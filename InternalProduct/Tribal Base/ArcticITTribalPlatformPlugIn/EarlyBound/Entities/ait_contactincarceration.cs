// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_contactincarceration
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_contactincarceration")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_contactincarceration : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_contactincarceration";
    public const string EntitySchemaName = "ait_contactincarceration";
    public const string PrimaryIdAttribute = "ait_contactincarcerationid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_contactincarceration()
      : base(nameof (ait_contactincarceration))
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

    [AttributeLogicalName("ait_contactincarcerationid")]
    public Guid? ait_contactincarcerationId
    {
      get => this.GetAttributeValue<Guid?>("ait_contactincarcerationid");
      set
      {
        this.OnPropertyChanging(nameof (ait_contactincarcerationId));
        this.SetAttributeValue("ait_contactincarcerationid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_contactincarcerationId));
      }
    }

    [AttributeLogicalName("ait_contactincarcerationid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_contactincarcerationId = new Guid?(value);
    }

    [AttributeLogicalName("ait_currentlyincarcerated")]
    public bool? ait_currentlyincarcerated
    {
      get => this.GetAttributeValue<bool?>(nameof (ait_currentlyincarcerated));
      set
      {
        this.OnPropertyChanging(nameof (ait_currentlyincarcerated));
        this.SetAttributeValue(nameof (ait_currentlyincarcerated), (object) value);
        this.OnPropertyChanged(nameof (ait_currentlyincarcerated));
      }
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

    [AttributeLogicalName("ait_prison")]
    public EntityReference ait_prison
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_prison));
      set
      {
        this.OnPropertyChanging(nameof (ait_prison));
        this.SetAttributeValue(nameof (ait_prison), (object) value);
        this.OnPropertyChanged(nameof (ait_prison));
      }
    }

    [AttributeLogicalName("ait_prisonernumber")]
    public string ait_prisonernumber
    {
      get => this.GetAttributeValue<string>(nameof (ait_prisonernumber));
      set
      {
        this.OnPropertyChanging(nameof (ait_prisonernumber));
        this.SetAttributeValue(nameof (ait_prisonernumber), (object) value);
        this.OnPropertyChanged(nameof (ait_prisonernumber));
      }
    }

    [AttributeLogicalName("ait_prisontype")]
    public OptionSetValue ait_prisontype
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_prisontype));
      set
      {
        this.OnPropertyChanging(nameof (ait_prisontype));
        this.SetAttributeValue(nameof (ait_prisontype), (object) value);
        this.OnPropertyChanged(nameof (ait_prisontype));
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
    public ait_contactincarcerationState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_contactincarcerationState?((ait_contactincarcerationState) Enum.ToObject(typeof (ait_contactincarcerationState), attributeValue.Value)) : new ait_contactincarcerationState?();
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

    [RelationshipSchemaName("ait_contactincarceration_Annotations")]
    public IEnumerable<Annotation> ait_contactincarceration_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (ait_contactincarceration_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactincarceration_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (ait_contactincarceration_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactincarceration_Annotations));
      }
    }

    [RelationshipSchemaName("ait_contactincarceration_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_contactincarceration_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_contactincarceration_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactincarceration_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_contactincarceration_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactincarceration_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_contactincarceration_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_contactincarceration_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_contactincarceration_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactincarceration_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_contactincarceration_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactincarceration_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_contactincarceration_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_contactincarceration_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_contactincarceration_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactincarceration_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_contactincarceration_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactincarceration_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_contactincarceration_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_contactincarceration_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_contactincarceration_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactincarceration_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_contactincarceration_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactincarceration_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_contactincarceration_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_contactincarceration_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_contactincarceration_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactincarceration_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_contactincarceration_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactincarceration_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_contactincarceration_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_contactincarceration_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_contactincarceration_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactincarceration_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_contactincarceration_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactincarceration_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_contactincarceration_ProcessSession")]
    public IEnumerable<ProcessSession> ait_contactincarceration_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_contactincarceration_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactincarceration_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_contactincarceration_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactincarceration_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_contactincarceration_SyncErrors")]
    public IEnumerable<SyncError> ait_contactincarceration_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_contactincarceration_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactincarceration_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_contactincarceration_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactincarceration_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_contactincarceration_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_contactincarceration_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_contactincarceration_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactincarceration_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_contactincarceration_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactincarceration_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_prison")]
    [RelationshipSchemaName("ait_ait_contactincarceration_ait_company")]
    public ait_company ait_ait_contactincarceration_ait_company
    {
      get
      {
        return this.GetRelatedEntity<ait_company>(nameof (ait_ait_contactincarceration_ait_company), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_contactincarceration_ait_company));
        this.SetRelatedEntity<ait_company>(nameof (ait_ait_contactincarceration_ait_company), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_contactincarceration_ait_company));
      }
    }

    [AttributeLogicalName("ait_contact")]
    [RelationshipSchemaName("ait_ait_contactincarceration_contact")]
    public Contact ait_ait_contactincarceration_contact
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (ait_ait_contactincarceration_contact), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_contactincarceration_contact));
        this.SetRelatedEntity<Contact>(nameof (ait_ait_contactincarceration_contact), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_contactincarceration_contact));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_contactincarceration")]
    public BusinessUnit business_unit_ait_contactincarceration
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_contactincarceration), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_contactincarceration_createdby")]
    public SystemUser lk_ait_contactincarceration_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_contactincarceration_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_contactincarceration_createdonbehalfby")]
    public SystemUser lk_ait_contactincarceration_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_contactincarceration_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_contactincarceration_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_contactincarceration_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_contactincarceration_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_contactincarceration_modifiedby")]
    public SystemUser lk_ait_contactincarceration_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_contactincarceration_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_contactincarceration_modifiedonbehalfby")]
    public SystemUser lk_ait_contactincarceration_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_contactincarceration_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_contactincarceration_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_contactincarceration_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_contactincarceration_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_contactincarceration")]
    public Team team_ait_contactincarceration
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_contactincarceration), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_contactincarceration")]
    public SystemUser user_ait_contactincarceration
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_ait_contactincarceration), new EntityRole?());
      }
    }

    public ait_contactincarceration(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_contactincarcerationid"] = (object) base.Id;
            break;
          case "ait_contactincarcerationid":
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
