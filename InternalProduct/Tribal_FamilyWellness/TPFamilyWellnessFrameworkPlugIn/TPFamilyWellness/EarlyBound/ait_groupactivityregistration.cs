// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EarlyBound.ait_groupactivityregistration
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_groupactivityregistration")]
  [GeneratedCode("CrmSvcUtil", "9.0.0.9154")]
  public class ait_groupactivityregistration : 
    Entity,
    INotifyPropertyChanging,
    INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_groupactivityregistration";
    public const int EntityTypeCode = 10713;

    public ait_groupactivityregistration()
      : base(nameof (ait_groupactivityregistration))
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

    [AttributeLogicalName("ait_actualattendedmeetings")]
    public int? ait_ActualAttendedMeetings
    {
      get => this.GetAttributeValue<int?>("ait_actualattendedmeetings");
      set
      {
        this.OnPropertyChanging(nameof (ait_ActualAttendedMeetings));
        this.SetAttributeValue("ait_actualattendedmeetings", (object) value);
        this.OnPropertyChanged(nameof (ait_ActualAttendedMeetings));
      }
    }

    [AttributeLogicalName("ait_actualattendedmeetings_date")]
    public DateTime? ait_ActualAttendedMeetings_Date
    {
      get => this.GetAttributeValue<DateTime?>("ait_actualattendedmeetings_date");
    }

    [AttributeLogicalName("ait_actualattendedmeetings_state")]
    public int? ait_ActualAttendedMeetings_State
    {
      get => this.GetAttributeValue<int?>("ait_actualattendedmeetings_state");
    }

    [AttributeLogicalName("ait_addtofuturemeetings")]
    public bool? ait_AddtoFutureMeetings
    {
      get => this.GetAttributeValue<bool?>("ait_addtofuturemeetings");
      set
      {
        this.OnPropertyChanging(nameof (ait_AddtoFutureMeetings));
        this.SetAttributeValue("ait_addtofuturemeetings", (object) value);
        this.OnPropertyChanged(nameof (ait_AddtoFutureMeetings));
      }
    }

    [AttributeLogicalName("ait_case")]
    public EntityReference ait_Case
    {
      get => this.GetAttributeValue<EntityReference>("ait_case");
      set
      {
        this.OnPropertyChanging(nameof (ait_Case));
        this.SetAttributeValue("ait_case", (object) value);
        this.OnPropertyChanged(nameof (ait_Case));
      }
    }

    [AttributeLogicalName("ait_clientprofile")]
    public EntityReference ait_ClientProfile
    {
      get => this.GetAttributeValue<EntityReference>("ait_clientprofile");
      set
      {
        this.OnPropertyChanging(nameof (ait_ClientProfile));
        this.SetAttributeValue("ait_clientprofile", (object) value);
        this.OnPropertyChanged(nameof (ait_ClientProfile));
      }
    }

    [AttributeLogicalName("ait_conditionsinstructionsnotes")]
    public string ait_ConditionsInstructionsNotes
    {
      get => this.GetAttributeValue<string>("ait_conditionsinstructionsnotes");
      set
      {
        this.OnPropertyChanging(nameof (ait_ConditionsInstructionsNotes));
        this.SetAttributeValue("ait_conditionsinstructionsnotes", (object) value);
        this.OnPropertyChanged(nameof (ait_ConditionsInstructionsNotes));
      }
    }

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

    [AttributeLogicalName("ait_familyplan")]
    public EntityReference ait_FamilyPlan
    {
      get => this.GetAttributeValue<EntityReference>("ait_familyplan");
      set
      {
        this.OnPropertyChanging(nameof (ait_FamilyPlan));
        this.SetAttributeValue("ait_familyplan", (object) value);
        this.OnPropertyChanged(nameof (ait_FamilyPlan));
      }
    }

    [AttributeLogicalName("ait_groupactivity")]
    public EntityReference ait_GroupActivity
    {
      get => this.GetAttributeValue<EntityReference>("ait_groupactivity");
      set
      {
        this.OnPropertyChanging(nameof (ait_GroupActivity));
        this.SetAttributeValue("ait_groupactivity", (object) value);
        this.OnPropertyChanged(nameof (ait_GroupActivity));
      }
    }

    [AttributeLogicalName("ait_groupactivitymeeting")]
    public EntityReference ait_GroupActivityMeeting
    {
      get => this.GetAttributeValue<EntityReference>("ait_groupactivitymeeting");
      set
      {
        this.OnPropertyChanging(nameof (ait_GroupActivityMeeting));
        this.SetAttributeValue("ait_groupactivitymeeting", (object) value);
        this.OnPropertyChanged(nameof (ait_GroupActivityMeeting));
      }
    }

    [AttributeLogicalName("ait_groupactivityregistrationid")]
    public Guid? ait_groupactivityregistrationId
    {
      get => this.GetAttributeValue<Guid?>("ait_groupactivityregistrationid");
      set
      {
        this.OnPropertyChanging(nameof (ait_groupactivityregistrationId));
        this.SetAttributeValue("ait_groupactivityregistrationid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_groupactivityregistrationId));
      }
    }

    [AttributeLogicalName("ait_groupactivityregistrationid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_groupactivityregistrationId = new Guid?(value);
    }

    [AttributeLogicalName("ait_housingprofile")]
    public EntityReference ait_HousingProfile
    {
      get => this.GetAttributeValue<EntityReference>("ait_housingprofile");
      set
      {
        this.OnPropertyChanging(nameof (ait_HousingProfile));
        this.SetAttributeValue("ait_housingprofile", (object) value);
        this.OnPropertyChanged(nameof (ait_HousingProfile));
      }
    }

    [AttributeLogicalName("ait_instructionnotes")]
    public string ait_InstructionNotes
    {
      get => this.GetAttributeValue<string>("ait_instructionnotes");
      set
      {
        this.OnPropertyChanging(nameof (ait_InstructionNotes));
        this.SetAttributeValue("ait_instructionnotes", (object) value);
        this.OnPropertyChanged(nameof (ait_InstructionNotes));
      }
    }

    [AttributeLogicalName("ait_meetingattendancerequired")]
    public bool? ait_MeetingAttendanceRequired
    {
      get => this.GetAttributeValue<bool?>("ait_meetingattendancerequired");
      set
      {
        this.OnPropertyChanging(nameof (ait_MeetingAttendanceRequired));
        this.SetAttributeValue("ait_meetingattendancerequired", (object) value);
        this.OnPropertyChanged(nameof (ait_MeetingAttendanceRequired));
      }
    }

    [AttributeLogicalName("ait_minimumnoofmeetings")]
    public int? ait_MinimumNoofMeetings
    {
      get => this.GetAttributeValue<int?>("ait_minimumnoofmeetings");
      set
      {
        this.OnPropertyChanging(nameof (ait_MinimumNoofMeetings));
        this.SetAttributeValue("ait_minimumnoofmeetings", (object) value);
        this.OnPropertyChanged(nameof (ait_MinimumNoofMeetings));
      }
    }

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

    [AttributeLogicalName("ait_registrationdate")]
    public DateTime? ait_RegistrationDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_registrationdate");
      set
      {
        this.OnPropertyChanging(nameof (ait_RegistrationDate));
        this.SetAttributeValue("ait_registrationdate", (object) value);
        this.OnPropertyChanged(nameof (ait_RegistrationDate));
      }
    }

    [AttributeLogicalName("ait_registrationid")]
    public string ait_RegistrationID
    {
      get => this.GetAttributeValue<string>("ait_registrationid");
      set
      {
        this.OnPropertyChanging(nameof (ait_RegistrationID));
        this.SetAttributeValue("ait_registrationid", (object) value);
        this.OnPropertyChanged(nameof (ait_RegistrationID));
      }
    }

    [AttributeLogicalName("ait_requirementfulfilled")]
    public OptionSetValue ait_RequirementFulfilled
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_requirementfulfilled");
      set
      {
        this.OnPropertyChanging(nameof (ait_RequirementFulfilled));
        this.SetAttributeValue("ait_requirementfulfilled", (object) value);
        this.OnPropertyChanged(nameof (ait_RequirementFulfilled));
      }
    }

    [AttributeLogicalName("ait_servicerequest")]
    public EntityReference ait_ServiceRequest
    {
      get => this.GetAttributeValue<EntityReference>("ait_servicerequest");
      set
      {
        this.OnPropertyChanging(nameof (ait_ServiceRequest));
        this.SetAttributeValue("ait_servicerequest", (object) value);
        this.OnPropertyChanged(nameof (ait_ServiceRequest));
      }
    }

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

    [AttributeLogicalName("createdby")]
    public EntityReference CreatedBy => this.GetAttributeValue<EntityReference>("createdby");

    [AttributeLogicalName("createdon")]
    public DateTime? CreatedOn => this.GetAttributeValue<DateTime?>("createdon");

    [AttributeLogicalName("createdonbehalfby")]
    public EntityReference CreatedOnBehalfBy
    {
      get => this.GetAttributeValue<EntityReference>("createdonbehalfby");
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

    [AttributeLogicalName("modifiedon")]
    public DateTime? ModifiedOn => this.GetAttributeValue<DateTime?>("modifiedon");

    [AttributeLogicalName("modifiedonbehalfby")]
    public EntityReference ModifiedOnBehalfBy
    {
      get => this.GetAttributeValue<EntityReference>("modifiedonbehalfby");
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
    public Ait_groupactivityregistrationState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new Ait_groupactivityregistrationState?((Ait_groupactivityregistrationState) Enum.ToObject(typeof (Ait_groupactivityregistrationState), attributeValue.Value)) : new Ait_groupactivityregistrationState?();
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

    [RelationshipSchemaName("ait_groupactivityregistration_ait_meetingattendee_GroupActivityRegistration")]
    public IEnumerable<ait_meetingattendee> ait_groupactivityregistration_ait_meetingattendee_GroupActivityRegistration
    {
      get
      {
        return this.GetRelatedEntities<ait_meetingattendee>(nameof (ait_groupactivityregistration_ait_meetingattendee_GroupActivityRegistration), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_groupactivityregistration_ait_meetingattendee_GroupActivityRegistration));
        this.SetRelatedEntities<ait_meetingattendee>(nameof (ait_groupactivityregistration_ait_meetingattendee_GroupActivityRegistration), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_groupactivityregistration_ait_meetingattendee_GroupActivityRegistration));
      }
    }

    [RelationshipSchemaName("ait_groupactivityregistration_Appointments")]
    public IEnumerable<Appointment> ait_groupactivityregistration_Appointments
    {
      get
      {
        return this.GetRelatedEntities<Appointment>(nameof (ait_groupactivityregistration_Appointments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_groupactivityregistration_Appointments));
        this.SetRelatedEntities<Appointment>(nameof (ait_groupactivityregistration_Appointments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_groupactivityregistration_Appointments));
      }
    }

    [RelationshipSchemaName("ait_groupactivityregistration_Emails")]
    public IEnumerable<Email> ait_groupactivityregistration_Emails
    {
      get
      {
        return this.GetRelatedEntities<Email>(nameof (ait_groupactivityregistration_Emails), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_groupactivityregistration_Emails));
        this.SetRelatedEntities<Email>(nameof (ait_groupactivityregistration_Emails), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_groupactivityregistration_Emails));
      }
    }

    [RelationshipSchemaName("ait_groupactivityregistration_PhoneCalls")]
    public IEnumerable<PhoneCall> ait_groupactivityregistration_PhoneCalls
    {
      get
      {
        return this.GetRelatedEntities<PhoneCall>(nameof (ait_groupactivityregistration_PhoneCalls), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_groupactivityregistration_PhoneCalls));
        this.SetRelatedEntities<PhoneCall>(nameof (ait_groupactivityregistration_PhoneCalls), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_groupactivityregistration_PhoneCalls));
      }
    }

    [RelationshipSchemaName("ait_groupactivityregistration_Tasks")]
    public IEnumerable<Task> ait_groupactivityregistration_Tasks
    {
      get
      {
        return this.GetRelatedEntities<Task>(nameof (ait_groupactivityregistration_Tasks), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_groupactivityregistration_Tasks));
        this.SetRelatedEntities<Task>(nameof (ait_groupactivityregistration_Tasks), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_groupactivityregistration_Tasks));
      }
    }

    [AttributeLogicalName("ait_case")]
    [RelationshipSchemaName("ait_case_ait_groupactivityregistration_Case")]
    public ait_case ait_case_ait_groupactivityregistration_Case
    {
      get
      {
        return this.GetRelatedEntity<ait_case>(nameof (ait_case_ait_groupactivityregistration_Case), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_case_ait_groupactivityregistration_Case));
        this.SetRelatedEntity<ait_case>(nameof (ait_case_ait_groupactivityregistration_Case), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_case_ait_groupactivityregistration_Case));
      }
    }

    [AttributeLogicalName("ait_familyplan")]
    [RelationshipSchemaName("ait_caseplan_ait_groupactivityregistration_FamilyPlan")]
    public ait_caseplan ait_caseplan_ait_groupactivityregistration_FamilyPlan
    {
      get
      {
        return this.GetRelatedEntity<ait_caseplan>(nameof (ait_caseplan_ait_groupactivityregistration_FamilyPlan), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_caseplan_ait_groupactivityregistration_FamilyPlan));
        this.SetRelatedEntity<ait_caseplan>(nameof (ait_caseplan_ait_groupactivityregistration_FamilyPlan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_caseplan_ait_groupactivityregistration_FamilyPlan));
      }
    }

    [AttributeLogicalName("ait_clientprofile")]
    [RelationshipSchemaName("ait_clientprofile_ait_groupactivityregistration_ClientProfile")]
    public ait_clientprofile ait_clientprofile_ait_groupactivityregistration_ClientProfile
    {
      get
      {
        return this.GetRelatedEntity<ait_clientprofile>(nameof (ait_clientprofile_ait_groupactivityregistration_ClientProfile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_ait_groupactivityregistration_ClientProfile));
        this.SetRelatedEntity<ait_clientprofile>(nameof (ait_clientprofile_ait_groupactivityregistration_ClientProfile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_ait_groupactivityregistration_ClientProfile));
      }
    }

    [AttributeLogicalName("ait_groupactivity")]
    [RelationshipSchemaName("ait_groupactivity_ait_groupactivityregistration_GroupActivity")]
    public ait_groupactivity ait_groupactivity_ait_groupactivityregistration_GroupActivity
    {
      get
      {
        return this.GetRelatedEntity<ait_groupactivity>(nameof (ait_groupactivity_ait_groupactivityregistration_GroupActivity), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_groupactivity_ait_groupactivityregistration_GroupActivity));
        this.SetRelatedEntity<ait_groupactivity>(nameof (ait_groupactivity_ait_groupactivityregistration_GroupActivity), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_groupactivity_ait_groupactivityregistration_GroupActivity));
      }
    }

    [AttributeLogicalName("ait_groupactivitymeeting")]
    [RelationshipSchemaName("ait_groupactivitymeeting_ait_groupactivityregistration_GroupActivityMeeting")]
    public ait_groupactivitymeeting ait_groupactivitymeeting_ait_groupactivityregistration_GroupActivityMeeting
    {
      get
      {
        return this.GetRelatedEntity<ait_groupactivitymeeting>(nameof (ait_groupactivitymeeting_ait_groupactivityregistration_GroupActivityMeeting), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_groupactivitymeeting_ait_groupactivityregistration_GroupActivityMeeting));
        this.SetRelatedEntity<ait_groupactivitymeeting>(nameof (ait_groupactivitymeeting_ait_groupactivityregistration_GroupActivityMeeting), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_groupactivitymeeting_ait_groupactivityregistration_GroupActivityMeeting));
      }
    }

    [AttributeLogicalName("ait_servicerequest")]
    [RelationshipSchemaName("ait_servicerequest_ait_groupactivityregistration_ServiceRequest")]
    public ait_servicerequest ait_servicerequest_ait_groupactivityregistration_ServiceRequest
    {
      get
      {
        return this.GetRelatedEntity<ait_servicerequest>(nameof (ait_servicerequest_ait_groupactivityregistration_ServiceRequest), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_ait_groupactivityregistration_ServiceRequest));
        this.SetRelatedEntity<ait_servicerequest>(nameof (ait_servicerequest_ait_groupactivityregistration_ServiceRequest), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_ait_groupactivityregistration_ServiceRequest));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_groupactivityregistration")]
    public BusinessUnit business_unit_ait_groupactivityregistration
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_groupactivityregistration), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_groupactivityregistration_createdby")]
    public SystemUser lk_ait_groupactivityregistration_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_groupactivityregistration_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_groupactivityregistration_createdonbehalfby")]
    public SystemUser lk_ait_groupactivityregistration_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_groupactivityregistration_createdonbehalfby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_groupactivityregistration_modifiedby")]
    public SystemUser lk_ait_groupactivityregistration_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_groupactivityregistration_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_groupactivityregistration_modifiedonbehalfby")]
    public SystemUser lk_ait_groupactivityregistration_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_groupactivityregistration_modifiedonbehalfby), new EntityRole?());
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_groupactivityregistration")]
    public Team team_ait_groupactivityregistration
    {
      get
      {
        return this.GetRelatedEntity<Team>(nameof (team_ait_groupactivityregistration), new EntityRole?());
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_groupactivityregistration")]
    public SystemUser user_ait_groupactivityregistration
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_ait_groupactivityregistration), new EntityRole?());
      }
    }
  }
}
