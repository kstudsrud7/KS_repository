// Decompiled with JetBrains decompiler
// Type: TPCourt.EarlyBound.ait_courtfinesandfees_ait_courtprofile
// Assembly: TPCourt.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: 615270E2-97DB-4878-8B8F-88925A0FA667
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPCourtFrameworkPlugIn-41F62F3A-2F19-44F2-86DD-4C4AA2D959EF\TPCourtFrameworkPlugIn.dll

using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Runtime.Serialization;

#nullable disable
namespace TPCourt.EarlyBound
{
  [EntityLogicalName("ait_courtfinesandfees_ait_courtprofile")]
  [GeneratedCode("XrmToolkit", "4.0")]
  [DataContract(Name = "Entity", Namespace = "http://schemas.microsoft.com/xrm/2011/Contracts")]
  public class ait_courtfinesandfees_ait_courtprofile : BaseProxyClass
  {
    public const string LogicalName = "ait_courtfinesandfees_ait_courtprofile";
    public const int ObjectTypeCode = 10161;
    public const string PrimaryIdAttribute = "ait_courtfinesandfees_ait_courtprofileid";
    public const string PrimaryNameAttribute = "";
    private static Dictionary<string, BaseProxyClass.eTextOptions> _textOptions;
    private static Dictionary<string, BaseProxyClass.eNumberOptions> _numberOptions;
    private static Dictionary<string, string> _errorStrings;

    static ait_courtfinesandfees_ait_courtprofile()
    {
      BaseProxyClass.RegisterProxyType(typeof (ait_courtfinesandfees_ait_courtprofile), nameof (ait_courtfinesandfees_ait_courtprofile));
      ait_courtfinesandfees_ait_courtprofile._textOptions = new Dictionary<string, BaseProxyClass.eTextOptions>();
      ait_courtfinesandfees_ait_courtprofile._numberOptions = new Dictionary<string, BaseProxyClass.eNumberOptions>();
      ait_courtfinesandfees_ait_courtprofile._errorStrings = new Dictionary<string, string>();
      ait_courtfinesandfees_ait_courtprofile.TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
      ait_courtfinesandfees_ait_courtprofile.NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
    }

    public ait_courtfinesandfees_ait_courtprofile()
      : base(new Entity(nameof (ait_courtfinesandfees_ait_courtprofile)))
    {
    }

    public ait_courtfinesandfees_ait_courtprofile(Entity original)
      : base(original)
    {
    }

    public static string GetLogicalName()
    {
      return BaseProxyClass.GetLogicalName<ait_courtfinesandfees_ait_courtprofile>();
    }

    public static BaseProxyClass.eTextOptions TextOptions { get; set; }

    public static void SetTextOptions(
      string logicalName,
      BaseProxyClass.eTextOptions options,
      string errorString = null)
    {
      if (ait_courtfinesandfees_ait_courtprofile._textOptions.ContainsKey(logicalName))
        ait_courtfinesandfees_ait_courtprofile._textOptions[logicalName] = options;
      else
        ait_courtfinesandfees_ait_courtprofile._textOptions.Add(logicalName, options);
      if (!string.IsNullOrEmpty(errorString))
      {
        if (ait_courtfinesandfees_ait_courtprofile._errorStrings.ContainsKey(logicalName))
          ait_courtfinesandfees_ait_courtprofile._errorStrings[logicalName] = errorString;
        else
          ait_courtfinesandfees_ait_courtprofile._errorStrings.Add(logicalName, errorString);
      }
      else
      {
        if (!ait_courtfinesandfees_ait_courtprofile._errorStrings.ContainsKey(logicalName))
          return;
        ait_courtfinesandfees_ait_courtprofile._errorStrings.Remove(logicalName);
      }
    }

    protected override BaseProxyClass.eTextOptions GetTextOptions(string logicalName)
    {
      return ait_courtfinesandfees_ait_courtprofile._textOptions.ContainsKey(logicalName) ? ait_courtfinesandfees_ait_courtprofile._textOptions[logicalName] : ait_courtfinesandfees_ait_courtprofile.TextOptions;
    }

    public static BaseProxyClass.eNumberOptions NumberOptions { get; set; }

    public static void SetNumberOptions(
      string logicalName,
      BaseProxyClass.eNumberOptions options,
      string errorString = null)
    {
      if (ait_courtfinesandfees_ait_courtprofile._numberOptions.ContainsKey(logicalName))
        ait_courtfinesandfees_ait_courtprofile._numberOptions[logicalName] = options;
      else
        ait_courtfinesandfees_ait_courtprofile._numberOptions.Add(logicalName, options);
      if (!string.IsNullOrEmpty(errorString))
      {
        if (ait_courtfinesandfees_ait_courtprofile._errorStrings.ContainsKey(logicalName))
          ait_courtfinesandfees_ait_courtprofile._errorStrings[logicalName] = errorString;
        else
          ait_courtfinesandfees_ait_courtprofile._errorStrings.Add(logicalName, errorString);
      }
      else
      {
        if (!ait_courtfinesandfees_ait_courtprofile._errorStrings.ContainsKey(logicalName))
          return;
        ait_courtfinesandfees_ait_courtprofile._errorStrings.Remove(logicalName);
      }
    }

    protected override BaseProxyClass.eNumberOptions GetNumberOptions(string logicalName)
    {
      return ait_courtfinesandfees_ait_courtprofile._numberOptions.ContainsKey(logicalName) ? ait_courtfinesandfees_ait_courtprofile._numberOptions[logicalName] : ait_courtfinesandfees_ait_courtprofile.NumberOptions;
    }

    protected override string GetErrorString(
      string attributeName,
      BaseProxyClass.eErrorType defaultErrorType)
    {
      return ait_courtfinesandfees_ait_courtprofile._errorStrings.ContainsKey(attributeName) ? ait_courtfinesandfees_ait_courtprofile._errorStrings[attributeName] : (defaultErrorType == BaseProxyClass.eErrorType.Text ? ait_courtfinesandfees_ait_courtprofile.TextError : ait_courtfinesandfees_ait_courtprofile.NumberError);
    }

    public static string TextError { get; set; }

    public static string NumberError { get; set; }

    [AttributeLogicalName("ait_courtfinesandfees_ait_courtprofileid")]
    public Guid ait_courtfinesandfees_ait_courtprofileid
    {
      get => this.Id;
      set
      {
        this.Id = value;
        this.SetPropertyValue<Guid>(nameof (ait_courtfinesandfees_ait_courtprofileid), value, nameof (ait_courtfinesandfees_ait_courtprofileid));
      }
    }

    [AttributeLogicalName("ait_courtfinesandfeesid")]
    public Guid ait_courtfinesandfeesid
    {
      get => this.GetPropertyValue<Guid>(nameof (ait_courtfinesandfeesid));
    }

    [AttributeLogicalName("ait_courtprofileid")]
    public Guid ait_courtprofileid => this.GetPropertyValue<Guid>(nameof (ait_courtprofileid));

    [AttributeLogicalName("versionnumber")]
    public int? versionnumber => this.GetPropertyValue<int?>(nameof (versionnumber));

    public List<ait_courtfinesandfees> Getait_courtfinesandfees_ait_courtprofile(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedManyToManyEntities<ait_courtfinesandfees>(service, (BaseProxyClass) this, nameof (ait_courtfinesandfees_ait_courtprofile), "ait_courtfinesandfees_ait_courtprofileid", "ait_courtfinesandfees", "ait_courtfinesandfeesid", nameof (ait_courtfinesandfees_ait_courtprofile), "ait_courtprofileid", "ait_courtfinesandfeesid", columns);
    }

    public List<ait_courtfinesandfees> Getait_courtfinesandfees_ait_courtprofile(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedManyToManyEntities<ait_courtfinesandfees>(service, (BaseProxyClass) this, nameof (ait_courtfinesandfees_ait_courtprofile), "ait_courtfinesandfees_ait_courtprofileid", "ait_courtfinesandfees", "ait_courtfinesandfeesid", nameof (ait_courtfinesandfees_ait_courtprofile), "ait_courtprofileid", "ait_courtfinesandfeesid", columns);
    }

    public void Relateait_courtfinesandfees_ait_courtprofile(
      IOrganizationService service,
      params Entity[] items)
    {
      service.RelateEntities((EntityReference) (BaseProxyClass) this, nameof (ait_courtfinesandfees_ait_courtprofile), items);
    }

    public void Relateait_courtfinesandfees_ait_courtprofile(
      IOrganizationService service,
      params EntityReference[] items)
    {
      service.RelateEntities((EntityReference) (BaseProxyClass) this, nameof (ait_courtfinesandfees_ait_courtprofile), items);
    }

    public void UnRelateait_courtfinesandfees_ait_courtprofile(
      IOrganizationService service,
      params Entity[] items)
    {
      service.UnRelateEntities((EntityReference) (BaseProxyClass) this, nameof (ait_courtfinesandfees_ait_courtprofile), items);
    }

    public void UnRelateait_courtfinesandfees_ait_courtprofile(
      IOrganizationService service,
      params EntityReference[] items)
    {
      service.UnRelateEntities((EntityReference) (BaseProxyClass) this, nameof (ait_courtfinesandfees_ait_courtprofile), items);
    }

    public static class Properties
    {
      public const string ait_courtfinesandfees_ait_courtprofileid = "ait_courtfinesandfees_ait_courtprofileid";
      public const string ait_courtfinesandfeesid = "ait_courtfinesandfeesid";
      public const string ait_courtprofileid = "ait_courtprofileid";
      public const string versionnumber = "versionnumber";
    }
  }
}
