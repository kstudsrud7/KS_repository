// Decompiled with JetBrains decompiler
// Type: ArcticIT.CrmFramework.Plugins.Enums.Global
// Assembly: TPFamilyWellness.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: C0DF2365-4BFC-418D-B654-2FF4D2B8EB1A
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPFamilyWellnessFrameworkPlugIn-A0924F88-EA00-EA11-A82D-000D3A1F0599\TPFamilyWellnessFrameworkPlugIn.dll

#nullable disable
namespace ArcticIT.CrmFramework.Plugins.Enums
{
  public static class Global
  {
    public enum Stage
    {
      VALIDATE = 10, // 0x0000000A
      PRE = 20, // 0x00000014
      POST = 40, // 0x00000028
    }

    public enum StateCode
    {
      ACTIVE,
      INACTIVE,
    }

    public enum ActivityStateCode
    {
      OPEN,
      COMPLETED,
      CANCELED,
      SCHEDULED,
    }

    public enum ActionType
    {
      UNKNOWN = -1, // 0xFFFFFFFF
      CREATE = 0,
      UPDATE = 1,
      DELETE = 2,
      CLOSE = 3,
      SETSTATE = 4,
      SETSTATEDYNAMICEVENT = 5,
      MERGE = 6,
      SENDEMAIL = 7,
    }
  }
}
