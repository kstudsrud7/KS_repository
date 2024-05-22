// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_referral
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_referral")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_referral : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_referral";
    public const string EntitySchemaName = "ait_referral";
    public const string PrimaryIdAttribute = "ait_referralid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_referral()
      : base(nameof (ait_referral))
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

    [AttributeLogicalName("ait_approveddate")]
    public DateTime? ait_ApprovedDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_approveddate");
      set
      {
        this.OnPropertyChanging(nameof (ait_ApprovedDate));
        this.SetAttributeValue("ait_approveddate", (object) value);
        this.OnPropertyChanged(nameof (ait_ApprovedDate));
      }
    }

    [AttributeLogicalName("ait_approver")]
    public EntityReference ait_Approver
    {
      get => this.GetAttributeValue<EntityReference>("ait_approver");
      set
      {
        this.OnPropertyChanging(nameof (ait_Approver));
        this.SetAttributeValue("ait_approver", (object) value);
        this.OnPropertyChanged(nameof (ait_Approver));
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
    public string ait_Comments
    {
      get => this.GetAttributeValue<string>("ait_comments");
      set
      {
        this.OnPropertyChanging(nameof (ait_Comments));
        this.SetAttributeValue("ait_comments", (object) value);
        this.OnPropertyChanged(nameof (ait_Comments));
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

    [AttributeLogicalName("ait_decisiondate")]
    public DateTime? ait_DecisionDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_decisiondate");
      set
      {
        this.OnPropertyChanging(nameof (ait_DecisionDate));
        this.SetAttributeValue("ait_decisiondate", (object) value);
        this.OnPropertyChanged(nameof (ait_DecisionDate));
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

    [AttributeLogicalName("ait_eligibilitycomment")]
    public string ait_EligibilityComment
    {
      get => this.GetAttributeValue<string>("ait_eligibilitycomment");
      set
      {
        this.OnPropertyChanging(nameof (ait_EligibilityComment));
        this.SetAttributeValue("ait_eligibilitycomment", (object) value);
        this.OnPropertyChanged(nameof (ait_EligibilityComment));
      }
    }

    [AttributeLogicalName("ait_eligible")]
    public bool? ait_Eligible
    {
      get => this.GetAttributeValue<bool?>("ait_eligible");
      set
      {
        this.OnPropertyChanging(nameof (ait_Eligible));
        this.SetAttributeValue("ait_eligible", (object) value);
        this.OnPropertyChanged(nameof (ait_Eligible));
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
    public EntityReference ait_Goal
    {
      get => this.GetAttributeValue<EntityReference>("ait_goal");
      set
      {
        this.OnPropertyChanging(nameof (ait_Goal));
        this.SetAttributeValue("ait_goal", (object) value);
        this.OnPropertyChanged(nameof (ait_Goal));
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

    [AttributeLogicalName("ait_paymentcount")]
    public int? ait_PaymentCount => this.GetAttributeValue<int?>("ait_paymentcount");

    [AttributeLogicalName("ait_paymentcount_date")]
    public DateTime? ait_PaymentCount_Date
    {
      get => this.GetAttributeValue<DateTime?>("ait_paymentcount_date");
    }

    [AttributeLogicalName("ait_paymentcount_state")]
    public int? ait_PaymentCount_State => this.GetAttributeValue<int?>("ait_paymentcount_state");

    [AttributeLogicalName("ait_paymenttotal")]
    public Money ait_PaymentTotal => this.GetAttributeValue<Money>("ait_paymenttotal");

    [AttributeLogicalName("ait_paymenttotal_base")]
    public Money ait_paymenttotal_Base => this.GetAttributeValue<Money>("ait_paymenttotal_base");

    [AttributeLogicalName("ait_paymenttotal_date")]
    public DateTime? ait_PaymentTotal_Date
    {
      get => this.GetAttributeValue<DateTime?>("ait_paymenttotal_date");
    }

    [AttributeLogicalName("ait_paymenttotal_state")]
    public int? ait_PaymentTotal_State => this.GetAttributeValue<int?>("ait_paymenttotal_state");

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

    [AttributeLogicalName("ait_referralautoid")]
    public string ait_ReferralAutoID
    {
      get => this.GetAttributeValue<string>("ait_referralautoid");
      set
      {
        this.OnPropertyChanging(nameof (ait_ReferralAutoID));
        this.SetAttributeValue("ait_referralautoid", (object) value);
        this.OnPropertyChanged(nameof (ait_ReferralAutoID));
      }
    }

    [AttributeLogicalName("ait_referraldate")]
    public DateTime? ait_ReferralDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_referraldate");
      set
      {
        this.OnPropertyChanging(nameof (ait_ReferralDate));
        this.SetAttributeValue("ait_referraldate", (object) value);
        this.OnPropertyChanged(nameof (ait_ReferralDate));
      }
    }

    [AttributeLogicalName("ait_referralid")]
    public Guid? ait_referralId
    {
      get => this.GetAttributeValue<Guid?>("ait_referralid");
      set
      {
        this.OnPropertyChanging(nameof (ait_referralId));
        this.SetAttributeValue("ait_referralid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_referralId));
      }
    }

    [AttributeLogicalName("ait_referralid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_referralId = new Guid?(value);
    }

    [AttributeLogicalName("ait_referralprovideraccepteddate")]
    public DateTime? ait_ReferralProviderAcceptedDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_referralprovideraccepteddate");
      set
      {
        this.OnPropertyChanging(nameof (ait_ReferralProviderAcceptedDate));
        this.SetAttributeValue("ait_referralprovideraccepteddate", (object) value);
        this.OnPropertyChanged(nameof (ait_ReferralProviderAcceptedDate));
      }
    }

    [AttributeLogicalName("ait_referralproviderrequesteddate")]
    public DateTime? ait_ReferralProviderRequestedDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_referralproviderrequesteddate");
      set
      {
        this.OnPropertyChanging(nameof (ait_ReferralProviderRequestedDate));
        this.SetAttributeValue("ait_referralproviderrequesteddate", (object) value);
        this.OnPropertyChanged(nameof (ait_ReferralProviderRequestedDate));
      }
    }

    [AttributeLogicalName("ait_referralsource")]
    public OptionSetValue ait_ReferralSource
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_referralsource");
      set
      {
        this.OnPropertyChanging(nameof (ait_ReferralSource));
        this.SetAttributeValue("ait_referralsource", (object) value);
        this.OnPropertyChanged(nameof (ait_ReferralSource));
      }
    }

    [AttributeLogicalName("ait_referralstatus")]
    public OptionSetValue ait_ReferralStatus
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_referralstatus");
      set
      {
        this.OnPropertyChanging(nameof (ait_ReferralStatus));
        this.SetAttributeValue("ait_referralstatus", (object) value);
        this.OnPropertyChanged(nameof (ait_ReferralStatus));
      }
    }

    [AttributeLogicalName("ait_referraltype")]
    public OptionSetValue ait_ReferralType
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_referraltype");
      set
      {
        this.OnPropertyChanging(nameof (ait_ReferralType));
        this.SetAttributeValue("ait_referraltype", (object) value);
        this.OnPropertyChanged(nameof (ait_ReferralType));
      }
    }

    [AttributeLogicalName("ait_referraltypeother")]
    public string ait_ReferralTypeOther
    {
      get => this.GetAttributeValue<string>("ait_referraltypeother");
      set
      {
        this.OnPropertyChanging(nameof (ait_ReferralTypeOther));
        this.SetAttributeValue("ait_referraltypeother", (object) value);
        this.OnPropertyChanged(nameof (ait_ReferralTypeOther));
      }
    }

    [AttributeLogicalName("ait_referredby")]
    public EntityReference ait_ReferredBy
    {
      get => this.GetAttributeValue<EntityReference>("ait_referredby");
      set
      {
        this.OnPropertyChanging(nameof (ait_ReferredBy));
        this.SetAttributeValue("ait_referredby", (object) value);
        this.OnPropertyChanged(nameof (ait_ReferredBy));
      }
    }

    [AttributeLogicalName("ait_referredtocompany")]
    public EntityReference ait_referredtocompany
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_referredtocompany));
      set
      {
        this.OnPropertyChanging(nameof (ait_referredtocompany));
        this.SetAttributeValue(nameof (ait_referredtocompany), (object) value);
        this.OnPropertyChanged(nameof (ait_referredtocompany));
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
    public ait_referralState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_referralState?((ait_referralState) Enum.ToObject(typeof (ait_referralState), attributeValue.Value)) : new ait_referralState?();
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

    [RelationshipSchemaName("ait_ait_referral_ait_planactivity_Referral")]
    public IEnumerable<ait_planactivity> ait_ait_referral_ait_planactivity_Referral
    {
      get
      {
        return this.GetRelatedEntities<ait_planactivity>(nameof (ait_ait_referral_ait_planactivity_Referral), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_referral_ait_planactivity_Referral));
        this.SetRelatedEntities<ait_planactivity>(nameof (ait_ait_referral_ait_planactivity_Referral), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_referral_ait_planactivity_Referral));
      }
    }

    [RelationshipSchemaName("ait_referral_ActivityParties")]
    public IEnumerable<ActivityParty> ait_referral_ActivityParties
    {
      get
      {
        return this.GetRelatedEntities<ActivityParty>(nameof (ait_referral_ActivityParties), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_referral_ActivityParties));
        this.SetRelatedEntities<ActivityParty>(nameof (ait_referral_ActivityParties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_referral_ActivityParties));
      }
    }

    [RelationshipSchemaName("ait_referral_ActivityPointers")]
    public IEnumerable<ActivityPointer> ait_referral_ActivityPointers
    {
      get
      {
        return this.GetRelatedEntities<ActivityPointer>(nameof (ait_referral_ActivityPointers), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_referral_ActivityPointers));
        this.SetRelatedEntities<ActivityPointer>(nameof (ait_referral_ActivityPointers), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_referral_ActivityPointers));
      }
    }

    [RelationshipSchemaName("ait_referral_ait_payment_Referral")]
    public IEnumerable<ait_payment> ait_referral_ait_payment_Referral
    {
      get
      {
        return this.GetRelatedEntities<ait_payment>(nameof (ait_referral_ait_payment_Referral), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_referral_ait_payment_Referral));
        this.SetRelatedEntities<ait_payment>(nameof (ait_referral_ait_payment_Referral), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_referral_ait_payment_Referral));
      }
    }

    [RelationshipSchemaName("ait_referral_Annotations")]
    public IEnumerable<Annotation> ait_referral_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (ait_referral_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_referral_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (ait_referral_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_referral_Annotations));
      }
    }

    [RelationshipSchemaName("ait_referral_Appointments")]
    public IEnumerable<Appointment> ait_referral_Appointments
    {
      get
      {
        return this.GetRelatedEntities<Appointment>(nameof (ait_referral_Appointments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_referral_Appointments));
        this.SetRelatedEntities<Appointment>(nameof (ait_referral_Appointments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_referral_Appointments));
      }
    }

    [RelationshipSchemaName("ait_referral_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_referral_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_referral_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_referral_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_referral_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_referral_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_referral_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_referral_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_referral_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_referral_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_referral_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_referral_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_referral_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_referral_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_referral_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_referral_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_referral_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_referral_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_referral_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_referral_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_referral_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_referral_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_referral_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_referral_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_referral_Emails")]
    public IEnumerable<Email> ait_referral_Emails
    {
      get => this.GetRelatedEntities<Email>(nameof (ait_referral_Emails), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_referral_Emails));
        this.SetRelatedEntities<Email>(nameof (ait_referral_Emails), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_referral_Emails));
      }
    }

    [RelationshipSchemaName("ait_referral_Faxes")]
    public IEnumerable<Fax> ait_referral_Faxes
    {
      get => this.GetRelatedEntities<Fax>(nameof (ait_referral_Faxes), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_referral_Faxes));
        this.SetRelatedEntities<Fax>(nameof (ait_referral_Faxes), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_referral_Faxes));
      }
    }

    [RelationshipSchemaName("ait_referral_Letters")]
    public IEnumerable<Letter> ait_referral_Letters
    {
      get => this.GetRelatedEntities<Letter>(nameof (ait_referral_Letters), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_referral_Letters));
        this.SetRelatedEntities<Letter>(nameof (ait_referral_Letters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_referral_Letters));
      }
    }

    [RelationshipSchemaName("ait_referral_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_referral_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_referral_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_referral_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_referral_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_referral_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_referral_PhoneCalls")]
    public IEnumerable<PhoneCall> ait_referral_PhoneCalls
    {
      get
      {
        return this.GetRelatedEntities<PhoneCall>(nameof (ait_referral_PhoneCalls), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_referral_PhoneCalls));
        this.SetRelatedEntities<PhoneCall>(nameof (ait_referral_PhoneCalls), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_referral_PhoneCalls));
      }
    }

    [RelationshipSchemaName("ait_referral_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_referral_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_referral_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_referral_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_referral_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_referral_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_referral_ProcessSession")]
    public IEnumerable<ProcessSession> ait_referral_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_referral_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_referral_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_referral_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_referral_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_referral_RecurringAppointmentMasters")]
    public IEnumerable<RecurringAppointmentMaster> ait_referral_RecurringAppointmentMasters
    {
      get
      {
        return this.GetRelatedEntities<RecurringAppointmentMaster>(nameof (ait_referral_RecurringAppointmentMasters), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_referral_RecurringAppointmentMasters));
        this.SetRelatedEntities<RecurringAppointmentMaster>(nameof (ait_referral_RecurringAppointmentMasters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_referral_RecurringAppointmentMasters));
      }
    }

    [RelationshipSchemaName("ait_referral_SharePointDocumentLocations")]
    public IEnumerable<SharePointDocumentLocation> ait_referral_SharePointDocumentLocations
    {
      get
      {
        return this.GetRelatedEntities<SharePointDocumentLocation>(nameof (ait_referral_SharePointDocumentLocations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_referral_SharePointDocumentLocations));
        this.SetRelatedEntities<SharePointDocumentLocation>(nameof (ait_referral_SharePointDocumentLocations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_referral_SharePointDocumentLocations));
      }
    }

    [RelationshipSchemaName("ait_referral_SharePointDocuments")]
    public IEnumerable<SharePointDocument> ait_referral_SharePointDocuments
    {
      get
      {
        return this.GetRelatedEntities<SharePointDocument>(nameof (ait_referral_SharePointDocuments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_referral_SharePointDocuments));
        this.SetRelatedEntities<SharePointDocument>(nameof (ait_referral_SharePointDocuments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_referral_SharePointDocuments));
      }
    }

    [RelationshipSchemaName("ait_referral_SocialActivities")]
    public IEnumerable<SocialActivity> ait_referral_SocialActivities
    {
      get
      {
        return this.GetRelatedEntities<SocialActivity>(nameof (ait_referral_SocialActivities), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_referral_SocialActivities));
        this.SetRelatedEntities<SocialActivity>(nameof (ait_referral_SocialActivities), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_referral_SocialActivities));
      }
    }

    [RelationshipSchemaName("ait_referral_SyncErrors")]
    public IEnumerable<SyncError> ait_referral_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_referral_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_referral_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_referral_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_referral_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_referral_Tasks")]
    public IEnumerable<Task> ait_referral_Tasks
    {
      get => this.GetRelatedEntities<Task>(nameof (ait_referral_Tasks), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_referral_Tasks));
        this.SetRelatedEntities<Task>(nameof (ait_referral_Tasks), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_referral_Tasks));
      }
    }

    [RelationshipSchemaName("ait_referral_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_referral_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_referral_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_referral_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_referral_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_referral_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_case")]
    [RelationshipSchemaName("ait_ait_case_ait_referral_Case")]
    public ait_case ait_ait_case_ait_referral_Case
    {
      get
      {
        return this.GetRelatedEntity<ait_case>(nameof (ait_ait_case_ait_referral_Case), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_case_ait_referral_Case));
        this.SetRelatedEntity<ait_case>(nameof (ait_ait_case_ait_referral_Case), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_case_ait_referral_Case));
      }
    }

    [AttributeLogicalName("ait_caseplan")]
    [RelationshipSchemaName("ait_ait_caseplan_ait_referral_Plan")]
    public ait_caseplan ait_ait_caseplan_ait_referral_Plan
    {
      get
      {
        return this.GetRelatedEntity<ait_caseplan>(nameof (ait_ait_caseplan_ait_referral_Plan), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_caseplan_ait_referral_Plan));
        this.SetRelatedEntity<ait_caseplan>(nameof (ait_ait_caseplan_ait_referral_Plan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_caseplan_ait_referral_Plan));
      }
    }

    [AttributeLogicalName("ait_individual")]
    [RelationshipSchemaName("ait_ait_clientprofile_ait_referral_Individual")]
    public ait_clientprofile ait_ait_clientprofile_ait_referral_Individual
    {
      get
      {
        return this.GetRelatedEntity<ait_clientprofile>(nameof (ait_ait_clientprofile_ait_referral_Individual), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_clientprofile_ait_referral_Individual));
        this.SetRelatedEntity<ait_clientprofile>(nameof (ait_ait_clientprofile_ait_referral_Individual), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_clientprofile_ait_referral_Individual));
      }
    }

    [AttributeLogicalName("ait_familygroup")]
    [RelationshipSchemaName("ait_ait_familygroup_ait_referral_FamilyGroup")]
    public ait_familygroup ait_ait_familygroup_ait_referral_FamilyGroup
    {
      get
      {
        return this.GetRelatedEntity<ait_familygroup>(nameof (ait_ait_familygroup_ait_referral_FamilyGroup), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_familygroup_ait_referral_FamilyGroup));
        this.SetRelatedEntity<ait_familygroup>(nameof (ait_ait_familygroup_ait_referral_FamilyGroup), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_familygroup_ait_referral_FamilyGroup));
      }
    }

    [AttributeLogicalName("ait_goal")]
    [RelationshipSchemaName("ait_ait_goal_ait_referral_Goal")]
    public ait_goal ait_ait_goal_ait_referral_Goal
    {
      get
      {
        return this.GetRelatedEntity<ait_goal>(nameof (ait_ait_goal_ait_referral_Goal), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_goal_ait_referral_Goal));
        this.SetRelatedEntity<ait_goal>(nameof (ait_ait_goal_ait_referral_Goal), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_goal_ait_referral_Goal));
      }
    }

    [AttributeLogicalName("ait_outcome")]
    [RelationshipSchemaName("ait_ait_outcome_ait_referral_Outcome")]
    public ait_outcome ait_ait_outcome_ait_referral_Outcome
    {
      get
      {
        return this.GetRelatedEntity<ait_outcome>(nameof (ait_ait_outcome_ait_referral_Outcome), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_outcome_ait_referral_Outcome));
        this.SetRelatedEntity<ait_outcome>(nameof (ait_ait_outcome_ait_referral_Outcome), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_outcome_ait_referral_Outcome));
      }
    }

    [AttributeLogicalName("ait_program")]
    [RelationshipSchemaName("ait_ait_program_ait_referral_Program")]
    public ait_program ait_ait_program_ait_referral_Program
    {
      get
      {
        return this.GetRelatedEntity<ait_program>(nameof (ait_ait_program_ait_referral_Program), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_program_ait_referral_Program));
        this.SetRelatedEntity<ait_program>(nameof (ait_ait_program_ait_referral_Program), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_program_ait_referral_Program));
      }
    }

    [AttributeLogicalName("ait_referredtocompany")]
    [RelationshipSchemaName("ait_company_ait_referral_referredtocompany")]
    public ait_company ait_company_ait_referral_referredtocompany
    {
      get
      {
        return this.GetRelatedEntity<ait_company>(nameof (ait_company_ait_referral_referredtocompany), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_company_ait_referral_referredtocompany));
        this.SetRelatedEntity<ait_company>(nameof (ait_company_ait_referral_referredtocompany), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_company_ait_referral_referredtocompany));
      }
    }

    [AttributeLogicalName("ait_servicerequest")]
    [RelationshipSchemaName("ait_servicerequest_ait_referral_ServiceRequest")]
    public ait_servicerequest ait_servicerequest_ait_referral_ServiceRequest
    {
      get
      {
        return this.GetRelatedEntity<ait_servicerequest>(nameof (ait_servicerequest_ait_referral_ServiceRequest), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_ait_referral_ServiceRequest));
        this.SetRelatedEntity<ait_servicerequest>(nameof (ait_servicerequest_ait_referral_ServiceRequest), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_ait_referral_ServiceRequest));
      }
    }

    [AttributeLogicalName("ait_approver")]
    [RelationshipSchemaName("ait_systemuser_ait_referral_Approver")]
    public SystemUser ait_systemuser_ait_referral_Approver
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (ait_systemuser_ait_referral_Approver), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_systemuser_ait_referral_Approver));
        this.SetRelatedEntity<SystemUser>(nameof (ait_systemuser_ait_referral_Approver), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_systemuser_ait_referral_Approver));
      }
    }

    [AttributeLogicalName("ait_caseworker")]
    [RelationshipSchemaName("ait_systemuser_ait_referral_Caseworker")]
    public SystemUser ait_systemuser_ait_referral_Caseworker
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (ait_systemuser_ait_referral_Caseworker), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_systemuser_ait_referral_Caseworker));
        this.SetRelatedEntity<SystemUser>(nameof (ait_systemuser_ait_referral_Caseworker), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_systemuser_ait_referral_Caseworker));
      }
    }

    [AttributeLogicalName("ait_referredby")]
    [RelationshipSchemaName("ait_systemuser_ait_referral_ReferredBy")]
    public SystemUser ait_systemuser_ait_referral_ReferredBy
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (ait_systemuser_ait_referral_ReferredBy), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_systemuser_ait_referral_ReferredBy));
        this.SetRelatedEntity<SystemUser>(nameof (ait_systemuser_ait_referral_ReferredBy), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_systemuser_ait_referral_ReferredBy));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_referral")]
    public BusinessUnit business_unit_ait_referral
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_referral), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_referral_createdby")]
    public SystemUser lk_ait_referral_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_referral_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_referral_createdonbehalfby")]
    public SystemUser lk_ait_referral_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_referral_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_referral_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_referral_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_referral_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_referral_modifiedby")]
    public SystemUser lk_ait_referral_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_referral_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_referral_modifiedonbehalfby")]
    public SystemUser lk_ait_referral_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_referral_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_referral_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_referral_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_referral_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_referral")]
    public Team team_ait_referral
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_referral), new EntityRole?());
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_ait_referral")]
    public TransactionCurrency TransactionCurrency_ait_referral
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_ait_referral), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_ait_referral));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_ait_referral), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_ait_referral));
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_referral")]
    public SystemUser user_ait_referral
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_ait_referral), new EntityRole?());
    }

    public ait_referral(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_referralid"] = (object) base.Id;
            break;
          case "ait_referralid":
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
