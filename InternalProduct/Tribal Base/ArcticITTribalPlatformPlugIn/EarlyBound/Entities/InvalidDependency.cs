// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.InvalidDependency
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("invaliddependency")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class InvalidDependency : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "invaliddependency";
    public const string EntitySchemaName = "InvalidDependency";
    public const string PrimaryIdAttribute = "invaliddependencyid";

    public InvalidDependency()
      : base("invaliddependency")
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

    [AttributeLogicalName("existingcomponentid")]
    public Guid? ExistingComponentId => this.GetAttributeValue<Guid?>("existingcomponentid");

    [AttributeLogicalName("existingcomponenttype")]
    public OptionSetValue ExistingComponentType
    {
      get => this.GetAttributeValue<OptionSetValue>("existingcomponenttype");
    }

    [AttributeLogicalName("existingdependencytype")]
    public OptionSetValue ExistingDependencyType
    {
      get => this.GetAttributeValue<OptionSetValue>("existingdependencytype");
    }

    [AttributeLogicalName("invaliddependencyid")]
    public Guid? InvalidDependencyId => this.GetAttributeValue<Guid?>("invaliddependencyid");

    [AttributeLogicalName("invaliddependencyid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => base.Id = value;
    }

    [AttributeLogicalName("isexistingnoderequiredcomponent")]
    public bool? IsExistingNodeRequiredComponent
    {
      get => this.GetAttributeValue<bool?>("isexistingnoderequiredcomponent");
    }

    [AttributeLogicalName("missingcomponentid")]
    public Guid? MissingComponentId
    {
      get => this.GetAttributeValue<Guid?>("missingcomponentid");
      set
      {
        this.OnPropertyChanging(nameof (MissingComponentId));
        this.SetAttributeValue("missingcomponentid", (object) value);
        this.OnPropertyChanged(nameof (MissingComponentId));
      }
    }

    [AttributeLogicalName("missingcomponentinfo")]
    public string MissingComponentInfo => this.GetAttributeValue<string>("missingcomponentinfo");

    [AttributeLogicalName("missingcomponentlookuptype")]
    public int? MissingComponentLookupType
    {
      get => this.GetAttributeValue<int?>("missingcomponentlookuptype");
    }

    [AttributeLogicalName("missingcomponenttype")]
    public OptionSetValue MissingComponentType
    {
      get => this.GetAttributeValue<OptionSetValue>("missingcomponenttype");
    }

    [RelationshipSchemaName("userentityinstancedata_invaliddependency")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_invaliddependency
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_invaliddependency), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_invaliddependency));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_invaliddependency), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_invaliddependency));
      }
    }

    public InvalidDependency(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["invaliddependencyid"] = (object) base.Id;
            break;
          case "invaliddependencyid":
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
