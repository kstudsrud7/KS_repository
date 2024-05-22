// Decompiled with JetBrains decompiler
// Type: ArcticIT.CrmFramework.Libraries.UpdateNameInformation
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

#nullable disable
namespace ArcticIT.CrmFramework.Libraries
{
  public class UpdateNameInformation
  {
    public UpdateNameInformation(string entityLogicalName, string relatedAttributeName)
    {
      this.EntityLogicalName = entityLogicalName;
      this.RelatedAttributeName = relatedAttributeName;
      this.ImpersonateOnUpdate = false;
    }

    public UpdateNameInformation(
      string entityLogicalName,
      string relatedAttributeName,
      bool impersoneateOnUpdate)
    {
      this.EntityLogicalName = entityLogicalName;
      this.RelatedAttributeName = relatedAttributeName;
      this.ImpersonateOnUpdate = impersoneateOnUpdate;
    }

    public string EntityLogicalName { get; private set; }

    public string RelatedAttributeName { get; private set; }

    public bool ImpersonateOnUpdate { get; private set; }
  }
}
