// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EarlyBound.ait_tribe
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_tribe")]
  [GeneratedCode("CrmSvcUtil", "9.0.0.9154")]
  public class ait_tribe : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_tribe";
    public const int EntityTypeCode = 10342;

    public ait_tribe()
      : base(nameof (ait_tribe))
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

    [AttributeLogicalName("ait_address1_city")]
    public EntityReference ait_address1_city
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_address1_city));
      set
      {
        this.OnPropertyChanging(nameof (ait_address1_city));
        this.SetAttributeValue(nameof (ait_address1_city), (object) value);
        this.OnPropertyChanged(nameof (ait_address1_city));
      }
    }

    [AttributeLogicalName("ait_address1_state")]
    public EntityReference ait_address1_state
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_address1_state));
      set
      {
        this.OnPropertyChanging(nameof (ait_address1_state));
        this.SetAttributeValue(nameof (ait_address1_state), (object) value);
        this.OnPropertyChanged(nameof (ait_address1_state));
      }
    }

    [AttributeLogicalName("ait_address1_street1")]
    public string ait_address1_street1
    {
      get => this.GetAttributeValue<string>(nameof (ait_address1_street1));
      set
      {
        this.OnPropertyChanging(nameof (ait_address1_street1));
        this.SetAttributeValue(nameof (ait_address1_street1), (object) value);
        this.OnPropertyChanged(nameof (ait_address1_street1));
      }
    }

    [AttributeLogicalName("ait_address1_zipcode")]
    public EntityReference ait_address1_zipcode
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_address1_zipcode));
      set
      {
        this.OnPropertyChanging(nameof (ait_address1_zipcode));
        this.SetAttributeValue(nameof (ait_address1_zipcode), (object) value);
        this.OnPropertyChanged(nameof (ait_address1_zipcode));
      }
    }

    [AttributeLogicalName("ait_address1_zipplus4")]
    public string ait_address1_zipplus4
    {
      get => this.GetAttributeValue<string>(nameof (ait_address1_zipplus4));
      set
      {
        this.OnPropertyChanging(nameof (ait_address1_zipplus4));
        this.SetAttributeValue(nameof (ait_address1_zipplus4), (object) value);
        this.OnPropertyChanged(nameof (ait_address1_zipplus4));
      }
    }

    [AttributeLogicalName("ait_ancsaregion")]
    public string ait_ANCSARegion
    {
      get => this.GetAttributeValue<string>("ait_ancsaregion");
      set
      {
        this.OnPropertyChanging(nameof (ait_ANCSARegion));
        this.SetAttributeValue("ait_ancsaregion", (object) value);
        this.OnPropertyChanged(nameof (ait_ANCSARegion));
      }
    }

    [AttributeLogicalName("ait_biaagency")]
    public string ait_BIAAgency
    {
      get => this.GetAttributeValue<string>("ait_biaagency");
      set
      {
        this.OnPropertyChanging(nameof (ait_BIAAgency));
        this.SetAttributeValue("ait_biaagency", (object) value);
        this.OnPropertyChanged(nameof (ait_BIAAgency));
      }
    }

    [AttributeLogicalName("ait_biaregion")]
    public OptionSetValue ait_BIARegion
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_biaregion");
      set
      {
        this.OnPropertyChanging(nameof (ait_BIARegion));
        this.SetAttributeValue("ait_biaregion", (object) value);
        this.OnPropertyChanged(nameof (ait_BIARegion));
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

    [AttributeLogicalName("ait_fax")]
    public string ait_Fax
    {
      get => this.GetAttributeValue<string>("ait_fax");
      set
      {
        this.OnPropertyChanging(nameof (ait_Fax));
        this.SetAttributeValue("ait_fax", (object) value);
        this.OnPropertyChanged(nameof (ait_Fax));
      }
    }

    [AttributeLogicalName("ait_includeintribalbq")]
    public bool? ait_includeintribalbq
    {
      get => this.GetAttributeValue<bool?>(nameof (ait_includeintribalbq));
      set
      {
        this.OnPropertyChanging(nameof (ait_includeintribalbq));
        this.SetAttributeValue(nameof (ait_includeintribalbq), (object) value);
        this.OnPropertyChanged(nameof (ait_includeintribalbq));
      }
    }

    [AttributeLogicalName("ait_mainphone")]
    public string ait_MainPhone
    {
      get => this.GetAttributeValue<string>("ait_mainphone");
      set
      {
        this.OnPropertyChanging(nameof (ait_MainPhone));
        this.SetAttributeValue("ait_mainphone", (object) value);
        this.OnPropertyChanged(nameof (ait_MainPhone));
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

    [AttributeLogicalName("ait_notes")]
    public string ait_Notes
    {
      get => this.GetAttributeValue<string>("ait_notes");
      set
      {
        this.OnPropertyChanging(nameof (ait_Notes));
        this.SetAttributeValue("ait_notes", (object) value);
        this.OnPropertyChanged(nameof (ait_Notes));
      }
    }

    [AttributeLogicalName("ait_officialname")]
    public string ait_officialname
    {
      get => this.GetAttributeValue<string>(nameof (ait_officialname));
      set
      {
        this.OnPropertyChanging(nameof (ait_officialname));
        this.SetAttributeValue(nameof (ait_officialname), (object) value);
        this.OnPropertyChanged(nameof (ait_officialname));
      }
    }

    [AttributeLogicalName("ait_parenttribe")]
    public EntityReference ait_parenttribe
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_parenttribe));
      set
      {
        this.OnPropertyChanging(nameof (ait_parenttribe));
        this.SetAttributeValue(nameof (ait_parenttribe), (object) value);
        this.OnPropertyChanged(nameof (ait_parenttribe));
      }
    }

    [AttributeLogicalName("ait_shortname")]
    public string ait_shortname
    {
      get => this.GetAttributeValue<string>(nameof (ait_shortname));
      set
      {
        this.OnPropertyChanging(nameof (ait_shortname));
        this.SetAttributeValue(nameof (ait_shortname), (object) value);
        this.OnPropertyChanged(nameof (ait_shortname));
      }
    }

    [AttributeLogicalName("ait_tribalrecognitionlevel")]
    public OptionSetValue ait_TribalRecognitionLevel
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_tribalrecognitionlevel");
      set
      {
        this.OnPropertyChanging(nameof (ait_TribalRecognitionLevel));
        this.SetAttributeValue("ait_tribalrecognitionlevel", (object) value);
        this.OnPropertyChanged(nameof (ait_TribalRecognitionLevel));
      }
    }

    [AttributeLogicalName("ait_tribealternatename")]
    public string ait_TribeAlternateName
    {
      get => this.GetAttributeValue<string>("ait_tribealternatename");
      set
      {
        this.OnPropertyChanging(nameof (ait_TribeAlternateName));
        this.SetAttributeValue("ait_tribealternatename", (object) value);
        this.OnPropertyChanged(nameof (ait_TribeAlternateName));
      }
    }

    [AttributeLogicalName("ait_tribeid")]
    public Guid? ait_tribeId
    {
      get => this.GetAttributeValue<Guid?>("ait_tribeid");
      set
      {
        this.OnPropertyChanging(nameof (ait_tribeId));
        this.SetAttributeValue("ait_tribeid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_tribeId));
      }
    }

    [AttributeLogicalName("ait_tribeid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_tribeId = new Guid?(value);
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
    public Ait_tribeState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new Ait_tribeState?((Ait_tribeState) Enum.ToObject(typeof (Ait_tribeState), attributeValue.Value)) : new Ait_tribeState?();
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

    [RelationshipSchemaName("ait_ait_tribe_ait_program_Tribe")]
    public IEnumerable<ait_program> ait_ait_tribe_ait_program_Tribe
    {
      get
      {
        return this.GetRelatedEntities<ait_program>(nameof (ait_ait_tribe_ait_program_Tribe), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_tribe_ait_program_Tribe));
        this.SetRelatedEntities<ait_program>(nameof (ait_ait_tribe_ait_program_Tribe), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_tribe_ait_program_Tribe));
      }
    }

    [RelationshipSchemaName]
    public IEnumerable<ait_tribe> Referencedait_ait_tribe_ait_tribe
    {
      get
      {
        return this.GetRelatedEntities<ait_tribe>("ait_ait_tribe_ait_tribe", new EntityRole?((EntityRole) 1));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencedait_ait_tribe_ait_tribe));
        this.SetRelatedEntities<ait_tribe>("ait_ait_tribe_ait_tribe", new EntityRole?((EntityRole) 1), value);
        this.OnPropertyChanged(nameof (Referencedait_ait_tribe_ait_tribe));
      }
    }

    [AttributeLogicalName("ait_parenttribe")]
    [RelationshipSchemaName]
    public ait_tribe Referencingait_ait_tribe_ait_tribe
    {
      get
      {
        return this.GetRelatedEntity<ait_tribe>("ait_ait_tribe_ait_tribe", new EntityRole?((EntityRole) 0));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencingait_ait_tribe_ait_tribe));
        this.SetRelatedEntity<ait_tribe>("ait_ait_tribe_ait_tribe", new EntityRole?((EntityRole) 0), value);
        this.OnPropertyChanged(nameof (Referencingait_ait_tribe_ait_tribe));
      }
    }
  }
}
