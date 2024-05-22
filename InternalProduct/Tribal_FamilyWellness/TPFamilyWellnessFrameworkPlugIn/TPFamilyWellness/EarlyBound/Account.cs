// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EarlyBound.Account
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("account")]
  [GeneratedCode("CrmSvcUtil", "9.0.0.9154")]
  public class Account : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "account";
    public const int EntityTypeCode = 1;

    public Account()
      : base("account")
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

    [AttributeLogicalName("accountcategorycode")]
    public OptionSetValue AccountCategoryCode
    {
      get => this.GetAttributeValue<OptionSetValue>("accountcategorycode");
      set
      {
        this.OnPropertyChanging(nameof (AccountCategoryCode));
        this.SetAttributeValue("accountcategorycode", (object) value);
        this.OnPropertyChanged(nameof (AccountCategoryCode));
      }
    }

    [AttributeLogicalName("accountcategorycodename")]
    public object AccountCategoryCodeName
    {
      get => this.GetAttributeValue<object>("accountcategorycodename");
    }

    [AttributeLogicalName("accountclassificationcode")]
    public OptionSetValue AccountClassificationCode
    {
      get => this.GetAttributeValue<OptionSetValue>("accountclassificationcode");
      set
      {
        this.OnPropertyChanging(nameof (AccountClassificationCode));
        this.SetAttributeValue("accountclassificationcode", (object) value);
        this.OnPropertyChanged(nameof (AccountClassificationCode));
      }
    }

    [AttributeLogicalName("accountclassificationcodename")]
    public object AccountClassificationCodeName
    {
      get => this.GetAttributeValue<object>("accountclassificationcodename");
    }

    [AttributeLogicalName("accountid")]
    public Guid? AccountId
    {
      get => this.GetAttributeValue<Guid?>("accountid");
      set
      {
        this.OnPropertyChanging(nameof (AccountId));
        this.SetAttributeValue("accountid", (object) value);
        this.OnPropertyChanged(nameof (AccountId));
      }
    }

    [AttributeLogicalName("accountnumber")]
    public string AccountNumber
    {
      get => this.GetAttributeValue<string>("accountnumber");
      set
      {
        this.OnPropertyChanging(nameof (AccountNumber));
        this.SetAttributeValue("accountnumber", (object) value);
        this.OnPropertyChanged(nameof (AccountNumber));
      }
    }

    [AttributeLogicalName("accountratingcode")]
    public OptionSetValue AccountRatingCode
    {
      get => this.GetAttributeValue<OptionSetValue>("accountratingcode");
      set
      {
        this.OnPropertyChanging(nameof (AccountRatingCode));
        this.SetAttributeValue("accountratingcode", (object) value);
        this.OnPropertyChanged(nameof (AccountRatingCode));
      }
    }

    [AttributeLogicalName("accountratingcodename")]
    public object AccountRatingCodeName => this.GetAttributeValue<object>("accountratingcodename");

    [AttributeLogicalName("address1_addressid")]
    public Guid? Address1_AddressId
    {
      get => this.GetAttributeValue<Guid?>("address1_addressid");
      set
      {
        this.OnPropertyChanging(nameof (Address1_AddressId));
        this.SetAttributeValue("address1_addressid", (object) value);
        this.OnPropertyChanged(nameof (Address1_AddressId));
      }
    }

    [AttributeLogicalName("address1_addresstypecode")]
    public OptionSetValue Address1_AddressTypeCode
    {
      get => this.GetAttributeValue<OptionSetValue>("address1_addresstypecode");
      set
      {
        this.OnPropertyChanging(nameof (Address1_AddressTypeCode));
        this.SetAttributeValue("address1_addresstypecode", (object) value);
        this.OnPropertyChanged(nameof (Address1_AddressTypeCode));
      }
    }

    [AttributeLogicalName("address1_addresstypecodename")]
    public object Address1_AddressTypeCodeName
    {
      get => this.GetAttributeValue<object>("address1_addresstypecodename");
    }

    [AttributeLogicalName("address1_city")]
    public string Address1_City
    {
      get => this.GetAttributeValue<string>("address1_city");
      set
      {
        this.OnPropertyChanging(nameof (Address1_City));
        this.SetAttributeValue("address1_city", (object) value);
        this.OnPropertyChanged(nameof (Address1_City));
      }
    }

    [AttributeLogicalName("address1_composite")]
    public string Address1_Composite => this.GetAttributeValue<string>("address1_composite");

    [AttributeLogicalName("address1_country")]
    public string Address1_Country
    {
      get => this.GetAttributeValue<string>("address1_country");
      set
      {
        this.OnPropertyChanging(nameof (Address1_Country));
        this.SetAttributeValue("address1_country", (object) value);
        this.OnPropertyChanged(nameof (Address1_Country));
      }
    }

    [AttributeLogicalName("address1_county")]
    public string Address1_County
    {
      get => this.GetAttributeValue<string>("address1_county");
      set
      {
        this.OnPropertyChanging(nameof (Address1_County));
        this.SetAttributeValue("address1_county", (object) value);
        this.OnPropertyChanged(nameof (Address1_County));
      }
    }

    [AttributeLogicalName("address1_fax")]
    public string Address1_Fax
    {
      get => this.GetAttributeValue<string>("address1_fax");
      set
      {
        this.OnPropertyChanging(nameof (Address1_Fax));
        this.SetAttributeValue("address1_fax", (object) value);
        this.OnPropertyChanged(nameof (Address1_Fax));
      }
    }

    [AttributeLogicalName("address1_freighttermscode")]
    public OptionSetValue Address1_FreightTermsCode
    {
      get => this.GetAttributeValue<OptionSetValue>("address1_freighttermscode");
      set
      {
        this.OnPropertyChanging(nameof (Address1_FreightTermsCode));
        this.SetAttributeValue("address1_freighttermscode", (object) value);
        this.OnPropertyChanged(nameof (Address1_FreightTermsCode));
      }
    }

    [AttributeLogicalName("address1_freighttermscodename")]
    public object Address1_FreightTermsCodeName
    {
      get => this.GetAttributeValue<object>("address1_freighttermscodename");
    }

    [AttributeLogicalName("address1_latitude")]
    public double? Address1_Latitude
    {
      get => this.GetAttributeValue<double?>("address1_latitude");
      set
      {
        this.OnPropertyChanging(nameof (Address1_Latitude));
        this.SetAttributeValue("address1_latitude", (object) value);
        this.OnPropertyChanged(nameof (Address1_Latitude));
      }
    }

    [AttributeLogicalName("address1_line1")]
    public string Address1_Line1
    {
      get => this.GetAttributeValue<string>("address1_line1");
      set
      {
        this.OnPropertyChanging(nameof (Address1_Line1));
        this.SetAttributeValue("address1_line1", (object) value);
        this.OnPropertyChanged(nameof (Address1_Line1));
      }
    }

    [AttributeLogicalName("address1_line2")]
    public string Address1_Line2
    {
      get => this.GetAttributeValue<string>("address1_line2");
      set
      {
        this.OnPropertyChanging(nameof (Address1_Line2));
        this.SetAttributeValue("address1_line2", (object) value);
        this.OnPropertyChanged(nameof (Address1_Line2));
      }
    }

    [AttributeLogicalName("address1_line3")]
    public string Address1_Line3
    {
      get => this.GetAttributeValue<string>("address1_line3");
      set
      {
        this.OnPropertyChanging(nameof (Address1_Line3));
        this.SetAttributeValue("address1_line3", (object) value);
        this.OnPropertyChanged(nameof (Address1_Line3));
      }
    }

    [AttributeLogicalName("address1_longitude")]
    public double? Address1_Longitude
    {
      get => this.GetAttributeValue<double?>("address1_longitude");
      set
      {
        this.OnPropertyChanging(nameof (Address1_Longitude));
        this.SetAttributeValue("address1_longitude", (object) value);
        this.OnPropertyChanged(nameof (Address1_Longitude));
      }
    }

    [AttributeLogicalName("address1_name")]
    public string Address1_Name
    {
      get => this.GetAttributeValue<string>("address1_name");
      set
      {
        this.OnPropertyChanging(nameof (Address1_Name));
        this.SetAttributeValue("address1_name", (object) value);
        this.OnPropertyChanged(nameof (Address1_Name));
      }
    }

    [AttributeLogicalName("address1_postalcode")]
    public string Address1_PostalCode
    {
      get => this.GetAttributeValue<string>("address1_postalcode");
      set
      {
        this.OnPropertyChanging(nameof (Address1_PostalCode));
        this.SetAttributeValue("address1_postalcode", (object) value);
        this.OnPropertyChanged(nameof (Address1_PostalCode));
      }
    }

    [AttributeLogicalName("address1_postofficebox")]
    public string Address1_PostOfficeBox
    {
      get => this.GetAttributeValue<string>("address1_postofficebox");
      set
      {
        this.OnPropertyChanging(nameof (Address1_PostOfficeBox));
        this.SetAttributeValue("address1_postofficebox", (object) value);
        this.OnPropertyChanged(nameof (Address1_PostOfficeBox));
      }
    }

    [AttributeLogicalName("address1_primarycontactname")]
    public string Address1_PrimaryContactName
    {
      get => this.GetAttributeValue<string>("address1_primarycontactname");
      set
      {
        this.OnPropertyChanging(nameof (Address1_PrimaryContactName));
        this.SetAttributeValue("address1_primarycontactname", (object) value);
        this.OnPropertyChanged(nameof (Address1_PrimaryContactName));
      }
    }

    [AttributeLogicalName("address1_shippingmethodcode")]
    public OptionSetValue Address1_ShippingMethodCode
    {
      get => this.GetAttributeValue<OptionSetValue>("address1_shippingmethodcode");
      set
      {
        this.OnPropertyChanging(nameof (Address1_ShippingMethodCode));
        this.SetAttributeValue("address1_shippingmethodcode", (object) value);
        this.OnPropertyChanged(nameof (Address1_ShippingMethodCode));
      }
    }

    [AttributeLogicalName("address1_shippingmethodcodename")]
    public object Address1_ShippingMethodCodeName
    {
      get => this.GetAttributeValue<object>("address1_shippingmethodcodename");
    }

    [AttributeLogicalName("address1_stateorprovince")]
    public string Address1_StateOrProvince
    {
      get => this.GetAttributeValue<string>("address1_stateorprovince");
      set
      {
        this.OnPropertyChanging(nameof (Address1_StateOrProvince));
        this.SetAttributeValue("address1_stateorprovince", (object) value);
        this.OnPropertyChanged(nameof (Address1_StateOrProvince));
      }
    }

    [AttributeLogicalName("address1_telephone1")]
    public string Address1_Telephone1
    {
      get => this.GetAttributeValue<string>("address1_telephone1");
      set
      {
        this.OnPropertyChanging(nameof (Address1_Telephone1));
        this.SetAttributeValue("address1_telephone1", (object) value);
        this.OnPropertyChanged(nameof (Address1_Telephone1));
      }
    }

    [AttributeLogicalName("address1_telephone2")]
    public string Address1_Telephone2
    {
      get => this.GetAttributeValue<string>("address1_telephone2");
      set
      {
        this.OnPropertyChanging(nameof (Address1_Telephone2));
        this.SetAttributeValue("address1_telephone2", (object) value);
        this.OnPropertyChanged(nameof (Address1_Telephone2));
      }
    }

    [AttributeLogicalName("address1_telephone3")]
    public string Address1_Telephone3
    {
      get => this.GetAttributeValue<string>("address1_telephone3");
      set
      {
        this.OnPropertyChanging(nameof (Address1_Telephone3));
        this.SetAttributeValue("address1_telephone3", (object) value);
        this.OnPropertyChanged(nameof (Address1_Telephone3));
      }
    }

    [AttributeLogicalName("address1_upszone")]
    public string Address1_UPSZone
    {
      get => this.GetAttributeValue<string>("address1_upszone");
      set
      {
        this.OnPropertyChanging(nameof (Address1_UPSZone));
        this.SetAttributeValue("address1_upszone", (object) value);
        this.OnPropertyChanged(nameof (Address1_UPSZone));
      }
    }

    [AttributeLogicalName("address1_utcoffset")]
    public int? Address1_UTCOffset
    {
      get => this.GetAttributeValue<int?>("address1_utcoffset");
      set
      {
        this.OnPropertyChanging(nameof (Address1_UTCOffset));
        this.SetAttributeValue("address1_utcoffset", (object) value);
        this.OnPropertyChanged(nameof (Address1_UTCOffset));
      }
    }

    [AttributeLogicalName("address2_addressid")]
    public Guid? Address2_AddressId
    {
      get => this.GetAttributeValue<Guid?>("address2_addressid");
      set
      {
        this.OnPropertyChanging(nameof (Address2_AddressId));
        this.SetAttributeValue("address2_addressid", (object) value);
        this.OnPropertyChanged(nameof (Address2_AddressId));
      }
    }

    [AttributeLogicalName("address2_addresstypecode")]
    public OptionSetValue Address2_AddressTypeCode
    {
      get => this.GetAttributeValue<OptionSetValue>("address2_addresstypecode");
      set
      {
        this.OnPropertyChanging(nameof (Address2_AddressTypeCode));
        this.SetAttributeValue("address2_addresstypecode", (object) value);
        this.OnPropertyChanged(nameof (Address2_AddressTypeCode));
      }
    }

    [AttributeLogicalName("address2_addresstypecodename")]
    public object Address2_AddressTypeCodeName
    {
      get => this.GetAttributeValue<object>("address2_addresstypecodename");
    }

    [AttributeLogicalName("address2_city")]
    public string Address2_City
    {
      get => this.GetAttributeValue<string>("address2_city");
      set
      {
        this.OnPropertyChanging(nameof (Address2_City));
        this.SetAttributeValue("address2_city", (object) value);
        this.OnPropertyChanged(nameof (Address2_City));
      }
    }

    [AttributeLogicalName("address2_composite")]
    public string Address2_Composite => this.GetAttributeValue<string>("address2_composite");

    [AttributeLogicalName("address2_country")]
    public string Address2_Country
    {
      get => this.GetAttributeValue<string>("address2_country");
      set
      {
        this.OnPropertyChanging(nameof (Address2_Country));
        this.SetAttributeValue("address2_country", (object) value);
        this.OnPropertyChanged(nameof (Address2_Country));
      }
    }

    [AttributeLogicalName("address2_county")]
    public string Address2_County
    {
      get => this.GetAttributeValue<string>("address2_county");
      set
      {
        this.OnPropertyChanging(nameof (Address2_County));
        this.SetAttributeValue("address2_county", (object) value);
        this.OnPropertyChanged(nameof (Address2_County));
      }
    }

    [AttributeLogicalName("address2_fax")]
    public string Address2_Fax
    {
      get => this.GetAttributeValue<string>("address2_fax");
      set
      {
        this.OnPropertyChanging(nameof (Address2_Fax));
        this.SetAttributeValue("address2_fax", (object) value);
        this.OnPropertyChanged(nameof (Address2_Fax));
      }
    }

    [AttributeLogicalName("address2_freighttermscode")]
    public OptionSetValue Address2_FreightTermsCode
    {
      get => this.GetAttributeValue<OptionSetValue>("address2_freighttermscode");
      set
      {
        this.OnPropertyChanging(nameof (Address2_FreightTermsCode));
        this.SetAttributeValue("address2_freighttermscode", (object) value);
        this.OnPropertyChanged(nameof (Address2_FreightTermsCode));
      }
    }

    [AttributeLogicalName("address2_freighttermscodename")]
    public object Address2_FreightTermsCodeName
    {
      get => this.GetAttributeValue<object>("address2_freighttermscodename");
    }

    [AttributeLogicalName("address2_latitude")]
    public double? Address2_Latitude
    {
      get => this.GetAttributeValue<double?>("address2_latitude");
      set
      {
        this.OnPropertyChanging(nameof (Address2_Latitude));
        this.SetAttributeValue("address2_latitude", (object) value);
        this.OnPropertyChanged(nameof (Address2_Latitude));
      }
    }

    [AttributeLogicalName("address2_line1")]
    public string Address2_Line1
    {
      get => this.GetAttributeValue<string>("address2_line1");
      set
      {
        this.OnPropertyChanging(nameof (Address2_Line1));
        this.SetAttributeValue("address2_line1", (object) value);
        this.OnPropertyChanged(nameof (Address2_Line1));
      }
    }

    [AttributeLogicalName("address2_line2")]
    public string Address2_Line2
    {
      get => this.GetAttributeValue<string>("address2_line2");
      set
      {
        this.OnPropertyChanging(nameof (Address2_Line2));
        this.SetAttributeValue("address2_line2", (object) value);
        this.OnPropertyChanged(nameof (Address2_Line2));
      }
    }

    [AttributeLogicalName("address2_line3")]
    public string Address2_Line3
    {
      get => this.GetAttributeValue<string>("address2_line3");
      set
      {
        this.OnPropertyChanging(nameof (Address2_Line3));
        this.SetAttributeValue("address2_line3", (object) value);
        this.OnPropertyChanged(nameof (Address2_Line3));
      }
    }

    [AttributeLogicalName("address2_longitude")]
    public double? Address2_Longitude
    {
      get => this.GetAttributeValue<double?>("address2_longitude");
      set
      {
        this.OnPropertyChanging(nameof (Address2_Longitude));
        this.SetAttributeValue("address2_longitude", (object) value);
        this.OnPropertyChanged(nameof (Address2_Longitude));
      }
    }

    [AttributeLogicalName("address2_name")]
    public string Address2_Name
    {
      get => this.GetAttributeValue<string>("address2_name");
      set
      {
        this.OnPropertyChanging(nameof (Address2_Name));
        this.SetAttributeValue("address2_name", (object) value);
        this.OnPropertyChanged(nameof (Address2_Name));
      }
    }

    [AttributeLogicalName("address2_postalcode")]
    public string Address2_PostalCode
    {
      get => this.GetAttributeValue<string>("address2_postalcode");
      set
      {
        this.OnPropertyChanging(nameof (Address2_PostalCode));
        this.SetAttributeValue("address2_postalcode", (object) value);
        this.OnPropertyChanged(nameof (Address2_PostalCode));
      }
    }

    [AttributeLogicalName("address2_postofficebox")]
    public string Address2_PostOfficeBox
    {
      get => this.GetAttributeValue<string>("address2_postofficebox");
      set
      {
        this.OnPropertyChanging(nameof (Address2_PostOfficeBox));
        this.SetAttributeValue("address2_postofficebox", (object) value);
        this.OnPropertyChanged(nameof (Address2_PostOfficeBox));
      }
    }

    [AttributeLogicalName("address2_primarycontactname")]
    public string Address2_PrimaryContactName
    {
      get => this.GetAttributeValue<string>("address2_primarycontactname");
      set
      {
        this.OnPropertyChanging(nameof (Address2_PrimaryContactName));
        this.SetAttributeValue("address2_primarycontactname", (object) value);
        this.OnPropertyChanged(nameof (Address2_PrimaryContactName));
      }
    }

    [AttributeLogicalName("address2_shippingmethodcode")]
    public OptionSetValue Address2_ShippingMethodCode
    {
      get => this.GetAttributeValue<OptionSetValue>("address2_shippingmethodcode");
      set
      {
        this.OnPropertyChanging(nameof (Address2_ShippingMethodCode));
        this.SetAttributeValue("address2_shippingmethodcode", (object) value);
        this.OnPropertyChanged(nameof (Address2_ShippingMethodCode));
      }
    }

    [AttributeLogicalName("address2_shippingmethodcodename")]
    public object Address2_ShippingMethodCodeName
    {
      get => this.GetAttributeValue<object>("address2_shippingmethodcodename");
    }

    [AttributeLogicalName("address2_stateorprovince")]
    public string Address2_StateOrProvince
    {
      get => this.GetAttributeValue<string>("address2_stateorprovince");
      set
      {
        this.OnPropertyChanging(nameof (Address2_StateOrProvince));
        this.SetAttributeValue("address2_stateorprovince", (object) value);
        this.OnPropertyChanged(nameof (Address2_StateOrProvince));
      }
    }

    [AttributeLogicalName("address2_telephone1")]
    public string Address2_Telephone1
    {
      get => this.GetAttributeValue<string>("address2_telephone1");
      set
      {
        this.OnPropertyChanging(nameof (Address2_Telephone1));
        this.SetAttributeValue("address2_telephone1", (object) value);
        this.OnPropertyChanged(nameof (Address2_Telephone1));
      }
    }

    [AttributeLogicalName("address2_telephone2")]
    public string Address2_Telephone2
    {
      get => this.GetAttributeValue<string>("address2_telephone2");
      set
      {
        this.OnPropertyChanging(nameof (Address2_Telephone2));
        this.SetAttributeValue("address2_telephone2", (object) value);
        this.OnPropertyChanged(nameof (Address2_Telephone2));
      }
    }

    [AttributeLogicalName("address2_telephone3")]
    public string Address2_Telephone3
    {
      get => this.GetAttributeValue<string>("address2_telephone3");
      set
      {
        this.OnPropertyChanging(nameof (Address2_Telephone3));
        this.SetAttributeValue("address2_telephone3", (object) value);
        this.OnPropertyChanged(nameof (Address2_Telephone3));
      }
    }

    [AttributeLogicalName("address2_upszone")]
    public string Address2_UPSZone
    {
      get => this.GetAttributeValue<string>("address2_upszone");
      set
      {
        this.OnPropertyChanging(nameof (Address2_UPSZone));
        this.SetAttributeValue("address2_upszone", (object) value);
        this.OnPropertyChanged(nameof (Address2_UPSZone));
      }
    }

    [AttributeLogicalName("address2_utcoffset")]
    public int? Address2_UTCOffset
    {
      get => this.GetAttributeValue<int?>("address2_utcoffset");
      set
      {
        this.OnPropertyChanging(nameof (Address2_UTCOffset));
        this.SetAttributeValue("address2_utcoffset", (object) value);
        this.OnPropertyChanged(nameof (Address2_UTCOffset));
      }
    }

    [AttributeLogicalName("adx_createdbyipaddress")]
    public string Adx_CreatedByIPAddress
    {
      get => this.GetAttributeValue<string>("adx_createdbyipaddress");
      set
      {
        this.OnPropertyChanging(nameof (Adx_CreatedByIPAddress));
        this.SetAttributeValue("adx_createdbyipaddress", (object) value);
        this.OnPropertyChanged(nameof (Adx_CreatedByIPAddress));
      }
    }

    [AttributeLogicalName("adx_createdbyusername")]
    public string Adx_CreatedByUsername
    {
      get => this.GetAttributeValue<string>("adx_createdbyusername");
      set
      {
        this.OnPropertyChanging(nameof (Adx_CreatedByUsername));
        this.SetAttributeValue("adx_createdbyusername", (object) value);
        this.OnPropertyChanged(nameof (Adx_CreatedByUsername));
      }
    }

    [AttributeLogicalName("adx_modifiedbyipaddress")]
    public string Adx_ModifiedByIPAddress
    {
      get => this.GetAttributeValue<string>("adx_modifiedbyipaddress");
      set
      {
        this.OnPropertyChanging(nameof (Adx_ModifiedByIPAddress));
        this.SetAttributeValue("adx_modifiedbyipaddress", (object) value);
        this.OnPropertyChanged(nameof (Adx_ModifiedByIPAddress));
      }
    }

    [AttributeLogicalName("adx_modifiedbyusername")]
    public string Adx_ModifiedByUsername
    {
      get => this.GetAttributeValue<string>("adx_modifiedbyusername");
      set
      {
        this.OnPropertyChanging(nameof (Adx_ModifiedByUsername));
        this.SetAttributeValue("adx_modifiedbyusername", (object) value);
        this.OnPropertyChanged(nameof (Adx_ModifiedByUsername));
      }
    }

    [AttributeLogicalName("aging30")]
    public Money Aging30 => this.GetAttributeValue<Money>("aging30");

    [AttributeLogicalName("aging30_base")]
    public Money Aging30_Base => this.GetAttributeValue<Money>("aging30_base");

    [AttributeLogicalName("aging60")]
    public Money Aging60 => this.GetAttributeValue<Money>("aging60");

    [AttributeLogicalName("aging60_base")]
    public Money Aging60_Base => this.GetAttributeValue<Money>("aging60_base");

    [AttributeLogicalName("aging90")]
    public Money Aging90 => this.GetAttributeValue<Money>("aging90");

    [AttributeLogicalName("aging90_base")]
    public Money Aging90_Base => this.GetAttributeValue<Money>("aging90_base");

    [AttributeLogicalName("ait_tribalowned")]
    public bool? ait_TribalOwned
    {
      get => this.GetAttributeValue<bool?>("ait_tribalowned");
      set
      {
        this.OnPropertyChanging(nameof (ait_TribalOwned));
        this.SetAttributeValue("ait_tribalowned", (object) value);
        this.OnPropertyChanged(nameof (ait_TribalOwned));
      }
    }

    [AttributeLogicalName("ait_tribalownedname")]
    public object ait_tribalownedName => this.GetAttributeValue<object>("ait_tribalownedname");

    [AttributeLogicalName("ait_vendornumber")]
    public string ait_VendorNumber
    {
      get => this.GetAttributeValue<string>("ait_vendornumber");
      set
      {
        this.OnPropertyChanging(nameof (ait_VendorNumber));
        this.SetAttributeValue("ait_vendornumber", (object) value);
        this.OnPropertyChanged(nameof (ait_VendorNumber));
      }
    }

    [AttributeLogicalName("businesstypecode")]
    public OptionSetValue BusinessTypeCode
    {
      get => this.GetAttributeValue<OptionSetValue>("businesstypecode");
      set
      {
        this.OnPropertyChanging(nameof (BusinessTypeCode));
        this.SetAttributeValue("businesstypecode", (object) value);
        this.OnPropertyChanged(nameof (BusinessTypeCode));
      }
    }

    [AttributeLogicalName("businesstypecodename")]
    public object BusinessTypeCodeName => this.GetAttributeValue<object>("businesstypecodename");

    [AttributeLogicalName("createdby")]
    public EntityReference CreatedBy => this.GetAttributeValue<EntityReference>("createdby");

    [AttributeLogicalName("createdbyexternalparty")]
    public EntityReference CreatedByExternalParty
    {
      get => this.GetAttributeValue<EntityReference>("createdbyexternalparty");
    }

    [AttributeLogicalName("createdbyexternalpartyname")]
    public string CreatedByExternalPartyName
    {
      get => this.GetAttributeValue<string>("createdbyexternalpartyname");
    }

    [AttributeLogicalName("createdbyexternalpartyyominame")]
    public string CreatedByExternalPartyYomiName
    {
      get => this.GetAttributeValue<string>("createdbyexternalpartyyominame");
    }

    [AttributeLogicalName("createdbyname")]
    public string CreatedByName => this.GetAttributeValue<string>("createdbyname");

    [AttributeLogicalName("createdbyyominame")]
    public string CreatedByYomiName => this.GetAttributeValue<string>("createdbyyominame");

    [AttributeLogicalName("createdon")]
    public DateTime? CreatedOn => this.GetAttributeValue<DateTime?>("createdon");

    [AttributeLogicalName("createdonbehalfby")]
    public EntityReference CreatedOnBehalfBy
    {
      get => this.GetAttributeValue<EntityReference>("createdonbehalfby");
    }

    [AttributeLogicalName("createdonbehalfbyname")]
    public string CreatedOnBehalfByName => this.GetAttributeValue<string>("createdonbehalfbyname");

    [AttributeLogicalName("createdonbehalfbyyominame")]
    public string CreatedOnBehalfByYomiName
    {
      get => this.GetAttributeValue<string>("createdonbehalfbyyominame");
    }

    [AttributeLogicalName("creditlimit")]
    public Money CreditLimit
    {
      get => this.GetAttributeValue<Money>("creditlimit");
      set
      {
        this.OnPropertyChanging(nameof (CreditLimit));
        this.SetAttributeValue("creditlimit", (object) value);
        this.OnPropertyChanged(nameof (CreditLimit));
      }
    }

    [AttributeLogicalName("creditlimit_base")]
    public Money CreditLimit_Base => this.GetAttributeValue<Money>("creditlimit_base");

    [AttributeLogicalName("creditonhold")]
    public bool? CreditOnHold
    {
      get => this.GetAttributeValue<bool?>("creditonhold");
      set
      {
        this.OnPropertyChanging(nameof (CreditOnHold));
        this.SetAttributeValue("creditonhold", (object) value);
        this.OnPropertyChanged(nameof (CreditOnHold));
      }
    }

    [AttributeLogicalName("creditonholdname")]
    public object CreditOnHoldName => this.GetAttributeValue<object>("creditonholdname");

    [AttributeLogicalName("customersizecode")]
    public OptionSetValue CustomerSizeCode
    {
      get => this.GetAttributeValue<OptionSetValue>("customersizecode");
      set
      {
        this.OnPropertyChanging(nameof (CustomerSizeCode));
        this.SetAttributeValue("customersizecode", (object) value);
        this.OnPropertyChanged(nameof (CustomerSizeCode));
      }
    }

    [AttributeLogicalName("customersizecodename")]
    public object CustomerSizeCodeName => this.GetAttributeValue<object>("customersizecodename");

    [AttributeLogicalName("customertypecode")]
    public OptionSetValue CustomerTypeCode
    {
      get => this.GetAttributeValue<OptionSetValue>("customertypecode");
      set
      {
        this.OnPropertyChanging(nameof (CustomerTypeCode));
        this.SetAttributeValue("customertypecode", (object) value);
        this.OnPropertyChanged(nameof (CustomerTypeCode));
      }
    }

    [AttributeLogicalName("customertypecodename")]
    public object CustomerTypeCodeName => this.GetAttributeValue<object>("customertypecodename");

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

    [AttributeLogicalName("donotbulkemail")]
    public bool? DoNotBulkEMail
    {
      get => this.GetAttributeValue<bool?>("donotbulkemail");
      set
      {
        this.OnPropertyChanging(nameof (DoNotBulkEMail));
        this.SetAttributeValue("donotbulkemail", (object) value);
        this.OnPropertyChanged(nameof (DoNotBulkEMail));
      }
    }

    [AttributeLogicalName("donotbulkemailname")]
    public object DoNotBulkEMailName => this.GetAttributeValue<object>("donotbulkemailname");

    [AttributeLogicalName("donotbulkpostalmail")]
    public bool? DoNotBulkPostalMail
    {
      get => this.GetAttributeValue<bool?>("donotbulkpostalmail");
      set
      {
        this.OnPropertyChanging(nameof (DoNotBulkPostalMail));
        this.SetAttributeValue("donotbulkpostalmail", (object) value);
        this.OnPropertyChanged(nameof (DoNotBulkPostalMail));
      }
    }

    [AttributeLogicalName("donotbulkpostalmailname")]
    public object DoNotBulkPostalMailName
    {
      get => this.GetAttributeValue<object>("donotbulkpostalmailname");
    }

    [AttributeLogicalName("donotemail")]
    public bool? DoNotEMail
    {
      get => this.GetAttributeValue<bool?>("donotemail");
      set
      {
        this.OnPropertyChanging(nameof (DoNotEMail));
        this.SetAttributeValue("donotemail", (object) value);
        this.OnPropertyChanged(nameof (DoNotEMail));
      }
    }

    [AttributeLogicalName("donotemailname")]
    public object DoNotEMailName => this.GetAttributeValue<object>("donotemailname");

    [AttributeLogicalName("donotfax")]
    public bool? DoNotFax
    {
      get => this.GetAttributeValue<bool?>("donotfax");
      set
      {
        this.OnPropertyChanging(nameof (DoNotFax));
        this.SetAttributeValue("donotfax", (object) value);
        this.OnPropertyChanged(nameof (DoNotFax));
      }
    }

    [AttributeLogicalName("donotfaxname")]
    public object DoNotFaxName => this.GetAttributeValue<object>("donotfaxname");

    [AttributeLogicalName("donotphone")]
    public bool? DoNotPhone
    {
      get => this.GetAttributeValue<bool?>("donotphone");
      set
      {
        this.OnPropertyChanging(nameof (DoNotPhone));
        this.SetAttributeValue("donotphone", (object) value);
        this.OnPropertyChanged(nameof (DoNotPhone));
      }
    }

    [AttributeLogicalName("donotphonename")]
    public object DoNotPhoneName => this.GetAttributeValue<object>("donotphonename");

    [AttributeLogicalName("donotpostalmail")]
    public bool? DoNotPostalMail
    {
      get => this.GetAttributeValue<bool?>("donotpostalmail");
      set
      {
        this.OnPropertyChanging(nameof (DoNotPostalMail));
        this.SetAttributeValue("donotpostalmail", (object) value);
        this.OnPropertyChanged(nameof (DoNotPostalMail));
      }
    }

    [AttributeLogicalName("donotpostalmailname")]
    public object DoNotPostalMailName => this.GetAttributeValue<object>("donotpostalmailname");

    [AttributeLogicalName("donotsendmarketingmaterialname")]
    public object DoNotSendMarketingMaterialName
    {
      get => this.GetAttributeValue<object>("donotsendmarketingmaterialname");
    }

    [AttributeLogicalName("donotsendmm")]
    public bool? DoNotSendMM
    {
      get => this.GetAttributeValue<bool?>("donotsendmm");
      set
      {
        this.OnPropertyChanging(nameof (DoNotSendMM));
        this.SetAttributeValue("donotsendmm", (object) value);
        this.OnPropertyChanged(nameof (DoNotSendMM));
      }
    }

    [AttributeLogicalName("emailaddress1")]
    public string EMailAddress1
    {
      get => this.GetAttributeValue<string>("emailaddress1");
      set
      {
        this.OnPropertyChanging(nameof (EMailAddress1));
        this.SetAttributeValue("emailaddress1", (object) value);
        this.OnPropertyChanged(nameof (EMailAddress1));
      }
    }

    [AttributeLogicalName("emailaddress2")]
    public string EMailAddress2
    {
      get => this.GetAttributeValue<string>("emailaddress2");
      set
      {
        this.OnPropertyChanging(nameof (EMailAddress2));
        this.SetAttributeValue("emailaddress2", (object) value);
        this.OnPropertyChanged(nameof (EMailAddress2));
      }
    }

    [AttributeLogicalName("emailaddress3")]
    public string EMailAddress3
    {
      get => this.GetAttributeValue<string>("emailaddress3");
      set
      {
        this.OnPropertyChanging(nameof (EMailAddress3));
        this.SetAttributeValue("emailaddress3", (object) value);
        this.OnPropertyChanged(nameof (EMailAddress3));
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

    [AttributeLogicalName("exchangerate")]
    public Decimal? ExchangeRate => this.GetAttributeValue<Decimal?>("exchangerate");

    [AttributeLogicalName("fax")]
    public string Fax
    {
      get => this.GetAttributeValue<string>("fax");
      set
      {
        this.OnPropertyChanging(nameof (Fax));
        this.SetAttributeValue("fax", (object) value);
        this.OnPropertyChanged(nameof (Fax));
      }
    }

    [AttributeLogicalName("followemail")]
    public bool? FollowEmail
    {
      get => this.GetAttributeValue<bool?>("followemail");
      set
      {
        this.OnPropertyChanging(nameof (FollowEmail));
        this.SetAttributeValue("followemail", (object) value);
        this.OnPropertyChanged(nameof (FollowEmail));
      }
    }

    [AttributeLogicalName("followemailname")]
    public object FollowEmailName => this.GetAttributeValue<object>("followemailname");

    [AttributeLogicalName("ftpsiteurl")]
    public string FtpSiteURL
    {
      get => this.GetAttributeValue<string>("ftpsiteurl");
      set
      {
        this.OnPropertyChanging(nameof (FtpSiteURL));
        this.SetAttributeValue("ftpsiteurl", (object) value);
        this.OnPropertyChanged(nameof (FtpSiteURL));
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

    [AttributeLogicalName("industrycode")]
    public OptionSetValue IndustryCode
    {
      get => this.GetAttributeValue<OptionSetValue>("industrycode");
      set
      {
        this.OnPropertyChanging(nameof (IndustryCode));
        this.SetAttributeValue("industrycode", (object) value);
        this.OnPropertyChanged(nameof (IndustryCode));
      }
    }

    [AttributeLogicalName("industrycodename")]
    public object IndustryCodeName => this.GetAttributeValue<object>("industrycodename");

    [AttributeLogicalName("isprivatename")]
    public object IsPrivateName => this.GetAttributeValue<object>("isprivatename");

    [AttributeLogicalName("lastonholdtime")]
    public DateTime? LastOnHoldTime
    {
      get => this.GetAttributeValue<DateTime?>("lastonholdtime");
      set
      {
        this.OnPropertyChanging(nameof (LastOnHoldTime));
        this.SetAttributeValue("lastonholdtime", (object) value);
        this.OnPropertyChanged(nameof (LastOnHoldTime));
      }
    }

    [AttributeLogicalName("lastusedincampaign")]
    public DateTime? LastUsedInCampaign
    {
      get => this.GetAttributeValue<DateTime?>("lastusedincampaign");
      set
      {
        this.OnPropertyChanging(nameof (LastUsedInCampaign));
        this.SetAttributeValue("lastusedincampaign", (object) value);
        this.OnPropertyChanged(nameof (LastUsedInCampaign));
      }
    }

    [AttributeLogicalName("marketcap")]
    public Money MarketCap
    {
      get => this.GetAttributeValue<Money>("marketcap");
      set
      {
        this.OnPropertyChanging(nameof (MarketCap));
        this.SetAttributeValue("marketcap", (object) value);
        this.OnPropertyChanged(nameof (MarketCap));
      }
    }

    [AttributeLogicalName("marketcap_base")]
    public Money MarketCap_Base => this.GetAttributeValue<Money>("marketcap_base");

    [AttributeLogicalName("marketingonly")]
    public bool? MarketingOnly
    {
      get => this.GetAttributeValue<bool?>("marketingonly");
      set
      {
        this.OnPropertyChanging(nameof (MarketingOnly));
        this.SetAttributeValue("marketingonly", (object) value);
        this.OnPropertyChanged(nameof (MarketingOnly));
      }
    }

    [AttributeLogicalName("marketingonlyname")]
    public object MarketingOnlyName => this.GetAttributeValue<object>("marketingonlyname");

    [AttributeLogicalName("masteraccountidname")]
    public string MasterAccountIdName => this.GetAttributeValue<string>("masteraccountidname");

    [AttributeLogicalName("masteraccountidyominame")]
    public string MasterAccountIdYomiName
    {
      get => this.GetAttributeValue<string>("masteraccountidyominame");
    }

    [AttributeLogicalName("masterid")]
    public EntityReference MasterId => this.GetAttributeValue<EntityReference>("masterid");

    [AttributeLogicalName("merged")]
    public bool? Merged => this.GetAttributeValue<bool?>("merged");

    [AttributeLogicalName("mergedname")]
    public object MergedName => this.GetAttributeValue<object>("mergedname");

    [AttributeLogicalName("modifiedby")]
    public EntityReference ModifiedBy => this.GetAttributeValue<EntityReference>("modifiedby");

    [AttributeLogicalName("modifiedbyexternalparty")]
    public EntityReference ModifiedByExternalParty
    {
      get => this.GetAttributeValue<EntityReference>("modifiedbyexternalparty");
    }

    [AttributeLogicalName("modifiedbyexternalpartyname")]
    public string ModifiedByExternalPartyName
    {
      get => this.GetAttributeValue<string>("modifiedbyexternalpartyname");
    }

    [AttributeLogicalName("modifiedbyexternalpartyyominame")]
    public string ModifiedByExternalPartyYomiName
    {
      get => this.GetAttributeValue<string>("modifiedbyexternalpartyyominame");
    }

    [AttributeLogicalName("modifiedbyname")]
    public string ModifiedByName => this.GetAttributeValue<string>("modifiedbyname");

    [AttributeLogicalName("modifiedbyyominame")]
    public string ModifiedByYomiName => this.GetAttributeValue<string>("modifiedbyyominame");

    [AttributeLogicalName("modifiedon")]
    public DateTime? ModifiedOn => this.GetAttributeValue<DateTime?>("modifiedon");

    [AttributeLogicalName("modifiedonbehalfby")]
    public EntityReference ModifiedOnBehalfBy
    {
      get => this.GetAttributeValue<EntityReference>("modifiedonbehalfby");
    }

    [AttributeLogicalName("modifiedonbehalfbyname")]
    public string ModifiedOnBehalfByName
    {
      get => this.GetAttributeValue<string>("modifiedonbehalfbyname");
    }

    [AttributeLogicalName("modifiedonbehalfbyyominame")]
    public string ModifiedOnBehalfByYomiName
    {
      get => this.GetAttributeValue<string>("modifiedonbehalfbyyominame");
    }

    [AttributeLogicalName("msa_managingpartnerid")]
    public EntityReference msa_managingpartnerid
    {
      get => this.GetAttributeValue<EntityReference>(nameof (msa_managingpartnerid));
      set
      {
        this.OnPropertyChanging(nameof (msa_managingpartnerid));
        this.SetAttributeValue(nameof (msa_managingpartnerid), (object) value);
        this.OnPropertyChanged(nameof (msa_managingpartnerid));
      }
    }

    [AttributeLogicalName("msa_managingpartneridname")]
    public string msa_managingpartneridName
    {
      get => this.GetAttributeValue<string>("msa_managingpartneridname");
    }

    [AttributeLogicalName("msa_managingpartneridyominame")]
    public string msa_managingpartneridYomiName
    {
      get => this.GetAttributeValue<string>("msa_managingpartneridyominame");
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

    [AttributeLogicalName("numberofemployees")]
    public int? NumberOfEmployees
    {
      get => this.GetAttributeValue<int?>("numberofemployees");
      set
      {
        this.OnPropertyChanging(nameof (NumberOfEmployees));
        this.SetAttributeValue("numberofemployees", (object) value);
        this.OnPropertyChanged(nameof (NumberOfEmployees));
      }
    }

    [AttributeLogicalName("onholdtime")]
    public int? OnHoldTime => this.GetAttributeValue<int?>("onholdtime");

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

    [AttributeLogicalName("ownerid")]
    public EntityReference OwnerId
    {
      get => this.GetAttributeValue<EntityReference>("ownerid");
      set
      {
        this.OnPropertyChanging(nameof (OwnerId));
        this.SetAttributeValue("ownerid", (object) value);
        this.OnPropertyChanged(nameof (OwnerId));
      }
    }

    [AttributeLogicalName("owneridname")]
    public string OwnerIdName => this.GetAttributeValue<string>("owneridname");

    [AttributeLogicalName("owneridtype")]
    public string OwnerIdType
    {
      get => this.GetAttributeValue<string>("owneridtype");
      set
      {
        this.OnPropertyChanging(nameof (OwnerIdType));
        this.SetAttributeValue("owneridtype", (object) value);
        this.OnPropertyChanged(nameof (OwnerIdType));
      }
    }

    [AttributeLogicalName("owneridyominame")]
    public string OwnerIdYomiName => this.GetAttributeValue<string>("owneridyominame");

    [AttributeLogicalName("ownershipcode")]
    public OptionSetValue OwnershipCode
    {
      get => this.GetAttributeValue<OptionSetValue>("ownershipcode");
      set
      {
        this.OnPropertyChanging(nameof (OwnershipCode));
        this.SetAttributeValue("ownershipcode", (object) value);
        this.OnPropertyChanged(nameof (OwnershipCode));
      }
    }

    [AttributeLogicalName("ownershipcodename")]
    public object OwnershipCodeName => this.GetAttributeValue<object>("ownershipcodename");

    [AttributeLogicalName("owningbusinessunit")]
    public EntityReference OwningBusinessUnit
    {
      get => this.GetAttributeValue<EntityReference>("owningbusinessunit");
    }

    [AttributeLogicalName("owningteam")]
    public EntityReference OwningTeam => this.GetAttributeValue<EntityReference>("owningteam");

    [AttributeLogicalName("owninguser")]
    public EntityReference OwningUser => this.GetAttributeValue<EntityReference>("owninguser");

    [AttributeLogicalName("parentaccountid")]
    public EntityReference ParentAccountId
    {
      get => this.GetAttributeValue<EntityReference>("parentaccountid");
      set
      {
        this.OnPropertyChanging(nameof (ParentAccountId));
        this.SetAttributeValue("parentaccountid", (object) value);
        this.OnPropertyChanged(nameof (ParentAccountId));
      }
    }

    [AttributeLogicalName("parentaccountidname")]
    public string ParentAccountIdName => this.GetAttributeValue<string>("parentaccountidname");

    [AttributeLogicalName("parentaccountidyominame")]
    public string ParentAccountIdYomiName
    {
      get => this.GetAttributeValue<string>("parentaccountidyominame");
    }

    [AttributeLogicalName("participatesinworkflow")]
    public bool? ParticipatesInWorkflow
    {
      get => this.GetAttributeValue<bool?>("participatesinworkflow");
      set
      {
        this.OnPropertyChanging(nameof (ParticipatesInWorkflow));
        this.SetAttributeValue("participatesinworkflow", (object) value);
        this.OnPropertyChanged(nameof (ParticipatesInWorkflow));
      }
    }

    [AttributeLogicalName("participatesinworkflowname")]
    public object ParticipatesInWorkflowName
    {
      get => this.GetAttributeValue<object>("participatesinworkflowname");
    }

    [AttributeLogicalName("paymenttermscode")]
    public OptionSetValue PaymentTermsCode
    {
      get => this.GetAttributeValue<OptionSetValue>("paymenttermscode");
      set
      {
        this.OnPropertyChanging(nameof (PaymentTermsCode));
        this.SetAttributeValue("paymenttermscode", (object) value);
        this.OnPropertyChanged(nameof (PaymentTermsCode));
      }
    }

    [AttributeLogicalName("paymenttermscodename")]
    public object PaymentTermsCodeName => this.GetAttributeValue<object>("paymenttermscodename");

    [AttributeLogicalName("preferredappointmentdaycode")]
    public OptionSetValue PreferredAppointmentDayCode
    {
      get => this.GetAttributeValue<OptionSetValue>("preferredappointmentdaycode");
      set
      {
        this.OnPropertyChanging(nameof (PreferredAppointmentDayCode));
        this.SetAttributeValue("preferredappointmentdaycode", (object) value);
        this.OnPropertyChanged(nameof (PreferredAppointmentDayCode));
      }
    }

    [AttributeLogicalName("preferredappointmentdaycodename")]
    public object PreferredAppointmentDayCodeName
    {
      get => this.GetAttributeValue<object>("preferredappointmentdaycodename");
    }

    [AttributeLogicalName("preferredappointmenttimecode")]
    public OptionSetValue PreferredAppointmentTimeCode
    {
      get => this.GetAttributeValue<OptionSetValue>("preferredappointmenttimecode");
      set
      {
        this.OnPropertyChanging(nameof (PreferredAppointmentTimeCode));
        this.SetAttributeValue("preferredappointmenttimecode", (object) value);
        this.OnPropertyChanged(nameof (PreferredAppointmentTimeCode));
      }
    }

    [AttributeLogicalName("preferredappointmenttimecodename")]
    public object PreferredAppointmentTimeCodeName
    {
      get => this.GetAttributeValue<object>("preferredappointmenttimecodename");
    }

    [AttributeLogicalName("preferredcontactmethodcode")]
    public OptionSetValue PreferredContactMethodCode
    {
      get => this.GetAttributeValue<OptionSetValue>("preferredcontactmethodcode");
      set
      {
        this.OnPropertyChanging(nameof (PreferredContactMethodCode));
        this.SetAttributeValue("preferredcontactmethodcode", (object) value);
        this.OnPropertyChanged(nameof (PreferredContactMethodCode));
      }
    }

    [AttributeLogicalName("preferredcontactmethodcodename")]
    public object PreferredContactMethodCodeName
    {
      get => this.GetAttributeValue<object>("preferredcontactmethodcodename");
    }

    [AttributeLogicalName("preferredsystemuserid")]
    public EntityReference PreferredSystemUserId
    {
      get => this.GetAttributeValue<EntityReference>("preferredsystemuserid");
      set
      {
        this.OnPropertyChanging(nameof (PreferredSystemUserId));
        this.SetAttributeValue("preferredsystemuserid", (object) value);
        this.OnPropertyChanged(nameof (PreferredSystemUserId));
      }
    }

    [AttributeLogicalName("preferredsystemuseridname")]
    public string PreferredSystemUserIdName
    {
      get => this.GetAttributeValue<string>("preferredsystemuseridname");
    }

    [AttributeLogicalName("preferredsystemuseridyominame")]
    public string PreferredSystemUserIdYomiName
    {
      get => this.GetAttributeValue<string>("preferredsystemuseridyominame");
    }

    [AttributeLogicalName("primarycontactid")]
    public EntityReference PrimaryContactId
    {
      get => this.GetAttributeValue<EntityReference>("primarycontactid");
      set
      {
        this.OnPropertyChanging(nameof (PrimaryContactId));
        this.SetAttributeValue("primarycontactid", (object) value);
        this.OnPropertyChanged(nameof (PrimaryContactId));
      }
    }

    [AttributeLogicalName("primarycontactidname")]
    public string PrimaryContactIdName => this.GetAttributeValue<string>("primarycontactidname");

    [AttributeLogicalName("primarycontactidyominame")]
    public string PrimaryContactIdYomiName
    {
      get => this.GetAttributeValue<string>("primarycontactidyominame");
    }

    [AttributeLogicalName("primarysatoriid")]
    public string PrimarySatoriId
    {
      get => this.GetAttributeValue<string>("primarysatoriid");
      set
      {
        this.OnPropertyChanging(nameof (PrimarySatoriId));
        this.SetAttributeValue("primarysatoriid", (object) value);
        this.OnPropertyChanged(nameof (PrimarySatoriId));
      }
    }

    [AttributeLogicalName("primarytwitterid")]
    public string PrimaryTwitterId
    {
      get => this.GetAttributeValue<string>("primarytwitterid");
      set
      {
        this.OnPropertyChanging(nameof (PrimaryTwitterId));
        this.SetAttributeValue("primarytwitterid", (object) value);
        this.OnPropertyChanged(nameof (PrimaryTwitterId));
      }
    }

    [AttributeLogicalName("processid")]
    public Guid? ProcessId
    {
      get => this.GetAttributeValue<Guid?>("processid");
      set
      {
        this.OnPropertyChanging(nameof (ProcessId));
        this.SetAttributeValue("processid", (object) value);
        this.OnPropertyChanged(nameof (ProcessId));
      }
    }

    [AttributeLogicalName("revenue")]
    public Money Revenue
    {
      get => this.GetAttributeValue<Money>("revenue");
      set
      {
        this.OnPropertyChanging(nameof (Revenue));
        this.SetAttributeValue("revenue", (object) value);
        this.OnPropertyChanged(nameof (Revenue));
      }
    }

    [AttributeLogicalName("revenue_base")]
    public Money Revenue_Base => this.GetAttributeValue<Money>("revenue_base");

    [AttributeLogicalName("sharesoutstanding")]
    public int? SharesOutstanding
    {
      get => this.GetAttributeValue<int?>("sharesoutstanding");
      set
      {
        this.OnPropertyChanging(nameof (SharesOutstanding));
        this.SetAttributeValue("sharesoutstanding", (object) value);
        this.OnPropertyChanged(nameof (SharesOutstanding));
      }
    }

    [AttributeLogicalName("shippingmethodcode")]
    public OptionSetValue ShippingMethodCode
    {
      get => this.GetAttributeValue<OptionSetValue>("shippingmethodcode");
      set
      {
        this.OnPropertyChanging(nameof (ShippingMethodCode));
        this.SetAttributeValue("shippingmethodcode", (object) value);
        this.OnPropertyChanged(nameof (ShippingMethodCode));
      }
    }

    [AttributeLogicalName("shippingmethodcodename")]
    public object ShippingMethodCodeName
    {
      get => this.GetAttributeValue<object>("shippingmethodcodename");
    }

    [AttributeLogicalName("sic")]
    public string SIC
    {
      get => this.GetAttributeValue<string>("sic");
      set
      {
        this.OnPropertyChanging(nameof (SIC));
        this.SetAttributeValue("sic", (object) value);
        this.OnPropertyChanged(nameof (SIC));
      }
    }

    [AttributeLogicalName("slaid")]
    public EntityReference SLAId
    {
      get => this.GetAttributeValue<EntityReference>("slaid");
      set
      {
        this.OnPropertyChanging(nameof (SLAId));
        this.SetAttributeValue("slaid", (object) value);
        this.OnPropertyChanged(nameof (SLAId));
      }
    }

    [AttributeLogicalName("slainvokedid")]
    public EntityReference SLAInvokedId => this.GetAttributeValue<EntityReference>("slainvokedid");

    [AttributeLogicalName("slainvokedidname")]
    public string SLAInvokedIdName => this.GetAttributeValue<string>("slainvokedidname");

    [AttributeLogicalName("slaname")]
    public string SLAName => this.GetAttributeValue<string>("slaname");

    [AttributeLogicalName("stageid")]
    public Guid? StageId
    {
      get => this.GetAttributeValue<Guid?>("stageid");
      set
      {
        this.OnPropertyChanging(nameof (StageId));
        this.SetAttributeValue("stageid", (object) value);
        this.OnPropertyChanged(nameof (StageId));
      }
    }

    [AttributeLogicalName("statecode")]
    public AccountState? StateCode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>("statecode");
        return attributeValue != null ? new AccountState?((AccountState) Enum.ToObject(typeof (AccountState), attributeValue.Value)) : new AccountState?();
      }
      set
      {
        this.OnPropertyChanging(nameof (StateCode));
        if (!value.HasValue)
          this.SetAttributeValue("statecode", (object) null);
        else
          this.SetAttributeValue("statecode", (object) new OptionSetValue((int) value.Value));
        this.OnPropertyChanged(nameof (StateCode));
      }
    }

    [AttributeLogicalName("statecodename")]
    public object StateCodeName => this.GetAttributeValue<object>("statecodename");

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

    [AttributeLogicalName("statuscodename")]
    public object StatusCodeName => this.GetAttributeValue<object>("statuscodename");

    [AttributeLogicalName("stockexchange")]
    public string StockExchange
    {
      get => this.GetAttributeValue<string>("stockexchange");
      set
      {
        this.OnPropertyChanging(nameof (StockExchange));
        this.SetAttributeValue("stockexchange", (object) value);
        this.OnPropertyChanged(nameof (StockExchange));
      }
    }

    [AttributeLogicalName("telephone1")]
    public string Telephone1
    {
      get => this.GetAttributeValue<string>("telephone1");
      set
      {
        this.OnPropertyChanging(nameof (Telephone1));
        this.SetAttributeValue("telephone1", (object) value);
        this.OnPropertyChanged(nameof (Telephone1));
      }
    }

    [AttributeLogicalName("telephone2")]
    public string Telephone2
    {
      get => this.GetAttributeValue<string>("telephone2");
      set
      {
        this.OnPropertyChanging(nameof (Telephone2));
        this.SetAttributeValue("telephone2", (object) value);
        this.OnPropertyChanged(nameof (Telephone2));
      }
    }

    [AttributeLogicalName("telephone3")]
    public string Telephone3
    {
      get => this.GetAttributeValue<string>("telephone3");
      set
      {
        this.OnPropertyChanging(nameof (Telephone3));
        this.SetAttributeValue("telephone3", (object) value);
        this.OnPropertyChanged(nameof (Telephone3));
      }
    }

    [AttributeLogicalName("territorycode")]
    public OptionSetValue TerritoryCode
    {
      get => this.GetAttributeValue<OptionSetValue>("territorycode");
      set
      {
        this.OnPropertyChanging(nameof (TerritoryCode));
        this.SetAttributeValue("territorycode", (object) value);
        this.OnPropertyChanged(nameof (TerritoryCode));
      }
    }

    [AttributeLogicalName("territorycodename")]
    public object TerritoryCodeName => this.GetAttributeValue<object>("territorycodename");

    [AttributeLogicalName("tickersymbol")]
    public string TickerSymbol
    {
      get => this.GetAttributeValue<string>("tickersymbol");
      set
      {
        this.OnPropertyChanging(nameof (TickerSymbol));
        this.SetAttributeValue("tickersymbol", (object) value);
        this.OnPropertyChanged(nameof (TickerSymbol));
      }
    }

    [AttributeLogicalName("timespentbymeonemailandmeetings")]
    public string TimeSpentByMeOnEmailAndMeetings
    {
      get => this.GetAttributeValue<string>("timespentbymeonemailandmeetings");
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

    [AttributeLogicalName("transactioncurrencyidname")]
    public string TransactionCurrencyIdName
    {
      get => this.GetAttributeValue<string>("transactioncurrencyidname");
    }

    [AttributeLogicalName("traversedpath")]
    public string TraversedPath
    {
      get => this.GetAttributeValue<string>("traversedpath");
      set
      {
        this.OnPropertyChanging(nameof (TraversedPath));
        this.SetAttributeValue("traversedpath", (object) value);
        this.OnPropertyChanged(nameof (TraversedPath));
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

    [AttributeLogicalName("websiteurl")]
    public string WebSiteURL
    {
      get => this.GetAttributeValue<string>("websiteurl");
      set
      {
        this.OnPropertyChanging(nameof (WebSiteURL));
        this.SetAttributeValue("websiteurl", (object) value);
        this.OnPropertyChanged(nameof (WebSiteURL));
      }
    }

    [AttributeLogicalName("yominame")]
    public string YomiName
    {
      get => this.GetAttributeValue<string>("yominame");
      set
      {
        this.OnPropertyChanging(nameof (YomiName));
        this.SetAttributeValue("yominame", (object) value);
        this.OnPropertyChanged(nameof (YomiName));
      }
    }

    [RelationshipSchemaName("Account_Appointments")]
    public IEnumerable<Appointment> Account_Appointments
    {
      get => this.GetRelatedEntities<Appointment>(nameof (Account_Appointments), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Account_Appointments));
        this.SetRelatedEntities<Appointment>(nameof (Account_Appointments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Account_Appointments));
      }
    }

    [RelationshipSchemaName("account_connections1")]
    public IEnumerable<Connection> account_connections1
    {
      get => this.GetRelatedEntities<Connection>(nameof (account_connections1), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (account_connections1));
        this.SetRelatedEntities<Connection>(nameof (account_connections1), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (account_connections1));
      }
    }

    [RelationshipSchemaName("account_connections2")]
    public IEnumerable<Connection> account_connections2
    {
      get => this.GetRelatedEntities<Connection>(nameof (account_connections2), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (account_connections2));
        this.SetRelatedEntities<Connection>(nameof (account_connections2), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (account_connections2));
      }
    }

    [RelationshipSchemaName("Account_Email_EmailSender")]
    public IEnumerable<Email> Account_Email_EmailSender
    {
      get => this.GetRelatedEntities<Email>(nameof (Account_Email_EmailSender), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Account_Email_EmailSender));
        this.SetRelatedEntities<Email>(nameof (Account_Email_EmailSender), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Account_Email_EmailSender));
      }
    }

    [RelationshipSchemaName("Account_Email_SendersAccount")]
    public IEnumerable<Email> Account_Email_SendersAccount
    {
      get
      {
        return this.GetRelatedEntities<Email>(nameof (Account_Email_SendersAccount), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Account_Email_SendersAccount));
        this.SetRelatedEntities<Email>(nameof (Account_Email_SendersAccount), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Account_Email_SendersAccount));
      }
    }

    [RelationshipSchemaName("Account_Emails")]
    public IEnumerable<Email> Account_Emails
    {
      get => this.GetRelatedEntities<Email>(nameof (Account_Emails), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Account_Emails));
        this.SetRelatedEntities<Email>(nameof (Account_Emails), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Account_Emails));
      }
    }

    [RelationshipSchemaName]
    public IEnumerable<Account> Referencedaccount_master_account
    {
      get
      {
        return this.GetRelatedEntities<Account>("account_master_account", new EntityRole?((EntityRole) 1));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencedaccount_master_account));
        this.SetRelatedEntities<Account>("account_master_account", new EntityRole?((EntityRole) 1), value);
        this.OnPropertyChanged(nameof (Referencedaccount_master_account));
      }
    }

    [RelationshipSchemaName]
    public IEnumerable<Account> Referencedaccount_parent_account
    {
      get
      {
        return this.GetRelatedEntities<Account>("account_parent_account", new EntityRole?((EntityRole) 1));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencedaccount_parent_account));
        this.SetRelatedEntities<Account>("account_parent_account", new EntityRole?((EntityRole) 1), value);
        this.OnPropertyChanged(nameof (Referencedaccount_parent_account));
      }
    }

    [RelationshipSchemaName("Account_Phonecalls")]
    public IEnumerable<PhoneCall> Account_Phonecalls
    {
      get => this.GetRelatedEntities<PhoneCall>(nameof (Account_Phonecalls), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Account_Phonecalls));
        this.SetRelatedEntities<PhoneCall>(nameof (Account_Phonecalls), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Account_Phonecalls));
      }
    }

    [RelationshipSchemaName("Account_Tasks")]
    public IEnumerable<Task> Account_Tasks
    {
      get => this.GetRelatedEntities<Task>(nameof (Account_Tasks), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Account_Tasks));
        this.SetRelatedEntities<Task>(nameof (Account_Tasks), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Account_Tasks));
      }
    }

    [RelationshipSchemaName("contact_customer_accounts")]
    public IEnumerable<Contact> contact_customer_accounts
    {
      get
      {
        return this.GetRelatedEntities<Contact>(nameof (contact_customer_accounts), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (contact_customer_accounts));
        this.SetRelatedEntities<Contact>(nameof (contact_customer_accounts), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (contact_customer_accounts));
      }
    }

    [RelationshipSchemaName]
    public IEnumerable<Account> Referencedmsa_account_managingpartner
    {
      get
      {
        return this.GetRelatedEntities<Account>("msa_account_managingpartner", new EntityRole?((EntityRole) 1));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencedmsa_account_managingpartner));
        this.SetRelatedEntities<Account>("msa_account_managingpartner", new EntityRole?((EntityRole) 1), value);
        this.OnPropertyChanged(nameof (Referencedmsa_account_managingpartner));
      }
    }

    [RelationshipSchemaName("msa_contact_managingpartner")]
    public IEnumerable<Contact> msa_contact_managingpartner
    {
      get
      {
        return this.GetRelatedEntities<Contact>(nameof (msa_contact_managingpartner), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msa_contact_managingpartner));
        this.SetRelatedEntities<Contact>(nameof (msa_contact_managingpartner), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msa_contact_managingpartner));
      }
    }

    [AttributeLogicalName("masterid")]
    [RelationshipSchemaName]
    public Account Referencingaccount_master_account
    {
      get
      {
        return this.GetRelatedEntity<Account>("account_master_account", new EntityRole?((EntityRole) 0));
      }
    }

    [AttributeLogicalName("parentaccountid")]
    [RelationshipSchemaName]
    public Account Referencingaccount_parent_account
    {
      get
      {
        return this.GetRelatedEntity<Account>("account_parent_account", new EntityRole?((EntityRole) 0));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencingaccount_parent_account));
        this.SetRelatedEntity<Account>("account_parent_account", new EntityRole?((EntityRole) 0), value);
        this.OnPropertyChanged(nameof (Referencingaccount_parent_account));
      }
    }

    [AttributeLogicalName("primarycontactid")]
    [RelationshipSchemaName("account_primary_contact")]
    public Contact account_primary_contact
    {
      get => this.GetRelatedEntity<Contact>(nameof (account_primary_contact), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (account_primary_contact));
        this.SetRelatedEntity<Contact>(nameof (account_primary_contact), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (account_primary_contact));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_accounts")]
    public BusinessUnit business_unit_accounts
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_accounts), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_accountbase_createdby")]
    public SystemUser lk_accountbase_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_accountbase_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_accountbase_createdonbehalfby")]
    public SystemUser lk_accountbase_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_accountbase_createdonbehalfby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_accountbase_modifiedby")]
    public SystemUser lk_accountbase_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_accountbase_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_accountbase_modifiedonbehalfby")]
    public SystemUser lk_accountbase_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_accountbase_modifiedonbehalfby), new EntityRole?());
      }
    }

    [AttributeLogicalName("msa_managingpartnerid")]
    [RelationshipSchemaName]
    public Account Referencingmsa_account_managingpartner
    {
      get
      {
        return this.GetRelatedEntity<Account>("msa_account_managingpartner", new EntityRole?((EntityRole) 0));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencingmsa_account_managingpartner));
        this.SetRelatedEntity<Account>("msa_account_managingpartner", new EntityRole?((EntityRole) 0), value);
        this.OnPropertyChanged(nameof (Referencingmsa_account_managingpartner));
      }
    }

    [AttributeLogicalName("stageid")]
    [RelationshipSchemaName("processstage_account")]
    public ProcessStage processstage_account
    {
      get => this.GetRelatedEntity<ProcessStage>(nameof (processstage_account), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (processstage_account));
        this.SetRelatedEntity<ProcessStage>(nameof (processstage_account), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (processstage_account));
      }
    }

    [AttributeLogicalName("preferredsystemuserid")]
    [RelationshipSchemaName("system_user_accounts")]
    public SystemUser system_user_accounts
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (system_user_accounts), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (system_user_accounts));
        this.SetRelatedEntity<SystemUser>(nameof (system_user_accounts), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (system_user_accounts));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_accounts")]
    public Team team_accounts
    {
      get => this.GetRelatedEntity<Team>(nameof (team_accounts), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_accounts")]
    public SystemUser user_accounts
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_accounts), new EntityRole?());
    }
  }
}
