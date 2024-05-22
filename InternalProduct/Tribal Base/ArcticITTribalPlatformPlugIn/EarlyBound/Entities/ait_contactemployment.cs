// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_contactemployment
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_contactemployment")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_contactemployment : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_contactemployment";
    public const string EntitySchemaName = "ait_contactemployment";
    public const string PrimaryIdAttribute = "ait_contactemploymentid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_contactemployment()
      : base(nameof (ait_contactemployment))
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

    [AttributeLogicalName("ait_cardlastissuedby")]
    public string ait_cardlastissuedby
    {
      get => this.GetAttributeValue<string>(nameof (ait_cardlastissuedby));
      set
      {
        this.OnPropertyChanging(nameof (ait_cardlastissuedby));
        this.SetAttributeValue(nameof (ait_cardlastissuedby), (object) value);
        this.OnPropertyChanged(nameof (ait_cardlastissuedby));
      }
    }

    [AttributeLogicalName("ait_cardlastissueddate")]
    public DateTime? ait_cardlastissueddate
    {
      get => this.GetAttributeValue<DateTime?>(nameof (ait_cardlastissueddate));
      set
      {
        this.OnPropertyChanging(nameof (ait_cardlastissueddate));
        this.SetAttributeValue(nameof (ait_cardlastissueddate), (object) value);
        this.OnPropertyChanged(nameof (ait_cardlastissueddate));
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

    [AttributeLogicalName("ait_contactemploymentid")]
    public Guid? ait_contactemploymentId
    {
      get => this.GetAttributeValue<Guid?>("ait_contactemploymentid");
      set
      {
        this.OnPropertyChanging(nameof (ait_contactemploymentId));
        this.SetAttributeValue("ait_contactemploymentid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_contactemploymentId));
      }
    }

    [AttributeLogicalName("ait_contactemploymentid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_contactemploymentId = new Guid?(value);
    }

    [AttributeLogicalName("ait_currentlyemployed")]
    public OptionSetValue ait_currentlyemployed
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_currentlyemployed));
      set
      {
        this.OnPropertyChanging(nameof (ait_currentlyemployed));
        this.SetAttributeValue(nameof (ait_currentlyemployed), (object) value);
        this.OnPropertyChanged(nameof (ait_currentlyemployed));
      }
    }

    [AttributeLogicalName("ait_department")]
    public string ait_Department
    {
      get => this.GetAttributeValue<string>("ait_department");
      set
      {
        this.OnPropertyChanging(nameof (ait_Department));
        this.SetAttributeValue("ait_department", (object) value);
        this.OnPropertyChanged(nameof (ait_Department));
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

    [AttributeLogicalName("ait_employeeid")]
    public string ait_employeeid
    {
      get => this.GetAttributeValue<string>(nameof (ait_employeeid));
      set
      {
        this.OnPropertyChanging(nameof (ait_employeeid));
        this.SetAttributeValue(nameof (ait_employeeid), (object) value);
        this.OnPropertyChanged(nameof (ait_employeeid));
      }
    }

    [AttributeLogicalName("ait_employer")]
    public EntityReference ait_employer
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_employer));
      set
      {
        this.OnPropertyChanging(nameof (ait_employer));
        this.SetAttributeValue(nameof (ait_employer), (object) value);
        this.OnPropertyChanged(nameof (ait_employer));
      }
    }

    [AttributeLogicalName("ait_employmentstatus")]
    public OptionSetValue ait_employmentstatus
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_employmentstatus));
      set
      {
        this.OnPropertyChanging(nameof (ait_employmentstatus));
        this.SetAttributeValue(nameof (ait_employmentstatus), (object) value);
        this.OnPropertyChanged(nameof (ait_employmentstatus));
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

    [AttributeLogicalName("ait_reasonforunemployment")]
    public OptionSetValue ait_reasonforunemployment
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_reasonforunemployment));
      set
      {
        this.OnPropertyChanging(nameof (ait_reasonforunemployment));
        this.SetAttributeValue(nameof (ait_reasonforunemployment), (object) value);
        this.OnPropertyChanged(nameof (ait_reasonforunemployment));
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
    public ait_contactemploymentState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_contactemploymentState?((ait_contactemploymentState) Enum.ToObject(typeof (ait_contactemploymentState), attributeValue.Value)) : new ait_contactemploymentState?();
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

    [RelationshipSchemaName("ait_ait_contactemployment_contact_employeeidcard")]
    public IEnumerable<Contact> ait_ait_contactemployment_contact_employeeidcard
    {
      get
      {
        return this.GetRelatedEntities<Contact>(nameof (ait_ait_contactemployment_contact_employeeidcard), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_contactemployment_contact_employeeidcard));
        this.SetRelatedEntities<Contact>(nameof (ait_ait_contactemployment_contact_employeeidcard), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_contactemployment_contact_employeeidcard));
      }
    }

    [RelationshipSchemaName("ait_contactemployment_Annotations")]
    public IEnumerable<Annotation> ait_contactemployment_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (ait_contactemployment_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactemployment_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (ait_contactemployment_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactemployment_Annotations));
      }
    }

    [RelationshipSchemaName("ait_contactemployment_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_contactemployment_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_contactemployment_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactemployment_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_contactemployment_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactemployment_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_contactemployment_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_contactemployment_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_contactemployment_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactemployment_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_contactemployment_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactemployment_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_contactemployment_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_contactemployment_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_contactemployment_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactemployment_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_contactemployment_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactemployment_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_contactemployment_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_contactemployment_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_contactemployment_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactemployment_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_contactemployment_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactemployment_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_contactemployment_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_contactemployment_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_contactemployment_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactemployment_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_contactemployment_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactemployment_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_contactemployment_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_contactemployment_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_contactemployment_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactemployment_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_contactemployment_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactemployment_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_contactemployment_ProcessSession")]
    public IEnumerable<ProcessSession> ait_contactemployment_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_contactemployment_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactemployment_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_contactemployment_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactemployment_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_contactemployment_SyncErrors")]
    public IEnumerable<SyncError> ait_contactemployment_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_contactemployment_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactemployment_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_contactemployment_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactemployment_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_contactemployment_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_contactemployment_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_contactemployment_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactemployment_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_contactemployment_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactemployment_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_employer")]
    [RelationshipSchemaName("ait_ait_contactemployment_ait_company")]
    public ait_company ait_ait_contactemployment_ait_company
    {
      get
      {
        return this.GetRelatedEntity<ait_company>(nameof (ait_ait_contactemployment_ait_company), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_contactemployment_ait_company));
        this.SetRelatedEntity<ait_company>(nameof (ait_ait_contactemployment_ait_company), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_contactemployment_ait_company));
      }
    }

    [AttributeLogicalName("ait_contact")]
    [RelationshipSchemaName("ait_ait_contactemployment_contact")]
    public Contact ait_ait_contactemployment_contact
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (ait_ait_contactemployment_contact), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_contactemployment_contact));
        this.SetRelatedEntity<Contact>(nameof (ait_ait_contactemployment_contact), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_contactemployment_contact));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_contactemployment")]
    public BusinessUnit business_unit_ait_contactemployment
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_contactemployment), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_contactemployment_createdby")]
    public SystemUser lk_ait_contactemployment_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_contactemployment_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_contactemployment_createdonbehalfby")]
    public SystemUser lk_ait_contactemployment_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_contactemployment_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_contactemployment_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_contactemployment_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_contactemployment_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_contactemployment_modifiedby")]
    public SystemUser lk_ait_contactemployment_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_contactemployment_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_contactemployment_modifiedonbehalfby")]
    public SystemUser lk_ait_contactemployment_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_contactemployment_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_contactemployment_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_contactemployment_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_contactemployment_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_contactemployment")]
    public Team team_ait_contactemployment
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_contactemployment), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_contactemployment")]
    public SystemUser user_ait_contactemployment
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_ait_contactemployment), new EntityRole?());
      }
    }

    public ait_contactemployment(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_contactemploymentid"] = (object) base.Id;
            break;
          case "ait_contactemploymentid":
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
