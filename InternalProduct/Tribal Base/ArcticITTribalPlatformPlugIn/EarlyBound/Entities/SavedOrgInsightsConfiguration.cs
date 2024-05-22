// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.SavedOrgInsightsConfiguration
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("savedorginsightsconfiguration")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class SavedOrgInsightsConfiguration : 
    Entity,
    INotifyPropertyChanging,
    INotifyPropertyChanged
  {
    public const string EntityLogicalName = "savedorginsightsconfiguration";
    public const string EntitySchemaName = "SavedOrgInsightsConfiguration";
    public const string PrimaryIdAttribute = "savedorginsightsconfigurationid";

    public SavedOrgInsightsConfiguration()
      : base("savedorginsightsconfiguration")
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

    [AttributeLogicalName("isdefault")]
    public bool? IsDefault
    {
      get => this.GetAttributeValue<bool?>("isdefault");
      set
      {
        this.OnPropertyChanging(nameof (IsDefault));
        this.SetAttributeValue("isdefault", (object) value);
        this.OnPropertyChanged(nameof (IsDefault));
      }
    }

    [AttributeLogicalName("isdrilldown")]
    public bool? IsDrilldown
    {
      get => this.GetAttributeValue<bool?>("isdrilldown");
      set
      {
        this.OnPropertyChanging(nameof (IsDrilldown));
        this.SetAttributeValue("isdrilldown", (object) value);
        this.OnPropertyChanged(nameof (IsDrilldown));
      }
    }

    [AttributeLogicalName("jsondata")]
    public string JsonData => this.GetAttributeValue<string>("jsondata");

    [AttributeLogicalName("jsondataendtime")]
    public DateTime? JsonDataEndTime => this.GetAttributeValue<DateTime?>("jsondataendtime");

    [AttributeLogicalName("jsondatastarttime")]
    public DateTime? JsonDataStartTime => this.GetAttributeValue<DateTime?>("jsondatastarttime");

    [AttributeLogicalName("lookback")]
    public OptionSetValue Lookback
    {
      get => this.GetAttributeValue<OptionSetValue>("lookback");
      set
      {
        this.OnPropertyChanging(nameof (Lookback));
        this.SetAttributeValue("lookback", (object) value);
        this.OnPropertyChanged(nameof (Lookback));
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

    [AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get => this.GetAttributeValue<EntityReference>("organizationid");
    }

    [AttributeLogicalName("parameters")]
    public string Parameters
    {
      get => this.GetAttributeValue<string>("parameters");
      set
      {
        this.OnPropertyChanging(nameof (Parameters));
        this.SetAttributeValue("parameters", (object) value);
        this.OnPropertyChanged(nameof (Parameters));
      }
    }

    [AttributeLogicalName("plotoption")]
    public OptionSetValue PlotOption
    {
      get => this.GetAttributeValue<OptionSetValue>("plotoption");
      set
      {
        this.OnPropertyChanging(nameof (PlotOption));
        this.SetAttributeValue("plotoption", (object) value);
        this.OnPropertyChanged(nameof (PlotOption));
      }
    }

    [AttributeLogicalName("savedorginsightsconfigurationid")]
    public Guid? SavedOrgInsightsConfigurationId
    {
      get => this.GetAttributeValue<Guid?>("savedorginsightsconfigurationid");
      set
      {
        this.OnPropertyChanging(nameof (SavedOrgInsightsConfigurationId));
        this.SetAttributeValue("savedorginsightsconfigurationid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (SavedOrgInsightsConfigurationId));
      }
    }

    [AttributeLogicalName("savedorginsightsconfigurationid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.SavedOrgInsightsConfigurationId = new Guid?(value);
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_savedorginsightsconfiguration_createdby")]
    public SystemUser lk_savedorginsightsconfiguration_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_savedorginsightsconfiguration_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_savedorginsightsconfiguration_createdonbehalfby")]
    public SystemUser lk_savedorginsightsconfiguration_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_savedorginsightsconfiguration_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_savedorginsightsconfiguration_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_savedorginsightsconfiguration_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_savedorginsightsconfiguration_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_savedorginsightsconfiguration_modifiedby")]
    public SystemUser lk_savedorginsightsconfiguration_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_savedorginsightsconfiguration_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_savedorginsightsconfiguration_modifiedonbehalfby")]
    public SystemUser lk_savedorginsightsconfiguration_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_savedorginsightsconfiguration_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_savedorginsightsconfiguration_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_savedorginsightsconfiguration_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_savedorginsightsconfiguration_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_savedorginsightsconfiguration")]
    public Organization organization_savedorginsightsconfiguration
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_savedorginsightsconfiguration), new EntityRole?());
      }
    }

    public SavedOrgInsightsConfiguration(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["savedorginsightsconfigurationid"] = (object) base.Id;
            break;
          case "savedorginsightsconfigurationid":
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
