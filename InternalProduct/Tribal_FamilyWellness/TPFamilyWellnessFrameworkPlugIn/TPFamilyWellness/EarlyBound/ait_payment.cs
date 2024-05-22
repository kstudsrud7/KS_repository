// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EarlyBound.ait_payment
// Assembly: TPFamilyWellness.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: C0DF2365-4BFC-418D-B654-2FF4D2B8EB1A
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPFamilyWellnessFrameworkPlugIn-A0924F88-EA00-EA11-A82D-000D3A1F0599\TPFamilyWellnessFrameworkPlugIn.dll

using Microsoft.Xrm.Sdk;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.Serialization;

#nullable disable
namespace TPFamilyWellness.EarlyBound
{
  [DataContract]
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_payment")]
  [GeneratedCode("CrmSvcUtil", "9.0.0.9154")]
  public class ait_payment : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_payment";
    public const int EntityTypeCode = 10392;

    public ait_payment()
      : base(nameof (ait_payment))
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

    [AttributeLogicalName("ait_checknumber")]
    public string ait_CheckNumber
    {
      get => this.GetAttributeValue<string>("ait_checknumber");
      set
      {
        this.OnPropertyChanging(nameof (ait_CheckNumber));
        this.SetAttributeValue("ait_checknumber", (object) value);
        this.OnPropertyChanged(nameof (ait_CheckNumber));
      }
    }

    [AttributeLogicalName("ait_comment")]
    public string ait_Comment
    {
      get => this.GetAttributeValue<string>("ait_comment");
      set
      {
        this.OnPropertyChanging(nameof (ait_Comment));
        this.SetAttributeValue("ait_comment", (object) value);
        this.OnPropertyChanged(nameof (ait_Comment));
      }
    }

    [AttributeLogicalName("ait_glaccount")]
    public string ait_GLAccount
    {
      get => this.GetAttributeValue<string>("ait_glaccount");
      set
      {
        this.OnPropertyChanging(nameof (ait_GLAccount));
        this.SetAttributeValue("ait_glaccount", (object) value);
        this.OnPropertyChanged(nameof (ait_GLAccount));
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

    [AttributeLogicalName("ait_howpaid")]
    public OptionSetValue ait_HowPaid
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_howpaid");
      set
      {
        this.OnPropertyChanging(nameof (ait_HowPaid));
        this.SetAttributeValue("ait_howpaid", (object) value);
        this.OnPropertyChanged(nameof (ait_HowPaid));
      }
    }

    [AttributeLogicalName("ait_howpaidotherdescription")]
    public string ait_HowPaidOtherDescription
    {
      get => this.GetAttributeValue<string>("ait_howpaidotherdescription");
      set
      {
        this.OnPropertyChanging(nameof (ait_HowPaidOtherDescription));
        this.SetAttributeValue("ait_howpaidotherdescription", (object) value);
        this.OnPropertyChanged(nameof (ait_HowPaidOtherDescription));
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

    [AttributeLogicalName("ait_payeeaccount")]
    public EntityReference ait_payeeaccount
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_payeeaccount));
      set
      {
        this.OnPropertyChanging(nameof (ait_payeeaccount));
        this.SetAttributeValue(nameof (ait_payeeaccount), (object) value);
        this.OnPropertyChanged(nameof (ait_payeeaccount));
      }
    }

    [AttributeLogicalName("ait_payeetype")]
    public OptionSetValue ait_payeetype
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_payeetype));
      set
      {
        this.OnPropertyChanging(nameof (ait_payeetype));
        this.SetAttributeValue(nameof (ait_payeetype), (object) value);
        this.OnPropertyChanged(nameof (ait_payeetype));
      }
    }

    [AttributeLogicalName("ait_payment_id")]
    public string ait_Payment_ID
    {
      get => this.GetAttributeValue<string>("ait_payment_id");
      set
      {
        this.OnPropertyChanging(nameof (ait_Payment_ID));
        this.SetAttributeValue("ait_payment_id", (object) value);
        this.OnPropertyChanged(nameof (ait_Payment_ID));
      }
    }

    [AttributeLogicalName("ait_paymentamount")]
    public Money ait_PaymentAmount
    {
      get => this.GetAttributeValue<Money>("ait_paymentamount");
      set
      {
        this.OnPropertyChanging(nameof (ait_PaymentAmount));
        this.SetAttributeValue("ait_paymentamount", (object) value);
        this.OnPropertyChanged(nameof (ait_PaymentAmount));
      }
    }

    [AttributeLogicalName("ait_paymentamount_base")]
    public Money ait_paymentamount_Base => this.GetAttributeValue<Money>("ait_paymentamount_base");

    [AttributeLogicalName("ait_paymentdate")]
    public DateTime? ait_PaymentDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_paymentdate");
      set
      {
        this.OnPropertyChanging(nameof (ait_PaymentDate));
        this.SetAttributeValue("ait_paymentdate", (object) value);
        this.OnPropertyChanged(nameof (ait_PaymentDate));
      }
    }

    [AttributeLogicalName("ait_paymentid")]
    public Guid? ait_paymentId
    {
      get => this.GetAttributeValue<Guid?>("ait_paymentid");
      set
      {
        this.OnPropertyChanging(nameof (ait_paymentId));
        this.SetAttributeValue("ait_paymentid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_paymentId));
      }
    }

    [AttributeLogicalName("ait_paymentid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_paymentId = new Guid?(value);
    }

    [AttributeLogicalName("ait_paymentstatus")]
    public OptionSetValue ait_paymentstatus
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_paymentstatus));
      set
      {
        this.OnPropertyChanging(nameof (ait_paymentstatus));
        this.SetAttributeValue(nameof (ait_paymentstatus), (object) value);
        this.OnPropertyChanged(nameof (ait_paymentstatus));
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

    [AttributeLogicalName("ait_reference")]
    public string ait_Reference
    {
      get => this.GetAttributeValue<string>("ait_reference");
      set
      {
        this.OnPropertyChanging(nameof (ait_Reference));
        this.SetAttributeValue("ait_reference", (object) value);
        this.OnPropertyChanged(nameof (ait_Reference));
      }
    }

    [AttributeLogicalName("ait_referral")]
    public EntityReference ait_Referral
    {
      get => this.GetAttributeValue<EntityReference>("ait_referral");
      set
      {
        this.OnPropertyChanging(nameof (ait_Referral));
        this.SetAttributeValue("ait_referral", (object) value);
        this.OnPropertyChanged(nameof (ait_Referral));
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
    public Ait_paymentState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new Ait_paymentState?((Ait_paymentState) Enum.ToObject(typeof (Ait_paymentState), attributeValue.Value)) : new Ait_paymentState?();
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

    [AttributeLogicalName("ait_payeeaccount")]
    [RelationshipSchemaName("ait_account_ait_payment_PayeeAccount")]
    public Account ait_account_ait_payment_PayeeAccount
    {
      get
      {
        return this.GetRelatedEntity<Account>(nameof (ait_account_ait_payment_PayeeAccount), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_account_ait_payment_PayeeAccount));
        this.SetRelatedEntity<Account>(nameof (ait_account_ait_payment_PayeeAccount), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_account_ait_payment_PayeeAccount));
      }
    }

    [AttributeLogicalName("ait_individual")]
    [RelationshipSchemaName("ait_ait_clientprofile_ait_payment_Individual")]
    public ait_clientprofile ait_ait_clientprofile_ait_payment_Individual
    {
      get
      {
        return this.GetRelatedEntity<ait_clientprofile>(nameof (ait_ait_clientprofile_ait_payment_Individual), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_clientprofile_ait_payment_Individual));
        this.SetRelatedEntity<ait_clientprofile>(nameof (ait_ait_clientprofile_ait_payment_Individual), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_clientprofile_ait_payment_Individual));
      }
    }

    [AttributeLogicalName("ait_program")]
    [RelationshipSchemaName("ait_ait_program_ait_payment_Program")]
    public ait_program ait_ait_program_ait_payment_Program
    {
      get
      {
        return this.GetRelatedEntity<ait_program>(nameof (ait_ait_program_ait_payment_Program), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_program_ait_payment_Program));
        this.SetRelatedEntity<ait_program>(nameof (ait_ait_program_ait_payment_Program), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_program_ait_payment_Program));
      }
    }

    [AttributeLogicalName("ait_caseplan")]
    [RelationshipSchemaName("ait_caseplan_ait_payment_plan")]
    public TPFamilyWellness.EarlyBound.ait_caseplan ait_caseplan_ait_payment_plan
    {
      get
      {
        return this.GetRelatedEntity<TPFamilyWellness.EarlyBound.ait_caseplan>(nameof (ait_caseplan_ait_payment_plan), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_caseplan_ait_payment_plan));
        this.SetRelatedEntity<TPFamilyWellness.EarlyBound.ait_caseplan>(nameof (ait_caseplan_ait_payment_plan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_caseplan_ait_payment_plan));
      }
    }

    [AttributeLogicalName("ait_goal")]
    [RelationshipSchemaName("ait_goal_ait_payment_goal")]
    public TPFamilyWellness.EarlyBound.ait_goal ait_goal_ait_payment_goal
    {
      get => this.GetRelatedEntity<TPFamilyWellness.EarlyBound.ait_goal>(nameof (ait_goal_ait_payment_goal), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_goal_ait_payment_goal));
        this.SetRelatedEntity<TPFamilyWellness.EarlyBound.ait_goal>(nameof (ait_goal_ait_payment_goal), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_goal_ait_payment_goal));
      }
    }

    [AttributeLogicalName("ait_referral")]
    [RelationshipSchemaName("ait_referral_ait_payment_Referral")]
    public ait_referral ait_referral_ait_payment_Referral
    {
      get
      {
        return this.GetRelatedEntity<ait_referral>(nameof (ait_referral_ait_payment_Referral), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_referral_ait_payment_Referral));
        this.SetRelatedEntity<ait_referral>(nameof (ait_referral_ait_payment_Referral), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_referral_ait_payment_Referral));
      }
    }

    [AttributeLogicalName("ait_servicerequest")]
    [RelationshipSchemaName("ait_servicerequest_ait_payment_ServiceRequest")]
    public ait_servicerequest ait_servicerequest_ait_payment_ServiceRequest
    {
      get
      {
        return this.GetRelatedEntity<ait_servicerequest>(nameof (ait_servicerequest_ait_payment_ServiceRequest), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_ait_payment_ServiceRequest));
        this.SetRelatedEntity<ait_servicerequest>(nameof (ait_servicerequest_ait_payment_ServiceRequest), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_ait_payment_ServiceRequest));
      }
    }
  }
}
