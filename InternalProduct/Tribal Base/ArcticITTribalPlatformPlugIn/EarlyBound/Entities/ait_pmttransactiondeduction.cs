// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_pmttransactiondeduction
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_pmttransactiondeduction")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_pmttransactiondeduction : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_pmttransactiondeduction";
    public const string EntitySchemaName = "ait_pmttransactiondeduction";
    public const string PrimaryIdAttribute = "ait_pmttransactiondeductionid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_pmttransactiondeduction()
      : base(nameof (ait_pmttransactiondeduction))
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

    [AttributeLogicalName("ait_accountingcode")]
    public string ait_AccountingCode
    {
      get => this.GetAttributeValue<string>("ait_accountingcode");
      set
      {
        this.OnPropertyChanging(nameof (ait_AccountingCode));
        this.SetAttributeValue("ait_accountingcode", (object) value);
        this.OnPropertyChanged(nameof (ait_AccountingCode));
      }
    }

    [AttributeLogicalName("ait_amount")]
    public Money ait_Amount
    {
      get => this.GetAttributeValue<Money>("ait_amount");
      set
      {
        this.OnPropertyChanging(nameof (ait_Amount));
        this.SetAttributeValue("ait_amount", (object) value);
        this.OnPropertyChanged(nameof (ait_Amount));
      }
    }

    [AttributeLogicalName("ait_amount_base")]
    public Money ait_amount_Base => this.GetAttributeValue<Money>("ait_amount_base");

    [AttributeLogicalName("ait_bankaccountid")]
    public EntityReference ait_bankaccountid
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_bankaccountid));
      set
      {
        this.OnPropertyChanging(nameof (ait_bankaccountid));
        this.SetAttributeValue(nameof (ait_bankaccountid), (object) value);
        this.OnPropertyChanged(nameof (ait_bankaccountid));
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
    public DateTime? ait_lastsynchronized
    {
      get => this.GetAttributeValue<DateTime?>(nameof (ait_lastsynchronized));
      set
      {
        this.OnPropertyChanging(nameof (ait_lastsynchronized));
        this.SetAttributeValue(nameof (ait_lastsynchronized), (object) value);
        this.OnPropertyChanged(nameof (ait_lastsynchronized));
      }
    }

    [AttributeLogicalName("ait_loanid")]
    public EntityReference ait_loanid
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_loanid));
      set
      {
        this.OnPropertyChanging(nameof (ait_loanid));
        this.SetAttributeValue(nameof (ait_loanid), (object) value);
        this.OnPropertyChanged(nameof (ait_loanid));
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

    [AttributeLogicalName("ait_plannedamount")]
    public Money ait_plannedamount
    {
      get => this.GetAttributeValue<Money>(nameof (ait_plannedamount));
      set
      {
        this.OnPropertyChanging(nameof (ait_plannedamount));
        this.SetAttributeValue(nameof (ait_plannedamount), (object) value);
        this.OnPropertyChanged(nameof (ait_plannedamount));
      }
    }

    [AttributeLogicalName("ait_plannedamount_base")]
    public Money ait_plannedamount_Base => this.GetAttributeValue<Money>("ait_plannedamount_base");

    [AttributeLogicalName("ait_pmtevent")]
    public EntityReference ait_PmtEvent
    {
      get => this.GetAttributeValue<EntityReference>("ait_pmtevent");
      set
      {
        this.OnPropertyChanging(nameof (ait_PmtEvent));
        this.SetAttributeValue("ait_pmtevent", (object) value);
        this.OnPropertyChanged(nameof (ait_PmtEvent));
      }
    }

    [AttributeLogicalName("ait_pmttransaction")]
    public EntityReference ait_PmtTransaction
    {
      get => this.GetAttributeValue<EntityReference>("ait_pmttransaction");
      set
      {
        this.OnPropertyChanging(nameof (ait_PmtTransaction));
        this.SetAttributeValue("ait_pmttransaction", (object) value);
        this.OnPropertyChanged(nameof (ait_PmtTransaction));
      }
    }

    [AttributeLogicalName("ait_pmttransactiondeductionid")]
    public Guid? ait_pmttransactiondeductionId
    {
      get => this.GetAttributeValue<Guid?>("ait_pmttransactiondeductionid");
      set
      {
        this.OnPropertyChanging(nameof (ait_pmttransactiondeductionId));
        this.SetAttributeValue("ait_pmttransactiondeductionid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_pmttransactiondeductionId));
      }
    }

    [AttributeLogicalName("ait_pmttransactiondeductionid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_pmttransactiondeductionId = new Guid?(value);
    }

    [AttributeLogicalName("ait_pmtwithholding")]
    public EntityReference ait_PmtWithholding
    {
      get => this.GetAttributeValue<EntityReference>("ait_pmtwithholding");
      set
      {
        this.OnPropertyChanging(nameof (ait_PmtWithholding));
        this.SetAttributeValue("ait_pmtwithholding", (object) value);
        this.OnPropertyChanged(nameof (ait_PmtWithholding));
      }
    }

    [AttributeLogicalName("ait_priority")]
    public int? ait_Priority
    {
      get => this.GetAttributeValue<int?>("ait_priority");
      set
      {
        this.OnPropertyChanging(nameof (ait_Priority));
        this.SetAttributeValue("ait_priority", (object) value);
        this.OnPropertyChanged(nameof (ait_Priority));
      }
    }

    [AttributeLogicalName("ait_vendorid")]
    public EntityReference ait_vendorid
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_vendorid));
      set
      {
        this.OnPropertyChanging(nameof (ait_vendorid));
        this.SetAttributeValue(nameof (ait_vendorid), (object) value);
        this.OnPropertyChanged(nameof (ait_vendorid));
      }
    }

    [AttributeLogicalName("ait_withholdingtypeid")]
    public EntityReference ait_withholdingtypeid
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_withholdingtypeid));
      set
      {
        this.OnPropertyChanging(nameof (ait_withholdingtypeid));
        this.SetAttributeValue(nameof (ait_withholdingtypeid), (object) value);
        this.OnPropertyChanged(nameof (ait_withholdingtypeid));
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
    public ait_pmttransactiondeductionState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_pmttransactiondeductionState?((ait_pmttransactiondeductionState) Enum.ToObject(typeof (ait_pmttransactiondeductionState), attributeValue.Value)) : new ait_pmttransactiondeductionState?();
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

    [RelationshipSchemaName("ait_pmttransactiondeduction_Annotations")]
    public IEnumerable<Annotation> ait_pmttransactiondeduction_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (ait_pmttransactiondeduction_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmttransactiondeduction_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (ait_pmttransactiondeduction_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmttransactiondeduction_Annotations));
      }
    }

    [RelationshipSchemaName("ait_pmttransactiondeduction_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_pmttransactiondeduction_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_pmttransactiondeduction_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmttransactiondeduction_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_pmttransactiondeduction_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmttransactiondeduction_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_pmttransactiondeduction_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_pmttransactiondeduction_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_pmttransactiondeduction_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmttransactiondeduction_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_pmttransactiondeduction_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmttransactiondeduction_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_pmttransactiondeduction_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_pmttransactiondeduction_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_pmttransactiondeduction_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmttransactiondeduction_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_pmttransactiondeduction_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmttransactiondeduction_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_pmttransactiondeduction_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_pmttransactiondeduction_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_pmttransactiondeduction_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmttransactiondeduction_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_pmttransactiondeduction_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmttransactiondeduction_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_pmttransactiondeduction_ProcessSession")]
    public IEnumerable<ProcessSession> ait_pmttransactiondeduction_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_pmttransactiondeduction_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmttransactiondeduction_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_pmttransactiondeduction_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmttransactiondeduction_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_pmttransactiondeduction_SyncErrors")]
    public IEnumerable<SyncError> ait_pmttransactiondeduction_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_pmttransactiondeduction_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmttransactiondeduction_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_pmttransactiondeduction_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmttransactiondeduction_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_pmttransactiondeduction_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_pmttransactiondeduction_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_pmttransactiondeduction_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmttransactiondeduction_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_pmttransactiondeduction_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmttransactiondeduction_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_pmtevent")]
    [RelationshipSchemaName("ait_ait_pmtevent_ait_pmttransactiondeduction_PmtEvent")]
    public ait_pmtevent ait_ait_pmtevent_ait_pmttransactiondeduction_PmtEvent
    {
      get
      {
        return this.GetRelatedEntity<ait_pmtevent>(nameof (ait_ait_pmtevent_ait_pmttransactiondeduction_PmtEvent), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_pmtevent_ait_pmttransactiondeduction_PmtEvent));
        this.SetRelatedEntity<ait_pmtevent>(nameof (ait_ait_pmtevent_ait_pmttransactiondeduction_PmtEvent), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_pmtevent_ait_pmttransactiondeduction_PmtEvent));
      }
    }

    [AttributeLogicalName("ait_pmttransaction")]
    [RelationshipSchemaName("ait_ait_pmttransaction_ait_pmttransactiondeduction_pmtTransaction")]
    public ait_pmttransaction ait_ait_pmttransaction_ait_pmttransactiondeduction_pmtTransaction
    {
      get
      {
        return this.GetRelatedEntity<ait_pmttransaction>(nameof (ait_ait_pmttransaction_ait_pmttransactiondeduction_pmtTransaction), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_pmttransaction_ait_pmttransactiondeduction_pmtTransaction));
        this.SetRelatedEntity<ait_pmttransaction>(nameof (ait_ait_pmttransaction_ait_pmttransactiondeduction_pmtTransaction), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_pmttransaction_ait_pmttransactiondeduction_pmtTransaction));
      }
    }

    [AttributeLogicalName("ait_pmtwithholding")]
    [RelationshipSchemaName("ait_ait_pmtwithholding_ait_pmttransactiondeduction_PmtWithholding")]
    public ait_pmtwithholding ait_ait_pmtwithholding_ait_pmttransactiondeduction_PmtWithholding
    {
      get
      {
        return this.GetRelatedEntity<ait_pmtwithholding>(nameof (ait_ait_pmtwithholding_ait_pmttransactiondeduction_PmtWithholding), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_pmtwithholding_ait_pmttransactiondeduction_PmtWithholding));
        this.SetRelatedEntity<ait_pmtwithholding>(nameof (ait_ait_pmtwithholding_ait_pmttransactiondeduction_PmtWithholding), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_pmtwithholding_ait_pmttransactiondeduction_PmtWithholding));
      }
    }

    [AttributeLogicalName("ait_bankaccountid")]
    [RelationshipSchemaName("ait_bankaccount_pmttransactiondeducti")]
    public ait_bankaccount ait_bankaccount_pmttransactiondeducti
    {
      get
      {
        return this.GetRelatedEntity<ait_bankaccount>(nameof (ait_bankaccount_pmttransactiondeducti), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_bankaccount_pmttransactiondeducti));
        this.SetRelatedEntity<ait_bankaccount>(nameof (ait_bankaccount_pmttransactiondeducti), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_bankaccount_pmttransactiondeducti));
      }
    }

    [AttributeLogicalName("ait_loanid")]
    [RelationshipSchemaName("ait_loan_pmttransactiondeduction")]
    public ait_loan ait_loan_pmttransactiondeduction
    {
      get
      {
        return this.GetRelatedEntity<ait_loan>(nameof (ait_loan_pmttransactiondeduction), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_loan_pmttransactiondeduction));
        this.SetRelatedEntity<ait_loan>(nameof (ait_loan_pmttransactiondeduction), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_loan_pmttransactiondeduction));
      }
    }

    [AttributeLogicalName("ait_vendorid")]
    [RelationshipSchemaName("ait_vendor_pmttransactiondeduction")]
    public Account ait_vendor_pmttransactiondeduction
    {
      get
      {
        return this.GetRelatedEntity<Account>(nameof (ait_vendor_pmttransactiondeduction), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_vendor_pmttransactiondeduction));
        this.SetRelatedEntity<Account>(nameof (ait_vendor_pmttransactiondeduction), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_vendor_pmttransactiondeduction));
      }
    }

    [AttributeLogicalName("ait_withholdingtypeid")]
    [RelationshipSchemaName("ait_withholdingtype_pmttransactiondeduction")]
    public ait_withholdingtype ait_withholdingtype_pmttransactiondeduction
    {
      get
      {
        return this.GetRelatedEntity<ait_withholdingtype>(nameof (ait_withholdingtype_pmttransactiondeduction), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_withholdingtype_pmttransactiondeduction));
        this.SetRelatedEntity<ait_withholdingtype>(nameof (ait_withholdingtype_pmttransactiondeduction), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_withholdingtype_pmttransactiondeduction));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_pmttransactiondeduction")]
    public BusinessUnit business_unit_ait_pmttransactiondeduction
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_pmttransactiondeduction), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_pmttransactiondeduction_createdby")]
    public SystemUser lk_ait_pmttransactiondeduction_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_pmttransactiondeduction_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_pmttransactiondeduction_createdonbehalfby")]
    public SystemUser lk_ait_pmttransactiondeduction_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_pmttransactiondeduction_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_pmttransactiondeduction_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_pmttransactiondeduction_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_pmttransactiondeduction_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_pmttransactiondeduction_modifiedby")]
    public SystemUser lk_ait_pmttransactiondeduction_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_pmttransactiondeduction_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_pmttransactiondeduction_modifiedonbehalfby")]
    public SystemUser lk_ait_pmttransactiondeduction_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_pmttransactiondeduction_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_pmttransactiondeduction_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_pmttransactiondeduction_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_pmttransactiondeduction_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_pmttransactiondeduction")]
    public Team team_ait_pmttransactiondeduction
    {
      get
      {
        return this.GetRelatedEntity<Team>(nameof (team_ait_pmttransactiondeduction), new EntityRole?());
      }
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_ait_pmttransactiondeduction")]
    public TransactionCurrency TransactionCurrency_ait_pmttransactiondeduction
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_ait_pmttransactiondeduction), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_ait_pmttransactiondeduction));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_ait_pmttransactiondeduction), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_ait_pmttransactiondeduction));
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_pmttransactiondeduction")]
    public SystemUser user_ait_pmttransactiondeduction
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_ait_pmttransactiondeduction), new EntityRole?());
      }
    }

    public ait_pmttransactiondeduction(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_pmttransactiondeductionid"] = (object) base.Id;
            break;
          case "ait_pmttransactiondeductionid":
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
