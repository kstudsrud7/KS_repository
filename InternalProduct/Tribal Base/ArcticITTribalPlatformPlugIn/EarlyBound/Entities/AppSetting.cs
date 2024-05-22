// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.AppSetting
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("appsetting")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class AppSetting : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "appsetting";
    public const string EntitySchemaName = "AppSetting";
    public const string PrimaryIdAttribute = "appsettingid";
    public const string PrimaryNameAttribute = "displayname";

    public AppSetting()
      : base("appsetting")
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

    [AttributeLogicalName("appsettingid")]
    public Guid? AppSettingId
    {
      get => this.GetAttributeValue<Guid?>("appsettingid");
      set
      {
        this.OnPropertyChanging(nameof (AppSettingId));
        this.SetAttributeValue("appsettingid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (AppSettingId));
      }
    }

    [AttributeLogicalName("appsettingid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.AppSettingId = new Guid?(value);
    }

    [AttributeLogicalName("componentidunique")]
    public Guid? ComponentIdUnique => this.GetAttributeValue<Guid?>("componentidunique");

    [AttributeLogicalName("componentstate")]
    public OptionSetValue ComponentState
    {
      get => this.GetAttributeValue<OptionSetValue>("componentstate");
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

    [AttributeLogicalName("description")]
    public string Description
    {
      get => this.GetAttributeValue<string>("description");
      set
      {
        this.OnPropertyChanging(nameof (Description));
        this.SetAttributeValue("description", (object) value);
        this.OnPropertyChanged(nameof (Description));
      }
    }

    [AttributeLogicalName("displayname")]
    public string DisplayName
    {
      get => this.GetAttributeValue<string>("displayname");
      set
      {
        this.OnPropertyChanging(nameof (DisplayName));
        this.SetAttributeValue("displayname", (object) value);
        this.OnPropertyChanged(nameof (DisplayName));
      }
    }

    [AttributeLogicalName("importsequencenumber")]
    public int? ImportSequenceNumber
    {
      get => this.GetAttributeValue<int?>("importsequencenumber");
      set
      {
        this.OnPropertyChanging(nameof (ImportSequenceNumber));
        this.SetAttributeValue("importsequencenumber", (object) value);
        this.OnPropertyChanged(nameof (ImportSequenceNumber));
      }
    }

    [AttributeLogicalName("iscustomizable")]
    public BooleanManagedProperty IsCustomizable
    {
      get => this.GetAttributeValue<BooleanManagedProperty>("iscustomizable");
      set
      {
        this.OnPropertyChanging(nameof (IsCustomizable));
        this.SetAttributeValue("iscustomizable", (object) value);
        this.OnPropertyChanged(nameof (IsCustomizable));
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

    [AttributeLogicalName("parentappmoduleid")]
    public EntityReference ParentAppModuleId
    {
      get => this.GetAttributeValue<EntityReference>("parentappmoduleid");
      set
      {
        this.OnPropertyChanging(nameof (ParentAppModuleId));
        this.SetAttributeValue("parentappmoduleid", (object) value);
        this.OnPropertyChanged(nameof (ParentAppModuleId));
      }
    }

    [AttributeLogicalName("settingdefinitionid")]
    public EntityReference SettingDefinitionId
    {
      get => this.GetAttributeValue<EntityReference>("settingdefinitionid");
      set
      {
        this.OnPropertyChanging(nameof (SettingDefinitionId));
        this.SetAttributeValue("settingdefinitionid", (object) value);
        this.OnPropertyChanged(nameof (SettingDefinitionId));
      }
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("statecode")]
    public AppSettingState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new AppSettingState?((AppSettingState) Enum.ToObject(typeof (AppSettingState), attributeValue.Value)) : new AppSettingState?();
      }
    }

    [AttributeLogicalName("statuscode")]
    public OptionSetValue StatusCode => this.GetAttributeValue<OptionSetValue>("statuscode");

    [AttributeLogicalName("timezoneruleversionnumber")]
    public int? TimeZoneRuleVersionNumber
    {
      get => this.GetAttributeValue<int?>("timezoneruleversionnumber");
      set
      {
        this.OnPropertyChanging(nameof (TimeZoneRuleVersionNumber));
        this.SetAttributeValue("timezoneruleversionnumber", (object) value);
        this.OnPropertyChanged(nameof (TimeZoneRuleVersionNumber));
      }
    }

    [AttributeLogicalName("uniquename")]
    public string UniqueName
    {
      get => this.GetAttributeValue<string>("uniquename");
      set
      {
        this.OnPropertyChanging(nameof (UniqueName));
        this.SetAttributeValue("uniquename", (object) value);
        this.OnPropertyChanged(nameof (UniqueName));
      }
    }

    [AttributeLogicalName("utcconversiontimezonecode")]
    public int? UTCConversionTimeZoneCode
    {
      get => this.GetAttributeValue<int?>("utcconversiontimezonecode");
      set
      {
        this.OnPropertyChanging(nameof (UTCConversionTimeZoneCode));
        this.SetAttributeValue("utcconversiontimezonecode", (object) value);
        this.OnPropertyChanged(nameof (UTCConversionTimeZoneCode));
      }
    }

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

    [RelationshipSchemaName("appsetting_AsyncOperations")]
    public IEnumerable<AsyncOperation> appsetting_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (appsetting_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appsetting_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (appsetting_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appsetting_AsyncOperations));
      }
    }

    [RelationshipSchemaName("appsetting_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> appsetting_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (appsetting_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appsetting_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (appsetting_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appsetting_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("appsetting_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> appsetting_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (appsetting_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appsetting_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (appsetting_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appsetting_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("appsetting_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> appsetting_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (appsetting_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appsetting_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (appsetting_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appsetting_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("appsetting_ProcessSession")]
    public IEnumerable<ProcessSession> appsetting_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (appsetting_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appsetting_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (appsetting_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appsetting_ProcessSession));
      }
    }

    [RelationshipSchemaName("appsetting_SyncErrors")]
    public IEnumerable<SyncError> appsetting_SyncErrors
    {
      get => this.GetRelatedEntities<SyncError>(nameof (appsetting_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (appsetting_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (appsetting_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appsetting_SyncErrors));
      }
    }

    [RelationshipSchemaName("appsetting_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> appsetting_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (appsetting_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appsetting_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (appsetting_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appsetting_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("parentappmoduleid")]
    [RelationshipSchemaName("appmodule_appsetting_parentappmoduleid")]
    public AppModule appmodule_appsetting_parentappmoduleid
    {
      get
      {
        return this.GetRelatedEntity<AppModule>(nameof (appmodule_appsetting_parentappmoduleid), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appmodule_appsetting_parentappmoduleid));
        this.SetRelatedEntity<AppModule>(nameof (appmodule_appsetting_parentappmoduleid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appmodule_appsetting_parentappmoduleid));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_appsetting_createdby")]
    public SystemUser lk_appsetting_createdby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_appsetting_createdby), new EntityRole?());
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_appsetting_createdonbehalfby")]
    public SystemUser lk_appsetting_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_appsetting_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_appsetting_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_appsetting_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_appsetting_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_appsetting_modifiedby")]
    public SystemUser lk_appsetting_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_appsetting_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_appsetting_modifiedonbehalfby")]
    public SystemUser lk_appsetting_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_appsetting_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_appsetting_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_appsetting_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_appsetting_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_appsetting")]
    public Organization organization_appsetting
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_appsetting), new EntityRole?());
      }
    }

    [AttributeLogicalName("settingdefinitionid")]
    [RelationshipSchemaName("settingdefinition_appsetting_settingdefinitionid")]
    public SettingDefinition settingdefinition_appsetting_settingdefinitionid
    {
      get
      {
        return this.GetRelatedEntity<SettingDefinition>(nameof (settingdefinition_appsetting_settingdefinitionid), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (settingdefinition_appsetting_settingdefinitionid));
        this.SetRelatedEntity<SettingDefinition>(nameof (settingdefinition_appsetting_settingdefinitionid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (settingdefinition_appsetting_settingdefinitionid));
      }
    }

    public AppSetting(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["appsettingid"] = (object) base.Id;
            break;
          case "appsettingid":
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
