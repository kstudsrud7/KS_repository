// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.OptionSets.ImportFile_ProcessingStatus
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
  public enum ImportFile_ProcessingStatus
  {
    [EnumMember] NotStarted = 1,
    [EnumMember] Parsing = 2,
    [EnumMember] ParsingComplete = 3,
    [EnumMember] ComplexTransformation = 4,
    [EnumMember] LookupTransformation = 5,
    [EnumMember] PicklistTransformation = 6,
    [EnumMember] OwnerTransformation = 7,
    [EnumMember] TransformationComplete = 8,
    [EnumMember] ImportPass1 = 9,
    [EnumMember] ImportPass2 = 10, // 0x0000000A
    [EnumMember] ImportComplete = 11, // 0x0000000B
    [EnumMember] PrimaryKeyTransformation = 12, // 0x0000000C
  }
}
