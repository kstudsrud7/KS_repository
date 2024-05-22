// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.OptionSets.WebResource_WebResourceType
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
  public enum WebResource_WebResourceType
  {
    [EnumMember] Webpage_HTML = 1,
    [EnumMember] StyleSheet_CSS = 2,
    [EnumMember] Script_JScript = 3,
    [EnumMember] Data_XML = 4,
    [EnumMember] PNGformat = 5,
    [EnumMember] JPGformat = 6,
    [EnumMember] GIFformat = 7,
    [EnumMember] Silverlight_XAP = 8,
    [EnumMember] StyleSheet_XSL = 9,
    [EnumMember] ICOformat = 10, // 0x0000000A
    [EnumMember] Vectorformat_SVG = 11, // 0x0000000B
    [EnumMember] String_RESX = 12, // 0x0000000C
  }
}
