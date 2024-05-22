// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_contactincomeandexpense
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_contactincomeandexpense")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_contactincomeandexpense : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_contactincomeandexpense";
    public const string EntitySchemaName = "ait_contactincomeandexpense";
    public const string PrimaryIdAttribute = "ait_contactincomeandexpenseid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_contactincomeandexpense()
      : base(nameof (ait_contactincomeandexpense))
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

    [AttributeLogicalName("ait_category")]
    public EntityReference ait_category
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_category));
      set
      {
        this.OnPropertyChanging(nameof (ait_category));
        this.SetAttributeValue(nameof (ait_category), (object) value);
        this.OnPropertyChanged(nameof (ait_category));
      }
    }

    [AttributeLogicalName("ait_contact")]
    public EntityReference ait_contact
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_contact));
      set
      {
        this.OnPropertyChanging(nameof (ait_contact));
        this.SetAttributeValue(nameof (ait_contact), (object) value);
        this.OnPropertyChanged(nameof (ait_contact));
      }
    }

    [AttributeLogicalName("ait_contactincomeandexpenseid")]
    public Guid? ait_contactincomeandexpenseId
    {
      get => this.GetAttributeValue<Guid?>("ait_contactincomeandexpenseid");
      set
      {
        this.OnPropertyChanging(nameof (ait_contactincomeandexpenseId));
        this.SetAttributeValue("ait_contactincomeandexpenseid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_contactincomeandexpenseId));
      }
    }

    [AttributeLogicalName("ait_contactincomeandexpenseid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_contactincomeandexpenseId = new Guid?(value);
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

    [AttributeLogicalName("ait_includeinrollup")]
    public bool? ait_includeinrollup
    {
      get => this.GetAttributeValue<bool?>(nameof (ait_includeinrollup));
      set
      {
        this.OnPropertyChanging(nameof (ait_includeinrollup));
        this.SetAttributeValue(nameof (ait_includeinrollup), (object) value);
        this.OnPropertyChanged(nameof (ait_includeinrollup));
      }
    }

    [AttributeLogicalName("ait_incomeorexpensetype")]
    public OptionSetValue ait_incomeorexpensetype
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_incomeorexpensetype));
      set
      {
        this.OnPropertyChanging(nameof (ait_incomeorexpensetype));
        this.SetAttributeValue(nameof (ait_incomeorexpensetype), (object) value);
        this.OnPropertyChanged(nameof (ait_incomeorexpensetype));
      }
    }

    [AttributeLogicalName("ait_monthlyamount")]
    public Money ait_monthlyamount
    {
      get => this.GetAttributeValue<Money>(nameof (ait_monthlyamount));
      set
      {
        this.OnPropertyChanging(nameof (ait_monthlyamount));
        this.SetAttributeValue(nameof (ait_monthlyamount), (object) value);
        this.OnPropertyChanged(nameof (ait_monthlyamount));
      }
    }

    [AttributeLogicalName("ait_monthlyamount_base")]
    public Money ait_monthlyamount_Base => this.GetAttributeValue<Money>("ait_monthlyamount_base");

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

    [AttributeLogicalName("ait_source")]
    public string ait_source
    {
      get => this.GetAttributeValue<string>(nameof (ait_source));
      set
      {
        this.OnPropertyChanging(nameof (ait_source));
        this.SetAttributeValue(nameof (ait_source), (object) value);
        this.OnPropertyChanged(nameof (ait_source));
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
    public ait_contactincomeandexpenseState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_contactincomeandexpenseState?((ait_contactincomeandexpenseState) Enum.ToObject(typeof (ait_contactincomeandexpenseState), attributeValue.Value)) : new ait_contactincomeandexpenseState?();
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

    [RelationshipSchemaName("ait_contactincomeandexpense_Annotations")]
    public IEnumerable<Annotation> ait_contactincomeandexpense_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (ait_contactincomeandexpense_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactincomeandexpense_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (ait_contactincomeandexpense_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactincomeandexpense_Annotations));
      }
    }

    [RelationshipSchemaName("ait_contactincomeandexpense_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_contactincomeandexpense_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_contactincomeandexpense_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactincomeandexpense_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_contactincomeandexpense_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactincomeandexpense_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_contactincomeandexpense_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_contactincomeandexpense_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_contactincomeandexpense_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactincomeandexpense_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_contactincomeandexpense_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactincomeandexpense_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_contactincomeandexpense_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_contactincomeandexpense_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_contactincomeandexpense_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactincomeandexpense_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_contactincomeandexpense_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactincomeandexpense_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_contactincomeandexpense_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_contactincomeandexpense_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_contactincomeandexpense_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactincomeandexpense_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_contactincomeandexpense_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactincomeandexpense_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_contactincomeandexpense_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_contactincomeandexpense_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_contactincomeandexpense_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactincomeandexpense_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_contactincomeandexpense_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactincomeandexpense_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_contactincomeandexpense_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_contactincomeandexpense_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_contactincomeandexpense_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactincomeandexpense_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_contactincomeandexpense_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactincomeandexpense_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_contactincomeandexpense_ProcessSession")]
    public IEnumerable<ProcessSession> ait_contactincomeandexpense_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_contactincomeandexpense_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactincomeandexpense_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_contactincomeandexpense_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactincomeandexpense_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_contactincomeandexpense_SyncErrors")]
    public IEnumerable<SyncError> ait_contactincomeandexpense_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_contactincomeandexpense_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactincomeandexpense_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_contactincomeandexpense_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactincomeandexpense_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_contactincomeandexpense_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_contactincomeandexpense_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_contactincomeandexpense_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactincomeandexpense_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_contactincomeandexpense_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactincomeandexpense_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_contact")]
    [RelationshipSchemaName("ait_ait_contactincomeandexpense_contact")]
    public Contact ait_ait_contactincomeandexpense_contact
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (ait_ait_contactincomeandexpense_contact), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_contactincomeandexpense_contact));
        this.SetRelatedEntity<Contact>(nameof (ait_ait_contactincomeandexpense_contact), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_contactincomeandexpense_contact));
      }
    }

    [AttributeLogicalName("ait_category")]
    [RelationshipSchemaName("ait_ait_incomeorexpensecategory_ait_contactincomeandexpense_category")]
    public ait_incomeorexpensecategory ait_ait_incomeorexpensecategory_ait_contactincomeandexpense_category
    {
      get
      {
        return this.GetRelatedEntity<ait_incomeorexpensecategory>(nameof (ait_ait_incomeorexpensecategory_ait_contactincomeandexpense_category), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_incomeorexpensecategory_ait_contactincomeandexpense_category));
        this.SetRelatedEntity<ait_incomeorexpensecategory>(nameof (ait_ait_incomeorexpensecategory_ait_contactincomeandexpense_category), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_incomeorexpensecategory_ait_contactincomeandexpense_category));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_contactincomeandexpense")]
    public BusinessUnit business_unit_ait_contactincomeandexpense
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_contactincomeandexpense), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_contactincomeandexpense_createdby")]
    public SystemUser lk_ait_contactincomeandexpense_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_contactincomeandexpense_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_contactincomeandexpense_createdonbehalfby")]
    public SystemUser lk_ait_contactincomeandexpense_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_contactincomeandexpense_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_contactincomeandexpense_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_contactincomeandexpense_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_contactincomeandexpense_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_contactincomeandexpense_modifiedby")]
    public SystemUser lk_ait_contactincomeandexpense_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_contactincomeandexpense_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_contactincomeandexpense_modifiedonbehalfby")]
    public SystemUser lk_ait_contactincomeandexpense_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_contactincomeandexpense_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_contactincomeandexpense_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_contactincomeandexpense_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_contactincomeandexpense_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_contactincomeandexpense")]
    public Team team_ait_contactincomeandexpense
    {
      get
      {
        return this.GetRelatedEntity<Team>(nameof (team_ait_contactincomeandexpense), new EntityRole?());
      }
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_ait_contactincomeandexpense")]
    public TransactionCurrency TransactionCurrency_ait_contactincomeandexpense
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_ait_contactincomeandexpense), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_ait_contactincomeandexpense));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_ait_contactincomeandexpense), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_ait_contactincomeandexpense));
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_contactincomeandexpense")]
    public SystemUser user_ait_contactincomeandexpense
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_ait_contactincomeandexpense), new EntityRole?());
      }
    }

    public ait_contactincomeandexpense(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_contactincomeandexpenseid"] = (object) base.Id;
            break;
          case "ait_contactincomeandexpenseid":
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
