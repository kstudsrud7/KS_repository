// Decompiled with JetBrains decompiler
// Type: ArcticIT.CrmFramework.Libraries.UpdateStatusInformation
// Assembly: TPFamilyWellness.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: C0DF2365-4BFC-418D-B654-2FF4D2B8EB1A
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPFamilyWellnessFrameworkPlugIn-A0924F88-EA00-EA11-A82D-000D3A1F0599\TPFamilyWellnessFrameworkPlugIn.dll

#nullable disable
namespace ArcticIT.CrmFramework.Libraries
{
  public class UpdateStatusInformation
  {
    public UpdateStatusInformation(
      string entityLogicalName,
      string relatedAttributeName,
      int stateCode,
      int satusCode)
    {
      this.EntityLogicalName = entityLogicalName;
      this.RelatedAttributeName = relatedAttributeName;
      this.ImpersonateOnUpdate = false;
      this.StateCode = stateCode;
      this.StatusCode = satusCode;
    }

    public UpdateStatusInformation(
      string entityLogicalName,
      string relatedAttributeName,
      int stateCode,
      int satusCode,
      bool impersoneateOnUpdate)
    {
      this.EntityLogicalName = entityLogicalName;
      this.RelatedAttributeName = relatedAttributeName;
      this.ImpersonateOnUpdate = impersoneateOnUpdate;
      this.StateCode = stateCode;
      this.StatusCode = satusCode;
    }

    public string EntityLogicalName { get; private set; }

    public string RelatedAttributeName { get; private set; }

    public int StateCode { get; private set; }

    public int StatusCode { get; private set; }

    public bool ImpersonateOnUpdate { get; private set; }
  }
}
