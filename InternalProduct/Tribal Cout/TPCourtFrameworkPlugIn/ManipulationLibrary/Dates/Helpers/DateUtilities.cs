// Decompiled with JetBrains decompiler
// Type: ManipulationLibrary.Dates.Helpers.DateUtilities
// Assembly: TPCourt.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: 615270E2-97DB-4878-8B8F-88925A0FA667
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPCourtFrameworkPlugIn-41F62F3A-2F19-44F2-86DD-4C4AA2D959EF\TPCourtFrameworkPlugIn.dll

using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Workflow;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

#nullable disable
namespace ManipulationLibrary.Dates.Helpers
{
  [Serializable]
  public class DateUtilities
  {
    public static DateTime FindDateXBizDays(
      EntityCollection calRules,
      DateTime startDate,
      int days,
      Operations operation)
    {
      TimeSpan timeSpan = new TimeSpan(1, 0, 0, 0);
      DateTime date = new DateTime();
      if (startDate != DateTime.MinValue)
        date = startDate;
      while (days > 0)
      {
        date = operation == Operations.Add ? date.Add(timeSpan) : date.Subtract(timeSpan);
        if (DateUtilities.IsBusinessDay(calRules, date))
          --days;
      }
      return date;
    }

    public static EntityCollection GetRules(CodeActivityContext executionContext)
    {
      IWorkflowContext extension = executionContext.GetExtension<IWorkflowContext>();
      return DateUtilities.GetRules(executionContext.GetExtension<IOrganizationServiceFactory>().CreateOrganizationService(new Guid?(((IExecutionContext) extension).UserId)), ((IExecutionContext) extension).OrganizationId);
    }

    public static EntityCollection GetRules(IOrganizationService service, Guid orgId)
    {
      if (service == null)
        return (EntityCollection) null;
      QueryExpression queryExpression1 = new QueryExpression();
      queryExpression1.EntityName = "calendar";
      queryExpression1.ColumnSet = new ColumnSet()
      {
        AllColumns = true
      };
      Collection<LinkEntity> linkEntities = (Collection<LinkEntity>) queryExpression1.LinkEntities;
      LinkEntity linkEntity1 = new LinkEntity();
      linkEntity1.LinkFromEntityName = "calendar";
      linkEntity1.LinkToEntityName = "organization";
      linkEntity1.LinkFromAttributeName = "calendarid";
      linkEntity1.LinkToAttributeName = "businessclosurecalendarid";
      LinkEntity linkEntity2 = linkEntity1;
      FilterExpression filterExpression = new FilterExpression();
      filterExpression.FilterOperator = (LogicalOperator) 0;
      Collection<ConditionExpression> conditions = (Collection<ConditionExpression>) filterExpression.Conditions;
      ConditionExpression conditionExpression = new ConditionExpression();
      conditionExpression.AttributeName = "organizationid";
      conditionExpression.Operator = (ConditionOperator) 0;
      ((Collection<object>) conditionExpression.Values).Add((object) orgId);
      conditions.Add(conditionExpression);
      linkEntity2.LinkCriteria = filterExpression;
      linkEntities.Add(linkEntity1);
      queryExpression1.PageInfo = new PagingInfo()
      {
        Count = 1,
        PageNumber = 1
      };
      QueryExpression queryExpression2 = queryExpression1;
      DataCollection<Entity> entities = service.RetrieveMultiple((QueryBase) queryExpression2).Entities;
      return ((Collection<Entity>) entities).Count != 0 ? (EntityCollection) ((DataCollection<string, object>) ((Collection<Entity>) entities)[0].Attributes)["calendarrules"] : (EntityCollection) null;
    }

    public static bool IsClosed(EntityCollection calRules, DateTime date)
    {
      return ((Collection<Entity>) calRules.Entities).Count != 0 && ((IEnumerable<Entity>) calRules.Entities).Select(rule => new
      {
        rule = rule,
        start = (DateTime) ((DataCollection<string, object>) rule.Attributes)["effectiveintervalstart"]
      }).Select(_param1 => new
      {
        \u003C\u003Eh__TransparentIdentifier0 = _param1,
        end = (DateTime) ((DataCollection<string, object>) _param1.rule.Attributes)["effectiveintervalend"]
      }).Where(_param1 => date >= _param1.\u003C\u003Eh__TransparentIdentifier0.start && date <= _param1.end).Select(_param1 => _param1.\u003C\u003Eh__TransparentIdentifier0.start).Any<DateTime>();
    }

    public static DateTime ModifyDateTime(
      EntityCollection calRules,
      bool checkLastDayOnly,
      DateTime date,
      Operations operation,
      int days,
      int hours,
      int minutes)
    {
      if (days != 0)
      {
        if (!checkLastDayOnly)
        {
          date = DateUtilities.FindDateXBizDays(calRules, date, days, operation);
        }
        else
        {
          date = date.AddDays((double) ((operation == Operations.Add ? 1 : -1) * days - 1));
          date = DateUtilities.FindDateXBizDays(calRules, date, 1, operation);
        }
      }
      DateTime startDate = date.AddHours((double) hours);
      startDate = startDate.AddMinutes((double) minutes);
      date = startDate;
      if (date.Hour > 18)
      {
        startDate = new DateTime(startDate.Year, startDate.Month, startDate.Day, operation == Operations.Add ? 8 : 18, 0, 0);
        date = DateUtilities.FindDateXBizDays(calRules, startDate, 1, operation);
      }
      else if (date.Hour < 8)
      {
        startDate = new DateTime(startDate.Year, startDate.Month, startDate.Day, operation == Operations.Add ? 8 : 18, 0, 0);
        date = startDate;
      }
      return date;
    }

    private static bool IsBusinessDay(EntityCollection calRules, DateTime date)
    {
      int num;
      switch (date.DayOfWeek)
      {
        case DayOfWeek.Sunday:
        case DayOfWeek.Saturday:
          num = 0;
          break;
        default:
          num = !DateUtilities.IsClosed(calRules, date) ? 1 : 0;
          break;
      }
      return num != 0;
    }
  }
}
