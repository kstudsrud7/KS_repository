// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EarlyBound.ClientUpdate
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("clientupdate")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.20")]
  public class ClientUpdate : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "clientupdate";
    public const int EntityTypeCode = 36;

    public ClientUpdate()
      : base("clientupdate")
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

    [AttributeLogicalName("clientupdateid")]
    public Guid? ClientUpdateId
    {
      get => this.GetAttributeValue<Guid?>("clientupdateid");
      set
      {
        this.OnPropertyChanging(nameof (ClientUpdateId));
        this.SetAttributeValue("clientupdateid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ClientUpdateId));
      }
    }

    [AttributeLogicalName("clientupdateid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ClientUpdateId = new Guid?(value);
    }

    [AttributeLogicalName("createdon")]
    public DateTime? CreatedOn => this.GetAttributeValue<DateTime?>("createdon");

    [AttributeLogicalName("description")]
    public string Description
    {
      get => this.GetAttributeValue<string>("description");
      set
      {
        this.OnPropertyChanging(nameof (Description));
        this.SetAttributeValue("description", (object) value);
        this.OnPropertyChanged(nameof (Description));
      }
    }

    [AttributeLogicalName("sqlscript")]
    public string SqlScript
    {
      get => this.GetAttributeValue<string>("sqlscript");
      set
      {
        this.OnPropertyChanging(nameof (SqlScript));
        this.SetAttributeValue("sqlscript", (object) value);
        this.OnPropertyChanged(nameof (SqlScript));
      }
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [AttributeLogicalName("wasexecuted")]
    public bool? WasExecuted
    {
      get => this.GetAttributeValue<bool?>("wasexecuted");
      set
      {
        this.OnPropertyChanging(nameof (WasExecuted));
        this.SetAttributeValue("wasexecuted", (object) value);
        this.OnPropertyChanged(nameof (WasExecuted));
      }
    }

    [AttributeLogicalName("whenexecute")]
    public OptionSetValue WhenExecute
    {
      get => this.GetAttributeValue<OptionSetValue>("whenexecute");
      set
      {
        this.OnPropertyChanging(nameof (WhenExecute));
        this.SetAttributeValue("whenexecute", (object) value);
        this.OnPropertyChanged(nameof (WhenExecute));
      }
    }
  }
}
