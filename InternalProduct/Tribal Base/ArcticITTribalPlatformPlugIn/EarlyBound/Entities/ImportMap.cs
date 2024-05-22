// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ImportMap
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("importmap")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ImportMap : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "importmap";
    public const string EntitySchemaName = "ImportMap";
    public const string PrimaryIdAttribute = "importmapid";
    public const string PrimaryNameAttribute = "name";

    public ImportMap()
      : base("importmap")
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

    [AttributeLogicalName("entitiesperfile")]
    public OptionSetValue EntitiesPerFile
    {
      get => this.GetAttributeValue<OptionSetValue>("entitiesperfile");
      set
      {
        this.OnPropertyChanging(nameof (EntitiesPerFile));
        this.SetAttributeValue("entitiesperfile", (object) value);
        this.OnPropertyChanged(nameof (EntitiesPerFile));
      }
    }

    [AttributeLogicalName("importmapid")]
    public Guid? ImportMapId
    {
      get => this.GetAttributeValue<Guid?>("importmapid");
      set
      {
        this.OnPropertyChanging(nameof (ImportMapId));
        this.SetAttributeValue("importmapid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ImportMapId));
      }
    }

    [AttributeLogicalName("importmapid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ImportMapId = new Guid?(value);
    }

    [AttributeLogicalName("importmapidunique")]
    public Guid? ImportMapIdUnique => this.GetAttributeValue<Guid?>("importmapidunique");

    [AttributeLogicalName("importmaptype")]
    public OptionSetValue ImportMapType
    {
      get => this.GetAttributeValue<OptionSetValue>("importmaptype");
      set
      {
        this.OnPropertyChanging(nameof (ImportMapType));
        this.SetAttributeValue("importmaptype", (object) value);
        this.OnPropertyChanged(nameof (ImportMapType));
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

    [AttributeLogicalName("ismanaged")]
    public bool? IsManaged => this.GetAttributeValue<bool?>("ismanaged");

    [AttributeLogicalName("isvalidforimport")]
    public bool? IsValidForImport => this.GetAttributeValue<bool?>("isvalidforimport");

    [AttributeLogicalName("iswizardcreated")]
    public bool? IsWizardCreated
    {
      get => this.GetAttributeValue<bool?>("iswizardcreated");
      set
      {
        this.OnPropertyChanging(nameof (IsWizardCreated));
        this.SetAttributeValue("iswizardcreated", (object) value);
        this.OnPropertyChanged(nameof (IsWizardCreated));
      }
    }

    [AttributeLogicalName("mapcustomizations")]
    public string MapCustomizations
    {
      get => this.GetAttributeValue<string>("mapcustomizations");
      set
      {
        this.OnPropertyChanging(nameof (MapCustomizations));
        this.SetAttributeValue("mapcustomizations", (object) value);
        this.OnPropertyChanged(nameof (MapCustomizations));
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

    [AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime => this.GetAttributeValue<DateTime?>("overwritetime");

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

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("source")]
    public string Source
    {
      get => this.GetAttributeValue<string>("source");
      set
      {
        this.OnPropertyChanging(nameof (Source));
        this.SetAttributeValue("source", (object) value);
        this.OnPropertyChanged(nameof (Source));
      }
    }

    [AttributeLogicalName("sourcetype")]
    public OptionSetValue SourceType
    {
      get => this.GetAttributeValue<OptionSetValue>("sourcetype");
      set
      {
        this.OnPropertyChanging(nameof (SourceType));
        this.SetAttributeValue("sourcetype", (object) value);
        this.OnPropertyChanged(nameof (SourceType));
      }
    }

    [AttributeLogicalName("sourceuseridentifierforsourcecrmuserlink")]
    public string SourceUserIdentifierForSourceCRMUserLink
    {
      get => this.GetAttributeValue<string>("sourceuseridentifierforsourcecrmuserlink");
      set
      {
        this.OnPropertyChanging(nameof (SourceUserIdentifierForSourceCRMUserLink));
        this.SetAttributeValue("sourceuseridentifierforsourcecrmuserlink", (object) value);
        this.OnPropertyChanged(nameof (SourceUserIdentifierForSourceCRMUserLink));
      }
    }

    [AttributeLogicalName("sourceuseridentifierforsourcedatasourceuserlink")]
    public string SourceUserIdentifierForSourceDataSourceUserLink
    {
      get => this.GetAttributeValue<string>("sourceuseridentifierforsourcedatasourceuserlink");
      set
      {
        this.OnPropertyChanging(nameof (SourceUserIdentifierForSourceDataSourceUserLink));
        this.SetAttributeValue("sourceuseridentifierforsourcedatasourceuserlink", (object) value);
        this.OnPropertyChanged(nameof (SourceUserIdentifierForSourceDataSourceUserLink));
      }
    }

    [AttributeLogicalName("statecode")]
    public ImportMapState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ImportMapState?((ImportMapState) Enum.ToObject(typeof (ImportMapState), attributeValue.Value)) : new ImportMapState?();
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

    [AttributeLogicalName("targetentity")]
    public OptionSetValue TargetEntity => this.GetAttributeValue<OptionSetValue>("targetentity");

    [AttributeLogicalName("targetuseridentifierforsourcecrmuserlink")]
    public string TargetUserIdentifierForSourceCRMUserLink
    {
      get => this.GetAttributeValue<string>("targetuseridentifierforsourcecrmuserlink");
      set
      {
        this.OnPropertyChanging(nameof (TargetUserIdentifierForSourceCRMUserLink));
        this.SetAttributeValue("targetuseridentifierforsourcecrmuserlink", (object) value);
        this.OnPropertyChanged(nameof (TargetUserIdentifierForSourceCRMUserLink));
      }
    }

    [RelationshipSchemaName("ColumnMapping_ImportMap")]
    public IEnumerable<ColumnMapping> ColumnMapping_ImportMap
    {
      get
      {
        return this.GetRelatedEntities<ColumnMapping>(nameof (ColumnMapping_ImportMap), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ColumnMapping_ImportMap));
        this.SetRelatedEntities<ColumnMapping>(nameof (ColumnMapping_ImportMap), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ColumnMapping_ImportMap));
      }
    }

    [RelationshipSchemaName("ImportEntityMapping_ImportMap")]
    public IEnumerable<ImportEntityMapping> ImportEntityMapping_ImportMap
    {
      get
      {
        return this.GetRelatedEntities<ImportEntityMapping>(nameof (ImportEntityMapping_ImportMap), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ImportEntityMapping_ImportMap));
        this.SetRelatedEntities<ImportEntityMapping>(nameof (ImportEntityMapping_ImportMap), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ImportEntityMapping_ImportMap));
      }
    }

    [RelationshipSchemaName("ImportMap_AsyncOperations")]
    public IEnumerable<AsyncOperation> ImportMap_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ImportMap_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ImportMap_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ImportMap_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ImportMap_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ImportMap_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ImportMap_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ImportMap_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ImportMap_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ImportMap_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ImportMap_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ImportMap_ImportFile")]
    public IEnumerable<ImportFile> ImportMap_ImportFile
    {
      get => this.GetRelatedEntities<ImportFile>(nameof (ImportMap_ImportFile), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ImportMap_ImportFile));
        this.SetRelatedEntities<ImportFile>(nameof (ImportMap_ImportFile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ImportMap_ImportFile));
      }
    }

    [RelationshipSchemaName("ImportMap_SyncErrors")]
    public IEnumerable<SyncError> ImportMap_SyncErrors
    {
      get => this.GetRelatedEntities<SyncError>(nameof (ImportMap_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ImportMap_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ImportMap_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ImportMap_SyncErrors));
      }
    }

    [RelationshipSchemaName("OwnerMapping_ImportMap")]
    public IEnumerable<OwnerMapping> OwnerMapping_ImportMap
    {
      get
      {
        return this.GetRelatedEntities<OwnerMapping>(nameof (OwnerMapping_ImportMap), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (OwnerMapping_ImportMap));
        this.SetRelatedEntities<OwnerMapping>(nameof (OwnerMapping_ImportMap), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (OwnerMapping_ImportMap));
      }
    }

    [RelationshipSchemaName("TransformationMapping_ImportMap")]
    public IEnumerable<TransformationMapping> TransformationMapping_ImportMap
    {
      get
      {
        return this.GetRelatedEntities<TransformationMapping>(nameof (TransformationMapping_ImportMap), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransformationMapping_ImportMap));
        this.SetRelatedEntities<TransformationMapping>(nameof (TransformationMapping_ImportMap), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransformationMapping_ImportMap));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_importmap")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_importmap
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_importmap), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_importmap));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_importmap), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_importmap));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("BusinessUnit_ImportMaps")]
    public BusinessUnit BusinessUnit_ImportMaps
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (BusinessUnit_ImportMaps), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_importmap_createdonbehalfby")]
    public SystemUser lk_importmap_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_importmap_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_importmap_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_importmap_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_importmap_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_importmap_modifiedonbehalfby")]
    public SystemUser lk_importmap_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_importmap_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_importmap_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_importmap_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_importmap_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_importmapbase_createdby")]
    public SystemUser lk_importmapbase_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_importmapbase_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_importmapbase_modifiedby")]
    public SystemUser lk_importmapbase_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_importmapbase_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("SystemUser_ImportMaps")]
    public SystemUser SystemUser_ImportMaps
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (SystemUser_ImportMaps), new EntityRole?());
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ImportMaps")]
    public Team team_ImportMaps
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ImportMaps), new EntityRole?());
    }

    public ImportMap(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["importmapid"] = (object) base.Id;
            break;
          case "importmapid":
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
