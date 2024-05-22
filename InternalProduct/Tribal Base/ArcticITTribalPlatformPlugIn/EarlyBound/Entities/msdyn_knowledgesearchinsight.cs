// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.msdyn_knowledgesearchinsight
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("msdyn_knowledgesearchinsight")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class msdyn_knowledgesearchinsight : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "msdyn_knowledgesearchinsight";
    public const string EntitySchemaName = "msdyn_knowledgesearchinsight";
    public const string PrimaryIdAttribute = "msdyn_knowledgesearchinsightid";
    public const string PrimaryNameAttribute = "msdyn_searchterm";

    public msdyn_knowledgesearchinsight()
      : base(nameof (msdyn_knowledgesearchinsight))
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

    [AttributeLogicalName("msdyn_applicationname")]
    public string msdyn_ApplicationName
    {
      get => this.GetAttributeValue<string>("msdyn_applicationname");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_ApplicationName));
        this.SetAttributeValue("msdyn_applicationname", (object) value);
        this.OnPropertyChanged(nameof (msdyn_ApplicationName));
      }
    }

    [AttributeLogicalName("msdyn_correlationid")]
    public string msdyn_CorrelationId
    {
      get => this.GetAttributeValue<string>("msdyn_correlationid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_CorrelationId));
        this.SetAttributeValue("msdyn_correlationid", (object) value);
        this.OnPropertyChanged(nameof (msdyn_CorrelationId));
      }
    }

    [AttributeLogicalName("msdyn_customcontrolid")]
    public string msdyn_CustomControlId
    {
      get => this.GetAttributeValue<string>("msdyn_customcontrolid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_CustomControlId));
        this.SetAttributeValue("msdyn_customcontrolid", (object) value);
        this.OnPropertyChanged(nameof (msdyn_CustomControlId));
      }
    }

    [AttributeLogicalName("msdyn_entityrecordid")]
    public string msdyn_EntityRecordId
    {
      get => this.GetAttributeValue<string>("msdyn_entityrecordid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_EntityRecordId));
        this.SetAttributeValue("msdyn_entityrecordid", (object) value);
        this.OnPropertyChanged(nameof (msdyn_EntityRecordId));
      }
    }

    [AttributeLogicalName("msdyn_entitytype")]
    public string msdyn_EntityType
    {
      get => this.GetAttributeValue<string>("msdyn_entitytype");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_EntityType));
        this.SetAttributeValue("msdyn_entitytype", (object) value);
        this.OnPropertyChanged(nameof (msdyn_EntityType));
      }
    }

    [AttributeLogicalName("msdyn_filters")]
    public string msdyn_Filters
    {
      get => this.GetAttributeValue<string>("msdyn_filters");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_Filters));
        this.SetAttributeValue("msdyn_filters", (object) value);
        this.OnPropertyChanged(nameof (msdyn_Filters));
      }
    }

    [AttributeLogicalName("msdyn_initiatedby")]
    public string msdyn_InitiatedBy
    {
      get => this.GetAttributeValue<string>("msdyn_initiatedby");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_InitiatedBy));
        this.SetAttributeValue("msdyn_initiatedby", (object) value);
        this.OnPropertyChanged(nameof (msdyn_InitiatedBy));
      }
    }

    [AttributeLogicalName("msdyn_knowledgesearchinsightid")]
    public Guid? msdyn_knowledgesearchinsightId
    {
      get => this.GetAttributeValue<Guid?>("msdyn_knowledgesearchinsightid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgesearchinsightId));
        this.SetAttributeValue("msdyn_knowledgesearchinsightid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (msdyn_knowledgesearchinsightId));
      }
    }

    [AttributeLogicalName("msdyn_knowledgesearchinsightid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.msdyn_knowledgesearchinsightId = new Guid?(value);
    }

    [AttributeLogicalName("msdyn_responsetime")]
    public int? msdyn_ResponseTime
    {
      get => this.GetAttributeValue<int?>("msdyn_responsetime");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_ResponseTime));
        this.SetAttributeValue("msdyn_responsetime", (object) value);
        this.OnPropertyChanged(nameof (msdyn_ResponseTime));
      }
    }

    [AttributeLogicalName("msdyn_resultcount")]
    public int? msdyn_ResultCount
    {
      get => this.GetAttributeValue<int?>("msdyn_resultcount");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_ResultCount));
        this.SetAttributeValue("msdyn_resultcount", (object) value);
        this.OnPropertyChanged(nameof (msdyn_ResultCount));
      }
    }

    [AttributeLogicalName("msdyn_searchproviderid")]
    public string msdyn_SearchProviderId
    {
      get => this.GetAttributeValue<string>("msdyn_searchproviderid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_SearchProviderId));
        this.SetAttributeValue("msdyn_searchproviderid", (object) value);
        this.OnPropertyChanged(nameof (msdyn_SearchProviderId));
      }
    }

    [AttributeLogicalName("msdyn_searchprovidername")]
    public string msdyn_SearchProviderName
    {
      get => this.GetAttributeValue<string>("msdyn_searchprovidername");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_SearchProviderName));
        this.SetAttributeValue("msdyn_searchprovidername", (object) value);
        this.OnPropertyChanged(nameof (msdyn_SearchProviderName));
      }
    }

    [AttributeLogicalName("msdyn_searchterm")]
    public string msdyn_SearchTerm
    {
      get => this.GetAttributeValue<string>("msdyn_searchterm");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_SearchTerm));
        this.SetAttributeValue("msdyn_searchterm", (object) value);
        this.OnPropertyChanged(nameof (msdyn_SearchTerm));
      }
    }

    [AttributeLogicalName("msdyn_searchtype")]
    public string msdyn_SearchType
    {
      get => this.GetAttributeValue<string>("msdyn_searchtype");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_SearchType));
        this.SetAttributeValue("msdyn_searchtype", (object) value);
        this.OnPropertyChanged(nameof (msdyn_SearchType));
      }
    }

    [AttributeLogicalName("msdyn_sortby")]
    public string msdyn_SortBy
    {
      get => this.GetAttributeValue<string>("msdyn_sortby");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_SortBy));
        this.SetAttributeValue("msdyn_sortby", (object) value);
        this.OnPropertyChanged(nameof (msdyn_SortBy));
      }
    }

    [AttributeLogicalName("msdyn_timestamp")]
    public DateTime? msdyn_TimeStamp
    {
      get => this.GetAttributeValue<DateTime?>("msdyn_timestamp");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_TimeStamp));
        this.SetAttributeValue("msdyn_timestamp", (object) value);
        this.OnPropertyChanged(nameof (msdyn_TimeStamp));
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

    [AttributeLogicalName("statecode")]
    public msdyn_knowledgesearchinsightState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new msdyn_knowledgesearchinsightState?((msdyn_knowledgesearchinsightState) Enum.ToObject(typeof (msdyn_knowledgesearchinsightState), attributeValue.Value)) : new msdyn_knowledgesearchinsightState?();
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

    [RelationshipSchemaName("msdyn_knowledgesearchinsight_AsyncOperations")]
    public IEnumerable<AsyncOperation> msdyn_knowledgesearchinsight_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (msdyn_knowledgesearchinsight_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgesearchinsight_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (msdyn_knowledgesearchinsight_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgesearchinsight_AsyncOperations));
      }
    }

    [RelationshipSchemaName("msdyn_knowledgesearchinsight_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> msdyn_knowledgesearchinsight_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_knowledgesearchinsight_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgesearchinsight_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_knowledgesearchinsight_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgesearchinsight_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("msdyn_knowledgesearchinsight_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> msdyn_knowledgesearchinsight_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (msdyn_knowledgesearchinsight_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgesearchinsight_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (msdyn_knowledgesearchinsight_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgesearchinsight_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("msdyn_knowledgesearchinsight_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> msdyn_knowledgesearchinsight_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (msdyn_knowledgesearchinsight_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgesearchinsight_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (msdyn_knowledgesearchinsight_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgesearchinsight_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("msdyn_knowledgesearchinsight_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> msdyn_knowledgesearchinsight_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_knowledgesearchinsight_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgesearchinsight_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_knowledgesearchinsight_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgesearchinsight_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("msdyn_knowledgesearchinsight_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> msdyn_knowledgesearchinsight_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_knowledgesearchinsight_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgesearchinsight_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_knowledgesearchinsight_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgesearchinsight_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("msdyn_knowledgesearchinsight_ProcessSession")]
    public IEnumerable<ProcessSession> msdyn_knowledgesearchinsight_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (msdyn_knowledgesearchinsight_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgesearchinsight_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (msdyn_knowledgesearchinsight_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgesearchinsight_ProcessSession));
      }
    }

    [RelationshipSchemaName("msdyn_knowledgesearchinsight_SyncErrors")]
    public IEnumerable<SyncError> msdyn_knowledgesearchinsight_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (msdyn_knowledgesearchinsight_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgesearchinsight_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (msdyn_knowledgesearchinsight_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgesearchinsight_SyncErrors));
      }
    }

    [RelationshipSchemaName("msdyn_knowledgesearchinsight_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> msdyn_knowledgesearchinsight_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_knowledgesearchinsight_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgesearchinsight_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_knowledgesearchinsight_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgesearchinsight_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_msdyn_knowledgesearchinsight")]
    public BusinessUnit business_unit_msdyn_knowledgesearchinsight
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_msdyn_knowledgesearchinsight), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_msdyn_knowledgesearchinsight_createdby")]
    public SystemUser lk_msdyn_knowledgesearchinsight_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_knowledgesearchinsight_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_knowledgesearchinsight_createdonbehalfby")]
    public SystemUser lk_msdyn_knowledgesearchinsight_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_knowledgesearchinsight_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_knowledgesearchinsight_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_knowledgesearchinsight_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_knowledgesearchinsight_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_msdyn_knowledgesearchinsight_modifiedby")]
    public SystemUser lk_msdyn_knowledgesearchinsight_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_knowledgesearchinsight_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_knowledgesearchinsight_modifiedonbehalfby")]
    public SystemUser lk_msdyn_knowledgesearchinsight_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_knowledgesearchinsight_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_knowledgesearchinsight_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_knowledgesearchinsight_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_knowledgesearchinsight_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_msdyn_knowledgesearchinsight")]
    public Team team_msdyn_knowledgesearchinsight
    {
      get
      {
        return this.GetRelatedEntity<Team>(nameof (team_msdyn_knowledgesearchinsight), new EntityRole?());
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_msdyn_knowledgesearchinsight")]
    public SystemUser user_msdyn_knowledgesearchinsight
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_msdyn_knowledgesearchinsight), new EntityRole?());
      }
    }

    public msdyn_knowledgesearchinsight(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["msdyn_knowledgesearchinsightid"] = (object) base.Id;
            break;
          case "msdyn_knowledgesearchinsightid":
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
