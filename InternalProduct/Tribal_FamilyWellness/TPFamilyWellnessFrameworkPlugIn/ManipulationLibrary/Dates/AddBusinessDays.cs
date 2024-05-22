// Decompiled with JetBrains decompiler
// Type: ManipulationLibrary.Dates.AddBusinessDays
// Assembly: TPFamilyWellness.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: C0DF2365-4BFC-418D-B654-2FF4D2B8EB1A
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPFamilyWellnessFrameworkPlugIn-A0924F88-EA00-EA11-A82D-000D3A1F0599\TPFamilyWellnessFrameworkPlugIn.dll

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
