// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_courtfinesandfees
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_courtfinesandfees")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_courtfinesandfees : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_courtfinesandfees";
    public const string EntitySchemaName = "ait_courtfinesandfees";
    public const string PrimaryIdAttribute = "ait_courtfinesandfeesid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_courtfinesandfees()
      : base(nameof (ait_courtfinesandfees))
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

    [AttributeLogicalName("ait_closeddate")]
    public DateTime? ait_ClosedDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_closeddate");
      set
      {
        this.OnPropertyChanging(nameof (ait_ClosedDate));
        this.SetAttributeValue("ait_closeddate", (object) value);
        this.OnPropertyChanged(nameof (ait_ClosedDate));
      }
    }

    [AttributeLogicalName("ait_courtcase")]
    public EntityReference ait_CourtCase
    {
      get => this.GetAttributeValue<EntityReference>("ait_courtcase");
      set
      {
        this.OnPropertyChanging(nameof (ait_CourtCase));
        this.SetAttributeValue("ait_courtcase", (object) value);
        this.OnPropertyChanged(nameof (ait_CourtCase));
      }
    }

    [AttributeLogicalName("ait_courtfinesandfeesid")]
    public Guid? ait_courtfinesandfeesId
    {
      get => this.GetAttributeValue<Guid?>("ait_courtfinesandfeesid");
      set
      {
        this.OnPropertyChanging(nameof (ait_courtfinesandfeesId));
        this.SetAttributeValue("ait_courtfinesandfeesid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_courtfinesandfeesId));
      }
    }

    [AttributeLogicalName("ait_courtfinesandfeesid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_courtfinesandfeesId = new Guid?(value);
    }

    [AttributeLogicalName("ait_date")]
    public DateTime? ait_Date
    {
      get => this.GetAttributeValue<DateTime?>("ait_date");
      set
      {
        this.OnPropertyChanging(nameof (ait_Date));
        this.SetAttributeValue("ait_date", (object) value);
        this.OnPropertyChanged(nameof (ait_Date));
      }
    }

    [AttributeLogicalName("ait_dateordersent")]
    public DateTime? ait_DateOrderSent
    {
      get => this.GetAttributeValue<DateTime?>("ait_dateordersent");
      set
      {
        this.OnPropertyChanging(nameof (ait_DateOrderSent));
        this.SetAttributeValue("ait_dateordersent", (object) value);
        this.OnPropertyChanged(nameof (ait_DateOrderSent));
      }
    }

    [AttributeLogicalName("ait_description")]
    public string ait_Description
    {
      get => this.GetAttributeValue<string>("ait_description");
      set
      {
        this.OnPropertyChanging(nameof (ait_Description));
        this.SetAttributeValue("ait_description", (object) value);
        this.OnPropertyChanged(nameof (ait_Description));
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

    [AttributeLogicalName("ait_feeid")]
    public string ait_FeeID
    {
      get => this.GetAttributeValue<string>("ait_feeid");
      set
      {
        this.OnPropertyChanging(nameof (ait_FeeID));
        this.SetAttributeValue("ait_feeid", (object) value);
        this.OnPropertyChanged(nameof (ait_FeeID));
      }
    }

    [AttributeLogicalName("ait_firstreminderlettersentdate")]
    public DateTime? ait_FirstReminderLetterSentDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_firstreminderlettersentdate");
      set
      {
        this.OnPropertyChanging(nameof (ait_FirstReminderLetterSentDate));
        this.SetAttributeValue("ait_firstreminderlettersentdate", (object) value);
        this.OnPropertyChanged(nameof (ait_FirstReminderLetterSentDate));
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

    [AttributeLogicalName("ait_paid")]
    public bool? ait_Paid
    {
      get => this.GetAttributeValue<bool?>("ait_paid");
      set
      {
        this.OnPropertyChanging(nameof (ait_Paid));
        this.SetAttributeValue("ait_paid", (object) value);
        this.OnPropertyChanged(nameof (ait_Paid));
      }
    }

    [AttributeLogicalName("ait_payableto")]
    public string ait_PayableTo
    {
      get => this.GetAttributeValue<string>("ait_payableto");
      set
      {
        this.OnPropertyChanging(nameof (ait_PayableTo));
        this.SetAttributeValue("ait_payableto", (object) value);
        this.OnPropertyChanged(nameof (ait_PayableTo));
      }
    }

    [AttributeLogicalName("ait_paymentsmade")]
    public int? ait_PaymentsMade => this.GetAttributeValue<int?>("ait_paymentsmade");

    [AttributeLogicalName("ait_paymentsmade_date")]
    public DateTime? ait_PaymentsMade_Date
    {
      get => this.GetAttributeValue<DateTime?>("ait_paymentsmade_date");
    }

    [AttributeLogicalName("ait_paymentsmade_state")]
    public int? ait_PaymentsMade_State => this.GetAttributeValue<int?>("ait_paymentsmade_state");

    [AttributeLogicalName("ait_percapinterceptletterdate")]
    public DateTime? ait_PerCapInterceptLetterDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_percapinterceptletterdate");
      set
      {
        this.OnPropertyChanging(nameof (ait_PerCapInterceptLetterDate));
        this.SetAttributeValue("ait_percapinterceptletterdate", (object) value);
        this.OnPropertyChanged(nameof (ait_PerCapInterceptLetterDate));
      }
    }

    [AttributeLogicalName("ait_taxinterceptletterdate")]
    public DateTime? ait_TaxInterceptLetterDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_taxinterceptletterdate");
      set
      {
        this.OnPropertyChanging(nameof (ait_TaxInterceptLetterDate));
        this.SetAttributeValue("ait_taxinterceptletterdate", (object) value);
        this.OnPropertyChanged(nameof (ait_TaxInterceptLetterDate));
      }
    }

    [AttributeLogicalName("ait_totalbalancedue")]
    public Money ait_TotalBalanceDue
    {
      get => this.GetAttributeValue<Money>("ait_totalbalancedue");
      set
      {
        this.OnPropertyChanging(nameof (ait_TotalBalanceDue));
        this.SetAttributeValue("ait_totalbalancedue", (object) value);
        this.OnPropertyChanged(nameof (ait_TotalBalanceDue));
      }
    }

    [AttributeLogicalName("ait_totalbalancedue_base")]
    public Money ait_totalbalancedue_Base
    {
      get => this.GetAttributeValue<Money>("ait_totalbalancedue_base");
    }

    [AttributeLogicalName("ait_totalpaymentsmade")]
    public Money ait_TotalPaymentsMade => this.GetAttributeValue<Money>("ait_totalpaymentsmade");

    [AttributeLogicalName("ait_totalpaymentsmade_base")]
    public Money ait_totalpaymentsmade_Base
    {
      get => this.GetAttributeValue<Money>("ait_totalpaymentsmade_base");
    }

    [AttributeLogicalName("ait_totalpaymentsmade_date")]
    public DateTime? ait_TotalPaymentsMade_Date
    {
      get => this.GetAttributeValue<DateTime?>("ait_totalpaymentsmade_date");
    }

    [AttributeLogicalName("ait_totalpaymentsmade_state")]
    public int? ait_TotalPaymentsMade_State
    {
      get => this.GetAttributeValue<int?>("ait_totalpaymentsmade_state");
    }

    [AttributeLogicalName("ait_type")]
    public OptionSetValue ait_Type
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_type");
      set
      {
        this.OnPropertyChanging(nameof (ait_Type));
        this.SetAttributeValue("ait_type", (object) value);
        this.OnPropertyChanged(nameof (ait_Type));
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
    public ait_courtfinesandfeesState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_courtfinesandfeesState?((ait_courtfinesandfeesState) Enum.ToObject(typeof (ait_courtfinesandfeesState), attributeValue.Value)) : new ait_courtfinesandfeesState?();
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

    [RelationshipSchemaName("ait_courtfinesandfees_ait_courtpayments_FinesandFees")]
    public IEnumerable<ait_courtpayments> ait_courtfinesandfees_ait_courtpayments_FinesandFees
    {
      get
      {
        return this.GetRelatedEntities<ait_courtpayments>(nameof (ait_courtfinesandfees_ait_courtpayments_FinesandFees), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtfinesandfees_ait_courtpayments_FinesandFees));
        this.SetRelatedEntities<ait_courtpayments>(nameof (ait_courtfinesandfees_ait_courtpayments_FinesandFees), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtfinesandfees_ait_courtpayments_FinesandFees));
      }
    }

    [RelationshipSchemaName("ait_courtfinesandfees_Annotations")]
    public IEnumerable<Annotation> ait_courtfinesandfees_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (ait_courtfinesandfees_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtfinesandfees_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (ait_courtfinesandfees_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtfinesandfees_Annotations));
      }
    }

    [RelationshipSchemaName("ait_courtfinesandfees_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_courtfinesandfees_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_courtfinesandfees_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtfinesandfees_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_courtfinesandfees_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtfinesandfees_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_courtfinesandfees_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_courtfinesandfees_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_courtfinesandfees_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtfinesandfees_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_courtfinesandfees_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtfinesandfees_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_courtfinesandfees_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_courtfinesandfees_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_courtfinesandfees_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtfinesandfees_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_courtfinesandfees_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtfinesandfees_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_courtfinesandfees_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_courtfinesandfees_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_courtfinesandfees_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtfinesandfees_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_courtfinesandfees_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtfinesandfees_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_courtfinesandfees_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_courtfinesandfees_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_courtfinesandfees_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtfinesandfees_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_courtfinesandfees_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtfinesandfees_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_courtfinesandfees_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_courtfinesandfees_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_courtfinesandfees_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtfinesandfees_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_courtfinesandfees_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtfinesandfees_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_courtfinesandfees_ProcessSession")]
    public IEnumerable<ProcessSession> ait_courtfinesandfees_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_courtfinesandfees_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtfinesandfees_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_courtfinesandfees_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtfinesandfees_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_courtfinesandfees_SyncErrors")]
    public IEnumerable<SyncError> ait_courtfinesandfees_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_courtfinesandfees_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtfinesandfees_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_courtfinesandfees_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtfinesandfees_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_courtfinesandfees_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_courtfinesandfees_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_courtfinesandfees_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtfinesandfees_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_courtfinesandfees_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtfinesandfees_UserEntityInstanceDatas));
      }
    }

    [RelationshipSchemaName("ait_courtfinesandfees_ait_courtprofile")]
    public IEnumerable<ait_courtprofile> ait_courtfinesandfees_ait_courtprofile
    {
      get
      {
        return this.GetRelatedEntities<ait_courtprofile>(nameof (ait_courtfinesandfees_ait_courtprofile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtfinesandfees_ait_courtprofile));
        this.SetRelatedEntities<ait_courtprofile>(nameof (ait_courtfinesandfees_ait_courtprofile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtfinesandfees_ait_courtprofile));
      }
    }

    [AttributeLogicalName("ait_courtcase")]
    [RelationshipSchemaName("ait_courtcase_ait_courtfinesandfees_CourtCase")]
    public ait_courtcase ait_courtcase_ait_courtfinesandfees_CourtCase
    {
      get
      {
        return this.GetRelatedEntity<ait_courtcase>(nameof (ait_courtcase_ait_courtfinesandfees_CourtCase), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtcase_ait_courtfinesandfees_CourtCase));
        this.SetRelatedEntity<ait_courtcase>(nameof (ait_courtcase_ait_courtfinesandfees_CourtCase), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtcase_ait_courtfinesandfees_CourtCase));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_courtfinesandfees")]
    public BusinessUnit business_unit_ait_courtfinesandfees
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_courtfinesandfees), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_courtfinesandfees_createdby")]
    public SystemUser lk_ait_courtfinesandfees_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_courtfinesandfees_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_courtfinesandfees_createdonbehalfby")]
    public SystemUser lk_ait_courtfinesandfees_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_courtfinesandfees_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_courtfinesandfees_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_courtfinesandfees_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_courtfinesandfees_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_courtfinesandfees_modifiedby")]
    public SystemUser lk_ait_courtfinesandfees_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_courtfinesandfees_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_courtfinesandfees_modifiedonbehalfby")]
    public SystemUser lk_ait_courtfinesandfees_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_courtfinesandfees_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_courtfinesandfees_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_courtfinesandfees_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_courtfinesandfees_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_courtfinesandfees")]
    public Team team_ait_courtfinesandfees
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_courtfinesandfees), new EntityRole?());
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_ait_courtfinesandfees")]
    public TransactionCurrency TransactionCurrency_ait_courtfinesandfees
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_ait_courtfinesandfees), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_ait_courtfinesandfees));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_ait_courtfinesandfees), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_ait_courtfinesandfees));
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_courtfinesandfees")]
    public SystemUser user_ait_courtfinesandfees
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_ait_courtfinesandfees), new EntityRole?());
      }
    }

    public ait_courtfinesandfees(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_courtfinesandfeesid"] = (object) base.Id;
            break;
          case "ait_courtfinesandfeesid":
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
