// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ExportSolutionUpload
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("exportsolutionupload")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ExportSolutionUpload : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "exportsolutionupload";
    public const string EntitySchemaName = "ExportSolutionUpload";
    public const string PrimaryIdAttribute = "exportsolutionuploadid";
    public const string PrimaryNameAttribute = "name";

    public ExportSolutionUpload()
      : base("exportsolutionupload")
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

    [AttributeLogicalName("asyncoperationid")]
    public EntityReference AsyncOperationId
    {
      get => this.GetAttributeValue<EntityReference>("asyncoperationid");
      set
      {
        this.OnPropertyChanging(nameof (AsyncOperationId));
        this.SetAttributeValue("asyncoperationid", (object) value);
        this.OnPropertyChanged(nameof (AsyncOperationId));
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

    [AttributeLogicalName("exportsolutionuploadid")]
    public Guid? ExportSolutionUploadId
    {
      get => this.GetAttributeValue<Guid?>("exportsolutionuploadid");
      set
      {
        this.OnPropertyChanging(nameof (ExportSolutionUploadId));
        this.SetAttributeValue("exportsolutionuploadid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ExportSolutionUploadId));
      }
    }

    [AttributeLogicalName("exportsolutionuploadid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ExportSolutionUploadId = new Guid?(value);
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

    [AttributeLogicalName("statecode")]
    public ExportSolutionUploadState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ExportSolutionUploadState?((ExportSolutionUploadState) Enum.ToObject(typeof (ExportSolutionUploadState), attributeValue.Value)) : new ExportSolutionUploadState?();
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

    [RelationshipSchemaName("exportsolutionupload_AsyncOperations")]
    public IEnumerable<AsyncOperation> exportsolutionupload_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (exportsolutionupload_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (exportsolutionupload_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (exportsolutionupload_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (exportsolutionupload_AsyncOperations));
      }
    }

    [RelationshipSchemaName("exportsolutionupload_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> exportsolutionupload_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (exportsolutionupload_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (exportsolutionupload_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (exportsolutionupload_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (exportsolutionupload_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("exportsolutionupload_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> exportsolutionupload_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (exportsolutionupload_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (exportsolutionupload_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (exportsolutionupload_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (exportsolutionupload_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("exportsolutionupload_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> exportsolutionupload_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (exportsolutionupload_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (exportsolutionupload_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (exportsolutionupload_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (exportsolutionupload_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("exportsolutionupload_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> exportsolutionupload_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (exportsolutionupload_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (exportsolutionupload_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (exportsolutionupload_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (exportsolutionupload_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("exportsolutionupload_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> exportsolutionupload_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (exportsolutionupload_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (exportsolutionupload_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (exportsolutionupload_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (exportsolutionupload_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("exportsolutionupload_ProcessSession")]
    public IEnumerable<ProcessSession> exportsolutionupload_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (exportsolutionupload_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (exportsolutionupload_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (exportsolutionupload_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (exportsolutionupload_ProcessSession));
      }
    }

    [RelationshipSchemaName("exportsolutionupload_SyncErrors")]
    public IEnumerable<SyncError> exportsolutionupload_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (exportsolutionupload_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (exportsolutionupload_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (exportsolutionupload_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (exportsolutionupload_SyncErrors));
      }
    }

    [RelationshipSchemaName("exportsolutionupload_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> exportsolutionupload_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (exportsolutionupload_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (exportsolutionupload_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (exportsolutionupload_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (exportsolutionupload_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_exportsolutionupload")]
    public BusinessUnit business_unit_exportsolutionupload
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_exportsolutionupload), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_exportsolutionupload_createdby")]
    public SystemUser lk_exportsolutionupload_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_exportsolutionupload_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_exportsolutionupload_createdonbehalfby")]
    public SystemUser lk_exportsolutionupload_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_exportsolutionupload_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_exportsolutionupload_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_exportsolutionupload_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_exportsolutionupload_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_exportsolutionupload_modifiedby")]
    public SystemUser lk_exportsolutionupload_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_exportsolutionupload_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_exportsolutionupload_modifiedonbehalfby")]
    public SystemUser lk_exportsolutionupload_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_exportsolutionupload_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_exportsolutionupload_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_exportsolutionupload_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_exportsolutionupload_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_exportsolutionupload")]
    public Team team_exportsolutionupload
    {
      get => this.GetRelatedEntity<Team>(nameof (team_exportsolutionupload), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_exportsolutionupload")]
    public SystemUser user_exportsolutionupload
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_exportsolutionupload), new EntityRole?());
      }
    }

    public ExportSolutionUpload(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["exportsolutionuploadid"] = (object) base.Id;
            break;
          case "exportsolutionuploadid":
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
