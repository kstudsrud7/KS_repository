// Decompiled with JetBrains decompiler
// Type: ArcticIT.CrmFramework.Plugins.Enums.Global
// Assembly: TPCourt.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: 615270E2-97DB-4878-8B8F-88925A0FA667
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPCourtFrameworkPlugIn-41F62F3A-2F19-44F2-86DD-4C4AA2D959EF\TPCourtFrameworkPlugIn.dll

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
