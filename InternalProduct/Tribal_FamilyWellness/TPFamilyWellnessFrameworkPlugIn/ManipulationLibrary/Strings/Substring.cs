// Decompiled with JetBrains decompiler
// Type: ManipulationLibrary.Strings.Substring
// Assembly: TPFamilyWellness.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: C0DF2365-4BFC-418D-B654-2FF4D2B8EB1A
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPFamilyWellnessFrameworkPlugIn-A0924F88-EA00-EA11-A82D-000D3A1F0599\TPFamilyWellnessFrameworkPlugIn.dll

using Microsoft.Xrm.Sdk.Workflow;
using System.Activities;

#nullable disable
namespace ManipulationLibrary.Strings
{
  public sealed class Substring : CodeActivity
  {
    [Input("Text")]
    public InArgument<string> Text { get; set; }

    [Output("Result")]
    public OutArgument<string> Result { get; set; }

    [Default("True")]
    [Input("From Left To Right")]
    public InArgument<bool> LeftToRight { get; set; }

    [Default("0")]
    [Input("Start Index")]
    public InArgument<int> StartIndex { get; set; }

    [Default("3")]
    [Input("Length")]
    public InArgument<int> Length { get; set; }

    protected override void Execute(CodeActivityContext executionContext)
    {
      string str = Substring.PerformSubstring(this.Text.Get<string>((ActivityContext) executionContext), this.StartIndex.Get<int>((ActivityContext) executionContext), this.Length.Get<int>((ActivityContext) executionContext), this.LeftToRight.Get<bool>((ActivityContext) executionContext));
      this.Result.Set((ActivityContext) executionContext, str);
    }

    private static string PerformSubstring(string result, int start, int length, bool lefttoright)
    {
      if (length <= 0 || start < 0)
      {
        result = string.Empty;
      }
      else
      {
        if (!lefttoright)
          start = result.Length - length - start;
        result = result.Substring(start, length);
      }
      return result;
    }
  }
}
