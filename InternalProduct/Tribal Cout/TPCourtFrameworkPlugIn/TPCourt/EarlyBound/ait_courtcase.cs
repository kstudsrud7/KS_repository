// Decompiled with JetBrains decompiler
// Type: TPCourt.EarlyBound.ait_courtcase
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
using System.Linq;
using System.Runtime.Serialization;

#nullable disable
namespace TPCourt.EarlyBound
{
  [EntityLogicalName("ait_courtcase")]
  [GeneratedCode("XrmToolkit", "4.0")]
  [DataContract(Name = "Entity", Namespace = "http://schemas.microsoft.com/xrm/2011/Contracts")]
  public class ait_courtcase : BaseProxyClass
  {
    public const string LogicalName = "ait_courtcase";
    public const int ObjectTypeCode = 10153;
    public const string PrimaryIdAttribute = "ait_courtcaseid";
    public const string PrimaryNameAttribute = "ait_name";
    private static Dictionary<string, BaseProxyClass.eTextOptions> _textOptions;
    private static Dictionary<string, BaseProxyClass.eNumberOptions> _numberOptions;
    private static Dictionary<string, string> _errorStrings;

    static ait_courtcase()
    {
      BaseProxyClass.RegisterProxyType(typeof (ait_courtcase), nameof (ait_courtcase));
      ait_courtcase._textOptions = new Dictionary<string, BaseProxyClass.eTextOptions>();
      ait_courtcase._numberOptions = new Dictionary<string, BaseProxyClass.eNumberOptions>();
      ait_courtcase._errorStrings = new Dictionary<string, string>();
      ait_courtcase.TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
      ait_courtcase.NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
    }

    public ait_courtcase()
      : base(new Entity(nameof (ait_courtcase)))
    {
    }

    public ait_courtcase(Entity original)
      : base(original)
    {
    }

    public static string GetLogicalName() => BaseProxyClass.GetLogicalName<ait_courtcase>();

    public static BaseProxyClass.eTextOptions TextOptions { get; set; }

    public static void SetTextOptions(
      string logicalName,
      BaseProxyClass.eTextOptions options,
      string errorString = null)
    {
      if (ait_courtcase._textOptions.ContainsKey(logicalName))
        ait_courtcase._textOptions[logicalName] = options;
      else
        ait_courtcase._textOptions.Add(logicalName, options);
      if (!string.IsNullOrEmpty(errorString))
      {
        if (ait_courtcase._errorStrings.ContainsKey(logicalName))
          ait_courtcase._errorStrings[logicalName] = errorString;
        else
          ait_courtcase._errorStrings.Add(logicalName, errorString);
      }
      else
      {
        if (!ait_courtcase._errorStrings.ContainsKey(logicalName))
          return;
        ait_courtcase._errorStrings.Remove(logicalName);
      }
    }

    protected override BaseProxyClass.eTextOptions GetTextOptions(string logicalName)
    {
      return ait_courtcase._textOptions.ContainsKey(logicalName) ? ait_courtcase._textOptions[logicalName] : ait_courtcase.TextOptions;
    }

    public static BaseProxyClass.eNumberOptions NumberOptions { get; set; }

    public static void SetNumberOptions(
      string logicalName,
      BaseProxyClass.eNumberOptions options,
      string errorString = null)
    {
      if (ait_courtcase._numberOptions.ContainsKey(logicalName))
        ait_courtcase._numberOptions[logicalName] = options;
      else
        ait_courtcase._numberOptions.Add(logicalName, options);
      if (!string.IsNullOrEmpty(errorString))
      {
        if (ait_courtcase._errorStrings.ContainsKey(logicalName))
          ait_courtcase._errorStrings[logicalName] = errorString;
        else
          ait_courtcase._errorStrings.Add(logicalName, errorString);
      }
      else
      {
        if (!ait_courtcase._errorStrings.ContainsKey(logicalName))
          return;
        ait_courtcase._errorStrings.Remove(logicalName);
      }
    }

    protected override BaseProxyClass.eNumberOptions GetNumberOptions(string logicalName)
    {
      return ait_courtcase._numberOptions.ContainsKey(logicalName) ? ait_courtcase._numberOptions[logicalName] : ait_courtcase.NumberOptions;
    }

    protected override string GetErrorString(
      string attributeName,
      BaseProxyClass.eErrorType defaultErrorType)
    {
      return ait_courtcase._errorStrings.ContainsKey(attributeName) ? ait_courtcase._errorStrings[attributeName] : (defaultErrorType == BaseProxyClass.eErrorType.Text ? ait_courtcase.TextError : ait_courtcase.NumberError);
    }

    public static string TextError { get; set; }

    public static string NumberError { get; set; }

    [AttributeLogicalName("ait_caseid")]
    public string ait_caseid
    {
      get => this.GetPropertyValue<string>(nameof (ait_caseid));
      set => this.SetPropertyValue(nameof (ait_caseid), value, 100, nameof (ait_caseid));
    }

    [AttributeLogicalName("ait_casetype")]
    public eAit_courtcasetype? ait_casetype
    {
      get
      {
        return this.ait_casetype_OptionSetValue != null ? new eAit_courtcasetype?((eAit_courtcasetype) this.ait_casetype_OptionSetValue.Value) : new eAit_courtcasetype?();
      }
      set
      {
        if (value.HasValue)
          this.ait_casetype_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.ait_casetype_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("ait_casetype")]
    public OptionSetValue ait_casetype_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("ait_casetype");
      set
      {
        this.SetPropertyValue<OptionSetValue>("ait_casetype", value, nameof (ait_casetype_OptionSetValue));
      }
    }

    public string ait_casetype_Text(IOrganizationService service)
    {
      return this.ait_casetype_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "ait_casetype");
    }

    public string ait_casetype_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.ait_casetype_OptionSetValue.Value);
    }

    [AttributeLogicalName("ait_closedate")]
    public DateTime? ait_closedate
    {
      get => this.GetPropertyValue<DateTime?>(nameof (ait_closedate));
      set
      {
        this.SetPropertyValue<DateTime?>(nameof (ait_closedate), value, nameof (ait_closedate));
      }
    }

    [AttributeLogicalName("ait_courtcaseid")]
    public Guid ait_courtcaseid
    {
      get => this.Id;
      set
      {
        this.Id = value;
        this.SetPropertyValue<Guid>(nameof (ait_courtcaseid), value, nameof (ait_courtcaseid));
      }
    }

    [AttributeLogicalName("ait_courtclerk")]
    public EntityReference ait_courtclerk
    {
      get => this.GetPropertyValue<EntityReference>(nameof (ait_courtclerk));
      set
      {
        this.SetPropertyValue<EntityReference>(nameof (ait_courtclerk), value, nameof (ait_courtclerk));
      }
    }

    [AttributeLogicalName("ait_courtclerkname")]
    public string ait_courtclerkname => this.GetPropertyValue<string>(nameof (ait_courtclerkname));

    [AttributeLogicalName("ait_courtclerkyominame")]
    public string ait_courtclerkyominame
    {
      get => this.GetPropertyValue<string>(nameof (ait_courtclerkyominame));
    }

    [AttributeLogicalName("ait_fcpcssdcasename")]
    public string ait_fcpcssdcasename
    {
      get => this.GetPropertyValue<string>(nameof (ait_fcpcssdcasename));
      set
      {
        this.SetPropertyValue(nameof (ait_fcpcssdcasename), value, 100, nameof (ait_fcpcssdcasename));
      }
    }

    [AttributeLogicalName("ait_fcpcssdcasenumber")]
    public string ait_fcpcssdcasenumber
    {
      get => this.GetPropertyValue<string>(nameof (ait_fcpcssdcasenumber));
      set
      {
        this.SetPropertyValue(nameof (ait_fcpcssdcasenumber), value, 100, nameof (ait_fcpcssdcasenumber));
      }
    }

    [AttributeLogicalName("ait_fcpcssdcasetype")]
    public eAit_courtcase_ait_fcpcssdcasetype? ait_fcpcssdcasetype
    {
      get
      {
        return this.ait_fcpcssdcasetype_OptionSetValue != null ? new eAit_courtcase_ait_fcpcssdcasetype?((eAit_courtcase_ait_fcpcssdcasetype) this.ait_fcpcssdcasetype_OptionSetValue.Value) : new eAit_courtcase_ait_fcpcssdcasetype?();
      }
      set
      {
        if (value.HasValue)
          this.ait_fcpcssdcasetype_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.ait_fcpcssdcasetype_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("ait_fcpcssdcasetype")]
    public OptionSetValue ait_fcpcssdcasetype_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("ait_fcpcssdcasetype");
      set
      {
        this.SetPropertyValue<OptionSetValue>("ait_fcpcssdcasetype", value, nameof (ait_fcpcssdcasetype_OptionSetValue));
      }
    }

    public string ait_fcpcssdcasetype_Text(IOrganizationService service)
    {
      return this.ait_fcpcssdcasetype_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "ait_fcpcssdcasetype");
    }

    public string ait_fcpcssdcasetype_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.ait_fcpcssdcasetype_OptionSetValue.Value);
    }

    [AttributeLogicalName("ait_fcpcssddate")]
    public DateTime? ait_fcpcssddate
    {
      get => this.GetPropertyValue<DateTime?>(nameof (ait_fcpcssddate));
      set
      {
        this.SetPropertyValue<DateTime?>(nameof (ait_fcpcssddate), value, nameof (ait_fcpcssddate));
      }
    }

    [AttributeLogicalName("ait_fcpcssdmisc")]
    public string ait_fcpcssdmisc
    {
      get => this.GetPropertyValue<string>(nameof (ait_fcpcssdmisc));
      set => this.SetPropertyValue(nameof (ait_fcpcssdmisc), value, 2000, nameof (ait_fcpcssdmisc));
    }

    [AttributeLogicalName("ait_initiationdate")]
    public DateTime? ait_initiationdate
    {
      get => this.GetPropertyValue<DateTime?>(nameof (ait_initiationdate));
      set
      {
        this.SetPropertyValue<DateTime?>(nameof (ait_initiationdate), value, nameof (ait_initiationdate));
      }
    }

    [AttributeLogicalName("ait_judge_user")]
    public EntityReference ait_judge_user
    {
      get => this.GetPropertyValue<EntityReference>(nameof (ait_judge_user));
      set
      {
        this.SetPropertyValue<EntityReference>(nameof (ait_judge_user), value, nameof (ait_judge_user));
      }
    }

    [AttributeLogicalName("ait_judge_username")]
    public string ait_judge_username => this.GetPropertyValue<string>(nameof (ait_judge_username));

    [AttributeLogicalName("ait_judge_useryominame")]
    public string ait_judge_useryominame
    {
      get => this.GetPropertyValue<string>(nameof (ait_judge_useryominame));
    }

    [AttributeLogicalName("ait_jurytrial")]
    public bool? ait_jurytrial
    {
      get => this.GetPropertyValue<bool?>(nameof (ait_jurytrial));
      set => this.SetPropertyValue<bool?>(nameof (ait_jurytrial), value, nameof (ait_jurytrial));
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

    [AttributeLogicalName("ait_otherclassification")]
    public List<eAit_courtcase_ait_otherclassification> ait_otherclassification
    {
      get
      {
        return this.ait_otherclassification_OptionSetValues != null ? ((IEnumerable<OptionSetValue>) this.ait_otherclassification_OptionSetValues).Select<OptionSetValue, eAit_courtcase_ait_otherclassification>((Func<OptionSetValue, eAit_courtcase_ait_otherclassification>) (o => (eAit_courtcase_ait_otherclassification) o.Value)).ToList<eAit_courtcase_ait_otherclassification>() : (List<eAit_courtcase_ait_otherclassification>) null;
      }
      set
      {
        if (value != null)
          this.ait_otherclassification_OptionSetValues = new OptionSetValueCollection((IList<OptionSetValue>) value.Select<eAit_courtcase_ait_otherclassification, OptionSetValue>((Func<eAit_courtcase_ait_otherclassification, OptionSetValue>) (o => new OptionSetValue((int) o))).ToList<OptionSetValue>());
        else
          this.ait_otherclassification_OptionSetValues = (OptionSetValueCollection) null;
      }
    }

    [AttributeLogicalName("ait_otherclassification")]
    public OptionSetValueCollection ait_otherclassification_OptionSetValues
    {
      get => this.GetPropertyValue<OptionSetValueCollection>("ait_otherclassification");
      set
      {
        this.SetPropertyValue<OptionSetValueCollection>("ait_otherclassification", value, nameof (ait_otherclassification_OptionSetValues));
      }
    }

    [AttributeLogicalName("ait_sealed")]
    public bool? ait_sealed
    {
      get => this.GetPropertyValue<bool?>(nameof (ait_sealed));
      set => this.SetPropertyValue<bool?>(nameof (ait_sealed), value, nameof (ait_sealed));
    }

    [AttributeLogicalName("ait_tempcaseid")]
    public string ait_tempcaseid
    {
      get => this.GetPropertyValue<string>(nameof (ait_tempcaseid));
      set => this.SetPropertyValue(nameof (ait_tempcaseid), value, 100, nameof (ait_tempcaseid));
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
    public eAit_courtcase_statecode? statecode
    {
      get
      {
        return this.statecode_OptionSetValue != null ? new eAit_courtcase_statecode?((eAit_courtcase_statecode) this.statecode_OptionSetValue.Value) : new eAit_courtcase_statecode?();
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
    public eAit_courtcase_statuscode? statuscode
    {
      get
      {
        return this.statuscode_OptionSetValue != null ? new eAit_courtcase_statuscode?((eAit_courtcase_statuscode) this.statuscode_OptionSetValue.Value) : new eAit_courtcase_statuscode?();
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

    public List<Entity> Getait_courtcase_ActivityPointers(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "activitypointer", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtcase_ActivityPointers(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "activitypointer", "regardingobjectid", columns);
    }

    public List<ait_casenote> Getait_ait_courtcase_ait_casenote_CourtCase(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_casenote>(service, this.Id, "ait_casenote", nameof (ait_courtcase), columns);
    }

    public List<ait_casenote> Getait_ait_courtcase_ait_casenote_CourtCase(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_casenote>(service, this.Id, "ait_casenote", nameof (ait_courtcase), columns);
    }

    public List<Entity> Getait_ait_courtcase_ait_charge_CourtCase(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_charge", nameof (ait_courtcase), columns);
    }

    public List<Entity> Getait_ait_courtcase_ait_charge_CourtCase(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_charge", nameof (ait_courtcase), columns);
    }

    public List<ait_courtfinesandfees> Getait_courtcase_ait_courtfinesandfees_CourtCase(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_courtfinesandfees>(service, this.Id, "ait_courtfinesandfees", nameof (ait_courtcase), columns);
    }

    public List<ait_courtfinesandfees> Getait_courtcase_ait_courtfinesandfees_CourtCase(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_courtfinesandfees>(service, this.Id, "ait_courtfinesandfees", nameof (ait_courtcase), columns);
    }

    public List<ait_courtparty> Getait_ait_courtcase_ait_courtparty(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_courtparty>(service, this.Id, "ait_courtparty", "ait_courtcaseid", columns);
    }

    public List<ait_courtparty> Getait_ait_courtcase_ait_courtparty(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_courtparty>(service, this.Id, "ait_courtparty", "ait_courtcaseid", columns);
    }

    public List<Entity> Getait_ait_courtcase_ait_hearing(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_hearing", "ait_courtcaseid", columns);
    }

    public List<Entity> Getait_ait_courtcase_ait_hearing(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_hearing", "ait_courtcaseid", columns);
    }

    public List<Entity> Getait_courtcase_ait_hearings(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_hearing", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtcase_ait_hearings(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "ait_hearing", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtcase_Annotations(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "annotation", "objectid", columns);
    }

    public List<Entity> Getait_courtcase_Annotations(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "annotation", "objectid", columns);
    }

    public List<appointment> Getait_courtcase_appointment_CourtCase(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<appointment>(service, this.Id, "appointment", nameof (ait_courtcase), columns);
    }

    public List<appointment> Getait_courtcase_appointment_CourtCase(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<appointment>(service, this.Id, "appointment", nameof (ait_courtcase), columns);
    }

    public List<appointment> Getait_courtcase_Appointments(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<appointment>(service, this.Id, "appointment", "regardingobjectid", columns);
    }

    public List<appointment> Getait_courtcase_Appointments(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<appointment>(service, this.Id, "appointment", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtcase_AsyncOperations(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "asyncoperation", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtcase_AsyncOperations(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "asyncoperation", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtcase_BulkDeleteFailures(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bulkdeletefailure", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtcase_BulkDeleteFailures(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bulkdeletefailure", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtcase_DuplicateBaseRecord(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "duplicaterecord", "baserecordid", columns);
    }

    public List<Entity> Getait_courtcase_DuplicateBaseRecord(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "duplicaterecord", "baserecordid", columns);
    }

    public List<Entity> Getait_courtcase_DuplicateMatchingRecord(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "duplicaterecord", "duplicaterecordid", columns);
    }

    public List<Entity> Getait_courtcase_DuplicateMatchingRecord(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "duplicaterecord", "duplicaterecordid", columns);
    }

    public List<Entity> Getait_courtcase_Emails(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "email", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtcase_Emails(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "email", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtcase_Faxes(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "fax", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtcase_Faxes(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "fax", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtcase_Letters(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "letter", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtcase_Letters(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "letter", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtcase_MailboxTrackingFolders(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "mailboxtrackingfolder", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtcase_MailboxTrackingFolders(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "mailboxtrackingfolder", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtcase_msfp_surveyinvites(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msfp_surveyinvite", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtcase_msfp_surveyinvites(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msfp_surveyinvite", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtcase_msfp_surveyresponses(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msfp_surveyresponse", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtcase_msfp_surveyresponses(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "msfp_surveyresponse", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtcase_PhoneCalls(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "phonecall", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtcase_PhoneCalls(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "phonecall", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtcase_PrincipalObjectAttributeAccesses(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "principalobjectattributeaccess", "objectid", columns);
    }

    public List<Entity> Getait_courtcase_PrincipalObjectAttributeAccesses(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "principalobjectattributeaccess", "objectid", columns);
    }

    public List<Entity> Getait_courtcase_ProcessSession(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "processsession", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtcase_ProcessSession(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "processsession", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtcase_RecurringAppointmentMasters(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "recurringappointmentmaster", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtcase_RecurringAppointmentMasters(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "recurringappointmentmaster", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtcase_ServiceAppointments(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "serviceappointment", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtcase_ServiceAppointments(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "serviceappointment", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtcase_SharePointDocuments(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sharepointdocument", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtcase_SharePointDocuments(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sharepointdocument", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtcase_SharePointDocumentLocations(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sharepointdocumentlocation", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtcase_SharePointDocumentLocations(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sharepointdocumentlocation", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtcase_SocialActivities(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "socialactivity", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtcase_SocialActivities(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "socialactivity", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtcase_SyncErrors(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "syncerror", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtcase_SyncErrors(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "syncerror", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtcase_Tasks(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "task", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtcase_Tasks(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "task", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtcase_UserEntityInstanceDatas(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userentityinstancedata", "objectid", columns);
    }

    public List<Entity> Getait_courtcase_UserEntityInstanceDatas(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userentityinstancedata", "objectid", columns);
    }

    public static class Properties
    {
      public const string ait_caseid = "ait_caseid";
      public const string ait_casetype = "ait_casetype";
      public const string ait_casetypename = "ait_casetypename";
      public const string ait_closedate = "ait_closedate";
      public const string ait_courtcaseid = "ait_courtcaseid";
      public const string ait_courtclerk = "ait_courtclerk";
      public const string ait_courtclerkname = "ait_courtclerkname";
      public const string ait_courtclerkyominame = "ait_courtclerkyominame";
      public const string ait_fcpcssdcasename = "ait_fcpcssdcasename";
      public const string ait_fcpcssdcasenumber = "ait_fcpcssdcasenumber";
      public const string ait_fcpcssdcasetype = "ait_fcpcssdcasetype";
      public const string ait_fcpcssdcasetypename = "ait_fcpcssdcasetypename";
      public const string ait_fcpcssddate = "ait_fcpcssddate";
      public const string ait_fcpcssdmisc = "ait_fcpcssdmisc";
      public const string ait_initiationdate = "ait_initiationdate";
      public const string ait_judge_user = "ait_judge_user";
      public const string ait_judge_username = "ait_judge_username";
      public const string ait_judge_useryominame = "ait_judge_useryominame";
      public const string ait_jurytrial = "ait_jurytrial";
      public const string ait_jurytrialname = "ait_jurytrialname";
      public const string ait_juvenile = "ait_juvenile";
      public const string ait_juvenilename = "ait_juvenilename";
      public const string ait_name = "ait_name";
      public const string ait_otherclassification = "ait_otherclassification";
      public const string ait_otherclassificationname = "ait_otherclassificationname";
      public const string ait_sealed = "ait_sealed";
      public const string ait_sealedname = "ait_sealedname";
      public const string ait_tempcaseid = "ait_tempcaseid";
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
