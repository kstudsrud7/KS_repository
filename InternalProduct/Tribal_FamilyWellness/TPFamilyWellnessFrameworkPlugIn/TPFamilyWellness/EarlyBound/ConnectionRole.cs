// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EarlyBound.ConnectionRole
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("connectionrole")]
  [GeneratedCode("CrmSvcUtil", "9.0.0.9154")]
  public class ConnectionRole : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "connectionrole";
    public const int EntityTypeCode = 3231;

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
    public ConnectionRoleState? StateCode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>("statecode");
        return attributeValue != null ? new ConnectionRoleState?((ConnectionRoleState) Enum.ToObject(typeof (ConnectionRoleState), attributeValue.Value)) : new ConnectionRoleState?();
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

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

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
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_connectionrolebase_modifiedonbehalfby")]
    public SystemUser lk_connectionrolebase_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_connectionrolebase_modifiedonbehalfby), new EntityRole?());
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
  }
}
