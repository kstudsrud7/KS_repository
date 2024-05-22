// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.AppModuleComponent
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("appmodulecomponent")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class AppModuleComponent : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "appmodulecomponent";
    public const string EntitySchemaName = "AppModuleComponent";
    public const string PrimaryIdAttribute = "appmodulecomponentid";

    public AppModuleComponent()
      : base("appmodulecomponent")
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

    [AttributeLogicalName("appmodulecomponentid")]
    public Guid? AppModuleComponentId
    {
      get => this.GetAttributeValue<Guid?>("appmodulecomponentid");
      set
      {
        this.OnPropertyChanging(nameof (AppModuleComponentId));
        this.SetAttributeValue("appmodulecomponentid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (AppModuleComponentId));
      }
    }

    [AttributeLogicalName("appmodulecomponentid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.AppModuleComponentId = new Guid?(value);
    }

    [AttributeLogicalName("appmodulecomponentidunique")]
    public Guid? AppModuleComponentIdUnique
    {
      get => this.GetAttributeValue<Guid?>("appmodulecomponentidunique");
      set
      {
        this.OnPropertyChanging(nameof (AppModuleComponentIdUnique));
        this.SetAttributeValue("appmodulecomponentidunique", (object) value);
        this.OnPropertyChanged(nameof (AppModuleComponentIdUnique));
      }
    }

    [AttributeLogicalName("appmoduleidunique")]
    public EntityReference AppModuleIdUnique
    {
      get => this.GetAttributeValue<EntityReference>("appmoduleidunique");
      set
      {
        this.OnPropertyChanging(nameof (AppModuleIdUnique));
        this.SetAttributeValue("appmoduleidunique", (object) value);
        this.OnPropertyChanged(nameof (AppModuleIdUnique));
      }
    }

    [AttributeLogicalName("componenttype")]
    public OptionSetValue ComponentType
    {
      get => this.GetAttributeValue<OptionSetValue>("componenttype");
      set
      {
        this.OnPropertyChanging(nameof (ComponentType));
        this.SetAttributeValue("componenttype", (object) value);
        this.OnPropertyChanged(nameof (ComponentType));
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

    [AttributeLogicalName("exchangerate")]
    public Decimal? ExchangeRate => this.GetAttributeValue<Decimal?>("exchangerate");

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

    [AttributeLogicalName("ismetadata")]
    public bool? IsMetadata
    {
      get => this.GetAttributeValue<bool?>("ismetadata");
      set
      {
        this.OnPropertyChanging(nameof (IsMetadata));
        this.SetAttributeValue("ismetadata", (object) value);
        this.OnPropertyChanged(nameof (IsMetadata));
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

    [AttributeLogicalName("objectid")]
    public Guid? ObjectId
    {
      get => this.GetAttributeValue<Guid?>("objectid");
      set
      {
        this.OnPropertyChanging(nameof (ObjectId));
        this.SetAttributeValue("objectid", (object) value);
        this.OnPropertyChanged(nameof (ObjectId));
      }
    }

    [AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime => this.GetAttributeValue<DateTime?>("overwritetime");

    [AttributeLogicalName("rootappmodulecomponentid")]
    public Guid? RootAppModuleComponentId
    {
      get => this.GetAttributeValue<Guid?>("rootappmodulecomponentid");
      set
      {
        this.OnPropertyChanging(nameof (RootAppModuleComponentId));
        this.SetAttributeValue("rootappmodulecomponentid", (object) value);
        this.OnPropertyChanged(nameof (RootAppModuleComponentId));
      }
    }

    [AttributeLogicalName("rootcomponentbehavior")]
    public OptionSetValue RootComponentBehavior
    {
      get => this.GetAttributeValue<OptionSetValue>("rootcomponentbehavior");
      set
      {
        this.OnPropertyChanging(nameof (RootComponentBehavior));
        this.SetAttributeValue("rootcomponentbehavior", (object) value);
        this.OnPropertyChanged(nameof (RootComponentBehavior));
      }
    }

    [AttributeLogicalName("timezoneruleversionnumber")]
    public int? TimeZoneRuleVersionNumber
    {
      get => this.GetAttributeValue<int?>("timezoneruleversionnumber");
      set
      {
        this.OnPropertyChanging(nameof (TimeZoneRuleVersionNumber));
        this.SetAttributeValue("timezoneruleversionnumber", (object) value);
        this.OnPropertyChanged(nameof (TimeZoneRuleVersionNumber));
      }
    }

    [AttributeLogicalName("utcconversiontimezonecode")]
    public int? UTCConversionTimeZoneCode
    {
      get => this.GetAttributeValue<int?>("utcconversiontimezonecode");
      set
      {
        this.OnPropertyChanging(nameof (UTCConversionTimeZoneCode));
        this.SetAttributeValue("utcconversiontimezonecode", (object) value);
        this.OnPropertyChanged(nameof (UTCConversionTimeZoneCode));
      }
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [AttributeLogicalName("appmoduleidunique")]
    [RelationshipSchemaName("appmodule_appmodulecomponent")]
    public AppModule appmodule_appmodulecomponent
    {
      get
      {
        return this.GetRelatedEntity<AppModule>(nameof (appmodule_appmodulecomponent), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appmodule_appmodulecomponent));
        this.SetRelatedEntity<AppModule>(nameof (appmodule_appmodulecomponent), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appmodule_appmodulecomponent));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_appmodulecomponent_createdby")]
    public SystemUser lk_appmodulecomponent_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_appmodulecomponent_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_appmodulecomponent_createdonbehalfby")]
    public SystemUser lk_appmodulecomponent_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_appmodulecomponent_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_appmodulecomponent_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_appmodulecomponent_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_appmodulecomponent_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_appmodulecomponent_modifiedby")]
    public SystemUser lk_appmodulecomponent_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_appmodulecomponent_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_appmodulecomponent_modifiedonbehalfby")]
    public SystemUser lk_appmodulecomponent_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_appmodulecomponent_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_appmodulecomponent_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_appmodulecomponent_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_appmodulecomponent_modifiedonbehalfby));
      }
    }

    public AppModuleComponent(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["appmodulecomponentid"] = (object) base.Id;
            break;
          case "appmodulecomponentid":
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
