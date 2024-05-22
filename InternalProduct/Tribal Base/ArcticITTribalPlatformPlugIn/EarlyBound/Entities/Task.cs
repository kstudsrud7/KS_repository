// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.Task
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("task")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class Task : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "task";
    public const string EntitySchemaName = "Task";
    public const string PrimaryIdAttribute = "activityid";
    public const string PrimaryNameAttribute = "subject";

    public Task()
      : base("task")
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

    [AttributeLogicalName("activityadditionalparams")]
    public string ActivityAdditionalParams
    {
      get => this.GetAttributeValue<string>("activityadditionalparams");
      set
      {
        this.OnPropertyChanging(nameof (ActivityAdditionalParams));
        this.SetAttributeValue("activityadditionalparams", (object) value);
        this.OnPropertyChanged(nameof (ActivityAdditionalParams));
      }
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

    [AttributeLogicalName("ait_caseplan")]
    public EntityReference ait_CasePlan
    {
      get => this.GetAttributeValue<EntityReference>("ait_caseplan");
      set
      {
        this.OnPropertyChanging(nameof (ait_CasePlan));
        this.SetAttributeValue("ait_caseplan", (object) value);
        this.OnPropertyChanged(nameof (ait_CasePlan));
      }
    }

    [AttributeLogicalName("ait_familygroup")]
    public EntityReference ait_FamilyGroup
    {
      get => this.GetAttributeValue<EntityReference>("ait_familygroup");
      set
      {
        this.OnPropertyChanging(nameof (ait_FamilyGroup));
        this.SetAttributeValue("ait_familygroup", (object) value);
        this.OnPropertyChanged(nameof (ait_FamilyGroup));
      }
    }

    [AttributeLogicalName("ait_individual")]
    public EntityReference ait_Individual
    {
      get => this.GetAttributeValue<EntityReference>("ait_individual");
      set
      {
        this.OnPropertyChanging(nameof (ait_Individual));
        this.SetAttributeValue("ait_individual", (object) value);
        this.OnPropertyChanged(nameof (ait_Individual));
      }
    }

    [AttributeLogicalName("ait_outcome")]
    public EntityReference ait_Outcome
    {
      get => this.GetAttributeValue<EntityReference>("ait_outcome");
      set
      {
        this.OnPropertyChanging(nameof (ait_Outcome));
        this.SetAttributeValue("ait_outcome", (object) value);
        this.OnPropertyChanged(nameof (ait_Outcome));
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

    [AttributeLogicalName("crmtaskassigneduniqueid")]
    public Guid? CrmTaskAssignedUniqueId
    {
      get => this.GetAttributeValue<Guid?>("crmtaskassigneduniqueid");
      set
      {
        this.OnPropertyChanging(nameof (CrmTaskAssignedUniqueId));
        this.SetAttributeValue("crmtaskassigneduniqueid", (object) value);
        this.OnPropertyChanged(nameof (CrmTaskAssignedUniqueId));
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

    [AttributeLogicalName("exchangerate")]
    public Decimal? ExchangeRate => this.GetAttributeValue<Decimal?>("exchangerate");

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

    [AttributeLogicalName("percentcomplete")]
    public int? PercentComplete
    {
      get => this.GetAttributeValue<int?>("percentcomplete");
      set
      {
        this.OnPropertyChanging(nameof (PercentComplete));
        this.SetAttributeValue("percentcomplete", (object) value);
        this.OnPropertyChanged(nameof (PercentComplete));
      }
    }

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
    public TaskState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new TaskState?((TaskState) Enum.ToObject(typeof (TaskState), attributeValue.Value)) : new TaskState?();
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

    [RelationshipSchemaName("ait_task_ait_planactivity_Task")]
    public IEnumerable<ait_planactivity> ait_task_ait_planactivity_Task
    {
      get
      {
        return this.GetRelatedEntities<ait_planactivity>(nameof (ait_task_ait_planactivity_Task), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_task_ait_planactivity_Task));
        this.SetRelatedEntities<ait_planactivity>(nameof (ait_task_ait_planactivity_Task), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_task_ait_planactivity_Task));
      }
    }

    [RelationshipSchemaName("slakpiinstance_task")]
    public IEnumerable<SLAKPIInstance> slakpiinstance_task
    {
      get
      {
        return this.GetRelatedEntities<SLAKPIInstance>(nameof (slakpiinstance_task), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (slakpiinstance_task));
        this.SetRelatedEntities<SLAKPIInstance>(nameof (slakpiinstance_task), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (slakpiinstance_task));
      }
    }

    [RelationshipSchemaName("task_actioncard")]
    public IEnumerable<ActionCard> task_actioncard
    {
      get => this.GetRelatedEntities<ActionCard>(nameof (task_actioncard), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (task_actioncard));
        this.SetRelatedEntities<ActionCard>(nameof (task_actioncard), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (task_actioncard));
      }
    }

    [RelationshipSchemaName("task_activity_parties")]
    public IEnumerable<ActivityParty> task_activity_parties
    {
      get
      {
        return this.GetRelatedEntities<ActivityParty>(nameof (task_activity_parties), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (task_activity_parties));
        this.SetRelatedEntities<ActivityParty>(nameof (task_activity_parties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (task_activity_parties));
      }
    }

    [RelationshipSchemaName("Task_Annotation")]
    public IEnumerable<Annotation> Task_Annotation
    {
      get => this.GetRelatedEntities<Annotation>(nameof (Task_Annotation), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Task_Annotation));
        this.SetRelatedEntities<Annotation>(nameof (Task_Annotation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Task_Annotation));
      }
    }

    [RelationshipSchemaName("Task_AsyncOperations")]
    public IEnumerable<AsyncOperation> Task_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (Task_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Task_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (Task_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Task_AsyncOperations));
      }
    }

    [RelationshipSchemaName("Task_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> Task_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (Task_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Task_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (Task_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Task_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("task_connections1")]
    public IEnumerable<Connection> task_connections1
    {
      get => this.GetRelatedEntities<Connection>(nameof (task_connections1), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (task_connections1));
        this.SetRelatedEntities<Connection>(nameof (task_connections1), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (task_connections1));
      }
    }

    [RelationshipSchemaName("task_connections2")]
    public IEnumerable<Connection> task_connections2
    {
      get => this.GetRelatedEntities<Connection>(nameof (task_connections2), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (task_connections2));
        this.SetRelatedEntities<Connection>(nameof (task_connections2), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (task_connections2));
      }
    }

    [RelationshipSchemaName("Task_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> Task_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (Task_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Task_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (Task_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Task_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("Task_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> Task_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (Task_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Task_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (Task_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Task_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("task_PostFollows")]
    public IEnumerable<PostFollow> task_PostFollows
    {
      get => this.GetRelatedEntities<PostFollow>(nameof (task_PostFollows), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (task_PostFollows));
        this.SetRelatedEntities<PostFollow>(nameof (task_PostFollows), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (task_PostFollows));
      }
    }

    [RelationshipSchemaName("task_principalobjectattributeaccess")]
    public IEnumerable<PrincipalObjectAttributeAccess> task_principalobjectattributeaccess
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (task_principalobjectattributeaccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (task_principalobjectattributeaccess));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (task_principalobjectattributeaccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (task_principalobjectattributeaccess));
      }
    }

    [RelationshipSchemaName("Task_ProcessSessions")]
    public IEnumerable<ProcessSession> Task_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (Task_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Task_ProcessSessions));
        this.SetRelatedEntities<ProcessSession>(nameof (Task_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Task_ProcessSessions));
      }
    }

    [RelationshipSchemaName("Task_QueueItem")]
    public IEnumerable<QueueItem> Task_QueueItem
    {
      get => this.GetRelatedEntities<QueueItem>(nameof (Task_QueueItem), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Task_QueueItem));
        this.SetRelatedEntities<QueueItem>(nameof (Task_QueueItem), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Task_QueueItem));
      }
    }

    [RelationshipSchemaName("Task_SyncErrors")]
    public IEnumerable<SyncError> Task_SyncErrors
    {
      get => this.GetRelatedEntities<SyncError>(nameof (Task_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Task_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (Task_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Task_SyncErrors));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_task")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_task
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_task), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_task));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_task), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_task));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Account_Tasks")]
    public Account Account_Tasks
    {
      get => this.GetRelatedEntity<Account>(nameof (Account_Tasks), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Account_Tasks));
        this.SetRelatedEntity<Account>(nameof (Account_Tasks), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Account_Tasks));
      }
    }

    [AttributeLogicalName("activityid")]
    [RelationshipSchemaName("activity_pointer_task")]
    public ActivityPointer activity_pointer_task
    {
      get
      {
        return this.GetRelatedEntity<ActivityPointer>(nameof (activity_pointer_task), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (activity_pointer_task));
        this.SetRelatedEntity<ActivityPointer>(nameof (activity_pointer_task), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (activity_pointer_task));
      }
    }

    [AttributeLogicalName("ait_caseplan")]
    [RelationshipSchemaName("ait_ait_caseplan_task_Plan")]
    public ait_caseplan ait_ait_caseplan_task_Plan
    {
      get
      {
        return this.GetRelatedEntity<ait_caseplan>(nameof (ait_ait_caseplan_task_Plan), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_caseplan_task_Plan));
        this.SetRelatedEntity<ait_caseplan>(nameof (ait_ait_caseplan_task_Plan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_caseplan_task_Plan));
      }
    }

    [AttributeLogicalName("ait_individual")]
    [RelationshipSchemaName("ait_ait_clientprofile_task_Individual")]
    public ait_clientprofile ait_ait_clientprofile_task_Individual
    {
      get
      {
        return this.GetRelatedEntity<ait_clientprofile>(nameof (ait_ait_clientprofile_task_Individual), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_clientprofile_task_Individual));
        this.SetRelatedEntity<ait_clientprofile>(nameof (ait_ait_clientprofile_task_Individual), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_clientprofile_task_Individual));
      }
    }

    [AttributeLogicalName("ait_familygroup")]
    [RelationshipSchemaName("ait_ait_familygroup_task_FamilyGroup")]
    public ait_familygroup ait_ait_familygroup_task_FamilyGroup
    {
      get
      {
        return this.GetRelatedEntity<ait_familygroup>(nameof (ait_ait_familygroup_task_FamilyGroup), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_familygroup_task_FamilyGroup));
        this.SetRelatedEntity<ait_familygroup>(nameof (ait_ait_familygroup_task_FamilyGroup), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_familygroup_task_FamilyGroup));
      }
    }

    [AttributeLogicalName("ait_outcome")]
    [RelationshipSchemaName("ait_ait_outcome_task_Outcome")]
    public ait_outcome ait_ait_outcome_task_Outcome
    {
      get
      {
        return this.GetRelatedEntity<ait_outcome>(nameof (ait_ait_outcome_task_Outcome), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_outcome_task_Outcome));
        this.SetRelatedEntity<ait_outcome>(nameof (ait_ait_outcome_task_Outcome), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_outcome_task_Outcome));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_assessment_Tasks")]
    public ait_assessment ait_assessment_Tasks
    {
      get
      {
        return this.GetRelatedEntity<ait_assessment>(nameof (ait_assessment_Tasks), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_assessment_Tasks));
        this.SetRelatedEntity<ait_assessment>(nameof (ait_assessment_Tasks), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_assessment_Tasks));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_case_Tasks")]
    public ait_case ait_case_Tasks
    {
      get => this.GetRelatedEntity<ait_case>(nameof (ait_case_Tasks), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_case_Tasks));
        this.SetRelatedEntity<ait_case>(nameof (ait_case_Tasks), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_case_Tasks));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_casenote_Tasks")]
    public ait_casenote ait_casenote_Tasks
    {
      get => this.GetRelatedEntity<ait_casenote>(nameof (ait_casenote_Tasks), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_casenote_Tasks));
        this.SetRelatedEntity<ait_casenote>(nameof (ait_casenote_Tasks), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_casenote_Tasks));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_caseplan_Tasks")]
    public ait_caseplan ait_caseplan_Tasks
    {
      get => this.GetRelatedEntity<ait_caseplan>(nameof (ait_caseplan_Tasks), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_caseplan_Tasks));
        this.SetRelatedEntity<ait_caseplan>(nameof (ait_caseplan_Tasks), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_caseplan_Tasks));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_changerequest_Tasks")]
    public ait_changerequest ait_changerequest_Tasks
    {
      get
      {
        return this.GetRelatedEntity<ait_changerequest>(nameof (ait_changerequest_Tasks), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_changerequest_Tasks));
        this.SetRelatedEntity<ait_changerequest>(nameof (ait_changerequest_Tasks), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_changerequest_Tasks));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_clientprofile_Tasks")]
    public ait_clientprofile ait_clientprofile_Tasks
    {
      get
      {
        return this.GetRelatedEntity<ait_clientprofile>(nameof (ait_clientprofile_Tasks), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_Tasks));
        this.SetRelatedEntity<ait_clientprofile>(nameof (ait_clientprofile_Tasks), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_Tasks));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_courtcase_Tasks")]
    public ait_courtcase ait_courtcase_Tasks
    {
      get => this.GetRelatedEntity<ait_courtcase>(nameof (ait_courtcase_Tasks), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_courtcase_Tasks));
        this.SetRelatedEntity<ait_courtcase>(nameof (ait_courtcase_Tasks), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtcase_Tasks));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_familygroup_Tasks")]
    public ait_familygroup ait_familygroup_Tasks
    {
      get
      {
        return this.GetRelatedEntity<ait_familygroup>(nameof (ait_familygroup_Tasks), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familygroup_Tasks));
        this.SetRelatedEntity<ait_familygroup>(nameof (ait_familygroup_Tasks), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familygroup_Tasks));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_goal_Tasks")]
    public ait_goal ait_goal_Tasks
    {
      get => this.GetRelatedEntity<ait_goal>(nameof (ait_goal_Tasks), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_goal_Tasks));
        this.SetRelatedEntity<ait_goal>(nameof (ait_goal_Tasks), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_goal_Tasks));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_icwaadoption_Tasks")]
    public ait_icwaadoption ait_icwaadoption_Tasks
    {
      get
      {
        return this.GetRelatedEntity<ait_icwaadoption>(nameof (ait_icwaadoption_Tasks), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaadoption_Tasks));
        this.SetRelatedEntity<ait_icwaadoption>(nameof (ait_icwaadoption_Tasks), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaadoption_Tasks));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_icwanotice_Tasks")]
    public ait_icwanotice ait_icwanotice_Tasks
    {
      get
      {
        return this.GetRelatedEntity<ait_icwanotice>(nameof (ait_icwanotice_Tasks), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwanotice_Tasks));
        this.SetRelatedEntity<ait_icwanotice>(nameof (ait_icwanotice_Tasks), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwanotice_Tasks));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_incident_Tasks")]
    public ait_incident ait_incident_Tasks
    {
      get => this.GetRelatedEntity<ait_incident>(nameof (ait_incident_Tasks), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_incident_Tasks));
        this.SetRelatedEntity<ait_incident>(nameof (ait_incident_Tasks), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incident_Tasks));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_investigation_Tasks")]
    public ait_investigation ait_investigation_Tasks
    {
      get
      {
        return this.GetRelatedEntity<ait_investigation>(nameof (ait_investigation_Tasks), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_investigation_Tasks));
        this.SetRelatedEntity<ait_investigation>(nameof (ait_investigation_Tasks), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_investigation_Tasks));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_outcome_Tasks")]
    public ait_outcome ait_outcome_Tasks
    {
      get => this.GetRelatedEntity<ait_outcome>(nameof (ait_outcome_Tasks), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_outcome_Tasks));
        this.SetRelatedEntity<ait_outcome>(nameof (ait_outcome_Tasks), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_outcome_Tasks));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_planactivity_Tasks")]
    public ait_planactivity ait_planactivity_Tasks
    {
      get
      {
        return this.GetRelatedEntity<ait_planactivity>(nameof (ait_planactivity_Tasks), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_planactivity_Tasks));
        this.SetRelatedEntity<ait_planactivity>(nameof (ait_planactivity_Tasks), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_planactivity_Tasks));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_program_Tasks")]
    public ait_program ait_program_Tasks
    {
      get => this.GetRelatedEntity<ait_program>(nameof (ait_program_Tasks), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_program_Tasks));
        this.SetRelatedEntity<ait_program>(nameof (ait_program_Tasks), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_program_Tasks));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_referral_Tasks")]
    public ait_referral ait_referral_Tasks
    {
      get => this.GetRelatedEntity<ait_referral>(nameof (ait_referral_Tasks), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_referral_Tasks));
        this.SetRelatedEntity<ait_referral>(nameof (ait_referral_Tasks), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_referral_Tasks));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_servicerequest_Tasks")]
    public ait_servicerequest ait_servicerequest_Tasks
    {
      get
      {
        return this.GetRelatedEntity<ait_servicerequest>(nameof (ait_servicerequest_Tasks), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_Tasks));
        this.SetRelatedEntity<ait_servicerequest>(nameof (ait_servicerequest_Tasks), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_Tasks));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_task_activities")]
    public BusinessUnit business_unit_task_activities
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_task_activities), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Contact_Tasks")]
    public Contact Contact_Tasks
    {
      get => this.GetRelatedEntity<Contact>(nameof (Contact_Tasks), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Contact_Tasks));
        this.SetRelatedEntity<Contact>(nameof (Contact_Tasks), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Contact_Tasks));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("KnowledgeArticle_Tasks")]
    public KnowledgeArticle KnowledgeArticle_Tasks
    {
      get
      {
        return this.GetRelatedEntity<KnowledgeArticle>(nameof (KnowledgeArticle_Tasks), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeArticle_Tasks));
        this.SetRelatedEntity<KnowledgeArticle>(nameof (KnowledgeArticle_Tasks), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeArticle_Tasks));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("KnowledgeBaseRecord_Tasks")]
    public KnowledgeBaseRecord KnowledgeBaseRecord_Tasks
    {
      get
      {
        return this.GetRelatedEntity<KnowledgeBaseRecord>(nameof (KnowledgeBaseRecord_Tasks), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeBaseRecord_Tasks));
        this.SetRelatedEntity<KnowledgeBaseRecord>(nameof (KnowledgeBaseRecord_Tasks), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeBaseRecord_Tasks));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_task_createdby")]
    public SystemUser lk_task_createdby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_task_createdby), new EntityRole?());
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_task_createdonbehalfby")]
    public SystemUser lk_task_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_task_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_task_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_task_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_task_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_task_modifiedby")]
    public SystemUser lk_task_modifiedby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_task_modifiedby), new EntityRole?());
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_task_modifiedonbehalfby")]
    public SystemUser lk_task_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_task_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_task_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_task_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_task_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("slaid")]
    [RelationshipSchemaName("manualsla_task")]
    public SLA manualsla_task
    {
      get => this.GetRelatedEntity<SLA>(nameof (manualsla_task), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (manualsla_task));
        this.SetRelatedEntity<SLA>(nameof (manualsla_task), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (manualsla_task));
      }
    }

    [AttributeLogicalName("stageid")]
    [RelationshipSchemaName("processstage_tasks")]
    public ProcessStage processstage_tasks
    {
      get => this.GetRelatedEntity<ProcessStage>(nameof (processstage_tasks), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (processstage_tasks));
        this.SetRelatedEntity<ProcessStage>(nameof (processstage_tasks), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (processstage_tasks));
      }
    }

    [AttributeLogicalName("slainvokedid")]
    [RelationshipSchemaName("sla_task")]
    public SLA sla_task => this.GetRelatedEntity<SLA>(nameof (sla_task), new EntityRole?());

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_task")]
    public Team team_task => this.GetRelatedEntity<Team>(nameof (team_task), new EntityRole?());

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_Task")]
    public TransactionCurrency TransactionCurrency_Task
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_Task), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_Task));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_Task), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_Task));
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_task")]
    public SystemUser user_task
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_task), new EntityRole?());
    }

    public Task(object anonymousType)
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
