// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_ait_committeemeeting_ait_committeemembe
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_ait_committeemeeting_ait_committeemembe")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_ait_committeemeeting_ait_committeemembe : 
    Entity,
    INotifyPropertyChanging,
    INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_ait_committeemeeting_ait_committeemembe";
    public const string EntitySchemaName = "ait_ait_committeemeeting_ait_committeemembe";
    public const string PrimaryIdAttribute = "ait_ait_committeemeeting_ait_committeemembeid";

    public ait_ait_committeemeeting_ait_committeemembe()
      : base(nameof (ait_ait_committeemeeting_ait_committeemembe))
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

    [AttributeLogicalName("ait_ait_committeemeeting_ait_committeemembeid")]
    public Guid? ait_ait_committeemeeting_ait_committeemembeId
    {
      get => this.GetAttributeValue<Guid?>("ait_ait_committeemeeting_ait_committeemembeid");
    }

    [AttributeLogicalName("ait_ait_committeemeeting_ait_committeemembeid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => base.Id = value;
    }

    [AttributeLogicalName("ait_committeemeetingid")]
    public Guid? ait_committeemeetingid
    {
      get => this.GetAttributeValue<Guid?>(nameof (ait_committeemeetingid));
    }

    [AttributeLogicalName("ait_committeememberid")]
    public Guid? ait_committeememberid
    {
      get => this.GetAttributeValue<Guid?>(nameof (ait_committeememberid));
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("ait_ait_committeemeeting_ait_committeemember")]
    public IEnumerable<ait_committeemeeting> ait_ait_committeemeeting_ait_committeemember
    {
      get
      {
        return this.GetRelatedEntities<ait_committeemeeting>(nameof (ait_ait_committeemeeting_ait_committeemember), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_committeemeeting_ait_committeemember));
        this.SetRelatedEntities<ait_committeemeeting>(nameof (ait_ait_committeemeeting_ait_committeemember), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_committeemeeting_ait_committeemember));
      }
    }

    public ait_ait_committeemeeting_ait_committeemembe(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_ait_committeemeeting_ait_committeemembeid"] = (object) base.Id;
            break;
          case "ait_ait_committeemeeting_ait_committeemembeid":
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
