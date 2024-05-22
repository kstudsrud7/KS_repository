// Decompiled with JetBrains decompiler
// Type: TPCourt.EarlyBound.contact
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
  [EntityLogicalName("contact")]
  [GeneratedCode("XrmToolkit", "4.0")]
  [DataContract(Name = "Entity", Namespace = "http://schemas.microsoft.com/xrm/2011/Contracts")]
  public class contact : BaseProxyClass
  {
    public const string LogicalName = "contact";
    public const int ObjectTypeCode = 2;
    public const string PrimaryIdAttribute = "contactid";
    public const string PrimaryNameAttribute = "fullname";
    public const string PrimaryImageAttribute = "entityimage";
    private static Dictionary<string, BaseProxyClass.eTextOptions> _textOptions;
    private static Dictionary<string, BaseProxyClass.eNumberOptions> _numberOptions;
    private static Dictionary<string, string> _errorStrings;

    static contact()
    {
      BaseProxyClass.RegisterProxyType(typeof (contact), nameof (contact));
      contact._textOptions = new Dictionary<string, BaseProxyClass.eTextOptions>();
      contact._numberOptions = new Dictionary<string, BaseProxyClass.eNumberOptions>();
      contact._errorStrings = new Dictionary<string, string>();
      contact.TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
      contact.NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
    }

    public contact()
      : base(new Entity(nameof (contact)))
    {
    }

    public contact(Entity original)
      : base(original)
    {
    }

    public static string GetLogicalName() => BaseProxyClass.GetLogicalName<contact>();

    public static BaseProxyClass.eTextOptions TextOptions { get; set; }

    public static void SetTextOptions(
      string logicalName,
      BaseProxyClass.eTextOptions options,
      string errorString = null)
    {
      if (contact._textOptions.ContainsKey(logicalName))
        contact._textOptions[logicalName] = options;
      else
        contact._textOptions.Add(logicalName, options);
      if (!string.IsNullOrEmpty(errorString))
      {
        if (contact._errorStrings.ContainsKey(logicalName))
          contact._errorStrings[logicalName] = errorString;
        else
          contact._errorStrings.Add(logicalName, errorString);
      }
      else
      {
        if (!contact._errorStrings.ContainsKey(logicalName))
          return;
        contact._errorStrings.Remove(logicalName);
      }
    }

    protected override BaseProxyClass.eTextOptions GetTextOptions(string logicalName)
    {
      return contact._textOptions.ContainsKey(logicalName) ? contact._textOptions[logicalName] : contact.TextOptions;
    }

    public static BaseProxyClass.eNumberOptions NumberOptions { get; set; }

    public static void SetNumberOptions(
      string logicalName,
      BaseProxyClass.eNumberOptions options,
      string errorString = null)
    {
      if (contact._numberOptions.ContainsKey(logicalName))
        contact._numberOptions[logicalName] = options;
      else
        contact._numberOptions.Add(logicalName, options);
      if (!string.IsNullOrEmpty(errorString))
      {
        if (contact._errorStrings.ContainsKey(logicalName))
          contact._errorStrings[logicalName] = errorString;
        else
          contact._errorStrings.Add(logicalName, errorString);
      }
      else
      {
        if (!contact._errorStrings.ContainsKey(logicalName))
          return;
        contact._errorStrings.Remove(logicalName);
      }
    }

    protected override BaseProxyClass.eNumberOptions GetNumberOptions(string logicalName)
    {
      return contact._numberOptions.ContainsKey(logicalName) ? contact._numberOptions[logicalName] : contact.NumberOptions;
    }

    protected override string GetErrorString(
      string attributeName,
      BaseProxyClass.eErrorType defaultErrorType)
    {
      return contact._errorStrings.ContainsKey(attributeName) ? contact._errorStrings[attributeName] : (defaultErrorType == BaseProxyClass.eErrorType.Text ? contact.TextError : contact.NumberError);
    }

    public static string TextError { get; set; }

    public static string NumberError { get; set; }

    [AttributeLogicalName("accountid")]
    public EntityReference accountid => this.GetPropertyValue<EntityReference>(nameof (accountid));

    [AttributeLogicalName("accountidname")]
    public string accountidname => this.GetPropertyValue<string>(nameof (accountidname));

    [AttributeLogicalName("accountidyominame")]
    public string accountidyominame => this.GetPropertyValue<string>(nameof (accountidyominame));

    [AttributeLogicalName("accountrolecode")]
    public eContact_accountrolecode? accountrolecode
    {
      get
      {
        return this.accountrolecode_OptionSetValue != null ? new eContact_accountrolecode?((eContact_accountrolecode) this.accountrolecode_OptionSetValue.Value) : new eContact_accountrolecode?();
      }
      set
      {
        if (value.HasValue)
          this.accountrolecode_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.accountrolecode_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("accountrolecode")]
    public OptionSetValue accountrolecode_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("accountrolecode");
      set
      {
        this.SetPropertyValue<OptionSetValue>("accountrolecode", value, nameof (accountrolecode_OptionSetValue));
      }
    }

    public string accountrolecode_Text(IOrganizationService service)
    {
      return this.accountrolecode_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "accountrolecode");
    }

    public string accountrolecode_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.accountrolecode_OptionSetValue.Value);
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
    public eContact_address1_addresstypecode? address1_addresstypecode
    {
      get
      {
        return this.address1_addresstypecode_OptionSetValue != null ? new eContact_address1_addresstypecode?((eContact_address1_addresstypecode) this.address1_addresstypecode_OptionSetValue.Value) : new eContact_address1_addresstypecode?();
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
    public eContact_address1_freighttermscode? address1_freighttermscode
    {
      get
      {
        return this.address1_freighttermscode_OptionSetValue != null ? new eContact_address1_freighttermscode?((eContact_address1_freighttermscode) this.address1_freighttermscode_OptionSetValue.Value) : new eContact_address1_freighttermscode?();
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
    public eContact_address1_shippingmethodcode? address1_shippingmethodcode
    {
      get
      {
        return this.address1_shippingmethodcode_OptionSetValue != null ? new eContact_address1_shippingmethodcode?((eContact_address1_shippingmethodcode) this.address1_shippingmethodcode_OptionSetValue.Value) : new eContact_address1_shippingmethodcode?();
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
    public eContact_address2_addresstypecode? address2_addresstypecode
    {
      get
      {
        return this.address2_addresstypecode_OptionSetValue != null ? new eContact_address2_addresstypecode?((eContact_address2_addresstypecode) this.address2_addresstypecode_OptionSetValue.Value) : new eContact_address2_addresstypecode?();
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
    public eContact_address2_freighttermscode? address2_freighttermscode
    {
      get
      {
        return this.address2_freighttermscode_OptionSetValue != null ? new eContact_address2_freighttermscode?((eContact_address2_freighttermscode) this.address2_freighttermscode_OptionSetValue.Value) : new eContact_address2_freighttermscode?();
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
    public eContact_address2_shippingmethodcode? address2_shippingmethodcode
    {
      get
      {
        return this.address2_shippingmethodcode_OptionSetValue != null ? new eContact_address2_shippingmethodcode?((eContact_address2_shippingmethodcode) this.address2_shippingmethodcode_OptionSetValue.Value) : new eContact_address2_shippingmethodcode?();
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

    [AttributeLogicalName("address3_addressid")]
    public Guid address3_addressid
    {
      get => this.GetPropertyValue<Guid>(nameof (address3_addressid));
      set
      {
        this.SetPropertyValue<Guid>(nameof (address3_addressid), value, nameof (address3_addressid));
      }
    }

    [AttributeLogicalName("address3_addresstypecode")]
    public eContact_address3_addresstypecode? address3_addresstypecode
    {
      get
      {
        return this.address3_addresstypecode_OptionSetValue != null ? new eContact_address3_addresstypecode?((eContact_address3_addresstypecode) this.address3_addresstypecode_OptionSetValue.Value) : new eContact_address3_addresstypecode?();
      }
      set
      {
        if (value.HasValue)
          this.address3_addresstypecode_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.address3_addresstypecode_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("address3_addresstypecode")]
    public OptionSetValue address3_addresstypecode_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("address3_addresstypecode");
      set
      {
        this.SetPropertyValue<OptionSetValue>("address3_addresstypecode", value, nameof (address3_addresstypecode_OptionSetValue));
      }
    }

    public string address3_addresstypecode_Text(IOrganizationService service)
    {
      return this.address3_addresstypecode_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "address3_addresstypecode");
    }

    public string address3_addresstypecode_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.address3_addresstypecode_OptionSetValue.Value);
    }

    [AttributeLogicalName("address3_city")]
    public string address3_city
    {
      get => this.GetPropertyValue<string>(nameof (address3_city));
      set => this.SetPropertyValue(nameof (address3_city), value, 80, nameof (address3_city));
    }

    [AttributeLogicalName("address3_composite")]
    public string address3_composite => this.GetPropertyValue<string>(nameof (address3_composite));

    [AttributeLogicalName("address3_country")]
    public string address3_country
    {
      get => this.GetPropertyValue<string>(nameof (address3_country));
      set => this.SetPropertyValue(nameof (address3_country), value, 80, nameof (address3_country));
    }

    [AttributeLogicalName("address3_county")]
    public string address3_county
    {
      get => this.GetPropertyValue<string>(nameof (address3_county));
      set => this.SetPropertyValue(nameof (address3_county), value, 50, nameof (address3_county));
    }

    [AttributeLogicalName("address3_fax")]
    public string address3_fax
    {
      get => this.GetPropertyValue<string>(nameof (address3_fax));
      set => this.SetPropertyValue(nameof (address3_fax), value, 50, nameof (address3_fax));
    }

    [AttributeLogicalName("address3_freighttermscode")]
    public eContact_address3_freighttermscode? address3_freighttermscode
    {
      get
      {
        return this.address3_freighttermscode_OptionSetValue != null ? new eContact_address3_freighttermscode?((eContact_address3_freighttermscode) this.address3_freighttermscode_OptionSetValue.Value) : new eContact_address3_freighttermscode?();
      }
      set
      {
        if (value.HasValue)
          this.address3_freighttermscode_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.address3_freighttermscode_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("address3_freighttermscode")]
    public OptionSetValue address3_freighttermscode_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("address3_freighttermscode");
      set
      {
        this.SetPropertyValue<OptionSetValue>("address3_freighttermscode", value, nameof (address3_freighttermscode_OptionSetValue));
      }
    }

    public string address3_freighttermscode_Text(IOrganizationService service)
    {
      return this.address3_freighttermscode_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "address3_freighttermscode");
    }

    public string address3_freighttermscode_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.address3_freighttermscode_OptionSetValue.Value);
    }

    [AttributeLogicalName("address3_latitude")]
    public double? address3_latitude
    {
      get => this.GetPropertyValue<double?>(nameof (address3_latitude));
      set
      {
        this.SetPropertyValue(nameof (address3_latitude), value, -90.0, 90.0, nameof (address3_latitude));
      }
    }

    [AttributeLogicalName("address3_line1")]
    public string address3_line1
    {
      get => this.GetPropertyValue<string>(nameof (address3_line1));
      set => this.SetPropertyValue(nameof (address3_line1), value, 250, nameof (address3_line1));
    }

    [AttributeLogicalName("address3_line2")]
    public string address3_line2
    {
      get => this.GetPropertyValue<string>(nameof (address3_line2));
      set => this.SetPropertyValue(nameof (address3_line2), value, 250, nameof (address3_line2));
    }

    [AttributeLogicalName("address3_line3")]
    public string address3_line3
    {
      get => this.GetPropertyValue<string>(nameof (address3_line3));
      set => this.SetPropertyValue(nameof (address3_line3), value, 250, nameof (address3_line3));
    }

    [AttributeLogicalName("address3_longitude")]
    public double? address3_longitude
    {
      get => this.GetPropertyValue<double?>(nameof (address3_longitude));
      set
      {
        this.SetPropertyValue(nameof (address3_longitude), value, -180.0, 180.0, nameof (address3_longitude));
      }
    }

    [AttributeLogicalName("address3_name")]
    public string address3_name
    {
      get => this.GetPropertyValue<string>(nameof (address3_name));
      set => this.SetPropertyValue(nameof (address3_name), value, 200, nameof (address3_name));
    }

    [AttributeLogicalName("address3_postalcode")]
    public string address3_postalcode
    {
      get => this.GetPropertyValue<string>(nameof (address3_postalcode));
      set
      {
        this.SetPropertyValue(nameof (address3_postalcode), value, 20, nameof (address3_postalcode));
      }
    }

    [AttributeLogicalName("address3_postofficebox")]
    public string address3_postofficebox
    {
      get => this.GetPropertyValue<string>(nameof (address3_postofficebox));
      set
      {
        this.SetPropertyValue(nameof (address3_postofficebox), value, 20, nameof (address3_postofficebox));
      }
    }

    [AttributeLogicalName("address3_primarycontactname")]
    public string address3_primarycontactname
    {
      get => this.GetPropertyValue<string>(nameof (address3_primarycontactname));
      set
      {
        this.SetPropertyValue(nameof (address3_primarycontactname), value, 100, nameof (address3_primarycontactname));
      }
    }

    [AttributeLogicalName("address3_shippingmethodcode")]
    public eContact_address3_shippingmethodcode? address3_shippingmethodcode
    {
      get
      {
        return this.address3_shippingmethodcode_OptionSetValue != null ? new eContact_address3_shippingmethodcode?((eContact_address3_shippingmethodcode) this.address3_shippingmethodcode_OptionSetValue.Value) : new eContact_address3_shippingmethodcode?();
      }
      set
      {
        if (value.HasValue)
          this.address3_shippingmethodcode_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.address3_shippingmethodcode_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("address3_shippingmethodcode")]
    public OptionSetValue address3_shippingmethodcode_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("address3_shippingmethodcode");
      set
      {
        this.SetPropertyValue<OptionSetValue>("address3_shippingmethodcode", value, nameof (address3_shippingmethodcode_OptionSetValue));
      }
    }

    public string address3_shippingmethodcode_Text(IOrganizationService service)
    {
      return this.address3_shippingmethodcode_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "address3_shippingmethodcode");
    }

    public string address3_shippingmethodcode_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.address3_shippingmethodcode_OptionSetValue.Value);
    }

    [AttributeLogicalName("address3_stateorprovince")]
    public string address3_stateorprovince
    {
      get => this.GetPropertyValue<string>(nameof (address3_stateorprovince));
      set
      {
        this.SetPropertyValue(nameof (address3_stateorprovince), value, 50, nameof (address3_stateorprovince));
      }
    }

    [AttributeLogicalName("address3_telephone1")]
    public string address3_telephone1
    {
      get => this.GetPropertyValue<string>(nameof (address3_telephone1));
      set
      {
        this.SetPropertyValue(nameof (address3_telephone1), value, 50, nameof (address3_telephone1));
      }
    }

    [AttributeLogicalName("address3_telephone2")]
    public string address3_telephone2
    {
      get => this.GetPropertyValue<string>(nameof (address3_telephone2));
      set
      {
        this.SetPropertyValue(nameof (address3_telephone2), value, 50, nameof (address3_telephone2));
      }
    }

    [AttributeLogicalName("address3_telephone3")]
    public string address3_telephone3
    {
      get => this.GetPropertyValue<string>(nameof (address3_telephone3));
      set
      {
        this.SetPropertyValue(nameof (address3_telephone3), value, 50, nameof (address3_telephone3));
      }
    }

    [AttributeLogicalName("address3_upszone")]
    public string address3_upszone
    {
      get => this.GetPropertyValue<string>(nameof (address3_upszone));
      set => this.SetPropertyValue(nameof (address3_upszone), value, 4, nameof (address3_upszone));
    }

    [AttributeLogicalName("address3_utcoffset")]
    public int? address3_utcoffset
    {
      get => this.GetPropertyValue<int?>(nameof (address3_utcoffset));
      set
      {
        this.SetPropertyValue(nameof (address3_utcoffset), value, -1500, 1500, nameof (address3_utcoffset));
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

    [AttributeLogicalName("ait_age")]
    public int? ait_age
    {
      get => this.GetPropertyValue<int?>(nameof (ait_age));
      set
      {
        this.SetPropertyValue(nameof (ait_age), value, int.MinValue, int.MaxValue, nameof (ait_age));
      }
    }

    [AttributeLogicalName("ait_agegroup")]
    public eAit_agegroup? ait_agegroup
    {
      get
      {
        return this.ait_agegroup_OptionSetValue != null ? new eAit_agegroup?((eAit_agegroup) this.ait_agegroup_OptionSetValue.Value) : new eAit_agegroup?();
      }
      set
      {
        if (value.HasValue)
          this.ait_agegroup_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.ait_agegroup_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("ait_agegroup")]
    public OptionSetValue ait_agegroup_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("ait_agegroup");
      set
      {
        this.SetPropertyValue<OptionSetValue>("ait_agegroup", value, nameof (ait_agegroup_OptionSetValue));
      }
    }

    public string ait_agegroup_Text(IOrganizationService service)
    {
      return this.ait_agegroup_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "ait_agegroup");
    }

    public string ait_agegroup_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.ait_agegroup_OptionSetValue.Value);
    }

    [AttributeLogicalName("ait_bandid")]
    public EntityReference ait_bandid
    {
      get => this.GetPropertyValue<EntityReference>(nameof (ait_bandid));
      set
      {
        this.SetPropertyValue<EntityReference>(nameof (ait_bandid), value, nameof (ait_bandid));
      }
    }

    [AttributeLogicalName("ait_bandidname")]
    public string ait_bandidname => this.GetPropertyValue<string>(nameof (ait_bandidname));

    [AttributeLogicalName("ait_birthrecord")]
    public EntityReference ait_birthrecord
    {
      get => this.GetPropertyValue<EntityReference>(nameof (ait_birthrecord));
      set
      {
        this.SetPropertyValue<EntityReference>(nameof (ait_birthrecord), value, nameof (ait_birthrecord));
      }
    }

    [AttributeLogicalName("ait_birthrecordname")]
    public string ait_birthrecordname
    {
      get => this.GetPropertyValue<string>(nameof (ait_birthrecordname));
    }

    [AttributeLogicalName("ait_certificationidcard")]
    public EntityReference ait_certificationidcard
    {
      get => this.GetPropertyValue<EntityReference>(nameof (ait_certificationidcard));
      set
      {
        this.SetPropertyValue<EntityReference>(nameof (ait_certificationidcard), value, nameof (ait_certificationidcard));
      }
    }

    [AttributeLogicalName("ait_certificationidcardname")]
    public string ait_certificationidcardname
    {
      get => this.GetPropertyValue<string>(nameof (ait_certificationidcardname));
    }

    [AttributeLogicalName("ait_currentlyemployed")]
    public eAit_yesno? ait_currentlyemployed
    {
      get
      {
        return this.ait_currentlyemployed_OptionSetValue != null ? new eAit_yesno?((eAit_yesno) this.ait_currentlyemployed_OptionSetValue.Value) : new eAit_yesno?();
      }
      set
      {
        if (value.HasValue)
          this.ait_currentlyemployed_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.ait_currentlyemployed_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("ait_currentlyemployed")]
    public OptionSetValue ait_currentlyemployed_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("ait_currentlyemployed");
      set
      {
        this.SetPropertyValue<OptionSetValue>("ait_currentlyemployed", value, nameof (ait_currentlyemployed_OptionSetValue));
      }
    }

    public string ait_currentlyemployed_Text(IOrganizationService service)
    {
      return this.ait_currentlyemployed_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "ait_currentlyemployed");
    }

    public string ait_currentlyemployed_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.ait_currentlyemployed_OptionSetValue.Value);
    }

    [AttributeLogicalName("ait_deathdate")]
    public DateTime? ait_deathdate
    {
      get => this.GetPropertyValue<DateTime?>(nameof (ait_deathdate));
      set
      {
        this.SetPropertyValue<DateTime?>(nameof (ait_deathdate), value, nameof (ait_deathdate));
      }
    }

    [AttributeLogicalName("ait_deathrecord")]
    public EntityReference ait_deathrecord
    {
      get => this.GetPropertyValue<EntityReference>(nameof (ait_deathrecord));
      set
      {
        this.SetPropertyValue<EntityReference>(nameof (ait_deathrecord), value, nameof (ait_deathrecord));
      }
    }

    [AttributeLogicalName("ait_deathrecordname")]
    public string ait_deathrecordname
    {
      get => this.GetPropertyValue<string>(nameof (ait_deathrecordname));
    }

    [AttributeLogicalName("ait_disabled")]
    public eAit_disabled? ait_disabled
    {
      get
      {
        return this.ait_disabled_OptionSetValue != null ? new eAit_disabled?((eAit_disabled) this.ait_disabled_OptionSetValue.Value) : new eAit_disabled?();
      }
      set
      {
        if (value.HasValue)
          this.ait_disabled_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.ait_disabled_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("ait_disabled")]
    public OptionSetValue ait_disabled_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("ait_disabled");
      set
      {
        this.SetPropertyValue<OptionSetValue>("ait_disabled", value, nameof (ait_disabled_OptionSetValue));
      }
    }

    public string ait_disabled_Text(IOrganizationService service)
    {
      return this.ait_disabled_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "ait_disabled");
    }

    public string ait_disabled_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.ait_disabled_OptionSetValue.Value);
    }

    [AttributeLogicalName("ait_emergencycontact")]
    public EntityReference ait_emergencycontact
    {
      get => this.GetPropertyValue<EntityReference>(nameof (ait_emergencycontact));
      set
      {
        this.SetPropertyValue<EntityReference>(nameof (ait_emergencycontact), value, nameof (ait_emergencycontact));
      }
    }

    [AttributeLogicalName("ait_emergencycontactname")]
    public string ait_emergencycontactname
    {
      get => this.GetPropertyValue<string>(nameof (ait_emergencycontactname));
    }

    [AttributeLogicalName("ait_employeeidcard")]
    public EntityReference ait_employeeidcard
    {
      get => this.GetPropertyValue<EntityReference>(nameof (ait_employeeidcard));
      set
      {
        this.SetPropertyValue<EntityReference>(nameof (ait_employeeidcard), value, nameof (ait_employeeidcard));
      }
    }

    [AttributeLogicalName("ait_employeeidcardname")]
    public string ait_employeeidcardname
    {
      get => this.GetPropertyValue<string>(nameof (ait_employeeidcardname));
    }

    [AttributeLogicalName("ait_entityimagestring")]
    public string ait_entityimagestring
    {
      get => this.GetPropertyValue<string>(nameof (ait_entityimagestring));
      set
      {
        this.SetPropertyValue(nameof (ait_entityimagestring), value, 1024094, nameof (ait_entityimagestring));
      }
    }

    [AttributeLogicalName("ait_ethnicity")]
    public eAit_ethnicity? ait_ethnicity
    {
      get
      {
        return this.ait_ethnicity_OptionSetValue != null ? new eAit_ethnicity?((eAit_ethnicity) this.ait_ethnicity_OptionSetValue.Value) : new eAit_ethnicity?();
      }
      set
      {
        if (value.HasValue)
          this.ait_ethnicity_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.ait_ethnicity_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("ait_ethnicity")]
    public OptionSetValue ait_ethnicity_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("ait_ethnicity");
      set
      {
        this.SetPropertyValue<OptionSetValue>("ait_ethnicity", value, nameof (ait_ethnicity_OptionSetValue));
      }
    }

    public string ait_ethnicity_Text(IOrganizationService service)
    {
      return this.ait_ethnicity_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "ait_ethnicity");
    }

    public string ait_ethnicity_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.ait_ethnicity_OptionSetValue.Value);
    }

    [AttributeLogicalName("ait_eyecolor")]
    public eAit_eyecolor? ait_eyecolor
    {
      get
      {
        return this.ait_eyecolor_OptionSetValue != null ? new eAit_eyecolor?((eAit_eyecolor) this.ait_eyecolor_OptionSetValue.Value) : new eAit_eyecolor?();
      }
      set
      {
        if (value.HasValue)
          this.ait_eyecolor_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.ait_eyecolor_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("ait_eyecolor")]
    public OptionSetValue ait_eyecolor_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("ait_eyecolor");
      set
      {
        this.SetPropertyValue<OptionSetValue>("ait_eyecolor", value, nameof (ait_eyecolor_OptionSetValue));
      }
    }

    public string ait_eyecolor_Text(IOrganizationService service)
    {
      return this.ait_eyecolor_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "ait_eyecolor");
    }

    public string ait_eyecolor_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.ait_eyecolor_OptionSetValue.Value);
    }

    [AttributeLogicalName("ait_federalcdibid")]
    public string ait_federalcdibid
    {
      get => this.GetPropertyValue<string>(nameof (ait_federalcdibid));
      set
      {
        this.SetPropertyValue(nameof (ait_federalcdibid), value, 100, nameof (ait_federalcdibid));
      }
    }

    [AttributeLogicalName("ait_federalcdibstatus")]
    public eAit_federalcdibstatus? ait_federalcdibstatus
    {
      get
      {
        return this.ait_federalcdibstatus_OptionSetValue != null ? new eAit_federalcdibstatus?((eAit_federalcdibstatus) this.ait_federalcdibstatus_OptionSetValue.Value) : new eAit_federalcdibstatus?();
      }
      set
      {
        if (value.HasValue)
          this.ait_federalcdibstatus_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.ait_federalcdibstatus_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("ait_federalcdibstatus")]
    public OptionSetValue ait_federalcdibstatus_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("ait_federalcdibstatus");
      set
      {
        this.SetPropertyValue<OptionSetValue>("ait_federalcdibstatus", value, nameof (ait_federalcdibstatus_OptionSetValue));
      }
    }

    public string ait_federalcdibstatus_Text(IOrganizationService service)
    {
      return this.ait_federalcdibstatus_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "ait_federalcdibstatus");
    }

    public string ait_federalcdibstatus_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.ait_federalcdibstatus_OptionSetValue.Value);
    }

    [AttributeLogicalName("ait_federalcdibstatuseffectivedate")]
    public DateTime? ait_federalcdibstatuseffectivedate
    {
      get => this.GetPropertyValue<DateTime?>(nameof (ait_federalcdibstatuseffectivedate));
      set
      {
        this.SetPropertyValue<DateTime?>(nameof (ait_federalcdibstatuseffectivedate), value, nameof (ait_federalcdibstatuseffectivedate));
      }
    }

    [AttributeLogicalName("ait_gender")]
    public eAit_gender? ait_gender
    {
      get
      {
        return this.ait_gender_OptionSetValue != null ? new eAit_gender?((eAit_gender) this.ait_gender_OptionSetValue.Value) : new eAit_gender?();
      }
      set
      {
        if (value.HasValue)
          this.ait_gender_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.ait_gender_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("ait_gender")]
    public OptionSetValue ait_gender_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("ait_gender");
      set
      {
        this.SetPropertyValue<OptionSetValue>("ait_gender", value, nameof (ait_gender_OptionSetValue));
      }
    }

    public string ait_gender_Text(IOrganizationService service)
    {
      return this.ait_gender_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "ait_gender");
    }

    public string ait_gender_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.ait_gender_OptionSetValue.Value);
    }

    [AttributeLogicalName("ait_haircolor")]
    public eAit_haircolor? ait_haircolor
    {
      get
      {
        return this.ait_haircolor_OptionSetValue != null ? new eAit_haircolor?((eAit_haircolor) this.ait_haircolor_OptionSetValue.Value) : new eAit_haircolor?();
      }
      set
      {
        if (value.HasValue)
          this.ait_haircolor_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.ait_haircolor_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("ait_haircolor")]
    public OptionSetValue ait_haircolor_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("ait_haircolor");
      set
      {
        this.SetPropertyValue<OptionSetValue>("ait_haircolor", value, nameof (ait_haircolor_OptionSetValue));
      }
    }

    public string ait_haircolor_Text(IOrganizationService service)
    {
      return this.ait_haircolor_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "ait_haircolor");
    }

    public string ait_haircolor_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.ait_haircolor_OptionSetValue.Value);
    }

    [AttributeLogicalName("ait_height")]
    public Decimal? ait_height
    {
      get => this.GetPropertyValue<Decimal?>(nameof (ait_height));
      set
      {
        this.SetPropertyValue(nameof (ait_height), value, -100000000000M, 100000000000M, nameof (ait_height));
      }
    }

    [AttributeLogicalName("ait_heightstring")]
    public string ait_heightstring
    {
      get => this.GetPropertyValue<string>(nameof (ait_heightstring));
      set
      {
        this.SetPropertyValue(nameof (ait_heightstring), value, 100, nameof (ait_heightstring));
      }
    }

    [AttributeLogicalName("ait_household")]
    public EntityReference ait_household
    {
      get => this.GetPropertyValue<EntityReference>(nameof (ait_household));
      set
      {
        this.SetPropertyValue<EntityReference>(nameof (ait_household), value, nameof (ait_household));
      }
    }

    [AttributeLogicalName("ait_householdmember")]
    public EntityReference ait_householdmember
    {
      get => this.GetPropertyValue<EntityReference>(nameof (ait_householdmember));
      set
      {
        this.SetPropertyValue<EntityReference>(nameof (ait_householdmember), value, nameof (ait_householdmember));
      }
    }

    [AttributeLogicalName("ait_householdmembername")]
    public string ait_householdmembername
    {
      get => this.GetPropertyValue<string>(nameof (ait_householdmembername));
    }

    [AttributeLogicalName("ait_householdname")]
    public string ait_householdname => this.GetPropertyValue<string>(nameof (ait_householdname));

    [AttributeLogicalName("ait_incarcerated")]
    public bool? ait_incarcerated
    {
      get => this.GetPropertyValue<bool?>(nameof (ait_incarcerated));
      set
      {
        this.SetPropertyValue<bool?>(nameof (ait_incarcerated), value, nameof (ait_incarcerated));
      }
    }

    [AttributeLogicalName("ait_isdeceased")]
    public bool? ait_isdeceased => this.GetPropertyValue<bool?>(nameof (ait_isdeceased));

    [AttributeLogicalName("ait_maritalstatus")]
    public eAit_maritalstatus? ait_maritalstatus
    {
      get
      {
        return this.ait_maritalstatus_OptionSetValue != null ? new eAit_maritalstatus?((eAit_maritalstatus) this.ait_maritalstatus_OptionSetValue.Value) : new eAit_maritalstatus?();
      }
      set
      {
        if (value.HasValue)
          this.ait_maritalstatus_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.ait_maritalstatus_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("ait_maritalstatus")]
    public OptionSetValue ait_maritalstatus_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("ait_maritalstatus");
      set
      {
        this.SetPropertyValue<OptionSetValue>("ait_maritalstatus", value, nameof (ait_maritalstatus_OptionSetValue));
      }
    }

    public string ait_maritalstatus_Text(IOrganizationService service)
    {
      return this.ait_maritalstatus_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "ait_maritalstatus");
    }

    public string ait_maritalstatus_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.ait_maritalstatus_OptionSetValue.Value);
    }

    [AttributeLogicalName("ait_medicalconditions")]
    public string ait_medicalconditions
    {
      get => this.GetPropertyValue<string>(nameof (ait_medicalconditions));
      set
      {
        this.SetPropertyValue(nameof (ait_medicalconditions), value, 200, nameof (ait_medicalconditions));
      }
    }

    [AttributeLogicalName("ait_memberprofile")]
    public EntityReference ait_memberprofile
    {
      get => this.GetPropertyValue<EntityReference>(nameof (ait_memberprofile));
      set
      {
        this.SetPropertyValue<EntityReference>(nameof (ait_memberprofile), value, nameof (ait_memberprofile));
      }
    }

    [AttributeLogicalName("ait_memberprofilename")]
    public string ait_memberprofilename
    {
      get => this.GetPropertyValue<string>(nameof (ait_memberprofilename));
    }

    [AttributeLogicalName("ait_membershipstatus")]
    public eAit_membershipstatus? ait_membershipstatus
    {
      get
      {
        return this.ait_membershipstatus_OptionSetValue != null ? new eAit_membershipstatus?((eAit_membershipstatus) this.ait_membershipstatus_OptionSetValue.Value) : new eAit_membershipstatus?();
      }
      set
      {
        if (value.HasValue)
          this.ait_membershipstatus_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.ait_membershipstatus_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("ait_membershipstatus")]
    public OptionSetValue ait_membershipstatus_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("ait_membershipstatus");
      set
      {
        this.SetPropertyValue<OptionSetValue>("ait_membershipstatus", value, nameof (ait_membershipstatus_OptionSetValue));
      }
    }

    public string ait_membershipstatus_Text(IOrganizationService service)
    {
      return this.ait_membershipstatus_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "ait_membershipstatus");
    }

    public string ait_membershipstatus_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.ait_membershipstatus_OptionSetValue.Value);
    }

    [AttributeLogicalName("ait_militarystatus")]
    public eAit_militarystatus? ait_militarystatus
    {
      get
      {
        return this.ait_militarystatus_OptionSetValue != null ? new eAit_militarystatus?((eAit_militarystatus) this.ait_militarystatus_OptionSetValue.Value) : new eAit_militarystatus?();
      }
      set
      {
        if (value.HasValue)
          this.ait_militarystatus_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.ait_militarystatus_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("ait_militarystatus")]
    public OptionSetValue ait_militarystatus_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("ait_militarystatus");
      set
      {
        this.SetPropertyValue<OptionSetValue>("ait_militarystatus", value, nameof (ait_militarystatus_OptionSetValue));
      }
    }

    public string ait_militarystatus_Text(IOrganizationService service)
    {
      return this.ait_militarystatus_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "ait_militarystatus");
    }

    public string ait_militarystatus_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.ait_militarystatus_OptionSetValue.Value);
    }

    [AttributeLogicalName("ait_primaryaddress")]
    public string ait_primaryaddress
    {
      get => this.GetPropertyValue<string>(nameof (ait_primaryaddress));
      set
      {
        this.SetPropertyValue(nameof (ait_primaryaddress), value, 2000, nameof (ait_primaryaddress));
      }
    }

    [AttributeLogicalName("ait_primaryemail")]
    public string ait_primaryemail
    {
      get => this.GetPropertyValue<string>(nameof (ait_primaryemail));
      set
      {
        this.SetPropertyValue(nameof (ait_primaryemail), value, 100, nameof (ait_primaryemail));
      }
    }

    [AttributeLogicalName("ait_primarylanguage")]
    public EntityReference ait_primarylanguage
    {
      get => this.GetPropertyValue<EntityReference>(nameof (ait_primarylanguage));
      set
      {
        this.SetPropertyValue<EntityReference>(nameof (ait_primarylanguage), value, nameof (ait_primarylanguage));
      }
    }

    [AttributeLogicalName("ait_primarylanguagename")]
    public string ait_primarylanguagename
    {
      get => this.GetPropertyValue<string>(nameof (ait_primarylanguagename));
    }

    [AttributeLogicalName("ait_primaryphone")]
    public string ait_primaryphone
    {
      get => this.GetPropertyValue<string>(nameof (ait_primaryphone));
      set
      {
        this.SetPropertyValue(nameof (ait_primaryphone), value, 100, nameof (ait_primaryphone));
      }
    }

    [AttributeLogicalName("ait_race")]
    public eAit_race? ait_race
    {
      get
      {
        return this.ait_race_OptionSetValue != null ? new eAit_race?((eAit_race) this.ait_race_OptionSetValue.Value) : new eAit_race?();
      }
      set
      {
        if (value.HasValue)
          this.ait_race_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.ait_race_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("ait_race")]
    public OptionSetValue ait_race_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("ait_race");
      set
      {
        this.SetPropertyValue<OptionSetValue>("ait_race", value, nameof (ait_race_OptionSetValue));
      }
    }

    public string ait_race_Text(IOrganizationService service)
    {
      return this.ait_race_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "ait_race");
    }

    public string ait_race_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.ait_race_OptionSetValue.Value);
    }

    [AttributeLogicalName("ait_registeredwithselectiveservice")]
    public bool? ait_registeredwithselectiveservice
    {
      get => this.GetPropertyValue<bool?>(nameof (ait_registeredwithselectiveservice));
      set
      {
        this.SetPropertyValue<bool?>(nameof (ait_registeredwithselectiveservice), value, nameof (ait_registeredwithselectiveservice));
      }
    }

    [AttributeLogicalName("ait_reservation")]
    public EntityReference ait_reservation
    {
      get => this.GetPropertyValue<EntityReference>(nameof (ait_reservation));
      set
      {
        this.SetPropertyValue<EntityReference>(nameof (ait_reservation), value, nameof (ait_reservation));
      }
    }

    [AttributeLogicalName("ait_reservationname")]
    public string ait_reservationname
    {
      get => this.GetPropertyValue<string>(nameof (ait_reservationname));
    }

    [AttributeLogicalName("ait_sourcesystemid")]
    public string ait_sourcesystemid
    {
      get => this.GetPropertyValue<string>(nameof (ait_sourcesystemid));
      set
      {
        this.SetPropertyValue(nameof (ait_sourcesystemid), value, 200, nameof (ait_sourcesystemid));
      }
    }

    [AttributeLogicalName("ait_ssn")]
    public string ait_ssn
    {
      get => this.GetPropertyValue<string>(nameof (ait_ssn));
      set => this.SetPropertyValue(nameof (ait_ssn), value, 100, nameof (ait_ssn));
    }

    [AttributeLogicalName("ait_ssnlast4")]
    public string ait_ssnlast4
    {
      get => this.GetPropertyValue<string>(nameof (ait_ssnlast4));
      set => this.SetPropertyValue(nameof (ait_ssnlast4), value, 100, nameof (ait_ssnlast4));
    }

    [AttributeLogicalName("ait_totalearnedincome")]
    public Decimal? ait_totalearnedincome
    {
      get
      {
        return this.ait_totalearnedincomeMoney != null ? new Decimal?(this.ait_totalearnedincomeMoney.Value) : new Decimal?();
      }
      set
      {
        if (value.HasValue)
          this.ait_totalearnedincomeMoney = new Money(value.Value);
        else
          this.ait_totalearnedincomeMoney = (Money) null;
      }
    }

    [AttributeLogicalName("ait_totalearnedincome")]
    public Money ait_totalearnedincomeMoney
    {
      get => this.GetPropertyValue<Money>("ait_totalearnedincome");
      set
      {
        this.SetPropertyValue("ait_totalearnedincome", value, -922337203685476M, 922337203685476M, nameof (ait_totalearnedincomeMoney));
      }
    }

    [AttributeLogicalName("ait_totalearnedincome_base")]
    public Decimal? ait_totalearnedincome_base
    {
      get
      {
        return this.ait_totalearnedincome_baseMoney != null ? new Decimal?(this.ait_totalearnedincome_baseMoney.Value) : new Decimal?();
      }
    }

    [AttributeLogicalName("ait_totalearnedincome_base")]
    public Money ait_totalearnedincome_baseMoney
    {
      get => this.GetPropertyValue<Money>("ait_totalearnedincome_base");
    }

    [AttributeLogicalName("ait_totalexpenses")]
    public Decimal? ait_totalexpenses
    {
      get
      {
        return this.ait_totalexpensesMoney != null ? new Decimal?(this.ait_totalexpensesMoney.Value) : new Decimal?();
      }
      set
      {
        if (value.HasValue)
          this.ait_totalexpensesMoney = new Money(value.Value);
        else
          this.ait_totalexpensesMoney = (Money) null;
      }
    }

    [AttributeLogicalName("ait_totalexpenses")]
    public Money ait_totalexpensesMoney
    {
      get => this.GetPropertyValue<Money>("ait_totalexpenses");
      set
      {
        this.SetPropertyValue("ait_totalexpenses", value, -922337203685476M, 922337203685476M, nameof (ait_totalexpensesMoney));
      }
    }

    [AttributeLogicalName("ait_totalexpenses_base")]
    public Decimal? ait_totalexpenses_base
    {
      get
      {
        return this.ait_totalexpenses_baseMoney != null ? new Decimal?(this.ait_totalexpenses_baseMoney.Value) : new Decimal?();
      }
    }

    [AttributeLogicalName("ait_totalexpenses_base")]
    public Money ait_totalexpenses_baseMoney
    {
      get => this.GetPropertyValue<Money>("ait_totalexpenses_base");
    }

    [AttributeLogicalName("ait_totalincome")]
    public Decimal? ait_totalincome
    {
      get
      {
        return this.ait_totalincomeMoney != null ? new Decimal?(this.ait_totalincomeMoney.Value) : new Decimal?();
      }
      set
      {
        if (value.HasValue)
          this.ait_totalincomeMoney = new Money(value.Value);
        else
          this.ait_totalincomeMoney = (Money) null;
      }
    }

    [AttributeLogicalName("ait_totalincome")]
    public Money ait_totalincomeMoney
    {
      get => this.GetPropertyValue<Money>("ait_totalincome");
      set
      {
        this.SetPropertyValue("ait_totalincome", value, -922337203685476M, 922337203685476M, nameof (ait_totalincomeMoney));
      }
    }

    [AttributeLogicalName("ait_totalincome_base")]
    public Decimal? ait_totalincome_base
    {
      get
      {
        return this.ait_totalincome_baseMoney != null ? new Decimal?(this.ait_totalincome_baseMoney.Value) : new Decimal?();
      }
    }

    [AttributeLogicalName("ait_totalincome_base")]
    public Money ait_totalincome_baseMoney => this.GetPropertyValue<Money>("ait_totalincome_base");

    [AttributeLogicalName("ait_totalunearnedincome")]
    public Decimal? ait_totalunearnedincome
    {
      get
      {
        return this.ait_totalunearnedincomeMoney != null ? new Decimal?(this.ait_totalunearnedincomeMoney.Value) : new Decimal?();
      }
      set
      {
        if (value.HasValue)
          this.ait_totalunearnedincomeMoney = new Money(value.Value);
        else
          this.ait_totalunearnedincomeMoney = (Money) null;
      }
    }

    [AttributeLogicalName("ait_totalunearnedincome")]
    public Money ait_totalunearnedincomeMoney
    {
      get => this.GetPropertyValue<Money>("ait_totalunearnedincome");
      set
      {
        this.SetPropertyValue("ait_totalunearnedincome", value, -922337203685476M, 922337203685476M, nameof (ait_totalunearnedincomeMoney));
      }
    }

    [AttributeLogicalName("ait_totalunearnedincome_base")]
    public Decimal? ait_totalunearnedincome_base
    {
      get
      {
        return this.ait_totalunearnedincome_baseMoney != null ? new Decimal?(this.ait_totalunearnedincome_baseMoney.Value) : new Decimal?();
      }
    }

    [AttributeLogicalName("ait_totalunearnedincome_base")]
    public Money ait_totalunearnedincome_baseMoney
    {
      get => this.GetPropertyValue<Money>("ait_totalunearnedincome_base");
    }

    [AttributeLogicalName("ait_tribalid")]
    public string ait_tribalid
    {
      get => this.GetPropertyValue<string>(nameof (ait_tribalid));
      set => this.SetPropertyValue(nameof (ait_tribalid), value, 100, nameof (ait_tribalid));
    }

    [AttributeLogicalName("ait_tribe")]
    public EntityReference ait_tribe
    {
      get => this.GetPropertyValue<EntityReference>(nameof (ait_tribe));
      set => this.SetPropertyValue<EntityReference>(nameof (ait_tribe), value, nameof (ait_tribe));
    }

    [AttributeLogicalName("ait_tribeemployed")]
    public eAit_yesno? ait_tribeemployed
    {
      get
      {
        return this.ait_tribeemployed_OptionSetValue != null ? new eAit_yesno?((eAit_yesno) this.ait_tribeemployed_OptionSetValue.Value) : new eAit_yesno?();
      }
      set
      {
        if (value.HasValue)
          this.ait_tribeemployed_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.ait_tribeemployed_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("ait_tribeemployed")]
    public OptionSetValue ait_tribeemployed_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("ait_tribeemployed");
      set
      {
        this.SetPropertyValue<OptionSetValue>("ait_tribeemployed", value, nameof (ait_tribeemployed_OptionSetValue));
      }
    }

    public string ait_tribeemployed_Text(IOrganizationService service)
    {
      return this.ait_tribeemployed_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "ait_tribeemployed");
    }

    public string ait_tribeemployed_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.ait_tribeemployed_OptionSetValue.Value);
    }

    [AttributeLogicalName("ait_tribename")]
    public string ait_tribename => this.GetPropertyValue<string>(nameof (ait_tribename));

    [AttributeLogicalName("ait_vendornumber")]
    public string ait_vendornumber
    {
      get => this.GetPropertyValue<string>(nameof (ait_vendornumber));
      set
      {
        this.SetPropertyValue(nameof (ait_vendornumber), value, 100, nameof (ait_vendornumber));
      }
    }

    [AttributeLogicalName("ait_weight")]
    public int? ait_weight
    {
      get => this.GetPropertyValue<int?>(nameof (ait_weight));
      set
      {
        this.SetPropertyValue(nameof (ait_weight), value, int.MinValue, int.MaxValue, nameof (ait_weight));
      }
    }

    [AttributeLogicalName("anniversary")]
    public DateTime? anniversary
    {
      get => this.GetPropertyValue<DateTime?>(nameof (anniversary));
      set => this.SetPropertyValue<DateTime?>(nameof (anniversary), value, nameof (anniversary));
    }

    [AttributeLogicalName("annualincome")]
    public Decimal? annualincome
    {
      get
      {
        return this.annualincomeMoney != null ? new Decimal?(this.annualincomeMoney.Value) : new Decimal?();
      }
      set
      {
        if (value.HasValue)
          this.annualincomeMoney = new Money(value.Value);
        else
          this.annualincomeMoney = (Money) null;
      }
    }

    [AttributeLogicalName("annualincome")]
    public Money annualincomeMoney
    {
      get => this.GetPropertyValue<Money>("annualincome");
      set
      {
        this.SetPropertyValue("annualincome", value, 0M, 100000000000000M, nameof (annualincomeMoney));
      }
    }

    [AttributeLogicalName("annualincome_base")]
    public Decimal? annualincome_base
    {
      get
      {
        return this.annualincome_baseMoney != null ? new Decimal?(this.annualincome_baseMoney.Value) : new Decimal?();
      }
    }

    [AttributeLogicalName("annualincome_base")]
    public Money annualincome_baseMoney => this.GetPropertyValue<Money>("annualincome_base");

    [AttributeLogicalName("assistantname")]
    public string assistantname
    {
      get => this.GetPropertyValue<string>(nameof (assistantname));
      set => this.SetPropertyValue(nameof (assistantname), value, 100, nameof (assistantname));
    }

    [AttributeLogicalName("assistantphone")]
    public string assistantphone
    {
      get => this.GetPropertyValue<string>(nameof (assistantphone));
      set => this.SetPropertyValue(nameof (assistantphone), value, 50, nameof (assistantphone));
    }

    [AttributeLogicalName("birthdate")]
    public DateTime? birthdate
    {
      get => this.GetPropertyValue<DateTime?>(nameof (birthdate));
      set => this.SetPropertyValue<DateTime?>(nameof (birthdate), value, nameof (birthdate));
    }

    [AttributeLogicalName("business2")]
    public string business2
    {
      get => this.GetPropertyValue<string>(nameof (business2));
      set => this.SetPropertyValue(nameof (business2), value, 50, nameof (business2));
    }

    [AttributeLogicalName("businesscard")]
    public string businesscard
    {
      get => this.GetPropertyValue<string>(nameof (businesscard));
      set => this.SetPropertyValue(nameof (businesscard), value, 1073741823, nameof (businesscard));
    }

    [AttributeLogicalName("businesscardattributes")]
    public string businesscardattributes
    {
      get => this.GetPropertyValue<string>(nameof (businesscardattributes));
      set
      {
        this.SetPropertyValue(nameof (businesscardattributes), value, 4000, nameof (businesscardattributes));
      }
    }

    [AttributeLogicalName("callback")]
    public string callback
    {
      get => this.GetPropertyValue<string>(nameof (callback));
      set => this.SetPropertyValue(nameof (callback), value, 50, nameof (callback));
    }

    [AttributeLogicalName("childrensnames")]
    public string childrensnames
    {
      get => this.GetPropertyValue<string>(nameof (childrensnames));
      set
      {
        this.SetPropertyValue(nameof (childrensnames), value, (int) byte.MaxValue, nameof (childrensnames));
      }
    }

    [AttributeLogicalName("company")]
    public string company
    {
      get => this.GetPropertyValue<string>(nameof (company));
      set => this.SetPropertyValue(nameof (company), value, 50, nameof (company));
    }

    [AttributeLogicalName("contactid")]
    public Guid contactid
    {
      get => this.Id;
      set
      {
        this.Id = value;
        this.SetPropertyValue<Guid>(nameof (contactid), value, nameof (contactid));
      }
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
    public eContact_customersizecode? customersizecode
    {
      get
      {
        return this.customersizecode_OptionSetValue != null ? new eContact_customersizecode?((eContact_customersizecode) this.customersizecode_OptionSetValue.Value) : new eContact_customersizecode?();
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
    public eContact_customertypecode? customertypecode
    {
      get
      {
        return this.customertypecode_OptionSetValue != null ? new eContact_customertypecode?((eContact_customertypecode) this.customertypecode_OptionSetValue.Value) : new eContact_customertypecode?();
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

    [AttributeLogicalName("department")]
    public string department
    {
      get => this.GetPropertyValue<string>(nameof (department));
      set => this.SetPropertyValue(nameof (department), value, 100, nameof (department));
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

    [AttributeLogicalName("educationcode")]
    public eContact_educationcode? educationcode
    {
      get
      {
        return this.educationcode_OptionSetValue != null ? new eContact_educationcode?((eContact_educationcode) this.educationcode_OptionSetValue.Value) : new eContact_educationcode?();
      }
      set
      {
        if (value.HasValue)
          this.educationcode_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.educationcode_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("educationcode")]
    public OptionSetValue educationcode_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("educationcode");
      set
      {
        this.SetPropertyValue<OptionSetValue>("educationcode", value, nameof (educationcode_OptionSetValue));
      }
    }

    public string educationcode_Text(IOrganizationService service)
    {
      return this.educationcode_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "educationcode");
    }

    public string educationcode_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.educationcode_OptionSetValue.Value);
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

    [AttributeLogicalName("employeeid")]
    public string employeeid
    {
      get => this.GetPropertyValue<string>(nameof (employeeid));
      set => this.SetPropertyValue(nameof (employeeid), value, 50, nameof (employeeid));
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

    [AttributeLogicalName("externaluseridentifier")]
    public string externaluseridentifier
    {
      get => this.GetPropertyValue<string>(nameof (externaluseridentifier));
      set
      {
        this.SetPropertyValue(nameof (externaluseridentifier), value, 50, nameof (externaluseridentifier));
      }
    }

    [AttributeLogicalName("familystatuscode")]
    public eContact_familystatuscode? familystatuscode
    {
      get
      {
        return this.familystatuscode_OptionSetValue != null ? new eContact_familystatuscode?((eContact_familystatuscode) this.familystatuscode_OptionSetValue.Value) : new eContact_familystatuscode?();
      }
      set
      {
        if (value.HasValue)
          this.familystatuscode_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.familystatuscode_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("familystatuscode")]
    public OptionSetValue familystatuscode_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("familystatuscode");
      set
      {
        this.SetPropertyValue<OptionSetValue>("familystatuscode", value, nameof (familystatuscode_OptionSetValue));
      }
    }

    public string familystatuscode_Text(IOrganizationService service)
    {
      return this.familystatuscode_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "familystatuscode");
    }

    public string familystatuscode_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.familystatuscode_OptionSetValue.Value);
    }

    [AttributeLogicalName("fax")]
    public string fax
    {
      get => this.GetPropertyValue<string>(nameof (fax));
      set => this.SetPropertyValue(nameof (fax), value, 50, nameof (fax));
    }

    [AttributeLogicalName("firstname")]
    public string firstname
    {
      get => this.GetPropertyValue<string>(nameof (firstname));
      set => this.SetPropertyValue(nameof (firstname), value, 50, nameof (firstname));
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

    [AttributeLogicalName("fullname")]
    public string fullname => this.GetPropertyValue<string>(nameof (fullname));

    [AttributeLogicalName("gendercode")]
    public eContact_gendercode? gendercode
    {
      get
      {
        return this.gendercode_OptionSetValue != null ? new eContact_gendercode?((eContact_gendercode) this.gendercode_OptionSetValue.Value) : new eContact_gendercode?();
      }
      set
      {
        if (value.HasValue)
          this.gendercode_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.gendercode_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("gendercode")]
    public OptionSetValue gendercode_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("gendercode");
      set
      {
        this.SetPropertyValue<OptionSetValue>("gendercode", value, nameof (gendercode_OptionSetValue));
      }
    }

    public string gendercode_Text(IOrganizationService service)
    {
      return this.gendercode_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "gendercode");
    }

    public string gendercode_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.gendercode_OptionSetValue.Value);
    }

    [AttributeLogicalName("governmentid")]
    public string governmentid
    {
      get => this.GetPropertyValue<string>(nameof (governmentid));
      set => this.SetPropertyValue(nameof (governmentid), value, 50, nameof (governmentid));
    }

    [AttributeLogicalName("haschildrencode")]
    public eContact_haschildrencode? haschildrencode
    {
      get
      {
        return this.haschildrencode_OptionSetValue != null ? new eContact_haschildrencode?((eContact_haschildrencode) this.haschildrencode_OptionSetValue.Value) : new eContact_haschildrencode?();
      }
      set
      {
        if (value.HasValue)
          this.haschildrencode_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.haschildrencode_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("haschildrencode")]
    public OptionSetValue haschildrencode_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("haschildrencode");
      set
      {
        this.SetPropertyValue<OptionSetValue>("haschildrencode", value, nameof (haschildrencode_OptionSetValue));
      }
    }

    public string haschildrencode_Text(IOrganizationService service)
    {
      return this.haschildrencode_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "haschildrencode");
    }

    public string haschildrencode_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.haschildrencode_OptionSetValue.Value);
    }

    [AttributeLogicalName("home2")]
    public string home2
    {
      get => this.GetPropertyValue<string>(nameof (home2));
      set => this.SetPropertyValue(nameof (home2), value, 50, nameof (home2));
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

    [AttributeLogicalName("isautocreate")]
    public bool? isautocreate => this.GetPropertyValue<bool?>(nameof (isautocreate));

    [AttributeLogicalName("isbackofficecustomer")]
    public bool? isbackofficecustomer
    {
      get => this.GetPropertyValue<bool?>(nameof (isbackofficecustomer));
      set
      {
        this.SetPropertyValue<bool?>(nameof (isbackofficecustomer), value, nameof (isbackofficecustomer));
      }
    }

    [AttributeLogicalName("isprivate")]
    public bool? isprivate => this.GetPropertyValue<bool?>(nameof (isprivate));

    [AttributeLogicalName("jobtitle")]
    public string jobtitle
    {
      get => this.GetPropertyValue<string>(nameof (jobtitle));
      set => this.SetPropertyValue(nameof (jobtitle), value, 100, nameof (jobtitle));
    }

    [AttributeLogicalName("lastname")]
    public string lastname
    {
      get => this.GetPropertyValue<string>(nameof (lastname));
      set => this.SetPropertyValue(nameof (lastname), value, 50, nameof (lastname));
    }

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

    [AttributeLogicalName("leadsourcecode")]
    public eContact_leadsourcecode? leadsourcecode
    {
      get
      {
        return this.leadsourcecode_OptionSetValue != null ? new eContact_leadsourcecode?((eContact_leadsourcecode) this.leadsourcecode_OptionSetValue.Value) : new eContact_leadsourcecode?();
      }
      set
      {
        if (value.HasValue)
          this.leadsourcecode_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.leadsourcecode_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("leadsourcecode")]
    public OptionSetValue leadsourcecode_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("leadsourcecode");
      set
      {
        this.SetPropertyValue<OptionSetValue>("leadsourcecode", value, nameof (leadsourcecode_OptionSetValue));
      }
    }

    public string leadsourcecode_Text(IOrganizationService service)
    {
      return this.leadsourcecode_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "leadsourcecode");
    }

    public string leadsourcecode_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.leadsourcecode_OptionSetValue.Value);
    }

    [AttributeLogicalName("managername")]
    public string managername
    {
      get => this.GetPropertyValue<string>(nameof (managername));
      set => this.SetPropertyValue(nameof (managername), value, 100, nameof (managername));
    }

    [AttributeLogicalName("managerphone")]
    public string managerphone
    {
      get => this.GetPropertyValue<string>(nameof (managerphone));
      set => this.SetPropertyValue(nameof (managerphone), value, 50, nameof (managerphone));
    }

    [AttributeLogicalName("marketingonly")]
    public bool? marketingonly
    {
      get => this.GetPropertyValue<bool?>(nameof (marketingonly));
      set => this.SetPropertyValue<bool?>(nameof (marketingonly), value, nameof (marketingonly));
    }

    [AttributeLogicalName("mastercontactidname")]
    public string mastercontactidname
    {
      get => this.GetPropertyValue<string>(nameof (mastercontactidname));
    }

    [AttributeLogicalName("mastercontactidyominame")]
    public string mastercontactidyominame
    {
      get => this.GetPropertyValue<string>(nameof (mastercontactidyominame));
    }

    [AttributeLogicalName("masterid")]
    public EntityReference masterid => this.GetPropertyValue<EntityReference>(nameof (masterid));

    [AttributeLogicalName("merged")]
    public bool? merged => this.GetPropertyValue<bool?>(nameof (merged));

    [AttributeLogicalName("middlename")]
    public string middlename
    {
      get => this.GetPropertyValue<string>(nameof (middlename));
      set => this.SetPropertyValue(nameof (middlename), value, 50, nameof (middlename));
    }

    [AttributeLogicalName("mobilephone")]
    public string mobilephone
    {
      get => this.GetPropertyValue<string>(nameof (mobilephone));
      set => this.SetPropertyValue(nameof (mobilephone), value, 50, nameof (mobilephone));
    }

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

    [AttributeLogicalName("msdyn_gdproptout")]
    public bool? msdyn_gdproptout
    {
      get => this.GetPropertyValue<bool?>(nameof (msdyn_gdproptout));
      set
      {
        this.SetPropertyValue<bool?>(nameof (msdyn_gdproptout), value, nameof (msdyn_gdproptout));
      }
    }

    [AttributeLogicalName("msdyn_orgchangestatus")]
    public eContact_msdyn_orgchangestatus? msdyn_orgchangestatus
    {
      get
      {
        return this.msdyn_orgchangestatus_OptionSetValue != null ? new eContact_msdyn_orgchangestatus?((eContact_msdyn_orgchangestatus) this.msdyn_orgchangestatus_OptionSetValue.Value) : new eContact_msdyn_orgchangestatus?();
      }
      set
      {
        if (value.HasValue)
          this.msdyn_orgchangestatus_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.msdyn_orgchangestatus_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("msdyn_orgchangestatus")]
    public OptionSetValue msdyn_orgchangestatus_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("msdyn_orgchangestatus");
      set
      {
        this.SetPropertyValue<OptionSetValue>("msdyn_orgchangestatus", value, nameof (msdyn_orgchangestatus_OptionSetValue));
      }
    }

    public string msdyn_orgchangestatus_Text(IOrganizationService service)
    {
      return this.msdyn_orgchangestatus_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "msdyn_orgchangestatus");
    }

    public string msdyn_orgchangestatus_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.msdyn_orgchangestatus_OptionSetValue.Value);
    }

    [AttributeLogicalName("nickname")]
    public string nickname
    {
      get => this.GetPropertyValue<string>(nameof (nickname));
      set => this.SetPropertyValue(nameof (nickname), value, 50, nameof (nickname));
    }

    [AttributeLogicalName("numberofchildren")]
    public int? numberofchildren
    {
      get => this.GetPropertyValue<int?>(nameof (numberofchildren));
      set
      {
        this.SetPropertyValue(nameof (numberofchildren), value, 0, 1000000000, nameof (numberofchildren));
      }
    }

    [AttributeLogicalName("onholdtime")]
    public int? onholdtime => this.GetPropertyValue<int?>(nameof (onholdtime));

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

    [AttributeLogicalName("pager")]
    public string pager
    {
      get => this.GetPropertyValue<string>(nameof (pager));
      set => this.SetPropertyValue(nameof (pager), value, 50, nameof (pager));
    }

    [AttributeLogicalName("parentcontactid")]
    public EntityReference parentcontactid
    {
      get => this.GetPropertyValue<EntityReference>(nameof (parentcontactid));
    }

    [AttributeLogicalName("parentcontactidname")]
    public string parentcontactidname
    {
      get => this.GetPropertyValue<string>(nameof (parentcontactidname));
    }

    [AttributeLogicalName("parentcontactidyominame")]
    public string parentcontactidyominame
    {
      get => this.GetPropertyValue<string>(nameof (parentcontactidyominame));
    }

    [AttributeLogicalName("parentcustomerid")]
    public EntityReference parentcustomerid
    {
      get => this.GetPropertyValue<EntityReference>(nameof (parentcustomerid));
      set
      {
        this.SetPropertyValue<EntityReference>(nameof (parentcustomerid), value, nameof (parentcustomerid));
      }
    }

    [AttributeLogicalName("parentcustomeridname")]
    public string parentcustomeridname
    {
      get => this.GetPropertyValue<string>(nameof (parentcustomeridname));
    }

    [AttributeLogicalName("parentcustomeridtype")]
    public string parentcustomeridtype
    {
      get => this.GetPropertyValue<string>(nameof (parentcustomeridtype));
      set
      {
        this.SetPropertyValue<string>(nameof (parentcustomeridtype), value, nameof (parentcustomeridtype));
      }
    }

    [AttributeLogicalName("parentcustomeridyominame")]
    public string parentcustomeridyominame
    {
      get => this.GetPropertyValue<string>(nameof (parentcustomeridyominame));
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
    public eContact_paymenttermscode? paymenttermscode
    {
      get
      {
        return this.paymenttermscode_OptionSetValue != null ? new eContact_paymenttermscode?((eContact_paymenttermscode) this.paymenttermscode_OptionSetValue.Value) : new eContact_paymenttermscode?();
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
    public eContact_preferredappointmentdaycode? preferredappointmentdaycode
    {
      get
      {
        return this.preferredappointmentdaycode_OptionSetValue != null ? new eContact_preferredappointmentdaycode?((eContact_preferredappointmentdaycode) this.preferredappointmentdaycode_OptionSetValue.Value) : new eContact_preferredappointmentdaycode?();
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
    public eContact_preferredappointmenttimecode? preferredappointmenttimecode
    {
      get
      {
        return this.preferredappointmenttimecode_OptionSetValue != null ? new eContact_preferredappointmenttimecode?((eContact_preferredappointmenttimecode) this.preferredappointmenttimecode_OptionSetValue.Value) : new eContact_preferredappointmenttimecode?();
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
    public eContact_preferredcontactmethodcode? preferredcontactmethodcode
    {
      get
      {
        return this.preferredcontactmethodcode_OptionSetValue != null ? new eContact_preferredcontactmethodcode?((eContact_preferredcontactmethodcode) this.preferredcontactmethodcode_OptionSetValue.Value) : new eContact_preferredcontactmethodcode?();
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

    [AttributeLogicalName("processid")]
    public Guid processid
    {
      get => this.GetPropertyValue<Guid>(nameof (processid));
      set => this.SetPropertyValue<Guid>(nameof (processid), value, nameof (processid));
    }

    [AttributeLogicalName("salutation")]
    public string salutation
    {
      get => this.GetPropertyValue<string>(nameof (salutation));
      set => this.SetPropertyValue(nameof (salutation), value, 100, nameof (salutation));
    }

    [AttributeLogicalName("shippingmethodcode")]
    public eContact_shippingmethodcode? shippingmethodcode
    {
      get
      {
        return this.shippingmethodcode_OptionSetValue != null ? new eContact_shippingmethodcode?((eContact_shippingmethodcode) this.shippingmethodcode_OptionSetValue.Value) : new eContact_shippingmethodcode?();
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

    [AttributeLogicalName("spousesname")]
    public string spousesname
    {
      get => this.GetPropertyValue<string>(nameof (spousesname));
      set => this.SetPropertyValue(nameof (spousesname), value, 100, nameof (spousesname));
    }

    [AttributeLogicalName("stageid")]
    public Guid stageid
    {
      get => this.GetPropertyValue<Guid>(nameof (stageid));
      set => this.SetPropertyValue<Guid>(nameof (stageid), value, nameof (stageid));
    }

    [AttributeLogicalName("statecode")]
    public eContact_statecode? statecode
    {
      get
      {
        return this.statecode_OptionSetValue != null ? new eContact_statecode?((eContact_statecode) this.statecode_OptionSetValue.Value) : new eContact_statecode?();
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
    public eContact_statuscode? statuscode
    {
      get
      {
        return this.statuscode_OptionSetValue != null ? new eContact_statuscode?((eContact_statuscode) this.statuscode_OptionSetValue.Value) : new eContact_statuscode?();
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

    [AttributeLogicalName("subscriptionid")]
    public Guid subscriptionid
    {
      get => this.GetPropertyValue<Guid>(nameof (subscriptionid));
      set => this.SetPropertyValue<Guid>(nameof (subscriptionid), value, nameof (subscriptionid));
    }

    [AttributeLogicalName("suffix")]
    public string suffix
    {
      get => this.GetPropertyValue<string>(nameof (suffix));
      set => this.SetPropertyValue(nameof (suffix), value, 10, nameof (suffix));
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
    public eContact_territorycode? territorycode
    {
      get
      {
        return this.territorycode_OptionSetValue != null ? new eContact_territorycode?((eContact_territorycode) this.territorycode_OptionSetValue.Value) : new eContact_territorycode?();
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

    [AttributeLogicalName("yomifirstname")]
    public string yomifirstname
    {
      get => this.GetPropertyValue<string>(nameof (yomifirstname));
      set => this.SetPropertyValue(nameof (yomifirstname), value, 150, nameof (yomifirstname));
    }

    [AttributeLogicalName("yomifullname")]
    public string yomifullname => this.GetPropertyValue<string>(nameof (yomifullname));

    [AttributeLogicalName("yomilastname")]
    public string yomilastname
    {
      get => this.GetPropertyValue<string>(nameof (yomilastname));
      set => this.SetPropertyValue(nameof (yomilastname), value, 150, nameof (yomilastname));
    }

    [AttributeLogicalName("yomimiddlename")]
    public string yomimiddlename
    {
      get => this.GetPropertyValue<string>(nameof (yomimiddlename));
      set => this.SetPropertyValue(nameof (yomimiddlename), value, 150, nameof (yomimiddlename));
    }

    public List<account> Getaccount_primary_contact(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<account>(service, this.Id, "account", "primarycontactid", columns);
    }

    public List<account> Getaccount_primary_contact(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<account>(service, this.Id, "account", "primarycontactid", columns);
    }

    public List<Entity> Getcontact_actioncard(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "actioncard", "regardingobjectid", columns);
    }

    public List<Entity> Getcontact_actioncard(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "actioncard", "regardingobjectid", columns);
    }

    public List<Entity> Getcontact_activity_parties(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "activityparty", "partyid", columns);
    }

    public List<Entity> Getcontact_activity_parties(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "activityparty", "partyid", columns);
    }

    public List<Entity> GetContact_ActivityPointers(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "activitypointer", "regardingobjectid", columns);
    }

    public List<Entity> GetContact_ActivityPointers(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "activitypointer", "regardingobjectid", columns);
    }

    public List<Entity> Getait_contact_ait_birthrecord_Contact(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_birthrecord", "ait_contact", columns);
    }

    public List<Entity> Getait_contact_ait_birthrecord_Contact(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_birthrecord", "ait_contact", columns);
    }

    public List<Entity> Getait_contact_ait_cardhistory_actioncontact(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_cardhistory", "ait_actioncontact", columns);
    }

    public List<Entity> Getait_contact_ait_cardhistory_actioncontact(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_cardhistory", "ait_actioncontact", columns);
    }

    public List<Entity> Getait_ait_committeemember_contact(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_committeemember", "ait_contact", columns);
    }

    public List<Entity> Getait_ait_committeemember_contact(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_committeemember", "ait_contact", columns);
    }

    public List<Entity> Getait_ait_contactcertification_contact(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contactcertification", "ait_contact", columns);
    }

    public List<Entity> Getait_ait_contactcertification_contact(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contactcertification", "ait_contact", columns);
    }

    public List<Entity> Getait_ait_contacteducation_contact(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contacteducation", "ait_contact", columns);
    }

    public List<Entity> Getait_ait_contacteducation_contact(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contacteducation", "ait_contact", columns);
    }

    public List<Entity> Getait_ait_contactemployment_contact(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contactemployment", "ait_contact", columns);
    }

    public List<Entity> Getait_ait_contactemployment_contact(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contactemployment", "ait_contact", columns);
    }

    public List<Entity> Getait_contact_ait_contactimage_contact(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contactimage", "ait_contact", columns);
    }

    public List<Entity> Getait_contact_ait_contactimage_contact(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contactimage", "ait_contact", columns);
    }

    public List<Entity> Getait_ait_contactincarceration_contact(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contactincarceration", "ait_contact", columns);
    }

    public List<Entity> Getait_ait_contactincarceration_contact(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contactincarceration", "ait_contact", columns);
    }

    public List<Entity> Getait_ait_contactincomeandexpense_contact(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contactincomeandexpense", "ait_contact", columns);
    }

    public List<Entity> Getait_ait_contactincomeandexpense_contact(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contactincomeandexpense", "ait_contact", columns);
    }

    public List<Entity> Getait_contact_ait_contactlanguage_Contact(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contactlanguage", "ait_contact", columns);
    }

    public List<Entity> Getait_contact_ait_contactlanguage_Contact(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contactlanguage", "ait_contact", columns);
    }

    public List<Entity> Getait_ait_contactmilitaryservice_contact(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contactmilitaryservice", "ait_contact", columns);
    }

    public List<Entity> Getait_ait_contactmilitaryservice_contact(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contactmilitaryservice", "ait_contact", columns);
    }

    public List<Entity> Getait_ait_contactname_contact(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contactname", "ait_contact", columns);
    }

    public List<Entity> Getait_ait_contactname_contact(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contactname", "ait_contact", columns);
    }

    public List<Entity> Getait_ait_contactskill_contact(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contactskill", "ait_contact", columns);
    }

    public List<Entity> Getait_ait_contactskill_contact(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contactskill", "ait_contact", columns);
    }

    public List<ait_courtprofile> Getait_contact_ait_courtprofile_Contact(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_courtprofile>(service, this.Id, "ait_courtprofile", "ait_contact", columns);
    }

    public List<ait_courtprofile> Getait_contact_ait_courtprofile_Contact(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_courtprofile>(service, this.Id, "ait_courtprofile", "ait_contact", columns);
    }

    public List<Entity> Getait_contact_ait_datamigrationhistory_contact(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_datamigrationhistory", "ait_contact", columns);
    }

    public List<Entity> Getait_contact_ait_datamigrationhistory_contact(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_datamigrationhistory", "ait_contact", columns);
    }

    public List<Entity> Getait_contact_ait_deathrecord_Contact(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_deathrecord", "ait_contact", columns);
    }

    public List<Entity> Getait_contact_ait_deathrecord_Contact(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_deathrecord", "ait_contact", columns);
    }

    public List<Entity> Getait_ait_electronicaddress_contact(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_electronicaddress", "ait_contact", columns);
    }

    public List<Entity> Getait_ait_electronicaddress_contact(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_electronicaddress", "ait_contact", columns);
    }

    public List<Entity> Getait_ait_emergencycontact_contact(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_emergencycontact", "ait_contact", columns);
    }

    public List<Entity> Getait_ait_emergencycontact_contact(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_emergencycontact", "ait_contact", columns);
    }

    public List<Entity> Getait_contact_ait_emergencycontact_EmergencyContact(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_emergencycontact", "ait_emergencycontact", columns);
    }

    public List<Entity> Getait_contact_ait_emergencycontact_EmergencyContact(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_emergencycontact", "ait_emergencycontact", columns);
    }

    public List<Entity> Getcontact_ait_hearings(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_hearing", "regardingobjectid", columns);
    }

    public List<Entity> Getcontact_ait_hearings(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_hearing", "regardingobjectid", columns);
    }

    public List<Entity> Getait_ait_household_contact(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_household", "ait_headofhousehold", columns);
    }

    public List<Entity> Getait_ait_household_contact(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_household", "ait_headofhousehold", columns);
    }

    public List<Entity> Getait_ait_householdmember_contact(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_householdmember", "ait_contact", columns);
    }

    public List<Entity> Getait_ait_householdmember_contact(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_householdmember", "ait_contact", columns);
    }

    public List<Entity> Getait_contact_ait_memberprofile_Contact(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_memberprofile", "ait_contact", columns);
    }

    public List<Entity> Getait_contact_ait_memberprofile_Contact(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_memberprofile", "ait_contact", columns);
    }

    public List<ait_physicaladdress> Getait_ait_physicaladdress_contact(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_physicaladdress>(service, this.Id, "ait_physicaladdress", "ait_contact", columns);
    }

    public List<ait_physicaladdress> Getait_ait_physicaladdress_contact(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_physicaladdress>(service, this.Id, "ait_physicaladdress", "ait_contact", columns);
    }

    public List<Entity> Getait_ait_relationship_contact(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_relationship", "ait_contact", columns);
    }

    public List<Entity> Getait_ait_relationship_contact(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_relationship", "ait_contact", columns);
    }

    public List<Entity> Getait_contact_ait_relationship_RelationshipTo(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_relationship", "ait_relationshipto", columns);
    }

    public List<Entity> Getait_contact_ait_relationship_RelationshipTo(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_relationship", "ait_relationshipto", columns);
    }

    public List<Entity> Getait_ait_training_contact(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_training", "ait_contact", columns);
    }

    public List<Entity> Getait_ait_training_contact(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_training", "ait_contact", columns);
    }

    public List<Entity> GetContact_Annotation(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "annotation", "objectid", columns);
    }

    public List<Entity> GetContact_Annotation(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "annotation", "objectid", columns);
    }

    public List<appointment> GetContact_Appointments(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<appointment>(service, this.Id, "appointment", "regardingobjectid", columns);
    }

    public List<appointment> GetContact_Appointments(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<appointment>(service, this.Id, "appointment", "regardingobjectid", columns);
    }

    public List<Entity> GetContact_AsyncOperations(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "asyncoperation", "regardingobjectid", columns);
    }

    public List<Entity> GetContact_AsyncOperations(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "asyncoperation", "regardingobjectid", columns);
    }

    public List<Entity> Getcontact_bookableresource_ContactId(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bookableresource", "contactid", columns);
    }

    public List<Entity> Getcontact_bookableresource_ContactId(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bookableresource", "contactid", columns);
    }

    public List<Entity> GetContact_BulkDeleteFailures(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bulkdeletefailure", "regardingobjectid", columns);
    }

    public List<Entity> GetContact_BulkDeleteFailures(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bulkdeletefailure", "regardingobjectid", columns);
    }

    public List<Entity> Getcontact_BulkOperations(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bulkoperation", "regardingobjectid", columns);
    }

    public List<Entity> Getcontact_BulkOperations(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bulkoperation", "regardingobjectid", columns);
    }

    public List<Entity> GetCreatedContact_BulkOperationLogs(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bulkoperationlog", "createdobjectid", columns);
    }

    public List<Entity> GetCreatedContact_BulkOperationLogs(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bulkoperationlog", "createdobjectid", columns);
    }

    public List<Entity> GetSourceContact_BulkOperationLogs(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bulkoperationlog", "regardingobjectid", columns);
    }

    public List<Entity> GetSourceContact_BulkOperationLogs(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bulkoperationlog", "regardingobjectid", columns);
    }

    public List<Entity> Getcontact_CampaignResponses(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "campaignresponse", "regardingobjectid", columns);
    }

    public List<Entity> Getcontact_CampaignResponses(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "campaignresponse", "regardingobjectid", columns);
    }

    public List<connection> Getcontact_connections1(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<connection>(service, this.Id, "connection", "record1id", columns);
    }

    public List<connection> Getcontact_connections1(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<connection>(service, this.Id, "connection", "record1id", columns);
    }

    public List<connection> Getcontact_connections2(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<connection>(service, this.Id, "connection", "record2id", columns);
    }

    public List<connection> Getcontact_connections2(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<connection>(service, this.Id, "connection", "record2id", columns);
    }

    public List<contact> Getcontact_customer_contacts(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<contact>(service, this.Id, nameof (contact), "parentcustomerid", columns);
    }

    public List<contact> Getcontact_customer_contacts(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<contact>(service, this.Id, nameof (contact), "parentcustomerid", columns);
    }

    public List<contact> Getcontact_master_contact(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<contact>(service, this.Id, nameof (contact), "masterid", columns);
    }

    public List<contact> Getcontact_master_contact(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<contact>(service, this.Id, nameof (contact), "masterid", columns);
    }

    public List<Entity> Getcontract_billingcustomer_contacts(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "contract", "billingcustomerid", columns);
    }

    public List<Entity> Getcontract_billingcustomer_contacts(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "contract", "billingcustomerid", columns);
    }

    public List<Entity> Getcontract_customer_contacts(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "contract", "customerid", columns);
    }

    public List<Entity> Getcontract_customer_contacts(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "contract", "customerid", columns);
    }

    public List<Entity> Getcontractlineitem_customer_contacts(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "contractdetail", "customerid", columns);
    }

    public List<Entity> Getcontractlineitem_customer_contacts(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "contractdetail", "customerid", columns);
    }

    public List<Entity> GetContact_CustomerAddress(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "customeraddress", "parentid", columns);
    }

    public List<Entity> GetContact_CustomerAddress(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "customeraddress", "parentid", columns);
    }

    public List<Entity> Getcontact_customer_opportunity_roles(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "customeropportunityrole", "customerid", columns);
    }

    public List<Entity> Getcontact_customer_opportunity_roles(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "customeropportunityrole", "customerid", columns);
    }

    public List<Entity> Getcontact_customer_relationship_customer(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "customerrelationship", "customerid", columns);
    }

    public List<Entity> Getcontact_customer_relationship_customer(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "customerrelationship", "customerid", columns);
    }

    public List<Entity> Getcontact_customer_relationship_partner(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "customerrelationship", "partnerid", columns);
    }

    public List<Entity> Getcontact_customer_relationship_partner(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "customerrelationship", "partnerid", columns);
    }

    public List<Entity> GetContact_DuplicateBaseRecord(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "duplicaterecord", "baserecordid", columns);
    }

    public List<Entity> GetContact_DuplicateBaseRecord(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "duplicaterecord", "baserecordid", columns);
    }

    public List<Entity> GetContact_DuplicateMatchingRecord(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "duplicaterecord", "duplicaterecordid", columns);
    }

    public List<Entity> GetContact_DuplicateMatchingRecord(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "duplicaterecord", "duplicaterecordid", columns);
    }

    public List<Entity> GetContact_Email_EmailSender(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "email", "emailsender", columns);
    }

    public List<Entity> GetContact_Email_EmailSender(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "email", "emailsender", columns);
    }

    public List<Entity> GetContact_Emails(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "email", "regardingobjectid", columns);
    }

    public List<Entity> GetContact_Emails(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "email", "regardingobjectid", columns);
    }

    public List<Entity> Getcontact_entitlement_ContactId(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "entitlement", "contactid", columns);
    }

    public List<Entity> Getcontact_entitlement_ContactId(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "entitlement", "contactid", columns);
    }

    public List<Entity> Getcontact_entitlement_Customer(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "entitlement", "customerid", columns);
    }

    public List<Entity> Getcontact_entitlement_Customer(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "entitlement", "customerid", columns);
    }

    public List<Entity> GetContact_ExternalPartyItems(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "externalpartyitem", "regardingobjectid", columns);
    }

    public List<Entity> GetContact_ExternalPartyItems(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "externalpartyitem", "regardingobjectid", columns);
    }

    public List<Entity> GetContact_Faxes(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "fax", "regardingobjectid", columns);
    }

    public List<Entity> GetContact_Faxes(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "fax", "regardingobjectid", columns);
    }

    public List<Entity> GetContact_Feedback(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "feedback", "regardingobjectid", columns);
    }

    public List<Entity> GetContact_Feedback(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "feedback", "regardingobjectid", columns);
    }

    public List<Entity> Getlk_contact_feedback_createdby(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "feedback", "createdbycontact", columns);
    }

    public List<Entity> Getlk_contact_feedback_createdby(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "feedback", "createdbycontact", columns);
    }

    public List<Entity> Getlk_contact_feedback_createdonbehalfby(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "feedback", "createdonbehalfbycontact", columns);
    }

    public List<Entity> Getlk_contact_feedback_createdonbehalfby(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "feedback", "createdonbehalfbycontact", columns);
    }

    public List<Entity> Getcontact_as_primary_contact(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "incident", "primarycontactid", columns);
    }

    public List<Entity> Getcontact_as_primary_contact(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "incident", "primarycontactid", columns);
    }

    public List<Entity> Getcontact_as_responsible_contact(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "incident", "responsiblecontactid", columns);
    }

    public List<Entity> Getcontact_as_responsible_contact(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "incident", "responsiblecontactid", columns);
    }

    public List<Entity> Getincident_customer_contacts(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "incident", "customerid", columns);
    }

    public List<Entity> Getincident_customer_contacts(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "incident", "customerid", columns);
    }

    public List<Entity> Getinvoice_customer_contacts(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "invoice", "customerid", columns);
    }

    public List<Entity> Getinvoice_customer_contacts(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "invoice", "customerid", columns);
    }

    public List<Entity> Getlead_customer_contacts(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "lead", "customerid", columns);
    }

    public List<Entity> Getlead_customer_contacts(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "lead", "customerid", columns);
    }

    public List<Entity> Getlead_parent_contact(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "lead", "parentcontactid", columns);
    }

    public List<Entity> Getlead_parent_contact(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "lead", "parentcontactid", columns);
    }

    public List<Entity> GetContact_Letters(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "letter", "regardingobjectid", columns);
    }

    public List<Entity> GetContact_Letters(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "letter", "regardingobjectid", columns);
    }

    public List<Entity> GetContact_MailboxTrackingFolder(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "mailboxtrackingfolder", "regardingobjectid", columns);
    }

    public List<Entity> GetContact_MailboxTrackingFolder(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "mailboxtrackingfolder", "regardingobjectid", columns);
    }

    public List<Entity> Getmsdyn_playbookinstance_contact(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_playbookinstance", "regarding", columns);
    }

    public List<Entity> Getmsdyn_playbookinstance_contact(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_playbookinstance", "regarding", columns);
    }

    public List<Entity> Getcontact_msfp_surveyinvites(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msfp_surveyinvite", "regardingobjectid", columns);
    }

    public List<Entity> Getcontact_msfp_surveyinvites(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msfp_surveyinvite", "regardingobjectid", columns);
    }

    public List<Entity> Getcontact_msfp_surveyresponses(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msfp_surveyresponse", "regardingobjectid", columns);
    }

    public List<Entity> Getcontact_msfp_surveyresponses(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msfp_surveyresponse", "regardingobjectid", columns);
    }

    public List<Entity> Getopportunity_customer_contacts(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "opportunity", "customerid", columns);
    }

    public List<Entity> Getopportunity_customer_contacts(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "opportunity", "customerid", columns);
    }

    public List<Entity> Getopportunity_parent_contact(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "opportunity", "parentcontactid", columns);
    }

    public List<Entity> Getopportunity_parent_contact(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "opportunity", "parentcontactid", columns);
    }

    public List<Entity> GetContact_Phonecalls(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "phonecall", "regardingobjectid", columns);
    }

    public List<Entity> GetContact_Phonecalls(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "phonecall", "regardingobjectid", columns);
    }

    public List<Entity> Getcontact_PostFollows(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "postfollow", "regardingobjectid", columns);
    }

    public List<Entity> Getcontact_PostFollows(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "postfollow", "regardingobjectid", columns);
    }

    public List<Entity> Getcontact_PostRegardings(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "postregarding", "regardingobjectid", columns);
    }

    public List<Entity> Getcontact_PostRegardings(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "postregarding", "regardingobjectid", columns);
    }

    public List<Entity> Getcontact_PostRoles(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "postrole", "regardingobjectid", columns);
    }

    public List<Entity> Getcontact_PostRoles(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "postrole", "regardingobjectid", columns);
    }

    public List<Entity> Getcontact_principalobjectattributeaccess(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "principalobjectattributeaccess", "objectid", columns);
    }

    public List<Entity> Getcontact_principalobjectattributeaccess(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "principalobjectattributeaccess", "objectid", columns);
    }

    public List<Entity> GetContact_ProcessSessions(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "processsession", "regardingobjectid", columns);
    }

    public List<Entity> GetContact_ProcessSessions(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "processsession", "regardingobjectid", columns);
    }

    public List<Entity> Getquote_customer_contacts(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "quote", "customerid", columns);
    }

    public List<Entity> Getquote_customer_contacts(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "quote", "customerid", columns);
    }

    public List<Entity> GetContact_RecurringAppointmentMasters(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "recurringappointmentmaster", "regardingobjectid", columns);
    }

    public List<Entity> GetContact_RecurringAppointmentMasters(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "recurringappointmentmaster", "regardingobjectid", columns);
    }

    public List<Entity> Getorder_customer_contacts(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "salesorder", "customerid", columns);
    }

    public List<Entity> Getorder_customer_contacts(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "salesorder", "customerid", columns);
    }

    public List<Entity> GetContact_ServiceAppointments(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "serviceappointment", "regardingobjectid", columns);
    }

    public List<Entity> GetContact_ServiceAppointments(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "serviceappointment", "regardingobjectid", columns);
    }

    public List<Entity> Getcontact_SharePointDocuments(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sharepointdocument", "regardingobjectid", columns);
    }

    public List<Entity> Getcontact_SharePointDocuments(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sharepointdocument", "regardingobjectid", columns);
    }

    public List<Entity> Getcontact_SharePointDocumentLocations(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sharepointdocumentlocation", "regardingobjectid", columns);
    }

    public List<Entity> Getcontact_SharePointDocumentLocations(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sharepointdocumentlocation", "regardingobjectid", columns);
    }

    public List<Entity> Getslakpiinstance_contact(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "slakpiinstance", "regarding", columns);
    }

    public List<Entity> Getslakpiinstance_contact(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "slakpiinstance", "regarding", columns);
    }

    public List<Entity> GetContact_SocialActivities(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "socialactivity", "regardingobjectid", columns);
    }

    public List<Entity> GetContact_SocialActivities(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "socialactivity", "regardingobjectid", columns);
    }

    public List<Entity> Getsocialactivity_postauthor_contacts(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "socialactivity", "postauthor", columns);
    }

    public List<Entity> Getsocialactivity_postauthor_contacts(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "socialactivity", "postauthor", columns);
    }

    public List<Entity> Getsocialactivity_postauthoraccount_contacts(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "socialactivity", "postauthoraccount", columns);
    }

    public List<Entity> Getsocialactivity_postauthoraccount_contacts(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "socialactivity", "postauthoraccount", columns);
    }

    public List<Entity> GetSocialprofile_customer_contacts(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "socialprofile", "customerid", columns);
    }

    public List<Entity> GetSocialprofile_customer_contacts(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "socialprofile", "customerid", columns);
    }

    public List<Entity> GetContact_SyncErrors(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "syncerror", "regardingobjectid", columns);
    }

    public List<Entity> GetContact_SyncErrors(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "syncerror", "regardingobjectid", columns);
    }

    public List<Entity> GetContact_Tasks(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "task", "regardingobjectid", columns);
    }

    public List<Entity> GetContact_Tasks(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "task", "regardingobjectid", columns);
    }

    public List<Entity> Getuserentityinstancedata_contact(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userentityinstancedata", "objectid", columns);
    }

    public List<Entity> Getuserentityinstancedata_contact(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userentityinstancedata", "objectid", columns);
    }

    public List<Entity> GetBulkOperation_Contacts(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedManyToManyEntities(service, (BaseProxyClass) this, nameof (contact), "contactid", "bulkoperation", "activityid", "bulkoperationlog", "regardingobjectid", "bulkoperationid", columns);
    }

    public List<Entity> GetBulkOperation_Contacts(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedManyToManyEntities(service, (BaseProxyClass) this, nameof (contact), "contactid", "bulkoperation", "activityid", "bulkoperationlog", "regardingobjectid", "bulkoperationid", columns);
    }

    public void RelateBulkOperation_Contacts(IOrganizationService service, params Entity[] items)
    {
      service.RelateEntities((EntityReference) (BaseProxyClass) this, "BulkOperation_Contacts", items);
    }

    public void RelateBulkOperation_Contacts(
      IOrganizationService service,
      params EntityReference[] items)
    {
      service.RelateEntities((EntityReference) (BaseProxyClass) this, "BulkOperation_Contacts", items);
    }

    public void UnRelateBulkOperation_Contacts(IOrganizationService service, params Entity[] items)
    {
      service.UnRelateEntities((EntityReference) (BaseProxyClass) this, "BulkOperation_Contacts", items);
    }

    public void UnRelateBulkOperation_Contacts(
      IOrganizationService service,
      params EntityReference[] items)
    {
      service.UnRelateEntities((EntityReference) (BaseProxyClass) this, "BulkOperation_Contacts", items);
    }

    public List<Entity> GetCampaignActivity_Contacts(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedManyToManyEntities(service, (BaseProxyClass) this, nameof (contact), "contactid", "campaignactivity", "activityid", "bulkoperationlog", "regardingobjectid", "campaignactivityid", columns);
    }

    public List<Entity> GetCampaignActivity_Contacts(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedManyToManyEntities(service, (BaseProxyClass) this, nameof (contact), "contactid", "campaignactivity", "activityid", "bulkoperationlog", "regardingobjectid", "campaignactivityid", columns);
    }

    public void RelateCampaignActivity_Contacts(IOrganizationService service, params Entity[] items)
    {
      service.RelateEntities((EntityReference) (BaseProxyClass) this, "CampaignActivity_Contacts", items);
    }

    public void RelateCampaignActivity_Contacts(
      IOrganizationService service,
      params EntityReference[] items)
    {
      service.RelateEntities((EntityReference) (BaseProxyClass) this, "CampaignActivity_Contacts", items);
    }

    public void UnRelateCampaignActivity_Contacts(
      IOrganizationService service,
      params Entity[] items)
    {
      service.UnRelateEntities((EntityReference) (BaseProxyClass) this, "CampaignActivity_Contacts", items);
    }

    public void UnRelateCampaignActivity_Contacts(
      IOrganizationService service,
      params EntityReference[] items)
    {
      service.UnRelateEntities((EntityReference) (BaseProxyClass) this, "CampaignActivity_Contacts", items);
    }

    public List<Entity> Getcontactleads_association(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedManyToManyEntities(service, (BaseProxyClass) this, nameof (contact), "contactid", "lead", "leadid", "contactleads", "contactid", "leadid", columns);
    }

    public List<Entity> Getcontactleads_association(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedManyToManyEntities(service, (BaseProxyClass) this, nameof (contact), "contactid", "lead", "leadid", "contactleads", "contactid", "leadid", columns);
    }

    public void Relatecontactleads_association(IOrganizationService service, params Entity[] items)
    {
      service.RelateEntities((EntityReference) (BaseProxyClass) this, "contactleads_association", items);
    }

    public void Relatecontactleads_association(
      IOrganizationService service,
      params EntityReference[] items)
    {
      service.RelateEntities((EntityReference) (BaseProxyClass) this, "contactleads_association", items);
    }

    public void UnRelatecontactleads_association(
      IOrganizationService service,
      params Entity[] items)
    {
      service.UnRelateEntities((EntityReference) (BaseProxyClass) this, "contactleads_association", items);
    }

    public void UnRelatecontactleads_association(
      IOrganizationService service,
      params EntityReference[] items)
    {
      service.UnRelateEntities((EntityReference) (BaseProxyClass) this, "contactleads_association", items);
    }

    public List<Entity> Getentitlementcontacts_association(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedManyToManyEntities(service, (BaseProxyClass) this, nameof (contact), "contactid", "entitlement", "entitlementid", "entitlementcontacts", "contactid", "entitlementid", columns);
    }

    public List<Entity> Getentitlementcontacts_association(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedManyToManyEntities(service, (BaseProxyClass) this, nameof (contact), "contactid", "entitlement", "entitlementid", "entitlementcontacts", "contactid", "entitlementid", columns);
    }

    public void Relateentitlementcontacts_association(
      IOrganizationService service,
      params Entity[] items)
    {
      service.RelateEntities((EntityReference) (BaseProxyClass) this, "entitlementcontacts_association", items);
    }

    public void Relateentitlementcontacts_association(
      IOrganizationService service,
      params EntityReference[] items)
    {
      service.RelateEntities((EntityReference) (BaseProxyClass) this, "entitlementcontacts_association", items);
    }

    public void UnRelateentitlementcontacts_association(
      IOrganizationService service,
      params Entity[] items)
    {
      service.UnRelateEntities((EntityReference) (BaseProxyClass) this, "entitlementcontacts_association", items);
    }

    public void UnRelateentitlementcontacts_association(
      IOrganizationService service,
      params EntityReference[] items)
    {
      service.UnRelateEntities((EntityReference) (BaseProxyClass) this, "entitlementcontacts_association", items);
    }

    public List<Entity> Getservicecontractcontacts_association(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedManyToManyEntities(service, (BaseProxyClass) this, nameof (contact), "contactid", "contract", "contractid", "servicecontractcontacts", "contactid", "contractid", columns);
    }

    public List<Entity> Getservicecontractcontacts_association(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedManyToManyEntities(service, (BaseProxyClass) this, nameof (contact), "contactid", "contract", "contractid", "servicecontractcontacts", "contactid", "contractid", columns);
    }

    public void Relateservicecontractcontacts_association(
      IOrganizationService service,
      params Entity[] items)
    {
      service.RelateEntities((EntityReference) (BaseProxyClass) this, "servicecontractcontacts_association", items);
    }

    public void Relateservicecontractcontacts_association(
      IOrganizationService service,
      params EntityReference[] items)
    {
      service.RelateEntities((EntityReference) (BaseProxyClass) this, "servicecontractcontacts_association", items);
    }

    public void UnRelateservicecontractcontacts_association(
      IOrganizationService service,
      params Entity[] items)
    {
      service.UnRelateEntities((EntityReference) (BaseProxyClass) this, "servicecontractcontacts_association", items);
    }

    public void UnRelateservicecontractcontacts_association(
      IOrganizationService service,
      params EntityReference[] items)
    {
      service.UnRelateEntities((EntityReference) (BaseProxyClass) this, "servicecontractcontacts_association", items);
    }

    public List<Entity> Getcontactinvoices_association(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedManyToManyEntities(service, (BaseProxyClass) this, nameof (contact), "contactid", "invoice", "invoiceid", "contactinvoices", "contactid", "invoiceid", columns);
    }

    public List<Entity> Getcontactinvoices_association(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedManyToManyEntities(service, (BaseProxyClass) this, nameof (contact), "contactid", "invoice", "invoiceid", "contactinvoices", "contactid", "invoiceid", columns);
    }

    public void Relatecontactinvoices_association(
      IOrganizationService service,
      params Entity[] items)
    {
      service.RelateEntities((EntityReference) (BaseProxyClass) this, "contactinvoices_association", items);
    }

    public void Relatecontactinvoices_association(
      IOrganizationService service,
      params EntityReference[] items)
    {
      service.RelateEntities((EntityReference) (BaseProxyClass) this, "contactinvoices_association", items);
    }

    public void UnRelatecontactinvoices_association(
      IOrganizationService service,
      params Entity[] items)
    {
      service.UnRelateEntities((EntityReference) (BaseProxyClass) this, "contactinvoices_association", items);
    }

    public void UnRelatecontactinvoices_association(
      IOrganizationService service,
      params EntityReference[] items)
    {
      service.UnRelateEntities((EntityReference) (BaseProxyClass) this, "contactinvoices_association", items);
    }

    public List<Entity> Getlistcontact_association(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedManyToManyEntities(service, (BaseProxyClass) this, nameof (contact), "contactid", "list", "listid", "listmember", "entityid", "listid", columns);
    }

    public List<Entity> Getlistcontact_association(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedManyToManyEntities(service, (BaseProxyClass) this, nameof (contact), "contactid", "list", "listid", "listmember", "entityid", "listid", columns);
    }

    public void Relatelistcontact_association(IOrganizationService service, params Entity[] items)
    {
      service.RelateEntities((EntityReference) (BaseProxyClass) this, "listcontact_association", items);
    }

    public void Relatelistcontact_association(
      IOrganizationService service,
      params EntityReference[] items)
    {
      service.RelateEntities((EntityReference) (BaseProxyClass) this, "listcontact_association", items);
    }

    public void UnRelatelistcontact_association(IOrganizationService service, params Entity[] items)
    {
      service.UnRelateEntities((EntityReference) (BaseProxyClass) this, "listcontact_association", items);
    }

    public void UnRelatelistcontact_association(
      IOrganizationService service,
      params EntityReference[] items)
    {
      service.UnRelateEntities((EntityReference) (BaseProxyClass) this, "listcontact_association", items);
    }

    public List<Entity> Getcontactquotes_association(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedManyToManyEntities(service, (BaseProxyClass) this, nameof (contact), "contactid", "quote", "quoteid", "contactquotes", "contactid", "quoteid", columns);
    }

    public List<Entity> Getcontactquotes_association(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedManyToManyEntities(service, (BaseProxyClass) this, nameof (contact), "contactid", "quote", "quoteid", "contactquotes", "contactid", "quoteid", columns);
    }

    public void Relatecontactquotes_association(IOrganizationService service, params Entity[] items)
    {
      service.RelateEntities((EntityReference) (BaseProxyClass) this, "contactquotes_association", items);
    }

    public void Relatecontactquotes_association(
      IOrganizationService service,
      params EntityReference[] items)
    {
      service.RelateEntities((EntityReference) (BaseProxyClass) this, "contactquotes_association", items);
    }

    public void UnRelatecontactquotes_association(
      IOrganizationService service,
      params Entity[] items)
    {
      service.UnRelateEntities((EntityReference) (BaseProxyClass) this, "contactquotes_association", items);
    }

    public void UnRelatecontactquotes_association(
      IOrganizationService service,
      params EntityReference[] items)
    {
      service.UnRelateEntities((EntityReference) (BaseProxyClass) this, "contactquotes_association", items);
    }

    public List<Entity> Getcontactorders_association(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedManyToManyEntities(service, (BaseProxyClass) this, nameof (contact), "contactid", "salesorder", "salesorderid", "contactorders", "contactid", "salesorderid", columns);
    }

    public List<Entity> Getcontactorders_association(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedManyToManyEntities(service, (BaseProxyClass) this, nameof (contact), "contactid", "salesorder", "salesorderid", "contactorders", "contactid", "salesorderid", columns);
    }

    public void Relatecontactorders_association(IOrganizationService service, params Entity[] items)
    {
      service.RelateEntities((EntityReference) (BaseProxyClass) this, "contactorders_association", items);
    }

    public void Relatecontactorders_association(
      IOrganizationService service,
      params EntityReference[] items)
    {
      service.RelateEntities((EntityReference) (BaseProxyClass) this, "contactorders_association", items);
    }

    public void UnRelatecontactorders_association(
      IOrganizationService service,
      params Entity[] items)
    {
      service.UnRelateEntities((EntityReference) (BaseProxyClass) this, "contactorders_association", items);
    }

    public void UnRelatecontactorders_association(
      IOrganizationService service,
      params EntityReference[] items)
    {
      service.UnRelateEntities((EntityReference) (BaseProxyClass) this, "contactorders_association", items);
    }

    public List<Entity> Getcontact_subscription_association(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedManyToManyEntities(service, (BaseProxyClass) this, nameof (contact), "contactid", "subscription", "subscriptionid", "subscriptionmanuallytrackedobject", "objectid", "subscriptionid", columns);
    }

    public List<Entity> Getcontact_subscription_association(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedManyToManyEntities(service, (BaseProxyClass) this, nameof (contact), "contactid", "subscription", "subscriptionid", "subscriptionmanuallytrackedobject", "objectid", "subscriptionid", columns);
    }

    public void Relatecontact_subscription_association(
      IOrganizationService service,
      params Entity[] items)
    {
      service.RelateEntities((EntityReference) (BaseProxyClass) this, "contact_subscription_association", items);
    }

    public void Relatecontact_subscription_association(
      IOrganizationService service,
      params EntityReference[] items)
    {
      service.RelateEntities((EntityReference) (BaseProxyClass) this, "contact_subscription_association", items);
    }

    public void UnRelatecontact_subscription_association(
      IOrganizationService service,
      params Entity[] items)
    {
      service.UnRelateEntities((EntityReference) (BaseProxyClass) this, "contact_subscription_association", items);
    }

    public void UnRelatecontact_subscription_association(
      IOrganizationService service,
      params EntityReference[] items)
    {
      service.UnRelateEntities((EntityReference) (BaseProxyClass) this, "contact_subscription_association", items);
    }

    public static class Properties
    {
      public const string accountid = "accountid";
      public const string accountidname = "accountidname";
      public const string accountidyominame = "accountidyominame";
      public const string accountrolecode = "accountrolecode";
      public const string accountrolecodename = "accountrolecodename";
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
      public const string address3_addressid = "address3_addressid";
      public const string address3_addresstypecode = "address3_addresstypecode";
      public const string address3_addresstypecodename = "address3_addresstypecodename";
      public const string address3_city = "address3_city";
      public const string address3_composite = "address3_composite";
      public const string address3_country = "address3_country";
      public const string address3_county = "address3_county";
      public const string address3_fax = "address3_fax";
      public const string address3_freighttermscode = "address3_freighttermscode";
      public const string address3_freighttermscodename = "address3_freighttermscodename";
      public const string address3_latitude = "address3_latitude";
      public const string address3_line1 = "address3_line1";
      public const string address3_line2 = "address3_line2";
      public const string address3_line3 = "address3_line3";
      public const string address3_longitude = "address3_longitude";
      public const string address3_name = "address3_name";
      public const string address3_postalcode = "address3_postalcode";
      public const string address3_postofficebox = "address3_postofficebox";
      public const string address3_primarycontactname = "address3_primarycontactname";
      public const string address3_shippingmethodcode = "address3_shippingmethodcode";
      public const string address3_shippingmethodcodename = "address3_shippingmethodcodename";
      public const string address3_stateorprovince = "address3_stateorprovince";
      public const string address3_telephone1 = "address3_telephone1";
      public const string address3_telephone2 = "address3_telephone2";
      public const string address3_telephone3 = "address3_telephone3";
      public const string address3_upszone = "address3_upszone";
      public const string address3_utcoffset = "address3_utcoffset";
      public const string aging30 = "aging30";
      public const string aging30_base = "aging30_base";
      public const string aging60 = "aging60";
      public const string aging60_base = "aging60_base";
      public const string aging90 = "aging90";
      public const string aging90_base = "aging90_base";
      public const string ait_age = "ait_age";
      public const string ait_agegroup = "ait_agegroup";
      public const string ait_agegroupname = "ait_agegroupname";
      public const string ait_bandid = "ait_bandid";
      public const string ait_bandidname = "ait_bandidname";
      public const string ait_birthrecord = "ait_birthrecord";
      public const string ait_birthrecordname = "ait_birthrecordname";
      public const string ait_certificationidcard = "ait_certificationidcard";
      public const string ait_certificationidcardname = "ait_certificationidcardname";
      public const string ait_currentlyemployed = "ait_currentlyemployed";
      public const string ait_currentlyemployedname = "ait_currentlyemployedname";
      public const string ait_deathdate = "ait_deathdate";
      public const string ait_deathrecord = "ait_deathrecord";
      public const string ait_deathrecordname = "ait_deathrecordname";
      public const string ait_disabled = "ait_disabled";
      public const string ait_disabledname = "ait_disabledname";
      public const string ait_emergencycontact = "ait_emergencycontact";
      public const string ait_emergencycontactname = "ait_emergencycontactname";
      public const string ait_employeeidcard = "ait_employeeidcard";
      public const string ait_employeeidcardname = "ait_employeeidcardname";
      public const string ait_entityimagestring = "ait_entityimagestring";
      public const string ait_ethnicity = "ait_ethnicity";
      public const string ait_ethnicityname = "ait_ethnicityname";
      public const string ait_eyecolor = "ait_eyecolor";
      public const string ait_eyecolorname = "ait_eyecolorname";
      public const string ait_federalcdibid = "ait_federalcdibid";
      public const string ait_federalcdibstatus = "ait_federalcdibstatus";
      public const string ait_federalcdibstatuseffectivedate = "ait_federalcdibstatuseffectivedate";
      public const string ait_federalcdibstatusname = "ait_federalcdibstatusname";
      public const string ait_gender = "ait_gender";
      public const string ait_gendername = "ait_gendername";
      public const string ait_haircolor = "ait_haircolor";
      public const string ait_haircolorname = "ait_haircolorname";
      public const string ait_height = "ait_height";
      public const string ait_heightstring = "ait_heightstring";
      public const string ait_household = "ait_household";
      public const string ait_householdmember = "ait_householdmember";
      public const string ait_householdmembername = "ait_householdmembername";
      public const string ait_householdname = "ait_householdname";
      public const string ait_incarcerated = "ait_incarcerated";
      public const string ait_incarceratedname = "ait_incarceratedname";
      public const string ait_isdeceased = "ait_isdeceased";
      public const string ait_isdeceasedname = "ait_isdeceasedname";
      public const string ait_maritalstatus = "ait_maritalstatus";
      public const string ait_maritalstatusname = "ait_maritalstatusname";
      public const string ait_medicalconditions = "ait_medicalconditions";
      public const string ait_memberprofile = "ait_memberprofile";
      public const string ait_memberprofilename = "ait_memberprofilename";
      public const string ait_membershipstatus = "ait_membershipstatus";
      public const string ait_membershipstatusname = "ait_membershipstatusname";
      public const string ait_militarystatus = "ait_militarystatus";
      public const string ait_militarystatusname = "ait_militarystatusname";
      public const string ait_primaryaddress = "ait_primaryaddress";
      public const string ait_primaryemail = "ait_primaryemail";
      public const string ait_primarylanguage = "ait_primarylanguage";
      public const string ait_primarylanguagename = "ait_primarylanguagename";
      public const string ait_primaryphone = "ait_primaryphone";
      public const string ait_race = "ait_race";
      public const string ait_racename = "ait_racename";
      public const string ait_registeredwithselectiveservice = "ait_registeredwithselectiveservice";
      public const string ait_registeredwithselectiveservicename = "ait_registeredwithselectiveservicename";
      public const string ait_reservation = "ait_reservation";
      public const string ait_reservationname = "ait_reservationname";
      public const string ait_sourcesystemid = "ait_sourcesystemid";
      public const string ait_ssn = "ait_ssn";
      public const string ait_ssnlast4 = "ait_ssnlast4";
      public const string ait_totalearnedincome = "ait_totalearnedincome";
      public const string ait_totalearnedincome_base = "ait_totalearnedincome_base";
      public const string ait_totalexpenses = "ait_totalexpenses";
      public const string ait_totalexpenses_base = "ait_totalexpenses_base";
      public const string ait_totalincome = "ait_totalincome";
      public const string ait_totalincome_base = "ait_totalincome_base";
      public const string ait_totalunearnedincome = "ait_totalunearnedincome";
      public const string ait_totalunearnedincome_base = "ait_totalunearnedincome_base";
      public const string ait_tribalid = "ait_tribalid";
      public const string ait_tribe = "ait_tribe";
      public const string ait_tribeemployed = "ait_tribeemployed";
      public const string ait_tribeemployedname = "ait_tribeemployedname";
      public const string ait_tribename = "ait_tribename";
      public const string ait_vendornumber = "ait_vendornumber";
      public const string ait_weight = "ait_weight";
      public const string anniversary = "anniversary";
      public const string annualincome = "annualincome";
      public const string annualincome_base = "annualincome_base";
      public const string assistantname = "assistantname";
      public const string assistantphone = "assistantphone";
      public const string birthdate = "birthdate";
      public const string business2 = "business2";
      public const string businesscard = "businesscard";
      public const string businesscardattributes = "businesscardattributes";
      public const string callback = "callback";
      public const string childrensnames = "childrensnames";
      public const string company = "company";
      public const string contactid = "contactid";
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
      public const string department = "department";
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
      public const string educationcode = "educationcode";
      public const string educationcodename = "educationcodename";
      public const string emailaddress1 = "emailaddress1";
      public const string emailaddress2 = "emailaddress2";
      public const string emailaddress3 = "emailaddress3";
      public const string employeeid = "employeeid";
      public const string entityimage = "entityimage";
      public const string entityimage_timestamp = "entityimage_timestamp";
      public const string entityimage_url = "entityimage_url";
      public const string entityimageid = "entityimageid";
      public const string exchangerate = "exchangerate";
      public const string externaluseridentifier = "externaluseridentifier";
      public const string familystatuscode = "familystatuscode";
      public const string familystatuscodename = "familystatuscodename";
      public const string fax = "fax";
      public const string firstname = "firstname";
      public const string followemail = "followemail";
      public const string followemailname = "followemailname";
      public const string ftpsiteurl = "ftpsiteurl";
      public const string fullname = "fullname";
      public const string gendercode = "gendercode";
      public const string gendercodename = "gendercodename";
      public const string governmentid = "governmentid";
      public const string haschildrencode = "haschildrencode";
      public const string haschildrencodename = "haschildrencodename";
      public const string home2 = "home2";
      public const string importsequencenumber = "importsequencenumber";
      public const string isautocreate = "isautocreate";
      public const string isbackofficecustomer = "isbackofficecustomer";
      public const string isbackofficecustomername = "isbackofficecustomername";
      public const string isprivate = "isprivate";
      public const string isprivatename = "isprivatename";
      public const string jobtitle = "jobtitle";
      public const string lastname = "lastname";
      public const string lastonholdtime = "lastonholdtime";
      public const string lastusedincampaign = "lastusedincampaign";
      public const string leadsourcecode = "leadsourcecode";
      public const string leadsourcecodename = "leadsourcecodename";
      public const string managername = "managername";
      public const string managerphone = "managerphone";
      public const string marketingonly = "marketingonly";
      public const string marketingonlyname = "marketingonlyname";
      public const string mastercontactidname = "mastercontactidname";
      public const string mastercontactidyominame = "mastercontactidyominame";
      public const string masterid = "masterid";
      public const string merged = "merged";
      public const string mergedname = "mergedname";
      public const string middlename = "middlename";
      public const string mobilephone = "mobilephone";
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
      public const string msdyn_gdproptout = "msdyn_gdproptout";
      public const string msdyn_gdproptoutname = "msdyn_gdproptoutname";
      public const string msdyn_orgchangestatus = "msdyn_orgchangestatus";
      public const string msdyn_orgchangestatusname = "msdyn_orgchangestatusname";
      public const string nickname = "nickname";
      public const string numberofchildren = "numberofchildren";
      public const string onholdtime = "onholdtime";
      public const string originatingleadid = "originatingleadid";
      public const string originatingleadidname = "originatingleadidname";
      public const string originatingleadidyominame = "originatingleadidyominame";
      public const string overriddencreatedon = "overriddencreatedon";
      public const string ownerid = "ownerid";
      public const string owneridname = "owneridname";
      public const string owneridtype = "owneridtype";
      public const string owneridyominame = "owneridyominame";
      public const string owningbusinessunit = "owningbusinessunit";
      public const string owningteam = "owningteam";
      public const string owninguser = "owninguser";
      public const string pager = "pager";
      public const string parentcontactid = "parentcontactid";
      public const string parentcontactidname = "parentcontactidname";
      public const string parentcontactidyominame = "parentcontactidyominame";
      public const string parentcustomerid = "parentcustomerid";
      public const string parentcustomeridname = "parentcustomeridname";
      public const string parentcustomeridtype = "parentcustomeridtype";
      public const string parentcustomeridyominame = "parentcustomeridyominame";
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
      public const string processid = "processid";
      public const string salutation = "salutation";
      public const string shippingmethodcode = "shippingmethodcode";
      public const string shippingmethodcodename = "shippingmethodcodename";
      public const string slaid = "slaid";
      public const string slainvokedid = "slainvokedid";
      public const string slainvokedidname = "slainvokedidname";
      public const string slaname = "slaname";
      public const string spousesname = "spousesname";
      public const string stageid = "stageid";
      public const string statecode = "statecode";
      public const string statecodename = "statecodename";
      public const string statuscode = "statuscode";
      public const string statuscodename = "statuscodename";
      public const string subscriptionid = "subscriptionid";
      public const string suffix = "suffix";
      public const string teamsfollowed = "teamsfollowed";
      public const string telephone1 = "telephone1";
      public const string telephone2 = "telephone2";
      public const string telephone3 = "telephone3";
      public const string territorycode = "territorycode";
      public const string territorycodename = "territorycodename";
      public const string timespentbymeonemailandmeetings = "timespentbymeonemailandmeetings";
      public const string timezoneruleversionnumber = "timezoneruleversionnumber";
      public const string transactioncurrencyid = "transactioncurrencyid";
      public const string transactioncurrencyidname = "transactioncurrencyidname";
      public const string traversedpath = "traversedpath";
      public const string utcconversiontimezonecode = "utcconversiontimezonecode";
      public const string versionnumber = "versionnumber";
      public const string websiteurl = "websiteurl";
      public const string yomifirstname = "yomifirstname";
      public const string yomifullname = "yomifullname";
      public const string yomilastname = "yomilastname";
      public const string yomimiddlename = "yomimiddlename";
    }
  }
}
