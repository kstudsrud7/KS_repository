// Decompiled with JetBrains decompiler
// Type: ManipulationLibrary.Strings.Capitalize
// Assembly: TPCourt.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: 615270E2-97DB-4878-8B8F-88925A0FA667
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPCourtFrameworkPlugIn-41F62F3A-2F19-44F2-86DD-4C4AA2D959EF\TPCourtFrameworkPlugIn.dll

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
