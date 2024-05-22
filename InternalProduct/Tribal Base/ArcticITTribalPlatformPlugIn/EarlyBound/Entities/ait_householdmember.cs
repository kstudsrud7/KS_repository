// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_householdmember
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_householdmember")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_householdmember : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_householdmember";
    public const string EntitySchemaName = "ait_householdmember";
    public const string PrimaryIdAttribute = "ait_householdmemberid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_householdmember()
      : base(nameof (ait_householdmember))
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

    [AttributeLogicalName("ait_dependent")]
    public bool? ait_dependent
    {
      get => this.GetAttributeValue<bool?>(nameof (ait_dependent));
      set
      {
        this.OnPropertyChanging(nameof (ait_dependent));
        this.SetAttributeValue(nameof (ait_dependent), (object) value);
        this.OnPropertyChanged(nameof (ait_dependent));
      }
    }

    [AttributeLogicalName("ait_household")]
    public EntityReference ait_household
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_household));
      set
      {
        this.OnPropertyChanging(nameof (ait_household));
        this.SetAttributeValue(nameof (ait_household), (object) value);
        this.OnPropertyChanged(nameof (ait_household));
      }
    }

    [AttributeLogicalName("ait_householdmemberid")]
    public Guid? ait_householdmemberId
    {
      get => this.GetAttributeValue<Guid?>("ait_householdmemberid");
      set
      {
        this.OnPropertyChanging(nameof (ait_householdmemberId));
        this.SetAttributeValue("ait_householdmemberid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_householdmemberId));
      }
    }

    [AttributeLogicalName("ait_householdmemberid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_householdmemberId = new Guid?(value);
    }

    [AttributeLogicalName("ait_includeincomeandexpensesinhousehold")]
    public bool? ait_includeincomeandexpensesinhousehold
    {
      get => this.GetAttributeValue<bool?>(nameof (ait_includeincomeandexpensesinhousehold));
      set
      {
        this.OnPropertyChanging(nameof (ait_includeincomeandexpensesinhousehold));
        this.SetAttributeValue(nameof (ait_includeincomeandexpensesinhousehold), (object) value);
        this.OnPropertyChanged(nameof (ait_includeincomeandexpensesinhousehold));
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

    [AttributeLogicalName("ait_relationshiptype")]
    public OptionSetValue ait_relationshiptype
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_relationshiptype));
      set
      {
        this.OnPropertyChanging(nameof (ait_relationshiptype));
        this.SetAttributeValue(nameof (ait_relationshiptype), (object) value);
        this.OnPropertyChanged(nameof (ait_relationshiptype));
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
    public ait_householdmemberState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_householdmemberState?((ait_householdmemberState) Enum.ToObject(typeof (ait_householdmemberState), attributeValue.Value)) : new ait_householdmemberState?();
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

    [RelationshipSchemaName("ait_ait_householdmember_ait_changerequest_HouseholdMember")]
    public IEnumerable<ait_changerequest> ait_ait_householdmember_ait_changerequest_HouseholdMember
    {
      get
      {
        return this.GetRelatedEntities<ait_changerequest>(nameof (ait_ait_householdmember_ait_changerequest_HouseholdMember), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_householdmember_ait_changerequest_HouseholdMember));
        this.SetRelatedEntities<ait_changerequest>(nameof (ait_ait_householdmember_ait_changerequest_HouseholdMember), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_householdmember_ait_changerequest_HouseholdMember));
      }
    }

    [RelationshipSchemaName("ait_ait_householdmember_contact_householdmember")]
    public IEnumerable<Contact> ait_ait_householdmember_contact_householdmember
    {
      get
      {
        return this.GetRelatedEntities<Contact>(nameof (ait_ait_householdmember_contact_householdmember), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_householdmember_contact_householdmember));
        this.SetRelatedEntities<Contact>(nameof (ait_ait_householdmember_contact_householdmember), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_householdmember_contact_householdmember));
      }
    }

    [RelationshipSchemaName("ait_householdmember_Annotations")]
    public IEnumerable<Annotation> ait_householdmember_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (ait_householdmember_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_householdmember_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (ait_householdmember_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_householdmember_Annotations));
      }
    }

    [RelationshipSchemaName("ait_householdmember_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_householdmember_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_householdmember_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_householdmember_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_householdmember_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_householdmember_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_householdmember_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_householdmember_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_householdmember_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_householdmember_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_householdmember_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_householdmember_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_householdmember_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_householdmember_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_householdmember_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_householdmember_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_householdmember_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_householdmember_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_householdmember_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_householdmember_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_householdmember_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_householdmember_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_householdmember_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_householdmember_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_householdmember_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_householdmember_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_householdmember_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_householdmember_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_householdmember_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_householdmember_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_householdmember_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_householdmember_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_householdmember_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_householdmember_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_householdmember_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_householdmember_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_householdmember_ProcessSession")]
    public IEnumerable<ProcessSession> ait_householdmember_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_householdmember_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_householdmember_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_householdmember_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_householdmember_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_householdmember_SyncErrors")]
    public IEnumerable<SyncError> ait_householdmember_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_householdmember_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_householdmember_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_householdmember_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_householdmember_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_householdmember_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_householdmember_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_householdmember_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_householdmember_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_householdmember_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_householdmember_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_household")]
    [RelationshipSchemaName("ait_ait_householdmember_ait_household")]
    public ArcticIT.EarlyBound.Entities.ait_household ait_ait_householdmember_ait_household
    {
      get
      {
        return this.GetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_household>(nameof (ait_ait_householdmember_ait_household), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_householdmember_ait_household));
        this.SetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_household>(nameof (ait_ait_householdmember_ait_household), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_householdmember_ait_household));
      }
    }

    [AttributeLogicalName("ait_contact")]
    [RelationshipSchemaName("ait_ait_householdmember_contact")]
    public Contact ait_ait_householdmember_contact
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (ait_ait_householdmember_contact), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_householdmember_contact));
        this.SetRelatedEntity<Contact>(nameof (ait_ait_householdmember_contact), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_householdmember_contact));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_householdmember")]
    public BusinessUnit business_unit_ait_householdmember
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_householdmember), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_householdmember_createdby")]
    public SystemUser lk_ait_householdmember_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_householdmember_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_householdmember_createdonbehalfby")]
    public SystemUser lk_ait_householdmember_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_householdmember_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_householdmember_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_householdmember_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_householdmember_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_householdmember_modifiedby")]
    public SystemUser lk_ait_householdmember_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_householdmember_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_householdmember_modifiedonbehalfby")]
    public SystemUser lk_ait_householdmember_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_householdmember_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_householdmember_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_householdmember_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_householdmember_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_householdmember")]
    public Team team_ait_householdmember
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_householdmember), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_householdmember")]
    public SystemUser user_ait_householdmember
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_ait_householdmember), new EntityRole?());
      }
    }

    public ait_householdmember(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_householdmemberid"] = (object) base.Id;
            break;
          case "ait_householdmemberid":
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
