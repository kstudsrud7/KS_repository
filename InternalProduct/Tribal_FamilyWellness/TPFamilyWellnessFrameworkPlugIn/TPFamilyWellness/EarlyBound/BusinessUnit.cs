// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EarlyBound.BusinessUnit
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("businessunit")]
  [GeneratedCode("CrmSvcUtil", "9.0.0.9154")]
  public class BusinessUnit : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "businessunit";
    public const int EntityTypeCode = 10;

    public BusinessUnit()
      : base("businessunit")
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

    [AttributeLogicalName("calendarid")]
    public EntityReference CalendarId
    {
      get => this.GetAttributeValue<EntityReference>("calendarid");
      set
      {
        this.OnPropertyChanging(nameof (CalendarId));
        this.SetAttributeValue("calendarid", (object) value);
        this.OnPropertyChanged(nameof (CalendarId));
      }
    }

    [AttributeLogicalName("costcenter")]
    public string CostCenter
    {
      get => this.GetAttributeValue<string>("costcenter");
      set
      {
        this.OnPropertyChanging(nameof (CostCenter));
        this.SetAttributeValue("costcenter", (object) value);
        this.OnPropertyChanged(nameof (CostCenter));
      }
    }

    [AttributeLogicalName("createdby")]
    public EntityReference CreatedBy => this.GetAttributeValue<EntityReference>("createdby");

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
    public double? CreditLimit
    {
      get => this.GetAttributeValue<double?>("creditlimit");
      set
      {
        this.OnPropertyChanging(nameof (CreditLimit));
        this.SetAttributeValue("creditlimit", (object) value);
        this.OnPropertyChanged(nameof (CreditLimit));
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

    [AttributeLogicalName("disabledreason")]
    public string DisabledReason => this.GetAttributeValue<string>("disabledreason");

    [AttributeLogicalName("divisionname")]
    public string DivisionName
    {
      get => this.GetAttributeValue<string>("divisionname");
      set
      {
        this.OnPropertyChanging(nameof (DivisionName));
        this.SetAttributeValue("divisionname", (object) value);
        this.OnPropertyChanged(nameof (DivisionName));
      }
    }

    [AttributeLogicalName("emailaddress")]
    public string EMailAddress
    {
      get => this.GetAttributeValue<string>("emailaddress");
      set
      {
        this.OnPropertyChanging(nameof (EMailAddress));
        this.SetAttributeValue("emailaddress", (object) value);
        this.OnPropertyChanged(nameof (EMailAddress));
      }
    }

    [AttributeLogicalName("exchangerate")]
    public Decimal? ExchangeRate => this.GetAttributeValue<Decimal?>("exchangerate");

    [AttributeLogicalName("fileasname")]
    public string FileAsName
    {
      get => this.GetAttributeValue<string>("fileasname");
      set
      {
        this.OnPropertyChanging(nameof (FileAsName));
        this.SetAttributeValue("fileasname", (object) value);
        this.OnPropertyChanged(nameof (FileAsName));
      }
    }

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

    [AttributeLogicalName("inheritancemask")]
    public int? InheritanceMask
    {
      get => this.GetAttributeValue<int?>("inheritancemask");
      set
      {
        this.OnPropertyChanging(nameof (InheritanceMask));
        this.SetAttributeValue("inheritancemask", (object) value);
        this.OnPropertyChanged(nameof (InheritanceMask));
      }
    }

    [AttributeLogicalName("isdisabled")]
    public bool? IsDisabled
    {
      get => this.GetAttributeValue<bool?>("isdisabled");
      set
      {
        this.OnPropertyChanging(nameof (IsDisabled));
        this.SetAttributeValue("isdisabled", (object) value);
        this.OnPropertyChanged(nameof (IsDisabled));
      }
    }

    [AttributeLogicalName("isdisabledname")]
    public object IsDisabledName => this.GetAttributeValue<object>("isdisabledname");

    [AttributeLogicalName("modifiedby")]
    public EntityReference ModifiedBy => this.GetAttributeValue<EntityReference>("modifiedby");

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

    [AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get => this.GetAttributeValue<EntityReference>("organizationid");
    }

    [AttributeLogicalName("organizationidname")]
    public string OrganizationIdName => this.GetAttributeValue<string>("organizationidname");

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

    [AttributeLogicalName("parentbusinessunitid")]
    public EntityReference ParentBusinessUnitId
    {
      get => this.GetAttributeValue<EntityReference>("parentbusinessunitid");
      set
      {
        this.OnPropertyChanging(nameof (ParentBusinessUnitId));
        this.SetAttributeValue("parentbusinessunitid", (object) value);
        this.OnPropertyChanged(nameof (ParentBusinessUnitId));
      }
    }

    [AttributeLogicalName("parentbusinessunitidname")]
    public string ParentBusinessUnitIdName
    {
      get => this.GetAttributeValue<string>("parentbusinessunitidname");
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

    [AttributeLogicalName("utcoffset")]
    public int? UTCOffset
    {
      get => this.GetAttributeValue<int?>("utcoffset");
      set
      {
        this.OnPropertyChanging(nameof (UTCOffset));
        this.SetAttributeValue("utcoffset", (object) value);
        this.OnPropertyChanged(nameof (UTCOffset));
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

    [AttributeLogicalName("workflowsuspended")]
    public bool? WorkflowSuspended
    {
      get => this.GetAttributeValue<bool?>("workflowsuspended");
      set
      {
        this.OnPropertyChanging(nameof (WorkflowSuspended));
        this.SetAttributeValue("workflowsuspended", (object) value);
        this.OnPropertyChanged(nameof (WorkflowSuspended));
      }
    }

    [AttributeLogicalName("workflowsuspendedname")]
    public object WorkflowSuspendedName => this.GetAttributeValue<object>("workflowsuspendedname");

    [RelationshipSchemaName("business_unit_accounts")]
    public IEnumerable<Account> business_unit_accounts
    {
      get => this.GetRelatedEntities<Account>(nameof (business_unit_accounts), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (business_unit_accounts));
        this.SetRelatedEntities<Account>(nameof (business_unit_accounts), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_accounts));
      }
    }

    [RelationshipSchemaName("business_unit_ait_assessment")]
    public IEnumerable<ait_assessment> business_unit_ait_assessment
    {
      get
      {
        return this.GetRelatedEntities<ait_assessment>(nameof (business_unit_ait_assessment), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_assessment));
        this.SetRelatedEntities<ait_assessment>(nameof (business_unit_ait_assessment), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_assessment));
      }
    }

    [RelationshipSchemaName("business_unit_ait_case")]
    public IEnumerable<ait_case> business_unit_ait_case
    {
      get => this.GetRelatedEntities<ait_case>(nameof (business_unit_ait_case), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_case));
        this.SetRelatedEntities<ait_case>(nameof (business_unit_ait_case), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_case));
      }
    }

    [RelationshipSchemaName("business_unit_ait_casenotefamilywellness")]
    public IEnumerable<ait_casenotefamilywellness> business_unit_ait_casenotefamilywellness
    {
      get
      {
        return this.GetRelatedEntities<ait_casenotefamilywellness>(nameof (business_unit_ait_casenotefamilywellness), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_casenotefamilywellness));
        this.SetRelatedEntities<ait_casenotefamilywellness>(nameof (business_unit_ait_casenotefamilywellness), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_casenotefamilywellness));
      }
    }

    [RelationshipSchemaName("business_unit_ait_caseplan")]
    public IEnumerable<ait_caseplan> business_unit_ait_caseplan
    {
      get
      {
        return this.GetRelatedEntities<ait_caseplan>(nameof (business_unit_ait_caseplan), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_caseplan));
        this.SetRelatedEntities<ait_caseplan>(nameof (business_unit_ait_caseplan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_caseplan));
      }
    }

    [RelationshipSchemaName("business_unit_ait_clientprofile")]
    public IEnumerable<ait_clientprofile> business_unit_ait_clientprofile
    {
      get
      {
        return this.GetRelatedEntities<ait_clientprofile>(nameof (business_unit_ait_clientprofile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_clientprofile));
        this.SetRelatedEntities<ait_clientprofile>(nameof (business_unit_ait_clientprofile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_clientprofile));
      }
    }

    [RelationshipSchemaName("business_unit_ait_familygroup")]
    public IEnumerable<ait_familygroup> business_unit_ait_familygroup
    {
      get
      {
        return this.GetRelatedEntities<ait_familygroup>(nameof (business_unit_ait_familygroup), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_familygroup));
        this.SetRelatedEntities<ait_familygroup>(nameof (business_unit_ait_familygroup), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_familygroup));
      }
    }

    [RelationshipSchemaName("business_unit_ait_goal")]
    public IEnumerable<ait_goal> business_unit_ait_goal
    {
      get => this.GetRelatedEntities<ait_goal>(nameof (business_unit_ait_goal), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_goal));
        this.SetRelatedEntities<ait_goal>(nameof (business_unit_ait_goal), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_goal));
      }
    }

    [RelationshipSchemaName("business_unit_ait_groupactivity")]
    public IEnumerable<ait_groupactivity> business_unit_ait_groupactivity
    {
      get
      {
        return this.GetRelatedEntities<ait_groupactivity>(nameof (business_unit_ait_groupactivity), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_groupactivity));
        this.SetRelatedEntities<ait_groupactivity>(nameof (business_unit_ait_groupactivity), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_groupactivity));
      }
    }

    [RelationshipSchemaName("business_unit_ait_groupactivitymeeting")]
    public IEnumerable<ait_groupactivitymeeting> business_unit_ait_groupactivitymeeting
    {
      get
      {
        return this.GetRelatedEntities<ait_groupactivitymeeting>(nameof (business_unit_ait_groupactivitymeeting), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_groupactivitymeeting));
        this.SetRelatedEntities<ait_groupactivitymeeting>(nameof (business_unit_ait_groupactivitymeeting), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_groupactivitymeeting));
      }
    }

    [RelationshipSchemaName("business_unit_ait_groupactivityregistration")]
    public IEnumerable<ait_groupactivityregistration> business_unit_ait_groupactivityregistration
    {
      get
      {
        return this.GetRelatedEntities<ait_groupactivityregistration>(nameof (business_unit_ait_groupactivityregistration), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_groupactivityregistration));
        this.SetRelatedEntities<ait_groupactivityregistration>(nameof (business_unit_ait_groupactivityregistration), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_groupactivityregistration));
      }
    }

    [RelationshipSchemaName("business_unit_ait_incidents")]
    public IEnumerable<ait_incidents> business_unit_ait_incidents
    {
      get
      {
        return this.GetRelatedEntities<ait_incidents>(nameof (business_unit_ait_incidents), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_incidents));
        this.SetRelatedEntities<ait_incidents>(nameof (business_unit_ait_incidents), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_incidents));
      }
    }

    [RelationshipSchemaName("business_unit_ait_meetingattendee")]
    public IEnumerable<ait_meetingattendee> business_unit_ait_meetingattendee
    {
      get
      {
        return this.GetRelatedEntities<ait_meetingattendee>(nameof (business_unit_ait_meetingattendee), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_meetingattendee));
        this.SetRelatedEntities<ait_meetingattendee>(nameof (business_unit_ait_meetingattendee), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_meetingattendee));
      }
    }

    [RelationshipSchemaName("business_unit_ait_payment")]
    public IEnumerable<ait_payment> business_unit_ait_payment
    {
      get
      {
        return this.GetRelatedEntities<ait_payment>(nameof (business_unit_ait_payment), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_payment));
        this.SetRelatedEntities<ait_payment>(nameof (business_unit_ait_payment), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_payment));
      }
    }

    [RelationshipSchemaName("business_unit_ait_placement")]
    public IEnumerable<ait_placement> business_unit_ait_placement
    {
      get
      {
        return this.GetRelatedEntities<ait_placement>(nameof (business_unit_ait_placement), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_placement));
        this.SetRelatedEntities<ait_placement>(nameof (business_unit_ait_placement), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_placement));
      }
    }

    [RelationshipSchemaName("business_unit_ait_placementlocation")]
    public IEnumerable<ait_placementlocation> business_unit_ait_placementlocation
    {
      get
      {
        return this.GetRelatedEntities<ait_placementlocation>(nameof (business_unit_ait_placementlocation), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_placementlocation));
        this.SetRelatedEntities<ait_placementlocation>(nameof (business_unit_ait_placementlocation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_placementlocation));
      }
    }

    [RelationshipSchemaName("business_unit_ait_planactivity")]
    public IEnumerable<ait_planactivity> business_unit_ait_planactivity
    {
      get
      {
        return this.GetRelatedEntities<ait_planactivity>(nameof (business_unit_ait_planactivity), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_planactivity));
        this.SetRelatedEntities<ait_planactivity>(nameof (business_unit_ait_planactivity), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_planactivity));
      }
    }

    [RelationshipSchemaName("business_unit_ait_program")]
    public IEnumerable<ait_program> business_unit_ait_program
    {
      get
      {
        return this.GetRelatedEntities<ait_program>(nameof (business_unit_ait_program), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_program));
        this.SetRelatedEntities<ait_program>(nameof (business_unit_ait_program), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_program));
      }
    }

    [RelationshipSchemaName("business_unit_ait_referral")]
    public IEnumerable<ait_referral> business_unit_ait_referral
    {
      get
      {
        return this.GetRelatedEntities<ait_referral>(nameof (business_unit_ait_referral), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_referral));
        this.SetRelatedEntities<ait_referral>(nameof (business_unit_ait_referral), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_referral));
      }
    }

    [RelationshipSchemaName("business_unit_ait_servicerequest")]
    public IEnumerable<ait_servicerequest> business_unit_ait_servicerequest
    {
      get
      {
        return this.GetRelatedEntities<ait_servicerequest>(nameof (business_unit_ait_servicerequest), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_servicerequest));
        this.SetRelatedEntities<ait_servicerequest>(nameof (business_unit_ait_servicerequest), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_servicerequest));
      }
    }

    [RelationshipSchemaName("business_unit_appointment_activities")]
    public IEnumerable<Appointment> business_unit_appointment_activities
    {
      get
      {
        return this.GetRelatedEntities<Appointment>(nameof (business_unit_appointment_activities), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_appointment_activities));
        this.SetRelatedEntities<Appointment>(nameof (business_unit_appointment_activities), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_appointment_activities));
      }
    }

    [RelationshipSchemaName("business_unit_connections")]
    public IEnumerable<Connection> business_unit_connections
    {
      get
      {
        return this.GetRelatedEntities<Connection>(nameof (business_unit_connections), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_connections));
        this.SetRelatedEntities<Connection>(nameof (business_unit_connections), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_connections));
      }
    }

    [RelationshipSchemaName("business_unit_contacts")]
    public IEnumerable<Contact> business_unit_contacts
    {
      get => this.GetRelatedEntities<Contact>(nameof (business_unit_contacts), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (business_unit_contacts));
        this.SetRelatedEntities<Contact>(nameof (business_unit_contacts), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_contacts));
      }
    }

    [RelationshipSchemaName("business_unit_email_activities")]
    public IEnumerable<Email> business_unit_email_activities
    {
      get
      {
        return this.GetRelatedEntities<Email>(nameof (business_unit_email_activities), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_email_activities));
        this.SetRelatedEntities<Email>(nameof (business_unit_email_activities), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_email_activities));
      }
    }

    [RelationshipSchemaName]
    public IEnumerable<BusinessUnit> Referencedbusiness_unit_parent_business_unit
    {
      get
      {
        return this.GetRelatedEntities<BusinessUnit>("business_unit_parent_business_unit", new EntityRole?((EntityRole) 1));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencedbusiness_unit_parent_business_unit));
        this.SetRelatedEntities<BusinessUnit>("business_unit_parent_business_unit", new EntityRole?((EntityRole) 1), value);
        this.OnPropertyChanged(nameof (Referencedbusiness_unit_parent_business_unit));
      }
    }

    [RelationshipSchemaName("business_unit_phone_call_activities")]
    public IEnumerable<PhoneCall> business_unit_phone_call_activities
    {
      get
      {
        return this.GetRelatedEntities<PhoneCall>(nameof (business_unit_phone_call_activities), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_phone_call_activities));
        this.SetRelatedEntities<PhoneCall>(nameof (business_unit_phone_call_activities), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_phone_call_activities));
      }
    }

    [RelationshipSchemaName("business_unit_system_users")]
    public IEnumerable<SystemUser> business_unit_system_users
    {
      get
      {
        return this.GetRelatedEntities<SystemUser>(nameof (business_unit_system_users), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_system_users));
        this.SetRelatedEntities<SystemUser>(nameof (business_unit_system_users), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_system_users));
      }
    }

    [RelationshipSchemaName("business_unit_task_activities")]
    public IEnumerable<Task> business_unit_task_activities
    {
      get
      {
        return this.GetRelatedEntities<Task>(nameof (business_unit_task_activities), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_task_activities));
        this.SetRelatedEntities<Task>(nameof (business_unit_task_activities), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_task_activities));
      }
    }

    [RelationshipSchemaName("business_unit_teams")]
    public IEnumerable<Team> business_unit_teams
    {
      get => this.GetRelatedEntities<Team>(nameof (business_unit_teams), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (business_unit_teams));
        this.SetRelatedEntities<Team>(nameof (business_unit_teams), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_teams));
      }
    }

    [RelationshipSchemaName("business_unit_user_settings")]
    public IEnumerable<UserSettings> business_unit_user_settings
    {
      get
      {
        return this.GetRelatedEntities<UserSettings>(nameof (business_unit_user_settings), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_user_settings));
        this.SetRelatedEntities<UserSettings>(nameof (business_unit_user_settings), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_user_settings));
      }
    }

    [AttributeLogicalName("parentbusinessunitid")]
    [RelationshipSchemaName]
    public BusinessUnit Referencingbusiness_unit_parent_business_unit
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>("business_unit_parent_business_unit", new EntityRole?((EntityRole) 0));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencingbusiness_unit_parent_business_unit));
        this.SetRelatedEntity<BusinessUnit>("business_unit_parent_business_unit", new EntityRole?((EntityRole) 0), value);
        this.OnPropertyChanged(nameof (Referencingbusiness_unit_parent_business_unit));
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_businessunit_createdonbehalfby")]
    public SystemUser lk_businessunit_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_businessunit_createdonbehalfby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_businessunit_modifiedonbehalfby")]
    public SystemUser lk_businessunit_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_businessunit_modifiedonbehalfby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_businessunitbase_createdby")]
    public SystemUser lk_businessunitbase_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_businessunitbase_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_businessunitbase_modifiedby")]
    public SystemUser lk_businessunitbase_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_businessunitbase_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_business_units")]
    public Organization organization_business_units
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_business_units), new EntityRole?());
      }
    }
  }
}
