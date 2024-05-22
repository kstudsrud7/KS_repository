// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.solutioncomponentrelationshipconfiguration
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("solutioncomponentrelationshipconfiguration")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class solutioncomponentrelationshipconfiguration : 
    Entity,
    INotifyPropertyChanging,
    INotifyPropertyChanged
  {
    public const string EntityLogicalName = "solutioncomponentrelationshipconfiguration";
    public const string EntitySchemaName = "solutioncomponentrelationshipconfiguration";
    public const string PrimaryIdAttribute = "solutioncomponentrelationshipconfigurationid";
    public const string PrimaryNameAttribute = "name";

    public solutioncomponentrelationshipconfiguration()
      : base(nameof (solutioncomponentrelationshipconfiguration))
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

    [AttributeLogicalName("entityrelationshipid")]
    public EntityReference EntityRelationshipId
    {
      get => this.GetAttributeValue<EntityReference>("entityrelationshipid");
      set
      {
        this.OnPropertyChanging(nameof (EntityRelationshipId));
        this.SetAttributeValue("entityrelationshipid", (object) value);
        this.OnPropertyChanged(nameof (EntityRelationshipId));
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

    [AttributeLogicalName("primaryentitydependencytype")]
    public OptionSetValue PrimaryEntityDependencyType
    {
      get => this.GetAttributeValue<OptionSetValue>("primaryentitydependencytype");
      set
      {
        this.OnPropertyChanging(nameof (PrimaryEntityDependencyType));
        this.SetAttributeValue("primaryentitydependencytype", (object) value);
        this.OnPropertyChanged(nameof (PrimaryEntityDependencyType));
      }
    }

    [AttributeLogicalName("secondaryentitydependencytype")]
    public OptionSetValue SecondaryEntityDependencyType
    {
      get => this.GetAttributeValue<OptionSetValue>("secondaryentitydependencytype");
      set
      {
        this.OnPropertyChanging(nameof (SecondaryEntityDependencyType));
        this.SetAttributeValue("secondaryentitydependencytype", (object) value);
        this.OnPropertyChanged(nameof (SecondaryEntityDependencyType));
      }
    }

    [AttributeLogicalName("solutioncomponentrelationshipconfigurationid")]
    public Guid? solutioncomponentrelationshipconfigurationId
    {
      get => this.GetAttributeValue<Guid?>("solutioncomponentrelationshipconfigurationid");
      set
      {
        this.OnPropertyChanging(nameof (solutioncomponentrelationshipconfigurationId));
        this.SetAttributeValue("solutioncomponentrelationshipconfigurationid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (solutioncomponentrelationshipconfigurationId));
      }
    }

    [AttributeLogicalName("solutioncomponentrelationshipconfigurationid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.solutioncomponentrelationshipconfigurationId = new Guid?(value);
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("statecode")]
    public solutioncomponentrelationshipconfigurationState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new solutioncomponentrelationshipconfigurationState?((solutioncomponentrelationshipconfigurationState) Enum.ToObject(typeof (solutioncomponentrelationshipconfigurationState), attributeValue.Value)) : new solutioncomponentrelationshipconfigurationState?();
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

    [RelationshipSchemaName("solutioncomponentrelationshipconfiguration_AsyncOperations")]
    public IEnumerable<AsyncOperation> solutioncomponentrelationshipconfiguration_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (solutioncomponentrelationshipconfiguration_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (solutioncomponentrelationshipconfiguration_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (solutioncomponentrelationshipconfiguration_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (solutioncomponentrelationshipconfiguration_AsyncOperations));
      }
    }

    [RelationshipSchemaName("solutioncomponentrelationshipconfiguration_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> solutioncomponentrelationshipconfiguration_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (solutioncomponentrelationshipconfiguration_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (solutioncomponentrelationshipconfiguration_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (solutioncomponentrelationshipconfiguration_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (solutioncomponentrelationshipconfiguration_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("solutioncomponentrelationshipconfiguration_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> solutioncomponentrelationshipconfiguration_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (solutioncomponentrelationshipconfiguration_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (solutioncomponentrelationshipconfiguration_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (solutioncomponentrelationshipconfiguration_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (solutioncomponentrelationshipconfiguration_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("solutioncomponentrelationshipconfiguration_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> solutioncomponentrelationshipconfiguration_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (solutioncomponentrelationshipconfiguration_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (solutioncomponentrelationshipconfiguration_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (solutioncomponentrelationshipconfiguration_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (solutioncomponentrelationshipconfiguration_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("solutioncomponentrelationshipconfiguration_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> solutioncomponentrelationshipconfiguration_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (solutioncomponentrelationshipconfiguration_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (solutioncomponentrelationshipconfiguration_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (solutioncomponentrelationshipconfiguration_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (solutioncomponentrelationshipconfiguration_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("solutioncomponentrelationshipconfiguration_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> solutioncomponentrelationshipconfiguration_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (solutioncomponentrelationshipconfiguration_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (solutioncomponentrelationshipconfiguration_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (solutioncomponentrelationshipconfiguration_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (solutioncomponentrelationshipconfiguration_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("solutioncomponentrelationshipconfiguration_ProcessSession")]
    public IEnumerable<ProcessSession> solutioncomponentrelationshipconfiguration_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (solutioncomponentrelationshipconfiguration_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (solutioncomponentrelationshipconfiguration_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (solutioncomponentrelationshipconfiguration_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (solutioncomponentrelationshipconfiguration_ProcessSession));
      }
    }

    [RelationshipSchemaName("solutioncomponentrelationshipconfiguration_SyncErrors")]
    public IEnumerable<SyncError> solutioncomponentrelationshipconfiguration_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (solutioncomponentrelationshipconfiguration_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (solutioncomponentrelationshipconfiguration_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (solutioncomponentrelationshipconfiguration_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (solutioncomponentrelationshipconfiguration_SyncErrors));
      }
    }

    [RelationshipSchemaName("solutioncomponentrelationshipconfiguration_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> solutioncomponentrelationshipconfiguration_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (solutioncomponentrelationshipconfiguration_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (solutioncomponentrelationshipconfiguration_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (solutioncomponentrelationshipconfiguration_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (solutioncomponentrelationshipconfiguration_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_solutioncomponentrelationshipconfiguration_createdby")]
    public SystemUser lk_solutioncomponentrelationshipconfiguration_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_solutioncomponentrelationshipconfiguration_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_solutioncomponentrelationshipconfiguration_createdonbehalfby")]
    public SystemUser lk_solutioncomponentrelationshipconfiguration_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_solutioncomponentrelationshipconfiguration_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_solutioncomponentrelationshipconfiguration_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_solutioncomponentrelationshipconfiguration_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_solutioncomponentrelationshipconfiguration_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_solutioncomponentrelationshipconfiguration_modifiedby")]
    public SystemUser lk_solutioncomponentrelationshipconfiguration_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_solutioncomponentrelationshipconfiguration_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_solutioncomponentrelationshipconfiguration_modifiedonbehalfby")]
    public SystemUser lk_solutioncomponentrelationshipconfiguration_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_solutioncomponentrelationshipconfiguration_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_solutioncomponentrelationshipconfiguration_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_solutioncomponentrelationshipconfiguration_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_solutioncomponentrelationshipconfiguration_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_solutioncomponentrelationshipconfiguration")]
    public Organization organization_solutioncomponentrelationshipconfiguration
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_solutioncomponentrelationshipconfiguration), new EntityRole?());
      }
    }

    public solutioncomponentrelationshipconfiguration(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["solutioncomponentrelationshipconfigurationid"] = (object) base.Id;
            break;
          case "solutioncomponentrelationshipconfigurationid":
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
