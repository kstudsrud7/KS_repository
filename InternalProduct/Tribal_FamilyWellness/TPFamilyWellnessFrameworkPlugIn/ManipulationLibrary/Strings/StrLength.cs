// Decompiled with JetBrains decompiler
// Type: ManipulationLibrary.Strings.StrLength
// Assembly: TPFamilyWellness.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: C0DF2365-4BFC-418D-B654-2FF4D2B8EB1A
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPFamilyWellnessFrameworkPlugIn-A0924F88-EA00-EA11-A82D-000D3A1F0599\TPFamilyWellnessFrameworkPlugIn.dll

using Microsoft.Xrm.Sdk.Workflow;
using System.Activities;

#nullable disable
namespace ManipulationLibrary.Strings
{
  public sealed class StrLength : CodeActivity
  {
    [Input("Text")]
    public InArgument<string> Text { get; set; }

    [Output("Length")]
    public OutArgument<int> Length { get; set; }

    protected override void Execute(CodeActivityContext executionContext)
    {
      this.Length.Set((ActivityContext) executionContext, this.Text.Get<string>((ActivityContext) executionContext).Length);
    }
  }
}
