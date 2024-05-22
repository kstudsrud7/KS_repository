// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.SLAKPIInstance
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("slakpiinstance")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class SLAKPIInstance : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "slakpiinstance";
    public const string EntitySchemaName = "SLAKPIInstance";
    public const string PrimaryIdAttribute = "slakpiinstanceid";
    public const string PrimaryNameAttribute = "name";

    public SLAKPIInstance()
      : base("slakpiinstance")
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

    [AttributeLogicalName("applicablefromvalue")]
    public DateTime? ApplicableFromValue
    {
      get => this.GetAttributeValue<DateTime?>("applicablefromvalue");
      set
      {
        this.OnPropertyChanging(nameof (ApplicableFromValue));
        this.SetAttributeValue("applicablefromvalue", (object) value);
        this.OnPropertyChanged(nameof (ApplicableFromValue));
      }
    }

    [AttributeLogicalName("computedfailuretime")]
    public DateTime? ComputedFailureTime
    {
      get => this.GetAttributeValue<DateTime?>("computedfailuretime");
      set
      {
        this.OnPropertyChanging(nameof (ComputedFailureTime));
        this.SetAttributeValue("computedfailuretime", (object) value);
        this.OnPropertyChanged(nameof (ComputedFailureTime));
      }
    }

    [AttributeLogicalName("computedwarningtime")]
    public DateTime? ComputedWarningTime
    {
      get => this.GetAttributeValue<DateTime?>("computedwarningtime");
      set
      {
        this.OnPropertyChanging(nameof (ComputedWarningTime));
        this.SetAttributeValue("computedwarningtime", (object) value);
        this.OnPropertyChanged(nameof (ComputedWarningTime));
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

    [AttributeLogicalName("elapsedtime")]
    public int? ElapsedTime
    {
      get => this.GetAttributeValue<int?>("elapsedtime");
      set
      {
        this.OnPropertyChanging(nameof (ElapsedTime));
        this.SetAttributeValue("elapsedtime", (object) value);
        this.OnPropertyChanged(nameof (ElapsedTime));
      }
    }

    [AttributeLogicalName("exchangerate")]
    public Decimal? ExchangeRate => this.GetAttributeValue<Decimal?>("exchangerate");

    [AttributeLogicalName("failuretime")]
    public DateTime? FailureTime
    {
      get => this.GetAttributeValue<DateTime?>("failuretime");
      set
      {
        this.OnPropertyChanging(nameof (FailureTime));
        this.SetAttributeValue("failuretime", (object) value);
        this.OnPropertyChanged(nameof (FailureTime));
      }
    }

    [AttributeLogicalName("lastresumetime")]
    public DateTime? LastResumeTime
    {
      get => this.GetAttributeValue<DateTime?>("lastresumetime");
      set
      {
        this.OnPropertyChanging(nameof (LastResumeTime));
        this.SetAttributeValue("lastresumetime", (object) value);
        this.OnPropertyChanged(nameof (LastResumeTime));
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

    [AttributeLogicalName("msdyn_actionexecutionstatus")]
    public OptionSetValue msdyn_ActionExecutionStatus
    {
      get => this.GetAttributeValue<OptionSetValue>("msdyn_actionexecutionstatus");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_ActionExecutionStatus));
        this.SetAttributeValue("msdyn_actionexecutionstatus", (object) value);
        this.OnPropertyChanged(nameof (msdyn_ActionExecutionStatus));
      }
    }

    [AttributeLogicalName("msdyn_calendarid")]
    public string msdyn_calendarid
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_calendarid));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_calendarid));
        this.SetAttributeValue(nameof (msdyn_calendarid), (object) value);
        this.OnPropertyChanged(nameof (msdyn_calendarid));
      }
    }

    [AttributeLogicalName("msdyn_prevslakpiinstanceid")]
    public string msdyn_prevslakpiinstanceid
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_prevslakpiinstanceid));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_prevslakpiinstanceid));
        this.SetAttributeValue(nameof (msdyn_prevslakpiinstanceid), (object) value);
        this.OnPropertyChanged(nameof (msdyn_prevslakpiinstanceid));
      }
    }

    [AttributeLogicalName("msdyn_slaitemid")]
    public EntityReference msdyn_slaitemid
    {
      get => this.GetAttributeValue<EntityReference>(nameof (msdyn_slaitemid));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_slaitemid));
        this.SetAttributeValue(nameof (msdyn_slaitemid), (object) value);
        this.OnPropertyChanged(nameof (msdyn_slaitemid));
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

    [AttributeLogicalName("pausedon")]
    public DateTime? PausedOn
    {
      get => this.GetAttributeValue<DateTime?>("pausedon");
      set
      {
        this.OnPropertyChanging(nameof (PausedOn));
        this.SetAttributeValue("pausedon", (object) value);
        this.OnPropertyChanged(nameof (PausedOn));
      }
    }

    [AttributeLogicalName("regarding")]
    public EntityReference Regarding
    {
      get => this.GetAttributeValue<EntityReference>("regarding");
      set
      {
        this.OnPropertyChanging(nameof (Regarding));
        this.SetAttributeValue("regarding", (object) value);
        this.OnPropertyChanged(nameof (Regarding));
      }
    }

    [AttributeLogicalName("regardingentityid")]
    public string RegardingEntityID
    {
      get => this.GetAttributeValue<string>("regardingentityid");
      set
      {
        this.OnPropertyChanging(nameof (RegardingEntityID));
        this.SetAttributeValue("regardingentityid", (object) value);
        this.OnPropertyChanged(nameof (RegardingEntityID));
      }
    }

    [AttributeLogicalName("slakpiinstanceid")]
    public Guid? SLAKPIInstanceId
    {
      get => this.GetAttributeValue<Guid?>("slakpiinstanceid");
      set
      {
        this.OnPropertyChanging(nameof (SLAKPIInstanceId));
        this.SetAttributeValue("slakpiinstanceid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (SLAKPIInstanceId));
      }
    }

    [AttributeLogicalName("slakpiinstanceid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.SLAKPIInstanceId = new Guid?(value);
    }

    [AttributeLogicalName("status")]
    public OptionSetValue Status
    {
      get => this.GetAttributeValue<OptionSetValue>("status");
      set
      {
        this.OnPropertyChanging(nameof (Status));
        this.SetAttributeValue("status", (object) value);
        this.OnPropertyChanged(nameof (Status));
      }
    }

    [AttributeLogicalName("succeededon")]
    public DateTime? SucceededOn
    {
      get => this.GetAttributeValue<DateTime?>("succeededon");
      set
      {
        this.OnPropertyChanging(nameof (SucceededOn));
        this.SetAttributeValue("succeededon", (object) value);
        this.OnPropertyChanged(nameof (SucceededOn));
      }
    }

    [AttributeLogicalName("successcheckedat")]
    public DateTime? SuccessCheckedAt
    {
      get => this.GetAttributeValue<DateTime?>("successcheckedat");
      set
      {
        this.OnPropertyChanging(nameof (SuccessCheckedAt));
        this.SetAttributeValue("successcheckedat", (object) value);
        this.OnPropertyChanged(nameof (SuccessCheckedAt));
      }
    }

    [AttributeLogicalName("terminalstatereached")]
    public bool? TerminalStateReached
    {
      get => this.GetAttributeValue<bool?>("terminalstatereached");
      set
      {
        this.OnPropertyChanging(nameof (TerminalStateReached));
        this.SetAttributeValue("terminalstatereached", (object) value);
        this.OnPropertyChanged(nameof (TerminalStateReached));
      }
    }

    [AttributeLogicalName("terminalstatetime")]
    public DateTime? TerminalStateTime
    {
      get => this.GetAttributeValue<DateTime?>("terminalstatetime");
      set
      {
        this.OnPropertyChanging(nameof (TerminalStateTime));
        this.SetAttributeValue("terminalstatetime", (object) value);
        this.OnPropertyChanged(nameof (TerminalStateTime));
      }
    }

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

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [AttributeLogicalName("warningtime")]
    public DateTime? WarningTime
    {
      get => this.GetAttributeValue<DateTime?>("warningtime");
      set
      {
        this.OnPropertyChanging(nameof (WarningTime));
        this.SetAttributeValue("warningtime", (object) value);
        this.OnPropertyChanged(nameof (WarningTime));
      }
    }

    [AttributeLogicalName("warningtimereached")]
    public OptionSetValue WarningTimeReached
    {
      get => this.GetAttributeValue<OptionSetValue>("warningtimereached");
      set
      {
        this.OnPropertyChanging(nameof (WarningTimeReached));
        this.SetAttributeValue("warningtimereached", (object) value);
        this.OnPropertyChanged(nameof (WarningTimeReached));
      }
    }

    [RelationshipSchemaName("SLAKPIInstance_SyncErrors")]
    public IEnumerable<SyncError> SLAKPIInstance_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (SLAKPIInstance_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SLAKPIInstance_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (SLAKPIInstance_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SLAKPIInstance_SyncErrors));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_slakpiinstance")]
    public BusinessUnit business_unit_slakpiinstance
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_slakpiinstance), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_slakpiinstance));
        this.SetRelatedEntity<BusinessUnit>(nameof (business_unit_slakpiinstance), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_slakpiinstance));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_slakpiinstancebase_createdby")]
    public SystemUser lk_slakpiinstancebase_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_slakpiinstancebase_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_slakpiinstancebase_createdonbehalfby")]
    public SystemUser lk_slakpiinstancebase_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_slakpiinstancebase_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_slakpiinstancebase_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_slakpiinstancebase_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_slakpiinstancebase_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_slakpiinstancebase_modifiedby")]
    public SystemUser lk_slakpiinstancebase_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_slakpiinstancebase_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_slakpiinstancebase_modifiedonbehalfby")]
    public SystemUser lk_slakpiinstancebase_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_slakpiinstancebase_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_slakpiinstancebase_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_slakpiinstancebase_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_slakpiinstancebase_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("msdyn_slaitemid")]
    [RelationshipSchemaName("msdyn_slaitem_slakpiinstance")]
    public SLAItem msdyn_slaitem_slakpiinstance
    {
      get
      {
        return this.GetRelatedEntity<SLAItem>(nameof (msdyn_slaitem_slakpiinstance), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_slaitem_slakpiinstance));
        this.SetRelatedEntity<SLAItem>(nameof (msdyn_slaitem_slakpiinstance), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_slaitem_slakpiinstance));
      }
    }

    [AttributeLogicalName("regarding")]
    [RelationshipSchemaName("slakpiinstance_account")]
    public Account slakpiinstance_account
    {
      get => this.GetRelatedEntity<Account>(nameof (slakpiinstance_account), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (slakpiinstance_account));
        this.SetRelatedEntity<Account>(nameof (slakpiinstance_account), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (slakpiinstance_account));
      }
    }

    [AttributeLogicalName("regarding")]
    [RelationshipSchemaName("slakpiinstance_activitypointer")]
    public ActivityPointer slakpiinstance_activitypointer
    {
      get
      {
        return this.GetRelatedEntity<ActivityPointer>(nameof (slakpiinstance_activitypointer), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (slakpiinstance_activitypointer));
        this.SetRelatedEntity<ActivityPointer>(nameof (slakpiinstance_activitypointer), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (slakpiinstance_activitypointer));
      }
    }

    [AttributeLogicalName("regarding")]
    [RelationshipSchemaName("slakpiinstance_appointment")]
    public Appointment slakpiinstance_appointment
    {
      get
      {
        return this.GetRelatedEntity<Appointment>(nameof (slakpiinstance_appointment), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (slakpiinstance_appointment));
        this.SetRelatedEntity<Appointment>(nameof (slakpiinstance_appointment), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (slakpiinstance_appointment));
      }
    }

    [AttributeLogicalName("regarding")]
    [RelationshipSchemaName("slakpiinstance_contact")]
    public Contact slakpiinstance_contact
    {
      get => this.GetRelatedEntity<Contact>(nameof (slakpiinstance_contact), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (slakpiinstance_contact));
        this.SetRelatedEntity<Contact>(nameof (slakpiinstance_contact), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (slakpiinstance_contact));
      }
    }

    [AttributeLogicalName("regarding")]
    [RelationshipSchemaName("slakpiinstance_email")]
    public Email slakpiinstance_email
    {
      get => this.GetRelatedEntity<Email>(nameof (slakpiinstance_email), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (slakpiinstance_email));
        this.SetRelatedEntity<Email>(nameof (slakpiinstance_email), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (slakpiinstance_email));
      }
    }

    [AttributeLogicalName("regarding")]
    [RelationshipSchemaName("slakpiinstance_fax")]
    public Fax slakpiinstance_fax
    {
      get => this.GetRelatedEntity<Fax>(nameof (slakpiinstance_fax), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (slakpiinstance_fax));
        this.SetRelatedEntity<Fax>(nameof (slakpiinstance_fax), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (slakpiinstance_fax));
      }
    }

    [AttributeLogicalName("regarding")]
    [RelationshipSchemaName("slakpiinstance_letter")]
    public Letter slakpiinstance_letter
    {
      get => this.GetRelatedEntity<Letter>(nameof (slakpiinstance_letter), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (slakpiinstance_letter));
        this.SetRelatedEntity<Letter>(nameof (slakpiinstance_letter), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (slakpiinstance_letter));
      }
    }

    [AttributeLogicalName("regarding")]
    [RelationshipSchemaName("slakpiinstance_phonecall")]
    public PhoneCall slakpiinstance_phonecall
    {
      get => this.GetRelatedEntity<PhoneCall>(nameof (slakpiinstance_phonecall), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (slakpiinstance_phonecall));
        this.SetRelatedEntity<PhoneCall>(nameof (slakpiinstance_phonecall), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (slakpiinstance_phonecall));
      }
    }

    [AttributeLogicalName("regarding")]
    [RelationshipSchemaName("slakpiinstance_socialactivity")]
    public SocialActivity slakpiinstance_socialactivity
    {
      get
      {
        return this.GetRelatedEntity<SocialActivity>(nameof (slakpiinstance_socialactivity), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (slakpiinstance_socialactivity));
        this.SetRelatedEntity<SocialActivity>(nameof (slakpiinstance_socialactivity), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (slakpiinstance_socialactivity));
      }
    }

    [AttributeLogicalName("regarding")]
    [RelationshipSchemaName("slakpiinstance_task")]
    public Task slakpiinstance_task
    {
      get => this.GetRelatedEntity<Task>(nameof (slakpiinstance_task), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (slakpiinstance_task));
        this.SetRelatedEntity<Task>(nameof (slakpiinstance_task), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (slakpiinstance_task));
      }
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_slakpiinstance")]
    public TransactionCurrency TransactionCurrency_slakpiinstance
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_slakpiinstance), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_slakpiinstance));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_slakpiinstance), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_slakpiinstance));
      }
    }

    public SLAKPIInstance(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["slakpiinstanceid"] = (object) base.Id;
            break;
          case "slakpiinstanceid":
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
