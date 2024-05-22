// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.AppModuleComponentEdge
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("appmodulecomponentedge")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class AppModuleComponentEdge : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "appmodulecomponentedge";
    public const string EntitySchemaName = "AppModuleComponentEdge";
    public const string PrimaryIdAttribute = "appmodulecomponentedgeid";
    public const string PrimaryNameAttribute = "name";

    public AppModuleComponentEdge()
      : base("appmodulecomponentedge")
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

    [AttributeLogicalName("appmodulecomponentedgeid")]
    public Guid? AppModuleComponentEdgeId
    {
      get => this.GetAttributeValue<Guid?>("appmodulecomponentedgeid");
      set
      {
        this.OnPropertyChanging(nameof (AppModuleComponentEdgeId));
        this.SetAttributeValue("appmodulecomponentedgeid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (AppModuleComponentEdgeId));
      }
    }

    [AttributeLogicalName("appmodulecomponentedgeid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.AppModuleComponentEdgeId = new Guid?(value);
    }

    [AttributeLogicalName("componentnodefrom")]
    public EntityReference ComponentNodeFrom
    {
      get => this.GetAttributeValue<EntityReference>("componentnodefrom");
      set
      {
        this.OnPropertyChanging(nameof (ComponentNodeFrom));
        this.SetAttributeValue("componentnodefrom", (object) value);
        this.OnPropertyChanged(nameof (ComponentNodeFrom));
      }
    }

    [AttributeLogicalName("componentnodeto")]
    public EntityReference ComponentNodeTo
    {
      get => this.GetAttributeValue<EntityReference>("componentnodeto");
      set
      {
        this.OnPropertyChanging(nameof (ComponentNodeTo));
        this.SetAttributeValue("componentnodeto", (object) value);
        this.OnPropertyChanged(nameof (ComponentNodeTo));
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

    [AttributeLogicalName("statecode")]
    public AppModuleComponentEdgeState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new AppModuleComponentEdgeState?((AppModuleComponentEdgeState) Enum.ToObject(typeof (AppModuleComponentEdgeState), attributeValue.Value)) : new AppModuleComponentEdgeState?();
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

    [RelationshipSchemaName("appmodulecomponentedge_AsyncOperations")]
    public IEnumerable<AsyncOperation> appmodulecomponentedge_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (appmodulecomponentedge_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appmodulecomponentedge_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (appmodulecomponentedge_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appmodulecomponentedge_AsyncOperations));
      }
    }

    [RelationshipSchemaName("appmodulecomponentedge_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> appmodulecomponentedge_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (appmodulecomponentedge_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appmodulecomponentedge_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (appmodulecomponentedge_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appmodulecomponentedge_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("appmodulecomponentedge_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> appmodulecomponentedge_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (appmodulecomponentedge_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appmodulecomponentedge_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (appmodulecomponentedge_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appmodulecomponentedge_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("appmodulecomponentedge_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> appmodulecomponentedge_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (appmodulecomponentedge_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appmodulecomponentedge_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (appmodulecomponentedge_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appmodulecomponentedge_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("appmodulecomponentedge_ProcessSession")]
    public IEnumerable<ProcessSession> appmodulecomponentedge_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (appmodulecomponentedge_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appmodulecomponentedge_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (appmodulecomponentedge_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appmodulecomponentedge_ProcessSession));
      }
    }

    [RelationshipSchemaName("appmodulecomponentedge_SyncErrors")]
    public IEnumerable<SyncError> appmodulecomponentedge_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (appmodulecomponentedge_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appmodulecomponentedge_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (appmodulecomponentedge_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appmodulecomponentedge_SyncErrors));
      }
    }

    [RelationshipSchemaName("appmodulecomponentedge_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> appmodulecomponentedge_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (appmodulecomponentedge_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appmodulecomponentedge_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (appmodulecomponentedge_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appmodulecomponentedge_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("componentnodefrom")]
    [RelationshipSchemaName("appmodulecomponentnode_appmodulecomponentedge_ComponentNodeFrom")]
    public AppModuleComponentNode appmodulecomponentnode_appmodulecomponentedge_ComponentNodeFrom
    {
      get
      {
        return this.GetRelatedEntity<AppModuleComponentNode>(nameof (appmodulecomponentnode_appmodulecomponentedge_ComponentNodeFrom), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appmodulecomponentnode_appmodulecomponentedge_ComponentNodeFrom));
        this.SetRelatedEntity<AppModuleComponentNode>(nameof (appmodulecomponentnode_appmodulecomponentedge_ComponentNodeFrom), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appmodulecomponentnode_appmodulecomponentedge_ComponentNodeFrom));
      }
    }

    [AttributeLogicalName("componentnodeto")]
    [RelationshipSchemaName("appmodulecomponentnode_appmodulecomponentedge_ComponentNodeTo")]
    public AppModuleComponentNode appmodulecomponentnode_appmodulecomponentedge_ComponentNodeTo
    {
      get
      {
        return this.GetRelatedEntity<AppModuleComponentNode>(nameof (appmodulecomponentnode_appmodulecomponentedge_ComponentNodeTo), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appmodulecomponentnode_appmodulecomponentedge_ComponentNodeTo));
        this.SetRelatedEntity<AppModuleComponentNode>(nameof (appmodulecomponentnode_appmodulecomponentedge_ComponentNodeTo), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appmodulecomponentnode_appmodulecomponentedge_ComponentNodeTo));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_appmodulecomponentedge_createdby")]
    public SystemUser lk_appmodulecomponentedge_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_appmodulecomponentedge_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_appmodulecomponentedge_createdonbehalfby")]
    public SystemUser lk_appmodulecomponentedge_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_appmodulecomponentedge_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_appmodulecomponentedge_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_appmodulecomponentedge_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_appmodulecomponentedge_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_appmodulecomponentedge_modifiedby")]
    public SystemUser lk_appmodulecomponentedge_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_appmodulecomponentedge_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_appmodulecomponentedge_modifiedonbehalfby")]
    public SystemUser lk_appmodulecomponentedge_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_appmodulecomponentedge_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_appmodulecomponentedge_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_appmodulecomponentedge_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_appmodulecomponentedge_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_appmodulecomponentedge")]
    public Organization organization_appmodulecomponentedge
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_appmodulecomponentedge), new EntityRole?());
      }
    }

    public AppModuleComponentEdge(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["appmodulecomponentedgeid"] = (object) base.Id;
            break;
          case "appmodulecomponentedgeid":
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
