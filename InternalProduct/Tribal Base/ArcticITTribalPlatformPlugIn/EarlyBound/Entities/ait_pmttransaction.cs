// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_pmttransaction
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_pmttransaction")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_pmttransaction : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_pmttransaction";
    public const string EntitySchemaName = "ait_pmttransaction";
    public const string PrimaryIdAttribute = "ait_pmttransactionid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_pmttransaction()
      : base(nameof (ait_pmttransaction))
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

    [AttributeLogicalName("ait_checkamount")]
    public Money ait_CheckAmount
    {
      get => this.GetAttributeValue<Money>("ait_checkamount");
      set
      {
        this.OnPropertyChanging(nameof (ait_CheckAmount));
        this.SetAttributeValue("ait_checkamount", (object) value);
        this.OnPropertyChanged(nameof (ait_CheckAmount));
      }
    }

    [AttributeLogicalName("ait_checkamount_base")]
    public Money ait_checkamount_Base => this.GetAttributeValue<Money>("ait_checkamount_base");

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

    [AttributeLogicalName("ait_payment")]
    public EntityReference ait_payment
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_payment));
      set
      {
        this.OnPropertyChanging(nameof (ait_payment));
        this.SetAttributeValue(nameof (ait_payment), (object) value);
        this.OnPropertyChanged(nameof (ait_payment));
      }
    }

    [AttributeLogicalName("ait_pmttransactionid")]
    public Guid? ait_pmttransactionId
    {
      get => this.GetAttributeValue<Guid?>("ait_pmttransactionid");
      set
      {
        this.OnPropertyChanging(nameof (ait_pmttransactionId));
        this.SetAttributeValue("ait_pmttransactionid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_pmttransactionId));
      }
    }

    [AttributeLogicalName("ait_pmttransactionid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_pmttransactionId = new Guid?(value);
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

    [AttributeLogicalName("ait_posttaxdeductionused")]
    public Money ait_posttaxdeductionused
    {
      get => this.GetAttributeValue<Money>(nameof (ait_posttaxdeductionused));
      set
      {
        this.OnPropertyChanging(nameof (ait_posttaxdeductionused));
        this.SetAttributeValue(nameof (ait_posttaxdeductionused), (object) value);
        this.OnPropertyChanged(nameof (ait_posttaxdeductionused));
      }
    }

    [AttributeLogicalName("ait_posttaxdeductionused_base")]
    public Money ait_posttaxdeductionused_Base
    {
      get => this.GetAttributeValue<Money>("ait_posttaxdeductionused_base");
    }

    [AttributeLogicalName("ait_pretaxdeductionused")]
    public Money ait_pretaxdeductionused
    {
      get => this.GetAttributeValue<Money>(nameof (ait_pretaxdeductionused));
      set
      {
        this.OnPropertyChanging(nameof (ait_pretaxdeductionused));
        this.SetAttributeValue(nameof (ait_pretaxdeductionused), (object) value);
        this.OnPropertyChanged(nameof (ait_pretaxdeductionused));
      }
    }

    [AttributeLogicalName("ait_pretaxdeductionused_base")]
    public Money ait_pretaxdeductionused_Base
    {
      get => this.GetAttributeValue<Money>("ait_pretaxdeductionused_base");
    }

    [AttributeLogicalName("ait_transactionamount")]
    public Money ait_TransactionAmount
    {
      get => this.GetAttributeValue<Money>("ait_transactionamount");
      set
      {
        this.OnPropertyChanging(nameof (ait_TransactionAmount));
        this.SetAttributeValue("ait_transactionamount", (object) value);
        this.OnPropertyChanged(nameof (ait_TransactionAmount));
      }
    }

    [AttributeLogicalName("ait_transactionamount_base")]
    public Money ait_transactionamount_Base
    {
      get => this.GetAttributeValue<Money>("ait_transactionamount_base");
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
    public ait_pmttransactionState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_pmttransactionState?((ait_pmttransactionState) Enum.ToObject(typeof (ait_pmttransactionState), attributeValue.Value)) : new ait_pmttransactionState?();
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

    [RelationshipSchemaName("ait_ait_pmttransaction_ait_pmttransactiondeduction_pmtTransaction")]
    public IEnumerable<ait_pmttransactiondeduction> ait_ait_pmttransaction_ait_pmttransactiondeduction_pmtTransaction
    {
      get
      {
        return this.GetRelatedEntities<ait_pmttransactiondeduction>(nameof (ait_ait_pmttransaction_ait_pmttransactiondeduction_pmtTransaction), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_pmttransaction_ait_pmttransactiondeduction_pmtTransaction));
        this.SetRelatedEntities<ait_pmttransactiondeduction>(nameof (ait_ait_pmttransaction_ait_pmttransactiondeduction_pmtTransaction), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_pmttransaction_ait_pmttransactiondeduction_pmtTransaction));
      }
    }

    [RelationshipSchemaName("ait_pmttransaction_Annotations")]
    public IEnumerable<Annotation> ait_pmttransaction_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (ait_pmttransaction_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmttransaction_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (ait_pmttransaction_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmttransaction_Annotations));
      }
    }

    [RelationshipSchemaName("ait_pmttransaction_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_pmttransaction_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_pmttransaction_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmttransaction_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_pmttransaction_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmttransaction_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_pmttransaction_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_pmttransaction_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_pmttransaction_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmttransaction_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_pmttransaction_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmttransaction_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_pmttransaction_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_pmttransaction_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_pmttransaction_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmttransaction_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_pmttransaction_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmttransaction_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_pmttransaction_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_pmttransaction_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_pmttransaction_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmttransaction_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_pmttransaction_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmttransaction_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_pmttransaction_ProcessSession")]
    public IEnumerable<ProcessSession> ait_pmttransaction_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_pmttransaction_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmttransaction_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_pmttransaction_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmttransaction_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_pmttransaction_SyncErrors")]
    public IEnumerable<SyncError> ait_pmttransaction_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_pmttransaction_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmttransaction_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_pmttransaction_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmttransaction_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_pmttransaction_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_pmttransaction_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_pmttransaction_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmttransaction_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_pmttransaction_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmttransaction_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_pmteligibility")]
    [RelationshipSchemaName("ait_ait_pmteligibility_ait_pmttransaction_PmtEligibility")]
    public ait_pmteligibility ait_ait_pmteligibility_ait_pmttransaction_PmtEligibility
    {
      get
      {
        return this.GetRelatedEntity<ait_pmteligibility>(nameof (ait_ait_pmteligibility_ait_pmttransaction_PmtEligibility), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_pmteligibility_ait_pmttransaction_PmtEligibility));
        this.SetRelatedEntity<ait_pmteligibility>(nameof (ait_ait_pmteligibility_ait_pmttransaction_PmtEligibility), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_pmteligibility_ait_pmttransaction_PmtEligibility));
      }
    }

    [AttributeLogicalName("ait_pmtevent")]
    [RelationshipSchemaName("ait_ait_pmtevent_ait_pmttransaction_PmtEvent")]
    public ait_pmtevent ait_ait_pmtevent_ait_pmttransaction_PmtEvent
    {
      get
      {
        return this.GetRelatedEntity<ait_pmtevent>(nameof (ait_ait_pmtevent_ait_pmttransaction_PmtEvent), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_pmtevent_ait_pmttransaction_PmtEvent));
        this.SetRelatedEntity<ait_pmtevent>(nameof (ait_ait_pmtevent_ait_pmttransaction_PmtEvent), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_pmtevent_ait_pmttransaction_PmtEvent));
      }
    }

    [AttributeLogicalName("ait_member")]
    [RelationshipSchemaName("ait_contact_ait_pmttransaction_Member")]
    public Contact ait_contact_ait_pmttransaction_Member
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (ait_contact_ait_pmttransaction_Member), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contact_ait_pmttransaction_Member));
        this.SetRelatedEntity<Contact>(nameof (ait_contact_ait_pmttransaction_Member), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contact_ait_pmttransaction_Member));
      }
    }

    [AttributeLogicalName("ait_paymentco")]
    [RelationshipSchemaName("ait_paymentco_pmteligibility_ait_pmttransaction")]
    public Contact ait_paymentco_pmteligibility_ait_pmttransaction
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (ait_paymentco_pmteligibility_ait_pmttransaction), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_paymentco_pmteligibility_ait_pmttransaction));
        this.SetRelatedEntity<Contact>(nameof (ait_paymentco_pmteligibility_ait_pmttransaction), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_paymentco_pmteligibility_ait_pmttransaction));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_pmttransaction")]
    public BusinessUnit business_unit_ait_pmttransaction
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_pmttransaction), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_pmttransaction_createdby")]
    public SystemUser lk_ait_pmttransaction_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_pmttransaction_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_pmttransaction_createdonbehalfby")]
    public SystemUser lk_ait_pmttransaction_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_pmttransaction_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_pmttransaction_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_pmttransaction_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_pmttransaction_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_pmttransaction_modifiedby")]
    public SystemUser lk_ait_pmttransaction_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_pmttransaction_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_pmttransaction_modifiedonbehalfby")]
    public SystemUser lk_ait_pmttransaction_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_pmttransaction_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_pmttransaction_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_pmttransaction_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_pmttransaction_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_pmttransaction")]
    public Team team_ait_pmttransaction
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_pmttransaction), new EntityRole?());
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_ait_pmttransaction")]
    public TransactionCurrency TransactionCurrency_ait_pmttransaction
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_ait_pmttransaction), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_ait_pmttransaction));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_ait_pmttransaction), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_ait_pmttransaction));
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_pmttransaction")]
    public SystemUser user_ait_pmttransaction
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_ait_pmttransaction), new EntityRole?());
    }

    public ait_pmttransaction(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_pmttransactionid"] = (object) base.Id;
            break;
          case "ait_pmttransactionid":
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
