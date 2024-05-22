// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.RecurrenceRule
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("recurrencerule")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class RecurrenceRule : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "recurrencerule";
    public const string EntitySchemaName = "RecurrenceRule";
    public const string PrimaryIdAttribute = "ruleid";

    public RecurrenceRule()
      : base("recurrencerule")
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

    [AttributeLogicalName("dayofmonth")]
    public int? DayOfMonth
    {
      get => this.GetAttributeValue<int?>("dayofmonth");
      set
      {
        this.OnPropertyChanging(nameof (DayOfMonth));
        this.SetAttributeValue("dayofmonth", (object) value);
        this.OnPropertyChanged(nameof (DayOfMonth));
      }
    }

    [AttributeLogicalName("daysofweekmask")]
    public int? DaysOfWeekMask
    {
      get => this.GetAttributeValue<int?>("daysofweekmask");
      set
      {
        this.OnPropertyChanging(nameof (DaysOfWeekMask));
        this.SetAttributeValue("daysofweekmask", (object) value);
        this.OnPropertyChanged(nameof (DaysOfWeekMask));
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

    [AttributeLogicalName("effectiveenddate")]
    public DateTime? EffectiveEndDate
    {
      get => this.GetAttributeValue<DateTime?>("effectiveenddate");
      set
      {
        this.OnPropertyChanging(nameof (EffectiveEndDate));
        this.SetAttributeValue("effectiveenddate", (object) value);
        this.OnPropertyChanged(nameof (EffectiveEndDate));
      }
    }

    [AttributeLogicalName("effectivestartdate")]
    public DateTime? EffectiveStartDate
    {
      get => this.GetAttributeValue<DateTime?>("effectivestartdate");
      set
      {
        this.OnPropertyChanging(nameof (EffectiveStartDate));
        this.SetAttributeValue("effectivestartdate", (object) value);
        this.OnPropertyChanged(nameof (EffectiveStartDate));
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

    [AttributeLogicalName("firstdayofweek")]
    public int? FirstDayOfWeek
    {
      get => this.GetAttributeValue<int?>("firstdayofweek");
      set
      {
        this.OnPropertyChanging(nameof (FirstDayOfWeek));
        this.SetAttributeValue("firstdayofweek", (object) value);
        this.OnPropertyChanged(nameof (FirstDayOfWeek));
      }
    }

    [AttributeLogicalName("instance")]
    public OptionSetValue Instance
    {
      get => this.GetAttributeValue<OptionSetValue>("instance");
      set
      {
        this.OnPropertyChanging(nameof (Instance));
        this.SetAttributeValue("instance", (object) value);
        this.OnPropertyChanged(nameof (Instance));
      }
    }

    [AttributeLogicalName("interval")]
    public int? Interval
    {
      get => this.GetAttributeValue<int?>("interval");
      set
      {
        this.OnPropertyChanging(nameof (Interval));
        this.SetAttributeValue("interval", (object) value);
        this.OnPropertyChanged(nameof (Interval));
      }
    }

    [AttributeLogicalName("isnthmonthly")]
    public bool? IsNthMonthly
    {
      get => this.GetAttributeValue<bool?>("isnthmonthly");
      set
      {
        this.OnPropertyChanging(nameof (IsNthMonthly));
        this.SetAttributeValue("isnthmonthly", (object) value);
        this.OnPropertyChanged(nameof (IsNthMonthly));
      }
    }

    [AttributeLogicalName("isnthyearly")]
    public bool? IsNthYearly
    {
      get => this.GetAttributeValue<bool?>("isnthyearly");
      set
      {
        this.OnPropertyChanging(nameof (IsNthYearly));
        this.SetAttributeValue("isnthyearly", (object) value);
        this.OnPropertyChanged(nameof (IsNthYearly));
      }
    }

    [AttributeLogicalName("isregenerate")]
    public bool? IsRegenerate
    {
      get => this.GetAttributeValue<bool?>("isregenerate");
      set
      {
        this.OnPropertyChanging(nameof (IsRegenerate));
        this.SetAttributeValue("isregenerate", (object) value);
        this.OnPropertyChanged(nameof (IsRegenerate));
      }
    }

    [AttributeLogicalName("isweekdaypattern")]
    public bool? IsWeekDayPattern
    {
      get => this.GetAttributeValue<bool?>("isweekdaypattern");
      set
      {
        this.OnPropertyChanging(nameof (IsWeekDayPattern));
        this.SetAttributeValue("isweekdaypattern", (object) value);
        this.OnPropertyChanged(nameof (IsWeekDayPattern));
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

    [AttributeLogicalName("monthofyear")]
    public OptionSetValue MonthOfYear
    {
      get => this.GetAttributeValue<OptionSetValue>("monthofyear");
      set
      {
        this.OnPropertyChanging(nameof (MonthOfYear));
        this.SetAttributeValue("monthofyear", (object) value);
        this.OnPropertyChanged(nameof (MonthOfYear));
      }
    }

    [AttributeLogicalName("objectid")]
    public EntityReference ObjectId
    {
      get => this.GetAttributeValue<EntityReference>("objectid");
      set
      {
        this.OnPropertyChanging(nameof (ObjectId));
        this.SetAttributeValue("objectid", (object) value);
        this.OnPropertyChanged(nameof (ObjectId));
      }
    }

    [AttributeLogicalName("occurrences")]
    public int? Occurrences
    {
      get => this.GetAttributeValue<int?>("occurrences");
      set
      {
        this.OnPropertyChanging(nameof (Occurrences));
        this.SetAttributeValue("occurrences", (object) value);
        this.OnPropertyChanged(nameof (Occurrences));
      }
    }

    [AttributeLogicalName("ownerid")]
    public EntityReference OwnerId
    {
      get => this.GetAttributeValue<EntityReference>("ownerid");
      set
      {
        this.OnPropertyChanging(nameof (OwnerId));
        this.SetAttributeValue("ownerid", (object) value);
        this.OnPropertyChanged(nameof (OwnerId));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    public EntityReference OwningBusinessUnit
    {
      get => this.GetAttributeValue<EntityReference>("owningbusinessunit");
    }

    [AttributeLogicalName("owningteam")]
    public EntityReference OwningTeam => this.GetAttributeValue<EntityReference>("owningteam");

    [AttributeLogicalName("owninguser")]
    public EntityReference OwningUser => this.GetAttributeValue<EntityReference>("owninguser");

    [AttributeLogicalName("patternenddate")]
    public DateTime? PatternEndDate
    {
      get => this.GetAttributeValue<DateTime?>("patternenddate");
      set
      {
        this.OnPropertyChanging(nameof (PatternEndDate));
        this.SetAttributeValue("patternenddate", (object) value);
        this.OnPropertyChanged(nameof (PatternEndDate));
      }
    }

    [AttributeLogicalName("patternendtype")]
    public OptionSetValue PatternEndType
    {
      get => this.GetAttributeValue<OptionSetValue>("patternendtype");
      set
      {
        this.OnPropertyChanging(nameof (PatternEndType));
        this.SetAttributeValue("patternendtype", (object) value);
        this.OnPropertyChanged(nameof (PatternEndType));
      }
    }

    [AttributeLogicalName("patternstartdate")]
    public DateTime? PatternStartDate
    {
      get => this.GetAttributeValue<DateTime?>("patternstartdate");
      set
      {
        this.OnPropertyChanging(nameof (PatternStartDate));
        this.SetAttributeValue("patternstartdate", (object) value);
        this.OnPropertyChanged(nameof (PatternStartDate));
      }
    }

    [AttributeLogicalName("recurrencepatterntype")]
    public OptionSetValue RecurrencePatternType
    {
      get => this.GetAttributeValue<OptionSetValue>("recurrencepatterntype");
      set
      {
        this.OnPropertyChanging(nameof (RecurrencePatternType));
        this.SetAttributeValue("recurrencepatterntype", (object) value);
        this.OnPropertyChanged(nameof (RecurrencePatternType));
      }
    }

    [AttributeLogicalName("ruleid")]
    public Guid? RuleId
    {
      get => this.GetAttributeValue<Guid?>("ruleid");
      set
      {
        this.OnPropertyChanging(nameof (RuleId));
        this.SetAttributeValue("ruleid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (RuleId));
      }
    }

    [AttributeLogicalName("ruleid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.RuleId = new Guid?(value);
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

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("recurrencerule_recurringappointmentmaster")]
    public IEnumerable<RecurringAppointmentMaster> recurrencerule_recurringappointmentmaster
    {
      get
      {
        return this.GetRelatedEntities<RecurringAppointmentMaster>(nameof (recurrencerule_recurringappointmentmaster), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (recurrencerule_recurringappointmentmaster));
        this.SetRelatedEntities<RecurringAppointmentMaster>(nameof (recurrencerule_recurringappointmentmaster), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (recurrencerule_recurringappointmentmaster));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("activity_pointer_recurrencerule")]
    public ActivityPointer activity_pointer_recurrencerule
    {
      get
      {
        return this.GetRelatedEntity<ActivityPointer>(nameof (activity_pointer_recurrencerule), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (activity_pointer_recurrencerule));
        this.SetRelatedEntity<ActivityPointer>(nameof (activity_pointer_recurrencerule), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (activity_pointer_recurrencerule));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_recurrencerule")]
    public BusinessUnit business_unit_recurrencerule
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_recurrencerule), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_recurrencerule_createdby")]
    public SystemUser lk_recurrencerule_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_recurrencerule_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_recurrencerule_modifiedby")]
    public SystemUser lk_recurrencerule_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_recurrencerule_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_recurrencerulebase_createdonbehalfby")]
    public SystemUser lk_recurrencerulebase_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_recurrencerulebase_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_recurrencerulebase_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_recurrencerulebase_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_recurrencerulebase_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_recurrencerulebase_modifiedonbehalfby")]
    public SystemUser lk_recurrencerulebase_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_recurrencerulebase_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_recurrencerulebase_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_recurrencerulebase_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_recurrencerulebase_modifiedonbehalfby));
      }
    }

    public RecurrenceRule(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ruleid"] = (object) base.Id;
            break;
          case "ruleid":
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
