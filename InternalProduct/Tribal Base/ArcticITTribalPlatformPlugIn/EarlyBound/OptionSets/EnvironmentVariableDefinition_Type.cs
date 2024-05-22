// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.OptionSets.EnvironmentVariableDefinition_Type
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
  public enum EnvironmentVariableDefinition_Type
  {
    [EnumMember] String = 100000000, // 0x05F5E100
    [EnumMember] Number = 100000001, // 0x05F5E101
    [EnumMember] Boolean = 100000002, // 0x05F5E102
    [EnumMember] JSON = 100000003, // 0x05F5E103
    [EnumMember] DataSource = 100000004, // 0x05F5E104
  }
}
