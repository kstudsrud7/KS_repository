// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.Appointment
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("appointment")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class Appointment : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "appointment";
    public const string EntitySchemaName = "Appointment";
    public const string PrimaryIdAttribute = "activityid";
    public const string PrimaryNameAttribute = "subject";

    public Appointment()
      : base("appointment")
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

    [AttributeLogicalName("ait_courtcase")]
    public EntityReference ait_CourtCase
    {
      get => this.GetAttributeValue<EntityReference>("ait_courtcase");
      set
      {
        this.OnPropertyChanging(nameof (ait_CourtCase));
        this.SetAttributeValue("ait_courtcase", (object) value);
        this.OnPropertyChanged(nameof (ait_CourtCase));
      }
    }

    [AttributeLogicalName("ait_courtclerk")]
    public EntityReference ait_CourtClerk
    {
      get => this.GetAttributeValue<EntityReference>("ait_courtclerk");
      set
      {
        this.OnPropertyChanging(nameof (ait_CourtClerk));
        this.SetAttributeValue("ait_courtclerk", (object) value);
        this.OnPropertyChanged(nameof (ait_CourtClerk));
      }
    }

    [AttributeLogicalName("ait_courtreporter")]
    public EntityReference ait_CourtReporter
    {
      get => this.GetAttributeValue<EntityReference>("ait_courtreporter");
      set
      {
        this.OnPropertyChanging(nameof (ait_CourtReporter));
        this.SetAttributeValue("ait_courtreporter", (object) value);
        this.OnPropertyChanged(nameof (ait_CourtReporter));
      }
    }

    [AttributeLogicalName("ait_courtroom")]
    public EntityReference ait_CourtRoom
    {
      get => this.GetAttributeValue<EntityReference>("ait_courtroom");
      set
      {
        this.OnPropertyChanging(nameof (ait_CourtRoom));
        this.SetAttributeValue("ait_courtroom", (object) value);
        this.OnPropertyChanged(nameof (ait_CourtRoom));
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

    [AttributeLogicalName("ait_hearingtype")]
    public OptionSetValue ait_HearingType
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_hearingtype");
      set
      {
        this.OnPropertyChanging(nameof (ait_HearingType));
        this.SetAttributeValue("ait_hearingtype", (object) value);
        this.OnPropertyChanged(nameof (ait_HearingType));
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

    [AttributeLogicalName("ait_judge")]
    public EntityReference ait_Judge
    {
      get => this.GetAttributeValue<EntityReference>("ait_judge");
      set
      {
        this.OnPropertyChanging(nameof (ait_Judge));
        this.SetAttributeValue("ait_judge", (object) value);
        this.OnPropertyChanged(nameof (ait_Judge));
      }
    }

    [AttributeLogicalName("ait_otherdescription")]
    public string ait_OtherDescription
    {
      get => this.GetAttributeValue<string>("ait_otherdescription");
      set
      {
        this.OnPropertyChanging(nameof (ait_OtherDescription));
        this.SetAttributeValue("ait_otherdescription", (object) value);
        this.OnPropertyChanged(nameof (ait_OtherDescription));
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

    [AttributeLogicalName("attachmentcount")]
    public int? AttachmentCount => this.GetAttributeValue<int?>("attachmentcount");

    [AttributeLogicalName("attachmenterrors")]
    public OptionSetValue AttachmentErrors
    {
      get => this.GetAttributeValue<OptionSetValue>("attachmenterrors");
      set
      {
        this.OnPropertyChanging(nameof (AttachmentErrors));
        this.SetAttributeValue("attachmenterrors", (object) value);
        this.OnPropertyChanged(nameof (AttachmentErrors));
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

    [AttributeLogicalName("instancetypecode")]
    public OptionSetValue InstanceTypeCode
    {
      get => this.GetAttributeValue<OptionSetValue>("instancetypecode");
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

    [AttributeLogicalName("isdraft")]
    public bool? IsDraft
    {
      get => this.GetAttributeValue<bool?>("isdraft");
      set
      {
        this.OnPropertyChanging(nameof (IsDraft));
        this.SetAttributeValue("isdraft", (object) value);
        this.OnPropertyChanged(nameof (IsDraft));
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

    [AttributeLogicalName("isunsafe")]
    public int? IsUnsafe => this.GetAttributeValue<int?>("isunsafe");

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

    [AttributeLogicalName("modifiedfieldsmask")]
    public string ModifiedFieldsMask => this.GetAttributeValue<string>("modifiedfieldsmask");

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

    [AttributeLogicalName("originalstartdate")]
    public DateTime? OriginalStartDate => this.GetAttributeValue<DateTime?>("originalstartdate");

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
    public AppointmentState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new AppointmentState?((AppointmentState) Enum.ToObject(typeof (AppointmentState), attributeValue.Value)) : new AppointmentState?();
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

    [RelationshipSchemaName("ait_appointment_ait_planactivity_Appointment")]
    public IEnumerable<ait_planactivity> ait_appointment_ait_planactivity_Appointment
    {
      get
      {
        return this.GetRelatedEntities<ait_planactivity>(nameof (ait_appointment_ait_planactivity_Appointment), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_appointment_ait_planactivity_Appointment));
        this.SetRelatedEntities<ait_planactivity>(nameof (ait_appointment_ait_planactivity_Appointment), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_appointment_ait_planactivity_Appointment));
      }
    }

    [RelationshipSchemaName("appointment_actioncard")]
    public IEnumerable<ActionCard> appointment_actioncard
    {
      get
      {
        return this.GetRelatedEntities<ActionCard>(nameof (appointment_actioncard), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appointment_actioncard));
        this.SetRelatedEntities<ActionCard>(nameof (appointment_actioncard), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appointment_actioncard));
      }
    }

    [RelationshipSchemaName("appointment_activity_mime_attachment")]
    public IEnumerable<ActivityMimeAttachment> appointment_activity_mime_attachment
    {
      get
      {
        return this.GetRelatedEntities<ActivityMimeAttachment>(nameof (appointment_activity_mime_attachment), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appointment_activity_mime_attachment));
        this.SetRelatedEntities<ActivityMimeAttachment>(nameof (appointment_activity_mime_attachment), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appointment_activity_mime_attachment));
      }
    }

    [RelationshipSchemaName("appointment_activity_parties")]
    public IEnumerable<ActivityParty> appointment_activity_parties
    {
      get
      {
        return this.GetRelatedEntities<ActivityParty>(nameof (appointment_activity_parties), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appointment_activity_parties));
        this.SetRelatedEntities<ActivityParty>(nameof (appointment_activity_parties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appointment_activity_parties));
      }
    }

    [RelationshipSchemaName("Appointment_Annotation")]
    public IEnumerable<Annotation> Appointment_Annotation
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (Appointment_Annotation), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Appointment_Annotation));
        this.SetRelatedEntities<Annotation>(nameof (Appointment_Annotation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Appointment_Annotation));
      }
    }

    [RelationshipSchemaName("Appointment_AsyncOperations")]
    public IEnumerable<AsyncOperation> Appointment_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (Appointment_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Appointment_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (Appointment_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Appointment_AsyncOperations));
      }
    }

    [RelationshipSchemaName("Appointment_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> Appointment_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (Appointment_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Appointment_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (Appointment_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Appointment_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("appointment_connections1")]
    public IEnumerable<Connection> appointment_connections1
    {
      get
      {
        return this.GetRelatedEntities<Connection>(nameof (appointment_connections1), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appointment_connections1));
        this.SetRelatedEntities<Connection>(nameof (appointment_connections1), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appointment_connections1));
      }
    }

    [RelationshipSchemaName("appointment_connections2")]
    public IEnumerable<Connection> appointment_connections2
    {
      get
      {
        return this.GetRelatedEntities<Connection>(nameof (appointment_connections2), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appointment_connections2));
        this.SetRelatedEntities<Connection>(nameof (appointment_connections2), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appointment_connections2));
      }
    }

    [RelationshipSchemaName("Appointment_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> Appointment_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (Appointment_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Appointment_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (Appointment_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Appointment_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("Appointment_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> Appointment_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (Appointment_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Appointment_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (Appointment_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Appointment_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("appointment_PostFollows")]
    public IEnumerable<PostFollow> appointment_PostFollows
    {
      get
      {
        return this.GetRelatedEntities<PostFollow>(nameof (appointment_PostFollows), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appointment_PostFollows));
        this.SetRelatedEntities<PostFollow>(nameof (appointment_PostFollows), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appointment_PostFollows));
      }
    }

    [RelationshipSchemaName("appointment_principalobjectattributeaccess")]
    public IEnumerable<PrincipalObjectAttributeAccess> appointment_principalobjectattributeaccess
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (appointment_principalobjectattributeaccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appointment_principalobjectattributeaccess));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (appointment_principalobjectattributeaccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appointment_principalobjectattributeaccess));
      }
    }

    [RelationshipSchemaName("Appointment_ProcessSessions")]
    public IEnumerable<ProcessSession> Appointment_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (Appointment_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Appointment_ProcessSessions));
        this.SetRelatedEntities<ProcessSession>(nameof (Appointment_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Appointment_ProcessSessions));
      }
    }

    [RelationshipSchemaName("Appointment_QueueItem")]
    public IEnumerable<QueueItem> Appointment_QueueItem
    {
      get => this.GetRelatedEntities<QueueItem>(nameof (Appointment_QueueItem), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Appointment_QueueItem));
        this.SetRelatedEntities<QueueItem>(nameof (Appointment_QueueItem), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Appointment_QueueItem));
      }
    }

    [RelationshipSchemaName("Appointment_SyncErrors")]
    public IEnumerable<SyncError> Appointment_SyncErrors
    {
      get => this.GetRelatedEntities<SyncError>(nameof (Appointment_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Appointment_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (Appointment_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Appointment_SyncErrors));
      }
    }

    [RelationshipSchemaName("slakpiinstance_appointment")]
    public IEnumerable<SLAKPIInstance> slakpiinstance_appointment
    {
      get
      {
        return this.GetRelatedEntities<SLAKPIInstance>(nameof (slakpiinstance_appointment), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (slakpiinstance_appointment));
        this.SetRelatedEntities<SLAKPIInstance>(nameof (slakpiinstance_appointment), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (slakpiinstance_appointment));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_appointment")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_appointment
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_appointment), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_appointment));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_appointment), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_appointment));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Account_Appointments")]
    public Account Account_Appointments
    {
      get => this.GetRelatedEntity<Account>(nameof (Account_Appointments), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Account_Appointments));
        this.SetRelatedEntity<Account>(nameof (Account_Appointments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Account_Appointments));
      }
    }

    [AttributeLogicalName("activityid")]
    [RelationshipSchemaName("activity_pointer_appointment")]
    public ActivityPointer activity_pointer_appointment
    {
      get
      {
        return this.GetRelatedEntity<ActivityPointer>(nameof (activity_pointer_appointment), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (activity_pointer_appointment));
        this.SetRelatedEntity<ActivityPointer>(nameof (activity_pointer_appointment), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (activity_pointer_appointment));
      }
    }

    [AttributeLogicalName("ait_caseplan")]
    [RelationshipSchemaName("ait_ait_caseplan_appointment_Plan")]
    public ait_caseplan ait_ait_caseplan_appointment_Plan
    {
      get
      {
        return this.GetRelatedEntity<ait_caseplan>(nameof (ait_ait_caseplan_appointment_Plan), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_caseplan_appointment_Plan));
        this.SetRelatedEntity<ait_caseplan>(nameof (ait_ait_caseplan_appointment_Plan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_caseplan_appointment_Plan));
      }
    }

    [AttributeLogicalName("ait_individual")]
    [RelationshipSchemaName("ait_ait_clientprofile_appointment_Individual")]
    public ait_clientprofile ait_ait_clientprofile_appointment_Individual
    {
      get
      {
        return this.GetRelatedEntity<ait_clientprofile>(nameof (ait_ait_clientprofile_appointment_Individual), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_clientprofile_appointment_Individual));
        this.SetRelatedEntity<ait_clientprofile>(nameof (ait_ait_clientprofile_appointment_Individual), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_clientprofile_appointment_Individual));
      }
    }

    [AttributeLogicalName("ait_familygroup")]
    [RelationshipSchemaName("ait_ait_familygroup_appointment_FamilyGroup")]
    public ait_familygroup ait_ait_familygroup_appointment_FamilyGroup
    {
      get
      {
        return this.GetRelatedEntity<ait_familygroup>(nameof (ait_ait_familygroup_appointment_FamilyGroup), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_familygroup_appointment_FamilyGroup));
        this.SetRelatedEntity<ait_familygroup>(nameof (ait_ait_familygroup_appointment_FamilyGroup), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_familygroup_appointment_FamilyGroup));
      }
    }

    [AttributeLogicalName("ait_outcome")]
    [RelationshipSchemaName("ait_ait_outcome_appointment_Outcome")]
    public ait_outcome ait_ait_outcome_appointment_Outcome
    {
      get
      {
        return this.GetRelatedEntity<ait_outcome>(nameof (ait_ait_outcome_appointment_Outcome), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_outcome_appointment_Outcome));
        this.SetRelatedEntity<ait_outcome>(nameof (ait_ait_outcome_appointment_Outcome), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_outcome_appointment_Outcome));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_assessment_Appointments")]
    public ait_assessment ait_assessment_Appointments
    {
      get
      {
        return this.GetRelatedEntity<ait_assessment>(nameof (ait_assessment_Appointments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_assessment_Appointments));
        this.SetRelatedEntity<ait_assessment>(nameof (ait_assessment_Appointments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_assessment_Appointments));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_case_Appointments")]
    public ait_case ait_case_Appointments
    {
      get => this.GetRelatedEntity<ait_case>(nameof (ait_case_Appointments), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_case_Appointments));
        this.SetRelatedEntity<ait_case>(nameof (ait_case_Appointments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_case_Appointments));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_casenote_Appointments")]
    public ait_casenote ait_casenote_Appointments
    {
      get
      {
        return this.GetRelatedEntity<ait_casenote>(nameof (ait_casenote_Appointments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_casenote_Appointments));
        this.SetRelatedEntity<ait_casenote>(nameof (ait_casenote_Appointments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_casenote_Appointments));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_caseplan_Appointments")]
    public ait_caseplan ait_caseplan_Appointments
    {
      get
      {
        return this.GetRelatedEntity<ait_caseplan>(nameof (ait_caseplan_Appointments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_caseplan_Appointments));
        this.SetRelatedEntity<ait_caseplan>(nameof (ait_caseplan_Appointments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_caseplan_Appointments));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_changerequest_Appointments")]
    public ait_changerequest ait_changerequest_Appointments
    {
      get
      {
        return this.GetRelatedEntity<ait_changerequest>(nameof (ait_changerequest_Appointments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_changerequest_Appointments));
        this.SetRelatedEntity<ait_changerequest>(nameof (ait_changerequest_Appointments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_changerequest_Appointments));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_clientprofile_Appointments")]
    public ait_clientprofile ait_clientprofile_Appointments
    {
      get
      {
        return this.GetRelatedEntity<ait_clientprofile>(nameof (ait_clientprofile_Appointments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_Appointments));
        this.SetRelatedEntity<ait_clientprofile>(nameof (ait_clientprofile_Appointments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_Appointments));
      }
    }

    [AttributeLogicalName("ait_courtcase")]
    [RelationshipSchemaName("ait_courtcase_appointment_CourtCase")]
    public ait_courtcase ait_courtcase_appointment_CourtCase
    {
      get
      {
        return this.GetRelatedEntity<ait_courtcase>(nameof (ait_courtcase_appointment_CourtCase), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtcase_appointment_CourtCase));
        this.SetRelatedEntity<ait_courtcase>(nameof (ait_courtcase_appointment_CourtCase), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtcase_appointment_CourtCase));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_courtcase_Appointments")]
    public ait_courtcase ait_courtcase_Appointments
    {
      get
      {
        return this.GetRelatedEntity<ait_courtcase>(nameof (ait_courtcase_Appointments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtcase_Appointments));
        this.SetRelatedEntity<ait_courtcase>(nameof (ait_courtcase_Appointments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtcase_Appointments));
      }
    }

    [AttributeLogicalName("ait_courtroom")]
    [RelationshipSchemaName("ait_courtroom_appointment_CourtRoom")]
    public ait_courtroom ait_courtroom_appointment_CourtRoom
    {
      get
      {
        return this.GetRelatedEntity<ait_courtroom>(nameof (ait_courtroom_appointment_CourtRoom), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtroom_appointment_CourtRoom));
        this.SetRelatedEntity<ait_courtroom>(nameof (ait_courtroom_appointment_CourtRoom), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtroom_appointment_CourtRoom));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_familygroup_Appointments")]
    public ait_familygroup ait_familygroup_Appointments
    {
      get
      {
        return this.GetRelatedEntity<ait_familygroup>(nameof (ait_familygroup_Appointments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familygroup_Appointments));
        this.SetRelatedEntity<ait_familygroup>(nameof (ait_familygroup_Appointments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familygroup_Appointments));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_goal_Appointments")]
    public ait_goal ait_goal_Appointments
    {
      get => this.GetRelatedEntity<ait_goal>(nameof (ait_goal_Appointments), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_goal_Appointments));
        this.SetRelatedEntity<ait_goal>(nameof (ait_goal_Appointments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_goal_Appointments));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_icwaadoption_Appointments")]
    public ait_icwaadoption ait_icwaadoption_Appointments
    {
      get
      {
        return this.GetRelatedEntity<ait_icwaadoption>(nameof (ait_icwaadoption_Appointments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaadoption_Appointments));
        this.SetRelatedEntity<ait_icwaadoption>(nameof (ait_icwaadoption_Appointments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaadoption_Appointments));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_icwanotice_Appointments")]
    public ait_icwanotice ait_icwanotice_Appointments
    {
      get
      {
        return this.GetRelatedEntity<ait_icwanotice>(nameof (ait_icwanotice_Appointments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwanotice_Appointments));
        this.SetRelatedEntity<ait_icwanotice>(nameof (ait_icwanotice_Appointments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwanotice_Appointments));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_incident_Appointments")]
    public ait_incident ait_incident_Appointments
    {
      get
      {
        return this.GetRelatedEntity<ait_incident>(nameof (ait_incident_Appointments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incident_Appointments));
        this.SetRelatedEntity<ait_incident>(nameof (ait_incident_Appointments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incident_Appointments));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_investigation_Appointments")]
    public ait_investigation ait_investigation_Appointments
    {
      get
      {
        return this.GetRelatedEntity<ait_investigation>(nameof (ait_investigation_Appointments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_investigation_Appointments));
        this.SetRelatedEntity<ait_investigation>(nameof (ait_investigation_Appointments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_investigation_Appointments));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_outcome_Appointments")]
    public ait_outcome ait_outcome_Appointments
    {
      get
      {
        return this.GetRelatedEntity<ait_outcome>(nameof (ait_outcome_Appointments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_outcome_Appointments));
        this.SetRelatedEntity<ait_outcome>(nameof (ait_outcome_Appointments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_outcome_Appointments));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_planactivity_Appointments")]
    public ait_planactivity ait_planactivity_Appointments
    {
      get
      {
        return this.GetRelatedEntity<ait_planactivity>(nameof (ait_planactivity_Appointments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_planactivity_Appointments));
        this.SetRelatedEntity<ait_planactivity>(nameof (ait_planactivity_Appointments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_planactivity_Appointments));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_program_Appointments")]
    public ait_program ait_program_Appointments
    {
      get
      {
        return this.GetRelatedEntity<ait_program>(nameof (ait_program_Appointments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_program_Appointments));
        this.SetRelatedEntity<ait_program>(nameof (ait_program_Appointments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_program_Appointments));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_referral_Appointments")]
    public ait_referral ait_referral_Appointments
    {
      get
      {
        return this.GetRelatedEntity<ait_referral>(nameof (ait_referral_Appointments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_referral_Appointments));
        this.SetRelatedEntity<ait_referral>(nameof (ait_referral_Appointments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_referral_Appointments));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_servicerequest_Appointments")]
    public ait_servicerequest ait_servicerequest_Appointments
    {
      get
      {
        return this.GetRelatedEntity<ait_servicerequest>(nameof (ait_servicerequest_Appointments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_Appointments));
        this.SetRelatedEntity<ait_servicerequest>(nameof (ait_servicerequest_Appointments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_Appointments));
      }
    }

    [AttributeLogicalName("ait_courtclerk")]
    [RelationshipSchemaName("ait_systemuser_appointment_CourtClerk")]
    public SystemUser ait_systemuser_appointment_CourtClerk
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (ait_systemuser_appointment_CourtClerk), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_systemuser_appointment_CourtClerk));
        this.SetRelatedEntity<SystemUser>(nameof (ait_systemuser_appointment_CourtClerk), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_systemuser_appointment_CourtClerk));
      }
    }

    [AttributeLogicalName("ait_courtreporter")]
    [RelationshipSchemaName("ait_systemuser_appointment_CourtReporter")]
    public SystemUser ait_systemuser_appointment_CourtReporter
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (ait_systemuser_appointment_CourtReporter), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_systemuser_appointment_CourtReporter));
        this.SetRelatedEntity<SystemUser>(nameof (ait_systemuser_appointment_CourtReporter), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_systemuser_appointment_CourtReporter));
      }
    }

    [AttributeLogicalName("ait_judge")]
    [RelationshipSchemaName("ait_systemuser_appointment_Judge")]
    public SystemUser ait_systemuser_appointment_Judge
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (ait_systemuser_appointment_Judge), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_systemuser_appointment_Judge));
        this.SetRelatedEntity<SystemUser>(nameof (ait_systemuser_appointment_Judge), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_systemuser_appointment_Judge));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_appointment_activities")]
    public BusinessUnit business_unit_appointment_activities
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_appointment_activities), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Contact_Appointments")]
    public Contact Contact_Appointments
    {
      get => this.GetRelatedEntity<Contact>(nameof (Contact_Appointments), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Contact_Appointments));
        this.SetRelatedEntity<Contact>(nameof (Contact_Appointments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Contact_Appointments));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("KnowledgeArticle_Appointments")]
    public KnowledgeArticle KnowledgeArticle_Appointments
    {
      get
      {
        return this.GetRelatedEntity<KnowledgeArticle>(nameof (KnowledgeArticle_Appointments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeArticle_Appointments));
        this.SetRelatedEntity<KnowledgeArticle>(nameof (KnowledgeArticle_Appointments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeArticle_Appointments));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("KnowledgeBaseRecord_Appointments")]
    public KnowledgeBaseRecord KnowledgeBaseRecord_Appointments
    {
      get
      {
        return this.GetRelatedEntity<KnowledgeBaseRecord>(nameof (KnowledgeBaseRecord_Appointments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeBaseRecord_Appointments));
        this.SetRelatedEntity<KnowledgeBaseRecord>(nameof (KnowledgeBaseRecord_Appointments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeBaseRecord_Appointments));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_appointment_createdby")]
    public SystemUser lk_appointment_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_appointment_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_appointment_createdonbehalfby")]
    public SystemUser lk_appointment_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_appointment_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_appointment_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_appointment_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_appointment_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_appointment_modifiedby")]
    public SystemUser lk_appointment_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_appointment_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_appointment_modifiedonbehalfby")]
    public SystemUser lk_appointment_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_appointment_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_appointment_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_appointment_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_appointment_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("slaid")]
    [RelationshipSchemaName("manualsla_appointment")]
    public SLA manualsla_appointment
    {
      get => this.GetRelatedEntity<SLA>(nameof (manualsla_appointment), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (manualsla_appointment));
        this.SetRelatedEntity<SLA>(nameof (manualsla_appointment), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (manualsla_appointment));
      }
    }

    [AttributeLogicalName("stageid")]
    [RelationshipSchemaName("processstage_appointments")]
    public ProcessStage processstage_appointments
    {
      get
      {
        return this.GetRelatedEntity<ProcessStage>(nameof (processstage_appointments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (processstage_appointments));
        this.SetRelatedEntity<ProcessStage>(nameof (processstage_appointments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (processstage_appointments));
      }
    }

    [AttributeLogicalName("seriesid")]
    [RelationshipSchemaName("recurringappointmentmaster_appointment")]
    public RecurringAppointmentMaster recurringappointmentmaster_appointment
    {
      get
      {
        return this.GetRelatedEntity<RecurringAppointmentMaster>(nameof (recurringappointmentmaster_appointment), new EntityRole?());
      }
    }

    [AttributeLogicalName("slainvokedid")]
    [RelationshipSchemaName("sla_appointment")]
    public SLA sla_appointment
    {
      get => this.GetRelatedEntity<SLA>(nameof (sla_appointment), new EntityRole?());
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_appointment")]
    public Team team_appointment
    {
      get => this.GetRelatedEntity<Team>(nameof (team_appointment), new EntityRole?());
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_Appointment")]
    public TransactionCurrency TransactionCurrency_Appointment
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_Appointment), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_Appointment));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_Appointment), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_Appointment));
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_appointment")]
    public SystemUser user_appointment
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_appointment), new EntityRole?());
    }

    public Appointment(object anonymousType)
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
