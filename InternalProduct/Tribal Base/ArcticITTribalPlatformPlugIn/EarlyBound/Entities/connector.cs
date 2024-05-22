// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.connector
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("connector")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class connector : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "connector";
    public const string EntitySchemaName = "connector";
    public const string PrimaryIdAttribute = "connectorid";
    public const string PrimaryNameAttribute = "name";

    public connector()
      : base(nameof (connector))
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

    [AttributeLogicalName("connectionparameters")]
    public string ConnectionParameters
    {
      get => this.GetAttributeValue<string>("connectionparameters");
      set
      {
        this.OnPropertyChanging(nameof (ConnectionParameters));
        this.SetAttributeValue("connectionparameters", (object) value);
        this.OnPropertyChanged(nameof (ConnectionParameters));
      }
    }

    [AttributeLogicalName("connectorid")]
    public Guid? connectorId
    {
      get => this.GetAttributeValue<Guid?>("connectorid");
      set
      {
        this.OnPropertyChanging(nameof (connectorId));
        this.SetAttributeValue("connectorid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (connectorId));
      }
    }

    [AttributeLogicalName("connectorid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.connectorId = new Guid?(value);
    }

    [AttributeLogicalName("connectoridunique")]
    public Guid? ConnectorIdUnique => this.GetAttributeValue<Guid?>("connectoridunique");

    [AttributeLogicalName("connectorinternalid")]
    public string ConnectorInternalId
    {
      get => this.GetAttributeValue<string>("connectorinternalid");
      set
      {
        this.OnPropertyChanging(nameof (ConnectorInternalId));
        this.SetAttributeValue("connectorinternalid", (object) value);
        this.OnPropertyChanged(nameof (ConnectorInternalId));
      }
    }

    [AttributeLogicalName("connectortype")]
    public OptionSetValue ConnectorType
    {
      get => this.GetAttributeValue<OptionSetValue>("connectortype");
      set
      {
        this.OnPropertyChanging(nameof (ConnectorType));
        this.SetAttributeValue("connectortype", (object) value);
        this.OnPropertyChanged(nameof (ConnectorType));
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

    [AttributeLogicalName("iconblob")]
    public byte[] IconBlob
    {
      get => this.GetAttributeValue<byte[]>("iconblob");
      set
      {
        this.OnPropertyChanging(nameof (IconBlob));
        this.SetAttributeValue("iconblob", (object) value);
        this.OnPropertyChanged(nameof (IconBlob));
      }
    }

    [AttributeLogicalName("iconblob_timestamp")]
    public long? IconBlob_Timestamp => this.GetAttributeValue<long?>("iconblob_timestamp");

    [AttributeLogicalName("iconblob_url")]
    public string IconBlob_URL => this.GetAttributeValue<string>("iconblob_url");

    [AttributeLogicalName("iconblobid")]
    public Guid? IconBlobId => this.GetAttributeValue<Guid?>("iconblobid");

    [AttributeLogicalName("iconbrandcolor")]
    public string IconBrandColor
    {
      get => this.GetAttributeValue<string>("iconbrandcolor");
      set
      {
        this.OnPropertyChanging(nameof (IconBrandColor));
        this.SetAttributeValue("iconbrandcolor", (object) value);
        this.OnPropertyChanged(nameof (IconBrandColor));
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

    [AttributeLogicalName("openapidefinition")]
    public string OpenApiDefinition
    {
      get => this.GetAttributeValue<string>("openapidefinition");
      set
      {
        this.OnPropertyChanging(nameof (OpenApiDefinition));
        this.SetAttributeValue("openapidefinition", (object) value);
        this.OnPropertyChanged(nameof (OpenApiDefinition));
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

    [AttributeLogicalName("policytemplateinstances")]
    public string PolicyTemplateInstances
    {
      get => this.GetAttributeValue<string>("policytemplateinstances");
      set
      {
        this.OnPropertyChanging(nameof (PolicyTemplateInstances));
        this.SetAttributeValue("policytemplateinstances", (object) value);
        this.OnPropertyChanged(nameof (PolicyTemplateInstances));
      }
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("statecode")]
    public connectorState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new connectorState?((connectorState) Enum.ToObject(typeof (connectorState), attributeValue.Value)) : new connectorState?();
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

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("connector_AsyncOperations")]
    public IEnumerable<AsyncOperation> connector_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (connector_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (connector_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (connector_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (connector_AsyncOperations));
      }
    }

    [RelationshipSchemaName("connector_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> connector_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (connector_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (connector_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (connector_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (connector_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("connector_connectionreference")]
    public IEnumerable<connectionreference> connector_connectionreference
    {
      get
      {
        return this.GetRelatedEntities<connectionreference>(nameof (connector_connectionreference), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (connector_connectionreference));
        this.SetRelatedEntities<connectionreference>(nameof (connector_connectionreference), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (connector_connectionreference));
      }
    }

    [RelationshipSchemaName("connector_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> connector_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (connector_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (connector_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (connector_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (connector_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("connector_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> connector_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (connector_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (connector_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (connector_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (connector_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("connector_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> connector_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (connector_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (connector_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (connector_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (connector_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("connector_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> connector_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (connector_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (connector_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (connector_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (connector_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("connector_ProcessSession")]
    public IEnumerable<ProcessSession> connector_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (connector_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (connector_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (connector_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (connector_ProcessSession));
      }
    }

    [RelationshipSchemaName("connector_SyncErrors")]
    public IEnumerable<SyncError> connector_SyncErrors
    {
      get => this.GetRelatedEntities<SyncError>(nameof (connector_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (connector_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (connector_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (connector_SyncErrors));
      }
    }

    [RelationshipSchemaName("connector_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> connector_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (connector_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (connector_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (connector_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (connector_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_connector")]
    public BusinessUnit business_unit_connector
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_connector), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_connector_createdby")]
    public SystemUser lk_connector_createdby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_connector_createdby), new EntityRole?());
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_connector_createdonbehalfby")]
    public SystemUser lk_connector_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_connector_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_connector_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_connector_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_connector_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_connector_modifiedby")]
    public SystemUser lk_connector_modifiedby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_connector_modifiedby), new EntityRole?());
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_connector_modifiedonbehalfby")]
    public SystemUser lk_connector_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_connector_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_connector_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_connector_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_connector_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_connector")]
    public Team team_connector
    {
      get => this.GetRelatedEntity<Team>(nameof (team_connector), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_connector")]
    public SystemUser user_connector
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_connector), new EntityRole?());
    }

    public connector(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["connectorid"] = (object) base.Id;
            break;
          case "connectorid":
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
