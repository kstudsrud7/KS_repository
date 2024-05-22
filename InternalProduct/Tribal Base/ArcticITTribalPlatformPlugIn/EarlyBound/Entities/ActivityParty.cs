// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ActivityParty
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("activityparty")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ActivityParty : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "activityparty";
    public const string EntitySchemaName = "ActivityParty";
    public const string PrimaryIdAttribute = "activitypartyid";
    public const string PrimaryNameAttribute = "partyidname";

    public ActivityParty()
      : base("activityparty")
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

    [AttributeLogicalName("activityid")]
    public EntityReference ActivityId
    {
      get => this.GetAttributeValue<EntityReference>("activityid");
      set
      {
        this.OnPropertyChanging(nameof (ActivityId));
        this.SetAttributeValue("activityid", (object) value);
        this.OnPropertyChanged(nameof (ActivityId));
      }
    }

    [AttributeLogicalName("activitypartyid")]
    public Guid? ActivityPartyId
    {
      get => this.GetAttributeValue<Guid?>("activitypartyid");
      set
      {
        this.OnPropertyChanging(nameof (ActivityPartyId));
        this.SetAttributeValue("activitypartyid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ActivityPartyId));
      }
    }

    [AttributeLogicalName("activitypartyid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ActivityPartyId = new Guid?(value);
    }

    [AttributeLogicalName("addressused")]
    public string AddressUsed
    {
      get => this.GetAttributeValue<string>("addressused");
      set
      {
        this.OnPropertyChanging(nameof (AddressUsed));
        this.SetAttributeValue("addressused", (object) value);
        this.OnPropertyChanged(nameof (AddressUsed));
      }
    }

    [AttributeLogicalName("addressusedemailcolumnnumber")]
    public int? AddressUsedEmailColumnNumber
    {
      get => this.GetAttributeValue<int?>("addressusedemailcolumnnumber");
    }

    [AttributeLogicalName("donotemail")]
    public bool? DoNotEmail => this.GetAttributeValue<bool?>("donotemail");

    [AttributeLogicalName("donotfax")]
    public bool? DoNotFax => this.GetAttributeValue<bool?>("donotfax");

    [AttributeLogicalName("donotphone")]
    public bool? DoNotPhone => this.GetAttributeValue<bool?>("donotphone");

    [AttributeLogicalName("donotpostalmail")]
    public bool? DoNotPostalMail => this.GetAttributeValue<bool?>("donotpostalmail");

    [AttributeLogicalName("effort")]
    public double? Effort
    {
      get => this.GetAttributeValue<double?>("effort");
      set
      {
        this.OnPropertyChanging(nameof (Effort));
        this.SetAttributeValue("effort", (object) value);
        this.OnPropertyChanged(nameof (Effort));
      }
    }

    [AttributeLogicalName("exchangeentryid")]
    public string ExchangeEntryId
    {
      get => this.GetAttributeValue<string>("exchangeentryid");
      set
      {
        this.OnPropertyChanging(nameof (ExchangeEntryId));
        this.SetAttributeValue("exchangeentryid", (object) value);
        this.OnPropertyChanged(nameof (ExchangeEntryId));
      }
    }

    [AttributeLogicalName("instancetypecode")]
    public OptionSetValue InstanceTypeCode
    {
      get => this.GetAttributeValue<OptionSetValue>("instancetypecode");
    }

    [AttributeLogicalName("ispartydeleted")]
    public bool? IsPartyDeleted => this.GetAttributeValue<bool?>("ispartydeleted");

    [AttributeLogicalName("ownerid")]
    public EntityReference OwnerId => this.GetAttributeValue<EntityReference>("ownerid");

    [AttributeLogicalName("participationtypemask")]
    public OptionSetValue ParticipationTypeMask
    {
      get => this.GetAttributeValue<OptionSetValue>("participationtypemask");
      set
      {
        this.OnPropertyChanging(nameof (ParticipationTypeMask));
        this.SetAttributeValue("participationtypemask", (object) value);
        this.OnPropertyChanged(nameof (ParticipationTypeMask));
      }
    }

    [AttributeLogicalName("partyid")]
    public EntityReference PartyId
    {
      get => this.GetAttributeValue<EntityReference>("partyid");
      set
      {
        this.OnPropertyChanging(nameof (PartyId));
        this.SetAttributeValue("partyid", (object) value);
        this.OnPropertyChanged(nameof (PartyId));
      }
    }

    [AttributeLogicalName("scheduledend")]
    public DateTime? ScheduledEnd => this.GetAttributeValue<DateTime?>("scheduledend");

    [AttributeLogicalName("scheduledstart")]
    public DateTime? ScheduledStart => this.GetAttributeValue<DateTime?>("scheduledstart");

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("ActivityParty_SyncErrors")]
    public IEnumerable<SyncError> ActivityParty_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ActivityParty_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ActivityParty_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ActivityParty_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ActivityParty_SyncErrors));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_activityparty")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_activityparty
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_activityparty), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_activityparty));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_activityparty), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_activityparty));
      }
    }

    [AttributeLogicalName("partyid")]
    [RelationshipSchemaName("account_activity_parties")]
    public Account account_activity_parties
    {
      get => this.GetRelatedEntity<Account>(nameof (account_activity_parties), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (account_activity_parties));
        this.SetRelatedEntity<Account>(nameof (account_activity_parties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (account_activity_parties));
      }
    }

    [AttributeLogicalName("activityid")]
    [RelationshipSchemaName("activitypointer_activity_parties")]
    public ActivityPointer activitypointer_activity_parties
    {
      get
      {
        return this.GetRelatedEntity<ActivityPointer>(nameof (activitypointer_activity_parties), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (activitypointer_activity_parties));
        this.SetRelatedEntity<ActivityPointer>(nameof (activitypointer_activity_parties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (activitypointer_activity_parties));
      }
    }

    [AttributeLogicalName("partyid")]
    [RelationshipSchemaName("ait_assessment_ActivityParties")]
    public ait_assessment ait_assessment_ActivityParties
    {
      get
      {
        return this.GetRelatedEntity<ait_assessment>(nameof (ait_assessment_ActivityParties), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_assessment_ActivityParties));
        this.SetRelatedEntity<ait_assessment>(nameof (ait_assessment_ActivityParties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_assessment_ActivityParties));
      }
    }

    [AttributeLogicalName("partyid")]
    [RelationshipSchemaName("ait_case_ActivityParties")]
    public ait_case ait_case_ActivityParties
    {
      get => this.GetRelatedEntity<ait_case>(nameof (ait_case_ActivityParties), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_case_ActivityParties));
        this.SetRelatedEntity<ait_case>(nameof (ait_case_ActivityParties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_case_ActivityParties));
      }
    }

    [AttributeLogicalName("partyid")]
    [RelationshipSchemaName("ait_casenote_ActivityParties")]
    public ait_casenote ait_casenote_ActivityParties
    {
      get
      {
        return this.GetRelatedEntity<ait_casenote>(nameof (ait_casenote_ActivityParties), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_casenote_ActivityParties));
        this.SetRelatedEntity<ait_casenote>(nameof (ait_casenote_ActivityParties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_casenote_ActivityParties));
      }
    }

    [AttributeLogicalName("partyid")]
    [RelationshipSchemaName("ait_caseplan_ActivityParties")]
    public ait_caseplan ait_caseplan_ActivityParties
    {
      get
      {
        return this.GetRelatedEntity<ait_caseplan>(nameof (ait_caseplan_ActivityParties), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_caseplan_ActivityParties));
        this.SetRelatedEntity<ait_caseplan>(nameof (ait_caseplan_ActivityParties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_caseplan_ActivityParties));
      }
    }

    [AttributeLogicalName("partyid")]
    [RelationshipSchemaName("ait_changerequest_ActivityParties")]
    public ait_changerequest ait_changerequest_ActivityParties
    {
      get
      {
        return this.GetRelatedEntity<ait_changerequest>(nameof (ait_changerequest_ActivityParties), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_changerequest_ActivityParties));
        this.SetRelatedEntity<ait_changerequest>(nameof (ait_changerequest_ActivityParties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_changerequest_ActivityParties));
      }
    }

    [AttributeLogicalName("partyid")]
    [RelationshipSchemaName("ait_clientprofile_ActivityParties")]
    public ait_clientprofile ait_clientprofile_ActivityParties
    {
      get
      {
        return this.GetRelatedEntity<ait_clientprofile>(nameof (ait_clientprofile_ActivityParties), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_ActivityParties));
        this.SetRelatedEntity<ait_clientprofile>(nameof (ait_clientprofile_ActivityParties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_ActivityParties));
      }
    }

    [AttributeLogicalName("partyid")]
    [RelationshipSchemaName("ait_familygroup_ActivityParties")]
    public ait_familygroup ait_familygroup_ActivityParties
    {
      get
      {
        return this.GetRelatedEntity<ait_familygroup>(nameof (ait_familygroup_ActivityParties), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familygroup_ActivityParties));
        this.SetRelatedEntity<ait_familygroup>(nameof (ait_familygroup_ActivityParties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familygroup_ActivityParties));
      }
    }

    [AttributeLogicalName("partyid")]
    [RelationshipSchemaName("ait_goal_ActivityParties")]
    public ait_goal ait_goal_ActivityParties
    {
      get => this.GetRelatedEntity<ait_goal>(nameof (ait_goal_ActivityParties), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_goal_ActivityParties));
        this.SetRelatedEntity<ait_goal>(nameof (ait_goal_ActivityParties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_goal_ActivityParties));
      }
    }

    [AttributeLogicalName("partyid")]
    [RelationshipSchemaName("ait_groupactivity_ActivityParties")]
    public ait_groupactivity ait_groupactivity_ActivityParties
    {
      get
      {
        return this.GetRelatedEntity<ait_groupactivity>(nameof (ait_groupactivity_ActivityParties), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_groupactivity_ActivityParties));
        this.SetRelatedEntity<ait_groupactivity>(nameof (ait_groupactivity_ActivityParties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_groupactivity_ActivityParties));
      }
    }

    [AttributeLogicalName("partyid")]
    [RelationshipSchemaName("ait_groupactivitymeeting_ActivityParties")]
    public ait_groupactivitymeeting ait_groupactivitymeeting_ActivityParties
    {
      get
      {
        return this.GetRelatedEntity<ait_groupactivitymeeting>(nameof (ait_groupactivitymeeting_ActivityParties), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_groupactivitymeeting_ActivityParties));
        this.SetRelatedEntity<ait_groupactivitymeeting>(nameof (ait_groupactivitymeeting_ActivityParties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_groupactivitymeeting_ActivityParties));
      }
    }

    [AttributeLogicalName("partyid")]
    [RelationshipSchemaName("ait_icwanotice_ActivityParties")]
    public ait_icwanotice ait_icwanotice_ActivityParties
    {
      get
      {
        return this.GetRelatedEntity<ait_icwanotice>(nameof (ait_icwanotice_ActivityParties), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwanotice_ActivityParties));
        this.SetRelatedEntity<ait_icwanotice>(nameof (ait_icwanotice_ActivityParties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwanotice_ActivityParties));
      }
    }

    [AttributeLogicalName("partyid")]
    [RelationshipSchemaName("ait_incident_ActivityParties")]
    public ait_incident ait_incident_ActivityParties
    {
      get
      {
        return this.GetRelatedEntity<ait_incident>(nameof (ait_incident_ActivityParties), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incident_ActivityParties));
        this.SetRelatedEntity<ait_incident>(nameof (ait_incident_ActivityParties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incident_ActivityParties));
      }
    }

    [AttributeLogicalName("partyid")]
    [RelationshipSchemaName("ait_investigation_ActivityParties")]
    public ait_investigation ait_investigation_ActivityParties
    {
      get
      {
        return this.GetRelatedEntity<ait_investigation>(nameof (ait_investigation_ActivityParties), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_investigation_ActivityParties));
        this.SetRelatedEntity<ait_investigation>(nameof (ait_investigation_ActivityParties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_investigation_ActivityParties));
      }
    }

    [AttributeLogicalName("partyid")]
    [RelationshipSchemaName("ait_outcome_ActivityParties")]
    public ait_outcome ait_outcome_ActivityParties
    {
      get
      {
        return this.GetRelatedEntity<ait_outcome>(nameof (ait_outcome_ActivityParties), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_outcome_ActivityParties));
        this.SetRelatedEntity<ait_outcome>(nameof (ait_outcome_ActivityParties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_outcome_ActivityParties));
      }
    }

    [AttributeLogicalName("partyid")]
    [RelationshipSchemaName("ait_payment_ActivityParties")]
    public ait_payment ait_payment_ActivityParties
    {
      get
      {
        return this.GetRelatedEntity<ait_payment>(nameof (ait_payment_ActivityParties), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_payment_ActivityParties));
        this.SetRelatedEntity<ait_payment>(nameof (ait_payment_ActivityParties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_payment_ActivityParties));
      }
    }

    [AttributeLogicalName("partyid")]
    [RelationshipSchemaName("ait_placementlocation_ActivityParties")]
    public ait_placementlocation ait_placementlocation_ActivityParties
    {
      get
      {
        return this.GetRelatedEntity<ait_placementlocation>(nameof (ait_placementlocation_ActivityParties), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_placementlocation_ActivityParties));
        this.SetRelatedEntity<ait_placementlocation>(nameof (ait_placementlocation_ActivityParties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_placementlocation_ActivityParties));
      }
    }

    [AttributeLogicalName("partyid")]
    [RelationshipSchemaName("ait_planactivity_ActivityParties")]
    public ait_planactivity ait_planactivity_ActivityParties
    {
      get
      {
        return this.GetRelatedEntity<ait_planactivity>(nameof (ait_planactivity_ActivityParties), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_planactivity_ActivityParties));
        this.SetRelatedEntity<ait_planactivity>(nameof (ait_planactivity_ActivityParties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_planactivity_ActivityParties));
      }
    }

    [AttributeLogicalName("partyid")]
    [RelationshipSchemaName("ait_program_ActivityParties")]
    public ait_program ait_program_ActivityParties
    {
      get
      {
        return this.GetRelatedEntity<ait_program>(nameof (ait_program_ActivityParties), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_program_ActivityParties));
        this.SetRelatedEntity<ait_program>(nameof (ait_program_ActivityParties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_program_ActivityParties));
      }
    }

    [AttributeLogicalName("partyid")]
    [RelationshipSchemaName("ait_referral_ActivityParties")]
    public ait_referral ait_referral_ActivityParties
    {
      get
      {
        return this.GetRelatedEntity<ait_referral>(nameof (ait_referral_ActivityParties), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_referral_ActivityParties));
        this.SetRelatedEntity<ait_referral>(nameof (ait_referral_ActivityParties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_referral_ActivityParties));
      }
    }

    [AttributeLogicalName("partyid")]
    [RelationshipSchemaName("ait_servicerequest_ActivityParties")]
    public ait_servicerequest ait_servicerequest_ActivityParties
    {
      get
      {
        return this.GetRelatedEntity<ait_servicerequest>(nameof (ait_servicerequest_ActivityParties), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_ActivityParties));
        this.SetRelatedEntity<ait_servicerequest>(nameof (ait_servicerequest_ActivityParties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_ActivityParties));
      }
    }

    [AttributeLogicalName("activityid")]
    [RelationshipSchemaName("appointment_activity_parties")]
    public Appointment appointment_activity_parties
    {
      get
      {
        return this.GetRelatedEntity<Appointment>(nameof (appointment_activity_parties), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appointment_activity_parties));
        this.SetRelatedEntity<Appointment>(nameof (appointment_activity_parties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appointment_activity_parties));
      }
    }

    [AttributeLogicalName("partyid")]
    [RelationshipSchemaName("contact_activity_parties")]
    public Contact contact_activity_parties
    {
      get => this.GetRelatedEntity<Contact>(nameof (contact_activity_parties), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (contact_activity_parties));
        this.SetRelatedEntity<Contact>(nameof (contact_activity_parties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (contact_activity_parties));
      }
    }

    [AttributeLogicalName("activityid")]
    [RelationshipSchemaName("email_activity_parties")]
    public Email email_activity_parties
    {
      get => this.GetRelatedEntity<Email>(nameof (email_activity_parties), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (email_activity_parties));
        this.SetRelatedEntity<Email>(nameof (email_activity_parties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (email_activity_parties));
      }
    }

    [AttributeLogicalName("activityid")]
    [RelationshipSchemaName("fax_activity_parties")]
    public Fax fax_activity_parties
    {
      get => this.GetRelatedEntity<Fax>(nameof (fax_activity_parties), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (fax_activity_parties));
        this.SetRelatedEntity<Fax>(nameof (fax_activity_parties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (fax_activity_parties));
      }
    }

    [AttributeLogicalName("partyid")]
    [RelationshipSchemaName("knowledgearticle_activity_parties")]
    public KnowledgeArticle knowledgearticle_activity_parties
    {
      get
      {
        return this.GetRelatedEntity<KnowledgeArticle>(nameof (knowledgearticle_activity_parties), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (knowledgearticle_activity_parties));
        this.SetRelatedEntity<KnowledgeArticle>(nameof (knowledgearticle_activity_parties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (knowledgearticle_activity_parties));
      }
    }

    [AttributeLogicalName("activityid")]
    [RelationshipSchemaName("letter_activity_parties")]
    public Letter letter_activity_parties
    {
      get => this.GetRelatedEntity<Letter>(nameof (letter_activity_parties), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (letter_activity_parties));
        this.SetRelatedEntity<Letter>(nameof (letter_activity_parties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (letter_activity_parties));
      }
    }

    [AttributeLogicalName("activityid")]
    [RelationshipSchemaName("phonecall_activity_parties")]
    public PhoneCall phonecall_activity_parties
    {
      get
      {
        return this.GetRelatedEntity<PhoneCall>(nameof (phonecall_activity_parties), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (phonecall_activity_parties));
        this.SetRelatedEntity<PhoneCall>(nameof (phonecall_activity_parties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (phonecall_activity_parties));
      }
    }

    [AttributeLogicalName("partyid")]
    [RelationshipSchemaName("queue_activity_parties")]
    public Queue queue_activity_parties
    {
      get => this.GetRelatedEntity<Queue>(nameof (queue_activity_parties), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (queue_activity_parties));
        this.SetRelatedEntity<Queue>(nameof (queue_activity_parties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (queue_activity_parties));
      }
    }

    [AttributeLogicalName("activityid")]
    [RelationshipSchemaName("recurringappointmentmaster_activity_parties")]
    public RecurringAppointmentMaster recurringappointmentmaster_activity_parties
    {
      get
      {
        return this.GetRelatedEntity<RecurringAppointmentMaster>(nameof (recurringappointmentmaster_activity_parties), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (recurringappointmentmaster_activity_parties));
        this.SetRelatedEntity<RecurringAppointmentMaster>(nameof (recurringappointmentmaster_activity_parties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (recurringappointmentmaster_activity_parties));
      }
    }

    [AttributeLogicalName("activityid")]
    [RelationshipSchemaName("socialactivity_activity_parties")]
    public SocialActivity socialactivity_activity_parties
    {
      get
      {
        return this.GetRelatedEntity<SocialActivity>(nameof (socialactivity_activity_parties), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (socialactivity_activity_parties));
        this.SetRelatedEntity<SocialActivity>(nameof (socialactivity_activity_parties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (socialactivity_activity_parties));
      }
    }

    [AttributeLogicalName("partyid")]
    [RelationshipSchemaName("system_user_activity_parties")]
    public SystemUser system_user_activity_parties
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (system_user_activity_parties), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (system_user_activity_parties));
        this.SetRelatedEntity<SystemUser>(nameof (system_user_activity_parties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (system_user_activity_parties));
      }
    }

    [AttributeLogicalName("activityid")]
    [RelationshipSchemaName("task_activity_parties")]
    public Task task_activity_parties
    {
      get => this.GetRelatedEntity<Task>(nameof (task_activity_parties), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (task_activity_parties));
        this.SetRelatedEntity<Task>(nameof (task_activity_parties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (task_activity_parties));
      }
    }

    public ActivityParty(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["activitypartyid"] = (object) base.Id;
            break;
          case "activitypartyid":
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
