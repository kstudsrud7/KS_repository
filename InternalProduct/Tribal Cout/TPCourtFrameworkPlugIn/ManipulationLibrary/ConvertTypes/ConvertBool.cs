// Decompiled with JetBrains decompiler
// Type: ManipulationLibrary.ConvertTypes.ConvertBool
// Assembly: TPCourt.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: 615270E2-97DB-4878-8B8F-88925A0FA667
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPCourtFrameworkPlugIn-41F62F3A-2F19-44F2-86DD-4C4AA2D959EF\TPCourtFrameworkPlugIn.dll

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
