// Decompiled with JetBrains decompiler
// Type: ManipulationLibrary.Calculations.Maximum
// Assembly: TPFamilyWellness.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: C0DF2365-4BFC-418D-B654-2FF4D2B8EB1A
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPFamilyWellnessFrameworkPlugIn-A0924F88-EA00-EA11-A82D-000D3A1F0599\TPFamilyWellnessFrameworkPlugIn.dll

using Microsoft.Xrm.Sdk.Workflow;
using System;
using System.Activities;

#nullable disable
namespace ManipulationLibrary.Calculations
{
  public sealed class Maximum : CodeActivity
  {
    [Default("0")]
    [Input("First number")]
    public InArgument<int> Number1 { get; set; }

    [Default("0")]
    [Input("Second number")]
    public InArgument<int> Number2 { get; set; }

    [Output("Result")]
    public OutArgument<int> Result { get; set; }

    protected override void Execute(CodeActivityContext executionContext)
    {
      this.Result.Set((ActivityContext) executionContext, Math.Max(this.Number1.Get<int>((ActivityContext) executionContext), this.Number2.Get<int>((ActivityContext) executionContext)));
    }
  }
}
