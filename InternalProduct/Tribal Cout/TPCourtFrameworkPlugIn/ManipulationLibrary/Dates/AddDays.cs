// Decompiled with JetBrains decompiler
// Type: ManipulationLibrary.Dates.AddDays
// Assembly: TPCourt.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: 615270E2-97DB-4878-8B8F-88925A0FA667
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPCourtFrameworkPlugIn-41F62F3A-2F19-44F2-86DD-4C4AA2D959EF\TPCourtFrameworkPlugIn.dll

using Microsoft.Xrm.Sdk.Workflow;
using System;
using System.Activities;

#nullable disable
namespace ManipulationLibrary.Dates
{
  public sealed class AddDays : CodeActivity
  {
    [Default("1900-01-01T00:00:00Z")]
    [Output("Result")]
    public OutArgument<DateTime> Result { get; set; }

    [Default("1900-01-01T00:00:00Z")]
    [Input("Start Date")]
    public InArgument<DateTime> StartDate { get; set; }

    [Default("0")]
    [Input("Years To Add")]
    public InArgument<int> YearsToAdd { get; set; }

    [Default("0")]
    [Input("Months To Add")]
    public InArgument<int> MonthsToAdd { get; set; }

    [Default("0")]
    [Input("Weeks To Add")]
    public InArgument<int> WeeksToAdd { get; set; }

    [Default("0")]
    [Input("Days To Add")]
    public InArgument<int> DaysToAdd { get; set; }

    [Default("0")]
    [Input("Hours To Add")]
    public InArgument<int> HoursToAdd { get; set; }

    [Default("0")]
    [Input("Minutes To Add")]
    public InArgument<int> MinutesToAdd { get; set; }

    protected override void Execute(CodeActivityContext executionContext)
    {
      DateTime dateTime1 = new DateTime();
      DateTime dateTime2 = this.StartDate.Get<DateTime>((ActivityContext) executionContext);
      if (dateTime2 != DateTime.MinValue)
        dateTime1 = dateTime2;
      if (dateTime2 != DateTime.MinValue && this.DaysToAdd.Get<int>((ActivityContext) executionContext) != 0)
      {
        DateTime dateTime3 = dateTime2.AddYears(this.YearsToAdd.Get<int>((ActivityContext) executionContext)).AddMonths(this.MonthsToAdd.Get<int>((ActivityContext) executionContext)).AddDays((double) (7 * this.WeeksToAdd.Get<int>((ActivityContext) executionContext) + this.DaysToAdd.Get<int>((ActivityContext) executionContext)));
        dateTime3 = dateTime3.AddHours((double) this.HoursToAdd.Get<int>((ActivityContext) executionContext));
        dateTime1 = dateTime3.AddMinutes((double) this.MinutesToAdd.Get<int>((ActivityContext) executionContext));
      }
      this.Result.Set((ActivityContext) executionContext, dateTime1);
    }
  }
}
