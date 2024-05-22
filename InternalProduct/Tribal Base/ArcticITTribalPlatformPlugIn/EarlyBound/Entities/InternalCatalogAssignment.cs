// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.InternalCatalogAssignment
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("internalcatalogassignment")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class InternalCatalogAssignment : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "internalcatalogassignment";
    public const string EntitySchemaName = "InternalCatalogAssignment";
    public const string PrimaryIdAttribute = "internalcatalogassignmentid";
    public const string PrimaryNameAttribute = "name";

    public InternalCatalogAssignment()
      : base("internalcatalogassignment")
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

    [AttributeLogicalName("internalcatalogassignmentid")]
    public Guid? InternalCatalogAssignmentId
    {
      get => this.GetAttributeValue<Guid?>("internalcatalogassignmentid");
      set
      {
        this.OnPropertyChanging(nameof (InternalCatalogAssignmentId));
        this.SetAttributeValue("internalcatalogassignmentid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (InternalCatalogAssignmentId));
      }
    }

    [AttributeLogicalName("internalcatalogassignmentid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.InternalCatalogAssignmentId = new Guid?(value);
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
    public InternalCatalogAssignmentState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new InternalCatalogAssignmentState?((InternalCatalogAssignmentState) Enum.ToObject(typeof (InternalCatalogAssignmentState), attributeValue.Value)) : new InternalCatalogAssignmentState?();
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

    [RelationshipSchemaName("internalcatalogassignment_AsyncOperations")]
    public IEnumerable<AsyncOperation> internalcatalogassignment_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (internalcatalogassignment_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (internalcatalogassignment_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (internalcatalogassignment_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (internalcatalogassignment_AsyncOperations));
      }
    }

    [RelationshipSchemaName("internalcatalogassignment_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> internalcatalogassignment_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (internalcatalogassignment_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (internalcatalogassignment_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (internalcatalogassignment_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (internalcatalogassignment_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("internalcatalogassignment_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> internalcatalogassignment_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (internalcatalogassignment_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (internalcatalogassignment_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (internalcatalogassignment_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (internalcatalogassignment_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("internalcatalogassignment_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> internalcatalogassignment_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (internalcatalogassignment_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (internalcatalogassignment_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (internalcatalogassignment_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (internalcatalogassignment_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("internalcatalogassignment_ProcessSession")]
    public IEnumerable<ProcessSession> internalcatalogassignment_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (internalcatalogassignment_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (internalcatalogassignment_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (internalcatalogassignment_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (internalcatalogassignment_ProcessSession));
      }
    }

    [RelationshipSchemaName("internalcatalogassignment_SyncErrors")]
    public IEnumerable<SyncError> internalcatalogassignment_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (internalcatalogassignment_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (internalcatalogassignment_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (internalcatalogassignment_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (internalcatalogassignment_SyncErrors));
      }
    }

    [RelationshipSchemaName("internalcatalogassignment_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> internalcatalogassignment_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (internalcatalogassignment_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (internalcatalogassignment_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (internalcatalogassignment_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (internalcatalogassignment_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("catalogid")]
    [RelationshipSchemaName("catalog_internalcatalogassignment")]
    public Catalog catalog_internalcatalogassignment
    {
      get
      {
        return this.GetRelatedEntity<Catalog>(nameof (catalog_internalcatalogassignment), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (catalog_internalcatalogassignment));
        this.SetRelatedEntity<Catalog>(nameof (catalog_internalcatalogassignment), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (catalog_internalcatalogassignment));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_internalcatalogassignment_createdby")]
    public SystemUser lk_internalcatalogassignment_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_internalcatalogassignment_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_internalcatalogassignment_createdonbehalfby")]
    public SystemUser lk_internalcatalogassignment_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_internalcatalogassignment_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_internalcatalogassignment_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_internalcatalogassignment_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_internalcatalogassignment_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_internalcatalogassignment_modifiedby")]
    public SystemUser lk_internalcatalogassignment_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_internalcatalogassignment_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_internalcatalogassignment_modifiedonbehalfby")]
    public SystemUser lk_internalcatalogassignment_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_internalcatalogassignment_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_internalcatalogassignment_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_internalcatalogassignment_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_internalcatalogassignment_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_internalcatalogassignment")]
    public Organization organization_internalcatalogassignment
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_internalcatalogassignment), new EntityRole?());
      }
    }

    [AttributeLogicalName("object")]
    [RelationshipSchemaName("sdkmessagefilter_internalcatalogassignment")]
    public SdkMessageFilter sdkmessagefilter_internalcatalogassignment
    {
      get
      {
        return this.GetRelatedEntity<SdkMessageFilter>(nameof (sdkmessagefilter_internalcatalogassignment), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (sdkmessagefilter_internalcatalogassignment));
        this.SetRelatedEntity<SdkMessageFilter>(nameof (sdkmessagefilter_internalcatalogassignment), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (sdkmessagefilter_internalcatalogassignment));
      }
    }

    public InternalCatalogAssignment(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["internalcatalogassignmentid"] = (object) base.Id;
            break;
          case "internalcatalogassignmentid":
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
