// Decompiled with JetBrains decompiler
// Type: ArcticIT.CrmFramework.Libraries.AddressLibrary
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

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
