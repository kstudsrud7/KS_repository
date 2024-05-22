// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.msdyn_AIFpTrainingDocument
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("msdyn_aifptrainingdocument")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class msdyn_AIFpTrainingDocument : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "msdyn_aifptrainingdocument";
    public const string EntitySchemaName = "msdyn_AIFpTrainingDocument";
    public const string PrimaryIdAttribute = "msdyn_aifptrainingdocumentid";
    public const string PrimaryNameAttribute = "msdyn_name";

    public msdyn_AIFpTrainingDocument()
      : base("msdyn_aifptrainingdocument")
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

    [AttributeLogicalName("msdyn_aiconfigurationid")]
    public EntityReference msdyn_AIConfigurationId
    {
      get => this.GetAttributeValue<EntityReference>("msdyn_aiconfigurationid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_AIConfigurationId));
        this.SetAttributeValue("msdyn_aiconfigurationid", (object) value);
        this.OnPropertyChanged(nameof (msdyn_AIConfigurationId));
      }
    }

    [AttributeLogicalName("msdyn_aifptrainingdocumentid")]
    public Guid? msdyn_AIFpTrainingDocumentId
    {
      get => this.GetAttributeValue<Guid?>("msdyn_aifptrainingdocumentid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_AIFpTrainingDocumentId));
        this.SetAttributeValue("msdyn_aifptrainingdocumentid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (msdyn_AIFpTrainingDocumentId));
      }
    }

    [AttributeLogicalName("msdyn_aifptrainingdocumentid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.msdyn_AIFpTrainingDocumentId = new Guid?(value);
    }

    [AttributeLogicalName("msdyn_checksum")]
    public string msdyn_Checksum
    {
      get => this.GetAttributeValue<string>("msdyn_checksum");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_Checksum));
        this.SetAttributeValue("msdyn_checksum", (object) value);
        this.OnPropertyChanged(nameof (msdyn_Checksum));
      }
    }

    [AttributeLogicalName("msdyn_metadata")]
    public string msdyn_Metadata
    {
      get => this.GetAttributeValue<string>("msdyn_metadata");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_Metadata));
        this.SetAttributeValue("msdyn_metadata", (object) value);
        this.OnPropertyChanged(nameof (msdyn_Metadata));
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

    [AttributeLogicalName("msdyn_sourcetype")]
    public string msdyn_SourceType
    {
      get => this.GetAttributeValue<string>("msdyn_sourcetype");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_SourceType));
        this.SetAttributeValue("msdyn_sourcetype", (object) value);
        this.OnPropertyChanged(nameof (msdyn_SourceType));
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
    public msdyn_AIFpTrainingDocumentState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new msdyn_AIFpTrainingDocumentState?((msdyn_AIFpTrainingDocumentState) Enum.ToObject(typeof (msdyn_AIFpTrainingDocumentState), attributeValue.Value)) : new msdyn_AIFpTrainingDocumentState?();
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

    [RelationshipSchemaName("msdyn_aifptrainingdocument_Annotations")]
    public IEnumerable<Annotation> msdyn_aifptrainingdocument_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (msdyn_aifptrainingdocument_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aifptrainingdocument_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (msdyn_aifptrainingdocument_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aifptrainingdocument_Annotations));
      }
    }

    [RelationshipSchemaName("msdyn_aifptrainingdocument_AsyncOperations")]
    public IEnumerable<AsyncOperation> msdyn_aifptrainingdocument_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (msdyn_aifptrainingdocument_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aifptrainingdocument_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (msdyn_aifptrainingdocument_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aifptrainingdocument_AsyncOperations));
      }
    }

    [RelationshipSchemaName("msdyn_aifptrainingdocument_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> msdyn_aifptrainingdocument_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_aifptrainingdocument_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aifptrainingdocument_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_aifptrainingdocument_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aifptrainingdocument_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("msdyn_aifptrainingdocument_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> msdyn_aifptrainingdocument_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_aifptrainingdocument_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aifptrainingdocument_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_aifptrainingdocument_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aifptrainingdocument_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("msdyn_aifptrainingdocument_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> msdyn_aifptrainingdocument_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_aifptrainingdocument_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aifptrainingdocument_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_aifptrainingdocument_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aifptrainingdocument_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("msdyn_aifptrainingdocument_ProcessSession")]
    public IEnumerable<ProcessSession> msdyn_aifptrainingdocument_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (msdyn_aifptrainingdocument_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aifptrainingdocument_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (msdyn_aifptrainingdocument_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aifptrainingdocument_ProcessSession));
      }
    }

    [RelationshipSchemaName("msdyn_aifptrainingdocument_SyncErrors")]
    public IEnumerable<SyncError> msdyn_aifptrainingdocument_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (msdyn_aifptrainingdocument_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aifptrainingdocument_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (msdyn_aifptrainingdocument_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aifptrainingdocument_SyncErrors));
      }
    }

    [RelationshipSchemaName("msdyn_aifptrainingdocument_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> msdyn_aifptrainingdocument_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_aifptrainingdocument_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aifptrainingdocument_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_aifptrainingdocument_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aifptrainingdocument_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_msdyn_aifptrainingdocument")]
    public BusinessUnit business_unit_msdyn_aifptrainingdocument
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_msdyn_aifptrainingdocument), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_msdyn_aifptrainingdocument_createdby")]
    public SystemUser lk_msdyn_aifptrainingdocument_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_aifptrainingdocument_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_aifptrainingdocument_createdonbehalfby")]
    public SystemUser lk_msdyn_aifptrainingdocument_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_aifptrainingdocument_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_aifptrainingdocument_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_aifptrainingdocument_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_aifptrainingdocument_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_msdyn_aifptrainingdocument_modifiedby")]
    public SystemUser lk_msdyn_aifptrainingdocument_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_aifptrainingdocument_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_aifptrainingdocument_modifiedonbehalfby")]
    public SystemUser lk_msdyn_aifptrainingdocument_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_aifptrainingdocument_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_aifptrainingdocument_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_aifptrainingdocument_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_aifptrainingdocument_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("msdyn_aiconfigurationid")]
    [RelationshipSchemaName("msdyn_msdyn_aiconfiguration_msdyn_aifptrainingdocument_AIConfigurationId")]
    public msdyn_AIConfiguration msdyn_msdyn_aiconfiguration_msdyn_aifptrainingdocument_AIConfigurationId
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIConfiguration>(nameof (msdyn_msdyn_aiconfiguration_msdyn_aifptrainingdocument_AIConfigurationId), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_msdyn_aiconfiguration_msdyn_aifptrainingdocument_AIConfigurationId));
        this.SetRelatedEntity<msdyn_AIConfiguration>(nameof (msdyn_msdyn_aiconfiguration_msdyn_aifptrainingdocument_AIConfigurationId), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_msdyn_aiconfiguration_msdyn_aifptrainingdocument_AIConfigurationId));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_msdyn_aifptrainingdocument")]
    public Team team_msdyn_aifptrainingdocument
    {
      get
      {
        return this.GetRelatedEntity<Team>(nameof (team_msdyn_aifptrainingdocument), new EntityRole?());
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_msdyn_aifptrainingdocument")]
    public SystemUser user_msdyn_aifptrainingdocument
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_msdyn_aifptrainingdocument), new EntityRole?());
      }
    }

    public msdyn_AIFpTrainingDocument(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["msdyn_aifptrainingdocumentid"] = (object) base.Id;
            break;
          case "msdyn_aifptrainingdocumentid":
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
