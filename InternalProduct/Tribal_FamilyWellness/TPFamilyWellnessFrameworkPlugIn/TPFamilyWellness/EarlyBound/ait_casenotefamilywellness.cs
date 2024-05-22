// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EarlyBound.ait_casenotefamilywellness
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_casenotefamilywellness")]
  [GeneratedCode("CrmSvcUtil", "9.0.0.9154")]
  public class ait_casenotefamilywellness : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_casenotefamilywellness";
    public const int EntityTypeCode = 10722;

    public ait_casenotefamilywellness()
      : base(nameof (ait_casenotefamilywellness))
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

    [AttributeLogicalName("ait_casename")]
    public string ait_CaseName => this.GetAttributeValue<string>("ait_casename");

    [AttributeLogicalName("ait_casenote")]
    public string ait_CaseNote
    {
      get => this.GetAttributeValue<string>("ait_casenote");
      set
      {
        this.OnPropertyChanging(nameof (ait_CaseNote));
        this.SetAttributeValue("ait_casenote", (object) value);
        this.OnPropertyChanged(nameof (ait_CaseNote));
      }
    }

    [AttributeLogicalName("ait_casenoteautoid")]
    public string ait_CaseNoteAutoID
    {
      get => this.GetAttributeValue<string>("ait_casenoteautoid");
      set
      {
        this.OnPropertyChanging(nameof (ait_CaseNoteAutoID));
        this.SetAttributeValue("ait_casenoteautoid", (object) value);
        this.OnPropertyChanged(nameof (ait_CaseNoteAutoID));
      }
    }

    [AttributeLogicalName("ait_casenotefamilywellnessid")]
    public Guid? ait_casenotefamilywellnessId
    {
      get => this.GetAttributeValue<Guid?>("ait_casenotefamilywellnessid");
      set
      {
        this.OnPropertyChanging(nameof (ait_casenotefamilywellnessId));
        this.SetAttributeValue("ait_casenotefamilywellnessid", (object) value);
        this.OnPropertyChanged(nameof (ait_casenotefamilywellnessId));
      }
    }

    [AttributeLogicalName("ait_casenotestatus")]
    public OptionSetValue ait_CaseNoteStatus
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_casenotestatus");
      set
      {
        this.OnPropertyChanging(nameof (ait_CaseNoteStatus));
        this.SetAttributeValue("ait_casenotestatus", (object) value);
        this.OnPropertyChanged(nameof (ait_CaseNoteStatus));
      }
    }

    [AttributeLogicalName("ait_casenotestatusname")]
    public object ait_casenotestatusName
    {
      get => this.GetAttributeValue<object>("ait_casenotestatusname");
    }

    [AttributeLogicalName("ait_casenotetype")]
    public OptionSetValue ait_CaseNoteType
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_casenotetype");
      set
      {
        this.OnPropertyChanging(nameof (ait_CaseNoteType));
        this.SetAttributeValue("ait_casenotetype", (object) value);
        this.OnPropertyChanged(nameof (ait_CaseNoteType));
      }
    }

    [AttributeLogicalName("ait_casenotetypename")]
    public object ait_casenotetypeName => this.GetAttributeValue<object>("ait_casenotetypename");

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

    [AttributeLogicalName("ait_duedate")]
    public DateTime? ait_DueDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_duedate");
      set
      {
        this.OnPropertyChanging(nameof (ait_DueDate));
        this.SetAttributeValue("ait_duedate", (object) value);
        this.OnPropertyChanged(nameof (ait_DueDate));
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

    [AttributeLogicalName("ait_successstory")]
    public bool? ait_SuccessStory
    {
      get => this.GetAttributeValue<bool?>("ait_successstory");
      set
      {
        this.OnPropertyChanging(nameof (ait_SuccessStory));
        this.SetAttributeValue("ait_successstory", (object) value);
        this.OnPropertyChanged(nameof (ait_SuccessStory));
      }
    }

    [AttributeLogicalName("ait_successstoryname")]
    public object ait_successstoryName => this.GetAttributeValue<object>("ait_successstoryname");

    [AttributeLogicalName("ait_summary")]
    public string ait_Summary
    {
      get => this.GetAttributeValue<string>("ait_summary");
      set
      {
        this.OnPropertyChanging(nameof (ait_Summary));
        this.SetAttributeValue("ait_summary", (object) value);
        this.OnPropertyChanged(nameof (ait_Summary));
      }
    }

    [AttributeLogicalName("ait_timetakenmin")]
    public int? ait_TimeTakenMin
    {
      get => this.GetAttributeValue<int?>("ait_timetakenmin");
      set
      {
        this.OnPropertyChanging(nameof (ait_TimeTakenMin));
        this.SetAttributeValue("ait_timetakenmin", (object) value);
        this.OnPropertyChanged(nameof (ait_TimeTakenMin));
      }
    }

    [AttributeLogicalName("ait_travelmileage")]
    public int? ait_TravelMileage
    {
      get => this.GetAttributeValue<int?>("ait_travelmileage");
      set
      {
        this.OnPropertyChanging(nameof (ait_TravelMileage));
        this.SetAttributeValue("ait_travelmileage", (object) value);
        this.OnPropertyChanged(nameof (ait_TravelMileage));
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
    public Ait_casenotefamilywellnessState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new Ait_casenotefamilywellnessState?((Ait_casenotefamilywellnessState) Enum.ToObject(typeof (Ait_casenotefamilywellnessState), attributeValue.Value)) : new Ait_casenotefamilywellnessState?();
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

    [RelationshipSchemaName("ait_casenotefamilywellness_ait_planactivity_CaseNotes")]
    public IEnumerable<ait_planactivity> ait_casenotefamilywellness_ait_planactivity_CaseNotes
    {
      get
      {
        return this.GetRelatedEntities<ait_planactivity>(nameof (ait_casenotefamilywellness_ait_planactivity_CaseNotes), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_casenotefamilywellness_ait_planactivity_CaseNotes));
        this.SetRelatedEntities<ait_planactivity>(nameof (ait_casenotefamilywellness_ait_planactivity_CaseNotes), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_casenotefamilywellness_ait_planactivity_CaseNotes));
      }
    }

    [RelationshipSchemaName("ait_casenotefamilywellness_Appointments")]
    public IEnumerable<Appointment> ait_casenotefamilywellness_Appointments
    {
      get
      {
        return this.GetRelatedEntities<Appointment>(nameof (ait_casenotefamilywellness_Appointments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_casenotefamilywellness_Appointments));
        this.SetRelatedEntities<Appointment>(nameof (ait_casenotefamilywellness_Appointments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_casenotefamilywellness_Appointments));
      }
    }

    [RelationshipSchemaName("ait_casenotefamilywellness_Emails")]
    public IEnumerable<Email> ait_casenotefamilywellness_Emails
    {
      get
      {
        return this.GetRelatedEntities<Email>(nameof (ait_casenotefamilywellness_Emails), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_casenotefamilywellness_Emails));
        this.SetRelatedEntities<Email>(nameof (ait_casenotefamilywellness_Emails), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_casenotefamilywellness_Emails));
      }
    }

    [RelationshipSchemaName("ait_casenotefamilywellness_PhoneCalls")]
    public IEnumerable<PhoneCall> ait_casenotefamilywellness_PhoneCalls
    {
      get
      {
        return this.GetRelatedEntities<PhoneCall>(nameof (ait_casenotefamilywellness_PhoneCalls), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_casenotefamilywellness_PhoneCalls));
        this.SetRelatedEntities<PhoneCall>(nameof (ait_casenotefamilywellness_PhoneCalls), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_casenotefamilywellness_PhoneCalls));
      }
    }

    [RelationshipSchemaName("ait_casenotefamilywellness_Tasks")]
    public IEnumerable<Task> ait_casenotefamilywellness_Tasks
    {
      get
      {
        return this.GetRelatedEntities<Task>(nameof (ait_casenotefamilywellness_Tasks), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_casenotefamilywellness_Tasks));
        this.SetRelatedEntities<Task>(nameof (ait_casenotefamilywellness_Tasks), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_casenotefamilywellness_Tasks));
      }
    }

    [AttributeLogicalName("ait_caseplan")]
    [RelationshipSchemaName("ait_ait_caseplan_ait_casenotefamilywellness")]
    public ait_caseplan ait_ait_caseplan_ait_casenotefamilywellness
    {
      get
      {
        return this.GetRelatedEntity<ait_caseplan>(nameof (ait_ait_caseplan_ait_casenotefamilywellness), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_caseplan_ait_casenotefamilywellness));
        this.SetRelatedEntity<ait_caseplan>(nameof (ait_ait_caseplan_ait_casenotefamilywellness), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_caseplan_ait_casenotefamilywellness));
      }
    }

    [AttributeLogicalName("ait_case")]
    [RelationshipSchemaName("ait_case_ait_casenotefamilywellness_Case")]
    public ait_case ait_case_ait_casenotefamilywellness_Case
    {
      get
      {
        return this.GetRelatedEntity<ait_case>(nameof (ait_case_ait_casenotefamilywellness_Case), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_case_ait_casenotefamilywellness_Case));
        this.SetRelatedEntity<ait_case>(nameof (ait_case_ait_casenotefamilywellness_Case), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_case_ait_casenotefamilywellness_Case));
      }
    }

    [AttributeLogicalName("ait_individual")]
    [RelationshipSchemaName("ait_clientprofile_ait_casenotefamilywellness_Individual")]
    public ait_clientprofile ait_clientprofile_ait_casenotefamilywellness_Individual
    {
      get
      {
        return this.GetRelatedEntity<ait_clientprofile>(nameof (ait_clientprofile_ait_casenotefamilywellness_Individual), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_ait_casenotefamilywellness_Individual));
        this.SetRelatedEntity<ait_clientprofile>(nameof (ait_clientprofile_ait_casenotefamilywellness_Individual), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_ait_casenotefamilywellness_Individual));
      }
    }

    [AttributeLogicalName("ait_familygroup")]
    [RelationshipSchemaName("ait_familygroup_ait_casenotefamilywellness_FamilyGroup")]
    public ait_familygroup ait_familygroup_ait_casenotefamilywellness_FamilyGroup
    {
      get
      {
        return this.GetRelatedEntity<ait_familygroup>(nameof (ait_familygroup_ait_casenotefamilywellness_FamilyGroup), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familygroup_ait_casenotefamilywellness_FamilyGroup));
        this.SetRelatedEntity<ait_familygroup>(nameof (ait_familygroup_ait_casenotefamilywellness_FamilyGroup), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familygroup_ait_casenotefamilywellness_FamilyGroup));
      }
    }

    [AttributeLogicalName("ait_outcome")]
    [RelationshipSchemaName("ait_outcome_ait_casenotefamilywellness_Outcome")]
    public ait_outcome ait_outcome_ait_casenotefamilywellness_Outcome
    {
      get
      {
        return this.GetRelatedEntity<ait_outcome>(nameof (ait_outcome_ait_casenotefamilywellness_Outcome), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_outcome_ait_casenotefamilywellness_Outcome));
        this.SetRelatedEntity<ait_outcome>(nameof (ait_outcome_ait_casenotefamilywellness_Outcome), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_outcome_ait_casenotefamilywellness_Outcome));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_casenotefamilywellness")]
    public BusinessUnit business_unit_ait_casenotefamilywellness
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_casenotefamilywellness), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_casenotefamilywellness_createdby")]
    public SystemUser lk_ait_casenotefamilywellness_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_casenotefamilywellness_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_casenotefamilywellness_createdonbehalfby")]
    public SystemUser lk_ait_casenotefamilywellness_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_casenotefamilywellness_createdonbehalfby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_casenotefamilywellness_modifiedby")]
    public SystemUser lk_ait_casenotefamilywellness_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_casenotefamilywellness_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_casenotefamilywellness_modifiedonbehalfby")]
    public SystemUser lk_ait_casenotefamilywellness_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_casenotefamilywellness_modifiedonbehalfby), new EntityRole?());
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_casenotefamilywellness")]
    public Team team_ait_casenotefamilywellness
    {
      get
      {
        return this.GetRelatedEntity<Team>(nameof (team_ait_casenotefamilywellness), new EntityRole?());
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_casenotefamilywellness")]
    public SystemUser user_ait_casenotefamilywellness
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_ait_casenotefamilywellness), new EntityRole?());
      }
    }
  }
}
