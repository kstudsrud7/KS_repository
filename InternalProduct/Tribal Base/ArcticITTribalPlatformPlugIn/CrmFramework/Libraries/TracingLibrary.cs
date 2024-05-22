// Decompiled with JetBrains decompiler
// Type: ArcticIT.CrmFramework.Libraries.TracingLibrary
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using ArcticIT.CrmFramework.Plugins;
using Microsoft.Xrm.Sdk;
using System;

#nullable disable
namespace ArcticIT.CrmFramework.Libraries
{
  public static class TracingLibrary
  {
    public static void Trace(FrameworkService frameworkService, Exception ex, string message)
    {
      string message1 = string.Format("{0} | Exception: {1} | {2} | {3}{4}", (object) message, (object) ex.GetType(), (object) ex.Message, (object) Environment.NewLine, (object) ex.StackTrace);
      TracingLibrary.Trace(frameworkService, message1);
    }

    public static void Trace(FrameworkService frameworkService, EntityBase entityBase)
    {
      string str = string.Empty;
      if (entityBase != null && entityBase.TargetEntityReference != null)
        str = string.Format(" | EntityName:{0}", (object) entityBase.TargetEntityReference.Name);
      if (frameworkService.PluginContext != null)
      {
        string message = string.Format("PluginContext--MessageName:{0} | PrimaryEntityType:{1}{2} | Depth:{3} | UserId:{4}", (object) ((IExecutionContext) frameworkService.PluginContext).MessageName, (object) ((IExecutionContext) frameworkService.PluginContext).PrimaryEntityName, (object) str, (object) ((IExecutionContext) frameworkService.PluginContext).Depth, (object) ((IExecutionContext) frameworkService.PluginContext).UserId);
        TracingLibrary.Trace(frameworkService, message);
      }
      else
      {
        if (frameworkService.WorkflowContext == null)
          return;
        string message = string.Format("WorkflowContext--MessageName:{0} | PrimaryEntityType:{1}{2} | Depth:{3} | UserId:{4}", (object) ((IExecutionContext) frameworkService.WorkflowContext).MessageName, (object) ((IExecutionContext) frameworkService.WorkflowContext).PrimaryEntityName, (object) str, (object) ((IExecutionContext) frameworkService.WorkflowContext).Depth, (object) ((IExecutionContext) frameworkService.WorkflowContext).UserId);
        TracingLibrary.Trace(frameworkService, message);
      }
    }

    public static void Trace(IServiceProvider serviceProvider, string message)
    {
      TracingLibrary.Trace(new FrameworkService(serviceProvider), message);
    }

    public static void Trace(FrameworkService frameworkService, string message)
    {
      frameworkService.Trace(message);
    }
  }
}
