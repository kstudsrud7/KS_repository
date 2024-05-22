// Decompiled with JetBrains decompiler
// Type: TPCourt.EarlyBound.appointment
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
  [EntityLogicalName("appointment")]
  [GeneratedCode("XrmToolkit", "4.0")]
  [DataContract(Name = "Entity", Namespace = "http://schemas.microsoft.com/xrm/2011/Contracts")]
  public class appointment : BaseProxyClass
  {
    public const string LogicalName = "appointment";
    public const int ObjectTypeCode = 4201;
    public const string PrimaryIdAttribute = "activityid";
    public const string PrimaryNameAttribute = "subject";
    private static Dictionary<string, BaseProxyClass.eTextOptions> _textOptions;
    private static Dictionary<string, BaseProxyClass.eNumberOptions> _numberOptions;
    private static Dictionary<string, string> _errorStrings;

    static appointment()
    {
      BaseProxyClass.RegisterProxyType(typeof (appointment), nameof (appointment));
      appointment._textOptions = new Dictionary<string, BaseProxyClass.eTextOptions>();
      appointment._numberOptions = new Dictionary<string, BaseProxyClass.eNumberOptions>();
      appointment._errorStrings = new Dictionary<string, string>();
      appointment.TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
      appointment.NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
    }

    public appointment()
      : base(new Entity(nameof (appointment)))
    {
    }

    public appointment(Entity original)
      : base(original)
    {
    }

    public static string GetLogicalName() => BaseProxyClass.GetLogicalName<appointment>();

    public static BaseProxyClass.eTextOptions TextOptions { get; set; }

    public static void SetTextOptions(
      string logicalName,
      BaseProxyClass.eTextOptions options,
      string errorString = null)
    {
      if (appointment._textOptions.ContainsKey(logicalName))
        appointment._textOptions[logicalName] = options;
      else
        appointment._textOptions.Add(logicalName, options);
      if (!string.IsNullOrEmpty(errorString))
      {
        if (appointment._errorStrings.ContainsKey(logicalName))
          appointment._errorStrings[logicalName] = errorString;
        else
          appointment._errorStrings.Add(logicalName, errorString);
      }
      else
      {
        if (!appointment._errorStrings.ContainsKey(logicalName))
          return;
        appointment._errorStrings.Remove(logicalName);
      }
    }

    protected override BaseProxyClass.eTextOptions GetTextOptions(string logicalName)
    {
      return appointment._textOptions.ContainsKey(logicalName) ? appointment._textOptions[logicalName] : appointment.TextOptions;
    }

    public static BaseProxyClass.eNumberOptions NumberOptions { get; set; }

    public static void SetNumberOptions(
      string logicalName,
      BaseProxyClass.eNumberOptions options,
      string errorString = null)
    {
      if (appointment._numberOptions.ContainsKey(logicalName))
        appointment._numberOptions[logicalName] = options;
      else
        appointment._numberOptions.Add(logicalName, options);
      if (!string.IsNullOrEmpty(errorString))
      {
        if (appointment._errorStrings.ContainsKey(logicalName))
          appointment._errorStrings[logicalName] = errorString;
        else
          appointment._errorStrings.Add(logicalName, errorString);
      }
      else
      {
        if (!appointment._errorStrings.ContainsKey(logicalName))
          return;
        appointment._errorStrings.Remove(logicalName);
      }
    }

    protected override BaseProxyClass.eNumberOptions GetNumberOptions(string logicalName)
    {
      return appointment._numberOptions.ContainsKey(logicalName) ? appointment._numberOptions[logicalName] : appointment.NumberOptions;
    }

    protected override string GetErrorString(
      string attributeName,
      BaseProxyClass.eErrorType defaultErrorType)
    {
      return appointment._errorStrings.ContainsKey(attributeName) ? appointment._errorStrings[attributeName] : (defaultErrorType == BaseProxyClass.eErrorType.Text ? appointment.TextError : appointment.NumberError);
    }

    public static string TextError { get; set; }

    public static string NumberError { get; set; }

    [AttributeLogicalName("activityadditionalparams")]
    public string activityadditionalparams
    {
      get => this.GetPropertyValue<string>(nameof (activityadditionalparams));
      set
      {
        this.SetPropertyValue(nameof (activityadditionalparams), value, 8192, nameof (activityadditionalparams));
      }
    }

    [AttributeLogicalName("activityid")]
    public Guid activityid
    {
      get => this.Id;
      set
      {
        this.Id = value;
        this.SetPropertyValue<Guid>(nameof (activityid), value, nameof (activityid));
      }
    }

    [AttributeLogicalName("activitytypecode")]
    public string activitytypecode => this.GetPropertyValue<string>(nameof (activitytypecode));

    [AttributeLogicalName("actualdurationminutes")]
    public int? actualdurationminutes
    {
      get => this.GetPropertyValue<int?>(nameof (actualdurationminutes));
      set
      {
        this.SetPropertyValue(nameof (actualdurationminutes), value, 0, int.MaxValue, nameof (actualdurationminutes));
      }
    }

    [AttributeLogicalName("actualend")]
    public DateTime? actualend
    {
      get => this.GetPropertyValue<DateTime?>(nameof (actualend));
      set => this.SetPropertyValue<DateTime?>(nameof (actualend), value, nameof (actualend));
    }

    [AttributeLogicalName("actualstart")]
    public DateTime? actualstart
    {
      get => this.GetPropertyValue<DateTime?>(nameof (actualstart));
      set => this.SetPropertyValue<DateTime?>(nameof (actualstart), value, nameof (actualstart));
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

    [AttributeLogicalName("ait_courtreporter")]
    public EntityReference ait_courtreporter
    {
      get => this.GetPropertyValue<EntityReference>(nameof (ait_courtreporter));
      set
      {
        this.SetPropertyValue<EntityReference>(nameof (ait_courtreporter), value, nameof (ait_courtreporter));
      }
    }

    [AttributeLogicalName("ait_courtreportername")]
    public string ait_courtreportername
    {
      get => this.GetPropertyValue<string>(nameof (ait_courtreportername));
    }

    [AttributeLogicalName("ait_courtreporteryominame")]
    public string ait_courtreporteryominame
    {
      get => this.GetPropertyValue<string>(nameof (ait_courtreporteryominame));
    }

    [AttributeLogicalName("ait_courtroom")]
    public EntityReference ait_courtroom
    {
      get => this.GetPropertyValue<EntityReference>(nameof (ait_courtroom));
      set
      {
        this.SetPropertyValue<EntityReference>(nameof (ait_courtroom), value, nameof (ait_courtroom));
      }
    }

    [AttributeLogicalName("ait_courtroomname")]
    public string ait_courtroomname => this.GetPropertyValue<string>(nameof (ait_courtroomname));

    [AttributeLogicalName("ait_hearingtype")]
    public eAit_appointment_ait_hearingtype? ait_hearingtype
    {
      get
      {
        return this.ait_hearingtype_OptionSetValue != null ? new eAit_appointment_ait_hearingtype?((eAit_appointment_ait_hearingtype) this.ait_hearingtype_OptionSetValue.Value) : new eAit_appointment_ait_hearingtype?();
      }
      set
      {
        if (value.HasValue)
          this.ait_hearingtype_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.ait_hearingtype_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("ait_hearingtype")]
    public OptionSetValue ait_hearingtype_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("ait_hearingtype");
      set
      {
        this.SetPropertyValue<OptionSetValue>("ait_hearingtype", value, nameof (ait_hearingtype_OptionSetValue));
      }
    }

    public string ait_hearingtype_Text(IOrganizationService service)
    {
      return this.ait_hearingtype_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "ait_hearingtype");
    }

    public string ait_hearingtype_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.ait_hearingtype_OptionSetValue.Value);
    }

    [AttributeLogicalName("ait_judge")]
    public EntityReference ait_judge
    {
      get => this.GetPropertyValue<EntityReference>(nameof (ait_judge));
      set => this.SetPropertyValue<EntityReference>(nameof (ait_judge), value, nameof (ait_judge));
    }

    [AttributeLogicalName("ait_judgename")]
    public string ait_judgename => this.GetPropertyValue<string>(nameof (ait_judgename));

    [AttributeLogicalName("ait_judgeyominame")]
    public string ait_judgeyominame => this.GetPropertyValue<string>(nameof (ait_judgeyominame));

    [AttributeLogicalName("attachmentcount")]
    public int? attachmentcount => this.GetPropertyValue<int?>(nameof (attachmentcount));

    [AttributeLogicalName("attachmenterrors")]
    public eAppointment_attachmenterrors? attachmenterrors
    {
      get
      {
        return this.attachmenterrors_OptionSetValue != null ? new eAppointment_attachmenterrors?((eAppointment_attachmenterrors) this.attachmenterrors_OptionSetValue.Value) : new eAppointment_attachmenterrors?();
      }
      set
      {
        if (value.HasValue)
          this.attachmenterrors_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.attachmenterrors_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("attachmenterrors")]
    public OptionSetValue attachmenterrors_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("attachmenterrors");
      set
      {
        this.SetPropertyValue<OptionSetValue>("attachmenterrors", value, nameof (attachmenterrors_OptionSetValue));
      }
    }

    public string attachmenterrors_Text(IOrganizationService service)
    {
      return this.attachmenterrors_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "attachmenterrors");
    }

    public string attachmenterrors_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.attachmenterrors_OptionSetValue.Value);
    }

    [AttributeLogicalName("category")]
    public string category
    {
      get => this.GetPropertyValue<string>(nameof (category));
      set => this.SetPropertyValue(nameof (category), value, 250, nameof (category));
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
      set => this.SetPropertyValue(nameof (description), value, 1048576, nameof (description));
    }

    [AttributeLogicalName("exchangerate")]
    public Decimal? exchangerate => this.GetPropertyValue<Decimal?>(nameof (exchangerate));

    [AttributeLogicalName("globalobjectid")]
    public string globalobjectid
    {
      get => this.GetPropertyValue<string>(nameof (globalobjectid));
      set => this.SetPropertyValue(nameof (globalobjectid), value, 300, nameof (globalobjectid));
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

    [AttributeLogicalName("instancetypecode")]
    public eAppointment_instancetypecode? instancetypecode
    {
      get
      {
        return this.instancetypecode_OptionSetValue != null ? new eAppointment_instancetypecode?((eAppointment_instancetypecode) this.instancetypecode_OptionSetValue.Value) : new eAppointment_instancetypecode?();
      }
    }

    [AttributeLogicalName("instancetypecode")]
    public OptionSetValue instancetypecode_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("instancetypecode");
    }

    public string instancetypecode_Text(IOrganizationService service)
    {
      return this.instancetypecode_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "instancetypecode");
    }

    public string instancetypecode_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.instancetypecode_OptionSetValue.Value);
    }

    [AttributeLogicalName("isalldayevent")]
    public bool? isalldayevent
    {
      get => this.GetPropertyValue<bool?>(nameof (isalldayevent));
      set => this.SetPropertyValue<bool?>(nameof (isalldayevent), value, nameof (isalldayevent));
    }

    [AttributeLogicalName("isbilled")]
    public bool? isbilled
    {
      get => this.GetPropertyValue<bool?>(nameof (isbilled));
      set => this.SetPropertyValue<bool?>(nameof (isbilled), value, nameof (isbilled));
    }

    [AttributeLogicalName("isdraft")]
    public bool? isdraft
    {
      get => this.GetPropertyValue<bool?>(nameof (isdraft));
      set => this.SetPropertyValue<bool?>(nameof (isdraft), value, nameof (isdraft));
    }

    [AttributeLogicalName("ismapiprivate")]
    public bool? ismapiprivate
    {
      get => this.GetPropertyValue<bool?>(nameof (ismapiprivate));
      set => this.SetPropertyValue<bool?>(nameof (ismapiprivate), value, nameof (ismapiprivate));
    }

    [AttributeLogicalName("isregularactivity")]
    public bool? isregularactivity => this.GetPropertyValue<bool?>(nameof (isregularactivity));

    [AttributeLogicalName("isunsafe")]
    public int? isunsafe => this.GetPropertyValue<int?>(nameof (isunsafe));

    [AttributeLogicalName("isworkflowcreated")]
    public bool? isworkflowcreated
    {
      get => this.GetPropertyValue<bool?>(nameof (isworkflowcreated));
      set
      {
        this.SetPropertyValue<bool?>(nameof (isworkflowcreated), value, nameof (isworkflowcreated));
      }
    }

    [AttributeLogicalName("lastonholdtime")]
    public DateTime? lastonholdtime
    {
      get => this.GetPropertyValue<DateTime?>(nameof (lastonholdtime));
      set
      {
        this.SetPropertyValue<DateTime?>(nameof (lastonholdtime), value, nameof (lastonholdtime));
      }
    }

    [AttributeLogicalName("location")]
    public string location
    {
      get => this.GetPropertyValue<string>(nameof (location));
      set => this.SetPropertyValue(nameof (location), value, 200, nameof (location));
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

    [AttributeLogicalName("modifiedfieldsmask")]
    public string modifiedfieldsmask => this.GetPropertyValue<string>(nameof (modifiedfieldsmask));

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

    [AttributeLogicalName("onholdtime")]
    public int? onholdtime => this.GetPropertyValue<int?>(nameof (onholdtime));

    [AttributeLogicalName("optionalattendees")]
    public EntityCollection optionalattendees
    {
      get => this.GetPropertyValue<EntityCollection>(nameof (optionalattendees));
      set
      {
        this.SetPropertyValue<EntityCollection>(nameof (optionalattendees), value, nameof (optionalattendees));
      }
    }

    [AttributeLogicalName("organizer")]
    public EntityCollection organizer
    {
      get => this.GetPropertyValue<EntityCollection>(nameof (organizer));
      set => this.SetPropertyValue<EntityCollection>(nameof (organizer), value, nameof (organizer));
    }

    [AttributeLogicalName("originalstartdate")]
    public DateTime? originalstartdate
    {
      get => this.GetPropertyValue<DateTime?>(nameof (originalstartdate));
    }

    [AttributeLogicalName("outlookownerapptid")]
    public int? outlookownerapptid
    {
      get => this.GetPropertyValue<int?>(nameof (outlookownerapptid));
      set
      {
        this.SetPropertyValue(nameof (outlookownerapptid), value, int.MinValue, int.MaxValue, nameof (outlookownerapptid));
      }
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

    [AttributeLogicalName("prioritycode")]
    public eAppointment_prioritycode? prioritycode
    {
      get
      {
        return this.prioritycode_OptionSetValue != null ? new eAppointment_prioritycode?((eAppointment_prioritycode) this.prioritycode_OptionSetValue.Value) : new eAppointment_prioritycode?();
      }
      set
      {
        if (value.HasValue)
          this.prioritycode_OptionSetValue = new OptionSetValue((int) value.Value);
        else
          this.prioritycode_OptionSetValue = (OptionSetValue) null;
      }
    }

    [AttributeLogicalName("prioritycode")]
    public OptionSetValue prioritycode_OptionSetValue
    {
      get => this.GetPropertyValue<OptionSetValue>("prioritycode");
      set
      {
        this.SetPropertyValue<OptionSetValue>("prioritycode", value, nameof (prioritycode_OptionSetValue));
      }
    }

    public string prioritycode_Text(IOrganizationService service)
    {
      return this.prioritycode_OptionSetValue.GetOptionSetText(service, (BaseProxyClass) this, "prioritycode");
    }

    public string prioritycode_Text(EnumAttributeMetadata attributeMetadata)
    {
      return attributeMetadata.GetOptionSetText(this.prioritycode_OptionSetValue.Value);
    }

    [AttributeLogicalName("processid")]
    public Guid processid
    {
      get => this.GetPropertyValue<Guid>(nameof (processid));
      set => this.SetPropertyValue<Guid>(nameof (processid), value, nameof (processid));
    }

    [AttributeLogicalName("regardingobjectid")]
    public EntityReference regardingobjectid
    {
      get => this.GetPropertyValue<EntityReference>(nameof (regardingobjectid));
      set
      {
        this.SetPropertyValue<EntityReference>(nameof (regardingobjectid), value, nameof (regardingobjectid));
      }
    }

    [AttributeLogicalName("regardingobjectidname")]
    public string regardingobjectidname
    {
      get => this.GetPropertyValue<string>(nameof (regardingobjectidname));
    }

    [AttributeLogicalName("regardingobjectidyominame")]
    public string regardingobjectidyominame
    {
      get => this.GetPropertyValue<string>(nameof (regardingobjectidyominame));
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

    [AttributeLogicalName("requiredattendees")]
    public EntityCollection requiredattendees
    {
      get => this.GetPropertyValue<EntityCollection>(nameof (requiredattendees));
      set
      {
        this.SetPropertyValue<EntityCollection>(nameof (requiredattendees), value, nameof (requiredattendees));
      }
    }

    [AttributeLogicalName("safedescription")]
    public string safedescription => this.GetPropertyValue<string>(nameof (safedescription));

    [AttributeLogicalName("scheduleddurationminutes")]
    public int? scheduleddurationminutes
    {
      get => this.GetPropertyValue<int?>(nameof (scheduleddurationminutes));
      set
      {
        this.SetPropertyValue(nameof (scheduleddurationminutes), value, 0, int.MaxValue, nameof (scheduleddurationminutes));
      }
    }

    [AttributeLogicalName("scheduledend")]
    public DateTime? scheduledend
    {
      get => this.GetPropertyValue<DateTime?>(nameof (scheduledend));
      set => this.SetPropertyValue<DateTime?>(nameof (scheduledend), value, nameof (scheduledend));
    }

    [AttributeLogicalName("scheduledstart")]
    public DateTime? scheduledstart
    {
      get => this.GetPropertyValue<DateTime?>(nameof (scheduledstart));
      set
      {
        this.SetPropertyValue<DateTime?>(nameof (scheduledstart), value, nameof (scheduledstart));
      }
    }

    [AttributeLogicalName("seriesid")]
    public Guid seriesid => this.GetPropertyValue<Guid>(nameof (seriesid));

    [AttributeLogicalName("serviceid")]
    public EntityReference serviceid
    {
      get => this.GetPropertyValue<EntityReference>(nameof (serviceid));
      set => this.SetPropertyValue<EntityReference>(nameof (serviceid), value, nameof (serviceid));
    }

    [AttributeLogicalName("serviceidname")]
    public string serviceidname => this.GetPropertyValue<string>(nameof (serviceidname));

    [AttributeLogicalName("slaid")]
    public EntityReference slaid
    {
      get => this.GetPropertyValue<EntityReference>(nameof (slaid));
      set => this.SetPropertyValue<EntityReference>(nameof (slaid), value, nameof (slaid));
    }

    [AttributeLogicalName("slainvokedid")]
    public EntityReference slainvokedid
    {
      get => this.GetPropertyValue<EntityReference>(nameof (slainvokedid));
    }

    [AttributeLogicalName("slainvokedidname")]
    public string slainvokedidname => this.GetPropertyValue<string>(nameof (slainvokedidname));

    [AttributeLogicalName("slaname")]
    public string slaname => this.GetPropertyValue<string>(nameof (slaname));

    [AttributeLogicalName("sortdate")]
    public DateTime? sortdate
    {
      get => this.GetPropertyValue<DateTime?>(nameof (sortdate));
      set => this.SetPropertyValue<DateTime?>(nameof (sortdate), value, nameof (sortdate));
    }

    [AttributeLogicalName("stageid")]
    public Guid stageid
    {
      get => this.GetPropertyValue<Guid>(nameof (stageid));
      set => this.SetPropertyValue<Guid>(nameof (stageid), value, nameof (stageid));
    }

    [AttributeLogicalName("statecode")]
    public eAppointment_statecode? statecode
    {
      get
      {
        return this.statecode_OptionSetValue != null ? new eAppointment_statecode?((eAppointment_statecode) this.statecode_OptionSetValue.Value) : new eAppointment_statecode?();
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
    public eAppointment_statuscode? statuscode
    {
      get
      {
        return this.statuscode_OptionSetValue != null ? new eAppointment_statuscode?((eAppointment_statuscode) this.statuscode_OptionSetValue.Value) : new eAppointment_statuscode?();
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

    [AttributeLogicalName("subcategory")]
    public string subcategory
    {
      get => this.GetPropertyValue<string>(nameof (subcategory));
      set => this.SetPropertyValue(nameof (subcategory), value, 250, nameof (subcategory));
    }

    [AttributeLogicalName("subject")]
    public string subject
    {
      get => this.GetPropertyValue<string>(nameof (subject));
      set => this.SetPropertyValue(nameof (subject), value, 200, nameof (subject));
    }

    [AttributeLogicalName("subscriptionid")]
    public Guid subscriptionid
    {
      get => this.GetPropertyValue<Guid>(nameof (subscriptionid));
      set => this.SetPropertyValue<Guid>(nameof (subscriptionid), value, nameof (subscriptionid));
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

    [AttributeLogicalName("traversedpath")]
    public string traversedpath
    {
      get => this.GetPropertyValue<string>(nameof (traversedpath));
      set => this.SetPropertyValue(nameof (traversedpath), value, 1250, nameof (traversedpath));
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

    public List<Entity> Getappointment_actioncard(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "actioncard", "regardingobjectid", columns);
    }

    public List<Entity> Getappointment_actioncard(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "actioncard", "regardingobjectid", columns);
    }

    public List<Entity> Getappointment_activity_mime_attachment(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "activitymimeattachment", "objectid", columns);
    }

    public List<Entity> Getappointment_activity_mime_attachment(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "activitymimeattachment", "objectid", columns);
    }

    public List<Entity> Getappointment_activity_parties(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "activityparty", "activityid", columns);
    }

    public List<Entity> Getappointment_activity_parties(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "activityparty", "activityid", columns);
    }

    public List<Entity> GetAppointment_Annotation(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "annotation", "objectid", columns);
    }

    public List<Entity> GetAppointment_Annotation(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "annotation", "objectid", columns);
    }

    public List<Entity> GetAppointment_AsyncOperations(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "asyncoperation", "regardingobjectid", columns);
    }

    public List<Entity> GetAppointment_AsyncOperations(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "asyncoperation", "regardingobjectid", columns);
    }

    public List<Entity> GetAppointment_BulkDeleteFailures(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bulkdeletefailure", "regardingobjectid", columns);
    }

    public List<Entity> GetAppointment_BulkDeleteFailures(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "bulkdeletefailure", "regardingobjectid", columns);
    }

    public List<Entity> Getappointment_campaignresponse(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "campaignresponse", "originatingactivityid", columns);
    }

    public List<Entity> Getappointment_campaignresponse(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "campaignresponse", "originatingactivityid", columns);
    }

    public List<connection> Getappointment_connections1(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<connection>(service, this.Id, "connection", "record1id", columns);
    }

    public List<connection> Getappointment_connections1(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<connection>(service, this.Id, "connection", "record1id", columns);
    }

    public List<connection> Getappointment_connections2(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<connection>(service, this.Id, "connection", "record2id", columns);
    }

    public List<connection> Getappointment_connections2(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities<connection>(service, this.Id, "connection", "record2id", columns);
    }

    public List<Entity> GetAppointment_DuplicateBaseRecord(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "duplicaterecord", "baserecordid", columns);
    }

    public List<Entity> GetAppointment_DuplicateBaseRecord(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "duplicaterecord", "baserecordid", columns);
    }

    public List<Entity> GetAppointment_DuplicateMatchingRecord(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "duplicaterecord", "duplicaterecordid", columns);
    }

    public List<Entity> GetAppointment_DuplicateMatchingRecord(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "duplicaterecord", "duplicaterecordid", columns);
    }

    public List<Entity> Getappointment_PostFollows(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "postfollow", "regardingobjectid", columns);
    }

    public List<Entity> Getappointment_PostFollows(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "postfollow", "regardingobjectid", columns);
    }

    public List<Entity> Getappointment_PostRegardings(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "postregarding", "regardingobjectid", columns);
    }

    public List<Entity> Getappointment_PostRegardings(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "postregarding", "regardingobjectid", columns);
    }

    public List<Entity> Getappointment_PostRoles(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "postrole", "regardingobjectid", columns);
    }

    public List<Entity> Getappointment_PostRoles(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "postrole", "regardingobjectid", columns);
    }

    public List<Entity> Getappointment_principalobjectattributeaccess(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "principalobjectattributeaccess", "objectid", columns);
    }

    public List<Entity> Getappointment_principalobjectattributeaccess(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "principalobjectattributeaccess", "objectid", columns);
    }

    public List<Entity> GetAppointment_ProcessSessions(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "processsession", "regardingobjectid", columns);
    }

    public List<Entity> GetAppointment_ProcessSessions(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "processsession", "regardingobjectid", columns);
    }

    public List<Entity> GetAppointment_QueueItem(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "queueitem", "objectid", columns);
    }

    public List<Entity> GetAppointment_QueueItem(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "queueitem", "objectid", columns);
    }

    public List<Entity> Getappointment_SharePointDocuments(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sharepointdocument", "regardingobjectid", columns);
    }

    public List<Entity> Getappointment_SharePointDocuments(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sharepointdocument", "regardingobjectid", columns);
    }

    public List<Entity> Getappointment_SharePointDocumentLocations(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sharepointdocumentlocation", "regardingobjectid", columns);
    }

    public List<Entity> Getappointment_SharePointDocumentLocations(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "sharepointdocumentlocation", "regardingobjectid", columns);
    }

    public List<Entity> Getslakpiinstance_appointment(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "slakpiinstance", "regarding", columns);
    }

    public List<Entity> Getslakpiinstance_appointment(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "slakpiinstance", "regarding", columns);
    }

    public List<Entity> GetAppointment_SyncErrors(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "syncerror", "regardingobjectid", columns);
    }

    public List<Entity> GetAppointment_SyncErrors(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "syncerror", "regardingobjectid", columns);
    }

    public List<Entity> Getuserentityinstancedata_appointment(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userentityinstancedata", "objectid", columns);
    }

    public List<Entity> Getuserentityinstancedata_appointment(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userentityinstancedata", "objectid", columns);
    }

    public static class Properties
    {
      public const string activityadditionalparams = "activityadditionalparams";
      public const string activityid = "activityid";
      public const string activitytypecode = "activitytypecode";
      public const string activitytypecodename = "activitytypecodename";
      public const string actualdurationminutes = "actualdurationminutes";
      public const string actualend = "actualend";
      public const string actualstart = "actualstart";
      public const string ait_courtcase = "ait_courtcase";
      public const string ait_courtcasename = "ait_courtcasename";
      public const string ait_courtclerk = "ait_courtclerk";
      public const string ait_courtclerkname = "ait_courtclerkname";
      public const string ait_courtclerkyominame = "ait_courtclerkyominame";
      public const string ait_courtreporter = "ait_courtreporter";
      public const string ait_courtreportername = "ait_courtreportername";
      public const string ait_courtreporteryominame = "ait_courtreporteryominame";
      public const string ait_courtroom = "ait_courtroom";
      public const string ait_courtroomname = "ait_courtroomname";
      public const string ait_hearingtype = "ait_hearingtype";
      public const string ait_hearingtypename = "ait_hearingtypename";
      public const string ait_judge = "ait_judge";
      public const string ait_judgename = "ait_judgename";
      public const string ait_judgeyominame = "ait_judgeyominame";
      public const string attachmentcount = "attachmentcount";
      public const string attachmenterrors = "attachmenterrors";
      public const string attachmenterrorsname = "attachmenterrorsname";
      public const string category = "category";
      public const string createdby = "createdby";
      public const string createdbyname = "createdbyname";
      public const string createdbyyominame = "createdbyyominame";
      public const string createdon = "createdon";
      public const string createdonbehalfby = "createdonbehalfby";
      public const string createdonbehalfbyname = "createdonbehalfbyname";
      public const string createdonbehalfbyyominame = "createdonbehalfbyyominame";
      public const string description = "description";
      public const string exchangerate = "exchangerate";
      public const string globalobjectid = "globalobjectid";
      public const string importsequencenumber = "importsequencenumber";
      public const string instancetypecode = "instancetypecode";
      public const string instancetypecodename = "instancetypecodename";
      public const string isalldayevent = "isalldayevent";
      public const string isalldayeventname = "isalldayeventname";
      public const string isbilled = "isbilled";
      public const string isbilledname = "isbilledname";
      public const string isdraft = "isdraft";
      public const string isdraftname = "isdraftname";
      public const string ismapiprivate = "ismapiprivate";
      public const string ismapiprivatename = "ismapiprivatename";
      public const string isregularactivity = "isregularactivity";
      public const string isregularactivityname = "isregularactivityname";
      public const string isunsafe = "isunsafe";
      public const string isworkflowcreated = "isworkflowcreated";
      public const string isworkflowcreatedname = "isworkflowcreatedname";
      public const string lastonholdtime = "lastonholdtime";
      public const string location = "location";
      public const string modifiedby = "modifiedby";
      public const string modifiedbyname = "modifiedbyname";
      public const string modifiedbyyominame = "modifiedbyyominame";
      public const string modifiedfieldsmask = "modifiedfieldsmask";
      public const string modifiedon = "modifiedon";
      public const string modifiedonbehalfby = "modifiedonbehalfby";
      public const string modifiedonbehalfbyname = "modifiedonbehalfbyname";
      public const string modifiedonbehalfbyyominame = "modifiedonbehalfbyyominame";
      public const string onholdtime = "onholdtime";
      public const string optionalattendees = "optionalattendees";
      public const string organizer = "organizer";
      public const string originalstartdate = "originalstartdate";
      public const string outlookownerapptid = "outlookownerapptid";
      public const string overriddencreatedon = "overriddencreatedon";
      public const string ownerid = "ownerid";
      public const string owneridname = "owneridname";
      public const string owneridtype = "owneridtype";
      public const string owneridyominame = "owneridyominame";
      public const string owningbusinessunit = "owningbusinessunit";
      public const string owningteam = "owningteam";
      public const string owninguser = "owninguser";
      public const string prioritycode = "prioritycode";
      public const string prioritycodename = "prioritycodename";
      public const string processid = "processid";
      public const string regardingobjectid = "regardingobjectid";
      public const string regardingobjectidname = "regardingobjectidname";
      public const string regardingobjectidyominame = "regardingobjectidyominame";
      public const string regardingobjecttypecode = "regardingobjecttypecode";
      public const string requiredattendees = "requiredattendees";
      public const string safedescription = "safedescription";
      public const string scheduleddurationminutes = "scheduleddurationminutes";
      public const string scheduledend = "scheduledend";
      public const string scheduledstart = "scheduledstart";
      public const string seriesid = "seriesid";
      public const string serviceid = "serviceid";
      public const string serviceidname = "serviceidname";
      public const string slaid = "slaid";
      public const string slainvokedid = "slainvokedid";
      public const string slainvokedidname = "slainvokedidname";
      public const string slaname = "slaname";
      public const string sortdate = "sortdate";
      public const string stageid = "stageid";
      public const string statecode = "statecode";
      public const string statecodename = "statecodename";
      public const string statuscode = "statuscode";
      public const string statuscodename = "statuscodename";
      public const string subcategory = "subcategory";
      public const string subject = "subject";
      public const string subscriptionid = "subscriptionid";
      public const string timezoneruleversionnumber = "timezoneruleversionnumber";
      public const string transactioncurrencyid = "transactioncurrencyid";
      public const string transactioncurrencyidname = "transactioncurrencyidname";
      public const string traversedpath = "traversedpath";
      public const string utcconversiontimezonecode = "utcconversiontimezonecode";
      public const string versionnumber = "versionnumber";
    }
  }
}
