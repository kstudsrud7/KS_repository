// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.TimeZoneRule
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("timezonerule")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class TimeZoneRule : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "timezonerule";
    public const string EntitySchemaName = "TimeZoneRule";
    public const string PrimaryIdAttribute = "timezoneruleid";
    public const string PrimaryNameAttribute = "timezoneruleversionnumber";

    public TimeZoneRule()
      : base("timezonerule")
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

    [AttributeLogicalName("bias")]
    public int? Bias
    {
      get => this.GetAttributeValue<int?>("bias");
      set
      {
        this.OnPropertyChanging(nameof (Bias));
        this.SetAttributeValue("bias", (object) value);
        this.OnPropertyChanged(nameof (Bias));
      }
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

    [AttributeLogicalName("daylightbias")]
    public int? DaylightBias
    {
      get => this.GetAttributeValue<int?>("daylightbias");
      set
      {
        this.OnPropertyChanging(nameof (DaylightBias));
        this.SetAttributeValue("daylightbias", (object) value);
        this.OnPropertyChanged(nameof (DaylightBias));
      }
    }

    [AttributeLogicalName("daylightday")]
    public int? DaylightDay
    {
      get => this.GetAttributeValue<int?>("daylightday");
      set
      {
        this.OnPropertyChanging(nameof (DaylightDay));
        this.SetAttributeValue("daylightday", (object) value);
        this.OnPropertyChanged(nameof (DaylightDay));
      }
    }

    [AttributeLogicalName("daylightdayofweek")]
    public int? DaylightDayOfWeek
    {
      get => this.GetAttributeValue<int?>("daylightdayofweek");
      set
      {
        this.OnPropertyChanging(nameof (DaylightDayOfWeek));
        this.SetAttributeValue("daylightdayofweek", (object) value);
        this.OnPropertyChanged(nameof (DaylightDayOfWeek));
      }
    }

    [AttributeLogicalName("daylighthour")]
    public int? DaylightHour
    {
      get => this.GetAttributeValue<int?>("daylighthour");
      set
      {
        this.OnPropertyChanging(nameof (DaylightHour));
        this.SetAttributeValue("daylighthour", (object) value);
        this.OnPropertyChanged(nameof (DaylightHour));
      }
    }

    [AttributeLogicalName("daylightminute")]
    public int? DaylightMinute
    {
      get => this.GetAttributeValue<int?>("daylightminute");
      set
      {
        this.OnPropertyChanging(nameof (DaylightMinute));
        this.SetAttributeValue("daylightminute", (object) value);
        this.OnPropertyChanged(nameof (DaylightMinute));
      }
    }

    [AttributeLogicalName("daylightmonth")]
    public int? DaylightMonth
    {
      get => this.GetAttributeValue<int?>("daylightmonth");
      set
      {
        this.OnPropertyChanging(nameof (DaylightMonth));
        this.SetAttributeValue("daylightmonth", (object) value);
        this.OnPropertyChanged(nameof (DaylightMonth));
      }
    }

    [AttributeLogicalName("daylightsecond")]
    public int? DaylightSecond
    {
      get => this.GetAttributeValue<int?>("daylightsecond");
      set
      {
        this.OnPropertyChanging(nameof (DaylightSecond));
        this.SetAttributeValue("daylightsecond", (object) value);
        this.OnPropertyChanged(nameof (DaylightSecond));
      }
    }

    [AttributeLogicalName("daylightyear")]
    public int? DaylightYear
    {
      get => this.GetAttributeValue<int?>("daylightyear");
      set
      {
        this.OnPropertyChanging(nameof (DaylightYear));
        this.SetAttributeValue("daylightyear", (object) value);
        this.OnPropertyChanged(nameof (DaylightYear));
      }
    }

    [AttributeLogicalName("effectivedatetime")]
    public DateTime? EffectiveDateTime
    {
      get => this.GetAttributeValue<DateTime?>("effectivedatetime");
      set
      {
        this.OnPropertyChanging(nameof (EffectiveDateTime));
        this.SetAttributeValue("effectivedatetime", (object) value);
        this.OnPropertyChanged(nameof (EffectiveDateTime));
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

    [AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get => this.GetAttributeValue<EntityReference>("organizationid");
    }

    [AttributeLogicalName("standardbias")]
    public int? StandardBias
    {
      get => this.GetAttributeValue<int?>("standardbias");
      set
      {
        this.OnPropertyChanging(nameof (StandardBias));
        this.SetAttributeValue("standardbias", (object) value);
        this.OnPropertyChanged(nameof (StandardBias));
      }
    }

    [AttributeLogicalName("standardday")]
    public int? StandardDay
    {
      get => this.GetAttributeValue<int?>("standardday");
      set
      {
        this.OnPropertyChanging(nameof (StandardDay));
        this.SetAttributeValue("standardday", (object) value);
        this.OnPropertyChanged(nameof (StandardDay));
      }
    }

    [AttributeLogicalName("standarddayofweek")]
    public int? StandardDayOfWeek
    {
      get => this.GetAttributeValue<int?>("standarddayofweek");
      set
      {
        this.OnPropertyChanging(nameof (StandardDayOfWeek));
        this.SetAttributeValue("standarddayofweek", (object) value);
        this.OnPropertyChanged(nameof (StandardDayOfWeek));
      }
    }

    [AttributeLogicalName("standardhour")]
    public int? StandardHour
    {
      get => this.GetAttributeValue<int?>("standardhour");
      set
      {
        this.OnPropertyChanging(nameof (StandardHour));
        this.SetAttributeValue("standardhour", (object) value);
        this.OnPropertyChanged(nameof (StandardHour));
      }
    }

    [AttributeLogicalName("standardminute")]
    public int? StandardMinute
    {
      get => this.GetAttributeValue<int?>("standardminute");
      set
      {
        this.OnPropertyChanging(nameof (StandardMinute));
        this.SetAttributeValue("standardminute", (object) value);
        this.OnPropertyChanged(nameof (StandardMinute));
      }
    }

    [AttributeLogicalName("standardmonth")]
    public int? StandardMonth
    {
      get => this.GetAttributeValue<int?>("standardmonth");
      set
      {
        this.OnPropertyChanging(nameof (StandardMonth));
        this.SetAttributeValue("standardmonth", (object) value);
        this.OnPropertyChanged(nameof (StandardMonth));
      }
    }

    [AttributeLogicalName("standardsecond")]
    public int? StandardSecond
    {
      get => this.GetAttributeValue<int?>("standardsecond");
      set
      {
        this.OnPropertyChanging(nameof (StandardSecond));
        this.SetAttributeValue("standardsecond", (object) value);
        this.OnPropertyChanged(nameof (StandardSecond));
      }
    }

    [AttributeLogicalName("standardyear")]
    public int? StandardYear
    {
      get => this.GetAttributeValue<int?>("standardyear");
      set
      {
        this.OnPropertyChanging(nameof (StandardYear));
        this.SetAttributeValue("standardyear", (object) value);
        this.OnPropertyChanged(nameof (StandardYear));
      }
    }

    [AttributeLogicalName("timezonedefinitionid")]
    public EntityReference TimeZoneDefinitionId
    {
      get => this.GetAttributeValue<EntityReference>("timezonedefinitionid");
      set
      {
        this.OnPropertyChanging(nameof (TimeZoneDefinitionId));
        this.SetAttributeValue("timezonedefinitionid", (object) value);
        this.OnPropertyChanged(nameof (TimeZoneDefinitionId));
      }
    }

    [AttributeLogicalName("timezoneruleid")]
    public Guid? TimeZoneRuleId
    {
      get => this.GetAttributeValue<Guid?>("timezoneruleid");
      set
      {
        this.OnPropertyChanging(nameof (TimeZoneRuleId));
        this.SetAttributeValue("timezoneruleid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (TimeZoneRuleId));
      }
    }

    [AttributeLogicalName("timezoneruleid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.TimeZoneRuleId = new Guid?(value);
    }

    [AttributeLogicalName("timezoneruleversionnumber")]
    public int? TimeZoneRuleVersionNumber
    {
      get => this.GetAttributeValue<int?>("timezoneruleversionnumber");
      set
      {
        this.OnPropertyChanging(nameof (TimeZoneRuleVersionNumber));
        this.SetAttributeValue("timezoneruleversionnumber", (object) value);
        this.OnPropertyChanged(nameof (TimeZoneRuleVersionNumber));
      }
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("userentityinstancedata_timezonerule")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_timezonerule
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_timezonerule), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_timezonerule));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_timezonerule), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_timezonerule));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_timezonerule_createdby")]
    public SystemUser lk_timezonerule_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_timezonerule_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_timezonerule_createdonbehalfby")]
    public SystemUser lk_timezonerule_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_timezonerule_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_timezonerule_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_timezonerule_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_timezonerule_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_timezonerule_modifiedby")]
    public SystemUser lk_timezonerule_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_timezonerule_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_timezonerule_modifiedonbehalfby")]
    public SystemUser lk_timezonerule_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_timezonerule_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_timezonerule_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_timezonerule_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_timezonerule_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("timezonedefinitionid")]
    [RelationshipSchemaName("lk_timezonerule_timezonedefinitionid")]
    public TimeZoneDefinition lk_timezonerule_timezonedefinitionid
    {
      get
      {
        return this.GetRelatedEntity<TimeZoneDefinition>(nameof (lk_timezonerule_timezonedefinitionid), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_timezonerule_timezonedefinitionid));
        this.SetRelatedEntity<TimeZoneDefinition>(nameof (lk_timezonerule_timezonedefinitionid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_timezonerule_timezonedefinitionid));
      }
    }

    public TimeZoneRule(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["timezoneruleid"] = (object) base.Id;
            break;
          case "timezoneruleid":
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
