// Decompiled with JetBrains decompiler
// Type: ArcticIT.CrmFramework.Workflow.WorkflowBase
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using ArcticIT.CrmFramework.Libraries;
using ArcticIT.CrmFramework.Plugins;
using Microsoft.Xrm.Sdk.Workflow;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

#nullable disable
namespace ArcticIT.CrmFramework.Workflow
{
  public abstract class WorkflowBase : CodeActivity
  {
    protected virtual void Execute(FrameworkService crmService)
    {
      throw new NotImplementedException("WorkflowBase.Execute(FrameworkService crmService) - Not Implementd");
    }

    protected override void Execute(CodeActivityContext context)
    {
      FrameworkService frameworkService = new FrameworkService(context);
      TracingLibrary.Trace(frameworkService, (EntityBase) null);
      this.WriteArguments(frameworkService, typeof (InputAttribute));
      try
      {
        this.Execute(frameworkService);
      }
      catch (Exception ex)
      {
        TracingLibrary.Trace(frameworkService, ex, "Uncaught exception");
        throw;
      }
      this.WriteArguments(frameworkService, typeof (OutputAttribute));
      FrameworkLog.WriteEntry(frameworkService);
    }

    private void WriteArguments(FrameworkService frameworkService, Type argumentType)
    {
      foreach (PropertyInfo propertyInfo in ((IEnumerable<PropertyInfo>) this.GetType().GetProperties()).Select(p => new
      {
        p = p,
        attrs = p.GetCustomAttributes(argumentType, true)
      }).Where(_param1 => _param1.attrs.Length != 0).Select(_param1 => _param1.p))
      {
        object obj = propertyInfo.GetValue((object) this, (object[]) null);
        if (obj is InArgument)
          frameworkService.Trace(propertyInfo.Name, (InArgument) obj);
        else if (obj is OutArgument)
          frameworkService.Trace(propertyInfo.Name, (OutArgument) obj);
      }
    }
  }
}
