// Decompiled with JetBrains decompiler
// Type: ManipulationLibrary.RegEx.ReturnMatch
// Assembly: TPCourt.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: 615270E2-97DB-4878-8B8F-88925A0FA667
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPCourtFrameworkPlugIn-41F62F3A-2F19-44F2-86DD-4C4AA2D959EF\TPCourtFrameworkPlugIn.dll

using Microsoft.Xrm.Sdk.Workflow;
using System;
using System.Activities;
using System.Text;
using System.Text.RegularExpressions;

#nullable disable
namespace ManipulationLibrary.RegEx
{
  public sealed class ReturnMatch : CodeActivity
  {
    [Default("-1")]
    [Input("Match Index (-1 for all, 1 for first)")]
    public InArgument<int> Index { get; set; }

    [Input("Text")]
    public InArgument<string> Text { get; set; }

    [Input("Regular Expression Pattern")]
    public InArgument<string> Pattern { get; set; }

    [Default("False")]
    [Output("Invalid Regular Expression")]
    public OutArgument<bool> InvalidRegularExpression { get; set; }

    [Default("False")]
    [Output("Match Found")]
    public OutArgument<bool> MatchFound { get; set; }

    [Output("Match")]
    public OutArgument<string> Match { get; set; }

    protected override void Execute(CodeActivityContext executionContext)
    {
      bool flag1 = false;
      bool flag2 = false;
      string pattern = this.Pattern.Get<string>((ActivityContext) executionContext);
      string input = this.Text.Get<string>((ActivityContext) executionContext);
      int num1 = this.Index.Get<int>((ActivityContext) executionContext);
      string empty = string.Empty;
      try
      {
        StringBuilder stringBuilder = new StringBuilder();
        System.Text.RegularExpressions.Match match = new Regex(pattern).Match(input);
        int num2 = 1;
        flag2 = match.Success;
        while (match.Success)
        {
          if (num2 == num1)
          {
            stringBuilder.Append(match.Value);
            break;
          }
          if (num2 == -1 && num1 >= 1)
            stringBuilder.Append((object) match);
          match = match.NextMatch();
          ++num2;
        }
        if (stringBuilder.Length > 0)
          empty = stringBuilder.ToString();
      }
      catch (ArgumentException ex)
      {
        flag1 = true;
      }
      this.InvalidRegularExpression.Set((ActivityContext) executionContext, flag1);
      this.MatchFound.Set((ActivityContext) executionContext, flag2);
      this.Match.Set((ActivityContext) executionContext, empty);
    }
  }
}
