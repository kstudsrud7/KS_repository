// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EarlyBound.ait_ait_incidents_ait_clientprofile
// Assembly: TPFamilyWellness.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: C0DF2365-4BFC-418D-B654-2FF4D2B8EB1A
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPFamilyWellnessFrameworkPlugIn-A0924F88-EA00-EA11-A82D-000D3A1F0599\TPFamilyWellnessFrameworkPlugIn.dll

using Microsoft.Xrm.Sdk;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

#nullable disable
namespace TPFamilyWellness.EarlyBound
{
  [DataContract]
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_ait_incidents_ait_clientprofile")]
  [GeneratedCode("CrmSvcUtil", "9.0.0.9154")]
  public class ait_ait_incidents_ait_clientprofile : 
    Entity,
    INotifyPropertyChanging,
    INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_ait_incidents_ait_clientprofile";
    public const int EntityTypeCode = 10711;

    public ait_ait_incidents_ait_clientprofile()
      : base(nameof (ait_ait_incidents_ait_clientprofile))
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

    [AttributeLogicalName("ait_ait_incidents_ait_clientprofileid")]
    public Guid? ait_ait_incidents_ait_clientprofileId
    {
      get => this.GetAttributeValue<Guid?>("ait_ait_incidents_ait_clientprofileid");
    }

    [AttributeLogicalName("ait_ait_incidents_ait_clientprofileid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => base.Id = value;
    }

    [AttributeLogicalName("ait_clientprofileid")]
    public Guid? ait_clientprofileid => this.GetAttributeValue<Guid?>(nameof (ait_clientprofileid));

    [AttributeLogicalName("ait_incidentsid")]
    public Guid? ait_incidentsid => this.GetAttributeValue<Guid?>(nameof (ait_incidentsid));

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("ait_ait_incidents_ait_clientprofile")]
    public IEnumerable<ait_incidents> ait_ait_incidents_ait_clientprofile1
    {
      get
      {
        return this.GetRelatedEntities<ait_incidents>(nameof (ait_ait_incidents_ait_clientprofile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_incidents_ait_clientprofile1));
        this.SetRelatedEntities<ait_incidents>(nameof (ait_ait_incidents_ait_clientprofile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_incidents_ait_clientprofile1));
      }
    }
  }
}
