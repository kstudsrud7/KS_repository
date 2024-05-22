// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.SavedQueryVisualization
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("savedqueryvisualization")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class SavedQueryVisualization : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "savedqueryvisualization";
    public const string EntitySchemaName = "SavedQueryVisualization";
    public const string PrimaryIdAttribute = "savedqueryvisualizationid";
    public const string PrimaryNameAttribute = "name";

    public SavedQueryVisualization()
      : base("savedqueryvisualization")
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

    [AttributeLogicalName("charttype")]
    public OptionSetValue ChartType
    {
      get => this.GetAttributeValue<OptionSetValue>("charttype");
      set
      {
        this.OnPropertyChanging(nameof (ChartType));
        this.SetAttributeValue("charttype", (object) value);
        this.OnPropertyChanged(nameof (ChartType));
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

    [AttributeLogicalName("datadescription")]
    public string DataDescription
    {
      get => this.GetAttributeValue<string>("datadescription");
      set
      {
        this.OnPropertyChanging(nameof (DataDescription));
        this.SetAttributeValue("datadescription", (object) value);
        this.OnPropertyChanged(nameof (DataDescription));
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

    [AttributeLogicalName("isdefault")]
    public bool? IsDefault
    {
      get => this.GetAttributeValue<bool?>("isdefault");
      set
      {
        this.OnPropertyChanging(nameof (IsDefault));
        this.SetAttributeValue("isdefault", (object) value);
        this.OnPropertyChanged(nameof (IsDefault));
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

    [AttributeLogicalName("presentationdescription")]
    public string PresentationDescription
    {
      get => this.GetAttributeValue<string>("presentationdescription");
      set
      {
        this.OnPropertyChanging(nameof (PresentationDescription));
        this.SetAttributeValue("presentationdescription", (object) value);
        this.OnPropertyChanged(nameof (PresentationDescription));
      }
    }

    [AttributeLogicalName("primaryentitytypecode")]
    public string PrimaryEntityTypeCode
    {
      get => this.GetAttributeValue<string>("primaryentitytypecode");
      set
      {
        this.OnPropertyChanging(nameof (PrimaryEntityTypeCode));
        this.SetAttributeValue("primaryentitytypecode", (object) value);
        this.OnPropertyChanged(nameof (PrimaryEntityTypeCode));
      }
    }

    [AttributeLogicalName("savedqueryvisualizationid")]
    public Guid? SavedQueryVisualizationId
    {
      get => this.GetAttributeValue<Guid?>("savedqueryvisualizationid");
      set
      {
        this.OnPropertyChanging(nameof (SavedQueryVisualizationId));
        this.SetAttributeValue("savedqueryvisualizationid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (SavedQueryVisualizationId));
      }
    }

    [AttributeLogicalName("savedqueryvisualizationid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.SavedQueryVisualizationId = new Guid?(value);
    }

    [AttributeLogicalName("savedqueryvisualizationidunique")]
    public Guid? SavedQueryVisualizationIdUnique
    {
      get => this.GetAttributeValue<Guid?>("savedqueryvisualizationidunique");
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("type")]
    public OptionSetValue Type
    {
      get => this.GetAttributeValue<OptionSetValue>("type");
      set
      {
        this.OnPropertyChanging(nameof (Type));
        this.SetAttributeValue("type", (object) value);
        this.OnPropertyChanged(nameof (Type));
      }
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [AttributeLogicalName("webresourceid")]
    public EntityReference WebResourceId
    {
      get => this.GetAttributeValue<EntityReference>("webresourceid");
      set
      {
        this.OnPropertyChanging(nameof (WebResourceId));
        this.SetAttributeValue("webresourceid", (object) value);
        this.OnPropertyChanged(nameof (WebResourceId));
      }
    }

    [RelationshipSchemaName("SavedQueryVisualization_SyncErrors")]
    public IEnumerable<SyncError> SavedQueryVisualization_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (SavedQueryVisualization_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SavedQueryVisualization_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (SavedQueryVisualization_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SavedQueryVisualization_SyncErrors));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_savedqueryvisualization")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_savedqueryvisualization
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_savedqueryvisualization), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_savedqueryvisualization));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_savedqueryvisualization), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_savedqueryvisualization));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_savedqueryvisualizationbase_createdby")]
    public SystemUser lk_savedqueryvisualizationbase_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_savedqueryvisualizationbase_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_savedqueryvisualizationbase_createdonbehalfby")]
    public SystemUser lk_savedqueryvisualizationbase_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_savedqueryvisualizationbase_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_savedqueryvisualizationbase_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_savedqueryvisualizationbase_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_savedqueryvisualizationbase_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_savedqueryvisualizationbase_modifiedby")]
    public SystemUser lk_savedqueryvisualizationbase_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_savedqueryvisualizationbase_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_savedqueryvisualizationbase_modifiedonbehalfby")]
    public SystemUser lk_savedqueryvisualizationbase_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_savedqueryvisualizationbase_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_savedqueryvisualizationbase_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_savedqueryvisualizationbase_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_savedqueryvisualizationbase_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_saved_query_visualizations")]
    public Organization organization_saved_query_visualizations
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_saved_query_visualizations), new EntityRole?());
      }
    }

    [AttributeLogicalName("webresourceid")]
    [RelationshipSchemaName("webresource_savedqueryvisualizations")]
    public WebResource webresource_savedqueryvisualizations
    {
      get
      {
        return this.GetRelatedEntity<WebResource>(nameof (webresource_savedqueryvisualizations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (webresource_savedqueryvisualizations));
        this.SetRelatedEntity<WebResource>(nameof (webresource_savedqueryvisualizations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (webresource_savedqueryvisualizations));
      }
    }

    public SavedQueryVisualization(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["savedqueryvisualizationid"] = (object) base.Id;
            break;
          case "savedqueryvisualizationid":
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
