// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EarlyBound.Ait_pmtprocessstages
// Assembly: TPFamilyWellness.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: C0DF2365-4BFC-418D-B654-2FF4D2B8EB1A
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPFamilyWellnessFrameworkPlugIn-A0924F88-EA00-EA11-A82D-000D3A1F0599\TPFamilyWellnessFrameworkPlugIn.dll

using System.CodeDom.Compiler;
using System.Runtime.Serialization;

#nullable disable
namespace TPFamilyWellness.EarlyBound
{
  [DataContract]
  [GeneratedCode("CrmSvcUtil", "9.0.0.9154")]
  public enum Ait_pmtprocessstages
  {
    [EnumMember] StartRestartProcessing = 750000000, // 0x2CB41780
    [EnumMember] Cancel = 750000001, // 0x2CB41781
    [EnumMember] ExportComplete = 750000002, // 0x2CB41782
    [EnumMember] ProcessingInProgress = 914600000, // 0x3683B040
    [EnumMember] AvailableforProcessing = 914600001, // 0x3683B041
    [EnumMember] TransactionsGenerated = 914600002, // 0x3683B042
    [EnumMember] ReadytoIntegrate = 914600003, // 0x3683B043
    [EnumMember] IntegrationSucceeded = 914600004, // 0x3683B044
    [EnumMember] IntegrationFailed = 914600005, // 0x3683B045
    [EnumMember] Integrating = 914600006, // 0x3683B046
    [EnumMember] ProcessingFailed = 914600007, // 0x3683B047
  }
}
