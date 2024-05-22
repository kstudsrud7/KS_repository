// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.SettingDefinition
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("settingdefinition")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class SettingDefinition : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "settingdefinition";
    public const string EntitySchemaName = "SettingDefinition";
    public const string PrimaryIdAttribute = "settingdefinitionid";
    public const string PrimaryNameAttribute = "displayname";

    public SettingDefinition()
      : base("settingdefinition")
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

    [AttributeLogicalName("canbecreatedbycomponentowningpublisher")]
    public bool? CanBeCreatedByComponentOwningPublisher
    {
      get => this.GetAttributeValue<bool?>("canbecreatedbycomponentowningpublisher");
      set
      {
        this.OnPropertyChanging(nameof (CanBeCreatedByComponentOwningPublisher));
        this.SetAttributeValue("canbecreatedbycomponentowningpublisher", (object) value);
        this.OnPropertyChanged(nameof (CanBeCreatedByComponentOwningPublisher));
      }
    }

    [AttributeLogicalName("category")]
    public OptionSetValue Category
    {
      get => this.GetAttributeValue<OptionSetValue>("category");
      set
      {
        this.OnPropertyChanging(nameof (Category));
        this.SetAttributeValue("category", (object) value);
        this.OnPropertyChanged(nameof (Category));
      }
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

    [AttributeLogicalName("datatype")]
    public OptionSetValue DataType
    {
      get => this.GetAttributeValue<OptionSetValue>("datatype");
      set
      {
        this.OnPropertyChanging(nameof (DataType));
        this.SetAttributeValue("datatype", (object) value);
        this.OnPropertyChanged(nameof (DataType));
      }
    }

    [AttributeLogicalName("defaultvalue")]
    public string DefaultValue
    {
      get => this.GetAttributeValue<string>("defaultvalue");
      set
      {
        this.OnPropertyChanging(nameof (DefaultValue));
        this.SetAttributeValue("defaultvalue", (object) value);
        this.OnPropertyChanged(nameof (DefaultValue));
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

    [AttributeLogicalName("helpurl")]
    public string HelpUrl
    {
      get => this.GetAttributeValue<string>("helpurl");
      set
      {
        this.OnPropertyChanging(nameof (HelpUrl));
        this.SetAttributeValue("helpurl", (object) value);
        this.OnPropertyChanged(nameof (HelpUrl));
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

    [AttributeLogicalName("scope")]
    public OptionSetValue Scope
    {
      get => this.GetAttributeValue<OptionSetValue>("scope");
      set
      {
        this.OnPropertyChanging(nameof (Scope));
        this.SetAttributeValue("scope", (object) value);
        this.OnPropertyChanged(nameof (Scope));
      }
    }

    [AttributeLogicalName("settingdefinitionid")]
    public Guid? SettingDefinitionId
    {
      get => this.GetAttributeValue<Guid?>("settingdefinitionid");
      set
      {
        this.OnPropertyChanging(nameof (SettingDefinitionId));
        this.SetAttributeValue("settingdefinitionid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (SettingDefinitionId));
      }
    }

    [AttributeLogicalName("settingdefinitionid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.SettingDefinitionId = new Guid?(value);
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("statecode")]
    public SettingDefinitionState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new SettingDefinitionState?((SettingDefinitionState) Enum.ToObject(typeof (SettingDefinitionState), attributeValue.Value)) : new SettingDefinitionState?();
      }
      set
      {
        this.OnPropertyChanging(nameof (statecode));
        if (!value.HasValue)
          this.SetAttributeValue(nameof (statecode), (object) null);
        else
          this.SetAttributeValue(nameof (statecode), (object) new OptionSetValue((int) value.Value));
        this.OnPropertyChanged(nameof (statecode));
      }
    }

    [AttributeLogicalName("statuscode")]
    public OptionSetValue StatusCode
    {
      get => this.GetAttributeValue<OptionSetValue>("statuscode");
      set
      {
        this.OnPropertyChanging(nameof (StatusCode));
        this.SetAttributeValue("statuscode", (object) value);
        this.OnPropertyChanged(nameof (StatusCode));
      }
    }

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

    [AttributeLogicalName("type")]
    public OptionSetValue Type
    {
      get => this.GetAttributeValue<OptionSetValue>("type");
      set
      {
        this.OnPropertyChanging(nameof (Type));
        this.SetAttributeValue("type", (object) value);
        this.OnPropertyChanged(nameof (Type));
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

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("settingdefinition_appsetting_settingdefinitionid")]
    public IEnumerable<AppSetting> settingdefinition_appsetting_settingdefinitionid
    {
      get
      {
        return this.GetRelatedEntities<AppSetting>(nameof (settingdefinition_appsetting_settingdefinitionid), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (settingdefinition_appsetting_settingdefinitionid));
        this.SetRelatedEntities<AppSetting>(nameof (settingdefinition_appsetting_settingdefinitionid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (settingdefinition_appsetting_settingdefinitionid));
      }
    }

    [RelationshipSchemaName("settingdefinition_AsyncOperations")]
    public IEnumerable<AsyncOperation> settingdefinition_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (settingdefinition_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (settingdefinition_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (settingdefinition_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (settingdefinition_AsyncOperations));
      }
    }

    [RelationshipSchemaName("settingdefinition_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> settingdefinition_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (settingdefinition_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (settingdefinition_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (settingdefinition_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (settingdefinition_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("settingdefinition_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> settingdefinition_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (settingdefinition_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (settingdefinition_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (settingdefinition_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (settingdefinition_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("settingdefinition_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> settingdefinition_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (settingdefinition_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (settingdefinition_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (settingdefinition_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (settingdefinition_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("settingdefinition_ProcessSession")]
    public IEnumerable<ProcessSession> settingdefinition_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (settingdefinition_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (settingdefinition_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (settingdefinition_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (settingdefinition_ProcessSession));
      }
    }

    [RelationshipSchemaName("settingdefinition_SyncErrors")]
    public IEnumerable<SyncError> settingdefinition_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (settingdefinition_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (settingdefinition_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (settingdefinition_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (settingdefinition_SyncErrors));
      }
    }

    [RelationshipSchemaName("settingdefinition_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> settingdefinition_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (settingdefinition_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (settingdefinition_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (settingdefinition_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (settingdefinition_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_settingdefinition_createdby")]
    public SystemUser lk_settingdefinition_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_settingdefinition_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_settingdefinition_createdonbehalfby")]
    public SystemUser lk_settingdefinition_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_settingdefinition_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_settingdefinition_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_settingdefinition_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_settingdefinition_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_settingdefinition_modifiedby")]
    public SystemUser lk_settingdefinition_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_settingdefinition_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_settingdefinition_modifiedonbehalfby")]
    public SystemUser lk_settingdefinition_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_settingdefinition_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_settingdefinition_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_settingdefinition_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_settingdefinition_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_settingdefinition")]
    public Organization organization_settingdefinition
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_settingdefinition), new EntityRole?());
      }
    }

    public SettingDefinition(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["settingdefinitionid"] = (object) base.Id;
            break;
          case "settingdefinitionid":
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
