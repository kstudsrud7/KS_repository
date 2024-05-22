// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.datalakeworkspace
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("datalakeworkspace")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class datalakeworkspace : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "datalakeworkspace";
    public const string EntitySchemaName = "datalakeworkspace";
    public const string PrimaryIdAttribute = "datalakeworkspaceid";
    public const string PrimaryNameAttribute = "name";

    public datalakeworkspace()
      : base(nameof (datalakeworkspace))
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

    [AttributeLogicalName("componentidunique")]
    public Guid? ComponentIdUnique => this.GetAttributeValue<Guid?>("componentidunique");

    [AttributeLogicalName("componentstate")]
    public OptionSetValue ComponentState
    {
      get => this.GetAttributeValue<OptionSetValue>("componentstate");
    }

    [AttributeLogicalName("containerendpoint")]
    public string containerendpoint => this.GetAttributeValue<string>(nameof (containerendpoint));

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

    [AttributeLogicalName("datalakeworkspace_uniquename")]
    public string datalakeworkspace_UniqueName
    {
      get => this.GetAttributeValue<string>("datalakeworkspace_uniquename");
      set
      {
        this.OnPropertyChanging(nameof (datalakeworkspace_UniqueName));
        this.SetAttributeValue("datalakeworkspace_uniquename", (object) value);
        this.OnPropertyChanged(nameof (datalakeworkspace_UniqueName));
      }
    }

    [AttributeLogicalName("datalakeworkspaceid")]
    public Guid? datalakeworkspaceId
    {
      get => this.GetAttributeValue<Guid?>("datalakeworkspaceid");
      set
      {
        this.OnPropertyChanging(nameof (datalakeworkspaceId));
        this.SetAttributeValue("datalakeworkspaceid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (datalakeworkspaceId));
      }
    }

    [AttributeLogicalName("datalakeworkspaceid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.datalakeworkspaceId = new Guid?(value);
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

    [AttributeLogicalName("iscustomercapacity")]
    public bool? iscustomercapacity
    {
      get => this.GetAttributeValue<bool?>(nameof (iscustomercapacity));
      set
      {
        this.OnPropertyChanging(nameof (iscustomercapacity));
        this.SetAttributeValue(nameof (iscustomercapacity), (object) value);
        this.OnPropertyChanged(nameof (iscustomercapacity));
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

    [AttributeLogicalName("isdeepcopyenabled")]
    public bool? isdeepcopyenabled
    {
      get => this.GetAttributeValue<bool?>(nameof (isdeepcopyenabled));
      set
      {
        this.OnPropertyChanging(nameof (isdeepcopyenabled));
        this.SetAttributeValue(nameof (isdeepcopyenabled), (object) value);
        this.OnPropertyChanged(nameof (isdeepcopyenabled));
      }
    }

    [AttributeLogicalName("ismanaged")]
    public bool? IsManaged => this.GetAttributeValue<bool?>("ismanaged");

    [AttributeLogicalName("isprivate")]
    public bool? isprivate
    {
      get => this.GetAttributeValue<bool?>(nameof (isprivate));
      set
      {
        this.OnPropertyChanging(nameof (isprivate));
        this.SetAttributeValue(nameof (isprivate), (object) value);
        this.OnPropertyChanged(nameof (isprivate));
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

    [AttributeLogicalName("owningappid")]
    public Guid? owningappid
    {
      get => this.GetAttributeValue<Guid?>(nameof (owningappid));
      set
      {
        this.OnPropertyChanging(nameof (owningappid));
        this.SetAttributeValue(nameof (owningappid), (object) value);
        this.OnPropertyChanged(nameof (owningappid));
      }
    }

    [AttributeLogicalName("path")]
    public string path => this.GetAttributeValue<string>(nameof (path));

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("statecode")]
    public datalakeworkspaceState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new datalakeworkspaceState?((datalakeworkspaceState) Enum.ToObject(typeof (datalakeworkspaceState), attributeValue.Value)) : new datalakeworkspaceState?();
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

    [RelationshipSchemaName("datalakeworkspace_AsyncOperations")]
    public IEnumerable<AsyncOperation> datalakeworkspace_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (datalakeworkspace_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakeworkspace_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (datalakeworkspace_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakeworkspace_AsyncOperations));
      }
    }

    [RelationshipSchemaName("datalakeworkspace_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> datalakeworkspace_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (datalakeworkspace_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakeworkspace_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (datalakeworkspace_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakeworkspace_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("datalakeworkspace_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> datalakeworkspace_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (datalakeworkspace_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakeworkspace_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (datalakeworkspace_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakeworkspace_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("datalakeworkspace_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> datalakeworkspace_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (datalakeworkspace_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakeworkspace_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (datalakeworkspace_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakeworkspace_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("datalakeworkspace_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> datalakeworkspace_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (datalakeworkspace_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakeworkspace_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (datalakeworkspace_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakeworkspace_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("datalakeworkspace_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> datalakeworkspace_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (datalakeworkspace_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakeworkspace_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (datalakeworkspace_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakeworkspace_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("datalakeworkspace_ProcessSession")]
    public IEnumerable<ProcessSession> datalakeworkspace_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (datalakeworkspace_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakeworkspace_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (datalakeworkspace_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakeworkspace_ProcessSession));
      }
    }

    [RelationshipSchemaName("datalakeworkspace_SyncErrors")]
    public IEnumerable<SyncError> datalakeworkspace_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (datalakeworkspace_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakeworkspace_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (datalakeworkspace_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakeworkspace_SyncErrors));
      }
    }

    [RelationshipSchemaName("datalakeworkspace_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> datalakeworkspace_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (datalakeworkspace_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakeworkspace_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (datalakeworkspace_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakeworkspace_UserEntityInstanceDatas));
      }
    }

    [RelationshipSchemaName("datalakeworkspace_workspacepermission")]
    public IEnumerable<datalakeworkspacepermission> datalakeworkspace_workspacepermission
    {
      get
      {
        return this.GetRelatedEntities<datalakeworkspacepermission>(nameof (datalakeworkspace_workspacepermission), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakeworkspace_workspacepermission));
        this.SetRelatedEntities<datalakeworkspacepermission>(nameof (datalakeworkspace_workspacepermission), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakeworkspace_workspacepermission));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_datalakeworkspace_createdby")]
    public SystemUser lk_datalakeworkspace_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_datalakeworkspace_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_datalakeworkspace_createdonbehalfby")]
    public SystemUser lk_datalakeworkspace_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_datalakeworkspace_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_datalakeworkspace_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_datalakeworkspace_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_datalakeworkspace_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_datalakeworkspace_modifiedby")]
    public SystemUser lk_datalakeworkspace_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_datalakeworkspace_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_datalakeworkspace_modifiedonbehalfby")]
    public SystemUser lk_datalakeworkspace_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_datalakeworkspace_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_datalakeworkspace_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_datalakeworkspace_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_datalakeworkspace_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_datalakeworkspace")]
    public Organization organization_datalakeworkspace
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_datalakeworkspace), new EntityRole?());
      }
    }

    public datalakeworkspace(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["datalakeworkspaceid"] = (object) base.Id;
            break;
          case "datalakeworkspaceid":
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
