// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.AppConfigInstance
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("appconfiginstance")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class AppConfigInstance : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "appconfiginstance";
    public const string EntitySchemaName = "AppConfigInstance";
    public const string PrimaryIdAttribute = "appconfiginstanceid";

    public AppConfigInstance()
      : base("appconfiginstance")
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

    [AttributeLogicalName("appconfigid")]
    public EntityReference AppConfigId
    {
      get => this.GetAttributeValue<EntityReference>("appconfigid");
      set
      {
        this.OnPropertyChanging(nameof (AppConfigId));
        this.SetAttributeValue("appconfigid", (object) value);
        this.OnPropertyChanged(nameof (AppConfigId));
      }
    }

    [AttributeLogicalName("appconfigidunique")]
    public Guid? AppConfigIdUnique
    {
      get => this.GetAttributeValue<Guid?>("appconfigidunique");
      set
      {
        this.OnPropertyChanging(nameof (AppConfigIdUnique));
        this.SetAttributeValue("appconfigidunique", (object) value);
        this.OnPropertyChanged(nameof (AppConfigIdUnique));
      }
    }

    [AttributeLogicalName("appconfiginstanceid")]
    public Guid? AppConfigInstanceId => this.GetAttributeValue<Guid?>("appconfiginstanceid");

    [AttributeLogicalName("appconfiginstanceid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => base.Id = value;
    }

    [AttributeLogicalName("appconfiginstanceidunique")]
    public Guid? AppConfigInstanceIdUnique
    {
      get => this.GetAttributeValue<Guid?>("appconfiginstanceidunique");
      set
      {
        this.OnPropertyChanging(nameof (AppConfigInstanceIdUnique));
        this.SetAttributeValue("appconfiginstanceidunique", (object) value);
        this.OnPropertyChanged(nameof (AppConfigInstanceIdUnique));
      }
    }

    [AttributeLogicalName("appconfigmasterid")]
    public EntityReference AppConfigMasterId
    {
      get => this.GetAttributeValue<EntityReference>("appconfigmasterid");
      set
      {
        this.OnPropertyChanging(nameof (AppConfigMasterId));
        this.SetAttributeValue("appconfigmasterid", (object) value);
        this.OnPropertyChanged(nameof (AppConfigMasterId));
      }
    }

    [AttributeLogicalName("componentstate")]
    public OptionSetValue ComponentState
    {
      get => this.GetAttributeValue<OptionSetValue>("componentstate");
    }

    [AttributeLogicalName("componenttype")]
    public string ComponentType
    {
      get => this.GetAttributeValue<string>("componenttype");
      set
      {
        this.OnPropertyChanging(nameof (ComponentType));
        this.SetAttributeValue("componenttype", (object) value);
        this.OnPropertyChanged(nameof (ComponentType));
      }
    }

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

    [AttributeLogicalName("importsequencenumber")]
    public int? ImportSequenceNumber => this.GetAttributeValue<int?>("importsequencenumber");

    [AttributeLogicalName("introducedversion")]
    public string IntroducedVersion
    {
      get => this.GetAttributeValue<string>("introducedversion");
      set
      {
        this.OnPropertyChanging(nameof (IntroducedVersion));
        this.SetAttributeValue("introducedversion", (object) value);
        this.OnPropertyChanged(nameof (IntroducedVersion));
      }
    }

    [AttributeLogicalName("ismanaged")]
    public bool? IsManaged => this.GetAttributeValue<bool?>("ismanaged");

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

    [AttributeLogicalName("objectid")]
    public Guid? ObjectId
    {
      get => this.GetAttributeValue<Guid?>("objectid");
      set
      {
        this.OnPropertyChanging(nameof (ObjectId));
        this.SetAttributeValue("objectid", (object) value);
        this.OnPropertyChanged(nameof (ObjectId));
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

    [AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime => this.GetAttributeValue<DateTime?>("overwritetime");

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("value")]
    public string Value
    {
      get => this.GetAttributeValue<string>("value");
      set
      {
        this.OnPropertyChanging(nameof (Value));
        this.SetAttributeValue(nameof (value), (object) value);
        this.OnPropertyChanged(nameof (Value));
      }
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [AttributeLogicalName("appconfigid")]
    [RelationshipSchemaName("appconfig_appconfiginstance")]
    public AppConfig appconfig_appconfiginstance
    {
      get
      {
        return this.GetRelatedEntity<AppConfig>(nameof (appconfig_appconfiginstance), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appconfig_appconfiginstance));
        this.SetRelatedEntity<AppConfig>(nameof (appconfig_appconfiginstance), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appconfig_appconfiginstance));
      }
    }

    [AttributeLogicalName("appconfigmasterid")]
    [RelationshipSchemaName("appconfigmaster_appconfiginstance")]
    public AppConfigMaster appconfigmaster_appconfiginstance
    {
      get
      {
        return this.GetRelatedEntity<AppConfigMaster>(nameof (appconfigmaster_appconfiginstance), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appconfigmaster_appconfiginstance));
        this.SetRelatedEntity<AppConfigMaster>(nameof (appconfigmaster_appconfiginstance), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appconfigmaster_appconfiginstance));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_appconfiginstance_createdby")]
    public SystemUser lk_appconfiginstance_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_appconfiginstance_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_appconfiginstance_createdonbehalfby")]
    public SystemUser lk_appconfiginstance_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_appconfiginstance_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_appconfiginstance_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_appconfiginstance_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_appconfiginstance_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_appconfiginstance_modifiedby")]
    public SystemUser lk_appconfiginstance_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_appconfiginstance_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_appconfiginstance_modifiedonbehalfby")]
    public SystemUser lk_appconfiginstance_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_appconfiginstance_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_appconfiginstance_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_appconfiginstance_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_appconfiginstance_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_appconfiginstance")]
    public Organization organization_appconfiginstance
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_appconfiginstance), new EntityRole?());
      }
    }

    public AppConfigInstance(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["appconfiginstanceid"] = (object) base.Id;
            break;
          case "appconfiginstanceid":
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
