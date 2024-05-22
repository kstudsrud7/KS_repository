// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_school
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_school")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_school : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_school";
    public const string EntitySchemaName = "ait_school";
    public const string PrimaryIdAttribute = "ait_schoolid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_school()
      : base(nameof (ait_school))
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

    [AttributeLogicalName("ait_address")]
    public EntityReference ait_address
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_address));
      set
      {
        this.OnPropertyChanging(nameof (ait_address));
        this.SetAttributeValue(nameof (ait_address), (object) value);
        this.OnPropertyChanged(nameof (ait_address));
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

    [AttributeLogicalName("ait_primaryaddress")]
    public string ait_primaryaddress
    {
      get => this.GetAttributeValue<string>(nameof (ait_primaryaddress));
      set
      {
        this.OnPropertyChanging(nameof (ait_primaryaddress));
        this.SetAttributeValue(nameof (ait_primaryaddress), (object) value);
        this.OnPropertyChanged(nameof (ait_primaryaddress));
      }
    }

    [AttributeLogicalName("ait_primaryemail")]
    public string ait_primaryemail
    {
      get => this.GetAttributeValue<string>(nameof (ait_primaryemail));
      set
      {
        this.OnPropertyChanging(nameof (ait_primaryemail));
        this.SetAttributeValue(nameof (ait_primaryemail), (object) value);
        this.OnPropertyChanged(nameof (ait_primaryemail));
      }
    }

    [AttributeLogicalName("ait_primaryphone")]
    public string ait_primaryphone
    {
      get => this.GetAttributeValue<string>(nameof (ait_primaryphone));
      set
      {
        this.OnPropertyChanging(nameof (ait_primaryphone));
        this.SetAttributeValue(nameof (ait_primaryphone), (object) value);
        this.OnPropertyChanged(nameof (ait_primaryphone));
      }
    }

    [AttributeLogicalName("ait_schoolid")]
    public Guid? ait_schoolId
    {
      get => this.GetAttributeValue<Guid?>("ait_schoolid");
      set
      {
        this.OnPropertyChanging(nameof (ait_schoolId));
        this.SetAttributeValue("ait_schoolid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_schoolId));
      }
    }

    [AttributeLogicalName("ait_schoolid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_schoolId = new Guid?(value);
    }

    [AttributeLogicalName("ait_schooltype")]
    public EntityReference ait_schooltype
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_schooltype));
      set
      {
        this.OnPropertyChanging(nameof (ait_schooltype));
        this.SetAttributeValue(nameof (ait_schooltype), (object) value);
        this.OnPropertyChanged(nameof (ait_schooltype));
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
    public ait_schoolState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_schoolState?((ait_schoolState) Enum.ToObject(typeof (ait_schoolState), attributeValue.Value)) : new ait_schoolState?();
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

    [RelationshipSchemaName("ait_ait_contacteducation_ait_school")]
    public IEnumerable<ait_contacteducation> ait_ait_contacteducation_ait_school
    {
      get
      {
        return this.GetRelatedEntities<ait_contacteducation>(nameof (ait_ait_contacteducation_ait_school), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_contacteducation_ait_school));
        this.SetRelatedEntities<ait_contacteducation>(nameof (ait_ait_contacteducation_ait_school), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_contacteducation_ait_school));
      }
    }

    [RelationshipSchemaName("ait_ait_electronicaddress_ait_school")]
    public IEnumerable<ait_electronicaddress> ait_ait_electronicaddress_ait_school
    {
      get
      {
        return this.GetRelatedEntities<ait_electronicaddress>(nameof (ait_ait_electronicaddress_ait_school), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_electronicaddress_ait_school));
        this.SetRelatedEntities<ait_electronicaddress>(nameof (ait_ait_electronicaddress_ait_school), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_electronicaddress_ait_school));
      }
    }

    [RelationshipSchemaName("ait_ait_physicaladdress_ait_school")]
    public IEnumerable<ait_physicaladdress> ait_ait_physicaladdress_ait_school
    {
      get
      {
        return this.GetRelatedEntities<ait_physicaladdress>(nameof (ait_ait_physicaladdress_ait_school), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_physicaladdress_ait_school));
        this.SetRelatedEntities<ait_physicaladdress>(nameof (ait_ait_physicaladdress_ait_school), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_physicaladdress_ait_school));
      }
    }

    [RelationshipSchemaName("ait_school_Annotations")]
    public IEnumerable<Annotation> ait_school_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (ait_school_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_school_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (ait_school_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_school_Annotations));
      }
    }

    [RelationshipSchemaName("ait_school_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_school_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_school_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_school_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_school_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_school_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_school_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_school_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_school_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_school_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_school_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_school_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_school_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_school_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_school_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_school_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_school_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_school_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_school_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_school_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_school_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_school_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_school_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_school_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_school_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_school_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_school_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_school_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_school_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_school_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_school_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_school_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_school_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_school_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_school_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_school_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_school_ProcessSession")]
    public IEnumerable<ProcessSession> ait_school_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_school_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_school_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_school_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_school_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_school_SyncErrors")]
    public IEnumerable<SyncError> ait_school_SyncErrors
    {
      get => this.GetRelatedEntities<SyncError>(nameof (ait_school_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_school_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_school_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_school_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_school_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_school_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_school_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_school_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_school_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_school_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_address")]
    [RelationshipSchemaName("ait_ait_school_ait_physicaladdress")]
    public ait_physicaladdress ait_ait_school_ait_physicaladdress
    {
      get
      {
        return this.GetRelatedEntity<ait_physicaladdress>(nameof (ait_ait_school_ait_physicaladdress), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_school_ait_physicaladdress));
        this.SetRelatedEntity<ait_physicaladdress>(nameof (ait_ait_school_ait_physicaladdress), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_school_ait_physicaladdress));
      }
    }

    [AttributeLogicalName("ait_schooltype")]
    [RelationshipSchemaName("ait_ait_school_ait_schooltype")]
    public ArcticIT.EarlyBound.Entities.ait_schooltype ait_ait_school_ait_schooltype
    {
      get
      {
        return this.GetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_schooltype>(nameof (ait_ait_school_ait_schooltype), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_school_ait_schooltype));
        this.SetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_schooltype>(nameof (ait_ait_school_ait_schooltype), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_school_ait_schooltype));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_school")]
    public BusinessUnit business_unit_ait_school
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_school), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_school_createdby")]
    public SystemUser lk_ait_school_createdby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_ait_school_createdby), new EntityRole?());
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_school_createdonbehalfby")]
    public SystemUser lk_ait_school_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_school_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_school_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_school_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_school_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_school_modifiedby")]
    public SystemUser lk_ait_school_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_school_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_school_modifiedonbehalfby")]
    public SystemUser lk_ait_school_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_school_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_school_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_school_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_school_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_school")]
    public Team team_ait_school
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_school), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_school")]
    public SystemUser user_ait_school
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_ait_school), new EntityRole?());
    }

    public ait_school(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_schoolid"] = (object) base.Id;
            break;
          case "ait_schoolid":
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
