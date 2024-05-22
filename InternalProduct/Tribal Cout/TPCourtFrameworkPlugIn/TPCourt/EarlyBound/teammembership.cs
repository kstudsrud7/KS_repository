// Decompiled with JetBrains decompiler
// Type: TPCourt.EarlyBound.teammembership
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
  [EntityLogicalName("teammembership")]
  [GeneratedCode("XrmToolkit", "4.0")]
  [DataContract(Name = "Entity", Namespace = "http://schemas.microsoft.com/xrm/2011/Contracts")]
  public class teammembership : BaseProxyClass
  {
    public const string LogicalName = "teammembership";
    public const int ObjectTypeCode = 23;
    public const string PrimaryIdAttribute = "teammembershipid";
    public const string PrimaryNameAttribute = "";
    private static Dictionary<string, BaseProxyClass.eTextOptions> _textOptions;
    private static Dictionary<string, BaseProxyClass.eNumberOptions> _numberOptions;
    private static Dictionary<string, string> _errorStrings;

    static teammembership()
    {
      BaseProxyClass.RegisterProxyType(typeof (teammembership), nameof (teammembership));
      teammembership._textOptions = new Dictionary<string, BaseProxyClass.eTextOptions>();
      teammembership._numberOptions = new Dictionary<string, BaseProxyClass.eNumberOptions>();
      teammembership._errorStrings = new Dictionary<string, string>();
      teammembership.TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
      teammembership.NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
    }

    public teammembership()
      : base(new Entity(nameof (teammembership)))
    {
    }

    public teammembership(Entity original)
      : base(original)
    {
    }

    public static string GetLogicalName() => BaseProxyClass.GetLogicalName<teammembership>();

    public static BaseProxyClass.eTextOptions TextOptions { get; set; }

    public static void SetTextOptions(
      string logicalName,
      BaseProxyClass.eTextOptions options,
      string errorString = null)
    {
      if (teammembership._textOptions.ContainsKey(logicalName))
        teammembership._textOptions[logicalName] = options;
      else
        teammembership._textOptions.Add(logicalName, options);
      if (!string.IsNullOrEmpty(errorString))
      {
        if (teammembership._errorStrings.ContainsKey(logicalName))
          teammembership._errorStrings[logicalName] = errorString;
        else
          teammembership._errorStrings.Add(logicalName, errorString);
      }
      else
      {
        if (!teammembership._errorStrings.ContainsKey(logicalName))
          return;
        teammembership._errorStrings.Remove(logicalName);
      }
    }

    protected override BaseProxyClass.eTextOptions GetTextOptions(string logicalName)
    {
      return teammembership._textOptions.ContainsKey(logicalName) ? teammembership._textOptions[logicalName] : teammembership.TextOptions;
    }

    public static BaseProxyClass.eNumberOptions NumberOptions { get; set; }

    public static void SetNumberOptions(
      string logicalName,
      BaseProxyClass.eNumberOptions options,
      string errorString = null)
    {
      if (teammembership._numberOptions.ContainsKey(logicalName))
        teammembership._numberOptions[logicalName] = options;
      else
        teammembership._numberOptions.Add(logicalName, options);
      if (!string.IsNullOrEmpty(errorString))
      {
        if (teammembership._errorStrings.ContainsKey(logicalName))
          teammembership._errorStrings[logicalName] = errorString;
        else
          teammembership._errorStrings.Add(logicalName, errorString);
      }
      else
      {
        if (!teammembership._errorStrings.ContainsKey(logicalName))
          return;
        teammembership._errorStrings.Remove(logicalName);
      }
    }

    protected override BaseProxyClass.eNumberOptions GetNumberOptions(string logicalName)
    {
      return teammembership._numberOptions.ContainsKey(logicalName) ? teammembership._numberOptions[logicalName] : teammembership.NumberOptions;
    }

    protected override string GetErrorString(
      string attributeName,
      BaseProxyClass.eErrorType defaultErrorType)
    {
      return teammembership._errorStrings.ContainsKey(attributeName) ? teammembership._errorStrings[attributeName] : (defaultErrorType == BaseProxyClass.eErrorType.Text ? teammembership.TextError : teammembership.NumberError);
    }

    public static string TextError { get; set; }

    public static string NumberError { get; set; }

    [AttributeLogicalName("systemuserid")]
    public Guid systemuserid => this.GetPropertyValue<Guid>(nameof (systemuserid));

    [AttributeLogicalName("teamid")]
    public Guid teamid => this.GetPropertyValue<Guid>(nameof (teamid));

    [AttributeLogicalName("teammembershipid")]
    public Guid teammembershipid
    {
      get => this.Id;
      set
      {
        this.Id = value;
        this.SetPropertyValue<Guid>(nameof (teammembershipid), value, nameof (teammembershipid));
      }
    }

    [AttributeLogicalName("versionnumber")]
    public int? versionnumber => this.GetPropertyValue<int?>(nameof (versionnumber));

    public List<Entity> Getuserentityinstancedata_teammembership(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userentityinstancedata", "objectid", columns);
    }

    public List<Entity> Getuserentityinstancedata_teammembership(
      IOrganizationService service,
      ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, this.Id, "userentityinstancedata", "objectid", columns);
    }

    public List<team> Getteammembership_association(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedManyToManyEntities<team>(service, (BaseProxyClass) this, nameof (teammembership), "teammembershipid", "team", "teamid", nameof (teammembership), "systemuserid", "teamid", columns);
    }

    public List<team> Getteammembership_association(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedManyToManyEntities<team>(service, (BaseProxyClass) this, nameof (teammembership), "teammembershipid", "team", "teamid", nameof (teammembership), "systemuserid", "teamid", columns);
    }

    public void Relateteammembership_association(
      IOrganizationService service,
      params Entity[] items)
    {
      service.RelateEntities((EntityReference) (BaseProxyClass) this, "teammembership_association", items);
    }

    public void Relateteammembership_association(
      IOrganizationService service,
      params EntityReference[] items)
    {
      service.RelateEntities((EntityReference) (BaseProxyClass) this, "teammembership_association", items);
    }

    public void UnRelateteammembership_association(
      IOrganizationService service,
      params Entity[] items)
    {
      service.UnRelateEntities((EntityReference) (BaseProxyClass) this, "teammembership_association", items);
    }

    public void UnRelateteammembership_association(
      IOrganizationService service,
      params EntityReference[] items)
    {
      service.UnRelateEntities((EntityReference) (BaseProxyClass) this, "teammembership_association", items);
    }

    public static class Properties
    {
      public const string systemuserid = "systemuserid";
      public const string teamid = "teamid";
      public const string teammembershipid = "teammembershipid";
      public const string versionnumber = "versionnumber";
    }
  }
}
