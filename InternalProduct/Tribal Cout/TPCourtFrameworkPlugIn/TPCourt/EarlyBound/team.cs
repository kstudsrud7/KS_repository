// Decompiled with JetBrains decompiler
// Type: TPCourt.EarlyBound.team
// Assembly: TPCourt.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: 615270E2-97DB-4878-8B8F-88925A0FA667
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPCourtFrameworkPlugIn-41F62F3A-2F19-44F2-86DD-4C4AA2D959EF\TPCourtFrameworkPlugIn.dll

using Microsoft.Crm.Sdk.Messages;
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
  [EntityLogicalName("team")]
  [GeneratedCode("XrmToolkit", "4.0")]
  [DataContract(Name = "Entity", Namespace = "http://schemas.microsoft.com/xrm/2011/Contracts")]
  public class team : BaseProxyClass
  {
    public const string LogicalName = "team";
    public const int ObjectTypeCode = 9;
    public const string PrimaryIdAttribute = "teamid";
    public const string PrimaryNameAttribute = "name";
    private static Dictionary<string, BaseProxyClass.eTextOptions> _textOptions;
    private static Dictionary<string, BaseProxyClass.eNumberOptions> _numberOptions;
    private static Dictionary<string, string> _errorStrings;

    static team()
    {
      BaseProxyClass.RegisterProxyType(typeof (team), nameof (team));
      team._textOptions = new Dictionary<string, BaseProxyClass.eTextOptions>();
      team._numberOptions = new Dictionary<string, BaseProxyClass.eNumberOptions>();
      team._errorStrings = new Dictionary<string, string>();
      team.TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
      team.NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
    }

    public team()
      : base(new Entity(nameof (team)))
    {
    }

    public team(Entity original)
      : base(original)
    {
    }

    public static string GetLogicalName() => BaseProxyClass.GetLogicalName<team>();

    public static BaseProxyClass.eTextOptions TextOptions { get; set; }

    public static void SetTextOptions(
      string logicalName,
      BaseProxyClass.eTextOptions options,
      string errorString = null)
    {
      if (team._textOptions.ContainsKey(logicalName))
        team._textOptions[logicalName] = options;
      else
        team._textOptions.Add(logicalName, options);
      if (!string.IsNullOrEmpty(errorString))
      {
        if (team._errorStrings.ContainsKey(logicalName))
          team._errorStrings[logicalName] = errorString;
        else
          team._errorStrings.Add(logicalName, errorString);
      }
      else
      {
        if (!team._errorStrings.ContainsKey(logicalName))
          return;
        team._errorStrings.Remove(logicalName);
      }
    }

    protected override BaseProxyClass.eTextOptions GetTextOptions(string logicalName)
    {
      return team._textOptions.ContainsKey(logicalName) ? team._textOptions[logicalName] : team.TextOptions;
    }

    public static BaseProxyClass.eNumberOptions NumberOptions { get; set; }

    public static void SetNumberOptions(
      string logicalName,
      BaseProxyClass.eNumberOptions options,
      string errorString = null)
    {
      if (team._numberOptions.ContainsKey(logicalName))
        team._numberOptions[logicalName] = options;
      else
        team._numberOptions.Add(logicalName, options);
      if (!string.IsNullOrEmpty(errorString))
      {
        if (team._errorStrings.ContainsKey(logicalName))
          team._errorStrings[logicalName] = errorString;
        else
          team._errorStrings.Add(logicalName, errorString);
      }
      else
      {
        if (!team._errorStrings.ContainsKey(logicalName))
          return;
        team._errorStrings.Remove(logicalName);
      }
    }

    protected override BaseProxyClass.eNumberOptions GetNumberOptions(string logicalName)
    {
      return team._numberOptions.ContainsKey(logicalName) ? team._numberOptions[logicalName] : team.NumberOptions;
    }

    protected override string GetErrorString(
      string attributeName,
      BaseProxyClass.eErrorType defaultErrorType)
    {
      return team._errorStrings.ContainsKey(attributeName) ? team._errorStrings[attributeName] : (defaultErrorType == BaseProxyClass.eErrorType.Text ? team.TextError : team.NumberError);
    }

    public static string TextError { get; set; }

    public static string NumberError { get; set; }

    [AttributeLogicalName("administratorid")]
    public EntityReference administratorid
    {
      get => this.GetPropertyValue<EntityReference>(nameof (administratorid));
      set
      {
        this.SetPropertyValue<EntityReference>(nameof (administratorid), value, nameof (administratorid));
      }
    }

    [AttributeLogicalName("administratoridname")]
    public string administratoridname
    {
      get => this.GetPropertyValue<string>(nameof (administratoridname));
    }

    [AttributeLogicalName("administratoridyominame")]
    public string administratoridyominame
    {
      get => this.GetPropertyValue<string>(nameof (administratoridyominame));
    }

    [AttributeLogicalName("azureactivedirectoryobjectid")]
    public Guid azureactivedirectoryobjectid
    {
      get => this.GetPropertyValue<Guid>(nameof (azureactivedirectoryobjectid));
      set
      {
        this.SetPropertyValue<Guid>(nameof (azureactivedirectoryobjectid), value, nameof (azureactivedirectoryobjectid));
      }
    }

    [AttributeLogicalName("businessunitid")]
    public EntityReference businessunitid
    {
      get => this.GetPropertyValue<EntityReference>(nameof (businessunitid));
      set
      {
        this.SetPropertyValue<EntityReference>(nameof (businessunitid), value, nameof (businessunitid));
      }
    }

    [AttributeLogicalName("businessunitidname")]
    public string businessunitidname => this.GetPropertyValue<string>(nameof (businessunitidname));

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

    [AttributeLogicalName("emailaddress")]
    public string emailaddress
    {
      get => this.GetPropertyValue<string>(nameof (emailaddress));
      set => this.SetPropertyValue(nameof (emailaddress), value, 100, nameof (emailaddress));
    }

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

    [AttributeLogicalName("isdefault")]
    public bool? isdefault => this.GetPropertyValue<bool?>(nameof (isdefault));

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
      set => this.SetPropertyValue(nameof (name), value, 160, nameof (name));
    }

    [AttributeLogicalName("organizationid")]
    public Guid organizationid => this.GetPropertyValue<Guid>(nameof (organizationid));

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

    [AttributeLogicalName("processid")]
    public Guid processid
    {
      get => this.GetPropertyValue<Guid>(nameof (processid));
      set => this.SetPropertyValue<Guid>(nameof (processid), value, nameof (processid));
    }

    [AttributeLogicalName("queueid")]
    public EntityReference queueid
    {
      get => this.GetPropertyValue<EntityReference>(nameof (queueid));
      set => this.SetPropertyValue<EntityReference>(nameof (queueid), value, nameof (queueid));
    }

    [AttributeLogicalName("queueidname")]
    public string queueidname => this.GetPropertyValue<string>(nameof (queueidname));

    [AttributeLogicalName("regardingobjectid")]
    public EntityReference regardingobjectid
    {
      get => this.GetPropertyValue<EntityReference>(nameof (regardingobjectid));
      set
      {
        this.SetPropertyValue<EntityReference>(nameof (regardingobjectid), value, nameof (regardingobjectid));
      }
    }

    [AttributeLogicalName("regardingobjecttypecode")]
    public string regardingobjecttypecode
    {
      get => this.GetPropertyValue<string>(nameof (regardingobjecttypecode));
      set
      {
        this.SetPropertyValue<string>(nameof (regardingobjecttypecode), value, nameof (regardingobjecttypecode));
      }
    }

    [AttributeLogicalName("stageid")]
    public Guid stageid
    {
      get => this.GetPropertyValue<Guid>(nameof (stageid));
      set => this.SetPropertyValue<Guid>(nameof (stageid), value, nameof (stageid));
    }

    [AttributeLogicalName("systemmanaged")]
    public bool? systemmanaged => this.GetPropertyValue<bool?>(nameof (systemmanaged));

    [AttributeLogicalName("teamid")]
    public Guid teamid
    {
      get => this.Id;
      set
      {
        this.Id = value;
        this.SetPropertyValue<Guid>(nameof (teamid), value, nameof (teamid));
      }
    }

    [AttributeLogicalName("teamtemplateid")]
    public EntityReference teamtemplateid
    {
      get => this.GetPropertyValue<EntityReference>(nameof (teamtemplateid));
      set
      {
        this.SetPropertyValue<EntityReference>(nameof (teamtemplateid), value, nameof (teamtemplateid));
      }
    }

    [AttributeLogicalName("teamtype")]
    public eTeam_type? teamtype
    {
      get
      {
        return this.teamtype_OptionSetValue != null ? new eTeam_type?((eTeam_type) this.teamtype_OptionSetValue.Value) : new eTeam_type?();
      }
      set
      {
        if (value.HasValue)
          this.teamtype_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.teamtype_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("teamtype")]
    public OptionSetValue teamtype_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("teamtype");
      set
      {
        this.SetPropertyValue<OptionSetValue>("teamtype", value, nameof (teamtype_OptionSetValue));
      }
    }

    public string teamtype_Text(IOrganizationService service)
    {
      return this.teamtype_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "teamtype");
    }

    public string teamtype_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.teamtype_OptionSetValue.Value);
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

    [AttributeLogicalName("traversedpath")]
    public string traversedpath
    {
      get => this.GetPropertyValue<string>(nameof (traversedpath));
      set => this.SetPropertyValue(nameof (traversedpath), value, 1250, nameof (traversedpath));
    }

    [AttributeLogicalName("versionnumber")]
    public int? versionnumber => this.GetPropertyValue<int?>(nameof (versionnumber));

    [AttributeLogicalName("yominame")]
    public string yominame
    {
      get => this.GetPropertyValue<string>(nameof (yominame));
      set => this.SetPropertyValue(nameof (yominame), value, 160, nameof (yominame));
    }

    public List<account> Getteam_accounts(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<account>(service, this.Id, "account", "owningteam", columns);
    }

    public List<account> Getteam_accounts(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<account>(service, this.Id, "account", "owningteam", columns);
    }

    public List<Entity> Getteam_actioncardusersettings(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "actioncardusersettings", "owningteam", columns);
    }

    public List<Entity> Getteam_actioncardusersettings(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "actioncardusersettings", "owningteam", columns);
    }

    public List<Entity> Getteam_activity(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "activitypointer", "owningteam", columns);
    }

    public List<Entity> Getteam_activity(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "activitypointer", "owningteam", columns);
    }

    public List<Entity> Getteam_adminsettingsentity(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "adminsettingsentity", "owningteam", columns);
    }

    public List<Entity> Getteam_adminsettingsentity(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "adminsettingsentity", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_birthrecord(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_birthrecord", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_birthrecord(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_birthrecord", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_bloodquantum(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_bloodquantum", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_bloodquantum(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_bloodquantum", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_cardhistory(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_cardhistory", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_cardhistory(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_cardhistory", "owningteam", columns);
    }

    public List<ait_casenote> Getteam_ait_casenote(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_casenote>(service, this.Id, "ait_casenote", "owningteam", columns);
    }

    public List<ait_casenote> Getteam_ait_casenote(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_casenote>(service, this.Id, "ait_casenote", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_charge(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_charge", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_charge(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_charge", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_company(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_company", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_company(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_company", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_contactcertification(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contactcertification", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_contactcertification(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contactcertification", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_contacteducation(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contacteducation", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_contacteducation(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contacteducation", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_contactemployment(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contactemployment", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_contactemployment(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contactemployment", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_contactimage(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contactimage", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_contactimage(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contactimage", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_contactincarceration(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contactincarceration", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_contactincarceration(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contactincarceration", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_contactincomeandexpense(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contactincomeandexpense", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_contactincomeandexpense(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contactincomeandexpense", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_contactlanguage(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contactlanguage", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_contactlanguage(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contactlanguage", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_contactmilitaryservice(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contactmilitaryservice", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_contactmilitaryservice(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contactmilitaryservice", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_contactname(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contactname", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_contactname(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contactname", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_contactskill(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contactskill", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_contactskill(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_contactskill", "owningteam", columns);
    }

    public List<ait_courtcase> Getteam_ait_courtcase(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_courtcase>(service, this.Id, "ait_courtcase", "owningteam", columns);
    }

    public List<ait_courtcase> Getteam_ait_courtcase(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_courtcase>(service, this.Id, "ait_courtcase", "owningteam", columns);
    }

    public List<ait_courtfinesandfees> Getteam_ait_courtfinesandfees(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_courtfinesandfees>(service, this.Id, "ait_courtfinesandfees", "owningteam", columns);
    }

    public List<ait_courtfinesandfees> Getteam_ait_courtfinesandfees(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_courtfinesandfees>(service, this.Id, "ait_courtfinesandfees", "owningteam", columns);
    }

    public List<ait_courtparty> Getteam_ait_courtparty(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_courtparty>(service, this.Id, "ait_courtparty", "owningteam", columns);
    }

    public List<ait_courtparty> Getteam_ait_courtparty(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_courtparty>(service, this.Id, "ait_courtparty", "owningteam", columns);
    }

    public List<ait_courtpayments> Getteam_ait_courtpayments(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_courtpayments>(service, this.Id, "ait_courtpayments", "owningteam", columns);
    }

    public List<ait_courtpayments> Getteam_ait_courtpayments(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_courtpayments>(service, this.Id, "ait_courtpayments", "owningteam", columns);
    }

    public List<ait_courtprofile> Getteam_ait_courtprofile(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_courtprofile>(service, this.Id, "ait_courtprofile", "owningteam", columns);
    }

    public List<ait_courtprofile> Getteam_ait_courtprofile(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_courtprofile>(service, this.Id, "ait_courtprofile", "owningteam", columns);
    }

    public List<ait_courtprofileaddress> Getteam_ait_courtprofileaddress(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_courtprofileaddress>(service, this.Id, "ait_courtprofileaddress", "owningteam", columns);
    }

    public List<ait_courtprofileaddress> Getteam_ait_courtprofileaddress(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_courtprofileaddress>(service, this.Id, "ait_courtprofileaddress", "owningteam", columns);
    }

    public List<ait_courtroom> Getteam_ait_courtroom(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_courtroom>(service, this.Id, "ait_courtroom", "owningteam", columns);
    }

    public List<ait_courtroom> Getteam_ait_courtroom(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_courtroom>(service, this.Id, "ait_courtroom", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_datamigrationhistory(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_datamigrationhistory", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_datamigrationhistory(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_datamigrationhistory", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_deathrecord(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_deathrecord", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_deathrecord(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_deathrecord", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_electronicaddress(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_electronicaddress", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_electronicaddress(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_electronicaddress", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_emergencycontact(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_emergencycontact", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_emergencycontact(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_emergencycontact", "owningteam", columns);
    }

    public List<Entity> Getait_hearing_team_owningteam(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_hearing", "owningteam", columns);
    }

    public List<Entity> Getait_hearing_team_owningteam(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_hearing", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_household(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_household", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_household(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_household", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_householdmember(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_householdmember", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_householdmember(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_householdmember", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_memberprofile(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_memberprofile", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_memberprofile(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_memberprofile", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_memberprofilemembershipcategory(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_memberprofilemembershipcategory", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_memberprofilemembershipcategory(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_memberprofilemembershipcategory", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_memberroll(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_memberroll", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_memberroll(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_memberroll", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_membershipstatuschangerequest(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_membershipstatuschangerequest", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_membershipstatuschangerequest(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_membershipstatuschangerequest", "owningteam", columns);
    }

    public List<ait_physicaladdress> Getteam_ait_physicaladdress(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_physicaladdress>(service, this.Id, "ait_physicaladdress", "owningteam", columns);
    }

    public List<ait_physicaladdress> Getteam_ait_physicaladdress(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_physicaladdress>(service, this.Id, "ait_physicaladdress", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_relationship(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_relationship", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_relationship(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_relationship", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_resolution(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_resolution", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_resolution(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_resolution", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_school(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_school", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_school(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_school", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_statute(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_statute", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_statute(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_statute", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_training(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_training", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_training(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_training", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_trainingtype(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_trainingtype", "owningteam", columns);
    }

    public List<Entity> Getteam_ait_trainingtype(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_trainingtype", "owningteam", columns);
    }

    public List<ait_tribalenrollmentconfiguration> Getteam_ait_tribalenrollmentconfiguration(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_tribalenrollmentconfiguration>(service, this.Id, "ait_tribalenrollmentconfiguration", "owningteam", columns);
    }

    public List<ait_tribalenrollmentconfiguration> Getteam_ait_tribalenrollmentconfiguration(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_tribalenrollmentconfiguration>(service, this.Id, "ait_tribalenrollmentconfiguration", "owningteam", columns);
    }

    public List<Entity> Getteam_annotations(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "annotation", "owningteam", columns);
    }

    public List<Entity> Getteam_annotations(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "annotation", "owningteam", columns);
    }

    public List<appointment> Getteam_appointment(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<appointment>(service, this.Id, "appointment", "owningteam", columns);
    }

    public List<appointment> Getteam_appointment(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<appointment>(service, this.Id, "appointment", "owningteam", columns);
    }

    public List<Entity> Getteam_asyncoperation(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "asyncoperation", "owningteam", columns);
    }

    public List<Entity> Getteam_asyncoperation(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "asyncoperation", "owningteam", columns);
    }

    public List<Entity> GetTeam_AsyncOperations(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "asyncoperation", "regardingobjectid", columns);
    }

    public List<Entity> GetTeam_AsyncOperations(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "asyncoperation", "regardingobjectid", columns);
    }

    public List<Entity> Getteam_bookableresource(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bookableresource", "owningteam", columns);
    }

    public List<Entity> Getteam_bookableresource(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bookableresource", "owningteam", columns);
    }

    public List<Entity> Getteam_bookableresourcebooking(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bookableresourcebooking", "owningteam", columns);
    }

    public List<Entity> Getteam_bookableresourcebooking(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bookableresourcebooking", "owningteam", columns);
    }

    public List<Entity> Getteam_bookableresourcebookingexchangesyncidmapping(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bookableresourcebookingexchangesyncidmapping", "owningteam", columns);
    }

    public List<Entity> Getteam_bookableresourcebookingexchangesyncidmapping(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bookableresourcebookingexchangesyncidmapping", "owningteam", columns);
    }

    public List<Entity> Getteam_bookableresourcebookingheader(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bookableresourcebookingheader", "owningteam", columns);
    }

    public List<Entity> Getteam_bookableresourcebookingheader(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bookableresourcebookingheader", "owningteam", columns);
    }

    public List<Entity> Getteam_bookableresourcecategory(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bookableresourcecategory", "owningteam", columns);
    }

    public List<Entity> Getteam_bookableresourcecategory(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bookableresourcecategory", "owningteam", columns);
    }

    public List<Entity> Getteam_bookableresourcecategoryassn(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bookableresourcecategoryassn", "owningteam", columns);
    }

    public List<Entity> Getteam_bookableresourcecategoryassn(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bookableresourcecategoryassn", "owningteam", columns);
    }

    public List<Entity> Getteam_bookableresourcecharacteristic(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bookableresourcecharacteristic", "owningteam", columns);
    }

    public List<Entity> Getteam_bookableresourcecharacteristic(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bookableresourcecharacteristic", "owningteam", columns);
    }

    public List<Entity> Getteam_bookableresourcegroup(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bookableresourcegroup", "owningteam", columns);
    }

    public List<Entity> Getteam_bookableresourcegroup(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bookableresourcegroup", "owningteam", columns);
    }

    public List<Entity> Getteam_bookingstatus(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bookingstatus", "owningteam", columns);
    }

    public List<Entity> Getteam_bookingstatus(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bookingstatus", "owningteam", columns);
    }

    public List<Entity> GetTeam_BulkDeleteFailures(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bulkdeletefailure", "regardingobjectid", columns);
    }

    public List<Entity> GetTeam_BulkDeleteFailures(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bulkdeletefailure", "regardingobjectid", columns);
    }

    public List<Entity> Getteam_BulkOperation(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bulkoperation", "owningteam", columns);
    }

    public List<Entity> Getteam_BulkOperation(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bulkoperation", "owningteam", columns);
    }

    public List<Entity> Getteam_bulkoperationlog(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bulkoperationlog", "owningteam", columns);
    }

    public List<Entity> Getteam_bulkoperationlog(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bulkoperationlog", "owningteam", columns);
    }

    public List<Entity> Getteam_Campaigns(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "campaign", "owningteam", columns);
    }

    public List<Entity> Getteam_Campaigns(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "campaign", "owningteam", columns);
    }

    public List<Entity> Getteam_campaignactivity(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "campaignactivity", "owningteam", columns);
    }

    public List<Entity> Getteam_campaignactivity(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "campaignactivity", "owningteam", columns);
    }

    public List<Entity> Getteam_campaignresponse(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "campaignresponse", "owningteam", columns);
    }

    public List<Entity> Getteam_campaignresponse(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "campaignresponse", "owningteam", columns);
    }

    public List<Entity> Getteam_canvasappextendedmetadata(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "canvasappextendedmetadata", "owningteam", columns);
    }

    public List<Entity> Getteam_canvasappextendedmetadata(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "canvasappextendedmetadata", "owningteam", columns);
    }

    public List<Entity> Getteam_channelaccessprofile(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "channelaccessprofile", "owningteam", columns);
    }

    public List<Entity> Getteam_channelaccessprofile(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "channelaccessprofile", "owningteam", columns);
    }

    public List<Entity> Getteam_profilerule(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "channelaccessprofilerule", "owningteam", columns);
    }

    public List<Entity> Getteam_profilerule(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "channelaccessprofilerule", "owningteam", columns);
    }

    public List<Entity> Getteam_characteristic(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "characteristic", "owningteam", columns);
    }

    public List<Entity> Getteam_characteristic(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "characteristic", "owningteam", columns);
    }

    public List<connection> Getteam_connections1(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<connection>(service, this.Id, "connection", "record1id", columns);
    }

    public List<connection> Getteam_connections1(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<connection>(service, this.Id, "connection", "record1id", columns);
    }

    public List<connection> Getteam_connections2(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<connection>(service, this.Id, "connection", "record2id", columns);
    }

    public List<connection> Getteam_connections2(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<connection>(service, this.Id, "connection", "record2id", columns);
    }

    public List<Entity> Getteam_connectionreference(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "connectionreference", "owningteam", columns);
    }

    public List<Entity> Getteam_connectionreference(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "connectionreference", "owningteam", columns);
    }

    public List<Entity> Getteam_connector(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "connector", "owningteam", columns);
    }

    public List<Entity> Getteam_connector(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "connector", "owningteam", columns);
    }

    public List<contact> Getteam_contacts(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<contact>(service, this.Id, "contact", "owningteam", columns);
    }

    public List<contact> Getteam_contacts(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<contact>(service, this.Id, "contact", "owningteam", columns);
    }

    public List<Entity> Getteam_service_contracts(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "contract", "owningteam", columns);
    }

    public List<Entity> Getteam_service_contracts(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "contract", "owningteam", columns);
    }

    public List<Entity> Getteam_contractdetail(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "contractdetail", "owningteam", columns);
    }

    public List<Entity> Getteam_contractdetail(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "contractdetail", "owningteam", columns);
    }

    public List<Entity> Getteam_convertrule(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "convertrule", "owningteam", columns);
    }

    public List<Entity> Getteam_convertrule(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "convertrule", "owningteam", columns);
    }

    public List<Entity> Getteam_customer_opportunity_roles(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "customeropportunityrole", "owningteam", columns);
    }

    public List<Entity> Getteam_customer_opportunity_roles(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "customeropportunityrole", "owningteam", columns);
    }

    public List<Entity> Getteam_customer_relationship(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "customerrelationship", "owningteam", columns);
    }

    public List<Entity> Getteam_customer_relationship(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "customerrelationship", "owningteam", columns);
    }

    public List<Entity> GetTeam_DuplicateBaseRecord(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "duplicaterecord", "baserecordid", columns);
    }

    public List<Entity> GetTeam_DuplicateBaseRecord(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "duplicaterecord", "baserecordid", columns);
    }

    public List<Entity> GetTeam_DuplicateMatchingRecord(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "duplicaterecord", "duplicaterecordid", columns);
    }

    public List<Entity> GetTeam_DuplicateMatchingRecord(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "duplicaterecord", "duplicaterecordid", columns);
    }

    public List<Entity> Getteam_DuplicateRules(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "duplicaterule", "owningteam", columns);
    }

    public List<Entity> Getteam_DuplicateRules(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "duplicaterule", "owningteam", columns);
    }

    public List<Entity> Getteam_DynamicPropertyInstance(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "dynamicpropertyinstance", "owningteam", columns);
    }

    public List<Entity> Getteam_DynamicPropertyInstance(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "dynamicpropertyinstance", "owningteam", columns);
    }

    public List<Entity> Getteam_email(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "email", "owningteam", columns);
    }

    public List<Entity> Getteam_email(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "email", "owningteam", columns);
    }

    public List<Entity> Getteam_emailserverprofile(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "emailserverprofile", "owningteam", columns);
    }

    public List<Entity> Getteam_emailserverprofile(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "emailserverprofile", "owningteam", columns);
    }

    public List<Entity> Getteam_entitlement(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "entitlement", "owningteam", columns);
    }

    public List<Entity> Getteam_entitlement(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "entitlement", "owningteam", columns);
    }

    public List<Entity> Getteam_entitlementchannel(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "entitlementchannel", "owningteam", columns);
    }

    public List<Entity> Getteam_entitlementchannel(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "entitlementchannel", "owningteam", columns);
    }

    public List<Entity> Getteam_entitlemententityallocationtypemapping(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "entitlemententityallocationtypemapping", "owningteam", columns);
    }

    public List<Entity> Getteam_entitlemententityallocationtypemapping(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "entitlemententityallocationtypemapping", "owningteam", columns);
    }

    public List<Entity> Getteam_environmentvariabledefinition(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "environmentvariabledefinition", "owningteam", columns);
    }

    public List<Entity> Getteam_environmentvariabledefinition(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "environmentvariabledefinition", "owningteam", columns);
    }

    public List<Entity> Getteam_environmentvariablevalue(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "environmentvariablevalue", "owningteam", columns);
    }

    public List<Entity> Getteam_environmentvariablevalue(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "environmentvariablevalue", "owningteam", columns);
    }

    public List<Entity> Getteam_exchangesyncidmapping(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "exchangesyncidmapping", "owningteam", columns);
    }

    public List<Entity> Getteam_exchangesyncidmapping(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "exchangesyncidmapping", "owningteam", columns);
    }

    public List<Entity> Getteam_externalparty(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "externalparty", "owningteam", columns);
    }

    public List<Entity> Getteam_externalparty(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "externalparty", "owningteam", columns);
    }

    public List<Entity> Getteam_fax(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "fax", "owningteam", columns);
    }

    public List<Entity> Getteam_fax(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "fax", "owningteam", columns);
    }

    public List<Entity> Getteam_flowsession(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "flowsession", "owningteam", columns);
    }

    public List<Entity> Getteam_flowsession(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "flowsession", "owningteam", columns);
    }

    public List<Entity> Getteam_goal(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "goal", "owningteam", columns);
    }

    public List<Entity> Getteam_goal(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "goal", "owningteam", columns);
    }

    public List<Entity> Getteam_goal_goalowner(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "goal", "goalownerid", columns);
    }

    public List<Entity> Getteam_goal_goalowner(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "goal", "goalownerid", columns);
    }

    public List<Entity> Getteam_goalrollupquery(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "goalrollupquery", "owningteam", columns);
    }

    public List<Entity> Getteam_goalrollupquery(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "goalrollupquery", "owningteam", columns);
    }

    public List<Entity> Getteam_Imports(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "import", "owningteam", columns);
    }

    public List<Entity> Getteam_Imports(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "import", "owningteam", columns);
    }

    public List<Entity> Getteam_ImportData(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "importdata", "owningteam", columns);
    }

    public List<Entity> Getteam_ImportData(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "importdata", "owningteam", columns);
    }

    public List<Entity> GetImportFile_Team(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "importfile", "recordsownerid", columns);
    }

    public List<Entity> GetImportFile_Team(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "importfile", "recordsownerid", columns);
    }

    public List<Entity> Getteam_ImportFiles(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "importfile", "owningteam", columns);
    }

    public List<Entity> Getteam_ImportFiles(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "importfile", "owningteam", columns);
    }

    public List<Entity> Getteam_ImportLogs(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "importlog", "owningteam", columns);
    }

    public List<Entity> Getteam_ImportLogs(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "importlog", "owningteam", columns);
    }

    public List<Entity> Getteam_ImportMaps(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "importmap", "owningteam", columns);
    }

    public List<Entity> Getteam_ImportMaps(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "importmap", "owningteam", columns);
    }

    public List<Entity> Getteam_incidents(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "incident", "owningteam", columns);
    }

    public List<Entity> Getteam_incidents(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "incident", "owningteam", columns);
    }

    public List<Entity> Getteam_incidentresolution(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "incidentresolution", "owningteam", columns);
    }

    public List<Entity> Getteam_incidentresolution(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "incidentresolution", "owningteam", columns);
    }

    public List<Entity> Getteam_interactionforemail(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "interactionforemail", "owningteam", columns);
    }

    public List<Entity> Getteam_interactionforemail(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "interactionforemail", "owningteam", columns);
    }

    public List<Entity> Getteam_invoices(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "invoice", "owningteam", columns);
    }

    public List<Entity> Getteam_invoices(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "invoice", "owningteam", columns);
    }

    public List<Entity> Getteam_invoicedetail(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "invoicedetail", "owningteam", columns);
    }

    public List<Entity> Getteam_invoicedetail(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "invoicedetail", "owningteam", columns);
    }

    public List<Entity> Getteam_knowledgearticle(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "knowledgearticle", "owningteam", columns);
    }

    public List<Entity> Getteam_knowledgearticle(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "knowledgearticle", "owningteam", columns);
    }

    public List<Entity> Getteam_knowledgearticleincident(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "knowledgearticleincident", "owningteam", columns);
    }

    public List<Entity> Getteam_knowledgearticleincident(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "knowledgearticleincident", "owningteam", columns);
    }

    public List<Entity> Getlead_owning_team(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "lead", "owningteam", columns);
    }

    public List<Entity> Getlead_owning_team(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "lead", "owningteam", columns);
    }

    public List<Entity> Getteam_letter(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "letter", "owningteam", columns);
    }

    public List<Entity> Getteam_letter(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "letter", "owningteam", columns);
    }

    public List<Entity> Getteam_list(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "list", "owningteam", columns);
    }

    public List<Entity> Getteam_list(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "list", "owningteam", columns);
    }

    public List<Entity> Getteam_listoperation(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "listoperation", "owningteam", columns);
    }

    public List<Entity> Getteam_listoperation(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "listoperation", "owningteam", columns);
    }

    public List<Entity> Getteam_mailbox(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "mailbox", "owningteam", columns);
    }

    public List<Entity> Getteam_mailbox(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "mailbox", "owningteam", columns);
    }

    public List<Entity> Getteam_mailboxtrackingcategory(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "mailboxtrackingcategory", "owningteam", columns);
    }

    public List<Entity> Getteam_mailboxtrackingcategory(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "mailboxtrackingcategory", "owningteam", columns);
    }

    public List<Entity> Getteam_mailboxtrackingfolder(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "mailboxtrackingfolder", "owningteam", columns);
    }

    public List<Entity> Getteam_mailboxtrackingfolder(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "mailboxtrackingfolder", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_actioncardregarding(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_actioncardregarding", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_actioncardregarding(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_actioncardregarding", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_actioncardrolesetting(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_actioncardrolesetting", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_actioncardrolesetting(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_actioncardrolesetting", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_aibdataset(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_aibdataset", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_aibdataset(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_aibdataset", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_aibdatasetfile(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_aibdatasetfile", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_aibdatasetfile(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_aibdatasetfile", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_aibdatasetrecord(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_aibdatasetrecord", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_aibdatasetrecord(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_aibdatasetrecord", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_aibdatasetscontainer(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_aibdatasetscontainer", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_aibdatasetscontainer(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_aibdatasetscontainer", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_aibfile(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_aibfile", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_aibfile(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_aibfile", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_aibfileattacheddata(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_aibfileattacheddata", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_aibfileattacheddata(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_aibfileattacheddata", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_aiconfiguration(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_aiconfiguration", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_aiconfiguration(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_aiconfiguration", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_aifptrainingdocument(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_aifptrainingdocument", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_aifptrainingdocument(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_aifptrainingdocument", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_aimodel(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_aimodel", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_aimodel(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_aimodel", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_aiodimage(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_aiodimage", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_aiodimage(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_aiodimage", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_aiodlabel(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_aiodlabel", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_aiodlabel(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_aiodlabel", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_aiodtrainingboundingbox(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_aiodtrainingboundingbox", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_aiodtrainingboundingbox(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_aiodtrainingboundingbox", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_aiodtrainingimage(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_aiodtrainingimage", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_aiodtrainingimage(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_aiodtrainingimage", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_aitemplate(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_aitemplate", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_aitemplate(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_aitemplate", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_analysiscomponent(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_analysiscomponent", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_analysiscomponent(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_analysiscomponent", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_analysisjob(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_analysisjob", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_analysisjob(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_analysisjob", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_analysisresult(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_analysisresult", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_analysisresult(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_analysisresult", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_analysisresultdetail(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_analysisresultdetail", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_analysisresultdetail(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_analysisresultdetail", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_analyticsadminsettings(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_analyticsadminsettings", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_analyticsadminsettings(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_analyticsadminsettings", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_analyticsforcs(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_analyticsforcs", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_analyticsforcs(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_analyticsforcs", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_autocapturerule(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_autocapturerule", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_autocapturerule(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_autocapturerule", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_autocapturesettings(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_autocapturesettings", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_autocapturesettings(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_autocapturesettings", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_callablecontext(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_callablecontext", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_callablecontext(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_callablecontext", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_customerasset(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_customerasset", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_customerasset(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_customerasset", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_customerassetcategory(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_customerassetcategory", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_customerassetcategory(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_customerassetcategory", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_dataanalyticsreport(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_dataanalyticsreport", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_dataanalyticsreport(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_dataanalyticsreport", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_dataflow(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_dataflow", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_dataflow(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_dataflow", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_entityrankingrule(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_entityrankingrule", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_entityrankingrule(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_entityrankingrule", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_flowcardtype(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_flowcardtype", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_flowcardtype(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_flowcardtype", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_forecastconfiguration(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_forecastconfiguration", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_forecastconfiguration(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_forecastconfiguration", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_forecastdefinition(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_forecastdefinition", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_forecastdefinition(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_forecastdefinition", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_forecastinstance(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_forecastinstance", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_forecastinstance(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_forecastinstance", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_forecastrecurrence(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_forecastrecurrence", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_forecastrecurrence(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_forecastrecurrence", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_icebreakersconfig(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_icebreakersconfig", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_icebreakersconfig(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_icebreakersconfig", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_iotalert(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iotalert", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_iotalert(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iotalert", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_iotdevice(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iotdevice", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_iotdevice(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iotdevice", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_iotdevicecategory(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iotdevicecategory", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_iotdevicecategory(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iotdevicecategory", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_iotdevicecommand(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iotdevicecommand", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_iotdevicecommand(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iotdevicecommand", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_iotdevicecommanddefinition(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iotdevicecommanddefinition", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_iotdevicecommanddefinition(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iotdevicecommanddefinition", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_iotdevicedatahistory(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iotdevicedatahistory", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_iotdevicedatahistory(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iotdevicedatahistory", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_iotdeviceproperty(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iotdeviceproperty", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_iotdeviceproperty(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iotdeviceproperty", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_iotdeviceregistrationhistory(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iotdeviceregistrationhistory", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_iotdeviceregistrationhistory(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iotdeviceregistrationhistory", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_iotdevicevisualizationconfiguration(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iotdevicevisualizationconfiguration", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_iotdevicevisualizationconfiguration(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iotdevicevisualizationconfiguration", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_iotfieldmapping(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iotfieldmapping", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_iotfieldmapping(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iotfieldmapping", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_iotpropertydefinition(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iotpropertydefinition", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_iotpropertydefinition(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iotpropertydefinition", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_iotprovider(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iotprovider", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_iotprovider(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iotprovider", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_iotproviderinstance(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iotproviderinstance", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_iotproviderinstance(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iotproviderinstance", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_iotsettings(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iotsettings", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_iotsettings(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_iotsettings", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_knowledgearticleimage(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_knowledgearticleimage", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_knowledgearticleimage(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_knowledgearticleimage", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_knowledgearticletemplate(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_knowledgearticletemplate", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_knowledgearticletemplate(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_knowledgearticletemplate", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_msteamssetting(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_msteamssetting", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_msteamssetting(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_msteamssetting", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_notesanalysisconfig(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_notesanalysisconfig", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_notesanalysisconfig(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_notesanalysisconfig", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_playbookactivity(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_playbookactivity", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_playbookactivity(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_playbookactivity", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_playbookactivityattribute(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_playbookactivityattribute", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_playbookactivityattribute(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_playbookactivityattribute", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_playbookcategory(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_playbookcategory", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_playbookcategory(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_playbookcategory", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_playbookinstance(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_playbookinstance", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_playbookinstance(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_playbookinstance", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_playbooktemplate(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_playbooktemplate", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_playbooktemplate(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_playbooktemplate", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_postalbum(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_postalbum", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_postalbum(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_postalbum", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_relationshipinsightsunifiedconfig(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_relationshipinsightsunifiedconfig", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_relationshipinsightsunifiedconfig(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_relationshipinsightsunifiedconfig", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_salesinsightssettings(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_salesinsightssettings", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_salesinsightssettings(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_salesinsightssettings", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_serviceconfiguration(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_serviceconfiguration", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_serviceconfiguration(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_serviceconfiguration", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_siconfig(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_siconfig", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_siconfig(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_siconfig", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_slakpi(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_slakpi", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_slakpi(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_slakpi", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_solutionhealthrule(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_solutionhealthrule", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_solutionhealthrule(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_solutionhealthrule", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_solutionhealthruleargument(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_solutionhealthruleargument", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_solutionhealthruleargument(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_solutionhealthruleargument", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_untrackedappointment(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_untrackedappointment", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_untrackedappointment(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_untrackedappointment", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_wallsavedqueryusersettings(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_wallsavedqueryusersettings", "owningteam", columns);
    }

    public List<Entity> Getteam_msdyn_wallsavedqueryusersettings(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msdyn_wallsavedqueryusersettings", "owningteam", columns);
    }

    public List<Entity> Getteam_msfp_emailtemplate(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msfp_emailtemplate", "owningteam", columns);
    }

    public List<Entity> Getteam_msfp_emailtemplate(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msfp_emailtemplate", "owningteam", columns);
    }

    public List<Entity> Getteam_msfp_localizedemailtemplate(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msfp_localizedemailtemplate", "owningteam", columns);
    }

    public List<Entity> Getteam_msfp_localizedemailtemplate(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msfp_localizedemailtemplate", "owningteam", columns);
    }

    public List<Entity> Getteam_msfp_project(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msfp_project", "owningteam", columns);
    }

    public List<Entity> Getteam_msfp_project(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msfp_project", "owningteam", columns);
    }

    public List<Entity> Getteam_msfp_question(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msfp_question", "owningteam", columns);
    }

    public List<Entity> Getteam_msfp_question(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msfp_question", "owningteam", columns);
    }

    public List<Entity> Getteam_msfp_questionresponse(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msfp_questionresponse", "owningteam", columns);
    }

    public List<Entity> Getteam_msfp_questionresponse(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msfp_questionresponse", "owningteam", columns);
    }

    public List<Entity> Getteam_msfp_satisfactionmetric(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msfp_satisfactionmetric", "owningteam", columns);
    }

    public List<Entity> Getteam_msfp_satisfactionmetric(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msfp_satisfactionmetric", "owningteam", columns);
    }

    public List<Entity> Getteam_msfp_survey(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msfp_survey", "owningteam", columns);
    }

    public List<Entity> Getteam_msfp_survey(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msfp_survey", "owningteam", columns);
    }

    public List<Entity> Getmsfp_surveyinvite_team_owningteam(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msfp_surveyinvite", "owningteam", columns);
    }

    public List<Entity> Getmsfp_surveyinvite_team_owningteam(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msfp_surveyinvite", "owningteam", columns);
    }

    public List<Entity> Getmsfp_surveyresponse_team_owningteam(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msfp_surveyresponse", "owningteam", columns);
    }

    public List<Entity> Getmsfp_surveyresponse_team_owningteam(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msfp_surveyresponse", "owningteam", columns);
    }

    public List<Entity> Getteam_msfp_unsubscribedrecipient(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msfp_unsubscribedrecipient", "owningteam", columns);
    }

    public List<Entity> Getteam_msfp_unsubscribedrecipient(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msfp_unsubscribedrecipient", "owningteam", columns);
    }

    public List<Entity> Getteam_opportunities(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "opportunity", "owningteam", columns);
    }

    public List<Entity> Getteam_opportunities(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "opportunity", "owningteam", columns);
    }

    public List<Entity> Getteam_opportunityclose(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "opportunityclose", "owningteam", columns);
    }

    public List<Entity> Getteam_opportunityclose(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "opportunityclose", "owningteam", columns);
    }

    public List<Entity> Getteam_opportunityproduct(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "opportunityproduct", "owningteam", columns);
    }

    public List<Entity> Getteam_opportunityproduct(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "opportunityproduct", "owningteam", columns);
    }

    public List<Entity> Getteam_orderclose(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "orderclose", "owningteam", columns);
    }

    public List<Entity> Getteam_orderclose(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "orderclose", "owningteam", columns);
    }

    public List<Entity> Getteam_pdfsetting(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "pdfsetting", "owningteam", columns);
    }

    public List<Entity> Getteam_pdfsetting(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "pdfsetting", "owningteam", columns);
    }

    public List<Entity> Getteam_phonecall(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "phonecall", "owningteam", columns);
    }

    public List<Entity> Getteam_phonecall(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "phonecall", "owningteam", columns);
    }

    public List<Entity> GetOwningTeam_postfollows(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "postfollow", "owningteam", columns);
    }

    public List<Entity> GetOwningTeam_postfollows(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "postfollow", "owningteam", columns);
    }

    public List<Entity> Getteam_PostRegardings(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "postregarding", "regardingobjectid", columns);
    }

    public List<Entity> Getteam_PostRegardings(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "postregarding", "regardingobjectid", columns);
    }

    public List<Entity> Getteam_PostRoles(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "postrole", "regardingobjectid", columns);
    }

    public List<Entity> Getteam_PostRoles(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "postrole", "regardingobjectid", columns);
    }

    public List<Entity> Getteam_principalobjectattributeaccess(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "principalobjectattributeaccess", "objectid", columns);
    }

    public List<Entity> Getteam_principalobjectattributeaccess(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "principalobjectattributeaccess", "objectid", columns);
    }

    public List<Entity> Getteam_principalobjectattributeaccess_principalid(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "principalobjectattributeaccess", "principalid", columns);
    }

    public List<Entity> Getteam_principalobjectattributeaccess_principalid(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "principalobjectattributeaccess", "principalid", columns);
    }

    public List<Entity> Getteam_processsession(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "processsession", "owningteam", columns);
    }

    public List<Entity> Getteam_processsession(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "processsession", "owningteam", columns);
    }

    public List<Entity> GetTeam_ProcessSessions(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "processsession", "regardingobjectid", columns);
    }

    public List<Entity> GetTeam_ProcessSessions(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "processsession", "regardingobjectid", columns);
    }

    public List<Entity> Getteam_processstageparameter(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "processstageparameter", "owningteam", columns);
    }

    public List<Entity> Getteam_processstageparameter(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "processstageparameter", "owningteam", columns);
    }

    public List<Entity> Getteam_queueitembase_workerid(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "queueitem", "workerid", columns);
    }

    public List<Entity> Getteam_queueitembase_workerid(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "queueitem", "workerid", columns);
    }

    public List<Entity> Getteam_quotes(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "quote", "owningteam", columns);
    }

    public List<Entity> Getteam_quotes(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "quote", "owningteam", columns);
    }

    public List<Entity> Getteam_quoteclose(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "quoteclose", "owningteam", columns);
    }

    public List<Entity> Getteam_quoteclose(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "quoteclose", "owningteam", columns);
    }

    public List<Entity> Getteam_quotedetail(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "quotedetail", "owningteam", columns);
    }

    public List<Entity> Getteam_quotedetail(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "quotedetail", "owningteam", columns);
    }

    public List<Entity> Getteam_ratingmodel(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ratingmodel", "owningteam", columns);
    }

    public List<Entity> Getteam_ratingmodel(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ratingmodel", "owningteam", columns);
    }

    public List<Entity> Getteam_ratingvalue(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ratingvalue", "owningteam", columns);
    }

    public List<Entity> Getteam_ratingvalue(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ratingvalue", "owningteam", columns);
    }

    public List<Entity> Getteam_recurringappointmentmaster(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "recurringappointmentmaster", "owningteam", columns);
    }

    public List<Entity> Getteam_recurringappointmentmaster(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "recurringappointmentmaster", "owningteam", columns);
    }

    public List<Entity> Getteam_resource_groups(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "resourcegroup", "resourcegroupid", columns);
    }

    public List<Entity> Getteam_resource_groups(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "resourcegroup", "resourcegroupid", columns);
    }

    public List<Entity> Getteam_resource_specs(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "resourcespec", "groupobjectid", columns);
    }

    public List<Entity> Getteam_resource_specs(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "resourcespec", "groupobjectid", columns);
    }

    public List<Entity> Getteam_routingrule(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "routingrule", "owningteam", columns);
    }

    public List<Entity> Getteam_routingrule(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "routingrule", "owningteam", columns);
    }

    public List<Entity> Getteam_routingruleitem(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "routingruleitem", "assignobjectid", columns);
    }

    public List<Entity> Getteam_routingruleitem(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "routingruleitem", "assignobjectid", columns);
    }

    public List<Entity> Getteam_orders(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "salesorder", "owningteam", columns);
    }

    public List<Entity> Getteam_orders(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "salesorder", "owningteam", columns);
    }

    public List<Entity> Getteam_salesorderdetail(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "salesorderdetail", "owningteam", columns);
    }

    public List<Entity> Getteam_salesorderdetail(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "salesorderdetail", "owningteam", columns);
    }

    public List<Entity> Getteam_service_appointments(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "serviceappointment", "owningteam", columns);
    }

    public List<Entity> Getteam_service_appointments(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "serviceappointment", "owningteam", columns);
    }

    public List<Entity> Getteam_sharepointdocumentlocation(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sharepointdocumentlocation", "owningteam", columns);
    }

    public List<Entity> Getteam_sharepointdocumentlocation(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sharepointdocumentlocation", "owningteam", columns);
    }

    public List<Entity> Getteam_sharepointsite(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sharepointsite", "owningteam", columns);
    }

    public List<Entity> Getteam_sharepointsite(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sharepointsite", "owningteam", columns);
    }

    public List<Entity> Getteam_slaBase(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sla", "owningteam", columns);
    }

    public List<Entity> Getteam_slaBase(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sla", "owningteam", columns);
    }

    public List<Entity> Getteam_socialactivity(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "socialactivity", "owningteam", columns);
    }

    public List<Entity> Getteam_socialactivity(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "socialactivity", "owningteam", columns);
    }

    public List<Entity> Getteam_stagesolutionupload(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "stagesolutionupload", "owningteam", columns);
    }

    public List<Entity> Getteam_stagesolutionupload(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "stagesolutionupload", "owningteam", columns);
    }

    public List<Entity> Getteam_SyncError(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "syncerror", "owningteam", columns);
    }

    public List<Entity> Getteam_SyncError(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "syncerror", "owningteam", columns);
    }

    public List<Entity> GetTeam_SyncErrors(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "syncerror", "regardingobjectid", columns);
    }

    public List<Entity> GetTeam_SyncErrors(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "syncerror", "regardingobjectid", columns);
    }

    public List<Entity> Getteam_task(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "task", "owningteam", columns);
    }

    public List<Entity> Getteam_task(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "task", "owningteam", columns);
    }

    public List<Entity> Getteam_email_templates(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "template", "owningteam", columns);
    }

    public List<Entity> Getteam_email_templates(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "template", "owningteam", columns);
    }

    public List<Entity> Getteam_userentityinstancedata(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userentityinstancedata", "owningteam", columns);
    }

    public List<Entity> Getteam_userentityinstancedata(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userentityinstancedata", "owningteam", columns);
    }

    public List<Entity> Getuserentityinstancedata_team(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userentityinstancedata", "objectid", columns);
    }

    public List<Entity> Getuserentityinstancedata_team(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userentityinstancedata", "objectid", columns);
    }

    public List<Entity> Getteam_userentityuisettings(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userentityuisettings", "owningteam", columns);
    }

    public List<Entity> Getteam_userentityuisettings(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userentityuisettings", "owningteam", columns);
    }

    public List<Entity> Getteam_userform(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userform", "owningteam", columns);
    }

    public List<Entity> Getteam_userform(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userform", "owningteam", columns);
    }

    public List<Entity> Getteam_userquery(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userquery", "owningteam", columns);
    }

    public List<Entity> Getteam_userquery(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userquery", "owningteam", columns);
    }

    public List<Entity> Getteam_userqueryvisualizations(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userqueryvisualization", "owningteam", columns);
    }

    public List<Entity> Getteam_userqueryvisualizations(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userqueryvisualization", "owningteam", columns);
    }

    public List<Entity> Getteam_workflow(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "workflow", "owningteam", columns);
    }

    public List<Entity> Getteam_workflow(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "workflow", "owningteam", columns);
    }

    public List<Entity> Getteam_workflowbinary(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "workflowbinary", "owningteam", columns);
    }

    public List<Entity> Getteam_workflowbinary(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "workflowbinary", "owningteam", columns);
    }

    public List<Entity> Getteam_workflowlog(IOrganizationService service, params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "workflowlog", "owningteam", columns);
    }

    public List<Entity> Getteam_workflowlog(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "workflowlog", "owningteam", columns);
    }

    public List<Entity> Getteamroles_association(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedManyToManyEntities(service, (BaseProxyClass) this, nameof (team), "teamid", "role", "roleid", "teamroles", "teamid", "roleid", columns);
    }

    public List<Entity> Getteamroles_association(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedManyToManyEntities(service, (BaseProxyClass) this, nameof (team), "teamid", "role", "roleid", "teamroles", "teamid", "roleid", columns);
    }

    public void Relateteamroles_association(IOrganizationService service, params Entity[] items)
    {
      service.RelateEntities((EntityReference) (BaseProxyClass) this, "teamroles_association", items);
    }

    public void Relateteamroles_association(
      IOrganizationService service,
      params EntityReference[] items)
    {
      service.RelateEntities((EntityReference) (BaseProxyClass) this, "teamroles_association", items);
    }

    public void UnRelateteamroles_association(IOrganizationService service, params Entity[] items)
    {
      service.UnRelateEntities((EntityReference) (BaseProxyClass) this, "teamroles_association", items);
    }

    public void UnRelateteamroles_association(
      IOrganizationService service,
      params EntityReference[] items)
    {
      service.UnRelateEntities((EntityReference) (BaseProxyClass) this, "teamroles_association", items);
    }

    public List<systemuser> Getteammembership_association(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedManyToManyEntities<systemuser>(service, (BaseProxyClass) this, nameof (team), "teamid", "systemuser", "systemuserid", "teammembership", "teamid", "systemuserid", columns);
    }

    public List<systemuser> Getteammembership_association(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedManyToManyEntities<systemuser>(service, (BaseProxyClass) this, nameof (team), "teamid", "systemuser", "systemuserid", "teammembership", "teamid", "systemuserid", columns);
    }

    public void Relateteammembership_association(
      IOrganizationService service,
      params Entity[] items)
    {
      service.RelateEntities((EntityReference) (BaseProxyClass) this, "teammembership_association", items);
    }

    public void Relateteammembership_association(
      IOrganizationService service,
      params EntityReference[] items)
    {
      service.RelateEntities((EntityReference) (BaseProxyClass) this, "teammembership_association", items);
    }

    public void UnRelateteammembership_association(
      IOrganizationService service,
      params Entity[] items)
    {
      service.UnRelateEntities((EntityReference) (BaseProxyClass) this, "teammembership_association", items);
    }

    public void UnRelateteammembership_association(
      IOrganizationService service,
      params EntityReference[] items)
    {
      service.UnRelateEntities((EntityReference) (BaseProxyClass) this, "teammembership_association", items);
    }

    public List<Entity> Getteamsyncattributemappingprofiles_association(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedManyToManyEntities(service, (BaseProxyClass) this, nameof (team), "teamid", "syncattributemappingprofile", "syncattributemappingprofileid", "teamsyncattributemappingprofiles", "teamid", "syncattributemappingprofileid", columns);
    }

    public List<Entity> Getteamsyncattributemappingprofiles_association(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedManyToManyEntities(service, (BaseProxyClass) this, nameof (team), "teamid", "syncattributemappingprofile", "syncattributemappingprofileid", "teamsyncattributemappingprofiles", "teamid", "syncattributemappingprofileid", columns);
    }

    public void Relateteamsyncattributemappingprofiles_association(
      IOrganizationService service,
      params Entity[] items)
    {
      service.RelateEntities((EntityReference) (BaseProxyClass) this, "teamsyncattributemappingprofiles_association", items);
    }

    public void Relateteamsyncattributemappingprofiles_association(
      IOrganizationService service,
      params EntityReference[] items)
    {
      service.RelateEntities((EntityReference) (BaseProxyClass) this, "teamsyncattributemappingprofiles_association", items);
    }

    public void UnRelateteamsyncattributemappingprofiles_association(
      IOrganizationService service,
      params Entity[] items)
    {
      service.UnRelateEntities((EntityReference) (BaseProxyClass) this, "teamsyncattributemappingprofiles_association", items);
    }

    public void UnRelateteamsyncattributemappingprofiles_association(
      IOrganizationService service,
      params EntityReference[] items)
    {
      service.UnRelateEntities((EntityReference) (BaseProxyClass) this, "teamsyncattributemappingprofiles_association", items);
    }

    public List<Entity> Getteamprofiles_association(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedManyToManyEntities(service, (BaseProxyClass) this, nameof (team), "teamid", "fieldsecurityprofile", "fieldsecurityprofileid", "teamprofiles", "teamid", "fieldsecurityprofileid", columns);
    }

    public List<Entity> Getteamprofiles_association(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedManyToManyEntities(service, (BaseProxyClass) this, nameof (team), "teamid", "fieldsecurityprofile", "fieldsecurityprofileid", "teamprofiles", "teamid", "fieldsecurityprofileid", columns);
    }

    public void Relateteamprofiles_association(IOrganizationService service, params Entity[] items)
    {
      service.RelateEntities((EntityReference) (BaseProxyClass) this, "teamprofiles_association", items);
    }

    public void Relateteamprofiles_association(
      IOrganizationService service,
      params EntityReference[] items)
    {
      service.RelateEntities((EntityReference) (BaseProxyClass) this, "teamprofiles_association", items);
    }

    public void UnRelateteamprofiles_association(
      IOrganizationService service,
      params Entity[] items)
    {
      service.UnRelateEntities((EntityReference) (BaseProxyClass) this, "teamprofiles_association", items);
    }

    public void UnRelateteamprofiles_association(
      IOrganizationService service,
      params EntityReference[] items)
    {
      service.UnRelateEntities((EntityReference) (BaseProxyClass) this, "teamprofiles_association", items);
    }

    public void AddMembers(IOrganizationService Service, List<Guid> MemberIds)
    {
      AddMembersTeamRequest membersTeamRequest = new AddMembersTeamRequest()
      {
        TeamId = this.Id,
        MemberIds = MemberIds.ToArray()
      };
      Service.Execute((OrganizationRequest) membersTeamRequest);
    }

    public static class Properties
    {
      public const string administratorid = "administratorid";
      public const string administratoridname = "administratoridname";
      public const string administratoridyominame = "administratoridyominame";
      public const string azureactivedirectoryobjectid = "azureactivedirectoryobjectid";
      public const string businessunitid = "businessunitid";
      public const string businessunitidname = "businessunitidname";
      public const string createdby = "createdby";
      public const string createdbyname = "createdbyname";
      public const string createdbyyominame = "createdbyyominame";
      public const string createdon = "createdon";
      public const string createdonbehalfby = "createdonbehalfby";
      public const string createdonbehalfbyname = "createdonbehalfbyname";
      public const string createdonbehalfbyyominame = "createdonbehalfbyyominame";
      public const string description = "description";
      public const string emailaddress = "emailaddress";
      public const string exchangerate = "exchangerate";
      public const string importsequencenumber = "importsequencenumber";
      public const string isdefault = "isdefault";
      public const string isdefaultname = "isdefaultname";
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
      public const string overriddencreatedon = "overriddencreatedon";
      public const string processid = "processid";
      public const string queueid = "queueid";
      public const string queueidname = "queueidname";
      public const string regardingobjectid = "regardingobjectid";
      public const string regardingobjecttypecode = "regardingobjecttypecode";
      public const string stageid = "stageid";
      public const string systemmanaged = "systemmanaged";
      public const string systemmanagedname = "systemmanagedname";
      public const string teamid = "teamid";
      public const string teamtemplateid = "teamtemplateid";
      public const string teamtype = "teamtype";
      public const string teamtypename = "teamtypename";
      public const string transactioncurrencyid = "transactioncurrencyid";
      public const string transactioncurrencyidname = "transactioncurrencyidname";
      public const string traversedpath = "traversedpath";
      public const string versionnumber = "versionnumber";
      public const string yominame = "yominame";
    }
  }
}
