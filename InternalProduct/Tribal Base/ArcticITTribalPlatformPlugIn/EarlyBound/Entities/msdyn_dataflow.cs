// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.msdyn_dataflow
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("msdyn_dataflow")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class msdyn_dataflow : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "msdyn_dataflow";
    public const string EntitySchemaName = "msdyn_dataflow";
    public const string PrimaryIdAttribute = "msdyn_dataflowid";
    public const string PrimaryNameAttribute = "msdyn_name";

    public msdyn_dataflow()
      : base(nameof (msdyn_dataflow))
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

    [AttributeLogicalName("msdyn_dataflowid")]
    public Guid? msdyn_dataflowId
    {
      get => this.GetAttributeValue<Guid?>("msdyn_dataflowid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_dataflowId));
        this.SetAttributeValue("msdyn_dataflowid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (msdyn_dataflowId));
      }
    }

    [AttributeLogicalName("msdyn_dataflowid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.msdyn_dataflowId = new Guid?(value);
    }

    [AttributeLogicalName("msdyn_description")]
    public string msdyn_Description
    {
      get => this.GetAttributeValue<string>("msdyn_description");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_Description));
        this.SetAttributeValue("msdyn_description", (object) value);
        this.OnPropertyChanged(nameof (msdyn_Description));
      }
    }

    [AttributeLogicalName("msdyn_destinationadls")]
    public string msdyn_DestinationADLS
    {
      get => this.GetAttributeValue<string>("msdyn_destinationadls");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_DestinationADLS));
        this.SetAttributeValue("msdyn_destinationadls", (object) value);
        this.OnPropertyChanged(nameof (msdyn_DestinationADLS));
      }
    }

    [AttributeLogicalName("msdyn_emailsettings")]
    public string msdyn_EmailSettings
    {
      get => this.GetAttributeValue<string>("msdyn_emailsettings");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_EmailSettings));
        this.SetAttributeValue("msdyn_emailsettings", (object) value);
        this.OnPropertyChanged(nameof (msdyn_EmailSettings));
      }
    }

    [AttributeLogicalName("msdyn_gatewayobjectid")]
    public string msdyn_GatewayObjectId
    {
      get => this.GetAttributeValue<string>("msdyn_gatewayobjectid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_GatewayObjectId));
        this.SetAttributeValue("msdyn_gatewayobjectid", (object) value);
        this.OnPropertyChanged(nameof (msdyn_GatewayObjectId));
      }
    }

    [AttributeLogicalName("msdyn_internalversion")]
    public string msdyn_InternalVersion
    {
      get => this.GetAttributeValue<string>("msdyn_internalversion");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_InternalVersion));
        this.SetAttributeValue("msdyn_internalversion", (object) value);
        this.OnPropertyChanged(nameof (msdyn_InternalVersion));
      }
    }

    [AttributeLogicalName("msdyn_mashupdocument")]
    public string msdyn_MashupDocument
    {
      get => this.GetAttributeValue<string>("msdyn_mashupdocument");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_MashupDocument));
        this.SetAttributeValue("msdyn_mashupdocument", (object) value);
        this.OnPropertyChanged(nameof (msdyn_MashupDocument));
      }
    }

    [AttributeLogicalName("msdyn_mashupsettings")]
    public string msdyn_MashupSettings
    {
      get => this.GetAttributeValue<string>("msdyn_mashupsettings");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_MashupSettings));
        this.SetAttributeValue("msdyn_mashupsettings", (object) value);
        this.OnPropertyChanged(nameof (msdyn_MashupSettings));
      }
    }

    [AttributeLogicalName("msdyn_name")]
    public string msdyn_name
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_name));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_name));
        this.SetAttributeValue(nameof (msdyn_name), (object) value);
        this.OnPropertyChanged(nameof (msdyn_name));
      }
    }

    [AttributeLogicalName("msdyn_originaldataflowid")]
    public string msdyn_OriginalDataflowId
    {
      get => this.GetAttributeValue<string>("msdyn_originaldataflowid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_OriginalDataflowId));
        this.SetAttributeValue("msdyn_originaldataflowid", (object) value);
        this.OnPropertyChanged(nameof (msdyn_OriginalDataflowId));
      }
    }

    [AttributeLogicalName("msdyn_refreshhistory")]
    public string msdyn_RefreshHistory
    {
      get => this.GetAttributeValue<string>("msdyn_refreshhistory");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_RefreshHistory));
        this.SetAttributeValue("msdyn_refreshhistory", (object) value);
        this.OnPropertyChanged(nameof (msdyn_RefreshHistory));
      }
    }

    [AttributeLogicalName("msdyn_refreshsettings")]
    public string msdyn_RefreshSettings
    {
      get => this.GetAttributeValue<string>("msdyn_refreshsettings");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_RefreshSettings));
        this.SetAttributeValue("msdyn_refreshsettings", (object) value);
        this.OnPropertyChanged(nameof (msdyn_RefreshSettings));
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

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("statecode")]
    public msdyn_dataflowState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new msdyn_dataflowState?((msdyn_dataflowState) Enum.ToObject(typeof (msdyn_dataflowState), attributeValue.Value)) : new msdyn_dataflowState?();
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

    [RelationshipSchemaName("msdyn_dataflow_AsyncOperations")]
    public IEnumerable<AsyncOperation> msdyn_dataflow_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (msdyn_dataflow_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_dataflow_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (msdyn_dataflow_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_dataflow_AsyncOperations));
      }
    }

    [RelationshipSchemaName("msdyn_dataflow_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> msdyn_dataflow_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_dataflow_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_dataflow_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_dataflow_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_dataflow_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("msdyn_dataflow_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> msdyn_dataflow_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (msdyn_dataflow_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_dataflow_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (msdyn_dataflow_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_dataflow_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("msdyn_dataflow_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> msdyn_dataflow_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (msdyn_dataflow_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_dataflow_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (msdyn_dataflow_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_dataflow_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("msdyn_dataflow_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> msdyn_dataflow_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_dataflow_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_dataflow_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_dataflow_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_dataflow_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("msdyn_dataflow_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> msdyn_dataflow_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_dataflow_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_dataflow_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_dataflow_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_dataflow_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("msdyn_dataflow_ProcessSession")]
    public IEnumerable<ProcessSession> msdyn_dataflow_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (msdyn_dataflow_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_dataflow_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (msdyn_dataflow_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_dataflow_ProcessSession));
      }
    }

    [RelationshipSchemaName("msdyn_dataflow_SyncErrors")]
    public IEnumerable<SyncError> msdyn_dataflow_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (msdyn_dataflow_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_dataflow_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (msdyn_dataflow_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_dataflow_SyncErrors));
      }
    }

    [RelationshipSchemaName("msdyn_dataflow_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> msdyn_dataflow_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_dataflow_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_dataflow_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_dataflow_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_dataflow_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_msdyn_dataflow")]
    public BusinessUnit business_unit_msdyn_dataflow
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_msdyn_dataflow), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_msdyn_dataflow_createdby")]
    public SystemUser lk_msdyn_dataflow_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_dataflow_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_dataflow_createdonbehalfby")]
    public SystemUser lk_msdyn_dataflow_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_dataflow_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_dataflow_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_dataflow_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_dataflow_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_msdyn_dataflow_modifiedby")]
    public SystemUser lk_msdyn_dataflow_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_dataflow_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_dataflow_modifiedonbehalfby")]
    public SystemUser lk_msdyn_dataflow_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_dataflow_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_dataflow_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_dataflow_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_dataflow_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_msdyn_dataflow")]
    public Team team_msdyn_dataflow
    {
      get => this.GetRelatedEntity<Team>(nameof (team_msdyn_dataflow), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_msdyn_dataflow")]
    public SystemUser user_msdyn_dataflow
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_msdyn_dataflow), new EntityRole?());
    }

    public msdyn_dataflow(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["msdyn_dataflowid"] = (object) base.Id;
            break;
          case "msdyn_dataflowid":
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
