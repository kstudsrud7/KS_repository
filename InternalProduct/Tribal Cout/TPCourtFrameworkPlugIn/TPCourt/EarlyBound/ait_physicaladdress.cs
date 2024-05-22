// Decompiled with JetBrains decompiler
// Type: TPCourt.EarlyBound.ait_physicaladdress
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
  [EntityLogicalName("ait_physicaladdress")]
  [GeneratedCode("XrmToolkit", "4.0")]
  [DataContract(Name = "Entity", Namespace = "http://schemas.microsoft.com/xrm/2011/Contracts")]
  public class ait_physicaladdress : BaseProxyClass
  {
    public const string LogicalName = "ait_physicaladdress";
    public const int ObjectTypeCode = 10134;
    public const string PrimaryIdAttribute = "ait_physicaladdressid";
    public const string PrimaryNameAttribute = "ait_name";
    private static Dictionary<string, BaseProxyClass.eTextOptions> _textOptions;
    private static Dictionary<string, BaseProxyClass.eNumberOptions> _numberOptions;
    private static Dictionary<string, string> _errorStrings;

    static ait_physicaladdress()
    {
      BaseProxyClass.RegisterProxyType(typeof (ait_physicaladdress), nameof (ait_physicaladdress));
      ait_physicaladdress._textOptions = new Dictionary<string, BaseProxyClass.eTextOptions>();
      ait_physicaladdress._numberOptions = new Dictionary<string, BaseProxyClass.eNumberOptions>();
      ait_physicaladdress._errorStrings = new Dictionary<string, string>();
      ait_physicaladdress.TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
      ait_physicaladdress.NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
    }

    public ait_physicaladdress()
      : base(new Entity(nameof (ait_physicaladdress)))
    {
    }

    public ait_physicaladdress(Entity original)
      : base(original)
    {
    }

    public static string GetLogicalName() => BaseProxyClass.GetLogicalName<ait_physicaladdress>();

    public static BaseProxyClass.eTextOptions TextOptions { get; set; }

    public static void SetTextOptions(
      string logicalName,
      BaseProxyClass.eTextOptions options,
      string errorString = null)
    {
      if (ait_physicaladdress._textOptions.ContainsKey(logicalName))
        ait_physicaladdress._textOptions[logicalName] = options;
      else
        ait_physicaladdress._textOptions.Add(logicalName, options);
      if (!string.IsNullOrEmpty(errorString))
      {
        if (ait_physicaladdress._errorStrings.ContainsKey(logicalName))
          ait_physicaladdress._errorStrings[logicalName] = errorString;
        else
          ait_physicaladdress._errorStrings.Add(logicalName, errorString);
      }
      else
      {
        if (!ait_physicaladdress._errorStrings.ContainsKey(logicalName))
          return;
        ait_physicaladdress._errorStrings.Remove(logicalName);
      }
    }

    protected override BaseProxyClass.eTextOptions GetTextOptions(string logicalName)
    {
      return ait_physicaladdress._textOptions.ContainsKey(logicalName) ? ait_physicaladdress._textOptions[logicalName] : ait_physicaladdress.TextOptions;
    }

    public static BaseProxyClass.eNumberOptions NumberOptions { get; set; }

    public static void SetNumberOptions(
      string logicalName,
      BaseProxyClass.eNumberOptions options,
      string errorString = null)
    {
      if (ait_physicaladdress._numberOptions.ContainsKey(logicalName))
        ait_physicaladdress._numberOptions[logicalName] = options;
      else
        ait_physicaladdress._numberOptions.Add(logicalName, options);
      if (!string.IsNullOrEmpty(errorString))
      {
        if (ait_physicaladdress._errorStrings.ContainsKey(logicalName))
          ait_physicaladdress._errorStrings[logicalName] = errorString;
        else
          ait_physicaladdress._errorStrings.Add(logicalName, errorString);
      }
      else
      {
        if (!ait_physicaladdress._errorStrings.ContainsKey(logicalName))
          return;
        ait_physicaladdress._errorStrings.Remove(logicalName);
      }
    }

    protected override BaseProxyClass.eNumberOptions GetNumberOptions(string logicalName)
    {
      return ait_physicaladdress._numberOptions.ContainsKey(logicalName) ? ait_physicaladdress._numberOptions[logicalName] : ait_physicaladdress.NumberOptions;
    }

    protected override string GetErrorString(
      string attributeName,
      BaseProxyClass.eErrorType defaultErrorType)
    {
      return ait_physicaladdress._errorStrings.ContainsKey(attributeName) ? ait_physicaladdress._errorStrings[attributeName] : (defaultErrorType == BaseProxyClass.eErrorType.Text ? ait_physicaladdress.TextError : ait_physicaladdress.NumberError);
    }

    public static string TextError { get; set; }

    public static string NumberError { get; set; }

    [AttributeLogicalName("ait_address")]
    public string ait_address
    {
      get => this.GetPropertyValue<string>(nameof (ait_address));
      set => this.SetPropertyValue(nameof (ait_address), value, 1000, nameof (ait_address));
    }

    [AttributeLogicalName("ait_addresstype")]
    public EntityReference ait_addresstype
    {
      get => this.GetPropertyValue<EntityReference>(nameof (ait_addresstype));
      set
      {
        this.SetPropertyValue<EntityReference>(nameof (ait_addresstype), value, nameof (ait_addresstype));
      }
    }

    [AttributeLogicalName("ait_addresstypename")]
    public string ait_addresstypename
    {
      get => this.GetPropertyValue<string>(nameof (ait_addresstypename));
    }

    [AttributeLogicalName("ait_city")]
    public EntityReference ait_city
    {
      get => this.GetPropertyValue<EntityReference>(nameof (ait_city));
      set => this.SetPropertyValue<EntityReference>(nameof (ait_city), value, nameof (ait_city));
    }

    [AttributeLogicalName("ait_cityname")]
    public string ait_cityname => this.GetPropertyValue<string>(nameof (ait_cityname));

    [AttributeLogicalName("ait_company")]
    public EntityReference ait_company
    {
      get => this.GetPropertyValue<EntityReference>(nameof (ait_company));
      set
      {
        this.SetPropertyValue<EntityReference>(nameof (ait_company), value, nameof (ait_company));
      }
    }

    [AttributeLogicalName("ait_companyname")]
    public string ait_companyname => this.GetPropertyValue<string>(nameof (ait_companyname));

    [AttributeLogicalName("ait_contact")]
    public EntityReference ait_contact
    {
      get => this.GetPropertyValue<EntityReference>(nameof (ait_contact));
      set
      {
        this.SetPropertyValue<EntityReference>(nameof (ait_contact), value, nameof (ait_contact));
      }
    }

    [AttributeLogicalName("ait_contactname")]
    public string ait_contactname => this.GetPropertyValue<string>(nameof (ait_contactname));

    [AttributeLogicalName("ait_contactyominame")]
    public string ait_contactyominame
    {
      get => this.GetPropertyValue<string>(nameof (ait_contactyominame));
    }

    [AttributeLogicalName("ait_countryregion")]
    public EntityReference ait_countryregion
    {
      get => this.GetPropertyValue<EntityReference>(nameof (ait_countryregion));
      set
      {
        this.SetPropertyValue<EntityReference>(nameof (ait_countryregion), value, nameof (ait_countryregion));
      }
    }

    [AttributeLogicalName("ait_countryregionname")]
    public string ait_countryregionname
    {
      get => this.GetPropertyValue<string>(nameof (ait_countryregionname));
    }

    [AttributeLogicalName("ait_county")]
    public EntityReference ait_county
    {
      get => this.GetPropertyValue<EntityReference>(nameof (ait_county));
      set
      {
        this.SetPropertyValue<EntityReference>(nameof (ait_county), value, nameof (ait_county));
      }
    }

    [AttributeLogicalName("ait_countyname")]
    public string ait_countyname => this.GetPropertyValue<string>(nameof (ait_countyname));

    [AttributeLogicalName("ait_current")]
    public bool? ait_current
    {
      get => this.GetPropertyValue<bool?>(nameof (ait_current));
      set => this.SetPropertyValue<bool?>(nameof (ait_current), value, nameof (ait_current));
    }

    [AttributeLogicalName("ait_directions")]
    public string ait_directions
    {
      get => this.GetPropertyValue<string>(nameof (ait_directions));
      set => this.SetPropertyValue(nameof (ait_directions), value, 2000, nameof (ait_directions));
    }

    [AttributeLogicalName("ait_geographicarea")]
    public EntityReference ait_geographicarea
    {
      get => this.GetPropertyValue<EntityReference>(nameof (ait_geographicarea));
      set
      {
        this.SetPropertyValue<EntityReference>(nameof (ait_geographicarea), value, nameof (ait_geographicarea));
      }
    }

    [AttributeLogicalName("ait_geographicareaname")]
    public string ait_geographicareaname
    {
      get => this.GetPropertyValue<string>(nameof (ait_geographicareaname));
    }

    [AttributeLogicalName("ait_latitude")]
    public double? ait_latitude
    {
      get => this.GetPropertyValue<double?>(nameof (ait_latitude));
      set
      {
        this.SetPropertyValue(nameof (ait_latitude), value, -180.0, 180.0, nameof (ait_latitude));
      }
    }

    [AttributeLogicalName("ait_longitude")]
    public double? ait_longitude
    {
      get => this.GetPropertyValue<double?>(nameof (ait_longitude));
      set
      {
        this.SetPropertyValue(nameof (ait_longitude), value, -180.0, 180.0, nameof (ait_longitude));
      }
    }

    [AttributeLogicalName("ait_mailing")]
    public bool? ait_mailing
    {
      get => this.GetPropertyValue<bool?>(nameof (ait_mailing));
      set => this.SetPropertyValue<bool?>(nameof (ait_mailing), value, nameof (ait_mailing));
    }

    [AttributeLogicalName("ait_name")]
    public string ait_name
    {
      get => this.GetPropertyValue<string>(nameof (ait_name));
      set => this.SetPropertyValue(nameof (ait_name), value, 100, nameof (ait_name));
    }

    [AttributeLogicalName("ait_physicaladdressid")]
    public Guid ait_physicaladdressid
    {
      get => this.Id;
      set
      {
        this.Id = value;
        this.SetPropertyValue<Guid>(nameof (ait_physicaladdressid), value, nameof (ait_physicaladdressid));
      }
    }

    [AttributeLogicalName("ait_returned")]
    public bool? ait_returned
    {
      get => this.GetPropertyValue<bool?>(nameof (ait_returned));
      set => this.SetPropertyValue<bool?>(nameof (ait_returned), value, nameof (ait_returned));
    }

    [AttributeLogicalName("ait_school")]
    public EntityReference ait_school
    {
      get => this.GetPropertyValue<EntityReference>(nameof (ait_school));
      set
      {
        this.SetPropertyValue<EntityReference>(nameof (ait_school), value, nameof (ait_school));
      }
    }

    [AttributeLogicalName("ait_schoolname")]
    public string ait_schoolname => this.GetPropertyValue<string>(nameof (ait_schoolname));

    [AttributeLogicalName("ait_specialmailinginstructions")]
    public string ait_specialmailinginstructions
    {
      get => this.GetPropertyValue<string>(nameof (ait_specialmailinginstructions));
      set
      {
        this.SetPropertyValue(nameof (ait_specialmailinginstructions), value, 100, nameof (ait_specialmailinginstructions));
      }
    }

    [AttributeLogicalName("ait_stateprovince")]
    public EntityReference ait_stateprovince
    {
      get => this.GetPropertyValue<EntityReference>(nameof (ait_stateprovince));
      set
      {
        this.SetPropertyValue<EntityReference>(nameof (ait_stateprovince), value, nameof (ait_stateprovince));
      }
    }

    [AttributeLogicalName("ait_stateprovincename")]
    public string ait_stateprovincename
    {
      get => this.GetPropertyValue<string>(nameof (ait_stateprovincename));
    }

    [AttributeLogicalName("ait_street1")]
    public string ait_street1
    {
      get => this.GetPropertyValue<string>(nameof (ait_street1));
      set => this.SetPropertyValue(nameof (ait_street1), value, 100, nameof (ait_street1));
    }

    [AttributeLogicalName("ait_street2")]
    public string ait_street2
    {
      get => this.GetPropertyValue<string>(nameof (ait_street2));
      set => this.SetPropertyValue(nameof (ait_street2), value, 100, nameof (ait_street2));
    }

    [AttributeLogicalName("ait_street3")]
    public string ait_street3
    {
      get => this.GetPropertyValue<string>(nameof (ait_street3));
      set => this.SetPropertyValue(nameof (ait_street3), value, 100, nameof (ait_street3));
    }

    [AttributeLogicalName("ait_usedfrom")]
    public DateTime? ait_usedfrom
    {
      get => this.GetPropertyValue<DateTime?>(nameof (ait_usedfrom));
      set => this.SetPropertyValue<DateTime?>(nameof (ait_usedfrom), value, nameof (ait_usedfrom));
    }

    [AttributeLogicalName("ait_usedto")]
    public DateTime? ait_usedto
    {
      get => this.GetPropertyValue<DateTime?>(nameof (ait_usedto));
      set => this.SetPropertyValue<DateTime?>(nameof (ait_usedto), value, nameof (ait_usedto));
    }

    [AttributeLogicalName("ait_zipcode")]
    public EntityReference ait_zipcode
    {
      get => this.GetPropertyValue<EntityReference>(nameof (ait_zipcode));
      set
      {
        this.SetPropertyValue<EntityReference>(nameof (ait_zipcode), value, nameof (ait_zipcode));
      }
    }

    [AttributeLogicalName("ait_zipcodeextension")]
    public string ait_zipcodeextension
    {
      get => this.GetPropertyValue<string>(nameof (ait_zipcodeextension));
      set
      {
        this.SetPropertyValue(nameof (ait_zipcodeextension), value, 100, nameof (ait_zipcodeextension));
      }
    }

    [AttributeLogicalName("ait_zipcodename")]
    public string ait_zipcodename => this.GetPropertyValue<string>(nameof (ait_zipcodename));

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

    [AttributeLogicalName("importsequencenumber")]
    public int? importsequencenumber
    {
      get => this.GetPropertyValue<int?>(nameof (importsequencenumber));
      set
      {
        this.SetPropertyValue(nameof (importsequencenumber), value, int.MinValue, int.MaxValue, nameof (importsequencenumber));
      }
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

    [AttributeLogicalName("statecode")]
    public eAit_physicaladdress_statecode? statecode
    {
      get
      {
        return this.statecode_OptionSetValue != null ? new eAit_physicaladdress_statecode?((eAit_physicaladdress_statecode) this.statecode_OptionSetValue.Value) : new eAit_physicaladdress_statecode?();
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
    public eAit_physicaladdress_statuscode? statuscode
    {
      get
      {
        return this.statuscode_OptionSetValue != null ? new eAit_physicaladdress_statuscode?((eAit_physicaladdress_statuscode) this.statuscode_OptionSetValue.Value) : new eAit_physicaladdress_statuscode?();
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

    [AttributeLogicalName("timezoneruleversionnumber")]
    public int? timezoneruleversionnumber
    {
      get => this.GetPropertyValue<int?>(nameof (timezoneruleversionnumber));
      set
      {
        this.SetPropertyValue(nameof (timezoneruleversionnumber), value, -1, int.MaxValue, nameof (timezoneruleversionnumber));
      }
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

    public List<Entity> Getait_ait_cemetary_ait_physicaladdress(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_cemetary", "ait_address", columns);
    }

    public List<Entity> Getait_ait_cemetary_ait_physicaladdress(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_cemetary", "ait_address", columns);
    }

    public List<ait_courtprofile> Getait_ait_physicaladdress_ait_courtprofile_PhysicalAddress(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_courtprofile>(service, this.Id, "ait_courtprofile", nameof (ait_physicaladdress), columns);
    }

    public List<ait_courtprofile> Getait_ait_physicaladdress_ait_courtprofile_PhysicalAddress(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_courtprofile>(service, this.Id, "ait_courtprofile", nameof (ait_physicaladdress), columns);
    }

    public List<ait_courtprofile> Getait_physicaladdress_ait_courtprofile_MailingAddress(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_courtprofile>(service, this.Id, "ait_courtprofile", "ait_mailingaddress", columns);
    }

    public List<ait_courtprofile> Getait_physicaladdress_ait_courtprofile_MailingAddress(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_courtprofile>(service, this.Id, "ait_courtprofile", "ait_mailingaddress", columns);
    }

    public List<Entity> Getait_ait_emergencycontact_ait_physicaladdress(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_emergencycontact", "ait_address", columns);
    }

    public List<Entity> Getait_ait_emergencycontact_ait_physicaladdress(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_emergencycontact", "ait_address", columns);
    }

    public List<Entity> Getait_ait_school_ait_physicaladdress(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_school", "ait_address", columns);
    }

    public List<Entity> Getait_ait_school_ait_physicaladdress(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_school", "ait_address", columns);
    }

    public List<Entity> Getait_physicaladdress_Annotations(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "annotation", "objectid", columns);
    }

    public List<Entity> Getait_physicaladdress_Annotations(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "annotation", "objectid", columns);
    }

    public List<Entity> Getait_physicaladdress_AsyncOperations(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "asyncoperation", "regardingobjectid", columns);
    }

    public List<Entity> Getait_physicaladdress_AsyncOperations(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "asyncoperation", "regardingobjectid", columns);
    }

    public List<Entity> Getait_physicaladdress_BulkDeleteFailures(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bulkdeletefailure", "regardingobjectid", columns);
    }

    public List<Entity> Getait_physicaladdress_BulkDeleteFailures(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bulkdeletefailure", "regardingobjectid", columns);
    }

    public List<Entity> Getait_physicaladdress_DuplicateBaseRecord(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "duplicaterecord", "baserecordid", columns);
    }

    public List<Entity> Getait_physicaladdress_DuplicateBaseRecord(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "duplicaterecord", "baserecordid", columns);
    }

    public List<Entity> Getait_physicaladdress_DuplicateMatchingRecord(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "duplicaterecord", "duplicaterecordid", columns);
    }

    public List<Entity> Getait_physicaladdress_DuplicateMatchingRecord(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "duplicaterecord", "duplicaterecordid", columns);
    }

    public List<Entity> Getait_physicaladdress_MailboxTrackingFolders(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "mailboxtrackingfolder", "regardingobjectid", columns);
    }

    public List<Entity> Getait_physicaladdress_MailboxTrackingFolders(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "mailboxtrackingfolder", "regardingobjectid", columns);
    }

    public List<Entity> Getait_physicaladdress_PrincipalObjectAttributeAccesses(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "principalobjectattributeaccess", "objectid", columns);
    }

    public List<Entity> Getait_physicaladdress_PrincipalObjectAttributeAccesses(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "principalobjectattributeaccess", "objectid", columns);
    }

    public List<Entity> Getait_physicaladdress_ProcessSession(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "processsession", "regardingobjectid", columns);
    }

    public List<Entity> Getait_physicaladdress_ProcessSession(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "processsession", "regardingobjectid", columns);
    }

    public List<Entity> Getait_physicaladdress_SyncErrors(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "syncerror", "regardingobjectid", columns);
    }

    public List<Entity> Getait_physicaladdress_SyncErrors(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "syncerror", "regardingobjectid", columns);
    }

    public List<Entity> Getait_physicaladdress_UserEntityInstanceDatas(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userentityinstancedata", "objectid", columns);
    }

    public List<Entity> Getait_physicaladdress_UserEntityInstanceDatas(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userentityinstancedata", "objectid", columns);
    }

    public static class Properties
    {
      public const string ait_address = "ait_address";
      public const string ait_addresstype = "ait_addresstype";
      public const string ait_addresstypename = "ait_addresstypename";
      public const string ait_city = "ait_city";
      public const string ait_cityname = "ait_cityname";
      public const string ait_company = "ait_company";
      public const string ait_companyname = "ait_companyname";
      public const string ait_contact = "ait_contact";
      public const string ait_contactname = "ait_contactname";
      public const string ait_contactyominame = "ait_contactyominame";
      public const string ait_countryregion = "ait_countryregion";
      public const string ait_countryregionname = "ait_countryregionname";
      public const string ait_county = "ait_county";
      public const string ait_countyname = "ait_countyname";
      public const string ait_current = "ait_current";
      public const string ait_currentname = "ait_currentname";
      public const string ait_directions = "ait_directions";
      public const string ait_geographicarea = "ait_geographicarea";
      public const string ait_geographicareaname = "ait_geographicareaname";
      public const string ait_latitude = "ait_latitude";
      public const string ait_longitude = "ait_longitude";
      public const string ait_mailing = "ait_mailing";
      public const string ait_mailingname = "ait_mailingname";
      public const string ait_name = "ait_name";
      public const string ait_physicaladdressid = "ait_physicaladdressid";
      public const string ait_returned = "ait_returned";
      public const string ait_returnedname = "ait_returnedname";
      public const string ait_school = "ait_school";
      public const string ait_schoolname = "ait_schoolname";
      public const string ait_specialmailinginstructions = "ait_specialmailinginstructions";
      public const string ait_stateprovince = "ait_stateprovince";
      public const string ait_stateprovincename = "ait_stateprovincename";
      public const string ait_street1 = "ait_street1";
      public const string ait_street2 = "ait_street2";
      public const string ait_street3 = "ait_street3";
      public const string ait_usedfrom = "ait_usedfrom";
      public const string ait_usedto = "ait_usedto";
      public const string ait_zipcode = "ait_zipcode";
      public const string ait_zipcodeextension = "ait_zipcodeextension";
      public const string ait_zipcodename = "ait_zipcodename";
      public const string createdby = "createdby";
      public const string createdbyname = "createdbyname";
      public const string createdbyyominame = "createdbyyominame";
      public const string createdon = "createdon";
      public const string createdonbehalfby = "createdonbehalfby";
      public const string createdonbehalfbyname = "createdonbehalfbyname";
      public const string createdonbehalfbyyominame = "createdonbehalfbyyominame";
      public const string importsequencenumber = "importsequencenumber";
      public const string modifiedby = "modifiedby";
      public const string modifiedbyname = "modifiedbyname";
      public const string modifiedbyyominame = "modifiedbyyominame";
      public const string modifiedon = "modifiedon";
      public const string modifiedonbehalfby = "modifiedonbehalfby";
      public const string modifiedonbehalfbyname = "modifiedonbehalfbyname";
      public const string modifiedonbehalfbyyominame = "modifiedonbehalfbyyominame";
      public const string overriddencreatedon = "overriddencreatedon";
      public const string ownerid = "ownerid";
      public const string owneridname = "owneridname";
      public const string owneridtype = "owneridtype";
      public const string owneridyominame = "owneridyominame";
      public const string owningbusinessunit = "owningbusinessunit";
      public const string owningteam = "owningteam";
      public const string owninguser = "owninguser";
      public const string statecode = "statecode";
      public const string statecodename = "statecodename";
      public const string statuscode = "statuscode";
      public const string statuscodename = "statuscodename";
      public const string timezoneruleversionnumber = "timezoneruleversionnumber";
      public const string utcconversiontimezonecode = "utcconversiontimezonecode";
      public const string versionnumber = "versionnumber";
    }
  }
}
