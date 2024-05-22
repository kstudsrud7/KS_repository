// Decompiled with JetBrains decompiler
// Type: ArcticIT.CrmFramework.Libraries.ObjectLibrary
// Assembly: TPCourt.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: 615270E2-97DB-4878-8B8F-88925A0FA667
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPCourtFrameworkPlugIn-41F62F3A-2F19-44F2-86DD-4C4AA2D959EF\TPCourtFrameworkPlugIn.dll

using ArcticIT.CrmFramework.Plugins;
using Microsoft.Xrm.Sdk;
using System;
using System.Reflection;

#nullable disable
namespace ArcticIT.CrmFramework.Libraries
{
  internal class ObjectLibrary
  {
    public static bool IsNullable<T>(T obj) => !typeof (T).IsValueType || (object) obj == null;

    public static bool IsNullable<T>(T? obj) where T : struct => true;

    public static bool NullableEquals<T>(T? t, T? v) where T : struct
    {
      if (!t.HasValue && !v.HasValue)
        return true;
      return (t.HasValue || !v.HasValue) && (!t.HasValue || v.HasValue) && t.Value.Equals((object) v.Value);
    }

    public static object GetNewObject(Type t)
    {
      try
      {
        return t.GetConstructor(new Type[0]).Invoke(new object[0]);
      }
      catch
      {
        return (object) null;
      }
    }

    public static string GetPropertyName(object obj, bool throwIfValueNull)
    {
      string propertyName = string.Empty;
      try
      {
        propertyName = ObjectLibrary.GetPropertyName(obj);
      }
      catch (PluginException ex)
      {
        if (throwIfValueNull)
          throw;
      }
      return propertyName;
    }

    public static string GetPropertyName(object obj)
    {
      return obj == null ? string.Empty : ObjectLibrary.GetPropertyName(obj.GetType());
    }

    public static string GetPropertyName(Type objectType)
    {
      string propertyName = string.Empty;
      if ((Type) null == objectType)
        return propertyName;
      PropertyInfo propertyInfo = (PropertyInfo) null;
      if ((PropertyInfo) null == propertyInfo)
        propertyInfo = objectType.GetProperty("Title");
      if ((PropertyInfo) null == propertyInfo)
        propertyInfo = objectType.GetProperty("bia_name");
      if ((PropertyInfo) null == propertyInfo)
        propertyInfo = objectType.GetProperty("FullName");
      if ((PropertyInfo) null != propertyInfo)
        propertyName = propertyInfo.Name;
      return propertyName;
    }

    public static object GetPropertyValue(object obj, string propertyName, bool throwIfValueNull)
    {
      object obj1 = (object) null;
      if (obj == null)
        return (object) null;
      try
      {
        obj1 = ObjectLibrary.GetPropertyValue(obj, propertyName);
      }
      catch (PluginException ex)
      {
        if (throwIfValueNull)
          throw;
      }
      return !throwIfValueNull || obj1 != null ? obj1 : throw new InvalidPluginExecutionException("Property " + propertyName + " can not be empty.");
    }

    public static object GetPropertyValue(object obj, string propertyName)
    {
      if (obj == null)
        return (object) null;
      PropertyInfo property = obj.GetType().GetProperty(propertyName);
      return !((PropertyInfo) null == property) ? property.GetValue(obj, (object[]) null) : throw new InvalidPluginExecutionException("Property " + propertyName + " could not be found.");
    }

    public static void SetPropertyValue(object obj, string propertyName, object value)
    {
      ObjectLibrary.SetPropertyValue(obj, propertyName, value, true);
    }

    public static void SetPropertyValue(
      object obj,
      string propertyName,
      object value,
      bool throwIfPropertyNotFound)
    {
      PropertyInfo property = obj.GetType().GetProperty(propertyName);
      if (throwIfPropertyNotFound && (PropertyInfo) null == property)
        throw new InvalidPluginExecutionException("Property " + propertyName + " could not be found.");
      if (!((PropertyInfo) null != property))
        return;
      property.SetValue(obj, value);
    }

    public static object GetEntityValueToUse(object baseValue, object preImageValue)
    {
      return baseValue != null ? baseValue : preImageValue;
    }

    public static object GetEntityValueToUse(
      EntityReference baseValue,
      EntityReference preImageValue)
    {
      object entityValueToUse = (object) null;
      if (baseValue != null && preImageValue != null && AttributeLibrary.Compare(baseValue, preImageValue) && (baseValue.Name != null || preImageValue.Name != null))
        entityValueToUse = baseValue.Name != null ? (object) baseValue : (object) preImageValue;
      if (entityValueToUse == null)
        entityValueToUse = baseValue != null ? (object) baseValue : (object) preImageValue;
      return entityValueToUse;
    }

    public static object GetEntityValueToUse(EntityBase entityBase, string attributeToUse)
    {
      object entityValueToUse = (object) null;
      Entity inputEntity = entityBase.GetInputEntity<Entity>();
      if (((DataCollection<string, object>) inputEntity.Attributes).ContainsKey(attributeToUse))
        entityValueToUse = ((DataCollection<string, object>) inputEntity.Attributes)[attributeToUse];
      if (entityValueToUse == null)
      {
        Entity entityFromPreImage = entityBase.GetEntityFromPreImage<Entity>();
        if (((DataCollection<string, object>) entityFromPreImage.Attributes).ContainsKey(attributeToUse))
          entityValueToUse = ((DataCollection<string, object>) entityFromPreImage.Attributes)[attributeToUse];
      }
      return entityValueToUse;
    }
  }
}
