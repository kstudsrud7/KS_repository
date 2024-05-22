// Decompiled with JetBrains decompiler
// Type: ArcticIT.CrmFramework.Libraries.AutoNumberLibrary
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using ArcticIT.EarlyBound.Entities;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;

#nullable disable
namespace ArcticIT.CrmFramework.Libraries
{
  internal class AutoNumberLibrary
  {
    private static object syncRoot = new object();

    public static string GetNextFormattedValue(
      FrameworkService frameworkService,
      string entityLogicalName,
      string attributeName)
    {
      return AutoNumberLibrary.GetNextFormattedValue(frameworkService, entityLogicalName, attributeName, (string) null);
    }

    public static string GetNextFormattedValue(
      FrameworkService frameworkService,
      string entityLogicalName,
      string attributeName,
      string category)
    {
      string empty1 = string.Empty;
      int num = AutoNumberLibrary.RetrieveAndIncrementValue(frameworkService, entityLogicalName, attributeName, category);
      string empty2 = string.Empty;
      ait_autonumber numberConfiguration = AutoNumberLibrary.GetAutoNumberConfiguration(frameworkService, entityLogicalName, attributeName, category);
      string str1 = string.IsNullOrEmpty(numberConfiguration.ait_valueformat) ? num.ToString() : num.ToString(numberConfiguration.ait_valueformat);
      string str2 = string.Empty;
      string str3 = string.Empty;
      if (!string.IsNullOrEmpty(numberConfiguration.ait_prefix))
        str2 = numberConfiguration.ait_prefix;
      if (!string.IsNullOrEmpty(numberConfiguration.ait_postfix))
        str3 = numberConfiguration.ait_postfix;
      return string.Format("{0}{1}{2}", (object) str2, (object) str1, (object) str3);
    }

    private static ait_autonumber GetAutoNumberConfiguration(
      FrameworkService frameworkService,
      string entityLogicalName,
      string attributeName,
      string category)
    {
      return AutoNumberLibrary.RetrieveAutoNumberEntity(frameworkService, entityLogicalName, attributeName, category);
    }

    private static ait_autonumber RetrieveAutoNumberEntity(
      FrameworkService frameworkService,
      string entityLogicalName,
      string attributeName,
      string category)
    {
      FrameworkService crmService = frameworkService.Impersonate();
      ait_autonumber aitAutonumber = (ait_autonumber) null;
      List<ConditionExpression> conditions = new List<ConditionExpression>();
      conditions.Add(new ConditionExpression("ait_entitylogicalname", (ConditionOperator) 0, (object) entityLogicalName));
      conditions.Add(new ConditionExpression("ait_attributename", (ConditionOperator) 0, (object) attributeName));
      if (category == null)
        conditions.Add(new ConditionExpression("ait_category", (ConditionOperator) 12));
      else
        conditions.Add(new ConditionExpression("ait_category", (ConditionOperator) 0, (object) category));
      EntityCollection allEntities = EntityLibrary.GetAllEntities((IOrganizationService) crmService, "ait_autonumber", conditions, true);
      if (allEntities == null || ((Collection<Entity>) allEntities.Entities).Count == 0)
        string.Format("Autonumber not found for {0}.{1}", (object) entityLogicalName, (object) attributeName);
      else
        aitAutonumber = (ait_autonumber) ((Collection<Entity>) allEntities.Entities)[0];
      return aitAutonumber;
    }

    private static int RetrieveAndIncrementValue(
      FrameworkService frameworkService,
      string entityLogicalName,
      string attributeName,
      string category)
    {
      FrameworkService frameworkService1 = frameworkService.Impersonate();
      int num1;
      lock (AutoNumberLibrary.syncRoot)
      {
        ait_autonumber currentEntity = AutoNumberLibrary.RetrieveAutoNumberEntity(frameworkService, entityLogicalName, attributeName, category);
        ait_autonumber aitAutonumber;
        if (currentEntity == null)
        {
          currentEntity = AutoNumberLibrary.CreateDefault(frameworkService, entityLogicalName, attributeName, category);
          aitAutonumber = currentEntity;
        }
        else
        {
          AutoNumberLibrary.LockEntity(frameworkService, currentEntity);
          aitAutonumber = new ait_autonumber();
          ((Entity) aitAutonumber).Id = ((Entity) currentEntity).Id;
        }
        int? nullable = currentEntity != null ? currentEntity.ait_value : throw new InvalidPluginExecutionException(string.Format("Autonumber not found for {0}.{1}", (object) entityLogicalName, (object) attributeName));
        int num2;
        if (nullable.HasValue)
        {
          nullable = currentEntity.ait_value;
          num2 = nullable.HasValue ? 1 : 0;
        }
        else
          num2 = 0;
        if (num2 != 0)
        {
          nullable = currentEntity.ait_value;
          num1 = nullable.Value;
        }
        else
          num1 = 0;
        if (AutoNumberLibrary.ShouldResetNumber(currentEntity))
          num1 = 0;
        ++num1;
        aitAutonumber.ait_value = new int?(num1);
        aitAutonumber.ait_valuechanged = new DateTime?(DateTime.Now);
        frameworkService1.Update((Entity) aitAutonumber);
      }
      return num1;
    }

    private static void LockEntity(FrameworkService frameworkService, ait_autonumber currentEntity)
    {
      if (currentEntity == null)
        return;
      ait_autonumber aitAutonumber = new ait_autonumber();
      ((Entity) aitAutonumber).Id = ((Entity) currentEntity).Id;
      aitAutonumber.ait_lockfield = string.Format("{0}::{1}", (object) DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss.fff tt"), (object) ((IExecutionContext) frameworkService.PluginContext).UserId.ToString());
      frameworkService.Impersonate().Update((Entity) aitAutonumber);
    }

    private static bool ShouldResetNumber(ait_autonumber currentEntity)
    {
      bool flag = false;
      if (currentEntity != null && currentEntity.ait_numberreset != null && currentEntity.ait_valuechanged.HasValue && currentEntity.ait_valuechanged.HasValue)
      {
        DateTime now = DateTime.Now;
        int year1 = CultureInfo.InvariantCulture.Calendar.GetYear(now);
        int month1 = CultureInfo.InvariantCulture.Calendar.GetMonth(now);
        int weekOfYear1 = CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(now, CalendarWeekRule.FirstDay, DayOfWeek.Monday);
        int dayOfYear1 = CultureInfo.InvariantCulture.Calendar.GetDayOfYear(now);
        DateTime time = currentEntity.ait_valuechanged.Value;
        int year2 = CultureInfo.InvariantCulture.Calendar.GetYear(time);
        int month2 = CultureInfo.InvariantCulture.Calendar.GetMonth(time);
        int weekOfYear2 = CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstDay, DayOfWeek.Monday);
        int dayOfYear2 = CultureInfo.InvariantCulture.Calendar.GetDayOfYear(time);
        switch (currentEntity.ait_numberreset.Value)
        {
          case 750000000:
            flag = dayOfYear1 != dayOfYear2;
            break;
          case 750000001:
            flag = weekOfYear1 != weekOfYear2;
            break;
          case 750000002:
            flag = month1 != month2;
            break;
          case 750000003:
            flag = year1 != year2;
            break;
        }
      }
      return flag;
    }

    private static ait_autonumber CreateDefault(
      FrameworkService frameworkService,
      string entityLogicalName,
      string attributeName,
      string category)
    {
      FrameworkService frameworkService1 = frameworkService.Impersonate();
      ait_autonumber aitAutonumber = new ait_autonumber();
      aitAutonumber.ait_entitylogicalname = entityLogicalName;
      aitAutonumber.ait_attributename = attributeName;
      aitAutonumber.ait_valueformat = "00000";
      ((Entity) aitAutonumber).Id = frameworkService1.Create((Entity) aitAutonumber);
      aitAutonumber.ait_category = category;
      return aitAutonumber;
    }
  }
}
