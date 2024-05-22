// Decompiled with JetBrains decompiler
// Type: ArcticIT.CrmFramework.Libraries.FormatLibrary
// Assembly: TPCourt.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: 615270E2-97DB-4878-8B8F-88925A0FA667
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPCourtFrameworkPlugIn-41F62F3A-2F19-44F2-86DD-4C4AA2D959EF\TPCourtFrameworkPlugIn.dll

using ArcticIT.CrmFramework.Plugins;
using Microsoft.Xrm.Sdk;
using System;

#nullable disable
namespace ArcticIT.CrmFramework.Libraries
{
  internal class FormatLibrary
  {
    public static string FormatName(string value1, string value2)
    {
      return string.Format("{0}{1}{2}", (object) value1, (object) " : ", (object) value2);
    }

    public static string FormatName(string value1, string value2, string value3)
    {
      return string.Format("{0}{1}{2}{3}{4}", (object) value1, (object) " : ", (object) value2, (object) " : ", (object) value3);
    }

    public static string FormatName(string value1, string value2, string value3, string value4)
    {
      return string.Format("{0}{1}{2}{3}{4}{5}{6}", (object) value1, (object) " : ", (object) value2, (object) " : ", (object) value3, (object) " : ", (object) value4);
    }

    public static string FormatName(
      string value1,
      string value2,
      string value3,
      string value4,
      string value5)
    {
      return string.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}", (object) value1, (object) " : ", (object) value2, (object) " : ", (object) value3, (object) " : ", (object) value4, (object) " : ", (object) value5);
    }

    public static string GetEntityValue(int? baseValue, int? preImageValue)
    {
      return !baseValue.HasValue && !preImageValue.HasValue ? string.Empty : FormatLibrary.GetFormatValue(new int?(baseValue.HasValue ? baseValue.Value : preImageValue.Value));
    }

    public static string GetEntityValue(Money baseValue, Money preImageValue)
    {
      return baseValue == null && preImageValue == null ? string.Empty : FormatLibrary.GetFormatValue(baseValue != null ? baseValue : preImageValue);
    }

    public static string GetEntityValue(DateTime? baseValue, DateTime? preImageValue)
    {
      return !baseValue.HasValue && !preImageValue.HasValue ? string.Empty : FormatLibrary.GetFormatValue(new DateTime?(baseValue.HasValue ? baseValue.Value : preImageValue.Value));
    }

    public static string GetEntityValue(string baseValue, string preImageValue)
    {
      return baseValue != null ? baseValue : preImageValue;
    }

    public static string GetEntityValue(
      IOrganizationService crmService,
      EntityReference baseValue,
      EntityReference preImageValue)
    {
      if (baseValue == null && preImageValue == null)
        return string.Empty;
      string entityValue = string.Empty;
      EntityReference entityReference = baseValue == null ? preImageValue : baseValue;
      if (entityReference != null)
        entityValue = entityReference.Name;
      if (string.IsNullOrEmpty(entityValue) && entityReference != null)
        entityValue = EntityLibrary.GetEntityName(crmService, entityReference, false);
      return entityValue;
    }

    public static string GetEntityValue(
      IOrganizationService crmService,
      string optionSetName,
      OptionSetValue baseValue,
      OptionSetValue preImageValue)
    {
      OptionSetValue optionSetValue = baseValue != null ? baseValue : preImageValue;
      return FormatLibrary.GetFormatValue(crmService, optionSetName, optionSetValue);
    }

    public static string GetEntityValueOptionSet(
      IOrganizationService crmService,
      EntityBase entityBase,
      string optionSetName,
      string propertyName)
    {
      string empty = string.Empty;
      Entity entityFromPreImage = entityBase.GetEntityFromPreImage<Entity>();
      Entity inputEntity = entityBase.GetInputEntity<Entity>();
      OptionSetValue optionSetValue = (OptionSetValue) null;
      if (inputEntity != null && ((DataCollection<string, object>) inputEntity.Attributes).Contains(propertyName))
        optionSetValue = (OptionSetValue) inputEntity[propertyName];
      else if (entityFromPreImage != null && ((DataCollection<string, object>) entityFromPreImage.Attributes).Contains(propertyName))
        optionSetValue = (OptionSetValue) entityFromPreImage[propertyName];
      return FormatLibrary.GetFormatValue(crmService, optionSetName, optionSetValue);
    }

    public static string GetFormatValue(Money value)
    {
      string formatValue = "$0.00";
      if (value != null)
        formatValue = value.Value.ToString("C");
      return formatValue;
    }

    public static string GetFormatValue(int? value)
    {
      string empty = string.Empty;
      if (value.HasValue)
        empty = value.Value.ToString();
      return empty;
    }

    public static string GetFormatValue(DateTime? value)
    {
      string empty = string.Empty;
      if (value.HasValue && value.HasValue)
        empty = value.Value.ToString("MM/dd/yyyy");
      return empty;
    }

    public static string GetFormatValue(
      IOrganizationService crmService,
      string optionSetName,
      OptionSetValue value)
    {
      string formatValue = string.Empty;
      if (value != null)
        formatValue = MetadataLibrary.GetOptionSetText(crmService, optionSetName, value.Value);
      return formatValue;
    }

    public static EntityReference GetImageValue(
      EntityReference baseValue,
      EntityReference preImageValue)
    {
      return baseValue == null && preImageValue == null ? (EntityReference) null : (baseValue != null ? baseValue : preImageValue);
    }

    public static OptionSetValue GetImageValue(
      OptionSetValue baseValue,
      OptionSetValue preImageValue)
    {
      return baseValue == null && preImageValue == null ? (OptionSetValue) null : (baseValue != null ? baseValue : preImageValue);
    }

    public static DateTime? GetImageValue(DateTime? baseValue, DateTime? preImageValue)
    {
      return !baseValue.HasValue && !preImageValue.HasValue ? new DateTime?() : new DateTime?(baseValue.HasValue ? baseValue.Value : preImageValue.Value);
    }

    public static object GetImageValue(string attributeName, EntityBase entityBase)
    {
      object imageValue = (object) null;
      Entity entityFromPreImage = entityBase.GetEntityFromPreImage<Entity>();
      Entity inputEntity = entityBase.GetInputEntity<Entity>();
      if (inputEntity != null && ((DataCollection<string, object>) inputEntity.Attributes).Contains(attributeName))
        imageValue = ((DataCollection<string, object>) inputEntity.Attributes)[attributeName];
      else if (entityFromPreImage != null && ((DataCollection<string, object>) entityFromPreImage.Attributes).Contains(attributeName))
        imageValue = ((DataCollection<string, object>) entityFromPreImage.Attributes)[attributeName];
      return imageValue;
    }
  }
}
