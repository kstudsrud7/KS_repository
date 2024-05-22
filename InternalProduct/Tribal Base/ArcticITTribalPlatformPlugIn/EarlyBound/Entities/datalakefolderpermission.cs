// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.datalakefolderpermission
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("datalakefolderpermission")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class datalakefolderpermission : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "datalakefolderpermission";
    public const string EntitySchemaName = "datalakefolderpermission";
    public const string PrimaryIdAttribute = "datalakefolderpermissionid";
    public const string PrimaryNameAttribute = "name";

    public datalakefolderpermission()
      : base(nameof (datalakefolderpermission))
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

    [AttributeLogicalName("datalakefolderpermission_uniquename")]
    public string datalakefolderpermission_UniqueName
    {
      get => this.GetAttributeValue<string>("datalakefolderpermission_uniquename");
      set
      {
        this.OnPropertyChanging(nameof (datalakefolderpermission_UniqueName));
        this.SetAttributeValue("datalakefolderpermission_uniquename", (object) value);
        this.OnPropertyChanged(nameof (datalakefolderpermission_UniqueName));
      }
    }

    [AttributeLogicalName("datalakefolderpermissionid")]
    public Guid? datalakefolderpermissionId
    {
      get => this.GetAttributeValue<Guid?>("datalakefolderpermissionid");
      set
      {
        this.OnPropertyChanging(nameof (datalakefolderpermissionId));
        this.SetAttributeValue("datalakefolderpermissionid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (datalakefolderpermissionId));
      }
    }

    [AttributeLogicalName("datalakefolderpermissionid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.datalakefolderpermissionId = new Guid?(value);
    }

    [AttributeLogicalName("folderid")]
    public EntityReference folderid
    {
      get => this.GetAttributeValue<EntityReference>(nameof (folderid));
      set
      {
        this.OnPropertyChanging(nameof (folderid));
        this.SetAttributeValue(nameof (folderid), (object) value);
        this.OnPropertyChanged(nameof (folderid));
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

    [AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime => this.GetAttributeValue<DateTime?>("overwritetime");

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

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("statecode")]
    public datalakefolderpermissionState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new datalakefolderpermissionState?((datalakefolderpermissionState) Enum.ToObject(typeof (datalakefolderpermissionState), attributeValue.Value)) : new datalakefolderpermissionState?();
      }
    }

    [AttributeLogicalName("statuscode")]
    public OptionSetValue StatusCode => this.GetAttributeValue<OptionSetValue>("statuscode");

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

    [RelationshipSchemaName("datalakefolderpermission_AsyncOperations")]
    public IEnumerable<AsyncOperation> datalakefolderpermission_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (datalakefolderpermission_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakefolderpermission_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (datalakefolderpermission_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakefolderpermission_AsyncOperations));
      }
    }

    [RelationshipSchemaName("datalakefolderpermission_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> datalakefolderpermission_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (datalakefolderpermission_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakefolderpermission_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (datalakefolderpermission_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakefolderpermission_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("datalakefolderpermission_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> datalakefolderpermission_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (datalakefolderpermission_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakefolderpermission_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (datalakefolderpermission_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakefolderpermission_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("datalakefolderpermission_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> datalakefolderpermission_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (datalakefolderpermission_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakefolderpermission_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (datalakefolderpermission_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakefolderpermission_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("datalakefolderpermission_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> datalakefolderpermission_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (datalakefolderpermission_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakefolderpermission_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (datalakefolderpermission_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakefolderpermission_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("datalakefolderpermission_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> datalakefolderpermission_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (datalakefolderpermission_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakefolderpermission_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (datalakefolderpermission_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakefolderpermission_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("datalakefolderpermission_ProcessSession")]
    public IEnumerable<ProcessSession> datalakefolderpermission_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (datalakefolderpermission_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakefolderpermission_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (datalakefolderpermission_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakefolderpermission_ProcessSession));
      }
    }

    [RelationshipSchemaName("datalakefolderpermission_SyncErrors")]
    public IEnumerable<SyncError> datalakefolderpermission_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (datalakefolderpermission_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakefolderpermission_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (datalakefolderpermission_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakefolderpermission_SyncErrors));
      }
    }

    [RelationshipSchemaName("datalakefolderpermission_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> datalakefolderpermission_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (datalakefolderpermission_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakefolderpermission_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (datalakefolderpermission_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakefolderpermission_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_datalakefolderpermission")]
    public BusinessUnit business_unit_datalakefolderpermission
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_datalakefolderpermission), new EntityRole?());
      }
    }

    [AttributeLogicalName("folderid")]
    [RelationshipSchemaName("datalakefolder_datalakefolderpermission")]
    public datalakefolder datalakefolder_datalakefolderpermission
    {
      get
      {
        return this.GetRelatedEntity<datalakefolder>(nameof (datalakefolder_datalakefolderpermission), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakefolder_datalakefolderpermission));
        this.SetRelatedEntity<datalakefolder>(nameof (datalakefolder_datalakefolderpermission), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakefolder_datalakefolderpermission));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_datalakefolderpermission_createdby")]
    public SystemUser lk_datalakefolderpermission_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_datalakefolderpermission_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_datalakefolderpermission_createdonbehalfby")]
    public SystemUser lk_datalakefolderpermission_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_datalakefolderpermission_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_datalakefolderpermission_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_datalakefolderpermission_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_datalakefolderpermission_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_datalakefolderpermission_modifiedby")]
    public SystemUser lk_datalakefolderpermission_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_datalakefolderpermission_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_datalakefolderpermission_modifiedonbehalfby")]
    public SystemUser lk_datalakefolderpermission_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_datalakefolderpermission_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_datalakefolderpermission_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_datalakefolderpermission_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_datalakefolderpermission_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_datalakefolderpermission")]
    public Team team_datalakefolderpermission
    {
      get => this.GetRelatedEntity<Team>(nameof (team_datalakefolderpermission), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_datalakefolderpermission")]
    public SystemUser user_datalakefolderpermission
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_datalakefolderpermission), new EntityRole?());
      }
    }

    public datalakefolderpermission(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["datalakefolderpermissionid"] = (object) base.Id;
            break;
          case "datalakefolderpermissionid":
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
