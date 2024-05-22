// Decompiled with JetBrains decompiler
// Type: ManipulationLibrary.Strings.Replace
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

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
