// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.AnnualFiscalCalendar
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("annualfiscalcalendar")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class AnnualFiscalCalendar : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "annualfiscalcalendar";
    public const string EntitySchemaName = "AnnualFiscalCalendar";
    public const string PrimaryIdAttribute = "userfiscalcalendarid";

    public AnnualFiscalCalendar()
      : base("annualfiscalcalendar")
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

    [AttributeLogicalName("annual")]
    public Money Annual
    {
      get => this.GetAttributeValue<Money>("annual");
      set
      {
        this.OnPropertyChanging(nameof (Annual));
        this.SetAttributeValue("annual", (object) value);
        this.OnPropertyChanged(nameof (Annual));
      }
    }

    [AttributeLogicalName("annual_base")]
    public Money Annual_Base => this.GetAttributeValue<Money>("annual_base");

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

    [RelationshipSchemaName("AnnualFiscalCalendar_AsyncOperations")]
    public IEnumerable<AsyncOperation> AnnualFiscalCalendar_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (AnnualFiscalCalendar_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (AnnualFiscalCalendar_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (AnnualFiscalCalendar_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (AnnualFiscalCalendar_AsyncOperations));
      }
    }

    [RelationshipSchemaName("AnnualFiscalCalendar_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> AnnualFiscalCalendar_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (AnnualFiscalCalendar_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (AnnualFiscalCalendar_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (AnnualFiscalCalendar_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (AnnualFiscalCalendar_BulkDeleteFailures));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_annualfiscalcalendar_createdby")]
    public SystemUser lk_annualfiscalcalendar_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_annualfiscalcalendar_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_annualfiscalcalendar_createdonbehalfby")]
    public SystemUser lk_annualfiscalcalendar_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_annualfiscalcalendar_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_annualfiscalcalendar_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_annualfiscalcalendar_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_annualfiscalcalendar_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_annualfiscalcalendar_modifiedby")]
    public SystemUser lk_annualfiscalcalendar_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_annualfiscalcalendar_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_annualfiscalcalendar_modifiedonbehalfby")]
    public SystemUser lk_annualfiscalcalendar_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_annualfiscalcalendar_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_annualfiscalcalendar_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_annualfiscalcalendar_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_annualfiscalcalendar_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("salespersonid")]
    [RelationshipSchemaName("lk_annualfiscalcalendar_salespersonid")]
    public SystemUser lk_annualfiscalcalendar_salespersonid
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_annualfiscalcalendar_salespersonid), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_annualfiscalcalendar_salespersonid));
        this.SetRelatedEntity<SystemUser>(nameof (lk_annualfiscalcalendar_salespersonid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_annualfiscalcalendar_salespersonid));
      }
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("transactioncurrency_annualfiscalcalendar")]
    public TransactionCurrency transactioncurrency_annualfiscalcalendar
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (transactioncurrency_annualfiscalcalendar), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (transactioncurrency_annualfiscalcalendar));
        this.SetRelatedEntity<TransactionCurrency>(nameof (transactioncurrency_annualfiscalcalendar), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (transactioncurrency_annualfiscalcalendar));
      }
    }

    public AnnualFiscalCalendar(object anonymousType)
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
