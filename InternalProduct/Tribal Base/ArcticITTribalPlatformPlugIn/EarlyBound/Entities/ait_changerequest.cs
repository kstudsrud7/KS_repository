// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_changerequest
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_changerequest")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_changerequest : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_changerequest";
    public const string EntitySchemaName = "ait_changerequest";
    public const string PrimaryIdAttribute = "ait_changerequestid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_changerequest()
      : base(nameof (ait_changerequest))
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

    [AttributeLogicalName("ait_approvalstatus")]
    public OptionSetValue ait_ApprovalStatus
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_approvalstatus");
      set
      {
        this.OnPropertyChanging(nameof (ait_ApprovalStatus));
        this.SetAttributeValue("ait_approvalstatus", (object) value);
        this.OnPropertyChanged(nameof (ait_ApprovalStatus));
      }
    }

    [AttributeLogicalName("ait_changerequestaddresstype")]
    public OptionSetValue ait_ChangeRequestAddressType
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_changerequestaddresstype");
      set
      {
        this.OnPropertyChanging(nameof (ait_ChangeRequestAddressType));
        this.SetAttributeValue("ait_changerequestaddresstype", (object) value);
        this.OnPropertyChanged(nameof (ait_ChangeRequestAddressType));
      }
    }

    [AttributeLogicalName("ait_changerequestid")]
    public Guid? ait_changerequestId
    {
      get => this.GetAttributeValue<Guid?>("ait_changerequestid");
      set
      {
        this.OnPropertyChanging(nameof (ait_changerequestId));
        this.SetAttributeValue("ait_changerequestid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_changerequestId));
      }
    }

    [AttributeLogicalName("ait_changerequestid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_changerequestId = new Guid?(value);
    }

    [AttributeLogicalName("ait_changerequestsource")]
    public OptionSetValue ait_ChangeRequestSource
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_changerequestsource");
      set
      {
        this.OnPropertyChanging(nameof (ait_ChangeRequestSource));
        this.SetAttributeValue("ait_changerequestsource", (object) value);
        this.OnPropertyChanged(nameof (ait_ChangeRequestSource));
      }
    }

    [AttributeLogicalName("ait_city_approved")]
    public EntityReference ait_City_Approved
    {
      get => this.GetAttributeValue<EntityReference>("ait_city_approved");
      set
      {
        this.OnPropertyChanging(nameof (ait_City_Approved));
        this.SetAttributeValue("ait_city_approved", (object) value);
        this.OnPropertyChanged(nameof (ait_City_Approved));
      }
    }

    [AttributeLogicalName("ait_city_user")]
    public string ait_City_User
    {
      get => this.GetAttributeValue<string>("ait_city_user");
      set
      {
        this.OnPropertyChanging(nameof (ait_City_User));
        this.SetAttributeValue("ait_city_user", (object) value);
        this.OnPropertyChanged(nameof (ait_City_User));
      }
    }

    [AttributeLogicalName("ait_contact")]
    public EntityReference ait_Contact
    {
      get => this.GetAttributeValue<EntityReference>("ait_contact");
      set
      {
        this.OnPropertyChanging(nameof (ait_Contact));
        this.SetAttributeValue("ait_contact", (object) value);
        this.OnPropertyChanged(nameof (ait_Contact));
      }
    }

    [AttributeLogicalName("ait_crtype")]
    public EntityReference ait_CRType
    {
      get => this.GetAttributeValue<EntityReference>("ait_crtype");
      set
      {
        this.OnPropertyChanging(nameof (ait_CRType));
        this.SetAttributeValue("ait_crtype", (object) value);
        this.OnPropertyChanged(nameof (ait_CRType));
      }
    }

    [AttributeLogicalName("ait_email_approved")]
    public string ait_Email_Approved
    {
      get => this.GetAttributeValue<string>("ait_email_approved");
      set
      {
        this.OnPropertyChanging(nameof (ait_Email_Approved));
        this.SetAttributeValue("ait_email_approved", (object) value);
        this.OnPropertyChanged(nameof (ait_Email_Approved));
      }
    }

    [AttributeLogicalName("ait_email_electronicaddress")]
    public EntityReference ait_Email_ElectronicAddress
    {
      get => this.GetAttributeValue<EntityReference>("ait_email_electronicaddress");
      set
      {
        this.OnPropertyChanging(nameof (ait_Email_ElectronicAddress));
        this.SetAttributeValue("ait_email_electronicaddress", (object) value);
        this.OnPropertyChanged(nameof (ait_Email_ElectronicAddress));
      }
    }

    [AttributeLogicalName("ait_email_user")]
    public string ait_Email_User
    {
      get => this.GetAttributeValue<string>("ait_email_user");
      set
      {
        this.OnPropertyChanging(nameof (ait_Email_User));
        this.SetAttributeValue("ait_email_user", (object) value);
        this.OnPropertyChanged(nameof (ait_Email_User));
      }
    }

    [AttributeLogicalName("ait_firstname_approved")]
    public string ait_FirstName_Approved
    {
      get => this.GetAttributeValue<string>("ait_firstname_approved");
      set
      {
        this.OnPropertyChanging(nameof (ait_FirstName_Approved));
        this.SetAttributeValue("ait_firstname_approved", (object) value);
        this.OnPropertyChanged(nameof (ait_FirstName_Approved));
      }
    }

    [AttributeLogicalName("ait_firstname_user")]
    public string ait_FirstName_User
    {
      get => this.GetAttributeValue<string>("ait_firstname_user");
      set
      {
        this.OnPropertyChanging(nameof (ait_FirstName_User));
        this.SetAttributeValue("ait_firstname_user", (object) value);
        this.OnPropertyChanged(nameof (ait_FirstName_User));
      }
    }

    [AttributeLogicalName("ait_householdmember")]
    public EntityReference ait_HouseholdMember
    {
      get => this.GetAttributeValue<EntityReference>("ait_householdmember");
      set
      {
        this.OnPropertyChanging(nameof (ait_HouseholdMember));
        this.SetAttributeValue("ait_householdmember", (object) value);
        this.OnPropertyChanged(nameof (ait_HouseholdMember));
      }
    }

    [AttributeLogicalName("ait_lastname_approved")]
    public string ait_LastName_Approved
    {
      get => this.GetAttributeValue<string>("ait_lastname_approved");
      set
      {
        this.OnPropertyChanging(nameof (ait_LastName_Approved));
        this.SetAttributeValue("ait_lastname_approved", (object) value);
        this.OnPropertyChanged(nameof (ait_LastName_Approved));
      }
    }

    [AttributeLogicalName("ait_lastname_user")]
    public string ait_LastName_User
    {
      get => this.GetAttributeValue<string>("ait_lastname_user");
      set
      {
        this.OnPropertyChanging(nameof (ait_LastName_User));
        this.SetAttributeValue("ait_lastname_user", (object) value);
        this.OnPropertyChanged(nameof (ait_LastName_User));
      }
    }

    [AttributeLogicalName("ait_middlename_approved")]
    public string ait_MiddleName_Approved
    {
      get => this.GetAttributeValue<string>("ait_middlename_approved");
      set
      {
        this.OnPropertyChanging(nameof (ait_MiddleName_Approved));
        this.SetAttributeValue("ait_middlename_approved", (object) value);
        this.OnPropertyChanged(nameof (ait_MiddleName_Approved));
      }
    }

    [AttributeLogicalName("ait_middlename_user")]
    public string ait_MiddleName_User
    {
      get => this.GetAttributeValue<string>("ait_middlename_user");
      set
      {
        this.OnPropertyChanging(nameof (ait_MiddleName_User));
        this.SetAttributeValue("ait_middlename_user", (object) value);
        this.OnPropertyChanged(nameof (ait_MiddleName_User));
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

    [AttributeLogicalName("ait_phone_approved")]
    public string ait_Phone_Approved
    {
      get => this.GetAttributeValue<string>("ait_phone_approved");
      set
      {
        this.OnPropertyChanging(nameof (ait_Phone_Approved));
        this.SetAttributeValue("ait_phone_approved", (object) value);
        this.OnPropertyChanged(nameof (ait_Phone_Approved));
      }
    }

    [AttributeLogicalName("ait_phone_electronicaddress")]
    public EntityReference ait_Phone_ElectronicAddress
    {
      get => this.GetAttributeValue<EntityReference>("ait_phone_electronicaddress");
      set
      {
        this.OnPropertyChanging(nameof (ait_Phone_ElectronicAddress));
        this.SetAttributeValue("ait_phone_electronicaddress", (object) value);
        this.OnPropertyChanged(nameof (ait_Phone_ElectronicAddress));
      }
    }

    [AttributeLogicalName("ait_phone_user")]
    public string ait_Phone_User
    {
      get => this.GetAttributeValue<string>("ait_phone_user");
      set
      {
        this.OnPropertyChanging(nameof (ait_Phone_User));
        this.SetAttributeValue("ait_phone_user", (object) value);
        this.OnPropertyChanged(nameof (ait_Phone_User));
      }
    }

    [AttributeLogicalName("ait_physicaladdress")]
    public EntityReference ait_PhysicalAddress
    {
      get => this.GetAttributeValue<EntityReference>("ait_physicaladdress");
      set
      {
        this.OnPropertyChanging(nameof (ait_PhysicalAddress));
        this.SetAttributeValue("ait_physicaladdress", (object) value);
        this.OnPropertyChanged(nameof (ait_PhysicalAddress));
      }
    }

    [AttributeLogicalName("ait_reasonforchange")]
    public string ait_ReasonforChange
    {
      get => this.GetAttributeValue<string>("ait_reasonforchange");
      set
      {
        this.OnPropertyChanging(nameof (ait_ReasonforChange));
        this.SetAttributeValue("ait_reasonforchange", (object) value);
        this.OnPropertyChanged(nameof (ait_ReasonforChange));
      }
    }

    [AttributeLogicalName("ait_relationshiptype")]
    public OptionSetValue ait_RelationshipType
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_relationshiptype");
      set
      {
        this.OnPropertyChanging(nameof (ait_RelationshipType));
        this.SetAttributeValue("ait_relationshiptype", (object) value);
        this.OnPropertyChanged(nameof (ait_RelationshipType));
      }
    }

    [AttributeLogicalName("ait_stateprovince_approved")]
    public EntityReference ait_StateProvince_Approved
    {
      get => this.GetAttributeValue<EntityReference>("ait_stateprovince_approved");
      set
      {
        this.OnPropertyChanging(nameof (ait_StateProvince_Approved));
        this.SetAttributeValue("ait_stateprovince_approved", (object) value);
        this.OnPropertyChanged(nameof (ait_StateProvince_Approved));
      }
    }

    [AttributeLogicalName("ait_stateprovince_user")]
    public string ait_StateProvince_User
    {
      get => this.GetAttributeValue<string>("ait_stateprovince_user");
      set
      {
        this.OnPropertyChanging(nameof (ait_StateProvince_User));
        this.SetAttributeValue("ait_stateprovince_user", (object) value);
        this.OnPropertyChanged(nameof (ait_StateProvince_User));
      }
    }

    [AttributeLogicalName("ait_statuschangedate")]
    public DateTime? ait_StatusChangeDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_statuschangedate");
      set
      {
        this.OnPropertyChanging(nameof (ait_StatusChangeDate));
        this.SetAttributeValue("ait_statuschangedate", (object) value);
        this.OnPropertyChanged(nameof (ait_StatusChangeDate));
      }
    }

    [AttributeLogicalName("ait_street1_approved")]
    public string ait_Street1_Approved
    {
      get => this.GetAttributeValue<string>("ait_street1_approved");
      set
      {
        this.OnPropertyChanging(nameof (ait_Street1_Approved));
        this.SetAttributeValue("ait_street1_approved", (object) value);
        this.OnPropertyChanged(nameof (ait_Street1_Approved));
      }
    }

    [AttributeLogicalName("ait_street1_user")]
    public string ait_Street1_User
    {
      get => this.GetAttributeValue<string>("ait_street1_user");
      set
      {
        this.OnPropertyChanging(nameof (ait_Street1_User));
        this.SetAttributeValue("ait_street1_user", (object) value);
        this.OnPropertyChanged(nameof (ait_Street1_User));
      }
    }

    [AttributeLogicalName("ait_street2_approved")]
    public string ait_Street2_Approved
    {
      get => this.GetAttributeValue<string>("ait_street2_approved");
      set
      {
        this.OnPropertyChanging(nameof (ait_Street2_Approved));
        this.SetAttributeValue("ait_street2_approved", (object) value);
        this.OnPropertyChanged(nameof (ait_Street2_Approved));
      }
    }

    [AttributeLogicalName("ait_street2_user")]
    public string ait_Street2_User
    {
      get => this.GetAttributeValue<string>("ait_street2_user");
      set
      {
        this.OnPropertyChanging(nameof (ait_Street2_User));
        this.SetAttributeValue("ait_street2_user", (object) value);
        this.OnPropertyChanged(nameof (ait_Street2_User));
      }
    }

    [AttributeLogicalName("ait_street3_approved")]
    public string ait_Street3_Approved
    {
      get => this.GetAttributeValue<string>("ait_street3_approved");
      set
      {
        this.OnPropertyChanging(nameof (ait_Street3_Approved));
        this.SetAttributeValue("ait_street3_approved", (object) value);
        this.OnPropertyChanged(nameof (ait_Street3_Approved));
      }
    }

    [AttributeLogicalName("ait_street3_user")]
    public string ait_Street3_User
    {
      get => this.GetAttributeValue<string>("ait_street3_user");
      set
      {
        this.OnPropertyChanging(nameof (ait_Street3_User));
        this.SetAttributeValue("ait_street3_user", (object) value);
        this.OnPropertyChanged(nameof (ait_Street3_User));
      }
    }

    [AttributeLogicalName("ait_summarynotes")]
    public string ait_SummaryNotes
    {
      get => this.GetAttributeValue<string>("ait_summarynotes");
      set
      {
        this.OnPropertyChanging(nameof (ait_SummaryNotes));
        this.SetAttributeValue("ait_summarynotes", (object) value);
        this.OnPropertyChanged(nameof (ait_SummaryNotes));
      }
    }

    [AttributeLogicalName("ait_zipcode_approved")]
    public EntityReference ait_ZipCode_Approved
    {
      get => this.GetAttributeValue<EntityReference>("ait_zipcode_approved");
      set
      {
        this.OnPropertyChanging(nameof (ait_ZipCode_Approved));
        this.SetAttributeValue("ait_zipcode_approved", (object) value);
        this.OnPropertyChanged(nameof (ait_ZipCode_Approved));
      }
    }

    [AttributeLogicalName("ait_zipcode_user")]
    public string ait_ZipCode_User
    {
      get => this.GetAttributeValue<string>("ait_zipcode_user");
      set
      {
        this.OnPropertyChanging(nameof (ait_ZipCode_User));
        this.SetAttributeValue("ait_zipcode_user", (object) value);
        this.OnPropertyChanged(nameof (ait_ZipCode_User));
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
    public ait_changerequestState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_changerequestState?((ait_changerequestState) Enum.ToObject(typeof (ait_changerequestState), attributeValue.Value)) : new ait_changerequestState?();
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

    [RelationshipSchemaName("ait_changerequest_ActivityParties")]
    public IEnumerable<ActivityParty> ait_changerequest_ActivityParties
    {
      get
      {
        return this.GetRelatedEntities<ActivityParty>(nameof (ait_changerequest_ActivityParties), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_changerequest_ActivityParties));
        this.SetRelatedEntities<ActivityParty>(nameof (ait_changerequest_ActivityParties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_changerequest_ActivityParties));
      }
    }

    [RelationshipSchemaName("ait_changerequest_ActivityPointers")]
    public IEnumerable<ActivityPointer> ait_changerequest_ActivityPointers
    {
      get
      {
        return this.GetRelatedEntities<ActivityPointer>(nameof (ait_changerequest_ActivityPointers), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_changerequest_ActivityPointers));
        this.SetRelatedEntities<ActivityPointer>(nameof (ait_changerequest_ActivityPointers), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_changerequest_ActivityPointers));
      }
    }

    [RelationshipSchemaName("ait_changerequest_Annotations")]
    public IEnumerable<Annotation> ait_changerequest_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (ait_changerequest_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_changerequest_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (ait_changerequest_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_changerequest_Annotations));
      }
    }

    [RelationshipSchemaName("ait_changerequest_Appointments")]
    public IEnumerable<Appointment> ait_changerequest_Appointments
    {
      get
      {
        return this.GetRelatedEntities<Appointment>(nameof (ait_changerequest_Appointments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_changerequest_Appointments));
        this.SetRelatedEntities<Appointment>(nameof (ait_changerequest_Appointments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_changerequest_Appointments));
      }
    }

    [RelationshipSchemaName("ait_changerequest_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_changerequest_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_changerequest_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_changerequest_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_changerequest_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_changerequest_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_changerequest_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_changerequest_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_changerequest_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_changerequest_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_changerequest_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_changerequest_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_changerequest_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_changerequest_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_changerequest_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_changerequest_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_changerequest_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_changerequest_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_changerequest_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_changerequest_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_changerequest_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_changerequest_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_changerequest_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_changerequest_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_changerequest_Emails")]
    public IEnumerable<Email> ait_changerequest_Emails
    {
      get => this.GetRelatedEntities<Email>(nameof (ait_changerequest_Emails), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_changerequest_Emails));
        this.SetRelatedEntities<Email>(nameof (ait_changerequest_Emails), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_changerequest_Emails));
      }
    }

    [RelationshipSchemaName("ait_changerequest_Faxes")]
    public IEnumerable<Fax> ait_changerequest_Faxes
    {
      get => this.GetRelatedEntities<Fax>(nameof (ait_changerequest_Faxes), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_changerequest_Faxes));
        this.SetRelatedEntities<Fax>(nameof (ait_changerequest_Faxes), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_changerequest_Faxes));
      }
    }

    [RelationshipSchemaName("ait_changerequest_Letters")]
    public IEnumerable<Letter> ait_changerequest_Letters
    {
      get => this.GetRelatedEntities<Letter>(nameof (ait_changerequest_Letters), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_changerequest_Letters));
        this.SetRelatedEntities<Letter>(nameof (ait_changerequest_Letters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_changerequest_Letters));
      }
    }

    [RelationshipSchemaName("ait_changerequest_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_changerequest_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_changerequest_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_changerequest_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_changerequest_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_changerequest_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_changerequest_PhoneCalls")]
    public IEnumerable<PhoneCall> ait_changerequest_PhoneCalls
    {
      get
      {
        return this.GetRelatedEntities<PhoneCall>(nameof (ait_changerequest_PhoneCalls), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_changerequest_PhoneCalls));
        this.SetRelatedEntities<PhoneCall>(nameof (ait_changerequest_PhoneCalls), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_changerequest_PhoneCalls));
      }
    }

    [RelationshipSchemaName("ait_changerequest_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_changerequest_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_changerequest_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_changerequest_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_changerequest_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_changerequest_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_changerequest_ProcessSession")]
    public IEnumerable<ProcessSession> ait_changerequest_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_changerequest_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_changerequest_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_changerequest_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_changerequest_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_changerequest_RecurringAppointmentMasters")]
    public IEnumerable<RecurringAppointmentMaster> ait_changerequest_RecurringAppointmentMasters
    {
      get
      {
        return this.GetRelatedEntities<RecurringAppointmentMaster>(nameof (ait_changerequest_RecurringAppointmentMasters), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_changerequest_RecurringAppointmentMasters));
        this.SetRelatedEntities<RecurringAppointmentMaster>(nameof (ait_changerequest_RecurringAppointmentMasters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_changerequest_RecurringAppointmentMasters));
      }
    }

    [RelationshipSchemaName("ait_changerequest_SocialActivities")]
    public IEnumerable<SocialActivity> ait_changerequest_SocialActivities
    {
      get
      {
        return this.GetRelatedEntities<SocialActivity>(nameof (ait_changerequest_SocialActivities), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_changerequest_SocialActivities));
        this.SetRelatedEntities<SocialActivity>(nameof (ait_changerequest_SocialActivities), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_changerequest_SocialActivities));
      }
    }

    [RelationshipSchemaName("ait_changerequest_SyncErrors")]
    public IEnumerable<SyncError> ait_changerequest_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_changerequest_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_changerequest_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_changerequest_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_changerequest_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_changerequest_Tasks")]
    public IEnumerable<Task> ait_changerequest_Tasks
    {
      get => this.GetRelatedEntities<Task>(nameof (ait_changerequest_Tasks), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_changerequest_Tasks));
        this.SetRelatedEntities<Task>(nameof (ait_changerequest_Tasks), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_changerequest_Tasks));
      }
    }

    [RelationshipSchemaName("ait_changerequest_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_changerequest_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_changerequest_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_changerequest_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_changerequest_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_changerequest_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_crtype")]
    [RelationshipSchemaName("ait_ait_changerequesttype_ait_changerequest_CRType")]
    public ait_changerequesttype ait_ait_changerequesttype_ait_changerequest_CRType
    {
      get
      {
        return this.GetRelatedEntity<ait_changerequesttype>(nameof (ait_ait_changerequesttype_ait_changerequest_CRType), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_changerequesttype_ait_changerequest_CRType));
        this.SetRelatedEntity<ait_changerequesttype>(nameof (ait_ait_changerequesttype_ait_changerequest_CRType), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_changerequesttype_ait_changerequest_CRType));
      }
    }

    [AttributeLogicalName("ait_city_approved")]
    [RelationshipSchemaName("ait_ait_city_ait_changerequest_City_Approved")]
    public ait_city ait_ait_city_ait_changerequest_City_Approved
    {
      get
      {
        return this.GetRelatedEntity<ait_city>(nameof (ait_ait_city_ait_changerequest_City_Approved), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_city_ait_changerequest_City_Approved));
        this.SetRelatedEntity<ait_city>(nameof (ait_ait_city_ait_changerequest_City_Approved), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_city_ait_changerequest_City_Approved));
      }
    }

    [AttributeLogicalName("ait_householdmember")]
    [RelationshipSchemaName("ait_ait_householdmember_ait_changerequest_HouseholdMember")]
    public ait_householdmember ait_ait_householdmember_ait_changerequest_HouseholdMember
    {
      get
      {
        return this.GetRelatedEntity<ait_householdmember>(nameof (ait_ait_householdmember_ait_changerequest_HouseholdMember), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_householdmember_ait_changerequest_HouseholdMember));
        this.SetRelatedEntity<ait_householdmember>(nameof (ait_ait_householdmember_ait_changerequest_HouseholdMember), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_householdmember_ait_changerequest_HouseholdMember));
      }
    }

    [AttributeLogicalName("ait_physicaladdress")]
    [RelationshipSchemaName("ait_ait_physicaladdress_ait_changerequest_PhysicalAddress")]
    public ait_physicaladdress ait_ait_physicaladdress_ait_changerequest_PhysicalAddress
    {
      get
      {
        return this.GetRelatedEntity<ait_physicaladdress>(nameof (ait_ait_physicaladdress_ait_changerequest_PhysicalAddress), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_physicaladdress_ait_changerequest_PhysicalAddress));
        this.SetRelatedEntity<ait_physicaladdress>(nameof (ait_ait_physicaladdress_ait_changerequest_PhysicalAddress), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_physicaladdress_ait_changerequest_PhysicalAddress));
      }
    }

    [AttributeLogicalName("ait_stateprovince_approved")]
    [RelationshipSchemaName("ait_ait_stateprovince_ait_changerequest_StateProvince_Approved")]
    public ait_stateprovince ait_ait_stateprovince_ait_changerequest_StateProvince_Approved
    {
      get
      {
        return this.GetRelatedEntity<ait_stateprovince>(nameof (ait_ait_stateprovince_ait_changerequest_StateProvince_Approved), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_stateprovince_ait_changerequest_StateProvince_Approved));
        this.SetRelatedEntity<ait_stateprovince>(nameof (ait_ait_stateprovince_ait_changerequest_StateProvince_Approved), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_stateprovince_ait_changerequest_StateProvince_Approved));
      }
    }

    [AttributeLogicalName("ait_zipcode_approved")]
    [RelationshipSchemaName("ait_ait_zipcodecity_ait_changerequest_ZipCode_Approved")]
    public ait_zipcodecity ait_ait_zipcodecity_ait_changerequest_ZipCode_Approved
    {
      get
      {
        return this.GetRelatedEntity<ait_zipcodecity>(nameof (ait_ait_zipcodecity_ait_changerequest_ZipCode_Approved), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_zipcodecity_ait_changerequest_ZipCode_Approved));
        this.SetRelatedEntity<ait_zipcodecity>(nameof (ait_ait_zipcodecity_ait_changerequest_ZipCode_Approved), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_zipcodecity_ait_changerequest_ZipCode_Approved));
      }
    }

    [AttributeLogicalName("ait_contact")]
    [RelationshipSchemaName("ait_contact_ait_changerequest_Contact")]
    public Contact ait_contact_ait_changerequest_Contact
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (ait_contact_ait_changerequest_Contact), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contact_ait_changerequest_Contact));
        this.SetRelatedEntity<Contact>(nameof (ait_contact_ait_changerequest_Contact), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contact_ait_changerequest_Contact));
      }
    }

    [AttributeLogicalName("ait_email_electronicaddress")]
    [RelationshipSchemaName("ait_email_electronicaddress_ait_changerequest_Email_ElectronicAddress")]
    public ait_electronicaddress ait_email_electronicaddress_ait_changerequest_Email_ElectronicAddress
    {
      get
      {
        return this.GetRelatedEntity<ait_electronicaddress>(nameof (ait_email_electronicaddress_ait_changerequest_Email_ElectronicAddress), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_email_electronicaddress_ait_changerequest_Email_ElectronicAddress));
        this.SetRelatedEntity<ait_electronicaddress>(nameof (ait_email_electronicaddress_ait_changerequest_Email_ElectronicAddress), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_email_electronicaddress_ait_changerequest_Email_ElectronicAddress));
      }
    }

    [AttributeLogicalName("ait_phone_electronicaddress")]
    [RelationshipSchemaName("ait_phone_electronicaddress_ait_changerequest_Phone_ElectronicAddress")]
    public ait_electronicaddress ait_phone_electronicaddress_ait_changerequest_Phone_ElectronicAddress
    {
      get
      {
        return this.GetRelatedEntity<ait_electronicaddress>(nameof (ait_phone_electronicaddress_ait_changerequest_Phone_ElectronicAddress), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_phone_electronicaddress_ait_changerequest_Phone_ElectronicAddress));
        this.SetRelatedEntity<ait_electronicaddress>(nameof (ait_phone_electronicaddress_ait_changerequest_Phone_ElectronicAddress), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_phone_electronicaddress_ait_changerequest_Phone_ElectronicAddress));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_changerequest")]
    public BusinessUnit business_unit_ait_changerequest
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_changerequest), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_changerequest_createdby")]
    public SystemUser lk_ait_changerequest_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_changerequest_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_changerequest_createdonbehalfby")]
    public SystemUser lk_ait_changerequest_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_changerequest_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_changerequest_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_changerequest_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_changerequest_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_changerequest_modifiedby")]
    public SystemUser lk_ait_changerequest_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_changerequest_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_changerequest_modifiedonbehalfby")]
    public SystemUser lk_ait_changerequest_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_changerequest_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_changerequest_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_changerequest_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_changerequest_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_changerequest")]
    public Team team_ait_changerequest
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_changerequest), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_changerequest")]
    public SystemUser user_ait_changerequest
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_ait_changerequest), new EntityRole?());
    }

    public ait_changerequest(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_changerequestid"] = (object) base.Id;
            break;
          case "ait_changerequestid":
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
