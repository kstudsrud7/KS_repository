// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.WebResource
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("webresource")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class WebResource : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "webresource";
    public const string EntitySchemaName = "WebResource";
    public const string PrimaryIdAttribute = "webresourceid";
    public const string PrimaryNameAttribute = "name";

    public WebResource()
      : base("webresource")
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

    [AttributeLogicalName("componentstate")]
    public OptionSetValue ComponentState
    {
      get => this.GetAttributeValue<OptionSetValue>("componentstate");
    }

    [AttributeLogicalName("content")]
    public string Content
    {
      get => this.GetAttributeValue<string>("content");
      set
      {
        this.OnPropertyChanging(nameof (Content));
        this.SetAttributeValue("content", (object) value);
        this.OnPropertyChanged(nameof (Content));
      }
    }

    [AttributeLogicalName("contentjson")]
    public string ContentJson
    {
      get => this.GetAttributeValue<string>("contentjson");
      set
      {
        this.OnPropertyChanging(nameof (ContentJson));
        this.SetAttributeValue("contentjson", (object) value);
        this.OnPropertyChanged(nameof (ContentJson));
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

    [AttributeLogicalName("dependencyxml")]
    public string DependencyXml
    {
      get => this.GetAttributeValue<string>("dependencyxml");
      set
      {
        this.OnPropertyChanging(nameof (DependencyXml));
        this.SetAttributeValue("dependencyxml", (object) value);
        this.OnPropertyChanged(nameof (DependencyXml));
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

    [AttributeLogicalName("displayname")]
    public string DisplayName
    {
      get => this.GetAttributeValue<string>("displayname");
      set
      {
        this.OnPropertyChanging(nameof (DisplayName));
        this.SetAttributeValue("displayname", (object) value);
        this.OnPropertyChanged(nameof (DisplayName));
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

    [AttributeLogicalName("isavailableformobileoffline")]
    public bool? IsAvailableForMobileOffline
    {
      get => this.GetAttributeValue<bool?>("isavailableformobileoffline");
      set
      {
        this.OnPropertyChanging(nameof (IsAvailableForMobileOffline));
        this.SetAttributeValue("isavailableformobileoffline", (object) value);
        this.OnPropertyChanged(nameof (IsAvailableForMobileOffline));
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

    [AttributeLogicalName("isenabledformobileclient")]
    public bool? IsEnabledForMobileClient
    {
      get => this.GetAttributeValue<bool?>("isenabledformobileclient");
      set
      {
        this.OnPropertyChanging(nameof (IsEnabledForMobileClient));
        this.SetAttributeValue("isenabledformobileclient", (object) value);
        this.OnPropertyChanged(nameof (IsEnabledForMobileClient));
      }
    }

    [AttributeLogicalName("ishidden")]
    public BooleanManagedProperty IsHidden
    {
      get => this.GetAttributeValue<BooleanManagedProperty>("ishidden");
      set
      {
        this.OnPropertyChanging(nameof (IsHidden));
        this.SetAttributeValue("ishidden", (object) value);
        this.OnPropertyChanged(nameof (IsHidden));
      }
    }

    [AttributeLogicalName("ismanaged")]
    public bool? IsManaged => this.GetAttributeValue<bool?>("ismanaged");

    [AttributeLogicalName("languagecode")]
    public int? LanguageCode
    {
      get => this.GetAttributeValue<int?>("languagecode");
      set
      {
        this.OnPropertyChanging(nameof (LanguageCode));
        this.SetAttributeValue("languagecode", (object) value);
        this.OnPropertyChanged(nameof (LanguageCode));
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

    [AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime => this.GetAttributeValue<DateTime?>("overwritetime");

    [AttributeLogicalName("silverlightversion")]
    public string SilverlightVersion
    {
      get => this.GetAttributeValue<string>("silverlightversion");
      set
      {
        this.OnPropertyChanging(nameof (SilverlightVersion));
        this.SetAttributeValue("silverlightversion", (object) value);
        this.OnPropertyChanged(nameof (SilverlightVersion));
      }
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [AttributeLogicalName("webresourceid")]
    public Guid? WebResourceId
    {
      get => this.GetAttributeValue<Guid?>("webresourceid");
      set
      {
        this.OnPropertyChanging(nameof (WebResourceId));
        this.SetAttributeValue("webresourceid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (WebResourceId));
      }
    }

    [AttributeLogicalName("webresourceid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.WebResourceId = new Guid?(value);
    }

    [AttributeLogicalName("webresourceidunique")]
    public Guid? WebResourceIdUnique => this.GetAttributeValue<Guid?>("webresourceidunique");

    [AttributeLogicalName("webresourcetype")]
    public OptionSetValue WebResourceType
    {
      get => this.GetAttributeValue<OptionSetValue>("webresourcetype");
      set
      {
        this.OnPropertyChanging(nameof (WebResourceType));
        this.SetAttributeValue("webresourcetype", (object) value);
        this.OnPropertyChanged(nameof (WebResourceType));
      }
    }

    [RelationshipSchemaName("lk_theme_logoid")]
    public IEnumerable<Theme> lk_theme_logoid
    {
      get => this.GetRelatedEntities<Theme>(nameof (lk_theme_logoid), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (lk_theme_logoid));
        this.SetRelatedEntities<Theme>(nameof (lk_theme_logoid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_theme_logoid));
      }
    }

    [RelationshipSchemaName("solution_configuration_webresource")]
    public IEnumerable<Solution> solution_configuration_webresource
    {
      get
      {
        return this.GetRelatedEntities<Solution>(nameof (solution_configuration_webresource), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (solution_configuration_webresource));
        this.SetRelatedEntities<Solution>(nameof (solution_configuration_webresource), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (solution_configuration_webresource));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_webresource")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_webresource
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_webresource), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_webresource));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_webresource), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_webresource));
      }
    }

    [RelationshipSchemaName("webresource_savedqueryvisualizations")]
    public IEnumerable<SavedQueryVisualization> webresource_savedqueryvisualizations
    {
      get
      {
        return this.GetRelatedEntities<SavedQueryVisualization>(nameof (webresource_savedqueryvisualizations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (webresource_savedqueryvisualizations));
        this.SetRelatedEntities<SavedQueryVisualization>(nameof (webresource_savedqueryvisualizations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (webresource_savedqueryvisualizations));
      }
    }

    [RelationshipSchemaName("webresource_userqueryvisualizations")]
    public IEnumerable<UserQueryVisualization> webresource_userqueryvisualizations
    {
      get
      {
        return this.GetRelatedEntities<UserQueryVisualization>(nameof (webresource_userqueryvisualizations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (webresource_userqueryvisualizations));
        this.SetRelatedEntities<UserQueryVisualization>(nameof (webresource_userqueryvisualizations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (webresource_userqueryvisualizations));
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_webresourcebase_createdonbehalfby")]
    public SystemUser lk_webresourcebase_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_webresourcebase_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_webresourcebase_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_webresourcebase_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_webresourcebase_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_webresourcebase_modifiedonbehalfby")]
    public SystemUser lk_webresourcebase_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_webresourcebase_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_webresourcebase_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_webresourcebase_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_webresourcebase_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("webresource_createdby")]
    public SystemUser webresource_createdby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (webresource_createdby), new EntityRole?());
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("webresource_modifiedby")]
    public SystemUser webresource_modifiedby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (webresource_modifiedby), new EntityRole?());
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("webresource_organization")]
    public Organization webresource_organization
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (webresource_organization), new EntityRole?());
      }
    }

    public WebResource(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["webresourceid"] = (object) base.Id;
            break;
          case "webresourceid":
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
