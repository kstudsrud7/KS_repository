// Decompiled with JetBrains decompiler
// Type: TPCourt.EarlyBound.ait_city
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
  [EntityLogicalName("ait_city")]
  [GeneratedCode("XrmToolkit", "4.0")]
  [DataContract(Name = "Entity", Namespace = "http://schemas.microsoft.com/xrm/2011/Contracts")]
  public class ait_city : BaseProxyClass
  {
    public const string LogicalName = "ait_city";
    public const int ObjectTypeCode = 10097;
    public const string PrimaryIdAttribute = "ait_cityid";
    public const string PrimaryNameAttribute = "ait_name";
    private static Dictionary<string, BaseProxyClass.eTextOptions> _textOptions;
    private static Dictionary<string, BaseProxyClass.eNumberOptions> _numberOptions;
    private static Dictionary<string, string> _errorStrings;

    static ait_city()
    {
      BaseProxyClass.RegisterProxyType(typeof (ait_city), nameof (ait_city));
      ait_city._textOptions = new Dictionary<string, BaseProxyClass.eTextOptions>();
      ait_city._numberOptions = new Dictionary<string, BaseProxyClass.eNumberOptions>();
      ait_city._errorStrings = new Dictionary<string, string>();
      ait_city.TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
      ait_city.NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
    }

    public ait_city()
      : base(new Entity(nameof (ait_city)))
    {
    }

    public ait_city(Entity original)
      : base(original)
    {
    }

    public static string GetLogicalName() => BaseProxyClass.GetLogicalName<ait_city>();

    public static BaseProxyClass.eTextOptions TextOptions { get; set; }

    public static void SetTextOptions(
      string logicalName,
      BaseProxyClass.eTextOptions options,
      string errorString = null)
    {
      if (ait_city._textOptions.ContainsKey(logicalName))
        ait_city._textOptions[logicalName] = options;
      else
        ait_city._textOptions.Add(logicalName, options);
      if (!string.IsNullOrEmpty(errorString))
      {
        if (ait_city._errorStrings.ContainsKey(logicalName))
          ait_city._errorStrings[logicalName] = errorString;
        else
          ait_city._errorStrings.Add(logicalName, errorString);
      }
      else
      {
        if (!ait_city._errorStrings.ContainsKey(logicalName))
          return;
        ait_city._errorStrings.Remove(logicalName);
      }
    }

    protected override BaseProxyClass.eTextOptions GetTextOptions(string logicalName)
    {
      return ait_city._textOptions.ContainsKey(logicalName) ? ait_city._textOptions[logicalName] : ait_city.TextOptions;
    }

    public static BaseProxyClass.eNumberOptions NumberOptions { get; set; }

    public static void SetNumberOptions(
      string logicalName,
      BaseProxyClass.eNumberOptions options,
      string errorString = null)
    {
      if (ait_city._numberOptions.ContainsKey(logicalName))
        ait_city._numberOptions[logicalName] = options;
      else
        ait_city._numberOptions.Add(logicalName, options);
      if (!string.IsNullOrEmpty(errorString))
      {
        if (ait_city._errorStrings.ContainsKey(logicalName))
          ait_city._errorStrings[logicalName] = errorString;
        else
          ait_city._errorStrings.Add(logicalName, errorString);
      }
      else
      {
        if (!ait_city._errorStrings.ContainsKey(logicalName))
          return;
        ait_city._errorStrings.Remove(logicalName);
      }
    }

    protected override BaseProxyClass.eNumberOptions GetNumberOptions(string logicalName)
    {
      return ait_city._numberOptions.ContainsKey(logicalName) ? ait_city._numberOptions[logicalName] : ait_city.NumberOptions;
    }

    protected override string GetErrorString(
      string attributeName,
      BaseProxyClass.eErrorType defaultErrorType)
    {
      return ait_city._errorStrings.ContainsKey(attributeName) ? ait_city._errorStrings[attributeName] : (defaultErrorType == BaseProxyClass.eErrorType.Text ? ait_city.TextError : ait_city.NumberError);
    }

    public static string TextError { get; set; }

    public static string NumberError { get; set; }

    [AttributeLogicalName("ait_cityid")]
    public Guid ait_cityid
    {
      get => this.Id;
      set
      {
        this.Id = value;
        this.SetPropertyValue<Guid>(nameof (ait_cityid), value, nameof (ait_cityid));
      }
    }

    [AttributeLogicalName("ait_citytype")]
    public eAit_citytype? ait_citytype
    {
      get
      {
        return this.ait_citytype_OptionSetValue != null ? new eAit_citytype?((eAit_citytype) this.ait_citytype_OptionSetValue.Value) : new eAit_citytype?();
      }
      set
      {
        if (value.HasValue)
          this.ait_citytype_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.ait_citytype_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("ait_citytype")]
    public OptionSetValue ait_citytype_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("ait_citytype");
      set
      {
        this.SetPropertyValue<OptionSetValue>("ait_citytype", value, nameof (ait_citytype_OptionSetValue));
      }
    }

    public string ait_citytype_Text(IOrganizationService service)
    {
      return this.ait_citytype_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "ait_citytype");
    }

    public string ait_citytype_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.ait_citytype_OptionSetValue.Value);
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

    [AttributeLogicalName("ait_description")]
    public string ait_description
    {
      get => this.GetPropertyValue<string>(nameof (ait_description));
      set => this.SetPropertyValue(nameof (ait_description), value, 250, nameof (ait_description));
    }

    [AttributeLogicalName("ait_households")]
    public int? ait_households
    {
      get => this.GetPropertyValue<int?>(nameof (ait_households));
      set
      {
        this.SetPropertyValue(nameof (ait_households), value, int.MinValue, int.MaxValue, nameof (ait_households));
      }
    }

    [AttributeLogicalName("ait_latitude")]
    public double? ait_latitude
    {
      get => this.GetPropertyValue<double?>(nameof (ait_latitude));
      set
      {
        this.SetPropertyValue(nameof (ait_latitude), value, (double) int.MinValue, 2147483648.0, nameof (ait_latitude));
      }
    }

    [AttributeLogicalName("ait_longitude")]
    public double? ait_longitude
    {
      get => this.GetPropertyValue<double?>(nameof (ait_longitude));
      set
      {
        this.SetPropertyValue(nameof (ait_longitude), value, (double) int.MinValue, 2147483648.0, nameof (ait_longitude));
      }
    }

    [AttributeLogicalName("ait_name")]
    public string ait_name
    {
      get => this.GetPropertyValue<string>(nameof (ait_name));
      set => this.SetPropertyValue(nameof (ait_name), value, 100, nameof (ait_name));
    }

    [AttributeLogicalName("ait_population")]
    public int? ait_population
    {
      get => this.GetPropertyValue<int?>(nameof (ait_population));
      set
      {
        this.SetPropertyValue(nameof (ait_population), value, int.MinValue, int.MaxValue, nameof (ait_population));
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

    [AttributeLogicalName("organizationid")]
    public EntityReference organizationid
    {
      get => this.GetPropertyValue<EntityReference>(nameof (organizationid));
    }

    [AttributeLogicalName("organizationidname")]
    public string organizationidname => this.GetPropertyValue<string>(nameof (organizationidname));

    [AttributeLogicalName("overriddencreatedon")]
    public DateTime? overriddencreatedon
    {
      get => this.GetPropertyValue<DateTime?>(nameof (overriddencreatedon));
      set
      {
        this.SetPropertyValue<DateTime?>(nameof (overriddencreatedon), value, nameof (overriddencreatedon));
      }
    }

    [AttributeLogicalName("statecode")]
    public eAit_city_statecode? statecode
    {
      get
      {
        return this.statecode_OptionSetValue != null ? new eAit_city_statecode?((eAit_city_statecode) this.statecode_OptionSetValue.Value) : new eAit_city_statecode?();
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
    public eAit_city_statuscode? statuscode
    {
      get
      {
        return this.statuscode_OptionSetValue != null ? new eAit_city_statuscode?((eAit_city_statuscode) this.statuscode_OptionSetValue.Value) : new eAit_city_statuscode?();
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

    public List<Entity> Getait_ait_birthrecord_ait_city(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_birthrecord", nameof (ait_city), columns);
    }

    public List<Entity> Getait_ait_birthrecord_ait_city(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_birthrecord", nameof (ait_city), columns);
    }

    public List<Entity> Getait_ait_city_ait_birthrecord_amendedcity(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_birthrecord", "ait_amendedcity", columns);
    }

    public List<Entity> Getait_ait_city_ait_birthrecord_amendedcity(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_birthrecord", "ait_amendedcity", columns);
    }

    public List<Entity> Getait_ait_city_ait_deathrecord_deathcity(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_deathrecord", "ait_deathcity", columns);
    }

    public List<Entity> Getait_ait_city_ait_deathrecord_deathcity(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_deathrecord", "ait_deathcity", columns);
    }

    public List<ait_physicaladdress> Getait_ait_physicaladdress_ait_city(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_physicaladdress>(service, this.Id, "ait_physicaladdress", nameof (ait_city), columns);
    }

    public List<ait_physicaladdress> Getait_ait_physicaladdress_ait_city(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_physicaladdress>(service, this.Id, "ait_physicaladdress", nameof (ait_city), columns);
    }

    public List<Entity> Getait_ait_city_ait_tribe(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_tribe", "ait_address1_city", columns);
    }

    public List<Entity> Getait_ait_city_ait_tribe(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_tribe", "ait_address1_city", columns);
    }

    public List<ait_zipcodecity> Getait_ait_zipcodecity_ait_city(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_zipcodecity>(service, this.Id, "ait_zipcodecity", nameof (ait_city), columns);
    }

    public List<ait_zipcodecity> Getait_ait_zipcodecity_ait_city(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_zipcodecity>(service, this.Id, "ait_zipcodecity", nameof (ait_city), columns);
    }

    public List<Entity> Getait_city_AsyncOperations(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "asyncoperation", "regardingobjectid", columns);
    }

    public List<Entity> Getait_city_AsyncOperations(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "asyncoperation", "regardingobjectid", columns);
    }

    public List<Entity> Getait_city_BulkDeleteFailures(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bulkdeletefailure", "regardingobjectid", columns);
    }

    public List<Entity> Getait_city_BulkDeleteFailures(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bulkdeletefailure", "regardingobjectid", columns);
    }

    public List<Entity> Getait_city_DuplicateBaseRecord(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "duplicaterecord", "baserecordid", columns);
    }

    public List<Entity> Getait_city_DuplicateBaseRecord(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "duplicaterecord", "baserecordid", columns);
    }

    public List<Entity> Getait_city_DuplicateMatchingRecord(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "duplicaterecord", "duplicaterecordid", columns);
    }

    public List<Entity> Getait_city_DuplicateMatchingRecord(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "duplicaterecord", "duplicaterecordid", columns);
    }

    public List<Entity> Getait_city_MailboxTrackingFolders(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "mailboxtrackingfolder", "regardingobjectid", columns);
    }

    public List<Entity> Getait_city_MailboxTrackingFolders(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "mailboxtrackingfolder", "regardingobjectid", columns);
    }

    public List<Entity> Getait_city_PrincipalObjectAttributeAccesses(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "principalobjectattributeaccess", "objectid", columns);
    }

    public List<Entity> Getait_city_PrincipalObjectAttributeAccesses(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "principalobjectattributeaccess", "objectid", columns);
    }

    public List<Entity> Getait_city_ProcessSession(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "processsession", "regardingobjectid", columns);
    }

    public List<Entity> Getait_city_ProcessSession(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "processsession", "regardingobjectid", columns);
    }

    public List<Entity> Getait_city_SyncErrors(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "syncerror", "regardingobjectid", columns);
    }

    public List<Entity> Getait_city_SyncErrors(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "syncerror", "regardingobjectid", columns);
    }

    public List<Entity> Getait_city_UserEntityInstanceDatas(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userentityinstancedata", "objectid", columns);
    }

    public List<Entity> Getait_city_UserEntityInstanceDatas(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userentityinstancedata", "objectid", columns);
    }

    public static class Properties
    {
      public const string ait_cityid = "ait_cityid";
      public const string ait_citytype = "ait_citytype";
      public const string ait_citytypename = "ait_citytypename";
      public const string ait_county = "ait_county";
      public const string ait_countyname = "ait_countyname";
      public const string ait_description = "ait_description";
      public const string ait_households = "ait_households";
      public const string ait_latitude = "ait_latitude";
      public const string ait_longitude = "ait_longitude";
      public const string ait_name = "ait_name";
      public const string ait_population = "ait_population";
      public const string ait_stateprovince = "ait_stateprovince";
      public const string ait_stateprovincename = "ait_stateprovincename";
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
      public const string organizationid = "organizationid";
      public const string organizationidname = "organizationidname";
      public const string overriddencreatedon = "overriddencreatedon";
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
