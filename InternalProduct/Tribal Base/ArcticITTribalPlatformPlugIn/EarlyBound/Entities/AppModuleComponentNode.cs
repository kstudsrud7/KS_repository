// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.AppModuleComponentNode
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("appmodulecomponentnode")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class AppModuleComponentNode : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "appmodulecomponentnode";
    public const string EntitySchemaName = "AppModuleComponentNode";
    public const string PrimaryIdAttribute = "appmodulecomponentnodeid";
    public const string PrimaryNameAttribute = "name";

    public AppModuleComponentNode()
      : base("appmodulecomponentnode")
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

    [AttributeLogicalName("appmodulecomponentnodeid")]
    public Guid? AppModuleComponentNodeId
    {
      get => this.GetAttributeValue<Guid?>("appmodulecomponentnodeid");
      set
      {
        this.OnPropertyChanging(nameof (AppModuleComponentNodeId));
        this.SetAttributeValue("appmodulecomponentnodeid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (AppModuleComponentNodeId));
      }
    }

    [AttributeLogicalName("appmodulecomponentnodeid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.AppModuleComponentNodeId = new Guid?(value);
    }

    [AttributeLogicalName("componentdatabaseversion")]
    public string ComponentDatabaseVersion
    {
      get => this.GetAttributeValue<string>("componentdatabaseversion");
      set
      {
        this.OnPropertyChanging(nameof (ComponentDatabaseVersion));
        this.SetAttributeValue("componentdatabaseversion", (object) value);
        this.OnPropertyChanged(nameof (ComponentDatabaseVersion));
      }
    }

    [AttributeLogicalName("componentobjectid")]
    public string ComponentObjectId
    {
      get => this.GetAttributeValue<string>("componentobjectid");
      set
      {
        this.OnPropertyChanging(nameof (ComponentObjectId));
        this.SetAttributeValue("componentobjectid", (object) value);
        this.OnPropertyChanged(nameof (ComponentObjectId));
      }
    }

    [AttributeLogicalName("componenttype")]
    public int? ComponentType
    {
      get => this.GetAttributeValue<int?>("componenttype");
      set
      {
        this.OnPropertyChanging(nameof (ComponentType));
        this.SetAttributeValue("componenttype", (object) value);
        this.OnPropertyChanged(nameof (ComponentType));
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

    [AttributeLogicalName("snapshotversionnumber")]
    public int? SnapshotVersionNumber
    {
      get => this.GetAttributeValue<int?>("snapshotversionnumber");
      set
      {
        this.OnPropertyChanging(nameof (SnapshotVersionNumber));
        this.SetAttributeValue("snapshotversionnumber", (object) value);
        this.OnPropertyChanged(nameof (SnapshotVersionNumber));
      }
    }

    [AttributeLogicalName("statecode")]
    public AppModuleComponentNodeState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new AppModuleComponentNodeState?((AppModuleComponentNodeState) Enum.ToObject(typeof (AppModuleComponentNodeState), attributeValue.Value)) : new AppModuleComponentNodeState?();
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

    [AttributeLogicalName("validationresult")]
    public string ValidationResult
    {
      get => this.GetAttributeValue<string>("validationresult");
      set
      {
        this.OnPropertyChanging(nameof (ValidationResult));
        this.SetAttributeValue("validationresult", (object) value);
        this.OnPropertyChanged(nameof (ValidationResult));
      }
    }

    [AttributeLogicalName("validationstatus")]
    public OptionSetValue ValidationStatus
    {
      get => this.GetAttributeValue<OptionSetValue>("validationstatus");
      set
      {
        this.OnPropertyChanging(nameof (ValidationStatus));
        this.SetAttributeValue("validationstatus", (object) value);
        this.OnPropertyChanged(nameof (ValidationStatus));
      }
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("appmodulecomponentnode_appmodulecomponentedge_ComponentNodeFrom")]
    public IEnumerable<AppModuleComponentEdge> appmodulecomponentnode_appmodulecomponentedge_ComponentNodeFrom
    {
      get
      {
        return this.GetRelatedEntities<AppModuleComponentEdge>(nameof (appmodulecomponentnode_appmodulecomponentedge_ComponentNodeFrom), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appmodulecomponentnode_appmodulecomponentedge_ComponentNodeFrom));
        this.SetRelatedEntities<AppModuleComponentEdge>(nameof (appmodulecomponentnode_appmodulecomponentedge_ComponentNodeFrom), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appmodulecomponentnode_appmodulecomponentedge_ComponentNodeFrom));
      }
    }

    [RelationshipSchemaName("appmodulecomponentnode_appmodulecomponentedge_ComponentNodeTo")]
    public IEnumerable<AppModuleComponentEdge> appmodulecomponentnode_appmodulecomponentedge_ComponentNodeTo
    {
      get
      {
        return this.GetRelatedEntities<AppModuleComponentEdge>(nameof (appmodulecomponentnode_appmodulecomponentedge_ComponentNodeTo), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appmodulecomponentnode_appmodulecomponentedge_ComponentNodeTo));
        this.SetRelatedEntities<AppModuleComponentEdge>(nameof (appmodulecomponentnode_appmodulecomponentedge_ComponentNodeTo), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appmodulecomponentnode_appmodulecomponentedge_ComponentNodeTo));
      }
    }

    [RelationshipSchemaName("appmodulecomponentnode_AsyncOperations")]
    public IEnumerable<AsyncOperation> appmodulecomponentnode_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (appmodulecomponentnode_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appmodulecomponentnode_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (appmodulecomponentnode_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appmodulecomponentnode_AsyncOperations));
      }
    }

    [RelationshipSchemaName("appmodulecomponentnode_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> appmodulecomponentnode_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (appmodulecomponentnode_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appmodulecomponentnode_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (appmodulecomponentnode_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appmodulecomponentnode_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("appmodulecomponentnode_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> appmodulecomponentnode_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (appmodulecomponentnode_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appmodulecomponentnode_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (appmodulecomponentnode_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appmodulecomponentnode_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("appmodulecomponentnode_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> appmodulecomponentnode_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (appmodulecomponentnode_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appmodulecomponentnode_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (appmodulecomponentnode_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appmodulecomponentnode_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("appmodulecomponentnode_ProcessSession")]
    public IEnumerable<ProcessSession> appmodulecomponentnode_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (appmodulecomponentnode_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appmodulecomponentnode_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (appmodulecomponentnode_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appmodulecomponentnode_ProcessSession));
      }
    }

    [RelationshipSchemaName("appmodulecomponentnode_SyncErrors")]
    public IEnumerable<SyncError> appmodulecomponentnode_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (appmodulecomponentnode_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appmodulecomponentnode_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (appmodulecomponentnode_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appmodulecomponentnode_SyncErrors));
      }
    }

    [RelationshipSchemaName("appmodulecomponentnode_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> appmodulecomponentnode_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (appmodulecomponentnode_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appmodulecomponentnode_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (appmodulecomponentnode_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appmodulecomponentnode_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_appmodulecomponentnode_createdby")]
    public SystemUser lk_appmodulecomponentnode_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_appmodulecomponentnode_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_appmodulecomponentnode_createdonbehalfby")]
    public SystemUser lk_appmodulecomponentnode_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_appmodulecomponentnode_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_appmodulecomponentnode_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_appmodulecomponentnode_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_appmodulecomponentnode_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_appmodulecomponentnode_modifiedby")]
    public SystemUser lk_appmodulecomponentnode_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_appmodulecomponentnode_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_appmodulecomponentnode_modifiedonbehalfby")]
    public SystemUser lk_appmodulecomponentnode_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_appmodulecomponentnode_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_appmodulecomponentnode_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_appmodulecomponentnode_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_appmodulecomponentnode_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_appmodulecomponentnode")]
    public Organization organization_appmodulecomponentnode
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_appmodulecomponentnode), new EntityRole?());
      }
    }

    public AppModuleComponentNode(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["appmodulecomponentnodeid"] = (object) base.Id;
            break;
          case "appmodulecomponentnodeid":
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
