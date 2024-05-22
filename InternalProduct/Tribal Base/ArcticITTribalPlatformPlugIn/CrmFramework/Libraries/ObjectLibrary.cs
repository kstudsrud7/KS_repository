// Decompiled with JetBrains decompiler
// Type: ArcticIT.CrmFramework.Libraries.ObjectLibrary
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

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
      string propertyName = string.Empty;
      PropertyInfo propertyInfo = (PropertyInfo) null;
      if ((PropertyInfo) null == propertyInfo)
        propertyInfo = obj.GetType().GetProperty("Title");
      if ((PropertyInfo) null == propertyInfo)
        propertyInfo = obj.GetType().GetProperty("ait_name");
      if ((PropertyInfo) null == propertyInfo)
        propertyInfo = obj.GetType().GetProperty("FullName");
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
      return !throwIfValueNull || obj1 != null ? obj1 : throw new PluginException("Property " + propertyName + " can not be empty.");
    }

    public static object GetPropertyValue(object obj, string propertyName)
    {
      if (obj == null)
        return (object) null;
      PropertyInfo property = obj.GetType().GetProperty(propertyName);
      return !((PropertyInfo) null == property) ? property.GetValue(obj, (object[]) null) : throw new PluginException("Property " + propertyName + " could not be found.");
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
        throw new PluginException("Property " + propertyName + " could not be found.");
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
