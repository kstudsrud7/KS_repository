// Decompiled with JetBrains decompiler
// Type: ArcticIT.CrmFramework.Libraries.TracingLibrary
// Assembly: TPFamilyWellness.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: C0DF2365-4BFC-418D-B654-2FF4D2B8EB1A
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPFamilyWellnessFrameworkPlugIn-A0924F88-EA00-EA11-A82D-000D3A1F0599\TPFamilyWellnessFrameworkPlugIn.dll

using ArcticIT.CrmFramework.Plugins;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

#nullable disable
namespace ArcticIT.CrmFramework.Libraries
{
  public static class TracingLibrary
  {
    public static void Trace(FrameworkService frameworkService, IPluginExecutionContext context)
    {
      TracingLibrary.Trace(frameworkService, ((IExecutionContext) context).PreEntityImages);
      TracingLibrary.Trace(frameworkService, ((IExecutionContext) context).PostEntityImages);
      TracingLibrary.Trace(frameworkService, ((IExecutionContext) context).InputParameters);
    }

    public static void Trace(
      FrameworkService frameworkService,
      EntityImageCollection entityImageCollection)
    {
      TracingLibrary.Trace(frameworkService, "EntityImageCollection:");
      foreach (string key in (IEnumerable<string>) ((DataCollection<string, Entity>) entityImageCollection).Keys)
      {
        string message = string.Format("Key: {0}; Value:{1}", (object) key, (object) ((DataCollection<string, Entity>) entityImageCollection)[key].ToString());
        TracingLibrary.Trace(frameworkService, message);
      }
    }

    public static void Trace(FrameworkService frameworkService, ParameterCollection parameters)
    {
      TracingLibrary.Trace(frameworkService, "ParameterCollection:");
      foreach (string key in (IEnumerable<string>) ((DataCollection<string, object>) parameters).Keys)
      {
        string message = string.Format("Key: {0}; Value:{1}", (object) key, (object) ((DataCollection<string, object>) parameters)[key].ToString());
        TracingLibrary.Trace(frameworkService, message);
      }
    }

    public static void Trace(FrameworkService frameworkService, Exception ex, string message)
    {
      string message1 = string.Format("{0} | Exception: {1} | {2} | {3}{4}", (object) message, (object) ex.GetType(), (object) ex.Message, (object) Environment.NewLine, (object) ex.StackTrace);
      TracingLibrary.Trace(frameworkService, message1);
    }

    public static void Trace(FrameworkService frameworkService, EntityBase entityBase)
    {
      string str = string.Empty;
      if (entityBase != null)
        str = string.Format(" | EntityName:{0}", (object) entityBase.GetPropertyNameValue());
      if (frameworkService.PluginContext != null)
      {
        string message = string.Format("PluginContext--MessageName:{0}({1}) | PrimaryEntityType:{2}{3} | Depth:{4} | UserId:{5}", (object) ((IExecutionContext) frameworkService.PluginContext).MessageName, (object) frameworkService.PluginContext.Stage, (object) ((IExecutionContext) frameworkService.PluginContext).PrimaryEntityName, (object) str, (object) ((IExecutionContext) frameworkService.PluginContext).Depth, (object) ((IExecutionContext) frameworkService.PluginContext).UserId);
        TracingLibrary.Trace(frameworkService, message);
      }
      else
      {
        if (frameworkService.WorkflowContext == null)
          return;
        string message = string.Format("WorkflowContext--MessageName:{0}({1}) | PrimaryEntityType:{2}{3} | Depth:{4} | UserId:{4}", (object) ((IExecutionContext) frameworkService.WorkflowContext).MessageName, (object) frameworkService.WorkflowContext.StageName, (object) ((IExecutionContext) frameworkService.WorkflowContext).PrimaryEntityName, (object) str, (object) ((IExecutionContext) frameworkService.WorkflowContext).Depth, (object) ((IExecutionContext) frameworkService.WorkflowContext).UserId);
        TracingLibrary.Trace(frameworkService, message);
      }
    }

    public static void Trace(IServiceProvider serviceProvider, string message)
    {
      TracingLibrary.Trace(new FrameworkService(serviceProvider), message);
    }

    public static void Trace(FrameworkService frameworkService, string message)
    {
      frameworkService?.Trace(message);
    }

    public static void Trace(FrameworkService frameworkService, string message, DateTime startTime)
    {
      if (frameworkService == null)
        return;
      string str = string.Format("[Elapsed Seconds: {0}", (object) DateTime.Now.Subtract(startTime).TotalSeconds);
      string format = string.Format("{0}{1}", (object) message, (object) str);
      frameworkService.Trace(format);
    }

    public static bool TraceObjectNull(
      string method,
      object parameter,
      string parameterName,
      FrameworkService frameworkService)
    {
      bool flag = parameter == null;
      if (flag)
        frameworkService.Trace("{0}: Parameter/object {1} cannot be null.", (object) method, (object) parameterName);
      return flag;
    }

    public static bool TraceObjectNull(
      object parameter,
      string parameterName,
      FrameworkService frameworkService)
    {
      bool flag = parameter == null;
      if (flag)
        frameworkService.Trace("Parameter/object {0} cannot be null.", (object) parameterName);
      return flag;
    }

    public static void TraceEntityDisplay(FrameworkService crmService, Entity entity)
    {
      TracingLibrary.TraceEntityDisplay(crmService, string.Empty, entity);
    }

    public static void TraceEntityDisplay(
      FrameworkService crmService,
      string message,
      Entity entity)
    {
      TracingLibrary.Trace(crmService, message + TracingLibrary.GetEntityDisplay(entity));
    }

    public static string GetFormatValue(EntityReference value)
    {
      string formatValue = "null";
      if (value != null)
        formatValue = string.IsNullOrEmpty(value.Name) ? value.Id.ToString() : value.Name;
      return formatValue;
    }

    public static string GetFormatValue(OptionSetValue value)
    {
      string formatValue = "null";
      if (value != null)
        formatValue = value.Value.ToString();
      return formatValue;
    }

    public static string GetFormatValue(Money value)
    {
      string formatValue = "null";
      if (value != null)
        formatValue = value.Value.ToString("C");
      return formatValue;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DateTime? TraceMethodStart(FrameworkService crmService)
    {
      return TracingLibrary.TraceMethodStart(crmService, 2);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DateTime? TraceMethodStart(FrameworkService crmService, int frameIndex)
    {
      string methodName = TracingLibrary.GetMethodName(frameIndex);
      crmService.TracingService.Trace("Method start: {0}", new object[1]
      {
        (object) methodName
      });
      return new DateTime?(DateTime.Now);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void TraceMethodEnd(FrameworkService crmService)
    {
      TracingLibrary.TraceMethodEnd(crmService, 2);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void TraceMethodEnd(FrameworkService crmService, DateTime? startTime)
    {
      TracingLibrary.TraceMethodEnd(crmService, startTime, 2);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void TraceMethodEnd(FrameworkService crmService, int frameIndex)
    {
      StackFrame frame = new StackTrace().GetFrame(frameIndex);
      crmService.TracingService.Trace("Method end: {0}", new object[1]
      {
        (object) frame.GetMethod().Name
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void TraceMethodEnd(
      FrameworkService crmService,
      string returnValue,
      int frameIndex)
    {
      StackFrame frame = new StackTrace().GetFrame(frameIndex);
      TracingLibrary.TraceMethodEnd(crmService, frame, returnValue, new DateTime?());
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void TraceMethodEnd(
      FrameworkService crmService,
      DateTime? startTime,
      int frameIndex)
    {
      StackFrame frame = new StackTrace().GetFrame(frameIndex);
      TracingLibrary.TraceMethodEnd(crmService, frame, (string) null, startTime);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void TraceMethodEnd(
      FrameworkService crmService,
      string returnValue,
      DateTime? startTime,
      int frameIndex)
    {
      StackFrame frame = new StackTrace().GetFrame(frameIndex);
      TracingLibrary.TraceMethodEnd(crmService, frame, returnValue, startTime);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void TraceMethodEnd(
      FrameworkService crmService,
      StackFrame sf,
      string returnValue,
      DateTime? startTime)
    {
      string str1 = string.Empty;
      if (startTime.HasValue && startTime.HasValue)
        str1 = string.Format("; Elapsed: {0}", (object) new TimeSpan((DateTime.Now - startTime.Value).Ticks).TotalSeconds);
      string str2 = string.Empty;
      if (!string.IsNullOrEmpty(returnValue))
        str2 = string.Format("; Value: {0}", (object) returnValue);
      crmService.TracingService.Trace("Method end: {0}{1}{2}", new object[3]
      {
        (object) sf.GetMethod().Name,
        (object) str2,
        (object) str1
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static string GetMethodName(int frameIndex)
    {
      return new StackTrace().GetFrame(frameIndex + 1).GetMethod().Name;
    }

    public static string GetEntityDisplay(Entity entity)
    {
      string empty = string.Empty;
      if (entity == null)
        return "EntityDump: null";
      string attributeList = TracingLibrary.GetAttributeList(entity);
      return string.Format("EntityDump: {0}({1})({2}): {3}", (object) entity.LogicalName, (object) entity.Id, (object) ((DataCollection<string, object>) entity.Attributes).Count, (object) attributeList);
    }

    public static string GetAttributeList(Entity entity)
    {
      string empty = string.Empty;
      if (entity == null || entity.Attributes == null || ((DataCollection<string, object>) entity.Attributes).Keys == null)
        return empty;
      StringBuilder stringBuilder = new StringBuilder();
      foreach (string key in (IEnumerable<string>) ((DataCollection<string, object>) entity.Attributes).Keys)
      {
        if (stringBuilder.Length > 0)
          stringBuilder.Append(",");
        stringBuilder.Append(TracingLibrary.GetAttributeDisplay(key, entity));
      }
      return stringBuilder.ToString();
    }

    public static void AddAttributeDisplay(StringBuilder attributeList, string key, Entity entity)
    {
      if (attributeList.Length > 0)
        attributeList.Append(",");
      attributeList.Append(TracingLibrary.GetAttributeDisplay(key, entity));
    }

    public static string GetAttributeDisplay(string key, Entity entity)
    {
      return TracingLibrary.GetAttributeDisplay(key, entity.Attributes);
    }

    public static string GetAttributeDisplay(string key, AttributeCollection attributeCollection)
    {
      string attributeDisplay = string.Empty;
      if (attributeCollection == null)
        return attributeDisplay;
      object attributeValue = (object) null;
      if (((DataCollection<string, object>) attributeCollection).TryGetValue(key, ref attributeValue))
        attributeDisplay = string.Format("{0}[{1}]", (object) key, (object) TracingLibrary.GetAttributeValueDisplay(attributeValue));
      return attributeDisplay;
    }

    public static string GetAttributeValueDisplay(object attributeValue)
    {
      string attributeValueDisplay1 = "null";
      string attributeValueDisplay2;
      switch (attributeValue)
      {
        case null:
          return attributeValueDisplay1;
        case Money _:
          attributeValueDisplay2 = ((Money) attributeValue).Value.ToString();
          break;
        case OptionSetValue _:
          attributeValueDisplay2 = ((OptionSetValue) attributeValue).Value.ToString();
          break;
        case EntityReference _:
          EntityReference entityReference = (EntityReference) attributeValue;
          attributeValueDisplay2 = string.Format("{0}-[{1}]-{2}", (object) entityReference.LogicalName, (object) entityReference.Id, (object) entityReference.Name);
          break;
        case DateTime? nullable:
          attributeValueDisplay2 = nullable.Value.ToUniversalTime().ToString("MM/dd/yyyy hh:mm:ss %K");
          break;
        case EntityCollection _:
          EntityCollection entityCollection = (EntityCollection) attributeValue;
          if (entityCollection != null)
          {
            int num = 0;
            if (entityCollection.Entities != null)
              num = ((Collection<Entity>) entityCollection.Entities).Count;
            attributeValueDisplay2 = string.Format("EntityCollection-{0}-{1}", (object) entityCollection.EntityName, (object) num);
            break;
          }
          attributeValueDisplay2 = "EntityCollection-null";
          break;
        default:
          attributeValueDisplay2 = attributeValue.ToString();
          break;
      }
      return attributeValueDisplay2;
    }
  }
}
