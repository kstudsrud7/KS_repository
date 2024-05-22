// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_groupactivitymeeting
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_groupactivitymeeting")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_groupactivitymeeting : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_groupactivitymeeting";
    public const string EntitySchemaName = "ait_groupactivitymeeting";
    public const string PrimaryIdAttribute = "ait_groupactivitymeetingid";
    public const string PrimaryNameAttribute = "ait_activitymeetingname";

    public ait_groupactivitymeeting()
      : base(nameof (ait_groupactivitymeeting))
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

    [AttributeLogicalName("ait_activitymeetingname")]
    public string ait_activitymeetingname
    {
      get => this.GetAttributeValue<string>(nameof (ait_activitymeetingname));
      set
      {
        this.OnPropertyChanging(nameof (ait_activitymeetingname));
        this.SetAttributeValue(nameof (ait_activitymeetingname), (object) value);
        this.OnPropertyChanged(nameof (ait_activitymeetingname));
      }
    }

    [AttributeLogicalName("ait_attendeecount")]
    public int? ait_AttendeeCount
    {
      get => this.GetAttributeValue<int?>("ait_attendeecount");
      set
      {
        this.OnPropertyChanging(nameof (ait_AttendeeCount));
        this.SetAttributeValue("ait_attendeecount", (object) value);
        this.OnPropertyChanged(nameof (ait_AttendeeCount));
      }
    }

    [AttributeLogicalName("ait_groupactivity")]
    public EntityReference ait_GroupActivity
    {
      get => this.GetAttributeValue<EntityReference>("ait_groupactivity");
      set
      {
        this.OnPropertyChanging(nameof (ait_GroupActivity));
        this.SetAttributeValue("ait_groupactivity", (object) value);
        this.OnPropertyChanged(nameof (ait_GroupActivity));
      }
    }

    [AttributeLogicalName("ait_groupactivitymeetingid")]
    public Guid? ait_groupactivitymeetingId
    {
      get => this.GetAttributeValue<Guid?>("ait_groupactivitymeetingid");
      set
      {
        this.OnPropertyChanging(nameof (ait_groupactivitymeetingId));
        this.SetAttributeValue("ait_groupactivitymeetingid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_groupactivitymeetingId));
      }
    }

    [AttributeLogicalName("ait_groupactivitymeetingid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_groupactivitymeetingId = new Guid?(value);
    }

    [AttributeLogicalName("ait_groupactivitymeetingidauto")]
    public string ait_GroupActivityMeetingIDauto
    {
      get => this.GetAttributeValue<string>("ait_groupactivitymeetingidauto");
      set
      {
        this.OnPropertyChanging(nameof (ait_GroupActivityMeetingIDauto));
        this.SetAttributeValue("ait_groupactivitymeetingidauto", (object) value);
        this.OnPropertyChanged(nameof (ait_GroupActivityMeetingIDauto));
      }
    }

    [AttributeLogicalName("ait_meetingdatetime")]
    public DateTime? ait_MeetingDateTime
    {
      get => this.GetAttributeValue<DateTime?>("ait_meetingdatetime");
      set
      {
        this.OnPropertyChanging(nameof (ait_MeetingDateTime));
        this.SetAttributeValue("ait_meetingdatetime", (object) value);
        this.OnPropertyChanged(nameof (ait_MeetingDateTime));
      }
    }

    [AttributeLogicalName("ait_meetingleader")]
    public EntityReference ait_MeetingLeader
    {
      get => this.GetAttributeValue<EntityReference>("ait_meetingleader");
      set
      {
        this.OnPropertyChanging(nameof (ait_MeetingLeader));
        this.SetAttributeValue("ait_meetingleader", (object) value);
        this.OnPropertyChanged(nameof (ait_MeetingLeader));
      }
    }

    [AttributeLogicalName("ait_meetingsummary")]
    public string ait_MeetingSummary
    {
      get => this.GetAttributeValue<string>("ait_meetingsummary");
      set
      {
        this.OnPropertyChanging(nameof (ait_MeetingSummary));
        this.SetAttributeValue("ait_meetingsummary", (object) value);
        this.OnPropertyChanged(nameof (ait_MeetingSummary));
      }
    }

    [AttributeLogicalName("ait_registeredcount")]
    public int? ait_RegisteredCount
    {
      get => this.GetAttributeValue<int?>("ait_registeredcount");
      set
      {
        this.OnPropertyChanging(nameof (ait_RegisteredCount));
        this.SetAttributeValue("ait_registeredcount", (object) value);
        this.OnPropertyChanged(nameof (ait_RegisteredCount));
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
    public ait_groupactivitymeetingState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_groupactivitymeetingState?((ait_groupactivitymeetingState) Enum.ToObject(typeof (ait_groupactivitymeetingState), attributeValue.Value)) : new ait_groupactivitymeetingState?();
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

    [RelationshipSchemaName("ait_groupactivitymeeting_ActivityParties")]
    public IEnumerable<ActivityParty> ait_groupactivitymeeting_ActivityParties
    {
      get
      {
        return this.GetRelatedEntities<ActivityParty>(nameof (ait_groupactivitymeeting_ActivityParties), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_groupactivitymeeting_ActivityParties));
        this.SetRelatedEntities<ActivityParty>(nameof (ait_groupactivitymeeting_ActivityParties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_groupactivitymeeting_ActivityParties));
      }
    }

    [RelationshipSchemaName("ait_groupactivitymeeting_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_groupactivitymeeting_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_groupactivitymeeting_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_groupactivitymeeting_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_groupactivitymeeting_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_groupactivitymeeting_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_groupactivitymeeting_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_groupactivitymeeting_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_groupactivitymeeting_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_groupactivitymeeting_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_groupactivitymeeting_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_groupactivitymeeting_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_groupactivitymeeting_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_groupactivitymeeting_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_groupactivitymeeting_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_groupactivitymeeting_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_groupactivitymeeting_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_groupactivitymeeting_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_groupactivitymeeting_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_groupactivitymeeting_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_groupactivitymeeting_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_groupactivitymeeting_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_groupactivitymeeting_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_groupactivitymeeting_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_groupactivitymeeting_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_groupactivitymeeting_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_groupactivitymeeting_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_groupactivitymeeting_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_groupactivitymeeting_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_groupactivitymeeting_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_groupactivitymeeting_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_groupactivitymeeting_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_groupactivitymeeting_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_groupactivitymeeting_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_groupactivitymeeting_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_groupactivitymeeting_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_groupactivitymeeting_ProcessSession")]
    public IEnumerable<ProcessSession> ait_groupactivitymeeting_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_groupactivitymeeting_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_groupactivitymeeting_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_groupactivitymeeting_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_groupactivitymeeting_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_groupactivitymeeting_SyncErrors")]
    public IEnumerable<SyncError> ait_groupactivitymeeting_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_groupactivitymeeting_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_groupactivitymeeting_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_groupactivitymeeting_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_groupactivitymeeting_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_groupactivitymeeting_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_groupactivitymeeting_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_groupactivitymeeting_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_groupactivitymeeting_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_groupactivitymeeting_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_groupactivitymeeting_UserEntityInstanceDatas));
      }
    }

    [RelationshipSchemaName("ait_ait_groupactivitymeeting_contact")]
    public IEnumerable<Contact> ait_ait_groupactivitymeeting_contact
    {
      get
      {
        return this.GetRelatedEntities<Contact>(nameof (ait_ait_groupactivitymeeting_contact), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_groupactivitymeeting_contact));
        this.SetRelatedEntities<Contact>(nameof (ait_ait_groupactivitymeeting_contact), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_groupactivitymeeting_contact));
      }
    }

    [AttributeLogicalName("ait_groupactivity")]
    [RelationshipSchemaName("ait_ait_groupactivity_ait_groupactivitymeeting_GroupActivity")]
    public ait_groupactivity ait_ait_groupactivity_ait_groupactivitymeeting_GroupActivity
    {
      get
      {
        return this.GetRelatedEntity<ait_groupactivity>(nameof (ait_ait_groupactivity_ait_groupactivitymeeting_GroupActivity), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_groupactivity_ait_groupactivitymeeting_GroupActivity));
        this.SetRelatedEntity<ait_groupactivity>(nameof (ait_ait_groupactivity_ait_groupactivitymeeting_GroupActivity), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_groupactivity_ait_groupactivitymeeting_GroupActivity));
      }
    }

    [AttributeLogicalName("ait_meetingleader")]
    [RelationshipSchemaName("ait_systemuser_ait_groupactivitymeeting_MeetingLeader")]
    public SystemUser ait_systemuser_ait_groupactivitymeeting_MeetingLeader
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (ait_systemuser_ait_groupactivitymeeting_MeetingLeader), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_systemuser_ait_groupactivitymeeting_MeetingLeader));
        this.SetRelatedEntity<SystemUser>(nameof (ait_systemuser_ait_groupactivitymeeting_MeetingLeader), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_systemuser_ait_groupactivitymeeting_MeetingLeader));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_groupactivitymeeting")]
    public BusinessUnit business_unit_ait_groupactivitymeeting
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_groupactivitymeeting), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_groupactivitymeeting_createdby")]
    public SystemUser lk_ait_groupactivitymeeting_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_groupactivitymeeting_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_groupactivitymeeting_createdonbehalfby")]
    public SystemUser lk_ait_groupactivitymeeting_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_groupactivitymeeting_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_groupactivitymeeting_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_groupactivitymeeting_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_groupactivitymeeting_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_groupactivitymeeting_modifiedby")]
    public SystemUser lk_ait_groupactivitymeeting_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_groupactivitymeeting_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_groupactivitymeeting_modifiedonbehalfby")]
    public SystemUser lk_ait_groupactivitymeeting_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_groupactivitymeeting_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_groupactivitymeeting_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_groupactivitymeeting_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_groupactivitymeeting_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_groupactivitymeeting")]
    public Team team_ait_groupactivitymeeting
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_groupactivitymeeting), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_groupactivitymeeting")]
    public SystemUser user_ait_groupactivitymeeting
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_ait_groupactivitymeeting), new EntityRole?());
      }
    }

    public ait_groupactivitymeeting(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_groupactivitymeetingid"] = (object) base.Id;
            break;
          case "ait_groupactivitymeetingid":
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
