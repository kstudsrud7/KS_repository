// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.RibbonMetadataToProcess
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ribbonmetadatatoprocess")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class RibbonMetadataToProcess : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ribbonmetadatatoprocess";
    public const string EntitySchemaName = "RibbonMetadataToProcess";
    public const string PrimaryIdAttribute = "ribbonmetadatarowid";

    public RibbonMetadataToProcess()
      : base("ribbonmetadatatoprocess")
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

    [AttributeLogicalName("completedon")]
    public DateTime? CompletedOn => this.GetAttributeValue<DateTime?>("completedon");

    [AttributeLogicalName("createdon")]
    public DateTime? CreatedOn => this.GetAttributeValue<DateTime?>("createdon");

    [AttributeLogicalName("entityname")]
    public string EntityName
    {
      get => this.GetAttributeValue<string>("entityname");
      set
      {
        this.OnPropertyChanging(nameof (EntityName));
        this.SetAttributeValue("entityname", (object) value);
        this.OnPropertyChanged(nameof (EntityName));
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

    [AttributeLogicalName("isdbupdate")]
    public int? IsDbUpdate
    {
      get => this.GetAttributeValue<int?>("isdbupdate");
      set
      {
        this.OnPropertyChanging(nameof (IsDbUpdate));
        this.SetAttributeValue("isdbupdate", (object) value);
        this.OnPropertyChanged(nameof (IsDbUpdate));
      }
    }

    [AttributeLogicalName("processedon")]
    public DateTime? ProcessedOn => this.GetAttributeValue<DateTime?>("processedon");

    [AttributeLogicalName("retrycount")]
    public int? RetryCount
    {
      get => this.GetAttributeValue<int?>("retrycount");
      set
      {
        this.OnPropertyChanging(nameof (RetryCount));
        this.SetAttributeValue("retrycount", (object) value);
        this.OnPropertyChanged(nameof (RetryCount));
      }
    }

    [AttributeLogicalName("ribbonmetadatarowid")]
    public Guid? RibbonMetadataRowId
    {
      get => this.GetAttributeValue<Guid?>("ribbonmetadatarowid");
      set
      {
        this.OnPropertyChanging(nameof (RibbonMetadataRowId));
        this.SetAttributeValue("ribbonmetadatarowid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (RibbonMetadataRowId));
      }
    }

    [AttributeLogicalName("ribbonmetadatarowid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.RibbonMetadataRowId = new Guid?(value);
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

    [AttributeLogicalName("status")]
    public int? Status
    {
      get => this.GetAttributeValue<int?>("status");
      set
      {
        this.OnPropertyChanging(nameof (Status));
        this.SetAttributeValue("status", (object) value);
        this.OnPropertyChanged(nameof (Status));
      }
    }

    public RibbonMetadataToProcess(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ribbonmetadatarowid"] = (object) base.Id;
            break;
          case "ribbonmetadatarowid":
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
