// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.OrgInsightsMetric
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("orginsightsmetric")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class OrgInsightsMetric : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "orginsightsmetric";
    public const string EntitySchemaName = "OrgInsightsMetric";
    public const string PrimaryIdAttribute = "orginsightsmetricid";

    public OrgInsightsMetric()
      : base("orginsightsmetric")
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

    [AttributeLogicalName("internalname")]
    public string InternalName
    {
      get => this.GetAttributeValue<string>("internalname");
      set
      {
        this.OnPropertyChanging(nameof (InternalName));
        this.SetAttributeValue("internalname", (object) value);
        this.OnPropertyChanged(nameof (InternalName));
      }
    }

    [AttributeLogicalName("metrictype")]
    public OptionSetValue MetricType
    {
      get => this.GetAttributeValue<OptionSetValue>("metrictype");
      set
      {
        this.OnPropertyChanging(nameof (MetricType));
        this.SetAttributeValue("metrictype", (object) value);
        this.OnPropertyChanged(nameof (MetricType));
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

    [AttributeLogicalName("orginsightsmetricid")]
    public Guid? OrgInsightsMetricId
    {
      get => this.GetAttributeValue<Guid?>("orginsightsmetricid");
      set
      {
        this.OnPropertyChanging(nameof (OrgInsightsMetricId));
        this.SetAttributeValue("orginsightsmetricid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (OrgInsightsMetricId));
      }
    }

    [AttributeLogicalName("orginsightsmetricid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.OrgInsightsMetricId = new Guid?(value);
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_orginsightsmetric")]
    public Organization organization_orginsightsmetric
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_orginsightsmetric), new EntityRole?());
      }
    }

    public OrgInsightsMetric(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["orginsightsmetricid"] = (object) base.Id;
            break;
          case "orginsightsmetricid":
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
