// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.botcomponent
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("botcomponent")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class botcomponent : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "botcomponent";
    public const string EntitySchemaName = "botcomponent";
    public const string PrimaryIdAttribute = "botcomponentid";
    public const string PrimaryNameAttribute = "name";

    public botcomponent()
      : base(nameof (botcomponent))
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

    [AttributeLogicalName("botcomponentid")]
    public Guid? botcomponentId
    {
      get => this.GetAttributeValue<Guid?>("botcomponentid");
      set
      {
        this.OnPropertyChanging(nameof (botcomponentId));
        this.SetAttributeValue("botcomponentid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (botcomponentId));
      }
    }

    [AttributeLogicalName("botcomponentid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.botcomponentId = new Guid?(value);
    }

    [AttributeLogicalName("category")]
    public string Category
    {
      get => this.GetAttributeValue<string>("category");
      set
      {
        this.OnPropertyChanging(nameof (Category));
        this.SetAttributeValue("category", (object) value);
        this.OnPropertyChanged(nameof (Category));
      }
    }

    [AttributeLogicalName("componentidunique")]
    public Guid? ComponentIdUnique => this.GetAttributeValue<Guid?>("componentidunique");

    [AttributeLogicalName("componentstate")]
    public OptionSetValue ComponentState
    {
      get => this.GetAttributeValue<OptionSetValue>("componentstate");
    }

    [AttributeLogicalName("componenttype")]
    public OptionSetValue ComponentType
    {
      get => this.GetAttributeValue<OptionSetValue>("componenttype");
      set
      {
        this.OnPropertyChanging(nameof (ComponentType));
        this.SetAttributeValue("componenttype", (object) value);
        this.OnPropertyChanged(nameof (ComponentType));
      }
    }

    [AttributeLogicalName("content")]
    public string Content
    {
      get => this.GetAttributeValue<string>("content");
      set
      {
        this.OnPropertyChanging(nameof (Content));
        this.SetAttributeValue("content", (object) value);
        this.OnPropertyChanged(nameof (Content));
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

    [AttributeLogicalName("data")]
    public string Data
    {
      get => this.GetAttributeValue<string>("data");
      set
      {
        this.OnPropertyChanging(nameof (Data));
        this.SetAttributeValue("data", (object) value);
        this.OnPropertyChanged(nameof (Data));
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

    [AttributeLogicalName("language")]
    public OptionSetValue Language
    {
      get => this.GetAttributeValue<OptionSetValue>("language");
      set
      {
        this.OnPropertyChanging(nameof (Language));
        this.SetAttributeValue("language", (object) value);
        this.OnPropertyChanged(nameof (Language));
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

    [AttributeLogicalName("parentbotcomponentid")]
    public EntityReference ParentBotComponentId
    {
      get => this.GetAttributeValue<EntityReference>("parentbotcomponentid");
      set
      {
        this.OnPropertyChanging(nameof (ParentBotComponentId));
        this.SetAttributeValue("parentbotcomponentid", (object) value);
        this.OnPropertyChanged(nameof (ParentBotComponentId));
      }
    }

    [AttributeLogicalName("schemaname")]
    public string SchemaName
    {
      get => this.GetAttributeValue<string>("schemaname");
      set
      {
        this.OnPropertyChanging(nameof (SchemaName));
        this.SetAttributeValue("schemaname", (object) value);
        this.OnPropertyChanged(nameof (SchemaName));
      }
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("statecode")]
    public botcomponentState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new botcomponentState?((botcomponentState) Enum.ToObject(typeof (botcomponentState), attributeValue.Value)) : new botcomponentState?();
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

    [RelationshipSchemaName("botcomponent_AsyncOperations")]
    public IEnumerable<AsyncOperation> botcomponent_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (botcomponent_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (botcomponent_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (botcomponent_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (botcomponent_AsyncOperations));
      }
    }

    [RelationshipSchemaName("botcomponent_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> botcomponent_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (botcomponent_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (botcomponent_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (botcomponent_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (botcomponent_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("botcomponent_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> botcomponent_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (botcomponent_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (botcomponent_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (botcomponent_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (botcomponent_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName]
    public IEnumerable<botcomponent> Referencedbotcomponent_parent_botcomponent
    {
      get
      {
        return this.GetRelatedEntities<botcomponent>("botcomponent_parent_botcomponent", new EntityRole?((EntityRole) 1));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencedbotcomponent_parent_botcomponent));
        this.SetRelatedEntities<botcomponent>("botcomponent_parent_botcomponent", new EntityRole?((EntityRole) 1), value);
        this.OnPropertyChanged(nameof (Referencedbotcomponent_parent_botcomponent));
      }
    }

    [RelationshipSchemaName("botcomponent_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> botcomponent_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (botcomponent_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (botcomponent_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (botcomponent_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (botcomponent_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("botcomponent_ProcessSession")]
    public IEnumerable<ProcessSession> botcomponent_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (botcomponent_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (botcomponent_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (botcomponent_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (botcomponent_ProcessSession));
      }
    }

    [RelationshipSchemaName("botcomponent_SyncErrors")]
    public IEnumerable<SyncError> botcomponent_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (botcomponent_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (botcomponent_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (botcomponent_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (botcomponent_SyncErrors));
      }
    }

    [RelationshipSchemaName("botcomponent_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> botcomponent_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (botcomponent_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (botcomponent_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (botcomponent_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (botcomponent_UserEntityInstanceDatas));
      }
    }

    [RelationshipSchemaName("bot_botcomponent")]
    public IEnumerable<bot> bot_botcomponent
    {
      get => this.GetRelatedEntities<bot>(nameof (bot_botcomponent), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (bot_botcomponent));
        this.SetRelatedEntities<bot>(nameof (bot_botcomponent), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (bot_botcomponent));
      }
    }

    [RelationshipSchemaName]
    public IEnumerable<botcomponent> Referencingbotcomponent_botcomponent
    {
      get
      {
        return this.GetRelatedEntities<botcomponent>("botcomponent_botcomponent", new EntityRole?((EntityRole) 0));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencingbotcomponent_botcomponent));
        this.SetRelatedEntities<botcomponent>("botcomponent_botcomponent", new EntityRole?((EntityRole) 0), value);
        this.OnPropertyChanged(nameof (Referencingbotcomponent_botcomponent));
      }
    }

    [RelationshipSchemaName]
    public IEnumerable<botcomponent> Referencedbotcomponent_botcomponent
    {
      get
      {
        return this.GetRelatedEntities<botcomponent>("botcomponent_botcomponent", new EntityRole?((EntityRole) 1));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencedbotcomponent_botcomponent));
        this.SetRelatedEntities<botcomponent>("botcomponent_botcomponent", new EntityRole?((EntityRole) 1), value);
        this.OnPropertyChanged(nameof (Referencedbotcomponent_botcomponent));
      }
    }

    [RelationshipSchemaName("botcomponent_workflow")]
    public IEnumerable<Workflow> botcomponent_workflow
    {
      get => this.GetRelatedEntities<Workflow>(nameof (botcomponent_workflow), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (botcomponent_workflow));
        this.SetRelatedEntities<Workflow>(nameof (botcomponent_workflow), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (botcomponent_workflow));
      }
    }

    [AttributeLogicalName("parentbotcomponentid")]
    [RelationshipSchemaName]
    public botcomponent Referencingbotcomponent_parent_botcomponent
    {
      get
      {
        return this.GetRelatedEntity<botcomponent>("botcomponent_parent_botcomponent", new EntityRole?((EntityRole) 0));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencingbotcomponent_parent_botcomponent));
        this.SetRelatedEntity<botcomponent>("botcomponent_parent_botcomponent", new EntityRole?((EntityRole) 0), value);
        this.OnPropertyChanged(nameof (Referencingbotcomponent_parent_botcomponent));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_botcomponent")]
    public BusinessUnit business_unit_botcomponent
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_botcomponent), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_botcomponent_createdby")]
    public SystemUser lk_botcomponent_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_botcomponent_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_botcomponent_createdonbehalfby")]
    public SystemUser lk_botcomponent_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_botcomponent_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_botcomponent_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_botcomponent_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_botcomponent_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_botcomponent_modifiedby")]
    public SystemUser lk_botcomponent_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_botcomponent_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_botcomponent_modifiedonbehalfby")]
    public SystemUser lk_botcomponent_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_botcomponent_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_botcomponent_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_botcomponent_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_botcomponent_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_botcomponent")]
    public Team team_botcomponent
    {
      get => this.GetRelatedEntity<Team>(nameof (team_botcomponent), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_botcomponent")]
    public SystemUser user_botcomponent
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_botcomponent), new EntityRole?());
    }

    public botcomponent(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["botcomponentid"] = (object) base.Id;
            break;
          case "botcomponentid":
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
