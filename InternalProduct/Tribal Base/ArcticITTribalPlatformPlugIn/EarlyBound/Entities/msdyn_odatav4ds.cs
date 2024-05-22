// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.msdyn_odatav4ds
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("msdyn_odatav4ds")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class msdyn_odatav4ds : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "msdyn_odatav4ds";
    public const string EntitySchemaName = "msdyn_odatav4ds";
    public const string PrimaryIdAttribute = "msdyn_odatav4dsid";
    public const string PrimaryNameAttribute = "msdyn_name";

    public msdyn_odatav4ds()
      : base(nameof (msdyn_odatav4ds))
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

    [AttributeLogicalName("msdyn_description")]
    public string msdyn_description
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_description));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_description));
        this.SetAttributeValue(nameof (msdyn_description), (object) value);
        this.OnPropertyChanged(nameof (msdyn_description));
      }
    }

    [AttributeLogicalName("msdyn_isparameter10header")]
    public bool? msdyn_isparameter10header
    {
      get => this.GetAttributeValue<bool?>(nameof (msdyn_isparameter10header));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_isparameter10header));
        this.SetAttributeValue(nameof (msdyn_isparameter10header), (object) value);
        this.OnPropertyChanged(nameof (msdyn_isparameter10header));
      }
    }

    [AttributeLogicalName("msdyn_isparameter1header")]
    public bool? msdyn_isparameter1header
    {
      get => this.GetAttributeValue<bool?>(nameof (msdyn_isparameter1header));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_isparameter1header));
        this.SetAttributeValue(nameof (msdyn_isparameter1header), (object) value);
        this.OnPropertyChanged(nameof (msdyn_isparameter1header));
      }
    }

    [AttributeLogicalName("msdyn_isparameter2header")]
    public bool? msdyn_isparameter2header
    {
      get => this.GetAttributeValue<bool?>(nameof (msdyn_isparameter2header));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_isparameter2header));
        this.SetAttributeValue(nameof (msdyn_isparameter2header), (object) value);
        this.OnPropertyChanged(nameof (msdyn_isparameter2header));
      }
    }

    [AttributeLogicalName("msdyn_isparameter3header")]
    public bool? msdyn_isparameter3header
    {
      get => this.GetAttributeValue<bool?>(nameof (msdyn_isparameter3header));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_isparameter3header));
        this.SetAttributeValue(nameof (msdyn_isparameter3header), (object) value);
        this.OnPropertyChanged(nameof (msdyn_isparameter3header));
      }
    }

    [AttributeLogicalName("msdyn_isparameter4header")]
    public bool? msdyn_isparameter4header
    {
      get => this.GetAttributeValue<bool?>(nameof (msdyn_isparameter4header));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_isparameter4header));
        this.SetAttributeValue(nameof (msdyn_isparameter4header), (object) value);
        this.OnPropertyChanged(nameof (msdyn_isparameter4header));
      }
    }

    [AttributeLogicalName("msdyn_isparameter5header")]
    public bool? msdyn_isparameter5header
    {
      get => this.GetAttributeValue<bool?>(nameof (msdyn_isparameter5header));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_isparameter5header));
        this.SetAttributeValue(nameof (msdyn_isparameter5header), (object) value);
        this.OnPropertyChanged(nameof (msdyn_isparameter5header));
      }
    }

    [AttributeLogicalName("msdyn_isparameter6header")]
    public bool? msdyn_isparameter6header
    {
      get => this.GetAttributeValue<bool?>(nameof (msdyn_isparameter6header));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_isparameter6header));
        this.SetAttributeValue(nameof (msdyn_isparameter6header), (object) value);
        this.OnPropertyChanged(nameof (msdyn_isparameter6header));
      }
    }

    [AttributeLogicalName("msdyn_isparameter7header")]
    public bool? msdyn_isparameter7header
    {
      get => this.GetAttributeValue<bool?>(nameof (msdyn_isparameter7header));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_isparameter7header));
        this.SetAttributeValue(nameof (msdyn_isparameter7header), (object) value);
        this.OnPropertyChanged(nameof (msdyn_isparameter7header));
      }
    }

    [AttributeLogicalName("msdyn_isparameter8header")]
    public bool? msdyn_isparameter8header
    {
      get => this.GetAttributeValue<bool?>(nameof (msdyn_isparameter8header));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_isparameter8header));
        this.SetAttributeValue(nameof (msdyn_isparameter8header), (object) value);
        this.OnPropertyChanged(nameof (msdyn_isparameter8header));
      }
    }

    [AttributeLogicalName("msdyn_isparameter9header")]
    public bool? msdyn_isparameter9header
    {
      get => this.GetAttributeValue<bool?>(nameof (msdyn_isparameter9header));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_isparameter9header));
        this.SetAttributeValue(nameof (msdyn_isparameter9header), (object) value);
        this.OnPropertyChanged(nameof (msdyn_isparameter9header));
      }
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

    [AttributeLogicalName("msdyn_odatav4dsid")]
    public Guid? msdyn_odatav4dsId
    {
      get => this.GetAttributeValue<Guid?>("msdyn_odatav4dsid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_odatav4dsId));
        this.SetAttributeValue("msdyn_odatav4dsid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (msdyn_odatav4dsId));
      }
    }

    [AttributeLogicalName("msdyn_odatav4dsid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.msdyn_odatav4dsId = new Guid?(value);
    }

    [AttributeLogicalName("msdyn_paginationmode")]
    public bool? msdyn_paginationmode
    {
      get => this.GetAttributeValue<bool?>(nameof (msdyn_paginationmode));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_paginationmode));
        this.SetAttributeValue(nameof (msdyn_paginationmode), (object) value);
        this.OnPropertyChanged(nameof (msdyn_paginationmode));
      }
    }

    [AttributeLogicalName("msdyn_paginationtype")]
    public OptionSetValue msdyn_paginationtype
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (msdyn_paginationtype));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_paginationtype));
        this.SetAttributeValue(nameof (msdyn_paginationtype), (object) value);
        this.OnPropertyChanged(nameof (msdyn_paginationtype));
      }
    }

    [AttributeLogicalName("msdyn_parameter10name")]
    public string msdyn_parameter10name
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_parameter10name));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_parameter10name));
        this.SetAttributeValue(nameof (msdyn_parameter10name), (object) value);
        this.OnPropertyChanged(nameof (msdyn_parameter10name));
      }
    }

    [AttributeLogicalName("msdyn_parameter10value")]
    public string msdyn_parameter10value
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_parameter10value));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_parameter10value));
        this.SetAttributeValue(nameof (msdyn_parameter10value), (object) value);
        this.OnPropertyChanged(nameof (msdyn_parameter10value));
      }
    }

    [AttributeLogicalName("msdyn_parameter1name")]
    public string msdyn_parameter1name
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_parameter1name));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_parameter1name));
        this.SetAttributeValue(nameof (msdyn_parameter1name), (object) value);
        this.OnPropertyChanged(nameof (msdyn_parameter1name));
      }
    }

    [AttributeLogicalName("msdyn_parameter1value")]
    public string msdyn_parameter1value
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_parameter1value));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_parameter1value));
        this.SetAttributeValue(nameof (msdyn_parameter1value), (object) value);
        this.OnPropertyChanged(nameof (msdyn_parameter1value));
      }
    }

    [AttributeLogicalName("msdyn_parameter2name")]
    public string msdyn_parameter2name
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_parameter2name));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_parameter2name));
        this.SetAttributeValue(nameof (msdyn_parameter2name), (object) value);
        this.OnPropertyChanged(nameof (msdyn_parameter2name));
      }
    }

    [AttributeLogicalName("msdyn_parameter2value")]
    public string msdyn_parameter2value
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_parameter2value));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_parameter2value));
        this.SetAttributeValue(nameof (msdyn_parameter2value), (object) value);
        this.OnPropertyChanged(nameof (msdyn_parameter2value));
      }
    }

    [AttributeLogicalName("msdyn_parameter3name")]
    public string msdyn_parameter3name
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_parameter3name));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_parameter3name));
        this.SetAttributeValue(nameof (msdyn_parameter3name), (object) value);
        this.OnPropertyChanged(nameof (msdyn_parameter3name));
      }
    }

    [AttributeLogicalName("msdyn_parameter3value")]
    public string msdyn_parameter3value
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_parameter3value));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_parameter3value));
        this.SetAttributeValue(nameof (msdyn_parameter3value), (object) value);
        this.OnPropertyChanged(nameof (msdyn_parameter3value));
      }
    }

    [AttributeLogicalName("msdyn_parameter4name")]
    public string msdyn_parameter4name
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_parameter4name));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_parameter4name));
        this.SetAttributeValue(nameof (msdyn_parameter4name), (object) value);
        this.OnPropertyChanged(nameof (msdyn_parameter4name));
      }
    }

    [AttributeLogicalName("msdyn_parameter4value")]
    public string msdyn_parameter4value
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_parameter4value));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_parameter4value));
        this.SetAttributeValue(nameof (msdyn_parameter4value), (object) value);
        this.OnPropertyChanged(nameof (msdyn_parameter4value));
      }
    }

    [AttributeLogicalName("msdyn_parameter5name")]
    public string msdyn_parameter5name
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_parameter5name));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_parameter5name));
        this.SetAttributeValue(nameof (msdyn_parameter5name), (object) value);
        this.OnPropertyChanged(nameof (msdyn_parameter5name));
      }
    }

    [AttributeLogicalName("msdyn_parameter5value")]
    public string msdyn_parameter5value
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_parameter5value));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_parameter5value));
        this.SetAttributeValue(nameof (msdyn_parameter5value), (object) value);
        this.OnPropertyChanged(nameof (msdyn_parameter5value));
      }
    }

    [AttributeLogicalName("msdyn_parameter6name")]
    public string msdyn_parameter6name
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_parameter6name));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_parameter6name));
        this.SetAttributeValue(nameof (msdyn_parameter6name), (object) value);
        this.OnPropertyChanged(nameof (msdyn_parameter6name));
      }
    }

    [AttributeLogicalName("msdyn_parameter6value")]
    public string msdyn_parameter6value
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_parameter6value));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_parameter6value));
        this.SetAttributeValue(nameof (msdyn_parameter6value), (object) value);
        this.OnPropertyChanged(nameof (msdyn_parameter6value));
      }
    }

    [AttributeLogicalName("msdyn_parameter7name")]
    public string msdyn_parameter7name
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_parameter7name));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_parameter7name));
        this.SetAttributeValue(nameof (msdyn_parameter7name), (object) value);
        this.OnPropertyChanged(nameof (msdyn_parameter7name));
      }
    }

    [AttributeLogicalName("msdyn_parameter7value")]
    public string msdyn_parameter7value
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_parameter7value));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_parameter7value));
        this.SetAttributeValue(nameof (msdyn_parameter7value), (object) value);
        this.OnPropertyChanged(nameof (msdyn_parameter7value));
      }
    }

    [AttributeLogicalName("msdyn_parameter8name")]
    public string msdyn_parameter8name
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_parameter8name));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_parameter8name));
        this.SetAttributeValue(nameof (msdyn_parameter8name), (object) value);
        this.OnPropertyChanged(nameof (msdyn_parameter8name));
      }
    }

    [AttributeLogicalName("msdyn_parameter8value")]
    public string msdyn_parameter8value
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_parameter8value));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_parameter8value));
        this.SetAttributeValue(nameof (msdyn_parameter8value), (object) value);
        this.OnPropertyChanged(nameof (msdyn_parameter8value));
      }
    }

    [AttributeLogicalName("msdyn_parameter9name")]
    public string msdyn_parameter9name
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_parameter9name));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_parameter9name));
        this.SetAttributeValue(nameof (msdyn_parameter9name), (object) value);
        this.OnPropertyChanged(nameof (msdyn_parameter9name));
      }
    }

    [AttributeLogicalName("msdyn_parameter9value")]
    public string msdyn_parameter9value
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_parameter9value));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_parameter9value));
        this.SetAttributeValue(nameof (msdyn_parameter9value), (object) value);
        this.OnPropertyChanged(nameof (msdyn_parameter9value));
      }
    }

    [AttributeLogicalName("msdyn_returninlinecount")]
    public bool? msdyn_returninlinecount
    {
      get => this.GetAttributeValue<bool?>(nameof (msdyn_returninlinecount));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_returninlinecount));
        this.SetAttributeValue(nameof (msdyn_returninlinecount), (object) value);
        this.OnPropertyChanged(nameof (msdyn_returninlinecount));
      }
    }

    [AttributeLogicalName("msdyn_timeout")]
    public int? msdyn_timeout
    {
      get => this.GetAttributeValue<int?>(nameof (msdyn_timeout));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_timeout));
        this.SetAttributeValue(nameof (msdyn_timeout), (object) value);
        this.OnPropertyChanged(nameof (msdyn_timeout));
      }
    }

    [AttributeLogicalName("msdyn_uri")]
    public string msdyn_uri
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_uri));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_uri));
        this.SetAttributeValue(nameof (msdyn_uri), (object) value);
        this.OnPropertyChanged(nameof (msdyn_uri));
      }
    }

    public msdyn_odatav4ds(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["msdyn_odatav4dsid"] = (object) base.Id;
            break;
          case "msdyn_odatav4dsid":
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
