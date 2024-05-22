// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ServicePlan
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("serviceplan")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ServicePlan : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "serviceplan";
    public const string EntitySchemaName = "ServicePlan";
    public const string PrimaryIdAttribute = "serviceplanid";
    public const string PrimaryNameAttribute = "name";

    public ServicePlan()
      : base("serviceplan")
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

    [AttributeLogicalName("accessmode")]
    public OptionSetValue AccessMode
    {
      get => this.GetAttributeValue<OptionSetValue>("accessmode");
      set
      {
        this.OnPropertyChanging(nameof (AccessMode));
        this.SetAttributeValue("accessmode", (object) value);
        this.OnPropertyChanged(nameof (AccessMode));
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

    [AttributeLogicalName("serviceplanid")]
    public Guid? ServicePlanId
    {
      get => this.GetAttributeValue<Guid?>("serviceplanid");
      set
      {
        this.OnPropertyChanging(nameof (ServicePlanId));
        this.SetAttributeValue("serviceplanid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ServicePlanId));
      }
    }

    [AttributeLogicalName("serviceplanid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ServicePlanId = new Guid?(value);
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

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

    [RelationshipSchemaName("serviceplan_AsyncOperations")]
    public IEnumerable<AsyncOperation> serviceplan_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (serviceplan_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (serviceplan_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (serviceplan_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (serviceplan_AsyncOperations));
      }
    }

    [RelationshipSchemaName("serviceplan_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> serviceplan_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (serviceplan_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (serviceplan_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (serviceplan_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (serviceplan_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("serviceplan_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> serviceplan_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (serviceplan_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (serviceplan_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (serviceplan_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (serviceplan_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("serviceplan_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> serviceplan_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (serviceplan_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (serviceplan_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (serviceplan_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (serviceplan_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("serviceplan_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> serviceplan_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (serviceplan_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (serviceplan_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (serviceplan_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (serviceplan_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("serviceplan_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> serviceplan_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (serviceplan_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (serviceplan_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (serviceplan_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (serviceplan_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("serviceplan_ProcessSession")]
    public IEnumerable<ProcessSession> serviceplan_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (serviceplan_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (serviceplan_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (serviceplan_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (serviceplan_ProcessSession));
      }
    }

    [RelationshipSchemaName("serviceplan_SyncErrors")]
    public IEnumerable<SyncError> serviceplan_SyncErrors
    {
      get => this.GetRelatedEntities<SyncError>(nameof (serviceplan_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (serviceplan_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (serviceplan_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (serviceplan_SyncErrors));
      }
    }

    [RelationshipSchemaName("serviceplan_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> serviceplan_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (serviceplan_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (serviceplan_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (serviceplan_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (serviceplan_UserEntityInstanceDatas));
      }
    }

    [RelationshipSchemaName("serviceplan_appmodule")]
    public IEnumerable<AppModule> serviceplan_appmodule
    {
      get => this.GetRelatedEntities<AppModule>(nameof (serviceplan_appmodule), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (serviceplan_appmodule));
        this.SetRelatedEntities<AppModule>(nameof (serviceplan_appmodule), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (serviceplan_appmodule));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_serviceplan_createdby")]
    public SystemUser lk_serviceplan_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_serviceplan_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_serviceplan_createdonbehalfby")]
    public SystemUser lk_serviceplan_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_serviceplan_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_serviceplan_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_serviceplan_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_serviceplan_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_serviceplan_modifiedby")]
    public SystemUser lk_serviceplan_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_serviceplan_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_serviceplan_modifiedonbehalfby")]
    public SystemUser lk_serviceplan_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_serviceplan_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_serviceplan_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_serviceplan_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_serviceplan_modifiedonbehalfby));
      }
    }

    public ServicePlan(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["serviceplanid"] = (object) base.Id;
            break;
          case "serviceplanid":
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
