// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.StageSolutionUpload
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("stagesolutionupload")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class StageSolutionUpload : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "stagesolutionupload";
    public const string EntitySchemaName = "StageSolutionUpload";
    public const string PrimaryIdAttribute = "stagesolutionuploadid";
    public const string PrimaryNameAttribute = "name";

    public StageSolutionUpload()
      : base("stagesolutionupload")
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

    [AttributeLogicalName("name")]
    public string name
    {
      get => this.GetAttributeValue<string>(nameof (name));
      set
      {
        this.OnPropertyChanging(nameof (name));
        this.SetAttributeValue(nameof (name), (object) value);
        this.OnPropertyChanged(nameof (name));
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

    [AttributeLogicalName("solutionfilename")]
    public string SolutionFileName
    {
      get => this.GetAttributeValue<string>("solutionfilename");
      set
      {
        this.OnPropertyChanging(nameof (SolutionFileName));
        this.SetAttributeValue("solutionfilename", (object) value);
        this.OnPropertyChanged(nameof (SolutionFileName));
      }
    }

    [AttributeLogicalName("solutionuniquename")]
    public string SolutionUniqueName
    {
      get => this.GetAttributeValue<string>("solutionuniquename");
      set
      {
        this.OnPropertyChanging(nameof (SolutionUniqueName));
        this.SetAttributeValue("solutionuniquename", (object) value);
        this.OnPropertyChanged(nameof (SolutionUniqueName));
      }
    }

    [AttributeLogicalName("stagesolutionuploadid")]
    public Guid? StageSolutionUploadId
    {
      get => this.GetAttributeValue<Guid?>("stagesolutionuploadid");
      set
      {
        this.OnPropertyChanging(nameof (StageSolutionUploadId));
        this.SetAttributeValue("stagesolutionuploadid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (StageSolutionUploadId));
      }
    }

    [AttributeLogicalName("stagesolutionuploadid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.StageSolutionUploadId = new Guid?(value);
    }

    [AttributeLogicalName("statecode")]
    public StageSolutionUploadState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new StageSolutionUploadState?((StageSolutionUploadState) Enum.ToObject(typeof (StageSolutionUploadState), attributeValue.Value)) : new StageSolutionUploadState?();
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

    [RelationshipSchemaName("stagesolutionupload_AsyncOperations")]
    public IEnumerable<AsyncOperation> stagesolutionupload_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (stagesolutionupload_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (stagesolutionupload_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (stagesolutionupload_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (stagesolutionupload_AsyncOperations));
      }
    }

    [RelationshipSchemaName("stagesolutionupload_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> stagesolutionupload_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (stagesolutionupload_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (stagesolutionupload_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (stagesolutionupload_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (stagesolutionupload_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("stagesolutionupload_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> stagesolutionupload_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (stagesolutionupload_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (stagesolutionupload_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (stagesolutionupload_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (stagesolutionupload_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("stagesolutionupload_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> stagesolutionupload_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (stagesolutionupload_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (stagesolutionupload_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (stagesolutionupload_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (stagesolutionupload_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("stagesolutionupload_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> stagesolutionupload_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (stagesolutionupload_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (stagesolutionupload_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (stagesolutionupload_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (stagesolutionupload_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("stagesolutionupload_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> stagesolutionupload_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (stagesolutionupload_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (stagesolutionupload_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (stagesolutionupload_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (stagesolutionupload_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("stagesolutionupload_ProcessSession")]
    public IEnumerable<ProcessSession> stagesolutionupload_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (stagesolutionupload_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (stagesolutionupload_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (stagesolutionupload_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (stagesolutionupload_ProcessSession));
      }
    }

    [RelationshipSchemaName("stagesolutionupload_SyncErrors")]
    public IEnumerable<SyncError> stagesolutionupload_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (stagesolutionupload_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (stagesolutionupload_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (stagesolutionupload_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (stagesolutionupload_SyncErrors));
      }
    }

    [RelationshipSchemaName("stagesolutionupload_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> stagesolutionupload_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (stagesolutionupload_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (stagesolutionupload_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (stagesolutionupload_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (stagesolutionupload_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_stagesolutionupload")]
    public BusinessUnit business_unit_stagesolutionupload
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_stagesolutionupload), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_stagesolutionupload_createdby")]
    public SystemUser lk_stagesolutionupload_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_stagesolutionupload_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_stagesolutionupload_createdonbehalfby")]
    public SystemUser lk_stagesolutionupload_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_stagesolutionupload_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_stagesolutionupload_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_stagesolutionupload_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_stagesolutionupload_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_stagesolutionupload_modifiedby")]
    public SystemUser lk_stagesolutionupload_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_stagesolutionupload_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_stagesolutionupload_modifiedonbehalfby")]
    public SystemUser lk_stagesolutionupload_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_stagesolutionupload_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_stagesolutionupload_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_stagesolutionupload_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_stagesolutionupload_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_stagesolutionupload")]
    public Team team_stagesolutionupload
    {
      get => this.GetRelatedEntity<Team>(nameof (team_stagesolutionupload), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_stagesolutionupload")]
    public SystemUser user_stagesolutionupload
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_stagesolutionupload), new EntityRole?());
      }
    }

    public StageSolutionUpload(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["stagesolutionuploadid"] = (object) base.Id;
            break;
          case "stagesolutionuploadid":
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
