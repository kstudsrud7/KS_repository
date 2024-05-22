// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.RelationshipRole
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("relationshiprole")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class RelationshipRole : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "relationshiprole";
    public const string EntitySchemaName = "RelationshipRole";
    public const string PrimaryIdAttribute = "relationshiproleid";
    public const string PrimaryNameAttribute = "name";

    public RelationshipRole()
      : base("relationshiprole")
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

    [AttributeLogicalName("relationshiproleid")]
    public Guid? RelationshipRoleId
    {
      get => this.GetAttributeValue<Guid?>("relationshiproleid");
      set
      {
        this.OnPropertyChanging(nameof (RelationshipRoleId));
        this.SetAttributeValue("relationshiproleid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (RelationshipRoleId));
      }
    }

    [AttributeLogicalName("relationshiproleid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.RelationshipRoleId = new Guid?(value);
    }

    [AttributeLogicalName("statecode")]
    public RelationshipRoleState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new RelationshipRoleState?((RelationshipRoleState) Enum.ToObject(typeof (RelationshipRoleState), attributeValue.Value)) : new RelationshipRoleState?();
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

    [RelationshipSchemaName("relationship_role_customer_role")]
    public IEnumerable<CustomerRelationship> relationship_role_customer_role
    {
      get
      {
        return this.GetRelatedEntities<CustomerRelationship>(nameof (relationship_role_customer_role), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (relationship_role_customer_role));
        this.SetRelatedEntities<CustomerRelationship>(nameof (relationship_role_customer_role), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (relationship_role_customer_role));
      }
    }

    [RelationshipSchemaName("relationship_role_partner_role")]
    public IEnumerable<CustomerRelationship> relationship_role_partner_role
    {
      get
      {
        return this.GetRelatedEntities<CustomerRelationship>(nameof (relationship_role_partner_role), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (relationship_role_partner_role));
        this.SetRelatedEntities<CustomerRelationship>(nameof (relationship_role_partner_role), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (relationship_role_partner_role));
      }
    }

    [RelationshipSchemaName("relationship_role_relationship_role_map")]
    public IEnumerable<RelationshipRoleMap> relationship_role_relationship_role_map
    {
      get
      {
        return this.GetRelatedEntities<RelationshipRoleMap>(nameof (relationship_role_relationship_role_map), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (relationship_role_relationship_role_map));
        this.SetRelatedEntities<RelationshipRoleMap>(nameof (relationship_role_relationship_role_map), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (relationship_role_relationship_role_map));
      }
    }

    [RelationshipSchemaName("RelationshipRole_AsyncOperations")]
    public IEnumerable<AsyncOperation> RelationshipRole_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (RelationshipRole_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (RelationshipRole_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (RelationshipRole_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (RelationshipRole_AsyncOperations));
      }
    }

    [RelationshipSchemaName("RelationshipRole_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> RelationshipRole_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (RelationshipRole_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (RelationshipRole_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (RelationshipRole_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (RelationshipRole_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("RelationshipRole_ProcessSessions")]
    public IEnumerable<ProcessSession> RelationshipRole_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (RelationshipRole_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (RelationshipRole_ProcessSessions));
        this.SetRelatedEntities<ProcessSession>(nameof (RelationshipRole_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (RelationshipRole_ProcessSessions));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_relationshiprole")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_relationshiprole
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_relationshiprole), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_relationshiprole));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_relationshiprole), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_relationshiprole));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("createdby_relationship_role")]
    public SystemUser createdby_relationship_role
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (createdby_relationship_role), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_relationshiprole_createdonbehalfby")]
    public SystemUser lk_relationshiprole_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_relationshiprole_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_relationshiprole_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_relationshiprole_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_relationshiprole_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_relationshiprole_modifiedonbehalfby")]
    public SystemUser lk_relationshiprole_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_relationshiprole_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_relationshiprole_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_relationshiprole_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_relationshiprole_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("modifiedby_relationship_role")]
    public SystemUser modifiedby_relationship_role
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (modifiedby_relationship_role), new EntityRole?());
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_relationship_roles")]
    public Organization organization_relationship_roles
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_relationship_roles), new EntityRole?());
      }
    }

    public RelationshipRole(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["relationshiproleid"] = (object) base.Id;
            break;
          case "relationshiproleid":
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
