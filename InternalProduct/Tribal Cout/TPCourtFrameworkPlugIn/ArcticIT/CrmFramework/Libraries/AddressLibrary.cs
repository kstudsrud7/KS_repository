// Decompiled with JetBrains decompiler
// Type: ArcticIT.CrmFramework.Libraries.AddressLibrary
// Assembly: TPCourt.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: 615270E2-97DB-4878-8B8F-88925A0FA667
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPCourtFrameworkPlugIn-41F62F3A-2F19-44F2-86DD-4C4AA2D959EF\TPCourtFrameworkPlugIn.dll

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
