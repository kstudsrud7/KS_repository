// Decompiled with JetBrains decompiler
// Type: ArcticIT.CrmFramework.Plugins.PluginException
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using System;

#nullable disable
namespace ArcticIT.CrmFramework.Plugins
{
  [Serializable]
  public class PluginException : Exception
  {
    public PluginException()
    {
    }

    public PluginException(string message)
      : base(message)
    {
    }

    public PluginException(string message, Exception e)
      : base(message, e)
    {
    }
  }
}
