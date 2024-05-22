// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.DuplicateRuleCondition
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("duplicaterulecondition")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class DuplicateRuleCondition : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "duplicaterulecondition";
    public const string EntitySchemaName = "DuplicateRuleCondition";
    public const string PrimaryIdAttribute = "duplicateruleconditionid";

    public DuplicateRuleCondition()
      : base("duplicaterulecondition")
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

    [AttributeLogicalName("baseattributename")]
    public string BaseAttributeName
    {
      get => this.GetAttributeValue<string>("baseattributename");
      set
      {
        this.OnPropertyChanging(nameof (BaseAttributeName));
        this.SetAttributeValue("baseattributename", (object) value);
        this.OnPropertyChanged(nameof (BaseAttributeName));
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

    [AttributeLogicalName("duplicateruleconditionid")]
    public Guid? DuplicateRuleConditionId
    {
      get => this.GetAttributeValue<Guid?>("duplicateruleconditionid");
      set
      {
        this.OnPropertyChanging(nameof (DuplicateRuleConditionId));
        this.SetAttributeValue("duplicateruleconditionid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (DuplicateRuleConditionId));
      }
    }

    [AttributeLogicalName("duplicateruleconditionid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.DuplicateRuleConditionId = new Guid?(value);
    }

    [AttributeLogicalName("ignoreblankvalues")]
    public bool? IgnoreBlankValues
    {
      get => this.GetAttributeValue<bool?>("ignoreblankvalues");
      set
      {
        this.OnPropertyChanging(nameof (IgnoreBlankValues));
        this.SetAttributeValue("ignoreblankvalues", (object) value);
        this.OnPropertyChanged(nameof (IgnoreBlankValues));
      }
    }

    [AttributeLogicalName("matchingattributename")]
    public string MatchingAttributeName
    {
      get => this.GetAttributeValue<string>("matchingattributename");
      set
      {
        this.OnPropertyChanging(nameof (MatchingAttributeName));
        this.SetAttributeValue("matchingattributename", (object) value);
        this.OnPropertyChanged(nameof (MatchingAttributeName));
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

    [AttributeLogicalName("operatorcode")]
    public OptionSetValue OperatorCode
    {
      get => this.GetAttributeValue<OptionSetValue>("operatorcode");
      set
      {
        this.OnPropertyChanging(nameof (OperatorCode));
        this.SetAttributeValue("operatorcode", (object) value);
        this.OnPropertyChanged(nameof (OperatorCode));
      }
    }

    [AttributeLogicalName("operatorparam")]
    public int? OperatorParam
    {
      get => this.GetAttributeValue<int?>("operatorparam");
      set
      {
        this.OnPropertyChanging(nameof (OperatorParam));
        this.SetAttributeValue("operatorparam", (object) value);
        this.OnPropertyChanged(nameof (OperatorParam));
      }
    }

    [AttributeLogicalName("ownerid")]
    public EntityReference OwnerId => this.GetAttributeValue<EntityReference>("ownerid");

    [AttributeLogicalName("owningbusinessunit")]
    public Guid? OwningBusinessUnit => this.GetAttributeValue<Guid?>("owningbusinessunit");

    [AttributeLogicalName("owninguser")]
    public Guid? OwningUser => this.GetAttributeValue<Guid?>("owninguser");

    [AttributeLogicalName("regardingobjectid")]
    public EntityReference RegardingObjectId
    {
      get => this.GetAttributeValue<EntityReference>("regardingobjectid");
      set
      {
        this.OnPropertyChanging(nameof (RegardingObjectId));
        this.SetAttributeValue("regardingobjectid", (object) value);
        this.OnPropertyChanged(nameof (RegardingObjectId));
      }
    }

    [RelationshipSchemaName("DuplicateRuleCondition_SyncErrors")]
    public IEnumerable<SyncError> DuplicateRuleCondition_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (DuplicateRuleCondition_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (DuplicateRuleCondition_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (DuplicateRuleCondition_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (DuplicateRuleCondition_SyncErrors));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_duplicaterulecondition")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_duplicaterulecondition
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_duplicaterulecondition), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_duplicaterulecondition));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_duplicaterulecondition), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_duplicaterulecondition));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("DuplicateRule_DuplicateRuleConditions")]
    public DuplicateRule DuplicateRule_DuplicateRuleConditions
    {
      get
      {
        return this.GetRelatedEntity<DuplicateRule>(nameof (DuplicateRule_DuplicateRuleConditions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (DuplicateRule_DuplicateRuleConditions));
        this.SetRelatedEntity<DuplicateRule>(nameof (DuplicateRule_DuplicateRuleConditions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (DuplicateRule_DuplicateRuleConditions));
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_duplicaterulecondition_createdonbehalfby")]
    public SystemUser lk_duplicaterulecondition_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_duplicaterulecondition_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_duplicaterulecondition_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_duplicaterulecondition_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_duplicaterulecondition_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_duplicaterulecondition_modifiedonbehalfby")]
    public SystemUser lk_duplicaterulecondition_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_duplicaterulecondition_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_duplicaterulecondition_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_duplicaterulecondition_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_duplicaterulecondition_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_duplicateruleconditionbase_createdby")]
    public SystemUser lk_duplicateruleconditionbase_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_duplicateruleconditionbase_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_duplicateruleconditionbase_modifiedby")]
    public SystemUser lk_duplicateruleconditionbase_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_duplicateruleconditionbase_modifiedby), new EntityRole?());
      }
    }

    public DuplicateRuleCondition(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["duplicateruleconditionid"] = (object) base.Id;
            break;
          case "duplicateruleconditionid":
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
