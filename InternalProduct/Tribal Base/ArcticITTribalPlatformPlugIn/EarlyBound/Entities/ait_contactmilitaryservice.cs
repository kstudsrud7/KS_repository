// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_contactmilitaryservice
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_contactmilitaryservice")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_contactmilitaryservice : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_contactmilitaryservice";
    public const string EntitySchemaName = "ait_contactmilitaryservice";
    public const string PrimaryIdAttribute = "ait_contactmilitaryserviceid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_contactmilitaryservice()
      : base(nameof (ait_contactmilitaryservice))
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

    [AttributeLogicalName("ait_armedservicestatus")]
    public OptionSetValue ait_armedservicestatus
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_armedservicestatus));
      set
      {
        this.OnPropertyChanging(nameof (ait_armedservicestatus));
        this.SetAttributeValue(nameof (ait_armedservicestatus), (object) value);
        this.OnPropertyChanged(nameof (ait_armedservicestatus));
      }
    }

    [AttributeLogicalName("ait_armedservicestype")]
    public OptionSetValue ait_armedservicestype
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_armedservicestype));
      set
      {
        this.OnPropertyChanging(nameof (ait_armedservicestype));
        this.SetAttributeValue(nameof (ait_armedservicestype), (object) value);
        this.OnPropertyChanged(nameof (ait_armedservicestype));
      }
    }

    [AttributeLogicalName("ait_branchofservice")]
    public OptionSetValue ait_branchofservice
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_branchofservice));
      set
      {
        this.OnPropertyChanging(nameof (ait_branchofservice));
        this.SetAttributeValue(nameof (ait_branchofservice), (object) value);
        this.OnPropertyChanged(nameof (ait_branchofservice));
      }
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

    [AttributeLogicalName("ait_contactmilitaryserviceid")]
    public Guid? ait_contactmilitaryserviceId
    {
      get => this.GetAttributeValue<Guid?>("ait_contactmilitaryserviceid");
      set
      {
        this.OnPropertyChanging(nameof (ait_contactmilitaryserviceId));
        this.SetAttributeValue("ait_contactmilitaryserviceid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_contactmilitaryserviceId));
      }
    }

    [AttributeLogicalName("ait_contactmilitaryserviceid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_contactmilitaryserviceId = new Guid?(value);
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

    [AttributeLogicalName("ait_dutystations")]
    public string ait_dutystations
    {
      get => this.GetAttributeValue<string>(nameof (ait_dutystations));
      set
      {
        this.OnPropertyChanging(nameof (ait_dutystations));
        this.SetAttributeValue(nameof (ait_dutystations), (object) value);
        this.OnPropertyChanged(nameof (ait_dutystations));
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

    [AttributeLogicalName("ait_hurtorinjured")]
    public OptionSetValue ait_hurtorinjured
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_hurtorinjured));
      set
      {
        this.OnPropertyChanging(nameof (ait_hurtorinjured));
        this.SetAttributeValue(nameof (ait_hurtorinjured), (object) value);
        this.OnPropertyChanged(nameof (ait_hurtorinjured));
      }
    }

    [AttributeLogicalName("ait_hurtorinjureddescription")]
    public string ait_hurtorinjureddescription
    {
      get => this.GetAttributeValue<string>(nameof (ait_hurtorinjureddescription));
      set
      {
        this.OnPropertyChanging(nameof (ait_hurtorinjureddescription));
        this.SetAttributeValue(nameof (ait_hurtorinjureddescription), (object) value);
        this.OnPropertyChanged(nameof (ait_hurtorinjureddescription));
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

    [AttributeLogicalName("ait_rank")]
    public string ait_rank
    {
      get => this.GetAttributeValue<string>(nameof (ait_rank));
      set
      {
        this.OnPropertyChanging(nameof (ait_rank));
        this.SetAttributeValue(nameof (ait_rank), (object) value);
        this.OnPropertyChanged(nameof (ait_rank));
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
    public ait_contactmilitaryserviceState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_contactmilitaryserviceState?((ait_contactmilitaryserviceState) Enum.ToObject(typeof (ait_contactmilitaryserviceState), attributeValue.Value)) : new ait_contactmilitaryserviceState?();
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

    [RelationshipSchemaName("ait_contactmilitaryservice_Annotations")]
    public IEnumerable<Annotation> ait_contactmilitaryservice_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (ait_contactmilitaryservice_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactmilitaryservice_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (ait_contactmilitaryservice_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactmilitaryservice_Annotations));
      }
    }

    [RelationshipSchemaName("ait_contactmilitaryservice_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_contactmilitaryservice_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_contactmilitaryservice_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactmilitaryservice_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_contactmilitaryservice_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactmilitaryservice_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_contactmilitaryservice_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_contactmilitaryservice_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_contactmilitaryservice_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactmilitaryservice_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_contactmilitaryservice_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactmilitaryservice_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_contactmilitaryservice_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_contactmilitaryservice_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_contactmilitaryservice_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactmilitaryservice_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_contactmilitaryservice_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactmilitaryservice_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_contactmilitaryservice_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_contactmilitaryservice_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_contactmilitaryservice_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactmilitaryservice_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_contactmilitaryservice_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactmilitaryservice_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_contactmilitaryservice_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_contactmilitaryservice_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_contactmilitaryservice_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactmilitaryservice_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_contactmilitaryservice_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactmilitaryservice_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_contactmilitaryservice_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_contactmilitaryservice_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_contactmilitaryservice_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactmilitaryservice_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_contactmilitaryservice_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactmilitaryservice_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_contactmilitaryservice_ProcessSession")]
    public IEnumerable<ProcessSession> ait_contactmilitaryservice_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_contactmilitaryservice_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactmilitaryservice_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_contactmilitaryservice_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactmilitaryservice_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_contactmilitaryservice_SyncErrors")]
    public IEnumerable<SyncError> ait_contactmilitaryservice_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_contactmilitaryservice_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactmilitaryservice_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_contactmilitaryservice_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactmilitaryservice_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_contactmilitaryservice_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_contactmilitaryservice_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_contactmilitaryservice_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactmilitaryservice_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_contactmilitaryservice_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactmilitaryservice_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_contact")]
    [RelationshipSchemaName("ait_ait_contactmilitaryservice_contact")]
    public Contact ait_ait_contactmilitaryservice_contact
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (ait_ait_contactmilitaryservice_contact), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_contactmilitaryservice_contact));
        this.SetRelatedEntity<Contact>(nameof (ait_ait_contactmilitaryservice_contact), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_contactmilitaryservice_contact));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_contactmilitaryservice")]
    public BusinessUnit business_unit_ait_contactmilitaryservice
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_contactmilitaryservice), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_contactmilitaryservice_createdby")]
    public SystemUser lk_ait_contactmilitaryservice_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_contactmilitaryservice_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_contactmilitaryservice_createdonbehalfby")]
    public SystemUser lk_ait_contactmilitaryservice_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_contactmilitaryservice_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_contactmilitaryservice_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_contactmilitaryservice_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_contactmilitaryservice_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_contactmilitaryservice_modifiedby")]
    public SystemUser lk_ait_contactmilitaryservice_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_contactmilitaryservice_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_contactmilitaryservice_modifiedonbehalfby")]
    public SystemUser lk_ait_contactmilitaryservice_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_contactmilitaryservice_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_contactmilitaryservice_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_contactmilitaryservice_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_contactmilitaryservice_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_contactmilitaryservice")]
    public Team team_ait_contactmilitaryservice
    {
      get
      {
        return this.GetRelatedEntity<Team>(nameof (team_ait_contactmilitaryservice), new EntityRole?());
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_contactmilitaryservice")]
    public SystemUser user_ait_contactmilitaryservice
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_ait_contactmilitaryservice), new EntityRole?());
      }
    }

    public ait_contactmilitaryservice(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_contactmilitaryserviceid"] = (object) base.Id;
            break;
          case "ait_contactmilitaryserviceid":
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
