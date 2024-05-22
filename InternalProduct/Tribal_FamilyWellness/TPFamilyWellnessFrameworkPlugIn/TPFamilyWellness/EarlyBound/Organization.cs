// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EarlyBound.Organization
// Assembly: TPFamilyWellness.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: C0DF2365-4BFC-418D-B654-2FF4D2B8EB1A
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPFamilyWellnessFrameworkPlugIn-A0924F88-EA00-EA11-A82D-000D3A1F0599\TPFamilyWellnessFrameworkPlugIn.dll

using Microsoft.Xrm.Sdk;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

#nullable disable
namespace TPFamilyWellness.EarlyBound
{
  [DataContract]
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("organization")]
  [GeneratedCode("CrmSvcUtil", "9.0.0.9154")]
  public class Organization : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "organization";
    public const int EntityTypeCode = 1019;

    public Organization()
      : base("organization")
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

    [AttributeLogicalName("aciwebendpointurl")]
    public string ACIWebEndpointUrl
    {
      get => this.GetAttributeValue<string>("aciwebendpointurl");
      set
      {
        this.OnPropertyChanging(nameof (ACIWebEndpointUrl));
        this.SetAttributeValue("aciwebendpointurl", (object) value);
        this.OnPropertyChanged(nameof (ACIWebEndpointUrl));
      }
    }

    [AttributeLogicalName("acknowledgementtemplateid")]
    public EntityReference AcknowledgementTemplateId
    {
      get => this.GetAttributeValue<EntityReference>("acknowledgementtemplateid");
      set
      {
        this.OnPropertyChanging(nameof (AcknowledgementTemplateId));
        this.SetAttributeValue("acknowledgementtemplateid", (object) value);
        this.OnPropertyChanged(nameof (AcknowledgementTemplateId));
      }
    }

    [AttributeLogicalName("allowaddressbooksyncs")]
    public bool? AllowAddressBookSyncs
    {
      get => this.GetAttributeValue<bool?>("allowaddressbooksyncs");
      set
      {
        this.OnPropertyChanging(nameof (AllowAddressBookSyncs));
        this.SetAttributeValue("allowaddressbooksyncs", (object) value);
        this.OnPropertyChanged(nameof (AllowAddressBookSyncs));
      }
    }

    [AttributeLogicalName("allowautoresponsecreation")]
    public bool? AllowAutoResponseCreation
    {
      get => this.GetAttributeValue<bool?>("allowautoresponsecreation");
      set
      {
        this.OnPropertyChanging(nameof (AllowAutoResponseCreation));
        this.SetAttributeValue("allowautoresponsecreation", (object) value);
        this.OnPropertyChanged(nameof (AllowAutoResponseCreation));
      }
    }

    [AttributeLogicalName("allowautounsubscribe")]
    public bool? AllowAutoUnsubscribe
    {
      get => this.GetAttributeValue<bool?>("allowautounsubscribe");
      set
      {
        this.OnPropertyChanging(nameof (AllowAutoUnsubscribe));
        this.SetAttributeValue("allowautounsubscribe", (object) value);
        this.OnPropertyChanged(nameof (AllowAutoUnsubscribe));
      }
    }

    [AttributeLogicalName("allowautounsubscribeacknowledgement")]
    public bool? AllowAutoUnsubscribeAcknowledgement
    {
      get => this.GetAttributeValue<bool?>("allowautounsubscribeacknowledgement");
      set
      {
        this.OnPropertyChanging(nameof (AllowAutoUnsubscribeAcknowledgement));
        this.SetAttributeValue("allowautounsubscribeacknowledgement", (object) value);
        this.OnPropertyChanged(nameof (AllowAutoUnsubscribeAcknowledgement));
      }
    }

    [AttributeLogicalName("allowclientmessagebarad")]
    public bool? AllowClientMessageBarAd
    {
      get => this.GetAttributeValue<bool?>("allowclientmessagebarad");
      set
      {
        this.OnPropertyChanging(nameof (AllowClientMessageBarAd));
        this.SetAttributeValue("allowclientmessagebarad", (object) value);
        this.OnPropertyChanged(nameof (AllowClientMessageBarAd));
      }
    }

    [AttributeLogicalName("allowentityonlyaudit")]
    public bool? AllowEntityOnlyAudit
    {
      get => this.GetAttributeValue<bool?>("allowentityonlyaudit");
      set
      {
        this.OnPropertyChanging(nameof (AllowEntityOnlyAudit));
        this.SetAttributeValue("allowentityonlyaudit", (object) value);
        this.OnPropertyChanged(nameof (AllowEntityOnlyAudit));
      }
    }

    [AttributeLogicalName("allowlegacyclientexperience")]
    public bool? AllowLegacyClientExperience
    {
      get => this.GetAttributeValue<bool?>("allowlegacyclientexperience");
      set
      {
        this.OnPropertyChanging(nameof (AllowLegacyClientExperience));
        this.SetAttributeValue("allowlegacyclientexperience", (object) value);
        this.OnPropertyChanged(nameof (AllowLegacyClientExperience));
      }
    }

    [AttributeLogicalName("allowlegacydialogsembedding")]
    public bool? AllowLegacyDialogsEmbedding
    {
      get => this.GetAttributeValue<bool?>("allowlegacydialogsembedding");
      set
      {
        this.OnPropertyChanging(nameof (AllowLegacyDialogsEmbedding));
        this.SetAttributeValue("allowlegacydialogsembedding", (object) value);
        this.OnPropertyChanged(nameof (AllowLegacyDialogsEmbedding));
      }
    }

    [AttributeLogicalName("allowmarketingemailexecution")]
    public bool? AllowMarketingEmailExecution
    {
      get => this.GetAttributeValue<bool?>("allowmarketingemailexecution");
      set
      {
        this.OnPropertyChanging(nameof (AllowMarketingEmailExecution));
        this.SetAttributeValue("allowmarketingemailexecution", (object) value);
        this.OnPropertyChanged(nameof (AllowMarketingEmailExecution));
      }
    }

    [AttributeLogicalName("allowofflinescheduledsyncs")]
    public bool? AllowOfflineScheduledSyncs
    {
      get => this.GetAttributeValue<bool?>("allowofflinescheduledsyncs");
      set
      {
        this.OnPropertyChanging(nameof (AllowOfflineScheduledSyncs));
        this.SetAttributeValue("allowofflinescheduledsyncs", (object) value);
        this.OnPropertyChanged(nameof (AllowOfflineScheduledSyncs));
      }
    }

    [AttributeLogicalName("allowoutlookscheduledsyncs")]
    public bool? AllowOutlookScheduledSyncs
    {
      get => this.GetAttributeValue<bool?>("allowoutlookscheduledsyncs");
      set
      {
        this.OnPropertyChanging(nameof (AllowOutlookScheduledSyncs));
        this.SetAttributeValue("allowoutlookscheduledsyncs", (object) value);
        this.OnPropertyChanged(nameof (AllowOutlookScheduledSyncs));
      }
    }

    [AttributeLogicalName("allowunresolvedpartiesonemailsend")]
    public bool? AllowUnresolvedPartiesOnEmailSend
    {
      get => this.GetAttributeValue<bool?>("allowunresolvedpartiesonemailsend");
      set
      {
        this.OnPropertyChanging(nameof (AllowUnresolvedPartiesOnEmailSend));
        this.SetAttributeValue("allowunresolvedpartiesonemailsend", (object) value);
        this.OnPropertyChanged(nameof (AllowUnresolvedPartiesOnEmailSend));
      }
    }

    [AttributeLogicalName("allowuserformmodepreference")]
    public bool? AllowUserFormModePreference
    {
      get => this.GetAttributeValue<bool?>("allowuserformmodepreference");
      set
      {
        this.OnPropertyChanging(nameof (AllowUserFormModePreference));
        this.SetAttributeValue("allowuserformmodepreference", (object) value);
        this.OnPropertyChanged(nameof (AllowUserFormModePreference));
      }
    }

    [AttributeLogicalName("allowusersseeappdownloadmessage")]
    public bool? AllowUsersSeeAppdownloadMessage
    {
      get => this.GetAttributeValue<bool?>("allowusersseeappdownloadmessage");
      set
      {
        this.OnPropertyChanging(nameof (AllowUsersSeeAppdownloadMessage));
        this.SetAttributeValue("allowusersseeappdownloadmessage", (object) value);
        this.OnPropertyChanged(nameof (AllowUsersSeeAppdownloadMessage));
      }
    }

    [AttributeLogicalName("allowwebexcelexport")]
    public bool? AllowWebExcelExport
    {
      get => this.GetAttributeValue<bool?>("allowwebexcelexport");
      set
      {
        this.OnPropertyChanging(nameof (AllowWebExcelExport));
        this.SetAttributeValue("allowwebexcelexport", (object) value);
        this.OnPropertyChanged(nameof (AllowWebExcelExport));
      }
    }

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

    [AttributeLogicalName("appdesignerexperienceenabled")]
    public bool? AppDesignerExperienceEnabled
    {
      get => this.GetAttributeValue<bool?>("appdesignerexperienceenabled");
      set
      {
        this.OnPropertyChanging(nameof (AppDesignerExperienceEnabled));
        this.SetAttributeValue("appdesignerexperienceenabled", (object) value);
        this.OnPropertyChanged(nameof (AppDesignerExperienceEnabled));
      }
    }

    [AttributeLogicalName("appointmentricheditorexperience")]
    public bool? AppointmentRichEditorExperience
    {
      get => this.GetAttributeValue<bool?>("appointmentricheditorexperience");
      set
      {
        this.OnPropertyChanging(nameof (AppointmentRichEditorExperience));
        this.SetAttributeValue("appointmentricheditorexperience", (object) value);
        this.OnPropertyChanged(nameof (AppointmentRichEditorExperience));
      }
    }

    [AttributeLogicalName("auditretentionperiod")]
    public int? AuditRetentionPeriod
    {
      get => this.GetAttributeValue<int?>("auditretentionperiod");
      set
      {
        this.OnPropertyChanging(nameof (AuditRetentionPeriod));
        this.SetAttributeValue("auditretentionperiod", (object) value);
        this.OnPropertyChanged(nameof (AuditRetentionPeriod));
      }
    }

    [AttributeLogicalName("autoapplydefaultoncasecreate")]
    public bool? AutoApplyDefaultonCaseCreate
    {
      get => this.GetAttributeValue<bool?>("autoapplydefaultoncasecreate");
      set
      {
        this.OnPropertyChanging(nameof (AutoApplyDefaultonCaseCreate));
        this.SetAttributeValue("autoapplydefaultoncasecreate", (object) value);
        this.OnPropertyChanged(nameof (AutoApplyDefaultonCaseCreate));
      }
    }

    [AttributeLogicalName("autoapplydefaultoncaseupdate")]
    public bool? AutoApplyDefaultonCaseUpdate
    {
      get => this.GetAttributeValue<bool?>("autoapplydefaultoncaseupdate");
      set
      {
        this.OnPropertyChanging(nameof (AutoApplyDefaultonCaseUpdate));
        this.SetAttributeValue("autoapplydefaultoncaseupdate", (object) value);
        this.OnPropertyChanged(nameof (AutoApplyDefaultonCaseUpdate));
      }
    }

    [AttributeLogicalName("autoapplysla")]
    public bool? AutoApplySLA
    {
      get => this.GetAttributeValue<bool?>("autoapplysla");
      set
      {
        this.OnPropertyChanging(nameof (AutoApplySLA));
        this.SetAttributeValue("autoapplysla", (object) value);
        this.OnPropertyChanged(nameof (AutoApplySLA));
      }
    }

    [AttributeLogicalName("azureschedulerjobcollectionname")]
    public string AzureSchedulerJobCollectionName
    {
      get => this.GetAttributeValue<string>("azureschedulerjobcollectionname");
      set
      {
        this.OnPropertyChanging(nameof (AzureSchedulerJobCollectionName));
        this.SetAttributeValue("azureschedulerjobcollectionname", (object) value);
        this.OnPropertyChanged(nameof (AzureSchedulerJobCollectionName));
      }
    }

    [AttributeLogicalName("basecurrencyid")]
    public EntityReference BaseCurrencyId
    {
      get => this.GetAttributeValue<EntityReference>("basecurrencyid");
      set
      {
        this.OnPropertyChanging(nameof (BaseCurrencyId));
        this.SetAttributeValue("basecurrencyid", (object) value);
        this.OnPropertyChanged(nameof (BaseCurrencyId));
      }
    }

    [AttributeLogicalName("basecurrencyprecision")]
    public int? BaseCurrencyPrecision => this.GetAttributeValue<int?>("basecurrencyprecision");

    [AttributeLogicalName("basecurrencysymbol")]
    public string BaseCurrencySymbol => this.GetAttributeValue<string>("basecurrencysymbol");

    [AttributeLogicalName("bingmapsapikey")]
    public string BingMapsApiKey
    {
      get => this.GetAttributeValue<string>("bingmapsapikey");
      set
      {
        this.OnPropertyChanging(nameof (BingMapsApiKey));
        this.SetAttributeValue("bingmapsapikey", (object) value);
        this.OnPropertyChanged(nameof (BingMapsApiKey));
      }
    }

    [AttributeLogicalName("blockedattachments")]
    public string BlockedAttachments
    {
      get => this.GetAttributeValue<string>("blockedattachments");
      set
      {
        this.OnPropertyChanging(nameof (BlockedAttachments));
        this.SetAttributeValue("blockedattachments", (object) value);
        this.OnPropertyChanged(nameof (BlockedAttachments));
      }
    }

    [AttributeLogicalName("bounddashboarddefaultcardexpanded")]
    public bool? BoundDashboardDefaultCardExpanded
    {
      get => this.GetAttributeValue<bool?>("bounddashboarddefaultcardexpanded");
      set
      {
        this.OnPropertyChanging(nameof (BoundDashboardDefaultCardExpanded));
        this.SetAttributeValue("bounddashboarddefaultcardexpanded", (object) value);
        this.OnPropertyChanged(nameof (BoundDashboardDefaultCardExpanded));
      }
    }

    [AttributeLogicalName("bulkoperationprefix")]
    public string BulkOperationPrefix
    {
      get => this.GetAttributeValue<string>("bulkoperationprefix");
      set
      {
        this.OnPropertyChanging(nameof (BulkOperationPrefix));
        this.SetAttributeValue("bulkoperationprefix", (object) value);
        this.OnPropertyChanged(nameof (BulkOperationPrefix));
      }
    }

    [AttributeLogicalName("businesscardoptions")]
    public string BusinessCardOptions
    {
      get => this.GetAttributeValue<string>("businesscardoptions");
      set
      {
        this.OnPropertyChanging(nameof (BusinessCardOptions));
        this.SetAttributeValue("businesscardoptions", (object) value);
        this.OnPropertyChanged(nameof (BusinessCardOptions));
      }
    }

    [AttributeLogicalName("businessclosurecalendarid")]
    public Guid? BusinessClosureCalendarId
    {
      get => this.GetAttributeValue<Guid?>("businessclosurecalendarid");
      set
      {
        this.OnPropertyChanging(nameof (BusinessClosureCalendarId));
        this.SetAttributeValue("businessclosurecalendarid", (object) value);
        this.OnPropertyChanged(nameof (BusinessClosureCalendarId));
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

    [AttributeLogicalName("campaignprefix")]
    public string CampaignPrefix
    {
      get => this.GetAttributeValue<string>("campaignprefix");
      set
      {
        this.OnPropertyChanging(nameof (CampaignPrefix));
        this.SetAttributeValue("campaignprefix", (object) value);
        this.OnPropertyChanged(nameof (CampaignPrefix));
      }
    }

    [AttributeLogicalName("cascadestatusupdate")]
    public bool? CascadeStatusUpdate
    {
      get => this.GetAttributeValue<bool?>("cascadestatusupdate");
      set
      {
        this.OnPropertyChanging(nameof (CascadeStatusUpdate));
        this.SetAttributeValue("cascadestatusupdate", (object) value);
        this.OnPropertyChanged(nameof (CascadeStatusUpdate));
      }
    }

    [AttributeLogicalName("caseprefix")]
    public string CasePrefix
    {
      get => this.GetAttributeValue<string>("caseprefix");
      set
      {
        this.OnPropertyChanging(nameof (CasePrefix));
        this.SetAttributeValue("caseprefix", (object) value);
        this.OnPropertyChanged(nameof (CasePrefix));
      }
    }

    [AttributeLogicalName("categoryprefix")]
    public string CategoryPrefix
    {
      get => this.GetAttributeValue<string>("categoryprefix");
      set
      {
        this.OnPropertyChanging(nameof (CategoryPrefix));
        this.SetAttributeValue("categoryprefix", (object) value);
        this.OnPropertyChanged(nameof (CategoryPrefix));
      }
    }

    [AttributeLogicalName("clientfeatureset")]
    public string ClientFeatureSet
    {
      get => this.GetAttributeValue<string>("clientfeatureset");
      set
      {
        this.OnPropertyChanging(nameof (ClientFeatureSet));
        this.SetAttributeValue("clientfeatureset", (object) value);
        this.OnPropertyChanged(nameof (ClientFeatureSet));
      }
    }

    [AttributeLogicalName("contentsecuritypolicyconfiguration")]
    public string ContentSecurityPolicyConfiguration
    {
      get => this.GetAttributeValue<string>("contentsecuritypolicyconfiguration");
      set
      {
        this.OnPropertyChanging(nameof (ContentSecurityPolicyConfiguration));
        this.SetAttributeValue("contentsecuritypolicyconfiguration", (object) value);
        this.OnPropertyChanged(nameof (ContentSecurityPolicyConfiguration));
      }
    }

    [AttributeLogicalName("contractprefix")]
    public string ContractPrefix
    {
      get => this.GetAttributeValue<string>("contractprefix");
      set
      {
        this.OnPropertyChanging(nameof (ContractPrefix));
        this.SetAttributeValue("contractprefix", (object) value);
        this.OnPropertyChanged(nameof (ContractPrefix));
      }
    }

    [AttributeLogicalName("cortanaproactiveexperienceenabled")]
    public bool? CortanaProactiveExperienceEnabled
    {
      get => this.GetAttributeValue<bool?>("cortanaproactiveexperienceenabled");
      set
      {
        this.OnPropertyChanging(nameof (CortanaProactiveExperienceEnabled));
        this.SetAttributeValue("cortanaproactiveexperienceenabled", (object) value);
        this.OnPropertyChanged(nameof (CortanaProactiveExperienceEnabled));
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
    }

    [AttributeLogicalName("createproductswithoutparentinactivestate")]
    public bool? CreateProductsWithoutParentInActiveState
    {
      get => this.GetAttributeValue<bool?>("createproductswithoutparentinactivestate");
      set
      {
        this.OnPropertyChanging(nameof (CreateProductsWithoutParentInActiveState));
        this.SetAttributeValue("createproductswithoutparentinactivestate", (object) value);
        this.OnPropertyChanged(nameof (CreateProductsWithoutParentInActiveState));
      }
    }

    [AttributeLogicalName("currencydecimalprecision")]
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

    [AttributeLogicalName("currencydisplayoption")]
    public OptionSetValue CurrencyDisplayOption
    {
      get => this.GetAttributeValue<OptionSetValue>("currencydisplayoption");
      set
      {
        this.OnPropertyChanging(nameof (CurrencyDisplayOption));
        this.SetAttributeValue("currencydisplayoption", (object) value);
        this.OnPropertyChanged(nameof (CurrencyDisplayOption));
      }
    }

    [AttributeLogicalName("currencyformatcode")]
    public OptionSetValue CurrencyFormatCode
    {
      get => this.GetAttributeValue<OptionSetValue>("currencyformatcode");
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

    [AttributeLogicalName("currentbulkoperationnumber")]
    [Obsolete]
    public int? CurrentBulkOperationNumber
    {
      get => this.GetAttributeValue<int?>("currentbulkoperationnumber");
      set
      {
        this.OnPropertyChanging(nameof (CurrentBulkOperationNumber));
        this.SetAttributeValue("currentbulkoperationnumber", (object) value);
        this.OnPropertyChanged(nameof (CurrentBulkOperationNumber));
      }
    }

    [AttributeLogicalName("currentcampaignnumber")]
    [Obsolete]
    public int? CurrentCampaignNumber
    {
      get => this.GetAttributeValue<int?>("currentcampaignnumber");
      set
      {
        this.OnPropertyChanging(nameof (CurrentCampaignNumber));
        this.SetAttributeValue("currentcampaignnumber", (object) value);
        this.OnPropertyChanged(nameof (CurrentCampaignNumber));
      }
    }

    [AttributeLogicalName("currentcasenumber")]
    [Obsolete]
    public int? CurrentCaseNumber
    {
      get => this.GetAttributeValue<int?>("currentcasenumber");
      set
      {
        this.OnPropertyChanging(nameof (CurrentCaseNumber));
        this.SetAttributeValue("currentcasenumber", (object) value);
        this.OnPropertyChanged(nameof (CurrentCaseNumber));
      }
    }

    [AttributeLogicalName("currentcategorynumber")]
    [Obsolete]
    public int? CurrentCategoryNumber
    {
      get => this.GetAttributeValue<int?>("currentcategorynumber");
      set
      {
        this.OnPropertyChanging(nameof (CurrentCategoryNumber));
        this.SetAttributeValue("currentcategorynumber", (object) value);
        this.OnPropertyChanged(nameof (CurrentCategoryNumber));
      }
    }

    [AttributeLogicalName("currentcontractnumber")]
    [Obsolete]
    public int? CurrentContractNumber
    {
      get => this.GetAttributeValue<int?>("currentcontractnumber");
      set
      {
        this.OnPropertyChanging(nameof (CurrentContractNumber));
        this.SetAttributeValue("currentcontractnumber", (object) value);
        this.OnPropertyChanged(nameof (CurrentContractNumber));
      }
    }

    [AttributeLogicalName("currentimportsequencenumber")]
    public int? CurrentImportSequenceNumber
    {
      get => this.GetAttributeValue<int?>("currentimportsequencenumber");
    }

    [AttributeLogicalName("currentinvoicenumber")]
    [Obsolete]
    public int? CurrentInvoiceNumber
    {
      get => this.GetAttributeValue<int?>("currentinvoicenumber");
      set
      {
        this.OnPropertyChanging(nameof (CurrentInvoiceNumber));
        this.SetAttributeValue("currentinvoicenumber", (object) value);
        this.OnPropertyChanged(nameof (CurrentInvoiceNumber));
      }
    }

    [AttributeLogicalName("currentkanumber")]
    [Obsolete]
    public int? CurrentKaNumber
    {
      get => this.GetAttributeValue<int?>("currentkanumber");
      set
      {
        this.OnPropertyChanging(nameof (CurrentKaNumber));
        this.SetAttributeValue("currentkanumber", (object) value);
        this.OnPropertyChanged(nameof (CurrentKaNumber));
      }
    }

    [AttributeLogicalName("currentkbnumber")]
    [Obsolete]
    public int? CurrentKbNumber
    {
      get => this.GetAttributeValue<int?>("currentkbnumber");
      set
      {
        this.OnPropertyChanging(nameof (CurrentKbNumber));
        this.SetAttributeValue("currentkbnumber", (object) value);
        this.OnPropertyChanged(nameof (CurrentKbNumber));
      }
    }

    [AttributeLogicalName("currentordernumber")]
    [Obsolete]
    public int? CurrentOrderNumber
    {
      get => this.GetAttributeValue<int?>("currentordernumber");
      set
      {
        this.OnPropertyChanging(nameof (CurrentOrderNumber));
        this.SetAttributeValue("currentordernumber", (object) value);
        this.OnPropertyChanged(nameof (CurrentOrderNumber));
      }
    }

    [AttributeLogicalName("currentparsedtablenumber")]
    public int? CurrentParsedTableNumber
    {
      get => this.GetAttributeValue<int?>("currentparsedtablenumber");
    }

    [AttributeLogicalName("currentquotenumber")]
    [Obsolete]
    public int? CurrentQuoteNumber
    {
      get => this.GetAttributeValue<int?>("currentquotenumber");
      set
      {
        this.OnPropertyChanging(nameof (CurrentQuoteNumber));
        this.SetAttributeValue("currentquotenumber", (object) value);
        this.OnPropertyChanged(nameof (CurrentQuoteNumber));
      }
    }

    [AttributeLogicalName("dateformatcode")]
    public OptionSetValue DateFormatCode
    {
      get => this.GetAttributeValue<OptionSetValue>("dateformatcode");
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

    [AttributeLogicalName("dayssincerecordlastmodifiedmaxvalue")]
    public int? DaysSinceRecordLastModifiedMaxValue
    {
      get => this.GetAttributeValue<int?>("dayssincerecordlastmodifiedmaxvalue");
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

    [AttributeLogicalName("defaultcrmcustomname")]
    public string DefaultCrmCustomName
    {
      get => this.GetAttributeValue<string>("defaultcrmcustomname");
      set
      {
        this.OnPropertyChanging(nameof (DefaultCrmCustomName));
        this.SetAttributeValue("defaultcrmcustomname", (object) value);
        this.OnPropertyChanged(nameof (DefaultCrmCustomName));
      }
    }

    [AttributeLogicalName("defaultemailserverprofileid")]
    public EntityReference DefaultEmailServerProfileId
    {
      get => this.GetAttributeValue<EntityReference>("defaultemailserverprofileid");
      set
      {
        this.OnPropertyChanging(nameof (DefaultEmailServerProfileId));
        this.SetAttributeValue("defaultemailserverprofileid", (object) value);
        this.OnPropertyChanged(nameof (DefaultEmailServerProfileId));
      }
    }

    [AttributeLogicalName("defaultemailsettings")]
    public string DefaultEmailSettings
    {
      get => this.GetAttributeValue<string>("defaultemailsettings");
      set
      {
        this.OnPropertyChanging(nameof (DefaultEmailSettings));
        this.SetAttributeValue("defaultemailsettings", (object) value);
        this.OnPropertyChanged(nameof (DefaultEmailSettings));
      }
    }

    [AttributeLogicalName("defaultmobileofflineprofileid")]
    public EntityReference DefaultMobileOfflineProfileId
    {
      get => this.GetAttributeValue<EntityReference>("defaultmobileofflineprofileid");
      set
      {
        this.OnPropertyChanging(nameof (DefaultMobileOfflineProfileId));
        this.SetAttributeValue("defaultmobileofflineprofileid", (object) value);
        this.OnPropertyChanged(nameof (DefaultMobileOfflineProfileId));
      }
    }

    [AttributeLogicalName("defaultrecurrenceendrangetype")]
    public OptionSetValue DefaultRecurrenceEndRangeType
    {
      get => this.GetAttributeValue<OptionSetValue>("defaultrecurrenceendrangetype");
      set
      {
        this.OnPropertyChanging(nameof (DefaultRecurrenceEndRangeType));
        this.SetAttributeValue("defaultrecurrenceendrangetype", (object) value);
        this.OnPropertyChanged(nameof (DefaultRecurrenceEndRangeType));
      }
    }

    [AttributeLogicalName("defaultthemedata")]
    public string DefaultThemeData
    {
      get => this.GetAttributeValue<string>("defaultthemedata");
      set
      {
        this.OnPropertyChanging(nameof (DefaultThemeData));
        this.SetAttributeValue("defaultthemedata", (object) value);
        this.OnPropertyChanged(nameof (DefaultThemeData));
      }
    }

    [AttributeLogicalName("delegatedadminuserid")]
    public Guid? DelegatedAdminUserId
    {
      get => this.GetAttributeValue<Guid?>("delegatedadminuserid");
      set
      {
        this.OnPropertyChanging(nameof (DelegatedAdminUserId));
        this.SetAttributeValue("delegatedadminuserid", (object) value);
        this.OnPropertyChanged(nameof (DelegatedAdminUserId));
      }
    }

    [AttributeLogicalName("disabledreason")]
    public string DisabledReason => this.GetAttributeValue<string>("disabledreason");

    [AttributeLogicalName("disablesocialcare")]
    public bool? DisableSocialCare
    {
      get => this.GetAttributeValue<bool?>("disablesocialcare");
      set
      {
        this.OnPropertyChanging(nameof (DisableSocialCare));
        this.SetAttributeValue("disablesocialcare", (object) value);
        this.OnPropertyChanged(nameof (DisableSocialCare));
      }
    }

    [AttributeLogicalName("discountcalculationmethod")]
    public OptionSetValue DiscountCalculationMethod
    {
      get => this.GetAttributeValue<OptionSetValue>("discountcalculationmethod");
      set
      {
        this.OnPropertyChanging(nameof (DiscountCalculationMethod));
        this.SetAttributeValue("discountcalculationmethod", (object) value);
        this.OnPropertyChanged(nameof (DiscountCalculationMethod));
      }
    }

    [AttributeLogicalName("displaynavigationtour")]
    public bool? DisplayNavigationTour
    {
      get => this.GetAttributeValue<bool?>("displaynavigationtour");
      set
      {
        this.OnPropertyChanging(nameof (DisplayNavigationTour));
        this.SetAttributeValue("displaynavigationtour", (object) value);
        this.OnPropertyChanged(nameof (DisplayNavigationTour));
      }
    }

    [AttributeLogicalName("emailconnectionchannel")]
    public OptionSetValue EmailConnectionChannel
    {
      get => this.GetAttributeValue<OptionSetValue>("emailconnectionchannel");
      set
      {
        this.OnPropertyChanging(nameof (EmailConnectionChannel));
        this.SetAttributeValue("emailconnectionchannel", (object) value);
        this.OnPropertyChanged(nameof (EmailConnectionChannel));
      }
    }

    [AttributeLogicalName("emailcorrelationenabled")]
    public bool? EmailCorrelationEnabled
    {
      get => this.GetAttributeValue<bool?>("emailcorrelationenabled");
      set
      {
        this.OnPropertyChanging(nameof (EmailCorrelationEnabled));
        this.SetAttributeValue("emailcorrelationenabled", (object) value);
        this.OnPropertyChanged(nameof (EmailCorrelationEnabled));
      }
    }

    [AttributeLogicalName("emailsendpollingperiod")]
    public int? EmailSendPollingPeriod
    {
      get => this.GetAttributeValue<int?>("emailsendpollingperiod");
      set
      {
        this.OnPropertyChanging(nameof (EmailSendPollingPeriod));
        this.SetAttributeValue("emailsendpollingperiod", (object) value);
        this.OnPropertyChanged(nameof (EmailSendPollingPeriod));
      }
    }

    [AttributeLogicalName("enablebingmapsintegration")]
    public bool? EnableBingMapsIntegration
    {
      get => this.GetAttributeValue<bool?>("enablebingmapsintegration");
      set
      {
        this.OnPropertyChanging(nameof (EnableBingMapsIntegration));
        this.SetAttributeValue("enablebingmapsintegration", (object) value);
        this.OnPropertyChanged(nameof (EnableBingMapsIntegration));
      }
    }

    [AttributeLogicalName("enableimmersiveskypeintegration")]
    public bool? EnableImmersiveSkypeIntegration
    {
      get => this.GetAttributeValue<bool?>("enableimmersiveskypeintegration");
      set
      {
        this.OnPropertyChanging(nameof (EnableImmersiveSkypeIntegration));
        this.SetAttributeValue("enableimmersiveskypeintegration", (object) value);
        this.OnPropertyChanged(nameof (EnableImmersiveSkypeIntegration));
      }
    }

    [AttributeLogicalName("enablelivepersonacarduci")]
    public bool? EnableLivePersonaCardUCI
    {
      get => this.GetAttributeValue<bool?>("enablelivepersonacarduci");
      set
      {
        this.OnPropertyChanging(nameof (EnableLivePersonaCardUCI));
        this.SetAttributeValue("enablelivepersonacarduci", (object) value);
        this.OnPropertyChanged(nameof (EnableLivePersonaCardUCI));
      }
    }

    [AttributeLogicalName("enablelivepersoncardintegrationinoffice")]
    public bool? EnableLivePersonCardIntegrationInOffice
    {
      get => this.GetAttributeValue<bool?>("enablelivepersoncardintegrationinoffice");
      set
      {
        this.OnPropertyChanging(nameof (EnableLivePersonCardIntegrationInOffice));
        this.SetAttributeValue("enablelivepersoncardintegrationinoffice", (object) value);
        this.OnPropertyChanged(nameof (EnableLivePersonCardIntegrationInOffice));
      }
    }

    [AttributeLogicalName("enablelpauthoring")]
    public bool? EnableLPAuthoring
    {
      get => this.GetAttributeValue<bool?>("enablelpauthoring");
      set
      {
        this.OnPropertyChanging(nameof (EnableLPAuthoring));
        this.SetAttributeValue("enablelpauthoring", (object) value);
        this.OnPropertyChanged(nameof (EnableLPAuthoring));
      }
    }

    [AttributeLogicalName("enablemicrosoftflowintegration")]
    public bool? EnableMicrosoftFlowIntegration
    {
      get => this.GetAttributeValue<bool?>("enablemicrosoftflowintegration");
      set
      {
        this.OnPropertyChanging(nameof (EnableMicrosoftFlowIntegration));
        this.SetAttributeValue("enablemicrosoftflowintegration", (object) value);
        this.OnPropertyChanged(nameof (EnableMicrosoftFlowIntegration));
      }
    }

    [AttributeLogicalName("enablepricingoncreate")]
    public bool? EnablePricingOnCreate
    {
      get => this.GetAttributeValue<bool?>("enablepricingoncreate");
      set
      {
        this.OnPropertyChanging(nameof (EnablePricingOnCreate));
        this.SetAttributeValue("enablepricingoncreate", (object) value);
        this.OnPropertyChanged(nameof (EnablePricingOnCreate));
      }
    }

    [AttributeLogicalName("enablesmartmatching")]
    public bool? EnableSmartMatching
    {
      get => this.GetAttributeValue<bool?>("enablesmartmatching");
      set
      {
        this.OnPropertyChanging(nameof (EnableSmartMatching));
        this.SetAttributeValue("enablesmartmatching", (object) value);
        this.OnPropertyChanged(nameof (EnableSmartMatching));
      }
    }

    [AttributeLogicalName("enableunifiedinterfaceshellrefresh")]
    public bool? EnableUnifiedInterfaceShellRefresh
    {
      get => this.GetAttributeValue<bool?>("enableunifiedinterfaceshellrefresh");
      set
      {
        this.OnPropertyChanging(nameof (EnableUnifiedInterfaceShellRefresh));
        this.SetAttributeValue("enableunifiedinterfaceshellrefresh", (object) value);
        this.OnPropertyChanged(nameof (EnableUnifiedInterfaceShellRefresh));
      }
    }

    [AttributeLogicalName("enforcereadonlyplugins")]
    public bool? EnforceReadOnlyPlugins
    {
      get => this.GetAttributeValue<bool?>("enforcereadonlyplugins");
      set
      {
        this.OnPropertyChanging(nameof (EnforceReadOnlyPlugins));
        this.SetAttributeValue("enforcereadonlyplugins", (object) value);
        this.OnPropertyChanged(nameof (EnforceReadOnlyPlugins));
      }
    }

    [AttributeLogicalName("entityimage")]
    public byte[] EntityImage
    {
      get => this.GetAttributeValue<byte[]>("entityimage");
      set
      {
        this.OnPropertyChanging(nameof (EntityImage));
        this.SetAttributeValue("entityimage", (object) value);
        this.OnPropertyChanged(nameof (EntityImage));
      }
    }

    [AttributeLogicalName("entityimage_timestamp")]
    public long? EntityImage_Timestamp => this.GetAttributeValue<long?>("entityimage_timestamp");

    [AttributeLogicalName("entityimage_url")]
    public string EntityImage_URL => this.GetAttributeValue<string>("entityimage_url");

    [AttributeLogicalName("entityimageid")]
    public Guid? EntityImageId => this.GetAttributeValue<Guid?>("entityimageid");

    [AttributeLogicalName("expirechangetrackingindays")]
    public int? ExpireChangeTrackingInDays
    {
      get => this.GetAttributeValue<int?>("expirechangetrackingindays");
      set
      {
        this.OnPropertyChanging(nameof (ExpireChangeTrackingInDays));
        this.SetAttributeValue("expirechangetrackingindays", (object) value);
        this.OnPropertyChanged(nameof (ExpireChangeTrackingInDays));
      }
    }

    [AttributeLogicalName("expiresubscriptionsindays")]
    public int? ExpireSubscriptionsInDays
    {
      get => this.GetAttributeValue<int?>("expiresubscriptionsindays");
      set
      {
        this.OnPropertyChanging(nameof (ExpireSubscriptionsInDays));
        this.SetAttributeValue("expiresubscriptionsindays", (object) value);
        this.OnPropertyChanged(nameof (ExpireSubscriptionsInDays));
      }
    }

    [AttributeLogicalName("externalbaseurl")]
    public string ExternalBaseUrl
    {
      get => this.GetAttributeValue<string>("externalbaseurl");
      set
      {
        this.OnPropertyChanging(nameof (ExternalBaseUrl));
        this.SetAttributeValue("externalbaseurl", (object) value);
        this.OnPropertyChanged(nameof (ExternalBaseUrl));
      }
    }

    [AttributeLogicalName("externalpartycorrelationkeys")]
    public string ExternalPartyCorrelationKeys
    {
      get => this.GetAttributeValue<string>("externalpartycorrelationkeys");
      set
      {
        this.OnPropertyChanging(nameof (ExternalPartyCorrelationKeys));
        this.SetAttributeValue("externalpartycorrelationkeys", (object) value);
        this.OnPropertyChanged(nameof (ExternalPartyCorrelationKeys));
      }
    }

    [AttributeLogicalName("externalpartyentitysettings")]
    public string ExternalPartyEntitySettings
    {
      get => this.GetAttributeValue<string>("externalpartyentitysettings");
      set
      {
        this.OnPropertyChanging(nameof (ExternalPartyEntitySettings));
        this.SetAttributeValue("externalpartyentitysettings", (object) value);
        this.OnPropertyChanged(nameof (ExternalPartyEntitySettings));
      }
    }

    [AttributeLogicalName("featureset")]
    public string FeatureSet
    {
      get => this.GetAttributeValue<string>("featureset");
      set
      {
        this.OnPropertyChanging(nameof (FeatureSet));
        this.SetAttributeValue("featureset", (object) value);
        this.OnPropertyChanged(nameof (FeatureSet));
      }
    }

    [AttributeLogicalName("fiscalcalendarstart")]
    public DateTime? FiscalCalendarStart
    {
      get => this.GetAttributeValue<DateTime?>("fiscalcalendarstart");
      set
      {
        this.OnPropertyChanging(nameof (FiscalCalendarStart));
        this.SetAttributeValue("fiscalcalendarstart", (object) value);
        this.OnPropertyChanged(nameof (FiscalCalendarStart));
      }
    }

    [AttributeLogicalName("fiscalperiodformat")]
    public string FiscalPeriodFormat
    {
      get => this.GetAttributeValue<string>("fiscalperiodformat");
      set
      {
        this.OnPropertyChanging(nameof (FiscalPeriodFormat));
        this.SetAttributeValue("fiscalperiodformat", (object) value);
        this.OnPropertyChanged(nameof (FiscalPeriodFormat));
      }
    }

    [AttributeLogicalName("fiscalperiodformatperiod")]
    public OptionSetValue FiscalPeriodFormatPeriod
    {
      get => this.GetAttributeValue<OptionSetValue>("fiscalperiodformatperiod");
      set
      {
        this.OnPropertyChanging(nameof (FiscalPeriodFormatPeriod));
        this.SetAttributeValue("fiscalperiodformatperiod", (object) value);
        this.OnPropertyChanged(nameof (FiscalPeriodFormatPeriod));
      }
    }

    [AttributeLogicalName("fiscalperiodtype")]
    public int? FiscalPeriodType
    {
      get => this.GetAttributeValue<int?>("fiscalperiodtype");
      set
      {
        this.OnPropertyChanging(nameof (FiscalPeriodType));
        this.SetAttributeValue("fiscalperiodtype", (object) value);
        this.OnPropertyChanged(nameof (FiscalPeriodType));
      }
    }

    [AttributeLogicalName("fiscalsettingsupdated")]
    [Obsolete]
    public bool? FiscalSettingsUpdated => this.GetAttributeValue<bool?>("fiscalsettingsupdated");

    [AttributeLogicalName("fiscalyeardisplaycode")]
    public int? FiscalYearDisplayCode
    {
      get => this.GetAttributeValue<int?>("fiscalyeardisplaycode");
      set
      {
        this.OnPropertyChanging(nameof (FiscalYearDisplayCode));
        this.SetAttributeValue("fiscalyeardisplaycode", (object) value);
        this.OnPropertyChanged(nameof (FiscalYearDisplayCode));
      }
    }

    [AttributeLogicalName("fiscalyearformat")]
    public string FiscalYearFormat
    {
      get => this.GetAttributeValue<string>("fiscalyearformat");
      set
      {
        this.OnPropertyChanging(nameof (FiscalYearFormat));
        this.SetAttributeValue("fiscalyearformat", (object) value);
        this.OnPropertyChanged(nameof (FiscalYearFormat));
      }
    }

    [AttributeLogicalName("fiscalyearformatprefix")]
    public OptionSetValue FiscalYearFormatPrefix
    {
      get => this.GetAttributeValue<OptionSetValue>("fiscalyearformatprefix");
      set
      {
        this.OnPropertyChanging(nameof (FiscalYearFormatPrefix));
        this.SetAttributeValue("fiscalyearformatprefix", (object) value);
        this.OnPropertyChanged(nameof (FiscalYearFormatPrefix));
      }
    }

    [AttributeLogicalName("fiscalyearformatsuffix")]
    public OptionSetValue FiscalYearFormatSuffix
    {
      get => this.GetAttributeValue<OptionSetValue>("fiscalyearformatsuffix");
      set
      {
        this.OnPropertyChanging(nameof (FiscalYearFormatSuffix));
        this.SetAttributeValue("fiscalyearformatsuffix", (object) value);
        this.OnPropertyChanged(nameof (FiscalYearFormatSuffix));
      }
    }

    [AttributeLogicalName("fiscalyearformatyear")]
    public OptionSetValue FiscalYearFormatYear
    {
      get => this.GetAttributeValue<OptionSetValue>("fiscalyearformatyear");
      set
      {
        this.OnPropertyChanging(nameof (FiscalYearFormatYear));
        this.SetAttributeValue("fiscalyearformatyear", (object) value);
        this.OnPropertyChanged(nameof (FiscalYearFormatYear));
      }
    }

    [AttributeLogicalName("fiscalyearperiodconnect")]
    public string FiscalYearPeriodConnect
    {
      get => this.GetAttributeValue<string>("fiscalyearperiodconnect");
      set
      {
        this.OnPropertyChanging(nameof (FiscalYearPeriodConnect));
        this.SetAttributeValue("fiscalyearperiodconnect", (object) value);
        this.OnPropertyChanged(nameof (FiscalYearPeriodConnect));
      }
    }

    [AttributeLogicalName("fullnameconventioncode")]
    public OptionSetValue FullNameConventionCode
    {
      get => this.GetAttributeValue<OptionSetValue>("fullnameconventioncode");
      set
      {
        this.OnPropertyChanging(nameof (FullNameConventionCode));
        this.SetAttributeValue("fullnameconventioncode", (object) value);
        this.OnPropertyChanged(nameof (FullNameConventionCode));
      }
    }

    [AttributeLogicalName("futureexpansionwindow")]
    public int? FutureExpansionWindow
    {
      get => this.GetAttributeValue<int?>("futureexpansionwindow");
      set
      {
        this.OnPropertyChanging(nameof (FutureExpansionWindow));
        this.SetAttributeValue("futureexpansionwindow", (object) value);
        this.OnPropertyChanged(nameof (FutureExpansionWindow));
      }
    }

    [AttributeLogicalName("generatealertsforerrors")]
    public bool? GenerateAlertsForErrors
    {
      get => this.GetAttributeValue<bool?>("generatealertsforerrors");
      set
      {
        this.OnPropertyChanging(nameof (GenerateAlertsForErrors));
        this.SetAttributeValue("generatealertsforerrors", (object) value);
        this.OnPropertyChanged(nameof (GenerateAlertsForErrors));
      }
    }

    [AttributeLogicalName("generatealertsforinformation")]
    public bool? GenerateAlertsForInformation
    {
      get => this.GetAttributeValue<bool?>("generatealertsforinformation");
      set
      {
        this.OnPropertyChanging(nameof (GenerateAlertsForInformation));
        this.SetAttributeValue("generatealertsforinformation", (object) value);
        this.OnPropertyChanged(nameof (GenerateAlertsForInformation));
      }
    }

    [AttributeLogicalName("generatealertsforwarnings")]
    public bool? GenerateAlertsForWarnings
    {
      get => this.GetAttributeValue<bool?>("generatealertsforwarnings");
      set
      {
        this.OnPropertyChanging(nameof (GenerateAlertsForWarnings));
        this.SetAttributeValue("generatealertsforwarnings", (object) value);
        this.OnPropertyChanged(nameof (GenerateAlertsForWarnings));
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

    [AttributeLogicalName("globalappendurlparametersenabled")]
    public bool? GlobalAppendUrlParametersEnabled
    {
      get => this.GetAttributeValue<bool?>("globalappendurlparametersenabled");
      set
      {
        this.OnPropertyChanging(nameof (GlobalAppendUrlParametersEnabled));
        this.SetAttributeValue("globalappendurlparametersenabled", (object) value);
        this.OnPropertyChanged(nameof (GlobalAppendUrlParametersEnabled));
      }
    }

    [AttributeLogicalName("globalhelpurl")]
    public string GlobalHelpUrl
    {
      get => this.GetAttributeValue<string>("globalhelpurl");
      set
      {
        this.OnPropertyChanging(nameof (GlobalHelpUrl));
        this.SetAttributeValue("globalhelpurl", (object) value);
        this.OnPropertyChanged(nameof (GlobalHelpUrl));
      }
    }

    [AttributeLogicalName("globalhelpurlenabled")]
    public bool? GlobalHelpUrlEnabled
    {
      get => this.GetAttributeValue<bool?>("globalhelpurlenabled");
      set
      {
        this.OnPropertyChanging(nameof (GlobalHelpUrlEnabled));
        this.SetAttributeValue("globalhelpurlenabled", (object) value);
        this.OnPropertyChanged(nameof (GlobalHelpUrlEnabled));
      }
    }

    [AttributeLogicalName("goalrollupexpirytime")]
    public int? GoalRollupExpiryTime
    {
      get => this.GetAttributeValue<int?>("goalrollupexpirytime");
      set
      {
        this.OnPropertyChanging(nameof (GoalRollupExpiryTime));
        this.SetAttributeValue("goalrollupexpirytime", (object) value);
        this.OnPropertyChanged(nameof (GoalRollupExpiryTime));
      }
    }

    [AttributeLogicalName("goalrollupfrequency")]
    public int? GoalRollupFrequency
    {
      get => this.GetAttributeValue<int?>("goalrollupfrequency");
      set
      {
        this.OnPropertyChanging(nameof (GoalRollupFrequency));
        this.SetAttributeValue("goalrollupfrequency", (object) value);
        this.OnPropertyChanged(nameof (GoalRollupFrequency));
      }
    }

    [AttributeLogicalName("grantaccesstonetworkservice")]
    public bool? GrantAccessToNetworkService
    {
      get => this.GetAttributeValue<bool?>("grantaccesstonetworkservice");
      set
      {
        this.OnPropertyChanging(nameof (GrantAccessToNetworkService));
        this.SetAttributeValue("grantaccesstonetworkservice", (object) value);
        this.OnPropertyChanged(nameof (GrantAccessToNetworkService));
      }
    }

    [AttributeLogicalName("hashdeltasubjectcount")]
    public int? HashDeltaSubjectCount
    {
      get => this.GetAttributeValue<int?>("hashdeltasubjectcount");
      set
      {
        this.OnPropertyChanging(nameof (HashDeltaSubjectCount));
        this.SetAttributeValue("hashdeltasubjectcount", (object) value);
        this.OnPropertyChanged(nameof (HashDeltaSubjectCount));
      }
    }

    [AttributeLogicalName("hashfilterkeywords")]
    public string HashFilterKeywords
    {
      get => this.GetAttributeValue<string>("hashfilterkeywords");
      set
      {
        this.OnPropertyChanging(nameof (HashFilterKeywords));
        this.SetAttributeValue("hashfilterkeywords", (object) value);
        this.OnPropertyChanged(nameof (HashFilterKeywords));
      }
    }

    [AttributeLogicalName("hashmaxcount")]
    public int? HashMaxCount
    {
      get => this.GetAttributeValue<int?>("hashmaxcount");
      set
      {
        this.OnPropertyChanging(nameof (HashMaxCount));
        this.SetAttributeValue("hashmaxcount", (object) value);
        this.OnPropertyChanged(nameof (HashMaxCount));
      }
    }

    [AttributeLogicalName("hashminaddresscount")]
    public int? HashMinAddressCount
    {
      get => this.GetAttributeValue<int?>("hashminaddresscount");
      set
      {
        this.OnPropertyChanging(nameof (HashMinAddressCount));
        this.SetAttributeValue("hashminaddresscount", (object) value);
        this.OnPropertyChanged(nameof (HashMinAddressCount));
      }
    }

    [AttributeLogicalName("highcontrastthemedata")]
    public string HighContrastThemeData
    {
      get => this.GetAttributeValue<string>("highcontrastthemedata");
      set
      {
        this.OnPropertyChanging(nameof (HighContrastThemeData));
        this.SetAttributeValue("highcontrastthemedata", (object) value);
        this.OnPropertyChanged(nameof (HighContrastThemeData));
      }
    }

    [AttributeLogicalName("ignoreinternalemail")]
    public bool? IgnoreInternalEmail
    {
      get => this.GetAttributeValue<bool?>("ignoreinternalemail");
      set
      {
        this.OnPropertyChanging(nameof (IgnoreInternalEmail));
        this.SetAttributeValue("ignoreinternalemail", (object) value);
        this.OnPropertyChanged(nameof (IgnoreInternalEmail));
      }
    }

    [AttributeLogicalName("inactivitytimeoutenabled")]
    public bool? InactivityTimeoutEnabled
    {
      get => this.GetAttributeValue<bool?>("inactivitytimeoutenabled");
      set
      {
        this.OnPropertyChanging(nameof (InactivityTimeoutEnabled));
        this.SetAttributeValue("inactivitytimeoutenabled", (object) value);
        this.OnPropertyChanged(nameof (InactivityTimeoutEnabled));
      }
    }

    [AttributeLogicalName("inactivitytimeoutinmins")]
    public int? InactivityTimeoutInMins
    {
      get => this.GetAttributeValue<int?>("inactivitytimeoutinmins");
      set
      {
        this.OnPropertyChanging(nameof (InactivityTimeoutInMins));
        this.SetAttributeValue("inactivitytimeoutinmins", (object) value);
        this.OnPropertyChanged(nameof (InactivityTimeoutInMins));
      }
    }

    [AttributeLogicalName("inactivitytimeoutreminderinmins")]
    public int? InactivityTimeoutReminderInMins
    {
      get => this.GetAttributeValue<int?>("inactivitytimeoutreminderinmins");
      set
      {
        this.OnPropertyChanging(nameof (InactivityTimeoutReminderInMins));
        this.SetAttributeValue("inactivitytimeoutreminderinmins", (object) value);
        this.OnPropertyChanged(nameof (InactivityTimeoutReminderInMins));
      }
    }

    [AttributeLogicalName("incomingemailexchangeemailretrievalbatchsize")]
    public int? IncomingEmailExchangeEmailRetrievalBatchSize
    {
      get => this.GetAttributeValue<int?>("incomingemailexchangeemailretrievalbatchsize");
      set
      {
        this.OnPropertyChanging(nameof (IncomingEmailExchangeEmailRetrievalBatchSize));
        this.SetAttributeValue("incomingemailexchangeemailretrievalbatchsize", (object) value);
        this.OnPropertyChanged(nameof (IncomingEmailExchangeEmailRetrievalBatchSize));
      }
    }

    [AttributeLogicalName("initialversion")]
    public string InitialVersion
    {
      get => this.GetAttributeValue<string>("initialversion");
      set
      {
        this.OnPropertyChanging(nameof (InitialVersion));
        this.SetAttributeValue("initialversion", (object) value);
        this.OnPropertyChanged(nameof (InitialVersion));
      }
    }

    [AttributeLogicalName("integrationuserid")]
    public Guid? IntegrationUserId
    {
      get => this.GetAttributeValue<Guid?>("integrationuserid");
      set
      {
        this.OnPropertyChanging(nameof (IntegrationUserId));
        this.SetAttributeValue("integrationuserid", (object) value);
        this.OnPropertyChanged(nameof (IntegrationUserId));
      }
    }

    [AttributeLogicalName("invoiceprefix")]
    public string InvoicePrefix
    {
      get => this.GetAttributeValue<string>("invoiceprefix");
      set
      {
        this.OnPropertyChanging(nameof (InvoicePrefix));
        this.SetAttributeValue("invoiceprefix", (object) value);
        this.OnPropertyChanged(nameof (InvoicePrefix));
      }
    }

    [AttributeLogicalName("isactioncardenabled")]
    public bool? IsActionCardEnabled
    {
      get => this.GetAttributeValue<bool?>("isactioncardenabled");
      set
      {
        this.OnPropertyChanging(nameof (IsActionCardEnabled));
        this.SetAttributeValue("isactioncardenabled", (object) value);
        this.OnPropertyChanged(nameof (IsActionCardEnabled));
      }
    }

    [AttributeLogicalName("isactionsupportfeatureenabled")]
    public bool? IsActionSupportFeatureEnabled
    {
      get => this.GetAttributeValue<bool?>("isactionsupportfeatureenabled");
      set
      {
        this.OnPropertyChanging(nameof (IsActionSupportFeatureEnabled));
        this.SetAttributeValue("isactionsupportfeatureenabled", (object) value);
        this.OnPropertyChanged(nameof (IsActionSupportFeatureEnabled));
      }
    }

    [AttributeLogicalName("isactivityanalysisenabled")]
    public bool? IsActivityAnalysisEnabled
    {
      get => this.GetAttributeValue<bool?>("isactivityanalysisenabled");
      set
      {
        this.OnPropertyChanging(nameof (IsActivityAnalysisEnabled));
        this.SetAttributeValue("isactivityanalysisenabled", (object) value);
        this.OnPropertyChanged(nameof (IsActivityAnalysisEnabled));
      }
    }

    [AttributeLogicalName("isallmoneydecimal")]
    public bool? IsAllMoneyDecimal => this.GetAttributeValue<bool?>("isallmoneydecimal");

    [AttributeLogicalName("isappmode")]
    public bool? IsAppMode
    {
      get => this.GetAttributeValue<bool?>("isappmode");
      set
      {
        this.OnPropertyChanging(nameof (IsAppMode));
        this.SetAttributeValue("isappmode", (object) value);
        this.OnPropertyChanged(nameof (IsAppMode));
      }
    }

    [AttributeLogicalName("isappointmentattachmentsyncenabled")]
    public bool? IsAppointmentAttachmentSyncEnabled
    {
      get => this.GetAttributeValue<bool?>("isappointmentattachmentsyncenabled");
      set
      {
        this.OnPropertyChanging(nameof (IsAppointmentAttachmentSyncEnabled));
        this.SetAttributeValue("isappointmentattachmentsyncenabled", (object) value);
        this.OnPropertyChanged(nameof (IsAppointmentAttachmentSyncEnabled));
      }
    }

    [AttributeLogicalName("isassignedtaskssyncenabled")]
    public bool? IsAssignedTasksSyncEnabled
    {
      get => this.GetAttributeValue<bool?>("isassignedtaskssyncenabled");
      set
      {
        this.OnPropertyChanging(nameof (IsAssignedTasksSyncEnabled));
        this.SetAttributeValue("isassignedtaskssyncenabled", (object) value);
        this.OnPropertyChanged(nameof (IsAssignedTasksSyncEnabled));
      }
    }

    [AttributeLogicalName("isauditenabled")]
    public bool? IsAuditEnabled
    {
      get => this.GetAttributeValue<bool?>("isauditenabled");
      set
      {
        this.OnPropertyChanging(nameof (IsAuditEnabled));
        this.SetAttributeValue("isauditenabled", (object) value);
        this.OnPropertyChanged(nameof (IsAuditEnabled));
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

    [AttributeLogicalName("isautodatacapturev2enabled")]
    public bool? IsAutoDataCaptureV2Enabled
    {
      get => this.GetAttributeValue<bool?>("isautodatacapturev2enabled");
      set
      {
        this.OnPropertyChanging(nameof (IsAutoDataCaptureV2Enabled));
        this.SetAttributeValue("isautodatacapturev2enabled", (object) value);
        this.OnPropertyChanged(nameof (IsAutoDataCaptureV2Enabled));
      }
    }

    [AttributeLogicalName("isautosaveenabled")]
    public bool? IsAutoSaveEnabled
    {
      get => this.GetAttributeValue<bool?>("isautosaveenabled");
      set
      {
        this.OnPropertyChanging(nameof (IsAutoSaveEnabled));
        this.SetAttributeValue("isautosaveenabled", (object) value);
        this.OnPropertyChanged(nameof (IsAutoSaveEnabled));
      }
    }

    [AttributeLogicalName("isbpfentitycustomizationfeatureenabled")]
    public bool? IsBPFEntityCustomizationFeatureEnabled
    {
      get => this.GetAttributeValue<bool?>("isbpfentitycustomizationfeatureenabled");
      set
      {
        this.OnPropertyChanging(nameof (IsBPFEntityCustomizationFeatureEnabled));
        this.SetAttributeValue("isbpfentitycustomizationfeatureenabled", (object) value);
        this.OnPropertyChanged(nameof (IsBPFEntityCustomizationFeatureEnabled));
      }
    }

    [AttributeLogicalName("isconflictdetectionenabledformobileclient")]
    public bool? IsConflictDetectionEnabledForMobileClient
    {
      get => this.GetAttributeValue<bool?>("isconflictdetectionenabledformobileclient");
      set
      {
        this.OnPropertyChanging(nameof (IsConflictDetectionEnabledForMobileClient));
        this.SetAttributeValue("isconflictdetectionenabledformobileclient", (object) value);
        this.OnPropertyChanged(nameof (IsConflictDetectionEnabledForMobileClient));
      }
    }

    [AttributeLogicalName("iscontactmailingaddresssyncenabled")]
    public bool? IsContactMailingAddressSyncEnabled
    {
      get => this.GetAttributeValue<bool?>("iscontactmailingaddresssyncenabled");
      set
      {
        this.OnPropertyChanging(nameof (IsContactMailingAddressSyncEnabled));
        this.SetAttributeValue("iscontactmailingaddresssyncenabled", (object) value);
        this.OnPropertyChanged(nameof (IsContactMailingAddressSyncEnabled));
      }
    }

    [AttributeLogicalName("iscontentsecuritypolicyenabled")]
    public bool? IsContentSecurityPolicyEnabled
    {
      get => this.GetAttributeValue<bool?>("iscontentsecuritypolicyenabled");
      set
      {
        this.OnPropertyChanging(nameof (IsContentSecurityPolicyEnabled));
        this.SetAttributeValue("iscontentsecuritypolicyenabled", (object) value);
        this.OnPropertyChanged(nameof (IsContentSecurityPolicyEnabled));
      }
    }

    [AttributeLogicalName("iscontextualemailenabled")]
    public bool? IsContextualEmailEnabled
    {
      get => this.GetAttributeValue<bool?>("iscontextualemailenabled");
      set
      {
        this.OnPropertyChanging(nameof (IsContextualEmailEnabled));
        this.SetAttributeValue("iscontextualemailenabled", (object) value);
        this.OnPropertyChanged(nameof (IsContextualEmailEnabled));
      }
    }

    [AttributeLogicalName("iscontextualhelpenabled")]
    public bool? IsContextualHelpEnabled
    {
      get => this.GetAttributeValue<bool?>("iscontextualhelpenabled");
      set
      {
        this.OnPropertyChanging(nameof (IsContextualHelpEnabled));
        this.SetAttributeValue("iscontextualhelpenabled", (object) value);
        this.OnPropertyChanged(nameof (IsContextualHelpEnabled));
      }
    }

    [AttributeLogicalName("iscustomcontrolsincanvasappsenabled")]
    public bool? IsCustomControlsInCanvasAppsEnabled
    {
      get => this.GetAttributeValue<bool?>("iscustomcontrolsincanvasappsenabled");
      set
      {
        this.OnPropertyChanging(nameof (IsCustomControlsInCanvasAppsEnabled));
        this.SetAttributeValue("iscustomcontrolsincanvasappsenabled", (object) value);
        this.OnPropertyChanged(nameof (IsCustomControlsInCanvasAppsEnabled));
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

    [AttributeLogicalName("isdelegateaccessenabled")]
    public bool? IsDelegateAccessEnabled
    {
      get => this.GetAttributeValue<bool?>("isdelegateaccessenabled");
      set
      {
        this.OnPropertyChanging(nameof (IsDelegateAccessEnabled));
        this.SetAttributeValue("isdelegateaccessenabled", (object) value);
        this.OnPropertyChanged(nameof (IsDelegateAccessEnabled));
      }
    }

    [AttributeLogicalName("isdelveactionhubintegrationenabled")]
    public bool? IsDelveActionHubIntegrationEnabled
    {
      get => this.GetAttributeValue<bool?>("isdelveactionhubintegrationenabled");
      set
      {
        this.OnPropertyChanging(nameof (IsDelveActionHubIntegrationEnabled));
        this.SetAttributeValue("isdelveactionhubintegrationenabled", (object) value);
        this.OnPropertyChanged(nameof (IsDelveActionHubIntegrationEnabled));
      }
    }

    [AttributeLogicalName("isdisabled")]
    public bool? IsDisabled => this.GetAttributeValue<bool?>("isdisabled");

    [AttributeLogicalName("isduplicatedetectionenabled")]
    public bool? IsDuplicateDetectionEnabled
    {
      get => this.GetAttributeValue<bool?>("isduplicatedetectionenabled");
      set
      {
        this.OnPropertyChanging(nameof (IsDuplicateDetectionEnabled));
        this.SetAttributeValue("isduplicatedetectionenabled", (object) value);
        this.OnPropertyChanged(nameof (IsDuplicateDetectionEnabled));
      }
    }

    [AttributeLogicalName("isduplicatedetectionenabledforimport")]
    public bool? IsDuplicateDetectionEnabledForImport
    {
      get => this.GetAttributeValue<bool?>("isduplicatedetectionenabledforimport");
      set
      {
        this.OnPropertyChanging(nameof (IsDuplicateDetectionEnabledForImport));
        this.SetAttributeValue("isduplicatedetectionenabledforimport", (object) value);
        this.OnPropertyChanged(nameof (IsDuplicateDetectionEnabledForImport));
      }
    }

    [AttributeLogicalName("isduplicatedetectionenabledforofflinesync")]
    public bool? IsDuplicateDetectionEnabledForOfflineSync
    {
      get => this.GetAttributeValue<bool?>("isduplicatedetectionenabledforofflinesync");
      set
      {
        this.OnPropertyChanging(nameof (IsDuplicateDetectionEnabledForOfflineSync));
        this.SetAttributeValue("isduplicatedetectionenabledforofflinesync", (object) value);
        this.OnPropertyChanged(nameof (IsDuplicateDetectionEnabledForOfflineSync));
      }
    }

    [AttributeLogicalName("isduplicatedetectionenabledforonlinecreateupdate")]
    public bool? IsDuplicateDetectionEnabledForOnlineCreateUpdate
    {
      get => this.GetAttributeValue<bool?>("isduplicatedetectionenabledforonlinecreateupdate");
      set
      {
        this.OnPropertyChanging(nameof (IsDuplicateDetectionEnabledForOnlineCreateUpdate));
        this.SetAttributeValue("isduplicatedetectionenabledforonlinecreateupdate", (object) value);
        this.OnPropertyChanged(nameof (IsDuplicateDetectionEnabledForOnlineCreateUpdate));
      }
    }

    [AttributeLogicalName("isemailmonitoringallowed")]
    public bool? IsEmailMonitoringAllowed
    {
      get => this.GetAttributeValue<bool?>("isemailmonitoringallowed");
      set
      {
        this.OnPropertyChanging(nameof (IsEmailMonitoringAllowed));
        this.SetAttributeValue("isemailmonitoringallowed", (object) value);
        this.OnPropertyChanged(nameof (IsEmailMonitoringAllowed));
      }
    }

    [AttributeLogicalName("isemailserverprofilecontentfilteringenabled")]
    public bool? IsEmailServerProfileContentFilteringEnabled
    {
      get => this.GetAttributeValue<bool?>("isemailserverprofilecontentfilteringenabled");
      set
      {
        this.OnPropertyChanging(nameof (IsEmailServerProfileContentFilteringEnabled));
        this.SetAttributeValue("isemailserverprofilecontentfilteringenabled", (object) value);
        this.OnPropertyChanged(nameof (IsEmailServerProfileContentFilteringEnabled));
      }
    }

    [AttributeLogicalName("isenabledforallroles")]
    public bool? IsEnabledForAllRoles
    {
      get => this.GetAttributeValue<bool?>("isenabledforallroles");
      set
      {
        this.OnPropertyChanging(nameof (IsEnabledForAllRoles));
        this.SetAttributeValue("isenabledforallroles", (object) value);
        this.OnPropertyChanged(nameof (IsEnabledForAllRoles));
      }
    }

    [AttributeLogicalName("isexternalfilestorageenabled")]
    public bool? IsExternalFileStorageEnabled
    {
      get => this.GetAttributeValue<bool?>("isexternalfilestorageenabled");
      set
      {
        this.OnPropertyChanging(nameof (IsExternalFileStorageEnabled));
        this.SetAttributeValue("isexternalfilestorageenabled", (object) value);
        this.OnPropertyChanged(nameof (IsExternalFileStorageEnabled));
      }
    }

    [AttributeLogicalName("isexternalsearchindexenabled")]
    public bool? IsExternalSearchIndexEnabled
    {
      get => this.GetAttributeValue<bool?>("isexternalsearchindexenabled");
      set
      {
        this.OnPropertyChanging(nameof (IsExternalSearchIndexEnabled));
        this.SetAttributeValue("isexternalsearchindexenabled", (object) value);
        this.OnPropertyChanged(nameof (IsExternalSearchIndexEnabled));
      }
    }

    [AttributeLogicalName("isfiscalperiodmonthbased")]
    public bool? IsFiscalPeriodMonthBased
    {
      get => this.GetAttributeValue<bool?>("isfiscalperiodmonthbased");
      set
      {
        this.OnPropertyChanging(nameof (IsFiscalPeriodMonthBased));
        this.SetAttributeValue("isfiscalperiodmonthbased", (object) value);
        this.OnPropertyChanged(nameof (IsFiscalPeriodMonthBased));
      }
    }

    [AttributeLogicalName("isfolderautocreatedonsp")]
    public bool? IsFolderAutoCreatedonSP
    {
      get => this.GetAttributeValue<bool?>("isfolderautocreatedonsp");
      set
      {
        this.OnPropertyChanging(nameof (IsFolderAutoCreatedonSP));
        this.SetAttributeValue("isfolderautocreatedonsp", (object) value);
        this.OnPropertyChanged(nameof (IsFolderAutoCreatedonSP));
      }
    }

    [AttributeLogicalName("isfolderbasedtrackingenabled")]
    public bool? IsFolderBasedTrackingEnabled
    {
      get => this.GetAttributeValue<bool?>("isfolderbasedtrackingenabled");
      set
      {
        this.OnPropertyChanging(nameof (IsFolderBasedTrackingEnabled));
        this.SetAttributeValue("isfolderbasedtrackingenabled", (object) value);
        this.OnPropertyChanged(nameof (IsFolderBasedTrackingEnabled));
      }
    }

    [AttributeLogicalName("isfulltextsearchenabled")]
    public bool? IsFullTextSearchEnabled
    {
      get => this.GetAttributeValue<bool?>("isfulltextsearchenabled");
      set
      {
        this.OnPropertyChanging(nameof (IsFullTextSearchEnabled));
        this.SetAttributeValue("isfulltextsearchenabled", (object) value);
        this.OnPropertyChanged(nameof (IsFullTextSearchEnabled));
      }
    }

    [AttributeLogicalName("ishierarchicalsecuritymodelenabled")]
    public bool? IsHierarchicalSecurityModelEnabled
    {
      get => this.GetAttributeValue<bool?>("ishierarchicalsecuritymodelenabled");
      set
      {
        this.OnPropertyChanging(nameof (IsHierarchicalSecurityModelEnabled));
        this.SetAttributeValue("ishierarchicalsecuritymodelenabled", (object) value);
        this.OnPropertyChanged(nameof (IsHierarchicalSecurityModelEnabled));
      }
    }

    [AttributeLogicalName("isluisenabledford365bot")]
    public bool? IsLUISEnabledforD365Bot
    {
      get => this.GetAttributeValue<bool?>("isluisenabledford365bot");
      set
      {
        this.OnPropertyChanging(nameof (IsLUISEnabledforD365Bot));
        this.SetAttributeValue("isluisenabledford365bot", (object) value);
        this.OnPropertyChanged(nameof (IsLUISEnabledforD365Bot));
      }
    }

    [AttributeLogicalName("ismailboxforcedunlockingenabled")]
    public bool? IsMailboxForcedUnlockingEnabled
    {
      get => this.GetAttributeValue<bool?>("ismailboxforcedunlockingenabled");
      set
      {
        this.OnPropertyChanging(nameof (IsMailboxForcedUnlockingEnabled));
        this.SetAttributeValue("ismailboxforcedunlockingenabled", (object) value);
        this.OnPropertyChanged(nameof (IsMailboxForcedUnlockingEnabled));
      }
    }

    [AttributeLogicalName("ismailboxinactivebackoffenabled")]
    public bool? IsMailboxInactiveBackoffEnabled
    {
      get => this.GetAttributeValue<bool?>("ismailboxinactivebackoffenabled");
      set
      {
        this.OnPropertyChanging(nameof (IsMailboxInactiveBackoffEnabled));
        this.SetAttributeValue("ismailboxinactivebackoffenabled", (object) value);
        this.OnPropertyChanged(nameof (IsMailboxInactiveBackoffEnabled));
      }
    }

    [AttributeLogicalName("ismanualsalesforecastingenabled")]
    public bool? IsManualSalesForecastingEnabled
    {
      get => this.GetAttributeValue<bool?>("ismanualsalesforecastingenabled");
      set
      {
        this.OnPropertyChanging(nameof (IsManualSalesForecastingEnabled));
        this.SetAttributeValue("ismanualsalesforecastingenabled", (object) value);
        this.OnPropertyChanged(nameof (IsManualSalesForecastingEnabled));
      }
    }

    [AttributeLogicalName("ismobileclientondemandsyncenabled")]
    public bool? IsMobileClientOnDemandSyncEnabled
    {
      get => this.GetAttributeValue<bool?>("ismobileclientondemandsyncenabled");
      set
      {
        this.OnPropertyChanging(nameof (IsMobileClientOnDemandSyncEnabled));
        this.SetAttributeValue("ismobileclientondemandsyncenabled", (object) value);
        this.OnPropertyChanged(nameof (IsMobileClientOnDemandSyncEnabled));
      }
    }

    [AttributeLogicalName("ismobileofflineenabled")]
    public bool? IsMobileOfflineEnabled
    {
      get => this.GetAttributeValue<bool?>("ismobileofflineenabled");
      set
      {
        this.OnPropertyChanging(nameof (IsMobileOfflineEnabled));
        this.SetAttributeValue("ismobileofflineenabled", (object) value);
        this.OnPropertyChanged(nameof (IsMobileOfflineEnabled));
      }
    }

    [AttributeLogicalName("ismsteamscollaborationenabled")]
    public bool? IsMSTeamsCollaborationEnabled
    {
      get => this.GetAttributeValue<bool?>("ismsteamscollaborationenabled");
      set
      {
        this.OnPropertyChanging(nameof (IsMSTeamsCollaborationEnabled));
        this.SetAttributeValue("ismsteamscollaborationenabled", (object) value);
        this.OnPropertyChanged(nameof (IsMSTeamsCollaborationEnabled));
      }
    }

    [AttributeLogicalName("ismsteamsenabled")]
    public bool? IsMSTeamsEnabled
    {
      get => this.GetAttributeValue<bool?>("ismsteamsenabled");
      set
      {
        this.OnPropertyChanging(nameof (IsMSTeamsEnabled));
        this.SetAttributeValue("ismsteamsenabled", (object) value);
        this.OnPropertyChanged(nameof (IsMSTeamsEnabled));
      }
    }

    [AttributeLogicalName("ismsteamssettingchangedbyuser")]
    public bool? IsMSTeamsSettingChangedByUser
    {
      get => this.GetAttributeValue<bool?>("ismsteamssettingchangedbyuser");
      set
      {
        this.OnPropertyChanging(nameof (IsMSTeamsSettingChangedByUser));
        this.SetAttributeValue("ismsteamssettingchangedbyuser", (object) value);
        this.OnPropertyChanged(nameof (IsMSTeamsSettingChangedByUser));
      }
    }

    [AttributeLogicalName("ismsteamsusersyncenabled")]
    public bool? IsMSTeamsUserSyncEnabled
    {
      get => this.GetAttributeValue<bool?>("ismsteamsusersyncenabled");
      set
      {
        this.OnPropertyChanging(nameof (IsMSTeamsUserSyncEnabled));
        this.SetAttributeValue("ismsteamsusersyncenabled", (object) value);
        this.OnPropertyChanged(nameof (IsMSTeamsUserSyncEnabled));
      }
    }

    [AttributeLogicalName("isnewaddproductexperienceenabled")]
    public bool? IsNewAddProductExperienceEnabled
    {
      get => this.GetAttributeValue<bool?>("isnewaddproductexperienceenabled");
      set
      {
        this.OnPropertyChanging(nameof (IsNewAddProductExperienceEnabled));
        this.SetAttributeValue("isnewaddproductexperienceenabled", (object) value);
        this.OnPropertyChanged(nameof (IsNewAddProductExperienceEnabled));
      }
    }

    [AttributeLogicalName("isnotesanalysisenabled")]
    public bool? IsNotesAnalysisEnabled
    {
      get => this.GetAttributeValue<bool?>("isnotesanalysisenabled");
      set
      {
        this.OnPropertyChanging(nameof (IsNotesAnalysisEnabled));
        this.SetAttributeValue("isnotesanalysisenabled", (object) value);
        this.OnPropertyChanged(nameof (IsNotesAnalysisEnabled));
      }
    }

    [AttributeLogicalName("isofficegraphenabled")]
    public bool? IsOfficeGraphEnabled
    {
      get => this.GetAttributeValue<bool?>("isofficegraphenabled");
      set
      {
        this.OnPropertyChanging(nameof (IsOfficeGraphEnabled));
        this.SetAttributeValue("isofficegraphenabled", (object) value);
        this.OnPropertyChanged(nameof (IsOfficeGraphEnabled));
      }
    }

    [AttributeLogicalName("isonedriveenabled")]
    public bool? IsOneDriveEnabled
    {
      get => this.GetAttributeValue<bool?>("isonedriveenabled");
      set
      {
        this.OnPropertyChanging(nameof (IsOneDriveEnabled));
        this.SetAttributeValue("isonedriveenabled", (object) value);
        this.OnPropertyChanged(nameof (IsOneDriveEnabled));
      }
    }

    [AttributeLogicalName("ispaienabled")]
    public bool? IsPAIEnabled
    {
      get => this.GetAttributeValue<bool?>("ispaienabled");
      set
      {
        this.OnPropertyChanging(nameof (IsPAIEnabled));
        this.SetAttributeValue("ispaienabled", (object) value);
        this.OnPropertyChanged(nameof (IsPAIEnabled));
      }
    }

    [AttributeLogicalName("ispdfgenerationenabled")]
    public string IsPDFGenerationEnabled
    {
      get => this.GetAttributeValue<string>("ispdfgenerationenabled");
      set
      {
        this.OnPropertyChanging(nameof (IsPDFGenerationEnabled));
        this.SetAttributeValue("ispdfgenerationenabled", (object) value);
        this.OnPropertyChanged(nameof (IsPDFGenerationEnabled));
      }
    }

    [AttributeLogicalName("isplaybookenabled")]
    public bool? IsPlaybookEnabled
    {
      get => this.GetAttributeValue<bool?>("isplaybookenabled");
      set
      {
        this.OnPropertyChanging(nameof (IsPlaybookEnabled));
        this.SetAttributeValue("isplaybookenabled", (object) value);
        this.OnPropertyChanged(nameof (IsPlaybookEnabled));
      }
    }

    [AttributeLogicalName("ispresenceenabled")]
    public bool? IsPresenceEnabled
    {
      get => this.GetAttributeValue<bool?>("ispresenceenabled");
      set
      {
        this.OnPropertyChanging(nameof (IsPresenceEnabled));
        this.SetAttributeValue("ispresenceenabled", (object) value);
        this.OnPropertyChanged(nameof (IsPresenceEnabled));
      }
    }

    [AttributeLogicalName("ispreviewenabledforactioncard")]
    public bool? IsPreviewEnabledForActionCard
    {
      get => this.GetAttributeValue<bool?>("ispreviewenabledforactioncard");
      set
      {
        this.OnPropertyChanging(nameof (IsPreviewEnabledForActionCard));
        this.SetAttributeValue("ispreviewenabledforactioncard", (object) value);
        this.OnPropertyChanged(nameof (IsPreviewEnabledForActionCard));
      }
    }

    [AttributeLogicalName("ispreviewforautocaptureenabled")]
    public bool? IsPreviewForAutoCaptureEnabled
    {
      get => this.GetAttributeValue<bool?>("ispreviewforautocaptureenabled");
      set
      {
        this.OnPropertyChanging(nameof (IsPreviewForAutoCaptureEnabled));
        this.SetAttributeValue("ispreviewforautocaptureenabled", (object) value);
        this.OnPropertyChanged(nameof (IsPreviewForAutoCaptureEnabled));
      }
    }

    [AttributeLogicalName("ispreviewforemailmonitoringallowed")]
    public bool? IsPreviewForEmailMonitoringAllowed
    {
      get => this.GetAttributeValue<bool?>("ispreviewforemailmonitoringallowed");
      set
      {
        this.OnPropertyChanging(nameof (IsPreviewForEmailMonitoringAllowed));
        this.SetAttributeValue("ispreviewforemailmonitoringallowed", (object) value);
        this.OnPropertyChanged(nameof (IsPreviewForEmailMonitoringAllowed));
      }
    }

    [AttributeLogicalName("ispricelistmandatory")]
    public bool? IsPriceListMandatory
    {
      get => this.GetAttributeValue<bool?>("ispricelistmandatory");
      set
      {
        this.OnPropertyChanging(nameof (IsPriceListMandatory));
        this.SetAttributeValue("ispricelistmandatory", (object) value);
        this.OnPropertyChanged(nameof (IsPriceListMandatory));
      }
    }

    [AttributeLogicalName("isquickcreateenabledforopportunityclose")]
    public bool? IsQuickCreateEnabledForOpportunityClose
    {
      get => this.GetAttributeValue<bool?>("isquickcreateenabledforopportunityclose");
      set
      {
        this.OnPropertyChanging(nameof (IsQuickCreateEnabledForOpportunityClose));
        this.SetAttributeValue("isquickcreateenabledforopportunityclose", (object) value);
        this.OnPropertyChanged(nameof (IsQuickCreateEnabledForOpportunityClose));
      }
    }

    [AttributeLogicalName("isreadauditenabled")]
    public bool? IsReadAuditEnabled
    {
      get => this.GetAttributeValue<bool?>("isreadauditenabled");
      set
      {
        this.OnPropertyChanging(nameof (IsReadAuditEnabled));
        this.SetAttributeValue("isreadauditenabled", (object) value);
        this.OnPropertyChanged(nameof (IsReadAuditEnabled));
      }
    }

    [AttributeLogicalName("isrelationshipinsightsenabled")]
    public bool? IsRelationshipInsightsEnabled
    {
      get => this.GetAttributeValue<bool?>("isrelationshipinsightsenabled");
      set
      {
        this.OnPropertyChanging(nameof (IsRelationshipInsightsEnabled));
        this.SetAttributeValue("isrelationshipinsightsenabled", (object) value);
        this.OnPropertyChanged(nameof (IsRelationshipInsightsEnabled));
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

    [AttributeLogicalName("isrichtextnotesenabled")]
    public bool? IsRichTextNotesEnabled
    {
      get => this.GetAttributeValue<bool?>("isrichtextnotesenabled");
      set
      {
        this.OnPropertyChanging(nameof (IsRichTextNotesEnabled));
        this.SetAttributeValue("isrichtextnotesenabled", (object) value);
        this.OnPropertyChanged(nameof (IsRichTextNotesEnabled));
      }
    }

    [AttributeLogicalName("issalesassistantenabled")]
    public bool? IsSalesAssistantEnabled
    {
      get => this.GetAttributeValue<bool?>("issalesassistantenabled");
      set
      {
        this.OnPropertyChanging(nameof (IsSalesAssistantEnabled));
        this.SetAttributeValue("issalesassistantenabled", (object) value);
        this.OnPropertyChanged(nameof (IsSalesAssistantEnabled));
      }
    }

    [AttributeLogicalName("issopintegrationenabled")]
    public bool? IsSOPIntegrationEnabled
    {
      get => this.GetAttributeValue<bool?>("issopintegrationenabled");
      set
      {
        this.OnPropertyChanging(nameof (IsSOPIntegrationEnabled));
        this.SetAttributeValue("issopintegrationenabled", (object) value);
        this.OnPropertyChanged(nameof (IsSOPIntegrationEnabled));
      }
    }

    [AttributeLogicalName("istextwrapenabled")]
    public bool? IsTextWrapEnabled
    {
      get => this.GetAttributeValue<bool?>("istextwrapenabled");
      set
      {
        this.OnPropertyChanging(nameof (IsTextWrapEnabled));
        this.SetAttributeValue("istextwrapenabled", (object) value);
        this.OnPropertyChanged(nameof (IsTextWrapEnabled));
      }
    }

    [AttributeLogicalName("isuseraccessauditenabled")]
    public bool? IsUserAccessAuditEnabled
    {
      get => this.GetAttributeValue<bool?>("isuseraccessauditenabled");
      set
      {
        this.OnPropertyChanging(nameof (IsUserAccessAuditEnabled));
        this.SetAttributeValue("isuseraccessauditenabled", (object) value);
        this.OnPropertyChanged(nameof (IsUserAccessAuditEnabled));
      }
    }

    [AttributeLogicalName("isvintegrationcode")]
    [Obsolete]
    public OptionSetValue ISVIntegrationCode
    {
      get => this.GetAttributeValue<OptionSetValue>("isvintegrationcode");
      set
      {
        this.OnPropertyChanging(nameof (ISVIntegrationCode));
        this.SetAttributeValue("isvintegrationcode", (object) value);
        this.OnPropertyChanged(nameof (ISVIntegrationCode));
      }
    }

    [AttributeLogicalName("kaprefix")]
    public string KaPrefix
    {
      get => this.GetAttributeValue<string>("kaprefix");
      set
      {
        this.OnPropertyChanging(nameof (KaPrefix));
        this.SetAttributeValue("kaprefix", (object) value);
        this.OnPropertyChanged(nameof (KaPrefix));
      }
    }

    [AttributeLogicalName("kbprefix")]
    public string KbPrefix
    {
      get => this.GetAttributeValue<string>("kbprefix");
      set
      {
        this.OnPropertyChanging(nameof (KbPrefix));
        this.SetAttributeValue("kbprefix", (object) value);
        this.OnPropertyChanged(nameof (KbPrefix));
      }
    }

    [AttributeLogicalName("kmsettings")]
    public string KMSettings
    {
      get => this.GetAttributeValue<string>("kmsettings");
      set
      {
        this.OnPropertyChanging(nameof (KMSettings));
        this.SetAttributeValue("kmsettings", (object) value);
        this.OnPropertyChanged(nameof (KMSettings));
      }
    }

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

    [AttributeLogicalName("mailboxintermittentissueminrange")]
    public int? MailboxIntermittentIssueMinRange
    {
      get => this.GetAttributeValue<int?>("mailboxintermittentissueminrange");
      set
      {
        this.OnPropertyChanging(nameof (MailboxIntermittentIssueMinRange));
        this.SetAttributeValue("mailboxintermittentissueminrange", (object) value);
        this.OnPropertyChanged(nameof (MailboxIntermittentIssueMinRange));
      }
    }

    [AttributeLogicalName("mailboxpermanentissueminrange")]
    public int? MailboxPermanentIssueMinRange
    {
      get => this.GetAttributeValue<int?>("mailboxpermanentissueminrange");
      set
      {
        this.OnPropertyChanging(nameof (MailboxPermanentIssueMinRange));
        this.SetAttributeValue("mailboxpermanentissueminrange", (object) value);
        this.OnPropertyChanged(nameof (MailboxPermanentIssueMinRange));
      }
    }

    [AttributeLogicalName("maxactionstepsinbpf")]
    public int? MaxActionStepsInBPF
    {
      get => this.GetAttributeValue<int?>("maxactionstepsinbpf");
      set
      {
        this.OnPropertyChanging(nameof (MaxActionStepsInBPF));
        this.SetAttributeValue("maxactionstepsinbpf", (object) value);
        this.OnPropertyChanged(nameof (MaxActionStepsInBPF));
      }
    }

    [AttributeLogicalName("maxappointmentdurationdays")]
    public int? MaxAppointmentDurationDays
    {
      get => this.GetAttributeValue<int?>("maxappointmentdurationdays");
      set
      {
        this.OnPropertyChanging(nameof (MaxAppointmentDurationDays));
        this.SetAttributeValue("maxappointmentdurationdays", (object) value);
        this.OnPropertyChanged(nameof (MaxAppointmentDurationDays));
      }
    }

    [AttributeLogicalName("maxconditionsformobileofflinefilters")]
    public int? MaxConditionsForMobileOfflineFilters
    {
      get => this.GetAttributeValue<int?>("maxconditionsformobileofflinefilters");
      set
      {
        this.OnPropertyChanging(nameof (MaxConditionsForMobileOfflineFilters));
        this.SetAttributeValue("maxconditionsformobileofflinefilters", (object) value);
        this.OnPropertyChanged(nameof (MaxConditionsForMobileOfflineFilters));
      }
    }

    [AttributeLogicalName("maxdepthforhierarchicalsecuritymodel")]
    public int? MaxDepthForHierarchicalSecurityModel
    {
      get => this.GetAttributeValue<int?>("maxdepthforhierarchicalsecuritymodel");
      set
      {
        this.OnPropertyChanging(nameof (MaxDepthForHierarchicalSecurityModel));
        this.SetAttributeValue("maxdepthforhierarchicalsecuritymodel", (object) value);
        this.OnPropertyChanged(nameof (MaxDepthForHierarchicalSecurityModel));
      }
    }

    [AttributeLogicalName("maxfolderbasedtrackingmappings")]
    public int? MaxFolderBasedTrackingMappings
    {
      get => this.GetAttributeValue<int?>("maxfolderbasedtrackingmappings");
      set
      {
        this.OnPropertyChanging(nameof (MaxFolderBasedTrackingMappings));
        this.SetAttributeValue("maxfolderbasedtrackingmappings", (object) value);
        this.OnPropertyChanged(nameof (MaxFolderBasedTrackingMappings));
      }
    }

    [AttributeLogicalName("maximumactivebusinessprocessflowsallowedperentity")]
    public int? MaximumActiveBusinessProcessFlowsAllowedPerEntity
    {
      get => this.GetAttributeValue<int?>("maximumactivebusinessprocessflowsallowedperentity");
      set
      {
        this.OnPropertyChanging(nameof (MaximumActiveBusinessProcessFlowsAllowedPerEntity));
        this.SetAttributeValue("maximumactivebusinessprocessflowsallowedperentity", (object) value);
        this.OnPropertyChanged(nameof (MaximumActiveBusinessProcessFlowsAllowedPerEntity));
      }
    }

    [AttributeLogicalName("maximumdynamicpropertiesallowed")]
    public int? MaximumDynamicPropertiesAllowed
    {
      get => this.GetAttributeValue<int?>("maximumdynamicpropertiesallowed");
      set
      {
        this.OnPropertyChanging(nameof (MaximumDynamicPropertiesAllowed));
        this.SetAttributeValue("maximumdynamicpropertiesallowed", (object) value);
        this.OnPropertyChanged(nameof (MaximumDynamicPropertiesAllowed));
      }
    }

    [AttributeLogicalName("maximumentitieswithactivesla")]
    public int? MaximumEntitiesWithActiveSLA
    {
      get => this.GetAttributeValue<int?>("maximumentitieswithactivesla");
      set
      {
        this.OnPropertyChanging(nameof (MaximumEntitiesWithActiveSLA));
        this.SetAttributeValue("maximumentitieswithactivesla", (object) value);
        this.OnPropertyChanged(nameof (MaximumEntitiesWithActiveSLA));
      }
    }

    [AttributeLogicalName("maximumslakpiperentitywithactivesla")]
    public int? MaximumSLAKPIPerEntityWithActiveSLA
    {
      get => this.GetAttributeValue<int?>("maximumslakpiperentitywithactivesla");
      set
      {
        this.OnPropertyChanging(nameof (MaximumSLAKPIPerEntityWithActiveSLA));
        this.SetAttributeValue("maximumslakpiperentitywithactivesla", (object) value);
        this.OnPropertyChanged(nameof (MaximumSLAKPIPerEntityWithActiveSLA));
      }
    }

    [AttributeLogicalName("maximumtrackingnumber")]
    public int? MaximumTrackingNumber
    {
      get => this.GetAttributeValue<int?>("maximumtrackingnumber");
      set
      {
        this.OnPropertyChanging(nameof (MaximumTrackingNumber));
        this.SetAttributeValue("maximumtrackingnumber", (object) value);
        this.OnPropertyChanged(nameof (MaximumTrackingNumber));
      }
    }

    [AttributeLogicalName("maxproductsinbundle")]
    public int? MaxProductsInBundle
    {
      get => this.GetAttributeValue<int?>("maxproductsinbundle");
      set
      {
        this.OnPropertyChanging(nameof (MaxProductsInBundle));
        this.SetAttributeValue("maxproductsinbundle", (object) value);
        this.OnPropertyChanged(nameof (MaxProductsInBundle));
      }
    }

    [AttributeLogicalName("maxrecordsforexporttoexcel")]
    public int? MaxRecordsForExportToExcel
    {
      get => this.GetAttributeValue<int?>("maxrecordsforexporttoexcel");
      set
      {
        this.OnPropertyChanging(nameof (MaxRecordsForExportToExcel));
        this.SetAttributeValue("maxrecordsforexporttoexcel", (object) value);
        this.OnPropertyChanged(nameof (MaxRecordsForExportToExcel));
      }
    }

    [AttributeLogicalName("maxrecordsforlookupfilters")]
    public int? MaxRecordsForLookupFilters
    {
      get => this.GetAttributeValue<int?>("maxrecordsforlookupfilters");
      set
      {
        this.OnPropertyChanging(nameof (MaxRecordsForLookupFilters));
        this.SetAttributeValue("maxrecordsforlookupfilters", (object) value);
        this.OnPropertyChanged(nameof (MaxRecordsForLookupFilters));
      }
    }

    [AttributeLogicalName("maxsupportedinternetexplorerversion")]
    public int? MaxSupportedInternetExplorerVersion
    {
      get => this.GetAttributeValue<int?>("maxsupportedinternetexplorerversion");
    }

    [AttributeLogicalName("maxuploadfilesize")]
    public int? MaxUploadFileSize
    {
      get => this.GetAttributeValue<int?>("maxuploadfilesize");
      set
      {
        this.OnPropertyChanging(nameof (MaxUploadFileSize));
        this.SetAttributeValue("maxuploadfilesize", (object) value);
        this.OnPropertyChanged(nameof (MaxUploadFileSize));
      }
    }

    [AttributeLogicalName("maxverboseloggingmailbox")]
    public int? MaxVerboseLoggingMailbox
    {
      get => this.GetAttributeValue<int?>("maxverboseloggingmailbox");
    }

    [AttributeLogicalName("maxverboseloggingsynccycles")]
    public int? MaxVerboseLoggingSyncCycles
    {
      get => this.GetAttributeValue<int?>("maxverboseloggingsynccycles");
    }

    [AttributeLogicalName("microsoftflowenvironment")]
    public string MicrosoftFlowEnvironment
    {
      get => this.GetAttributeValue<string>("microsoftflowenvironment");
      set
      {
        this.OnPropertyChanging(nameof (MicrosoftFlowEnvironment));
        this.SetAttributeValue("microsoftflowenvironment", (object) value);
        this.OnPropertyChanged(nameof (MicrosoftFlowEnvironment));
      }
    }

    [AttributeLogicalName("minaddressbooksyncinterval")]
    public int? MinAddressBookSyncInterval
    {
      get => this.GetAttributeValue<int?>("minaddressbooksyncinterval");
      set
      {
        this.OnPropertyChanging(nameof (MinAddressBookSyncInterval));
        this.SetAttributeValue("minaddressbooksyncinterval", (object) value);
        this.OnPropertyChanged(nameof (MinAddressBookSyncInterval));
      }
    }

    [AttributeLogicalName("minofflinesyncinterval")]
    public int? MinOfflineSyncInterval
    {
      get => this.GetAttributeValue<int?>("minofflinesyncinterval");
      set
      {
        this.OnPropertyChanging(nameof (MinOfflineSyncInterval));
        this.SetAttributeValue("minofflinesyncinterval", (object) value);
        this.OnPropertyChanged(nameof (MinOfflineSyncInterval));
      }
    }

    [AttributeLogicalName("minoutlooksyncinterval")]
    public int? MinOutlookSyncInterval
    {
      get => this.GetAttributeValue<int?>("minoutlooksyncinterval");
      set
      {
        this.OnPropertyChanging(nameof (MinOutlookSyncInterval));
        this.SetAttributeValue("minoutlooksyncinterval", (object) value);
        this.OnPropertyChanged(nameof (MinOutlookSyncInterval));
      }
    }

    [AttributeLogicalName("mobileofflineminlicenseprod")]
    public int? MobileOfflineMinLicenseProd
    {
      get => this.GetAttributeValue<int?>("mobileofflineminlicenseprod");
    }

    [AttributeLogicalName("mobileofflineminlicensetrial")]
    public int? MobileOfflineMinLicenseTrial
    {
      get => this.GetAttributeValue<int?>("mobileofflineminlicensetrial");
    }

    [AttributeLogicalName("mobileofflinesyncinterval")]
    public int? MobileOfflineSyncInterval
    {
      get => this.GetAttributeValue<int?>("mobileofflinesyncinterval");
      set
      {
        this.OnPropertyChanging(nameof (MobileOfflineSyncInterval));
        this.SetAttributeValue("mobileofflinesyncinterval", (object) value);
        this.OnPropertyChanged(nameof (MobileOfflineSyncInterval));
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
    public OptionSetValue NegativeFormatCode
    {
      get => this.GetAttributeValue<OptionSetValue>("negativeformatcode");
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

    [AttributeLogicalName("notifymailboxownerofemailserverlevelalerts")]
    public bool? NotifyMailboxOwnerOfEmailServerLevelAlerts
    {
      get => this.GetAttributeValue<bool?>("notifymailboxownerofemailserverlevelalerts");
      set
      {
        this.OnPropertyChanging(nameof (NotifyMailboxOwnerOfEmailServerLevelAlerts));
        this.SetAttributeValue("notifymailboxownerofemailserverlevelalerts", (object) value);
        this.OnPropertyChanged(nameof (NotifyMailboxOwnerOfEmailServerLevelAlerts));
      }
    }

    [AttributeLogicalName("numberformat")]
    public string NumberFormat
    {
      get => this.GetAttributeValue<string>("numberformat");
      set
      {
        this.OnPropertyChanging(nameof (NumberFormat));
        this.SetAttributeValue("numberformat", (object) value);
        this.OnPropertyChanged(nameof (NumberFormat));
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

    [AttributeLogicalName("officeappsautodeploymentenabled")]
    public bool? OfficeAppsAutoDeploymentEnabled
    {
      get => this.GetAttributeValue<bool?>("officeappsautodeploymentenabled");
      set
      {
        this.OnPropertyChanging(nameof (OfficeAppsAutoDeploymentEnabled));
        this.SetAttributeValue("officeappsautodeploymentenabled", (object) value);
        this.OnPropertyChanged(nameof (OfficeAppsAutoDeploymentEnabled));
      }
    }

    [AttributeLogicalName("officegraphdelveurl")]
    public string OfficeGraphDelveUrl
    {
      get => this.GetAttributeValue<string>("officegraphdelveurl");
      set
      {
        this.OnPropertyChanging(nameof (OfficeGraphDelveUrl));
        this.SetAttributeValue("officegraphdelveurl", (object) value);
        this.OnPropertyChanged(nameof (OfficeGraphDelveUrl));
      }
    }

    [AttributeLogicalName("oobpricecalculationenabled")]
    public bool? OOBPriceCalculationEnabled
    {
      get => this.GetAttributeValue<bool?>("oobpricecalculationenabled");
      set
      {
        this.OnPropertyChanging(nameof (OOBPriceCalculationEnabled));
        this.SetAttributeValue("oobpricecalculationenabled", (object) value);
        this.OnPropertyChanged(nameof (OOBPriceCalculationEnabled));
      }
    }

    [AttributeLogicalName("orderprefix")]
    public string OrderPrefix
    {
      get => this.GetAttributeValue<string>("orderprefix");
      set
      {
        this.OnPropertyChanging(nameof (OrderPrefix));
        this.SetAttributeValue("orderprefix", (object) value);
        this.OnPropertyChanged(nameof (OrderPrefix));
      }
    }

    [AttributeLogicalName("organizationid")]
    public Guid? OrganizationId => this.GetAttributeValue<Guid?>("organizationid");

    [AttributeLogicalName("organizationid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => base.Id = value;
    }

    [AttributeLogicalName("organizationstate")]
    public OptionSetValue OrganizationState
    {
      get => this.GetAttributeValue<OptionSetValue>("organizationstate");
    }

    [AttributeLogicalName("orgdborgsettings")]
    public string OrgDbOrgSettings
    {
      get => this.GetAttributeValue<string>("orgdborgsettings");
      set
      {
        this.OnPropertyChanging(nameof (OrgDbOrgSettings));
        this.SetAttributeValue("orgdborgsettings", (object) value);
        this.OnPropertyChanged(nameof (OrgDbOrgSettings));
      }
    }

    [AttributeLogicalName("orginsightsenabled")]
    public bool? OrgInsightsEnabled
    {
      get => this.GetAttributeValue<bool?>("orginsightsenabled");
      set
      {
        this.OnPropertyChanging(nameof (OrgInsightsEnabled));
        this.SetAttributeValue("orginsightsenabled", (object) value);
        this.OnPropertyChanged(nameof (OrgInsightsEnabled));
      }
    }

    [AttributeLogicalName("paipreviewscenarioenabled")]
    public bool? PaiPreviewScenarioEnabled
    {
      get => this.GetAttributeValue<bool?>("paipreviewscenarioenabled");
      set
      {
        this.OnPropertyChanging(nameof (PaiPreviewScenarioEnabled));
        this.SetAttributeValue("paipreviewscenarioenabled", (object) value);
        this.OnPropertyChanged(nameof (PaiPreviewScenarioEnabled));
      }
    }

    [AttributeLogicalName("parsedtablecolumnprefix")]
    public string ParsedTableColumnPrefix
    {
      get => this.GetAttributeValue<string>("parsedtablecolumnprefix");
    }

    [AttributeLogicalName("parsedtableprefix")]
    public string ParsedTablePrefix => this.GetAttributeValue<string>("parsedtableprefix");

    [AttributeLogicalName("pastexpansionwindow")]
    public int? PastExpansionWindow
    {
      get => this.GetAttributeValue<int?>("pastexpansionwindow");
      set
      {
        this.OnPropertyChanging(nameof (PastExpansionWindow));
        this.SetAttributeValue("pastexpansionwindow", (object) value);
        this.OnPropertyChanged(nameof (PastExpansionWindow));
      }
    }

    [AttributeLogicalName("picture")]
    public string Picture
    {
      get => this.GetAttributeValue<string>("picture");
      set
      {
        this.OnPropertyChanging(nameof (Picture));
        this.SetAttributeValue("picture", (object) value);
        this.OnPropertyChanged(nameof (Picture));
      }
    }

    [AttributeLogicalName("pinpointlanguagecode")]
    public int? PinpointLanguageCode
    {
      get => this.GetAttributeValue<int?>("pinpointlanguagecode");
      set
      {
        this.OnPropertyChanging(nameof (PinpointLanguageCode));
        this.SetAttributeValue("pinpointlanguagecode", (object) value);
        this.OnPropertyChanged(nameof (PinpointLanguageCode));
      }
    }

    [AttributeLogicalName("plugintracelogsetting")]
    public OptionSetValue PluginTraceLogSetting
    {
      get => this.GetAttributeValue<OptionSetValue>("plugintracelogsetting");
      set
      {
        this.OnPropertyChanging(nameof (PluginTraceLogSetting));
        this.SetAttributeValue("plugintracelogsetting", (object) value);
        this.OnPropertyChanged(nameof (PluginTraceLogSetting));
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

    [AttributeLogicalName("postmessagewhitelistdomains")]
    public string PostMessageWhitelistDomains
    {
      get => this.GetAttributeValue<string>("postmessagewhitelistdomains");
      set
      {
        this.OnPropertyChanging(nameof (PostMessageWhitelistDomains));
        this.SetAttributeValue("postmessagewhitelistdomains", (object) value);
        this.OnPropertyChanged(nameof (PostMessageWhitelistDomains));
      }
    }

    [AttributeLogicalName("powerbifeatureenabled")]
    public bool? PowerBiFeatureEnabled
    {
      get => this.GetAttributeValue<bool?>("powerbifeatureenabled");
      set
      {
        this.OnPropertyChanging(nameof (PowerBiFeatureEnabled));
        this.SetAttributeValue("powerbifeatureenabled", (object) value);
        this.OnPropertyChanged(nameof (PowerBiFeatureEnabled));
      }
    }

    [AttributeLogicalName("pricingdecimalprecision")]
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

    [AttributeLogicalName("privacystatementurl")]
    public string PrivacyStatementUrl
    {
      get => this.GetAttributeValue<string>("privacystatementurl");
      set
      {
        this.OnPropertyChanging(nameof (PrivacyStatementUrl));
        this.SetAttributeValue("privacystatementurl", (object) value);
        this.OnPropertyChanged(nameof (PrivacyStatementUrl));
      }
    }

    [AttributeLogicalName("privilegeusergroupid")]
    public Guid? PrivilegeUserGroupId
    {
      get => this.GetAttributeValue<Guid?>("privilegeusergroupid");
      set
      {
        this.OnPropertyChanging(nameof (PrivilegeUserGroupId));
        this.SetAttributeValue("privilegeusergroupid", (object) value);
        this.OnPropertyChanged(nameof (PrivilegeUserGroupId));
      }
    }

    [AttributeLogicalName("privreportinggroupid")]
    public Guid? PrivReportingGroupId
    {
      get => this.GetAttributeValue<Guid?>("privreportinggroupid");
      set
      {
        this.OnPropertyChanging(nameof (PrivReportingGroupId));
        this.SetAttributeValue("privreportinggroupid", (object) value);
        this.OnPropertyChanged(nameof (PrivReportingGroupId));
      }
    }

    [AttributeLogicalName("privreportinggroupname")]
    public string PrivReportingGroupName
    {
      get => this.GetAttributeValue<string>("privreportinggroupname");
      set
      {
        this.OnPropertyChanging(nameof (PrivReportingGroupName));
        this.SetAttributeValue("privreportinggroupname", (object) value);
        this.OnPropertyChanged(nameof (PrivReportingGroupName));
      }
    }

    [AttributeLogicalName("productrecommendationsenabled")]
    public bool? ProductRecommendationsEnabled
    {
      get => this.GetAttributeValue<bool?>("productrecommendationsenabled");
      set
      {
        this.OnPropertyChanging(nameof (ProductRecommendationsEnabled));
        this.SetAttributeValue("productrecommendationsenabled", (object) value);
        this.OnPropertyChanged(nameof (ProductRecommendationsEnabled));
      }
    }

    [AttributeLogicalName("qualifyleadadditionaloptions")]
    public string QualifyLeadAdditionalOptions
    {
      get => this.GetAttributeValue<string>("qualifyleadadditionaloptions");
      set
      {
        this.OnPropertyChanging(nameof (QualifyLeadAdditionalOptions));
        this.SetAttributeValue("qualifyleadadditionaloptions", (object) value);
        this.OnPropertyChanged(nameof (QualifyLeadAdditionalOptions));
      }
    }

    [AttributeLogicalName("quickfindrecordlimitenabled")]
    public bool? QuickFindRecordLimitEnabled
    {
      get => this.GetAttributeValue<bool?>("quickfindrecordlimitenabled");
      set
      {
        this.OnPropertyChanging(nameof (QuickFindRecordLimitEnabled));
        this.SetAttributeValue("quickfindrecordlimitenabled", (object) value);
        this.OnPropertyChanged(nameof (QuickFindRecordLimitEnabled));
      }
    }

    [AttributeLogicalName("quoteprefix")]
    public string QuotePrefix
    {
      get => this.GetAttributeValue<string>("quoteprefix");
      set
      {
        this.OnPropertyChanging(nameof (QuotePrefix));
        this.SetAttributeValue("quoteprefix", (object) value);
        this.OnPropertyChanged(nameof (QuotePrefix));
      }
    }

    [AttributeLogicalName("recurrencedefaultnumberofoccurrences")]
    public int? RecurrenceDefaultNumberOfOccurrences
    {
      get => this.GetAttributeValue<int?>("recurrencedefaultnumberofoccurrences");
      set
      {
        this.OnPropertyChanging(nameof (RecurrenceDefaultNumberOfOccurrences));
        this.SetAttributeValue("recurrencedefaultnumberofoccurrences", (object) value);
        this.OnPropertyChanged(nameof (RecurrenceDefaultNumberOfOccurrences));
      }
    }

    [AttributeLogicalName("recurrenceexpansionjobbatchinterval")]
    public int? RecurrenceExpansionJobBatchInterval
    {
      get => this.GetAttributeValue<int?>("recurrenceexpansionjobbatchinterval");
      set
      {
        this.OnPropertyChanging(nameof (RecurrenceExpansionJobBatchInterval));
        this.SetAttributeValue("recurrenceexpansionjobbatchinterval", (object) value);
        this.OnPropertyChanged(nameof (RecurrenceExpansionJobBatchInterval));
      }
    }

    [AttributeLogicalName("recurrenceexpansionjobbatchsize")]
    public int? RecurrenceExpansionJobBatchSize
    {
      get => this.GetAttributeValue<int?>("recurrenceexpansionjobbatchsize");
      set
      {
        this.OnPropertyChanging(nameof (RecurrenceExpansionJobBatchSize));
        this.SetAttributeValue("recurrenceexpansionjobbatchsize", (object) value);
        this.OnPropertyChanged(nameof (RecurrenceExpansionJobBatchSize));
      }
    }

    [AttributeLogicalName("recurrenceexpansionsynchcreatemax")]
    public int? RecurrenceExpansionSynchCreateMax
    {
      get => this.GetAttributeValue<int?>("recurrenceexpansionsynchcreatemax");
      set
      {
        this.OnPropertyChanging(nameof (RecurrenceExpansionSynchCreateMax));
        this.SetAttributeValue("recurrenceexpansionsynchcreatemax", (object) value);
        this.OnPropertyChanged(nameof (RecurrenceExpansionSynchCreateMax));
      }
    }

    [AttributeLogicalName("referencesitemapxml")]
    [Obsolete]
    public string ReferenceSiteMapXml
    {
      get => this.GetAttributeValue<string>("referencesitemapxml");
      set
      {
        this.OnPropertyChanging(nameof (ReferenceSiteMapXml));
        this.SetAttributeValue("referencesitemapxml", (object) value);
        this.OnPropertyChanged(nameof (ReferenceSiteMapXml));
      }
    }

    [AttributeLogicalName("rendersecureiframeforemail")]
    public bool? RenderSecureIFrameForEmail
    {
      get => this.GetAttributeValue<bool?>("rendersecureiframeforemail");
      set
      {
        this.OnPropertyChanging(nameof (RenderSecureIFrameForEmail));
        this.SetAttributeValue("rendersecureiframeforemail", (object) value);
        this.OnPropertyChanged(nameof (RenderSecureIFrameForEmail));
      }
    }

    [AttributeLogicalName("reportinggroupid")]
    public Guid? ReportingGroupId
    {
      get => this.GetAttributeValue<Guid?>("reportinggroupid");
      set
      {
        this.OnPropertyChanging(nameof (ReportingGroupId));
        this.SetAttributeValue("reportinggroupid", (object) value);
        this.OnPropertyChanged(nameof (ReportingGroupId));
      }
    }

    [AttributeLogicalName("reportinggroupname")]
    public string ReportingGroupName
    {
      get => this.GetAttributeValue<string>("reportinggroupname");
      set
      {
        this.OnPropertyChanging(nameof (ReportingGroupName));
        this.SetAttributeValue("reportinggroupname", (object) value);
        this.OnPropertyChanged(nameof (ReportingGroupName));
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

    [AttributeLogicalName("requireapprovalforqueueemail")]
    public bool? RequireApprovalForQueueEmail
    {
      get => this.GetAttributeValue<bool?>("requireapprovalforqueueemail");
      set
      {
        this.OnPropertyChanging(nameof (RequireApprovalForQueueEmail));
        this.SetAttributeValue("requireapprovalforqueueemail", (object) value);
        this.OnPropertyChanged(nameof (RequireApprovalForQueueEmail));
      }
    }

    [AttributeLogicalName("requireapprovalforuseremail")]
    public bool? RequireApprovalForUserEmail
    {
      get => this.GetAttributeValue<bool?>("requireapprovalforuseremail");
      set
      {
        this.OnPropertyChanging(nameof (RequireApprovalForUserEmail));
        this.SetAttributeValue("requireapprovalforuseremail", (object) value);
        this.OnPropertyChanged(nameof (RequireApprovalForUserEmail));
      }
    }

    [AttributeLogicalName("resolvesimilarunresolvedemailaddress")]
    public bool? ResolveSimilarUnresolvedEmailAddress
    {
      get => this.GetAttributeValue<bool?>("resolvesimilarunresolvedemailaddress");
      set
      {
        this.OnPropertyChanging(nameof (ResolveSimilarUnresolvedEmailAddress));
        this.SetAttributeValue("resolvesimilarunresolvedemailaddress", (object) value);
        this.OnPropertyChanged(nameof (ResolveSimilarUnresolvedEmailAddress));
      }
    }

    [AttributeLogicalName("restrictstatusupdate")]
    public bool? RestrictStatusUpdate
    {
      get => this.GetAttributeValue<bool?>("restrictstatusupdate");
      set
      {
        this.OnPropertyChanging(nameof (RestrictStatusUpdate));
        this.SetAttributeValue("restrictstatusupdate", (object) value);
        this.OnPropertyChanged(nameof (RestrictStatusUpdate));
      }
    }

    [AttributeLogicalName("rierrorstatus")]
    public int? RiErrorStatus
    {
      get => this.GetAttributeValue<int?>("rierrorstatus");
      set
      {
        this.OnPropertyChanging(nameof (RiErrorStatus));
        this.SetAttributeValue("rierrorstatus", (object) value);
        this.OnPropertyChanged(nameof (RiErrorStatus));
      }
    }

    [AttributeLogicalName("sampledataimportid")]
    public Guid? SampleDataImportId
    {
      get => this.GetAttributeValue<Guid?>("sampledataimportid");
      set
      {
        this.OnPropertyChanging(nameof (SampleDataImportId));
        this.SetAttributeValue("sampledataimportid", (object) value);
        this.OnPropertyChanged(nameof (SampleDataImportId));
      }
    }

    [AttributeLogicalName("schemanameprefix")]
    public string SchemaNamePrefix
    {
      get => this.GetAttributeValue<string>("schemanameprefix");
      set
      {
        this.OnPropertyChanging(nameof (SchemaNamePrefix));
        this.SetAttributeValue("schemanameprefix", (object) value);
        this.OnPropertyChanged(nameof (SchemaNamePrefix));
      }
    }

    [AttributeLogicalName("sendbulkemailinuci")]
    public bool? SendBulkEmailInUCI
    {
      get => this.GetAttributeValue<bool?>("sendbulkemailinuci");
      set
      {
        this.OnPropertyChanging(nameof (SendBulkEmailInUCI));
        this.SetAttributeValue("sendbulkemailinuci", (object) value);
        this.OnPropertyChanged(nameof (SendBulkEmailInUCI));
      }
    }

    [AttributeLogicalName("servestaticresourcesfromazurecdn")]
    public bool? ServeStaticResourcesFromAzureCDN
    {
      get => this.GetAttributeValue<bool?>("servestaticresourcesfromazurecdn");
      set
      {
        this.OnPropertyChanging(nameof (ServeStaticResourcesFromAzureCDN));
        this.SetAttributeValue("servestaticresourcesfromazurecdn", (object) value);
        this.OnPropertyChanged(nameof (ServeStaticResourcesFromAzureCDN));
      }
    }

    [AttributeLogicalName("sessiontimeoutenabled")]
    public bool? SessionTimeoutEnabled
    {
      get => this.GetAttributeValue<bool?>("sessiontimeoutenabled");
      set
      {
        this.OnPropertyChanging(nameof (SessionTimeoutEnabled));
        this.SetAttributeValue("sessiontimeoutenabled", (object) value);
        this.OnPropertyChanged(nameof (SessionTimeoutEnabled));
      }
    }

    [AttributeLogicalName("sessiontimeoutinmins")]
    public int? SessionTimeoutInMins
    {
      get => this.GetAttributeValue<int?>("sessiontimeoutinmins");
      set
      {
        this.OnPropertyChanging(nameof (SessionTimeoutInMins));
        this.SetAttributeValue("sessiontimeoutinmins", (object) value);
        this.OnPropertyChanged(nameof (SessionTimeoutInMins));
      }
    }

    [AttributeLogicalName("sessiontimeoutreminderinmins")]
    public int? SessionTimeoutReminderInMins
    {
      get => this.GetAttributeValue<int?>("sessiontimeoutreminderinmins");
      set
      {
        this.OnPropertyChanging(nameof (SessionTimeoutReminderInMins));
        this.SetAttributeValue("sessiontimeoutreminderinmins", (object) value);
        this.OnPropertyChanged(nameof (SessionTimeoutReminderInMins));
      }
    }

    [AttributeLogicalName("sharepointdeploymenttype")]
    public OptionSetValue SharePointDeploymentType
    {
      get => this.GetAttributeValue<OptionSetValue>("sharepointdeploymenttype");
      set
      {
        this.OnPropertyChanging(nameof (SharePointDeploymentType));
        this.SetAttributeValue("sharepointdeploymenttype", (object) value);
        this.OnPropertyChanged(nameof (SharePointDeploymentType));
      }
    }

    [AttributeLogicalName("sharetopreviousowneronassign")]
    public bool? ShareToPreviousOwnerOnAssign
    {
      get => this.GetAttributeValue<bool?>("sharetopreviousowneronassign");
      set
      {
        this.OnPropertyChanging(nameof (ShareToPreviousOwnerOnAssign));
        this.SetAttributeValue("sharetopreviousowneronassign", (object) value);
        this.OnPropertyChanged(nameof (ShareToPreviousOwnerOnAssign));
      }
    }

    [AttributeLogicalName("showkbarticledeprecationnotification")]
    public bool? ShowKBArticleDeprecationNotification
    {
      get => this.GetAttributeValue<bool?>("showkbarticledeprecationnotification");
      set
      {
        this.OnPropertyChanging(nameof (ShowKBArticleDeprecationNotification));
        this.SetAttributeValue("showkbarticledeprecationnotification", (object) value);
        this.OnPropertyChanged(nameof (ShowKBArticleDeprecationNotification));
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

    [AttributeLogicalName("signupoutlookdownloadfwlink")]
    public string SignupOutlookDownloadFWLink
    {
      get => this.GetAttributeValue<string>("signupoutlookdownloadfwlink");
      set
      {
        this.OnPropertyChanging(nameof (SignupOutlookDownloadFWLink));
        this.SetAttributeValue("signupoutlookdownloadfwlink", (object) value);
        this.OnPropertyChanged(nameof (SignupOutlookDownloadFWLink));
      }
    }

    [AttributeLogicalName("sitemapxml")]
    [Obsolete]
    public string SiteMapXml
    {
      get => this.GetAttributeValue<string>("sitemapxml");
      set
      {
        this.OnPropertyChanging(nameof (SiteMapXml));
        this.SetAttributeValue("sitemapxml", (object) value);
        this.OnPropertyChanged(nameof (SiteMapXml));
      }
    }

    [AttributeLogicalName("slapausestates")]
    public string SlaPauseStates
    {
      get => this.GetAttributeValue<string>("slapausestates");
      set
      {
        this.OnPropertyChanging(nameof (SlaPauseStates));
        this.SetAttributeValue("slapausestates", (object) value);
        this.OnPropertyChanged(nameof (SlaPauseStates));
      }
    }

    [AttributeLogicalName("socialinsightsenabled")]
    public bool? SocialInsightsEnabled
    {
      get => this.GetAttributeValue<bool?>("socialinsightsenabled");
      set
      {
        this.OnPropertyChanging(nameof (SocialInsightsEnabled));
        this.SetAttributeValue("socialinsightsenabled", (object) value);
        this.OnPropertyChanged(nameof (SocialInsightsEnabled));
      }
    }

    [AttributeLogicalName("socialinsightsinstance")]
    public string SocialInsightsInstance
    {
      get => this.GetAttributeValue<string>("socialinsightsinstance");
      set
      {
        this.OnPropertyChanging(nameof (SocialInsightsInstance));
        this.SetAttributeValue("socialinsightsinstance", (object) value);
        this.OnPropertyChanged(nameof (SocialInsightsInstance));
      }
    }

    [AttributeLogicalName("socialinsightstermsaccepted")]
    public bool? SocialInsightsTermsAccepted
    {
      get => this.GetAttributeValue<bool?>("socialinsightstermsaccepted");
      set
      {
        this.OnPropertyChanging(nameof (SocialInsightsTermsAccepted));
        this.SetAttributeValue("socialinsightstermsaccepted", (object) value);
        this.OnPropertyChanged(nameof (SocialInsightsTermsAccepted));
      }
    }

    [AttributeLogicalName("sortid")]
    public int? SortId
    {
      get => this.GetAttributeValue<int?>("sortid");
      set
      {
        this.OnPropertyChanging(nameof (SortId));
        this.SetAttributeValue("sortid", (object) value);
        this.OnPropertyChanged(nameof (SortId));
      }
    }

    [AttributeLogicalName("sqlaccessgroupid")]
    public Guid? SqlAccessGroupId
    {
      get => this.GetAttributeValue<Guid?>("sqlaccessgroupid");
      set
      {
        this.OnPropertyChanging(nameof (SqlAccessGroupId));
        this.SetAttributeValue("sqlaccessgroupid", (object) value);
        this.OnPropertyChanged(nameof (SqlAccessGroupId));
      }
    }

    [AttributeLogicalName("sqlaccessgroupname")]
    public string SqlAccessGroupName
    {
      get => this.GetAttributeValue<string>("sqlaccessgroupname");
      set
      {
        this.OnPropertyChanging(nameof (SqlAccessGroupName));
        this.SetAttributeValue("sqlaccessgroupname", (object) value);
        this.OnPropertyChanged(nameof (SqlAccessGroupName));
      }
    }

    [AttributeLogicalName("sqmenabled")]
    public bool? SQMEnabled
    {
      get => this.GetAttributeValue<bool?>("sqmenabled");
      set
      {
        this.OnPropertyChanging(nameof (SQMEnabled));
        this.SetAttributeValue("sqmenabled", (object) value);
        this.OnPropertyChanged(nameof (SQMEnabled));
      }
    }

    [AttributeLogicalName("supportuserid")]
    public Guid? SupportUserId
    {
      get => this.GetAttributeValue<Guid?>("supportuserid");
      set
      {
        this.OnPropertyChanging(nameof (SupportUserId));
        this.SetAttributeValue("supportuserid", (object) value);
        this.OnPropertyChanged(nameof (SupportUserId));
      }
    }

    [AttributeLogicalName("suppresssla")]
    public bool? SuppressSLA
    {
      get => this.GetAttributeValue<bool?>("suppresssla");
      set
      {
        this.OnPropertyChanging(nameof (SuppressSLA));
        this.SetAttributeValue("suppresssla", (object) value);
        this.OnPropertyChanged(nameof (SuppressSLA));
      }
    }

    [AttributeLogicalName("syncbulkoperationbatchsize")]
    public int? SyncBulkOperationBatchSize
    {
      get => this.GetAttributeValue<int?>("syncbulkoperationbatchsize");
      set
      {
        this.OnPropertyChanging(nameof (SyncBulkOperationBatchSize));
        this.SetAttributeValue("syncbulkoperationbatchsize", (object) value);
        this.OnPropertyChanged(nameof (SyncBulkOperationBatchSize));
      }
    }

    [AttributeLogicalName("syncbulkoperationmaxlimit")]
    public int? SyncBulkOperationMaxLimit
    {
      get => this.GetAttributeValue<int?>("syncbulkoperationmaxlimit");
      set
      {
        this.OnPropertyChanging(nameof (SyncBulkOperationMaxLimit));
        this.SetAttributeValue("syncbulkoperationmaxlimit", (object) value);
        this.OnPropertyChanged(nameof (SyncBulkOperationMaxLimit));
      }
    }

    [AttributeLogicalName("syncoptinselection")]
    public bool? SyncOptInSelection
    {
      get => this.GetAttributeValue<bool?>("syncoptinselection");
      set
      {
        this.OnPropertyChanging(nameof (SyncOptInSelection));
        this.SetAttributeValue("syncoptinselection", (object) value);
        this.OnPropertyChanged(nameof (SyncOptInSelection));
      }
    }

    [AttributeLogicalName("syncoptinselectionstatus")]
    public OptionSetValue SyncOptInSelectionStatus
    {
      get => this.GetAttributeValue<OptionSetValue>("syncoptinselectionstatus");
      set
      {
        this.OnPropertyChanging(nameof (SyncOptInSelectionStatus));
        this.SetAttributeValue("syncoptinselectionstatus", (object) value);
        this.OnPropertyChanged(nameof (SyncOptInSelectionStatus));
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
        this.OnPropertyChanged(nameof (SystemUserId));
      }
    }

    [AttributeLogicalName("tagmaxaggressivecycles")]
    public int? TagMaxAggressiveCycles
    {
      get => this.GetAttributeValue<int?>("tagmaxaggressivecycles");
      set
      {
        this.OnPropertyChanging(nameof (TagMaxAggressiveCycles));
        this.SetAttributeValue("tagmaxaggressivecycles", (object) value);
        this.OnPropertyChanged(nameof (TagMaxAggressiveCycles));
      }
    }

    [AttributeLogicalName("tagpollingperiod")]
    public int? TagPollingPeriod
    {
      get => this.GetAttributeValue<int?>("tagpollingperiod");
      set
      {
        this.OnPropertyChanging(nameof (TagPollingPeriod));
        this.SetAttributeValue("tagpollingperiod", (object) value);
        this.OnPropertyChanged(nameof (TagPollingPeriod));
      }
    }

    [AttributeLogicalName("taskbasedflowenabled")]
    public bool? TaskBasedFlowEnabled
    {
      get => this.GetAttributeValue<bool?>("taskbasedflowenabled");
      set
      {
        this.OnPropertyChanging(nameof (TaskBasedFlowEnabled));
        this.SetAttributeValue("taskbasedflowenabled", (object) value);
        this.OnPropertyChanged(nameof (TaskBasedFlowEnabled));
      }
    }

    [AttributeLogicalName("textanalyticsenabled")]
    public bool? TextAnalyticsEnabled
    {
      get => this.GetAttributeValue<bool?>("textanalyticsenabled");
      set
      {
        this.OnPropertyChanging(nameof (TextAnalyticsEnabled));
        this.SetAttributeValue("textanalyticsenabled", (object) value);
        this.OnPropertyChanged(nameof (TextAnalyticsEnabled));
      }
    }

    [AttributeLogicalName("timeformatcode")]
    public OptionSetValue TimeFormatCode
    {
      get => this.GetAttributeValue<OptionSetValue>("timeformatcode");
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

    [AttributeLogicalName("tokenexpiry")]
    public int? TokenExpiry
    {
      get => this.GetAttributeValue<int?>("tokenexpiry");
      set
      {
        this.OnPropertyChanging(nameof (TokenExpiry));
        this.SetAttributeValue("tokenexpiry", (object) value);
        this.OnPropertyChanged(nameof (TokenExpiry));
      }
    }

    [AttributeLogicalName("tokenkey")]
    public string TokenKey
    {
      get => this.GetAttributeValue<string>("tokenkey");
      set
      {
        this.OnPropertyChanging(nameof (TokenKey));
        this.SetAttributeValue("tokenkey", (object) value);
        this.OnPropertyChanged(nameof (TokenKey));
      }
    }

    [AttributeLogicalName("tracelogmaximumageindays")]
    public int? TraceLogMaximumAgeInDays
    {
      get => this.GetAttributeValue<int?>("tracelogmaximumageindays");
      set
      {
        this.OnPropertyChanging(nameof (TraceLogMaximumAgeInDays));
        this.SetAttributeValue("tracelogmaximumageindays", (object) value);
        this.OnPropertyChanged(nameof (TraceLogMaximumAgeInDays));
      }
    }

    [AttributeLogicalName("trackingprefix")]
    public string TrackingPrefix
    {
      get => this.GetAttributeValue<string>("trackingprefix");
      set
      {
        this.OnPropertyChanging(nameof (TrackingPrefix));
        this.SetAttributeValue("trackingprefix", (object) value);
        this.OnPropertyChanged(nameof (TrackingPrefix));
      }
    }

    [AttributeLogicalName("trackingtokenidbase")]
    public int? TrackingTokenIdBase
    {
      get => this.GetAttributeValue<int?>("trackingtokenidbase");
      set
      {
        this.OnPropertyChanging(nameof (TrackingTokenIdBase));
        this.SetAttributeValue("trackingtokenidbase", (object) value);
        this.OnPropertyChanged(nameof (TrackingTokenIdBase));
      }
    }

    [AttributeLogicalName("trackingtokeniddigits")]
    public int? TrackingTokenIdDigits
    {
      get => this.GetAttributeValue<int?>("trackingtokeniddigits");
      set
      {
        this.OnPropertyChanging(nameof (TrackingTokenIdDigits));
        this.SetAttributeValue("trackingtokeniddigits", (object) value);
        this.OnPropertyChanged(nameof (TrackingTokenIdDigits));
      }
    }

    [AttributeLogicalName("uniquespecifierlength")]
    public int? UniqueSpecifierLength
    {
      get => this.GetAttributeValue<int?>("uniquespecifierlength");
      set
      {
        this.OnPropertyChanging(nameof (UniqueSpecifierLength));
        this.SetAttributeValue("uniquespecifierlength", (object) value);
        this.OnPropertyChanged(nameof (UniqueSpecifierLength));
      }
    }

    [AttributeLogicalName("unresolveemailaddressifmultiplematch")]
    public bool? UnresolveEmailAddressIfMultipleMatch
    {
      get => this.GetAttributeValue<bool?>("unresolveemailaddressifmultiplematch");
      set
      {
        this.OnPropertyChanging(nameof (UnresolveEmailAddressIfMultipleMatch));
        this.SetAttributeValue("unresolveemailaddressifmultiplematch", (object) value);
        this.OnPropertyChanged(nameof (UnresolveEmailAddressIfMultipleMatch));
      }
    }

    [AttributeLogicalName("useinbuiltrulefordefaultpricelistselection")]
    public bool? UseInbuiltRuleForDefaultPricelistSelection
    {
      get => this.GetAttributeValue<bool?>("useinbuiltrulefordefaultpricelistselection");
      set
      {
        this.OnPropertyChanging(nameof (UseInbuiltRuleForDefaultPricelistSelection));
        this.SetAttributeValue("useinbuiltrulefordefaultpricelistselection", (object) value);
        this.OnPropertyChanged(nameof (UseInbuiltRuleForDefaultPricelistSelection));
      }
    }

    [AttributeLogicalName("uselegacyrendering")]
    public bool? UseLegacyRendering
    {
      get => this.GetAttributeValue<bool?>("uselegacyrendering");
      set
      {
        this.OnPropertyChanging(nameof (UseLegacyRendering));
        this.SetAttributeValue("uselegacyrendering", (object) value);
        this.OnPropertyChanged(nameof (UseLegacyRendering));
      }
    }

    [AttributeLogicalName("usepositionhierarchy")]
    public bool? UsePositionHierarchy
    {
      get => this.GetAttributeValue<bool?>("usepositionhierarchy");
      set
      {
        this.OnPropertyChanging(nameof (UsePositionHierarchy));
        this.SetAttributeValue("usepositionhierarchy", (object) value);
        this.OnPropertyChanged(nameof (UsePositionHierarchy));
      }
    }

    [AttributeLogicalName("usequickfindviewforgridsearch")]
    public bool? UseQuickFindViewForGridSearch
    {
      get => this.GetAttributeValue<bool?>("usequickfindviewforgridsearch");
      set
      {
        this.OnPropertyChanging(nameof (UseQuickFindViewForGridSearch));
        this.SetAttributeValue("usequickfindviewforgridsearch", (object) value);
        this.OnPropertyChanged(nameof (UseQuickFindViewForGridSearch));
      }
    }

    [AttributeLogicalName("useraccessauditinginterval")]
    public int? UserAccessAuditingInterval
    {
      get => this.GetAttributeValue<int?>("useraccessauditinginterval");
      set
      {
        this.OnPropertyChanging(nameof (UserAccessAuditingInterval));
        this.SetAttributeValue("useraccessauditinginterval", (object) value);
        this.OnPropertyChanged(nameof (UserAccessAuditingInterval));
      }
    }

    [AttributeLogicalName("usereadform")]
    public bool? UseReadForm
    {
      get => this.GetAttributeValue<bool?>("usereadform");
      set
      {
        this.OnPropertyChanging(nameof (UseReadForm));
        this.SetAttributeValue("usereadform", (object) value);
        this.OnPropertyChanged(nameof (UseReadForm));
      }
    }

    [AttributeLogicalName("usergroupid")]
    public Guid? UserGroupId
    {
      get => this.GetAttributeValue<Guid?>("usergroupid");
      set
      {
        this.OnPropertyChanging(nameof (UserGroupId));
        this.SetAttributeValue("usergroupid", (object) value);
        this.OnPropertyChanged(nameof (UserGroupId));
      }
    }

    [AttributeLogicalName("useskypeprotocol")]
    public bool? UseSkypeProtocol
    {
      get => this.GetAttributeValue<bool?>("useskypeprotocol");
      set
      {
        this.OnPropertyChanging(nameof (UseSkypeProtocol));
        this.SetAttributeValue("useskypeprotocol", (object) value);
        this.OnPropertyChanged(nameof (UseSkypeProtocol));
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

    [AttributeLogicalName("v3calloutconfighash")]
    public string V3CalloutConfigHash => this.GetAttributeValue<string>("v3calloutconfighash");

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [AttributeLogicalName("webresourcehash")]
    public string WebResourceHash
    {
      get => this.GetAttributeValue<string>("webresourcehash");
      set
      {
        this.OnPropertyChanging(nameof (WebResourceHash));
        this.SetAttributeValue("webresourcehash", (object) value);
        this.OnPropertyChanged(nameof (WebResourceHash));
      }
    }

    [AttributeLogicalName("weekstartdaycode")]
    public OptionSetValue WeekStartDayCode
    {
      get => this.GetAttributeValue<OptionSetValue>("weekstartdaycode");
      set
      {
        this.OnPropertyChanging(nameof (WeekStartDayCode));
        this.SetAttributeValue("weekstartdaycode", (object) value);
        this.OnPropertyChanged(nameof (WeekStartDayCode));
      }
    }

    [AttributeLogicalName("widgetproperties")]
    public string WidgetProperties
    {
      get => this.GetAttributeValue<string>("widgetproperties");
      set
      {
        this.OnPropertyChanging(nameof (WidgetProperties));
        this.SetAttributeValue("widgetproperties", (object) value);
        this.OnPropertyChanged(nameof (WidgetProperties));
      }
    }

    [AttributeLogicalName("yammergroupid")]
    public int? YammerGroupId
    {
      get => this.GetAttributeValue<int?>("yammergroupid");
      set
      {
        this.OnPropertyChanging(nameof (YammerGroupId));
        this.SetAttributeValue("yammergroupid", (object) value);
        this.OnPropertyChanged(nameof (YammerGroupId));
      }
    }

    [AttributeLogicalName("yammernetworkpermalink")]
    public string YammerNetworkPermalink
    {
      get => this.GetAttributeValue<string>("yammernetworkpermalink");
      set
      {
        this.OnPropertyChanging(nameof (YammerNetworkPermalink));
        this.SetAttributeValue("yammernetworkpermalink", (object) value);
        this.OnPropertyChanged(nameof (YammerNetworkPermalink));
      }
    }

    [AttributeLogicalName("yammeroauthaccesstokenexpired")]
    public bool? YammerOAuthAccessTokenExpired
    {
      get => this.GetAttributeValue<bool?>("yammeroauthaccesstokenexpired");
      set
      {
        this.OnPropertyChanging(nameof (YammerOAuthAccessTokenExpired));
        this.SetAttributeValue("yammeroauthaccesstokenexpired", (object) value);
        this.OnPropertyChanged(nameof (YammerOAuthAccessTokenExpired));
      }
    }

    [AttributeLogicalName("yammerpostmethod")]
    public OptionSetValue YammerPostMethod
    {
      get => this.GetAttributeValue<OptionSetValue>("yammerpostmethod");
      set
      {
        this.OnPropertyChanging(nameof (YammerPostMethod));
        this.SetAttributeValue("yammerpostmethod", (object) value);
        this.OnPropertyChanged(nameof (YammerPostMethod));
      }
    }

    [AttributeLogicalName("yearstartweekcode")]
    public int? YearStartWeekCode
    {
      get => this.GetAttributeValue<int?>("yearstartweekcode");
      set
      {
        this.OnPropertyChanging(nameof (YearStartWeekCode));
        this.SetAttributeValue("yearstartweekcode", (object) value);
        this.OnPropertyChanged(nameof (YearStartWeekCode));
      }
    }

    [RelationshipSchemaName("organization_ait_addresstype")]
    public IEnumerable<ait_addresstype> organization_ait_addresstype
    {
      get
      {
        return this.GetRelatedEntities<ait_addresstype>(nameof (organization_ait_addresstype), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (organization_ait_addresstype));
        this.SetRelatedEntities<ait_addresstype>(nameof (organization_ait_addresstype), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (organization_ait_addresstype));
      }
    }

    [RelationshipSchemaName("organization_ait_familywellnessconfiguration")]
    public IEnumerable<ait_familywellnessconfiguration> organization_ait_familywellnessconfiguration
    {
      get
      {
        return this.GetRelatedEntities<ait_familywellnessconfiguration>(nameof (organization_ait_familywellnessconfiguration), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (organization_ait_familywellnessconfiguration));
        this.SetRelatedEntities<ait_familywellnessconfiguration>(nameof (organization_ait_familywellnessconfiguration), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (organization_ait_familywellnessconfiguration));
      }
    }

    [RelationshipSchemaName("organization_ait_incidenttype")]
    public IEnumerable<ait_incidenttype> organization_ait_incidenttype
    {
      get
      {
        return this.GetRelatedEntities<ait_incidenttype>(nameof (organization_ait_incidenttype), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (organization_ait_incidenttype));
        this.SetRelatedEntities<ait_incidenttype>(nameof (organization_ait_incidenttype), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (organization_ait_incidenttype));
      }
    }

    [RelationshipSchemaName("organization_ait_investigation")]
    public IEnumerable<ait_investigation> organization_ait_investigation
    {
      get
      {
        return this.GetRelatedEntities<ait_investigation>(nameof (organization_ait_investigation), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (organization_ait_investigation));
        this.SetRelatedEntities<ait_investigation>(nameof (organization_ait_investigation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (organization_ait_investigation));
      }
    }

    [RelationshipSchemaName("organization_ait_tribe")]
    public IEnumerable<ait_tribe> organization_ait_tribe
    {
      get => this.GetRelatedEntities<ait_tribe>(nameof (organization_ait_tribe), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (organization_ait_tribe));
        this.SetRelatedEntities<ait_tribe>(nameof (organization_ait_tribe), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (organization_ait_tribe));
      }
    }

    [RelationshipSchemaName("organization_business_units")]
    public IEnumerable<BusinessUnit> organization_business_units
    {
      get
      {
        return this.GetRelatedEntities<BusinessUnit>(nameof (organization_business_units), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (organization_business_units));
        this.SetRelatedEntities<BusinessUnit>(nameof (organization_business_units), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (organization_business_units));
      }
    }

    [RelationshipSchemaName("organization_connection_roles")]
    public IEnumerable<ConnectionRole> organization_connection_roles
    {
      get
      {
        return this.GetRelatedEntities<ConnectionRole>(nameof (organization_connection_roles), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (organization_connection_roles));
        this.SetRelatedEntities<ConnectionRole>(nameof (organization_connection_roles), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (organization_connection_roles));
      }
    }

    [RelationshipSchemaName("organization_system_users")]
    public IEnumerable<SystemUser> organization_system_users
    {
      get
      {
        return this.GetRelatedEntities<SystemUser>(nameof (organization_system_users), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (organization_system_users));
        this.SetRelatedEntities<SystemUser>(nameof (organization_system_users), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (organization_system_users));
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_organization_createdonbehalfby")]
    public SystemUser lk_organization_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_organization_createdonbehalfby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_organization_modifiedonbehalfby")]
    public SystemUser lk_organization_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_organization_modifiedonbehalfby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_organizationbase_createdby")]
    public SystemUser lk_organizationbase_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_organizationbase_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_organizationbase_modifiedby")]
    public SystemUser lk_organizationbase_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_organizationbase_modifiedby), new EntityRole?());
      }
    }
  }
}
