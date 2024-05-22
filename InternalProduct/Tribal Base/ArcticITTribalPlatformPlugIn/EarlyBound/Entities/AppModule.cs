// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.AppModule
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("appmodule")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class AppModule : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "appmodule";
    public const string EntitySchemaName = "AppModule";
    public const string PrimaryIdAttribute = "appmoduleid";
    public const string PrimaryNameAttribute = "name";

    public AppModule()
      : base("appmodule")
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

    [AttributeLogicalName("appmoduleid")]
    public Guid? AppModuleId
    {
      get => this.GetAttributeValue<Guid?>("appmoduleid");
      set
      {
        this.OnPropertyChanging(nameof (AppModuleId));
        this.SetAttributeValue("appmoduleid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (AppModuleId));
      }
    }

    [AttributeLogicalName("appmoduleid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.AppModuleId = new Guid?(value);
    }

    [AttributeLogicalName("appmoduleidunique")]
    public Guid? AppModuleIdUnique
    {
      get => this.GetAttributeValue<Guid?>("appmoduleidunique");
      set
      {
        this.OnPropertyChanging(nameof (AppModuleIdUnique));
        this.SetAttributeValue("appmoduleidunique", (object) value);
        this.OnPropertyChanged(nameof (AppModuleIdUnique));
      }
    }

    [AttributeLogicalName("appmoduleversion")]
    public string AppModuleVersion
    {
      get => this.GetAttributeValue<string>("appmoduleversion");
      set
      {
        this.OnPropertyChanging(nameof (AppModuleVersion));
        this.SetAttributeValue("appmoduleversion", (object) value);
        this.OnPropertyChanged(nameof (AppModuleVersion));
      }
    }

    [AttributeLogicalName("appmodulexmlmanaged")]
    public string AppModuleXmlManaged
    {
      get => this.GetAttributeValue<string>("appmodulexmlmanaged");
      set
      {
        this.OnPropertyChanging(nameof (AppModuleXmlManaged));
        this.SetAttributeValue("appmodulexmlmanaged", (object) value);
        this.OnPropertyChanged(nameof (AppModuleXmlManaged));
      }
    }

    [AttributeLogicalName("clienttype")]
    public int? ClientType
    {
      get => this.GetAttributeValue<int?>("clienttype");
      set
      {
        this.OnPropertyChanging(nameof (ClientType));
        this.SetAttributeValue("clienttype", (object) value);
        this.OnPropertyChanged(nameof (ClientType));
      }
    }

    [AttributeLogicalName("componentstate")]
    public OptionSetValue ComponentState
    {
      get => this.GetAttributeValue<OptionSetValue>("componentstate");
    }

    [AttributeLogicalName("configxml")]
    public string ConfigXML
    {
      get => this.GetAttributeValue<string>("configxml");
      set
      {
        this.OnPropertyChanging(nameof (ConfigXML));
        this.SetAttributeValue("configxml", (object) value);
        this.OnPropertyChanged(nameof (ConfigXML));
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

    [AttributeLogicalName("descriptor")]
    public string Descriptor => this.GetAttributeValue<string>("descriptor");

    [AttributeLogicalName("eventhandlers")]
    public string EventHandlers
    {
      get => this.GetAttributeValue<string>("eventhandlers");
      set
      {
        this.OnPropertyChanging(nameof (EventHandlers));
        this.SetAttributeValue("eventhandlers", (object) value);
        this.OnPropertyChanged(nameof (EventHandlers));
      }
    }

    [AttributeLogicalName("formfactor")]
    public int? FormFactor
    {
      get => this.GetAttributeValue<int?>("formfactor");
      set
      {
        this.OnPropertyChanging(nameof (FormFactor));
        this.SetAttributeValue("formfactor", (object) value);
        this.OnPropertyChanged(nameof (FormFactor));
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

    [AttributeLogicalName("isfeatured")]
    public bool? IsFeatured
    {
      get => this.GetAttributeValue<bool?>("isfeatured");
      set
      {
        this.OnPropertyChanging(nameof (IsFeatured));
        this.SetAttributeValue("isfeatured", (object) value);
        this.OnPropertyChanged(nameof (IsFeatured));
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

    [AttributeLogicalName("navigationtype")]
    public OptionSetValue NavigationType
    {
      get => this.GetAttributeValue<OptionSetValue>("navigationtype");
      set
      {
        this.OnPropertyChanging(nameof (NavigationType));
        this.SetAttributeValue("navigationtype", (object) value);
        this.OnPropertyChanged(nameof (NavigationType));
      }
    }

    [AttributeLogicalName("optimizedfor")]
    public string OptimizedFor
    {
      get => this.GetAttributeValue<string>("optimizedfor");
      set
      {
        this.OnPropertyChanging(nameof (OptimizedFor));
        this.SetAttributeValue("optimizedfor", (object) value);
        this.OnPropertyChanged(nameof (OptimizedFor));
      }
    }

    [AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get => this.GetAttributeValue<EntityReference>("organizationid");
    }

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

    [AttributeLogicalName("publishedon")]
    public DateTime? PublishedOn
    {
      get => this.GetAttributeValue<DateTime?>("publishedon");
      set
      {
        this.OnPropertyChanging(nameof (PublishedOn));
        this.SetAttributeValue("publishedon", (object) value);
        this.OnPropertyChanged(nameof (PublishedOn));
      }
    }

    [AttributeLogicalName("publisherid")]
    public EntityReference PublisherId
    {
      get => this.GetAttributeValue<EntityReference>("publisherid");
      set
      {
        this.OnPropertyChanging(nameof (PublisherId));
        this.SetAttributeValue("publisherid", (object) value);
        this.OnPropertyChanged(nameof (PublisherId));
      }
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("statecode")]
    public AppModuleState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new AppModuleState?((AppModuleState) Enum.ToObject(typeof (AppModuleState), attributeValue.Value)) : new AppModuleState?();
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

    [AttributeLogicalName("uniquename")]
    public string UniqueName
    {
      get => this.GetAttributeValue<string>("uniquename");
      set
      {
        this.OnPropertyChanging(nameof (UniqueName));
        this.SetAttributeValue("uniquename", (object) value);
        this.OnPropertyChanged(nameof (UniqueName));
      }
    }

    [AttributeLogicalName("url")]
    public string URL
    {
      get => this.GetAttributeValue<string>("url");
      set
      {
        this.OnPropertyChanging(nameof (URL));
        this.SetAttributeValue("url", (object) value);
        this.OnPropertyChanged(nameof (URL));
      }
    }

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
        this.OnPropertyChanged(nameof (WebResourceId));
      }
    }

    [AttributeLogicalName("welcomepageid")]
    public Guid? WelcomePageId
    {
      get => this.GetAttributeValue<Guid?>("welcomepageid");
      set
      {
        this.OnPropertyChanging(nameof (WelcomePageId));
        this.SetAttributeValue("welcomepageid", (object) value);
        this.OnPropertyChanged(nameof (WelcomePageId));
      }
    }

    [RelationshipSchemaName("appmodule_appconfig")]
    public IEnumerable<AppConfig> appmodule_appconfig
    {
      get => this.GetRelatedEntities<AppConfig>(nameof (appmodule_appconfig), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (appmodule_appconfig));
        this.SetRelatedEntities<AppConfig>(nameof (appmodule_appconfig), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appmodule_appconfig));
      }
    }

    [RelationshipSchemaName("appmodule_appelement_parentappmoduleid")]
    public IEnumerable<AppElement> appmodule_appelement_parentappmoduleid
    {
      get
      {
        return this.GetRelatedEntities<AppElement>(nameof (appmodule_appelement_parentappmoduleid), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appmodule_appelement_parentappmoduleid));
        this.SetRelatedEntities<AppElement>(nameof (appmodule_appelement_parentappmoduleid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appmodule_appelement_parentappmoduleid));
      }
    }

    [RelationshipSchemaName("appmodule_appmodulecomponent")]
    public IEnumerable<AppModuleComponent> appmodule_appmodulecomponent
    {
      get
      {
        return this.GetRelatedEntities<AppModuleComponent>(nameof (appmodule_appmodulecomponent), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appmodule_appmodulecomponent));
        this.SetRelatedEntities<AppModuleComponent>(nameof (appmodule_appmodulecomponent), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appmodule_appmodulecomponent));
      }
    }

    [RelationshipSchemaName("appmodule_appsetting_parentappmoduleid")]
    public IEnumerable<AppSetting> appmodule_appsetting_parentappmoduleid
    {
      get
      {
        return this.GetRelatedEntities<AppSetting>(nameof (appmodule_appsetting_parentappmoduleid), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appmodule_appsetting_parentappmoduleid));
        this.SetRelatedEntities<AppSetting>(nameof (appmodule_appsetting_parentappmoduleid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appmodule_appsetting_parentappmoduleid));
      }
    }

    [RelationshipSchemaName("appmoduleroles_association")]
    public IEnumerable<Role> appmoduleroles_association
    {
      get => this.GetRelatedEntities<Role>(nameof (appmoduleroles_association), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (appmoduleroles_association));
        this.SetRelatedEntities<Role>(nameof (appmoduleroles_association), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appmoduleroles_association));
      }
    }

    [RelationshipSchemaName("serviceplan_appmodule")]
    public IEnumerable<ServicePlan> serviceplan_appmodule
    {
      get
      {
        return this.GetRelatedEntities<ServicePlan>(nameof (serviceplan_appmodule), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (serviceplan_appmodule));
        this.SetRelatedEntities<ServicePlan>(nameof (serviceplan_appmodule), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (serviceplan_appmodule));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_appmodule_createdby")]
    public SystemUser lk_appmodule_createdby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_appmodule_createdby), new EntityRole?());
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_appmodule_createdonbehalfby")]
    public SystemUser lk_appmodule_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_appmodule_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_appmodule_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_appmodule_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_appmodule_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_appmodule_modifiedby")]
    public SystemUser lk_appmodule_modifiedby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_appmodule_modifiedby), new EntityRole?());
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_appmodule_modifiedonbehalfby")]
    public SystemUser lk_appmodule_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_appmodule_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_appmodule_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_appmodule_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_appmodule_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_appmodule")]
    public Organization organization_appmodule
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_appmodule), new EntityRole?());
      }
    }

    [AttributeLogicalName("publisherid")]
    [RelationshipSchemaName("publisher_appmodule")]
    public Publisher publisher_appmodule
    {
      get => this.GetRelatedEntity<Publisher>(nameof (publisher_appmodule), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (publisher_appmodule));
        this.SetRelatedEntity<Publisher>(nameof (publisher_appmodule), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (publisher_appmodule));
      }
    }

    public AppModule(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["appmoduleid"] = (object) base.Id;
            break;
          case "appmoduleid":
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
