// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.msdyn_federatedarticle
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("msdyn_federatedarticle")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class msdyn_federatedarticle : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "msdyn_federatedarticle";
    public const string EntitySchemaName = "msdyn_federatedarticle";
    public const string PrimaryIdAttribute = "msdyn_federatedarticleid";
    public const string PrimaryNameAttribute = "msdyn_title";

    public msdyn_federatedarticle()
      : base(nameof (msdyn_federatedarticle))
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

    [AttributeLogicalName("msdyn_federatedarticleid")]
    public Guid? msdyn_federatedarticleId
    {
      get => this.GetAttributeValue<Guid?>("msdyn_federatedarticleid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_federatedarticleId));
        this.SetAttributeValue("msdyn_federatedarticleid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (msdyn_federatedarticleId));
      }
    }

    [AttributeLogicalName("msdyn_federatedarticleid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.msdyn_federatedarticleId = new Guid?(value);
    }

    [AttributeLogicalName("msdyn_searchproviderarticleid")]
    public string msdyn_searchproviderarticleid
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_searchproviderarticleid));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_searchproviderarticleid));
        this.SetAttributeValue(nameof (msdyn_searchproviderarticleid), (object) value);
        this.OnPropertyChanged(nameof (msdyn_searchproviderarticleid));
      }
    }

    [AttributeLogicalName("msdyn_searchproviderid")]
    public EntityReference msdyn_searchproviderid
    {
      get => this.GetAttributeValue<EntityReference>(nameof (msdyn_searchproviderid));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_searchproviderid));
        this.SetAttributeValue(nameof (msdyn_searchproviderid), (object) value);
        this.OnPropertyChanged(nameof (msdyn_searchproviderid));
      }
    }

    [AttributeLogicalName("msdyn_title")]
    public string msdyn_title
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_title));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_title));
        this.SetAttributeValue(nameof (msdyn_title), (object) value);
        this.OnPropertyChanged(nameof (msdyn_title));
      }
    }

    [AttributeLogicalName("msdyn_url")]
    public string msdyn_url
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_url));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_url));
        this.SetAttributeValue(nameof (msdyn_url), (object) value);
        this.OnPropertyChanged(nameof (msdyn_url));
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
    public msdyn_federatedarticleState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new msdyn_federatedarticleState?((msdyn_federatedarticleState) Enum.ToObject(typeof (msdyn_federatedarticleState), attributeValue.Value)) : new msdyn_federatedarticleState?();
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

    [RelationshipSchemaName("msdyn_federatedarticle_AsyncOperations")]
    public IEnumerable<AsyncOperation> msdyn_federatedarticle_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (msdyn_federatedarticle_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_federatedarticle_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (msdyn_federatedarticle_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_federatedarticle_AsyncOperations));
      }
    }

    [RelationshipSchemaName("msdyn_federatedarticle_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> msdyn_federatedarticle_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_federatedarticle_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_federatedarticle_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_federatedarticle_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_federatedarticle_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("msdyn_federatedarticle_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> msdyn_federatedarticle_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (msdyn_federatedarticle_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_federatedarticle_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (msdyn_federatedarticle_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_federatedarticle_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("msdyn_federatedarticle_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> msdyn_federatedarticle_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (msdyn_federatedarticle_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_federatedarticle_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (msdyn_federatedarticle_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_federatedarticle_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("msdyn_federatedarticle_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> msdyn_federatedarticle_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_federatedarticle_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_federatedarticle_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_federatedarticle_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_federatedarticle_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("msdyn_federatedarticle_msdyn_federatedarticleincident_federatedarticleId")]
    public IEnumerable<msdyn_federatedarticleincident> msdyn_federatedarticle_msdyn_federatedarticleincident_federatedarticleId
    {
      get
      {
        return this.GetRelatedEntities<msdyn_federatedarticleincident>(nameof (msdyn_federatedarticle_msdyn_federatedarticleincident_federatedarticleId), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_federatedarticle_msdyn_federatedarticleincident_federatedarticleId));
        this.SetRelatedEntities<msdyn_federatedarticleincident>(nameof (msdyn_federatedarticle_msdyn_federatedarticleincident_federatedarticleId), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_federatedarticle_msdyn_federatedarticleincident_federatedarticleId));
      }
    }

    [RelationshipSchemaName("msdyn_federatedarticle_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> msdyn_federatedarticle_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_federatedarticle_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_federatedarticle_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_federatedarticle_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_federatedarticle_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("msdyn_federatedarticle_ProcessSession")]
    public IEnumerable<ProcessSession> msdyn_federatedarticle_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (msdyn_federatedarticle_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_federatedarticle_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (msdyn_federatedarticle_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_federatedarticle_ProcessSession));
      }
    }

    [RelationshipSchemaName("msdyn_federatedarticle_SyncErrors")]
    public IEnumerable<SyncError> msdyn_federatedarticle_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (msdyn_federatedarticle_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_federatedarticle_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (msdyn_federatedarticle_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_federatedarticle_SyncErrors));
      }
    }

    [RelationshipSchemaName("msdyn_federatedarticle_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> msdyn_federatedarticle_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_federatedarticle_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_federatedarticle_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_federatedarticle_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_federatedarticle_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_msdyn_federatedarticle")]
    public BusinessUnit business_unit_msdyn_federatedarticle
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_msdyn_federatedarticle), new EntityRole?());
      }
    }

    [AttributeLogicalName("msdyn_searchproviderid")]
    [RelationshipSchemaName("IK_msdyn_kmfederatedsearchconfig_msdyn_federatedarticle_searchproviderid")]
    public msdyn_kmfederatedsearchconfig IK_msdyn_kmfederatedsearchconfig_msdyn_federatedarticle_searchproviderid
    {
      get
      {
        return this.GetRelatedEntity<msdyn_kmfederatedsearchconfig>(nameof (IK_msdyn_kmfederatedsearchconfig_msdyn_federatedarticle_searchproviderid), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (IK_msdyn_kmfederatedsearchconfig_msdyn_federatedarticle_searchproviderid));
        this.SetRelatedEntity<msdyn_kmfederatedsearchconfig>(nameof (IK_msdyn_kmfederatedsearchconfig_msdyn_federatedarticle_searchproviderid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (IK_msdyn_kmfederatedsearchconfig_msdyn_federatedarticle_searchproviderid));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_msdyn_federatedarticle_createdby")]
    public SystemUser lk_msdyn_federatedarticle_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_federatedarticle_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_federatedarticle_createdonbehalfby")]
    public SystemUser lk_msdyn_federatedarticle_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_federatedarticle_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_federatedarticle_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_federatedarticle_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_federatedarticle_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_msdyn_federatedarticle_modifiedby")]
    public SystemUser lk_msdyn_federatedarticle_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_federatedarticle_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_federatedarticle_modifiedonbehalfby")]
    public SystemUser lk_msdyn_federatedarticle_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_federatedarticle_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_federatedarticle_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_federatedarticle_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_federatedarticle_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_msdyn_federatedarticle")]
    public Team team_msdyn_federatedarticle
    {
      get => this.GetRelatedEntity<Team>(nameof (team_msdyn_federatedarticle), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_msdyn_federatedarticle")]
    public SystemUser user_msdyn_federatedarticle
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_msdyn_federatedarticle), new EntityRole?());
      }
    }

    public msdyn_federatedarticle(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["msdyn_federatedarticleid"] = (object) base.Id;
            break;
          case "msdyn_federatedarticleid":
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
