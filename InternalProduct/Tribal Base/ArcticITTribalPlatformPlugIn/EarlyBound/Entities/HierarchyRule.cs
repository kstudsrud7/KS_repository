// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.HierarchyRule
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("hierarchyrule")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class HierarchyRule : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "hierarchyrule";
    public const string EntitySchemaName = "HierarchyRule";
    public const string PrimaryIdAttribute = "hierarchyruleid";
    public const string PrimaryNameAttribute = "name";

    public HierarchyRule()
      : base("hierarchyrule")
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

    [AttributeLogicalName("componentstate")]
    public OptionSetValue ComponentState
    {
      get => this.GetAttributeValue<OptionSetValue>("componentstate");
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

    [AttributeLogicalName("hierarchyruleid")]
    public Guid? HierarchyRuleID
    {
      get => this.GetAttributeValue<Guid?>("hierarchyruleid");
      set
      {
        this.OnPropertyChanging(nameof (HierarchyRuleID));
        this.SetAttributeValue("hierarchyruleid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (HierarchyRuleID));
      }
    }

    [AttributeLogicalName("hierarchyruleid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.HierarchyRuleID = new Guid?(value);
    }

    [AttributeLogicalName("hierarchyruleidunique")]
    public Guid? HierarchyRuleIDUnique => this.GetAttributeValue<Guid?>("hierarchyruleidunique");

    [AttributeLogicalName("introducedversion")]
    public string IntroducedVersion
    {
      get => this.GetAttributeValue<string>("introducedversion");
      set
      {
        this.OnPropertyChanging(nameof (IntroducedVersion));
        this.SetAttributeValue("introducedversion", (object) value);
        this.OnPropertyChanged(nameof (IntroducedVersion));
      }
    }

    [AttributeLogicalName("iscustomizable")]
    public BooleanManagedProperty IsCustomizable
    {
      get => this.GetAttributeValue<BooleanManagedProperty>("iscustomizable");
      set
      {
        this.OnPropertyChanging(nameof (IsCustomizable));
        this.SetAttributeValue("iscustomizable", (object) value);
        this.OnPropertyChanged(nameof (IsCustomizable));
      }
    }

    [AttributeLogicalName("ismanaged")]
    public bool? IsManaged => this.GetAttributeValue<bool?>("ismanaged");

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

    [AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime => this.GetAttributeValue<DateTime?>("overwritetime");

    [AttributeLogicalName("primaryentityformid")]
    public Guid? PrimaryEntityFormID
    {
      get => this.GetAttributeValue<Guid?>("primaryentityformid");
      set
      {
        this.OnPropertyChanging(nameof (PrimaryEntityFormID));
        this.SetAttributeValue("primaryentityformid", (object) value);
        this.OnPropertyChanged(nameof (PrimaryEntityFormID));
      }
    }

    [AttributeLogicalName("primaryentitylogicalname")]
    public string PrimaryEntityLogicalName
    {
      get => this.GetAttributeValue<string>("primaryentitylogicalname");
      set
      {
        this.OnPropertyChanging(nameof (PrimaryEntityLogicalName));
        this.SetAttributeValue("primaryentitylogicalname", (object) value);
        this.OnPropertyChanged(nameof (PrimaryEntityLogicalName));
      }
    }

    [AttributeLogicalName("publishedon")]
    public DateTime? PublishedOn => this.GetAttributeValue<DateTime?>("publishedon");

    [AttributeLogicalName("relatedentityformid")]
    public Guid? RelatedEntityFormId => this.GetAttributeValue<Guid?>("relatedentityformid");

    [AttributeLogicalName("relatedentitylogicalname")]
    public string RelatedEntityLogicalName
    {
      get => this.GetAttributeValue<string>("relatedentitylogicalname");
    }

    [AttributeLogicalName("showdisabled")]
    public bool? ShowDisabled
    {
      get => this.GetAttributeValue<bool?>("showdisabled");
      set
      {
        this.OnPropertyChanging(nameof (ShowDisabled));
        this.SetAttributeValue("showdisabled", (object) value);
        this.OnPropertyChanged(nameof (ShowDisabled));
      }
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("sortby")]
    public Guid? SortBy => this.GetAttributeValue<Guid?>("sortby");

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_hierarchyrules")]
    public Organization organization_hierarchyrules
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_hierarchyrules), new EntityRole?());
      }
    }

    public HierarchyRule(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["hierarchyruleid"] = (object) base.Id;
            break;
          case "hierarchyruleid":
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
