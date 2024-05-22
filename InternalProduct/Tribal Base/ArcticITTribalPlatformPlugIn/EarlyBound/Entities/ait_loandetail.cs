// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_loandetail
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_loandetail")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_loandetail : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_loandetail";
    public const string EntitySchemaName = "ait_loandetail";
    public const string PrimaryIdAttribute = "ait_loandetailid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_loandetail()
      : base(nameof (ait_loandetail))
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

    [AttributeLogicalName("ait_amounttowardsinterest")]
    public Money ait_amounttowardsinterest
    {
      get => this.GetAttributeValue<Money>(nameof (ait_amounttowardsinterest));
      set
      {
        this.OnPropertyChanging(nameof (ait_amounttowardsinterest));
        this.SetAttributeValue(nameof (ait_amounttowardsinterest), (object) value);
        this.OnPropertyChanged(nameof (ait_amounttowardsinterest));
      }
    }

    [AttributeLogicalName("ait_amounttowardsinterest_base")]
    public Money ait_amounttowardsinterest_Base
    {
      get => this.GetAttributeValue<Money>("ait_amounttowardsinterest_base");
    }

    [AttributeLogicalName("ait_amounttowardsprincipal")]
    public Money ait_amounttowardsprincipal
    {
      get => this.GetAttributeValue<Money>(nameof (ait_amounttowardsprincipal));
      set
      {
        this.OnPropertyChanging(nameof (ait_amounttowardsprincipal));
        this.SetAttributeValue(nameof (ait_amounttowardsprincipal), (object) value);
        this.OnPropertyChanged(nameof (ait_amounttowardsprincipal));
      }
    }

    [AttributeLogicalName("ait_amounttowardsprincipal_base")]
    public Money ait_amounttowardsprincipal_Base
    {
      get => this.GetAttributeValue<Money>("ait_amounttowardsprincipal_base");
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

    [AttributeLogicalName("ait_loandetailid")]
    public Guid? ait_loandetailId
    {
      get => this.GetAttributeValue<Guid?>("ait_loandetailid");
      set
      {
        this.OnPropertyChanging(nameof (ait_loandetailId));
        this.SetAttributeValue("ait_loandetailid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_loandetailId));
      }
    }

    [AttributeLogicalName("ait_loandetailid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_loandetailId = new Guid?(value);
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

    [AttributeLogicalName("ait_outstandingbalance")]
    public Money ait_outstandingbalance
    {
      get => this.GetAttributeValue<Money>(nameof (ait_outstandingbalance));
      set
      {
        this.OnPropertyChanging(nameof (ait_outstandingbalance));
        this.SetAttributeValue(nameof (ait_outstandingbalance), (object) value);
        this.OnPropertyChanged(nameof (ait_outstandingbalance));
      }
    }

    [AttributeLogicalName("ait_outstandingbalance_base")]
    public Money ait_outstandingbalance_Base
    {
      get => this.GetAttributeValue<Money>("ait_outstandingbalance_base");
    }

    [AttributeLogicalName("ait_transactionamount")]
    public Money ait_transactionamount
    {
      get => this.GetAttributeValue<Money>(nameof (ait_transactionamount));
      set
      {
        this.OnPropertyChanging(nameof (ait_transactionamount));
        this.SetAttributeValue(nameof (ait_transactionamount), (object) value);
        this.OnPropertyChanged(nameof (ait_transactionamount));
      }
    }

    [AttributeLogicalName("ait_transactionamount_base")]
    public Money ait_transactionamount_Base
    {
      get => this.GetAttributeValue<Money>("ait_transactionamount_base");
    }

    [AttributeLogicalName("ait_transactiondate")]
    public DateTime? ait_transactiondate
    {
      get => this.GetAttributeValue<DateTime?>(nameof (ait_transactiondate));
      set
      {
        this.OnPropertyChanging(nameof (ait_transactiondate));
        this.SetAttributeValue(nameof (ait_transactiondate), (object) value);
        this.OnPropertyChanged(nameof (ait_transactiondate));
      }
    }

    [AttributeLogicalName("ait_transactiontype")]
    public OptionSetValue ait_transactiontype
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_transactiontype));
      set
      {
        this.OnPropertyChanging(nameof (ait_transactiontype));
        this.SetAttributeValue(nameof (ait_transactiontype), (object) value);
        this.OnPropertyChanged(nameof (ait_transactiontype));
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
    public ait_loandetailState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_loandetailState?((ait_loandetailState) Enum.ToObject(typeof (ait_loandetailState), attributeValue.Value)) : new ait_loandetailState?();
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

    [RelationshipSchemaName("ait_loandetail_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_loandetail_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_loandetail_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_loandetail_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_loandetail_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_loandetail_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_loandetail_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_loandetail_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_loandetail_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_loandetail_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_loandetail_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_loandetail_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_loandetail_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_loandetail_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_loandetail_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_loandetail_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_loandetail_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_loandetail_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_loandetail_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_loandetail_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_loandetail_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_loandetail_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_loandetail_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_loandetail_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_loandetail_ProcessSession")]
    public IEnumerable<ProcessSession> ait_loandetail_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_loandetail_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_loandetail_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_loandetail_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_loandetail_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_loandetail_SyncErrors")]
    public IEnumerable<SyncError> ait_loandetail_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_loandetail_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_loandetail_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_loandetail_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_loandetail_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_loandetail_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_loandetail_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_loandetail_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_loandetail_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_loandetail_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_loandetail_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_loanid")]
    [RelationshipSchemaName("ait_loan_loandetail")]
    public ait_loan ait_loan_loandetail
    {
      get => this.GetRelatedEntity<ait_loan>(nameof (ait_loan_loandetail), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_loan_loandetail));
        this.SetRelatedEntity<ait_loan>(nameof (ait_loan_loandetail), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_loan_loandetail));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_loandetail")]
    public BusinessUnit business_unit_ait_loandetail
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_loandetail), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_loandetail_createdby")]
    public SystemUser lk_ait_loandetail_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_loandetail_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_loandetail_createdonbehalfby")]
    public SystemUser lk_ait_loandetail_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_loandetail_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_loandetail_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_loandetail_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_loandetail_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_loandetail_modifiedby")]
    public SystemUser lk_ait_loandetail_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_loandetail_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_loandetail_modifiedonbehalfby")]
    public SystemUser lk_ait_loandetail_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_loandetail_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_loandetail_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_loandetail_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_loandetail_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_loandetail")]
    public Team team_ait_loandetail
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_loandetail), new EntityRole?());
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_ait_loandetail")]
    public TransactionCurrency TransactionCurrency_ait_loandetail
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_ait_loandetail), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_ait_loandetail));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_ait_loandetail), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_ait_loandetail));
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_loandetail")]
    public SystemUser user_ait_loandetail
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_ait_loandetail), new EntityRole?());
    }

    public ait_loandetail(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_loandetailid"] = (object) base.Id;
            break;
          case "ait_loandetailid":
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
