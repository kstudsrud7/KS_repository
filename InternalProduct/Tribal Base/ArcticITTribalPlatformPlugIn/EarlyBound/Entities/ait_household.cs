// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_household
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_household")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_household : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_household";
    public const string EntitySchemaName = "ait_household";
    public const string PrimaryIdAttribute = "ait_householdid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_household()
      : base(nameof (ait_household))
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

    [AttributeLogicalName("ait_description")]
    public string ait_description
    {
      get => this.GetAttributeValue<string>(nameof (ait_description));
      set
      {
        this.OnPropertyChanging(nameof (ait_description));
        this.SetAttributeValue(nameof (ait_description), (object) value);
        this.OnPropertyChanged(nameof (ait_description));
      }
    }

    [AttributeLogicalName("ait_headofhousehold")]
    public EntityReference ait_headofhousehold
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_headofhousehold));
      set
      {
        this.OnPropertyChanging(nameof (ait_headofhousehold));
        this.SetAttributeValue(nameof (ait_headofhousehold), (object) value);
        this.OnPropertyChanged(nameof (ait_headofhousehold));
      }
    }

    [AttributeLogicalName("ait_householdid")]
    public Guid? ait_householdId
    {
      get => this.GetAttributeValue<Guid?>("ait_householdid");
      set
      {
        this.OnPropertyChanging(nameof (ait_householdId));
        this.SetAttributeValue("ait_householdid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_householdId));
      }
    }

    [AttributeLogicalName("ait_householdid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_householdId = new Guid?(value);
    }

    [AttributeLogicalName("ait_householdidnumber")]
    public string ait_householdidnumber
    {
      get => this.GetAttributeValue<string>(nameof (ait_householdidnumber));
      set
      {
        this.OnPropertyChanging(nameof (ait_householdidnumber));
        this.SetAttributeValue(nameof (ait_householdidnumber), (object) value);
        this.OnPropertyChanged(nameof (ait_householdidnumber));
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

    [AttributeLogicalName("ait_totalearnedincome")]
    public Money ait_totalearnedincome
    {
      get => this.GetAttributeValue<Money>(nameof (ait_totalearnedincome));
      set
      {
        this.OnPropertyChanging(nameof (ait_totalearnedincome));
        this.SetAttributeValue(nameof (ait_totalearnedincome), (object) value);
        this.OnPropertyChanged(nameof (ait_totalearnedincome));
      }
    }

    [AttributeLogicalName("ait_totalearnedincome_base")]
    public Money ait_totalearnedincome_Base
    {
      get => this.GetAttributeValue<Money>("ait_totalearnedincome_base");
    }

    [AttributeLogicalName("ait_totalexpenses")]
    public Money ait_totalexpenses
    {
      get => this.GetAttributeValue<Money>(nameof (ait_totalexpenses));
      set
      {
        this.OnPropertyChanging(nameof (ait_totalexpenses));
        this.SetAttributeValue(nameof (ait_totalexpenses), (object) value);
        this.OnPropertyChanged(nameof (ait_totalexpenses));
      }
    }

    [AttributeLogicalName("ait_totalexpenses_base")]
    public Money ait_totalexpenses_Base => this.GetAttributeValue<Money>("ait_totalexpenses_base");

    [AttributeLogicalName("ait_totalincome")]
    public Money ait_totalincome
    {
      get => this.GetAttributeValue<Money>(nameof (ait_totalincome));
      set
      {
        this.OnPropertyChanging(nameof (ait_totalincome));
        this.SetAttributeValue(nameof (ait_totalincome), (object) value);
        this.OnPropertyChanged(nameof (ait_totalincome));
      }
    }

    [AttributeLogicalName("ait_totalincome_base")]
    public Money ait_totalincome_Base => this.GetAttributeValue<Money>("ait_totalincome_base");

    [AttributeLogicalName("ait_totalunearnedincome")]
    public Money ait_totalunearnedincome
    {
      get => this.GetAttributeValue<Money>(nameof (ait_totalunearnedincome));
      set
      {
        this.OnPropertyChanging(nameof (ait_totalunearnedincome));
        this.SetAttributeValue(nameof (ait_totalunearnedincome), (object) value);
        this.OnPropertyChanged(nameof (ait_totalunearnedincome));
      }
    }

    [AttributeLogicalName("ait_totalunearnedincome_base")]
    public Money ait_totalunearnedincome_Base
    {
      get => this.GetAttributeValue<Money>("ait_totalunearnedincome_base");
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
    public ait_householdState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_householdState?((ait_householdState) Enum.ToObject(typeof (ait_householdState), attributeValue.Value)) : new ait_householdState?();
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

    [RelationshipSchemaName("ait_ait_household_contact_household")]
    public IEnumerable<Contact> ait_ait_household_contact_household
    {
      get
      {
        return this.GetRelatedEntities<Contact>(nameof (ait_ait_household_contact_household), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_household_contact_household));
        this.SetRelatedEntities<Contact>(nameof (ait_ait_household_contact_household), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_household_contact_household));
      }
    }

    [RelationshipSchemaName("ait_ait_householdmember_ait_household")]
    public IEnumerable<ait_householdmember> ait_ait_householdmember_ait_household
    {
      get
      {
        return this.GetRelatedEntities<ait_householdmember>(nameof (ait_ait_householdmember_ait_household), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_householdmember_ait_household));
        this.SetRelatedEntities<ait_householdmember>(nameof (ait_ait_householdmember_ait_household), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_householdmember_ait_household));
      }
    }

    [RelationshipSchemaName("ait_household_Annotations")]
    public IEnumerable<Annotation> ait_household_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (ait_household_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_household_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (ait_household_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_household_Annotations));
      }
    }

    [RelationshipSchemaName("ait_household_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_household_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_household_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_household_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_household_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_household_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_household_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_household_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_household_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_household_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_household_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_household_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_household_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_household_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_household_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_household_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_household_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_household_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_household_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_household_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_household_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_household_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_household_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_household_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_household_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_household_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_household_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_household_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_household_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_household_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_household_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_household_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_household_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_household_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_household_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_household_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_household_ProcessSession")]
    public IEnumerable<ProcessSession> ait_household_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_household_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_household_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_household_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_household_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_household_SyncErrors")]
    public IEnumerable<SyncError> ait_household_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_household_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_household_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_household_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_household_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_household_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_household_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_household_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_household_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_household_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_household_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_headofhousehold")]
    [RelationshipSchemaName("ait_ait_household_contact")]
    public Contact ait_ait_household_contact
    {
      get => this.GetRelatedEntity<Contact>(nameof (ait_ait_household_contact), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_household_contact));
        this.SetRelatedEntity<Contact>(nameof (ait_ait_household_contact), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_household_contact));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_household")]
    public BusinessUnit business_unit_ait_household
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_household), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_household_createdby")]
    public SystemUser lk_ait_household_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_household_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_household_createdonbehalfby")]
    public SystemUser lk_ait_household_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_household_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_household_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_household_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_household_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_household_modifiedby")]
    public SystemUser lk_ait_household_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_household_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_household_modifiedonbehalfby")]
    public SystemUser lk_ait_household_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_household_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_household_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_household_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_household_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_household")]
    public Team team_ait_household
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_household), new EntityRole?());
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_ait_household")]
    public TransactionCurrency TransactionCurrency_ait_household
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_ait_household), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_ait_household));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_ait_household), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_ait_household));
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_household")]
    public SystemUser user_ait_household
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_ait_household), new EntityRole?());
    }

    public ait_household(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_householdid"] = (object) base.Id;
            break;
          case "ait_householdid":
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
