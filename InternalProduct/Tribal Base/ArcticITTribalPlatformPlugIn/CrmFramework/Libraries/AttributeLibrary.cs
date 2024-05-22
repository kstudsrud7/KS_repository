// Decompiled with JetBrains decompiler
// Type: ArcticIT.CrmFramework.Libraries.AttributeLibrary
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using Microsoft.Xrm.Sdk;
using System;

#nullable disable
namespace ArcticIT.CrmFramework.Libraries
{
  public static class AttributeLibrary
  {
    public static bool Compare(object original, object compareTo)
    {
      bool flag;
      switch (compareTo)
      {
        case EntityReference _:
          flag = AttributeLibrary.Compare((EntityReference) original, (EntityReference) compareTo);
          break;
        case OptionSetValue _:
          OptionSetValue compareTo1 = compareTo as OptionSetValue;
          flag = AttributeLibrary.Compare((OptionSetValue) original, compareTo1);
          break;
        case Money _:
          flag = AttributeLibrary.Compare((Money) original, (Money) compareTo);
          break;
        case bool? compareTo2:
          flag = AttributeLibrary.Compare((bool?) original, compareTo2);
          break;
        case DateTime? compareTo3:
          flag = AttributeLibrary.Compare((DateTime?) original, compareTo3);
          break;
        case int? compareTo4:
          flag = AttributeLibrary.Compare((int?) original, compareTo4);
          break;
        case string _:
          flag = (string) original == (string) compareTo;
          break;
        default:
          flag = !ObjectLibrary.IsNullable<object>(compareTo) ? original == compareTo : original == compareTo;
          break;
      }
      return flag;
    }

    public static bool Compare(DateTime? original, DateTime compareTo)
    {
      return original.HasValue && original.Value == compareTo;
    }

    public static bool Compare(DateTime? original, DateTime? compareTo)
    {
      if (!original.HasValue && !compareTo.HasValue)
        return true;
      return (!original.HasValue || compareTo.HasValue) && (original.HasValue || !compareTo.HasValue) && original.Value == compareTo.Value;
    }

    public static bool Compare(int? original, int compareTo)
    {
      return original.HasValue && original.Value == compareTo;
    }

    public static bool Compare(int? original, int? compareTo)
    {
      if (!original.HasValue && !compareTo.HasValue)
        return true;
      return (!original.HasValue || compareTo.HasValue) && (original.HasValue || !compareTo.HasValue) && original.Value == compareTo.Value;
    }

    public static bool Compare(bool? original, bool compareTo)
    {
      return original.HasValue && original.Value == compareTo;
    }

    public static bool Compare(bool? original, bool? compareTo)
    {
      if (!original.HasValue && !compareTo.HasValue)
        return true;
      return (!original.HasValue || compareTo.HasValue) && (original.HasValue || !compareTo.HasValue) && original.Value == compareTo.Value;
    }

    public static bool Compare(Money original, Decimal compareTo)
    {
      return original != null && original.Value == compareTo;
    }

    public static bool Compare(Money original, Money compareTo)
    {
      if (original == null && compareTo == null)
        return true;
      return (original == null || compareTo != null) && (original != null || compareTo == null) && original.Value == compareTo.Value;
    }

    public static bool Compare(OptionSetValue original, int compareTo)
    {
      return original != null && original.Value == compareTo;
    }

    public static bool Compare(OptionSetValue original, OptionSetValue compareTo)
    {
      if (original == null && compareTo == null)
        return true;
      return (original == null || compareTo != null) && (original != null || compareTo == null) && original.Value == compareTo.Value;
    }

    public static bool Compare(EntityReference original, Entity compareTo)
    {
      if (original == null && compareTo == null)
        return true;
      return (original == null || compareTo != null) && (original != null || compareTo == null) && AttributeLibrary.Compare(original, compareTo.ToEntityReference());
    }

    public static bool Compare(EntityReference original, EntityReference compareTo)
    {
      if (original == null && compareTo == null)
        return true;
      return (original == null || compareTo != null) && (original != null || compareTo == null) && original.Id == compareTo.Id && original.LogicalName == compareTo.LogicalName;
    }

    public static int GetValue(int? value)
    {
      int num = 0;
      if (value.HasValue && value.HasValue)
        num = value.Value;
      return num;
    }

    public static Decimal GetValue(Money value)
    {
      Decimal num = 0M;
      if (value != null)
        num = value.Value;
      return num;
    }

    public static Money Plus(Money money1, Money money2)
    {
      return money1 != null || money2 == null ? (money1 == null || money2 != null ? new Money(money1.Value + money2.Value) : money1) : money2;
    }

    public static Money Minus(Money money1, Money money2)
    {
      return money1 != null || money2 == null ? (money1 == null || money2 != null ? new Money(money1.Value - money2.Value) : money1) : new Money(money2.Value * -1M);
    }

    public static bool Compare(Entity original, Entity compareTo)
    {
      if (original == null && compareTo == null)
        return true;
      return (original == null || compareTo != null) && (original != null || compareTo == null) && AttributeLibrary.Compare(original.ToEntityReference(), compareTo.ToEntityReference());
    }
  }
}
