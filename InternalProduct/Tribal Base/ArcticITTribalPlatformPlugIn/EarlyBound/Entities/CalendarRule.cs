// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.CalendarRule
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using Microsoft.Xrm.Sdk;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.Serialization;

#nullable disable
namespace ArcticIT.EarlyBound.Entities
{
  [DataContract]
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("calendarrule")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class CalendarRule : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "calendarrule";
    public const string EntitySchemaName = "CalendarRule";
    public const string PrimaryIdAttribute = "calendarruleid";
    public const string PrimaryNameAttribute = "name";

    public CalendarRule()
      : base("calendarrule")
    {
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public event PropertyChangingEventHandler PropertyChanging;

    private void OnPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void OnPropertyChanging(string propertyName)
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, new PropertyChangingEventArgs(propertyName));
    }

    [AttributeLogicalName("businessunitid")]
    public Guid? BusinessUnitId => this.GetAttributeValue<Guid?>("businessunitid");

    [AttributeLogicalName("calendarid")]
    public EntityReference CalendarId
    {
      get => this.GetAttributeValue<EntityReference>("calendarid");
      set
      {
        this.OnPropertyChanging(nameof (CalendarId));
        this.SetAttributeValue("calendarid", (object) value);
        this.OnPropertyChanged(nameof (CalendarId));
      }
    }

    [AttributeLogicalName("calendarruleid")]
    public Guid? CalendarRuleId
    {
      get => this.GetAttributeValue<Guid?>("calendarruleid");
      set
      {
        this.OnPropertyChanging(nameof (CalendarRuleId));
        this.SetAttributeValue("calendarruleid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (CalendarRuleId));
      }
    }

    [AttributeLogicalName("calendarruleid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.CalendarRuleId = new Guid?(value);
    }

    [AttributeLogicalName("createdby")]
    public EntityReference CreatedBy => this.GetAttributeValue<EntityReference>("createdby");

    [AttributeLogicalName("createdon")]
    public DateTime? CreatedOn => this.GetAttributeValue<DateTime?>("createdon");

    [AttributeLogicalName("createdonbehalfby")]
    public EntityReference CreatedOnBehalfBy
    {
      get => this.GetAttributeValue<EntityReference>("createdonbehalfby");
      set
      {
        this.OnPropertyChanging(nameof (CreatedOnBehalfBy));
        this.SetAttributeValue("createdonbehalfby", (object) value);
        this.OnPropertyChanged(nameof (CreatedOnBehalfBy));
      }
    }

    [AttributeLogicalName("description")]
    public string Description
    {
      get => this.GetAttributeValue<string>("description");
      set
      {
        this.OnPropertyChanging(nameof (Description));
        this.SetAttributeValue("description", (object) value);
        this.OnPropertyChanged(nameof (Description));
      }
    }

    [AttributeLogicalName("duration")]
    public int? Duration
    {
      get => this.GetAttributeValue<int?>("duration");
      set
      {
        this.OnPropertyChanging(nameof (Duration));
        this.SetAttributeValue("duration", (object) value);
        this.OnPropertyChanged(nameof (Duration));
      }
    }

    [AttributeLogicalName("effectiveintervalend")]
    public DateTime? EffectiveIntervalEnd
    {
      get => this.GetAttributeValue<DateTime?>("effectiveintervalend");
      set
      {
        this.OnPropertyChanging(nameof (EffectiveIntervalEnd));
        this.SetAttributeValue("effectiveintervalend", (object) value);
        this.OnPropertyChanged(nameof (EffectiveIntervalEnd));
      }
    }

    [AttributeLogicalName("effectiveintervalstart")]
    public DateTime? EffectiveIntervalStart
    {
      get => this.GetAttributeValue<DateTime?>("effectiveintervalstart");
      set
      {
        this.OnPropertyChanging(nameof (EffectiveIntervalStart));
        this.SetAttributeValue("effectiveintervalstart", (object) value);
        this.OnPropertyChanged(nameof (EffectiveIntervalStart));
      }
    }

    [AttributeLogicalName("effort")]
    public double? Effort
    {
      get => this.GetAttributeValue<double?>("effort");
      set
      {
        this.OnPropertyChanging(nameof (Effort));
        this.SetAttributeValue("effort", (object) value);
        this.OnPropertyChanged(nameof (Effort));
      }
    }

    [AttributeLogicalName("endtime")]
    public DateTime? EndTime
    {
      get => this.GetAttributeValue<DateTime?>("endtime");
      set
      {
        this.OnPropertyChanging(nameof (EndTime));
        this.SetAttributeValue("endtime", (object) value);
        this.OnPropertyChanged(nameof (EndTime));
      }
    }

    [AttributeLogicalName("extentcode")]
    public int? ExtentCode
    {
      get => this.GetAttributeValue<int?>("extentcode");
      set
      {
        this.OnPropertyChanging(nameof (ExtentCode));
        this.SetAttributeValue("extentcode", (object) value);
        this.OnPropertyChanged(nameof (ExtentCode));
      }
    }

    [AttributeLogicalName("groupdesignator")]
    public string GroupDesignator
    {
      get => this.GetAttributeValue<string>("groupdesignator");
      set
      {
        this.OnPropertyChanging(nameof (GroupDesignator));
        this.SetAttributeValue("groupdesignator", (object) value);
        this.OnPropertyChanged(nameof (GroupDesignator));
      }
    }

    [AttributeLogicalName("innercalendarid")]
    public EntityReference InnerCalendarId
    {
      get => this.GetAttributeValue<EntityReference>("innercalendarid");
      set
      {
        this.OnPropertyChanging(nameof (InnerCalendarId));
        this.SetAttributeValue("innercalendarid", (object) value);
        this.OnPropertyChanged(nameof (InnerCalendarId));
      }
    }

    [AttributeLogicalName("ismodified")]
    public bool? IsModified
    {
      get => this.GetAttributeValue<bool?>("ismodified");
      set
      {
        this.OnPropertyChanging(nameof (IsModified));
        this.SetAttributeValue("ismodified", (object) value);
        this.OnPropertyChanged(nameof (IsModified));
      }
    }

    [AttributeLogicalName("isselected")]
    public bool? IsSelected
    {
      get => this.GetAttributeValue<bool?>("isselected");
      set
      {
        this.OnPropertyChanging(nameof (IsSelected));
        this.SetAttributeValue("isselected", (object) value);
        this.OnPropertyChanged(nameof (IsSelected));
      }
    }

    [AttributeLogicalName("issimple")]
    public bool? IsSimple
    {
      get => this.GetAttributeValue<bool?>("issimple");
      set
      {
        this.OnPropertyChanging(nameof (IsSimple));
        this.SetAttributeValue("issimple", (object) value);
        this.OnPropertyChanged(nameof (IsSimple));
      }
    }

    [AttributeLogicalName("isvaried")]
    public bool? IsVaried
    {
      get => this.GetAttributeValue<bool?>("isvaried");
      set
      {
        this.OnPropertyChanging(nameof (IsVaried));
        this.SetAttributeValue("isvaried", (object) value);
        this.OnPropertyChanged(nameof (IsVaried));
      }
    }

    [AttributeLogicalName("modifiedby")]
    public EntityReference ModifiedBy => this.GetAttributeValue<EntityReference>("modifiedby");

    [AttributeLogicalName("modifiedon")]
    public DateTime? ModifiedOn => this.GetAttributeValue<DateTime?>("modifiedon");

    [AttributeLogicalName("modifiedonbehalfby")]
    public EntityReference ModifiedOnBehalfBy
    {
      get => this.GetAttributeValue<EntityReference>("modifiedonbehalfby");
      set
      {
        this.OnPropertyChanging(nameof (ModifiedOnBehalfBy));
        this.SetAttributeValue("modifiedonbehalfby", (object) value);
        this.OnPropertyChanged(nameof (ModifiedOnBehalfBy));
      }
    }

    [AttributeLogicalName("name")]
    public string Name
    {
      get => this.GetAttributeValue<string>("name");
      set
      {
        this.OnPropertyChanging(nameof (Name));
        this.SetAttributeValue("name", (object) value);
        this.OnPropertyChanged(nameof (Name));
      }
    }

    [AttributeLogicalName("offset")]
    public int? Offset
    {
      get => this.GetAttributeValue<int?>("offset");
      set
      {
        this.OnPropertyChanging(nameof (Offset));
        this.SetAttributeValue("offset", (object) value);
        this.OnPropertyChanged(nameof (Offset));
      }
    }

    [AttributeLogicalName("organizationid")]
    public Guid? OrganizationId => this.GetAttributeValue<Guid?>("organizationid");

    [AttributeLogicalName("pattern")]
    public string Pattern
    {
      get => this.GetAttributeValue<string>("pattern");
      set
      {
        this.OnPropertyChanging(nameof (Pattern));
        this.SetAttributeValue("pattern", (object) value);
        this.OnPropertyChanged(nameof (Pattern));
      }
    }

    [AttributeLogicalName("rank")]
    public int? Rank
    {
      get => this.GetAttributeValue<int?>("rank");
      set
      {
        this.OnPropertyChanging(nameof (Rank));
        this.SetAttributeValue("rank", (object) value);
        this.OnPropertyChanged(nameof (Rank));
      }
    }

    [AttributeLogicalName("starttime")]
    public DateTime? StartTime
    {
      get => this.GetAttributeValue<DateTime?>("starttime");
      set
      {
        this.OnPropertyChanging(nameof (StartTime));
        this.SetAttributeValue("starttime", (object) value);
        this.OnPropertyChanged(nameof (StartTime));
      }
    }

    [AttributeLogicalName("subcode")]
    public int? SubCode
    {
      get => this.GetAttributeValue<int?>("subcode");
      set
      {
        this.OnPropertyChanging(nameof (SubCode));
        this.SetAttributeValue("subcode", (object) value);
        this.OnPropertyChanged(nameof (SubCode));
      }
    }

    [AttributeLogicalName("timecode")]
    public int? TimeCode
    {
      get => this.GetAttributeValue<int?>("timecode");
      set
      {
        this.OnPropertyChanging(nameof (TimeCode));
        this.SetAttributeValue("timecode", (object) value);
        this.OnPropertyChanged(nameof (TimeCode));
      }
    }

    [AttributeLogicalName("timezonecode")]
    public int? TimeZoneCode
    {
      get => this.GetAttributeValue<int?>("timezonecode");
      set
      {
        this.OnPropertyChanging(nameof (TimeZoneCode));
        this.SetAttributeValue("timezonecode", (object) value);
        this.OnPropertyChanged(nameof (TimeZoneCode));
      }
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("userentityinstancedata_calendarrule")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_calendarrule
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_calendarrule), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_calendarrule));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_calendarrule), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_calendarrule));
      }
    }

    [AttributeLogicalName("calendarid")]
    [RelationshipSchemaName("calendar_calendar_rules")]
    public Calendar calendar_calendar_rules
    {
      get => this.GetRelatedEntity<Calendar>(nameof (calendar_calendar_rules), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (calendar_calendar_rules));
        this.SetRelatedEntity<Calendar>(nameof (calendar_calendar_rules), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (calendar_calendar_rules));
      }
    }

    [AttributeLogicalName("innercalendarid")]
    [RelationshipSchemaName("inner_calendar_calendar_rules")]
    public Calendar inner_calendar_calendar_rules
    {
      get
      {
        return this.GetRelatedEntity<Calendar>(nameof (inner_calendar_calendar_rules), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (inner_calendar_calendar_rules));
        this.SetRelatedEntity<Calendar>(nameof (inner_calendar_calendar_rules), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (inner_calendar_calendar_rules));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_calendarrule_createdby")]
    public SystemUser lk_calendarrule_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_calendarrule_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_calendarrule_createdonbehalfby")]
    public SystemUser lk_calendarrule_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_calendarrule_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_calendarrule_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_calendarrule_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_calendarrule_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_calendarrule_modifiedby")]
    public SystemUser lk_calendarrule_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_calendarrule_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_calendarrule_modifiedonbehalfby")]
    public SystemUser lk_calendarrule_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_calendarrule_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_calendarrule_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_calendarrule_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_calendarrule_modifiedonbehalfby));
      }
    }

    public CalendarRule(object anonymousType)
      : this()
    {
      foreach (PropertyInfo property in anonymousType.GetType().GetProperties())
      {
        object obj = property.GetValue(anonymousType, (object[]) null);
        string str = property.Name.ToLower();
        if (str.EndsWith("enum") && obj.GetType().BaseType == typeof (Enum))
        {
          obj = (object) new OptionSetValue((int) obj);
          str = str.Remove(str.Length - "enum".Length);
        }
        switch (str)
        {
          case "id":
            base.Id = (Guid) obj;
            ((DataCollection<string, object>) this.Attributes)["calendarruleid"] = (object) base.Id;
            break;
          case "calendarruleid":
            Guid? nullable = (Guid?) obj;
            if (nullable.HasValue)
            {
              base.Id = nullable.Value;
              ((DataCollection<string, object>) this.Attributes)[str] = (object) base.Id;
              break;
            }
            continue;
          case "formattedvalues":
            ((DataCollection<string, string>) this.FormattedValues).AddRange((IEnumerable<KeyValuePair<string, string>>) obj);
            break;
          default:
            ((DataCollection<string, object>) this.Attributes)[str] = obj;
            break;
        }
      }
    }
  }
}
