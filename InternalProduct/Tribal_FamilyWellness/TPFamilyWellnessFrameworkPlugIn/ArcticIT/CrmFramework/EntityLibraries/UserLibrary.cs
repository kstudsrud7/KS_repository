// Decompiled with JetBrains decompiler
// Type: ArcticIT.CrmFramework.EntityLibraries.UserLibrary
// Assembly: TPFamilyWellness.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: C0DF2365-4BFC-418D-B654-2FF4D2B8EB1A
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPFamilyWellnessFrameworkPlugIn-A0924F88-EA00-EA11-A82D-000D3A1F0599\TPFamilyWellnessFrameworkPlugIn.dll

using ArcticIT.CrmFramework.Libraries;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using TPFamilyWellness.EarlyBound;

#nullable disable
namespace ArcticIT.CrmFramework.EntityLibraries
{
  internal class UserLibrary
  {
    public static UserSettings GetUserSettings(IOrganizationService crmService)
    {
      UserSettings userSettings = (UserSettings) null;
      EntityCollection allEntities = EntityLibrary.GetAllEntities(crmService, "usersettings", new List<ConditionExpression>()
      {
        new ConditionExpression("systemuserid", (ConditionOperator) 41)
      }, false);
      if (allEntities != null && ((Collection<Entity>) allEntities.Entities).Count > 0)
        userSettings = (UserSettings) allEntities[0];
      return userSettings;
    }

    public static DateTime? LocalTime(IOrganizationService crmService)
    {
      DateTime? nullable = new DateTime?(DateTime.Now);
      UserSettings userSettings = UserLibrary.GetUserSettings(crmService);
      int? timeZoneCode;
      int num;
      if (userSettings != null)
      {
        timeZoneCode = userSettings.TimeZoneCode;
        num = timeZoneCode.HasValue ? 1 : 0;
      }
      else
        num = 0;
      if (num != 0)
      {
        ref DateTime? local = ref nullable;
        IOrganizationService crmService1 = crmService;
        DateTime utcNow = DateTime.UtcNow;
        timeZoneCode = userSettings.TimeZoneCode;
        int localTimeZoneCode = timeZoneCode.Value;
        DateTime dateTime = UserLibrary.RetrieveLocalTimeFromUTCTime(crmService1, utcNow, localTimeZoneCode);
        local = new DateTime?(dateTime);
      }
      return nullable;
    }

    private static DateTime RetrieveLocalTimeFromUTCTime(
      IOrganizationService crmService,
      DateTime utcTime,
      int localTimeZoneCode)
    {
      LocalTimeFromUtcTimeRequest fromUtcTimeRequest = new LocalTimeFromUtcTimeRequest()
      {
        TimeZoneCode = localTimeZoneCode,
        UtcTime = utcTime.ToUniversalTime()
      };
      return ((LocalTimeFromUtcTimeResponse) crmService.Execute((OrganizationRequest) fromUtcTimeRequest)).LocalTime;
    }
  }
}
