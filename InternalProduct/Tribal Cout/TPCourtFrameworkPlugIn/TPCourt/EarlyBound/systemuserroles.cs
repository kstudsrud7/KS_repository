// Decompiled with JetBrains decompiler
// Type: TPCourt.EarlyBound.systemuserroles
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
  [EntityLogicalName("systemuserroles")]
  [GeneratedCode("XrmToolkit", "4.0")]
  [DataContract(Name = "Entity", Namespace = "http://schemas.microsoft.com/xrm/2011/Contracts")]
  public class systemuserroles : BaseProxyClass
  {
    public const string LogicalName = "systemuserroles";
    public const int ObjectTypeCode = 15;
    public const string PrimaryIdAttribute = "systemuserroleid";
    public const string PrimaryNameAttribute = "";
    private static Dictionary<string, BaseProxyClass.eTextOptions> _textOptions;
    private static Dictionary<string, BaseProxyClass.eNumberOptions> _numberOptions;
    private static Dictionary<string, string> _errorStrings;

    static systemuserroles()
    {
      BaseProxyClass.RegisterProxyType(typeof (systemuserroles), nameof (systemuserroles));
      systemuserroles._textOptions = new Dictionary<string, BaseProxyClass.eTextOptions>();
      systemuserroles._numberOptions = new Dictionary<string, BaseProxyClass.eNumberOptions>();
      systemuserroles._errorStrings = new Dictionary<string, string>();
      systemuserroles.TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
      systemuserroles.NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
    }

    public systemuserroles()
      : base(new Entity(nameof (systemuserroles)))
    {
    }

    public systemuserroles(Entity original)
      : base(original)
    {
    }

    public static string GetLogicalName() => BaseProxyClass.GetLogicalName<systemuserroles>();

    public static BaseProxyClass.eTextOptions TextOptions { get; set; }

    public static void SetTextOptions(
      string logicalName,
      BaseProxyClass.eTextOptions options,
      string errorString = null)
    {
      if (systemuserroles._textOptions.ContainsKey(logicalName))
        systemuserroles._textOptions[logicalName] = options;
      else
        systemuserroles._textOptions.Add(logicalName, options);
      if (!string.IsNullOrEmpty(errorString))
      {
        if (systemuserroles._errorStrings.ContainsKey(logicalName))
          systemuserroles._errorStrings[logicalName] = errorString;
        else
          systemuserroles._errorStrings.Add(logicalName, errorString);
      }
      else
      {
        if (!systemuserroles._errorStrings.ContainsKey(logicalName))
          return;
        systemuserroles._errorStrings.Remove(logicalName);
      }
    }

    protected override BaseProxyClass.eTextOptions GetTextOptions(string logicalName)
    {
      return systemuserroles._textOptions.ContainsKey(logicalName) ? systemuserroles._textOptions[logicalName] : systemuserroles.TextOptions;
    }

    public static BaseProxyClass.eNumberOptions NumberOptions { get; set; }

    public static void SetNumberOptions(
      string logicalName,
      BaseProxyClass.eNumberOptions options,
      string errorString = null)
    {
      if (systemuserroles._numberOptions.ContainsKey(logicalName))
        systemuserroles._numberOptions[logicalName] = options;
      else
        systemuserroles._numberOptions.Add(logicalName, options);
      if (!string.IsNullOrEmpty(errorString))
      {
        if (systemuserroles._errorStrings.ContainsKey(logicalName))
          systemuserroles._errorStrings[logicalName] = errorString;
        else
          systemuserroles._errorStrings.Add(logicalName, errorString);
      }
      else
      {
        if (!systemuserroles._errorStrings.ContainsKey(logicalName))
          return;
        systemuserroles._errorStrings.Remove(logicalName);
      }
    }

    protected override BaseProxyClass.eNumberOptions GetNumberOptions(string logicalName)
    {
      return systemuserroles._numberOptions.ContainsKey(logicalName) ? systemuserroles._numberOptions[logicalName] : systemuserroles.NumberOptions;
    }

    protected override string GetErrorString(
      string attributeName,
      BaseProxyClass.eErrorType defaultErrorType)
    {
      return systemuserroles._errorStrings.ContainsKey(attributeName) ? systemuserroles._errorStrings[attributeName] : (defaultErrorType == BaseProxyClass.eErrorType.Text ? systemuserroles.TextError : systemuserroles.NumberError);
    }

    public static string TextError { get; set; }

    public static string NumberError { get; set; }

    [AttributeLogicalName("roleid")]
    public Guid roleid => this.GetPropertyValue<Guid>(nameof (roleid));

    [AttributeLogicalName("systemuserid")]
    public Guid systemuserid => this.GetPropertyValue<Guid>(nameof (systemuserid));

    [AttributeLogicalName("systemuserroleid")]
    public Guid systemuserroleid
    {
      get => this.Id;
      set
      {
        this.Id = value;
        this.SetPropertyValue<Guid>(nameof (systemuserroleid), value, nameof (systemuserroleid));
      }
    }

    [AttributeLogicalName("versionnumber")]
    public int? versionnumber => this.GetPropertyValue<int?>(nameof (versionnumber));

    public List<systemuser> Getsystemuserroles_association(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedManyToManyEntities<systemuser>(service, (BaseProxyClass) this, nameof (systemuserroles), "systemuserroleid", "systemuser", "systemuserid", nameof (systemuserroles), "roleid", "systemuserid", columns);
    }

    public List<systemuser> Getsystemuserroles_association(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedManyToManyEntities<systemuser>(service, (BaseProxyClass) this, nameof (systemuserroles), "systemuserroleid", "systemuser", "systemuserid", nameof (systemuserroles), "roleid", "systemuserid", columns);
    }

    public void Relatesystemuserroles_association(
      IOrganizationService service,
      params Entity[] items)
    {
      service.RelateEntities((EntityReference) (BaseProxyClass) this, "systemuserroles_association", items);
    }

    public void Relatesystemuserroles_association(
      IOrganizationService service,
      params EntityReference[] items)
    {
      service.RelateEntities((EntityReference) (BaseProxyClass) this, "systemuserroles_association", items);
    }

    public void UnRelatesystemuserroles_association(
      IOrganizationService service,
      params Entity[] items)
    {
      service.UnRelateEntities((EntityReference) (BaseProxyClass) this, "systemuserroles_association", items);
    }

    public void UnRelatesystemuserroles_association(
      IOrganizationService service,
      params EntityReference[] items)
    {
      service.UnRelateEntities((EntityReference) (BaseProxyClass) this, "systemuserroles_association", items);
    }

    public static class Properties
    {
      public const string roleid = "roleid";
      public const string systemuserid = "systemuserid";
      public const string systemuserroleid = "systemuserroleid";
      public const string versionnumber = "versionnumber";
    }
  }
}
