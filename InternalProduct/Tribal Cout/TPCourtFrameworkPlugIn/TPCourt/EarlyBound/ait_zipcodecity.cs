// Decompiled with JetBrains decompiler
// Type: TPCourt.EarlyBound.ait_zipcodecity
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
  [EntityLogicalName("ait_zipcodecity")]
  [GeneratedCode("XrmToolkit", "4.0")]
  [DataContract(Name = "Entity", Namespace = "http://schemas.microsoft.com/xrm/2011/Contracts")]
  public class ait_zipcodecity : BaseProxyClass
  {
    public const string LogicalName = "ait_zipcodecity";
    public const int ObjectTypeCode = 10147;
    public const string PrimaryIdAttribute = "ait_zipcodecityid";
    public const string PrimaryNameAttribute = "ait_name";
    private static Dictionary<string, BaseProxyClass.eTextOptions> _textOptions;
    private static Dictionary<string, BaseProxyClass.eNumberOptions> _numberOptions;
    private static Dictionary<string, string> _errorStrings;

    static ait_zipcodecity()
    {
      BaseProxyClass.RegisterProxyType(typeof (ait_zipcodecity), nameof (ait_zipcodecity));
      ait_zipcodecity._textOptions = new Dictionary<string, BaseProxyClass.eTextOptions>();
      ait_zipcodecity._numberOptions = new Dictionary<string, BaseProxyClass.eNumberOptions>();
      ait_zipcodecity._errorStrings = new Dictionary<string, string>();
      ait_zipcodecity.TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
      ait_zipcodecity.NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
    }

    public ait_zipcodecity()
      : base(new Entity(nameof (ait_zipcodecity)))
    {
    }

    public ait_zipcodecity(Entity original)
      : base(original)
    {
    }

    public static string GetLogicalName() => BaseProxyClass.GetLogicalName<ait_zipcodecity>();

    public static BaseProxyClass.eTextOptions TextOptions { get; set; }

    public static void SetTextOptions(
      string logicalName,
      BaseProxyClass.eTextOptions options,
      string errorString = null)
    {
      if (ait_zipcodecity._textOptions.ContainsKey(logicalName))
        ait_zipcodecity._textOptions[logicalName] = options;
      else
        ait_zipcodecity._textOptions.Add(logicalName, options);
      if (!string.IsNullOrEmpty(errorString))
      {
        if (ait_zipcodecity._errorStrings.ContainsKey(logicalName))
          ait_zipcodecity._errorStrings[logicalName] = errorString;
        else
          ait_zipcodecity._errorStrings.Add(logicalName, errorString);
      }
      else
      {
        if (!ait_zipcodecity._errorStrings.ContainsKey(logicalName))
          return;
        ait_zipcodecity._errorStrings.Remove(logicalName);
      }
    }

    protected override BaseProxyClass.eTextOptions GetTextOptions(string logicalName)
    {
      return ait_zipcodecity._textOptions.ContainsKey(logicalName) ? ait_zipcodecity._textOptions[logicalName] : ait_zipcodecity.TextOptions;
    }

    public static BaseProxyClass.eNumberOptions NumberOptions { get; set; }

    public static void SetNumberOptions(
      string logicalName,
      BaseProxyClass.eNumberOptions options,
      string errorString = null)
    {
      if (ait_zipcodecity._numberOptions.ContainsKey(logicalName))
        ait_zipcodecity._numberOptions[logicalName] = options;
      else
        ait_zipcodecity._numberOptions.Add(logicalName, options);
      if (!string.IsNullOrEmpty(errorString))
      {
        if (ait_zipcodecity._errorStrings.ContainsKey(logicalName))
          ait_zipcodecity._errorStrings[logicalName] = errorString;
        else
          ait_zipcodecity._errorStrings.Add(logicalName, errorString);
      }
      else
      {
        if (!ait_zipcodecity._errorStrings.ContainsKey(logicalName))
          return;
        ait_zipcodecity._errorStrings.Remove(logicalName);
      }
    }

    protected override BaseProxyClass.eNumberOptions GetNumberOptions(string logicalName)
    {
      return ait_zipcodecity._numberOptions.ContainsKey(logicalName) ? ait_zipcodecity._numberOptions[logicalName] : ait_zipcodecity.NumberOptions;
    }

    protected override string GetErrorString(
      string attributeName,
      BaseProxyClass.eErrorType defaultErrorType)
    {
      return ait_zipcodecity._errorStrings.ContainsKey(attributeName) ? ait_zipcodecity._errorStrings[attributeName] : (defaultErrorType == BaseProxyClass.eErrorType.Text ? ait_zipcodecity.TextError : ait_zipcodecity.NumberError);
    }

    public static string TextError { get; set; }

    public static string NumberError { get; set; }

    [AttributeLogicalName("ait_city")]
    public EntityReference ait_city
    {
      get => this.GetPropertyValue<EntityReference>(nameof (ait_city));
      set => this.SetPropertyValue<EntityReference>(nameof (ait_city), value, nameof (ait_city));
    }

    [AttributeLogicalName("ait_cityname")]
    public string ait_cityname => this.GetPropertyValue<string>(nameof (ait_cityname));

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

    [AttributeLogicalName("ait_zipcodecityid")]
    public Guid ait_zipcodecityid
    {
      get => this.Id;
      set
      {
        this.Id = value;
        this.SetPropertyValue<Guid>(nameof (ait_zipcodecityid), value, nameof (ait_zipcodecityid));
      }
    }

    [AttributeLogicalName("ait_zippostalcode")]
    public string ait_zippostalcode
    {
      get => this.GetPropertyValue<string>(nameof (ait_zippostalcode));
      set
      {
        this.SetPropertyValue(nameof (ait_zippostalcode), value, 100, nameof (ait_zippostalcode));
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
    public eAit_zipcodecity_statecode? statecode
    {
      get
      {
        return this.statecode_OptionSetValue != null ? new eAit_zipcodecity_statecode?((eAit_zipcodecity_statecode) this.statecode_OptionSetValue.Value) : new eAit_zipcodecity_statecode?();
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
    public eAit_zipcodecity_statuscode? statuscode
    {
      get
      {
        return this.statuscode_OptionSetValue != null ? new eAit_zipcodecity_statuscode?((eAit_zipcodecity_statuscode) this.statuscode_OptionSetValue.Value) : new eAit_zipcodecity_statuscode?();
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

    public List<ait_physicaladdress> Getait_ait_physicaladdress_ait_zipcodecity(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_physicaladdress>(service, this.Id, "ait_physicaladdress", "ait_zipcode", columns);
    }

    public List<ait_physicaladdress> Getait_ait_physicaladdress_ait_zipcodecity(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_physicaladdress>(service, this.Id, "ait_physicaladdress", "ait_zipcode", columns);
    }

    public List<Entity> Getait_ait_zipcodecity_ait_tribe(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_tribe", "ait_address1_zipcode", columns);
    }

    public List<Entity> Getait_ait_zipcodecity_ait_tribe(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_tribe", "ait_address1_zipcode", columns);
    }

    public List<Entity> Getait_zipcodecity_AsyncOperations(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "asyncoperation", "regardingobjectid", columns);
    }

    public List<Entity> Getait_zipcodecity_AsyncOperations(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "asyncoperation", "regardingobjectid", columns);
    }

    public List<Entity> Getait_zipcodecity_BulkDeleteFailures(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bulkdeletefailure", "regardingobjectid", columns);
    }

    public List<Entity> Getait_zipcodecity_BulkDeleteFailures(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bulkdeletefailure", "regardingobjectid", columns);
    }

    public List<Entity> Getait_zipcodecity_MailboxTrackingFolders(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "mailboxtrackingfolder", "regardingobjectid", columns);
    }

    public List<Entity> Getait_zipcodecity_MailboxTrackingFolders(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "mailboxtrackingfolder", "regardingobjectid", columns);
    }

    public List<Entity> Getait_zipcodecity_PrincipalObjectAttributeAccesses(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "principalobjectattributeaccess", "objectid", columns);
    }

    public List<Entity> Getait_zipcodecity_PrincipalObjectAttributeAccesses(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "principalobjectattributeaccess", "objectid", columns);
    }

    public List<Entity> Getait_zipcodecity_ProcessSession(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "processsession", "regardingobjectid", columns);
    }

    public List<Entity> Getait_zipcodecity_ProcessSession(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "processsession", "regardingobjectid", columns);
    }

    public List<Entity> Getait_zipcodecity_SyncErrors(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "syncerror", "regardingobjectid", columns);
    }

    public List<Entity> Getait_zipcodecity_SyncErrors(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "syncerror", "regardingobjectid", columns);
    }

    public List<Entity> Getait_zipcodecity_UserEntityInstanceDatas(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userentityinstancedata", "objectid", columns);
    }

    public List<Entity> Getait_zipcodecity_UserEntityInstanceDatas(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userentityinstancedata", "objectid", columns);
    }

    public static class Properties
    {
      public const string ait_city = "ait_city";
      public const string ait_cityname = "ait_cityname";
      public const string ait_description = "ait_description";
      public const string ait_name = "ait_name";
      public const string ait_stateprovince = "ait_stateprovince";
      public const string ait_stateprovincename = "ait_stateprovincename";
      public const string ait_zipcodecityid = "ait_zipcodecityid";
      public const string ait_zippostalcode = "ait_zippostalcode";
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
