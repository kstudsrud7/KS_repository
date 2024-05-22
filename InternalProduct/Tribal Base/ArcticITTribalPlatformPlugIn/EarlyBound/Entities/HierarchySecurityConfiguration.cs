// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.HierarchySecurityConfiguration
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("hierarchysecurityconfiguration")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class HierarchySecurityConfiguration : 
    Entity,
    INotifyPropertyChanging,
    INotifyPropertyChanged
  {
    public const string EntityLogicalName = "hierarchysecurityconfiguration";
    public const string EntitySchemaName = "HierarchySecurityConfiguration";
    public const string PrimaryIdAttribute = "hierarchysecuritymodelingsettingid";

    public HierarchySecurityConfiguration()
      : base("hierarchysecurityconfiguration")
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

    [AttributeLogicalName("entityname")]
    public string EntityName
    {
      get => this.GetAttributeValue<string>("entityname");
      set
      {
        this.OnPropertyChanging(nameof (EntityName));
        this.SetAttributeValue("entityname", (object) value);
        this.OnPropertyChanged(nameof (EntityName));
      }
    }

    [AttributeLogicalName("hierarchysecuritymodelingsettingid")]
    public Guid? HierarchySecurityModelingSettingId
    {
      get => this.GetAttributeValue<Guid?>("hierarchysecuritymodelingsettingid");
      set
      {
        this.OnPropertyChanging(nameof (HierarchySecurityModelingSettingId));
        this.SetAttributeValue("hierarchysecuritymodelingsettingid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (HierarchySecurityModelingSettingId));
      }
    }

    [AttributeLogicalName("hierarchysecuritymodelingsettingid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.HierarchySecurityModelingSettingId = new Guid?(value);
    }

    [AttributeLogicalName("objecttypecode")]
    public string ObjectTypeCode
    {
      get => this.GetAttributeValue<string>("objecttypecode");
      set
      {
        this.OnPropertyChanging(nameof (ObjectTypeCode));
        this.SetAttributeValue("objecttypecode", (object) value);
        this.OnPropertyChanged(nameof (ObjectTypeCode));
      }
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber
    {
      get => this.GetAttributeValue<long?>("versionnumber");
      set
      {
        this.OnPropertyChanging(nameof (VersionNumber));
        this.SetAttributeValue("versionnumber", (object) value);
        this.OnPropertyChanged(nameof (VersionNumber));
      }
    }

    public HierarchySecurityConfiguration(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["hierarchysecuritymodelingsettingid"] = (object) base.Id;
            break;
          case "hierarchysecuritymodelingsettingid":
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
