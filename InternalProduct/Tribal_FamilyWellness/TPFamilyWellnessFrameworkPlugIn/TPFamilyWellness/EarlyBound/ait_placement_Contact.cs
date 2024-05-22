// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EarlyBound.ait_placement_Contact
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_placement_contact")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.20")]
  public class ait_placement_Contact : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_placement_contact";
    public const int EntityTypeCode = 10150;

    public ait_placement_Contact()
      : base("ait_placement_contact")
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

    [AttributeLogicalName("ait_placement_contactid")]
    public Guid? ait_placement_ContactId
    {
      get => this.GetAttributeValue<Guid?>("ait_placement_contactid");
    }

    [AttributeLogicalName("ait_placement_contactid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => base.Id = value;
    }

    [AttributeLogicalName("ait_placementid")]
    public Guid? ait_placementid => this.GetAttributeValue<Guid?>(nameof (ait_placementid));

    [AttributeLogicalName("contactid")]
    public Guid? contactid => this.GetAttributeValue<Guid?>(nameof (contactid));

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("ait_placement_Contact_Contact")]
    public IEnumerable<Contact> ait_placement_Contact_Contact
    {
      get
      {
        return this.GetRelatedEntities<Contact>(nameof (ait_placement_Contact_Contact), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_placement_Contact_Contact));
        this.SetRelatedEntities<Contact>(nameof (ait_placement_Contact_Contact), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_placement_Contact_Contact));
      }
    }
  }
}
