// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ProcessStage
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("processstage")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ProcessStage : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "processstage";
    public const string EntitySchemaName = "ProcessStage";
    public const string PrimaryIdAttribute = "processstageid";
    public const string PrimaryNameAttribute = "stagename";

    public ProcessStage()
      : base("processstage")
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

    [AttributeLogicalName("clientdata")]
    public string ClientData => this.GetAttributeValue<string>("clientdata");

    [AttributeLogicalName("connector")]
    public string Connector
    {
      get => this.GetAttributeValue<string>("connector");
      set
      {
        this.OnPropertyChanging(nameof (Connector));
        this.SetAttributeValue("connector", (object) value);
        this.OnPropertyChanged(nameof (Connector));
      }
    }

    [AttributeLogicalName("istrigger")]
    public bool? IsTrigger
    {
      get => this.GetAttributeValue<bool?>("istrigger");
      set
      {
        this.OnPropertyChanging(nameof (IsTrigger));
        this.SetAttributeValue("istrigger", (object) value);
        this.OnPropertyChanged(nameof (IsTrigger));
      }
    }

    [AttributeLogicalName("operationid")]
    public string OperationId
    {
      get => this.GetAttributeValue<string>("operationid");
      set
      {
        this.OnPropertyChanging(nameof (OperationId));
        this.SetAttributeValue("operationid", (object) value);
        this.OnPropertyChanged(nameof (OperationId));
      }
    }

    [AttributeLogicalName("operationkind")]
    public OptionSetValue OperationKind
    {
      get => this.GetAttributeValue<OptionSetValue>("operationkind");
      set
      {
        this.OnPropertyChanging(nameof (OperationKind));
        this.SetAttributeValue("operationkind", (object) value);
        this.OnPropertyChanged(nameof (OperationKind));
      }
    }

    [AttributeLogicalName("operationtype")]
    public OptionSetValue OperationType
    {
      get => this.GetAttributeValue<OptionSetValue>("operationtype");
      set
      {
        this.OnPropertyChanging(nameof (OperationType));
        this.SetAttributeValue("operationtype", (object) value);
        this.OnPropertyChanged(nameof (OperationType));
      }
    }

    [AttributeLogicalName("ownerid")]
    public EntityReference OwnerId => this.GetAttributeValue<EntityReference>("ownerid");

    [AttributeLogicalName("owningbusinessunit")]
    public Guid? OwningBusinessUnit => this.GetAttributeValue<Guid?>("owningbusinessunit");

    [AttributeLogicalName("primaryentitytypecode")]
    public string PrimaryEntityTypeCode
    {
      get => this.GetAttributeValue<string>("primaryentitytypecode");
      set
      {
        this.OnPropertyChanging(nameof (PrimaryEntityTypeCode));
        this.SetAttributeValue("primaryentitytypecode", (object) value);
        this.OnPropertyChanged(nameof (PrimaryEntityTypeCode));
      }
    }

    [AttributeLogicalName("processid")]
    public EntityReference ProcessId
    {
      get => this.GetAttributeValue<EntityReference>("processid");
      set
      {
        this.OnPropertyChanging(nameof (ProcessId));
        this.SetAttributeValue("processid", (object) value);
        this.OnPropertyChanged(nameof (ProcessId));
      }
    }

    [AttributeLogicalName("processstageid")]
    public Guid? ProcessStageId
    {
      get => this.GetAttributeValue<Guid?>("processstageid");
      set
      {
        this.OnPropertyChanging(nameof (ProcessStageId));
        this.SetAttributeValue("processstageid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ProcessStageId));
      }
    }

    [AttributeLogicalName("processstageid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ProcessStageId = new Guid?(value);
    }

    [AttributeLogicalName("stagecategory")]
    public OptionSetValue StageCategory
    {
      get => this.GetAttributeValue<OptionSetValue>("stagecategory");
      set
      {
        this.OnPropertyChanging(nameof (StageCategory));
        this.SetAttributeValue("stagecategory", (object) value);
        this.OnPropertyChanged(nameof (StageCategory));
      }
    }

    [AttributeLogicalName("stagename")]
    public string StageName
    {
      get => this.GetAttributeValue<string>("stagename");
      set
      {
        this.OnPropertyChanging(nameof (StageName));
        this.SetAttributeValue("stagename", (object) value);
        this.OnPropertyChanged(nameof (StageName));
      }
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("lk_expiredprocess_activestageid")]
    public IEnumerable<ExpiredProcess> lk_expiredprocess_activestageid
    {
      get
      {
        return this.GetRelatedEntities<ExpiredProcess>(nameof (lk_expiredprocess_activestageid), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_expiredprocess_activestageid));
        this.SetRelatedEntities<ExpiredProcess>(nameof (lk_expiredprocess_activestageid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_expiredprocess_activestageid));
      }
    }

    [RelationshipSchemaName("lk_newprocess_activestageid")]
    public IEnumerable<NewProcess> lk_newprocess_activestageid
    {
      get
      {
        return this.GetRelatedEntities<NewProcess>(nameof (lk_newprocess_activestageid), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_newprocess_activestageid));
        this.SetRelatedEntities<NewProcess>(nameof (lk_newprocess_activestageid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_newprocess_activestageid));
      }
    }

    [RelationshipSchemaName("lk_translationprocess_activestageid")]
    public IEnumerable<TranslationProcess> lk_translationprocess_activestageid
    {
      get
      {
        return this.GetRelatedEntities<TranslationProcess>(nameof (lk_translationprocess_activestageid), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_translationprocess_activestageid));
        this.SetRelatedEntities<TranslationProcess>(nameof (lk_translationprocess_activestageid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_translationprocess_activestageid));
      }
    }

    [RelationshipSchemaName("processstage_account")]
    public IEnumerable<Account> processstage_account
    {
      get => this.GetRelatedEntities<Account>(nameof (processstage_account), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (processstage_account));
        this.SetRelatedEntities<Account>(nameof (processstage_account), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (processstage_account));
      }
    }

    [RelationshipSchemaName("processstage_ait_case")]
    public IEnumerable<ait_case> processstage_ait_case
    {
      get => this.GetRelatedEntities<ait_case>(nameof (processstage_ait_case), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (processstage_ait_case));
        this.SetRelatedEntities<ait_case>(nameof (processstage_ait_case), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (processstage_ait_case));
      }
    }

    [RelationshipSchemaName("processstage_appointments")]
    public IEnumerable<Appointment> processstage_appointments
    {
      get
      {
        return this.GetRelatedEntities<Appointment>(nameof (processstage_appointments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (processstage_appointments));
        this.SetRelatedEntities<Appointment>(nameof (processstage_appointments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (processstage_appointments));
      }
    }

    [RelationshipSchemaName("processstage_contact")]
    public IEnumerable<Contact> processstage_contact
    {
      get => this.GetRelatedEntities<Contact>(nameof (processstage_contact), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (processstage_contact));
        this.SetRelatedEntities<Contact>(nameof (processstage_contact), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (processstage_contact));
      }
    }

    [RelationshipSchemaName("processstage_emails")]
    public IEnumerable<Email> processstage_emails
    {
      get => this.GetRelatedEntities<Email>(nameof (processstage_emails), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (processstage_emails));
        this.SetRelatedEntities<Email>(nameof (processstage_emails), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (processstage_emails));
      }
    }

    [RelationshipSchemaName("processstage_faxes")]
    public IEnumerable<Fax> processstage_faxes
    {
      get => this.GetRelatedEntities<Fax>(nameof (processstage_faxes), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (processstage_faxes));
        this.SetRelatedEntities<Fax>(nameof (processstage_faxes), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (processstage_faxes));
      }
    }

    [RelationshipSchemaName("processstage_knowledgearticle")]
    public IEnumerable<KnowledgeArticle> processstage_knowledgearticle
    {
      get
      {
        return this.GetRelatedEntities<KnowledgeArticle>(nameof (processstage_knowledgearticle), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (processstage_knowledgearticle));
        this.SetRelatedEntities<KnowledgeArticle>(nameof (processstage_knowledgearticle), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (processstage_knowledgearticle));
      }
    }

    [RelationshipSchemaName("processstage_letters")]
    public IEnumerable<Letter> processstage_letters
    {
      get => this.GetRelatedEntities<Letter>(nameof (processstage_letters), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (processstage_letters));
        this.SetRelatedEntities<Letter>(nameof (processstage_letters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (processstage_letters));
      }
    }

    [RelationshipSchemaName("processstage_phonecalls")]
    public IEnumerable<PhoneCall> processstage_phonecalls
    {
      get
      {
        return this.GetRelatedEntities<PhoneCall>(nameof (processstage_phonecalls), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (processstage_phonecalls));
        this.SetRelatedEntities<PhoneCall>(nameof (processstage_phonecalls), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (processstage_phonecalls));
      }
    }

    [RelationshipSchemaName("processstage_processstageparameter")]
    public IEnumerable<processstageparameter> processstage_processstageparameter
    {
      get
      {
        return this.GetRelatedEntities<processstageparameter>(nameof (processstage_processstageparameter), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (processstage_processstageparameter));
        this.SetRelatedEntities<processstageparameter>(nameof (processstage_processstageparameter), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (processstage_processstageparameter));
      }
    }

    [RelationshipSchemaName("processstage_recurringappointmentmasters")]
    public IEnumerable<RecurringAppointmentMaster> processstage_recurringappointmentmasters
    {
      get
      {
        return this.GetRelatedEntities<RecurringAppointmentMaster>(nameof (processstage_recurringappointmentmasters), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (processstage_recurringappointmentmasters));
        this.SetRelatedEntities<RecurringAppointmentMaster>(nameof (processstage_recurringappointmentmasters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (processstage_recurringappointmentmasters));
      }
    }

    [RelationshipSchemaName("ProcessStage_SyncErrors")]
    public IEnumerable<SyncError> ProcessStage_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ProcessStage_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ProcessStage_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ProcessStage_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ProcessStage_SyncErrors));
      }
    }

    [RelationshipSchemaName("processstage_systemusers")]
    public IEnumerable<SystemUser> processstage_systemusers
    {
      get
      {
        return this.GetRelatedEntities<SystemUser>(nameof (processstage_systemusers), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (processstage_systemusers));
        this.SetRelatedEntities<SystemUser>(nameof (processstage_systemusers), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (processstage_systemusers));
      }
    }

    [RelationshipSchemaName("processstage_tasks")]
    public IEnumerable<Task> processstage_tasks
    {
      get => this.GetRelatedEntities<Task>(nameof (processstage_tasks), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (processstage_tasks));
        this.SetRelatedEntities<Task>(nameof (processstage_tasks), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (processstage_tasks));
      }
    }

    [RelationshipSchemaName("processstage_teams")]
    public IEnumerable<Team> processstage_teams
    {
      get => this.GetRelatedEntities<Team>(nameof (processstage_teams), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (processstage_teams));
        this.SetRelatedEntities<Team>(nameof (processstage_teams), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (processstage_teams));
      }
    }

    [AttributeLogicalName("processid")]
    [RelationshipSchemaName("process_processstage")]
    public Workflow process_processstage
    {
      get => this.GetRelatedEntity<Workflow>(nameof (process_processstage), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (process_processstage));
        this.SetRelatedEntity<Workflow>(nameof (process_processstage), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (process_processstage));
      }
    }

    public ProcessStage(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["processstageid"] = (object) base.Id;
            break;
          case "processstageid":
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
