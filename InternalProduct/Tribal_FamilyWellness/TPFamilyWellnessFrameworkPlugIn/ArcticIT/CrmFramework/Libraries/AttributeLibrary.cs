// Decompiled with JetBrains decompiler
// Type: ArcticIT.CrmFramework.Libraries.AttributeLibrary
// Assembly: TPFamilyWellness.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: C0DF2365-4BFC-418D-B654-2FF4D2B8EB1A
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPFamilyWellnessFrameworkPlugIn-A0924F88-EA00-EA11-A82D-000D3A1F0599\TPFamilyWellnessFrameworkPlugIn.dll

using Microsoft.Xrm.Sdk;
using System;
using System.Globalization;

#nullable disable
namespace ArcticIT.CrmFramework.Libraries
{
  public static class AttributeLibrary
  {
    public static bool Compare(object original, object compareTo)
    {
      if (original == null && compareTo == null)
        return true;
      if (original != null && compareTo == null || original == null && compareTo != null)
        return false;
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

    public static bool Compare(Entity original, Entity compareTo)
    {
      if (original == null && compareTo == null)
        return true;
      return (original == null || compareTo != null) && (original != null || compareTo == null) && AttributeLibrary.Compare(original.ToEntityReference(), compareTo.ToEntityReference());
    }

    public static bool Compare(DateTime? original, DateTime compareTo)
    {
      return original.HasValue && original.Value == compareTo;
    }

    public static bool Compare(DateTime? original, DateTime? compareTo)
    {
      if (!original.HasValue && !compareTo.HasValue)
        return true;
      if (original.HasValue && !compareTo.HasValue || !original.HasValue && compareTo.HasValue)
        return false;
      DateTime dateTime = original.Value;
      DateTime universalTime1 = dateTime.ToUniversalTime();
      dateTime = compareTo.Value;
      DateTime universalTime2 = dateTime.ToUniversalTime();
      return universalTime1 == universalTime2;
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

    public static bool Compare(string original, string compareTo)
    {
      if (string.IsNullOrEmpty(original) && string.IsNullOrEmpty(compareTo))
        return true;
      return (string.IsNullOrEmpty(original) || !string.IsNullOrEmpty(compareTo)) && (!string.IsNullOrEmpty(original) || string.IsNullOrEmpty(compareTo)) && original == compareTo;
    }

    public static bool GetValue(bool? value)
    {
      bool flag = false;
      if (value.HasValue && value.HasValue)
        flag = value.Value;
      return flag;
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

    public static Money MoneyMultiply(Money money1, Decimal value2)
    {
      Money money = (Money) null;
      if (money1 != null)
        money = new Money(money1.Value * value2);
      return money;
    }

    public static Money MoneyMultiply(Money money1, Money money2)
    {
      Money money = (Money) null;
      if (money1 != null && money2 != null)
        money = new Money(money1.Value * money2.Value);
      return money;
    }

    public static Money MoneyPlus(Money money1, Money money2)
    {
      return money1 != null || money2 == null ? (money1 == null || money2 != null ? new Money(money1.Value + money2.Value) : money1) : money2;
    }

    public static Money MoneyMinus(Money money1, Money money2)
    {
      return money1 != null || money2 == null ? (money1 == null || money2 != null ? new Money(money1.Value - money2.Value) : money1) : new Money(money2.Value * -1M);
    }

    public static DateTime? DatePlus(DateTime? dateTime, int years, int months, int days)
    {
      if (!dateTime.HasValue || !dateTime.HasValue)
        return new DateTime?();
      DateTime dateTime1 = dateTime.Value;
      dateTime1 = dateTime1.AddYears(years);
      dateTime1 = dateTime1.AddMonths(months);
      dateTime1 = dateTime1.AddDays((double) days);
      return new DateTime?(dateTime1);
    }

    public static void UpdateCalendarFields(
      Entity entity,
      DateTime? dateToUpdate,
      string dayOfYearField,
      string weekOfYearField,
      string monthOfYearField,
      string quarterOfYearField,
      string yearField)
    {
      int? nullable1 = new int?();
      int? nullable2 = new int?();
      int? nullable3 = new int?();
      int? nullable4 = new int?();
      int? nullable5 = new int?();
      if (dateToUpdate.HasValue && dateToUpdate.HasValue)
      {
        DateTime time = dateToUpdate.Value;
        nullable1 = new int?(time.Day);
        nullable2 = new int?(DateTimeFormatInfo.CurrentInfo.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstDay, DayOfWeek.Monday));
        nullable3 = new int?(time.Month);
        nullable4 = new int?((int) Math.Ceiling((double) (nullable3.Value / 3)) + 1);
        nullable5 = new int?(time.Year);
      }
      if (!string.IsNullOrEmpty(dayOfYearField))
        entity[dayOfYearField] = (object) nullable1;
      if (!string.IsNullOrEmpty(weekOfYearField))
        entity[weekOfYearField] = (object) nullable2;
      if (!string.IsNullOrEmpty(monthOfYearField))
        entity[monthOfYearField] = (object) AttributeLibrary.GetOptionSetValue(nullable3);
      if (!string.IsNullOrEmpty(quarterOfYearField))
        entity[quarterOfYearField] = (object) AttributeLibrary.GetOptionSetValue(nullable4);
      if (string.IsNullOrEmpty(yearField))
        return;
      entity[yearField] = (object) nullable5.ToString();
    }

    private static OptionSetValue GetOptionSetValue(int? value)
    {
      OptionSetValue optionSetValue = (OptionSetValue) null;
      if (value.HasValue && value.HasValue)
        optionSetValue = new OptionSetValue(value.Value);
      return optionSetValue;
    }
  }
}
