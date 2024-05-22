// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.solutioncomponentattributeconfiguration
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("solutioncomponentattributeconfiguration")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class solutioncomponentattributeconfiguration : 
    Entity,
    INotifyPropertyChanging,
    INotifyPropertyChanged
  {
    public const string EntityLogicalName = "solutioncomponentattributeconfiguration";
    public const string EntitySchemaName = "solutioncomponentattributeconfiguration";
    public const string PrimaryIdAttribute = "solutioncomponentattributeconfigurationid";
    public const string PrimaryNameAttribute = "name";

    public solutioncomponentattributeconfiguration()
      : base(nameof (solutioncomponentattributeconfiguration))
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

    [AttributeLogicalName("attributeid")]
    public EntityReference AttributeId
    {
      get => this.GetAttributeValue<EntityReference>("attributeid");
      set
      {
        this.OnPropertyChanging(nameof (AttributeId));
        this.SetAttributeValue("attributeid", (object) value);
        this.OnPropertyChanged(nameof (AttributeId));
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

    [AttributeLogicalName("encodingformat")]
    public OptionSetValue EncodingFormat
    {
      get => this.GetAttributeValue<OptionSetValue>("encodingformat");
      set
      {
        this.OnPropertyChanging(nameof (EncodingFormat));
        this.SetAttributeValue("encodingformat", (object) value);
        this.OnPropertyChanged(nameof (EncodingFormat));
      }
    }

    [AttributeLogicalName("fileextension")]
    public string FileExtension
    {
      get => this.GetAttributeValue<string>("fileextension");
      set
      {
        this.OnPropertyChanging(nameof (FileExtension));
        this.SetAttributeValue("fileextension", (object) value);
        this.OnPropertyChanged(nameof (FileExtension));
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

    [AttributeLogicalName("isexportdisabled")]
    public bool? IsExportDisabled
    {
      get => this.GetAttributeValue<bool?>("isexportdisabled");
      set
      {
        this.OnPropertyChanging(nameof (IsExportDisabled));
        this.SetAttributeValue("isexportdisabled", (object) value);
        this.OnPropertyChanged(nameof (IsExportDisabled));
      }
    }

    [AttributeLogicalName("isexportedasfile")]
    public bool? IsExportedAsFile
    {
      get => this.GetAttributeValue<bool?>("isexportedasfile");
      set
      {
        this.OnPropertyChanging(nameof (IsExportedAsFile));
        this.SetAttributeValue("isexportedasfile", (object) value);
        this.OnPropertyChanged(nameof (IsExportedAsFile));
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

    [AttributeLogicalName("solutioncomponentattributeconfigurationid")]
    public Guid? solutioncomponentattributeconfigurationId
    {
      get => this.GetAttributeValue<Guid?>("solutioncomponentattributeconfigurationid");
      set
      {
        this.OnPropertyChanging(nameof (solutioncomponentattributeconfigurationId));
        this.SetAttributeValue("solutioncomponentattributeconfigurationid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (solutioncomponentattributeconfigurationId));
      }
    }

    [AttributeLogicalName("solutioncomponentattributeconfigurationid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.solutioncomponentattributeconfigurationId = new Guid?(value);
    }

    [AttributeLogicalName("solutioncomponentconfigurationid")]
    public EntityReference SolutionComponentConfigurationId
    {
      get => this.GetAttributeValue<EntityReference>("solutioncomponentconfigurationid");
      set
      {
        this.OnPropertyChanging(nameof (SolutionComponentConfigurationId));
        this.SetAttributeValue("solutioncomponentconfigurationid", (object) value);
        this.OnPropertyChanged(nameof (SolutionComponentConfigurationId));
      }
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("statecode")]
    public solutioncomponentattributeconfigurationState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new solutioncomponentattributeconfigurationState?((solutioncomponentattributeconfigurationState) Enum.ToObject(typeof (solutioncomponentattributeconfigurationState), attributeValue.Value)) : new solutioncomponentattributeconfigurationState?();
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

    [RelationshipSchemaName("solutioncomponentattributeconfiguration_AsyncOperations")]
    public IEnumerable<AsyncOperation> solutioncomponentattributeconfiguration_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (solutioncomponentattributeconfiguration_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (solutioncomponentattributeconfiguration_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (solutioncomponentattributeconfiguration_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (solutioncomponentattributeconfiguration_AsyncOperations));
      }
    }

    [RelationshipSchemaName("solutioncomponentattributeconfiguration_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> solutioncomponentattributeconfiguration_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (solutioncomponentattributeconfiguration_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (solutioncomponentattributeconfiguration_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (solutioncomponentattributeconfiguration_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (solutioncomponentattributeconfiguration_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("solutioncomponentattributeconfiguration_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> solutioncomponentattributeconfiguration_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (solutioncomponentattributeconfiguration_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (solutioncomponentattributeconfiguration_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (solutioncomponentattributeconfiguration_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (solutioncomponentattributeconfiguration_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("solutioncomponentattributeconfiguration_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> solutioncomponentattributeconfiguration_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (solutioncomponentattributeconfiguration_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (solutioncomponentattributeconfiguration_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (solutioncomponentattributeconfiguration_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (solutioncomponentattributeconfiguration_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("solutioncomponentattributeconfiguration_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> solutioncomponentattributeconfiguration_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (solutioncomponentattributeconfiguration_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (solutioncomponentattributeconfiguration_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (solutioncomponentattributeconfiguration_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (solutioncomponentattributeconfiguration_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("solutioncomponentattributeconfiguration_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> solutioncomponentattributeconfiguration_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (solutioncomponentattributeconfiguration_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (solutioncomponentattributeconfiguration_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (solutioncomponentattributeconfiguration_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (solutioncomponentattributeconfiguration_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("solutioncomponentattributeconfiguration_ProcessSession")]
    public IEnumerable<ProcessSession> solutioncomponentattributeconfiguration_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (solutioncomponentattributeconfiguration_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (solutioncomponentattributeconfiguration_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (solutioncomponentattributeconfiguration_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (solutioncomponentattributeconfiguration_ProcessSession));
      }
    }

    [RelationshipSchemaName("solutioncomponentattributeconfiguration_SyncErrors")]
    public IEnumerable<SyncError> solutioncomponentattributeconfiguration_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (solutioncomponentattributeconfiguration_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (solutioncomponentattributeconfiguration_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (solutioncomponentattributeconfiguration_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (solutioncomponentattributeconfiguration_SyncErrors));
      }
    }

    [RelationshipSchemaName("solutioncomponentattributeconfiguration_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> solutioncomponentattributeconfiguration_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (solutioncomponentattributeconfiguration_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (solutioncomponentattributeconfiguration_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (solutioncomponentattributeconfiguration_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (solutioncomponentattributeconfiguration_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_solutioncomponentattributeconfiguration_createdby")]
    public SystemUser lk_solutioncomponentattributeconfiguration_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_solutioncomponentattributeconfiguration_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_solutioncomponentattributeconfiguration_createdonbehalfby")]
    public SystemUser lk_solutioncomponentattributeconfiguration_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_solutioncomponentattributeconfiguration_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_solutioncomponentattributeconfiguration_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_solutioncomponentattributeconfiguration_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_solutioncomponentattributeconfiguration_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_solutioncomponentattributeconfiguration_modifiedby")]
    public SystemUser lk_solutioncomponentattributeconfiguration_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_solutioncomponentattributeconfiguration_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_solutioncomponentattributeconfiguration_modifiedonbehalfby")]
    public SystemUser lk_solutioncomponentattributeconfiguration_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_solutioncomponentattributeconfiguration_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_solutioncomponentattributeconfiguration_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_solutioncomponentattributeconfiguration_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_solutioncomponentattributeconfiguration_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_solutioncomponentattributeconfiguration")]
    public Organization organization_solutioncomponentattributeconfiguration
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_solutioncomponentattributeconfiguration), new EntityRole?());
      }
    }

    [AttributeLogicalName("solutioncomponentconfigurationid")]
    [RelationshipSchemaName("solutioncomponentconfig_solutioncomponentattrconfig")]
    public solutioncomponentconfiguration solutioncomponentconfig_solutioncomponentattrconfig
    {
      get
      {
        return this.GetRelatedEntity<solutioncomponentconfiguration>(nameof (solutioncomponentconfig_solutioncomponentattrconfig), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (solutioncomponentconfig_solutioncomponentattrconfig));
        this.SetRelatedEntity<solutioncomponentconfiguration>(nameof (solutioncomponentconfig_solutioncomponentattrconfig), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (solutioncomponentconfig_solutioncomponentattrconfig));
      }
    }

    public solutioncomponentattributeconfiguration(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["solutioncomponentattributeconfigurationid"] = (object) base.Id;
            break;
          case "solutioncomponentattributeconfigurationid":
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
