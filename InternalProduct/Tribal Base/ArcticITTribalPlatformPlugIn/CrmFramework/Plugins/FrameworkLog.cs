// Decompiled with JetBrains decompiler
// Type: ArcticIT.CrmFramework.Plugins.FrameworkLog
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using ArcticIT.CrmFramework.Libraries;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Workflow;
using System;
using System.Diagnostics;

#nullable disable
namespace ArcticIT.CrmFramework.Plugins
{
  public static class FrameworkLog
  {
    public static void WriteEntry(FrameworkService service)
    {
      string eventMessage = FrameworkLog.GetEventMessage(service);
      int logId = 0;
      FrameworkLog.WriteEntry(eventMessage, EventLogEntryType.Information, logId);
      TracingLibrary.Trace(service, eventMessage);
    }

    public static void WriteEntry(EntityBase entityBase)
    {
      string eventMessage = FrameworkLog.GetEventMessage(entityBase);
      int eventLogId = FrameworkLog.GetEventLogId(entityBase.CrmService.PluginContext);
      FrameworkLog.WriteEntry(eventMessage, EventLogEntryType.Information, eventLogId);
      TracingLibrary.Trace(entityBase.CrmService, eventMessage);
    }

    public static void WriteEntry(string logMessage, EventLogEntryType entryType, int logId)
    {
    }

    public static string GetEventMessage(FrameworkService service)
    {
      string eventMessage = string.Empty;
      DateTime now = DateTime.Now;
      DateTime createTime = service.CreateTime;
      double totalSeconds = now.Subtract(createTime).TotalSeconds;
      if (service != null)
      {
        string messageCount = FrameworkLog.GetMessageCount(service);
        string messageTime = FrameworkLog.GetMessageTime(service);
        TimeSpan timeSpan = new TimeSpan(now.Subtract(createTime).Ticks) - service.TotalServiceCallTime;
        eventMessage = string.Format("Elapsed Seconds: {0}; Plugin Time: {1}; Counts:; {2}; ServiceCallTimes:; {3}", (object) totalSeconds, (object) timeSpan, (object) messageCount, (object) messageTime);
      }
      return eventMessage;
    }

    public static string GetEventMessage(EntityBase entityBase)
    {
      string message = string.Empty;
      FrameworkService crmService = entityBase.CrmService;
      DateTime now = DateTime.Now;
      DateTime createTime = entityBase.CreateTime;
      double totalSeconds = now.Subtract(createTime).TotalSeconds;
      if (crmService != null)
      {
        string messageCount = FrameworkLog.GetMessageCount(crmService);
        string messageTime = FrameworkLog.GetMessageTime(crmService);
        TimeSpan timeSpan = new TimeSpan(now.Subtract(createTime).Ticks) - crmService.TotalServiceCallTime;
        message = string.Format("Elapsed Seconds: {0}; Plugin Time: {1}; Counts:; {2}; ServiceCallTimes:; {3}", (object) totalSeconds, (object) timeSpan, (object) messageCount, (object) messageTime);
      }
      return FrameworkLog.GetEventMessage(entityBase.CrmService.PluginContext, message);
    }

    public static string GetEventMessage(IPluginExecutionContext pluginContext)
    {
      return FrameworkLog.GetEventMessage(pluginContext, string.Empty);
    }

    public static string GetEventMessage(IWorkflowContext workflowContext, string message)
    {
      string empty = string.Empty;
      string str = string.Empty;
      if (!string.IsNullOrEmpty(message))
        str = string.Format("Message: {0}", (object) message);
      return string.Format("Stage: {0}; {1}", (object) workflowContext.StageName, (object) str);
    }

    public static string GetEventMessage(IPluginExecutionContext pluginContext, string message)
    {
      string empty = string.Empty;
      string str1 = pluginContext.Stage.ToString();
      switch (pluginContext.Stage)
      {
        case 20:
          str1 += "-PRE";
          break;
        case 40:
          str1 += "-POST";
          break;
      }
      string str2 = string.Empty;
      if (!string.IsNullOrEmpty(message))
        str2 = string.Format("Message: {0}", (object) message);
      return string.Format("Name: {0}; Stage: {1}; Depth {2}; Entity: {3}; {4}", (object) ((IExecutionContext) pluginContext).MessageName, (object) str1, (object) ((IExecutionContext) pluginContext).Depth, (object) ((IExecutionContext) pluginContext).PrimaryEntityName, (object) str2);
    }

    private static string GetMessageTime(FrameworkService service)
    {
      string messageTime = string.Empty;
      if (service != null)
        messageTime = string.Format("Total: {0}; Execute: {1}; Create: {2}; Update: {3}; Delete: {4}, Retrieve: {5}; RetriveMultiple: {6}", (object) service.TotalServiceCallTime, (object) service.ExecuteExecuteTime, (object) service.ExecuteCreateTime, (object) service.ExecuteUpdateTime, (object) service.ExecuteDeleteTime, (object) service.ExecuteRetrieveTime, (object) service.ExecuteRetrieveMultipleTime);
      return messageTime;
    }

    private static string GetMessageCount(FrameworkService service)
    {
      string messageCount = string.Empty;
      if (service != null)
        messageCount = string.Format("Execute: {0}; Create: {1}; Update: {2}; Delete: {3}, Retrieve: {4}; RetriveMultiple: {5},{6}", (object) service.ExecuteExecuteCount, (object) service.ExecuteCreateCount, (object) service.ExecuteUpdateCount, (object) service.ExecuteDeleteCount, (object) service.ExecuteRetrieveCount, (object) service.ExecuteRetrieveMultipleCount, (object) service.RecordRetrieveMultipleCount);
      return messageCount;
    }

    public static int GetEventLogId(IPluginExecutionContext pluginContext)
    {
      int num = 100;
      switch (((IExecutionContext) pluginContext).MessageName.ToLower())
      {
        case "create":
          num += 100;
          break;
        case "update":
          num += 200;
          break;
        case "delete":
          num += 300;
          break;
        case "setstatedynamicentity":
          num += 400;
          break;
        case "associate":
          num += 500;
          break;
        case "disassociate":
          num += 600;
          break;
      }
      return num + pluginContext.Stage;
    }
  }
}
