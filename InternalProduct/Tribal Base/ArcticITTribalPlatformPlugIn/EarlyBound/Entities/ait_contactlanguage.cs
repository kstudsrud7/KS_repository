// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_contactlanguage
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_contactlanguage")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_contactlanguage : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_contactlanguage";
    public const string EntitySchemaName = "ait_contactlanguage";
    public const string PrimaryIdAttribute = "ait_contactlanguageid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_contactlanguage()
      : base(nameof (ait_contactlanguage))
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

    [AttributeLogicalName("ait_contact")]
    public EntityReference ait_contact
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_contact));
      set
      {
        this.OnPropertyChanging(nameof (ait_contact));
        this.SetAttributeValue(nameof (ait_contact), (object) value);
        this.OnPropertyChanged(nameof (ait_contact));
      }
    }

    [AttributeLogicalName("ait_contactlanguageid")]
    public Guid? ait_contactlanguageId
    {
      get => this.GetAttributeValue<Guid?>("ait_contactlanguageid");
      set
      {
        this.OnPropertyChanging(nameof (ait_contactlanguageId));
        this.SetAttributeValue("ait_contactlanguageid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_contactlanguageId));
      }
    }

    [AttributeLogicalName("ait_contactlanguageid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_contactlanguageId = new Guid?(value);
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

    [AttributeLogicalName("ait_language")]
    public EntityReference ait_Language
    {
      get => this.GetAttributeValue<EntityReference>("ait_language");
      set
      {
        this.OnPropertyChanging(nameof (ait_Language));
        this.SetAttributeValue("ait_language", (object) value);
        this.OnPropertyChanged(nameof (ait_Language));
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

    [AttributeLogicalName("ait_proficiency")]
    public EntityReference ait_proficiency
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_proficiency));
      set
      {
        this.OnPropertyChanging(nameof (ait_proficiency));
        this.SetAttributeValue(nameof (ait_proficiency), (object) value);
        this.OnPropertyChanged(nameof (ait_proficiency));
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
    public ait_contactlanguageState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_contactlanguageState?((ait_contactlanguageState) Enum.ToObject(typeof (ait_contactlanguageState), attributeValue.Value)) : new ait_contactlanguageState?();
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

    [RelationshipSchemaName("ait_contactlanguage_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_contactlanguage_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_contactlanguage_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactlanguage_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_contactlanguage_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactlanguage_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_contactlanguage_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_contactlanguage_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_contactlanguage_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactlanguage_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_contactlanguage_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactlanguage_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_contactlanguage_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_contactlanguage_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_contactlanguage_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactlanguage_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_contactlanguage_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactlanguage_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_contactlanguage_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_contactlanguage_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_contactlanguage_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactlanguage_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_contactlanguage_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactlanguage_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_contactlanguage_ProcessSession")]
    public IEnumerable<ProcessSession> ait_contactlanguage_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_contactlanguage_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactlanguage_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_contactlanguage_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactlanguage_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_contactlanguage_SyncErrors")]
    public IEnumerable<SyncError> ait_contactlanguage_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_contactlanguage_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactlanguage_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_contactlanguage_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactlanguage_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_contactlanguage_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_contactlanguage_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_contactlanguage_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactlanguage_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_contactlanguage_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactlanguage_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_language")]
    [RelationshipSchemaName("ait_ait_language_ait_contactlanguage_Language")]
    public ait_language ait_ait_language_ait_contactlanguage_Language
    {
      get
      {
        return this.GetRelatedEntity<ait_language>(nameof (ait_ait_language_ait_contactlanguage_Language), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_language_ait_contactlanguage_Language));
        this.SetRelatedEntity<ait_language>(nameof (ait_ait_language_ait_contactlanguage_Language), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_language_ait_contactlanguage_Language));
      }
    }

    [AttributeLogicalName("ait_proficiency")]
    [RelationshipSchemaName("ait_ait_languageproficiencylevel_ait_contactlanguage_proficiency")]
    public ait_languageproficiencylevel ait_ait_languageproficiencylevel_ait_contactlanguage_proficiency
    {
      get
      {
        return this.GetRelatedEntity<ait_languageproficiencylevel>(nameof (ait_ait_languageproficiencylevel_ait_contactlanguage_proficiency), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_languageproficiencylevel_ait_contactlanguage_proficiency));
        this.SetRelatedEntity<ait_languageproficiencylevel>(nameof (ait_ait_languageproficiencylevel_ait_contactlanguage_proficiency), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_languageproficiencylevel_ait_contactlanguage_proficiency));
      }
    }

    [AttributeLogicalName("ait_contact")]
    [RelationshipSchemaName("ait_contact_ait_contactlanguage_Contact")]
    public Contact ait_contact_ait_contactlanguage_Contact
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (ait_contact_ait_contactlanguage_Contact), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contact_ait_contactlanguage_Contact));
        this.SetRelatedEntity<Contact>(nameof (ait_contact_ait_contactlanguage_Contact), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contact_ait_contactlanguage_Contact));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_contactlanguage")]
    public BusinessUnit business_unit_ait_contactlanguage
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_contactlanguage), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_contactlanguage_createdby")]
    public SystemUser lk_ait_contactlanguage_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_contactlanguage_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_contactlanguage_createdonbehalfby")]
    public SystemUser lk_ait_contactlanguage_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_contactlanguage_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_contactlanguage_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_contactlanguage_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_contactlanguage_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_contactlanguage_modifiedby")]
    public SystemUser lk_ait_contactlanguage_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_contactlanguage_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_contactlanguage_modifiedonbehalfby")]
    public SystemUser lk_ait_contactlanguage_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_contactlanguage_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_contactlanguage_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_contactlanguage_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_contactlanguage_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_contactlanguage")]
    public Team team_ait_contactlanguage
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_contactlanguage), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_contactlanguage")]
    public SystemUser user_ait_contactlanguage
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_ait_contactlanguage), new EntityRole?());
      }
    }

    public ait_contactlanguage(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_contactlanguageid"] = (object) base.Id;
            break;
          case "ait_contactlanguageid":
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
