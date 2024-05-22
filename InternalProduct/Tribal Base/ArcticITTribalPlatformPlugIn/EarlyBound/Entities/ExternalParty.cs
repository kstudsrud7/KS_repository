// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ExternalParty
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("externalparty")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ExternalParty : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "externalparty";
    public const string EntitySchemaName = "ExternalParty";
    public const string PrimaryIdAttribute = "externalpartyid";
    public const string PrimaryNameAttribute = "fullname";

    public ExternalParty()
      : base("externalparty")
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

    [AttributeLogicalName("correlationkey")]
    public string CorrelationKey
    {
      get => this.GetAttributeValue<string>("correlationkey");
      set
      {
        this.OnPropertyChanging(nameof (CorrelationKey));
        this.SetAttributeValue("correlationkey", (object) value);
        this.OnPropertyChanged(nameof (CorrelationKey));
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

    [AttributeLogicalName("emailaddress")]
    public string EmailAddress
    {
      get => this.GetAttributeValue<string>("emailaddress");
      set
      {
        this.OnPropertyChanging(nameof (EmailAddress));
        this.SetAttributeValue("emailaddress", (object) value);
        this.OnPropertyChanged(nameof (EmailAddress));
      }
    }

    [AttributeLogicalName("exchangerate")]
    public Decimal? ExchangeRate => this.GetAttributeValue<Decimal?>("exchangerate");

    [AttributeLogicalName("externalpartyid")]
    public Guid? ExternalPartyId
    {
      get => this.GetAttributeValue<Guid?>("externalpartyid");
      set
      {
        this.OnPropertyChanging(nameof (ExternalPartyId));
        this.SetAttributeValue("externalpartyid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ExternalPartyId));
      }
    }

    [AttributeLogicalName("externalpartyid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ExternalPartyId = new Guid?(value);
    }

    [AttributeLogicalName("externalpartyidunique")]
    public Guid? ExternalPartyIdUnique => this.GetAttributeValue<Guid?>("externalpartyidunique");

    [AttributeLogicalName("firstname")]
    public string FirstName
    {
      get => this.GetAttributeValue<string>("firstname");
      set
      {
        this.OnPropertyChanging(nameof (FirstName));
        this.SetAttributeValue("firstname", (object) value);
        this.OnPropertyChanged(nameof (FirstName));
      }
    }

    [AttributeLogicalName("fullname")]
    public string FullName
    {
      get => this.GetAttributeValue<string>("fullname");
      set
      {
        this.OnPropertyChanging(nameof (FullName));
        this.SetAttributeValue("fullname", (object) value);
        this.OnPropertyChanged(nameof (FullName));
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

    [AttributeLogicalName("lastdisabledon")]
    public DateTime? LastDisabledOn
    {
      get => this.GetAttributeValue<DateTime?>("lastdisabledon");
      set
      {
        this.OnPropertyChanging(nameof (LastDisabledOn));
        this.SetAttributeValue("lastdisabledon", (object) value);
        this.OnPropertyChanged(nameof (LastDisabledOn));
      }
    }

    [AttributeLogicalName("lastenabledon")]
    public DateTime? LastEnabledOn
    {
      get => this.GetAttributeValue<DateTime?>("lastenabledon");
      set
      {
        this.OnPropertyChanging(nameof (LastEnabledOn));
        this.SetAttributeValue("lastenabledon", (object) value);
        this.OnPropertyChanged(nameof (LastEnabledOn));
      }
    }

    [AttributeLogicalName("lastname")]
    public string LastName
    {
      get => this.GetAttributeValue<string>("lastname");
      set
      {
        this.OnPropertyChanging(nameof (LastName));
        this.SetAttributeValue("lastname", (object) value);
        this.OnPropertyChanged(nameof (LastName));
      }
    }

    [AttributeLogicalName("middlename")]
    public string MiddleName
    {
      get => this.GetAttributeValue<string>("middlename");
      set
      {
        this.OnPropertyChanging(nameof (MiddleName));
        this.SetAttributeValue("middlename", (object) value);
        this.OnPropertyChanged(nameof (MiddleName));
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
    public ExternalPartyState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ExternalPartyState?((ExternalPartyState) Enum.ToObject(typeof (ExternalPartyState), attributeValue.Value)) : new ExternalPartyState?();
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

    [AttributeLogicalName("type")]
    public string Type
    {
      get => this.GetAttributeValue<string>("type");
      set
      {
        this.OnPropertyChanging(nameof (Type));
        this.SetAttributeValue("type", (object) value);
        this.OnPropertyChanged(nameof (Type));
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

    [AttributeLogicalName("yomifirstname")]
    public string YomiFirstName
    {
      get => this.GetAttributeValue<string>("yomifirstname");
      set
      {
        this.OnPropertyChanging(nameof (YomiFirstName));
        this.SetAttributeValue("yomifirstname", (object) value);
        this.OnPropertyChanged(nameof (YomiFirstName));
      }
    }

    [AttributeLogicalName("yomifullname")]
    public string YomiFullName => this.GetAttributeValue<string>("yomifullname");

    [AttributeLogicalName("yomilastname")]
    public string YomiLastName
    {
      get => this.GetAttributeValue<string>("yomilastname");
      set
      {
        this.OnPropertyChanging(nameof (YomiLastName));
        this.SetAttributeValue("yomilastname", (object) value);
        this.OnPropertyChanged(nameof (YomiLastName));
      }
    }

    [AttributeLogicalName("yomimiddlename")]
    public string YomiMiddleName
    {
      get => this.GetAttributeValue<string>("yomimiddlename");
      set
      {
        this.OnPropertyChanging(nameof (YomiMiddleName));
        this.SetAttributeValue("yomimiddlename", (object) value);
        this.OnPropertyChanged(nameof (YomiMiddleName));
      }
    }

    [RelationshipSchemaName("externalparty_AsyncOperations")]
    public IEnumerable<AsyncOperation> externalparty_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (externalparty_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (externalparty_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (externalparty_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (externalparty_AsyncOperations));
      }
    }

    [RelationshipSchemaName("externalparty_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> externalparty_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (externalparty_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (externalparty_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (externalparty_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (externalparty_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("externalparty_entries")]
    public IEnumerable<ExternalPartyItem> externalparty_entries
    {
      get
      {
        return this.GetRelatedEntities<ExternalPartyItem>(nameof (externalparty_entries), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (externalparty_entries));
        this.SetRelatedEntities<ExternalPartyItem>(nameof (externalparty_entries), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (externalparty_entries));
      }
    }

    [RelationshipSchemaName("externalparty_ProcessSession")]
    public IEnumerable<ProcessSession> externalparty_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (externalparty_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (externalparty_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (externalparty_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (externalparty_ProcessSession));
      }
    }

    [RelationshipSchemaName("ExternalParty_SyncErrors")]
    public IEnumerable<SyncError> ExternalParty_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ExternalParty_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ExternalParty_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ExternalParty_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ExternalParty_SyncErrors));
      }
    }

    [RelationshipSchemaName("externalparty_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> externalparty_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (externalparty_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (externalparty_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (externalparty_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (externalparty_UserEntityInstanceDatas));
      }
    }

    [RelationshipSchemaName("lk_externalparty_account_createdby")]
    public IEnumerable<Account> lk_externalparty_account_createdby
    {
      get
      {
        return this.GetRelatedEntities<Account>(nameof (lk_externalparty_account_createdby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_externalparty_account_createdby));
        this.SetRelatedEntities<Account>(nameof (lk_externalparty_account_createdby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_externalparty_account_createdby));
      }
    }

    [RelationshipSchemaName("lk_externalparty_account_modifiedby")]
    public IEnumerable<Account> lk_externalparty_account_modifiedby
    {
      get
      {
        return this.GetRelatedEntities<Account>(nameof (lk_externalparty_account_modifiedby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_externalparty_account_modifiedby));
        this.SetRelatedEntities<Account>(nameof (lk_externalparty_account_modifiedby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_externalparty_account_modifiedby));
      }
    }

    [RelationshipSchemaName("lk_externalparty_contact_createdby")]
    public IEnumerable<Contact> lk_externalparty_contact_createdby
    {
      get
      {
        return this.GetRelatedEntities<Contact>(nameof (lk_externalparty_contact_createdby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_externalparty_contact_createdby));
        this.SetRelatedEntities<Contact>(nameof (lk_externalparty_contact_createdby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_externalparty_contact_createdby));
      }
    }

    [RelationshipSchemaName("lk_externalparty_contact_modifiedby")]
    public IEnumerable<Contact> lk_externalparty_contact_modifiedby
    {
      get
      {
        return this.GetRelatedEntities<Contact>(nameof (lk_externalparty_contact_modifiedby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_externalparty_contact_modifiedby));
        this.SetRelatedEntities<Contact>(nameof (lk_externalparty_contact_modifiedby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_externalparty_contact_modifiedby));
      }
    }

    [RelationshipSchemaName("lk_externalparty_subject_createdby")]
    public IEnumerable<Subject> lk_externalparty_subject_createdby
    {
      get
      {
        return this.GetRelatedEntities<Subject>(nameof (lk_externalparty_subject_createdby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_externalparty_subject_createdby));
        this.SetRelatedEntities<Subject>(nameof (lk_externalparty_subject_createdby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_externalparty_subject_createdby));
      }
    }

    [RelationshipSchemaName("lk_externalparty_subject_modifiedby")]
    public IEnumerable<Subject> lk_externalparty_subject_modifiedby
    {
      get
      {
        return this.GetRelatedEntities<Subject>(nameof (lk_externalparty_subject_modifiedby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_externalparty_subject_modifiedby));
        this.SetRelatedEntities<Subject>(nameof (lk_externalparty_subject_modifiedby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_externalparty_subject_modifiedby));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_externalparty")]
    public BusinessUnit business_unit_externalparty
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_externalparty), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_externalparty_createdby")]
    public SystemUser lk_externalparty_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_externalparty_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_externalparty_createdonbehalfby")]
    public SystemUser lk_externalparty_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_externalparty_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_externalparty_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_externalparty_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_externalparty_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_externalparty_modifiedby")]
    public SystemUser lk_externalparty_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_externalparty_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_externalparty_modifiedonbehalfby")]
    public SystemUser lk_externalparty_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_externalparty_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_externalparty_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_externalparty_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_externalparty_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_externalparty")]
    public Team team_externalparty
    {
      get => this.GetRelatedEntity<Team>(nameof (team_externalparty), new EntityRole?());
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_ExternalParty")]
    public TransactionCurrency TransactionCurrency_ExternalParty
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_ExternalParty), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_ExternalParty));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_ExternalParty), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_ExternalParty));
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_externalparty")]
    public SystemUser user_externalparty
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_externalparty), new EntityRole?());
    }

    public ExternalParty(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["externalpartyid"] = (object) base.Id;
            break;
          case "externalpartyid":
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
