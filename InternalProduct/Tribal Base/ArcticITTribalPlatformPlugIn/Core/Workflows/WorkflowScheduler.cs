// Decompiled with JetBrains decompiler
// Type: ArcticIT.Core.Workflows.WorkflowScheduler
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using Microsoft.Xrm.Sdk.Workflow;
using System;
using System.Activities;

#nullable disable
namespace ArcticIT.Core.Workflows
{
  public class WorkflowScheduler : CodeActivity
  {
    protected override void Execute(CodeActivityContext executionContext)
    {
      DateTime dateTime1 = DateTime.Today;
      dateTime1 = dateTime1.AddDays((double) this.DelayInDays.Get((ActivityContext) executionContext));
      dateTime1 = dateTime1.AddHours((double) this.HourOfDay.Get((ActivityContext) executionContext));
      DateTime dateTime2 = dateTime1.AddMinutes((double) this.MinuteOfHour.Get((ActivityContext) executionContext));
      this.RunDatetime.Set((ActivityContext) executionContext, dateTime2);
    }

    [Input("Delay in Days")]
    [Default("1")]
    public InArgument<int> DelayInDays { get; set; }

    [Input("Hour of Day")]
    [Default("1")]
    public InArgument<int> HourOfDay { get; set; }

    [Input("Minute of Hour")]
    [Default("1")]
    public InArgument<int> MinuteOfHour { get; set; }

    [Output("Run Datetime")]
    public OutArgument<DateTime> RunDatetime { get; set; }
  }
}
