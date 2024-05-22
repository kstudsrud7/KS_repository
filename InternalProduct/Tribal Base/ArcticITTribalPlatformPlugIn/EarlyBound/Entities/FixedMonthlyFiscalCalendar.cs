// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.FixedMonthlyFiscalCalendar
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("fixedmonthlyfiscalcalendar")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class FixedMonthlyFiscalCalendar : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "fixedmonthlyfiscalcalendar";
    public const string EntitySchemaName = "FixedMonthlyFiscalCalendar";
    public const string PrimaryIdAttribute = "userfiscalcalendarid";

    public FixedMonthlyFiscalCalendar()
      : base("fixedmonthlyfiscalcalendar")
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
    public EntityReference BusinessUnitId
    {
      get => this.GetAttributeValue<EntityReference>("businessunitid");
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

    [AttributeLogicalName("effectiveon")]
    public DateTime? EffectiveOn
    {
      get => this.GetAttributeValue<DateTime?>("effectiveon");
      set
      {
        this.OnPropertyChanging(nameof (EffectiveOn));
        this.SetAttributeValue("effectiveon", (object) value);
        this.OnPropertyChanged(nameof (EffectiveOn));
      }
    }

    [AttributeLogicalName("exchangerate")]
    public Decimal? ExchangeRate => this.GetAttributeValue<Decimal?>("exchangerate");

    [AttributeLogicalName("fiscalperiodtype")]
    public int? FiscalPeriodType => this.GetAttributeValue<int?>("fiscalperiodtype");

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

    [AttributeLogicalName("period1")]
    public Money Period1
    {
      get => this.GetAttributeValue<Money>("period1");
      set
      {
        this.OnPropertyChanging(nameof (Period1));
        this.SetAttributeValue("period1", (object) value);
        this.OnPropertyChanged(nameof (Period1));
      }
    }

    [AttributeLogicalName("period1_base")]
    public Money Period1_Base => this.GetAttributeValue<Money>("period1_base");

    [AttributeLogicalName("period10")]
    public Money Period10
    {
      get => this.GetAttributeValue<Money>("period10");
      set
      {
        this.OnPropertyChanging(nameof (Period10));
        this.SetAttributeValue("period10", (object) value);
        this.OnPropertyChanged(nameof (Period10));
      }
    }

    [AttributeLogicalName("period10_base")]
    public Money Period10_Base => this.GetAttributeValue<Money>("period10_base");

    [AttributeLogicalName("period11")]
    public Money Period11
    {
      get => this.GetAttributeValue<Money>("period11");
      set
      {
        this.OnPropertyChanging(nameof (Period11));
        this.SetAttributeValue("period11", (object) value);
        this.OnPropertyChanged(nameof (Period11));
      }
    }

    [AttributeLogicalName("period11_base")]
    public Money Period11_Base => this.GetAttributeValue<Money>("period11_base");

    [AttributeLogicalName("period12")]
    public Money Period12
    {
      get => this.GetAttributeValue<Money>("period12");
      set
      {
        this.OnPropertyChanging(nameof (Period12));
        this.SetAttributeValue("period12", (object) value);
        this.OnPropertyChanged(nameof (Period12));
      }
    }

    [AttributeLogicalName("period12_base")]
    public Money Period12_Base => this.GetAttributeValue<Money>("period12_base");

    [AttributeLogicalName("period13")]
    public Money Period13
    {
      get => this.GetAttributeValue<Money>("period13");
      set
      {
        this.OnPropertyChanging(nameof (Period13));
        this.SetAttributeValue("period13", (object) value);
        this.OnPropertyChanged(nameof (Period13));
      }
    }

    [AttributeLogicalName("period13_base")]
    public Money Period13_Base => this.GetAttributeValue<Money>("period13_base");

    [AttributeLogicalName("period2")]
    public Money Period2
    {
      get => this.GetAttributeValue<Money>("period2");
      set
      {
        this.OnPropertyChanging(nameof (Period2));
        this.SetAttributeValue("period2", (object) value);
        this.OnPropertyChanged(nameof (Period2));
      }
    }

    [AttributeLogicalName("period2_base")]
    public Money Period2_Base => this.GetAttributeValue<Money>("period2_base");

    [AttributeLogicalName("period3")]
    public Money Period3
    {
      get => this.GetAttributeValue<Money>("period3");
      set
      {
        this.OnPropertyChanging(nameof (Period3));
        this.SetAttributeValue("period3", (object) value);
        this.OnPropertyChanged(nameof (Period3));
      }
    }

    [AttributeLogicalName("period3_base")]
    public Money Period3_Base => this.GetAttributeValue<Money>("period3_base");

    [AttributeLogicalName("period4")]
    public Money Period4
    {
      get => this.GetAttributeValue<Money>("period4");
      set
      {
        this.OnPropertyChanging(nameof (Period4));
        this.SetAttributeValue("period4", (object) value);
        this.OnPropertyChanged(nameof (Period4));
      }
    }

    [AttributeLogicalName("period4_base")]
    public Money Period4_Base => this.GetAttributeValue<Money>("period4_base");

    [AttributeLogicalName("period5")]
    public Money Period5
    {
      get => this.GetAttributeValue<Money>("period5");
      set
      {
        this.OnPropertyChanging(nameof (Period5));
        this.SetAttributeValue("period5", (object) value);
        this.OnPropertyChanged(nameof (Period5));
      }
    }

    [AttributeLogicalName("period5_base")]
    public Money Period5_Base => this.GetAttributeValue<Money>("period5_base");

    [AttributeLogicalName("period6")]
    public Money Period6
    {
      get => this.GetAttributeValue<Money>("period6");
      set
      {
        this.OnPropertyChanging(nameof (Period6));
        this.SetAttributeValue("period6", (object) value);
        this.OnPropertyChanged(nameof (Period6));
      }
    }

    [AttributeLogicalName("period6_base")]
    public Money Period6_Base => this.GetAttributeValue<Money>("period6_base");

    [AttributeLogicalName("period7")]
    public Money Period7
    {
      get => this.GetAttributeValue<Money>("period7");
      set
      {
        this.OnPropertyChanging(nameof (Period7));
        this.SetAttributeValue("period7", (object) value);
        this.OnPropertyChanged(nameof (Period7));
      }
    }

    [AttributeLogicalName("period7_base")]
    public Money Period7_Base => this.GetAttributeValue<Money>("period7_base");

    [AttributeLogicalName("period8")]
    public Money Period8
    {
      get => this.GetAttributeValue<Money>("period8");
      set
      {
        this.OnPropertyChanging(nameof (Period8));
        this.SetAttributeValue("period8", (object) value);
        this.OnPropertyChanged(nameof (Period8));
      }
    }

    [AttributeLogicalName("period8_base")]
    public Money Period8_Base => this.GetAttributeValue<Money>("period8_base");

    [AttributeLogicalName("period9")]
    public Money Period9
    {
      get => this.GetAttributeValue<Money>("period9");
      set
      {
        this.OnPropertyChanging(nameof (Period9));
        this.SetAttributeValue("period9", (object) value);
        this.OnPropertyChanged(nameof (Period9));
      }
    }

    [AttributeLogicalName("period9_base")]
    public Money Period9_Base => this.GetAttributeValue<Money>("period9_base");

    [AttributeLogicalName("salespersonid")]
    public EntityReference SalesPersonId
    {
      get => this.GetAttributeValue<EntityReference>("salespersonid");
      set
      {
        this.OnPropertyChanging(nameof (SalesPersonId));
        this.SetAttributeValue("salespersonid", (object) value);
        this.OnPropertyChanged(nameof (SalesPersonId));
      }
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

    [AttributeLogicalName("transactioncurrencyid")]
    public EntityReference TransactionCurrencyId
    {
      get => this.GetAttributeValue<EntityReference>("transactioncurrencyid");
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrencyId));
        this.SetAttributeValue("transactioncurrencyid", (object) value);
        this.OnPropertyChanged(nameof (TransactionCurrencyId));
      }
    }

    [AttributeLogicalName("userfiscalcalendarid")]
    public Guid? UserFiscalCalendarId
    {
      get => this.GetAttributeValue<Guid?>("userfiscalcalendarid");
      set
      {
        this.OnPropertyChanging(nameof (UserFiscalCalendarId));
        this.SetAttributeValue("userfiscalcalendarid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (UserFiscalCalendarId));
      }
    }

    [AttributeLogicalName("userfiscalcalendarid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.UserFiscalCalendarId = new Guid?(value);
    }

    [AttributeLogicalName("utcconversiontimezonecode")]
    public int? UTCConversionTimeZoneCode
    {
      get => this.GetAttributeValue<int?>("utcconversiontimezonecode");
      set
      {
        this.OnPropertyChanging(nameof (UTCConversionTimeZoneCode));
        this.SetAttributeValue("utcconversiontimezonecode", (object) value);
        this.OnPropertyChanged(nameof (UTCConversionTimeZoneCode));
      }
    }

    [RelationshipSchemaName("FixedMonthlyFiscalCalendar_AsyncOperations")]
    public IEnumerable<AsyncOperation> FixedMonthlyFiscalCalendar_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (FixedMonthlyFiscalCalendar_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (FixedMonthlyFiscalCalendar_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (FixedMonthlyFiscalCalendar_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (FixedMonthlyFiscalCalendar_AsyncOperations));
      }
    }

    [RelationshipSchemaName("FixedMonthlyFiscalCalendar_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> FixedMonthlyFiscalCalendar_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (FixedMonthlyFiscalCalendar_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (FixedMonthlyFiscalCalendar_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (FixedMonthlyFiscalCalendar_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (FixedMonthlyFiscalCalendar_BulkDeleteFailures));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_fixedmonthlyfiscalcalendar_createdby")]
    public SystemUser lk_fixedmonthlyfiscalcalendar_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_fixedmonthlyfiscalcalendar_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_fixedmonthlyfiscalcalendar_createdonbehalfby")]
    public SystemUser lk_fixedmonthlyfiscalcalendar_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_fixedmonthlyfiscalcalendar_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_fixedmonthlyfiscalcalendar_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_fixedmonthlyfiscalcalendar_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_fixedmonthlyfiscalcalendar_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_fixedmonthlyfiscalcalendar_modifiedby")]
    public SystemUser lk_fixedmonthlyfiscalcalendar_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_fixedmonthlyfiscalcalendar_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_fixedmonthlyfiscalcalendar_modifiedonbehalfby")]
    public SystemUser lk_fixedmonthlyfiscalcalendar_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_fixedmonthlyfiscalcalendar_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_fixedmonthlyfiscalcalendar_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_fixedmonthlyfiscalcalendar_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_fixedmonthlyfiscalcalendar_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("salespersonid")]
    [RelationshipSchemaName("lk_fixedmonthlyfiscalcalendar_salespersonid")]
    public SystemUser lk_fixedmonthlyfiscalcalendar_salespersonid
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_fixedmonthlyfiscalcalendar_salespersonid), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_fixedmonthlyfiscalcalendar_salespersonid));
        this.SetRelatedEntity<SystemUser>(nameof (lk_fixedmonthlyfiscalcalendar_salespersonid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_fixedmonthlyfiscalcalendar_salespersonid));
      }
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("transactioncurrency_fixedmonthlyfiscalcalendar")]
    public TransactionCurrency transactioncurrency_fixedmonthlyfiscalcalendar
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (transactioncurrency_fixedmonthlyfiscalcalendar), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (transactioncurrency_fixedmonthlyfiscalcalendar));
        this.SetRelatedEntity<TransactionCurrency>(nameof (transactioncurrency_fixedmonthlyfiscalcalendar), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (transactioncurrency_fixedmonthlyfiscalcalendar));
      }
    }

    public FixedMonthlyFiscalCalendar(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["userfiscalcalendarid"] = (object) base.Id;
            break;
          case "userfiscalcalendarid":
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
