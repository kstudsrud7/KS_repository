// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_icwanotice
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_icwanotice")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_icwanotice : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_icwanotice";
    public const string EntitySchemaName = "ait_icwanotice";
    public const string PrimaryIdAttribute = "ait_icwanoticeid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_icwanotice()
      : base(nameof (ait_icwanotice))
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

    [AttributeLogicalName("ait_adoption")]
    public OptionSetValue ait_Adoption
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_adoption");
      set
      {
        this.OnPropertyChanging(nameof (ait_Adoption));
        this.SetAttributeValue("ait_adoption", (object) value);
        this.OnPropertyChanged(nameof (ait_Adoption));
      }
    }

    [AttributeLogicalName("ait_biaservicesprovided")]
    public string ait_BIAServicesProvided
    {
      get => this.GetAttributeValue<string>("ait_biaservicesprovided");
      set
      {
        this.OnPropertyChanging(nameof (ait_BIAServicesProvided));
        this.SetAttributeValue("ait_biaservicesprovided", (object) value);
        this.OnPropertyChanged(nameof (ait_BIAServicesProvided));
      }
    }

    [AttributeLogicalName("ait_biologicalparentofamericanindianancestry")]
    public OptionSetValue ait_BiologicalParentofAmericanIndianAncestry
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_biologicalparentofamericanindianancestry");
      set
      {
        this.OnPropertyChanging(nameof (ait_BiologicalParentofAmericanIndianAncestry));
        this.SetAttributeValue("ait_biologicalparentofamericanindianancestry", (object) value);
        this.OnPropertyChanged(nameof (ait_BiologicalParentofAmericanIndianAncestry));
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

    [AttributeLogicalName("ait_caseworkerreviewcomments")]
    public string ait_CaseworkerReviewComments
    {
      get => this.GetAttributeValue<string>("ait_caseworkerreviewcomments");
      set
      {
        this.OnPropertyChanging(nameof (ait_CaseworkerReviewComments));
        this.SetAttributeValue("ait_caseworkerreviewcomments", (object) value);
        this.OnPropertyChanged(nameof (ait_CaseworkerReviewComments));
      }
    }

    [AttributeLogicalName("ait_childclientprofile")]
    public EntityReference ait_ChildClientProfile
    {
      get => this.GetAttributeValue<EntityReference>("ait_childclientprofile");
      set
      {
        this.OnPropertyChanging(nameof (ait_ChildClientProfile));
        this.SetAttributeValue("ait_childclientprofile", (object) value);
        this.OnPropertyChanged(nameof (ait_ChildClientProfile));
      }
    }

    [AttributeLogicalName("ait_childparentsadopted")]
    public OptionSetValue ait_ChildParentsAdopted
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_childparentsadopted");
      set
      {
        this.OnPropertyChanging(nameof (ait_ChildParentsAdopted));
        this.SetAttributeValue("ait_childparentsadopted", (object) value);
        this.OnPropertyChanged(nameof (ait_ChildParentsAdopted));
      }
    }

    [AttributeLogicalName("ait_courtcasecounty")]
    public string ait_CourtCaseCounty
    {
      get => this.GetAttributeValue<string>("ait_courtcasecounty");
      set
      {
        this.OnPropertyChanging(nameof (ait_CourtCaseCounty));
        this.SetAttributeValue("ait_courtcasecounty", (object) value);
        this.OnPropertyChanged(nameof (ait_CourtCaseCounty));
      }
    }

    [AttributeLogicalName("ait_courtcaseid")]
    public string ait_CourtCaseID
    {
      get => this.GetAttributeValue<string>("ait_courtcaseid");
      set
      {
        this.OnPropertyChanging(nameof (ait_CourtCaseID));
        this.SetAttributeValue("ait_courtcaseid", (object) value);
        this.OnPropertyChanged(nameof (ait_CourtCaseID));
      }
    }

    [AttributeLogicalName("ait_courtcasestate")]
    public string ait_CourtCaseState
    {
      get => this.GetAttributeValue<string>("ait_courtcasestate");
      set
      {
        this.OnPropertyChanging(nameof (ait_CourtCaseState));
        this.SetAttributeValue("ait_courtcasestate", (object) value);
        this.OnPropertyChanged(nameof (ait_CourtCaseState));
      }
    }

    [AttributeLogicalName("ait_datereceived")]
    public DateTime? ait_DateReceived
    {
      get => this.GetAttributeValue<DateTime?>("ait_datereceived");
      set
      {
        this.OnPropertyChanging(nameof (ait_DateReceived));
        this.SetAttributeValue("ait_datereceived", (object) value);
        this.OnPropertyChanged(nameof (ait_DateReceived));
      }
    }

    [AttributeLogicalName("ait_declinedate")]
    public DateTime? ait_DeclineDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_declinedate");
      set
      {
        this.OnPropertyChanging(nameof (ait_DeclineDate));
        this.SetAttributeValue("ait_declinedate", (object) value);
        this.OnPropertyChanged(nameof (ait_DeclineDate));
      }
    }

    [AttributeLogicalName("ait_declinereason")]
    public string ait_DeclineReason
    {
      get => this.GetAttributeValue<string>("ait_declinereason");
      set
      {
        this.OnPropertyChanging(nameof (ait_DeclineReason));
        this.SetAttributeValue("ait_declinereason", (object) value);
        this.OnPropertyChanged(nameof (ait_DeclineReason));
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

    [AttributeLogicalName("ait_designatedagent")]
    public EntityReference ait_DesignatedAgent
    {
      get => this.GetAttributeValue<EntityReference>("ait_designatedagent");
      set
      {
        this.OnPropertyChanging(nameof (ait_DesignatedAgent));
        this.SetAttributeValue("ait_designatedagent", (object) value);
        this.OnPropertyChanged(nameof (ait_DesignatedAgent));
      }
    }

    [AttributeLogicalName("ait_didrequesternotifyallapplicabletribes")]
    public OptionSetValue ait_DidRequesterNotifyAllApplicableTribes
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_didrequesternotifyallapplicabletribes");
      set
      {
        this.OnPropertyChanging(nameof (ait_DidRequesterNotifyAllApplicableTribes));
        this.SetAttributeValue("ait_didrequesternotifyallapplicabletribes", (object) value);
        this.OnPropertyChanged(nameof (ait_DidRequesterNotifyAllApplicableTribes));
      }
    }

    [AttributeLogicalName("ait_documentsattached")]
    public OptionSetValue ait_DocumentsAttached
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_documentsattached");
      set
      {
        this.OnPropertyChanging(nameof (ait_DocumentsAttached));
        this.SetAttributeValue("ait_documentsattached", (object) value);
        this.OnPropertyChanged(nameof (ait_DocumentsAttached));
      }
    }

    [AttributeLogicalName("ait_domesticviolenceinvolved")]
    public bool? ait_DomesticViolenceInvolved
    {
      get => this.GetAttributeValue<bool?>("ait_domesticviolenceinvolved");
      set
      {
        this.OnPropertyChanging(nameof (ait_DomesticViolenceInvolved));
        this.SetAttributeValue("ait_domesticviolenceinvolved", (object) value);
        this.OnPropertyChanged(nameof (ait_DomesticViolenceInvolved));
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

    [AttributeLogicalName("ait_enrollmentreviewcomments")]
    public string ait_EnrollmentReviewComments
    {
      get => this.GetAttributeValue<string>("ait_enrollmentreviewcomments");
      set
      {
        this.OnPropertyChanging(nameof (ait_EnrollmentReviewComments));
        this.SetAttributeValue("ait_enrollmentreviewcomments", (object) value);
        this.OnPropertyChanged(nameof (ait_EnrollmentReviewComments));
      }
    }

    [AttributeLogicalName("ait_enrollmentreviewer")]
    public EntityReference ait_EnrollmentReviewer
    {
      get => this.GetAttributeValue<EntityReference>("ait_enrollmentreviewer");
      set
      {
        this.OnPropertyChanging(nameof (ait_EnrollmentReviewer));
        this.SetAttributeValue("ait_enrollmentreviewer", (object) value);
        this.OnPropertyChanged(nameof (ait_EnrollmentReviewer));
      }
    }

    [AttributeLogicalName("ait_enrollmentstatus")]
    public OptionSetValue ait_EnrollmentStatus
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_enrollmentstatus");
      set
      {
        this.OnPropertyChanging(nameof (ait_EnrollmentStatus));
        this.SetAttributeValue("ait_enrollmentstatus", (object) value);
        this.OnPropertyChanged(nameof (ait_EnrollmentStatus));
      }
    }

    [AttributeLogicalName("ait_enrollmentstatusdate")]
    public DateTime? ait_EnrollmentStatusDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_enrollmentstatusdate");
      set
      {
        this.OnPropertyChanging(nameof (ait_EnrollmentStatusDate));
        this.SetAttributeValue("ait_enrollmentstatusdate", (object) value);
        this.OnPropertyChanged(nameof (ait_EnrollmentStatusDate));
      }
    }

    [AttributeLogicalName("ait_evidenceofnative")]
    public OptionSetValue ait_EvidenceofNative
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_evidenceofnative");
      set
      {
        this.OnPropertyChanging(nameof (ait_EvidenceofNative));
        this.SetAttributeValue("ait_evidenceofnative", (object) value);
        this.OnPropertyChanged(nameof (ait_EvidenceofNative));
      }
    }

    [AttributeLogicalName("ait_familymemberancestrydetails")]
    public string ait_FamilyMemberAncestryDetails
    {
      get => this.GetAttributeValue<string>("ait_familymemberancestrydetails");
      set
      {
        this.OnPropertyChanging(nameof (ait_FamilyMemberAncestryDetails));
        this.SetAttributeValue("ait_familymemberancestrydetails", (object) value);
        this.OnPropertyChanged(nameof (ait_FamilyMemberAncestryDetails));
      }
    }

    [AttributeLogicalName("ait_familyreceivedservicesfrombia")]
    public OptionSetValue ait_FamilyReceivedServicesfromBIA
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_familyreceivedservicesfrombia");
      set
      {
        this.OnPropertyChanging(nameof (ait_FamilyReceivedServicesfromBIA));
        this.SetAttributeValue("ait_familyreceivedservicesfrombia", (object) value);
        this.OnPropertyChanged(nameof (ait_FamilyReceivedServicesfromBIA));
      }
    }

    [AttributeLogicalName("ait_icwaaction")]
    public OptionSetValue ait_ICWAAction
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_icwaaction");
      set
      {
        this.OnPropertyChanging(nameof (ait_ICWAAction));
        this.SetAttributeValue("ait_icwaaction", (object) value);
        this.OnPropertyChanged(nameof (ait_ICWAAction));
      }
    }

    [AttributeLogicalName("ait_icwanoticeautonumber")]
    public string ait_ICWANoticeAutoNumber
    {
      get => this.GetAttributeValue<string>("ait_icwanoticeautonumber");
      set
      {
        this.OnPropertyChanging(nameof (ait_ICWANoticeAutoNumber));
        this.SetAttributeValue("ait_icwanoticeautonumber", (object) value);
        this.OnPropertyChanged(nameof (ait_ICWANoticeAutoNumber));
      }
    }

    [AttributeLogicalName("ait_icwanoticeid")]
    public Guid? ait_icwanoticeId
    {
      get => this.GetAttributeValue<Guid?>("ait_icwanoticeid");
      set
      {
        this.OnPropertyChanging(nameof (ait_icwanoticeId));
        this.SetAttributeValue("ait_icwanoticeid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_icwanoticeId));
      }
    }

    [AttributeLogicalName("ait_icwanoticeid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_icwanoticeId = new Guid?(value);
    }

    [AttributeLogicalName("ait_icwanoticestatus")]
    public OptionSetValue ait_ICWANoticeStatus
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_icwanoticestatus");
      set
      {
        this.OnPropertyChanging(nameof (ait_ICWANoticeStatus));
        this.SetAttributeValue("ait_icwanoticestatus", (object) value);
        this.OnPropertyChanged(nameof (ait_ICWANoticeStatus));
      }
    }

    [AttributeLogicalName("ait_ischildadopted")]
    public OptionSetValue ait_IsChildAdopted
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_ischildadopted");
      set
      {
        this.OnPropertyChanging(nameof (ait_IsChildAdopted));
        this.SetAttributeValue("ait_ischildadopted", (object) value);
        this.OnPropertyChanged(nameof (ait_IsChildAdopted));
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

    [AttributeLogicalName("ait_noticesubstantiated")]
    public bool? ait_NoticeSubstantiated
    {
      get => this.GetAttributeValue<bool?>("ait_noticesubstantiated");
      set
      {
        this.OnPropertyChanging(nameof (ait_NoticeSubstantiated));
        this.SetAttributeValue("ait_noticesubstantiated", (object) value);
        this.OnPropertyChanged(nameof (ait_NoticeSubstantiated));
      }
    }

    [AttributeLogicalName("ait_parentsofamericanindianancestry")]
    public OptionSetValue ait_ParentsofAmericanIndianAncestry
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_parentsofamericanindianancestry");
      set
      {
        this.OnPropertyChanging(nameof (ait_ParentsofAmericanIndianAncestry));
        this.SetAttributeValue("ait_parentsofamericanindianancestry", (object) value);
        this.OnPropertyChanged(nameof (ait_ParentsofAmericanIndianAncestry));
      }
    }

    [AttributeLogicalName("ait_petitiontribalcourt")]
    public bool? ait_PetitionTribalCourt
    {
      get => this.GetAttributeValue<bool?>("ait_petitiontribalcourt");
      set
      {
        this.OnPropertyChanging(nameof (ait_PetitionTribalCourt));
        this.SetAttributeValue("ait_petitiontribalcourt", (object) value);
        this.OnPropertyChanged(nameof (ait_PetitionTribalCourt));
      }
    }

    [AttributeLogicalName("ait_placement")]
    public EntityReference ait_Placement
    {
      get => this.GetAttributeValue<EntityReference>("ait_placement");
      set
      {
        this.OnPropertyChanging(nameof (ait_Placement));
        this.SetAttributeValue("ait_placement", (object) value);
        this.OnPropertyChanged(nameof (ait_Placement));
      }
    }

    [AttributeLogicalName("ait_placementoutofhome")]
    public bool? ait_PlacementoutofHome
    {
      get => this.GetAttributeValue<bool?>("ait_placementoutofhome");
      set
      {
        this.OnPropertyChanging(nameof (ait_PlacementoutofHome));
        this.SetAttributeValue("ait_placementoutofhome", (object) value);
        this.OnPropertyChanged(nameof (ait_PlacementoutofHome));
      }
    }

    [AttributeLogicalName("ait_recurringcases")]
    public bool? ait_RecurringCases
    {
      get => this.GetAttributeValue<bool?>("ait_recurringcases");
      set
      {
        this.OnPropertyChanging(nameof (ait_RecurringCases));
        this.SetAttributeValue("ait_recurringcases", (object) value);
        this.OnPropertyChanged(nameof (ait_RecurringCases));
      }
    }

    [AttributeLogicalName("ait_refertotribalsocialservices")]
    public bool? ait_RefertoTribalSocialServices
    {
      get => this.GetAttributeValue<bool?>("ait_refertotribalsocialservices");
      set
      {
        this.OnPropertyChanging(nameof (ait_RefertoTribalSocialServices));
        this.SetAttributeValue("ait_refertotribalsocialservices", (object) value);
        this.OnPropertyChanged(nameof (ait_RefertoTribalSocialServices));
      }
    }

    [AttributeLogicalName("ait_relatedincident")]
    public EntityReference ait_RelatedIncident
    {
      get => this.GetAttributeValue<EntityReference>("ait_relatedincident");
      set
      {
        this.OnPropertyChanging(nameof (ait_RelatedIncident));
        this.SetAttributeValue("ait_relatedincident", (object) value);
        this.OnPropertyChanged(nameof (ait_RelatedIncident));
      }
    }

    [AttributeLogicalName("ait_requestorcompany")]
    public EntityReference ait_RequestorCompany
    {
      get => this.GetAttributeValue<EntityReference>("ait_requestorcompany");
      set
      {
        this.OnPropertyChanging(nameof (ait_RequestorCompany));
        this.SetAttributeValue("ait_requestorcompany", (object) value);
        this.OnPropertyChanged(nameof (ait_RequestorCompany));
      }
    }

    [AttributeLogicalName("ait_responsedate")]
    public DateTime? ait_ResponseDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_responsedate");
      set
      {
        this.OnPropertyChanging(nameof (ait_ResponseDate));
        this.SetAttributeValue("ait_responsedate", (object) value);
        this.OnPropertyChanged(nameof (ait_ResponseDate));
      }
    }

    [AttributeLogicalName("ait_responsemethod")]
    public OptionSetValue ait_ResponseMethod
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_responsemethod");
      set
      {
        this.OnPropertyChanging(nameof (ait_ResponseMethod));
        this.SetAttributeValue("ait_responsemethod", (object) value);
        this.OnPropertyChanged(nameof (ait_ResponseMethod));
      }
    }

    [AttributeLogicalName("ait_siblinginvolvedcases")]
    public bool? ait_SiblingInvolvedCases
    {
      get => this.GetAttributeValue<bool?>("ait_siblinginvolvedcases");
      set
      {
        this.OnPropertyChanging(nameof (ait_SiblingInvolvedCases));
        this.SetAttributeValue("ait_siblinginvolvedcases", (object) value);
        this.OnPropertyChanged(nameof (ait_SiblingInvolvedCases));
      }
    }

    [AttributeLogicalName("ait_statuseffectivedate")]
    public DateTime? ait_StatusEffectiveDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_statuseffectivedate");
      set
      {
        this.OnPropertyChanging(nameof (ait_StatusEffectiveDate));
        this.SetAttributeValue("ait_statuseffectivedate", (object) value);
        this.OnPropertyChanged(nameof (ait_StatusEffectiveDate));
      }
    }

    [AttributeLogicalName("ait_typeofadoptionnotice")]
    public string ait_TypeofAdoptionNotice
    {
      get => this.GetAttributeValue<string>("ait_typeofadoptionnotice");
      set
      {
        this.OnPropertyChanging(nameof (ait_TypeofAdoptionNotice));
        this.SetAttributeValue("ait_typeofadoptionnotice", (object) value);
        this.OnPropertyChanged(nameof (ait_TypeofAdoptionNotice));
      }
    }

    [AttributeLogicalName("ait_voluntaryinvoluntary")]
    public OptionSetValue ait_VoluntaryInvoluntary
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_voluntaryinvoluntary");
      set
      {
        this.OnPropertyChanging(nameof (ait_VoluntaryInvoluntary));
        this.SetAttributeValue("ait_voluntaryinvoluntary", (object) value);
        this.OnPropertyChanged(nameof (ait_VoluntaryInvoluntary));
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
    public ait_icwanoticeState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_icwanoticeState?((ait_icwanoticeState) Enum.ToObject(typeof (ait_icwanoticeState), attributeValue.Value)) : new ait_icwanoticeState?();
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

    [RelationshipSchemaName("ait_icwanotice_ActivityParties")]
    public IEnumerable<ActivityParty> ait_icwanotice_ActivityParties
    {
      get
      {
        return this.GetRelatedEntities<ActivityParty>(nameof (ait_icwanotice_ActivityParties), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwanotice_ActivityParties));
        this.SetRelatedEntities<ActivityParty>(nameof (ait_icwanotice_ActivityParties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwanotice_ActivityParties));
      }
    }

    [RelationshipSchemaName("ait_icwanotice_ActivityPointers")]
    public IEnumerable<ActivityPointer> ait_icwanotice_ActivityPointers
    {
      get
      {
        return this.GetRelatedEntities<ActivityPointer>(nameof (ait_icwanotice_ActivityPointers), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwanotice_ActivityPointers));
        this.SetRelatedEntities<ActivityPointer>(nameof (ait_icwanotice_ActivityPointers), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwanotice_ActivityPointers));
      }
    }

    [RelationshipSchemaName("ait_icwanotice_ait_icwaregionnotification_ICWANotice")]
    public IEnumerable<ait_icwaregionnotification> ait_icwanotice_ait_icwaregionnotification_ICWANotice
    {
      get
      {
        return this.GetRelatedEntities<ait_icwaregionnotification>(nameof (ait_icwanotice_ait_icwaregionnotification_ICWANotice), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwanotice_ait_icwaregionnotification_ICWANotice));
        this.SetRelatedEntities<ait_icwaregionnotification>(nameof (ait_icwanotice_ait_icwaregionnotification_ICWANotice), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwanotice_ait_icwaregionnotification_ICWANotice));
      }
    }

    [RelationshipSchemaName("ait_icwanotice_Annotations")]
    public IEnumerable<Annotation> ait_icwanotice_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (ait_icwanotice_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwanotice_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (ait_icwanotice_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwanotice_Annotations));
      }
    }

    [RelationshipSchemaName("ait_icwanotice_Appointments")]
    public IEnumerable<Appointment> ait_icwanotice_Appointments
    {
      get
      {
        return this.GetRelatedEntities<Appointment>(nameof (ait_icwanotice_Appointments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwanotice_Appointments));
        this.SetRelatedEntities<Appointment>(nameof (ait_icwanotice_Appointments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwanotice_Appointments));
      }
    }

    [RelationshipSchemaName("ait_icwanotice_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_icwanotice_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_icwanotice_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwanotice_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_icwanotice_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwanotice_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_icwanotice_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_icwanotice_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_icwanotice_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwanotice_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_icwanotice_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwanotice_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_icwanotice_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_icwanotice_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_icwanotice_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwanotice_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_icwanotice_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwanotice_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_icwanotice_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_icwanotice_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_icwanotice_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwanotice_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_icwanotice_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwanotice_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_icwanotice_Emails")]
    public IEnumerable<Email> ait_icwanotice_Emails
    {
      get => this.GetRelatedEntities<Email>(nameof (ait_icwanotice_Emails), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_icwanotice_Emails));
        this.SetRelatedEntities<Email>(nameof (ait_icwanotice_Emails), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwanotice_Emails));
      }
    }

    [RelationshipSchemaName("ait_icwanotice_Faxes")]
    public IEnumerable<Fax> ait_icwanotice_Faxes
    {
      get => this.GetRelatedEntities<Fax>(nameof (ait_icwanotice_Faxes), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_icwanotice_Faxes));
        this.SetRelatedEntities<Fax>(nameof (ait_icwanotice_Faxes), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwanotice_Faxes));
      }
    }

    [RelationshipSchemaName("ait_icwanotice_Letters")]
    public IEnumerable<Letter> ait_icwanotice_Letters
    {
      get => this.GetRelatedEntities<Letter>(nameof (ait_icwanotice_Letters), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_icwanotice_Letters));
        this.SetRelatedEntities<Letter>(nameof (ait_icwanotice_Letters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwanotice_Letters));
      }
    }

    [RelationshipSchemaName("ait_icwanotice_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_icwanotice_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_icwanotice_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwanotice_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_icwanotice_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwanotice_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_icwanotice_PhoneCalls")]
    public IEnumerable<PhoneCall> ait_icwanotice_PhoneCalls
    {
      get
      {
        return this.GetRelatedEntities<PhoneCall>(nameof (ait_icwanotice_PhoneCalls), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwanotice_PhoneCalls));
        this.SetRelatedEntities<PhoneCall>(nameof (ait_icwanotice_PhoneCalls), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwanotice_PhoneCalls));
      }
    }

    [RelationshipSchemaName("ait_icwanotice_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_icwanotice_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_icwanotice_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwanotice_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_icwanotice_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwanotice_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_icwanotice_ProcessSession")]
    public IEnumerable<ProcessSession> ait_icwanotice_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_icwanotice_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwanotice_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_icwanotice_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwanotice_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_icwanotice_RecurringAppointmentMasters")]
    public IEnumerable<RecurringAppointmentMaster> ait_icwanotice_RecurringAppointmentMasters
    {
      get
      {
        return this.GetRelatedEntities<RecurringAppointmentMaster>(nameof (ait_icwanotice_RecurringAppointmentMasters), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwanotice_RecurringAppointmentMasters));
        this.SetRelatedEntities<RecurringAppointmentMaster>(nameof (ait_icwanotice_RecurringAppointmentMasters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwanotice_RecurringAppointmentMasters));
      }
    }

    [RelationshipSchemaName("ait_icwanotice_SharePointDocumentLocations")]
    public IEnumerable<SharePointDocumentLocation> ait_icwanotice_SharePointDocumentLocations
    {
      get
      {
        return this.GetRelatedEntities<SharePointDocumentLocation>(nameof (ait_icwanotice_SharePointDocumentLocations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwanotice_SharePointDocumentLocations));
        this.SetRelatedEntities<SharePointDocumentLocation>(nameof (ait_icwanotice_SharePointDocumentLocations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwanotice_SharePointDocumentLocations));
      }
    }

    [RelationshipSchemaName("ait_icwanotice_SharePointDocuments")]
    public IEnumerable<SharePointDocument> ait_icwanotice_SharePointDocuments
    {
      get
      {
        return this.GetRelatedEntities<SharePointDocument>(nameof (ait_icwanotice_SharePointDocuments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwanotice_SharePointDocuments));
        this.SetRelatedEntities<SharePointDocument>(nameof (ait_icwanotice_SharePointDocuments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwanotice_SharePointDocuments));
      }
    }

    [RelationshipSchemaName("ait_icwanotice_SocialActivities")]
    public IEnumerable<SocialActivity> ait_icwanotice_SocialActivities
    {
      get
      {
        return this.GetRelatedEntities<SocialActivity>(nameof (ait_icwanotice_SocialActivities), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwanotice_SocialActivities));
        this.SetRelatedEntities<SocialActivity>(nameof (ait_icwanotice_SocialActivities), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwanotice_SocialActivities));
      }
    }

    [RelationshipSchemaName("ait_icwanotice_SyncErrors")]
    public IEnumerable<SyncError> ait_icwanotice_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_icwanotice_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwanotice_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_icwanotice_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwanotice_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_icwanotice_Tasks")]
    public IEnumerable<Task> ait_icwanotice_Tasks
    {
      get => this.GetRelatedEntities<Task>(nameof (ait_icwanotice_Tasks), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_icwanotice_Tasks));
        this.SetRelatedEntities<Task>(nameof (ait_icwanotice_Tasks), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwanotice_Tasks));
      }
    }

    [RelationshipSchemaName("ait_icwanotice_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_icwanotice_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_icwanotice_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwanotice_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_icwanotice_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwanotice_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_relatedincident")]
    [RelationshipSchemaName("ait_ait_incident_ait_icwanotice_RelatedIncident")]
    public ait_incident ait_ait_incident_ait_icwanotice_RelatedIncident
    {
      get
      {
        return this.GetRelatedEntity<ait_incident>(nameof (ait_ait_incident_ait_icwanotice_RelatedIncident), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_incident_ait_icwanotice_RelatedIncident));
        this.SetRelatedEntity<ait_incident>(nameof (ait_ait_incident_ait_icwanotice_RelatedIncident), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_incident_ait_icwanotice_RelatedIncident));
      }
    }

    [AttributeLogicalName("ait_placement")]
    [RelationshipSchemaName("ait_ait_placement_ait_icwanotice_Placement")]
    public ait_placement ait_ait_placement_ait_icwanotice_Placement
    {
      get
      {
        return this.GetRelatedEntity<ait_placement>(nameof (ait_ait_placement_ait_icwanotice_Placement), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_placement_ait_icwanotice_Placement));
        this.SetRelatedEntity<ait_placement>(nameof (ait_ait_placement_ait_icwanotice_Placement), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_placement_ait_icwanotice_Placement));
      }
    }

    [AttributeLogicalName("ait_childclientprofile")]
    [RelationshipSchemaName("ait_clientprofile_ait_icwanotice_ChildClientProfile")]
    public ait_clientprofile ait_clientprofile_ait_icwanotice_ChildClientProfile
    {
      get
      {
        return this.GetRelatedEntity<ait_clientprofile>(nameof (ait_clientprofile_ait_icwanotice_ChildClientProfile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_ait_icwanotice_ChildClientProfile));
        this.SetRelatedEntity<ait_clientprofile>(nameof (ait_clientprofile_ait_icwanotice_ChildClientProfile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_ait_icwanotice_ChildClientProfile));
      }
    }

    [AttributeLogicalName("ait_requestorcompany")]
    [RelationshipSchemaName("ait_company_ait_icwanotice_RequestorCompany")]
    public ait_company ait_company_ait_icwanotice_RequestorCompany
    {
      get
      {
        return this.GetRelatedEntity<ait_company>(nameof (ait_company_ait_icwanotice_RequestorCompany), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_company_ait_icwanotice_RequestorCompany));
        this.SetRelatedEntity<ait_company>(nameof (ait_company_ait_icwanotice_RequestorCompany), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_company_ait_icwanotice_RequestorCompany));
      }
    }

    [AttributeLogicalName("ait_designatedagent")]
    [RelationshipSchemaName("ait_contact_ait_icwanotice_DesignatedAgent")]
    public Contact ait_contact_ait_icwanotice_DesignatedAgent
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (ait_contact_ait_icwanotice_DesignatedAgent), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contact_ait_icwanotice_DesignatedAgent));
        this.SetRelatedEntity<Contact>(nameof (ait_contact_ait_icwanotice_DesignatedAgent), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contact_ait_icwanotice_DesignatedAgent));
      }
    }

    [AttributeLogicalName("ait_caseworker")]
    [RelationshipSchemaName("ait_systemuser_ait_icwanotice_Caseworker")]
    public SystemUser ait_systemuser_ait_icwanotice_Caseworker
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (ait_systemuser_ait_icwanotice_Caseworker), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_systemuser_ait_icwanotice_Caseworker));
        this.SetRelatedEntity<SystemUser>(nameof (ait_systemuser_ait_icwanotice_Caseworker), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_systemuser_ait_icwanotice_Caseworker));
      }
    }

    [AttributeLogicalName("ait_enrollmentreviewer")]
    [RelationshipSchemaName("ait_systemuser_ait_icwanotice_EnrollmentReviewer")]
    public SystemUser ait_systemuser_ait_icwanotice_EnrollmentReviewer
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (ait_systemuser_ait_icwanotice_EnrollmentReviewer), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_systemuser_ait_icwanotice_EnrollmentReviewer));
        this.SetRelatedEntity<SystemUser>(nameof (ait_systemuser_ait_icwanotice_EnrollmentReviewer), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_systemuser_ait_icwanotice_EnrollmentReviewer));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_icwanotice")]
    public BusinessUnit business_unit_ait_icwanotice
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_icwanotice), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_icwanotice_createdby")]
    public SystemUser lk_ait_icwanotice_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_icwanotice_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_icwanotice_createdonbehalfby")]
    public SystemUser lk_ait_icwanotice_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_icwanotice_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_icwanotice_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_icwanotice_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_icwanotice_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_icwanotice_modifiedby")]
    public SystemUser lk_ait_icwanotice_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_icwanotice_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_icwanotice_modifiedonbehalfby")]
    public SystemUser lk_ait_icwanotice_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_icwanotice_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_icwanotice_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_icwanotice_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_icwanotice_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_icwanotice")]
    public Team team_ait_icwanotice
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_icwanotice), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_icwanotice")]
    public SystemUser user_ait_icwanotice
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_ait_icwanotice), new EntityRole?());
    }

    public ait_icwanotice(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_icwanoticeid"] = (object) base.Id;
            break;
          case "ait_icwanoticeid":
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
