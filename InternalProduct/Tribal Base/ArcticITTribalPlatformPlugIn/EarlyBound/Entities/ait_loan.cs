// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_loan
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_loan")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_loan : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_loan";
    public const string EntitySchemaName = "ait_loan";
    public const string PrimaryIdAttribute = "ait_loanid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_loan()
      : base(nameof (ait_loan))
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

    [AttributeLogicalName("ait_accountingcodeid")]
    public EntityReference ait_accountingcodeid
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_accountingcodeid));
      set
      {
        this.OnPropertyChanging(nameof (ait_accountingcodeid));
        this.SetAttributeValue(nameof (ait_accountingcodeid), (object) value);
        this.OnPropertyChanged(nameof (ait_accountingcodeid));
      }
    }

    [AttributeLogicalName("ait_balance")]
    public Money ait_balance
    {
      get => this.GetAttributeValue<Money>(nameof (ait_balance));
      set
      {
        this.OnPropertyChanging(nameof (ait_balance));
        this.SetAttributeValue(nameof (ait_balance), (object) value);
        this.OnPropertyChanged(nameof (ait_balance));
      }
    }

    [AttributeLogicalName("ait_balance_base")]
    public Money ait_balance_Base => this.GetAttributeValue<Money>("ait_balance_base");

    [AttributeLogicalName("ait_contactid")]
    public EntityReference ait_contactid
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_contactid));
      set
      {
        this.OnPropertyChanging(nameof (ait_contactid));
        this.SetAttributeValue(nameof (ait_contactid), (object) value);
        this.OnPropertyChanged(nameof (ait_contactid));
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

    [AttributeLogicalName("ait_loanamount")]
    public Money ait_loanamount
    {
      get => this.GetAttributeValue<Money>(nameof (ait_loanamount));
      set
      {
        this.OnPropertyChanging(nameof (ait_loanamount));
        this.SetAttributeValue(nameof (ait_loanamount), (object) value);
        this.OnPropertyChanged(nameof (ait_loanamount));
      }
    }

    [AttributeLogicalName("ait_loanamount_base")]
    public Money ait_loanamount_Base => this.GetAttributeValue<Money>("ait_loanamount_base");

    [AttributeLogicalName("ait_loandate")]
    public DateTime? ait_loandate
    {
      get => this.GetAttributeValue<DateTime?>(nameof (ait_loandate));
      set
      {
        this.OnPropertyChanging(nameof (ait_loandate));
        this.SetAttributeValue(nameof (ait_loandate), (object) value);
        this.OnPropertyChanged(nameof (ait_loandate));
      }
    }

    [AttributeLogicalName("ait_loanid")]
    public Guid? ait_loanId
    {
      get => this.GetAttributeValue<Guid?>("ait_loanid");
      set
      {
        this.OnPropertyChanging(nameof (ait_loanId));
        this.SetAttributeValue("ait_loanid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_loanId));
      }
    }

    [AttributeLogicalName("ait_loanid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_loanId = new Guid?(value);
    }

    [AttributeLogicalName("ait_loantypeid")]
    public EntityReference ait_loantypeid
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_loantypeid));
      set
      {
        this.OnPropertyChanging(nameof (ait_loantypeid));
        this.SetAttributeValue(nameof (ait_loantypeid), (object) value);
        this.OnPropertyChanged(nameof (ait_loantypeid));
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

    [AttributeLogicalName("ait_paymentamount")]
    public Money ait_paymentamount
    {
      get => this.GetAttributeValue<Money>(nameof (ait_paymentamount));
      set
      {
        this.OnPropertyChanging(nameof (ait_paymentamount));
        this.SetAttributeValue(nameof (ait_paymentamount), (object) value);
        this.OnPropertyChanged(nameof (ait_paymentamount));
      }
    }

    [AttributeLogicalName("ait_paymentamount_base")]
    public Money ait_paymentamount_Base => this.GetAttributeValue<Money>("ait_paymentamount_base");

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
    public ait_loanState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_loanState?((ait_loanState) Enum.ToObject(typeof (ait_loanState), attributeValue.Value)) : new ait_loanState?();
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

    [RelationshipSchemaName("ait_loan_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_loan_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_loan_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_loan_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_loan_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_loan_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_loan_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_loan_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_loan_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_loan_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_loan_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_loan_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_loan_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_loan_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_loan_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_loan_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_loan_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_loan_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_loan_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_loan_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_loan_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_loan_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_loan_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_loan_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_loan_loandetail")]
    public IEnumerable<ait_loandetail> ait_loan_loandetail
    {
      get
      {
        return this.GetRelatedEntities<ait_loandetail>(nameof (ait_loan_loandetail), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_loan_loandetail));
        this.SetRelatedEntities<ait_loandetail>(nameof (ait_loan_loandetail), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_loan_loandetail));
      }
    }

    [RelationshipSchemaName("ait_loan_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_loan_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_loan_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_loan_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_loan_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_loan_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_loan_pmttransactiondeduction")]
    public IEnumerable<ait_pmttransactiondeduction> ait_loan_pmttransactiondeduction
    {
      get
      {
        return this.GetRelatedEntities<ait_pmttransactiondeduction>(nameof (ait_loan_pmttransactiondeduction), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_loan_pmttransactiondeduction));
        this.SetRelatedEntities<ait_pmttransactiondeduction>(nameof (ait_loan_pmttransactiondeduction), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_loan_pmttransactiondeduction));
      }
    }

    [RelationshipSchemaName("ait_loan_pmtwithholding")]
    public IEnumerable<ait_pmtwithholding> ait_loan_pmtwithholding
    {
      get
      {
        return this.GetRelatedEntities<ait_pmtwithholding>(nameof (ait_loan_pmtwithholding), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_loan_pmtwithholding));
        this.SetRelatedEntities<ait_pmtwithholding>(nameof (ait_loan_pmtwithholding), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_loan_pmtwithholding));
      }
    }

    [RelationshipSchemaName("ait_loan_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_loan_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_loan_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_loan_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_loan_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_loan_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_loan_ProcessSession")]
    public IEnumerable<ProcessSession> ait_loan_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_loan_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_loan_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_loan_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_loan_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_loan_SyncErrors")]
    public IEnumerable<SyncError> ait_loan_SyncErrors
    {
      get => this.GetRelatedEntities<SyncError>(nameof (ait_loan_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_loan_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_loan_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_loan_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_loan_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_loan_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_loan_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_loan_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_loan_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_loan_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_accountingcodeid")]
    [RelationshipSchemaName("ait_accountingcode_loan")]
    public ait_accountingcode ait_accountingcode_loan
    {
      get
      {
        return this.GetRelatedEntity<ait_accountingcode>(nameof (ait_accountingcode_loan), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_accountingcode_loan));
        this.SetRelatedEntity<ait_accountingcode>(nameof (ait_accountingcode_loan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_accountingcode_loan));
      }
    }

    [AttributeLogicalName("ait_contactid")]
    [RelationshipSchemaName("ait_contact_loan")]
    public Contact ait_contact_loan
    {
      get => this.GetRelatedEntity<Contact>(nameof (ait_contact_loan), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_contact_loan));
        this.SetRelatedEntity<Contact>(nameof (ait_contact_loan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contact_loan));
      }
    }

    [AttributeLogicalName("ait_loantypeid")]
    [RelationshipSchemaName("ait_loantype_loan")]
    public ait_loantype ait_loantype_loan
    {
      get => this.GetRelatedEntity<ait_loantype>(nameof (ait_loantype_loan), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_loantype_loan));
        this.SetRelatedEntity<ait_loantype>(nameof (ait_loantype_loan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_loantype_loan));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_loan")]
    public BusinessUnit business_unit_ait_loan
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_loan), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_loan_createdby")]
    public SystemUser lk_ait_loan_createdby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_ait_loan_createdby), new EntityRole?());
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_loan_createdonbehalfby")]
    public SystemUser lk_ait_loan_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_loan_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_loan_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_loan_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_loan_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_loan_modifiedby")]
    public SystemUser lk_ait_loan_modifiedby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_ait_loan_modifiedby), new EntityRole?());
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_loan_modifiedonbehalfby")]
    public SystemUser lk_ait_loan_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_loan_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_loan_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_loan_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_loan_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_loan")]
    public Team team_ait_loan
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_loan), new EntityRole?());
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_ait_loan")]
    public TransactionCurrency TransactionCurrency_ait_loan
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_ait_loan), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_ait_loan));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_ait_loan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_ait_loan));
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_loan")]
    public SystemUser user_ait_loan
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_ait_loan), new EntityRole?());
    }

    public ait_loan(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_loanid"] = (object) base.Id;
            break;
          case "ait_loanid":
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
