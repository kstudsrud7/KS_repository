// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.Dependency
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("dependency")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class Dependency : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "dependency";
    public const string EntitySchemaName = "Dependency";
    public const string PrimaryIdAttribute = "dependencyid";

    public Dependency()
      : base("dependency")
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

    [AttributeLogicalName("dependencyid")]
    public Guid? DependencyId => this.GetAttributeValue<Guid?>("dependencyid");

    [AttributeLogicalName("dependencyid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => base.Id = value;
    }

    [AttributeLogicalName("dependencytype")]
    public OptionSetValue DependencyType
    {
      get => this.GetAttributeValue<OptionSetValue>("dependencytype");
    }

    [AttributeLogicalName("dependentcomponentbasesolutionid")]
    public Guid? DependentComponentBaseSolutionId
    {
      get => this.GetAttributeValue<Guid?>("dependentcomponentbasesolutionid");
    }

    [AttributeLogicalName("dependentcomponentnodeid")]
    public EntityReference DependentComponentNodeId
    {
      get => this.GetAttributeValue<EntityReference>("dependentcomponentnodeid");
    }

    [AttributeLogicalName("dependentcomponentobjectid")]
    public Guid? DependentComponentObjectId
    {
      get => this.GetAttributeValue<Guid?>("dependentcomponentobjectid");
    }

    [AttributeLogicalName("dependentcomponentparentid")]
    public Guid? DependentComponentParentId
    {
      get => this.GetAttributeValue<Guid?>("dependentcomponentparentid");
    }

    [AttributeLogicalName("dependentcomponenttype")]
    public OptionSetValue DependentComponentType
    {
      get => this.GetAttributeValue<OptionSetValue>("dependentcomponenttype");
    }

    [AttributeLogicalName("requiredcomponentbasesolutionid")]
    public Guid? RequiredComponentBaseSolutionId
    {
      get => this.GetAttributeValue<Guid?>("requiredcomponentbasesolutionid");
    }

    [AttributeLogicalName("requiredcomponentintroducedversion")]
    public double? RequiredComponentIntroducedVersion
    {
      get => this.GetAttributeValue<double?>("requiredcomponentintroducedversion");
    }

    [AttributeLogicalName("requiredcomponentnodeid")]
    public EntityReference RequiredComponentNodeId
    {
      get => this.GetAttributeValue<EntityReference>("requiredcomponentnodeid");
    }

    [AttributeLogicalName("requiredcomponentobjectid")]
    public Guid? RequiredComponentObjectId
    {
      get => this.GetAttributeValue<Guid?>("requiredcomponentobjectid");
    }

    [AttributeLogicalName("requiredcomponentparentid")]
    public Guid? RequiredComponentParentId
    {
      get => this.GetAttributeValue<Guid?>("requiredcomponentparentid");
    }

    [AttributeLogicalName("requiredcomponenttype")]
    public OptionSetValue RequiredComponentType
    {
      get => this.GetAttributeValue<OptionSetValue>("requiredcomponenttype");
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("userentityinstancedata_dependency")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_dependency
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_dependency), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_dependency));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_dependency), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_dependency));
      }
    }

    public Dependency(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["dependencyid"] = (object) base.Id;
            break;
          case "dependencyid":
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
