// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_pmteligibility
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_pmteligibility")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_pmteligibility : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_pmteligibility";
    public const string EntitySchemaName = "ait_pmteligibility";
    public const string PrimaryIdAttribute = "ait_pmteligibilityid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_pmteligibility()
      : base(nameof (ait_pmteligibility))
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

    [AttributeLogicalName("ait_paymentco")]
    public EntityReference ait_paymentco
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_paymentco));
      set
      {
        this.OnPropertyChanging(nameof (ait_paymentco));
        this.SetAttributeValue(nameof (ait_paymentco), (object) value);
        this.OnPropertyChanged(nameof (ait_paymentco));
      }
    }

    [AttributeLogicalName("ait_pmteligibilityid")]
    public Guid? ait_pmteligibilityId
    {
      get => this.GetAttributeValue<Guid?>("ait_pmteligibilityid");
      set
      {
        this.OnPropertyChanging(nameof (ait_pmteligibilityId));
        this.SetAttributeValue("ait_pmteligibilityid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_pmteligibilityId));
      }
    }

    [AttributeLogicalName("ait_pmteligibilityid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_pmteligibilityId = new Guid?(value);
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

    [AttributeLogicalName("ait_posttaxdeductionmaxoverride")]
    public Money ait_posttaxdeductionmaxoverride
    {
      get => this.GetAttributeValue<Money>(nameof (ait_posttaxdeductionmaxoverride));
      set
      {
        this.OnPropertyChanging(nameof (ait_posttaxdeductionmaxoverride));
        this.SetAttributeValue(nameof (ait_posttaxdeductionmaxoverride), (object) value);
        this.OnPropertyChanged(nameof (ait_posttaxdeductionmaxoverride));
      }
    }

    [AttributeLogicalName("ait_posttaxdeductionmaxoverride_base")]
    public Money ait_posttaxdeductionmaxoverride_Base
    {
      get => this.GetAttributeValue<Money>("ait_posttaxdeductionmaxoverride_base");
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
    public ait_pmteligibilityState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_pmteligibilityState?((ait_pmteligibilityState) Enum.ToObject(typeof (ait_pmteligibilityState), attributeValue.Value)) : new ait_pmteligibilityState?();
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

    [RelationshipSchemaName("ait_ait_pmteligibility_ait_pmttransaction_PmtEligibility")]
    public IEnumerable<ait_pmttransaction> ait_ait_pmteligibility_ait_pmttransaction_PmtEligibility
    {
      get
      {
        return this.GetRelatedEntities<ait_pmttransaction>(nameof (ait_ait_pmteligibility_ait_pmttransaction_PmtEligibility), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_pmteligibility_ait_pmttransaction_PmtEligibility));
        this.SetRelatedEntities<ait_pmttransaction>(nameof (ait_ait_pmteligibility_ait_pmttransaction_PmtEligibility), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_pmteligibility_ait_pmttransaction_PmtEligibility));
      }
    }

    [RelationshipSchemaName("ait_ait_pmteligibility_ait_pmtwithholding_PmtEligibility")]
    public IEnumerable<ait_pmtwithholding> ait_ait_pmteligibility_ait_pmtwithholding_PmtEligibility
    {
      get
      {
        return this.GetRelatedEntities<ait_pmtwithholding>(nameof (ait_ait_pmteligibility_ait_pmtwithholding_PmtEligibility), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_pmteligibility_ait_pmtwithholding_PmtEligibility));
        this.SetRelatedEntities<ait_pmtwithholding>(nameof (ait_ait_pmteligibility_ait_pmtwithholding_PmtEligibility), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_pmteligibility_ait_pmtwithholding_PmtEligibility));
      }
    }

    [RelationshipSchemaName("ait_pmteligibility_Annotations")]
    public IEnumerable<Annotation> ait_pmteligibility_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (ait_pmteligibility_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmteligibility_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (ait_pmteligibility_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmteligibility_Annotations));
      }
    }

    [RelationshipSchemaName("ait_pmteligibility_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_pmteligibility_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_pmteligibility_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmteligibility_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_pmteligibility_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmteligibility_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_pmteligibility_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_pmteligibility_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_pmteligibility_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmteligibility_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_pmteligibility_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmteligibility_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_pmteligibility_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_pmteligibility_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_pmteligibility_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmteligibility_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_pmteligibility_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmteligibility_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_pmteligibility_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_pmteligibility_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_pmteligibility_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmteligibility_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_pmteligibility_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmteligibility_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_pmteligibility_ProcessSession")]
    public IEnumerable<ProcessSession> ait_pmteligibility_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_pmteligibility_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmteligibility_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_pmteligibility_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmteligibility_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_pmteligibility_SyncErrors")]
    public IEnumerable<SyncError> ait_pmteligibility_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_pmteligibility_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmteligibility_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_pmteligibility_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmteligibility_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_pmteligibility_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_pmteligibility_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_pmteligibility_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmteligibility_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_pmteligibility_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmteligibility_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_pmtpaymenttype")]
    [RelationshipSchemaName("ait_ait_pmtpaymenttype_ait_pmteligibility_PmtPaymentType")]
    public ait_pmtpaymenttype ait_ait_pmtpaymenttype_ait_pmteligibility_PmtPaymentType
    {
      get
      {
        return this.GetRelatedEntity<ait_pmtpaymenttype>(nameof (ait_ait_pmtpaymenttype_ait_pmteligibility_PmtPaymentType), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_pmtpaymenttype_ait_pmteligibility_PmtPaymentType));
        this.SetRelatedEntity<ait_pmtpaymenttype>(nameof (ait_ait_pmtpaymenttype_ait_pmteligibility_PmtPaymentType), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_pmtpaymenttype_ait_pmteligibility_PmtPaymentType));
      }
    }

    [AttributeLogicalName("ait_member")]
    [RelationshipSchemaName("ait_contact_ait_pmteligibility_Member")]
    public Contact ait_contact_ait_pmteligibility_Member
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (ait_contact_ait_pmteligibility_Member), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contact_ait_pmteligibility_Member));
        this.SetRelatedEntity<Contact>(nameof (ait_contact_ait_pmteligibility_Member), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contact_ait_pmteligibility_Member));
      }
    }

    [AttributeLogicalName("ait_paymentco")]
    [RelationshipSchemaName("ait_paymentco_pmteligibility")]
    public Contact ait_paymentco_pmteligibility
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (ait_paymentco_pmteligibility), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_paymentco_pmteligibility));
        this.SetRelatedEntity<Contact>(nameof (ait_paymentco_pmteligibility), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_paymentco_pmteligibility));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_pmteligibility")]
    public BusinessUnit business_unit_ait_pmteligibility
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_pmteligibility), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_pmteligibility_createdby")]
    public SystemUser lk_ait_pmteligibility_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_pmteligibility_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_pmteligibility_createdonbehalfby")]
    public SystemUser lk_ait_pmteligibility_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_pmteligibility_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_pmteligibility_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_pmteligibility_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_pmteligibility_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_pmteligibility_modifiedby")]
    public SystemUser lk_ait_pmteligibility_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_pmteligibility_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_pmteligibility_modifiedonbehalfby")]
    public SystemUser lk_ait_pmteligibility_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_pmteligibility_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_pmteligibility_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_pmteligibility_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_pmteligibility_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_pmteligibility")]
    public Team team_ait_pmteligibility
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_pmteligibility), new EntityRole?());
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_ait_pmteligibility")]
    public TransactionCurrency TransactionCurrency_ait_pmteligibility
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_ait_pmteligibility), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_ait_pmteligibility));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_ait_pmteligibility), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_ait_pmteligibility));
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_pmteligibility")]
    public SystemUser user_ait_pmteligibility
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_ait_pmteligibility), new EntityRole?());
    }

    public ait_pmteligibility(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_pmteligibilityid"] = (object) base.Id;
            break;
          case "ait_pmteligibilityid":
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
