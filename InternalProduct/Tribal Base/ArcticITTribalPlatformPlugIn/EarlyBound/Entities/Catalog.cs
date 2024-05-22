// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.Catalog
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("catalog")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class Catalog : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "catalog";
    public const string EntitySchemaName = "Catalog";
    public const string PrimaryIdAttribute = "catalogid";
    public const string PrimaryNameAttribute = "name";

    public Catalog()
      : base("catalog")
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

    [AttributeLogicalName("catalogid")]
    public Guid? CatalogId
    {
      get => this.GetAttributeValue<Guid?>("catalogid");
      set
      {
        this.OnPropertyChanging(nameof (CatalogId));
        this.SetAttributeValue("catalogid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (CatalogId));
      }
    }

    [AttributeLogicalName("catalogid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.CatalogId = new Guid?(value);
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

    [AttributeLogicalName("description")]
    public string Description
    {
      get => this.GetAttributeValue<string>("description");
      set
      {
        this.OnPropertyChanging(nameof (Description));
        this.SetAttributeValue("description", (object) value);
        this.OnPropertyChanged(nameof (Description));
      }
    }

    [AttributeLogicalName("displayname")]
    public string DisplayName
    {
      get => this.GetAttributeValue<string>("displayname");
      set
      {
        this.OnPropertyChanging(nameof (DisplayName));
        this.SetAttributeValue("displayname", (object) value);
        this.OnPropertyChanged(nameof (DisplayName));
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

    [AttributeLogicalName("parentcatalogid")]
    public EntityReference ParentCatalogId
    {
      get => this.GetAttributeValue<EntityReference>("parentcatalogid");
      set
      {
        this.OnPropertyChanging(nameof (ParentCatalogId));
        this.SetAttributeValue("parentcatalogid", (object) value);
        this.OnPropertyChanged(nameof (ParentCatalogId));
      }
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("statecode")]
    public CatalogState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new CatalogState?((CatalogState) Enum.ToObject(typeof (CatalogState), attributeValue.Value)) : new CatalogState?();
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

    [AttributeLogicalName("uniquename")]
    public string UniqueName
    {
      get => this.GetAttributeValue<string>("uniquename");
      set
      {
        this.OnPropertyChanging(nameof (UniqueName));
        this.SetAttributeValue("uniquename", (object) value);
        this.OnPropertyChanged(nameof (UniqueName));
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

    [RelationshipSchemaName("catalog_AsyncOperations")]
    public IEnumerable<AsyncOperation> catalog_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (catalog_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (catalog_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (catalog_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (catalog_AsyncOperations));
      }
    }

    [RelationshipSchemaName("catalog_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> catalog_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (catalog_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (catalog_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (catalog_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (catalog_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("catalog_catalogassignment")]
    public IEnumerable<CatalogAssignment> catalog_catalogassignment
    {
      get
      {
        return this.GetRelatedEntities<CatalogAssignment>(nameof (catalog_catalogassignment), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (catalog_catalogassignment));
        this.SetRelatedEntities<CatalogAssignment>(nameof (catalog_catalogassignment), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (catalog_catalogassignment));
      }
    }

    [RelationshipSchemaName("catalog_internalcatalogassignment")]
    public IEnumerable<InternalCatalogAssignment> catalog_internalcatalogassignment
    {
      get
      {
        return this.GetRelatedEntities<InternalCatalogAssignment>(nameof (catalog_internalcatalogassignment), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (catalog_internalcatalogassignment));
        this.SetRelatedEntities<InternalCatalogAssignment>(nameof (catalog_internalcatalogassignment), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (catalog_internalcatalogassignment));
      }
    }

    [RelationshipSchemaName("catalog_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> catalog_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (catalog_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (catalog_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (catalog_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (catalog_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("catalog_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> catalog_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (catalog_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (catalog_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (catalog_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (catalog_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("catalog_ProcessSession")]
    public IEnumerable<ProcessSession> catalog_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (catalog_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (catalog_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (catalog_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (catalog_ProcessSession));
      }
    }

    [RelationshipSchemaName("catalog_SyncErrors")]
    public IEnumerable<SyncError> catalog_SyncErrors
    {
      get => this.GetRelatedEntities<SyncError>(nameof (catalog_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (catalog_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (catalog_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (catalog_SyncErrors));
      }
    }

    [RelationshipSchemaName("catalog_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> catalog_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (catalog_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (catalog_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (catalog_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (catalog_UserEntityInstanceDatas));
      }
    }

    [RelationshipSchemaName]
    public IEnumerable<Catalog> Referencedparentcatalog_catalog
    {
      get
      {
        return this.GetRelatedEntities<Catalog>("parentcatalog_catalog", new EntityRole?((EntityRole) 1));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencedparentcatalog_catalog));
        this.SetRelatedEntities<Catalog>("parentcatalog_catalog", new EntityRole?((EntityRole) 1), value);
        this.OnPropertyChanged(nameof (Referencedparentcatalog_catalog));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_catalog_createdby")]
    public SystemUser lk_catalog_createdby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_catalog_createdby), new EntityRole?());
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_catalog_createdonbehalfby")]
    public SystemUser lk_catalog_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_catalog_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_catalog_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_catalog_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_catalog_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_catalog_modifiedby")]
    public SystemUser lk_catalog_modifiedby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_catalog_modifiedby), new EntityRole?());
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_catalog_modifiedonbehalfby")]
    public SystemUser lk_catalog_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_catalog_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_catalog_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_catalog_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_catalog_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_catalog")]
    public Organization organization_catalog
    {
      get => this.GetRelatedEntity<Organization>(nameof (organization_catalog), new EntityRole?());
    }

    [AttributeLogicalName("parentcatalogid")]
    [RelationshipSchemaName]
    public Catalog Referencingparentcatalog_catalog
    {
      get
      {
        return this.GetRelatedEntity<Catalog>("parentcatalog_catalog", new EntityRole?((EntityRole) 0));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencingparentcatalog_catalog));
        this.SetRelatedEntity<Catalog>("parentcatalog_catalog", new EntityRole?((EntityRole) 0), value);
        this.OnPropertyChanged(nameof (Referencingparentcatalog_catalog));
      }
    }

    public Catalog(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["catalogid"] = (object) base.Id;
            break;
          case "catalogid":
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
