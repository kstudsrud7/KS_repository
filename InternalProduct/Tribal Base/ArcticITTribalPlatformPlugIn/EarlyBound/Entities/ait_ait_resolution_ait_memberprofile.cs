﻿// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_ait_resolution_ait_memberprofile
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using Microsoft.Xrm.Sdk;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.Serialization;

#nullable disable
namespace ArcticIT.EarlyBound.Entities
{
  [DataContract]
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_ait_resolution_ait_memberprofile")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_ait_resolution_ait_memberprofile : 
    Entity,
    INotifyPropertyChanging,
    INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_ait_resolution_ait_memberprofile";
    public const string EntitySchemaName = "ait_ait_resolution_ait_memberprofile";
    public const string PrimaryIdAttribute = "ait_ait_resolution_ait_memberprofileid";

    public ait_ait_resolution_ait_memberprofile()
      : base(nameof (ait_ait_resolution_ait_memberprofile))
    {
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public event PropertyChangingEventHandler PropertyChanging;

    private void OnPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void OnPropertyChanging(string propertyName)
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, new PropertyChangingEventArgs(propertyName));
    }

    [AttributeLogicalName("ait_ait_resolution_ait_memberprofileid")]
    public Guid? ait_ait_resolution_ait_memberprofileId
    {
      get => this.GetAttributeValue<Guid?>("ait_ait_resolution_ait_memberprofileid");
    }

    [AttributeLogicalName("ait_ait_resolution_ait_memberprofileid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => base.Id = value;
    }

    [AttributeLogicalName("ait_memberprofileid")]
    public Guid? ait_memberprofileid => this.GetAttributeValue<Guid?>(nameof (ait_memberprofileid));

    [AttributeLogicalName("ait_resolutionid")]
    public Guid? ait_resolutionid => this.GetAttributeValue<Guid?>(nameof (ait_resolutionid));

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("ait_ait_resolution_ait_memberprofile")]
    public IEnumerable<ait_resolution> ait_ait_resolution_ait_memberprofile1
    {
      get
      {
        return this.GetRelatedEntities<ait_resolution>(nameof (ait_ait_resolution_ait_memberprofile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_resolution_ait_memberprofile1));
        this.SetRelatedEntities<ait_resolution>(nameof (ait_ait_resolution_ait_memberprofile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_resolution_ait_memberprofile1));
      }
    }

    public ait_ait_resolution_ait_memberprofile(object anonymousType)
      : this()
    {
      foreach (PropertyInfo property in anonymousType.GetType().GetProperties())
      {
        object obj = property.GetValue(anonymousType, (object[]) null);
        string str = property.Name.ToLower();
        if (str.EndsWith("enum") && obj.GetType().BaseType == typeof (Enum))
        {
          obj = (object) new OptionSetValue((int) obj);
          str = str.Remove(str.Length - "enum".Length);
        }
        switch (str)
        {
          case "id":
            base.Id = (Guid) obj;
            ((DataCollection<string, object>) this.Attributes)["ait_ait_resolution_ait_memberprofileid"] = (object) base.Id;
            break;
          case "ait_ait_resolution_ait_memberprofileid":
            Guid? nullable = (Guid?) obj;
            if (nullable.HasValue)
            {
              base.Id = nullable.Value;
              ((DataCollection<string, object>) this.Attributes)[str] = (object) base.Id;
              break;
            }
            continue;
          case "formattedvalues":
            ((DataCollection<string, string>) this.FormattedValues).AddRange((IEnumerable<KeyValuePair<string, string>>) obj);
            break;
          default:
            ((DataCollection<string, object>) this.Attributes)[str] = obj;
            break;
        }
      }
    }
  }
}
