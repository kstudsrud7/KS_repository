// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.MonthlyFiscalCalendar
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("monthlyfiscalcalendar")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class MonthlyFiscalCalendar : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "monthlyfiscalcalendar";
    public const string EntitySchemaName = "MonthlyFiscalCalendar";
    public const string PrimaryIdAttribute = "userfiscalcalendarid";

    public MonthlyFiscalCalendar()
      : base("monthlyfiscalcalendar")
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

    [AttributeLogicalName("month1")]
    public Money Month1
    {
      get => this.GetAttributeValue<Money>("month1");
      set
      {
        this.OnPropertyChanging(nameof (Month1));
        this.SetAttributeValue("month1", (object) value);
        this.OnPropertyChanged(nameof (Month1));
      }
    }

    [AttributeLogicalName("month1_base")]
    public Money Month1_Base => this.GetAttributeValue<Money>("month1_base");

    [AttributeLogicalName("month10")]
    public Money Month10
    {
      get => this.GetAttributeValue<Money>("month10");
      set
      {
        this.OnPropertyChanging(nameof (Month10));
        this.SetAttributeValue("month10", (object) value);
        this.OnPropertyChanged(nameof (Month10));
      }
    }

    [AttributeLogicalName("month10_base")]
    public Money Month10_Base => this.GetAttributeValue<Money>("month10_base");

    [AttributeLogicalName("month11")]
    public Money Month11
    {
      get => this.GetAttributeValue<Money>("month11");
      set
      {
        this.OnPropertyChanging(nameof (Month11));
        this.SetAttributeValue("month11", (object) value);
        this.OnPropertyChanged(nameof (Month11));
      }
    }

    [AttributeLogicalName("month11_base")]
    public Money Month11_Base => this.GetAttributeValue<Money>("month11_base");

    [AttributeLogicalName("month12")]
    public Money Month12
    {
      get => this.GetAttributeValue<Money>("month12");
      set
      {
        this.OnPropertyChanging(nameof (Month12));
        this.SetAttributeValue("month12", (object) value);
        this.OnPropertyChanged(nameof (Month12));
      }
    }

    [AttributeLogicalName("month12_base")]
    public Money Month12_Base => this.GetAttributeValue<Money>("month12_base");

    [AttributeLogicalName("month2")]
    public Money Month2
    {
      get => this.GetAttributeValue<Money>("month2");
      set
      {
        this.OnPropertyChanging(nameof (Month2));
        this.SetAttributeValue("month2", (object) value);
        this.OnPropertyChanged(nameof (Month2));
      }
    }

    [AttributeLogicalName("month2_base")]
    public Money Month2_Base => this.GetAttributeValue<Money>("month2_base");

    [AttributeLogicalName("month3")]
    public Money Month3
    {
      get => this.GetAttributeValue<Money>("month3");
      set
      {
        this.OnPropertyChanging(nameof (Month3));
        this.SetAttributeValue("month3", (object) value);
        this.OnPropertyChanged(nameof (Month3));
      }
    }

    [AttributeLogicalName("month3_base")]
    public Money Month3_Base => this.GetAttributeValue<Money>("month3_base");

    [AttributeLogicalName("month4")]
    public Money Month4
    {
      get => this.GetAttributeValue<Money>("month4");
      set
      {
        this.OnPropertyChanging(nameof (Month4));
        this.SetAttributeValue("month4", (object) value);
        this.OnPropertyChanged(nameof (Month4));
      }
    }

    [AttributeLogicalName("month4_base")]
    public Money Month4_Base => this.GetAttributeValue<Money>("month4_base");

    [AttributeLogicalName("month5")]
    public Money Month5
    {
      get => this.GetAttributeValue<Money>("month5");
      set
      {
        this.OnPropertyChanging(nameof (Month5));
        this.SetAttributeValue("month5", (object) value);
        this.OnPropertyChanged(nameof (Month5));
      }
    }

    [AttributeLogicalName("month5_base")]
    public Money Month5_Base => this.GetAttributeValue<Money>("month5_base");

    [AttributeLogicalName("month6")]
    public Money Month6
    {
      get => this.GetAttributeValue<Money>("month6");
      set
      {
        this.OnPropertyChanging(nameof (Month6));
        this.SetAttributeValue("month6", (object) value);
        this.OnPropertyChanged(nameof (Month6));
      }
    }

    [AttributeLogicalName("month6_base")]
    public Money Month6_Base => this.GetAttributeValue<Money>("month6_base");

    [AttributeLogicalName("month7")]
    public Money Month7
    {
      get => this.GetAttributeValue<Money>("month7");
      set
      {
        this.OnPropertyChanging(nameof (Month7));
        this.SetAttributeValue("month7", (object) value);
        this.OnPropertyChanged(nameof (Month7));
      }
    }

    [AttributeLogicalName("month7_base")]
    public Money Month7_Base => this.GetAttributeValue<Money>("month7_base");

    [AttributeLogicalName("month8")]
    public Money Month8
    {
      get => this.GetAttributeValue<Money>("month8");
      set
      {
        this.OnPropertyChanging(nameof (Month8));
        this.SetAttributeValue("month8", (object) value);
        this.OnPropertyChanged(nameof (Month8));
      }
    }

    [AttributeLogicalName("month8_base")]
    public Money Month8_Base => this.GetAttributeValue<Money>("month8_base");

    [AttributeLogicalName("month9")]
    public Money Month9
    {
      get => this.GetAttributeValue<Money>("month9");
      set
      {
        this.OnPropertyChanging(nameof (Month9));
        this.SetAttributeValue("month9", (object) value);
        this.OnPropertyChanged(nameof (Month9));
      }
    }

    [AttributeLogicalName("month9_base")]
    public Money Month9_Base => this.GetAttributeValue<Money>("month9_base");

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

    [RelationshipSchemaName("MonthlyFiscalCalendar_AsyncOperations")]
    public IEnumerable<AsyncOperation> MonthlyFiscalCalendar_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (MonthlyFiscalCalendar_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (MonthlyFiscalCalendar_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (MonthlyFiscalCalendar_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (MonthlyFiscalCalendar_AsyncOperations));
      }
    }

    [RelationshipSchemaName("MonthlyFiscalCalendar_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> MonthlyFiscalCalendar_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (MonthlyFiscalCalendar_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (MonthlyFiscalCalendar_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (MonthlyFiscalCalendar_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (MonthlyFiscalCalendar_BulkDeleteFailures));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_monthlyfiscalcalendar_createdby")]
    public SystemUser lk_monthlyfiscalcalendar_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_monthlyfiscalcalendar_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_monthlyfiscalcalendar_createdonbehalfby")]
    public SystemUser lk_monthlyfiscalcalendar_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_monthlyfiscalcalendar_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_monthlyfiscalcalendar_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_monthlyfiscalcalendar_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_monthlyfiscalcalendar_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_monthlyfiscalcalendar_modifiedby")]
    public SystemUser lk_monthlyfiscalcalendar_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_monthlyfiscalcalendar_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_monthlyfiscalcalendar_modifiedonbehalfby")]
    public SystemUser lk_monthlyfiscalcalendar_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_monthlyfiscalcalendar_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_monthlyfiscalcalendar_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_monthlyfiscalcalendar_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_monthlyfiscalcalendar_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("salespersonid")]
    [RelationshipSchemaName("lk_monthlyfiscalcalendar_salespersonid")]
    public SystemUser lk_monthlyfiscalcalendar_salespersonid
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_monthlyfiscalcalendar_salespersonid), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_monthlyfiscalcalendar_salespersonid));
        this.SetRelatedEntity<SystemUser>(nameof (lk_monthlyfiscalcalendar_salespersonid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_monthlyfiscalcalendar_salespersonid));
      }
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("transactioncurrency_monthlyfiscalcalendar")]
    public TransactionCurrency transactioncurrency_monthlyfiscalcalendar
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (transactioncurrency_monthlyfiscalcalendar), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (transactioncurrency_monthlyfiscalcalendar));
        this.SetRelatedEntity<TransactionCurrency>(nameof (transactioncurrency_monthlyfiscalcalendar), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (transactioncurrency_monthlyfiscalcalendar));
      }
    }

    public MonthlyFiscalCalendar(object anonymousType)
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
