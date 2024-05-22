// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.OptionSets.QueueItem_ObjectTypeCode
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
  public enum QueueItem_ObjectTypeCode
  {
    [EnumMember] Activity = 4200, // 0x00001068
    [EnumMember] Hearing = 4201, // 0x00001069
    [EnumMember] Email = 4202, // 0x0000106A
    [EnumMember] Fax = 4204, // 0x0000106C
    [EnumMember] Letter = 4207, // 0x0000106F
    [EnumMember] PhoneCall = 4210, // 0x00001072
    [EnumMember] Task = 4212, // 0x00001074
    [EnumMember] SocialActivity = 4216, // 0x00001078
    [EnumMember] RecurringAppointment = 4251, // 0x0000109B
    [EnumMember] KnowledgeArticle = 9953, // 0x000026E1
    [EnumMember] KnowledgeArticleTemplate = 10003, // 0x00002713
    [EnumMember] AlertSubscription = 10556, // 0x0000293C
    [EnumMember] InviteRedemption = 10559, // 0x0000293F
    [EnumMember] PortalComment = 10608, // 0x00002970
    [EnumMember] Incident = 10656, // 0x000029A0
    [EnumMember] ServiceRequest = 10668, // 0x000029AC
  }
}
