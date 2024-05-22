// Decompiled with JetBrains decompiler
// Type: ManipulationLibrary.Calculations.ConvertValue
// Assembly: TPCourt.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: 615270E2-97DB-4878-8B8F-88925A0FA667
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPCourtFrameworkPlugIn-41F62F3A-2F19-44F2-86DD-4C4AA2D959EF\TPCourtFrameworkPlugIn.dll

using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Workflow;
using System;
using System.Activities;

#nullable disable
namespace ManipulationLibrary.Calculations
{
  public sealed class ConvertValue : CodeActivity
  {
    [Default("0")]
    [Input("Value to convert")]
    public InArgument<string> Value { get; set; }

    [Output("Decimal")]
    public OutArgument<Decimal> DecimalValue { get; set; }

    [Output("Money")]
    public OutArgument<Money> MoneyValue { get; set; }

    [Output("Float")]
    public OutArgument<double> FloatValue { get; set; }

    [Output("Rounded Number")]
    public OutArgument<int> RoundedValue { get; set; }

    [Output("Truncated Number")]
    public OutArgument<int> TruncatedValue { get; set; }

    [Default("False")]
    [Output("Processing Error")]
    public OutArgument<bool> ProcessingError { get; set; }

    [Default("False")]
    [Output("Processing Error Message")]
    public OutArgument<string> ProcessingErrorMessage { get; set; }

    protected override void Execute(CodeActivityContext executionContext)
    {
      bool flag = false;
      try
      {
        double d = Convert.ToDouble(this.Value.Get<string>((ActivityContext) executionContext));
        this.FloatValue.Set((ActivityContext) executionContext, d);
        this.DecimalValue.Set((ActivityContext) executionContext, Convert.ToDecimal(Math.Round(d, 2)));
        this.MoneyValue.Set((ActivityContext) executionContext, new Money()
        {
          Value = Convert.ToDecimal(Math.Round(d, 2))
        });
        this.TruncatedValue.Set((ActivityContext) executionContext, Convert.ToInt32(Math.Truncate(d)));
        this.RoundedValue.Set((ActivityContext) executionContext, Convert.ToInt32(Math.Round(d, 0)));
      }
      catch (Exception ex)
      {
        flag = true;
        string str = string.Format("Error converting ({0}) - {1}", (object) this.Value, (object) ex.Message);
        this.ProcessingErrorMessage.Set((ActivityContext) executionContext, str);
      }
      this.ProcessingError.Set((ActivityContext) executionContext, flag);
    }
  }
}
