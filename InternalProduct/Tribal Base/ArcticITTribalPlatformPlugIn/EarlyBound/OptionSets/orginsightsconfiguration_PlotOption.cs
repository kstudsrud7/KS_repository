// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.OptionSets.orginsightsconfiguration_PlotOption
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
  public enum orginsightsconfiguration_PlotOption
  {
    [EnumMember] Line = 1,
    [EnumMember] Column = 2,
    [EnumMember] Area = 3,
    [EnumMember] Pie = 4,
    [EnumMember] Bar = 5,
    [EnumMember] Donut = 6,
    [EnumMember] Infocard = 7,
    [EnumMember] List = 8,
    [EnumMember] DoubleDonut = 9,
    [EnumMember] LinearGauge = 10, // 0x0000000A
    [EnumMember] Bubble = 11, // 0x0000000B
  }
}
