// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.OptionSets.Connection_Record2ObjectTypeCode
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
  public enum Connection_Record2ObjectTypeCode
  {
    [EnumMember] Account = 1,
    [EnumMember] Contact = 2,
    [EnumMember] User = 8,
    [EnumMember] Team = 9,
    [EnumMember] Position = 50, // 0x00000032
    [EnumMember] SocialProfile = 99, // 0x00000063
    [EnumMember] Territory = 2013, // 0x000007DD
    [EnumMember] Activity = 4200, // 0x00001068
    [EnumMember] Hearing = 4201, // 0x00001069
    [EnumMember] Email = 4202, // 0x0000106A
    [EnumMember] Fax = 4204, // 0x0000106C
    [EnumMember] Letter = 4207, // 0x0000106F
    [EnumMember] PhoneCall = 4210, // 0x00001072
    [EnumMember] Task = 4212, // 0x00001074
    [EnumMember] SocialActivity = 4216, // 0x00001078
    [EnumMember] RecurringAppointment = 4251, // 0x0000109B
    [EnumMember] ProcessSession = 4710, // 0x00001266
    [EnumMember] ChannelAccessProfileRule = 9400, // 0x000024B8
    [EnumMember] Goal = 9600, // 0x00002580
    [EnumMember] KnowledgeBaseRecord = 9930, // 0x000026CA
    [EnumMember] KnowledgeArticle = 9953, // 0x000026E1
    [EnumMember] WebNotificationURL = 10548, // 0x00002934
    [EnumMember] WebPage = 10549, // 0x00002935
    [EnumMember] Website = 10551, // 0x00002937
    [EnumMember] AlertSubscription = 10556, // 0x0000293C
    [EnumMember] Invitation = 10558, // 0x0000293E
    [EnumMember] InviteRedemption = 10559, // 0x0000293F
    [EnumMember] PublishingStateTransitionRule = 10569, // 0x00002949
    [EnumMember] Shortcut = 10572, // 0x0000294C
  }
}
