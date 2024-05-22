// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_familygroup
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_familygroup")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_familygroup : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_familygroup";
    public const string EntitySchemaName = "ait_familygroup";
    public const string PrimaryIdAttribute = "ait_familygroupid";
    public const string PrimaryNameAttribute = "ait_name";

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
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_familygroupId));
      }
    }

    [AttributeLogicalName("ait_familygroupid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_familygroupId = new Guid?(value);
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
    public ait_familygroupState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_familygroupState?((ait_familygroupState) Enum.ToObject(typeof (ait_familygroupState), attributeValue.Value)) : new ait_familygroupState?();
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

    [RelationshipSchemaName("ait_ait_familygroup_ait_casenote_FamilyGroup")]
    public IEnumerable<ait_casenote> ait_ait_familygroup_ait_casenote_FamilyGroup
    {
      get
      {
        return this.GetRelatedEntities<ait_casenote>(nameof (ait_ait_familygroup_ait_casenote_FamilyGroup), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_familygroup_ait_casenote_FamilyGroup));
        this.SetRelatedEntities<ait_casenote>(nameof (ait_ait_familygroup_ait_casenote_FamilyGroup), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_familygroup_ait_casenote_FamilyGroup));
      }
    }

    [RelationshipSchemaName("ait_ait_familygroup_ait_outcome_FamilyGroup")]
    public IEnumerable<ait_outcome> ait_ait_familygroup_ait_outcome_FamilyGroup
    {
      get
      {
        return this.GetRelatedEntities<ait_outcome>(nameof (ait_ait_familygroup_ait_outcome_FamilyGroup), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_familygroup_ait_outcome_FamilyGroup));
        this.SetRelatedEntities<ait_outcome>(nameof (ait_ait_familygroup_ait_outcome_FamilyGroup), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_familygroup_ait_outcome_FamilyGroup));
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

    [RelationshipSchemaName("ait_ait_familygroup_ait_safetyplan")]
    public IEnumerable<ait_safetyplan> ait_ait_familygroup_ait_safetyplan
    {
      get
      {
        return this.GetRelatedEntities<ait_safetyplan>(nameof (ait_ait_familygroup_ait_safetyplan), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_familygroup_ait_safetyplan));
        this.SetRelatedEntities<ait_safetyplan>(nameof (ait_ait_familygroup_ait_safetyplan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_familygroup_ait_safetyplan));
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

    [RelationshipSchemaName("ait_familygroup_ActivityParties")]
    public IEnumerable<ActivityParty> ait_familygroup_ActivityParties
    {
      get
      {
        return this.GetRelatedEntities<ActivityParty>(nameof (ait_familygroup_ActivityParties), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familygroup_ActivityParties));
        this.SetRelatedEntities<ActivityParty>(nameof (ait_familygroup_ActivityParties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familygroup_ActivityParties));
      }
    }

    [RelationshipSchemaName("ait_familygroup_ActivityPointers")]
    public IEnumerable<ActivityPointer> ait_familygroup_ActivityPointers
    {
      get
      {
        return this.GetRelatedEntities<ActivityPointer>(nameof (ait_familygroup_ActivityPointers), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familygroup_ActivityPointers));
        this.SetRelatedEntities<ActivityPointer>(nameof (ait_familygroup_ActivityPointers), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familygroup_ActivityPointers));
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

    [RelationshipSchemaName("ait_familygroup_Annotations")]
    public IEnumerable<Annotation> ait_familygroup_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (ait_familygroup_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familygroup_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (ait_familygroup_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familygroup_Annotations));
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

    [RelationshipSchemaName("ait_familygroup_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_familygroup_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_familygroup_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familygroup_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_familygroup_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familygroup_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_familygroup_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_familygroup_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_familygroup_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familygroup_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_familygroup_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familygroup_BulkDeleteFailures));
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

    [RelationshipSchemaName("ait_familygroup_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_familygroup_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_familygroup_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familygroup_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_familygroup_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familygroup_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_familygroup_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_familygroup_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_familygroup_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familygroup_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_familygroup_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familygroup_DuplicateMatchingRecord));
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

    [RelationshipSchemaName("ait_familygroup_Faxes")]
    public IEnumerable<Fax> ait_familygroup_Faxes
    {
      get => this.GetRelatedEntities<Fax>(nameof (ait_familygroup_Faxes), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_familygroup_Faxes));
        this.SetRelatedEntities<Fax>(nameof (ait_familygroup_Faxes), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familygroup_Faxes));
      }
    }

    [RelationshipSchemaName("ait_familygroup_Letters")]
    public IEnumerable<Letter> ait_familygroup_Letters
    {
      get => this.GetRelatedEntities<Letter>(nameof (ait_familygroup_Letters), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_familygroup_Letters));
        this.SetRelatedEntities<Letter>(nameof (ait_familygroup_Letters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familygroup_Letters));
      }
    }

    [RelationshipSchemaName("ait_familygroup_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_familygroup_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_familygroup_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familygroup_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_familygroup_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familygroup_MailboxTrackingFolders));
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

    [RelationshipSchemaName("ait_familygroup_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_familygroup_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_familygroup_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familygroup_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_familygroup_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familygroup_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_familygroup_ProcessSession")]
    public IEnumerable<ProcessSession> ait_familygroup_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_familygroup_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familygroup_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_familygroup_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familygroup_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_familygroup_RecurringAppointmentMasters")]
    public IEnumerable<RecurringAppointmentMaster> ait_familygroup_RecurringAppointmentMasters
    {
      get
      {
        return this.GetRelatedEntities<RecurringAppointmentMaster>(nameof (ait_familygroup_RecurringAppointmentMasters), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familygroup_RecurringAppointmentMasters));
        this.SetRelatedEntities<RecurringAppointmentMaster>(nameof (ait_familygroup_RecurringAppointmentMasters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familygroup_RecurringAppointmentMasters));
      }
    }

    [RelationshipSchemaName("ait_familygroup_SocialActivities")]
    public IEnumerable<SocialActivity> ait_familygroup_SocialActivities
    {
      get
      {
        return this.GetRelatedEntities<SocialActivity>(nameof (ait_familygroup_SocialActivities), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familygroup_SocialActivities));
        this.SetRelatedEntities<SocialActivity>(nameof (ait_familygroup_SocialActivities), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familygroup_SocialActivities));
      }
    }

    [RelationshipSchemaName("ait_familygroup_SyncErrors")]
    public IEnumerable<SyncError> ait_familygroup_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_familygroup_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familygroup_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_familygroup_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familygroup_SyncErrors));
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

    [RelationshipSchemaName("ait_familygroup_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_familygroup_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_familygroup_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familygroup_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_familygroup_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familygroup_UserEntityInstanceDatas));
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
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_familygroup_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_familygroup_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_familygroup_createdonbehalfby));
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
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_familygroup_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_familygroup_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_familygroup_modifiedonbehalfby));
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

    public ait_familygroup(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_familygroupid"] = (object) base.Id;
            break;
          case "ait_familygroupid":
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
