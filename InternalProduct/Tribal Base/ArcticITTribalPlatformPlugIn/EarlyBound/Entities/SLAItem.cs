// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.SLAItem
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("slaitem")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class SLAItem : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "slaitem";
    public const string EntitySchemaName = "SLAItem";
    public const string PrimaryIdAttribute = "slaitemid";
    public const string PrimaryNameAttribute = "name";

    public SLAItem()
      : base("slaitem")
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

    [AttributeLogicalName("actionflowuniquename")]
    public string actionflowuniquename
    {
      get => this.GetAttributeValue<string>(nameof (actionflowuniquename));
      set
      {
        this.OnPropertyChanging(nameof (actionflowuniquename));
        this.SetAttributeValue(nameof (actionflowuniquename), (object) value);
        this.OnPropertyChanged(nameof (actionflowuniquename));
      }
    }

    [AttributeLogicalName("actionurl")]
    public string ActionURL
    {
      get => this.GetAttributeValue<string>("actionurl");
      set
      {
        this.OnPropertyChanging(nameof (ActionURL));
        this.SetAttributeValue("actionurl", (object) value);
        this.OnPropertyChanged(nameof (ActionURL));
      }
    }

    [AttributeLogicalName("allowpauseresume")]
    public bool? AllowPauseResume
    {
      get => this.GetAttributeValue<bool?>("allowpauseresume");
      set
      {
        this.OnPropertyChanging(nameof (AllowPauseResume));
        this.SetAttributeValue("allowpauseresume", (object) value);
        this.OnPropertyChanged(nameof (AllowPauseResume));
      }
    }

    [AttributeLogicalName("applicableentity")]
    public string ApplicableEntity
    {
      get => this.GetAttributeValue<string>("applicableentity");
      set
      {
        this.OnPropertyChanging(nameof (ApplicableEntity));
        this.SetAttributeValue("applicableentity", (object) value);
        this.OnPropertyChanged(nameof (ApplicableEntity));
      }
    }

    [AttributeLogicalName("applicablewhenxml")]
    public string ApplicableWhenXml
    {
      get => this.GetAttributeValue<string>("applicablewhenxml");
      set
      {
        this.OnPropertyChanging(nameof (ApplicableWhenXml));
        this.SetAttributeValue("applicablewhenxml", (object) value);
        this.OnPropertyChanged(nameof (ApplicableWhenXml));
      }
    }

    [AttributeLogicalName("businesshoursid")]
    public EntityReference BusinessHoursId
    {
      get => this.GetAttributeValue<EntityReference>("businesshoursid");
      set
      {
        this.OnPropertyChanging(nameof (BusinessHoursId));
        this.SetAttributeValue("businesshoursid", (object) value);
        this.OnPropertyChanged(nameof (BusinessHoursId));
      }
    }

    [AttributeLogicalName("changedattributelist")]
    public string ChangedAttributeList
    {
      get => this.GetAttributeValue<string>("changedattributelist");
      set
      {
        this.OnPropertyChanging(nameof (ChangedAttributeList));
        this.SetAttributeValue("changedattributelist", (object) value);
        this.OnPropertyChanged(nameof (ChangedAttributeList));
      }
    }

    [AttributeLogicalName("componentstate")]
    public OptionSetValue ComponentState
    {
      get => this.GetAttributeValue<OptionSetValue>("componentstate");
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

    [AttributeLogicalName("failureafter")]
    public int? FailureAfter
    {
      get => this.GetAttributeValue<int?>("failureafter");
      set
      {
        this.OnPropertyChanging(nameof (FailureAfter));
        this.SetAttributeValue("failureafter", (object) value);
        this.OnPropertyChanged(nameof (FailureAfter));
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

    [AttributeLogicalName("msdyn_advancedpauseconfiguration")]
    public bool? msdyn_AdvancedPauseConfiguration
    {
      get => this.GetAttributeValue<bool?>("msdyn_advancedpauseconfiguration");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_AdvancedPauseConfiguration));
        this.SetAttributeValue("msdyn_advancedpauseconfiguration", (object) value);
        this.OnPropertyChanged(nameof (msdyn_AdvancedPauseConfiguration));
      }
    }

    [AttributeLogicalName("msdyn_pauseconfigurationxml")]
    public string msdyn_PauseConfigurationXml
    {
      get => this.GetAttributeValue<string>("msdyn_pauseconfigurationxml");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_PauseConfigurationXml));
        this.SetAttributeValue("msdyn_pauseconfigurationxml", (object) value);
        this.OnPropertyChanged(nameof (msdyn_PauseConfigurationXml));
      }
    }

    [AttributeLogicalName("msdyn_slakpiid")]
    public EntityReference msdyn_slakpiid
    {
      get => this.GetAttributeValue<EntityReference>(nameof (msdyn_slakpiid));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_slakpiid));
        this.SetAttributeValue(nameof (msdyn_slakpiid), (object) value);
        this.OnPropertyChanged(nameof (msdyn_slakpiid));
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
    public EntityReference OwningUser
    {
      get => this.GetAttributeValue<EntityReference>("owninguser");
      set
      {
        this.OnPropertyChanging(nameof (OwningUser));
        this.SetAttributeValue("owninguser", (object) value);
        this.OnPropertyChanged(nameof (OwningUser));
      }
    }

    [AttributeLogicalName("relatedfield")]
    public string RelatedField
    {
      get => this.GetAttributeValue<string>("relatedfield");
      set
      {
        this.OnPropertyChanging(nameof (RelatedField));
        this.SetAttributeValue("relatedfield", (object) value);
        this.OnPropertyChanged(nameof (RelatedField));
      }
    }

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

    [AttributeLogicalName("slaid")]
    public EntityReference SLAId
    {
      get => this.GetAttributeValue<EntityReference>("slaid");
      set
      {
        this.OnPropertyChanging(nameof (SLAId));
        this.SetAttributeValue("slaid", (object) value);
        this.OnPropertyChanged(nameof (SLAId));
      }
    }

    [AttributeLogicalName("slaitemid")]
    public Guid? SLAItemId
    {
      get => this.GetAttributeValue<Guid?>("slaitemid");
      set
      {
        this.OnPropertyChanging(nameof (SLAItemId));
        this.SetAttributeValue("slaitemid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (SLAItemId));
      }
    }

    [AttributeLogicalName("slaitemid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.SLAItemId = new Guid?(value);
    }

    [AttributeLogicalName("slaitemidunique")]
    public Guid? SLAItemIdUnique => this.GetAttributeValue<Guid?>("slaitemidunique");

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("successconditionsxml")]
    public string SuccessConditionsXml
    {
      get => this.GetAttributeValue<string>("successconditionsxml");
      set
      {
        this.OnPropertyChanging(nameof (SuccessConditionsXml));
        this.SetAttributeValue("successconditionsxml", (object) value);
        this.OnPropertyChanged(nameof (SuccessConditionsXml));
      }
    }

    [AttributeLogicalName("transactioncurrencyid")]
    public EntityReference TransactionCurrencyId
    {
      get => this.GetAttributeValue<EntityReference>("transactioncurrencyid");
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [AttributeLogicalName("warnafter")]
    public int? WarnAfter
    {
      get => this.GetAttributeValue<int?>("warnafter");
      set
      {
        this.OnPropertyChanging(nameof (WarnAfter));
        this.SetAttributeValue("warnafter", (object) value);
        this.OnPropertyChanged(nameof (WarnAfter));
      }
    }

    [AttributeLogicalName("workflowid")]
    public EntityReference WorkflowId
    {
      get => this.GetAttributeValue<EntityReference>("workflowid");
      set
      {
        this.OnPropertyChanging(nameof (WorkflowId));
        this.SetAttributeValue("workflowid", (object) value);
        this.OnPropertyChanged(nameof (WorkflowId));
      }
    }

    [RelationshipSchemaName("msdyn_slaitem_slakpiinstance")]
    public IEnumerable<SLAKPIInstance> msdyn_slaitem_slakpiinstance
    {
      get
      {
        return this.GetRelatedEntities<SLAKPIInstance>(nameof (msdyn_slaitem_slakpiinstance), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_slaitem_slakpiinstance));
        this.SetRelatedEntities<SLAKPIInstance>(nameof (msdyn_slaitem_slakpiinstance), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_slaitem_slakpiinstance));
      }
    }

    [RelationshipSchemaName("SLAItem_SyncErrors")]
    public IEnumerable<SyncError> SLAItem_SyncErrors
    {
      get => this.GetRelatedEntities<SyncError>(nameof (SLAItem_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (SLAItem_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (SLAItem_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SLAItem_SyncErrors));
      }
    }

    [AttributeLogicalName("businesshoursid")]
    [RelationshipSchemaName("calendar_slaitem")]
    public Calendar calendar_slaitem
    {
      get => this.GetRelatedEntity<Calendar>(nameof (calendar_slaitem), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (calendar_slaitem));
        this.SetRelatedEntity<Calendar>(nameof (calendar_slaitem), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (calendar_slaitem));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_slaitembase_createdby")]
    public SystemUser lk_slaitembase_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_slaitembase_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_slaitembase_createdonbehalfby")]
    public SystemUser lk_slaitembase_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_slaitembase_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_slaitembase_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_slaitembase_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_slaitembase_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_slaitembase_modifiedby")]
    public SystemUser lk_slaitembase_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_slaitembase_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_slaitembase_modifiedonbehalfby")]
    public SystemUser lk_slaitembase_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_slaitembase_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_slaitembase_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_slaitembase_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_slaitembase_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("msdyn_slakpiid")]
    [RelationshipSchemaName("msdyn_msdyn_slakpi_slaitem")]
    public msdyn_slakpi msdyn_msdyn_slakpi_slaitem
    {
      get
      {
        return this.GetRelatedEntity<msdyn_slakpi>(nameof (msdyn_msdyn_slakpi_slaitem), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_msdyn_slakpi_slaitem));
        this.SetRelatedEntity<msdyn_slakpi>(nameof (msdyn_msdyn_slakpi_slaitem), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_msdyn_slakpi_slaitem));
      }
    }

    [AttributeLogicalName("slaid")]
    [RelationshipSchemaName("sla_slaitem_slaId")]
    public SLA sla_slaitem_slaId
    {
      get => this.GetRelatedEntity<SLA>(nameof (sla_slaitem_slaId), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (sla_slaitem_slaId));
        this.SetRelatedEntity<SLA>(nameof (sla_slaitem_slaId), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (sla_slaitem_slaId));
      }
    }

    [AttributeLogicalName("workflowid")]
    [RelationshipSchemaName("slaitembase_workflowid")]
    public Workflow slaitembase_workflowid
    {
      get => this.GetRelatedEntity<Workflow>(nameof (slaitembase_workflowid), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (slaitembase_workflowid));
        this.SetRelatedEntity<Workflow>(nameof (slaitembase_workflowid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (slaitembase_workflowid));
      }
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_SLAItem")]
    public TransactionCurrency TransactionCurrency_SLAItem
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_SLAItem), new EntityRole?());
      }
    }

    public SLAItem(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["slaitemid"] = (object) base.Id;
            break;
          case "slaitemid":
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
