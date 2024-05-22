// Decompiled with JetBrains decompiler
// Type: TPCourt.EarlyBound.connectionrole
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
  [EntityLogicalName("connectionrole")]
  [GeneratedCode("XrmToolkit", "4.0")]
  [DataContract(Name = "Entity", Namespace = "http://schemas.microsoft.com/xrm/2011/Contracts")]
  public class connectionrole : BaseProxyClass
  {
    public const string LogicalName = "connectionrole";
    public const int ObjectTypeCode = 3231;
    public const string PrimaryIdAttribute = "connectionroleid";
    public const string PrimaryNameAttribute = "name";
    private static Dictionary<string, BaseProxyClass.eTextOptions> _textOptions;
    private static Dictionary<string, BaseProxyClass.eNumberOptions> _numberOptions;
    private static Dictionary<string, string> _errorStrings;

    static connectionrole()
    {
      BaseProxyClass.RegisterProxyType(typeof (connectionrole), nameof (connectionrole));
      connectionrole._textOptions = new Dictionary<string, BaseProxyClass.eTextOptions>();
      connectionrole._numberOptions = new Dictionary<string, BaseProxyClass.eNumberOptions>();
      connectionrole._errorStrings = new Dictionary<string, string>();
      connectionrole.TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
      connectionrole.NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
    }

    public connectionrole()
      : base(new Entity(nameof (connectionrole)))
    {
    }

    public connectionrole(Entity original)
      : base(original)
    {
    }

    public static string GetLogicalName() => BaseProxyClass.GetLogicalName<connectionrole>();

    public static BaseProxyClass.eTextOptions TextOptions { get; set; }

    public static void SetTextOptions(
      string logicalName,
      BaseProxyClass.eTextOptions options,
      string errorString = null)
    {
      if (connectionrole._textOptions.ContainsKey(logicalName))
        connectionrole._textOptions[logicalName] = options;
      else
        connectionrole._textOptions.Add(logicalName, options);
      if (!string.IsNullOrEmpty(errorString))
      {
        if (connectionrole._errorStrings.ContainsKey(logicalName))
          connectionrole._errorStrings[logicalName] = errorString;
        else
          connectionrole._errorStrings.Add(logicalName, errorString);
      }
      else
      {
        if (!connectionrole._errorStrings.ContainsKey(logicalName))
          return;
        connectionrole._errorStrings.Remove(logicalName);
      }
    }

    protected override BaseProxyClass.eTextOptions GetTextOptions(string logicalName)
    {
      return connectionrole._textOptions.ContainsKey(logicalName) ? connectionrole._textOptions[logicalName] : connectionrole.TextOptions;
    }

    public static BaseProxyClass.eNumberOptions NumberOptions { get; set; }

    public static void SetNumberOptions(
      string logicalName,
      BaseProxyClass.eNumberOptions options,
      string errorString = null)
    {
      if (connectionrole._numberOptions.ContainsKey(logicalName))
        connectionrole._numberOptions[logicalName] = options;
      else
        connectionrole._numberOptions.Add(logicalName, options);
      if (!string.IsNullOrEmpty(errorString))
      {
        if (connectionrole._errorStrings.ContainsKey(logicalName))
          connectionrole._errorStrings[logicalName] = errorString;
        else
          connectionrole._errorStrings.Add(logicalName, errorString);
      }
      else
      {
        if (!connectionrole._errorStrings.ContainsKey(logicalName))
          return;
        connectionrole._errorStrings.Remove(logicalName);
      }
    }

    protected override BaseProxyClass.eNumberOptions GetNumberOptions(string logicalName)
    {
      return connectionrole._numberOptions.ContainsKey(logicalName) ? connectionrole._numberOptions[logicalName] : connectionrole.NumberOptions;
    }

    protected override string GetErrorString(
      string attributeName,
      BaseProxyClass.eErrorType defaultErrorType)
    {
      return connectionrole._errorStrings.ContainsKey(attributeName) ? connectionrole._errorStrings[attributeName] : (defaultErrorType == BaseProxyClass.eErrorType.Text ? connectionrole.TextError : connectionrole.NumberError);
    }

    public static string TextError { get; set; }

    public static string NumberError { get; set; }

    [AttributeLogicalName("category")]
    public eConnectionrole_category? category
    {
      get
      {
        return this.category_OptionSetValue != null ? new eConnectionrole_category?((eConnectionrole_category) this.category_OptionSetValue.Value) : new eConnectionrole_category?();
      }
      set
      {
        if (value.HasValue)
          this.category_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.category_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("category")]
    public OptionSetValue category_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("category");
      set
      {
        this.SetPropertyValue<OptionSetValue>("category", value, nameof (category_OptionSetValue));
      }
    }

    public string category_Text(IOrganizationService service)
    {
      return this.category_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "category");
    }

    public string category_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.category_OptionSetValue.Value);
    }

    [AttributeLogicalName("componentstate")]
    public eComponentstate? componentstate
    {
      get
      {
        return this.componentstate_OptionSetValue != null ? new eComponentstate?((eComponentstate) this.componentstate_OptionSetValue.Value) : new eComponentstate?();
      }
    }

    [AttributeLogicalName("componentstate")]
    public OptionSetValue componentstate_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("componentstate");
    }

    public string componentstate_Text(IOrganizationService service)
    {
      return this.componentstate_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "componentstate");
    }

    public string componentstate_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.componentstate_OptionSetValue.Value);
    }

    [AttributeLogicalName("connectionroleid")]
    public Guid connectionroleid
    {
      get => this.Id;
      set
      {
        this.Id = value;
        this.SetPropertyValue<Guid>(nameof (connectionroleid), value, nameof (connectionroleid));
      }
    }

    [AttributeLogicalName("connectionroleidunique")]
    public Guid connectionroleidunique
    {
      get => this.GetPropertyValue<Guid>(nameof (connectionroleidunique));
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
      set => this.SetPropertyValue(nameof (description), value, 1000, nameof (description));
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

    [AttributeLogicalName("introducedversion")]
    public string introducedversion
    {
      get => this.GetPropertyValue<string>(nameof (introducedversion));
      set
      {
        this.SetPropertyValue(nameof (introducedversion), value, 48, nameof (introducedversion));
      }
    }

    [AttributeLogicalName("iscustomizable")]
    public BooleanManagedProperty iscustomizable
    {
      get => this.GetPropertyValue<BooleanManagedProperty>(nameof (iscustomizable));
      set
      {
        this.SetPropertyValue<BooleanManagedProperty>(nameof (iscustomizable), value, nameof (iscustomizable));
      }
    }

    [AttributeLogicalName("ismanaged")]
    public bool? ismanaged => this.GetPropertyValue<bool?>(nameof (ismanaged));

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
    public string name
    {
      get => this.GetPropertyValue<string>(nameof (name));
      set => this.SetPropertyValue(nameof (name), value, 100, nameof (name));
    }

    [AttributeLogicalName("organizationid")]
    public EntityReference organizationid
    {
      get => this.GetPropertyValue<EntityReference>(nameof (organizationid));
    }

    [AttributeLogicalName("organizationidname")]
    public string organizationidname => this.GetPropertyValue<string>(nameof (organizationidname));

    [AttributeLogicalName("overwritetime")]
    public DateTime? overwritetime => this.GetPropertyValue<DateTime?>(nameof (overwritetime));

    [AttributeLogicalName("solutionid")]
    public Guid solutionid => this.GetPropertyValue<Guid>(nameof (solutionid));

    [AttributeLogicalName("statecode")]
    public eConnectionrole_statecode? statecode
    {
      get
      {
        return this.statecode_OptionSetValue != null ? new eConnectionrole_statecode?((eConnectionrole_statecode) this.statecode_OptionSetValue.Value) : new eConnectionrole_statecode?();
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
    public eConnectionrole_statuscode? statuscode
    {
      get
      {
        return this.statuscode_OptionSetValue != null ? new eConnectionrole_statuscode?((eConnectionrole_statuscode) this.statuscode_OptionSetValue.Value) : new eConnectionrole_statuscode?();
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

    [AttributeLogicalName("supportingsolutionid")]
    public Guid supportingsolutionid => this.GetPropertyValue<Guid>(nameof (supportingsolutionid));

    [AttributeLogicalName("versionnumber")]
    public int? versionnumber => this.GetPropertyValue<int?>(nameof (versionnumber));

    public List<Entity> GetConnection_Role_AsyncOperations(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "asyncoperation", "regardingobjectid", columns);
    }

    public List<Entity> GetConnection_Role_AsyncOperations(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "asyncoperation", "regardingobjectid", columns);
    }

    public List<connection> Getconnection_role_connections1(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<connection>(service, this.Id, "connection", "record1roleid", columns);
    }

    public List<connection> Getconnection_role_connections1(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<connection>(service, this.Id, "connection", "record1roleid", columns);
    }

    public List<connection> Getconnection_role_connections2(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<connection>(service, this.Id, "connection", "record2roleid", columns);
    }

    public List<connection> Getconnection_role_connections2(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<connection>(service, this.Id, "connection", "record2roleid", columns);
    }

    public List<Entity> Getconnection_role_connection_role_object_type_codes(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "connectionroleobjecttypecode", "connectionroleid", columns);
    }

    public List<Entity> Getconnection_role_connection_role_object_type_codes(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "connectionroleobjecttypecode", "connectionroleid", columns);
    }

    public List<Entity> GetConnectionRole_ProcessSessions(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "processsession", "regardingobjectid", columns);
    }

    public List<Entity> GetConnectionRole_ProcessSessions(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "processsession", "regardingobjectid", columns);
    }

    public List<Entity> GetConnectionRole_SyncErrors(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "syncerror", "regardingobjectid", columns);
    }

    public List<Entity> GetConnectionRole_SyncErrors(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "syncerror", "regardingobjectid", columns);
    }

    public List<Entity> Getuserentityinstancedata_connectionrole(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userentityinstancedata", "objectid", columns);
    }

    public List<Entity> Getuserentityinstancedata_connectionrole(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userentityinstancedata", "objectid", columns);
    }

    public List<connectionrole> Getconnectionroleassociation_association(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedManyToManyEntities<connectionrole>(service, (BaseProxyClass) this, nameof (connectionrole), "connectionroleid", nameof (connectionrole), "connectionroleid", "connectionroleassociation", "connectionroleid", "associatedconnectionroleid", columns);
    }

    public List<connectionrole> Getconnectionroleassociation_association(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedManyToManyEntities<connectionrole>(service, (BaseProxyClass) this, nameof (connectionrole), "connectionroleid", nameof (connectionrole), "connectionroleid", "connectionroleassociation", "connectionroleid", "associatedconnectionroleid", columns);
    }

    public void Relateconnectionroleassociation_association(
      IOrganizationService service,
      params Entity[] items)
    {
      service.RelateEntities((EntityReference) (BaseProxyClass) this, "connectionroleassociation_association", items);
    }

    public void Relateconnectionroleassociation_association(
      IOrganizationService service,
      params EntityReference[] items)
    {
      service.RelateEntities((EntityReference) (BaseProxyClass) this, "connectionroleassociation_association", items);
    }

    public void UnRelateconnectionroleassociation_association(
      IOrganizationService service,
      params Entity[] items)
    {
      service.UnRelateEntities((EntityReference) (BaseProxyClass) this, "connectionroleassociation_association", items);
    }

    public void UnRelateconnectionroleassociation_association(
      IOrganizationService service,
      params EntityReference[] items)
    {
      service.UnRelateEntities((EntityReference) (BaseProxyClass) this, "connectionroleassociation_association", items);
    }

    public static class Properties
    {
      public const string category = "category";
      public const string categoryname = "categoryname";
      public const string componentstate = "componentstate";
      public const string connectionroleid = "connectionroleid";
      public const string connectionroleidunique = "connectionroleidunique";
      public const string createdby = "createdby";
      public const string createdbyname = "createdbyname";
      public const string createdbyyominame = "createdbyyominame";
      public const string createdon = "createdon";
      public const string createdonbehalfby = "createdonbehalfby";
      public const string createdonbehalfbyname = "createdonbehalfbyname";
      public const string createdonbehalfbyyominame = "createdonbehalfbyyominame";
      public const string description = "description";
      public const string importsequencenumber = "importsequencenumber";
      public const string introducedversion = "introducedversion";
      public const string iscustomizable = "iscustomizable";
      public const string ismanaged = "ismanaged";
      public const string ismanagedname = "ismanagedname";
      public const string modifiedby = "modifiedby";
      public const string modifiedbyname = "modifiedbyname";
      public const string modifiedbyyominame = "modifiedbyyominame";
      public const string modifiedon = "modifiedon";
      public const string modifiedonbehalfby = "modifiedonbehalfby";
      public const string modifiedonbehalfbyname = "modifiedonbehalfbyname";
      public const string modifiedonbehalfbyyominame = "modifiedonbehalfbyyominame";
      public const string name = "name";
      public const string organizationid = "organizationid";
      public const string organizationidname = "organizationidname";
      public const string overwritetime = "overwritetime";
      public const string solutionid = "solutionid";
      public const string statecode = "statecode";
      public const string statecodename = "statecodename";
      public const string statuscode = "statuscode";
      public const string statuscodename = "statuscodename";
      public const string supportingsolutionid = "supportingsolutionid";
      public const string versionnumber = "versionnumber";
    }
  }
}
