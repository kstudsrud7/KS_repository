// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ActivityPointer
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("activitypointer")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ActivityPointer : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "activitypointer";
    public const string EntitySchemaName = "ActivityPointer";
    public const string PrimaryIdAttribute = "activityid";
    public const string PrimaryNameAttribute = "subject";

    public ActivityPointer()
      : base("activitypointer")
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

    [AttributeLogicalName("allparties")]
    public IEnumerable<ActivityParty> allparties
    {
      get
      {
        EntityCollection attributeValue = this.GetAttributeValue<EntityCollection>(nameof (allparties));
        return attributeValue != null && attributeValue.Entities != null ? ((IEnumerable<Entity>) attributeValue.Entities).Select<Entity, ActivityParty>((Func<Entity, ActivityParty>) (e => e.ToEntity<ActivityParty>())) : (IEnumerable<ActivityParty>) null;
      }
    }

    [AttributeLogicalName("community")]
    public OptionSetValue Community
    {
      get => this.GetAttributeValue<OptionSetValue>("community");
      set
      {
        this.OnPropertyChanging(nameof (Community));
        this.SetAttributeValue("community", (object) value);
        this.OnPropertyChanged(nameof (Community));
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

    [AttributeLogicalName("deliverylastattemptedon")]
    public DateTime? DeliveryLastAttemptedOn
    {
      get => this.GetAttributeValue<DateTime?>("deliverylastattemptedon");
    }

    [AttributeLogicalName("deliveryprioritycode")]
    public OptionSetValue DeliveryPriorityCode
    {
      get => this.GetAttributeValue<OptionSetValue>("deliveryprioritycode");
      set
      {
        this.OnPropertyChanging(nameof (DeliveryPriorityCode));
        this.SetAttributeValue("deliveryprioritycode", (object) value);
        this.OnPropertyChanged(nameof (DeliveryPriorityCode));
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

    [AttributeLogicalName("exchangeitemid")]
    public string ExchangeItemId
    {
      get => this.GetAttributeValue<string>("exchangeitemid");
      set
      {
        this.OnPropertyChanging(nameof (ExchangeItemId));
        this.SetAttributeValue("exchangeitemid", (object) value);
        this.OnPropertyChanged(nameof (ExchangeItemId));
      }
    }

    [AttributeLogicalName("exchangerate")]
    public Decimal? ExchangeRate => this.GetAttributeValue<Decimal?>("exchangerate");

    [AttributeLogicalName("exchangeweblink")]
    public string ExchangeWebLink
    {
      get => this.GetAttributeValue<string>("exchangeweblink");
      set
      {
        this.OnPropertyChanging(nameof (ExchangeWebLink));
        this.SetAttributeValue("exchangeweblink", (object) value);
        this.OnPropertyChanged(nameof (ExchangeWebLink));
      }
    }

    [AttributeLogicalName("instancetypecode")]
    public OptionSetValue InstanceTypeCode
    {
      get => this.GetAttributeValue<OptionSetValue>("instancetypecode");
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

    [AttributeLogicalName("ismapiprivate")]
    public bool? IsMapiPrivate
    {
      get => this.GetAttributeValue<bool?>("ismapiprivate");
      set
      {
        this.OnPropertyChanging(nameof (IsMapiPrivate));
        this.SetAttributeValue("ismapiprivate", (object) value);
        this.OnPropertyChanged(nameof (IsMapiPrivate));
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

    [AttributeLogicalName("leftvoicemail")]
    public bool? LeftVoiceMail
    {
      get => this.GetAttributeValue<bool?>("leftvoicemail");
      set
      {
        this.OnPropertyChanging(nameof (LeftVoiceMail));
        this.SetAttributeValue("leftvoicemail", (object) value);
        this.OnPropertyChanged(nameof (LeftVoiceMail));
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

    [AttributeLogicalName("postponeactivityprocessinguntil")]
    public DateTime? PostponeActivityProcessingUntil
    {
      get => this.GetAttributeValue<DateTime?>("postponeactivityprocessinguntil");
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
      set
      {
        this.OnPropertyChanging(nameof (ScheduledDurationMinutes));
        this.SetAttributeValue("scheduleddurationminutes", (object) value);
        this.OnPropertyChanged(nameof (ScheduledDurationMinutes));
      }
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

    [AttributeLogicalName("sendermailboxid")]
    public EntityReference SenderMailboxId
    {
      get => this.GetAttributeValue<EntityReference>("sendermailboxid");
    }

    [AttributeLogicalName("senton")]
    public DateTime? SentOn => this.GetAttributeValue<DateTime?>("senton");

    [AttributeLogicalName("seriesid")]
    public Guid? SeriesId => this.GetAttributeValue<Guid?>("seriesid");

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
    public ActivityPointerState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ActivityPointerState?((ActivityPointerState) Enum.ToObject(typeof (ActivityPointerState), attributeValue.Value)) : new ActivityPointerState?();
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

    [RelationshipSchemaName("activity_pointer_activity_mime_attachment")]
    public IEnumerable<ActivityMimeAttachment> activity_pointer_activity_mime_attachment
    {
      get
      {
        return this.GetRelatedEntities<ActivityMimeAttachment>(nameof (activity_pointer_activity_mime_attachment), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (activity_pointer_activity_mime_attachment));
        this.SetRelatedEntities<ActivityMimeAttachment>(nameof (activity_pointer_activity_mime_attachment), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (activity_pointer_activity_mime_attachment));
      }
    }

    [RelationshipSchemaName("activity_pointer_appointment")]
    public IEnumerable<Appointment> activity_pointer_appointment
    {
      get
      {
        return this.GetRelatedEntities<Appointment>(nameof (activity_pointer_appointment), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (activity_pointer_appointment));
        this.SetRelatedEntities<Appointment>(nameof (activity_pointer_appointment), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (activity_pointer_appointment));
      }
    }

    [RelationshipSchemaName("activity_pointer_email")]
    public IEnumerable<Email> activity_pointer_email
    {
      get => this.GetRelatedEntities<Email>(nameof (activity_pointer_email), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (activity_pointer_email));
        this.SetRelatedEntities<Email>(nameof (activity_pointer_email), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (activity_pointer_email));
      }
    }

    [RelationshipSchemaName("activity_pointer_fax")]
    public IEnumerable<Fax> activity_pointer_fax
    {
      get => this.GetRelatedEntities<Fax>(nameof (activity_pointer_fax), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (activity_pointer_fax));
        this.SetRelatedEntities<Fax>(nameof (activity_pointer_fax), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (activity_pointer_fax));
      }
    }

    [RelationshipSchemaName("activity_pointer_letter")]
    public IEnumerable<Letter> activity_pointer_letter
    {
      get => this.GetRelatedEntities<Letter>(nameof (activity_pointer_letter), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (activity_pointer_letter));
        this.SetRelatedEntities<Letter>(nameof (activity_pointer_letter), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (activity_pointer_letter));
      }
    }

    [RelationshipSchemaName("activity_pointer_phonecall")]
    public IEnumerable<PhoneCall> activity_pointer_phonecall
    {
      get
      {
        return this.GetRelatedEntities<PhoneCall>(nameof (activity_pointer_phonecall), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (activity_pointer_phonecall));
        this.SetRelatedEntities<PhoneCall>(nameof (activity_pointer_phonecall), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (activity_pointer_phonecall));
      }
    }

    [RelationshipSchemaName("activity_pointer_recurrencerule")]
    public IEnumerable<RecurrenceRule> activity_pointer_recurrencerule
    {
      get
      {
        return this.GetRelatedEntities<RecurrenceRule>(nameof (activity_pointer_recurrencerule), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (activity_pointer_recurrencerule));
        this.SetRelatedEntities<RecurrenceRule>(nameof (activity_pointer_recurrencerule), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (activity_pointer_recurrencerule));
      }
    }

    [RelationshipSchemaName("activity_pointer_recurringappointmentmaster")]
    public IEnumerable<RecurringAppointmentMaster> activity_pointer_recurringappointmentmaster
    {
      get
      {
        return this.GetRelatedEntities<RecurringAppointmentMaster>(nameof (activity_pointer_recurringappointmentmaster), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (activity_pointer_recurringappointmentmaster));
        this.SetRelatedEntities<RecurringAppointmentMaster>(nameof (activity_pointer_recurringappointmentmaster), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (activity_pointer_recurringappointmentmaster));
      }
    }

    [RelationshipSchemaName("activity_pointer_socialactivity")]
    public IEnumerable<SocialActivity> activity_pointer_socialactivity
    {
      get
      {
        return this.GetRelatedEntities<SocialActivity>(nameof (activity_pointer_socialactivity), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (activity_pointer_socialactivity));
        this.SetRelatedEntities<SocialActivity>(nameof (activity_pointer_socialactivity), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (activity_pointer_socialactivity));
      }
    }

    [RelationshipSchemaName("activity_pointer_task")]
    public IEnumerable<Task> activity_pointer_task
    {
      get => this.GetRelatedEntities<Task>(nameof (activity_pointer_task), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (activity_pointer_task));
        this.SetRelatedEntities<Task>(nameof (activity_pointer_task), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (activity_pointer_task));
      }
    }

    [RelationshipSchemaName("activitypointer_activity_parties")]
    public IEnumerable<ActivityParty> activitypointer_activity_parties
    {
      get
      {
        return this.GetRelatedEntities<ActivityParty>(nameof (activitypointer_activity_parties), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (activitypointer_activity_parties));
        this.SetRelatedEntities<ActivityParty>(nameof (activitypointer_activity_parties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (activitypointer_activity_parties));
      }
    }

    [RelationshipSchemaName("ActivityPointer_AsyncOperations")]
    public IEnumerable<AsyncOperation> ActivityPointer_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ActivityPointer_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ActivityPointer_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ActivityPointer_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ActivityPointer_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ActivityPointer_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ActivityPointer_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ActivityPointer_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ActivityPointer_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ActivityPointer_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ActivityPointer_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("activitypointer_connections1")]
    public IEnumerable<Connection> activitypointer_connections1
    {
      get
      {
        return this.GetRelatedEntities<Connection>(nameof (activitypointer_connections1), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (activitypointer_connections1));
        this.SetRelatedEntities<Connection>(nameof (activitypointer_connections1), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (activitypointer_connections1));
      }
    }

    [RelationshipSchemaName("activitypointer_connections2")]
    public IEnumerable<Connection> activitypointer_connections2
    {
      get
      {
        return this.GetRelatedEntities<Connection>(nameof (activitypointer_connections2), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (activitypointer_connections2));
        this.SetRelatedEntities<Connection>(nameof (activitypointer_connections2), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (activitypointer_connections2));
      }
    }

    [RelationshipSchemaName("ActivityPointer_QueueItem")]
    public IEnumerable<QueueItem> ActivityPointer_QueueItem
    {
      get
      {
        return this.GetRelatedEntities<QueueItem>(nameof (ActivityPointer_QueueItem), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ActivityPointer_QueueItem));
        this.SetRelatedEntities<QueueItem>(nameof (ActivityPointer_QueueItem), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ActivityPointer_QueueItem));
      }
    }

    [RelationshipSchemaName("slakpiinstance_activitypointer")]
    public IEnumerable<SLAKPIInstance> slakpiinstance_activitypointer
    {
      get
      {
        return this.GetRelatedEntities<SLAKPIInstance>(nameof (slakpiinstance_activitypointer), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (slakpiinstance_activitypointer));
        this.SetRelatedEntities<SLAKPIInstance>(nameof (slakpiinstance_activitypointer), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (slakpiinstance_activitypointer));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Account_ActivityPointers")]
    public Account Account_ActivityPointers
    {
      get => this.GetRelatedEntity<Account>(nameof (Account_ActivityPointers), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Account_ActivityPointers));
        this.SetRelatedEntity<Account>(nameof (Account_ActivityPointers), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Account_ActivityPointers));
      }
    }

    [AttributeLogicalName("sendermailboxid")]
    [RelationshipSchemaName("activitypointer_sendermailboxid_mailbox")]
    public Mailbox activitypointer_sendermailboxid_mailbox
    {
      get
      {
        return this.GetRelatedEntity<Mailbox>(nameof (activitypointer_sendermailboxid_mailbox), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_assessment_ActivityPointers")]
    public ait_assessment ait_assessment_ActivityPointers
    {
      get
      {
        return this.GetRelatedEntity<ait_assessment>(nameof (ait_assessment_ActivityPointers), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_assessment_ActivityPointers));
        this.SetRelatedEntity<ait_assessment>(nameof (ait_assessment_ActivityPointers), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_assessment_ActivityPointers));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_case_ActivityPointers")]
    public ait_case ait_case_ActivityPointers
    {
      get => this.GetRelatedEntity<ait_case>(nameof (ait_case_ActivityPointers), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_case_ActivityPointers));
        this.SetRelatedEntity<ait_case>(nameof (ait_case_ActivityPointers), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_case_ActivityPointers));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_casenote_ActivityPointers")]
    public ait_casenote ait_casenote_ActivityPointers
    {
      get
      {
        return this.GetRelatedEntity<ait_casenote>(nameof (ait_casenote_ActivityPointers), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_casenote_ActivityPointers));
        this.SetRelatedEntity<ait_casenote>(nameof (ait_casenote_ActivityPointers), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_casenote_ActivityPointers));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_caseplan_ActivityPointers")]
    public ait_caseplan ait_caseplan_ActivityPointers
    {
      get
      {
        return this.GetRelatedEntity<ait_caseplan>(nameof (ait_caseplan_ActivityPointers), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_caseplan_ActivityPointers));
        this.SetRelatedEntity<ait_caseplan>(nameof (ait_caseplan_ActivityPointers), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_caseplan_ActivityPointers));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_changerequest_ActivityPointers")]
    public ait_changerequest ait_changerequest_ActivityPointers
    {
      get
      {
        return this.GetRelatedEntity<ait_changerequest>(nameof (ait_changerequest_ActivityPointers), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_changerequest_ActivityPointers));
        this.SetRelatedEntity<ait_changerequest>(nameof (ait_changerequest_ActivityPointers), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_changerequest_ActivityPointers));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_clientprofile_ActivityPointers")]
    public ait_clientprofile ait_clientprofile_ActivityPointers
    {
      get
      {
        return this.GetRelatedEntity<ait_clientprofile>(nameof (ait_clientprofile_ActivityPointers), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_ActivityPointers));
        this.SetRelatedEntity<ait_clientprofile>(nameof (ait_clientprofile_ActivityPointers), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_ActivityPointers));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_courtcase_ActivityPointers")]
    public ait_courtcase ait_courtcase_ActivityPointers
    {
      get
      {
        return this.GetRelatedEntity<ait_courtcase>(nameof (ait_courtcase_ActivityPointers), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtcase_ActivityPointers));
        this.SetRelatedEntity<ait_courtcase>(nameof (ait_courtcase_ActivityPointers), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtcase_ActivityPointers));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_familygroup_ActivityPointers")]
    public ait_familygroup ait_familygroup_ActivityPointers
    {
      get
      {
        return this.GetRelatedEntity<ait_familygroup>(nameof (ait_familygroup_ActivityPointers), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familygroup_ActivityPointers));
        this.SetRelatedEntity<ait_familygroup>(nameof (ait_familygroup_ActivityPointers), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familygroup_ActivityPointers));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_goal_ActivityPointers")]
    public ait_goal ait_goal_ActivityPointers
    {
      get => this.GetRelatedEntity<ait_goal>(nameof (ait_goal_ActivityPointers), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_goal_ActivityPointers));
        this.SetRelatedEntity<ait_goal>(nameof (ait_goal_ActivityPointers), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_goal_ActivityPointers));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_icwaadoption_ActivityPointers")]
    public ait_icwaadoption ait_icwaadoption_ActivityPointers
    {
      get
      {
        return this.GetRelatedEntity<ait_icwaadoption>(nameof (ait_icwaadoption_ActivityPointers), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaadoption_ActivityPointers));
        this.SetRelatedEntity<ait_icwaadoption>(nameof (ait_icwaadoption_ActivityPointers), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaadoption_ActivityPointers));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_icwanotice_ActivityPointers")]
    public ait_icwanotice ait_icwanotice_ActivityPointers
    {
      get
      {
        return this.GetRelatedEntity<ait_icwanotice>(nameof (ait_icwanotice_ActivityPointers), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwanotice_ActivityPointers));
        this.SetRelatedEntity<ait_icwanotice>(nameof (ait_icwanotice_ActivityPointers), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwanotice_ActivityPointers));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_incident_ActivityPointers")]
    public ait_incident ait_incident_ActivityPointers
    {
      get
      {
        return this.GetRelatedEntity<ait_incident>(nameof (ait_incident_ActivityPointers), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incident_ActivityPointers));
        this.SetRelatedEntity<ait_incident>(nameof (ait_incident_ActivityPointers), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incident_ActivityPointers));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_investigation_ActivityPointers")]
    public ait_investigation ait_investigation_ActivityPointers
    {
      get
      {
        return this.GetRelatedEntity<ait_investigation>(nameof (ait_investigation_ActivityPointers), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_investigation_ActivityPointers));
        this.SetRelatedEntity<ait_investigation>(nameof (ait_investigation_ActivityPointers), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_investigation_ActivityPointers));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_outcome_ActivityPointers")]
    public ait_outcome ait_outcome_ActivityPointers
    {
      get
      {
        return this.GetRelatedEntity<ait_outcome>(nameof (ait_outcome_ActivityPointers), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_outcome_ActivityPointers));
        this.SetRelatedEntity<ait_outcome>(nameof (ait_outcome_ActivityPointers), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_outcome_ActivityPointers));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_planactivity_ActivityPointers")]
    public ait_planactivity ait_planactivity_ActivityPointers
    {
      get
      {
        return this.GetRelatedEntity<ait_planactivity>(nameof (ait_planactivity_ActivityPointers), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_planactivity_ActivityPointers));
        this.SetRelatedEntity<ait_planactivity>(nameof (ait_planactivity_ActivityPointers), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_planactivity_ActivityPointers));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_program_ActivityPointers")]
    public ait_program ait_program_ActivityPointers
    {
      get
      {
        return this.GetRelatedEntity<ait_program>(nameof (ait_program_ActivityPointers), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_program_ActivityPointers));
        this.SetRelatedEntity<ait_program>(nameof (ait_program_ActivityPointers), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_program_ActivityPointers));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_referral_ActivityPointers")]
    public ait_referral ait_referral_ActivityPointers
    {
      get
      {
        return this.GetRelatedEntity<ait_referral>(nameof (ait_referral_ActivityPointers), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_referral_ActivityPointers));
        this.SetRelatedEntity<ait_referral>(nameof (ait_referral_ActivityPointers), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_referral_ActivityPointers));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_servicerequest_ActivityPointers")]
    public ait_servicerequest ait_servicerequest_ActivityPointers
    {
      get
      {
        return this.GetRelatedEntity<ait_servicerequest>(nameof (ait_servicerequest_ActivityPointers), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_ActivityPointers));
        this.SetRelatedEntity<ait_servicerequest>(nameof (ait_servicerequest_ActivityPointers), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_ActivityPointers));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_activitypointer")]
    public BusinessUnit business_unit_activitypointer
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_activitypointer), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Contact_ActivityPointers")]
    public Contact Contact_ActivityPointers
    {
      get => this.GetRelatedEntity<Contact>(nameof (Contact_ActivityPointers), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Contact_ActivityPointers));
        this.SetRelatedEntity<Contact>(nameof (Contact_ActivityPointers), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Contact_ActivityPointers));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("interactionforemail_ActivityPointers")]
    public InteractionForEmail interactionforemail_ActivityPointers
    {
      get
      {
        return this.GetRelatedEntity<InteractionForEmail>(nameof (interactionforemail_ActivityPointers), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (interactionforemail_ActivityPointers));
        this.SetRelatedEntity<InteractionForEmail>(nameof (interactionforemail_ActivityPointers), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (interactionforemail_ActivityPointers));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("KnowledgeArticle_ActivityPointers")]
    public KnowledgeArticle KnowledgeArticle_ActivityPointers
    {
      get
      {
        return this.GetRelatedEntity<KnowledgeArticle>(nameof (KnowledgeArticle_ActivityPointers), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeArticle_ActivityPointers));
        this.SetRelatedEntity<KnowledgeArticle>(nameof (KnowledgeArticle_ActivityPointers), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeArticle_ActivityPointers));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("KnowledgeBaseRecord_ActivityPointers")]
    public KnowledgeBaseRecord KnowledgeBaseRecord_ActivityPointers
    {
      get
      {
        return this.GetRelatedEntity<KnowledgeBaseRecord>(nameof (KnowledgeBaseRecord_ActivityPointers), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeBaseRecord_ActivityPointers));
        this.SetRelatedEntity<KnowledgeBaseRecord>(nameof (KnowledgeBaseRecord_ActivityPointers), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeBaseRecord_ActivityPointers));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_activitypointer_createdby")]
    public SystemUser lk_activitypointer_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_activitypointer_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_activitypointer_createdonbehalfby")]
    public SystemUser lk_activitypointer_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_activitypointer_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_activitypointer_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_activitypointer_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_activitypointer_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_activitypointer_modifiedby")]
    public SystemUser lk_activitypointer_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_activitypointer_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_activitypointer_modifiedonbehalfby")]
    public SystemUser lk_activitypointer_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_activitypointer_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_activitypointer_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_activitypointer_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_activitypointer_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("slaid")]
    [RelationshipSchemaName("manualsla_activitypointer")]
    public SLA manualsla_activitypointer
    {
      get => this.GetRelatedEntity<SLA>(nameof (manualsla_activitypointer), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (manualsla_activitypointer));
        this.SetRelatedEntity<SLA>(nameof (manualsla_activitypointer), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (manualsla_activitypointer));
      }
    }

    [AttributeLogicalName("slainvokedid")]
    [RelationshipSchemaName("sla_activitypointer")]
    public SLA sla_activitypointer
    {
      get => this.GetRelatedEntity<SLA>(nameof (sla_activitypointer), new EntityRole?());
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_activity")]
    public Team team_activity
    {
      get => this.GetRelatedEntity<Team>(nameof (team_activity), new EntityRole?());
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_ActivityPointer")]
    public TransactionCurrency TransactionCurrency_ActivityPointer
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_ActivityPointer), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_ActivityPointer));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_ActivityPointer), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_ActivityPointer));
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_activity")]
    public SystemUser user_activity
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_activity), new EntityRole?());
    }

    public ActivityPointer(object anonymousType)
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
