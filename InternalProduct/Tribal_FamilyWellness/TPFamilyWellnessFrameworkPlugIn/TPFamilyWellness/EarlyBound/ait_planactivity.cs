// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EarlyBound.ait_planactivity
// Assembly: TPFamilyWellness.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: C0DF2365-4BFC-418D-B654-2FF4D2B8EB1A
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPFamilyWellnessFrameworkPlugIn-A0924F88-EA00-EA11-A82D-000D3A1F0599\TPFamilyWellnessFrameworkPlugIn.dll

using Microsoft.Xrm.Sdk;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

#nullable disable
namespace TPFamilyWellness.EarlyBound
{
  [DataContract]
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_planactivity")]
  [GeneratedCode("CrmSvcUtil", "9.0.0.9154")]
  public class ait_planactivity : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_planactivity";
    public const int EntityTypeCode = 10664;

    public ait_planactivity()
      : base(nameof (ait_planactivity))
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

    [AttributeLogicalName("ait_activityautoid")]
    public string ait_ActivityAutoID
    {
      get => this.GetAttributeValue<string>("ait_activityautoid");
      set
      {
        this.OnPropertyChanging(nameof (ait_ActivityAutoID));
        this.SetAttributeValue("ait_activityautoid", (object) value);
        this.OnPropertyChanged(nameof (ait_ActivityAutoID));
      }
    }

    [AttributeLogicalName("ait_activitystatus")]
    public OptionSetValue ait_ActivityStatus
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_activitystatus");
      set
      {
        this.OnPropertyChanging(nameof (ait_ActivityStatus));
        this.SetAttributeValue("ait_activitystatus", (object) value);
        this.OnPropertyChanged(nameof (ait_ActivityStatus));
      }
    }

    [AttributeLogicalName("ait_activitystatusname")]
    public object ait_activitystatusName
    {
      get => this.GetAttributeValue<object>("ait_activitystatusname");
    }

    [AttributeLogicalName("ait_activitytype")]
    public OptionSetValue ait_ActivityType
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_activitytype");
      set
      {
        this.OnPropertyChanging(nameof (ait_ActivityType));
        this.SetAttributeValue("ait_activitytype", (object) value);
        this.OnPropertyChanged(nameof (ait_ActivityType));
      }
    }

    [AttributeLogicalName("ait_activitytypename")]
    public object ait_activitytypeName => this.GetAttributeValue<object>("ait_activitytypename");

    [AttributeLogicalName("ait_appointment")]
    public EntityReference ait_Appointment
    {
      get => this.GetAttributeValue<EntityReference>("ait_appointment");
      set
      {
        this.OnPropertyChanging(nameof (ait_Appointment));
        this.SetAttributeValue("ait_appointment", (object) value);
        this.OnPropertyChanged(nameof (ait_Appointment));
      }
    }

    [AttributeLogicalName("ait_appointmentname")]
    public string ait_AppointmentName => this.GetAttributeValue<string>("ait_appointmentname");

    [AttributeLogicalName("ait_assessment")]
    public EntityReference ait_Assessment
    {
      get => this.GetAttributeValue<EntityReference>("ait_assessment");
      set
      {
        this.OnPropertyChanging(nameof (ait_Assessment));
        this.SetAttributeValue("ait_assessment", (object) value);
        this.OnPropertyChanged(nameof (ait_Assessment));
      }
    }

    [AttributeLogicalName("ait_assessmentname")]
    public string ait_AssessmentName => this.GetAttributeValue<string>("ait_assessmentname");

    [AttributeLogicalName("ait_case")]
    public EntityReference ait_case
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_case));
      set
      {
        this.OnPropertyChanging(nameof (ait_case));
        this.SetAttributeValue(nameof (ait_case), (object) value);
        this.OnPropertyChanged(nameof (ait_case));
      }
    }

    [AttributeLogicalName("ait_casename")]
    public string ait_caseName => this.GetAttributeValue<string>("ait_casename");

    [AttributeLogicalName("ait_casenotes")]
    public EntityReference ait_CaseNotes
    {
      get => this.GetAttributeValue<EntityReference>("ait_casenotes");
      set
      {
        this.OnPropertyChanging(nameof (ait_CaseNotes));
        this.SetAttributeValue("ait_casenotes", (object) value);
        this.OnPropertyChanged(nameof (ait_CaseNotes));
      }
    }

    [AttributeLogicalName("ait_casenotesname")]
    public string ait_CaseNotesName => this.GetAttributeValue<string>("ait_casenotesname");

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

    [AttributeLogicalName("ait_completeddate")]
    public DateTime? ait_CompletedDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_completeddate");
      set
      {
        this.OnPropertyChanging(nameof (ait_CompletedDate));
        this.SetAttributeValue("ait_completeddate", (object) value);
        this.OnPropertyChanged(nameof (ait_CompletedDate));
      }
    }

    [AttributeLogicalName("ait_description")]
    public string ait_Description
    {
      get => this.GetAttributeValue<string>("ait_description");
      set
      {
        this.OnPropertyChanging(nameof (ait_Description));
        this.SetAttributeValue("ait_description", (object) value);
        this.OnPropertyChanged(nameof (ait_Description));
      }
    }

    [AttributeLogicalName("ait_email")]
    public EntityReference ait_Email
    {
      get => this.GetAttributeValue<EntityReference>("ait_email");
      set
      {
        this.OnPropertyChanging(nameof (ait_Email));
        this.SetAttributeValue("ait_email", (object) value);
        this.OnPropertyChanged(nameof (ait_Email));
      }
    }

    [AttributeLogicalName("ait_emailname")]
    public string ait_EmailName => this.GetAttributeValue<string>("ait_emailname");

    [AttributeLogicalName("ait_enddate")]
    public DateTime? ait_EndDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_enddate");
      set
      {
        this.OnPropertyChanging(nameof (ait_EndDate));
        this.SetAttributeValue("ait_enddate", (object) value);
        this.OnPropertyChanged(nameof (ait_EndDate));
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

    [AttributeLogicalName("ait_familygroupname")]
    public string ait_FamilyGroupName => this.GetAttributeValue<string>("ait_familygroupname");

    [AttributeLogicalName("ait_goal")]
    public EntityReference ait_Goal
    {
      get => this.GetAttributeValue<EntityReference>("ait_goal");
      set
      {
        this.OnPropertyChanging(nameof (ait_Goal));
        this.SetAttributeValue("ait_goal", (object) value);
        this.OnPropertyChanged(nameof (ait_Goal));
      }
    }

    [AttributeLogicalName("ait_goalname")]
    public string ait_GoalName => this.GetAttributeValue<string>("ait_goalname");

    [AttributeLogicalName("ait_incidentsid")]
    public EntityReference ait_IncidentsId
    {
      get => this.GetAttributeValue<EntityReference>("ait_incidentsid");
      set
      {
        this.OnPropertyChanging(nameof (ait_IncidentsId));
        this.SetAttributeValue("ait_incidentsid", (object) value);
        this.OnPropertyChanged(nameof (ait_IncidentsId));
      }
    }

    [AttributeLogicalName("ait_incidentsidname")]
    public string ait_IncidentsIdName => this.GetAttributeValue<string>("ait_incidentsidname");

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

    [AttributeLogicalName("ait_name")]
    public string ait_name
    {
      get => this.GetAttributeValue<string>(nameof (ait_name));
      set
      {
        this.OnPropertyChanging(nameof (ait_name));
        this.SetAttributeValue(nameof (ait_name), (object) value);
        this.OnPropertyChanged(nameof (ait_name));
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

    [AttributeLogicalName("ait_phonecall")]
    public EntityReference ait_PhoneCall
    {
      get => this.GetAttributeValue<EntityReference>("ait_phonecall");
      set
      {
        this.OnPropertyChanging(nameof (ait_PhoneCall));
        this.SetAttributeValue("ait_phonecall", (object) value);
        this.OnPropertyChanged(nameof (ait_PhoneCall));
      }
    }

    [AttributeLogicalName("ait_phonecallname")]
    public string ait_PhoneCallName => this.GetAttributeValue<string>("ait_phonecallname");

    [AttributeLogicalName("ait_placement")]
    public EntityReference ait_placement
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_placement));
      set
      {
        this.OnPropertyChanging(nameof (ait_placement));
        this.SetAttributeValue(nameof (ait_placement), (object) value);
        this.OnPropertyChanged(nameof (ait_placement));
      }
    }

    [AttributeLogicalName("ait_placementname")]
    public string ait_placementName => this.GetAttributeValue<string>("ait_placementname");

    [AttributeLogicalName("ait_planactivityid")]
    public Guid? ait_planactivityId
    {
      get => this.GetAttributeValue<Guid?>("ait_planactivityid");
      set
      {
        this.OnPropertyChanging(nameof (ait_planactivityId));
        this.SetAttributeValue("ait_planactivityid", (object) value);
        this.OnPropertyChanged(nameof (ait_planactivityId));
      }
    }

    [AttributeLogicalName("ait_referral")]
    public EntityReference ait_Referral
    {
      get => this.GetAttributeValue<EntityReference>("ait_referral");
      set
      {
        this.OnPropertyChanging(nameof (ait_Referral));
        this.SetAttributeValue("ait_referral", (object) value);
        this.OnPropertyChanged(nameof (ait_Referral));
      }
    }

    [AttributeLogicalName("ait_referralname")]
    public string ait_ReferralName => this.GetAttributeValue<string>("ait_referralname");

    [AttributeLogicalName("ait_safetyplan")]
    public EntityReference ait_SafetyPlan
    {
      get => this.GetAttributeValue<EntityReference>("ait_safetyplan");
      set
      {
        this.OnPropertyChanging(nameof (ait_SafetyPlan));
        this.SetAttributeValue("ait_safetyplan", (object) value);
        this.OnPropertyChanged(nameof (ait_SafetyPlan));
      }
    }

    [AttributeLogicalName("ait_safetyplanname")]
    public string ait_SafetyPlanName => this.GetAttributeValue<string>("ait_safetyplanname");

    [AttributeLogicalName("ait_startdate")]
    public DateTime? ait_StartDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_startdate");
      set
      {
        this.OnPropertyChanging(nameof (ait_StartDate));
        this.SetAttributeValue("ait_startdate", (object) value);
        this.OnPropertyChanged(nameof (ait_StartDate));
      }
    }

    [AttributeLogicalName("ait_statuslabel")]
    public string ait_StatusLabel
    {
      get => this.GetAttributeValue<string>("ait_statuslabel");
      set
      {
        this.OnPropertyChanging(nameof (ait_StatusLabel));
        this.SetAttributeValue("ait_statuslabel", (object) value);
        this.OnPropertyChanged(nameof (ait_StatusLabel));
      }
    }

    [AttributeLogicalName("ait_task")]
    public EntityReference ait_Task
    {
      get => this.GetAttributeValue<EntityReference>("ait_task");
      set
      {
        this.OnPropertyChanging(nameof (ait_Task));
        this.SetAttributeValue("ait_task", (object) value);
        this.OnPropertyChanged(nameof (ait_Task));
      }
    }

    [AttributeLogicalName("ait_taskname")]
    public string ait_TaskName => this.GetAttributeValue<string>("ait_taskname");

    [AttributeLogicalName("ait_timetaken")]
    public int? ait_TimeTaken
    {
      get => this.GetAttributeValue<int?>("ait_timetaken");
      set
      {
        this.OnPropertyChanging(nameof (ait_TimeTaken));
        this.SetAttributeValue("ait_timetaken", (object) value);
        this.OnPropertyChanged(nameof (ait_TimeTaken));
      }
    }

    [AttributeLogicalName("ait_traveltime")]
    public int? ait_TravelTime
    {
      get => this.GetAttributeValue<int?>("ait_traveltime");
      set
      {
        this.OnPropertyChanging(nameof (ait_TravelTime));
        this.SetAttributeValue("ait_traveltime", (object) value);
        this.OnPropertyChanged(nameof (ait_TravelTime));
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

    [AttributeLogicalName("emailaddress")]
    public string EmailAddress
    {
      get => this.GetAttributeValue<string>("emailaddress");
      set
      {
        this.OnPropertyChanging(nameof (EmailAddress));
        this.SetAttributeValue("emailaddress", (object) value);
        this.OnPropertyChanged(nameof (EmailAddress));
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

    [AttributeLogicalName("modifiedbyname")]
    public string ModifiedByName => this.GetAttributeValue<string>("modifiedbyname");

    [AttributeLogicalName("modifiedbyyominame")]
    public string ModifiedByYomiName => this.GetAttributeValue<string>("modifiedbyyominame");

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

    [AttributeLogicalName("statecode")]
    public Ait_planactivityState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new Ait_planactivityState?((Ait_planactivityState) Enum.ToObject(typeof (Ait_planactivityState), attributeValue.Value)) : new Ait_planactivityState?();
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

    [AttributeLogicalName("statecodename")]
    public object statecodeName => this.GetAttributeValue<object>("statecodename");

    [AttributeLogicalName("statuscode")]
    public OptionSetValue statuscode
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (statuscode));
      set
      {
        this.OnPropertyChanging(nameof (statuscode));
        this.SetAttributeValue(nameof (statuscode), (object) value);
        this.OnPropertyChanged(nameof (statuscode));
      }
    }

    [AttributeLogicalName("statuscodename")]
    public object statuscodeName => this.GetAttributeValue<object>("statuscodename");

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

    [RelationshipSchemaName("ait_planactivity_Appointments")]
    public IEnumerable<Appointment> ait_planactivity_Appointments
    {
      get
      {
        return this.GetRelatedEntities<Appointment>(nameof (ait_planactivity_Appointments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_planactivity_Appointments));
        this.SetRelatedEntities<Appointment>(nameof (ait_planactivity_Appointments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_planactivity_Appointments));
      }
    }

    [RelationshipSchemaName("ait_planactivity_Emails")]
    public IEnumerable<Email> ait_planactivity_Emails
    {
      get => this.GetRelatedEntities<Email>(nameof (ait_planactivity_Emails), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_planactivity_Emails));
        this.SetRelatedEntities<Email>(nameof (ait_planactivity_Emails), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_planactivity_Emails));
      }
    }

    [RelationshipSchemaName("ait_planactivity_PhoneCalls")]
    public IEnumerable<PhoneCall> ait_planactivity_PhoneCalls
    {
      get
      {
        return this.GetRelatedEntities<PhoneCall>(nameof (ait_planactivity_PhoneCalls), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_planactivity_PhoneCalls));
        this.SetRelatedEntities<PhoneCall>(nameof (ait_planactivity_PhoneCalls), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_planactivity_PhoneCalls));
      }
    }

    [RelationshipSchemaName("ait_planactivity_Tasks")]
    public IEnumerable<Task> ait_planactivity_Tasks
    {
      get => this.GetRelatedEntities<Task>(nameof (ait_planactivity_Tasks), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_planactivity_Tasks));
        this.SetRelatedEntities<Task>(nameof (ait_planactivity_Tasks), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_planactivity_Tasks));
      }
    }

    [AttributeLogicalName("ait_assessment")]
    [RelationshipSchemaName("ait_ait_assessment_ait_planactivity_Assessment")]
    public ait_assessment ait_ait_assessment_ait_planactivity_Assessment
    {
      get
      {
        return this.GetRelatedEntity<ait_assessment>(nameof (ait_ait_assessment_ait_planactivity_Assessment), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_assessment_ait_planactivity_Assessment));
        this.SetRelatedEntity<ait_assessment>(nameof (ait_ait_assessment_ait_planactivity_Assessment), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_assessment_ait_planactivity_Assessment));
      }
    }

    [AttributeLogicalName("ait_case")]
    [RelationshipSchemaName("ait_ait_case_ait_planactivity_Case")]
    public TPFamilyWellness.EarlyBound.ait_case ait_ait_case_ait_planactivity_Case
    {
      get
      {
        return this.GetRelatedEntity<TPFamilyWellness.EarlyBound.ait_case>(nameof (ait_ait_case_ait_planactivity_Case), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_case_ait_planactivity_Case));
        this.SetRelatedEntity<TPFamilyWellness.EarlyBound.ait_case>(nameof (ait_ait_case_ait_planactivity_Case), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_case_ait_planactivity_Case));
      }
    }

    [AttributeLogicalName("ait_caseplan")]
    [RelationshipSchemaName("ait_ait_caseplan_ait_planactivity_Plan")]
    public ait_caseplan ait_ait_caseplan_ait_planactivity_Plan
    {
      get
      {
        return this.GetRelatedEntity<ait_caseplan>(nameof (ait_ait_caseplan_ait_planactivity_Plan), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_caseplan_ait_planactivity_Plan));
        this.SetRelatedEntity<ait_caseplan>(nameof (ait_ait_caseplan_ait_planactivity_Plan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_caseplan_ait_planactivity_Plan));
      }
    }

    [AttributeLogicalName("ait_individual")]
    [RelationshipSchemaName("ait_ait_clientprofile_ait_planactivity_Individual")]
    public ait_clientprofile ait_ait_clientprofile_ait_planactivity_Individual
    {
      get
      {
        return this.GetRelatedEntity<ait_clientprofile>(nameof (ait_ait_clientprofile_ait_planactivity_Individual), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_clientprofile_ait_planactivity_Individual));
        this.SetRelatedEntity<ait_clientprofile>(nameof (ait_ait_clientprofile_ait_planactivity_Individual), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_clientprofile_ait_planactivity_Individual));
      }
    }

    [AttributeLogicalName("ait_familygroup")]
    [RelationshipSchemaName("ait_ait_familygroup_ait_planactivity_FamilyGroup")]
    public ait_familygroup ait_ait_familygroup_ait_planactivity_FamilyGroup
    {
      get
      {
        return this.GetRelatedEntity<ait_familygroup>(nameof (ait_ait_familygroup_ait_planactivity_FamilyGroup), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_familygroup_ait_planactivity_FamilyGroup));
        this.SetRelatedEntity<ait_familygroup>(nameof (ait_ait_familygroup_ait_planactivity_FamilyGroup), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_familygroup_ait_planactivity_FamilyGroup));
      }
    }

    [AttributeLogicalName("ait_goal")]
    [RelationshipSchemaName("ait_ait_goal_ait_planactivity_Goal")]
    public ait_goal ait_ait_goal_ait_planactivity_Goal
    {
      get
      {
        return this.GetRelatedEntity<ait_goal>(nameof (ait_ait_goal_ait_planactivity_Goal), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_goal_ait_planactivity_Goal));
        this.SetRelatedEntity<ait_goal>(nameof (ait_ait_goal_ait_planactivity_Goal), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_goal_ait_planactivity_Goal));
      }
    }

    [AttributeLogicalName("ait_incidentsid")]
    [RelationshipSchemaName("ait_ait_incidents_ait_planactivity")]
    public ait_incidents ait_ait_incidents_ait_planactivity
    {
      get
      {
        return this.GetRelatedEntity<ait_incidents>(nameof (ait_ait_incidents_ait_planactivity), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_incidents_ait_planactivity));
        this.SetRelatedEntity<ait_incidents>(nameof (ait_ait_incidents_ait_planactivity), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_incidents_ait_planactivity));
      }
    }

    [AttributeLogicalName("ait_outcome")]
    [RelationshipSchemaName("ait_ait_outcome_ait_planactivity_Outcome")]
    public ait_outcome ait_ait_outcome_ait_planactivity_Outcome
    {
      get
      {
        return this.GetRelatedEntity<ait_outcome>(nameof (ait_ait_outcome_ait_planactivity_Outcome), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_outcome_ait_planactivity_Outcome));
        this.SetRelatedEntity<ait_outcome>(nameof (ait_ait_outcome_ait_planactivity_Outcome), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_outcome_ait_planactivity_Outcome));
      }
    }

    [AttributeLogicalName("ait_placement")]
    [RelationshipSchemaName("ait_ait_placement_ait_planactivity_Placement")]
    public TPFamilyWellness.EarlyBound.ait_placement ait_ait_placement_ait_planactivity_Placement
    {
      get
      {
        return this.GetRelatedEntity<TPFamilyWellness.EarlyBound.ait_placement>(nameof (ait_ait_placement_ait_planactivity_Placement), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_placement_ait_planactivity_Placement));
        this.SetRelatedEntity<TPFamilyWellness.EarlyBound.ait_placement>(nameof (ait_ait_placement_ait_planactivity_Placement), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_placement_ait_planactivity_Placement));
      }
    }

    [AttributeLogicalName("ait_referral")]
    [RelationshipSchemaName("ait_ait_referral_ait_planactivity_Referral")]
    public ait_referral ait_ait_referral_ait_planactivity_Referral
    {
      get
      {
        return this.GetRelatedEntity<ait_referral>(nameof (ait_ait_referral_ait_planactivity_Referral), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_referral_ait_planactivity_Referral));
        this.SetRelatedEntity<ait_referral>(nameof (ait_ait_referral_ait_planactivity_Referral), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_referral_ait_planactivity_Referral));
      }
    }

    [AttributeLogicalName("ait_appointment")]
    [RelationshipSchemaName("ait_appointment_ait_planactivity_Appointment")]
    public Appointment ait_appointment_ait_planactivity_Appointment
    {
      get
      {
        return this.GetRelatedEntity<Appointment>(nameof (ait_appointment_ait_planactivity_Appointment), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_appointment_ait_planactivity_Appointment));
        this.SetRelatedEntity<Appointment>(nameof (ait_appointment_ait_planactivity_Appointment), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_appointment_ait_planactivity_Appointment));
      }
    }

    [AttributeLogicalName("ait_casenotes")]
    [RelationshipSchemaName("ait_casenotefamilywellness_ait_planactivity_CaseNotes")]
    public ait_casenotefamilywellness ait_casenotefamilywellness_ait_planactivity_CaseNotes
    {
      get
      {
        return this.GetRelatedEntity<ait_casenotefamilywellness>(nameof (ait_casenotefamilywellness_ait_planactivity_CaseNotes), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_casenotefamilywellness_ait_planactivity_CaseNotes));
        this.SetRelatedEntity<ait_casenotefamilywellness>(nameof (ait_casenotefamilywellness_ait_planactivity_CaseNotes), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_casenotefamilywellness_ait_planactivity_CaseNotes));
      }
    }

    [AttributeLogicalName("ait_email")]
    [RelationshipSchemaName("ait_email_ait_planactivity_Email")]
    public Email ait_email_ait_planactivity_Email
    {
      get
      {
        return this.GetRelatedEntity<Email>(nameof (ait_email_ait_planactivity_Email), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_email_ait_planactivity_Email));
        this.SetRelatedEntity<Email>(nameof (ait_email_ait_planactivity_Email), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_email_ait_planactivity_Email));
      }
    }

    [AttributeLogicalName("ait_phonecall")]
    [RelationshipSchemaName("ait_phonecall_ait_planactivity_PhoneCall")]
    public PhoneCall ait_phonecall_ait_planactivity_PhoneCall
    {
      get
      {
        return this.GetRelatedEntity<PhoneCall>(nameof (ait_phonecall_ait_planactivity_PhoneCall), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_phonecall_ait_planactivity_PhoneCall));
        this.SetRelatedEntity<PhoneCall>(nameof (ait_phonecall_ait_planactivity_PhoneCall), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_phonecall_ait_planactivity_PhoneCall));
      }
    }

    [AttributeLogicalName("ait_task")]
    [RelationshipSchemaName("ait_task_ait_planactivity_Task")]
    public Task ait_task_ait_planactivity_Task
    {
      get
      {
        return this.GetRelatedEntity<Task>(nameof (ait_task_ait_planactivity_Task), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_task_ait_planactivity_Task));
        this.SetRelatedEntity<Task>(nameof (ait_task_ait_planactivity_Task), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_task_ait_planactivity_Task));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_planactivity")]
    public BusinessUnit business_unit_ait_planactivity
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_planactivity), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_planactivity_createdby")]
    public SystemUser lk_ait_planactivity_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_planactivity_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_planactivity_createdonbehalfby")]
    public SystemUser lk_ait_planactivity_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_planactivity_createdonbehalfby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_planactivity_modifiedby")]
    public SystemUser lk_ait_planactivity_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_planactivity_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_planactivity_modifiedonbehalfby")]
    public SystemUser lk_ait_planactivity_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_planactivity_modifiedonbehalfby), new EntityRole?());
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_planactivity")]
    public Team team_ait_planactivity
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_planactivity), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_planactivity")]
    public SystemUser user_ait_planactivity
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_ait_planactivity), new EntityRole?());
    }
  }
}
