// Decompiled with JetBrains decompiler
// Type: ArcticIT.CrmFramework.Libraries.AddressLibrary
// Assembly: TPFamilyWellness.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: C0DF2365-4BFC-418D-B654-2FF4D2B8EB1A
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPFamilyWellnessFrameworkPlugIn-A0924F88-EA00-EA11-A82D-000D3A1F0599\TPFamilyWellnessFrameworkPlugIn.dll

using System;
using System.Text.RegularExpressions;

#nullable disable
namespace ArcticIT.CrmFramework.Libraries
{
  public static class AddressLibrary
  {
    public static string FormatAddress(
      string street1,
      string street2,
      string street3,
      string city,
      string state,
      string zip,
      string zipExtension,
      string country)
    {
      return string.Format("{0}{1}{2}{3}{4}{5}{6}", (object) (!string.IsNullOrWhiteSpace(street1) ? street1 + Environment.NewLine : string.Empty), (object) (!string.IsNullOrWhiteSpace(street2) ? street2 + Environment.NewLine : string.Empty), (object) (!string.IsNullOrWhiteSpace(street3) ? street3 + Environment.NewLine : string.Empty), (object) (!string.IsNullOrWhiteSpace(city) ? city + ", " : string.Empty), (object) (state + "   "), (object) ((!string.IsNullOrWhiteSpace(zip) ? zip : string.Empty) + (!string.IsNullOrWhiteSpace(zipExtension) ? "-" + zipExtension : string.Empty)), (object) (!string.IsNullOrWhiteSpace(country) ? Environment.NewLine + country : string.Empty));
    }

    public static string FormatPhoneNumber(string phoneNum)
    {
      return AddressLibrary.FormatPhoneNumber(phoneNum, string.Empty);
    }

    public static string FormatPhoneNumber(string phoneNum, string phoneFormat)
    {
      if (string.IsNullOrEmpty(phoneNum))
        return phoneNum;
      if (phoneFormat == "")
        phoneFormat = "(###) ###-####";
      phoneNum = new Regex("[^\\d]").Replace(phoneNum, "");
      if (phoneNum.Length == 10)
        phoneNum = Convert.ToInt64(phoneNum).ToString(phoneFormat);
      return phoneNum;
    }
  }
}
