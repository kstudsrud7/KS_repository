﻿// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_emergencycontact
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_emergencycontact")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_emergencycontact : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_emergencycontact";
    public const string EntitySchemaName = "ait_emergencycontact";
    public const string PrimaryIdAttribute = "ait_emergencycontactid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_emergencycontact()
      : base(nameof (ait_emergencycontact))
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

    [AttributeLogicalName("ait_emergencycontact")]
    public EntityReference ait_EmergencyContact
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_emergencycontact));
      set
      {
        this.OnPropertyChanging(nameof (ait_EmergencyContact));
        this.SetAttributeValue(nameof (ait_emergencycontact), (object) value);
        this.OnPropertyChanged(nameof (ait_EmergencyContact));
      }
    }

    [AttributeLogicalName("ait_emergencycontactid")]
    public Guid? ait_emergencycontactId
    {
      get => this.GetAttributeValue<Guid?>("ait_emergencycontactid");
      set
      {
        this.OnPropertyChanging(nameof (ait_emergencycontactId));
        this.SetAttributeValue("ait_emergencycontactid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_emergencycontactId));
      }
    }

    [AttributeLogicalName("ait_emergencycontactid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_emergencycontactId = new Guid?(value);
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

    [AttributeLogicalName("ait_phone")]
    public EntityReference ait_phone
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_phone));
      set
      {
        this.OnPropertyChanging(nameof (ait_phone));
        this.SetAttributeValue(nameof (ait_phone), (object) value);
        this.OnPropertyChanged(nameof (ait_phone));
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
    public ait_emergencycontactState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_emergencycontactState?((ait_emergencycontactState) Enum.ToObject(typeof (ait_emergencycontactState), attributeValue.Value)) : new ait_emergencycontactState?();
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

    [RelationshipSchemaName("ait_contact_ait_emergencycontact")]
    public IEnumerable<Contact> ait_contact_ait_emergencycontact
    {
      get
      {
        return this.GetRelatedEntities<Contact>(nameof (ait_contact_ait_emergencycontact), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contact_ait_emergencycontact));
        this.SetRelatedEntities<Contact>(nameof (ait_contact_ait_emergencycontact), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contact_ait_emergencycontact));
      }
    }

    [RelationshipSchemaName("ait_emergencycontact_Annotations")]
    public IEnumerable<Annotation> ait_emergencycontact_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (ait_emergencycontact_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_emergencycontact_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (ait_emergencycontact_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_emergencycontact_Annotations));
      }
    }

    [RelationshipSchemaName("ait_emergencycontact_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_emergencycontact_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_emergencycontact_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_emergencycontact_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_emergencycontact_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_emergencycontact_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_emergencycontact_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_emergencycontact_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_emergencycontact_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_emergencycontact_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_emergencycontact_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_emergencycontact_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_emergencycontact_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_emergencycontact_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_emergencycontact_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_emergencycontact_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_emergencycontact_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_emergencycontact_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_emergencycontact_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_emergencycontact_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_emergencycontact_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_emergencycontact_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_emergencycontact_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_emergencycontact_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_emergencycontact_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_emergencycontact_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_emergencycontact_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_emergencycontact_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_emergencycontact_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_emergencycontact_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_emergencycontact_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_emergencycontact_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_emergencycontact_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_emergencycontact_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_emergencycontact_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_emergencycontact_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_emergencycontact_ProcessSession")]
    public IEnumerable<ProcessSession> ait_emergencycontact_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_emergencycontact_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_emergencycontact_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_emergencycontact_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_emergencycontact_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_emergencycontact_SyncErrors")]
    public IEnumerable<SyncError> ait_emergencycontact_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_emergencycontact_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_emergencycontact_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_emergencycontact_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_emergencycontact_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_emergencycontact_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_emergencycontact_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_emergencycontact_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_emergencycontact_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_emergencycontact_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_emergencycontact_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_phone")]
    [RelationshipSchemaName("ait_ait_emergencycontact_ait_electronicaddress")]
    public ait_electronicaddress ait_ait_emergencycontact_ait_electronicaddress
    {
      get
      {
        return this.GetRelatedEntity<ait_electronicaddress>(nameof (ait_ait_emergencycontact_ait_electronicaddress), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_emergencycontact_ait_electronicaddress));
        this.SetRelatedEntity<ait_electronicaddress>(nameof (ait_ait_emergencycontact_ait_electronicaddress), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_emergencycontact_ait_electronicaddress));
      }
    }

    [AttributeLogicalName("ait_address")]
    [RelationshipSchemaName("ait_ait_emergencycontact_ait_physicaladdress")]
    public ait_physicaladdress ait_ait_emergencycontact_ait_physicaladdress
    {
      get
      {
        return this.GetRelatedEntity<ait_physicaladdress>(nameof (ait_ait_emergencycontact_ait_physicaladdress), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_emergencycontact_ait_physicaladdress));
        this.SetRelatedEntity<ait_physicaladdress>(nameof (ait_ait_emergencycontact_ait_physicaladdress), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_emergencycontact_ait_physicaladdress));
      }
    }

    [AttributeLogicalName("ait_contact")]
    [RelationshipSchemaName("ait_ait_emergencycontact_contact")]
    public Contact ait_ait_emergencycontact_contact
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (ait_ait_emergencycontact_contact), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_emergencycontact_contact));
        this.SetRelatedEntity<Contact>(nameof (ait_ait_emergencycontact_contact), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_emergencycontact_contact));
      }
    }

    [AttributeLogicalName("ait_emergencycontact")]
    [RelationshipSchemaName("ait_contact_ait_emergencycontact_EmergencyContact")]
    public Contact ait_contact_ait_emergencycontact_EmergencyContact
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (ait_contact_ait_emergencycontact_EmergencyContact), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contact_ait_emergencycontact_EmergencyContact));
        this.SetRelatedEntity<Contact>(nameof (ait_contact_ait_emergencycontact_EmergencyContact), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contact_ait_emergencycontact_EmergencyContact));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_emergencycontact")]
    public BusinessUnit business_unit_ait_emergencycontact
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_emergencycontact), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_emergencycontact_createdby")]
    public SystemUser lk_ait_emergencycontact_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_emergencycontact_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_emergencycontact_createdonbehalfby")]
    public SystemUser lk_ait_emergencycontact_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_emergencycontact_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_emergencycontact_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_emergencycontact_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_emergencycontact_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_emergencycontact_modifiedby")]
    public SystemUser lk_ait_emergencycontact_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_emergencycontact_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_emergencycontact_modifiedonbehalfby")]
    public SystemUser lk_ait_emergencycontact_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_emergencycontact_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_emergencycontact_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_emergencycontact_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_emergencycontact_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_emergencycontact")]
    public Team team_ait_emergencycontact
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_emergencycontact), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_emergencycontact")]
    public SystemUser user_ait_emergencycontact
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_ait_emergencycontact), new EntityRole?());
      }
    }

    public ait_emergencycontact(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_emergencycontactid"] = (object) base.Id;
            break;
          case "ait_emergencycontactid":
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