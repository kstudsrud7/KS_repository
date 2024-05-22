// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_languageproficiencylevel
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_languageproficiencylevel")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_languageproficiencylevel : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_languageproficiencylevel";
    public const string EntitySchemaName = "ait_languageproficiencylevel";
    public const string PrimaryIdAttribute = "ait_languageproficiencylevelid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_languageproficiencylevel()
      : base(nameof (ait_languageproficiencylevel))
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

    [AttributeLogicalName("ait_languageproficiencylevelid")]
    public Guid? ait_languageproficiencylevelId
    {
      get => this.GetAttributeValue<Guid?>("ait_languageproficiencylevelid");
      set
      {
        this.OnPropertyChanging(nameof (ait_languageproficiencylevelId));
        this.SetAttributeValue("ait_languageproficiencylevelid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_languageproficiencylevelId));
      }
    }

    [AttributeLogicalName("ait_languageproficiencylevelid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_languageproficiencylevelId = new Guid?(value);
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

    [AttributeLogicalName("ait_readingdefinitions")]
    public string ait_readingdefinitions
    {
      get => this.GetAttributeValue<string>(nameof (ait_readingdefinitions));
      set
      {
        this.OnPropertyChanging(nameof (ait_readingdefinitions));
        this.SetAttributeValue(nameof (ait_readingdefinitions), (object) value);
        this.OnPropertyChanged(nameof (ait_readingdefinitions));
      }
    }

    [AttributeLogicalName("ait_speakingdefinitions")]
    public string ait_speakingdefinitions
    {
      get => this.GetAttributeValue<string>(nameof (ait_speakingdefinitions));
      set
      {
        this.OnPropertyChanging(nameof (ait_speakingdefinitions));
        this.SetAttributeValue(nameof (ait_speakingdefinitions), (object) value);
        this.OnPropertyChanged(nameof (ait_speakingdefinitions));
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
    public ait_languageproficiencylevelState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_languageproficiencylevelState?((ait_languageproficiencylevelState) Enum.ToObject(typeof (ait_languageproficiencylevelState), attributeValue.Value)) : new ait_languageproficiencylevelState?();
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

    [RelationshipSchemaName("ait_ait_languageproficiencylevel_ait_contactlanguage_proficiency")]
    public IEnumerable<ait_contactlanguage> ait_ait_languageproficiencylevel_ait_contactlanguage_proficiency
    {
      get
      {
        return this.GetRelatedEntities<ait_contactlanguage>(nameof (ait_ait_languageproficiencylevel_ait_contactlanguage_proficiency), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_languageproficiencylevel_ait_contactlanguage_proficiency));
        this.SetRelatedEntities<ait_contactlanguage>(nameof (ait_ait_languageproficiencylevel_ait_contactlanguage_proficiency), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_languageproficiencylevel_ait_contactlanguage_proficiency));
      }
    }

    [RelationshipSchemaName("ait_languageproficiencylevel_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_languageproficiencylevel_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_languageproficiencylevel_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_languageproficiencylevel_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_languageproficiencylevel_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_languageproficiencylevel_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_languageproficiencylevel_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_languageproficiencylevel_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_languageproficiencylevel_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_languageproficiencylevel_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_languageproficiencylevel_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_languageproficiencylevel_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_languageproficiencylevel_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_languageproficiencylevel_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_languageproficiencylevel_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_languageproficiencylevel_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_languageproficiencylevel_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_languageproficiencylevel_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_languageproficiencylevel_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_languageproficiencylevel_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_languageproficiencylevel_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_languageproficiencylevel_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_languageproficiencylevel_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_languageproficiencylevel_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_languageproficiencylevel_ProcessSession")]
    public IEnumerable<ProcessSession> ait_languageproficiencylevel_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_languageproficiencylevel_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_languageproficiencylevel_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_languageproficiencylevel_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_languageproficiencylevel_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_languageproficiencylevel_SyncErrors")]
    public IEnumerable<SyncError> ait_languageproficiencylevel_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_languageproficiencylevel_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_languageproficiencylevel_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_languageproficiencylevel_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_languageproficiencylevel_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_languageproficiencylevel_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_languageproficiencylevel_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_languageproficiencylevel_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_languageproficiencylevel_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_languageproficiencylevel_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_languageproficiencylevel_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_languageproficiencylevel_createdby")]
    public SystemUser lk_ait_languageproficiencylevel_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_languageproficiencylevel_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_languageproficiencylevel_createdonbehalfby")]
    public SystemUser lk_ait_languageproficiencylevel_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_languageproficiencylevel_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_languageproficiencylevel_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_languageproficiencylevel_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_languageproficiencylevel_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_languageproficiencylevel_modifiedby")]
    public SystemUser lk_ait_languageproficiencylevel_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_languageproficiencylevel_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_languageproficiencylevel_modifiedonbehalfby")]
    public SystemUser lk_ait_languageproficiencylevel_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_languageproficiencylevel_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_languageproficiencylevel_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_languageproficiencylevel_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_languageproficiencylevel_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_ait_languageproficiencylevel")]
    public Organization organization_ait_languageproficiencylevel
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_ait_languageproficiencylevel), new EntityRole?());
      }
    }

    public ait_languageproficiencylevel(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_languageproficiencylevelid"] = (object) base.Id;
            break;
          case "ait_languageproficiencylevelid":
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
