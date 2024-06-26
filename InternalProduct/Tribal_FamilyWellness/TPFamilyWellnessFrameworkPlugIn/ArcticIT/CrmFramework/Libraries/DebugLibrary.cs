﻿// Decompiled with JetBrains decompiler
// Type: ArcticIT.CrmFramework.Libraries.DebugLibrary
// Assembly: TPFamilyWellness.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: C0DF2365-4BFC-418D-B654-2FF4D2B8EB1A
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPFamilyWellnessFrameworkPlugIn-A0924F88-EA00-EA11-A82D-000D3A1F0599\TPFamilyWellnessFrameworkPlugIn.dll

using Microsoft.Xrm.Sdk;

#nullable disable
namespace ArcticIT.CrmFramework.Libraries
{
  public static class DebugLibrary
  {
    public static string GetFormattedString(EntityReference entityReference)
    {
      string empty = string.Empty;
      return entityReference == null ? empty : string.Format("({0} [{1}] [{2}])", (object) entityReference.LogicalName, (object) entityReference.Name, (object) entityReference.Id);
    }
  }
}
