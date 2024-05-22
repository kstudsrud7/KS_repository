// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.Territory
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("territory")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class Territory : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "territory";
    public const string EntitySchemaName = "Territory";
    public const string PrimaryIdAttribute = "territoryid";
    public const string PrimaryNameAttribute = "name";

    public Territory()
      : base("territory")
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

    [AttributeLogicalName("entityimage")]
    public byte[] EntityImage
    {
      get => this.GetAttributeValue<byte[]>("entityimage");
      set
      {
        this.OnPropertyChanging(nameof (EntityImage));
        this.SetAttributeValue("entityimage", (object) value);
        this.OnPropertyChanged(nameof (EntityImage));
      }
    }

    [AttributeLogicalName("entityimage_timestamp")]
    public long? EntityImage_Timestamp => this.GetAttributeValue<long?>("entityimage_timestamp");

    [AttributeLogicalName("entityimage_url")]
    public string EntityImage_URL => this.GetAttributeValue<string>("entityimage_url");

    [AttributeLogicalName("entityimageid")]
    public Guid? EntityImageId => this.GetAttributeValue<Guid?>("entityimageid");

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

    [AttributeLogicalName("managerid")]
    public EntityReference ManagerId
    {
      get => this.GetAttributeValue<EntityReference>("managerid");
      set
      {
        this.OnPropertyChanging(nameof (ManagerId));
        this.SetAttributeValue("managerid", (object) value);
        this.OnPropertyChanged(nameof (ManagerId));
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

    [AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get => this.GetAttributeValue<EntityReference>("organizationid");
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

    [AttributeLogicalName("parentterritoryid")]
    public EntityReference ParentTerritoryId
    {
      get => this.GetAttributeValue<EntityReference>("parentterritoryid");
      set
      {
        this.OnPropertyChanging(nameof (ParentTerritoryId));
        this.SetAttributeValue("parentterritoryid", (object) value);
        this.OnPropertyChanged(nameof (ParentTerritoryId));
      }
    }

    [AttributeLogicalName("territoryid")]
    public Guid? TerritoryId
    {
      get => this.GetAttributeValue<Guid?>("territoryid");
      set
      {
        this.OnPropertyChanging(nameof (TerritoryId));
        this.SetAttributeValue("territoryid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (TerritoryId));
      }
    }

    [AttributeLogicalName("territoryid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.TerritoryId = new Guid?(value);
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

    [RelationshipSchemaName("Territory_AsyncOperations")]
    public IEnumerable<AsyncOperation> Territory_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (Territory_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Territory_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (Territory_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Territory_AsyncOperations));
      }
    }

    [RelationshipSchemaName("Territory_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> Territory_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (Territory_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Territory_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (Territory_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Territory_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("territory_connections1")]
    public IEnumerable<Connection> territory_connections1
    {
      get
      {
        return this.GetRelatedEntities<Connection>(nameof (territory_connections1), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (territory_connections1));
        this.SetRelatedEntities<Connection>(nameof (territory_connections1), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (territory_connections1));
      }
    }

    [RelationshipSchemaName("territory_connections2")]
    public IEnumerable<Connection> territory_connections2
    {
      get
      {
        return this.GetRelatedEntities<Connection>(nameof (territory_connections2), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (territory_connections2));
        this.SetRelatedEntities<Connection>(nameof (territory_connections2), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (territory_connections2));
      }
    }

    [RelationshipSchemaName("territory_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> territory_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (territory_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (territory_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (territory_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (territory_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName]
    public IEnumerable<Territory> Referencedterritory_parent_territory
    {
      get
      {
        return this.GetRelatedEntities<Territory>("territory_parent_territory", new EntityRole?((EntityRole) 1));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencedterritory_parent_territory));
        this.SetRelatedEntities<Territory>("territory_parent_territory", new EntityRole?((EntityRole) 1), value);
        this.OnPropertyChanged(nameof (Referencedterritory_parent_territory));
      }
    }

    [RelationshipSchemaName("territory_principalobjectattributeaccess")]
    public IEnumerable<PrincipalObjectAttributeAccess> territory_principalobjectattributeaccess
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (territory_principalobjectattributeaccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (territory_principalobjectattributeaccess));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (territory_principalobjectattributeaccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (territory_principalobjectattributeaccess));
      }
    }

    [RelationshipSchemaName("Territory_ProcessSessions")]
    public IEnumerable<ProcessSession> Territory_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (Territory_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Territory_ProcessSessions));
        this.SetRelatedEntities<ProcessSession>(nameof (Territory_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Territory_ProcessSessions));
      }
    }

    [RelationshipSchemaName("Territory_SyncErrors")]
    public IEnumerable<SyncError> Territory_SyncErrors
    {
      get => this.GetRelatedEntities<SyncError>(nameof (Territory_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Territory_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (Territory_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Territory_SyncErrors));
      }
    }

    [RelationshipSchemaName("territory_system_users")]
    public IEnumerable<SystemUser> territory_system_users
    {
      get
      {
        return this.GetRelatedEntities<SystemUser>(nameof (territory_system_users), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (territory_system_users));
        this.SetRelatedEntities<SystemUser>(nameof (territory_system_users), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (territory_system_users));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_territory")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_territory
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_territory), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_territory));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_territory), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_territory));
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_territory_createdonbehalfby")]
    public SystemUser lk_territory_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_territory_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_territory_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_territory_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_territory_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_territory_modifiedonbehalfby")]
    public SystemUser lk_territory_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_territory_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_territory_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_territory_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_territory_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_territorybase_createdby")]
    public SystemUser lk_territorybase_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_territorybase_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_territorybase_modifiedby")]
    public SystemUser lk_territorybase_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_territorybase_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_territories")]
    public Organization organization_territories
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_territories), new EntityRole?());
      }
    }

    [AttributeLogicalName("managerid")]
    [RelationshipSchemaName("system_user_territories")]
    public SystemUser system_user_territories
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (system_user_territories), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (system_user_territories));
        this.SetRelatedEntity<SystemUser>(nameof (system_user_territories), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (system_user_territories));
      }
    }

    [AttributeLogicalName("parentterritoryid")]
    [RelationshipSchemaName]
    public Territory Referencingterritory_parent_territory
    {
      get
      {
        return this.GetRelatedEntity<Territory>("territory_parent_territory", new EntityRole?((EntityRole) 0));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencingterritory_parent_territory));
        this.SetRelatedEntity<Territory>("territory_parent_territory", new EntityRole?((EntityRole) 0), value);
        this.OnPropertyChanged(nameof (Referencingterritory_parent_territory));
      }
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_Territory")]
    public TransactionCurrency TransactionCurrency_Territory
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_Territory), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_Territory));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_Territory), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_Territory));
      }
    }

    public Territory(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["territoryid"] = (object) base.Id;
            break;
          case "territoryid":
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
