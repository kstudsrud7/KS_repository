// Decompiled with JetBrains decompiler
// Type: ManipulationLibrary.RegEx.Match
// Assembly: TPFamilyWellness.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: C0DF2365-4BFC-418D-B654-2FF4D2B8EB1A
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPFamilyWellnessFrameworkPlugIn-A0924F88-EA00-EA11-A82D-000D3A1F0599\TPFamilyWellnessFrameworkPlugIn.dll

using Microsoft.Xrm.Sdk.Workflow;
using System;
using System.Activities;
using System.Text.RegularExpressions;

#nullable disable
namespace ManipulationLibrary.RegEx
{
  public sealed class Match : CodeActivity
  {
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

    protected override void Execute(CodeActivityContext executionContext)
    {
      bool flag1 = false;
      bool flag2 = false;
      string pattern = this.Pattern.Get<string>((ActivityContext) executionContext);
      string input = this.Text.Get<string>((ActivityContext) executionContext);
      try
      {
        flag2 = new Regex(pattern).Match(input).Success;
      }
      catch (ArgumentException ex)
      {
        flag1 = true;
      }
      this.InvalidRegularExpression.Set((ActivityContext) executionContext, flag1);
      this.MatchFound.Set((ActivityContext) executionContext, flag2);
    }
  }
}
