// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_assessment
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_assessment")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_assessment : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_assessment";
    public const string EntitySchemaName = "ait_assessment";
    public const string PrimaryIdAttribute = "ait_assessmentid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_assessment()
      : base(nameof (ait_assessment))
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

    [AttributeLogicalName("ait_actualtime")]
    public int? ait_ActualTime
    {
      get => this.GetAttributeValue<int?>("ait_actualtime");
      set
      {
        this.OnPropertyChanging(nameof (ait_ActualTime));
        this.SetAttributeValue("ait_actualtime", (object) value);
        this.OnPropertyChanged(nameof (ait_ActualTime));
      }
    }

    [AttributeLogicalName("ait_actualtraveltime")]
    public int? ait_ActualTravelTime
    {
      get => this.GetAttributeValue<int?>("ait_actualtraveltime");
      set
      {
        this.OnPropertyChanging(nameof (ait_ActualTravelTime));
        this.SetAttributeValue("ait_actualtraveltime", (object) value);
        this.OnPropertyChanged(nameof (ait_ActualTravelTime));
      }
    }

    [AttributeLogicalName("ait_assessmentautoid")]
    public string ait_AssessmentAutoID
    {
      get => this.GetAttributeValue<string>("ait_assessmentautoid");
      set
      {
        this.OnPropertyChanging(nameof (ait_AssessmentAutoID));
        this.SetAttributeValue("ait_assessmentautoid", (object) value);
        this.OnPropertyChanged(nameof (ait_AssessmentAutoID));
      }
    }

    [AttributeLogicalName("ait_assessmentid")]
    public Guid? ait_assessmentId
    {
      get => this.GetAttributeValue<Guid?>("ait_assessmentid");
      set
      {
        this.OnPropertyChanging(nameof (ait_assessmentId));
        this.SetAttributeValue("ait_assessmentid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_assessmentId));
      }
    }

    [AttributeLogicalName("ait_assessmentid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_assessmentId = new Guid?(value);
    }

    [AttributeLogicalName("ait_assessmentnarrative")]
    public string ait_AssessmentNarrative
    {
      get => this.GetAttributeValue<string>("ait_assessmentnarrative");
      set
      {
        this.OnPropertyChanging(nameof (ait_AssessmentNarrative));
        this.SetAttributeValue("ait_assessmentnarrative", (object) value);
        this.OnPropertyChanged(nameof (ait_AssessmentNarrative));
      }
    }

    [AttributeLogicalName("ait_assessmentstatus")]
    public OptionSetValue ait_assessmentstatus
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_assessmentstatus));
      set
      {
        this.OnPropertyChanging(nameof (ait_assessmentstatus));
        this.SetAttributeValue(nameof (ait_assessmentstatus), (object) value);
        this.OnPropertyChanged(nameof (ait_assessmentstatus));
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

    [AttributeLogicalName("ait_comments")]
    public string ait_comments
    {
      get => this.GetAttributeValue<string>(nameof (ait_comments));
      set
      {
        this.OnPropertyChanging(nameof (ait_comments));
        this.SetAttributeValue(nameof (ait_comments), (object) value);
        this.OnPropertyChanged(nameof (ait_comments));
      }
    }

    [AttributeLogicalName("ait_culturalengagement")]
    public OptionSetValue ait_CulturalEngagement
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_culturalengagement");
      set
      {
        this.OnPropertyChanging(nameof (ait_CulturalEngagement));
        this.SetAttributeValue("ait_culturalengagement", (object) value);
        this.OnPropertyChanged(nameof (ait_CulturalEngagement));
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

    [AttributeLogicalName("ait_economicengagement")]
    public OptionSetValue ait_EconomicEngagement
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_economicengagement");
      set
      {
        this.OnPropertyChanging(nameof (ait_EconomicEngagement));
        this.SetAttributeValue("ait_economicengagement", (object) value);
        this.OnPropertyChanged(nameof (ait_EconomicEngagement));
      }
    }

    [AttributeLogicalName("ait_educationengagement")]
    public OptionSetValue ait_EducationEngagement
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_educationengagement");
      set
      {
        this.OnPropertyChanging(nameof (ait_EducationEngagement));
        this.SetAttributeValue("ait_educationengagement", (object) value);
        this.OnPropertyChanged(nameof (ait_EducationEngagement));
      }
    }

    [AttributeLogicalName("ait_faithengagement")]
    public OptionSetValue ait_FaithEngagement
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_faithengagement");
      set
      {
        this.OnPropertyChanging(nameof (ait_FaithEngagement));
        this.SetAttributeValue("ait_faithengagement", (object) value);
        this.OnPropertyChanged(nameof (ait_FaithEngagement));
      }
    }

    [AttributeLogicalName("ait_familyengagement")]
    public OptionSetValue ait_FamilyEngagement
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_familyengagement");
      set
      {
        this.OnPropertyChanging(nameof (ait_FamilyEngagement));
        this.SetAttributeValue("ait_familyengagement", (object) value);
        this.OnPropertyChanged(nameof (ait_FamilyEngagement));
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
    public EntityReference ait_goal
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_goal));
      set
      {
        this.OnPropertyChanging(nameof (ait_goal));
        this.SetAttributeValue(nameof (ait_goal), (object) value);
        this.OnPropertyChanged(nameof (ait_goal));
      }
    }

    [AttributeLogicalName("ait_housingsituation")]
    public OptionSetValue ait_HousingSituation
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_housingsituation");
      set
      {
        this.OnPropertyChanging(nameof (ait_HousingSituation));
        this.SetAttributeValue("ait_housingsituation", (object) value);
        this.OnPropertyChanged(nameof (ait_HousingSituation));
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

    [AttributeLogicalName("ait_medicalengagement")]
    public OptionSetValue ait_MedicalEngagement
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_medicalengagement");
      set
      {
        this.OnPropertyChanging(nameof (ait_MedicalEngagement));
        this.SetAttributeValue("ait_medicalengagement", (object) value);
        this.OnPropertyChanged(nameof (ait_MedicalEngagement));
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

    [AttributeLogicalName("ait_socialengagement")]
    public OptionSetValue ait_SocialEngagement
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_socialengagement");
      set
      {
        this.OnPropertyChanging(nameof (ait_SocialEngagement));
        this.SetAttributeValue("ait_socialengagement", (object) value);
        this.OnPropertyChanged(nameof (ait_SocialEngagement));
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
    public ait_assessmentState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_assessmentState?((ait_assessmentState) Enum.ToObject(typeof (ait_assessmentState), attributeValue.Value)) : new ait_assessmentState?();
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

    [RelationshipSchemaName("ait_ait_assessment_ait_planactivity_Assessment")]
    public IEnumerable<ait_planactivity> ait_ait_assessment_ait_planactivity_Assessment
    {
      get
      {
        return this.GetRelatedEntities<ait_planactivity>(nameof (ait_ait_assessment_ait_planactivity_Assessment), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_assessment_ait_planactivity_Assessment));
        this.SetRelatedEntities<ait_planactivity>(nameof (ait_ait_assessment_ait_planactivity_Assessment), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_assessment_ait_planactivity_Assessment));
      }
    }

    [RelationshipSchemaName("ait_assessment_ActivityParties")]
    public IEnumerable<ActivityParty> ait_assessment_ActivityParties
    {
      get
      {
        return this.GetRelatedEntities<ActivityParty>(nameof (ait_assessment_ActivityParties), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_assessment_ActivityParties));
        this.SetRelatedEntities<ActivityParty>(nameof (ait_assessment_ActivityParties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_assessment_ActivityParties));
      }
    }

    [RelationshipSchemaName("ait_assessment_ActivityPointers")]
    public IEnumerable<ActivityPointer> ait_assessment_ActivityPointers
    {
      get
      {
        return this.GetRelatedEntities<ActivityPointer>(nameof (ait_assessment_ActivityPointers), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_assessment_ActivityPointers));
        this.SetRelatedEntities<ActivityPointer>(nameof (ait_assessment_ActivityPointers), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_assessment_ActivityPointers));
      }
    }

    [RelationshipSchemaName("ait_assessment_Annotations")]
    public IEnumerable<Annotation> ait_assessment_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (ait_assessment_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_assessment_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (ait_assessment_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_assessment_Annotations));
      }
    }

    [RelationshipSchemaName("ait_assessment_Appointments")]
    public IEnumerable<Appointment> ait_assessment_Appointments
    {
      get
      {
        return this.GetRelatedEntities<Appointment>(nameof (ait_assessment_Appointments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_assessment_Appointments));
        this.SetRelatedEntities<Appointment>(nameof (ait_assessment_Appointments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_assessment_Appointments));
      }
    }

    [RelationshipSchemaName("ait_assessment_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_assessment_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_assessment_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_assessment_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_assessment_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_assessment_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_assessment_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_assessment_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_assessment_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_assessment_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_assessment_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_assessment_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_assessment_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_assessment_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_assessment_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_assessment_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_assessment_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_assessment_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_assessment_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_assessment_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_assessment_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_assessment_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_assessment_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_assessment_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_assessment_Emails")]
    public IEnumerable<Email> ait_assessment_Emails
    {
      get => this.GetRelatedEntities<Email>(nameof (ait_assessment_Emails), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_assessment_Emails));
        this.SetRelatedEntities<Email>(nameof (ait_assessment_Emails), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_assessment_Emails));
      }
    }

    [RelationshipSchemaName("ait_assessment_Faxes")]
    public IEnumerable<Fax> ait_assessment_Faxes
    {
      get => this.GetRelatedEntities<Fax>(nameof (ait_assessment_Faxes), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_assessment_Faxes));
        this.SetRelatedEntities<Fax>(nameof (ait_assessment_Faxes), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_assessment_Faxes));
      }
    }

    [RelationshipSchemaName("ait_assessment_Letters")]
    public IEnumerable<Letter> ait_assessment_Letters
    {
      get => this.GetRelatedEntities<Letter>(nameof (ait_assessment_Letters), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_assessment_Letters));
        this.SetRelatedEntities<Letter>(nameof (ait_assessment_Letters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_assessment_Letters));
      }
    }

    [RelationshipSchemaName("ait_assessment_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_assessment_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_assessment_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_assessment_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_assessment_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_assessment_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_assessment_PhoneCalls")]
    public IEnumerable<PhoneCall> ait_assessment_PhoneCalls
    {
      get
      {
        return this.GetRelatedEntities<PhoneCall>(nameof (ait_assessment_PhoneCalls), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_assessment_PhoneCalls));
        this.SetRelatedEntities<PhoneCall>(nameof (ait_assessment_PhoneCalls), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_assessment_PhoneCalls));
      }
    }

    [RelationshipSchemaName("ait_assessment_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_assessment_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_assessment_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_assessment_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_assessment_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_assessment_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_assessment_ProcessSession")]
    public IEnumerable<ProcessSession> ait_assessment_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_assessment_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_assessment_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_assessment_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_assessment_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_assessment_RecurringAppointmentMasters")]
    public IEnumerable<RecurringAppointmentMaster> ait_assessment_RecurringAppointmentMasters
    {
      get
      {
        return this.GetRelatedEntities<RecurringAppointmentMaster>(nameof (ait_assessment_RecurringAppointmentMasters), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_assessment_RecurringAppointmentMasters));
        this.SetRelatedEntities<RecurringAppointmentMaster>(nameof (ait_assessment_RecurringAppointmentMasters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_assessment_RecurringAppointmentMasters));
      }
    }

    [RelationshipSchemaName("ait_assessment_SocialActivities")]
    public IEnumerable<SocialActivity> ait_assessment_SocialActivities
    {
      get
      {
        return this.GetRelatedEntities<SocialActivity>(nameof (ait_assessment_SocialActivities), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_assessment_SocialActivities));
        this.SetRelatedEntities<SocialActivity>(nameof (ait_assessment_SocialActivities), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_assessment_SocialActivities));
      }
    }

    [RelationshipSchemaName("ait_assessment_SyncErrors")]
    public IEnumerable<SyncError> ait_assessment_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_assessment_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_assessment_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_assessment_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_assessment_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_assessment_Tasks")]
    public IEnumerable<Task> ait_assessment_Tasks
    {
      get => this.GetRelatedEntities<Task>(nameof (ait_assessment_Tasks), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_assessment_Tasks));
        this.SetRelatedEntities<Task>(nameof (ait_assessment_Tasks), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_assessment_Tasks));
      }
    }

    [RelationshipSchemaName("ait_assessment_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_assessment_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_assessment_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_assessment_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_assessment_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_assessment_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_caseworker")]
    [RelationshipSchemaName("ait_ait_assessment_ait_Caseworker_systemu")]
    public SystemUser ait_ait_assessment_ait_Caseworker_systemu
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (ait_ait_assessment_ait_Caseworker_systemu), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_assessment_ait_Caseworker_systemu));
        this.SetRelatedEntity<SystemUser>(nameof (ait_ait_assessment_ait_Caseworker_systemu), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_assessment_ait_Caseworker_systemu));
      }
    }

    [AttributeLogicalName("ait_case")]
    [RelationshipSchemaName("ait_ait_case_ait_assessment_Case")]
    public ait_case ait_ait_case_ait_assessment_Case
    {
      get
      {
        return this.GetRelatedEntity<ait_case>(nameof (ait_ait_case_ait_assessment_Case), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_case_ait_assessment_Case));
        this.SetRelatedEntity<ait_case>(nameof (ait_ait_case_ait_assessment_Case), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_case_ait_assessment_Case));
      }
    }

    [AttributeLogicalName("ait_caseplan")]
    [RelationshipSchemaName("ait_ait_caseplan_ait_assessment_Plan")]
    public ait_caseplan ait_ait_caseplan_ait_assessment_Plan
    {
      get
      {
        return this.GetRelatedEntity<ait_caseplan>(nameof (ait_ait_caseplan_ait_assessment_Plan), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_caseplan_ait_assessment_Plan));
        this.SetRelatedEntity<ait_caseplan>(nameof (ait_ait_caseplan_ait_assessment_Plan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_caseplan_ait_assessment_Plan));
      }
    }

    [AttributeLogicalName("ait_individual")]
    [RelationshipSchemaName("ait_ait_clientprofile_ait_assessment_Individual")]
    public ait_clientprofile ait_ait_clientprofile_ait_assessment_Individual
    {
      get
      {
        return this.GetRelatedEntity<ait_clientprofile>(nameof (ait_ait_clientprofile_ait_assessment_Individual), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_clientprofile_ait_assessment_Individual));
        this.SetRelatedEntity<ait_clientprofile>(nameof (ait_ait_clientprofile_ait_assessment_Individual), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_clientprofile_ait_assessment_Individual));
      }
    }

    [AttributeLogicalName("ait_familygroup")]
    [RelationshipSchemaName("ait_ait_familygroup_ait_assessment_FamilyGroup")]
    public ait_familygroup ait_ait_familygroup_ait_assessment_FamilyGroup
    {
      get
      {
        return this.GetRelatedEntity<ait_familygroup>(nameof (ait_ait_familygroup_ait_assessment_FamilyGroup), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_familygroup_ait_assessment_FamilyGroup));
        this.SetRelatedEntity<ait_familygroup>(nameof (ait_ait_familygroup_ait_assessment_FamilyGroup), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_familygroup_ait_assessment_FamilyGroup));
      }
    }

    [AttributeLogicalName("ait_outcome")]
    [RelationshipSchemaName("ait_ait_outcome_ait_assessment_Outcome")]
    public ait_outcome ait_ait_outcome_ait_assessment_Outcome
    {
      get
      {
        return this.GetRelatedEntity<ait_outcome>(nameof (ait_ait_outcome_ait_assessment_Outcome), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_outcome_ait_assessment_Outcome));
        this.SetRelatedEntity<ait_outcome>(nameof (ait_ait_outcome_ait_assessment_Outcome), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_outcome_ait_assessment_Outcome));
      }
    }

    [AttributeLogicalName("ait_program")]
    [RelationshipSchemaName("ait_ait_program_ait_assessment_Program")]
    public ait_program ait_ait_program_ait_assessment_Program
    {
      get
      {
        return this.GetRelatedEntity<ait_program>(nameof (ait_ait_program_ait_assessment_Program), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_program_ait_assessment_Program));
        this.SetRelatedEntity<ait_program>(nameof (ait_ait_program_ait_assessment_Program), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_program_ait_assessment_Program));
      }
    }

    [AttributeLogicalName("ait_goal")]
    [RelationshipSchemaName("ait_goal_ait_assessment_goal")]
    public ArcticIT.EarlyBound.Entities.ait_goal ait_goal_ait_assessment_goal
    {
      get
      {
        return this.GetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_goal>(nameof (ait_goal_ait_assessment_goal), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_goal_ait_assessment_goal));
        this.SetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_goal>(nameof (ait_goal_ait_assessment_goal), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_goal_ait_assessment_goal));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_assessment")]
    public BusinessUnit business_unit_ait_assessment
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_assessment), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_assessment_createdby")]
    public SystemUser lk_ait_assessment_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_assessment_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_assessment_createdonbehalfby")]
    public SystemUser lk_ait_assessment_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_assessment_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_assessment_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_assessment_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_assessment_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_assessment_modifiedby")]
    public SystemUser lk_ait_assessment_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_assessment_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_assessment_modifiedonbehalfby")]
    public SystemUser lk_ait_assessment_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_assessment_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_assessment_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_assessment_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_assessment_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_assessment")]
    public Team team_ait_assessment
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_assessment), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_assessment")]
    public SystemUser user_ait_assessment
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_ait_assessment), new EntityRole?());
    }

    public ait_assessment(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_assessmentid"] = (object) base.Id;
            break;
          case "ait_assessmentid":
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
