// Decompiled with JetBrains decompiler
// Type: ArcticIT.TribalEnrollment.Libraries.TribalEnrollmentFormatLibrary
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using ArcticIT.CrmFramework.Libraries;
using ArcticIT.EarlyBound.Entities;
using Microsoft.Xrm.Sdk;
using System;

#nullable disable
namespace ArcticIT.TribalEnrollment.Libraries
{
  internal class TribalEnrollmentFormatLibrary
  {
    public static string FormatAddress(
      IOrganizationService crmService,
      string street1,
      string street2,
      string street3,
      EntityReference city,
      EntityReference state,
      EntityReference zip,
      string zipExtension,
      EntityReference country)
    {
      string empty = string.Empty;
      string entityName1 = EntityLibrary.GetEntityName(crmService, city, false);
      string country1 = EntityLibrary.GetEntityName(crmService, country, false);
      if (country1.ToLower() == "united states" || country1.ToLower() == "us" || country1.ToLower() == "united states of america")
        country1 = string.Empty;
      string entityName2 = EntityLibrary.GetEntityName(crmService, zip, false);
      ait_stateprovince entity = (ait_stateprovince) EntityLibrary.GetEntity(crmService, state, false);
      string state1 = entity == null || string.IsNullOrEmpty(entity.ait_abbreviation) ? EntityLibrary.GetEntityName(crmService, state, false) : entity.ait_abbreviation;
      return TribalEnrollmentFormatLibrary.FormatAddress(street1, street2, street3, entityName1, state1, entityName2, zipExtension, country1);
    }

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
      return string.Format("{0}{1}{2}{3}{4}{5}{6}", (object) (!string.IsNullOrWhiteSpace(street1) ? street1 + Environment.NewLine : ""), (object) (!string.IsNullOrWhiteSpace(street2) ? street2 + Environment.NewLine : ""), (object) (!string.IsNullOrWhiteSpace(street3) ? street3 + Environment.NewLine : ""), (object) (!string.IsNullOrWhiteSpace(city) ? city + ", " : ""), (object) (state + "   "), (object) ((!string.IsNullOrWhiteSpace(zip) ? zip : "") + (!string.IsNullOrWhiteSpace(zipExtension) ? "-" + zipExtension : "")), (object) (!string.IsNullOrWhiteSpace(country) ? Environment.NewLine + country : ""));
    }
  }
}
