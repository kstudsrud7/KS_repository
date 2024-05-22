// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_committeemember
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_committeemember")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_committeemember : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_committeemember";
    public const string EntitySchemaName = "ait_committeemember";
    public const string PrimaryIdAttribute = "ait_committeememberid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_committeemember()
      : base(nameof (ait_committeemember))
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

    [AttributeLogicalName("ait_committee")]
    public EntityReference ait_committee
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_committee));
      set
      {
        this.OnPropertyChanging(nameof (ait_committee));
        this.SetAttributeValue(nameof (ait_committee), (object) value);
        this.OnPropertyChanged(nameof (ait_committee));
      }
    }

    [AttributeLogicalName("ait_committeememberid")]
    public Guid? ait_committeememberId
    {
      get => this.GetAttributeValue<Guid?>("ait_committeememberid");
      set
      {
        this.OnPropertyChanging(nameof (ait_committeememberId));
        this.SetAttributeValue("ait_committeememberid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_committeememberId));
      }
    }

    [AttributeLogicalName("ait_committeememberid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_committeememberId = new Guid?(value);
    }

    [AttributeLogicalName("ait_contact")]
    public EntityReference ait_contact
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_contact));
      set
      {
        this.OnPropertyChanging(nameof (ait_contact));
        this.SetAttributeValue(nameof (ait_contact), (object) value);
        this.OnPropertyChanged(nameof (ait_contact));
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
    public ait_committeememberState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_committeememberState?((ait_committeememberState) Enum.ToObject(typeof (ait_committeememberState), attributeValue.Value)) : new ait_committeememberState?();
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

    [RelationshipSchemaName("ait_ait_committeeposition_ait_committeemember")]
    public IEnumerable<ait_committeeposition> ait_ait_committeeposition_ait_committeemember
    {
      get
      {
        return this.GetRelatedEntities<ait_committeeposition>(nameof (ait_ait_committeeposition_ait_committeemember), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_committeeposition_ait_committeemember));
        this.SetRelatedEntities<ait_committeeposition>(nameof (ait_ait_committeeposition_ait_committeemember), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_committeeposition_ait_committeemember));
      }
    }

    [RelationshipSchemaName("ait_committeemember_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_committeemember_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_committeemember_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_committeemember_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_committeemember_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_committeemember_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_committeemember_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_committeemember_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_committeemember_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_committeemember_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_committeemember_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_committeemember_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_committeemember_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_committeemember_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_committeemember_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_committeemember_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_committeemember_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_committeemember_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_committeemember_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_committeemember_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_committeemember_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_committeemember_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_committeemember_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_committeemember_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_committeemember_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_committeemember_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_committeemember_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_committeemember_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_committeemember_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_committeemember_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_committeemember_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_committeemember_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_committeemember_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_committeemember_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_committeemember_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_committeemember_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_committeemember_ProcessSession")]
    public IEnumerable<ProcessSession> ait_committeemember_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_committeemember_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_committeemember_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_committeemember_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_committeemember_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_committeemember_SyncErrors")]
    public IEnumerable<SyncError> ait_committeemember_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_committeemember_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_committeemember_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_committeemember_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_committeemember_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_committeemember_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_committeemember_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_committeemember_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_committeemember_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_committeemember_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_committeemember_UserEntityInstanceDatas));
      }
    }

    [RelationshipSchemaName("ait_ait_committeemeeting_ait_committeemember")]
    public IEnumerable<ait_committeemeeting> ait_ait_committeemeeting_ait_committeemember
    {
      get
      {
        return this.GetRelatedEntities<ait_committeemeeting>(nameof (ait_ait_committeemeeting_ait_committeemember), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_committeemeeting_ait_committeemember));
        this.SetRelatedEntities<ait_committeemeeting>(nameof (ait_ait_committeemeeting_ait_committeemember), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_committeemeeting_ait_committeemember));
      }
    }

    [AttributeLogicalName("ait_committee")]
    [RelationshipSchemaName("ait_ait_committeemember_ait_committee")]
    public ArcticIT.EarlyBound.Entities.ait_committee ait_ait_committeemember_ait_committee
    {
      get
      {
        return this.GetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_committee>(nameof (ait_ait_committeemember_ait_committee), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_committeemember_ait_committee));
        this.SetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_committee>(nameof (ait_ait_committeemember_ait_committee), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_committeemember_ait_committee));
      }
    }

    [AttributeLogicalName("ait_contact")]
    [RelationshipSchemaName("ait_ait_committeemember_contact")]
    public Contact ait_ait_committeemember_contact
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (ait_ait_committeemember_contact), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_committeemember_contact));
        this.SetRelatedEntity<Contact>(nameof (ait_ait_committeemember_contact), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_committeemember_contact));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_committeemember_createdby")]
    public SystemUser lk_ait_committeemember_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_committeemember_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_committeemember_createdonbehalfby")]
    public SystemUser lk_ait_committeemember_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_committeemember_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_committeemember_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_committeemember_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_committeemember_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_committeemember_modifiedby")]
    public SystemUser lk_ait_committeemember_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_committeemember_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_committeemember_modifiedonbehalfby")]
    public SystemUser lk_ait_committeemember_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_committeemember_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_committeemember_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_committeemember_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_committeemember_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_ait_committeemember")]
    public Organization organization_ait_committeemember
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_ait_committeemember), new EntityRole?());
      }
    }

    public ait_committeemember(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_committeememberid"] = (object) base.Id;
            break;
          case "ait_committeememberid":
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
