// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.AppElement
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("appelement")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class AppElement : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "appelement";
    public const string EntitySchemaName = "AppElement";
    public const string PrimaryIdAttribute = "appelementid";
    public const string PrimaryNameAttribute = "name";

    public AppElement()
      : base("appelement")
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

    [AttributeLogicalName("appelementid")]
    public Guid? AppElementId
    {
      get => this.GetAttributeValue<Guid?>("appelementid");
      set
      {
        this.OnPropertyChanging(nameof (AppElementId));
        this.SetAttributeValue("appelementid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (AppElementId));
      }
    }

    [AttributeLogicalName("appelementid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.AppElementId = new Guid?(value);
    }

    [AttributeLogicalName("canvasappid")]
    public EntityReference CanvasAppId
    {
      get => this.GetAttributeValue<EntityReference>("canvasappid");
      set
      {
        this.OnPropertyChanging(nameof (CanvasAppId));
        this.SetAttributeValue("canvasappid", (object) value);
        this.OnPropertyChanged(nameof (CanvasAppId));
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

    [AttributeLogicalName("parentappmoduleid")]
    public EntityReference ParentAppModuleId
    {
      get => this.GetAttributeValue<EntityReference>("parentappmoduleid");
      set
      {
        this.OnPropertyChanging(nameof (ParentAppModuleId));
        this.SetAttributeValue("parentappmoduleid", (object) value);
        this.OnPropertyChanged(nameof (ParentAppModuleId));
      }
    }

    [AttributeLogicalName("publishconfiguration")]
    public string PublishConfiguration
    {
      get => this.GetAttributeValue<string>("publishconfiguration");
      set
      {
        this.OnPropertyChanging(nameof (PublishConfiguration));
        this.SetAttributeValue("publishconfiguration", (object) value);
        this.OnPropertyChanged(nameof (PublishConfiguration));
      }
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("statecode")]
    public AppElementState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new AppElementState?((AppElementState) Enum.ToObject(typeof (AppElementState), attributeValue.Value)) : new AppElementState?();
      }
    }

    [AttributeLogicalName("statuscode")]
    public OptionSetValue StatusCode => this.GetAttributeValue<OptionSetValue>("statuscode");

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

    [RelationshipSchemaName("appelement_AsyncOperations")]
    public IEnumerable<AsyncOperation> appelement_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (appelement_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appelement_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (appelement_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appelement_AsyncOperations));
      }
    }

    [RelationshipSchemaName("appelement_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> appelement_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (appelement_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appelement_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (appelement_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appelement_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("appelement_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> appelement_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (appelement_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appelement_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (appelement_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appelement_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("appelement_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> appelement_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (appelement_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appelement_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (appelement_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appelement_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("appelement_ProcessSession")]
    public IEnumerable<ProcessSession> appelement_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (appelement_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appelement_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (appelement_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appelement_ProcessSession));
      }
    }

    [RelationshipSchemaName("appelement_SyncErrors")]
    public IEnumerable<SyncError> appelement_SyncErrors
    {
      get => this.GetRelatedEntities<SyncError>(nameof (appelement_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (appelement_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (appelement_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appelement_SyncErrors));
      }
    }

    [RelationshipSchemaName("appelement_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> appelement_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (appelement_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appelement_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (appelement_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appelement_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("parentappmoduleid")]
    [RelationshipSchemaName("appmodule_appelement_parentappmoduleid")]
    public AppModule appmodule_appelement_parentappmoduleid
    {
      get
      {
        return this.GetRelatedEntity<AppModule>(nameof (appmodule_appelement_parentappmoduleid), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appmodule_appelement_parentappmoduleid));
        this.SetRelatedEntity<AppModule>(nameof (appmodule_appelement_parentappmoduleid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appmodule_appelement_parentappmoduleid));
      }
    }

    [AttributeLogicalName("canvasappid")]
    [RelationshipSchemaName("canvasapp_appelement_canvasappid")]
    public CanvasApp canvasapp_appelement_canvasappid
    {
      get
      {
        return this.GetRelatedEntity<CanvasApp>(nameof (canvasapp_appelement_canvasappid), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (canvasapp_appelement_canvasappid));
        this.SetRelatedEntity<CanvasApp>(nameof (canvasapp_appelement_canvasappid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (canvasapp_appelement_canvasappid));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_appelement_createdby")]
    public SystemUser lk_appelement_createdby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_appelement_createdby), new EntityRole?());
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_appelement_createdonbehalfby")]
    public SystemUser lk_appelement_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_appelement_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_appelement_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_appelement_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_appelement_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_appelement_modifiedby")]
    public SystemUser lk_appelement_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_appelement_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_appelement_modifiedonbehalfby")]
    public SystemUser lk_appelement_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_appelement_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_appelement_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_appelement_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_appelement_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_appelement")]
    public Organization organization_appelement
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_appelement), new EntityRole?());
      }
    }

    public AppElement(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["appelementid"] = (object) base.Id;
            break;
          case "appelementid":
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
