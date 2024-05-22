// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.datalakeworkspacepermission
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("datalakeworkspacepermission")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class datalakeworkspacepermission : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "datalakeworkspacepermission";
    public const string EntitySchemaName = "datalakeworkspacepermission";
    public const string PrimaryIdAttribute = "datalakeworkspacepermissionid";
    public const string PrimaryNameAttribute = "name";

    public datalakeworkspacepermission()
      : base(nameof (datalakeworkspacepermission))
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

    [AttributeLogicalName("appid")]
    public Guid? appid
    {
      get => this.GetAttributeValue<Guid?>(nameof (appid));
      set
      {
        this.OnPropertyChanging(nameof (appid));
        this.SetAttributeValue(nameof (appid), (object) value);
        this.OnPropertyChanged(nameof (appid));
      }
    }

    [AttributeLogicalName("canexecute")]
    public bool? canexecute
    {
      get => this.GetAttributeValue<bool?>(nameof (canexecute));
      set
      {
        this.OnPropertyChanging(nameof (canexecute));
        this.SetAttributeValue(nameof (canexecute), (object) value);
        this.OnPropertyChanged(nameof (canexecute));
      }
    }

    [AttributeLogicalName("canread")]
    public bool? canread
    {
      get => this.GetAttributeValue<bool?>(nameof (canread));
      set
      {
        this.OnPropertyChanging(nameof (canread));
        this.SetAttributeValue(nameof (canread), (object) value);
        this.OnPropertyChanged(nameof (canread));
      }
    }

    [AttributeLogicalName("canwrite")]
    public bool? canwrite
    {
      get => this.GetAttributeValue<bool?>(nameof (canwrite));
      set
      {
        this.OnPropertyChanging(nameof (canwrite));
        this.SetAttributeValue(nameof (canwrite), (object) value);
        this.OnPropertyChanged(nameof (canwrite));
      }
    }

    [AttributeLogicalName("componentidunique")]
    public Guid? ComponentIdUnique => this.GetAttributeValue<Guid?>("componentidunique");

    [AttributeLogicalName("componentstate")]
    public OptionSetValue ComponentState
    {
      get => this.GetAttributeValue<OptionSetValue>("componentstate");
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

    [AttributeLogicalName("datalakeworkspacepermission_uniquename")]
    public string datalakeworkspacepermission_UniqueName
    {
      get => this.GetAttributeValue<string>("datalakeworkspacepermission_uniquename");
      set
      {
        this.OnPropertyChanging(nameof (datalakeworkspacepermission_UniqueName));
        this.SetAttributeValue("datalakeworkspacepermission_uniquename", (object) value);
        this.OnPropertyChanged(nameof (datalakeworkspacepermission_UniqueName));
      }
    }

    [AttributeLogicalName("datalakeworkspacepermissionid")]
    public Guid? datalakeworkspacepermissionId
    {
      get => this.GetAttributeValue<Guid?>("datalakeworkspacepermissionid");
      set
      {
        this.OnPropertyChanging(nameof (datalakeworkspacepermissionId));
        this.SetAttributeValue("datalakeworkspacepermissionid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (datalakeworkspacepermissionId));
      }
    }

    [AttributeLogicalName("datalakeworkspacepermissionid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.datalakeworkspacepermissionId = new Guid?(value);
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

    [AttributeLogicalName("iscustomizable")]
    public BooleanManagedProperty IsCustomizable
    {
      get => this.GetAttributeValue<BooleanManagedProperty>("iscustomizable");
      set
      {
        this.OnPropertyChanging(nameof (IsCustomizable));
        this.SetAttributeValue("iscustomizable", (object) value);
        this.OnPropertyChanged(nameof (IsCustomizable));
      }
    }

    [AttributeLogicalName("ismanaged")]
    public bool? IsManaged => this.GetAttributeValue<bool?>("ismanaged");

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

    [AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get => this.GetAttributeValue<EntityReference>("organizationid");
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

    [AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime => this.GetAttributeValue<DateTime?>("overwritetime");

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("statecode")]
    public datalakeworkspacepermissionState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new datalakeworkspacepermissionState?((datalakeworkspacepermissionState) Enum.ToObject(typeof (datalakeworkspacepermissionState), attributeValue.Value)) : new datalakeworkspacepermissionState?();
      }
    }

    [AttributeLogicalName("statuscode")]
    public OptionSetValue StatusCode => this.GetAttributeValue<OptionSetValue>("statuscode");

    [AttributeLogicalName("tenantid")]
    public Guid? tenantid
    {
      get => this.GetAttributeValue<Guid?>(nameof (tenantid));
      set
      {
        this.OnPropertyChanging(nameof (tenantid));
        this.SetAttributeValue(nameof (tenantid), (object) value);
        this.OnPropertyChanged(nameof (tenantid));
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

    [AttributeLogicalName("whitelistedappid")]
    public Guid? whitelistedappid
    {
      get => this.GetAttributeValue<Guid?>(nameof (whitelistedappid));
      set
      {
        this.OnPropertyChanging(nameof (whitelistedappid));
        this.SetAttributeValue(nameof (whitelistedappid), (object) value);
        this.OnPropertyChanged(nameof (whitelistedappid));
      }
    }

    [AttributeLogicalName("workspaceid")]
    public EntityReference workspaceid
    {
      get => this.GetAttributeValue<EntityReference>(nameof (workspaceid));
      set
      {
        this.OnPropertyChanging(nameof (workspaceid));
        this.SetAttributeValue(nameof (workspaceid), (object) value);
        this.OnPropertyChanged(nameof (workspaceid));
      }
    }

    [RelationshipSchemaName("datalakeworkspacepermission_AsyncOperations")]
    public IEnumerable<AsyncOperation> datalakeworkspacepermission_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (datalakeworkspacepermission_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakeworkspacepermission_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (datalakeworkspacepermission_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakeworkspacepermission_AsyncOperations));
      }
    }

    [RelationshipSchemaName("datalakeworkspacepermission_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> datalakeworkspacepermission_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (datalakeworkspacepermission_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakeworkspacepermission_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (datalakeworkspacepermission_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakeworkspacepermission_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("datalakeworkspacepermission_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> datalakeworkspacepermission_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (datalakeworkspacepermission_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakeworkspacepermission_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (datalakeworkspacepermission_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakeworkspacepermission_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("datalakeworkspacepermission_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> datalakeworkspacepermission_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (datalakeworkspacepermission_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakeworkspacepermission_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (datalakeworkspacepermission_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakeworkspacepermission_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("datalakeworkspacepermission_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> datalakeworkspacepermission_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (datalakeworkspacepermission_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakeworkspacepermission_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (datalakeworkspacepermission_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakeworkspacepermission_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("datalakeworkspacepermission_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> datalakeworkspacepermission_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (datalakeworkspacepermission_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakeworkspacepermission_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (datalakeworkspacepermission_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakeworkspacepermission_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("datalakeworkspacepermission_ProcessSession")]
    public IEnumerable<ProcessSession> datalakeworkspacepermission_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (datalakeworkspacepermission_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakeworkspacepermission_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (datalakeworkspacepermission_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakeworkspacepermission_ProcessSession));
      }
    }

    [RelationshipSchemaName("datalakeworkspacepermission_SyncErrors")]
    public IEnumerable<SyncError> datalakeworkspacepermission_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (datalakeworkspacepermission_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakeworkspacepermission_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (datalakeworkspacepermission_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakeworkspacepermission_SyncErrors));
      }
    }

    [RelationshipSchemaName("datalakeworkspacepermission_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> datalakeworkspacepermission_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (datalakeworkspacepermission_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakeworkspacepermission_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (datalakeworkspacepermission_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakeworkspacepermission_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("workspaceid")]
    [RelationshipSchemaName("datalakeworkspace_workspacepermission")]
    public datalakeworkspace datalakeworkspace_workspacepermission
    {
      get
      {
        return this.GetRelatedEntity<datalakeworkspace>(nameof (datalakeworkspace_workspacepermission), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakeworkspace_workspacepermission));
        this.SetRelatedEntity<datalakeworkspace>(nameof (datalakeworkspace_workspacepermission), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakeworkspace_workspacepermission));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_datalakeworkspacepermission_createdby")]
    public SystemUser lk_datalakeworkspacepermission_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_datalakeworkspacepermission_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_datalakeworkspacepermission_createdonbehalfby")]
    public SystemUser lk_datalakeworkspacepermission_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_datalakeworkspacepermission_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_datalakeworkspacepermission_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_datalakeworkspacepermission_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_datalakeworkspacepermission_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_datalakeworkspacepermission_modifiedby")]
    public SystemUser lk_datalakeworkspacepermission_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_datalakeworkspacepermission_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_datalakeworkspacepermission_modifiedonbehalfby")]
    public SystemUser lk_datalakeworkspacepermission_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_datalakeworkspacepermission_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_datalakeworkspacepermission_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_datalakeworkspacepermission_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_datalakeworkspacepermission_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_datalakeworkspacepermission")]
    public Organization organization_datalakeworkspacepermission
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_datalakeworkspacepermission), new EntityRole?());
      }
    }

    public datalakeworkspacepermission(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["datalakeworkspacepermissionid"] = (object) base.Id;
            break;
          case "datalakeworkspacepermissionid":
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
