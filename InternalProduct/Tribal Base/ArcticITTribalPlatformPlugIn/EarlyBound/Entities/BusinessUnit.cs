// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.BusinessUnit
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("businessunit")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class BusinessUnit : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "businessunit";
    public const string EntitySchemaName = "BusinessUnit";
    public const string PrimaryIdAttribute = "businessunitid";
    public const string PrimaryNameAttribute = "name";

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
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (BusinessUnitId));
      }
    }

    [AttributeLogicalName("businessunitid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.BusinessUnitId = new Guid?(value);
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

    [RelationshipSchemaName("actioncardusersettings_businessunit")]
    public IEnumerable<ActionCardUserSettings> actioncardusersettings_businessunit
    {
      get
      {
        return this.GetRelatedEntities<ActionCardUserSettings>(nameof (actioncardusersettings_businessunit), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (actioncardusersettings_businessunit));
        this.SetRelatedEntities<ActionCardUserSettings>(nameof (actioncardusersettings_businessunit), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (actioncardusersettings_businessunit));
      }
    }

    [RelationshipSchemaName("BulkDeleteOperation_BusinessUnit")]
    public IEnumerable<BulkDeleteOperation> BulkDeleteOperation_BusinessUnit
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteOperation>(nameof (BulkDeleteOperation_BusinessUnit), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (BulkDeleteOperation_BusinessUnit));
        this.SetRelatedEntities<BulkDeleteOperation>(nameof (BulkDeleteOperation_BusinessUnit), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (BulkDeleteOperation_BusinessUnit));
      }
    }

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

    [RelationshipSchemaName("business_unit_actioncards")]
    public IEnumerable<ActionCard> business_unit_actioncards
    {
      get
      {
        return this.GetRelatedEntities<ActionCard>(nameof (business_unit_actioncards), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_actioncards));
        this.SetRelatedEntities<ActionCard>(nameof (business_unit_actioncards), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_actioncards));
      }
    }

    [RelationshipSchemaName("business_unit_activitypointer")]
    public IEnumerable<ActivityPointer> business_unit_activitypointer
    {
      get
      {
        return this.GetRelatedEntities<ActivityPointer>(nameof (business_unit_activitypointer), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_activitypointer));
        this.SetRelatedEntities<ActivityPointer>(nameof (business_unit_activitypointer), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_activitypointer));
      }
    }

    [RelationshipSchemaName("business_unit_ait_accountingcode")]
    public IEnumerable<ait_accountingcode> business_unit_ait_accountingcode
    {
      get
      {
        return this.GetRelatedEntities<ait_accountingcode>(nameof (business_unit_ait_accountingcode), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_accountingcode));
        this.SetRelatedEntities<ait_accountingcode>(nameof (business_unit_ait_accountingcode), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_accountingcode));
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

    [RelationshipSchemaName("business_unit_ait_bankaccount")]
    public IEnumerable<ait_bankaccount> business_unit_ait_bankaccount
    {
      get
      {
        return this.GetRelatedEntities<ait_bankaccount>(nameof (business_unit_ait_bankaccount), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_bankaccount));
        this.SetRelatedEntities<ait_bankaccount>(nameof (business_unit_ait_bankaccount), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_bankaccount));
      }
    }

    [RelationshipSchemaName("business_unit_ait_birthrecord")]
    public IEnumerable<ait_birthrecord> business_unit_ait_birthrecord
    {
      get
      {
        return this.GetRelatedEntities<ait_birthrecord>(nameof (business_unit_ait_birthrecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_birthrecord));
        this.SetRelatedEntities<ait_birthrecord>(nameof (business_unit_ait_birthrecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_birthrecord));
      }
    }

    [RelationshipSchemaName("business_unit_ait_bloodquantum")]
    public IEnumerable<ait_bloodquantum> business_unit_ait_bloodquantum
    {
      get
      {
        return this.GetRelatedEntities<ait_bloodquantum>(nameof (business_unit_ait_bloodquantum), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_bloodquantum));
        this.SetRelatedEntities<ait_bloodquantum>(nameof (business_unit_ait_bloodquantum), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_bloodquantum));
      }
    }

    [RelationshipSchemaName("business_unit_ait_cardhistory")]
    public IEnumerable<ait_cardhistory> business_unit_ait_cardhistory
    {
      get
      {
        return this.GetRelatedEntities<ait_cardhistory>(nameof (business_unit_ait_cardhistory), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_cardhistory));
        this.SetRelatedEntities<ait_cardhistory>(nameof (business_unit_ait_cardhistory), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_cardhistory));
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

    [RelationshipSchemaName("business_unit_ait_casenote")]
    public IEnumerable<ait_casenote> business_unit_ait_casenote
    {
      get
      {
        return this.GetRelatedEntities<ait_casenote>(nameof (business_unit_ait_casenote), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_casenote));
        this.SetRelatedEntities<ait_casenote>(nameof (business_unit_ait_casenote), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_casenote));
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

    [RelationshipSchemaName("business_unit_ait_changerequest")]
    public IEnumerable<ait_changerequest> business_unit_ait_changerequest
    {
      get
      {
        return this.GetRelatedEntities<ait_changerequest>(nameof (business_unit_ait_changerequest), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_changerequest));
        this.SetRelatedEntities<ait_changerequest>(nameof (business_unit_ait_changerequest), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_changerequest));
      }
    }

    [RelationshipSchemaName("business_unit_ait_changerequesttype")]
    public IEnumerable<ait_changerequesttype> business_unit_ait_changerequesttype
    {
      get
      {
        return this.GetRelatedEntities<ait_changerequesttype>(nameof (business_unit_ait_changerequesttype), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_changerequesttype));
        this.SetRelatedEntities<ait_changerequesttype>(nameof (business_unit_ait_changerequesttype), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_changerequesttype));
      }
    }

    [RelationshipSchemaName("business_unit_ait_charge")]
    public IEnumerable<ait_charge> business_unit_ait_charge
    {
      get
      {
        return this.GetRelatedEntities<ait_charge>(nameof (business_unit_ait_charge), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_charge));
        this.SetRelatedEntities<ait_charge>(nameof (business_unit_ait_charge), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_charge));
      }
    }

    [RelationshipSchemaName("business_unit_ait_childvisitations")]
    public IEnumerable<ait_childvisitations> business_unit_ait_childvisitations
    {
      get
      {
        return this.GetRelatedEntities<ait_childvisitations>(nameof (business_unit_ait_childvisitations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_childvisitations));
        this.SetRelatedEntities<ait_childvisitations>(nameof (business_unit_ait_childvisitations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_childvisitations));
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

    [RelationshipSchemaName("business_unit_ait_company")]
    public IEnumerable<ait_company> business_unit_ait_company
    {
      get
      {
        return this.GetRelatedEntities<ait_company>(nameof (business_unit_ait_company), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_company));
        this.SetRelatedEntities<ait_company>(nameof (business_unit_ait_company), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_company));
      }
    }

    [RelationshipSchemaName("business_unit_ait_contactcertification")]
    public IEnumerable<ait_contactcertification> business_unit_ait_contactcertification
    {
      get
      {
        return this.GetRelatedEntities<ait_contactcertification>(nameof (business_unit_ait_contactcertification), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_contactcertification));
        this.SetRelatedEntities<ait_contactcertification>(nameof (business_unit_ait_contactcertification), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_contactcertification));
      }
    }

    [RelationshipSchemaName("business_unit_ait_contacteducation")]
    public IEnumerable<ait_contacteducation> business_unit_ait_contacteducation
    {
      get
      {
        return this.GetRelatedEntities<ait_contacteducation>(nameof (business_unit_ait_contacteducation), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_contacteducation));
        this.SetRelatedEntities<ait_contacteducation>(nameof (business_unit_ait_contacteducation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_contacteducation));
      }
    }

    [RelationshipSchemaName("business_unit_ait_contactemployment")]
    public IEnumerable<ait_contactemployment> business_unit_ait_contactemployment
    {
      get
      {
        return this.GetRelatedEntities<ait_contactemployment>(nameof (business_unit_ait_contactemployment), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_contactemployment));
        this.SetRelatedEntities<ait_contactemployment>(nameof (business_unit_ait_contactemployment), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_contactemployment));
      }
    }

    [RelationshipSchemaName("business_unit_ait_contactimage")]
    public IEnumerable<ait_contactimage> business_unit_ait_contactimage
    {
      get
      {
        return this.GetRelatedEntities<ait_contactimage>(nameof (business_unit_ait_contactimage), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_contactimage));
        this.SetRelatedEntities<ait_contactimage>(nameof (business_unit_ait_contactimage), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_contactimage));
      }
    }

    [RelationshipSchemaName("business_unit_ait_contactincarceration")]
    public IEnumerable<ait_contactincarceration> business_unit_ait_contactincarceration
    {
      get
      {
        return this.GetRelatedEntities<ait_contactincarceration>(nameof (business_unit_ait_contactincarceration), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_contactincarceration));
        this.SetRelatedEntities<ait_contactincarceration>(nameof (business_unit_ait_contactincarceration), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_contactincarceration));
      }
    }

    [RelationshipSchemaName("business_unit_ait_contactincomeandexpense")]
    public IEnumerable<ait_contactincomeandexpense> business_unit_ait_contactincomeandexpense
    {
      get
      {
        return this.GetRelatedEntities<ait_contactincomeandexpense>(nameof (business_unit_ait_contactincomeandexpense), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_contactincomeandexpense));
        this.SetRelatedEntities<ait_contactincomeandexpense>(nameof (business_unit_ait_contactincomeandexpense), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_contactincomeandexpense));
      }
    }

    [RelationshipSchemaName("business_unit_ait_contactlanguage")]
    public IEnumerable<ait_contactlanguage> business_unit_ait_contactlanguage
    {
      get
      {
        return this.GetRelatedEntities<ait_contactlanguage>(nameof (business_unit_ait_contactlanguage), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_contactlanguage));
        this.SetRelatedEntities<ait_contactlanguage>(nameof (business_unit_ait_contactlanguage), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_contactlanguage));
      }
    }

    [RelationshipSchemaName("business_unit_ait_contactmilitaryservice")]
    public IEnumerable<ait_contactmilitaryservice> business_unit_ait_contactmilitaryservice
    {
      get
      {
        return this.GetRelatedEntities<ait_contactmilitaryservice>(nameof (business_unit_ait_contactmilitaryservice), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_contactmilitaryservice));
        this.SetRelatedEntities<ait_contactmilitaryservice>(nameof (business_unit_ait_contactmilitaryservice), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_contactmilitaryservice));
      }
    }

    [RelationshipSchemaName("business_unit_ait_contactname")]
    public IEnumerable<ait_contactname> business_unit_ait_contactname
    {
      get
      {
        return this.GetRelatedEntities<ait_contactname>(nameof (business_unit_ait_contactname), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_contactname));
        this.SetRelatedEntities<ait_contactname>(nameof (business_unit_ait_contactname), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_contactname));
      }
    }

    [RelationshipSchemaName("business_unit_ait_contactskill")]
    public IEnumerable<ait_contactskill> business_unit_ait_contactskill
    {
      get
      {
        return this.GetRelatedEntities<ait_contactskill>(nameof (business_unit_ait_contactskill), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_contactskill));
        this.SetRelatedEntities<ait_contactskill>(nameof (business_unit_ait_contactskill), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_contactskill));
      }
    }

    [RelationshipSchemaName("business_unit_ait_courtcase")]
    public IEnumerable<ait_courtcase> business_unit_ait_courtcase
    {
      get
      {
        return this.GetRelatedEntities<ait_courtcase>(nameof (business_unit_ait_courtcase), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_courtcase));
        this.SetRelatedEntities<ait_courtcase>(nameof (business_unit_ait_courtcase), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_courtcase));
      }
    }

    [RelationshipSchemaName("business_unit_ait_courtfinesandfees")]
    public IEnumerable<ait_courtfinesandfees> business_unit_ait_courtfinesandfees
    {
      get
      {
        return this.GetRelatedEntities<ait_courtfinesandfees>(nameof (business_unit_ait_courtfinesandfees), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_courtfinesandfees));
        this.SetRelatedEntities<ait_courtfinesandfees>(nameof (business_unit_ait_courtfinesandfees), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_courtfinesandfees));
      }
    }

    [RelationshipSchemaName("business_unit_ait_courtparty")]
    public IEnumerable<ait_courtparty> business_unit_ait_courtparty
    {
      get
      {
        return this.GetRelatedEntities<ait_courtparty>(nameof (business_unit_ait_courtparty), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_courtparty));
        this.SetRelatedEntities<ait_courtparty>(nameof (business_unit_ait_courtparty), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_courtparty));
      }
    }

    [RelationshipSchemaName("business_unit_ait_courtpayments")]
    public IEnumerable<ait_courtpayments> business_unit_ait_courtpayments
    {
      get
      {
        return this.GetRelatedEntities<ait_courtpayments>(nameof (business_unit_ait_courtpayments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_courtpayments));
        this.SetRelatedEntities<ait_courtpayments>(nameof (business_unit_ait_courtpayments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_courtpayments));
      }
    }

    [RelationshipSchemaName("business_unit_ait_courtprofile")]
    public IEnumerable<ait_courtprofile> business_unit_ait_courtprofile
    {
      get
      {
        return this.GetRelatedEntities<ait_courtprofile>(nameof (business_unit_ait_courtprofile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_courtprofile));
        this.SetRelatedEntities<ait_courtprofile>(nameof (business_unit_ait_courtprofile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_courtprofile));
      }
    }

    [RelationshipSchemaName("business_unit_ait_courtprofileaddress")]
    public IEnumerable<ait_courtprofileaddress> business_unit_ait_courtprofileaddress
    {
      get
      {
        return this.GetRelatedEntities<ait_courtprofileaddress>(nameof (business_unit_ait_courtprofileaddress), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_courtprofileaddress));
        this.SetRelatedEntities<ait_courtprofileaddress>(nameof (business_unit_ait_courtprofileaddress), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_courtprofileaddress));
      }
    }

    [RelationshipSchemaName("business_unit_ait_courtroom")]
    public IEnumerable<ait_courtroom> business_unit_ait_courtroom
    {
      get
      {
        return this.GetRelatedEntities<ait_courtroom>(nameof (business_unit_ait_courtroom), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_courtroom));
        this.SetRelatedEntities<ait_courtroom>(nameof (business_unit_ait_courtroom), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_courtroom));
      }
    }

    [RelationshipSchemaName("business_unit_ait_datamigrationhistory")]
    public IEnumerable<ait_datamigrationhistory> business_unit_ait_datamigrationhistory
    {
      get
      {
        return this.GetRelatedEntities<ait_datamigrationhistory>(nameof (business_unit_ait_datamigrationhistory), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_datamigrationhistory));
        this.SetRelatedEntities<ait_datamigrationhistory>(nameof (business_unit_ait_datamigrationhistory), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_datamigrationhistory));
      }
    }

    [RelationshipSchemaName("business_unit_ait_deathrecord")]
    public IEnumerable<ait_deathrecord> business_unit_ait_deathrecord
    {
      get
      {
        return this.GetRelatedEntities<ait_deathrecord>(nameof (business_unit_ait_deathrecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_deathrecord));
        this.SetRelatedEntities<ait_deathrecord>(nameof (business_unit_ait_deathrecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_deathrecord));
      }
    }

    [RelationshipSchemaName("business_unit_ait_electronicaddress")]
    public IEnumerable<ait_electronicaddress> business_unit_ait_electronicaddress
    {
      get
      {
        return this.GetRelatedEntities<ait_electronicaddress>(nameof (business_unit_ait_electronicaddress), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_electronicaddress));
        this.SetRelatedEntities<ait_electronicaddress>(nameof (business_unit_ait_electronicaddress), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_electronicaddress));
      }
    }

    [RelationshipSchemaName("business_unit_ait_emergencycontact")]
    public IEnumerable<ait_emergencycontact> business_unit_ait_emergencycontact
    {
      get
      {
        return this.GetRelatedEntities<ait_emergencycontact>(nameof (business_unit_ait_emergencycontact), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_emergencycontact));
        this.SetRelatedEntities<ait_emergencycontact>(nameof (business_unit_ait_emergencycontact), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_emergencycontact));
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

    [RelationshipSchemaName("business_unit_ait_household")]
    public IEnumerable<ait_household> business_unit_ait_household
    {
      get
      {
        return this.GetRelatedEntities<ait_household>(nameof (business_unit_ait_household), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_household));
        this.SetRelatedEntities<ait_household>(nameof (business_unit_ait_household), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_household));
      }
    }

    [RelationshipSchemaName("business_unit_ait_householdmember")]
    public IEnumerable<ait_householdmember> business_unit_ait_householdmember
    {
      get
      {
        return this.GetRelatedEntities<ait_householdmember>(nameof (business_unit_ait_householdmember), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_householdmember));
        this.SetRelatedEntities<ait_householdmember>(nameof (business_unit_ait_householdmember), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_householdmember));
      }
    }

    [RelationshipSchemaName("business_unit_ait_icwaadoption")]
    public IEnumerable<ait_icwaadoption> business_unit_ait_icwaadoption
    {
      get
      {
        return this.GetRelatedEntities<ait_icwaadoption>(nameof (business_unit_ait_icwaadoption), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_icwaadoption));
        this.SetRelatedEntities<ait_icwaadoption>(nameof (business_unit_ait_icwaadoption), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_icwaadoption));
      }
    }

    [RelationshipSchemaName("business_unit_ait_icwanotice")]
    public IEnumerable<ait_icwanotice> business_unit_ait_icwanotice
    {
      get
      {
        return this.GetRelatedEntities<ait_icwanotice>(nameof (business_unit_ait_icwanotice), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_icwanotice));
        this.SetRelatedEntities<ait_icwanotice>(nameof (business_unit_ait_icwanotice), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_icwanotice));
      }
    }

    [RelationshipSchemaName("business_unit_ait_icwaregion")]
    public IEnumerable<ait_icwaregion> business_unit_ait_icwaregion
    {
      get
      {
        return this.GetRelatedEntities<ait_icwaregion>(nameof (business_unit_ait_icwaregion), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_icwaregion));
        this.SetRelatedEntities<ait_icwaregion>(nameof (business_unit_ait_icwaregion), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_icwaregion));
      }
    }

    [RelationshipSchemaName("business_unit_ait_icwaregionnotification")]
    public IEnumerable<ait_icwaregionnotification> business_unit_ait_icwaregionnotification
    {
      get
      {
        return this.GetRelatedEntities<ait_icwaregionnotification>(nameof (business_unit_ait_icwaregionnotification), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_icwaregionnotification));
        this.SetRelatedEntities<ait_icwaregionnotification>(nameof (business_unit_ait_icwaregionnotification), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_icwaregionnotification));
      }
    }

    [RelationshipSchemaName("business_unit_ait_loan")]
    public IEnumerable<ait_loan> business_unit_ait_loan
    {
      get => this.GetRelatedEntities<ait_loan>(nameof (business_unit_ait_loan), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_loan));
        this.SetRelatedEntities<ait_loan>(nameof (business_unit_ait_loan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_loan));
      }
    }

    [RelationshipSchemaName("business_unit_ait_loandetail")]
    public IEnumerable<ait_loandetail> business_unit_ait_loandetail
    {
      get
      {
        return this.GetRelatedEntities<ait_loandetail>(nameof (business_unit_ait_loandetail), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_loandetail));
        this.SetRelatedEntities<ait_loandetail>(nameof (business_unit_ait_loandetail), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_loandetail));
      }
    }

    [RelationshipSchemaName("business_unit_ait_loantype")]
    public IEnumerable<ait_loantype> business_unit_ait_loantype
    {
      get
      {
        return this.GetRelatedEntities<ait_loantype>(nameof (business_unit_ait_loantype), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_loantype));
        this.SetRelatedEntities<ait_loantype>(nameof (business_unit_ait_loantype), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_loantype));
      }
    }

    [RelationshipSchemaName("business_unit_ait_memberprofile")]
    public IEnumerable<ait_memberprofile> business_unit_ait_memberprofile
    {
      get
      {
        return this.GetRelatedEntities<ait_memberprofile>(nameof (business_unit_ait_memberprofile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_memberprofile));
        this.SetRelatedEntities<ait_memberprofile>(nameof (business_unit_ait_memberprofile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_memberprofile));
      }
    }

    [RelationshipSchemaName("business_unit_ait_memberprofilemembershipcategory")]
    public IEnumerable<ait_memberprofilemembershipcategory> business_unit_ait_memberprofilemembershipcategory
    {
      get
      {
        return this.GetRelatedEntities<ait_memberprofilemembershipcategory>(nameof (business_unit_ait_memberprofilemembershipcategory), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_memberprofilemembershipcategory));
        this.SetRelatedEntities<ait_memberprofilemembershipcategory>(nameof (business_unit_ait_memberprofilemembershipcategory), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_memberprofilemembershipcategory));
      }
    }

    [RelationshipSchemaName("business_unit_ait_memberroll")]
    public IEnumerable<ait_memberroll> business_unit_ait_memberroll
    {
      get
      {
        return this.GetRelatedEntities<ait_memberroll>(nameof (business_unit_ait_memberroll), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_memberroll));
        this.SetRelatedEntities<ait_memberroll>(nameof (business_unit_ait_memberroll), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_memberroll));
      }
    }

    [RelationshipSchemaName("business_unit_ait_membershipstatuschangerequest")]
    public IEnumerable<ait_membershipstatuschangerequest> business_unit_ait_membershipstatuschangerequest
    {
      get
      {
        return this.GetRelatedEntities<ait_membershipstatuschangerequest>(nameof (business_unit_ait_membershipstatuschangerequest), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_membershipstatuschangerequest));
        this.SetRelatedEntities<ait_membershipstatuschangerequest>(nameof (business_unit_ait_membershipstatuschangerequest), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_membershipstatuschangerequest));
      }
    }

    [RelationshipSchemaName("business_unit_ait_outcome")]
    public IEnumerable<ait_outcome> business_unit_ait_outcome
    {
      get
      {
        return this.GetRelatedEntities<ait_outcome>(nameof (business_unit_ait_outcome), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_outcome));
        this.SetRelatedEntities<ait_outcome>(nameof (business_unit_ait_outcome), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_outcome));
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

    [RelationshipSchemaName("business_unit_ait_physicaladdress")]
    public IEnumerable<ait_physicaladdress> business_unit_ait_physicaladdress
    {
      get
      {
        return this.GetRelatedEntities<ait_physicaladdress>(nameof (business_unit_ait_physicaladdress), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_physicaladdress));
        this.SetRelatedEntities<ait_physicaladdress>(nameof (business_unit_ait_physicaladdress), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_physicaladdress));
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

    [RelationshipSchemaName("business_unit_ait_pmteligibility")]
    public IEnumerable<ait_pmteligibility> business_unit_ait_pmteligibility
    {
      get
      {
        return this.GetRelatedEntities<ait_pmteligibility>(nameof (business_unit_ait_pmteligibility), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_pmteligibility));
        this.SetRelatedEntities<ait_pmteligibility>(nameof (business_unit_ait_pmteligibility), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_pmteligibility));
      }
    }

    [RelationshipSchemaName("business_unit_ait_pmtevent")]
    public IEnumerable<ait_pmtevent> business_unit_ait_pmtevent
    {
      get
      {
        return this.GetRelatedEntities<ait_pmtevent>(nameof (business_unit_ait_pmtevent), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_pmtevent));
        this.SetRelatedEntities<ait_pmtevent>(nameof (business_unit_ait_pmtevent), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_pmtevent));
      }
    }

    [RelationshipSchemaName("business_unit_ait_pmtpaymenttype")]
    public IEnumerable<ait_pmtpaymenttype> business_unit_ait_pmtpaymenttype
    {
      get
      {
        return this.GetRelatedEntities<ait_pmtpaymenttype>(nameof (business_unit_ait_pmtpaymenttype), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_pmtpaymenttype));
        this.SetRelatedEntities<ait_pmtpaymenttype>(nameof (business_unit_ait_pmtpaymenttype), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_pmtpaymenttype));
      }
    }

    [RelationshipSchemaName("business_unit_ait_pmttransaction")]
    public IEnumerable<ait_pmttransaction> business_unit_ait_pmttransaction
    {
      get
      {
        return this.GetRelatedEntities<ait_pmttransaction>(nameof (business_unit_ait_pmttransaction), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_pmttransaction));
        this.SetRelatedEntities<ait_pmttransaction>(nameof (business_unit_ait_pmttransaction), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_pmttransaction));
      }
    }

    [RelationshipSchemaName("business_unit_ait_pmttransactiondeduction")]
    public IEnumerable<ait_pmttransactiondeduction> business_unit_ait_pmttransactiondeduction
    {
      get
      {
        return this.GetRelatedEntities<ait_pmttransactiondeduction>(nameof (business_unit_ait_pmttransactiondeduction), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_pmttransactiondeduction));
        this.SetRelatedEntities<ait_pmttransactiondeduction>(nameof (business_unit_ait_pmttransactiondeduction), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_pmttransactiondeduction));
      }
    }

    [RelationshipSchemaName("business_unit_ait_pmtwithholding")]
    public IEnumerable<ait_pmtwithholding> business_unit_ait_pmtwithholding
    {
      get
      {
        return this.GetRelatedEntities<ait_pmtwithholding>(nameof (business_unit_ait_pmtwithholding), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_pmtwithholding));
        this.SetRelatedEntities<ait_pmtwithholding>(nameof (business_unit_ait_pmtwithholding), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_pmtwithholding));
      }
    }

    [RelationshipSchemaName("business_unit_ait_pmtwithholdingoverride")]
    public IEnumerable<ait_pmtwithholdingoverride> business_unit_ait_pmtwithholdingoverride
    {
      get
      {
        return this.GetRelatedEntities<ait_pmtwithholdingoverride>(nameof (business_unit_ait_pmtwithholdingoverride), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_pmtwithholdingoverride));
        this.SetRelatedEntities<ait_pmtwithholdingoverride>(nameof (business_unit_ait_pmtwithholdingoverride), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_pmtwithholdingoverride));
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

    [RelationshipSchemaName("business_unit_ait_relationship")]
    public IEnumerable<ait_relationship> business_unit_ait_relationship
    {
      get
      {
        return this.GetRelatedEntities<ait_relationship>(nameof (business_unit_ait_relationship), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_relationship));
        this.SetRelatedEntities<ait_relationship>(nameof (business_unit_ait_relationship), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_relationship));
      }
    }

    [RelationshipSchemaName("business_unit_ait_resolution")]
    public IEnumerable<ait_resolution> business_unit_ait_resolution
    {
      get
      {
        return this.GetRelatedEntities<ait_resolution>(nameof (business_unit_ait_resolution), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_resolution));
        this.SetRelatedEntities<ait_resolution>(nameof (business_unit_ait_resolution), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_resolution));
      }
    }

    [RelationshipSchemaName("business_unit_ait_safetyplan")]
    public IEnumerable<ait_safetyplan> business_unit_ait_safetyplan
    {
      get
      {
        return this.GetRelatedEntities<ait_safetyplan>(nameof (business_unit_ait_safetyplan), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_safetyplan));
        this.SetRelatedEntities<ait_safetyplan>(nameof (business_unit_ait_safetyplan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_safetyplan));
      }
    }

    [RelationshipSchemaName("business_unit_ait_school")]
    public IEnumerable<ait_school> business_unit_ait_school
    {
      get
      {
        return this.GetRelatedEntities<ait_school>(nameof (business_unit_ait_school), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_school));
        this.SetRelatedEntities<ait_school>(nameof (business_unit_ait_school), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_school));
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

    [RelationshipSchemaName("business_unit_ait_statute")]
    public IEnumerable<ait_statute> business_unit_ait_statute
    {
      get
      {
        return this.GetRelatedEntities<ait_statute>(nameof (business_unit_ait_statute), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_statute));
        this.SetRelatedEntities<ait_statute>(nameof (business_unit_ait_statute), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_statute));
      }
    }

    [RelationshipSchemaName("business_unit_ait_training")]
    public IEnumerable<ait_training> business_unit_ait_training
    {
      get
      {
        return this.GetRelatedEntities<ait_training>(nameof (business_unit_ait_training), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_training));
        this.SetRelatedEntities<ait_training>(nameof (business_unit_ait_training), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_training));
      }
    }

    [RelationshipSchemaName("business_unit_ait_trainingtype")]
    public IEnumerable<ait_trainingtype> business_unit_ait_trainingtype
    {
      get
      {
        return this.GetRelatedEntities<ait_trainingtype>(nameof (business_unit_ait_trainingtype), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_trainingtype));
        this.SetRelatedEntities<ait_trainingtype>(nameof (business_unit_ait_trainingtype), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_trainingtype));
      }
    }

    [RelationshipSchemaName("business_unit_ait_tribalenrollmentconfiguration")]
    public IEnumerable<ait_tribalenrollmentconfiguration> business_unit_ait_tribalenrollmentconfiguration
    {
      get
      {
        return this.GetRelatedEntities<ait_tribalenrollmentconfiguration>(nameof (business_unit_ait_tribalenrollmentconfiguration), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_tribalenrollmentconfiguration));
        this.SetRelatedEntities<ait_tribalenrollmentconfiguration>(nameof (business_unit_ait_tribalenrollmentconfiguration), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_tribalenrollmentconfiguration));
      }
    }

    [RelationshipSchemaName("business_unit_ait_withholdingtype")]
    public IEnumerable<ait_withholdingtype> business_unit_ait_withholdingtype
    {
      get
      {
        return this.GetRelatedEntities<ait_withholdingtype>(nameof (business_unit_ait_withholdingtype), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_ait_withholdingtype));
        this.SetRelatedEntities<ait_withholdingtype>(nameof (business_unit_ait_withholdingtype), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_ait_withholdingtype));
      }
    }

    [RelationshipSchemaName("business_unit_annotations")]
    public IEnumerable<Annotation> business_unit_annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (business_unit_annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_annotations));
        this.SetRelatedEntities<Annotation>(nameof (business_unit_annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_annotations));
      }
    }

    [RelationshipSchemaName("business_unit_applicationuser")]
    public IEnumerable<ApplicationUser> business_unit_applicationuser
    {
      get
      {
        return this.GetRelatedEntities<ApplicationUser>(nameof (business_unit_applicationuser), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_applicationuser));
        this.SetRelatedEntities<ApplicationUser>(nameof (business_unit_applicationuser), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_applicationuser));
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

    [RelationshipSchemaName("business_unit_asyncoperation")]
    public IEnumerable<AsyncOperation> business_unit_asyncoperation
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (business_unit_asyncoperation), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_asyncoperation));
        this.SetRelatedEntities<AsyncOperation>(nameof (business_unit_asyncoperation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_asyncoperation));
      }
    }

    [RelationshipSchemaName("business_unit_bot")]
    public IEnumerable<bot> business_unit_bot
    {
      get => this.GetRelatedEntities<bot>(nameof (business_unit_bot), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (business_unit_bot));
        this.SetRelatedEntities<bot>(nameof (business_unit_bot), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_bot));
      }
    }

    [RelationshipSchemaName("business_unit_botcomponent")]
    public IEnumerable<botcomponent> business_unit_botcomponent
    {
      get
      {
        return this.GetRelatedEntities<botcomponent>(nameof (business_unit_botcomponent), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_botcomponent));
        this.SetRelatedEntities<botcomponent>(nameof (business_unit_botcomponent), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_botcomponent));
      }
    }

    [RelationshipSchemaName("business_unit_calendars")]
    public IEnumerable<Calendar> business_unit_calendars
    {
      get => this.GetRelatedEntities<Calendar>(nameof (business_unit_calendars), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (business_unit_calendars));
        this.SetRelatedEntities<Calendar>(nameof (business_unit_calendars), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_calendars));
      }
    }

    [RelationshipSchemaName("business_unit_canvasappextendedmetadata")]
    public IEnumerable<CanvasAppExtendedMetadata> business_unit_canvasappextendedmetadata
    {
      get
      {
        return this.GetRelatedEntities<CanvasAppExtendedMetadata>(nameof (business_unit_canvasappextendedmetadata), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_canvasappextendedmetadata));
        this.SetRelatedEntities<CanvasAppExtendedMetadata>(nameof (business_unit_canvasappextendedmetadata), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_canvasappextendedmetadata));
      }
    }

    [RelationshipSchemaName("business_unit_category")]
    public IEnumerable<Category> business_unit_category
    {
      get => this.GetRelatedEntities<Category>(nameof (business_unit_category), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (business_unit_category));
        this.SetRelatedEntities<Category>(nameof (business_unit_category), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_category));
      }
    }

    [RelationshipSchemaName("business_unit_channelaccessprofile")]
    public IEnumerable<ChannelAccessProfile> business_unit_channelaccessprofile
    {
      get
      {
        return this.GetRelatedEntities<ChannelAccessProfile>(nameof (business_unit_channelaccessprofile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_channelaccessprofile));
        this.SetRelatedEntities<ChannelAccessProfile>(nameof (business_unit_channelaccessprofile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_channelaccessprofile));
      }
    }

    [RelationshipSchemaName("business_unit_connectionreference")]
    public IEnumerable<connectionreference> business_unit_connectionreference
    {
      get
      {
        return this.GetRelatedEntities<connectionreference>(nameof (business_unit_connectionreference), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_connectionreference));
        this.SetRelatedEntities<connectionreference>(nameof (business_unit_connectionreference), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_connectionreference));
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

    [RelationshipSchemaName("business_unit_connector")]
    public IEnumerable<connector> business_unit_connector
    {
      get
      {
        return this.GetRelatedEntities<connector>(nameof (business_unit_connector), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_connector));
        this.SetRelatedEntities<connector>(nameof (business_unit_connector), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_connector));
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

    [RelationshipSchemaName("business_unit_conversationtranscript")]
    public IEnumerable<conversationtranscript> business_unit_conversationtranscript
    {
      get
      {
        return this.GetRelatedEntities<conversationtranscript>(nameof (business_unit_conversationtranscript), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_conversationtranscript));
        this.SetRelatedEntities<conversationtranscript>(nameof (business_unit_conversationtranscript), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_conversationtranscript));
      }
    }

    [RelationshipSchemaName("business_unit_convertrule")]
    public IEnumerable<ConvertRule> business_unit_convertrule
    {
      get
      {
        return this.GetRelatedEntities<ConvertRule>(nameof (business_unit_convertrule), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_convertrule));
        this.SetRelatedEntities<ConvertRule>(nameof (business_unit_convertrule), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_convertrule));
      }
    }

    [RelationshipSchemaName("business_unit_customapi")]
    public IEnumerable<CustomAPI> business_unit_customapi
    {
      get
      {
        return this.GetRelatedEntities<CustomAPI>(nameof (business_unit_customapi), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_customapi));
        this.SetRelatedEntities<CustomAPI>(nameof (business_unit_customapi), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_customapi));
      }
    }

    [RelationshipSchemaName("business_unit_customer_relationship")]
    public IEnumerable<CustomerRelationship> business_unit_customer_relationship
    {
      get
      {
        return this.GetRelatedEntities<CustomerRelationship>(nameof (business_unit_customer_relationship), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_customer_relationship));
        this.SetRelatedEntities<CustomerRelationship>(nameof (business_unit_customer_relationship), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_customer_relationship));
      }
    }

    [RelationshipSchemaName("business_unit_datalakefolder")]
    public IEnumerable<datalakefolder> business_unit_datalakefolder
    {
      get
      {
        return this.GetRelatedEntities<datalakefolder>(nameof (business_unit_datalakefolder), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_datalakefolder));
        this.SetRelatedEntities<datalakefolder>(nameof (business_unit_datalakefolder), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_datalakefolder));
      }
    }

    [RelationshipSchemaName("business_unit_datalakefolderpermission")]
    public IEnumerable<datalakefolderpermission> business_unit_datalakefolderpermission
    {
      get
      {
        return this.GetRelatedEntities<datalakefolderpermission>(nameof (business_unit_datalakefolderpermission), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_datalakefolderpermission));
        this.SetRelatedEntities<datalakefolderpermission>(nameof (business_unit_datalakefolderpermission), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_datalakefolderpermission));
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

    [RelationshipSchemaName("business_unit_emailserverprofile")]
    public IEnumerable<EmailServerProfile> business_unit_emailserverprofile
    {
      get
      {
        return this.GetRelatedEntities<EmailServerProfile>(nameof (business_unit_emailserverprofile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_emailserverprofile));
        this.SetRelatedEntities<EmailServerProfile>(nameof (business_unit_emailserverprofile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_emailserverprofile));
      }
    }

    [RelationshipSchemaName("business_unit_emailsignatures")]
    public IEnumerable<EmailSignature> business_unit_emailsignatures
    {
      get
      {
        return this.GetRelatedEntities<EmailSignature>(nameof (business_unit_emailsignatures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_emailsignatures));
        this.SetRelatedEntities<EmailSignature>(nameof (business_unit_emailsignatures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_emailsignatures));
      }
    }

    [RelationshipSchemaName("business_unit_environmentvariabledefinition")]
    public IEnumerable<EnvironmentVariableDefinition> business_unit_environmentvariabledefinition
    {
      get
      {
        return this.GetRelatedEntities<EnvironmentVariableDefinition>(nameof (business_unit_environmentvariabledefinition), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_environmentvariabledefinition));
        this.SetRelatedEntities<EnvironmentVariableDefinition>(nameof (business_unit_environmentvariabledefinition), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_environmentvariabledefinition));
      }
    }

    [RelationshipSchemaName("business_unit_environmentvariablevalue")]
    public IEnumerable<EnvironmentVariableValue> business_unit_environmentvariablevalue
    {
      get
      {
        return this.GetRelatedEntities<EnvironmentVariableValue>(nameof (business_unit_environmentvariablevalue), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_environmentvariablevalue));
        this.SetRelatedEntities<EnvironmentVariableValue>(nameof (business_unit_environmentvariablevalue), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_environmentvariablevalue));
      }
    }

    [RelationshipSchemaName("business_unit_exchangesyncidmapping")]
    public IEnumerable<ExchangeSyncIdMapping> business_unit_exchangesyncidmapping
    {
      get
      {
        return this.GetRelatedEntities<ExchangeSyncIdMapping>(nameof (business_unit_exchangesyncidmapping), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_exchangesyncidmapping));
        this.SetRelatedEntities<ExchangeSyncIdMapping>(nameof (business_unit_exchangesyncidmapping), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_exchangesyncidmapping));
      }
    }

    [RelationshipSchemaName("business_unit_exportsolutionupload")]
    public IEnumerable<ExportSolutionUpload> business_unit_exportsolutionupload
    {
      get
      {
        return this.GetRelatedEntities<ExportSolutionUpload>(nameof (business_unit_exportsolutionupload), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_exportsolutionupload));
        this.SetRelatedEntities<ExportSolutionUpload>(nameof (business_unit_exportsolutionupload), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_exportsolutionupload));
      }
    }

    [RelationshipSchemaName("business_unit_externalparty")]
    public IEnumerable<ExternalParty> business_unit_externalparty
    {
      get
      {
        return this.GetRelatedEntities<ExternalParty>(nameof (business_unit_externalparty), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_externalparty));
        this.SetRelatedEntities<ExternalParty>(nameof (business_unit_externalparty), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_externalparty));
      }
    }

    [RelationshipSchemaName("business_unit_fax_activities")]
    public IEnumerable<Fax> business_unit_fax_activities
    {
      get => this.GetRelatedEntities<Fax>(nameof (business_unit_fax_activities), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (business_unit_fax_activities));
        this.SetRelatedEntities<Fax>(nameof (business_unit_fax_activities), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_fax_activities));
      }
    }

    [RelationshipSchemaName("business_unit_feedback")]
    public IEnumerable<Feedback> business_unit_feedback
    {
      get => this.GetRelatedEntities<Feedback>(nameof (business_unit_feedback), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (business_unit_feedback));
        this.SetRelatedEntities<Feedback>(nameof (business_unit_feedback), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_feedback));
      }
    }

    [RelationshipSchemaName("business_unit_flowsession")]
    public IEnumerable<flowsession> business_unit_flowsession
    {
      get
      {
        return this.GetRelatedEntities<flowsession>(nameof (business_unit_flowsession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_flowsession));
        this.SetRelatedEntities<flowsession>(nameof (business_unit_flowsession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_flowsession));
      }
    }

    [RelationshipSchemaName("business_unit_goal")]
    public IEnumerable<Goal> business_unit_goal
    {
      get => this.GetRelatedEntities<Goal>(nameof (business_unit_goal), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (business_unit_goal));
        this.SetRelatedEntities<Goal>(nameof (business_unit_goal), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_goal));
      }
    }

    [RelationshipSchemaName("business_unit_goalrollupquery")]
    public IEnumerable<GoalRollupQuery> business_unit_goalrollupquery
    {
      get
      {
        return this.GetRelatedEntities<GoalRollupQuery>(nameof (business_unit_goalrollupquery), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_goalrollupquery));
        this.SetRelatedEntities<GoalRollupQuery>(nameof (business_unit_goalrollupquery), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_goalrollupquery));
      }
    }

    [RelationshipSchemaName("business_unit_interactionforemail")]
    public IEnumerable<InteractionForEmail> business_unit_interactionforemail
    {
      get
      {
        return this.GetRelatedEntities<InteractionForEmail>(nameof (business_unit_interactionforemail), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_interactionforemail));
        this.SetRelatedEntities<InteractionForEmail>(nameof (business_unit_interactionforemail), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_interactionforemail));
      }
    }

    [RelationshipSchemaName("business_unit_knowledgearticle")]
    public IEnumerable<KnowledgeArticle> business_unit_knowledgearticle
    {
      get
      {
        return this.GetRelatedEntities<KnowledgeArticle>(nameof (business_unit_knowledgearticle), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_knowledgearticle));
        this.SetRelatedEntities<KnowledgeArticle>(nameof (business_unit_knowledgearticle), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_knowledgearticle));
      }
    }

    [RelationshipSchemaName("business_unit_letter_activities")]
    public IEnumerable<Letter> business_unit_letter_activities
    {
      get
      {
        return this.GetRelatedEntities<Letter>(nameof (business_unit_letter_activities), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_letter_activities));
        this.SetRelatedEntities<Letter>(nameof (business_unit_letter_activities), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_letter_activities));
      }
    }

    [RelationshipSchemaName("business_unit_mailbox")]
    public IEnumerable<Mailbox> business_unit_mailbox
    {
      get => this.GetRelatedEntities<Mailbox>(nameof (business_unit_mailbox), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (business_unit_mailbox));
        this.SetRelatedEntities<Mailbox>(nameof (business_unit_mailbox), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_mailbox));
      }
    }

    [RelationshipSchemaName("business_unit_mailmergetemplates")]
    public IEnumerable<MailMergeTemplate> business_unit_mailmergetemplates
    {
      get
      {
        return this.GetRelatedEntities<MailMergeTemplate>(nameof (business_unit_mailmergetemplates), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_mailmergetemplates));
        this.SetRelatedEntities<MailMergeTemplate>(nameof (business_unit_mailmergetemplates), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_mailmergetemplates));
      }
    }

    [RelationshipSchemaName("business_unit_msdyn_aibdataset")]
    public IEnumerable<msdyn_AIBDataset> business_unit_msdyn_aibdataset
    {
      get
      {
        return this.GetRelatedEntities<msdyn_AIBDataset>(nameof (business_unit_msdyn_aibdataset), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_msdyn_aibdataset));
        this.SetRelatedEntities<msdyn_AIBDataset>(nameof (business_unit_msdyn_aibdataset), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_msdyn_aibdataset));
      }
    }

    [RelationshipSchemaName("business_unit_msdyn_aibdatasetfile")]
    public IEnumerable<msdyn_AIBDatasetFile> business_unit_msdyn_aibdatasetfile
    {
      get
      {
        return this.GetRelatedEntities<msdyn_AIBDatasetFile>(nameof (business_unit_msdyn_aibdatasetfile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_msdyn_aibdatasetfile));
        this.SetRelatedEntities<msdyn_AIBDatasetFile>(nameof (business_unit_msdyn_aibdatasetfile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_msdyn_aibdatasetfile));
      }
    }

    [RelationshipSchemaName("business_unit_msdyn_aibdatasetrecord")]
    public IEnumerable<msdyn_AIBDatasetRecord> business_unit_msdyn_aibdatasetrecord
    {
      get
      {
        return this.GetRelatedEntities<msdyn_AIBDatasetRecord>(nameof (business_unit_msdyn_aibdatasetrecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_msdyn_aibdatasetrecord));
        this.SetRelatedEntities<msdyn_AIBDatasetRecord>(nameof (business_unit_msdyn_aibdatasetrecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_msdyn_aibdatasetrecord));
      }
    }

    [RelationshipSchemaName("business_unit_msdyn_aibdatasetscontainer")]
    public IEnumerable<msdyn_AIBDatasetsContainer> business_unit_msdyn_aibdatasetscontainer
    {
      get
      {
        return this.GetRelatedEntities<msdyn_AIBDatasetsContainer>(nameof (business_unit_msdyn_aibdatasetscontainer), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_msdyn_aibdatasetscontainer));
        this.SetRelatedEntities<msdyn_AIBDatasetsContainer>(nameof (business_unit_msdyn_aibdatasetscontainer), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_msdyn_aibdatasetscontainer));
      }
    }

    [RelationshipSchemaName("business_unit_msdyn_aibfile")]
    public IEnumerable<msdyn_AIBFile> business_unit_msdyn_aibfile
    {
      get
      {
        return this.GetRelatedEntities<msdyn_AIBFile>(nameof (business_unit_msdyn_aibfile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_msdyn_aibfile));
        this.SetRelatedEntities<msdyn_AIBFile>(nameof (business_unit_msdyn_aibfile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_msdyn_aibfile));
      }
    }

    [RelationshipSchemaName("business_unit_msdyn_aibfileattacheddata")]
    public IEnumerable<msdyn_AIBFileAttachedData> business_unit_msdyn_aibfileattacheddata
    {
      get
      {
        return this.GetRelatedEntities<msdyn_AIBFileAttachedData>(nameof (business_unit_msdyn_aibfileattacheddata), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_msdyn_aibfileattacheddata));
        this.SetRelatedEntities<msdyn_AIBFileAttachedData>(nameof (business_unit_msdyn_aibfileattacheddata), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_msdyn_aibfileattacheddata));
      }
    }

    [RelationshipSchemaName("business_unit_msdyn_aiconfiguration")]
    public IEnumerable<msdyn_AIConfiguration> business_unit_msdyn_aiconfiguration
    {
      get
      {
        return this.GetRelatedEntities<msdyn_AIConfiguration>(nameof (business_unit_msdyn_aiconfiguration), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_msdyn_aiconfiguration));
        this.SetRelatedEntities<msdyn_AIConfiguration>(nameof (business_unit_msdyn_aiconfiguration), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_msdyn_aiconfiguration));
      }
    }

    [RelationshipSchemaName("business_unit_msdyn_aifptrainingdocument")]
    public IEnumerable<msdyn_AIFpTrainingDocument> business_unit_msdyn_aifptrainingdocument
    {
      get
      {
        return this.GetRelatedEntities<msdyn_AIFpTrainingDocument>(nameof (business_unit_msdyn_aifptrainingdocument), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_msdyn_aifptrainingdocument));
        this.SetRelatedEntities<msdyn_AIFpTrainingDocument>(nameof (business_unit_msdyn_aifptrainingdocument), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_msdyn_aifptrainingdocument));
      }
    }

    [RelationshipSchemaName("business_unit_msdyn_aimodel")]
    public IEnumerable<msdyn_AIModel> business_unit_msdyn_aimodel
    {
      get
      {
        return this.GetRelatedEntities<msdyn_AIModel>(nameof (business_unit_msdyn_aimodel), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_msdyn_aimodel));
        this.SetRelatedEntities<msdyn_AIModel>(nameof (business_unit_msdyn_aimodel), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_msdyn_aimodel));
      }
    }

    [RelationshipSchemaName("business_unit_msdyn_aiodimage")]
    public IEnumerable<msdyn_AIOdImage> business_unit_msdyn_aiodimage
    {
      get
      {
        return this.GetRelatedEntities<msdyn_AIOdImage>(nameof (business_unit_msdyn_aiodimage), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_msdyn_aiodimage));
        this.SetRelatedEntities<msdyn_AIOdImage>(nameof (business_unit_msdyn_aiodimage), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_msdyn_aiodimage));
      }
    }

    [RelationshipSchemaName("business_unit_msdyn_aiodlabel")]
    public IEnumerable<msdyn_AIOdLabel> business_unit_msdyn_aiodlabel
    {
      get
      {
        return this.GetRelatedEntities<msdyn_AIOdLabel>(nameof (business_unit_msdyn_aiodlabel), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_msdyn_aiodlabel));
        this.SetRelatedEntities<msdyn_AIOdLabel>(nameof (business_unit_msdyn_aiodlabel), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_msdyn_aiodlabel));
      }
    }

    [RelationshipSchemaName("business_unit_msdyn_aiodtrainingboundingbox")]
    public IEnumerable<msdyn_AIOdTrainingBoundingBox> business_unit_msdyn_aiodtrainingboundingbox
    {
      get
      {
        return this.GetRelatedEntities<msdyn_AIOdTrainingBoundingBox>(nameof (business_unit_msdyn_aiodtrainingboundingbox), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_msdyn_aiodtrainingboundingbox));
        this.SetRelatedEntities<msdyn_AIOdTrainingBoundingBox>(nameof (business_unit_msdyn_aiodtrainingboundingbox), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_msdyn_aiodtrainingboundingbox));
      }
    }

    [RelationshipSchemaName("business_unit_msdyn_aiodtrainingimage")]
    public IEnumerable<msdyn_AIOdTrainingImage> business_unit_msdyn_aiodtrainingimage
    {
      get
      {
        return this.GetRelatedEntities<msdyn_AIOdTrainingImage>(nameof (business_unit_msdyn_aiodtrainingimage), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_msdyn_aiodtrainingimage));
        this.SetRelatedEntities<msdyn_AIOdTrainingImage>(nameof (business_unit_msdyn_aiodtrainingimage), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_msdyn_aiodtrainingimage));
      }
    }

    [RelationshipSchemaName("business_unit_msdyn_aitemplate")]
    public IEnumerable<msdyn_AITemplate> business_unit_msdyn_aitemplate
    {
      get
      {
        return this.GetRelatedEntities<msdyn_AITemplate>(nameof (business_unit_msdyn_aitemplate), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_msdyn_aitemplate));
        this.SetRelatedEntities<msdyn_AITemplate>(nameof (business_unit_msdyn_aitemplate), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_msdyn_aitemplate));
      }
    }

    [RelationshipSchemaName("business_unit_msdyn_analysiscomponent")]
    public IEnumerable<msdyn_analysiscomponent> business_unit_msdyn_analysiscomponent
    {
      get
      {
        return this.GetRelatedEntities<msdyn_analysiscomponent>(nameof (business_unit_msdyn_analysiscomponent), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_msdyn_analysiscomponent));
        this.SetRelatedEntities<msdyn_analysiscomponent>(nameof (business_unit_msdyn_analysiscomponent), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_msdyn_analysiscomponent));
      }
    }

    [RelationshipSchemaName("business_unit_msdyn_analysisjob")]
    public IEnumerable<msdyn_analysisjob> business_unit_msdyn_analysisjob
    {
      get
      {
        return this.GetRelatedEntities<msdyn_analysisjob>(nameof (business_unit_msdyn_analysisjob), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_msdyn_analysisjob));
        this.SetRelatedEntities<msdyn_analysisjob>(nameof (business_unit_msdyn_analysisjob), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_msdyn_analysisjob));
      }
    }

    [RelationshipSchemaName("business_unit_msdyn_analysisresult")]
    public IEnumerable<msdyn_analysisresult> business_unit_msdyn_analysisresult
    {
      get
      {
        return this.GetRelatedEntities<msdyn_analysisresult>(nameof (business_unit_msdyn_analysisresult), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_msdyn_analysisresult));
        this.SetRelatedEntities<msdyn_analysisresult>(nameof (business_unit_msdyn_analysisresult), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_msdyn_analysisresult));
      }
    }

    [RelationshipSchemaName("business_unit_msdyn_analysisresultdetail")]
    public IEnumerable<msdyn_analysisresultdetail> business_unit_msdyn_analysisresultdetail
    {
      get
      {
        return this.GetRelatedEntities<msdyn_analysisresultdetail>(nameof (business_unit_msdyn_analysisresultdetail), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_msdyn_analysisresultdetail));
        this.SetRelatedEntities<msdyn_analysisresultdetail>(nameof (business_unit_msdyn_analysisresultdetail), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_msdyn_analysisresultdetail));
      }
    }

    [RelationshipSchemaName("business_unit_msdyn_dataflow")]
    public IEnumerable<msdyn_dataflow> business_unit_msdyn_dataflow
    {
      get
      {
        return this.GetRelatedEntities<msdyn_dataflow>(nameof (business_unit_msdyn_dataflow), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_msdyn_dataflow));
        this.SetRelatedEntities<msdyn_dataflow>(nameof (business_unit_msdyn_dataflow), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_msdyn_dataflow));
      }
    }

    [RelationshipSchemaName("business_unit_msdyn_federatedarticle")]
    public IEnumerable<msdyn_federatedarticle> business_unit_msdyn_federatedarticle
    {
      get
      {
        return this.GetRelatedEntities<msdyn_federatedarticle>(nameof (business_unit_msdyn_federatedarticle), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_msdyn_federatedarticle));
        this.SetRelatedEntities<msdyn_federatedarticle>(nameof (business_unit_msdyn_federatedarticle), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_msdyn_federatedarticle));
      }
    }

    [RelationshipSchemaName("business_unit_msdyn_kmfederatedsearchconfig")]
    public IEnumerable<msdyn_kmfederatedsearchconfig> business_unit_msdyn_kmfederatedsearchconfig
    {
      get
      {
        return this.GetRelatedEntities<msdyn_kmfederatedsearchconfig>(nameof (business_unit_msdyn_kmfederatedsearchconfig), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_msdyn_kmfederatedsearchconfig));
        this.SetRelatedEntities<msdyn_kmfederatedsearchconfig>(nameof (business_unit_msdyn_kmfederatedsearchconfig), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_msdyn_kmfederatedsearchconfig));
      }
    }

    [RelationshipSchemaName("business_unit_msdyn_knowledgearticleimage")]
    public IEnumerable<msdyn_knowledgearticleimage> business_unit_msdyn_knowledgearticleimage
    {
      get
      {
        return this.GetRelatedEntities<msdyn_knowledgearticleimage>(nameof (business_unit_msdyn_knowledgearticleimage), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_msdyn_knowledgearticleimage));
        this.SetRelatedEntities<msdyn_knowledgearticleimage>(nameof (business_unit_msdyn_knowledgearticleimage), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_msdyn_knowledgearticleimage));
      }
    }

    [RelationshipSchemaName("business_unit_msdyn_knowledgearticletemplate")]
    public IEnumerable<msdyn_knowledgearticletemplate> business_unit_msdyn_knowledgearticletemplate
    {
      get
      {
        return this.GetRelatedEntities<msdyn_knowledgearticletemplate>(nameof (business_unit_msdyn_knowledgearticletemplate), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_msdyn_knowledgearticletemplate));
        this.SetRelatedEntities<msdyn_knowledgearticletemplate>(nameof (business_unit_msdyn_knowledgearticletemplate), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_msdyn_knowledgearticletemplate));
      }
    }

    [RelationshipSchemaName("business_unit_msdyn_knowledgeinteractioninsight")]
    public IEnumerable<msdyn_knowledgeinteractioninsight> business_unit_msdyn_knowledgeinteractioninsight
    {
      get
      {
        return this.GetRelatedEntities<msdyn_knowledgeinteractioninsight>(nameof (business_unit_msdyn_knowledgeinteractioninsight), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_msdyn_knowledgeinteractioninsight));
        this.SetRelatedEntities<msdyn_knowledgeinteractioninsight>(nameof (business_unit_msdyn_knowledgeinteractioninsight), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_msdyn_knowledgeinteractioninsight));
      }
    }

    [RelationshipSchemaName("business_unit_msdyn_knowledgesearchinsight")]
    public IEnumerable<msdyn_knowledgesearchinsight> business_unit_msdyn_knowledgesearchinsight
    {
      get
      {
        return this.GetRelatedEntities<msdyn_knowledgesearchinsight>(nameof (business_unit_msdyn_knowledgesearchinsight), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_msdyn_knowledgesearchinsight));
        this.SetRelatedEntities<msdyn_knowledgesearchinsight>(nameof (business_unit_msdyn_knowledgesearchinsight), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_msdyn_knowledgesearchinsight));
      }
    }

    [RelationshipSchemaName("business_unit_msdyn_richtextfile")]
    public IEnumerable<msdyn_richtextfile> business_unit_msdyn_richtextfile
    {
      get
      {
        return this.GetRelatedEntities<msdyn_richtextfile>(nameof (business_unit_msdyn_richtextfile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_msdyn_richtextfile));
        this.SetRelatedEntities<msdyn_richtextfile>(nameof (business_unit_msdyn_richtextfile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_msdyn_richtextfile));
      }
    }

    [RelationshipSchemaName("business_unit_msdyn_serviceconfiguration")]
    public IEnumerable<msdyn_serviceconfiguration> business_unit_msdyn_serviceconfiguration
    {
      get
      {
        return this.GetRelatedEntities<msdyn_serviceconfiguration>(nameof (business_unit_msdyn_serviceconfiguration), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_msdyn_serviceconfiguration));
        this.SetRelatedEntities<msdyn_serviceconfiguration>(nameof (business_unit_msdyn_serviceconfiguration), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_msdyn_serviceconfiguration));
      }
    }

    [RelationshipSchemaName("business_unit_msdyn_slakpi")]
    public IEnumerable<msdyn_slakpi> business_unit_msdyn_slakpi
    {
      get
      {
        return this.GetRelatedEntities<msdyn_slakpi>(nameof (business_unit_msdyn_slakpi), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_msdyn_slakpi));
        this.SetRelatedEntities<msdyn_slakpi>(nameof (business_unit_msdyn_slakpi), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_msdyn_slakpi));
      }
    }

    [RelationshipSchemaName("business_unit_msdyn_solutionhealthrule")]
    public IEnumerable<msdyn_solutionhealthrule> business_unit_msdyn_solutionhealthrule
    {
      get
      {
        return this.GetRelatedEntities<msdyn_solutionhealthrule>(nameof (business_unit_msdyn_solutionhealthrule), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_msdyn_solutionhealthrule));
        this.SetRelatedEntities<msdyn_solutionhealthrule>(nameof (business_unit_msdyn_solutionhealthrule), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_msdyn_solutionhealthrule));
      }
    }

    [RelationshipSchemaName("business_unit_msdyn_solutionhealthruleargument")]
    public IEnumerable<msdyn_solutionhealthruleargument> business_unit_msdyn_solutionhealthruleargument
    {
      get
      {
        return this.GetRelatedEntities<msdyn_solutionhealthruleargument>(nameof (business_unit_msdyn_solutionhealthruleargument), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_msdyn_solutionhealthruleargument));
        this.SetRelatedEntities<msdyn_solutionhealthruleargument>(nameof (business_unit_msdyn_solutionhealthruleargument), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_msdyn_solutionhealthruleargument));
      }
    }

    [RelationshipSchemaName("business_unit_msdynce_botcontent")]
    public IEnumerable<msdynce_botcontent> business_unit_msdynce_botcontent
    {
      get
      {
        return this.GetRelatedEntities<msdynce_botcontent>(nameof (business_unit_msdynce_botcontent), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_msdynce_botcontent));
        this.SetRelatedEntities<msdynce_botcontent>(nameof (business_unit_msdynce_botcontent), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_msdynce_botcontent));
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

    [RelationshipSchemaName("business_unit_pdfsetting")]
    public IEnumerable<PDFSetting> business_unit_pdfsetting
    {
      get
      {
        return this.GetRelatedEntities<PDFSetting>(nameof (business_unit_pdfsetting), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_pdfsetting));
        this.SetRelatedEntities<PDFSetting>(nameof (business_unit_pdfsetting), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_pdfsetting));
      }
    }

    [RelationshipSchemaName("business_unit_personaldocumenttemplates")]
    public IEnumerable<PersonalDocumentTemplate> business_unit_personaldocumenttemplates
    {
      get
      {
        return this.GetRelatedEntities<PersonalDocumentTemplate>(nameof (business_unit_personaldocumenttemplates), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_personaldocumenttemplates));
        this.SetRelatedEntities<PersonalDocumentTemplate>(nameof (business_unit_personaldocumenttemplates), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_personaldocumenttemplates));
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

    [RelationshipSchemaName("business_unit_postfollows")]
    public IEnumerable<PostFollow> business_unit_postfollows
    {
      get
      {
        return this.GetRelatedEntities<PostFollow>(nameof (business_unit_postfollows), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_postfollows));
        this.SetRelatedEntities<PostFollow>(nameof (business_unit_postfollows), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_postfollows));
      }
    }

    [RelationshipSchemaName("business_unit_processstageparameter")]
    public IEnumerable<processstageparameter> business_unit_processstageparameter
    {
      get
      {
        return this.GetRelatedEntities<processstageparameter>(nameof (business_unit_processstageparameter), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_processstageparameter));
        this.SetRelatedEntities<processstageparameter>(nameof (business_unit_processstageparameter), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_processstageparameter));
      }
    }

    [RelationshipSchemaName("business_unit_profilerule")]
    public IEnumerable<ChannelAccessProfileRule> business_unit_profilerule
    {
      get
      {
        return this.GetRelatedEntities<ChannelAccessProfileRule>(nameof (business_unit_profilerule), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_profilerule));
        this.SetRelatedEntities<ChannelAccessProfileRule>(nameof (business_unit_profilerule), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_profilerule));
      }
    }

    [RelationshipSchemaName("business_unit_queues")]
    public IEnumerable<Queue> business_unit_queues
    {
      get => this.GetRelatedEntities<Queue>(nameof (business_unit_queues), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (business_unit_queues));
        this.SetRelatedEntities<Queue>(nameof (business_unit_queues), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_queues));
      }
    }

    [RelationshipSchemaName("business_unit_queues2")]
    public IEnumerable<Queue> business_unit_queues2
    {
      get => this.GetRelatedEntities<Queue>(nameof (business_unit_queues2), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (business_unit_queues2));
        this.SetRelatedEntities<Queue>(nameof (business_unit_queues2), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_queues2));
      }
    }

    [RelationshipSchemaName("business_unit_recurrencerule")]
    public IEnumerable<RecurrenceRule> business_unit_recurrencerule
    {
      get
      {
        return this.GetRelatedEntities<RecurrenceRule>(nameof (business_unit_recurrencerule), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_recurrencerule));
        this.SetRelatedEntities<RecurrenceRule>(nameof (business_unit_recurrencerule), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_recurrencerule));
      }
    }

    [RelationshipSchemaName("business_unit_recurringappointmentmaster_activities")]
    public IEnumerable<RecurringAppointmentMaster> business_unit_recurringappointmentmaster_activities
    {
      get
      {
        return this.GetRelatedEntities<RecurringAppointmentMaster>(nameof (business_unit_recurringappointmentmaster_activities), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_recurringappointmentmaster_activities));
        this.SetRelatedEntities<RecurringAppointmentMaster>(nameof (business_unit_recurringappointmentmaster_activities), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_recurringappointmentmaster_activities));
      }
    }

    [RelationshipSchemaName("business_unit_reports")]
    public IEnumerable<Report> business_unit_reports
    {
      get => this.GetRelatedEntities<Report>(nameof (business_unit_reports), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (business_unit_reports));
        this.SetRelatedEntities<Report>(nameof (business_unit_reports), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_reports));
      }
    }

    [RelationshipSchemaName("business_unit_revokeinheritedaccessrecordstracker")]
    public IEnumerable<revokeinheritedaccessrecordstracker> business_unit_revokeinheritedaccessrecordstracker
    {
      get
      {
        return this.GetRelatedEntities<revokeinheritedaccessrecordstracker>(nameof (business_unit_revokeinheritedaccessrecordstracker), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_revokeinheritedaccessrecordstracker));
        this.SetRelatedEntities<revokeinheritedaccessrecordstracker>(nameof (business_unit_revokeinheritedaccessrecordstracker), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_revokeinheritedaccessrecordstracker));
      }
    }

    [RelationshipSchemaName("business_unit_roles")]
    public IEnumerable<Role> business_unit_roles
    {
      get => this.GetRelatedEntities<Role>(nameof (business_unit_roles), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (business_unit_roles));
        this.SetRelatedEntities<Role>(nameof (business_unit_roles), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_roles));
      }
    }

    [RelationshipSchemaName("business_unit_routingrule")]
    public IEnumerable<RoutingRule> business_unit_routingrule
    {
      get
      {
        return this.GetRelatedEntities<RoutingRule>(nameof (business_unit_routingrule), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_routingrule));
        this.SetRelatedEntities<RoutingRule>(nameof (business_unit_routingrule), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_routingrule));
      }
    }

    [RelationshipSchemaName("business_unit_sharepointdocument")]
    public IEnumerable<SharePointDocument> business_unit_sharepointdocument
    {
      get
      {
        return this.GetRelatedEntities<SharePointDocument>(nameof (business_unit_sharepointdocument), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_sharepointdocument));
        this.SetRelatedEntities<SharePointDocument>(nameof (business_unit_sharepointdocument), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_sharepointdocument));
      }
    }

    [RelationshipSchemaName("business_unit_sharepointdocument2")]
    public IEnumerable<SharePointDocument> business_unit_sharepointdocument2
    {
      get
      {
        return this.GetRelatedEntities<SharePointDocument>(nameof (business_unit_sharepointdocument2), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_sharepointdocument2));
        this.SetRelatedEntities<SharePointDocument>(nameof (business_unit_sharepointdocument2), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_sharepointdocument2));
      }
    }

    [RelationshipSchemaName("business_unit_sharepointdocumentlocation")]
    public IEnumerable<SharePointDocumentLocation> business_unit_sharepointdocumentlocation
    {
      get
      {
        return this.GetRelatedEntities<SharePointDocumentLocation>(nameof (business_unit_sharepointdocumentlocation), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_sharepointdocumentlocation));
        this.SetRelatedEntities<SharePointDocumentLocation>(nameof (business_unit_sharepointdocumentlocation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_sharepointdocumentlocation));
      }
    }

    [RelationshipSchemaName("business_unit_sharepointsites")]
    public IEnumerable<SharePointSite> business_unit_sharepointsites
    {
      get
      {
        return this.GetRelatedEntities<SharePointSite>(nameof (business_unit_sharepointsites), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_sharepointsites));
        this.SetRelatedEntities<SharePointSite>(nameof (business_unit_sharepointsites), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_sharepointsites));
      }
    }

    [RelationshipSchemaName("business_unit_slabase")]
    public IEnumerable<SLA> business_unit_slabase
    {
      get => this.GetRelatedEntities<SLA>(nameof (business_unit_slabase), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (business_unit_slabase));
        this.SetRelatedEntities<SLA>(nameof (business_unit_slabase), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_slabase));
      }
    }

    [RelationshipSchemaName("business_unit_slakpiinstance")]
    public IEnumerable<SLAKPIInstance> business_unit_slakpiinstance
    {
      get
      {
        return this.GetRelatedEntities<SLAKPIInstance>(nameof (business_unit_slakpiinstance), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_slakpiinstance));
        this.SetRelatedEntities<SLAKPIInstance>(nameof (business_unit_slakpiinstance), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_slakpiinstance));
      }
    }

    [RelationshipSchemaName("business_unit_socialactivity")]
    public IEnumerable<SocialActivity> business_unit_socialactivity
    {
      get
      {
        return this.GetRelatedEntities<SocialActivity>(nameof (business_unit_socialactivity), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_socialactivity));
        this.SetRelatedEntities<SocialActivity>(nameof (business_unit_socialactivity), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_socialactivity));
      }
    }

    [RelationshipSchemaName("business_unit_socialprofiles")]
    public IEnumerable<SocialProfile> business_unit_socialprofiles
    {
      get
      {
        return this.GetRelatedEntities<SocialProfile>(nameof (business_unit_socialprofiles), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_socialprofiles));
        this.SetRelatedEntities<SocialProfile>(nameof (business_unit_socialprofiles), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_socialprofiles));
      }
    }

    [RelationshipSchemaName("business_unit_stagesolutionupload")]
    public IEnumerable<StageSolutionUpload> business_unit_stagesolutionupload
    {
      get
      {
        return this.GetRelatedEntities<StageSolutionUpload>(nameof (business_unit_stagesolutionupload), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_stagesolutionupload));
        this.SetRelatedEntities<StageSolutionUpload>(nameof (business_unit_stagesolutionupload), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_stagesolutionupload));
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

    [RelationshipSchemaName("business_unit_templates")]
    public IEnumerable<Template> business_unit_templates
    {
      get => this.GetRelatedEntities<Template>(nameof (business_unit_templates), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (business_unit_templates));
        this.SetRelatedEntities<Template>(nameof (business_unit_templates), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_templates));
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

    [RelationshipSchemaName("business_unit_userform")]
    public IEnumerable<UserForm> business_unit_userform
    {
      get => this.GetRelatedEntities<UserForm>(nameof (business_unit_userform), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (business_unit_userform));
        this.SetRelatedEntities<UserForm>(nameof (business_unit_userform), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_userform));
      }
    }

    [RelationshipSchemaName("business_unit_userquery")]
    public IEnumerable<UserQuery> business_unit_userquery
    {
      get
      {
        return this.GetRelatedEntities<UserQuery>(nameof (business_unit_userquery), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_userquery));
        this.SetRelatedEntities<UserQuery>(nameof (business_unit_userquery), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_userquery));
      }
    }

    [RelationshipSchemaName("business_unit_userqueryvisualizations")]
    public IEnumerable<UserQueryVisualization> business_unit_userqueryvisualizations
    {
      get
      {
        return this.GetRelatedEntities<UserQueryVisualization>(nameof (business_unit_userqueryvisualizations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_userqueryvisualizations));
        this.SetRelatedEntities<UserQueryVisualization>(nameof (business_unit_userqueryvisualizations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_userqueryvisualizations));
      }
    }

    [RelationshipSchemaName("business_unit_workflow")]
    public IEnumerable<Workflow> business_unit_workflow
    {
      get => this.GetRelatedEntities<Workflow>(nameof (business_unit_workflow), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (business_unit_workflow));
        this.SetRelatedEntities<Workflow>(nameof (business_unit_workflow), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_workflow));
      }
    }

    [RelationshipSchemaName("business_unit_workflowbinary")]
    public IEnumerable<workflowbinary> business_unit_workflowbinary
    {
      get
      {
        return this.GetRelatedEntities<workflowbinary>(nameof (business_unit_workflowbinary), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_workflowbinary));
        this.SetRelatedEntities<workflowbinary>(nameof (business_unit_workflowbinary), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_workflowbinary));
      }
    }

    [RelationshipSchemaName("business_unit_workflowlogs")]
    public IEnumerable<WorkflowLog> business_unit_workflowlogs
    {
      get
      {
        return this.GetRelatedEntities<WorkflowLog>(nameof (business_unit_workflowlogs), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_workflowlogs));
        this.SetRelatedEntities<WorkflowLog>(nameof (business_unit_workflowlogs), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_workflowlogs));
      }
    }

    [RelationshipSchemaName("BusinessUnit_AsyncOperations")]
    public IEnumerable<AsyncOperation> BusinessUnit_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (BusinessUnit_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (BusinessUnit_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (BusinessUnit_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (BusinessUnit_AsyncOperations));
      }
    }

    [RelationshipSchemaName("BusinessUnit_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> BusinessUnit_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (BusinessUnit_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (BusinessUnit_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (BusinessUnit_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (BusinessUnit_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("businessunit_callbackregistration")]
    public IEnumerable<CallbackRegistration> businessunit_callbackregistration
    {
      get
      {
        return this.GetRelatedEntities<CallbackRegistration>(nameof (businessunit_callbackregistration), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (businessunit_callbackregistration));
        this.SetRelatedEntities<CallbackRegistration>(nameof (businessunit_callbackregistration), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (businessunit_callbackregistration));
      }
    }

    [RelationshipSchemaName("businessunit_canvasapp")]
    public IEnumerable<CanvasApp> businessunit_canvasapp
    {
      get => this.GetRelatedEntities<CanvasApp>(nameof (businessunit_canvasapp), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (businessunit_canvasapp));
        this.SetRelatedEntities<CanvasApp>(nameof (businessunit_canvasapp), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (businessunit_canvasapp));
      }
    }

    [RelationshipSchemaName("businessunit_canvasappextendedmetadata")]
    public IEnumerable<CanvasAppExtendedMetadata> businessunit_canvasappextendedmetadata
    {
      get
      {
        return this.GetRelatedEntities<CanvasAppExtendedMetadata>(nameof (businessunit_canvasappextendedmetadata), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (businessunit_canvasappextendedmetadata));
        this.SetRelatedEntities<CanvasAppExtendedMetadata>(nameof (businessunit_canvasappextendedmetadata), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (businessunit_canvasappextendedmetadata));
      }
    }

    [RelationshipSchemaName("BusinessUnit_DuplicateRules")]
    public IEnumerable<DuplicateRule> BusinessUnit_DuplicateRules
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRule>(nameof (BusinessUnit_DuplicateRules), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (BusinessUnit_DuplicateRules));
        this.SetRelatedEntities<DuplicateRule>(nameof (BusinessUnit_DuplicateRules), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (BusinessUnit_DuplicateRules));
      }
    }

    [RelationshipSchemaName("BusinessUnit_ImportFiles")]
    public IEnumerable<ImportFile> BusinessUnit_ImportFiles
    {
      get
      {
        return this.GetRelatedEntities<ImportFile>(nameof (BusinessUnit_ImportFiles), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (BusinessUnit_ImportFiles));
        this.SetRelatedEntities<ImportFile>(nameof (BusinessUnit_ImportFiles), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (BusinessUnit_ImportFiles));
      }
    }

    [RelationshipSchemaName("BusinessUnit_ImportLogs")]
    public IEnumerable<ImportLog> BusinessUnit_ImportLogs
    {
      get
      {
        return this.GetRelatedEntities<ImportLog>(nameof (BusinessUnit_ImportLogs), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (BusinessUnit_ImportLogs));
        this.SetRelatedEntities<ImportLog>(nameof (BusinessUnit_ImportLogs), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (BusinessUnit_ImportLogs));
      }
    }

    [RelationshipSchemaName("BusinessUnit_ImportMaps")]
    public IEnumerable<ImportMap> BusinessUnit_ImportMaps
    {
      get
      {
        return this.GetRelatedEntities<ImportMap>(nameof (BusinessUnit_ImportMaps), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (BusinessUnit_ImportMaps));
        this.SetRelatedEntities<ImportMap>(nameof (BusinessUnit_ImportMaps), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (BusinessUnit_ImportMaps));
      }
    }

    [RelationshipSchemaName("BusinessUnit_Imports")]
    public IEnumerable<Import> BusinessUnit_Imports
    {
      get => this.GetRelatedEntities<Import>(nameof (BusinessUnit_Imports), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (BusinessUnit_Imports));
        this.SetRelatedEntities<Import>(nameof (BusinessUnit_Imports), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (BusinessUnit_Imports));
      }
    }

    [RelationshipSchemaName("businessunit_mailboxtrackingcategory")]
    public IEnumerable<MailboxTrackingCategory> businessunit_mailboxtrackingcategory
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingCategory>(nameof (businessunit_mailboxtrackingcategory), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (businessunit_mailboxtrackingcategory));
        this.SetRelatedEntities<MailboxTrackingCategory>(nameof (businessunit_mailboxtrackingcategory), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (businessunit_mailboxtrackingcategory));
      }
    }

    [RelationshipSchemaName("businessunit_mailboxtrackingfolder")]
    public IEnumerable<MailboxTrackingFolder> businessunit_mailboxtrackingfolder
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (businessunit_mailboxtrackingfolder), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (businessunit_mailboxtrackingfolder));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (businessunit_mailboxtrackingfolder), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (businessunit_mailboxtrackingfolder));
      }
    }

    [RelationshipSchemaName("businessunit_principalobjectattributeaccess")]
    public IEnumerable<PrincipalObjectAttributeAccess> businessunit_principalobjectattributeaccess
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (businessunit_principalobjectattributeaccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (businessunit_principalobjectattributeaccess));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (businessunit_principalobjectattributeaccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (businessunit_principalobjectattributeaccess));
      }
    }

    [RelationshipSchemaName("BusinessUnit_ProcessSessions")]
    public IEnumerable<ProcessSession> BusinessUnit_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (BusinessUnit_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (BusinessUnit_ProcessSessions));
        this.SetRelatedEntities<ProcessSession>(nameof (BusinessUnit_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (BusinessUnit_ProcessSessions));
      }
    }

    [RelationshipSchemaName("BusinessUnit_SyncError")]
    public IEnumerable<SyncError> BusinessUnit_SyncError
    {
      get => this.GetRelatedEntities<SyncError>(nameof (BusinessUnit_SyncError), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (BusinessUnit_SyncError));
        this.SetRelatedEntities<SyncError>(nameof (BusinessUnit_SyncError), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (BusinessUnit_SyncError));
      }
    }

    [RelationshipSchemaName("BusinessUnit_SyncErrors")]
    public IEnumerable<SyncError> BusinessUnit_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (BusinessUnit_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (BusinessUnit_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (BusinessUnit_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (BusinessUnit_SyncErrors));
      }
    }

    [RelationshipSchemaName("mbs_businessunit_mbs_pluginprofile")]
    public IEnumerable<mbs_pluginprofile> mbs_businessunit_mbs_pluginprofile
    {
      get
      {
        return this.GetRelatedEntities<mbs_pluginprofile>(nameof (mbs_businessunit_mbs_pluginprofile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (mbs_businessunit_mbs_pluginprofile));
        this.SetRelatedEntities<mbs_pluginprofile>(nameof (mbs_businessunit_mbs_pluginprofile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (mbs_businessunit_mbs_pluginprofile));
      }
    }

    [RelationshipSchemaName("Owning_businessunit_processsessions")]
    public IEnumerable<ProcessSession> Owning_businessunit_processsessions
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (Owning_businessunit_processsessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Owning_businessunit_processsessions));
        this.SetRelatedEntities<ProcessSession>(nameof (Owning_businessunit_processsessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Owning_businessunit_processsessions));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_businessunit")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_businessunit
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_businessunit), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_businessunit));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_businessunit), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_businessunit));
      }
    }

    [RelationshipSchemaName("userentityuisettings_businessunit")]
    public IEnumerable<UserEntityUISettings> userentityuisettings_businessunit
    {
      get
      {
        return this.GetRelatedEntities<UserEntityUISettings>(nameof (userentityuisettings_businessunit), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityuisettings_businessunit));
        this.SetRelatedEntities<UserEntityUISettings>(nameof (userentityuisettings_businessunit), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityuisettings_businessunit));
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

    [AttributeLogicalName("calendarid")]
    [RelationshipSchemaName("BusinessUnit_Calendar")]
    public Calendar BusinessUnit_Calendar
    {
      get => this.GetRelatedEntity<Calendar>(nameof (BusinessUnit_Calendar), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (BusinessUnit_Calendar));
        this.SetRelatedEntity<Calendar>(nameof (BusinessUnit_Calendar), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (BusinessUnit_Calendar));
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
      set
      {
        this.OnPropertyChanging(nameof (lk_businessunit_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_businessunit_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_businessunit_createdonbehalfby));
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
      set
      {
        this.OnPropertyChanging(nameof (lk_businessunit_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_businessunit_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_businessunit_modifiedonbehalfby));
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

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_BusinessUnit")]
    public TransactionCurrency TransactionCurrency_BusinessUnit
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_BusinessUnit), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_BusinessUnit));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_BusinessUnit), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_BusinessUnit));
      }
    }

    public BusinessUnit(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["businessunitid"] = (object) base.Id;
            break;
          case "businessunitid":
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
