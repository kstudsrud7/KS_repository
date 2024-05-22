// Decompiled with JetBrains decompiler
// Type: ManipulationLibrary.Calculations.BasicMath
// Assembly: TPCourt.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: 615270E2-97DB-4878-8B8F-88925A0FA667
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPCourtFrameworkPlugIn-41F62F3A-2F19-44F2-86DD-4C4AA2D959EF\TPCourtFrameworkPlugIn.dll

using Microsoft.Xrm.Sdk.Workflow;
using System;
using System.Activities;

#nullable disable
namespace ManipulationLibrary.Calculations
{
  public sealed class BasicMath : CodeActivity
  {
    [Default("0")]
    [Input("First number")]
    public InArgument<Decimal> Number1 { get; set; }

    [Default("0")]
    [Input("Second number")]
    public InArgument<Decimal> Number2 { get; set; }

    [Default("+")]
    [Input("Symbol")]
    public InArgument<string> Symbol { get; set; }

    [Output("Result")]
    public OutArgument<Decimal> Result { get; set; }

    protected override void Execute(CodeActivityContext executionContext)
    {
      Decimal num1 = this.Number1.Get<Decimal>((ActivityContext) executionContext);
      Decimal num2 = this.Number2.Get<Decimal>((ActivityContext) executionContext);
      switch (this.Symbol.Get<string>((ActivityContext) executionContext))
      {
        case null:
          this.Result.Set((ActivityContext) executionContext, num1);
          break;
        case "+":
          num1 += num2;
          goto default;
        case "-":
          num1 -= num2;
          goto default;
        case "/":
          num1 /= num2;
          goto default;
        case "*":
          num1 *= num2;
          goto default;
        default:
          goto case null;
      }
    }
  }
}
