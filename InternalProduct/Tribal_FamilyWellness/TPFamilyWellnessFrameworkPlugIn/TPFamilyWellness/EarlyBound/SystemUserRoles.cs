// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EarlyBound.SystemUserRoles
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("systemuserroles")]
  [GeneratedCode("CrmSvcUtil", "9.0.0.9154")]
  public class SystemUserRoles : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "systemuserroles";
    public const int EntityTypeCode = 15;

    public SystemUserRoles()
      : base("systemuserroles")
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

    [AttributeLogicalName("roleid")]
    public Guid? RoleId => this.GetAttributeValue<Guid?>("roleid");

    [AttributeLogicalName("systemuserid")]
    public Guid? SystemUserId => this.GetAttributeValue<Guid?>("systemuserid");

    [AttributeLogicalName("systemuserroleid")]
    public Guid? SystemUserRoleId
    {
      get => this.GetAttributeValue<Guid?>("systemuserroleid");
      set
      {
        this.OnPropertyChanging(nameof (SystemUserRoleId));
        this.SetAttributeValue("systemuserroleid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (SystemUserRoleId));
      }
    }

    [AttributeLogicalName("systemuserroleid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.SystemUserRoleId = new Guid?(value);
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("systemuserroles_association")]
    public IEnumerable<SystemUser> systemuserroles_association
    {
      get
      {
        return this.GetRelatedEntities<SystemUser>(nameof (systemuserroles_association), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (systemuserroles_association));
        this.SetRelatedEntities<SystemUser>(nameof (systemuserroles_association), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (systemuserroles_association));
      }
    }
  }
}
