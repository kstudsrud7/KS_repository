// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_contacteducation
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_contacteducation")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_contacteducation : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_contacteducation";
    public const string EntitySchemaName = "ait_contacteducation";
    public const string PrimaryIdAttribute = "ait_contacteducationid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_contacteducation()
      : base(nameof (ait_contacteducation))
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

    [AttributeLogicalName("ait_contacteducationid")]
    public Guid? ait_contacteducationId
    {
      get => this.GetAttributeValue<Guid?>("ait_contacteducationid");
      set
      {
        this.OnPropertyChanging(nameof (ait_contacteducationId));
        this.SetAttributeValue("ait_contacteducationid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_contacteducationId));
      }
    }

    [AttributeLogicalName("ait_contacteducationid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_contacteducationId = new Guid?(value);
    }

    [AttributeLogicalName("ait_degree")]
    public EntityReference ait_degree
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_degree));
      set
      {
        this.OnPropertyChanging(nameof (ait_degree));
        this.SetAttributeValue(nameof (ait_degree), (object) value);
        this.OnPropertyChanged(nameof (ait_degree));
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

    [AttributeLogicalName("ait_fieldofstudy")]
    public string ait_fieldofstudy
    {
      get => this.GetAttributeValue<string>(nameof (ait_fieldofstudy));
      set
      {
        this.OnPropertyChanging(nameof (ait_fieldofstudy));
        this.SetAttributeValue(nameof (ait_fieldofstudy), (object) value);
        this.OnPropertyChanged(nameof (ait_fieldofstudy));
      }
    }

    [AttributeLogicalName("ait_gpa")]
    public Decimal? ait_gpa
    {
      get => this.GetAttributeValue<Decimal?>(nameof (ait_gpa));
      set
      {
        this.OnPropertyChanging(nameof (ait_gpa));
        this.SetAttributeValue(nameof (ait_gpa), (object) value);
        this.OnPropertyChanged(nameof (ait_gpa));
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

    [AttributeLogicalName("ait_school")]
    public EntityReference ait_school
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_school));
      set
      {
        this.OnPropertyChanging(nameof (ait_school));
        this.SetAttributeValue(nameof (ait_school), (object) value);
        this.OnPropertyChanged(nameof (ait_school));
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

    [AttributeLogicalName("ait_type")]
    public EntityReference ait_type
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_type));
      set
      {
        this.OnPropertyChanging(nameof (ait_type));
        this.SetAttributeValue(nameof (ait_type), (object) value);
        this.OnPropertyChanged(nameof (ait_type));
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
    public ait_contacteducationState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_contacteducationState?((ait_contacteducationState) Enum.ToObject(typeof (ait_contacteducationState), attributeValue.Value)) : new ait_contacteducationState?();
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

    [RelationshipSchemaName("ait_contacteducation_Annotations")]
    public IEnumerable<Annotation> ait_contacteducation_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (ait_contacteducation_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contacteducation_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (ait_contacteducation_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contacteducation_Annotations));
      }
    }

    [RelationshipSchemaName("ait_contacteducation_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_contacteducation_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_contacteducation_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contacteducation_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_contacteducation_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contacteducation_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_contacteducation_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_contacteducation_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_contacteducation_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contacteducation_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_contacteducation_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contacteducation_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_contacteducation_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_contacteducation_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_contacteducation_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contacteducation_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_contacteducation_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contacteducation_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_contacteducation_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_contacteducation_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_contacteducation_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contacteducation_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_contacteducation_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contacteducation_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_contacteducation_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_contacteducation_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_contacteducation_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contacteducation_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_contacteducation_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contacteducation_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_contacteducation_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_contacteducation_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_contacteducation_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contacteducation_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_contacteducation_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contacteducation_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_contacteducation_ProcessSession")]
    public IEnumerable<ProcessSession> ait_contacteducation_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_contacteducation_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contacteducation_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_contacteducation_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contacteducation_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_contacteducation_SyncErrors")]
    public IEnumerable<SyncError> ait_contacteducation_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_contacteducation_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contacteducation_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_contacteducation_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contacteducation_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_contacteducation_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_contacteducation_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_contacteducation_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contacteducation_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_contacteducation_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contacteducation_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_degree")]
    [RelationshipSchemaName("ait_ait_contacteducation_ait_degree")]
    public ArcticIT.EarlyBound.Entities.ait_degree ait_ait_contacteducation_ait_degree
    {
      get
      {
        return this.GetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_degree>(nameof (ait_ait_contacteducation_ait_degree), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_contacteducation_ait_degree));
        this.SetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_degree>(nameof (ait_ait_contacteducation_ait_degree), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_contacteducation_ait_degree));
      }
    }

    [AttributeLogicalName("ait_school")]
    [RelationshipSchemaName("ait_ait_contacteducation_ait_school")]
    public ArcticIT.EarlyBound.Entities.ait_school ait_ait_contacteducation_ait_school
    {
      get
      {
        return this.GetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_school>(nameof (ait_ait_contacteducation_ait_school), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_contacteducation_ait_school));
        this.SetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_school>(nameof (ait_ait_contacteducation_ait_school), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_contacteducation_ait_school));
      }
    }

    [AttributeLogicalName("ait_type")]
    [RelationshipSchemaName("ait_ait_contacteducation_ait_schooltype")]
    public ait_schooltype ait_ait_contacteducation_ait_schooltype
    {
      get
      {
        return this.GetRelatedEntity<ait_schooltype>(nameof (ait_ait_contacteducation_ait_schooltype), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_contacteducation_ait_schooltype));
        this.SetRelatedEntity<ait_schooltype>(nameof (ait_ait_contacteducation_ait_schooltype), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_contacteducation_ait_schooltype));
      }
    }

    [AttributeLogicalName("ait_contact")]
    [RelationshipSchemaName("ait_ait_contacteducation_contact")]
    public Contact ait_ait_contacteducation_contact
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (ait_ait_contacteducation_contact), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_contacteducation_contact));
        this.SetRelatedEntity<Contact>(nameof (ait_ait_contacteducation_contact), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_contacteducation_contact));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_contacteducation")]
    public BusinessUnit business_unit_ait_contacteducation
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_contacteducation), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_contacteducation_createdby")]
    public SystemUser lk_ait_contacteducation_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_contacteducation_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_contacteducation_createdonbehalfby")]
    public SystemUser lk_ait_contacteducation_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_contacteducation_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_contacteducation_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_contacteducation_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_contacteducation_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_contacteducation_modifiedby")]
    public SystemUser lk_ait_contacteducation_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_contacteducation_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_contacteducation_modifiedonbehalfby")]
    public SystemUser lk_ait_contacteducation_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_contacteducation_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_contacteducation_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_contacteducation_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_contacteducation_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_contacteducation")]
    public Team team_ait_contacteducation
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_contacteducation), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_contacteducation")]
    public SystemUser user_ait_contacteducation
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_ait_contacteducation), new EntityRole?());
      }
    }

    public ait_contacteducation(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_contacteducationid"] = (object) base.Id;
            break;
          case "ait_contacteducationid":
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
