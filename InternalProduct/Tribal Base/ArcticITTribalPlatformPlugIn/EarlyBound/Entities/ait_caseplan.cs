// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_caseplan
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_caseplan")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_caseplan : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_caseplan";
    public const string EntitySchemaName = "ait_caseplan";
    public const string PrimaryIdAttribute = "ait_caseplanid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_caseplan()
      : base(nameof (ait_caseplan))
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

    [AttributeLogicalName("ait_additionalneeds")]
    public string ait_AdditionalNeeds
    {
      get => this.GetAttributeValue<string>("ait_additionalneeds");
      set
      {
        this.OnPropertyChanging(nameof (ait_AdditionalNeeds));
        this.SetAttributeValue("ait_additionalneeds", (object) value);
        this.OnPropertyChanged(nameof (ait_AdditionalNeeds));
      }
    }

    [AttributeLogicalName("ait_assessmenttimespent")]
    public int? ait_AssessmentTimeSpent => this.GetAttributeValue<int?>("ait_assessmenttimespent");

    [AttributeLogicalName("ait_assessmenttimespent_date")]
    public DateTime? ait_AssessmentTimeSpent_Date
    {
      get => this.GetAttributeValue<DateTime?>("ait_assessmenttimespent_date");
    }

    [AttributeLogicalName("ait_assessmenttimespent_state")]
    public int? ait_AssessmentTimeSpent_State
    {
      get => this.GetAttributeValue<int?>("ait_assessmenttimespent_state");
    }

    [AttributeLogicalName("ait_assessmenttraveltimespent")]
    public int? ait_AssessmentTravelTimeSpent
    {
      get => this.GetAttributeValue<int?>("ait_assessmenttraveltimespent");
    }

    [AttributeLogicalName("ait_assessmenttraveltimespent_date")]
    public DateTime? ait_AssessmentTravelTimeSpent_Date
    {
      get => this.GetAttributeValue<DateTime?>("ait_assessmenttraveltimespent_date");
    }

    [AttributeLogicalName("ait_assessmenttraveltimespent_state")]
    public int? ait_AssessmentTravelTimeSpent_State
    {
      get => this.GetAttributeValue<int?>("ait_assessmenttraveltimespent_state");
    }

    [AttributeLogicalName("ait_caseautoid")]
    public string ait_CaseAutoID
    {
      get => this.GetAttributeValue<string>("ait_caseautoid");
      set
      {
        this.OnPropertyChanging(nameof (ait_CaseAutoID));
        this.SetAttributeValue("ait_caseautoid", (object) value);
        this.OnPropertyChanged(nameof (ait_CaseAutoID));
      }
    }

    [AttributeLogicalName("ait_casenotetimespent")]
    public int? ait_CaseNoteTimeSpent => this.GetAttributeValue<int?>("ait_casenotetimespent");

    [AttributeLogicalName("ait_casenotetimespent_date")]
    public DateTime? ait_CaseNoteTimeSpent_Date
    {
      get => this.GetAttributeValue<DateTime?>("ait_casenotetimespent_date");
    }

    [AttributeLogicalName("ait_casenotetimespent_state")]
    public int? ait_CaseNoteTimeSpent_State
    {
      get => this.GetAttributeValue<int?>("ait_casenotetimespent_state");
    }

    [AttributeLogicalName("ait_casenotetraveltimespent")]
    public int? ait_CaseNoteTravelTimeSpent
    {
      get => this.GetAttributeValue<int?>("ait_casenotetraveltimespent");
    }

    [AttributeLogicalName("ait_casenotetraveltimespent_date")]
    public DateTime? ait_CaseNoteTravelTimeSpent_Date
    {
      get => this.GetAttributeValue<DateTime?>("ait_casenotetraveltimespent_date");
    }

    [AttributeLogicalName("ait_casenotetraveltimespent_state")]
    public int? ait_CaseNoteTravelTimeSpent_State
    {
      get => this.GetAttributeValue<int?>("ait_casenotetraveltimespent_state");
    }

    [AttributeLogicalName("ait_caseplanid")]
    public Guid? ait_caseplanId
    {
      get => this.GetAttributeValue<Guid?>("ait_caseplanid");
      set
      {
        this.OnPropertyChanging(nameof (ait_caseplanId));
        this.SetAttributeValue("ait_caseplanid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_caseplanId));
      }
    }

    [AttributeLogicalName("ait_caseplanid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_caseplanId = new Guid?(value);
    }

    [AttributeLogicalName("ait_casestatus")]
    public OptionSetValue ait_CaseStatus
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_casestatus");
      set
      {
        this.OnPropertyChanging(nameof (ait_CaseStatus));
        this.SetAttributeValue("ait_casestatus", (object) value);
        this.OnPropertyChanged(nameof (ait_CaseStatus));
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

    [AttributeLogicalName("ait_crisisdescription")]
    public string ait_CrisisDescription
    {
      get => this.GetAttributeValue<string>("ait_crisisdescription");
      set
      {
        this.OnPropertyChanging(nameof (ait_CrisisDescription));
        this.SetAttributeValue("ait_crisisdescription", (object) value);
        this.OnPropertyChanged(nameof (ait_CrisisDescription));
      }
    }

    [AttributeLogicalName("ait_crisisranking")]
    public OptionSetValue ait_CrisisRanking
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_crisisranking");
      set
      {
        this.OnPropertyChanging(nameof (ait_CrisisRanking));
        this.SetAttributeValue("ait_crisisranking", (object) value);
        this.OnPropertyChanged(nameof (ait_CrisisRanking));
      }
    }

    [AttributeLogicalName("ait_crisistype")]
    public OptionSetValue ait_CrisisType
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_crisistype");
      set
      {
        this.OnPropertyChanging(nameof (ait_CrisisType));
        this.SetAttributeValue("ait_crisistype", (object) value);
        this.OnPropertyChanged(nameof (ait_CrisisType));
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

    [AttributeLogicalName("ait_familyneeds")]
    public string ait_FamilyNeeds
    {
      get => this.GetAttributeValue<string>("ait_familyneeds");
      set
      {
        this.OnPropertyChanging(nameof (ait_FamilyNeeds));
        this.SetAttributeValue("ait_familyneeds", (object) value);
        this.OnPropertyChanged(nameof (ait_FamilyNeeds));
      }
    }

    [AttributeLogicalName("ait_goaltimespent")]
    public int? ait_GoalTimeSpent => this.GetAttributeValue<int?>("ait_goaltimespent");

    [AttributeLogicalName("ait_goaltimespent_date")]
    public DateTime? ait_GoalTimeSpent_Date
    {
      get => this.GetAttributeValue<DateTime?>("ait_goaltimespent_date");
    }

    [AttributeLogicalName("ait_goaltimespent_state")]
    public int? ait_GoalTimeSpent_State => this.GetAttributeValue<int?>("ait_goaltimespent_state");

    [AttributeLogicalName("ait_goaltraveltimespent")]
    public int? ait_GoalTravelTimeSpent => this.GetAttributeValue<int?>("ait_goaltraveltimespent");

    [AttributeLogicalName("ait_goaltraveltimespent_date")]
    public DateTime? ait_GoalTravelTimeSpent_Date
    {
      get => this.GetAttributeValue<DateTime?>("ait_goaltraveltimespent_date");
    }

    [AttributeLogicalName("ait_goaltraveltimespent_state")]
    public int? ait_GoalTravelTimeSpent_State
    {
      get => this.GetAttributeValue<int?>("ait_goaltraveltimespent_state");
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

    [AttributeLogicalName("ait_needsexpressedbyagency")]
    public string ait_NeedsExpressedbyAgency
    {
      get => this.GetAttributeValue<string>("ait_needsexpressedbyagency");
      set
      {
        this.OnPropertyChanging(nameof (ait_NeedsExpressedbyAgency));
        this.SetAttributeValue("ait_needsexpressedbyagency", (object) value);
        this.OnPropertyChanged(nameof (ait_NeedsExpressedbyAgency));
      }
    }

    [AttributeLogicalName("ait_needsnotagreedon")]
    public string ait_NeedsNotAgreedOn
    {
      get => this.GetAttributeValue<string>("ait_needsnotagreedon");
      set
      {
        this.OnPropertyChanging(nameof (ait_NeedsNotAgreedOn));
        this.SetAttributeValue("ait_needsnotagreedon", (object) value);
        this.OnPropertyChanged(nameof (ait_NeedsNotAgreedOn));
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

    [AttributeLogicalName("ait_planlength")]
    public string ait_PlanLength
    {
      get => this.GetAttributeValue<string>("ait_planlength");
      set
      {
        this.OnPropertyChanging(nameof (ait_PlanLength));
        this.SetAttributeValue("ait_planlength", (object) value);
        this.OnPropertyChanged(nameof (ait_PlanLength));
      }
    }

    [AttributeLogicalName("ait_planstartdate")]
    public DateTime? ait_PlanStartDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_planstartdate");
      set
      {
        this.OnPropertyChanging(nameof (ait_PlanStartDate));
        this.SetAttributeValue("ait_planstartdate", (object) value);
        this.OnPropertyChanged(nameof (ait_PlanStartDate));
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

    [AttributeLogicalName("ait_signoffdate")]
    public DateTime? ait_SignoffDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_signoffdate");
      set
      {
        this.OnPropertyChanging(nameof (ait_SignoffDate));
        this.SetAttributeValue("ait_signoffdate", (object) value);
        this.OnPropertyChanged(nameof (ait_SignoffDate));
      }
    }

    [AttributeLogicalName("ait_situation")]
    public string ait_Situation
    {
      get => this.GetAttributeValue<string>("ait_situation");
      set
      {
        this.OnPropertyChanging(nameof (ait_Situation));
        this.SetAttributeValue("ait_situation", (object) value);
        this.OnPropertyChanged(nameof (ait_Situation));
      }
    }

    [AttributeLogicalName("ait_totalcasetimespent")]
    public Decimal? ait_TotalCaseTimeSpent
    {
      get => this.GetAttributeValue<Decimal?>("ait_totalcasetimespent");
    }

    [AttributeLogicalName("ait_totaltimespenthours")]
    public Decimal? ait_TotalTimeSpenthours
    {
      get => this.GetAttributeValue<Decimal?>("ait_totaltimespenthours");
    }

    [AttributeLogicalName("ait_totaltraveltimespenthours")]
    public Decimal? ait_TotalTravelTimeSpenthours
    {
      get => this.GetAttributeValue<Decimal?>("ait_totaltraveltimespenthours");
    }

    [AttributeLogicalName("ait_vision")]
    public string ait_Vision
    {
      get => this.GetAttributeValue<string>("ait_vision");
      set
      {
        this.OnPropertyChanging(nameof (ait_Vision));
        this.SetAttributeValue("ait_vision", (object) value);
        this.OnPropertyChanged(nameof (ait_Vision));
      }
    }

    [AttributeLogicalName("ait_whatwillhappen")]
    public string ait_WhatWillHappen
    {
      get => this.GetAttributeValue<string>("ait_whatwillhappen");
      set
      {
        this.OnPropertyChanging(nameof (ait_WhatWillHappen));
        this.SetAttributeValue("ait_whatwillhappen", (object) value);
        this.OnPropertyChanged(nameof (ait_WhatWillHappen));
      }
    }

    [AttributeLogicalName("ait_whoelseinvolved")]
    public string ait_WhoelseInvolved
    {
      get => this.GetAttributeValue<string>("ait_whoelseinvolved");
      set
      {
        this.OnPropertyChanging(nameof (ait_WhoelseInvolved));
        this.SetAttributeValue("ait_whoelseinvolved", (object) value);
        this.OnPropertyChanged(nameof (ait_WhoelseInvolved));
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
    public ait_caseplanState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_caseplanState?((ait_caseplanState) Enum.ToObject(typeof (ait_caseplanState), attributeValue.Value)) : new ait_caseplanState?();
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

    [RelationshipSchemaName("ait_ait_caseplan_ait_assessment_Plan")]
    public IEnumerable<ait_assessment> ait_ait_caseplan_ait_assessment_Plan
    {
      get
      {
        return this.GetRelatedEntities<ait_assessment>(nameof (ait_ait_caseplan_ait_assessment_Plan), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_caseplan_ait_assessment_Plan));
        this.SetRelatedEntities<ait_assessment>(nameof (ait_ait_caseplan_ait_assessment_Plan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_caseplan_ait_assessment_Plan));
      }
    }

    [RelationshipSchemaName("ait_ait_caseplan_ait_casenote_Plan")]
    public IEnumerable<ait_casenote> ait_ait_caseplan_ait_casenote_Plan
    {
      get
      {
        return this.GetRelatedEntities<ait_casenote>(nameof (ait_ait_caseplan_ait_casenote_Plan), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_caseplan_ait_casenote_Plan));
        this.SetRelatedEntities<ait_casenote>(nameof (ait_ait_caseplan_ait_casenote_Plan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_caseplan_ait_casenote_Plan));
      }
    }

    [RelationshipSchemaName("ait_ait_caseplan_ait_goal_Plan")]
    public IEnumerable<ait_goal> ait_ait_caseplan_ait_goal_Plan
    {
      get
      {
        return this.GetRelatedEntities<ait_goal>(nameof (ait_ait_caseplan_ait_goal_Plan), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_caseplan_ait_goal_Plan));
        this.SetRelatedEntities<ait_goal>(nameof (ait_ait_caseplan_ait_goal_Plan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_caseplan_ait_goal_Plan));
      }
    }

    [RelationshipSchemaName("ait_ait_caseplan_ait_outcome_Plan")]
    public IEnumerable<ait_outcome> ait_ait_caseplan_ait_outcome_Plan
    {
      get
      {
        return this.GetRelatedEntities<ait_outcome>(nameof (ait_ait_caseplan_ait_outcome_Plan), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_caseplan_ait_outcome_Plan));
        this.SetRelatedEntities<ait_outcome>(nameof (ait_ait_caseplan_ait_outcome_Plan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_caseplan_ait_outcome_Plan));
      }
    }

    [RelationshipSchemaName("ait_ait_caseplan_ait_planactivity_Plan")]
    public IEnumerable<ait_planactivity> ait_ait_caseplan_ait_planactivity_Plan
    {
      get
      {
        return this.GetRelatedEntities<ait_planactivity>(nameof (ait_ait_caseplan_ait_planactivity_Plan), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_caseplan_ait_planactivity_Plan));
        this.SetRelatedEntities<ait_planactivity>(nameof (ait_ait_caseplan_ait_planactivity_Plan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_caseplan_ait_planactivity_Plan));
      }
    }

    [RelationshipSchemaName("ait_ait_caseplan_ait_referral_Plan")]
    public IEnumerable<ait_referral> ait_ait_caseplan_ait_referral_Plan
    {
      get
      {
        return this.GetRelatedEntities<ait_referral>(nameof (ait_ait_caseplan_ait_referral_Plan), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_caseplan_ait_referral_Plan));
        this.SetRelatedEntities<ait_referral>(nameof (ait_ait_caseplan_ait_referral_Plan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_caseplan_ait_referral_Plan));
      }
    }

    [RelationshipSchemaName("ait_ait_caseplan_ait_safetyplan")]
    public IEnumerable<ait_safetyplan> ait_ait_caseplan_ait_safetyplan
    {
      get
      {
        return this.GetRelatedEntities<ait_safetyplan>(nameof (ait_ait_caseplan_ait_safetyplan), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_caseplan_ait_safetyplan));
        this.SetRelatedEntities<ait_safetyplan>(nameof (ait_ait_caseplan_ait_safetyplan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_caseplan_ait_safetyplan));
      }
    }

    [RelationshipSchemaName("ait_ait_caseplan_appointment_Plan")]
    public IEnumerable<Appointment> ait_ait_caseplan_appointment_Plan
    {
      get
      {
        return this.GetRelatedEntities<Appointment>(nameof (ait_ait_caseplan_appointment_Plan), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_caseplan_appointment_Plan));
        this.SetRelatedEntities<Appointment>(nameof (ait_ait_caseplan_appointment_Plan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_caseplan_appointment_Plan));
      }
    }

    [RelationshipSchemaName("ait_ait_caseplan_email_Plan")]
    public IEnumerable<Email> ait_ait_caseplan_email_Plan
    {
      get
      {
        return this.GetRelatedEntities<Email>(nameof (ait_ait_caseplan_email_Plan), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_caseplan_email_Plan));
        this.SetRelatedEntities<Email>(nameof (ait_ait_caseplan_email_Plan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_caseplan_email_Plan));
      }
    }

    [RelationshipSchemaName("ait_ait_caseplan_phonecall_Plan")]
    public IEnumerable<PhoneCall> ait_ait_caseplan_phonecall_Plan
    {
      get
      {
        return this.GetRelatedEntities<PhoneCall>(nameof (ait_ait_caseplan_phonecall_Plan), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_caseplan_phonecall_Plan));
        this.SetRelatedEntities<PhoneCall>(nameof (ait_ait_caseplan_phonecall_Plan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_caseplan_phonecall_Plan));
      }
    }

    [RelationshipSchemaName("ait_ait_caseplan_task_Plan")]
    public IEnumerable<Task> ait_ait_caseplan_task_Plan
    {
      get => this.GetRelatedEntities<Task>(nameof (ait_ait_caseplan_task_Plan), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_caseplan_task_Plan));
        this.SetRelatedEntities<Task>(nameof (ait_ait_caseplan_task_Plan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_caseplan_task_Plan));
      }
    }

    [RelationshipSchemaName("ait_caseplan_ActivityParties")]
    public IEnumerable<ActivityParty> ait_caseplan_ActivityParties
    {
      get
      {
        return this.GetRelatedEntities<ActivityParty>(nameof (ait_caseplan_ActivityParties), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_caseplan_ActivityParties));
        this.SetRelatedEntities<ActivityParty>(nameof (ait_caseplan_ActivityParties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_caseplan_ActivityParties));
      }
    }

    [RelationshipSchemaName("ait_caseplan_ActivityPointers")]
    public IEnumerable<ActivityPointer> ait_caseplan_ActivityPointers
    {
      get
      {
        return this.GetRelatedEntities<ActivityPointer>(nameof (ait_caseplan_ActivityPointers), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_caseplan_ActivityPointers));
        this.SetRelatedEntities<ActivityPointer>(nameof (ait_caseplan_ActivityPointers), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_caseplan_ActivityPointers));
      }
    }

    [RelationshipSchemaName("ait_caseplan_ait_payment_plan")]
    public IEnumerable<ait_payment> ait_caseplan_ait_payment_plan
    {
      get
      {
        return this.GetRelatedEntities<ait_payment>(nameof (ait_caseplan_ait_payment_plan), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_caseplan_ait_payment_plan));
        this.SetRelatedEntities<ait_payment>(nameof (ait_caseplan_ait_payment_plan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_caseplan_ait_payment_plan));
      }
    }

    [RelationshipSchemaName("ait_caseplan_ait_servicerequest_Plan")]
    public IEnumerable<ait_servicerequest> ait_caseplan_ait_servicerequest_Plan
    {
      get
      {
        return this.GetRelatedEntities<ait_servicerequest>(nameof (ait_caseplan_ait_servicerequest_Plan), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_caseplan_ait_servicerequest_Plan));
        this.SetRelatedEntities<ait_servicerequest>(nameof (ait_caseplan_ait_servicerequest_Plan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_caseplan_ait_servicerequest_Plan));
      }
    }

    [RelationshipSchemaName("ait_caseplan_Annotations")]
    public IEnumerable<Annotation> ait_caseplan_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (ait_caseplan_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_caseplan_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (ait_caseplan_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_caseplan_Annotations));
      }
    }

    [RelationshipSchemaName("ait_caseplan_Appointments")]
    public IEnumerable<Appointment> ait_caseplan_Appointments
    {
      get
      {
        return this.GetRelatedEntities<Appointment>(nameof (ait_caseplan_Appointments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_caseplan_Appointments));
        this.SetRelatedEntities<Appointment>(nameof (ait_caseplan_Appointments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_caseplan_Appointments));
      }
    }

    [RelationshipSchemaName("ait_caseplan_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_caseplan_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_caseplan_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_caseplan_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_caseplan_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_caseplan_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_caseplan_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_caseplan_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_caseplan_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_caseplan_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_caseplan_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_caseplan_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_caseplan_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_caseplan_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_caseplan_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_caseplan_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_caseplan_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_caseplan_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_caseplan_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_caseplan_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_caseplan_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_caseplan_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_caseplan_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_caseplan_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_caseplan_Emails")]
    public IEnumerable<Email> ait_caseplan_Emails
    {
      get => this.GetRelatedEntities<Email>(nameof (ait_caseplan_Emails), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_caseplan_Emails));
        this.SetRelatedEntities<Email>(nameof (ait_caseplan_Emails), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_caseplan_Emails));
      }
    }

    [RelationshipSchemaName("ait_caseplan_Faxes")]
    public IEnumerable<Fax> ait_caseplan_Faxes
    {
      get => this.GetRelatedEntities<Fax>(nameof (ait_caseplan_Faxes), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_caseplan_Faxes));
        this.SetRelatedEntities<Fax>(nameof (ait_caseplan_Faxes), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_caseplan_Faxes));
      }
    }

    [RelationshipSchemaName("ait_caseplan_Letters")]
    public IEnumerable<Letter> ait_caseplan_Letters
    {
      get => this.GetRelatedEntities<Letter>(nameof (ait_caseplan_Letters), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_caseplan_Letters));
        this.SetRelatedEntities<Letter>(nameof (ait_caseplan_Letters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_caseplan_Letters));
      }
    }

    [RelationshipSchemaName("ait_caseplan_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_caseplan_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_caseplan_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_caseplan_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_caseplan_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_caseplan_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_caseplan_PhoneCalls")]
    public IEnumerable<PhoneCall> ait_caseplan_PhoneCalls
    {
      get
      {
        return this.GetRelatedEntities<PhoneCall>(nameof (ait_caseplan_PhoneCalls), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_caseplan_PhoneCalls));
        this.SetRelatedEntities<PhoneCall>(nameof (ait_caseplan_PhoneCalls), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_caseplan_PhoneCalls));
      }
    }

    [RelationshipSchemaName("ait_caseplan_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_caseplan_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_caseplan_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_caseplan_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_caseplan_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_caseplan_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_caseplan_ProcessSession")]
    public IEnumerable<ProcessSession> ait_caseplan_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_caseplan_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_caseplan_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_caseplan_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_caseplan_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_caseplan_RecurringAppointmentMasters")]
    public IEnumerable<RecurringAppointmentMaster> ait_caseplan_RecurringAppointmentMasters
    {
      get
      {
        return this.GetRelatedEntities<RecurringAppointmentMaster>(nameof (ait_caseplan_RecurringAppointmentMasters), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_caseplan_RecurringAppointmentMasters));
        this.SetRelatedEntities<RecurringAppointmentMaster>(nameof (ait_caseplan_RecurringAppointmentMasters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_caseplan_RecurringAppointmentMasters));
      }
    }

    [RelationshipSchemaName("ait_caseplan_SharePointDocumentLocations")]
    public IEnumerable<SharePointDocumentLocation> ait_caseplan_SharePointDocumentLocations
    {
      get
      {
        return this.GetRelatedEntities<SharePointDocumentLocation>(nameof (ait_caseplan_SharePointDocumentLocations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_caseplan_SharePointDocumentLocations));
        this.SetRelatedEntities<SharePointDocumentLocation>(nameof (ait_caseplan_SharePointDocumentLocations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_caseplan_SharePointDocumentLocations));
      }
    }

    [RelationshipSchemaName("ait_caseplan_SharePointDocuments")]
    public IEnumerable<SharePointDocument> ait_caseplan_SharePointDocuments
    {
      get
      {
        return this.GetRelatedEntities<SharePointDocument>(nameof (ait_caseplan_SharePointDocuments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_caseplan_SharePointDocuments));
        this.SetRelatedEntities<SharePointDocument>(nameof (ait_caseplan_SharePointDocuments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_caseplan_SharePointDocuments));
      }
    }

    [RelationshipSchemaName("ait_caseplan_SocialActivities")]
    public IEnumerable<SocialActivity> ait_caseplan_SocialActivities
    {
      get
      {
        return this.GetRelatedEntities<SocialActivity>(nameof (ait_caseplan_SocialActivities), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_caseplan_SocialActivities));
        this.SetRelatedEntities<SocialActivity>(nameof (ait_caseplan_SocialActivities), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_caseplan_SocialActivities));
      }
    }

    [RelationshipSchemaName("ait_caseplan_SyncErrors")]
    public IEnumerable<SyncError> ait_caseplan_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_caseplan_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_caseplan_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_caseplan_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_caseplan_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_caseplan_Tasks")]
    public IEnumerable<Task> ait_caseplan_Tasks
    {
      get => this.GetRelatedEntities<Task>(nameof (ait_caseplan_Tasks), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_caseplan_Tasks));
        this.SetRelatedEntities<Task>(nameof (ait_caseplan_Tasks), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_caseplan_Tasks));
      }
    }

    [RelationshipSchemaName("ait_caseplan_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_caseplan_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_caseplan_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_caseplan_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_caseplan_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_caseplan_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_individual")]
    [RelationshipSchemaName("ait_ait_clientprofile_ait_caseplan_Individual")]
    public ait_clientprofile ait_ait_clientprofile_ait_caseplan_Individual
    {
      get
      {
        return this.GetRelatedEntity<ait_clientprofile>(nameof (ait_ait_clientprofile_ait_caseplan_Individual), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_clientprofile_ait_caseplan_Individual));
        this.SetRelatedEntity<ait_clientprofile>(nameof (ait_ait_clientprofile_ait_caseplan_Individual), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_clientprofile_ait_caseplan_Individual));
      }
    }

    [AttributeLogicalName("ait_program")]
    [RelationshipSchemaName("ait_ait_program_ait_caseplan_Program")]
    public ait_program ait_ait_program_ait_caseplan_Program
    {
      get
      {
        return this.GetRelatedEntity<ait_program>(nameof (ait_ait_program_ait_caseplan_Program), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_program_ait_caseplan_Program));
        this.SetRelatedEntity<ait_program>(nameof (ait_ait_program_ait_caseplan_Program), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_program_ait_caseplan_Program));
      }
    }

    [AttributeLogicalName("ait_familygroup")]
    [RelationshipSchemaName("ait_familygroup_ait_caseplan_FamilyGroup")]
    public ait_familygroup ait_familygroup_ait_caseplan_FamilyGroup
    {
      get
      {
        return this.GetRelatedEntity<ait_familygroup>(nameof (ait_familygroup_ait_caseplan_FamilyGroup), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familygroup_ait_caseplan_FamilyGroup));
        this.SetRelatedEntity<ait_familygroup>(nameof (ait_familygroup_ait_caseplan_FamilyGroup), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familygroup_ait_caseplan_FamilyGroup));
      }
    }

    [AttributeLogicalName("ait_servicerequest")]
    [RelationshipSchemaName("ait_servicerequest_ait_caseplan_ServiceRequest")]
    public ait_servicerequest ait_servicerequest_ait_caseplan_ServiceRequest
    {
      get
      {
        return this.GetRelatedEntity<ait_servicerequest>(nameof (ait_servicerequest_ait_caseplan_ServiceRequest), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_ait_caseplan_ServiceRequest));
        this.SetRelatedEntity<ait_servicerequest>(nameof (ait_servicerequest_ait_caseplan_ServiceRequest), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_ait_caseplan_ServiceRequest));
      }
    }

    [AttributeLogicalName("ait_caseworker")]
    [RelationshipSchemaName("ait_systemuser_ait_caseplan_Caseworker")]
    public SystemUser ait_systemuser_ait_caseplan_Caseworker
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (ait_systemuser_ait_caseplan_Caseworker), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_systemuser_ait_caseplan_Caseworker));
        this.SetRelatedEntity<SystemUser>(nameof (ait_systemuser_ait_caseplan_Caseworker), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_systemuser_ait_caseplan_Caseworker));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_caseplan")]
    public BusinessUnit business_unit_ait_caseplan
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_caseplan), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_caseplan_createdby")]
    public SystemUser lk_ait_caseplan_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_caseplan_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_caseplan_createdonbehalfby")]
    public SystemUser lk_ait_caseplan_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_caseplan_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_caseplan_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_caseplan_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_caseplan_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_caseplan_modifiedby")]
    public SystemUser lk_ait_caseplan_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_caseplan_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_caseplan_modifiedonbehalfby")]
    public SystemUser lk_ait_caseplan_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_caseplan_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_caseplan_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_caseplan_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_caseplan_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_caseplan")]
    public Team team_ait_caseplan
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_caseplan), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_caseplan")]
    public SystemUser user_ait_caseplan
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_ait_caseplan), new EntityRole?());
    }

    public ait_caseplan(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_caseplanid"] = (object) base.Id;
            break;
          case "ait_caseplanid":
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
