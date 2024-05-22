// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.AttributeMap
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("attributemap")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class AttributeMap : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "attributemap";
    public const string EntitySchemaName = "AttributeMap";
    public const string PrimaryIdAttribute = "attributemapid";

    public AttributeMap()
      : base("attributemap")
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

    [AttributeLogicalName("attributemapid")]
    public Guid? AttributeMapId
    {
      get => this.GetAttributeValue<Guid?>("attributemapid");
      set
      {
        this.OnPropertyChanging(nameof (AttributeMapId));
        this.SetAttributeValue("attributemapid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (AttributeMapId));
      }
    }

    [AttributeLogicalName("attributemapid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.AttributeMapId = new Guid?(value);
    }

    [AttributeLogicalName("attributemapidunique")]
    public Guid? AttributeMapIdUnique => this.GetAttributeValue<Guid?>("attributemapidunique");

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
    public EntityReference EntityMapId
    {
      get => this.GetAttributeValue<EntityReference>("entitymapid");
      set
      {
        this.OnPropertyChanging(nameof (EntityMapId));
        this.SetAttributeValue("entitymapid", (object) value);
        this.OnPropertyChanged(nameof (EntityMapId));
      }
    }

    [AttributeLogicalName("ismanaged")]
    public bool? IsManaged => this.GetAttributeValue<bool?>("ismanaged");

    [AttributeLogicalName("issystem")]
    public bool? IsSystem
    {
      get => this.GetAttributeValue<bool?>("issystem");
      set
      {
        this.OnPropertyChanging(nameof (IsSystem));
        this.SetAttributeValue("issystem", (object) value);
        this.OnPropertyChanged(nameof (IsSystem));
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
    public EntityReference OrganizationId
    {
      get => this.GetAttributeValue<EntityReference>("organizationid");
    }

    [AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime => this.GetAttributeValue<DateTime?>("overwritetime");

    [AttributeLogicalName("parentattributemapid")]
    public EntityReference ParentAttributeMapId
    {
      get => this.GetAttributeValue<EntityReference>("parentattributemapid");
      set
      {
        this.OnPropertyChanging(nameof (ParentAttributeMapId));
        this.SetAttributeValue("parentattributemapid", (object) value);
        this.OnPropertyChanged(nameof (ParentAttributeMapId));
      }
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("sourceattributename")]
    public string SourceAttributeName
    {
      get => this.GetAttributeValue<string>("sourceattributename");
      set
      {
        this.OnPropertyChanging(nameof (SourceAttributeName));
        this.SetAttributeValue("sourceattributename", (object) value);
        this.OnPropertyChanged(nameof (SourceAttributeName));
      }
    }

    [AttributeLogicalName("targetattributename")]
    public string TargetAttributeName
    {
      get => this.GetAttributeValue<string>("targetattributename");
      set
      {
        this.OnPropertyChanging(nameof (TargetAttributeName));
        this.SetAttributeValue("targetattributename", (object) value);
        this.OnPropertyChanged(nameof (TargetAttributeName));
      }
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName]
    public IEnumerable<AttributeMap> Referencedattribute_map_attribute_maps
    {
      get
      {
        return this.GetRelatedEntities<AttributeMap>("attribute_map_attribute_maps", new EntityRole?((EntityRole) 1));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencedattribute_map_attribute_maps));
        this.SetRelatedEntities<AttributeMap>("attribute_map_attribute_maps", new EntityRole?((EntityRole) 1), value);
        this.OnPropertyChanged(nameof (Referencedattribute_map_attribute_maps));
      }
    }

    [RelationshipSchemaName("AttributeMap_AsyncOperations")]
    public IEnumerable<AsyncOperation> AttributeMap_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (AttributeMap_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (AttributeMap_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (AttributeMap_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (AttributeMap_AsyncOperations));
      }
    }

    [RelationshipSchemaName("AttributeMap_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> AttributeMap_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (AttributeMap_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (AttributeMap_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (AttributeMap_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (AttributeMap_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_attributemap")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_attributemap
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_attributemap), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_attributemap));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_attributemap), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_attributemap));
      }
    }

    [AttributeLogicalName("parentattributemapid")]
    [RelationshipSchemaName]
    public AttributeMap Referencingattribute_map_attribute_maps
    {
      get
      {
        return this.GetRelatedEntity<AttributeMap>("attribute_map_attribute_maps", new EntityRole?((EntityRole) 0));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencingattribute_map_attribute_maps));
        this.SetRelatedEntity<AttributeMap>("attribute_map_attribute_maps", new EntityRole?((EntityRole) 0), value);
        this.OnPropertyChanged(nameof (Referencingattribute_map_attribute_maps));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("createdby_attributemap")]
    public SystemUser createdby_attributemap
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (createdby_attributemap), new EntityRole?());
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("createdonbehalfby_attributemap")]
    public SystemUser createdonbehalfby_attributemap
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (createdonbehalfby_attributemap), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (createdonbehalfby_attributemap));
        this.SetRelatedEntity<SystemUser>(nameof (createdonbehalfby_attributemap), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (createdonbehalfby_attributemap));
      }
    }

    [AttributeLogicalName("entitymapid")]
    [RelationshipSchemaName("entity_map_attribute_maps")]
    public EntityMap entity_map_attribute_maps
    {
      get
      {
        return this.GetRelatedEntity<EntityMap>(nameof (entity_map_attribute_maps), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (entity_map_attribute_maps));
        this.SetRelatedEntity<EntityMap>(nameof (entity_map_attribute_maps), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (entity_map_attribute_maps));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("modifiedby_attributemap")]
    public SystemUser modifiedby_attributemap
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (modifiedby_attributemap), new EntityRole?());
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("modifiedonbehalfby_attributemap")]
    public SystemUser modifiedonbehalfby_attributemap
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (modifiedonbehalfby_attributemap), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (modifiedonbehalfby_attributemap));
        this.SetRelatedEntity<SystemUser>(nameof (modifiedonbehalfby_attributemap), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (modifiedonbehalfby_attributemap));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_attributemap")]
    public Organization organization_attributemap
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_attributemap), new EntityRole?());
      }
    }

    public AttributeMap(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["attributemapid"] = (object) base.Id;
            break;
          case "attributemapid":
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
