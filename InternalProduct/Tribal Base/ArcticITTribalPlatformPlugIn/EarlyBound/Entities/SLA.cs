// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.SLA
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("sla")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class SLA : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "sla";
    public const string EntitySchemaName = "SLA";
    public const string PrimaryIdAttribute = "slaid";
    public const string PrimaryNameAttribute = "name";

    public SLA()
      : base("sla")
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

    [AttributeLogicalName("allowpauseresume")]
    public bool? AllowPauseResume
    {
      get => this.GetAttributeValue<bool?>("allowpauseresume");
      set
      {
        this.OnPropertyChanging(nameof (AllowPauseResume));
        this.SetAttributeValue("allowpauseresume", (object) value);
        this.OnPropertyChanged(nameof (AllowPauseResume));
      }
    }

    [AttributeLogicalName("applicablefrom")]
    public string ApplicableFrom
    {
      get => this.GetAttributeValue<string>("applicablefrom");
      set
      {
        this.OnPropertyChanging(nameof (ApplicableFrom));
        this.SetAttributeValue("applicablefrom", (object) value);
        this.OnPropertyChanged(nameof (ApplicableFrom));
      }
    }

    [AttributeLogicalName("applicablefrompicklist")]
    public OptionSetValue ApplicableFromPickList
    {
      get => this.GetAttributeValue<OptionSetValue>("applicablefrompicklist");
      set
      {
        this.OnPropertyChanging(nameof (ApplicableFromPickList));
        this.SetAttributeValue("applicablefrompicklist", (object) value);
        this.OnPropertyChanged(nameof (ApplicableFromPickList));
      }
    }

    [AttributeLogicalName("businesshoursid")]
    public EntityReference BusinessHoursId
    {
      get => this.GetAttributeValue<EntityReference>("businesshoursid");
      set
      {
        this.OnPropertyChanging(nameof (BusinessHoursId));
        this.SetAttributeValue("businesshoursid", (object) value);
        this.OnPropertyChanged(nameof (BusinessHoursId));
      }
    }

    [AttributeLogicalName("changedattributelist")]
    public string ChangedAttributeList
    {
      get => this.GetAttributeValue<string>("changedattributelist");
      set
      {
        this.OnPropertyChanging(nameof (ChangedAttributeList));
        this.SetAttributeValue("changedattributelist", (object) value);
        this.OnPropertyChanged(nameof (ChangedAttributeList));
      }
    }

    [AttributeLogicalName("componentstate")]
    public OptionSetValue ComponentState
    {
      get => this.GetAttributeValue<OptionSetValue>("componentstate");
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

    [AttributeLogicalName("exchangerate")]
    public Decimal? ExchangeRate => this.GetAttributeValue<Decimal?>("exchangerate");

    [AttributeLogicalName("isdefault")]
    public bool? IsDefault
    {
      get => this.GetAttributeValue<bool?>("isdefault");
      set
      {
        this.OnPropertyChanging(nameof (IsDefault));
        this.SetAttributeValue("isdefault", (object) value);
        this.OnPropertyChanged(nameof (IsDefault));
      }
    }

    [AttributeLogicalName("ismanaged")]
    public bool? IsManaged => this.GetAttributeValue<bool?>("ismanaged");

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

    [AttributeLogicalName("objecttypecode")]
    public OptionSetValue ObjectTypeCode
    {
      get => this.GetAttributeValue<OptionSetValue>("objecttypecode");
    }

    [AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime => this.GetAttributeValue<DateTime?>("overwritetime");

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
      set
      {
        this.OnPropertyChanging(nameof (OwningBusinessUnit));
        this.SetAttributeValue("owningbusinessunit", (object) value);
        this.OnPropertyChanged(nameof (OwningBusinessUnit));
      }
    }

    [AttributeLogicalName("owningteam")]
    public EntityReference OwningTeam
    {
      get => this.GetAttributeValue<EntityReference>("owningteam");
      set
      {
        this.OnPropertyChanging(nameof (OwningTeam));
        this.SetAttributeValue("owningteam", (object) value);
        this.OnPropertyChanged(nameof (OwningTeam));
      }
    }

    [AttributeLogicalName("owninguser")]
    public EntityReference OwningUser
    {
      get => this.GetAttributeValue<EntityReference>("owninguser");
      set
      {
        this.OnPropertyChanging(nameof (OwningUser));
        this.SetAttributeValue("owninguser", (object) value);
        this.OnPropertyChanged(nameof (OwningUser));
      }
    }

    [AttributeLogicalName("primaryentityotc")]
    public int? PrimaryEntityOTC
    {
      get => this.GetAttributeValue<int?>("primaryentityotc");
      set
      {
        this.OnPropertyChanging(nameof (PrimaryEntityOTC));
        this.SetAttributeValue("primaryentityotc", (object) value);
        this.OnPropertyChanged(nameof (PrimaryEntityOTC));
      }
    }

    [AttributeLogicalName("slaid")]
    public Guid? SLAId
    {
      get => this.GetAttributeValue<Guid?>("slaid");
      set
      {
        this.OnPropertyChanging(nameof (SLAId));
        this.SetAttributeValue("slaid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (SLAId));
      }
    }

    [AttributeLogicalName("slaid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.SLAId = new Guid?(value);
    }

    [AttributeLogicalName("slaidunique")]
    public Guid? SLAIdUnique => this.GetAttributeValue<Guid?>("slaidunique");

    [AttributeLogicalName("slatype")]
    public OptionSetValue SLAType
    {
      get => this.GetAttributeValue<OptionSetValue>("slatype");
      set
      {
        this.OnPropertyChanging(nameof (SLAType));
        this.SetAttributeValue("slatype", (object) value);
        this.OnPropertyChanged(nameof (SLAType));
      }
    }

    [AttributeLogicalName("slaversion")]
    public OptionSetValue slaversion
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (slaversion));
      set
      {
        this.OnPropertyChanging(nameof (slaversion));
        this.SetAttributeValue(nameof (slaversion), (object) value);
        this.OnPropertyChanged(nameof (slaversion));
      }
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("statecode")]
    public SLAState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new SLAState?((SLAState) Enum.ToObject(typeof (SLAState), attributeValue.Value)) : new SLAState?();
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

    [AttributeLogicalName("transactioncurrencyid")]
    public EntityReference TransactionCurrencyId
    {
      get => this.GetAttributeValue<EntityReference>("transactioncurrencyid");
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [AttributeLogicalName("workflowid")]
    public EntityReference WorkflowId
    {
      get => this.GetAttributeValue<EntityReference>("workflowid");
      set
      {
        this.OnPropertyChanging(nameof (WorkflowId));
        this.SetAttributeValue("workflowid", (object) value);
        this.OnPropertyChanged(nameof (WorkflowId));
      }
    }

    [RelationshipSchemaName("manualsla_account")]
    public IEnumerable<Account> manualsla_account
    {
      get => this.GetRelatedEntities<Account>(nameof (manualsla_account), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (manualsla_account));
        this.SetRelatedEntities<Account>(nameof (manualsla_account), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (manualsla_account));
      }
    }

    [RelationshipSchemaName("manualsla_activitypointer")]
    public IEnumerable<ActivityPointer> manualsla_activitypointer
    {
      get
      {
        return this.GetRelatedEntities<ActivityPointer>(nameof (manualsla_activitypointer), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (manualsla_activitypointer));
        this.SetRelatedEntities<ActivityPointer>(nameof (manualsla_activitypointer), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (manualsla_activitypointer));
      }
    }

    [RelationshipSchemaName("manualsla_appointment")]
    public IEnumerable<Appointment> manualsla_appointment
    {
      get
      {
        return this.GetRelatedEntities<Appointment>(nameof (manualsla_appointment), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (manualsla_appointment));
        this.SetRelatedEntities<Appointment>(nameof (manualsla_appointment), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (manualsla_appointment));
      }
    }

    [RelationshipSchemaName("manualsla_contact")]
    public IEnumerable<Contact> manualsla_contact
    {
      get => this.GetRelatedEntities<Contact>(nameof (manualsla_contact), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (manualsla_contact));
        this.SetRelatedEntities<Contact>(nameof (manualsla_contact), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (manualsla_contact));
      }
    }

    [RelationshipSchemaName("manualsla_email")]
    public IEnumerable<Email> manualsla_email
    {
      get => this.GetRelatedEntities<Email>(nameof (manualsla_email), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (manualsla_email));
        this.SetRelatedEntities<Email>(nameof (manualsla_email), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (manualsla_email));
      }
    }

    [RelationshipSchemaName("manualsla_fax")]
    public IEnumerable<Fax> manualsla_fax
    {
      get => this.GetRelatedEntities<Fax>(nameof (manualsla_fax), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (manualsla_fax));
        this.SetRelatedEntities<Fax>(nameof (manualsla_fax), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (manualsla_fax));
      }
    }

    [RelationshipSchemaName("manualsla_letter")]
    public IEnumerable<Letter> manualsla_letter
    {
      get => this.GetRelatedEntities<Letter>(nameof (manualsla_letter), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (manualsla_letter));
        this.SetRelatedEntities<Letter>(nameof (manualsla_letter), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (manualsla_letter));
      }
    }

    [RelationshipSchemaName("manualsla_phonecall")]
    public IEnumerable<PhoneCall> manualsla_phonecall
    {
      get => this.GetRelatedEntities<PhoneCall>(nameof (manualsla_phonecall), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (manualsla_phonecall));
        this.SetRelatedEntities<PhoneCall>(nameof (manualsla_phonecall), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (manualsla_phonecall));
      }
    }

    [RelationshipSchemaName("manualsla_socialactivity")]
    public IEnumerable<SocialActivity> manualsla_socialactivity
    {
      get
      {
        return this.GetRelatedEntities<SocialActivity>(nameof (manualsla_socialactivity), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (manualsla_socialactivity));
        this.SetRelatedEntities<SocialActivity>(nameof (manualsla_socialactivity), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (manualsla_socialactivity));
      }
    }

    [RelationshipSchemaName("manualsla_task")]
    public IEnumerable<Task> manualsla_task
    {
      get => this.GetRelatedEntities<Task>(nameof (manualsla_task), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (manualsla_task));
        this.SetRelatedEntities<Task>(nameof (manualsla_task), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (manualsla_task));
      }
    }

    [RelationshipSchemaName("sla_account")]
    public IEnumerable<Account> sla_account
    {
      get => this.GetRelatedEntities<Account>(nameof (sla_account), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (sla_account));
        this.SetRelatedEntities<Account>(nameof (sla_account), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (sla_account));
      }
    }

    [RelationshipSchemaName("sla_activitypointer")]
    public IEnumerable<ActivityPointer> sla_activitypointer
    {
      get
      {
        return this.GetRelatedEntities<ActivityPointer>(nameof (sla_activitypointer), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (sla_activitypointer));
        this.SetRelatedEntities<ActivityPointer>(nameof (sla_activitypointer), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (sla_activitypointer));
      }
    }

    [RelationshipSchemaName("sla_Annotation")]
    public IEnumerable<Annotation> sla_Annotation
    {
      get => this.GetRelatedEntities<Annotation>(nameof (sla_Annotation), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (sla_Annotation));
        this.SetRelatedEntities<Annotation>(nameof (sla_Annotation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (sla_Annotation));
      }
    }

    [RelationshipSchemaName("sla_appointment")]
    public IEnumerable<Appointment> sla_appointment
    {
      get => this.GetRelatedEntities<Appointment>(nameof (sla_appointment), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (sla_appointment));
        this.SetRelatedEntities<Appointment>(nameof (sla_appointment), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (sla_appointment));
      }
    }

    [RelationshipSchemaName("sla_contact")]
    public IEnumerable<Contact> sla_contact
    {
      get => this.GetRelatedEntities<Contact>(nameof (sla_contact), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (sla_contact));
        this.SetRelatedEntities<Contact>(nameof (sla_contact), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (sla_contact));
      }
    }

    [RelationshipSchemaName("sla_email")]
    public IEnumerable<Email> sla_email
    {
      get => this.GetRelatedEntities<Email>(nameof (sla_email), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (sla_email));
        this.SetRelatedEntities<Email>(nameof (sla_email), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (sla_email));
      }
    }

    [RelationshipSchemaName("sla_fax")]
    public IEnumerable<Fax> sla_fax
    {
      get => this.GetRelatedEntities<Fax>(nameof (sla_fax), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (sla_fax));
        this.SetRelatedEntities<Fax>(nameof (sla_fax), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (sla_fax));
      }
    }

    [RelationshipSchemaName("sla_letter")]
    public IEnumerable<Letter> sla_letter
    {
      get => this.GetRelatedEntities<Letter>(nameof (sla_letter), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (sla_letter));
        this.SetRelatedEntities<Letter>(nameof (sla_letter), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (sla_letter));
      }
    }

    [RelationshipSchemaName("sla_phonecall")]
    public IEnumerable<PhoneCall> sla_phonecall
    {
      get => this.GetRelatedEntities<PhoneCall>(nameof (sla_phonecall), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (sla_phonecall));
        this.SetRelatedEntities<PhoneCall>(nameof (sla_phonecall), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (sla_phonecall));
      }
    }

    [RelationshipSchemaName("sla_slaitem_slaId")]
    public IEnumerable<SLAItem> sla_slaitem_slaId
    {
      get => this.GetRelatedEntities<SLAItem>(nameof (sla_slaitem_slaId), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (sla_slaitem_slaId));
        this.SetRelatedEntities<SLAItem>(nameof (sla_slaitem_slaId), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (sla_slaitem_slaId));
      }
    }

    [RelationshipSchemaName("sla_socialactivity")]
    public IEnumerable<SocialActivity> sla_socialactivity
    {
      get
      {
        return this.GetRelatedEntities<SocialActivity>(nameof (sla_socialactivity), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (sla_socialactivity));
        this.SetRelatedEntities<SocialActivity>(nameof (sla_socialactivity), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (sla_socialactivity));
      }
    }

    [RelationshipSchemaName("SLA_SyncErrors")]
    public IEnumerable<SyncError> SLA_SyncErrors
    {
      get => this.GetRelatedEntities<SyncError>(nameof (SLA_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (SLA_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (SLA_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SLA_SyncErrors));
      }
    }

    [RelationshipSchemaName("sla_task")]
    public IEnumerable<Task> sla_task
    {
      get => this.GetRelatedEntities<Task>(nameof (sla_task), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (sla_task));
        this.SetRelatedEntities<Task>(nameof (sla_task), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (sla_task));
      }
    }

    [RelationshipSchemaName("slabase_AsyncOperations")]
    public IEnumerable<AsyncOperation> slabase_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (slabase_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (slabase_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (slabase_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (slabase_AsyncOperations));
      }
    }

    [RelationshipSchemaName("slabase_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> slabase_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (slabase_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (slabase_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (slabase_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (slabase_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("slabase_ProcessSessions")]
    public IEnumerable<ProcessSession> slabase_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (slabase_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (slabase_ProcessSessions));
        this.SetRelatedEntities<ProcessSession>(nameof (slabase_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (slabase_ProcessSessions));
      }
    }

    [RelationshipSchemaName("slabase_userentityinstancedatas")]
    public IEnumerable<UserEntityInstanceData> slabase_userentityinstancedatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (slabase_userentityinstancedatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (slabase_userentityinstancedatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (slabase_userentityinstancedatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (slabase_userentityinstancedatas));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_slabase")]
    public BusinessUnit business_unit_slabase
    {
      get => this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_slabase), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (business_unit_slabase));
        this.SetRelatedEntity<BusinessUnit>(nameof (business_unit_slabase), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_slabase));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_slabase_createdby")]
    public SystemUser lk_slabase_createdby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_slabase_createdby), new EntityRole?());
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_slabase_createdonbehalfby")]
    public SystemUser lk_slabase_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_slabase_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_slabase_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_slabase_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_slabase_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_slabase_modifiedby")]
    public SystemUser lk_slabase_modifiedby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_slabase_modifiedby), new EntityRole?());
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_slabase_modifiedonbehalfby")]
    public SystemUser lk_slabase_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_slabase_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_slabase_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_slabase_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_slabase_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("businesshoursid")]
    [RelationshipSchemaName("slabase_businesshoursid")]
    public Calendar slabase_businesshoursid
    {
      get => this.GetRelatedEntity<Calendar>(nameof (slabase_businesshoursid), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (slabase_businesshoursid));
        this.SetRelatedEntity<Calendar>(nameof (slabase_businesshoursid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (slabase_businesshoursid));
      }
    }

    [AttributeLogicalName("workflowid")]
    [RelationshipSchemaName("slabase_workflowid")]
    public Workflow slabase_workflowid
    {
      get => this.GetRelatedEntity<Workflow>(nameof (slabase_workflowid), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (slabase_workflowid));
        this.SetRelatedEntity<Workflow>(nameof (slabase_workflowid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (slabase_workflowid));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_slaBase")]
    public Team team_slaBase
    {
      get => this.GetRelatedEntity<Team>(nameof (team_slaBase), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_slaBase));
        this.SetRelatedEntity<Team>(nameof (team_slaBase), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_slaBase));
      }
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_SLA")]
    public TransactionCurrency TransactionCurrency_SLA
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_SLA), new EntityRole?());
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_slabase")]
    public SystemUser user_slabase
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_slabase), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (user_slabase));
        this.SetRelatedEntity<SystemUser>(nameof (user_slabase), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (user_slabase));
      }
    }

    public SLA(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["slaid"] = (object) base.Id;
            break;
          case "slaid":
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
