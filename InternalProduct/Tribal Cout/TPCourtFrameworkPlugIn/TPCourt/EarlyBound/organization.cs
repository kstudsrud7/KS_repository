// Decompiled with JetBrains decompiler
// Type: TPCourt.EarlyBound.organization
// Assembly: TPCourt.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: 615270E2-97DB-4878-8B8F-88925A0FA667
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPCourtFrameworkPlugIn-41F62F3A-2F19-44F2-86DD-4C4AA2D959EF\TPCourtFrameworkPlugIn.dll

using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Runtime.Serialization;

#nullable disable
namespace TPCourt.EarlyBound
{
  [EntityLogicalName("organization")]
  [GeneratedCode("XrmToolkit", "4.0")]
  [DataContract(Name = "Entity", Namespace = "http://schemas.microsoft.com/xrm/2011/Contracts")]
  public class organization : BaseProxyClass
  {
    public const string LogicalName = "organization";
    public const int ObjectTypeCode = 1019;
    public const string PrimaryIdAttribute = "organizationid";
    public const string PrimaryNameAttribute = "name";
    public const string PrimaryImageAttribute = "entityimage";
    private static Dictionary<string, BaseProxyClass.eTextOptions> _textOptions;
    private static Dictionary<string, BaseProxyClass.eNumberOptions> _numberOptions;
    private static Dictionary<string, string> _errorStrings;

    static organization()
    {
      BaseProxyClass.RegisterProxyType(typeof (organization), nameof (organization));
      organization._textOptions = new Dictionary<string, BaseProxyClass.eTextOptions>();
      organization._numberOptions = new Dictionary<string, BaseProxyClass.eNumberOptions>();
      organization._errorStrings = new Dictionary<string, string>();
      organization.TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
      organization.NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
    }

    public organization()
      : base(new Entity(nameof (organization)))
    {
    }

    public organization(Entity original)
      : base(original)
    {
    }

    public static string GetLogicalName() => BaseProxyClass.GetLogicalName<organization>();

    public static BaseProxyClass.eTextOptions TextOptions { get; set; }

    public static void SetTextOptions(
      string logicalName,
      BaseProxyClass.eTextOptions options,
      string errorString = null)
    {
      if (organization._textOptions.ContainsKey(logicalName))
        organization._textOptions[logicalName] = options;
      else
        organization._textOptions.Add(logicalName, options);
      if (!string.IsNullOrEmpty(errorString))
      {
        if (organization._errorStrings.ContainsKey(logicalName))
          organization._errorStrings[logicalName] = errorString;
        else
          organization._errorStrings.Add(logicalName, errorString);
      }
      else
      {
        if (!organization._errorStrings.ContainsKey(logicalName))
          return;
        organization._errorStrings.Remove(logicalName);
      }
    }

    protected override BaseProxyClass.eTextOptions GetTextOptions(string logicalName)
    {
      return organization._textOptions.ContainsKey(logicalName) ? organization._textOptions[logicalName] : organization.TextOptions;
    }

    public static BaseProxyClass.eNumberOptions NumberOptions { get; set; }

    public static void SetNumberOptions(
      string logicalName,
      BaseProxyClass.eNumberOptions options,
      string errorString = null)
    {
      if (organization._numberOptions.ContainsKey(logicalName))
        organization._numberOptions[logicalName] = options;
      else
        organization._numberOptions.Add(logicalName, options);
      if (!string.IsNullOrEmpty(errorString))
      {
        if (organization._errorStrings.ContainsKey(logicalName))
          organization._errorStrings[logicalName] = errorString;
        else
          organization._errorStrings.Add(logicalName, errorString);
      }
      else
      {
        if (!organization._errorStrings.ContainsKey(logicalName))
          return;
        organization._errorStrings.Remove(logicalName);
      }
    }

    protected override BaseProxyClass.eNumberOptions GetNumberOptions(string logicalName)
    {
      return organization._numberOptions.ContainsKey(logicalName) ? organization._numberOptions[logicalName] : organization.NumberOptions;
    }

    protected override string GetErrorString(
      string attributeName,
      BaseProxyClass.eErrorType defaultErrorType)
    {
      return organization._errorStrings.ContainsKey(attributeName) ? organization._errorStrings[attributeName] : (defaultErrorType == BaseProxyClass.eErrorType.Text ? organization.TextError : organization.NumberError);
    }

    public static string TextError { get; set; }

    public static string NumberError { get; set; }

    [AttributeLogicalName("aciwebendpointurl")]
    public string aciwebendpointurl
    {
      get => this.GetPropertyValue<string>(nameof (aciwebendpointurl));
      set
      {
        this.SetPropertyValue(nameof (aciwebendpointurl), value, 500, nameof (aciwebendpointurl));
      }
    }

    [AttributeLogicalName("acknowledgementtemplateid")]
    public EntityReference acknowledgementtemplateid
    {
      get => this.GetPropertyValue<EntityReference>(nameof (acknowledgementtemplateid));
      set
      {
        this.SetPropertyValue<EntityReference>(nameof (acknowledgementtemplateid), value, nameof (acknowledgementtemplateid));
      }
    }

    [AttributeLogicalName("acknowledgementtemplateidname")]
    public string acknowledgementtemplateidname
    {
      get => this.GetPropertyValue<string>(nameof (acknowledgementtemplateidname));
    }

    [AttributeLogicalName("allowaddressbooksyncs")]
    public bool? allowaddressbooksyncs
    {
      get => this.GetPropertyValue<bool?>(nameof (allowaddressbooksyncs));
      set
      {
        this.SetPropertyValue<bool?>(nameof (allowaddressbooksyncs), value, nameof (allowaddressbooksyncs));
      }
    }

    [AttributeLogicalName("allowautoresponsecreation")]
    public bool? allowautoresponsecreation
    {
      get => this.GetPropertyValue<bool?>(nameof (allowautoresponsecreation));
      set
      {
        this.SetPropertyValue<bool?>(nameof (allowautoresponsecreation), value, nameof (allowautoresponsecreation));
      }
    }

    [AttributeLogicalName("allowautounsubscribe")]
    public bool? allowautounsubscribe
    {
      get => this.GetPropertyValue<bool?>(nameof (allowautounsubscribe));
      set
      {
        this.SetPropertyValue<bool?>(nameof (allowautounsubscribe), value, nameof (allowautounsubscribe));
      }
    }

    [AttributeLogicalName("allowautounsubscribeacknowledgement")]
    public bool? allowautounsubscribeacknowledgement
    {
      get => this.GetPropertyValue<bool?>(nameof (allowautounsubscribeacknowledgement));
      set
      {
        this.SetPropertyValue<bool?>(nameof (allowautounsubscribeacknowledgement), value, nameof (allowautounsubscribeacknowledgement));
      }
    }

    [AttributeLogicalName("allowclientmessagebarad")]
    public bool? allowclientmessagebarad
    {
      get => this.GetPropertyValue<bool?>(nameof (allowclientmessagebarad));
      set
      {
        this.SetPropertyValue<bool?>(nameof (allowclientmessagebarad), value, nameof (allowclientmessagebarad));
      }
    }

    [AttributeLogicalName("allowentityonlyaudit")]
    public bool? allowentityonlyaudit
    {
      get => this.GetPropertyValue<bool?>(nameof (allowentityonlyaudit));
      set
      {
        this.SetPropertyValue<bool?>(nameof (allowentityonlyaudit), value, nameof (allowentityonlyaudit));
      }
    }

    [AttributeLogicalName("allowlegacyclientexperience")]
    public bool? allowlegacyclientexperience
    {
      get => this.GetPropertyValue<bool?>(nameof (allowlegacyclientexperience));
      set
      {
        this.SetPropertyValue<bool?>(nameof (allowlegacyclientexperience), value, nameof (allowlegacyclientexperience));
      }
    }

    [AttributeLogicalName("allowlegacydialogsembedding")]
    public bool? allowlegacydialogsembedding
    {
      get => this.GetPropertyValue<bool?>(nameof (allowlegacydialogsembedding));
      set
      {
        this.SetPropertyValue<bool?>(nameof (allowlegacydialogsembedding), value, nameof (allowlegacydialogsembedding));
      }
    }

    [AttributeLogicalName("allowmarketingemailexecution")]
    public bool? allowmarketingemailexecution
    {
      get => this.GetPropertyValue<bool?>(nameof (allowmarketingemailexecution));
      set
      {
        this.SetPropertyValue<bool?>(nameof (allowmarketingemailexecution), value, nameof (allowmarketingemailexecution));
      }
    }

    [AttributeLogicalName("allowofflinescheduledsyncs")]
    public bool? allowofflinescheduledsyncs
    {
      get => this.GetPropertyValue<bool?>(nameof (allowofflinescheduledsyncs));
      set
      {
        this.SetPropertyValue<bool?>(nameof (allowofflinescheduledsyncs), value, nameof (allowofflinescheduledsyncs));
      }
    }

    [AttributeLogicalName("allowoutlookscheduledsyncs")]
    public bool? allowoutlookscheduledsyncs
    {
      get => this.GetPropertyValue<bool?>(nameof (allowoutlookscheduledsyncs));
      set
      {
        this.SetPropertyValue<bool?>(nameof (allowoutlookscheduledsyncs), value, nameof (allowoutlookscheduledsyncs));
      }
    }

    [AttributeLogicalName("allowunresolvedpartiesonemailsend")]
    public bool? allowunresolvedpartiesonemailsend
    {
      get => this.GetPropertyValue<bool?>(nameof (allowunresolvedpartiesonemailsend));
      set
      {
        this.SetPropertyValue<bool?>(nameof (allowunresolvedpartiesonemailsend), value, nameof (allowunresolvedpartiesonemailsend));
      }
    }

    [AttributeLogicalName("allowuserformmodepreference")]
    public bool? allowuserformmodepreference
    {
      get => this.GetPropertyValue<bool?>(nameof (allowuserformmodepreference));
      set
      {
        this.SetPropertyValue<bool?>(nameof (allowuserformmodepreference), value, nameof (allowuserformmodepreference));
      }
    }

    [AttributeLogicalName("allowusersseeappdownloadmessage")]
    public bool? allowusersseeappdownloadmessage
    {
      get => this.GetPropertyValue<bool?>(nameof (allowusersseeappdownloadmessage));
      set
      {
        this.SetPropertyValue<bool?>(nameof (allowusersseeappdownloadmessage), value, nameof (allowusersseeappdownloadmessage));
      }
    }

    [AttributeLogicalName("allowwebexcelexport")]
    public bool? allowwebexcelexport
    {
      get => this.GetPropertyValue<bool?>(nameof (allowwebexcelexport));
      set
      {
        this.SetPropertyValue<bool?>(nameof (allowwebexcelexport), value, nameof (allowwebexcelexport));
      }
    }

    [AttributeLogicalName("amdesignator")]
    public string amdesignator
    {
      get => this.GetPropertyValue<string>(nameof (amdesignator));
      set => this.SetPropertyValue(nameof (amdesignator), value, 25, nameof (amdesignator));
    }

    [AttributeLogicalName("appdesignerexperienceenabled")]
    public bool? appdesignerexperienceenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (appdesignerexperienceenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (appdesignerexperienceenabled), value, nameof (appdesignerexperienceenabled));
      }
    }

    [AttributeLogicalName("appointmentricheditorexperience")]
    public bool? appointmentricheditorexperience
    {
      get => this.GetPropertyValue<bool?>(nameof (appointmentricheditorexperience));
      set
      {
        this.SetPropertyValue<bool?>(nameof (appointmentricheditorexperience), value, nameof (appointmentricheditorexperience));
      }
    }

    [AttributeLogicalName("auditretentionperiod")]
    public int? auditretentionperiod
    {
      get => this.GetPropertyValue<int?>(nameof (auditretentionperiod));
      set
      {
        this.SetPropertyValue(nameof (auditretentionperiod), value, 30, int.MaxValue, nameof (auditretentionperiod));
      }
    }

    [AttributeLogicalName("auditretentionperiodv2")]
    public int? auditretentionperiodv2
    {
      get => this.GetPropertyValue<int?>(nameof (auditretentionperiodv2));
      set
      {
        this.SetPropertyValue(nameof (auditretentionperiodv2), value, int.MinValue, int.MaxValue, nameof (auditretentionperiodv2));
      }
    }

    [AttributeLogicalName("autoapplydefaultoncasecreate")]
    public bool? autoapplydefaultoncasecreate
    {
      get => this.GetPropertyValue<bool?>(nameof (autoapplydefaultoncasecreate));
      set
      {
        this.SetPropertyValue<bool?>(nameof (autoapplydefaultoncasecreate), value, nameof (autoapplydefaultoncasecreate));
      }
    }

    [AttributeLogicalName("autoapplydefaultoncaseupdate")]
    public bool? autoapplydefaultoncaseupdate
    {
      get => this.GetPropertyValue<bool?>(nameof (autoapplydefaultoncaseupdate));
      set
      {
        this.SetPropertyValue<bool?>(nameof (autoapplydefaultoncaseupdate), value, nameof (autoapplydefaultoncaseupdate));
      }
    }

    [AttributeLogicalName("autoapplysla")]
    public bool? autoapplysla
    {
      get => this.GetPropertyValue<bool?>(nameof (autoapplysla));
      set => this.SetPropertyValue<bool?>(nameof (autoapplysla), value, nameof (autoapplysla));
    }

    [AttributeLogicalName("azureschedulerjobcollectionname")]
    public string azureschedulerjobcollectionname
    {
      get => this.GetPropertyValue<string>(nameof (azureschedulerjobcollectionname));
      set
      {
        this.SetPropertyValue(nameof (azureschedulerjobcollectionname), value, 100, nameof (azureschedulerjobcollectionname));
      }
    }

    [AttributeLogicalName("basecurrencyid")]
    public EntityReference basecurrencyid
    {
      get => this.GetPropertyValue<EntityReference>(nameof (basecurrencyid));
      set
      {
        this.SetPropertyValue<EntityReference>(nameof (basecurrencyid), value, nameof (basecurrencyid));
      }
    }

    [AttributeLogicalName("basecurrencyidname")]
    public string basecurrencyidname => this.GetPropertyValue<string>(nameof (basecurrencyidname));

    [AttributeLogicalName("basecurrencyprecision")]
    public int? basecurrencyprecision
    {
      get => this.GetPropertyValue<int?>(nameof (basecurrencyprecision));
    }

    [AttributeLogicalName("basecurrencysymbol")]
    public string basecurrencysymbol => this.GetPropertyValue<string>(nameof (basecurrencysymbol));

    [AttributeLogicalName("baseisocurrencycode")]
    public string baseisocurrencycode
    {
      get => this.GetPropertyValue<string>(nameof (baseisocurrencycode));
    }

    [AttributeLogicalName("bingmapsapikey")]
    public string bingmapsapikey
    {
      get => this.GetPropertyValue<string>(nameof (bingmapsapikey));
      set => this.SetPropertyValue(nameof (bingmapsapikey), value, 1024, nameof (bingmapsapikey));
    }

    [AttributeLogicalName("blockedattachments")]
    public string blockedattachments
    {
      get => this.GetPropertyValue<string>(nameof (blockedattachments));
      set
      {
        this.SetPropertyValue(nameof (blockedattachments), value, 1073741823, nameof (blockedattachments));
      }
    }

    [AttributeLogicalName("bounddashboarddefaultcardexpanded")]
    public bool? bounddashboarddefaultcardexpanded
    {
      get => this.GetPropertyValue<bool?>(nameof (bounddashboarddefaultcardexpanded));
      set
      {
        this.SetPropertyValue<bool?>(nameof (bounddashboarddefaultcardexpanded), value, nameof (bounddashboarddefaultcardexpanded));
      }
    }

    [AttributeLogicalName("bulkoperationprefix")]
    public string bulkoperationprefix
    {
      get => this.GetPropertyValue<string>(nameof (bulkoperationprefix));
      set
      {
        this.SetPropertyValue(nameof (bulkoperationprefix), value, 20, nameof (bulkoperationprefix));
      }
    }

    [AttributeLogicalName("businesscardoptions")]
    public string businesscardoptions
    {
      get => this.GetPropertyValue<string>(nameof (businesscardoptions));
      set
      {
        this.SetPropertyValue(nameof (businesscardoptions), value, 1000, nameof (businesscardoptions));
      }
    }

    [AttributeLogicalName("businessclosurecalendarid")]
    public Guid businessclosurecalendarid
    {
      get => this.GetPropertyValue<Guid>(nameof (businessclosurecalendarid));
      set
      {
        this.SetPropertyValue<Guid>(nameof (businessclosurecalendarid), value, nameof (businessclosurecalendarid));
      }
    }

    [AttributeLogicalName("calendartype")]
    public int? calendartype
    {
      get => this.GetPropertyValue<int?>(nameof (calendartype));
      set
      {
        this.SetPropertyValue(nameof (calendartype), value, int.MinValue, int.MaxValue, nameof (calendartype));
      }
    }

    [AttributeLogicalName("campaignprefix")]
    public string campaignprefix
    {
      get => this.GetPropertyValue<string>(nameof (campaignprefix));
      set => this.SetPropertyValue(nameof (campaignprefix), value, 20, nameof (campaignprefix));
    }

    [AttributeLogicalName("cascadestatusupdate")]
    public bool? cascadestatusupdate
    {
      get => this.GetPropertyValue<bool?>(nameof (cascadestatusupdate));
      set
      {
        this.SetPropertyValue<bool?>(nameof (cascadestatusupdate), value, nameof (cascadestatusupdate));
      }
    }

    [AttributeLogicalName("caseprefix")]
    public string caseprefix
    {
      get => this.GetPropertyValue<string>(nameof (caseprefix));
      set => this.SetPropertyValue(nameof (caseprefix), value, 20, nameof (caseprefix));
    }

    [AttributeLogicalName("categoryprefix")]
    public string categoryprefix
    {
      get => this.GetPropertyValue<string>(nameof (categoryprefix));
      set => this.SetPropertyValue(nameof (categoryprefix), value, 20, nameof (categoryprefix));
    }

    [AttributeLogicalName("clientfeatureset")]
    public string clientfeatureset
    {
      get => this.GetPropertyValue<string>(nameof (clientfeatureset));
      set
      {
        this.SetPropertyValue(nameof (clientfeatureset), value, 1073741823, nameof (clientfeatureset));
      }
    }

    [AttributeLogicalName("contentsecuritypolicyconfiguration")]
    public string contentsecuritypolicyconfiguration
    {
      get => this.GetPropertyValue<string>(nameof (contentsecuritypolicyconfiguration));
      set
      {
        this.SetPropertyValue(nameof (contentsecuritypolicyconfiguration), value, 1073741823, nameof (contentsecuritypolicyconfiguration));
      }
    }

    [AttributeLogicalName("contractprefix")]
    public string contractprefix
    {
      get => this.GetPropertyValue<string>(nameof (contractprefix));
      set => this.SetPropertyValue(nameof (contractprefix), value, 20, nameof (contractprefix));
    }

    [AttributeLogicalName("cortanaproactiveexperienceenabled")]
    public bool? cortanaproactiveexperienceenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (cortanaproactiveexperienceenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (cortanaproactiveexperienceenabled), value, nameof (cortanaproactiveexperienceenabled));
      }
    }

    [AttributeLogicalName("createdby")]
    public EntityReference createdby => this.GetPropertyValue<EntityReference>(nameof (createdby));

    [AttributeLogicalName("createdbyname")]
    public string createdbyname => this.GetPropertyValue<string>(nameof (createdbyname));

    [AttributeLogicalName("createdbyyominame")]
    public string createdbyyominame => this.GetPropertyValue<string>(nameof (createdbyyominame));

    [AttributeLogicalName("createdon")]
    public DateTime? createdon => this.GetPropertyValue<DateTime?>(nameof (createdon));

    [AttributeLogicalName("createdonbehalfby")]
    public EntityReference createdonbehalfby
    {
      get => this.GetPropertyValue<EntityReference>(nameof (createdonbehalfby));
    }

    [AttributeLogicalName("createdonbehalfbyname")]
    public string createdonbehalfbyname
    {
      get => this.GetPropertyValue<string>(nameof (createdonbehalfbyname));
    }

    [AttributeLogicalName("createdonbehalfbyyominame")]
    public string createdonbehalfbyyominame
    {
      get => this.GetPropertyValue<string>(nameof (createdonbehalfbyyominame));
    }

    [AttributeLogicalName("createproductswithoutparentinactivestate")]
    public bool? createproductswithoutparentinactivestate
    {
      get => this.GetPropertyValue<bool?>(nameof (createproductswithoutparentinactivestate));
      set
      {
        this.SetPropertyValue<bool?>(nameof (createproductswithoutparentinactivestate), value, nameof (createproductswithoutparentinactivestate));
      }
    }

    [AttributeLogicalName("currencydecimalprecision")]
    public int? currencydecimalprecision
    {
      get => this.GetPropertyValue<int?>(nameof (currencydecimalprecision));
      set
      {
        this.SetPropertyValue(nameof (currencydecimalprecision), value, int.MinValue, int.MaxValue, nameof (currencydecimalprecision));
      }
    }

    [AttributeLogicalName("currencydisplayoption")]
    public eOrganization_currencydisplayoption? currencydisplayoption
    {
      get
      {
        return this.currencydisplayoption_OptionSetValue != null ? new eOrganization_currencydisplayoption?((eOrganization_currencydisplayoption) this.currencydisplayoption_OptionSetValue.Value) : new eOrganization_currencydisplayoption?();
      }
      set
      {
        if (value.HasValue)
          this.currencydisplayoption_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.currencydisplayoption_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("currencydisplayoption")]
    public OptionSetValue currencydisplayoption_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("currencydisplayoption");
      set
      {
        this.SetPropertyValue<OptionSetValue>("currencydisplayoption", value, nameof (currencydisplayoption_OptionSetValue));
      }
    }

    public string currencydisplayoption_Text(IOrganizationService service)
    {
      return this.currencydisplayoption_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "currencydisplayoption");
    }

    public string currencydisplayoption_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.currencydisplayoption_OptionSetValue.Value);
    }

    [AttributeLogicalName("currencyformatcode")]
    public OptionSetValue currencyformatcode
    {
      get => this.GetPropertyValue<OptionSetValue>(nameof (currencyformatcode));
      set
      {
        this.SetPropertyValue<OptionSetValue>(nameof (currencyformatcode), value, nameof (currencyformatcode));
      }
    }

    [AttributeLogicalName("currencysymbol")]
    public string currencysymbol
    {
      get => this.GetPropertyValue<string>(nameof (currencysymbol));
      set => this.SetPropertyValue(nameof (currencysymbol), value, 13, nameof (currencysymbol));
    }

    [AttributeLogicalName("currentbulkoperationnumber")]
    public int? currentbulkoperationnumber
    {
      get => this.GetPropertyValue<int?>(nameof (currentbulkoperationnumber));
      set
      {
        this.SetPropertyValue(nameof (currentbulkoperationnumber), value, 0, int.MaxValue, nameof (currentbulkoperationnumber));
      }
    }

    [AttributeLogicalName("currentcampaignnumber")]
    public int? currentcampaignnumber
    {
      get => this.GetPropertyValue<int?>(nameof (currentcampaignnumber));
      set
      {
        this.SetPropertyValue(nameof (currentcampaignnumber), value, int.MinValue, int.MaxValue, nameof (currentcampaignnumber));
      }
    }

    [AttributeLogicalName("currentcasenumber")]
    public int? currentcasenumber
    {
      get => this.GetPropertyValue<int?>(nameof (currentcasenumber));
      set
      {
        this.SetPropertyValue(nameof (currentcasenumber), value, int.MinValue, int.MaxValue, nameof (currentcasenumber));
      }
    }

    [AttributeLogicalName("currentcategorynumber")]
    public int? currentcategorynumber
    {
      get => this.GetPropertyValue<int?>(nameof (currentcategorynumber));
      set
      {
        this.SetPropertyValue(nameof (currentcategorynumber), value, -1, int.MaxValue, nameof (currentcategorynumber));
      }
    }

    [AttributeLogicalName("currentcontractnumber")]
    public int? currentcontractnumber
    {
      get => this.GetPropertyValue<int?>(nameof (currentcontractnumber));
      set
      {
        this.SetPropertyValue(nameof (currentcontractnumber), value, int.MinValue, int.MaxValue, nameof (currentcontractnumber));
      }
    }

    [AttributeLogicalName("currentimportsequencenumber")]
    public int? currentimportsequencenumber
    {
      get => this.GetPropertyValue<int?>(nameof (currentimportsequencenumber));
    }

    [AttributeLogicalName("currentinvoicenumber")]
    public int? currentinvoicenumber
    {
      get => this.GetPropertyValue<int?>(nameof (currentinvoicenumber));
      set
      {
        this.SetPropertyValue(nameof (currentinvoicenumber), value, int.MinValue, int.MaxValue, nameof (currentinvoicenumber));
      }
    }

    [AttributeLogicalName("currentkanumber")]
    public int? currentkanumber
    {
      get => this.GetPropertyValue<int?>(nameof (currentkanumber));
      set
      {
        this.SetPropertyValue(nameof (currentkanumber), value, -1, int.MaxValue, nameof (currentkanumber));
      }
    }

    [AttributeLogicalName("currentkbnumber")]
    public int? currentkbnumber
    {
      get => this.GetPropertyValue<int?>(nameof (currentkbnumber));
      set
      {
        this.SetPropertyValue(nameof (currentkbnumber), value, int.MinValue, int.MaxValue, nameof (currentkbnumber));
      }
    }

    [AttributeLogicalName("currentordernumber")]
    public int? currentordernumber
    {
      get => this.GetPropertyValue<int?>(nameof (currentordernumber));
      set
      {
        this.SetPropertyValue(nameof (currentordernumber), value, int.MinValue, int.MaxValue, nameof (currentordernumber));
      }
    }

    [AttributeLogicalName("currentparsedtablenumber")]
    public int? currentparsedtablenumber
    {
      get => this.GetPropertyValue<int?>(nameof (currentparsedtablenumber));
    }

    [AttributeLogicalName("currentquotenumber")]
    public int? currentquotenumber
    {
      get => this.GetPropertyValue<int?>(nameof (currentquotenumber));
      set
      {
        this.SetPropertyValue(nameof (currentquotenumber), value, int.MinValue, int.MaxValue, nameof (currentquotenumber));
      }
    }

    [AttributeLogicalName("dateformatcode")]
    public OptionSetValue dateformatcode
    {
      get => this.GetPropertyValue<OptionSetValue>(nameof (dateformatcode));
      set
      {
        this.SetPropertyValue<OptionSetValue>(nameof (dateformatcode), value, nameof (dateformatcode));
      }
    }

    [AttributeLogicalName("dateformatstring")]
    public string dateformatstring
    {
      get => this.GetPropertyValue<string>(nameof (dateformatstring));
      set
      {
        this.SetPropertyValue(nameof (dateformatstring), value, (int) byte.MaxValue, nameof (dateformatstring));
      }
    }

    [AttributeLogicalName("dateseparator")]
    public string dateseparator
    {
      get => this.GetPropertyValue<string>(nameof (dateseparator));
      set => this.SetPropertyValue(nameof (dateseparator), value, 5, nameof (dateseparator));
    }

    [AttributeLogicalName("dayssincerecordlastmodifiedmaxvalue")]
    public int? dayssincerecordlastmodifiedmaxvalue
    {
      get => this.GetPropertyValue<int?>(nameof (dayssincerecordlastmodifiedmaxvalue));
    }

    [AttributeLogicalName("decimalsymbol")]
    public string decimalsymbol
    {
      get => this.GetPropertyValue<string>(nameof (decimalsymbol));
      set => this.SetPropertyValue(nameof (decimalsymbol), value, 5, nameof (decimalsymbol));
    }

    [AttributeLogicalName("defaultcountrycode")]
    public string defaultcountrycode
    {
      get => this.GetPropertyValue<string>(nameof (defaultcountrycode));
      set
      {
        this.SetPropertyValue(nameof (defaultcountrycode), value, 30, nameof (defaultcountrycode));
      }
    }

    [AttributeLogicalName("defaultcrmcustomname")]
    public string defaultcrmcustomname
    {
      get => this.GetPropertyValue<string>(nameof (defaultcrmcustomname));
      set
      {
        this.SetPropertyValue(nameof (defaultcrmcustomname), value, 100, nameof (defaultcrmcustomname));
      }
    }

    [AttributeLogicalName("defaultemailserverprofileid")]
    public EntityReference defaultemailserverprofileid
    {
      get => this.GetPropertyValue<EntityReference>(nameof (defaultemailserverprofileid));
      set
      {
        this.SetPropertyValue<EntityReference>(nameof (defaultemailserverprofileid), value, nameof (defaultemailserverprofileid));
      }
    }

    [AttributeLogicalName("defaultemailserverprofileidname")]
    public string defaultemailserverprofileidname
    {
      get => this.GetPropertyValue<string>(nameof (defaultemailserverprofileidname));
    }

    [AttributeLogicalName("defaultemailsettings")]
    public string defaultemailsettings
    {
      get => this.GetPropertyValue<string>(nameof (defaultemailsettings));
      set
      {
        this.SetPropertyValue(nameof (defaultemailsettings), value, 1073741823, nameof (defaultemailsettings));
      }
    }

    [AttributeLogicalName("defaultmobileofflineprofileid")]
    public EntityReference defaultmobileofflineprofileid
    {
      get => this.GetPropertyValue<EntityReference>(nameof (defaultmobileofflineprofileid));
      set
      {
        this.SetPropertyValue<EntityReference>(nameof (defaultmobileofflineprofileid), value, nameof (defaultmobileofflineprofileid));
      }
    }

    [AttributeLogicalName("defaultmobileofflineprofileidname")]
    public string defaultmobileofflineprofileidname
    {
      get => this.GetPropertyValue<string>(nameof (defaultmobileofflineprofileidname));
    }

    [AttributeLogicalName("defaultrecurrenceendrangetype")]
    public eOrganization_defaultrecurrenceendrangetype? defaultrecurrenceendrangetype
    {
      get
      {
        return this.defaultrecurrenceendrangetype_OptionSetValue != null ? new eOrganization_defaultrecurrenceendrangetype?((eOrganization_defaultrecurrenceendrangetype) this.defaultrecurrenceendrangetype_OptionSetValue.Value) : new eOrganization_defaultrecurrenceendrangetype?();
      }
      set
      {
        if (value.HasValue)
          this.defaultrecurrenceendrangetype_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.defaultrecurrenceendrangetype_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("defaultrecurrenceendrangetype")]
    public OptionSetValue defaultrecurrenceendrangetype_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("defaultrecurrenceendrangetype");
      set
      {
        this.SetPropertyValue<OptionSetValue>("defaultrecurrenceendrangetype", value, nameof (defaultrecurrenceendrangetype_OptionSetValue));
      }
    }

    public string defaultrecurrenceendrangetype_Text(IOrganizationService service)
    {
      return this.defaultrecurrenceendrangetype_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "defaultrecurrenceendrangetype");
    }

    public string defaultrecurrenceendrangetype_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.defaultrecurrenceendrangetype_OptionSetValue.Value);
    }

    [AttributeLogicalName("defaultthemedata")]
    public string defaultthemedata
    {
      get => this.GetPropertyValue<string>(nameof (defaultthemedata));
      set
      {
        this.SetPropertyValue(nameof (defaultthemedata), value, 1073741823, nameof (defaultthemedata));
      }
    }

    [AttributeLogicalName("delegatedadminuserid")]
    public Guid delegatedadminuserid
    {
      get => this.GetPropertyValue<Guid>(nameof (delegatedadminuserid));
      set
      {
        this.SetPropertyValue<Guid>(nameof (delegatedadminuserid), value, nameof (delegatedadminuserid));
      }
    }

    [AttributeLogicalName("disabledreason")]
    public string disabledreason => this.GetPropertyValue<string>(nameof (disabledreason));

    [AttributeLogicalName("disablesocialcare")]
    public bool? disablesocialcare
    {
      get => this.GetPropertyValue<bool?>(nameof (disablesocialcare));
      set
      {
        this.SetPropertyValue<bool?>(nameof (disablesocialcare), value, nameof (disablesocialcare));
      }
    }

    [AttributeLogicalName("discountcalculationmethod")]
    public eOrganization_discountcalculationmethod? discountcalculationmethod
    {
      get
      {
        return this.discountcalculationmethod_OptionSetValue != null ? new eOrganization_discountcalculationmethod?((eOrganization_discountcalculationmethod) this.discountcalculationmethod_OptionSetValue.Value) : new eOrganization_discountcalculationmethod?();
      }
      set
      {
        if (value.HasValue)
          this.discountcalculationmethod_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.discountcalculationmethod_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("discountcalculationmethod")]
    public OptionSetValue discountcalculationmethod_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("discountcalculationmethod");
      set
      {
        this.SetPropertyValue<OptionSetValue>("discountcalculationmethod", value, nameof (discountcalculationmethod_OptionSetValue));
      }
    }

    public string discountcalculationmethod_Text(IOrganizationService service)
    {
      return this.discountcalculationmethod_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "discountcalculationmethod");
    }

    public string discountcalculationmethod_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.discountcalculationmethod_OptionSetValue.Value);
    }

    [AttributeLogicalName("displaynavigationtour")]
    public bool? displaynavigationtour
    {
      get => this.GetPropertyValue<bool?>(nameof (displaynavigationtour));
      set
      {
        this.SetPropertyValue<bool?>(nameof (displaynavigationtour), value, nameof (displaynavigationtour));
      }
    }

    [AttributeLogicalName("emailconnectionchannel")]
    public OptionSetValue emailconnectionchannel
    {
      get => this.GetPropertyValue<OptionSetValue>(nameof (emailconnectionchannel));
      set
      {
        this.SetPropertyValue<OptionSetValue>(nameof (emailconnectionchannel), value, nameof (emailconnectionchannel));
      }
    }

    [AttributeLogicalName("emailcorrelationenabled")]
    public bool? emailcorrelationenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (emailcorrelationenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (emailcorrelationenabled), value, nameof (emailcorrelationenabled));
      }
    }

    [AttributeLogicalName("emailsendpollingperiod")]
    public int? emailsendpollingperiod
    {
      get => this.GetPropertyValue<int?>(nameof (emailsendpollingperiod));
      set
      {
        this.SetPropertyValue(nameof (emailsendpollingperiod), value, int.MinValue, int.MaxValue, nameof (emailsendpollingperiod));
      }
    }

    [AttributeLogicalName("enablebingmapsintegration")]
    public bool? enablebingmapsintegration
    {
      get => this.GetPropertyValue<bool?>(nameof (enablebingmapsintegration));
      set
      {
        this.SetPropertyValue<bool?>(nameof (enablebingmapsintegration), value, nameof (enablebingmapsintegration));
      }
    }

    [AttributeLogicalName("enableimmersiveskypeintegration")]
    public bool? enableimmersiveskypeintegration
    {
      get => this.GetPropertyValue<bool?>(nameof (enableimmersiveskypeintegration));
      set
      {
        this.SetPropertyValue<bool?>(nameof (enableimmersiveskypeintegration), value, nameof (enableimmersiveskypeintegration));
      }
    }

    [AttributeLogicalName("enablelivepersonacarduci")]
    public bool? enablelivepersonacarduci
    {
      get => this.GetPropertyValue<bool?>(nameof (enablelivepersonacarduci));
      set
      {
        this.SetPropertyValue<bool?>(nameof (enablelivepersonacarduci), value, nameof (enablelivepersonacarduci));
      }
    }

    [AttributeLogicalName("enablelivepersoncardintegrationinoffice")]
    public bool? enablelivepersoncardintegrationinoffice
    {
      get => this.GetPropertyValue<bool?>(nameof (enablelivepersoncardintegrationinoffice));
      set
      {
        this.SetPropertyValue<bool?>(nameof (enablelivepersoncardintegrationinoffice), value, nameof (enablelivepersoncardintegrationinoffice));
      }
    }

    [AttributeLogicalName("enablelpauthoring")]
    public bool? enablelpauthoring
    {
      get => this.GetPropertyValue<bool?>(nameof (enablelpauthoring));
      set
      {
        this.SetPropertyValue<bool?>(nameof (enablelpauthoring), value, nameof (enablelpauthoring));
      }
    }

    [AttributeLogicalName("enablemicrosoftflowintegration")]
    public bool? enablemicrosoftflowintegration
    {
      get => this.GetPropertyValue<bool?>(nameof (enablemicrosoftflowintegration));
      set
      {
        this.SetPropertyValue<bool?>(nameof (enablemicrosoftflowintegration), value, nameof (enablemicrosoftflowintegration));
      }
    }

    [AttributeLogicalName("enablepricingoncreate")]
    public bool? enablepricingoncreate
    {
      get => this.GetPropertyValue<bool?>(nameof (enablepricingoncreate));
      set
      {
        this.SetPropertyValue<bool?>(nameof (enablepricingoncreate), value, nameof (enablepricingoncreate));
      }
    }

    [AttributeLogicalName("enablesmartmatching")]
    public bool? enablesmartmatching
    {
      get => this.GetPropertyValue<bool?>(nameof (enablesmartmatching));
      set
      {
        this.SetPropertyValue<bool?>(nameof (enablesmartmatching), value, nameof (enablesmartmatching));
      }
    }

    [AttributeLogicalName("enableunifiedinterfaceshellrefresh")]
    public bool? enableunifiedinterfaceshellrefresh
    {
      get => this.GetPropertyValue<bool?>(nameof (enableunifiedinterfaceshellrefresh));
      set
      {
        this.SetPropertyValue<bool?>(nameof (enableunifiedinterfaceshellrefresh), value, nameof (enableunifiedinterfaceshellrefresh));
      }
    }

    [AttributeLogicalName("enforcereadonlyplugins")]
    public bool? enforcereadonlyplugins
    {
      get => this.GetPropertyValue<bool?>(nameof (enforcereadonlyplugins));
      set
      {
        this.SetPropertyValue<bool?>(nameof (enforcereadonlyplugins), value, nameof (enforcereadonlyplugins));
      }
    }

    [AttributeLogicalName("entityimage_timestamp")]
    public int? entityimage_timestamp
    {
      get => this.GetPropertyValue<int?>(nameof (entityimage_timestamp));
    }

    [AttributeLogicalName("entityimage_url")]
    public string entityimage_url => this.GetPropertyValue<string>(nameof (entityimage_url));

    [AttributeLogicalName("entityimageid")]
    public Guid entityimageid => this.GetPropertyValue<Guid>(nameof (entityimageid));

    [AttributeLogicalName("expirechangetrackingindays")]
    public int? expirechangetrackingindays
    {
      get => this.GetPropertyValue<int?>(nameof (expirechangetrackingindays));
      set
      {
        this.SetPropertyValue(nameof (expirechangetrackingindays), value, 0, 365, nameof (expirechangetrackingindays));
      }
    }

    [AttributeLogicalName("expiresubscriptionsindays")]
    public int? expiresubscriptionsindays
    {
      get => this.GetPropertyValue<int?>(nameof (expiresubscriptionsindays));
      set
      {
        this.SetPropertyValue(nameof (expiresubscriptionsindays), value, 0, int.MaxValue, nameof (expiresubscriptionsindays));
      }
    }

    [AttributeLogicalName("externalbaseurl")]
    public string externalbaseurl
    {
      get => this.GetPropertyValue<string>(nameof (externalbaseurl));
      set => this.SetPropertyValue(nameof (externalbaseurl), value, 500, nameof (externalbaseurl));
    }

    [AttributeLogicalName("externalpartycorrelationkeys")]
    public string externalpartycorrelationkeys
    {
      get => this.GetPropertyValue<string>(nameof (externalpartycorrelationkeys));
      set
      {
        this.SetPropertyValue(nameof (externalpartycorrelationkeys), value, 1073741823, nameof (externalpartycorrelationkeys));
      }
    }

    [AttributeLogicalName("externalpartyentitysettings")]
    public string externalpartyentitysettings
    {
      get => this.GetPropertyValue<string>(nameof (externalpartyentitysettings));
      set
      {
        this.SetPropertyValue(nameof (externalpartyentitysettings), value, 1073741823, nameof (externalpartyentitysettings));
      }
    }

    [AttributeLogicalName("featureset")]
    public string featureset
    {
      get => this.GetPropertyValue<string>(nameof (featureset));
      set => this.SetPropertyValue(nameof (featureset), value, 1073741823, nameof (featureset));
    }

    [AttributeLogicalName("fiscalcalendarstart")]
    public DateTime? fiscalcalendarstart
    {
      get => this.GetPropertyValue<DateTime?>(nameof (fiscalcalendarstart));
      set
      {
        this.SetPropertyValue<DateTime?>(nameof (fiscalcalendarstart), value, nameof (fiscalcalendarstart));
      }
    }

    [AttributeLogicalName("fiscalperiodformat")]
    public string fiscalperiodformat
    {
      get => this.GetPropertyValue<string>(nameof (fiscalperiodformat));
      set
      {
        this.SetPropertyValue(nameof (fiscalperiodformat), value, 25, nameof (fiscalperiodformat));
      }
    }

    [AttributeLogicalName("fiscalperiodformatperiod")]
    public eOrganization_fiscalperiodformat? fiscalperiodformatperiod
    {
      get
      {
        return this.fiscalperiodformatperiod_OptionSetValue != null ? new eOrganization_fiscalperiodformat?((eOrganization_fiscalperiodformat) this.fiscalperiodformatperiod_OptionSetValue.Value) : new eOrganization_fiscalperiodformat?();
      }
      set
      {
        if (value.HasValue)
          this.fiscalperiodformatperiod_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.fiscalperiodformatperiod_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("fiscalperiodformatperiod")]
    public OptionSetValue fiscalperiodformatperiod_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("fiscalperiodformatperiod");
      set
      {
        this.SetPropertyValue<OptionSetValue>("fiscalperiodformatperiod", value, nameof (fiscalperiodformatperiod_OptionSetValue));
      }
    }

    public string fiscalperiodformatperiod_Text(IOrganizationService service)
    {
      return this.fiscalperiodformatperiod_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "fiscalperiodformatperiod");
    }

    public string fiscalperiodformatperiod_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.fiscalperiodformatperiod_OptionSetValue.Value);
    }

    [AttributeLogicalName("fiscalperiodtype")]
    public int? fiscalperiodtype
    {
      get => this.GetPropertyValue<int?>(nameof (fiscalperiodtype));
      set
      {
        this.SetPropertyValue(nameof (fiscalperiodtype), value, int.MinValue, int.MaxValue, nameof (fiscalperiodtype));
      }
    }

    [AttributeLogicalName("fiscalsettingsupdated")]
    public bool? fiscalsettingsupdated
    {
      get => this.GetPropertyValue<bool?>(nameof (fiscalsettingsupdated));
    }

    [AttributeLogicalName("fiscalyeardisplaycode")]
    public int? fiscalyeardisplaycode
    {
      get => this.GetPropertyValue<int?>(nameof (fiscalyeardisplaycode));
      set
      {
        this.SetPropertyValue<int?>(nameof (fiscalyeardisplaycode), value, nameof (fiscalyeardisplaycode));
      }
    }

    [AttributeLogicalName("fiscalyearformat")]
    public string fiscalyearformat
    {
      get => this.GetPropertyValue<string>(nameof (fiscalyearformat));
      set => this.SetPropertyValue(nameof (fiscalyearformat), value, 25, nameof (fiscalyearformat));
    }

    [AttributeLogicalName("fiscalyearformatprefix")]
    public eOrganization_fiscalyearformatprefix? fiscalyearformatprefix
    {
      get
      {
        return this.fiscalyearformatprefix_OptionSetValue != null ? new eOrganization_fiscalyearformatprefix?((eOrganization_fiscalyearformatprefix) this.fiscalyearformatprefix_OptionSetValue.Value) : new eOrganization_fiscalyearformatprefix?();
      }
      set
      {
        if (value.HasValue)
          this.fiscalyearformatprefix_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.fiscalyearformatprefix_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("fiscalyearformatprefix")]
    public OptionSetValue fiscalyearformatprefix_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("fiscalyearformatprefix");
      set
      {
        this.SetPropertyValue<OptionSetValue>("fiscalyearformatprefix", value, nameof (fiscalyearformatprefix_OptionSetValue));
      }
    }

    public string fiscalyearformatprefix_Text(IOrganizationService service)
    {
      return this.fiscalyearformatprefix_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "fiscalyearformatprefix");
    }

    public string fiscalyearformatprefix_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.fiscalyearformatprefix_OptionSetValue.Value);
    }

    [AttributeLogicalName("fiscalyearformatsuffix")]
    public eOrganization_fiscalyearformatsuffix? fiscalyearformatsuffix
    {
      get
      {
        return this.fiscalyearformatsuffix_OptionSetValue != null ? new eOrganization_fiscalyearformatsuffix?((eOrganization_fiscalyearformatsuffix) this.fiscalyearformatsuffix_OptionSetValue.Value) : new eOrganization_fiscalyearformatsuffix?();
      }
      set
      {
        if (value.HasValue)
          this.fiscalyearformatsuffix_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.fiscalyearformatsuffix_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("fiscalyearformatsuffix")]
    public OptionSetValue fiscalyearformatsuffix_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("fiscalyearformatsuffix");
      set
      {
        this.SetPropertyValue<OptionSetValue>("fiscalyearformatsuffix", value, nameof (fiscalyearformatsuffix_OptionSetValue));
      }
    }

    public string fiscalyearformatsuffix_Text(IOrganizationService service)
    {
      return this.fiscalyearformatsuffix_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "fiscalyearformatsuffix");
    }

    public string fiscalyearformatsuffix_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.fiscalyearformatsuffix_OptionSetValue.Value);
    }

    [AttributeLogicalName("fiscalyearformatyear")]
    public eOrganization_fiscalyearformatyear? fiscalyearformatyear
    {
      get
      {
        return this.fiscalyearformatyear_OptionSetValue != null ? new eOrganization_fiscalyearformatyear?((eOrganization_fiscalyearformatyear) this.fiscalyearformatyear_OptionSetValue.Value) : new eOrganization_fiscalyearformatyear?();
      }
      set
      {
        if (value.HasValue)
          this.fiscalyearformatyear_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.fiscalyearformatyear_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("fiscalyearformatyear")]
    public OptionSetValue fiscalyearformatyear_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("fiscalyearformatyear");
      set
      {
        this.SetPropertyValue<OptionSetValue>("fiscalyearformatyear", value, nameof (fiscalyearformatyear_OptionSetValue));
      }
    }

    public string fiscalyearformatyear_Text(IOrganizationService service)
    {
      return this.fiscalyearformatyear_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "fiscalyearformatyear");
    }

    public string fiscalyearformatyear_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.fiscalyearformatyear_OptionSetValue.Value);
    }

    [AttributeLogicalName("fiscalyearperiodconnect")]
    public string fiscalyearperiodconnect
    {
      get => this.GetPropertyValue<string>(nameof (fiscalyearperiodconnect));
      set
      {
        this.SetPropertyValue(nameof (fiscalyearperiodconnect), value, 5, nameof (fiscalyearperiodconnect));
      }
    }

    [AttributeLogicalName("fullnameconventioncode")]
    public OptionSetValue fullnameconventioncode
    {
      get => this.GetPropertyValue<OptionSetValue>(nameof (fullnameconventioncode));
      set
      {
        this.SetPropertyValue<OptionSetValue>(nameof (fullnameconventioncode), value, nameof (fullnameconventioncode));
      }
    }

    [AttributeLogicalName("futureexpansionwindow")]
    public int? futureexpansionwindow
    {
      get => this.GetPropertyValue<int?>(nameof (futureexpansionwindow));
      set
      {
        this.SetPropertyValue(nameof (futureexpansionwindow), value, 1, 140, nameof (futureexpansionwindow));
      }
    }

    [AttributeLogicalName("generatealertsforerrors")]
    public bool? generatealertsforerrors
    {
      get => this.GetPropertyValue<bool?>(nameof (generatealertsforerrors));
      set
      {
        this.SetPropertyValue<bool?>(nameof (generatealertsforerrors), value, nameof (generatealertsforerrors));
      }
    }

    [AttributeLogicalName("generatealertsforinformation")]
    public bool? generatealertsforinformation
    {
      get => this.GetPropertyValue<bool?>(nameof (generatealertsforinformation));
      set
      {
        this.SetPropertyValue<bool?>(nameof (generatealertsforinformation), value, nameof (generatealertsforinformation));
      }
    }

    [AttributeLogicalName("generatealertsforwarnings")]
    public bool? generatealertsforwarnings
    {
      get => this.GetPropertyValue<bool?>(nameof (generatealertsforwarnings));
      set
      {
        this.SetPropertyValue<bool?>(nameof (generatealertsforwarnings), value, nameof (generatealertsforwarnings));
      }
    }

    [AttributeLogicalName("getstartedpanecontentenabled")]
    public bool? getstartedpanecontentenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (getstartedpanecontentenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (getstartedpanecontentenabled), value, nameof (getstartedpanecontentenabled));
      }
    }

    [AttributeLogicalName("globalappendurlparametersenabled")]
    public bool? globalappendurlparametersenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (globalappendurlparametersenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (globalappendurlparametersenabled), value, nameof (globalappendurlparametersenabled));
      }
    }

    [AttributeLogicalName("globalhelpurl")]
    public string globalhelpurl
    {
      get => this.GetPropertyValue<string>(nameof (globalhelpurl));
      set => this.SetPropertyValue(nameof (globalhelpurl), value, 500, nameof (globalhelpurl));
    }

    [AttributeLogicalName("globalhelpurlenabled")]
    public bool? globalhelpurlenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (globalhelpurlenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (globalhelpurlenabled), value, nameof (globalhelpurlenabled));
      }
    }

    [AttributeLogicalName("goalrollupexpirytime")]
    public int? goalrollupexpirytime
    {
      get => this.GetPropertyValue<int?>(nameof (goalrollupexpirytime));
      set
      {
        this.SetPropertyValue(nameof (goalrollupexpirytime), value, 0, 400, nameof (goalrollupexpirytime));
      }
    }

    [AttributeLogicalName("goalrollupfrequency")]
    public int? goalrollupfrequency
    {
      get => this.GetPropertyValue<int?>(nameof (goalrollupfrequency));
      set
      {
        this.SetPropertyValue(nameof (goalrollupfrequency), value, 1, int.MaxValue, nameof (goalrollupfrequency));
      }
    }

    [AttributeLogicalName("grantaccesstonetworkservice")]
    public bool? grantaccesstonetworkservice
    {
      get => this.GetPropertyValue<bool?>(nameof (grantaccesstonetworkservice));
      set
      {
        this.SetPropertyValue<bool?>(nameof (grantaccesstonetworkservice), value, nameof (grantaccesstonetworkservice));
      }
    }

    [AttributeLogicalName("hashdeltasubjectcount")]
    public int? hashdeltasubjectcount
    {
      get => this.GetPropertyValue<int?>(nameof (hashdeltasubjectcount));
      set
      {
        this.SetPropertyValue(nameof (hashdeltasubjectcount), value, 0, int.MaxValue, nameof (hashdeltasubjectcount));
      }
    }

    [AttributeLogicalName("hashfilterkeywords")]
    public string hashfilterkeywords
    {
      get => this.GetPropertyValue<string>(nameof (hashfilterkeywords));
      set
      {
        this.SetPropertyValue(nameof (hashfilterkeywords), value, 1073741823, nameof (hashfilterkeywords));
      }
    }

    [AttributeLogicalName("hashmaxcount")]
    public int? hashmaxcount
    {
      get => this.GetPropertyValue<int?>(nameof (hashmaxcount));
      set
      {
        this.SetPropertyValue(nameof (hashmaxcount), value, 0, int.MaxValue, nameof (hashmaxcount));
      }
    }

    [AttributeLogicalName("hashminaddresscount")]
    public int? hashminaddresscount
    {
      get => this.GetPropertyValue<int?>(nameof (hashminaddresscount));
      set
      {
        this.SetPropertyValue(nameof (hashminaddresscount), value, 0, int.MaxValue, nameof (hashminaddresscount));
      }
    }

    [AttributeLogicalName("highcontrastthemedata")]
    public string highcontrastthemedata
    {
      get => this.GetPropertyValue<string>(nameof (highcontrastthemedata));
      set
      {
        this.SetPropertyValue(nameof (highcontrastthemedata), value, 1073741823, nameof (highcontrastthemedata));
      }
    }

    [AttributeLogicalName("ignoreinternalemail")]
    public bool? ignoreinternalemail
    {
      get => this.GetPropertyValue<bool?>(nameof (ignoreinternalemail));
      set
      {
        this.SetPropertyValue<bool?>(nameof (ignoreinternalemail), value, nameof (ignoreinternalemail));
      }
    }

    [AttributeLogicalName("inactivitytimeoutenabled")]
    public bool? inactivitytimeoutenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (inactivitytimeoutenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (inactivitytimeoutenabled), value, nameof (inactivitytimeoutenabled));
      }
    }

    [AttributeLogicalName("inactivitytimeoutinmins")]
    public int? inactivitytimeoutinmins
    {
      get => this.GetPropertyValue<int?>(nameof (inactivitytimeoutinmins));
      set
      {
        this.SetPropertyValue(nameof (inactivitytimeoutinmins), value, 0, int.MaxValue, nameof (inactivitytimeoutinmins));
      }
    }

    [AttributeLogicalName("inactivitytimeoutreminderinmins")]
    public int? inactivitytimeoutreminderinmins
    {
      get => this.GetPropertyValue<int?>(nameof (inactivitytimeoutreminderinmins));
      set
      {
        this.SetPropertyValue(nameof (inactivitytimeoutreminderinmins), value, 0, int.MaxValue, nameof (inactivitytimeoutreminderinmins));
      }
    }

    [AttributeLogicalName("incomingemailexchangeemailretrievalbatchsize")]
    public int? incomingemailexchangeemailretrievalbatchsize
    {
      get => this.GetPropertyValue<int?>(nameof (incomingemailexchangeemailretrievalbatchsize));
      set
      {
        this.SetPropertyValue(nameof (incomingemailexchangeemailretrievalbatchsize), value, 1, int.MaxValue, nameof (incomingemailexchangeemailretrievalbatchsize));
      }
    }

    [AttributeLogicalName("initialversion")]
    public string initialversion
    {
      get => this.GetPropertyValue<string>(nameof (initialversion));
      set => this.SetPropertyValue(nameof (initialversion), value, 20, nameof (initialversion));
    }

    [AttributeLogicalName("integrationuserid")]
    public Guid integrationuserid
    {
      get => this.GetPropertyValue<Guid>(nameof (integrationuserid));
      set
      {
        this.SetPropertyValue<Guid>(nameof (integrationuserid), value, nameof (integrationuserid));
      }
    }

    [AttributeLogicalName("invoiceprefix")]
    public string invoiceprefix
    {
      get => this.GetPropertyValue<string>(nameof (invoiceprefix));
      set => this.SetPropertyValue(nameof (invoiceprefix), value, 20, nameof (invoiceprefix));
    }

    [AttributeLogicalName("isactioncardenabled")]
    public bool? isactioncardenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (isactioncardenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (isactioncardenabled), value, nameof (isactioncardenabled));
      }
    }

    [AttributeLogicalName("isactionsupportfeatureenabled")]
    public bool? isactionsupportfeatureenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (isactionsupportfeatureenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (isactionsupportfeatureenabled), value, nameof (isactionsupportfeatureenabled));
      }
    }

    [AttributeLogicalName("isactivityanalysisenabled")]
    public bool? isactivityanalysisenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (isactivityanalysisenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (isactivityanalysisenabled), value, nameof (isactivityanalysisenabled));
      }
    }

    [AttributeLogicalName("isallmoneydecimal")]
    public bool? isallmoneydecimal => this.GetPropertyValue<bool?>(nameof (isallmoneydecimal));

    [AttributeLogicalName("isappmode")]
    public bool? isappmode
    {
      get => this.GetPropertyValue<bool?>(nameof (isappmode));
      set => this.SetPropertyValue<bool?>(nameof (isappmode), value, nameof (isappmode));
    }

    [AttributeLogicalName("isappointmentattachmentsyncenabled")]
    public bool? isappointmentattachmentsyncenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (isappointmentattachmentsyncenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (isappointmentattachmentsyncenabled), value, nameof (isappointmentattachmentsyncenabled));
      }
    }

    [AttributeLogicalName("isassignedtaskssyncenabled")]
    public bool? isassignedtaskssyncenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (isassignedtaskssyncenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (isassignedtaskssyncenabled), value, nameof (isassignedtaskssyncenabled));
      }
    }

    [AttributeLogicalName("isauditenabled")]
    public bool? isauditenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (isauditenabled));
      set => this.SetPropertyValue<bool?>(nameof (isauditenabled), value, nameof (isauditenabled));
    }

    [AttributeLogicalName("isautodatacaptureenabled")]
    public bool? isautodatacaptureenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (isautodatacaptureenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (isautodatacaptureenabled), value, nameof (isautodatacaptureenabled));
      }
    }

    [AttributeLogicalName("isautodatacapturev2enabled")]
    public bool? isautodatacapturev2enabled
    {
      get => this.GetPropertyValue<bool?>(nameof (isautodatacapturev2enabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (isautodatacapturev2enabled), value, nameof (isautodatacapturev2enabled));
      }
    }

    [AttributeLogicalName("isautosaveenabled")]
    public bool? isautosaveenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (isautosaveenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (isautosaveenabled), value, nameof (isautosaveenabled));
      }
    }

    [AttributeLogicalName("isbpfentitycustomizationfeatureenabled")]
    public bool? isbpfentitycustomizationfeatureenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (isbpfentitycustomizationfeatureenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (isbpfentitycustomizationfeatureenabled), value, nameof (isbpfentitycustomizationfeatureenabled));
      }
    }

    [AttributeLogicalName("isconflictdetectionenabledformobileclient")]
    public bool? isconflictdetectionenabledformobileclient
    {
      get => this.GetPropertyValue<bool?>(nameof (isconflictdetectionenabledformobileclient));
      set
      {
        this.SetPropertyValue<bool?>(nameof (isconflictdetectionenabledformobileclient), value, nameof (isconflictdetectionenabledformobileclient));
      }
    }

    [AttributeLogicalName("iscontactmailingaddresssyncenabled")]
    public bool? iscontactmailingaddresssyncenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (iscontactmailingaddresssyncenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (iscontactmailingaddresssyncenabled), value, nameof (iscontactmailingaddresssyncenabled));
      }
    }

    [AttributeLogicalName("iscontentsecuritypolicyenabled")]
    public bool? iscontentsecuritypolicyenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (iscontentsecuritypolicyenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (iscontentsecuritypolicyenabled), value, nameof (iscontentsecuritypolicyenabled));
      }
    }

    [AttributeLogicalName("iscontextualemailenabled")]
    public bool? iscontextualemailenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (iscontextualemailenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (iscontextualemailenabled), value, nameof (iscontextualemailenabled));
      }
    }

    [AttributeLogicalName("iscontextualhelpenabled")]
    public bool? iscontextualhelpenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (iscontextualhelpenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (iscontextualhelpenabled), value, nameof (iscontextualhelpenabled));
      }
    }

    [AttributeLogicalName("iscustomcontrolsincanvasappsenabled")]
    public bool? iscustomcontrolsincanvasappsenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (iscustomcontrolsincanvasappsenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (iscustomcontrolsincanvasappsenabled), value, nameof (iscustomcontrolsincanvasappsenabled));
      }
    }

    [AttributeLogicalName("isdefaultcountrycodecheckenabled")]
    public bool? isdefaultcountrycodecheckenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (isdefaultcountrycodecheckenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (isdefaultcountrycodecheckenabled), value, nameof (isdefaultcountrycodecheckenabled));
      }
    }

    [AttributeLogicalName("isdelegateaccessenabled")]
    public bool? isdelegateaccessenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (isdelegateaccessenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (isdelegateaccessenabled), value, nameof (isdelegateaccessenabled));
      }
    }

    [AttributeLogicalName("isdelveactionhubintegrationenabled")]
    public bool? isdelveactionhubintegrationenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (isdelveactionhubintegrationenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (isdelveactionhubintegrationenabled), value, nameof (isdelveactionhubintegrationenabled));
      }
    }

    [AttributeLogicalName("isdisabled")]
    public bool? isdisabled => this.GetPropertyValue<bool?>(nameof (isdisabled));

    [AttributeLogicalName("isduplicatedetectionenabled")]
    public bool? isduplicatedetectionenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (isduplicatedetectionenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (isduplicatedetectionenabled), value, nameof (isduplicatedetectionenabled));
      }
    }

    [AttributeLogicalName("isduplicatedetectionenabledforimport")]
    public bool? isduplicatedetectionenabledforimport
    {
      get => this.GetPropertyValue<bool?>(nameof (isduplicatedetectionenabledforimport));
      set
      {
        this.SetPropertyValue<bool?>(nameof (isduplicatedetectionenabledforimport), value, nameof (isduplicatedetectionenabledforimport));
      }
    }

    [AttributeLogicalName("isduplicatedetectionenabledforofflinesync")]
    public bool? isduplicatedetectionenabledforofflinesync
    {
      get => this.GetPropertyValue<bool?>(nameof (isduplicatedetectionenabledforofflinesync));
      set
      {
        this.SetPropertyValue<bool?>(nameof (isduplicatedetectionenabledforofflinesync), value, nameof (isduplicatedetectionenabledforofflinesync));
      }
    }

    [AttributeLogicalName("isduplicatedetectionenabledforonlinecreateupdate")]
    public bool? isduplicatedetectionenabledforonlinecreateupdate
    {
      get
      {
        return this.GetPropertyValue<bool?>(nameof (isduplicatedetectionenabledforonlinecreateupdate));
      }
      set
      {
        this.SetPropertyValue<bool?>(nameof (isduplicatedetectionenabledforonlinecreateupdate), value, nameof (isduplicatedetectionenabledforonlinecreateupdate));
      }
    }

    [AttributeLogicalName("isemailmonitoringallowed")]
    public bool? isemailmonitoringallowed
    {
      get => this.GetPropertyValue<bool?>(nameof (isemailmonitoringallowed));
      set
      {
        this.SetPropertyValue<bool?>(nameof (isemailmonitoringallowed), value, nameof (isemailmonitoringallowed));
      }
    }

    [AttributeLogicalName("isemailserverprofilecontentfilteringenabled")]
    public bool? isemailserverprofilecontentfilteringenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (isemailserverprofilecontentfilteringenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (isemailserverprofilecontentfilteringenabled), value, nameof (isemailserverprofilecontentfilteringenabled));
      }
    }

    [AttributeLogicalName("isenabledforallroles")]
    public bool? isenabledforallroles
    {
      get => this.GetPropertyValue<bool?>(nameof (isenabledforallroles));
      set
      {
        this.SetPropertyValue<bool?>(nameof (isenabledforallroles), value, nameof (isenabledforallroles));
      }
    }

    [AttributeLogicalName("isexternalfilestorageenabled")]
    public bool? isexternalfilestorageenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (isexternalfilestorageenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (isexternalfilestorageenabled), value, nameof (isexternalfilestorageenabled));
      }
    }

    [AttributeLogicalName("isexternalsearchindexenabled")]
    public bool? isexternalsearchindexenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (isexternalsearchindexenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (isexternalsearchindexenabled), value, nameof (isexternalsearchindexenabled));
      }
    }

    [AttributeLogicalName("isfiscalperiodmonthbased")]
    public bool? isfiscalperiodmonthbased
    {
      get => this.GetPropertyValue<bool?>(nameof (isfiscalperiodmonthbased));
      set
      {
        this.SetPropertyValue<bool?>(nameof (isfiscalperiodmonthbased), value, nameof (isfiscalperiodmonthbased));
      }
    }

    [AttributeLogicalName("isfolderautocreatedonsp")]
    public bool? isfolderautocreatedonsp
    {
      get => this.GetPropertyValue<bool?>(nameof (isfolderautocreatedonsp));
      set
      {
        this.SetPropertyValue<bool?>(nameof (isfolderautocreatedonsp), value, nameof (isfolderautocreatedonsp));
      }
    }

    [AttributeLogicalName("isfolderbasedtrackingenabled")]
    public bool? isfolderbasedtrackingenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (isfolderbasedtrackingenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (isfolderbasedtrackingenabled), value, nameof (isfolderbasedtrackingenabled));
      }
    }

    [AttributeLogicalName("isfulltextsearchenabled")]
    public bool? isfulltextsearchenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (isfulltextsearchenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (isfulltextsearchenabled), value, nameof (isfulltextsearchenabled));
      }
    }

    [AttributeLogicalName("isgeospatialazuremapsintegrationenabled")]
    public bool? isgeospatialazuremapsintegrationenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (isgeospatialazuremapsintegrationenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (isgeospatialazuremapsintegrationenabled), value, nameof (isgeospatialazuremapsintegrationenabled));
      }
    }

    [AttributeLogicalName("ishierarchicalsecuritymodelenabled")]
    public bool? ishierarchicalsecuritymodelenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (ishierarchicalsecuritymodelenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (ishierarchicalsecuritymodelenabled), value, nameof (ishierarchicalsecuritymodelenabled));
      }
    }

    [AttributeLogicalName("isluisenabledford365bot")]
    public bool? isluisenabledford365bot
    {
      get => this.GetPropertyValue<bool?>(nameof (isluisenabledford365bot));
      set
      {
        this.SetPropertyValue<bool?>(nameof (isluisenabledford365bot), value, nameof (isluisenabledford365bot));
      }
    }

    [AttributeLogicalName("ismailboxforcedunlockingenabled")]
    public bool? ismailboxforcedunlockingenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (ismailboxforcedunlockingenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (ismailboxforcedunlockingenabled), value, nameof (ismailboxforcedunlockingenabled));
      }
    }

    [AttributeLogicalName("ismailboxinactivebackoffenabled")]
    public bool? ismailboxinactivebackoffenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (ismailboxinactivebackoffenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (ismailboxinactivebackoffenabled), value, nameof (ismailboxinactivebackoffenabled));
      }
    }

    [AttributeLogicalName("ismanualsalesforecastingenabled")]
    public bool? ismanualsalesforecastingenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (ismanualsalesforecastingenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (ismanualsalesforecastingenabled), value, nameof (ismanualsalesforecastingenabled));
      }
    }

    [AttributeLogicalName("ismobileclientondemandsyncenabled")]
    public bool? ismobileclientondemandsyncenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (ismobileclientondemandsyncenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (ismobileclientondemandsyncenabled), value, nameof (ismobileclientondemandsyncenabled));
      }
    }

    [AttributeLogicalName("ismobileofflineenabled")]
    public bool? ismobileofflineenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (ismobileofflineenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (ismobileofflineenabled), value, nameof (ismobileofflineenabled));
      }
    }

    [AttributeLogicalName("ismodeldrivenappsinmsteamsenabled")]
    public bool? ismodeldrivenappsinmsteamsenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (ismodeldrivenappsinmsteamsenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (ismodeldrivenappsinmsteamsenabled), value, nameof (ismodeldrivenappsinmsteamsenabled));
      }
    }

    [AttributeLogicalName("ismsteamscollaborationenabled")]
    public bool? ismsteamscollaborationenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (ismsteamscollaborationenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (ismsteamscollaborationenabled), value, nameof (ismsteamscollaborationenabled));
      }
    }

    [AttributeLogicalName("ismsteamsenabled")]
    public bool? ismsteamsenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (ismsteamsenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (ismsteamsenabled), value, nameof (ismsteamsenabled));
      }
    }

    [AttributeLogicalName("ismsteamssettingchangedbyuser")]
    public bool? ismsteamssettingchangedbyuser
    {
      get => this.GetPropertyValue<bool?>(nameof (ismsteamssettingchangedbyuser));
      set
      {
        this.SetPropertyValue<bool?>(nameof (ismsteamssettingchangedbyuser), value, nameof (ismsteamssettingchangedbyuser));
      }
    }

    [AttributeLogicalName("ismsteamsusersyncenabled")]
    public bool? ismsteamsusersyncenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (ismsteamsusersyncenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (ismsteamsusersyncenabled), value, nameof (ismsteamsusersyncenabled));
      }
    }

    [AttributeLogicalName("isnewaddproductexperienceenabled")]
    public bool? isnewaddproductexperienceenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (isnewaddproductexperienceenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (isnewaddproductexperienceenabled), value, nameof (isnewaddproductexperienceenabled));
      }
    }

    [AttributeLogicalName("isnotesanalysisenabled")]
    public bool? isnotesanalysisenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (isnotesanalysisenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (isnotesanalysisenabled), value, nameof (isnotesanalysisenabled));
      }
    }

    [AttributeLogicalName("isofficegraphenabled")]
    public bool? isofficegraphenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (isofficegraphenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (isofficegraphenabled), value, nameof (isofficegraphenabled));
      }
    }

    [AttributeLogicalName("isonedriveenabled")]
    public bool? isonedriveenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (isonedriveenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (isonedriveenabled), value, nameof (isonedriveenabled));
      }
    }

    [AttributeLogicalName("ispaienabled")]
    public bool? ispaienabled
    {
      get => this.GetPropertyValue<bool?>(nameof (ispaienabled));
      set => this.SetPropertyValue<bool?>(nameof (ispaienabled), value, nameof (ispaienabled));
    }

    [AttributeLogicalName("ispdfgenerationenabled")]
    public string ispdfgenerationenabled
    {
      get => this.GetPropertyValue<string>(nameof (ispdfgenerationenabled));
      set
      {
        this.SetPropertyValue(nameof (ispdfgenerationenabled), value, 1000, nameof (ispdfgenerationenabled));
      }
    }

    [AttributeLogicalName("isplaybookenabled")]
    public bool? isplaybookenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (isplaybookenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (isplaybookenabled), value, nameof (isplaybookenabled));
      }
    }

    [AttributeLogicalName("ispresenceenabled")]
    public bool? ispresenceenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (ispresenceenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (ispresenceenabled), value, nameof (ispresenceenabled));
      }
    }

    [AttributeLogicalName("ispreviewenabledforactioncard")]
    public bool? ispreviewenabledforactioncard
    {
      get => this.GetPropertyValue<bool?>(nameof (ispreviewenabledforactioncard));
      set
      {
        this.SetPropertyValue<bool?>(nameof (ispreviewenabledforactioncard), value, nameof (ispreviewenabledforactioncard));
      }
    }

    [AttributeLogicalName("ispreviewforautocaptureenabled")]
    public bool? ispreviewforautocaptureenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (ispreviewforautocaptureenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (ispreviewforautocaptureenabled), value, nameof (ispreviewforautocaptureenabled));
      }
    }

    [AttributeLogicalName("ispreviewforemailmonitoringallowed")]
    public bool? ispreviewforemailmonitoringallowed
    {
      get => this.GetPropertyValue<bool?>(nameof (ispreviewforemailmonitoringallowed));
      set
      {
        this.SetPropertyValue<bool?>(nameof (ispreviewforemailmonitoringallowed), value, nameof (ispreviewforemailmonitoringallowed));
      }
    }

    [AttributeLogicalName("ispricelistmandatory")]
    public bool? ispricelistmandatory
    {
      get => this.GetPropertyValue<bool?>(nameof (ispricelistmandatory));
      set
      {
        this.SetPropertyValue<bool?>(nameof (ispricelistmandatory), value, nameof (ispricelistmandatory));
      }
    }

    [AttributeLogicalName("isquickcreateenabledforopportunityclose")]
    public bool? isquickcreateenabledforopportunityclose
    {
      get => this.GetPropertyValue<bool?>(nameof (isquickcreateenabledforopportunityclose));
      set
      {
        this.SetPropertyValue<bool?>(nameof (isquickcreateenabledforopportunityclose), value, nameof (isquickcreateenabledforopportunityclose));
      }
    }

    [AttributeLogicalName("isreadauditenabled")]
    public bool? isreadauditenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (isreadauditenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (isreadauditenabled), value, nameof (isreadauditenabled));
      }
    }

    [AttributeLogicalName("isrelationshipinsightsenabled")]
    public bool? isrelationshipinsightsenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (isrelationshipinsightsenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (isrelationshipinsightsenabled), value, nameof (isrelationshipinsightsenabled));
      }
    }

    [AttributeLogicalName("isresourcebookingexchangesyncenabled")]
    public bool? isresourcebookingexchangesyncenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (isresourcebookingexchangesyncenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (isresourcebookingexchangesyncenabled), value, nameof (isresourcebookingexchangesyncenabled));
      }
    }

    [AttributeLogicalName("isrichtextnotesenabled")]
    public bool? isrichtextnotesenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (isrichtextnotesenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (isrichtextnotesenabled), value, nameof (isrichtextnotesenabled));
      }
    }

    [AttributeLogicalName("issalesassistantenabled")]
    public bool? issalesassistantenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (issalesassistantenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (issalesassistantenabled), value, nameof (issalesassistantenabled));
      }
    }

    [AttributeLogicalName("issopintegrationenabled")]
    public bool? issopintegrationenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (issopintegrationenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (issopintegrationenabled), value, nameof (issopintegrationenabled));
      }
    }

    [AttributeLogicalName("istextwrapenabled")]
    public bool? istextwrapenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (istextwrapenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (istextwrapenabled), value, nameof (istextwrapenabled));
      }
    }

    [AttributeLogicalName("isuseraccessauditenabled")]
    public bool? isuseraccessauditenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (isuseraccessauditenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (isuseraccessauditenabled), value, nameof (isuseraccessauditenabled));
      }
    }

    [AttributeLogicalName("isvintegrationcode")]
    public OptionSetValue isvintegrationcode
    {
      get => this.GetPropertyValue<OptionSetValue>(nameof (isvintegrationcode));
      set
      {
        this.SetPropertyValue<OptionSetValue>(nameof (isvintegrationcode), value, nameof (isvintegrationcode));
      }
    }

    [AttributeLogicalName("iswriteinproductsallowed")]
    public bool? iswriteinproductsallowed
    {
      get => this.GetPropertyValue<bool?>(nameof (iswriteinproductsallowed));
      set
      {
        this.SetPropertyValue<bool?>(nameof (iswriteinproductsallowed), value, nameof (iswriteinproductsallowed));
      }
    }

    [AttributeLogicalName("kaprefix")]
    public string kaprefix
    {
      get => this.GetPropertyValue<string>(nameof (kaprefix));
      set => this.SetPropertyValue(nameof (kaprefix), value, 20, nameof (kaprefix));
    }

    [AttributeLogicalName("kbprefix")]
    public string kbprefix
    {
      get => this.GetPropertyValue<string>(nameof (kbprefix));
      set => this.SetPropertyValue(nameof (kbprefix), value, 20, nameof (kbprefix));
    }

    [AttributeLogicalName("kmsettings")]
    public string kmsettings
    {
      get => this.GetPropertyValue<string>(nameof (kmsettings));
      set => this.SetPropertyValue(nameof (kmsettings), value, 1073741823, nameof (kmsettings));
    }

    [AttributeLogicalName("languagecode")]
    public int? languagecode
    {
      get => this.GetPropertyValue<int?>(nameof (languagecode));
      set
      {
        this.SetPropertyValue(nameof (languagecode), value, 0, int.MaxValue, nameof (languagecode));
      }
    }

    [AttributeLogicalName("localeid")]
    public int? localeid
    {
      get => this.GetPropertyValue<int?>(nameof (localeid));
      set => this.SetPropertyValue(nameof (localeid), value, 0, int.MaxValue, nameof (localeid));
    }

    [AttributeLogicalName("longdateformatcode")]
    public int? longdateformatcode
    {
      get => this.GetPropertyValue<int?>(nameof (longdateformatcode));
      set
      {
        this.SetPropertyValue(nameof (longdateformatcode), value, int.MinValue, int.MaxValue, nameof (longdateformatcode));
      }
    }

    [AttributeLogicalName("mailboxintermittentissueminrange")]
    public int? mailboxintermittentissueminrange
    {
      get => this.GetPropertyValue<int?>(nameof (mailboxintermittentissueminrange));
      set
      {
        this.SetPropertyValue(nameof (mailboxintermittentissueminrange), value, int.MinValue, int.MaxValue, nameof (mailboxintermittentissueminrange));
      }
    }

    [AttributeLogicalName("mailboxpermanentissueminrange")]
    public int? mailboxpermanentissueminrange
    {
      get => this.GetPropertyValue<int?>(nameof (mailboxpermanentissueminrange));
      set
      {
        this.SetPropertyValue(nameof (mailboxpermanentissueminrange), value, int.MinValue, int.MaxValue, nameof (mailboxpermanentissueminrange));
      }
    }

    [AttributeLogicalName("maxactionstepsinbpf")]
    public int? maxactionstepsinbpf
    {
      get => this.GetPropertyValue<int?>(nameof (maxactionstepsinbpf));
      set
      {
        this.SetPropertyValue(nameof (maxactionstepsinbpf), value, 0, 100, nameof (maxactionstepsinbpf));
      }
    }

    [AttributeLogicalName("maxappointmentdurationdays")]
    public int? maxappointmentdurationdays
    {
      get => this.GetPropertyValue<int?>(nameof (maxappointmentdurationdays));
      set
      {
        this.SetPropertyValue(nameof (maxappointmentdurationdays), value, 0, int.MaxValue, nameof (maxappointmentdurationdays));
      }
    }

    [AttributeLogicalName("maxconditionsformobileofflinefilters")]
    public int? maxconditionsformobileofflinefilters
    {
      get => this.GetPropertyValue<int?>(nameof (maxconditionsformobileofflinefilters));
      set
      {
        this.SetPropertyValue(nameof (maxconditionsformobileofflinefilters), value, 0, int.MaxValue, nameof (maxconditionsformobileofflinefilters));
      }
    }

    [AttributeLogicalName("maxdepthforhierarchicalsecuritymodel")]
    public int? maxdepthforhierarchicalsecuritymodel
    {
      get => this.GetPropertyValue<int?>(nameof (maxdepthforhierarchicalsecuritymodel));
      set
      {
        this.SetPropertyValue(nameof (maxdepthforhierarchicalsecuritymodel), value, int.MinValue, int.MaxValue, nameof (maxdepthforhierarchicalsecuritymodel));
      }
    }

    [AttributeLogicalName("maxfolderbasedtrackingmappings")]
    public int? maxfolderbasedtrackingmappings
    {
      get => this.GetPropertyValue<int?>(nameof (maxfolderbasedtrackingmappings));
      set
      {
        this.SetPropertyValue(nameof (maxfolderbasedtrackingmappings), value, 1, 25, nameof (maxfolderbasedtrackingmappings));
      }
    }

    [AttributeLogicalName("maximumactivebusinessprocessflowsallowedperentity")]
    public int? maximumactivebusinessprocessflowsallowedperentity
    {
      get
      {
        return this.GetPropertyValue<int?>(nameof (maximumactivebusinessprocessflowsallowedperentity));
      }
      set
      {
        this.SetPropertyValue(nameof (maximumactivebusinessprocessflowsallowedperentity), value, 1, int.MaxValue, nameof (maximumactivebusinessprocessflowsallowedperentity));
      }
    }

    [AttributeLogicalName("maximumdynamicpropertiesallowed")]
    public int? maximumdynamicpropertiesallowed
    {
      get => this.GetPropertyValue<int?>(nameof (maximumdynamicpropertiesallowed));
      set
      {
        this.SetPropertyValue(nameof (maximumdynamicpropertiesallowed), value, 0, int.MaxValue, nameof (maximumdynamicpropertiesallowed));
      }
    }

    [AttributeLogicalName("maximumentitieswithactivesla")]
    public int? maximumentitieswithactivesla
    {
      get => this.GetPropertyValue<int?>(nameof (maximumentitieswithactivesla));
      set
      {
        this.SetPropertyValue(nameof (maximumentitieswithactivesla), value, 0, int.MaxValue, nameof (maximumentitieswithactivesla));
      }
    }

    [AttributeLogicalName("maximumslakpiperentitywithactivesla")]
    public int? maximumslakpiperentitywithactivesla
    {
      get => this.GetPropertyValue<int?>(nameof (maximumslakpiperentitywithactivesla));
      set
      {
        this.SetPropertyValue(nameof (maximumslakpiperentitywithactivesla), value, 0, int.MaxValue, nameof (maximumslakpiperentitywithactivesla));
      }
    }

    [AttributeLogicalName("maximumtrackingnumber")]
    public int? maximumtrackingnumber
    {
      get => this.GetPropertyValue<int?>(nameof (maximumtrackingnumber));
      set
      {
        this.SetPropertyValue(nameof (maximumtrackingnumber), value, 0, int.MaxValue, nameof (maximumtrackingnumber));
      }
    }

    [AttributeLogicalName("maxproductsinbundle")]
    public int? maxproductsinbundle
    {
      get => this.GetPropertyValue<int?>(nameof (maxproductsinbundle));
      set
      {
        this.SetPropertyValue(nameof (maxproductsinbundle), value, 0, int.MaxValue, nameof (maxproductsinbundle));
      }
    }

    [AttributeLogicalName("maxrecordsforexporttoexcel")]
    public int? maxrecordsforexporttoexcel
    {
      get => this.GetPropertyValue<int?>(nameof (maxrecordsforexporttoexcel));
      set
      {
        this.SetPropertyValue(nameof (maxrecordsforexporttoexcel), value, 0, int.MaxValue, nameof (maxrecordsforexporttoexcel));
      }
    }

    [AttributeLogicalName("maxrecordsforlookupfilters")]
    public int? maxrecordsforlookupfilters
    {
      get => this.GetPropertyValue<int?>(nameof (maxrecordsforlookupfilters));
      set
      {
        this.SetPropertyValue(nameof (maxrecordsforlookupfilters), value, 0, int.MaxValue, nameof (maxrecordsforlookupfilters));
      }
    }

    [AttributeLogicalName("maxslaitemspersla")]
    public int? maxslaitemspersla
    {
      get => this.GetPropertyValue<int?>(nameof (maxslaitemspersla));
      set
      {
        this.SetPropertyValue(nameof (maxslaitemspersla), value, 0, int.MaxValue, nameof (maxslaitemspersla));
      }
    }

    [AttributeLogicalName("maxsupportedinternetexplorerversion")]
    public int? maxsupportedinternetexplorerversion
    {
      get => this.GetPropertyValue<int?>(nameof (maxsupportedinternetexplorerversion));
    }

    [AttributeLogicalName("maxuploadfilesize")]
    public int? maxuploadfilesize
    {
      get => this.GetPropertyValue<int?>(nameof (maxuploadfilesize));
      set
      {
        this.SetPropertyValue(nameof (maxuploadfilesize), value, 0, int.MaxValue, nameof (maxuploadfilesize));
      }
    }

    [AttributeLogicalName("maxverboseloggingmailbox")]
    public int? maxverboseloggingmailbox
    {
      get => this.GetPropertyValue<int?>(nameof (maxverboseloggingmailbox));
    }

    [AttributeLogicalName("maxverboseloggingsynccycles")]
    public int? maxverboseloggingsynccycles
    {
      get => this.GetPropertyValue<int?>(nameof (maxverboseloggingsynccycles));
    }

    [AttributeLogicalName("metadatasynclasttimeofneverexpireddeletedobjects")]
    public DateTime? metadatasynclasttimeofneverexpireddeletedobjects
    {
      get
      {
        return this.GetPropertyValue<DateTime?>(nameof (metadatasynclasttimeofneverexpireddeletedobjects));
      }
    }

    [AttributeLogicalName("metadatasynctimestamp")]
    public int? metadatasynctimestamp
    {
      get => this.GetPropertyValue<int?>(nameof (metadatasynctimestamp));
    }

    [AttributeLogicalName("microsoftflowenvironment")]
    public string microsoftflowenvironment
    {
      get => this.GetPropertyValue<string>(nameof (microsoftflowenvironment));
      set
      {
        this.SetPropertyValue(nameof (microsoftflowenvironment), value, 1024, nameof (microsoftflowenvironment));
      }
    }

    [AttributeLogicalName("minaddressbooksyncinterval")]
    public int? minaddressbooksyncinterval
    {
      get => this.GetPropertyValue<int?>(nameof (minaddressbooksyncinterval));
      set
      {
        this.SetPropertyValue(nameof (minaddressbooksyncinterval), value, int.MinValue, int.MaxValue, nameof (minaddressbooksyncinterval));
      }
    }

    [AttributeLogicalName("minofflinesyncinterval")]
    public int? minofflinesyncinterval
    {
      get => this.GetPropertyValue<int?>(nameof (minofflinesyncinterval));
      set
      {
        this.SetPropertyValue(nameof (minofflinesyncinterval), value, int.MinValue, int.MaxValue, nameof (minofflinesyncinterval));
      }
    }

    [AttributeLogicalName("minoutlooksyncinterval")]
    public int? minoutlooksyncinterval
    {
      get => this.GetPropertyValue<int?>(nameof (minoutlooksyncinterval));
      set
      {
        this.SetPropertyValue(nameof (minoutlooksyncinterval), value, 0, int.MaxValue, nameof (minoutlooksyncinterval));
      }
    }

    [AttributeLogicalName("mobileofflineminlicenseprod")]
    public int? mobileofflineminlicenseprod
    {
      get => this.GetPropertyValue<int?>(nameof (mobileofflineminlicenseprod));
    }

    [AttributeLogicalName("mobileofflineminlicensetrial")]
    public int? mobileofflineminlicensetrial
    {
      get => this.GetPropertyValue<int?>(nameof (mobileofflineminlicensetrial));
    }

    [AttributeLogicalName("mobileofflinesyncinterval")]
    public int? mobileofflinesyncinterval
    {
      get => this.GetPropertyValue<int?>(nameof (mobileofflinesyncinterval));
      set
      {
        this.SetPropertyValue(nameof (mobileofflinesyncinterval), value, 0, int.MaxValue, nameof (mobileofflinesyncinterval));
      }
    }

    [AttributeLogicalName("modifiedby")]
    public EntityReference modifiedby
    {
      get => this.GetPropertyValue<EntityReference>(nameof (modifiedby));
    }

    [AttributeLogicalName("modifiedbyname")]
    public string modifiedbyname => this.GetPropertyValue<string>(nameof (modifiedbyname));

    [AttributeLogicalName("modifiedbyyominame")]
    public string modifiedbyyominame => this.GetPropertyValue<string>(nameof (modifiedbyyominame));

    [AttributeLogicalName("modifiedon")]
    public DateTime? modifiedon => this.GetPropertyValue<DateTime?>(nameof (modifiedon));

    [AttributeLogicalName("modifiedonbehalfby")]
    public EntityReference modifiedonbehalfby
    {
      get => this.GetPropertyValue<EntityReference>(nameof (modifiedonbehalfby));
    }

    [AttributeLogicalName("modifiedonbehalfbyname")]
    public string modifiedonbehalfbyname
    {
      get => this.GetPropertyValue<string>(nameof (modifiedonbehalfbyname));
    }

    [AttributeLogicalName("modifiedonbehalfbyyominame")]
    public string modifiedonbehalfbyyominame
    {
      get => this.GetPropertyValue<string>(nameof (modifiedonbehalfbyyominame));
    }

    [AttributeLogicalName("name")]
    public string name
    {
      get => this.GetPropertyValue<string>(nameof (name));
      set => this.SetPropertyValue(nameof (name), value, 160, nameof (name));
    }

    [AttributeLogicalName("negativecurrencyformatcode")]
    public int? negativecurrencyformatcode
    {
      get => this.GetPropertyValue<int?>(nameof (negativecurrencyformatcode));
      set
      {
        this.SetPropertyValue(nameof (negativecurrencyformatcode), value, int.MinValue, int.MaxValue, nameof (negativecurrencyformatcode));
      }
    }

    [AttributeLogicalName("negativeformatcode")]
    public OptionSetValue negativeformatcode
    {
      get => this.GetPropertyValue<OptionSetValue>(nameof (negativeformatcode));
      set
      {
        this.SetPropertyValue<OptionSetValue>(nameof (negativeformatcode), value, nameof (negativeformatcode));
      }
    }

    [AttributeLogicalName("nextcustomobjecttypecode")]
    public int? nextcustomobjecttypecode
    {
      get => this.GetPropertyValue<int?>(nameof (nextcustomobjecttypecode));
    }

    [AttributeLogicalName("nexttrackingnumber")]
    public int? nexttrackingnumber
    {
      get => this.GetPropertyValue<int?>(nameof (nexttrackingnumber));
      set
      {
        this.SetPropertyValue(nameof (nexttrackingnumber), value, int.MinValue, int.MaxValue, nameof (nexttrackingnumber));
      }
    }

    [AttributeLogicalName("notifymailboxownerofemailserverlevelalerts")]
    public bool? notifymailboxownerofemailserverlevelalerts
    {
      get => this.GetPropertyValue<bool?>(nameof (notifymailboxownerofemailserverlevelalerts));
      set
      {
        this.SetPropertyValue<bool?>(nameof (notifymailboxownerofemailserverlevelalerts), value, nameof (notifymailboxownerofemailserverlevelalerts));
      }
    }

    [AttributeLogicalName("numberformat")]
    public string numberformat
    {
      get => this.GetPropertyValue<string>(nameof (numberformat));
      set => this.SetPropertyValue(nameof (numberformat), value, 2, nameof (numberformat));
    }

    [AttributeLogicalName("numbergroupformat")]
    public string numbergroupformat
    {
      get => this.GetPropertyValue<string>(nameof (numbergroupformat));
      set
      {
        this.SetPropertyValue(nameof (numbergroupformat), value, 50, nameof (numbergroupformat));
      }
    }

    [AttributeLogicalName("numberseparator")]
    public string numberseparator
    {
      get => this.GetPropertyValue<string>(nameof (numberseparator));
      set => this.SetPropertyValue(nameof (numberseparator), value, 5, nameof (numberseparator));
    }

    [AttributeLogicalName("officeappsautodeploymentenabled")]
    public bool? officeappsautodeploymentenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (officeappsautodeploymentenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (officeappsautodeploymentenabled), value, nameof (officeappsautodeploymentenabled));
      }
    }

    [AttributeLogicalName("officegraphdelveurl")]
    public string officegraphdelveurl
    {
      get => this.GetPropertyValue<string>(nameof (officegraphdelveurl));
      set
      {
        this.SetPropertyValue(nameof (officegraphdelveurl), value, 1000, nameof (officegraphdelveurl));
      }
    }

    [AttributeLogicalName("oobpricecalculationenabled")]
    public bool? oobpricecalculationenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (oobpricecalculationenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (oobpricecalculationenabled), value, nameof (oobpricecalculationenabled));
      }
    }

    [AttributeLogicalName("orderprefix")]
    public string orderprefix
    {
      get => this.GetPropertyValue<string>(nameof (orderprefix));
      set => this.SetPropertyValue(nameof (orderprefix), value, 20, nameof (orderprefix));
    }

    [AttributeLogicalName("organizationid")]
    public Guid organizationid
    {
      get => this.Id;
      set
      {
        this.Id = value;
        this.SetPropertyValue<Guid>(nameof (organizationid), value, nameof (organizationid));
      }
    }

    [AttributeLogicalName("organizationstate")]
    public eOrganization_organizationstate? organizationstate
    {
      get
      {
        return this.organizationstate_OptionSetValue != null ? new eOrganization_organizationstate?((eOrganization_organizationstate) this.organizationstate_OptionSetValue.Value) : new eOrganization_organizationstate?();
      }
    }

    [AttributeLogicalName("organizationstate")]
    public OptionSetValue organizationstate_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("organizationstate");
    }

    public string organizationstate_Text(IOrganizationService service)
    {
      return this.organizationstate_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "organizationstate");
    }

    public string organizationstate_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.organizationstate_OptionSetValue.Value);
    }

    [AttributeLogicalName("orgdborgsettings")]
    public string orgdborgsettings
    {
      get => this.GetPropertyValue<string>(nameof (orgdborgsettings));
      set
      {
        this.SetPropertyValue(nameof (orgdborgsettings), value, 1073741823, nameof (orgdborgsettings));
      }
    }

    [AttributeLogicalName("orginsightsenabled")]
    public bool? orginsightsenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (orginsightsenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (orginsightsenabled), value, nameof (orginsightsenabled));
      }
    }

    [AttributeLogicalName("paipreviewscenarioenabled")]
    public bool? paipreviewscenarioenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (paipreviewscenarioenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (paipreviewscenarioenabled), value, nameof (paipreviewscenarioenabled));
      }
    }

    [AttributeLogicalName("parsedtablecolumnprefix")]
    public string parsedtablecolumnprefix
    {
      get => this.GetPropertyValue<string>(nameof (parsedtablecolumnprefix));
    }

    [AttributeLogicalName("parsedtableprefix")]
    public string parsedtableprefix => this.GetPropertyValue<string>(nameof (parsedtableprefix));

    [AttributeLogicalName("pastexpansionwindow")]
    public int? pastexpansionwindow
    {
      get => this.GetPropertyValue<int?>(nameof (pastexpansionwindow));
      set
      {
        this.SetPropertyValue(nameof (pastexpansionwindow), value, 1, 120, nameof (pastexpansionwindow));
      }
    }

    [AttributeLogicalName("picture")]
    public string picture
    {
      get => this.GetPropertyValue<string>(nameof (picture));
      set => this.SetPropertyValue(nameof (picture), value, 1073741823, nameof (picture));
    }

    [AttributeLogicalName("pinpointlanguagecode")]
    public int? pinpointlanguagecode
    {
      get => this.GetPropertyValue<int?>(nameof (pinpointlanguagecode));
      set
      {
        this.SetPropertyValue(nameof (pinpointlanguagecode), value, 0, int.MaxValue, nameof (pinpointlanguagecode));
      }
    }

    [AttributeLogicalName("plugintracelogsetting")]
    public OptionSetValue plugintracelogsetting
    {
      get => this.GetPropertyValue<OptionSetValue>(nameof (plugintracelogsetting));
      set
      {
        this.SetPropertyValue<OptionSetValue>(nameof (plugintracelogsetting), value, nameof (plugintracelogsetting));
      }
    }

    [AttributeLogicalName("pmdesignator")]
    public string pmdesignator
    {
      get => this.GetPropertyValue<string>(nameof (pmdesignator));
      set => this.SetPropertyValue(nameof (pmdesignator), value, 25, nameof (pmdesignator));
    }

    [AttributeLogicalName("postmessagewhitelistdomains")]
    public string postmessagewhitelistdomains
    {
      get => this.GetPropertyValue<string>(nameof (postmessagewhitelistdomains));
      set
      {
        this.SetPropertyValue(nameof (postmessagewhitelistdomains), value, 500, nameof (postmessagewhitelistdomains));
      }
    }

    [AttributeLogicalName("powerbifeatureenabled")]
    public bool? powerbifeatureenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (powerbifeatureenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (powerbifeatureenabled), value, nameof (powerbifeatureenabled));
      }
    }

    [AttributeLogicalName("pricingdecimalprecision")]
    public int? pricingdecimalprecision
    {
      get => this.GetPropertyValue<int?>(nameof (pricingdecimalprecision));
      set
      {
        this.SetPropertyValue(nameof (pricingdecimalprecision), value, 0, 4, nameof (pricingdecimalprecision));
      }
    }

    [AttributeLogicalName("privacystatementurl")]
    public string privacystatementurl
    {
      get => this.GetPropertyValue<string>(nameof (privacystatementurl));
      set
      {
        this.SetPropertyValue(nameof (privacystatementurl), value, 500, nameof (privacystatementurl));
      }
    }

    [AttributeLogicalName("privilegeusergroupid")]
    public Guid privilegeusergroupid
    {
      get => this.GetPropertyValue<Guid>(nameof (privilegeusergroupid));
      set
      {
        this.SetPropertyValue<Guid>(nameof (privilegeusergroupid), value, nameof (privilegeusergroupid));
      }
    }

    [AttributeLogicalName("privreportinggroupid")]
    public Guid privreportinggroupid
    {
      get => this.GetPropertyValue<Guid>(nameof (privreportinggroupid));
      set
      {
        this.SetPropertyValue<Guid>(nameof (privreportinggroupid), value, nameof (privreportinggroupid));
      }
    }

    [AttributeLogicalName("privreportinggroupname")]
    public string privreportinggroupname
    {
      get => this.GetPropertyValue<string>(nameof (privreportinggroupname));
      set
      {
        this.SetPropertyValue(nameof (privreportinggroupname), value, 256, nameof (privreportinggroupname));
      }
    }

    [AttributeLogicalName("productrecommendationsenabled")]
    public bool? productrecommendationsenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (productrecommendationsenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (productrecommendationsenabled), value, nameof (productrecommendationsenabled));
      }
    }

    [AttributeLogicalName("qualifyleadadditionaloptions")]
    public string qualifyleadadditionaloptions
    {
      get => this.GetPropertyValue<string>(nameof (qualifyleadadditionaloptions));
      set
      {
        this.SetPropertyValue(nameof (qualifyleadadditionaloptions), value, 1000, nameof (qualifyleadadditionaloptions));
      }
    }

    [AttributeLogicalName("quickfindrecordlimitenabled")]
    public bool? quickfindrecordlimitenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (quickfindrecordlimitenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (quickfindrecordlimitenabled), value, nameof (quickfindrecordlimitenabled));
      }
    }

    [AttributeLogicalName("quoteprefix")]
    public string quoteprefix
    {
      get => this.GetPropertyValue<string>(nameof (quoteprefix));
      set => this.SetPropertyValue(nameof (quoteprefix), value, 20, nameof (quoteprefix));
    }

    [AttributeLogicalName("recurrencedefaultnumberofoccurrences")]
    public int? recurrencedefaultnumberofoccurrences
    {
      get => this.GetPropertyValue<int?>(nameof (recurrencedefaultnumberofoccurrences));
      set
      {
        this.SetPropertyValue(nameof (recurrencedefaultnumberofoccurrences), value, 1, 999, nameof (recurrencedefaultnumberofoccurrences));
      }
    }

    [AttributeLogicalName("recurrenceexpansionjobbatchinterval")]
    public int? recurrenceexpansionjobbatchinterval
    {
      get => this.GetPropertyValue<int?>(nameof (recurrenceexpansionjobbatchinterval));
      set
      {
        this.SetPropertyValue(nameof (recurrenceexpansionjobbatchinterval), value, 0, int.MaxValue, nameof (recurrenceexpansionjobbatchinterval));
      }
    }

    [AttributeLogicalName("recurrenceexpansionjobbatchsize")]
    public int? recurrenceexpansionjobbatchsize
    {
      get => this.GetPropertyValue<int?>(nameof (recurrenceexpansionjobbatchsize));
      set
      {
        this.SetPropertyValue(nameof (recurrenceexpansionjobbatchsize), value, 0, int.MaxValue, nameof (recurrenceexpansionjobbatchsize));
      }
    }

    [AttributeLogicalName("recurrenceexpansionsynchcreatemax")]
    public int? recurrenceexpansionsynchcreatemax
    {
      get => this.GetPropertyValue<int?>(nameof (recurrenceexpansionsynchcreatemax));
      set
      {
        this.SetPropertyValue(nameof (recurrenceexpansionsynchcreatemax), value, 1, 1000, nameof (recurrenceexpansionsynchcreatemax));
      }
    }

    [AttributeLogicalName("referencesitemapxml")]
    public string referencesitemapxml
    {
      get => this.GetPropertyValue<string>(nameof (referencesitemapxml));
      set
      {
        this.SetPropertyValue(nameof (referencesitemapxml), value, 1073741823, nameof (referencesitemapxml));
      }
    }

    [AttributeLogicalName("rendersecureiframeforemail")]
    public bool? rendersecureiframeforemail
    {
      get => this.GetPropertyValue<bool?>(nameof (rendersecureiframeforemail));
      set
      {
        this.SetPropertyValue<bool?>(nameof (rendersecureiframeforemail), value, nameof (rendersecureiframeforemail));
      }
    }

    [AttributeLogicalName("reportinggroupid")]
    public Guid reportinggroupid
    {
      get => this.GetPropertyValue<Guid>(nameof (reportinggroupid));
      set
      {
        this.SetPropertyValue<Guid>(nameof (reportinggroupid), value, nameof (reportinggroupid));
      }
    }

    [AttributeLogicalName("reportinggroupname")]
    public string reportinggroupname
    {
      get => this.GetPropertyValue<string>(nameof (reportinggroupname));
      set
      {
        this.SetPropertyValue(nameof (reportinggroupname), value, 256, nameof (reportinggroupname));
      }
    }

    [AttributeLogicalName("reportscripterrors")]
    public eOrganization_reportscripterrors? reportscripterrors
    {
      get
      {
        return this.reportscripterrors_OptionSetValue != null ? new eOrganization_reportscripterrors?((eOrganization_reportscripterrors) this.reportscripterrors_OptionSetValue.Value) : new eOrganization_reportscripterrors?();
      }
      set
      {
        if (value.HasValue)
          this.reportscripterrors_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.reportscripterrors_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("reportscripterrors")]
    public OptionSetValue reportscripterrors_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("reportscripterrors");
      set
      {
        this.SetPropertyValue<OptionSetValue>("reportscripterrors", value, nameof (reportscripterrors_OptionSetValue));
      }
    }

    public string reportscripterrors_Text(IOrganizationService service)
    {
      return this.reportscripterrors_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "reportscripterrors");
    }

    public string reportscripterrors_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.reportscripterrors_OptionSetValue.Value);
    }

    [AttributeLogicalName("requireapprovalforqueueemail")]
    public bool? requireapprovalforqueueemail
    {
      get => this.GetPropertyValue<bool?>(nameof (requireapprovalforqueueemail));
      set
      {
        this.SetPropertyValue<bool?>(nameof (requireapprovalforqueueemail), value, nameof (requireapprovalforqueueemail));
      }
    }

    [AttributeLogicalName("requireapprovalforuseremail")]
    public bool? requireapprovalforuseremail
    {
      get => this.GetPropertyValue<bool?>(nameof (requireapprovalforuseremail));
      set
      {
        this.SetPropertyValue<bool?>(nameof (requireapprovalforuseremail), value, nameof (requireapprovalforuseremail));
      }
    }

    [AttributeLogicalName("resolvesimilarunresolvedemailaddress")]
    public bool? resolvesimilarunresolvedemailaddress
    {
      get => this.GetPropertyValue<bool?>(nameof (resolvesimilarunresolvedemailaddress));
      set
      {
        this.SetPropertyValue<bool?>(nameof (resolvesimilarunresolvedemailaddress), value, nameof (resolvesimilarunresolvedemailaddress));
      }
    }

    [AttributeLogicalName("restrictstatusupdate")]
    public bool? restrictstatusupdate
    {
      get => this.GetPropertyValue<bool?>(nameof (restrictstatusupdate));
      set
      {
        this.SetPropertyValue<bool?>(nameof (restrictstatusupdate), value, nameof (restrictstatusupdate));
      }
    }

    [AttributeLogicalName("rierrorstatus")]
    public int? rierrorstatus
    {
      get => this.GetPropertyValue<int?>(nameof (rierrorstatus));
      set
      {
        this.SetPropertyValue(nameof (rierrorstatus), value, 0, int.MaxValue, nameof (rierrorstatus));
      }
    }

    [AttributeLogicalName("sampledataimportid")]
    public Guid sampledataimportid
    {
      get => this.GetPropertyValue<Guid>(nameof (sampledataimportid));
      set
      {
        this.SetPropertyValue<Guid>(nameof (sampledataimportid), value, nameof (sampledataimportid));
      }
    }

    [AttributeLogicalName("schedulingengine")]
    public eOrganization_schedulingengine? schedulingengine
    {
      get
      {
        return this.schedulingengine_OptionSetValue != null ? new eOrganization_schedulingengine?((eOrganization_schedulingengine) this.schedulingengine_OptionSetValue.Value) : new eOrganization_schedulingengine?();
      }
      set
      {
        if (value.HasValue)
          this.schedulingengine_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.schedulingengine_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("schedulingengine")]
    public OptionSetValue schedulingengine_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("schedulingengine");
      set
      {
        this.SetPropertyValue<OptionSetValue>("schedulingengine", value, nameof (schedulingengine_OptionSetValue));
      }
    }

    public string schedulingengine_Text(IOrganizationService service)
    {
      return this.schedulingengine_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "schedulingengine");
    }

    public string schedulingengine_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.schedulingengine_OptionSetValue.Value);
    }

    [AttributeLogicalName("schemanameprefix")]
    public string schemanameprefix
    {
      get => this.GetPropertyValue<string>(nameof (schemanameprefix));
      set => this.SetPropertyValue(nameof (schemanameprefix), value, 8, nameof (schemanameprefix));
    }

    [AttributeLogicalName("sendbulkemailinuci")]
    public bool? sendbulkemailinuci
    {
      get => this.GetPropertyValue<bool?>(nameof (sendbulkemailinuci));
      set
      {
        this.SetPropertyValue<bool?>(nameof (sendbulkemailinuci), value, nameof (sendbulkemailinuci));
      }
    }

    [AttributeLogicalName("servestaticresourcesfromazurecdn")]
    public bool? servestaticresourcesfromazurecdn
    {
      get => this.GetPropertyValue<bool?>(nameof (servestaticresourcesfromazurecdn));
      set
      {
        this.SetPropertyValue<bool?>(nameof (servestaticresourcesfromazurecdn), value, nameof (servestaticresourcesfromazurecdn));
      }
    }

    [AttributeLogicalName("sessiontimeoutenabled")]
    public bool? sessiontimeoutenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (sessiontimeoutenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (sessiontimeoutenabled), value, nameof (sessiontimeoutenabled));
      }
    }

    [AttributeLogicalName("sessiontimeoutinmins")]
    public int? sessiontimeoutinmins
    {
      get => this.GetPropertyValue<int?>(nameof (sessiontimeoutinmins));
      set
      {
        this.SetPropertyValue(nameof (sessiontimeoutinmins), value, 0, int.MaxValue, nameof (sessiontimeoutinmins));
      }
    }

    [AttributeLogicalName("sessiontimeoutreminderinmins")]
    public int? sessiontimeoutreminderinmins
    {
      get => this.GetPropertyValue<int?>(nameof (sessiontimeoutreminderinmins));
      set
      {
        this.SetPropertyValue(nameof (sessiontimeoutreminderinmins), value, 0, int.MaxValue, nameof (sessiontimeoutreminderinmins));
      }
    }

    [AttributeLogicalName("sharepointdeploymenttype")]
    public OptionSetValue sharepointdeploymenttype
    {
      get => this.GetPropertyValue<OptionSetValue>(nameof (sharepointdeploymenttype));
      set
      {
        this.SetPropertyValue<OptionSetValue>(nameof (sharepointdeploymenttype), value, nameof (sharepointdeploymenttype));
      }
    }

    [AttributeLogicalName("sharetopreviousowneronassign")]
    public bool? sharetopreviousowneronassign
    {
      get => this.GetPropertyValue<bool?>(nameof (sharetopreviousowneronassign));
      set
      {
        this.SetPropertyValue<bool?>(nameof (sharetopreviousowneronassign), value, nameof (sharetopreviousowneronassign));
      }
    }

    [AttributeLogicalName("showkbarticledeprecationnotification")]
    public bool? showkbarticledeprecationnotification
    {
      get => this.GetPropertyValue<bool?>(nameof (showkbarticledeprecationnotification));
      set
      {
        this.SetPropertyValue<bool?>(nameof (showkbarticledeprecationnotification), value, nameof (showkbarticledeprecationnotification));
      }
    }

    [AttributeLogicalName("showweeknumber")]
    public bool? showweeknumber
    {
      get => this.GetPropertyValue<bool?>(nameof (showweeknumber));
      set => this.SetPropertyValue<bool?>(nameof (showweeknumber), value, nameof (showweeknumber));
    }

    [AttributeLogicalName("signupoutlookdownloadfwlink")]
    public string signupoutlookdownloadfwlink
    {
      get => this.GetPropertyValue<string>(nameof (signupoutlookdownloadfwlink));
      set
      {
        this.SetPropertyValue(nameof (signupoutlookdownloadfwlink), value, 200, nameof (signupoutlookdownloadfwlink));
      }
    }

    [AttributeLogicalName("sitemapxml")]
    public string sitemapxml
    {
      get => this.GetPropertyValue<string>(nameof (sitemapxml));
      set => this.SetPropertyValue(nameof (sitemapxml), value, 1073741823, nameof (sitemapxml));
    }

    [AttributeLogicalName("slapausestates")]
    public string slapausestates
    {
      get => this.GetPropertyValue<string>(nameof (slapausestates));
      set
      {
        this.SetPropertyValue(nameof (slapausestates), value, 1073741823, nameof (slapausestates));
      }
    }

    [AttributeLogicalName("socialinsightsenabled")]
    public bool? socialinsightsenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (socialinsightsenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (socialinsightsenabled), value, nameof (socialinsightsenabled));
      }
    }

    [AttributeLogicalName("socialinsightsinstance")]
    public string socialinsightsinstance
    {
      get => this.GetPropertyValue<string>(nameof (socialinsightsinstance));
      set
      {
        this.SetPropertyValue(nameof (socialinsightsinstance), value, 2048, nameof (socialinsightsinstance));
      }
    }

    [AttributeLogicalName("socialinsightstermsaccepted")]
    public bool? socialinsightstermsaccepted
    {
      get => this.GetPropertyValue<bool?>(nameof (socialinsightstermsaccepted));
      set
      {
        this.SetPropertyValue<bool?>(nameof (socialinsightstermsaccepted), value, nameof (socialinsightstermsaccepted));
      }
    }

    [AttributeLogicalName("sortid")]
    public int? sortid
    {
      get => this.GetPropertyValue<int?>(nameof (sortid));
      set
      {
        this.SetPropertyValue(nameof (sortid), value, int.MinValue, int.MaxValue, nameof (sortid));
      }
    }

    [AttributeLogicalName("sqlaccessgroupid")]
    public Guid sqlaccessgroupid
    {
      get => this.GetPropertyValue<Guid>(nameof (sqlaccessgroupid));
      set
      {
        this.SetPropertyValue<Guid>(nameof (sqlaccessgroupid), value, nameof (sqlaccessgroupid));
      }
    }

    [AttributeLogicalName("sqlaccessgroupname")]
    public string sqlaccessgroupname
    {
      get => this.GetPropertyValue<string>(nameof (sqlaccessgroupname));
      set
      {
        this.SetPropertyValue(nameof (sqlaccessgroupname), value, 256, nameof (sqlaccessgroupname));
      }
    }

    [AttributeLogicalName("sqmenabled")]
    public bool? sqmenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (sqmenabled));
      set => this.SetPropertyValue<bool?>(nameof (sqmenabled), value, nameof (sqmenabled));
    }

    [AttributeLogicalName("supportuserid")]
    public Guid supportuserid
    {
      get => this.GetPropertyValue<Guid>(nameof (supportuserid));
      set => this.SetPropertyValue<Guid>(nameof (supportuserid), value, nameof (supportuserid));
    }

    [AttributeLogicalName("suppresssla")]
    public bool? suppresssla
    {
      get => this.GetPropertyValue<bool?>(nameof (suppresssla));
      set => this.SetPropertyValue<bool?>(nameof (suppresssla), value, nameof (suppresssla));
    }

    [AttributeLogicalName("syncbulkoperationbatchsize")]
    public int? syncbulkoperationbatchsize
    {
      get => this.GetPropertyValue<int?>(nameof (syncbulkoperationbatchsize));
      set
      {
        this.SetPropertyValue(nameof (syncbulkoperationbatchsize), value, 1, 1000, nameof (syncbulkoperationbatchsize));
      }
    }

    [AttributeLogicalName("syncbulkoperationmaxlimit")]
    public int? syncbulkoperationmaxlimit
    {
      get => this.GetPropertyValue<int?>(nameof (syncbulkoperationmaxlimit));
      set
      {
        this.SetPropertyValue(nameof (syncbulkoperationmaxlimit), value, 1, 500000, nameof (syncbulkoperationmaxlimit));
      }
    }

    [AttributeLogicalName("syncoptinselection")]
    public bool? syncoptinselection
    {
      get => this.GetPropertyValue<bool?>(nameof (syncoptinselection));
      set
      {
        this.SetPropertyValue<bool?>(nameof (syncoptinselection), value, nameof (syncoptinselection));
      }
    }

    [AttributeLogicalName("syncoptinselectionstatus")]
    public OptionSetValue syncoptinselectionstatus
    {
      get => this.GetPropertyValue<OptionSetValue>(nameof (syncoptinselectionstatus));
      set
      {
        this.SetPropertyValue<OptionSetValue>(nameof (syncoptinselectionstatus), value, nameof (syncoptinselectionstatus));
      }
    }

    [AttributeLogicalName("systemuserid")]
    public Guid systemuserid
    {
      get => this.GetPropertyValue<Guid>(nameof (systemuserid));
      set => this.SetPropertyValue<Guid>(nameof (systemuserid), value, nameof (systemuserid));
    }

    [AttributeLogicalName("tagmaxaggressivecycles")]
    public int? tagmaxaggressivecycles
    {
      get => this.GetPropertyValue<int?>(nameof (tagmaxaggressivecycles));
      set
      {
        this.SetPropertyValue<int?>(nameof (tagmaxaggressivecycles), value, nameof (tagmaxaggressivecycles));
      }
    }

    [AttributeLogicalName("tagpollingperiod")]
    public int? tagpollingperiod
    {
      get => this.GetPropertyValue<int?>(nameof (tagpollingperiod));
      set
      {
        this.SetPropertyValue(nameof (tagpollingperiod), value, 0, int.MaxValue, nameof (tagpollingperiod));
      }
    }

    [AttributeLogicalName("taskbasedflowenabled")]
    public bool? taskbasedflowenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (taskbasedflowenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (taskbasedflowenabled), value, nameof (taskbasedflowenabled));
      }
    }

    [AttributeLogicalName("textanalyticsenabled")]
    public bool? textanalyticsenabled
    {
      get => this.GetPropertyValue<bool?>(nameof (textanalyticsenabled));
      set
      {
        this.SetPropertyValue<bool?>(nameof (textanalyticsenabled), value, nameof (textanalyticsenabled));
      }
    }

    [AttributeLogicalName("timeformatcode")]
    public OptionSetValue timeformatcode
    {
      get => this.GetPropertyValue<OptionSetValue>(nameof (timeformatcode));
      set
      {
        this.SetPropertyValue<OptionSetValue>(nameof (timeformatcode), value, nameof (timeformatcode));
      }
    }

    [AttributeLogicalName("timeformatstring")]
    public string timeformatstring
    {
      get => this.GetPropertyValue<string>(nameof (timeformatstring));
      set
      {
        this.SetPropertyValue(nameof (timeformatstring), value, (int) byte.MaxValue, nameof (timeformatstring));
      }
    }

    [AttributeLogicalName("timeseparator")]
    public string timeseparator
    {
      get => this.GetPropertyValue<string>(nameof (timeseparator));
      set => this.SetPropertyValue(nameof (timeseparator), value, 5, nameof (timeseparator));
    }

    [AttributeLogicalName("timezoneruleversionnumber")]
    public int? timezoneruleversionnumber
    {
      get => this.GetPropertyValue<int?>(nameof (timezoneruleversionnumber));
      set
      {
        this.SetPropertyValue(nameof (timezoneruleversionnumber), value, -1, int.MaxValue, nameof (timezoneruleversionnumber));
      }
    }

    [AttributeLogicalName("tokenexpiry")]
    public int? tokenexpiry
    {
      get => this.GetPropertyValue<int?>(nameof (tokenexpiry));
      set => this.SetPropertyValue<int?>(nameof (tokenexpiry), value, nameof (tokenexpiry));
    }

    [AttributeLogicalName("tokenkey")]
    public string tokenkey
    {
      get => this.GetPropertyValue<string>(nameof (tokenkey));
      set => this.SetPropertyValue(nameof (tokenkey), value, 90, nameof (tokenkey));
    }

    [AttributeLogicalName("tracelogmaximumageindays")]
    public int? tracelogmaximumageindays
    {
      get => this.GetPropertyValue<int?>(nameof (tracelogmaximumageindays));
      set
      {
        this.SetPropertyValue(nameof (tracelogmaximumageindays), value, 0, int.MaxValue, nameof (tracelogmaximumageindays));
      }
    }

    [AttributeLogicalName("trackingprefix")]
    public string trackingprefix
    {
      get => this.GetPropertyValue<string>(nameof (trackingprefix));
      set => this.SetPropertyValue(nameof (trackingprefix), value, 256, nameof (trackingprefix));
    }

    [AttributeLogicalName("trackingtokenidbase")]
    public int? trackingtokenidbase
    {
      get => this.GetPropertyValue<int?>(nameof (trackingtokenidbase));
      set
      {
        this.SetPropertyValue(nameof (trackingtokenidbase), value, 0, int.MaxValue, nameof (trackingtokenidbase));
      }
    }

    [AttributeLogicalName("trackingtokeniddigits")]
    public int? trackingtokeniddigits
    {
      get => this.GetPropertyValue<int?>(nameof (trackingtokeniddigits));
      set
      {
        this.SetPropertyValue<int?>(nameof (trackingtokeniddigits), value, nameof (trackingtokeniddigits));
      }
    }

    [AttributeLogicalName("uniquespecifierlength")]
    public int? uniquespecifierlength
    {
      get => this.GetPropertyValue<int?>(nameof (uniquespecifierlength));
      set
      {
        this.SetPropertyValue(nameof (uniquespecifierlength), value, 4, 6, nameof (uniquespecifierlength));
      }
    }

    [AttributeLogicalName("unresolveemailaddressifmultiplematch")]
    public bool? unresolveemailaddressifmultiplematch
    {
      get => this.GetPropertyValue<bool?>(nameof (unresolveemailaddressifmultiplematch));
      set
      {
        this.SetPropertyValue<bool?>(nameof (unresolveemailaddressifmultiplematch), value, nameof (unresolveemailaddressifmultiplematch));
      }
    }

    [AttributeLogicalName("useinbuiltrulefordefaultpricelistselection")]
    public bool? useinbuiltrulefordefaultpricelistselection
    {
      get => this.GetPropertyValue<bool?>(nameof (useinbuiltrulefordefaultpricelistselection));
      set
      {
        this.SetPropertyValue<bool?>(nameof (useinbuiltrulefordefaultpricelistselection), value, nameof (useinbuiltrulefordefaultpricelistselection));
      }
    }

    [AttributeLogicalName("uselegacyrendering")]
    public bool? uselegacyrendering
    {
      get => this.GetPropertyValue<bool?>(nameof (uselegacyrendering));
      set
      {
        this.SetPropertyValue<bool?>(nameof (uselegacyrendering), value, nameof (uselegacyrendering));
      }
    }

    [AttributeLogicalName("usepositionhierarchy")]
    public bool? usepositionhierarchy
    {
      get => this.GetPropertyValue<bool?>(nameof (usepositionhierarchy));
      set
      {
        this.SetPropertyValue<bool?>(nameof (usepositionhierarchy), value, nameof (usepositionhierarchy));
      }
    }

    [AttributeLogicalName("usequickfindviewforgridsearch")]
    public bool? usequickfindviewforgridsearch
    {
      get => this.GetPropertyValue<bool?>(nameof (usequickfindviewforgridsearch));
      set
      {
        this.SetPropertyValue<bool?>(nameof (usequickfindviewforgridsearch), value, nameof (usequickfindviewforgridsearch));
      }
    }

    [AttributeLogicalName("useraccessauditinginterval")]
    public int? useraccessauditinginterval
    {
      get => this.GetPropertyValue<int?>(nameof (useraccessauditinginterval));
      set
      {
        this.SetPropertyValue(nameof (useraccessauditinginterval), value, 0, int.MaxValue, nameof (useraccessauditinginterval));
      }
    }

    [AttributeLogicalName("usereadform")]
    public bool? usereadform
    {
      get => this.GetPropertyValue<bool?>(nameof (usereadform));
      set => this.SetPropertyValue<bool?>(nameof (usereadform), value, nameof (usereadform));
    }

    [AttributeLogicalName("usergroupid")]
    public Guid usergroupid
    {
      get => this.GetPropertyValue<Guid>(nameof (usergroupid));
      set => this.SetPropertyValue<Guid>(nameof (usergroupid), value, nameof (usergroupid));
    }

    [AttributeLogicalName("useskypeprotocol")]
    public bool? useskypeprotocol
    {
      get => this.GetPropertyValue<bool?>(nameof (useskypeprotocol));
      set
      {
        this.SetPropertyValue<bool?>(nameof (useskypeprotocol), value, nameof (useskypeprotocol));
      }
    }

    [AttributeLogicalName("utcconversiontimezonecode")]
    public int? utcconversiontimezonecode
    {
      get => this.GetPropertyValue<int?>(nameof (utcconversiontimezonecode));
      set
      {
        this.SetPropertyValue(nameof (utcconversiontimezonecode), value, -1, int.MaxValue, nameof (utcconversiontimezonecode));
      }
    }

    [AttributeLogicalName("v3calloutconfighash")]
    public string v3calloutconfighash
    {
      get => this.GetPropertyValue<string>(nameof (v3calloutconfighash));
    }

    [AttributeLogicalName("versionnumber")]
    public int? versionnumber => this.GetPropertyValue<int?>(nameof (versionnumber));

    [AttributeLogicalName("webresourcehash")]
    public string webresourcehash
    {
      get => this.GetPropertyValue<string>(nameof (webresourcehash));
      set => this.SetPropertyValue(nameof (webresourcehash), value, 100, nameof (webresourcehash));
    }

    [AttributeLogicalName("weekstartdaycode")]
    public OptionSetValue weekstartdaycode
    {
      get => this.GetPropertyValue<OptionSetValue>(nameof (weekstartdaycode));
      set
      {
        this.SetPropertyValue<OptionSetValue>(nameof (weekstartdaycode), value, nameof (weekstartdaycode));
      }
    }

    [AttributeLogicalName("widgetproperties")]
    public string widgetproperties
    {
      get => this.GetPropertyValue<string>(nameof (widgetproperties));
      set
      {
        this.SetPropertyValue(nameof (widgetproperties), value, 100, nameof (widgetproperties));
      }
    }

    [AttributeLogicalName("yammergroupid")]
    public int? yammergroupid
    {
      get => this.GetPropertyValue<int?>(nameof (yammergroupid));
      set
      {
        this.SetPropertyValue(nameof (yammergroupid), value, 0, int.MaxValue, nameof (yammergroupid));
      }
    }

    [AttributeLogicalName("yammernetworkpermalink")]
    public string yammernetworkpermalink
    {
      get => this.GetPropertyValue<string>(nameof (yammernetworkpermalink));
      set
      {
        this.SetPropertyValue(nameof (yammernetworkpermalink), value, 100, nameof (yammernetworkpermalink));
      }
    }

    [AttributeLogicalName("yammeroauthaccesstokenexpired")]
    public bool? yammeroauthaccesstokenexpired
    {
      get => this.GetPropertyValue<bool?>(nameof (yammeroauthaccesstokenexpired));
      set
      {
        this.SetPropertyValue<bool?>(nameof (yammeroauthaccesstokenexpired), value, nameof (yammeroauthaccesstokenexpired));
      }
    }

    [AttributeLogicalName("yammerpostmethod")]
    public OptionSetValue yammerpostmethod
    {
      get => this.GetPropertyValue<OptionSetValue>(nameof (yammerpostmethod));
      set
      {
        this.SetPropertyValue<OptionSetValue>(nameof (yammerpostmethod), value, nameof (yammerpostmethod));
      }
    }

    [AttributeLogicalName("yearstartweekcode")]
    public int? yearstartweekcode
    {
      get => this.GetPropertyValue<int?>(nameof (yearstartweekcode));
      set
      {
        this.SetPropertyValue(nameof (yearstartweekcode), value, int.MinValue, int.MaxValue, nameof (yearstartweekcode));
      }
    }

    public List<Entity> Getorganization_aciviewmapper(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "aciviewmapper", "organizationid", columns);
    }

    public List<Entity> Getorganization_aciviewmapper(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "aciviewmapper", "organizationid", columns);
    }

    public List<Entity> Getorganization_advancedsimilarityrule(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "advancedsimilarityrule", "organizationid", columns);
    }

    public List<Entity> Getorganization_advancedsimilarityrule(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "advancedsimilarityrule", "organizationid", columns);
    }

    public List<Entity> Getorganization_ait_addresstype(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_addresstype", "organizationid", columns);
    }

    public List<Entity> Getorganization_ait_addresstype(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_addresstype", "organizationid", columns);
    }

    public List<Entity> Getorganization_ait_autonumber(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_autonumber", "organizationid", columns);
    }

    public List<Entity> Getorganization_ait_autonumber(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_autonumber", "organizationid", columns);
    }

    public List<Entity> Getorganization_ait_band(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_band", "organizationid", columns);
    }

    public List<Entity> Getorganization_ait_band(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_band", "organizationid", columns);
    }

    public List<Entity> Getorganization_ait_cardformat(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_cardformat", "organizationid", columns);
    }

    public List<Entity> Getorganization_ait_cardformat(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_cardformat", "organizationid", columns);
    }

    public List<Entity> Getorganization_ait_cardformatdetail(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_cardformatdetail", "organizationid", columns);
    }

    public List<Entity> Getorganization_ait_cardformatdetail(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_cardformatdetail", "organizationid", columns);
    }

    public List<Entity> Getorganization_ait_causeofdeath(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_causeofdeath", "organizationid", columns);
    }

    public List<Entity> Getorganization_ait_causeofdeath(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_causeofdeath", "organizationid", columns);
    }

    public List<Entity> Getorganization_ait_cemetary(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_cemetary", "organizationid", columns);
    }

    public List<Entity> Getorganization_ait_cemetary(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_cemetary", "organizationid", columns);
    }

    public List<Entity> Getorganization_ait_certification(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_certification", "organizationid", columns);
    }

    public List<Entity> Getorganization_ait_certification(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_certification", "organizationid", columns);
    }

    public List<ait_city> Getorganization_ait_city(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_city>(service, this.Id, "ait_city", "organizationid", columns);
    }

    public List<ait_city> Getorganization_ait_city(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_city>(service, this.Id, "ait_city", "organizationid", columns);
    }

    public List<Entity> Getorganization_ait_clan(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_clan", "organizationid", columns);
    }

    public List<Entity> Getorganization_ait_clan(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_clan", "organizationid", columns);
    }

    public List<Entity> Getorganization_ait_committee(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_committee", "organizationid", columns);
    }

    public List<Entity> Getorganization_ait_committee(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_committee", "organizationid", columns);
    }

    public List<Entity> Getorganization_ait_committeemeeting(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_committeemeeting", "organizationid", columns);
    }

    public List<Entity> Getorganization_ait_committeemeeting(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_committeemeeting", "organizationid", columns);
    }

    public List<Entity> Getorganization_ait_committeemember(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_committeemember", "organizationid", columns);
    }

    public List<Entity> Getorganization_ait_committeemember(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_committeemember", "organizationid", columns);
    }

    public List<Entity> Getorganization_ait_committeeposition(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_committeeposition", "organizationid", columns);
    }

    public List<Entity> Getorganization_ait_committeeposition(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_committeeposition", "organizationid", columns);
    }

    public List<Entity> Getorganization_ait_committeepositiontype(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_committeepositiontype", "organizationid", columns);
    }

    public List<Entity> Getorganization_ait_committeepositiontype(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_committeepositiontype", "organizationid", columns);
    }

    public List<ait_countryregion> Getorganization_ait_countryregion(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_countryregion>(service, this.Id, "ait_countryregion", "organizationid", columns);
    }

    public List<ait_countryregion> Getorganization_ait_countryregion(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_countryregion>(service, this.Id, "ait_countryregion", "organizationid", columns);
    }

    public List<ait_county> Getorganization_ait_county(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_county>(service, this.Id, "ait_county", "organizationid", columns);
    }

    public List<ait_county> Getorganization_ait_county(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_county>(service, this.Id, "ait_county", "organizationid", columns);
    }

    public List<Entity> Getorganization_ait_degree(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_degree", "organizationid", columns);
    }

    public List<Entity> Getorganization_ait_degree(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_degree", "organizationid", columns);
    }

    public List<Entity> Getorganization_ait_geographicalarea(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_geographicalarea", "organizationid", columns);
    }

    public List<Entity> Getorganization_ait_geographicalarea(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_geographicalarea", "organizationid", columns);
    }

    public List<Entity> Getorganization_ait_incomeorexpensecategory(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_incomeorexpensecategory", "organizationid", columns);
    }

    public List<Entity> Getorganization_ait_incomeorexpensecategory(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_incomeorexpensecategory", "organizationid", columns);
    }

    public List<Entity> Getorganization_ait_language(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_language", "organizationid", columns);
    }

    public List<Entity> Getorganization_ait_language(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_language", "organizationid", columns);
    }

    public List<Entity> Getorganization_ait_languageproficiencylevel(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_languageproficiencylevel", "organizationid", columns);
    }

    public List<Entity> Getorganization_ait_languageproficiencylevel(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_languageproficiencylevel", "organizationid", columns);
    }

    public List<Entity> Getorganization_ait_membershipcategory(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_membershipcategory", "organizationid", columns);
    }

    public List<Entity> Getorganization_ait_membershipcategory(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_membershipcategory", "organizationid", columns);
    }

    public List<Entity> Getorganization_ait_nametype(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_nametype", "organizationid", columns);
    }

    public List<Entity> Getorganization_ait_nametype(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_nametype", "organizationid", columns);
    }

    public List<Entity> Getorganization_ait_reservation(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_reservation", "organizationid", columns);
    }

    public List<Entity> Getorganization_ait_reservation(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_reservation", "organizationid", columns);
    }

    public List<Entity> Getorganization_ait_roll(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_roll", "organizationid", columns);
    }

    public List<Entity> Getorganization_ait_roll(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_roll", "organizationid", columns);
    }

    public List<Entity> Getorganization_ait_schooltype(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_schooltype", "organizationid", columns);
    }

    public List<Entity> Getorganization_ait_schooltype(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_schooltype", "organizationid", columns);
    }

    public List<Entity> Getorganization_ait_skill(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_skill", "organizationid", columns);
    }

    public List<Entity> Getorganization_ait_skill(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_skill", "organizationid", columns);
    }

    public List<ait_stateprovince> Getorganization_ait_stateprovince(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_stateprovince>(service, this.Id, "ait_stateprovince", "organizationid", columns);
    }

    public List<ait_stateprovince> Getorganization_ait_stateprovince(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_stateprovince>(service, this.Id, "ait_stateprovince", "organizationid", columns);
    }

    public List<Entity> Getorganization_ait_tribe(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_tribe", "organizationid", columns);
    }

    public List<Entity> Getorganization_ait_tribe(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_tribe", "organizationid", columns);
    }

    public List<ait_zipcodecity> Getorganization_ait_zipcodecity(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_zipcodecity>(service, this.Id, "ait_zipcodecity", "organizationid", columns);
    }

    public List<ait_zipcodecity> Getorganization_ait_zipcodecity(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_zipcodecity>(service, this.Id, "ait_zipcodecity", "organizationid", columns);
    }

    public List<Entity> Getorganization_apisettings(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "apisettings", "organizationid", columns);
    }

    public List<Entity> Getorganization_apisettings(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "apisettings", "organizationid", columns);
    }

    public List<Entity> Getorganization_appconfig(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "appconfig", "organizationid", columns);
    }

    public List<Entity> Getorganization_appconfig(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "appconfig", "organizationid", columns);
    }

    public List<Entity> Getorganization_appconfiginstance(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "appconfiginstance", "organizationid", columns);
    }

    public List<Entity> Getorganization_appconfiginstance(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "appconfiginstance", "organizationid", columns);
    }

    public List<Entity> Getorganization_appconfigmaster(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "appconfigmaster", "organizationid", columns);
    }

    public List<Entity> Getorganization_appconfigmaster(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "appconfigmaster", "organizationid", columns);
    }

    public List<Entity> Getorganization_appelement(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "appelement", "organizationid", columns);
    }

    public List<Entity> Getorganization_appelement(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "appelement", "organizationid", columns);
    }

    public List<Entity> Getorganization_applicationfile(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "applicationfile", "organizationid", columns);
    }

    public List<Entity> Getorganization_applicationfile(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "applicationfile", "organizationid", columns);
    }

    public List<Entity> Getorganization_appmodule(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "appmodule", "organizationid", columns);
    }

    public List<Entity> Getorganization_appmodule(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "appmodule", "organizationid", columns);
    }

    public List<Entity> Getorganization_appmodulecomponentedge(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "appmodulecomponentedge", "organizationid", columns);
    }

    public List<Entity> Getorganization_appmodulecomponentedge(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "appmodulecomponentedge", "organizationid", columns);
    }

    public List<Entity> Getorganization_appmodulecomponentnode(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "appmodulecomponentnode", "organizationid", columns);
    }

    public List<Entity> Getorganization_appmodulecomponentnode(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "appmodulecomponentnode", "organizationid", columns);
    }

    public List<Entity> Getorganization_appsetting(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "appsetting", "organizationid", columns);
    }

    public List<Entity> Getorganization_appsetting(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "appsetting", "organizationid", columns);
    }

    public List<Entity> GetOrganization_AsyncOperations(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "asyncoperation", "regardingobjectid", columns);
    }

    public List<Entity> GetOrganization_AsyncOperations(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "asyncoperation", "regardingobjectid", columns);
    }

    public List<Entity> Getorganization_attributemap(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "attributemap", "organizationid", columns);
    }

    public List<Entity> Getorganization_attributemap(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "attributemap", "organizationid", columns);
    }

    public List<Entity> Getlk_authorizationserver_organizationid(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "authorizationserver", "organizationid", columns);
    }

    public List<Entity> Getlk_authorizationserver_organizationid(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "authorizationserver", "organizationid", columns);
    }

    public List<Entity> Getorganization_azureserviceconnection(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "azureserviceconnection", "organizationid", columns);
    }

    public List<Entity> Getorganization_azureserviceconnection(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "azureserviceconnection", "organizationid", columns);
    }

    public List<Entity> GetOrganization_BulkDeleteFailures(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bulkdeletefailure", "regardingobjectid", columns);
    }

    public List<Entity> GetOrganization_BulkDeleteFailures(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bulkdeletefailure", "regardingobjectid", columns);
    }

    public List<businessunit> Getorganization_business_units(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<businessunit>(service, this.Id, "businessunit", "organizationid", columns);
    }

    public List<businessunit> Getorganization_business_units(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<businessunit>(service, this.Id, "businessunit", "organizationid", columns);
    }

    public List<Entity> Getorganization_business_unit_news_articles(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "businessunitnewsarticle", "organizationid", columns);
    }

    public List<Entity> Getorganization_business_unit_news_articles(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "businessunitnewsarticle", "organizationid", columns);
    }

    public List<Entity> Getorganization_calendars(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "calendar", "organizationid", columns);
    }

    public List<Entity> Getorganization_calendars(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "calendar", "organizationid", columns);
    }

    public List<Entity> Getchannelproperty_organization(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "channelproperty", "organizationid", columns);
    }

    public List<Entity> Getchannelproperty_organization(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "channelproperty", "organizationid", columns);
    }

    public List<Entity> Getchannelpropertygroup_organization(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "channelpropertygroup", "organizationid", columns);
    }

    public List<Entity> Getchannelpropertygroup_organization(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "channelpropertygroup", "organizationid", columns);
    }

    public List<Entity> Getorganization_competitors(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "competitor", "organizationid", columns);
    }

    public List<Entity> Getorganization_competitors(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "competitor", "organizationid", columns);
    }

    public List<Entity> Getorganization_complexcontrols(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "complexcontrol", "organizationid", columns);
    }

    public List<Entity> Getorganization_complexcontrols(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "complexcontrol", "organizationid", columns);
    }

    public List<connectionrole> Getorganization_connection_roles(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<connectionrole>(service, this.Id, "connectionrole", "organizationid", columns);
    }

    public List<connectionrole> Getorganization_connection_roles(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<connectionrole>(service, this.Id, "connectionrole", "organizationid", columns);
    }

    public List<Entity> Getorganization_constraint_based_groups(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "constraintbasedgroup", "organizationid", columns);
    }

    public List<Entity> Getorganization_constraint_based_groups(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "constraintbasedgroup", "organizationid", columns);
    }

    public List<Entity> Getorganization_contract_templates(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "contracttemplate", "organizationid", columns);
    }

    public List<Entity> Getorganization_contract_templates(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "contracttemplate", "organizationid", columns);
    }

    public List<Entity> Getcustomcontrol_organization(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "customcontrol", "organizationid", columns);
    }

    public List<Entity> Getcustomcontrol_organization(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "customcontrol", "organizationid", columns);
    }

    public List<Entity> Getcustomcontroldefaultconfig_organization(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "customcontroldefaultconfig", "organizationid", columns);
    }

    public List<Entity> Getcustomcontroldefaultconfig_organization(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "customcontroldefaultconfig", "organizationid", columns);
    }

    public List<Entity> Getcustomcontrolresource_organization(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "customcontrolresource", "organizationid", columns);
    }

    public List<Entity> Getcustomcontrolresource_organization(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "customcontrolresource", "organizationid", columns);
    }

    public List<Entity> Getorganization_datalakeworkspace(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "datalakeworkspace", "organizationid", columns);
    }

    public List<Entity> Getorganization_datalakeworkspace(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "datalakeworkspace", "organizationid", columns);
    }

    public List<Entity> Getorganization_datalakeworkspacepermission(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "datalakeworkspacepermission", "organizationid", columns);
    }

    public List<Entity> Getorganization_datalakeworkspacepermission(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "datalakeworkspacepermission", "organizationid", columns);
    }

    public List<Entity> Getlk_dataperformance_organizationid(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "dataperformance", "organizationid", columns);
    }

    public List<Entity> Getlk_dataperformance_organizationid(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "dataperformance", "organizationid", columns);
    }

    public List<Entity> Getorganization_delveactionhub(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "delveactionhub", "organizationid", columns);
    }

    public List<Entity> Getorganization_delveactionhub(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "delveactionhub", "organizationid", columns);
    }

    public List<Entity> Getorganization_discount_types(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "discounttype", "organizationid", columns);
    }

    public List<Entity> Getorganization_discount_types(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "discounttype", "organizationid", columns);
    }

    public List<Entity> Getorganization_custom_displaystrings(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "displaystring", "organizationid", columns);
    }

    public List<Entity> Getorganization_custom_displaystrings(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "displaystring", "organizationid", columns);
    }

    public List<Entity> Getorganization_indexed_documents(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "documentindex", "organizationid", columns);
    }

    public List<Entity> Getorganization_indexed_documents(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "documentindex", "organizationid", columns);
    }

    public List<Entity> Getlk_documenttemplatebase_organization(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "documenttemplate", "organizationid", columns);
    }

    public List<Entity> Getlk_documenttemplatebase_organization(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "documenttemplate", "organizationid", columns);
    }

    public List<Entity> Getdynamicproperty_organization(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "dynamicproperty", "organizationid", columns);
    }

    public List<Entity> Getdynamicproperty_organization(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "dynamicproperty", "organizationid", columns);
    }

    public List<Entity> GetDynamicPropertyAssociation_organization(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "dynamicpropertyassociation", "organizationid", columns);
    }

    public List<Entity> GetDynamicPropertyAssociation_organization(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "dynamicpropertyassociation", "organizationid", columns);
    }

    public List<Entity> GetDynamicPropertyOptionSetItem_organization(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "dynamicpropertyoptionsetitem", "organizationid", columns);
    }

    public List<Entity> GetDynamicPropertyOptionSetItem_organization(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "dynamicpropertyoptionsetitem", "organizationid", columns);
    }

    public List<Entity> Getorganization_emailserverprofile(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "emailserverprofile", "organizationid", columns);
    }

    public List<Entity> Getorganization_emailserverprofile(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "emailserverprofile", "organizationid", columns);
    }

    public List<Entity> Getentitlementchannel_organization(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "entitlementchannel", "organizationid", columns);
    }

    public List<Entity> Getentitlementchannel_organization(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "entitlementchannel", "organizationid", columns);
    }

    public List<Entity> Getentitlementtemplate_organization(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "entitlementtemplate", "organizationid", columns);
    }

    public List<Entity> Getentitlementtemplate_organization(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "entitlementtemplate", "organizationid", columns);
    }

    public List<Entity> Getentitlementtemplatechannel_organization(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "entitlementtemplatechannel", "organizationid", columns);
    }

    public List<Entity> Getentitlementtemplatechannel_organization(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "entitlementtemplatechannel", "organizationid", columns);
    }

    public List<Entity> Getorganization_entityanalyticsconfig(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "entityanalyticsconfig", "organizationid", columns);
    }

    public List<Entity> Getorganization_entityanalyticsconfig(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "entityanalyticsconfig", "organizationid", columns);
    }

    public List<Entity> Getorganization_entitydataprovider(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "entitydataprovider", "organizationid", columns);
    }

    public List<Entity> Getorganization_entitydataprovider(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "entitydataprovider", "organizationid", columns);
    }

    public List<Entity> Getorganization_entitydatasource(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "entitydatasource", "organizationid", columns);
    }

    public List<Entity> Getorganization_entitydatasource(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "entitydatasource", "organizationid", columns);
    }

    public List<Entity> Getorganization_entitymap(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "entitymap", "organizationid", columns);
    }

    public List<Entity> Getorganization_entitymap(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "entitymap", "organizationid", columns);
    }

    public List<Entity> Getorganization_equipment(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "equipment", "organizationid", columns);
    }

    public List<Entity> Getorganization_equipment(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "equipment", "organizationid", columns);
    }

    public List<Entity> Getorganization_expanderevent(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "expanderevent", "organizationid", columns);
    }

    public List<Entity> Getorganization_expanderevent(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "expanderevent", "organizationid", columns);
    }

    public List<Entity> Getorganization_expiredprocess(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "expiredprocess", "organizationid", columns);
    }

    public List<Entity> Getorganization_expiredprocess(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "expiredprocess", "organizationid", columns);
    }

    public List<Entity> Getlk_fieldsecurityprofile_organizationid(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "fieldsecurityprofile", "organizationid", columns);
    }

    public List<Entity> Getlk_fieldsecurityprofile_organizationid(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "fieldsecurityprofile", "organizationid", columns);
    }

    public List<Entity> Getorganization_hierarchyrules(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "hierarchyrule", "organizationid", columns);
    }

    public List<Entity> Getorganization_hierarchyrules(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "hierarchyrule", "organizationid", columns);
    }

    public List<Entity> Getorganization_importjob(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "importjob", "organizationid", columns);
    }

    public List<Entity> Getorganization_importjob(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "importjob", "organizationid", columns);
    }

    public List<Entity> Getorganization_integration_statuses(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "integrationstatus", "organizationid", columns);
    }

    public List<Entity> Getorganization_integration_statuses(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "integrationstatus", "organizationid", columns);
    }

    public List<Entity> Getorganization_isvconfigs(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "isvconfig", "organizationid", columns);
    }

    public List<Entity> Getorganization_isvconfigs(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "isvconfig", "organizationid", columns);
    }

    public List<Entity> Getorganization_kb_articles(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "kbarticle", "organizationid", columns);
    }

    public List<Entity> Getorganization_kb_articles(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "kbarticle", "organizationid", columns);
    }

    public List<Entity> Getorganization_kb_article_templates(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "kbarticletemplate", "organizationid", columns);
    }

    public List<Entity> Getorganization_kb_article_templates(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "kbarticletemplate", "organizationid", columns);
    }

    public List<Entity> Getorganization_KnowledgeBaseRecord(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "knowledgebaserecord", "organizationid", columns);
    }

    public List<Entity> Getorganization_KnowledgeBaseRecord(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "knowledgebaserecord", "organizationid", columns);
    }

    public List<Entity> Getorganization_knowledgesearchmodel(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "knowledgesearchmodel", "organizationid", columns);
    }

    public List<Entity> Getorganization_knowledgesearchmodel(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "knowledgesearchmodel", "organizationid", columns);
    }

    public List<Entity> Getlanguagelocale_organization(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "languagelocale", "organizationid", columns);
    }

    public List<Entity> Getlanguagelocale_organization(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "languagelocale", "organizationid", columns);
    }

    public List<Entity> Getorganization_leadtoopportunitysalesprocess(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "leadtoopportunitysalesprocess", "organizationid", columns);
    }

    public List<Entity> Getorganization_leadtoopportunitysalesprocess(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "leadtoopportunitysalesprocess", "organizationid", columns);
    }

    public List<Entity> Getorganization_licenses(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "license", "organizationid", columns);
    }

    public List<Entity> Getorganization_licenses(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "license", "organizationid", columns);
    }

    public List<Entity> Getorganization_mailbox(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "mailbox", "organizationid", columns);
    }

    public List<Entity> Getorganization_mailbox(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "mailbox", "organizationid", columns);
    }

    public List<Entity> Getorganization_mailboxstatistics(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "mailboxstatistics", "organizationid", columns);
    }

    public List<Entity> Getorganization_mailboxstatistics(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "mailboxstatistics", "organizationid", columns);
    }

    public List<Entity> GetOrganization_MailboxTrackingFolder(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "mailboxtrackingfolder", "organizationid", columns);
    }

    public List<Entity> GetOrganization_MailboxTrackingFolder(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "mailboxtrackingfolder", "organizationid", columns);
    }

    public List<Entity> Getorganization_metric(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "metric", "organizationid", columns);
    }

    public List<Entity> Getorganization_metric(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "metric", "organizationid", columns);
    }

    public List<Entity> GetMobileOfflineProfile_organization(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "mobileofflineprofile", "organizationid", columns);
    }

    public List<Entity> GetMobileOfflineProfile_organization(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "mobileofflineprofile", "organizationid", columns);
    }

    public List<Entity> GetMobileOfflineProfileItem_organization(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "mobileofflineprofileitem", "organizationid", columns);
    }

    public List<Entity> GetMobileOfflineProfileItem_organization(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "mobileofflineprofileitem", "organizationid", columns);
    }

    public List<Entity> GetMobileOfflineProfileItemAssociation_organization(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "mobileofflineprofileitemassociation", "organizationid", columns);
    }

    public List<Entity> GetMobileOfflineProfileItemAssociation_organization(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "mobileofflineprofileitemassociation", "organizationid", columns);
    }

    public List<Entity> Getorganization_msdyn_databaseversion(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_databaseversion", "organizationid", columns);
    }

    public List<Entity> Getorganization_msdyn_databaseversion(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_databaseversion", "organizationid", columns);
    }

    public List<Entity> Getorganization_msdyn_helppage(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_helppage", "organizationid", columns);
    }

    public List<Entity> Getorganization_msdyn_helppage(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_helppage", "organizationid", columns);
    }

    public List<Entity> Getorganization_msdyn_iottocaseprocess(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iottocaseprocess", "organizationid", columns);
    }

    public List<Entity> Getorganization_msdyn_iottocaseprocess(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iottocaseprocess", "organizationid", columns);
    }

    public List<Entity> Getorganization_msdyn_postconfig(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_postconfig", "organizationid", columns);
    }

    public List<Entity> Getorganization_msdyn_postconfig(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_postconfig", "organizationid", columns);
    }

    public List<Entity> Getorganization_msdyn_postruleconfig(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_postruleconfig", "organizationid", columns);
    }

    public List<Entity> Getorganization_msdyn_postruleconfig(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_postruleconfig", "organizationid", columns);
    }

    public List<Entity> Getorganization_msdyn_sikeyvalueconfig(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_sikeyvalueconfig", "organizationid", columns);
    }

    public List<Entity> Getorganization_msdyn_sikeyvalueconfig(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_sikeyvalueconfig", "organizationid", columns);
    }

    public List<Entity> Getorganization_msdyn_solutionhealthruleset(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_solutionhealthruleset", "organizationid", columns);
    }

    public List<Entity> Getorganization_msdyn_solutionhealthruleset(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_solutionhealthruleset", "organizationid", columns);
    }

    public List<Entity> Getorganization_msdyn_upgraderun(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_upgraderun", "organizationid", columns);
    }

    public List<Entity> Getorganization_msdyn_upgraderun(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_upgraderun", "organizationid", columns);
    }

    public List<Entity> Getorganization_msdyn_upgradestep(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_upgradestep", "organizationid", columns);
    }

    public List<Entity> Getorganization_msdyn_upgradestep(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_upgradestep", "organizationid", columns);
    }

    public List<Entity> Getorganization_msdyn_upgradeversion(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_upgradeversion", "organizationid", columns);
    }

    public List<Entity> Getorganization_msdyn_upgradeversion(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_upgradeversion", "organizationid", columns);
    }

    public List<Entity> Getorganization_msdyn_wallsavedquery(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_wallsavedquery", "organizationid", columns);
    }

    public List<Entity> Getorganization_msdyn_wallsavedquery(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_wallsavedquery", "organizationid", columns);
    }

    public List<Entity> Getorganization_navigationsetting(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "navigationsetting", "organizationid", columns);
    }

    public List<Entity> Getorganization_navigationsetting(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "navigationsetting", "organizationid", columns);
    }

    public List<Entity> Getorganization_newprocess(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "newprocess", "organizationid", columns);
    }

    public List<Entity> Getorganization_newprocess(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "newprocess", "organizationid", columns);
    }

    public List<Entity> Getorganization_officegraphdocument(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "officegraphdocument", "organizationid", columns);
    }

    public List<Entity> Getorganization_officegraphdocument(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "officegraphdocument", "organizationid", columns);
    }

    public List<Entity> Getofflinecommanddefinition_organization(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "offlinecommanddefinition", "organizationid", columns);
    }

    public List<Entity> Getofflinecommanddefinition_organization(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "offlinecommanddefinition", "organizationid", columns);
    }

    public List<Entity> Getorganization_opportunitysalesprocess(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "opportunitysalesprocess", "organizationid", columns);
    }

    public List<Entity> Getorganization_opportunitysalesprocess(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "opportunitysalesprocess", "organizationid", columns);
    }

    public List<Entity> Getlk_organizationui_organizationid(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "organizationui", "organizationid", columns);
    }

    public List<Entity> Getlk_organizationui_organizationid(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "organizationui", "organizationid", columns);
    }

    public List<Entity> Getorganization_orginsightsmetric(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "orginsightsmetric", "organizationid", columns);
    }

    public List<Entity> Getorganization_orginsightsmetric(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "orginsightsmetric", "organizationid", columns);
    }

    public List<Entity> Getorganization_orginsightsnotification(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "orginsightsnotification", "organizationid", columns);
    }

    public List<Entity> Getorganization_orginsightsnotification(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "orginsightsnotification", "organizationid", columns);
    }

    public List<Entity> Getlk_partnerapplication_organizationid(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "partnerapplication", "organizationid", columns);
    }

    public List<Entity> Getlk_partnerapplication_organizationid(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "partnerapplication", "organizationid", columns);
    }

    public List<Entity> Getorganization_phonetocaseprocess(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "phonetocaseprocess", "organizationid", columns);
    }

    public List<Entity> Getorganization_phonetocaseprocess(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "phonetocaseprocess", "organizationid", columns);
    }

    public List<Entity> Getorganization_pluginassembly(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "pluginassembly", "organizationid", columns);
    }

    public List<Entity> Getorganization_pluginassembly(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "pluginassembly", "organizationid", columns);
    }

    public List<Entity> Getorganization_plugintype(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "plugintype", "organizationid", columns);
    }

    public List<Entity> Getorganization_plugintype(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "plugintype", "organizationid", columns);
    }

    public List<Entity> Getorganization_plugintypestatistic(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "plugintypestatistic", "organizationid", columns);
    }

    public List<Entity> Getorganization_plugintypestatistic(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "plugintypestatistic", "organizationid", columns);
    }

    public List<Entity> Getorganization_position(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "position", "organizationid", columns);
    }

    public List<Entity> Getorganization_position(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "position", "organizationid", columns);
    }

    public List<Entity> Getorganization_post(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "post", "organizationid", columns);
    }

    public List<Entity> Getorganization_post(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "post", "organizationid", columns);
    }

    public List<Entity> Getorganization_PostComment(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "postcomment", "organizationid", columns);
    }

    public List<Entity> Getorganization_PostComment(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "postcomment", "organizationid", columns);
    }

    public List<Entity> Getorganization_postlike(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "postlike", "organizationid", columns);
    }

    public List<Entity> Getorganization_postlike(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "postlike", "organizationid", columns);
    }

    public List<Entity> Getorganization_postrole(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "postrole", "organizationid", columns);
    }

    public List<Entity> Getorganization_postrole(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "postrole", "organizationid", columns);
    }

    public List<Entity> Getorganization_price_levels(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "pricelevel", "organizationid", columns);
    }

    public List<Entity> Getorganization_price_levels(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "pricelevel", "organizationid", columns);
    }

    public List<Entity> Getlk_principalobjectattributeaccess_organizationid(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "principalobjectattributeaccess", "organizationid", columns);
    }

    public List<Entity> Getlk_principalobjectattributeaccess_organizationid(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "principalobjectattributeaccess", "organizationid", columns);
    }

    public List<Entity> Getlk_principalsyncattributemap_organizationid(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "principalsyncattributemap", "organizationid", columns);
    }

    public List<Entity> Getlk_principalsyncattributemap_organizationid(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "principalsyncattributemap", "organizationid", columns);
    }

    public List<Entity> Getorganization_products(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "product", "organizationid", columns);
    }

    public List<Entity> Getorganization_products(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "product", "organizationid", columns);
    }

    public List<Entity> Getorganization_ProductAssociation(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "productassociation", "organizationid", columns);
    }

    public List<Entity> Getorganization_ProductAssociation(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "productassociation", "organizationid", columns);
    }

    public List<Entity> Getorganization_ProductSubstitute(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "productsubstitute", "organizationid", columns);
    }

    public List<Entity> Getorganization_ProductSubstitute(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "productsubstitute", "organizationid", columns);
    }

    public List<Entity> Getorganization_publisher(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "publisher", "organizationid", columns);
    }

    public List<Entity> Getorganization_publisher(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "publisher", "organizationid", columns);
    }

    public List<Entity> Getorganization_queues(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "queue", "organizationid", columns);
    }

    public List<Entity> Getorganization_queues(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "queue", "organizationid", columns);
    }

    public List<Entity> Getorganization_queueitems(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "queueitem", "organizationid", columns);
    }

    public List<Entity> Getorganization_queueitems(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "queueitem", "organizationid", columns);
    }

    public List<Entity> Getorganization_recommendeddocument(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "recommendeddocument", "organizationid", columns);
    }

    public List<Entity> Getorganization_recommendeddocument(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "recommendeddocument", "organizationid", columns);
    }

    public List<Entity> Getorganization_relationship_roles(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "relationshiprole", "organizationid", columns);
    }

    public List<Entity> Getorganization_relationship_roles(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "relationshiprole", "organizationid", columns);
    }

    public List<Entity> Getorganization_resources(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "resource", "organizationid", columns);
    }

    public List<Entity> Getorganization_resources(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "resource", "organizationid", columns);
    }

    public List<Entity> Getorganization_resource_groups(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "resourcegroup", "organizationid", columns);
    }

    public List<Entity> Getorganization_resource_groups(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "resourcegroup", "organizationid", columns);
    }

    public List<Entity> Getorganization_resource_specs(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "resourcespec", "organizationid", columns);
    }

    public List<Entity> Getorganization_resource_specs(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "resourcespec", "organizationid", columns);
    }

    public List<Entity> Getorganization_ribbon_command(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ribboncommand", "organizationid", columns);
    }

    public List<Entity> Getorganization_ribbon_command(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ribboncommand", "organizationid", columns);
    }

    public List<Entity> Getorganization_ribbon_context_group(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ribboncontextgroup", "organizationid", columns);
    }

    public List<Entity> Getorganization_ribbon_context_group(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ribboncontextgroup", "organizationid", columns);
    }

    public List<Entity> Getorganization_ribbon_customization(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ribboncustomization", "organizationid", columns);
    }

    public List<Entity> Getorganization_ribbon_customization(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ribboncustomization", "organizationid", columns);
    }

    public List<Entity> Getorganization_ribbon_diff(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ribbondiff", "organizationid", columns);
    }

    public List<Entity> Getorganization_ribbon_diff(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ribbondiff", "organizationid", columns);
    }

    public List<Entity> Getorganization_ribbon_rule(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ribbonrule", "organizationid", columns);
    }

    public List<Entity> Getorganization_ribbon_rule(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ribbonrule", "organizationid", columns);
    }

    public List<Entity> Getorganization_ribbon_tab_to_command_map(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ribbontabtocommandmap", "organizationid", columns);
    }

    public List<Entity> Getorganization_ribbon_tab_to_command_map(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ribbontabtocommandmap", "organizationid", columns);
    }

    public List<Entity> Getorganization_roles(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "role", "organizationid", columns);
    }

    public List<Entity> Getorganization_roles(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "role", "organizationid", columns);
    }

    public List<Entity> Getorganization_RoutingRules(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "routingrule", "organizationid", columns);
    }

    public List<Entity> Getorganization_RoutingRules(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "routingrule", "organizationid", columns);
    }

    public List<Entity> Getorganization_routingruleitems(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "routingruleitem", "organizationid", columns);
    }

    public List<Entity> Getorganization_routingruleitems(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "routingruleitem", "organizationid", columns);
    }

    public List<Entity> Getorganization_sales_literature(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "salesliterature", "organizationid", columns);
    }

    public List<Entity> Getorganization_sales_literature(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "salesliterature", "organizationid", columns);
    }

    public List<Entity> Getorganization_savedorginsightsconfiguration(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "savedorginsightsconfiguration", "organizationid", columns);
    }

    public List<Entity> Getorganization_savedorginsightsconfiguration(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "savedorginsightsconfiguration", "organizationid", columns);
    }

    public List<Entity> Getorganization_saved_queries(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "savedquery", "organizationid", columns);
    }

    public List<Entity> Getorganization_saved_queries(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "savedquery", "organizationid", columns);
    }

    public List<Entity> Getorganization_saved_query_visualizations(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "savedqueryvisualization", "organizationid", columns);
    }

    public List<Entity> Getorganization_saved_query_visualizations(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "savedqueryvisualization", "organizationid", columns);
    }

    public List<Entity> Getorganization_sdkmessage(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sdkmessage", "organizationid", columns);
    }

    public List<Entity> Getorganization_sdkmessage(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sdkmessage", "organizationid", columns);
    }

    public List<Entity> Getorganization_sdkmessagefilter(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sdkmessagefilter", "organizationid", columns);
    }

    public List<Entity> Getorganization_sdkmessagefilter(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sdkmessagefilter", "organizationid", columns);
    }

    public List<Entity> Getorganization_sdkmessagepair(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sdkmessagepair", "organizationid", columns);
    }

    public List<Entity> Getorganization_sdkmessagepair(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sdkmessagepair", "organizationid", columns);
    }

    public List<Entity> Getorganization_sdkmessageprocessingstep(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sdkmessageprocessingstep", "organizationid", columns);
    }

    public List<Entity> Getorganization_sdkmessageprocessingstep(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sdkmessageprocessingstep", "organizationid", columns);
    }

    public List<Entity> Getorganization_sdkmessageprocessingstepimage(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sdkmessageprocessingstepimage", "organizationid", columns);
    }

    public List<Entity> Getorganization_sdkmessageprocessingstepimage(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sdkmessageprocessingstepimage", "organizationid", columns);
    }

    public List<Entity> Getorganization_sdkmessageprocessingstepsecureconfig(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sdkmessageprocessingstepsecureconfig", "organizationid", columns);
    }

    public List<Entity> Getorganization_sdkmessageprocessingstepsecureconfig(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sdkmessageprocessingstepsecureconfig", "organizationid", columns);
    }

    public List<Entity> Getorganization_sdkmessagerequest(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sdkmessagerequest", "organizationid", columns);
    }

    public List<Entity> Getorganization_sdkmessagerequest(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sdkmessagerequest", "organizationid", columns);
    }

    public List<Entity> Getorganization_sdkmessagerequestfield(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sdkmessagerequestfield", "organizationid", columns);
    }

    public List<Entity> Getorganization_sdkmessagerequestfield(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sdkmessagerequestfield", "organizationid", columns);
    }

    public List<Entity> Getorganization_sdkmessageresponse(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sdkmessageresponse", "organizationid", columns);
    }

    public List<Entity> Getorganization_sdkmessageresponse(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sdkmessageresponse", "organizationid", columns);
    }

    public List<Entity> Getorganization_sdkmessageresponsefield(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sdkmessageresponsefield", "organizationid", columns);
    }

    public List<Entity> Getorganization_sdkmessageresponsefield(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sdkmessageresponsefield", "organizationid", columns);
    }

    public List<Entity> Getorganization_services(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, nameof (service), "organizationid", columns);
    }

    public List<Entity> Getorganization_services(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, nameof (service), "organizationid", columns);
    }

    public List<Entity> Getorganization_serviceendpoint(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "serviceendpoint", "organizationid", columns);
    }

    public List<Entity> Getorganization_serviceendpoint(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "serviceendpoint", "organizationid", columns);
    }

    public List<Entity> Getorganization_settingdefinition(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "settingdefinition", "organizationid", columns);
    }

    public List<Entity> Getorganization_settingdefinition(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "settingdefinition", "organizationid", columns);
    }

    public List<Entity> Getorganization_sharepointdata(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sharepointdata", "organizationid", columns);
    }

    public List<Entity> Getorganization_sharepointdata(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sharepointdata", "organizationid", columns);
    }

    public List<Entity> Getorganization_sharepointdocument(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sharepointdocument", "organizationid", columns);
    }

    public List<Entity> Getorganization_sharepointdocument(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sharepointdocument", "organizationid", columns);
    }

    public List<Entity> Getorganization_similarityrule(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "similarityrule", "organizationid", columns);
    }

    public List<Entity> Getorganization_similarityrule(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "similarityrule", "organizationid", columns);
    }

    public List<Entity> Getorganization_sites(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "site", "organizationid", columns);
    }

    public List<Entity> Getorganization_sites(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "site", "organizationid", columns);
    }

    public List<Entity> Getorganization_sitemap(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sitemap", "organizationid", columns);
    }

    public List<Entity> Getorganization_sitemap(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sitemap", "organizationid", columns);
    }

    public List<Entity> Getorganization_socialinsightsconfiguration(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "socialinsightsconfiguration", "organizationid", columns);
    }

    public List<Entity> Getorganization_socialinsightsconfiguration(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "socialinsightsconfiguration", "organizationid", columns);
    }

    public List<Entity> Getorganization_solution(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "solution", "organizationid", columns);
    }

    public List<Entity> Getorganization_solution(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "solution", "organizationid", columns);
    }

    public List<Entity> Getorganization_solutioncomponentattributeconfiguration(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "solutioncomponentattributeconfiguration", "organizationid", columns);
    }

    public List<Entity> Getorganization_solutioncomponentattributeconfiguration(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "solutioncomponentattributeconfiguration", "organizationid", columns);
    }

    public List<Entity> Getorganization_solutioncomponentconfiguration(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "solutioncomponentconfiguration", "organizationid", columns);
    }

    public List<Entity> Getorganization_solutioncomponentconfiguration(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "solutioncomponentconfiguration", "organizationid", columns);
    }

    public List<Entity> Getorganization_solutioncomponentrelationshipconfiguration(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "solutioncomponentrelationshipconfiguration", "organizationid", columns);
    }

    public List<Entity> Getorganization_solutioncomponentrelationshipconfiguration(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "solutioncomponentrelationshipconfiguration", "organizationid", columns);
    }

    public List<Entity> Getorganization_status_maps(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "statusmap", "organizationid", columns);
    }

    public List<Entity> Getorganization_status_maps(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "statusmap", "organizationid", columns);
    }

    public List<Entity> Getorganization_string_maps(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "stringmap", "organizationid", columns);
    }

    public List<Entity> Getorganization_string_maps(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "stringmap", "organizationid", columns);
    }

    public List<Entity> Getorganization_subjects(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "subject", "organizationid", columns);
    }

    public List<Entity> Getorganization_subjects(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "subject", "organizationid", columns);
    }

    public List<Entity> Getorganization_suggestioncardtemplate(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "suggestioncardtemplate", "organizationid", columns);
    }

    public List<Entity> Getorganization_suggestioncardtemplate(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "suggestioncardtemplate", "organizationid", columns);
    }

    public List<Entity> Getlk_syncattributemappingprofile_organizationid(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "syncattributemappingprofile", "organizationid", columns);
    }

    public List<Entity> Getlk_syncattributemappingprofile_organizationid(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "syncattributemappingprofile", "organizationid", columns);
    }

    public List<Entity> GetOrganization_SyncErrors(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "syncerror", "regardingobjectid", columns);
    }

    public List<Entity> GetOrganization_SyncErrors(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "syncerror", "regardingobjectid", columns);
    }

    public List<Entity> Getorganization_systemapplicationmetadata(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "systemapplicationmetadata", "organizationid", columns);
    }

    public List<Entity> Getorganization_systemapplicationmetadata(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "systemapplicationmetadata", "organizationid", columns);
    }

    public List<Entity> Getorganization_systemforms(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "systemform", "organizationid", columns);
    }

    public List<Entity> Getorganization_systemforms(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "systemform", "organizationid", columns);
    }

    public List<systemuser> Getorganization_system_users(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<systemuser>(service, this.Id, "systemuser", "organizationid", columns);
    }

    public List<systemuser> Getorganization_system_users(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<systemuser>(service, this.Id, "systemuser", "organizationid", columns);
    }

    public List<team> Getorganization_teams(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<team>(service, this.Id, "team", "organizationid", columns);
    }

    public List<team> Getorganization_teams(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<team>(service, this.Id, "team", "organizationid", columns);
    }

    public List<Entity> Getorganization_territories(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "territory", "organizationid", columns);
    }

    public List<Entity> Getorganization_territories(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "territory", "organizationid", columns);
    }

    public List<Entity> Getorganization_textanalyticsentitymapping(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "textanalyticsentitymapping", "organizationid", columns);
    }

    public List<Entity> Getorganization_textanalyticsentitymapping(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "textanalyticsentitymapping", "organizationid", columns);
    }

    public List<Entity> Getorganization_theme(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "theme", "organizationid", columns);
    }

    public List<Entity> Getorganization_theme(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "theme", "organizationid", columns);
    }

    public List<Entity> Getorganization_topicmodel(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "topicmodel", "organizationid", columns);
    }

    public List<Entity> Getorganization_topicmodel(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "topicmodel", "organizationid", columns);
    }

    public List<Entity> Getorganization_topicmodelconfiguration(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "topicmodelconfiguration", "organizationid", columns);
    }

    public List<Entity> Getorganization_topicmodelconfiguration(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "topicmodelconfiguration", "organizationid", columns);
    }

    public List<Entity> Getorganization_topicmodelexecutionhistory(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "topicmodelexecutionhistory", "organizationid", columns);
    }

    public List<Entity> Getorganization_topicmodelexecutionhistory(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "topicmodelexecutionhistory", "organizationid", columns);
    }

    public List<Entity> Getorganization_traceassociation(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "traceassociation", "organizationid", columns);
    }

    public List<Entity> Getorganization_traceassociation(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "traceassociation", "organizationid", columns);
    }

    public List<Entity> Getorganization_tracelog(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "tracelog", "organizationid", columns);
    }

    public List<Entity> Getorganization_tracelog(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "tracelog", "organizationid", columns);
    }

    public List<Entity> Getorganization_transactioncurrencies(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "transactioncurrency", "organizationid", columns);
    }

    public List<Entity> Getorganization_transactioncurrencies(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "transactioncurrency", "organizationid", columns);
    }

    public List<Entity> Getorganization_translationprocess(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "translationprocess", "organizationid", columns);
    }

    public List<Entity> Getorganization_translationprocess(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "translationprocess", "organizationid", columns);
    }

    public List<Entity> Getorganization_uof_schedules(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "uomschedule", "organizationid", columns);
    }

    public List<Entity> Getorganization_uof_schedules(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "uomschedule", "organizationid", columns);
    }

    public List<Entity> Getuserentityinstancedata_organization(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userentityinstancedata", "objectid", columns);
    }

    public List<Entity> Getuserentityinstancedata_organization(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userentityinstancedata", "objectid", columns);
    }

    public List<Entity> Getorganization_UserMapping(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "usermapping", "organizationid", columns);
    }

    public List<Entity> Getorganization_UserMapping(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "usermapping", "organizationid", columns);
    }

    public List<Entity> Getwebresource_organization(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "webresource", "organizationid", columns);
    }

    public List<Entity> Getwebresource_organization(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "webresource", "organizationid", columns);
    }

    public List<Entity> Getorganization_webwizard(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "webwizard", "organizationid", columns);
    }

    public List<Entity> Getorganization_webwizard(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "webwizard", "organizationid", columns);
    }

    public List<Entity> Getorganization_wizardaccessprivilege(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "wizardaccessprivilege", "organizationid", columns);
    }

    public List<Entity> Getorganization_wizardaccessprivilege(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "wizardaccessprivilege", "organizationid", columns);
    }

    public List<Entity> Getorganization_wizardpage(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "wizardpage", "organizationid", columns);
    }

    public List<Entity> Getorganization_wizardpage(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "wizardpage", "organizationid", columns);
    }

    public static class Properties
    {
      public const string aciwebendpointurl = "aciwebendpointurl";
      public const string acknowledgementtemplateid = "acknowledgementtemplateid";
      public const string acknowledgementtemplateidname = "acknowledgementtemplateidname";
      public const string allowaddressbooksyncs = "allowaddressbooksyncs";
      public const string allowautoresponsecreation = "allowautoresponsecreation";
      public const string allowautounsubscribe = "allowautounsubscribe";
      public const string allowautounsubscribeacknowledgement = "allowautounsubscribeacknowledgement";
      public const string allowclientmessagebarad = "allowclientmessagebarad";
      public const string allowentityonlyaudit = "allowentityonlyaudit";
      public const string allowlegacyclientexperience = "allowlegacyclientexperience";
      public const string allowlegacydialogsembedding = "allowlegacydialogsembedding";
      public const string allowmarketingemailexecution = "allowmarketingemailexecution";
      public const string allowofflinescheduledsyncs = "allowofflinescheduledsyncs";
      public const string allowoutlookscheduledsyncs = "allowoutlookscheduledsyncs";
      public const string allowunresolvedpartiesonemailsend = "allowunresolvedpartiesonemailsend";
      public const string allowuserformmodepreference = "allowuserformmodepreference";
      public const string allowusersseeappdownloadmessage = "allowusersseeappdownloadmessage";
      public const string allowwebexcelexport = "allowwebexcelexport";
      public const string amdesignator = "amdesignator";
      public const string appdesignerexperienceenabled = "appdesignerexperienceenabled";
      public const string appointmentricheditorexperience = "appointmentricheditorexperience";
      public const string appointmentricheditorexperiencename = "appointmentricheditorexperiencename";
      public const string auditretentionperiod = "auditretentionperiod";
      public const string auditretentionperiodv2 = "auditretentionperiodv2";
      public const string autoapplydefaultoncasecreate = "autoapplydefaultoncasecreate";
      public const string autoapplydefaultoncasecreatename = "autoapplydefaultoncasecreatename";
      public const string autoapplydefaultoncaseupdate = "autoapplydefaultoncaseupdate";
      public const string autoapplydefaultoncaseupdatename = "autoapplydefaultoncaseupdatename";
      public const string autoapplysla = "autoapplysla";
      public const string azureschedulerjobcollectionname = "azureschedulerjobcollectionname";
      public const string basecurrencyid = "basecurrencyid";
      public const string basecurrencyidname = "basecurrencyidname";
      public const string basecurrencyprecision = "basecurrencyprecision";
      public const string basecurrencysymbol = "basecurrencysymbol";
      public const string baseisocurrencycode = "baseisocurrencycode";
      public const string bingmapsapikey = "bingmapsapikey";
      public const string blockedattachments = "blockedattachments";
      public const string bounddashboarddefaultcardexpanded = "bounddashboarddefaultcardexpanded";
      public const string bulkoperationprefix = "bulkoperationprefix";
      public const string businesscardoptions = "businesscardoptions";
      public const string businessclosurecalendarid = "businessclosurecalendarid";
      public const string calendartype = "calendartype";
      public const string campaignprefix = "campaignprefix";
      public const string cascadestatusupdate = "cascadestatusupdate";
      public const string caseprefix = "caseprefix";
      public const string categoryprefix = "categoryprefix";
      public const string clientfeatureset = "clientfeatureset";
      public const string contentsecuritypolicyconfiguration = "contentsecuritypolicyconfiguration";
      public const string contractprefix = "contractprefix";
      public const string cortanaproactiveexperienceenabled = "cortanaproactiveexperienceenabled";
      public const string createdby = "createdby";
      public const string createdbyname = "createdbyname";
      public const string createdbyyominame = "createdbyyominame";
      public const string createdon = "createdon";
      public const string createdonbehalfby = "createdonbehalfby";
      public const string createdonbehalfbyname = "createdonbehalfbyname";
      public const string createdonbehalfbyyominame = "createdonbehalfbyyominame";
      public const string createproductswithoutparentinactivestate = "createproductswithoutparentinactivestate";
      public const string currencydecimalprecision = "currencydecimalprecision";
      public const string currencydisplayoption = "currencydisplayoption";
      public const string currencyformatcode = "currencyformatcode";
      public const string currencyformatcodename = "currencyformatcodename";
      public const string currencysymbol = "currencysymbol";
      public const string currentbulkoperationnumber = "currentbulkoperationnumber";
      public const string currentcampaignnumber = "currentcampaignnumber";
      public const string currentcasenumber = "currentcasenumber";
      public const string currentcategorynumber = "currentcategorynumber";
      public const string currentcontractnumber = "currentcontractnumber";
      public const string currentimportsequencenumber = "currentimportsequencenumber";
      public const string currentinvoicenumber = "currentinvoicenumber";
      public const string currentkanumber = "currentkanumber";
      public const string currentkbnumber = "currentkbnumber";
      public const string currentordernumber = "currentordernumber";
      public const string currentparsedtablenumber = "currentparsedtablenumber";
      public const string currentquotenumber = "currentquotenumber";
      public const string dateformatcode = "dateformatcode";
      public const string dateformatcodename = "dateformatcodename";
      public const string dateformatstring = "dateformatstring";
      public const string dateseparator = "dateseparator";
      public const string dayssincerecordlastmodifiedmaxvalue = "dayssincerecordlastmodifiedmaxvalue";
      public const string decimalsymbol = "decimalsymbol";
      public const string defaultcountrycode = "defaultcountrycode";
      public const string defaultcrmcustomname = "defaultcrmcustomname";
      public const string defaultemailserverprofileid = "defaultemailserverprofileid";
      public const string defaultemailserverprofileidname = "defaultemailserverprofileidname";
      public const string defaultemailsettings = "defaultemailsettings";
      public const string defaultmobileofflineprofileid = "defaultmobileofflineprofileid";
      public const string defaultmobileofflineprofileidname = "defaultmobileofflineprofileidname";
      public const string defaultrecurrenceendrangetype = "defaultrecurrenceendrangetype";
      public const string defaultrecurrenceendrangetypename = "defaultrecurrenceendrangetypename";
      public const string defaultthemedata = "defaultthemedata";
      public const string delegatedadminuserid = "delegatedadminuserid";
      public const string disabledreason = "disabledreason";
      public const string disablesocialcare = "disablesocialcare";
      public const string discountcalculationmethod = "discountcalculationmethod";
      public const string displaynavigationtour = "displaynavigationtour";
      public const string emailconnectionchannel = "emailconnectionchannel";
      public const string emailcorrelationenabled = "emailcorrelationenabled";
      public const string emailsendpollingperiod = "emailsendpollingperiod";
      public const string enablebingmapsintegration = "enablebingmapsintegration";
      public const string enableimmersiveskypeintegration = "enableimmersiveskypeintegration";
      public const string enablelivepersonacarduci = "enablelivepersonacarduci";
      public const string enablelivepersoncardintegrationinoffice = "enablelivepersoncardintegrationinoffice";
      public const string enablelpauthoring = "enablelpauthoring";
      public const string enablemicrosoftflowintegration = "enablemicrosoftflowintegration";
      public const string enablepricingoncreate = "enablepricingoncreate";
      public const string enablesmartmatching = "enablesmartmatching";
      public const string enableunifiedinterfaceshellrefresh = "enableunifiedinterfaceshellrefresh";
      public const string enforcereadonlyplugins = "enforcereadonlyplugins";
      public const string entityimage = "entityimage";
      public const string entityimage_timestamp = "entityimage_timestamp";
      public const string entityimage_url = "entityimage_url";
      public const string entityimageid = "entityimageid";
      public const string expirechangetrackingindays = "expirechangetrackingindays";
      public const string expiresubscriptionsindays = "expiresubscriptionsindays";
      public const string externalbaseurl = "externalbaseurl";
      public const string externalpartycorrelationkeys = "externalpartycorrelationkeys";
      public const string externalpartyentitysettings = "externalpartyentitysettings";
      public const string featureset = "featureset";
      public const string fiscalcalendarstart = "fiscalcalendarstart";
      public const string fiscalperiodformat = "fiscalperiodformat";
      public const string fiscalperiodformatperiod = "fiscalperiodformatperiod";
      public const string fiscalperiodformatperiodname = "fiscalperiodformatperiodname";
      public const string fiscalperiodtype = "fiscalperiodtype";
      public const string fiscalsettingsupdated = "fiscalsettingsupdated";
      public const string fiscalsettingsupdatedname = "fiscalsettingsupdatedname";
      public const string fiscalyeardisplaycode = "fiscalyeardisplaycode";
      public const string fiscalyearformat = "fiscalyearformat";
      public const string fiscalyearformatprefix = "fiscalyearformatprefix";
      public const string fiscalyearformatprefixname = "fiscalyearformatprefixname";
      public const string fiscalyearformatsuffix = "fiscalyearformatsuffix";
      public const string fiscalyearformatsuffixname = "fiscalyearformatsuffixname";
      public const string fiscalyearformatyear = "fiscalyearformatyear";
      public const string fiscalyearformatyearname = "fiscalyearformatyearname";
      public const string fiscalyearperiodconnect = "fiscalyearperiodconnect";
      public const string fullnameconventioncode = "fullnameconventioncode";
      public const string fullnameconventioncodename = "fullnameconventioncodename";
      public const string futureexpansionwindow = "futureexpansionwindow";
      public const string generatealertsforerrors = "generatealertsforerrors";
      public const string generatealertsforinformation = "generatealertsforinformation";
      public const string generatealertsforwarnings = "generatealertsforwarnings";
      public const string getstartedpanecontentenabled = "getstartedpanecontentenabled";
      public const string globalappendurlparametersenabled = "globalappendurlparametersenabled";
      public const string globalhelpurl = "globalhelpurl";
      public const string globalhelpurlenabled = "globalhelpurlenabled";
      public const string goalrollupexpirytime = "goalrollupexpirytime";
      public const string goalrollupfrequency = "goalrollupfrequency";
      public const string grantaccesstonetworkservice = "grantaccesstonetworkservice";
      public const string hashdeltasubjectcount = "hashdeltasubjectcount";
      public const string hashfilterkeywords = "hashfilterkeywords";
      public const string hashmaxcount = "hashmaxcount";
      public const string hashminaddresscount = "hashminaddresscount";
      public const string highcontrastthemedata = "highcontrastthemedata";
      public const string ignoreinternalemail = "ignoreinternalemail";
      public const string inactivitytimeoutenabled = "inactivitytimeoutenabled";
      public const string inactivitytimeoutinmins = "inactivitytimeoutinmins";
      public const string inactivitytimeoutreminderinmins = "inactivitytimeoutreminderinmins";
      public const string incomingemailexchangeemailretrievalbatchsize = "incomingemailexchangeemailretrievalbatchsize";
      public const string initialversion = "initialversion";
      public const string integrationuserid = "integrationuserid";
      public const string invoiceprefix = "invoiceprefix";
      public const string isactioncardenabled = "isactioncardenabled";
      public const string isactionsupportfeatureenabled = "isactionsupportfeatureenabled";
      public const string isactivityanalysisenabled = "isactivityanalysisenabled";
      public const string isallmoneydecimal = "isallmoneydecimal";
      public const string isappmode = "isappmode";
      public const string isappointmentattachmentsyncenabled = "isappointmentattachmentsyncenabled";
      public const string isassignedtaskssyncenabled = "isassignedtaskssyncenabled";
      public const string isauditenabled = "isauditenabled";
      public const string isautodatacaptureenabled = "isautodatacaptureenabled";
      public const string isautodatacapturev2enabled = "isautodatacapturev2enabled";
      public const string isautosaveenabled = "isautosaveenabled";
      public const string isbpfentitycustomizationfeatureenabled = "isbpfentitycustomizationfeatureenabled";
      public const string isconflictdetectionenabledformobileclient = "isconflictdetectionenabledformobileclient";
      public const string iscontactmailingaddresssyncenabled = "iscontactmailingaddresssyncenabled";
      public const string iscontentsecuritypolicyenabled = "iscontentsecuritypolicyenabled";
      public const string iscontextualemailenabled = "iscontextualemailenabled";
      public const string iscontextualhelpenabled = "iscontextualhelpenabled";
      public const string iscustomcontrolsincanvasappsenabled = "iscustomcontrolsincanvasappsenabled";
      public const string isdefaultcountrycodecheckenabled = "isdefaultcountrycodecheckenabled";
      public const string isdelegateaccessenabled = "isdelegateaccessenabled";
      public const string isdelveactionhubintegrationenabled = "isdelveactionhubintegrationenabled";
      public const string isdisabled = "isdisabled";
      public const string isdisabledname = "isdisabledname";
      public const string isduplicatedetectionenabled = "isduplicatedetectionenabled";
      public const string isduplicatedetectionenabledforimport = "isduplicatedetectionenabledforimport";
      public const string isduplicatedetectionenabledforofflinesync = "isduplicatedetectionenabledforofflinesync";
      public const string isduplicatedetectionenabledforonlinecreateupdate = "isduplicatedetectionenabledforonlinecreateupdate";
      public const string isemailmonitoringallowed = "isemailmonitoringallowed";
      public const string isemailserverprofilecontentfilteringenabled = "isemailserverprofilecontentfilteringenabled";
      public const string isenabledforallroles = "isenabledforallroles";
      public const string isexternalfilestorageenabled = "isexternalfilestorageenabled";
      public const string isexternalsearchindexenabled = "isexternalsearchindexenabled";
      public const string isfiscalperiodmonthbased = "isfiscalperiodmonthbased";
      public const string isfolderautocreatedonsp = "isfolderautocreatedonsp";
      public const string isfolderbasedtrackingenabled = "isfolderbasedtrackingenabled";
      public const string isfulltextsearchenabled = "isfulltextsearchenabled";
      public const string isgeospatialazuremapsintegrationenabled = "isgeospatialazuremapsintegrationenabled";
      public const string ishierarchicalsecuritymodelenabled = "ishierarchicalsecuritymodelenabled";
      public const string isluisenabledford365bot = "isluisenabledford365bot";
      public const string ismailboxforcedunlockingenabled = "ismailboxforcedunlockingenabled";
      public const string ismailboxinactivebackoffenabled = "ismailboxinactivebackoffenabled";
      public const string ismanualsalesforecastingenabled = "ismanualsalesforecastingenabled";
      public const string ismobileclientondemandsyncenabled = "ismobileclientondemandsyncenabled";
      public const string ismobileofflineenabled = "ismobileofflineenabled";
      public const string ismodeldrivenappsinmsteamsenabled = "ismodeldrivenappsinmsteamsenabled";
      public const string ismsteamscollaborationenabled = "ismsteamscollaborationenabled";
      public const string ismsteamsenabled = "ismsteamsenabled";
      public const string ismsteamssettingchangedbyuser = "ismsteamssettingchangedbyuser";
      public const string ismsteamsusersyncenabled = "ismsteamsusersyncenabled";
      public const string isnewaddproductexperienceenabled = "isnewaddproductexperienceenabled";
      public const string isnotesanalysisenabled = "isnotesanalysisenabled";
      public const string isofficegraphenabled = "isofficegraphenabled";
      public const string isonedriveenabled = "isonedriveenabled";
      public const string ispaienabled = "ispaienabled";
      public const string ispdfgenerationenabled = "ispdfgenerationenabled";
      public const string isplaybookenabled = "isplaybookenabled";
      public const string ispresenceenabled = "ispresenceenabled";
      public const string ispresenceenabledname = "ispresenceenabledname";
      public const string ispreviewenabledforactioncard = "ispreviewenabledforactioncard";
      public const string ispreviewforautocaptureenabled = "ispreviewforautocaptureenabled";
      public const string ispreviewforemailmonitoringallowed = "ispreviewforemailmonitoringallowed";
      public const string ispricelistmandatory = "ispricelistmandatory";
      public const string isquickcreateenabledforopportunityclose = "isquickcreateenabledforopportunityclose";
      public const string isreadauditenabled = "isreadauditenabled";
      public const string isrelationshipinsightsenabled = "isrelationshipinsightsenabled";
      public const string isresourcebookingexchangesyncenabled = "isresourcebookingexchangesyncenabled";
      public const string isrichtextnotesenabled = "isrichtextnotesenabled";
      public const string issalesassistantenabled = "issalesassistantenabled";
      public const string issopintegrationenabled = "issopintegrationenabled";
      public const string istextwrapenabled = "istextwrapenabled";
      public const string isuseraccessauditenabled = "isuseraccessauditenabled";
      public const string isvintegrationcode = "isvintegrationcode";
      public const string iswriteinproductsallowed = "iswriteinproductsallowed";
      public const string kaprefix = "kaprefix";
      public const string kbprefix = "kbprefix";
      public const string kmsettings = "kmsettings";
      public const string languagecode = "languagecode";
      public const string languagecodename = "languagecodename";
      public const string localeid = "localeid";
      public const string longdateformatcode = "longdateformatcode";
      public const string mailboxintermittentissueminrange = "mailboxintermittentissueminrange";
      public const string mailboxpermanentissueminrange = "mailboxpermanentissueminrange";
      public const string maxactionstepsinbpf = "maxactionstepsinbpf";
      public const string maxappointmentdurationdays = "maxappointmentdurationdays";
      public const string maxconditionsformobileofflinefilters = "maxconditionsformobileofflinefilters";
      public const string maxdepthforhierarchicalsecuritymodel = "maxdepthforhierarchicalsecuritymodel";
      public const string maxfolderbasedtrackingmappings = "maxfolderbasedtrackingmappings";
      public const string maximumactivebusinessprocessflowsallowedperentity = "maximumactivebusinessprocessflowsallowedperentity";
      public const string maximumdynamicpropertiesallowed = "maximumdynamicpropertiesallowed";
      public const string maximumentitieswithactivesla = "maximumentitieswithactivesla";
      public const string maximumslakpiperentitywithactivesla = "maximumslakpiperentitywithactivesla";
      public const string maximumtrackingnumber = "maximumtrackingnumber";
      public const string maxproductsinbundle = "maxproductsinbundle";
      public const string maxrecordsforexporttoexcel = "maxrecordsforexporttoexcel";
      public const string maxrecordsforlookupfilters = "maxrecordsforlookupfilters";
      public const string maxslaitemspersla = "maxslaitemspersla";
      public const string maxsupportedinternetexplorerversion = "maxsupportedinternetexplorerversion";
      public const string maxuploadfilesize = "maxuploadfilesize";
      public const string maxverboseloggingmailbox = "maxverboseloggingmailbox";
      public const string maxverboseloggingsynccycles = "maxverboseloggingsynccycles";
      public const string metadatasynclasttimeofneverexpireddeletedobjects = "metadatasynclasttimeofneverexpireddeletedobjects";
      public const string metadatasynctimestamp = "metadatasynctimestamp";
      public const string microsoftflowenvironment = "microsoftflowenvironment";
      public const string minaddressbooksyncinterval = "minaddressbooksyncinterval";
      public const string minofflinesyncinterval = "minofflinesyncinterval";
      public const string minoutlooksyncinterval = "minoutlooksyncinterval";
      public const string mobileofflineminlicenseprod = "mobileofflineminlicenseprod";
      public const string mobileofflineminlicensetrial = "mobileofflineminlicensetrial";
      public const string mobileofflinesyncinterval = "mobileofflinesyncinterval";
      public const string modifiedby = "modifiedby";
      public const string modifiedbyname = "modifiedbyname";
      public const string modifiedbyyominame = "modifiedbyyominame";
      public const string modifiedon = "modifiedon";
      public const string modifiedonbehalfby = "modifiedonbehalfby";
      public const string modifiedonbehalfbyname = "modifiedonbehalfbyname";
      public const string modifiedonbehalfbyyominame = "modifiedonbehalfbyyominame";
      public const string name = "name";
      public const string negativecurrencyformatcode = "negativecurrencyformatcode";
      public const string negativeformatcode = "negativeformatcode";
      public const string negativeformatcodename = "negativeformatcodename";
      public const string nextcustomobjecttypecode = "nextcustomobjecttypecode";
      public const string nexttrackingnumber = "nexttrackingnumber";
      public const string notifymailboxownerofemailserverlevelalerts = "notifymailboxownerofemailserverlevelalerts";
      public const string numberformat = "numberformat";
      public const string numbergroupformat = "numbergroupformat";
      public const string numberseparator = "numberseparator";
      public const string officeappsautodeploymentenabled = "officeappsautodeploymentenabled";
      public const string officegraphdelveurl = "officegraphdelveurl";
      public const string oobpricecalculationenabled = "oobpricecalculationenabled";
      public const string orderprefix = "orderprefix";
      public const string organizationid = "organizationid";
      public const string organizationstate = "organizationstate";
      public const string orgdborgsettings = "orgdborgsettings";
      public const string orginsightsenabled = "orginsightsenabled";
      public const string paipreviewscenarioenabled = "paipreviewscenarioenabled";
      public const string parsedtablecolumnprefix = "parsedtablecolumnprefix";
      public const string parsedtableprefix = "parsedtableprefix";
      public const string pastexpansionwindow = "pastexpansionwindow";
      public const string picture = "picture";
      public const string pinpointlanguagecode = "pinpointlanguagecode";
      public const string plugintracelogsetting = "plugintracelogsetting";
      public const string plugintracelogsettingname = "plugintracelogsettingname";
      public const string pmdesignator = "pmdesignator";
      public const string postmessagewhitelistdomains = "postmessagewhitelistdomains";
      public const string powerbifeatureenabled = "powerbifeatureenabled";
      public const string pricingdecimalprecision = "pricingdecimalprecision";
      public const string privacystatementurl = "privacystatementurl";
      public const string privilegeusergroupid = "privilegeusergroupid";
      public const string privreportinggroupid = "privreportinggroupid";
      public const string privreportinggroupname = "privreportinggroupname";
      public const string productrecommendationsenabled = "productrecommendationsenabled";
      public const string qualifyleadadditionaloptions = "qualifyleadadditionaloptions";
      public const string quickfindrecordlimitenabled = "quickfindrecordlimitenabled";
      public const string quoteprefix = "quoteprefix";
      public const string recurrencedefaultnumberofoccurrences = "recurrencedefaultnumberofoccurrences";
      public const string recurrenceexpansionjobbatchinterval = "recurrenceexpansionjobbatchinterval";
      public const string recurrenceexpansionjobbatchsize = "recurrenceexpansionjobbatchsize";
      public const string recurrenceexpansionsynchcreatemax = "recurrenceexpansionsynchcreatemax";
      public const string referencesitemapxml = "referencesitemapxml";
      public const string rendersecureiframeforemail = "rendersecureiframeforemail";
      public const string reportinggroupid = "reportinggroupid";
      public const string reportinggroupname = "reportinggroupname";
      public const string reportscripterrors = "reportscripterrors";
      public const string reportscripterrorsname = "reportscripterrorsname";
      public const string requireapprovalforqueueemail = "requireapprovalforqueueemail";
      public const string requireapprovalforuseremail = "requireapprovalforuseremail";
      public const string resolvesimilarunresolvedemailaddress = "resolvesimilarunresolvedemailaddress";
      public const string restrictstatusupdate = "restrictstatusupdate";
      public const string rierrorstatus = "rierrorstatus";
      public const string sampledataimportid = "sampledataimportid";
      public const string schedulingengine = "schedulingengine";
      public const string schedulingenginename = "schedulingenginename";
      public const string schemanameprefix = "schemanameprefix";
      public const string sendbulkemailinuci = "sendbulkemailinuci";
      public const string servestaticresourcesfromazurecdn = "servestaticresourcesfromazurecdn";
      public const string sessiontimeoutenabled = "sessiontimeoutenabled";
      public const string sessiontimeoutinmins = "sessiontimeoutinmins";
      public const string sessiontimeoutreminderinmins = "sessiontimeoutreminderinmins";
      public const string sharepointdeploymenttype = "sharepointdeploymenttype";
      public const string sharetopreviousowneronassign = "sharetopreviousowneronassign";
      public const string showkbarticledeprecationnotification = "showkbarticledeprecationnotification";
      public const string showweeknumber = "showweeknumber";
      public const string showweeknumbername = "showweeknumbername";
      public const string signupoutlookdownloadfwlink = "signupoutlookdownloadfwlink";
      public const string sitemapxml = "sitemapxml";
      public const string slapausestates = "slapausestates";
      public const string socialinsightsenabled = "socialinsightsenabled";
      public const string socialinsightsinstance = "socialinsightsinstance";
      public const string socialinsightstermsaccepted = "socialinsightstermsaccepted";
      public const string sortid = "sortid";
      public const string sqlaccessgroupid = "sqlaccessgroupid";
      public const string sqlaccessgroupname = "sqlaccessgroupname";
      public const string sqmenabled = "sqmenabled";
      public const string supportuserid = "supportuserid";
      public const string suppresssla = "suppresssla";
      public const string syncbulkoperationbatchsize = "syncbulkoperationbatchsize";
      public const string syncbulkoperationmaxlimit = "syncbulkoperationmaxlimit";
      public const string syncoptinselection = "syncoptinselection";
      public const string syncoptinselectionstatus = "syncoptinselectionstatus";
      public const string systemuserid = "systemuserid";
      public const string tagmaxaggressivecycles = "tagmaxaggressivecycles";
      public const string tagpollingperiod = "tagpollingperiod";
      public const string taskbasedflowenabled = "taskbasedflowenabled";
      public const string textanalyticsenabled = "textanalyticsenabled";
      public const string timeformatcode = "timeformatcode";
      public const string timeformatcodename = "timeformatcodename";
      public const string timeformatstring = "timeformatstring";
      public const string timeseparator = "timeseparator";
      public const string timezoneruleversionnumber = "timezoneruleversionnumber";
      public const string tokenexpiry = "tokenexpiry";
      public const string tokenkey = "tokenkey";
      public const string tracelogmaximumageindays = "tracelogmaximumageindays";
      public const string trackingprefix = "trackingprefix";
      public const string trackingtokenidbase = "trackingtokenidbase";
      public const string trackingtokeniddigits = "trackingtokeniddigits";
      public const string uniquespecifierlength = "uniquespecifierlength";
      public const string unresolveemailaddressifmultiplematch = "unresolveemailaddressifmultiplematch";
      public const string useinbuiltrulefordefaultpricelistselection = "useinbuiltrulefordefaultpricelistselection";
      public const string uselegacyrendering = "uselegacyrendering";
      public const string usepositionhierarchy = "usepositionhierarchy";
      public const string usequickfindviewforgridsearch = "usequickfindviewforgridsearch";
      public const string useraccessauditinginterval = "useraccessauditinginterval";
      public const string usereadform = "usereadform";
      public const string usergroupid = "usergroupid";
      public const string useskypeprotocol = "useskypeprotocol";
      public const string utcconversiontimezonecode = "utcconversiontimezonecode";
      public const string v3calloutconfighash = "v3calloutconfighash";
      public const string versionnumber = "versionnumber";
      public const string webresourcehash = "webresourcehash";
      public const string weekstartdaycode = "weekstartdaycode";
      public const string weekstartdaycodename = "weekstartdaycodename";
      public const string widgetproperties = "widgetproperties";
      public const string yammergroupid = "yammergroupid";
      public const string yammernetworkpermalink = "yammernetworkpermalink";
      public const string yammeroauthaccesstokenexpired = "yammeroauthaccesstokenexpired";
      public const string yammerpostmethod = "yammerpostmethod";
      public const string yearstartweekcode = "yearstartweekcode";
    }
  }
}
