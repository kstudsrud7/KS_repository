// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_goal
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_goal")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_goal : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_goal";
    public const string EntitySchemaName = "ait_goal";
    public const string PrimaryIdAttribute = "ait_goalid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_goal()
      : base(nameof (ait_goal))
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

    [AttributeLogicalName("ait_actualcompletion")]
    public DateTime? ait_ActualCompletion
    {
      get => this.GetAttributeValue<DateTime?>("ait_actualcompletion");
      set
      {
        this.OnPropertyChanging(nameof (ait_ActualCompletion));
        this.SetAttributeValue("ait_actualcompletion", (object) value);
        this.OnPropertyChanged(nameof (ait_ActualCompletion));
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

    [AttributeLogicalName("ait_caseworker")]
    public EntityReference ait_Caseworker
    {
      get => this.GetAttributeValue<EntityReference>("ait_caseworker");
      set
      {
        this.OnPropertyChanging(nameof (ait_Caseworker));
        this.SetAttributeValue("ait_caseworker", (object) value);
        this.OnPropertyChanged(nameof (ait_Caseworker));
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

    [AttributeLogicalName("ait_goalautoid")]
    public string ait_GoalAutoID
    {
      get => this.GetAttributeValue<string>("ait_goalautoid");
      set
      {
        this.OnPropertyChanging(nameof (ait_GoalAutoID));
        this.SetAttributeValue("ait_goalautoid", (object) value);
        this.OnPropertyChanged(nameof (ait_GoalAutoID));
      }
    }

    [AttributeLogicalName("ait_goalid")]
    public Guid? ait_goalId
    {
      get => this.GetAttributeValue<Guid?>("ait_goalid");
      set
      {
        this.OnPropertyChanging(nameof (ait_goalId));
        this.SetAttributeValue("ait_goalid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_goalId));
      }
    }

    [AttributeLogicalName("ait_goalid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_goalId = new Guid?(value);
    }

    [AttributeLogicalName("ait_goalnotes")]
    public string ait_GoalNotes
    {
      get => this.GetAttributeValue<string>("ait_goalnotes");
      set
      {
        this.OnPropertyChanging(nameof (ait_GoalNotes));
        this.SetAttributeValue("ait_goalnotes", (object) value);
        this.OnPropertyChanged(nameof (ait_GoalNotes));
      }
    }

    [AttributeLogicalName("ait_goalstatus")]
    public OptionSetValue ait_GoalStatus
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_goalstatus");
      set
      {
        this.OnPropertyChanging(nameof (ait_GoalStatus));
        this.SetAttributeValue("ait_goalstatus", (object) value);
        this.OnPropertyChanged(nameof (ait_GoalStatus));
      }
    }

    [AttributeLogicalName("ait_goalsummary")]
    public string ait_GoalSummary
    {
      get => this.GetAttributeValue<string>("ait_goalsummary");
      set
      {
        this.OnPropertyChanging(nameof (ait_GoalSummary));
        this.SetAttributeValue("ait_goalsummary", (object) value);
        this.OnPropertyChanged(nameof (ait_GoalSummary));
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

    [AttributeLogicalName("ait_intervention")]
    public string ait_Intervention
    {
      get => this.GetAttributeValue<string>("ait_intervention");
      set
      {
        this.OnPropertyChanging(nameof (ait_Intervention));
        this.SetAttributeValue("ait_intervention", (object) value);
        this.OnPropertyChanged(nameof (ait_Intervention));
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

    [AttributeLogicalName("ait_objective")]
    public string ait_Objective
    {
      get => this.GetAttributeValue<string>("ait_objective");
      set
      {
        this.OnPropertyChanging(nameof (ait_Objective));
        this.SetAttributeValue("ait_objective", (object) value);
        this.OnPropertyChanged(nameof (ait_Objective));
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

    [AttributeLogicalName("ait_targetdate")]
    public DateTime? ait_TargetDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_targetdate");
      set
      {
        this.OnPropertyChanging(nameof (ait_TargetDate));
        this.SetAttributeValue("ait_targetdate", (object) value);
        this.OnPropertyChanged(nameof (ait_TargetDate));
      }
    }

    [AttributeLogicalName("ait_totalmeetingtime")]
    public int? ait_TotalMeetingTime
    {
      get => this.GetAttributeValue<int?>("ait_totalmeetingtime");
      set
      {
        this.OnPropertyChanging(nameof (ait_TotalMeetingTime));
        this.SetAttributeValue("ait_totalmeetingtime", (object) value);
        this.OnPropertyChanged(nameof (ait_TotalMeetingTime));
      }
    }

    [AttributeLogicalName("ait_totaltraveltime")]
    public int? ait_TotalTraveltime
    {
      get => this.GetAttributeValue<int?>("ait_totaltraveltime");
      set
      {
        this.OnPropertyChanging(nameof (ait_TotalTraveltime));
        this.SetAttributeValue("ait_totaltraveltime", (object) value);
        this.OnPropertyChanged(nameof (ait_TotalTraveltime));
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
      set
      {
        this.OnPropertyChanging(nameof (ModifiedOnBehalfBy));
        this.SetAttributeValue("modifiedonbehalfby", (object) value);
        this.OnPropertyChanged(nameof (ModifiedOnBehalfBy));
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

    [AttributeLogicalName("statecode")]
    public ait_goalState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_goalState?((ait_goalState) Enum.ToObject(typeof (ait_goalState), attributeValue.Value)) : new ait_goalState?();
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

    [RelationshipSchemaName("ait_ait_goal_ait_outcome_Goal")]
    public IEnumerable<ait_outcome> ait_ait_goal_ait_outcome_Goal
    {
      get
      {
        return this.GetRelatedEntities<ait_outcome>(nameof (ait_ait_goal_ait_outcome_Goal), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_goal_ait_outcome_Goal));
        this.SetRelatedEntities<ait_outcome>(nameof (ait_ait_goal_ait_outcome_Goal), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_goal_ait_outcome_Goal));
      }
    }

    [RelationshipSchemaName("ait_ait_goal_ait_planactivity_Goal")]
    public IEnumerable<ait_planactivity> ait_ait_goal_ait_planactivity_Goal
    {
      get
      {
        return this.GetRelatedEntities<ait_planactivity>(nameof (ait_ait_goal_ait_planactivity_Goal), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_goal_ait_planactivity_Goal));
        this.SetRelatedEntities<ait_planactivity>(nameof (ait_ait_goal_ait_planactivity_Goal), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_goal_ait_planactivity_Goal));
      }
    }

    [RelationshipSchemaName("ait_ait_goal_ait_referral_Goal")]
    public IEnumerable<ait_referral> ait_ait_goal_ait_referral_Goal
    {
      get
      {
        return this.GetRelatedEntities<ait_referral>(nameof (ait_ait_goal_ait_referral_Goal), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_goal_ait_referral_Goal));
        this.SetRelatedEntities<ait_referral>(nameof (ait_ait_goal_ait_referral_Goal), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_goal_ait_referral_Goal));
      }
    }

    [RelationshipSchemaName("ait_goal_ActivityParties")]
    public IEnumerable<ActivityParty> ait_goal_ActivityParties
    {
      get
      {
        return this.GetRelatedEntities<ActivityParty>(nameof (ait_goal_ActivityParties), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_goal_ActivityParties));
        this.SetRelatedEntities<ActivityParty>(nameof (ait_goal_ActivityParties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_goal_ActivityParties));
      }
    }

    [RelationshipSchemaName("ait_goal_ActivityPointers")]
    public IEnumerable<ActivityPointer> ait_goal_ActivityPointers
    {
      get
      {
        return this.GetRelatedEntities<ActivityPointer>(nameof (ait_goal_ActivityPointers), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_goal_ActivityPointers));
        this.SetRelatedEntities<ActivityPointer>(nameof (ait_goal_ActivityPointers), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_goal_ActivityPointers));
      }
    }

    [RelationshipSchemaName("ait_goal_ait_assessment_goal")]
    public IEnumerable<ait_assessment> ait_goal_ait_assessment_goal
    {
      get
      {
        return this.GetRelatedEntities<ait_assessment>(nameof (ait_goal_ait_assessment_goal), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_goal_ait_assessment_goal));
        this.SetRelatedEntities<ait_assessment>(nameof (ait_goal_ait_assessment_goal), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_goal_ait_assessment_goal));
      }
    }

    [RelationshipSchemaName("ait_goal_ait_payment_goal")]
    public IEnumerable<ait_payment> ait_goal_ait_payment_goal
    {
      get
      {
        return this.GetRelatedEntities<ait_payment>(nameof (ait_goal_ait_payment_goal), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_goal_ait_payment_goal));
        this.SetRelatedEntities<ait_payment>(nameof (ait_goal_ait_payment_goal), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_goal_ait_payment_goal));
      }
    }

    [RelationshipSchemaName("ait_goal_Annotations")]
    public IEnumerable<Annotation> ait_goal_Annotations
    {
      get => this.GetRelatedEntities<Annotation>(nameof (ait_goal_Annotations), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_goal_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (ait_goal_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_goal_Annotations));
      }
    }

    [RelationshipSchemaName("ait_goal_Appointments")]
    public IEnumerable<Appointment> ait_goal_Appointments
    {
      get
      {
        return this.GetRelatedEntities<Appointment>(nameof (ait_goal_Appointments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_goal_Appointments));
        this.SetRelatedEntities<Appointment>(nameof (ait_goal_Appointments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_goal_Appointments));
      }
    }

    [RelationshipSchemaName("ait_goal_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_goal_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_goal_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_goal_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_goal_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_goal_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_goal_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_goal_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_goal_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_goal_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_goal_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_goal_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_goal_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_goal_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_goal_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_goal_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_goal_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_goal_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_goal_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_goal_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_goal_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_goal_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_goal_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_goal_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_goal_Emails")]
    public IEnumerable<Email> ait_goal_Emails
    {
      get => this.GetRelatedEntities<Email>(nameof (ait_goal_Emails), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_goal_Emails));
        this.SetRelatedEntities<Email>(nameof (ait_goal_Emails), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_goal_Emails));
      }
    }

    [RelationshipSchemaName("ait_goal_Faxes")]
    public IEnumerable<Fax> ait_goal_Faxes
    {
      get => this.GetRelatedEntities<Fax>(nameof (ait_goal_Faxes), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_goal_Faxes));
        this.SetRelatedEntities<Fax>(nameof (ait_goal_Faxes), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_goal_Faxes));
      }
    }

    [RelationshipSchemaName("ait_goal_Letters")]
    public IEnumerable<Letter> ait_goal_Letters
    {
      get => this.GetRelatedEntities<Letter>(nameof (ait_goal_Letters), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_goal_Letters));
        this.SetRelatedEntities<Letter>(nameof (ait_goal_Letters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_goal_Letters));
      }
    }

    [RelationshipSchemaName("ait_goal_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_goal_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_goal_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_goal_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_goal_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_goal_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_goal_PhoneCalls")]
    public IEnumerable<PhoneCall> ait_goal_PhoneCalls
    {
      get => this.GetRelatedEntities<PhoneCall>(nameof (ait_goal_PhoneCalls), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_goal_PhoneCalls));
        this.SetRelatedEntities<PhoneCall>(nameof (ait_goal_PhoneCalls), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_goal_PhoneCalls));
      }
    }

    [RelationshipSchemaName("ait_goal_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_goal_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_goal_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_goal_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_goal_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_goal_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_goal_ProcessSession")]
    public IEnumerable<ProcessSession> ait_goal_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_goal_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_goal_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_goal_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_goal_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_goal_RecurringAppointmentMasters")]
    public IEnumerable<RecurringAppointmentMaster> ait_goal_RecurringAppointmentMasters
    {
      get
      {
        return this.GetRelatedEntities<RecurringAppointmentMaster>(nameof (ait_goal_RecurringAppointmentMasters), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_goal_RecurringAppointmentMasters));
        this.SetRelatedEntities<RecurringAppointmentMaster>(nameof (ait_goal_RecurringAppointmentMasters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_goal_RecurringAppointmentMasters));
      }
    }

    [RelationshipSchemaName("ait_goal_SocialActivities")]
    public IEnumerable<SocialActivity> ait_goal_SocialActivities
    {
      get
      {
        return this.GetRelatedEntities<SocialActivity>(nameof (ait_goal_SocialActivities), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_goal_SocialActivities));
        this.SetRelatedEntities<SocialActivity>(nameof (ait_goal_SocialActivities), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_goal_SocialActivities));
      }
    }

    [RelationshipSchemaName("ait_goal_SyncErrors")]
    public IEnumerable<SyncError> ait_goal_SyncErrors
    {
      get => this.GetRelatedEntities<SyncError>(nameof (ait_goal_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_goal_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_goal_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_goal_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_goal_Tasks")]
    public IEnumerable<Task> ait_goal_Tasks
    {
      get => this.GetRelatedEntities<Task>(nameof (ait_goal_Tasks), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_goal_Tasks));
        this.SetRelatedEntities<Task>(nameof (ait_goal_Tasks), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_goal_Tasks));
      }
    }

    [RelationshipSchemaName("ait_goal_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_goal_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_goal_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_goal_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_goal_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_goal_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_caseplan")]
    [RelationshipSchemaName("ait_ait_caseplan_ait_goal_Plan")]
    public ait_caseplan ait_ait_caseplan_ait_goal_Plan
    {
      get
      {
        return this.GetRelatedEntity<ait_caseplan>(nameof (ait_ait_caseplan_ait_goal_Plan), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_caseplan_ait_goal_Plan));
        this.SetRelatedEntity<ait_caseplan>(nameof (ait_ait_caseplan_ait_goal_Plan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_caseplan_ait_goal_Plan));
      }
    }

    [AttributeLogicalName("ait_individual")]
    [RelationshipSchemaName("ait_ait_clientprofile_ait_goal_Individual")]
    public ait_clientprofile ait_ait_clientprofile_ait_goal_Individual
    {
      get
      {
        return this.GetRelatedEntity<ait_clientprofile>(nameof (ait_ait_clientprofile_ait_goal_Individual), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_clientprofile_ait_goal_Individual));
        this.SetRelatedEntity<ait_clientprofile>(nameof (ait_ait_clientprofile_ait_goal_Individual), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_clientprofile_ait_goal_Individual));
      }
    }

    [AttributeLogicalName("ait_outcome")]
    [RelationshipSchemaName("ait_ait_outcome_ait_goal_Outcome")]
    public ait_outcome ait_ait_outcome_ait_goal_Outcome
    {
      get
      {
        return this.GetRelatedEntity<ait_outcome>(nameof (ait_ait_outcome_ait_goal_Outcome), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_outcome_ait_goal_Outcome));
        this.SetRelatedEntity<ait_outcome>(nameof (ait_ait_outcome_ait_goal_Outcome), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_outcome_ait_goal_Outcome));
      }
    }

    [AttributeLogicalName("ait_familygroup")]
    [RelationshipSchemaName("ait_familygroup_ait_goal_FamilyGroup")]
    public ait_familygroup ait_familygroup_ait_goal_FamilyGroup
    {
      get
      {
        return this.GetRelatedEntity<ait_familygroup>(nameof (ait_familygroup_ait_goal_FamilyGroup), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familygroup_ait_goal_FamilyGroup));
        this.SetRelatedEntity<ait_familygroup>(nameof (ait_familygroup_ait_goal_FamilyGroup), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familygroup_ait_goal_FamilyGroup));
      }
    }

    [AttributeLogicalName("ait_program")]
    [RelationshipSchemaName("ait_program_ait_goal_Program")]
    public ait_program ait_program_ait_goal_Program
    {
      get
      {
        return this.GetRelatedEntity<ait_program>(nameof (ait_program_ait_goal_Program), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_program_ait_goal_Program));
        this.SetRelatedEntity<ait_program>(nameof (ait_program_ait_goal_Program), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_program_ait_goal_Program));
      }
    }

    [AttributeLogicalName("ait_servicerequest")]
    [RelationshipSchemaName("ait_servicerequest_ait_goal_ServiceRequest")]
    public ait_servicerequest ait_servicerequest_ait_goal_ServiceRequest
    {
      get
      {
        return this.GetRelatedEntity<ait_servicerequest>(nameof (ait_servicerequest_ait_goal_ServiceRequest), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_ait_goal_ServiceRequest));
        this.SetRelatedEntity<ait_servicerequest>(nameof (ait_servicerequest_ait_goal_ServiceRequest), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_ait_goal_ServiceRequest));
      }
    }

    [AttributeLogicalName("ait_caseworker")]
    [RelationshipSchemaName("ait_systemuser_ait_goal_Caseworker")]
    public SystemUser ait_systemuser_ait_goal_Caseworker
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (ait_systemuser_ait_goal_Caseworker), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_systemuser_ait_goal_Caseworker));
        this.SetRelatedEntity<SystemUser>(nameof (ait_systemuser_ait_goal_Caseworker), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_systemuser_ait_goal_Caseworker));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_goal")]
    public BusinessUnit business_unit_ait_goal
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_goal), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_goal_createdby")]
    public SystemUser lk_ait_goal_createdby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_ait_goal_createdby), new EntityRole?());
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_goal_createdonbehalfby")]
    public SystemUser lk_ait_goal_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_goal_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_goal_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_goal_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_goal_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_goal_modifiedby")]
    public SystemUser lk_ait_goal_modifiedby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_ait_goal_modifiedby), new EntityRole?());
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_goal_modifiedonbehalfby")]
    public SystemUser lk_ait_goal_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_goal_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_goal_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_goal_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_goal_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_goal")]
    public Team team_ait_goal
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_goal), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_goal")]
    public SystemUser user_ait_goal
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_ait_goal), new EntityRole?());
    }

    public ait_goal(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_goalid"] = (object) base.Id;
            break;
          case "ait_goalid":
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
