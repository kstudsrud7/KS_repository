// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EarlyBound.Connection
// Assembly: TPFamilyWellness.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: C0DF2365-4BFC-418D-B654-2FF4D2B8EB1A
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPFamilyWellnessFrameworkPlugIn-A0924F88-EA00-EA11-A82D-000D3A1F0599\TPFamilyWellnessFrameworkPlugIn.dll

using Microsoft.Xrm.Sdk;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

#nullable disable
namespace TPFamilyWellness.EarlyBound
{
  [DataContract]
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("connection")]
  [GeneratedCode("CrmSvcUtil", "9.0.0.9154")]
  public class Connection : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "connection";
    public const int EntityTypeCode = 3234;

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
    public ConnectionState? StateCode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>("statecode");
        return attributeValue != null ? new ConnectionState?((ConnectionState) Enum.ToObject(typeof (ConnectionState), attributeValue.Value)) : new ConnectionState?();
      }
      set
      {
        this.OnPropertyChanging(nameof (StateCode));
        if (!value.HasValue)
          this.SetAttributeValue("statecode", (object) null);
        else
          this.SetAttributeValue("statecode", (object) new OptionSetValue((int) value.Value));
        this.OnPropertyChanged(nameof (StateCode));
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

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_connectionbase_createdonbehalfby")]
    public SystemUser lk_connectionbase_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_connectionbase_createdonbehalfby), new EntityRole?());
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
  }
}
