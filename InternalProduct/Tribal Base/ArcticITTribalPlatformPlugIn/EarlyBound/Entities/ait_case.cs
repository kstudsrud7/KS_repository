// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_case
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_case")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_case : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_case";
    public const string EntitySchemaName = "ait_case";
    public const string PrimaryIdAttribute = "ait_caseid";
    public const string PrimaryNameAttribute = "ait_casename";

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

    [AttributeLogicalName("ait_caseid")]
    public Guid? ait_caseId
    {
      get => this.GetAttributeValue<Guid?>("ait_caseid");
      set
      {
        this.OnPropertyChanging(nameof (ait_caseId));
        this.SetAttributeValue("ait_caseid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_caseId));
      }
    }

    [AttributeLogicalName("ait_caseid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_caseId = new Guid?(value);
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

    [AttributeLogicalName("ait_client")]
    public EntityReference ait_Client
    {
      get => this.GetAttributeValue<EntityReference>("ait_client");
      set
      {
        this.OnPropertyChanging(nameof (ait_Client));
        this.SetAttributeValue("ait_client", (object) value);
        this.OnPropertyChanged(nameof (ait_Client));
      }
    }

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
    public ait_caseState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_caseState?((ait_caseState) Enum.ToObject(typeof (ait_caseState), attributeValue.Value)) : new ait_caseState?();
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

    [RelationshipSchemaName("ait_ait_case_ait_casenote_Case")]
    public IEnumerable<ait_casenote> ait_ait_case_ait_casenote_Case
    {
      get
      {
        return this.GetRelatedEntities<ait_casenote>(nameof (ait_ait_case_ait_casenote_Case), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_case_ait_casenote_Case));
        this.SetRelatedEntities<ait_casenote>(nameof (ait_ait_case_ait_casenote_Case), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_case_ait_casenote_Case));
      }
    }

    [RelationshipSchemaName("ait_ait_case_ait_incident_Case")]
    public IEnumerable<ait_incident> ait_ait_case_ait_incident_Case
    {
      get
      {
        return this.GetRelatedEntities<ait_incident>(nameof (ait_ait_case_ait_incident_Case), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_case_ait_incident_Case));
        this.SetRelatedEntities<ait_incident>(nameof (ait_ait_case_ait_incident_Case), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_case_ait_incident_Case));
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

    [RelationshipSchemaName("ait_ait_case_ait_safetyplan_Case")]
    public IEnumerable<ait_safetyplan> ait_ait_case_ait_safetyplan_Case
    {
      get
      {
        return this.GetRelatedEntities<ait_safetyplan>(nameof (ait_ait_case_ait_safetyplan_Case), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_case_ait_safetyplan_Case));
        this.SetRelatedEntities<ait_safetyplan>(nameof (ait_ait_case_ait_safetyplan_Case), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_case_ait_safetyplan_Case));
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

    [RelationshipSchemaName("ait_case_ActivityParties")]
    public IEnumerable<ActivityParty> ait_case_ActivityParties
    {
      get
      {
        return this.GetRelatedEntities<ActivityParty>(nameof (ait_case_ActivityParties), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_case_ActivityParties));
        this.SetRelatedEntities<ActivityParty>(nameof (ait_case_ActivityParties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_case_ActivityParties));
      }
    }

    [RelationshipSchemaName("ait_case_ActivityPointers")]
    public IEnumerable<ActivityPointer> ait_case_ActivityPointers
    {
      get
      {
        return this.GetRelatedEntities<ActivityPointer>(nameof (ait_case_ActivityPointers), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_case_ActivityPointers));
        this.SetRelatedEntities<ActivityPointer>(nameof (ait_case_ActivityPointers), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_case_ActivityPointers));
      }
    }

    [RelationshipSchemaName("ait_case_Annotations")]
    public IEnumerable<Annotation> ait_case_Annotations
    {
      get => this.GetRelatedEntities<Annotation>(nameof (ait_case_Annotations), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_case_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (ait_case_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_case_Annotations));
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

    [RelationshipSchemaName("ait_case_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_case_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_case_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_case_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_case_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_case_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_case_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_case_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_case_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_case_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_case_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_case_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_case_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_case_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_case_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_case_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_case_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_case_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_case_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_case_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_case_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_case_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_case_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_case_DuplicateMatchingRecord));
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

    [RelationshipSchemaName("ait_case_Faxes")]
    public IEnumerable<Fax> ait_case_Faxes
    {
      get => this.GetRelatedEntities<Fax>(nameof (ait_case_Faxes), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_case_Faxes));
        this.SetRelatedEntities<Fax>(nameof (ait_case_Faxes), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_case_Faxes));
      }
    }

    [RelationshipSchemaName("ait_case_Letters")]
    public IEnumerable<Letter> ait_case_Letters
    {
      get => this.GetRelatedEntities<Letter>(nameof (ait_case_Letters), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_case_Letters));
        this.SetRelatedEntities<Letter>(nameof (ait_case_Letters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_case_Letters));
      }
    }

    [RelationshipSchemaName("ait_case_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_case_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_case_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_case_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_case_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_case_MailboxTrackingFolders));
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

    [RelationshipSchemaName("ait_case_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_case_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_case_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_case_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_case_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_case_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_case_ProcessSession")]
    public IEnumerable<ProcessSession> ait_case_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_case_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_case_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_case_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_case_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_case_RecurringAppointmentMasters")]
    public IEnumerable<RecurringAppointmentMaster> ait_case_RecurringAppointmentMasters
    {
      get
      {
        return this.GetRelatedEntities<RecurringAppointmentMaster>(nameof (ait_case_RecurringAppointmentMasters), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_case_RecurringAppointmentMasters));
        this.SetRelatedEntities<RecurringAppointmentMaster>(nameof (ait_case_RecurringAppointmentMasters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_case_RecurringAppointmentMasters));
      }
    }

    [RelationshipSchemaName("ait_case_SharePointDocumentLocations")]
    public IEnumerable<SharePointDocumentLocation> ait_case_SharePointDocumentLocations
    {
      get
      {
        return this.GetRelatedEntities<SharePointDocumentLocation>(nameof (ait_case_SharePointDocumentLocations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_case_SharePointDocumentLocations));
        this.SetRelatedEntities<SharePointDocumentLocation>(nameof (ait_case_SharePointDocumentLocations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_case_SharePointDocumentLocations));
      }
    }

    [RelationshipSchemaName("ait_case_SharePointDocuments")]
    public IEnumerable<SharePointDocument> ait_case_SharePointDocuments
    {
      get
      {
        return this.GetRelatedEntities<SharePointDocument>(nameof (ait_case_SharePointDocuments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_case_SharePointDocuments));
        this.SetRelatedEntities<SharePointDocument>(nameof (ait_case_SharePointDocuments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_case_SharePointDocuments));
      }
    }

    [RelationshipSchemaName("ait_case_SocialActivities")]
    public IEnumerable<SocialActivity> ait_case_SocialActivities
    {
      get
      {
        return this.GetRelatedEntities<SocialActivity>(nameof (ait_case_SocialActivities), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_case_SocialActivities));
        this.SetRelatedEntities<SocialActivity>(nameof (ait_case_SocialActivities), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_case_SocialActivities));
      }
    }

    [RelationshipSchemaName("ait_case_SyncErrors")]
    public IEnumerable<SyncError> ait_case_SyncErrors
    {
      get => this.GetRelatedEntities<SyncError>(nameof (ait_case_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_case_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_case_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_case_SyncErrors));
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

    [RelationshipSchemaName("ait_case_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_case_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_case_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_case_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_case_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_case_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_client")]
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
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_case_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_case_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_case_createdonbehalfby));
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
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_case_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_case_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_case_modifiedonbehalfby));
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

    public ait_case(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_caseid"] = (object) base.Id;
            break;
          case "ait_caseid":
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
