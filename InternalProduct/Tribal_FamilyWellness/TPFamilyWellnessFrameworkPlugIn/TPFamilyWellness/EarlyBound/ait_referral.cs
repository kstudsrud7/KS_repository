// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EarlyBound.ait_referral
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_referral")]
  [GeneratedCode("CrmSvcUtil", "9.0.0.9154")]
  public class ait_referral : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_referral";
    public const int EntityTypeCode = 10397;

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
    public OptionSetValue ait_Eligible
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_eligible");
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

    [AttributeLogicalName("ait_referredto")]
    public EntityReference ait_ReferredTo
    {
      get => this.GetAttributeValue<EntityReference>("ait_referredto");
      set
      {
        this.OnPropertyChanging(nameof (ait_ReferredTo));
        this.SetAttributeValue("ait_referredto", (object) value);
        this.OnPropertyChanged(nameof (ait_ReferredTo));
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
    public Ait_referralState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new Ait_referralState?((Ait_referralState) Enum.ToObject(typeof (Ait_referralState), attributeValue.Value)) : new Ait_referralState?();
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

    [AttributeLogicalName("ait_referredto")]
    [RelationshipSchemaName("ait_account_ait_referral_ReferredTo")]
    public Account ait_account_ait_referral_ReferredTo
    {
      get
      {
        return this.GetRelatedEntity<Account>(nameof (ait_account_ait_referral_ReferredTo), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_account_ait_referral_ReferredTo));
        this.SetRelatedEntity<Account>(nameof (ait_account_ait_referral_ReferredTo), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_account_ait_referral_ReferredTo));
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
  }
}
