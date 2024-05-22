// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EarlyBound.SystemUser
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("systemuser")]
  [GeneratedCode("CrmSvcUtil", "9.0.0.9154")]
  public class SystemUser : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "systemuser";
    public const int EntityTypeCode = 8;

    public SystemUser()
      : base("systemuser")
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

    [AttributeLogicalName("accessmode")]
    public OptionSetValue AccessMode
    {
      get => this.GetAttributeValue<OptionSetValue>("accessmode");
      set
      {
        this.OnPropertyChanging(nameof (AccessMode));
        this.SetAttributeValue("accessmode", (object) value);
        this.OnPropertyChanged(nameof (AccessMode));
      }
    }

    [AttributeLogicalName("accessmodename")]
    public object AccessModeName => this.GetAttributeValue<object>("accessmodename");

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

    [AttributeLogicalName("applicationid")]
    public Guid? ApplicationId
    {
      get => this.GetAttributeValue<Guid?>("applicationid");
      set
      {
        this.OnPropertyChanging(nameof (ApplicationId));
        this.SetAttributeValue("applicationid", (object) value);
        this.OnPropertyChanged(nameof (ApplicationId));
      }
    }

    [AttributeLogicalName("applicationiduri")]
    public string ApplicationIdUri => this.GetAttributeValue<string>("applicationiduri");

    [AttributeLogicalName("azureactivedirectoryobjectid")]
    public Guid? AzureActiveDirectoryObjectId
    {
      get => this.GetAttributeValue<Guid?>("azureactivedirectoryobjectid");
    }

    [AttributeLogicalName("businessunitid")]
    public EntityReference BusinessUnitId
    {
      get => this.GetAttributeValue<EntityReference>("businessunitid");
      set
      {
        this.OnPropertyChanging(nameof (BusinessUnitId));
        this.SetAttributeValue("businessunitid", (object) value);
        this.OnPropertyChanged(nameof (BusinessUnitId));
      }
    }

    [AttributeLogicalName("businessunitidname")]
    public string BusinessUnitIdName => this.GetAttributeValue<string>("businessunitidname");

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

    [AttributeLogicalName("caltype")]
    public OptionSetValue CALType
    {
      get => this.GetAttributeValue<OptionSetValue>("caltype");
      set
      {
        this.OnPropertyChanging(nameof (CALType));
        this.SetAttributeValue("caltype", (object) value);
        this.OnPropertyChanged(nameof (CALType));
      }
    }

    [AttributeLogicalName("caltypename")]
    public object CALTypeName => this.GetAttributeValue<object>("caltypename");

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

    [AttributeLogicalName("defaultfilterspopulated")]
    public bool? DefaultFiltersPopulated
    {
      get => this.GetAttributeValue<bool?>("defaultfilterspopulated");
    }

    [AttributeLogicalName("defaultmailbox")]
    public EntityReference DefaultMailbox
    {
      get => this.GetAttributeValue<EntityReference>("defaultmailbox");
    }

    [AttributeLogicalName("defaultmailboxname")]
    public string DefaultMailboxName => this.GetAttributeValue<string>("defaultmailboxname");

    [AttributeLogicalName("defaultodbfoldername")]
    public string DefaultOdbFolderName => this.GetAttributeValue<string>("defaultodbfoldername");

    [AttributeLogicalName("disabledreason")]
    public string DisabledReason => this.GetAttributeValue<string>("disabledreason");

    [AttributeLogicalName("displayinserviceviews")]
    public bool? DisplayInServiceViews
    {
      get => this.GetAttributeValue<bool?>("displayinserviceviews");
      set
      {
        this.OnPropertyChanging(nameof (DisplayInServiceViews));
        this.SetAttributeValue("displayinserviceviews", (object) value);
        this.OnPropertyChanged(nameof (DisplayInServiceViews));
      }
    }

    [AttributeLogicalName("displayinserviceviewsname")]
    public object DisplayInServiceViewsName
    {
      get => this.GetAttributeValue<object>("displayinserviceviewsname");
    }

    [AttributeLogicalName("domainname")]
    public string DomainName
    {
      get => this.GetAttributeValue<string>("domainname");
      set
      {
        this.OnPropertyChanging(nameof (DomainName));
        this.SetAttributeValue("domainname", (object) value);
        this.OnPropertyChanged(nameof (DomainName));
      }
    }

    [AttributeLogicalName("emailrouteraccessapproval")]
    public OptionSetValue EmailRouterAccessApproval
    {
      get => this.GetAttributeValue<OptionSetValue>("emailrouteraccessapproval");
      set
      {
        this.OnPropertyChanging(nameof (EmailRouterAccessApproval));
        this.SetAttributeValue("emailrouteraccessapproval", (object) value);
        this.OnPropertyChanged(nameof (EmailRouterAccessApproval));
      }
    }

    [AttributeLogicalName("emailrouteraccessapprovalname")]
    public object EmailRouterAccessApprovalName
    {
      get => this.GetAttributeValue<object>("emailrouteraccessapprovalname");
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

    [AttributeLogicalName("fullname")]
    public string FullName => this.GetAttributeValue<string>("fullname");

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

    [AttributeLogicalName("homephone")]
    public string HomePhone
    {
      get => this.GetAttributeValue<string>("homephone");
      set
      {
        this.OnPropertyChanging(nameof (HomePhone));
        this.SetAttributeValue("homephone", (object) value);
        this.OnPropertyChanged(nameof (HomePhone));
      }
    }

    [AttributeLogicalName("identityid")]
    public int? IdentityId => this.GetAttributeValue<int?>("identityid");

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

    [AttributeLogicalName("incomingemaildeliverymethod")]
    public OptionSetValue IncomingEmailDeliveryMethod
    {
      get => this.GetAttributeValue<OptionSetValue>("incomingemaildeliverymethod");
      set
      {
        this.OnPropertyChanging(nameof (IncomingEmailDeliveryMethod));
        this.SetAttributeValue("incomingemaildeliverymethod", (object) value);
        this.OnPropertyChanged(nameof (IncomingEmailDeliveryMethod));
      }
    }

    [AttributeLogicalName("incomingemaildeliverymethodname")]
    public object IncomingEmailDeliveryMethodName
    {
      get => this.GetAttributeValue<object>("incomingemaildeliverymethodname");
    }

    [AttributeLogicalName("internalemailaddress")]
    public string InternalEMailAddress
    {
      get => this.GetAttributeValue<string>("internalemailaddress");
      set
      {
        this.OnPropertyChanging(nameof (InternalEMailAddress));
        this.SetAttributeValue("internalemailaddress", (object) value);
        this.OnPropertyChanged(nameof (InternalEMailAddress));
      }
    }

    [AttributeLogicalName("invitestatuscode")]
    public OptionSetValue InviteStatusCode
    {
      get => this.GetAttributeValue<OptionSetValue>("invitestatuscode");
      set
      {
        this.OnPropertyChanging(nameof (InviteStatusCode));
        this.SetAttributeValue("invitestatuscode", (object) value);
        this.OnPropertyChanged(nameof (InviteStatusCode));
      }
    }

    [AttributeLogicalName("invitestatuscodename")]
    public object InviteStatusCodeName => this.GetAttributeValue<object>("invitestatuscodename");

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

    [AttributeLogicalName("isemailaddressapprovedbyo365admin")]
    public bool? IsEmailAddressApprovedByO365Admin
    {
      get => this.GetAttributeValue<bool?>("isemailaddressapprovedbyo365admin");
    }

    [AttributeLogicalName("isintegrationuser")]
    public bool? IsIntegrationUser
    {
      get => this.GetAttributeValue<bool?>("isintegrationuser");
      set
      {
        this.OnPropertyChanging(nameof (IsIntegrationUser));
        this.SetAttributeValue("isintegrationuser", (object) value);
        this.OnPropertyChanged(nameof (IsIntegrationUser));
      }
    }

    [AttributeLogicalName("isintegrationusername")]
    public object IsIntegrationUserName => this.GetAttributeValue<object>("isintegrationusername");

    [AttributeLogicalName("islicensed")]
    public bool? IsLicensed
    {
      get => this.GetAttributeValue<bool?>("islicensed");
      set
      {
        this.OnPropertyChanging(nameof (IsLicensed));
        this.SetAttributeValue("islicensed", (object) value);
        this.OnPropertyChanged(nameof (IsLicensed));
      }
    }

    [AttributeLogicalName("islicensedname")]
    public object IsLicensedName => this.GetAttributeValue<object>("islicensedname");

    [AttributeLogicalName("issyncwithdirectory")]
    public bool? IsSyncWithDirectory
    {
      get => this.GetAttributeValue<bool?>("issyncwithdirectory");
      set
      {
        this.OnPropertyChanging(nameof (IsSyncWithDirectory));
        this.SetAttributeValue("issyncwithdirectory", (object) value);
        this.OnPropertyChanged(nameof (IsSyncWithDirectory));
      }
    }

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

    [AttributeLogicalName("mobilealertemail")]
    public string MobileAlertEMail
    {
      get => this.GetAttributeValue<string>("mobilealertemail");
      set
      {
        this.OnPropertyChanging(nameof (MobileAlertEMail));
        this.SetAttributeValue("mobilealertemail", (object) value);
        this.OnPropertyChanged(nameof (MobileAlertEMail));
      }
    }

    [AttributeLogicalName("mobileofflineprofileid")]
    public EntityReference MobileOfflineProfileId
    {
      get => this.GetAttributeValue<EntityReference>("mobileofflineprofileid");
      set
      {
        this.OnPropertyChanging(nameof (MobileOfflineProfileId));
        this.SetAttributeValue("mobileofflineprofileid", (object) value);
        this.OnPropertyChanged(nameof (MobileOfflineProfileId));
      }
    }

    [AttributeLogicalName("mobileofflineprofileidname")]
    public string MobileOfflineProfileIdName
    {
      get => this.GetAttributeValue<string>("mobileofflineprofileidname");
      set
      {
        this.OnPropertyChanging(nameof (MobileOfflineProfileIdName));
        this.SetAttributeValue("mobileofflineprofileidname", (object) value);
        this.OnPropertyChanged(nameof (MobileOfflineProfileIdName));
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

    [AttributeLogicalName("organizationid")]
    public Guid? OrganizationId => this.GetAttributeValue<Guid?>("organizationid");

    [AttributeLogicalName("organizationidname")]
    public string OrganizationIdName => this.GetAttributeValue<string>("organizationidname");

    [AttributeLogicalName("outgoingemaildeliverymethod")]
    public OptionSetValue OutgoingEmailDeliveryMethod
    {
      get => this.GetAttributeValue<OptionSetValue>("outgoingemaildeliverymethod");
      set
      {
        this.OnPropertyChanging(nameof (OutgoingEmailDeliveryMethod));
        this.SetAttributeValue("outgoingemaildeliverymethod", (object) value);
        this.OnPropertyChanged(nameof (OutgoingEmailDeliveryMethod));
      }
    }

    [AttributeLogicalName("outgoingemaildeliverymethodname")]
    public object OutgoingEmailDeliveryMethodName
    {
      get => this.GetAttributeValue<object>("outgoingemaildeliverymethodname");
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

    [AttributeLogicalName("parentsystemuserid")]
    public EntityReference ParentSystemUserId
    {
      get => this.GetAttributeValue<EntityReference>("parentsystemuserid");
      set
      {
        this.OnPropertyChanging(nameof (ParentSystemUserId));
        this.SetAttributeValue("parentsystemuserid", (object) value);
        this.OnPropertyChanged(nameof (ParentSystemUserId));
      }
    }

    [AttributeLogicalName("parentsystemuseridname")]
    public string ParentSystemUserIdName
    {
      get => this.GetAttributeValue<string>("parentsystemuseridname");
    }

    [AttributeLogicalName("parentsystemuseridyominame")]
    public string ParentSystemUserIdYomiName
    {
      get => this.GetAttributeValue<string>("parentsystemuseridyominame");
    }

    [AttributeLogicalName("passporthi")]
    public int? PassportHi
    {
      get => this.GetAttributeValue<int?>("passporthi");
      set
      {
        this.OnPropertyChanging(nameof (PassportHi));
        this.SetAttributeValue("passporthi", (object) value);
        this.OnPropertyChanged(nameof (PassportHi));
      }
    }

    [AttributeLogicalName("passportlo")]
    public int? PassportLo
    {
      get => this.GetAttributeValue<int?>("passportlo");
      set
      {
        this.OnPropertyChanging(nameof (PassportLo));
        this.SetAttributeValue("passportlo", (object) value);
        this.OnPropertyChanged(nameof (PassportLo));
      }
    }

    [AttributeLogicalName("personalemailaddress")]
    public string PersonalEMailAddress
    {
      get => this.GetAttributeValue<string>("personalemailaddress");
      set
      {
        this.OnPropertyChanging(nameof (PersonalEMailAddress));
        this.SetAttributeValue("personalemailaddress", (object) value);
        this.OnPropertyChanged(nameof (PersonalEMailAddress));
      }
    }

    [AttributeLogicalName("photourl")]
    public string PhotoUrl
    {
      get => this.GetAttributeValue<string>("photourl");
      set
      {
        this.OnPropertyChanging(nameof (PhotoUrl));
        this.SetAttributeValue("photourl", (object) value);
        this.OnPropertyChanged(nameof (PhotoUrl));
      }
    }

    [AttributeLogicalName("positionid")]
    public EntityReference PositionId
    {
      get => this.GetAttributeValue<EntityReference>("positionid");
      set
      {
        this.OnPropertyChanging(nameof (PositionId));
        this.SetAttributeValue("positionid", (object) value);
        this.OnPropertyChanged(nameof (PositionId));
      }
    }

    [AttributeLogicalName("positionidname")]
    public string PositionIdName => this.GetAttributeValue<string>("positionidname");

    [AttributeLogicalName("preferredaddresscode")]
    public OptionSetValue PreferredAddressCode
    {
      get => this.GetAttributeValue<OptionSetValue>("preferredaddresscode");
      set
      {
        this.OnPropertyChanging(nameof (PreferredAddressCode));
        this.SetAttributeValue("preferredaddresscode", (object) value);
        this.OnPropertyChanged(nameof (PreferredAddressCode));
      }
    }

    [AttributeLogicalName("preferredaddresscodename")]
    public object PreferredAddressCodeName
    {
      get => this.GetAttributeValue<object>("preferredaddresscodename");
    }

    [AttributeLogicalName("preferredemailcode")]
    public OptionSetValue PreferredEmailCode
    {
      get => this.GetAttributeValue<OptionSetValue>("preferredemailcode");
      set
      {
        this.OnPropertyChanging(nameof (PreferredEmailCode));
        this.SetAttributeValue("preferredemailcode", (object) value);
        this.OnPropertyChanged(nameof (PreferredEmailCode));
      }
    }

    [AttributeLogicalName("preferredemailcodename")]
    public object PreferredEmailCodeName
    {
      get => this.GetAttributeValue<object>("preferredemailcodename");
    }

    [AttributeLogicalName("preferredphonecode")]
    public OptionSetValue PreferredPhoneCode
    {
      get => this.GetAttributeValue<OptionSetValue>("preferredphonecode");
      set
      {
        this.OnPropertyChanging(nameof (PreferredPhoneCode));
        this.SetAttributeValue("preferredphonecode", (object) value);
        this.OnPropertyChanged(nameof (PreferredPhoneCode));
      }
    }

    [AttributeLogicalName("preferredphonecodename")]
    public object PreferredPhoneCodeName
    {
      get => this.GetAttributeValue<object>("preferredphonecodename");
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

    [AttributeLogicalName("queueid")]
    public EntityReference QueueId
    {
      get => this.GetAttributeValue<EntityReference>("queueid");
      set
      {
        this.OnPropertyChanging(nameof (QueueId));
        this.SetAttributeValue("queueid", (object) value);
        this.OnPropertyChanged(nameof (QueueId));
      }
    }

    [AttributeLogicalName("queueidname")]
    public string QueueIdName => this.GetAttributeValue<string>("queueidname");

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

    [AttributeLogicalName("setupuser")]
    public bool? SetupUser
    {
      get => this.GetAttributeValue<bool?>("setupuser");
      set
      {
        this.OnPropertyChanging(nameof (SetupUser));
        this.SetAttributeValue("setupuser", (object) value);
        this.OnPropertyChanged(nameof (SetupUser));
      }
    }

    [AttributeLogicalName("setupusername")]
    public object SetupUserName => this.GetAttributeValue<object>("setupusername");

    [AttributeLogicalName("sharepointemailaddress")]
    public string SharePointEmailAddress
    {
      get => this.GetAttributeValue<string>("sharepointemailaddress");
      set
      {
        this.OnPropertyChanging(nameof (SharePointEmailAddress));
        this.SetAttributeValue("sharepointemailaddress", (object) value);
        this.OnPropertyChanged(nameof (SharePointEmailAddress));
      }
    }

    [AttributeLogicalName("skills")]
    public string Skills
    {
      get => this.GetAttributeValue<string>("skills");
      set
      {
        this.OnPropertyChanging(nameof (Skills));
        this.SetAttributeValue("skills", (object) value);
        this.OnPropertyChanged(nameof (Skills));
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

    [AttributeLogicalName("territoryid")]
    public EntityReference TerritoryId
    {
      get => this.GetAttributeValue<EntityReference>("territoryid");
      set
      {
        this.OnPropertyChanging(nameof (TerritoryId));
        this.SetAttributeValue("territoryid", (object) value);
        this.OnPropertyChanged(nameof (TerritoryId));
      }
    }

    [AttributeLogicalName("territoryidname")]
    public string TerritoryIdName => this.GetAttributeValue<string>("territoryidname");

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

    [AttributeLogicalName("title")]
    public string Title
    {
      get => this.GetAttributeValue<string>("title");
      set
      {
        this.OnPropertyChanging(nameof (Title));
        this.SetAttributeValue("title", (object) value);
        this.OnPropertyChanged(nameof (Title));
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

    [AttributeLogicalName("userlicensetype")]
    public int? UserLicenseType
    {
      get => this.GetAttributeValue<int?>("userlicensetype");
      set
      {
        this.OnPropertyChanging(nameof (UserLicenseType));
        this.SetAttributeValue("userlicensetype", (object) value);
        this.OnPropertyChanged(nameof (UserLicenseType));
      }
    }

    [AttributeLogicalName("userpuid")]
    public string UserPuid => this.GetAttributeValue<string>("userpuid");

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

    [AttributeLogicalName("windowsliveid")]
    public string WindowsLiveID
    {
      get => this.GetAttributeValue<string>("windowsliveid");
      set
      {
        this.OnPropertyChanging(nameof (WindowsLiveID));
        this.SetAttributeValue("windowsliveid", (object) value);
        this.OnPropertyChanged(nameof (WindowsLiveID));
      }
    }

    [AttributeLogicalName("yammeremailaddress")]
    public string YammerEmailAddress
    {
      get => this.GetAttributeValue<string>("yammeremailaddress");
      set
      {
        this.OnPropertyChanging(nameof (YammerEmailAddress));
        this.SetAttributeValue("yammeremailaddress", (object) value);
        this.OnPropertyChanged(nameof (YammerEmailAddress));
      }
    }

    [AttributeLogicalName("yammeruserid")]
    public string YammerUserId
    {
      get => this.GetAttributeValue<string>("yammeruserid");
      set
      {
        this.OnPropertyChanging(nameof (YammerUserId));
        this.SetAttributeValue("yammeruserid", (object) value);
        this.OnPropertyChanged(nameof (YammerUserId));
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

    [RelationshipSchemaName("ait_ait_assessment_ait_Caseworker_systemu")]
    public IEnumerable<ait_assessment> ait_ait_assessment_ait_Caseworker_systemu
    {
      get
      {
        return this.GetRelatedEntities<ait_assessment>(nameof (ait_ait_assessment_ait_Caseworker_systemu), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_assessment_ait_Caseworker_systemu));
        this.SetRelatedEntities<ait_assessment>(nameof (ait_ait_assessment_ait_Caseworker_systemu), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_assessment_ait_Caseworker_systemu));
      }
    }

    [RelationshipSchemaName("ait_systemuser_ait_case_ApprovedBy")]
    public IEnumerable<ait_case> ait_systemuser_ait_case_ApprovedBy
    {
      get
      {
        return this.GetRelatedEntities<ait_case>(nameof (ait_systemuser_ait_case_ApprovedBy), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_systemuser_ait_case_ApprovedBy));
        this.SetRelatedEntities<ait_case>(nameof (ait_systemuser_ait_case_ApprovedBy), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_systemuser_ait_case_ApprovedBy));
      }
    }

    [RelationshipSchemaName("ait_systemuser_ait_caseplan_Caseworker")]
    public IEnumerable<ait_caseplan> ait_systemuser_ait_caseplan_Caseworker
    {
      get
      {
        return this.GetRelatedEntities<ait_caseplan>(nameof (ait_systemuser_ait_caseplan_Caseworker), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_systemuser_ait_caseplan_Caseworker));
        this.SetRelatedEntities<ait_caseplan>(nameof (ait_systemuser_ait_caseplan_Caseworker), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_systemuser_ait_caseplan_Caseworker));
      }
    }

    [RelationshipSchemaName("ait_systemuser_ait_goal_Caseworker")]
    public IEnumerable<ait_goal> ait_systemuser_ait_goal_Caseworker
    {
      get
      {
        return this.GetRelatedEntities<ait_goal>(nameof (ait_systemuser_ait_goal_Caseworker), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_systemuser_ait_goal_Caseworker));
        this.SetRelatedEntities<ait_goal>(nameof (ait_systemuser_ait_goal_Caseworker), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_systemuser_ait_goal_Caseworker));
      }
    }

    [RelationshipSchemaName("ait_systemuser_ait_groupactivitymeeting_MeetingLeader")]
    public IEnumerable<ait_groupactivitymeeting> ait_systemuser_ait_groupactivitymeeting_MeetingLeader
    {
      get
      {
        return this.GetRelatedEntities<ait_groupactivitymeeting>(nameof (ait_systemuser_ait_groupactivitymeeting_MeetingLeader), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_systemuser_ait_groupactivitymeeting_MeetingLeader));
        this.SetRelatedEntities<ait_groupactivitymeeting>(nameof (ait_systemuser_ait_groupactivitymeeting_MeetingLeader), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_systemuser_ait_groupactivitymeeting_MeetingLeader));
      }
    }

    [RelationshipSchemaName("ait_systemuser_ait_incidents_primaryinvestigator")]
    public IEnumerable<ait_incidents> ait_systemuser_ait_incidents_primaryinvestigator
    {
      get
      {
        return this.GetRelatedEntities<ait_incidents>(nameof (ait_systemuser_ait_incidents_primaryinvestigator), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_systemuser_ait_incidents_primaryinvestigator));
        this.SetRelatedEntities<ait_incidents>(nameof (ait_systemuser_ait_incidents_primaryinvestigator), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_systemuser_ait_incidents_primaryinvestigator));
      }
    }

    [RelationshipSchemaName("ait_systemuser_ait_investigation_investigator")]
    public IEnumerable<ait_investigation> ait_systemuser_ait_investigation_investigator
    {
      get
      {
        return this.GetRelatedEntities<ait_investigation>(nameof (ait_systemuser_ait_investigation_investigator), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_systemuser_ait_investigation_investigator));
        this.SetRelatedEntities<ait_investigation>(nameof (ait_systemuser_ait_investigation_investigator), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_systemuser_ait_investigation_investigator));
      }
    }

    [RelationshipSchemaName("ait_systemuser_ait_payment_Approver")]
    public IEnumerable<ait_payment> ait_systemuser_ait_payment_Approver
    {
      get
      {
        return this.GetRelatedEntities<ait_payment>(nameof (ait_systemuser_ait_payment_Approver), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_systemuser_ait_payment_Approver));
        this.SetRelatedEntities<ait_payment>(nameof (ait_systemuser_ait_payment_Approver), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_systemuser_ait_payment_Approver));
      }
    }

    [RelationshipSchemaName("ait_systemuser_ait_placementlocation_InpsectedBy")]
    public IEnumerable<ait_placementlocation> ait_systemuser_ait_placementlocation_InpsectedBy
    {
      get
      {
        return this.GetRelatedEntities<ait_placementlocation>(nameof (ait_systemuser_ait_placementlocation_InpsectedBy), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_systemuser_ait_placementlocation_InpsectedBy));
        this.SetRelatedEntities<ait_placementlocation>(nameof (ait_systemuser_ait_placementlocation_InpsectedBy), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_systemuser_ait_placementlocation_InpsectedBy));
      }
    }

    [RelationshipSchemaName("ait_systemuser_ait_program_ProgramManager")]
    public IEnumerable<ait_program> ait_systemuser_ait_program_ProgramManager
    {
      get
      {
        return this.GetRelatedEntities<ait_program>(nameof (ait_systemuser_ait_program_ProgramManager), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_systemuser_ait_program_ProgramManager));
        this.SetRelatedEntities<ait_program>(nameof (ait_systemuser_ait_program_ProgramManager), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_systemuser_ait_program_ProgramManager));
      }
    }

    [RelationshipSchemaName("ait_systemuser_ait_referral_Approver")]
    public IEnumerable<ait_referral> ait_systemuser_ait_referral_Approver
    {
      get
      {
        return this.GetRelatedEntities<ait_referral>(nameof (ait_systemuser_ait_referral_Approver), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_systemuser_ait_referral_Approver));
        this.SetRelatedEntities<ait_referral>(nameof (ait_systemuser_ait_referral_Approver), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_systemuser_ait_referral_Approver));
      }
    }

    [RelationshipSchemaName("ait_systemuser_ait_referral_Caseworker")]
    public IEnumerable<ait_referral> ait_systemuser_ait_referral_Caseworker
    {
      get
      {
        return this.GetRelatedEntities<ait_referral>(nameof (ait_systemuser_ait_referral_Caseworker), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_systemuser_ait_referral_Caseworker));
        this.SetRelatedEntities<ait_referral>(nameof (ait_systemuser_ait_referral_Caseworker), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_systemuser_ait_referral_Caseworker));
      }
    }

    [RelationshipSchemaName("ait_systemuser_ait_referral_ReferredBy")]
    public IEnumerable<ait_referral> ait_systemuser_ait_referral_ReferredBy
    {
      get
      {
        return this.GetRelatedEntities<ait_referral>(nameof (ait_systemuser_ait_referral_ReferredBy), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_systemuser_ait_referral_ReferredBy));
        this.SetRelatedEntities<ait_referral>(nameof (ait_systemuser_ait_referral_ReferredBy), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_systemuser_ait_referral_ReferredBy));
      }
    }

    [RelationshipSchemaName("ait_systemuser_ait_servicerequest_approver")]
    public IEnumerable<ait_servicerequest> ait_systemuser_ait_servicerequest_approver
    {
      get
      {
        return this.GetRelatedEntities<ait_servicerequest>(nameof (ait_systemuser_ait_servicerequest_approver), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_systemuser_ait_servicerequest_approver));
        this.SetRelatedEntities<ait_servicerequest>(nameof (ait_systemuser_ait_servicerequest_approver), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_systemuser_ait_servicerequest_approver));
      }
    }

    [RelationshipSchemaName("ait_systemuser_ait_servicerequest_caseworker")]
    public IEnumerable<ait_servicerequest> ait_systemuser_ait_servicerequest_caseworker
    {
      get
      {
        return this.GetRelatedEntities<ait_servicerequest>(nameof (ait_systemuser_ait_servicerequest_caseworker), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_systemuser_ait_servicerequest_caseworker));
        this.SetRelatedEntities<ait_servicerequest>(nameof (ait_systemuser_ait_servicerequest_caseworker), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_systemuser_ait_servicerequest_caseworker));
      }
    }

    [RelationshipSchemaName("ait_systemuser_appointment_CourtClerk")]
    public IEnumerable<Appointment> ait_systemuser_appointment_CourtClerk
    {
      get
      {
        return this.GetRelatedEntities<Appointment>(nameof (ait_systemuser_appointment_CourtClerk), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_systemuser_appointment_CourtClerk));
        this.SetRelatedEntities<Appointment>(nameof (ait_systemuser_appointment_CourtClerk), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_systemuser_appointment_CourtClerk));
      }
    }

    [RelationshipSchemaName("ait_systemuser_appointment_CourtReporter")]
    public IEnumerable<Appointment> ait_systemuser_appointment_CourtReporter
    {
      get
      {
        return this.GetRelatedEntities<Appointment>(nameof (ait_systemuser_appointment_CourtReporter), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_systemuser_appointment_CourtReporter));
        this.SetRelatedEntities<Appointment>(nameof (ait_systemuser_appointment_CourtReporter), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_systemuser_appointment_CourtReporter));
      }
    }

    [RelationshipSchemaName("ait_systemuser_appointment_Judge")]
    public IEnumerable<Appointment> ait_systemuser_appointment_Judge
    {
      get
      {
        return this.GetRelatedEntities<Appointment>(nameof (ait_systemuser_appointment_Judge), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_systemuser_appointment_Judge));
        this.SetRelatedEntities<Appointment>(nameof (ait_systemuser_appointment_Judge), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_systemuser_appointment_Judge));
      }
    }

    [RelationshipSchemaName("contact_owning_user")]
    public IEnumerable<Contact> contact_owning_user
    {
      get => this.GetRelatedEntities<Contact>(nameof (contact_owning_user), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (contact_owning_user));
        this.SetRelatedEntities<Contact>(nameof (contact_owning_user), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (contact_owning_user));
      }
    }

    [RelationshipSchemaName("createdby_connection")]
    public IEnumerable<Connection> createdby_connection
    {
      get => this.GetRelatedEntities<Connection>(nameof (createdby_connection), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (createdby_connection));
        this.SetRelatedEntities<Connection>(nameof (createdby_connection), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (createdby_connection));
      }
    }

    [RelationshipSchemaName("createdby_connection_role")]
    public IEnumerable<ConnectionRole> createdby_connection_role
    {
      get
      {
        return this.GetRelatedEntities<ConnectionRole>(nameof (createdby_connection_role), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (createdby_connection_role));
        this.SetRelatedEntities<ConnectionRole>(nameof (createdby_connection_role), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (createdby_connection_role));
      }
    }

    [RelationshipSchemaName("lk_accountbase_createdby")]
    public IEnumerable<Account> lk_accountbase_createdby
    {
      get => this.GetRelatedEntities<Account>(nameof (lk_accountbase_createdby), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (lk_accountbase_createdby));
        this.SetRelatedEntities<Account>(nameof (lk_accountbase_createdby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_accountbase_createdby));
      }
    }

    [RelationshipSchemaName("lk_accountbase_createdonbehalfby")]
    public IEnumerable<Account> lk_accountbase_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<Account>(nameof (lk_accountbase_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_accountbase_createdonbehalfby));
        this.SetRelatedEntities<Account>(nameof (lk_accountbase_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_accountbase_createdonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_accountbase_modifiedby")]
    public IEnumerable<Account> lk_accountbase_modifiedby
    {
      get
      {
        return this.GetRelatedEntities<Account>(nameof (lk_accountbase_modifiedby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_accountbase_modifiedby));
        this.SetRelatedEntities<Account>(nameof (lk_accountbase_modifiedby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_accountbase_modifiedby));
      }
    }

    [RelationshipSchemaName("lk_accountbase_modifiedonbehalfby")]
    public IEnumerable<Account> lk_accountbase_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<Account>(nameof (lk_accountbase_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_accountbase_modifiedonbehalfby));
        this.SetRelatedEntities<Account>(nameof (lk_accountbase_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_accountbase_modifiedonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_ait_addresstype_createdby")]
    public IEnumerable<ait_addresstype> lk_ait_addresstype_createdby
    {
      get
      {
        return this.GetRelatedEntities<ait_addresstype>(nameof (lk_ait_addresstype_createdby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_addresstype_createdby));
        this.SetRelatedEntities<ait_addresstype>(nameof (lk_ait_addresstype_createdby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_addresstype_createdby));
      }
    }

    [RelationshipSchemaName("lk_ait_addresstype_createdonbehalfby")]
    public IEnumerable<ait_addresstype> lk_ait_addresstype_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<ait_addresstype>(nameof (lk_ait_addresstype_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_addresstype_createdonbehalfby));
        this.SetRelatedEntities<ait_addresstype>(nameof (lk_ait_addresstype_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_addresstype_createdonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_ait_addresstype_modifiedby")]
    public IEnumerable<ait_addresstype> lk_ait_addresstype_modifiedby
    {
      get
      {
        return this.GetRelatedEntities<ait_addresstype>(nameof (lk_ait_addresstype_modifiedby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_addresstype_modifiedby));
        this.SetRelatedEntities<ait_addresstype>(nameof (lk_ait_addresstype_modifiedby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_addresstype_modifiedby));
      }
    }

    [RelationshipSchemaName("lk_ait_addresstype_modifiedonbehalfby")]
    public IEnumerable<ait_addresstype> lk_ait_addresstype_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<ait_addresstype>(nameof (lk_ait_addresstype_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_addresstype_modifiedonbehalfby));
        this.SetRelatedEntities<ait_addresstype>(nameof (lk_ait_addresstype_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_addresstype_modifiedonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_ait_assessment_createdby")]
    public IEnumerable<ait_assessment> lk_ait_assessment_createdby
    {
      get
      {
        return this.GetRelatedEntities<ait_assessment>(nameof (lk_ait_assessment_createdby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_assessment_createdby));
        this.SetRelatedEntities<ait_assessment>(nameof (lk_ait_assessment_createdby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_assessment_createdby));
      }
    }

    [RelationshipSchemaName("lk_ait_assessment_createdonbehalfby")]
    public IEnumerable<ait_assessment> lk_ait_assessment_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<ait_assessment>(nameof (lk_ait_assessment_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_assessment_createdonbehalfby));
        this.SetRelatedEntities<ait_assessment>(nameof (lk_ait_assessment_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_assessment_createdonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_ait_assessment_modifiedby")]
    public IEnumerable<ait_assessment> lk_ait_assessment_modifiedby
    {
      get
      {
        return this.GetRelatedEntities<ait_assessment>(nameof (lk_ait_assessment_modifiedby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_assessment_modifiedby));
        this.SetRelatedEntities<ait_assessment>(nameof (lk_ait_assessment_modifiedby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_assessment_modifiedby));
      }
    }

    [RelationshipSchemaName("lk_ait_assessment_modifiedonbehalfby")]
    public IEnumerable<ait_assessment> lk_ait_assessment_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<ait_assessment>(nameof (lk_ait_assessment_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_assessment_modifiedonbehalfby));
        this.SetRelatedEntities<ait_assessment>(nameof (lk_ait_assessment_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_assessment_modifiedonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_ait_case_createdby")]
    public IEnumerable<ait_case> lk_ait_case_createdby
    {
      get => this.GetRelatedEntities<ait_case>(nameof (lk_ait_case_createdby), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_case_createdby));
        this.SetRelatedEntities<ait_case>(nameof (lk_ait_case_createdby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_case_createdby));
      }
    }

    [RelationshipSchemaName("lk_ait_case_createdonbehalfby")]
    public IEnumerable<ait_case> lk_ait_case_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<ait_case>(nameof (lk_ait_case_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_case_createdonbehalfby));
        this.SetRelatedEntities<ait_case>(nameof (lk_ait_case_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_case_createdonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_ait_case_modifiedby")]
    public IEnumerable<ait_case> lk_ait_case_modifiedby
    {
      get => this.GetRelatedEntities<ait_case>(nameof (lk_ait_case_modifiedby), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_case_modifiedby));
        this.SetRelatedEntities<ait_case>(nameof (lk_ait_case_modifiedby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_case_modifiedby));
      }
    }

    [RelationshipSchemaName("lk_ait_case_modifiedonbehalfby")]
    public IEnumerable<ait_case> lk_ait_case_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<ait_case>(nameof (lk_ait_case_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_case_modifiedonbehalfby));
        this.SetRelatedEntities<ait_case>(nameof (lk_ait_case_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_case_modifiedonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_ait_casenotefamilywellness_createdby")]
    public IEnumerable<ait_casenotefamilywellness> lk_ait_casenotefamilywellness_createdby
    {
      get
      {
        return this.GetRelatedEntities<ait_casenotefamilywellness>(nameof (lk_ait_casenotefamilywellness_createdby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_casenotefamilywellness_createdby));
        this.SetRelatedEntities<ait_casenotefamilywellness>(nameof (lk_ait_casenotefamilywellness_createdby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_casenotefamilywellness_createdby));
      }
    }

    [RelationshipSchemaName("lk_ait_casenotefamilywellness_createdonbehalfby")]
    public IEnumerable<ait_casenotefamilywellness> lk_ait_casenotefamilywellness_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<ait_casenotefamilywellness>(nameof (lk_ait_casenotefamilywellness_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_casenotefamilywellness_createdonbehalfby));
        this.SetRelatedEntities<ait_casenotefamilywellness>(nameof (lk_ait_casenotefamilywellness_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_casenotefamilywellness_createdonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_ait_casenotefamilywellness_modifiedby")]
    public IEnumerable<ait_casenotefamilywellness> lk_ait_casenotefamilywellness_modifiedby
    {
      get
      {
        return this.GetRelatedEntities<ait_casenotefamilywellness>(nameof (lk_ait_casenotefamilywellness_modifiedby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_casenotefamilywellness_modifiedby));
        this.SetRelatedEntities<ait_casenotefamilywellness>(nameof (lk_ait_casenotefamilywellness_modifiedby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_casenotefamilywellness_modifiedby));
      }
    }

    [RelationshipSchemaName("lk_ait_casenotefamilywellness_modifiedonbehalfby")]
    public IEnumerable<ait_casenotefamilywellness> lk_ait_casenotefamilywellness_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<ait_casenotefamilywellness>(nameof (lk_ait_casenotefamilywellness_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_casenotefamilywellness_modifiedonbehalfby));
        this.SetRelatedEntities<ait_casenotefamilywellness>(nameof (lk_ait_casenotefamilywellness_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_casenotefamilywellness_modifiedonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_ait_caseplan_createdby")]
    public IEnumerable<ait_caseplan> lk_ait_caseplan_createdby
    {
      get
      {
        return this.GetRelatedEntities<ait_caseplan>(nameof (lk_ait_caseplan_createdby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_caseplan_createdby));
        this.SetRelatedEntities<ait_caseplan>(nameof (lk_ait_caseplan_createdby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_caseplan_createdby));
      }
    }

    [RelationshipSchemaName("lk_ait_caseplan_createdonbehalfby")]
    public IEnumerable<ait_caseplan> lk_ait_caseplan_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<ait_caseplan>(nameof (lk_ait_caseplan_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_caseplan_createdonbehalfby));
        this.SetRelatedEntities<ait_caseplan>(nameof (lk_ait_caseplan_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_caseplan_createdonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_ait_caseplan_modifiedby")]
    public IEnumerable<ait_caseplan> lk_ait_caseplan_modifiedby
    {
      get
      {
        return this.GetRelatedEntities<ait_caseplan>(nameof (lk_ait_caseplan_modifiedby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_caseplan_modifiedby));
        this.SetRelatedEntities<ait_caseplan>(nameof (lk_ait_caseplan_modifiedby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_caseplan_modifiedby));
      }
    }

    [RelationshipSchemaName("lk_ait_caseplan_modifiedonbehalfby")]
    public IEnumerable<ait_caseplan> lk_ait_caseplan_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<ait_caseplan>(nameof (lk_ait_caseplan_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_caseplan_modifiedonbehalfby));
        this.SetRelatedEntities<ait_caseplan>(nameof (lk_ait_caseplan_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_caseplan_modifiedonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_ait_clan_createdby")]
    public IEnumerable<ait_clan> lk_ait_clan_createdby
    {
      get => this.GetRelatedEntities<ait_clan>(nameof (lk_ait_clan_createdby), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_clan_createdby));
        this.SetRelatedEntities<ait_clan>(nameof (lk_ait_clan_createdby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_clan_createdby));
      }
    }

    [RelationshipSchemaName("lk_ait_clan_createdonbehalfby")]
    public IEnumerable<ait_clan> lk_ait_clan_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<ait_clan>(nameof (lk_ait_clan_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_clan_createdonbehalfby));
        this.SetRelatedEntities<ait_clan>(nameof (lk_ait_clan_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_clan_createdonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_ait_clan_modifiedby")]
    public IEnumerable<ait_clan> lk_ait_clan_modifiedby
    {
      get => this.GetRelatedEntities<ait_clan>(nameof (lk_ait_clan_modifiedby), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_clan_modifiedby));
        this.SetRelatedEntities<ait_clan>(nameof (lk_ait_clan_modifiedby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_clan_modifiedby));
      }
    }

    [RelationshipSchemaName("lk_ait_clan_modifiedonbehalfby")]
    public IEnumerable<ait_clan> lk_ait_clan_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<ait_clan>(nameof (lk_ait_clan_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_clan_modifiedonbehalfby));
        this.SetRelatedEntities<ait_clan>(nameof (lk_ait_clan_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_clan_modifiedonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_ait_clientprofile_createdby")]
    public IEnumerable<ait_clientprofile> lk_ait_clientprofile_createdby
    {
      get
      {
        return this.GetRelatedEntities<ait_clientprofile>(nameof (lk_ait_clientprofile_createdby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_clientprofile_createdby));
        this.SetRelatedEntities<ait_clientprofile>(nameof (lk_ait_clientprofile_createdby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_clientprofile_createdby));
      }
    }

    [RelationshipSchemaName("lk_ait_clientprofile_createdonbehalfby")]
    public IEnumerable<ait_clientprofile> lk_ait_clientprofile_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<ait_clientprofile>(nameof (lk_ait_clientprofile_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_clientprofile_createdonbehalfby));
        this.SetRelatedEntities<ait_clientprofile>(nameof (lk_ait_clientprofile_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_clientprofile_createdonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_ait_clientprofile_modifiedby")]
    public IEnumerable<ait_clientprofile> lk_ait_clientprofile_modifiedby
    {
      get
      {
        return this.GetRelatedEntities<ait_clientprofile>(nameof (lk_ait_clientprofile_modifiedby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_clientprofile_modifiedby));
        this.SetRelatedEntities<ait_clientprofile>(nameof (lk_ait_clientprofile_modifiedby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_clientprofile_modifiedby));
      }
    }

    [RelationshipSchemaName("lk_ait_clientprofile_modifiedonbehalfby")]
    public IEnumerable<ait_clientprofile> lk_ait_clientprofile_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<ait_clientprofile>(nameof (lk_ait_clientprofile_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_clientprofile_modifiedonbehalfby));
        this.SetRelatedEntities<ait_clientprofile>(nameof (lk_ait_clientprofile_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_clientprofile_modifiedonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_ait_familygroup_createdby")]
    public IEnumerable<ait_familygroup> lk_ait_familygroup_createdby
    {
      get
      {
        return this.GetRelatedEntities<ait_familygroup>(nameof (lk_ait_familygroup_createdby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_familygroup_createdby));
        this.SetRelatedEntities<ait_familygroup>(nameof (lk_ait_familygroup_createdby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_familygroup_createdby));
      }
    }

    [RelationshipSchemaName("lk_ait_familygroup_createdonbehalfby")]
    public IEnumerable<ait_familygroup> lk_ait_familygroup_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<ait_familygroup>(nameof (lk_ait_familygroup_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_familygroup_createdonbehalfby));
        this.SetRelatedEntities<ait_familygroup>(nameof (lk_ait_familygroup_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_familygroup_createdonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_ait_familygroup_modifiedby")]
    public IEnumerable<ait_familygroup> lk_ait_familygroup_modifiedby
    {
      get
      {
        return this.GetRelatedEntities<ait_familygroup>(nameof (lk_ait_familygroup_modifiedby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_familygroup_modifiedby));
        this.SetRelatedEntities<ait_familygroup>(nameof (lk_ait_familygroup_modifiedby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_familygroup_modifiedby));
      }
    }

    [RelationshipSchemaName("lk_ait_familygroup_modifiedonbehalfby")]
    public IEnumerable<ait_familygroup> lk_ait_familygroup_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<ait_familygroup>(nameof (lk_ait_familygroup_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_familygroup_modifiedonbehalfby));
        this.SetRelatedEntities<ait_familygroup>(nameof (lk_ait_familygroup_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_familygroup_modifiedonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_ait_familywellnessconfiguration_createdby")]
    public IEnumerable<ait_familywellnessconfiguration> lk_ait_familywellnessconfiguration_createdby
    {
      get
      {
        return this.GetRelatedEntities<ait_familywellnessconfiguration>(nameof (lk_ait_familywellnessconfiguration_createdby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_familywellnessconfiguration_createdby));
        this.SetRelatedEntities<ait_familywellnessconfiguration>(nameof (lk_ait_familywellnessconfiguration_createdby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_familywellnessconfiguration_createdby));
      }
    }

    [RelationshipSchemaName("lk_ait_familywellnessconfiguration_createdonbehalfby")]
    public IEnumerable<ait_familywellnessconfiguration> lk_ait_familywellnessconfiguration_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<ait_familywellnessconfiguration>(nameof (lk_ait_familywellnessconfiguration_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_familywellnessconfiguration_createdonbehalfby));
        this.SetRelatedEntities<ait_familywellnessconfiguration>(nameof (lk_ait_familywellnessconfiguration_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_familywellnessconfiguration_createdonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_ait_familywellnessconfiguration_modifiedby")]
    public IEnumerable<ait_familywellnessconfiguration> lk_ait_familywellnessconfiguration_modifiedby
    {
      get
      {
        return this.GetRelatedEntities<ait_familywellnessconfiguration>(nameof (lk_ait_familywellnessconfiguration_modifiedby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_familywellnessconfiguration_modifiedby));
        this.SetRelatedEntities<ait_familywellnessconfiguration>(nameof (lk_ait_familywellnessconfiguration_modifiedby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_familywellnessconfiguration_modifiedby));
      }
    }

    [RelationshipSchemaName("lk_ait_familywellnessconfiguration_modifiedonbehalfby")]
    public IEnumerable<ait_familywellnessconfiguration> lk_ait_familywellnessconfiguration_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<ait_familywellnessconfiguration>(nameof (lk_ait_familywellnessconfiguration_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_familywellnessconfiguration_modifiedonbehalfby));
        this.SetRelatedEntities<ait_familywellnessconfiguration>(nameof (lk_ait_familywellnessconfiguration_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_familywellnessconfiguration_modifiedonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_ait_goal_createdby")]
    public IEnumerable<ait_goal> lk_ait_goal_createdby
    {
      get => this.GetRelatedEntities<ait_goal>(nameof (lk_ait_goal_createdby), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_goal_createdby));
        this.SetRelatedEntities<ait_goal>(nameof (lk_ait_goal_createdby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_goal_createdby));
      }
    }

    [RelationshipSchemaName("lk_ait_goal_createdonbehalfby")]
    public IEnumerable<ait_goal> lk_ait_goal_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<ait_goal>(nameof (lk_ait_goal_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_goal_createdonbehalfby));
        this.SetRelatedEntities<ait_goal>(nameof (lk_ait_goal_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_goal_createdonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_ait_goal_modifiedby")]
    public IEnumerable<ait_goal> lk_ait_goal_modifiedby
    {
      get => this.GetRelatedEntities<ait_goal>(nameof (lk_ait_goal_modifiedby), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_goal_modifiedby));
        this.SetRelatedEntities<ait_goal>(nameof (lk_ait_goal_modifiedby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_goal_modifiedby));
      }
    }

    [RelationshipSchemaName("lk_ait_goal_modifiedonbehalfby")]
    public IEnumerable<ait_goal> lk_ait_goal_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<ait_goal>(nameof (lk_ait_goal_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_goal_modifiedonbehalfby));
        this.SetRelatedEntities<ait_goal>(nameof (lk_ait_goal_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_goal_modifiedonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_ait_groupactivity_createdby")]
    public IEnumerable<ait_groupactivity> lk_ait_groupactivity_createdby
    {
      get
      {
        return this.GetRelatedEntities<ait_groupactivity>(nameof (lk_ait_groupactivity_createdby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_groupactivity_createdby));
        this.SetRelatedEntities<ait_groupactivity>(nameof (lk_ait_groupactivity_createdby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_groupactivity_createdby));
      }
    }

    [RelationshipSchemaName("lk_ait_groupactivity_createdonbehalfby")]
    public IEnumerable<ait_groupactivity> lk_ait_groupactivity_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<ait_groupactivity>(nameof (lk_ait_groupactivity_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_groupactivity_createdonbehalfby));
        this.SetRelatedEntities<ait_groupactivity>(nameof (lk_ait_groupactivity_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_groupactivity_createdonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_ait_groupactivity_modifiedby")]
    public IEnumerable<ait_groupactivity> lk_ait_groupactivity_modifiedby
    {
      get
      {
        return this.GetRelatedEntities<ait_groupactivity>(nameof (lk_ait_groupactivity_modifiedby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_groupactivity_modifiedby));
        this.SetRelatedEntities<ait_groupactivity>(nameof (lk_ait_groupactivity_modifiedby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_groupactivity_modifiedby));
      }
    }

    [RelationshipSchemaName("lk_ait_groupactivity_modifiedonbehalfby")]
    public IEnumerable<ait_groupactivity> lk_ait_groupactivity_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<ait_groupactivity>(nameof (lk_ait_groupactivity_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_groupactivity_modifiedonbehalfby));
        this.SetRelatedEntities<ait_groupactivity>(nameof (lk_ait_groupactivity_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_groupactivity_modifiedonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_ait_groupactivitymeeting_createdby")]
    public IEnumerable<ait_groupactivitymeeting> lk_ait_groupactivitymeeting_createdby
    {
      get
      {
        return this.GetRelatedEntities<ait_groupactivitymeeting>(nameof (lk_ait_groupactivitymeeting_createdby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_groupactivitymeeting_createdby));
        this.SetRelatedEntities<ait_groupactivitymeeting>(nameof (lk_ait_groupactivitymeeting_createdby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_groupactivitymeeting_createdby));
      }
    }

    [RelationshipSchemaName("lk_ait_groupactivitymeeting_createdonbehalfby")]
    public IEnumerable<ait_groupactivitymeeting> lk_ait_groupactivitymeeting_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<ait_groupactivitymeeting>(nameof (lk_ait_groupactivitymeeting_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_groupactivitymeeting_createdonbehalfby));
        this.SetRelatedEntities<ait_groupactivitymeeting>(nameof (lk_ait_groupactivitymeeting_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_groupactivitymeeting_createdonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_ait_groupactivitymeeting_modifiedby")]
    public IEnumerable<ait_groupactivitymeeting> lk_ait_groupactivitymeeting_modifiedby
    {
      get
      {
        return this.GetRelatedEntities<ait_groupactivitymeeting>(nameof (lk_ait_groupactivitymeeting_modifiedby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_groupactivitymeeting_modifiedby));
        this.SetRelatedEntities<ait_groupactivitymeeting>(nameof (lk_ait_groupactivitymeeting_modifiedby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_groupactivitymeeting_modifiedby));
      }
    }

    [RelationshipSchemaName("lk_ait_groupactivitymeeting_modifiedonbehalfby")]
    public IEnumerable<ait_groupactivitymeeting> lk_ait_groupactivitymeeting_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<ait_groupactivitymeeting>(nameof (lk_ait_groupactivitymeeting_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_groupactivitymeeting_modifiedonbehalfby));
        this.SetRelatedEntities<ait_groupactivitymeeting>(nameof (lk_ait_groupactivitymeeting_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_groupactivitymeeting_modifiedonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_ait_groupactivityregistration_createdby")]
    public IEnumerable<ait_groupactivityregistration> lk_ait_groupactivityregistration_createdby
    {
      get
      {
        return this.GetRelatedEntities<ait_groupactivityregistration>(nameof (lk_ait_groupactivityregistration_createdby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_groupactivityregistration_createdby));
        this.SetRelatedEntities<ait_groupactivityregistration>(nameof (lk_ait_groupactivityregistration_createdby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_groupactivityregistration_createdby));
      }
    }

    [RelationshipSchemaName("lk_ait_groupactivityregistration_createdonbehalfby")]
    public IEnumerable<ait_groupactivityregistration> lk_ait_groupactivityregistration_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<ait_groupactivityregistration>(nameof (lk_ait_groupactivityregistration_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_groupactivityregistration_createdonbehalfby));
        this.SetRelatedEntities<ait_groupactivityregistration>(nameof (lk_ait_groupactivityregistration_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_groupactivityregistration_createdonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_ait_groupactivityregistration_modifiedby")]
    public IEnumerable<ait_groupactivityregistration> lk_ait_groupactivityregistration_modifiedby
    {
      get
      {
        return this.GetRelatedEntities<ait_groupactivityregistration>(nameof (lk_ait_groupactivityregistration_modifiedby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_groupactivityregistration_modifiedby));
        this.SetRelatedEntities<ait_groupactivityregistration>(nameof (lk_ait_groupactivityregistration_modifiedby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_groupactivityregistration_modifiedby));
      }
    }

    [RelationshipSchemaName("lk_ait_groupactivityregistration_modifiedonbehalfby")]
    public IEnumerable<ait_groupactivityregistration> lk_ait_groupactivityregistration_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<ait_groupactivityregistration>(nameof (lk_ait_groupactivityregistration_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_groupactivityregistration_modifiedonbehalfby));
        this.SetRelatedEntities<ait_groupactivityregistration>(nameof (lk_ait_groupactivityregistration_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_groupactivityregistration_modifiedonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_ait_incidents_createdby")]
    public IEnumerable<ait_incidents> lk_ait_incidents_createdby
    {
      get
      {
        return this.GetRelatedEntities<ait_incidents>(nameof (lk_ait_incidents_createdby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_incidents_createdby));
        this.SetRelatedEntities<ait_incidents>(nameof (lk_ait_incidents_createdby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_incidents_createdby));
      }
    }

    [RelationshipSchemaName("lk_ait_incidents_createdonbehalfby")]
    public IEnumerable<ait_incidents> lk_ait_incidents_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<ait_incidents>(nameof (lk_ait_incidents_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_incidents_createdonbehalfby));
        this.SetRelatedEntities<ait_incidents>(nameof (lk_ait_incidents_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_incidents_createdonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_ait_incidents_modifiedby")]
    public IEnumerable<ait_incidents> lk_ait_incidents_modifiedby
    {
      get
      {
        return this.GetRelatedEntities<ait_incidents>(nameof (lk_ait_incidents_modifiedby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_incidents_modifiedby));
        this.SetRelatedEntities<ait_incidents>(nameof (lk_ait_incidents_modifiedby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_incidents_modifiedby));
      }
    }

    [RelationshipSchemaName("lk_ait_incidents_modifiedonbehalfby")]
    public IEnumerable<ait_incidents> lk_ait_incidents_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<ait_incidents>(nameof (lk_ait_incidents_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_incidents_modifiedonbehalfby));
        this.SetRelatedEntities<ait_incidents>(nameof (lk_ait_incidents_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_incidents_modifiedonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_ait_incidenttype_createdby")]
    public IEnumerable<ait_incidenttype> lk_ait_incidenttype_createdby
    {
      get
      {
        return this.GetRelatedEntities<ait_incidenttype>(nameof (lk_ait_incidenttype_createdby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_incidenttype_createdby));
        this.SetRelatedEntities<ait_incidenttype>(nameof (lk_ait_incidenttype_createdby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_incidenttype_createdby));
      }
    }

    [RelationshipSchemaName("lk_ait_incidenttype_createdonbehalfby")]
    public IEnumerable<ait_incidenttype> lk_ait_incidenttype_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<ait_incidenttype>(nameof (lk_ait_incidenttype_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_incidenttype_createdonbehalfby));
        this.SetRelatedEntities<ait_incidenttype>(nameof (lk_ait_incidenttype_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_incidenttype_createdonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_ait_incidenttype_modifiedby")]
    public IEnumerable<ait_incidenttype> lk_ait_incidenttype_modifiedby
    {
      get
      {
        return this.GetRelatedEntities<ait_incidenttype>(nameof (lk_ait_incidenttype_modifiedby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_incidenttype_modifiedby));
        this.SetRelatedEntities<ait_incidenttype>(nameof (lk_ait_incidenttype_modifiedby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_incidenttype_modifiedby));
      }
    }

    [RelationshipSchemaName("lk_ait_incidenttype_modifiedonbehalfby")]
    public IEnumerable<ait_incidenttype> lk_ait_incidenttype_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<ait_incidenttype>(nameof (lk_ait_incidenttype_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_incidenttype_modifiedonbehalfby));
        this.SetRelatedEntities<ait_incidenttype>(nameof (lk_ait_incidenttype_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_incidenttype_modifiedonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_ait_investigation_createdby")]
    public IEnumerable<ait_investigation> lk_ait_investigation_createdby
    {
      get
      {
        return this.GetRelatedEntities<ait_investigation>(nameof (lk_ait_investigation_createdby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_investigation_createdby));
        this.SetRelatedEntities<ait_investigation>(nameof (lk_ait_investigation_createdby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_investigation_createdby));
      }
    }

    [RelationshipSchemaName("lk_ait_investigation_createdonbehalfby")]
    public IEnumerable<ait_investigation> lk_ait_investigation_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<ait_investigation>(nameof (lk_ait_investigation_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_investigation_createdonbehalfby));
        this.SetRelatedEntities<ait_investigation>(nameof (lk_ait_investigation_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_investigation_createdonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_ait_investigation_modifiedby")]
    public IEnumerable<ait_investigation> lk_ait_investigation_modifiedby
    {
      get
      {
        return this.GetRelatedEntities<ait_investigation>(nameof (lk_ait_investigation_modifiedby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_investigation_modifiedby));
        this.SetRelatedEntities<ait_investigation>(nameof (lk_ait_investigation_modifiedby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_investigation_modifiedby));
      }
    }

    [RelationshipSchemaName("lk_ait_investigation_modifiedonbehalfby")]
    public IEnumerable<ait_investigation> lk_ait_investigation_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<ait_investigation>(nameof (lk_ait_investigation_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_investigation_modifiedonbehalfby));
        this.SetRelatedEntities<ait_investigation>(nameof (lk_ait_investigation_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_investigation_modifiedonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_ait_meetingattendee_createdby")]
    public IEnumerable<ait_meetingattendee> lk_ait_meetingattendee_createdby
    {
      get
      {
        return this.GetRelatedEntities<ait_meetingattendee>(nameof (lk_ait_meetingattendee_createdby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_meetingattendee_createdby));
        this.SetRelatedEntities<ait_meetingattendee>(nameof (lk_ait_meetingattendee_createdby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_meetingattendee_createdby));
      }
    }

    [RelationshipSchemaName("lk_ait_meetingattendee_createdonbehalfby")]
    public IEnumerable<ait_meetingattendee> lk_ait_meetingattendee_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<ait_meetingattendee>(nameof (lk_ait_meetingattendee_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_meetingattendee_createdonbehalfby));
        this.SetRelatedEntities<ait_meetingattendee>(nameof (lk_ait_meetingattendee_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_meetingattendee_createdonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_ait_meetingattendee_modifiedby")]
    public IEnumerable<ait_meetingattendee> lk_ait_meetingattendee_modifiedby
    {
      get
      {
        return this.GetRelatedEntities<ait_meetingattendee>(nameof (lk_ait_meetingattendee_modifiedby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_meetingattendee_modifiedby));
        this.SetRelatedEntities<ait_meetingattendee>(nameof (lk_ait_meetingattendee_modifiedby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_meetingattendee_modifiedby));
      }
    }

    [RelationshipSchemaName("lk_ait_meetingattendee_modifiedonbehalfby")]
    public IEnumerable<ait_meetingattendee> lk_ait_meetingattendee_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<ait_meetingattendee>(nameof (lk_ait_meetingattendee_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_meetingattendee_modifiedonbehalfby));
        this.SetRelatedEntities<ait_meetingattendee>(nameof (lk_ait_meetingattendee_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_meetingattendee_modifiedonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_ait_payment_createdby")]
    public IEnumerable<ait_payment> lk_ait_payment_createdby
    {
      get
      {
        return this.GetRelatedEntities<ait_payment>(nameof (lk_ait_payment_createdby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_payment_createdby));
        this.SetRelatedEntities<ait_payment>(nameof (lk_ait_payment_createdby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_payment_createdby));
      }
    }

    [RelationshipSchemaName("lk_ait_payment_createdonbehalfby")]
    public IEnumerable<ait_payment> lk_ait_payment_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<ait_payment>(nameof (lk_ait_payment_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_payment_createdonbehalfby));
        this.SetRelatedEntities<ait_payment>(nameof (lk_ait_payment_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_payment_createdonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_ait_payment_modifiedby")]
    public IEnumerable<ait_payment> lk_ait_payment_modifiedby
    {
      get
      {
        return this.GetRelatedEntities<ait_payment>(nameof (lk_ait_payment_modifiedby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_payment_modifiedby));
        this.SetRelatedEntities<ait_payment>(nameof (lk_ait_payment_modifiedby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_payment_modifiedby));
      }
    }

    [RelationshipSchemaName("lk_ait_payment_modifiedonbehalfby")]
    public IEnumerable<ait_payment> lk_ait_payment_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<ait_payment>(nameof (lk_ait_payment_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_payment_modifiedonbehalfby));
        this.SetRelatedEntities<ait_payment>(nameof (lk_ait_payment_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_payment_modifiedonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_ait_placement_createdby")]
    public IEnumerable<ait_placement> lk_ait_placement_createdby
    {
      get
      {
        return this.GetRelatedEntities<ait_placement>(nameof (lk_ait_placement_createdby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_placement_createdby));
        this.SetRelatedEntities<ait_placement>(nameof (lk_ait_placement_createdby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_placement_createdby));
      }
    }

    [RelationshipSchemaName("lk_ait_placement_createdonbehalfby")]
    public IEnumerable<ait_placement> lk_ait_placement_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<ait_placement>(nameof (lk_ait_placement_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_placement_createdonbehalfby));
        this.SetRelatedEntities<ait_placement>(nameof (lk_ait_placement_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_placement_createdonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_ait_placement_modifiedby")]
    public IEnumerable<ait_placement> lk_ait_placement_modifiedby
    {
      get
      {
        return this.GetRelatedEntities<ait_placement>(nameof (lk_ait_placement_modifiedby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_placement_modifiedby));
        this.SetRelatedEntities<ait_placement>(nameof (lk_ait_placement_modifiedby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_placement_modifiedby));
      }
    }

    [RelationshipSchemaName("lk_ait_placement_modifiedonbehalfby")]
    public IEnumerable<ait_placement> lk_ait_placement_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<ait_placement>(nameof (lk_ait_placement_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_placement_modifiedonbehalfby));
        this.SetRelatedEntities<ait_placement>(nameof (lk_ait_placement_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_placement_modifiedonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_ait_placementlocation_createdby")]
    public IEnumerable<ait_placementlocation> lk_ait_placementlocation_createdby
    {
      get
      {
        return this.GetRelatedEntities<ait_placementlocation>(nameof (lk_ait_placementlocation_createdby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_placementlocation_createdby));
        this.SetRelatedEntities<ait_placementlocation>(nameof (lk_ait_placementlocation_createdby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_placementlocation_createdby));
      }
    }

    [RelationshipSchemaName("lk_ait_placementlocation_createdonbehalfby")]
    public IEnumerable<ait_placementlocation> lk_ait_placementlocation_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<ait_placementlocation>(nameof (lk_ait_placementlocation_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_placementlocation_createdonbehalfby));
        this.SetRelatedEntities<ait_placementlocation>(nameof (lk_ait_placementlocation_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_placementlocation_createdonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_ait_placementlocation_modifiedby")]
    public IEnumerable<ait_placementlocation> lk_ait_placementlocation_modifiedby
    {
      get
      {
        return this.GetRelatedEntities<ait_placementlocation>(nameof (lk_ait_placementlocation_modifiedby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_placementlocation_modifiedby));
        this.SetRelatedEntities<ait_placementlocation>(nameof (lk_ait_placementlocation_modifiedby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_placementlocation_modifiedby));
      }
    }

    [RelationshipSchemaName("lk_ait_placementlocation_modifiedonbehalfby")]
    public IEnumerable<ait_placementlocation> lk_ait_placementlocation_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<ait_placementlocation>(nameof (lk_ait_placementlocation_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_placementlocation_modifiedonbehalfby));
        this.SetRelatedEntities<ait_placementlocation>(nameof (lk_ait_placementlocation_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_placementlocation_modifiedonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_ait_planactivity_createdby")]
    public IEnumerable<ait_planactivity> lk_ait_planactivity_createdby
    {
      get
      {
        return this.GetRelatedEntities<ait_planactivity>(nameof (lk_ait_planactivity_createdby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_planactivity_createdby));
        this.SetRelatedEntities<ait_planactivity>(nameof (lk_ait_planactivity_createdby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_planactivity_createdby));
      }
    }

    [RelationshipSchemaName("lk_ait_planactivity_createdonbehalfby")]
    public IEnumerable<ait_planactivity> lk_ait_planactivity_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<ait_planactivity>(nameof (lk_ait_planactivity_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_planactivity_createdonbehalfby));
        this.SetRelatedEntities<ait_planactivity>(nameof (lk_ait_planactivity_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_planactivity_createdonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_ait_planactivity_modifiedby")]
    public IEnumerable<ait_planactivity> lk_ait_planactivity_modifiedby
    {
      get
      {
        return this.GetRelatedEntities<ait_planactivity>(nameof (lk_ait_planactivity_modifiedby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_planactivity_modifiedby));
        this.SetRelatedEntities<ait_planactivity>(nameof (lk_ait_planactivity_modifiedby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_planactivity_modifiedby));
      }
    }

    [RelationshipSchemaName("lk_ait_planactivity_modifiedonbehalfby")]
    public IEnumerable<ait_planactivity> lk_ait_planactivity_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<ait_planactivity>(nameof (lk_ait_planactivity_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_planactivity_modifiedonbehalfby));
        this.SetRelatedEntities<ait_planactivity>(nameof (lk_ait_planactivity_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_planactivity_modifiedonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_ait_program_createdby")]
    public IEnumerable<ait_program> lk_ait_program_createdby
    {
      get
      {
        return this.GetRelatedEntities<ait_program>(nameof (lk_ait_program_createdby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_program_createdby));
        this.SetRelatedEntities<ait_program>(nameof (lk_ait_program_createdby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_program_createdby));
      }
    }

    [RelationshipSchemaName("lk_ait_program_createdonbehalfby")]
    public IEnumerable<ait_program> lk_ait_program_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<ait_program>(nameof (lk_ait_program_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_program_createdonbehalfby));
        this.SetRelatedEntities<ait_program>(nameof (lk_ait_program_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_program_createdonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_ait_program_modifiedby")]
    public IEnumerable<ait_program> lk_ait_program_modifiedby
    {
      get
      {
        return this.GetRelatedEntities<ait_program>(nameof (lk_ait_program_modifiedby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_program_modifiedby));
        this.SetRelatedEntities<ait_program>(nameof (lk_ait_program_modifiedby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_program_modifiedby));
      }
    }

    [RelationshipSchemaName("lk_ait_program_modifiedonbehalfby")]
    public IEnumerable<ait_program> lk_ait_program_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<ait_program>(nameof (lk_ait_program_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_program_modifiedonbehalfby));
        this.SetRelatedEntities<ait_program>(nameof (lk_ait_program_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_program_modifiedonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_ait_referral_createdby")]
    public IEnumerable<ait_referral> lk_ait_referral_createdby
    {
      get
      {
        return this.GetRelatedEntities<ait_referral>(nameof (lk_ait_referral_createdby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_referral_createdby));
        this.SetRelatedEntities<ait_referral>(nameof (lk_ait_referral_createdby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_referral_createdby));
      }
    }

    [RelationshipSchemaName("lk_ait_referral_createdonbehalfby")]
    public IEnumerable<ait_referral> lk_ait_referral_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<ait_referral>(nameof (lk_ait_referral_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_referral_createdonbehalfby));
        this.SetRelatedEntities<ait_referral>(nameof (lk_ait_referral_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_referral_createdonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_ait_referral_modifiedby")]
    public IEnumerable<ait_referral> lk_ait_referral_modifiedby
    {
      get
      {
        return this.GetRelatedEntities<ait_referral>(nameof (lk_ait_referral_modifiedby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_referral_modifiedby));
        this.SetRelatedEntities<ait_referral>(nameof (lk_ait_referral_modifiedby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_referral_modifiedby));
      }
    }

    [RelationshipSchemaName("lk_ait_referral_modifiedonbehalfby")]
    public IEnumerable<ait_referral> lk_ait_referral_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<ait_referral>(nameof (lk_ait_referral_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_referral_modifiedonbehalfby));
        this.SetRelatedEntities<ait_referral>(nameof (lk_ait_referral_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_referral_modifiedonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_ait_servicerequest_createdby")]
    public IEnumerable<ait_servicerequest> lk_ait_servicerequest_createdby
    {
      get
      {
        return this.GetRelatedEntities<ait_servicerequest>(nameof (lk_ait_servicerequest_createdby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_servicerequest_createdby));
        this.SetRelatedEntities<ait_servicerequest>(nameof (lk_ait_servicerequest_createdby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_servicerequest_createdby));
      }
    }

    [RelationshipSchemaName("lk_ait_servicerequest_createdonbehalfby")]
    public IEnumerable<ait_servicerequest> lk_ait_servicerequest_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<ait_servicerequest>(nameof (lk_ait_servicerequest_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_servicerequest_createdonbehalfby));
        this.SetRelatedEntities<ait_servicerequest>(nameof (lk_ait_servicerequest_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_servicerequest_createdonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_ait_servicerequest_modifiedby")]
    public IEnumerable<ait_servicerequest> lk_ait_servicerequest_modifiedby
    {
      get
      {
        return this.GetRelatedEntities<ait_servicerequest>(nameof (lk_ait_servicerequest_modifiedby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_servicerequest_modifiedby));
        this.SetRelatedEntities<ait_servicerequest>(nameof (lk_ait_servicerequest_modifiedby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_servicerequest_modifiedby));
      }
    }

    [RelationshipSchemaName("lk_ait_servicerequest_modifiedonbehalfby")]
    public IEnumerable<ait_servicerequest> lk_ait_servicerequest_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<ait_servicerequest>(nameof (lk_ait_servicerequest_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_servicerequest_modifiedonbehalfby));
        this.SetRelatedEntities<ait_servicerequest>(nameof (lk_ait_servicerequest_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_servicerequest_modifiedonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_ait_tribe_createdby")]
    public IEnumerable<ait_tribe> lk_ait_tribe_createdby
    {
      get => this.GetRelatedEntities<ait_tribe>(nameof (lk_ait_tribe_createdby), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_tribe_createdby));
        this.SetRelatedEntities<ait_tribe>(nameof (lk_ait_tribe_createdby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_tribe_createdby));
      }
    }

    [RelationshipSchemaName("lk_ait_tribe_createdonbehalfby")]
    public IEnumerable<ait_tribe> lk_ait_tribe_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<ait_tribe>(nameof (lk_ait_tribe_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_tribe_createdonbehalfby));
        this.SetRelatedEntities<ait_tribe>(nameof (lk_ait_tribe_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_tribe_createdonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_ait_tribe_modifiedby")]
    public IEnumerable<ait_tribe> lk_ait_tribe_modifiedby
    {
      get
      {
        return this.GetRelatedEntities<ait_tribe>(nameof (lk_ait_tribe_modifiedby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_tribe_modifiedby));
        this.SetRelatedEntities<ait_tribe>(nameof (lk_ait_tribe_modifiedby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_tribe_modifiedby));
      }
    }

    [RelationshipSchemaName("lk_ait_tribe_modifiedonbehalfby")]
    public IEnumerable<ait_tribe> lk_ait_tribe_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<ait_tribe>(nameof (lk_ait_tribe_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_tribe_modifiedonbehalfby));
        this.SetRelatedEntities<ait_tribe>(nameof (lk_ait_tribe_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_tribe_modifiedonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_appointment_createdby")]
    public IEnumerable<Appointment> lk_appointment_createdby
    {
      get
      {
        return this.GetRelatedEntities<Appointment>(nameof (lk_appointment_createdby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_appointment_createdby));
        this.SetRelatedEntities<Appointment>(nameof (lk_appointment_createdby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_appointment_createdby));
      }
    }

    [RelationshipSchemaName("lk_appointment_createdonbehalfby")]
    public IEnumerable<Appointment> lk_appointment_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<Appointment>(nameof (lk_appointment_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_appointment_createdonbehalfby));
        this.SetRelatedEntities<Appointment>(nameof (lk_appointment_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_appointment_createdonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_appointment_modifiedby")]
    public IEnumerable<Appointment> lk_appointment_modifiedby
    {
      get
      {
        return this.GetRelatedEntities<Appointment>(nameof (lk_appointment_modifiedby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_appointment_modifiedby));
        this.SetRelatedEntities<Appointment>(nameof (lk_appointment_modifiedby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_appointment_modifiedby));
      }
    }

    [RelationshipSchemaName("lk_appointment_modifiedonbehalfby")]
    public IEnumerable<Appointment> lk_appointment_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<Appointment>(nameof (lk_appointment_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_appointment_modifiedonbehalfby));
        this.SetRelatedEntities<Appointment>(nameof (lk_appointment_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_appointment_modifiedonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_businessunit_createdonbehalfby")]
    public IEnumerable<BusinessUnit> lk_businessunit_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<BusinessUnit>(nameof (lk_businessunit_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_businessunit_createdonbehalfby));
        this.SetRelatedEntities<BusinessUnit>(nameof (lk_businessunit_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_businessunit_createdonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_businessunit_modifiedonbehalfby")]
    public IEnumerable<BusinessUnit> lk_businessunit_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<BusinessUnit>(nameof (lk_businessunit_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_businessunit_modifiedonbehalfby));
        this.SetRelatedEntities<BusinessUnit>(nameof (lk_businessunit_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_businessunit_modifiedonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_businessunitbase_createdby")]
    public IEnumerable<BusinessUnit> lk_businessunitbase_createdby
    {
      get
      {
        return this.GetRelatedEntities<BusinessUnit>(nameof (lk_businessunitbase_createdby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_businessunitbase_createdby));
        this.SetRelatedEntities<BusinessUnit>(nameof (lk_businessunitbase_createdby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_businessunitbase_createdby));
      }
    }

    [RelationshipSchemaName("lk_businessunitbase_modifiedby")]
    public IEnumerable<BusinessUnit> lk_businessunitbase_modifiedby
    {
      get
      {
        return this.GetRelatedEntities<BusinessUnit>(nameof (lk_businessunitbase_modifiedby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_businessunitbase_modifiedby));
        this.SetRelatedEntities<BusinessUnit>(nameof (lk_businessunitbase_modifiedby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_businessunitbase_modifiedby));
      }
    }

    [RelationshipSchemaName("lk_connectionbase_createdonbehalfby")]
    public IEnumerable<Connection> lk_connectionbase_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<Connection>(nameof (lk_connectionbase_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_connectionbase_createdonbehalfby));
        this.SetRelatedEntities<Connection>(nameof (lk_connectionbase_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_connectionbase_createdonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_connectionbase_modifiedonbehalfby")]
    public IEnumerable<Connection> lk_connectionbase_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<Connection>(nameof (lk_connectionbase_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_connectionbase_modifiedonbehalfby));
        this.SetRelatedEntities<Connection>(nameof (lk_connectionbase_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_connectionbase_modifiedonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_connectionrolebase_createdonbehalfby")]
    public IEnumerable<ConnectionRole> lk_connectionrolebase_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<ConnectionRole>(nameof (lk_connectionrolebase_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_connectionrolebase_createdonbehalfby));
        this.SetRelatedEntities<ConnectionRole>(nameof (lk_connectionrolebase_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_connectionrolebase_createdonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_connectionrolebase_modifiedonbehalfby")]
    public IEnumerable<ConnectionRole> lk_connectionrolebase_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<ConnectionRole>(nameof (lk_connectionrolebase_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_connectionrolebase_modifiedonbehalfby));
        this.SetRelatedEntities<ConnectionRole>(nameof (lk_connectionrolebase_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_connectionrolebase_modifiedonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_contact_createdonbehalfby")]
    public IEnumerable<Contact> lk_contact_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<Contact>(nameof (lk_contact_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_contact_createdonbehalfby));
        this.SetRelatedEntities<Contact>(nameof (lk_contact_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_contact_createdonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_contact_modifiedonbehalfby")]
    public IEnumerable<Contact> lk_contact_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<Contact>(nameof (lk_contact_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_contact_modifiedonbehalfby));
        this.SetRelatedEntities<Contact>(nameof (lk_contact_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_contact_modifiedonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_contactbase_createdby")]
    public IEnumerable<Contact> lk_contactbase_createdby
    {
      get => this.GetRelatedEntities<Contact>(nameof (lk_contactbase_createdby), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (lk_contactbase_createdby));
        this.SetRelatedEntities<Contact>(nameof (lk_contactbase_createdby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_contactbase_createdby));
      }
    }

    [RelationshipSchemaName("lk_contactbase_modifiedby")]
    public IEnumerable<Contact> lk_contactbase_modifiedby
    {
      get
      {
        return this.GetRelatedEntities<Contact>(nameof (lk_contactbase_modifiedby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_contactbase_modifiedby));
        this.SetRelatedEntities<Contact>(nameof (lk_contactbase_modifiedby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_contactbase_modifiedby));
      }
    }

    [RelationshipSchemaName("lk_email_createdby")]
    public IEnumerable<Email> lk_email_createdby
    {
      get => this.GetRelatedEntities<Email>(nameof (lk_email_createdby), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (lk_email_createdby));
        this.SetRelatedEntities<Email>(nameof (lk_email_createdby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_email_createdby));
      }
    }

    [RelationshipSchemaName("lk_email_createdonbehalfby")]
    public IEnumerable<Email> lk_email_createdonbehalfby
    {
      get => this.GetRelatedEntities<Email>(nameof (lk_email_createdonbehalfby), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (lk_email_createdonbehalfby));
        this.SetRelatedEntities<Email>(nameof (lk_email_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_email_createdonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_email_modifiedby")]
    public IEnumerable<Email> lk_email_modifiedby
    {
      get => this.GetRelatedEntities<Email>(nameof (lk_email_modifiedby), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (lk_email_modifiedby));
        this.SetRelatedEntities<Email>(nameof (lk_email_modifiedby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_email_modifiedby));
      }
    }

    [RelationshipSchemaName("lk_email_modifiedonbehalfby")]
    public IEnumerable<Email> lk_email_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<Email>(nameof (lk_email_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_email_modifiedonbehalfby));
        this.SetRelatedEntities<Email>(nameof (lk_email_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_email_modifiedonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_organization_createdonbehalfby")]
    public IEnumerable<Organization> lk_organization_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<Organization>(nameof (lk_organization_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_organization_createdonbehalfby));
        this.SetRelatedEntities<Organization>(nameof (lk_organization_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_organization_createdonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_organization_modifiedonbehalfby")]
    public IEnumerable<Organization> lk_organization_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<Organization>(nameof (lk_organization_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_organization_modifiedonbehalfby));
        this.SetRelatedEntities<Organization>(nameof (lk_organization_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_organization_modifiedonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_organizationbase_createdby")]
    public IEnumerable<Organization> lk_organizationbase_createdby
    {
      get
      {
        return this.GetRelatedEntities<Organization>(nameof (lk_organizationbase_createdby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_organizationbase_createdby));
        this.SetRelatedEntities<Organization>(nameof (lk_organizationbase_createdby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_organizationbase_createdby));
      }
    }

    [RelationshipSchemaName("lk_organizationbase_modifiedby")]
    public IEnumerable<Organization> lk_organizationbase_modifiedby
    {
      get
      {
        return this.GetRelatedEntities<Organization>(nameof (lk_organizationbase_modifiedby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_organizationbase_modifiedby));
        this.SetRelatedEntities<Organization>(nameof (lk_organizationbase_modifiedby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_organizationbase_modifiedby));
      }
    }

    [RelationshipSchemaName("lk_phonecall_createdby")]
    public IEnumerable<PhoneCall> lk_phonecall_createdby
    {
      get => this.GetRelatedEntities<PhoneCall>(nameof (lk_phonecall_createdby), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (lk_phonecall_createdby));
        this.SetRelatedEntities<PhoneCall>(nameof (lk_phonecall_createdby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_phonecall_createdby));
      }
    }

    [RelationshipSchemaName("lk_phonecall_createdonbehalfby")]
    public IEnumerable<PhoneCall> lk_phonecall_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<PhoneCall>(nameof (lk_phonecall_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_phonecall_createdonbehalfby));
        this.SetRelatedEntities<PhoneCall>(nameof (lk_phonecall_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_phonecall_createdonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_phonecall_modifiedby")]
    public IEnumerable<PhoneCall> lk_phonecall_modifiedby
    {
      get
      {
        return this.GetRelatedEntities<PhoneCall>(nameof (lk_phonecall_modifiedby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_phonecall_modifiedby));
        this.SetRelatedEntities<PhoneCall>(nameof (lk_phonecall_modifiedby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_phonecall_modifiedby));
      }
    }

    [RelationshipSchemaName("lk_phonecall_modifiedonbehalfby")]
    public IEnumerable<PhoneCall> lk_phonecall_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<PhoneCall>(nameof (lk_phonecall_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_phonecall_modifiedonbehalfby));
        this.SetRelatedEntities<PhoneCall>(nameof (lk_phonecall_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_phonecall_modifiedonbehalfby));
      }
    }

    [RelationshipSchemaName]
    public IEnumerable<SystemUser> Referencedlk_systemuser_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<SystemUser>("lk_systemuser_createdonbehalfby", new EntityRole?((EntityRole) 1));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencedlk_systemuser_createdonbehalfby));
        this.SetRelatedEntities<SystemUser>("lk_systemuser_createdonbehalfby", new EntityRole?((EntityRole) 1), value);
        this.OnPropertyChanged(nameof (Referencedlk_systemuser_createdonbehalfby));
      }
    }

    [RelationshipSchemaName]
    public IEnumerable<SystemUser> Referencedlk_systemuser_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<SystemUser>("lk_systemuser_modifiedonbehalfby", new EntityRole?((EntityRole) 1));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencedlk_systemuser_modifiedonbehalfby));
        this.SetRelatedEntities<SystemUser>("lk_systemuser_modifiedonbehalfby", new EntityRole?((EntityRole) 1), value);
        this.OnPropertyChanged(nameof (Referencedlk_systemuser_modifiedonbehalfby));
      }
    }

    [RelationshipSchemaName]
    public IEnumerable<SystemUser> Referencedlk_systemuserbase_createdby
    {
      get
      {
        return this.GetRelatedEntities<SystemUser>("lk_systemuserbase_createdby", new EntityRole?((EntityRole) 1));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencedlk_systemuserbase_createdby));
        this.SetRelatedEntities<SystemUser>("lk_systemuserbase_createdby", new EntityRole?((EntityRole) 1), value);
        this.OnPropertyChanged(nameof (Referencedlk_systemuserbase_createdby));
      }
    }

    [RelationshipSchemaName]
    public IEnumerable<SystemUser> Referencedlk_systemuserbase_modifiedby
    {
      get
      {
        return this.GetRelatedEntities<SystemUser>("lk_systemuserbase_modifiedby", new EntityRole?((EntityRole) 1));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencedlk_systemuserbase_modifiedby));
        this.SetRelatedEntities<SystemUser>("lk_systemuserbase_modifiedby", new EntityRole?((EntityRole) 1), value);
        this.OnPropertyChanged(nameof (Referencedlk_systemuserbase_modifiedby));
      }
    }

    [RelationshipSchemaName("lk_task_createdby")]
    public IEnumerable<Task> lk_task_createdby
    {
      get => this.GetRelatedEntities<Task>(nameof (lk_task_createdby), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (lk_task_createdby));
        this.SetRelatedEntities<Task>(nameof (lk_task_createdby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_task_createdby));
      }
    }

    [RelationshipSchemaName("lk_task_createdonbehalfby")]
    public IEnumerable<Task> lk_task_createdonbehalfby
    {
      get => this.GetRelatedEntities<Task>(nameof (lk_task_createdonbehalfby), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (lk_task_createdonbehalfby));
        this.SetRelatedEntities<Task>(nameof (lk_task_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_task_createdonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_task_modifiedby")]
    public IEnumerable<Task> lk_task_modifiedby
    {
      get => this.GetRelatedEntities<Task>(nameof (lk_task_modifiedby), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (lk_task_modifiedby));
        this.SetRelatedEntities<Task>(nameof (lk_task_modifiedby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_task_modifiedby));
      }
    }

    [RelationshipSchemaName("lk_task_modifiedonbehalfby")]
    public IEnumerable<Task> lk_task_modifiedonbehalfby
    {
      get => this.GetRelatedEntities<Task>(nameof (lk_task_modifiedonbehalfby), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (lk_task_modifiedonbehalfby));
        this.SetRelatedEntities<Task>(nameof (lk_task_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_task_modifiedonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_team_createdonbehalfby")]
    public IEnumerable<Team> lk_team_createdonbehalfby
    {
      get => this.GetRelatedEntities<Team>(nameof (lk_team_createdonbehalfby), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (lk_team_createdonbehalfby));
        this.SetRelatedEntities<Team>(nameof (lk_team_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_team_createdonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_team_modifiedonbehalfby")]
    public IEnumerable<Team> lk_team_modifiedonbehalfby
    {
      get => this.GetRelatedEntities<Team>(nameof (lk_team_modifiedonbehalfby), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (lk_team_modifiedonbehalfby));
        this.SetRelatedEntities<Team>(nameof (lk_team_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_team_modifiedonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_teambase_administratorid")]
    public IEnumerable<Team> lk_teambase_administratorid
    {
      get => this.GetRelatedEntities<Team>(nameof (lk_teambase_administratorid), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (lk_teambase_administratorid));
        this.SetRelatedEntities<Team>(nameof (lk_teambase_administratorid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_teambase_administratorid));
      }
    }

    [RelationshipSchemaName("lk_teambase_createdby")]
    public IEnumerable<Team> lk_teambase_createdby
    {
      get => this.GetRelatedEntities<Team>(nameof (lk_teambase_createdby), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (lk_teambase_createdby));
        this.SetRelatedEntities<Team>(nameof (lk_teambase_createdby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_teambase_createdby));
      }
    }

    [RelationshipSchemaName("lk_teambase_modifiedby")]
    public IEnumerable<Team> lk_teambase_modifiedby
    {
      get => this.GetRelatedEntities<Team>(nameof (lk_teambase_modifiedby), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (lk_teambase_modifiedby));
        this.SetRelatedEntities<Team>(nameof (lk_teambase_modifiedby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_teambase_modifiedby));
      }
    }

    [RelationshipSchemaName("lk_usersettings_createdonbehalfby")]
    public IEnumerable<UserSettings> lk_usersettings_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<UserSettings>(nameof (lk_usersettings_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_usersettings_createdonbehalfby));
        this.SetRelatedEntities<UserSettings>(nameof (lk_usersettings_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_usersettings_createdonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_usersettings_modifiedonbehalfby")]
    public IEnumerable<UserSettings> lk_usersettings_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntities<UserSettings>(nameof (lk_usersettings_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_usersettings_modifiedonbehalfby));
        this.SetRelatedEntities<UserSettings>(nameof (lk_usersettings_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_usersettings_modifiedonbehalfby));
      }
    }

    [RelationshipSchemaName("lk_usersettingsbase_createdby")]
    public IEnumerable<UserSettings> lk_usersettingsbase_createdby
    {
      get
      {
        return this.GetRelatedEntities<UserSettings>(nameof (lk_usersettingsbase_createdby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_usersettingsbase_createdby));
        this.SetRelatedEntities<UserSettings>(nameof (lk_usersettingsbase_createdby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_usersettingsbase_createdby));
      }
    }

    [RelationshipSchemaName("lk_usersettingsbase_modifiedby")]
    public IEnumerable<UserSettings> lk_usersettingsbase_modifiedby
    {
      get
      {
        return this.GetRelatedEntities<UserSettings>(nameof (lk_usersettingsbase_modifiedby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_usersettingsbase_modifiedby));
        this.SetRelatedEntities<UserSettings>(nameof (lk_usersettingsbase_modifiedby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_usersettingsbase_modifiedby));
      }
    }

    [RelationshipSchemaName("modifiedby_connection")]
    public IEnumerable<Connection> modifiedby_connection
    {
      get => this.GetRelatedEntities<Connection>(nameof (modifiedby_connection), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (modifiedby_connection));
        this.SetRelatedEntities<Connection>(nameof (modifiedby_connection), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (modifiedby_connection));
      }
    }

    [RelationshipSchemaName("modifiedby_connection_role")]
    public IEnumerable<ConnectionRole> modifiedby_connection_role
    {
      get
      {
        return this.GetRelatedEntities<ConnectionRole>(nameof (modifiedby_connection_role), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (modifiedby_connection_role));
        this.SetRelatedEntities<ConnectionRole>(nameof (modifiedby_connection_role), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (modifiedby_connection_role));
      }
    }

    [RelationshipSchemaName("system_user_accounts")]
    public IEnumerable<Account> system_user_accounts
    {
      get => this.GetRelatedEntities<Account>(nameof (system_user_accounts), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (system_user_accounts));
        this.SetRelatedEntities<Account>(nameof (system_user_accounts), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (system_user_accounts));
      }
    }

    [RelationshipSchemaName("system_user_contacts")]
    public IEnumerable<Contact> system_user_contacts
    {
      get => this.GetRelatedEntities<Contact>(nameof (system_user_contacts), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (system_user_contacts));
        this.SetRelatedEntities<Contact>(nameof (system_user_contacts), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (system_user_contacts));
      }
    }

    [RelationshipSchemaName("systemuser_connections1")]
    public IEnumerable<Connection> systemuser_connections1
    {
      get
      {
        return this.GetRelatedEntities<Connection>(nameof (systemuser_connections1), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (systemuser_connections1));
        this.SetRelatedEntities<Connection>(nameof (systemuser_connections1), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (systemuser_connections1));
      }
    }

    [RelationshipSchemaName("systemuser_connections2")]
    public IEnumerable<Connection> systemuser_connections2
    {
      get
      {
        return this.GetRelatedEntities<Connection>(nameof (systemuser_connections2), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (systemuser_connections2));
        this.SetRelatedEntities<Connection>(nameof (systemuser_connections2), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (systemuser_connections2));
      }
    }

    [RelationshipSchemaName("SystemUser_Email_EmailSender")]
    public IEnumerable<Email> SystemUser_Email_EmailSender
    {
      get
      {
        return this.GetRelatedEntities<Email>(nameof (SystemUser_Email_EmailSender), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SystemUser_Email_EmailSender));
        this.SetRelatedEntities<Email>(nameof (SystemUser_Email_EmailSender), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SystemUser_Email_EmailSender));
      }
    }

    [RelationshipSchemaName("user_accounts")]
    public IEnumerable<Account> user_accounts
    {
      get => this.GetRelatedEntities<Account>(nameof (user_accounts), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (user_accounts));
        this.SetRelatedEntities<Account>(nameof (user_accounts), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (user_accounts));
      }
    }

    [RelationshipSchemaName("user_ait_assessment")]
    public IEnumerable<ait_assessment> user_ait_assessment
    {
      get
      {
        return this.GetRelatedEntities<ait_assessment>(nameof (user_ait_assessment), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (user_ait_assessment));
        this.SetRelatedEntities<ait_assessment>(nameof (user_ait_assessment), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (user_ait_assessment));
      }
    }

    [RelationshipSchemaName("user_ait_case")]
    public IEnumerable<ait_case> user_ait_case
    {
      get => this.GetRelatedEntities<ait_case>(nameof (user_ait_case), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (user_ait_case));
        this.SetRelatedEntities<ait_case>(nameof (user_ait_case), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (user_ait_case));
      }
    }

    [RelationshipSchemaName("user_ait_casenotefamilywellness")]
    public IEnumerable<ait_casenotefamilywellness> user_ait_casenotefamilywellness
    {
      get
      {
        return this.GetRelatedEntities<ait_casenotefamilywellness>(nameof (user_ait_casenotefamilywellness), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (user_ait_casenotefamilywellness));
        this.SetRelatedEntities<ait_casenotefamilywellness>(nameof (user_ait_casenotefamilywellness), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (user_ait_casenotefamilywellness));
      }
    }

    [RelationshipSchemaName("user_ait_caseplan")]
    public IEnumerable<ait_caseplan> user_ait_caseplan
    {
      get => this.GetRelatedEntities<ait_caseplan>(nameof (user_ait_caseplan), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (user_ait_caseplan));
        this.SetRelatedEntities<ait_caseplan>(nameof (user_ait_caseplan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (user_ait_caseplan));
      }
    }

    [RelationshipSchemaName("user_ait_clientprofile")]
    public IEnumerable<ait_clientprofile> user_ait_clientprofile
    {
      get
      {
        return this.GetRelatedEntities<ait_clientprofile>(nameof (user_ait_clientprofile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (user_ait_clientprofile));
        this.SetRelatedEntities<ait_clientprofile>(nameof (user_ait_clientprofile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (user_ait_clientprofile));
      }
    }

    [RelationshipSchemaName("user_ait_familygroup")]
    public IEnumerable<ait_familygroup> user_ait_familygroup
    {
      get
      {
        return this.GetRelatedEntities<ait_familygroup>(nameof (user_ait_familygroup), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (user_ait_familygroup));
        this.SetRelatedEntities<ait_familygroup>(nameof (user_ait_familygroup), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (user_ait_familygroup));
      }
    }

    [RelationshipSchemaName("user_ait_goal")]
    public IEnumerable<ait_goal> user_ait_goal
    {
      get => this.GetRelatedEntities<ait_goal>(nameof (user_ait_goal), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (user_ait_goal));
        this.SetRelatedEntities<ait_goal>(nameof (user_ait_goal), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (user_ait_goal));
      }
    }

    [RelationshipSchemaName("user_ait_groupactivity")]
    public IEnumerable<ait_groupactivity> user_ait_groupactivity
    {
      get
      {
        return this.GetRelatedEntities<ait_groupactivity>(nameof (user_ait_groupactivity), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (user_ait_groupactivity));
        this.SetRelatedEntities<ait_groupactivity>(nameof (user_ait_groupactivity), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (user_ait_groupactivity));
      }
    }

    [RelationshipSchemaName("user_ait_groupactivitymeeting")]
    public IEnumerable<ait_groupactivitymeeting> user_ait_groupactivitymeeting
    {
      get
      {
        return this.GetRelatedEntities<ait_groupactivitymeeting>(nameof (user_ait_groupactivitymeeting), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (user_ait_groupactivitymeeting));
        this.SetRelatedEntities<ait_groupactivitymeeting>(nameof (user_ait_groupactivitymeeting), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (user_ait_groupactivitymeeting));
      }
    }

    [RelationshipSchemaName("user_ait_groupactivityregistration")]
    public IEnumerable<ait_groupactivityregistration> user_ait_groupactivityregistration
    {
      get
      {
        return this.GetRelatedEntities<ait_groupactivityregistration>(nameof (user_ait_groupactivityregistration), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (user_ait_groupactivityregistration));
        this.SetRelatedEntities<ait_groupactivityregistration>(nameof (user_ait_groupactivityregistration), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (user_ait_groupactivityregistration));
      }
    }

    [RelationshipSchemaName("user_ait_incidents")]
    public IEnumerable<ait_incidents> user_ait_incidents
    {
      get => this.GetRelatedEntities<ait_incidents>(nameof (user_ait_incidents), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (user_ait_incidents));
        this.SetRelatedEntities<ait_incidents>(nameof (user_ait_incidents), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (user_ait_incidents));
      }
    }

    [RelationshipSchemaName("user_ait_meetingattendee")]
    public IEnumerable<ait_meetingattendee> user_ait_meetingattendee
    {
      get
      {
        return this.GetRelatedEntities<ait_meetingattendee>(nameof (user_ait_meetingattendee), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (user_ait_meetingattendee));
        this.SetRelatedEntities<ait_meetingattendee>(nameof (user_ait_meetingattendee), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (user_ait_meetingattendee));
      }
    }

    [RelationshipSchemaName("user_ait_payment")]
    public IEnumerable<ait_payment> user_ait_payment
    {
      get => this.GetRelatedEntities<ait_payment>(nameof (user_ait_payment), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (user_ait_payment));
        this.SetRelatedEntities<ait_payment>(nameof (user_ait_payment), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (user_ait_payment));
      }
    }

    [RelationshipSchemaName("user_ait_placement")]
    public IEnumerable<ait_placement> user_ait_placement
    {
      get => this.GetRelatedEntities<ait_placement>(nameof (user_ait_placement), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (user_ait_placement));
        this.SetRelatedEntities<ait_placement>(nameof (user_ait_placement), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (user_ait_placement));
      }
    }

    [RelationshipSchemaName("user_ait_placementlocation")]
    public IEnumerable<ait_placementlocation> user_ait_placementlocation
    {
      get
      {
        return this.GetRelatedEntities<ait_placementlocation>(nameof (user_ait_placementlocation), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (user_ait_placementlocation));
        this.SetRelatedEntities<ait_placementlocation>(nameof (user_ait_placementlocation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (user_ait_placementlocation));
      }
    }

    [RelationshipSchemaName("user_ait_planactivity")]
    public IEnumerable<ait_planactivity> user_ait_planactivity
    {
      get
      {
        return this.GetRelatedEntities<ait_planactivity>(nameof (user_ait_planactivity), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (user_ait_planactivity));
        this.SetRelatedEntities<ait_planactivity>(nameof (user_ait_planactivity), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (user_ait_planactivity));
      }
    }

    [RelationshipSchemaName("user_ait_program")]
    public IEnumerable<ait_program> user_ait_program
    {
      get => this.GetRelatedEntities<ait_program>(nameof (user_ait_program), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (user_ait_program));
        this.SetRelatedEntities<ait_program>(nameof (user_ait_program), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (user_ait_program));
      }
    }

    [RelationshipSchemaName("user_ait_referral")]
    public IEnumerable<ait_referral> user_ait_referral
    {
      get => this.GetRelatedEntities<ait_referral>(nameof (user_ait_referral), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (user_ait_referral));
        this.SetRelatedEntities<ait_referral>(nameof (user_ait_referral), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (user_ait_referral));
      }
    }

    [RelationshipSchemaName("user_ait_servicerequest")]
    public IEnumerable<ait_servicerequest> user_ait_servicerequest
    {
      get
      {
        return this.GetRelatedEntities<ait_servicerequest>(nameof (user_ait_servicerequest), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (user_ait_servicerequest));
        this.SetRelatedEntities<ait_servicerequest>(nameof (user_ait_servicerequest), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (user_ait_servicerequest));
      }
    }

    [RelationshipSchemaName("user_appointment")]
    public IEnumerable<Appointment> user_appointment
    {
      get => this.GetRelatedEntities<Appointment>(nameof (user_appointment), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (user_appointment));
        this.SetRelatedEntities<Appointment>(nameof (user_appointment), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (user_appointment));
      }
    }

    [RelationshipSchemaName("user_email")]
    public IEnumerable<Email> user_email
    {
      get => this.GetRelatedEntities<Email>(nameof (user_email), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (user_email));
        this.SetRelatedEntities<Email>(nameof (user_email), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (user_email));
      }
    }

    [RelationshipSchemaName]
    public IEnumerable<SystemUser> Referenceduser_parent_user
    {
      get
      {
        return this.GetRelatedEntities<SystemUser>("user_parent_user", new EntityRole?((EntityRole) 1));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referenceduser_parent_user));
        this.SetRelatedEntities<SystemUser>("user_parent_user", new EntityRole?((EntityRole) 1), value);
        this.OnPropertyChanged(nameof (Referenceduser_parent_user));
      }
    }

    [RelationshipSchemaName("user_phonecall")]
    public IEnumerable<PhoneCall> user_phonecall
    {
      get => this.GetRelatedEntities<PhoneCall>(nameof (user_phonecall), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (user_phonecall));
        this.SetRelatedEntities<PhoneCall>(nameof (user_phonecall), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (user_phonecall));
      }
    }

    [RelationshipSchemaName("user_settings")]
    public IEnumerable<UserSettings> user_settings
    {
      get => this.GetRelatedEntities<UserSettings>(nameof (user_settings), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (user_settings));
        this.SetRelatedEntities<UserSettings>(nameof (user_settings), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (user_settings));
      }
    }

    [RelationshipSchemaName("user_task")]
    public IEnumerable<Task> user_task
    {
      get => this.GetRelatedEntities<Task>(nameof (user_task), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (user_task));
        this.SetRelatedEntities<Task>(nameof (user_task), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (user_task));
      }
    }

    [RelationshipSchemaName("teammembership_association")]
    public IEnumerable<Team> teammembership_association
    {
      get => this.GetRelatedEntities<Team>(nameof (teammembership_association), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (teammembership_association));
        this.SetRelatedEntities<Team>(nameof (teammembership_association), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (teammembership_association));
      }
    }

    [AttributeLogicalName("businessunitid")]
    [RelationshipSchemaName("business_unit_system_users")]
    public BusinessUnit business_unit_system_users
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_system_users), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_system_users));
        this.SetRelatedEntity<BusinessUnit>(nameof (business_unit_system_users), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_system_users));
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName]
    public SystemUser Referencinglk_systemuser_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_systemuser_createdonbehalfby", new EntityRole?((EntityRole) 0));
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName]
    public SystemUser Referencinglk_systemuser_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_systemuser_modifiedonbehalfby", new EntityRole?((EntityRole) 0));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName]
    public SystemUser Referencinglk_systemuserbase_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_systemuserbase_createdby", new EntityRole?((EntityRole) 0));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName]
    public SystemUser Referencinglk_systemuserbase_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_systemuserbase_modifiedby", new EntityRole?((EntityRole) 0));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_system_users")]
    public Organization organization_system_users
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_system_users), new EntityRole?());
      }
    }

    [AttributeLogicalName("stageid")]
    [RelationshipSchemaName("processstage_systemusers")]
    public ProcessStage processstage_systemusers
    {
      get
      {
        return this.GetRelatedEntity<ProcessStage>(nameof (processstage_systemusers), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (processstage_systemusers));
        this.SetRelatedEntity<ProcessStage>(nameof (processstage_systemusers), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (processstage_systemusers));
      }
    }

    [AttributeLogicalName("parentsystemuserid")]
    [RelationshipSchemaName]
    public SystemUser Referencinguser_parent_user
    {
      get => this.GetRelatedEntity<SystemUser>("user_parent_user", new EntityRole?((EntityRole) 0));
      set
      {
        this.OnPropertyChanging(nameof (Referencinguser_parent_user));
        this.SetRelatedEntity<SystemUser>("user_parent_user", new EntityRole?((EntityRole) 0), value);
        this.OnPropertyChanged(nameof (Referencinguser_parent_user));
      }
    }
  }
}
