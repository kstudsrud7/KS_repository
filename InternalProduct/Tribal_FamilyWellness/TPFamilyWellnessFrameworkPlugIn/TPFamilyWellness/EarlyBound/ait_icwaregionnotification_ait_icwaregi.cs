// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EarlyBound.ait_icwaregionnotification_ait_icwaregi
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_icwaregionnotification_ait_icwaregi")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.20")]
  public class ait_icwaregionnotification_ait_icwaregi : 
    Entity,
    INotifyPropertyChanging,
    INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_icwaregionnotification_ait_icwaregi";
    public const int EntityTypeCode = 10149;

    public ait_icwaregionnotification_ait_icwaregi()
      : base(nameof (ait_icwaregionnotification_ait_icwaregi))
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

    [AttributeLogicalName("ait_icwaregionid")]
    public Guid? ait_icwaregionid => this.GetAttributeValue<Guid?>(nameof (ait_icwaregionid));

    [AttributeLogicalName("ait_icwaregionnotification_ait_icwaregiid")]
    public Guid? ait_icwaregionnotification_ait_icwaregiId
    {
      get => this.GetAttributeValue<Guid?>("ait_icwaregionnotification_ait_icwaregiid");
    }

    [AttributeLogicalName("ait_icwaregionnotification_ait_icwaregiid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => base.Id = value;
    }

    [AttributeLogicalName("ait_icwaregionnotificationid")]
    public Guid? ait_icwaregionnotificationid
    {
      get => this.GetAttributeValue<Guid?>(nameof (ait_icwaregionnotificationid));
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");
  }
}
