// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ChannelAccessProfileRuleItem
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("channelaccessprofileruleitem")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ChannelAccessProfileRuleItem : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "channelaccessprofileruleitem";
    public const string EntitySchemaName = "ChannelAccessProfileRuleItem";
    public const string PrimaryIdAttribute = "channelaccessprofileruleitemid";
    public const string PrimaryNameAttribute = "name";

    public ChannelAccessProfileRuleItem()
      : base("channelaccessprofileruleitem")
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

    [AttributeLogicalName("associatedchannelaccessprofile")]
    public EntityReference AssociatedChannelAccessProfile
    {
      get => this.GetAttributeValue<EntityReference>("associatedchannelaccessprofile");
      set
      {
        this.OnPropertyChanging(nameof (AssociatedChannelAccessProfile));
        this.SetAttributeValue("associatedchannelaccessprofile", (object) value);
        this.OnPropertyChanged(nameof (AssociatedChannelAccessProfile));
      }
    }

    [AttributeLogicalName("channelaccessprofileruleid")]
    public EntityReference ChannelAccessProfileRuleId
    {
      get => this.GetAttributeValue<EntityReference>("channelaccessprofileruleid");
      set
      {
        this.OnPropertyChanging(nameof (ChannelAccessProfileRuleId));
        this.SetAttributeValue("channelaccessprofileruleid", (object) value);
        this.OnPropertyChanged(nameof (ChannelAccessProfileRuleId));
      }
    }

    [AttributeLogicalName("channelaccessprofileruleitemid")]
    public Guid? ChannelAccessProfileRuleItemId
    {
      get => this.GetAttributeValue<Guid?>("channelaccessprofileruleitemid");
      set
      {
        this.OnPropertyChanging(nameof (ChannelAccessProfileRuleItemId));
        this.SetAttributeValue("channelaccessprofileruleitemid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ChannelAccessProfileRuleItemId));
      }
    }

    [AttributeLogicalName("channelaccessprofileruleitemid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ChannelAccessProfileRuleItemId = new Guid?(value);
    }

    [AttributeLogicalName("channelaccessprofileruleitemidunique")]
    public Guid? ChannelAccessProfileRuleItemIdUnique
    {
      get => this.GetAttributeValue<Guid?>("channelaccessprofileruleitemidunique");
    }

    [AttributeLogicalName("componentstate")]
    public OptionSetValue ComponentState
    {
      get => this.GetAttributeValue<OptionSetValue>("componentstate");
    }

    [AttributeLogicalName("conditionxml")]
    public string ConditionXml
    {
      get => this.GetAttributeValue<string>("conditionxml");
      set
      {
        this.OnPropertyChanging(nameof (ConditionXml));
        this.SetAttributeValue("conditionxml", (object) value);
        this.OnPropertyChanged(nameof (ConditionXml));
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

    [AttributeLogicalName("exchangerate")]
    public Decimal? ExchangeRate => this.GetAttributeValue<Decimal?>("exchangerate");

    [AttributeLogicalName("introducedversion")]
    public string IntroducedVersion
    {
      get => this.GetAttributeValue<string>("introducedversion");
      set
      {
        this.OnPropertyChanging(nameof (IntroducedVersion));
        this.SetAttributeValue("introducedversion", (object) value);
        this.OnPropertyChanged(nameof (IntroducedVersion));
      }
    }

    [AttributeLogicalName("ismanaged")]
    public bool? IsManaged => this.GetAttributeValue<bool?>("ismanaged");

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

    [AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime => this.GetAttributeValue<DateTime?>("overwritetime");

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

    [AttributeLogicalName("owninguser")]
    public EntityReference OwningUser => this.GetAttributeValue<EntityReference>("owninguser");

    [AttributeLogicalName("sequencenumber")]
    public int? SequenceNumber
    {
      get => this.GetAttributeValue<int?>("sequencenumber");
      set
      {
        this.OnPropertyChanging(nameof (SequenceNumber));
        this.SetAttributeValue("sequencenumber", (object) value);
        this.OnPropertyChanged(nameof (SequenceNumber));
      }
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

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

    [AttributeLogicalName("transactioncurrencyid")]
    public EntityReference TransactionCurrencyId
    {
      get => this.GetAttributeValue<EntityReference>("transactioncurrencyid");
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrencyId));
        this.SetAttributeValue("transactioncurrencyid", (object) value);
        this.OnPropertyChanged(nameof (TransactionCurrencyId));
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

    [RelationshipSchemaName("ChannelAccessProfileRuleItem_SyncErrors")]
    public IEnumerable<SyncError> ChannelAccessProfileRuleItem_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ChannelAccessProfileRuleItem_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ChannelAccessProfileRuleItem_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ChannelAccessProfileRuleItem_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ChannelAccessProfileRuleItem_SyncErrors));
      }
    }

    [RelationshipSchemaName("profileruleitem_Annotations")]
    public IEnumerable<Annotation> profileruleitem_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (profileruleitem_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (profileruleitem_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (profileruleitem_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (profileruleitem_Annotations));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_profileruleitem_createdby")]
    public SystemUser lk_profileruleitem_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_profileruleitem_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_profileruleitem_createdonbehalfby")]
    public SystemUser lk_profileruleitem_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_profileruleitem_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_profileruleitem_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_profileruleitem_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_profileruleitem_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_profileruleitem_modifiedby")]
    public SystemUser lk_profileruleitem_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_profileruleitem_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_profileruleitem_modifiedonbehalfby")]
    public SystemUser lk_profileruleitem_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_profileruleitem_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_profileruleitem_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_profileruleitem_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_profileruleitem_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("channelaccessprofileruleid")]
    [RelationshipSchemaName("profilerule_entries")]
    public ChannelAccessProfileRule profilerule_entries
    {
      get
      {
        return this.GetRelatedEntity<ChannelAccessProfileRule>(nameof (profilerule_entries), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (profilerule_entries));
        this.SetRelatedEntity<ChannelAccessProfileRule>(nameof (profilerule_entries), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (profilerule_entries));
      }
    }

    [AttributeLogicalName("associatedchannelaccessprofile")]
    [RelationshipSchemaName("profileruleitem_associated_channelaccessprofile")]
    public ChannelAccessProfile profileruleitem_associated_channelaccessprofile
    {
      get
      {
        return this.GetRelatedEntity<ChannelAccessProfile>(nameof (profileruleitem_associated_channelaccessprofile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (profileruleitem_associated_channelaccessprofile));
        this.SetRelatedEntity<ChannelAccessProfile>(nameof (profileruleitem_associated_channelaccessprofile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (profileruleitem_associated_channelaccessprofile));
      }
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_profileruleitem")]
    public TransactionCurrency TransactionCurrency_profileruleitem
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_profileruleitem), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_profileruleitem));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_profileruleitem), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_profileruleitem));
      }
    }

    public ChannelAccessProfileRuleItem(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["channelaccessprofileruleitemid"] = (object) base.Id;
            break;
          case "channelaccessprofileruleitemid":
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
