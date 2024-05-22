// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.Fax
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using Microsoft.Xrm.Sdk;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

#nullable disable
namespace ArcticIT.EarlyBound.Entities
{
  [DataContract]
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("fax")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class Fax : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "fax";
    public const string EntitySchemaName = "Fax";
    public const string PrimaryIdAttribute = "activityid";
    public const string PrimaryNameAttribute = "subject";

    public Fax()
      : base("fax")
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

    [AttributeLogicalName("activityid")]
    public Guid? ActivityId
    {
      get => this.GetAttributeValue<Guid?>("activityid");
      set
      {
        this.OnPropertyChanging(nameof (ActivityId));
        this.SetAttributeValue("activityid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ActivityId));
      }
    }

    [AttributeLogicalName("activityid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ActivityId = new Guid?(value);
    }

    [AttributeLogicalName("activitytypecode")]
    public string ActivityTypeCode => this.GetAttributeValue<string>("activitytypecode");

    [AttributeLogicalName("actualdurationminutes")]
    public int? ActualDurationMinutes
    {
      get => this.GetAttributeValue<int?>("actualdurationminutes");
      set
      {
        this.OnPropertyChanging(nameof (ActualDurationMinutes));
        this.SetAttributeValue("actualdurationminutes", (object) value);
        this.OnPropertyChanged(nameof (ActualDurationMinutes));
      }
    }

    [AttributeLogicalName("actualend")]
    public DateTime? ActualEnd
    {
      get => this.GetAttributeValue<DateTime?>("actualend");
      set
      {
        this.OnPropertyChanging(nameof (ActualEnd));
        this.SetAttributeValue("actualend", (object) value);
        this.OnPropertyChanged(nameof (ActualEnd));
      }
    }

    [AttributeLogicalName("actualstart")]
    public DateTime? ActualStart
    {
      get => this.GetAttributeValue<DateTime?>("actualstart");
      set
      {
        this.OnPropertyChanging(nameof (ActualStart));
        this.SetAttributeValue("actualstart", (object) value);
        this.OnPropertyChanged(nameof (ActualStart));
      }
    }

    [AttributeLogicalName("billingcode")]
    public string BillingCode
    {
      get => this.GetAttributeValue<string>("billingcode");
      set
      {
        this.OnPropertyChanging(nameof (BillingCode));
        this.SetAttributeValue("billingcode", (object) value);
        this.OnPropertyChanged(nameof (BillingCode));
      }
    }

    [AttributeLogicalName("category")]
    public string Category
    {
      get => this.GetAttributeValue<string>("category");
      set
      {
        this.OnPropertyChanging(nameof (Category));
        this.SetAttributeValue("category", (object) value);
        this.OnPropertyChanged(nameof (Category));
      }
    }

    [AttributeLogicalName("coverpagename")]
    public string CoverPageName
    {
      get => this.GetAttributeValue<string>("coverpagename");
      set
      {
        this.OnPropertyChanging(nameof (CoverPageName));
        this.SetAttributeValue("coverpagename", (object) value);
        this.OnPropertyChanged(nameof (CoverPageName));
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

    [AttributeLogicalName("directioncode")]
    public bool? DirectionCode
    {
      get => this.GetAttributeValue<bool?>("directioncode");
      set
      {
        this.OnPropertyChanging(nameof (DirectionCode));
        this.SetAttributeValue("directioncode", (object) value);
        this.OnPropertyChanged(nameof (DirectionCode));
      }
    }

    [AttributeLogicalName("exchangerate")]
    public Decimal? ExchangeRate => this.GetAttributeValue<Decimal?>("exchangerate");

    [AttributeLogicalName("faxnumber")]
    public string FaxNumber
    {
      get => this.GetAttributeValue<string>("faxnumber");
      set
      {
        this.OnPropertyChanging(nameof (FaxNumber));
        this.SetAttributeValue("faxnumber", (object) value);
        this.OnPropertyChanged(nameof (FaxNumber));
      }
    }

    [AttributeLogicalName("from")]
    public IEnumerable<ActivityParty> From
    {
      get
      {
        EntityCollection attributeValue = this.GetAttributeValue<EntityCollection>("from");
        return attributeValue != null && attributeValue.Entities != null ? ((IEnumerable<Entity>) attributeValue.Entities).Select<Entity, ActivityParty>((Func<Entity, ActivityParty>) (e => e.ToEntity<ActivityParty>())) : (IEnumerable<ActivityParty>) null;
      }
      set
      {
        this.OnPropertyChanging(nameof (From));
        if (value == null)
          this.SetAttributeValue("from", (object) value);
        else
          this.SetAttributeValue("from", (object) new EntityCollection((IList<Entity>) new List<Entity>((IEnumerable<Entity>) value)));
        this.OnPropertyChanged(nameof (From));
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

    [AttributeLogicalName("isbilled")]
    public bool? IsBilled
    {
      get => this.GetAttributeValue<bool?>("isbilled");
      set
      {
        this.OnPropertyChanging(nameof (IsBilled));
        this.SetAttributeValue("isbilled", (object) value);
        this.OnPropertyChanged(nameof (IsBilled));
      }
    }

    [AttributeLogicalName("isregularactivity")]
    public bool? IsRegularActivity => this.GetAttributeValue<bool?>("isregularactivity");

    [AttributeLogicalName("isworkflowcreated")]
    public bool? IsWorkflowCreated
    {
      get => this.GetAttributeValue<bool?>("isworkflowcreated");
      set
      {
        this.OnPropertyChanging(nameof (IsWorkflowCreated));
        this.SetAttributeValue("isworkflowcreated", (object) value);
        this.OnPropertyChanged(nameof (IsWorkflowCreated));
      }
    }

    [AttributeLogicalName("lastonholdtime")]
    public DateTime? LastOnHoldTime
    {
      get => this.GetAttributeValue<DateTime?>("lastonholdtime");
      set
      {
        this.OnPropertyChanging(nameof (LastOnHoldTime));
        this.SetAttributeValue("lastonholdtime", (object) value);
        this.OnPropertyChanged(nameof (LastOnHoldTime));
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

    [AttributeLogicalName("numberofpages")]
    public int? NumberOfPages
    {
      get => this.GetAttributeValue<int?>("numberofpages");
      set
      {
        this.OnPropertyChanging(nameof (NumberOfPages));
        this.SetAttributeValue("numberofpages", (object) value);
        this.OnPropertyChanged(nameof (NumberOfPages));
      }
    }

    [AttributeLogicalName("onholdtime")]
    public int? OnHoldTime => this.GetAttributeValue<int?>("onholdtime");

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

    [AttributeLogicalName("prioritycode")]
    public OptionSetValue PriorityCode
    {
      get => this.GetAttributeValue<OptionSetValue>("prioritycode");
      set
      {
        this.OnPropertyChanging(nameof (PriorityCode));
        this.SetAttributeValue("prioritycode", (object) value);
        this.OnPropertyChanged(nameof (PriorityCode));
      }
    }

    [AttributeLogicalName("processid")]
    public Guid? ProcessId
    {
      get => this.GetAttributeValue<Guid?>("processid");
      set
      {
        this.OnPropertyChanging(nameof (ProcessId));
        this.SetAttributeValue("processid", (object) value);
        this.OnPropertyChanged(nameof (ProcessId));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    public EntityReference RegardingObjectId
    {
      get => this.GetAttributeValue<EntityReference>("regardingobjectid");
      set
      {
        this.OnPropertyChanging(nameof (RegardingObjectId));
        this.SetAttributeValue("regardingobjectid", (object) value);
        this.OnPropertyChanged(nameof (RegardingObjectId));
      }
    }

    [AttributeLogicalName("scheduleddurationminutes")]
    public int? ScheduledDurationMinutes
    {
      get => this.GetAttributeValue<int?>("scheduleddurationminutes");
    }

    [AttributeLogicalName("scheduledend")]
    public DateTime? ScheduledEnd
    {
      get => this.GetAttributeValue<DateTime?>("scheduledend");
      set
      {
        this.OnPropertyChanging(nameof (ScheduledEnd));
        this.SetAttributeValue("scheduledend", (object) value);
        this.OnPropertyChanged(nameof (ScheduledEnd));
      }
    }

    [AttributeLogicalName("scheduledstart")]
    public DateTime? ScheduledStart
    {
      get => this.GetAttributeValue<DateTime?>("scheduledstart");
      set
      {
        this.OnPropertyChanging(nameof (ScheduledStart));
        this.SetAttributeValue("scheduledstart", (object) value);
        this.OnPropertyChanged(nameof (ScheduledStart));
      }
    }

    [AttributeLogicalName("slaid")]
    public EntityReference SLAId
    {
      get => this.GetAttributeValue<EntityReference>("slaid");
      set
      {
        this.OnPropertyChanging(nameof (SLAId));
        this.SetAttributeValue("slaid", (object) value);
        this.OnPropertyChanged(nameof (SLAId));
      }
    }

    [AttributeLogicalName("slainvokedid")]
    public EntityReference SLAInvokedId => this.GetAttributeValue<EntityReference>("slainvokedid");

    [AttributeLogicalName("sortdate")]
    public DateTime? SortDate
    {
      get => this.GetAttributeValue<DateTime?>("sortdate");
      set
      {
        this.OnPropertyChanging(nameof (SortDate));
        this.SetAttributeValue("sortdate", (object) value);
        this.OnPropertyChanged(nameof (SortDate));
      }
    }

    [AttributeLogicalName("stageid")]
    public Guid? StageId
    {
      get => this.GetAttributeValue<Guid?>("stageid");
      set
      {
        this.OnPropertyChanging(nameof (StageId));
        this.SetAttributeValue("stageid", (object) value);
        this.OnPropertyChanged(nameof (StageId));
      }
    }

    [AttributeLogicalName("statecode")]
    public FaxState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new FaxState?((FaxState) Enum.ToObject(typeof (FaxState), attributeValue.Value)) : new FaxState?();
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

    [AttributeLogicalName("subcategory")]
    public string Subcategory
    {
      get => this.GetAttributeValue<string>("subcategory");
      set
      {
        this.OnPropertyChanging(nameof (Subcategory));
        this.SetAttributeValue("subcategory", (object) value);
        this.OnPropertyChanged(nameof (Subcategory));
      }
    }

    [AttributeLogicalName("subject")]
    public string Subject
    {
      get => this.GetAttributeValue<string>("subject");
      set
      {
        this.OnPropertyChanging(nameof (Subject));
        this.SetAttributeValue("subject", (object) value);
        this.OnPropertyChanged(nameof (Subject));
      }
    }

    [AttributeLogicalName("subscriptionid")]
    public Guid? SubscriptionId
    {
      get => this.GetAttributeValue<Guid?>("subscriptionid");
      set
      {
        this.OnPropertyChanging(nameof (SubscriptionId));
        this.SetAttributeValue("subscriptionid", (object) value);
        this.OnPropertyChanged(nameof (SubscriptionId));
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

    [AttributeLogicalName("to")]
    public IEnumerable<ActivityParty> To
    {
      get
      {
        EntityCollection attributeValue = this.GetAttributeValue<EntityCollection>("to");
        return attributeValue != null && attributeValue.Entities != null ? ((IEnumerable<Entity>) attributeValue.Entities).Select<Entity, ActivityParty>((Func<Entity, ActivityParty>) (e => e.ToEntity<ActivityParty>())) : (IEnumerable<ActivityParty>) null;
      }
      set
      {
        this.OnPropertyChanging(nameof (To));
        if (value == null)
          this.SetAttributeValue("to", (object) value);
        else
          this.SetAttributeValue("to", (object) new EntityCollection((IList<Entity>) new List<Entity>((IEnumerable<Entity>) value)));
        this.OnPropertyChanged(nameof (To));
      }
    }

    [AttributeLogicalName("transactioncurrencyid")]
    public EntityReference TransactionCurrencyId
    {
      get => this.GetAttributeValue<EntityReference>("transactioncurrencyid");
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrencyId));
        this.SetAttributeValue("transactioncurrencyid", (object) value);
        this.OnPropertyChanged(nameof (TransactionCurrencyId));
      }
    }

    [AttributeLogicalName("traversedpath")]
    public string TraversedPath
    {
      get => this.GetAttributeValue<string>("traversedpath");
      set
      {
        this.OnPropertyChanging(nameof (TraversedPath));
        this.SetAttributeValue("traversedpath", (object) value);
        this.OnPropertyChanged(nameof (TraversedPath));
      }
    }

    [AttributeLogicalName("tsid")]
    public string Tsid
    {
      get => this.GetAttributeValue<string>("tsid");
      set
      {
        this.OnPropertyChanging(nameof (Tsid));
        this.SetAttributeValue("tsid", (object) value);
        this.OnPropertyChanged(nameof (Tsid));
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

    [RelationshipSchemaName("fax_actioncard")]
    public IEnumerable<ActionCard> fax_actioncard
    {
      get => this.GetRelatedEntities<ActionCard>(nameof (fax_actioncard), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (fax_actioncard));
        this.SetRelatedEntities<ActionCard>(nameof (fax_actioncard), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (fax_actioncard));
      }
    }

    [RelationshipSchemaName("fax_activity_parties")]
    public IEnumerable<ActivityParty> fax_activity_parties
    {
      get
      {
        return this.GetRelatedEntities<ActivityParty>(nameof (fax_activity_parties), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (fax_activity_parties));
        this.SetRelatedEntities<ActivityParty>(nameof (fax_activity_parties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (fax_activity_parties));
      }
    }

    [RelationshipSchemaName("Fax_Annotation")]
    public IEnumerable<Annotation> Fax_Annotation
    {
      get => this.GetRelatedEntities<Annotation>(nameof (Fax_Annotation), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Fax_Annotation));
        this.SetRelatedEntities<Annotation>(nameof (Fax_Annotation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Fax_Annotation));
      }
    }

    [RelationshipSchemaName("Fax_AsyncOperations")]
    public IEnumerable<AsyncOperation> Fax_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (Fax_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Fax_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (Fax_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Fax_AsyncOperations));
      }
    }

    [RelationshipSchemaName("Fax_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> Fax_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (Fax_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Fax_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (Fax_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Fax_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("fax_connections1")]
    public IEnumerable<Connection> fax_connections1
    {
      get => this.GetRelatedEntities<Connection>(nameof (fax_connections1), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (fax_connections1));
        this.SetRelatedEntities<Connection>(nameof (fax_connections1), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (fax_connections1));
      }
    }

    [RelationshipSchemaName("fax_connections2")]
    public IEnumerable<Connection> fax_connections2
    {
      get => this.GetRelatedEntities<Connection>(nameof (fax_connections2), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (fax_connections2));
        this.SetRelatedEntities<Connection>(nameof (fax_connections2), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (fax_connections2));
      }
    }

    [RelationshipSchemaName("Fax_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> Fax_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (Fax_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Fax_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (Fax_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Fax_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("Fax_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> Fax_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (Fax_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Fax_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (Fax_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Fax_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("fax_principalobjectattributeaccess")]
    public IEnumerable<PrincipalObjectAttributeAccess> fax_principalobjectattributeaccess
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (fax_principalobjectattributeaccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (fax_principalobjectattributeaccess));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (fax_principalobjectattributeaccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (fax_principalobjectattributeaccess));
      }
    }

    [RelationshipSchemaName("Fax_ProcessSessions")]
    public IEnumerable<ProcessSession> Fax_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (Fax_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Fax_ProcessSessions));
        this.SetRelatedEntities<ProcessSession>(nameof (Fax_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Fax_ProcessSessions));
      }
    }

    [RelationshipSchemaName("Fax_QueueItem")]
    public IEnumerable<QueueItem> Fax_QueueItem
    {
      get => this.GetRelatedEntities<QueueItem>(nameof (Fax_QueueItem), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Fax_QueueItem));
        this.SetRelatedEntities<QueueItem>(nameof (Fax_QueueItem), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Fax_QueueItem));
      }
    }

    [RelationshipSchemaName("Fax_SyncErrors")]
    public IEnumerable<SyncError> Fax_SyncErrors
    {
      get => this.GetRelatedEntities<SyncError>(nameof (Fax_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Fax_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (Fax_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Fax_SyncErrors));
      }
    }

    [RelationshipSchemaName("slakpiinstance_fax")]
    public IEnumerable<SLAKPIInstance> slakpiinstance_fax
    {
      get
      {
        return this.GetRelatedEntities<SLAKPIInstance>(nameof (slakpiinstance_fax), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (slakpiinstance_fax));
        this.SetRelatedEntities<SLAKPIInstance>(nameof (slakpiinstance_fax), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (slakpiinstance_fax));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_fax")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_fax
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_fax), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_fax));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_fax), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_fax));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Account_Faxes")]
    public Account Account_Faxes
    {
      get => this.GetRelatedEntity<Account>(nameof (Account_Faxes), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Account_Faxes));
        this.SetRelatedEntity<Account>(nameof (Account_Faxes), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Account_Faxes));
      }
    }

    [AttributeLogicalName("activityid")]
    [RelationshipSchemaName("activity_pointer_fax")]
    public ActivityPointer activity_pointer_fax
    {
      get
      {
        return this.GetRelatedEntity<ActivityPointer>(nameof (activity_pointer_fax), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (activity_pointer_fax));
        this.SetRelatedEntity<ActivityPointer>(nameof (activity_pointer_fax), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (activity_pointer_fax));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_assessment_Faxes")]
    public ait_assessment ait_assessment_Faxes
    {
      get
      {
        return this.GetRelatedEntity<ait_assessment>(nameof (ait_assessment_Faxes), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_assessment_Faxes));
        this.SetRelatedEntity<ait_assessment>(nameof (ait_assessment_Faxes), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_assessment_Faxes));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_case_Faxes")]
    public ait_case ait_case_Faxes
    {
      get => this.GetRelatedEntity<ait_case>(nameof (ait_case_Faxes), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_case_Faxes));
        this.SetRelatedEntity<ait_case>(nameof (ait_case_Faxes), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_case_Faxes));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_casenote_Faxes")]
    public ait_casenote ait_casenote_Faxes
    {
      get => this.GetRelatedEntity<ait_casenote>(nameof (ait_casenote_Faxes), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_casenote_Faxes));
        this.SetRelatedEntity<ait_casenote>(nameof (ait_casenote_Faxes), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_casenote_Faxes));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_caseplan_Faxes")]
    public ait_caseplan ait_caseplan_Faxes
    {
      get => this.GetRelatedEntity<ait_caseplan>(nameof (ait_caseplan_Faxes), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_caseplan_Faxes));
        this.SetRelatedEntity<ait_caseplan>(nameof (ait_caseplan_Faxes), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_caseplan_Faxes));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_changerequest_Faxes")]
    public ait_changerequest ait_changerequest_Faxes
    {
      get
      {
        return this.GetRelatedEntity<ait_changerequest>(nameof (ait_changerequest_Faxes), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_changerequest_Faxes));
        this.SetRelatedEntity<ait_changerequest>(nameof (ait_changerequest_Faxes), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_changerequest_Faxes));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_clientprofile_Faxes")]
    public ait_clientprofile ait_clientprofile_Faxes
    {
      get
      {
        return this.GetRelatedEntity<ait_clientprofile>(nameof (ait_clientprofile_Faxes), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_Faxes));
        this.SetRelatedEntity<ait_clientprofile>(nameof (ait_clientprofile_Faxes), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_Faxes));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_courtcase_Faxes")]
    public ait_courtcase ait_courtcase_Faxes
    {
      get => this.GetRelatedEntity<ait_courtcase>(nameof (ait_courtcase_Faxes), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_courtcase_Faxes));
        this.SetRelatedEntity<ait_courtcase>(nameof (ait_courtcase_Faxes), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtcase_Faxes));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_familygroup_Faxes")]
    public ait_familygroup ait_familygroup_Faxes
    {
      get
      {
        return this.GetRelatedEntity<ait_familygroup>(nameof (ait_familygroup_Faxes), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familygroup_Faxes));
        this.SetRelatedEntity<ait_familygroup>(nameof (ait_familygroup_Faxes), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familygroup_Faxes));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_goal_Faxes")]
    public ait_goal ait_goal_Faxes
    {
      get => this.GetRelatedEntity<ait_goal>(nameof (ait_goal_Faxes), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_goal_Faxes));
        this.SetRelatedEntity<ait_goal>(nameof (ait_goal_Faxes), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_goal_Faxes));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_icwaadoption_Faxes")]
    public ait_icwaadoption ait_icwaadoption_Faxes
    {
      get
      {
        return this.GetRelatedEntity<ait_icwaadoption>(nameof (ait_icwaadoption_Faxes), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaadoption_Faxes));
        this.SetRelatedEntity<ait_icwaadoption>(nameof (ait_icwaadoption_Faxes), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaadoption_Faxes));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_icwanotice_Faxes")]
    public ait_icwanotice ait_icwanotice_Faxes
    {
      get
      {
        return this.GetRelatedEntity<ait_icwanotice>(nameof (ait_icwanotice_Faxes), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwanotice_Faxes));
        this.SetRelatedEntity<ait_icwanotice>(nameof (ait_icwanotice_Faxes), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwanotice_Faxes));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_incident_Faxes")]
    public ait_incident ait_incident_Faxes
    {
      get => this.GetRelatedEntity<ait_incident>(nameof (ait_incident_Faxes), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_incident_Faxes));
        this.SetRelatedEntity<ait_incident>(nameof (ait_incident_Faxes), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incident_Faxes));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_investigation_Faxes")]
    public ait_investigation ait_investigation_Faxes
    {
      get
      {
        return this.GetRelatedEntity<ait_investigation>(nameof (ait_investigation_Faxes), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_investigation_Faxes));
        this.SetRelatedEntity<ait_investigation>(nameof (ait_investigation_Faxes), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_investigation_Faxes));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_outcome_Faxes")]
    public ait_outcome ait_outcome_Faxes
    {
      get => this.GetRelatedEntity<ait_outcome>(nameof (ait_outcome_Faxes), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_outcome_Faxes));
        this.SetRelatedEntity<ait_outcome>(nameof (ait_outcome_Faxes), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_outcome_Faxes));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_planactivity_Faxes")]
    public ait_planactivity ait_planactivity_Faxes
    {
      get
      {
        return this.GetRelatedEntity<ait_planactivity>(nameof (ait_planactivity_Faxes), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_planactivity_Faxes));
        this.SetRelatedEntity<ait_planactivity>(nameof (ait_planactivity_Faxes), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_planactivity_Faxes));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_program_Faxes")]
    public ait_program ait_program_Faxes
    {
      get => this.GetRelatedEntity<ait_program>(nameof (ait_program_Faxes), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_program_Faxes));
        this.SetRelatedEntity<ait_program>(nameof (ait_program_Faxes), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_program_Faxes));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_referral_Faxes")]
    public ait_referral ait_referral_Faxes
    {
      get => this.GetRelatedEntity<ait_referral>(nameof (ait_referral_Faxes), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_referral_Faxes));
        this.SetRelatedEntity<ait_referral>(nameof (ait_referral_Faxes), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_referral_Faxes));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_servicerequest_Faxes")]
    public ait_servicerequest ait_servicerequest_Faxes
    {
      get
      {
        return this.GetRelatedEntity<ait_servicerequest>(nameof (ait_servicerequest_Faxes), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_Faxes));
        this.SetRelatedEntity<ait_servicerequest>(nameof (ait_servicerequest_Faxes), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_Faxes));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_fax_activities")]
    public BusinessUnit business_unit_fax_activities
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_fax_activities), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Contact_Faxes")]
    public Contact Contact_Faxes
    {
      get => this.GetRelatedEntity<Contact>(nameof (Contact_Faxes), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Contact_Faxes));
        this.SetRelatedEntity<Contact>(nameof (Contact_Faxes), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Contact_Faxes));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("KnowledgeArticle_Faxes")]
    public KnowledgeArticle KnowledgeArticle_Faxes
    {
      get
      {
        return this.GetRelatedEntity<KnowledgeArticle>(nameof (KnowledgeArticle_Faxes), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeArticle_Faxes));
        this.SetRelatedEntity<KnowledgeArticle>(nameof (KnowledgeArticle_Faxes), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeArticle_Faxes));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("KnowledgeBaseRecord_Faxes")]
    public KnowledgeBaseRecord KnowledgeBaseRecord_Faxes
    {
      get
      {
        return this.GetRelatedEntity<KnowledgeBaseRecord>(nameof (KnowledgeBaseRecord_Faxes), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeBaseRecord_Faxes));
        this.SetRelatedEntity<KnowledgeBaseRecord>(nameof (KnowledgeBaseRecord_Faxes), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeBaseRecord_Faxes));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_fax_createdby")]
    public SystemUser lk_fax_createdby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_fax_createdby), new EntityRole?());
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_fax_createdonbehalfby")]
    public SystemUser lk_fax_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_fax_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_fax_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_fax_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_fax_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_fax_modifiedby")]
    public SystemUser lk_fax_modifiedby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_fax_modifiedby), new EntityRole?());
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_fax_modifiedonbehalfby")]
    public SystemUser lk_fax_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_fax_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_fax_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_fax_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_fax_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("slaid")]
    [RelationshipSchemaName("manualsla_fax")]
    public SLA manualsla_fax
    {
      get => this.GetRelatedEntity<SLA>(nameof (manualsla_fax), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (manualsla_fax));
        this.SetRelatedEntity<SLA>(nameof (manualsla_fax), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (manualsla_fax));
      }
    }

    [AttributeLogicalName("stageid")]
    [RelationshipSchemaName("processstage_faxes")]
    public ProcessStage processstage_faxes
    {
      get => this.GetRelatedEntity<ProcessStage>(nameof (processstage_faxes), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (processstage_faxes));
        this.SetRelatedEntity<ProcessStage>(nameof (processstage_faxes), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (processstage_faxes));
      }
    }

    [AttributeLogicalName("slainvokedid")]
    [RelationshipSchemaName("sla_fax")]
    public SLA sla_fax => this.GetRelatedEntity<SLA>(nameof (sla_fax), new EntityRole?());

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_fax")]
    public Team team_fax => this.GetRelatedEntity<Team>(nameof (team_fax), new EntityRole?());

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_Fax")]
    public TransactionCurrency TransactionCurrency_Fax
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_Fax), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_Fax));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_Fax), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_Fax));
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_fax")]
    public SystemUser user_fax
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_fax), new EntityRole?());
    }

    public Fax(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["activityid"] = (object) base.Id;
            break;
          case "activityid":
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
