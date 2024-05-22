// Decompiled with JetBrains decompiler
// Type: TPCourt.EarlyBound.businessunit
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
  [EntityLogicalName("businessunit")]
  [GeneratedCode("XrmToolkit", "4.0")]
  [DataContract(Name = "Entity", Namespace = "http://schemas.microsoft.com/xrm/2011/Contracts")]
  public class businessunit : BaseProxyClass
  {
    public const string LogicalName = "businessunit";
    public const int ObjectTypeCode = 10;
    public const string PrimaryIdAttribute = "businessunitid";
    public const string PrimaryNameAttribute = "name";
    private static Dictionary<string, BaseProxyClass.eTextOptions> _textOptions;
    private static Dictionary<string, BaseProxyClass.eNumberOptions> _numberOptions;
    private static Dictionary<string, string> _errorStrings;

    static businessunit()
    {
      BaseProxyClass.RegisterProxyType(typeof (businessunit), nameof (businessunit));
      businessunit._textOptions = new Dictionary<string, BaseProxyClass.eTextOptions>();
      businessunit._numberOptions = new Dictionary<string, BaseProxyClass.eNumberOptions>();
      businessunit._errorStrings = new Dictionary<string, string>();
      businessunit.TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
      businessunit.NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
    }

    public businessunit()
      : base(new Entity(nameof (businessunit)))
    {
    }

    public businessunit(Entity original)
      : base(original)
    {
    }

    public static string GetLogicalName() => BaseProxyClass.GetLogicalName<businessunit>();

    public static BaseProxyClass.eTextOptions TextOptions { get; set; }

    public static void SetTextOptions(
      string logicalName,
      BaseProxyClass.eTextOptions options,
      string errorString = null)
    {
      if (businessunit._textOptions.ContainsKey(logicalName))
        businessunit._textOptions[logicalName] = options;
      else
        businessunit._textOptions.Add(logicalName, options);
      if (!string.IsNullOrEmpty(errorString))
      {
        if (businessunit._errorStrings.ContainsKey(logicalName))
          businessunit._errorStrings[logicalName] = errorString;
        else
          businessunit._errorStrings.Add(logicalName, errorString);
      }
      else
      {
        if (!businessunit._errorStrings.ContainsKey(logicalName))
          return;
        businessunit._errorStrings.Remove(logicalName);
      }
    }

    protected override BaseProxyClass.eTextOptions GetTextOptions(string logicalName)
    {
      return businessunit._textOptions.ContainsKey(logicalName) ? businessunit._textOptions[logicalName] : businessunit.TextOptions;
    }

    public static BaseProxyClass.eNumberOptions NumberOptions { get; set; }

    public static void SetNumberOptions(
      string logicalName,
      BaseProxyClass.eNumberOptions options,
      string errorString = null)
    {
      if (businessunit._numberOptions.ContainsKey(logicalName))
        businessunit._numberOptions[logicalName] = options;
      else
        businessunit._numberOptions.Add(logicalName, options);
      if (!string.IsNullOrEmpty(errorString))
      {
        if (businessunit._errorStrings.ContainsKey(logicalName))
          businessunit._errorStrings[logicalName] = errorString;
        else
          businessunit._errorStrings.Add(logicalName, errorString);
      }
      else
      {
        if (!businessunit._errorStrings.ContainsKey(logicalName))
          return;
        businessunit._errorStrings.Remove(logicalName);
      }
    }

    protected override BaseProxyClass.eNumberOptions GetNumberOptions(string logicalName)
    {
      return businessunit._numberOptions.ContainsKey(logicalName) ? businessunit._numberOptions[logicalName] : businessunit.NumberOptions;
    }

    protected override string GetErrorString(
      string attributeName,
      BaseProxyClass.eErrorType defaultErrorType)
    {
      return businessunit._errorStrings.ContainsKey(attributeName) ? businessunit._errorStrings[attributeName] : (defaultErrorType == BaseProxyClass.eErrorType.Text ? businessunit.TextError : businessunit.NumberError);
    }

    public static string TextError { get; set; }

    public static string NumberError { get; set; }

    [AttributeLogicalName("address1_addressid")]
    public Guid address1_addressid
    {
      get => this.GetPropertyValue<Guid>(nameof (address1_addressid));
      set
      {
        this.SetPropertyValue<Guid>(nameof (address1_addressid), value, nameof (address1_addressid));
      }
    }

    [AttributeLogicalName("address1_addresstypecode")]
    public eBusinessunit_address1_addresstypecode? address1_addresstypecode
    {
      get
      {
        return this.address1_addresstypecode_OptionSetValue != null ? new eBusinessunit_address1_addresstypecode?((eBusinessunit_address1_addresstypecode) this.address1_addresstypecode_OptionSetValue.Value) : new eBusinessunit_address1_addresstypecode?();
      }
      set
      {
        if (value.HasValue)
          this.address1_addresstypecode_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.address1_addresstypecode_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("address1_addresstypecode")]
    public OptionSetValue address1_addresstypecode_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("address1_addresstypecode");
      set
      {
        this.SetPropertyValue<OptionSetValue>("address1_addresstypecode", value, nameof (address1_addresstypecode_OptionSetValue));
      }
    }

    public string address1_addresstypecode_Text(IOrganizationService service)
    {
      return this.address1_addresstypecode_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "address1_addresstypecode");
    }

    public string address1_addresstypecode_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.address1_addresstypecode_OptionSetValue.Value);
    }

    [AttributeLogicalName("address1_city")]
    public string address1_city
    {
      get => this.GetPropertyValue<string>(nameof (address1_city));
      set => this.SetPropertyValue(nameof (address1_city), value, 80, nameof (address1_city));
    }

    [AttributeLogicalName("address1_country")]
    public string address1_country
    {
      get => this.GetPropertyValue<string>(nameof (address1_country));
      set => this.SetPropertyValue(nameof (address1_country), value, 80, nameof (address1_country));
    }

    [AttributeLogicalName("address1_county")]
    public string address1_county
    {
      get => this.GetPropertyValue<string>(nameof (address1_county));
      set => this.SetPropertyValue(nameof (address1_county), value, 50, nameof (address1_county));
    }

    [AttributeLogicalName("address1_fax")]
    public string address1_fax
    {
      get => this.GetPropertyValue<string>(nameof (address1_fax));
      set => this.SetPropertyValue(nameof (address1_fax), value, 50, nameof (address1_fax));
    }

    [AttributeLogicalName("address1_latitude")]
    public double? address1_latitude
    {
      get => this.GetPropertyValue<double?>(nameof (address1_latitude));
      set
      {
        this.SetPropertyValue(nameof (address1_latitude), value, -90.0, 90.0, nameof (address1_latitude));
      }
    }

    [AttributeLogicalName("address1_line1")]
    public string address1_line1
    {
      get => this.GetPropertyValue<string>(nameof (address1_line1));
      set => this.SetPropertyValue(nameof (address1_line1), value, 250, nameof (address1_line1));
    }

    [AttributeLogicalName("address1_line2")]
    public string address1_line2
    {
      get => this.GetPropertyValue<string>(nameof (address1_line2));
      set => this.SetPropertyValue(nameof (address1_line2), value, 250, nameof (address1_line2));
    }

    [AttributeLogicalName("address1_line3")]
    public string address1_line3
    {
      get => this.GetPropertyValue<string>(nameof (address1_line3));
      set => this.SetPropertyValue(nameof (address1_line3), value, 250, nameof (address1_line3));
    }

    [AttributeLogicalName("address1_longitude")]
    public double? address1_longitude
    {
      get => this.GetPropertyValue<double?>(nameof (address1_longitude));
      set
      {
        this.SetPropertyValue(nameof (address1_longitude), value, -180.0, 180.0, nameof (address1_longitude));
      }
    }

    [AttributeLogicalName("address1_name")]
    public string address1_name
    {
      get => this.GetPropertyValue<string>(nameof (address1_name));
      set => this.SetPropertyValue(nameof (address1_name), value, 100, nameof (address1_name));
    }

    [AttributeLogicalName("address1_postalcode")]
    public string address1_postalcode
    {
      get => this.GetPropertyValue<string>(nameof (address1_postalcode));
      set
      {
        this.SetPropertyValue(nameof (address1_postalcode), value, 20, nameof (address1_postalcode));
      }
    }

    [AttributeLogicalName("address1_postofficebox")]
    public string address1_postofficebox
    {
      get => this.GetPropertyValue<string>(nameof (address1_postofficebox));
      set
      {
        this.SetPropertyValue(nameof (address1_postofficebox), value, 20, nameof (address1_postofficebox));
      }
    }

    [AttributeLogicalName("address1_shippingmethodcode")]
    public eBusinessunit_address1_shippingmethodcode? address1_shippingmethodcode
    {
      get
      {
        return this.address1_shippingmethodcode_OptionSetValue != null ? new eBusinessunit_address1_shippingmethodcode?((eBusinessunit_address1_shippingmethodcode) this.address1_shippingmethodcode_OptionSetValue.Value) : new eBusinessunit_address1_shippingmethodcode?();
      }
      set
      {
        if (value.HasValue)
          this.address1_shippingmethodcode_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.address1_shippingmethodcode_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("address1_shippingmethodcode")]
    public OptionSetValue address1_shippingmethodcode_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("address1_shippingmethodcode");
      set
      {
        this.SetPropertyValue<OptionSetValue>("address1_shippingmethodcode", value, nameof (address1_shippingmethodcode_OptionSetValue));
      }
    }

    public string address1_shippingmethodcode_Text(IOrganizationService service)
    {
      return this.address1_shippingmethodcode_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "address1_shippingmethodcode");
    }

    public string address1_shippingmethodcode_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.address1_shippingmethodcode_OptionSetValue.Value);
    }

    [AttributeLogicalName("address1_stateorprovince")]
    public string address1_stateorprovince
    {
      get => this.GetPropertyValue<string>(nameof (address1_stateorprovince));
      set
      {
        this.SetPropertyValue(nameof (address1_stateorprovince), value, 50, nameof (address1_stateorprovince));
      }
    }

    [AttributeLogicalName("address1_telephone1")]
    public string address1_telephone1
    {
      get => this.GetPropertyValue<string>(nameof (address1_telephone1));
      set
      {
        this.SetPropertyValue(nameof (address1_telephone1), value, 50, nameof (address1_telephone1));
      }
    }

    [AttributeLogicalName("address1_telephone2")]
    public string address1_telephone2
    {
      get => this.GetPropertyValue<string>(nameof (address1_telephone2));
      set
      {
        this.SetPropertyValue(nameof (address1_telephone2), value, 50, nameof (address1_telephone2));
      }
    }

    [AttributeLogicalName("address1_telephone3")]
    public string address1_telephone3
    {
      get => this.GetPropertyValue<string>(nameof (address1_telephone3));
      set
      {
        this.SetPropertyValue(nameof (address1_telephone3), value, 50, nameof (address1_telephone3));
      }
    }

    [AttributeLogicalName("address1_upszone")]
    public string address1_upszone
    {
      get => this.GetPropertyValue<string>(nameof (address1_upszone));
      set => this.SetPropertyValue(nameof (address1_upszone), value, 4, nameof (address1_upszone));
    }

    [AttributeLogicalName("address1_utcoffset")]
    public int? address1_utcoffset
    {
      get => this.GetPropertyValue<int?>(nameof (address1_utcoffset));
      set
      {
        this.SetPropertyValue(nameof (address1_utcoffset), value, -1500, 1500, nameof (address1_utcoffset));
      }
    }

    [AttributeLogicalName("address2_addressid")]
    public Guid address2_addressid
    {
      get => this.GetPropertyValue<Guid>(nameof (address2_addressid));
      set
      {
        this.SetPropertyValue<Guid>(nameof (address2_addressid), value, nameof (address2_addressid));
      }
    }

    [AttributeLogicalName("address2_addresstypecode")]
    public eBusinessunit_address2_addresstypecode? address2_addresstypecode
    {
      get
      {
        return this.address2_addresstypecode_OptionSetValue != null ? new eBusinessunit_address2_addresstypecode?((eBusinessunit_address2_addresstypecode) this.address2_addresstypecode_OptionSetValue.Value) : new eBusinessunit_address2_addresstypecode?();
      }
      set
      {
        if (value.HasValue)
          this.address2_addresstypecode_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.address2_addresstypecode_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("address2_addresstypecode")]
    public OptionSetValue address2_addresstypecode_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("address2_addresstypecode");
      set
      {
        this.SetPropertyValue<OptionSetValue>("address2_addresstypecode", value, nameof (address2_addresstypecode_OptionSetValue));
      }
    }

    public string address2_addresstypecode_Text(IOrganizationService service)
    {
      return this.address2_addresstypecode_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "address2_addresstypecode");
    }

    public string address2_addresstypecode_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.address2_addresstypecode_OptionSetValue.Value);
    }

    [AttributeLogicalName("address2_city")]
    public string address2_city
    {
      get => this.GetPropertyValue<string>(nameof (address2_city));
      set => this.SetPropertyValue(nameof (address2_city), value, 80, nameof (address2_city));
    }

    [AttributeLogicalName("address2_country")]
    public string address2_country
    {
      get => this.GetPropertyValue<string>(nameof (address2_country));
      set => this.SetPropertyValue(nameof (address2_country), value, 80, nameof (address2_country));
    }

    [AttributeLogicalName("address2_county")]
    public string address2_county
    {
      get => this.GetPropertyValue<string>(nameof (address2_county));
      set => this.SetPropertyValue(nameof (address2_county), value, 50, nameof (address2_county));
    }

    [AttributeLogicalName("address2_fax")]
    public string address2_fax
    {
      get => this.GetPropertyValue<string>(nameof (address2_fax));
      set => this.SetPropertyValue(nameof (address2_fax), value, 50, nameof (address2_fax));
    }

    [AttributeLogicalName("address2_latitude")]
    public double? address2_latitude
    {
      get => this.GetPropertyValue<double?>(nameof (address2_latitude));
      set
      {
        this.SetPropertyValue(nameof (address2_latitude), value, -90.0, 90.0, nameof (address2_latitude));
      }
    }

    [AttributeLogicalName("address2_line1")]
    public string address2_line1
    {
      get => this.GetPropertyValue<string>(nameof (address2_line1));
      set => this.SetPropertyValue(nameof (address2_line1), value, 250, nameof (address2_line1));
    }

    [AttributeLogicalName("address2_line2")]
    public string address2_line2
    {
      get => this.GetPropertyValue<string>(nameof (address2_line2));
      set => this.SetPropertyValue(nameof (address2_line2), value, 250, nameof (address2_line2));
    }

    [AttributeLogicalName("address2_line3")]
    public string address2_line3
    {
      get => this.GetPropertyValue<string>(nameof (address2_line3));
      set => this.SetPropertyValue(nameof (address2_line3), value, 250, nameof (address2_line3));
    }

    [AttributeLogicalName("address2_longitude")]
    public double? address2_longitude
    {
      get => this.GetPropertyValue<double?>(nameof (address2_longitude));
      set
      {
        this.SetPropertyValue(nameof (address2_longitude), value, -180.0, 180.0, nameof (address2_longitude));
      }
    }

    [AttributeLogicalName("address2_name")]
    public string address2_name
    {
      get => this.GetPropertyValue<string>(nameof (address2_name));
      set => this.SetPropertyValue(nameof (address2_name), value, 100, nameof (address2_name));
    }

    [AttributeLogicalName("address2_postalcode")]
    public string address2_postalcode
    {
      get => this.GetPropertyValue<string>(nameof (address2_postalcode));
      set
      {
        this.SetPropertyValue(nameof (address2_postalcode), value, 20, nameof (address2_postalcode));
      }
    }

    [AttributeLogicalName("address2_postofficebox")]
    public string address2_postofficebox
    {
      get => this.GetPropertyValue<string>(nameof (address2_postofficebox));
      set
      {
        this.SetPropertyValue(nameof (address2_postofficebox), value, 20, nameof (address2_postofficebox));
      }
    }

    [AttributeLogicalName("address2_shippingmethodcode")]
    public eBusinessunit_address2_shippingmethodcode? address2_shippingmethodcode
    {
      get
      {
        return this.address2_shippingmethodcode_OptionSetValue != null ? new eBusinessunit_address2_shippingmethodcode?((eBusinessunit_address2_shippingmethodcode) this.address2_shippingmethodcode_OptionSetValue.Value) : new eBusinessunit_address2_shippingmethodcode?();
      }
      set
      {
        if (value.HasValue)
          this.address2_shippingmethodcode_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.address2_shippingmethodcode_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("address2_shippingmethodcode")]
    public OptionSetValue address2_shippingmethodcode_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("address2_shippingmethodcode");
      set
      {
        this.SetPropertyValue<OptionSetValue>("address2_shippingmethodcode", value, nameof (address2_shippingmethodcode_OptionSetValue));
      }
    }

    public string address2_shippingmethodcode_Text(IOrganizationService service)
    {
      return this.address2_shippingmethodcode_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "address2_shippingmethodcode");
    }

    public string address2_shippingmethodcode_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.address2_shippingmethodcode_OptionSetValue.Value);
    }

    [AttributeLogicalName("address2_stateorprovince")]
    public string address2_stateorprovince
    {
      get => this.GetPropertyValue<string>(nameof (address2_stateorprovince));
      set
      {
        this.SetPropertyValue(nameof (address2_stateorprovince), value, 50, nameof (address2_stateorprovince));
      }
    }

    [AttributeLogicalName("address2_telephone1")]
    public string address2_telephone1
    {
      get => this.GetPropertyValue<string>(nameof (address2_telephone1));
      set
      {
        this.SetPropertyValue(nameof (address2_telephone1), value, 50, nameof (address2_telephone1));
      }
    }

    [AttributeLogicalName("address2_telephone2")]
    public string address2_telephone2
    {
      get => this.GetPropertyValue<string>(nameof (address2_telephone2));
      set
      {
        this.SetPropertyValue(nameof (address2_telephone2), value, 50, nameof (address2_telephone2));
      }
    }

    [AttributeLogicalName("address2_telephone3")]
    public string address2_telephone3
    {
      get => this.GetPropertyValue<string>(nameof (address2_telephone3));
      set
      {
        this.SetPropertyValue(nameof (address2_telephone3), value, 50, nameof (address2_telephone3));
      }
    }

    [AttributeLogicalName("address2_upszone")]
    public string address2_upszone
    {
      get => this.GetPropertyValue<string>(nameof (address2_upszone));
      set => this.SetPropertyValue(nameof (address2_upszone), value, 4, nameof (address2_upszone));
    }

    [AttributeLogicalName("address2_utcoffset")]
    public int? address2_utcoffset
    {
      get => this.GetPropertyValue<int?>(nameof (address2_utcoffset));
      set
      {
        this.SetPropertyValue(nameof (address2_utcoffset), value, -1500, 1500, nameof (address2_utcoffset));
      }
    }

    [AttributeLogicalName("businessunitid")]
    public Guid businessunitid
    {
      get => this.Id;
      set
      {
        this.Id = value;
        this.SetPropertyValue<Guid>(nameof (businessunitid), value, nameof (businessunitid));
      }
    }

    [AttributeLogicalName("calendarid")]
    public EntityReference calendarid
    {
      get => this.GetPropertyValue<EntityReference>(nameof (calendarid));
      set
      {
        this.SetPropertyValue<EntityReference>(nameof (calendarid), value, nameof (calendarid));
      }
    }

    [AttributeLogicalName("costcenter")]
    public string costcenter
    {
      get => this.GetPropertyValue<string>(nameof (costcenter));
      set => this.SetPropertyValue(nameof (costcenter), value, 100, nameof (costcenter));
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

    [AttributeLogicalName("creditlimit")]
    public double? creditlimit
    {
      get => this.GetPropertyValue<double?>(nameof (creditlimit));
      set
      {
        this.SetPropertyValue(nameof (creditlimit), value, 0.0, 1000000000.0, nameof (creditlimit));
      }
    }

    [AttributeLogicalName("description")]
    public string description
    {
      get => this.GetPropertyValue<string>(nameof (description));
      set => this.SetPropertyValue(nameof (description), value, 2000, nameof (description));
    }

    [AttributeLogicalName("disabledreason")]
    public string disabledreason => this.GetPropertyValue<string>(nameof (disabledreason));

    [AttributeLogicalName("divisionname")]
    public string divisionname
    {
      get => this.GetPropertyValue<string>(nameof (divisionname));
      set => this.SetPropertyValue(nameof (divisionname), value, 100, nameof (divisionname));
    }

    [AttributeLogicalName("emailaddress")]
    public string emailaddress
    {
      get => this.GetPropertyValue<string>(nameof (emailaddress));
      set => this.SetPropertyValue(nameof (emailaddress), value, 100, nameof (emailaddress));
    }

    [AttributeLogicalName("exchangerate")]
    public Decimal? exchangerate => this.GetPropertyValue<Decimal?>(nameof (exchangerate));

    [AttributeLogicalName("fileasname")]
    public string fileasname
    {
      get => this.GetPropertyValue<string>(nameof (fileasname));
      set => this.SetPropertyValue(nameof (fileasname), value, 100, nameof (fileasname));
    }

    [AttributeLogicalName("ftpsiteurl")]
    public string ftpsiteurl
    {
      get => this.GetPropertyValue<string>(nameof (ftpsiteurl));
      set => this.SetPropertyValue(nameof (ftpsiteurl), value, 200, nameof (ftpsiteurl));
    }

    [AttributeLogicalName("importsequencenumber")]
    public int? importsequencenumber
    {
      get => this.GetPropertyValue<int?>(nameof (importsequencenumber));
      set
      {
        this.SetPropertyValue(nameof (importsequencenumber), value, int.MinValue, int.MaxValue, nameof (importsequencenumber));
      }
    }

    [AttributeLogicalName("inheritancemask")]
    public int? inheritancemask
    {
      get => this.GetPropertyValue<int?>(nameof (inheritancemask));
      set
      {
        this.SetPropertyValue(nameof (inheritancemask), value, 0, 1000000000, nameof (inheritancemask));
      }
    }

    [AttributeLogicalName("isdisabled")]
    public bool? isdisabled
    {
      get => this.GetPropertyValue<bool?>(nameof (isdisabled));
      set => this.SetPropertyValue<bool?>(nameof (isdisabled), value, nameof (isdisabled));
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

    [AttributeLogicalName("organizationid")]
    public EntityReference organizationid
    {
      get => this.GetPropertyValue<EntityReference>(nameof (organizationid));
    }

    [AttributeLogicalName("organizationidname")]
    public string organizationidname => this.GetPropertyValue<string>(nameof (organizationidname));

    [AttributeLogicalName("overriddencreatedon")]
    public DateTime? overriddencreatedon
    {
      get => this.GetPropertyValue<DateTime?>(nameof (overriddencreatedon));
      set
      {
        this.SetPropertyValue<DateTime?>(nameof (overriddencreatedon), value, nameof (overriddencreatedon));
      }
    }

    [AttributeLogicalName("parentbusinessunitid")]
    public EntityReference parentbusinessunitid
    {
      get => this.GetPropertyValue<EntityReference>(nameof (parentbusinessunitid));
      set
      {
        this.SetPropertyValue<EntityReference>(nameof (parentbusinessunitid), value, nameof (parentbusinessunitid));
      }
    }

    [AttributeLogicalName("parentbusinessunitidname")]
    public string parentbusinessunitidname
    {
      get => this.GetPropertyValue<string>(nameof (parentbusinessunitidname));
    }

    [AttributeLogicalName("picture")]
    public string picture
    {
      get => this.GetPropertyValue<string>(nameof (picture));
      set => this.SetPropertyValue(nameof (picture), value, 1073741823, nameof (picture));
    }

    [AttributeLogicalName("stockexchange")]
    public string stockexchange
    {
      get => this.GetPropertyValue<string>(nameof (stockexchange));
      set => this.SetPropertyValue(nameof (stockexchange), value, 20, nameof (stockexchange));
    }

    [AttributeLogicalName("tickersymbol")]
    public string tickersymbol
    {
      get => this.GetPropertyValue<string>(nameof (tickersymbol));
      set => this.SetPropertyValue(nameof (tickersymbol), value, 10, nameof (tickersymbol));
    }

    [AttributeLogicalName("transactioncurrencyid")]
    public EntityReference transactioncurrencyid
    {
      get => this.GetPropertyValue<EntityReference>(nameof (transactioncurrencyid));
      set
      {
        this.SetPropertyValue<EntityReference>(nameof (transactioncurrencyid), value, nameof (transactioncurrencyid));
      }
    }

    [AttributeLogicalName("transactioncurrencyidname")]
    public string transactioncurrencyidname
    {
      get => this.GetPropertyValue<string>(nameof (transactioncurrencyidname));
    }

    [AttributeLogicalName("usergroupid")]
    public Guid usergroupid => this.GetPropertyValue<Guid>(nameof (usergroupid));

    [AttributeLogicalName("utcoffset")]
    public int? utcoffset
    {
      get => this.GetPropertyValue<int?>(nameof (utcoffset));
      set => this.SetPropertyValue(nameof (utcoffset), value, -1500, 1500, nameof (utcoffset));
    }

    [AttributeLogicalName("versionnumber")]
    public int? versionnumber => this.GetPropertyValue<int?>(nameof (versionnumber));

    [AttributeLogicalName("websiteurl")]
    public string websiteurl
    {
      get => this.GetPropertyValue<string>(nameof (websiteurl));
      set => this.SetPropertyValue(nameof (websiteurl), value, 200, nameof (websiteurl));
    }

    [AttributeLogicalName("workflowsuspended")]
    public bool? workflowsuspended
    {
      get => this.GetPropertyValue<bool?>(nameof (workflowsuspended));
      set
      {
        this.SetPropertyValue<bool?>(nameof (workflowsuspended), value, nameof (workflowsuspended));
      }
    }

    public List<account> Getbusiness_unit_accounts(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<account>(service, this.Id, "account", "owningbusinessunit", columns);
    }

    public List<account> Getbusiness_unit_accounts(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<account>(service, this.Id, "account", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_actioncards(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "actioncard", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_actioncards(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "actioncard", "owningbusinessunit", columns);
    }

    public List<Entity> Getactioncardusersettings_businessunit(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "actioncardusersettings", "owningbusinessunit", columns);
    }

    public List<Entity> Getactioncardusersettings_businessunit(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "actioncardusersettings", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_activitypointer(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "activitypointer", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_activitypointer(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "activitypointer", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_adminsettingsentity(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "adminsettingsentity", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_adminsettingsentity(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "adminsettingsentity", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_birthrecord(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_birthrecord", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_birthrecord(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_birthrecord", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_bloodquantum(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_bloodquantum", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_bloodquantum(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_bloodquantum", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_cardhistory(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_cardhistory", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_cardhistory(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_cardhistory", "owningbusinessunit", columns);
    }

    public List<ait_casenote> Getbusiness_unit_ait_casenote(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_casenote>(service, this.Id, "ait_casenote", "owningbusinessunit", columns);
    }

    public List<ait_casenote> Getbusiness_unit_ait_casenote(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_casenote>(service, this.Id, "ait_casenote", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_charge(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_charge", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_charge(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_charge", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_company(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_company", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_company(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_company", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_contactcertification(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contactcertification", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_contactcertification(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contactcertification", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_contacteducation(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contacteducation", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_contacteducation(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contacteducation", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_contactemployment(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contactemployment", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_contactemployment(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contactemployment", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_contactimage(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contactimage", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_contactimage(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contactimage", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_contactincarceration(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contactincarceration", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_contactincarceration(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contactincarceration", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_contactincomeandexpense(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contactincomeandexpense", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_contactincomeandexpense(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contactincomeandexpense", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_contactlanguage(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contactlanguage", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_contactlanguage(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contactlanguage", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_contactmilitaryservice(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contactmilitaryservice", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_contactmilitaryservice(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contactmilitaryservice", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_contactname(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contactname", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_contactname(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contactname", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_contactskill(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contactskill", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_contactskill(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contactskill", "owningbusinessunit", columns);
    }

    public List<ait_courtcase> Getbusiness_unit_ait_courtcase(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_courtcase>(service, this.Id, "ait_courtcase", "owningbusinessunit", columns);
    }

    public List<ait_courtcase> Getbusiness_unit_ait_courtcase(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_courtcase>(service, this.Id, "ait_courtcase", "owningbusinessunit", columns);
    }

    public List<ait_courtfinesandfees> Getbusiness_unit_ait_courtfinesandfees(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_courtfinesandfees>(service, this.Id, "ait_courtfinesandfees", "owningbusinessunit", columns);
    }

    public List<ait_courtfinesandfees> Getbusiness_unit_ait_courtfinesandfees(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_courtfinesandfees>(service, this.Id, "ait_courtfinesandfees", "owningbusinessunit", columns);
    }

    public List<ait_courtparty> Getbusiness_unit_ait_courtparty(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_courtparty>(service, this.Id, "ait_courtparty", "owningbusinessunit", columns);
    }

    public List<ait_courtparty> Getbusiness_unit_ait_courtparty(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_courtparty>(service, this.Id, "ait_courtparty", "owningbusinessunit", columns);
    }

    public List<ait_courtpayments> Getbusiness_unit_ait_courtpayments(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_courtpayments>(service, this.Id, "ait_courtpayments", "owningbusinessunit", columns);
    }

    public List<ait_courtpayments> Getbusiness_unit_ait_courtpayments(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_courtpayments>(service, this.Id, "ait_courtpayments", "owningbusinessunit", columns);
    }

    public List<ait_courtprofile> Getbusiness_unit_ait_courtprofile(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_courtprofile>(service, this.Id, "ait_courtprofile", "owningbusinessunit", columns);
    }

    public List<ait_courtprofile> Getbusiness_unit_ait_courtprofile(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_courtprofile>(service, this.Id, "ait_courtprofile", "owningbusinessunit", columns);
    }

    public List<ait_courtprofileaddress> Getbusiness_unit_ait_courtprofileaddress(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_courtprofileaddress>(service, this.Id, "ait_courtprofileaddress", "owningbusinessunit", columns);
    }

    public List<ait_courtprofileaddress> Getbusiness_unit_ait_courtprofileaddress(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_courtprofileaddress>(service, this.Id, "ait_courtprofileaddress", "owningbusinessunit", columns);
    }

    public List<ait_courtroom> Getbusiness_unit_ait_courtroom(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_courtroom>(service, this.Id, "ait_courtroom", "owningbusinessunit", columns);
    }

    public List<ait_courtroom> Getbusiness_unit_ait_courtroom(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_courtroom>(service, this.Id, "ait_courtroom", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_datamigrationhistory(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_datamigrationhistory", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_datamigrationhistory(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_datamigrationhistory", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_deathrecord(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_deathrecord", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_deathrecord(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_deathrecord", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_electronicaddress(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_electronicaddress", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_electronicaddress(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_electronicaddress", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_emergencycontact(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_emergencycontact", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_emergencycontact(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_emergencycontact", "owningbusinessunit", columns);
    }

    public List<Entity> Getait_hearing_businessunit_owningbusinessunit(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_hearing", "owningbusinessunit", columns);
    }

    public List<Entity> Getait_hearing_businessunit_owningbusinessunit(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_hearing", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_household(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_household", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_household(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_household", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_householdmember(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_householdmember", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_householdmember(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_householdmember", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_memberprofile(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_memberprofile", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_memberprofile(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_memberprofile", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_memberprofilemembershipcategory(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_memberprofilemembershipcategory", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_memberprofilemembershipcategory(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_memberprofilemembershipcategory", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_memberroll(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_memberroll", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_memberroll(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_memberroll", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_membershipstatuschangerequest(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_membershipstatuschangerequest", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_membershipstatuschangerequest(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_membershipstatuschangerequest", "owningbusinessunit", columns);
    }

    public List<ait_physicaladdress> Getbusiness_unit_ait_physicaladdress(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_physicaladdress>(service, this.Id, "ait_physicaladdress", "owningbusinessunit", columns);
    }

    public List<ait_physicaladdress> Getbusiness_unit_ait_physicaladdress(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_physicaladdress>(service, this.Id, "ait_physicaladdress", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_relationship(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_relationship", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_relationship(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_relationship", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_resolution(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_resolution", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_resolution(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_resolution", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_school(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_school", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_school(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_school", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_statute(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_statute", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_statute(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_statute", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_training(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_training", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_training(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_training", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_trainingtype(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_trainingtype", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ait_trainingtype(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_trainingtype", "owningbusinessunit", columns);
    }

    public List<ait_tribalenrollmentconfiguration> Getbusiness_unit_ait_tribalenrollmentconfiguration(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_tribalenrollmentconfiguration>(service, this.Id, "ait_tribalenrollmentconfiguration", "owningbusinessunit", columns);
    }

    public List<ait_tribalenrollmentconfiguration> Getbusiness_unit_ait_tribalenrollmentconfiguration(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_tribalenrollmentconfiguration>(service, this.Id, "ait_tribalenrollmentconfiguration", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_annotations(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "annotation", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_annotations(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "annotation", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_applicationuser(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "applicationuser", "businessunitid", columns);
    }

    public List<Entity> Getbusiness_unit_applicationuser(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "applicationuser", "businessunitid", columns);
    }

    public List<appointment> Getbusiness_unit_appointment_activities(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<appointment>(service, this.Id, "appointment", "owningbusinessunit", columns);
    }

    public List<appointment> Getbusiness_unit_appointment_activities(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<appointment>(service, this.Id, "appointment", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_asyncoperation(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "asyncoperation", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_asyncoperation(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "asyncoperation", "owningbusinessunit", columns);
    }

    public List<Entity> GetBusinessUnit_AsyncOperations(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "asyncoperation", "regardingobjectid", columns);
    }

    public List<Entity> GetBusinessUnit_AsyncOperations(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "asyncoperation", "regardingobjectid", columns);
    }

    public List<Entity> Getbusiness_unit_bookableresource(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bookableresource", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_bookableresource(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bookableresource", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_bookableresourcebooking(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bookableresourcebooking", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_bookableresourcebooking(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bookableresourcebooking", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_bookableresourcebookingexchangesyncidmapping(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bookableresourcebookingexchangesyncidmapping", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_bookableresourcebookingexchangesyncidmapping(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bookableresourcebookingexchangesyncidmapping", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_bookableresourcebookingheader(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bookableresourcebookingheader", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_bookableresourcebookingheader(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bookableresourcebookingheader", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_bookableresourcecategory(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bookableresourcecategory", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_bookableresourcecategory(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bookableresourcecategory", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_bookableresourcecategoryassn(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bookableresourcecategoryassn", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_bookableresourcecategoryassn(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bookableresourcecategoryassn", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_bookableresourcecharacteristic(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bookableresourcecharacteristic", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_bookableresourcecharacteristic(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bookableresourcecharacteristic", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_bookableresourcegroup(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bookableresourcegroup", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_bookableresourcegroup(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bookableresourcegroup", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_bookingstatus(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bookingstatus", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_bookingstatus(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bookingstatus", "owningbusinessunit", columns);
    }

    public List<Entity> GetBusinessUnit_BulkDeleteFailures(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bulkdeletefailure", "regardingobjectid", columns);
    }

    public List<Entity> GetBusinessUnit_BulkDeleteFailures(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bulkdeletefailure", "regardingobjectid", columns);
    }

    public List<Entity> GetBulkDeleteOperation_BusinessUnit(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bulkdeleteoperation", "owningbusinessunit", columns);
    }

    public List<Entity> GetBulkDeleteOperation_BusinessUnit(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bulkdeleteoperation", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_BulkOperation_activities(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bulkoperation", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_BulkOperation_activities(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bulkoperation", "owningbusinessunit", columns);
    }

    public List<businessunit> Getbusiness_unit_parent_business_unit(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<businessunit>(service, this.Id, nameof (businessunit), "parentbusinessunitid", columns);
    }

    public List<businessunit> Getbusiness_unit_parent_business_unit(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<businessunit>(service, this.Id, nameof (businessunit), "parentbusinessunitid", columns);
    }

    public List<Entity> Getbizmap_businessid_businessunit(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "businessunitmap", "businessid", columns);
    }

    public List<Entity> Getbizmap_businessid_businessunit(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "businessunitmap", "businessid", columns);
    }

    public List<Entity> Getbizmap_subbusinessid_businessunit(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "businessunitmap", "subbusinessid", columns);
    }

    public List<Entity> Getbizmap_subbusinessid_businessunit(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "businessunitmap", "subbusinessid", columns);
    }

    public List<Entity> Getbusiness_unit_calendars(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "calendar", "businessunitid", columns);
    }

    public List<Entity> Getbusiness_unit_calendars(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "calendar", "businessunitid", columns);
    }

    public List<Entity> Getbusinessunit_callbackregistration(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "callbackregistration", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusinessunit_callbackregistration(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "callbackregistration", "owningbusinessunit", columns);
    }

    public List<Entity> GetBusinessUnit_Campaigns(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "campaign", "owningbusinessunit", columns);
    }

    public List<Entity> GetBusinessUnit_Campaigns(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "campaign", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_campaignactivity_activities(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "campaignactivity", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_campaignactivity_activities(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "campaignactivity", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_campaignresponse_activities(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "campaignresponse", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_campaignresponse_activities(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "campaignresponse", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusinessunit_canvasapp(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "canvasapp", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusinessunit_canvasapp(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "canvasapp", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_canvasappextendedmetadata(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "canvasappextendedmetadata", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_canvasappextendedmetadata(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "canvasappextendedmetadata", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusinessunit_canvasappextendedmetadata(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "canvasappextendedmetadata", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusinessunit_canvasappextendedmetadata(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "canvasappextendedmetadata", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_category(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "category", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_category(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "category", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_channelaccessprofile(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "channelaccessprofile", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_channelaccessprofile(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "channelaccessprofile", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_profilerule(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "channelaccessprofilerule", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_profilerule(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "channelaccessprofilerule", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_characteristic(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "characteristic", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_characteristic(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "characteristic", "owningbusinessunit", columns);
    }

    public List<connection> Getbusiness_unit_connections(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<connection>(service, this.Id, "connection", "owningbusinessunit", columns);
    }

    public List<connection> Getbusiness_unit_connections(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<connection>(service, this.Id, "connection", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_connectionreference(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "connectionreference", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_connectionreference(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "connectionreference", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_connector(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "connector", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_connector(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "connector", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_constraint_based_groups(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "constraintbasedgroup", "businessunitid", columns);
    }

    public List<Entity> Getbusiness_unit_constraint_based_groups(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "constraintbasedgroup", "businessunitid", columns);
    }

    public List<contact> Getbusiness_unit_contacts(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<contact>(service, this.Id, "contact", "owningbusinessunit", columns);
    }

    public List<contact> Getbusiness_unit_contacts(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<contact>(service, this.Id, "contact", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_service_contracts(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "contract", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_service_contracts(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "contract", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_convertrule(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "convertrule", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_convertrule(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "convertrule", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_customer_opportunity_roles(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "customeropportunityrole", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_customer_opportunity_roles(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "customeropportunityrole", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_customer_relationship(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "customerrelationship", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_customer_relationship(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "customerrelationship", "owningbusinessunit", columns);
    }

    public List<Entity> GetBusinessUnit_DuplicateRules(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "duplicaterule", "owningbusinessunit", columns);
    }

    public List<Entity> GetBusinessUnit_DuplicateRules(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "duplicaterule", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_dynamicproperyinstance(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "dynamicpropertyinstance", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_dynamicproperyinstance(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "dynamicpropertyinstance", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_email_activities(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "email", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_email_activities(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "email", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_emailserverprofile(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "emailserverprofile", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_emailserverprofile(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "emailserverprofile", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_emailsignatures(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "emailsignature", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_emailsignatures(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "emailsignature", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_entitlement(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "entitlement", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_entitlement(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "entitlement", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_entitlemententityallocationtypemapping(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "entitlemententityallocationtypemapping", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_entitlemententityallocationtypemapping(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "entitlemententityallocationtypemapping", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_environmentvariabledefinition(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "environmentvariabledefinition", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_environmentvariabledefinition(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "environmentvariabledefinition", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_environmentvariablevalue(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "environmentvariablevalue", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_environmentvariablevalue(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "environmentvariablevalue", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_equipment(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "equipment", "businessunitid", columns);
    }

    public List<Entity> Getbusiness_unit_equipment(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "equipment", "businessunitid", columns);
    }

    public List<Entity> Getbusiness_unit_exchangesyncidmapping(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "exchangesyncidmapping", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_exchangesyncidmapping(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "exchangesyncidmapping", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_externalparty(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "externalparty", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_externalparty(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "externalparty", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_fax_activities(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "fax", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_fax_activities(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "fax", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_feedback(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "feedback", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_feedback(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "feedback", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_flowsession(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "flowsession", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_flowsession(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "flowsession", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_goal(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "goal", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_goal(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "goal", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_goalrollupquery(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "goalrollupquery", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_goalrollupquery(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "goalrollupquery", "owningbusinessunit", columns);
    }

    public List<Entity> GetBusinessUnit_Imports(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "import", "owningbusinessunit", columns);
    }

    public List<Entity> GetBusinessUnit_Imports(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "import", "owningbusinessunit", columns);
    }

    public List<Entity> GetBusinessUnit_ImportData(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "importdata", "owningbusinessunit", columns);
    }

    public List<Entity> GetBusinessUnit_ImportData(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "importdata", "owningbusinessunit", columns);
    }

    public List<Entity> GetBusinessUnit_ImportFiles(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "importfile", "owningbusinessunit", columns);
    }

    public List<Entity> GetBusinessUnit_ImportFiles(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "importfile", "owningbusinessunit", columns);
    }

    public List<Entity> GetBusinessUnit_ImportLogs(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "importlog", "owningbusinessunit", columns);
    }

    public List<Entity> GetBusinessUnit_ImportLogs(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "importlog", "owningbusinessunit", columns);
    }

    public List<Entity> GetBusinessUnit_ImportMaps(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "importmap", "owningbusinessunit", columns);
    }

    public List<Entity> GetBusinessUnit_ImportMaps(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "importmap", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_incidents(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "incident", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_incidents(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "incident", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_incident_resolution_activities(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "incidentresolution", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_incident_resolution_activities(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "incidentresolution", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_interactionforemail(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "interactionforemail", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_interactionforemail(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "interactionforemail", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusinessunit_internal_addresses(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "internaladdress", "parentid", columns);
    }

    public List<Entity> Getbusinessunit_internal_addresses(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "internaladdress", "parentid", columns);
    }

    public List<Entity> Getbusiness_unit_invoices(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "invoice", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_invoices(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "invoice", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_knowledgearticle(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "knowledgearticle", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_knowledgearticle(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "knowledgearticle", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_leads(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "lead", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_leads(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "lead", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_letter_activities(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "letter", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_letter_activities(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "letter", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_list(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "list", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_list(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "list", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_listoperation(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "listoperation", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_listoperation(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "listoperation", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_mailbox(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "mailbox", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_mailbox(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "mailbox", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusinessunit_mailboxtrackingcategory(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "mailboxtrackingcategory", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusinessunit_mailboxtrackingcategory(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "mailboxtrackingcategory", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusinessunit_mailboxtrackingfolder(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "mailboxtrackingfolder", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusinessunit_mailboxtrackingfolder(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "mailboxtrackingfolder", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_mailmergetemplates(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "mailmergetemplate", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_mailmergetemplates(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "mailmergetemplate", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_actioncardregarding(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_actioncardregarding", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_actioncardregarding(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_actioncardregarding", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_actioncardrolesetting(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_actioncardrolesetting", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_actioncardrolesetting(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_actioncardrolesetting", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_aibdataset(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_aibdataset", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_aibdataset(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_aibdataset", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_aibdatasetfile(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_aibdatasetfile", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_aibdatasetfile(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_aibdatasetfile", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_aibdatasetrecord(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_aibdatasetrecord", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_aibdatasetrecord(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_aibdatasetrecord", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_aibdatasetscontainer(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_aibdatasetscontainer", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_aibdatasetscontainer(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_aibdatasetscontainer", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_aibfile(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_aibfile", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_aibfile(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_aibfile", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_aibfileattacheddata(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_aibfileattacheddata", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_aibfileattacheddata(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_aibfileattacheddata", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_aiconfiguration(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_aiconfiguration", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_aiconfiguration(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_aiconfiguration", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_aifptrainingdocument(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_aifptrainingdocument", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_aifptrainingdocument(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_aifptrainingdocument", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_aimodel(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_aimodel", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_aimodel(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_aimodel", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_aiodimage(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_aiodimage", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_aiodimage(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_aiodimage", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_aiodlabel(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_aiodlabel", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_aiodlabel(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_aiodlabel", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_aiodtrainingboundingbox(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_aiodtrainingboundingbox", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_aiodtrainingboundingbox(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_aiodtrainingboundingbox", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_aiodtrainingimage(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_aiodtrainingimage", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_aiodtrainingimage(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_aiodtrainingimage", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_aitemplate(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_aitemplate", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_aitemplate(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_aitemplate", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_analysiscomponent(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_analysiscomponent", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_analysiscomponent(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_analysiscomponent", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_analysisjob(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_analysisjob", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_analysisjob(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_analysisjob", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_analysisresult(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_analysisresult", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_analysisresult(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_analysisresult", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_analysisresultdetail(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_analysisresultdetail", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_analysisresultdetail(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_analysisresultdetail", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_analyticsadminsettings(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_analyticsadminsettings", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_analyticsadminsettings(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_analyticsadminsettings", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_analyticsforcs(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_analyticsforcs", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_analyticsforcs(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_analyticsforcs", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_autocapturerule(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_autocapturerule", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_autocapturerule(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_autocapturerule", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_autocapturesettings(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_autocapturesettings", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_autocapturesettings(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_autocapturesettings", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_callablecontext(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_callablecontext", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_callablecontext(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_callablecontext", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_customerasset(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_customerasset", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_customerasset(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_customerasset", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_customerassetcategory(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_customerassetcategory", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_customerassetcategory(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_customerassetcategory", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_dataanalyticsreport(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_dataanalyticsreport", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_dataanalyticsreport(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_dataanalyticsreport", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_dataflow(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_dataflow", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_dataflow(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_dataflow", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_entityrankingrule(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_entityrankingrule", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_entityrankingrule(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_entityrankingrule", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_flowcardtype(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_flowcardtype", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_flowcardtype(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_flowcardtype", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_forecastconfiguration(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_forecastconfiguration", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_forecastconfiguration(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_forecastconfiguration", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_forecastdefinition(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_forecastdefinition", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_forecastdefinition(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_forecastdefinition", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_forecastinstance(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_forecastinstance", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_forecastinstance(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_forecastinstance", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_forecastrecurrence(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_forecastrecurrence", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_forecastrecurrence(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_forecastrecurrence", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_icebreakersconfig(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_icebreakersconfig", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_icebreakersconfig(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_icebreakersconfig", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_iotalert(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iotalert", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_iotalert(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iotalert", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_iotdevice(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iotdevice", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_iotdevice(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iotdevice", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_iotdevicecategory(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iotdevicecategory", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_iotdevicecategory(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iotdevicecategory", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_iotdevicecommand(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iotdevicecommand", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_iotdevicecommand(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iotdevicecommand", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_iotdevicecommanddefinition(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iotdevicecommanddefinition", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_iotdevicecommanddefinition(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iotdevicecommanddefinition", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_iotdevicedatahistory(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iotdevicedatahistory", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_iotdevicedatahistory(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iotdevicedatahistory", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_iotdeviceproperty(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iotdeviceproperty", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_iotdeviceproperty(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iotdeviceproperty", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_iotdeviceregistrationhistory(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iotdeviceregistrationhistory", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_iotdeviceregistrationhistory(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iotdeviceregistrationhistory", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_iotdevicevisualizationconfiguration(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iotdevicevisualizationconfiguration", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_iotdevicevisualizationconfiguration(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iotdevicevisualizationconfiguration", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_iotfieldmapping(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iotfieldmapping", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_iotfieldmapping(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iotfieldmapping", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_iotpropertydefinition(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iotpropertydefinition", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_iotpropertydefinition(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iotpropertydefinition", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_iotprovider(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iotprovider", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_iotprovider(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iotprovider", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_iotproviderinstance(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iotproviderinstance", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_iotproviderinstance(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iotproviderinstance", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_iotsettings(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iotsettings", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_iotsettings(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iotsettings", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_knowledgearticleimage(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_knowledgearticleimage", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_knowledgearticleimage(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_knowledgearticleimage", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_knowledgearticletemplate(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_knowledgearticletemplate", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_knowledgearticletemplate(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_knowledgearticletemplate", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_msteamssetting(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_msteamssetting", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_msteamssetting(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_msteamssetting", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_notesanalysisconfig(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_notesanalysisconfig", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_notesanalysisconfig(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_notesanalysisconfig", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_playbookactivity(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_playbookactivity", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_playbookactivity(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_playbookactivity", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_playbookactivityattribute(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_playbookactivityattribute", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_playbookactivityattribute(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_playbookactivityattribute", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_playbookcategory(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_playbookcategory", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_playbookcategory(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_playbookcategory", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_playbookinstance(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_playbookinstance", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_playbookinstance(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_playbookinstance", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_playbooktemplate(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_playbooktemplate", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_playbooktemplate(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_playbooktemplate", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_postalbum(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_postalbum", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_postalbum(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_postalbum", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_relationshipinsightsunifiedconfig(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_relationshipinsightsunifiedconfig", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_relationshipinsightsunifiedconfig(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_relationshipinsightsunifiedconfig", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_salesinsightssettings(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_salesinsightssettings", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_salesinsightssettings(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_salesinsightssettings", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_serviceconfiguration(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_serviceconfiguration", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_serviceconfiguration(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_serviceconfiguration", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_siconfig(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_siconfig", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_siconfig(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_siconfig", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_slakpi(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_slakpi", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_slakpi(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_slakpi", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_solutionhealthrule(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_solutionhealthrule", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_solutionhealthrule(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_solutionhealthrule", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_solutionhealthruleargument(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_solutionhealthruleargument", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_solutionhealthruleargument(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_solutionhealthruleargument", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_untrackedappointment(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_untrackedappointment", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_untrackedappointment(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_untrackedappointment", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_wallsavedqueryusersettings(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_wallsavedqueryusersettings", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msdyn_wallsavedqueryusersettings(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_wallsavedqueryusersettings", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msfp_emailtemplate(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msfp_emailtemplate", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msfp_emailtemplate(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msfp_emailtemplate", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msfp_localizedemailtemplate(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msfp_localizedemailtemplate", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msfp_localizedemailtemplate(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msfp_localizedemailtemplate", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msfp_project(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msfp_project", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msfp_project(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msfp_project", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msfp_question(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msfp_question", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msfp_question(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msfp_question", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msfp_questionresponse(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msfp_questionresponse", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msfp_questionresponse(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msfp_questionresponse", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msfp_satisfactionmetric(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msfp_satisfactionmetric", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msfp_satisfactionmetric(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msfp_satisfactionmetric", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msfp_survey(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msfp_survey", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msfp_survey(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msfp_survey", "owningbusinessunit", columns);
    }

    public List<Entity> Getmsfp_surveyinvite_businessunit_owningbusinessunit(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msfp_surveyinvite", "owningbusinessunit", columns);
    }

    public List<Entity> Getmsfp_surveyinvite_businessunit_owningbusinessunit(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msfp_surveyinvite", "owningbusinessunit", columns);
    }

    public List<Entity> Getmsfp_surveyresponse_businessunit_owningbusinessunit(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msfp_surveyresponse", "owningbusinessunit", columns);
    }

    public List<Entity> Getmsfp_surveyresponse_businessunit_owningbusinessunit(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msfp_surveyresponse", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msfp_unsubscribedrecipient(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msfp_unsubscribedrecipient", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_msfp_unsubscribedrecipient(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msfp_unsubscribedrecipient", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_opportunities(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "opportunity", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_opportunities(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "opportunity", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_opportunity_close_activities(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "opportunityclose", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_opportunity_close_activities(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "opportunityclose", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_order_close_activities(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "orderclose", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_order_close_activities(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "orderclose", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_pdfsetting(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "pdfsetting", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_pdfsetting(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "pdfsetting", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_personaldocumenttemplates(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "personaldocumenttemplate", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_personaldocumenttemplates(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "personaldocumenttemplate", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_phone_call_activities(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "phonecall", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_phone_call_activities(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "phonecall", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_postfollows(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "postfollow", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_postfollows(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "postfollow", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_PostRegarding(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "postregarding", "regardingobjectowningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_PostRegarding(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "postregarding", "regardingobjectowningbusinessunit", columns);
    }

    public List<Entity> Getbusinessunit_principalobjectattributeaccess(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "principalobjectattributeaccess", "objectid", columns);
    }

    public List<Entity> Getbusinessunit_principalobjectattributeaccess(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "principalobjectattributeaccess", "objectid", columns);
    }

    public List<Entity> GetBusinessUnit_ProcessSessions(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "processsession", "regardingobjectid", columns);
    }

    public List<Entity> GetBusinessUnit_ProcessSessions(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "processsession", "regardingobjectid", columns);
    }

    public List<Entity> GetOwning_businessunit_processsessions(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "processsession", "owningbusinessunit", columns);
    }

    public List<Entity> GetOwning_businessunit_processsessions(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "processsession", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_processstageparameter(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "processstageparameter", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_processstageparameter(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "processstageparameter", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_queues(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "queue", "businessunitid", columns);
    }

    public List<Entity> Getbusiness_unit_queues(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "queue", "businessunitid", columns);
    }

    public List<Entity> Getbusiness_unit_queues2(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "queue", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_queues2(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "queue", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_quotes(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "quote", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_quotes(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "quote", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_quote_close_activities(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "quoteclose", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_quote_close_activities(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "quoteclose", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ratingmodel(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ratingmodel", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ratingmodel(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ratingmodel", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ratingvalue(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ratingvalue", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_ratingvalue(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ratingvalue", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_recurrencerule(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "recurrencerule", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_recurrencerule(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "recurrencerule", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_recurringappointmentmaster_activities(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "recurringappointmentmaster", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_recurringappointmentmaster_activities(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "recurringappointmentmaster", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_reports(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "report", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_reports(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "report", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_resources(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "resource", "businessunitid", columns);
    }

    public List<Entity> Getbusiness_unit_resources(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "resource", "businessunitid", columns);
    }

    public List<Entity> Getbusiness_unit_resource_groups(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "resourcegroup", "businessunitid", columns);
    }

    public List<Entity> Getbusiness_unit_resource_groups(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "resourcegroup", "businessunitid", columns);
    }

    public List<Entity> Getbusiness_unit_resource_specs(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "resourcespec", "businessunitid", columns);
    }

    public List<Entity> Getbusiness_unit_resource_specs(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "resourcespec", "businessunitid", columns);
    }

    public List<Entity> Getbusiness_unit_roles(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "role", "businessunitid", columns);
    }

    public List<Entity> Getbusiness_unit_roles(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "role", "businessunitid", columns);
    }

    public List<Entity> Getbusiness_unit_routingrule(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "routingrule", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_routingrule(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "routingrule", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_orders(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "salesorder", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_orders(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "salesorder", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_salesprocessinstance(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "salesprocessinstance", "businessunitid", columns);
    }

    public List<Entity> Getbusiness_unit_salesprocessinstance(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "salesprocessinstance", "businessunitid", columns);
    }

    public List<Entity> Getbusiness_unit_service_appointments(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "serviceappointment", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_service_appointments(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "serviceappointment", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_sharepointdocument(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sharepointdocument", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_sharepointdocument(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sharepointdocument", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_sharepointdocument2(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sharepointdocument", "businessunitid", columns);
    }

    public List<Entity> Getbusiness_unit_sharepointdocument2(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sharepointdocument", "businessunitid", columns);
    }

    public List<Entity> Getbusiness_unit_sharepointdocumentlocation(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sharepointdocumentlocation", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_sharepointdocumentlocation(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sharepointdocumentlocation", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_sharepointsites(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sharepointsite", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_sharepointsites(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sharepointsite", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_slabase(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sla", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_slabase(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sla", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_slakpiinstance(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "slakpiinstance", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_slakpiinstance(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "slakpiinstance", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_socialactivity(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "socialactivity", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_socialactivity(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "socialactivity", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_socialprofiles(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "socialprofile", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_socialprofiles(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "socialprofile", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_stagesolutionupload(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "stagesolutionupload", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_stagesolutionupload(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "stagesolutionupload", "owningbusinessunit", columns);
    }

    public List<Entity> GetBusinessUnit_SyncError(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "syncerror", "owningbusinessunit", columns);
    }

    public List<Entity> GetBusinessUnit_SyncError(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "syncerror", "owningbusinessunit", columns);
    }

    public List<Entity> GetBusinessUnit_SyncErrors(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "syncerror", "regardingobjectid", columns);
    }

    public List<Entity> GetBusinessUnit_SyncErrors(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "syncerror", "regardingobjectid", columns);
    }

    public List<systemuser> Getbusiness_unit_system_users(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<systemuser>(service, this.Id, "systemuser", "businessunitid", columns);
    }

    public List<systemuser> Getbusiness_unit_system_users(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<systemuser>(service, this.Id, "systemuser", "businessunitid", columns);
    }

    public List<Entity> Getsystemuserbusinessunitentitymap_businessunitid_businessunit(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "systemuserbusinessunitentitymap", "businessunitid", columns);
    }

    public List<Entity> Getsystemuserbusinessunitentitymap_businessunitid_businessunit(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "systemuserbusinessunitentitymap", "businessunitid", columns);
    }

    public List<Entity> Getbusiness_unit_task_activities(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "task", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_task_activities(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "task", "owningbusinessunit", columns);
    }

    public List<team> Getbusiness_unit_teams(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<team>(service, this.Id, "team", "businessunitid", columns);
    }

    public List<team> Getbusiness_unit_teams(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<team>(service, this.Id, "team", "businessunitid", columns);
    }

    public List<Entity> Getbusiness_unit_templates(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "template", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_templates(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "template", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_TraceRegarding(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "traceregarding", "regardingobjectowningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_TraceRegarding(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "traceregarding", "regardingobjectowningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_untrackedemail_activities(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "untrackedemail", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_untrackedemail_activities(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "untrackedemail", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_userapplicationmetadata(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userapplicationmetadata", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_userapplicationmetadata(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userapplicationmetadata", "owningbusinessunit", columns);
    }

    public List<Entity> Getuserentityinstancedata_businessunit(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userentityinstancedata", "owningbusinessunit", columns);
    }

    public List<Entity> Getuserentityinstancedata_businessunit(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userentityinstancedata", "owningbusinessunit", columns);
    }

    public List<Entity> Getuserentityuisettings_businessunit(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userentityuisettings", "owningbusinessunit", columns);
    }

    public List<Entity> Getuserentityuisettings_businessunit(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userentityuisettings", "owningbusinessunit", columns);
    }

    public List<Entity> Getlk_userfiscalcalendar_businessunit(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userfiscalcalendar", "businessunitid", columns);
    }

    public List<Entity> Getlk_userfiscalcalendar_businessunit(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userfiscalcalendar", "businessunitid", columns);
    }

    public List<Entity> Getbusiness_unit_userform(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userform", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_userform(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userform", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_userquery(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userquery", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_userquery(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userquery", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_userqueryvisualizations(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userqueryvisualization", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_userqueryvisualizations(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userqueryvisualization", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_user_settings(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "usersettings", "businessunitid", columns);
    }

    public List<Entity> Getbusiness_unit_user_settings(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "usersettings", "businessunitid", columns);
    }

    public List<Entity> Getbusiness_unit_workflow(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "workflow", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_workflow(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "workflow", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_workflowbinary(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "workflowbinary", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_workflowbinary(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "workflowbinary", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_workflowlogs(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "workflowlog", "owningbusinessunit", columns);
    }

    public List<Entity> Getbusiness_unit_workflowlogs(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "workflowlog", "owningbusinessunit", columns);
    }

    public static class Properties
    {
      public const string address1_addressid = "address1_addressid";
      public const string address1_addresstypecode = "address1_addresstypecode";
      public const string address1_addresstypecodename = "address1_addresstypecodename";
      public const string address1_city = "address1_city";
      public const string address1_country = "address1_country";
      public const string address1_county = "address1_county";
      public const string address1_fax = "address1_fax";
      public const string address1_latitude = "address1_latitude";
      public const string address1_line1 = "address1_line1";
      public const string address1_line2 = "address1_line2";
      public const string address1_line3 = "address1_line3";
      public const string address1_longitude = "address1_longitude";
      public const string address1_name = "address1_name";
      public const string address1_postalcode = "address1_postalcode";
      public const string address1_postofficebox = "address1_postofficebox";
      public const string address1_shippingmethodcode = "address1_shippingmethodcode";
      public const string address1_shippingmethodcodename = "address1_shippingmethodcodename";
      public const string address1_stateorprovince = "address1_stateorprovince";
      public const string address1_telephone1 = "address1_telephone1";
      public const string address1_telephone2 = "address1_telephone2";
      public const string address1_telephone3 = "address1_telephone3";
      public const string address1_upszone = "address1_upszone";
      public const string address1_utcoffset = "address1_utcoffset";
      public const string address2_addressid = "address2_addressid";
      public const string address2_addresstypecode = "address2_addresstypecode";
      public const string address2_addresstypecodename = "address2_addresstypecodename";
      public const string address2_city = "address2_city";
      public const string address2_country = "address2_country";
      public const string address2_county = "address2_county";
      public const string address2_fax = "address2_fax";
      public const string address2_latitude = "address2_latitude";
      public const string address2_line1 = "address2_line1";
      public const string address2_line2 = "address2_line2";
      public const string address2_line3 = "address2_line3";
      public const string address2_longitude = "address2_longitude";
      public const string address2_name = "address2_name";
      public const string address2_postalcode = "address2_postalcode";
      public const string address2_postofficebox = "address2_postofficebox";
      public const string address2_shippingmethodcode = "address2_shippingmethodcode";
      public const string address2_shippingmethodcodename = "address2_shippingmethodcodename";
      public const string address2_stateorprovince = "address2_stateorprovince";
      public const string address2_telephone1 = "address2_telephone1";
      public const string address2_telephone2 = "address2_telephone2";
      public const string address2_telephone3 = "address2_telephone3";
      public const string address2_upszone = "address2_upszone";
      public const string address2_utcoffset = "address2_utcoffset";
      public const string businessunitid = "businessunitid";
      public const string calendarid = "calendarid";
      public const string costcenter = "costcenter";
      public const string createdby = "createdby";
      public const string createdbyname = "createdbyname";
      public const string createdbyyominame = "createdbyyominame";
      public const string createdon = "createdon";
      public const string createdonbehalfby = "createdonbehalfby";
      public const string createdonbehalfbyname = "createdonbehalfbyname";
      public const string createdonbehalfbyyominame = "createdonbehalfbyyominame";
      public const string creditlimit = "creditlimit";
      public const string description = "description";
      public const string disabledreason = "disabledreason";
      public const string divisionname = "divisionname";
      public const string emailaddress = "emailaddress";
      public const string exchangerate = "exchangerate";
      public const string fileasname = "fileasname";
      public const string ftpsiteurl = "ftpsiteurl";
      public const string importsequencenumber = "importsequencenumber";
      public const string inheritancemask = "inheritancemask";
      public const string isdisabled = "isdisabled";
      public const string isdisabledname = "isdisabledname";
      public const string modifiedby = "modifiedby";
      public const string modifiedbyname = "modifiedbyname";
      public const string modifiedbyyominame = "modifiedbyyominame";
      public const string modifiedon = "modifiedon";
      public const string modifiedonbehalfby = "modifiedonbehalfby";
      public const string modifiedonbehalfbyname = "modifiedonbehalfbyname";
      public const string modifiedonbehalfbyyominame = "modifiedonbehalfbyyominame";
      public const string name = "name";
      public const string organizationid = "organizationid";
      public const string organizationidname = "organizationidname";
      public const string overriddencreatedon = "overriddencreatedon";
      public const string parentbusinessunitid = "parentbusinessunitid";
      public const string parentbusinessunitidname = "parentbusinessunitidname";
      public const string picture = "picture";
      public const string stockexchange = "stockexchange";
      public const string tickersymbol = "tickersymbol";
      public const string transactioncurrencyid = "transactioncurrencyid";
      public const string transactioncurrencyidname = "transactioncurrencyidname";
      public const string usergroupid = "usergroupid";
      public const string utcoffset = "utcoffset";
      public const string versionnumber = "versionnumber";
      public const string websiteurl = "websiteurl";
      public const string workflowsuspended = "workflowsuspended";
      public const string workflowsuspendedname = "workflowsuspendedname";
    }
  }
}
