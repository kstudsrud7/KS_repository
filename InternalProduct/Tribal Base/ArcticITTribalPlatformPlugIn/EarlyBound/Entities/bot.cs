// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.bot
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("bot")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class bot : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "bot";
    public const string EntitySchemaName = "bot";
    public const string PrimaryIdAttribute = "botid";
    public const string PrimaryNameAttribute = "name";

    public bot()
      : base(nameof (bot))
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

    [AttributeLogicalName("accesscontrolpolicy")]
    public OptionSetValue accesscontrolpolicy
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (accesscontrolpolicy));
      set
      {
        this.OnPropertyChanging(nameof (accesscontrolpolicy));
        this.SetAttributeValue(nameof (accesscontrolpolicy), (object) value);
        this.OnPropertyChanged(nameof (accesscontrolpolicy));
      }
    }

    [AttributeLogicalName("applicationmanifestinformation")]
    public string applicationmanifestinformation
    {
      get => this.GetAttributeValue<string>(nameof (applicationmanifestinformation));
      set
      {
        this.OnPropertyChanging(nameof (applicationmanifestinformation));
        this.SetAttributeValue(nameof (applicationmanifestinformation), (object) value);
        this.OnPropertyChanged(nameof (applicationmanifestinformation));
      }
    }

    [AttributeLogicalName("authenticationmode")]
    public OptionSetValue authenticationmode
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (authenticationmode));
      set
      {
        this.OnPropertyChanging(nameof (authenticationmode));
        this.SetAttributeValue(nameof (authenticationmode), (object) value);
        this.OnPropertyChanged(nameof (authenticationmode));
      }
    }

    [AttributeLogicalName("authenticationtrigger")]
    public OptionSetValue authenticationtrigger
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (authenticationtrigger));
      set
      {
        this.OnPropertyChanging(nameof (authenticationtrigger));
        this.SetAttributeValue(nameof (authenticationtrigger), (object) value);
        this.OnPropertyChanged(nameof (authenticationtrigger));
      }
    }

    [AttributeLogicalName("authorizedsecuritygroupids")]
    public string authorizedsecuritygroupids
    {
      get => this.GetAttributeValue<string>(nameof (authorizedsecuritygroupids));
      set
      {
        this.OnPropertyChanging(nameof (authorizedsecuritygroupids));
        this.SetAttributeValue(nameof (authorizedsecuritygroupids), (object) value);
        this.OnPropertyChanged(nameof (authorizedsecuritygroupids));
      }
    }

    [AttributeLogicalName("botid")]
    public Guid? botId
    {
      get => this.GetAttributeValue<Guid?>("botid");
      set
      {
        this.OnPropertyChanging(nameof (botId));
        this.SetAttributeValue("botid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (botId));
      }
    }

    [AttributeLogicalName("botid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.botId = new Guid?(value);
    }

    [AttributeLogicalName("componentidunique")]
    public Guid? ComponentIdUnique => this.GetAttributeValue<Guid?>("componentidunique");

    [AttributeLogicalName("componentstate")]
    public OptionSetValue ComponentState
    {
      get => this.GetAttributeValue<OptionSetValue>("componentstate");
    }

    [AttributeLogicalName("configuration")]
    public string Configuration
    {
      get => this.GetAttributeValue<string>("configuration");
      set
      {
        this.OnPropertyChanging(nameof (Configuration));
        this.SetAttributeValue("configuration", (object) value);
        this.OnPropertyChanged(nameof (Configuration));
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

    [AttributeLogicalName("iconbase64")]
    public string iconbase64
    {
      get => this.GetAttributeValue<string>(nameof (iconbase64));
      set
      {
        this.OnPropertyChanging(nameof (iconbase64));
        this.SetAttributeValue(nameof (iconbase64), (object) value);
        this.OnPropertyChanged(nameof (iconbase64));
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

    [AttributeLogicalName("publishedby")]
    public EntityReference publishedby
    {
      get => this.GetAttributeValue<EntityReference>(nameof (publishedby));
      set
      {
        this.OnPropertyChanging(nameof (publishedby));
        this.SetAttributeValue(nameof (publishedby), (object) value);
        this.OnPropertyChanged(nameof (publishedby));
      }
    }

    [AttributeLogicalName("publishedon")]
    public DateTime? publishedon
    {
      get => this.GetAttributeValue<DateTime?>(nameof (publishedon));
      set
      {
        this.OnPropertyChanging(nameof (publishedon));
        this.SetAttributeValue(nameof (publishedon), (object) value);
        this.OnPropertyChanged(nameof (publishedon));
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
    public botState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new botState?((botState) Enum.ToObject(typeof (botState), attributeValue.Value)) : new botState?();
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

    [RelationshipSchemaName("bot_AsyncOperations")]
    public IEnumerable<AsyncOperation> bot_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (bot_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (bot_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (bot_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (bot_AsyncOperations));
      }
    }

    [RelationshipSchemaName("bot_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> bot_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (bot_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (bot_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (bot_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (bot_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("bot_conversationtranscript")]
    public IEnumerable<conversationtranscript> bot_conversationtranscript
    {
      get
      {
        return this.GetRelatedEntities<conversationtranscript>(nameof (bot_conversationtranscript), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (bot_conversationtranscript));
        this.SetRelatedEntities<conversationtranscript>(nameof (bot_conversationtranscript), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (bot_conversationtranscript));
      }
    }

    [RelationshipSchemaName("bot_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> bot_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (bot_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (bot_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (bot_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (bot_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("bot_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> bot_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (bot_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (bot_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (bot_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (bot_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("bot_ProcessSession")]
    public IEnumerable<ProcessSession> bot_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (bot_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (bot_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (bot_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (bot_ProcessSession));
      }
    }

    [RelationshipSchemaName("bot_SyncErrors")]
    public IEnumerable<SyncError> bot_SyncErrors
    {
      get => this.GetRelatedEntities<SyncError>(nameof (bot_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (bot_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (bot_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (bot_SyncErrors));
      }
    }

    [RelationshipSchemaName("bot_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> bot_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (bot_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (bot_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (bot_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (bot_UserEntityInstanceDatas));
      }
    }

    [RelationshipSchemaName("bot_botcomponent")]
    public IEnumerable<botcomponent> bot_botcomponent
    {
      get => this.GetRelatedEntities<botcomponent>(nameof (bot_botcomponent), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (bot_botcomponent));
        this.SetRelatedEntities<botcomponent>(nameof (bot_botcomponent), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (bot_botcomponent));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_bot")]
    public BusinessUnit business_unit_bot
    {
      get => this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_bot), new EntityRole?());
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_bot_createdby")]
    public SystemUser lk_bot_createdby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_bot_createdby), new EntityRole?());
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_bot_createdonbehalfby")]
    public SystemUser lk_bot_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_bot_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_bot_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_bot_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_bot_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_bot_modifiedby")]
    public SystemUser lk_bot_modifiedby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_bot_modifiedby), new EntityRole?());
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_bot_modifiedonbehalfby")]
    public SystemUser lk_bot_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_bot_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_bot_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_bot_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_bot_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("publishedby")]
    [RelationshipSchemaName("systemuser_bot_publishedby")]
    public SystemUser systemuser_bot_publishedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (systemuser_bot_publishedby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (systemuser_bot_publishedby));
        this.SetRelatedEntity<SystemUser>(nameof (systemuser_bot_publishedby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (systemuser_bot_publishedby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_bot")]
    public Team team_bot => this.GetRelatedEntity<Team>(nameof (team_bot), new EntityRole?());

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_bot")]
    public SystemUser user_bot
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_bot), new EntityRole?());
    }

    public bot(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["botid"] = (object) base.Id;
            break;
          case "botid":
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
