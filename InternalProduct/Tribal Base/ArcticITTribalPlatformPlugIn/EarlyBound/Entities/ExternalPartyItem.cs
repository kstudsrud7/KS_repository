// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ExternalPartyItem
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("externalpartyitem")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ExternalPartyItem : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "externalpartyitem";
    public const string EntitySchemaName = "ExternalPartyItem";
    public const string PrimaryIdAttribute = "externalpartyitemid";
    public const string PrimaryNameAttribute = "name";

    public ExternalPartyItem()
      : base("externalpartyitem")
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

    [AttributeLogicalName("channelaccessprofileid")]
    public EntityReference ChannelAccessProfileId
    {
      get => this.GetAttributeValue<EntityReference>("channelaccessprofileid");
      set
      {
        this.OnPropertyChanging(nameof (ChannelAccessProfileId));
        this.SetAttributeValue("channelaccessprofileid", (object) value);
        this.OnPropertyChanged(nameof (ChannelAccessProfileId));
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

    [AttributeLogicalName("externalpartyid")]
    public EntityReference ExternalPartyId
    {
      get => this.GetAttributeValue<EntityReference>("externalpartyid");
      set
      {
        this.OnPropertyChanging(nameof (ExternalPartyId));
        this.SetAttributeValue("externalpartyid", (object) value);
        this.OnPropertyChanged(nameof (ExternalPartyId));
      }
    }

    [AttributeLogicalName("externalpartyitemid")]
    public Guid? ExternalPartyItemId
    {
      get => this.GetAttributeValue<Guid?>("externalpartyitemid");
      set
      {
        this.OnPropertyChanging(nameof (ExternalPartyItemId));
        this.SetAttributeValue("externalpartyitemid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ExternalPartyItemId));
      }
    }

    [AttributeLogicalName("externalpartyitemid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ExternalPartyItemId = new Guid?(value);
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

    [AttributeLogicalName("introducedversion")]
    public string IntroducedVersion
    {
      get => this.GetAttributeValue<string>("introducedversion");
      set
      {
        this.OnPropertyChanging(nameof (IntroducedVersion));
        this.SetAttributeValue("introducedversion", (object) value);
        this.OnPropertyChanged(nameof (IntroducedVersion));
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
    public string Name
    {
      get => this.GetAttributeValue<string>("name");
      set
      {
        this.OnPropertyChanging(nameof (Name));
        this.SetAttributeValue("name", (object) value);
        this.OnPropertyChanged(nameof (Name));
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
      set
      {
        this.OnPropertyChanging(nameof (OwningBusinessUnit));
        this.SetAttributeValue("owningbusinessunit", (object) value);
        this.OnPropertyChanged(nameof (OwningBusinessUnit));
      }
    }

    [AttributeLogicalName("owninguser")]
    public EntityReference OwningUser => this.GetAttributeValue<EntityReference>("owninguser");

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

    [AttributeLogicalName("statecode")]
    public ExternalPartyItemState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ExternalPartyItemState?((ExternalPartyItemState) Enum.ToObject(typeof (ExternalPartyItemState), attributeValue.Value)) : new ExternalPartyItemState?();
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

    [RelationshipSchemaName("externalpartyitem_AsyncOperations")]
    public IEnumerable<AsyncOperation> externalpartyitem_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (externalpartyitem_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (externalpartyitem_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (externalpartyitem_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (externalpartyitem_AsyncOperations));
      }
    }

    [RelationshipSchemaName("externalpartyitem_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> externalpartyitem_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (externalpartyitem_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (externalpartyitem_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (externalpartyitem_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (externalpartyitem_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("externalpartyitem_ProcessSession")]
    public IEnumerable<ProcessSession> externalpartyitem_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (externalpartyitem_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (externalpartyitem_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (externalpartyitem_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (externalpartyitem_ProcessSession));
      }
    }

    [RelationshipSchemaName("ExternalPartyItem_SyncErrors")]
    public IEnumerable<SyncError> ExternalPartyItem_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ExternalPartyItem_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ExternalPartyItem_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ExternalPartyItem_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ExternalPartyItem_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Contact_ExternalPartyItems")]
    public Contact Contact_ExternalPartyItems
    {
      get => this.GetRelatedEntity<Contact>(nameof (Contact_ExternalPartyItems), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Contact_ExternalPartyItems));
        this.SetRelatedEntity<Contact>(nameof (Contact_ExternalPartyItems), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Contact_ExternalPartyItems));
      }
    }

    [AttributeLogicalName("externalpartyid")]
    [RelationshipSchemaName("externalparty_entries")]
    public ExternalParty externalparty_entries
    {
      get
      {
        return this.GetRelatedEntity<ExternalParty>(nameof (externalparty_entries), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (externalparty_entries));
        this.SetRelatedEntity<ExternalParty>(nameof (externalparty_entries), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (externalparty_entries));
      }
    }

    [AttributeLogicalName("channelaccessprofileid")]
    [RelationshipSchemaName("lk_externalpartyitem_channelaccessprofileid")]
    public ChannelAccessProfile lk_externalpartyitem_channelaccessprofileid
    {
      get
      {
        return this.GetRelatedEntity<ChannelAccessProfile>(nameof (lk_externalpartyitem_channelaccessprofileid), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_externalpartyitem_channelaccessprofileid));
        this.SetRelatedEntity<ChannelAccessProfile>(nameof (lk_externalpartyitem_channelaccessprofileid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_externalpartyitem_channelaccessprofileid));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_externalpartyitem_createdby")]
    public SystemUser lk_externalpartyitem_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_externalpartyitem_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_externalpartyitem_createdonbehalfby")]
    public SystemUser lk_externalpartyitem_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_externalpartyitem_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_externalpartyitem_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_externalpartyitem_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_externalpartyitem_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_externalpartyitem_modifiedby")]
    public SystemUser lk_externalpartyitem_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_externalpartyitem_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_externalpartyitem_modifiedonbehalfby")]
    public SystemUser lk_externalpartyitem_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_externalpartyitem_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_externalpartyitem_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_externalpartyitem_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_externalpartyitem_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("SystemUser_ExternalPartyItems")]
    public SystemUser SystemUser_ExternalPartyItems
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (SystemUser_ExternalPartyItems), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SystemUser_ExternalPartyItems));
        this.SetRelatedEntity<SystemUser>(nameof (SystemUser_ExternalPartyItems), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SystemUser_ExternalPartyItems));
      }
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_externalpartyitem")]
    public TransactionCurrency TransactionCurrency_externalpartyitem
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_externalpartyitem), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_externalpartyitem));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_externalpartyitem), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_externalpartyitem));
      }
    }

    public ExternalPartyItem(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["externalpartyitemid"] = (object) base.Id;
            break;
          case "externalpartyitemid":
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
