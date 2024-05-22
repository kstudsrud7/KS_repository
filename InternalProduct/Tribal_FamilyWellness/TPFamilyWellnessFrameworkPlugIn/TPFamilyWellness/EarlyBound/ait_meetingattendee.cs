// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EarlyBound.ait_meetingattendee
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_meetingattendee")]
  [GeneratedCode("CrmSvcUtil", "9.0.0.9154")]
  public class ait_meetingattendee : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_meetingattendee";
    public const int EntityTypeCode = 10714;

    public ait_meetingattendee()
      : base(nameof (ait_meetingattendee))
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

    [AttributeLogicalName("ait_attended")]
    public bool? ait_Attended
    {
      get => this.GetAttributeValue<bool?>("ait_attended");
      set
      {
        this.OnPropertyChanging(nameof (ait_Attended));
        this.SetAttributeValue("ait_attended", (object) value);
        this.OnPropertyChanged(nameof (ait_Attended));
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

    [AttributeLogicalName("ait_groupactivityregistration")]
    public EntityReference ait_GroupActivityRegistration
    {
      get => this.GetAttributeValue<EntityReference>("ait_groupactivityregistration");
      set
      {
        this.OnPropertyChanging(nameof (ait_GroupActivityRegistration));
        this.SetAttributeValue("ait_groupactivityregistration", (object) value);
        this.OnPropertyChanged(nameof (ait_GroupActivityRegistration));
      }
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

    [AttributeLogicalName("ait_meetingattendeeid")]
    public Guid? ait_meetingattendeeId
    {
      get => this.GetAttributeValue<Guid?>("ait_meetingattendeeid");
      set
      {
        this.OnPropertyChanging(nameof (ait_meetingattendeeId));
        this.SetAttributeValue("ait_meetingattendeeid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_meetingattendeeId));
      }
    }

    [AttributeLogicalName("ait_meetingattendeeid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_meetingattendeeId = new Guid?(value);
    }

    [AttributeLogicalName("ait_meetingcompleted")]
    public OptionSetValue ait_MeetingCompleted
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_meetingcompleted");
      set
      {
        this.OnPropertyChanging(nameof (ait_MeetingCompleted));
        this.SetAttributeValue("ait_meetingcompleted", (object) value);
        this.OnPropertyChanged(nameof (ait_MeetingCompleted));
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

    [AttributeLogicalName("ait_noshow")]
    public bool? ait_NoShow
    {
      get => this.GetAttributeValue<bool?>("ait_noshow");
      set
      {
        this.OnPropertyChanging(nameof (ait_NoShow));
        this.SetAttributeValue("ait_noshow", (object) value);
        this.OnPropertyChanged(nameof (ait_NoShow));
      }
    }

    [AttributeLogicalName("ait_notes")]
    public string ait_Notes
    {
      get => this.GetAttributeValue<string>("ait_notes");
      set
      {
        this.OnPropertyChanging(nameof (ait_Notes));
        this.SetAttributeValue("ait_notes", (object) value);
        this.OnPropertyChanged(nameof (ait_Notes));
      }
    }

    [AttributeLogicalName("ait_ontime")]
    public bool? ait_OnTime
    {
      get => this.GetAttributeValue<bool?>("ait_ontime");
      set
      {
        this.OnPropertyChanging(nameof (ait_OnTime));
        this.SetAttributeValue("ait_ontime", (object) value);
        this.OnPropertyChanged(nameof (ait_OnTime));
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
    public Ait_meetingattendeeState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new Ait_meetingattendeeState?((Ait_meetingattendeeState) Enum.ToObject(typeof (Ait_meetingattendeeState), attributeValue.Value)) : new Ait_meetingattendeeState?();
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

    [RelationshipSchemaName("ait_ait_meetingattendee_ait_caseplan")]
    public IEnumerable<ait_caseplan> ait_ait_meetingattendee_ait_caseplan
    {
      get
      {
        return this.GetRelatedEntities<ait_caseplan>(nameof (ait_ait_meetingattendee_ait_caseplan), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_meetingattendee_ait_caseplan));
        this.SetRelatedEntities<ait_caseplan>(nameof (ait_ait_meetingattendee_ait_caseplan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_meetingattendee_ait_caseplan));
      }
    }

    [RelationshipSchemaName("ait_meetingattendee_ait_cases")]
    public IEnumerable<ait_case> ait_meetingattendee_ait_cases
    {
      get
      {
        return this.GetRelatedEntities<ait_case>(nameof (ait_meetingattendee_ait_cases), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_meetingattendee_ait_cases));
        this.SetRelatedEntities<ait_case>(nameof (ait_meetingattendee_ait_cases), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_meetingattendee_ait_cases));
      }
    }

    [RelationshipSchemaName("ait_meetingattendee_ait_clientprofile")]
    public IEnumerable<ait_clientprofile> ait_meetingattendee_ait_clientprofile
    {
      get
      {
        return this.GetRelatedEntities<ait_clientprofile>(nameof (ait_meetingattendee_ait_clientprofile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_meetingattendee_ait_clientprofile));
        this.SetRelatedEntities<ait_clientprofile>(nameof (ait_meetingattendee_ait_clientprofile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_meetingattendee_ait_clientprofile));
      }
    }

    [RelationshipSchemaName("ait_meetingattendee_Appointments")]
    public IEnumerable<Appointment> ait_meetingattendee_Appointments
    {
      get
      {
        return this.GetRelatedEntities<Appointment>(nameof (ait_meetingattendee_Appointments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_meetingattendee_Appointments));
        this.SetRelatedEntities<Appointment>(nameof (ait_meetingattendee_Appointments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_meetingattendee_Appointments));
      }
    }

    [RelationshipSchemaName("ait_meetingattendee_Emails")]
    public IEnumerable<Email> ait_meetingattendee_Emails
    {
      get => this.GetRelatedEntities<Email>(nameof (ait_meetingattendee_Emails), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_meetingattendee_Emails));
        this.SetRelatedEntities<Email>(nameof (ait_meetingattendee_Emails), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_meetingattendee_Emails));
      }
    }

    [RelationshipSchemaName("ait_meetingattendee_PhoneCalls")]
    public IEnumerable<PhoneCall> ait_meetingattendee_PhoneCalls
    {
      get
      {
        return this.GetRelatedEntities<PhoneCall>(nameof (ait_meetingattendee_PhoneCalls), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_meetingattendee_PhoneCalls));
        this.SetRelatedEntities<PhoneCall>(nameof (ait_meetingattendee_PhoneCalls), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_meetingattendee_PhoneCalls));
      }
    }

    [RelationshipSchemaName("ait_meetingattendee_Tasks")]
    public IEnumerable<Task> ait_meetingattendee_Tasks
    {
      get => this.GetRelatedEntities<Task>(nameof (ait_meetingattendee_Tasks), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_meetingattendee_Tasks));
        this.SetRelatedEntities<Task>(nameof (ait_meetingattendee_Tasks), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_meetingattendee_Tasks));
      }
    }

    [AttributeLogicalName("ait_case")]
    [RelationshipSchemaName("ait_case_ait_meetingattendee_Case")]
    public ait_case ait_case_ait_meetingattendee_Case
    {
      get
      {
        return this.GetRelatedEntity<ait_case>(nameof (ait_case_ait_meetingattendee_Case), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_case_ait_meetingattendee_Case));
        this.SetRelatedEntity<ait_case>(nameof (ait_case_ait_meetingattendee_Case), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_case_ait_meetingattendee_Case));
      }
    }

    [AttributeLogicalName("ait_familyplan")]
    [RelationshipSchemaName("ait_caseplan_ait_meetingattendee_FamilyPlan")]
    public ait_caseplan ait_caseplan_ait_meetingattendee_FamilyPlan
    {
      get
      {
        return this.GetRelatedEntity<ait_caseplan>(nameof (ait_caseplan_ait_meetingattendee_FamilyPlan), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_caseplan_ait_meetingattendee_FamilyPlan));
        this.SetRelatedEntity<ait_caseplan>(nameof (ait_caseplan_ait_meetingattendee_FamilyPlan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_caseplan_ait_meetingattendee_FamilyPlan));
      }
    }

    [AttributeLogicalName("ait_clientprofile")]
    [RelationshipSchemaName("ait_clientprofile_ait_meetingattendee_ClientProfile")]
    public ait_clientprofile ait_clientprofile_ait_meetingattendee_ClientProfile
    {
      get
      {
        return this.GetRelatedEntity<ait_clientprofile>(nameof (ait_clientprofile_ait_meetingattendee_ClientProfile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_ait_meetingattendee_ClientProfile));
        this.SetRelatedEntity<ait_clientprofile>(nameof (ait_clientprofile_ait_meetingattendee_ClientProfile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_ait_meetingattendee_ClientProfile));
      }
    }

    [AttributeLogicalName("ait_groupactivity")]
    [RelationshipSchemaName("ait_groupactivity_ait_meetingattendee_GroupActivity")]
    public ait_groupactivity ait_groupactivity_ait_meetingattendee_GroupActivity
    {
      get
      {
        return this.GetRelatedEntity<ait_groupactivity>(nameof (ait_groupactivity_ait_meetingattendee_GroupActivity), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_groupactivity_ait_meetingattendee_GroupActivity));
        this.SetRelatedEntity<ait_groupactivity>(nameof (ait_groupactivity_ait_meetingattendee_GroupActivity), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_groupactivity_ait_meetingattendee_GroupActivity));
      }
    }

    [AttributeLogicalName("ait_groupactivitymeeting")]
    [RelationshipSchemaName("ait_groupactivitymeeting_ait_meetingattendee_GroupActivityMeeting")]
    public ait_groupactivitymeeting ait_groupactivitymeeting_ait_meetingattendee_GroupActivityMeeting
    {
      get
      {
        return this.GetRelatedEntity<ait_groupactivitymeeting>(nameof (ait_groupactivitymeeting_ait_meetingattendee_GroupActivityMeeting), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_groupactivitymeeting_ait_meetingattendee_GroupActivityMeeting));
        this.SetRelatedEntity<ait_groupactivitymeeting>(nameof (ait_groupactivitymeeting_ait_meetingattendee_GroupActivityMeeting), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_groupactivitymeeting_ait_meetingattendee_GroupActivityMeeting));
      }
    }

    [AttributeLogicalName("ait_groupactivityregistration")]
    [RelationshipSchemaName("ait_groupactivityregistration_ait_meetingattendee_GroupActivityRegistration")]
    public ait_groupactivityregistration ait_groupactivityregistration_ait_meetingattendee_GroupActivityRegistration
    {
      get
      {
        return this.GetRelatedEntity<ait_groupactivityregistration>(nameof (ait_groupactivityregistration_ait_meetingattendee_GroupActivityRegistration), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_groupactivityregistration_ait_meetingattendee_GroupActivityRegistration));
        this.SetRelatedEntity<ait_groupactivityregistration>(nameof (ait_groupactivityregistration_ait_meetingattendee_GroupActivityRegistration), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_groupactivityregistration_ait_meetingattendee_GroupActivityRegistration));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_meetingattendee")]
    public BusinessUnit business_unit_ait_meetingattendee
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_meetingattendee), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_meetingattendee_createdby")]
    public SystemUser lk_ait_meetingattendee_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_meetingattendee_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_meetingattendee_createdonbehalfby")]
    public SystemUser lk_ait_meetingattendee_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_meetingattendee_createdonbehalfby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_meetingattendee_modifiedby")]
    public SystemUser lk_ait_meetingattendee_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_meetingattendee_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_meetingattendee_modifiedonbehalfby")]
    public SystemUser lk_ait_meetingattendee_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_meetingattendee_modifiedonbehalfby), new EntityRole?());
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_meetingattendee")]
    public Team team_ait_meetingattendee
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_meetingattendee), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_meetingattendee")]
    public SystemUser user_ait_meetingattendee
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_ait_meetingattendee), new EntityRole?());
      }
    }
  }
}
