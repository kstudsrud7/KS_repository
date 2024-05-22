// Decompiled with JetBrains decompiler
// Type: TPCourt.EarlyBound.ait_tribalenrollmentconfiguration
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
  [EntityLogicalName("ait_tribalenrollmentconfiguration")]
  [GeneratedCode("XrmToolkit", "4.0")]
  [DataContract(Name = "Entity", Namespace = "http://schemas.microsoft.com/xrm/2011/Contracts")]
  public class ait_tribalenrollmentconfiguration : BaseProxyClass
  {
    public const string LogicalName = "ait_tribalenrollmentconfiguration";
    public const int ObjectTypeCode = 10145;
    public const string PrimaryIdAttribute = "ait_tribalenrollmentconfigurationid";
    public const string PrimaryNameAttribute = "ait_name";
    public const string PrimaryImageAttribute = "entityimage";
    private static Dictionary<string, BaseProxyClass.eTextOptions> _textOptions;
    private static Dictionary<string, BaseProxyClass.eNumberOptions> _numberOptions;
    private static Dictionary<string, string> _errorStrings;

    static ait_tribalenrollmentconfiguration()
    {
      BaseProxyClass.RegisterProxyType(typeof (ait_tribalenrollmentconfiguration), nameof (ait_tribalenrollmentconfiguration));
      ait_tribalenrollmentconfiguration._textOptions = new Dictionary<string, BaseProxyClass.eTextOptions>();
      ait_tribalenrollmentconfiguration._numberOptions = new Dictionary<string, BaseProxyClass.eNumberOptions>();
      ait_tribalenrollmentconfiguration._errorStrings = new Dictionary<string, string>();
      ait_tribalenrollmentconfiguration.TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
      ait_tribalenrollmentconfiguration.NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
    }

    public ait_tribalenrollmentconfiguration()
      : base(new Entity(nameof (ait_tribalenrollmentconfiguration)))
    {
    }

    public ait_tribalenrollmentconfiguration(Entity original)
      : base(original)
    {
    }

    public static string GetLogicalName()
    {
      return BaseProxyClass.GetLogicalName<ait_tribalenrollmentconfiguration>();
    }

    public static BaseProxyClass.eTextOptions TextOptions { get; set; }

    public static void SetTextOptions(
      string logicalName,
      BaseProxyClass.eTextOptions options,
      string errorString = null)
    {
      if (ait_tribalenrollmentconfiguration._textOptions.ContainsKey(logicalName))
        ait_tribalenrollmentconfiguration._textOptions[logicalName] = options;
      else
        ait_tribalenrollmentconfiguration._textOptions.Add(logicalName, options);
      if (!string.IsNullOrEmpty(errorString))
      {
        if (ait_tribalenrollmentconfiguration._errorStrings.ContainsKey(logicalName))
          ait_tribalenrollmentconfiguration._errorStrings[logicalName] = errorString;
        else
          ait_tribalenrollmentconfiguration._errorStrings.Add(logicalName, errorString);
      }
      else
      {
        if (!ait_tribalenrollmentconfiguration._errorStrings.ContainsKey(logicalName))
          return;
        ait_tribalenrollmentconfiguration._errorStrings.Remove(logicalName);
      }
    }

    protected override BaseProxyClass.eTextOptions GetTextOptions(string logicalName)
    {
      return ait_tribalenrollmentconfiguration._textOptions.ContainsKey(logicalName) ? ait_tribalenrollmentconfiguration._textOptions[logicalName] : ait_tribalenrollmentconfiguration.TextOptions;
    }

    public static BaseProxyClass.eNumberOptions NumberOptions { get; set; }

    public static void SetNumberOptions(
      string logicalName,
      BaseProxyClass.eNumberOptions options,
      string errorString = null)
    {
      if (ait_tribalenrollmentconfiguration._numberOptions.ContainsKey(logicalName))
        ait_tribalenrollmentconfiguration._numberOptions[logicalName] = options;
      else
        ait_tribalenrollmentconfiguration._numberOptions.Add(logicalName, options);
      if (!string.IsNullOrEmpty(errorString))
      {
        if (ait_tribalenrollmentconfiguration._errorStrings.ContainsKey(logicalName))
          ait_tribalenrollmentconfiguration._errorStrings[logicalName] = errorString;
        else
          ait_tribalenrollmentconfiguration._errorStrings.Add(logicalName, errorString);
      }
      else
      {
        if (!ait_tribalenrollmentconfiguration._errorStrings.ContainsKey(logicalName))
          return;
        ait_tribalenrollmentconfiguration._errorStrings.Remove(logicalName);
      }
    }

    protected override BaseProxyClass.eNumberOptions GetNumberOptions(string logicalName)
    {
      return ait_tribalenrollmentconfiguration._numberOptions.ContainsKey(logicalName) ? ait_tribalenrollmentconfiguration._numberOptions[logicalName] : ait_tribalenrollmentconfiguration.NumberOptions;
    }

    protected override string GetErrorString(
      string attributeName,
      BaseProxyClass.eErrorType defaultErrorType)
    {
      return ait_tribalenrollmentconfiguration._errorStrings.ContainsKey(attributeName) ? ait_tribalenrollmentconfiguration._errorStrings[attributeName] : (defaultErrorType == BaseProxyClass.eErrorType.Text ? ait_tribalenrollmentconfiguration.TextError : ait_tribalenrollmentconfiguration.NumberError);
    }

    public static string TextError { get; set; }

    public static string NumberError { get; set; }

    [AttributeLogicalName("ait_adultage")]
    public int? ait_adultage
    {
      get => this.GetPropertyValue<int?>(nameof (ait_adultage));
      set => this.SetPropertyValue(nameof (ait_adultage), value, 0, 100, nameof (ait_adultage));
    }

    [AttributeLogicalName("ait_bqcalculationmethod")]
    public eAit_bloodquantumcalculationmethod? ait_bqcalculationmethod
    {
      get
      {
        return this.ait_bqcalculationmethod_OptionSetValue != null ? new eAit_bloodquantumcalculationmethod?((eAit_bloodquantumcalculationmethod) this.ait_bqcalculationmethod_OptionSetValue.Value) : new eAit_bloodquantumcalculationmethod?();
      }
      set
      {
        if (value.HasValue)
          this.ait_bqcalculationmethod_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.ait_bqcalculationmethod_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("ait_bqcalculationmethod")]
    public OptionSetValue ait_bqcalculationmethod_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("ait_bqcalculationmethod");
      set
      {
        this.SetPropertyValue<OptionSetValue>("ait_bqcalculationmethod", value, nameof (ait_bqcalculationmethod_OptionSetValue));
      }
    }

    public string ait_bqcalculationmethod_Text(IOrganizationService service)
    {
      return this.ait_bqcalculationmethod_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "ait_bqcalculationmethod");
    }

    public string ait_bqcalculationmethod_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.ait_bqcalculationmethod_OptionSetValue.Value);
    }

    [AttributeLogicalName("ait_bqmembershipthresholddecimal")]
    public Decimal? ait_bqmembershipthresholddecimal
    {
      get => this.GetPropertyValue<Decimal?>(nameof (ait_bqmembershipthresholddecimal));
      set
      {
        this.SetPropertyValue(nameof (ait_bqmembershipthresholddecimal), value, 0M, 1000000000M, nameof (ait_bqmembershipthresholddecimal));
      }
    }

    [AttributeLogicalName("ait_bqmembershipthresholdfraction")]
    public string ait_bqmembershipthresholdfraction
    {
      get => this.GetPropertyValue<string>(nameof (ait_bqmembershipthresholdfraction));
      set
      {
        this.SetPropertyValue(nameof (ait_bqmembershipthresholdfraction), value, 100, nameof (ait_bqmembershipthresholdfraction));
      }
    }

    [AttributeLogicalName("ait_bqparentminimumdecimal")]
    public Decimal? ait_bqparentminimumdecimal
    {
      get => this.GetPropertyValue<Decimal?>(nameof (ait_bqparentminimumdecimal));
      set
      {
        this.SetPropertyValue(nameof (ait_bqparentminimumdecimal), value, 0M, 1000000000M, nameof (ait_bqparentminimumdecimal));
      }
    }

    [AttributeLogicalName("ait_bqparentminimumfraction")]
    public string ait_bqparentminimumfraction
    {
      get => this.GetPropertyValue<string>(nameof (ait_bqparentminimumfraction));
      set
      {
        this.SetPropertyValue(nameof (ait_bqparentminimumfraction), value, 100, nameof (ait_bqparentminimumfraction));
      }
    }

    [AttributeLogicalName("ait_contactnaming")]
    public eAit_contactnaming? ait_contactnaming
    {
      get
      {
        return this.ait_contactnaming_OptionSetValue != null ? new eAit_contactnaming?((eAit_contactnaming) this.ait_contactnaming_OptionSetValue.Value) : new eAit_contactnaming?();
      }
      set
      {
        if (value.HasValue)
          this.ait_contactnaming_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.ait_contactnaming_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("ait_contactnaming")]
    public OptionSetValue ait_contactnaming_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("ait_contactnaming");
      set
      {
        this.SetPropertyValue<OptionSetValue>("ait_contactnaming", value, nameof (ait_contactnaming_OptionSetValue));
      }
    }

    public string ait_contactnaming_Text(IOrganizationService service)
    {
      return this.ait_contactnaming_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "ait_contactnaming");
    }

    public string ait_contactnaming_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.ait_contactnaming_OptionSetValue.Value);
    }

    [AttributeLogicalName("ait_defaulttribe")]
    public EntityReference ait_defaulttribe
    {
      get => this.GetPropertyValue<EntityReference>(nameof (ait_defaulttribe));
      set
      {
        this.SetPropertyValue<EntityReference>(nameof (ait_defaulttribe), value, nameof (ait_defaulttribe));
      }
    }

    [AttributeLogicalName("ait_defaulttribename")]
    public string ait_defaulttribename
    {
      get => this.GetPropertyValue<string>(nameof (ait_defaulttribename));
    }

    [AttributeLogicalName("ait_entityimagestring")]
    public string ait_entityimagestring
    {
      get => this.GetPropertyValue<string>(nameof (ait_entityimagestring));
      set
      {
        this.SetPropertyValue(nameof (ait_entityimagestring), value, 1024094, nameof (ait_entityimagestring));
      }
    }

    [AttributeLogicalName("ait_familytreereporturl")]
    public string ait_familytreereporturl
    {
      get => this.GetPropertyValue<string>(nameof (ait_familytreereporturl));
      set
      {
        this.SetPropertyValue(nameof (ait_familytreereporturl), value, 100, nameof (ait_familytreereporturl));
      }
    }

    [AttributeLogicalName("ait_householdnaming")]
    public eAit_householdnameoptions? ait_householdnaming
    {
      get
      {
        return this.ait_householdnaming_OptionSetValue != null ? new eAit_householdnameoptions?((eAit_householdnameoptions) this.ait_householdnaming_OptionSetValue.Value) : new eAit_householdnameoptions?();
      }
      set
      {
        if (value.HasValue)
          this.ait_householdnaming_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.ait_householdnaming_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("ait_householdnaming")]
    public OptionSetValue ait_householdnaming_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("ait_householdnaming");
      set
      {
        this.SetPropertyValue<OptionSetValue>("ait_householdnaming", value, nameof (ait_householdnaming_OptionSetValue));
      }
    }

    public string ait_householdnaming_Text(IOrganizationService service)
    {
      return this.ait_householdnaming_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "ait_householdnaming");
    }

    public string ait_householdnaming_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.ait_householdnaming_OptionSetValue.Value);
    }

    [AttributeLogicalName("ait_membershipcardexpirationperiod")]
    public int? ait_membershipcardexpirationperiod
    {
      get => this.GetPropertyValue<int?>(nameof (ait_membershipcardexpirationperiod));
      set
      {
        this.SetPropertyValue(nameof (ait_membershipcardexpirationperiod), value, 0, 100, nameof (ait_membershipcardexpirationperiod));
      }
    }

    [AttributeLogicalName("ait_name")]
    public string ait_name
    {
      get => this.GetPropertyValue<string>(nameof (ait_name));
      set => this.SetPropertyValue(nameof (ait_name), value, 100, nameof (ait_name));
    }

    [AttributeLogicalName("ait_reportfooterinformation")]
    public string ait_reportfooterinformation
    {
      get => this.GetPropertyValue<string>(nameof (ait_reportfooterinformation));
      set
      {
        this.SetPropertyValue(nameof (ait_reportfooterinformation), value, 2000, nameof (ait_reportfooterinformation));
      }
    }

    [AttributeLogicalName("ait_seniorage")]
    public int? ait_seniorage
    {
      get => this.GetPropertyValue<int?>(nameof (ait_seniorage));
      set => this.SetPropertyValue(nameof (ait_seniorage), value, 0, 100, nameof (ait_seniorage));
    }

    [AttributeLogicalName("ait_supportedidprintversion")]
    public string ait_supportedidprintversion
    {
      get => this.GetPropertyValue<string>(nameof (ait_supportedidprintversion));
      set
      {
        this.SetPropertyValue(nameof (ait_supportedidprintversion), value, 100, nameof (ait_supportedidprintversion));
      }
    }

    [AttributeLogicalName("ait_synchronizehouseholdaddresses")]
    public bool? ait_synchronizehouseholdaddresses
    {
      get => this.GetPropertyValue<bool?>(nameof (ait_synchronizehouseholdaddresses));
      set
      {
        this.SetPropertyValue<bool?>(nameof (ait_synchronizehouseholdaddresses), value, nameof (ait_synchronizehouseholdaddresses));
      }
    }

    [AttributeLogicalName("ait_tribalenrollmentconfigurationid")]
    public Guid ait_tribalenrollmentconfigurationid
    {
      get => this.Id;
      set
      {
        this.Id = value;
        this.SetPropertyValue<Guid>(nameof (ait_tribalenrollmentconfigurationid), value, nameof (ait_tribalenrollmentconfigurationid));
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

    [AttributeLogicalName("entityimage_timestamp")]
    public int? entityimage_timestamp
    {
      get => this.GetPropertyValue<int?>(nameof (entityimage_timestamp));
    }

    [AttributeLogicalName("entityimage_url")]
    public string entityimage_url => this.GetPropertyValue<string>(nameof (entityimage_url));

    [AttributeLogicalName("entityimageid")]
    public Guid entityimageid => this.GetPropertyValue<Guid>(nameof (entityimageid));

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
    public eAit_tribalenrollmentconfiguration_statecode? statecode
    {
      get
      {
        return this.statecode_OptionSetValue != null ? new eAit_tribalenrollmentconfiguration_statecode?((eAit_tribalenrollmentconfiguration_statecode) this.statecode_OptionSetValue.Value) : new eAit_tribalenrollmentconfiguration_statecode?();
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
    public eAit_tribalenrollmentconfiguration_statuscode? statuscode
    {
      get
      {
        return this.statuscode_OptionSetValue != null ? new eAit_tribalenrollmentconfiguration_statuscode?((eAit_tribalenrollmentconfiguration_statuscode) this.statuscode_OptionSetValue.Value) : new eAit_tribalenrollmentconfiguration_statuscode?();
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

    public List<Entity> Getait_tribalenrollmentconfiguration_AsyncOperations(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "asyncoperation", "regardingobjectid", columns);
    }

    public List<Entity> Getait_tribalenrollmentconfiguration_AsyncOperations(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "asyncoperation", "regardingobjectid", columns);
    }

    public List<Entity> Getait_tribalenrollmentconfiguration_BulkDeleteFailures(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bulkdeletefailure", "regardingobjectid", columns);
    }

    public List<Entity> Getait_tribalenrollmentconfiguration_BulkDeleteFailures(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bulkdeletefailure", "regardingobjectid", columns);
    }

    public List<Entity> Getait_tribalenrollmentconfiguration_DuplicateBaseRecord(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "duplicaterecord", "baserecordid", columns);
    }

    public List<Entity> Getait_tribalenrollmentconfiguration_DuplicateBaseRecord(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "duplicaterecord", "baserecordid", columns);
    }

    public List<Entity> Getait_tribalenrollmentconfiguration_DuplicateMatchingRecord(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "duplicaterecord", "duplicaterecordid", columns);
    }

    public List<Entity> Getait_tribalenrollmentconfiguration_DuplicateMatchingRecord(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "duplicaterecord", "duplicaterecordid", columns);
    }

    public List<Entity> Getait_tribalenrollmentconfiguration_MailboxTrackingFolders(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "mailboxtrackingfolder", "regardingobjectid", columns);
    }

    public List<Entity> Getait_tribalenrollmentconfiguration_MailboxTrackingFolders(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "mailboxtrackingfolder", "regardingobjectid", columns);
    }

    public List<Entity> Getait_tribalenrollmentconfiguration_PrincipalObjectAttributeAccesses(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "principalobjectattributeaccess", "objectid", columns);
    }

    public List<Entity> Getait_tribalenrollmentconfiguration_PrincipalObjectAttributeAccesses(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "principalobjectattributeaccess", "objectid", columns);
    }

    public List<Entity> Getait_tribalenrollmentconfiguration_ProcessSession(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "processsession", "regardingobjectid", columns);
    }

    public List<Entity> Getait_tribalenrollmentconfiguration_ProcessSession(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "processsession", "regardingobjectid", columns);
    }

    public List<Entity> Getait_tribalenrollmentconfiguration_SyncErrors(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "syncerror", "regardingobjectid", columns);
    }

    public List<Entity> Getait_tribalenrollmentconfiguration_SyncErrors(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "syncerror", "regardingobjectid", columns);
    }

    public List<Entity> Getait_tribalenrollmentconfiguration_UserEntityInstanceDatas(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userentityinstancedata", "objectid", columns);
    }

    public List<Entity> Getait_tribalenrollmentconfiguration_UserEntityInstanceDatas(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userentityinstancedata", "objectid", columns);
    }

    public static class Properties
    {
      public const string ait_adultage = "ait_adultage";
      public const string ait_bqcalculationmethod = "ait_bqcalculationmethod";
      public const string ait_bqcalculationmethodname = "ait_bqcalculationmethodname";
      public const string ait_bqmembershipthresholddecimal = "ait_bqmembershipthresholddecimal";
      public const string ait_bqmembershipthresholdfraction = "ait_bqmembershipthresholdfraction";
      public const string ait_bqparentminimumdecimal = "ait_bqparentminimumdecimal";
      public const string ait_bqparentminimumfraction = "ait_bqparentminimumfraction";
      public const string ait_contactnaming = "ait_contactnaming";
      public const string ait_contactnamingname = "ait_contactnamingname";
      public const string ait_defaulttribe = "ait_defaulttribe";
      public const string ait_defaulttribename = "ait_defaulttribename";
      public const string ait_entityimagestring = "ait_entityimagestring";
      public const string ait_familytreereporturl = "ait_familytreereporturl";
      public const string ait_householdnaming = "ait_householdnaming";
      public const string ait_householdnamingname = "ait_householdnamingname";
      public const string ait_membershipcardexpirationperiod = "ait_membershipcardexpirationperiod";
      public const string ait_name = "ait_name";
      public const string ait_reportfooterinformation = "ait_reportfooterinformation";
      public const string ait_seniorage = "ait_seniorage";
      public const string ait_supportedidprintversion = "ait_supportedidprintversion";
      public const string ait_synchronizehouseholdaddresses = "ait_synchronizehouseholdaddresses";
      public const string ait_synchronizehouseholdaddressesname = "ait_synchronizehouseholdaddressesname";
      public const string ait_tribalenrollmentconfigurationid = "ait_tribalenrollmentconfigurationid";
      public const string createdby = "createdby";
      public const string createdbyname = "createdbyname";
      public const string createdbyyominame = "createdbyyominame";
      public const string createdon = "createdon";
      public const string createdonbehalfby = "createdonbehalfby";
      public const string createdonbehalfbyname = "createdonbehalfbyname";
      public const string createdonbehalfbyyominame = "createdonbehalfbyyominame";
      public const string entityimage = "entityimage";
      public const string entityimage_timestamp = "entityimage_timestamp";
      public const string entityimage_url = "entityimage_url";
      public const string entityimageid = "entityimageid";
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
