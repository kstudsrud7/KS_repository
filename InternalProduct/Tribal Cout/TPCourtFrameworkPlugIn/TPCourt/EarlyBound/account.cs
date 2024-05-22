// Decompiled with JetBrains decompiler
// Type: TPCourt.EarlyBound.account
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
  [EntityLogicalName("account")]
  [GeneratedCode("XrmToolkit", "4.0")]
  [DataContract(Name = "Entity", Namespace = "http://schemas.microsoft.com/xrm/2011/Contracts")]
  public class account : BaseProxyClass
  {
    public const string LogicalName = "account";
    public const int ObjectTypeCode = 1;
    public const string PrimaryIdAttribute = "accountid";
    public const string PrimaryNameAttribute = "name";
    public const string PrimaryImageAttribute = "entityimage";
    private static Dictionary<string, BaseProxyClass.eTextOptions> _textOptions;
    private static Dictionary<string, BaseProxyClass.eNumberOptions> _numberOptions;
    private static Dictionary<string, string> _errorStrings;

    static account()
    {
      BaseProxyClass.RegisterProxyType(typeof (account), nameof (account));
      account._textOptions = new Dictionary<string, BaseProxyClass.eTextOptions>();
      account._numberOptions = new Dictionary<string, BaseProxyClass.eNumberOptions>();
      account._errorStrings = new Dictionary<string, string>();
      account.TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
      account.NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
    }

    public account()
      : base(new Entity(nameof (account)))
    {
    }

    public account(Entity original)
      : base(original)
    {
    }

    public static string GetLogicalName() => BaseProxyClass.GetLogicalName<account>();

    public static BaseProxyClass.eTextOptions TextOptions { get; set; }

    public static void SetTextOptions(
      string logicalName,
      BaseProxyClass.eTextOptions options,
      string errorString = null)
    {
      if (account._textOptions.ContainsKey(logicalName))
        account._textOptions[logicalName] = options;
      else
        account._textOptions.Add(logicalName, options);
      if (!string.IsNullOrEmpty(errorString))
      {
        if (account._errorStrings.ContainsKey(logicalName))
          account._errorStrings[logicalName] = errorString;
        else
          account._errorStrings.Add(logicalName, errorString);
      }
      else
      {
        if (!account._errorStrings.ContainsKey(logicalName))
          return;
        account._errorStrings.Remove(logicalName);
      }
    }

    protected override BaseProxyClass.eTextOptions GetTextOptions(string logicalName)
    {
      return account._textOptions.ContainsKey(logicalName) ? account._textOptions[logicalName] : account.TextOptions;
    }

    public static BaseProxyClass.eNumberOptions NumberOptions { get; set; }

    public static void SetNumberOptions(
      string logicalName,
      BaseProxyClass.eNumberOptions options,
      string errorString = null)
    {
      if (account._numberOptions.ContainsKey(logicalName))
        account._numberOptions[logicalName] = options;
      else
        account._numberOptions.Add(logicalName, options);
      if (!string.IsNullOrEmpty(errorString))
      {
        if (account._errorStrings.ContainsKey(logicalName))
          account._errorStrings[logicalName] = errorString;
        else
          account._errorStrings.Add(logicalName, errorString);
      }
      else
      {
        if (!account._errorStrings.ContainsKey(logicalName))
          return;
        account._errorStrings.Remove(logicalName);
      }
    }

    protected override BaseProxyClass.eNumberOptions GetNumberOptions(string logicalName)
    {
      return account._numberOptions.ContainsKey(logicalName) ? account._numberOptions[logicalName] : account.NumberOptions;
    }

    protected override string GetErrorString(
      string attributeName,
      BaseProxyClass.eErrorType defaultErrorType)
    {
      return account._errorStrings.ContainsKey(attributeName) ? account._errorStrings[attributeName] : (defaultErrorType == BaseProxyClass.eErrorType.Text ? account.TextError : account.NumberError);
    }

    public static string TextError { get; set; }

    public static string NumberError { get; set; }

    [AttributeLogicalName("accountcategorycode")]
    public eAccount_accountcategorycode? accountcategorycode
    {
      get
      {
        return this.accountcategorycode_OptionSetValue != null ? new eAccount_accountcategorycode?((eAccount_accountcategorycode) this.accountcategorycode_OptionSetValue.Value) : new eAccount_accountcategorycode?();
      }
      set
      {
        if (value.HasValue)
          this.accountcategorycode_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.accountcategorycode_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("accountcategorycode")]
    public OptionSetValue accountcategorycode_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("accountcategorycode");
      set
      {
        this.SetPropertyValue<OptionSetValue>("accountcategorycode", value, nameof (accountcategorycode_OptionSetValue));
      }
    }

    public string accountcategorycode_Text(IOrganizationService service)
    {
      return this.accountcategorycode_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "accountcategorycode");
    }

    public string accountcategorycode_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.accountcategorycode_OptionSetValue.Value);
    }

    [AttributeLogicalName("accountclassificationcode")]
    public eAccount_accountclassificationcode? accountclassificationcode
    {
      get
      {
        return this.accountclassificationcode_OptionSetValue != null ? new eAccount_accountclassificationcode?((eAccount_accountclassificationcode) this.accountclassificationcode_OptionSetValue.Value) : new eAccount_accountclassificationcode?();
      }
      set
      {
        if (value.HasValue)
          this.accountclassificationcode_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.accountclassificationcode_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("accountclassificationcode")]
    public OptionSetValue accountclassificationcode_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("accountclassificationcode");
      set
      {
        this.SetPropertyValue<OptionSetValue>("accountclassificationcode", value, nameof (accountclassificationcode_OptionSetValue));
      }
    }

    public string accountclassificationcode_Text(IOrganizationService service)
    {
      return this.accountclassificationcode_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "accountclassificationcode");
    }

    public string accountclassificationcode_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.accountclassificationcode_OptionSetValue.Value);
    }

    [AttributeLogicalName("accountid")]
    public Guid accountid
    {
      get => this.Id;
      set
      {
        this.Id = value;
        this.SetPropertyValue<Guid>(nameof (accountid), value, nameof (accountid));
      }
    }

    [AttributeLogicalName("accountnumber")]
    public string accountnumber
    {
      get => this.GetPropertyValue<string>(nameof (accountnumber));
      set => this.SetPropertyValue(nameof (accountnumber), value, 20, nameof (accountnumber));
    }

    [AttributeLogicalName("accountratingcode")]
    public eAccount_accountratingcode? accountratingcode
    {
      get
      {
        return this.accountratingcode_OptionSetValue != null ? new eAccount_accountratingcode?((eAccount_accountratingcode) this.accountratingcode_OptionSetValue.Value) : new eAccount_accountratingcode?();
      }
      set
      {
        if (value.HasValue)
          this.accountratingcode_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.accountratingcode_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("accountratingcode")]
    public OptionSetValue accountratingcode_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("accountratingcode");
      set
      {
        this.SetPropertyValue<OptionSetValue>("accountratingcode", value, nameof (accountratingcode_OptionSetValue));
      }
    }

    public string accountratingcode_Text(IOrganizationService service)
    {
      return this.accountratingcode_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "accountratingcode");
    }

    public string accountratingcode_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.accountratingcode_OptionSetValue.Value);
    }

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
    public eAccount_address1_addresstypecode? address1_addresstypecode
    {
      get
      {
        return this.address1_addresstypecode_OptionSetValue != null ? new eAccount_address1_addresstypecode?((eAccount_address1_addresstypecode) this.address1_addresstypecode_OptionSetValue.Value) : new eAccount_address1_addresstypecode?();
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

    [AttributeLogicalName("address1_composite")]
    public string address1_composite => this.GetPropertyValue<string>(nameof (address1_composite));

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

    [AttributeLogicalName("address1_freighttermscode")]
    public eAccount_address1_freighttermscode? address1_freighttermscode
    {
      get
      {
        return this.address1_freighttermscode_OptionSetValue != null ? new eAccount_address1_freighttermscode?((eAccount_address1_freighttermscode) this.address1_freighttermscode_OptionSetValue.Value) : new eAccount_address1_freighttermscode?();
      }
      set
      {
        if (value.HasValue)
          this.address1_freighttermscode_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.address1_freighttermscode_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("address1_freighttermscode")]
    public OptionSetValue address1_freighttermscode_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("address1_freighttermscode");
      set
      {
        this.SetPropertyValue<OptionSetValue>("address1_freighttermscode", value, nameof (address1_freighttermscode_OptionSetValue));
      }
    }

    public string address1_freighttermscode_Text(IOrganizationService service)
    {
      return this.address1_freighttermscode_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "address1_freighttermscode");
    }

    public string address1_freighttermscode_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.address1_freighttermscode_OptionSetValue.Value);
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
      set => this.SetPropertyValue(nameof (address1_name), value, 200, nameof (address1_name));
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

    [AttributeLogicalName("address1_primarycontactname")]
    public string address1_primarycontactname
    {
      get => this.GetPropertyValue<string>(nameof (address1_primarycontactname));
      set
      {
        this.SetPropertyValue(nameof (address1_primarycontactname), value, 100, nameof (address1_primarycontactname));
      }
    }

    [AttributeLogicalName("address1_shippingmethodcode")]
    public eAccount_address1_shippingmethodcode? address1_shippingmethodcode
    {
      get
      {
        return this.address1_shippingmethodcode_OptionSetValue != null ? new eAccount_address1_shippingmethodcode?((eAccount_address1_shippingmethodcode) this.address1_shippingmethodcode_OptionSetValue.Value) : new eAccount_address1_shippingmethodcode?();
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
    public eAccount_address2_addresstypecode? address2_addresstypecode
    {
      get
      {
        return this.address2_addresstypecode_OptionSetValue != null ? new eAccount_address2_addresstypecode?((eAccount_address2_addresstypecode) this.address2_addresstypecode_OptionSetValue.Value) : new eAccount_address2_addresstypecode?();
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

    [AttributeLogicalName("address2_composite")]
    public string address2_composite => this.GetPropertyValue<string>(nameof (address2_composite));

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

    [AttributeLogicalName("address2_freighttermscode")]
    public eAccount_address2_freighttermscode? address2_freighttermscode
    {
      get
      {
        return this.address2_freighttermscode_OptionSetValue != null ? new eAccount_address2_freighttermscode?((eAccount_address2_freighttermscode) this.address2_freighttermscode_OptionSetValue.Value) : new eAccount_address2_freighttermscode?();
      }
      set
      {
        if (value.HasValue)
          this.address2_freighttermscode_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.address2_freighttermscode_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("address2_freighttermscode")]
    public OptionSetValue address2_freighttermscode_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("address2_freighttermscode");
      set
      {
        this.SetPropertyValue<OptionSetValue>("address2_freighttermscode", value, nameof (address2_freighttermscode_OptionSetValue));
      }
    }

    public string address2_freighttermscode_Text(IOrganizationService service)
    {
      return this.address2_freighttermscode_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "address2_freighttermscode");
    }

    public string address2_freighttermscode_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.address2_freighttermscode_OptionSetValue.Value);
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
      set => this.SetPropertyValue(nameof (address2_name), value, 200, nameof (address2_name));
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

    [AttributeLogicalName("address2_primarycontactname")]
    public string address2_primarycontactname
    {
      get => this.GetPropertyValue<string>(nameof (address2_primarycontactname));
      set
      {
        this.SetPropertyValue(nameof (address2_primarycontactname), value, 100, nameof (address2_primarycontactname));
      }
    }

    [AttributeLogicalName("address2_shippingmethodcode")]
    public eAccount_address2_shippingmethodcode? address2_shippingmethodcode
    {
      get
      {
        return this.address2_shippingmethodcode_OptionSetValue != null ? new eAccount_address2_shippingmethodcode?((eAccount_address2_shippingmethodcode) this.address2_shippingmethodcode_OptionSetValue.Value) : new eAccount_address2_shippingmethodcode?();
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

    [AttributeLogicalName("aging30")]
    public Decimal? aging30
    {
      get => this.aging30Money != null ? new Decimal?(this.aging30Money.Value) : new Decimal?();
    }

    [AttributeLogicalName("aging30")]
    public Money aging30Money => this.GetPropertyValue<Money>("aging30");

    [AttributeLogicalName("aging30_base")]
    public Decimal? aging30_base
    {
      get
      {
        return this.aging30_baseMoney != null ? new Decimal?(this.aging30_baseMoney.Value) : new Decimal?();
      }
    }

    [AttributeLogicalName("aging30_base")]
    public Money aging30_baseMoney => this.GetPropertyValue<Money>("aging30_base");

    [AttributeLogicalName("aging60")]
    public Decimal? aging60
    {
      get => this.aging60Money != null ? new Decimal?(this.aging60Money.Value) : new Decimal?();
    }

    [AttributeLogicalName("aging60")]
    public Money aging60Money => this.GetPropertyValue<Money>("aging60");

    [AttributeLogicalName("aging60_base")]
    public Decimal? aging60_base
    {
      get
      {
        return this.aging60_baseMoney != null ? new Decimal?(this.aging60_baseMoney.Value) : new Decimal?();
      }
    }

    [AttributeLogicalName("aging60_base")]
    public Money aging60_baseMoney => this.GetPropertyValue<Money>("aging60_base");

    [AttributeLogicalName("aging90")]
    public Decimal? aging90
    {
      get => this.aging90Money != null ? new Decimal?(this.aging90Money.Value) : new Decimal?();
    }

    [AttributeLogicalName("aging90")]
    public Money aging90Money => this.GetPropertyValue<Money>("aging90");

    [AttributeLogicalName("aging90_base")]
    public Decimal? aging90_base
    {
      get
      {
        return this.aging90_baseMoney != null ? new Decimal?(this.aging90_baseMoney.Value) : new Decimal?();
      }
    }

    [AttributeLogicalName("aging90_base")]
    public Money aging90_baseMoney => this.GetPropertyValue<Money>("aging90_base");

    [AttributeLogicalName("businesstypecode")]
    public eAccount_businesstypecode? businesstypecode
    {
      get
      {
        return this.businesstypecode_OptionSetValue != null ? new eAccount_businesstypecode?((eAccount_businesstypecode) this.businesstypecode_OptionSetValue.Value) : new eAccount_businesstypecode?();
      }
      set
      {
        if (value.HasValue)
          this.businesstypecode_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.businesstypecode_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("businesstypecode")]
    public OptionSetValue businesstypecode_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("businesstypecode");
      set
      {
        this.SetPropertyValue<OptionSetValue>("businesstypecode", value, nameof (businesstypecode_OptionSetValue));
      }
    }

    public string businesstypecode_Text(IOrganizationService service)
    {
      return this.businesstypecode_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "businesstypecode");
    }

    public string businesstypecode_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.businesstypecode_OptionSetValue.Value);
    }

    [AttributeLogicalName("createdby")]
    public EntityReference createdby => this.GetPropertyValue<EntityReference>(nameof (createdby));

    [AttributeLogicalName("createdbyexternalparty")]
    public EntityReference createdbyexternalparty
    {
      get => this.GetPropertyValue<EntityReference>(nameof (createdbyexternalparty));
    }

    [AttributeLogicalName("createdbyexternalpartyname")]
    public string createdbyexternalpartyname
    {
      get => this.GetPropertyValue<string>(nameof (createdbyexternalpartyname));
    }

    [AttributeLogicalName("createdbyexternalpartyyominame")]
    public string createdbyexternalpartyyominame
    {
      get => this.GetPropertyValue<string>(nameof (createdbyexternalpartyyominame));
    }

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
    public Decimal? creditlimit
    {
      get
      {
        return this.creditlimitMoney != null ? new Decimal?(this.creditlimitMoney.Value) : new Decimal?();
      }
      set
      {
        if (value.HasValue)
          this.creditlimitMoney = new Money(value.Value);
        else
          this.creditlimitMoney = (Money) null;
      }
    }

    [AttributeLogicalName("creditlimit")]
    public Money creditlimitMoney
    {
      get => this.GetPropertyValue<Money>("creditlimit");
      set
      {
        this.SetPropertyValue("creditlimit", value, 0M, 100000000000000M, nameof (creditlimitMoney));
      }
    }

    [AttributeLogicalName("creditlimit_base")]
    public Decimal? creditlimit_base
    {
      get
      {
        return this.creditlimit_baseMoney != null ? new Decimal?(this.creditlimit_baseMoney.Value) : new Decimal?();
      }
    }

    [AttributeLogicalName("creditlimit_base")]
    public Money creditlimit_baseMoney => this.GetPropertyValue<Money>("creditlimit_base");

    [AttributeLogicalName("creditonhold")]
    public bool? creditonhold
    {
      get => this.GetPropertyValue<bool?>(nameof (creditonhold));
      set => this.SetPropertyValue<bool?>(nameof (creditonhold), value, nameof (creditonhold));
    }

    [AttributeLogicalName("customersizecode")]
    public eAccount_customersizecode? customersizecode
    {
      get
      {
        return this.customersizecode_OptionSetValue != null ? new eAccount_customersizecode?((eAccount_customersizecode) this.customersizecode_OptionSetValue.Value) : new eAccount_customersizecode?();
      }
      set
      {
        if (value.HasValue)
          this.customersizecode_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.customersizecode_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("customersizecode")]
    public OptionSetValue customersizecode_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("customersizecode");
      set
      {
        this.SetPropertyValue<OptionSetValue>("customersizecode", value, nameof (customersizecode_OptionSetValue));
      }
    }

    public string customersizecode_Text(IOrganizationService service)
    {
      return this.customersizecode_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "customersizecode");
    }

    public string customersizecode_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.customersizecode_OptionSetValue.Value);
    }

    [AttributeLogicalName("customertypecode")]
    public eAccount_customertypecode? customertypecode
    {
      get
      {
        return this.customertypecode_OptionSetValue != null ? new eAccount_customertypecode?((eAccount_customertypecode) this.customertypecode_OptionSetValue.Value) : new eAccount_customertypecode?();
      }
      set
      {
        if (value.HasValue)
          this.customertypecode_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.customertypecode_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("customertypecode")]
    public OptionSetValue customertypecode_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("customertypecode");
      set
      {
        this.SetPropertyValue<OptionSetValue>("customertypecode", value, nameof (customertypecode_OptionSetValue));
      }
    }

    public string customertypecode_Text(IOrganizationService service)
    {
      return this.customertypecode_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "customertypecode");
    }

    public string customertypecode_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.customertypecode_OptionSetValue.Value);
    }

    [AttributeLogicalName("defaultpricelevelid")]
    public EntityReference defaultpricelevelid
    {
      get => this.GetPropertyValue<EntityReference>(nameof (defaultpricelevelid));
      set
      {
        this.SetPropertyValue<EntityReference>(nameof (defaultpricelevelid), value, nameof (defaultpricelevelid));
      }
    }

    [AttributeLogicalName("defaultpricelevelidname")]
    public string defaultpricelevelidname
    {
      get => this.GetPropertyValue<string>(nameof (defaultpricelevelidname));
    }

    [AttributeLogicalName("description")]
    public string description
    {
      get => this.GetPropertyValue<string>(nameof (description));
      set => this.SetPropertyValue(nameof (description), value, 2000, nameof (description));
    }

    [AttributeLogicalName("donotbulkemail")]
    public bool? donotbulkemail
    {
      get => this.GetPropertyValue<bool?>(nameof (donotbulkemail));
      set => this.SetPropertyValue<bool?>(nameof (donotbulkemail), value, nameof (donotbulkemail));
    }

    [AttributeLogicalName("donotbulkpostalmail")]
    public bool? donotbulkpostalmail
    {
      get => this.GetPropertyValue<bool?>(nameof (donotbulkpostalmail));
      set
      {
        this.SetPropertyValue<bool?>(nameof (donotbulkpostalmail), value, nameof (donotbulkpostalmail));
      }
    }

    [AttributeLogicalName("donotemail")]
    public bool? donotemail
    {
      get => this.GetPropertyValue<bool?>(nameof (donotemail));
      set => this.SetPropertyValue<bool?>(nameof (donotemail), value, nameof (donotemail));
    }

    [AttributeLogicalName("donotfax")]
    public bool? donotfax
    {
      get => this.GetPropertyValue<bool?>(nameof (donotfax));
      set => this.SetPropertyValue<bool?>(nameof (donotfax), value, nameof (donotfax));
    }

    [AttributeLogicalName("donotphone")]
    public bool? donotphone
    {
      get => this.GetPropertyValue<bool?>(nameof (donotphone));
      set => this.SetPropertyValue<bool?>(nameof (donotphone), value, nameof (donotphone));
    }

    [AttributeLogicalName("donotpostalmail")]
    public bool? donotpostalmail
    {
      get => this.GetPropertyValue<bool?>(nameof (donotpostalmail));
      set
      {
        this.SetPropertyValue<bool?>(nameof (donotpostalmail), value, nameof (donotpostalmail));
      }
    }

    [AttributeLogicalName("donotsendmm")]
    public bool? donotsendmm
    {
      get => this.GetPropertyValue<bool?>(nameof (donotsendmm));
      set => this.SetPropertyValue<bool?>(nameof (donotsendmm), value, nameof (donotsendmm));
    }

    [AttributeLogicalName("emailaddress1")]
    public string emailaddress1
    {
      get => this.GetPropertyValue<string>(nameof (emailaddress1));
      set => this.SetPropertyValue(nameof (emailaddress1), value, 100, nameof (emailaddress1));
    }

    [AttributeLogicalName("emailaddress2")]
    public string emailaddress2
    {
      get => this.GetPropertyValue<string>(nameof (emailaddress2));
      set => this.SetPropertyValue(nameof (emailaddress2), value, 100, nameof (emailaddress2));
    }

    [AttributeLogicalName("emailaddress3")]
    public string emailaddress3
    {
      get => this.GetPropertyValue<string>(nameof (emailaddress3));
      set => this.SetPropertyValue(nameof (emailaddress3), value, 100, nameof (emailaddress3));
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

    [AttributeLogicalName("exchangerate")]
    public Decimal? exchangerate => this.GetPropertyValue<Decimal?>(nameof (exchangerate));

    [AttributeLogicalName("fax")]
    public string fax
    {
      get => this.GetPropertyValue<string>(nameof (fax));
      set => this.SetPropertyValue(nameof (fax), value, 50, nameof (fax));
    }

    [AttributeLogicalName("followemail")]
    public bool? followemail
    {
      get => this.GetPropertyValue<bool?>(nameof (followemail));
      set => this.SetPropertyValue<bool?>(nameof (followemail), value, nameof (followemail));
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

    [AttributeLogicalName("industrycode")]
    public eAccount_industrycode? industrycode
    {
      get
      {
        return this.industrycode_OptionSetValue != null ? new eAccount_industrycode?((eAccount_industrycode) this.industrycode_OptionSetValue.Value) : new eAccount_industrycode?();
      }
      set
      {
        if (value.HasValue)
          this.industrycode_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.industrycode_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("industrycode")]
    public OptionSetValue industrycode_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("industrycode");
      set
      {
        this.SetPropertyValue<OptionSetValue>("industrycode", value, nameof (industrycode_OptionSetValue));
      }
    }

    public string industrycode_Text(IOrganizationService service)
    {
      return this.industrycode_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "industrycode");
    }

    public string industrycode_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.industrycode_OptionSetValue.Value);
    }

    [AttributeLogicalName("isprivate")]
    public bool? isprivate => this.GetPropertyValue<bool?>(nameof (isprivate));

    [AttributeLogicalName("lastonholdtime")]
    public DateTime? lastonholdtime
    {
      get => this.GetPropertyValue<DateTime?>(nameof (lastonholdtime));
      set
      {
        this.SetPropertyValue<DateTime?>(nameof (lastonholdtime), value, nameof (lastonholdtime));
      }
    }

    [AttributeLogicalName("lastusedincampaign")]
    public DateTime? lastusedincampaign
    {
      get => this.GetPropertyValue<DateTime?>(nameof (lastusedincampaign));
      set
      {
        this.SetPropertyValue<DateTime?>(nameof (lastusedincampaign), value, nameof (lastusedincampaign));
      }
    }

    [AttributeLogicalName("marketcap")]
    public Decimal? marketcap
    {
      get => this.marketcapMoney != null ? new Decimal?(this.marketcapMoney.Value) : new Decimal?();
      set
      {
        if (value.HasValue)
          this.marketcapMoney = new Money(value.Value);
        else
          this.marketcapMoney = (Money) null;
      }
    }

    [AttributeLogicalName("marketcap")]
    public Money marketcapMoney
    {
      get => this.GetPropertyValue<Money>("marketcap");
      set
      {
        this.SetPropertyValue("marketcap", value, 0M, 100000000000000M, nameof (marketcapMoney));
      }
    }

    [AttributeLogicalName("marketcap_base")]
    public Decimal? marketcap_base
    {
      get
      {
        return this.marketcap_baseMoney != null ? new Decimal?(this.marketcap_baseMoney.Value) : new Decimal?();
      }
    }

    [AttributeLogicalName("marketcap_base")]
    public Money marketcap_baseMoney => this.GetPropertyValue<Money>("marketcap_base");

    [AttributeLogicalName("marketingonly")]
    public bool? marketingonly
    {
      get => this.GetPropertyValue<bool?>(nameof (marketingonly));
      set => this.SetPropertyValue<bool?>(nameof (marketingonly), value, nameof (marketingonly));
    }

    [AttributeLogicalName("masteraccountidname")]
    public string masteraccountidname
    {
      get => this.GetPropertyValue<string>(nameof (masteraccountidname));
    }

    [AttributeLogicalName("masteraccountidyominame")]
    public string masteraccountidyominame
    {
      get => this.GetPropertyValue<string>(nameof (masteraccountidyominame));
    }

    [AttributeLogicalName("masterid")]
    public EntityReference masterid => this.GetPropertyValue<EntityReference>(nameof (masterid));

    [AttributeLogicalName("merged")]
    public bool? merged => this.GetPropertyValue<bool?>(nameof (merged));

    [AttributeLogicalName("modifiedby")]
    public EntityReference modifiedby
    {
      get => this.GetPropertyValue<EntityReference>(nameof (modifiedby));
    }

    [AttributeLogicalName("modifiedbyexternalparty")]
    public EntityReference modifiedbyexternalparty
    {
      get => this.GetPropertyValue<EntityReference>(nameof (modifiedbyexternalparty));
    }

    [AttributeLogicalName("modifiedbyexternalpartyname")]
    public string modifiedbyexternalpartyname
    {
      get => this.GetPropertyValue<string>(nameof (modifiedbyexternalpartyname));
    }

    [AttributeLogicalName("modifiedbyexternalpartyyominame")]
    public string modifiedbyexternalpartyyominame
    {
      get => this.GetPropertyValue<string>(nameof (modifiedbyexternalpartyyominame));
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

    [AttributeLogicalName("numberofemployees")]
    public int? numberofemployees
    {
      get => this.GetPropertyValue<int?>(nameof (numberofemployees));
      set
      {
        this.SetPropertyValue(nameof (numberofemployees), value, 0, 1000000000, nameof (numberofemployees));
      }
    }

    [AttributeLogicalName("onholdtime")]
    public int? onholdtime => this.GetPropertyValue<int?>(nameof (onholdtime));

    [AttributeLogicalName("opendeals")]
    public int? opendeals => this.GetPropertyValue<int?>(nameof (opendeals));

    [AttributeLogicalName("opendeals_date")]
    public DateTime? opendeals_date => this.GetPropertyValue<DateTime?>(nameof (opendeals_date));

    [AttributeLogicalName("opendeals_state")]
    public int? opendeals_state => this.GetPropertyValue<int?>(nameof (opendeals_state));

    [AttributeLogicalName("openrevenue")]
    public Decimal? openrevenue
    {
      get
      {
        return this.openrevenueMoney != null ? new Decimal?(this.openrevenueMoney.Value) : new Decimal?();
      }
    }

    [AttributeLogicalName("openrevenue")]
    public Money openrevenueMoney => this.GetPropertyValue<Money>("openrevenue");

    [AttributeLogicalName("openrevenue_base")]
    public Decimal? openrevenue_base
    {
      get
      {
        return this.openrevenue_baseMoney != null ? new Decimal?(this.openrevenue_baseMoney.Value) : new Decimal?();
      }
    }

    [AttributeLogicalName("openrevenue_base")]
    public Money openrevenue_baseMoney => this.GetPropertyValue<Money>("openrevenue_base");

    [AttributeLogicalName("openrevenue_date")]
    public DateTime? openrevenue_date
    {
      get => this.GetPropertyValue<DateTime?>(nameof (openrevenue_date));
    }

    [AttributeLogicalName("openrevenue_state")]
    public int? openrevenue_state => this.GetPropertyValue<int?>(nameof (openrevenue_state));

    [AttributeLogicalName("originatingleadid")]
    public EntityReference originatingleadid
    {
      get => this.GetPropertyValue<EntityReference>(nameof (originatingleadid));
      set
      {
        this.SetPropertyValue<EntityReference>(nameof (originatingleadid), value, nameof (originatingleadid));
      }
    }

    [AttributeLogicalName("originatingleadidname")]
    public string originatingleadidname
    {
      get => this.GetPropertyValue<string>(nameof (originatingleadidname));
    }

    [AttributeLogicalName("originatingleadidyominame")]
    public string originatingleadidyominame
    {
      get => this.GetPropertyValue<string>(nameof (originatingleadidyominame));
    }

    [AttributeLogicalName("overriddencreatedon")]
    public DateTime? overriddencreatedon
    {
      get => this.GetPropertyValue<DateTime?>(nameof (overriddencreatedon));
      set
      {
        this.SetPropertyValue<DateTime?>(nameof (overriddencreatedon), value, nameof (overriddencreatedon));
      }
    }

    [AttributeLogicalName("ownerid")]
    public EntityReference ownerid
    {
      get => this.GetPropertyValue<EntityReference>(nameof (ownerid));
      set => this.SetPropertyValue<EntityReference>(nameof (ownerid), value, nameof (ownerid));
    }

    [AttributeLogicalName("owneridname")]
    public string owneridname => this.GetPropertyValue<string>(nameof (owneridname));

    [AttributeLogicalName("owneridtype")]
    public string owneridtype
    {
      get => this.GetPropertyValue<string>(nameof (owneridtype));
      set => this.SetPropertyValue<string>(nameof (owneridtype), value, nameof (owneridtype));
    }

    [AttributeLogicalName("owneridyominame")]
    public string owneridyominame => this.GetPropertyValue<string>(nameof (owneridyominame));

    [AttributeLogicalName("ownershipcode")]
    public eAccount_ownershipcode? ownershipcode
    {
      get
      {
        return this.ownershipcode_OptionSetValue != null ? new eAccount_ownershipcode?((eAccount_ownershipcode) this.ownershipcode_OptionSetValue.Value) : new eAccount_ownershipcode?();
      }
      set
      {
        if (value.HasValue)
          this.ownershipcode_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.ownershipcode_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("ownershipcode")]
    public OptionSetValue ownershipcode_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("ownershipcode");
      set
      {
        this.SetPropertyValue<OptionSetValue>("ownershipcode", value, nameof (ownershipcode_OptionSetValue));
      }
    }

    public string ownershipcode_Text(IOrganizationService service)
    {
      return this.ownershipcode_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "ownershipcode");
    }

    public string ownershipcode_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.ownershipcode_OptionSetValue.Value);
    }

    [AttributeLogicalName("owningbusinessunit")]
    public EntityReference owningbusinessunit
    {
      get => this.GetPropertyValue<EntityReference>(nameof (owningbusinessunit));
    }

    [AttributeLogicalName("owningteam")]
    public EntityReference owningteam
    {
      get => this.GetPropertyValue<EntityReference>(nameof (owningteam));
    }

    [AttributeLogicalName("owninguser")]
    public EntityReference owninguser
    {
      get => this.GetPropertyValue<EntityReference>(nameof (owninguser));
    }

    [AttributeLogicalName("parentaccountid")]
    public EntityReference parentaccountid
    {
      get => this.GetPropertyValue<EntityReference>(nameof (parentaccountid));
      set
      {
        this.SetPropertyValue<EntityReference>(nameof (parentaccountid), value, nameof (parentaccountid));
      }
    }

    [AttributeLogicalName("parentaccountidname")]
    public string parentaccountidname
    {
      get => this.GetPropertyValue<string>(nameof (parentaccountidname));
    }

    [AttributeLogicalName("parentaccountidyominame")]
    public string parentaccountidyominame
    {
      get => this.GetPropertyValue<string>(nameof (parentaccountidyominame));
    }

    [AttributeLogicalName("participatesinworkflow")]
    public bool? participatesinworkflow
    {
      get => this.GetPropertyValue<bool?>(nameof (participatesinworkflow));
      set
      {
        this.SetPropertyValue<bool?>(nameof (participatesinworkflow), value, nameof (participatesinworkflow));
      }
    }

    [AttributeLogicalName("paymenttermscode")]
    public eAccount_paymenttermscode? paymenttermscode
    {
      get
      {
        return this.paymenttermscode_OptionSetValue != null ? new eAccount_paymenttermscode?((eAccount_paymenttermscode) this.paymenttermscode_OptionSetValue.Value) : new eAccount_paymenttermscode?();
      }
      set
      {
        if (value.HasValue)
          this.paymenttermscode_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.paymenttermscode_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("paymenttermscode")]
    public OptionSetValue paymenttermscode_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("paymenttermscode");
      set
      {
        this.SetPropertyValue<OptionSetValue>("paymenttermscode", value, nameof (paymenttermscode_OptionSetValue));
      }
    }

    public string paymenttermscode_Text(IOrganizationService service)
    {
      return this.paymenttermscode_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "paymenttermscode");
    }

    public string paymenttermscode_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.paymenttermscode_OptionSetValue.Value);
    }

    [AttributeLogicalName("preferredappointmentdaycode")]
    public eAccount_preferredappointmentdaycode? preferredappointmentdaycode
    {
      get
      {
        return this.preferredappointmentdaycode_OptionSetValue != null ? new eAccount_preferredappointmentdaycode?((eAccount_preferredappointmentdaycode) this.preferredappointmentdaycode_OptionSetValue.Value) : new eAccount_preferredappointmentdaycode?();
      }
      set
      {
        if (value.HasValue)
          this.preferredappointmentdaycode_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.preferredappointmentdaycode_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("preferredappointmentdaycode")]
    public OptionSetValue preferredappointmentdaycode_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("preferredappointmentdaycode");
      set
      {
        this.SetPropertyValue<OptionSetValue>("preferredappointmentdaycode", value, nameof (preferredappointmentdaycode_OptionSetValue));
      }
    }

    public string preferredappointmentdaycode_Text(IOrganizationService service)
    {
      return this.preferredappointmentdaycode_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "preferredappointmentdaycode");
    }

    public string preferredappointmentdaycode_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.preferredappointmentdaycode_OptionSetValue.Value);
    }

    [AttributeLogicalName("preferredappointmenttimecode")]
    public eAccount_preferredappointmenttimecode? preferredappointmenttimecode
    {
      get
      {
        return this.preferredappointmenttimecode_OptionSetValue != null ? new eAccount_preferredappointmenttimecode?((eAccount_preferredappointmenttimecode) this.preferredappointmenttimecode_OptionSetValue.Value) : new eAccount_preferredappointmenttimecode?();
      }
      set
      {
        if (value.HasValue)
          this.preferredappointmenttimecode_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.preferredappointmenttimecode_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("preferredappointmenttimecode")]
    public OptionSetValue preferredappointmenttimecode_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("preferredappointmenttimecode");
      set
      {
        this.SetPropertyValue<OptionSetValue>("preferredappointmenttimecode", value, nameof (preferredappointmenttimecode_OptionSetValue));
      }
    }

    public string preferredappointmenttimecode_Text(IOrganizationService service)
    {
      return this.preferredappointmenttimecode_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "preferredappointmenttimecode");
    }

    public string preferredappointmenttimecode_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.preferredappointmenttimecode_OptionSetValue.Value);
    }

    [AttributeLogicalName("preferredcontactmethodcode")]
    public eAccount_preferredcontactmethodcode? preferredcontactmethodcode
    {
      get
      {
        return this.preferredcontactmethodcode_OptionSetValue != null ? new eAccount_preferredcontactmethodcode?((eAccount_preferredcontactmethodcode) this.preferredcontactmethodcode_OptionSetValue.Value) : new eAccount_preferredcontactmethodcode?();
      }
      set
      {
        if (value.HasValue)
          this.preferredcontactmethodcode_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.preferredcontactmethodcode_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("preferredcontactmethodcode")]
    public OptionSetValue preferredcontactmethodcode_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("preferredcontactmethodcode");
      set
      {
        this.SetPropertyValue<OptionSetValue>("preferredcontactmethodcode", value, nameof (preferredcontactmethodcode_OptionSetValue));
      }
    }

    public string preferredcontactmethodcode_Text(IOrganizationService service)
    {
      return this.preferredcontactmethodcode_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "preferredcontactmethodcode");
    }

    public string preferredcontactmethodcode_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.preferredcontactmethodcode_OptionSetValue.Value);
    }

    [AttributeLogicalName("preferredequipmentid")]
    public EntityReference preferredequipmentid
    {
      get => this.GetPropertyValue<EntityReference>(nameof (preferredequipmentid));
      set
      {
        this.SetPropertyValue<EntityReference>(nameof (preferredequipmentid), value, nameof (preferredequipmentid));
      }
    }

    [AttributeLogicalName("preferredequipmentidname")]
    public string preferredequipmentidname
    {
      get => this.GetPropertyValue<string>(nameof (preferredequipmentidname));
    }

    [AttributeLogicalName("preferredserviceid")]
    public EntityReference preferredserviceid
    {
      get => this.GetPropertyValue<EntityReference>(nameof (preferredserviceid));
      set
      {
        this.SetPropertyValue<EntityReference>(nameof (preferredserviceid), value, nameof (preferredserviceid));
      }
    }

    [AttributeLogicalName("preferredserviceidname")]
    public string preferredserviceidname
    {
      get => this.GetPropertyValue<string>(nameof (preferredserviceidname));
    }

    [AttributeLogicalName("preferredsystemuserid")]
    public EntityReference preferredsystemuserid
    {
      get => this.GetPropertyValue<EntityReference>(nameof (preferredsystemuserid));
      set
      {
        this.SetPropertyValue<EntityReference>(nameof (preferredsystemuserid), value, nameof (preferredsystemuserid));
      }
    }

    [AttributeLogicalName("preferredsystemuseridname")]
    public string preferredsystemuseridname
    {
      get => this.GetPropertyValue<string>(nameof (preferredsystemuseridname));
    }

    [AttributeLogicalName("preferredsystemuseridyominame")]
    public string preferredsystemuseridyominame
    {
      get => this.GetPropertyValue<string>(nameof (preferredsystemuseridyominame));
    }

    [AttributeLogicalName("primarycontactid")]
    public EntityReference primarycontactid
    {
      get => this.GetPropertyValue<EntityReference>(nameof (primarycontactid));
      set
      {
        this.SetPropertyValue<EntityReference>(nameof (primarycontactid), value, nameof (primarycontactid));
      }
    }

    [AttributeLogicalName("primarycontactidname")]
    public string primarycontactidname
    {
      get => this.GetPropertyValue<string>(nameof (primarycontactidname));
    }

    [AttributeLogicalName("primarycontactidyominame")]
    public string primarycontactidyominame
    {
      get => this.GetPropertyValue<string>(nameof (primarycontactidyominame));
    }

    [AttributeLogicalName("primarysatoriid")]
    public string primarysatoriid
    {
      get => this.GetPropertyValue<string>(nameof (primarysatoriid));
      set => this.SetPropertyValue(nameof (primarysatoriid), value, 200, nameof (primarysatoriid));
    }

    [AttributeLogicalName("primarytwitterid")]
    public string primarytwitterid
    {
      get => this.GetPropertyValue<string>(nameof (primarytwitterid));
      set => this.SetPropertyValue(nameof (primarytwitterid), value, 20, nameof (primarytwitterid));
    }

    [AttributeLogicalName("processid")]
    public Guid processid
    {
      get => this.GetPropertyValue<Guid>(nameof (processid));
      set => this.SetPropertyValue<Guid>(nameof (processid), value, nameof (processid));
    }

    [AttributeLogicalName("revenue")]
    public Decimal? revenue
    {
      get => this.revenueMoney != null ? new Decimal?(this.revenueMoney.Value) : new Decimal?();
      set
      {
        if (value.HasValue)
          this.revenueMoney = new Money(value.Value);
        else
          this.revenueMoney = (Money) null;
      }
    }

    [AttributeLogicalName("revenue")]
    public Money revenueMoney
    {
      get => this.GetPropertyValue<Money>("revenue");
      set => this.SetPropertyValue("revenue", value, 0M, 100000000000000M, nameof (revenueMoney));
    }

    [AttributeLogicalName("revenue_base")]
    public Decimal? revenue_base
    {
      get
      {
        return this.revenue_baseMoney != null ? new Decimal?(this.revenue_baseMoney.Value) : new Decimal?();
      }
    }

    [AttributeLogicalName("revenue_base")]
    public Money revenue_baseMoney => this.GetPropertyValue<Money>("revenue_base");

    [AttributeLogicalName("sharesoutstanding")]
    public int? sharesoutstanding
    {
      get => this.GetPropertyValue<int?>(nameof (sharesoutstanding));
      set
      {
        this.SetPropertyValue(nameof (sharesoutstanding), value, 0, 1000000000, nameof (sharesoutstanding));
      }
    }

    [AttributeLogicalName("shippingmethodcode")]
    public eAccount_shippingmethodcode? shippingmethodcode
    {
      get
      {
        return this.shippingmethodcode_OptionSetValue != null ? new eAccount_shippingmethodcode?((eAccount_shippingmethodcode) this.shippingmethodcode_OptionSetValue.Value) : new eAccount_shippingmethodcode?();
      }
      set
      {
        if (value.HasValue)
          this.shippingmethodcode_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.shippingmethodcode_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("shippingmethodcode")]
    public OptionSetValue shippingmethodcode_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("shippingmethodcode");
      set
      {
        this.SetPropertyValue<OptionSetValue>("shippingmethodcode", value, nameof (shippingmethodcode_OptionSetValue));
      }
    }

    public string shippingmethodcode_Text(IOrganizationService service)
    {
      return this.shippingmethodcode_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "shippingmethodcode");
    }

    public string shippingmethodcode_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.shippingmethodcode_OptionSetValue.Value);
    }

    [AttributeLogicalName("sic")]
    public string sic
    {
      get => this.GetPropertyValue<string>(nameof (sic));
      set => this.SetPropertyValue(nameof (sic), value, 20, nameof (sic));
    }

    [AttributeLogicalName("slaid")]
    public EntityReference slaid
    {
      get => this.GetPropertyValue<EntityReference>(nameof (slaid));
      set => this.SetPropertyValue<EntityReference>(nameof (slaid), value, nameof (slaid));
    }

    [AttributeLogicalName("slainvokedid")]
    public EntityReference slainvokedid
    {
      get => this.GetPropertyValue<EntityReference>(nameof (slainvokedid));
    }

    [AttributeLogicalName("slainvokedidname")]
    public string slainvokedidname => this.GetPropertyValue<string>(nameof (slainvokedidname));

    [AttributeLogicalName("slaname")]
    public string slaname => this.GetPropertyValue<string>(nameof (slaname));

    [AttributeLogicalName("stageid")]
    public Guid stageid
    {
      get => this.GetPropertyValue<Guid>(nameof (stageid));
      set => this.SetPropertyValue<Guid>(nameof (stageid), value, nameof (stageid));
    }

    [AttributeLogicalName("statecode")]
    public eAccount_statecode? statecode
    {
      get
      {
        return this.statecode_OptionSetValue != null ? new eAccount_statecode?((eAccount_statecode) this.statecode_OptionSetValue.Value) : new eAccount_statecode?();
      }
      set
      {
        if (value.HasValue)
          this.statecode_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.statecode_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("statecode")]
    public OptionSetValue statecode_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("statecode");
      set
      {
        this.SetPropertyValue<OptionSetValue>("statecode", value, nameof (statecode_OptionSetValue));
      }
    }

    public string statecode_Text(IOrganizationService service)
    {
      return this.statecode_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "statecode");
    }

    public string statecode_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.statecode_OptionSetValue.Value);
    }

    [AttributeLogicalName("statuscode")]
    public eAccount_statuscode? statuscode
    {
      get
      {
        return this.statuscode_OptionSetValue != null ? new eAccount_statuscode?((eAccount_statuscode) this.statuscode_OptionSetValue.Value) : new eAccount_statuscode?();
      }
      set
      {
        if (value.HasValue)
          this.statuscode_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.statuscode_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("statuscode")]
    public OptionSetValue statuscode_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("statuscode");
      set
      {
        this.SetPropertyValue<OptionSetValue>("statuscode", value, nameof (statuscode_OptionSetValue));
      }
    }

    public string statuscode_Text(IOrganizationService service)
    {
      return this.statuscode_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "statuscode");
    }

    public string statuscode_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.statuscode_OptionSetValue.Value);
    }

    [AttributeLogicalName("stockexchange")]
    public string stockexchange
    {
      get => this.GetPropertyValue<string>(nameof (stockexchange));
      set => this.SetPropertyValue(nameof (stockexchange), value, 20, nameof (stockexchange));
    }

    [AttributeLogicalName("teamsfollowed")]
    public int? teamsfollowed
    {
      get => this.GetPropertyValue<int?>(nameof (teamsfollowed));
      set
      {
        this.SetPropertyValue(nameof (teamsfollowed), value, int.MinValue, int.MaxValue, nameof (teamsfollowed));
      }
    }

    [AttributeLogicalName("telephone1")]
    public string telephone1
    {
      get => this.GetPropertyValue<string>(nameof (telephone1));
      set => this.SetPropertyValue(nameof (telephone1), value, 50, nameof (telephone1));
    }

    [AttributeLogicalName("telephone2")]
    public string telephone2
    {
      get => this.GetPropertyValue<string>(nameof (telephone2));
      set => this.SetPropertyValue(nameof (telephone2), value, 50, nameof (telephone2));
    }

    [AttributeLogicalName("telephone3")]
    public string telephone3
    {
      get => this.GetPropertyValue<string>(nameof (telephone3));
      set => this.SetPropertyValue(nameof (telephone3), value, 50, nameof (telephone3));
    }

    [AttributeLogicalName("territorycode")]
    public eAccount_territorycode? territorycode
    {
      get
      {
        return this.territorycode_OptionSetValue != null ? new eAccount_territorycode?((eAccount_territorycode) this.territorycode_OptionSetValue.Value) : new eAccount_territorycode?();
      }
      set
      {
        if (value.HasValue)
          this.territorycode_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.territorycode_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("territorycode")]
    public OptionSetValue territorycode_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("territorycode");
      set
      {
        this.SetPropertyValue<OptionSetValue>("territorycode", value, nameof (territorycode_OptionSetValue));
      }
    }

    public string territorycode_Text(IOrganizationService service)
    {
      return this.territorycode_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "territorycode");
    }

    public string territorycode_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.territorycode_OptionSetValue.Value);
    }

    [AttributeLogicalName("territoryid")]
    public EntityReference territoryid
    {
      get => this.GetPropertyValue<EntityReference>(nameof (territoryid));
      set
      {
        this.SetPropertyValue<EntityReference>(nameof (territoryid), value, nameof (territoryid));
      }
    }

    [AttributeLogicalName("territoryidname")]
    public string territoryidname => this.GetPropertyValue<string>(nameof (territoryidname));

    [AttributeLogicalName("tickersymbol")]
    public string tickersymbol
    {
      get => this.GetPropertyValue<string>(nameof (tickersymbol));
      set => this.SetPropertyValue(nameof (tickersymbol), value, 10, nameof (tickersymbol));
    }

    [AttributeLogicalName("timespentbymeonemailandmeetings")]
    public string timespentbymeonemailandmeetings
    {
      get => this.GetPropertyValue<string>(nameof (timespentbymeonemailandmeetings));
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

    [AttributeLogicalName("traversedpath")]
    public string traversedpath
    {
      get => this.GetPropertyValue<string>(nameof (traversedpath));
      set => this.SetPropertyValue(nameof (traversedpath), value, 1250, nameof (traversedpath));
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

    [AttributeLogicalName("versionnumber")]
    public int? versionnumber => this.GetPropertyValue<int?>(nameof (versionnumber));

    [AttributeLogicalName("websiteurl")]
    public string websiteurl
    {
      get => this.GetPropertyValue<string>(nameof (websiteurl));
      set => this.SetPropertyValue(nameof (websiteurl), value, 200, nameof (websiteurl));
    }

    [AttributeLogicalName("yominame")]
    public string yominame
    {
      get => this.GetPropertyValue<string>(nameof (yominame));
      set => this.SetPropertyValue(nameof (yominame), value, 160, nameof (yominame));
    }

    public List<account> Getaccount_master_account(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<account>(service, this.Id, nameof (account), "masterid", columns);
    }

    public List<account> Getaccount_master_account(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<account>(service, this.Id, nameof (account), "masterid", columns);
    }

    public List<account> Getaccount_parent_account(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<account>(service, this.Id, nameof (account), "parentaccountid", columns);
    }

    public List<account> Getaccount_parent_account(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<account>(service, this.Id, nameof (account), "parentaccountid", columns);
    }

    public List<Entity> Getaccount_actioncard(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "actioncard", "regardingobjectid", columns);
    }

    public List<Entity> Getaccount_actioncard(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "actioncard", "regardingobjectid", columns);
    }

    public List<Entity> Getaccount_activity_parties(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "activityparty", "partyid", columns);
    }

    public List<Entity> Getaccount_activity_parties(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "activityparty", "partyid", columns);
    }

    public List<Entity> GetAccount_ActivityPointers(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "activitypointer", "regardingobjectid", columns);
    }

    public List<Entity> GetAccount_ActivityPointers(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "activitypointer", "regardingobjectid", columns);
    }

    public List<ait_courtprofile> Getait_account_ait_courtprofile_Account(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_courtprofile>(service, this.Id, "ait_courtprofile", "ait_account", columns);
    }

    public List<ait_courtprofile> Getait_account_ait_courtprofile_Account(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_courtprofile>(service, this.Id, "ait_courtprofile", "ait_account", columns);
    }

    public List<Entity> Getaccount_ait_hearings(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_hearing", "regardingobjectid", columns);
    }

    public List<Entity> Getaccount_ait_hearings(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_hearing", "regardingobjectid", columns);
    }

    public List<Entity> GetAccount_Annotation(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "annotation", "objectid", columns);
    }

    public List<Entity> GetAccount_Annotation(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "annotation", "objectid", columns);
    }

    public List<appointment> GetAccount_Appointments(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<appointment>(service, this.Id, "appointment", "regardingobjectid", columns);
    }

    public List<appointment> GetAccount_Appointments(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<appointment>(service, this.Id, "appointment", "regardingobjectid", columns);
    }

    public List<Entity> GetAccount_AsyncOperations(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "asyncoperation", "regardingobjectid", columns);
    }

    public List<Entity> GetAccount_AsyncOperations(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "asyncoperation", "regardingobjectid", columns);
    }

    public List<Entity> Getaccount_bookableresource_AccountId(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bookableresource", "accountid", columns);
    }

    public List<Entity> Getaccount_bookableresource_AccountId(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bookableresource", "accountid", columns);
    }

    public List<Entity> GetAccount_BulkDeleteFailures(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bulkdeletefailure", "regardingobjectid", columns);
    }

    public List<Entity> GetAccount_BulkDeleteFailures(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bulkdeletefailure", "regardingobjectid", columns);
    }

    public List<Entity> Getaccount_BulkOperations(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bulkoperation", "regardingobjectid", columns);
    }

    public List<Entity> Getaccount_BulkOperations(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bulkoperation", "regardingobjectid", columns);
    }

    public List<Entity> GetCreatedAccount_BulkOperationLogs2(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bulkoperationlog", "createdobjectid", columns);
    }

    public List<Entity> GetCreatedAccount_BulkOperationLogs2(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bulkoperationlog", "createdobjectid", columns);
    }

    public List<Entity> GetSourceAccount_BulkOperationLogs(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bulkoperationlog", "regardingobjectid", columns);
    }

    public List<Entity> GetSourceAccount_BulkOperationLogs(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bulkoperationlog", "regardingobjectid", columns);
    }

    public List<Entity> Getaccount_CampaignResponses(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "campaignresponse", "regardingobjectid", columns);
    }

    public List<Entity> Getaccount_CampaignResponses(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "campaignresponse", "regardingobjectid", columns);
    }

    public List<connection> Getaccount_connections1(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<connection>(service, this.Id, "connection", "record1id", columns);
    }

    public List<connection> Getaccount_connections1(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<connection>(service, this.Id, "connection", "record1id", columns);
    }

    public List<connection> Getaccount_connections2(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<connection>(service, this.Id, "connection", "record2id", columns);
    }

    public List<connection> Getaccount_connections2(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<connection>(service, this.Id, "connection", "record2id", columns);
    }

    public List<contact> Getcontact_customer_accounts(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<contact>(service, this.Id, "contact", "parentcustomerid", columns);
    }

    public List<contact> Getcontact_customer_accounts(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<contact>(service, this.Id, "contact", "parentcustomerid", columns);
    }

    public List<Entity> Getcontract_billingcustomer_accounts(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "contract", "billingcustomerid", columns);
    }

    public List<Entity> Getcontract_billingcustomer_accounts(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "contract", "billingcustomerid", columns);
    }

    public List<Entity> Getcontract_customer_accounts(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "contract", "customerid", columns);
    }

    public List<Entity> Getcontract_customer_accounts(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "contract", "customerid", columns);
    }

    public List<Entity> Getcontractlineitem_customer_accounts(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "contractdetail", "customerid", columns);
    }

    public List<Entity> Getcontractlineitem_customer_accounts(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "contractdetail", "customerid", columns);
    }

    public List<Entity> GetAccount_CustomerAddress(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "customeraddress", "parentid", columns);
    }

    public List<Entity> GetAccount_CustomerAddress(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "customeraddress", "parentid", columns);
    }

    public List<Entity> Getaccount_customer_opportunity_roles(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "customeropportunityrole", "customerid", columns);
    }

    public List<Entity> Getaccount_customer_opportunity_roles(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "customeropportunityrole", "customerid", columns);
    }

    public List<Entity> Getaccount_customer_relationship_customer(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "customerrelationship", "customerid", columns);
    }

    public List<Entity> Getaccount_customer_relationship_customer(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "customerrelationship", "customerid", columns);
    }

    public List<Entity> Getaccount_customer_relationship_partner(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "customerrelationship", "partnerid", columns);
    }

    public List<Entity> Getaccount_customer_relationship_partner(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "customerrelationship", "partnerid", columns);
    }

    public List<Entity> GetAccount_DuplicateBaseRecord(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "duplicaterecord", "baserecordid", columns);
    }

    public List<Entity> GetAccount_DuplicateBaseRecord(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "duplicaterecord", "baserecordid", columns);
    }

    public List<Entity> GetAccount_DuplicateMatchingRecord(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "duplicaterecord", "duplicaterecordid", columns);
    }

    public List<Entity> GetAccount_DuplicateMatchingRecord(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "duplicaterecord", "duplicaterecordid", columns);
    }

    public List<Entity> GetAccount_Email_EmailSender(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "email", "emailsender", columns);
    }

    public List<Entity> GetAccount_Email_EmailSender(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "email", "emailsender", columns);
    }

    public List<Entity> GetAccount_Email_SendersAccount(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "email", "sendersaccount", columns);
    }

    public List<Entity> GetAccount_Email_SendersAccount(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "email", "sendersaccount", columns);
    }

    public List<Entity> GetAccount_Emails(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "email", "regardingobjectid", columns);
    }

    public List<Entity> GetAccount_Emails(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "email", "regardingobjectid", columns);
    }

    public List<Entity> Getaccount_entitlement_Account(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "entitlement", "accountid", columns);
    }

    public List<Entity> Getaccount_entitlement_Account(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "entitlement", "accountid", columns);
    }

    public List<Entity> Getaccount_entitlement_Customer(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "entitlement", "customerid", columns);
    }

    public List<Entity> Getaccount_entitlement_Customer(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "entitlement", "customerid", columns);
    }

    public List<Entity> GetAccount_Faxes(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "fax", "regardingobjectid", columns);
    }

    public List<Entity> GetAccount_Faxes(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "fax", "regardingobjectid", columns);
    }

    public List<Entity> Getincident_customer_accounts(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "incident", "customerid", columns);
    }

    public List<Entity> Getincident_customer_accounts(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "incident", "customerid", columns);
    }

    public List<Entity> Getaccount_IncidentResolutions(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "incidentresolution", "regardingobjectid", columns);
    }

    public List<Entity> Getaccount_IncidentResolutions(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "incidentresolution", "regardingobjectid", columns);
    }

    public List<Entity> Getinvoice_customer_accounts(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "invoice", "customerid", columns);
    }

    public List<Entity> Getinvoice_customer_accounts(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "invoice", "customerid", columns);
    }

    public List<Entity> Getlead_customer_accounts(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "lead", "customerid", columns);
    }

    public List<Entity> Getlead_customer_accounts(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "lead", "customerid", columns);
    }

    public List<Entity> Getlead_parent_account(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "lead", "parentaccountid", columns);
    }

    public List<Entity> Getlead_parent_account(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "lead", "parentaccountid", columns);
    }

    public List<Entity> GetAccount_Letters(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "letter", "regardingobjectid", columns);
    }

    public List<Entity> GetAccount_Letters(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "letter", "regardingobjectid", columns);
    }

    public List<Entity> GetAccount_MailboxTrackingFolder(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "mailboxtrackingfolder", "regardingobjectid", columns);
    }

    public List<Entity> GetAccount_MailboxTrackingFolder(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "mailboxtrackingfolder", "regardingobjectid", columns);
    }

    public List<Entity> Getmsdyn_account_msdyn_customerasset_Account(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_customerasset", "msdyn_account", columns);
    }

    public List<Entity> Getmsdyn_account_msdyn_customerasset_Account(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_customerasset", "msdyn_account", columns);
    }

    public List<Entity> Getmsdyn_account_msdyn_iotdevice_Account(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iotdevice", "msdyn_account", columns);
    }

    public List<Entity> Getmsdyn_account_msdyn_iotdevice_Account(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iotdevice", "msdyn_account", columns);
    }

    public List<Entity> Getmsdyn_playbookinstance_account(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_playbookinstance", "regarding", columns);
    }

    public List<Entity> Getmsdyn_playbookinstance_account(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_playbookinstance", "regarding", columns);
    }

    public List<Entity> Getaccount_msfp_surveyinvites(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msfp_surveyinvite", "regardingobjectid", columns);
    }

    public List<Entity> Getaccount_msfp_surveyinvites(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msfp_surveyinvite", "regardingobjectid", columns);
    }

    public List<Entity> Getaccount_msfp_surveyresponses(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msfp_surveyresponse", "regardingobjectid", columns);
    }

    public List<Entity> Getaccount_msfp_surveyresponses(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msfp_surveyresponse", "regardingobjectid", columns);
    }

    public List<Entity> Getopportunity_customer_accounts(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "opportunity", "customerid", columns);
    }

    public List<Entity> Getopportunity_customer_accounts(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "opportunity", "customerid", columns);
    }

    public List<Entity> Getopportunity_parent_account(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "opportunity", "parentaccountid", columns);
    }

    public List<Entity> Getopportunity_parent_account(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "opportunity", "parentaccountid", columns);
    }

    public List<Entity> Getaccount_OpportunityCloses(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "opportunityclose", "regardingobjectid", columns);
    }

    public List<Entity> Getaccount_OpportunityCloses(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "opportunityclose", "regardingobjectid", columns);
    }

    public List<Entity> Getaccount_OrderCloses(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "orderclose", "regardingobjectid", columns);
    }

    public List<Entity> Getaccount_OrderCloses(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "orderclose", "regardingobjectid", columns);
    }

    public List<Entity> GetAccount_Phonecalls(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "phonecall", "regardingobjectid", columns);
    }

    public List<Entity> GetAccount_Phonecalls(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "phonecall", "regardingobjectid", columns);
    }

    public List<Entity> Getaccount_PostFollows(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "postfollow", "regardingobjectid", columns);
    }

    public List<Entity> Getaccount_PostFollows(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "postfollow", "regardingobjectid", columns);
    }

    public List<Entity> Getaccount_PostRegardings(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "postregarding", "regardingobjectid", columns);
    }

    public List<Entity> Getaccount_PostRegardings(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "postregarding", "regardingobjectid", columns);
    }

    public List<Entity> Getaccount_PostRoles(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "postrole", "regardingobjectid", columns);
    }

    public List<Entity> Getaccount_PostRoles(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "postrole", "regardingobjectid", columns);
    }

    public List<Entity> Getaccount_principalobjectattributeaccess(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "principalobjectattributeaccess", "objectid", columns);
    }

    public List<Entity> Getaccount_principalobjectattributeaccess(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "principalobjectattributeaccess", "objectid", columns);
    }

    public List<Entity> GetAccount_ProcessSessions(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "processsession", "regardingobjectid", columns);
    }

    public List<Entity> GetAccount_ProcessSessions(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "processsession", "regardingobjectid", columns);
    }

    public List<Entity> Getquote_customer_accounts(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "quote", "customerid", columns);
    }

    public List<Entity> Getquote_customer_accounts(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "quote", "customerid", columns);
    }

    public List<Entity> Getaccount_QuoteCloses(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "quoteclose", "regardingobjectid", columns);
    }

    public List<Entity> Getaccount_QuoteCloses(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "quoteclose", "regardingobjectid", columns);
    }

    public List<Entity> GetAccount_RecurringAppointmentMasters(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "recurringappointmentmaster", "regardingobjectid", columns);
    }

    public List<Entity> GetAccount_RecurringAppointmentMasters(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "recurringappointmentmaster", "regardingobjectid", columns);
    }

    public List<Entity> Getorder_customer_accounts(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "salesorder", "customerid", columns);
    }

    public List<Entity> Getorder_customer_accounts(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "salesorder", "customerid", columns);
    }

    public List<Entity> GetAccount_ServiceAppointments(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "serviceappointment", "regardingobjectid", columns);
    }

    public List<Entity> GetAccount_ServiceAppointments(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "serviceappointment", "regardingobjectid", columns);
    }

    public List<Entity> GetAccount_SharepointDocument(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sharepointdocument", "regardingobjectid", columns);
    }

    public List<Entity> GetAccount_SharepointDocument(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sharepointdocument", "regardingobjectid", columns);
    }

    public List<Entity> GetAccount_SharepointDocumentLocation(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sharepointdocumentlocation", "regardingobjectid", columns);
    }

    public List<Entity> GetAccount_SharepointDocumentLocation(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sharepointdocumentlocation", "regardingobjectid", columns);
    }

    public List<Entity> Getslakpiinstance_account(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "slakpiinstance", "regarding", columns);
    }

    public List<Entity> Getslakpiinstance_account(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "slakpiinstance", "regarding", columns);
    }

    public List<Entity> GetAccount_SocialActivities(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "socialactivity", "regardingobjectid", columns);
    }

    public List<Entity> GetAccount_SocialActivities(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "socialactivity", "regardingobjectid", columns);
    }

    public List<Entity> GetSocialActivity_PostAuthor_accounts(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "socialactivity", "postauthor", columns);
    }

    public List<Entity> GetSocialActivity_PostAuthor_accounts(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "socialactivity", "postauthor", columns);
    }

    public List<Entity> GetSocialActivity_PostAuthorAccount_accounts(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "socialactivity", "postauthoraccount", columns);
    }

    public List<Entity> GetSocialActivity_PostAuthorAccount_accounts(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "socialactivity", "postauthoraccount", columns);
    }

    public List<Entity> GetSocialprofile_customer_accounts(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "socialprofile", "customerid", columns);
    }

    public List<Entity> GetSocialprofile_customer_accounts(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "socialprofile", "customerid", columns);
    }

    public List<Entity> GetAccount_SyncErrors(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "syncerror", "regardingobjectid", columns);
    }

    public List<Entity> GetAccount_SyncErrors(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "syncerror", "regardingobjectid", columns);
    }

    public List<Entity> GetAccount_Tasks(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "task", "regardingobjectid", columns);
    }

    public List<Entity> GetAccount_Tasks(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "task", "regardingobjectid", columns);
    }

    public List<Entity> Getuserentityinstancedata_account(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userentityinstancedata", "objectid", columns);
    }

    public List<Entity> Getuserentityinstancedata_account(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userentityinstancedata", "objectid", columns);
    }

    public List<Entity> Getaccountleads_association(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedManyToManyEntities(service, (BaseProxyClass) this, nameof (account), "accountid", "lead", "leadid", "accountleads", "leadid", "accountid", columns);
    }

    public List<Entity> Getaccountleads_association(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedManyToManyEntities(service, (BaseProxyClass) this, nameof (account), "accountid", "lead", "leadid", "accountleads", "leadid", "accountid", columns);
    }

    public void Relateaccountleads_association(IOrganizationService service, params Entity[] items)
    {
      service.RelateEntities((EntityReference) (BaseProxyClass) this, "accountleads_association", items);
    }

    public void Relateaccountleads_association(
      IOrganizationService service,
      params EntityReference[] items)
    {
      service.RelateEntities((EntityReference) (BaseProxyClass) this, "accountleads_association", items);
    }

    public void UnRelateaccountleads_association(
      IOrganizationService service,
      params Entity[] items)
    {
      service.UnRelateEntities((EntityReference) (BaseProxyClass) this, "accountleads_association", items);
    }

    public void UnRelateaccountleads_association(
      IOrganizationService service,
      params EntityReference[] items)
    {
      service.UnRelateEntities((EntityReference) (BaseProxyClass) this, "accountleads_association", items);
    }

    public List<Entity> GetBulkOperation_Accounts(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedManyToManyEntities(service, (BaseProxyClass) this, nameof (account), "accountid", "bulkoperation", "activityid", "bulkoperationlog", "regardingobjectid", "bulkoperationid", columns);
    }

    public List<Entity> GetBulkOperation_Accounts(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedManyToManyEntities(service, (BaseProxyClass) this, nameof (account), "accountid", "bulkoperation", "activityid", "bulkoperationlog", "regardingobjectid", "bulkoperationid", columns);
    }

    public void RelateBulkOperation_Accounts(IOrganizationService service, params Entity[] items)
    {
      service.RelateEntities((EntityReference) (BaseProxyClass) this, "BulkOperation_Accounts", items);
    }

    public void RelateBulkOperation_Accounts(
      IOrganizationService service,
      params EntityReference[] items)
    {
      service.RelateEntities((EntityReference) (BaseProxyClass) this, "BulkOperation_Accounts", items);
    }

    public void UnRelateBulkOperation_Accounts(IOrganizationService service, params Entity[] items)
    {
      service.UnRelateEntities((EntityReference) (BaseProxyClass) this, "BulkOperation_Accounts", items);
    }

    public void UnRelateBulkOperation_Accounts(
      IOrganizationService service,
      params EntityReference[] items)
    {
      service.UnRelateEntities((EntityReference) (BaseProxyClass) this, "BulkOperation_Accounts", items);
    }

    public List<Entity> GetCampaignActivity_Accounts(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedManyToManyEntities(service, (BaseProxyClass) this, nameof (account), "accountid", "campaignactivity", "activityid", "bulkoperationlog", "regardingobjectid", "campaignactivityid", columns);
    }

    public List<Entity> GetCampaignActivity_Accounts(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedManyToManyEntities(service, (BaseProxyClass) this, nameof (account), "accountid", "campaignactivity", "activityid", "bulkoperationlog", "regardingobjectid", "campaignactivityid", columns);
    }

    public void RelateCampaignActivity_Accounts(IOrganizationService service, params Entity[] items)
    {
      service.RelateEntities((EntityReference) (BaseProxyClass) this, "CampaignActivity_Accounts", items);
    }

    public void RelateCampaignActivity_Accounts(
      IOrganizationService service,
      params EntityReference[] items)
    {
      service.RelateEntities((EntityReference) (BaseProxyClass) this, "CampaignActivity_Accounts", items);
    }

    public void UnRelateCampaignActivity_Accounts(
      IOrganizationService service,
      params Entity[] items)
    {
      service.UnRelateEntities((EntityReference) (BaseProxyClass) this, "CampaignActivity_Accounts", items);
    }

    public void UnRelateCampaignActivity_Accounts(
      IOrganizationService service,
      params EntityReference[] items)
    {
      service.UnRelateEntities((EntityReference) (BaseProxyClass) this, "CampaignActivity_Accounts", items);
    }

    public List<Entity> Getlistaccount_association(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedManyToManyEntities(service, (BaseProxyClass) this, nameof (account), "accountid", "list", "listid", "listmember", "entityid", "listid", columns);
    }

    public List<Entity> Getlistaccount_association(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedManyToManyEntities(service, (BaseProxyClass) this, nameof (account), "accountid", "list", "listid", "listmember", "entityid", "listid", columns);
    }

    public void Relatelistaccount_association(IOrganizationService service, params Entity[] items)
    {
      service.RelateEntities((EntityReference) (BaseProxyClass) this, "listaccount_association", items);
    }

    public void Relatelistaccount_association(
      IOrganizationService service,
      params EntityReference[] items)
    {
      service.RelateEntities((EntityReference) (BaseProxyClass) this, "listaccount_association", items);
    }

    public void UnRelatelistaccount_association(IOrganizationService service, params Entity[] items)
    {
      service.UnRelateEntities((EntityReference) (BaseProxyClass) this, "listaccount_association", items);
    }

    public void UnRelatelistaccount_association(
      IOrganizationService service,
      params EntityReference[] items)
    {
      service.UnRelateEntities((EntityReference) (BaseProxyClass) this, "listaccount_association", items);
    }

    public static class Properties
    {
      public const string accountcategorycode = "accountcategorycode";
      public const string accountcategorycodename = "accountcategorycodename";
      public const string accountclassificationcode = "accountclassificationcode";
      public const string accountclassificationcodename = "accountclassificationcodename";
      public const string accountid = "accountid";
      public const string accountnumber = "accountnumber";
      public const string accountratingcode = "accountratingcode";
      public const string accountratingcodename = "accountratingcodename";
      public const string address1_addressid = "address1_addressid";
      public const string address1_addresstypecode = "address1_addresstypecode";
      public const string address1_addresstypecodename = "address1_addresstypecodename";
      public const string address1_city = "address1_city";
      public const string address1_composite = "address1_composite";
      public const string address1_country = "address1_country";
      public const string address1_county = "address1_county";
      public const string address1_fax = "address1_fax";
      public const string address1_freighttermscode = "address1_freighttermscode";
      public const string address1_freighttermscodename = "address1_freighttermscodename";
      public const string address1_latitude = "address1_latitude";
      public const string address1_line1 = "address1_line1";
      public const string address1_line2 = "address1_line2";
      public const string address1_line3 = "address1_line3";
      public const string address1_longitude = "address1_longitude";
      public const string address1_name = "address1_name";
      public const string address1_postalcode = "address1_postalcode";
      public const string address1_postofficebox = "address1_postofficebox";
      public const string address1_primarycontactname = "address1_primarycontactname";
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
      public const string address2_composite = "address2_composite";
      public const string address2_country = "address2_country";
      public const string address2_county = "address2_county";
      public const string address2_fax = "address2_fax";
      public const string address2_freighttermscode = "address2_freighttermscode";
      public const string address2_freighttermscodename = "address2_freighttermscodename";
      public const string address2_latitude = "address2_latitude";
      public const string address2_line1 = "address2_line1";
      public const string address2_line2 = "address2_line2";
      public const string address2_line3 = "address2_line3";
      public const string address2_longitude = "address2_longitude";
      public const string address2_name = "address2_name";
      public const string address2_postalcode = "address2_postalcode";
      public const string address2_postofficebox = "address2_postofficebox";
      public const string address2_primarycontactname = "address2_primarycontactname";
      public const string address2_shippingmethodcode = "address2_shippingmethodcode";
      public const string address2_shippingmethodcodename = "address2_shippingmethodcodename";
      public const string address2_stateorprovince = "address2_stateorprovince";
      public const string address2_telephone1 = "address2_telephone1";
      public const string address2_telephone2 = "address2_telephone2";
      public const string address2_telephone3 = "address2_telephone3";
      public const string address2_upszone = "address2_upszone";
      public const string address2_utcoffset = "address2_utcoffset";
      public const string aging30 = "aging30";
      public const string aging30_base = "aging30_base";
      public const string aging60 = "aging60";
      public const string aging60_base = "aging60_base";
      public const string aging90 = "aging90";
      public const string aging90_base = "aging90_base";
      public const string businesstypecode = "businesstypecode";
      public const string businesstypecodename = "businesstypecodename";
      public const string createdby = "createdby";
      public const string createdbyexternalparty = "createdbyexternalparty";
      public const string createdbyexternalpartyname = "createdbyexternalpartyname";
      public const string createdbyexternalpartyyominame = "createdbyexternalpartyyominame";
      public const string createdbyname = "createdbyname";
      public const string createdbyyominame = "createdbyyominame";
      public const string createdon = "createdon";
      public const string createdonbehalfby = "createdonbehalfby";
      public const string createdonbehalfbyname = "createdonbehalfbyname";
      public const string createdonbehalfbyyominame = "createdonbehalfbyyominame";
      public const string creditlimit = "creditlimit";
      public const string creditlimit_base = "creditlimit_base";
      public const string creditonhold = "creditonhold";
      public const string creditonholdname = "creditonholdname";
      public const string customersizecode = "customersizecode";
      public const string customersizecodename = "customersizecodename";
      public const string customertypecode = "customertypecode";
      public const string customertypecodename = "customertypecodename";
      public const string defaultpricelevelid = "defaultpricelevelid";
      public const string defaultpricelevelidname = "defaultpricelevelidname";
      public const string description = "description";
      public const string donotbulkemail = "donotbulkemail";
      public const string donotbulkemailname = "donotbulkemailname";
      public const string donotbulkpostalmail = "donotbulkpostalmail";
      public const string donotbulkpostalmailname = "donotbulkpostalmailname";
      public const string donotemail = "donotemail";
      public const string donotemailname = "donotemailname";
      public const string donotfax = "donotfax";
      public const string donotfaxname = "donotfaxname";
      public const string donotphone = "donotphone";
      public const string donotphonename = "donotphonename";
      public const string donotpostalmail = "donotpostalmail";
      public const string donotpostalmailname = "donotpostalmailname";
      public const string donotsendmarketingmaterialname = "donotsendmarketingmaterialname";
      public const string donotsendmm = "donotsendmm";
      public const string emailaddress1 = "emailaddress1";
      public const string emailaddress2 = "emailaddress2";
      public const string emailaddress3 = "emailaddress3";
      public const string entityimage = "entityimage";
      public const string entityimage_timestamp = "entityimage_timestamp";
      public const string entityimage_url = "entityimage_url";
      public const string entityimageid = "entityimageid";
      public const string exchangerate = "exchangerate";
      public const string fax = "fax";
      public const string followemail = "followemail";
      public const string followemailname = "followemailname";
      public const string ftpsiteurl = "ftpsiteurl";
      public const string importsequencenumber = "importsequencenumber";
      public const string industrycode = "industrycode";
      public const string industrycodename = "industrycodename";
      public const string isprivate = "isprivate";
      public const string isprivatename = "isprivatename";
      public const string lastonholdtime = "lastonholdtime";
      public const string lastusedincampaign = "lastusedincampaign";
      public const string marketcap = "marketcap";
      public const string marketcap_base = "marketcap_base";
      public const string marketingonly = "marketingonly";
      public const string marketingonlyname = "marketingonlyname";
      public const string masteraccountidname = "masteraccountidname";
      public const string masteraccountidyominame = "masteraccountidyominame";
      public const string masterid = "masterid";
      public const string merged = "merged";
      public const string mergedname = "mergedname";
      public const string modifiedby = "modifiedby";
      public const string modifiedbyexternalparty = "modifiedbyexternalparty";
      public const string modifiedbyexternalpartyname = "modifiedbyexternalpartyname";
      public const string modifiedbyexternalpartyyominame = "modifiedbyexternalpartyyominame";
      public const string modifiedbyname = "modifiedbyname";
      public const string modifiedbyyominame = "modifiedbyyominame";
      public const string modifiedon = "modifiedon";
      public const string modifiedonbehalfby = "modifiedonbehalfby";
      public const string modifiedonbehalfbyname = "modifiedonbehalfbyname";
      public const string modifiedonbehalfbyyominame = "modifiedonbehalfbyyominame";
      public const string name = "name";
      public const string numberofemployees = "numberofemployees";
      public const string onholdtime = "onholdtime";
      public const string opendeals = "opendeals";
      public const string opendeals_date = "opendeals_date";
      public const string opendeals_state = "opendeals_state";
      public const string openrevenue = "openrevenue";
      public const string openrevenue_base = "openrevenue_base";
      public const string openrevenue_date = "openrevenue_date";
      public const string openrevenue_state = "openrevenue_state";
      public const string originatingleadid = "originatingleadid";
      public const string originatingleadidname = "originatingleadidname";
      public const string originatingleadidyominame = "originatingleadidyominame";
      public const string overriddencreatedon = "overriddencreatedon";
      public const string ownerid = "ownerid";
      public const string owneridname = "owneridname";
      public const string owneridtype = "owneridtype";
      public const string owneridyominame = "owneridyominame";
      public const string ownershipcode = "ownershipcode";
      public const string ownershipcodename = "ownershipcodename";
      public const string owningbusinessunit = "owningbusinessunit";
      public const string owningteam = "owningteam";
      public const string owninguser = "owninguser";
      public const string parentaccountid = "parentaccountid";
      public const string parentaccountidname = "parentaccountidname";
      public const string parentaccountidyominame = "parentaccountidyominame";
      public const string participatesinworkflow = "participatesinworkflow";
      public const string participatesinworkflowname = "participatesinworkflowname";
      public const string paymenttermscode = "paymenttermscode";
      public const string paymenttermscodename = "paymenttermscodename";
      public const string preferredappointmentdaycode = "preferredappointmentdaycode";
      public const string preferredappointmentdaycodename = "preferredappointmentdaycodename";
      public const string preferredappointmenttimecode = "preferredappointmenttimecode";
      public const string preferredappointmenttimecodename = "preferredappointmenttimecodename";
      public const string preferredcontactmethodcode = "preferredcontactmethodcode";
      public const string preferredcontactmethodcodename = "preferredcontactmethodcodename";
      public const string preferredequipmentid = "preferredequipmentid";
      public const string preferredequipmentidname = "preferredequipmentidname";
      public const string preferredserviceid = "preferredserviceid";
      public const string preferredserviceidname = "preferredserviceidname";
      public const string preferredsystemuserid = "preferredsystemuserid";
      public const string preferredsystemuseridname = "preferredsystemuseridname";
      public const string preferredsystemuseridyominame = "preferredsystemuseridyominame";
      public const string primarycontactid = "primarycontactid";
      public const string primarycontactidname = "primarycontactidname";
      public const string primarycontactidyominame = "primarycontactidyominame";
      public const string primarysatoriid = "primarysatoriid";
      public const string primarytwitterid = "primarytwitterid";
      public const string processid = "processid";
      public const string revenue = "revenue";
      public const string revenue_base = "revenue_base";
      public const string sharesoutstanding = "sharesoutstanding";
      public const string shippingmethodcode = "shippingmethodcode";
      public const string shippingmethodcodename = "shippingmethodcodename";
      public const string sic = "sic";
      public const string slaid = "slaid";
      public const string slainvokedid = "slainvokedid";
      public const string slainvokedidname = "slainvokedidname";
      public const string slaname = "slaname";
      public const string stageid = "stageid";
      public const string statecode = "statecode";
      public const string statecodename = "statecodename";
      public const string statuscode = "statuscode";
      public const string statuscodename = "statuscodename";
      public const string stockexchange = "stockexchange";
      public const string teamsfollowed = "teamsfollowed";
      public const string telephone1 = "telephone1";
      public const string telephone2 = "telephone2";
      public const string telephone3 = "telephone3";
      public const string territorycode = "territorycode";
      public const string territorycodename = "territorycodename";
      public const string territoryid = "territoryid";
      public const string territoryidname = "territoryidname";
      public const string tickersymbol = "tickersymbol";
      public const string timespentbymeonemailandmeetings = "timespentbymeonemailandmeetings";
      public const string timezoneruleversionnumber = "timezoneruleversionnumber";
      public const string transactioncurrencyid = "transactioncurrencyid";
      public const string transactioncurrencyidname = "transactioncurrencyidname";
      public const string traversedpath = "traversedpath";
      public const string utcconversiontimezonecode = "utcconversiontimezonecode";
      public const string versionnumber = "versionnumber";
      public const string websiteurl = "websiteurl";
      public const string yominame = "yominame";
    }
  }
}
