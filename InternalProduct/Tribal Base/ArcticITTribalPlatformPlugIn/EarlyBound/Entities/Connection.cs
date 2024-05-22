// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.Connection
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("connection")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class Connection : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "connection";
    public const string EntitySchemaName = "Connection";
    public const string PrimaryIdAttribute = "connectionid";
    public const string PrimaryNameAttribute = "name";

    public Connection()
      : base("connection")
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

    [AttributeLogicalName("connectionid")]
    public Guid? ConnectionId
    {
      get => this.GetAttributeValue<Guid?>("connectionid");
      set
      {
        this.OnPropertyChanging(nameof (ConnectionId));
        this.SetAttributeValue("connectionid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ConnectionId));
      }
    }

    [AttributeLogicalName("connectionid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ConnectionId = new Guid?(value);
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

    [AttributeLogicalName("effectiveend")]
    public DateTime? EffectiveEnd
    {
      get => this.GetAttributeValue<DateTime?>("effectiveend");
      set
      {
        this.OnPropertyChanging(nameof (EffectiveEnd));
        this.SetAttributeValue("effectiveend", (object) value);
        this.OnPropertyChanged(nameof (EffectiveEnd));
      }
    }

    [AttributeLogicalName("effectivestart")]
    public DateTime? EffectiveStart
    {
      get => this.GetAttributeValue<DateTime?>("effectivestart");
      set
      {
        this.OnPropertyChanging(nameof (EffectiveStart));
        this.SetAttributeValue("effectivestart", (object) value);
        this.OnPropertyChanged(nameof (EffectiveStart));
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

    [AttributeLogicalName("ismaster")]
    public bool? IsMaster => this.GetAttributeValue<bool?>("ismaster");

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
    public string Name => this.GetAttributeValue<string>("name");

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

    [AttributeLogicalName("record1id")]
    public EntityReference Record1Id
    {
      get => this.GetAttributeValue<EntityReference>("record1id");
      set
      {
        this.OnPropertyChanging(nameof (Record1Id));
        this.SetAttributeValue("record1id", (object) value);
        this.OnPropertyChanged(nameof (Record1Id));
      }
    }

    [AttributeLogicalName("record1objecttypecode")]
    public OptionSetValue Record1ObjectTypeCode
    {
      get => this.GetAttributeValue<OptionSetValue>("record1objecttypecode");
    }

    [AttributeLogicalName("record1roleid")]
    public EntityReference Record1RoleId
    {
      get => this.GetAttributeValue<EntityReference>("record1roleid");
      set
      {
        this.OnPropertyChanging(nameof (Record1RoleId));
        this.SetAttributeValue("record1roleid", (object) value);
        this.OnPropertyChanged(nameof (Record1RoleId));
      }
    }

    [AttributeLogicalName("record2id")]
    public EntityReference Record2Id
    {
      get => this.GetAttributeValue<EntityReference>("record2id");
      set
      {
        this.OnPropertyChanging(nameof (Record2Id));
        this.SetAttributeValue("record2id", (object) value);
        this.OnPropertyChanged(nameof (Record2Id));
      }
    }

    [AttributeLogicalName("record2objecttypecode")]
    public OptionSetValue Record2ObjectTypeCode
    {
      get => this.GetAttributeValue<OptionSetValue>("record2objecttypecode");
    }

    [AttributeLogicalName("record2roleid")]
    public EntityReference Record2RoleId
    {
      get => this.GetAttributeValue<EntityReference>("record2roleid");
      set
      {
        this.OnPropertyChanging(nameof (Record2RoleId));
        this.SetAttributeValue("record2roleid", (object) value);
        this.OnPropertyChanged(nameof (Record2RoleId));
      }
    }

    [AttributeLogicalName("relatedconnectionid")]
    public EntityReference RelatedConnectionId
    {
      get => this.GetAttributeValue<EntityReference>("relatedconnectionid");
    }

    [AttributeLogicalName("statecode")]
    public ConnectionState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ConnectionState?((ConnectionState) Enum.ToObject(typeof (ConnectionState), attributeValue.Value)) : new ConnectionState?();
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

    [RelationshipSchemaName("Connection_AsyncOperations")]
    public IEnumerable<AsyncOperation> Connection_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (Connection_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Connection_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (Connection_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Connection_AsyncOperations));
      }
    }

    [RelationshipSchemaName("connection_principalobjectattributeaccess")]
    public IEnumerable<PrincipalObjectAttributeAccess> connection_principalobjectattributeaccess
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (connection_principalobjectattributeaccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (connection_principalobjectattributeaccess));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (connection_principalobjectattributeaccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (connection_principalobjectattributeaccess));
      }
    }

    [RelationshipSchemaName("Connection_ProcessSessions")]
    public IEnumerable<ProcessSession> Connection_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (Connection_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Connection_ProcessSessions));
        this.SetRelatedEntities<ProcessSession>(nameof (Connection_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Connection_ProcessSessions));
      }
    }

    [RelationshipSchemaName]
    public IEnumerable<Connection> Referencedconnection_related_connection
    {
      get
      {
        return this.GetRelatedEntities<Connection>("connection_related_connection", new EntityRole?((EntityRole) 1));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencedconnection_related_connection));
        this.SetRelatedEntities<Connection>("connection_related_connection", new EntityRole?((EntityRole) 1), value);
        this.OnPropertyChanged(nameof (Referencedconnection_related_connection));
      }
    }

    [RelationshipSchemaName("Connection_SyncErrors")]
    public IEnumerable<SyncError> Connection_SyncErrors
    {
      get => this.GetRelatedEntities<SyncError>(nameof (Connection_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Connection_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (Connection_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Connection_SyncErrors));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_connection")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_connection
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_connection), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_connection));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_connection), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_connection));
      }
    }

    [AttributeLogicalName("record1id")]
    [RelationshipSchemaName("account_connections1")]
    public Account account_connections1
    {
      get => this.GetRelatedEntity<Account>(nameof (account_connections1), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (account_connections1));
        this.SetRelatedEntity<Account>(nameof (account_connections1), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (account_connections1));
      }
    }

    [AttributeLogicalName("record2id")]
    [RelationshipSchemaName("account_connections2")]
    public Account account_connections2
    {
      get => this.GetRelatedEntity<Account>(nameof (account_connections2), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (account_connections2));
        this.SetRelatedEntity<Account>(nameof (account_connections2), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (account_connections2));
      }
    }

    [AttributeLogicalName("record1id")]
    [RelationshipSchemaName("activitypointer_connections1")]
    public ActivityPointer activitypointer_connections1
    {
      get
      {
        return this.GetRelatedEntity<ActivityPointer>(nameof (activitypointer_connections1), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (activitypointer_connections1));
        this.SetRelatedEntity<ActivityPointer>(nameof (activitypointer_connections1), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (activitypointer_connections1));
      }
    }

    [AttributeLogicalName("record2id")]
    [RelationshipSchemaName("activitypointer_connections2")]
    public ActivityPointer activitypointer_connections2
    {
      get
      {
        return this.GetRelatedEntity<ActivityPointer>(nameof (activitypointer_connections2), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (activitypointer_connections2));
        this.SetRelatedEntity<ActivityPointer>(nameof (activitypointer_connections2), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (activitypointer_connections2));
      }
    }

    [AttributeLogicalName("record1id")]
    [RelationshipSchemaName("appointment_connections1")]
    public Appointment appointment_connections1
    {
      get
      {
        return this.GetRelatedEntity<Appointment>(nameof (appointment_connections1), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appointment_connections1));
        this.SetRelatedEntity<Appointment>(nameof (appointment_connections1), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appointment_connections1));
      }
    }

    [AttributeLogicalName("record2id")]
    [RelationshipSchemaName("appointment_connections2")]
    public Appointment appointment_connections2
    {
      get
      {
        return this.GetRelatedEntity<Appointment>(nameof (appointment_connections2), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appointment_connections2));
        this.SetRelatedEntity<Appointment>(nameof (appointment_connections2), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appointment_connections2));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_connections")]
    public BusinessUnit business_unit_connections
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_connections), new EntityRole?());
      }
    }

    [AttributeLogicalName("relatedconnectionid")]
    [RelationshipSchemaName]
    public Connection Referencingconnection_related_connection
    {
      get
      {
        return this.GetRelatedEntity<Connection>("connection_related_connection", new EntityRole?((EntityRole) 0));
      }
    }

    [AttributeLogicalName("record1roleid")]
    [RelationshipSchemaName("connection_role_connections1")]
    public ConnectionRole connection_role_connections1
    {
      get
      {
        return this.GetRelatedEntity<ConnectionRole>(nameof (connection_role_connections1), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (connection_role_connections1));
        this.SetRelatedEntity<ConnectionRole>(nameof (connection_role_connections1), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (connection_role_connections1));
      }
    }

    [AttributeLogicalName("record2roleid")]
    [RelationshipSchemaName("connection_role_connections2")]
    public ConnectionRole connection_role_connections2
    {
      get
      {
        return this.GetRelatedEntity<ConnectionRole>(nameof (connection_role_connections2), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (connection_role_connections2));
        this.SetRelatedEntity<ConnectionRole>(nameof (connection_role_connections2), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (connection_role_connections2));
      }
    }

    [AttributeLogicalName("record1id")]
    [RelationshipSchemaName("contact_connections1")]
    public Contact contact_connections1
    {
      get => this.GetRelatedEntity<Contact>(nameof (contact_connections1), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (contact_connections1));
        this.SetRelatedEntity<Contact>(nameof (contact_connections1), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (contact_connections1));
      }
    }

    [AttributeLogicalName("record2id")]
    [RelationshipSchemaName("contact_connections2")]
    public Contact contact_connections2
    {
      get => this.GetRelatedEntity<Contact>(nameof (contact_connections2), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (contact_connections2));
        this.SetRelatedEntity<Contact>(nameof (contact_connections2), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (contact_connections2));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("createdby_connection")]
    public SystemUser createdby_connection
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (createdby_connection), new EntityRole?());
    }

    [AttributeLogicalName("record1id")]
    [RelationshipSchemaName("email_connections1")]
    public Email email_connections1
    {
      get => this.GetRelatedEntity<Email>(nameof (email_connections1), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (email_connections1));
        this.SetRelatedEntity<Email>(nameof (email_connections1), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (email_connections1));
      }
    }

    [AttributeLogicalName("record2id")]
    [RelationshipSchemaName("email_connections2")]
    public Email email_connections2
    {
      get => this.GetRelatedEntity<Email>(nameof (email_connections2), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (email_connections2));
        this.SetRelatedEntity<Email>(nameof (email_connections2), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (email_connections2));
      }
    }

    [AttributeLogicalName("record1id")]
    [RelationshipSchemaName("fax_connections1")]
    public Fax fax_connections1
    {
      get => this.GetRelatedEntity<Fax>(nameof (fax_connections1), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (fax_connections1));
        this.SetRelatedEntity<Fax>(nameof (fax_connections1), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (fax_connections1));
      }
    }

    [AttributeLogicalName("record2id")]
    [RelationshipSchemaName("fax_connections2")]
    public Fax fax_connections2
    {
      get => this.GetRelatedEntity<Fax>(nameof (fax_connections2), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (fax_connections2));
        this.SetRelatedEntity<Fax>(nameof (fax_connections2), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (fax_connections2));
      }
    }

    [AttributeLogicalName("record1id")]
    [RelationshipSchemaName("goal_connections1")]
    public Goal goal_connections1
    {
      get => this.GetRelatedEntity<Goal>(nameof (goal_connections1), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (goal_connections1));
        this.SetRelatedEntity<Goal>(nameof (goal_connections1), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (goal_connections1));
      }
    }

    [AttributeLogicalName("record2id")]
    [RelationshipSchemaName("goal_connections2")]
    public Goal goal_connections2
    {
      get => this.GetRelatedEntity<Goal>(nameof (goal_connections2), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (goal_connections2));
        this.SetRelatedEntity<Goal>(nameof (goal_connections2), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (goal_connections2));
      }
    }

    [AttributeLogicalName("record1id")]
    [RelationshipSchemaName("knowledgearticle_connections1")]
    public KnowledgeArticle knowledgearticle_connections1
    {
      get
      {
        return this.GetRelatedEntity<KnowledgeArticle>(nameof (knowledgearticle_connections1), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (knowledgearticle_connections1));
        this.SetRelatedEntity<KnowledgeArticle>(nameof (knowledgearticle_connections1), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (knowledgearticle_connections1));
      }
    }

    [AttributeLogicalName("record2id")]
    [RelationshipSchemaName("knowledgearticle_connections2")]
    public KnowledgeArticle knowledgearticle_connections2
    {
      get
      {
        return this.GetRelatedEntity<KnowledgeArticle>(nameof (knowledgearticle_connections2), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (knowledgearticle_connections2));
        this.SetRelatedEntity<KnowledgeArticle>(nameof (knowledgearticle_connections2), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (knowledgearticle_connections2));
      }
    }

    [AttributeLogicalName("record1id")]
    [RelationshipSchemaName("KnowledgeBaseRecord_connections1")]
    public KnowledgeBaseRecord KnowledgeBaseRecord_connections1
    {
      get
      {
        return this.GetRelatedEntity<KnowledgeBaseRecord>(nameof (KnowledgeBaseRecord_connections1), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeBaseRecord_connections1));
        this.SetRelatedEntity<KnowledgeBaseRecord>(nameof (KnowledgeBaseRecord_connections1), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeBaseRecord_connections1));
      }
    }

    [AttributeLogicalName("record2id")]
    [RelationshipSchemaName("KnowledgeBaseRecord_connections2")]
    public KnowledgeBaseRecord KnowledgeBaseRecord_connections2
    {
      get
      {
        return this.GetRelatedEntity<KnowledgeBaseRecord>(nameof (KnowledgeBaseRecord_connections2), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeBaseRecord_connections2));
        this.SetRelatedEntity<KnowledgeBaseRecord>(nameof (KnowledgeBaseRecord_connections2), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeBaseRecord_connections2));
      }
    }

    [AttributeLogicalName("record1id")]
    [RelationshipSchemaName("letter_connections1")]
    public Letter letter_connections1
    {
      get => this.GetRelatedEntity<Letter>(nameof (letter_connections1), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (letter_connections1));
        this.SetRelatedEntity<Letter>(nameof (letter_connections1), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (letter_connections1));
      }
    }

    [AttributeLogicalName("record2id")]
    [RelationshipSchemaName("letter_connections2")]
    public Letter letter_connections2
    {
      get => this.GetRelatedEntity<Letter>(nameof (letter_connections2), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (letter_connections2));
        this.SetRelatedEntity<Letter>(nameof (letter_connections2), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (letter_connections2));
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_connectionbase_createdonbehalfby")]
    public SystemUser lk_connectionbase_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_connectionbase_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_connectionbase_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_connectionbase_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_connectionbase_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_connectionbase_modifiedonbehalfby")]
    public SystemUser lk_connectionbase_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_connectionbase_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_connectionbase_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_connectionbase_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_connectionbase_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("modifiedby_connection")]
    public SystemUser modifiedby_connection
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (modifiedby_connection), new EntityRole?());
    }

    [AttributeLogicalName("record1id")]
    [RelationshipSchemaName("phonecall_connections1")]
    public PhoneCall phonecall_connections1
    {
      get => this.GetRelatedEntity<PhoneCall>(nameof (phonecall_connections1), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (phonecall_connections1));
        this.SetRelatedEntity<PhoneCall>(nameof (phonecall_connections1), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (phonecall_connections1));
      }
    }

    [AttributeLogicalName("record2id")]
    [RelationshipSchemaName("phonecall_connections2")]
    public PhoneCall phonecall_connections2
    {
      get => this.GetRelatedEntity<PhoneCall>(nameof (phonecall_connections2), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (phonecall_connections2));
        this.SetRelatedEntity<PhoneCall>(nameof (phonecall_connections2), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (phonecall_connections2));
      }
    }

    [AttributeLogicalName("record1id")]
    [RelationshipSchemaName("position_connection1")]
    public Position position_connection1
    {
      get => this.GetRelatedEntity<Position>(nameof (position_connection1), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (position_connection1));
        this.SetRelatedEntity<Position>(nameof (position_connection1), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (position_connection1));
      }
    }

    [AttributeLogicalName("record2id")]
    [RelationshipSchemaName("position_connection2")]
    public Position position_connection2
    {
      get => this.GetRelatedEntity<Position>(nameof (position_connection2), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (position_connection2));
        this.SetRelatedEntity<Position>(nameof (position_connection2), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (position_connection2));
      }
    }

    [AttributeLogicalName("record1id")]
    [RelationshipSchemaName("processsession_connections1")]
    public ProcessSession processsession_connections1
    {
      get
      {
        return this.GetRelatedEntity<ProcessSession>(nameof (processsession_connections1), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (processsession_connections1));
        this.SetRelatedEntity<ProcessSession>(nameof (processsession_connections1), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (processsession_connections1));
      }
    }

    [AttributeLogicalName("record2id")]
    [RelationshipSchemaName("processsession_connections2")]
    public ProcessSession processsession_connections2
    {
      get
      {
        return this.GetRelatedEntity<ProcessSession>(nameof (processsession_connections2), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (processsession_connections2));
        this.SetRelatedEntity<ProcessSession>(nameof (processsession_connections2), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (processsession_connections2));
      }
    }

    [AttributeLogicalName("record1id")]
    [RelationshipSchemaName("profilerule_connections1")]
    public ChannelAccessProfileRule profilerule_connections1
    {
      get
      {
        return this.GetRelatedEntity<ChannelAccessProfileRule>(nameof (profilerule_connections1), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (profilerule_connections1));
        this.SetRelatedEntity<ChannelAccessProfileRule>(nameof (profilerule_connections1), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (profilerule_connections1));
      }
    }

    [AttributeLogicalName("record2id")]
    [RelationshipSchemaName("profilerule_connections2")]
    public ChannelAccessProfileRule profilerule_connections2
    {
      get
      {
        return this.GetRelatedEntity<ChannelAccessProfileRule>(nameof (profilerule_connections2), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (profilerule_connections2));
        this.SetRelatedEntity<ChannelAccessProfileRule>(nameof (profilerule_connections2), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (profilerule_connections2));
      }
    }

    [AttributeLogicalName("record1id")]
    [RelationshipSchemaName("recurringappointmentmaster_connections1")]
    public RecurringAppointmentMaster recurringappointmentmaster_connections1
    {
      get
      {
        return this.GetRelatedEntity<RecurringAppointmentMaster>(nameof (recurringappointmentmaster_connections1), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (recurringappointmentmaster_connections1));
        this.SetRelatedEntity<RecurringAppointmentMaster>(nameof (recurringappointmentmaster_connections1), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (recurringappointmentmaster_connections1));
      }
    }

    [AttributeLogicalName("record2id")]
    [RelationshipSchemaName("recurringappointmentmaster_connections2")]
    public RecurringAppointmentMaster recurringappointmentmaster_connections2
    {
      get
      {
        return this.GetRelatedEntity<RecurringAppointmentMaster>(nameof (recurringappointmentmaster_connections2), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (recurringappointmentmaster_connections2));
        this.SetRelatedEntity<RecurringAppointmentMaster>(nameof (recurringappointmentmaster_connections2), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (recurringappointmentmaster_connections2));
      }
    }

    [AttributeLogicalName("record1id")]
    [RelationshipSchemaName("socialactivity_connections1")]
    public SocialActivity socialactivity_connections1
    {
      get
      {
        return this.GetRelatedEntity<SocialActivity>(nameof (socialactivity_connections1), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (socialactivity_connections1));
        this.SetRelatedEntity<SocialActivity>(nameof (socialactivity_connections1), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (socialactivity_connections1));
      }
    }

    [AttributeLogicalName("record2id")]
    [RelationshipSchemaName("socialactivity_connections2")]
    public SocialActivity socialactivity_connections2
    {
      get
      {
        return this.GetRelatedEntity<SocialActivity>(nameof (socialactivity_connections2), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (socialactivity_connections2));
        this.SetRelatedEntity<SocialActivity>(nameof (socialactivity_connections2), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (socialactivity_connections2));
      }
    }

    [AttributeLogicalName("record1id")]
    [RelationshipSchemaName("socialprofile_connections1")]
    public SocialProfile socialprofile_connections1
    {
      get
      {
        return this.GetRelatedEntity<SocialProfile>(nameof (socialprofile_connections1), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (socialprofile_connections1));
        this.SetRelatedEntity<SocialProfile>(nameof (socialprofile_connections1), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (socialprofile_connections1));
      }
    }

    [AttributeLogicalName("record2id")]
    [RelationshipSchemaName("socialprofile_connections2")]
    public SocialProfile socialprofile_connections2
    {
      get
      {
        return this.GetRelatedEntity<SocialProfile>(nameof (socialprofile_connections2), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (socialprofile_connections2));
        this.SetRelatedEntity<SocialProfile>(nameof (socialprofile_connections2), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (socialprofile_connections2));
      }
    }

    [AttributeLogicalName("record1id")]
    [RelationshipSchemaName("systemuser_connections1")]
    public SystemUser systemuser_connections1
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (systemuser_connections1), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (systemuser_connections1));
        this.SetRelatedEntity<SystemUser>(nameof (systemuser_connections1), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (systemuser_connections1));
      }
    }

    [AttributeLogicalName("record2id")]
    [RelationshipSchemaName("systemuser_connections2")]
    public SystemUser systemuser_connections2
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (systemuser_connections2), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (systemuser_connections2));
        this.SetRelatedEntity<SystemUser>(nameof (systemuser_connections2), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (systemuser_connections2));
      }
    }

    [AttributeLogicalName("record1id")]
    [RelationshipSchemaName("task_connections1")]
    public Task task_connections1
    {
      get => this.GetRelatedEntity<Task>(nameof (task_connections1), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (task_connections1));
        this.SetRelatedEntity<Task>(nameof (task_connections1), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (task_connections1));
      }
    }

    [AttributeLogicalName("record2id")]
    [RelationshipSchemaName("task_connections2")]
    public Task task_connections2
    {
      get => this.GetRelatedEntity<Task>(nameof (task_connections2), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (task_connections2));
        this.SetRelatedEntity<Task>(nameof (task_connections2), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (task_connections2));
      }
    }

    [AttributeLogicalName("record1id")]
    [RelationshipSchemaName("team_connections1")]
    public Team team_connections1
    {
      get => this.GetRelatedEntity<Team>(nameof (team_connections1), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_connections1));
        this.SetRelatedEntity<Team>(nameof (team_connections1), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_connections1));
      }
    }

    [AttributeLogicalName("record2id")]
    [RelationshipSchemaName("team_connections2")]
    public Team team_connections2
    {
      get => this.GetRelatedEntity<Team>(nameof (team_connections2), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_connections2));
        this.SetRelatedEntity<Team>(nameof (team_connections2), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_connections2));
      }
    }

    [AttributeLogicalName("record1id")]
    [RelationshipSchemaName("territory_connections1")]
    public Territory territory_connections1
    {
      get => this.GetRelatedEntity<Territory>(nameof (territory_connections1), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (territory_connections1));
        this.SetRelatedEntity<Territory>(nameof (territory_connections1), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (territory_connections1));
      }
    }

    [AttributeLogicalName("record2id")]
    [RelationshipSchemaName("territory_connections2")]
    public Territory territory_connections2
    {
      get => this.GetRelatedEntity<Territory>(nameof (territory_connections2), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (territory_connections2));
        this.SetRelatedEntity<Territory>(nameof (territory_connections2), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (territory_connections2));
      }
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_Connection")]
    public TransactionCurrency TransactionCurrency_Connection
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_Connection), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_Connection));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_Connection), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_Connection));
      }
    }

    public Connection(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["connectionid"] = (object) base.Id;
            break;
          case "connectionid":
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
