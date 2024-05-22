// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.EntityMap
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("entitymap")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class EntityMap : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "entitymap";
    public const string EntitySchemaName = "EntityMap";
    public const string PrimaryIdAttribute = "entitymapid";

    public EntityMap()
      : base("entitymap")
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

    [AttributeLogicalName("entitymapid")]
    public Guid? EntityMapId
    {
      get => this.GetAttributeValue<Guid?>("entitymapid");
      set
      {
        this.OnPropertyChanging(nameof (EntityMapId));
        this.SetAttributeValue("entitymapid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (EntityMapId));
      }
    }

    [AttributeLogicalName("entitymapid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.EntityMapId = new Guid?(value);
    }

    [AttributeLogicalName("entitymapidunique")]
    public Guid? EntityMapIdUnique => this.GetAttributeValue<Guid?>("entitymapidunique");

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

    [AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get => this.GetAttributeValue<EntityReference>("organizationid");
    }

    [AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime => this.GetAttributeValue<DateTime?>("overwritetime");

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("sourceentityname")]
    public string SourceEntityName
    {
      get => this.GetAttributeValue<string>("sourceentityname");
      set
      {
        this.OnPropertyChanging(nameof (SourceEntityName));
        this.SetAttributeValue("sourceentityname", (object) value);
        this.OnPropertyChanged(nameof (SourceEntityName));
      }
    }

    [AttributeLogicalName("targetentityname")]
    public string TargetEntityName
    {
      get => this.GetAttributeValue<string>("targetentityname");
      set
      {
        this.OnPropertyChanging(nameof (TargetEntityName));
        this.SetAttributeValue("targetentityname", (object) value);
        this.OnPropertyChanged(nameof (TargetEntityName));
      }
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("entity_map_attribute_maps")]
    public IEnumerable<AttributeMap> entity_map_attribute_maps
    {
      get
      {
        return this.GetRelatedEntities<AttributeMap>(nameof (entity_map_attribute_maps), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (entity_map_attribute_maps));
        this.SetRelatedEntities<AttributeMap>(nameof (entity_map_attribute_maps), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (entity_map_attribute_maps));
      }
    }

    [RelationshipSchemaName("EntityMap_AsyncOperations")]
    public IEnumerable<AsyncOperation> EntityMap_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (EntityMap_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (EntityMap_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (EntityMap_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (EntityMap_AsyncOperations));
      }
    }

    [RelationshipSchemaName("EntityMap_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> EntityMap_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (EntityMap_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (EntityMap_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (EntityMap_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (EntityMap_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_entitymap")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_entitymap
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_entitymap), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_entitymap));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_entitymap), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_entitymap));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("createdby_entitymap")]
    public SystemUser createdby_entitymap
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (createdby_entitymap), new EntityRole?());
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_entitymap_createdonbehalfby")]
    public SystemUser lk_entitymap_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_entitymap_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_entitymap_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_entitymap_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_entitymap_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_entitymap_modifiedonbehalfby")]
    public SystemUser lk_entitymap_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_entitymap_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_entitymap_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_entitymap_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_entitymap_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("modifiedby_entitymap")]
    public SystemUser modifiedby_entitymap
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (modifiedby_entitymap), new EntityRole?());
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_entitymap")]
    public Organization organization_entitymap
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_entitymap), new EntityRole?());
      }
    }

    public EntityMap(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["entitymapid"] = (object) base.Id;
            break;
          case "entitymapid":
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
