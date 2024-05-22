// Decompiled with JetBrains decompiler
// Type: ArcticIT.CrmFramework.Workflow.WorkflowBase
// Assembly: TPFamilyWellness.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: C0DF2365-4BFC-418D-B654-2FF4D2B8EB1A
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPFamilyWellnessFrameworkPlugIn-A0924F88-EA00-EA11-A82D-000D3A1F0599\TPFamilyWellnessFrameworkPlugIn.dll

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
