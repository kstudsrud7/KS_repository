// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.DuplicateRule
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("duplicaterule")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class DuplicateRule : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "duplicaterule";
    public const string EntitySchemaName = "DuplicateRule";
    public const string PrimaryIdAttribute = "duplicateruleid";
    public const string PrimaryNameAttribute = "name";

    public DuplicateRule()
      : base("duplicaterule")
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

    [AttributeLogicalName("baseentitymatchcodetable")]
    public string BaseEntityMatchCodeTable
    {
      get => this.GetAttributeValue<string>("baseentitymatchcodetable");
    }

    [AttributeLogicalName("baseentityname")]
    public string BaseEntityName
    {
      get => this.GetAttributeValue<string>("baseentityname");
      set
      {
        this.OnPropertyChanging(nameof (BaseEntityName));
        this.SetAttributeValue("baseentityname", (object) value);
        this.OnPropertyChanged(nameof (BaseEntityName));
      }
    }

    [AttributeLogicalName("baseentitytypecode")]
    public OptionSetValue BaseEntityTypeCode
    {
      get => this.GetAttributeValue<OptionSetValue>("baseentitytypecode");
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

    [AttributeLogicalName("description")]
    public string Description
    {
      get => this.GetAttributeValue<string>("description");
      set
      {
        this.OnPropertyChanging(nameof (Description));
        this.SetAttributeValue("description", (object) value);
        this.OnPropertyChanged(nameof (Description));
      }
    }

    [AttributeLogicalName("duplicateruleid")]
    public Guid? DuplicateRuleId
    {
      get => this.GetAttributeValue<Guid?>("duplicateruleid");
      set
      {
        this.OnPropertyChanging(nameof (DuplicateRuleId));
        this.SetAttributeValue("duplicateruleid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (DuplicateRuleId));
      }
    }

    [AttributeLogicalName("duplicateruleid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.DuplicateRuleId = new Guid?(value);
    }

    [AttributeLogicalName("excludeinactiverecords")]
    public bool? ExcludeInactiveRecords
    {
      get => this.GetAttributeValue<bool?>("excludeinactiverecords");
      set
      {
        this.OnPropertyChanging(nameof (ExcludeInactiveRecords));
        this.SetAttributeValue("excludeinactiverecords", (object) value);
        this.OnPropertyChanged(nameof (ExcludeInactiveRecords));
      }
    }

    [AttributeLogicalName("iscasesensitive")]
    public bool? IsCaseSensitive
    {
      get => this.GetAttributeValue<bool?>("iscasesensitive");
      set
      {
        this.OnPropertyChanging(nameof (IsCaseSensitive));
        this.SetAttributeValue("iscasesensitive", (object) value);
        this.OnPropertyChanged(nameof (IsCaseSensitive));
      }
    }

    [AttributeLogicalName("matchingentitymatchcodetable")]
    public string MatchingEntityMatchCodeTable
    {
      get => this.GetAttributeValue<string>("matchingentitymatchcodetable");
    }

    [AttributeLogicalName("matchingentityname")]
    public string MatchingEntityName
    {
      get => this.GetAttributeValue<string>("matchingentityname");
      set
      {
        this.OnPropertyChanging(nameof (MatchingEntityName));
        this.SetAttributeValue("matchingentityname", (object) value);
        this.OnPropertyChanged(nameof (MatchingEntityName));
      }
    }

    [AttributeLogicalName("matchingentitytypecode")]
    public OptionSetValue MatchingEntityTypeCode
    {
      get => this.GetAttributeValue<OptionSetValue>("matchingentitytypecode");
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

    [AttributeLogicalName("name")]
    public string Name
    {
      get => this.GetAttributeValue<string>("name");
      set
      {
        this.OnPropertyChanging(nameof (Name));
        this.SetAttributeValue("name", (object) value);
        this.OnPropertyChanged(nameof (Name));
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
    public DuplicateRuleState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new DuplicateRuleState?((DuplicateRuleState) Enum.ToObject(typeof (DuplicateRuleState), attributeValue.Value)) : new DuplicateRuleState?();
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

    [RelationshipSchemaName("DuplicateRule_Annotation")]
    public IEnumerable<Annotation> DuplicateRule_Annotation
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (DuplicateRule_Annotation), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (DuplicateRule_Annotation));
        this.SetRelatedEntities<Annotation>(nameof (DuplicateRule_Annotation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (DuplicateRule_Annotation));
      }
    }

    [RelationshipSchemaName("DuplicateRule_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> DuplicateRule_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (DuplicateRule_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (DuplicateRule_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (DuplicateRule_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (DuplicateRule_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("DuplicateRule_DuplicateRuleConditions")]
    public IEnumerable<DuplicateRuleCondition> DuplicateRule_DuplicateRuleConditions
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRuleCondition>(nameof (DuplicateRule_DuplicateRuleConditions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (DuplicateRule_DuplicateRuleConditions));
        this.SetRelatedEntities<DuplicateRuleCondition>(nameof (DuplicateRule_DuplicateRuleConditions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (DuplicateRule_DuplicateRuleConditions));
      }
    }

    [RelationshipSchemaName("DuplicateRule_SyncErrors")]
    public IEnumerable<SyncError> DuplicateRule_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (DuplicateRule_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (DuplicateRule_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (DuplicateRule_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (DuplicateRule_SyncErrors));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_duplicaterule")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_duplicaterule
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_duplicaterule), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_duplicaterule));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_duplicaterule), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_duplicaterule));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("BusinessUnit_DuplicateRules")]
    public BusinessUnit BusinessUnit_DuplicateRules
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (BusinessUnit_DuplicateRules), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_duplicaterule_createdonbehalfby")]
    public SystemUser lk_duplicaterule_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_duplicaterule_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_duplicaterule_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_duplicaterule_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_duplicaterule_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_duplicaterule_modifiedonbehalfby")]
    public SystemUser lk_duplicaterule_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_duplicaterule_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_duplicaterule_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_duplicaterule_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_duplicaterule_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_duplicaterulebase_createdby")]
    public SystemUser lk_duplicaterulebase_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_duplicaterulebase_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_duplicaterulebase_modifiedby")]
    public SystemUser lk_duplicaterulebase_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_duplicaterulebase_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("SystemUser_DuplicateRules")]
    public SystemUser SystemUser_DuplicateRules
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (SystemUser_DuplicateRules), new EntityRole?());
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_DuplicateRules")]
    public Team team_DuplicateRules
    {
      get => this.GetRelatedEntity<Team>(nameof (team_DuplicateRules), new EntityRole?());
    }

    public DuplicateRule(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["duplicateruleid"] = (object) base.Id;
            break;
          case "duplicateruleid":
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
