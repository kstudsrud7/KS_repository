// Decompiled with JetBrains decompiler
// Type: ArcticIT.CrmFramework.EntityLibraries.UserLibrary
// Assembly: TPCourt.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: 615270E2-97DB-4878-8B8F-88925A0FA667
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPCourtFrameworkPlugIn-41F62F3A-2F19-44F2-86DD-4C4AA2D959EF\TPCourtFrameworkPlugIn.dll

using ArcticIT.CrmFramework.Libraries;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using TPCourt.EarlyBound;

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
