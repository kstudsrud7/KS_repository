// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_committee
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_committee")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_committee : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_committee";
    public const string EntitySchemaName = "ait_committee";
    public const string PrimaryIdAttribute = "ait_committeeid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_committee()
      : base(nameof (ait_committee))
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

    [AttributeLogicalName("ait_charter")]
    public string ait_charter
    {
      get => this.GetAttributeValue<string>(nameof (ait_charter));
      set
      {
        this.OnPropertyChanging(nameof (ait_charter));
        this.SetAttributeValue(nameof (ait_charter), (object) value);
        this.OnPropertyChanged(nameof (ait_charter));
      }
    }

    [AttributeLogicalName("ait_committeeid")]
    public Guid? ait_committeeId
    {
      get => this.GetAttributeValue<Guid?>("ait_committeeid");
      set
      {
        this.OnPropertyChanging(nameof (ait_committeeId));
        this.SetAttributeValue("ait_committeeid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_committeeId));
      }
    }

    [AttributeLogicalName("ait_committeeid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_committeeId = new Guid?(value);
    }

    [AttributeLogicalName("ait_description")]
    public string ait_description
    {
      get => this.GetAttributeValue<string>(nameof (ait_description));
      set
      {
        this.OnPropertyChanging(nameof (ait_description));
        this.SetAttributeValue(nameof (ait_description), (object) value);
        this.OnPropertyChanged(nameof (ait_description));
      }
    }

    [AttributeLogicalName("ait_enddate")]
    public DateTime? ait_enddate
    {
      get => this.GetAttributeValue<DateTime?>(nameof (ait_enddate));
      set
      {
        this.OnPropertyChanging(nameof (ait_enddate));
        this.SetAttributeValue(nameof (ait_enddate), (object) value);
        this.OnPropertyChanged(nameof (ait_enddate));
      }
    }

    [AttributeLogicalName("ait_meetingdatedescription")]
    public string ait_meetingdatedescription
    {
      get => this.GetAttributeValue<string>(nameof (ait_meetingdatedescription));
      set
      {
        this.OnPropertyChanging(nameof (ait_meetingdatedescription));
        this.SetAttributeValue(nameof (ait_meetingdatedescription), (object) value);
        this.OnPropertyChanged(nameof (ait_meetingdatedescription));
      }
    }

    [AttributeLogicalName("ait_meetinglocation")]
    public string ait_meetinglocation
    {
      get => this.GetAttributeValue<string>(nameof (ait_meetinglocation));
      set
      {
        this.OnPropertyChanging(nameof (ait_meetinglocation));
        this.SetAttributeValue(nameof (ait_meetinglocation), (object) value);
        this.OnPropertyChanged(nameof (ait_meetinglocation));
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

    [AttributeLogicalName("ait_startdate")]
    public DateTime? ait_startdate
    {
      get => this.GetAttributeValue<DateTime?>(nameof (ait_startdate));
      set
      {
        this.OnPropertyChanging(nameof (ait_startdate));
        this.SetAttributeValue(nameof (ait_startdate), (object) value);
        this.OnPropertyChanged(nameof (ait_startdate));
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

    [AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get => this.GetAttributeValue<EntityReference>("organizationid");
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

    [AttributeLogicalName("statecode")]
    public ait_committeeState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_committeeState?((ait_committeeState) Enum.ToObject(typeof (ait_committeeState), attributeValue.Value)) : new ait_committeeState?();
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

    [RelationshipSchemaName("ait_ait_committeemeeting_ait_committee")]
    public IEnumerable<ait_committeemeeting> ait_ait_committeemeeting_ait_committee
    {
      get
      {
        return this.GetRelatedEntities<ait_committeemeeting>(nameof (ait_ait_committeemeeting_ait_committee), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_committeemeeting_ait_committee));
        this.SetRelatedEntities<ait_committeemeeting>(nameof (ait_ait_committeemeeting_ait_committee), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_committeemeeting_ait_committee));
      }
    }

    [RelationshipSchemaName("ait_ait_committeemember_ait_committee")]
    public IEnumerable<ait_committeemember> ait_ait_committeemember_ait_committee
    {
      get
      {
        return this.GetRelatedEntities<ait_committeemember>(nameof (ait_ait_committeemember_ait_committee), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_committeemember_ait_committee));
        this.SetRelatedEntities<ait_committeemember>(nameof (ait_ait_committeemember_ait_committee), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_committeemember_ait_committee));
      }
    }

    [RelationshipSchemaName("ait_ait_committeeposition_ait_committee")]
    public IEnumerable<ait_committeeposition> ait_ait_committeeposition_ait_committee
    {
      get
      {
        return this.GetRelatedEntities<ait_committeeposition>(nameof (ait_ait_committeeposition_ait_committee), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_committeeposition_ait_committee));
        this.SetRelatedEntities<ait_committeeposition>(nameof (ait_ait_committeeposition_ait_committee), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_committeeposition_ait_committee));
      }
    }

    [RelationshipSchemaName("ait_committee_Annotations")]
    public IEnumerable<Annotation> ait_committee_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (ait_committee_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_committee_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (ait_committee_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_committee_Annotations));
      }
    }

    [RelationshipSchemaName("ait_committee_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_committee_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_committee_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_committee_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_committee_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_committee_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_committee_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_committee_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_committee_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_committee_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_committee_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_committee_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_committee_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_committee_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_committee_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_committee_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_committee_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_committee_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_committee_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_committee_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_committee_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_committee_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_committee_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_committee_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_committee_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_committee_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_committee_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_committee_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_committee_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_committee_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_committee_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_committee_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_committee_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_committee_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_committee_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_committee_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_committee_ProcessSession")]
    public IEnumerable<ProcessSession> ait_committee_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_committee_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_committee_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_committee_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_committee_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_committee_SyncErrors")]
    public IEnumerable<SyncError> ait_committee_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_committee_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_committee_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_committee_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_committee_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_committee_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_committee_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_committee_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_committee_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_committee_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_committee_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_committee_createdby")]
    public SystemUser lk_ait_committee_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_committee_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_committee_createdonbehalfby")]
    public SystemUser lk_ait_committee_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_committee_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_committee_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_committee_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_committee_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_committee_modifiedby")]
    public SystemUser lk_ait_committee_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_committee_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_committee_modifiedonbehalfby")]
    public SystemUser lk_ait_committee_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_committee_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_committee_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_committee_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_committee_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_ait_committee")]
    public Organization organization_ait_committee
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_ait_committee), new EntityRole?());
      }
    }

    public ait_committee(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_committeeid"] = (object) base.Id;
            break;
          case "ait_committeeid":
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
