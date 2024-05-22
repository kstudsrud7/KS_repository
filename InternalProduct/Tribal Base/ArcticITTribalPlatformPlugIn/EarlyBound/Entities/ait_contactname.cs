// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_contactname
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_contactname")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_contactname : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_contactname";
    public const string EntitySchemaName = "ait_contactname";
    public const string PrimaryIdAttribute = "ait_contactnameid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_contactname()
      : base(nameof (ait_contactname))
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

    [AttributeLogicalName("ait_contactnameid")]
    public Guid? ait_contactnameId
    {
      get => this.GetAttributeValue<Guid?>("ait_contactnameid");
      set
      {
        this.OnPropertyChanging(nameof (ait_contactnameId));
        this.SetAttributeValue("ait_contactnameid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_contactnameId));
      }
    }

    [AttributeLogicalName("ait_contactnameid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_contactnameId = new Guid?(value);
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

    [AttributeLogicalName("ait_usedfrom")]
    public DateTime? ait_usedfrom
    {
      get => this.GetAttributeValue<DateTime?>(nameof (ait_usedfrom));
      set
      {
        this.OnPropertyChanging(nameof (ait_usedfrom));
        this.SetAttributeValue(nameof (ait_usedfrom), (object) value);
        this.OnPropertyChanged(nameof (ait_usedfrom));
      }
    }

    [AttributeLogicalName("ait_usedto")]
    public DateTime? ait_usedto
    {
      get => this.GetAttributeValue<DateTime?>(nameof (ait_usedto));
      set
      {
        this.OnPropertyChanging(nameof (ait_usedto));
        this.SetAttributeValue(nameof (ait_usedto), (object) value);
        this.OnPropertyChanged(nameof (ait_usedto));
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
    public ait_contactnameState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_contactnameState?((ait_contactnameState) Enum.ToObject(typeof (ait_contactnameState), attributeValue.Value)) : new ait_contactnameState?();
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

    [RelationshipSchemaName("ait_contactname_Annotations")]
    public IEnumerable<Annotation> ait_contactname_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (ait_contactname_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactname_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (ait_contactname_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactname_Annotations));
      }
    }

    [RelationshipSchemaName("ait_contactname_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_contactname_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_contactname_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactname_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_contactname_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactname_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_contactname_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_contactname_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_contactname_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactname_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_contactname_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactname_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_contactname_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_contactname_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_contactname_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactname_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_contactname_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactname_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_contactname_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_contactname_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_contactname_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactname_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_contactname_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactname_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_contactname_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_contactname_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_contactname_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactname_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_contactname_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactname_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_contactname_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_contactname_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_contactname_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactname_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_contactname_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactname_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_contactname_ProcessSession")]
    public IEnumerable<ProcessSession> ait_contactname_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_contactname_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactname_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_contactname_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactname_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_contactname_SyncErrors")]
    public IEnumerable<SyncError> ait_contactname_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_contactname_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactname_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_contactname_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactname_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_contactname_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_contactname_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_contactname_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactname_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_contactname_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactname_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_type")]
    [RelationshipSchemaName("ait_ait_contactname_ait_nametype")]
    public ait_nametype ait_ait_contactname_ait_nametype
    {
      get
      {
        return this.GetRelatedEntity<ait_nametype>(nameof (ait_ait_contactname_ait_nametype), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_contactname_ait_nametype));
        this.SetRelatedEntity<ait_nametype>(nameof (ait_ait_contactname_ait_nametype), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_contactname_ait_nametype));
      }
    }

    [AttributeLogicalName("ait_contact")]
    [RelationshipSchemaName("ait_ait_contactname_contact")]
    public Contact ait_ait_contactname_contact
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (ait_ait_contactname_contact), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_contactname_contact));
        this.SetRelatedEntity<Contact>(nameof (ait_ait_contactname_contact), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_contactname_contact));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_contactname")]
    public BusinessUnit business_unit_ait_contactname
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_contactname), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_contactname_createdby")]
    public SystemUser lk_ait_contactname_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_contactname_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_contactname_createdonbehalfby")]
    public SystemUser lk_ait_contactname_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_contactname_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_contactname_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_contactname_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_contactname_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_contactname_modifiedby")]
    public SystemUser lk_ait_contactname_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_contactname_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_contactname_modifiedonbehalfby")]
    public SystemUser lk_ait_contactname_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_contactname_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_contactname_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_contactname_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_contactname_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_contactname")]
    public Team team_ait_contactname
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_contactname), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_contactname")]
    public SystemUser user_ait_contactname
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_ait_contactname), new EntityRole?());
    }

    public ait_contactname(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_contactnameid"] = (object) base.Id;
            break;
          case "ait_contactnameid":
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
