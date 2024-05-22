// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.TransactionCurrency
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("transactioncurrency")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class TransactionCurrency : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "transactioncurrency";
    public const string EntitySchemaName = "TransactionCurrency";
    public const string PrimaryIdAttribute = "transactioncurrencyid";
    public const string PrimaryNameAttribute = "currencyname";

    public TransactionCurrency()
      : base("transactioncurrency")
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

    [AttributeLogicalName("currencyname")]
    public string CurrencyName
    {
      get => this.GetAttributeValue<string>("currencyname");
      set
      {
        this.OnPropertyChanging(nameof (CurrencyName));
        this.SetAttributeValue("currencyname", (object) value);
        this.OnPropertyChanged(nameof (CurrencyName));
      }
    }

    [AttributeLogicalName("currencyprecision")]
    public int? CurrencyPrecision
    {
      get => this.GetAttributeValue<int?>("currencyprecision");
      set
      {
        this.OnPropertyChanging(nameof (CurrencyPrecision));
        this.SetAttributeValue("currencyprecision", (object) value);
        this.OnPropertyChanged(nameof (CurrencyPrecision));
      }
    }

    [AttributeLogicalName("currencysymbol")]
    public string CurrencySymbol
    {
      get => this.GetAttributeValue<string>("currencysymbol");
      set
      {
        this.OnPropertyChanging(nameof (CurrencySymbol));
        this.SetAttributeValue("currencysymbol", (object) value);
        this.OnPropertyChanged(nameof (CurrencySymbol));
      }
    }

    [AttributeLogicalName("entityimage")]
    public byte[] EntityImage
    {
      get => this.GetAttributeValue<byte[]>("entityimage");
      set
      {
        this.OnPropertyChanging(nameof (EntityImage));
        this.SetAttributeValue("entityimage", (object) value);
        this.OnPropertyChanged(nameof (EntityImage));
      }
    }

    [AttributeLogicalName("entityimage_timestamp")]
    public long? EntityImage_Timestamp => this.GetAttributeValue<long?>("entityimage_timestamp");

    [AttributeLogicalName("entityimage_url")]
    public string EntityImage_URL => this.GetAttributeValue<string>("entityimage_url");

    [AttributeLogicalName("entityimageid")]
    public Guid? EntityImageId => this.GetAttributeValue<Guid?>("entityimageid");

    [AttributeLogicalName("exchangerate")]
    public Decimal? ExchangeRate
    {
      get => this.GetAttributeValue<Decimal?>("exchangerate");
      set
      {
        this.OnPropertyChanging(nameof (ExchangeRate));
        this.SetAttributeValue("exchangerate", (object) value);
        this.OnPropertyChanged(nameof (ExchangeRate));
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

    [AttributeLogicalName("isocurrencycode")]
    public string ISOCurrencyCode
    {
      get => this.GetAttributeValue<string>("isocurrencycode");
      set
      {
        this.OnPropertyChanging(nameof (ISOCurrencyCode));
        this.SetAttributeValue("isocurrencycode", (object) value);
        this.OnPropertyChanged(nameof (ISOCurrencyCode));
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

    [AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get => this.GetAttributeValue<EntityReference>("organizationid");
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

    [AttributeLogicalName("statecode")]
    public TransactionCurrencyState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new TransactionCurrencyState?((TransactionCurrencyState) Enum.ToObject(typeof (TransactionCurrencyState), attributeValue.Value)) : new TransactionCurrencyState?();
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

    [AttributeLogicalName("transactioncurrencyid")]
    public Guid? TransactionCurrencyId
    {
      get => this.GetAttributeValue<Guid?>("transactioncurrencyid");
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrencyId));
        this.SetAttributeValue("transactioncurrencyid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (TransactionCurrencyId));
      }
    }

    [AttributeLogicalName("transactioncurrencyid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.TransactionCurrencyId = new Guid?(value);
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("basecurrency_organization")]
    public IEnumerable<Organization> basecurrency_organization
    {
      get
      {
        return this.GetRelatedEntities<Organization>(nameof (basecurrency_organization), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (basecurrency_organization));
        this.SetRelatedEntities<Organization>(nameof (basecurrency_organization), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (basecurrency_organization));
      }
    }

    [RelationshipSchemaName("transactioncurrency_account")]
    public IEnumerable<Account> transactioncurrency_account
    {
      get
      {
        return this.GetRelatedEntities<Account>(nameof (transactioncurrency_account), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (transactioncurrency_account));
        this.SetRelatedEntities<Account>(nameof (transactioncurrency_account), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (transactioncurrency_account));
      }
    }

    [RelationshipSchemaName("transactioncurrency_actioncard")]
    public IEnumerable<ActionCard> transactioncurrency_actioncard
    {
      get
      {
        return this.GetRelatedEntities<ActionCard>(nameof (transactioncurrency_actioncard), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (transactioncurrency_actioncard));
        this.SetRelatedEntities<ActionCard>(nameof (transactioncurrency_actioncard), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (transactioncurrency_actioncard));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_ActionCardUserState")]
    public IEnumerable<ActionCardUserState> TransactionCurrency_ActionCardUserState
    {
      get
      {
        return this.GetRelatedEntities<ActionCardUserState>(nameof (TransactionCurrency_ActionCardUserState), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_ActionCardUserState));
        this.SetRelatedEntities<ActionCardUserState>(nameof (TransactionCurrency_ActionCardUserState), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_ActionCardUserState));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_ActivityPointer")]
    public IEnumerable<ActivityPointer> TransactionCurrency_ActivityPointer
    {
      get
      {
        return this.GetRelatedEntities<ActivityPointer>(nameof (TransactionCurrency_ActivityPointer), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_ActivityPointer));
        this.SetRelatedEntities<ActivityPointer>(nameof (TransactionCurrency_ActivityPointer), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_ActivityPointer));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_ait_clientprofile")]
    public IEnumerable<ait_clientprofile> TransactionCurrency_ait_clientprofile
    {
      get
      {
        return this.GetRelatedEntities<ait_clientprofile>(nameof (TransactionCurrency_ait_clientprofile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_ait_clientprofile));
        this.SetRelatedEntities<ait_clientprofile>(nameof (TransactionCurrency_ait_clientprofile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_ait_clientprofile));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_ait_contactincomeandexpense")]
    public IEnumerable<ait_contactincomeandexpense> TransactionCurrency_ait_contactincomeandexpense
    {
      get
      {
        return this.GetRelatedEntities<ait_contactincomeandexpense>(nameof (TransactionCurrency_ait_contactincomeandexpense), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_ait_contactincomeandexpense));
        this.SetRelatedEntities<ait_contactincomeandexpense>(nameof (TransactionCurrency_ait_contactincomeandexpense), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_ait_contactincomeandexpense));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_ait_courtfinesandfees")]
    public IEnumerable<ait_courtfinesandfees> TransactionCurrency_ait_courtfinesandfees
    {
      get
      {
        return this.GetRelatedEntities<ait_courtfinesandfees>(nameof (TransactionCurrency_ait_courtfinesandfees), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_ait_courtfinesandfees));
        this.SetRelatedEntities<ait_courtfinesandfees>(nameof (TransactionCurrency_ait_courtfinesandfees), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_ait_courtfinesandfees));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_ait_courtpayments")]
    public IEnumerable<ait_courtpayments> TransactionCurrency_ait_courtpayments
    {
      get
      {
        return this.GetRelatedEntities<ait_courtpayments>(nameof (TransactionCurrency_ait_courtpayments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_ait_courtpayments));
        this.SetRelatedEntities<ait_courtpayments>(nameof (TransactionCurrency_ait_courtpayments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_ait_courtpayments));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_ait_household")]
    public IEnumerable<ait_household> TransactionCurrency_ait_household
    {
      get
      {
        return this.GetRelatedEntities<ait_household>(nameof (TransactionCurrency_ait_household), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_ait_household));
        this.SetRelatedEntities<ait_household>(nameof (TransactionCurrency_ait_household), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_ait_household));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_ait_loan")]
    public IEnumerable<ait_loan> TransactionCurrency_ait_loan
    {
      get
      {
        return this.GetRelatedEntities<ait_loan>(nameof (TransactionCurrency_ait_loan), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_ait_loan));
        this.SetRelatedEntities<ait_loan>(nameof (TransactionCurrency_ait_loan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_ait_loan));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_ait_loandetail")]
    public IEnumerable<ait_loandetail> TransactionCurrency_ait_loandetail
    {
      get
      {
        return this.GetRelatedEntities<ait_loandetail>(nameof (TransactionCurrency_ait_loandetail), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_ait_loandetail));
        this.SetRelatedEntities<ait_loandetail>(nameof (TransactionCurrency_ait_loandetail), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_ait_loandetail));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_ait_payment")]
    public IEnumerable<ait_payment> TransactionCurrency_ait_payment
    {
      get
      {
        return this.GetRelatedEntities<ait_payment>(nameof (TransactionCurrency_ait_payment), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_ait_payment));
        this.SetRelatedEntities<ait_payment>(nameof (TransactionCurrency_ait_payment), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_ait_payment));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_ait_placement")]
    public IEnumerable<ait_placement> TransactionCurrency_ait_placement
    {
      get
      {
        return this.GetRelatedEntities<ait_placement>(nameof (TransactionCurrency_ait_placement), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_ait_placement));
        this.SetRelatedEntities<ait_placement>(nameof (TransactionCurrency_ait_placement), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_ait_placement));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_ait_placementlocation")]
    public IEnumerable<ait_placementlocation> TransactionCurrency_ait_placementlocation
    {
      get
      {
        return this.GetRelatedEntities<ait_placementlocation>(nameof (TransactionCurrency_ait_placementlocation), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_ait_placementlocation));
        this.SetRelatedEntities<ait_placementlocation>(nameof (TransactionCurrency_ait_placementlocation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_ait_placementlocation));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_ait_pmteligibility")]
    public IEnumerable<ait_pmteligibility> TransactionCurrency_ait_pmteligibility
    {
      get
      {
        return this.GetRelatedEntities<ait_pmteligibility>(nameof (TransactionCurrency_ait_pmteligibility), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_ait_pmteligibility));
        this.SetRelatedEntities<ait_pmteligibility>(nameof (TransactionCurrency_ait_pmteligibility), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_ait_pmteligibility));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_ait_pmtevent")]
    public IEnumerable<ait_pmtevent> TransactionCurrency_ait_pmtevent
    {
      get
      {
        return this.GetRelatedEntities<ait_pmtevent>(nameof (TransactionCurrency_ait_pmtevent), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_ait_pmtevent));
        this.SetRelatedEntities<ait_pmtevent>(nameof (TransactionCurrency_ait_pmtevent), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_ait_pmtevent));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_ait_pmtpaymenttype")]
    public IEnumerable<ait_pmtpaymenttype> TransactionCurrency_ait_pmtpaymenttype
    {
      get
      {
        return this.GetRelatedEntities<ait_pmtpaymenttype>(nameof (TransactionCurrency_ait_pmtpaymenttype), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_ait_pmtpaymenttype));
        this.SetRelatedEntities<ait_pmtpaymenttype>(nameof (TransactionCurrency_ait_pmtpaymenttype), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_ait_pmtpaymenttype));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_ait_pmttransaction")]
    public IEnumerable<ait_pmttransaction> TransactionCurrency_ait_pmttransaction
    {
      get
      {
        return this.GetRelatedEntities<ait_pmttransaction>(nameof (TransactionCurrency_ait_pmttransaction), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_ait_pmttransaction));
        this.SetRelatedEntities<ait_pmttransaction>(nameof (TransactionCurrency_ait_pmttransaction), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_ait_pmttransaction));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_ait_pmttransactiondeduction")]
    public IEnumerable<ait_pmttransactiondeduction> TransactionCurrency_ait_pmttransactiondeduction
    {
      get
      {
        return this.GetRelatedEntities<ait_pmttransactiondeduction>(nameof (TransactionCurrency_ait_pmttransactiondeduction), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_ait_pmttransactiondeduction));
        this.SetRelatedEntities<ait_pmttransactiondeduction>(nameof (TransactionCurrency_ait_pmttransactiondeduction), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_ait_pmttransactiondeduction));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_ait_pmtwithholding")]
    public IEnumerable<ait_pmtwithholding> TransactionCurrency_ait_pmtwithholding
    {
      get
      {
        return this.GetRelatedEntities<ait_pmtwithholding>(nameof (TransactionCurrency_ait_pmtwithholding), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_ait_pmtwithholding));
        this.SetRelatedEntities<ait_pmtwithholding>(nameof (TransactionCurrency_ait_pmtwithholding), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_ait_pmtwithholding));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_ait_pmtwithholdingoverride")]
    public IEnumerable<ait_pmtwithholdingoverride> TransactionCurrency_ait_pmtwithholdingoverride
    {
      get
      {
        return this.GetRelatedEntities<ait_pmtwithholdingoverride>(nameof (TransactionCurrency_ait_pmtwithholdingoverride), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_ait_pmtwithholdingoverride));
        this.SetRelatedEntities<ait_pmtwithholdingoverride>(nameof (TransactionCurrency_ait_pmtwithholdingoverride), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_ait_pmtwithholdingoverride));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_ait_program")]
    public IEnumerable<ait_program> TransactionCurrency_ait_program
    {
      get
      {
        return this.GetRelatedEntities<ait_program>(nameof (TransactionCurrency_ait_program), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_ait_program));
        this.SetRelatedEntities<ait_program>(nameof (TransactionCurrency_ait_program), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_ait_program));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_ait_referral")]
    public IEnumerable<ait_referral> TransactionCurrency_ait_referral
    {
      get
      {
        return this.GetRelatedEntities<ait_referral>(nameof (TransactionCurrency_ait_referral), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_ait_referral));
        this.SetRelatedEntities<ait_referral>(nameof (TransactionCurrency_ait_referral), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_ait_referral));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_ait_servicerequest")]
    public IEnumerable<ait_servicerequest> TransactionCurrency_ait_servicerequest
    {
      get
      {
        return this.GetRelatedEntities<ait_servicerequest>(nameof (TransactionCurrency_ait_servicerequest), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_ait_servicerequest));
        this.SetRelatedEntities<ait_servicerequest>(nameof (TransactionCurrency_ait_servicerequest), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_ait_servicerequest));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_ait_withholdingtype")]
    public IEnumerable<ait_withholdingtype> TransactionCurrency_ait_withholdingtype
    {
      get
      {
        return this.GetRelatedEntities<ait_withholdingtype>(nameof (TransactionCurrency_ait_withholdingtype), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_ait_withholdingtype));
        this.SetRelatedEntities<ait_withholdingtype>(nameof (TransactionCurrency_ait_withholdingtype), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_ait_withholdingtype));
      }
    }

    [RelationshipSchemaName("transactioncurrency_annualfiscalcalendar")]
    public IEnumerable<AnnualFiscalCalendar> transactioncurrency_annualfiscalcalendar
    {
      get
      {
        return this.GetRelatedEntities<AnnualFiscalCalendar>(nameof (transactioncurrency_annualfiscalcalendar), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (transactioncurrency_annualfiscalcalendar));
        this.SetRelatedEntities<AnnualFiscalCalendar>(nameof (transactioncurrency_annualfiscalcalendar), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (transactioncurrency_annualfiscalcalendar));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_Appointment")]
    public IEnumerable<Appointment> TransactionCurrency_Appointment
    {
      get
      {
        return this.GetRelatedEntities<Appointment>(nameof (TransactionCurrency_Appointment), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_Appointment));
        this.SetRelatedEntities<Appointment>(nameof (TransactionCurrency_Appointment), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_Appointment));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_AsyncOperations")]
    public IEnumerable<AsyncOperation> TransactionCurrency_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (TransactionCurrency_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (TransactionCurrency_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_AsyncOperations));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_BusinessUnit")]
    public IEnumerable<BusinessUnit> TransactionCurrency_BusinessUnit
    {
      get
      {
        return this.GetRelatedEntities<BusinessUnit>(nameof (TransactionCurrency_BusinessUnit), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_BusinessUnit));
        this.SetRelatedEntities<BusinessUnit>(nameof (TransactionCurrency_BusinessUnit), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_BusinessUnit));
      }
    }

    [RelationshipSchemaName("transactioncurrency_cardtype")]
    public IEnumerable<CardType> transactioncurrency_cardtype
    {
      get
      {
        return this.GetRelatedEntities<CardType>(nameof (transactioncurrency_cardtype), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (transactioncurrency_cardtype));
        this.SetRelatedEntities<CardType>(nameof (transactioncurrency_cardtype), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (transactioncurrency_cardtype));
      }
    }

    [RelationshipSchemaName("transactioncurrency_category")]
    public IEnumerable<Category> transactioncurrency_category
    {
      get
      {
        return this.GetRelatedEntities<Category>(nameof (transactioncurrency_category), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (transactioncurrency_category));
        this.SetRelatedEntities<Category>(nameof (transactioncurrency_category), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (transactioncurrency_category));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_ChannelAccessProfile")]
    public IEnumerable<ChannelAccessProfile> TransactionCurrency_ChannelAccessProfile
    {
      get
      {
        return this.GetRelatedEntities<ChannelAccessProfile>(nameof (TransactionCurrency_ChannelAccessProfile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_ChannelAccessProfile));
        this.SetRelatedEntities<ChannelAccessProfile>(nameof (TransactionCurrency_ChannelAccessProfile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_ChannelAccessProfile));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_Connection")]
    public IEnumerable<Connection> TransactionCurrency_Connection
    {
      get
      {
        return this.GetRelatedEntities<Connection>(nameof (TransactionCurrency_Connection), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_Connection));
        this.SetRelatedEntities<Connection>(nameof (TransactionCurrency_Connection), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_Connection));
      }
    }

    [RelationshipSchemaName("transactioncurrency_contact")]
    public IEnumerable<Contact> transactioncurrency_contact
    {
      get
      {
        return this.GetRelatedEntities<Contact>(nameof (transactioncurrency_contact), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (transactioncurrency_contact));
        this.SetRelatedEntities<Contact>(nameof (transactioncurrency_contact), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (transactioncurrency_contact));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_ConvertRule")]
    public IEnumerable<ConvertRule> TransactionCurrency_ConvertRule
    {
      get
      {
        return this.GetRelatedEntities<ConvertRule>(nameof (TransactionCurrency_ConvertRule), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_ConvertRule));
        this.SetRelatedEntities<ConvertRule>(nameof (TransactionCurrency_ConvertRule), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_ConvertRule));
      }
    }

    [RelationshipSchemaName("transactioncurrency_convertruleitem")]
    public IEnumerable<ConvertRuleItem> transactioncurrency_convertruleitem
    {
      get
      {
        return this.GetRelatedEntities<ConvertRuleItem>(nameof (transactioncurrency_convertruleitem), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (transactioncurrency_convertruleitem));
        this.SetRelatedEntities<ConvertRuleItem>(nameof (transactioncurrency_convertruleitem), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (transactioncurrency_convertruleitem));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_CustomerAddress")]
    public IEnumerable<CustomerAddress> TransactionCurrency_CustomerAddress
    {
      get
      {
        return this.GetRelatedEntities<CustomerAddress>(nameof (TransactionCurrency_CustomerAddress), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_CustomerAddress));
        this.SetRelatedEntities<CustomerAddress>(nameof (TransactionCurrency_CustomerAddress), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_CustomerAddress));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_delveactionhub")]
    public IEnumerable<DelveActionHub> TransactionCurrency_delveactionhub
    {
      get
      {
        return this.GetRelatedEntities<DelveActionHub>(nameof (TransactionCurrency_delveactionhub), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_delveactionhub));
        this.SetRelatedEntities<DelveActionHub>(nameof (TransactionCurrency_delveactionhub), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_delveactionhub));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> TransactionCurrency_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (TransactionCurrency_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (TransactionCurrency_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> TransactionCurrency_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (TransactionCurrency_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (TransactionCurrency_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_Email")]
    public IEnumerable<Email> TransactionCurrency_Email
    {
      get => this.GetRelatedEntities<Email>(nameof (TransactionCurrency_Email), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_Email));
        this.SetRelatedEntities<Email>(nameof (TransactionCurrency_Email), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_Email));
      }
    }

    [RelationshipSchemaName("transactioncurrency_expiredprocess")]
    public IEnumerable<ExpiredProcess> transactioncurrency_expiredprocess
    {
      get
      {
        return this.GetRelatedEntities<ExpiredProcess>(nameof (transactioncurrency_expiredprocess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (transactioncurrency_expiredprocess));
        this.SetRelatedEntities<ExpiredProcess>(nameof (transactioncurrency_expiredprocess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (transactioncurrency_expiredprocess));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_ExternalParty")]
    public IEnumerable<ExternalParty> TransactionCurrency_ExternalParty
    {
      get
      {
        return this.GetRelatedEntities<ExternalParty>(nameof (TransactionCurrency_ExternalParty), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_ExternalParty));
        this.SetRelatedEntities<ExternalParty>(nameof (TransactionCurrency_ExternalParty), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_ExternalParty));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_externalpartyitem")]
    public IEnumerable<ExternalPartyItem> TransactionCurrency_externalpartyitem
    {
      get
      {
        return this.GetRelatedEntities<ExternalPartyItem>(nameof (TransactionCurrency_externalpartyitem), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_externalpartyitem));
        this.SetRelatedEntities<ExternalPartyItem>(nameof (TransactionCurrency_externalpartyitem), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_externalpartyitem));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_Fax")]
    public IEnumerable<Fax> TransactionCurrency_Fax
    {
      get => this.GetRelatedEntities<Fax>(nameof (TransactionCurrency_Fax), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_Fax));
        this.SetRelatedEntities<Fax>(nameof (TransactionCurrency_Fax), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_Fax));
      }
    }

    [RelationshipSchemaName("transactioncurrency_feedback")]
    public IEnumerable<Feedback> transactioncurrency_feedback
    {
      get
      {
        return this.GetRelatedEntities<Feedback>(nameof (transactioncurrency_feedback), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (transactioncurrency_feedback));
        this.SetRelatedEntities<Feedback>(nameof (transactioncurrency_feedback), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (transactioncurrency_feedback));
      }
    }

    [RelationshipSchemaName("transactioncurrency_fixedmonthlyfiscalcalendar")]
    public IEnumerable<FixedMonthlyFiscalCalendar> transactioncurrency_fixedmonthlyfiscalcalendar
    {
      get
      {
        return this.GetRelatedEntities<FixedMonthlyFiscalCalendar>(nameof (transactioncurrency_fixedmonthlyfiscalcalendar), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (transactioncurrency_fixedmonthlyfiscalcalendar));
        this.SetRelatedEntities<FixedMonthlyFiscalCalendar>(nameof (transactioncurrency_fixedmonthlyfiscalcalendar), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (transactioncurrency_fixedmonthlyfiscalcalendar));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_Goal")]
    public IEnumerable<Goal> TransactionCurrency_Goal
    {
      get => this.GetRelatedEntities<Goal>(nameof (TransactionCurrency_Goal), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_Goal));
        this.SetRelatedEntities<Goal>(nameof (TransactionCurrency_Goal), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_Goal));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_InteractionForEmail")]
    public IEnumerable<InteractionForEmail> TransactionCurrency_InteractionForEmail
    {
      get
      {
        return this.GetRelatedEntities<InteractionForEmail>(nameof (TransactionCurrency_InteractionForEmail), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_InteractionForEmail));
        this.SetRelatedEntities<InteractionForEmail>(nameof (TransactionCurrency_InteractionForEmail), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_InteractionForEmail));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_KbArticle")]
    public IEnumerable<KbArticle> TransactionCurrency_KbArticle
    {
      get
      {
        return this.GetRelatedEntities<KbArticle>(nameof (TransactionCurrency_KbArticle), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_KbArticle));
        this.SetRelatedEntities<KbArticle>(nameof (TransactionCurrency_KbArticle), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_KbArticle));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_knowledgearticle")]
    public IEnumerable<KnowledgeArticle> TransactionCurrency_knowledgearticle
    {
      get
      {
        return this.GetRelatedEntities<KnowledgeArticle>(nameof (TransactionCurrency_knowledgearticle), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_knowledgearticle));
        this.SetRelatedEntities<KnowledgeArticle>(nameof (TransactionCurrency_knowledgearticle), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_knowledgearticle));
      }
    }

    [RelationshipSchemaName("transactioncurrency_knowledgearticleviews")]
    public IEnumerable<KnowledgeArticleViews> transactioncurrency_knowledgearticleviews
    {
      get
      {
        return this.GetRelatedEntities<KnowledgeArticleViews>(nameof (transactioncurrency_knowledgearticleviews), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (transactioncurrency_knowledgearticleviews));
        this.SetRelatedEntities<KnowledgeArticleViews>(nameof (transactioncurrency_knowledgearticleviews), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (transactioncurrency_knowledgearticleviews));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_KnowledgeBaseRecord")]
    public IEnumerable<KnowledgeBaseRecord> TransactionCurrency_KnowledgeBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<KnowledgeBaseRecord>(nameof (TransactionCurrency_KnowledgeBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_KnowledgeBaseRecord));
        this.SetRelatedEntities<KnowledgeBaseRecord>(nameof (TransactionCurrency_KnowledgeBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_KnowledgeBaseRecord));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_Letter")]
    public IEnumerable<Letter> TransactionCurrency_Letter
    {
      get
      {
        return this.GetRelatedEntities<Letter>(nameof (TransactionCurrency_Letter), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_Letter));
        this.SetRelatedEntities<Letter>(nameof (TransactionCurrency_Letter), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_Letter));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_MailMergeTemplate")]
    public IEnumerable<MailMergeTemplate> TransactionCurrency_MailMergeTemplate
    {
      get
      {
        return this.GetRelatedEntities<MailMergeTemplate>(nameof (TransactionCurrency_MailMergeTemplate), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_MailMergeTemplate));
        this.SetRelatedEntities<MailMergeTemplate>(nameof (TransactionCurrency_MailMergeTemplate), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_MailMergeTemplate));
      }
    }

    [RelationshipSchemaName("transactioncurrency_monthlyfiscalcalendar")]
    public IEnumerable<MonthlyFiscalCalendar> transactioncurrency_monthlyfiscalcalendar
    {
      get
      {
        return this.GetRelatedEntities<MonthlyFiscalCalendar>(nameof (transactioncurrency_monthlyfiscalcalendar), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (transactioncurrency_monthlyfiscalcalendar));
        this.SetRelatedEntities<MonthlyFiscalCalendar>(nameof (transactioncurrency_monthlyfiscalcalendar), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (transactioncurrency_monthlyfiscalcalendar));
      }
    }

    [RelationshipSchemaName("transactioncurrency_newprocess")]
    public IEnumerable<NewProcess> transactioncurrency_newprocess
    {
      get
      {
        return this.GetRelatedEntities<NewProcess>(nameof (transactioncurrency_newprocess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (transactioncurrency_newprocess));
        this.SetRelatedEntities<NewProcess>(nameof (transactioncurrency_newprocess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (transactioncurrency_newprocess));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_officegraphdocument")]
    public IEnumerable<OfficeGraphDocument> TransactionCurrency_officegraphdocument
    {
      get
      {
        return this.GetRelatedEntities<OfficeGraphDocument>(nameof (TransactionCurrency_officegraphdocument), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_officegraphdocument));
        this.SetRelatedEntities<OfficeGraphDocument>(nameof (TransactionCurrency_officegraphdocument), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_officegraphdocument));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_PhoneCall")]
    public IEnumerable<PhoneCall> TransactionCurrency_PhoneCall
    {
      get
      {
        return this.GetRelatedEntities<PhoneCall>(nameof (TransactionCurrency_PhoneCall), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_PhoneCall));
        this.SetRelatedEntities<PhoneCall>(nameof (TransactionCurrency_PhoneCall), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_PhoneCall));
      }
    }

    [RelationshipSchemaName("transactioncurrency_position")]
    public IEnumerable<Position> transactioncurrency_position
    {
      get
      {
        return this.GetRelatedEntities<Position>(nameof (transactioncurrency_position), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (transactioncurrency_position));
        this.SetRelatedEntities<Position>(nameof (transactioncurrency_position), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (transactioncurrency_position));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_ProcessSessions")]
    public IEnumerable<ProcessSession> TransactionCurrency_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (TransactionCurrency_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_ProcessSessions));
        this.SetRelatedEntities<ProcessSession>(nameof (TransactionCurrency_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_ProcessSessions));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_profilerule")]
    public IEnumerable<ChannelAccessProfileRule> TransactionCurrency_profilerule
    {
      get
      {
        return this.GetRelatedEntities<ChannelAccessProfileRule>(nameof (TransactionCurrency_profilerule), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_profilerule));
        this.SetRelatedEntities<ChannelAccessProfileRule>(nameof (TransactionCurrency_profilerule), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_profilerule));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_profileruleitem")]
    public IEnumerable<ChannelAccessProfileRuleItem> TransactionCurrency_profileruleitem
    {
      get
      {
        return this.GetRelatedEntities<ChannelAccessProfileRuleItem>(nameof (TransactionCurrency_profileruleitem), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_profileruleitem));
        this.SetRelatedEntities<ChannelAccessProfileRuleItem>(nameof (TransactionCurrency_profileruleitem), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_profileruleitem));
      }
    }

    [RelationshipSchemaName("transactioncurrency_quarterlyfiscalcalendar")]
    public IEnumerable<QuarterlyFiscalCalendar> transactioncurrency_quarterlyfiscalcalendar
    {
      get
      {
        return this.GetRelatedEntities<QuarterlyFiscalCalendar>(nameof (transactioncurrency_quarterlyfiscalcalendar), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (transactioncurrency_quarterlyfiscalcalendar));
        this.SetRelatedEntities<QuarterlyFiscalCalendar>(nameof (transactioncurrency_quarterlyfiscalcalendar), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (transactioncurrency_quarterlyfiscalcalendar));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_Queue")]
    public IEnumerable<Queue> TransactionCurrency_Queue
    {
      get => this.GetRelatedEntities<Queue>(nameof (TransactionCurrency_Queue), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_Queue));
        this.SetRelatedEntities<Queue>(nameof (TransactionCurrency_Queue), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_Queue));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_QueueItem")]
    public IEnumerable<QueueItem> TransactionCurrency_QueueItem
    {
      get
      {
        return this.GetRelatedEntities<QueueItem>(nameof (TransactionCurrency_QueueItem), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_QueueItem));
        this.SetRelatedEntities<QueueItem>(nameof (TransactionCurrency_QueueItem), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_QueueItem));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_recommendeddocument")]
    public IEnumerable<RecommendedDocument> TransactionCurrency_recommendeddocument
    {
      get
      {
        return this.GetRelatedEntities<RecommendedDocument>(nameof (TransactionCurrency_recommendeddocument), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_recommendeddocument));
        this.SetRelatedEntities<RecommendedDocument>(nameof (TransactionCurrency_recommendeddocument), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_recommendeddocument));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_RecurringAppointmentMaster")]
    public IEnumerable<RecurringAppointmentMaster> TransactionCurrency_RecurringAppointmentMaster
    {
      get
      {
        return this.GetRelatedEntities<RecurringAppointmentMaster>(nameof (TransactionCurrency_RecurringAppointmentMaster), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_RecurringAppointmentMaster));
        this.SetRelatedEntities<RecurringAppointmentMaster>(nameof (TransactionCurrency_RecurringAppointmentMaster), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_RecurringAppointmentMaster));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_ReportCategory")]
    public IEnumerable<ReportCategory> TransactionCurrency_ReportCategory
    {
      get
      {
        return this.GetRelatedEntities<ReportCategory>(nameof (TransactionCurrency_ReportCategory), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_ReportCategory));
        this.SetRelatedEntities<ReportCategory>(nameof (TransactionCurrency_ReportCategory), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_ReportCategory));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_Routingrule")]
    public IEnumerable<RoutingRule> TransactionCurrency_Routingrule
    {
      get
      {
        return this.GetRelatedEntities<RoutingRule>(nameof (TransactionCurrency_Routingrule), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_Routingrule));
        this.SetRelatedEntities<RoutingRule>(nameof (TransactionCurrency_Routingrule), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_Routingrule));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_routingruleitem")]
    public IEnumerable<RoutingRuleItem> TransactionCurrency_routingruleitem
    {
      get
      {
        return this.GetRelatedEntities<RoutingRuleItem>(nameof (TransactionCurrency_routingruleitem), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_routingruleitem));
        this.SetRelatedEntities<RoutingRuleItem>(nameof (TransactionCurrency_routingruleitem), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_routingruleitem));
      }
    }

    [RelationshipSchemaName("transactioncurrency_semiannualfiscalcalendar")]
    public IEnumerable<SemiAnnualFiscalCalendar> transactioncurrency_semiannualfiscalcalendar
    {
      get
      {
        return this.GetRelatedEntities<SemiAnnualFiscalCalendar>(nameof (transactioncurrency_semiannualfiscalcalendar), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (transactioncurrency_semiannualfiscalcalendar));
        this.SetRelatedEntities<SemiAnnualFiscalCalendar>(nameof (transactioncurrency_semiannualfiscalcalendar), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (transactioncurrency_semiannualfiscalcalendar));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_SharePointDocument")]
    public IEnumerable<SharePointDocument> TransactionCurrency_SharePointDocument
    {
      get
      {
        return this.GetRelatedEntities<SharePointDocument>(nameof (TransactionCurrency_SharePointDocument), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_SharePointDocument));
        this.SetRelatedEntities<SharePointDocument>(nameof (TransactionCurrency_SharePointDocument), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_SharePointDocument));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_SharePointDocumentLocation")]
    public IEnumerable<SharePointDocumentLocation> TransactionCurrency_SharePointDocumentLocation
    {
      get
      {
        return this.GetRelatedEntities<SharePointDocumentLocation>(nameof (TransactionCurrency_SharePointDocumentLocation), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_SharePointDocumentLocation));
        this.SetRelatedEntities<SharePointDocumentLocation>(nameof (TransactionCurrency_SharePointDocumentLocation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_SharePointDocumentLocation));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_SharePointSite")]
    public IEnumerable<SharePointSite> TransactionCurrency_SharePointSite
    {
      get
      {
        return this.GetRelatedEntities<SharePointSite>(nameof (TransactionCurrency_SharePointSite), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_SharePointSite));
        this.SetRelatedEntities<SharePointSite>(nameof (TransactionCurrency_SharePointSite), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_SharePointSite));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_SLA")]
    public IEnumerable<SLA> TransactionCurrency_SLA
    {
      get => this.GetRelatedEntities<SLA>(nameof (TransactionCurrency_SLA), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_SLA));
        this.SetRelatedEntities<SLA>(nameof (TransactionCurrency_SLA), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_SLA));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_SLAItem")]
    public IEnumerable<SLAItem> TransactionCurrency_SLAItem
    {
      get
      {
        return this.GetRelatedEntities<SLAItem>(nameof (TransactionCurrency_SLAItem), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_SLAItem));
        this.SetRelatedEntities<SLAItem>(nameof (TransactionCurrency_SLAItem), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_SLAItem));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_slakpiinstance")]
    public IEnumerable<SLAKPIInstance> TransactionCurrency_slakpiinstance
    {
      get
      {
        return this.GetRelatedEntities<SLAKPIInstance>(nameof (TransactionCurrency_slakpiinstance), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_slakpiinstance));
        this.SetRelatedEntities<SLAKPIInstance>(nameof (TransactionCurrency_slakpiinstance), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_slakpiinstance));
      }
    }

    [RelationshipSchemaName("transactioncurrency_socialactivity")]
    public IEnumerable<SocialActivity> transactioncurrency_socialactivity
    {
      get
      {
        return this.GetRelatedEntities<SocialActivity>(nameof (transactioncurrency_socialactivity), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (transactioncurrency_socialactivity));
        this.SetRelatedEntities<SocialActivity>(nameof (transactioncurrency_socialactivity), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (transactioncurrency_socialactivity));
      }
    }

    [RelationshipSchemaName("transactioncurrency_SocialProfile")]
    public IEnumerable<SocialProfile> transactioncurrency_SocialProfile
    {
      get
      {
        return this.GetRelatedEntities<SocialProfile>(nameof (transactioncurrency_SocialProfile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (transactioncurrency_SocialProfile));
        this.SetRelatedEntities<SocialProfile>(nameof (transactioncurrency_SocialProfile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (transactioncurrency_SocialProfile));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_suggestioncardtemplate")]
    public IEnumerable<SuggestionCardTemplate> TransactionCurrency_suggestioncardtemplate
    {
      get
      {
        return this.GetRelatedEntities<SuggestionCardTemplate>(nameof (TransactionCurrency_suggestioncardtemplate), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_suggestioncardtemplate));
        this.SetRelatedEntities<SuggestionCardTemplate>(nameof (TransactionCurrency_suggestioncardtemplate), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_suggestioncardtemplate));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_SyncErrors")]
    public IEnumerable<SyncError> TransactionCurrency_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (TransactionCurrency_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (TransactionCurrency_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_SyncErrors));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_SystemUser")]
    public IEnumerable<SystemUser> TransactionCurrency_SystemUser
    {
      get
      {
        return this.GetRelatedEntities<SystemUser>(nameof (TransactionCurrency_SystemUser), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_SystemUser));
        this.SetRelatedEntities<SystemUser>(nameof (TransactionCurrency_SystemUser), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_SystemUser));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_Task")]
    public IEnumerable<Task> TransactionCurrency_Task
    {
      get => this.GetRelatedEntities<Task>(nameof (TransactionCurrency_Task), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_Task));
        this.SetRelatedEntities<Task>(nameof (TransactionCurrency_Task), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_Task));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_Team")]
    public IEnumerable<Team> TransactionCurrency_Team
    {
      get => this.GetRelatedEntities<Team>(nameof (TransactionCurrency_Team), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_Team));
        this.SetRelatedEntities<Team>(nameof (TransactionCurrency_Team), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_Team));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_Territory")]
    public IEnumerable<Territory> TransactionCurrency_Territory
    {
      get
      {
        return this.GetRelatedEntities<Territory>(nameof (TransactionCurrency_Territory), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_Territory));
        this.SetRelatedEntities<Territory>(nameof (TransactionCurrency_Territory), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_Territory));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_Theme")]
    public IEnumerable<Theme> TransactionCurrency_Theme
    {
      get => this.GetRelatedEntities<Theme>(nameof (TransactionCurrency_Theme), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_Theme));
        this.SetRelatedEntities<Theme>(nameof (TransactionCurrency_Theme), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_Theme));
      }
    }

    [RelationshipSchemaName("transactioncurrency_translationprocess")]
    public IEnumerable<TranslationProcess> transactioncurrency_translationprocess
    {
      get
      {
        return this.GetRelatedEntities<TranslationProcess>(nameof (transactioncurrency_translationprocess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (transactioncurrency_translationprocess));
        this.SetRelatedEntities<TranslationProcess>(nameof (transactioncurrency_translationprocess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (transactioncurrency_translationprocess));
      }
    }

    [RelationshipSchemaName("TransactionCurrency_UserMapping")]
    public IEnumerable<UserMapping> TransactionCurrency_UserMapping
    {
      get
      {
        return this.GetRelatedEntities<UserMapping>(nameof (TransactionCurrency_UserMapping), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_UserMapping));
        this.SetRelatedEntities<UserMapping>(nameof (TransactionCurrency_UserMapping), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_UserMapping));
      }
    }

    [RelationshipSchemaName("transactioncurrency_usersettings")]
    public IEnumerable<UserSettings> transactioncurrency_usersettings
    {
      get
      {
        return this.GetRelatedEntities<UserSettings>(nameof (transactioncurrency_usersettings), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (transactioncurrency_usersettings));
        this.SetRelatedEntities<UserSettings>(nameof (transactioncurrency_usersettings), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (transactioncurrency_usersettings));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_transactioncurrency")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_transactioncurrency
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_transactioncurrency), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_transactioncurrency));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_transactioncurrency), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_transactioncurrency));
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_transactioncurrency_createdonbehalfby")]
    public SystemUser lk_transactioncurrency_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_transactioncurrency_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_transactioncurrency_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_transactioncurrency_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_transactioncurrency_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_transactioncurrency_modifiedonbehalfby")]
    public SystemUser lk_transactioncurrency_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_transactioncurrency_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_transactioncurrency_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_transactioncurrency_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_transactioncurrency_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_transactioncurrencybase_createdby")]
    public SystemUser lk_transactioncurrencybase_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_transactioncurrencybase_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_transactioncurrencybase_modifiedby")]
    public SystemUser lk_transactioncurrencybase_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_transactioncurrencybase_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_transactioncurrencies")]
    public Organization organization_transactioncurrencies
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_transactioncurrencies), new EntityRole?());
      }
    }

    public TransactionCurrency(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["transactioncurrencyid"] = (object) base.Id;
            break;
          case "transactioncurrencyid":
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
