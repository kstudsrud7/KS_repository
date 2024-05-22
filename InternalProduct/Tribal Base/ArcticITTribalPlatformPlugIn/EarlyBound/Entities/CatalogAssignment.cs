// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.CatalogAssignment
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("catalogassignment")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class CatalogAssignment : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "catalogassignment";
    public const string EntitySchemaName = "CatalogAssignment";
    public const string PrimaryIdAttribute = "catalogassignmentid";
    public const string PrimaryNameAttribute = "name";

    public CatalogAssignment()
      : base("catalogassignment")
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

    [AttributeLogicalName("catalogassignmentid")]
    public Guid? CatalogAssignmentId
    {
      get => this.GetAttributeValue<Guid?>("catalogassignmentid");
      set
      {
        this.OnPropertyChanging(nameof (CatalogAssignmentId));
        this.SetAttributeValue("catalogassignmentid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (CatalogAssignmentId));
      }
    }

    [AttributeLogicalName("catalogassignmentid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.CatalogAssignmentId = new Guid?(value);
    }

    [AttributeLogicalName("catalogid")]
    public EntityReference CatalogId
    {
      get => this.GetAttributeValue<EntityReference>("catalogid");
      set
      {
        this.OnPropertyChanging(nameof (CatalogId));
        this.SetAttributeValue("catalogid", (object) value);
        this.OnPropertyChanged(nameof (CatalogId));
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

    [AttributeLogicalName("name")]
    public string Name
    {
      get => this.GetAttributeValue<string>("name");
      set
      {
        this.OnPropertyChanging(nameof (Name));
        this.SetAttributeValue("name", (object) value);
        this.OnPropertyChanged(nameof (Name));
      }
    }

    [AttributeLogicalName("object")]
    public EntityReference Object
    {
      get => this.GetAttributeValue<EntityReference>("object");
      set
      {
        this.OnPropertyChanging(nameof (Object));
        this.SetAttributeValue("object", (object) value);
        this.OnPropertyChanged(nameof (Object));
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
    public CatalogAssignmentState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new CatalogAssignmentState?((CatalogAssignmentState) Enum.ToObject(typeof (CatalogAssignmentState), attributeValue.Value)) : new CatalogAssignmentState?();
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

    [RelationshipSchemaName("catalogassignment_AsyncOperations")]
    public IEnumerable<AsyncOperation> catalogassignment_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (catalogassignment_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (catalogassignment_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (catalogassignment_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (catalogassignment_AsyncOperations));
      }
    }

    [RelationshipSchemaName("catalogassignment_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> catalogassignment_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (catalogassignment_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (catalogassignment_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (catalogassignment_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (catalogassignment_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("catalogassignment_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> catalogassignment_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (catalogassignment_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (catalogassignment_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (catalogassignment_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (catalogassignment_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("catalogassignment_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> catalogassignment_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (catalogassignment_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (catalogassignment_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (catalogassignment_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (catalogassignment_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("catalogassignment_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> catalogassignment_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (catalogassignment_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (catalogassignment_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (catalogassignment_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (catalogassignment_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("catalogassignment_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> catalogassignment_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (catalogassignment_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (catalogassignment_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (catalogassignment_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (catalogassignment_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("catalogassignment_ProcessSession")]
    public IEnumerable<ProcessSession> catalogassignment_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (catalogassignment_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (catalogassignment_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (catalogassignment_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (catalogassignment_ProcessSession));
      }
    }

    [RelationshipSchemaName("catalogassignment_SyncErrors")]
    public IEnumerable<SyncError> catalogassignment_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (catalogassignment_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (catalogassignment_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (catalogassignment_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (catalogassignment_SyncErrors));
      }
    }

    [RelationshipSchemaName("catalogassignment_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> catalogassignment_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (catalogassignment_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (catalogassignment_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (catalogassignment_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (catalogassignment_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("catalogid")]
    [RelationshipSchemaName("catalog_catalogassignment")]
    public Catalog catalog_catalogassignment
    {
      get => this.GetRelatedEntity<Catalog>(nameof (catalog_catalogassignment), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (catalog_catalogassignment));
        this.SetRelatedEntity<Catalog>(nameof (catalog_catalogassignment), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (catalog_catalogassignment));
      }
    }

    [AttributeLogicalName("object")]
    [RelationshipSchemaName("catalogassignment_customapi")]
    public CustomAPI catalogassignment_customapi
    {
      get
      {
        return this.GetRelatedEntity<CustomAPI>(nameof (catalogassignment_customapi), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (catalogassignment_customapi));
        this.SetRelatedEntity<CustomAPI>(nameof (catalogassignment_customapi), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (catalogassignment_customapi));
      }
    }

    [AttributeLogicalName("object")]
    [RelationshipSchemaName("catalogassignment_workflow")]
    public Workflow catalogassignment_workflow
    {
      get
      {
        return this.GetRelatedEntity<Workflow>(nameof (catalogassignment_workflow), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (catalogassignment_workflow));
        this.SetRelatedEntity<Workflow>(nameof (catalogassignment_workflow), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (catalogassignment_workflow));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_catalogassignment_createdby")]
    public SystemUser lk_catalogassignment_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_catalogassignment_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_catalogassignment_createdonbehalfby")]
    public SystemUser lk_catalogassignment_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_catalogassignment_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_catalogassignment_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_catalogassignment_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_catalogassignment_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_catalogassignment_modifiedby")]
    public SystemUser lk_catalogassignment_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_catalogassignment_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_catalogassignment_modifiedonbehalfby")]
    public SystemUser lk_catalogassignment_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_catalogassignment_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_catalogassignment_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_catalogassignment_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_catalogassignment_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_catalogassignment")]
    public Organization organization_catalogassignment
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_catalogassignment), new EntityRole?());
      }
    }

    public CatalogAssignment(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["catalogassignmentid"] = (object) base.Id;
            break;
          case "catalogassignmentid":
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
