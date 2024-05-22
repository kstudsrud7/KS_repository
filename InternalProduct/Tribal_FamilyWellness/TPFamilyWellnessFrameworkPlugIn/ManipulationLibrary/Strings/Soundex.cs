// Decompiled with JetBrains decompiler
// Type: ManipulationLibrary.Strings.Soundex
// Assembly: TPFamilyWellness.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: C0DF2365-4BFC-418D-B654-2FF4D2B8EB1A
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPFamilyWellnessFrameworkPlugIn-A0924F88-EA00-EA11-A82D-000D3A1F0599\TPFamilyWellnessFrameworkPlugIn.dll

using Microsoft.Xrm.Sdk.Workflow;
using System.Activities;
using System.Text;

#nullable disable
namespace ManipulationLibrary.Strings
{
  public sealed class Soundex : CodeActivity
  {
    [Default("4")]
    [Input("Minimum Length")]
    public InArgument<int> MinLength { get; set; }

    [Default("4")]
    [Input("Maximum Length")]
    public InArgument<int> MaxLength { get; set; }

    [Default("false")]
    [Input("Use Original Version")]
    public InArgument<bool> UseOriginal { get; set; }

    [Input("Text")]
    public InArgument<string> Text { get; set; }

    [Output("Result")]
    public OutArgument<string> Result { get; set; }

    private static string Codify(string text, int min, int max, bool original)
    {
      if (string.IsNullOrEmpty(text))
        return string.Empty;
      string str1 = text.Trim();
      StringBuilder stringBuilder = new StringBuilder();
      string str2 = "0300052D634205D12011122222";
      if (original)
        str2 = "03000520634205012011122222";
      char ch1 = str2["etaoinshrdlcumwfgypbvkjxqz".IndexOf(char.ToLower(str1[0]))];
      for (int index1 = 1; index1 < str1.Length; ++index1)
      {
        int index2 = "etaoinshrdlcumwfgypbvkjxqz".IndexOf(char.ToLower(str1[index1]));
        if (index2 >= 0)
        {
          char ch2 = str2[index2];
          if (ch2 != '0' && (int) ch2 != (int) ch1)
          {
            ch1 = ch2;
            stringBuilder.Append(ch2);
          }
        }
      }
      stringBuilder.Replace("D", string.Empty);
      stringBuilder.Insert(0, char.ToUpper(str1[0]));
      while (stringBuilder.Length < min)
        stringBuilder.Append('0');
      if (stringBuilder.Length > max)
        stringBuilder.Remove(max, stringBuilder.Length - max);
      return stringBuilder.ToString();
    }

    protected override void Execute(CodeActivityContext executionContext)
    {
      int min = this.MinLength.Get<int>((ActivityContext) executionContext);
      int max = this.MaxLength.Get<int>((ActivityContext) executionContext);
      bool original = this.UseOriginal.Get<bool>((ActivityContext) executionContext);
      string str = Soundex.Codify(this.Text.Get<string>((ActivityContext) executionContext), min, max, original);
      this.Result.Set((ActivityContext) executionContext, str);
    }
  }
}
