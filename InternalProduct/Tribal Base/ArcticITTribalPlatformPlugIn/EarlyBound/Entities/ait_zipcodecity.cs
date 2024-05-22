// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_zipcodecity
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_zipcodecity")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_zipcodecity : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_zipcodecity";
    public const string EntitySchemaName = "ait_zipcodecity";
    public const string PrimaryIdAttribute = "ait_zipcodecityid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_zipcodecity()
      : base(nameof (ait_zipcodecity))
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

    [AttributeLogicalName("ait_city")]
    public EntityReference ait_city
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_city));
      set
      {
        this.OnPropertyChanging(nameof (ait_city));
        this.SetAttributeValue(nameof (ait_city), (object) value);
        this.OnPropertyChanged(nameof (ait_city));
      }
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

    [AttributeLogicalName("ait_stateprovince")]
    public EntityReference ait_stateprovince
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_stateprovince));
      set
      {
        this.OnPropertyChanging(nameof (ait_stateprovince));
        this.SetAttributeValue(nameof (ait_stateprovince), (object) value);
        this.OnPropertyChanged(nameof (ait_stateprovince));
      }
    }

    [AttributeLogicalName("ait_zipcodecityid")]
    public Guid? ait_zipcodecityId
    {
      get => this.GetAttributeValue<Guid?>("ait_zipcodecityid");
      set
      {
        this.OnPropertyChanging(nameof (ait_zipcodecityId));
        this.SetAttributeValue("ait_zipcodecityid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_zipcodecityId));
      }
    }

    [AttributeLogicalName("ait_zipcodecityid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_zipcodecityId = new Guid?(value);
    }

    [AttributeLogicalName("ait_zippostalcode")]
    public string ait_zippostalcode
    {
      get => this.GetAttributeValue<string>(nameof (ait_zippostalcode));
      set
      {
        this.OnPropertyChanging(nameof (ait_zippostalcode));
        this.SetAttributeValue(nameof (ait_zippostalcode), (object) value);
        this.OnPropertyChanged(nameof (ait_zippostalcode));
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
    public ait_zipcodecityState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_zipcodecityState?((ait_zipcodecityState) Enum.ToObject(typeof (ait_zipcodecityState), attributeValue.Value)) : new ait_zipcodecityState?();
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

    [RelationshipSchemaName("ait_ait_physicaladdress_ait_zipcodecity")]
    public IEnumerable<ait_physicaladdress> ait_ait_physicaladdress_ait_zipcodecity
    {
      get
      {
        return this.GetRelatedEntities<ait_physicaladdress>(nameof (ait_ait_physicaladdress_ait_zipcodecity), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_physicaladdress_ait_zipcodecity));
        this.SetRelatedEntities<ait_physicaladdress>(nameof (ait_ait_physicaladdress_ait_zipcodecity), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_physicaladdress_ait_zipcodecity));
      }
    }

    [RelationshipSchemaName("ait_ait_zipcodecity_ait_changerequest_ZipCode_Approved")]
    public IEnumerable<ait_changerequest> ait_ait_zipcodecity_ait_changerequest_ZipCode_Approved
    {
      get
      {
        return this.GetRelatedEntities<ait_changerequest>(nameof (ait_ait_zipcodecity_ait_changerequest_ZipCode_Approved), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_zipcodecity_ait_changerequest_ZipCode_Approved));
        this.SetRelatedEntities<ait_changerequest>(nameof (ait_ait_zipcodecity_ait_changerequest_ZipCode_Approved), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_zipcodecity_ait_changerequest_ZipCode_Approved));
      }
    }

    [RelationshipSchemaName("ait_ait_zipcodecity_ait_tribe")]
    public IEnumerable<ait_tribe> ait_ait_zipcodecity_ait_tribe
    {
      get
      {
        return this.GetRelatedEntities<ait_tribe>(nameof (ait_ait_zipcodecity_ait_tribe), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_zipcodecity_ait_tribe));
        this.SetRelatedEntities<ait_tribe>(nameof (ait_ait_zipcodecity_ait_tribe), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_zipcodecity_ait_tribe));
      }
    }

    [RelationshipSchemaName("ait_zipcodecity_ait_courtprofileaddress_ZipLookup")]
    public IEnumerable<ait_courtprofileaddress> ait_zipcodecity_ait_courtprofileaddress_ZipLookup
    {
      get
      {
        return this.GetRelatedEntities<ait_courtprofileaddress>(nameof (ait_zipcodecity_ait_courtprofileaddress_ZipLookup), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_zipcodecity_ait_courtprofileaddress_ZipLookup));
        this.SetRelatedEntities<ait_courtprofileaddress>(nameof (ait_zipcodecity_ait_courtprofileaddress_ZipLookup), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_zipcodecity_ait_courtprofileaddress_ZipLookup));
      }
    }

    [RelationshipSchemaName("ait_zipcodecity_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_zipcodecity_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_zipcodecity_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_zipcodecity_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_zipcodecity_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_zipcodecity_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_zipcodecity_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_zipcodecity_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_zipcodecity_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_zipcodecity_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_zipcodecity_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_zipcodecity_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_zipcodecity_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_zipcodecity_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_zipcodecity_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_zipcodecity_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_zipcodecity_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_zipcodecity_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_zipcodecity_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_zipcodecity_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_zipcodecity_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_zipcodecity_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_zipcodecity_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_zipcodecity_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_zipcodecity_ProcessSession")]
    public IEnumerable<ProcessSession> ait_zipcodecity_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_zipcodecity_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_zipcodecity_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_zipcodecity_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_zipcodecity_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_zipcodecity_SyncErrors")]
    public IEnumerable<SyncError> ait_zipcodecity_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_zipcodecity_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_zipcodecity_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_zipcodecity_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_zipcodecity_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_zipcodecity_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_zipcodecity_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_zipcodecity_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_zipcodecity_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_zipcodecity_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_zipcodecity_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_city")]
    [RelationshipSchemaName("ait_ait_zipcodecity_ait_city")]
    public ArcticIT.EarlyBound.Entities.ait_city ait_ait_zipcodecity_ait_city
    {
      get
      {
        return this.GetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_city>(nameof (ait_ait_zipcodecity_ait_city), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_zipcodecity_ait_city));
        this.SetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_city>(nameof (ait_ait_zipcodecity_ait_city), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_zipcodecity_ait_city));
      }
    }

    [AttributeLogicalName("ait_stateprovince")]
    [RelationshipSchemaName("ait_ait_zipcodecity_ait_stateprovince")]
    public ArcticIT.EarlyBound.Entities.ait_stateprovince ait_ait_zipcodecity_ait_stateprovince
    {
      get
      {
        return this.GetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_stateprovince>(nameof (ait_ait_zipcodecity_ait_stateprovince), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_zipcodecity_ait_stateprovince));
        this.SetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_stateprovince>(nameof (ait_ait_zipcodecity_ait_stateprovince), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_zipcodecity_ait_stateprovince));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_zipcodecity_createdby")]
    public SystemUser lk_ait_zipcodecity_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_zipcodecity_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_zipcodecity_createdonbehalfby")]
    public SystemUser lk_ait_zipcodecity_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_zipcodecity_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_zipcodecity_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_zipcodecity_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_zipcodecity_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_zipcodecity_modifiedby")]
    public SystemUser lk_ait_zipcodecity_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_zipcodecity_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_zipcodecity_modifiedonbehalfby")]
    public SystemUser lk_ait_zipcodecity_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_zipcodecity_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_zipcodecity_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_zipcodecity_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_zipcodecity_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_ait_zipcodecity")]
    public Organization organization_ait_zipcodecity
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_ait_zipcodecity), new EntityRole?());
      }
    }

    public ait_zipcodecity(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_zipcodecityid"] = (object) base.Id;
            break;
          case "ait_zipcodecityid":
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
