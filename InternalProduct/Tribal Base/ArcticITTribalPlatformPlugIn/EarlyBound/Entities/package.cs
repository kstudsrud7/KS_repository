// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.package
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("package")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class package : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "package";
    public const string EntitySchemaName = "package";
    public const string PrimaryIdAttribute = "packageid";
    public const string PrimaryNameAttribute = "packageuniquename";

    public package()
      : base(nameof (package))
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
    public Guid? AppId
    {
      get => this.GetAttributeValue<Guid?>("appid");
      set
      {
        this.OnPropertyChanging(nameof (AppId));
        this.SetAttributeValue("appid", (object) value);
        this.OnPropertyChanged(nameof (AppId));
      }
    }

    [AttributeLogicalName("applicationname")]
    public string ApplicationName
    {
      get => this.GetAttributeValue<string>("applicationname");
      set
      {
        this.OnPropertyChanging(nameof (ApplicationName));
        this.SetAttributeValue("applicationname", (object) value);
        this.OnPropertyChanged(nameof (ApplicationName));
      }
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

    [AttributeLogicalName("installedon")]
    public DateTime? InstalledOn
    {
      get => this.GetAttributeValue<DateTime?>("installedon");
      set
      {
        this.OnPropertyChanging(nameof (InstalledOn));
        this.SetAttributeValue("installedon", (object) value);
        this.OnPropertyChanged(nameof (InstalledOn));
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

    [AttributeLogicalName("packageid")]
    public Guid? packageId
    {
      get => this.GetAttributeValue<Guid?>("packageid");
      set
      {
        this.OnPropertyChanging(nameof (packageId));
        this.SetAttributeValue("packageid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (packageId));
      }
    }

    [AttributeLogicalName("packageid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.packageId = new Guid?(value);
    }

    [AttributeLogicalName("packageinstanceid")]
    public Guid? PackageInstanceId
    {
      get => this.GetAttributeValue<Guid?>("packageinstanceid");
      set
      {
        this.OnPropertyChanging(nameof (PackageInstanceId));
        this.SetAttributeValue("packageinstanceid", (object) value);
        this.OnPropertyChanged(nameof (PackageInstanceId));
      }
    }

    [AttributeLogicalName("packageinstanceoperationid")]
    public Guid? PackageInstanceOperationId
    {
      get => this.GetAttributeValue<Guid?>("packageinstanceoperationid");
      set
      {
        this.OnPropertyChanging(nameof (PackageInstanceOperationId));
        this.SetAttributeValue("packageinstanceoperationid", (object) value);
        this.OnPropertyChanged(nameof (PackageInstanceOperationId));
      }
    }

    [AttributeLogicalName("packageuniquename")]
    public string PackageUniqueName
    {
      get => this.GetAttributeValue<string>("packageuniquename");
      set
      {
        this.OnPropertyChanging(nameof (PackageUniqueName));
        this.SetAttributeValue("packageuniquename", (object) value);
        this.OnPropertyChanged(nameof (PackageUniqueName));
      }
    }

    [AttributeLogicalName("packageversion")]
    public string PackageVersion
    {
      get => this.GetAttributeValue<string>("packageversion");
      set
      {
        this.OnPropertyChanging(nameof (PackageVersion));
        this.SetAttributeValue("packageversion", (object) value);
        this.OnPropertyChanged(nameof (PackageVersion));
      }
    }

    [AttributeLogicalName("publisherid")]
    public Guid? PublisherId
    {
      get => this.GetAttributeValue<Guid?>("publisherid");
      set
      {
        this.OnPropertyChanging(nameof (PublisherId));
        this.SetAttributeValue("publisherid", (object) value);
        this.OnPropertyChanged(nameof (PublisherId));
      }
    }

    [AttributeLogicalName("publishername")]
    public string PublisherName
    {
      get => this.GetAttributeValue<string>("publishername");
      set
      {
        this.OnPropertyChanging(nameof (PublisherName));
        this.SetAttributeValue("publishername", (object) value);
        this.OnPropertyChanged(nameof (PublisherName));
      }
    }

    [AttributeLogicalName("statecode")]
    public packageState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new packageState?((packageState) Enum.ToObject(typeof (packageState), attributeValue.Value)) : new packageState?();
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

    [AttributeLogicalName("tpspackageid")]
    public Guid? TPSPackageId
    {
      get => this.GetAttributeValue<Guid?>("tpspackageid");
      set
      {
        this.OnPropertyChanging(nameof (TPSPackageId));
        this.SetAttributeValue("tpspackageid", (object) value);
        this.OnPropertyChanged(nameof (TPSPackageId));
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

    [RelationshipSchemaName("package_AsyncOperations")]
    public IEnumerable<AsyncOperation> package_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (package_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (package_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (package_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (package_AsyncOperations));
      }
    }

    [RelationshipSchemaName("package_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> package_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (package_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (package_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (package_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (package_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("package_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> package_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (package_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (package_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (package_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (package_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("package_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> package_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (package_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (package_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (package_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (package_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("package_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> package_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (package_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (package_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (package_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (package_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("package_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> package_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (package_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (package_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (package_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (package_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("package_ProcessSession")]
    public IEnumerable<ProcessSession> package_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (package_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (package_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (package_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (package_ProcessSession));
      }
    }

    [RelationshipSchemaName("package_SyncErrors")]
    public IEnumerable<SyncError> package_SyncErrors
    {
      get => this.GetRelatedEntities<SyncError>(nameof (package_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (package_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (package_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (package_SyncErrors));
      }
    }

    [RelationshipSchemaName("package_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> package_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (package_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (package_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (package_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (package_UserEntityInstanceDatas));
      }
    }

    [RelationshipSchemaName("package_solution")]
    public IEnumerable<Solution> package_solution
    {
      get => this.GetRelatedEntities<Solution>(nameof (package_solution), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (package_solution));
        this.SetRelatedEntities<Solution>(nameof (package_solution), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (package_solution));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_package_createdby")]
    public SystemUser lk_package_createdby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_package_createdby), new EntityRole?());
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_package_createdonbehalfby")]
    public SystemUser lk_package_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_package_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_package_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_package_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_package_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_package_modifiedby")]
    public SystemUser lk_package_modifiedby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_package_modifiedby), new EntityRole?());
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_package_modifiedonbehalfby")]
    public SystemUser lk_package_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_package_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_package_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_package_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_package_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_package")]
    public Organization organization_package
    {
      get => this.GetRelatedEntity<Organization>(nameof (organization_package), new EntityRole?());
    }

    public package(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["packageid"] = (object) base.Id;
            break;
          case "packageid":
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
