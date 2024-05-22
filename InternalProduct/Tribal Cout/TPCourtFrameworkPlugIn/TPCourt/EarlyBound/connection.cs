// Decompiled with JetBrains decompiler
// Type: TPCourt.EarlyBound.connection
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
  [EntityLogicalName("connection")]
  [GeneratedCode("XrmToolkit", "4.0")]
  [DataContract(Name = "Entity", Namespace = "http://schemas.microsoft.com/xrm/2011/Contracts")]
  public class connection : BaseProxyClass
  {
    public const string LogicalName = "connection";
    public const int ObjectTypeCode = 3234;
    public const string PrimaryIdAttribute = "connectionid";
    public const string PrimaryNameAttribute = "name";
    public const string PrimaryImageAttribute = "entityimage";
    private static Dictionary<string, BaseProxyClass.eTextOptions> _textOptions;
    private static Dictionary<string, BaseProxyClass.eNumberOptions> _numberOptions;
    private static Dictionary<string, string> _errorStrings;

    static connection()
    {
      BaseProxyClass.RegisterProxyType(typeof (connection), nameof (connection));
      connection._textOptions = new Dictionary<string, BaseProxyClass.eTextOptions>();
      connection._numberOptions = new Dictionary<string, BaseProxyClass.eNumberOptions>();
      connection._errorStrings = new Dictionary<string, string>();
      connection.TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
      connection.NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
    }

    public connection()
      : base(new Entity(nameof (connection)))
    {
    }

    public connection(Entity original)
      : base(original)
    {
    }

    public static string GetLogicalName() => BaseProxyClass.GetLogicalName<connection>();

    public static BaseProxyClass.eTextOptions TextOptions { get; set; }

    public static void SetTextOptions(
      string logicalName,
      BaseProxyClass.eTextOptions options,
      string errorString = null)
    {
      if (connection._textOptions.ContainsKey(logicalName))
        connection._textOptions[logicalName] = options;
      else
        connection._textOptions.Add(logicalName, options);
      if (!string.IsNullOrEmpty(errorString))
      {
        if (connection._errorStrings.ContainsKey(logicalName))
          connection._errorStrings[logicalName] = errorString;
        else
          connection._errorStrings.Add(logicalName, errorString);
      }
      else
      {
        if (!connection._errorStrings.ContainsKey(logicalName))
          return;
        connection._errorStrings.Remove(logicalName);
      }
    }

    protected override BaseProxyClass.eTextOptions GetTextOptions(string logicalName)
    {
      return connection._textOptions.ContainsKey(logicalName) ? connection._textOptions[logicalName] : connection.TextOptions;
    }

    public static BaseProxyClass.eNumberOptions NumberOptions { get; set; }

    public static void SetNumberOptions(
      string logicalName,
      BaseProxyClass.eNumberOptions options,
      string errorString = null)
    {
      if (connection._numberOptions.ContainsKey(logicalName))
        connection._numberOptions[logicalName] = options;
      else
        connection._numberOptions.Add(logicalName, options);
      if (!string.IsNullOrEmpty(errorString))
      {
        if (connection._errorStrings.ContainsKey(logicalName))
          connection._errorStrings[logicalName] = errorString;
        else
          connection._errorStrings.Add(logicalName, errorString);
      }
      else
      {
        if (!connection._errorStrings.ContainsKey(logicalName))
          return;
        connection._errorStrings.Remove(logicalName);
      }
    }

    protected override BaseProxyClass.eNumberOptions GetNumberOptions(string logicalName)
    {
      return connection._numberOptions.ContainsKey(logicalName) ? connection._numberOptions[logicalName] : connection.NumberOptions;
    }

    protected override string GetErrorString(
      string attributeName,
      BaseProxyClass.eErrorType defaultErrorType)
    {
      return connection._errorStrings.ContainsKey(attributeName) ? connection._errorStrings[attributeName] : (defaultErrorType == BaseProxyClass.eErrorType.Text ? connection.TextError : connection.NumberError);
    }

    public static string TextError { get; set; }

    public static string NumberError { get; set; }

    [AttributeLogicalName("connectionid")]
    public Guid connectionid
    {
      get => this.Id;
      set
      {
        this.Id = value;
        this.SetPropertyValue<Guid>(nameof (connectionid), value, nameof (connectionid));
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

    [AttributeLogicalName("description")]
    public string description
    {
      get => this.GetPropertyValue<string>(nameof (description));
      set => this.SetPropertyValue(nameof (description), value, 2000, nameof (description));
    }

    [AttributeLogicalName("effectiveend")]
    public DateTime? effectiveend
    {
      get => this.GetPropertyValue<DateTime?>(nameof (effectiveend));
      set => this.SetPropertyValue<DateTime?>(nameof (effectiveend), value, nameof (effectiveend));
    }

    [AttributeLogicalName("effectivestart")]
    public DateTime? effectivestart
    {
      get => this.GetPropertyValue<DateTime?>(nameof (effectivestart));
      set
      {
        this.SetPropertyValue<DateTime?>(nameof (effectivestart), value, nameof (effectivestart));
      }
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

    [AttributeLogicalName("exchangerate")]
    public Decimal? exchangerate => this.GetPropertyValue<Decimal?>(nameof (exchangerate));

    [AttributeLogicalName("importsequencenumber")]
    public int? importsequencenumber
    {
      get => this.GetPropertyValue<int?>(nameof (importsequencenumber));
      set
      {
        this.SetPropertyValue(nameof (importsequencenumber), value, int.MinValue, int.MaxValue, nameof (importsequencenumber));
      }
    }

    [AttributeLogicalName("ismaster")]
    public bool? ismaster => this.GetPropertyValue<bool?>(nameof (ismaster));

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

    [AttributeLogicalName("name")]
    public string name => this.GetPropertyValue<string>(nameof (name));

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

    [AttributeLogicalName("record1id")]
    public EntityReference record1id
    {
      get => this.GetPropertyValue<EntityReference>(nameof (record1id));
      set => this.SetPropertyValue<EntityReference>(nameof (record1id), value, nameof (record1id));
    }

    [AttributeLogicalName("record1idname")]
    public string record1idname => this.GetPropertyValue<string>(nameof (record1idname));

    [AttributeLogicalName("record1idobjecttypecode")]
    public string record1idobjecttypecode
    {
      get => this.GetPropertyValue<string>(nameof (record1idobjecttypecode));
      set
      {
        this.SetPropertyValue<string>(nameof (record1idobjecttypecode), value, nameof (record1idobjecttypecode));
      }
    }

    [AttributeLogicalName("record1objecttypecode")]
    public eConnection_record1objecttypecode? record1objecttypecode
    {
      get
      {
        return this.record1objecttypecode_OptionSetValue != null ? new eConnection_record1objecttypecode?((eConnection_record1objecttypecode) this.record1objecttypecode_OptionSetValue.Value) : new eConnection_record1objecttypecode?();
      }
    }

    [AttributeLogicalName("record1objecttypecode")]
    public OptionSetValue record1objecttypecode_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("record1objecttypecode");
    }

    public string record1objecttypecode_Text(IOrganizationService service)
    {
      return this.record1objecttypecode_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "record1objecttypecode");
    }

    public string record1objecttypecode_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.record1objecttypecode_OptionSetValue.Value);
    }

    [AttributeLogicalName("record1roleid")]
    public EntityReference record1roleid
    {
      get => this.GetPropertyValue<EntityReference>(nameof (record1roleid));
      set
      {
        this.SetPropertyValue<EntityReference>(nameof (record1roleid), value, nameof (record1roleid));
      }
    }

    [AttributeLogicalName("record1roleidname")]
    public string record1roleidname => this.GetPropertyValue<string>(nameof (record1roleidname));

    [AttributeLogicalName("record2id")]
    public EntityReference record2id
    {
      get => this.GetPropertyValue<EntityReference>(nameof (record2id));
      set => this.SetPropertyValue<EntityReference>(nameof (record2id), value, nameof (record2id));
    }

    [AttributeLogicalName("record2idname")]
    public string record2idname => this.GetPropertyValue<string>(nameof (record2idname));

    [AttributeLogicalName("record2idobjecttypecode")]
    public string record2idobjecttypecode
    {
      get => this.GetPropertyValue<string>(nameof (record2idobjecttypecode));
      set
      {
        this.SetPropertyValue<string>(nameof (record2idobjecttypecode), value, nameof (record2idobjecttypecode));
      }
    }

    [AttributeLogicalName("record2objecttypecode")]
    public eConnection_record2objecttypecode? record2objecttypecode
    {
      get
      {
        return this.record2objecttypecode_OptionSetValue != null ? new eConnection_record2objecttypecode?((eConnection_record2objecttypecode) this.record2objecttypecode_OptionSetValue.Value) : new eConnection_record2objecttypecode?();
      }
    }

    [AttributeLogicalName("record2objecttypecode")]
    public OptionSetValue record2objecttypecode_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("record2objecttypecode");
    }

    public string record2objecttypecode_Text(IOrganizationService service)
    {
      return this.record2objecttypecode_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "record2objecttypecode");
    }

    public string record2objecttypecode_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.record2objecttypecode_OptionSetValue.Value);
    }

    [AttributeLogicalName("record2roleid")]
    public EntityReference record2roleid
    {
      get => this.GetPropertyValue<EntityReference>(nameof (record2roleid));
      set
      {
        this.SetPropertyValue<EntityReference>(nameof (record2roleid), value, nameof (record2roleid));
      }
    }

    [AttributeLogicalName("record2roleidname")]
    public string record2roleidname => this.GetPropertyValue<string>(nameof (record2roleidname));

    [AttributeLogicalName("relatedconnectionid")]
    public EntityReference relatedconnectionid
    {
      get => this.GetPropertyValue<EntityReference>(nameof (relatedconnectionid));
    }

    [AttributeLogicalName("statecode")]
    public eConnection_statecode? statecode
    {
      get
      {
        return this.statecode_OptionSetValue != null ? new eConnection_statecode?((eConnection_statecode) this.statecode_OptionSetValue.Value) : new eConnection_statecode?();
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
    public eConnection_statuscode? statuscode
    {
      get
      {
        return this.statuscode_OptionSetValue != null ? new eConnection_statuscode?((eConnection_statuscode) this.statuscode_OptionSetValue.Value) : new eConnection_statuscode?();
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

    [AttributeLogicalName("transactioncurrencyid")]
    public EntityReference transactioncurrencyid
    {
      get => this.GetPropertyValue<EntityReference>(nameof (transactioncurrencyid));
      set
      {
        this.SetPropertyValue<EntityReference>(nameof (transactioncurrencyid), value, nameof (transactioncurrencyid));
      }
    }

    [AttributeLogicalName("transactioncurrencyidname")]
    public string transactioncurrencyidname
    {
      get => this.GetPropertyValue<string>(nameof (transactioncurrencyidname));
    }

    [AttributeLogicalName("versionnumber")]
    public int? versionnumber => this.GetPropertyValue<int?>(nameof (versionnumber));

    public List<Entity> GetConnection_AsyncOperations(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "asyncoperation", "regardingobjectid", columns);
    }

    public List<Entity> GetConnection_AsyncOperations(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "asyncoperation", "regardingobjectid", columns);
    }

    public List<connection> Getconnection_related_connection(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<connection>(service, this.Id, nameof (connection), "relatedconnectionid", columns);
    }

    public List<connection> Getconnection_related_connection(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<connection>(service, this.Id, nameof (connection), "relatedconnectionid", columns);
    }

    public List<Entity> Getconnection_principalobjectattributeaccess(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "principalobjectattributeaccess", "objectid", columns);
    }

    public List<Entity> Getconnection_principalobjectattributeaccess(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "principalobjectattributeaccess", "objectid", columns);
    }

    public List<Entity> GetConnection_ProcessSessions(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "processsession", "regardingobjectid", columns);
    }

    public List<Entity> GetConnection_ProcessSessions(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "processsession", "regardingobjectid", columns);
    }

    public List<Entity> GetConnection_SyncErrors(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "syncerror", "regardingobjectid", columns);
    }

    public List<Entity> GetConnection_SyncErrors(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "syncerror", "regardingobjectid", columns);
    }

    public List<Entity> Getuserentityinstancedata_connection(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userentityinstancedata", "objectid", columns);
    }

    public List<Entity> Getuserentityinstancedata_connection(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userentityinstancedata", "objectid", columns);
    }

    public static class Properties
    {
      public const string connectionid = "connectionid";
      public const string createdby = "createdby";
      public const string createdbyname = "createdbyname";
      public const string createdbyyominame = "createdbyyominame";
      public const string createdon = "createdon";
      public const string createdonbehalfby = "createdonbehalfby";
      public const string createdonbehalfbyname = "createdonbehalfbyname";
      public const string createdonbehalfbyyominame = "createdonbehalfbyyominame";
      public const string description = "description";
      public const string effectiveend = "effectiveend";
      public const string effectivestart = "effectivestart";
      public const string entityimage = "entityimage";
      public const string entityimage_timestamp = "entityimage_timestamp";
      public const string entityimage_url = "entityimage_url";
      public const string entityimageid = "entityimageid";
      public const string exchangerate = "exchangerate";
      public const string importsequencenumber = "importsequencenumber";
      public const string ismaster = "ismaster";
      public const string ismastername = "ismastername";
      public const string modifiedby = "modifiedby";
      public const string modifiedbyname = "modifiedbyname";
      public const string modifiedbyyominame = "modifiedbyyominame";
      public const string modifiedon = "modifiedon";
      public const string modifiedonbehalfby = "modifiedonbehalfby";
      public const string modifiedonbehalfbyname = "modifiedonbehalfbyname";
      public const string modifiedonbehalfbyyominame = "modifiedonbehalfbyyominame";
      public const string name = "name";
      public const string overriddencreatedon = "overriddencreatedon";
      public const string ownerid = "ownerid";
      public const string owneridname = "owneridname";
      public const string owneridtype = "owneridtype";
      public const string owneridyominame = "owneridyominame";
      public const string owningbusinessunit = "owningbusinessunit";
      public const string owningteam = "owningteam";
      public const string owninguser = "owninguser";
      public const string record1id = "record1id";
      public const string record1idname = "record1idname";
      public const string record1idobjecttypecode = "record1idobjecttypecode";
      public const string record1objecttypecode = "record1objecttypecode";
      public const string record1objecttypecodename = "record1objecttypecodename";
      public const string record1roleid = "record1roleid";
      public const string record1roleidname = "record1roleidname";
      public const string record2id = "record2id";
      public const string record2idname = "record2idname";
      public const string record2idobjecttypecode = "record2idobjecttypecode";
      public const string record2objecttypecode = "record2objecttypecode";
      public const string record2objecttypecodename = "record2objecttypecodename";
      public const string record2roleid = "record2roleid";
      public const string record2roleidname = "record2roleidname";
      public const string relatedconnectionid = "relatedconnectionid";
      public const string statecode = "statecode";
      public const string statecodename = "statecodename";
      public const string statuscode = "statuscode";
      public const string statuscodename = "statuscodename";
      public const string transactioncurrencyid = "transactioncurrencyid";
      public const string transactioncurrencyidname = "transactioncurrencyidname";
      public const string versionnumber = "versionnumber";
    }
  }
}
