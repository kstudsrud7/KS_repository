// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_membershipcategory
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_membershipcategory")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_membershipcategory : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_membershipcategory";
    public const string EntitySchemaName = "ait_membershipcategory";
    public const string PrimaryIdAttribute = "ait_membershipcategoryid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_membershipcategory()
      : base(nameof (ait_membershipcategory))
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

    [AttributeLogicalName("ait_membershipcategoryid")]
    public Guid? ait_membershipcategoryId
    {
      get => this.GetAttributeValue<Guid?>("ait_membershipcategoryid");
      set
      {
        this.OnPropertyChanging(nameof (ait_membershipcategoryId));
        this.SetAttributeValue("ait_membershipcategoryid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_membershipcategoryId));
      }
    }

    [AttributeLogicalName("ait_membershipcategoryid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_membershipcategoryId = new Guid?(value);
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
    public ait_membershipcategoryState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_membershipcategoryState?((ait_membershipcategoryState) Enum.ToObject(typeof (ait_membershipcategoryState), attributeValue.Value)) : new ait_membershipcategoryState?();
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

    [RelationshipSchemaName("ait_ait_membershipcategory_ait_memberprofilemembershipcategory_membershipcategory")]
    public IEnumerable<ait_memberprofilemembershipcategory> ait_ait_membershipcategory_ait_memberprofilemembershipcategory_membershipcategory
    {
      get
      {
        return this.GetRelatedEntities<ait_memberprofilemembershipcategory>(nameof (ait_ait_membershipcategory_ait_memberprofilemembershipcategory_membershipcategory), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_membershipcategory_ait_memberprofilemembershipcategory_membershipcategory));
        this.SetRelatedEntities<ait_memberprofilemembershipcategory>(nameof (ait_ait_membershipcategory_ait_memberprofilemembershipcategory_membershipcategory), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_membershipcategory_ait_memberprofilemembershipcategory_membershipcategory));
      }
    }

    [RelationshipSchemaName("ait_membershipcategory_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_membershipcategory_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_membershipcategory_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_membershipcategory_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_membershipcategory_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_membershipcategory_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_membershipcategory_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_membershipcategory_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_membershipcategory_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_membershipcategory_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_membershipcategory_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_membershipcategory_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_membershipcategory_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_membershipcategory_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_membershipcategory_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_membershipcategory_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_membershipcategory_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_membershipcategory_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_membershipcategory_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_membershipcategory_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_membershipcategory_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_membershipcategory_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_membershipcategory_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_membershipcategory_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_membershipcategory_ProcessSession")]
    public IEnumerable<ProcessSession> ait_membershipcategory_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_membershipcategory_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_membershipcategory_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_membershipcategory_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_membershipcategory_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_membershipcategory_SyncErrors")]
    public IEnumerable<SyncError> ait_membershipcategory_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_membershipcategory_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_membershipcategory_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_membershipcategory_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_membershipcategory_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_membershipcategory_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_membershipcategory_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_membershipcategory_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_membershipcategory_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_membershipcategory_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_membershipcategory_UserEntityInstanceDatas));
      }
    }

    [RelationshipSchemaName("ait_ait_memberprofile_ait_membershipcategory")]
    public IEnumerable<ait_memberprofile> ait_ait_memberprofile_ait_membershipcategory
    {
      get
      {
        return this.GetRelatedEntities<ait_memberprofile>(nameof (ait_ait_memberprofile_ait_membershipcategory), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_memberprofile_ait_membershipcategory));
        this.SetRelatedEntities<ait_memberprofile>(nameof (ait_ait_memberprofile_ait_membershipcategory), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_memberprofile_ait_membershipcategory));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_membershipcategory_createdby")]
    public SystemUser lk_ait_membershipcategory_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_membershipcategory_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_membershipcategory_createdonbehalfby")]
    public SystemUser lk_ait_membershipcategory_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_membershipcategory_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_membershipcategory_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_membershipcategory_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_membershipcategory_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_membershipcategory_modifiedby")]
    public SystemUser lk_ait_membershipcategory_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_membershipcategory_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_membershipcategory_modifiedonbehalfby")]
    public SystemUser lk_ait_membershipcategory_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_membershipcategory_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_membershipcategory_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_membershipcategory_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_membershipcategory_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_ait_membershipcategory")]
    public Organization organization_ait_membershipcategory
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_ait_membershipcategory), new EntityRole?());
      }
    }

    public ait_membershipcategory(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_membershipcategoryid"] = (object) base.Id;
            break;
          case "ait_membershipcategoryid":
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
