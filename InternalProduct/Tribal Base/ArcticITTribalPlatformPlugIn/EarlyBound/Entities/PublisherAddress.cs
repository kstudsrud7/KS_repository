// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.PublisherAddress
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("publisheraddress")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class PublisherAddress : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "publisheraddress";
    public const string EntitySchemaName = "PublisherAddress";
    public const string PrimaryIdAttribute = "publisheraddressid";
    public const string PrimaryNameAttribute = "name";

    public PublisherAddress()
      : base("publisheraddress")
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
      set
      {
        this.OnPropertyChanging(nameof (CreatedOnBehalfBy));
        this.SetAttributeValue("createdonbehalfby", (object) value);
        this.OnPropertyChanged(nameof (CreatedOnBehalfBy));
      }
    }

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

    [AttributeLogicalName("publisheraddressid")]
    public Guid? PublisherAddressId
    {
      get => this.GetAttributeValue<Guid?>("publisheraddressid");
      set
      {
        this.OnPropertyChanging(nameof (PublisherAddressId));
        this.SetAttributeValue("publisheraddressid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (PublisherAddressId));
      }
    }

    [AttributeLogicalName("publisheraddressid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.PublisherAddressId = new Guid?(value);
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

    [RelationshipSchemaName("userentityinstancedata_publisheraddress")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_publisheraddress
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_publisheraddress), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_publisheraddress));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_publisheraddress), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_publisheraddress));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_publisheraddressbase_createdby")]
    public SystemUser lk_publisheraddressbase_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_publisheraddressbase_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_publisheraddressbase_createdonbehalfby")]
    public SystemUser lk_publisheraddressbase_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_publisheraddressbase_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_publisheraddressbase_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_publisheraddressbase_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_publisheraddressbase_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_publisheraddressbase_modifiedby")]
    public SystemUser lk_publisheraddressbase_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_publisheraddressbase_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_publisheraddressbase_modifiedonbehalfby")]
    public SystemUser lk_publisheraddressbase_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_publisheraddressbase_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_publisheraddressbase_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_publisheraddressbase_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_publisheraddressbase_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("parentid")]
    [RelationshipSchemaName("Publisher_PublisherAddress")]
    public Publisher Publisher_PublisherAddress
    {
      get
      {
        return this.GetRelatedEntity<Publisher>(nameof (Publisher_PublisherAddress), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Publisher_PublisherAddress));
        this.SetRelatedEntity<Publisher>(nameof (Publisher_PublisherAddress), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Publisher_PublisherAddress));
      }
    }

    public PublisherAddress(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["publisheraddressid"] = (object) base.Id;
            break;
          case "publisheraddressid":
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
