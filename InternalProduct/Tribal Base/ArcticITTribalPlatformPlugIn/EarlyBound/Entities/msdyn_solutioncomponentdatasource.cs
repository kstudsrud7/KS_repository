// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.msdyn_solutioncomponentdatasource
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("msdyn_solutioncomponentdatasource")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class msdyn_solutioncomponentdatasource : 
    Entity,
    INotifyPropertyChanging,
    INotifyPropertyChanged
  {
    public const string EntityLogicalName = "msdyn_solutioncomponentdatasource";
    public const string EntitySchemaName = "msdyn_solutioncomponentdatasource";
    public const string PrimaryIdAttribute = "msdyn_solutioncomponentdatasourceid";
    public const string PrimaryNameAttribute = "msdyn_name";

    public msdyn_solutioncomponentdatasource()
      : base(nameof (msdyn_solutioncomponentdatasource))
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

    [AttributeLogicalName("msdyn_solutioncomponentdatasourceid")]
    public Guid? msdyn_solutioncomponentdatasourceId
    {
      get => this.GetAttributeValue<Guid?>("msdyn_solutioncomponentdatasourceid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutioncomponentdatasourceId));
        this.SetAttributeValue("msdyn_solutioncomponentdatasourceid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (msdyn_solutioncomponentdatasourceId));
      }
    }

    [AttributeLogicalName("msdyn_solutioncomponentdatasourceid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.msdyn_solutioncomponentdatasourceId = new Guid?(value);
    }

    [RelationshipSchemaName("msdyn_solutioncomponentdatasource_Annotations")]
    public IEnumerable<Annotation> msdyn_solutioncomponentdatasource_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (msdyn_solutioncomponentdatasource_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutioncomponentdatasource_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (msdyn_solutioncomponentdatasource_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_solutioncomponentdatasource_Annotations));
      }
    }

    public msdyn_solutioncomponentdatasource(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["msdyn_solutioncomponentdatasourceid"] = (object) base.Id;
            break;
          case "msdyn_solutioncomponentdatasourceid":
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
