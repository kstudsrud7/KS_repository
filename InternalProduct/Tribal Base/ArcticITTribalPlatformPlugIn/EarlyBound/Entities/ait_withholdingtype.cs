// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_withholdingtype
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_withholdingtype")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_withholdingtype : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_withholdingtype";
    public const string EntitySchemaName = "ait_withholdingtype";
    public const string PrimaryIdAttribute = "ait_withholdingtypeid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_withholdingtype()
      : base(nameof (ait_withholdingtype))
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

    [AttributeLogicalName("ait_autocreatewithholding")]
    public bool? ait_autocreatewithholding
    {
      get => this.GetAttributeValue<bool?>(nameof (ait_autocreatewithholding));
      set
      {
        this.OnPropertyChanging(nameof (ait_autocreatewithholding));
        this.SetAttributeValue(nameof (ait_autocreatewithholding), (object) value);
        this.OnPropertyChanged(nameof (ait_autocreatewithholding));
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

    [AttributeLogicalName("ait_posttaxdeduction")]
    public bool? ait_posttaxdeduction
    {
      get => this.GetAttributeValue<bool?>(nameof (ait_posttaxdeduction));
      set
      {
        this.OnPropertyChanging(nameof (ait_posttaxdeduction));
        this.SetAttributeValue(nameof (ait_posttaxdeduction), (object) value);
        this.OnPropertyChanged(nameof (ait_posttaxdeduction));
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

    [AttributeLogicalName("ait_voluntary")]
    public bool? ait_voluntary
    {
      get => this.GetAttributeValue<bool?>(nameof (ait_voluntary));
      set
      {
        this.OnPropertyChanging(nameof (ait_voluntary));
        this.SetAttributeValue(nameof (ait_voluntary), (object) value);
        this.OnPropertyChanged(nameof (ait_voluntary));
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

    [AttributeLogicalName("ait_withholdingrangeend")]
    public int? ait_withholdingrangeend
    {
      get => this.GetAttributeValue<int?>(nameof (ait_withholdingrangeend));
      set
      {
        this.OnPropertyChanging(nameof (ait_withholdingrangeend));
        this.SetAttributeValue(nameof (ait_withholdingrangeend), (object) value);
        this.OnPropertyChanged(nameof (ait_withholdingrangeend));
      }
    }

    [AttributeLogicalName("ait_withholdingrangestart")]
    public int? ait_withholdingrangestart
    {
      get => this.GetAttributeValue<int?>(nameof (ait_withholdingrangestart));
      set
      {
        this.OnPropertyChanging(nameof (ait_withholdingrangestart));
        this.SetAttributeValue(nameof (ait_withholdingrangestart), (object) value);
        this.OnPropertyChanged(nameof (ait_withholdingrangestart));
      }
    }

    [AttributeLogicalName("ait_withholdingtypeid")]
    public Guid? ait_withholdingtypeId
    {
      get => this.GetAttributeValue<Guid?>("ait_withholdingtypeid");
      set
      {
        this.OnPropertyChanging(nameof (ait_withholdingtypeId));
        this.SetAttributeValue("ait_withholdingtypeid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_withholdingtypeId));
      }
    }

    [AttributeLogicalName("ait_withholdingtypeid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_withholdingtypeId = new Guid?(value);
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
    public ait_withholdingtypeState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_withholdingtypeState?((ait_withholdingtypeState) Enum.ToObject(typeof (ait_withholdingtypeState), attributeValue.Value)) : new ait_withholdingtypeState?();
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

    [RelationshipSchemaName("ait_withholdingtype_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_withholdingtype_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_withholdingtype_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_withholdingtype_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_withholdingtype_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_withholdingtype_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_withholdingtype_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_withholdingtype_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_withholdingtype_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_withholdingtype_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_withholdingtype_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_withholdingtype_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_withholdingtype_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_withholdingtype_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_withholdingtype_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_withholdingtype_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_withholdingtype_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_withholdingtype_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_withholdingtype_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_withholdingtype_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_withholdingtype_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_withholdingtype_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_withholdingtype_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_withholdingtype_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_withholdingtype_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_withholdingtype_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_withholdingtype_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_withholdingtype_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_withholdingtype_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_withholdingtype_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_withholdingtype_pmttransactiondeduction")]
    public IEnumerable<ait_pmttransactiondeduction> ait_withholdingtype_pmttransactiondeduction
    {
      get
      {
        return this.GetRelatedEntities<ait_pmttransactiondeduction>(nameof (ait_withholdingtype_pmttransactiondeduction), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_withholdingtype_pmttransactiondeduction));
        this.SetRelatedEntities<ait_pmttransactiondeduction>(nameof (ait_withholdingtype_pmttransactiondeduction), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_withholdingtype_pmttransactiondeduction));
      }
    }

    [RelationshipSchemaName("ait_withholdingtype_pmtwithholding")]
    public IEnumerable<ait_pmtwithholding> ait_withholdingtype_pmtwithholding
    {
      get
      {
        return this.GetRelatedEntities<ait_pmtwithholding>(nameof (ait_withholdingtype_pmtwithholding), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_withholdingtype_pmtwithholding));
        this.SetRelatedEntities<ait_pmtwithholding>(nameof (ait_withholdingtype_pmtwithholding), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_withholdingtype_pmtwithholding));
      }
    }

    [RelationshipSchemaName("ait_withholdingtype_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_withholdingtype_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_withholdingtype_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_withholdingtype_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_withholdingtype_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_withholdingtype_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_withholdingtype_ProcessSession")]
    public IEnumerable<ProcessSession> ait_withholdingtype_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_withholdingtype_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_withholdingtype_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_withholdingtype_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_withholdingtype_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_withholdingtype_SyncErrors")]
    public IEnumerable<SyncError> ait_withholdingtype_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_withholdingtype_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_withholdingtype_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_withholdingtype_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_withholdingtype_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_withholdingtype_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_withholdingtype_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_withholdingtype_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_withholdingtype_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_withholdingtype_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_withholdingtype_UserEntityInstanceDatas));
      }
    }

    [RelationshipSchemaName("ait_withholdingtype_pmtpaymenttype")]
    public IEnumerable<ait_pmtpaymenttype> ait_withholdingtype_pmtpaymenttype
    {
      get
      {
        return this.GetRelatedEntities<ait_pmtpaymenttype>(nameof (ait_withholdingtype_pmtpaymenttype), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_withholdingtype_pmtpaymenttype));
        this.SetRelatedEntities<ait_pmtpaymenttype>(nameof (ait_withholdingtype_pmtpaymenttype), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_withholdingtype_pmtpaymenttype));
      }
    }

    [AttributeLogicalName("ait_accountingcodeid")]
    [RelationshipSchemaName("ait_accountingcode_withholdingtype")]
    public ait_accountingcode ait_accountingcode_withholdingtype
    {
      get
      {
        return this.GetRelatedEntity<ait_accountingcode>(nameof (ait_accountingcode_withholdingtype), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_accountingcode_withholdingtype));
        this.SetRelatedEntity<ait_accountingcode>(nameof (ait_accountingcode_withholdingtype), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_accountingcode_withholdingtype));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_withholdingtype")]
    public BusinessUnit business_unit_ait_withholdingtype
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_withholdingtype), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_withholdingtype_createdby")]
    public SystemUser lk_ait_withholdingtype_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_withholdingtype_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_withholdingtype_createdonbehalfby")]
    public SystemUser lk_ait_withholdingtype_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_withholdingtype_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_withholdingtype_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_withholdingtype_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_withholdingtype_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_withholdingtype_modifiedby")]
    public SystemUser lk_ait_withholdingtype_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_withholdingtype_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_withholdingtype_modifiedonbehalfby")]
    public SystemUser lk_ait_withholdingtype_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_withholdingtype_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_withholdingtype_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_withholdingtype_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_withholdingtype_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_withholdingtype")]
    public Team team_ait_withholdingtype
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_withholdingtype), new EntityRole?());
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_ait_withholdingtype")]
    public TransactionCurrency TransactionCurrency_ait_withholdingtype
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_ait_withholdingtype), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_ait_withholdingtype));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_ait_withholdingtype), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_ait_withholdingtype));
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_withholdingtype")]
    public SystemUser user_ait_withholdingtype
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_ait_withholdingtype), new EntityRole?());
      }
    }

    public ait_withholdingtype(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_withholdingtypeid"] = (object) base.Id;
            break;
          case "ait_withholdingtypeid":
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
