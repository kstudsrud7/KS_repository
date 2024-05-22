// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.SemiAnnualFiscalCalendar
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("semiannualfiscalcalendar")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class SemiAnnualFiscalCalendar : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "semiannualfiscalcalendar";
    public const string EntitySchemaName = "SemiAnnualFiscalCalendar";
    public const string PrimaryIdAttribute = "userfiscalcalendarid";

    public SemiAnnualFiscalCalendar()
      : base("semiannualfiscalcalendar")
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

    [AttributeLogicalName("firsthalf")]
    public Money FirstHalf
    {
      get => this.GetAttributeValue<Money>("firsthalf");
      set
      {
        this.OnPropertyChanging(nameof (FirstHalf));
        this.SetAttributeValue("firsthalf", (object) value);
        this.OnPropertyChanged(nameof (FirstHalf));
      }
    }

    [AttributeLogicalName("firsthalf_base")]
    public Money FirstHalf_Base => this.GetAttributeValue<Money>("firsthalf_base");

    [AttributeLogicalName("fiscalperiodtype")]
    public int? FiscalPeriodType => this.GetAttributeValue<int?>("fiscalperiodtype");

    [AttributeLogicalName("importsequencenumber")]
    public int? ImportSequenceNumber
    {
      get => this.GetAttributeValue<int?>("importsequencenumber");
      set
      {
        this.OnPropertyChanging(nameof (ImportSequenceNumber));
        this.SetAttributeValue("importsequencenumber", (object) value);
        this.OnPropertyChanged(nameof (ImportSequenceNumber));
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

    [AttributeLogicalName("secondhalf")]
    public Money SecondHalf
    {
      get => this.GetAttributeValue<Money>("secondhalf");
      set
      {
        this.OnPropertyChanging(nameof (SecondHalf));
        this.SetAttributeValue("secondhalf", (object) value);
        this.OnPropertyChanged(nameof (SecondHalf));
      }
    }

    [AttributeLogicalName("secondhalf_base")]
    public Money SecondHalf_Base => this.GetAttributeValue<Money>("secondhalf_base");

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

    [RelationshipSchemaName("SemiAnnualFiscalCalendar_AsyncOperations")]
    public IEnumerable<AsyncOperation> SemiAnnualFiscalCalendar_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (SemiAnnualFiscalCalendar_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SemiAnnualFiscalCalendar_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (SemiAnnualFiscalCalendar_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SemiAnnualFiscalCalendar_AsyncOperations));
      }
    }

    [RelationshipSchemaName("SemiAnnualFiscalCalendar_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> SemiAnnualFiscalCalendar_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (SemiAnnualFiscalCalendar_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SemiAnnualFiscalCalendar_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (SemiAnnualFiscalCalendar_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SemiAnnualFiscalCalendar_BulkDeleteFailures));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_semiannualfiscalcalendar_createdby")]
    public SystemUser lk_semiannualfiscalcalendar_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_semiannualfiscalcalendar_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_semiannualfiscalcalendar_createdonbehalfby")]
    public SystemUser lk_semiannualfiscalcalendar_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_semiannualfiscalcalendar_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_semiannualfiscalcalendar_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_semiannualfiscalcalendar_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_semiannualfiscalcalendar_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_semiannualfiscalcalendar_modifiedby")]
    public SystemUser lk_semiannualfiscalcalendar_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_semiannualfiscalcalendar_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_semiannualfiscalcalendar_modifiedonbehalfby")]
    public SystemUser lk_semiannualfiscalcalendar_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_semiannualfiscalcalendar_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_semiannualfiscalcalendar_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_semiannualfiscalcalendar_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_semiannualfiscalcalendar_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("salespersonid")]
    [RelationshipSchemaName("lk_semiannualfiscalcalendar_salespersonid")]
    public SystemUser lk_semiannualfiscalcalendar_salespersonid
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_semiannualfiscalcalendar_salespersonid), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_semiannualfiscalcalendar_salespersonid));
        this.SetRelatedEntity<SystemUser>(nameof (lk_semiannualfiscalcalendar_salespersonid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_semiannualfiscalcalendar_salespersonid));
      }
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("transactioncurrency_semiannualfiscalcalendar")]
    public TransactionCurrency transactioncurrency_semiannualfiscalcalendar
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (transactioncurrency_semiannualfiscalcalendar), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (transactioncurrency_semiannualfiscalcalendar));
        this.SetRelatedEntity<TransactionCurrency>(nameof (transactioncurrency_semiannualfiscalcalendar), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (transactioncurrency_semiannualfiscalcalendar));
      }
    }

    public SemiAnnualFiscalCalendar(object anonymousType)
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
