// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.conversationtranscript
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("conversationtranscript")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class conversationtranscript : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "conversationtranscript";
    public const string EntitySchemaName = "conversationtranscript";
    public const string PrimaryIdAttribute = "conversationtranscriptid";
    public const string PrimaryNameAttribute = "name";

    public conversationtranscript()
      : base(nameof (conversationtranscript))
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

    [AttributeLogicalName("bot_conversationtranscriptid")]
    public EntityReference bot_conversationtranscriptId
    {
      get => this.GetAttributeValue<EntityReference>("bot_conversationtranscriptid");
      set
      {
        this.OnPropertyChanging(nameof (bot_conversationtranscriptId));
        this.SetAttributeValue("bot_conversationtranscriptid", (object) value);
        this.OnPropertyChanged(nameof (bot_conversationtranscriptId));
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

    [AttributeLogicalName("conversationstarttime")]
    public DateTime? ConversationStartTime
    {
      get => this.GetAttributeValue<DateTime?>("conversationstarttime");
      set
      {
        this.OnPropertyChanging(nameof (ConversationStartTime));
        this.SetAttributeValue("conversationstarttime", (object) value);
        this.OnPropertyChanged(nameof (ConversationStartTime));
      }
    }

    [AttributeLogicalName("conversationtranscriptid")]
    public Guid? conversationtranscriptId
    {
      get => this.GetAttributeValue<Guid?>("conversationtranscriptid");
      set
      {
        this.OnPropertyChanging(nameof (conversationtranscriptId));
        this.SetAttributeValue("conversationtranscriptid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (conversationtranscriptId));
      }
    }

    [AttributeLogicalName("conversationtranscriptid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.conversationtranscriptId = new Guid?(value);
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

    [AttributeLogicalName("metadata")]
    public string metadata
    {
      get => this.GetAttributeValue<string>(nameof (metadata));
      set
      {
        this.OnPropertyChanging(nameof (metadata));
        this.SetAttributeValue(nameof (metadata), (object) value);
        this.OnPropertyChanged(nameof (metadata));
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

    [AttributeLogicalName("schematype")]
    public string SchemaType
    {
      get => this.GetAttributeValue<string>("schematype");
      set
      {
        this.OnPropertyChanging(nameof (SchemaType));
        this.SetAttributeValue("schematype", (object) value);
        this.OnPropertyChanged(nameof (SchemaType));
      }
    }

    [AttributeLogicalName("schemaversion")]
    public string SchemaVersion
    {
      get => this.GetAttributeValue<string>("schemaversion");
      set
      {
        this.OnPropertyChanging(nameof (SchemaVersion));
        this.SetAttributeValue("schemaversion", (object) value);
        this.OnPropertyChanged(nameof (SchemaVersion));
      }
    }

    [AttributeLogicalName("statecode")]
    public conversationtranscriptState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new conversationtranscriptState?((conversationtranscriptState) Enum.ToObject(typeof (conversationtranscriptState), attributeValue.Value)) : new conversationtranscriptState?();
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

    [RelationshipSchemaName("conversationtranscript_AsyncOperations")]
    public IEnumerable<AsyncOperation> conversationtranscript_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (conversationtranscript_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (conversationtranscript_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (conversationtranscript_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (conversationtranscript_AsyncOperations));
      }
    }

    [RelationshipSchemaName("conversationtranscript_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> conversationtranscript_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (conversationtranscript_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (conversationtranscript_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (conversationtranscript_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (conversationtranscript_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("conversationtranscript_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> conversationtranscript_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (conversationtranscript_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (conversationtranscript_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (conversationtranscript_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (conversationtranscript_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("conversationtranscript_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> conversationtranscript_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (conversationtranscript_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (conversationtranscript_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (conversationtranscript_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (conversationtranscript_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("conversationtranscript_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> conversationtranscript_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (conversationtranscript_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (conversationtranscript_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (conversationtranscript_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (conversationtranscript_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("conversationtranscript_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> conversationtranscript_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (conversationtranscript_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (conversationtranscript_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (conversationtranscript_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (conversationtranscript_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("conversationtranscript_ProcessSession")]
    public IEnumerable<ProcessSession> conversationtranscript_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (conversationtranscript_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (conversationtranscript_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (conversationtranscript_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (conversationtranscript_ProcessSession));
      }
    }

    [RelationshipSchemaName("conversationtranscript_SyncErrors")]
    public IEnumerable<SyncError> conversationtranscript_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (conversationtranscript_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (conversationtranscript_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (conversationtranscript_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (conversationtranscript_SyncErrors));
      }
    }

    [RelationshipSchemaName("conversationtranscript_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> conversationtranscript_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (conversationtranscript_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (conversationtranscript_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (conversationtranscript_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (conversationtranscript_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("bot_conversationtranscriptid")]
    [RelationshipSchemaName("bot_conversationtranscript")]
    public bot bot_conversationtranscript
    {
      get => this.GetRelatedEntity<bot>(nameof (bot_conversationtranscript), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (bot_conversationtranscript));
        this.SetRelatedEntity<bot>(nameof (bot_conversationtranscript), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (bot_conversationtranscript));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_conversationtranscript")]
    public BusinessUnit business_unit_conversationtranscript
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_conversationtranscript), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_conversationtranscript_createdby")]
    public SystemUser lk_conversationtranscript_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_conversationtranscript_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_conversationtranscript_createdonbehalfby")]
    public SystemUser lk_conversationtranscript_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_conversationtranscript_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_conversationtranscript_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_conversationtranscript_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_conversationtranscript_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_conversationtranscript_modifiedby")]
    public SystemUser lk_conversationtranscript_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_conversationtranscript_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_conversationtranscript_modifiedonbehalfby")]
    public SystemUser lk_conversationtranscript_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_conversationtranscript_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_conversationtranscript_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_conversationtranscript_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_conversationtranscript_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_conversationtranscript")]
    public Team team_conversationtranscript
    {
      get => this.GetRelatedEntity<Team>(nameof (team_conversationtranscript), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_conversationtranscript")]
    public SystemUser user_conversationtranscript
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_conversationtranscript), new EntityRole?());
      }
    }

    public conversationtranscript(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["conversationtranscriptid"] = (object) base.Id;
            break;
          case "conversationtranscriptid":
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
