// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.msdyn_analysisresultdetail
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("msdyn_analysisresultdetail")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class msdyn_analysisresultdetail : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "msdyn_analysisresultdetail";
    public const string EntitySchemaName = "msdyn_analysisresultdetail";
    public const string PrimaryIdAttribute = "msdyn_analysisresultdetailid";
    public const string PrimaryNameAttribute = "msdyn_name";

    public msdyn_analysisresultdetail()
      : base(nameof (msdyn_analysisresultdetail))
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

    [AttributeLogicalName("msdyn_analysisresult")]
    public EntityReference msdyn_AnalysisResult
    {
      get => this.GetAttributeValue<EntityReference>("msdyn_analysisresult");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_AnalysisResult));
        this.SetAttributeValue("msdyn_analysisresult", (object) value);
        this.OnPropertyChanged(nameof (msdyn_AnalysisResult));
      }
    }

    [AttributeLogicalName("msdyn_analysisresultdetailid")]
    public Guid? msdyn_analysisresultdetailId
    {
      get => this.GetAttributeValue<Guid?>("msdyn_analysisresultdetailid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysisresultdetailId));
        this.SetAttributeValue("msdyn_analysisresultdetailid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (msdyn_analysisresultdetailId));
      }
    }

    [AttributeLogicalName("msdyn_analysisresultdetailid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.msdyn_analysisresultdetailId = new Guid?(value);
    }

    [AttributeLogicalName("msdyn_canopenentityrecord")]
    public bool? msdyn_CanOpenEntityRecord
    {
      get => this.GetAttributeValue<bool?>("msdyn_canopenentityrecord");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_CanOpenEntityRecord));
        this.SetAttributeValue("msdyn_canopenentityrecord", (object) value);
        this.OnPropertyChanged(nameof (msdyn_CanOpenEntityRecord));
      }
    }

    [AttributeLogicalName("msdyn_entityname")]
    public string msdyn_EntityName
    {
      get => this.GetAttributeValue<string>("msdyn_entityname");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_EntityName));
        this.SetAttributeValue("msdyn_entityname", (object) value);
        this.OnPropertyChanged(nameof (msdyn_EntityName));
      }
    }

    [AttributeLogicalName("msdyn_message")]
    public string msdyn_Message
    {
      get => this.GetAttributeValue<string>("msdyn_message");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_Message));
        this.SetAttributeValue("msdyn_message", (object) value);
        this.OnPropertyChanged(nameof (msdyn_Message));
      }
    }

    [AttributeLogicalName("msdyn_name")]
    public string msdyn_name
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_name));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_name));
        this.SetAttributeValue(nameof (msdyn_name), (object) value);
        this.OnPropertyChanged(nameof (msdyn_name));
      }
    }

    [AttributeLogicalName("msdyn_resultentityid")]
    public string msdyn_ResultEntityId
    {
      get => this.GetAttributeValue<string>("msdyn_resultentityid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_ResultEntityId));
        this.SetAttributeValue("msdyn_resultentityid", (object) value);
        this.OnPropertyChanged(nameof (msdyn_ResultEntityId));
      }
    }

    [AttributeLogicalName("msdyn_resultentitylogicalname")]
    public string msdyn_ResultEntityLogicalName
    {
      get => this.GetAttributeValue<string>("msdyn_resultentitylogicalname");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_ResultEntityLogicalName));
        this.SetAttributeValue("msdyn_resultentitylogicalname", (object) value);
        this.OnPropertyChanged(nameof (msdyn_ResultEntityLogicalName));
      }
    }

    [AttributeLogicalName("msdyn_resultentityprimarykey")]
    public string msdyn_ResultEntityPrimaryKey
    {
      get => this.GetAttributeValue<string>("msdyn_resultentityprimarykey");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_ResultEntityPrimaryKey));
        this.SetAttributeValue("msdyn_resultentityprimarykey", (object) value);
        this.OnPropertyChanged(nameof (msdyn_ResultEntityPrimaryKey));
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
    public msdyn_analysisresultdetailState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new msdyn_analysisresultdetailState?((msdyn_analysisresultdetailState) Enum.ToObject(typeof (msdyn_analysisresultdetailState), attributeValue.Value)) : new msdyn_analysisresultdetailState?();
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

    [RelationshipSchemaName("msdyn_analysisresultdetail_AsyncOperations")]
    public IEnumerable<AsyncOperation> msdyn_analysisresultdetail_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (msdyn_analysisresultdetail_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysisresultdetail_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (msdyn_analysisresultdetail_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysisresultdetail_AsyncOperations));
      }
    }

    [RelationshipSchemaName("msdyn_analysisresultdetail_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> msdyn_analysisresultdetail_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_analysisresultdetail_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysisresultdetail_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_analysisresultdetail_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysisresultdetail_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("msdyn_analysisresultdetail_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> msdyn_analysisresultdetail_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (msdyn_analysisresultdetail_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysisresultdetail_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (msdyn_analysisresultdetail_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysisresultdetail_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("msdyn_analysisresultdetail_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> msdyn_analysisresultdetail_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (msdyn_analysisresultdetail_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysisresultdetail_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (msdyn_analysisresultdetail_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysisresultdetail_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("msdyn_analysisresultdetail_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> msdyn_analysisresultdetail_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_analysisresultdetail_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysisresultdetail_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_analysisresultdetail_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysisresultdetail_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("msdyn_analysisresultdetail_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> msdyn_analysisresultdetail_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_analysisresultdetail_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysisresultdetail_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_analysisresultdetail_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysisresultdetail_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("msdyn_analysisresultdetail_ProcessSession")]
    public IEnumerable<ProcessSession> msdyn_analysisresultdetail_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (msdyn_analysisresultdetail_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysisresultdetail_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (msdyn_analysisresultdetail_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysisresultdetail_ProcessSession));
      }
    }

    [RelationshipSchemaName("msdyn_analysisresultdetail_SyncErrors")]
    public IEnumerable<SyncError> msdyn_analysisresultdetail_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (msdyn_analysisresultdetail_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysisresultdetail_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (msdyn_analysisresultdetail_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysisresultdetail_SyncErrors));
      }
    }

    [RelationshipSchemaName("msdyn_analysisresultdetail_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> msdyn_analysisresultdetail_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_analysisresultdetail_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysisresultdetail_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_analysisresultdetail_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysisresultdetail_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_msdyn_analysisresultdetail")]
    public BusinessUnit business_unit_msdyn_analysisresultdetail
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_msdyn_analysisresultdetail), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_msdyn_analysisresultdetail_createdby")]
    public SystemUser lk_msdyn_analysisresultdetail_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_analysisresultdetail_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_analysisresultdetail_createdonbehalfby")]
    public SystemUser lk_msdyn_analysisresultdetail_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_analysisresultdetail_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_analysisresultdetail_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_analysisresultdetail_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_analysisresultdetail_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_msdyn_analysisresultdetail_modifiedby")]
    public SystemUser lk_msdyn_analysisresultdetail_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_analysisresultdetail_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_analysisresultdetail_modifiedonbehalfby")]
    public SystemUser lk_msdyn_analysisresultdetail_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_analysisresultdetail_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_analysisresultdetail_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_analysisresultdetail_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_analysisresultdetail_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("msdyn_analysisresult")]
    [RelationshipSchemaName("msdyn_msdyn_analysisresult_msdyn_analysisresultdetail_AnalysisResult")]
    public msdyn_analysisresult msdyn_msdyn_analysisresult_msdyn_analysisresultdetail_AnalysisResult
    {
      get
      {
        return this.GetRelatedEntity<msdyn_analysisresult>(nameof (msdyn_msdyn_analysisresult_msdyn_analysisresultdetail_AnalysisResult), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_msdyn_analysisresult_msdyn_analysisresultdetail_AnalysisResult));
        this.SetRelatedEntity<msdyn_analysisresult>(nameof (msdyn_msdyn_analysisresult_msdyn_analysisresultdetail_AnalysisResult), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_msdyn_analysisresult_msdyn_analysisresultdetail_AnalysisResult));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_msdyn_analysisresultdetail")]
    public Team team_msdyn_analysisresultdetail
    {
      get
      {
        return this.GetRelatedEntity<Team>(nameof (team_msdyn_analysisresultdetail), new EntityRole?());
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_msdyn_analysisresultdetail")]
    public SystemUser user_msdyn_analysisresultdetail
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_msdyn_analysisresultdetail), new EntityRole?());
      }
    }

    public msdyn_analysisresultdetail(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["msdyn_analysisresultdetailid"] = (object) base.Id;
            break;
          case "msdyn_analysisresultdetailid":
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
