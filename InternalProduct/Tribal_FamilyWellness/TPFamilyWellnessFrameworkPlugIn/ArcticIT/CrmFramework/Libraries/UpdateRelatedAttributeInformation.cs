// Decompiled with JetBrains decompiler
// Type: ArcticIT.CrmFramework.Libraries.UpdateRelatedAttributeInformation
// Assembly: TPFamilyWellness.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: C0DF2365-4BFC-418D-B654-2FF4D2B8EB1A
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPFamilyWellnessFrameworkPlugIn-A0924F88-EA00-EA11-A82D-000D3A1F0599\TPFamilyWellnessFrameworkPlugIn.dll

#nullable disable
namespace ArcticIT.CrmFramework.Libraries
{
  public class UpdateRelatedAttributeInformation
  {
    public UpdateRelatedAttributeInformation(
      string entityLogicalName,
      string relatedAttributeName,
      string baseColumnList,
      string relatedColumnList)
    {
      this.EntityLogicalName = entityLogicalName;
      this.RelatedAttributeName = relatedAttributeName;
      this.ImpersonateOnUpdate = false;
    }

    public UpdateRelatedAttributeInformation(
      string entityLogicalName,
      string relatedAttributeName,
      string baseColumnList,
      string relatedColumnList,
      bool impersoneateOnUpdate)
    {
      this.EntityLogicalName = entityLogicalName;
      this.RelatedAttributeName = relatedAttributeName;
      this.ImpersonateOnUpdate = impersoneateOnUpdate;
      this.SetColumnLists(baseColumnList, relatedColumnList);
    }

    public string[] BaseColumnList { get; private set; }

    public string[] RelatedColumnList { get; private set; }

    public string EntityLogicalName { get; private set; }

    public string RelatedAttributeName { get; private set; }

    public bool ImpersonateOnUpdate { get; private set; }

    private void SetColumnLists(string baseColumnList, string relatedColumnList)
    {
      if (!string.IsNullOrEmpty(baseColumnList))
        this.BaseColumnList = baseColumnList.Split(',');
      else
        this.BaseColumnList = new string[0];
      if (!string.IsNullOrEmpty(relatedColumnList))
        this.RelatedColumnList = relatedColumnList.Split(',');
      else
        this.RelatedColumnList = new string[0];
    }
  }
}
