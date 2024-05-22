// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_datamigrationhistory
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_datamigrationhistory")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_datamigrationhistory : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_datamigrationhistory";
    public const string EntitySchemaName = "ait_datamigrationhistory";
    public const string PrimaryIdAttribute = "ait_datamigrationhistoryid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_datamigrationhistory()
      : base(nameof (ait_datamigrationhistory))
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

    [AttributeLogicalName("ait_changedate")]
    public DateTime? ait_changedate
    {
      get => this.GetAttributeValue<DateTime?>(nameof (ait_changedate));
      set
      {
        this.OnPropertyChanging(nameof (ait_changedate));
        this.SetAttributeValue(nameof (ait_changedate), (object) value);
        this.OnPropertyChanged(nameof (ait_changedate));
      }
    }

    [AttributeLogicalName("ait_changeuser")]
    public string ait_changeuser
    {
      get => this.GetAttributeValue<string>(nameof (ait_changeuser));
      set
      {
        this.OnPropertyChanging(nameof (ait_changeuser));
        this.SetAttributeValue(nameof (ait_changeuser), (object) value);
        this.OnPropertyChanged(nameof (ait_changeuser));
      }
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

    [AttributeLogicalName("ait_datamigrationhistoryid")]
    public Guid? ait_datamigrationhistoryId
    {
      get => this.GetAttributeValue<Guid?>("ait_datamigrationhistoryid");
      set
      {
        this.OnPropertyChanging(nameof (ait_datamigrationhistoryId));
        this.SetAttributeValue("ait_datamigrationhistoryid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_datamigrationhistoryId));
      }
    }

    [AttributeLogicalName("ait_datamigrationhistoryid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_datamigrationhistoryId = new Guid?(value);
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
    public ait_datamigrationhistoryState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_datamigrationhistoryState?((ait_datamigrationhistoryState) Enum.ToObject(typeof (ait_datamigrationhistoryState), attributeValue.Value)) : new ait_datamigrationhistoryState?();
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

    [RelationshipSchemaName("ait_datamigrationhistory_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_datamigrationhistory_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_datamigrationhistory_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_datamigrationhistory_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_datamigrationhistory_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_datamigrationhistory_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_datamigrationhistory_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_datamigrationhistory_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_datamigrationhistory_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_datamigrationhistory_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_datamigrationhistory_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_datamigrationhistory_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_datamigrationhistory_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_datamigrationhistory_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_datamigrationhistory_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_datamigrationhistory_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_datamigrationhistory_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_datamigrationhistory_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_datamigrationhistory_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_datamigrationhistory_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_datamigrationhistory_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_datamigrationhistory_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_datamigrationhistory_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_datamigrationhistory_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_datamigrationhistory_ProcessSession")]
    public IEnumerable<ProcessSession> ait_datamigrationhistory_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_datamigrationhistory_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_datamigrationhistory_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_datamigrationhistory_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_datamigrationhistory_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_datamigrationhistory_SyncErrors")]
    public IEnumerable<SyncError> ait_datamigrationhistory_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_datamigrationhistory_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_datamigrationhistory_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_datamigrationhistory_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_datamigrationhistory_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_datamigrationhistory_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_datamigrationhistory_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_datamigrationhistory_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_datamigrationhistory_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_datamigrationhistory_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_datamigrationhistory_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_contact")]
    [RelationshipSchemaName("ait_contact_ait_datamigrationhistory_contact")]
    public Contact ait_contact_ait_datamigrationhistory_contact
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (ait_contact_ait_datamigrationhistory_contact), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contact_ait_datamigrationhistory_contact));
        this.SetRelatedEntity<Contact>(nameof (ait_contact_ait_datamigrationhistory_contact), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contact_ait_datamigrationhistory_contact));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_datamigrationhistory")]
    public BusinessUnit business_unit_ait_datamigrationhistory
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_datamigrationhistory), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_datamigrationhistory_createdby")]
    public SystemUser lk_ait_datamigrationhistory_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_datamigrationhistory_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_datamigrationhistory_createdonbehalfby")]
    public SystemUser lk_ait_datamigrationhistory_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_datamigrationhistory_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_datamigrationhistory_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_datamigrationhistory_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_datamigrationhistory_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_datamigrationhistory_modifiedby")]
    public SystemUser lk_ait_datamigrationhistory_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_datamigrationhistory_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_datamigrationhistory_modifiedonbehalfby")]
    public SystemUser lk_ait_datamigrationhistory_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_datamigrationhistory_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_datamigrationhistory_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_datamigrationhistory_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_datamigrationhistory_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_datamigrationhistory")]
    public Team team_ait_datamigrationhistory
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_datamigrationhistory), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_datamigrationhistory")]
    public SystemUser user_ait_datamigrationhistory
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_ait_datamigrationhistory), new EntityRole?());
      }
    }

    public ait_datamigrationhistory(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_datamigrationhistoryid"] = (object) base.Id;
            break;
          case "ait_datamigrationhistoryid":
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
