// Decompiled with JetBrains decompiler
// Type: ArcticIT.CrmFramework.Libraries.UpdateNameInformation
// Assembly: TPCourt.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: 615270E2-97DB-4878-8B8F-88925A0FA667
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPCourtFrameworkPlugIn-41F62F3A-2F19-44F2-86DD-4C4AA2D959EF\TPCourtFrameworkPlugIn.dll

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
