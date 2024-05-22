// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EarlyBound.ait_caseplan
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_caseplan")]
  [GeneratedCode("CrmSvcUtil", "9.0.0.9154")]
  public class ait_caseplan : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_caseplan";
    public const int EntityTypeCode = 10644;

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
        this.OnPropertyChanged(nameof (ait_caseplanId));
      }
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

    [AttributeLogicalName("ait_casestatusname")]
    public object ait_casestatusName => this.GetAttributeValue<object>("ait_casestatusname");

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

    [AttributeLogicalName("ait_caseworkername")]
    public string ait_CaseworkerName => this.GetAttributeValue<string>("ait_caseworkername");

    [AttributeLogicalName("ait_caseworkeryominame")]
    public string ait_CaseworkerYomiName
    {
      get => this.GetAttributeValue<string>("ait_caseworkeryominame");
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

    [AttributeLogicalName("ait_crisisrankingname")]
    public object ait_crisisrankingName => this.GetAttributeValue<object>("ait_crisisrankingname");

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

    [AttributeLogicalName("ait_crisistypename")]
    public object ait_crisistypeName => this.GetAttributeValue<object>("ait_crisistypename");

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

    [AttributeLogicalName("ait_familyplanid")]
    public EntityReference ait_FamilyPlanId
    {
      get => this.GetAttributeValue<EntityReference>("ait_familyplanid");
      set
      {
        this.OnPropertyChanging(nameof (ait_FamilyPlanId));
        this.SetAttributeValue("ait_familyplanid", (object) value);
        this.OnPropertyChanged(nameof (ait_FamilyPlanId));
      }
    }

    [AttributeLogicalName("ait_familyplanidname")]
    public string ait_FamilyPlanIdName => this.GetAttributeValue<string>("ait_familyplanidname");

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

    [AttributeLogicalName("ait_programname")]
    public string ait_ProgramName => this.GetAttributeValue<string>("ait_programname");

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

    [AttributeLogicalName("ait_servicerequestname")]
    public string ait_ServiceRequestName
    {
      get => this.GetAttributeValue<string>("ait_servicerequestname");
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
    public Ait_caseplanState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new Ait_caseplanState?((Ait_caseplanState) Enum.ToObject(typeof (Ait_caseplanState), attributeValue.Value)) : new Ait_caseplanState?();
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

    [RelationshipSchemaName("ait_ait_caseplan_ait_case_Plan")]
    public IEnumerable<ait_case> ait_ait_caseplan_ait_case_Plan
    {
      get
      {
        return this.GetRelatedEntities<ait_case>(nameof (ait_ait_caseplan_ait_case_Plan), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_caseplan_ait_case_Plan));
        this.SetRelatedEntities<ait_case>(nameof (ait_ait_caseplan_ait_case_Plan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_caseplan_ait_case_Plan));
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

    [RelationshipSchemaName("ait_ait_caseplan_ait_incidents_FamilyPlan")]
    public IEnumerable<ait_incidents> ait_ait_caseplan_ait_incidents_FamilyPlan
    {
      get
      {
        return this.GetRelatedEntities<ait_incidents>(nameof (ait_ait_caseplan_ait_incidents_FamilyPlan), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_caseplan_ait_incidents_FamilyPlan));
        this.SetRelatedEntities<ait_incidents>(nameof (ait_ait_caseplan_ait_incidents_FamilyPlan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_caseplan_ait_incidents_FamilyPlan));
      }
    }

    [RelationshipSchemaName("ait_ait_caseplan_ait_placement_Plan")]
    public IEnumerable<ait_placement> ait_ait_caseplan_ait_placement_Plan
    {
      get
      {
        return this.GetRelatedEntities<ait_placement>(nameof (ait_ait_caseplan_ait_placement_Plan), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_caseplan_ait_placement_Plan));
        this.SetRelatedEntities<ait_placement>(nameof (ait_ait_caseplan_ait_placement_Plan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_caseplan_ait_placement_Plan));
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

    [RelationshipSchemaName("ait_caseplan_ait_casenotefamilywellness_FamilyPlan")]
    public IEnumerable<ait_casenotefamilywellness> ait_caseplan_ait_casenotefamilywellness_FamilyPlan
    {
      get
      {
        return this.GetRelatedEntities<ait_casenotefamilywellness>(nameof (ait_caseplan_ait_casenotefamilywellness_FamilyPlan), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_caseplan_ait_casenotefamilywellness_FamilyPlan));
        this.SetRelatedEntities<ait_casenotefamilywellness>(nameof (ait_caseplan_ait_casenotefamilywellness_FamilyPlan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_caseplan_ait_casenotefamilywellness_FamilyPlan));
      }
    }

    [RelationshipSchemaName("ait_caseplan_ait_groupactivityregistration_FamilyPlan")]
    public IEnumerable<ait_groupactivityregistration> ait_caseplan_ait_groupactivityregistration_FamilyPlan
    {
      get
      {
        return this.GetRelatedEntities<ait_groupactivityregistration>(nameof (ait_caseplan_ait_groupactivityregistration_FamilyPlan), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_caseplan_ait_groupactivityregistration_FamilyPlan));
        this.SetRelatedEntities<ait_groupactivityregistration>(nameof (ait_caseplan_ait_groupactivityregistration_FamilyPlan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_caseplan_ait_groupactivityregistration_FamilyPlan));
      }
    }

    [RelationshipSchemaName("ait_caseplan_ait_meetingattendee_FamilyPlan")]
    public IEnumerable<ait_meetingattendee> ait_caseplan_ait_meetingattendee_FamilyPlan
    {
      get
      {
        return this.GetRelatedEntities<ait_meetingattendee>(nameof (ait_caseplan_ait_meetingattendee_FamilyPlan), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_caseplan_ait_meetingattendee_FamilyPlan));
        this.SetRelatedEntities<ait_meetingattendee>(nameof (ait_caseplan_ait_meetingattendee_FamilyPlan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_caseplan_ait_meetingattendee_FamilyPlan));
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

    [AttributeLogicalName("ait_familyplanid")]
    [RelationshipSchemaName("ait_ait_meetingattendee_ait_caseplan")]
    public ait_meetingattendee ait_ait_meetingattendee_ait_caseplan
    {
      get
      {
        return this.GetRelatedEntity<ait_meetingattendee>(nameof (ait_ait_meetingattendee_ait_caseplan), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_meetingattendee_ait_caseplan));
        this.SetRelatedEntity<ait_meetingattendee>(nameof (ait_ait_meetingattendee_ait_caseplan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_meetingattendee_ait_caseplan));
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
  }
}
