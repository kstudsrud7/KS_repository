// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.UserSettings
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("usersettings")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class UserSettings : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "usersettings";
    public const string EntitySchemaName = "UserSettings";
    public const string PrimaryIdAttribute = "systemuserid";

    public UserSettings()
      : base("usersettings")
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

    [AttributeLogicalName("addressbooksyncinterval")]
    public int? AddressBookSyncInterval
    {
      get => this.GetAttributeValue<int?>("addressbooksyncinterval");
      set
      {
        this.OnPropertyChanging(nameof (AddressBookSyncInterval));
        this.SetAttributeValue("addressbooksyncinterval", (object) value);
        this.OnPropertyChanged(nameof (AddressBookSyncInterval));
      }
    }

    [AttributeLogicalName("advancedfindstartupmode")]
    public int? AdvancedFindStartupMode
    {
      get => this.GetAttributeValue<int?>("advancedfindstartupmode");
      set
      {
        this.OnPropertyChanging(nameof (AdvancedFindStartupMode));
        this.SetAttributeValue("advancedfindstartupmode", (object) value);
        this.OnPropertyChanged(nameof (AdvancedFindStartupMode));
      }
    }

    [AttributeLogicalName("allowemailcredentials")]
    [Obsolete]
    public bool? AllowEmailCredentials => this.GetAttributeValue<bool?>("allowemailcredentials");

    [AttributeLogicalName("amdesignator")]
    public string AMDesignator
    {
      get => this.GetAttributeValue<string>("amdesignator");
      set
      {
        this.OnPropertyChanging(nameof (AMDesignator));
        this.SetAttributeValue("amdesignator", (object) value);
        this.OnPropertyChanged(nameof (AMDesignator));
      }
    }

    [AttributeLogicalName("autocaptureuserstatus")]
    public int? AutoCaptureUserStatus
    {
      get => this.GetAttributeValue<int?>("autocaptureuserstatus");
      set
      {
        this.OnPropertyChanging(nameof (AutoCaptureUserStatus));
        this.SetAttributeValue("autocaptureuserstatus", (object) value);
        this.OnPropertyChanged(nameof (AutoCaptureUserStatus));
      }
    }

    [AttributeLogicalName("autocreatecontactonpromote")]
    public int? AutoCreateContactOnPromote
    {
      get => this.GetAttributeValue<int?>("autocreatecontactonpromote");
      set
      {
        this.OnPropertyChanging(nameof (AutoCreateContactOnPromote));
        this.SetAttributeValue("autocreatecontactonpromote", (object) value);
        this.OnPropertyChanged(nameof (AutoCreateContactOnPromote));
      }
    }

    [AttributeLogicalName("businessunitid")]
    public Guid? BusinessUnitId
    {
      get => this.GetAttributeValue<Guid?>("businessunitid");
      set
      {
        this.OnPropertyChanging(nameof (BusinessUnitId));
        this.SetAttributeValue("businessunitid", (object) value);
        this.OnPropertyChanged(nameof (BusinessUnitId));
      }
    }

    [AttributeLogicalName("calendartype")]
    public int? CalendarType
    {
      get => this.GetAttributeValue<int?>("calendartype");
      set
      {
        this.OnPropertyChanging(nameof (CalendarType));
        this.SetAttributeValue("calendartype", (object) value);
        this.OnPropertyChanged(nameof (CalendarType));
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

    [AttributeLogicalName("currencydecimalprecision")]
    [Obsolete]
    public int? CurrencyDecimalPrecision
    {
      get => this.GetAttributeValue<int?>("currencydecimalprecision");
      set
      {
        this.OnPropertyChanging(nameof (CurrencyDecimalPrecision));
        this.SetAttributeValue("currencydecimalprecision", (object) value);
        this.OnPropertyChanged(nameof (CurrencyDecimalPrecision));
      }
    }

    [AttributeLogicalName("currencyformatcode")]
    public int? CurrencyFormatCode
    {
      get => this.GetAttributeValue<int?>("currencyformatcode");
      set
      {
        this.OnPropertyChanging(nameof (CurrencyFormatCode));
        this.SetAttributeValue("currencyformatcode", (object) value);
        this.OnPropertyChanged(nameof (CurrencyFormatCode));
      }
    }

    [AttributeLogicalName("currencysymbol")]
    public string CurrencySymbol
    {
      get => this.GetAttributeValue<string>("currencysymbol");
      set
      {
        this.OnPropertyChanging(nameof (CurrencySymbol));
        this.SetAttributeValue("currencysymbol", (object) value);
        this.OnPropertyChanged(nameof (CurrencySymbol));
      }
    }

    [AttributeLogicalName("datavalidationmodeforexporttoexcel")]
    public OptionSetValue DataValidationModeForExportToExcel
    {
      get => this.GetAttributeValue<OptionSetValue>("datavalidationmodeforexporttoexcel");
      set
      {
        this.OnPropertyChanging(nameof (DataValidationModeForExportToExcel));
        this.SetAttributeValue("datavalidationmodeforexporttoexcel", (object) value);
        this.OnPropertyChanged(nameof (DataValidationModeForExportToExcel));
      }
    }

    [AttributeLogicalName("dateformatcode")]
    public int? DateFormatCode
    {
      get => this.GetAttributeValue<int?>("dateformatcode");
      set
      {
        this.OnPropertyChanging(nameof (DateFormatCode));
        this.SetAttributeValue("dateformatcode", (object) value);
        this.OnPropertyChanged(nameof (DateFormatCode));
      }
    }

    [AttributeLogicalName("dateformatstring")]
    public string DateFormatString
    {
      get => this.GetAttributeValue<string>("dateformatstring");
      set
      {
        this.OnPropertyChanging(nameof (DateFormatString));
        this.SetAttributeValue("dateformatstring", (object) value);
        this.OnPropertyChanged(nameof (DateFormatString));
      }
    }

    [AttributeLogicalName("dateseparator")]
    public string DateSeparator
    {
      get => this.GetAttributeValue<string>("dateseparator");
      set
      {
        this.OnPropertyChanging(nameof (DateSeparator));
        this.SetAttributeValue("dateseparator", (object) value);
        this.OnPropertyChanged(nameof (DateSeparator));
      }
    }

    [AttributeLogicalName("decimalsymbol")]
    public string DecimalSymbol
    {
      get => this.GetAttributeValue<string>("decimalsymbol");
      set
      {
        this.OnPropertyChanging(nameof (DecimalSymbol));
        this.SetAttributeValue("decimalsymbol", (object) value);
        this.OnPropertyChanged(nameof (DecimalSymbol));
      }
    }

    [AttributeLogicalName("defaultcalendarview")]
    public int? DefaultCalendarView
    {
      get => this.GetAttributeValue<int?>("defaultcalendarview");
      set
      {
        this.OnPropertyChanging(nameof (DefaultCalendarView));
        this.SetAttributeValue("defaultcalendarview", (object) value);
        this.OnPropertyChanged(nameof (DefaultCalendarView));
      }
    }

    [AttributeLogicalName("defaultcountrycode")]
    public string DefaultCountryCode
    {
      get => this.GetAttributeValue<string>("defaultcountrycode");
      set
      {
        this.OnPropertyChanging(nameof (DefaultCountryCode));
        this.SetAttributeValue("defaultcountrycode", (object) value);
        this.OnPropertyChanged(nameof (DefaultCountryCode));
      }
    }

    [AttributeLogicalName("defaultdashboardid")]
    public Guid? DefaultDashboardId
    {
      get => this.GetAttributeValue<Guid?>("defaultdashboardid");
      set
      {
        this.OnPropertyChanging(nameof (DefaultDashboardId));
        this.SetAttributeValue("defaultdashboardid", (object) value);
        this.OnPropertyChanged(nameof (DefaultDashboardId));
      }
    }

    [AttributeLogicalName("defaultsearchexperience")]
    public OptionSetValue DefaultSearchExperience
    {
      get => this.GetAttributeValue<OptionSetValue>("defaultsearchexperience");
      set
      {
        this.OnPropertyChanging(nameof (DefaultSearchExperience));
        this.SetAttributeValue("defaultsearchexperience", (object) value);
        this.OnPropertyChanged(nameof (DefaultSearchExperience));
      }
    }

    [AttributeLogicalName("emailpassword")]
    [Obsolete]
    public string EmailPassword => this.GetAttributeValue<string>("emailpassword");

    [AttributeLogicalName("emailusername")]
    [Obsolete]
    public string EmailUsername => this.GetAttributeValue<string>("emailusername");

    [AttributeLogicalName("entityformmode")]
    public OptionSetValue EntityFormMode
    {
      get => this.GetAttributeValue<OptionSetValue>("entityformmode");
      set
      {
        this.OnPropertyChanging(nameof (EntityFormMode));
        this.SetAttributeValue("entityformmode", (object) value);
        this.OnPropertyChanged(nameof (EntityFormMode));
      }
    }

    [AttributeLogicalName("fullnameconventioncode")]
    public int? FullNameConventionCode
    {
      get => this.GetAttributeValue<int?>("fullnameconventioncode");
      set
      {
        this.OnPropertyChanging(nameof (FullNameConventionCode));
        this.SetAttributeValue("fullnameconventioncode", (object) value);
        this.OnPropertyChanged(nameof (FullNameConventionCode));
      }
    }

    [AttributeLogicalName("getstartedpanecontentenabled")]
    public bool? GetStartedPaneContentEnabled
    {
      get => this.GetAttributeValue<bool?>("getstartedpanecontentenabled");
      set
      {
        this.OnPropertyChanging(nameof (GetStartedPaneContentEnabled));
        this.SetAttributeValue("getstartedpanecontentenabled", (object) value);
        this.OnPropertyChanged(nameof (GetStartedPaneContentEnabled));
      }
    }

    [AttributeLogicalName("helplanguageid")]
    public int? HelpLanguageId
    {
      get => this.GetAttributeValue<int?>("helplanguageid");
      set
      {
        this.OnPropertyChanging(nameof (HelpLanguageId));
        this.SetAttributeValue("helplanguageid", (object) value);
        this.OnPropertyChanged(nameof (HelpLanguageId));
      }
    }

    [AttributeLogicalName("homepagearea")]
    public string HomepageArea
    {
      get => this.GetAttributeValue<string>("homepagearea");
      set
      {
        this.OnPropertyChanging(nameof (HomepageArea));
        this.SetAttributeValue("homepagearea", (object) value);
        this.OnPropertyChanged(nameof (HomepageArea));
      }
    }

    [AttributeLogicalName("homepagelayout")]
    public string HomepageLayout
    {
      get => this.GetAttributeValue<string>("homepagelayout");
      set
      {
        this.OnPropertyChanging(nameof (HomepageLayout));
        this.SetAttributeValue("homepagelayout", (object) value);
        this.OnPropertyChanged(nameof (HomepageLayout));
      }
    }

    [AttributeLogicalName("homepagesubarea")]
    public string HomepageSubarea
    {
      get => this.GetAttributeValue<string>("homepagesubarea");
      set
      {
        this.OnPropertyChanging(nameof (HomepageSubarea));
        this.SetAttributeValue("homepagesubarea", (object) value);
        this.OnPropertyChanged(nameof (HomepageSubarea));
      }
    }

    [AttributeLogicalName("ignoreunsolicitedemail")]
    public bool? IgnoreUnsolicitedEmail
    {
      get => this.GetAttributeValue<bool?>("ignoreunsolicitedemail");
      set
      {
        this.OnPropertyChanging(nameof (IgnoreUnsolicitedEmail));
        this.SetAttributeValue("ignoreunsolicitedemail", (object) value);
        this.OnPropertyChanged(nameof (IgnoreUnsolicitedEmail));
      }
    }

    [AttributeLogicalName("incomingemailfilteringmethod")]
    public OptionSetValue IncomingEmailFilteringMethod
    {
      get => this.GetAttributeValue<OptionSetValue>("incomingemailfilteringmethod");
      set
      {
        this.OnPropertyChanging(nameof (IncomingEmailFilteringMethod));
        this.SetAttributeValue("incomingemailfilteringmethod", (object) value);
        this.OnPropertyChanged(nameof (IncomingEmailFilteringMethod));
      }
    }

    [AttributeLogicalName("isappsforcrmalertdismissed")]
    public bool? IsAppsForCrmAlertDismissed
    {
      get => this.GetAttributeValue<bool?>("isappsforcrmalertdismissed");
      set
      {
        this.OnPropertyChanging(nameof (IsAppsForCrmAlertDismissed));
        this.SetAttributeValue("isappsforcrmalertdismissed", (object) value);
        this.OnPropertyChanged(nameof (IsAppsForCrmAlertDismissed));
      }
    }

    [AttributeLogicalName("isautodatacaptureenabled")]
    public bool? IsAutoDataCaptureEnabled
    {
      get => this.GetAttributeValue<bool?>("isautodatacaptureenabled");
      set
      {
        this.OnPropertyChanging(nameof (IsAutoDataCaptureEnabled));
        this.SetAttributeValue("isautodatacaptureenabled", (object) value);
        this.OnPropertyChanged(nameof (IsAutoDataCaptureEnabled));
      }
    }

    [AttributeLogicalName("isdefaultcountrycodecheckenabled")]
    public bool? IsDefaultCountryCodeCheckEnabled
    {
      get => this.GetAttributeValue<bool?>("isdefaultcountrycodecheckenabled");
      set
      {
        this.OnPropertyChanging(nameof (IsDefaultCountryCodeCheckEnabled));
        this.SetAttributeValue("isdefaultcountrycodecheckenabled", (object) value);
        this.OnPropertyChanged(nameof (IsDefaultCountryCodeCheckEnabled));
      }
    }

    [AttributeLogicalName("isduplicatedetectionenabledwhengoingonline")]
    public bool? IsDuplicateDetectionEnabledWhenGoingOnline
    {
      get => this.GetAttributeValue<bool?>("isduplicatedetectionenabledwhengoingonline");
      set
      {
        this.OnPropertyChanging(nameof (IsDuplicateDetectionEnabledWhenGoingOnline));
        this.SetAttributeValue("isduplicatedetectionenabledwhengoingonline", (object) value);
        this.OnPropertyChanged(nameof (IsDuplicateDetectionEnabledWhenGoingOnline));
      }
    }

    [AttributeLogicalName("isemailconversationviewenabled")]
    public bool? IsEmailConversationViewEnabled
    {
      get => this.GetAttributeValue<bool?>("isemailconversationviewenabled");
      set
      {
        this.OnPropertyChanging(nameof (IsEmailConversationViewEnabled));
        this.SetAttributeValue("isemailconversationviewenabled", (object) value);
        this.OnPropertyChanged(nameof (IsEmailConversationViewEnabled));
      }
    }

    [AttributeLogicalName("isguidedhelpenabled")]
    public bool? IsGuidedHelpEnabled
    {
      get => this.GetAttributeValue<bool?>("isguidedhelpenabled");
      set
      {
        this.OnPropertyChanging(nameof (IsGuidedHelpEnabled));
        this.SetAttributeValue("isguidedhelpenabled", (object) value);
        this.OnPropertyChanged(nameof (IsGuidedHelpEnabled));
      }
    }

    [AttributeLogicalName("isresourcebookingexchangesyncenabled")]
    public bool? IsResourceBookingExchangeSyncEnabled
    {
      get => this.GetAttributeValue<bool?>("isresourcebookingexchangesyncenabled");
      set
      {
        this.OnPropertyChanging(nameof (IsResourceBookingExchangeSyncEnabled));
        this.SetAttributeValue("isresourcebookingexchangesyncenabled", (object) value);
        this.OnPropertyChanged(nameof (IsResourceBookingExchangeSyncEnabled));
      }
    }

    [AttributeLogicalName("issendasallowed")]
    public bool? IsSendAsAllowed
    {
      get => this.GetAttributeValue<bool?>("issendasallowed");
      set
      {
        this.OnPropertyChanging(nameof (IsSendAsAllowed));
        this.SetAttributeValue("issendasallowed", (object) value);
        this.OnPropertyChanged(nameof (IsSendAsAllowed));
      }
    }

    [AttributeLogicalName("lastalertsviewedtime")]
    public DateTime? LastAlertsViewedTime
    {
      get => this.GetAttributeValue<DateTime?>("lastalertsviewedtime");
      set
      {
        this.OnPropertyChanging(nameof (LastAlertsViewedTime));
        this.SetAttributeValue("lastalertsviewedtime", (object) value);
        this.OnPropertyChanged(nameof (LastAlertsViewedTime));
      }
    }

    [AttributeLogicalName("localeid")]
    public int? LocaleId
    {
      get => this.GetAttributeValue<int?>("localeid");
      set
      {
        this.OnPropertyChanging(nameof (LocaleId));
        this.SetAttributeValue("localeid", (object) value);
        this.OnPropertyChanged(nameof (LocaleId));
      }
    }

    [AttributeLogicalName("longdateformatcode")]
    public int? LongDateFormatCode
    {
      get => this.GetAttributeValue<int?>("longdateformatcode");
      set
      {
        this.OnPropertyChanging(nameof (LongDateFormatCode));
        this.SetAttributeValue("longdateformatcode", (object) value);
        this.OnPropertyChanged(nameof (LongDateFormatCode));
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

    [AttributeLogicalName("negativecurrencyformatcode")]
    public int? NegativeCurrencyFormatCode
    {
      get => this.GetAttributeValue<int?>("negativecurrencyformatcode");
      set
      {
        this.OnPropertyChanging(nameof (NegativeCurrencyFormatCode));
        this.SetAttributeValue("negativecurrencyformatcode", (object) value);
        this.OnPropertyChanged(nameof (NegativeCurrencyFormatCode));
      }
    }

    [AttributeLogicalName("negativeformatcode")]
    public int? NegativeFormatCode
    {
      get => this.GetAttributeValue<int?>("negativeformatcode");
      set
      {
        this.OnPropertyChanging(nameof (NegativeFormatCode));
        this.SetAttributeValue("negativeformatcode", (object) value);
        this.OnPropertyChanged(nameof (NegativeFormatCode));
      }
    }

    [AttributeLogicalName("nexttrackingnumber")]
    public int? NextTrackingNumber
    {
      get => this.GetAttributeValue<int?>("nexttrackingnumber");
      set
      {
        this.OnPropertyChanging(nameof (NextTrackingNumber));
        this.SetAttributeValue("nexttrackingnumber", (object) value);
        this.OnPropertyChanged(nameof (NextTrackingNumber));
      }
    }

    [AttributeLogicalName("numbergroupformat")]
    public string NumberGroupFormat
    {
      get => this.GetAttributeValue<string>("numbergroupformat");
      set
      {
        this.OnPropertyChanging(nameof (NumberGroupFormat));
        this.SetAttributeValue("numbergroupformat", (object) value);
        this.OnPropertyChanged(nameof (NumberGroupFormat));
      }
    }

    [AttributeLogicalName("numberseparator")]
    public string NumberSeparator
    {
      get => this.GetAttributeValue<string>("numberseparator");
      set
      {
        this.OnPropertyChanging(nameof (NumberSeparator));
        this.SetAttributeValue("numberseparator", (object) value);
        this.OnPropertyChanged(nameof (NumberSeparator));
      }
    }

    [AttributeLogicalName("offlinesyncinterval")]
    public int? OfflineSyncInterval
    {
      get => this.GetAttributeValue<int?>("offlinesyncinterval");
      set
      {
        this.OnPropertyChanging(nameof (OfflineSyncInterval));
        this.SetAttributeValue("offlinesyncinterval", (object) value);
        this.OnPropertyChanged(nameof (OfflineSyncInterval));
      }
    }

    [AttributeLogicalName("outlooksyncinterval")]
    public int? OutlookSyncInterval
    {
      get => this.GetAttributeValue<int?>("outlooksyncinterval");
      set
      {
        this.OnPropertyChanging(nameof (OutlookSyncInterval));
        this.SetAttributeValue("outlooksyncinterval", (object) value);
        this.OnPropertyChanged(nameof (OutlookSyncInterval));
      }
    }

    [AttributeLogicalName("paginglimit")]
    public int? PagingLimit
    {
      get => this.GetAttributeValue<int?>("paginglimit");
      set
      {
        this.OnPropertyChanging(nameof (PagingLimit));
        this.SetAttributeValue("paginglimit", (object) value);
        this.OnPropertyChanged(nameof (PagingLimit));
      }
    }

    [AttributeLogicalName("personalizationsettings")]
    public string PersonalizationSettings
    {
      get => this.GetAttributeValue<string>("personalizationsettings");
      set
      {
        this.OnPropertyChanging(nameof (PersonalizationSettings));
        this.SetAttributeValue("personalizationsettings", (object) value);
        this.OnPropertyChanged(nameof (PersonalizationSettings));
      }
    }

    [AttributeLogicalName("pmdesignator")]
    public string PMDesignator
    {
      get => this.GetAttributeValue<string>("pmdesignator");
      set
      {
        this.OnPropertyChanging(nameof (PMDesignator));
        this.SetAttributeValue("pmdesignator", (object) value);
        this.OnPropertyChanged(nameof (PMDesignator));
      }
    }

    [AttributeLogicalName("pricingdecimalprecision")]
    [Obsolete]
    public int? PricingDecimalPrecision
    {
      get => this.GetAttributeValue<int?>("pricingdecimalprecision");
      set
      {
        this.OnPropertyChanging(nameof (PricingDecimalPrecision));
        this.SetAttributeValue("pricingdecimalprecision", (object) value);
        this.OnPropertyChanged(nameof (PricingDecimalPrecision));
      }
    }

    [AttributeLogicalName("reportscripterrors")]
    public OptionSetValue ReportScriptErrors
    {
      get => this.GetAttributeValue<OptionSetValue>("reportscripterrors");
      set
      {
        this.OnPropertyChanging(nameof (ReportScriptErrors));
        this.SetAttributeValue("reportscripterrors", (object) value);
        this.OnPropertyChanged(nameof (ReportScriptErrors));
      }
    }

    [AttributeLogicalName("resourcebookingexchangesyncversion")]
    public long? ResourceBookingExchangeSyncVersion
    {
      get => this.GetAttributeValue<long?>("resourcebookingexchangesyncversion");
      set
      {
        this.OnPropertyChanging(nameof (ResourceBookingExchangeSyncVersion));
        this.SetAttributeValue("resourcebookingexchangesyncversion", (object) value);
        this.OnPropertyChanged(nameof (ResourceBookingExchangeSyncVersion));
      }
    }

    [AttributeLogicalName("selectedglobalfilterid")]
    public Guid? SelectedGlobalFilterId
    {
      get => this.GetAttributeValue<Guid?>("selectedglobalfilterid");
      set
      {
        this.OnPropertyChanging(nameof (SelectedGlobalFilterId));
        this.SetAttributeValue("selectedglobalfilterid", (object) value);
        this.OnPropertyChanged(nameof (SelectedGlobalFilterId));
      }
    }

    [AttributeLogicalName("showweeknumber")]
    public bool? ShowWeekNumber
    {
      get => this.GetAttributeValue<bool?>("showweeknumber");
      set
      {
        this.OnPropertyChanging(nameof (ShowWeekNumber));
        this.SetAttributeValue("showweeknumber", (object) value);
        this.OnPropertyChanged(nameof (ShowWeekNumber));
      }
    }

    [AttributeLogicalName("splitviewstate")]
    public bool? SplitViewState
    {
      get => this.GetAttributeValue<bool?>("splitviewstate");
      set
      {
        this.OnPropertyChanging(nameof (SplitViewState));
        this.SetAttributeValue("splitviewstate", (object) value);
        this.OnPropertyChanged(nameof (SplitViewState));
      }
    }

    [AttributeLogicalName("synccontactcompany")]
    public bool? SyncContactCompany
    {
      get => this.GetAttributeValue<bool?>("synccontactcompany");
      set
      {
        this.OnPropertyChanging(nameof (SyncContactCompany));
        this.SetAttributeValue("synccontactcompany", (object) value);
        this.OnPropertyChanged(nameof (SyncContactCompany));
      }
    }

    [AttributeLogicalName("systemuserid")]
    public Guid? SystemUserId
    {
      get => this.GetAttributeValue<Guid?>("systemuserid");
      set
      {
        this.OnPropertyChanging(nameof (SystemUserId));
        this.SetAttributeValue("systemuserid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (SystemUserId));
      }
    }

    [AttributeLogicalName("systemuserid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.SystemUserId = new Guid?(value);
    }

    [AttributeLogicalName("timeformatcode")]
    public int? TimeFormatCode
    {
      get => this.GetAttributeValue<int?>("timeformatcode");
      set
      {
        this.OnPropertyChanging(nameof (TimeFormatCode));
        this.SetAttributeValue("timeformatcode", (object) value);
        this.OnPropertyChanged(nameof (TimeFormatCode));
      }
    }

    [AttributeLogicalName("timeformatstring")]
    public string TimeFormatString
    {
      get => this.GetAttributeValue<string>("timeformatstring");
      set
      {
        this.OnPropertyChanging(nameof (TimeFormatString));
        this.SetAttributeValue("timeformatstring", (object) value);
        this.OnPropertyChanged(nameof (TimeFormatString));
      }
    }

    [AttributeLogicalName("timeseparator")]
    public string TimeSeparator
    {
      get => this.GetAttributeValue<string>("timeseparator");
      set
      {
        this.OnPropertyChanging(nameof (TimeSeparator));
        this.SetAttributeValue("timeseparator", (object) value);
        this.OnPropertyChanged(nameof (TimeSeparator));
      }
    }

    [AttributeLogicalName("timezonebias")]
    public int? TimeZoneBias
    {
      get => this.GetAttributeValue<int?>("timezonebias");
      set
      {
        this.OnPropertyChanging(nameof (TimeZoneBias));
        this.SetAttributeValue("timezonebias", (object) value);
        this.OnPropertyChanged(nameof (TimeZoneBias));
      }
    }

    [AttributeLogicalName("timezonecode")]
    public int? TimeZoneCode
    {
      get => this.GetAttributeValue<int?>("timezonecode");
      set
      {
        this.OnPropertyChanging(nameof (TimeZoneCode));
        this.SetAttributeValue("timezonecode", (object) value);
        this.OnPropertyChanged(nameof (TimeZoneCode));
      }
    }

    [AttributeLogicalName("timezonedaylightbias")]
    public int? TimeZoneDaylightBias
    {
      get => this.GetAttributeValue<int?>("timezonedaylightbias");
      set
      {
        this.OnPropertyChanging(nameof (TimeZoneDaylightBias));
        this.SetAttributeValue("timezonedaylightbias", (object) value);
        this.OnPropertyChanged(nameof (TimeZoneDaylightBias));
      }
    }

    [AttributeLogicalName("timezonedaylightday")]
    public int? TimeZoneDaylightDay
    {
      get => this.GetAttributeValue<int?>("timezonedaylightday");
      set
      {
        this.OnPropertyChanging(nameof (TimeZoneDaylightDay));
        this.SetAttributeValue("timezonedaylightday", (object) value);
        this.OnPropertyChanged(nameof (TimeZoneDaylightDay));
      }
    }

    [AttributeLogicalName("timezonedaylightdayofweek")]
    public int? TimeZoneDaylightDayOfWeek
    {
      get => this.GetAttributeValue<int?>("timezonedaylightdayofweek");
      set
      {
        this.OnPropertyChanging(nameof (TimeZoneDaylightDayOfWeek));
        this.SetAttributeValue("timezonedaylightdayofweek", (object) value);
        this.OnPropertyChanged(nameof (TimeZoneDaylightDayOfWeek));
      }
    }

    [AttributeLogicalName("timezonedaylighthour")]
    public int? TimeZoneDaylightHour
    {
      get => this.GetAttributeValue<int?>("timezonedaylighthour");
      set
      {
        this.OnPropertyChanging(nameof (TimeZoneDaylightHour));
        this.SetAttributeValue("timezonedaylighthour", (object) value);
        this.OnPropertyChanged(nameof (TimeZoneDaylightHour));
      }
    }

    [AttributeLogicalName("timezonedaylightminute")]
    public int? TimeZoneDaylightMinute
    {
      get => this.GetAttributeValue<int?>("timezonedaylightminute");
      set
      {
        this.OnPropertyChanging(nameof (TimeZoneDaylightMinute));
        this.SetAttributeValue("timezonedaylightminute", (object) value);
        this.OnPropertyChanged(nameof (TimeZoneDaylightMinute));
      }
    }

    [AttributeLogicalName("timezonedaylightmonth")]
    public int? TimeZoneDaylightMonth
    {
      get => this.GetAttributeValue<int?>("timezonedaylightmonth");
      set
      {
        this.OnPropertyChanging(nameof (TimeZoneDaylightMonth));
        this.SetAttributeValue("timezonedaylightmonth", (object) value);
        this.OnPropertyChanged(nameof (TimeZoneDaylightMonth));
      }
    }

    [AttributeLogicalName("timezonedaylightsecond")]
    public int? TimeZoneDaylightSecond
    {
      get => this.GetAttributeValue<int?>("timezonedaylightsecond");
      set
      {
        this.OnPropertyChanging(nameof (TimeZoneDaylightSecond));
        this.SetAttributeValue("timezonedaylightsecond", (object) value);
        this.OnPropertyChanged(nameof (TimeZoneDaylightSecond));
      }
    }

    [AttributeLogicalName("timezonedaylightyear")]
    public int? TimeZoneDaylightYear
    {
      get => this.GetAttributeValue<int?>("timezonedaylightyear");
      set
      {
        this.OnPropertyChanging(nameof (TimeZoneDaylightYear));
        this.SetAttributeValue("timezonedaylightyear", (object) value);
        this.OnPropertyChanged(nameof (TimeZoneDaylightYear));
      }
    }

    [AttributeLogicalName("timezonestandardbias")]
    public int? TimeZoneStandardBias
    {
      get => this.GetAttributeValue<int?>("timezonestandardbias");
      set
      {
        this.OnPropertyChanging(nameof (TimeZoneStandardBias));
        this.SetAttributeValue("timezonestandardbias", (object) value);
        this.OnPropertyChanged(nameof (TimeZoneStandardBias));
      }
    }

    [AttributeLogicalName("timezonestandardday")]
    public int? TimeZoneStandardDay
    {
      get => this.GetAttributeValue<int?>("timezonestandardday");
      set
      {
        this.OnPropertyChanging(nameof (TimeZoneStandardDay));
        this.SetAttributeValue("timezonestandardday", (object) value);
        this.OnPropertyChanged(nameof (TimeZoneStandardDay));
      }
    }

    [AttributeLogicalName("timezonestandarddayofweek")]
    public int? TimeZoneStandardDayOfWeek
    {
      get => this.GetAttributeValue<int?>("timezonestandarddayofweek");
      set
      {
        this.OnPropertyChanging(nameof (TimeZoneStandardDayOfWeek));
        this.SetAttributeValue("timezonestandarddayofweek", (object) value);
        this.OnPropertyChanged(nameof (TimeZoneStandardDayOfWeek));
      }
    }

    [AttributeLogicalName("timezonestandardhour")]
    public int? TimeZoneStandardHour
    {
      get => this.GetAttributeValue<int?>("timezonestandardhour");
      set
      {
        this.OnPropertyChanging(nameof (TimeZoneStandardHour));
        this.SetAttributeValue("timezonestandardhour", (object) value);
        this.OnPropertyChanged(nameof (TimeZoneStandardHour));
      }
    }

    [AttributeLogicalName("timezonestandardminute")]
    public int? TimeZoneStandardMinute
    {
      get => this.GetAttributeValue<int?>("timezonestandardminute");
      set
      {
        this.OnPropertyChanging(nameof (TimeZoneStandardMinute));
        this.SetAttributeValue("timezonestandardminute", (object) value);
        this.OnPropertyChanged(nameof (TimeZoneStandardMinute));
      }
    }

    [AttributeLogicalName("timezonestandardmonth")]
    public int? TimeZoneStandardMonth
    {
      get => this.GetAttributeValue<int?>("timezonestandardmonth");
      set
      {
        this.OnPropertyChanging(nameof (TimeZoneStandardMonth));
        this.SetAttributeValue("timezonestandardmonth", (object) value);
        this.OnPropertyChanged(nameof (TimeZoneStandardMonth));
      }
    }

    [AttributeLogicalName("timezonestandardsecond")]
    public int? TimeZoneStandardSecond
    {
      get => this.GetAttributeValue<int?>("timezonestandardsecond");
      set
      {
        this.OnPropertyChanging(nameof (TimeZoneStandardSecond));
        this.SetAttributeValue("timezonestandardsecond", (object) value);
        this.OnPropertyChanged(nameof (TimeZoneStandardSecond));
      }
    }

    [AttributeLogicalName("timezonestandardyear")]
    public int? TimeZoneStandardYear
    {
      get => this.GetAttributeValue<int?>("timezonestandardyear");
      set
      {
        this.OnPropertyChanging(nameof (TimeZoneStandardYear));
        this.SetAttributeValue("timezonestandardyear", (object) value);
        this.OnPropertyChanged(nameof (TimeZoneStandardYear));
      }
    }

    [AttributeLogicalName("trackingtokenid")]
    public int? TrackingTokenId
    {
      get => this.GetAttributeValue<int?>("trackingtokenid");
      set
      {
        this.OnPropertyChanging(nameof (TrackingTokenId));
        this.SetAttributeValue("trackingtokenid", (object) value);
        this.OnPropertyChanged(nameof (TrackingTokenId));
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

    [AttributeLogicalName("uilanguageid")]
    public int? UILanguageId
    {
      get => this.GetAttributeValue<int?>("uilanguageid");
      set
      {
        this.OnPropertyChanging(nameof (UILanguageId));
        this.SetAttributeValue("uilanguageid", (object) value);
        this.OnPropertyChanged(nameof (UILanguageId));
      }
    }

    [AttributeLogicalName("usecrmformforappointment")]
    public bool? UseCrmFormForAppointment
    {
      get => this.GetAttributeValue<bool?>("usecrmformforappointment");
      set
      {
        this.OnPropertyChanging(nameof (UseCrmFormForAppointment));
        this.SetAttributeValue("usecrmformforappointment", (object) value);
        this.OnPropertyChanged(nameof (UseCrmFormForAppointment));
      }
    }

    [AttributeLogicalName("usecrmformforcontact")]
    public bool? UseCrmFormForContact
    {
      get => this.GetAttributeValue<bool?>("usecrmformforcontact");
      set
      {
        this.OnPropertyChanging(nameof (UseCrmFormForContact));
        this.SetAttributeValue("usecrmformforcontact", (object) value);
        this.OnPropertyChanged(nameof (UseCrmFormForContact));
      }
    }

    [AttributeLogicalName("usecrmformforemail")]
    public bool? UseCrmFormForEmail
    {
      get => this.GetAttributeValue<bool?>("usecrmformforemail");
      set
      {
        this.OnPropertyChanging(nameof (UseCrmFormForEmail));
        this.SetAttributeValue("usecrmformforemail", (object) value);
        this.OnPropertyChanged(nameof (UseCrmFormForEmail));
      }
    }

    [AttributeLogicalName("usecrmformfortask")]
    public bool? UseCrmFormForTask
    {
      get => this.GetAttributeValue<bool?>("usecrmformfortask");
      set
      {
        this.OnPropertyChanging(nameof (UseCrmFormForTask));
        this.SetAttributeValue("usecrmformfortask", (object) value);
        this.OnPropertyChanged(nameof (UseCrmFormForTask));
      }
    }

    [AttributeLogicalName("useimagestrips")]
    public bool? UseImageStrips
    {
      get => this.GetAttributeValue<bool?>("useimagestrips");
      set
      {
        this.OnPropertyChanging(nameof (UseImageStrips));
        this.SetAttributeValue("useimagestrips", (object) value);
        this.OnPropertyChanged(nameof (UseImageStrips));
      }
    }

    [AttributeLogicalName("userprofile")]
    public string UserProfile
    {
      get => this.GetAttributeValue<string>("userprofile");
      set
      {
        this.OnPropertyChanging(nameof (UserProfile));
        this.SetAttributeValue("userprofile", (object) value);
        this.OnPropertyChanged(nameof (UserProfile));
      }
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [AttributeLogicalName("visualizationpanelayout")]
    public OptionSetValue VisualizationPaneLayout
    {
      get => this.GetAttributeValue<OptionSetValue>("visualizationpanelayout");
      set
      {
        this.OnPropertyChanging(nameof (VisualizationPaneLayout));
        this.SetAttributeValue("visualizationpanelayout", (object) value);
        this.OnPropertyChanged(nameof (VisualizationPaneLayout));
      }
    }

    [AttributeLogicalName("workdaystarttime")]
    public string WorkdayStartTime
    {
      get => this.GetAttributeValue<string>("workdaystarttime");
      set
      {
        this.OnPropertyChanging(nameof (WorkdayStartTime));
        this.SetAttributeValue("workdaystarttime", (object) value);
        this.OnPropertyChanged(nameof (WorkdayStartTime));
      }
    }

    [AttributeLogicalName("workdaystoptime")]
    public string WorkdayStopTime
    {
      get => this.GetAttributeValue<string>("workdaystoptime");
      set
      {
        this.OnPropertyChanging(nameof (WorkdayStopTime));
        this.SetAttributeValue("workdaystoptime", (object) value);
        this.OnPropertyChanged(nameof (WorkdayStopTime));
      }
    }

    [AttributeLogicalName("businessunitid")]
    [RelationshipSchemaName("business_unit_user_settings")]
    public BusinessUnit business_unit_user_settings
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_user_settings), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_user_settings));
        this.SetRelatedEntity<BusinessUnit>(nameof (business_unit_user_settings), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_user_settings));
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_usersettings_createdonbehalfby")]
    public SystemUser lk_usersettings_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_usersettings_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_usersettings_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_usersettings_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_usersettings_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_usersettings_modifiedonbehalfby")]
    public SystemUser lk_usersettings_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_usersettings_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_usersettings_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_usersettings_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_usersettings_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_usersettingsbase_createdby")]
    public SystemUser lk_usersettingsbase_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_usersettingsbase_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_usersettingsbase_modifiedby")]
    public SystemUser lk_usersettingsbase_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_usersettingsbase_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("transactioncurrency_usersettings")]
    public TransactionCurrency transactioncurrency_usersettings
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (transactioncurrency_usersettings), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (transactioncurrency_usersettings));
        this.SetRelatedEntity<TransactionCurrency>(nameof (transactioncurrency_usersettings), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (transactioncurrency_usersettings));
      }
    }

    [AttributeLogicalName("systemuserid")]
    [RelationshipSchemaName("user_settings")]
    public SystemUser user_settings
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_settings), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (user_settings));
        this.SetRelatedEntity<SystemUser>(nameof (user_settings), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (user_settings));
      }
    }

    public UserSettings(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["systemuserid"] = (object) base.Id;
            break;
          case "systemuserid":
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
