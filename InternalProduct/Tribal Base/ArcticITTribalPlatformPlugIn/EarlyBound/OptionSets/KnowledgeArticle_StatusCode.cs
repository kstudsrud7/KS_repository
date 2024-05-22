// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.OptionSets.KnowledgeArticle_StatusCode
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
  public enum KnowledgeArticle_StatusCode
  {
    [EnumMember] Proposed = 1,
    [EnumMember] Draft = 2,
    [EnumMember] Needsreview_Active = 3,
    [EnumMember] Inreview = 4,
    [EnumMember] Approved = 5,
    [EnumMember] Scheduled = 6,
    [EnumMember] Published = 7,
    [EnumMember] Needsreview_Inactive = 8,
    [EnumMember] Updating = 9,
    [EnumMember] Expired = 10, // 0x0000000A
    [EnumMember] Rejected_Inactive_11 = 11, // 0x0000000B
    [EnumMember] Archived = 12, // 0x0000000C
    [EnumMember] Discarded = 13, // 0x0000000D
    [EnumMember] Rejected_Inactive_14 = 14, // 0x0000000E
  }
}
