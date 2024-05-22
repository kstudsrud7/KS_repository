// Decompiled with JetBrains decompiler
// Type: ManipulationLibrary.Strings.PadString
// Assembly: TPCourt.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: 615270E2-97DB-4878-8B8F-88925A0FA667
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPCourtFrameworkPlugIn-41F62F3A-2F19-44F2-86DD-4C4AA2D959EF\TPCourtFrameworkPlugIn.dll

using Microsoft.Xrm.Sdk.Workflow;
using System.Activities;

#nullable disable
namespace ManipulationLibrary.Strings
{
  public sealed class PadString : CodeActivity
  {
    [Input("Text")]
    public InArgument<string> Text { get; set; }

    [Output("Result")]
    public OutArgument<string> Result { get; set; }

    [Input("Pad Character")]
    public InArgument<string> PadCharacter { get; set; }

    [Default("True")]
    [Input("Pad on the Left")]
    public InArgument<bool> PadOnLeft { get; set; }

    [Default("30")]
    [Input("Final Length")]
    public InArgument<int> FinalLength { get; set; }

    protected override void Execute(CodeActivityContext executionContext)
    {
      string str1 = this.PadCharacter.Get<string>((ActivityContext) executionContext);
      char paddingChar = string.IsNullOrEmpty(str1) ? ' ' : str1[0];
      int totalWidth = this.FinalLength.Get<int>((ActivityContext) executionContext);
      string str2 = this.Text.Get<string>((ActivityContext) executionContext);
      string str3 = this.PadOnLeft.Get<bool>((ActivityContext) executionContext) ? str2.PadLeft(totalWidth, paddingChar) : str2.PadRight(totalWidth, paddingChar);
      this.Result.Set((ActivityContext) executionContext, str3);
    }
  }
}
