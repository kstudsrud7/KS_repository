// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_groupactivity
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_groupactivity")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_groupactivity : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_groupactivity";
    public const string EntitySchemaName = "ait_groupactivity";
    public const string PrimaryIdAttribute = "ait_groupactivityid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_groupactivity()
      : base(nameof (ait_groupactivity))
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

    [AttributeLogicalName("ait_activityobjective")]
    public string ait_ActivityObjective
    {
      get => this.GetAttributeValue<string>("ait_activityobjective");
      set
      {
        this.OnPropertyChanging(nameof (ait_ActivityObjective));
        this.SetAttributeValue("ait_activityobjective", (object) value);
        this.OnPropertyChanged(nameof (ait_ActivityObjective));
      }
    }

    [AttributeLogicalName("ait_activitystartdate")]
    public DateTime? ait_ActivityStartDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_activitystartdate");
      set
      {
        this.OnPropertyChanging(nameof (ait_ActivityStartDate));
        this.SetAttributeValue("ait_activitystartdate", (object) value);
        this.OnPropertyChanged(nameof (ait_ActivityStartDate));
      }
    }

    [AttributeLogicalName("ait_duration")]
    public int? ait_Duration
    {
      get => this.GetAttributeValue<int?>("ait_duration");
      set
      {
        this.OnPropertyChanging(nameof (ait_Duration));
        this.SetAttributeValue("ait_duration", (object) value);
        this.OnPropertyChanged(nameof (ait_Duration));
      }
    }

    [AttributeLogicalName("ait_eventtype")]
    public OptionSetValue ait_EventType
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_eventtype");
      set
      {
        this.OnPropertyChanging(nameof (ait_EventType));
        this.SetAttributeValue("ait_eventtype", (object) value);
        this.OnPropertyChanged(nameof (ait_EventType));
      }
    }

    [AttributeLogicalName("ait_groupactivityid")]
    public Guid? ait_groupactivityId
    {
      get => this.GetAttributeValue<Guid?>("ait_groupactivityid");
      set
      {
        this.OnPropertyChanging(nameof (ait_groupactivityId));
        this.SetAttributeValue("ait_groupactivityid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_groupactivityId));
      }
    }

    [AttributeLogicalName("ait_groupactivityid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_groupactivityId = new Guid?(value);
    }

    [AttributeLogicalName("ait_groupactivityidauto")]
    public string ait_GroupActivityIDauto
    {
      get => this.GetAttributeValue<string>("ait_groupactivityidauto");
      set
      {
        this.OnPropertyChanging(nameof (ait_GroupActivityIDauto));
        this.SetAttributeValue("ait_groupactivityidauto", (object) value);
        this.OnPropertyChanged(nameof (ait_GroupActivityIDauto));
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

    [AttributeLogicalName("ait_numberofactivities")]
    public int? ait_NumberofActivities
    {
      get => this.GetAttributeValue<int?>("ait_numberofactivities");
      set
      {
        this.OnPropertyChanging(nameof (ait_NumberofActivities));
        this.SetAttributeValue("ait_numberofactivities", (object) value);
        this.OnPropertyChanged(nameof (ait_NumberofActivities));
      }
    }

    [AttributeLogicalName("ait_program")]
    public EntityReference ait_Program
    {
      get => this.GetAttributeValue<EntityReference>("ait_program");
      set
      {
        this.OnPropertyChanging(nameof (ait_Program));
        this.SetAttributeValue("ait_program", (object) value);
        this.OnPropertyChanged(nameof (ait_Program));
      }
    }

    [AttributeLogicalName("ait_totalattendees")]
    public int? ait_TotalAttendees
    {
      get => this.GetAttributeValue<int?>("ait_totalattendees");
      set
      {
        this.OnPropertyChanging(nameof (ait_TotalAttendees));
        this.SetAttributeValue("ait_totalattendees", (object) value);
        this.OnPropertyChanged(nameof (ait_TotalAttendees));
      }
    }

    [AttributeLogicalName("ait_totalmeetings")]
    public int? ait_TotalMeetings => this.GetAttributeValue<int?>("ait_totalmeetings");

    [AttributeLogicalName("ait_totalmeetings_date")]
    public DateTime? ait_TotalMeetings_Date
    {
      get => this.GetAttributeValue<DateTime?>("ait_totalmeetings_date");
    }

    [AttributeLogicalName("ait_totalmeetings_state")]
    public int? ait_TotalMeetings_State => this.GetAttributeValue<int?>("ait_totalmeetings_state");

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
    public ait_groupactivityState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_groupactivityState?((ait_groupactivityState) Enum.ToObject(typeof (ait_groupactivityState), attributeValue.Value)) : new ait_groupactivityState?();
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

    [RelationshipSchemaName("ait_ait_groupactivity_ait_groupactivitymeeting_GroupActivity")]
    public IEnumerable<ait_groupactivitymeeting> ait_ait_groupactivity_ait_groupactivitymeeting_GroupActivity
    {
      get
      {
        return this.GetRelatedEntities<ait_groupactivitymeeting>(nameof (ait_ait_groupactivity_ait_groupactivitymeeting_GroupActivity), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_groupactivity_ait_groupactivitymeeting_GroupActivity));
        this.SetRelatedEntities<ait_groupactivitymeeting>(nameof (ait_ait_groupactivity_ait_groupactivitymeeting_GroupActivity), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_groupactivity_ait_groupactivitymeeting_GroupActivity));
      }
    }

    [RelationshipSchemaName("ait_groupactivity_ActivityParties")]
    public IEnumerable<ActivityParty> ait_groupactivity_ActivityParties
    {
      get
      {
        return this.GetRelatedEntities<ActivityParty>(nameof (ait_groupactivity_ActivityParties), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_groupactivity_ActivityParties));
        this.SetRelatedEntities<ActivityParty>(nameof (ait_groupactivity_ActivityParties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_groupactivity_ActivityParties));
      }
    }

    [RelationshipSchemaName("ait_groupactivity_Annotations")]
    public IEnumerable<Annotation> ait_groupactivity_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (ait_groupactivity_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_groupactivity_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (ait_groupactivity_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_groupactivity_Annotations));
      }
    }

    [RelationshipSchemaName("ait_groupactivity_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_groupactivity_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_groupactivity_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_groupactivity_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_groupactivity_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_groupactivity_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_groupactivity_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_groupactivity_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_groupactivity_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_groupactivity_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_groupactivity_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_groupactivity_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_groupactivity_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_groupactivity_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_groupactivity_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_groupactivity_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_groupactivity_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_groupactivity_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_groupactivity_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_groupactivity_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_groupactivity_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_groupactivity_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_groupactivity_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_groupactivity_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_groupactivity_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_groupactivity_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_groupactivity_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_groupactivity_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_groupactivity_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_groupactivity_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_groupactivity_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_groupactivity_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_groupactivity_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_groupactivity_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_groupactivity_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_groupactivity_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_groupactivity_ProcessSession")]
    public IEnumerable<ProcessSession> ait_groupactivity_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_groupactivity_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_groupactivity_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_groupactivity_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_groupactivity_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_groupactivity_SyncErrors")]
    public IEnumerable<SyncError> ait_groupactivity_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_groupactivity_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_groupactivity_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_groupactivity_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_groupactivity_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_groupactivity_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_groupactivity_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_groupactivity_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_groupactivity_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_groupactivity_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_groupactivity_UserEntityInstanceDatas));
      }
    }

    [RelationshipSchemaName("ait_ait_groupactivity_contact")]
    public IEnumerable<Contact> ait_ait_groupactivity_contact
    {
      get
      {
        return this.GetRelatedEntities<Contact>(nameof (ait_ait_groupactivity_contact), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_groupactivity_contact));
        this.SetRelatedEntities<Contact>(nameof (ait_ait_groupactivity_contact), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_groupactivity_contact));
      }
    }

    [AttributeLogicalName("ait_program")]
    [RelationshipSchemaName("ait_program_ait_groupactivity_Program")]
    public ait_program ait_program_ait_groupactivity_Program
    {
      get
      {
        return this.GetRelatedEntity<ait_program>(nameof (ait_program_ait_groupactivity_Program), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_program_ait_groupactivity_Program));
        this.SetRelatedEntity<ait_program>(nameof (ait_program_ait_groupactivity_Program), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_program_ait_groupactivity_Program));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_groupactivity")]
    public BusinessUnit business_unit_ait_groupactivity
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_groupactivity), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_groupactivity_createdby")]
    public SystemUser lk_ait_groupactivity_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_groupactivity_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_groupactivity_createdonbehalfby")]
    public SystemUser lk_ait_groupactivity_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_groupactivity_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_groupactivity_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_groupactivity_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_groupactivity_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_groupactivity_modifiedby")]
    public SystemUser lk_ait_groupactivity_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_groupactivity_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_groupactivity_modifiedonbehalfby")]
    public SystemUser lk_ait_groupactivity_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_groupactivity_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_groupactivity_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_groupactivity_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_groupactivity_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_groupactivity")]
    public Team team_ait_groupactivity
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_groupactivity), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_groupactivity")]
    public SystemUser user_ait_groupactivity
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_ait_groupactivity), new EntityRole?());
    }

    public ait_groupactivity(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_groupactivityid"] = (object) base.Id;
            break;
          case "ait_groupactivityid":
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
