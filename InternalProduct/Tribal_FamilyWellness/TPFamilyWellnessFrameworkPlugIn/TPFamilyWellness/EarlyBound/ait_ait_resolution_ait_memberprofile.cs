// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EarlyBound.ait_ait_resolution_ait_memberprofile
// Assembly: TPFamilyWellness.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: C0DF2365-4BFC-418D-B654-2FF4D2B8EB1A
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPFamilyWellnessFrameworkPlugIn-A0924F88-EA00-EA11-A82D-000D3A1F0599\TPFamilyWellnessFrameworkPlugIn.dll

using Microsoft.Xrm.Sdk;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.Serialization;

#nullable disable
namespace TPFamilyWellness.EarlyBound
{
  [DataContract]
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_ait_resolution_ait_memberprofile")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.20")]
  public class ait_ait_resolution_ait_memberprofile : 
    Entity,
    INotifyPropertyChanging,
    INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_ait_resolution_ait_memberprofile";
    public const int EntityTypeCode = 10122;

    public ait_ait_resolution_ait_memberprofile()
      : base(nameof (ait_ait_resolution_ait_memberprofile))
    {
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public event PropertyChangingEventHandler PropertyChanging;

    private void OnPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void OnPropertyChanging(string propertyName)
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, new PropertyChangingEventArgs(propertyName));
    }

    [AttributeLogicalName("ait_ait_resolution_ait_memberprofileid")]
    public Guid? ait_ait_resolution_ait_memberprofileId
    {
      get => this.GetAttributeValue<Guid?>("ait_ait_resolution_ait_memberprofileid");
    }

    [AttributeLogicalName("ait_ait_resolution_ait_memberprofileid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => base.Id = value;
    }

    [AttributeLogicalName("ait_memberprofileid")]
    public Guid? ait_memberprofileid => this.GetAttributeValue<Guid?>(nameof (ait_memberprofileid));

    [AttributeLogicalName("ait_resolutionid")]
    public Guid? ait_resolutionid => this.GetAttributeValue<Guid?>(nameof (ait_resolutionid));

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");
  }
}
