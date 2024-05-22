// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EarlyBound.Team
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("team")]
  [GeneratedCode("CrmSvcUtil", "9.0.0.9154")]
  public class Team : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "team";
    public const int EntityTypeCode = 9;

    public Team()
      : base("team")
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

    [AttributeLogicalName("administratorid")]
    public EntityReference AdministratorId
    {
      get => this.GetAttributeValue<EntityReference>("administratorid");
      set
      {
        this.OnPropertyChanging(nameof (AdministratorId));
        this.SetAttributeValue("administratorid", (object) value);
        this.OnPropertyChanged(nameof (AdministratorId));
      }
    }

    [AttributeLogicalName("administratoridname")]
    public string AdministratorIdName => this.GetAttributeValue<string>("administratoridname");

    [AttributeLogicalName("administratoridyominame")]
    public string AdministratorIdYomiName
    {
      get => this.GetAttributeValue<string>("administratoridyominame");
    }

    [AttributeLogicalName("azureactivedirectoryobjectid")]
    public Guid? AzureActiveDirectoryObjectId
    {
      get => this.GetAttributeValue<Guid?>("azureactivedirectoryobjectid");
      set
      {
        this.OnPropertyChanging(nameof (AzureActiveDirectoryObjectId));
        this.SetAttributeValue("azureactivedirectoryobjectid", (object) value);
        this.OnPropertyChanged(nameof (AzureActiveDirectoryObjectId));
      }
    }

    [AttributeLogicalName("businessunitid")]
    public EntityReference BusinessUnitId
    {
      get => this.GetAttributeValue<EntityReference>("businessunitid");
      set
      {
        this.OnPropertyChanging(nameof (BusinessUnitId));
        this.SetAttributeValue("businessunitid", (object) value);
        this.OnPropertyChanged(nameof (BusinessUnitId));
      }
    }

    [AttributeLogicalName("businessunitidname")]
    public string BusinessUnitIdName => this.GetAttributeValue<string>("businessunitidname");

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

    [AttributeLogicalName("description")]
    public string Description
    {
      get => this.GetAttributeValue<string>("description");
      set
      {
        this.OnPropertyChanging(nameof (Description));
        this.SetAttributeValue("description", (object) value);
        this.OnPropertyChanged(nameof (Description));
      }
    }

    [AttributeLogicalName("emailaddress")]
    public string EMailAddress
    {
      get => this.GetAttributeValue<string>("emailaddress");
      set
      {
        this.OnPropertyChanging(nameof (EMailAddress));
        this.SetAttributeValue("emailaddress", (object) value);
        this.OnPropertyChanged(nameof (EMailAddress));
      }
    }

    [AttributeLogicalName("exchangerate")]
    public Decimal? ExchangeRate => this.GetAttributeValue<Decimal?>("exchangerate");

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

    [AttributeLogicalName("isdefault")]
    public bool? IsDefault => this.GetAttributeValue<bool?>("isdefault");

    [AttributeLogicalName("isdefaultname")]
    public object IsDefaultName => this.GetAttributeValue<object>("isdefaultname");

    [AttributeLogicalName("membershiptype")]
    public OptionSetValue MembershipType
    {
      get => this.GetAttributeValue<OptionSetValue>("membershiptype");
      set
      {
        this.OnPropertyChanging(nameof (MembershipType));
        this.SetAttributeValue("membershiptype", (object) value);
        this.OnPropertyChanged(nameof (MembershipType));
      }
    }

    [AttributeLogicalName("membershiptypename")]
    public object membershiptypeName => this.GetAttributeValue<object>("membershiptypename");

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

    [AttributeLogicalName("name")]
    public string Name
    {
      get => this.GetAttributeValue<string>("name");
      set
      {
        this.OnPropertyChanging(nameof (Name));
        this.SetAttributeValue("name", (object) value);
        this.OnPropertyChanged(nameof (Name));
      }
    }

    [AttributeLogicalName("organizationid")]
    public Guid? OrganizationId => this.GetAttributeValue<Guid?>("organizationid");

    [AttributeLogicalName("organizationidname")]
    public string OrganizationIdName => this.GetAttributeValue<string>("organizationidname");

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

    [AttributeLogicalName("processid")]
    public Guid? ProcessId
    {
      get => this.GetAttributeValue<Guid?>("processid");
      set
      {
        this.OnPropertyChanging(nameof (ProcessId));
        this.SetAttributeValue("processid", (object) value);
        this.OnPropertyChanged(nameof (ProcessId));
      }
    }

    [AttributeLogicalName("queueid")]
    public EntityReference QueueId
    {
      get => this.GetAttributeValue<EntityReference>("queueid");
      set
      {
        this.OnPropertyChanging(nameof (QueueId));
        this.SetAttributeValue("queueid", (object) value);
        this.OnPropertyChanged(nameof (QueueId));
      }
    }

    [AttributeLogicalName("queueidname")]
    public string QueueIdName => this.GetAttributeValue<string>("queueidname");

    [AttributeLogicalName("regardingobjectid")]
    public EntityReference RegardingObjectId
    {
      get => this.GetAttributeValue<EntityReference>("regardingobjectid");
      set
      {
        this.OnPropertyChanging(nameof (RegardingObjectId));
        this.SetAttributeValue("regardingobjectid", (object) value);
        this.OnPropertyChanged(nameof (RegardingObjectId));
      }
    }

    [AttributeLogicalName("regardingobjecttypecode")]
    public string RegardingObjectTypeCode
    {
      get => this.GetAttributeValue<string>("regardingobjecttypecode");
      set
      {
        this.OnPropertyChanging(nameof (RegardingObjectTypeCode));
        this.SetAttributeValue("regardingobjecttypecode", (object) value);
        this.OnPropertyChanged(nameof (RegardingObjectTypeCode));
      }
    }

    [AttributeLogicalName("stageid")]
    public Guid? StageId
    {
      get => this.GetAttributeValue<Guid?>("stageid");
      set
      {
        this.OnPropertyChanging(nameof (StageId));
        this.SetAttributeValue("stageid", (object) value);
        this.OnPropertyChanged(nameof (StageId));
      }
    }

    [AttributeLogicalName("systemmanaged")]
    public bool? SystemManaged => this.GetAttributeValue<bool?>("systemmanaged");

    [AttributeLogicalName("systemmanagedname")]
    public object SystemManagedName => this.GetAttributeValue<object>("systemmanagedname");

    [AttributeLogicalName("teamid")]
    public Guid? TeamId
    {
      get => this.GetAttributeValue<Guid?>("teamid");
      set
      {
        this.OnPropertyChanging(nameof (TeamId));
        this.SetAttributeValue("teamid", (object) value);
        this.OnPropertyChanged(nameof (TeamId));
      }
    }

    [AttributeLogicalName("teamtemplateid")]
    public EntityReference TeamTemplateId
    {
      get => this.GetAttributeValue<EntityReference>("teamtemplateid");
      set
      {
        this.OnPropertyChanging(nameof (TeamTemplateId));
        this.SetAttributeValue("teamtemplateid", (object) value);
        this.OnPropertyChanged(nameof (TeamTemplateId));
      }
    }

    [AttributeLogicalName("teamtype")]
    public OptionSetValue TeamType
    {
      get => this.GetAttributeValue<OptionSetValue>("teamtype");
      set
      {
        this.OnPropertyChanging(nameof (TeamType));
        this.SetAttributeValue("teamtype", (object) value);
        this.OnPropertyChanged(nameof (TeamType));
      }
    }

    [AttributeLogicalName("teamtypename")]
    public object TeamTypeName => this.GetAttributeValue<object>("teamtypename");

    [AttributeLogicalName("transactioncurrencyid")]
    public EntityReference TransactionCurrencyId
    {
      get => this.GetAttributeValue<EntityReference>("transactioncurrencyid");
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrencyId));
        this.SetAttributeValue("transactioncurrencyid", (object) value);
        this.OnPropertyChanged(nameof (TransactionCurrencyId));
      }
    }

    [AttributeLogicalName("transactioncurrencyidname")]
    public string TransactionCurrencyIdName
    {
      get => this.GetAttributeValue<string>("transactioncurrencyidname");
    }

    [AttributeLogicalName("traversedpath")]
    public string TraversedPath
    {
      get => this.GetAttributeValue<string>("traversedpath");
      set
      {
        this.OnPropertyChanging(nameof (TraversedPath));
        this.SetAttributeValue("traversedpath", (object) value);
        this.OnPropertyChanged(nameof (TraversedPath));
      }
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [AttributeLogicalName("yominame")]
    public string YomiName
    {
      get => this.GetAttributeValue<string>("yominame");
      set
      {
        this.OnPropertyChanging(nameof (YomiName));
        this.SetAttributeValue("yominame", (object) value);
        this.OnPropertyChanged(nameof (YomiName));
      }
    }

    [RelationshipSchemaName("team_accounts")]
    public IEnumerable<Account> team_accounts
    {
      get => this.GetRelatedEntities<Account>(nameof (team_accounts), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_accounts));
        this.SetRelatedEntities<Account>(nameof (team_accounts), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_accounts));
      }
    }

    [RelationshipSchemaName("team_ait_assessment")]
    public IEnumerable<ait_assessment> team_ait_assessment
    {
      get
      {
        return this.GetRelatedEntities<ait_assessment>(nameof (team_ait_assessment), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_assessment));
        this.SetRelatedEntities<ait_assessment>(nameof (team_ait_assessment), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_assessment));
      }
    }

    [RelationshipSchemaName("team_ait_case")]
    public IEnumerable<ait_case> team_ait_case
    {
      get => this.GetRelatedEntities<ait_case>(nameof (team_ait_case), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_ait_case));
        this.SetRelatedEntities<ait_case>(nameof (team_ait_case), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_case));
      }
    }

    [RelationshipSchemaName("team_ait_casenotefamilywellness")]
    public IEnumerable<ait_casenotefamilywellness> team_ait_casenotefamilywellness
    {
      get
      {
        return this.GetRelatedEntities<ait_casenotefamilywellness>(nameof (team_ait_casenotefamilywellness), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_casenotefamilywellness));
        this.SetRelatedEntities<ait_casenotefamilywellness>(nameof (team_ait_casenotefamilywellness), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_casenotefamilywellness));
      }
    }

    [RelationshipSchemaName("team_ait_caseplan")]
    public IEnumerable<ait_caseplan> team_ait_caseplan
    {
      get => this.GetRelatedEntities<ait_caseplan>(nameof (team_ait_caseplan), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_ait_caseplan));
        this.SetRelatedEntities<ait_caseplan>(nameof (team_ait_caseplan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_caseplan));
      }
    }

    [RelationshipSchemaName("team_ait_clientprofile")]
    public IEnumerable<ait_clientprofile> team_ait_clientprofile
    {
      get
      {
        return this.GetRelatedEntities<ait_clientprofile>(nameof (team_ait_clientprofile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_clientprofile));
        this.SetRelatedEntities<ait_clientprofile>(nameof (team_ait_clientprofile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_clientprofile));
      }
    }

    [RelationshipSchemaName("team_ait_familygroup")]
    public IEnumerable<ait_familygroup> team_ait_familygroup
    {
      get
      {
        return this.GetRelatedEntities<ait_familygroup>(nameof (team_ait_familygroup), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_familygroup));
        this.SetRelatedEntities<ait_familygroup>(nameof (team_ait_familygroup), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_familygroup));
      }
    }

    [RelationshipSchemaName("team_ait_goal")]
    public IEnumerable<ait_goal> team_ait_goal
    {
      get => this.GetRelatedEntities<ait_goal>(nameof (team_ait_goal), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_ait_goal));
        this.SetRelatedEntities<ait_goal>(nameof (team_ait_goal), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_goal));
      }
    }

    [RelationshipSchemaName("team_ait_groupactivity")]
    public IEnumerable<ait_groupactivity> team_ait_groupactivity
    {
      get
      {
        return this.GetRelatedEntities<ait_groupactivity>(nameof (team_ait_groupactivity), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_groupactivity));
        this.SetRelatedEntities<ait_groupactivity>(nameof (team_ait_groupactivity), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_groupactivity));
      }
    }

    [RelationshipSchemaName("team_ait_groupactivitymeeting")]
    public IEnumerable<ait_groupactivitymeeting> team_ait_groupactivitymeeting
    {
      get
      {
        return this.GetRelatedEntities<ait_groupactivitymeeting>(nameof (team_ait_groupactivitymeeting), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_groupactivitymeeting));
        this.SetRelatedEntities<ait_groupactivitymeeting>(nameof (team_ait_groupactivitymeeting), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_groupactivitymeeting));
      }
    }

    [RelationshipSchemaName("team_ait_groupactivityregistration")]
    public IEnumerable<ait_groupactivityregistration> team_ait_groupactivityregistration
    {
      get
      {
        return this.GetRelatedEntities<ait_groupactivityregistration>(nameof (team_ait_groupactivityregistration), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_groupactivityregistration));
        this.SetRelatedEntities<ait_groupactivityregistration>(nameof (team_ait_groupactivityregistration), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_groupactivityregistration));
      }
    }

    [RelationshipSchemaName("team_ait_incidents")]
    public IEnumerable<ait_incidents> team_ait_incidents
    {
      get => this.GetRelatedEntities<ait_incidents>(nameof (team_ait_incidents), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_ait_incidents));
        this.SetRelatedEntities<ait_incidents>(nameof (team_ait_incidents), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_incidents));
      }
    }

    [RelationshipSchemaName("team_ait_meetingattendee")]
    public IEnumerable<ait_meetingattendee> team_ait_meetingattendee
    {
      get
      {
        return this.GetRelatedEntities<ait_meetingattendee>(nameof (team_ait_meetingattendee), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_meetingattendee));
        this.SetRelatedEntities<ait_meetingattendee>(nameof (team_ait_meetingattendee), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_meetingattendee));
      }
    }

    [RelationshipSchemaName("team_ait_payment")]
    public IEnumerable<ait_payment> team_ait_payment
    {
      get => this.GetRelatedEntities<ait_payment>(nameof (team_ait_payment), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_ait_payment));
        this.SetRelatedEntities<ait_payment>(nameof (team_ait_payment), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_payment));
      }
    }

    [RelationshipSchemaName("team_ait_placement")]
    public IEnumerable<ait_placement> team_ait_placement
    {
      get => this.GetRelatedEntities<ait_placement>(nameof (team_ait_placement), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_ait_placement));
        this.SetRelatedEntities<ait_placement>(nameof (team_ait_placement), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_placement));
      }
    }

    [RelationshipSchemaName("team_ait_placementlocation")]
    public IEnumerable<ait_placementlocation> team_ait_placementlocation
    {
      get
      {
        return this.GetRelatedEntities<ait_placementlocation>(nameof (team_ait_placementlocation), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_placementlocation));
        this.SetRelatedEntities<ait_placementlocation>(nameof (team_ait_placementlocation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_placementlocation));
      }
    }

    [RelationshipSchemaName("team_ait_planactivity")]
    public IEnumerable<ait_planactivity> team_ait_planactivity
    {
      get
      {
        return this.GetRelatedEntities<ait_planactivity>(nameof (team_ait_planactivity), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_planactivity));
        this.SetRelatedEntities<ait_planactivity>(nameof (team_ait_planactivity), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_planactivity));
      }
    }

    [RelationshipSchemaName("team_ait_program")]
    public IEnumerable<ait_program> team_ait_program
    {
      get => this.GetRelatedEntities<ait_program>(nameof (team_ait_program), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_ait_program));
        this.SetRelatedEntities<ait_program>(nameof (team_ait_program), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_program));
      }
    }

    [RelationshipSchemaName("team_ait_referral")]
    public IEnumerable<ait_referral> team_ait_referral
    {
      get => this.GetRelatedEntities<ait_referral>(nameof (team_ait_referral), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_ait_referral));
        this.SetRelatedEntities<ait_referral>(nameof (team_ait_referral), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_referral));
      }
    }

    [RelationshipSchemaName("team_ait_servicerequest")]
    public IEnumerable<ait_servicerequest> team_ait_servicerequest
    {
      get
      {
        return this.GetRelatedEntities<ait_servicerequest>(nameof (team_ait_servicerequest), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_servicerequest));
        this.SetRelatedEntities<ait_servicerequest>(nameof (team_ait_servicerequest), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_servicerequest));
      }
    }

    [RelationshipSchemaName("team_appointment")]
    public IEnumerable<Appointment> team_appointment
    {
      get => this.GetRelatedEntities<Appointment>(nameof (team_appointment), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_appointment));
        this.SetRelatedEntities<Appointment>(nameof (team_appointment), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_appointment));
      }
    }

    [RelationshipSchemaName("team_connections1")]
    public IEnumerable<Connection> team_connections1
    {
      get => this.GetRelatedEntities<Connection>(nameof (team_connections1), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_connections1));
        this.SetRelatedEntities<Connection>(nameof (team_connections1), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_connections1));
      }
    }

    [RelationshipSchemaName("team_connections2")]
    public IEnumerable<Connection> team_connections2
    {
      get => this.GetRelatedEntities<Connection>(nameof (team_connections2), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_connections2));
        this.SetRelatedEntities<Connection>(nameof (team_connections2), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_connections2));
      }
    }

    [RelationshipSchemaName("team_contacts")]
    public IEnumerable<Contact> team_contacts
    {
      get => this.GetRelatedEntities<Contact>(nameof (team_contacts), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_contacts));
        this.SetRelatedEntities<Contact>(nameof (team_contacts), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_contacts));
      }
    }

    [RelationshipSchemaName("team_email")]
    public IEnumerable<Email> team_email
    {
      get => this.GetRelatedEntities<Email>(nameof (team_email), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_email));
        this.SetRelatedEntities<Email>(nameof (team_email), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_email));
      }
    }

    [RelationshipSchemaName("team_phonecall")]
    public IEnumerable<PhoneCall> team_phonecall
    {
      get => this.GetRelatedEntities<PhoneCall>(nameof (team_phonecall), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_phonecall));
        this.SetRelatedEntities<PhoneCall>(nameof (team_phonecall), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_phonecall));
      }
    }

    [RelationshipSchemaName("team_task")]
    public IEnumerable<Task> team_task
    {
      get => this.GetRelatedEntities<Task>(nameof (team_task), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_task));
        this.SetRelatedEntities<Task>(nameof (team_task), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_task));
      }
    }

    [RelationshipSchemaName("teammembership_association")]
    public IEnumerable<SystemUser> teammembership_association
    {
      get
      {
        return this.GetRelatedEntities<SystemUser>(nameof (teammembership_association), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (teammembership_association));
        this.SetRelatedEntities<SystemUser>(nameof (teammembership_association), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (teammembership_association));
      }
    }

    [AttributeLogicalName("businessunitid")]
    [RelationshipSchemaName("business_unit_teams")]
    public BusinessUnit business_unit_teams
    {
      get => this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_teams), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (business_unit_teams));
        this.SetRelatedEntity<BusinessUnit>(nameof (business_unit_teams), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_teams));
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_team_createdonbehalfby")]
    public SystemUser lk_team_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_team_createdonbehalfby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_team_modifiedonbehalfby")]
    public SystemUser lk_team_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_team_modifiedonbehalfby), new EntityRole?());
      }
    }

    [AttributeLogicalName("administratorid")]
    [RelationshipSchemaName("lk_teambase_administratorid")]
    public SystemUser lk_teambase_administratorid
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_teambase_administratorid), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_teambase_administratorid));
        this.SetRelatedEntity<SystemUser>(nameof (lk_teambase_administratorid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_teambase_administratorid));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_teambase_createdby")]
    public SystemUser lk_teambase_createdby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_teambase_createdby), new EntityRole?());
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_teambase_modifiedby")]
    public SystemUser lk_teambase_modifiedby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_teambase_modifiedby), new EntityRole?());
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_teams")]
    public Organization organization_teams
    {
      get => this.GetRelatedEntity<Organization>(nameof (organization_teams), new EntityRole?());
    }

    [AttributeLogicalName("stageid")]
    [RelationshipSchemaName("processstage_teams")]
    public ProcessStage processstage_teams
    {
      get => this.GetRelatedEntity<ProcessStage>(nameof (processstage_teams), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (processstage_teams));
        this.SetRelatedEntity<ProcessStage>(nameof (processstage_teams), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (processstage_teams));
      }
    }
  }
}
