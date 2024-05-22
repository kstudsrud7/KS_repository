// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_autonumber
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_autonumber")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_autonumber : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_autonumber";
    public const string EntitySchemaName = "ait_autonumber";
    public const string PrimaryIdAttribute = "ait_autonumberid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_autonumber()
      : base(nameof (ait_autonumber))
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

    [AttributeLogicalName("ait_attributename")]
    public string ait_attributename
    {
      get => this.GetAttributeValue<string>(nameof (ait_attributename));
      set
      {
        this.OnPropertyChanging(nameof (ait_attributename));
        this.SetAttributeValue(nameof (ait_attributename), (object) value);
        this.OnPropertyChanged(nameof (ait_attributename));
      }
    }

    [AttributeLogicalName("ait_autonumberid")]
    public Guid? ait_autonumberId
    {
      get => this.GetAttributeValue<Guid?>("ait_autonumberid");
      set
      {
        this.OnPropertyChanging(nameof (ait_autonumberId));
        this.SetAttributeValue("ait_autonumberid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_autonumberId));
      }
    }

    [AttributeLogicalName("ait_autonumberid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_autonumberId = new Guid?(value);
    }

    [AttributeLogicalName("ait_category")]
    public string ait_category
    {
      get => this.GetAttributeValue<string>(nameof (ait_category));
      set
      {
        this.OnPropertyChanging(nameof (ait_category));
        this.SetAttributeValue(nameof (ait_category), (object) value);
        this.OnPropertyChanged(nameof (ait_category));
      }
    }

    [AttributeLogicalName("ait_entitylogicalname")]
    public string ait_entitylogicalname
    {
      get => this.GetAttributeValue<string>(nameof (ait_entitylogicalname));
      set
      {
        this.OnPropertyChanging(nameof (ait_entitylogicalname));
        this.SetAttributeValue(nameof (ait_entitylogicalname), (object) value);
        this.OnPropertyChanged(nameof (ait_entitylogicalname));
      }
    }

    [AttributeLogicalName("ait_lockfield")]
    public string ait_lockfield
    {
      get => this.GetAttributeValue<string>(nameof (ait_lockfield));
      set
      {
        this.OnPropertyChanging(nameof (ait_lockfield));
        this.SetAttributeValue(nameof (ait_lockfield), (object) value);
        this.OnPropertyChanged(nameof (ait_lockfield));
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

    [AttributeLogicalName("ait_numberreset")]
    public OptionSetValue ait_numberreset
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_numberreset));
      set
      {
        this.OnPropertyChanging(nameof (ait_numberreset));
        this.SetAttributeValue(nameof (ait_numberreset), (object) value);
        this.OnPropertyChanged(nameof (ait_numberreset));
      }
    }

    [AttributeLogicalName("ait_postfix")]
    public string ait_postfix
    {
      get => this.GetAttributeValue<string>(nameof (ait_postfix));
      set
      {
        this.OnPropertyChanging(nameof (ait_postfix));
        this.SetAttributeValue(nameof (ait_postfix), (object) value);
        this.OnPropertyChanged(nameof (ait_postfix));
      }
    }

    [AttributeLogicalName("ait_prefix")]
    public string ait_prefix
    {
      get => this.GetAttributeValue<string>(nameof (ait_prefix));
      set
      {
        this.OnPropertyChanging(nameof (ait_prefix));
        this.SetAttributeValue(nameof (ait_prefix), (object) value);
        this.OnPropertyChanged(nameof (ait_prefix));
      }
    }

    [AttributeLogicalName("ait_value")]
    public int? ait_value
    {
      get => this.GetAttributeValue<int?>(nameof (ait_value));
      set
      {
        this.OnPropertyChanging(nameof (ait_value));
        this.SetAttributeValue(nameof (ait_value), (object) value);
        this.OnPropertyChanged(nameof (ait_value));
      }
    }

    [AttributeLogicalName("ait_valuechanged")]
    public DateTime? ait_valuechanged
    {
      get => this.GetAttributeValue<DateTime?>(nameof (ait_valuechanged));
      set
      {
        this.OnPropertyChanging(nameof (ait_valuechanged));
        this.SetAttributeValue(nameof (ait_valuechanged), (object) value);
        this.OnPropertyChanged(nameof (ait_valuechanged));
      }
    }

    [AttributeLogicalName("ait_valueformat")]
    public string ait_valueformat
    {
      get => this.GetAttributeValue<string>(nameof (ait_valueformat));
      set
      {
        this.OnPropertyChanging(nameof (ait_valueformat));
        this.SetAttributeValue(nameof (ait_valueformat), (object) value);
        this.OnPropertyChanged(nameof (ait_valueformat));
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
    public ait_autonumberState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_autonumberState?((ait_autonumberState) Enum.ToObject(typeof (ait_autonumberState), attributeValue.Value)) : new ait_autonumberState?();
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

    [RelationshipSchemaName("ait_autonumber_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_autonumber_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_autonumber_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_autonumber_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_autonumber_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_autonumber_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_autonumber_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_autonumber_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_autonumber_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_autonumber_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_autonumber_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_autonumber_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_autonumber_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_autonumber_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_autonumber_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_autonumber_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_autonumber_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_autonumber_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_autonumber_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_autonumber_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_autonumber_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_autonumber_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_autonumber_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_autonumber_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_autonumber_ProcessSession")]
    public IEnumerable<ProcessSession> ait_autonumber_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_autonumber_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_autonumber_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_autonumber_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_autonumber_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_autonumber_SyncErrors")]
    public IEnumerable<SyncError> ait_autonumber_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_autonumber_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_autonumber_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_autonumber_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_autonumber_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_autonumber_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_autonumber_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_autonumber_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_autonumber_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_autonumber_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_autonumber_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_autonumber_createdby")]
    public SystemUser lk_ait_autonumber_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_autonumber_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_autonumber_createdonbehalfby")]
    public SystemUser lk_ait_autonumber_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_autonumber_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_autonumber_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_autonumber_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_autonumber_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_autonumber_modifiedby")]
    public SystemUser lk_ait_autonumber_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_autonumber_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_autonumber_modifiedonbehalfby")]
    public SystemUser lk_ait_autonumber_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_autonumber_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_autonumber_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_autonumber_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_autonumber_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_ait_autonumber")]
    public Organization organization_ait_autonumber
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_ait_autonumber), new EntityRole?());
      }
    }

    public ait_autonumber(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_autonumberid"] = (object) base.Id;
            break;
          case "ait_autonumberid":
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
