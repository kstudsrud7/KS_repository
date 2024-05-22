// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_cardhistory
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_cardhistory")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_cardhistory : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_cardhistory";
    public const string EntitySchemaName = "ait_cardhistory";
    public const string PrimaryIdAttribute = "ait_cardhistoryid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_cardhistory()
      : base(nameof (ait_cardhistory))
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

    [AttributeLogicalName("ait_actioncard")]
    public EntityReference ait_actioncard
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_actioncard));
      set
      {
        this.OnPropertyChanging(nameof (ait_actioncard));
        this.SetAttributeValue(nameof (ait_actioncard), (object) value);
        this.OnPropertyChanged(nameof (ait_actioncard));
      }
    }

    [AttributeLogicalName("ait_actioncontact")]
    public EntityReference ait_actioncontact
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_actioncontact));
      set
      {
        this.OnPropertyChanging(nameof (ait_actioncontact));
        this.SetAttributeValue(nameof (ait_actioncontact), (object) value);
        this.OnPropertyChanged(nameof (ait_actioncontact));
      }
    }

    [AttributeLogicalName("ait_actiondescription")]
    public string ait_actiondescription
    {
      get => this.GetAttributeValue<string>(nameof (ait_actiondescription));
      set
      {
        this.OnPropertyChanging(nameof (ait_actiondescription));
        this.SetAttributeValue(nameof (ait_actiondescription), (object) value);
        this.OnPropertyChanged(nameof (ait_actiondescription));
      }
    }

    [AttributeLogicalName("ait_actiontaken")]
    public OptionSetValue ait_actiontaken
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_actiontaken));
      set
      {
        this.OnPropertyChanging(nameof (ait_actiontaken));
        this.SetAttributeValue(nameof (ait_actiontaken), (object) value);
        this.OnPropertyChanged(nameof (ait_actiontaken));
      }
    }

    [AttributeLogicalName("ait_actionuser")]
    public EntityReference ait_actionuser
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_actionuser));
      set
      {
        this.OnPropertyChanging(nameof (ait_actionuser));
        this.SetAttributeValue(nameof (ait_actionuser), (object) value);
        this.OnPropertyChanged(nameof (ait_actionuser));
      }
    }

    [AttributeLogicalName("ait_cardhistoryid")]
    public Guid? ait_cardhistoryId
    {
      get => this.GetAttributeValue<Guid?>("ait_cardhistoryid");
      set
      {
        this.OnPropertyChanging(nameof (ait_cardhistoryId));
        this.SetAttributeValue("ait_cardhistoryid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_cardhistoryId));
      }
    }

    [AttributeLogicalName("ait_cardhistoryid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_cardhistoryId = new Guid?(value);
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
    public ait_cardhistoryState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_cardhistoryState?((ait_cardhistoryState) Enum.ToObject(typeof (ait_cardhistoryState), attributeValue.Value)) : new ait_cardhistoryState?();
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

    [RelationshipSchemaName("ait_cardhistory_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_cardhistory_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_cardhistory_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_cardhistory_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_cardhistory_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_cardhistory_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_cardhistory_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_cardhistory_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_cardhistory_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_cardhistory_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_cardhistory_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_cardhistory_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_cardhistory_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_cardhistory_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_cardhistory_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_cardhistory_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_cardhistory_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_cardhistory_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_cardhistory_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_cardhistory_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_cardhistory_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_cardhistory_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_cardhistory_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_cardhistory_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_cardhistory_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_cardhistory_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_cardhistory_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_cardhistory_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_cardhistory_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_cardhistory_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_cardhistory_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_cardhistory_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_cardhistory_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_cardhistory_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_cardhistory_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_cardhistory_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_cardhistory_ProcessSession")]
    public IEnumerable<ProcessSession> ait_cardhistory_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_cardhistory_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_cardhistory_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_cardhistory_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_cardhistory_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_cardhistory_SyncErrors")]
    public IEnumerable<SyncError> ait_cardhistory_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_cardhistory_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_cardhistory_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_cardhistory_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_cardhistory_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_cardhistory_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_cardhistory_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_cardhistory_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_cardhistory_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_cardhistory_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_cardhistory_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_actioncard")]
    [RelationshipSchemaName("ait_ait_cardformat_ait_cardhistory_actioncard")]
    public ait_cardformat ait_ait_cardformat_ait_cardhistory_actioncard
    {
      get
      {
        return this.GetRelatedEntity<ait_cardformat>(nameof (ait_ait_cardformat_ait_cardhistory_actioncard), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_cardformat_ait_cardhistory_actioncard));
        this.SetRelatedEntity<ait_cardformat>(nameof (ait_ait_cardformat_ait_cardhistory_actioncard), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_cardformat_ait_cardhistory_actioncard));
      }
    }

    [AttributeLogicalName("ait_actioncontact")]
    [RelationshipSchemaName("ait_contact_ait_cardhistory_actioncontact")]
    public Contact ait_contact_ait_cardhistory_actioncontact
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (ait_contact_ait_cardhistory_actioncontact), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contact_ait_cardhistory_actioncontact));
        this.SetRelatedEntity<Contact>(nameof (ait_contact_ait_cardhistory_actioncontact), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contact_ait_cardhistory_actioncontact));
      }
    }

    [AttributeLogicalName("ait_actionuser")]
    [RelationshipSchemaName("ait_systemuser_ait_cardhistory_actionuser")]
    public SystemUser ait_systemuser_ait_cardhistory_actionuser
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (ait_systemuser_ait_cardhistory_actionuser), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_systemuser_ait_cardhistory_actionuser));
        this.SetRelatedEntity<SystemUser>(nameof (ait_systemuser_ait_cardhistory_actionuser), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_systemuser_ait_cardhistory_actionuser));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_cardhistory")]
    public BusinessUnit business_unit_ait_cardhistory
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_cardhistory), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_cardhistory_createdby")]
    public SystemUser lk_ait_cardhistory_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_cardhistory_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_cardhistory_createdonbehalfby")]
    public SystemUser lk_ait_cardhistory_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_cardhistory_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_cardhistory_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_cardhistory_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_cardhistory_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_cardhistory_modifiedby")]
    public SystemUser lk_ait_cardhistory_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_cardhistory_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_cardhistory_modifiedonbehalfby")]
    public SystemUser lk_ait_cardhistory_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_cardhistory_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_cardhistory_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_cardhistory_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_cardhistory_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_cardhistory")]
    public Team team_ait_cardhistory
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_cardhistory), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_cardhistory")]
    public SystemUser user_ait_cardhistory
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_ait_cardhistory), new EntityRole?());
    }

    public ait_cardhistory(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_cardhistoryid"] = (object) base.Id;
            break;
          case "ait_cardhistoryid":
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
