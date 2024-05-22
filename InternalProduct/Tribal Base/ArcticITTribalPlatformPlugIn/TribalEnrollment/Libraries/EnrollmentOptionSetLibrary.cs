// Decompiled with JetBrains decompiler
// Type: ArcticIT.TribalEnrollment.Libraries.EnrollmentOptionSetLibrary
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using Microsoft.Xrm.Sdk;

#nullable disable
namespace ArcticIT.TribalEnrollment.Libraries
{
  internal class EnrollmentOptionSetLibrary
  {
    public static int? YesNoValue(bool? value)
    {
      int? nullable = new int?();
      if (value.HasValue && value.HasValue)
        nullable = EnrollmentOptionSetLibrary.YesNoValue(value.Value);
      return nullable;
    }

    public static int? YesNoValue(bool value) => new int?(value ? 750000001 : 750000000);

    public static OptionSetValue YesNoOptionSet(bool? value)
    {
      OptionSetValue optionSetValue = (OptionSetValue) null;
      int? nullable = EnrollmentOptionSetLibrary.YesNoValue(value);
      if (nullable.HasValue && nullable.HasValue)
        optionSetValue = new OptionSetValue(nullable.Value);
      return optionSetValue;
    }

    public static OptionSetValue YesNoOptionSet(bool value)
    {
      return EnrollmentOptionSetLibrary.YesNoOptionSet(new bool?(value));
    }
  }
}
