// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.DelveActionHub
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("delveactionhub")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class DelveActionHub : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "delveactionhub";
    public const string EntitySchemaName = "DelveActionHub";
    public const string PrimaryIdAttribute = "delveactionhubid";
    public const string PrimaryNameAttribute = "subject";

    public DelveActionHub()
      : base("delveactionhub")
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

    [AttributeLogicalName("cardtype")]
    public OptionSetValue CardType => this.GetAttributeValue<OptionSetValue>("cardtype");

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

    [AttributeLogicalName("createdtime")]
    public DateTime? CreatedTime => this.GetAttributeValue<DateTime?>("createdtime");

    [AttributeLogicalName("delveactionhubid")]
    public Guid? DelveActionHubId
    {
      get => this.GetAttributeValue<Guid?>("delveactionhubid");
      set
      {
        this.OnPropertyChanging(nameof (DelveActionHubId));
        this.SetAttributeValue("delveactionhubid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (DelveActionHubId));
      }
    }

    [AttributeLogicalName("delveactionhubid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.DelveActionHubId = new Guid?(value);
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

    [AttributeLogicalName("iconclassname")]
    public string IconClassName => this.GetAttributeValue<string>("iconclassname");

    [AttributeLogicalName("mailweblink")]
    public string MailWebLink
    {
      get => this.GetAttributeValue<string>("mailweblink");
      set
      {
        this.OnPropertyChanging(nameof (MailWebLink));
        this.SetAttributeValue("mailweblink", (object) value);
        this.OnPropertyChanged(nameof (MailWebLink));
      }
    }

    [AttributeLogicalName("messageid")]
    public string MessageId
    {
      get => this.GetAttributeValue<string>("messageid");
      set
      {
        this.OnPropertyChanging(nameof (MessageId));
        this.SetAttributeValue("messageid", (object) value);
        this.OnPropertyChanged(nameof (MessageId));
      }
    }

    [AttributeLogicalName("messagetime")]
    public DateTime? MessageTime => this.GetAttributeValue<DateTime?>("messagetime");

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

    [AttributeLogicalName("modifiedtime")]
    public DateTime? ModifiedTime => this.GetAttributeValue<DateTime?>("modifiedtime");

    [AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get => this.GetAttributeValue<EntityReference>("organizationid");
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

    [AttributeLogicalName("relatedmailids")]
    public string RelatedMailIds
    {
      get => this.GetAttributeValue<string>("relatedmailids");
      set
      {
        this.OnPropertyChanging(nameof (RelatedMailIds));
        this.SetAttributeValue("relatedmailids", (object) value);
        this.OnPropertyChanged(nameof (RelatedMailIds));
      }
    }

    [AttributeLogicalName("sender")]
    public string Sender
    {
      get => this.GetAttributeValue<string>("sender");
      set
      {
        this.OnPropertyChanging(nameof (Sender));
        this.SetAttributeValue("sender", (object) value);
        this.OnPropertyChanged(nameof (Sender));
      }
    }

    [AttributeLogicalName("senderentityid")]
    public Guid? SenderEntityId
    {
      get => this.GetAttributeValue<Guid?>("senderentityid");
      set
      {
        this.OnPropertyChanging(nameof (SenderEntityId));
        this.SetAttributeValue("senderentityid", (object) value);
        this.OnPropertyChanged(nameof (SenderEntityId));
      }
    }

    [AttributeLogicalName("senderentityobjecttypecode")]
    public int? SenderEntityObjectTypeCode
    {
      get => this.GetAttributeValue<int?>("senderentityobjecttypecode");
    }

    [AttributeLogicalName("senderimageurl")]
    public string SenderImageUrl
    {
      get => this.GetAttributeValue<string>("senderimageurl");
      set
      {
        this.OnPropertyChanging(nameof (SenderImageUrl));
        this.SetAttributeValue("senderimageurl", (object) value);
        this.OnPropertyChanged(nameof (SenderImageUrl));
      }
    }

    [AttributeLogicalName("statecode")]
    public DelveActionHubState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new DelveActionHubState?((DelveActionHubState) Enum.ToObject(typeof (DelveActionHubState), attributeValue.Value)) : new DelveActionHubState?();
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

    [AttributeLogicalName("subject")]
    public string Subject
    {
      get => this.GetAttributeValue<string>("subject");
      set
      {
        this.OnPropertyChanging(nameof (Subject));
        this.SetAttributeValue("subject", (object) value);
        this.OnPropertyChanged(nameof (Subject));
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

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_delveactionhub_createdby")]
    public SystemUser lk_delveactionhub_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_delveactionhub_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_delveactionhub_createdonbehalfby")]
    public SystemUser lk_delveactionhub_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_delveactionhub_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_delveactionhub_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_delveactionhub_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_delveactionhub_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_delveactionhub_modifiedby")]
    public SystemUser lk_delveactionhub_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_delveactionhub_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_delveactionhub_modifiedonbehalfby")]
    public SystemUser lk_delveactionhub_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_delveactionhub_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_delveactionhub_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_delveactionhub_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_delveactionhub_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_delveactionhub")]
    public Organization organization_delveactionhub
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_delveactionhub), new EntityRole?());
      }
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_delveactionhub")]
    public TransactionCurrency TransactionCurrency_delveactionhub
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_delveactionhub), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_delveactionhub));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_delveactionhub), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_delveactionhub));
      }
    }

    public DelveActionHub(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["delveactionhubid"] = (object) base.Id;
            break;
          case "delveactionhubid":
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
