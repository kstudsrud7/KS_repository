﻿// Decompiled with JetBrains decompiler
// Type: ManipulationLibrary.ConvertTypes.ConvertBool
// Assembly: TPFamilyWellness.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: C0DF2365-4BFC-418D-B654-2FF4D2B8EB1A
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPFamilyWellnessFrameworkPlugIn-A0924F88-EA00-EA11-A82D-000D3A1F0599\TPFamilyWellnessFrameworkPlugIn.dll

using Microsoft.Xrm.Sdk.Workflow;
using System;
using System.Activities;

#nullable disable
namespace ManipulationLibrary.ConvertTypes
{
  public class ConvertBool : CodeActivity
  {
    [Default("0")]
    [Input("Integer Input")]
    public InArgument<int> inputIntArg { get; set; }

    [Output("Boolean Value")]
    public OutArgument<bool> outputBoolArg { get; set; }

    protected override void Execute(CodeActivityContext context)
    {
      int result;
      int.TryParse(this.inputIntArg.Get((ActivityContext) context).ToString(), out result);
      bool boolean = Convert.ToBoolean(result);
      this.outputBoolArg.Set((ActivityContext) context, boolean);
    }
  }
}
