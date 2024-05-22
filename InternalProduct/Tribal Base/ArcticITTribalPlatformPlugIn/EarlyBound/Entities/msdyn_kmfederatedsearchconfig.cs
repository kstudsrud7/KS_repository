// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.msdyn_kmfederatedsearchconfig
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("msdyn_kmfederatedsearchconfig")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class msdyn_kmfederatedsearchconfig : 
    Entity,
    INotifyPropertyChanging,
    INotifyPropertyChanged
  {
    public const string EntityLogicalName = "msdyn_kmfederatedsearchconfig";
    public const string EntitySchemaName = "msdyn_kmfederatedsearchconfig";
    public const string PrimaryIdAttribute = "msdyn_kmfederatedsearchconfigid";
    public const string PrimaryNameAttribute = "msdyn_name";

    public msdyn_kmfederatedsearchconfig()
      : base(nameof (msdyn_kmfederatedsearchconfig))
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

    [AttributeLogicalName("connectionid")]
    public string ConnectionId
    {
      get => this.GetAttributeValue<string>("connectionid");
      set
      {
        this.OnPropertyChanging(nameof (ConnectionId));
        this.SetAttributeValue("connectionid", (object) value);
        this.OnPropertyChanged(nameof (ConnectionId));
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

    [AttributeLogicalName("isdefault")]
    public bool? IsDefault
    {
      get => this.GetAttributeValue<bool?>("isdefault");
      set
      {
        this.OnPropertyChanging(nameof (IsDefault));
        this.SetAttributeValue("isdefault", (object) value);
        this.OnPropertyChanged(nameof (IsDefault));
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

    [AttributeLogicalName("msdyn_description")]
    public string msdyn_Description
    {
      get => this.GetAttributeValue<string>("msdyn_description");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_Description));
        this.SetAttributeValue("msdyn_description", (object) value);
        this.OnPropertyChanged(nameof (msdyn_Description));
      }
    }

    [AttributeLogicalName("msdyn_kmfederatedsearchconfigid")]
    public Guid? msdyn_kmfederatedsearchconfigId
    {
      get => this.GetAttributeValue<Guid?>("msdyn_kmfederatedsearchconfigid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_kmfederatedsearchconfigId));
        this.SetAttributeValue("msdyn_kmfederatedsearchconfigid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (msdyn_kmfederatedsearchconfigId));
      }
    }

    [AttributeLogicalName("msdyn_kmfederatedsearchconfigid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.msdyn_kmfederatedsearchconfigId = new Guid?(value);
    }

    [AttributeLogicalName("msdyn_name")]
    public string msdyn_Name
    {
      get => this.GetAttributeValue<string>("msdyn_name");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_Name));
        this.SetAttributeValue("msdyn_name", (object) value);
        this.OnPropertyChanged(nameof (msdyn_Name));
      }
    }

    [AttributeLogicalName("organization")]
    public string Organization
    {
      get => this.GetAttributeValue<string>("organization");
      set
      {
        this.OnPropertyChanging(nameof (Organization));
        this.SetAttributeValue("organization", (object) value);
        this.OnPropertyChanged(nameof (Organization));
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

    [AttributeLogicalName("searchtype")]
    public OptionSetValue SearchType
    {
      get => this.GetAttributeValue<OptionSetValue>("searchtype");
      set
      {
        this.OnPropertyChanging(nameof (SearchType));
        this.SetAttributeValue("searchtype", (object) value);
        this.OnPropertyChanged(nameof (SearchType));
      }
    }

    [AttributeLogicalName("sharepointurl")]
    public string SharepointURL
    {
      get => this.GetAttributeValue<string>("sharepointurl");
      set
      {
        this.OnPropertyChanging(nameof (SharepointURL));
        this.SetAttributeValue("sharepointurl", (object) value);
        this.OnPropertyChanged(nameof (SharepointURL));
      }
    }

    [AttributeLogicalName("statecode")]
    public msdyn_kmfederatedsearchconfigState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new msdyn_kmfederatedsearchconfigState?((msdyn_kmfederatedsearchconfigState) Enum.ToObject(typeof (msdyn_kmfederatedsearchconfigState), attributeValue.Value)) : new msdyn_kmfederatedsearchconfigState?();
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

    [RelationshipSchemaName("IK_msdyn_kmfederatedsearchconfig_msdyn_federatedarticle_searchproviderid")]
    public IEnumerable<msdyn_federatedarticle> IK_msdyn_kmfederatedsearchconfig_msdyn_federatedarticle_searchproviderid
    {
      get
      {
        return this.GetRelatedEntities<msdyn_federatedarticle>(nameof (IK_msdyn_kmfederatedsearchconfig_msdyn_federatedarticle_searchproviderid), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (IK_msdyn_kmfederatedsearchconfig_msdyn_federatedarticle_searchproviderid));
        this.SetRelatedEntities<msdyn_federatedarticle>(nameof (IK_msdyn_kmfederatedsearchconfig_msdyn_federatedarticle_searchproviderid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (IK_msdyn_kmfederatedsearchconfig_msdyn_federatedarticle_searchproviderid));
      }
    }

    [RelationshipSchemaName("msdyn_kmfederatedsearchconfig_AsyncOperations")]
    public IEnumerable<AsyncOperation> msdyn_kmfederatedsearchconfig_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (msdyn_kmfederatedsearchconfig_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_kmfederatedsearchconfig_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (msdyn_kmfederatedsearchconfig_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_kmfederatedsearchconfig_AsyncOperations));
      }
    }

    [RelationshipSchemaName("msdyn_kmfederatedsearchconfig_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> msdyn_kmfederatedsearchconfig_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_kmfederatedsearchconfig_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_kmfederatedsearchconfig_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_kmfederatedsearchconfig_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_kmfederatedsearchconfig_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("msdyn_kmfederatedsearchconfig_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> msdyn_kmfederatedsearchconfig_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (msdyn_kmfederatedsearchconfig_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_kmfederatedsearchconfig_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (msdyn_kmfederatedsearchconfig_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_kmfederatedsearchconfig_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("msdyn_kmfederatedsearchconfig_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> msdyn_kmfederatedsearchconfig_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (msdyn_kmfederatedsearchconfig_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_kmfederatedsearchconfig_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (msdyn_kmfederatedsearchconfig_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_kmfederatedsearchconfig_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("msdyn_kmfederatedsearchconfig_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> msdyn_kmfederatedsearchconfig_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_kmfederatedsearchconfig_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_kmfederatedsearchconfig_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_kmfederatedsearchconfig_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_kmfederatedsearchconfig_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("msdyn_kmfederatedsearchconfig_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> msdyn_kmfederatedsearchconfig_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_kmfederatedsearchconfig_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_kmfederatedsearchconfig_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_kmfederatedsearchconfig_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_kmfederatedsearchconfig_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("msdyn_kmfederatedsearchconfig_ProcessSession")]
    public IEnumerable<ProcessSession> msdyn_kmfederatedsearchconfig_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (msdyn_kmfederatedsearchconfig_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_kmfederatedsearchconfig_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (msdyn_kmfederatedsearchconfig_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_kmfederatedsearchconfig_ProcessSession));
      }
    }

    [RelationshipSchemaName("msdyn_kmfederatedsearchconfig_SyncErrors")]
    public IEnumerable<SyncError> msdyn_kmfederatedsearchconfig_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (msdyn_kmfederatedsearchconfig_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_kmfederatedsearchconfig_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (msdyn_kmfederatedsearchconfig_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_kmfederatedsearchconfig_SyncErrors));
      }
    }

    [RelationshipSchemaName("msdyn_kmfederatedsearchconfig_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> msdyn_kmfederatedsearchconfig_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_kmfederatedsearchconfig_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_kmfederatedsearchconfig_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_kmfederatedsearchconfig_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_kmfederatedsearchconfig_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_msdyn_kmfederatedsearchconfig")]
    public BusinessUnit business_unit_msdyn_kmfederatedsearchconfig
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_msdyn_kmfederatedsearchconfig), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_msdyn_kmfederatedsearchconfig_createdby")]
    public SystemUser lk_msdyn_kmfederatedsearchconfig_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_kmfederatedsearchconfig_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_kmfederatedsearchconfig_createdonbehalfby")]
    public SystemUser lk_msdyn_kmfederatedsearchconfig_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_kmfederatedsearchconfig_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_kmfederatedsearchconfig_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_kmfederatedsearchconfig_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_kmfederatedsearchconfig_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_msdyn_kmfederatedsearchconfig_modifiedby")]
    public SystemUser lk_msdyn_kmfederatedsearchconfig_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_kmfederatedsearchconfig_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_kmfederatedsearchconfig_modifiedonbehalfby")]
    public SystemUser lk_msdyn_kmfederatedsearchconfig_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_kmfederatedsearchconfig_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_kmfederatedsearchconfig_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_kmfederatedsearchconfig_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_kmfederatedsearchconfig_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_msdyn_kmfederatedsearchconfig")]
    public Team team_msdyn_kmfederatedsearchconfig
    {
      get
      {
        return this.GetRelatedEntity<Team>(nameof (team_msdyn_kmfederatedsearchconfig), new EntityRole?());
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_msdyn_kmfederatedsearchconfig")]
    public SystemUser user_msdyn_kmfederatedsearchconfig
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_msdyn_kmfederatedsearchconfig), new EntityRole?());
      }
    }

    public msdyn_kmfederatedsearchconfig(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["msdyn_kmfederatedsearchconfigid"] = (object) base.Id;
            break;
          case "msdyn_kmfederatedsearchconfigid":
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
