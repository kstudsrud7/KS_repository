// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.InteractionForEmail
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("interactionforemail")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class InteractionForEmail : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "interactionforemail";
    public const string EntitySchemaName = "InteractionForEmail";
    public const string PrimaryIdAttribute = "interactionforemailid";
    public const string PrimaryNameAttribute = "name";

    public InteractionForEmail()
      : base("interactionforemail")
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

    [AttributeLogicalName("emailactivityid")]
    public Guid? EmailActivityId => this.GetAttributeValue<Guid?>("emailactivityid");

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

    [AttributeLogicalName("emailinteractionreplyid")]
    public Guid? EmailInteractionReplyId
    {
      get => this.GetAttributeValue<Guid?>("emailinteractionreplyid");
    }

    [AttributeLogicalName("emailinteractiontime")]
    public DateTime? EmailInteractionTime
    {
      get => this.GetAttributeValue<DateTime?>("emailinteractiontime");
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

    [AttributeLogicalName("interactedcomponenttext")]
    public string InteractedComponentText
    {
      get => this.GetAttributeValue<string>("interactedcomponenttext");
      set
      {
        this.OnPropertyChanging(nameof (InteractedComponentText));
        this.SetAttributeValue("interactedcomponenttext", (object) value);
        this.OnPropertyChanged(nameof (InteractedComponentText));
      }
    }

    [AttributeLogicalName("interactionforemailid")]
    public Guid? InteractionForEmailId
    {
      get => this.GetAttributeValue<Guid?>("interactionforemailid");
      set
      {
        this.OnPropertyChanging(nameof (InteractionForEmailId));
        this.SetAttributeValue("interactionforemailid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (InteractionForEmailId));
      }
    }

    [AttributeLogicalName("interactionforemailid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.InteractionForEmailId = new Guid?(value);
    }

    [AttributeLogicalName("interactionlocation")]
    public string InteractionLocation
    {
      get => this.GetAttributeValue<string>("interactionlocation");
      set
      {
        this.OnPropertyChanging(nameof (InteractionLocation));
        this.SetAttributeValue("interactionlocation", (object) value);
        this.OnPropertyChanged(nameof (InteractionLocation));
      }
    }

    [AttributeLogicalName("interactionpartyid")]
    public Guid? InteractionPartyId => this.GetAttributeValue<Guid?>("interactionpartyid");

    [AttributeLogicalName("interactionrepliedby")]
    public string InteractionRepliedBy
    {
      get => this.GetAttributeValue<string>("interactionrepliedby");
      set
      {
        this.OnPropertyChanging(nameof (InteractionRepliedBy));
        this.SetAttributeValue("interactionrepliedby", (object) value);
        this.OnPropertyChanged(nameof (InteractionRepliedBy));
      }
    }

    [AttributeLogicalName("interactionreplyid")]
    public string InteractionReplyId
    {
      get => this.GetAttributeValue<string>("interactionreplyid");
      set
      {
        this.OnPropertyChanging(nameof (InteractionReplyId));
        this.SetAttributeValue("interactionreplyid", (object) value);
        this.OnPropertyChanged(nameof (InteractionReplyId));
      }
    }

    [AttributeLogicalName("interactiontype")]
    public OptionSetValue InteractionType
    {
      get => this.GetAttributeValue<OptionSetValue>("interactiontype");
    }

    [AttributeLogicalName("interactionuseragent")]
    public string InteractionUserAgent
    {
      get => this.GetAttributeValue<string>("interactionuseragent");
      set
      {
        this.OnPropertyChanging(nameof (InteractionUserAgent));
        this.SetAttributeValue("interactionuseragent", (object) value);
        this.OnPropertyChanged(nameof (InteractionUserAgent));
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

    [AttributeLogicalName("name")]
    public string name
    {
      get => this.GetAttributeValue<string>(nameof (name));
      set
      {
        this.OnPropertyChanging(nameof (name));
        this.SetAttributeValue(nameof (name), (object) value);
        this.OnPropertyChanged(nameof (name));
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
    public InteractionForEmailState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new InteractionForEmailState?((InteractionForEmailState) Enum.ToObject(typeof (InteractionForEmailState), attributeValue.Value)) : new InteractionForEmailState?();
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

    [RelationshipSchemaName("interactionforemail_ActivityPointers")]
    public IEnumerable<ActivityPointer> interactionforemail_ActivityPointers
    {
      get
      {
        return this.GetRelatedEntities<ActivityPointer>(nameof (interactionforemail_ActivityPointers), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (interactionforemail_ActivityPointers));
        this.SetRelatedEntities<ActivityPointer>(nameof (interactionforemail_ActivityPointers), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (interactionforemail_ActivityPointers));
      }
    }

    [RelationshipSchemaName("interactionforemail_AsyncOperations")]
    public IEnumerable<AsyncOperation> interactionforemail_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (interactionforemail_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (interactionforemail_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (interactionforemail_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (interactionforemail_AsyncOperations));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_interactionforemail")]
    public BusinessUnit business_unit_interactionforemail
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_interactionforemail), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_interactionforemail_createdby")]
    public SystemUser lk_interactionforemail_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_interactionforemail_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_interactionforemail_createdonbehalfby")]
    public SystemUser lk_interactionforemail_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_interactionforemail_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_interactionforemail_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_interactionforemail_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_interactionforemail_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_interactionforemail_modifiedby")]
    public SystemUser lk_interactionforemail_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_interactionforemail_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_interactionforemail_modifiedonbehalfby")]
    public SystemUser lk_interactionforemail_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_interactionforemail_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_interactionforemail_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_interactionforemail_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_interactionforemail_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_interactionforemail")]
    public Team team_interactionforemail
    {
      get => this.GetRelatedEntity<Team>(nameof (team_interactionforemail), new EntityRole?());
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_InteractionForEmail")]
    public TransactionCurrency TransactionCurrency_InteractionForEmail
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_InteractionForEmail), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_InteractionForEmail));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_InteractionForEmail), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_InteractionForEmail));
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_interactionforemail")]
    public SystemUser user_interactionforemail
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_interactionforemail), new EntityRole?());
      }
    }

    public InteractionForEmail(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["interactionforemailid"] = (object) base.Id;
            break;
          case "interactionforemailid":
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
