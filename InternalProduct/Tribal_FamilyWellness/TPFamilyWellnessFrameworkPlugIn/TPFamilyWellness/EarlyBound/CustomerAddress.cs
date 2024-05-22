// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EarlyBound.CustomerAddress
// Assembly: TPFamilyWellness.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: C0DF2365-4BFC-418D-B654-2FF4D2B8EB1A
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPFamilyWellnessFrameworkPlugIn-A0924F88-EA00-EA11-A82D-000D3A1F0599\TPFamilyWellnessFrameworkPlugIn.dll

using Microsoft.Xrm.Sdk;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.Serialization;

#nullable disable
namespace TPFamilyWellness.EarlyBound
{
  [DataContract]
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("customeraddress")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.20")]
  public class CustomerAddress : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "customeraddress";
    public const int EntityTypeCode = 1071;

    public CustomerAddress()
      : base("customeraddress")
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

    [AttributeLogicalName("addressnumber")]
    public int? AddressNumber
    {
      get => this.GetAttributeValue<int?>("addressnumber");
      set
      {
        this.OnPropertyChanging(nameof (AddressNumber));
        this.SetAttributeValue("addressnumber", (object) value);
        this.OnPropertyChanged(nameof (AddressNumber));
      }
    }

    [AttributeLogicalName("addresstypecode")]
    public OptionSetValue AddressTypeCode
    {
      get => this.GetAttributeValue<OptionSetValue>("addresstypecode");
      set
      {
        this.OnPropertyChanging(nameof (AddressTypeCode));
        this.SetAttributeValue("addresstypecode", (object) value);
        this.OnPropertyChanged(nameof (AddressTypeCode));
      }
    }

    [AttributeLogicalName("city")]
    public string City
    {
      get => this.GetAttributeValue<string>("city");
      set
      {
        this.OnPropertyChanging(nameof (City));
        this.SetAttributeValue("city", (object) value);
        this.OnPropertyChanged(nameof (City));
      }
    }

    [AttributeLogicalName("composite")]
    public string Composite => this.GetAttributeValue<string>("composite");

    [AttributeLogicalName("country")]
    public string Country
    {
      get => this.GetAttributeValue<string>("country");
      set
      {
        this.OnPropertyChanging(nameof (Country));
        this.SetAttributeValue("country", (object) value);
        this.OnPropertyChanged(nameof (Country));
      }
    }

    [AttributeLogicalName("county")]
    public string County
    {
      get => this.GetAttributeValue<string>("county");
      set
      {
        this.OnPropertyChanging(nameof (County));
        this.SetAttributeValue("county", (object) value);
        this.OnPropertyChanged(nameof (County));
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

    [AttributeLogicalName("customeraddressid")]
    public Guid? CustomerAddressId
    {
      get => this.GetAttributeValue<Guid?>("customeraddressid");
      set
      {
        this.OnPropertyChanging(nameof (CustomerAddressId));
        this.SetAttributeValue("customeraddressid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (CustomerAddressId));
      }
    }

    [AttributeLogicalName("customeraddressid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.CustomerAddressId = new Guid?(value);
    }

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

    [AttributeLogicalName("freighttermscode")]
    public OptionSetValue FreightTermsCode
    {
      get => this.GetAttributeValue<OptionSetValue>("freighttermscode");
      set
      {
        this.OnPropertyChanging(nameof (FreightTermsCode));
        this.SetAttributeValue("freighttermscode", (object) value);
        this.OnPropertyChanged(nameof (FreightTermsCode));
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

    [AttributeLogicalName("latitude")]
    public double? Latitude
    {
      get => this.GetAttributeValue<double?>("latitude");
      set
      {
        this.OnPropertyChanging(nameof (Latitude));
        this.SetAttributeValue("latitude", (object) value);
        this.OnPropertyChanged(nameof (Latitude));
      }
    }

    [AttributeLogicalName("line1")]
    public string Line1
    {
      get => this.GetAttributeValue<string>("line1");
      set
      {
        this.OnPropertyChanging(nameof (Line1));
        this.SetAttributeValue("line1", (object) value);
        this.OnPropertyChanged(nameof (Line1));
      }
    }

    [AttributeLogicalName("line2")]
    public string Line2
    {
      get => this.GetAttributeValue<string>("line2");
      set
      {
        this.OnPropertyChanging(nameof (Line2));
        this.SetAttributeValue("line2", (object) value);
        this.OnPropertyChanged(nameof (Line2));
      }
    }

    [AttributeLogicalName("line3")]
    public string Line3
    {
      get => this.GetAttributeValue<string>("line3");
      set
      {
        this.OnPropertyChanging(nameof (Line3));
        this.SetAttributeValue("line3", (object) value);
        this.OnPropertyChanged(nameof (Line3));
      }
    }

    [AttributeLogicalName("longitude")]
    public double? Longitude
    {
      get => this.GetAttributeValue<double?>("longitude");
      set
      {
        this.OnPropertyChanging(nameof (Longitude));
        this.SetAttributeValue("longitude", (object) value);
        this.OnPropertyChanged(nameof (Longitude));
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

    [AttributeLogicalName("objecttypecode")]
    public string ObjectTypeCode
    {
      get => this.GetAttributeValue<string>("objecttypecode");
      set
      {
        this.OnPropertyChanging(nameof (ObjectTypeCode));
        this.SetAttributeValue("objecttypecode", (object) value);
        this.OnPropertyChanged(nameof (ObjectTypeCode));
      }
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

    [AttributeLogicalName("ownerid")]
    public EntityReference OwnerId => this.GetAttributeValue<EntityReference>("ownerid");

    [AttributeLogicalName("owningbusinessunit")]
    public EntityReference OwningBusinessUnit
    {
      get => this.GetAttributeValue<EntityReference>("owningbusinessunit");
    }

    [AttributeLogicalName("owninguser")]
    public EntityReference OwningUser => this.GetAttributeValue<EntityReference>("owninguser");

    [AttributeLogicalName("parentid")]
    public EntityReference ParentId
    {
      get => this.GetAttributeValue<EntityReference>("parentid");
      set
      {
        this.OnPropertyChanging(nameof (ParentId));
        this.SetAttributeValue("parentid", (object) value);
        this.OnPropertyChanged(nameof (ParentId));
      }
    }

    [AttributeLogicalName("postalcode")]
    public string PostalCode
    {
      get => this.GetAttributeValue<string>("postalcode");
      set
      {
        this.OnPropertyChanging(nameof (PostalCode));
        this.SetAttributeValue("postalcode", (object) value);
        this.OnPropertyChanged(nameof (PostalCode));
      }
    }

    [AttributeLogicalName("postofficebox")]
    public string PostOfficeBox
    {
      get => this.GetAttributeValue<string>("postofficebox");
      set
      {
        this.OnPropertyChanging(nameof (PostOfficeBox));
        this.SetAttributeValue("postofficebox", (object) value);
        this.OnPropertyChanged(nameof (PostOfficeBox));
      }
    }

    [AttributeLogicalName("primarycontactname")]
    public string PrimaryContactName
    {
      get => this.GetAttributeValue<string>("primarycontactname");
      set
      {
        this.OnPropertyChanging(nameof (PrimaryContactName));
        this.SetAttributeValue("primarycontactname", (object) value);
        this.OnPropertyChanged(nameof (PrimaryContactName));
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

    [AttributeLogicalName("stateorprovince")]
    public string StateOrProvince
    {
      get => this.GetAttributeValue<string>("stateorprovince");
      set
      {
        this.OnPropertyChanging(nameof (StateOrProvince));
        this.SetAttributeValue("stateorprovince", (object) value);
        this.OnPropertyChanged(nameof (StateOrProvince));
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

    [AttributeLogicalName("upszone")]
    public string UPSZone
    {
      get => this.GetAttributeValue<string>("upszone");
      set
      {
        this.OnPropertyChanging(nameof (UPSZone));
        this.SetAttributeValue("upszone", (object) value);
        this.OnPropertyChanged(nameof (UPSZone));
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

    [AttributeLogicalName("parentid")]
    [RelationshipSchemaName("Account_CustomerAddress")]
    public Account Account_CustomerAddress
    {
      get => this.GetRelatedEntity<Account>(nameof (Account_CustomerAddress), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Account_CustomerAddress));
        this.SetRelatedEntity<Account>(nameof (Account_CustomerAddress), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Account_CustomerAddress));
      }
    }

    [AttributeLogicalName("parentid")]
    [RelationshipSchemaName("Contact_CustomerAddress")]
    public Contact Contact_CustomerAddress
    {
      get => this.GetRelatedEntity<Contact>(nameof (Contact_CustomerAddress), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Contact_CustomerAddress));
        this.SetRelatedEntity<Contact>(nameof (Contact_CustomerAddress), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Contact_CustomerAddress));
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_customeraddress_createdonbehalfby")]
    public SystemUser lk_customeraddress_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_customeraddress_createdonbehalfby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_customeraddress_modifiedonbehalfby")]
    public SystemUser lk_customeraddress_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_customeraddress_modifiedonbehalfby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_customeraddressbase_createdby")]
    public SystemUser lk_customeraddressbase_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_customeraddressbase_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_customeraddressbase_modifiedby")]
    public SystemUser lk_customeraddressbase_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_customeraddressbase_modifiedby), new EntityRole?());
      }
    }
  }
}
