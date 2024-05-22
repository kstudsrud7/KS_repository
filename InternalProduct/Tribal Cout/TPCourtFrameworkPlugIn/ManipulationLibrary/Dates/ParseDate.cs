// Decompiled with JetBrains decompiler
// Type: ManipulationLibrary.Dates.ParseDate
// Assembly: TPCourt.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: 615270E2-97DB-4878-8B8F-88925A0FA667
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPCourtFrameworkPlugIn-41F62F3A-2F19-44F2-86DD-4C4AA2D959EF\TPCourtFrameworkPlugIn.dll

using Microsoft.Xrm.Sdk.Workflow;
using System;
using System.Activities;
using System.Globalization;

#nullable disable
namespace ManipulationLibrary.Dates
{
  public sealed class ParseDate : CodeActivity
  {
    [Default("1900-01-01T00:00:00Z")]
    [Input("Date")]
    public InArgument<DateTime> Date { get; set; }

    [Output("Day Of Week")]
    public OutArgument<int> DayOfWeek { get; set; }

    [Output("Day Of Week (Text)")]
    public OutArgument<string> DayOfWeekString { get; set; }

    [Output("Day Of Year")]
    public OutArgument<int> DayOfYear { get; set; }

    [Output("Week Number")]
    public OutArgument<int> Week { get; set; }

    [Output("Year")]
    public OutArgument<int> Year { get; set; }

    [Output("Month")]
    public OutArgument<int> Month { get; set; }

    [Output("Day")]
    public OutArgument<int> Day { get; set; }

    [Output("Hour (12-Hour-Clock)")]
    public OutArgument<int> Hour { get; set; }

    [Output("Hour (24-Hour-Clock)")]
    public OutArgument<int> Hour24 { get; set; }

    [Output("Minute")]
    public OutArgument<int> Minute { get; set; }

    [Output("AM")]
    public OutArgument<bool> IsAM { get; set; }

    [Output("PM")]
    public OutArgument<bool> IsPM { get; set; }

    public static int GetWeek(DateTime date)
    {
      return CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstFourDayWeek, System.DayOfWeek.Monday);
    }

    protected override void Execute(CodeActivityContext executionContext)
    {
      DateTime date = this.Date.Get<DateTime>((ActivityContext) executionContext);
      int num = date.Hour;
      this.Year.Set((ActivityContext) executionContext, date.Year);
      this.Month.Set((ActivityContext) executionContext, date.Month);
      this.Day.Set((ActivityContext) executionContext, date.Day);
      this.Hour24.Set((ActivityContext) executionContext, date.Hour);
      bool flag;
      if (date.Hour >= 12)
      {
        flag = false;
        num = date.Hour - 12;
      }
      else
        flag = true;
      this.Hour.Set((ActivityContext) executionContext, num);
      this.IsAM.Set((ActivityContext) executionContext, flag);
      this.IsPM.Set((ActivityContext) executionContext, !flag);
      this.Minute.Set((ActivityContext) executionContext, date.Minute);
      this.DayOfWeek.Set((ActivityContext) executionContext, (int) date.DayOfWeek);
      this.DayOfWeekString.Set((ActivityContext) executionContext, date.DayOfWeek.ToString());
      this.DayOfYear.Set((ActivityContext) executionContext, date.DayOfYear);
      this.Week.Set((ActivityContext) executionContext, ParseDate.GetWeek(date));
    }
  }
}
