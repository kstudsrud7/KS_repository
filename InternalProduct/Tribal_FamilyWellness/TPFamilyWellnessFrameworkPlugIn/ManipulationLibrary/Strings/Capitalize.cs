// Decompiled with JetBrains decompiler
// Type: ManipulationLibrary.Strings.Capitalize
// Assembly: TPFamilyWellness.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: C0DF2365-4BFC-418D-B654-2FF4D2B8EB1A
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPFamilyWellnessFrameworkPlugIn-A0924F88-EA00-EA11-A82D-000D3A1F0599\TPFamilyWellnessFrameworkPlugIn.dll

using Microsoft.Xrm.Sdk.Workflow;
using System.Activities;
using System.Globalization;

#nullable disable
namespace ManipulationLibrary.Strings
{
  public sealed class Capitalize : CodeActivity
  {
    [Input("Text")]
    public InArgument<string> Text { get; set; }

    [Output("Result")]
    public OutArgument<string> Result { get; set; }

    [Default("True")]
    [Input("Capitalize All Words")]
    public InArgument<bool> CapAll { get; set; }

    protected override void Execute(CodeActivityContext executionContext)
    {
      string str1 = this.Text.Get<string>((ActivityContext) executionContext);
      string str2 = !this.CapAll.Get<bool>((ActivityContext) executionContext) ? str1.Substring(0, 1).ToUpper() + str1.Substring(1) : CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str1);
      this.Result.Set((ActivityContext) executionContext, str2);
    }
  }
}
