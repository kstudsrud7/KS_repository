﻿// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.searchtelemetry
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("searchtelemetry")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class searchtelemetry : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "searchtelemetry";
    public const string EntitySchemaName = "searchtelemetry";
    public const string PrimaryIdAttribute = "searchtelemetryid";
    public const string PrimaryNameAttribute = "userquery";

    public searchtelemetry()
      : base(nameof (searchtelemetry))
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

    [AttributeLogicalName("correlationid")]
    public string CorrelationId
    {
      get => this.GetAttributeValue<string>("correlationid");
      set
      {
        this.OnPropertyChanging(nameof (CorrelationId));
        this.SetAttributeValue("correlationid", (object) value);
        this.OnPropertyChanged(nameof (CorrelationId));
      }
    }

    [AttributeLogicalName("createdon")]
    public DateTime? CreatedOn => this.GetAttributeValue<DateTime?>("createdon");

    [AttributeLogicalName("feedbackdata")]
    public string FeedbackData
    {
      get => this.GetAttributeValue<string>("feedbackdata");
      set
      {
        this.OnPropertyChanging(nameof (FeedbackData));
        this.SetAttributeValue("feedbackdata", (object) value);
        this.OnPropertyChanged(nameof (FeedbackData));
      }
    }

    [AttributeLogicalName("requestid")]
    public string RequestId
    {
      get => this.GetAttributeValue<string>("requestid");
      set
      {
        this.OnPropertyChanging(nameof (RequestId));
        this.SetAttributeValue("requestid", (object) value);
        this.OnPropertyChanged(nameof (RequestId));
      }
    }

    [AttributeLogicalName("searchtelemetryid")]
    public Guid? searchtelemetryId
    {
      get => this.GetAttributeValue<Guid?>("searchtelemetryid");
      set
      {
        this.OnPropertyChanging(nameof (searchtelemetryId));
        this.SetAttributeValue("searchtelemetryid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (searchtelemetryId));
      }
    }

    [AttributeLogicalName("searchtelemetryid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.searchtelemetryId = new Guid?(value);
    }

    [AttributeLogicalName("sessionid")]
    public string SessionId
    {
      get => this.GetAttributeValue<string>("sessionid");
      set
      {
        this.OnPropertyChanging(nameof (SessionId));
        this.SetAttributeValue("sessionid", (object) value);
        this.OnPropertyChanged(nameof (SessionId));
      }
    }

    [AttributeLogicalName("ttlinseconds")]
    public int? TTLInSeconds
    {
      get => this.GetAttributeValue<int?>("ttlinseconds");
      set
      {
        this.OnPropertyChanging(nameof (TTLInSeconds));
        this.SetAttributeValue("ttlinseconds", (object) value);
        this.OnPropertyChanged(nameof (TTLInSeconds));
      }
    }

    [AttributeLogicalName("userquery")]
    public string UserQuery
    {
      get => this.GetAttributeValue<string>("userquery");
      set
      {
        this.OnPropertyChanging(nameof (UserQuery));
        this.SetAttributeValue("userquery", (object) value);
        this.OnPropertyChanged(nameof (UserQuery));
      }
    }

    public searchtelemetry(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["searchtelemetryid"] = (object) base.Id;
            break;
          case "searchtelemetryid":
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