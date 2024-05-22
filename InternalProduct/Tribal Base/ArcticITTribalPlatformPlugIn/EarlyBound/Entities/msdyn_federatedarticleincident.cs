// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.msdyn_federatedarticleincident
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("msdyn_federatedarticleincident")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class msdyn_federatedarticleincident : 
    Entity,
    INotifyPropertyChanging,
    INotifyPropertyChanged
  {
    public const string EntityLogicalName = "msdyn_federatedarticleincident";
    public const string EntitySchemaName = "msdyn_federatedarticleincident";
    public const string PrimaryIdAttribute = "msdyn_federatedarticleincidentid";
    public const string PrimaryNameAttribute = "msdyn_name";

    public msdyn_federatedarticleincident()
      : base(nameof (msdyn_federatedarticleincident))
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

    [AttributeLogicalName("msdyn_federatedarticleid")]
    public EntityReference msdyn_federatedarticleid
    {
      get => this.GetAttributeValue<EntityReference>(nameof (msdyn_federatedarticleid));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_federatedarticleid));
        this.SetAttributeValue(nameof (msdyn_federatedarticleid), (object) value);
        this.OnPropertyChanged(nameof (msdyn_federatedarticleid));
      }
    }

    [AttributeLogicalName("msdyn_federatedarticleincidentid")]
    public Guid? msdyn_federatedarticleincidentId
    {
      get => this.GetAttributeValue<Guid?>("msdyn_federatedarticleincidentid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_federatedarticleincidentId));
        this.SetAttributeValue("msdyn_federatedarticleincidentid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (msdyn_federatedarticleincidentId));
      }
    }

    [AttributeLogicalName("msdyn_federatedarticleincidentid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.msdyn_federatedarticleincidentId = new Guid?(value);
    }

    [AttributeLogicalName("msdyn_incidentid")]
    public EntityReference msdyn_incidentid
    {
      get => this.GetAttributeValue<EntityReference>(nameof (msdyn_incidentid));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_incidentid));
        this.SetAttributeValue(nameof (msdyn_incidentid), (object) value);
        this.OnPropertyChanged(nameof (msdyn_incidentid));
      }
    }

    [AttributeLogicalName("msdyn_name")]
    public string msdyn_name
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_name));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_name));
        this.SetAttributeValue(nameof (msdyn_name), (object) value);
        this.OnPropertyChanged(nameof (msdyn_name));
      }
    }

    [AttributeLogicalName("msdyn_searchproviderarticleid")]
    public string msdyn_searchproviderarticleid
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_searchproviderarticleid));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_searchproviderarticleid));
        this.SetAttributeValue(nameof (msdyn_searchproviderarticleid), (object) value);
        this.OnPropertyChanged(nameof (msdyn_searchproviderarticleid));
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
    public msdyn_federatedarticleincidentState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new msdyn_federatedarticleincidentState?((msdyn_federatedarticleincidentState) Enum.ToObject(typeof (msdyn_federatedarticleincidentState), attributeValue.Value)) : new msdyn_federatedarticleincidentState?();
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

    [RelationshipSchemaName("msdyn_federatedarticleincident_AsyncOperations")]
    public IEnumerable<AsyncOperation> msdyn_federatedarticleincident_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (msdyn_federatedarticleincident_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_federatedarticleincident_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (msdyn_federatedarticleincident_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_federatedarticleincident_AsyncOperations));
      }
    }

    [RelationshipSchemaName("msdyn_federatedarticleincident_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> msdyn_federatedarticleincident_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_federatedarticleincident_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_federatedarticleincident_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_federatedarticleincident_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_federatedarticleincident_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("msdyn_federatedarticleincident_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> msdyn_federatedarticleincident_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (msdyn_federatedarticleincident_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_federatedarticleincident_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (msdyn_federatedarticleincident_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_federatedarticleincident_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("msdyn_federatedarticleincident_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> msdyn_federatedarticleincident_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (msdyn_federatedarticleincident_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_federatedarticleincident_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (msdyn_federatedarticleincident_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_federatedarticleincident_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("msdyn_federatedarticleincident_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> msdyn_federatedarticleincident_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_federatedarticleincident_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_federatedarticleincident_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_federatedarticleincident_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_federatedarticleincident_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("msdyn_federatedarticleincident_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> msdyn_federatedarticleincident_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_federatedarticleincident_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_federatedarticleincident_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_federatedarticleincident_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_federatedarticleincident_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("msdyn_federatedarticleincident_ProcessSession")]
    public IEnumerable<ProcessSession> msdyn_federatedarticleincident_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (msdyn_federatedarticleincident_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_federatedarticleincident_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (msdyn_federatedarticleincident_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_federatedarticleincident_ProcessSession));
      }
    }

    [RelationshipSchemaName("msdyn_federatedarticleincident_SyncErrors")]
    public IEnumerable<SyncError> msdyn_federatedarticleincident_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (msdyn_federatedarticleincident_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_federatedarticleincident_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (msdyn_federatedarticleincident_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_federatedarticleincident_SyncErrors));
      }
    }

    [RelationshipSchemaName("msdyn_federatedarticleincident_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> msdyn_federatedarticleincident_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_federatedarticleincident_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_federatedarticleincident_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_federatedarticleincident_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_federatedarticleincident_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_msdyn_federatedarticleincident_createdby")]
    public SystemUser lk_msdyn_federatedarticleincident_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_federatedarticleincident_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_federatedarticleincident_createdonbehalfby")]
    public SystemUser lk_msdyn_federatedarticleincident_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_federatedarticleincident_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_federatedarticleincident_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_federatedarticleincident_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_federatedarticleincident_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_msdyn_federatedarticleincident_modifiedby")]
    public SystemUser lk_msdyn_federatedarticleincident_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_federatedarticleincident_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_federatedarticleincident_modifiedonbehalfby")]
    public SystemUser lk_msdyn_federatedarticleincident_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_federatedarticleincident_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_federatedarticleincident_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_federatedarticleincident_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_federatedarticleincident_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("msdyn_federatedarticleid")]
    [RelationshipSchemaName("msdyn_federatedarticle_msdyn_federatedarticleincident_federatedarticleId")]
    public msdyn_federatedarticle msdyn_federatedarticle_msdyn_federatedarticleincident_federatedarticleId
    {
      get
      {
        return this.GetRelatedEntity<msdyn_federatedarticle>(nameof (msdyn_federatedarticle_msdyn_federatedarticleincident_federatedarticleId), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_federatedarticle_msdyn_federatedarticleincident_federatedarticleId));
        this.SetRelatedEntity<msdyn_federatedarticle>(nameof (msdyn_federatedarticle_msdyn_federatedarticleincident_federatedarticleId), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_federatedarticle_msdyn_federatedarticleincident_federatedarticleId));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_msdyn_federatedarticleincident")]
    public Organization organization_msdyn_federatedarticleincident
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_msdyn_federatedarticleincident), new EntityRole?());
      }
    }

    public msdyn_federatedarticleincident(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["msdyn_federatedarticleincidentid"] = (object) base.Id;
            break;
          case "msdyn_federatedarticleincidentid":
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
