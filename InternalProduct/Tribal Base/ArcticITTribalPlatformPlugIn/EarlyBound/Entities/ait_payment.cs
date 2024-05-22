// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_payment
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_payment")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_payment : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_payment";
    public const string EntitySchemaName = "ait_payment";
    public const string PrimaryIdAttribute = "ait_paymentid";
    public const string PrimaryNameAttribute = "ait_name";

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

    [AttributeLogicalName("ait_denialdate")]
    public DateTime? ait_DenialDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_denialdate");
      set
      {
        this.OnPropertyChanging(nameof (ait_DenialDate));
        this.SetAttributeValue("ait_denialdate", (object) value);
        this.OnPropertyChanged(nameof (ait_DenialDate));
      }
    }

    [AttributeLogicalName("ait_denialreason")]
    public string ait_DenialReason
    {
      get => this.GetAttributeValue<string>("ait_denialreason");
      set
      {
        this.OnPropertyChanging(nameof (ait_DenialReason));
        this.SetAttributeValue("ait_denialreason", (object) value);
        this.OnPropertyChanged(nameof (ait_DenialReason));
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

    [AttributeLogicalName("ait_payeeclientprofile")]
    public EntityReference ait_payeeclientprofile
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_payeeclientprofile));
      set
      {
        this.OnPropertyChanging(nameof (ait_payeeclientprofile));
        this.SetAttributeValue(nameof (ait_payeeclientprofile), (object) value);
        this.OnPropertyChanged(nameof (ait_payeeclientprofile));
      }
    }

    [AttributeLogicalName("ait_payeecompany")]
    public EntityReference ait_payeecompany
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_payeecompany));
      set
      {
        this.OnPropertyChanging(nameof (ait_payeecompany));
        this.SetAttributeValue(nameof (ait_payeecompany), (object) value);
        this.OnPropertyChanged(nameof (ait_payeecompany));
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

    [AttributeLogicalName("ait_requestedpaymentamount")]
    public Money ait_RequestedPaymentAmount
    {
      get => this.GetAttributeValue<Money>("ait_requestedpaymentamount");
      set
      {
        this.OnPropertyChanging(nameof (ait_RequestedPaymentAmount));
        this.SetAttributeValue("ait_requestedpaymentamount", (object) value);
        this.OnPropertyChanged(nameof (ait_RequestedPaymentAmount));
      }
    }

    [AttributeLogicalName("ait_requestedpaymentamount_base")]
    public Money ait_requestedpaymentamount_Base
    {
      get => this.GetAttributeValue<Money>("ait_requestedpaymentamount_base");
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
    public ait_paymentState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_paymentState?((ait_paymentState) Enum.ToObject(typeof (ait_paymentState), attributeValue.Value)) : new ait_paymentState?();
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

    [RelationshipSchemaName("ait_ait_payment_ait_placement_Payment")]
    public IEnumerable<ait_placement> ait_ait_payment_ait_placement_Payment
    {
      get
      {
        return this.GetRelatedEntities<ait_placement>(nameof (ait_ait_payment_ait_placement_Payment), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_payment_ait_placement_Payment));
        this.SetRelatedEntities<ait_placement>(nameof (ait_ait_payment_ait_placement_Payment), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_payment_ait_placement_Payment));
      }
    }

    [RelationshipSchemaName("ait_payment_ActivityParties")]
    public IEnumerable<ActivityParty> ait_payment_ActivityParties
    {
      get
      {
        return this.GetRelatedEntities<ActivityParty>(nameof (ait_payment_ActivityParties), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_payment_ActivityParties));
        this.SetRelatedEntities<ActivityParty>(nameof (ait_payment_ActivityParties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_payment_ActivityParties));
      }
    }

    [RelationshipSchemaName("ait_payment_Annotations")]
    public IEnumerable<Annotation> ait_payment_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (ait_payment_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_payment_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (ait_payment_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_payment_Annotations));
      }
    }

    [RelationshipSchemaName("ait_payment_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_payment_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_payment_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_payment_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_payment_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_payment_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_payment_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_payment_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_payment_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_payment_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_payment_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_payment_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_payment_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_payment_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_payment_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_payment_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_payment_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_payment_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_payment_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_payment_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_payment_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_payment_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_payment_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_payment_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_payment_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_payment_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_payment_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_payment_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_payment_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_payment_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_payment_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_payment_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_payment_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_payment_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_payment_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_payment_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_payment_ProcessSession")]
    public IEnumerable<ProcessSession> ait_payment_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_payment_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_payment_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_payment_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_payment_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_payment_SyncErrors")]
    public IEnumerable<SyncError> ait_payment_SyncErrors
    {
      get => this.GetRelatedEntities<SyncError>(nameof (ait_payment_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_payment_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_payment_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_payment_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_payment_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_payment_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_payment_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_payment_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_payment_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_payment_UserEntityInstanceDatas));
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
    public ArcticIT.EarlyBound.Entities.ait_caseplan ait_caseplan_ait_payment_plan
    {
      get
      {
        return this.GetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_caseplan>(nameof (ait_caseplan_ait_payment_plan), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_caseplan_ait_payment_plan));
        this.SetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_caseplan>(nameof (ait_caseplan_ait_payment_plan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_caseplan_ait_payment_plan));
      }
    }

    [AttributeLogicalName("ait_payeecompany")]
    [RelationshipSchemaName("ait_company_ait_payment_payeecompany")]
    public ait_company ait_company_ait_payment_payeecompany
    {
      get
      {
        return this.GetRelatedEntity<ait_company>(nameof (ait_company_ait_payment_payeecompany), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_company_ait_payment_payeecompany));
        this.SetRelatedEntity<ait_company>(nameof (ait_company_ait_payment_payeecompany), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_company_ait_payment_payeecompany));
      }
    }

    [AttributeLogicalName("ait_goal")]
    [RelationshipSchemaName("ait_goal_ait_payment_goal")]
    public ArcticIT.EarlyBound.Entities.ait_goal ait_goal_ait_payment_goal
    {
      get => this.GetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_goal>(nameof (ait_goal_ait_payment_goal), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_goal_ait_payment_goal));
        this.SetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_goal>(nameof (ait_goal_ait_payment_goal), new EntityRole?(), value);
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

    [AttributeLogicalName("ait_approver")]
    [RelationshipSchemaName("ait_systemuser_ait_payment_Approver")]
    public SystemUser ait_systemuser_ait_payment_Approver
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (ait_systemuser_ait_payment_Approver), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_systemuser_ait_payment_Approver));
        this.SetRelatedEntity<SystemUser>(nameof (ait_systemuser_ait_payment_Approver), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_systemuser_ait_payment_Approver));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_payment")]
    public BusinessUnit business_unit_ait_payment
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_payment), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_payment_createdby")]
    public SystemUser lk_ait_payment_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_payment_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_payment_createdonbehalfby")]
    public SystemUser lk_ait_payment_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_payment_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_payment_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_payment_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_payment_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_payment_modifiedby")]
    public SystemUser lk_ait_payment_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_payment_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_payment_modifiedonbehalfby")]
    public SystemUser lk_ait_payment_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_payment_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_payment_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_payment_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_payment_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_payment")]
    public Team team_ait_payment
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_payment), new EntityRole?());
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_ait_payment")]
    public TransactionCurrency TransactionCurrency_ait_payment
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_ait_payment), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_ait_payment));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_ait_payment), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_ait_payment));
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_payment")]
    public SystemUser user_ait_payment
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_ait_payment), new EntityRole?());
    }

    public ait_payment(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_paymentid"] = (object) base.Id;
            break;
          case "ait_paymentid":
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
