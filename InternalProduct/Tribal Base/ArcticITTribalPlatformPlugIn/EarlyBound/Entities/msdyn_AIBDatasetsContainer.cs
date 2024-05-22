// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.msdyn_AIBDatasetsContainer
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("msdyn_aibdatasetscontainer")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class msdyn_AIBDatasetsContainer : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "msdyn_aibdatasetscontainer";
    public const string EntitySchemaName = "msdyn_AIBDatasetsContainer";
    public const string PrimaryIdAttribute = "msdyn_aibdatasetscontainerid";
    public const string PrimaryNameAttribute = "msdyn_name";

    public msdyn_AIBDatasetsContainer()
      : base("msdyn_aibdatasetscontainer")
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

    [AttributeLogicalName("msdyn_aibdatasetscontainerid")]
    public Guid? msdyn_AIBDatasetsContainerId
    {
      get => this.GetAttributeValue<Guid?>("msdyn_aibdatasetscontainerid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_AIBDatasetsContainerId));
        this.SetAttributeValue("msdyn_aibdatasetscontainerid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (msdyn_AIBDatasetsContainerId));
      }
    }

    [AttributeLogicalName("msdyn_aibdatasetscontainerid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.msdyn_AIBDatasetsContainerId = new Guid?(value);
    }

    [AttributeLogicalName("msdyn_aimodelid")]
    public EntityReference msdyn_AIModelId
    {
      get => this.GetAttributeValue<EntityReference>("msdyn_aimodelid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_AIModelId));
        this.SetAttributeValue("msdyn_aimodelid", (object) value);
        this.OnPropertyChanged(nameof (msdyn_AIModelId));
      }
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
    public msdyn_AIBDatasetsContainerState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new msdyn_AIBDatasetsContainerState?((msdyn_AIBDatasetsContainerState) Enum.ToObject(typeof (msdyn_AIBDatasetsContainerState), attributeValue.Value)) : new msdyn_AIBDatasetsContainerState?();
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

    [RelationshipSchemaName("msdyn_AIBDataset_msdyn_AIBDatasetsContain")]
    public IEnumerable<msdyn_AIBDataset> msdyn_AIBDataset_msdyn_AIBDatasetsContain
    {
      get
      {
        return this.GetRelatedEntities<msdyn_AIBDataset>(nameof (msdyn_AIBDataset_msdyn_AIBDatasetsContain), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_AIBDataset_msdyn_AIBDatasetsContain));
        this.SetRelatedEntities<msdyn_AIBDataset>(nameof (msdyn_AIBDataset_msdyn_AIBDatasetsContain), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_AIBDataset_msdyn_AIBDatasetsContain));
      }
    }

    [RelationshipSchemaName("msdyn_aibdatasetscontainer_AsyncOperations")]
    public IEnumerable<AsyncOperation> msdyn_aibdatasetscontainer_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (msdyn_aibdatasetscontainer_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibdatasetscontainer_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (msdyn_aibdatasetscontainer_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibdatasetscontainer_AsyncOperations));
      }
    }

    [RelationshipSchemaName("msdyn_aibdatasetscontainer_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> msdyn_aibdatasetscontainer_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_aibdatasetscontainer_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibdatasetscontainer_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_aibdatasetscontainer_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibdatasetscontainer_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("msdyn_aibdatasetscontainer_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> msdyn_aibdatasetscontainer_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (msdyn_aibdatasetscontainer_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibdatasetscontainer_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (msdyn_aibdatasetscontainer_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibdatasetscontainer_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("msdyn_aibdatasetscontainer_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> msdyn_aibdatasetscontainer_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (msdyn_aibdatasetscontainer_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibdatasetscontainer_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (msdyn_aibdatasetscontainer_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibdatasetscontainer_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("msdyn_aibdatasetscontainer_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> msdyn_aibdatasetscontainer_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_aibdatasetscontainer_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibdatasetscontainer_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_aibdatasetscontainer_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibdatasetscontainer_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("msdyn_aibdatasetscontainer_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> msdyn_aibdatasetscontainer_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_aibdatasetscontainer_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibdatasetscontainer_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_aibdatasetscontainer_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibdatasetscontainer_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("msdyn_aibdatasetscontainer_ProcessSession")]
    public IEnumerable<ProcessSession> msdyn_aibdatasetscontainer_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (msdyn_aibdatasetscontainer_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibdatasetscontainer_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (msdyn_aibdatasetscontainer_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibdatasetscontainer_ProcessSession));
      }
    }

    [RelationshipSchemaName("msdyn_aibdatasetscontainer_SyncErrors")]
    public IEnumerable<SyncError> msdyn_aibdatasetscontainer_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (msdyn_aibdatasetscontainer_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibdatasetscontainer_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (msdyn_aibdatasetscontainer_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibdatasetscontainer_SyncErrors));
      }
    }

    [RelationshipSchemaName("msdyn_aibdatasetscontainer_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> msdyn_aibdatasetscontainer_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_aibdatasetscontainer_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibdatasetscontainer_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_aibdatasetscontainer_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibdatasetscontainer_UserEntityInstanceDatas));
      }
    }

    [RelationshipSchemaName("msdyn_AIBFile_msdyn_AIBDatasetsCont")]
    public IEnumerable<msdyn_AIBFile> msdyn_AIBFile_msdyn_AIBDatasetsCont
    {
      get
      {
        return this.GetRelatedEntities<msdyn_AIBFile>(nameof (msdyn_AIBFile_msdyn_AIBDatasetsCont), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_AIBFile_msdyn_AIBDatasetsCont));
        this.SetRelatedEntities<msdyn_AIBFile>(nameof (msdyn_AIBFile_msdyn_AIBDatasetsCont), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_AIBFile_msdyn_AIBDatasetsCont));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_msdyn_aibdatasetscontainer")]
    public BusinessUnit business_unit_msdyn_aibdatasetscontainer
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_msdyn_aibdatasetscontainer), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_msdyn_aibdatasetscontainer_createdby")]
    public SystemUser lk_msdyn_aibdatasetscontainer_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_aibdatasetscontainer_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_aibdatasetscontainer_createdonbehalfby")]
    public SystemUser lk_msdyn_aibdatasetscontainer_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_aibdatasetscontainer_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_aibdatasetscontainer_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_aibdatasetscontainer_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_aibdatasetscontainer_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_msdyn_aibdatasetscontainer_modifiedby")]
    public SystemUser lk_msdyn_aibdatasetscontainer_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_aibdatasetscontainer_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_aibdatasetscontainer_modifiedonbehalfby")]
    public SystemUser lk_msdyn_aibdatasetscontainer_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_aibdatasetscontainer_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_aibdatasetscontainer_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_aibdatasetscontainer_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_aibdatasetscontainer_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("msdyn_aimodelid")]
    [RelationshipSchemaName("msdyn_AIBDatasetsContainer_msdyn_AIModelI")]
    public msdyn_AIModel msdyn_AIBDatasetsContainer_msdyn_AIModelI
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIModel>(nameof (msdyn_AIBDatasetsContainer_msdyn_AIModelI), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_AIBDatasetsContainer_msdyn_AIModelI));
        this.SetRelatedEntity<msdyn_AIModel>(nameof (msdyn_AIBDatasetsContainer_msdyn_AIModelI), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_AIBDatasetsContainer_msdyn_AIModelI));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_msdyn_aibdatasetscontainer")]
    public Team team_msdyn_aibdatasetscontainer
    {
      get
      {
        return this.GetRelatedEntity<Team>(nameof (team_msdyn_aibdatasetscontainer), new EntityRole?());
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_msdyn_aibdatasetscontainer")]
    public SystemUser user_msdyn_aibdatasetscontainer
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_msdyn_aibdatasetscontainer), new EntityRole?());
      }
    }

    public msdyn_AIBDatasetsContainer(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["msdyn_aibdatasetscontainerid"] = (object) base.Id;
            break;
          case "msdyn_aibdatasetscontainerid":
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
