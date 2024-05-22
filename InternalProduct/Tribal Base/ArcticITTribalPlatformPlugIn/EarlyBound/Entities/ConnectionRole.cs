// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ConnectionRole
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("connectionrole")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ConnectionRole : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "connectionrole";
    public const string EntitySchemaName = "ConnectionRole";
    public const string PrimaryIdAttribute = "connectionroleid";
    public const string PrimaryNameAttribute = "name";

    public ConnectionRole()
      : base("connectionrole")
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

    [AttributeLogicalName("category")]
    public OptionSetValue Category
    {
      get => this.GetAttributeValue<OptionSetValue>("category");
      set
      {
        this.OnPropertyChanging(nameof (Category));
        this.SetAttributeValue("category", (object) value);
        this.OnPropertyChanged(nameof (Category));
      }
    }

    [AttributeLogicalName("componentstate")]
    public OptionSetValue ComponentState
    {
      get => this.GetAttributeValue<OptionSetValue>("componentstate");
    }

    [AttributeLogicalName("connectionroleid")]
    public Guid? ConnectionRoleId
    {
      get => this.GetAttributeValue<Guid?>("connectionroleid");
      set
      {
        this.OnPropertyChanging(nameof (ConnectionRoleId));
        this.SetAttributeValue("connectionroleid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ConnectionRoleId));
      }
    }

    [AttributeLogicalName("connectionroleid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ConnectionRoleId = new Guid?(value);
    }

    [AttributeLogicalName("connectionroleidunique")]
    public Guid? ConnectionRoleIdUnique => this.GetAttributeValue<Guid?>("connectionroleidunique");

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

    [AttributeLogicalName("iscustomizable")]
    public BooleanManagedProperty IsCustomizable
    {
      get => this.GetAttributeValue<BooleanManagedProperty>("iscustomizable");
      set
      {
        this.OnPropertyChanging(nameof (IsCustomizable));
        this.SetAttributeValue("iscustomizable", (object) value);
        this.OnPropertyChanged(nameof (IsCustomizable));
      }
    }

    [AttributeLogicalName("ismanaged")]
    public bool? IsManaged => this.GetAttributeValue<bool?>("ismanaged");

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

    [AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime => this.GetAttributeValue<DateTime?>("overwritetime");

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("statecode")]
    public ConnectionRoleState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ConnectionRoleState?((ConnectionRoleState) Enum.ToObject(typeof (ConnectionRoleState), attributeValue.Value)) : new ConnectionRoleState?();
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

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("Connection_Role_AsyncOperations")]
    public IEnumerable<AsyncOperation> Connection_Role_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (Connection_Role_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Connection_Role_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (Connection_Role_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Connection_Role_AsyncOperations));
      }
    }

    [RelationshipSchemaName("connection_role_connection_role_object_type_codes")]
    public IEnumerable<ConnectionRoleObjectTypeCode> connection_role_connection_role_object_type_codes
    {
      get
      {
        return this.GetRelatedEntities<ConnectionRoleObjectTypeCode>(nameof (connection_role_connection_role_object_type_codes), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (connection_role_connection_role_object_type_codes));
        this.SetRelatedEntities<ConnectionRoleObjectTypeCode>(nameof (connection_role_connection_role_object_type_codes), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (connection_role_connection_role_object_type_codes));
      }
    }

    [RelationshipSchemaName("connection_role_connections1")]
    public IEnumerable<Connection> connection_role_connections1
    {
      get
      {
        return this.GetRelatedEntities<Connection>(nameof (connection_role_connections1), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (connection_role_connections1));
        this.SetRelatedEntities<Connection>(nameof (connection_role_connections1), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (connection_role_connections1));
      }
    }

    [RelationshipSchemaName("connection_role_connections2")]
    public IEnumerable<Connection> connection_role_connections2
    {
      get
      {
        return this.GetRelatedEntities<Connection>(nameof (connection_role_connections2), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (connection_role_connections2));
        this.SetRelatedEntities<Connection>(nameof (connection_role_connections2), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (connection_role_connections2));
      }
    }

    [RelationshipSchemaName("ConnectionRole_ProcessSessions")]
    public IEnumerable<ProcessSession> ConnectionRole_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ConnectionRole_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ConnectionRole_ProcessSessions));
        this.SetRelatedEntities<ProcessSession>(nameof (ConnectionRole_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ConnectionRole_ProcessSessions));
      }
    }

    [RelationshipSchemaName("ConnectionRole_SyncErrors")]
    public IEnumerable<SyncError> ConnectionRole_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ConnectionRole_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ConnectionRole_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ConnectionRole_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ConnectionRole_SyncErrors));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_connectionrole")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_connectionrole
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_connectionrole), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_connectionrole));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_connectionrole), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_connectionrole));
      }
    }

    [RelationshipSchemaName]
    public IEnumerable<ConnectionRole> Referencingconnectionroleassociation_association
    {
      get
      {
        return this.GetRelatedEntities<ConnectionRole>("connectionroleassociation_association", new EntityRole?((EntityRole) 0));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencingconnectionroleassociation_association));
        this.SetRelatedEntities<ConnectionRole>("connectionroleassociation_association", new EntityRole?((EntityRole) 0), value);
        this.OnPropertyChanged(nameof (Referencingconnectionroleassociation_association));
      }
    }

    [RelationshipSchemaName]
    public IEnumerable<ConnectionRole> Referencedconnectionroleassociation_association
    {
      get
      {
        return this.GetRelatedEntities<ConnectionRole>("connectionroleassociation_association", new EntityRole?((EntityRole) 1));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencedconnectionroleassociation_association));
        this.SetRelatedEntities<ConnectionRole>("connectionroleassociation_association", new EntityRole?((EntityRole) 1), value);
        this.OnPropertyChanged(nameof (Referencedconnectionroleassociation_association));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("createdby_connection_role")]
    public SystemUser createdby_connection_role
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (createdby_connection_role), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_connectionrolebase_createdonbehalfby")]
    public SystemUser lk_connectionrolebase_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_connectionrolebase_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_connectionrolebase_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_connectionrolebase_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_connectionrolebase_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_connectionrolebase_modifiedonbehalfby")]
    public SystemUser lk_connectionrolebase_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_connectionrolebase_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_connectionrolebase_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_connectionrolebase_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_connectionrolebase_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("modifiedby_connection_role")]
    public SystemUser modifiedby_connection_role
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (modifiedby_connection_role), new EntityRole?());
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_connection_roles")]
    public Organization organization_connection_roles
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_connection_roles), new EntityRole?());
      }
    }

    public ConnectionRole(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["connectionroleid"] = (object) base.Id;
            break;
          case "connectionroleid":
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
