// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.Theme
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("theme")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class Theme : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "theme";
    public const string EntitySchemaName = "Theme";
    public const string PrimaryIdAttribute = "themeid";
    public const string PrimaryNameAttribute = "name";

    public Theme()
      : base("theme")
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

    [AttributeLogicalName("accentcolor")]
    public string AccentColor
    {
      get => this.GetAttributeValue<string>("accentcolor");
      set
      {
        this.OnPropertyChanging(nameof (AccentColor));
        this.SetAttributeValue("accentcolor", (object) value);
        this.OnPropertyChanged(nameof (AccentColor));
      }
    }

    [AttributeLogicalName("backgroundcolor")]
    public string BackgroundColor
    {
      get => this.GetAttributeValue<string>("backgroundcolor");
      set
      {
        this.OnPropertyChanging(nameof (BackgroundColor));
        this.SetAttributeValue("backgroundcolor", (object) value);
        this.OnPropertyChanged(nameof (BackgroundColor));
      }
    }

    [AttributeLogicalName("controlborder")]
    public string ControlBorder
    {
      get => this.GetAttributeValue<string>("controlborder");
      set
      {
        this.OnPropertyChanging(nameof (ControlBorder));
        this.SetAttributeValue("controlborder", (object) value);
        this.OnPropertyChanged(nameof (ControlBorder));
      }
    }

    [AttributeLogicalName("controlshade")]
    public string ControlShade
    {
      get => this.GetAttributeValue<string>("controlshade");
      set
      {
        this.OnPropertyChanging(nameof (ControlShade));
        this.SetAttributeValue("controlshade", (object) value);
        this.OnPropertyChanged(nameof (ControlShade));
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

    [AttributeLogicalName("defaultcustomentitycolor")]
    public string DefaultCustomEntityColor
    {
      get => this.GetAttributeValue<string>("defaultcustomentitycolor");
      set
      {
        this.OnPropertyChanging(nameof (DefaultCustomEntityColor));
        this.SetAttributeValue("defaultcustomentitycolor", (object) value);
        this.OnPropertyChanged(nameof (DefaultCustomEntityColor));
      }
    }

    [AttributeLogicalName("defaultentitycolor")]
    public string DefaultEntityColor
    {
      get => this.GetAttributeValue<string>("defaultentitycolor");
      set
      {
        this.OnPropertyChanging(nameof (DefaultEntityColor));
        this.SetAttributeValue("defaultentitycolor", (object) value);
        this.OnPropertyChanged(nameof (DefaultEntityColor));
      }
    }

    [AttributeLogicalName("exchangerate")]
    public Decimal? ExchangeRate => this.GetAttributeValue<Decimal?>("exchangerate");

    [AttributeLogicalName("globallinkcolor")]
    public string GlobalLinkColor
    {
      get => this.GetAttributeValue<string>("globallinkcolor");
      set
      {
        this.OnPropertyChanging(nameof (GlobalLinkColor));
        this.SetAttributeValue("globallinkcolor", (object) value);
        this.OnPropertyChanged(nameof (GlobalLinkColor));
      }
    }

    [AttributeLogicalName("headercolor")]
    public string HeaderColor
    {
      get => this.GetAttributeValue<string>("headercolor");
      set
      {
        this.OnPropertyChanging(nameof (HeaderColor));
        this.SetAttributeValue("headercolor", (object) value);
        this.OnPropertyChanged(nameof (HeaderColor));
      }
    }

    [AttributeLogicalName("hoverlinkeffect")]
    public string HoverLinkEffect
    {
      get => this.GetAttributeValue<string>("hoverlinkeffect");
      set
      {
        this.OnPropertyChanging(nameof (HoverLinkEffect));
        this.SetAttributeValue("hoverlinkeffect", (object) value);
        this.OnPropertyChanged(nameof (HoverLinkEffect));
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

    [AttributeLogicalName("isdefaulttheme")]
    public bool? IsDefaultTheme
    {
      get => this.GetAttributeValue<bool?>("isdefaulttheme");
      set
      {
        this.OnPropertyChanging(nameof (IsDefaultTheme));
        this.SetAttributeValue("isdefaulttheme", (object) value);
        this.OnPropertyChanged(nameof (IsDefaultTheme));
      }
    }

    [AttributeLogicalName("logoid")]
    public EntityReference LogoId
    {
      get => this.GetAttributeValue<EntityReference>("logoid");
      set
      {
        this.OnPropertyChanging(nameof (LogoId));
        this.SetAttributeValue("logoid", (object) value);
        this.OnPropertyChanged(nameof (LogoId));
      }
    }

    [AttributeLogicalName("logotooltip")]
    public string LogoToolTip
    {
      get => this.GetAttributeValue<string>("logotooltip");
      set
      {
        this.OnPropertyChanging(nameof (LogoToolTip));
        this.SetAttributeValue("logotooltip", (object) value);
        this.OnPropertyChanged(nameof (LogoToolTip));
      }
    }

    [AttributeLogicalName("maincolor")]
    public string MainColor
    {
      get => this.GetAttributeValue<string>("maincolor");
      set
      {
        this.OnPropertyChanging(nameof (MainColor));
        this.SetAttributeValue("maincolor", (object) value);
        this.OnPropertyChanged(nameof (MainColor));
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

    [AttributeLogicalName("navbarbackgroundcolor")]
    public string NavBarBackgroundColor
    {
      get => this.GetAttributeValue<string>("navbarbackgroundcolor");
      set
      {
        this.OnPropertyChanging(nameof (NavBarBackgroundColor));
        this.SetAttributeValue("navbarbackgroundcolor", (object) value);
        this.OnPropertyChanged(nameof (NavBarBackgroundColor));
      }
    }

    [AttributeLogicalName("navbarshelfcolor")]
    public string NavBarShelfColor
    {
      get => this.GetAttributeValue<string>("navbarshelfcolor");
      set
      {
        this.OnPropertyChanging(nameof (NavBarShelfColor));
        this.SetAttributeValue("navbarshelfcolor", (object) value);
        this.OnPropertyChanged(nameof (NavBarShelfColor));
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

    [AttributeLogicalName("pageheaderbackgroundcolor")]
    public string PageHeaderBackgroundColor
    {
      get => this.GetAttributeValue<string>("pageheaderbackgroundcolor");
      set
      {
        this.OnPropertyChanging(nameof (PageHeaderBackgroundColor));
        this.SetAttributeValue("pageheaderbackgroundcolor", (object) value);
        this.OnPropertyChanged(nameof (PageHeaderBackgroundColor));
      }
    }

    [AttributeLogicalName("panelheaderbackgroundcolor")]
    public string PanelHeaderBackgroundColor
    {
      get => this.GetAttributeValue<string>("panelheaderbackgroundcolor");
      set
      {
        this.OnPropertyChanging(nameof (PanelHeaderBackgroundColor));
        this.SetAttributeValue("panelheaderbackgroundcolor", (object) value);
        this.OnPropertyChanged(nameof (PanelHeaderBackgroundColor));
      }
    }

    [AttributeLogicalName("processcontrolcolor")]
    public string ProcessControlColor
    {
      get => this.GetAttributeValue<string>("processcontrolcolor");
      set
      {
        this.OnPropertyChanging(nameof (ProcessControlColor));
        this.SetAttributeValue("processcontrolcolor", (object) value);
        this.OnPropertyChanged(nameof (ProcessControlColor));
      }
    }

    [AttributeLogicalName("selectedlinkeffect")]
    public string SelectedLinkEffect
    {
      get => this.GetAttributeValue<string>("selectedlinkeffect");
      set
      {
        this.OnPropertyChanging(nameof (SelectedLinkEffect));
        this.SetAttributeValue("selectedlinkeffect", (object) value);
        this.OnPropertyChanged(nameof (SelectedLinkEffect));
      }
    }

    [AttributeLogicalName("statecode")]
    public ThemeState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ThemeState?((ThemeState) Enum.ToObject(typeof (ThemeState), attributeValue.Value)) : new ThemeState?();
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

    [AttributeLogicalName("themeid")]
    public Guid? ThemeId
    {
      get => this.GetAttributeValue<Guid?>("themeid");
      set
      {
        this.OnPropertyChanging(nameof (ThemeId));
        this.SetAttributeValue("themeid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ThemeId));
      }
    }

    [AttributeLogicalName("themeid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ThemeId = new Guid?(value);
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

    [AttributeLogicalName("transactioncurrencyid")]
    public EntityReference TransactionCurrencyId
    {
      get => this.GetAttributeValue<EntityReference>("transactioncurrencyid");
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrencyId));
        this.SetAttributeValue("transactioncurrencyid", (object) value);
        this.OnPropertyChanged(nameof (TransactionCurrencyId));
      }
    }

    [AttributeLogicalName("type")]
    public bool? Type
    {
      get => this.GetAttributeValue<bool?>("type");
      set
      {
        this.OnPropertyChanging(nameof (Type));
        this.SetAttributeValue("type", (object) value);
        this.OnPropertyChanged(nameof (Type));
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

    [RelationshipSchemaName("theme_AsyncOperations")]
    public IEnumerable<AsyncOperation> theme_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (theme_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (theme_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (theme_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (theme_AsyncOperations));
      }
    }

    [RelationshipSchemaName("theme_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> theme_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (theme_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (theme_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (theme_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (theme_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("theme_ProcessSession")]
    public IEnumerable<ProcessSession> theme_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (theme_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (theme_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (theme_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (theme_ProcessSession));
      }
    }

    [RelationshipSchemaName("theme_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> theme_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (theme_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (theme_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (theme_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (theme_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_theme_createdby")]
    public SystemUser lk_theme_createdby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_theme_createdby), new EntityRole?());
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_theme_createdonbehalfby")]
    public SystemUser lk_theme_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_theme_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_theme_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_theme_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_theme_createdonbehalfby));
      }
    }

    [AttributeLogicalName("logoid")]
    [RelationshipSchemaName("lk_theme_logoid")]
    public WebResource lk_theme_logoid
    {
      get => this.GetRelatedEntity<WebResource>(nameof (lk_theme_logoid), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (lk_theme_logoid));
        this.SetRelatedEntity<WebResource>(nameof (lk_theme_logoid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_theme_logoid));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_theme_modifiedby")]
    public SystemUser lk_theme_modifiedby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_theme_modifiedby), new EntityRole?());
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_theme_modifiedonbehalfby")]
    public SystemUser lk_theme_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_theme_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_theme_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_theme_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_theme_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_theme")]
    public Organization organization_theme
    {
      get => this.GetRelatedEntity<Organization>(nameof (organization_theme), new EntityRole?());
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_Theme")]
    public TransactionCurrency TransactionCurrency_Theme
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_Theme), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_Theme));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_Theme), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_Theme));
      }
    }

    public Theme(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["themeid"] = (object) base.Id;
            break;
          case "themeid":
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
