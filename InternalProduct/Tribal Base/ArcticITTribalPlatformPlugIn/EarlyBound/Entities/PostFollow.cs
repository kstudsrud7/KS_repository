// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.PostFollow
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("postfollow")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class PostFollow : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "postfollow";
    public const string EntitySchemaName = "PostFollow";
    public const string PrimaryIdAttribute = "postfollowid";
    public const string PrimaryNameAttribute = "regardingobjectidname";

    public PostFollow()
      : base("postfollow")
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

    [AttributeLogicalName("postfollowid")]
    public Guid? PostFollowId
    {
      get => this.GetAttributeValue<Guid?>("postfollowid");
      set
      {
        this.OnPropertyChanging(nameof (PostFollowId));
        this.SetAttributeValue("postfollowid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (PostFollowId));
      }
    }

    [AttributeLogicalName("postfollowid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.PostFollowId = new Guid?(value);
    }

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

    [AttributeLogicalName("yammerpoststate")]
    public int? YammerPostState => this.GetAttributeValue<int?>("yammerpoststate");

    [RelationshipSchemaName("PostFollow_AsyncOperations")]
    public IEnumerable<AsyncOperation> PostFollow_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (PostFollow_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (PostFollow_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (PostFollow_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (PostFollow_AsyncOperations));
      }
    }

    [RelationshipSchemaName("PostFollow_SyncErrors")]
    public IEnumerable<SyncError> PostFollow_SyncErrors
    {
      get => this.GetRelatedEntities<SyncError>(nameof (PostFollow_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (PostFollow_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (PostFollow_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (PostFollow_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("account_PostFollows")]
    public Account account_PostFollows
    {
      get => this.GetRelatedEntity<Account>(nameof (account_PostFollows), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (account_PostFollows));
        this.SetRelatedEntity<Account>(nameof (account_PostFollows), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (account_PostFollows));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("appointment_PostFollows")]
    public Appointment appointment_PostFollows
    {
      get
      {
        return this.GetRelatedEntity<Appointment>(nameof (appointment_PostFollows), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appointment_PostFollows));
        this.SetRelatedEntity<Appointment>(nameof (appointment_PostFollows), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appointment_PostFollows));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_postfollows")]
    public BusinessUnit business_unit_postfollows
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_postfollows), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("contact_PostFollows")]
    public Contact contact_PostFollows
    {
      get => this.GetRelatedEntity<Contact>(nameof (contact_PostFollows), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (contact_PostFollows));
        this.SetRelatedEntity<Contact>(nameof (contact_PostFollows), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (contact_PostFollows));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("knowledgearticle_PostFollows")]
    public KnowledgeArticle knowledgearticle_PostFollows
    {
      get
      {
        return this.GetRelatedEntity<KnowledgeArticle>(nameof (knowledgearticle_PostFollows), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (knowledgearticle_PostFollows));
        this.SetRelatedEntity<KnowledgeArticle>(nameof (knowledgearticle_PostFollows), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (knowledgearticle_PostFollows));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_PostFollow_createdby")]
    public SystemUser lk_PostFollow_createdby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_PostFollow_createdby), new EntityRole?());
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_postfollow_createdonbehalfby")]
    public SystemUser lk_postfollow_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_postfollow_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_postfollow_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_postfollow_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_postfollow_createdonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("OwningTeam_postfollows")]
    public Team OwningTeam_postfollows
    {
      get => this.GetRelatedEntity<Team>(nameof (OwningTeam_postfollows), new EntityRole?());
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("phonecall_PostFollows")]
    public PhoneCall phonecall_PostFollows
    {
      get => this.GetRelatedEntity<PhoneCall>(nameof (phonecall_PostFollows), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (phonecall_PostFollows));
        this.SetRelatedEntity<PhoneCall>(nameof (phonecall_PostFollows), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (phonecall_PostFollows));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("processsession_PostFollows")]
    public ProcessSession processsession_PostFollows
    {
      get
      {
        return this.GetRelatedEntity<ProcessSession>(nameof (processsession_PostFollows), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (processsession_PostFollows));
        this.SetRelatedEntity<ProcessSession>(nameof (processsession_PostFollows), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (processsession_PostFollows));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("queue_PostFollows")]
    public Queue queue_PostFollows
    {
      get => this.GetRelatedEntity<Queue>(nameof (queue_PostFollows), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (queue_PostFollows));
        this.SetRelatedEntity<Queue>(nameof (queue_PostFollows), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (queue_PostFollows));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("recurringappointmentmaster_PostFollows")]
    public RecurringAppointmentMaster recurringappointmentmaster_PostFollows
    {
      get
      {
        return this.GetRelatedEntity<RecurringAppointmentMaster>(nameof (recurringappointmentmaster_PostFollows), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (recurringappointmentmaster_PostFollows));
        this.SetRelatedEntity<RecurringAppointmentMaster>(nameof (recurringappointmentmaster_PostFollows), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (recurringappointmentmaster_PostFollows));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("systemuser_PostFollows")]
    public SystemUser systemuser_PostFollows
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (systemuser_PostFollows), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (systemuser_PostFollows));
        this.SetRelatedEntity<SystemUser>(nameof (systemuser_PostFollows), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (systemuser_PostFollows));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("task_PostFollows")]
    public Task task_PostFollows
    {
      get => this.GetRelatedEntity<Task>(nameof (task_PostFollows), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (task_PostFollows));
        this.SetRelatedEntity<Task>(nameof (task_PostFollows), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (task_PostFollows));
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_owner_postfollows")]
    public SystemUser user_owner_postfollows
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_owner_postfollows), new EntityRole?());
    }

    public PostFollow(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["postfollowid"] = (object) base.Id;
            break;
          case "postfollowid":
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
