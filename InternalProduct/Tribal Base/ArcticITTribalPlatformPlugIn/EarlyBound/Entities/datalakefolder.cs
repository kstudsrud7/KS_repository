// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.datalakefolder
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("datalakefolder")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class datalakefolder : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "datalakefolder";
    public const string EntitySchemaName = "datalakefolder";
    public const string PrimaryIdAttribute = "datalakefolderid";
    public const string PrimaryNameAttribute = "name";

    public datalakefolder()
      : base(nameof (datalakefolder))
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

    [AttributeLogicalName("datalakefolder_uniquename")]
    public string datalakefolder_UniqueName
    {
      get => this.GetAttributeValue<string>("datalakefolder_uniquename");
      set
      {
        this.OnPropertyChanging(nameof (datalakefolder_UniqueName));
        this.SetAttributeValue("datalakefolder_uniquename", (object) value);
        this.OnPropertyChanged(nameof (datalakefolder_UniqueName));
      }
    }

    [AttributeLogicalName("datalakefolderid")]
    public Guid? datalakefolderId
    {
      get => this.GetAttributeValue<Guid?>("datalakefolderid");
      set
      {
        this.OnPropertyChanging(nameof (datalakefolderId));
        this.SetAttributeValue("datalakefolderid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (datalakefolderId));
      }
    }

    [AttributeLogicalName("datalakefolderid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.datalakefolderId = new Guid?(value);
    }

    [AttributeLogicalName("extendedproperties")]
    public string extendedproperties
    {
      get => this.GetAttributeValue<string>(nameof (extendedproperties));
      set
      {
        this.OnPropertyChanging(nameof (extendedproperties));
        this.SetAttributeValue(nameof (extendedproperties), (object) value);
        this.OnPropertyChanged(nameof (extendedproperties));
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

    [AttributeLogicalName("owningbusinessunit")]
    public EntityReference OwningBusinessUnit
    {
      get => this.GetAttributeValue<EntityReference>("owningbusinessunit");
    }

    [AttributeLogicalName("owningteam")]
    public EntityReference OwningTeam => this.GetAttributeValue<EntityReference>("owningteam");

    [AttributeLogicalName("owninguser")]
    public EntityReference OwningUser => this.GetAttributeValue<EntityReference>("owninguser");

    [AttributeLogicalName("path")]
    public string path => this.GetAttributeValue<string>(nameof (path));

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("statecode")]
    public datalakefolderState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new datalakefolderState?((datalakefolderState) Enum.ToObject(typeof (datalakefolderState), attributeValue.Value)) : new datalakefolderState?();
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

    [RelationshipSchemaName("datalakefolder_AsyncOperations")]
    public IEnumerable<AsyncOperation> datalakefolder_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (datalakefolder_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakefolder_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (datalakefolder_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakefolder_AsyncOperations));
      }
    }

    [RelationshipSchemaName("datalakefolder_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> datalakefolder_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (datalakefolder_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakefolder_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (datalakefolder_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakefolder_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("datalakefolder_datalakefolderpermission")]
    public IEnumerable<datalakefolderpermission> datalakefolder_datalakefolderpermission
    {
      get
      {
        return this.GetRelatedEntities<datalakefolderpermission>(nameof (datalakefolder_datalakefolderpermission), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakefolder_datalakefolderpermission));
        this.SetRelatedEntities<datalakefolderpermission>(nameof (datalakefolder_datalakefolderpermission), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakefolder_datalakefolderpermission));
      }
    }

    [RelationshipSchemaName("datalakefolder_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> datalakefolder_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (datalakefolder_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakefolder_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (datalakefolder_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakefolder_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("datalakefolder_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> datalakefolder_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (datalakefolder_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakefolder_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (datalakefolder_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakefolder_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("datalakefolder_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> datalakefolder_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (datalakefolder_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakefolder_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (datalakefolder_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakefolder_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("datalakefolder_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> datalakefolder_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (datalakefolder_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakefolder_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (datalakefolder_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakefolder_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("datalakefolder_ProcessSession")]
    public IEnumerable<ProcessSession> datalakefolder_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (datalakefolder_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakefolder_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (datalakefolder_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakefolder_ProcessSession));
      }
    }

    [RelationshipSchemaName("datalakefolder_SyncErrors")]
    public IEnumerable<SyncError> datalakefolder_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (datalakefolder_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakefolder_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (datalakefolder_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakefolder_SyncErrors));
      }
    }

    [RelationshipSchemaName("datalakefolder_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> datalakefolder_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (datalakefolder_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakefolder_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (datalakefolder_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakefolder_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_datalakefolder")]
    public BusinessUnit business_unit_datalakefolder
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_datalakefolder), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_datalakefolder_createdby")]
    public SystemUser lk_datalakefolder_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_datalakefolder_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_datalakefolder_createdonbehalfby")]
    public SystemUser lk_datalakefolder_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_datalakefolder_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_datalakefolder_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_datalakefolder_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_datalakefolder_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_datalakefolder_modifiedby")]
    public SystemUser lk_datalakefolder_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_datalakefolder_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_datalakefolder_modifiedonbehalfby")]
    public SystemUser lk_datalakefolder_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_datalakefolder_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_datalakefolder_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_datalakefolder_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_datalakefolder_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_datalakefolder")]
    public Team team_datalakefolder
    {
      get => this.GetRelatedEntity<Team>(nameof (team_datalakefolder), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_datalakefolder")]
    public SystemUser user_datalakefolder
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_datalakefolder), new EntityRole?());
    }

    public datalakefolder(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["datalakefolderid"] = (object) base.Id;
            break;
          case "datalakefolderid":
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
