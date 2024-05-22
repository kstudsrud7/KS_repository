// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.SolutionHistoryData
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("solutionhistorydata")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class SolutionHistoryData : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "solutionhistorydata";
    public const string EntitySchemaName = "SolutionHistoryData";
    public const string PrimaryIdAttribute = "solutionhistorydataid";

    public SolutionHistoryData()
      : base("solutionhistorydata")
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

    [AttributeLogicalName("activityid")]
    public Guid? ActivityId
    {
      get => this.GetAttributeValue<Guid?>("activityid");
      set
      {
        this.OnPropertyChanging(nameof (ActivityId));
        this.SetAttributeValue("activityid", (object) value);
        this.OnPropertyChanged(nameof (ActivityId));
      }
    }

    [AttributeLogicalName("correlationid")]
    public Guid? CorrelationId
    {
      get => this.GetAttributeValue<Guid?>("correlationid");
      set
      {
        this.OnPropertyChanging(nameof (CorrelationId));
        this.SetAttributeValue("correlationid", (object) value);
        this.OnPropertyChanged(nameof (CorrelationId));
      }
    }

    [AttributeLogicalName("endtime")]
    public DateTime? EndTime
    {
      get => this.GetAttributeValue<DateTime?>("endtime");
      set
      {
        this.OnPropertyChanging(nameof (EndTime));
        this.SetAttributeValue("endtime", (object) value);
        this.OnPropertyChanged(nameof (EndTime));
      }
    }

    [AttributeLogicalName("errorcode")]
    public int? ErrorCode
    {
      get => this.GetAttributeValue<int?>("errorcode");
      set
      {
        this.OnPropertyChanging(nameof (ErrorCode));
        this.SetAttributeValue("errorcode", (object) value);
        this.OnPropertyChanged(nameof (ErrorCode));
      }
    }

    [AttributeLogicalName("exceptionmessage")]
    public string ExceptionMessage
    {
      get => this.GetAttributeValue<string>("exceptionmessage");
      set
      {
        this.OnPropertyChanging(nameof (ExceptionMessage));
        this.SetAttributeValue("exceptionmessage", (object) value);
        this.OnPropertyChanged(nameof (ExceptionMessage));
      }
    }

    [AttributeLogicalName("exceptionstack")]
    public string ExceptionStack
    {
      get => this.GetAttributeValue<string>("exceptionstack");
      set
      {
        this.OnPropertyChanging(nameof (ExceptionStack));
        this.SetAttributeValue("exceptionstack", (object) value);
        this.OnPropertyChanged(nameof (ExceptionStack));
      }
    }

    [AttributeLogicalName("ismanaged")]
    public bool? IsManaged
    {
      get => this.GetAttributeValue<bool?>("ismanaged");
      set
      {
        this.OnPropertyChanging(nameof (IsManaged));
        this.SetAttributeValue("ismanaged", (object) value);
        this.OnPropertyChanged(nameof (IsManaged));
      }
    }

    [AttributeLogicalName("ismicrosoftpublisher")]
    public bool? IsMicrosoftPublisher
    {
      get => this.GetAttributeValue<bool?>("ismicrosoftpublisher");
      set
      {
        this.OnPropertyChanging(nameof (IsMicrosoftPublisher));
        this.SetAttributeValue("ismicrosoftpublisher", (object) value);
        this.OnPropertyChanged(nameof (IsMicrosoftPublisher));
      }
    }

    [AttributeLogicalName("isoverwritecustomizations")]
    public bool? IsOverwriteCustomizations
    {
      get => this.GetAttributeValue<bool?>("isoverwritecustomizations");
      set
      {
        this.OnPropertyChanging(nameof (IsOverwriteCustomizations));
        this.SetAttributeValue("isoverwritecustomizations", (object) value);
        this.OnPropertyChanged(nameof (IsOverwriteCustomizations));
      }
    }

    [AttributeLogicalName("ispatch")]
    public bool? IsPatch
    {
      get => this.GetAttributeValue<bool?>("ispatch");
      set
      {
        this.OnPropertyChanging(nameof (IsPatch));
        this.SetAttributeValue("ispatch", (object) value);
        this.OnPropertyChanged(nameof (IsPatch));
      }
    }

    [AttributeLogicalName("operation")]
    public OptionSetValue Operation
    {
      get => this.GetAttributeValue<OptionSetValue>("operation");
      set
      {
        this.OnPropertyChanging(nameof (Operation));
        this.SetAttributeValue("operation", (object) value);
        this.OnPropertyChanged(nameof (Operation));
      }
    }

    [AttributeLogicalName("packagename")]
    public string PackageName
    {
      get => this.GetAttributeValue<string>("packagename");
      set
      {
        this.OnPropertyChanging(nameof (PackageName));
        this.SetAttributeValue("packagename", (object) value);
        this.OnPropertyChanged(nameof (PackageName));
      }
    }

    [AttributeLogicalName("packageversion")]
    public string PackageVersion
    {
      get => this.GetAttributeValue<string>("packageversion");
      set
      {
        this.OnPropertyChanging(nameof (PackageVersion));
        this.SetAttributeValue("packageversion", (object) value);
        this.OnPropertyChanged(nameof (PackageVersion));
      }
    }

    [AttributeLogicalName("publishername")]
    public string PublisherName
    {
      get => this.GetAttributeValue<string>("publishername");
      set
      {
        this.OnPropertyChanging(nameof (PublisherName));
        this.SetAttributeValue("publishername", (object) value);
        this.OnPropertyChanged(nameof (PublisherName));
      }
    }

    [AttributeLogicalName("result")]
    public int? Result
    {
      get => this.GetAttributeValue<int?>("result");
      set
      {
        this.OnPropertyChanging(nameof (Result));
        this.SetAttributeValue("result", (object) value);
        this.OnPropertyChanged(nameof (Result));
      }
    }

    [AttributeLogicalName("solutionhistorydataid")]
    public Guid? SolutionHistoryDataId
    {
      get => this.GetAttributeValue<Guid?>("solutionhistorydataid");
      set
      {
        this.OnPropertyChanging(nameof (SolutionHistoryDataId));
        this.SetAttributeValue("solutionhistorydataid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (SolutionHistoryDataId));
      }
    }

    [AttributeLogicalName("solutionhistorydataid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.SolutionHistoryDataId = new Guid?(value);
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId
    {
      get => this.GetAttributeValue<Guid?>("solutionid");
      set
      {
        this.OnPropertyChanging(nameof (SolutionId));
        this.SetAttributeValue("solutionid", (object) value);
        this.OnPropertyChanged(nameof (SolutionId));
      }
    }

    [AttributeLogicalName("solutionname")]
    public string SolutionName
    {
      get => this.GetAttributeValue<string>("solutionname");
      set
      {
        this.OnPropertyChanging(nameof (SolutionName));
        this.SetAttributeValue("solutionname", (object) value);
        this.OnPropertyChanged(nameof (SolutionName));
      }
    }

    [AttributeLogicalName("solutionversion")]
    public string SolutionVersion
    {
      get => this.GetAttributeValue<string>("solutionversion");
      set
      {
        this.OnPropertyChanging(nameof (SolutionVersion));
        this.SetAttributeValue("solutionversion", (object) value);
        this.OnPropertyChanged(nameof (SolutionVersion));
      }
    }

    [AttributeLogicalName("starttime")]
    public DateTime? StartTime
    {
      get => this.GetAttributeValue<DateTime?>("starttime");
      set
      {
        this.OnPropertyChanging(nameof (StartTime));
        this.SetAttributeValue("starttime", (object) value);
        this.OnPropertyChanged(nameof (StartTime));
      }
    }

    [AttributeLogicalName("status")]
    public OptionSetValue Status
    {
      get => this.GetAttributeValue<OptionSetValue>("status");
      set
      {
        this.OnPropertyChanging(nameof (Status));
        this.SetAttributeValue("status", (object) value);
        this.OnPropertyChanged(nameof (Status));
      }
    }

    [AttributeLogicalName("suboperation")]
    public OptionSetValue SubOperation
    {
      get => this.GetAttributeValue<OptionSetValue>("suboperation");
      set
      {
        this.OnPropertyChanging(nameof (SubOperation));
        this.SetAttributeValue("suboperation", (object) value);
        this.OnPropertyChanged(nameof (SubOperation));
      }
    }

    public SolutionHistoryData(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["solutionhistorydataid"] = (object) base.Id;
            break;
          case "solutionhistorydataid":
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
