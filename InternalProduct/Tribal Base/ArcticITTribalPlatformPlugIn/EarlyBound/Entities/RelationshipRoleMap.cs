// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.RelationshipRoleMap
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("relationshiprolemap")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class RelationshipRoleMap : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "relationshiprolemap";
    public const string EntitySchemaName = "RelationshipRoleMap";
    public const string PrimaryIdAttribute = "relationshiprolemapid";

    public RelationshipRoleMap()
      : base("relationshiprolemap")
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

    [AttributeLogicalName("associateobjecttypecode")]
    public string AssociateObjectTypeCode
    {
      get => this.GetAttributeValue<string>("associateobjecttypecode");
      set
      {
        this.OnPropertyChanging(nameof (AssociateObjectTypeCode));
        this.SetAttributeValue("associateobjecttypecode", (object) value);
        this.OnPropertyChanged(nameof (AssociateObjectTypeCode));
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

    [AttributeLogicalName("organizationid")]
    public Guid? OrganizationId => this.GetAttributeValue<Guid?>("organizationid");

    [AttributeLogicalName("primaryobjecttypecode")]
    public string PrimaryObjectTypeCode
    {
      get => this.GetAttributeValue<string>("primaryobjecttypecode");
      set
      {
        this.OnPropertyChanging(nameof (PrimaryObjectTypeCode));
        this.SetAttributeValue("primaryobjecttypecode", (object) value);
        this.OnPropertyChanged(nameof (PrimaryObjectTypeCode));
      }
    }

    [AttributeLogicalName("relationshiproleid")]
    public EntityReference RelationshipRoleId
    {
      get => this.GetAttributeValue<EntityReference>("relationshiproleid");
      set
      {
        this.OnPropertyChanging(nameof (RelationshipRoleId));
        this.SetAttributeValue("relationshiproleid", (object) value);
        this.OnPropertyChanged(nameof (RelationshipRoleId));
      }
    }

    [AttributeLogicalName("relationshiprolemapid")]
    public Guid? RelationshipRoleMapId
    {
      get => this.GetAttributeValue<Guid?>("relationshiprolemapid");
      set
      {
        this.OnPropertyChanging(nameof (RelationshipRoleMapId));
        this.SetAttributeValue("relationshiprolemapid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (RelationshipRoleMapId));
      }
    }

    [AttributeLogicalName("relationshiprolemapid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.RelationshipRoleMapId = new Guid?(value);
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("RelationshipRoleMap_AsyncOperations")]
    public IEnumerable<AsyncOperation> RelationshipRoleMap_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (RelationshipRoleMap_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (RelationshipRoleMap_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (RelationshipRoleMap_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (RelationshipRoleMap_AsyncOperations));
      }
    }

    [RelationshipSchemaName("RelationshipRoleMap_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> RelationshipRoleMap_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (RelationshipRoleMap_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (RelationshipRoleMap_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (RelationshipRoleMap_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (RelationshipRoleMap_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_relationshiprolemap")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_relationshiprolemap
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_relationshiprolemap), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_relationshiprolemap));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_relationshiprolemap), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_relationshiprolemap));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("createdby_relationship_role_map")]
    public SystemUser createdby_relationship_role_map
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (createdby_relationship_role_map), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_relationshiprolemap_createdonbehalfby")]
    public SystemUser lk_relationshiprolemap_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_relationshiprolemap_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_relationshiprolemap_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_relationshiprolemap_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_relationshiprolemap_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_relationshiprolemap_modifiedonbehalfby")]
    public SystemUser lk_relationshiprolemap_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_relationshiprolemap_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_relationshiprolemap_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_relationshiprolemap_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_relationshiprolemap_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("modifiedby_relationship_role_map")]
    public SystemUser modifiedby_relationship_role_map
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (modifiedby_relationship_role_map), new EntityRole?());
      }
    }

    [AttributeLogicalName("relationshiproleid")]
    [RelationshipSchemaName("relationship_role_relationship_role_map")]
    public RelationshipRole relationship_role_relationship_role_map
    {
      get
      {
        return this.GetRelatedEntity<RelationshipRole>(nameof (relationship_role_relationship_role_map), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (relationship_role_relationship_role_map));
        this.SetRelatedEntity<RelationshipRole>(nameof (relationship_role_relationship_role_map), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (relationship_role_relationship_role_map));
      }
    }

    public RelationshipRoleMap(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["relationshiprolemapid"] = (object) base.Id;
            break;
          case "relationshiprolemapid":
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
