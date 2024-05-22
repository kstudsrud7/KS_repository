// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EarlyBound.ait_placementlocation
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_placementlocation")]
  [GeneratedCode("CrmSvcUtil", "9.0.0.9154")]
  public class ait_placementlocation : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_placementlocation";
    public const int EntityTypeCode = 10394;

    public ait_placementlocation()
      : base(nameof (ait_placementlocation))
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

    [AttributeLogicalName("ait_account")]
    public EntityReference ait_account
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_account));
      set
      {
        this.OnPropertyChanging(nameof (ait_account));
        this.SetAttributeValue(nameof (ait_account), (object) value);
        this.OnPropertyChanged(nameof (ait_account));
      }
    }

    [AttributeLogicalName("ait_address")]
    public string ait_Address
    {
      get => this.GetAttributeValue<string>("ait_address");
      set
      {
        this.OnPropertyChanging(nameof (ait_Address));
        this.SetAttributeValue("ait_address", (object) value);
        this.OnPropertyChanged(nameof (ait_Address));
      }
    }

    [AttributeLogicalName("ait_backgroundcheckdate")]
    public DateTime? ait_BackgroundCheckDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_backgroundcheckdate");
      set
      {
        this.OnPropertyChanging(nameof (ait_BackgroundCheckDate));
        this.SetAttributeValue("ait_backgroundcheckdate", (object) value);
        this.OnPropertyChanged(nameof (ait_BackgroundCheckDate));
      }
    }

    [AttributeLogicalName("ait_backgroundcheckyn")]
    public bool? ait_BackgroundCheckYN
    {
      get => this.GetAttributeValue<bool?>("ait_backgroundcheckyn");
      set
      {
        this.OnPropertyChanging(nameof (ait_BackgroundCheckYN));
        this.SetAttributeValue("ait_backgroundcheckyn", (object) value);
        this.OnPropertyChanged(nameof (ait_BackgroundCheckYN));
      }
    }

    [AttributeLogicalName("ait_description")]
    public string ait_description
    {
      get => this.GetAttributeValue<string>(nameof (ait_description));
      set
      {
        this.OnPropertyChanging(nameof (ait_description));
        this.SetAttributeValue(nameof (ait_description), (object) value);
        this.OnPropertyChanged(nameof (ait_description));
      }
    }

    [AttributeLogicalName("ait_ineligibledate")]
    public DateTime? ait_IneligibleDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_ineligibledate");
      set
      {
        this.OnPropertyChanging(nameof (ait_IneligibleDate));
        this.SetAttributeValue("ait_ineligibledate", (object) value);
        this.OnPropertyChanged(nameof (ait_IneligibleDate));
      }
    }

    [AttributeLogicalName("ait_ineligiblereason")]
    public string ait_IneligibleReason
    {
      get => this.GetAttributeValue<string>("ait_ineligiblereason");
      set
      {
        this.OnPropertyChanging(nameof (ait_IneligibleReason));
        this.SetAttributeValue("ait_ineligiblereason", (object) value);
        this.OnPropertyChanged(nameof (ait_IneligibleReason));
      }
    }

    [AttributeLogicalName("ait_inpsectedby")]
    public EntityReference ait_InpsectedBy
    {
      get => this.GetAttributeValue<EntityReference>("ait_inpsectedby");
      set
      {
        this.OnPropertyChanging(nameof (ait_InpsectedBy));
        this.SetAttributeValue("ait_inpsectedby", (object) value);
        this.OnPropertyChanged(nameof (ait_InpsectedBy));
      }
    }

    [AttributeLogicalName("ait_lastinspectiondate")]
    public DateTime? ait_LastInspectionDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_lastinspectiondate");
      set
      {
        this.OnPropertyChanging(nameof (ait_LastInspectionDate));
        this.SetAttributeValue("ait_lastinspectiondate", (object) value);
        this.OnPropertyChanged(nameof (ait_LastInspectionDate));
      }
    }

    [AttributeLogicalName("ait_noofchildrenallowed")]
    public int? ait_noofchildrenallowed
    {
      get => this.GetAttributeValue<int?>(nameof (ait_noofchildrenallowed));
      set
      {
        this.OnPropertyChanging(nameof (ait_noofchildrenallowed));
        this.SetAttributeValue(nameof (ait_noofchildrenallowed), (object) value);
        this.OnPropertyChanged(nameof (ait_noofchildrenallowed));
      }
    }

    [AttributeLogicalName("ait_phone")]
    public string ait_Phone
    {
      get => this.GetAttributeValue<string>("ait_phone");
      set
      {
        this.OnPropertyChanging(nameof (ait_Phone));
        this.SetAttributeValue("ait_phone", (object) value);
        this.OnPropertyChanged(nameof (ait_Phone));
      }
    }

    [AttributeLogicalName("ait_placementcount")]
    public int? ait_PlacementCount => this.GetAttributeValue<int?>("ait_placementcount");

    [AttributeLogicalName("ait_placementcount_date")]
    public DateTime? ait_PlacementCount_Date
    {
      get => this.GetAttributeValue<DateTime?>("ait_placementcount_date");
    }

    [AttributeLogicalName("ait_placementcount_state")]
    public int? ait_PlacementCount_State
    {
      get => this.GetAttributeValue<int?>("ait_placementcount_state");
    }

    [AttributeLogicalName("ait_placementlocationid")]
    public Guid? ait_placementlocationId
    {
      get => this.GetAttributeValue<Guid?>("ait_placementlocationid");
      set
      {
        this.OnPropertyChanging(nameof (ait_placementlocationId));
        this.SetAttributeValue("ait_placementlocationid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_placementlocationId));
      }
    }

    [AttributeLogicalName("ait_placementlocationid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_placementlocationId = new Guid?(value);
    }

    [AttributeLogicalName("ait_placementlocationname")]
    public string ait_placementlocationname
    {
      get => this.GetAttributeValue<string>(nameof (ait_placementlocationname));
      set
      {
        this.OnPropertyChanging(nameof (ait_placementlocationname));
        this.SetAttributeValue(nameof (ait_placementlocationname), (object) value);
        this.OnPropertyChanged(nameof (ait_placementlocationname));
      }
    }

    [AttributeLogicalName("ait_placementstatus")]
    public OptionSetValue ait_placementstatus
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_placementstatus));
      set
      {
        this.OnPropertyChanging(nameof (ait_placementstatus));
        this.SetAttributeValue(nameof (ait_placementstatus), (object) value);
        this.OnPropertyChanged(nameof (ait_placementstatus));
      }
    }

    [AttributeLogicalName("ait_primarycontact")]
    public EntityReference ait_primarycontact
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_primarycontact));
      set
      {
        this.OnPropertyChanging(nameof (ait_primarycontact));
        this.SetAttributeValue(nameof (ait_primarycontact), (object) value);
        this.OnPropertyChanged(nameof (ait_primarycontact));
      }
    }

    [AttributeLogicalName("ait_remainingplacements")]
    public int? ait_RemainingPlacements => this.GetAttributeValue<int?>("ait_remainingplacements");

    [AttributeLogicalName("ait_secondarycontact")]
    public EntityReference ait_secondarycontact
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_secondarycontact));
      set
      {
        this.OnPropertyChanging(nameof (ait_secondarycontact));
        this.SetAttributeValue(nameof (ait_secondarycontact), (object) value);
        this.OnPropertyChanged(nameof (ait_secondarycontact));
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

    [AttributeLogicalName("ownerid")]
    public EntityReference OwnerId
    {
      get => this.GetAttributeValue<EntityReference>("ownerid");
      set
      {
        this.OnPropertyChanging(nameof (OwnerId));
        this.SetAttributeValue("ownerid", (object) value);
        this.OnPropertyChanged(nameof (OwnerId));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    public EntityReference OwningBusinessUnit
    {
      get => this.GetAttributeValue<EntityReference>("owningbusinessunit");
    }

    [AttributeLogicalName("owningteam")]
    public EntityReference OwningTeam => this.GetAttributeValue<EntityReference>("owningteam");

    [AttributeLogicalName("owninguser")]
    public EntityReference OwningUser => this.GetAttributeValue<EntityReference>("owninguser");

    [AttributeLogicalName("statecode")]
    public Ait_placementlocationState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new Ait_placementlocationState?((Ait_placementlocationState) Enum.ToObject(typeof (Ait_placementlocationState), attributeValue.Value)) : new Ait_placementlocationState?();
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

    [RelationshipSchemaName("ait_placement_placementlocation_ait_place")]
    public IEnumerable<ait_placement> ait_placement_placementlocation_ait_place
    {
      get
      {
        return this.GetRelatedEntities<ait_placement>(nameof (ait_placement_placementlocation_ait_place), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_placement_placementlocation_ait_place));
        this.SetRelatedEntities<ait_placement>(nameof (ait_placement_placementlocation_ait_place), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_placement_placementlocation_ait_place));
      }
    }

    [AttributeLogicalName("ait_account")]
    [RelationshipSchemaName("ait_placementlocation_account_Account")]
    public Account ait_placementlocation_account_Account
    {
      get
      {
        return this.GetRelatedEntity<Account>(nameof (ait_placementlocation_account_Account), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_placementlocation_account_Account));
        this.SetRelatedEntity<Account>(nameof (ait_placementlocation_account_Account), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_placementlocation_account_Account));
      }
    }
  }
}
