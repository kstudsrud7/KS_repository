// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_pmtevent
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_pmtevent")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_pmtevent : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_pmtevent";
    public const string EntitySchemaName = "ait_pmtevent";
    public const string PrimaryIdAttribute = "ait_pmteventid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_pmtevent()
      : base(nameof (ait_pmtevent))
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

    [AttributeLogicalName("ait_distributionbudgetamount")]
    public Money ait_DistributionBudgetAmount
    {
      get => this.GetAttributeValue<Money>("ait_distributionbudgetamount");
      set
      {
        this.OnPropertyChanging(nameof (ait_DistributionBudgetAmount));
        this.SetAttributeValue("ait_distributionbudgetamount", (object) value);
        this.OnPropertyChanged(nameof (ait_DistributionBudgetAmount));
      }
    }

    [AttributeLogicalName("ait_distributionbudgetamount_base")]
    public Money ait_distributionbudgetamount_Base
    {
      get => this.GetAttributeValue<Money>("ait_distributionbudgetamount_base");
    }

    [AttributeLogicalName("ait_finalizedbyid")]
    public EntityReference ait_finalizedbyid
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_finalizedbyid));
      set
      {
        this.OnPropertyChanging(nameof (ait_finalizedbyid));
        this.SetAttributeValue(nameof (ait_finalizedbyid), (object) value);
        this.OnPropertyChanged(nameof (ait_finalizedbyid));
      }
    }

    [AttributeLogicalName("ait_generateendtime")]
    public DateTime? ait_GenerateEndTime
    {
      get => this.GetAttributeValue<DateTime?>("ait_generateendtime");
      set
      {
        this.OnPropertyChanging(nameof (ait_GenerateEndTime));
        this.SetAttributeValue("ait_generateendtime", (object) value);
        this.OnPropertyChanged(nameof (ait_GenerateEndTime));
      }
    }

    [AttributeLogicalName("ait_generatestarttime")]
    public DateTime? ait_GenerateStartTime
    {
      get => this.GetAttributeValue<DateTime?>("ait_generatestarttime");
      set
      {
        this.OnPropertyChanging(nameof (ait_GenerateStartTime));
        this.SetAttributeValue("ait_generatestarttime", (object) value);
        this.OnPropertyChanged(nameof (ait_GenerateStartTime));
      }
    }

    [AttributeLogicalName("ait_iteration")]
    public int? ait_Iteration
    {
      get => this.GetAttributeValue<int?>("ait_iteration");
      set
      {
        this.OnPropertyChanging(nameof (ait_Iteration));
        this.SetAttributeValue("ait_iteration", (object) value);
        this.OnPropertyChanged(nameof (ait_Iteration));
      }
    }

    [AttributeLogicalName("ait_lastsynchronized")]
    public DateTime? ait_LastSynchronized
    {
      get => this.GetAttributeValue<DateTime?>("ait_lastsynchronized");
      set
      {
        this.OnPropertyChanging(nameof (ait_LastSynchronized));
        this.SetAttributeValue("ait_lastsynchronized", (object) value);
        this.OnPropertyChanged(nameof (ait_LastSynchronized));
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

    [AttributeLogicalName("ait_paymentamountoverride")]
    public Money ait_PaymentAmountOverride
    {
      get => this.GetAttributeValue<Money>("ait_paymentamountoverride");
      set
      {
        this.OnPropertyChanging(nameof (ait_PaymentAmountOverride));
        this.SetAttributeValue("ait_paymentamountoverride", (object) value);
        this.OnPropertyChanged(nameof (ait_PaymentAmountOverride));
      }
    }

    [AttributeLogicalName("ait_paymentamountoverride_base")]
    public Money ait_paymentamountoverride_Base
    {
      get => this.GetAttributeValue<Money>("ait_paymentamountoverride_base");
    }

    [AttributeLogicalName("ait_paymentcount")]
    public int? ait_PaymentCount
    {
      get => this.GetAttributeValue<int?>("ait_paymentcount");
      set
      {
        this.OnPropertyChanging(nameof (ait_PaymentCount));
        this.SetAttributeValue("ait_paymentcount", (object) value);
        this.OnPropertyChanged(nameof (ait_PaymentCount));
      }
    }

    [AttributeLogicalName("ait_paymentcount_date")]
    public DateTime? ait_PaymentCount_Date
    {
      get => this.GetAttributeValue<DateTime?>("ait_paymentcount_date");
    }

    [AttributeLogicalName("ait_paymentcount_state")]
    public int? ait_PaymentCount_State => this.GetAttributeValue<int?>("ait_paymentcount_state");

    [AttributeLogicalName("ait_paymenteventdetails")]
    public string ait_PaymentEventDetails
    {
      get => this.GetAttributeValue<string>("ait_paymenteventdetails");
      set
      {
        this.OnPropertyChanging(nameof (ait_PaymentEventDetails));
        this.SetAttributeValue("ait_paymenteventdetails", (object) value);
        this.OnPropertyChanged(nameof (ait_PaymentEventDetails));
      }
    }

    [AttributeLogicalName("ait_paymenttotal")]
    public Money ait_PaymentTotal
    {
      get => this.GetAttributeValue<Money>("ait_paymenttotal");
      set
      {
        this.OnPropertyChanging(nameof (ait_PaymentTotal));
        this.SetAttributeValue("ait_paymenttotal", (object) value);
        this.OnPropertyChanged(nameof (ait_PaymentTotal));
      }
    }

    [AttributeLogicalName("ait_paymenttotal_base")]
    public Money ait_paymenttotal_Base => this.GetAttributeValue<Money>("ait_paymenttotal_base");

    [AttributeLogicalName("ait_paymenttotal_date")]
    public DateTime? ait_PaymentTotal_Date
    {
      get => this.GetAttributeValue<DateTime?>("ait_paymenttotal_date");
    }

    [AttributeLogicalName("ait_paymenttotal_state")]
    public int? ait_PaymentTotal_State => this.GetAttributeValue<int?>("ait_paymenttotal_state");

    [AttributeLogicalName("ait_pmteventid")]
    public Guid? ait_pmteventId
    {
      get => this.GetAttributeValue<Guid?>("ait_pmteventid");
      set
      {
        this.OnPropertyChanging(nameof (ait_pmteventId));
        this.SetAttributeValue("ait_pmteventid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_pmteventId));
      }
    }

    [AttributeLogicalName("ait_pmteventid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_pmteventId = new Guid?(value);
    }

    [AttributeLogicalName("ait_pmtpaymenttype")]
    public EntityReference ait_PmtPaymentType
    {
      get => this.GetAttributeValue<EntityReference>("ait_pmtpaymenttype");
      set
      {
        this.OnPropertyChanging(nameof (ait_PmtPaymentType));
        this.SetAttributeValue("ait_pmtpaymenttype", (object) value);
        this.OnPropertyChanged(nameof (ait_PmtPaymentType));
      }
    }

    [AttributeLogicalName("ait_pmttransactioncount")]
    public int? ait_PmtTransactionCount
    {
      get => this.GetAttributeValue<int?>("ait_pmttransactioncount");
      set
      {
        this.OnPropertyChanging(nameof (ait_PmtTransactionCount));
        this.SetAttributeValue("ait_pmttransactioncount", (object) value);
        this.OnPropertyChanged(nameof (ait_PmtTransactionCount));
      }
    }

    [AttributeLogicalName("ait_pmttransactiondeductioncount")]
    public int? ait_PmtTransactionDeductionCount
    {
      get => this.GetAttributeValue<int?>("ait_pmttransactiondeductioncount");
      set
      {
        this.OnPropertyChanging(nameof (ait_PmtTransactionDeductionCount));
        this.SetAttributeValue("ait_pmttransactiondeductioncount", (object) value);
        this.OnPropertyChanged(nameof (ait_PmtTransactionDeductionCount));
      }
    }

    [AttributeLogicalName("ait_processedbyid")]
    public EntityReference ait_processedbyid
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_processedbyid));
      set
      {
        this.OnPropertyChanging(nameof (ait_processedbyid));
        this.SetAttributeValue(nameof (ait_processedbyid), (object) value);
        this.OnPropertyChanged(nameof (ait_processedbyid));
      }
    }

    [AttributeLogicalName("ait_processingerror")]
    public string ait_processingerror
    {
      get => this.GetAttributeValue<string>(nameof (ait_processingerror));
      set
      {
        this.OnPropertyChanging(nameof (ait_processingerror));
        this.SetAttributeValue(nameof (ait_processingerror), (object) value);
        this.OnPropertyChanged(nameof (ait_processingerror));
      }
    }

    [AttributeLogicalName("ait_processstage")]
    public OptionSetValue ait_ProcessStage
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_processstage");
      set
      {
        this.OnPropertyChanging(nameof (ait_ProcessStage));
        this.SetAttributeValue("ait_processstage", (object) value);
        this.OnPropertyChanged(nameof (ait_ProcessStage));
      }
    }

    [AttributeLogicalName("ait_totalnetpaidamount")]
    public Money ait_TotalNetPaidAmount
    {
      get => this.GetAttributeValue<Money>("ait_totalnetpaidamount");
      set
      {
        this.OnPropertyChanging(nameof (ait_TotalNetPaidAmount));
        this.SetAttributeValue("ait_totalnetpaidamount", (object) value);
        this.OnPropertyChanged(nameof (ait_TotalNetPaidAmount));
      }
    }

    [AttributeLogicalName("ait_totalnetpaidamount_base")]
    public Money ait_totalnetpaidamount_Base
    {
      get => this.GetAttributeValue<Money>("ait_totalnetpaidamount_base");
    }

    [AttributeLogicalName("ait_totalpaymentdeductions")]
    public Money ait_TotalPaymentDeductions
    {
      get => this.GetAttributeValue<Money>("ait_totalpaymentdeductions");
      set
      {
        this.OnPropertyChanging(nameof (ait_TotalPaymentDeductions));
        this.SetAttributeValue("ait_totalpaymentdeductions", (object) value);
        this.OnPropertyChanged(nameof (ait_TotalPaymentDeductions));
      }
    }

    [AttributeLogicalName("ait_totalpaymentdeductions_base")]
    public Money ait_totalpaymentdeductions_Base
    {
      get => this.GetAttributeValue<Money>("ait_totalpaymentdeductions_base");
    }

    [AttributeLogicalName("ait_totalpaymentdeductions_date")]
    public DateTime? ait_TotalPaymentDeductions_Date
    {
      get => this.GetAttributeValue<DateTime?>("ait_totalpaymentdeductions_date");
    }

    [AttributeLogicalName("ait_totalpaymentdeductions_state")]
    public int? ait_TotalPaymentDeductions_State
    {
      get => this.GetAttributeValue<int?>("ait_totalpaymentdeductions_state");
    }

    [AttributeLogicalName("ait_totalpcpayments")]
    public Money ait_TotalPmtPayments
    {
      get => this.GetAttributeValue<Money>("ait_totalpcpayments");
      set
      {
        this.OnPropertyChanging(nameof (ait_TotalPmtPayments));
        this.SetAttributeValue("ait_totalpcpayments", (object) value);
        this.OnPropertyChanged(nameof (ait_TotalPmtPayments));
      }
    }

    [AttributeLogicalName("ait_totalpcpayments_base")]
    public Money ait_totalpcpayments_Base
    {
      get => this.GetAttributeValue<Money>("ait_totalpcpayments_base");
    }

    [AttributeLogicalName("ait_transactiondate")]
    public DateTime? ait_TransactionDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_transactiondate");
      set
      {
        this.OnPropertyChanging(nameof (ait_TransactionDate));
        this.SetAttributeValue("ait_transactiondate", (object) value);
        this.OnPropertyChanged(nameof (ait_TransactionDate));
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
    public ait_pmteventState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_pmteventState?((ait_pmteventState) Enum.ToObject(typeof (ait_pmteventState), attributeValue.Value)) : new ait_pmteventState?();
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

    [RelationshipSchemaName("ait_ait_pmtevent_ait_pmttransaction_PmtEvent")]
    public IEnumerable<ait_pmttransaction> ait_ait_pmtevent_ait_pmttransaction_PmtEvent
    {
      get
      {
        return this.GetRelatedEntities<ait_pmttransaction>(nameof (ait_ait_pmtevent_ait_pmttransaction_PmtEvent), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_pmtevent_ait_pmttransaction_PmtEvent));
        this.SetRelatedEntities<ait_pmttransaction>(nameof (ait_ait_pmtevent_ait_pmttransaction_PmtEvent), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_pmtevent_ait_pmttransaction_PmtEvent));
      }
    }

    [RelationshipSchemaName("ait_ait_pmtevent_ait_pmttransactiondeduction_PmtEvent")]
    public IEnumerable<ait_pmttransactiondeduction> ait_ait_pmtevent_ait_pmttransactiondeduction_PmtEvent
    {
      get
      {
        return this.GetRelatedEntities<ait_pmttransactiondeduction>(nameof (ait_ait_pmtevent_ait_pmttransactiondeduction_PmtEvent), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_pmtevent_ait_pmttransactiondeduction_PmtEvent));
        this.SetRelatedEntities<ait_pmttransactiondeduction>(nameof (ait_ait_pmtevent_ait_pmttransactiondeduction_PmtEvent), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_pmtevent_ait_pmttransactiondeduction_PmtEvent));
      }
    }

    [RelationshipSchemaName("ait_pmtevent_Annotations")]
    public IEnumerable<Annotation> ait_pmtevent_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (ait_pmtevent_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtevent_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (ait_pmtevent_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtevent_Annotations));
      }
    }

    [RelationshipSchemaName("ait_pmtevent_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_pmtevent_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_pmtevent_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtevent_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_pmtevent_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtevent_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_pmtevent_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_pmtevent_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_pmtevent_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtevent_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_pmtevent_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtevent_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_pmtevent_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_pmtevent_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_pmtevent_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtevent_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_pmtevent_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtevent_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_pmtevent_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_pmtevent_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_pmtevent_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtevent_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_pmtevent_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtevent_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_pmtevent_ProcessSession")]
    public IEnumerable<ProcessSession> ait_pmtevent_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_pmtevent_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtevent_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_pmtevent_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtevent_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_pmtevent_SyncErrors")]
    public IEnumerable<SyncError> ait_pmtevent_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_pmtevent_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtevent_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_pmtevent_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtevent_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_pmtevent_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_pmtevent_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_pmtevent_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtevent_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_pmtevent_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtevent_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_pmtpaymenttype")]
    [RelationshipSchemaName("ait_ait_pmtpaymenttype_ait_pmtevent_pmtPaymentType")]
    public ait_pmtpaymenttype ait_ait_pmtpaymenttype_ait_pmtevent_pmtPaymentType
    {
      get
      {
        return this.GetRelatedEntity<ait_pmtpaymenttype>(nameof (ait_ait_pmtpaymenttype_ait_pmtevent_pmtPaymentType), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_pmtpaymenttype_ait_pmtevent_pmtPaymentType));
        this.SetRelatedEntity<ait_pmtpaymenttype>(nameof (ait_ait_pmtpaymenttype_ait_pmtevent_pmtPaymentType), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_pmtpaymenttype_ait_pmtevent_pmtPaymentType));
      }
    }

    [AttributeLogicalName("ait_approvedby")]
    [RelationshipSchemaName("ait_systemuser_ait_pmtevent_ApprovedBy")]
    public SystemUser ait_systemuser_ait_pmtevent_ApprovedBy
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (ait_systemuser_ait_pmtevent_ApprovedBy), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_systemuser_ait_pmtevent_ApprovedBy));
        this.SetRelatedEntity<SystemUser>(nameof (ait_systemuser_ait_pmtevent_ApprovedBy), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_systemuser_ait_pmtevent_ApprovedBy));
      }
    }

    [AttributeLogicalName("ait_finalizedbyid")]
    [RelationshipSchemaName("ait_systemuser_pmtevent_finalizedby")]
    public SystemUser ait_systemuser_pmtevent_finalizedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (ait_systemuser_pmtevent_finalizedby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_systemuser_pmtevent_finalizedby));
        this.SetRelatedEntity<SystemUser>(nameof (ait_systemuser_pmtevent_finalizedby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_systemuser_pmtevent_finalizedby));
      }
    }

    [AttributeLogicalName("ait_processedbyid")]
    [RelationshipSchemaName("ait_systemuser_pmtevent_processedby")]
    public SystemUser ait_systemuser_pmtevent_processedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (ait_systemuser_pmtevent_processedby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_systemuser_pmtevent_processedby));
        this.SetRelatedEntity<SystemUser>(nameof (ait_systemuser_pmtevent_processedby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_systemuser_pmtevent_processedby));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_pmtevent")]
    public BusinessUnit business_unit_ait_pmtevent
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_pmtevent), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_pmtevent_createdby")]
    public SystemUser lk_ait_pmtevent_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_pmtevent_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_pmtevent_createdonbehalfby")]
    public SystemUser lk_ait_pmtevent_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_pmtevent_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_pmtevent_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_pmtevent_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_pmtevent_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_pmtevent_modifiedby")]
    public SystemUser lk_ait_pmtevent_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_pmtevent_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_pmtevent_modifiedonbehalfby")]
    public SystemUser lk_ait_pmtevent_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_pmtevent_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_pmtevent_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_pmtevent_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_pmtevent_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_pmtevent")]
    public Team team_ait_pmtevent
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_pmtevent), new EntityRole?());
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_ait_pmtevent")]
    public TransactionCurrency TransactionCurrency_ait_pmtevent
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_ait_pmtevent), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_ait_pmtevent));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_ait_pmtevent), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_ait_pmtevent));
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_pmtevent")]
    public SystemUser user_ait_pmtevent
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_ait_pmtevent), new EntityRole?());
    }

    public ait_pmtevent(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_pmteventid"] = (object) base.Id;
            break;
          case "ait_pmteventid":
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
