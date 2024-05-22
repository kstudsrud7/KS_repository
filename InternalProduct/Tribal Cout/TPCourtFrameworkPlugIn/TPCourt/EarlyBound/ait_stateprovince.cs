// Decompiled with JetBrains decompiler
// Type: TPCourt.EarlyBound.ait_stateprovince
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
  [EntityLogicalName("ait_stateprovince")]
  [GeneratedCode("XrmToolkit", "4.0")]
  [DataContract(Name = "Entity", Namespace = "http://schemas.microsoft.com/xrm/2011/Contracts")]
  public class ait_stateprovince : BaseProxyClass
  {
    public const string LogicalName = "ait_stateprovince";
    public const int ObjectTypeCode = 10142;
    public const string PrimaryIdAttribute = "ait_stateprovinceid";
    public const string PrimaryNameAttribute = "ait_name";
    private static Dictionary<string, BaseProxyClass.eTextOptions> _textOptions;
    private static Dictionary<string, BaseProxyClass.eNumberOptions> _numberOptions;
    private static Dictionary<string, string> _errorStrings;

    static ait_stateprovince()
    {
      BaseProxyClass.RegisterProxyType(typeof (ait_stateprovince), nameof (ait_stateprovince));
      ait_stateprovince._textOptions = new Dictionary<string, BaseProxyClass.eTextOptions>();
      ait_stateprovince._numberOptions = new Dictionary<string, BaseProxyClass.eNumberOptions>();
      ait_stateprovince._errorStrings = new Dictionary<string, string>();
      ait_stateprovince.TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
      ait_stateprovince.NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
    }

    public ait_stateprovince()
      : base(new Entity(nameof (ait_stateprovince)))
    {
    }

    public ait_stateprovince(Entity original)
      : base(original)
    {
    }

    public static string GetLogicalName() => BaseProxyClass.GetLogicalName<ait_stateprovince>();

    public static BaseProxyClass.eTextOptions TextOptions { get; set; }

    public static void SetTextOptions(
      string logicalName,
      BaseProxyClass.eTextOptions options,
      string errorString = null)
    {
      if (ait_stateprovince._textOptions.ContainsKey(logicalName))
        ait_stateprovince._textOptions[logicalName] = options;
      else
        ait_stateprovince._textOptions.Add(logicalName, options);
      if (!string.IsNullOrEmpty(errorString))
      {
        if (ait_stateprovince._errorStrings.ContainsKey(logicalName))
          ait_stateprovince._errorStrings[logicalName] = errorString;
        else
          ait_stateprovince._errorStrings.Add(logicalName, errorString);
      }
      else
      {
        if (!ait_stateprovince._errorStrings.ContainsKey(logicalName))
          return;
        ait_stateprovince._errorStrings.Remove(logicalName);
      }
    }

    protected override BaseProxyClass.eTextOptions GetTextOptions(string logicalName)
    {
      return ait_stateprovince._textOptions.ContainsKey(logicalName) ? ait_stateprovince._textOptions[logicalName] : ait_stateprovince.TextOptions;
    }

    public static BaseProxyClass.eNumberOptions NumberOptions { get; set; }

    public static void SetNumberOptions(
      string logicalName,
      BaseProxyClass.eNumberOptions options,
      string errorString = null)
    {
      if (ait_stateprovince._numberOptions.ContainsKey(logicalName))
        ait_stateprovince._numberOptions[logicalName] = options;
      else
        ait_stateprovince._numberOptions.Add(logicalName, options);
      if (!string.IsNullOrEmpty(errorString))
      {
        if (ait_stateprovince._errorStrings.ContainsKey(logicalName))
          ait_stateprovince._errorStrings[logicalName] = errorString;
        else
          ait_stateprovince._errorStrings.Add(logicalName, errorString);
      }
      else
      {
        if (!ait_stateprovince._errorStrings.ContainsKey(logicalName))
          return;
        ait_stateprovince._errorStrings.Remove(logicalName);
      }
    }

    protected override BaseProxyClass.eNumberOptions GetNumberOptions(string logicalName)
    {
      return ait_stateprovince._numberOptions.ContainsKey(logicalName) ? ait_stateprovince._numberOptions[logicalName] : ait_stateprovince.NumberOptions;
    }

    protected override string GetErrorString(
      string attributeName,
      BaseProxyClass.eErrorType defaultErrorType)
    {
      return ait_stateprovince._errorStrings.ContainsKey(attributeName) ? ait_stateprovince._errorStrings[attributeName] : (defaultErrorType == BaseProxyClass.eErrorType.Text ? ait_stateprovince.TextError : ait_stateprovince.NumberError);
    }

    public static string TextError { get; set; }

    public static string NumberError { get; set; }

    [AttributeLogicalName("ait_abbreviation")]
    public string ait_abbreviation
    {
      get => this.GetPropertyValue<string>(nameof (ait_abbreviation));
      set
      {
        this.SetPropertyValue(nameof (ait_abbreviation), value, 100, nameof (ait_abbreviation));
      }
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

    [AttributeLogicalName("ait_description")]
    public string ait_description
    {
      get => this.GetPropertyValue<string>(nameof (ait_description));
      set => this.SetPropertyValue(nameof (ait_description), value, 250, nameof (ait_description));
    }

    [AttributeLogicalName("ait_name")]
    public string ait_name
    {
      get => this.GetPropertyValue<string>(nameof (ait_name));
      set => this.SetPropertyValue(nameof (ait_name), value, 100, nameof (ait_name));
    }

    [AttributeLogicalName("ait_stateprovinceid")]
    public Guid ait_stateprovinceid
    {
      get => this.Id;
      set
      {
        this.Id = value;
        this.SetPropertyValue<Guid>(nameof (ait_stateprovinceid), value, nameof (ait_stateprovinceid));
      }
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
    public eAit_stateprovince_statecode? statecode
    {
      get
      {
        return this.statecode_OptionSetValue != null ? new eAit_stateprovince_statecode?((eAit_stateprovince_statecode) this.statecode_OptionSetValue.Value) : new eAit_stateprovince_statecode?();
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
    public eAit_stateprovince_statuscode? statuscode
    {
      get
      {
        return this.statuscode_OptionSetValue != null ? new eAit_stateprovince_statuscode?((eAit_stateprovince_statuscode) this.statuscode_OptionSetValue.Value) : new eAit_stateprovince_statuscode?();
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

    public List<Entity> Getait_ait_birthrecord_ait_stateprovince(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_birthrecord", "ait_state", columns);
    }

    public List<Entity> Getait_ait_birthrecord_ait_stateprovince(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_birthrecord", "ait_state", columns);
    }

    public List<Entity> Getait_ait_stateprovince_ait_birthrecord_amendedstate(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_birthrecord", "ait_amendedstateprovince", columns);
    }

    public List<Entity> Getait_ait_stateprovince_ait_birthrecord_amendedstate(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_birthrecord", "ait_amendedstateprovince", columns);
    }

    public List<ait_city> Getait_ait_city_ait_stateprovince(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_city>(service, this.Id, "ait_city", nameof (ait_stateprovince), columns);
    }

    public List<ait_city> Getait_ait_city_ait_stateprovince(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_city>(service, this.Id, "ait_city", nameof (ait_stateprovince), columns);
    }

    public List<ait_county> Getait_ait_county_ait_stateprovince(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_county>(service, this.Id, "ait_county", nameof (ait_stateprovince), columns);
    }

    public List<ait_county> Getait_ait_county_ait_stateprovince(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_county>(service, this.Id, "ait_county", nameof (ait_stateprovince), columns);
    }

    public List<ait_courtprofile> Getait_stateprovince_ait_courtprofile_IssueState(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_courtprofile>(service, this.Id, "ait_courtprofile", "ait_issuestate", columns);
    }

    public List<ait_courtprofile> Getait_stateprovince_ait_courtprofile_IssueState(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_courtprofile>(service, this.Id, "ait_courtprofile", "ait_issuestate", columns);
    }

    public List<Entity> Getait_ait_stateprovince_ait_deathrecord_deathstate(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_deathrecord", "ait_deathstate", columns);
    }

    public List<Entity> Getait_ait_stateprovince_ait_deathrecord_deathstate(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_deathrecord", "ait_deathstate", columns);
    }

    public List<ait_physicaladdress> Getait_ait_physicaladdress_ait_stateprovince(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_physicaladdress>(service, this.Id, "ait_physicaladdress", nameof (ait_stateprovince), columns);
    }

    public List<ait_physicaladdress> Getait_ait_physicaladdress_ait_stateprovince(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_physicaladdress>(service, this.Id, "ait_physicaladdress", nameof (ait_stateprovince), columns);
    }

    public List<Entity> Getait_ait_stateprovince_ait_tribe(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_tribe", "ait_address1_state", columns);
    }

    public List<Entity> Getait_ait_stateprovince_ait_tribe(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_tribe", "ait_address1_state", columns);
    }

    public List<ait_zipcodecity> Getait_ait_zipcodecity_ait_stateprovince(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_zipcodecity>(service, this.Id, "ait_zipcodecity", nameof (ait_stateprovince), columns);
    }

    public List<ait_zipcodecity> Getait_ait_zipcodecity_ait_stateprovince(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_zipcodecity>(service, this.Id, "ait_zipcodecity", nameof (ait_stateprovince), columns);
    }

    public List<Entity> Getait_stateprovince_AsyncOperations(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "asyncoperation", "regardingobjectid", columns);
    }

    public List<Entity> Getait_stateprovince_AsyncOperations(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "asyncoperation", "regardingobjectid", columns);
    }

    public List<Entity> Getait_stateprovince_BulkDeleteFailures(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bulkdeletefailure", "regardingobjectid", columns);
    }

    public List<Entity> Getait_stateprovince_BulkDeleteFailures(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bulkdeletefailure", "regardingobjectid", columns);
    }

    public List<Entity> Getait_stateprovince_DuplicateBaseRecord(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "duplicaterecord", "baserecordid", columns);
    }

    public List<Entity> Getait_stateprovince_DuplicateBaseRecord(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "duplicaterecord", "baserecordid", columns);
    }

    public List<Entity> Getait_stateprovince_DuplicateMatchingRecord(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "duplicaterecord", "duplicaterecordid", columns);
    }

    public List<Entity> Getait_stateprovince_DuplicateMatchingRecord(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "duplicaterecord", "duplicaterecordid", columns);
    }

    public List<Entity> Getait_stateprovince_MailboxTrackingFolders(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "mailboxtrackingfolder", "regardingobjectid", columns);
    }

    public List<Entity> Getait_stateprovince_MailboxTrackingFolders(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "mailboxtrackingfolder", "regardingobjectid", columns);
    }

    public List<Entity> Getait_stateprovince_PrincipalObjectAttributeAccesses(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "principalobjectattributeaccess", "objectid", columns);
    }

    public List<Entity> Getait_stateprovince_PrincipalObjectAttributeAccesses(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "principalobjectattributeaccess", "objectid", columns);
    }

    public List<Entity> Getait_stateprovince_ProcessSession(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "processsession", "regardingobjectid", columns);
    }

    public List<Entity> Getait_stateprovince_ProcessSession(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "processsession", "regardingobjectid", columns);
    }

    public List<Entity> Getait_stateprovince_SyncErrors(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "syncerror", "regardingobjectid", columns);
    }

    public List<Entity> Getait_stateprovince_SyncErrors(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "syncerror", "regardingobjectid", columns);
    }

    public List<Entity> Getait_stateprovince_UserEntityInstanceDatas(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userentityinstancedata", "objectid", columns);
    }

    public List<Entity> Getait_stateprovince_UserEntityInstanceDatas(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userentityinstancedata", "objectid", columns);
    }

    public static class Properties
    {
      public const string ait_abbreviation = "ait_abbreviation";
      public const string ait_countryregion = "ait_countryregion";
      public const string ait_countryregionname = "ait_countryregionname";
      public const string ait_description = "ait_description";
      public const string ait_name = "ait_name";
      public const string ait_stateprovinceid = "ait_stateprovinceid";
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
