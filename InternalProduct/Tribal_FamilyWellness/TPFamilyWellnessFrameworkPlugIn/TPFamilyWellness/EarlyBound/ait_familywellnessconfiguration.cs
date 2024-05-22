// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EarlyBound.ait_familywellnessconfiguration
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_familywellnessconfiguration")]
  [GeneratedCode("CrmSvcUtil", "9.0.0.9154")]
  public class ait_familywellnessconfiguration : 
    Entity,
    INotifyPropertyChanging,
    INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_familywellnessconfiguration";
    public const int EntityTypeCode = 10380;

    public ait_familywellnessconfiguration()
      : base(nameof (ait_familywellnessconfiguration))
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

    [AttributeLogicalName("ait_entityimage")]
    public byte[] ait_EntityImage
    {
      get => this.GetAttributeValue<byte[]>("ait_entityimage");
      set
      {
        this.OnPropertyChanging(nameof (ait_EntityImage));
        this.SetAttributeValue("ait_entityimage", (object) value);
        this.OnPropertyChanged(nameof (ait_EntityImage));
      }
    }

    [AttributeLogicalName("ait_entityimage_timestamp")]
    public long? ait_EntityImage_Timestamp
    {
      get => this.GetAttributeValue<long?>("ait_entityimage_timestamp");
    }

    [AttributeLogicalName("ait_entityimage_url")]
    public string ait_EntityImage_URL => this.GetAttributeValue<string>("ait_entityimage_url");

    [AttributeLogicalName("ait_entityimageid")]
    public Guid? ait_EntityImageId => this.GetAttributeValue<Guid?>("ait_entityimageid");

    [AttributeLogicalName("ait_entityimagestring")]
    public string ait_EntityImageString
    {
      get => this.GetAttributeValue<string>("ait_entityimagestring");
      set
      {
        this.OnPropertyChanging(nameof (ait_EntityImageString));
        this.SetAttributeValue("ait_entityimagestring", (object) value);
        this.OnPropertyChanged(nameof (ait_EntityImageString));
      }
    }

    [AttributeLogicalName("ait_familywellnessconfigurationid")]
    public Guid? ait_familywellnessconfigurationId
    {
      get => this.GetAttributeValue<Guid?>("ait_familywellnessconfigurationid");
      set
      {
        this.OnPropertyChanging(nameof (ait_familywellnessconfigurationId));
        this.SetAttributeValue("ait_familywellnessconfigurationid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_familywellnessconfigurationId));
      }
    }

    [AttributeLogicalName("ait_familywellnessconfigurationid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_familywellnessconfigurationId = new Guid?(value);
    }

    [AttributeLogicalName("ait_fwmode")]
    public OptionSetValue ait_FWMode
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_fwmode");
      set
      {
        this.OnPropertyChanging(nameof (ait_FWMode));
        this.SetAttributeValue("ait_fwmode", (object) value);
        this.OnPropertyChanged(nameof (ait_FWMode));
      }
    }

    [AttributeLogicalName("ait_name")]
    public string ait_name
    {
      get => this.GetAttributeValue<string>(nameof (ait_name));
      set
      {
        this.OnPropertyChanging(nameof (ait_name));
        this.SetAttributeValue(nameof (ait_name), (object) value);
        this.OnPropertyChanged(nameof (ait_name));
      }
    }

    [AttributeLogicalName("ait_productkey")]
    public string ait_ProductKey
    {
      get => this.GetAttributeValue<string>("ait_productkey");
      set
      {
        this.OnPropertyChanging(nameof (ait_ProductKey));
        this.SetAttributeValue("ait_productkey", (object) value);
        this.OnPropertyChanged(nameof (ait_ProductKey));
      }
    }

    [AttributeLogicalName("ait_reportsheader")]
    public string ait_ReportsHeader
    {
      get => this.GetAttributeValue<string>("ait_reportsheader");
      set
      {
        this.OnPropertyChanging(nameof (ait_ReportsHeader));
        this.SetAttributeValue("ait_reportsheader", (object) value);
        this.OnPropertyChanged(nameof (ait_ReportsHeader));
      }
    }

    [AttributeLogicalName("ait_reportsheader2")]
    public string ait_ReportsHeader2
    {
      get => this.GetAttributeValue<string>("ait_reportsheader2");
      set
      {
        this.OnPropertyChanging(nameof (ait_ReportsHeader2));
        this.SetAttributeValue("ait_reportsheader2", (object) value);
        this.OnPropertyChanged(nameof (ait_ReportsHeader2));
      }
    }

    [AttributeLogicalName("createdby")]
    public EntityReference CreatedBy => this.GetAttributeValue<EntityReference>("createdby");

    [AttributeLogicalName("createdon")]
    public DateTime? CreatedOn => this.GetAttributeValue<DateTime?>("createdon");

    [AttributeLogicalName("createdonbehalfby")]
    public EntityReference CreatedOnBehalfBy
    {
      get => this.GetAttributeValue<EntityReference>("createdonbehalfby");
    }

    [AttributeLogicalName("importsequencenumber")]
    public int? ImportSequenceNumber
    {
      get => this.GetAttributeValue<int?>("importsequencenumber");
      set
      {
        this.OnPropertyChanging(nameof (ImportSequenceNumber));
        this.SetAttributeValue("importsequencenumber", (object) value);
        this.OnPropertyChanged(nameof (ImportSequenceNumber));
      }
    }

    [AttributeLogicalName("modifiedby")]
    public EntityReference ModifiedBy => this.GetAttributeValue<EntityReference>("modifiedby");

    [AttributeLogicalName("modifiedon")]
    public DateTime? ModifiedOn => this.GetAttributeValue<DateTime?>("modifiedon");

    [AttributeLogicalName("modifiedonbehalfby")]
    public EntityReference ModifiedOnBehalfBy
    {
      get => this.GetAttributeValue<EntityReference>("modifiedonbehalfby");
    }

    [AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get => this.GetAttributeValue<EntityReference>("organizationid");
    }

    [AttributeLogicalName("overriddencreatedon")]
    public DateTime? OverriddenCreatedOn
    {
      get => this.GetAttributeValue<DateTime?>("overriddencreatedon");
      set
      {
        this.OnPropertyChanging(nameof (OverriddenCreatedOn));
        this.SetAttributeValue("overriddencreatedon", (object) value);
        this.OnPropertyChanged(nameof (OverriddenCreatedOn));
      }
    }

    [AttributeLogicalName("statecode")]
    public Ait_familywellnessconfigurationState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new Ait_familywellnessconfigurationState?((Ait_familywellnessconfigurationState) Enum.ToObject(typeof (Ait_familywellnessconfigurationState), attributeValue.Value)) : new Ait_familywellnessconfigurationState?();
      }
      set
      {
        this.OnPropertyChanging(nameof (statecode));
        if (!value.HasValue)
          this.SetAttributeValue(nameof (statecode), (object) null);
        else
          this.SetAttributeValue(nameof (statecode), (object) new OptionSetValue((int) value.Value));
        this.OnPropertyChanged(nameof (statecode));
      }
    }

    [AttributeLogicalName("statuscode")]
    public OptionSetValue statuscode
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (statuscode));
      set
      {
        this.OnPropertyChanging(nameof (statuscode));
        this.SetAttributeValue(nameof (statuscode), (object) value);
        this.OnPropertyChanged(nameof (statuscode));
      }
    }

    [AttributeLogicalName("timezoneruleversionnumber")]
    public int? TimeZoneRuleVersionNumber
    {
      get => this.GetAttributeValue<int?>("timezoneruleversionnumber");
      set
      {
        this.OnPropertyChanging(nameof (TimeZoneRuleVersionNumber));
        this.SetAttributeValue("timezoneruleversionnumber", (object) value);
        this.OnPropertyChanged(nameof (TimeZoneRuleVersionNumber));
      }
    }

    [AttributeLogicalName("utcconversiontimezonecode")]
    public int? UTCConversionTimeZoneCode
    {
      get => this.GetAttributeValue<int?>("utcconversiontimezonecode");
      set
      {
        this.OnPropertyChanging(nameof (UTCConversionTimeZoneCode));
        this.SetAttributeValue("utcconversiontimezonecode", (object) value);
        this.OnPropertyChanged(nameof (UTCConversionTimeZoneCode));
      }
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_familywellnessconfiguration_createdby")]
    public SystemUser lk_ait_familywellnessconfiguration_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_familywellnessconfiguration_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_familywellnessconfiguration_createdonbehalfby")]
    public SystemUser lk_ait_familywellnessconfiguration_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_familywellnessconfiguration_createdonbehalfby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_familywellnessconfiguration_modifiedby")]
    public SystemUser lk_ait_familywellnessconfiguration_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_familywellnessconfiguration_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_familywellnessconfiguration_modifiedonbehalfby")]
    public SystemUser lk_ait_familywellnessconfiguration_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_familywellnessconfiguration_modifiedonbehalfby), new EntityRole?());
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_ait_familywellnessconfiguration")]
    public Organization organization_ait_familywellnessconfiguration
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_ait_familywellnessconfiguration), new EntityRole?());
      }
    }
  }
}
