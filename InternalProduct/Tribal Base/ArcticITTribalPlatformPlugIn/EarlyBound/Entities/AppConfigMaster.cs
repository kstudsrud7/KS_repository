// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.AppConfigMaster
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("appconfigmaster")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class AppConfigMaster : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "appconfigmaster";
    public const string EntitySchemaName = "AppConfigMaster";
    public const string PrimaryIdAttribute = "appconfigmasterid";
    public const string PrimaryNameAttribute = "name";

    public AppConfigMaster()
      : base("appconfigmaster")
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

    [AttributeLogicalName("appconfigmasterid")]
    public Guid? AppConfigMasterId => this.GetAttributeValue<Guid?>("appconfigmasterid");

    [AttributeLogicalName("appconfigmasterid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => base.Id = value;
    }

    [AttributeLogicalName("configtype")]
    public string ConfigType => this.GetAttributeValue<string>("configtype");

    [AttributeLogicalName("createdby")]
    public EntityReference CreatedBy => this.GetAttributeValue<EntityReference>("createdby");

    [AttributeLogicalName("createdon")]
    public DateTime? CreatedOn => this.GetAttributeValue<DateTime?>("createdon");

    [AttributeLogicalName("createdonbehalfby")]
    public EntityReference CreatedOnBehalfBy
    {
      get => this.GetAttributeValue<EntityReference>("createdonbehalfby");
      set
      {
        this.OnPropertyChanging(nameof (CreatedOnBehalfBy));
        this.SetAttributeValue("createdonbehalfby", (object) value);
        this.OnPropertyChanged(nameof (CreatedOnBehalfBy));
      }
    }

    [AttributeLogicalName("defaultvalue")]
    public string DefaultValue => this.GetAttributeValue<string>("defaultvalue");

    [AttributeLogicalName("importsequencenumber")]
    public int? ImportSequenceNumber => this.GetAttributeValue<int?>("importsequencenumber");

    [AttributeLogicalName("isnavigationsetting")]
    public int? IsNavigationSetting => this.GetAttributeValue<int?>("isnavigationsetting");

    [AttributeLogicalName("modifiedby")]
    public EntityReference ModifiedBy => this.GetAttributeValue<EntityReference>("modifiedby");

    [AttributeLogicalName("modifiedon")]
    public DateTime? ModifiedOn => this.GetAttributeValue<DateTime?>("modifiedon");

    [AttributeLogicalName("modifiedonbehalfby")]
    public EntityReference ModifiedOnBehalfBy
    {
      get => this.GetAttributeValue<EntityReference>("modifiedonbehalfby");
      set
      {
        this.OnPropertyChanging(nameof (ModifiedOnBehalfBy));
        this.SetAttributeValue("modifiedonbehalfby", (object) value);
        this.OnPropertyChanged(nameof (ModifiedOnBehalfBy));
      }
    }

    [AttributeLogicalName("name")]
    public string Name
    {
      get => this.GetAttributeValue<string>("name");
      set
      {
        this.OnPropertyChanging(nameof (Name));
        this.SetAttributeValue("name", (object) value);
        this.OnPropertyChanged(nameof (Name));
      }
    }

    [AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get => this.GetAttributeValue<EntityReference>("organizationid");
    }

    [AttributeLogicalName("overriddencreatedon")]
    public DateTime? OverriddenCreatedOn
    {
      get => this.GetAttributeValue<DateTime?>("overriddencreatedon");
      set
      {
        this.OnPropertyChanging(nameof (OverriddenCreatedOn));
        this.SetAttributeValue("overriddencreatedon", (object) value);
        this.OnPropertyChanged(nameof (OverriddenCreatedOn));
      }
    }

    [AttributeLogicalName("parentappconfigmasterid")]
    public string ParentAppConfigMasterId
    {
      get => this.GetAttributeValue<string>("parentappconfigmasterid");
    }

    [AttributeLogicalName("validator")]
    public string Validator => this.GetAttributeValue<string>("validator");

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("appconfigmaster_appconfiginstance")]
    public IEnumerable<AppConfigInstance> appconfigmaster_appconfiginstance
    {
      get
      {
        return this.GetRelatedEntities<AppConfigInstance>(nameof (appconfigmaster_appconfiginstance), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appconfigmaster_appconfiginstance));
        this.SetRelatedEntities<AppConfigInstance>(nameof (appconfigmaster_appconfiginstance), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appconfigmaster_appconfiginstance));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_appconfigmaster_createdby")]
    public SystemUser lk_appconfigmaster_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_appconfigmaster_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_appconfigmaster_createdonbehalfby")]
    public SystemUser lk_appconfigmaster_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_appconfigmaster_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_appconfigmaster_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_appconfigmaster_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_appconfigmaster_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_appconfigmaster_modifiedby")]
    public SystemUser lk_appconfigmaster_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_appconfigmaster_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_appconfigmaster_modifiedonbehalfby")]
    public SystemUser lk_appconfigmaster_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_appconfigmaster_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_appconfigmaster_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_appconfigmaster_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_appconfigmaster_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_appconfigmaster")]
    public Organization organization_appconfigmaster
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_appconfigmaster), new EntityRole?());
      }
    }

    public AppConfigMaster(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["appconfigmasterid"] = (object) base.Id;
            break;
          case "appconfigmasterid":
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
