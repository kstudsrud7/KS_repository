// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EarlyBound.Connection_record2objecttypecode
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
  public enum Connection_record2objecttypecode
  {
    [EnumMember] Account = 1,
    [EnumMember] Contact = 2,
    [EnumMember] User = 8,
    [EnumMember] Team = 9,
    [EnumMember] Position = 50, // 0x00000032
    [EnumMember] SocialProfile = 99, // 0x00000063
    [EnumMember] Territory = 2013, // 0x000007DD
    [EnumMember] Activity = 4200, // 0x00001068
    [EnumMember] Appointment = 4201, // 0x00001069
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
    [EnumMember] CourtHearing = 10715, // 0x000029DB
  }
}
