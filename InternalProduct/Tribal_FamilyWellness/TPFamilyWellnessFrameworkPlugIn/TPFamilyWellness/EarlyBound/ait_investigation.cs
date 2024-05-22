// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EarlyBound.ait_investigation
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_investigation")]
  [GeneratedCode("CrmSvcUtil", "9.0.0.9154")]
  public class ait_investigation : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_investigation";
    public const int EntityTypeCode = 10390;

    public ait_investigation()
      : base(nameof (ait_investigation))
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

    [AttributeLogicalName("ait_enddate")]
    public DateTime? ait_enddate
    {
      get => this.GetAttributeValue<DateTime?>(nameof (ait_enddate));
      set
      {
        this.OnPropertyChanging(nameof (ait_enddate));
        this.SetAttributeValue(nameof (ait_enddate), (object) value);
        this.OnPropertyChanged(nameof (ait_enddate));
      }
    }

    [AttributeLogicalName("ait_incident")]
    public EntityReference ait_incident
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_incident));
      set
      {
        this.OnPropertyChanging(nameof (ait_incident));
        this.SetAttributeValue(nameof (ait_incident), (object) value);
        this.OnPropertyChanged(nameof (ait_incident));
      }
    }

    [AttributeLogicalName("ait_investigationid")]
    public Guid? ait_investigationId
    {
      get => this.GetAttributeValue<Guid?>("ait_investigationid");
      set
      {
        this.OnPropertyChanging(nameof (ait_investigationId));
        this.SetAttributeValue("ait_investigationid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_investigationId));
      }
    }

    [AttributeLogicalName("ait_investigationid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_investigationId = new Guid?(value);
    }

    [AttributeLogicalName("ait_investigationnotes")]
    public string ait_InvestigationNotes
    {
      get => this.GetAttributeValue<string>("ait_investigationnotes");
      set
      {
        this.OnPropertyChanging(nameof (ait_InvestigationNotes));
        this.SetAttributeValue("ait_investigationnotes", (object) value);
        this.OnPropertyChanged(nameof (ait_InvestigationNotes));
      }
    }

    [AttributeLogicalName("ait_investigationreportid")]
    public string ait_InvestigationReportID
    {
      get => this.GetAttributeValue<string>("ait_investigationreportid");
      set
      {
        this.OnPropertyChanging(nameof (ait_InvestigationReportID));
        this.SetAttributeValue("ait_investigationreportid", (object) value);
        this.OnPropertyChanged(nameof (ait_InvestigationReportID));
      }
    }

    [AttributeLogicalName("ait_investigationstatus")]
    public OptionSetValue ait_investigationstatus
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_investigationstatus));
      set
      {
        this.OnPropertyChanging(nameof (ait_investigationstatus));
        this.SetAttributeValue(nameof (ait_investigationstatus), (object) value);
        this.OnPropertyChanged(nameof (ait_investigationstatus));
      }
    }

    [AttributeLogicalName("ait_investigator")]
    public EntityReference ait_investigator
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_investigator));
      set
      {
        this.OnPropertyChanging(nameof (ait_investigator));
        this.SetAttributeValue(nameof (ait_investigator), (object) value);
        this.OnPropertyChanged(nameof (ait_investigator));
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

    [AttributeLogicalName("ait_reporttype")]
    public OptionSetValue ait_reporttype
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_reporttype));
      set
      {
        this.OnPropertyChanging(nameof (ait_reporttype));
        this.SetAttributeValue(nameof (ait_reporttype), (object) value);
        this.OnPropertyChanged(nameof (ait_reporttype));
      }
    }

    [AttributeLogicalName("ait_startdate")]
    public DateTime? ait_startdate
    {
      get => this.GetAttributeValue<DateTime?>(nameof (ait_startdate));
      set
      {
        this.OnPropertyChanging(nameof (ait_startdate));
        this.SetAttributeValue(nameof (ait_startdate), (object) value);
        this.OnPropertyChanged(nameof (ait_startdate));
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

    [AttributeLogicalName("emailaddress")]
    public string EmailAddress
    {
      get => this.GetAttributeValue<string>("emailaddress");
      set
      {
        this.OnPropertyChanging(nameof (EmailAddress));
        this.SetAttributeValue("emailaddress", (object) value);
        this.OnPropertyChanged(nameof (EmailAddress));
      }
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
    public Ait_investigationState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new Ait_investigationState?((Ait_investigationState) Enum.ToObject(typeof (Ait_investigationState), attributeValue.Value)) : new Ait_investigationState?();
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
  }
}
