// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.OptionSets.SdkMessageProcessingStep_Stage
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using System.CodeDom.Compiler;
using System.Runtime.Serialization;

#nullable disable
namespace ArcticIT.EarlyBound.OptionSets
{
  [DataContract]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public enum SdkMessageProcessingStep_Stage
  {
    [EnumMember] InitialPreoperation_Forinternaluseonly = 5,
    [EnumMember] Prevalidation = 10, // 0x0000000A
    [EnumMember] InternalPreoperationBeforeExternalPlugins_Forinternaluseonly = 15, // 0x0000000F
    [EnumMember] Preoperation = 20, // 0x00000014
    [EnumMember] InternalPreoperationAfterExternalPlugins_Forinternaluseonly = 25, // 0x00000019
    [EnumMember] MainOperation_Forinternaluseonly = 30, // 0x0000001E
    [EnumMember] InternalPostoperationBeforeExternalPlugins_Forinternaluseonly = 35, // 0x00000023
    [EnumMember] Postoperation = 40, // 0x00000028
    [EnumMember] InternalPostoperationAfterExternalPlugins_Forinternaluseonly = 45, // 0x0000002D
    [EnumMember] Postoperation_Deprecated = 50, // 0x00000032
    [EnumMember] FinalPostoperation_Forinternaluseonly = 55, // 0x00000037
    [EnumMember] PreCommitstagefiredbeforetransactioncommit_Forinternaluseonly = 80, // 0x00000050
    [EnumMember] PostCommitstagefiredaftertransactioncommit_Forinternaluseonly = 90, // 0x0000005A
  }
}
