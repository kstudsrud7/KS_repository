// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.connectionreference
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("connectionreference")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class connectionreference : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "connectionreference";
    public const string EntitySchemaName = "connectionreference";
    public const string PrimaryIdAttribute = "connectionreferenceid";
    public const string PrimaryNameAttribute = "connectionreferencedisplayname";

    public connectionreference()
      : base(nameof (connectionreference))
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

    [AttributeLogicalName("connectionid")]
    public string ConnectionId
    {
      get => this.GetAttributeValue<string>("connectionid");
      set
      {
        this.OnPropertyChanging(nameof (ConnectionId));
        this.SetAttributeValue("connectionid", (object) value);
        this.OnPropertyChanged(nameof (ConnectionId));
      }
    }

    [AttributeLogicalName("connectionreferencedisplayname")]
    public string connectionreferencedisplayname
    {
      get => this.GetAttributeValue<string>(nameof (connectionreferencedisplayname));
      set
      {
        this.OnPropertyChanging(nameof (connectionreferencedisplayname));
        this.SetAttributeValue(nameof (connectionreferencedisplayname), (object) value);
        this.OnPropertyChanged(nameof (connectionreferencedisplayname));
      }
    }

    [AttributeLogicalName("connectionreferenceid")]
    public Guid? connectionreferenceId
    {
      get => this.GetAttributeValue<Guid?>("connectionreferenceid");
      set
      {
        this.OnPropertyChanging(nameof (connectionreferenceId));
        this.SetAttributeValue("connectionreferenceid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (connectionreferenceId));
      }
    }

    [AttributeLogicalName("connectionreferenceid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.connectionreferenceId = new Guid?(value);
    }

    [AttributeLogicalName("connectionreferencelogicalname")]
    public string ConnectionReferenceLogicalName
    {
      get => this.GetAttributeValue<string>("connectionreferencelogicalname");
      set
      {
        this.OnPropertyChanging(nameof (ConnectionReferenceLogicalName));
        this.SetAttributeValue("connectionreferencelogicalname", (object) value);
        this.OnPropertyChanged(nameof (ConnectionReferenceLogicalName));
      }
    }

    [AttributeLogicalName("connectorid")]
    public string ConnectorId
    {
      get => this.GetAttributeValue<string>("connectorid");
      set
      {
        this.OnPropertyChanging(nameof (ConnectorId));
        this.SetAttributeValue("connectorid", (object) value);
        this.OnPropertyChanged(nameof (ConnectorId));
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

    [AttributeLogicalName("customconnectorid")]
    public EntityReference CustomConnectorId
    {
      get => this.GetAttributeValue<EntityReference>("customconnectorid");
      set
      {
        this.OnPropertyChanging(nameof (CustomConnectorId));
        this.SetAttributeValue("customconnectorid", (object) value);
        this.OnPropertyChanged(nameof (CustomConnectorId));
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

    [AttributeLogicalName("ownerid")]
    public EntityReference OwnerId
    {
      get => this.GetAttributeValue<EntityReference>("ownerid");
      set
      {
        this.OnPropertyChanging(nameof (OwnerId));
        this.SetAttributeValue("ownerid", (object) value);
        this.OnPropertyChanged(nameof (OwnerId));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    public EntityReference OwningBusinessUnit
    {
      get => this.GetAttributeValue<EntityReference>("owningbusinessunit");
    }

    [AttributeLogicalName("owningteam")]
    public EntityReference OwningTeam => this.GetAttributeValue<EntityReference>("owningteam");

    [AttributeLogicalName("owninguser")]
    public EntityReference OwningUser => this.GetAttributeValue<EntityReference>("owninguser");

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("statecode")]
    public connectionreferenceState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new connectionreferenceState?((connectionreferenceState) Enum.ToObject(typeof (connectionreferenceState), attributeValue.Value)) : new connectionreferenceState?();
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

    [RelationshipSchemaName("connectionreference_AsyncOperations")]
    public IEnumerable<AsyncOperation> connectionreference_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (connectionreference_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (connectionreference_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (connectionreference_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (connectionreference_AsyncOperations));
      }
    }

    [RelationshipSchemaName("connectionreference_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> connectionreference_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (connectionreference_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (connectionreference_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (connectionreference_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (connectionreference_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("connectionreference_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> connectionreference_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (connectionreference_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (connectionreference_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (connectionreference_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (connectionreference_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("connectionreference_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> connectionreference_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (connectionreference_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (connectionreference_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (connectionreference_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (connectionreference_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("connectionreference_ProcessSession")]
    public IEnumerable<ProcessSession> connectionreference_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (connectionreference_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (connectionreference_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (connectionreference_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (connectionreference_ProcessSession));
      }
    }

    [RelationshipSchemaName("connectionreference_SyncErrors")]
    public IEnumerable<SyncError> connectionreference_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (connectionreference_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (connectionreference_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (connectionreference_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (connectionreference_SyncErrors));
      }
    }

    [RelationshipSchemaName("connectionreference_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> connectionreference_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (connectionreference_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (connectionreference_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (connectionreference_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (connectionreference_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_connectionreference")]
    public BusinessUnit business_unit_connectionreference
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_connectionreference), new EntityRole?());
      }
    }

    [AttributeLogicalName("customconnectorid")]
    [RelationshipSchemaName("connector_connectionreference")]
    public connector connector_connectionreference
    {
      get
      {
        return this.GetRelatedEntity<connector>(nameof (connector_connectionreference), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (connector_connectionreference));
        this.SetRelatedEntity<connector>(nameof (connector_connectionreference), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (connector_connectionreference));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_connectionreference_createdby")]
    public SystemUser lk_connectionreference_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_connectionreference_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_connectionreference_createdonbehalfby")]
    public SystemUser lk_connectionreference_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_connectionreference_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_connectionreference_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_connectionreference_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_connectionreference_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_connectionreference_modifiedby")]
    public SystemUser lk_connectionreference_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_connectionreference_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_connectionreference_modifiedonbehalfby")]
    public SystemUser lk_connectionreference_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_connectionreference_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_connectionreference_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_connectionreference_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_connectionreference_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_connectionreference")]
    public Team team_connectionreference
    {
      get => this.GetRelatedEntity<Team>(nameof (team_connectionreference), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_connectionreference")]
    public SystemUser user_connectionreference
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_connectionreference), new EntityRole?());
      }
    }

    public connectionreference(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["connectionreferenceid"] = (object) base.Id;
            break;
          case "connectionreferenceid":
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
