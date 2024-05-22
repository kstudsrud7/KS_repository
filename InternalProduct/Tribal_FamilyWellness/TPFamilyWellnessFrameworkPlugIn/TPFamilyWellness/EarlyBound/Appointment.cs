// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EarlyBound.Appointment
// Assembly: TPFamilyWellness.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: C0DF2365-4BFC-418D-B654-2FF4D2B8EB1A
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPFamilyWellnessFrameworkPlugIn-A0924F88-EA00-EA11-A82D-000D3A1F0599\TPFamilyWellnessFrameworkPlugIn.dll

using Microsoft.Xrm.Sdk;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;

#nullable disable
namespace TPFamilyWellness.EarlyBound
{
  [DataContract]
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("appointment")]
  [GeneratedCode("CrmSvcUtil", "9.0.0.9154")]
  public class Appointment : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "appointment";
    public const int EntityTypeCode = 4201;

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
        this.OnPropertyChanged(nameof (ActivityId));
      }
    }

    [AttributeLogicalName("activitytypecode")]
    public string ActivityTypeCode => this.GetAttributeValue<string>("activitytypecode");

    [AttributeLogicalName("activitytypecodename")]
    public object ActivityTypeCodeName => this.GetAttributeValue<object>("activitytypecodename");

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

    [AttributeLogicalName("ait_caseplanname")]
    public string ait_CasePlanName => this.GetAttributeValue<string>("ait_caseplanname");

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

    [AttributeLogicalName("ait_courtcasename")]
    public string ait_CourtCaseName => this.GetAttributeValue<string>("ait_courtcasename");

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

    [AttributeLogicalName("ait_courtclerkname")]
    public string ait_CourtClerkName => this.GetAttributeValue<string>("ait_courtclerkname");

    [AttributeLogicalName("ait_courtclerkyominame")]
    public string ait_CourtClerkYomiName
    {
      get => this.GetAttributeValue<string>("ait_courtclerkyominame");
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

    [AttributeLogicalName("ait_courtreportername")]
    public string ait_CourtReporterName => this.GetAttributeValue<string>("ait_courtreportername");

    [AttributeLogicalName("ait_courtreporteryominame")]
    public string ait_CourtReporterYomiName
    {
      get => this.GetAttributeValue<string>("ait_courtreporteryominame");
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

    [AttributeLogicalName("ait_courtroomname")]
    public string ait_CourtRoomName => this.GetAttributeValue<string>("ait_courtroomname");

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

    [AttributeLogicalName("ait_familygroupname")]
    public string ait_FamilyGroupName => this.GetAttributeValue<string>("ait_familygroupname");

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

    [AttributeLogicalName("ait_hearingtypename")]
    public object ait_hearingtypeName => this.GetAttributeValue<object>("ait_hearingtypename");

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

    [AttributeLogicalName("ait_individualname")]
    public string ait_IndividualName => this.GetAttributeValue<string>("ait_individualname");

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

    [AttributeLogicalName("ait_judgename")]
    public string ait_JudgeName => this.GetAttributeValue<string>("ait_judgename");

    [AttributeLogicalName("ait_judgeyominame")]
    public string ait_JudgeYomiName => this.GetAttributeValue<string>("ait_judgeyominame");

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

    [AttributeLogicalName("ait_outcomename")]
    public string ait_OutcomeName => this.GetAttributeValue<string>("ait_outcomename");

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

    [AttributeLogicalName("attachmenterrorsname")]
    public object AttachmentErrorsName => this.GetAttributeValue<object>("attachmenterrorsname");

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

    [AttributeLogicalName("createdbyname")]
    public string CreatedByName => this.GetAttributeValue<string>("createdbyname");

    [AttributeLogicalName("createdbyyominame")]
    public string CreatedByYomiName => this.GetAttributeValue<string>("createdbyyominame");

    [AttributeLogicalName("createdon")]
    public DateTime? CreatedOn => this.GetAttributeValue<DateTime?>("createdon");

    [AttributeLogicalName("createdonbehalfby")]
    public EntityReference CreatedOnBehalfBy
    {
      get => this.GetAttributeValue<EntityReference>("createdonbehalfby");
    }

    [AttributeLogicalName("createdonbehalfbyname")]
    public string CreatedOnBehalfByName => this.GetAttributeValue<string>("createdonbehalfbyname");

    [AttributeLogicalName("createdonbehalfbyyominame")]
    public string CreatedOnBehalfByYomiName
    {
      get => this.GetAttributeValue<string>("createdonbehalfbyyominame");
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

    [AttributeLogicalName("instancetypecodename")]
    public object InstanceTypeCodeName => this.GetAttributeValue<object>("instancetypecodename");

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

    [AttributeLogicalName("isalldayeventname")]
    public object IsAllDayEventName => this.GetAttributeValue<object>("isalldayeventname");

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

    [AttributeLogicalName("isbilledname")]
    public object IsBilledName => this.GetAttributeValue<object>("isbilledname");

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

    [AttributeLogicalName("isdraftname")]
    public object IsDraftName => this.GetAttributeValue<object>("isdraftname");

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

    [AttributeLogicalName("ismapiprivatename")]
    public object IsMapiPrivateName => this.GetAttributeValue<object>("ismapiprivatename");

    [AttributeLogicalName("isregularactivity")]
    public bool? IsRegularActivity => this.GetAttributeValue<bool?>("isregularactivity");

    [AttributeLogicalName("isregularactivityname")]
    public object IsRegularActivityName => this.GetAttributeValue<object>("isregularactivityname");

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

    [AttributeLogicalName("isworkflowcreatedname")]
    public object IsWorkflowCreatedName => this.GetAttributeValue<object>("isworkflowcreatedname");

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

    [AttributeLogicalName("modifiedbyname")]
    public string ModifiedByName => this.GetAttributeValue<string>("modifiedbyname");

    [AttributeLogicalName("modifiedbyyominame")]
    public string ModifiedByYomiName => this.GetAttributeValue<string>("modifiedbyyominame");

    [AttributeLogicalName("modifiedfieldsmask")]
    public string ModifiedFieldsMask => this.GetAttributeValue<string>("modifiedfieldsmask");

    [AttributeLogicalName("modifiedon")]
    public DateTime? ModifiedOn => this.GetAttributeValue<DateTime?>("modifiedon");

    [AttributeLogicalName("modifiedonbehalfby")]
    public EntityReference ModifiedOnBehalfBy
    {
      get => this.GetAttributeValue<EntityReference>("modifiedonbehalfby");
    }

    [AttributeLogicalName("modifiedonbehalfbyname")]
    public string ModifiedOnBehalfByName
    {
      get => this.GetAttributeValue<string>("modifiedonbehalfbyname");
    }

    [AttributeLogicalName("modifiedonbehalfbyyominame")]
    public string ModifiedOnBehalfByYomiName
    {
      get => this.GetAttributeValue<string>("modifiedonbehalfbyyominame");
    }

    [AttributeLogicalName("onholdtime")]
    public int? OnHoldTime => this.GetAttributeValue<int?>("onholdtime");

    [AttributeLogicalName("optionalattendees")]
    public IEnumerable<Entity> OptionalAttendees
    {
      get
      {
        EntityCollection attributeValue = this.GetAttributeValue<EntityCollection>("optionalattendees");
        return attributeValue != null && attributeValue.Entities != null ? ((IEnumerable) attributeValue.Entities).Cast<Entity>() : (IEnumerable<Entity>) null;
      }
      set
      {
        this.OnPropertyChanging(nameof (OptionalAttendees));
        if (value == null)
          this.SetAttributeValue("optionalattendees", (object) value);
        else
          this.SetAttributeValue("optionalattendees", (object) new EntityCollection((IList<Entity>) new List<Entity>(value)));
        this.OnPropertyChanged(nameof (OptionalAttendees));
      }
    }

    [AttributeLogicalName("organizer")]
    public IEnumerable<Entity> Organizer
    {
      get
      {
        EntityCollection attributeValue = this.GetAttributeValue<EntityCollection>("organizer");
        return attributeValue != null && attributeValue.Entities != null ? ((IEnumerable) attributeValue.Entities).Cast<Entity>() : (IEnumerable<Entity>) null;
      }
      set
      {
        this.OnPropertyChanging(nameof (Organizer));
        if (value == null)
          this.SetAttributeValue("organizer", (object) value);
        else
          this.SetAttributeValue("organizer", (object) new EntityCollection((IList<Entity>) new List<Entity>(value)));
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

    [AttributeLogicalName("owneridname")]
    public string OwnerIdName => this.GetAttributeValue<string>("owneridname");

    [AttributeLogicalName("owneridtype")]
    public string OwnerIdType
    {
      get => this.GetAttributeValue<string>("owneridtype");
      set
      {
        this.OnPropertyChanging(nameof (OwnerIdType));
        this.SetAttributeValue("owneridtype", (object) value);
        this.OnPropertyChanged(nameof (OwnerIdType));
      }
    }

    [AttributeLogicalName("owneridyominame")]
    public string OwnerIdYomiName => this.GetAttributeValue<string>("owneridyominame");

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

    [AttributeLogicalName("prioritycodename")]
    public object PriorityCodeName => this.GetAttributeValue<object>("prioritycodename");

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

    [AttributeLogicalName("regardingobjectidname")]
    public string RegardingObjectIdName => this.GetAttributeValue<string>("regardingobjectidname");

    [AttributeLogicalName("regardingobjectidyominame")]
    public string RegardingObjectIdYomiName
    {
      get => this.GetAttributeValue<string>("regardingobjectidyominame");
    }

    [AttributeLogicalName("regardingobjecttypecode")]
    public string RegardingObjectTypeCode
    {
      get => this.GetAttributeValue<string>("regardingobjecttypecode");
      set
      {
        this.OnPropertyChanging(nameof (RegardingObjectTypeCode));
        this.SetAttributeValue("regardingobjecttypecode", (object) value);
        this.OnPropertyChanged(nameof (RegardingObjectTypeCode));
      }
    }

    [AttributeLogicalName("requiredattendees")]
    public IEnumerable<Entity> requiredattendees
    {
      get
      {
        EntityCollection attributeValue = this.GetAttributeValue<EntityCollection>(nameof (requiredattendees));
        return attributeValue != null && attributeValue.Entities != null ? ((IEnumerable) attributeValue.Entities).Cast<Entity>() : (IEnumerable<Entity>) null;
      }
      set
      {
        this.OnPropertyChanging(nameof (requiredattendees));
        if (value == null)
          this.SetAttributeValue(nameof (requiredattendees), (object) value);
        else
          this.SetAttributeValue(nameof (requiredattendees), (object) new EntityCollection((IList<Entity>) new List<Entity>(value)));
        this.OnPropertyChanged(nameof (requiredattendees));
      }
    }

    [AttributeLogicalName("safedescription")]
    public string SafeDescription => this.GetAttributeValue<string>("safedescription");

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

    [AttributeLogicalName("slainvokedidname")]
    public string SLAInvokedIdName => this.GetAttributeValue<string>("slainvokedidname");

    [AttributeLogicalName("slaname")]
    public string SLAName => this.GetAttributeValue<string>("slaname");

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
    public AppointmentState? StateCode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>("statecode");
        return attributeValue != null ? new AppointmentState?((AppointmentState) Enum.ToObject(typeof (AppointmentState), attributeValue.Value)) : new AppointmentState?();
      }
      set
      {
        this.OnPropertyChanging(nameof (StateCode));
        if (!value.HasValue)
          this.SetAttributeValue("statecode", (object) null);
        else
          this.SetAttributeValue("statecode", (object) new OptionSetValue((int) value.Value));
        this.OnPropertyChanged(nameof (StateCode));
      }
    }

    [AttributeLogicalName("statecodename")]
    public object StateCodeName => this.GetAttributeValue<object>("statecodename");

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

    [AttributeLogicalName("statuscodename")]
    public object StatusCodeName => this.GetAttributeValue<object>("statuscodename");

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

    [AttributeLogicalName("transactioncurrencyidname")]
    public string TransactionCurrencyIdName
    {
      get => this.GetAttributeValue<string>("transactioncurrencyidname");
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
    [RelationshipSchemaName("ait_casenotefamilywellness_Appointments")]
    public ait_casenotefamilywellness ait_casenotefamilywellness_Appointments
    {
      get
      {
        return this.GetRelatedEntity<ait_casenotefamilywellness>(nameof (ait_casenotefamilywellness_Appointments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_casenotefamilywellness_Appointments));
        this.SetRelatedEntity<ait_casenotefamilywellness>(nameof (ait_casenotefamilywellness_Appointments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_casenotefamilywellness_Appointments));
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
    [RelationshipSchemaName("ait_groupactivityregistration_Appointments")]
    public ait_groupactivityregistration ait_groupactivityregistration_Appointments
    {
      get
      {
        return this.GetRelatedEntity<ait_groupactivityregistration>(nameof (ait_groupactivityregistration_Appointments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_groupactivityregistration_Appointments));
        this.SetRelatedEntity<ait_groupactivityregistration>(nameof (ait_groupactivityregistration_Appointments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_groupactivityregistration_Appointments));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_incidents_Appointments")]
    public ait_incidents ait_incidents_Appointments
    {
      get
      {
        return this.GetRelatedEntity<ait_incidents>(nameof (ait_incidents_Appointments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incidents_Appointments));
        this.SetRelatedEntity<ait_incidents>(nameof (ait_incidents_Appointments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incidents_Appointments));
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
    [RelationshipSchemaName("ait_meetingattendee_Appointments")]
    public ait_meetingattendee ait_meetingattendee_Appointments
    {
      get
      {
        return this.GetRelatedEntity<ait_meetingattendee>(nameof (ait_meetingattendee_Appointments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_meetingattendee_Appointments));
        this.SetRelatedEntity<ait_meetingattendee>(nameof (ait_meetingattendee_Appointments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_meetingattendee_Appointments));
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

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_appointment")]
    public Team team_appointment
    {
      get => this.GetRelatedEntity<Team>(nameof (team_appointment), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_appointment")]
    public SystemUser user_appointment
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_appointment), new EntityRole?());
    }
  }
}
