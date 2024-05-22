// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.RecurringAppointmentMaster
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("recurringappointmentmaster")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class RecurringAppointmentMaster : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "recurringappointmentmaster";
    public const string EntitySchemaName = "RecurringAppointmentMaster";
    public const string PrimaryIdAttribute = "activityid";
    public const string PrimaryNameAttribute = "subject";

    public RecurringAppointmentMaster()
      : base("recurringappointmentmaster")
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

    [AttributeLogicalName("dayofmonth")]
    public int? DayOfMonth
    {
      get => this.GetAttributeValue<int?>("dayofmonth");
      set
      {
        this.OnPropertyChanging(nameof (DayOfMonth));
        this.SetAttributeValue("dayofmonth", (object) value);
        this.OnPropertyChanged(nameof (DayOfMonth));
      }
    }

    [AttributeLogicalName("daysofweekmask")]
    public int? DaysOfWeekMask
    {
      get => this.GetAttributeValue<int?>("daysofweekmask");
      set
      {
        this.OnPropertyChanging(nameof (DaysOfWeekMask));
        this.SetAttributeValue("daysofweekmask", (object) value);
        this.OnPropertyChanged(nameof (DaysOfWeekMask));
      }
    }

    [AttributeLogicalName("deletedexceptionslist")]
    public string DeletedExceptionsList => this.GetAttributeValue<string>("deletedexceptionslist");

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

    [AttributeLogicalName("duration")]
    public int? Duration
    {
      get => this.GetAttributeValue<int?>("duration");
      set
      {
        this.OnPropertyChanging(nameof (Duration));
        this.SetAttributeValue("duration", (object) value);
        this.OnPropertyChanged(nameof (Duration));
      }
    }

    [AttributeLogicalName("effectiveenddate")]
    public DateTime? EffectiveEndDate
    {
      get => this.GetAttributeValue<DateTime?>("effectiveenddate");
      set
      {
        this.OnPropertyChanging(nameof (EffectiveEndDate));
        this.SetAttributeValue("effectiveenddate", (object) value);
        this.OnPropertyChanged(nameof (EffectiveEndDate));
      }
    }

    [AttributeLogicalName("effectivestartdate")]
    public DateTime? EffectiveStartDate
    {
      get => this.GetAttributeValue<DateTime?>("effectivestartdate");
      set
      {
        this.OnPropertyChanging(nameof (EffectiveStartDate));
        this.SetAttributeValue("effectivestartdate", (object) value);
        this.OnPropertyChanged(nameof (EffectiveStartDate));
      }
    }

    [AttributeLogicalName("endtime")]
    public DateTime? EndTime
    {
      get => this.GetAttributeValue<DateTime?>("endtime");
      set
      {
        this.OnPropertyChanging(nameof (EndTime));
        this.SetAttributeValue("endtime", (object) value);
        this.OnPropertyChanged(nameof (EndTime));
      }
    }

    [AttributeLogicalName("exchangerate")]
    public Decimal? ExchangeRate => this.GetAttributeValue<Decimal?>("exchangerate");

    [AttributeLogicalName("expansionstatecode")]
    public OptionSetValue Expansionstatecode
    {
      get => this.GetAttributeValue<OptionSetValue>("expansionstatecode");
    }

    [AttributeLogicalName("firstdayofweek")]
    public int? FirstDayOfWeek
    {
      get => this.GetAttributeValue<int?>("firstdayofweek");
      set
      {
        this.OnPropertyChanging(nameof (FirstDayOfWeek));
        this.SetAttributeValue("firstdayofweek", (object) value);
        this.OnPropertyChanged(nameof (FirstDayOfWeek));
      }
    }

    [AttributeLogicalName("globalobjectid")]
    public string GlobalObjectId
    {
      get => this.GetAttributeValue<string>("globalobjectid");
      set
      {
        this.OnPropertyChanging(nameof (GlobalObjectId));
        this.SetAttributeValue("globalobjectid", (object) value);
        this.OnPropertyChanged(nameof (GlobalObjectId));
      }
    }

    [AttributeLogicalName("groupid")]
    public EntityReference GroupId => this.GetAttributeValue<EntityReference>("groupid");

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

    [AttributeLogicalName("instance")]
    public OptionSetValue Instance
    {
      get => this.GetAttributeValue<OptionSetValue>("instance");
      set
      {
        this.OnPropertyChanging(nameof (Instance));
        this.SetAttributeValue("instance", (object) value);
        this.OnPropertyChanged(nameof (Instance));
      }
    }

    [AttributeLogicalName("instancetypecode")]
    public OptionSetValue InstanceTypeCode
    {
      get => this.GetAttributeValue<OptionSetValue>("instancetypecode");
    }

    [AttributeLogicalName("interval")]
    public int? Interval
    {
      get => this.GetAttributeValue<int?>("interval");
      set
      {
        this.OnPropertyChanging(nameof (Interval));
        this.SetAttributeValue("interval", (object) value);
        this.OnPropertyChanged(nameof (Interval));
      }
    }

    [AttributeLogicalName("isalldayevent")]
    public bool? IsAllDayEvent
    {
      get => this.GetAttributeValue<bool?>("isalldayevent");
      set
      {
        this.OnPropertyChanging(nameof (IsAllDayEvent));
        this.SetAttributeValue("isalldayevent", (object) value);
        this.OnPropertyChanged(nameof (IsAllDayEvent));
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

    [AttributeLogicalName("isnthmonthly")]
    public bool? IsNthMonthly
    {
      get => this.GetAttributeValue<bool?>("isnthmonthly");
      set
      {
        this.OnPropertyChanging(nameof (IsNthMonthly));
        this.SetAttributeValue("isnthmonthly", (object) value);
        this.OnPropertyChanged(nameof (IsNthMonthly));
      }
    }

    [AttributeLogicalName("isnthyearly")]
    public bool? IsNthYearly
    {
      get => this.GetAttributeValue<bool?>("isnthyearly");
      set
      {
        this.OnPropertyChanging(nameof (IsNthYearly));
        this.SetAttributeValue("isnthyearly", (object) value);
        this.OnPropertyChanged(nameof (IsNthYearly));
      }
    }

    [AttributeLogicalName("isregenerate")]
    public bool? IsRegenerate
    {
      get => this.GetAttributeValue<bool?>("isregenerate");
      set
      {
        this.OnPropertyChanging(nameof (IsRegenerate));
        this.SetAttributeValue("isregenerate", (object) value);
        this.OnPropertyChanged(nameof (IsRegenerate));
      }
    }

    [AttributeLogicalName("isregularactivity")]
    public bool? IsRegularActivity => this.GetAttributeValue<bool?>("isregularactivity");

    [AttributeLogicalName("isunsafe")]
    public int? IsUnsafe => this.GetAttributeValue<int?>("isunsafe");

    [AttributeLogicalName("isweekdaypattern")]
    public bool? IsWeekDayPattern
    {
      get => this.GetAttributeValue<bool?>("isweekdaypattern");
      set
      {
        this.OnPropertyChanging(nameof (IsWeekDayPattern));
        this.SetAttributeValue("isweekdaypattern", (object) value);
        this.OnPropertyChanged(nameof (IsWeekDayPattern));
      }
    }

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

    [AttributeLogicalName("lastexpandedinstancedate")]
    public DateTime? LastExpandedInstanceDate
    {
      get => this.GetAttributeValue<DateTime?>("lastexpandedinstancedate");
    }

    [AttributeLogicalName("location")]
    public string Location
    {
      get => this.GetAttributeValue<string>("location");
      set
      {
        this.OnPropertyChanging(nameof (Location));
        this.SetAttributeValue("location", (object) value);
        this.OnPropertyChanged(nameof (Location));
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

    [AttributeLogicalName("monthofyear")]
    public OptionSetValue MonthOfYear
    {
      get => this.GetAttributeValue<OptionSetValue>("monthofyear");
      set
      {
        this.OnPropertyChanging(nameof (MonthOfYear));
        this.SetAttributeValue("monthofyear", (object) value);
        this.OnPropertyChanged(nameof (MonthOfYear));
      }
    }

    [AttributeLogicalName("nextexpansioninstancedate")]
    public DateTime? NextExpansionInstanceDate
    {
      get => this.GetAttributeValue<DateTime?>("nextexpansioninstancedate");
    }

    [AttributeLogicalName("occurrences")]
    public int? Occurrences
    {
      get => this.GetAttributeValue<int?>("occurrences");
      set
      {
        this.OnPropertyChanging(nameof (Occurrences));
        this.SetAttributeValue("occurrences", (object) value);
        this.OnPropertyChanged(nameof (Occurrences));
      }
    }

    [AttributeLogicalName("optionalattendees")]
    public IEnumerable<ActivityParty> OptionalAttendees
    {
      get
      {
        EntityCollection attributeValue = this.GetAttributeValue<EntityCollection>("optionalattendees");
        return attributeValue != null && attributeValue.Entities != null ? ((IEnumerable<Entity>) attributeValue.Entities).Select<Entity, ActivityParty>((Func<Entity, ActivityParty>) (e => e.ToEntity<ActivityParty>())) : (IEnumerable<ActivityParty>) null;
      }
      set
      {
        this.OnPropertyChanging(nameof (OptionalAttendees));
        if (value == null)
          this.SetAttributeValue("optionalattendees", (object) value);
        else
          this.SetAttributeValue("optionalattendees", (object) new EntityCollection((IList<Entity>) new List<Entity>((IEnumerable<Entity>) value)));
        this.OnPropertyChanged(nameof (OptionalAttendees));
      }
    }

    [AttributeLogicalName("organizer")]
    public IEnumerable<ActivityParty> Organizer
    {
      get
      {
        EntityCollection attributeValue = this.GetAttributeValue<EntityCollection>("organizer");
        return attributeValue != null && attributeValue.Entities != null ? ((IEnumerable<Entity>) attributeValue.Entities).Select<Entity, ActivityParty>((Func<Entity, ActivityParty>) (e => e.ToEntity<ActivityParty>())) : (IEnumerable<ActivityParty>) null;
      }
      set
      {
        this.OnPropertyChanging(nameof (Organizer));
        if (value == null)
          this.SetAttributeValue("organizer", (object) value);
        else
          this.SetAttributeValue("organizer", (object) new EntityCollection((IList<Entity>) new List<Entity>((IEnumerable<Entity>) value)));
        this.OnPropertyChanged(nameof (Organizer));
      }
    }

    [AttributeLogicalName("outlookownerapptid")]
    public int? OutlookOwnerApptId
    {
      get => this.GetAttributeValue<int?>("outlookownerapptid");
      set
      {
        this.OnPropertyChanging(nameof (OutlookOwnerApptId));
        this.SetAttributeValue("outlookownerapptid", (object) value);
        this.OnPropertyChanged(nameof (OutlookOwnerApptId));
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

    [AttributeLogicalName("patternenddate")]
    public DateTime? PatternEndDate
    {
      get => this.GetAttributeValue<DateTime?>("patternenddate");
      set
      {
        this.OnPropertyChanging(nameof (PatternEndDate));
        this.SetAttributeValue("patternenddate", (object) value);
        this.OnPropertyChanged(nameof (PatternEndDate));
      }
    }

    [AttributeLogicalName("patternendtype")]
    public OptionSetValue PatternEndType
    {
      get => this.GetAttributeValue<OptionSetValue>("patternendtype");
      set
      {
        this.OnPropertyChanging(nameof (PatternEndType));
        this.SetAttributeValue("patternendtype", (object) value);
        this.OnPropertyChanged(nameof (PatternEndType));
      }
    }

    [AttributeLogicalName("patternstartdate")]
    public DateTime? PatternStartDate
    {
      get => this.GetAttributeValue<DateTime?>("patternstartdate");
      set
      {
        this.OnPropertyChanging(nameof (PatternStartDate));
        this.SetAttributeValue("patternstartdate", (object) value);
        this.OnPropertyChanged(nameof (PatternStartDate));
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

    [AttributeLogicalName("recurrencepatterntype")]
    public OptionSetValue RecurrencePatternType
    {
      get => this.GetAttributeValue<OptionSetValue>("recurrencepatterntype");
      set
      {
        this.OnPropertyChanging(nameof (RecurrencePatternType));
        this.SetAttributeValue("recurrencepatterntype", (object) value);
        this.OnPropertyChanged(nameof (RecurrencePatternType));
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

    [AttributeLogicalName("requiredattendees")]
    public IEnumerable<ActivityParty> RequiredAttendees
    {
      get
      {
        EntityCollection attributeValue = this.GetAttributeValue<EntityCollection>("requiredattendees");
        return attributeValue != null && attributeValue.Entities != null ? ((IEnumerable<Entity>) attributeValue.Entities).Select<Entity, ActivityParty>((Func<Entity, ActivityParty>) (e => e.ToEntity<ActivityParty>())) : (IEnumerable<ActivityParty>) null;
      }
      set
      {
        this.OnPropertyChanging(nameof (RequiredAttendees));
        if (value == null)
          this.SetAttributeValue("requiredattendees", (object) value);
        else
          this.SetAttributeValue("requiredattendees", (object) new EntityCollection((IList<Entity>) new List<Entity>((IEnumerable<Entity>) value)));
        this.OnPropertyChanged(nameof (RequiredAttendees));
      }
    }

    [AttributeLogicalName("ruleid")]
    public EntityReference RuleId => this.GetAttributeValue<EntityReference>("ruleid");

    [AttributeLogicalName("scheduledend")]
    public DateTime? ScheduledEnd => this.GetAttributeValue<DateTime?>("scheduledend");

    [AttributeLogicalName("scheduledstart")]
    public DateTime? ScheduledStart => this.GetAttributeValue<DateTime?>("scheduledstart");

    [AttributeLogicalName("seriesstatus")]
    public bool? SeriesStatus
    {
      get => this.GetAttributeValue<bool?>("seriesstatus");
      set
      {
        this.OnPropertyChanging(nameof (SeriesStatus));
        this.SetAttributeValue("seriesstatus", (object) value);
        this.OnPropertyChanged(nameof (SeriesStatus));
      }
    }

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

    [AttributeLogicalName("starttime")]
    public DateTime? StartTime
    {
      get => this.GetAttributeValue<DateTime?>("starttime");
      set
      {
        this.OnPropertyChanging(nameof (StartTime));
        this.SetAttributeValue("starttime", (object) value);
        this.OnPropertyChanged(nameof (StartTime));
      }
    }

    [AttributeLogicalName("statecode")]
    public RecurringAppointmentMasterState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new RecurringAppointmentMasterState?((RecurringAppointmentMasterState) Enum.ToObject(typeof (RecurringAppointmentMasterState), attributeValue.Value)) : new RecurringAppointmentMasterState?();
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

    [RelationshipSchemaName("recurringappointmentmaster_actioncard")]
    public IEnumerable<ActionCard> recurringappointmentmaster_actioncard
    {
      get
      {
        return this.GetRelatedEntities<ActionCard>(nameof (recurringappointmentmaster_actioncard), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (recurringappointmentmaster_actioncard));
        this.SetRelatedEntities<ActionCard>(nameof (recurringappointmentmaster_actioncard), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (recurringappointmentmaster_actioncard));
      }
    }

    [RelationshipSchemaName("recurringappointmentmaster_activity_parties")]
    public IEnumerable<ActivityParty> recurringappointmentmaster_activity_parties
    {
      get
      {
        return this.GetRelatedEntities<ActivityParty>(nameof (recurringappointmentmaster_activity_parties), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (recurringappointmentmaster_activity_parties));
        this.SetRelatedEntities<ActivityParty>(nameof (recurringappointmentmaster_activity_parties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (recurringappointmentmaster_activity_parties));
      }
    }

    [RelationshipSchemaName("RecurringAppointmentMaster_Annotation")]
    public IEnumerable<Annotation> RecurringAppointmentMaster_Annotation
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (RecurringAppointmentMaster_Annotation), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (RecurringAppointmentMaster_Annotation));
        this.SetRelatedEntities<Annotation>(nameof (RecurringAppointmentMaster_Annotation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (RecurringAppointmentMaster_Annotation));
      }
    }

    [RelationshipSchemaName("recurringappointmentmaster_appointment")]
    public IEnumerable<Appointment> recurringappointmentmaster_appointment
    {
      get
      {
        return this.GetRelatedEntities<Appointment>(nameof (recurringappointmentmaster_appointment), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (recurringappointmentmaster_appointment));
        this.SetRelatedEntities<Appointment>(nameof (recurringappointmentmaster_appointment), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (recurringappointmentmaster_appointment));
      }
    }

    [RelationshipSchemaName("RecurringAppointmentMaster_AsyncOperations")]
    public IEnumerable<AsyncOperation> RecurringAppointmentMaster_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (RecurringAppointmentMaster_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (RecurringAppointmentMaster_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (RecurringAppointmentMaster_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (RecurringAppointmentMaster_AsyncOperations));
      }
    }

    [RelationshipSchemaName("RecurringAppointmentMaster_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> RecurringAppointmentMaster_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (RecurringAppointmentMaster_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (RecurringAppointmentMaster_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (RecurringAppointmentMaster_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (RecurringAppointmentMaster_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("recurringappointmentmaster_connections1")]
    public IEnumerable<Connection> recurringappointmentmaster_connections1
    {
      get
      {
        return this.GetRelatedEntities<Connection>(nameof (recurringappointmentmaster_connections1), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (recurringappointmentmaster_connections1));
        this.SetRelatedEntities<Connection>(nameof (recurringappointmentmaster_connections1), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (recurringappointmentmaster_connections1));
      }
    }

    [RelationshipSchemaName("recurringappointmentmaster_connections2")]
    public IEnumerable<Connection> recurringappointmentmaster_connections2
    {
      get
      {
        return this.GetRelatedEntities<Connection>(nameof (recurringappointmentmaster_connections2), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (recurringappointmentmaster_connections2));
        this.SetRelatedEntities<Connection>(nameof (recurringappointmentmaster_connections2), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (recurringappointmentmaster_connections2));
      }
    }

    [RelationshipSchemaName("RecurringAppointmentMaster_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> RecurringAppointmentMaster_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (RecurringAppointmentMaster_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (RecurringAppointmentMaster_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (RecurringAppointmentMaster_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (RecurringAppointmentMaster_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("RecurringAppointmentMaster_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> RecurringAppointmentMaster_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (RecurringAppointmentMaster_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (RecurringAppointmentMaster_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (RecurringAppointmentMaster_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (RecurringAppointmentMaster_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("recurringappointmentmaster_PostFollows")]
    public IEnumerable<PostFollow> recurringappointmentmaster_PostFollows
    {
      get
      {
        return this.GetRelatedEntities<PostFollow>(nameof (recurringappointmentmaster_PostFollows), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (recurringappointmentmaster_PostFollows));
        this.SetRelatedEntities<PostFollow>(nameof (recurringappointmentmaster_PostFollows), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (recurringappointmentmaster_PostFollows));
      }
    }

    [RelationshipSchemaName("recurringappointmentmaster_principalobjectattributeaccess")]
    public IEnumerable<PrincipalObjectAttributeAccess> recurringappointmentmaster_principalobjectattributeaccess
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (recurringappointmentmaster_principalobjectattributeaccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (recurringappointmentmaster_principalobjectattributeaccess));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (recurringappointmentmaster_principalobjectattributeaccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (recurringappointmentmaster_principalobjectattributeaccess));
      }
    }

    [RelationshipSchemaName("RecurringAppointmentMaster_ProcessSessions")]
    public IEnumerable<ProcessSession> RecurringAppointmentMaster_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (RecurringAppointmentMaster_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (RecurringAppointmentMaster_ProcessSessions));
        this.SetRelatedEntities<ProcessSession>(nameof (RecurringAppointmentMaster_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (RecurringAppointmentMaster_ProcessSessions));
      }
    }

    [RelationshipSchemaName("RecurringAppointmentMaster_QueueItem")]
    public IEnumerable<QueueItem> RecurringAppointmentMaster_QueueItem
    {
      get
      {
        return this.GetRelatedEntities<QueueItem>(nameof (RecurringAppointmentMaster_QueueItem), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (RecurringAppointmentMaster_QueueItem));
        this.SetRelatedEntities<QueueItem>(nameof (RecurringAppointmentMaster_QueueItem), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (RecurringAppointmentMaster_QueueItem));
      }
    }

    [RelationshipSchemaName("RecurringAppointmentMaster_SyncErrors")]
    public IEnumerable<SyncError> RecurringAppointmentMaster_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (RecurringAppointmentMaster_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (RecurringAppointmentMaster_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (RecurringAppointmentMaster_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (RecurringAppointmentMaster_SyncErrors));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_recurringappointmentmaster")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_recurringappointmentmaster
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_recurringappointmentmaster), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_recurringappointmentmaster));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_recurringappointmentmaster), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_recurringappointmentmaster));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Account_RecurringAppointmentMasters")]
    public Account Account_RecurringAppointmentMasters
    {
      get
      {
        return this.GetRelatedEntity<Account>(nameof (Account_RecurringAppointmentMasters), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Account_RecurringAppointmentMasters));
        this.SetRelatedEntity<Account>(nameof (Account_RecurringAppointmentMasters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Account_RecurringAppointmentMasters));
      }
    }

    [AttributeLogicalName("activityid")]
    [RelationshipSchemaName("activity_pointer_recurringappointmentmaster")]
    public ActivityPointer activity_pointer_recurringappointmentmaster
    {
      get
      {
        return this.GetRelatedEntity<ActivityPointer>(nameof (activity_pointer_recurringappointmentmaster), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (activity_pointer_recurringappointmentmaster));
        this.SetRelatedEntity<ActivityPointer>(nameof (activity_pointer_recurringappointmentmaster), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (activity_pointer_recurringappointmentmaster));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_assessment_RecurringAppointmentMasters")]
    public ait_assessment ait_assessment_RecurringAppointmentMasters
    {
      get
      {
        return this.GetRelatedEntity<ait_assessment>(nameof (ait_assessment_RecurringAppointmentMasters), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_assessment_RecurringAppointmentMasters));
        this.SetRelatedEntity<ait_assessment>(nameof (ait_assessment_RecurringAppointmentMasters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_assessment_RecurringAppointmentMasters));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_case_RecurringAppointmentMasters")]
    public ait_case ait_case_RecurringAppointmentMasters
    {
      get
      {
        return this.GetRelatedEntity<ait_case>(nameof (ait_case_RecurringAppointmentMasters), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_case_RecurringAppointmentMasters));
        this.SetRelatedEntity<ait_case>(nameof (ait_case_RecurringAppointmentMasters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_case_RecurringAppointmentMasters));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_casenote_RecurringAppointmentMasters")]
    public ait_casenote ait_casenote_RecurringAppointmentMasters
    {
      get
      {
        return this.GetRelatedEntity<ait_casenote>(nameof (ait_casenote_RecurringAppointmentMasters), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_casenote_RecurringAppointmentMasters));
        this.SetRelatedEntity<ait_casenote>(nameof (ait_casenote_RecurringAppointmentMasters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_casenote_RecurringAppointmentMasters));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_caseplan_RecurringAppointmentMasters")]
    public ait_caseplan ait_caseplan_RecurringAppointmentMasters
    {
      get
      {
        return this.GetRelatedEntity<ait_caseplan>(nameof (ait_caseplan_RecurringAppointmentMasters), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_caseplan_RecurringAppointmentMasters));
        this.SetRelatedEntity<ait_caseplan>(nameof (ait_caseplan_RecurringAppointmentMasters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_caseplan_RecurringAppointmentMasters));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_changerequest_RecurringAppointmentMasters")]
    public ait_changerequest ait_changerequest_RecurringAppointmentMasters
    {
      get
      {
        return this.GetRelatedEntity<ait_changerequest>(nameof (ait_changerequest_RecurringAppointmentMasters), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_changerequest_RecurringAppointmentMasters));
        this.SetRelatedEntity<ait_changerequest>(nameof (ait_changerequest_RecurringAppointmentMasters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_changerequest_RecurringAppointmentMasters));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_clientprofile_RecurringAppointmentMasters")]
    public ait_clientprofile ait_clientprofile_RecurringAppointmentMasters
    {
      get
      {
        return this.GetRelatedEntity<ait_clientprofile>(nameof (ait_clientprofile_RecurringAppointmentMasters), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_RecurringAppointmentMasters));
        this.SetRelatedEntity<ait_clientprofile>(nameof (ait_clientprofile_RecurringAppointmentMasters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_RecurringAppointmentMasters));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_courtcase_RecurringAppointmentMasters")]
    public ait_courtcase ait_courtcase_RecurringAppointmentMasters
    {
      get
      {
        return this.GetRelatedEntity<ait_courtcase>(nameof (ait_courtcase_RecurringAppointmentMasters), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtcase_RecurringAppointmentMasters));
        this.SetRelatedEntity<ait_courtcase>(nameof (ait_courtcase_RecurringAppointmentMasters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtcase_RecurringAppointmentMasters));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_familygroup_RecurringAppointmentMasters")]
    public ait_familygroup ait_familygroup_RecurringAppointmentMasters
    {
      get
      {
        return this.GetRelatedEntity<ait_familygroup>(nameof (ait_familygroup_RecurringAppointmentMasters), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familygroup_RecurringAppointmentMasters));
        this.SetRelatedEntity<ait_familygroup>(nameof (ait_familygroup_RecurringAppointmentMasters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familygroup_RecurringAppointmentMasters));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_goal_RecurringAppointmentMasters")]
    public ait_goal ait_goal_RecurringAppointmentMasters
    {
      get
      {
        return this.GetRelatedEntity<ait_goal>(nameof (ait_goal_RecurringAppointmentMasters), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_goal_RecurringAppointmentMasters));
        this.SetRelatedEntity<ait_goal>(nameof (ait_goal_RecurringAppointmentMasters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_goal_RecurringAppointmentMasters));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_icwaadoption_RecurringAppointmentMasters")]
    public ait_icwaadoption ait_icwaadoption_RecurringAppointmentMasters
    {
      get
      {
        return this.GetRelatedEntity<ait_icwaadoption>(nameof (ait_icwaadoption_RecurringAppointmentMasters), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaadoption_RecurringAppointmentMasters));
        this.SetRelatedEntity<ait_icwaadoption>(nameof (ait_icwaadoption_RecurringAppointmentMasters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaadoption_RecurringAppointmentMasters));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_icwanotice_RecurringAppointmentMasters")]
    public ait_icwanotice ait_icwanotice_RecurringAppointmentMasters
    {
      get
      {
        return this.GetRelatedEntity<ait_icwanotice>(nameof (ait_icwanotice_RecurringAppointmentMasters), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwanotice_RecurringAppointmentMasters));
        this.SetRelatedEntity<ait_icwanotice>(nameof (ait_icwanotice_RecurringAppointmentMasters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwanotice_RecurringAppointmentMasters));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_incident_RecurringAppointmentMasters")]
    public ait_incident ait_incident_RecurringAppointmentMasters
    {
      get
      {
        return this.GetRelatedEntity<ait_incident>(nameof (ait_incident_RecurringAppointmentMasters), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incident_RecurringAppointmentMasters));
        this.SetRelatedEntity<ait_incident>(nameof (ait_incident_RecurringAppointmentMasters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incident_RecurringAppointmentMasters));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_investigation_RecurringAppointmentMasters")]
    public ait_investigation ait_investigation_RecurringAppointmentMasters
    {
      get
      {
        return this.GetRelatedEntity<ait_investigation>(nameof (ait_investigation_RecurringAppointmentMasters), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_investigation_RecurringAppointmentMasters));
        this.SetRelatedEntity<ait_investigation>(nameof (ait_investigation_RecurringAppointmentMasters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_investigation_RecurringAppointmentMasters));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_outcome_RecurringAppointmentMasters")]
    public ait_outcome ait_outcome_RecurringAppointmentMasters
    {
      get
      {
        return this.GetRelatedEntity<ait_outcome>(nameof (ait_outcome_RecurringAppointmentMasters), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_outcome_RecurringAppointmentMasters));
        this.SetRelatedEntity<ait_outcome>(nameof (ait_outcome_RecurringAppointmentMasters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_outcome_RecurringAppointmentMasters));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_planactivity_RecurringAppointmentMasters")]
    public ait_planactivity ait_planactivity_RecurringAppointmentMasters
    {
      get
      {
        return this.GetRelatedEntity<ait_planactivity>(nameof (ait_planactivity_RecurringAppointmentMasters), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_planactivity_RecurringAppointmentMasters));
        this.SetRelatedEntity<ait_planactivity>(nameof (ait_planactivity_RecurringAppointmentMasters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_planactivity_RecurringAppointmentMasters));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_program_RecurringAppointmentMasters")]
    public ait_program ait_program_RecurringAppointmentMasters
    {
      get
      {
        return this.GetRelatedEntity<ait_program>(nameof (ait_program_RecurringAppointmentMasters), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_program_RecurringAppointmentMasters));
        this.SetRelatedEntity<ait_program>(nameof (ait_program_RecurringAppointmentMasters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_program_RecurringAppointmentMasters));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_referral_RecurringAppointmentMasters")]
    public ait_referral ait_referral_RecurringAppointmentMasters
    {
      get
      {
        return this.GetRelatedEntity<ait_referral>(nameof (ait_referral_RecurringAppointmentMasters), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_referral_RecurringAppointmentMasters));
        this.SetRelatedEntity<ait_referral>(nameof (ait_referral_RecurringAppointmentMasters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_referral_RecurringAppointmentMasters));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_servicerequest_RecurringAppointmentMasters")]
    public ait_servicerequest ait_servicerequest_RecurringAppointmentMasters
    {
      get
      {
        return this.GetRelatedEntity<ait_servicerequest>(nameof (ait_servicerequest_RecurringAppointmentMasters), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_RecurringAppointmentMasters));
        this.SetRelatedEntity<ait_servicerequest>(nameof (ait_servicerequest_RecurringAppointmentMasters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_RecurringAppointmentMasters));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_recurringappointmentmaster_activities")]
    public BusinessUnit business_unit_recurringappointmentmaster_activities
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_recurringappointmentmaster_activities), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Contact_RecurringAppointmentMasters")]
    public Contact Contact_RecurringAppointmentMasters
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (Contact_RecurringAppointmentMasters), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Contact_RecurringAppointmentMasters));
        this.SetRelatedEntity<Contact>(nameof (Contact_RecurringAppointmentMasters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Contact_RecurringAppointmentMasters));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("KnowledgeArticle_RecurringAppointmentMasters")]
    public KnowledgeArticle KnowledgeArticle_RecurringAppointmentMasters
    {
      get
      {
        return this.GetRelatedEntity<KnowledgeArticle>(nameof (KnowledgeArticle_RecurringAppointmentMasters), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeArticle_RecurringAppointmentMasters));
        this.SetRelatedEntity<KnowledgeArticle>(nameof (KnowledgeArticle_RecurringAppointmentMasters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeArticle_RecurringAppointmentMasters));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("KnowledgeBaseRecord_RecurringAppointmentMasters")]
    public KnowledgeBaseRecord KnowledgeBaseRecord_RecurringAppointmentMasters
    {
      get
      {
        return this.GetRelatedEntity<KnowledgeBaseRecord>(nameof (KnowledgeBaseRecord_RecurringAppointmentMasters), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeBaseRecord_RecurringAppointmentMasters));
        this.SetRelatedEntity<KnowledgeBaseRecord>(nameof (KnowledgeBaseRecord_RecurringAppointmentMasters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeBaseRecord_RecurringAppointmentMasters));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_recurringappointmentmaster_createdby")]
    public SystemUser lk_recurringappointmentmaster_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_recurringappointmentmaster_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_recurringappointmentmaster_createdonbehalfby")]
    public SystemUser lk_recurringappointmentmaster_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_recurringappointmentmaster_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_recurringappointmentmaster_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_recurringappointmentmaster_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_recurringappointmentmaster_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_recurringappointmentmaster_modifiedby")]
    public SystemUser lk_recurringappointmentmaster_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_recurringappointmentmaster_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_recurringappointmentmaster_modifiedonbehalfby")]
    public SystemUser lk_recurringappointmentmaster_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_recurringappointmentmaster_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_recurringappointmentmaster_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_recurringappointmentmaster_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_recurringappointmentmaster_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("stageid")]
    [RelationshipSchemaName("processstage_recurringappointmentmasters")]
    public ProcessStage processstage_recurringappointmentmasters
    {
      get
      {
        return this.GetRelatedEntity<ProcessStage>(nameof (processstage_recurringappointmentmasters), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (processstage_recurringappointmentmasters));
        this.SetRelatedEntity<ProcessStage>(nameof (processstage_recurringappointmentmasters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (processstage_recurringappointmentmasters));
      }
    }

    [AttributeLogicalName("activityid")]
    [RelationshipSchemaName("recurrencerule_recurringappointmentmaster")]
    public RecurrenceRule recurrencerule_recurringappointmentmaster
    {
      get
      {
        return this.GetRelatedEntity<RecurrenceRule>(nameof (recurrencerule_recurringappointmentmaster), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (recurrencerule_recurringappointmentmaster));
        this.SetRelatedEntity<RecurrenceRule>(nameof (recurrencerule_recurringappointmentmaster), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (recurrencerule_recurringappointmentmaster));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_recurringappointmentmaster")]
    public Team team_recurringappointmentmaster
    {
      get
      {
        return this.GetRelatedEntity<Team>(nameof (team_recurringappointmentmaster), new EntityRole?());
      }
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_RecurringAppointmentMaster")]
    public TransactionCurrency TransactionCurrency_RecurringAppointmentMaster
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_RecurringAppointmentMaster), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_RecurringAppointmentMaster));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_RecurringAppointmentMaster), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_RecurringAppointmentMaster));
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_recurringappointmentmaster")]
    public SystemUser user_recurringappointmentmaster
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_recurringappointmentmaster), new EntityRole?());
      }
    }

    public RecurringAppointmentMaster(object anonymousType)
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
