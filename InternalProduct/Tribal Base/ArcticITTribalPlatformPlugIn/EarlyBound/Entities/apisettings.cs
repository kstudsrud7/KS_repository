// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.apisettings
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("apisettings")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class apisettings : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "apisettings";
    public const string EntitySchemaName = "apisettings";
    public const string PrimaryIdAttribute = "apisettingsid";
    public const string PrimaryNameAttribute = "parententitylogicalname";

    public apisettings()
      : base(nameof (apisettings))
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

    [AttributeLogicalName("apisettingsid")]
    public Guid? apisettingsId
    {
      get => this.GetAttributeValue<Guid?>("apisettingsid");
      set
      {
        this.OnPropertyChanging(nameof (apisettingsId));
        this.SetAttributeValue("apisettingsid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (apisettingsId));
      }
    }

    [AttributeLogicalName("apisettingsid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.apisettingsId = new Guid?(value);
    }

    [AttributeLogicalName("bulkapiexecutionmode")]
    public OptionSetValue BulkApiExecutionMode
    {
      get => this.GetAttributeValue<OptionSetValue>("bulkapiexecutionmode");
      set
      {
        this.OnPropertyChanging(nameof (BulkApiExecutionMode));
        this.SetAttributeValue("bulkapiexecutionmode", (object) value);
        this.OnPropertyChanged(nameof (BulkApiExecutionMode));
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

    [AttributeLogicalName("parententitylogicalname")]
    public string ParentEntityLogicalName
    {
      get => this.GetAttributeValue<string>("parententitylogicalname");
      set
      {
        this.OnPropertyChanging(nameof (ParentEntityLogicalName));
        this.SetAttributeValue("parententitylogicalname", (object) value);
        this.OnPropertyChanged(nameof (ParentEntityLogicalName));
      }
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("statecode")]
    public apisettingsState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new apisettingsState?((apisettingsState) Enum.ToObject(typeof (apisettingsState), attributeValue.Value)) : new apisettingsState?();
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

    [RelationshipSchemaName("apisettings_AsyncOperations")]
    public IEnumerable<AsyncOperation> apisettings_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (apisettings_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (apisettings_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (apisettings_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (apisettings_AsyncOperations));
      }
    }

    [RelationshipSchemaName("apisettings_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> apisettings_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (apisettings_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (apisettings_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (apisettings_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (apisettings_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("apisettings_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> apisettings_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (apisettings_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (apisettings_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (apisettings_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (apisettings_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("apisettings_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> apisettings_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (apisettings_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (apisettings_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (apisettings_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (apisettings_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("apisettings_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> apisettings_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (apisettings_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (apisettings_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (apisettings_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (apisettings_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("apisettings_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> apisettings_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (apisettings_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (apisettings_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (apisettings_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (apisettings_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("apisettings_ProcessSession")]
    public IEnumerable<ProcessSession> apisettings_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (apisettings_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (apisettings_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (apisettings_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (apisettings_ProcessSession));
      }
    }

    [RelationshipSchemaName("apisettings_SyncErrors")]
    public IEnumerable<SyncError> apisettings_SyncErrors
    {
      get => this.GetRelatedEntities<SyncError>(nameof (apisettings_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (apisettings_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (apisettings_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (apisettings_SyncErrors));
      }
    }

    [RelationshipSchemaName("apisettings_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> apisettings_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (apisettings_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (apisettings_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (apisettings_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (apisettings_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_apisettings_createdby")]
    public SystemUser lk_apisettings_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_apisettings_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_apisettings_createdonbehalfby")]
    public SystemUser lk_apisettings_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_apisettings_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_apisettings_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_apisettings_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_apisettings_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_apisettings_modifiedby")]
    public SystemUser lk_apisettings_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_apisettings_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_apisettings_modifiedonbehalfby")]
    public SystemUser lk_apisettings_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_apisettings_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_apisettings_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_apisettings_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_apisettings_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_apisettings")]
    public Organization organization_apisettings
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_apisettings), new EntityRole?());
      }
    }

    public apisettings(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["apisettingsid"] = (object) base.Id;
            break;
          case "apisettingsid":
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
