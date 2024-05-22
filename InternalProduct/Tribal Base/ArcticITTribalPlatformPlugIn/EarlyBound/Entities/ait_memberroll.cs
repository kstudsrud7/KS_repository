// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_memberroll
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_memberroll")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_memberroll : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_memberroll";
    public const string EntitySchemaName = "ait_memberroll";
    public const string PrimaryIdAttribute = "ait_memberrollid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_memberroll()
      : base(nameof (ait_memberroll))
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

    [AttributeLogicalName("ait_memberprofile")]
    public EntityReference ait_memberprofile
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_memberprofile));
      set
      {
        this.OnPropertyChanging(nameof (ait_memberprofile));
        this.SetAttributeValue(nameof (ait_memberprofile), (object) value);
        this.OnPropertyChanged(nameof (ait_memberprofile));
      }
    }

    [AttributeLogicalName("ait_memberrollid")]
    public Guid? ait_memberrollId
    {
      get => this.GetAttributeValue<Guid?>("ait_memberrollid");
      set
      {
        this.OnPropertyChanging(nameof (ait_memberrollId));
        this.SetAttributeValue("ait_memberrollid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_memberrollId));
      }
    }

    [AttributeLogicalName("ait_memberrollid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_memberrollId = new Guid?(value);
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

    [AttributeLogicalName("ait_roll")]
    public EntityReference ait_roll
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_roll));
      set
      {
        this.OnPropertyChanging(nameof (ait_roll));
        this.SetAttributeValue(nameof (ait_roll), (object) value);
        this.OnPropertyChanged(nameof (ait_roll));
      }
    }

    [AttributeLogicalName("ait_rollnumber")]
    public string ait_rollnumber
    {
      get => this.GetAttributeValue<string>(nameof (ait_rollnumber));
      set
      {
        this.OnPropertyChanging(nameof (ait_rollnumber));
        this.SetAttributeValue(nameof (ait_rollnumber), (object) value);
        this.OnPropertyChanged(nameof (ait_rollnumber));
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
    public ait_memberrollState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_memberrollState?((ait_memberrollState) Enum.ToObject(typeof (ait_memberrollState), attributeValue.Value)) : new ait_memberrollState?();
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

    [RelationshipSchemaName("ait_memberroll_Annotations")]
    public IEnumerable<Annotation> ait_memberroll_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (ait_memberroll_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_memberroll_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (ait_memberroll_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_memberroll_Annotations));
      }
    }

    [RelationshipSchemaName("ait_memberroll_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_memberroll_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_memberroll_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_memberroll_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_memberroll_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_memberroll_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_memberroll_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_memberroll_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_memberroll_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_memberroll_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_memberroll_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_memberroll_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_memberroll_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_memberroll_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_memberroll_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_memberroll_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_memberroll_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_memberroll_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_memberroll_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_memberroll_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_memberroll_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_memberroll_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_memberroll_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_memberroll_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_memberroll_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_memberroll_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_memberroll_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_memberroll_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_memberroll_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_memberroll_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_memberroll_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_memberroll_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_memberroll_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_memberroll_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_memberroll_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_memberroll_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_memberroll_ProcessSession")]
    public IEnumerable<ProcessSession> ait_memberroll_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_memberroll_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_memberroll_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_memberroll_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_memberroll_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_memberroll_SyncErrors")]
    public IEnumerable<SyncError> ait_memberroll_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_memberroll_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_memberroll_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_memberroll_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_memberroll_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_memberroll_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_memberroll_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_memberroll_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_memberroll_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_memberroll_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_memberroll_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_memberprofile")]
    [RelationshipSchemaName("ait_ait_memberroll_ait_memberprofile")]
    public ArcticIT.EarlyBound.Entities.ait_memberprofile ait_ait_memberroll_ait_memberprofile
    {
      get
      {
        return this.GetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_memberprofile>(nameof (ait_ait_memberroll_ait_memberprofile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_memberroll_ait_memberprofile));
        this.SetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_memberprofile>(nameof (ait_ait_memberroll_ait_memberprofile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_memberroll_ait_memberprofile));
      }
    }

    [AttributeLogicalName("ait_roll")]
    [RelationshipSchemaName("ait_ait_memberroll_ait_roll")]
    public ArcticIT.EarlyBound.Entities.ait_roll ait_ait_memberroll_ait_roll
    {
      get
      {
        return this.GetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_roll>(nameof (ait_ait_memberroll_ait_roll), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_memberroll_ait_roll));
        this.SetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_roll>(nameof (ait_ait_memberroll_ait_roll), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_memberroll_ait_roll));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_memberroll")]
    public BusinessUnit business_unit_ait_memberroll
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_memberroll), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_memberroll_createdby")]
    public SystemUser lk_ait_memberroll_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_memberroll_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_memberroll_createdonbehalfby")]
    public SystemUser lk_ait_memberroll_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_memberroll_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_memberroll_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_memberroll_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_memberroll_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_memberroll_modifiedby")]
    public SystemUser lk_ait_memberroll_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_memberroll_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_memberroll_modifiedonbehalfby")]
    public SystemUser lk_ait_memberroll_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_memberroll_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_memberroll_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_memberroll_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_memberroll_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_memberroll")]
    public Team team_ait_memberroll
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_memberroll), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_memberroll")]
    public SystemUser user_ait_memberroll
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_ait_memberroll), new EntityRole?());
    }

    public ait_memberroll(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_memberrollid"] = (object) base.Id;
            break;
          case "ait_memberrollid":
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
