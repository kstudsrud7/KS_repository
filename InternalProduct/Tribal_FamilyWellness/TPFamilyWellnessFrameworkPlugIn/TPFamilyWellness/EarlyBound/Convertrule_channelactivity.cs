// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EarlyBound.Convertrule_channelactivity
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
  public enum Convertrule_channelactivity
  {
    [EnumMember] Appointment = 4201, // 0x00001069
    [EnumMember] Email = 4202, // 0x0000106A
    [EnumMember] PhoneCall = 4210, // 0x00001072
    [EnumMember] Task = 4212, // 0x00001074
    [EnumMember] SocialActivity = 4216, // 0x00001078
    [EnumMember] AlertSubscription = 10556, // 0x0000293C
    [EnumMember] InviteRedemption = 10559, // 0x0000293F
    [EnumMember] PortalComment = 10608, // 0x00002970
    [EnumMember] CourtHearing = 10715, // 0x000029DB
  }
}
