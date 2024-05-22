// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.processstageparameter
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("processstageparameter")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class processstageparameter : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "processstageparameter";
    public const string EntitySchemaName = "processstageparameter";
    public const string PrimaryIdAttribute = "processstageparameterid";
    public const string PrimaryNameAttribute = "name";

    public processstageparameter()
      : base(nameof (processstageparameter))
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

    [AttributeLogicalName("processstageid")]
    public EntityReference ProcessStageId
    {
      get => this.GetAttributeValue<EntityReference>("processstageid");
      set
      {
        this.OnPropertyChanging(nameof (ProcessStageId));
        this.SetAttributeValue("processstageid", (object) value);
        this.OnPropertyChanged(nameof (ProcessStageId));
      }
    }

    [AttributeLogicalName("processstageparameterid")]
    public Guid? processstageparameterId
    {
      get => this.GetAttributeValue<Guid?>("processstageparameterid");
      set
      {
        this.OnPropertyChanging(nameof (processstageparameterId));
        this.SetAttributeValue("processstageparameterid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (processstageparameterId));
      }
    }

    [AttributeLogicalName("processstageparameterid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.processstageparameterId = new Guid?(value);
    }

    [AttributeLogicalName("statecode")]
    public processstageparameterState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new processstageparameterState?((processstageparameterState) Enum.ToObject(typeof (processstageparameterState), attributeValue.Value)) : new processstageparameterState?();
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

    [AttributeLogicalName("value")]
    public string Value
    {
      get => this.GetAttributeValue<string>("value");
      set
      {
        this.OnPropertyChanging(nameof (Value));
        this.SetAttributeValue(nameof (value), (object) value);
        this.OnPropertyChanged(nameof (Value));
      }
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("processstageparameter_AsyncOperations")]
    public IEnumerable<AsyncOperation> processstageparameter_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (processstageparameter_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (processstageparameter_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (processstageparameter_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (processstageparameter_AsyncOperations));
      }
    }

    [RelationshipSchemaName("processstageparameter_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> processstageparameter_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (processstageparameter_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (processstageparameter_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (processstageparameter_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (processstageparameter_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("processstageparameter_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> processstageparameter_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (processstageparameter_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (processstageparameter_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (processstageparameter_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (processstageparameter_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("processstageparameter_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> processstageparameter_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (processstageparameter_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (processstageparameter_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (processstageparameter_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (processstageparameter_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("processstageparameter_ProcessSession")]
    public IEnumerable<ProcessSession> processstageparameter_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (processstageparameter_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (processstageparameter_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (processstageparameter_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (processstageparameter_ProcessSession));
      }
    }

    [RelationshipSchemaName("processstageparameter_SyncErrors")]
    public IEnumerable<SyncError> processstageparameter_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (processstageparameter_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (processstageparameter_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (processstageparameter_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (processstageparameter_SyncErrors));
      }
    }

    [RelationshipSchemaName("processstageparameter_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> processstageparameter_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (processstageparameter_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (processstageparameter_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (processstageparameter_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (processstageparameter_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_processstageparameter")]
    public BusinessUnit business_unit_processstageparameter
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_processstageparameter), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_processstageparameter_createdby")]
    public SystemUser lk_processstageparameter_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_processstageparameter_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_processstageparameter_createdonbehalfby")]
    public SystemUser lk_processstageparameter_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_processstageparameter_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_processstageparameter_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_processstageparameter_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_processstageparameter_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_processstageparameter_modifiedby")]
    public SystemUser lk_processstageparameter_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_processstageparameter_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_processstageparameter_modifiedonbehalfby")]
    public SystemUser lk_processstageparameter_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_processstageparameter_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_processstageparameter_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_processstageparameter_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_processstageparameter_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("processstageid")]
    [RelationshipSchemaName("processstage_processstageparameter")]
    public ProcessStage processstage_processstageparameter
    {
      get
      {
        return this.GetRelatedEntity<ProcessStage>(nameof (processstage_processstageparameter), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (processstage_processstageparameter));
        this.SetRelatedEntity<ProcessStage>(nameof (processstage_processstageparameter), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (processstage_processstageparameter));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_processstageparameter")]
    public Team team_processstageparameter
    {
      get => this.GetRelatedEntity<Team>(nameof (team_processstageparameter), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_processstageparameter")]
    public SystemUser user_processstageparameter
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_processstageparameter), new EntityRole?());
      }
    }

    public processstageparameter(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["processstageparameterid"] = (object) base.Id;
            break;
          case "processstageparameterid":
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
