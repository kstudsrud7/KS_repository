// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.QuarterlyFiscalCalendar
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("quarterlyfiscalcalendar")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class QuarterlyFiscalCalendar : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "quarterlyfiscalcalendar";
    public const string EntitySchemaName = "QuarterlyFiscalCalendar";
    public const string PrimaryIdAttribute = "userfiscalcalendarid";

    public QuarterlyFiscalCalendar()
      : base("quarterlyfiscalcalendar")
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

    [AttributeLogicalName("quarter1")]
    public Money Quarter1
    {
      get => this.GetAttributeValue<Money>("quarter1");
      set
      {
        this.OnPropertyChanging(nameof (Quarter1));
        this.SetAttributeValue("quarter1", (object) value);
        this.OnPropertyChanged(nameof (Quarter1));
      }
    }

    [AttributeLogicalName("quarter1_base")]
    public Money Quarter1_Base => this.GetAttributeValue<Money>("quarter1_base");

    [AttributeLogicalName("quarter2")]
    public Money Quarter2
    {
      get => this.GetAttributeValue<Money>("quarter2");
      set
      {
        this.OnPropertyChanging(nameof (Quarter2));
        this.SetAttributeValue("quarter2", (object) value);
        this.OnPropertyChanged(nameof (Quarter2));
      }
    }

    [AttributeLogicalName("quarter2_base")]
    public Money Quarter2_Base => this.GetAttributeValue<Money>("quarter2_base");

    [AttributeLogicalName("quarter3")]
    public Money Quarter3
    {
      get => this.GetAttributeValue<Money>("quarter3");
      set
      {
        this.OnPropertyChanging(nameof (Quarter3));
        this.SetAttributeValue("quarter3", (object) value);
        this.OnPropertyChanged(nameof (Quarter3));
      }
    }

    [AttributeLogicalName("quarter3_base")]
    public Money Quarter3_Base => this.GetAttributeValue<Money>("quarter3_base");

    [AttributeLogicalName("quarter4")]
    public Money Quarter4
    {
      get => this.GetAttributeValue<Money>("quarter4");
      set
      {
        this.OnPropertyChanging(nameof (Quarter4));
        this.SetAttributeValue("quarter4", (object) value);
        this.OnPropertyChanged(nameof (Quarter4));
      }
    }

    [AttributeLogicalName("quarter4_base")]
    public Money Quarter4_Base => this.GetAttributeValue<Money>("quarter4_base");

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

    [RelationshipSchemaName("QuarterlyFiscalCalendar_AsyncOperations")]
    public IEnumerable<AsyncOperation> QuarterlyFiscalCalendar_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (QuarterlyFiscalCalendar_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (QuarterlyFiscalCalendar_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (QuarterlyFiscalCalendar_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (QuarterlyFiscalCalendar_AsyncOperations));
      }
    }

    [RelationshipSchemaName("QuarterlyFiscalCalendar_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> QuarterlyFiscalCalendar_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (QuarterlyFiscalCalendar_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (QuarterlyFiscalCalendar_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (QuarterlyFiscalCalendar_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (QuarterlyFiscalCalendar_BulkDeleteFailures));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_quarterlyfiscalcalendar_createdby")]
    public SystemUser lk_quarterlyfiscalcalendar_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_quarterlyfiscalcalendar_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_quarterlyfiscalcalendar_createdonbehalfby")]
    public SystemUser lk_quarterlyfiscalcalendar_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_quarterlyfiscalcalendar_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_quarterlyfiscalcalendar_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_quarterlyfiscalcalendar_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_quarterlyfiscalcalendar_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_quarterlyfiscalcalendar_modifiedby")]
    public SystemUser lk_quarterlyfiscalcalendar_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_quarterlyfiscalcalendar_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_quarterlyfiscalcalendar_modifiedonbehalfby")]
    public SystemUser lk_quarterlyfiscalcalendar_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_quarterlyfiscalcalendar_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_quarterlyfiscalcalendar_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_quarterlyfiscalcalendar_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_quarterlyfiscalcalendar_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("salespersonid")]
    [RelationshipSchemaName("lk_quarterlyfiscalcalendar_salespersonid")]
    public SystemUser lk_quarterlyfiscalcalendar_salespersonid
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_quarterlyfiscalcalendar_salespersonid), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_quarterlyfiscalcalendar_salespersonid));
        this.SetRelatedEntity<SystemUser>(nameof (lk_quarterlyfiscalcalendar_salespersonid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_quarterlyfiscalcalendar_salespersonid));
      }
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("transactioncurrency_quarterlyfiscalcalendar")]
    public TransactionCurrency transactioncurrency_quarterlyfiscalcalendar
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (transactioncurrency_quarterlyfiscalcalendar), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (transactioncurrency_quarterlyfiscalcalendar));
        this.SetRelatedEntity<TransactionCurrency>(nameof (transactioncurrency_quarterlyfiscalcalendar), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (transactioncurrency_quarterlyfiscalcalendar));
      }
    }

    public QuarterlyFiscalCalendar(object anonymousType)
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
