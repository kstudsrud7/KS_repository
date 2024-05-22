// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_pmtpaymenttype
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_pmtpaymenttype")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_pmtpaymenttype : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_pmtpaymenttype";
    public const string EntitySchemaName = "ait_pmtpaymenttype";
    public const string PrimaryIdAttribute = "ait_pmtpaymenttypeid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_pmtpaymenttype()
      : base(nameof (ait_pmtpaymenttype))
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

    [AttributeLogicalName("ait_agemaximum")]
    public int? ait_agemaximum
    {
      get => this.GetAttributeValue<int?>(nameof (ait_agemaximum));
      set
      {
        this.OnPropertyChanging(nameof (ait_agemaximum));
        this.SetAttributeValue(nameof (ait_agemaximum), (object) value);
        this.OnPropertyChanged(nameof (ait_agemaximum));
      }
    }

    [AttributeLogicalName("ait_ageminimum")]
    public int? ait_ageminimum
    {
      get => this.GetAttributeValue<int?>(nameof (ait_ageminimum));
      set
      {
        this.OnPropertyChanging(nameof (ait_ageminimum));
        this.SetAttributeValue(nameof (ait_ageminimum), (object) value);
        this.OnPropertyChanged(nameof (ait_ageminimum));
      }
    }

    [AttributeLogicalName("ait_alloweligibilityoverride")]
    public bool? ait_alloweligibilityoverride
    {
      get => this.GetAttributeValue<bool?>(nameof (ait_alloweligibilityoverride));
      set
      {
        this.OnPropertyChanging(nameof (ait_alloweligibilityoverride));
        this.SetAttributeValue(nameof (ait_alloweligibilityoverride), (object) value);
        this.OnPropertyChanged(nameof (ait_alloweligibilityoverride));
      }
    }

    [AttributeLogicalName("ait_alloweventoverride")]
    public bool? ait_alloweventoverride
    {
      get => this.GetAttributeValue<bool?>(nameof (ait_alloweventoverride));
      set
      {
        this.OnPropertyChanging(nameof (ait_alloweventoverride));
        this.SetAttributeValue(nameof (ait_alloweventoverride), (object) value);
        this.OnPropertyChanged(nameof (ait_alloweventoverride));
      }
    }

    [AttributeLogicalName("ait_allowwithholdings")]
    public bool? ait_AllowWithholdings
    {
      get => this.GetAttributeValue<bool?>("ait_allowwithholdings");
      set
      {
        this.OnPropertyChanging(nameof (ait_AllowWithholdings));
        this.SetAttributeValue("ait_allowwithholdings", (object) value);
        this.OnPropertyChanged(nameof (ait_AllowWithholdings));
      }
    }

    [AttributeLogicalName("ait_autocreateeligibilities")]
    public bool? ait_autocreateeligibilities
    {
      get => this.GetAttributeValue<bool?>(nameof (ait_autocreateeligibilities));
      set
      {
        this.OnPropertyChanging(nameof (ait_autocreateeligibilities));
        this.SetAttributeValue(nameof (ait_autocreateeligibilities), (object) value);
        this.OnPropertyChanged(nameof (ait_autocreateeligibilities));
      }
    }

    [AttributeLogicalName("ait_dayofpayment")]
    public int? ait_DayofPayment
    {
      get => this.GetAttributeValue<int?>("ait_dayofpayment");
      set
      {
        this.OnPropertyChanging(nameof (ait_DayofPayment));
        this.SetAttributeValue("ait_dayofpayment", (object) value);
        this.OnPropertyChanged(nameof (ait_DayofPayment));
      }
    }

    [AttributeLogicalName("ait_eligibilitycriteria")]
    public OptionSetValue ait_eligibilitycriteria
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_eligibilitycriteria));
      set
      {
        this.OnPropertyChanging(nameof (ait_eligibilitycriteria));
        this.SetAttributeValue(nameof (ait_eligibilitycriteria), (object) value);
        this.OnPropertyChanged(nameof (ait_eligibilitycriteria));
      }
    }

    [AttributeLogicalName("ait_financedestination")]
    public OptionSetValue ait_financedestination
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_financedestination));
      set
      {
        this.OnPropertyChanging(nameof (ait_financedestination));
        this.SetAttributeValue(nameof (ait_financedestination), (object) value);
        this.OnPropertyChanged(nameof (ait_financedestination));
      }
    }

    [AttributeLogicalName("ait_gender")]
    public OptionSetValue ait_gender
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_gender));
      set
      {
        this.OnPropertyChanging(nameof (ait_gender));
        this.SetAttributeValue(nameof (ait_gender), (object) value);
        this.OnPropertyChanged(nameof (ait_gender));
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

    [AttributeLogicalName("ait_paymentfrequency")]
    public OptionSetValue ait_PaymentFrequency
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_paymentfrequency");
      set
      {
        this.OnPropertyChanging(nameof (ait_PaymentFrequency));
        this.SetAttributeValue("ait_paymentfrequency", (object) value);
        this.OnPropertyChanged(nameof (ait_PaymentFrequency));
      }
    }

    [AttributeLogicalName("ait_pmtpaymenttypeid")]
    public Guid? ait_pmtpaymenttypeId
    {
      get => this.GetAttributeValue<Guid?>("ait_pmtpaymenttypeid");
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtpaymenttypeId));
        this.SetAttributeValue("ait_pmtpaymenttypeid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_pmtpaymenttypeId));
      }
    }

    [AttributeLogicalName("ait_pmtpaymenttypeid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_pmtpaymenttypeId = new Guid?(value);
    }

    [AttributeLogicalName("ait_posttaxdeductionmaximum")]
    public Money ait_posttaxdeductionmaximum
    {
      get => this.GetAttributeValue<Money>(nameof (ait_posttaxdeductionmaximum));
      set
      {
        this.OnPropertyChanging(nameof (ait_posttaxdeductionmaximum));
        this.SetAttributeValue(nameof (ait_posttaxdeductionmaximum), (object) value);
        this.OnPropertyChanged(nameof (ait_posttaxdeductionmaximum));
      }
    }

    [AttributeLogicalName("ait_posttaxdeductionmaximum_base")]
    public Money ait_posttaxdeductionmaximum_Base
    {
      get => this.GetAttributeValue<Money>("ait_posttaxdeductionmaximum_base");
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
    public ait_pmtpaymenttypeState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_pmtpaymenttypeState?((ait_pmtpaymenttypeState) Enum.ToObject(typeof (ait_pmtpaymenttypeState), attributeValue.Value)) : new ait_pmtpaymenttypeState?();
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

    [RelationshipSchemaName("ait_ait_pmtpaymenttype_ait_pmteligibility_PmtPaymentType")]
    public IEnumerable<ait_pmteligibility> ait_ait_pmtpaymenttype_ait_pmteligibility_PmtPaymentType
    {
      get
      {
        return this.GetRelatedEntities<ait_pmteligibility>(nameof (ait_ait_pmtpaymenttype_ait_pmteligibility_PmtPaymentType), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_pmtpaymenttype_ait_pmteligibility_PmtPaymentType));
        this.SetRelatedEntities<ait_pmteligibility>(nameof (ait_ait_pmtpaymenttype_ait_pmteligibility_PmtPaymentType), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_pmtpaymenttype_ait_pmteligibility_PmtPaymentType));
      }
    }

    [RelationshipSchemaName("ait_ait_pmtpaymenttype_ait_pmtevent_pmtPaymentType")]
    public IEnumerable<ait_pmtevent> ait_ait_pmtpaymenttype_ait_pmtevent_pmtPaymentType
    {
      get
      {
        return this.GetRelatedEntities<ait_pmtevent>(nameof (ait_ait_pmtpaymenttype_ait_pmtevent_pmtPaymentType), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_pmtpaymenttype_ait_pmtevent_pmtPaymentType));
        this.SetRelatedEntities<ait_pmtevent>(nameof (ait_ait_pmtpaymenttype_ait_pmtevent_pmtPaymentType), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_pmtpaymenttype_ait_pmtevent_pmtPaymentType));
      }
    }

    [RelationshipSchemaName("ait_pmtpaymenttype_Annotations")]
    public IEnumerable<Annotation> ait_pmtpaymenttype_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (ait_pmtpaymenttype_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtpaymenttype_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (ait_pmtpaymenttype_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtpaymenttype_Annotations));
      }
    }

    [RelationshipSchemaName("ait_pmtpaymenttype_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_pmtpaymenttype_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_pmtpaymenttype_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtpaymenttype_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_pmtpaymenttype_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtpaymenttype_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_pmtpaymenttype_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_pmtpaymenttype_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_pmtpaymenttype_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtpaymenttype_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_pmtpaymenttype_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtpaymenttype_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_pmtpaymenttype_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_pmtpaymenttype_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_pmtpaymenttype_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtpaymenttype_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_pmtpaymenttype_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtpaymenttype_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_pmtpaymenttype_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_pmtpaymenttype_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_pmtpaymenttype_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtpaymenttype_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_pmtpaymenttype_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtpaymenttype_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_pmtpaymenttype_ProcessSession")]
    public IEnumerable<ProcessSession> ait_pmtpaymenttype_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_pmtpaymenttype_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtpaymenttype_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_pmtpaymenttype_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtpaymenttype_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_pmtpaymenttype_SyncErrors")]
    public IEnumerable<SyncError> ait_pmtpaymenttype_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_pmtpaymenttype_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtpaymenttype_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_pmtpaymenttype_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtpaymenttype_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_pmtpaymenttype_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_pmtpaymenttype_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_pmtpaymenttype_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtpaymenttype_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_pmtpaymenttype_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtpaymenttype_UserEntityInstanceDatas));
      }
    }

    [RelationshipSchemaName("ait_withholdingtype_pmtpaymenttype")]
    public IEnumerable<ait_withholdingtype> ait_withholdingtype_pmtpaymenttype
    {
      get
      {
        return this.GetRelatedEntities<ait_withholdingtype>(nameof (ait_withholdingtype_pmtpaymenttype), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_withholdingtype_pmtpaymenttype));
        this.SetRelatedEntities<ait_withholdingtype>(nameof (ait_withholdingtype_pmtpaymenttype), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_withholdingtype_pmtpaymenttype));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_pmtpaymenttype")]
    public BusinessUnit business_unit_ait_pmtpaymenttype
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_pmtpaymenttype), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_pmtpaymenttype_createdby")]
    public SystemUser lk_ait_pmtpaymenttype_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_pmtpaymenttype_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_pmtpaymenttype_createdonbehalfby")]
    public SystemUser lk_ait_pmtpaymenttype_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_pmtpaymenttype_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_pmtpaymenttype_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_pmtpaymenttype_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_pmtpaymenttype_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_pmtpaymenttype_modifiedby")]
    public SystemUser lk_ait_pmtpaymenttype_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_pmtpaymenttype_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_pmtpaymenttype_modifiedonbehalfby")]
    public SystemUser lk_ait_pmtpaymenttype_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_pmtpaymenttype_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_pmtpaymenttype_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_pmtpaymenttype_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_pmtpaymenttype_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_pmtpaymenttype")]
    public Team team_ait_pmtpaymenttype
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_pmtpaymenttype), new EntityRole?());
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_ait_pmtpaymenttype")]
    public TransactionCurrency TransactionCurrency_ait_pmtpaymenttype
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_ait_pmtpaymenttype), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_ait_pmtpaymenttype));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_ait_pmtpaymenttype), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_ait_pmtpaymenttype));
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_pmtpaymenttype")]
    public SystemUser user_ait_pmtpaymenttype
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_ait_pmtpaymenttype), new EntityRole?());
    }

    public ait_pmtpaymenttype(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_pmtpaymenttypeid"] = (object) base.Id;
            break;
          case "ait_pmtpaymenttypeid":
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
