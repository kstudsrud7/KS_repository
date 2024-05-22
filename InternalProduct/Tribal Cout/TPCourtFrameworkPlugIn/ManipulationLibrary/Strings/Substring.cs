// Decompiled with JetBrains decompiler
// Type: ManipulationLibrary.Strings.Substring
// Assembly: TPCourt.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: 615270E2-97DB-4878-8B8F-88925A0FA667
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPCourtFrameworkPlugIn-41F62F3A-2F19-44F2-86DD-4C4AA2D959EF\TPCourtFrameworkPlugIn.dll

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
