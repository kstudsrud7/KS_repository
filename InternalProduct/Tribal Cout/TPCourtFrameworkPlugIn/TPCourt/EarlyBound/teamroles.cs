// Decompiled with JetBrains decompiler
// Type: TPCourt.EarlyBound.teamroles
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
  [EntityLogicalName("teamroles")]
  [GeneratedCode("XrmToolkit", "4.0")]
  [DataContract(Name = "Entity", Namespace = "http://schemas.microsoft.com/xrm/2011/Contracts")]
  public class teamroles : BaseProxyClass
  {
    public const string LogicalName = "teamroles";
    public const int ObjectTypeCode = 40;
    public const string PrimaryIdAttribute = "teamroleid";
    public const string PrimaryNameAttribute = "";
    private static Dictionary<string, BaseProxyClass.eTextOptions> _textOptions;
    private static Dictionary<string, BaseProxyClass.eNumberOptions> _numberOptions;
    private static Dictionary<string, string> _errorStrings;

    static teamroles()
    {
      BaseProxyClass.RegisterProxyType(typeof (teamroles), nameof (teamroles));
      teamroles._textOptions = new Dictionary<string, BaseProxyClass.eTextOptions>();
      teamroles._numberOptions = new Dictionary<string, BaseProxyClass.eNumberOptions>();
      teamroles._errorStrings = new Dictionary<string, string>();
      teamroles.TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
      teamroles.NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
    }

    public teamroles()
      : base(new Entity(nameof (teamroles)))
    {
    }

    public teamroles(Entity original)
      : base(original)
    {
    }

    public static string GetLogicalName() => BaseProxyClass.GetLogicalName<teamroles>();

    public static BaseProxyClass.eTextOptions TextOptions { get; set; }

    public static void SetTextOptions(
      string logicalName,
      BaseProxyClass.eTextOptions options,
      string errorString = null)
    {
      if (teamroles._textOptions.ContainsKey(logicalName))
        teamroles._textOptions[logicalName] = options;
      else
        teamroles._textOptions.Add(logicalName, options);
      if (!string.IsNullOrEmpty(errorString))
      {
        if (teamroles._errorStrings.ContainsKey(logicalName))
          teamroles._errorStrings[logicalName] = errorString;
        else
          teamroles._errorStrings.Add(logicalName, errorString);
      }
      else
      {
        if (!teamroles._errorStrings.ContainsKey(logicalName))
          return;
        teamroles._errorStrings.Remove(logicalName);
      }
    }

    protected override BaseProxyClass.eTextOptions GetTextOptions(string logicalName)
    {
      return teamroles._textOptions.ContainsKey(logicalName) ? teamroles._textOptions[logicalName] : teamroles.TextOptions;
    }

    public static BaseProxyClass.eNumberOptions NumberOptions { get; set; }

    public static void SetNumberOptions(
      string logicalName,
      BaseProxyClass.eNumberOptions options,
      string errorString = null)
    {
      if (teamroles._numberOptions.ContainsKey(logicalName))
        teamroles._numberOptions[logicalName] = options;
      else
        teamroles._numberOptions.Add(logicalName, options);
      if (!string.IsNullOrEmpty(errorString))
      {
        if (teamroles._errorStrings.ContainsKey(logicalName))
          teamroles._errorStrings[logicalName] = errorString;
        else
          teamroles._errorStrings.Add(logicalName, errorString);
      }
      else
      {
        if (!teamroles._errorStrings.ContainsKey(logicalName))
          return;
        teamroles._errorStrings.Remove(logicalName);
      }
    }

    protected override BaseProxyClass.eNumberOptions GetNumberOptions(string logicalName)
    {
      return teamroles._numberOptions.ContainsKey(logicalName) ? teamroles._numberOptions[logicalName] : teamroles.NumberOptions;
    }

    protected override string GetErrorString(
      string attributeName,
      BaseProxyClass.eErrorType defaultErrorType)
    {
      return teamroles._errorStrings.ContainsKey(attributeName) ? teamroles._errorStrings[attributeName] : (defaultErrorType == BaseProxyClass.eErrorType.Text ? teamroles.TextError : teamroles.NumberError);
    }

    public static string TextError { get; set; }

    public static string NumberError { get; set; }

    [AttributeLogicalName("roleid")]
    public Guid roleid => this.GetPropertyValue<Guid>(nameof (roleid));

    [AttributeLogicalName("teamid")]
    public Guid teamid => this.GetPropertyValue<Guid>(nameof (teamid));

    [AttributeLogicalName("teamroleid")]
    public Guid teamroleid
    {
      get => this.Id;
      set
      {
        this.Id = value;
        this.SetPropertyValue<Guid>(nameof (teamroleid), value, nameof (teamroleid));
      }
    }

    [AttributeLogicalName("versionnumber")]
    public int? versionnumber => this.GetPropertyValue<int?>(nameof (versionnumber));

    public List<team> Getteamroles_association(
      IOrganizationService service,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedManyToManyEntities<team>(service, (BaseProxyClass) this, nameof (teamroles), "teamroleid", "team", "teamid", nameof (teamroles), "roleid", "teamid", columns);
    }

    public List<team> Getteamroles_association(IOrganizationService service, ColumnSet columns)
    {
      return BaseProxyClass.GetRelatedManyToManyEntities<team>(service, (BaseProxyClass) this, nameof (teamroles), "teamroleid", "team", "teamid", nameof (teamroles), "roleid", "teamid", columns);
    }

    public void Relateteamroles_association(IOrganizationService service, params Entity[] items)
    {
      service.RelateEntities((EntityReference) (BaseProxyClass) this, "teamroles_association", items);
    }

    public void Relateteamroles_association(
      IOrganizationService service,
      params EntityReference[] items)
    {
      service.RelateEntities((EntityReference) (BaseProxyClass) this, "teamroles_association", items);
    }

    public void UnRelateteamroles_association(IOrganizationService service, params Entity[] items)
    {
      service.UnRelateEntities((EntityReference) (BaseProxyClass) this, "teamroles_association", items);
    }

    public void UnRelateteamroles_association(
      IOrganizationService service,
      params EntityReference[] items)
    {
      service.UnRelateEntities((EntityReference) (BaseProxyClass) this, "teamroles_association", items);
    }

    public static class Properties
    {
      public const string roleid = "roleid";
      public const string teamid = "teamid";
      public const string teamroleid = "teamroleid";
      public const string versionnumber = "versionnumber";
    }
  }
}
