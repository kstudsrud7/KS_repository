// Decompiled with JetBrains decompiler
// Type: TPCourt.EarlyBound.ait_courtfinesandfees
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
  [EntityLogicalName("ait_courtfinesandfees")]
  [GeneratedCode("XrmToolkit", "4.0")]
  [DataContract(Name = "Entity", Namespace = "http://schemas.microsoft.com/xrm/2011/Contracts")]
  public class ait_courtfinesandfees : BaseProxyClass
  {
    public const string LogicalName = "ait_courtfinesandfees";
    public const int ObjectTypeCode = 10154;
    public const string PrimaryIdAttribute = "ait_courtfinesandfeesid";
    public const string PrimaryNameAttribute = "ait_name";
    private static Dictionary<string, BaseProxyClass.eTextOptions> _textOptions;
    private static Dictionary<string, BaseProxyClass.eNumberOptions> _numberOptions;
    private static Dictionary<string, string> _errorStrings;

    static ait_courtfinesandfees()
    {
      BaseProxyClass.RegisterProxyType(typeof (ait_courtfinesandfees), nameof (ait_courtfinesandfees));
      ait_courtfinesandfees._textOptions = new Dictionary<string, BaseProxyClass.eTextOptions>();
      ait_courtfinesandfees._numberOptions = new Dictionary<string, BaseProxyClass.eNumberOptions>();
      ait_courtfinesandfees._errorStrings = new Dictionary<string, string>();
      ait_courtfinesandfees.TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
      ait_courtfinesandfees.NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
    }

    public ait_courtfinesandfees()
      : base(new Entity(nameof (ait_courtfinesandfees)))
    {
    }

    public ait_courtfinesandfees(Entity original)
      : base(original)
    {
    }

    public static string GetLogicalName() => BaseProxyClass.GetLogicalName<ait_courtfinesandfees>();

    public static BaseProxyClass.eTextOptions TextOptions { get; set; }

    public static void SetTextOptions(
      string logicalName,
      BaseProxyClass.eTextOptions options,
      string errorString = null)
    {
      if (ait_courtfinesandfees._textOptions.ContainsKey(logicalName))
        ait_courtfinesandfees._textOptions[logicalName] = options;
      else
        ait_courtfinesandfees._textOptions.Add(logicalName, options);
      if (!string.IsNullOrEmpty(errorString))
      {
        if (ait_courtfinesandfees._errorStrings.ContainsKey(logicalName))
          ait_courtfinesandfees._errorStrings[logicalName] = errorString;
        else
          ait_courtfinesandfees._errorStrings.Add(logicalName, errorString);
      }
      else
      {
        if (!ait_courtfinesandfees._errorStrings.ContainsKey(logicalName))
          return;
        ait_courtfinesandfees._errorStrings.Remove(logicalName);
      }
    }

    protected override BaseProxyClass.eTextOptions GetTextOptions(string logicalName)
    {
      return ait_courtfinesandfees._textOptions.ContainsKey(logicalName) ? ait_courtfinesandfees._textOptions[logicalName] : ait_courtfinesandfees.TextOptions;
    }

    public static BaseProxyClass.eNumberOptions NumberOptions { get; set; }

    public static void SetNumberOptions(
      string logicalName,
      BaseProxyClass.eNumberOptions options,
      string errorString = null)
    {
      if (ait_courtfinesandfees._numberOptions.ContainsKey(logicalName))
        ait_courtfinesandfees._numberOptions[logicalName] = options;
      else
        ait_courtfinesandfees._numberOptions.Add(logicalName, options);
      if (!string.IsNullOrEmpty(errorString))
      {
        if (ait_courtfinesandfees._errorStrings.ContainsKey(logicalName))
          ait_courtfinesandfees._errorStrings[logicalName] = errorString;
        else
          ait_courtfinesandfees._errorStrings.Add(logicalName, errorString);
      }
      else
      {
        if (!ait_courtfinesandfees._errorStrings.ContainsKey(logicalName))
          return;
        ait_courtfinesandfees._errorStrings.Remove(logicalName);
      }
    }

    protected override BaseProxyClass.eNumberOptions GetNumberOptions(string logicalName)
    {
      return ait_courtfinesandfees._numberOptions.ContainsKey(logicalName) ? ait_courtfinesandfees._numberOptions[logicalName] : ait_courtfinesandfees.NumberOptions;
    }

    protected override string GetErrorString(
      string attributeName,
      BaseProxyClass.eErrorType defaultErrorType)
    {
      return ait_courtfinesandfees._errorStrings.ContainsKey(attributeName) ? ait_courtfinesandfees._errorStrings[attributeName] : (defaultErrorType == BaseProxyClass.eErrorType.Text ? ait_courtfinesandfees.TextError : ait_courtfinesandfees.NumberError);
    }

    public static string TextError { get; set; }

    public static string NumberError { get; set; }

    [AttributeLogicalName("ait_amount")]
    public Decimal? ait_amount
    {
      get
      {
        return this.ait_amountMoney != null ? new Decimal?(this.ait_amountMoney.Value) : new Decimal?();
      }
      set
      {
        if (value.HasValue)
          this.ait_amountMoney = new Money(value.Value);
        else
          this.ait_amountMoney = (Money) null;
      }
    }

    [AttributeLogicalName("ait_amount")]
    public Money ait_amountMoney
    {
      get => this.GetPropertyValue<Money>("ait_amount");
      set
      {
        this.SetPropertyValue("ait_amount", value, -922337203685477M, 922337203685477M, nameof (ait_amountMoney));
      }
    }

    [AttributeLogicalName("ait_amount_base")]
    public Decimal? ait_amount_base
    {
      get
      {
        return this.ait_amount_baseMoney != null ? new Decimal?(this.ait_amount_baseMoney.Value) : new Decimal?();
      }
    }

    [AttributeLogicalName("ait_amount_base")]
    public Money ait_amount_baseMoney => this.GetPropertyValue<Money>("ait_amount_base");

    [AttributeLogicalName("ait_closeddate")]
    public DateTime? ait_closeddate
    {
      get => this.GetPropertyValue<DateTime?>(nameof (ait_closeddate));
      set
      {
        this.SetPropertyValue<DateTime?>(nameof (ait_closeddate), value, nameof (ait_closeddate));
      }
    }

    [AttributeLogicalName("ait_courtcase")]
    public EntityReference ait_courtcase
    {
      get => this.GetPropertyValue<EntityReference>(nameof (ait_courtcase));
      set
      {
        this.SetPropertyValue<EntityReference>(nameof (ait_courtcase), value, nameof (ait_courtcase));
      }
    }

    [AttributeLogicalName("ait_courtcasename")]
    public string ait_courtcasename => this.GetPropertyValue<string>(nameof (ait_courtcasename));

    [AttributeLogicalName("ait_courtfinesandfeesid")]
    public Guid ait_courtfinesandfeesid
    {
      get => this.Id;
      set
      {
        this.Id = value;
        this.SetPropertyValue<Guid>(nameof (ait_courtfinesandfeesid), value, nameof (ait_courtfinesandfeesid));
      }
    }

    [AttributeLogicalName("ait_date")]
    public DateTime? ait_date
    {
      get => this.GetPropertyValue<DateTime?>(nameof (ait_date));
      set => this.SetPropertyValue<DateTime?>(nameof (ait_date), value, nameof (ait_date));
    }

    [AttributeLogicalName("ait_dateordersent")]
    public DateTime? ait_dateordersent
    {
      get => this.GetPropertyValue<DateTime?>(nameof (ait_dateordersent));
      set
      {
        this.SetPropertyValue<DateTime?>(nameof (ait_dateordersent), value, nameof (ait_dateordersent));
      }
    }

    [AttributeLogicalName("ait_description")]
    public string ait_description
    {
      get => this.GetPropertyValue<string>(nameof (ait_description));
      set => this.SetPropertyValue(nameof (ait_description), value, 100, nameof (ait_description));
    }

    [AttributeLogicalName("ait_duedate")]
    public DateTime? ait_duedate
    {
      get => this.GetPropertyValue<DateTime?>(nameof (ait_duedate));
      set => this.SetPropertyValue<DateTime?>(nameof (ait_duedate), value, nameof (ait_duedate));
    }

    [AttributeLogicalName("ait_feeid")]
    public string ait_feeid
    {
      get => this.GetPropertyValue<string>(nameof (ait_feeid));
      set => this.SetPropertyValue(nameof (ait_feeid), value, 100, nameof (ait_feeid));
    }

    [AttributeLogicalName("ait_firstreminderlettersentdate")]
    public DateTime? ait_firstreminderlettersentdate
    {
      get => this.GetPropertyValue<DateTime?>(nameof (ait_firstreminderlettersentdate));
      set
      {
        this.SetPropertyValue<DateTime?>(nameof (ait_firstreminderlettersentdate), value, nameof (ait_firstreminderlettersentdate));
      }
    }

    [AttributeLogicalName("ait_name")]
    public string ait_name
    {
      get => this.GetPropertyValue<string>(nameof (ait_name));
      set => this.SetPropertyValue(nameof (ait_name), value, 100, nameof (ait_name));
    }

    [AttributeLogicalName("ait_paid")]
    public bool? ait_paid
    {
      get => this.GetPropertyValue<bool?>(nameof (ait_paid));
      set => this.SetPropertyValue<bool?>(nameof (ait_paid), value, nameof (ait_paid));
    }

    [AttributeLogicalName("ait_payableto")]
    public string ait_payableto
    {
      get => this.GetPropertyValue<string>(nameof (ait_payableto));
      set => this.SetPropertyValue(nameof (ait_payableto), value, 100, nameof (ait_payableto));
    }

    [AttributeLogicalName("ait_paymentsmade")]
    public int? ait_paymentsmade => this.GetPropertyValue<int?>(nameof (ait_paymentsmade));

    [AttributeLogicalName("ait_paymentsmade_date")]
    public DateTime? ait_paymentsmade_date
    {
      get => this.GetPropertyValue<DateTime?>(nameof (ait_paymentsmade_date));
    }

    [AttributeLogicalName("ait_paymentsmade_state")]
    public int? ait_paymentsmade_state
    {
      get => this.GetPropertyValue<int?>(nameof (ait_paymentsmade_state));
    }

    [AttributeLogicalName("ait_percapinterceptletterdate")]
    public DateTime? ait_percapinterceptletterdate
    {
      get => this.GetPropertyValue<DateTime?>(nameof (ait_percapinterceptletterdate));
      set
      {
        this.SetPropertyValue<DateTime?>(nameof (ait_percapinterceptletterdate), value, nameof (ait_percapinterceptletterdate));
      }
    }

    [AttributeLogicalName("ait_taxinterceptletterdate")]
    public DateTime? ait_taxinterceptletterdate
    {
      get => this.GetPropertyValue<DateTime?>(nameof (ait_taxinterceptletterdate));
      set
      {
        this.SetPropertyValue<DateTime?>(nameof (ait_taxinterceptletterdate), value, nameof (ait_taxinterceptletterdate));
      }
    }

    [AttributeLogicalName("ait_totalbalancedue")]
    public Decimal? ait_totalbalancedue
    {
      get
      {
        return this.ait_totalbalancedueMoney != null ? new Decimal?(this.ait_totalbalancedueMoney.Value) : new Decimal?();
      }
      set
      {
        if (value.HasValue)
          this.ait_totalbalancedueMoney = new Money(value.Value);
        else
          this.ait_totalbalancedueMoney = (Money) null;
      }
    }

    [AttributeLogicalName("ait_totalbalancedue")]
    public Money ait_totalbalancedueMoney
    {
      get => this.GetPropertyValue<Money>("ait_totalbalancedue");
      set
      {
        this.SetPropertyValue("ait_totalbalancedue", value, -922337203685477M, 922337203685477M, nameof (ait_totalbalancedueMoney));
      }
    }

    [AttributeLogicalName("ait_totalbalancedue_base")]
    public Decimal? ait_totalbalancedue_base
    {
      get
      {
        return this.ait_totalbalancedue_baseMoney != null ? new Decimal?(this.ait_totalbalancedue_baseMoney.Value) : new Decimal?();
      }
    }

    [AttributeLogicalName("ait_totalbalancedue_base")]
    public Money ait_totalbalancedue_baseMoney
    {
      get => this.GetPropertyValue<Money>("ait_totalbalancedue_base");
    }

    [AttributeLogicalName("ait_totalpaymentsmade")]
    public Decimal? ait_totalpaymentsmade
    {
      get
      {
        return this.ait_totalpaymentsmadeMoney != null ? new Decimal?(this.ait_totalpaymentsmadeMoney.Value) : new Decimal?();
      }
    }

    [AttributeLogicalName("ait_totalpaymentsmade")]
    public Money ait_totalpaymentsmadeMoney
    {
      get => this.GetPropertyValue<Money>("ait_totalpaymentsmade");
    }

    [AttributeLogicalName("ait_totalpaymentsmade_base")]
    public Decimal? ait_totalpaymentsmade_base
    {
      get
      {
        return this.ait_totalpaymentsmade_baseMoney != null ? new Decimal?(this.ait_totalpaymentsmade_baseMoney.Value) : new Decimal?();
      }
    }

    [AttributeLogicalName("ait_totalpaymentsmade_base")]
    public Money ait_totalpaymentsmade_baseMoney
    {
      get => this.GetPropertyValue<Money>("ait_totalpaymentsmade_base");
    }

    [AttributeLogicalName("ait_totalpaymentsmade_date")]
    public DateTime? ait_totalpaymentsmade_date
    {
      get => this.GetPropertyValue<DateTime?>(nameof (ait_totalpaymentsmade_date));
    }

    [AttributeLogicalName("ait_totalpaymentsmade_state")]
    public int? ait_totalpaymentsmade_state
    {
      get => this.GetPropertyValue<int?>(nameof (ait_totalpaymentsmade_state));
    }

    [AttributeLogicalName("ait_type")]
    public eAit_courtfinesandfees_ait_type? ait_type
    {
      get
      {
        return this.ait_type_OptionSetValue != null ? new eAit_courtfinesandfees_ait_type?((eAit_courtfinesandfees_ait_type) this.ait_type_OptionSetValue.Value) : new eAit_courtfinesandfees_ait_type?();
      }
      set
      {
        if (value.HasValue)
          this.ait_type_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.ait_type_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("ait_type")]
    public OptionSetValue ait_type_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("ait_type");
      set
      {
        this.SetPropertyValue<OptionSetValue>("ait_type", value, nameof (ait_type_OptionSetValue));
      }
    }

    public string ait_type_Text(IOrganizationService service)
    {
      return this.ait_type_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "ait_type");
    }

    public string ait_type_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.ait_type_OptionSetValue.Value);
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
    public eAit_courtfinesandfees_statecode? statecode
    {
      get
      {
        return this.statecode_OptionSetValue != null ? new eAit_courtfinesandfees_statecode?((eAit_courtfinesandfees_statecode) this.statecode_OptionSetValue.Value) : new eAit_courtfinesandfees_statecode?();
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
    public eAit_courtfinesandfees_statuscode? statuscode
    {
      get
      {
        return this.statuscode_OptionSetValue != null ? new eAit_courtfinesandfees_statuscode?((eAit_courtfinesandfees_statuscode) this.statuscode_OptionSetValue.Value) : new eAit_courtfinesandfees_statuscode?();
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

    public List<ait_courtpayments> Getait_courtfinesandfees_ait_courtpayments_FinesandFees(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_courtpayments>(service, this.Id, "ait_courtpayments", "ait_finesandfees", columns);
    }

    public List<ait_courtpayments> Getait_courtfinesandfees_ait_courtpayments_FinesandFees(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<ait_courtpayments>(service, this.Id, "ait_courtpayments", "ait_finesandfees", columns);
    }

    public List<Entity> Getait_courtfinesandfees_Annotations(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "annotation", "objectid", columns);
    }

    public List<Entity> Getait_courtfinesandfees_Annotations(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "annotation", "objectid", columns);
    }

    public List<Entity> Getait_courtfinesandfees_AsyncOperations(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "asyncoperation", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtfinesandfees_AsyncOperations(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "asyncoperation", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtfinesandfees_BulkDeleteFailures(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bulkdeletefailure", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtfinesandfees_BulkDeleteFailures(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bulkdeletefailure", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtfinesandfees_DuplicateBaseRecord(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "duplicaterecord", "baserecordid", columns);
    }

    public List<Entity> Getait_courtfinesandfees_DuplicateBaseRecord(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "duplicaterecord", "baserecordid", columns);
    }

    public List<Entity> Getait_courtfinesandfees_DuplicateMatchingRecord(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "duplicaterecord", "duplicaterecordid", columns);
    }

    public List<Entity> Getait_courtfinesandfees_DuplicateMatchingRecord(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "duplicaterecord", "duplicaterecordid", columns);
    }

    public List<Entity> Getait_courtfinesandfees_MailboxTrackingFolders(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "mailboxtrackingfolder", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtfinesandfees_MailboxTrackingFolders(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "mailboxtrackingfolder", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtfinesandfees_PrincipalObjectAttributeAccesses(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "principalobjectattributeaccess", "objectid", columns);
    }

    public List<Entity> Getait_courtfinesandfees_PrincipalObjectAttributeAccesses(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "principalobjectattributeaccess", "objectid", columns);
    }

    public List<Entity> Getait_courtfinesandfees_ProcessSession(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "processsession", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtfinesandfees_ProcessSession(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "processsession", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtfinesandfees_SyncErrors(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "syncerror", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtfinesandfees_SyncErrors(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "syncerror", "regardingobjectid", columns);
    }

    public List<Entity> Getait_courtfinesandfees_UserEntityInstanceDatas(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userentityinstancedata", "objectid", columns);
    }

    public List<Entity> Getait_courtfinesandfees_UserEntityInstanceDatas(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userentityinstancedata", "objectid", columns);
    }

    public List<ait_courtprofile> Getait_courtfinesandfees_ait_courtprofile(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedManyToManyEntities<ait_courtprofile>(service, (BaseProxyClass) this, nameof (ait_courtfinesandfees), "ait_courtfinesandfeesid", "ait_courtprofile", "ait_courtprofileid", "ait_courtfinesandfees_ait_courtprofile", "ait_courtfinesandfeesid", "ait_courtprofileid", columns);
    }

    public List<ait_courtprofile> Getait_courtfinesandfees_ait_courtprofile(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedManyToManyEntities<ait_courtprofile>(service, (BaseProxyClass) this, nameof (ait_courtfinesandfees), "ait_courtfinesandfeesid", "ait_courtprofile", "ait_courtprofileid", "ait_courtfinesandfees_ait_courtprofile", "ait_courtfinesandfeesid", "ait_courtprofileid", columns);
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
      public const string ait_amount = "ait_amount";
      public const string ait_amount_base = "ait_amount_base";
      public const string ait_closeddate = "ait_closeddate";
      public const string ait_courtcase = "ait_courtcase";
      public const string ait_courtcasename = "ait_courtcasename";
      public const string ait_courtfinesandfeesid = "ait_courtfinesandfeesid";
      public const string ait_date = "ait_date";
      public const string ait_dateordersent = "ait_dateordersent";
      public const string ait_description = "ait_description";
      public const string ait_duedate = "ait_duedate";
      public const string ait_feeid = "ait_feeid";
      public const string ait_firstreminderlettersentdate = "ait_firstreminderlettersentdate";
      public const string ait_name = "ait_name";
      public const string ait_paid = "ait_paid";
      public const string ait_paidname = "ait_paidname";
      public const string ait_payableto = "ait_payableto";
      public const string ait_paymentsmade = "ait_paymentsmade";
      public const string ait_paymentsmade_date = "ait_paymentsmade_date";
      public const string ait_paymentsmade_state = "ait_paymentsmade_state";
      public const string ait_percapinterceptletterdate = "ait_percapinterceptletterdate";
      public const string ait_taxinterceptletterdate = "ait_taxinterceptletterdate";
      public const string ait_totalbalancedue = "ait_totalbalancedue";
      public const string ait_totalbalancedue_base = "ait_totalbalancedue_base";
      public const string ait_totalpaymentsmade = "ait_totalpaymentsmade";
      public const string ait_totalpaymentsmade_base = "ait_totalpaymentsmade_base";
      public const string ait_totalpaymentsmade_date = "ait_totalpaymentsmade_date";
      public const string ait_totalpaymentsmade_state = "ait_totalpaymentsmade_state";
      public const string ait_type = "ait_type";
      public const string ait_typename = "ait_typename";
      public const string createdby = "createdby";
      public const string createdbyname = "createdbyname";
      public const string createdbyyominame = "createdbyyominame";
      public const string createdon = "createdon";
      public const string createdonbehalfby = "createdonbehalfby";
      public const string createdonbehalfbyname = "createdonbehalfbyname";
      public const string createdonbehalfbyyominame = "createdonbehalfbyyominame";
      public const string exchangerate = "exchangerate";
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
      public const string transactioncurrencyid = "transactioncurrencyid";
      public const string transactioncurrencyidname = "transactioncurrencyidname";
      public const string utcconversiontimezonecode = "utcconversiontimezonecode";
      public const string versionnumber = "versionnumber";
    }
  }
}
