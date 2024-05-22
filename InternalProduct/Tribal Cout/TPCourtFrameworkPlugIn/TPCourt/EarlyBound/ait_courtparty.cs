// Decompiled with JetBrains decompiler
// Type: TPCourt.EarlyBound.ait_courtparty
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
  [EntityLogicalName("ait_courtparty")]
  [GeneratedCode("XrmToolkit", "4.0")]
  [DataContract(Name = "Entity", Namespace = "http://schemas.microsoft.com/xrm/2011/Contracts")]
  public class ait_courtparty : BaseProxyClass
  {
    public const string LogicalName = "ait_courtparty";
    public const int ObjectTypeCode = 10155;
    public const string PrimaryIdAttribute = "ait_courtpartyid";
    public const string PrimaryNameAttribute = "ait_name";
    private static Dictionary<string, BaseProxyClass.eTextOptions> _textOptions;
    private static Dictionary<string, BaseProxyClass.eNumberOptions> _numberOptions;
    private static Dictionary<string, string> _errorStrings;

    static ait_courtparty()
    {
      BaseProxyClass.RegisterProxyType(typeof (ait_courtparty), nameof (ait_courtparty));
      ait_courtparty._textOptions = new Dictionary<string, BaseProxyClass.eTextOptions>();
      ait_courtparty._numberOptions = new Dictionary<string, BaseProxyClass.eNumberOptions>();
      ait_courtparty._errorStrings = new Dictionary<string, string>();
      ait_courtparty.TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
      ait_courtparty.NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
    }

    public ait_courtparty()
      : base(new Entity(nameof (ait_courtparty)))
    {
    }

    public ait_courtparty(Entity original)
      : base(original)
    {
    }

    public static string GetLogicalName() => BaseProxyClass.GetLogicalName<ait_courtparty>();

    public static BaseProxyClass.eTextOptions TextOptions { get; set; }

    public static void SetTextOptions(
      string logicalName,
      BaseProxyClass.eTextOptions options,
      string errorString = null)
    {
      if (ait_courtparty._textOptions.ContainsKey(logicalName))
        ait_courtparty._textOptions[logicalName] = options;
      else
        ait_courtparty._textOptions.Add(logicalName, options);
      if (!string.IsNullOrEmpty(errorString))
      {
        if (ait_courtparty._errorStrings.ContainsKey(logicalName))
          ait_courtparty._errorStrings[logicalName] = errorString;
        else
          ait_courtparty._errorStrings.Add(logicalName, errorString);
      }
      else
      {
        if (!ait_courtparty._errorStrings.ContainsKey(logicalName))
          return;
        ait_courtparty._errorStrings.Remove(logicalName);
      }
    }

    protected override BaseProxyClass.eTextOptions GetTextOptions(string logicalName)
    {
      return ait_courtparty._textOptions.ContainsKey(logicalName) ? ait_courtparty._textOptions[logicalName] : ait_courtparty.TextOptions;
    }

    public static BaseProxyClass.eNumberOptions NumberOptions { get; set; }

    public static void SetNumberOptions(
      string logicalName,
      BaseProxyClass.eNumberOptions options,
      string errorString = null)
    {
      if (ait_courtparty._numberOptions.ContainsKey(logicalName))
        ait_courtparty._numberOptions[logicalName] = options;
      else
        ait_courtparty._numberOptions.Add(logicalName, options);
      if (!string.IsNullOrEmpty(errorString))
      {
        if (ait_courtparty._errorStrings.ContainsKey(logicalName))
          ait_courtparty._errorStrings[logicalName] = errorString;
        else
          ait_courtparty._errorStrings.Add(logicalName, errorString);
      }
      else
      {
        if (!ait_courtparty._errorStrings.ContainsKey(logicalName))
          return;
        ait_courtparty._errorStrings.Remove(logicalName);
      }
    }

    protected override BaseProxyClass.eNumberOptions GetNumberOptions(string logicalName)
    {
      return ait_courtparty._numberOptions.ContainsKey(logicalName) ? ait_courtparty._numberOptions[logicalName] : ait_courtparty.NumberOptions;
    }

    protected override string GetErrorString(
      string attributeName,
      BaseProxyClass.eErrorType defaultErrorType)
    {
      return ait_courtparty._errorStrings.ContainsKey(attributeName) ? ait_courtparty._errorStrings[attributeName] : (defaultErrorType == BaseProxyClass.eErrorType.Text ? ait_courtparty.TextError : ait_courtparty.NumberError);
    }

    public static string TextError { get; set; }

    public static string NumberError { get; set; }

    [AttributeLogicalName("ait_courtcaseid")]
    public EntityReference ait_courtcaseid
    {
      get => this.GetPropertyValue<EntityReference>(nameof (ait_courtcaseid));
      set
      {
        this.SetPropertyValue<EntityReference>(nameof (ait_courtcaseid), value, nameof (ait_courtcaseid));
      }
    }

    [AttributeLogicalName("ait_courtcaseidname")]
    public string ait_courtcaseidname
    {
      get => this.GetPropertyValue<string>(nameof (ait_courtcaseidname));
    }

    [AttributeLogicalName("ait_courtpartyid")]
    public Guid ait_courtpartyid
    {
      get => this.Id;
      set
      {
        this.Id = value;
        this.SetPropertyValue<Guid>(nameof (ait_courtpartyid), value, nameof (ait_courtpartyid));
      }
    }

    [AttributeLogicalName("ait_courtpartysubtype")]
    public eAit_courtpartysubtype? ait_courtpartysubtype
    {
      get
      {
        return this.ait_courtpartysubtype_OptionSetValue != null ? new eAit_courtpartysubtype?((eAit_courtpartysubtype) this.ait_courtpartysubtype_OptionSetValue.Value) : new eAit_courtpartysubtype?();
      }
      set
      {
        if (value.HasValue)
          this.ait_courtpartysubtype_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.ait_courtpartysubtype_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("ait_courtpartysubtype")]
    public OptionSetValue ait_courtpartysubtype_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("ait_courtpartysubtype");
      set
      {
        this.SetPropertyValue<OptionSetValue>("ait_courtpartysubtype", value, nameof (ait_courtpartysubtype_OptionSetValue));
      }
    }

    public string ait_courtpartysubtype_Text(IOrganizationService service)
    {
      return this.ait_courtpartysubtype_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "ait_courtpartysubtype");
    }

    public string ait_courtpartysubtype_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.ait_courtpartysubtype_OptionSetValue.Value);
    }

    [AttributeLogicalName("ait_courtpartytype")]
    public eAit_courtpartytype? ait_courtpartytype
    {
      get
      {
        return this.ait_courtpartytype_OptionSetValue != null ? new eAit_courtpartytype?((eAit_courtpartytype) this.ait_courtpartytype_OptionSetValue.Value) : new eAit_courtpartytype?();
      }
      set
      {
        if (value.HasValue)
          this.ait_courtpartytype_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.ait_courtpartytype_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("ait_courtpartytype")]
    public OptionSetValue ait_courtpartytype_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("ait_courtpartytype");
      set
      {
        this.SetPropertyValue<OptionSetValue>("ait_courtpartytype", value, nameof (ait_courtpartytype_OptionSetValue));
      }
    }

    public string ait_courtpartytype_Text(IOrganizationService service)
    {
      return this.ait_courtpartytype_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "ait_courtpartytype");
    }

    public string ait_courtpartytype_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.ait_courtpartytype_OptionSetValue.Value);
    }

    [AttributeLogicalName("ait_courtprofile")]
    public EntityReference ait_courtprofile
    {
      get => this.GetPropertyValue<EntityReference>(nameof (ait_courtprofile));
      set
      {
        this.SetPropertyValue<EntityReference>(nameof (ait_courtprofile), value, nameof (ait_courtprofile));
      }
    }

    [AttributeLogicalName("ait_courtprofilename")]
    public string ait_courtprofilename
    {
      get => this.GetPropertyValue<string>(nameof (ait_courtprofilename));
    }

    [AttributeLogicalName("ait_description")]
    public string ait_description
    {
      get => this.GetPropertyValue<string>(nameof (ait_description));
      set => this.SetPropertyValue(nameof (ait_description), value, 2000, nameof (ait_description));
    }

    [AttributeLogicalName("ait_guardianadlitem")]
    public bool? ait_guardianadlitem
    {
      get => this.GetPropertyValue<bool?>(nameof (ait_guardianadlitem));
      set
      {
        this.SetPropertyValue<bool?>(nameof (ait_guardianadlitem), value, nameof (ait_guardianadlitem));
      }
    }

    [AttributeLogicalName("ait_juvenile")]
    public bool? ait_juvenile
    {
      get => this.GetPropertyValue<bool?>(nameof (ait_juvenile));
      set => this.SetPropertyValue<bool?>(nameof (ait_juvenile), value, nameof (ait_juvenile));
    }

    [AttributeLogicalName("ait_name")]
    public string ait_name
    {
      get => this.GetPropertyValue<string>(nameof (ait_name));
      set => this.SetPropertyValue(nameof (ait_name), value, 100, nameof (ait_name));
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
    public eAit_courtparty_statecode? statecode
    {
      get
      {
        return this.statecode_OptionSetValue != null ? new eAit_courtparty_statecode?((eAit_courtparty_statecode) this.statecode_OptionSetValue.Value) : new eAit_courtparty_statecode?();
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
    public eAit_courtparty_statuscode? statuscode
    {
      get
      {
        return this.statuscode_OptionSetValue != null ? new eAit_courtparty_statuscode?((eAit_courtparty_statuscode) this.statuscode_OptionSetValue.Value) : new eAit_courtparty_statuscode?();
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

    public List<Entity> Getait_courtparty_AsyncOperations(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "asyncoperation", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtparty_AsyncOperations(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "asyncoperation", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtparty_BulkDeleteFailures(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bulkdeletefailure", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtparty_BulkDeleteFailures(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bulkdeletefailure", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtparty_DuplicateBaseRecord(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "duplicaterecord", "baserecordid", columns);
    }

    public List<Entity> Getait_courtparty_DuplicateBaseRecord(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "duplicaterecord", "baserecordid", columns);
    }

    public List<Entity> Getait_courtparty_DuplicateMatchingRecord(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "duplicaterecord", "duplicaterecordid", columns);
    }

    public List<Entity> Getait_courtparty_DuplicateMatchingRecord(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "duplicaterecord", "duplicaterecordid", columns);
    }

    public List<Entity> Getait_courtparty_MailboxTrackingFolders(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "mailboxtrackingfolder", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtparty_MailboxTrackingFolders(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "mailboxtrackingfolder", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtparty_PrincipalObjectAttributeAccesses(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "principalobjectattributeaccess", "objectid", columns);
    }

    public List<Entity> Getait_courtparty_PrincipalObjectAttributeAccesses(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "principalobjectattributeaccess", "objectid", columns);
    }

    public List<Entity> Getait_courtparty_ProcessSession(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "processsession", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtparty_ProcessSession(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "processsession", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtparty_SyncErrors(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "syncerror", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtparty_SyncErrors(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "syncerror", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtparty_UserEntityInstanceDatas(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userentityinstancedata", "objectid", columns);
    }

    public List<Entity> Getait_courtparty_UserEntityInstanceDatas(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userentityinstancedata", "objectid", columns);
    }

    public static class Properties
    {
      public const string ait_courtcaseid = "ait_courtcaseid";
      public const string ait_courtcaseidname = "ait_courtcaseidname";
      public const string ait_courtpartyid = "ait_courtpartyid";
      public const string ait_courtpartysubtype = "ait_courtpartysubtype";
      public const string ait_courtpartysubtypename = "ait_courtpartysubtypename";
      public const string ait_courtpartytype = "ait_courtpartytype";
      public const string ait_courtpartytypename = "ait_courtpartytypename";
      public const string ait_courtprofile = "ait_courtprofile";
      public const string ait_courtprofilename = "ait_courtprofilename";
      public const string ait_description = "ait_description";
      public const string ait_guardianadlitem = "ait_guardianadlitem";
      public const string ait_guardianadlitemname = "ait_guardianadlitemname";
      public const string ait_juvenile = "ait_juvenile";
      public const string ait_juvenilename = "ait_juvenilename";
      public const string ait_name = "ait_name";
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
