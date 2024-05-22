// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_tribe
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_tribe")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_tribe : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_tribe";
    public const string EntitySchemaName = "ait_tribe";
    public const string PrimaryIdAttribute = "ait_tribeid";
    public const string PrimaryNameAttribute = "ait_name";

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
    public string ait_biaregion
    {
      get => this.GetAttributeValue<string>(nameof (ait_biaregion));
      set
      {
        this.OnPropertyChanging(nameof (ait_biaregion));
        this.SetAttributeValue(nameof (ait_biaregion), (object) value);
        this.OnPropertyChanged(nameof (ait_biaregion));
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
    public ait_tribeState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_tribeState?((ait_tribeState) Enum.ToObject(typeof (ait_tribeState), attributeValue.Value)) : new ait_tribeState?();
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
    public OptionSetValue StatusCode
    {
      get => this.GetAttributeValue<OptionSetValue>("statuscode");
      set
      {
        this.OnPropertyChanging(nameof (StatusCode));
        this.SetAttributeValue("statuscode", (object) value);
        this.OnPropertyChanged(nameof (StatusCode));
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

    [RelationshipSchemaName("ait_ait_tribalenrollmentconfiguration_ait_tribe")]
    public IEnumerable<ait_tribalenrollmentconfiguration> ait_ait_tribalenrollmentconfiguration_ait_tribe
    {
      get
      {
        return this.GetRelatedEntities<ait_tribalenrollmentconfiguration>(nameof (ait_ait_tribalenrollmentconfiguration_ait_tribe), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_tribalenrollmentconfiguration_ait_tribe));
        this.SetRelatedEntities<ait_tribalenrollmentconfiguration>(nameof (ait_ait_tribalenrollmentconfiguration_ait_tribe), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_tribalenrollmentconfiguration_ait_tribe));
      }
    }

    [RelationshipSchemaName("ait_ait_tribe_ait_bloodquantum_confederatedtribefilter")]
    public IEnumerable<ait_bloodquantum> ait_ait_tribe_ait_bloodquantum_confederatedtribefilter
    {
      get
      {
        return this.GetRelatedEntities<ait_bloodquantum>(nameof (ait_ait_tribe_ait_bloodquantum_confederatedtribefilter), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_tribe_ait_bloodquantum_confederatedtribefilter));
        this.SetRelatedEntities<ait_bloodquantum>(nameof (ait_ait_tribe_ait_bloodquantum_confederatedtribefilter), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_tribe_ait_bloodquantum_confederatedtribefilter));
      }
    }

    [RelationshipSchemaName("ait_ait_tribe_ait_bloodquantum_Tribe")]
    public IEnumerable<ait_bloodquantum> ait_ait_tribe_ait_bloodquantum_Tribe
    {
      get
      {
        return this.GetRelatedEntities<ait_bloodquantum>(nameof (ait_ait_tribe_ait_bloodquantum_Tribe), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_tribe_ait_bloodquantum_Tribe));
        this.SetRelatedEntities<ait_bloodquantum>(nameof (ait_ait_tribe_ait_bloodquantum_Tribe), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_tribe_ait_bloodquantum_Tribe));
      }
    }

    [RelationshipSchemaName("ait_ait_tribe_ait_company_tribeowned")]
    public IEnumerable<ait_company> ait_ait_tribe_ait_company_tribeowned
    {
      get
      {
        return this.GetRelatedEntities<ait_company>(nameof (ait_ait_tribe_ait_company_tribeowned), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_tribe_ait_company_tribeowned));
        this.SetRelatedEntities<ait_company>(nameof (ait_ait_tribe_ait_company_tribeowned), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_tribe_ait_company_tribeowned));
      }
    }

    [RelationshipSchemaName("ait_ait_tribe_ait_memberprofile_tribe")]
    public IEnumerable<ait_memberprofile> ait_ait_tribe_ait_memberprofile_tribe
    {
      get
      {
        return this.GetRelatedEntities<ait_memberprofile>(nameof (ait_ait_tribe_ait_memberprofile_tribe), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_tribe_ait_memberprofile_tribe));
        this.SetRelatedEntities<ait_memberprofile>(nameof (ait_ait_tribe_ait_memberprofile_tribe), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_tribe_ait_memberprofile_tribe));
      }
    }

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

    [RelationshipSchemaName("ait_contact_ait_tribe")]
    public IEnumerable<Contact> ait_contact_ait_tribe
    {
      get => this.GetRelatedEntities<Contact>(nameof (ait_contact_ait_tribe), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_contact_ait_tribe));
        this.SetRelatedEntities<Contact>(nameof (ait_contact_ait_tribe), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contact_ait_tribe));
      }
    }

    [RelationshipSchemaName("ait_tribe_ait_icwaadoption_MemberofTribe")]
    public IEnumerable<ait_icwaadoption> ait_tribe_ait_icwaadoption_MemberofTribe
    {
      get
      {
        return this.GetRelatedEntities<ait_icwaadoption>(nameof (ait_tribe_ait_icwaadoption_MemberofTribe), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_tribe_ait_icwaadoption_MemberofTribe));
        this.SetRelatedEntities<ait_icwaadoption>(nameof (ait_tribe_ait_icwaadoption_MemberofTribe), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_tribe_ait_icwaadoption_MemberofTribe));
      }
    }

    [RelationshipSchemaName("ait_tribe_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_tribe_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_tribe_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_tribe_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_tribe_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_tribe_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_tribe_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_tribe_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_tribe_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_tribe_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_tribe_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_tribe_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_tribe_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_tribe_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_tribe_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_tribe_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_tribe_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_tribe_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_tribe_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_tribe_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_tribe_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_tribe_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_tribe_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_tribe_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_tribe_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_tribe_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_tribe_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_tribe_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_tribe_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_tribe_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_tribe_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_tribe_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_tribe_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_tribe_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_tribe_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_tribe_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_tribe_ProcessSession")]
    public IEnumerable<ProcessSession> ait_tribe_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_tribe_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_tribe_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_tribe_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_tribe_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_tribe_SyncErrors")]
    public IEnumerable<SyncError> ait_tribe_SyncErrors
    {
      get => this.GetRelatedEntities<SyncError>(nameof (ait_tribe_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_tribe_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_tribe_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_tribe_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_tribe_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_tribe_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_tribe_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_tribe_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_tribe_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_tribe_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_address1_city")]
    [RelationshipSchemaName("ait_ait_city_ait_tribe")]
    public ait_city ait_ait_city_ait_tribe
    {
      get => this.GetRelatedEntity<ait_city>(nameof (ait_ait_city_ait_tribe), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_city_ait_tribe));
        this.SetRelatedEntity<ait_city>(nameof (ait_ait_city_ait_tribe), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_city_ait_tribe));
      }
    }

    [AttributeLogicalName("ait_address1_state")]
    [RelationshipSchemaName("ait_ait_stateprovince_ait_tribe")]
    public ait_stateprovince ait_ait_stateprovince_ait_tribe
    {
      get
      {
        return this.GetRelatedEntity<ait_stateprovince>(nameof (ait_ait_stateprovince_ait_tribe), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_stateprovince_ait_tribe));
        this.SetRelatedEntity<ait_stateprovince>(nameof (ait_ait_stateprovince_ait_tribe), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_stateprovince_ait_tribe));
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

    [AttributeLogicalName("ait_address1_zipcode")]
    [RelationshipSchemaName("ait_ait_zipcodecity_ait_tribe")]
    public ait_zipcodecity ait_ait_zipcodecity_ait_tribe
    {
      get
      {
        return this.GetRelatedEntity<ait_zipcodecity>(nameof (ait_ait_zipcodecity_ait_tribe), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_zipcodecity_ait_tribe));
        this.SetRelatedEntity<ait_zipcodecity>(nameof (ait_ait_zipcodecity_ait_tribe), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_zipcodecity_ait_tribe));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_tribe_createdby")]
    public SystemUser lk_ait_tribe_createdby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_ait_tribe_createdby), new EntityRole?());
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_tribe_createdonbehalfby")]
    public SystemUser lk_ait_tribe_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_tribe_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_tribe_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_tribe_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_tribe_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_tribe_modifiedby")]
    public SystemUser lk_ait_tribe_modifiedby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_ait_tribe_modifiedby), new EntityRole?());
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_tribe_modifiedonbehalfby")]
    public SystemUser lk_ait_tribe_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_tribe_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_tribe_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_tribe_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_tribe_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_ait_tribe")]
    public Organization organization_ait_tribe
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_ait_tribe), new EntityRole?());
      }
    }

    public ait_tribe(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_tribeid"] = (object) base.Id;
            break;
          case "ait_tribeid":
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
