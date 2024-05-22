// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.EnvironmentVariableDefinition
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("environmentvariabledefinition")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class EnvironmentVariableDefinition : 
    Entity,
    INotifyPropertyChanging,
    INotifyPropertyChanged
  {
    public const string EntityLogicalName = "environmentvariabledefinition";
    public const string EntitySchemaName = "EnvironmentVariableDefinition";
    public const string PrimaryIdAttribute = "environmentvariabledefinitionid";
    public const string PrimaryNameAttribute = "schemaname";

    public EnvironmentVariableDefinition()
      : base("environmentvariabledefinition")
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

    [AttributeLogicalName("apiid")]
    public string ApiId
    {
      get => this.GetAttributeValue<string>("apiid");
      set
      {
        this.OnPropertyChanging(nameof (ApiId));
        this.SetAttributeValue("apiid", (object) value);
        this.OnPropertyChanged(nameof (ApiId));
      }
    }

    [AttributeLogicalName("componentstate")]
    public OptionSetValue ComponentState
    {
      get => this.GetAttributeValue<OptionSetValue>("componentstate");
    }

    [AttributeLogicalName("connectionreferenceid")]
    public EntityReference ConnectionReferenceId
    {
      get => this.GetAttributeValue<EntityReference>("connectionreferenceid");
      set
      {
        this.OnPropertyChanging(nameof (ConnectionReferenceId));
        this.SetAttributeValue("connectionreferenceid", (object) value);
        this.OnPropertyChanged(nameof (ConnectionReferenceId));
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

    [AttributeLogicalName("environmentvariabledefinitionid")]
    public Guid? EnvironmentVariableDefinitionId
    {
      get => this.GetAttributeValue<Guid?>("environmentvariabledefinitionid");
      set
      {
        this.OnPropertyChanging(nameof (EnvironmentVariableDefinitionId));
        this.SetAttributeValue("environmentvariabledefinitionid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (EnvironmentVariableDefinitionId));
      }
    }

    [AttributeLogicalName("environmentvariabledefinitionid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.EnvironmentVariableDefinitionId = new Guid?(value);
    }

    [AttributeLogicalName("environmentvariabledefinitionidunique")]
    public Guid? EnvironmentVariableDefinitionIdUnique
    {
      get => this.GetAttributeValue<Guid?>("environmentvariabledefinitionidunique");
    }

    [AttributeLogicalName("hint")]
    public string Hint
    {
      get => this.GetAttributeValue<string>("hint");
      set
      {
        this.OnPropertyChanging(nameof (Hint));
        this.SetAttributeValue("hint", (object) value);
        this.OnPropertyChanged(nameof (Hint));
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

    [AttributeLogicalName("isrequired")]
    public bool? IsRequired
    {
      get => this.GetAttributeValue<bool?>("isrequired");
      set
      {
        this.OnPropertyChanging(nameof (IsRequired));
        this.SetAttributeValue("isrequired", (object) value);
        this.OnPropertyChanged(nameof (IsRequired));
      }
    }

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

    [AttributeLogicalName("ownerid")]
    public EntityReference OwnerId
    {
      get => this.GetAttributeValue<EntityReference>("ownerid");
      set
      {
        this.OnPropertyChanging(nameof (OwnerId));
        this.SetAttributeValue("ownerid", (object) value);
        this.OnPropertyChanged(nameof (OwnerId));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    public EntityReference OwningBusinessUnit
    {
      get => this.GetAttributeValue<EntityReference>("owningbusinessunit");
    }

    [AttributeLogicalName("owningteam")]
    public EntityReference OwningTeam => this.GetAttributeValue<EntityReference>("owningteam");

    [AttributeLogicalName("owninguser")]
    public EntityReference OwningUser => this.GetAttributeValue<EntityReference>("owninguser");

    [AttributeLogicalName("parameterkey")]
    public string ParameterKey
    {
      get => this.GetAttributeValue<string>("parameterkey");
      set
      {
        this.OnPropertyChanging(nameof (ParameterKey));
        this.SetAttributeValue("parameterkey", (object) value);
        this.OnPropertyChanged(nameof (ParameterKey));
      }
    }

    [AttributeLogicalName("parentdefinitionid")]
    public EntityReference ParentDefinitionId
    {
      get => this.GetAttributeValue<EntityReference>("parentdefinitionid");
      set
      {
        this.OnPropertyChanging(nameof (ParentDefinitionId));
        this.SetAttributeValue("parentdefinitionid", (object) value);
        this.OnPropertyChanged(nameof (ParentDefinitionId));
      }
    }

    [AttributeLogicalName("schemaname")]
    public string SchemaName
    {
      get => this.GetAttributeValue<string>("schemaname");
      set
      {
        this.OnPropertyChanging(nameof (SchemaName));
        this.SetAttributeValue("schemaname", (object) value);
        this.OnPropertyChanged(nameof (SchemaName));
      }
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("statecode")]
    public EnvironmentVariableDefinitionState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new EnvironmentVariableDefinitionState?((EnvironmentVariableDefinitionState) Enum.ToObject(typeof (EnvironmentVariableDefinitionState), attributeValue.Value)) : new EnvironmentVariableDefinitionState?();
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

    [AttributeLogicalName("valueschema")]
    public string ValueSchema
    {
      get => this.GetAttributeValue<string>("valueschema");
      set
      {
        this.OnPropertyChanging(nameof (ValueSchema));
        this.SetAttributeValue("valueschema", (object) value);
        this.OnPropertyChanged(nameof (ValueSchema));
      }
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName]
    public IEnumerable<EnvironmentVariableDefinition> Referencedenvdefinition_envdefinition
    {
      get
      {
        return this.GetRelatedEntities<EnvironmentVariableDefinition>("envdefinition_envdefinition", new EntityRole?((EntityRole) 1));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencedenvdefinition_envdefinition));
        this.SetRelatedEntities<EnvironmentVariableDefinition>("envdefinition_envdefinition", new EntityRole?((EntityRole) 1), value);
        this.OnPropertyChanged(nameof (Referencedenvdefinition_envdefinition));
      }
    }

    [RelationshipSchemaName("environmentvariabledefinition_AsyncOperations")]
    public IEnumerable<AsyncOperation> environmentvariabledefinition_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (environmentvariabledefinition_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (environmentvariabledefinition_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (environmentvariabledefinition_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (environmentvariabledefinition_AsyncOperations));
      }
    }

    [RelationshipSchemaName("environmentvariabledefinition_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> environmentvariabledefinition_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (environmentvariabledefinition_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (environmentvariabledefinition_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (environmentvariabledefinition_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (environmentvariabledefinition_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("environmentvariabledefinition_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> environmentvariabledefinition_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (environmentvariabledefinition_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (environmentvariabledefinition_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (environmentvariabledefinition_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (environmentvariabledefinition_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("environmentvariabledefinition_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> environmentvariabledefinition_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (environmentvariabledefinition_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (environmentvariabledefinition_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (environmentvariabledefinition_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (environmentvariabledefinition_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("environmentvariabledefinition_environmentvariablevalue")]
    public IEnumerable<EnvironmentVariableValue> environmentvariabledefinition_environmentvariablevalue
    {
      get
      {
        return this.GetRelatedEntities<EnvironmentVariableValue>(nameof (environmentvariabledefinition_environmentvariablevalue), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (environmentvariabledefinition_environmentvariablevalue));
        this.SetRelatedEntities<EnvironmentVariableValue>(nameof (environmentvariabledefinition_environmentvariablevalue), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (environmentvariabledefinition_environmentvariablevalue));
      }
    }

    [RelationshipSchemaName("environmentvariabledefinition_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> environmentvariabledefinition_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (environmentvariabledefinition_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (environmentvariabledefinition_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (environmentvariabledefinition_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (environmentvariabledefinition_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("environmentvariabledefinition_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> environmentvariabledefinition_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (environmentvariabledefinition_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (environmentvariabledefinition_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (environmentvariabledefinition_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (environmentvariabledefinition_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("environmentvariabledefinition_ProcessSession")]
    public IEnumerable<ProcessSession> environmentvariabledefinition_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (environmentvariabledefinition_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (environmentvariabledefinition_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (environmentvariabledefinition_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (environmentvariabledefinition_ProcessSession));
      }
    }

    [RelationshipSchemaName("environmentvariabledefinition_SyncErrors")]
    public IEnumerable<SyncError> environmentvariabledefinition_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (environmentvariabledefinition_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (environmentvariabledefinition_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (environmentvariabledefinition_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (environmentvariabledefinition_SyncErrors));
      }
    }

    [RelationshipSchemaName("environmentvariabledefinition_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> environmentvariabledefinition_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (environmentvariabledefinition_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (environmentvariabledefinition_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (environmentvariabledefinition_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (environmentvariabledefinition_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_environmentvariabledefinition")]
    public BusinessUnit business_unit_environmentvariabledefinition
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_environmentvariabledefinition), new EntityRole?());
      }
    }

    [AttributeLogicalName("parentdefinitionid")]
    [RelationshipSchemaName]
    public EnvironmentVariableDefinition Referencingenvdefinition_envdefinition
    {
      get
      {
        return this.GetRelatedEntity<EnvironmentVariableDefinition>("envdefinition_envdefinition", new EntityRole?((EntityRole) 0));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencingenvdefinition_envdefinition));
        this.SetRelatedEntity<EnvironmentVariableDefinition>("envdefinition_envdefinition", new EntityRole?((EntityRole) 0), value);
        this.OnPropertyChanged(nameof (Referencingenvdefinition_envdefinition));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_environmentvariabledefinition_createdby")]
    public SystemUser lk_environmentvariabledefinition_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_environmentvariabledefinition_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_environmentvariabledefinition_createdonbehalfby")]
    public SystemUser lk_environmentvariabledefinition_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_environmentvariabledefinition_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_environmentvariabledefinition_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_environmentvariabledefinition_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_environmentvariabledefinition_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_environmentvariabledefinition_modifiedby")]
    public SystemUser lk_environmentvariabledefinition_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_environmentvariabledefinition_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_environmentvariabledefinition_modifiedonbehalfby")]
    public SystemUser lk_environmentvariabledefinition_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_environmentvariabledefinition_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_environmentvariabledefinition_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_environmentvariabledefinition_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_environmentvariabledefinition_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_environmentvariabledefinition")]
    public Team team_environmentvariabledefinition
    {
      get
      {
        return this.GetRelatedEntity<Team>(nameof (team_environmentvariabledefinition), new EntityRole?());
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_environmentvariabledefinition")]
    public SystemUser user_environmentvariabledefinition
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_environmentvariabledefinition), new EntityRole?());
      }
    }

    public EnvironmentVariableDefinition(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["environmentvariabledefinitionid"] = (object) base.Id;
            break;
          case "environmentvariabledefinitionid":
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
