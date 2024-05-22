// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_servicerequest
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_servicerequest")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_servicerequest : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_servicerequest";
    public const string EntitySchemaName = "ait_servicerequest";
    public const string PrimaryIdAttribute = "ait_servicerequestid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_servicerequest()
      : base(nameof (ait_servicerequest))
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

    [AttributeLogicalName("ait_approvaldate")]
    public DateTime? ait_approvaldate
    {
      get => this.GetAttributeValue<DateTime?>(nameof (ait_approvaldate));
      set
      {
        this.OnPropertyChanging(nameof (ait_approvaldate));
        this.SetAttributeValue(nameof (ait_approvaldate), (object) value);
        this.OnPropertyChanged(nameof (ait_approvaldate));
      }
    }

    [AttributeLogicalName("ait_approvalneeded")]
    public bool? ait_ApprovalNeeded
    {
      get => this.GetAttributeValue<bool?>("ait_approvalneeded");
      set
      {
        this.OnPropertyChanging(nameof (ait_ApprovalNeeded));
        this.SetAttributeValue("ait_approvalneeded", (object) value);
        this.OnPropertyChanged(nameof (ait_ApprovalNeeded));
      }
    }

    [AttributeLogicalName("ait_approvalstatus")]
    public OptionSetValue ait_approvalstatus
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_approvalstatus));
      set
      {
        this.OnPropertyChanging(nameof (ait_approvalstatus));
        this.SetAttributeValue(nameof (ait_approvalstatus), (object) value);
        this.OnPropertyChanged(nameof (ait_approvalstatus));
      }
    }

    [AttributeLogicalName("ait_approver")]
    public EntityReference ait_approver
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_approver));
      set
      {
        this.OnPropertyChanging(nameof (ait_approver));
        this.SetAttributeValue(nameof (ait_approver), (object) value);
        this.OnPropertyChanged(nameof (ait_approver));
      }
    }

    [AttributeLogicalName("ait_approvernotes")]
    public string ait_ApproverNotes
    {
      get => this.GetAttributeValue<string>("ait_approvernotes");
      set
      {
        this.OnPropertyChanging(nameof (ait_ApproverNotes));
        this.SetAttributeValue("ait_approvernotes", (object) value);
        this.OnPropertyChanged(nameof (ait_ApproverNotes));
      }
    }

    [AttributeLogicalName("ait_autonumbertest")]
    public string ait_AutoNumberTest
    {
      get => this.GetAttributeValue<string>("ait_autonumbertest");
      set
      {
        this.OnPropertyChanging(nameof (ait_AutoNumberTest));
        this.SetAttributeValue("ait_autonumbertest", (object) value);
        this.OnPropertyChanged(nameof (ait_AutoNumberTest));
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
    public EntityReference ait_caseworker
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_caseworker));
      set
      {
        this.OnPropertyChanging(nameof (ait_caseworker));
        this.SetAttributeValue(nameof (ait_caseworker), (object) value);
        this.OnPropertyChanged(nameof (ait_caseworker));
      }
    }

    [AttributeLogicalName("ait_christmasgivingtree")]
    public bool? ait_christmasgivingtree
    {
      get => this.GetAttributeValue<bool?>(nameof (ait_christmasgivingtree));
      set
      {
        this.OnPropertyChanging(nameof (ait_christmasgivingtree));
        this.SetAttributeValue(nameof (ait_christmasgivingtree), (object) value);
        this.OnPropertyChanged(nameof (ait_christmasgivingtree));
      }
    }

    [AttributeLogicalName("ait_christmasvouchers")]
    public bool? ait_christmasvouchers
    {
      get => this.GetAttributeValue<bool?>(nameof (ait_christmasvouchers));
      set
      {
        this.OnPropertyChanging(nameof (ait_christmasvouchers));
        this.SetAttributeValue(nameof (ait_christmasvouchers), (object) value);
        this.OnPropertyChanged(nameof (ait_christmasvouchers));
      }
    }

    [AttributeLogicalName("ait_clientprofile")]
    public EntityReference ait_clientprofile
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_clientprofile));
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile));
        this.SetAttributeValue(nameof (ait_clientprofile), (object) value);
        this.OnPropertyChanged(nameof (ait_clientprofile));
      }
    }

    [AttributeLogicalName("ait_completiondate")]
    public DateTime? ait_CompletionDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_completiondate");
      set
      {
        this.OnPropertyChanging(nameof (ait_CompletionDate));
        this.SetAttributeValue("ait_completiondate", (object) value);
        this.OnPropertyChanged(nameof (ait_CompletionDate));
      }
    }

    [AttributeLogicalName("ait_decisionrationale")]
    public string ait_DecisionRationale
    {
      get => this.GetAttributeValue<string>("ait_decisionrationale");
      set
      {
        this.OnPropertyChanging(nameof (ait_DecisionRationale));
        this.SetAttributeValue("ait_decisionrationale", (object) value);
        this.OnPropertyChanged(nameof (ait_DecisionRationale));
      }
    }

    [AttributeLogicalName("ait_eligibilitycriteria")]
    public string ait_eligibilitycriteria
    {
      get => this.GetAttributeValue<string>(nameof (ait_eligibilitycriteria));
      set
      {
        this.OnPropertyChanging(nameof (ait_eligibilitycriteria));
        this.SetAttributeValue(nameof (ait_eligibilitycriteria), (object) value);
        this.OnPropertyChanged(nameof (ait_eligibilitycriteria));
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

    [AttributeLogicalName("ait_financialassistancerequested")]
    public bool? ait_financialassistancerequested
    {
      get => this.GetAttributeValue<bool?>(nameof (ait_financialassistancerequested));
      set
      {
        this.OnPropertyChanging(nameof (ait_financialassistancerequested));
        this.SetAttributeValue(nameof (ait_financialassistancerequested), (object) value);
        this.OnPropertyChanged(nameof (ait_financialassistancerequested));
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

    [AttributeLogicalName("ait_requestedamount")]
    public Money ait_requestedamount
    {
      get => this.GetAttributeValue<Money>(nameof (ait_requestedamount));
      set
      {
        this.OnPropertyChanging(nameof (ait_requestedamount));
        this.SetAttributeValue(nameof (ait_requestedamount), (object) value);
        this.OnPropertyChanged(nameof (ait_requestedamount));
      }
    }

    [AttributeLogicalName("ait_requestedamount_base")]
    public Money ait_requestedamount_Base
    {
      get => this.GetAttributeValue<Money>("ait_requestedamount_base");
    }

    [AttributeLogicalName("ait_requestereligible")]
    public OptionSetValue ait_RequesterEligible
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_requestereligible");
      set
      {
        this.OnPropertyChanging(nameof (ait_RequesterEligible));
        this.SetAttributeValue("ait_requestereligible", (object) value);
        this.OnPropertyChanged(nameof (ait_RequesterEligible));
      }
    }

    [AttributeLogicalName("ait_servicerequestdate")]
    public DateTime? ait_servicerequestdate
    {
      get => this.GetAttributeValue<DateTime?>(nameof (ait_servicerequestdate));
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequestdate));
        this.SetAttributeValue(nameof (ait_servicerequestdate), (object) value);
        this.OnPropertyChanged(nameof (ait_servicerequestdate));
      }
    }

    [AttributeLogicalName("ait_servicerequestid")]
    public Guid? ait_servicerequestId
    {
      get => this.GetAttributeValue<Guid?>("ait_servicerequestid");
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequestId));
        this.SetAttributeValue("ait_servicerequestid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_servicerequestId));
      }
    }

    [AttributeLogicalName("ait_servicerequestid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_servicerequestId = new Guid?(value);
    }

    [AttributeLogicalName("ait_servicerequestname")]
    public string ait_ServiceRequestName
    {
      get => this.GetAttributeValue<string>("ait_servicerequestname");
      set
      {
        this.OnPropertyChanging(nameof (ait_ServiceRequestName));
        this.SetAttributeValue("ait_servicerequestname", (object) value);
        this.OnPropertyChanged(nameof (ait_ServiceRequestName));
      }
    }

    [AttributeLogicalName("ait_servicerequestreason")]
    public string ait_servicerequestreason
    {
      get => this.GetAttributeValue<string>(nameof (ait_servicerequestreason));
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequestreason));
        this.SetAttributeValue(nameof (ait_servicerequestreason), (object) value);
        this.OnPropertyChanged(nameof (ait_servicerequestreason));
      }
    }

    [AttributeLogicalName("ait_servicerequeststatus")]
    public OptionSetValue ait_servicerequeststatus
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_servicerequeststatus));
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequeststatus));
        this.SetAttributeValue(nameof (ait_servicerequeststatus), (object) value);
        this.OnPropertyChanged(nameof (ait_servicerequeststatus));
      }
    }

    [AttributeLogicalName("ait_servicerequesttype")]
    public OptionSetValue ait_servicerequesttype
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_servicerequesttype));
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequesttype));
        this.SetAttributeValue(nameof (ait_servicerequesttype), (object) value);
        this.OnPropertyChanged(nameof (ait_servicerequesttype));
      }
    }

    [AttributeLogicalName("ait_thanksgivingvouchers")]
    public bool? ait_thanksgivingvouchers
    {
      get => this.GetAttributeValue<bool?>(nameof (ait_thanksgivingvouchers));
      set
      {
        this.OnPropertyChanging(nameof (ait_thanksgivingvouchers));
        this.SetAttributeValue(nameof (ait_thanksgivingvouchers), (object) value);
        this.OnPropertyChanged(nameof (ait_thanksgivingvouchers));
      }
    }

    [AttributeLogicalName("ait_totalpayments")]
    public Money ait_TotalPayments => this.GetAttributeValue<Money>("ait_totalpayments");

    [AttributeLogicalName("ait_totalpayments_base")]
    public Money ait_totalpayments_Base => this.GetAttributeValue<Money>("ait_totalpayments_base");

    [AttributeLogicalName("ait_totalpayments_date")]
    public DateTime? ait_TotalPayments_Date
    {
      get => this.GetAttributeValue<DateTime?>("ait_totalpayments_date");
    }

    [AttributeLogicalName("ait_totalpayments_state")]
    public int? ait_TotalPayments_State => this.GetAttributeValue<int?>("ait_totalpayments_state");

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

    [AttributeLogicalName("exchangerate")]
    public Decimal? ExchangeRate => this.GetAttributeValue<Decimal?>("exchangerate");

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
    public ait_servicerequestState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_servicerequestState?((ait_servicerequestState) Enum.ToObject(typeof (ait_servicerequestState), attributeValue.Value)) : new ait_servicerequestState?();
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

    [AttributeLogicalName("transactioncurrencyid")]
    public EntityReference TransactionCurrencyId
    {
      get => this.GetAttributeValue<EntityReference>("transactioncurrencyid");
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrencyId));
        this.SetAttributeValue("transactioncurrencyid", (object) value);
        this.OnPropertyChanged(nameof (TransactionCurrencyId));
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

    [RelationshipSchemaName("ait_ait_servicerequest_ait_case_ServiceRequest")]
    public IEnumerable<ait_case> ait_ait_servicerequest_ait_case_ServiceRequest
    {
      get
      {
        return this.GetRelatedEntities<ait_case>(nameof (ait_ait_servicerequest_ait_case_ServiceRequest), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_servicerequest_ait_case_ServiceRequest));
        this.SetRelatedEntities<ait_case>(nameof (ait_ait_servicerequest_ait_case_ServiceRequest), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_servicerequest_ait_case_ServiceRequest));
      }
    }

    [RelationshipSchemaName("ait_servicerequest_ActivityParties")]
    public IEnumerable<ActivityParty> ait_servicerequest_ActivityParties
    {
      get
      {
        return this.GetRelatedEntities<ActivityParty>(nameof (ait_servicerequest_ActivityParties), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_ActivityParties));
        this.SetRelatedEntities<ActivityParty>(nameof (ait_servicerequest_ActivityParties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_ActivityParties));
      }
    }

    [RelationshipSchemaName("ait_servicerequest_ActivityPointers")]
    public IEnumerable<ActivityPointer> ait_servicerequest_ActivityPointers
    {
      get
      {
        return this.GetRelatedEntities<ActivityPointer>(nameof (ait_servicerequest_ActivityPointers), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_ActivityPointers));
        this.SetRelatedEntities<ActivityPointer>(nameof (ait_servicerequest_ActivityPointers), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_ActivityPointers));
      }
    }

    [RelationshipSchemaName("ait_servicerequest_ait_caseplan_ServiceRequest")]
    public IEnumerable<ait_caseplan> ait_servicerequest_ait_caseplan_ServiceRequest
    {
      get
      {
        return this.GetRelatedEntities<ait_caseplan>(nameof (ait_servicerequest_ait_caseplan_ServiceRequest), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_ait_caseplan_ServiceRequest));
        this.SetRelatedEntities<ait_caseplan>(nameof (ait_servicerequest_ait_caseplan_ServiceRequest), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_ait_caseplan_ServiceRequest));
      }
    }

    [RelationshipSchemaName("ait_servicerequest_ait_goal_ServiceRequest")]
    public IEnumerable<ait_goal> ait_servicerequest_ait_goal_ServiceRequest
    {
      get
      {
        return this.GetRelatedEntities<ait_goal>(nameof (ait_servicerequest_ait_goal_ServiceRequest), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_ait_goal_ServiceRequest));
        this.SetRelatedEntities<ait_goal>(nameof (ait_servicerequest_ait_goal_ServiceRequest), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_ait_goal_ServiceRequest));
      }
    }

    [RelationshipSchemaName("ait_servicerequest_ait_incident_ServiceRequest")]
    public IEnumerable<ait_incident> ait_servicerequest_ait_incident_ServiceRequest
    {
      get
      {
        return this.GetRelatedEntities<ait_incident>(nameof (ait_servicerequest_ait_incident_ServiceRequest), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_ait_incident_ServiceRequest));
        this.SetRelatedEntities<ait_incident>(nameof (ait_servicerequest_ait_incident_ServiceRequest), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_ait_incident_ServiceRequest));
      }
    }

    [RelationshipSchemaName("ait_servicerequest_ait_payment_ServiceRequest")]
    public IEnumerable<ait_payment> ait_servicerequest_ait_payment_ServiceRequest
    {
      get
      {
        return this.GetRelatedEntities<ait_payment>(nameof (ait_servicerequest_ait_payment_ServiceRequest), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_ait_payment_ServiceRequest));
        this.SetRelatedEntities<ait_payment>(nameof (ait_servicerequest_ait_payment_ServiceRequest), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_ait_payment_ServiceRequest));
      }
    }

    [RelationshipSchemaName("ait_servicerequest_ait_referral_ServiceRequest")]
    public IEnumerable<ait_referral> ait_servicerequest_ait_referral_ServiceRequest
    {
      get
      {
        return this.GetRelatedEntities<ait_referral>(nameof (ait_servicerequest_ait_referral_ServiceRequest), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_ait_referral_ServiceRequest));
        this.SetRelatedEntities<ait_referral>(nameof (ait_servicerequest_ait_referral_ServiceRequest), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_ait_referral_ServiceRequest));
      }
    }

    [RelationshipSchemaName("ait_servicerequest_Annotations")]
    public IEnumerable<Annotation> ait_servicerequest_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (ait_servicerequest_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (ait_servicerequest_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_Annotations));
      }
    }

    [RelationshipSchemaName("ait_servicerequest_Appointments")]
    public IEnumerable<Appointment> ait_servicerequest_Appointments
    {
      get
      {
        return this.GetRelatedEntities<Appointment>(nameof (ait_servicerequest_Appointments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_Appointments));
        this.SetRelatedEntities<Appointment>(nameof (ait_servicerequest_Appointments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_Appointments));
      }
    }

    [RelationshipSchemaName("ait_servicerequest_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_servicerequest_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_servicerequest_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_servicerequest_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_servicerequest_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_servicerequest_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_servicerequest_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_servicerequest_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_servicerequest_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_servicerequest_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_servicerequest_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_servicerequest_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_servicerequest_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_servicerequest_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_servicerequest_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_servicerequest_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_servicerequest_Emails")]
    public IEnumerable<Email> ait_servicerequest_Emails
    {
      get => this.GetRelatedEntities<Email>(nameof (ait_servicerequest_Emails), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_Emails));
        this.SetRelatedEntities<Email>(nameof (ait_servicerequest_Emails), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_Emails));
      }
    }

    [RelationshipSchemaName("ait_servicerequest_Faxes")]
    public IEnumerable<Fax> ait_servicerequest_Faxes
    {
      get => this.GetRelatedEntities<Fax>(nameof (ait_servicerequest_Faxes), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_Faxes));
        this.SetRelatedEntities<Fax>(nameof (ait_servicerequest_Faxes), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_Faxes));
      }
    }

    [RelationshipSchemaName("ait_servicerequest_Letters")]
    public IEnumerable<Letter> ait_servicerequest_Letters
    {
      get
      {
        return this.GetRelatedEntities<Letter>(nameof (ait_servicerequest_Letters), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_Letters));
        this.SetRelatedEntities<Letter>(nameof (ait_servicerequest_Letters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_Letters));
      }
    }

    [RelationshipSchemaName("ait_servicerequest_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_servicerequest_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_servicerequest_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_servicerequest_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_servicerequest_PhoneCalls")]
    public IEnumerable<PhoneCall> ait_servicerequest_PhoneCalls
    {
      get
      {
        return this.GetRelatedEntities<PhoneCall>(nameof (ait_servicerequest_PhoneCalls), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_PhoneCalls));
        this.SetRelatedEntities<PhoneCall>(nameof (ait_servicerequest_PhoneCalls), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_PhoneCalls));
      }
    }

    [RelationshipSchemaName("ait_servicerequest_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_servicerequest_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_servicerequest_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_servicerequest_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_servicerequest_ProcessSession")]
    public IEnumerable<ProcessSession> ait_servicerequest_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_servicerequest_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_servicerequest_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_servicerequest_QueueItems")]
    public IEnumerable<QueueItem> ait_servicerequest_QueueItems
    {
      get
      {
        return this.GetRelatedEntities<QueueItem>(nameof (ait_servicerequest_QueueItems), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_QueueItems));
        this.SetRelatedEntities<QueueItem>(nameof (ait_servicerequest_QueueItems), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_QueueItems));
      }
    }

    [RelationshipSchemaName("ait_servicerequest_RecurringAppointmentMasters")]
    public IEnumerable<RecurringAppointmentMaster> ait_servicerequest_RecurringAppointmentMasters
    {
      get
      {
        return this.GetRelatedEntities<RecurringAppointmentMaster>(nameof (ait_servicerequest_RecurringAppointmentMasters), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_RecurringAppointmentMasters));
        this.SetRelatedEntities<RecurringAppointmentMaster>(nameof (ait_servicerequest_RecurringAppointmentMasters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_RecurringAppointmentMasters));
      }
    }

    [RelationshipSchemaName("ait_servicerequest_SharePointDocumentLocations")]
    public IEnumerable<SharePointDocumentLocation> ait_servicerequest_SharePointDocumentLocations
    {
      get
      {
        return this.GetRelatedEntities<SharePointDocumentLocation>(nameof (ait_servicerequest_SharePointDocumentLocations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_SharePointDocumentLocations));
        this.SetRelatedEntities<SharePointDocumentLocation>(nameof (ait_servicerequest_SharePointDocumentLocations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_SharePointDocumentLocations));
      }
    }

    [RelationshipSchemaName("ait_servicerequest_SharePointDocuments")]
    public IEnumerable<SharePointDocument> ait_servicerequest_SharePointDocuments
    {
      get
      {
        return this.GetRelatedEntities<SharePointDocument>(nameof (ait_servicerequest_SharePointDocuments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_SharePointDocuments));
        this.SetRelatedEntities<SharePointDocument>(nameof (ait_servicerequest_SharePointDocuments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_SharePointDocuments));
      }
    }

    [RelationshipSchemaName("ait_servicerequest_SocialActivities")]
    public IEnumerable<SocialActivity> ait_servicerequest_SocialActivities
    {
      get
      {
        return this.GetRelatedEntities<SocialActivity>(nameof (ait_servicerequest_SocialActivities), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_SocialActivities));
        this.SetRelatedEntities<SocialActivity>(nameof (ait_servicerequest_SocialActivities), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_SocialActivities));
      }
    }

    [RelationshipSchemaName("ait_servicerequest_SyncErrors")]
    public IEnumerable<SyncError> ait_servicerequest_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_servicerequest_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_servicerequest_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_servicerequest_Tasks")]
    public IEnumerable<Task> ait_servicerequest_Tasks
    {
      get => this.GetRelatedEntities<Task>(nameof (ait_servicerequest_Tasks), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_Tasks));
        this.SetRelatedEntities<Task>(nameof (ait_servicerequest_Tasks), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_Tasks));
      }
    }

    [RelationshipSchemaName("ait_servicerequest_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_servicerequest_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_servicerequest_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_servicerequest_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_case")]
    [RelationshipSchemaName("ait_ait_case_ait_servicerequest_Case")]
    public ait_case ait_ait_case_ait_servicerequest_Case
    {
      get
      {
        return this.GetRelatedEntity<ait_case>(nameof (ait_ait_case_ait_servicerequest_Case), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_case_ait_servicerequest_Case));
        this.SetRelatedEntity<ait_case>(nameof (ait_ait_case_ait_servicerequest_Case), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_case_ait_servicerequest_Case));
      }
    }

    [AttributeLogicalName("ait_caseplan")]
    [RelationshipSchemaName("ait_caseplan_ait_servicerequest_Plan")]
    public ait_caseplan ait_caseplan_ait_servicerequest_Plan
    {
      get
      {
        return this.GetRelatedEntity<ait_caseplan>(nameof (ait_caseplan_ait_servicerequest_Plan), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_caseplan_ait_servicerequest_Plan));
        this.SetRelatedEntity<ait_caseplan>(nameof (ait_caseplan_ait_servicerequest_Plan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_caseplan_ait_servicerequest_Plan));
      }
    }

    [AttributeLogicalName("ait_familygroup")]
    [RelationshipSchemaName("ait_familygroup_ait_servicerequest_FamilyGroup")]
    public ait_familygroup ait_familygroup_ait_servicerequest_FamilyGroup
    {
      get
      {
        return this.GetRelatedEntity<ait_familygroup>(nameof (ait_familygroup_ait_servicerequest_FamilyGroup), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familygroup_ait_servicerequest_FamilyGroup));
        this.SetRelatedEntity<ait_familygroup>(nameof (ait_familygroup_ait_servicerequest_FamilyGroup), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familygroup_ait_servicerequest_FamilyGroup));
      }
    }

    [AttributeLogicalName("ait_program")]
    [RelationshipSchemaName("ait_program_ait_servicerequest_Program")]
    public ait_program ait_program_ait_servicerequest_Program
    {
      get
      {
        return this.GetRelatedEntity<ait_program>(nameof (ait_program_ait_servicerequest_Program), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_program_ait_servicerequest_Program));
        this.SetRelatedEntity<ait_program>(nameof (ait_program_ait_servicerequest_Program), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_program_ait_servicerequest_Program));
      }
    }

    [AttributeLogicalName("ait_clientprofile")]
    [RelationshipSchemaName("ait_servicerequest_clientprofile_ait_clie")]
    public ArcticIT.EarlyBound.Entities.ait_clientprofile ait_servicerequest_clientprofile_ait_clie
    {
      get
      {
        return this.GetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_clientprofile>(nameof (ait_servicerequest_clientprofile_ait_clie), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_clientprofile_ait_clie));
        this.SetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_clientprofile>(nameof (ait_servicerequest_clientprofile_ait_clie), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_clientprofile_ait_clie));
      }
    }

    [AttributeLogicalName("ait_approver")]
    [RelationshipSchemaName("ait_systemuser_ait_servicerequest_approver")]
    public SystemUser ait_systemuser_ait_servicerequest_approver
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (ait_systemuser_ait_servicerequest_approver), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_systemuser_ait_servicerequest_approver));
        this.SetRelatedEntity<SystemUser>(nameof (ait_systemuser_ait_servicerequest_approver), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_systemuser_ait_servicerequest_approver));
      }
    }

    [AttributeLogicalName("ait_caseworker")]
    [RelationshipSchemaName("ait_systemuser_ait_servicerequest_caseworker")]
    public SystemUser ait_systemuser_ait_servicerequest_caseworker
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (ait_systemuser_ait_servicerequest_caseworker), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_systemuser_ait_servicerequest_caseworker));
        this.SetRelatedEntity<SystemUser>(nameof (ait_systemuser_ait_servicerequest_caseworker), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_systemuser_ait_servicerequest_caseworker));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_servicerequest")]
    public BusinessUnit business_unit_ait_servicerequest
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_servicerequest), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_servicerequest_createdby")]
    public SystemUser lk_ait_servicerequest_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_servicerequest_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_servicerequest_createdonbehalfby")]
    public SystemUser lk_ait_servicerequest_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_servicerequest_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_servicerequest_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_servicerequest_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_servicerequest_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_servicerequest_modifiedby")]
    public SystemUser lk_ait_servicerequest_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_servicerequest_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_servicerequest_modifiedonbehalfby")]
    public SystemUser lk_ait_servicerequest_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_servicerequest_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_servicerequest_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_servicerequest_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_servicerequest_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_servicerequest")]
    public Team team_ait_servicerequest
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_servicerequest), new EntityRole?());
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_ait_servicerequest")]
    public TransactionCurrency TransactionCurrency_ait_servicerequest
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_ait_servicerequest), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_ait_servicerequest));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_ait_servicerequest), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_ait_servicerequest));
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_servicerequest")]
    public SystemUser user_ait_servicerequest
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_ait_servicerequest), new EntityRole?());
    }

    public ait_servicerequest(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_servicerequestid"] = (object) base.Id;
            break;
          case "ait_servicerequestid":
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
