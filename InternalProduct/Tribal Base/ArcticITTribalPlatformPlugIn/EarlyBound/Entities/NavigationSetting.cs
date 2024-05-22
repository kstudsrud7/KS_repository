// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.NavigationSetting
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("navigationsetting")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class NavigationSetting : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "navigationsetting";
    public const string EntitySchemaName = "NavigationSetting";
    public const string PrimaryIdAttribute = "navigationsettingid";
    public const string PrimaryNameAttribute = "name";

    public NavigationSetting()
      : base("navigationsetting")
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

    [AttributeLogicalName("advancedsettingorder")]
    public int? AdvancedSettingOrder
    {
      get => this.GetAttributeValue<int?>("advancedsettingorder");
      set
      {
        this.OnPropertyChanging(nameof (AdvancedSettingOrder));
        this.SetAttributeValue("advancedsettingorder", (object) value);
        this.OnPropertyChanged(nameof (AdvancedSettingOrder));
      }
    }

    [AttributeLogicalName("appconfigid")]
    public EntityReference AppConfigId
    {
      get => this.GetAttributeValue<EntityReference>("appconfigid");
      set
      {
        this.OnPropertyChanging(nameof (AppConfigId));
        this.SetAttributeValue("appconfigid", (object) value);
        this.OnPropertyChanged(nameof (AppConfigId));
      }
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

    [AttributeLogicalName("groupname")]
    public string GroupName
    {
      get => this.GetAttributeValue<string>("groupname");
      set
      {
        this.OnPropertyChanging(nameof (GroupName));
        this.SetAttributeValue("groupname", (object) value);
        this.OnPropertyChanged(nameof (GroupName));
      }
    }

    [AttributeLogicalName("iconresourceid")]
    public Guid? IconResourceId
    {
      get => this.GetAttributeValue<Guid?>("iconresourceid");
      set
      {
        this.OnPropertyChanging(nameof (IconResourceId));
        this.SetAttributeValue("iconresourceid", (object) value);
        this.OnPropertyChanged(nameof (IconResourceId));
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

    [AttributeLogicalName("navigationsettingid")]
    public Guid? NavigationSettingId
    {
      get => this.GetAttributeValue<Guid?>("navigationsettingid");
      set
      {
        this.OnPropertyChanging(nameof (NavigationSettingId));
        this.SetAttributeValue("navigationsettingid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (NavigationSettingId));
      }
    }

    [AttributeLogicalName("navigationsettingid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.NavigationSettingId = new Guid?(value);
    }

    [AttributeLogicalName("navigationsettingidunique")]
    public Guid? NavigationSettingIdUnique
    {
      get => this.GetAttributeValue<Guid?>("navigationsettingidunique");
      set
      {
        this.OnPropertyChanging(nameof (NavigationSettingIdUnique));
        this.SetAttributeValue("navigationsettingidunique", (object) value);
        this.OnPropertyChanged(nameof (NavigationSettingIdUnique));
      }
    }

    [AttributeLogicalName("objecttypecode")]
    public int? ObjectTypeCode
    {
      get => this.GetAttributeValue<int?>("objecttypecode");
      set
      {
        this.OnPropertyChanging(nameof (ObjectTypeCode));
        this.SetAttributeValue("objecttypecode", (object) value);
        this.OnPropertyChanged(nameof (ObjectTypeCode));
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

    [AttributeLogicalName("pageurl")]
    public string PageUrl
    {
      get => this.GetAttributeValue<string>("pageurl");
      set
      {
        this.OnPropertyChanging(nameof (PageUrl));
        this.SetAttributeValue("pageurl", (object) value);
        this.OnPropertyChanged(nameof (PageUrl));
      }
    }

    [AttributeLogicalName("parentnavigationsettingid")]
    public Guid? ParentNavigationSettingId
    {
      get => this.GetAttributeValue<Guid?>("parentnavigationsettingid");
      set
      {
        this.OnPropertyChanging(nameof (ParentNavigationSettingId));
        this.SetAttributeValue("parentnavigationsettingid", (object) value);
        this.OnPropertyChanged(nameof (ParentNavigationSettingId));
      }
    }

    [AttributeLogicalName("privileges")]
    public int? Privileges
    {
      get => this.GetAttributeValue<int?>("privileges");
      set
      {
        this.OnPropertyChanging(nameof (Privileges));
        this.SetAttributeValue("privileges", (object) value);
        this.OnPropertyChanged(nameof (Privileges));
      }
    }

    [AttributeLogicalName("progressstate")]
    public bool? ProgressState
    {
      get => this.GetAttributeValue<bool?>("progressstate");
      set
      {
        this.OnPropertyChanging(nameof (ProgressState));
        this.SetAttributeValue("progressstate", (object) value);
        this.OnPropertyChanged(nameof (ProgressState));
      }
    }

    [AttributeLogicalName("quicksettingorder")]
    public int? QuickSettingOrder
    {
      get => this.GetAttributeValue<int?>("quicksettingorder");
      set
      {
        this.OnPropertyChanging(nameof (QuickSettingOrder));
        this.SetAttributeValue("quicksettingorder", (object) value);
        this.OnPropertyChanged(nameof (QuickSettingOrder));
      }
    }

    [AttributeLogicalName("resourceid")]
    public Guid? ResourceId
    {
      get => this.GetAttributeValue<Guid?>("resourceid");
      set
      {
        this.OnPropertyChanging(nameof (ResourceId));
        this.SetAttributeValue("resourceid", (object) value);
        this.OnPropertyChanged(nameof (ResourceId));
      }
    }

    [AttributeLogicalName("settingtype")]
    public OptionSetValue SettingType
    {
      get => this.GetAttributeValue<OptionSetValue>("settingtype");
      set
      {
        this.OnPropertyChanging(nameof (SettingType));
        this.SetAttributeValue("settingtype", (object) value);
        this.OnPropertyChanged(nameof (SettingType));
      }
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_navigationsetting_createdby")]
    public SystemUser lk_navigationsetting_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_navigationsetting_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_navigationsetting_createdonbehalfby")]
    public SystemUser lk_navigationsetting_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_navigationsetting_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_navigationsetting_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_navigationsetting_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_navigationsetting_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_navigationsetting_modifiedby")]
    public SystemUser lk_navigationsetting_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_navigationsetting_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_navigationsetting_modifiedonbehalfby")]
    public SystemUser lk_navigationsetting_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_navigationsetting_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_navigationsetting_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_navigationsetting_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_navigationsetting_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("appconfigid")]
    [RelationshipSchemaName("navigationsetting_appconfig")]
    public AppConfig navigationsetting_appconfig
    {
      get
      {
        return this.GetRelatedEntity<AppConfig>(nameof (navigationsetting_appconfig), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (navigationsetting_appconfig));
        this.SetRelatedEntity<AppConfig>(nameof (navigationsetting_appconfig), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (navigationsetting_appconfig));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_navigationsetting")]
    public Organization organization_navigationsetting
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_navigationsetting), new EntityRole?());
      }
    }

    public NavigationSetting(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["navigationsettingid"] = (object) base.Id;
            break;
          case "navigationsettingid":
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
