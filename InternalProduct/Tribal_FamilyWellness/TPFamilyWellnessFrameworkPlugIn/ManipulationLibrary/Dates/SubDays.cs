// Decompiled with JetBrains decompiler
// Type: ManipulationLibrary.Dates.SubDays
// Assembly: TPFamilyWellness.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: C0DF2365-4BFC-418D-B654-2FF4D2B8EB1A
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPFamilyWellnessFrameworkPlugIn-A0924F88-EA00-EA11-A82D-000D3A1F0599\TPFamilyWellnessFrameworkPlugIn.dll

using Microsoft.Xrm.Sdk.Workflow;
using System;
using System.Activities;

#nullable disable
namespace ManipulationLibrary.Dates
{
  public sealed class SubDays : CodeActivity
  {
    [Default("1900-01-01T00:00:00Z")]
    [Output("Result")]
    public OutArgument<DateTime> Result { get; set; }

    [Default("1900-01-01T00:00:00Z")]
    [Input("Start Date")]
    public InArgument<DateTime> StartDate { get; set; }

    [Default("0")]
    [Input("Years To Subtract")]
    public InArgument<int> YearsToSubtract { get; set; }

    [Default("0")]
    [Input("Months To Subtract")]
    public InArgument<int> MonthsToSubtract { get; set; }

    [Default("0")]
    [Input("Weeks To Subtract")]
    public InArgument<int> WeeksToSubtract { get; set; }

    [Default("0")]
    [Input("Days To Subtract")]
    public InArgument<int> DaysToSubtract { get; set; }

    [Default("0")]
    [Input("Hours To Subtract")]
    public InArgument<int> HoursToSubtract { get; set; }

    [Default("0")]
    [Input("Minutes To Subtract")]
    public InArgument<int> MinutesToSubtract { get; set; }

    protected override void Execute(CodeActivityContext executionContext)
    {
      DateTime dateTime1 = new DateTime();
      DateTime dateTime2 = this.StartDate.Get<DateTime>((ActivityContext) executionContext);
      if (dateTime2 != DateTime.MinValue)
        dateTime1 = dateTime2;
      if (dateTime2 != DateTime.MinValue && this.DaysToSubtract.Get<int>((ActivityContext) executionContext) != 0)
        dateTime1 = dateTime2.AddYears(-1 * this.YearsToSubtract.Get<int>((ActivityContext) executionContext)).AddMonths(-1 * this.MonthsToSubtract.Get<int>((ActivityContext) executionContext)).AddDays((double) (-7 * this.WeeksToSubtract.Get<int>((ActivityContext) executionContext) + -1 * this.DaysToSubtract.Get<int>((ActivityContext) executionContext))).AddHours((double) (-1 * this.HoursToSubtract.Get<int>((ActivityContext) executionContext))).AddMinutes((double) (-1 * this.MinutesToSubtract.Get<int>((ActivityContext) executionContext)));
      this.Result.Set((ActivityContext) executionContext, dateTime1);
    }
  }
}
