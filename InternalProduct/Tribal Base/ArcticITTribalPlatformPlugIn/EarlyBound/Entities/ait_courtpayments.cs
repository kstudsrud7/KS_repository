// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_courtpayments
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_courtpayments")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_courtpayments : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_courtpayments";
    public const string EntitySchemaName = "ait_courtpayments";
    public const string PrimaryIdAttribute = "ait_courtpaymentsid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_courtpayments()
      : base(nameof (ait_courtpayments))
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

    [AttributeLogicalName("ait_courtpaymentsid")]
    public Guid? ait_courtpaymentsId
    {
      get => this.GetAttributeValue<Guid?>("ait_courtpaymentsid");
      set
      {
        this.OnPropertyChanging(nameof (ait_courtpaymentsId));
        this.SetAttributeValue("ait_courtpaymentsid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_courtpaymentsId));
      }
    }

    [AttributeLogicalName("ait_courtpaymentsid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_courtpaymentsId = new Guid?(value);
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

    [AttributeLogicalName("ait_finesandfees")]
    public EntityReference ait_FinesandFees
    {
      get => this.GetAttributeValue<EntityReference>("ait_finesandfees");
      set
      {
        this.OnPropertyChanging(nameof (ait_FinesandFees));
        this.SetAttributeValue("ait_finesandfees", (object) value);
        this.OnPropertyChanged(nameof (ait_FinesandFees));
      }
    }

    [AttributeLogicalName("ait_howpaid")]
    public OptionSetValue ait_HowPaid
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_howpaid");
      set
      {
        this.OnPropertyChanging(nameof (ait_HowPaid));
        this.SetAttributeValue("ait_howpaid", (object) value);
        this.OnPropertyChanged(nameof (ait_HowPaid));
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

    [AttributeLogicalName("ait_paymentdate")]
    public DateTime? ait_PaymentDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_paymentdate");
      set
      {
        this.OnPropertyChanging(nameof (ait_PaymentDate));
        this.SetAttributeValue("ait_paymentdate", (object) value);
        this.OnPropertyChanged(nameof (ait_PaymentDate));
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
    public ait_courtpaymentsState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_courtpaymentsState?((ait_courtpaymentsState) Enum.ToObject(typeof (ait_courtpaymentsState), attributeValue.Value)) : new ait_courtpaymentsState?();
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

    [RelationshipSchemaName("ait_courtpayments_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_courtpayments_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_courtpayments_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtpayments_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_courtpayments_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtpayments_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_courtpayments_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_courtpayments_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_courtpayments_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtpayments_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_courtpayments_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtpayments_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_courtpayments_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_courtpayments_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_courtpayments_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtpayments_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_courtpayments_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtpayments_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_courtpayments_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_courtpayments_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_courtpayments_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtpayments_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_courtpayments_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtpayments_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_courtpayments_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_courtpayments_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_courtpayments_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtpayments_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_courtpayments_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtpayments_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_courtpayments_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_courtpayments_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_courtpayments_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtpayments_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_courtpayments_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtpayments_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_courtpayments_ProcessSession")]
    public IEnumerable<ProcessSession> ait_courtpayments_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_courtpayments_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtpayments_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_courtpayments_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtpayments_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_courtpayments_SyncErrors")]
    public IEnumerable<SyncError> ait_courtpayments_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_courtpayments_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtpayments_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_courtpayments_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtpayments_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_courtpayments_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_courtpayments_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_courtpayments_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtpayments_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_courtpayments_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtpayments_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_finesandfees")]
    [RelationshipSchemaName("ait_courtfinesandfees_ait_courtpayments_FinesandFees")]
    public ait_courtfinesandfees ait_courtfinesandfees_ait_courtpayments_FinesandFees
    {
      get
      {
        return this.GetRelatedEntity<ait_courtfinesandfees>(nameof (ait_courtfinesandfees_ait_courtpayments_FinesandFees), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtfinesandfees_ait_courtpayments_FinesandFees));
        this.SetRelatedEntity<ait_courtfinesandfees>(nameof (ait_courtfinesandfees_ait_courtpayments_FinesandFees), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtfinesandfees_ait_courtpayments_FinesandFees));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_courtpayments")]
    public BusinessUnit business_unit_ait_courtpayments
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_courtpayments), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_courtpayments_createdby")]
    public SystemUser lk_ait_courtpayments_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_courtpayments_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_courtpayments_createdonbehalfby")]
    public SystemUser lk_ait_courtpayments_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_courtpayments_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_courtpayments_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_courtpayments_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_courtpayments_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_courtpayments_modifiedby")]
    public SystemUser lk_ait_courtpayments_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_courtpayments_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_courtpayments_modifiedonbehalfby")]
    public SystemUser lk_ait_courtpayments_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_courtpayments_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_courtpayments_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_courtpayments_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_courtpayments_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_courtpayments")]
    public Team team_ait_courtpayments
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_courtpayments), new EntityRole?());
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_ait_courtpayments")]
    public TransactionCurrency TransactionCurrency_ait_courtpayments
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_ait_courtpayments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_ait_courtpayments));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_ait_courtpayments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_ait_courtpayments));
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_courtpayments")]
    public SystemUser user_ait_courtpayments
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_ait_courtpayments), new EntityRole?());
    }

    public ait_courtpayments(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_courtpaymentsid"] = (object) base.Id;
            break;
          case "ait_courtpaymentsid":
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
