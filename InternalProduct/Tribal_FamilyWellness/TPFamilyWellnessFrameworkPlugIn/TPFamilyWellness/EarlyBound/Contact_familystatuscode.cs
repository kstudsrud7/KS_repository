﻿// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EarlyBound.Contact_familystatuscode
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
  public enum Contact_familystatuscode
  {
    [EnumMember] Single = 1,
    [EnumMember] Married = 2,
    [EnumMember] Divorced = 3,
    [EnumMember] Widowed = 4,
  }
}
