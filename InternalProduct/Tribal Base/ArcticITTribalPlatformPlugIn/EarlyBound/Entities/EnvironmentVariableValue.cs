// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.EnvironmentVariableValue
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("environmentvariablevalue")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class EnvironmentVariableValue : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "environmentvariablevalue";
    public const string EntitySchemaName = "EnvironmentVariableValue";
    public const string PrimaryIdAttribute = "environmentvariablevalueid";
    public const string PrimaryNameAttribute = "schemaname";

    public EnvironmentVariableValue()
      : base("environmentvariablevalue")
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

    [AttributeLogicalName("environmentvariabledefinitionid")]
    public EntityReference EnvironmentVariableDefinitionId
    {
      get => this.GetAttributeValue<EntityReference>("environmentvariabledefinitionid");
      set
      {
        this.OnPropertyChanging(nameof (EnvironmentVariableDefinitionId));
        this.SetAttributeValue("environmentvariabledefinitionid", (object) value);
        this.OnPropertyChanged(nameof (EnvironmentVariableDefinitionId));
      }
    }

    [AttributeLogicalName("environmentvariablevalueid")]
    public Guid? EnvironmentVariableValueId
    {
      get => this.GetAttributeValue<Guid?>("environmentvariablevalueid");
      set
      {
        this.OnPropertyChanging(nameof (EnvironmentVariableValueId));
        this.SetAttributeValue("environmentvariablevalueid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (EnvironmentVariableValueId));
      }
    }

    [AttributeLogicalName("environmentvariablevalueid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.EnvironmentVariableValueId = new Guid?(value);
    }

    [AttributeLogicalName("environmentvariablevalueidunique")]
    public Guid? EnvironmentVariableValueIdUnique
    {
      get => this.GetAttributeValue<Guid?>("environmentvariablevalueidunique");
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
    public EnvironmentVariableValueState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new EnvironmentVariableValueState?((EnvironmentVariableValueState) Enum.ToObject(typeof (EnvironmentVariableValueState), attributeValue.Value)) : new EnvironmentVariableValueState?();
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

    [RelationshipSchemaName("environmentvariablevalue_AsyncOperations")]
    public IEnumerable<AsyncOperation> environmentvariablevalue_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (environmentvariablevalue_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (environmentvariablevalue_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (environmentvariablevalue_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (environmentvariablevalue_AsyncOperations));
      }
    }

    [RelationshipSchemaName("environmentvariablevalue_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> environmentvariablevalue_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (environmentvariablevalue_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (environmentvariablevalue_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (environmentvariablevalue_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (environmentvariablevalue_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("environmentvariablevalue_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> environmentvariablevalue_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (environmentvariablevalue_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (environmentvariablevalue_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (environmentvariablevalue_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (environmentvariablevalue_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("environmentvariablevalue_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> environmentvariablevalue_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (environmentvariablevalue_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (environmentvariablevalue_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (environmentvariablevalue_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (environmentvariablevalue_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("environmentvariablevalue_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> environmentvariablevalue_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (environmentvariablevalue_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (environmentvariablevalue_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (environmentvariablevalue_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (environmentvariablevalue_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("environmentvariablevalue_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> environmentvariablevalue_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (environmentvariablevalue_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (environmentvariablevalue_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (environmentvariablevalue_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (environmentvariablevalue_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("environmentvariablevalue_ProcessSession")]
    public IEnumerable<ProcessSession> environmentvariablevalue_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (environmentvariablevalue_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (environmentvariablevalue_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (environmentvariablevalue_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (environmentvariablevalue_ProcessSession));
      }
    }

    [RelationshipSchemaName("environmentvariablevalue_SyncErrors")]
    public IEnumerable<SyncError> environmentvariablevalue_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (environmentvariablevalue_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (environmentvariablevalue_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (environmentvariablevalue_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (environmentvariablevalue_SyncErrors));
      }
    }

    [RelationshipSchemaName("environmentvariablevalue_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> environmentvariablevalue_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (environmentvariablevalue_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (environmentvariablevalue_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (environmentvariablevalue_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (environmentvariablevalue_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_environmentvariablevalue")]
    public BusinessUnit business_unit_environmentvariablevalue
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_environmentvariablevalue), new EntityRole?());
      }
    }

    [AttributeLogicalName("environmentvariabledefinitionid")]
    [RelationshipSchemaName("environmentvariabledefinition_environmentvariablevalue")]
    public EnvironmentVariableDefinition environmentvariabledefinition_environmentvariablevalue
    {
      get
      {
        return this.GetRelatedEntity<EnvironmentVariableDefinition>(nameof (environmentvariabledefinition_environmentvariablevalue), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (environmentvariabledefinition_environmentvariablevalue));
        this.SetRelatedEntity<EnvironmentVariableDefinition>(nameof (environmentvariabledefinition_environmentvariablevalue), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (environmentvariabledefinition_environmentvariablevalue));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_environmentvariablevalue_createdby")]
    public SystemUser lk_environmentvariablevalue_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_environmentvariablevalue_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_environmentvariablevalue_createdonbehalfby")]
    public SystemUser lk_environmentvariablevalue_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_environmentvariablevalue_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_environmentvariablevalue_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_environmentvariablevalue_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_environmentvariablevalue_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_environmentvariablevalue_modifiedby")]
    public SystemUser lk_environmentvariablevalue_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_environmentvariablevalue_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_environmentvariablevalue_modifiedonbehalfby")]
    public SystemUser lk_environmentvariablevalue_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_environmentvariablevalue_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_environmentvariablevalue_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_environmentvariablevalue_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_environmentvariablevalue_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_environmentvariablevalue")]
    public Team team_environmentvariablevalue
    {
      get => this.GetRelatedEntity<Team>(nameof (team_environmentvariablevalue), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_environmentvariablevalue")]
    public SystemUser user_environmentvariablevalue
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_environmentvariablevalue), new EntityRole?());
      }
    }

    public EnvironmentVariableValue(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["environmentvariablevalueid"] = (object) base.Id;
            break;
          case "environmentvariablevalueid":
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
