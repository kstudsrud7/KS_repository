// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EarlyBound.SystemUserProfiles
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("systemuserprofiles")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.20")]
  public class SystemUserProfiles : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "systemuserprofiles";
    public const int EntityTypeCode = 1202;

    public SystemUserProfiles()
      : base("systemuserprofiles")
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

    [AttributeLogicalName("systemuserid")]
    public Guid? SystemUserId => this.GetAttributeValue<Guid?>("systemuserid");

    [AttributeLogicalName("systemuserprofileid")]
    public Guid? SystemUserProfileId
    {
      get => this.GetAttributeValue<Guid?>("systemuserprofileid");
      set
      {
        this.OnPropertyChanging(nameof (SystemUserProfileId));
        this.SetAttributeValue("systemuserprofileid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (SystemUserProfileId));
      }
    }

    [AttributeLogicalName("systemuserprofileid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.SystemUserProfileId = new Guid?(value);
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("systemuserprofiles_association")]
    public IEnumerable<SystemUser> systemuserprofiles_association
    {
      get
      {
        return this.GetRelatedEntities<SystemUser>(nameof (systemuserprofiles_association), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (systemuserprofiles_association));
        this.SetRelatedEntities<SystemUser>(nameof (systemuserprofiles_association), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (systemuserprofiles_association));
      }
    }
  }
}
