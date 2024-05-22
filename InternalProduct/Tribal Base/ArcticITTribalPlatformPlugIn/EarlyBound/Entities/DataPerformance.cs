// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.DataPerformance
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("dataperformance")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class DataPerformance : Microsoft.Xrm.Sdk.Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "dataperformance";
    public const string EntitySchemaName = "DataPerformance";
    public const string PrimaryIdAttribute = "dataperformanceid";

    public DataPerformance()
      : base("dataperformance")
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

    [AttributeLogicalName("anyoptimizationapplied")]
    public bool? AnyOptimizationApplied => this.GetAttributeValue<bool?>("anyoptimizationapplied");

    [AttributeLogicalName("anyoptimizationavailable")]
    public bool? AnyOptimizationAvailable
    {
      get => this.GetAttributeValue<bool?>("anyoptimizationavailable");
    }

    [AttributeLogicalName("component")]
    public string Component => this.GetAttributeValue<string>("component");

    [AttributeLogicalName("count")]
    public int? Count => this.GetAttributeValue<int?>("count");

    [AttributeLogicalName("dataperformanceid")]
    public Guid? DataPerformanceId
    {
      get => this.GetAttributeValue<Guid?>("dataperformanceid");
      set
      {
        this.OnPropertyChanging(nameof (DataPerformanceId));
        this.SetAttributeValue("dataperformanceid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (DataPerformanceId));
      }
    }

    [AttributeLogicalName("dataperformanceid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.DataPerformanceId = new Guid?(value);
    }

    [AttributeLogicalName("entity")]
    public string Entity => this.GetAttributeValue<string>("entity");

    [AttributeLogicalName("estimatedoptimizationimpact")]
    public Decimal? EstimatedOptimizationImpact
    {
      get => this.GetAttributeValue<Decimal?>("estimatedoptimizationimpact");
    }

    [AttributeLogicalName("executionperiod")]
    public string ExecutionPeriod => this.GetAttributeValue<string>("executionperiod");

    [AttributeLogicalName("lastactionresult")]
    public string LastActionResult => this.GetAttributeValue<string>("lastactionresult");

    [AttributeLogicalName("lastoptimizationdate")]
    public DateTime? LastOptimizationDate
    {
      get => this.GetAttributeValue<DateTime?>("lastoptimizationdate");
    }

    [AttributeLogicalName("maxtime")]
    public Decimal? MaxTime => this.GetAttributeValue<Decimal?>("maxtime");

    [AttributeLogicalName("mediantime")]
    public Decimal? MedianTime => this.GetAttributeValue<Decimal?>("mediantime");

    [AttributeLogicalName("mintime")]
    public Decimal? MinTime => this.GetAttributeValue<Decimal?>("mintime");

    [AttributeLogicalName("operation")]
    public string Operation => this.GetAttributeValue<string>("operation");

    [AttributeLogicalName("optimizationstatus")]
    public string OptimizationStatus => this.GetAttributeValue<string>("optimizationstatus");

    [AttributeLogicalName("optimizationstorage")]
    public Decimal? OptimizationStorage => this.GetAttributeValue<Decimal?>("optimizationstorage");

    [AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get => this.GetAttributeValue<EntityReference>("organizationid");
    }

    [AttributeLogicalName("realizedoptimizationimpact")]
    public string RealizedOptimizationImpact
    {
      get => this.GetAttributeValue<string>("realizedoptimizationimpact");
    }

    [AttributeLogicalName("solution")]
    public string Solution => this.GetAttributeValue<string>("solution");

    [AttributeLogicalName("weight")]
    public Decimal? Weight => this.GetAttributeValue<Decimal?>("weight");

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("lk_dataperformance_organizationid")]
    public Organization lk_dataperformance_organizationid
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (lk_dataperformance_organizationid), new EntityRole?());
      }
    }

    public DataPerformance(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["dataperformanceid"] = (object) base.Id;
            break;
          case "dataperformanceid":
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
