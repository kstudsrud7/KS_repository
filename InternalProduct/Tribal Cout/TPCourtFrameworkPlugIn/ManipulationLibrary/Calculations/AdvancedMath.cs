// Decompiled with JetBrains decompiler
// Type: ManipulationLibrary.Calculations.AdvancedMath
// Assembly: TPCourt.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: 615270E2-97DB-4878-8B8F-88925A0FA667
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPCourtFrameworkPlugIn-41F62F3A-2F19-44F2-86DD-4C4AA2D959EF\TPCourtFrameworkPlugIn.dll

using ManipulationLibrary.Calculations.Helpers;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Workflow;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace ManipulationLibrary.Calculations
{
  public sealed class AdvancedMath : CodeActivity
  {
    [Default("False")]
    [Output("Error Processing Formula")]
    public OutArgument<bool> Error { get; set; }

    [Output("Error Message")]
    public OutArgument<string> ErrorMessage { get; set; }

    [Default("((3+5)/@a)*pi")]
    [Input("Formula")]
    public InArgument<string> Formula { get; set; }

    [Input("@a")]
    public InArgument<string> Var1 { get; set; }

    [Input("@b")]
    public InArgument<string> Var2 { get; set; }

    [Input("@c")]
    public InArgument<string> Var3 { get; set; }

    [Input("@d")]
    public InArgument<string> Var4 { get; set; }

    [Input("@e")]
    public InArgument<string> Var5 { get; set; }

    [Input("@f")]
    public InArgument<string> Var6 { get; set; }

    [Input("@g")]
    public InArgument<string> Var7 { get; set; }

    [Input("@h")]
    public InArgument<string> Var8 { get; set; }

    [Input("@i")]
    public InArgument<string> Var9 { get; set; }

    [Input("@x")]
    public InArgument<string> Var10 { get; set; }

    [Input("@y")]
    public InArgument<string> Var11 { get; set; }

    [Input("@z")]
    public InArgument<string> Var12 { get; set; }

    [Output("String Output")]
    public OutArgument<string> StringOutput { get; set; }

    [Output("Money Result")]
    public OutArgument<Money> MoneyOutput { get; set; }

    [Output("Truncated Number Output")]
    public OutArgument<int> TruncatedOutput { get; set; }

    [Output("Rounded Number Output")]
    public OutArgument<int> RoundedOutput { get; set; }

    [Output("Float Output")]
    public OutArgument<double> FloatOutput { get; set; }

    private void AddParameters(ActivityContext context, Dictionary<string, string> parameters)
    {
      AdvancedMath.AddParameter((IDictionary<string, string>) parameters, "@a", this.Var1.Get<string>(context));
      AdvancedMath.AddParameter((IDictionary<string, string>) parameters, "@b", this.Var2.Get<string>(context));
      AdvancedMath.AddParameter((IDictionary<string, string>) parameters, "@c", this.Var3.Get<string>(context));
      AdvancedMath.AddParameter((IDictionary<string, string>) parameters, "@d", this.Var4.Get<string>(context));
      AdvancedMath.AddParameter((IDictionary<string, string>) parameters, "@e", this.Var5.Get<string>(context));
      AdvancedMath.AddParameter((IDictionary<string, string>) parameters, "@f", this.Var6.Get<string>(context));
      AdvancedMath.AddParameter((IDictionary<string, string>) parameters, "@g", this.Var7.Get<string>(context));
      AdvancedMath.AddParameter((IDictionary<string, string>) parameters, "@h", this.Var8.Get<string>(context));
      AdvancedMath.AddParameter((IDictionary<string, string>) parameters, "@i", this.Var9.Get<string>(context));
      AdvancedMath.AddParameter((IDictionary<string, string>) parameters, "@x", this.Var10.Get<string>(context));
      AdvancedMath.AddParameter((IDictionary<string, string>) parameters, "@y", this.Var11.Get<string>(context));
      AdvancedMath.AddParameter((IDictionary<string, string>) parameters, "@z", this.Var12.Get<string>(context));
    }

    private static void AddParameter(
      IDictionary<string, string> parameters,
      string param,
      string variable)
    {
      double result;
      if (string.IsNullOrEmpty(variable) || !double.TryParse(variable, out result))
        return;
      parameters.Add(param, result.ToString());
    }

    protected override void Execute(CodeActivityContext executionContext)
    {
      bool flag = false;
      string str = string.Empty;
      string seed = this.Formula.Get<string>((ActivityContext) executionContext);
      try
      {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        this.AddParameters((ActivityContext) executionContext, dictionary);
        string equation = dictionary.Aggregate<KeyValuePair<string, string>, string>(seed, (Func<string, KeyValuePair<string, string>, string>) ((c, p) => c.Replace(p.Key, string.Format(" {0} ", (object) p.Value))));
        this.SetOutputValues((ActivityContext) executionContext, Equation.Solve(equation));
      }
      catch (Exception ex)
      {
        str = ex.Message;
        flag = true;
      }
      this.Error.Set((ActivityContext) executionContext, flag);
      this.ErrorMessage.Set((ActivityContext) executionContext, str);
    }

    private void SetOutputValues(ActivityContext context, double value)
    {
      this.StringOutput.Set(context, string.Format("{0:0.0#####}", (object) value));
      this.MoneyOutput.Set(context, new Money()
      {
        Value = Convert.ToDecimal(Math.Round(value, 2))
      });
      this.TruncatedOutput.Set(context, Convert.ToInt32(Math.Truncate(value)));
      this.RoundedOutput.Set(context, (object) Math.Round(value, 0));
      this.FloatOutput.Set(context, value);
    }
  }
}
