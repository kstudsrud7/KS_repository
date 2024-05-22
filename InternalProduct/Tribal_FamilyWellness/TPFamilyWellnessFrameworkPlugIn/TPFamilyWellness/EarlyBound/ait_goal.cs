// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EarlyBound.ait_goal
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_goal")]
  [GeneratedCode("CrmSvcUtil", "9.0.0.9154")]
  public class ait_goal : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_goal";
    public const int EntityTypeCode = 10381;

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
    public Ait_goalState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new Ait_goalState?((Ait_goalState) Enum.ToObject(typeof (Ait_goalState), attributeValue.Value)) : new Ait_goalState?();
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
  }
}
