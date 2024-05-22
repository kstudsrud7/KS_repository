// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EarlyBound.TeamProfiles
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("teamprofiles")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.20")]
  public class TeamProfiles : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "teamprofiles";
    public const int EntityTypeCode = 1203;

    public TeamProfiles()
      : base("teamprofiles")
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

    [AttributeLogicalName("fieldsecurityprofileid")]
    public Guid? FieldSecurityProfileId => this.GetAttributeValue<Guid?>("fieldsecurityprofileid");

    [AttributeLogicalName("teamid")]
    public Guid? TeamId => this.GetAttributeValue<Guid?>("teamid");

    [AttributeLogicalName("teamprofileid")]
    public Guid? TeamProfileId
    {
      get => this.GetAttributeValue<Guid?>("teamprofileid");
      set
      {
        this.OnPropertyChanging(nameof (TeamProfileId));
        this.SetAttributeValue("teamprofileid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (TeamProfileId));
      }
    }

    [AttributeLogicalName("teamprofileid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.TeamProfileId = new Guid?(value);
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");
  }
}
