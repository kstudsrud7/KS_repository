// Decompiled with JetBrains decompiler
// Type: TPCourt.EarlyBound.ait_courtprofile
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
  [EntityLogicalName("ait_courtprofile")]
  [GeneratedCode("XrmToolkit", "4.0")]
  [DataContract(Name = "Entity", Namespace = "http://schemas.microsoft.com/xrm/2011/Contracts")]
  public class ait_courtprofile : BaseProxyClass
  {
    public const string LogicalName = "ait_courtprofile";
    public const int ObjectTypeCode = 10157;
    public const string PrimaryIdAttribute = "ait_courtprofileid";
    public const string PrimaryNameAttribute = "ait_name";
    private static Dictionary<string, BaseProxyClass.eTextOptions> _textOptions;
    private static Dictionary<string, BaseProxyClass.eNumberOptions> _numberOptions;
    private static Dictionary<string, string> _errorStrings;

    static ait_courtprofile()
    {
      BaseProxyClass.RegisterProxyType(typeof (ait_courtprofile), nameof (ait_courtprofile));
      ait_courtprofile._textOptions = new Dictionary<string, BaseProxyClass.eTextOptions>();
      ait_courtprofile._numberOptions = new Dictionary<string, BaseProxyClass.eNumberOptions>();
      ait_courtprofile._errorStrings = new Dictionary<string, string>();
      ait_courtprofile.TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
      ait_courtprofile.NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
    }

    public ait_courtprofile()
      : base(new Entity(nameof (ait_courtprofile)))
    {
    }

    public ait_courtprofile(Entity original)
      : base(original)
    {
    }

    public static string GetLogicalName() => BaseProxyClass.GetLogicalName<ait_courtprofile>();

    public static BaseProxyClass.eTextOptions TextOptions { get; set; }

    public static void SetTextOptions(
      string logicalName,
      BaseProxyClass.eTextOptions options,
      string errorString = null)
    {
      if (ait_courtprofile._textOptions.ContainsKey(logicalName))
        ait_courtprofile._textOptions[logicalName] = options;
      else
        ait_courtprofile._textOptions.Add(logicalName, options);
      if (!string.IsNullOrEmpty(errorString))
      {
        if (ait_courtprofile._errorStrings.ContainsKey(logicalName))
          ait_courtprofile._errorStrings[logicalName] = errorString;
        else
          ait_courtprofile._errorStrings.Add(logicalName, errorString);
      }
      else
      {
        if (!ait_courtprofile._errorStrings.ContainsKey(logicalName))
          return;
        ait_courtprofile._errorStrings.Remove(logicalName);
      }
    }

    protected override BaseProxyClass.eTextOptions GetTextOptions(string logicalName)
    {
      return ait_courtprofile._textOptions.ContainsKey(logicalName) ? ait_courtprofile._textOptions[logicalName] : ait_courtprofile.TextOptions;
    }

    public static BaseProxyClass.eNumberOptions NumberOptions { get; set; }

    public static void SetNumberOptions(
      string logicalName,
      BaseProxyClass.eNumberOptions options,
      string errorString = null)
    {
      if (ait_courtprofile._numberOptions.ContainsKey(logicalName))
        ait_courtprofile._numberOptions[logicalName] = options;
      else
        ait_courtprofile._numberOptions.Add(logicalName, options);
      if (!string.IsNullOrEmpty(errorString))
      {
        if (ait_courtprofile._errorStrings.ContainsKey(logicalName))
          ait_courtprofile._errorStrings[logicalName] = errorString;
        else
          ait_courtprofile._errorStrings.Add(logicalName, errorString);
      }
      else
      {
        if (!ait_courtprofile._errorStrings.ContainsKey(logicalName))
          return;
        ait_courtprofile._errorStrings.Remove(logicalName);
      }
    }

    protected override BaseProxyClass.eNumberOptions GetNumberOptions(string logicalName)
    {
      return ait_courtprofile._numberOptions.ContainsKey(logicalName) ? ait_courtprofile._numberOptions[logicalName] : ait_courtprofile.NumberOptions;
    }

    protected override string GetErrorString(
      string attributeName,
      BaseProxyClass.eErrorType defaultErrorType)
    {
      return ait_courtprofile._errorStrings.ContainsKey(attributeName) ? ait_courtprofile._errorStrings[attributeName] : (defaultErrorType == BaseProxyClass.eErrorType.Text ? ait_courtprofile.TextError : ait_courtprofile.NumberError);
    }

    public static string TextError { get; set; }

    public static string NumberError { get; set; }

    [AttributeLogicalName("ait_account")]
    public EntityReference ait_account
    {
      get => this.GetPropertyValue<EntityReference>(nameof (ait_account));
      set
      {
        this.SetPropertyValue<EntityReference>(nameof (ait_account), value, nameof (ait_account));
      }
    }

    [AttributeLogicalName("ait_accountname")]
    public string ait_accountname => this.GetPropertyValue<string>(nameof (ait_accountname));

    [AttributeLogicalName("ait_accountyominame")]
    public string ait_accountyominame
    {
      get => this.GetPropertyValue<string>(nameof (ait_accountyominame));
    }

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

    [AttributeLogicalName("ait_courtprofileid")]
    public Guid ait_courtprofileid
    {
      get => this.Id;
      set
      {
        this.Id = value;
        this.SetPropertyValue<Guid>(nameof (ait_courtprofileid), value, nameof (ait_courtprofileid));
      }
    }

    [AttributeLogicalName("ait_courtprofiletype")]
    public eAit_courtprofiletype? ait_courtprofiletype
    {
      get
      {
        return this.ait_courtprofiletype_OptionSetValue != null ? new eAit_courtprofiletype?((eAit_courtprofiletype) this.ait_courtprofiletype_OptionSetValue.Value) : new eAit_courtprofiletype?();
      }
      set
      {
        if (value.HasValue)
          this.ait_courtprofiletype_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.ait_courtprofiletype_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("ait_courtprofiletype")]
    public OptionSetValue ait_courtprofiletype_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("ait_courtprofiletype");
      set
      {
        this.SetPropertyValue<OptionSetValue>("ait_courtprofiletype", value, nameof (ait_courtprofiletype_OptionSetValue));
      }
    }

    public string ait_courtprofiletype_Text(IOrganizationService service)
    {
      return this.ait_courtprofiletype_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "ait_courtprofiletype");
    }

    public string ait_courtprofiletype_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.ait_courtprofiletype_OptionSetValue.Value);
    }

    [AttributeLogicalName("ait_dlexpiration")]
    public DateTime? ait_dlexpiration
    {
      get => this.GetPropertyValue<DateTime?>(nameof (ait_dlexpiration));
      set
      {
        this.SetPropertyValue<DateTime?>(nameof (ait_dlexpiration), value, nameof (ait_dlexpiration));
      }
    }

    [AttributeLogicalName("ait_dojnumber")]
    public string ait_dojnumber
    {
      get => this.GetPropertyValue<string>(nameof (ait_dojnumber));
      set => this.SetPropertyValue(nameof (ait_dojnumber), value, 100, nameof (ait_dojnumber));
    }

    [AttributeLogicalName("ait_driverslicenseno")]
    public string ait_driverslicenseno
    {
      get => this.GetPropertyValue<string>(nameof (ait_driverslicenseno));
      set
      {
        this.SetPropertyValue(nameof (ait_driverslicenseno), value, 100, nameof (ait_driverslicenseno));
      }
    }

    [AttributeLogicalName("ait_email")]
    public string ait_email
    {
      get => this.GetPropertyValue<string>(nameof (ait_email));
      set => this.SetPropertyValue(nameof (ait_email), value, 100, nameof (ait_email));
    }

    [AttributeLogicalName("ait_issuestate")]
    public EntityReference ait_issuestate
    {
      get => this.GetPropertyValue<EntityReference>(nameof (ait_issuestate));
      set
      {
        this.SetPropertyValue<EntityReference>(nameof (ait_issuestate), value, nameof (ait_issuestate));
      }
    }

    [AttributeLogicalName("ait_issuestatename")]
    public string ait_issuestatename => this.GetPropertyValue<string>(nameof (ait_issuestatename));

    [AttributeLogicalName("ait_lastupdated")]
    public DateTime? ait_lastupdated
    {
      get => this.GetPropertyValue<DateTime?>(nameof (ait_lastupdated));
      set
      {
        this.SetPropertyValue<DateTime?>(nameof (ait_lastupdated), value, nameof (ait_lastupdated));
      }
    }

    [AttributeLogicalName("ait_mailingaddress")]
    public EntityReference ait_mailingaddress
    {
      get => this.GetPropertyValue<EntityReference>(nameof (ait_mailingaddress));
      set
      {
        this.SetPropertyValue<EntityReference>(nameof (ait_mailingaddress), value, nameof (ait_mailingaddress));
      }
    }

    [AttributeLogicalName("ait_mailingaddressname")]
    public string ait_mailingaddressname
    {
      get => this.GetPropertyValue<string>(nameof (ait_mailingaddressname));
    }

    [AttributeLogicalName("ait_name")]
    public string ait_name
    {
      get => this.GetPropertyValue<string>(nameof (ait_name));
      set => this.SetPropertyValue(nameof (ait_name), value, 100, nameof (ait_name));
    }

    [AttributeLogicalName("ait_phonenumber")]
    public string ait_phonenumber
    {
      get => this.GetPropertyValue<string>(nameof (ait_phonenumber));
      set => this.SetPropertyValue(nameof (ait_phonenumber), value, 100, nameof (ait_phonenumber));
    }

    [AttributeLogicalName("ait_physicaladdress")]
    public EntityReference ait_physicaladdress
    {
      get => this.GetPropertyValue<EntityReference>(nameof (ait_physicaladdress));
      set
      {
        this.SetPropertyValue<EntityReference>(nameof (ait_physicaladdress), value, nameof (ait_physicaladdress));
      }
    }

    [AttributeLogicalName("ait_physicaladdressname")]
    public string ait_physicaladdressname
    {
      get => this.GetPropertyValue<string>(nameof (ait_physicaladdressname));
    }

    [AttributeLogicalName("ait_updatedaddress")]
    public string ait_updatedaddress
    {
      get => this.GetPropertyValue<string>(nameof (ait_updatedaddress));
      set
      {
        this.SetPropertyValue(nameof (ait_updatedaddress), value, 2000, nameof (ait_updatedaddress));
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
    public eAit_courtprofile_statecode? statecode
    {
      get
      {
        return this.statecode_OptionSetValue != null ? new eAit_courtprofile_statecode?((eAit_courtprofile_statecode) this.statecode_OptionSetValue.Value) : new eAit_courtprofile_statecode?();
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
    public eAit_courtprofile_statuscode? statuscode
    {
      get
      {
        return this.statuscode_OptionSetValue != null ? new eAit_courtprofile_statuscode?((eAit_courtprofile_statuscode) this.statuscode_OptionSetValue.Value) : new eAit_courtprofile_statuscode?();
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

    public List<ait_casenote> Getait_ait_courtprofile_ait_casenote_CourtProfile(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_casenote>(service, this.Id, "ait_casenote", nameof (ait_courtprofile), columns);
    }

    public List<ait_casenote> Getait_ait_courtprofile_ait_casenote_CourtProfile(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_casenote>(service, this.Id, "ait_casenote", nameof (ait_courtprofile), columns);
    }

    public List<Entity> Getait_ait_courtprofile_ait_charge_CourtProfile(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_charge", nameof (ait_courtprofile), columns);
    }

    public List<Entity> Getait_ait_courtprofile_ait_charge_CourtProfile(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_charge", nameof (ait_courtprofile), columns);
    }

    public List<ait_courtparty> Getait_ait_courtprofile_ait_courtparty_CourtProfile(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_courtparty>(service, this.Id, "ait_courtparty", nameof (ait_courtprofile), columns);
    }

    public List<ait_courtparty> Getait_ait_courtprofile_ait_courtparty_CourtProfile(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_courtparty>(service, this.Id, "ait_courtparty", nameof (ait_courtprofile), columns);
    }

    public List<ait_courtprofileaddress> Getait_courtprofile_ait_courtprofileaddress_CourtProfile(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_courtprofileaddress>(service, this.Id, "ait_courtprofileaddress", nameof (ait_courtprofile), columns);
    }

    public List<ait_courtprofileaddress> Getait_courtprofile_ait_courtprofileaddress_CourtProfile(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_courtprofileaddress>(service, this.Id, "ait_courtprofileaddress", nameof (ait_courtprofile), columns);
    }

    public List<Entity> Getait_courtprofile_AsyncOperations(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "asyncoperation", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtprofile_AsyncOperations(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "asyncoperation", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtprofile_BulkDeleteFailures(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bulkdeletefailure", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtprofile_BulkDeleteFailures(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bulkdeletefailure", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtprofile_DuplicateBaseRecord(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "duplicaterecord", "baserecordid", columns);
    }

    public List<Entity> Getait_courtprofile_DuplicateBaseRecord(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "duplicaterecord", "baserecordid", columns);
    }

    public List<Entity> Getait_courtprofile_DuplicateMatchingRecord(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "duplicaterecord", "duplicaterecordid", columns);
    }

    public List<Entity> Getait_courtprofile_DuplicateMatchingRecord(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "duplicaterecord", "duplicaterecordid", columns);
    }

    public List<Entity> Getait_courtprofile_MailboxTrackingFolders(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "mailboxtrackingfolder", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtprofile_MailboxTrackingFolders(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "mailboxtrackingfolder", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtprofile_PrincipalObjectAttributeAccesses(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "principalobjectattributeaccess", "objectid", columns);
    }

    public List<Entity> Getait_courtprofile_PrincipalObjectAttributeAccesses(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "principalobjectattributeaccess", "objectid", columns);
    }

    public List<Entity> Getait_courtprofile_ProcessSession(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "processsession", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtprofile_ProcessSession(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "processsession", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtprofile_SharePointDocuments(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sharepointdocument", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtprofile_SharePointDocuments(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sharepointdocument", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtprofile_SharePointDocumentLocations(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sharepointdocumentlocation", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtprofile_SharePointDocumentLocations(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sharepointdocumentlocation", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtprofile_SyncErrors(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "syncerror", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtprofile_SyncErrors(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "syncerror", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtprofile_UserEntityInstanceDatas(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userentityinstancedata", "objectid", columns);
    }

    public List<Entity> Getait_courtprofile_UserEntityInstanceDatas(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userentityinstancedata", "objectid", columns);
    }

    public List<ait_courtfinesandfees> Getait_courtfinesandfees_ait_courtprofile(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedManyToManyEntities<ait_courtfinesandfees>(service, (BaseProxyClass) this, nameof (ait_courtprofile), "ait_courtprofileid", "ait_courtfinesandfees", "ait_courtfinesandfeesid", "ait_courtfinesandfees_ait_courtprofile", "ait_courtprofileid", "ait_courtfinesandfeesid", columns);
    }

    public List<ait_courtfinesandfees> Getait_courtfinesandfees_ait_courtprofile(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedManyToManyEntities<ait_courtfinesandfees>(service, (BaseProxyClass) this, nameof (ait_courtprofile), "ait_courtprofileid", "ait_courtfinesandfees", "ait_courtfinesandfeesid", "ait_courtfinesandfees_ait_courtprofile", "ait_courtprofileid", "ait_courtfinesandfeesid", columns);
    }

    public void Relateait_courtfinesandfees_ait_courtprofile(
      IOrganizationService service,
      params Entity[] items)
    {
      service.RelateEntities((EntityReference) (BaseProxyClass) this, "ait_courtfinesandfees_ait_courtprofile", items);
    }

    public void Relateait_courtfinesandfees_ait_courtprofile(
      IOrganizationService service,
      params EntityReference[] items)
    {
      service.RelateEntities((EntityReference) (BaseProxyClass) this, "ait_courtfinesandfees_ait_courtprofile", items);
    }

    public void UnRelateait_courtfinesandfees_ait_courtprofile(
      IOrganizationService service,
      params Entity[] items)
    {
      service.UnRelateEntities((EntityReference) (BaseProxyClass) this, "ait_courtfinesandfees_ait_courtprofile", items);
    }

    public void UnRelateait_courtfinesandfees_ait_courtprofile(
      IOrganizationService service,
      params EntityReference[] items)
    {
      service.UnRelateEntities((EntityReference) (BaseProxyClass) this, "ait_courtfinesandfees_ait_courtprofile", items);
    }

    public static class Properties
    {
      public const string ait_account = "ait_account";
      public const string ait_accountname = "ait_accountname";
      public const string ait_accountyominame = "ait_accountyominame";
      public const string ait_contact = "ait_contact";
      public const string ait_contactname = "ait_contactname";
      public const string ait_contactyominame = "ait_contactyominame";
      public const string ait_courtprofileid = "ait_courtprofileid";
      public const string ait_courtprofiletype = "ait_courtprofiletype";
      public const string ait_courtprofiletypename = "ait_courtprofiletypename";
      public const string ait_dlexpiration = "ait_dlexpiration";
      public const string ait_dojnumber = "ait_dojnumber";
      public const string ait_driverslicenseno = "ait_driverslicenseno";
      public const string ait_email = "ait_email";
      public const string ait_issuestate = "ait_issuestate";
      public const string ait_issuestatename = "ait_issuestatename";
      public const string ait_lastupdated = "ait_lastupdated";
      public const string ait_mailingaddress = "ait_mailingaddress";
      public const string ait_mailingaddressname = "ait_mailingaddressname";
      public const string ait_name = "ait_name";
      public const string ait_phonenumber = "ait_phonenumber";
      public const string ait_physicaladdress = "ait_physicaladdress";
      public const string ait_physicaladdressname = "ait_physicaladdressname";
      public const string ait_updatedaddress = "ait_updatedaddress";
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
