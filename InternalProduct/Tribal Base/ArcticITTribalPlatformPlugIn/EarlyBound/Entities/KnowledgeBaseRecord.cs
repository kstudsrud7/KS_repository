// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.KnowledgeBaseRecord
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("knowledgebaserecord")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class KnowledgeBaseRecord : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "knowledgebaserecord";
    public const string EntitySchemaName = "KnowledgeBaseRecord";
    public const string PrimaryIdAttribute = "knowledgebaserecordid";
    public const string PrimaryNameAttribute = "title";

    public KnowledgeBaseRecord()
      : base("knowledgebaserecord")
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

    [AttributeLogicalName("exchangerate")]
    public Decimal? ExchangeRate => this.GetAttributeValue<Decimal?>("exchangerate");

    [AttributeLogicalName("knowledgebaserecordid")]
    public Guid? KnowledgeBaseRecordId
    {
      get => this.GetAttributeValue<Guid?>("knowledgebaserecordid");
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeBaseRecordId));
        this.SetAttributeValue("knowledgebaserecordid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (KnowledgeBaseRecordId));
      }
    }

    [AttributeLogicalName("knowledgebaserecordid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.KnowledgeBaseRecordId = new Guid?(value);
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

    [AttributeLogicalName("privateurl")]
    public string PrivateUrl
    {
      get => this.GetAttributeValue<string>("privateurl");
      set
      {
        this.OnPropertyChanging(nameof (PrivateUrl));
        this.SetAttributeValue("privateurl", (object) value);
        this.OnPropertyChanged(nameof (PrivateUrl));
      }
    }

    [AttributeLogicalName("publicurl")]
    public string PublicUrl
    {
      get => this.GetAttributeValue<string>("publicurl");
      set
      {
        this.OnPropertyChanging(nameof (PublicUrl));
        this.SetAttributeValue("publicurl", (object) value);
        this.OnPropertyChanged(nameof (PublicUrl));
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

    [AttributeLogicalName("title")]
    public string Title
    {
      get => this.GetAttributeValue<string>("title");
      set
      {
        this.OnPropertyChanging(nameof (Title));
        this.SetAttributeValue("title", (object) value);
        this.OnPropertyChanged(nameof (Title));
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

    [AttributeLogicalName("uniqueid")]
    public string UniqueId
    {
      get => this.GetAttributeValue<string>("uniqueid");
      set
      {
        this.OnPropertyChanging(nameof (UniqueId));
        this.SetAttributeValue("uniqueid", (object) value);
        this.OnPropertyChanged(nameof (UniqueId));
      }
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("KnowledgeBaseRecord_ActivityPointers")]
    public IEnumerable<ActivityPointer> KnowledgeBaseRecord_ActivityPointers
    {
      get
      {
        return this.GetRelatedEntities<ActivityPointer>(nameof (KnowledgeBaseRecord_ActivityPointers), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeBaseRecord_ActivityPointers));
        this.SetRelatedEntities<ActivityPointer>(nameof (KnowledgeBaseRecord_ActivityPointers), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeBaseRecord_ActivityPointers));
      }
    }

    [RelationshipSchemaName("KnowledgeBaseRecord_Annotations")]
    public IEnumerable<Annotation> KnowledgeBaseRecord_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (KnowledgeBaseRecord_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeBaseRecord_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (KnowledgeBaseRecord_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeBaseRecord_Annotations));
      }
    }

    [RelationshipSchemaName("KnowledgeBaseRecord_Appointments")]
    public IEnumerable<Appointment> KnowledgeBaseRecord_Appointments
    {
      get
      {
        return this.GetRelatedEntities<Appointment>(nameof (KnowledgeBaseRecord_Appointments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeBaseRecord_Appointments));
        this.SetRelatedEntities<Appointment>(nameof (KnowledgeBaseRecord_Appointments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeBaseRecord_Appointments));
      }
    }

    [RelationshipSchemaName("KnowledgeBaseRecord_AsyncOperations")]
    public IEnumerable<AsyncOperation> KnowledgeBaseRecord_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (KnowledgeBaseRecord_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeBaseRecord_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (KnowledgeBaseRecord_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeBaseRecord_AsyncOperations));
      }
    }

    [RelationshipSchemaName("KnowledgeBaseRecord_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> KnowledgeBaseRecord_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (KnowledgeBaseRecord_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeBaseRecord_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (KnowledgeBaseRecord_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeBaseRecord_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("KnowledgeBaseRecord_connections1")]
    public IEnumerable<Connection> KnowledgeBaseRecord_connections1
    {
      get
      {
        return this.GetRelatedEntities<Connection>(nameof (KnowledgeBaseRecord_connections1), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeBaseRecord_connections1));
        this.SetRelatedEntities<Connection>(nameof (KnowledgeBaseRecord_connections1), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeBaseRecord_connections1));
      }
    }

    [RelationshipSchemaName("KnowledgeBaseRecord_connections2")]
    public IEnumerable<Connection> KnowledgeBaseRecord_connections2
    {
      get
      {
        return this.GetRelatedEntities<Connection>(nameof (KnowledgeBaseRecord_connections2), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeBaseRecord_connections2));
        this.SetRelatedEntities<Connection>(nameof (KnowledgeBaseRecord_connections2), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeBaseRecord_connections2));
      }
    }

    [RelationshipSchemaName("KnowledgeBaseRecord_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> KnowledgeBaseRecord_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (KnowledgeBaseRecord_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeBaseRecord_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (KnowledgeBaseRecord_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeBaseRecord_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("KnowledgeBaseRecord_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> KnowledgeBaseRecord_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (KnowledgeBaseRecord_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeBaseRecord_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (KnowledgeBaseRecord_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeBaseRecord_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("KnowledgeBaseRecord_Emails")]
    public IEnumerable<Email> KnowledgeBaseRecord_Emails
    {
      get => this.GetRelatedEntities<Email>(nameof (KnowledgeBaseRecord_Emails), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeBaseRecord_Emails));
        this.SetRelatedEntities<Email>(nameof (KnowledgeBaseRecord_Emails), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeBaseRecord_Emails));
      }
    }

    [RelationshipSchemaName("KnowledgeBaseRecord_Faxes")]
    public IEnumerable<Fax> KnowledgeBaseRecord_Faxes
    {
      get => this.GetRelatedEntities<Fax>(nameof (KnowledgeBaseRecord_Faxes), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeBaseRecord_Faxes));
        this.SetRelatedEntities<Fax>(nameof (KnowledgeBaseRecord_Faxes), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeBaseRecord_Faxes));
      }
    }

    [RelationshipSchemaName("KnowledgeBaseRecord_Letters")]
    public IEnumerable<Letter> KnowledgeBaseRecord_Letters
    {
      get
      {
        return this.GetRelatedEntities<Letter>(nameof (KnowledgeBaseRecord_Letters), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeBaseRecord_Letters));
        this.SetRelatedEntities<Letter>(nameof (KnowledgeBaseRecord_Letters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeBaseRecord_Letters));
      }
    }

    [RelationshipSchemaName("KnowledgeBaseRecord_PhoneCalls")]
    public IEnumerable<PhoneCall> KnowledgeBaseRecord_PhoneCalls
    {
      get
      {
        return this.GetRelatedEntities<PhoneCall>(nameof (KnowledgeBaseRecord_PhoneCalls), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeBaseRecord_PhoneCalls));
        this.SetRelatedEntities<PhoneCall>(nameof (KnowledgeBaseRecord_PhoneCalls), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeBaseRecord_PhoneCalls));
      }
    }

    [RelationshipSchemaName("KnowledgeBaseRecord_PrincipalObjectAttributeAccess")]
    public IEnumerable<PrincipalObjectAttributeAccess> KnowledgeBaseRecord_PrincipalObjectAttributeAccess
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (KnowledgeBaseRecord_PrincipalObjectAttributeAccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeBaseRecord_PrincipalObjectAttributeAccess));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (KnowledgeBaseRecord_PrincipalObjectAttributeAccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeBaseRecord_PrincipalObjectAttributeAccess));
      }
    }

    [RelationshipSchemaName("KnowledgeBaseRecord_ProcessSession")]
    public IEnumerable<ProcessSession> KnowledgeBaseRecord_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (KnowledgeBaseRecord_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeBaseRecord_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (KnowledgeBaseRecord_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeBaseRecord_ProcessSession));
      }
    }

    [RelationshipSchemaName("KnowledgeBaseRecord_RecurringAppointmentMasters")]
    public IEnumerable<RecurringAppointmentMaster> KnowledgeBaseRecord_RecurringAppointmentMasters
    {
      get
      {
        return this.GetRelatedEntities<RecurringAppointmentMaster>(nameof (KnowledgeBaseRecord_RecurringAppointmentMasters), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeBaseRecord_RecurringAppointmentMasters));
        this.SetRelatedEntities<RecurringAppointmentMaster>(nameof (KnowledgeBaseRecord_RecurringAppointmentMasters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeBaseRecord_RecurringAppointmentMasters));
      }
    }

    [RelationshipSchemaName("KnowledgeBaseRecord_SocialActivities")]
    public IEnumerable<SocialActivity> KnowledgeBaseRecord_SocialActivities
    {
      get
      {
        return this.GetRelatedEntities<SocialActivity>(nameof (KnowledgeBaseRecord_SocialActivities), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeBaseRecord_SocialActivities));
        this.SetRelatedEntities<SocialActivity>(nameof (KnowledgeBaseRecord_SocialActivities), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeBaseRecord_SocialActivities));
      }
    }

    [RelationshipSchemaName("KnowledgeBaseRecord_SyncErrors")]
    public IEnumerable<SyncError> KnowledgeBaseRecord_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (KnowledgeBaseRecord_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeBaseRecord_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (KnowledgeBaseRecord_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeBaseRecord_SyncErrors));
      }
    }

    [RelationshipSchemaName("KnowledgeBaseRecord_Tasks")]
    public IEnumerable<Task> KnowledgeBaseRecord_Tasks
    {
      get => this.GetRelatedEntities<Task>(nameof (KnowledgeBaseRecord_Tasks), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeBaseRecord_Tasks));
        this.SetRelatedEntities<Task>(nameof (KnowledgeBaseRecord_Tasks), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeBaseRecord_Tasks));
      }
    }

    [RelationshipSchemaName("KnowledgeBaseRecord_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> KnowledgeBaseRecord_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (KnowledgeBaseRecord_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeBaseRecord_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (KnowledgeBaseRecord_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeBaseRecord_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_KnowledgeBaseRecord_createdby")]
    public SystemUser lk_KnowledgeBaseRecord_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_KnowledgeBaseRecord_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_KnowledgeBaseRecord_createdonbehalfby")]
    public SystemUser lk_KnowledgeBaseRecord_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_KnowledgeBaseRecord_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_KnowledgeBaseRecord_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_KnowledgeBaseRecord_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_KnowledgeBaseRecord_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_KnowledgeBaseRecord_modifiedby")]
    public SystemUser lk_KnowledgeBaseRecord_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_KnowledgeBaseRecord_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_KnowledgeBaseRecord_modifiedonbehalfby")]
    public SystemUser lk_KnowledgeBaseRecord_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_KnowledgeBaseRecord_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_KnowledgeBaseRecord_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_KnowledgeBaseRecord_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_KnowledgeBaseRecord_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_KnowledgeBaseRecord")]
    public Organization organization_KnowledgeBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_KnowledgeBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_KnowledgeBaseRecord")]
    public TransactionCurrency TransactionCurrency_KnowledgeBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_KnowledgeBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_KnowledgeBaseRecord));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_KnowledgeBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_KnowledgeBaseRecord));
      }
    }

    public KnowledgeBaseRecord(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["knowledgebaserecordid"] = (object) base.Id;
            break;
          case "knowledgebaserecordid":
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
