// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EarlyBound.ait_familygroup
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_familygroup")]
  [GeneratedCode("CrmSvcUtil", "9.0.0.9154")]
  public class ait_familygroup : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_familygroup";
    public const int EntityTypeCode = 10647;

    public ait_familygroup()
      : base(nameof (ait_familygroup))
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

    [AttributeLogicalName("ait_familygroup_autoid")]
    public string ait_FamilyGroup_AutoID
    {
      get => this.GetAttributeValue<string>("ait_familygroup_autoid");
      set
      {
        this.OnPropertyChanging(nameof (ait_FamilyGroup_AutoID));
        this.SetAttributeValue("ait_familygroup_autoid", (object) value);
        this.OnPropertyChanged(nameof (ait_FamilyGroup_AutoID));
      }
    }

    [AttributeLogicalName("ait_familygroupid")]
    public Guid? ait_familygroupId
    {
      get => this.GetAttributeValue<Guid?>("ait_familygroupid");
      set
      {
        this.OnPropertyChanging(nameof (ait_familygroupId));
        this.SetAttributeValue("ait_familygroupid", (object) value);
        this.OnPropertyChanged(nameof (ait_familygroupId));
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

    [AttributeLogicalName("ait_primarycontact")]
    public EntityReference ait_PrimaryContact
    {
      get => this.GetAttributeValue<EntityReference>("ait_primarycontact");
      set
      {
        this.OnPropertyChanging(nameof (ait_PrimaryContact));
        this.SetAttributeValue("ait_primarycontact", (object) value);
        this.OnPropertyChanged(nameof (ait_PrimaryContact));
      }
    }

    [AttributeLogicalName("ait_primarycontactname")]
    public string ait_PrimaryContactName
    {
      get => this.GetAttributeValue<string>("ait_primarycontactname");
    }

    [AttributeLogicalName("ait_primarycontacttribalmember")]
    public string ait_PrimaryContactTribalMember
    {
      get => this.GetAttributeValue<string>("ait_primarycontacttribalmember");
      set
      {
        this.OnPropertyChanging(nameof (ait_PrimaryContactTribalMember));
        this.SetAttributeValue("ait_primarycontacttribalmember", (object) value);
        this.OnPropertyChanged(nameof (ait_PrimaryContactTribalMember));
      }
    }

    [AttributeLogicalName("ait_primarycontactyominame")]
    public string ait_PrimaryContactYomiName
    {
      get => this.GetAttributeValue<string>("ait_primarycontactyominame");
    }

    [AttributeLogicalName("ait_totaladults")]
    public int? ait_TotalAdults => this.GetAttributeValue<int?>("ait_totaladults");

    [AttributeLogicalName("ait_totaladults_date")]
    public DateTime? ait_TotalAdults_Date
    {
      get => this.GetAttributeValue<DateTime?>("ait_totaladults_date");
    }

    [AttributeLogicalName("ait_totaladults_state")]
    public int? ait_TotalAdults_State => this.GetAttributeValue<int?>("ait_totaladults_state");

    [AttributeLogicalName("ait_totalfamilymembers")]
    public int? ait_TotalFamilyMembers => this.GetAttributeValue<int?>("ait_totalfamilymembers");

    [AttributeLogicalName("ait_totalfamilymembers_date")]
    public DateTime? ait_TotalFamilyMembers_Date
    {
      get => this.GetAttributeValue<DateTime?>("ait_totalfamilymembers_date");
    }

    [AttributeLogicalName("ait_totalfamilymembers_state")]
    public int? ait_TotalFamilyMembers_State
    {
      get => this.GetAttributeValue<int?>("ait_totalfamilymembers_state");
    }

    [AttributeLogicalName("ait_totalminor")]
    public int? ait_TotalMinor
    {
      get => this.GetAttributeValue<int?>("ait_totalminor");
      set
      {
        this.OnPropertyChanging(nameof (ait_TotalMinor));
        this.SetAttributeValue("ait_totalminor", (object) value);
        this.OnPropertyChanged(nameof (ait_TotalMinor));
      }
    }

    [AttributeLogicalName("ait_totalminor_date")]
    public DateTime? ait_TotalMinor_Date
    {
      get => this.GetAttributeValue<DateTime?>("ait_totalminor_date");
    }

    [AttributeLogicalName("ait_totalminor_state")]
    public int? ait_TotalMinor_State => this.GetAttributeValue<int?>("ait_totalminor_state");

    [AttributeLogicalName("ait_totalsenior")]
    public int? ait_TotalSenior
    {
      get => this.GetAttributeValue<int?>("ait_totalsenior");
      set
      {
        this.OnPropertyChanging(nameof (ait_TotalSenior));
        this.SetAttributeValue("ait_totalsenior", (object) value);
        this.OnPropertyChanged(nameof (ait_TotalSenior));
      }
    }

    [AttributeLogicalName("ait_totalsenior_date")]
    public DateTime? ait_TotalSenior_Date
    {
      get => this.GetAttributeValue<DateTime?>("ait_totalsenior_date");
    }

    [AttributeLogicalName("ait_totalsenior_state")]
    public int? ait_TotalSenior_State => this.GetAttributeValue<int?>("ait_totalsenior_state");

    [AttributeLogicalName("createdby")]
    public EntityReference CreatedBy => this.GetAttributeValue<EntityReference>("createdby");

    [AttributeLogicalName("createdbyname")]
    public string CreatedByName => this.GetAttributeValue<string>("createdbyname");

    [AttributeLogicalName("createdbyyominame")]
    public string CreatedByYomiName => this.GetAttributeValue<string>("createdbyyominame");

    [AttributeLogicalName("createdon")]
    public DateTime? CreatedOn => this.GetAttributeValue<DateTime?>("createdon");

    [AttributeLogicalName("createdonbehalfby")]
    public EntityReference CreatedOnBehalfBy
    {
      get => this.GetAttributeValue<EntityReference>("createdonbehalfby");
    }

    [AttributeLogicalName("createdonbehalfbyname")]
    public string CreatedOnBehalfByName => this.GetAttributeValue<string>("createdonbehalfbyname");

    [AttributeLogicalName("createdonbehalfbyyominame")]
    public string CreatedOnBehalfByYomiName
    {
      get => this.GetAttributeValue<string>("createdonbehalfbyyominame");
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

    [AttributeLogicalName("modifiedbyname")]
    public string ModifiedByName => this.GetAttributeValue<string>("modifiedbyname");

    [AttributeLogicalName("modifiedbyyominame")]
    public string ModifiedByYomiName => this.GetAttributeValue<string>("modifiedbyyominame");

    [AttributeLogicalName("modifiedon")]
    public DateTime? ModifiedOn => this.GetAttributeValue<DateTime?>("modifiedon");

    [AttributeLogicalName("modifiedonbehalfby")]
    public EntityReference ModifiedOnBehalfBy
    {
      get => this.GetAttributeValue<EntityReference>("modifiedonbehalfby");
    }

    [AttributeLogicalName("modifiedonbehalfbyname")]
    public string ModifiedOnBehalfByName
    {
      get => this.GetAttributeValue<string>("modifiedonbehalfbyname");
    }

    [AttributeLogicalName("modifiedonbehalfbyyominame")]
    public string ModifiedOnBehalfByYomiName
    {
      get => this.GetAttributeValue<string>("modifiedonbehalfbyyominame");
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

    [AttributeLogicalName("owneridname")]
    public string OwnerIdName => this.GetAttributeValue<string>("owneridname");

    [AttributeLogicalName("owneridtype")]
    public string OwnerIdType
    {
      get => this.GetAttributeValue<string>("owneridtype");
      set
      {
        this.OnPropertyChanging(nameof (OwnerIdType));
        this.SetAttributeValue("owneridtype", (object) value);
        this.OnPropertyChanged(nameof (OwnerIdType));
      }
    }

    [AttributeLogicalName("owneridyominame")]
    public string OwnerIdYomiName => this.GetAttributeValue<string>("owneridyominame");

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
    public Ait_familygroupState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new Ait_familygroupState?((Ait_familygroupState) Enum.ToObject(typeof (Ait_familygroupState), attributeValue.Value)) : new Ait_familygroupState?();
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

    [AttributeLogicalName("statecodename")]
    public object statecodeName => this.GetAttributeValue<object>("statecodename");

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

    [AttributeLogicalName("statuscodename")]
    public object statuscodeName => this.GetAttributeValue<object>("statuscodename");

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

    [RelationshipSchemaName("ait_ait_familygroup_ait_assessment_FamilyGroup")]
    public IEnumerable<ait_assessment> ait_ait_familygroup_ait_assessment_FamilyGroup
    {
      get
      {
        return this.GetRelatedEntities<ait_assessment>(nameof (ait_ait_familygroup_ait_assessment_FamilyGroup), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_familygroup_ait_assessment_FamilyGroup));
        this.SetRelatedEntities<ait_assessment>(nameof (ait_ait_familygroup_ait_assessment_FamilyGroup), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_familygroup_ait_assessment_FamilyGroup));
      }
    }

    [RelationshipSchemaName("ait_ait_familygroup_ait_placement_FamilyGroup")]
    public IEnumerable<ait_placement> ait_ait_familygroup_ait_placement_FamilyGroup
    {
      get
      {
        return this.GetRelatedEntities<ait_placement>(nameof (ait_ait_familygroup_ait_placement_FamilyGroup), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_familygroup_ait_placement_FamilyGroup));
        this.SetRelatedEntities<ait_placement>(nameof (ait_ait_familygroup_ait_placement_FamilyGroup), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_familygroup_ait_placement_FamilyGroup));
      }
    }

    [RelationshipSchemaName("ait_ait_familygroup_ait_planactivity_FamilyGroup")]
    public IEnumerable<ait_planactivity> ait_ait_familygroup_ait_planactivity_FamilyGroup
    {
      get
      {
        return this.GetRelatedEntities<ait_planactivity>(nameof (ait_ait_familygroup_ait_planactivity_FamilyGroup), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_familygroup_ait_planactivity_FamilyGroup));
        this.SetRelatedEntities<ait_planactivity>(nameof (ait_ait_familygroup_ait_planactivity_FamilyGroup), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_familygroup_ait_planactivity_FamilyGroup));
      }
    }

    [RelationshipSchemaName("ait_ait_familygroup_ait_referral_FamilyGroup")]
    public IEnumerable<ait_referral> ait_ait_familygroup_ait_referral_FamilyGroup
    {
      get
      {
        return this.GetRelatedEntities<ait_referral>(nameof (ait_ait_familygroup_ait_referral_FamilyGroup), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_familygroup_ait_referral_FamilyGroup));
        this.SetRelatedEntities<ait_referral>(nameof (ait_ait_familygroup_ait_referral_FamilyGroup), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_familygroup_ait_referral_FamilyGroup));
      }
    }

    [RelationshipSchemaName("ait_ait_familygroup_appointment_FamilyGroup")]
    public IEnumerable<Appointment> ait_ait_familygroup_appointment_FamilyGroup
    {
      get
      {
        return this.GetRelatedEntities<Appointment>(nameof (ait_ait_familygroup_appointment_FamilyGroup), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_familygroup_appointment_FamilyGroup));
        this.SetRelatedEntities<Appointment>(nameof (ait_ait_familygroup_appointment_FamilyGroup), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_familygroup_appointment_FamilyGroup));
      }
    }

    [RelationshipSchemaName("ait_ait_familygroup_email_FamilyGroup")]
    public IEnumerable<Email> ait_ait_familygroup_email_FamilyGroup
    {
      get
      {
        return this.GetRelatedEntities<Email>(nameof (ait_ait_familygroup_email_FamilyGroup), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_familygroup_email_FamilyGroup));
        this.SetRelatedEntities<Email>(nameof (ait_ait_familygroup_email_FamilyGroup), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_familygroup_email_FamilyGroup));
      }
    }

    [RelationshipSchemaName("ait_ait_familygroup_phonecall_FamilyGroup")]
    public IEnumerable<PhoneCall> ait_ait_familygroup_phonecall_FamilyGroup
    {
      get
      {
        return this.GetRelatedEntities<PhoneCall>(nameof (ait_ait_familygroup_phonecall_FamilyGroup), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_familygroup_phonecall_FamilyGroup));
        this.SetRelatedEntities<PhoneCall>(nameof (ait_ait_familygroup_phonecall_FamilyGroup), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_familygroup_phonecall_FamilyGroup));
      }
    }

    [RelationshipSchemaName("ait_ait_familygroup_task_FamilyGroup")]
    public IEnumerable<Task> ait_ait_familygroup_task_FamilyGroup
    {
      get
      {
        return this.GetRelatedEntities<Task>(nameof (ait_ait_familygroup_task_FamilyGroup), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_familygroup_task_FamilyGroup));
        this.SetRelatedEntities<Task>(nameof (ait_ait_familygroup_task_FamilyGroup), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_familygroup_task_FamilyGroup));
      }
    }

    [RelationshipSchemaName("ait_familygroup_ait_casenotefamilywellness_FamilyGroup")]
    public IEnumerable<ait_casenotefamilywellness> ait_familygroup_ait_casenotefamilywellness_FamilyGroup
    {
      get
      {
        return this.GetRelatedEntities<ait_casenotefamilywellness>(nameof (ait_familygroup_ait_casenotefamilywellness_FamilyGroup), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familygroup_ait_casenotefamilywellness_FamilyGroup));
        this.SetRelatedEntities<ait_casenotefamilywellness>(nameof (ait_familygroup_ait_casenotefamilywellness_FamilyGroup), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familygroup_ait_casenotefamilywellness_FamilyGroup));
      }
    }

    [RelationshipSchemaName("ait_familygroup_ait_caseplan_FamilyGroup")]
    public IEnumerable<ait_caseplan> ait_familygroup_ait_caseplan_FamilyGroup
    {
      get
      {
        return this.GetRelatedEntities<ait_caseplan>(nameof (ait_familygroup_ait_caseplan_FamilyGroup), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familygroup_ait_caseplan_FamilyGroup));
        this.SetRelatedEntities<ait_caseplan>(nameof (ait_familygroup_ait_caseplan_FamilyGroup), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familygroup_ait_caseplan_FamilyGroup));
      }
    }

    [RelationshipSchemaName("ait_familygroup_ait_goal_FamilyGroup")]
    public IEnumerable<ait_goal> ait_familygroup_ait_goal_FamilyGroup
    {
      get
      {
        return this.GetRelatedEntities<ait_goal>(nameof (ait_familygroup_ait_goal_FamilyGroup), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familygroup_ait_goal_FamilyGroup));
        this.SetRelatedEntities<ait_goal>(nameof (ait_familygroup_ait_goal_FamilyGroup), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familygroup_ait_goal_FamilyGroup));
      }
    }

    [RelationshipSchemaName("ait_familygroup_ait_servicerequest_FamilyGroup")]
    public IEnumerable<ait_servicerequest> ait_familygroup_ait_servicerequest_FamilyGroup
    {
      get
      {
        return this.GetRelatedEntities<ait_servicerequest>(nameof (ait_familygroup_ait_servicerequest_FamilyGroup), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familygroup_ait_servicerequest_FamilyGroup));
        this.SetRelatedEntities<ait_servicerequest>(nameof (ait_familygroup_ait_servicerequest_FamilyGroup), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familygroup_ait_servicerequest_FamilyGroup));
      }
    }

    [RelationshipSchemaName("ait_familygroup_Appointments")]
    public IEnumerable<Appointment> ait_familygroup_Appointments
    {
      get
      {
        return this.GetRelatedEntities<Appointment>(nameof (ait_familygroup_Appointments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familygroup_Appointments));
        this.SetRelatedEntities<Appointment>(nameof (ait_familygroup_Appointments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familygroup_Appointments));
      }
    }

    [RelationshipSchemaName("ait_familygroup_contact_familygroup")]
    public IEnumerable<Contact> ait_familygroup_contact_familygroup
    {
      get
      {
        return this.GetRelatedEntities<Contact>(nameof (ait_familygroup_contact_familygroup), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familygroup_contact_familygroup));
        this.SetRelatedEntities<Contact>(nameof (ait_familygroup_contact_familygroup), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familygroup_contact_familygroup));
      }
    }

    [RelationshipSchemaName("ait_familygroup_Emails")]
    public IEnumerable<Email> ait_familygroup_Emails
    {
      get => this.GetRelatedEntities<Email>(nameof (ait_familygroup_Emails), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_familygroup_Emails));
        this.SetRelatedEntities<Email>(nameof (ait_familygroup_Emails), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familygroup_Emails));
      }
    }

    [RelationshipSchemaName("ait_familygroup_PhoneCalls")]
    public IEnumerable<PhoneCall> ait_familygroup_PhoneCalls
    {
      get
      {
        return this.GetRelatedEntities<PhoneCall>(nameof (ait_familygroup_PhoneCalls), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familygroup_PhoneCalls));
        this.SetRelatedEntities<PhoneCall>(nameof (ait_familygroup_PhoneCalls), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familygroup_PhoneCalls));
      }
    }

    [RelationshipSchemaName("ait_familygroup_Tasks")]
    public IEnumerable<Task> ait_familygroup_Tasks
    {
      get => this.GetRelatedEntities<Task>(nameof (ait_familygroup_Tasks), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_familygroup_Tasks));
        this.SetRelatedEntities<Task>(nameof (ait_familygroup_Tasks), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familygroup_Tasks));
      }
    }

    [AttributeLogicalName("ait_primarycontact")]
    [RelationshipSchemaName("ait_contact_ait_familygroup_PrimaryContact")]
    public Contact ait_contact_ait_familygroup_PrimaryContact
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (ait_contact_ait_familygroup_PrimaryContact), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contact_ait_familygroup_PrimaryContact));
        this.SetRelatedEntity<Contact>(nameof (ait_contact_ait_familygroup_PrimaryContact), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contact_ait_familygroup_PrimaryContact));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_familygroup")]
    public BusinessUnit business_unit_ait_familygroup
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_familygroup), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_familygroup_createdby")]
    public SystemUser lk_ait_familygroup_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_familygroup_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_familygroup_createdonbehalfby")]
    public SystemUser lk_ait_familygroup_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_familygroup_createdonbehalfby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_familygroup_modifiedby")]
    public SystemUser lk_ait_familygroup_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_familygroup_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_familygroup_modifiedonbehalfby")]
    public SystemUser lk_ait_familygroup_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_familygroup_modifiedonbehalfby), new EntityRole?());
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_familygroup")]
    public Team team_ait_familygroup
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_familygroup), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_familygroup")]
    public SystemUser user_ait_familygroup
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_ait_familygroup), new EntityRole?());
    }
  }
}
