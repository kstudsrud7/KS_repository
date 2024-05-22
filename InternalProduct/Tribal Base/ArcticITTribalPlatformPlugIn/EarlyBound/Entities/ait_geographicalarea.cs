// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_geographicalarea
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_geographicalarea")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_geographicalarea : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_geographicalarea";
    public const string EntitySchemaName = "ait_geographicalarea";
    public const string PrimaryIdAttribute = "ait_geographicalareaid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_geographicalarea()
      : base(nameof (ait_geographicalarea))
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

    [AttributeLogicalName("ait_description")]
    public string ait_description
    {
      get => this.GetAttributeValue<string>(nameof (ait_description));
      set
      {
        this.OnPropertyChanging(nameof (ait_description));
        this.SetAttributeValue(nameof (ait_description), (object) value);
        this.OnPropertyChanged(nameof (ait_description));
      }
    }

    [AttributeLogicalName("ait_geographicalareaid")]
    public Guid? ait_geographicalareaId
    {
      get => this.GetAttributeValue<Guid?>("ait_geographicalareaid");
      set
      {
        this.OnPropertyChanging(nameof (ait_geographicalareaId));
        this.SetAttributeValue("ait_geographicalareaid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_geographicalareaId));
      }
    }

    [AttributeLogicalName("ait_geographicalareaid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_geographicalareaId = new Guid?(value);
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

    [AttributeLogicalName("ait_parentgeographicarea")]
    public EntityReference ait_parentgeographicarea
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_parentgeographicarea));
      set
      {
        this.OnPropertyChanging(nameof (ait_parentgeographicarea));
        this.SetAttributeValue(nameof (ait_parentgeographicarea), (object) value);
        this.OnPropertyChanged(nameof (ait_parentgeographicarea));
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
    public ait_geographicalareaState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_geographicalareaState?((ait_geographicalareaState) Enum.ToObject(typeof (ait_geographicalareaState), attributeValue.Value)) : new ait_geographicalareaState?();
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

    [RelationshipSchemaName]
    public IEnumerable<ait_geographicalarea> Referencedait_ait_geographicalarea_ait_geographicalarea
    {
      get
      {
        return this.GetRelatedEntities<ait_geographicalarea>("ait_ait_geographicalarea_ait_geographicalarea", new EntityRole?((EntityRole) 1));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencedait_ait_geographicalarea_ait_geographicalarea));
        this.SetRelatedEntities<ait_geographicalarea>("ait_ait_geographicalarea_ait_geographicalarea", new EntityRole?((EntityRole) 1), value);
        this.OnPropertyChanged(nameof (Referencedait_ait_geographicalarea_ait_geographicalarea));
      }
    }

    [RelationshipSchemaName("ait_ait_physicaladdress_ait_geographicalarea")]
    public IEnumerable<ait_physicaladdress> ait_ait_physicaladdress_ait_geographicalarea
    {
      get
      {
        return this.GetRelatedEntities<ait_physicaladdress>(nameof (ait_ait_physicaladdress_ait_geographicalarea), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_physicaladdress_ait_geographicalarea));
        this.SetRelatedEntities<ait_physicaladdress>(nameof (ait_ait_physicaladdress_ait_geographicalarea), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_physicaladdress_ait_geographicalarea));
      }
    }

    [RelationshipSchemaName("ait_geographicalarea_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_geographicalarea_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_geographicalarea_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_geographicalarea_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_geographicalarea_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_geographicalarea_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_geographicalarea_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_geographicalarea_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_geographicalarea_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_geographicalarea_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_geographicalarea_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_geographicalarea_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_geographicalarea_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_geographicalarea_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_geographicalarea_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_geographicalarea_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_geographicalarea_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_geographicalarea_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_geographicalarea_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_geographicalarea_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_geographicalarea_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_geographicalarea_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_geographicalarea_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_geographicalarea_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_geographicalarea_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_geographicalarea_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_geographicalarea_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_geographicalarea_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_geographicalarea_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_geographicalarea_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_geographicalarea_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_geographicalarea_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_geographicalarea_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_geographicalarea_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_geographicalarea_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_geographicalarea_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_geographicalarea_ProcessSession")]
    public IEnumerable<ProcessSession> ait_geographicalarea_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_geographicalarea_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_geographicalarea_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_geographicalarea_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_geographicalarea_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_geographicalarea_SyncErrors")]
    public IEnumerable<SyncError> ait_geographicalarea_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_geographicalarea_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_geographicalarea_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_geographicalarea_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_geographicalarea_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_geographicalarea_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_geographicalarea_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_geographicalarea_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_geographicalarea_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_geographicalarea_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_geographicalarea_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_parentgeographicarea")]
    [RelationshipSchemaName]
    public ait_geographicalarea Referencingait_ait_geographicalarea_ait_geographicalarea
    {
      get
      {
        return this.GetRelatedEntity<ait_geographicalarea>("ait_ait_geographicalarea_ait_geographicalarea", new EntityRole?((EntityRole) 0));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencingait_ait_geographicalarea_ait_geographicalarea));
        this.SetRelatedEntity<ait_geographicalarea>("ait_ait_geographicalarea_ait_geographicalarea", new EntityRole?((EntityRole) 0), value);
        this.OnPropertyChanged(nameof (Referencingait_ait_geographicalarea_ait_geographicalarea));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_geographicalarea_createdby")]
    public SystemUser lk_ait_geographicalarea_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_geographicalarea_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_geographicalarea_createdonbehalfby")]
    public SystemUser lk_ait_geographicalarea_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_geographicalarea_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_geographicalarea_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_geographicalarea_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_geographicalarea_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_geographicalarea_modifiedby")]
    public SystemUser lk_ait_geographicalarea_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_geographicalarea_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_geographicalarea_modifiedonbehalfby")]
    public SystemUser lk_ait_geographicalarea_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_geographicalarea_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_geographicalarea_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_geographicalarea_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_geographicalarea_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_ait_geographicalarea")]
    public Organization organization_ait_geographicalarea
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_ait_geographicalarea), new EntityRole?());
      }
    }

    public ait_geographicalarea(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_geographicalareaid"] = (object) base.Id;
            break;
          case "ait_geographicalareaid":
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
