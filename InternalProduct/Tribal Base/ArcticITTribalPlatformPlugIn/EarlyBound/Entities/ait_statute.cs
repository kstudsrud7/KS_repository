// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_statute
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_statute")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_statute : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_statute";
    public const string EntitySchemaName = "ait_statute";
    public const string PrimaryIdAttribute = "ait_statuteid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_statute()
      : base(nameof (ait_statute))
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

    [AttributeLogicalName("ait_class")]
    public OptionSetValue ait_Class
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_class");
      set
      {
        this.OnPropertyChanging(nameof (ait_Class));
        this.SetAttributeValue("ait_class", (object) value);
        this.OnPropertyChanged(nameof (ait_Class));
      }
    }

    [AttributeLogicalName("ait_name")]
    public string ait_name
    {
      get => this.GetAttributeValue<string>(nameof (ait_name));
      set
      {
        this.OnPropertyChanging(nameof (ait_name));
        this.SetAttributeValue(nameof (ait_name), (object) value);
        this.OnPropertyChanged(nameof (ait_name));
      }
    }

    [AttributeLogicalName("ait_statuteid")]
    public Guid? ait_statuteId
    {
      get => this.GetAttributeValue<Guid?>("ait_statuteid");
      set
      {
        this.OnPropertyChanging(nameof (ait_statuteId));
        this.SetAttributeValue("ait_statuteid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_statuteId));
      }
    }

    [AttributeLogicalName("ait_statuteid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_statuteId = new Guid?(value);
    }

    [AttributeLogicalName("ait_statutenumber")]
    public string ait_StatuteNumber
    {
      get => this.GetAttributeValue<string>("ait_statutenumber");
      set
      {
        this.OnPropertyChanging(nameof (ait_StatuteNumber));
        this.SetAttributeValue("ait_statutenumber", (object) value);
        this.OnPropertyChanged(nameof (ait_StatuteNumber));
      }
    }

    [AttributeLogicalName("ait_statutetext")]
    public string ait_StatuteText
    {
      get => this.GetAttributeValue<string>("ait_statutetext");
      set
      {
        this.OnPropertyChanging(nameof (ait_StatuteText));
        this.SetAttributeValue("ait_statutetext", (object) value);
        this.OnPropertyChanged(nameof (ait_StatuteText));
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

    [AttributeLogicalName("statecode")]
    public ait_statuteState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_statuteState?((ait_statuteState) Enum.ToObject(typeof (ait_statuteState), attributeValue.Value)) : new ait_statuteState?();
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

    [RelationshipSchemaName("ait_statute_ait_charge_Statute")]
    public IEnumerable<ait_charge> ait_statute_ait_charge_Statute
    {
      get
      {
        return this.GetRelatedEntities<ait_charge>(nameof (ait_statute_ait_charge_Statute), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_statute_ait_charge_Statute));
        this.SetRelatedEntities<ait_charge>(nameof (ait_statute_ait_charge_Statute), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_statute_ait_charge_Statute));
      }
    }

    [RelationshipSchemaName("ait_statute_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_statute_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_statute_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_statute_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_statute_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_statute_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_statute_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_statute_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_statute_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_statute_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_statute_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_statute_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_statute_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_statute_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_statute_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_statute_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_statute_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_statute_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_statute_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_statute_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_statute_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_statute_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_statute_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_statute_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_statute_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_statute_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_statute_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_statute_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_statute_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_statute_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_statute_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_statute_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_statute_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_statute_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_statute_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_statute_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_statute_ProcessSession")]
    public IEnumerable<ProcessSession> ait_statute_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_statute_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_statute_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_statute_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_statute_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_statute_SyncErrors")]
    public IEnumerable<SyncError> ait_statute_SyncErrors
    {
      get => this.GetRelatedEntities<SyncError>(nameof (ait_statute_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_statute_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_statute_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_statute_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_statute_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_statute_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_statute_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_statute_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_statute_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_statute_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_statute")]
    public BusinessUnit business_unit_ait_statute
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_statute), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_statute_createdby")]
    public SystemUser lk_ait_statute_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_statute_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_statute_createdonbehalfby")]
    public SystemUser lk_ait_statute_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_statute_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_statute_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_statute_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_statute_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_statute_modifiedby")]
    public SystemUser lk_ait_statute_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_statute_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_statute_modifiedonbehalfby")]
    public SystemUser lk_ait_statute_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_statute_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_statute_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_statute_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_statute_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_statute")]
    public Team team_ait_statute
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_statute), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_statute")]
    public SystemUser user_ait_statute
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_ait_statute), new EntityRole?());
    }

    public ait_statute(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_statuteid"] = (object) base.Id;
            break;
          case "ait_statuteid":
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
