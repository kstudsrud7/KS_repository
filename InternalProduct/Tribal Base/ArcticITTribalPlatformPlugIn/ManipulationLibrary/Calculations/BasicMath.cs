// Decompiled with JetBrains decompiler
// Type: ManipulationLibrary.Calculations.BasicMath
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

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
