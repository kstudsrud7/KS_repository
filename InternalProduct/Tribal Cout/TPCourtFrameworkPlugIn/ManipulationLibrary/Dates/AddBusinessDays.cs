// Decompiled with JetBrains decompiler
// Type: ManipulationLibrary.Dates.AddBusinessDays
// Assembly: TPCourt.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: 615270E2-97DB-4878-8B8F-88925A0FA667
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPCourtFrameworkPlugIn-41F62F3A-2F19-44F2-86DD-4C4AA2D959EF\TPCourtFrameworkPlugIn.dll

using ManipulationLibrary.Dates.Helpers;
using Microsoft.Xrm.Sdk.Workflow;
using System;
using System.Activities;

#nullable disable
namespace ManipulationLibrary.Dates
{
  public sealed class AddBusinessDays : CodeActivity
  {
    [Default("1900-01-01T00:00:00Z")]
    [Output("Result")]
    public OutArgument<DateTime> Result { get; set; }

    [Default("1900-01-01T00:00:00Z")]
    [Input("Start Date")]
    public InArgument<DateTime> StartDate { get; set; }

    [Default("false")]
    [Input("Only check to make sure the last day is a business day")]
    public InArgument<bool> CheckOnlyLastDay { get; set; }

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
      DateTime dateTime = DateUtilities.ModifyDateTime(DateUtilities.GetRules(executionContext), this.CheckOnlyLastDay.Get<bool>((ActivityContext) executionContext), this.StartDate.Get<DateTime>((ActivityContext) executionContext), Operations.Add, this.DaysToAdd.Get<int>((ActivityContext) executionContext), this.HoursToAdd.Get<int>((ActivityContext) executionContext), this.MinutesToAdd.Get<int>((ActivityContext) executionContext));
      this.Result.Set((ActivityContext) executionContext, dateTime);
    }
  }
}
