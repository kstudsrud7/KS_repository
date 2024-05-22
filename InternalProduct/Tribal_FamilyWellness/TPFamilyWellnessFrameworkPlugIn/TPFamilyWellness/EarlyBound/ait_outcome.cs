// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EarlyBound.ait_outcome
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_outcome")]
  [GeneratedCode("CrmSvcUtil", "9.0.0.9154")]
  public class ait_outcome : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_outcome";
    public const int EntityTypeCode = 10660;

    public ait_outcome()
      : base(nameof (ait_outcome))
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

    [AttributeLogicalName("ait_actualcompletiondate")]
    public DateTime? ait_ActualCompletionDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_actualcompletiondate");
      set
      {
        this.OnPropertyChanging(nameof (ait_ActualCompletionDate));
        this.SetAttributeValue("ait_actualcompletiondate", (object) value);
        this.OnPropertyChanged(nameof (ait_ActualCompletionDate));
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

    [AttributeLogicalName("ait_duration")]
    public OptionSetValue ait_Duration
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_duration");
      set
      {
        this.OnPropertyChanging(nameof (ait_Duration));
        this.SetAttributeValue("ait_duration", (object) value);
        this.OnPropertyChanged(nameof (ait_Duration));
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

    [AttributeLogicalName("ait_indicatorresult")]
    public string ait_IndicatorResult
    {
      get => this.GetAttributeValue<string>("ait_indicatorresult");
      set
      {
        this.OnPropertyChanging(nameof (ait_IndicatorResult));
        this.SetAttributeValue("ait_indicatorresult", (object) value);
        this.OnPropertyChanged(nameof (ait_IndicatorResult));
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

    [AttributeLogicalName("ait_nextreviewdate")]
    public DateTime? ait_NextReviewDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_nextreviewdate");
      set
      {
        this.OnPropertyChanging(nameof (ait_NextReviewDate));
        this.SetAttributeValue("ait_nextreviewdate", (object) value);
        this.OnPropertyChanged(nameof (ait_NextReviewDate));
      }
    }

    [AttributeLogicalName("ait_outcomeautoid")]
    public string ait_OutcomeAutoID
    {
      get => this.GetAttributeValue<string>("ait_outcomeautoid");
      set
      {
        this.OnPropertyChanging(nameof (ait_OutcomeAutoID));
        this.SetAttributeValue("ait_outcomeautoid", (object) value);
        this.OnPropertyChanged(nameof (ait_OutcomeAutoID));
      }
    }

    [AttributeLogicalName("ait_outcomeid")]
    public Guid? ait_outcomeId
    {
      get => this.GetAttributeValue<Guid?>("ait_outcomeid");
      set
      {
        this.OnPropertyChanging(nameof (ait_outcomeId));
        this.SetAttributeValue("ait_outcomeid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_outcomeId));
      }
    }

    [AttributeLogicalName("ait_outcomeid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_outcomeId = new Guid?(value);
    }

    [AttributeLogicalName("ait_outcomeindicator")]
    public string ait_OutcomeIndicator
    {
      get => this.GetAttributeValue<string>("ait_outcomeindicator");
      set
      {
        this.OnPropertyChanging(nameof (ait_OutcomeIndicator));
        this.SetAttributeValue("ait_outcomeindicator", (object) value);
        this.OnPropertyChanged(nameof (ait_OutcomeIndicator));
      }
    }

    [AttributeLogicalName("ait_outcomeresult")]
    public OptionSetValue ait_OutcomeResult
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_outcomeresult");
      set
      {
        this.OnPropertyChanging(nameof (ait_OutcomeResult));
        this.SetAttributeValue("ait_outcomeresult", (object) value);
        this.OnPropertyChanged(nameof (ait_OutcomeResult));
      }
    }

    [AttributeLogicalName("ait_outcomestatus")]
    public OptionSetValue ait_OutcomeStatus
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_outcomestatus");
      set
      {
        this.OnPropertyChanging(nameof (ait_OutcomeStatus));
        this.SetAttributeValue("ait_outcomestatus", (object) value);
        this.OnPropertyChanged(nameof (ait_OutcomeStatus));
      }
    }

    [AttributeLogicalName("ait_outcomesummary")]
    public string ait_OutcomeSummary
    {
      get => this.GetAttributeValue<string>("ait_outcomesummary");
      set
      {
        this.OnPropertyChanging(nameof (ait_OutcomeSummary));
        this.SetAttributeValue("ait_outcomesummary", (object) value);
        this.OnPropertyChanged(nameof (ait_OutcomeSummary));
      }
    }

    [AttributeLogicalName("ait_program")]
    public EntityReference ait_Program
    {
      get => this.GetAttributeValue<EntityReference>("ait_program");
      set
      {
        this.OnPropertyChanging(nameof (ait_Program));
        this.SetAttributeValue("ait_program", (object) value);
        this.OnPropertyChanged(nameof (ait_Program));
      }
    }

    [AttributeLogicalName("ait_signoffdate")]
    public DateTime? ait_SignOffDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_signoffdate");
      set
      {
        this.OnPropertyChanging(nameof (ait_SignOffDate));
        this.SetAttributeValue("ait_signoffdate", (object) value);
        this.OnPropertyChanged(nameof (ait_SignOffDate));
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
    public Ait_outcomeState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new Ait_outcomeState?((Ait_outcomeState) Enum.ToObject(typeof (Ait_outcomeState), attributeValue.Value)) : new Ait_outcomeState?();
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

    [RelationshipSchemaName("ait_ait_outcome_ait_assessment_Outcome")]
    public IEnumerable<ait_assessment> ait_ait_outcome_ait_assessment_Outcome
    {
      get
      {
        return this.GetRelatedEntities<ait_assessment>(nameof (ait_ait_outcome_ait_assessment_Outcome), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_outcome_ait_assessment_Outcome));
        this.SetRelatedEntities<ait_assessment>(nameof (ait_ait_outcome_ait_assessment_Outcome), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_outcome_ait_assessment_Outcome));
      }
    }

    [RelationshipSchemaName("ait_ait_outcome_ait_goal_Outcome")]
    public IEnumerable<ait_goal> ait_ait_outcome_ait_goal_Outcome
    {
      get
      {
        return this.GetRelatedEntities<ait_goal>(nameof (ait_ait_outcome_ait_goal_Outcome), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_outcome_ait_goal_Outcome));
        this.SetRelatedEntities<ait_goal>(nameof (ait_ait_outcome_ait_goal_Outcome), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_outcome_ait_goal_Outcome));
      }
    }

    [RelationshipSchemaName("ait_ait_outcome_ait_planactivity_Outcome")]
    public IEnumerable<ait_planactivity> ait_ait_outcome_ait_planactivity_Outcome
    {
      get
      {
        return this.GetRelatedEntities<ait_planactivity>(nameof (ait_ait_outcome_ait_planactivity_Outcome), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_outcome_ait_planactivity_Outcome));
        this.SetRelatedEntities<ait_planactivity>(nameof (ait_ait_outcome_ait_planactivity_Outcome), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_outcome_ait_planactivity_Outcome));
      }
    }

    [RelationshipSchemaName("ait_ait_outcome_ait_referral_Outcome")]
    public IEnumerable<ait_referral> ait_ait_outcome_ait_referral_Outcome
    {
      get
      {
        return this.GetRelatedEntities<ait_referral>(nameof (ait_ait_outcome_ait_referral_Outcome), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_outcome_ait_referral_Outcome));
        this.SetRelatedEntities<ait_referral>(nameof (ait_ait_outcome_ait_referral_Outcome), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_outcome_ait_referral_Outcome));
      }
    }

    [RelationshipSchemaName("ait_ait_outcome_appointment_Outcome")]
    public IEnumerable<Appointment> ait_ait_outcome_appointment_Outcome
    {
      get
      {
        return this.GetRelatedEntities<Appointment>(nameof (ait_ait_outcome_appointment_Outcome), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_outcome_appointment_Outcome));
        this.SetRelatedEntities<Appointment>(nameof (ait_ait_outcome_appointment_Outcome), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_outcome_appointment_Outcome));
      }
    }

    [RelationshipSchemaName("ait_ait_outcome_email_Outcome")]
    public IEnumerable<Email> ait_ait_outcome_email_Outcome
    {
      get
      {
        return this.GetRelatedEntities<Email>(nameof (ait_ait_outcome_email_Outcome), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_outcome_email_Outcome));
        this.SetRelatedEntities<Email>(nameof (ait_ait_outcome_email_Outcome), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_outcome_email_Outcome));
      }
    }

    [RelationshipSchemaName("ait_ait_outcome_phonecall_Outcome")]
    public IEnumerable<PhoneCall> ait_ait_outcome_phonecall_Outcome
    {
      get
      {
        return this.GetRelatedEntities<PhoneCall>(nameof (ait_ait_outcome_phonecall_Outcome), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_outcome_phonecall_Outcome));
        this.SetRelatedEntities<PhoneCall>(nameof (ait_ait_outcome_phonecall_Outcome), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_outcome_phonecall_Outcome));
      }
    }

    [RelationshipSchemaName("ait_ait_outcome_task_Outcome")]
    public IEnumerable<Task> ait_ait_outcome_task_Outcome
    {
      get
      {
        return this.GetRelatedEntities<Task>(nameof (ait_ait_outcome_task_Outcome), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_outcome_task_Outcome));
        this.SetRelatedEntities<Task>(nameof (ait_ait_outcome_task_Outcome), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_outcome_task_Outcome));
      }
    }

    [RelationshipSchemaName("ait_outcome_ait_casenotefamilywellness_Outcome")]
    public IEnumerable<ait_casenotefamilywellness> ait_outcome_ait_casenotefamilywellness_Outcome
    {
      get
      {
        return this.GetRelatedEntities<ait_casenotefamilywellness>(nameof (ait_outcome_ait_casenotefamilywellness_Outcome), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_outcome_ait_casenotefamilywellness_Outcome));
        this.SetRelatedEntities<ait_casenotefamilywellness>(nameof (ait_outcome_ait_casenotefamilywellness_Outcome), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_outcome_ait_casenotefamilywellness_Outcome));
      }
    }

    [RelationshipSchemaName("ait_outcome_Appointments")]
    public IEnumerable<Appointment> ait_outcome_Appointments
    {
      get
      {
        return this.GetRelatedEntities<Appointment>(nameof (ait_outcome_Appointments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_outcome_Appointments));
        this.SetRelatedEntities<Appointment>(nameof (ait_outcome_Appointments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_outcome_Appointments));
      }
    }

    [RelationshipSchemaName("ait_outcome_Emails")]
    public IEnumerable<Email> ait_outcome_Emails
    {
      get => this.GetRelatedEntities<Email>(nameof (ait_outcome_Emails), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_outcome_Emails));
        this.SetRelatedEntities<Email>(nameof (ait_outcome_Emails), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_outcome_Emails));
      }
    }

    [RelationshipSchemaName("ait_outcome_PhoneCalls")]
    public IEnumerable<PhoneCall> ait_outcome_PhoneCalls
    {
      get => this.GetRelatedEntities<PhoneCall>(nameof (ait_outcome_PhoneCalls), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_outcome_PhoneCalls));
        this.SetRelatedEntities<PhoneCall>(nameof (ait_outcome_PhoneCalls), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_outcome_PhoneCalls));
      }
    }

    [RelationshipSchemaName("ait_outcome_Tasks")]
    public IEnumerable<Task> ait_outcome_Tasks
    {
      get => this.GetRelatedEntities<Task>(nameof (ait_outcome_Tasks), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_outcome_Tasks));
        this.SetRelatedEntities<Task>(nameof (ait_outcome_Tasks), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_outcome_Tasks));
      }
    }

    [AttributeLogicalName("ait_caseplan")]
    [RelationshipSchemaName("ait_ait_caseplan_ait_outcome_Plan")]
    public ait_caseplan ait_ait_caseplan_ait_outcome_Plan
    {
      get
      {
        return this.GetRelatedEntity<ait_caseplan>(nameof (ait_ait_caseplan_ait_outcome_Plan), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_caseplan_ait_outcome_Plan));
        this.SetRelatedEntity<ait_caseplan>(nameof (ait_ait_caseplan_ait_outcome_Plan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_caseplan_ait_outcome_Plan));
      }
    }

    [AttributeLogicalName("ait_individual")]
    [RelationshipSchemaName("ait_ait_clientprofile_ait_outcome_Individual")]
    public ait_clientprofile ait_ait_clientprofile_ait_outcome_Individual
    {
      get
      {
        return this.GetRelatedEntity<ait_clientprofile>(nameof (ait_ait_clientprofile_ait_outcome_Individual), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_clientprofile_ait_outcome_Individual));
        this.SetRelatedEntity<ait_clientprofile>(nameof (ait_ait_clientprofile_ait_outcome_Individual), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_clientprofile_ait_outcome_Individual));
      }
    }

    [AttributeLogicalName("ait_familygroup")]
    [RelationshipSchemaName("ait_ait_familygroup_ait_outcome_FamilyGroup")]
    public ait_familygroup ait_ait_familygroup_ait_outcome_FamilyGroup
    {
      get
      {
        return this.GetRelatedEntity<ait_familygroup>(nameof (ait_ait_familygroup_ait_outcome_FamilyGroup), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_familygroup_ait_outcome_FamilyGroup));
        this.SetRelatedEntity<ait_familygroup>(nameof (ait_ait_familygroup_ait_outcome_FamilyGroup), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_familygroup_ait_outcome_FamilyGroup));
      }
    }

    [AttributeLogicalName("ait_goal")]
    [RelationshipSchemaName("ait_ait_goal_ait_outcome_Goal")]
    public ait_goal ait_ait_goal_ait_outcome_Goal
    {
      get
      {
        return this.GetRelatedEntity<ait_goal>(nameof (ait_ait_goal_ait_outcome_Goal), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_goal_ait_outcome_Goal));
        this.SetRelatedEntity<ait_goal>(nameof (ait_ait_goal_ait_outcome_Goal), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_goal_ait_outcome_Goal));
      }
    }

    [AttributeLogicalName("ait_program")]
    [RelationshipSchemaName("ait_ait_program_ait_outcome_Program")]
    public ait_program ait_ait_program_ait_outcome_Program
    {
      get
      {
        return this.GetRelatedEntity<ait_program>(nameof (ait_ait_program_ait_outcome_Program), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_program_ait_outcome_Program));
        this.SetRelatedEntity<ait_program>(nameof (ait_ait_program_ait_outcome_Program), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_program_ait_outcome_Program));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_outcome")]
    public BusinessUnit business_unit_ait_outcome
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_outcome), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_outcome_createdby")]
    public SystemUser lk_ait_outcome_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_outcome_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_outcome_createdonbehalfby")]
    public SystemUser lk_ait_outcome_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_outcome_createdonbehalfby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_outcome_modifiedby")]
    public SystemUser lk_ait_outcome_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_outcome_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_outcome_modifiedonbehalfby")]
    public SystemUser lk_ait_outcome_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_outcome_modifiedonbehalfby), new EntityRole?());
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_outcome")]
    public Team team_ait_outcome
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_outcome), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_outcome")]
    public SystemUser user_ait_outcome
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_ait_outcome), new EntityRole?());
    }
  }
}
