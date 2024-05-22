// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.AppConfig
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("appconfig")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class AppConfig : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "appconfig";
    public const string EntitySchemaName = "AppConfig";
    public const string PrimaryIdAttribute = "appconfigid";

    public AppConfig()
      : base("appconfig")
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

    [AttributeLogicalName("appconfigid")]
    public Guid? AppConfigId => this.GetAttributeValue<Guid?>("appconfigid");

    [AttributeLogicalName("appconfigid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => base.Id = value;
    }

    [AttributeLogicalName("appconfigidunique")]
    public Guid? AppConfigIdUnique
    {
      get => this.GetAttributeValue<Guid?>("appconfigidunique");
      set
      {
        this.OnPropertyChanging(nameof (AppConfigIdUnique));
        this.SetAttributeValue("appconfigidunique", (object) value);
        this.OnPropertyChanged(nameof (AppConfigIdUnique));
      }
    }

    [AttributeLogicalName("appconfigimportxml")]
    public string AppConfigImportXml
    {
      get => this.GetAttributeValue<string>("appconfigimportxml");
      set
      {
        this.OnPropertyChanging(nameof (AppConfigImportXml));
        this.SetAttributeValue("appconfigimportxml", (object) value);
        this.OnPropertyChanged(nameof (AppConfigImportXml));
      }
    }

    [AttributeLogicalName("appmoduleid")]
    public EntityReference AppModuleId
    {
      get => this.GetAttributeValue<EntityReference>("appmoduleid");
      set
      {
        this.OnPropertyChanging(nameof (AppModuleId));
        this.SetAttributeValue("appmoduleid", (object) value);
        this.OnPropertyChanged(nameof (AppModuleId));
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
    public int? ImportSequenceNumber => this.GetAttributeValue<int?>("importsequencenumber");

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

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("statecode")]
    public AppConfigState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new AppConfigState?((AppConfigState) Enum.ToObject(typeof (AppConfigState), attributeValue.Value)) : new AppConfigState?();
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

    [RelationshipSchemaName("appconfig_appconfiginstance")]
    public IEnumerable<AppConfigInstance> appconfig_appconfiginstance
    {
      get
      {
        return this.GetRelatedEntities<AppConfigInstance>(nameof (appconfig_appconfiginstance), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appconfig_appconfiginstance));
        this.SetRelatedEntities<AppConfigInstance>(nameof (appconfig_appconfiginstance), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appconfig_appconfiginstance));
      }
    }

    [RelationshipSchemaName("navigationsetting_appconfig")]
    public IEnumerable<NavigationSetting> navigationsetting_appconfig
    {
      get
      {
        return this.GetRelatedEntities<NavigationSetting>(nameof (navigationsetting_appconfig), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (navigationsetting_appconfig));
        this.SetRelatedEntities<NavigationSetting>(nameof (navigationsetting_appconfig), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (navigationsetting_appconfig));
      }
    }

    [AttributeLogicalName("appmoduleid")]
    [RelationshipSchemaName("appmodule_appconfig")]
    public AppModule appmodule_appconfig
    {
      get => this.GetRelatedEntity<AppModule>(nameof (appmodule_appconfig), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (appmodule_appconfig));
        this.SetRelatedEntity<AppModule>(nameof (appmodule_appconfig), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appmodule_appconfig));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_appconfig_createdby")]
    public SystemUser lk_appconfig_createdby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_appconfig_createdby), new EntityRole?());
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_appconfig_createdonbehalfby")]
    public SystemUser lk_appconfig_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_appconfig_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_appconfig_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_appconfig_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_appconfig_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_appconfig_modifiedby")]
    public SystemUser lk_appconfig_modifiedby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_appconfig_modifiedby), new EntityRole?());
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_appconfig_modifiedonbehalfby")]
    public SystemUser lk_appconfig_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_appconfig_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_appconfig_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_appconfig_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_appconfig_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_appconfig")]
    public Organization organization_appconfig
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_appconfig), new EntityRole?());
      }
    }

    public AppConfig(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["appconfigid"] = (object) base.Id;
            break;
          case "appconfigid":
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
