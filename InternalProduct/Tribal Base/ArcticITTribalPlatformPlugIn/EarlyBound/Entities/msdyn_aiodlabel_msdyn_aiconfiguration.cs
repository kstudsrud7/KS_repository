// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.msdyn_aiodlabel_msdyn_aiconfiguration
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("msdyn_aiodlabel_msdyn_aiconfiguration")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class msdyn_aiodlabel_msdyn_aiconfiguration : 
    Entity,
    INotifyPropertyChanging,
    INotifyPropertyChanged
  {
    public const string EntityLogicalName = "msdyn_aiodlabel_msdyn_aiconfiguration";
    public const string EntitySchemaName = "msdyn_aiodlabel_msdyn_aiconfiguration";
    public const string PrimaryIdAttribute = "msdyn_aiodlabel_msdyn_aiconfigurationid";

    public msdyn_aiodlabel_msdyn_aiconfiguration()
      : base(nameof (msdyn_aiodlabel_msdyn_aiconfiguration))
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

    [AttributeLogicalName("msdyn_aiconfigurationid")]
    public Guid? msdyn_aiconfigurationid
    {
      get => this.GetAttributeValue<Guid?>(nameof (msdyn_aiconfigurationid));
    }

    [AttributeLogicalName("msdyn_aiodlabel_msdyn_aiconfigurationid")]
    public Guid? msdyn_aiodlabel_msdyn_aiconfigurationId
    {
      get => this.GetAttributeValue<Guid?>("msdyn_aiodlabel_msdyn_aiconfigurationid");
    }

    [AttributeLogicalName("msdyn_aiodlabel_msdyn_aiconfigurationid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => base.Id = value;
    }

    [AttributeLogicalName("msdyn_aiodlabelid")]
    public Guid? msdyn_aiodlabelid => this.GetAttributeValue<Guid?>(nameof (msdyn_aiodlabelid));

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("msdyn_aiodlabel_msdyn_aiconfiguration")]
    public IEnumerable<msdyn_AIOdLabel> msdyn_aiodlabel_msdyn_aiconfiguration1
    {
      get
      {
        return this.GetRelatedEntities<msdyn_AIOdLabel>(nameof (msdyn_aiodlabel_msdyn_aiconfiguration), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodlabel_msdyn_aiconfiguration1));
        this.SetRelatedEntities<msdyn_AIOdLabel>(nameof (msdyn_aiodlabel_msdyn_aiconfiguration), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodlabel_msdyn_aiconfiguration1));
      }
    }

    public msdyn_aiodlabel_msdyn_aiconfiguration(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["msdyn_aiodlabel_msdyn_aiconfigurationid"] = (object) base.Id;
            break;
          case "msdyn_aiodlabel_msdyn_aiconfigurationid":
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
