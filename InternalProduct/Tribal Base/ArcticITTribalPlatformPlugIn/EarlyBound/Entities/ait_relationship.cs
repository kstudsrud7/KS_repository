// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_relationship
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_relationship")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_relationship : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_relationship";
    public const string EntitySchemaName = "ait_relationship";
    public const string PrimaryIdAttribute = "ait_relationshipid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_relationship()
      : base(nameof (ait_relationship))
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

    [AttributeLogicalName("ait_birthdate")]
    public DateTime? ait_birthdate
    {
      get => this.GetAttributeValue<DateTime?>(nameof (ait_birthdate));
      set
      {
        this.OnPropertyChanging(nameof (ait_birthdate));
        this.SetAttributeValue(nameof (ait_birthdate), (object) value);
        this.OnPropertyChanged(nameof (ait_birthdate));
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

    [AttributeLogicalName("ait_courtappointedconservator")]
    public OptionSetValue ait_courtappointedconservator
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_courtappointedconservator));
      set
      {
        this.OnPropertyChanging(nameof (ait_courtappointedconservator));
        this.SetAttributeValue(nameof (ait_courtappointedconservator), (object) value);
        this.OnPropertyChanged(nameof (ait_courtappointedconservator));
      }
    }

    [AttributeLogicalName("ait_custodydescriptioninfo")]
    public string ait_custodydescriptioninfo
    {
      get => this.GetAttributeValue<string>(nameof (ait_custodydescriptioninfo));
      set
      {
        this.OnPropertyChanging(nameof (ait_custodydescriptioninfo));
        this.SetAttributeValue(nameof (ait_custodydescriptioninfo), (object) value);
        this.OnPropertyChanged(nameof (ait_custodydescriptioninfo));
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

    [AttributeLogicalName("ait_legalnoncustodyrights")]
    public OptionSetValue ait_legalnoncustodyrights
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_legalnoncustodyrights));
      set
      {
        this.OnPropertyChanging(nameof (ait_legalnoncustodyrights));
        this.SetAttributeValue(nameof (ait_legalnoncustodyrights), (object) value);
        this.OnPropertyChanged(nameof (ait_legalnoncustodyrights));
      }
    }

    [AttributeLogicalName("ait_legalstatus")]
    public OptionSetValue ait_legalstatus
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_legalstatus));
      set
      {
        this.OnPropertyChanging(nameof (ait_legalstatus));
        this.SetAttributeValue(nameof (ait_legalstatus), (object) value);
        this.OnPropertyChanged(nameof (ait_legalstatus));
      }
    }

    [AttributeLogicalName("ait_legalvisitation")]
    public OptionSetValue ait_legalvisitation
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_legalvisitation));
      set
      {
        this.OnPropertyChanging(nameof (ait_legalvisitation));
        this.SetAttributeValue(nameof (ait_legalvisitation), (object) value);
        this.OnPropertyChanged(nameof (ait_legalvisitation));
      }
    }

    [AttributeLogicalName("ait_maritalstatus")]
    public OptionSetValue ait_maritalstatus
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_maritalstatus));
      set
      {
        this.OnPropertyChanging(nameof (ait_maritalstatus));
        this.SetAttributeValue(nameof (ait_maritalstatus), (object) value);
        this.OnPropertyChanged(nameof (ait_maritalstatus));
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

    [AttributeLogicalName("ait_relationshipid")]
    public Guid? ait_relationshipId
    {
      get => this.GetAttributeValue<Guid?>("ait_relationshipid");
      set
      {
        this.OnPropertyChanging(nameof (ait_relationshipId));
        this.SetAttributeValue("ait_relationshipid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_relationshipId));
      }
    }

    [AttributeLogicalName("ait_relationshipid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_relationshipId = new Guid?(value);
    }

    [AttributeLogicalName("ait_relationshipreason")]
    public OptionSetValue ait_relationshipreason
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_relationshipreason));
      set
      {
        this.OnPropertyChanging(nameof (ait_relationshipreason));
        this.SetAttributeValue(nameof (ait_relationshipreason), (object) value);
        this.OnPropertyChanged(nameof (ait_relationshipreason));
      }
    }

    [AttributeLogicalName("ait_relationshipto")]
    public EntityReference ait_RelationshipTo
    {
      get => this.GetAttributeValue<EntityReference>("ait_relationshipto");
      set
      {
        this.OnPropertyChanging(nameof (ait_RelationshipTo));
        this.SetAttributeValue("ait_relationshipto", (object) value);
        this.OnPropertyChanged(nameof (ait_RelationshipTo));
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
    public ait_relationshipState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_relationshipState?((ait_relationshipState) Enum.ToObject(typeof (ait_relationshipState), attributeValue.Value)) : new ait_relationshipState?();
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

    [RelationshipSchemaName("ait_relationship_Annotations")]
    public IEnumerable<Annotation> ait_relationship_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (ait_relationship_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_relationship_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (ait_relationship_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_relationship_Annotations));
      }
    }

    [RelationshipSchemaName("ait_relationship_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_relationship_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_relationship_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_relationship_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_relationship_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_relationship_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_relationship_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_relationship_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_relationship_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_relationship_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_relationship_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_relationship_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_relationship_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_relationship_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_relationship_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_relationship_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_relationship_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_relationship_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_relationship_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_relationship_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_relationship_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_relationship_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_relationship_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_relationship_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_relationship_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_relationship_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_relationship_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_relationship_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_relationship_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_relationship_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_relationship_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_relationship_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_relationship_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_relationship_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_relationship_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_relationship_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_relationship_ProcessSession")]
    public IEnumerable<ProcessSession> ait_relationship_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_relationship_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_relationship_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_relationship_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_relationship_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_relationship_SyncErrors")]
    public IEnumerable<SyncError> ait_relationship_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_relationship_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_relationship_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_relationship_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_relationship_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_relationship_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_relationship_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_relationship_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_relationship_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_relationship_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_relationship_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_contact")]
    [RelationshipSchemaName("ait_ait_relationship_contact")]
    public Contact ait_ait_relationship_contact
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (ait_ait_relationship_contact), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_relationship_contact));
        this.SetRelatedEntity<Contact>(nameof (ait_ait_relationship_contact), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_relationship_contact));
      }
    }

    [AttributeLogicalName("ait_relationshipto")]
    [RelationshipSchemaName("ait_contact_ait_relationship_RelationshipTo")]
    public Contact ait_contact_ait_relationship_RelationshipTo
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (ait_contact_ait_relationship_RelationshipTo), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contact_ait_relationship_RelationshipTo));
        this.SetRelatedEntity<Contact>(nameof (ait_contact_ait_relationship_RelationshipTo), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contact_ait_relationship_RelationshipTo));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_relationship")]
    public BusinessUnit business_unit_ait_relationship
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_relationship), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_relationship_createdby")]
    public SystemUser lk_ait_relationship_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_relationship_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_relationship_createdonbehalfby")]
    public SystemUser lk_ait_relationship_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_relationship_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_relationship_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_relationship_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_relationship_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_relationship_modifiedby")]
    public SystemUser lk_ait_relationship_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_relationship_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_relationship_modifiedonbehalfby")]
    public SystemUser lk_ait_relationship_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_relationship_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_relationship_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_relationship_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_relationship_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_relationship")]
    public Team team_ait_relationship
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_relationship), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_relationship")]
    public SystemUser user_ait_relationship
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_ait_relationship), new EntityRole?());
    }

    public ait_relationship(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_relationshipid"] = (object) base.Id;
            break;
          case "ait_relationshipid":
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
