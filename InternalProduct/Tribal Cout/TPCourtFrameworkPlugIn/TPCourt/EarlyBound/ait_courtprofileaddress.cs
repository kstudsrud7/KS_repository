// Decompiled with JetBrains decompiler
// Type: TPCourt.EarlyBound.ait_courtprofileaddress
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
  [EntityLogicalName("ait_courtprofileaddress")]
  [GeneratedCode("XrmToolkit", "4.0")]
  [DataContract(Name = "Entity", Namespace = "http://schemas.microsoft.com/xrm/2011/Contracts")]
  public class ait_courtprofileaddress : BaseProxyClass
  {
    public const string LogicalName = "ait_courtprofileaddress";
    public const int ObjectTypeCode = 10204;
    public const string PrimaryIdAttribute = "ait_courtprofileaddressid";
    public const string PrimaryNameAttribute = "ait_name";
    private static Dictionary<string, BaseProxyClass.eTextOptions> _textOptions;
    private static Dictionary<string, BaseProxyClass.eNumberOptions> _numberOptions;
    private static Dictionary<string, string> _errorStrings;

    static ait_courtprofileaddress()
    {
      BaseProxyClass.RegisterProxyType(typeof (ait_courtprofileaddress), nameof (ait_courtprofileaddress));
      ait_courtprofileaddress._textOptions = new Dictionary<string, BaseProxyClass.eTextOptions>();
      ait_courtprofileaddress._numberOptions = new Dictionary<string, BaseProxyClass.eNumberOptions>();
      ait_courtprofileaddress._errorStrings = new Dictionary<string, string>();
      ait_courtprofileaddress.TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
      ait_courtprofileaddress.NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
    }

    public ait_courtprofileaddress()
      : base(new Entity(nameof (ait_courtprofileaddress)))
    {
    }

    public ait_courtprofileaddress(Entity original)
      : base(original)
    {
    }

    public static string GetLogicalName()
    {
      return BaseProxyClass.GetLogicalName<ait_courtprofileaddress>();
    }

    public static BaseProxyClass.eTextOptions TextOptions { get; set; }

    public static void SetTextOptions(
      string logicalName,
      BaseProxyClass.eTextOptions options,
      string errorString = null)
    {
      if (ait_courtprofileaddress._textOptions.ContainsKey(logicalName))
        ait_courtprofileaddress._textOptions[logicalName] = options;
      else
        ait_courtprofileaddress._textOptions.Add(logicalName, options);
      if (!string.IsNullOrEmpty(errorString))
      {
        if (ait_courtprofileaddress._errorStrings.ContainsKey(logicalName))
          ait_courtprofileaddress._errorStrings[logicalName] = errorString;
        else
          ait_courtprofileaddress._errorStrings.Add(logicalName, errorString);
      }
      else
      {
        if (!ait_courtprofileaddress._errorStrings.ContainsKey(logicalName))
          return;
        ait_courtprofileaddress._errorStrings.Remove(logicalName);
      }
    }

    protected override BaseProxyClass.eTextOptions GetTextOptions(string logicalName)
    {
      return ait_courtprofileaddress._textOptions.ContainsKey(logicalName) ? ait_courtprofileaddress._textOptions[logicalName] : ait_courtprofileaddress.TextOptions;
    }

    public static BaseProxyClass.eNumberOptions NumberOptions { get; set; }

    public static void SetNumberOptions(
      string logicalName,
      BaseProxyClass.eNumberOptions options,
      string errorString = null)
    {
      if (ait_courtprofileaddress._numberOptions.ContainsKey(logicalName))
        ait_courtprofileaddress._numberOptions[logicalName] = options;
      else
        ait_courtprofileaddress._numberOptions.Add(logicalName, options);
      if (!string.IsNullOrEmpty(errorString))
      {
        if (ait_courtprofileaddress._errorStrings.ContainsKey(logicalName))
          ait_courtprofileaddress._errorStrings[logicalName] = errorString;
        else
          ait_courtprofileaddress._errorStrings.Add(logicalName, errorString);
      }
      else
      {
        if (!ait_courtprofileaddress._errorStrings.ContainsKey(logicalName))
          return;
        ait_courtprofileaddress._errorStrings.Remove(logicalName);
      }
    }

    protected override BaseProxyClass.eNumberOptions GetNumberOptions(string logicalName)
    {
      return ait_courtprofileaddress._numberOptions.ContainsKey(logicalName) ? ait_courtprofileaddress._numberOptions[logicalName] : ait_courtprofileaddress.NumberOptions;
    }

    protected override string GetErrorString(
      string attributeName,
      BaseProxyClass.eErrorType defaultErrorType)
    {
      return ait_courtprofileaddress._errorStrings.ContainsKey(attributeName) ? ait_courtprofileaddress._errorStrings[attributeName] : (defaultErrorType == BaseProxyClass.eErrorType.Text ? ait_courtprofileaddress.TextError : ait_courtprofileaddress.NumberError);
    }

    public static string TextError { get; set; }

    public static string NumberError { get; set; }

    [AttributeLogicalName("ait_city")]
    public string ait_city
    {
      get => this.GetPropertyValue<string>(nameof (ait_city));
      set => this.SetPropertyValue(nameof (ait_city), value, 100, nameof (ait_city));
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

    [AttributeLogicalName("ait_courtprofileaddressid")]
    public Guid ait_courtprofileaddressid
    {
      get => this.Id;
      set
      {
        this.Id = value;
        this.SetPropertyValue<Guid>(nameof (ait_courtprofileaddressid), value, nameof (ait_courtprofileaddressid));
      }
    }

    [AttributeLogicalName("ait_courtprofilename")]
    public string ait_courtprofilename
    {
      get => this.GetPropertyValue<string>(nameof (ait_courtprofilename));
    }

    [AttributeLogicalName("ait_email")]
    public string ait_email
    {
      get => this.GetPropertyValue<string>(nameof (ait_email));
      set => this.SetPropertyValue(nameof (ait_email), value, 100, nameof (ait_email));
    }

    [AttributeLogicalName("ait_name")]
    public string ait_name
    {
      get => this.GetPropertyValue<string>(nameof (ait_name));
      set => this.SetPropertyValue(nameof (ait_name), value, 100, nameof (ait_name));
    }

    [AttributeLogicalName("ait_notes")]
    public string ait_notes
    {
      get => this.GetPropertyValue<string>(nameof (ait_notes));
      set => this.SetPropertyValue(nameof (ait_notes), value, 2000, nameof (ait_notes));
    }

    [AttributeLogicalName("ait_phone1")]
    public string ait_phone1
    {
      get => this.GetPropertyValue<string>(nameof (ait_phone1));
      set => this.SetPropertyValue(nameof (ait_phone1), value, 100, nameof (ait_phone1));
    }

    [AttributeLogicalName("ait_phone2")]
    public string ait_phone2
    {
      get => this.GetPropertyValue<string>(nameof (ait_phone2));
      set => this.SetPropertyValue(nameof (ait_phone2), value, 100, nameof (ait_phone2));
    }

    [AttributeLogicalName("ait_state")]
    public string ait_state
    {
      get => this.GetPropertyValue<string>(nameof (ait_state));
      set => this.SetPropertyValue(nameof (ait_state), value, 100, nameof (ait_state));
    }

    [AttributeLogicalName("ait_street")]
    public string ait_street
    {
      get => this.GetPropertyValue<string>(nameof (ait_street));
      set => this.SetPropertyValue(nameof (ait_street), value, 100, nameof (ait_street));
    }

    [AttributeLogicalName("ait_street2")]
    public string ait_street2
    {
      get => this.GetPropertyValue<string>(nameof (ait_street2));
      set => this.SetPropertyValue(nameof (ait_street2), value, 100, nameof (ait_street2));
    }

    [AttributeLogicalName("ait_zipcode")]
    public string ait_zipcode
    {
      get => this.GetPropertyValue<string>(nameof (ait_zipcode));
      set => this.SetPropertyValue(nameof (ait_zipcode), value, 100, nameof (ait_zipcode));
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
    public eAit_courtprofileaddress_statecode? statecode
    {
      get
      {
        return this.statecode_OptionSetValue != null ? new eAit_courtprofileaddress_statecode?((eAit_courtprofileaddress_statecode) this.statecode_OptionSetValue.Value) : new eAit_courtprofileaddress_statecode?();
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
    public eAit_courtprofileaddress_statuscode? statuscode
    {
      get
      {
        return this.statuscode_OptionSetValue != null ? new eAit_courtprofileaddress_statuscode?((eAit_courtprofileaddress_statuscode) this.statuscode_OptionSetValue.Value) : new eAit_courtprofileaddress_statuscode?();
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

    public List<Entity> Getait_courtprofileaddress_AsyncOperations(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "asyncoperation", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtprofileaddress_AsyncOperations(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "asyncoperation", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtprofileaddress_BulkDeleteFailures(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bulkdeletefailure", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtprofileaddress_BulkDeleteFailures(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bulkdeletefailure", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtprofileaddress_DuplicateBaseRecord(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "duplicaterecord", "baserecordid", columns);
    }

    public List<Entity> Getait_courtprofileaddress_DuplicateBaseRecord(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "duplicaterecord", "baserecordid", columns);
    }

    public List<Entity> Getait_courtprofileaddress_DuplicateMatchingRecord(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "duplicaterecord", "duplicaterecordid", columns);
    }

    public List<Entity> Getait_courtprofileaddress_DuplicateMatchingRecord(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "duplicaterecord", "duplicaterecordid", columns);
    }

    public List<Entity> Getait_courtprofileaddress_MailboxTrackingFolders(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "mailboxtrackingfolder", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtprofileaddress_MailboxTrackingFolders(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "mailboxtrackingfolder", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtprofileaddress_PrincipalObjectAttributeAccesses(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "principalobjectattributeaccess", "objectid", columns);
    }

    public List<Entity> Getait_courtprofileaddress_PrincipalObjectAttributeAccesses(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "principalobjectattributeaccess", "objectid", columns);
    }

    public List<Entity> Getait_courtprofileaddress_ProcessSession(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "processsession", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtprofileaddress_ProcessSession(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "processsession", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtprofileaddress_SyncErrors(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "syncerror", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtprofileaddress_SyncErrors(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "syncerror", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtprofileaddress_UserEntityInstanceDatas(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userentityinstancedata", "objectid", columns);
    }

    public List<Entity> Getait_courtprofileaddress_UserEntityInstanceDatas(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userentityinstancedata", "objectid", columns);
    }

    public static class Properties
    {
      public const string ait_city = "ait_city";
      public const string ait_courtprofile = "ait_courtprofile";
      public const string ait_courtprofileaddressid = "ait_courtprofileaddressid";
      public const string ait_courtprofilename = "ait_courtprofilename";
      public const string ait_email = "ait_email";
      public const string ait_name = "ait_name";
      public const string ait_notes = "ait_notes";
      public const string ait_phone1 = "ait_phone1";
      public const string ait_phone2 = "ait_phone2";
      public const string ait_state = "ait_state";
      public const string ait_street = "ait_street";
      public const string ait_street2 = "ait_street2";
      public const string ait_zipcode = "ait_zipcode";
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
