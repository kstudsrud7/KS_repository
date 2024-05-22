// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_contactcertification
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_contactcertification")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_contactcertification : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_contactcertification";
    public const string EntitySchemaName = "ait_contactcertification";
    public const string PrimaryIdAttribute = "ait_contactcertificationid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_contactcertification()
      : base(nameof (ait_contactcertification))
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

    [AttributeLogicalName("ait_certification")]
    public EntityReference ait_certification
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_certification));
      set
      {
        this.OnPropertyChanging(nameof (ait_certification));
        this.SetAttributeValue(nameof (ait_certification), (object) value);
        this.OnPropertyChanged(nameof (ait_certification));
      }
    }

    [AttributeLogicalName("ait_certificationdate")]
    public DateTime? ait_certificationdate
    {
      get => this.GetAttributeValue<DateTime?>(nameof (ait_certificationdate));
      set
      {
        this.OnPropertyChanging(nameof (ait_certificationdate));
        this.SetAttributeValue(nameof (ait_certificationdate), (object) value);
        this.OnPropertyChanged(nameof (ait_certificationdate));
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

    [AttributeLogicalName("ait_contactcertificationid")]
    public Guid? ait_contactcertificationId
    {
      get => this.GetAttributeValue<Guid?>("ait_contactcertificationid");
      set
      {
        this.OnPropertyChanging(nameof (ait_contactcertificationId));
        this.SetAttributeValue("ait_contactcertificationid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_contactcertificationId));
      }
    }

    [AttributeLogicalName("ait_contactcertificationid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_contactcertificationId = new Guid?(value);
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

    [AttributeLogicalName("ait_expirationdate")]
    public DateTime? ait_expirationdate
    {
      get => this.GetAttributeValue<DateTime?>(nameof (ait_expirationdate));
      set
      {
        this.OnPropertyChanging(nameof (ait_expirationdate));
        this.SetAttributeValue(nameof (ait_expirationdate), (object) value);
        this.OnPropertyChanged(nameof (ait_expirationdate));
      }
    }

    [AttributeLogicalName("ait_idnumber")]
    public string ait_idnumber
    {
      get => this.GetAttributeValue<string>(nameof (ait_idnumber));
      set
      {
        this.OnPropertyChanging(nameof (ait_idnumber));
        this.SetAttributeValue(nameof (ait_idnumber), (object) value);
        this.OnPropertyChanged(nameof (ait_idnumber));
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
    public ait_contactcertificationState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_contactcertificationState?((ait_contactcertificationState) Enum.ToObject(typeof (ait_contactcertificationState), attributeValue.Value)) : new ait_contactcertificationState?();
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

    [RelationshipSchemaName("ait_ait_contactcertification_contact_certificationidcard")]
    public IEnumerable<Contact> ait_ait_contactcertification_contact_certificationidcard
    {
      get
      {
        return this.GetRelatedEntities<Contact>(nameof (ait_ait_contactcertification_contact_certificationidcard), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_contactcertification_contact_certificationidcard));
        this.SetRelatedEntities<Contact>(nameof (ait_ait_contactcertification_contact_certificationidcard), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_contactcertification_contact_certificationidcard));
      }
    }

    [RelationshipSchemaName("ait_contactcertification_Annotations")]
    public IEnumerable<Annotation> ait_contactcertification_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (ait_contactcertification_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactcertification_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (ait_contactcertification_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactcertification_Annotations));
      }
    }

    [RelationshipSchemaName("ait_contactcertification_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_contactcertification_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_contactcertification_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactcertification_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_contactcertification_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactcertification_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_contactcertification_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_contactcertification_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_contactcertification_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactcertification_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_contactcertification_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactcertification_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_contactcertification_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_contactcertification_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_contactcertification_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactcertification_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_contactcertification_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactcertification_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_contactcertification_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_contactcertification_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_contactcertification_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactcertification_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_contactcertification_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactcertification_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_contactcertification_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_contactcertification_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_contactcertification_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactcertification_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_contactcertification_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactcertification_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_contactcertification_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_contactcertification_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_contactcertification_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactcertification_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_contactcertification_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactcertification_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_contactcertification_ProcessSession")]
    public IEnumerable<ProcessSession> ait_contactcertification_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_contactcertification_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactcertification_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_contactcertification_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactcertification_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_contactcertification_SyncErrors")]
    public IEnumerable<SyncError> ait_contactcertification_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_contactcertification_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactcertification_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_contactcertification_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactcertification_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_contactcertification_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_contactcertification_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_contactcertification_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactcertification_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_contactcertification_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactcertification_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_certification")]
    [RelationshipSchemaName("ait_ait_contactcertification_ait_certification")]
    public ArcticIT.EarlyBound.Entities.ait_certification ait_ait_contactcertification_ait_certification
    {
      get
      {
        return this.GetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_certification>(nameof (ait_ait_contactcertification_ait_certification), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_contactcertification_ait_certification));
        this.SetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_certification>(nameof (ait_ait_contactcertification_ait_certification), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_contactcertification_ait_certification));
      }
    }

    [AttributeLogicalName("ait_contact")]
    [RelationshipSchemaName("ait_ait_contactcertification_contact")]
    public Contact ait_ait_contactcertification_contact
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (ait_ait_contactcertification_contact), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_contactcertification_contact));
        this.SetRelatedEntity<Contact>(nameof (ait_ait_contactcertification_contact), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_contactcertification_contact));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_contactcertification")]
    public BusinessUnit business_unit_ait_contactcertification
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_contactcertification), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_contactcertification_createdby")]
    public SystemUser lk_ait_contactcertification_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_contactcertification_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_contactcertification_createdonbehalfby")]
    public SystemUser lk_ait_contactcertification_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_contactcertification_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_contactcertification_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_contactcertification_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_contactcertification_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_contactcertification_modifiedby")]
    public SystemUser lk_ait_contactcertification_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_contactcertification_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_contactcertification_modifiedonbehalfby")]
    public SystemUser lk_ait_contactcertification_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_contactcertification_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_contactcertification_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_contactcertification_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_contactcertification_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_contactcertification")]
    public Team team_ait_contactcertification
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_contactcertification), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_contactcertification")]
    public SystemUser user_ait_contactcertification
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_ait_contactcertification), new EntityRole?());
      }
    }

    public ait_contactcertification(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_contactcertificationid"] = (object) base.Id;
            break;
          case "ait_contactcertificationid":
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
