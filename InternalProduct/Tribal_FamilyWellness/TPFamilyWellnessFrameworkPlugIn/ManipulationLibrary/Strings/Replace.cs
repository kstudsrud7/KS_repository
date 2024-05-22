// Decompiled with JetBrains decompiler
// Type: ManipulationLibrary.Strings.Replace
// Assembly: TPFamilyWellness.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: C0DF2365-4BFC-418D-B654-2FF4D2B8EB1A
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPFamilyWellnessFrameworkPlugIn-A0924F88-EA00-EA11-A82D-000D3A1F0599\TPFamilyWellnessFrameworkPlugIn.dll

using Microsoft.Xrm.Sdk.Workflow;
using System;
using System.Activities;
using System.Text;

#nullable disable
namespace ManipulationLibrary.Strings
{
  public sealed class Replace : CodeActivity
  {
    [Input("Text")]
    public InArgument<string> Text { get; set; }

    [Output("Result")]
    public OutArgument<string> Result { get; set; }

    [Input("Old Value")]
    public InArgument<string> Old { get; set; }

    [Input("New Value")]
    public InArgument<string> New { get; set; }

    [Default("False")]
    [Input("Case Sensitive")]
    public InArgument<bool> CaseSensitive { get; set; }

    protected override void Execute(CodeActivityContext executionContext)
    {
      string text = this.Text.Get<string>((ActivityContext) executionContext);
      string str1 = this.Old.Get<string>((ActivityContext) executionContext);
      string str2 = this.New.Get<string>((ActivityContext) executionContext) ?? string.Empty;
      string str3 = string.Empty;
      if (!this.CaseSensitive.Get<bool>((ActivityContext) executionContext))
      {
        if (!string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(str1))
          str3 = text.Replace(str1, str2);
      }
      else
        str3 = Replace.CompareAndReplace(text, str1, str2, StringComparison.CurrentCultureIgnoreCase);
      this.Result.Set((ActivityContext) executionContext, str3);
    }

    private static string CompareAndReplace(
      string text,
      string old,
      string @new,
      StringComparison comparison)
    {
      if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(old))
        return text;
      StringBuilder stringBuilder = new StringBuilder();
      int length = old.Length;
      int startIndex = 0;
      for (int index = text.IndexOf(old, comparison); index > 0; index = text.IndexOf(old, startIndex, comparison))
      {
        stringBuilder.Append(text, startIndex, index - startIndex);
        stringBuilder.Append(@new);
        startIndex = index + length;
      }
      stringBuilder.Append(text, startIndex, text.Length - startIndex);
      return stringBuilder.ToString();
    }
  }
}
