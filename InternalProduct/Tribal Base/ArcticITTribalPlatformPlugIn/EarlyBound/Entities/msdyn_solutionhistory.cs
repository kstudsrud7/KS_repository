// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.msdyn_solutionhistory
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("msdyn_solutionhistory")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class msdyn_solutionhistory : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "msdyn_solutionhistory";
    public const string EntitySchemaName = "msdyn_solutionhistory";
    public const string PrimaryIdAttribute = "msdyn_solutionhistoryid";
    public const string PrimaryNameAttribute = "msdyn_name";

    public msdyn_solutionhistory()
      : base(nameof (msdyn_solutionhistory))
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

    [AttributeLogicalName("msdyn_activityid")]
    public string msdyn_activityid
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_activityid));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_activityid));
        this.SetAttributeValue(nameof (msdyn_activityid), (object) value);
        this.OnPropertyChanged(nameof (msdyn_activityid));
      }
    }

    [AttributeLogicalName("msdyn_correlationid")]
    public string msdyn_correlationid
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_correlationid));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_correlationid));
        this.SetAttributeValue(nameof (msdyn_correlationid), (object) value);
        this.OnPropertyChanged(nameof (msdyn_correlationid));
      }
    }

    [AttributeLogicalName("msdyn_endtime")]
    public DateTime? msdyn_endtime
    {
      get => this.GetAttributeValue<DateTime?>(nameof (msdyn_endtime));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_endtime));
        this.SetAttributeValue(nameof (msdyn_endtime), (object) value);
        this.OnPropertyChanged(nameof (msdyn_endtime));
      }
    }

    [AttributeLogicalName("msdyn_errorcode")]
    public string msdyn_errorcode
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_errorcode));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_errorcode));
        this.SetAttributeValue(nameof (msdyn_errorcode), (object) value);
        this.OnPropertyChanged(nameof (msdyn_errorcode));
      }
    }

    [AttributeLogicalName("msdyn_exceptionmessage")]
    public string msdyn_exceptionmessage
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_exceptionmessage));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_exceptionmessage));
        this.SetAttributeValue(nameof (msdyn_exceptionmessage), (object) value);
        this.OnPropertyChanged(nameof (msdyn_exceptionmessage));
      }
    }

    [AttributeLogicalName("msdyn_exceptionstack")]
    public string msdyn_exceptionstack
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_exceptionstack));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_exceptionstack));
        this.SetAttributeValue(nameof (msdyn_exceptionstack), (object) value);
        this.OnPropertyChanged(nameof (msdyn_exceptionstack));
      }
    }

    [AttributeLogicalName("msdyn_ismanaged")]
    public bool? msdyn_ismanaged
    {
      get => this.GetAttributeValue<bool?>(nameof (msdyn_ismanaged));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_ismanaged));
        this.SetAttributeValue(nameof (msdyn_ismanaged), (object) value);
        this.OnPropertyChanged(nameof (msdyn_ismanaged));
      }
    }

    [AttributeLogicalName("msdyn_isoverwritecustomizations")]
    public bool? msdyn_isoverwritecustomizations
    {
      get => this.GetAttributeValue<bool?>(nameof (msdyn_isoverwritecustomizations));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_isoverwritecustomizations));
        this.SetAttributeValue(nameof (msdyn_isoverwritecustomizations), (object) value);
        this.OnPropertyChanged(nameof (msdyn_isoverwritecustomizations));
      }
    }

    [AttributeLogicalName("msdyn_ispatch")]
    public bool? msdyn_ispatch
    {
      get => this.GetAttributeValue<bool?>(nameof (msdyn_ispatch));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_ispatch));
        this.SetAttributeValue(nameof (msdyn_ispatch), (object) value);
        this.OnPropertyChanged(nameof (msdyn_ispatch));
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

    [AttributeLogicalName("msdyn_operation")]
    public OptionSetValue msdyn_operation
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (msdyn_operation));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_operation));
        this.SetAttributeValue(nameof (msdyn_operation), (object) value);
        this.OnPropertyChanged(nameof (msdyn_operation));
      }
    }

    [AttributeLogicalName("msdyn_packagename")]
    public string msdyn_packagename
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_packagename));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_packagename));
        this.SetAttributeValue(nameof (msdyn_packagename), (object) value);
        this.OnPropertyChanged(nameof (msdyn_packagename));
      }
    }

    [AttributeLogicalName("msdyn_packageversion")]
    public string msdyn_packageversion
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_packageversion));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_packageversion));
        this.SetAttributeValue(nameof (msdyn_packageversion), (object) value);
        this.OnPropertyChanged(nameof (msdyn_packageversion));
      }
    }

    [AttributeLogicalName("msdyn_publisherid")]
    public string msdyn_publisherid
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_publisherid));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_publisherid));
        this.SetAttributeValue(nameof (msdyn_publisherid), (object) value);
        this.OnPropertyChanged(nameof (msdyn_publisherid));
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

    [AttributeLogicalName("msdyn_result")]
    public bool? msdyn_result
    {
      get => this.GetAttributeValue<bool?>(nameof (msdyn_result));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_result));
        this.SetAttributeValue(nameof (msdyn_result), (object) value);
        this.OnPropertyChanged(nameof (msdyn_result));
      }
    }

    [AttributeLogicalName("msdyn_solutionhistoryid")]
    public Guid? msdyn_solutionhistoryId
    {
      get => this.GetAttributeValue<Guid?>("msdyn_solutionhistoryid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutionhistoryId));
        this.SetAttributeValue("msdyn_solutionhistoryid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (msdyn_solutionhistoryId));
      }
    }

    [AttributeLogicalName("msdyn_solutionhistoryid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.msdyn_solutionhistoryId = new Guid?(value);
    }

    [AttributeLogicalName("msdyn_solutionid")]
    public string msdyn_solutionid
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_solutionid));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutionid));
        this.SetAttributeValue(nameof (msdyn_solutionid), (object) value);
        this.OnPropertyChanged(nameof (msdyn_solutionid));
      }
    }

    [AttributeLogicalName("msdyn_solutionversion")]
    public string msdyn_solutionversion
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_solutionversion));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutionversion));
        this.SetAttributeValue(nameof (msdyn_solutionversion), (object) value);
        this.OnPropertyChanged(nameof (msdyn_solutionversion));
      }
    }

    [AttributeLogicalName("msdyn_starttime")]
    public DateTime? msdyn_starttime
    {
      get => this.GetAttributeValue<DateTime?>(nameof (msdyn_starttime));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_starttime));
        this.SetAttributeValue(nameof (msdyn_starttime), (object) value);
        this.OnPropertyChanged(nameof (msdyn_starttime));
      }
    }

    [AttributeLogicalName("msdyn_status")]
    public OptionSetValue msdyn_status
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (msdyn_status));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_status));
        this.SetAttributeValue(nameof (msdyn_status), (object) value);
        this.OnPropertyChanged(nameof (msdyn_status));
      }
    }

    [AttributeLogicalName("msdyn_suboperation")]
    public OptionSetValue msdyn_suboperation
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (msdyn_suboperation));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_suboperation));
        this.SetAttributeValue(nameof (msdyn_suboperation), (object) value);
        this.OnPropertyChanged(nameof (msdyn_suboperation));
      }
    }

    [AttributeLogicalName("msdyn_totaltime")]
    public int? msdyn_totaltime
    {
      get => this.GetAttributeValue<int?>(nameof (msdyn_totaltime));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_totaltime));
        this.SetAttributeValue(nameof (msdyn_totaltime), (object) value);
        this.OnPropertyChanged(nameof (msdyn_totaltime));
      }
    }

    public msdyn_solutionhistory(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["msdyn_solutionhistoryid"] = (object) base.Id;
            break;
          case "msdyn_solutionhistoryid":
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
