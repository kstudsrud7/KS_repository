// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.RibbonCustomization
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ribboncustomization")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class RibbonCustomization : Microsoft.Xrm.Sdk.Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ribboncustomization";
    public const string EntitySchemaName = "RibbonCustomization";
    public const string PrimaryIdAttribute = "ribboncustomizationid";

    public RibbonCustomization()
      : base("ribboncustomization")
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

    [AttributeLogicalName("entity")]
    public string Entity
    {
      get => this.GetAttributeValue<string>("entity");
      set
      {
        this.OnPropertyChanging(nameof (Entity));
        this.SetAttributeValue("entity", (object) value);
        this.OnPropertyChanged(nameof (Entity));
      }
    }

    [AttributeLogicalName("ismanaged")]
    public bool? IsManaged => this.GetAttributeValue<bool?>("ismanaged");

    [AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get => this.GetAttributeValue<EntityReference>("organizationid");
    }

    [AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime => this.GetAttributeValue<DateTime?>("overwritetime");

    [AttributeLogicalName("publishedon")]
    public DateTime? PublishedOn => this.GetAttributeValue<DateTime?>("publishedon");

    [AttributeLogicalName("ribboncustomizationid")]
    public Guid? RibbonCustomizationId
    {
      get => this.GetAttributeValue<Guid?>("ribboncustomizationid");
      set
      {
        this.OnPropertyChanging(nameof (RibbonCustomizationId));
        this.SetAttributeValue("ribboncustomizationid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (RibbonCustomizationId));
      }
    }

    [AttributeLogicalName("ribboncustomizationid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.RibbonCustomizationId = new Guid?(value);
    }

    [AttributeLogicalName("ribboncustomizationuniqueid")]
    public Guid? RibbonCustomizationUniqueId
    {
      get => this.GetAttributeValue<Guid?>("ribboncustomizationuniqueid");
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("userentityinstancedata_ribboncustomization")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_ribboncustomization
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_ribboncustomization), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_ribboncustomization));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_ribboncustomization), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_ribboncustomization));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_ribbon_customization")]
    public Organization organization_ribbon_customization
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_ribbon_customization), new EntityRole?());
      }
    }

    public RibbonCustomization(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ribboncustomizationid"] = (object) base.Id;
            break;
          case "ribboncustomizationid":
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
