// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EarlyBound.ait_case
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_case")]
  [GeneratedCode("CrmSvcUtil", "9.0.0.9154")]
  public class ait_case : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_case";
    public const int EntityTypeCode = 10707;

    public ait_case()
      : base(nameof (ait_case))
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

    [AttributeLogicalName("ait_applicant")]
    public string ait_Applicant
    {
      get => this.GetAttributeValue<string>("ait_applicant");
      set
      {
        this.OnPropertyChanging(nameof (ait_Applicant));
        this.SetAttributeValue("ait_applicant", (object) value);
        this.OnPropertyChanged(nameof (ait_Applicant));
      }
    }

    [AttributeLogicalName("ait_applicantrelationshiptoclient")]
    public OptionSetValue ait_ApplicantRelationshiptoClient
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_applicantrelationshiptoclient");
      set
      {
        this.OnPropertyChanging(nameof (ait_ApplicantRelationshiptoClient));
        this.SetAttributeValue("ait_applicantrelationshiptoclient", (object) value);
        this.OnPropertyChanged(nameof (ait_ApplicantRelationshiptoClient));
      }
    }

    [AttributeLogicalName("ait_applicantrelationshiptoclientname")]
    public object ait_applicantrelationshiptoclientName
    {
      get => this.GetAttributeValue<object>("ait_applicantrelationshiptoclientname");
    }

    [AttributeLogicalName("ait_approvaldate")]
    public DateTime? ait_ApprovalDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_approvaldate");
      set
      {
        this.OnPropertyChanging(nameof (ait_ApprovalDate));
        this.SetAttributeValue("ait_approvaldate", (object) value);
        this.OnPropertyChanged(nameof (ait_ApprovalDate));
      }
    }

    [AttributeLogicalName("ait_approvedby")]
    public EntityReference ait_ApprovedBy
    {
      get => this.GetAttributeValue<EntityReference>("ait_approvedby");
      set
      {
        this.OnPropertyChanging(nameof (ait_ApprovedBy));
        this.SetAttributeValue("ait_approvedby", (object) value);
        this.OnPropertyChanged(nameof (ait_ApprovedBy));
      }
    }

    [AttributeLogicalName("ait_approvedbyname")]
    public string ait_ApprovedByName => this.GetAttributeValue<string>("ait_approvedbyname");

    [AttributeLogicalName("ait_approvedbyyominame")]
    public string ait_ApprovedByYomiName
    {
      get => this.GetAttributeValue<string>("ait_approvedbyyominame");
    }

    [AttributeLogicalName("ait_casegmaid")]
    public EntityReference ait_CaseGMAId
    {
      get => this.GetAttributeValue<EntityReference>("ait_casegmaid");
      set
      {
        this.OnPropertyChanging(nameof (ait_CaseGMAId));
        this.SetAttributeValue("ait_casegmaid", (object) value);
        this.OnPropertyChanged(nameof (ait_CaseGMAId));
      }
    }

    [AttributeLogicalName("ait_casegmaidname")]
    public string ait_CaseGMAIdName => this.GetAttributeValue<string>("ait_casegmaidname");

    [AttributeLogicalName("ait_caseid")]
    public Guid? ait_caseId
    {
      get => this.GetAttributeValue<Guid?>("ait_caseid");
      set
      {
        this.OnPropertyChanging(nameof (ait_caseId));
        this.SetAttributeValue("ait_caseid", (object) value);
        this.OnPropertyChanged(nameof (ait_caseId));
      }
    }

    [AttributeLogicalName("ait_casename")]
    public string ait_casename
    {
      get => this.GetAttributeValue<string>(nameof (ait_casename));
      set
      {
        this.OnPropertyChanging(nameof (ait_casename));
        this.SetAttributeValue(nameof (ait_casename), (object) value);
        this.OnPropertyChanged(nameof (ait_casename));
      }
    }

    [AttributeLogicalName("ait_casenumber")]
    public string ait_casenumber
    {
      get => this.GetAttributeValue<string>(nameof (ait_casenumber));
      set
      {
        this.OnPropertyChanging(nameof (ait_casenumber));
        this.SetAttributeValue(nameof (ait_casenumber), (object) value);
        this.OnPropertyChanged(nameof (ait_casenumber));
      }
    }

    [AttributeLogicalName("ait_caseplan")]
    public EntityReference ait_caseplan
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_caseplan));
      set
      {
        this.OnPropertyChanging(nameof (ait_caseplan));
        this.SetAttributeValue(nameof (ait_caseplan), (object) value);
        this.OnPropertyChanged(nameof (ait_caseplan));
      }
    }

    [AttributeLogicalName("ait_caseplanname")]
    public string ait_caseplanName => this.GetAttributeValue<string>("ait_caseplanname");

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

    [AttributeLogicalName("ait_casetype")]
    public OptionSetValue ait_CaseType
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_casetype");
      set
      {
        this.OnPropertyChanging(nameof (ait_CaseType));
        this.SetAttributeValue("ait_casetype", (object) value);
        this.OnPropertyChanged(nameof (ait_CaseType));
      }
    }

    [AttributeLogicalName("ait_casetypename")]
    public object ait_casetypeName => this.GetAttributeValue<object>("ait_casetypename");

    [AttributeLogicalName("ait_closeddate")]
    public DateTime? ait_ClosedDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_closeddate");
      set
      {
        this.OnPropertyChanging(nameof (ait_ClosedDate));
        this.SetAttributeValue("ait_closeddate", (object) value);
        this.OnPropertyChanged(nameof (ait_ClosedDate));
      }
    }

    [AttributeLogicalName("ait_individual")]
    public EntityReference ait_individual
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_individual));
      set
      {
        this.OnPropertyChanging(nameof (ait_individual));
        this.SetAttributeValue(nameof (ait_individual), (object) value);
        this.OnPropertyChanged(nameof (ait_individual));
      }
    }

    [AttributeLogicalName("ait_individualname")]
    public string ait_individualName => this.GetAttributeValue<string>("ait_individualname");

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

    [AttributeLogicalName("ait_rationale")]
    public string ait_Rationale
    {
      get => this.GetAttributeValue<string>("ait_rationale");
      set
      {
        this.OnPropertyChanging(nameof (ait_Rationale));
        this.SetAttributeValue("ait_rationale", (object) value);
        this.OnPropertyChanged(nameof (ait_Rationale));
      }
    }

    [AttributeLogicalName("ait_relatedcourtcase")]
    public string ait_RelatedCourtCase
    {
      get => this.GetAttributeValue<string>("ait_relatedcourtcase");
      set
      {
        this.OnPropertyChanging(nameof (ait_RelatedCourtCase));
        this.SetAttributeValue("ait_relatedcourtcase", (object) value);
        this.OnPropertyChanged(nameof (ait_RelatedCourtCase));
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

    [AttributeLogicalName("ait_servicerequestname")]
    public string ait_ServiceRequestName
    {
      get => this.GetAttributeValue<string>("ait_servicerequestname");
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

    [AttributeLogicalName("processid")]
    public Guid? processid
    {
      get => this.GetAttributeValue<Guid?>(nameof (processid));
      set
      {
        this.OnPropertyChanging(nameof (processid));
        this.SetAttributeValue(nameof (processid), (object) value);
        this.OnPropertyChanged(nameof (processid));
      }
    }

    [AttributeLogicalName("stageid")]
    public Guid? stageid
    {
      get => this.GetAttributeValue<Guid?>(nameof (stageid));
      set
      {
        this.OnPropertyChanging(nameof (stageid));
        this.SetAttributeValue(nameof (stageid), (object) value);
        this.OnPropertyChanged(nameof (stageid));
      }
    }

    [AttributeLogicalName("statecode")]
    public Ait_caseState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new Ait_caseState?((Ait_caseState) Enum.ToObject(typeof (Ait_caseState), attributeValue.Value)) : new Ait_caseState?();
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

    [AttributeLogicalName("traversedpath")]
    public string traversedpath
    {
      get => this.GetAttributeValue<string>(nameof (traversedpath));
      set
      {
        this.OnPropertyChanging(nameof (traversedpath));
        this.SetAttributeValue(nameof (traversedpath), (object) value);
        this.OnPropertyChanged(nameof (traversedpath));
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

    [RelationshipSchemaName("ait_ait_case_ait_assessment_Case")]
    public IEnumerable<ait_assessment> ait_ait_case_ait_assessment_Case
    {
      get
      {
        return this.GetRelatedEntities<ait_assessment>(nameof (ait_ait_case_ait_assessment_Case), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_case_ait_assessment_Case));
        this.SetRelatedEntities<ait_assessment>(nameof (ait_ait_case_ait_assessment_Case), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_case_ait_assessment_Case));
      }
    }

    [RelationshipSchemaName("ait_ait_case_ait_incidents_Case")]
    public IEnumerable<ait_incidents> ait_ait_case_ait_incidents_Case
    {
      get
      {
        return this.GetRelatedEntities<ait_incidents>(nameof (ait_ait_case_ait_incidents_Case), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_case_ait_incidents_Case));
        this.SetRelatedEntities<ait_incidents>(nameof (ait_ait_case_ait_incidents_Case), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_case_ait_incidents_Case));
      }
    }

    [RelationshipSchemaName("ait_ait_case_ait_placement_Case")]
    public IEnumerable<ait_placement> ait_ait_case_ait_placement_Case
    {
      get
      {
        return this.GetRelatedEntities<ait_placement>(nameof (ait_ait_case_ait_placement_Case), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_case_ait_placement_Case));
        this.SetRelatedEntities<ait_placement>(nameof (ait_ait_case_ait_placement_Case), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_case_ait_placement_Case));
      }
    }

    [RelationshipSchemaName("ait_ait_case_ait_planactivity_Case")]
    public IEnumerable<ait_planactivity> ait_ait_case_ait_planactivity_Case
    {
      get
      {
        return this.GetRelatedEntities<ait_planactivity>(nameof (ait_ait_case_ait_planactivity_Case), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_case_ait_planactivity_Case));
        this.SetRelatedEntities<ait_planactivity>(nameof (ait_ait_case_ait_planactivity_Case), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_case_ait_planactivity_Case));
      }
    }

    [RelationshipSchemaName("ait_ait_case_ait_referral_Case")]
    public IEnumerable<ait_referral> ait_ait_case_ait_referral_Case
    {
      get
      {
        return this.GetRelatedEntities<ait_referral>(nameof (ait_ait_case_ait_referral_Case), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_case_ait_referral_Case));
        this.SetRelatedEntities<ait_referral>(nameof (ait_ait_case_ait_referral_Case), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_case_ait_referral_Case));
      }
    }

    [RelationshipSchemaName("ait_ait_case_ait_servicerequest_Case")]
    public IEnumerable<ait_servicerequest> ait_ait_case_ait_servicerequest_Case
    {
      get
      {
        return this.GetRelatedEntities<ait_servicerequest>(nameof (ait_ait_case_ait_servicerequest_Case), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_case_ait_servicerequest_Case));
        this.SetRelatedEntities<ait_servicerequest>(nameof (ait_ait_case_ait_servicerequest_Case), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_case_ait_servicerequest_Case));
      }
    }

    [RelationshipSchemaName("ait_case_ait_casenotefamilywellness_Case")]
    public IEnumerable<ait_casenotefamilywellness> ait_case_ait_casenotefamilywellness_Case
    {
      get
      {
        return this.GetRelatedEntities<ait_casenotefamilywellness>(nameof (ait_case_ait_casenotefamilywellness_Case), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_case_ait_casenotefamilywellness_Case));
        this.SetRelatedEntities<ait_casenotefamilywellness>(nameof (ait_case_ait_casenotefamilywellness_Case), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_case_ait_casenotefamilywellness_Case));
      }
    }

    [RelationshipSchemaName("ait_case_ait_groupactivityregistration_Case")]
    public IEnumerable<ait_groupactivityregistration> ait_case_ait_groupactivityregistration_Case
    {
      get
      {
        return this.GetRelatedEntities<ait_groupactivityregistration>(nameof (ait_case_ait_groupactivityregistration_Case), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_case_ait_groupactivityregistration_Case));
        this.SetRelatedEntities<ait_groupactivityregistration>(nameof (ait_case_ait_groupactivityregistration_Case), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_case_ait_groupactivityregistration_Case));
      }
    }

    [RelationshipSchemaName("ait_case_ait_meetingattendee_Case")]
    public IEnumerable<ait_meetingattendee> ait_case_ait_meetingattendee_Case
    {
      get
      {
        return this.GetRelatedEntities<ait_meetingattendee>(nameof (ait_case_ait_meetingattendee_Case), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_case_ait_meetingattendee_Case));
        this.SetRelatedEntities<ait_meetingattendee>(nameof (ait_case_ait_meetingattendee_Case), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_case_ait_meetingattendee_Case));
      }
    }

    [RelationshipSchemaName("ait_case_Appointments")]
    public IEnumerable<Appointment> ait_case_Appointments
    {
      get
      {
        return this.GetRelatedEntities<Appointment>(nameof (ait_case_Appointments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_case_Appointments));
        this.SetRelatedEntities<Appointment>(nameof (ait_case_Appointments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_case_Appointments));
      }
    }

    [RelationshipSchemaName("ait_case_Emails")]
    public IEnumerable<Email> ait_case_Emails
    {
      get => this.GetRelatedEntities<Email>(nameof (ait_case_Emails), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_case_Emails));
        this.SetRelatedEntities<Email>(nameof (ait_case_Emails), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_case_Emails));
      }
    }

    [RelationshipSchemaName("ait_case_PhoneCalls")]
    public IEnumerable<PhoneCall> ait_case_PhoneCalls
    {
      get => this.GetRelatedEntities<PhoneCall>(nameof (ait_case_PhoneCalls), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_case_PhoneCalls));
        this.SetRelatedEntities<PhoneCall>(nameof (ait_case_PhoneCalls), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_case_PhoneCalls));
      }
    }

    [RelationshipSchemaName("ait_case_Tasks")]
    public IEnumerable<Task> ait_case_Tasks
    {
      get => this.GetRelatedEntities<Task>(nameof (ait_case_Tasks), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_case_Tasks));
        this.SetRelatedEntities<Task>(nameof (ait_case_Tasks), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_case_Tasks));
      }
    }

    [AttributeLogicalName("ait_caseplan")]
    [RelationshipSchemaName("ait_ait_caseplan_ait_case_Plan")]
    public TPFamilyWellness.EarlyBound.ait_caseplan ait_ait_caseplan_ait_case_Plan
    {
      get
      {
        return this.GetRelatedEntity<TPFamilyWellness.EarlyBound.ait_caseplan>(nameof (ait_ait_caseplan_ait_case_Plan), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_caseplan_ait_case_Plan));
        this.SetRelatedEntity<TPFamilyWellness.EarlyBound.ait_caseplan>(nameof (ait_ait_caseplan_ait_case_Plan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_caseplan_ait_case_Plan));
      }
    }

    [AttributeLogicalName("ait_individual")]
    [RelationshipSchemaName("ait_ait_clientprofile_ait_case_Client")]
    public ait_clientprofile ait_ait_clientprofile_ait_case_Client
    {
      get
      {
        return this.GetRelatedEntity<ait_clientprofile>(nameof (ait_ait_clientprofile_ait_case_Client), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_clientprofile_ait_case_Client));
        this.SetRelatedEntity<ait_clientprofile>(nameof (ait_ait_clientprofile_ait_case_Client), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_clientprofile_ait_case_Client));
      }
    }

    [AttributeLogicalName("ait_program")]
    [RelationshipSchemaName("ait_ait_program_ait_case_Program")]
    public ait_program ait_ait_program_ait_case_Program
    {
      get
      {
        return this.GetRelatedEntity<ait_program>(nameof (ait_ait_program_ait_case_Program), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_program_ait_case_Program));
        this.SetRelatedEntity<ait_program>(nameof (ait_ait_program_ait_case_Program), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_program_ait_case_Program));
      }
    }

    [AttributeLogicalName("ait_servicerequest")]
    [RelationshipSchemaName("ait_ait_servicerequest_ait_case_ServiceRequest")]
    public ait_servicerequest ait_ait_servicerequest_ait_case_ServiceRequest
    {
      get
      {
        return this.GetRelatedEntity<ait_servicerequest>(nameof (ait_ait_servicerequest_ait_case_ServiceRequest), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_servicerequest_ait_case_ServiceRequest));
        this.SetRelatedEntity<ait_servicerequest>(nameof (ait_ait_servicerequest_ait_case_ServiceRequest), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_servicerequest_ait_case_ServiceRequest));
      }
    }

    [AttributeLogicalName("ait_casegmaid")]
    [RelationshipSchemaName("ait_meetingattendee_ait_cases")]
    public ait_meetingattendee ait_meetingattendee_ait_cases
    {
      get
      {
        return this.GetRelatedEntity<ait_meetingattendee>(nameof (ait_meetingattendee_ait_cases), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_meetingattendee_ait_cases));
        this.SetRelatedEntity<ait_meetingattendee>(nameof (ait_meetingattendee_ait_cases), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_meetingattendee_ait_cases));
      }
    }

    [AttributeLogicalName("ait_approvedby")]
    [RelationshipSchemaName("ait_systemuser_ait_case_ApprovedBy")]
    public SystemUser ait_systemuser_ait_case_ApprovedBy
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (ait_systemuser_ait_case_ApprovedBy), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_systemuser_ait_case_ApprovedBy));
        this.SetRelatedEntity<SystemUser>(nameof (ait_systemuser_ait_case_ApprovedBy), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_systemuser_ait_case_ApprovedBy));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_case")]
    public BusinessUnit business_unit_ait_case
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_case), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_case_createdby")]
    public SystemUser lk_ait_case_createdby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_ait_case_createdby), new EntityRole?());
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_case_createdonbehalfby")]
    public SystemUser lk_ait_case_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_case_createdonbehalfby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_case_modifiedby")]
    public SystemUser lk_ait_case_modifiedby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_ait_case_modifiedby), new EntityRole?());
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_case_modifiedonbehalfby")]
    public SystemUser lk_ait_case_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_case_modifiedonbehalfby), new EntityRole?());
      }
    }

    [AttributeLogicalName("stageid")]
    [RelationshipSchemaName("processstage_ait_case")]
    public ProcessStage processstage_ait_case
    {
      get => this.GetRelatedEntity<ProcessStage>(nameof (processstage_ait_case), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (processstage_ait_case));
        this.SetRelatedEntity<ProcessStage>(nameof (processstage_ait_case), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (processstage_ait_case));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_case")]
    public Team team_ait_case
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_case), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_case")]
    public SystemUser user_ait_case
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_ait_case), new EntityRole?());
    }
  }
}
