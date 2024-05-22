// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.revokeinheritedaccessrecordstracker
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("revokeinheritedaccessrecordstracker")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class revokeinheritedaccessrecordstracker : 
    Entity,
    INotifyPropertyChanging,
    INotifyPropertyChanged
  {
    public const string EntityLogicalName = "revokeinheritedaccessrecordstracker";
    public const string EntitySchemaName = "revokeinheritedaccessrecordstracker";
    public const string PrimaryIdAttribute = "revokeinheritedaccessrecordstrackerid";
    public const string PrimaryNameAttribute = "revokeinheritedaccessrecordstracker";

    public revokeinheritedaccessrecordstracker()
      : base(nameof (revokeinheritedaccessrecordstracker))
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

    [AttributeLogicalName("recordsjson")]
    public string RecordsJson
    {
      get => this.GetAttributeValue<string>("recordsjson");
      set
      {
        this.OnPropertyChanging(nameof (RecordsJson));
        this.SetAttributeValue("recordsjson", (object) value);
        this.OnPropertyChanged(nameof (RecordsJson));
      }
    }

    [AttributeLogicalName("revokeinheritedaccessrecordstracker")]
    public string revokeinheritedaccessrecordstracker1
    {
      get => this.GetAttributeValue<string>(nameof (revokeinheritedaccessrecordstracker));
      set
      {
        this.OnPropertyChanging(nameof (revokeinheritedaccessrecordstracker1));
        this.SetAttributeValue(nameof (revokeinheritedaccessrecordstracker), (object) value);
        this.OnPropertyChanged(nameof (revokeinheritedaccessrecordstracker1));
      }
    }

    [AttributeLogicalName("revokeinheritedaccessrecordstrackerid")]
    public Guid? revokeinheritedaccessrecordstrackerId
    {
      get => this.GetAttributeValue<Guid?>("revokeinheritedaccessrecordstrackerid");
      set
      {
        this.OnPropertyChanging(nameof (revokeinheritedaccessrecordstrackerId));
        this.SetAttributeValue("revokeinheritedaccessrecordstrackerid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (revokeinheritedaccessrecordstrackerId));
      }
    }

    [AttributeLogicalName("revokeinheritedaccessrecordstrackerid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.revokeinheritedaccessrecordstrackerId = new Guid?(value);
    }

    [AttributeLogicalName("statecode")]
    public revokeinheritedaccessrecordstrackerState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new revokeinheritedaccessrecordstrackerState?((revokeinheritedaccessrecordstrackerState) Enum.ToObject(typeof (revokeinheritedaccessrecordstrackerState), attributeValue.Value)) : new revokeinheritedaccessrecordstrackerState?();
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

    [AttributeLogicalName("totalrecords")]
    public int? TotalRecords
    {
      get => this.GetAttributeValue<int?>("totalrecords");
      set
      {
        this.OnPropertyChanging(nameof (TotalRecords));
        this.SetAttributeValue("totalrecords", (object) value);
        this.OnPropertyChanged(nameof (TotalRecords));
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

    [RelationshipSchemaName("revokeinheritedaccessrecordstracker_AsyncOperations")]
    public IEnumerable<AsyncOperation> revokeinheritedaccessrecordstracker_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (revokeinheritedaccessrecordstracker_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (revokeinheritedaccessrecordstracker_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (revokeinheritedaccessrecordstracker_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (revokeinheritedaccessrecordstracker_AsyncOperations));
      }
    }

    [RelationshipSchemaName("revokeinheritedaccessrecordstracker_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> revokeinheritedaccessrecordstracker_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (revokeinheritedaccessrecordstracker_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (revokeinheritedaccessrecordstracker_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (revokeinheritedaccessrecordstracker_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (revokeinheritedaccessrecordstracker_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("revokeinheritedaccessrecordstracker_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> revokeinheritedaccessrecordstracker_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (revokeinheritedaccessrecordstracker_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (revokeinheritedaccessrecordstracker_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (revokeinheritedaccessrecordstracker_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (revokeinheritedaccessrecordstracker_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("revokeinheritedaccessrecordstracker_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> revokeinheritedaccessrecordstracker_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (revokeinheritedaccessrecordstracker_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (revokeinheritedaccessrecordstracker_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (revokeinheritedaccessrecordstracker_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (revokeinheritedaccessrecordstracker_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("revokeinheritedaccessrecordstracker_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> revokeinheritedaccessrecordstracker_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (revokeinheritedaccessrecordstracker_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (revokeinheritedaccessrecordstracker_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (revokeinheritedaccessrecordstracker_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (revokeinheritedaccessrecordstracker_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("revokeinheritedaccessrecordstracker_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> revokeinheritedaccessrecordstracker_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (revokeinheritedaccessrecordstracker_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (revokeinheritedaccessrecordstracker_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (revokeinheritedaccessrecordstracker_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (revokeinheritedaccessrecordstracker_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("revokeinheritedaccessrecordstracker_ProcessSession")]
    public IEnumerable<ProcessSession> revokeinheritedaccessrecordstracker_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (revokeinheritedaccessrecordstracker_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (revokeinheritedaccessrecordstracker_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (revokeinheritedaccessrecordstracker_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (revokeinheritedaccessrecordstracker_ProcessSession));
      }
    }

    [RelationshipSchemaName("revokeinheritedaccessrecordstracker_SyncErrors")]
    public IEnumerable<SyncError> revokeinheritedaccessrecordstracker_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (revokeinheritedaccessrecordstracker_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (revokeinheritedaccessrecordstracker_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (revokeinheritedaccessrecordstracker_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (revokeinheritedaccessrecordstracker_SyncErrors));
      }
    }

    [RelationshipSchemaName("revokeinheritedaccessrecordstracker_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> revokeinheritedaccessrecordstracker_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (revokeinheritedaccessrecordstracker_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (revokeinheritedaccessrecordstracker_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (revokeinheritedaccessrecordstracker_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (revokeinheritedaccessrecordstracker_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_revokeinheritedaccessrecordstracker")]
    public BusinessUnit business_unit_revokeinheritedaccessrecordstracker
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_revokeinheritedaccessrecordstracker), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_revokeinheritedaccessrecordstracker_createdby")]
    public SystemUser lk_revokeinheritedaccessrecordstracker_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_revokeinheritedaccessrecordstracker_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_revokeinheritedaccessrecordstracker_createdonbehalfby")]
    public SystemUser lk_revokeinheritedaccessrecordstracker_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_revokeinheritedaccessrecordstracker_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_revokeinheritedaccessrecordstracker_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_revokeinheritedaccessrecordstracker_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_revokeinheritedaccessrecordstracker_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_revokeinheritedaccessrecordstracker_modifiedby")]
    public SystemUser lk_revokeinheritedaccessrecordstracker_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_revokeinheritedaccessrecordstracker_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_revokeinheritedaccessrecordstracker_modifiedonbehalfby")]
    public SystemUser lk_revokeinheritedaccessrecordstracker_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_revokeinheritedaccessrecordstracker_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_revokeinheritedaccessrecordstracker_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_revokeinheritedaccessrecordstracker_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_revokeinheritedaccessrecordstracker_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_revokeinheritedaccessrecordstracker")]
    public Team team_revokeinheritedaccessrecordstracker
    {
      get
      {
        return this.GetRelatedEntity<Team>(nameof (team_revokeinheritedaccessrecordstracker), new EntityRole?());
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_revokeinheritedaccessrecordstracker")]
    public SystemUser user_revokeinheritedaccessrecordstracker
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_revokeinheritedaccessrecordstracker), new EntityRole?());
      }
    }

    public revokeinheritedaccessrecordstracker(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["revokeinheritedaccessrecordstrackerid"] = (object) base.Id;
            break;
          case "revokeinheritedaccessrecordstrackerid":
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
