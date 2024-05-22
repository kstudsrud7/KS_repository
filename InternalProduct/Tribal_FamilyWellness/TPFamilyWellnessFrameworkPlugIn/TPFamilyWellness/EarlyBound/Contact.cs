// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EarlyBound.Contact
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("contact")]
  [GeneratedCode("CrmSvcUtil", "9.0.0.9154")]
  public class Contact : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "contact";
    public const int EntityTypeCode = 2;

    public Contact()
      : base("contact")
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

    [AttributeLogicalName("accountid")]
    public EntityReference AccountId => this.GetAttributeValue<EntityReference>("accountid");

    [AttributeLogicalName("accountidname")]
    public string AccountIdName => this.GetAttributeValue<string>("accountidname");

    [AttributeLogicalName("accountidyominame")]
    public string AccountIdYomiName => this.GetAttributeValue<string>("accountidyominame");

    [AttributeLogicalName("accountrolecode")]
    public OptionSetValue AccountRoleCode
    {
      get => this.GetAttributeValue<OptionSetValue>("accountrolecode");
      set
      {
        this.OnPropertyChanging(nameof (AccountRoleCode));
        this.SetAttributeValue("accountrolecode", (object) value);
        this.OnPropertyChanged(nameof (AccountRoleCode));
      }
    }

    [AttributeLogicalName("accountrolecodename")]
    public object AccountRoleCodeName => this.GetAttributeValue<object>("accountrolecodename");

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

    [AttributeLogicalName("address3_addressid")]
    public Guid? Address3_AddressId
    {
      get => this.GetAttributeValue<Guid?>("address3_addressid");
      set
      {
        this.OnPropertyChanging(nameof (Address3_AddressId));
        this.SetAttributeValue("address3_addressid", (object) value);
        this.OnPropertyChanged(nameof (Address3_AddressId));
      }
    }

    [AttributeLogicalName("address3_addresstypecode")]
    public OptionSetValue Address3_AddressTypeCode
    {
      get => this.GetAttributeValue<OptionSetValue>("address3_addresstypecode");
      set
      {
        this.OnPropertyChanging(nameof (Address3_AddressTypeCode));
        this.SetAttributeValue("address3_addresstypecode", (object) value);
        this.OnPropertyChanged(nameof (Address3_AddressTypeCode));
      }
    }

    [AttributeLogicalName("address3_addresstypecodename")]
    public object Address3_AddressTypeCodeName
    {
      get => this.GetAttributeValue<object>("address3_addresstypecodename");
    }

    [AttributeLogicalName("address3_city")]
    public string Address3_City
    {
      get => this.GetAttributeValue<string>("address3_city");
      set
      {
        this.OnPropertyChanging(nameof (Address3_City));
        this.SetAttributeValue("address3_city", (object) value);
        this.OnPropertyChanged(nameof (Address3_City));
      }
    }

    [AttributeLogicalName("address3_composite")]
    public string Address3_Composite => this.GetAttributeValue<string>("address3_composite");

    [AttributeLogicalName("address3_country")]
    public string Address3_Country
    {
      get => this.GetAttributeValue<string>("address3_country");
      set
      {
        this.OnPropertyChanging(nameof (Address3_Country));
        this.SetAttributeValue("address3_country", (object) value);
        this.OnPropertyChanged(nameof (Address3_Country));
      }
    }

    [AttributeLogicalName("address3_county")]
    public string Address3_County
    {
      get => this.GetAttributeValue<string>("address3_county");
      set
      {
        this.OnPropertyChanging(nameof (Address3_County));
        this.SetAttributeValue("address3_county", (object) value);
        this.OnPropertyChanged(nameof (Address3_County));
      }
    }

    [AttributeLogicalName("address3_fax")]
    public string Address3_Fax
    {
      get => this.GetAttributeValue<string>("address3_fax");
      set
      {
        this.OnPropertyChanging(nameof (Address3_Fax));
        this.SetAttributeValue("address3_fax", (object) value);
        this.OnPropertyChanged(nameof (Address3_Fax));
      }
    }

    [AttributeLogicalName("address3_freighttermscode")]
    public OptionSetValue Address3_FreightTermsCode
    {
      get => this.GetAttributeValue<OptionSetValue>("address3_freighttermscode");
      set
      {
        this.OnPropertyChanging(nameof (Address3_FreightTermsCode));
        this.SetAttributeValue("address3_freighttermscode", (object) value);
        this.OnPropertyChanged(nameof (Address3_FreightTermsCode));
      }
    }

    [AttributeLogicalName("address3_freighttermscodename")]
    public object Address3_FreightTermsCodeName
    {
      get => this.GetAttributeValue<object>("address3_freighttermscodename");
    }

    [AttributeLogicalName("address3_latitude")]
    public double? Address3_Latitude
    {
      get => this.GetAttributeValue<double?>("address3_latitude");
      set
      {
        this.OnPropertyChanging(nameof (Address3_Latitude));
        this.SetAttributeValue("address3_latitude", (object) value);
        this.OnPropertyChanged(nameof (Address3_Latitude));
      }
    }

    [AttributeLogicalName("address3_line1")]
    public string Address3_Line1
    {
      get => this.GetAttributeValue<string>("address3_line1");
      set
      {
        this.OnPropertyChanging(nameof (Address3_Line1));
        this.SetAttributeValue("address3_line1", (object) value);
        this.OnPropertyChanged(nameof (Address3_Line1));
      }
    }

    [AttributeLogicalName("address3_line2")]
    public string Address3_Line2
    {
      get => this.GetAttributeValue<string>("address3_line2");
      set
      {
        this.OnPropertyChanging(nameof (Address3_Line2));
        this.SetAttributeValue("address3_line2", (object) value);
        this.OnPropertyChanged(nameof (Address3_Line2));
      }
    }

    [AttributeLogicalName("address3_line3")]
    public string Address3_Line3
    {
      get => this.GetAttributeValue<string>("address3_line3");
      set
      {
        this.OnPropertyChanging(nameof (Address3_Line3));
        this.SetAttributeValue("address3_line3", (object) value);
        this.OnPropertyChanged(nameof (Address3_Line3));
      }
    }

    [AttributeLogicalName("address3_longitude")]
    public double? Address3_Longitude
    {
      get => this.GetAttributeValue<double?>("address3_longitude");
      set
      {
        this.OnPropertyChanging(nameof (Address3_Longitude));
        this.SetAttributeValue("address3_longitude", (object) value);
        this.OnPropertyChanged(nameof (Address3_Longitude));
      }
    }

    [AttributeLogicalName("address3_name")]
    public string Address3_Name
    {
      get => this.GetAttributeValue<string>("address3_name");
      set
      {
        this.OnPropertyChanging(nameof (Address3_Name));
        this.SetAttributeValue("address3_name", (object) value);
        this.OnPropertyChanged(nameof (Address3_Name));
      }
    }

    [AttributeLogicalName("address3_postalcode")]
    public string Address3_PostalCode
    {
      get => this.GetAttributeValue<string>("address3_postalcode");
      set
      {
        this.OnPropertyChanging(nameof (Address3_PostalCode));
        this.SetAttributeValue("address3_postalcode", (object) value);
        this.OnPropertyChanged(nameof (Address3_PostalCode));
      }
    }

    [AttributeLogicalName("address3_postofficebox")]
    public string Address3_PostOfficeBox
    {
      get => this.GetAttributeValue<string>("address3_postofficebox");
      set
      {
        this.OnPropertyChanging(nameof (Address3_PostOfficeBox));
        this.SetAttributeValue("address3_postofficebox", (object) value);
        this.OnPropertyChanged(nameof (Address3_PostOfficeBox));
      }
    }

    [AttributeLogicalName("address3_primarycontactname")]
    public string Address3_PrimaryContactName
    {
      get => this.GetAttributeValue<string>("address3_primarycontactname");
      set
      {
        this.OnPropertyChanging(nameof (Address3_PrimaryContactName));
        this.SetAttributeValue("address3_primarycontactname", (object) value);
        this.OnPropertyChanged(nameof (Address3_PrimaryContactName));
      }
    }

    [AttributeLogicalName("address3_shippingmethodcode")]
    public OptionSetValue Address3_ShippingMethodCode
    {
      get => this.GetAttributeValue<OptionSetValue>("address3_shippingmethodcode");
      set
      {
        this.OnPropertyChanging(nameof (Address3_ShippingMethodCode));
        this.SetAttributeValue("address3_shippingmethodcode", (object) value);
        this.OnPropertyChanged(nameof (Address3_ShippingMethodCode));
      }
    }

    [AttributeLogicalName("address3_shippingmethodcodename")]
    public object Address3_ShippingMethodCodeName
    {
      get => this.GetAttributeValue<object>("address3_shippingmethodcodename");
    }

    [AttributeLogicalName("address3_stateorprovince")]
    public string Address3_StateOrProvince
    {
      get => this.GetAttributeValue<string>("address3_stateorprovince");
      set
      {
        this.OnPropertyChanging(nameof (Address3_StateOrProvince));
        this.SetAttributeValue("address3_stateorprovince", (object) value);
        this.OnPropertyChanged(nameof (Address3_StateOrProvince));
      }
    }

    [AttributeLogicalName("address3_telephone1")]
    public string Address3_Telephone1
    {
      get => this.GetAttributeValue<string>("address3_telephone1");
      set
      {
        this.OnPropertyChanging(nameof (Address3_Telephone1));
        this.SetAttributeValue("address3_telephone1", (object) value);
        this.OnPropertyChanged(nameof (Address3_Telephone1));
      }
    }

    [AttributeLogicalName("address3_telephone2")]
    public string Address3_Telephone2
    {
      get => this.GetAttributeValue<string>("address3_telephone2");
      set
      {
        this.OnPropertyChanging(nameof (Address3_Telephone2));
        this.SetAttributeValue("address3_telephone2", (object) value);
        this.OnPropertyChanged(nameof (Address3_Telephone2));
      }
    }

    [AttributeLogicalName("address3_telephone3")]
    public string Address3_Telephone3
    {
      get => this.GetAttributeValue<string>("address3_telephone3");
      set
      {
        this.OnPropertyChanging(nameof (Address3_Telephone3));
        this.SetAttributeValue("address3_telephone3", (object) value);
        this.OnPropertyChanged(nameof (Address3_Telephone3));
      }
    }

    [AttributeLogicalName("address3_upszone")]
    public string Address3_UPSZone
    {
      get => this.GetAttributeValue<string>("address3_upszone");
      set
      {
        this.OnPropertyChanging(nameof (Address3_UPSZone));
        this.SetAttributeValue("address3_upszone", (object) value);
        this.OnPropertyChanged(nameof (Address3_UPSZone));
      }
    }

    [AttributeLogicalName("address3_utcoffset")]
    public int? Address3_UTCOffset
    {
      get => this.GetAttributeValue<int?>("address3_utcoffset");
      set
      {
        this.OnPropertyChanging(nameof (Address3_UTCOffset));
        this.SetAttributeValue("address3_utcoffset", (object) value);
        this.OnPropertyChanged(nameof (Address3_UTCOffset));
      }
    }

    [AttributeLogicalName("adx_confirmremovepassword")]
    public bool? adx_ConfirmRemovePassword
    {
      get => this.GetAttributeValue<bool?>("adx_confirmremovepassword");
      set
      {
        this.OnPropertyChanging(nameof (adx_ConfirmRemovePassword));
        this.SetAttributeValue("adx_confirmremovepassword", (object) value);
        this.OnPropertyChanged(nameof (adx_ConfirmRemovePassword));
      }
    }

    [AttributeLogicalName("adx_confirmremovepasswordname")]
    public object adx_confirmremovepasswordName
    {
      get => this.GetAttributeValue<object>("adx_confirmremovepasswordname");
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

    [AttributeLogicalName("adx_identity_accessfailedcount")]
    public int? adx_identity_accessfailedcount
    {
      get => this.GetAttributeValue<int?>(nameof (adx_identity_accessfailedcount));
      set
      {
        this.OnPropertyChanging(nameof (adx_identity_accessfailedcount));
        this.SetAttributeValue(nameof (adx_identity_accessfailedcount), (object) value);
        this.OnPropertyChanged(nameof (adx_identity_accessfailedcount));
      }
    }

    [AttributeLogicalName("adx_identity_emailaddress1confirmed")]
    public bool? adx_identity_emailaddress1confirmed
    {
      get => this.GetAttributeValue<bool?>(nameof (adx_identity_emailaddress1confirmed));
      set
      {
        this.OnPropertyChanging(nameof (adx_identity_emailaddress1confirmed));
        this.SetAttributeValue(nameof (adx_identity_emailaddress1confirmed), (object) value);
        this.OnPropertyChanged(nameof (adx_identity_emailaddress1confirmed));
      }
    }

    [AttributeLogicalName("adx_identity_emailaddress1confirmedname")]
    public object adx_identity_emailaddress1confirmedName
    {
      get => this.GetAttributeValue<object>("adx_identity_emailaddress1confirmedname");
    }

    [AttributeLogicalName("adx_identity_lastsuccessfullogin")]
    public DateTime? adx_identity_lastsuccessfullogin
    {
      get => this.GetAttributeValue<DateTime?>(nameof (adx_identity_lastsuccessfullogin));
      set
      {
        this.OnPropertyChanging(nameof (adx_identity_lastsuccessfullogin));
        this.SetAttributeValue(nameof (adx_identity_lastsuccessfullogin), (object) value);
        this.OnPropertyChanged(nameof (adx_identity_lastsuccessfullogin));
      }
    }

    [AttributeLogicalName("adx_identity_locallogindisabled")]
    public bool? adx_identity_locallogindisabled
    {
      get => this.GetAttributeValue<bool?>(nameof (adx_identity_locallogindisabled));
      set
      {
        this.OnPropertyChanging(nameof (adx_identity_locallogindisabled));
        this.SetAttributeValue(nameof (adx_identity_locallogindisabled), (object) value);
        this.OnPropertyChanged(nameof (adx_identity_locallogindisabled));
      }
    }

    [AttributeLogicalName("adx_identity_locallogindisabledname")]
    public object adx_identity_locallogindisabledName
    {
      get => this.GetAttributeValue<object>("adx_identity_locallogindisabledname");
    }

    [AttributeLogicalName("adx_identity_lockoutenabled")]
    public bool? adx_identity_lockoutenabled
    {
      get => this.GetAttributeValue<bool?>(nameof (adx_identity_lockoutenabled));
      set
      {
        this.OnPropertyChanging(nameof (adx_identity_lockoutenabled));
        this.SetAttributeValue(nameof (adx_identity_lockoutenabled), (object) value);
        this.OnPropertyChanged(nameof (adx_identity_lockoutenabled));
      }
    }

    [AttributeLogicalName("adx_identity_lockoutenabledname")]
    public object adx_identity_lockoutenabledName
    {
      get => this.GetAttributeValue<object>("adx_identity_lockoutenabledname");
    }

    [AttributeLogicalName("adx_identity_lockoutenddate")]
    public DateTime? adx_identity_lockoutenddate
    {
      get => this.GetAttributeValue<DateTime?>(nameof (adx_identity_lockoutenddate));
      set
      {
        this.OnPropertyChanging(nameof (adx_identity_lockoutenddate));
        this.SetAttributeValue(nameof (adx_identity_lockoutenddate), (object) value);
        this.OnPropertyChanged(nameof (adx_identity_lockoutenddate));
      }
    }

    [AttributeLogicalName("adx_identity_logonenabled")]
    public bool? adx_identity_logonenabled
    {
      get => this.GetAttributeValue<bool?>(nameof (adx_identity_logonenabled));
      set
      {
        this.OnPropertyChanging(nameof (adx_identity_logonenabled));
        this.SetAttributeValue(nameof (adx_identity_logonenabled), (object) value);
        this.OnPropertyChanged(nameof (adx_identity_logonenabled));
      }
    }

    [AttributeLogicalName("adx_identity_logonenabledname")]
    public object adx_identity_logonenabledName
    {
      get => this.GetAttributeValue<object>("adx_identity_logonenabledname");
    }

    [AttributeLogicalName("adx_identity_mobilephoneconfirmed")]
    public bool? adx_identity_mobilephoneconfirmed
    {
      get => this.GetAttributeValue<bool?>(nameof (adx_identity_mobilephoneconfirmed));
      set
      {
        this.OnPropertyChanging(nameof (adx_identity_mobilephoneconfirmed));
        this.SetAttributeValue(nameof (adx_identity_mobilephoneconfirmed), (object) value);
        this.OnPropertyChanged(nameof (adx_identity_mobilephoneconfirmed));
      }
    }

    [AttributeLogicalName("adx_identity_mobilephoneconfirmedname")]
    public object adx_identity_mobilephoneconfirmedName
    {
      get => this.GetAttributeValue<object>("adx_identity_mobilephoneconfirmedname");
    }

    [AttributeLogicalName("adx_identity_newpassword")]
    public string adx_identity_newpassword
    {
      get => this.GetAttributeValue<string>(nameof (adx_identity_newpassword));
      set
      {
        this.OnPropertyChanging(nameof (adx_identity_newpassword));
        this.SetAttributeValue(nameof (adx_identity_newpassword), (object) value);
        this.OnPropertyChanged(nameof (adx_identity_newpassword));
      }
    }

    [AttributeLogicalName("adx_identity_passwordhash")]
    public string adx_identity_passwordhash
    {
      get => this.GetAttributeValue<string>(nameof (adx_identity_passwordhash));
      set
      {
        this.OnPropertyChanging(nameof (adx_identity_passwordhash));
        this.SetAttributeValue(nameof (adx_identity_passwordhash), (object) value);
        this.OnPropertyChanged(nameof (adx_identity_passwordhash));
      }
    }

    [AttributeLogicalName("adx_identity_securitystamp")]
    public string adx_identity_securitystamp
    {
      get => this.GetAttributeValue<string>(nameof (adx_identity_securitystamp));
      set
      {
        this.OnPropertyChanging(nameof (adx_identity_securitystamp));
        this.SetAttributeValue(nameof (adx_identity_securitystamp), (object) value);
        this.OnPropertyChanged(nameof (adx_identity_securitystamp));
      }
    }

    [AttributeLogicalName("adx_identity_twofactorenabled")]
    public bool? adx_identity_twofactorenabled
    {
      get => this.GetAttributeValue<bool?>(nameof (adx_identity_twofactorenabled));
      set
      {
        this.OnPropertyChanging(nameof (adx_identity_twofactorenabled));
        this.SetAttributeValue(nameof (adx_identity_twofactorenabled), (object) value);
        this.OnPropertyChanged(nameof (adx_identity_twofactorenabled));
      }
    }

    [AttributeLogicalName("adx_identity_twofactorenabledname")]
    public object adx_identity_twofactorenabledName
    {
      get => this.GetAttributeValue<object>("adx_identity_twofactorenabledname");
    }

    [AttributeLogicalName("adx_identity_username")]
    public string adx_identity_username
    {
      get => this.GetAttributeValue<string>(nameof (adx_identity_username));
      set
      {
        this.OnPropertyChanging(nameof (adx_identity_username));
        this.SetAttributeValue(nameof (adx_identity_username), (object) value);
        this.OnPropertyChanged(nameof (adx_identity_username));
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

    [AttributeLogicalName("adx_organizationname")]
    public string Adx_OrganizationName
    {
      get => this.GetAttributeValue<string>("adx_organizationname");
      set
      {
        this.OnPropertyChanging(nameof (Adx_OrganizationName));
        this.SetAttributeValue("adx_organizationname", (object) value);
        this.OnPropertyChanged(nameof (Adx_OrganizationName));
      }
    }

    [AttributeLogicalName("adx_preferredlanguageid")]
    public EntityReference adx_preferredlanguageid
    {
      get => this.GetAttributeValue<EntityReference>(nameof (adx_preferredlanguageid));
      set
      {
        this.OnPropertyChanging(nameof (adx_preferredlanguageid));
        this.SetAttributeValue(nameof (adx_preferredlanguageid), (object) value);
        this.OnPropertyChanged(nameof (adx_preferredlanguageid));
      }
    }

    [AttributeLogicalName("adx_preferredlanguageidname")]
    public string adx_preferredlanguageidName
    {
      get => this.GetAttributeValue<string>("adx_preferredlanguageidname");
    }

    [AttributeLogicalName("adx_profilealert")]
    public bool? adx_profilealert
    {
      get => this.GetAttributeValue<bool?>(nameof (adx_profilealert));
      set
      {
        this.OnPropertyChanging(nameof (adx_profilealert));
        this.SetAttributeValue(nameof (adx_profilealert), (object) value);
        this.OnPropertyChanged(nameof (adx_profilealert));
      }
    }

    [AttributeLogicalName("adx_profilealertdate")]
    public DateTime? adx_profilealertdate
    {
      get => this.GetAttributeValue<DateTime?>(nameof (adx_profilealertdate));
      set
      {
        this.OnPropertyChanging(nameof (adx_profilealertdate));
        this.SetAttributeValue(nameof (adx_profilealertdate), (object) value);
        this.OnPropertyChanged(nameof (adx_profilealertdate));
      }
    }

    [AttributeLogicalName("adx_profilealertinstructions")]
    public string adx_profilealertinstructions
    {
      get => this.GetAttributeValue<string>(nameof (adx_profilealertinstructions));
      set
      {
        this.OnPropertyChanging(nameof (adx_profilealertinstructions));
        this.SetAttributeValue(nameof (adx_profilealertinstructions), (object) value);
        this.OnPropertyChanged(nameof (adx_profilealertinstructions));
      }
    }

    [AttributeLogicalName("adx_profilealertname")]
    public object adx_profilealertName => this.GetAttributeValue<object>("adx_profilealertname");

    [AttributeLogicalName("adx_profileisanonymous")]
    public bool? Adx_ProfileIsAnonymous
    {
      get => this.GetAttributeValue<bool?>("adx_profileisanonymous");
      set
      {
        this.OnPropertyChanging(nameof (Adx_ProfileIsAnonymous));
        this.SetAttributeValue("adx_profileisanonymous", (object) value);
        this.OnPropertyChanged(nameof (Adx_ProfileIsAnonymous));
      }
    }

    [AttributeLogicalName("adx_profileisanonymousname")]
    public object adx_profileisanonymousName
    {
      get => this.GetAttributeValue<object>("adx_profileisanonymousname");
    }

    [AttributeLogicalName("adx_profilelastactivity")]
    public DateTime? Adx_ProfileLastActivity
    {
      get => this.GetAttributeValue<DateTime?>("adx_profilelastactivity");
      set
      {
        this.OnPropertyChanging(nameof (Adx_ProfileLastActivity));
        this.SetAttributeValue("adx_profilelastactivity", (object) value);
        this.OnPropertyChanged(nameof (Adx_ProfileLastActivity));
      }
    }

    [AttributeLogicalName("adx_profilemodifiedon")]
    public DateTime? adx_profilemodifiedon
    {
      get => this.GetAttributeValue<DateTime?>(nameof (adx_profilemodifiedon));
      set
      {
        this.OnPropertyChanging(nameof (adx_profilemodifiedon));
        this.SetAttributeValue(nameof (adx_profilemodifiedon), (object) value);
        this.OnPropertyChanged(nameof (adx_profilemodifiedon));
      }
    }

    [AttributeLogicalName("adx_publicprofilecopy")]
    public string adx_PublicProfileCopy
    {
      get => this.GetAttributeValue<string>("adx_publicprofilecopy");
      set
      {
        this.OnPropertyChanging(nameof (adx_PublicProfileCopy));
        this.SetAttributeValue("adx_publicprofilecopy", (object) value);
        this.OnPropertyChanged(nameof (adx_PublicProfileCopy));
      }
    }

    [AttributeLogicalName("adx_timezone")]
    public int? Adx_TimeZone
    {
      get => this.GetAttributeValue<int?>("adx_timezone");
      set
      {
        this.OnPropertyChanging(nameof (Adx_TimeZone));
        this.SetAttributeValue("adx_timezone", (object) value);
        this.OnPropertyChanged(nameof (Adx_TimeZone));
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

    [AttributeLogicalName("ait_age")]
    public int? ait_age
    {
      get => this.GetAttributeValue<int?>(nameof (ait_age));
      set
      {
        this.OnPropertyChanging(nameof (ait_age));
        this.SetAttributeValue(nameof (ait_age), (object) value);
        this.OnPropertyChanged(nameof (ait_age));
      }
    }

    [AttributeLogicalName("ait_agegroup")]
    public OptionSetValue ait_agegroup
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_agegroup));
      set
      {
        this.OnPropertyChanging(nameof (ait_agegroup));
        this.SetAttributeValue(nameof (ait_agegroup), (object) value);
        this.OnPropertyChanged(nameof (ait_agegroup));
      }
    }

    [AttributeLogicalName("ait_agegroupname")]
    public object ait_agegroupName => this.GetAttributeValue<object>("ait_agegroupname");

    [AttributeLogicalName("ait_bandid")]
    public EntityReference ait_bandid
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_bandid));
      set
      {
        this.OnPropertyChanging(nameof (ait_bandid));
        this.SetAttributeValue(nameof (ait_bandid), (object) value);
        this.OnPropertyChanged(nameof (ait_bandid));
      }
    }

    [AttributeLogicalName("ait_bandidname")]
    public string ait_bandidName => this.GetAttributeValue<string>("ait_bandidname");

    [AttributeLogicalName("ait_birthrecord")]
    public EntityReference ait_birthrecord
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_birthrecord));
      set
      {
        this.OnPropertyChanging(nameof (ait_birthrecord));
        this.SetAttributeValue(nameof (ait_birthrecord), (object) value);
        this.OnPropertyChanged(nameof (ait_birthrecord));
      }
    }

    [AttributeLogicalName("ait_birthrecordname")]
    public string ait_birthrecordName => this.GetAttributeValue<string>("ait_birthrecordname");

    [AttributeLogicalName("ait_certificationidcard")]
    public EntityReference ait_certificationidcard
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_certificationidcard));
      set
      {
        this.OnPropertyChanging(nameof (ait_certificationidcard));
        this.SetAttributeValue(nameof (ait_certificationidcard), (object) value);
        this.OnPropertyChanged(nameof (ait_certificationidcard));
      }
    }

    [AttributeLogicalName("ait_certificationidcardname")]
    public string ait_certificationidcardName
    {
      get => this.GetAttributeValue<string>("ait_certificationidcardname");
    }

    [AttributeLogicalName("ait_clientprofile")]
    public EntityReference ait_ClientProfile
    {
      get => this.GetAttributeValue<EntityReference>("ait_clientprofile");
      set
      {
        this.OnPropertyChanging(nameof (ait_ClientProfile));
        this.SetAttributeValue("ait_clientprofile", (object) value);
        this.OnPropertyChanged(nameof (ait_ClientProfile));
      }
    }

    [AttributeLogicalName("ait_clientprofilename")]
    public string ait_ClientProfileName => this.GetAttributeValue<string>("ait_clientprofilename");

    [AttributeLogicalName("ait_courtprofile")]
    public EntityReference ait_CourtProfile
    {
      get => this.GetAttributeValue<EntityReference>("ait_courtprofile");
      set
      {
        this.OnPropertyChanging(nameof (ait_CourtProfile));
        this.SetAttributeValue("ait_courtprofile", (object) value);
        this.OnPropertyChanged(nameof (ait_CourtProfile));
      }
    }

    [AttributeLogicalName("ait_courtprofilename")]
    public string ait_CourtProfileName => this.GetAttributeValue<string>("ait_courtprofilename");

    [AttributeLogicalName("ait_currentlyemployed")]
    public OptionSetValue ait_currentlyemployed
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_currentlyemployed));
      set
      {
        this.OnPropertyChanging(nameof (ait_currentlyemployed));
        this.SetAttributeValue(nameof (ait_currentlyemployed), (object) value);
        this.OnPropertyChanged(nameof (ait_currentlyemployed));
      }
    }

    [AttributeLogicalName("ait_currentlyemployedname")]
    public object ait_currentlyemployedName
    {
      get => this.GetAttributeValue<object>("ait_currentlyemployedname");
    }

    [AttributeLogicalName("ait_deathdate")]
    public DateTime? ait_deathdate
    {
      get => this.GetAttributeValue<DateTime?>(nameof (ait_deathdate));
      set
      {
        this.OnPropertyChanging(nameof (ait_deathdate));
        this.SetAttributeValue(nameof (ait_deathdate), (object) value);
        this.OnPropertyChanged(nameof (ait_deathdate));
      }
    }

    [AttributeLogicalName("ait_deathrecord")]
    public EntityReference ait_deathrecord
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_deathrecord));
      set
      {
        this.OnPropertyChanging(nameof (ait_deathrecord));
        this.SetAttributeValue(nameof (ait_deathrecord), (object) value);
        this.OnPropertyChanged(nameof (ait_deathrecord));
      }
    }

    [AttributeLogicalName("ait_deathrecordname")]
    public string ait_deathrecordName => this.GetAttributeValue<string>("ait_deathrecordname");

    [AttributeLogicalName("ait_disabled")]
    public OptionSetValue ait_disabled
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_disabled));
      set
      {
        this.OnPropertyChanging(nameof (ait_disabled));
        this.SetAttributeValue(nameof (ait_disabled), (object) value);
        this.OnPropertyChanged(nameof (ait_disabled));
      }
    }

    [AttributeLogicalName("ait_disabledname")]
    public object ait_disabledName => this.GetAttributeValue<object>("ait_disabledname");

    [AttributeLogicalName("ait_emergencycontact")]
    public EntityReference ait_emergencycontact
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_emergencycontact));
      set
      {
        this.OnPropertyChanging(nameof (ait_emergencycontact));
        this.SetAttributeValue(nameof (ait_emergencycontact), (object) value);
        this.OnPropertyChanged(nameof (ait_emergencycontact));
      }
    }

    [AttributeLogicalName("ait_emergencycontactname")]
    public string ait_emergencycontactName
    {
      get => this.GetAttributeValue<string>("ait_emergencycontactname");
    }

    [AttributeLogicalName("ait_employeeidcard")]
    public EntityReference ait_employeeidcard
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_employeeidcard));
      set
      {
        this.OnPropertyChanging(nameof (ait_employeeidcard));
        this.SetAttributeValue(nameof (ait_employeeidcard), (object) value);
        this.OnPropertyChanged(nameof (ait_employeeidcard));
      }
    }

    [AttributeLogicalName("ait_employeeidcardname")]
    public string ait_employeeidcardName
    {
      get => this.GetAttributeValue<string>("ait_employeeidcardname");
    }

    [AttributeLogicalName("ait_entityimagestring")]
    public string ait_entityimagestring
    {
      get => this.GetAttributeValue<string>(nameof (ait_entityimagestring));
      set
      {
        this.OnPropertyChanging(nameof (ait_entityimagestring));
        this.SetAttributeValue(nameof (ait_entityimagestring), (object) value);
        this.OnPropertyChanged(nameof (ait_entityimagestring));
      }
    }

    [AttributeLogicalName("ait_ethnicity")]
    public OptionSetValue ait_ethnicity
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_ethnicity));
      set
      {
        this.OnPropertyChanging(nameof (ait_ethnicity));
        this.SetAttributeValue(nameof (ait_ethnicity), (object) value);
        this.OnPropertyChanged(nameof (ait_ethnicity));
      }
    }

    [AttributeLogicalName("ait_ethnicityname")]
    public object ait_ethnicityName => this.GetAttributeValue<object>("ait_ethnicityname");

    [AttributeLogicalName("ait_eyecolor")]
    public OptionSetValue ait_eyecolor
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_eyecolor));
      set
      {
        this.OnPropertyChanging(nameof (ait_eyecolor));
        this.SetAttributeValue(nameof (ait_eyecolor), (object) value);
        this.OnPropertyChanged(nameof (ait_eyecolor));
      }
    }

    [AttributeLogicalName("ait_eyecolorname")]
    public object ait_eyecolorName => this.GetAttributeValue<object>("ait_eyecolorname");

    [AttributeLogicalName("ait_familygroup")]
    public EntityReference ait_familygroup
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_familygroup));
      set
      {
        this.OnPropertyChanging(nameof (ait_familygroup));
        this.SetAttributeValue(nameof (ait_familygroup), (object) value);
        this.OnPropertyChanged(nameof (ait_familygroup));
      }
    }

    [AttributeLogicalName("ait_familygroupname")]
    public string ait_familygroupName => this.GetAttributeValue<string>("ait_familygroupname");

    [AttributeLogicalName("ait_federalcdibid")]
    public string ait_federalcdibid
    {
      get => this.GetAttributeValue<string>(nameof (ait_federalcdibid));
      set
      {
        this.OnPropertyChanging(nameof (ait_federalcdibid));
        this.SetAttributeValue(nameof (ait_federalcdibid), (object) value);
        this.OnPropertyChanged(nameof (ait_federalcdibid));
      }
    }

    [AttributeLogicalName("ait_federalcdibstatus")]
    public OptionSetValue ait_federalcdibstatus
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_federalcdibstatus));
      set
      {
        this.OnPropertyChanging(nameof (ait_federalcdibstatus));
        this.SetAttributeValue(nameof (ait_federalcdibstatus), (object) value);
        this.OnPropertyChanged(nameof (ait_federalcdibstatus));
      }
    }

    [AttributeLogicalName("ait_federalcdibstatuseffectivedate")]
    public DateTime? ait_federalcdibstatuseffectivedate
    {
      get => this.GetAttributeValue<DateTime?>(nameof (ait_federalcdibstatuseffectivedate));
      set
      {
        this.OnPropertyChanging(nameof (ait_federalcdibstatuseffectivedate));
        this.SetAttributeValue(nameof (ait_federalcdibstatuseffectivedate), (object) value);
        this.OnPropertyChanged(nameof (ait_federalcdibstatuseffectivedate));
      }
    }

    [AttributeLogicalName("ait_federalcdibstatusname")]
    public object ait_federalcdibstatusName
    {
      get => this.GetAttributeValue<object>("ait_federalcdibstatusname");
    }

    [AttributeLogicalName("ait_gender")]
    public OptionSetValue ait_gender
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_gender));
      set
      {
        this.OnPropertyChanging(nameof (ait_gender));
        this.SetAttributeValue(nameof (ait_gender), (object) value);
        this.OnPropertyChanged(nameof (ait_gender));
      }
    }

    [AttributeLogicalName("ait_gendername")]
    public object ait_genderName => this.GetAttributeValue<object>("ait_gendername");

    [AttributeLogicalName("ait_haircolor")]
    public OptionSetValue ait_haircolor
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_haircolor));
      set
      {
        this.OnPropertyChanging(nameof (ait_haircolor));
        this.SetAttributeValue(nameof (ait_haircolor), (object) value);
        this.OnPropertyChanged(nameof (ait_haircolor));
      }
    }

    [AttributeLogicalName("ait_haircolorname")]
    public object ait_haircolorName => this.GetAttributeValue<object>("ait_haircolorname");

    [AttributeLogicalName("ait_height")]
    public Decimal? ait_height
    {
      get => this.GetAttributeValue<Decimal?>(nameof (ait_height));
      set
      {
        this.OnPropertyChanging(nameof (ait_height));
        this.SetAttributeValue(nameof (ait_height), (object) value);
        this.OnPropertyChanged(nameof (ait_height));
      }
    }

    [AttributeLogicalName("ait_heightstring")]
    public string ait_heightstring
    {
      get => this.GetAttributeValue<string>(nameof (ait_heightstring));
      set
      {
        this.OnPropertyChanging(nameof (ait_heightstring));
        this.SetAttributeValue(nameof (ait_heightstring), (object) value);
        this.OnPropertyChanged(nameof (ait_heightstring));
      }
    }

    [AttributeLogicalName("ait_household")]
    public EntityReference ait_household
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_household));
      set
      {
        this.OnPropertyChanging(nameof (ait_household));
        this.SetAttributeValue(nameof (ait_household), (object) value);
        this.OnPropertyChanged(nameof (ait_household));
      }
    }

    [AttributeLogicalName("ait_householdmember")]
    public EntityReference ait_householdmember
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_householdmember));
      set
      {
        this.OnPropertyChanging(nameof (ait_householdmember));
        this.SetAttributeValue(nameof (ait_householdmember), (object) value);
        this.OnPropertyChanged(nameof (ait_householdmember));
      }
    }

    [AttributeLogicalName("ait_householdmembername")]
    public string ait_householdmemberName
    {
      get => this.GetAttributeValue<string>("ait_householdmembername");
    }

    [AttributeLogicalName("ait_householdname")]
    public string ait_householdName => this.GetAttributeValue<string>("ait_householdname");

    [AttributeLogicalName("ait_incarcerated")]
    public bool? ait_incarcerated
    {
      get => this.GetAttributeValue<bool?>(nameof (ait_incarcerated));
      set
      {
        this.OnPropertyChanging(nameof (ait_incarcerated));
        this.SetAttributeValue(nameof (ait_incarcerated), (object) value);
        this.OnPropertyChanged(nameof (ait_incarcerated));
      }
    }

    [AttributeLogicalName("ait_incarceratedname")]
    public object ait_incarceratedName => this.GetAttributeValue<object>("ait_incarceratedname");

    [AttributeLogicalName("ait_isdeceased")]
    public bool? ait_IsDeceased => this.GetAttributeValue<bool?>("ait_isdeceased");

    [AttributeLogicalName("ait_isdeceasedname")]
    public object ait_isdeceasedName => this.GetAttributeValue<object>("ait_isdeceasedname");

    [AttributeLogicalName("ait_maritalstatus")]
    public OptionSetValue ait_maritalstatus
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_maritalstatus));
      set
      {
        this.OnPropertyChanging(nameof (ait_maritalstatus));
        this.SetAttributeValue(nameof (ait_maritalstatus), (object) value);
        this.OnPropertyChanged(nameof (ait_maritalstatus));
      }
    }

    [AttributeLogicalName("ait_maritalstatusname")]
    public object ait_maritalstatusName => this.GetAttributeValue<object>("ait_maritalstatusname");

    [AttributeLogicalName("ait_medicalconditions")]
    public string ait_medicalconditions
    {
      get => this.GetAttributeValue<string>(nameof (ait_medicalconditions));
      set
      {
        this.OnPropertyChanging(nameof (ait_medicalconditions));
        this.SetAttributeValue(nameof (ait_medicalconditions), (object) value);
        this.OnPropertyChanged(nameof (ait_medicalconditions));
      }
    }

    [AttributeLogicalName("ait_memberprofile")]
    public EntityReference ait_MemberProfile
    {
      get => this.GetAttributeValue<EntityReference>("ait_memberprofile");
      set
      {
        this.OnPropertyChanging(nameof (ait_MemberProfile));
        this.SetAttributeValue("ait_memberprofile", (object) value);
        this.OnPropertyChanged(nameof (ait_MemberProfile));
      }
    }

    [AttributeLogicalName("ait_memberprofilename")]
    public string ait_MemberProfileName => this.GetAttributeValue<string>("ait_memberprofilename");

    [AttributeLogicalName("ait_membershipstatus")]
    public OptionSetValue ait_membershipstatus
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_membershipstatus));
      set
      {
        this.OnPropertyChanging(nameof (ait_membershipstatus));
        this.SetAttributeValue(nameof (ait_membershipstatus), (object) value);
        this.OnPropertyChanged(nameof (ait_membershipstatus));
      }
    }

    [AttributeLogicalName("ait_membershipstatusname")]
    public object ait_membershipstatusName
    {
      get => this.GetAttributeValue<object>("ait_membershipstatusname");
    }

    [AttributeLogicalName("ait_militarystatus")]
    public OptionSetValue ait_militarystatus
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_militarystatus));
      set
      {
        this.OnPropertyChanging(nameof (ait_militarystatus));
        this.SetAttributeValue(nameof (ait_militarystatus), (object) value);
        this.OnPropertyChanged(nameof (ait_militarystatus));
      }
    }

    [AttributeLogicalName("ait_militarystatusname")]
    public object ait_militarystatusName
    {
      get => this.GetAttributeValue<object>("ait_militarystatusname");
    }

    [AttributeLogicalName("ait_primaryaddress")]
    public string ait_primaryaddress
    {
      get => this.GetAttributeValue<string>(nameof (ait_primaryaddress));
      set
      {
        this.OnPropertyChanging(nameof (ait_primaryaddress));
        this.SetAttributeValue(nameof (ait_primaryaddress), (object) value);
        this.OnPropertyChanged(nameof (ait_primaryaddress));
      }
    }

    [AttributeLogicalName("ait_primaryemail")]
    public string ait_primaryemail
    {
      get => this.GetAttributeValue<string>(nameof (ait_primaryemail));
      set
      {
        this.OnPropertyChanging(nameof (ait_primaryemail));
        this.SetAttributeValue(nameof (ait_primaryemail), (object) value);
        this.OnPropertyChanged(nameof (ait_primaryemail));
      }
    }

    [AttributeLogicalName("ait_primarylanguage")]
    public EntityReference ait_primarylanguage
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_primarylanguage));
      set
      {
        this.OnPropertyChanging(nameof (ait_primarylanguage));
        this.SetAttributeValue(nameof (ait_primarylanguage), (object) value);
        this.OnPropertyChanged(nameof (ait_primarylanguage));
      }
    }

    [AttributeLogicalName("ait_primarylanguagename")]
    public string ait_primarylanguageName
    {
      get => this.GetAttributeValue<string>("ait_primarylanguagename");
    }

    [AttributeLogicalName("ait_primaryphone")]
    public string ait_primaryphone
    {
      get => this.GetAttributeValue<string>(nameof (ait_primaryphone));
      set
      {
        this.OnPropertyChanging(nameof (ait_primaryphone));
        this.SetAttributeValue(nameof (ait_primaryphone), (object) value);
        this.OnPropertyChanged(nameof (ait_primaryphone));
      }
    }

    [AttributeLogicalName("ait_race")]
    public OptionSetValue ait_race
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_race));
      set
      {
        this.OnPropertyChanging(nameof (ait_race));
        this.SetAttributeValue(nameof (ait_race), (object) value);
        this.OnPropertyChanged(nameof (ait_race));
      }
    }

    [AttributeLogicalName("ait_racename")]
    public object ait_raceName => this.GetAttributeValue<object>("ait_racename");

    [AttributeLogicalName("ait_registeredwithselectiveservice")]
    public bool? ait_registeredwithselectiveservice
    {
      get => this.GetAttributeValue<bool?>(nameof (ait_registeredwithselectiveservice));
      set
      {
        this.OnPropertyChanging(nameof (ait_registeredwithselectiveservice));
        this.SetAttributeValue(nameof (ait_registeredwithselectiveservice), (object) value);
        this.OnPropertyChanged(nameof (ait_registeredwithselectiveservice));
      }
    }

    [AttributeLogicalName("ait_registeredwithselectiveservicename")]
    public object ait_registeredwithselectiveserviceName
    {
      get => this.GetAttributeValue<object>("ait_registeredwithselectiveservicename");
    }

    [AttributeLogicalName("ait_reservation")]
    public EntityReference ait_reservation
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_reservation));
      set
      {
        this.OnPropertyChanging(nameof (ait_reservation));
        this.SetAttributeValue(nameof (ait_reservation), (object) value);
        this.OnPropertyChanged(nameof (ait_reservation));
      }
    }

    [AttributeLogicalName("ait_reservationname")]
    public string ait_reservationName => this.GetAttributeValue<string>("ait_reservationname");

    [AttributeLogicalName("ait_shareholderid")]
    public string ait_ShareholderID
    {
      get => this.GetAttributeValue<string>("ait_shareholderid");
      set
      {
        this.OnPropertyChanging(nameof (ait_ShareholderID));
        this.SetAttributeValue("ait_shareholderid", (object) value);
        this.OnPropertyChanged(nameof (ait_ShareholderID));
      }
    }

    [AttributeLogicalName("ait_sourcesystemid")]
    public string ait_sourcesystemid
    {
      get => this.GetAttributeValue<string>(nameof (ait_sourcesystemid));
      set
      {
        this.OnPropertyChanging(nameof (ait_sourcesystemid));
        this.SetAttributeValue(nameof (ait_sourcesystemid), (object) value);
        this.OnPropertyChanged(nameof (ait_sourcesystemid));
      }
    }

    [AttributeLogicalName("ait_ssn")]
    public string ait_ssn
    {
      get => this.GetAttributeValue<string>(nameof (ait_ssn));
      set
      {
        this.OnPropertyChanging(nameof (ait_ssn));
        this.SetAttributeValue(nameof (ait_ssn), (object) value);
        this.OnPropertyChanged(nameof (ait_ssn));
      }
    }

    [AttributeLogicalName("ait_ssnlast4")]
    public string ait_ssnlast4
    {
      get => this.GetAttributeValue<string>(nameof (ait_ssnlast4));
      set
      {
        this.OnPropertyChanging(nameof (ait_ssnlast4));
        this.SetAttributeValue(nameof (ait_ssnlast4), (object) value);
        this.OnPropertyChanged(nameof (ait_ssnlast4));
      }
    }

    [AttributeLogicalName("ait_totalearnedincome")]
    public Money ait_totalearnedincome
    {
      get => this.GetAttributeValue<Money>(nameof (ait_totalearnedincome));
      set
      {
        this.OnPropertyChanging(nameof (ait_totalearnedincome));
        this.SetAttributeValue(nameof (ait_totalearnedincome), (object) value);
        this.OnPropertyChanged(nameof (ait_totalearnedincome));
      }
    }

    [AttributeLogicalName("ait_totalearnedincome_base")]
    public Money ait_totalearnedincome_Base
    {
      get => this.GetAttributeValue<Money>("ait_totalearnedincome_base");
    }

    [AttributeLogicalName("ait_totalexpenses")]
    public Money ait_totalexpenses
    {
      get => this.GetAttributeValue<Money>(nameof (ait_totalexpenses));
      set
      {
        this.OnPropertyChanging(nameof (ait_totalexpenses));
        this.SetAttributeValue(nameof (ait_totalexpenses), (object) value);
        this.OnPropertyChanged(nameof (ait_totalexpenses));
      }
    }

    [AttributeLogicalName("ait_totalexpenses_base")]
    public Money ait_totalexpenses_Base => this.GetAttributeValue<Money>("ait_totalexpenses_base");

    [AttributeLogicalName("ait_totalincome")]
    public Money ait_totalincome
    {
      get => this.GetAttributeValue<Money>(nameof (ait_totalincome));
      set
      {
        this.OnPropertyChanging(nameof (ait_totalincome));
        this.SetAttributeValue(nameof (ait_totalincome), (object) value);
        this.OnPropertyChanged(nameof (ait_totalincome));
      }
    }

    [AttributeLogicalName("ait_totalincome_base")]
    public Money ait_totalincome_Base => this.GetAttributeValue<Money>("ait_totalincome_base");

    [AttributeLogicalName("ait_totalnetamount")]
    public Money ait_totalnetamount
    {
      get => this.GetAttributeValue<Money>(nameof (ait_totalnetamount));
      set
      {
        this.OnPropertyChanging(nameof (ait_totalnetamount));
        this.SetAttributeValue(nameof (ait_totalnetamount), (object) value);
        this.OnPropertyChanged(nameof (ait_totalnetamount));
      }
    }

    [AttributeLogicalName("ait_totalnetamount_base")]
    public Money ait_totalnetamount_Base
    {
      get => this.GetAttributeValue<Money>("ait_totalnetamount_base");
    }

    [AttributeLogicalName("ait_totalnetamount_date")]
    public DateTime? ait_totalnetamount_Date
    {
      get => this.GetAttributeValue<DateTime?>("ait_totalnetamount_date");
    }

    [AttributeLogicalName("ait_totalnetamount_state")]
    public int? ait_totalnetamount_State
    {
      get => this.GetAttributeValue<int?>("ait_totalnetamount_state");
    }

    [AttributeLogicalName("ait_totalunearnedincome")]
    public Money ait_totalunearnedincome
    {
      get => this.GetAttributeValue<Money>(nameof (ait_totalunearnedincome));
      set
      {
        this.OnPropertyChanging(nameof (ait_totalunearnedincome));
        this.SetAttributeValue(nameof (ait_totalunearnedincome), (object) value);
        this.OnPropertyChanged(nameof (ait_totalunearnedincome));
      }
    }

    [AttributeLogicalName("ait_totalunearnedincome_base")]
    public Money ait_totalunearnedincome_Base
    {
      get => this.GetAttributeValue<Money>("ait_totalunearnedincome_base");
    }

    [AttributeLogicalName("ait_tribalid")]
    public string ait_tribalid
    {
      get => this.GetAttributeValue<string>(nameof (ait_tribalid));
      set
      {
        this.OnPropertyChanging(nameof (ait_tribalid));
        this.SetAttributeValue(nameof (ait_tribalid), (object) value);
        this.OnPropertyChanged(nameof (ait_tribalid));
      }
    }

    [AttributeLogicalName("ait_tribe")]
    public EntityReference ait_tribe
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_tribe));
      set
      {
        this.OnPropertyChanging(nameof (ait_tribe));
        this.SetAttributeValue(nameof (ait_tribe), (object) value);
        this.OnPropertyChanged(nameof (ait_tribe));
      }
    }

    [AttributeLogicalName("ait_tribeemployed")]
    public OptionSetValue ait_tribeemployed
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_tribeemployed));
      set
      {
        this.OnPropertyChanging(nameof (ait_tribeemployed));
        this.SetAttributeValue(nameof (ait_tribeemployed), (object) value);
        this.OnPropertyChanged(nameof (ait_tribeemployed));
      }
    }

    [AttributeLogicalName("ait_tribeemployedname")]
    public object ait_tribeemployedName => this.GetAttributeValue<object>("ait_tribeemployedname");

    [AttributeLogicalName("ait_tribename")]
    public string ait_tribeName => this.GetAttributeValue<string>("ait_tribename");

    [AttributeLogicalName("ait_vendornumber")]
    public string ait_vendornumber
    {
      get => this.GetAttributeValue<string>(nameof (ait_vendornumber));
      set
      {
        this.OnPropertyChanging(nameof (ait_vendornumber));
        this.SetAttributeValue(nameof (ait_vendornumber), (object) value);
        this.OnPropertyChanged(nameof (ait_vendornumber));
      }
    }

    [AttributeLogicalName("ait_weight")]
    public int? ait_weight
    {
      get => this.GetAttributeValue<int?>(nameof (ait_weight));
      set
      {
        this.OnPropertyChanging(nameof (ait_weight));
        this.SetAttributeValue(nameof (ait_weight), (object) value);
        this.OnPropertyChanged(nameof (ait_weight));
      }
    }

    [AttributeLogicalName("ait_willonfile")]
    public bool? ait_WillOnFile
    {
      get => this.GetAttributeValue<bool?>("ait_willonfile");
      set
      {
        this.OnPropertyChanging(nameof (ait_WillOnFile));
        this.SetAttributeValue("ait_willonfile", (object) value);
        this.OnPropertyChanged(nameof (ait_WillOnFile));
      }
    }

    [AttributeLogicalName("ait_willonfilename")]
    public object ait_willonfileName => this.GetAttributeValue<object>("ait_willonfilename");

    [AttributeLogicalName("ait_willreceiveddate")]
    public DateTime? ait_WillReceivedDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_willreceiveddate");
      set
      {
        this.OnPropertyChanging(nameof (ait_WillReceivedDate));
        this.SetAttributeValue("ait_willreceiveddate", (object) value);
        this.OnPropertyChanged(nameof (ait_WillReceivedDate));
      }
    }

    [AttributeLogicalName("anniversary")]
    public DateTime? Anniversary
    {
      get => this.GetAttributeValue<DateTime?>("anniversary");
      set
      {
        this.OnPropertyChanging(nameof (Anniversary));
        this.SetAttributeValue("anniversary", (object) value);
        this.OnPropertyChanged(nameof (Anniversary));
      }
    }

    [AttributeLogicalName("annualincome")]
    public Money AnnualIncome
    {
      get => this.GetAttributeValue<Money>("annualincome");
      set
      {
        this.OnPropertyChanging(nameof (AnnualIncome));
        this.SetAttributeValue("annualincome", (object) value);
        this.OnPropertyChanged(nameof (AnnualIncome));
      }
    }

    [AttributeLogicalName("annualincome_base")]
    public Money AnnualIncome_Base => this.GetAttributeValue<Money>("annualincome_base");

    [AttributeLogicalName("assistantname")]
    public string AssistantName
    {
      get => this.GetAttributeValue<string>("assistantname");
      set
      {
        this.OnPropertyChanging(nameof (AssistantName));
        this.SetAttributeValue("assistantname", (object) value);
        this.OnPropertyChanged(nameof (AssistantName));
      }
    }

    [AttributeLogicalName("assistantphone")]
    public string AssistantPhone
    {
      get => this.GetAttributeValue<string>("assistantphone");
      set
      {
        this.OnPropertyChanging(nameof (AssistantPhone));
        this.SetAttributeValue("assistantphone", (object) value);
        this.OnPropertyChanged(nameof (AssistantPhone));
      }
    }

    [AttributeLogicalName("birthdate")]
    public DateTime? BirthDate
    {
      get => this.GetAttributeValue<DateTime?>("birthdate");
      set
      {
        this.OnPropertyChanging(nameof (BirthDate));
        this.SetAttributeValue("birthdate", (object) value);
        this.OnPropertyChanged(nameof (BirthDate));
      }
    }

    [AttributeLogicalName("business2")]
    public string Business2
    {
      get => this.GetAttributeValue<string>("business2");
      set
      {
        this.OnPropertyChanging(nameof (Business2));
        this.SetAttributeValue("business2", (object) value);
        this.OnPropertyChanged(nameof (Business2));
      }
    }

    [AttributeLogicalName("callback")]
    public string Callback
    {
      get => this.GetAttributeValue<string>("callback");
      set
      {
        this.OnPropertyChanging(nameof (Callback));
        this.SetAttributeValue("callback", (object) value);
        this.OnPropertyChanged(nameof (Callback));
      }
    }

    [AttributeLogicalName("childrensnames")]
    public string ChildrensNames
    {
      get => this.GetAttributeValue<string>("childrensnames");
      set
      {
        this.OnPropertyChanging(nameof (ChildrensNames));
        this.SetAttributeValue("childrensnames", (object) value);
        this.OnPropertyChanged(nameof (ChildrensNames));
      }
    }

    [AttributeLogicalName("company")]
    public string Company
    {
      get => this.GetAttributeValue<string>("company");
      set
      {
        this.OnPropertyChanging(nameof (Company));
        this.SetAttributeValue("company", (object) value);
        this.OnPropertyChanged(nameof (Company));
      }
    }

    [AttributeLogicalName("contactid")]
    public Guid? ContactId
    {
      get => this.GetAttributeValue<Guid?>("contactid");
      set
      {
        this.OnPropertyChanging(nameof (ContactId));
        this.SetAttributeValue("contactid", (object) value);
        this.OnPropertyChanged(nameof (ContactId));
      }
    }

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

    [AttributeLogicalName("department")]
    public string Department
    {
      get => this.GetAttributeValue<string>("department");
      set
      {
        this.OnPropertyChanging(nameof (Department));
        this.SetAttributeValue("department", (object) value);
        this.OnPropertyChanged(nameof (Department));
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

    [AttributeLogicalName("educationcode")]
    public OptionSetValue EducationCode
    {
      get => this.GetAttributeValue<OptionSetValue>("educationcode");
      set
      {
        this.OnPropertyChanging(nameof (EducationCode));
        this.SetAttributeValue("educationcode", (object) value);
        this.OnPropertyChanged(nameof (EducationCode));
      }
    }

    [AttributeLogicalName("educationcodename")]
    public object EducationCodeName => this.GetAttributeValue<object>("educationcodename");

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

    [AttributeLogicalName("employeeid")]
    public string EmployeeId
    {
      get => this.GetAttributeValue<string>("employeeid");
      set
      {
        this.OnPropertyChanging(nameof (EmployeeId));
        this.SetAttributeValue("employeeid", (object) value);
        this.OnPropertyChanged(nameof (EmployeeId));
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

    [AttributeLogicalName("externaluseridentifier")]
    public string ExternalUserIdentifier
    {
      get => this.GetAttributeValue<string>("externaluseridentifier");
      set
      {
        this.OnPropertyChanging(nameof (ExternalUserIdentifier));
        this.SetAttributeValue("externaluseridentifier", (object) value);
        this.OnPropertyChanged(nameof (ExternalUserIdentifier));
      }
    }

    [AttributeLogicalName("familystatuscode")]
    public OptionSetValue FamilyStatusCode
    {
      get => this.GetAttributeValue<OptionSetValue>("familystatuscode");
      set
      {
        this.OnPropertyChanging(nameof (FamilyStatusCode));
        this.SetAttributeValue("familystatuscode", (object) value);
        this.OnPropertyChanged(nameof (FamilyStatusCode));
      }
    }

    [AttributeLogicalName("familystatuscodename")]
    public object FamilyStatusCodeName => this.GetAttributeValue<object>("familystatuscodename");

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

    [AttributeLogicalName("firstname")]
    public string FirstName
    {
      get => this.GetAttributeValue<string>("firstname");
      set
      {
        this.OnPropertyChanging(nameof (FirstName));
        this.SetAttributeValue("firstname", (object) value);
        this.OnPropertyChanged(nameof (FirstName));
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
    public string FtpSiteUrl
    {
      get => this.GetAttributeValue<string>("ftpsiteurl");
      set
      {
        this.OnPropertyChanging(nameof (FtpSiteUrl));
        this.SetAttributeValue("ftpsiteurl", (object) value);
        this.OnPropertyChanged(nameof (FtpSiteUrl));
      }
    }

    [AttributeLogicalName("fullname")]
    public string FullName => this.GetAttributeValue<string>("fullname");

    [AttributeLogicalName("gendercode")]
    public OptionSetValue GenderCode
    {
      get => this.GetAttributeValue<OptionSetValue>("gendercode");
      set
      {
        this.OnPropertyChanging(nameof (GenderCode));
        this.SetAttributeValue("gendercode", (object) value);
        this.OnPropertyChanged(nameof (GenderCode));
      }
    }

    [AttributeLogicalName("gendercodename")]
    public object GenderCodeName => this.GetAttributeValue<object>("gendercodename");

    [AttributeLogicalName("governmentid")]
    public string GovernmentId
    {
      get => this.GetAttributeValue<string>("governmentid");
      set
      {
        this.OnPropertyChanging(nameof (GovernmentId));
        this.SetAttributeValue("governmentid", (object) value);
        this.OnPropertyChanged(nameof (GovernmentId));
      }
    }

    [AttributeLogicalName("haschildrencode")]
    public OptionSetValue HasChildrenCode
    {
      get => this.GetAttributeValue<OptionSetValue>("haschildrencode");
      set
      {
        this.OnPropertyChanging(nameof (HasChildrenCode));
        this.SetAttributeValue("haschildrencode", (object) value);
        this.OnPropertyChanged(nameof (HasChildrenCode));
      }
    }

    [AttributeLogicalName("haschildrencodename")]
    public object HasChildrenCodeName => this.GetAttributeValue<object>("haschildrencodename");

    [AttributeLogicalName("home2")]
    public string Home2
    {
      get => this.GetAttributeValue<string>("home2");
      set
      {
        this.OnPropertyChanging(nameof (Home2));
        this.SetAttributeValue("home2", (object) value);
        this.OnPropertyChanged(nameof (Home2));
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

    [AttributeLogicalName("isbackofficecustomer")]
    public bool? IsBackofficeCustomer
    {
      get => this.GetAttributeValue<bool?>("isbackofficecustomer");
      set
      {
        this.OnPropertyChanging(nameof (IsBackofficeCustomer));
        this.SetAttributeValue("isbackofficecustomer", (object) value);
        this.OnPropertyChanged(nameof (IsBackofficeCustomer));
      }
    }

    [AttributeLogicalName("isbackofficecustomername")]
    public object IsBackofficeCustomerName
    {
      get => this.GetAttributeValue<object>("isbackofficecustomername");
    }

    [AttributeLogicalName("isprivatename")]
    public object IsPrivateName => this.GetAttributeValue<object>("isprivatename");

    [AttributeLogicalName("jobtitle")]
    public string JobTitle
    {
      get => this.GetAttributeValue<string>("jobtitle");
      set
      {
        this.OnPropertyChanging(nameof (JobTitle));
        this.SetAttributeValue("jobtitle", (object) value);
        this.OnPropertyChanged(nameof (JobTitle));
      }
    }

    [AttributeLogicalName("lastname")]
    public string LastName
    {
      get => this.GetAttributeValue<string>("lastname");
      set
      {
        this.OnPropertyChanging(nameof (LastName));
        this.SetAttributeValue("lastname", (object) value);
        this.OnPropertyChanged(nameof (LastName));
      }
    }

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

    [AttributeLogicalName("leadsourcecode")]
    public OptionSetValue LeadSourceCode
    {
      get => this.GetAttributeValue<OptionSetValue>("leadsourcecode");
      set
      {
        this.OnPropertyChanging(nameof (LeadSourceCode));
        this.SetAttributeValue("leadsourcecode", (object) value);
        this.OnPropertyChanged(nameof (LeadSourceCode));
      }
    }

    [AttributeLogicalName("leadsourcecodename")]
    public object LeadSourceCodeName => this.GetAttributeValue<object>("leadsourcecodename");

    [AttributeLogicalName("managername")]
    public string ManagerName
    {
      get => this.GetAttributeValue<string>("managername");
      set
      {
        this.OnPropertyChanging(nameof (ManagerName));
        this.SetAttributeValue("managername", (object) value);
        this.OnPropertyChanged(nameof (ManagerName));
      }
    }

    [AttributeLogicalName("managerphone")]
    public string ManagerPhone
    {
      get => this.GetAttributeValue<string>("managerphone");
      set
      {
        this.OnPropertyChanging(nameof (ManagerPhone));
        this.SetAttributeValue("managerphone", (object) value);
        this.OnPropertyChanged(nameof (ManagerPhone));
      }
    }

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

    [AttributeLogicalName("mastercontactidname")]
    public string MasterContactIdName => this.GetAttributeValue<string>("mastercontactidname");

    [AttributeLogicalName("mastercontactidyominame")]
    public string MasterContactIdYomiName
    {
      get => this.GetAttributeValue<string>("mastercontactidyominame");
    }

    [AttributeLogicalName("masterid")]
    public EntityReference MasterId => this.GetAttributeValue<EntityReference>("masterid");

    [AttributeLogicalName("merged")]
    public bool? Merged => this.GetAttributeValue<bool?>("merged");

    [AttributeLogicalName("mergedname")]
    public object MergedName => this.GetAttributeValue<object>("mergedname");

    [AttributeLogicalName("middlename")]
    public string MiddleName
    {
      get => this.GetAttributeValue<string>("middlename");
      set
      {
        this.OnPropertyChanging(nameof (MiddleName));
        this.SetAttributeValue("middlename", (object) value);
        this.OnPropertyChanged(nameof (MiddleName));
      }
    }

    [AttributeLogicalName("mobilephone")]
    public string MobilePhone
    {
      get => this.GetAttributeValue<string>("mobilephone");
      set
      {
        this.OnPropertyChanging(nameof (MobilePhone));
        this.SetAttributeValue("mobilephone", (object) value);
        this.OnPropertyChanged(nameof (MobilePhone));
      }
    }

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

    [AttributeLogicalName("msdyn_disablewebtracking")]
    public bool? msdyn_disablewebtracking
    {
      get => this.GetAttributeValue<bool?>(nameof (msdyn_disablewebtracking));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_disablewebtracking));
        this.SetAttributeValue(nameof (msdyn_disablewebtracking), (object) value);
        this.OnPropertyChanged(nameof (msdyn_disablewebtracking));
      }
    }

    [AttributeLogicalName("msdyn_disablewebtrackingname")]
    public object msdyn_disablewebtrackingName
    {
      get => this.GetAttributeValue<object>("msdyn_disablewebtrackingname");
    }

    [AttributeLogicalName("msdyn_isminor")]
    public bool? msdyn_isminor
    {
      get => this.GetAttributeValue<bool?>(nameof (msdyn_isminor));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_isminor));
        this.SetAttributeValue(nameof (msdyn_isminor), (object) value);
        this.OnPropertyChanged(nameof (msdyn_isminor));
      }
    }

    [AttributeLogicalName("msdyn_isminorname")]
    public object msdyn_isminorName => this.GetAttributeValue<object>("msdyn_isminorname");

    [AttributeLogicalName("msdyn_isminorwithparentalconsent")]
    public bool? msdyn_isminorwithparentalconsent
    {
      get => this.GetAttributeValue<bool?>(nameof (msdyn_isminorwithparentalconsent));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_isminorwithparentalconsent));
        this.SetAttributeValue(nameof (msdyn_isminorwithparentalconsent), (object) value);
        this.OnPropertyChanged(nameof (msdyn_isminorwithparentalconsent));
      }
    }

    [AttributeLogicalName("msdyn_isminorwithparentalconsentname")]
    public object msdyn_isminorwithparentalconsentName
    {
      get => this.GetAttributeValue<object>("msdyn_isminorwithparentalconsentname");
    }

    [AttributeLogicalName("msdyn_portaltermsagreementdate")]
    public DateTime? msdyn_portaltermsagreementdate
    {
      get => this.GetAttributeValue<DateTime?>(nameof (msdyn_portaltermsagreementdate));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_portaltermsagreementdate));
        this.SetAttributeValue(nameof (msdyn_portaltermsagreementdate), (object) value);
        this.OnPropertyChanged(nameof (msdyn_portaltermsagreementdate));
      }
    }

    [AttributeLogicalName("nickname")]
    public string NickName
    {
      get => this.GetAttributeValue<string>("nickname");
      set
      {
        this.OnPropertyChanging(nameof (NickName));
        this.SetAttributeValue("nickname", (object) value);
        this.OnPropertyChanged(nameof (NickName));
      }
    }

    [AttributeLogicalName("numberofchildren")]
    public int? NumberOfChildren
    {
      get => this.GetAttributeValue<int?>("numberofchildren");
      set
      {
        this.OnPropertyChanging(nameof (NumberOfChildren));
        this.SetAttributeValue("numberofchildren", (object) value);
        this.OnPropertyChanged(nameof (NumberOfChildren));
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

    [AttributeLogicalName("owningbusinessunit")]
    public EntityReference OwningBusinessUnit
    {
      get => this.GetAttributeValue<EntityReference>("owningbusinessunit");
    }

    [AttributeLogicalName("owningteam")]
    public EntityReference OwningTeam => this.GetAttributeValue<EntityReference>("owningteam");

    [AttributeLogicalName("owninguser")]
    public EntityReference OwningUser => this.GetAttributeValue<EntityReference>("owninguser");

    [AttributeLogicalName("pager")]
    public string Pager
    {
      get => this.GetAttributeValue<string>("pager");
      set
      {
        this.OnPropertyChanging(nameof (Pager));
        this.SetAttributeValue("pager", (object) value);
        this.OnPropertyChanged(nameof (Pager));
      }
    }

    [AttributeLogicalName("parentcontactid")]
    public EntityReference ParentContactId
    {
      get => this.GetAttributeValue<EntityReference>("parentcontactid");
    }

    [AttributeLogicalName("parentcontactidname")]
    public string ParentContactIdName => this.GetAttributeValue<string>("parentcontactidname");

    [AttributeLogicalName("parentcontactidyominame")]
    public string ParentContactIdYomiName
    {
      get => this.GetAttributeValue<string>("parentcontactidyominame");
    }

    [AttributeLogicalName("parentcustomerid")]
    public EntityReference ParentCustomerId
    {
      get => this.GetAttributeValue<EntityReference>("parentcustomerid");
      set
      {
        this.OnPropertyChanging(nameof (ParentCustomerId));
        this.SetAttributeValue("parentcustomerid", (object) value);
        this.OnPropertyChanged(nameof (ParentCustomerId));
      }
    }

    [AttributeLogicalName("parentcustomeridname")]
    public string ParentCustomerIdName => this.GetAttributeValue<string>("parentcustomeridname");

    [AttributeLogicalName("parentcustomeridtype")]
    public string ParentCustomerIdType
    {
      get => this.GetAttributeValue<string>("parentcustomeridtype");
      set
      {
        this.OnPropertyChanging(nameof (ParentCustomerIdType));
        this.SetAttributeValue("parentcustomeridtype", (object) value);
        this.OnPropertyChanged(nameof (ParentCustomerIdType));
      }
    }

    [AttributeLogicalName("parentcustomeridyominame")]
    public string ParentCustomerIdYomiName
    {
      get => this.GetAttributeValue<string>("parentcustomeridyominame");
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

    [AttributeLogicalName("salutation")]
    public string Salutation
    {
      get => this.GetAttributeValue<string>("salutation");
      set
      {
        this.OnPropertyChanging(nameof (Salutation));
        this.SetAttributeValue("salutation", (object) value);
        this.OnPropertyChanged(nameof (Salutation));
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

    [AttributeLogicalName("spousesname")]
    public string SpousesName
    {
      get => this.GetAttributeValue<string>("spousesname");
      set
      {
        this.OnPropertyChanging(nameof (SpousesName));
        this.SetAttributeValue("spousesname", (object) value);
        this.OnPropertyChanged(nameof (SpousesName));
      }
    }

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
    public ContactState? StateCode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>("statecode");
        return attributeValue != null ? new ContactState?((ContactState) Enum.ToObject(typeof (ContactState), attributeValue.Value)) : new ContactState?();
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

    [AttributeLogicalName("subscriptionid")]
    public Guid? SubscriptionId
    {
      get => this.GetAttributeValue<Guid?>("subscriptionid");
      set
      {
        this.OnPropertyChanging(nameof (SubscriptionId));
        this.SetAttributeValue("subscriptionid", (object) value);
        this.OnPropertyChanged(nameof (SubscriptionId));
      }
    }

    [AttributeLogicalName("suffix")]
    public string Suffix
    {
      get => this.GetAttributeValue<string>("suffix");
      set
      {
        this.OnPropertyChanging(nameof (Suffix));
        this.SetAttributeValue("suffix", (object) value);
        this.OnPropertyChanged(nameof (Suffix));
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
    public string WebSiteUrl
    {
      get => this.GetAttributeValue<string>("websiteurl");
      set
      {
        this.OnPropertyChanging(nameof (WebSiteUrl));
        this.SetAttributeValue("websiteurl", (object) value);
        this.OnPropertyChanged(nameof (WebSiteUrl));
      }
    }

    [AttributeLogicalName("yomifirstname")]
    public string YomiFirstName
    {
      get => this.GetAttributeValue<string>("yomifirstname");
      set
      {
        this.OnPropertyChanging(nameof (YomiFirstName));
        this.SetAttributeValue("yomifirstname", (object) value);
        this.OnPropertyChanged(nameof (YomiFirstName));
      }
    }

    [AttributeLogicalName("yomifullname")]
    public string YomiFullName => this.GetAttributeValue<string>("yomifullname");

    [AttributeLogicalName("yomilastname")]
    public string YomiLastName
    {
      get => this.GetAttributeValue<string>("yomilastname");
      set
      {
        this.OnPropertyChanging(nameof (YomiLastName));
        this.SetAttributeValue("yomilastname", (object) value);
        this.OnPropertyChanged(nameof (YomiLastName));
      }
    }

    [AttributeLogicalName("yomimiddlename")]
    public string YomiMiddleName
    {
      get => this.GetAttributeValue<string>("yomimiddlename");
      set
      {
        this.OnPropertyChanging(nameof (YomiMiddleName));
        this.SetAttributeValue("yomimiddlename", (object) value);
        this.OnPropertyChanged(nameof (YomiMiddleName));
      }
    }

    [RelationshipSchemaName("account_primary_contact")]
    public IEnumerable<Account> account_primary_contact
    {
      get => this.GetRelatedEntities<Account>(nameof (account_primary_contact), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (account_primary_contact));
        this.SetRelatedEntities<Account>(nameof (account_primary_contact), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (account_primary_contact));
      }
    }

    [RelationshipSchemaName("ait_contact_ait_clientprofile_Contact")]
    public IEnumerable<ait_clientprofile> ait_contact_ait_clientprofile_Contact
    {
      get
      {
        return this.GetRelatedEntities<ait_clientprofile>(nameof (ait_contact_ait_clientprofile_Contact), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contact_ait_clientprofile_Contact));
        this.SetRelatedEntities<ait_clientprofile>(nameof (ait_contact_ait_clientprofile_Contact), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contact_ait_clientprofile_Contact));
      }
    }

    [RelationshipSchemaName("ait_contact_ait_clientprofile_Guardian1")]
    public IEnumerable<ait_clientprofile> ait_contact_ait_clientprofile_Guardian1
    {
      get
      {
        return this.GetRelatedEntities<ait_clientprofile>(nameof (ait_contact_ait_clientprofile_Guardian1), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contact_ait_clientprofile_Guardian1));
        this.SetRelatedEntities<ait_clientprofile>(nameof (ait_contact_ait_clientprofile_Guardian1), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contact_ait_clientprofile_Guardian1));
      }
    }

    [RelationshipSchemaName("ait_contact_ait_clientprofile_Guardian2")]
    public IEnumerable<ait_clientprofile> ait_contact_ait_clientprofile_Guardian2
    {
      get
      {
        return this.GetRelatedEntities<ait_clientprofile>(nameof (ait_contact_ait_clientprofile_Guardian2), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contact_ait_clientprofile_Guardian2));
        this.SetRelatedEntities<ait_clientprofile>(nameof (ait_contact_ait_clientprofile_Guardian2), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contact_ait_clientprofile_Guardian2));
      }
    }

    [RelationshipSchemaName("ait_contact_ait_clientprofile_NextofKin")]
    public IEnumerable<ait_clientprofile> ait_contact_ait_clientprofile_NextofKin
    {
      get
      {
        return this.GetRelatedEntities<ait_clientprofile>(nameof (ait_contact_ait_clientprofile_NextofKin), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contact_ait_clientprofile_NextofKin));
        this.SetRelatedEntities<ait_clientprofile>(nameof (ait_contact_ait_clientprofile_NextofKin), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contact_ait_clientprofile_NextofKin));
      }
    }

    [RelationshipSchemaName("ait_contact_ait_clientprofile_PrimaryProvider")]
    public IEnumerable<ait_clientprofile> ait_contact_ait_clientprofile_PrimaryProvider
    {
      get
      {
        return this.GetRelatedEntities<ait_clientprofile>(nameof (ait_contact_ait_clientprofile_PrimaryProvider), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contact_ait_clientprofile_PrimaryProvider));
        this.SetRelatedEntities<ait_clientprofile>(nameof (ait_contact_ait_clientprofile_PrimaryProvider), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contact_ait_clientprofile_PrimaryProvider));
      }
    }

    [RelationshipSchemaName("ait_contact_ait_familygroup_PrimaryContact")]
    public IEnumerable<TPFamilyWellness.EarlyBound.ait_familygroup> ait_contact_ait_familygroup_PrimaryContact
    {
      get
      {
        return this.GetRelatedEntities<TPFamilyWellness.EarlyBound.ait_familygroup>(nameof (ait_contact_ait_familygroup_PrimaryContact), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contact_ait_familygroup_PrimaryContact));
        this.SetRelatedEntities<TPFamilyWellness.EarlyBound.ait_familygroup>(nameof (ait_contact_ait_familygroup_PrimaryContact), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contact_ait_familygroup_PrimaryContact));
      }
    }

    [RelationshipSchemaName("ait_contact_ait_incidents_CustodianName")]
    public IEnumerable<ait_incidents> ait_contact_ait_incidents_CustodianName
    {
      get
      {
        return this.GetRelatedEntities<ait_incidents>(nameof (ait_contact_ait_incidents_CustodianName), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contact_ait_incidents_CustodianName));
        this.SetRelatedEntities<ait_incidents>(nameof (ait_contact_ait_incidents_CustodianName), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contact_ait_incidents_CustodianName));
      }
    }

    [RelationshipSchemaName("ait_contact_ait_incidents_fathersname")]
    public IEnumerable<ait_incidents> ait_contact_ait_incidents_fathersname
    {
      get
      {
        return this.GetRelatedEntities<ait_incidents>(nameof (ait_contact_ait_incidents_fathersname), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contact_ait_incidents_fathersname));
        this.SetRelatedEntities<ait_incidents>(nameof (ait_contact_ait_incidents_fathersname), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contact_ait_incidents_fathersname));
      }
    }

    [RelationshipSchemaName("ait_contact_ait_incidents_mothersname")]
    public IEnumerable<ait_incidents> ait_contact_ait_incidents_mothersname
    {
      get
      {
        return this.GetRelatedEntities<ait_incidents>(nameof (ait_contact_ait_incidents_mothersname), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contact_ait_incidents_mothersname));
        this.SetRelatedEntities<ait_incidents>(nameof (ait_contact_ait_incidents_mothersname), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contact_ait_incidents_mothersname));
      }
    }

    [RelationshipSchemaName("ait_contact_ait_incidents_OffenderContactName")]
    public IEnumerable<ait_incidents> ait_contact_ait_incidents_OffenderContactName
    {
      get
      {
        return this.GetRelatedEntities<ait_incidents>(nameof (ait_contact_ait_incidents_OffenderContactName), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contact_ait_incidents_OffenderContactName));
        this.SetRelatedEntities<ait_incidents>(nameof (ait_contact_ait_incidents_OffenderContactName), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contact_ait_incidents_OffenderContactName));
      }
    }

    [RelationshipSchemaName("ait_contact_ait_incidents_reporter")]
    public IEnumerable<ait_incidents> ait_contact_ait_incidents_reporter
    {
      get
      {
        return this.GetRelatedEntities<ait_incidents>(nameof (ait_contact_ait_incidents_reporter), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contact_ait_incidents_reporter));
        this.SetRelatedEntities<ait_incidents>(nameof (ait_contact_ait_incidents_reporter), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contact_ait_incidents_reporter));
      }
    }

    [RelationshipSchemaName("ait_placementlocation_primarycontact_Cont")]
    public IEnumerable<ait_placementlocation> ait_placementlocation_primarycontact_Cont
    {
      get
      {
        return this.GetRelatedEntities<ait_placementlocation>(nameof (ait_placementlocation_primarycontact_Cont), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_placementlocation_primarycontact_Cont));
        this.SetRelatedEntities<ait_placementlocation>(nameof (ait_placementlocation_primarycontact_Cont), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_placementlocation_primarycontact_Cont));
      }
    }

    [RelationshipSchemaName("ait_placementlocation_secondarycontact_Co")]
    public IEnumerable<ait_placementlocation> ait_placementlocation_secondarycontact_Co
    {
      get
      {
        return this.GetRelatedEntities<ait_placementlocation>(nameof (ait_placementlocation_secondarycontact_Co), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_placementlocation_secondarycontact_Co));
        this.SetRelatedEntities<ait_placementlocation>(nameof (ait_placementlocation_secondarycontact_Co), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_placementlocation_secondarycontact_Co));
      }
    }

    [RelationshipSchemaName("Contact_Appointments")]
    public IEnumerable<Appointment> Contact_Appointments
    {
      get => this.GetRelatedEntities<Appointment>(nameof (Contact_Appointments), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Contact_Appointments));
        this.SetRelatedEntities<Appointment>(nameof (Contact_Appointments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Contact_Appointments));
      }
    }

    [RelationshipSchemaName("contact_connections1")]
    public IEnumerable<Connection> contact_connections1
    {
      get => this.GetRelatedEntities<Connection>(nameof (contact_connections1), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (contact_connections1));
        this.SetRelatedEntities<Connection>(nameof (contact_connections1), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (contact_connections1));
      }
    }

    [RelationshipSchemaName("contact_connections2")]
    public IEnumerable<Connection> contact_connections2
    {
      get => this.GetRelatedEntities<Connection>(nameof (contact_connections2), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (contact_connections2));
        this.SetRelatedEntities<Connection>(nameof (contact_connections2), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (contact_connections2));
      }
    }

    [RelationshipSchemaName]
    public IEnumerable<Contact> Referencedcontact_customer_contacts
    {
      get
      {
        return this.GetRelatedEntities<Contact>("contact_customer_contacts", new EntityRole?((EntityRole) 1));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencedcontact_customer_contacts));
        this.SetRelatedEntities<Contact>("contact_customer_contacts", new EntityRole?((EntityRole) 1), value);
        this.OnPropertyChanged(nameof (Referencedcontact_customer_contacts));
      }
    }

    [RelationshipSchemaName("Contact_Email_EmailSender")]
    public IEnumerable<Email> Contact_Email_EmailSender
    {
      get => this.GetRelatedEntities<Email>(nameof (Contact_Email_EmailSender), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Contact_Email_EmailSender));
        this.SetRelatedEntities<Email>(nameof (Contact_Email_EmailSender), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Contact_Email_EmailSender));
      }
    }

    [RelationshipSchemaName("Contact_Emails")]
    public IEnumerable<Email> Contact_Emails
    {
      get => this.GetRelatedEntities<Email>(nameof (Contact_Emails), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Contact_Emails));
        this.SetRelatedEntities<Email>(nameof (Contact_Emails), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Contact_Emails));
      }
    }

    [RelationshipSchemaName]
    public IEnumerable<Contact> Referencedcontact_master_contact
    {
      get
      {
        return this.GetRelatedEntities<Contact>("contact_master_contact", new EntityRole?((EntityRole) 1));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencedcontact_master_contact));
        this.SetRelatedEntities<Contact>("contact_master_contact", new EntityRole?((EntityRole) 1), value);
        this.OnPropertyChanged(nameof (Referencedcontact_master_contact));
      }
    }

    [RelationshipSchemaName("Contact_Phonecalls")]
    public IEnumerable<PhoneCall> Contact_Phonecalls
    {
      get => this.GetRelatedEntities<PhoneCall>(nameof (Contact_Phonecalls), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Contact_Phonecalls));
        this.SetRelatedEntities<PhoneCall>(nameof (Contact_Phonecalls), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Contact_Phonecalls));
      }
    }

    [RelationshipSchemaName("Contact_Tasks")]
    public IEnumerable<Task> Contact_Tasks
    {
      get => this.GetRelatedEntities<Task>(nameof (Contact_Tasks), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Contact_Tasks));
        this.SetRelatedEntities<Task>(nameof (Contact_Tasks), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Contact_Tasks));
      }
    }

    [RelationshipSchemaName("ait_ait_groupactivity_contact")]
    public IEnumerable<ait_groupactivity> ait_ait_groupactivity_contact
    {
      get
      {
        return this.GetRelatedEntities<ait_groupactivity>(nameof (ait_ait_groupactivity_contact), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_groupactivity_contact));
        this.SetRelatedEntities<ait_groupactivity>(nameof (ait_ait_groupactivity_contact), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_groupactivity_contact));
      }
    }

    [RelationshipSchemaName("ait_ait_groupactivitymeeting_contact")]
    public IEnumerable<ait_groupactivitymeeting> ait_ait_groupactivitymeeting_contact
    {
      get
      {
        return this.GetRelatedEntities<ait_groupactivitymeeting>(nameof (ait_ait_groupactivitymeeting_contact), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_groupactivitymeeting_contact));
        this.SetRelatedEntities<ait_groupactivitymeeting>(nameof (ait_ait_groupactivitymeeting_contact), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_groupactivitymeeting_contact));
      }
    }

    [RelationshipSchemaName("ait_placement_Contact_Contact")]
    public IEnumerable<ait_placement> ait_placement_Contact_Contact
    {
      get
      {
        return this.GetRelatedEntities<ait_placement>(nameof (ait_placement_Contact_Contact), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_placement_Contact_Contact));
        this.SetRelatedEntities<ait_placement>(nameof (ait_placement_Contact_Contact), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_placement_Contact_Contact));
      }
    }

    [AttributeLogicalName("ait_clientprofile")]
    [RelationshipSchemaName("ait_ait_clientprofile_contact_ClientProfile")]
    public ait_clientprofile ait_ait_clientprofile_contact_ClientProfile
    {
      get
      {
        return this.GetRelatedEntity<ait_clientprofile>(nameof (ait_ait_clientprofile_contact_ClientProfile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_clientprofile_contact_ClientProfile));
        this.SetRelatedEntity<ait_clientprofile>(nameof (ait_ait_clientprofile_contact_ClientProfile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_clientprofile_contact_ClientProfile));
      }
    }

    [AttributeLogicalName("ait_tribe")]
    [RelationshipSchemaName("ait_contact_ait_tribe")]
    public TPFamilyWellness.EarlyBound.ait_tribe ait_contact_ait_tribe
    {
      get => this.GetRelatedEntity<TPFamilyWellness.EarlyBound.ait_tribe>(nameof (ait_contact_ait_tribe), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_contact_ait_tribe));
        this.SetRelatedEntity<TPFamilyWellness.EarlyBound.ait_tribe>(nameof (ait_contact_ait_tribe), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contact_ait_tribe));
      }
    }

    [AttributeLogicalName("ait_familygroup")]
    [RelationshipSchemaName("ait_familygroup_contact_familygroup")]
    public TPFamilyWellness.EarlyBound.ait_familygroup ait_familygroup_contact_familygroup
    {
      get
      {
        return this.GetRelatedEntity<TPFamilyWellness.EarlyBound.ait_familygroup>(nameof (ait_familygroup_contact_familygroup), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familygroup_contact_familygroup));
        this.SetRelatedEntity<TPFamilyWellness.EarlyBound.ait_familygroup>(nameof (ait_familygroup_contact_familygroup), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familygroup_contact_familygroup));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_contacts")]
    public BusinessUnit business_unit_contacts
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_contacts), new EntityRole?());
      }
    }

    [AttributeLogicalName("parentcustomerid")]
    [RelationshipSchemaName("contact_customer_accounts")]
    public Account contact_customer_accounts
    {
      get => this.GetRelatedEntity<Account>(nameof (contact_customer_accounts), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (contact_customer_accounts));
        this.SetRelatedEntity<Account>(nameof (contact_customer_accounts), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (contact_customer_accounts));
      }
    }

    [AttributeLogicalName("parentcustomerid")]
    [RelationshipSchemaName]
    public Contact Referencingcontact_customer_contacts
    {
      get
      {
        return this.GetRelatedEntity<Contact>("contact_customer_contacts", new EntityRole?((EntityRole) 0));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencingcontact_customer_contacts));
        this.SetRelatedEntity<Contact>("contact_customer_contacts", new EntityRole?((EntityRole) 0), value);
        this.OnPropertyChanged(nameof (Referencingcontact_customer_contacts));
      }
    }

    [AttributeLogicalName("masterid")]
    [RelationshipSchemaName]
    public Contact Referencingcontact_master_contact
    {
      get
      {
        return this.GetRelatedEntity<Contact>("contact_master_contact", new EntityRole?((EntityRole) 0));
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("contact_owning_user")]
    public SystemUser contact_owning_user
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (contact_owning_user), new EntityRole?());
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_contact_createdonbehalfby")]
    public SystemUser lk_contact_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_contact_createdonbehalfby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_contact_modifiedonbehalfby")]
    public SystemUser lk_contact_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_contact_modifiedonbehalfby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_contactbase_createdby")]
    public SystemUser lk_contactbase_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_contactbase_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_contactbase_modifiedby")]
    public SystemUser lk_contactbase_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_contactbase_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("msa_managingpartnerid")]
    [RelationshipSchemaName("msa_contact_managingpartner")]
    public Account msa_contact_managingpartner
    {
      get
      {
        return this.GetRelatedEntity<Account>(nameof (msa_contact_managingpartner), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msa_contact_managingpartner));
        this.SetRelatedEntity<Account>(nameof (msa_contact_managingpartner), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msa_contact_managingpartner));
      }
    }

    [AttributeLogicalName("stageid")]
    [RelationshipSchemaName("processstage_contact")]
    public ProcessStage processstage_contact
    {
      get => this.GetRelatedEntity<ProcessStage>(nameof (processstage_contact), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (processstage_contact));
        this.SetRelatedEntity<ProcessStage>(nameof (processstage_contact), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (processstage_contact));
      }
    }

    [AttributeLogicalName("preferredsystemuserid")]
    [RelationshipSchemaName("system_user_contacts")]
    public SystemUser system_user_contacts
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (system_user_contacts), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (system_user_contacts));
        this.SetRelatedEntity<SystemUser>(nameof (system_user_contacts), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (system_user_contacts));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_contacts")]
    public Team team_contacts
    {
      get => this.GetRelatedEntity<Team>(nameof (team_contacts), new EntityRole?());
    }
  }
}
