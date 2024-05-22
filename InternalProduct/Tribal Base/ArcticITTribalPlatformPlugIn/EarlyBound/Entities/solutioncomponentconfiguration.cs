// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.solutioncomponentconfiguration
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("solutioncomponentconfiguration")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class solutioncomponentconfiguration : 
    Entity,
    INotifyPropertyChanging,
    INotifyPropertyChanged
  {
    public const string EntityLogicalName = "solutioncomponentconfiguration";
    public const string EntitySchemaName = "solutioncomponentconfiguration";
    public const string PrimaryIdAttribute = "solutioncomponentconfigurationid";
    public const string PrimaryNameAttribute = "name";

    public solutioncomponentconfiguration()
      : base(nameof (solutioncomponentconfiguration))
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

    [AttributeLogicalName("entityid")]
    public EntityReference EntityId
    {
      get => this.GetAttributeValue<EntityReference>("entityid");
      set
      {
        this.OnPropertyChanging(nameof (EntityId));
        this.SetAttributeValue("entityid", (object) value);
        this.OnPropertyChanged(nameof (EntityId));
      }
    }

    [AttributeLogicalName("fileformat")]
    public OptionSetValue FileFormat
    {
      get => this.GetAttributeValue<OptionSetValue>("fileformat");
      set
      {
        this.OnPropertyChanging(nameof (FileFormat));
        this.SetAttributeValue("fileformat", (object) value);
        this.OnPropertyChanged(nameof (FileFormat));
      }
    }

    [AttributeLogicalName("filescope")]
    public OptionSetValue FileScope
    {
      get => this.GetAttributeValue<OptionSetValue>("filescope");
      set
      {
        this.OnPropertyChanging(nameof (FileScope));
        this.SetAttributeValue("filescope", (object) value);
        this.OnPropertyChanged(nameof (FileScope));
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

    [AttributeLogicalName("isdisplayable")]
    public bool? isdisplayable
    {
      get => this.GetAttributeValue<bool?>(nameof (isdisplayable));
      set
      {
        this.OnPropertyChanging(nameof (isdisplayable));
        this.SetAttributeValue(nameof (isdisplayable), (object) value);
        this.OnPropertyChanged(nameof (isdisplayable));
      }
    }

    [AttributeLogicalName("ismanaged")]
    public bool? IsManaged => this.GetAttributeValue<bool?>("ismanaged");

    [AttributeLogicalName("issoftdeleteenabled")]
    public bool? IsSoftDeleteEnabled
    {
      get => this.GetAttributeValue<bool?>("issoftdeleteenabled");
      set
      {
        this.OnPropertyChanging(nameof (IsSoftDeleteEnabled));
        this.SetAttributeValue("issoftdeleteenabled", (object) value);
        this.OnPropertyChanged(nameof (IsSoftDeleteEnabled));
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

    [AttributeLogicalName("solutioncomponentconfigurationid")]
    public Guid? solutioncomponentconfigurationId
    {
      get => this.GetAttributeValue<Guid?>("solutioncomponentconfigurationid");
      set
      {
        this.OnPropertyChanging(nameof (solutioncomponentconfigurationId));
        this.SetAttributeValue("solutioncomponentconfigurationid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (solutioncomponentconfigurationId));
      }
    }

    [AttributeLogicalName("solutioncomponentconfigurationid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.solutioncomponentconfigurationId = new Guid?(value);
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("statecode")]
    public solutioncomponentconfigurationState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new solutioncomponentconfigurationState?((solutioncomponentconfigurationState) Enum.ToObject(typeof (solutioncomponentconfigurationState), attributeValue.Value)) : new solutioncomponentconfigurationState?();
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

    [RelationshipSchemaName("solutioncomponentconfig_solutioncomponentattrconfig")]
    public IEnumerable<solutioncomponentattributeconfiguration> solutioncomponentconfig_solutioncomponentattrconfig
    {
      get
      {
        return this.GetRelatedEntities<solutioncomponentattributeconfiguration>(nameof (solutioncomponentconfig_solutioncomponentattrconfig), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (solutioncomponentconfig_solutioncomponentattrconfig));
        this.SetRelatedEntities<solutioncomponentattributeconfiguration>(nameof (solutioncomponentconfig_solutioncomponentattrconfig), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (solutioncomponentconfig_solutioncomponentattrconfig));
      }
    }

    [RelationshipSchemaName("solutioncomponentconfiguration_AsyncOperations")]
    public IEnumerable<AsyncOperation> solutioncomponentconfiguration_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (solutioncomponentconfiguration_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (solutioncomponentconfiguration_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (solutioncomponentconfiguration_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (solutioncomponentconfiguration_AsyncOperations));
      }
    }

    [RelationshipSchemaName("solutioncomponentconfiguration_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> solutioncomponentconfiguration_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (solutioncomponentconfiguration_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (solutioncomponentconfiguration_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (solutioncomponentconfiguration_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (solutioncomponentconfiguration_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("solutioncomponentconfiguration_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> solutioncomponentconfiguration_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (solutioncomponentconfiguration_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (solutioncomponentconfiguration_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (solutioncomponentconfiguration_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (solutioncomponentconfiguration_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("solutioncomponentconfiguration_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> solutioncomponentconfiguration_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (solutioncomponentconfiguration_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (solutioncomponentconfiguration_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (solutioncomponentconfiguration_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (solutioncomponentconfiguration_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("solutioncomponentconfiguration_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> solutioncomponentconfiguration_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (solutioncomponentconfiguration_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (solutioncomponentconfiguration_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (solutioncomponentconfiguration_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (solutioncomponentconfiguration_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("solutioncomponentconfiguration_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> solutioncomponentconfiguration_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (solutioncomponentconfiguration_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (solutioncomponentconfiguration_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (solutioncomponentconfiguration_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (solutioncomponentconfiguration_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("solutioncomponentconfiguration_ProcessSession")]
    public IEnumerable<ProcessSession> solutioncomponentconfiguration_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (solutioncomponentconfiguration_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (solutioncomponentconfiguration_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (solutioncomponentconfiguration_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (solutioncomponentconfiguration_ProcessSession));
      }
    }

    [RelationshipSchemaName("solutioncomponentconfiguration_SyncErrors")]
    public IEnumerable<SyncError> solutioncomponentconfiguration_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (solutioncomponentconfiguration_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (solutioncomponentconfiguration_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (solutioncomponentconfiguration_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (solutioncomponentconfiguration_SyncErrors));
      }
    }

    [RelationshipSchemaName("solutioncomponentconfiguration_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> solutioncomponentconfiguration_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (solutioncomponentconfiguration_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (solutioncomponentconfiguration_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (solutioncomponentconfiguration_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (solutioncomponentconfiguration_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_solutioncomponentconfiguration_createdby")]
    public SystemUser lk_solutioncomponentconfiguration_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_solutioncomponentconfiguration_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_solutioncomponentconfiguration_createdonbehalfby")]
    public SystemUser lk_solutioncomponentconfiguration_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_solutioncomponentconfiguration_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_solutioncomponentconfiguration_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_solutioncomponentconfiguration_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_solutioncomponentconfiguration_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_solutioncomponentconfiguration_modifiedby")]
    public SystemUser lk_solutioncomponentconfiguration_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_solutioncomponentconfiguration_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_solutioncomponentconfiguration_modifiedonbehalfby")]
    public SystemUser lk_solutioncomponentconfiguration_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_solutioncomponentconfiguration_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_solutioncomponentconfiguration_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_solutioncomponentconfiguration_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_solutioncomponentconfiguration_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_solutioncomponentconfiguration")]
    public Organization organization_solutioncomponentconfiguration
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_solutioncomponentconfiguration), new EntityRole?());
      }
    }

    public solutioncomponentconfiguration(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["solutioncomponentconfigurationid"] = (object) base.Id;
            break;
          case "solutioncomponentconfigurationid":
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
