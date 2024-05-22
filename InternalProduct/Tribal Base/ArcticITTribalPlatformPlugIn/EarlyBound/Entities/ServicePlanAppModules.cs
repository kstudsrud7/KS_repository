// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ServicePlanAppModules
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("serviceplanappmodules")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ServicePlanAppModules : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "serviceplanappmodules";
    public const string EntitySchemaName = "ServicePlanAppModules";
    public const string PrimaryIdAttribute = "serviceplanappmodulesid";

    public ServicePlanAppModules()
      : base("serviceplanappmodules")
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

    [AttributeLogicalName("appmoduleid")]
    public Guid? AppModuleId => this.GetAttributeValue<Guid?>("appmoduleid");

    [AttributeLogicalName("componentidunique")]
    public Guid? ComponentIdUnique => this.GetAttributeValue<Guid?>("componentidunique");

    [AttributeLogicalName("componentstate")]
    public OptionSetValue ComponentState
    {
      get => this.GetAttributeValue<OptionSetValue>("componentstate");
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

    [AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime => this.GetAttributeValue<DateTime?>("overwritetime");

    [AttributeLogicalName("serviceplanappmodulesid")]
    public Guid? ServicePlanAppModulesId
    {
      get => this.GetAttributeValue<Guid?>("serviceplanappmodulesid");
    }

    [AttributeLogicalName("serviceplanappmodulesid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => base.Id = value;
    }

    [AttributeLogicalName("serviceplanid")]
    public Guid? ServicePlanId => this.GetAttributeValue<Guid?>("serviceplanid");

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("serviceplan_appmodule")]
    public IEnumerable<ServicePlan> serviceplan_appmodule
    {
      get
      {
        return this.GetRelatedEntities<ServicePlan>(nameof (serviceplan_appmodule), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (serviceplan_appmodule));
        this.SetRelatedEntities<ServicePlan>(nameof (serviceplan_appmodule), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (serviceplan_appmodule));
      }
    }

    public ServicePlanAppModules(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["serviceplanappmodulesid"] = (object) base.Id;
            break;
          case "serviceplanappmodulesid":
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
