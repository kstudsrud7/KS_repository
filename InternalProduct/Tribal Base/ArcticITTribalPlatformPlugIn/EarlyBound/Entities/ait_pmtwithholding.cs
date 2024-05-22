// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_pmtwithholding
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_pmtwithholding")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_pmtwithholding : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_pmtwithholding";
    public const string EntitySchemaName = "ait_pmtwithholding";
    public const string PrimaryIdAttribute = "ait_pmtwithholdingid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_pmtwithholding()
      : base(nameof (ait_pmtwithholding))
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
    public EntityReference ait_AccountingCode
    {
      get => this.GetAttributeValue<EntityReference>("ait_accountingcode");
      set
      {
        this.OnPropertyChanging(nameof (ait_AccountingCode));
        this.SetAttributeValue("ait_accountingcode", (object) value);
        this.OnPropertyChanged(nameof (ait_AccountingCode));
      }
    }

    [AttributeLogicalName("ait_amounttype")]
    public OptionSetValue ait_amounttype
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_amounttype));
      set
      {
        this.OnPropertyChanging(nameof (ait_amounttype));
        this.SetAttributeValue(nameof (ait_amounttype), (object) value);
        this.OnPropertyChanged(nameof (ait_amounttype));
      }
    }

    [AttributeLogicalName("ait_bankaccount")]
    public EntityReference ait_BankAccount
    {
      get => this.GetAttributeValue<EntityReference>("ait_bankaccount");
      set
      {
        this.OnPropertyChanging(nameof (ait_BankAccount));
        this.SetAttributeValue("ait_bankaccount", (object) value);
        this.OnPropertyChanged(nameof (ait_BankAccount));
      }
    }

    [AttributeLogicalName("ait_enddate")]
    public DateTime? ait_EndDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_enddate");
      set
      {
        this.OnPropertyChanging(nameof (ait_EndDate));
        this.SetAttributeValue("ait_enddate", (object) value);
        this.OnPropertyChanged(nameof (ait_EndDate));
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

    [AttributeLogicalName("ait_member")]
    public EntityReference ait_Member
    {
      get => this.GetAttributeValue<EntityReference>("ait_member");
      set
      {
        this.OnPropertyChanging(nameof (ait_Member));
        this.SetAttributeValue("ait_member", (object) value);
        this.OnPropertyChanged(nameof (ait_Member));
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

    [AttributeLogicalName("ait_pmteligibility")]
    public EntityReference ait_PmtEligibility
    {
      get => this.GetAttributeValue<EntityReference>("ait_pmteligibility");
      set
      {
        this.OnPropertyChanging(nameof (ait_PmtEligibility));
        this.SetAttributeValue("ait_pmteligibility", (object) value);
        this.OnPropertyChanged(nameof (ait_PmtEligibility));
      }
    }

    [AttributeLogicalName("ait_pmtwithholdingid")]
    public Guid? ait_pmtwithholdingId
    {
      get => this.GetAttributeValue<Guid?>("ait_pmtwithholdingid");
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtwithholdingId));
        this.SetAttributeValue("ait_pmtwithholdingid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_pmtwithholdingId));
      }
    }

    [AttributeLogicalName("ait_pmtwithholdingid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_pmtwithholdingId = new Guid?(value);
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

    [AttributeLogicalName("ait_recurring")]
    public bool? ait_recurring
    {
      get => this.GetAttributeValue<bool?>(nameof (ait_recurring));
      set
      {
        this.OnPropertyChanging(nameof (ait_recurring));
        this.SetAttributeValue(nameof (ait_recurring), (object) value);
        this.OnPropertyChanged(nameof (ait_recurring));
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

    [AttributeLogicalName("ait_systemgenerated")]
    public bool? ait_SystemGenerated
    {
      get => this.GetAttributeValue<bool?>("ait_systemgenerated");
      set
      {
        this.OnPropertyChanging(nameof (ait_SystemGenerated));
        this.SetAttributeValue("ait_systemgenerated", (object) value);
        this.OnPropertyChanged(nameof (ait_SystemGenerated));
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

    [AttributeLogicalName("ait_withholdingamount")]
    public Money ait_WithholdingAmount
    {
      get => this.GetAttributeValue<Money>("ait_withholdingamount");
      set
      {
        this.OnPropertyChanging(nameof (ait_WithholdingAmount));
        this.SetAttributeValue("ait_withholdingamount", (object) value);
        this.OnPropertyChanged(nameof (ait_WithholdingAmount));
      }
    }

    [AttributeLogicalName("ait_withholdingamount_base")]
    public Money ait_withholdingamount_Base
    {
      get => this.GetAttributeValue<Money>("ait_withholdingamount_base");
    }

    [AttributeLogicalName("ait_withholdingpercentage")]
    public Decimal? ait_withholdingpercentage
    {
      get => this.GetAttributeValue<Decimal?>(nameof (ait_withholdingpercentage));
      set
      {
        this.OnPropertyChanging(nameof (ait_withholdingpercentage));
        this.SetAttributeValue(nameof (ait_withholdingpercentage), (object) value);
        this.OnPropertyChanged(nameof (ait_withholdingpercentage));
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
    public ait_pmtwithholdingState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_pmtwithholdingState?((ait_pmtwithholdingState) Enum.ToObject(typeof (ait_pmtwithholdingState), attributeValue.Value)) : new ait_pmtwithholdingState?();
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

    [RelationshipSchemaName("ait_ait_pmtwithholding_ait_pmttransactiondeduction_PmtWithholding")]
    public IEnumerable<ait_pmttransactiondeduction> ait_ait_pmtwithholding_ait_pmttransactiondeduction_PmtWithholding
    {
      get
      {
        return this.GetRelatedEntities<ait_pmttransactiondeduction>(nameof (ait_ait_pmtwithholding_ait_pmttransactiondeduction_PmtWithholding), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_pmtwithholding_ait_pmttransactiondeduction_PmtWithholding));
        this.SetRelatedEntities<ait_pmttransactiondeduction>(nameof (ait_ait_pmtwithholding_ait_pmttransactiondeduction_PmtWithholding), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_pmtwithholding_ait_pmttransactiondeduction_PmtWithholding));
      }
    }

    [RelationshipSchemaName("ait_ait_pmtwithholding_ait_pmtwithholdingoverride_PmtWithholding")]
    public IEnumerable<ait_pmtwithholdingoverride> ait_ait_pmtwithholding_ait_pmtwithholdingoverride_PmtWithholding
    {
      get
      {
        return this.GetRelatedEntities<ait_pmtwithholdingoverride>(nameof (ait_ait_pmtwithholding_ait_pmtwithholdingoverride_PmtWithholding), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_pmtwithholding_ait_pmtwithholdingoverride_PmtWithholding));
        this.SetRelatedEntities<ait_pmtwithholdingoverride>(nameof (ait_ait_pmtwithholding_ait_pmtwithholdingoverride_PmtWithholding), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_pmtwithholding_ait_pmtwithholdingoverride_PmtWithholding));
      }
    }

    [RelationshipSchemaName("ait_pmtwithholding_Annotations")]
    public IEnumerable<Annotation> ait_pmtwithholding_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (ait_pmtwithholding_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtwithholding_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (ait_pmtwithholding_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtwithholding_Annotations));
      }
    }

    [RelationshipSchemaName("ait_pmtwithholding_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_pmtwithholding_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_pmtwithholding_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtwithholding_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_pmtwithholding_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtwithholding_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_pmtwithholding_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_pmtwithholding_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_pmtwithholding_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtwithholding_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_pmtwithholding_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtwithholding_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_pmtwithholding_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_pmtwithholding_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_pmtwithholding_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtwithholding_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_pmtwithholding_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtwithholding_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_pmtwithholding_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_pmtwithholding_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_pmtwithholding_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtwithholding_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_pmtwithholding_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtwithholding_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_pmtwithholding_ProcessSession")]
    public IEnumerable<ProcessSession> ait_pmtwithholding_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_pmtwithholding_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtwithholding_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_pmtwithholding_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtwithholding_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_pmtwithholding_SyncErrors")]
    public IEnumerable<SyncError> ait_pmtwithholding_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_pmtwithholding_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtwithholding_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_pmtwithholding_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtwithholding_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_pmtwithholding_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_pmtwithholding_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_pmtwithholding_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtwithholding_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_pmtwithholding_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtwithholding_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_accountingcode")]
    [RelationshipSchemaName("ait_ait_accountingcode_ait_pmtwithholding_AccountingCode")]
    public ait_accountingcode ait_ait_accountingcode_ait_pmtwithholding_AccountingCode
    {
      get
      {
        return this.GetRelatedEntity<ait_accountingcode>(nameof (ait_ait_accountingcode_ait_pmtwithholding_AccountingCode), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_accountingcode_ait_pmtwithholding_AccountingCode));
        this.SetRelatedEntity<ait_accountingcode>(nameof (ait_ait_accountingcode_ait_pmtwithholding_AccountingCode), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_accountingcode_ait_pmtwithholding_AccountingCode));
      }
    }

    [AttributeLogicalName("ait_bankaccount")]
    [RelationshipSchemaName("ait_ait_bankaccount_ait_pmtwithholding_BankAccount")]
    public ait_bankaccount ait_ait_bankaccount_ait_pmtwithholding_BankAccount
    {
      get
      {
        return this.GetRelatedEntity<ait_bankaccount>(nameof (ait_ait_bankaccount_ait_pmtwithholding_BankAccount), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_bankaccount_ait_pmtwithholding_BankAccount));
        this.SetRelatedEntity<ait_bankaccount>(nameof (ait_ait_bankaccount_ait_pmtwithholding_BankAccount), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_bankaccount_ait_pmtwithholding_BankAccount));
      }
    }

    [AttributeLogicalName("ait_pmteligibility")]
    [RelationshipSchemaName("ait_ait_pmteligibility_ait_pmtwithholding_PmtEligibility")]
    public ait_pmteligibility ait_ait_pmteligibility_ait_pmtwithholding_PmtEligibility
    {
      get
      {
        return this.GetRelatedEntity<ait_pmteligibility>(nameof (ait_ait_pmteligibility_ait_pmtwithholding_PmtEligibility), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_pmteligibility_ait_pmtwithholding_PmtEligibility));
        this.SetRelatedEntity<ait_pmteligibility>(nameof (ait_ait_pmteligibility_ait_pmtwithholding_PmtEligibility), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_pmteligibility_ait_pmtwithholding_PmtEligibility));
      }
    }

    [AttributeLogicalName("ait_member")]
    [RelationshipSchemaName("ait_contact_ait_pmtwithholding_Member")]
    public Contact ait_contact_ait_pmtwithholding_Member
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (ait_contact_ait_pmtwithholding_Member), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contact_ait_pmtwithholding_Member));
        this.SetRelatedEntity<Contact>(nameof (ait_contact_ait_pmtwithholding_Member), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contact_ait_pmtwithholding_Member));
      }
    }

    [AttributeLogicalName("ait_loanid")]
    [RelationshipSchemaName("ait_loan_pmtwithholding")]
    public ait_loan ait_loan_pmtwithholding
    {
      get => this.GetRelatedEntity<ait_loan>(nameof (ait_loan_pmtwithholding), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_loan_pmtwithholding));
        this.SetRelatedEntity<ait_loan>(nameof (ait_loan_pmtwithholding), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_loan_pmtwithholding));
      }
    }

    [AttributeLogicalName("ait_vendorid")]
    [RelationshipSchemaName("ait_vendor_pmtwithholding")]
    public Account ait_vendor_pmtwithholding
    {
      get => this.GetRelatedEntity<Account>(nameof (ait_vendor_pmtwithholding), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_vendor_pmtwithholding));
        this.SetRelatedEntity<Account>(nameof (ait_vendor_pmtwithholding), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_vendor_pmtwithholding));
      }
    }

    [AttributeLogicalName("ait_withholdingtypeid")]
    [RelationshipSchemaName("ait_withholdingtype_pmtwithholding")]
    public ait_withholdingtype ait_withholdingtype_pmtwithholding
    {
      get
      {
        return this.GetRelatedEntity<ait_withholdingtype>(nameof (ait_withholdingtype_pmtwithholding), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_withholdingtype_pmtwithholding));
        this.SetRelatedEntity<ait_withholdingtype>(nameof (ait_withholdingtype_pmtwithholding), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_withholdingtype_pmtwithholding));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_pmtwithholding")]
    public BusinessUnit business_unit_ait_pmtwithholding
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_pmtwithholding), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_pmtwithholding_createdby")]
    public SystemUser lk_ait_pmtwithholding_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_pmtwithholding_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_pmtwithholding_createdonbehalfby")]
    public SystemUser lk_ait_pmtwithholding_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_pmtwithholding_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_pmtwithholding_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_pmtwithholding_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_pmtwithholding_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_pmtwithholding_modifiedby")]
    public SystemUser lk_ait_pmtwithholding_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_pmtwithholding_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_pmtwithholding_modifiedonbehalfby")]
    public SystemUser lk_ait_pmtwithholding_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_pmtwithholding_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_pmtwithholding_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_pmtwithholding_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_pmtwithholding_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_pmtwithholding")]
    public Team team_ait_pmtwithholding
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_pmtwithholding), new EntityRole?());
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_ait_pmtwithholding")]
    public TransactionCurrency TransactionCurrency_ait_pmtwithholding
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_ait_pmtwithholding), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_ait_pmtwithholding));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_ait_pmtwithholding), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_ait_pmtwithholding));
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_pmtwithholding")]
    public SystemUser user_ait_pmtwithholding
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_ait_pmtwithholding), new EntityRole?());
    }

    public ait_pmtwithholding(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_pmtwithholdingid"] = (object) base.Id;
            break;
          case "ait_pmtwithholdingid":
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
