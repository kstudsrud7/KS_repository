// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_physicaladdress
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using Microsoft.Xrm.Sdk;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.Serialization;

#nullable disable
namespace ArcticIT.EarlyBound.Entities
{
  [DataContract]
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_physicaladdress")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_physicaladdress : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_physicaladdress";
    public const string EntitySchemaName = "ait_physicaladdress";
    public const string PrimaryIdAttribute = "ait_physicaladdressid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_physicaladdress()
      : base(nameof (ait_physicaladdress))
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

    [AttributeLogicalName("ait_address")]
    public string ait_address
    {
      get => this.GetAttributeValue<string>(nameof (ait_address));
      set
      {
        this.OnPropertyChanging(nameof (ait_address));
        this.SetAttributeValue(nameof (ait_address), (object) value);
        this.OnPropertyChanged(nameof (ait_address));
      }
    }

    [AttributeLogicalName("ait_addresstype")]
    public EntityReference ait_addresstype
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_addresstype));
      set
      {
        this.OnPropertyChanging(nameof (ait_addresstype));
        this.SetAttributeValue(nameof (ait_addresstype), (object) value);
        this.OnPropertyChanged(nameof (ait_addresstype));
      }
    }

    [AttributeLogicalName("ait_city")]
    public EntityReference ait_city
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_city));
      set
      {
        this.OnPropertyChanging(nameof (ait_city));
        this.SetAttributeValue(nameof (ait_city), (object) value);
        this.OnPropertyChanged(nameof (ait_city));
      }
    }

    [AttributeLogicalName("ait_company")]
    public EntityReference ait_company
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_company));
      set
      {
        this.OnPropertyChanging(nameof (ait_company));
        this.SetAttributeValue(nameof (ait_company), (object) value);
        this.OnPropertyChanged(nameof (ait_company));
      }
    }

    [AttributeLogicalName("ait_contact")]
    public EntityReference ait_contact
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_contact));
      set
      {
        this.OnPropertyChanging(nameof (ait_contact));
        this.SetAttributeValue(nameof (ait_contact), (object) value);
        this.OnPropertyChanged(nameof (ait_contact));
      }
    }

    [AttributeLogicalName("ait_countryregion")]
    public EntityReference ait_countryregion
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_countryregion));
      set
      {
        this.OnPropertyChanging(nameof (ait_countryregion));
        this.SetAttributeValue(nameof (ait_countryregion), (object) value);
        this.OnPropertyChanged(nameof (ait_countryregion));
      }
    }

    [AttributeLogicalName("ait_county")]
    public EntityReference ait_county
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_county));
      set
      {
        this.OnPropertyChanging(nameof (ait_county));
        this.SetAttributeValue(nameof (ait_county), (object) value);
        this.OnPropertyChanged(nameof (ait_county));
      }
    }

    [AttributeLogicalName("ait_current")]
    public bool? ait_current
    {
      get => this.GetAttributeValue<bool?>(nameof (ait_current));
      set
      {
        this.OnPropertyChanging(nameof (ait_current));
        this.SetAttributeValue(nameof (ait_current), (object) value);
        this.OnPropertyChanged(nameof (ait_current));
      }
    }

    [AttributeLogicalName("ait_directions")]
    public string ait_directions
    {
      get => this.GetAttributeValue<string>(nameof (ait_directions));
      set
      {
        this.OnPropertyChanging(nameof (ait_directions));
        this.SetAttributeValue(nameof (ait_directions), (object) value);
        this.OnPropertyChanged(nameof (ait_directions));
      }
    }

    [AttributeLogicalName("ait_geographicarea")]
    public EntityReference ait_geographicarea
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_geographicarea));
      set
      {
        this.OnPropertyChanging(nameof (ait_geographicarea));
        this.SetAttributeValue(nameof (ait_geographicarea), (object) value);
        this.OnPropertyChanged(nameof (ait_geographicarea));
      }
    }

    [AttributeLogicalName("ait_latitude")]
    public double? ait_latitude
    {
      get => this.GetAttributeValue<double?>(nameof (ait_latitude));
      set
      {
        this.OnPropertyChanging(nameof (ait_latitude));
        this.SetAttributeValue(nameof (ait_latitude), (object) value);
        this.OnPropertyChanged(nameof (ait_latitude));
      }
    }

    [AttributeLogicalName("ait_longitude")]
    public double? ait_longitude
    {
      get => this.GetAttributeValue<double?>(nameof (ait_longitude));
      set
      {
        this.OnPropertyChanging(nameof (ait_longitude));
        this.SetAttributeValue(nameof (ait_longitude), (object) value);
        this.OnPropertyChanged(nameof (ait_longitude));
      }
    }

    [AttributeLogicalName("ait_mailing")]
    public bool? ait_mailing
    {
      get => this.GetAttributeValue<bool?>(nameof (ait_mailing));
      set
      {
        this.OnPropertyChanging(nameof (ait_mailing));
        this.SetAttributeValue(nameof (ait_mailing), (object) value);
        this.OnPropertyChanged(nameof (ait_mailing));
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

    [AttributeLogicalName("ait_physicaladdressid")]
    public Guid? ait_physicaladdressId
    {
      get => this.GetAttributeValue<Guid?>("ait_physicaladdressid");
      set
      {
        this.OnPropertyChanging(nameof (ait_physicaladdressId));
        this.SetAttributeValue("ait_physicaladdressid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_physicaladdressId));
      }
    }

    [AttributeLogicalName("ait_physicaladdressid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_physicaladdressId = new Guid?(value);
    }

    [AttributeLogicalName("ait_returned")]
    public bool? ait_returned
    {
      get => this.GetAttributeValue<bool?>(nameof (ait_returned));
      set
      {
        this.OnPropertyChanging(nameof (ait_returned));
        this.SetAttributeValue(nameof (ait_returned), (object) value);
        this.OnPropertyChanged(nameof (ait_returned));
      }
    }

    [AttributeLogicalName("ait_school")]
    public EntityReference ait_school
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_school));
      set
      {
        this.OnPropertyChanging(nameof (ait_school));
        this.SetAttributeValue(nameof (ait_school), (object) value);
        this.OnPropertyChanged(nameof (ait_school));
      }
    }

    [AttributeLogicalName("ait_specialmailinginstructions")]
    public string ait_specialmailinginstructions
    {
      get => this.GetAttributeValue<string>(nameof (ait_specialmailinginstructions));
      set
      {
        this.OnPropertyChanging(nameof (ait_specialmailinginstructions));
        this.SetAttributeValue(nameof (ait_specialmailinginstructions), (object) value);
        this.OnPropertyChanged(nameof (ait_specialmailinginstructions));
      }
    }

    [AttributeLogicalName("ait_stateprovince")]
    public EntityReference ait_stateprovince
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_stateprovince));
      set
      {
        this.OnPropertyChanging(nameof (ait_stateprovince));
        this.SetAttributeValue(nameof (ait_stateprovince), (object) value);
        this.OnPropertyChanged(nameof (ait_stateprovince));
      }
    }

    [AttributeLogicalName("ait_street1")]
    public string ait_street1
    {
      get => this.GetAttributeValue<string>(nameof (ait_street1));
      set
      {
        this.OnPropertyChanging(nameof (ait_street1));
        this.SetAttributeValue(nameof (ait_street1), (object) value);
        this.OnPropertyChanged(nameof (ait_street1));
      }
    }

    [AttributeLogicalName("ait_street2")]
    public string ait_street2
    {
      get => this.GetAttributeValue<string>(nameof (ait_street2));
      set
      {
        this.OnPropertyChanging(nameof (ait_street2));
        this.SetAttributeValue(nameof (ait_street2), (object) value);
        this.OnPropertyChanged(nameof (ait_street2));
      }
    }

    [AttributeLogicalName("ait_street3")]
    public string ait_street3
    {
      get => this.GetAttributeValue<string>(nameof (ait_street3));
      set
      {
        this.OnPropertyChanging(nameof (ait_street3));
        this.SetAttributeValue(nameof (ait_street3), (object) value);
        this.OnPropertyChanged(nameof (ait_street3));
      }
    }

    [AttributeLogicalName("ait_usedfrom")]
    public DateTime? ait_usedfrom
    {
      get => this.GetAttributeValue<DateTime?>(nameof (ait_usedfrom));
      set
      {
        this.OnPropertyChanging(nameof (ait_usedfrom));
        this.SetAttributeValue(nameof (ait_usedfrom), (object) value);
        this.OnPropertyChanged(nameof (ait_usedfrom));
      }
    }

    [AttributeLogicalName("ait_usedto")]
    public DateTime? ait_usedto
    {
      get => this.GetAttributeValue<DateTime?>(nameof (ait_usedto));
      set
      {
        this.OnPropertyChanging(nameof (ait_usedto));
        this.SetAttributeValue(nameof (ait_usedto), (object) value);
        this.OnPropertyChanged(nameof (ait_usedto));
      }
    }

    [AttributeLogicalName("ait_zipcode")]
    public EntityReference ait_zipcode
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_zipcode));
      set
      {
        this.OnPropertyChanging(nameof (ait_zipcode));
        this.SetAttributeValue(nameof (ait_zipcode), (object) value);
        this.OnPropertyChanged(nameof (ait_zipcode));
      }
    }

    [AttributeLogicalName("ait_zipcodeextension")]
    public string ait_zipcodeextension
    {
      get => this.GetAttributeValue<string>(nameof (ait_zipcodeextension));
      set
      {
        this.OnPropertyChanging(nameof (ait_zipcodeextension));
        this.SetAttributeValue(nameof (ait_zipcodeextension), (object) value);
        this.OnPropertyChanged(nameof (ait_zipcodeextension));
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
      set
      {
        this.OnPropertyChanging(nameof (CreatedOnBehalfBy));
        this.SetAttributeValue("createdonbehalfby", (object) value);
        this.OnPropertyChanged(nameof (CreatedOnBehalfBy));
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
      set
      {
        this.OnPropertyChanging(nameof (ModifiedOnBehalfBy));
        this.SetAttributeValue("modifiedonbehalfby", (object) value);
        this.OnPropertyChanged(nameof (ModifiedOnBehalfBy));
      }
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
    public ait_physicaladdressState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_physicaladdressState?((ait_physicaladdressState) Enum.ToObject(typeof (ait_physicaladdressState), attributeValue.Value)) : new ait_physicaladdressState?();
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

    [RelationshipSchemaName("ait_ait_cemetary_ait_physicaladdress")]
    public IEnumerable<ait_cemetary> ait_ait_cemetary_ait_physicaladdress
    {
      get
      {
        return this.GetRelatedEntities<ait_cemetary>(nameof (ait_ait_cemetary_ait_physicaladdress), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_cemetary_ait_physicaladdress));
        this.SetRelatedEntities<ait_cemetary>(nameof (ait_ait_cemetary_ait_physicaladdress), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_cemetary_ait_physicaladdress));
      }
    }

    [RelationshipSchemaName("ait_ait_emergencycontact_ait_physicaladdress")]
    public IEnumerable<ait_emergencycontact> ait_ait_emergencycontact_ait_physicaladdress
    {
      get
      {
        return this.GetRelatedEntities<ait_emergencycontact>(nameof (ait_ait_emergencycontact_ait_physicaladdress), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_emergencycontact_ait_physicaladdress));
        this.SetRelatedEntities<ait_emergencycontact>(nameof (ait_ait_emergencycontact_ait_physicaladdress), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_emergencycontact_ait_physicaladdress));
      }
    }

    [RelationshipSchemaName("ait_ait_physicaladdress_ait_changerequest_PhysicalAddress")]
    public IEnumerable<ait_changerequest> ait_ait_physicaladdress_ait_changerequest_PhysicalAddress
    {
      get
      {
        return this.GetRelatedEntities<ait_changerequest>(nameof (ait_ait_physicaladdress_ait_changerequest_PhysicalAddress), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_physicaladdress_ait_changerequest_PhysicalAddress));
        this.SetRelatedEntities<ait_changerequest>(nameof (ait_ait_physicaladdress_ait_changerequest_PhysicalAddress), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_physicaladdress_ait_changerequest_PhysicalAddress));
      }
    }

    [RelationshipSchemaName("ait_ait_physicaladdress_ait_courtprofile_PhysicalAddress")]
    public IEnumerable<ait_courtprofile> ait_ait_physicaladdress_ait_courtprofile_PhysicalAddress
    {
      get
      {
        return this.GetRelatedEntities<ait_courtprofile>(nameof (ait_ait_physicaladdress_ait_courtprofile_PhysicalAddress), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_physicaladdress_ait_courtprofile_PhysicalAddress));
        this.SetRelatedEntities<ait_courtprofile>(nameof (ait_ait_physicaladdress_ait_courtprofile_PhysicalAddress), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_physicaladdress_ait_courtprofile_PhysicalAddress));
      }
    }

    [RelationshipSchemaName("ait_ait_physicaladdress_ait_courtprofileaddress_ContactAddress")]
    public IEnumerable<ait_courtprofileaddress> ait_ait_physicaladdress_ait_courtprofileaddress_ContactAddress
    {
      get
      {
        return this.GetRelatedEntities<ait_courtprofileaddress>(nameof (ait_ait_physicaladdress_ait_courtprofileaddress_ContactAddress), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_physicaladdress_ait_courtprofileaddress_ContactAddress));
        this.SetRelatedEntities<ait_courtprofileaddress>(nameof (ait_ait_physicaladdress_ait_courtprofileaddress_ContactAddress), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_physicaladdress_ait_courtprofileaddress_ContactAddress));
      }
    }

    [RelationshipSchemaName("ait_ait_school_ait_physicaladdress")]
    public IEnumerable<ArcticIT.EarlyBound.Entities.ait_school> ait_ait_school_ait_physicaladdress
    {
      get
      {
        return this.GetRelatedEntities<ArcticIT.EarlyBound.Entities.ait_school>(nameof (ait_ait_school_ait_physicaladdress), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_school_ait_physicaladdress));
        this.SetRelatedEntities<ArcticIT.EarlyBound.Entities.ait_school>(nameof (ait_ait_school_ait_physicaladdress), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_school_ait_physicaladdress));
      }
    }

    [RelationshipSchemaName("ait_physicaladdress_ait_courtprofile_MailingAddress")]
    public IEnumerable<ait_courtprofile> ait_physicaladdress_ait_courtprofile_MailingAddress
    {
      get
      {
        return this.GetRelatedEntities<ait_courtprofile>(nameof (ait_physicaladdress_ait_courtprofile_MailingAddress), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_physicaladdress_ait_courtprofile_MailingAddress));
        this.SetRelatedEntities<ait_courtprofile>(nameof (ait_physicaladdress_ait_courtprofile_MailingAddress), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_physicaladdress_ait_courtprofile_MailingAddress));
      }
    }

    [RelationshipSchemaName("ait_physicaladdress_Annotations")]
    public IEnumerable<Annotation> ait_physicaladdress_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (ait_physicaladdress_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_physicaladdress_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (ait_physicaladdress_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_physicaladdress_Annotations));
      }
    }

    [RelationshipSchemaName("ait_physicaladdress_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_physicaladdress_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_physicaladdress_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_physicaladdress_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_physicaladdress_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_physicaladdress_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_physicaladdress_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_physicaladdress_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_physicaladdress_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_physicaladdress_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_physicaladdress_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_physicaladdress_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_physicaladdress_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_physicaladdress_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_physicaladdress_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_physicaladdress_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_physicaladdress_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_physicaladdress_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_physicaladdress_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_physicaladdress_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_physicaladdress_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_physicaladdress_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_physicaladdress_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_physicaladdress_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_physicaladdress_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_physicaladdress_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_physicaladdress_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_physicaladdress_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_physicaladdress_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_physicaladdress_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_physicaladdress_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_physicaladdress_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_physicaladdress_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_physicaladdress_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_physicaladdress_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_physicaladdress_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_physicaladdress_ProcessSession")]
    public IEnumerable<ProcessSession> ait_physicaladdress_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_physicaladdress_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_physicaladdress_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_physicaladdress_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_physicaladdress_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_physicaladdress_SyncErrors")]
    public IEnumerable<SyncError> ait_physicaladdress_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_physicaladdress_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_physicaladdress_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_physicaladdress_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_physicaladdress_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_physicaladdress_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_physicaladdress_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_physicaladdress_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_physicaladdress_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_physicaladdress_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_physicaladdress_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_addresstype")]
    [RelationshipSchemaName("ait_ait_physicaladdress_ait_addresstype")]
    public ArcticIT.EarlyBound.Entities.ait_addresstype ait_ait_physicaladdress_ait_addresstype
    {
      get
      {
        return this.GetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_addresstype>(nameof (ait_ait_physicaladdress_ait_addresstype), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_physicaladdress_ait_addresstype));
        this.SetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_addresstype>(nameof (ait_ait_physicaladdress_ait_addresstype), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_physicaladdress_ait_addresstype));
      }
    }

    [AttributeLogicalName("ait_city")]
    [RelationshipSchemaName("ait_ait_physicaladdress_ait_city")]
    public ArcticIT.EarlyBound.Entities.ait_city ait_ait_physicaladdress_ait_city
    {
      get
      {
        return this.GetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_city>(nameof (ait_ait_physicaladdress_ait_city), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_physicaladdress_ait_city));
        this.SetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_city>(nameof (ait_ait_physicaladdress_ait_city), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_physicaladdress_ait_city));
      }
    }

    [AttributeLogicalName("ait_company")]
    [RelationshipSchemaName("ait_ait_physicaladdress_ait_company")]
    public ArcticIT.EarlyBound.Entities.ait_company ait_ait_physicaladdress_ait_company
    {
      get
      {
        return this.GetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_company>(nameof (ait_ait_physicaladdress_ait_company), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_physicaladdress_ait_company));
        this.SetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_company>(nameof (ait_ait_physicaladdress_ait_company), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_physicaladdress_ait_company));
      }
    }

    [AttributeLogicalName("ait_countryregion")]
    [RelationshipSchemaName("ait_ait_physicaladdress_ait_countryregion")]
    public ArcticIT.EarlyBound.Entities.ait_countryregion ait_ait_physicaladdress_ait_countryregion
    {
      get
      {
        return this.GetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_countryregion>(nameof (ait_ait_physicaladdress_ait_countryregion), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_physicaladdress_ait_countryregion));
        this.SetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_countryregion>(nameof (ait_ait_physicaladdress_ait_countryregion), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_physicaladdress_ait_countryregion));
      }
    }

    [AttributeLogicalName("ait_county")]
    [RelationshipSchemaName("ait_ait_physicaladdress_ait_county")]
    public ArcticIT.EarlyBound.Entities.ait_county ait_ait_physicaladdress_ait_county
    {
      get
      {
        return this.GetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_county>(nameof (ait_ait_physicaladdress_ait_county), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_physicaladdress_ait_county));
        this.SetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_county>(nameof (ait_ait_physicaladdress_ait_county), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_physicaladdress_ait_county));
      }
    }

    [AttributeLogicalName("ait_geographicarea")]
    [RelationshipSchemaName("ait_ait_physicaladdress_ait_geographicalarea")]
    public ait_geographicalarea ait_ait_physicaladdress_ait_geographicalarea
    {
      get
      {
        return this.GetRelatedEntity<ait_geographicalarea>(nameof (ait_ait_physicaladdress_ait_geographicalarea), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_physicaladdress_ait_geographicalarea));
        this.SetRelatedEntity<ait_geographicalarea>(nameof (ait_ait_physicaladdress_ait_geographicalarea), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_physicaladdress_ait_geographicalarea));
      }
    }

    [AttributeLogicalName("ait_school")]
    [RelationshipSchemaName("ait_ait_physicaladdress_ait_school")]
    public ArcticIT.EarlyBound.Entities.ait_school ait_ait_physicaladdress_ait_school
    {
      get
      {
        return this.GetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_school>(nameof (ait_ait_physicaladdress_ait_school), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_physicaladdress_ait_school));
        this.SetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_school>(nameof (ait_ait_physicaladdress_ait_school), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_physicaladdress_ait_school));
      }
    }

    [AttributeLogicalName("ait_stateprovince")]
    [RelationshipSchemaName("ait_ait_physicaladdress_ait_stateprovince")]
    public ArcticIT.EarlyBound.Entities.ait_stateprovince ait_ait_physicaladdress_ait_stateprovince
    {
      get
      {
        return this.GetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_stateprovince>(nameof (ait_ait_physicaladdress_ait_stateprovince), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_physicaladdress_ait_stateprovince));
        this.SetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_stateprovince>(nameof (ait_ait_physicaladdress_ait_stateprovince), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_physicaladdress_ait_stateprovince));
      }
    }

    [AttributeLogicalName("ait_zipcode")]
    [RelationshipSchemaName("ait_ait_physicaladdress_ait_zipcodecity")]
    public ait_zipcodecity ait_ait_physicaladdress_ait_zipcodecity
    {
      get
      {
        return this.GetRelatedEntity<ait_zipcodecity>(nameof (ait_ait_physicaladdress_ait_zipcodecity), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_physicaladdress_ait_zipcodecity));
        this.SetRelatedEntity<ait_zipcodecity>(nameof (ait_ait_physicaladdress_ait_zipcodecity), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_physicaladdress_ait_zipcodecity));
      }
    }

    [AttributeLogicalName("ait_contact")]
    [RelationshipSchemaName("ait_ait_physicaladdress_contact")]
    public Contact ait_ait_physicaladdress_contact
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (ait_ait_physicaladdress_contact), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_physicaladdress_contact));
        this.SetRelatedEntity<Contact>(nameof (ait_ait_physicaladdress_contact), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_physicaladdress_contact));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_physicaladdress")]
    public BusinessUnit business_unit_ait_physicaladdress
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_physicaladdress), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_physicaladdress_createdby")]
    public SystemUser lk_ait_physicaladdress_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_physicaladdress_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_physicaladdress_createdonbehalfby")]
    public SystemUser lk_ait_physicaladdress_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_physicaladdress_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_physicaladdress_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_physicaladdress_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_physicaladdress_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_physicaladdress_modifiedby")]
    public SystemUser lk_ait_physicaladdress_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_physicaladdress_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_physicaladdress_modifiedonbehalfby")]
    public SystemUser lk_ait_physicaladdress_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_physicaladdress_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_physicaladdress_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_physicaladdress_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_physicaladdress_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_physicaladdress")]
    public Team team_ait_physicaladdress
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_physicaladdress), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_physicaladdress")]
    public SystemUser user_ait_physicaladdress
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_ait_physicaladdress), new EntityRole?());
      }
    }

    public ait_physicaladdress(object anonymousType)
      : this()
    {
      foreach (PropertyInfo property in anonymousType.GetType().GetProperties())
      {
        object obj = property.GetValue(anonymousType, (object[]) null);
        string str = property.Name.ToLower();
        if (str.EndsWith("enum") && obj.GetType().BaseType == typeof (Enum))
        {
          obj = (object) new OptionSetValue((int) obj);
          str = str.Remove(str.Length - "enum".Length);
        }
        switch (str)
        {
          case "id":
            base.Id = (Guid) obj;
            ((DataCollection<string, object>) this.Attributes)["ait_physicaladdressid"] = (object) base.Id;
            break;
          case "ait_physicaladdressid":
            Guid? nullable = (Guid?) obj;
            if (nullable.HasValue)
            {
              base.Id = nullable.Value;
              ((DataCollection<string, object>) this.Attributes)[str] = (object) base.Id;
              break;
            }
            continue;
          case "formattedvalues":
            ((DataCollection<string, string>) this.FormattedValues).AddRange((IEnumerable<KeyValuePair<string, string>>) obj);
            break;
          default:
            ((DataCollection<string, object>) this.Attributes)[str] = obj;
            break;
        }
      }
    }
  }
}
