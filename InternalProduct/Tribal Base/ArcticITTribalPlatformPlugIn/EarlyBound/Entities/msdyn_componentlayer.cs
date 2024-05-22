// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.msdyn_componentlayer
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("msdyn_componentlayer")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class msdyn_componentlayer : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "msdyn_componentlayer";
    public const string EntitySchemaName = "msdyn_componentlayer";
    public const string PrimaryIdAttribute = "msdyn_componentlayerid";
    public const string PrimaryNameAttribute = "msdyn_name";

    public msdyn_componentlayer()
      : base(nameof (msdyn_componentlayer))
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

    [AttributeLogicalName("msdyn_changes")]
    public string msdyn_changes
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_changes));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_changes));
        this.SetAttributeValue(nameof (msdyn_changes), (object) value);
        this.OnPropertyChanged(nameof (msdyn_changes));
      }
    }

    [AttributeLogicalName("msdyn_children")]
    public string msdyn_children
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_children));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_children));
        this.SetAttributeValue(nameof (msdyn_children), (object) value);
        this.OnPropertyChanged(nameof (msdyn_children));
      }
    }

    [AttributeLogicalName("msdyn_componentid")]
    public string msdyn_componentid
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_componentid));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_componentid));
        this.SetAttributeValue(nameof (msdyn_componentid), (object) value);
        this.OnPropertyChanged(nameof (msdyn_componentid));
      }
    }

    [AttributeLogicalName("msdyn_componentjson")]
    public string msdyn_componentjson
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_componentjson));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_componentjson));
        this.SetAttributeValue(nameof (msdyn_componentjson), (object) value);
        this.OnPropertyChanged(nameof (msdyn_componentjson));
      }
    }

    [AttributeLogicalName("msdyn_componentlayerid")]
    public Guid? msdyn_componentlayerId
    {
      get => this.GetAttributeValue<Guid?>("msdyn_componentlayerid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_componentlayerId));
        this.SetAttributeValue("msdyn_componentlayerid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (msdyn_componentlayerId));
      }
    }

    [AttributeLogicalName("msdyn_componentlayerid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.msdyn_componentlayerId = new Guid?(value);
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

    [AttributeLogicalName("msdyn_order")]
    public int? msdyn_order
    {
      get => this.GetAttributeValue<int?>(nameof (msdyn_order));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_order));
        this.SetAttributeValue(nameof (msdyn_order), (object) value);
        this.OnPropertyChanged(nameof (msdyn_order));
      }
    }

    [AttributeLogicalName("msdyn_overwritetime")]
    public DateTime? msdyn_endtime
    {
      get => this.GetAttributeValue<DateTime?>("msdyn_overwritetime");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_endtime));
        this.SetAttributeValue("msdyn_overwritetime", (object) value);
        this.OnPropertyChanged(nameof (msdyn_endtime));
      }
    }

    [AttributeLogicalName("msdyn_publishername")]
    public string msdyn_publishername
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_publishername));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_publishername));
        this.SetAttributeValue(nameof (msdyn_publishername), (object) value);
        this.OnPropertyChanged(nameof (msdyn_publishername));
      }
    }

    [AttributeLogicalName("msdyn_solutioncomponentname")]
    public string msdyn_solutioncomponentname
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_solutioncomponentname));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutioncomponentname));
        this.SetAttributeValue(nameof (msdyn_solutioncomponentname), (object) value);
        this.OnPropertyChanged(nameof (msdyn_solutioncomponentname));
      }
    }

    [AttributeLogicalName("msdyn_solutionname")]
    public string msdyn_solutionname
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_solutionname));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutionname));
        this.SetAttributeValue(nameof (msdyn_solutionname), (object) value);
        this.OnPropertyChanged(nameof (msdyn_solutionname));
      }
    }

    public msdyn_componentlayer(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["msdyn_componentlayerid"] = (object) base.Id;
            break;
          case "msdyn_componentlayerid":
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
