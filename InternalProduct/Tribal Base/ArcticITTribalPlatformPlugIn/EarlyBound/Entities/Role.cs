// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.Role
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("role")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class Role : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "role";
    public const string EntitySchemaName = "Role";
    public const string PrimaryIdAttribute = "roleid";
    public const string PrimaryNameAttribute = "name";

    public Role()
      : base("role")
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

    [AttributeLogicalName("businessunitid")]
    public EntityReference BusinessUnitId
    {
      get => this.GetAttributeValue<EntityReference>("businessunitid");
      set
      {
        this.OnPropertyChanging(nameof (BusinessUnitId));
        this.SetAttributeValue("businessunitid", (object) value);
        this.OnPropertyChanged(nameof (BusinessUnitId));
      }
    }

    [AttributeLogicalName("canbedeleted")]
    public BooleanManagedProperty CanBeDeleted
    {
      get => this.GetAttributeValue<BooleanManagedProperty>("canbedeleted");
      set
      {
        this.OnPropertyChanging(nameof (CanBeDeleted));
        this.SetAttributeValue("canbedeleted", (object) value);
        this.OnPropertyChanged(nameof (CanBeDeleted));
      }
    }

    [AttributeLogicalName("componentstate")]
    public OptionSetValue ComponentState
    {
      get => this.GetAttributeValue<OptionSetValue>("componentstate");
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

    [AttributeLogicalName("isinherited")]
    public OptionSetValue IsInherited
    {
      get => this.GetAttributeValue<OptionSetValue>("isinherited");
      set
      {
        this.OnPropertyChanging(nameof (IsInherited));
        this.SetAttributeValue("isinherited", (object) value);
        this.OnPropertyChanged(nameof (IsInherited));
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
    public Guid? OrganizationId => this.GetAttributeValue<Guid?>("organizationid");

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

    [AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime => this.GetAttributeValue<DateTime?>("overwritetime");

    [AttributeLogicalName("parentroleid")]
    public EntityReference ParentRoleId => this.GetAttributeValue<EntityReference>("parentroleid");

    [AttributeLogicalName("parentrootroleid")]
    public EntityReference ParentRootRoleId
    {
      get => this.GetAttributeValue<EntityReference>("parentrootroleid");
    }

    [AttributeLogicalName("roleid")]
    public Guid? RoleId
    {
      get => this.GetAttributeValue<Guid?>("roleid");
      set
      {
        this.OnPropertyChanging(nameof (RoleId));
        this.SetAttributeValue("roleid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (RoleId));
      }
    }

    [AttributeLogicalName("roleid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.RoleId = new Guid?(value);
    }

    [AttributeLogicalName("roleidunique")]
    public Guid? RoleIdUnique => this.GetAttributeValue<Guid?>("roleidunique");

    [AttributeLogicalName("roletemplateid")]
    public EntityReference RoleTemplateId
    {
      get => this.GetAttributeValue<EntityReference>("roletemplateid");
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("Role_AsyncOperations")]
    public IEnumerable<AsyncOperation> Role_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (Role_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Role_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (Role_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Role_AsyncOperations));
      }
    }

    [RelationshipSchemaName("Role_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> Role_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (Role_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Role_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (Role_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Role_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName]
    public IEnumerable<Role> Referencedrole_parent_role
    {
      get => this.GetRelatedEntities<Role>("role_parent_role", new EntityRole?((EntityRole) 1));
      set
      {
        this.OnPropertyChanging(nameof (Referencedrole_parent_role));
        this.SetRelatedEntities<Role>("role_parent_role", new EntityRole?((EntityRole) 1), value);
        this.OnPropertyChanged(nameof (Referencedrole_parent_role));
      }
    }

    [RelationshipSchemaName]
    public IEnumerable<Role> Referencedrole_parent_root_role
    {
      get
      {
        return this.GetRelatedEntities<Role>("role_parent_root_role", new EntityRole?((EntityRole) 1));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencedrole_parent_root_role));
        this.SetRelatedEntities<Role>("role_parent_root_role", new EntityRole?((EntityRole) 1), value);
        this.OnPropertyChanged(nameof (Referencedrole_parent_root_role));
      }
    }

    [RelationshipSchemaName("Role_SyncErrors")]
    public IEnumerable<SyncError> Role_SyncErrors
    {
      get => this.GetRelatedEntities<SyncError>(nameof (Role_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Role_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (Role_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Role_SyncErrors));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_role")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_role
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_role), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_role));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_role), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_role));
      }
    }

    [RelationshipSchemaName("applicationuserrole")]
    public IEnumerable<ApplicationUser> applicationuserrole
    {
      get
      {
        return this.GetRelatedEntities<ApplicationUser>(nameof (applicationuserrole), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (applicationuserrole));
        this.SetRelatedEntities<ApplicationUser>(nameof (applicationuserrole), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (applicationuserrole));
      }
    }

    [RelationshipSchemaName("appmoduleroles_association")]
    public IEnumerable<AppModule> appmoduleroles_association
    {
      get
      {
        return this.GetRelatedEntities<AppModule>(nameof (appmoduleroles_association), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appmoduleroles_association));
        this.SetRelatedEntities<AppModule>(nameof (appmoduleroles_association), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appmoduleroles_association));
      }
    }

    [RelationshipSchemaName("roleprivileges_association")]
    public IEnumerable<Privilege> roleprivileges_association
    {
      get
      {
        return this.GetRelatedEntities<Privilege>(nameof (roleprivileges_association), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (roleprivileges_association));
        this.SetRelatedEntities<Privilege>(nameof (roleprivileges_association), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (roleprivileges_association));
      }
    }

    [RelationshipSchemaName("systemuserroles_association")]
    public IEnumerable<SystemUser> systemuserroles_association
    {
      get
      {
        return this.GetRelatedEntities<SystemUser>(nameof (systemuserroles_association), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (systemuserroles_association));
        this.SetRelatedEntities<SystemUser>(nameof (systemuserroles_association), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (systemuserroles_association));
      }
    }

    [RelationshipSchemaName("teamroles_association")]
    public IEnumerable<Team> teamroles_association
    {
      get => this.GetRelatedEntities<Team>(nameof (teamroles_association), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (teamroles_association));
        this.SetRelatedEntities<Team>(nameof (teamroles_association), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (teamroles_association));
      }
    }

    [AttributeLogicalName("businessunitid")]
    [RelationshipSchemaName("business_unit_roles")]
    public BusinessUnit business_unit_roles
    {
      get => this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_roles), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (business_unit_roles));
        this.SetRelatedEntity<BusinessUnit>(nameof (business_unit_roles), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_roles));
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_role_createdonbehalfby")]
    public SystemUser lk_role_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_role_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_role_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_role_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_role_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_role_modifiedonbehalfby")]
    public SystemUser lk_role_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_role_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_role_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_role_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_role_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_rolebase_createdby")]
    public SystemUser lk_rolebase_createdby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_rolebase_createdby), new EntityRole?());
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_rolebase_modifiedby")]
    public SystemUser lk_rolebase_modifiedby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_rolebase_modifiedby), new EntityRole?());
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_roles")]
    public Organization organization_roles
    {
      get => this.GetRelatedEntity<Organization>(nameof (organization_roles), new EntityRole?());
    }

    [AttributeLogicalName("parentroleid")]
    [RelationshipSchemaName]
    public Role Referencingrole_parent_role
    {
      get => this.GetRelatedEntity<Role>("role_parent_role", new EntityRole?((EntityRole) 0));
    }

    [AttributeLogicalName("parentrootroleid")]
    [RelationshipSchemaName]
    public Role Referencingrole_parent_root_role
    {
      get => this.GetRelatedEntity<Role>("role_parent_root_role", new EntityRole?((EntityRole) 0));
    }

    [AttributeLogicalName("solutionid")]
    [RelationshipSchemaName("solution_role")]
    public Solution solution_role
    {
      get => this.GetRelatedEntity<Solution>(nameof (solution_role), new EntityRole?());
    }

    public Role(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["roleid"] = (object) base.Id;
            break;
          case "roleid":
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
