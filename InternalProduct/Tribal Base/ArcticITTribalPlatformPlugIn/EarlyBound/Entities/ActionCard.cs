// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ActionCard
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("actioncard")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ActionCard : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "actioncard";
    public const string EntitySchemaName = "ActionCard";
    public const string PrimaryIdAttribute = "actioncardid";
    public const string PrimaryNameAttribute = "title";

    public ActionCard()
      : base("actioncard")
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

    [AttributeLogicalName("actioncardid")]
    public Guid? ActionCardId
    {
      get => this.GetAttributeValue<Guid?>("actioncardid");
      set
      {
        this.OnPropertyChanging(nameof (ActionCardId));
        this.SetAttributeValue("actioncardid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ActionCardId));
      }
    }

    [AttributeLogicalName("actioncardid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ActionCardId = new Guid?(value);
    }

    [AttributeLogicalName("cardtype")]
    public int? CardType
    {
      get => this.GetAttributeValue<int?>("cardtype");
      set
      {
        this.OnPropertyChanging(nameof (CardType));
        this.SetAttributeValue("cardtype", (object) value);
        this.OnPropertyChanged(nameof (CardType));
      }
    }

    [AttributeLogicalName("cardtypeid")]
    public EntityReference CardTypeId
    {
      get => this.GetAttributeValue<EntityReference>("cardtypeid");
      set
      {
        this.OnPropertyChanging(nameof (CardTypeId));
        this.SetAttributeValue("cardtypeid", (object) value);
        this.OnPropertyChanged(nameof (CardTypeId));
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

    [AttributeLogicalName("data")]
    public string Data
    {
      get => this.GetAttributeValue<string>("data");
      set
      {
        this.OnPropertyChanging(nameof (Data));
        this.SetAttributeValue("data", (object) value);
        this.OnPropertyChanged(nameof (Data));
      }
    }

    [AttributeLogicalName("description")]
    public string Description
    {
      get => this.GetAttributeValue<string>("description");
      set
      {
        this.OnPropertyChanging(nameof (Description));
        this.SetAttributeValue("description", (object) value);
        this.OnPropertyChanged(nameof (Description));
      }
    }

    [AttributeLogicalName("exchangerate")]
    public Decimal? ExchangeRate => this.GetAttributeValue<Decimal?>("exchangerate");

    [AttributeLogicalName("expirydate")]
    public DateTime? ExpiryDate
    {
      get => this.GetAttributeValue<DateTime?>("expirydate");
      set
      {
        this.OnPropertyChanging(nameof (ExpiryDate));
        this.SetAttributeValue("expirydate", (object) value);
        this.OnPropertyChanged(nameof (ExpiryDate));
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

    [AttributeLogicalName("parentregardingobjectid")]
    public EntityReference ParentRegardingObjectId
    {
      get => this.GetAttributeValue<EntityReference>("parentregardingobjectid");
      set
      {
        this.OnPropertyChanging(nameof (ParentRegardingObjectId));
        this.SetAttributeValue("parentregardingobjectid", (object) value);
        this.OnPropertyChanged(nameof (ParentRegardingObjectId));
      }
    }

    [AttributeLogicalName("parentregardingobjectiddata")]
    public string ParentRegardingObjectIdData
    {
      get => this.GetAttributeValue<string>("parentregardingobjectiddata");
      set
      {
        this.OnPropertyChanging(nameof (ParentRegardingObjectIdData));
        this.SetAttributeValue("parentregardingobjectiddata", (object) value);
        this.OnPropertyChanged(nameof (ParentRegardingObjectIdData));
      }
    }

    [AttributeLogicalName("priority")]
    public int? Priority
    {
      get => this.GetAttributeValue<int?>("priority");
      set
      {
        this.OnPropertyChanging(nameof (Priority));
        this.SetAttributeValue("priority", (object) value);
        this.OnPropertyChanged(nameof (Priority));
      }
    }

    [AttributeLogicalName("recordid")]
    public EntityReference RecordId
    {
      get => this.GetAttributeValue<EntityReference>("recordid");
      set
      {
        this.OnPropertyChanging(nameof (RecordId));
        this.SetAttributeValue("recordid", (object) value);
        this.OnPropertyChanged(nameof (RecordId));
      }
    }

    [AttributeLogicalName("recordidobjecttypecode2")]
    public int? RecordIdObjectTypeCode2
    {
      get => this.GetAttributeValue<int?>("recordidobjecttypecode2");
      set
      {
        this.OnPropertyChanging(nameof (RecordIdObjectTypeCode2));
        this.SetAttributeValue("recordidobjecttypecode2", (object) value);
        this.OnPropertyChanged(nameof (RecordIdObjectTypeCode2));
      }
    }

    [AttributeLogicalName("referencetokens")]
    public string ReferenceTokens
    {
      get => this.GetAttributeValue<string>("referencetokens");
      set
      {
        this.OnPropertyChanging(nameof (ReferenceTokens));
        this.SetAttributeValue("referencetokens", (object) value);
        this.OnPropertyChanged(nameof (ReferenceTokens));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    public EntityReference RegardingObjectId
    {
      get => this.GetAttributeValue<EntityReference>("regardingobjectid");
      set
      {
        this.OnPropertyChanging(nameof (RegardingObjectId));
        this.SetAttributeValue("regardingobjectid", (object) value);
        this.OnPropertyChanged(nameof (RegardingObjectId));
      }
    }

    [AttributeLogicalName("source")]
    public OptionSetValue Source
    {
      get => this.GetAttributeValue<OptionSetValue>("source");
      set
      {
        this.OnPropertyChanging(nameof (Source));
        this.SetAttributeValue("source", (object) value);
        this.OnPropertyChanged(nameof (Source));
      }
    }

    [AttributeLogicalName("startdate")]
    public DateTime? StartDate
    {
      get => this.GetAttributeValue<DateTime?>("startdate");
      set
      {
        this.OnPropertyChanging(nameof (StartDate));
        this.SetAttributeValue("startdate", (object) value);
        this.OnPropertyChanged(nameof (StartDate));
      }
    }

    [AttributeLogicalName("state")]
    public OptionSetValue State
    {
      get => this.GetAttributeValue<OptionSetValue>("state");
      set
      {
        this.OnPropertyChanging(nameof (State));
        this.SetAttributeValue("state", (object) value);
        this.OnPropertyChanged(nameof (State));
      }
    }

    [AttributeLogicalName("title")]
    public string Title
    {
      get => this.GetAttributeValue<string>("title");
      set
      {
        this.OnPropertyChanging(nameof (Title));
        this.SetAttributeValue("title", (object) value);
        this.OnPropertyChanged(nameof (Title));
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

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [AttributeLogicalName("visibility")]
    public bool? Visibility
    {
      get => this.GetAttributeValue<bool?>("visibility");
      set
      {
        this.OnPropertyChanging(nameof (Visibility));
        this.SetAttributeValue("visibility", (object) value);
        this.OnPropertyChanged(nameof (Visibility));
      }
    }

    [RelationshipSchemaName("ActionCardUserState_ActionCard")]
    public IEnumerable<ActionCardUserState> ActionCardUserState_ActionCard
    {
      get
      {
        return this.GetRelatedEntities<ActionCardUserState>(nameof (ActionCardUserState_ActionCard), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ActionCardUserState_ActionCard));
        this.SetRelatedEntities<ActionCardUserState>(nameof (ActionCardUserState_ActionCard), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ActionCardUserState_ActionCard));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("account_actioncard")]
    public Account account_actioncard
    {
      get => this.GetRelatedEntity<Account>(nameof (account_actioncard), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (account_actioncard));
        this.SetRelatedEntity<Account>(nameof (account_actioncard), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (account_actioncard));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("appointment_actioncard")]
    public Appointment appointment_actioncard
    {
      get => this.GetRelatedEntity<Appointment>(nameof (appointment_actioncard), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (appointment_actioncard));
        this.SetRelatedEntity<Appointment>(nameof (appointment_actioncard), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appointment_actioncard));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_actioncards")]
    public BusinessUnit business_unit_actioncards
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_actioncards), new EntityRole?());
      }
    }

    [AttributeLogicalName("cardtypeid")]
    [RelationshipSchemaName("cardtype_actioncard")]
    public ArcticIT.EarlyBound.Entities.CardType cardtype_actioncard
    {
      get => this.GetRelatedEntity<ArcticIT.EarlyBound.Entities.CardType>(nameof (cardtype_actioncard), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (cardtype_actioncard));
        this.SetRelatedEntity<ArcticIT.EarlyBound.Entities.CardType>(nameof (cardtype_actioncard), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (cardtype_actioncard));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("contact_actioncard")]
    public Contact contact_actioncard
    {
      get => this.GetRelatedEntity<Contact>(nameof (contact_actioncard), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (contact_actioncard));
        this.SetRelatedEntity<Contact>(nameof (contact_actioncard), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (contact_actioncard));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("email_actioncard")]
    public Email email_actioncard
    {
      get => this.GetRelatedEntity<Email>(nameof (email_actioncard), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (email_actioncard));
        this.SetRelatedEntity<Email>(nameof (email_actioncard), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (email_actioncard));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("fax_actioncard")]
    public Fax fax_actioncard
    {
      get => this.GetRelatedEntity<Fax>(nameof (fax_actioncard), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (fax_actioncard));
        this.SetRelatedEntity<Fax>(nameof (fax_actioncard), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (fax_actioncard));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("letter_actioncard")]
    public Letter letter_actioncard
    {
      get => this.GetRelatedEntity<Letter>(nameof (letter_actioncard), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (letter_actioncard));
        this.SetRelatedEntity<Letter>(nameof (letter_actioncard), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (letter_actioncard));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_actioncardbase_createdby")]
    public SystemUser lk_actioncardbase_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_actioncardbase_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_actioncardbase_createdonbehalfby")]
    public SystemUser lk_actioncardbase_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_actioncardbase_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_actioncardbase_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_actioncardbase_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_actioncardbase_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_actioncardbase_modifiedby")]
    public SystemUser lk_actioncardbase_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_actioncardbase_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_actioncardbase_modifiedonbehalfby")]
    public SystemUser lk_actioncardbase_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_actioncardbase_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_actioncardbase_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_actioncardbase_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_actioncardbase_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("phonecall_actioncard")]
    public PhoneCall phonecall_actioncard
    {
      get => this.GetRelatedEntity<PhoneCall>(nameof (phonecall_actioncard), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (phonecall_actioncard));
        this.SetRelatedEntity<PhoneCall>(nameof (phonecall_actioncard), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (phonecall_actioncard));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("recurringappointmentmaster_actioncard")]
    public RecurringAppointmentMaster recurringappointmentmaster_actioncard
    {
      get
      {
        return this.GetRelatedEntity<RecurringAppointmentMaster>(nameof (recurringappointmentmaster_actioncard), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (recurringappointmentmaster_actioncard));
        this.SetRelatedEntity<RecurringAppointmentMaster>(nameof (recurringappointmentmaster_actioncard), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (recurringappointmentmaster_actioncard));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("task_actioncard")]
    public Task task_actioncard
    {
      get => this.GetRelatedEntity<Task>(nameof (task_actioncard), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (task_actioncard));
        this.SetRelatedEntity<Task>(nameof (task_actioncard), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (task_actioncard));
      }
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("transactioncurrency_actioncard")]
    public TransactionCurrency transactioncurrency_actioncard
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (transactioncurrency_actioncard), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (transactioncurrency_actioncard));
        this.SetRelatedEntity<TransactionCurrency>(nameof (transactioncurrency_actioncard), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (transactioncurrency_actioncard));
      }
    }

    public ActionCard(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["actioncardid"] = (object) base.Id;
            break;
          case "actioncardid":
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
