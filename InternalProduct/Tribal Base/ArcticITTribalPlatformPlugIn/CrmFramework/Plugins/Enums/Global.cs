// Decompiled with JetBrains decompiler
// Type: ArcticIT.CrmFramework.Plugins.Enums.Global
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

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
    }
  }
}
