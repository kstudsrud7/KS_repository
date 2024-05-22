// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.msdyn_knowledgeinteractioninsight
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("msdyn_knowledgeinteractioninsight")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class msdyn_knowledgeinteractioninsight : 
    Entity,
    INotifyPropertyChanging,
    INotifyPropertyChanged
  {
    public const string EntityLogicalName = "msdyn_knowledgeinteractioninsight";
    public const string EntitySchemaName = "msdyn_knowledgeinteractioninsight";
    public const string PrimaryIdAttribute = "msdyn_knowledgeinteractioninsightid";
    public const string PrimaryNameAttribute = "msdyn_interactiontype";

    public msdyn_knowledgeinteractioninsight()
      : base(nameof (msdyn_knowledgeinteractioninsight))
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

    [AttributeLogicalName("msdyn_articlerank")]
    public int? msdyn_ArticleRank
    {
      get => this.GetAttributeValue<int?>("msdyn_articlerank");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_ArticleRank));
        this.SetAttributeValue("msdyn_articlerank", (object) value);
        this.OnPropertyChanged(nameof (msdyn_ArticleRank));
      }
    }

    [AttributeLogicalName("msdyn_articlerecordid")]
    public string msdyn_ArticleRecordId
    {
      get => this.GetAttributeValue<string>("msdyn_articlerecordid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_ArticleRecordId));
        this.SetAttributeValue("msdyn_articlerecordid", (object) value);
        this.OnPropertyChanged(nameof (msdyn_ArticleRecordId));
      }
    }

    [AttributeLogicalName("msdyn_articlerelevance")]
    public double? msdyn_ArticleRelevance
    {
      get => this.GetAttributeValue<double?>("msdyn_articlerelevance");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_ArticleRelevance));
        this.SetAttributeValue("msdyn_articlerelevance", (object) value);
        this.OnPropertyChanged(nameof (msdyn_ArticleRelevance));
      }
    }

    [AttributeLogicalName("msdyn_interactioncontext")]
    public string msdyn_InteractionContext
    {
      get => this.GetAttributeValue<string>("msdyn_interactioncontext");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_InteractionContext));
        this.SetAttributeValue("msdyn_interactioncontext", (object) value);
        this.OnPropertyChanged(nameof (msdyn_InteractionContext));
      }
    }

    [AttributeLogicalName("msdyn_interactiontype")]
    public string msdyn_InteractionType
    {
      get => this.GetAttributeValue<string>("msdyn_interactiontype");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_InteractionType));
        this.SetAttributeValue("msdyn_interactiontype", (object) value);
        this.OnPropertyChanged(nameof (msdyn_InteractionType));
      }
    }

    [AttributeLogicalName("msdyn_knowledgeinteractioninsightid")]
    public Guid? msdyn_knowledgeinteractioninsightId
    {
      get => this.GetAttributeValue<Guid?>("msdyn_knowledgeinteractioninsightid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgeinteractioninsightId));
        this.SetAttributeValue("msdyn_knowledgeinteractioninsightid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (msdyn_knowledgeinteractioninsightId));
      }
    }

    [AttributeLogicalName("msdyn_knowledgeinteractioninsightid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.msdyn_knowledgeinteractioninsightId = new Guid?(value);
    }

    [AttributeLogicalName("msdyn_knowledgeoperationid")]
    public string msdyn_KnowledgeOperationId
    {
      get => this.GetAttributeValue<string>("msdyn_knowledgeoperationid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_KnowledgeOperationId));
        this.SetAttributeValue("msdyn_knowledgeoperationid", (object) value);
        this.OnPropertyChanged(nameof (msdyn_KnowledgeOperationId));
      }
    }

    [AttributeLogicalName("msdyn_knowledgeoperationtype")]
    public string msdyn_KnowledgeOperationType
    {
      get => this.GetAttributeValue<string>("msdyn_knowledgeoperationtype");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_KnowledgeOperationType));
        this.SetAttributeValue("msdyn_knowledgeoperationtype", (object) value);
        this.OnPropertyChanged(nameof (msdyn_KnowledgeOperationType));
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
    public msdyn_knowledgeinteractioninsightState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new msdyn_knowledgeinteractioninsightState?((msdyn_knowledgeinteractioninsightState) Enum.ToObject(typeof (msdyn_knowledgeinteractioninsightState), attributeValue.Value)) : new msdyn_knowledgeinteractioninsightState?();
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

    [RelationshipSchemaName("msdyn_knowledgeinteractioninsight_AsyncOperations")]
    public IEnumerable<AsyncOperation> msdyn_knowledgeinteractioninsight_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (msdyn_knowledgeinteractioninsight_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgeinteractioninsight_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (msdyn_knowledgeinteractioninsight_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgeinteractioninsight_AsyncOperations));
      }
    }

    [RelationshipSchemaName("msdyn_knowledgeinteractioninsight_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> msdyn_knowledgeinteractioninsight_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_knowledgeinteractioninsight_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgeinteractioninsight_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_knowledgeinteractioninsight_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgeinteractioninsight_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("msdyn_knowledgeinteractioninsight_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> msdyn_knowledgeinteractioninsight_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (msdyn_knowledgeinteractioninsight_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgeinteractioninsight_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (msdyn_knowledgeinteractioninsight_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgeinteractioninsight_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("msdyn_knowledgeinteractioninsight_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> msdyn_knowledgeinteractioninsight_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (msdyn_knowledgeinteractioninsight_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgeinteractioninsight_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (msdyn_knowledgeinteractioninsight_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgeinteractioninsight_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("msdyn_knowledgeinteractioninsight_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> msdyn_knowledgeinteractioninsight_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_knowledgeinteractioninsight_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgeinteractioninsight_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_knowledgeinteractioninsight_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgeinteractioninsight_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("msdyn_knowledgeinteractioninsight_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> msdyn_knowledgeinteractioninsight_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_knowledgeinteractioninsight_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgeinteractioninsight_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_knowledgeinteractioninsight_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgeinteractioninsight_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("msdyn_knowledgeinteractioninsight_ProcessSession")]
    public IEnumerable<ProcessSession> msdyn_knowledgeinteractioninsight_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (msdyn_knowledgeinteractioninsight_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgeinteractioninsight_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (msdyn_knowledgeinteractioninsight_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgeinteractioninsight_ProcessSession));
      }
    }

    [RelationshipSchemaName("msdyn_knowledgeinteractioninsight_SyncErrors")]
    public IEnumerable<SyncError> msdyn_knowledgeinteractioninsight_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (msdyn_knowledgeinteractioninsight_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgeinteractioninsight_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (msdyn_knowledgeinteractioninsight_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgeinteractioninsight_SyncErrors));
      }
    }

    [RelationshipSchemaName("msdyn_knowledgeinteractioninsight_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> msdyn_knowledgeinteractioninsight_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_knowledgeinteractioninsight_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgeinteractioninsight_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_knowledgeinteractioninsight_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgeinteractioninsight_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_msdyn_knowledgeinteractioninsight")]
    public BusinessUnit business_unit_msdyn_knowledgeinteractioninsight
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_msdyn_knowledgeinteractioninsight), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_msdyn_knowledgeinteractioninsight_createdby")]
    public SystemUser lk_msdyn_knowledgeinteractioninsight_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_knowledgeinteractioninsight_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_knowledgeinteractioninsight_createdonbehalfby")]
    public SystemUser lk_msdyn_knowledgeinteractioninsight_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_knowledgeinteractioninsight_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_knowledgeinteractioninsight_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_knowledgeinteractioninsight_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_knowledgeinteractioninsight_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_msdyn_knowledgeinteractioninsight_modifiedby")]
    public SystemUser lk_msdyn_knowledgeinteractioninsight_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_knowledgeinteractioninsight_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_knowledgeinteractioninsight_modifiedonbehalfby")]
    public SystemUser lk_msdyn_knowledgeinteractioninsight_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_knowledgeinteractioninsight_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_knowledgeinteractioninsight_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_knowledgeinteractioninsight_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_knowledgeinteractioninsight_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_msdyn_knowledgeinteractioninsight")]
    public Team team_msdyn_knowledgeinteractioninsight
    {
      get
      {
        return this.GetRelatedEntity<Team>(nameof (team_msdyn_knowledgeinteractioninsight), new EntityRole?());
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_msdyn_knowledgeinteractioninsight")]
    public SystemUser user_msdyn_knowledgeinteractioninsight
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_msdyn_knowledgeinteractioninsight), new EntityRole?());
      }
    }

    public msdyn_knowledgeinteractioninsight(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["msdyn_knowledgeinteractioninsightid"] = (object) base.Id;
            break;
          case "msdyn_knowledgeinteractioninsightid":
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
