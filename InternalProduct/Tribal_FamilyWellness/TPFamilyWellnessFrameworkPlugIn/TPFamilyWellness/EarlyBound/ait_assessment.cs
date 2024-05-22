// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EarlyBound.ait_assessment
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_assessment")]
  [GeneratedCode("CrmSvcUtil", "9.0.0.9154")]
  public class ait_assessment : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_assessment";
    public const int EntityTypeCode = 10375;

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
    public Ait_assessmentState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new Ait_assessmentState?((Ait_assessmentState) Enum.ToObject(typeof (Ait_assessmentState), attributeValue.Value)) : new Ait_assessmentState?();
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

    [AttributeLogicalName("ait_goal")]
    [RelationshipSchemaName("ait_goal_ait_assessment_goal")]
    public TPFamilyWellness.EarlyBound.ait_goal ait_goal_ait_assessment_goal
    {
      get
      {
        return this.GetRelatedEntity<TPFamilyWellness.EarlyBound.ait_goal>(nameof (ait_goal_ait_assessment_goal), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_goal_ait_assessment_goal));
        this.SetRelatedEntity<TPFamilyWellness.EarlyBound.ait_goal>(nameof (ait_goal_ait_assessment_goal), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_goal_ait_assessment_goal));
      }
    }
  }
}
