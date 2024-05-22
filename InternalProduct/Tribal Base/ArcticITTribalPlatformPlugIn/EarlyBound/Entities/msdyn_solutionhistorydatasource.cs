// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.msdyn_solutionhistorydatasource
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("msdyn_solutionhistorydatasource")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class msdyn_solutionhistorydatasource : 
    Entity,
    INotifyPropertyChanging,
    INotifyPropertyChanged
  {
    public const string EntityLogicalName = "msdyn_solutionhistorydatasource";
    public const string EntitySchemaName = "msdyn_solutionhistorydatasource";
    public const string PrimaryIdAttribute = "msdyn_solutionhistorydatasourceid";
    public const string PrimaryNameAttribute = "msdyn_name";

    public msdyn_solutionhistorydatasource()
      : base(nameof (msdyn_solutionhistorydatasource))
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

    [AttributeLogicalName("msdyn_name")]
    public string msdyn_name
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_name));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_name));
        this.SetAttributeValue(nameof (msdyn_name), (object) value);
        this.OnPropertyChanged(nameof (msdyn_name));
      }
    }

    [AttributeLogicalName("msdyn_solutionhistorydatasourceid")]
    public Guid? msdyn_solutionhistorydatasourceId
    {
      get => this.GetAttributeValue<Guid?>("msdyn_solutionhistorydatasourceid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutionhistorydatasourceId));
        this.SetAttributeValue("msdyn_solutionhistorydatasourceid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (msdyn_solutionhistorydatasourceId));
      }
    }

    [AttributeLogicalName("msdyn_solutionhistorydatasourceid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.msdyn_solutionhistorydatasourceId = new Guid?(value);
    }

    [RelationshipSchemaName("msdyn_solutionhistorydatasource_Annotations")]
    public IEnumerable<Annotation> msdyn_solutionhistorydatasource_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (msdyn_solutionhistorydatasource_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutionhistorydatasource_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (msdyn_solutionhistorydatasource_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_solutionhistorydatasource_Annotations));
      }
    }

    public msdyn_solutionhistorydatasource(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["msdyn_solutionhistorydatasourceid"] = (object) base.Id;
            break;
          case "msdyn_solutionhistorydatasourceid":
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
