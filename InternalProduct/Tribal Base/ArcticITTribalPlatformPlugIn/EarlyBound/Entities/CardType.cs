// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.CardType
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("cardtype")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class CardType : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "cardtype";
    public const string EntitySchemaName = "CardType";
    public const string PrimaryIdAttribute = "cardtypeid";
    public const string PrimaryNameAttribute = "cardname";

    public CardType()
      : base("cardtype")
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

    [AttributeLogicalName("actions")]
    public string Actions
    {
      get => this.GetAttributeValue<string>("actions");
      set
      {
        this.OnPropertyChanging(nameof (Actions));
        this.SetAttributeValue("actions", (object) value);
        this.OnPropertyChanged(nameof (Actions));
      }
    }

    [AttributeLogicalName("adaptivecardtemplate")]
    public string AdaptiveCardTemplate
    {
      get => this.GetAttributeValue<string>("adaptivecardtemplate");
      set
      {
        this.OnPropertyChanging(nameof (AdaptiveCardTemplate));
        this.SetAttributeValue("adaptivecardtemplate", (object) value);
        this.OnPropertyChanged(nameof (AdaptiveCardTemplate));
      }
    }

    [AttributeLogicalName("boolcardoption")]
    public bool? BoolCardOption
    {
      get => this.GetAttributeValue<bool?>("boolcardoption");
      set
      {
        this.OnPropertyChanging(nameof (BoolCardOption));
        this.SetAttributeValue("boolcardoption", (object) value);
        this.OnPropertyChanged(nameof (BoolCardOption));
      }
    }

    [AttributeLogicalName("cardname")]
    public string CardName
    {
      get => this.GetAttributeValue<string>("cardname");
      set
      {
        this.OnPropertyChanging(nameof (CardName));
        this.SetAttributeValue("cardname", (object) value);
        this.OnPropertyChanged(nameof (CardName));
      }
    }

    [AttributeLogicalName("cardtype")]
    public int? CardType1
    {
      get => this.GetAttributeValue<int?>("cardtype");
      set
      {
        this.OnPropertyChanging(nameof (CardType1));
        this.SetAttributeValue("cardtype", (object) value);
        this.OnPropertyChanged(nameof (CardType1));
      }
    }

    [AttributeLogicalName("cardtypeicon")]
    public string CardTypeIcon
    {
      get => this.GetAttributeValue<string>("cardtypeicon");
      set
      {
        this.OnPropertyChanging(nameof (CardTypeIcon));
        this.SetAttributeValue("cardtypeicon", (object) value);
        this.OnPropertyChanged(nameof (CardTypeIcon));
      }
    }

    [AttributeLogicalName("cardtypeid")]
    public Guid? CardTypeId
    {
      get => this.GetAttributeValue<Guid?>("cardtypeid");
      set
      {
        this.OnPropertyChanging(nameof (CardTypeId));
        this.SetAttributeValue("cardtypeid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (CardTypeId));
      }
    }

    [AttributeLogicalName("cardtypeid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.CardTypeId = new Guid?(value);
    }

    [AttributeLogicalName("clientavailability")]
    public OptionSetValue ClientAvailability
    {
      get => this.GetAttributeValue<OptionSetValue>("clientavailability");
      set
      {
        this.OnPropertyChanging(nameof (ClientAvailability));
        this.SetAttributeValue("clientavailability", (object) value);
        this.OnPropertyChanged(nameof (ClientAvailability));
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

    [AttributeLogicalName("groupcategory")]
    public int? GroupCategory
    {
      get => this.GetAttributeValue<int?>("groupcategory");
      set
      {
        this.OnPropertyChanging(nameof (GroupCategory));
        this.SetAttributeValue("groupcategory", (object) value);
        this.OnPropertyChanged(nameof (GroupCategory));
      }
    }

    [AttributeLogicalName("grouptype")]
    public string GroupType
    {
      get => this.GetAttributeValue<string>("grouptype");
      set
      {
        this.OnPropertyChanging(nameof (GroupType));
        this.SetAttributeValue("grouptype", (object) value);
        this.OnPropertyChanged(nameof (GroupType));
      }
    }

    [AttributeLogicalName("hassnoozedismiss")]
    public bool? HasSnoozeDismiss
    {
      get => this.GetAttributeValue<bool?>("hassnoozedismiss");
      set
      {
        this.OnPropertyChanging(nameof (HasSnoozeDismiss));
        this.SetAttributeValue("hassnoozedismiss", (object) value);
        this.OnPropertyChanged(nameof (HasSnoozeDismiss));
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

    [AttributeLogicalName("intcardoption")]
    public int? IntCardOption
    {
      get => this.GetAttributeValue<int?>("intcardoption");
      set
      {
        this.OnPropertyChanging(nameof (IntCardOption));
        this.SetAttributeValue("intcardoption", (object) value);
        this.OnPropertyChanged(nameof (IntCardOption));
      }
    }

    [AttributeLogicalName("isbasecard")]
    public bool? IsBaseCard
    {
      get => this.GetAttributeValue<bool?>("isbasecard");
      set
      {
        this.OnPropertyChanging(nameof (IsBaseCard));
        this.SetAttributeValue("isbasecard", (object) value);
        this.OnPropertyChanged(nameof (IsBaseCard));
      }
    }

    [AttributeLogicalName("isenabled")]
    public bool? IsEnabled
    {
      get => this.GetAttributeValue<bool?>("isenabled");
      set
      {
        this.OnPropertyChanging(nameof (IsEnabled));
        this.SetAttributeValue("isenabled", (object) value);
        this.OnPropertyChanged(nameof (IsEnabled));
      }
    }

    [AttributeLogicalName("isliveonly")]
    public bool? IsLiveOnly
    {
      get => this.GetAttributeValue<bool?>("isliveonly");
      set
      {
        this.OnPropertyChanging(nameof (IsLiveOnly));
        this.SetAttributeValue("isliveonly", (object) value);
        this.OnPropertyChanged(nameof (IsLiveOnly));
      }
    }

    [AttributeLogicalName("ispreviewcard")]
    public bool? IsPreviewCard
    {
      get => this.GetAttributeValue<bool?>("ispreviewcard");
      set
      {
        this.OnPropertyChanging(nameof (IsPreviewCard));
        this.SetAttributeValue("ispreviewcard", (object) value);
        this.OnPropertyChanged(nameof (IsPreviewCard));
      }
    }

    [AttributeLogicalName("lastsynctime")]
    public DateTime? LastSyncTime
    {
      get => this.GetAttributeValue<DateTime?>("lastsynctime");
      set
      {
        this.OnPropertyChanging(nameof (LastSyncTime));
        this.SetAttributeValue("lastsynctime", (object) value);
        this.OnPropertyChanged(nameof (LastSyncTime));
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

    [AttributeLogicalName("publishername")]
    public string PublisherName
    {
      get => this.GetAttributeValue<string>("publishername");
      set
      {
        this.OnPropertyChanging(nameof (PublisherName));
        this.SetAttributeValue("publishername", (object) value);
        this.OnPropertyChanged(nameof (PublisherName));
      }
    }

    [AttributeLogicalName("scheduletime")]
    public DateTime? ScheduleTime
    {
      get => this.GetAttributeValue<DateTime?>("scheduletime");
      set
      {
        this.OnPropertyChanging(nameof (ScheduleTime));
        this.SetAttributeValue("scheduletime", (object) value);
        this.OnPropertyChanged(nameof (ScheduleTime));
      }
    }

    [AttributeLogicalName("softtitle")]
    public string SoftTitle
    {
      get => this.GetAttributeValue<string>("softtitle");
      set
      {
        this.OnPropertyChanging(nameof (SoftTitle));
        this.SetAttributeValue("softtitle", (object) value);
        this.OnPropertyChanged(nameof (SoftTitle));
      }
    }

    [AttributeLogicalName("stringcardoption")]
    public string StringCardOption
    {
      get => this.GetAttributeValue<string>("stringcardoption");
      set
      {
        this.OnPropertyChanging(nameof (StringCardOption));
        this.SetAttributeValue("stringcardoption", (object) value);
        this.OnPropertyChanged(nameof (StringCardOption));
      }
    }

    [AttributeLogicalName("summarytext")]
    public string SummaryText
    {
      get => this.GetAttributeValue<string>("summarytext");
      set
      {
        this.OnPropertyChanging(nameof (SummaryText));
        this.SetAttributeValue("summarytext", (object) value);
        this.OnPropertyChanged(nameof (SummaryText));
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

    [RelationshipSchemaName("cardtype_actioncard")]
    public IEnumerable<ActionCard> cardtype_actioncard
    {
      get => this.GetRelatedEntities<ActionCard>(nameof (cardtype_actioncard), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (cardtype_actioncard));
        this.SetRelatedEntities<ActionCard>(nameof (cardtype_actioncard), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (cardtype_actioncard));
      }
    }

    [RelationshipSchemaName("cardtype_actioncardusersettings")]
    public IEnumerable<ActionCardUserSettings> cardtype_actioncardusersettings
    {
      get
      {
        return this.GetRelatedEntities<ActionCardUserSettings>(nameof (cardtype_actioncardusersettings), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (cardtype_actioncardusersettings));
        this.SetRelatedEntities<ActionCardUserSettings>(nameof (cardtype_actioncardusersettings), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (cardtype_actioncardusersettings));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_cardtype_createdby")]
    public SystemUser lk_cardtype_createdby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_cardtype_createdby), new EntityRole?());
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_cardtype_createdonbehalfby")]
    public SystemUser lk_cardtype_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_cardtype_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_cardtype_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_cardtype_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_cardtype_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_cardtype_modifiedby")]
    public SystemUser lk_cardtype_modifiedby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_cardtype_modifiedby), new EntityRole?());
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_cardtype_modifiedonbehalfby")]
    public SystemUser lk_cardtype_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_cardtype_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_cardtype_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_cardtype_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_cardtype_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("transactioncurrency_cardtype")]
    public TransactionCurrency transactioncurrency_cardtype
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (transactioncurrency_cardtype), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (transactioncurrency_cardtype));
        this.SetRelatedEntity<TransactionCurrency>(nameof (transactioncurrency_cardtype), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (transactioncurrency_cardtype));
      }
    }

    public CardType(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["cardtypeid"] = (object) base.Id;
            break;
          case "cardtypeid":
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
