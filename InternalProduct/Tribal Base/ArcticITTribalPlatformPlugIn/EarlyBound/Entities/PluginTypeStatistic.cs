// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.PluginTypeStatistic
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("plugintypestatistic")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class PluginTypeStatistic : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "plugintypestatistic";
    public const string EntitySchemaName = "PluginTypeStatistic";
    public const string PrimaryIdAttribute = "plugintypestatisticid";

    public PluginTypeStatistic()
      : base("plugintypestatistic")
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

    [AttributeLogicalName("averageexecutetimeinmilliseconds")]
    public int? AverageExecuteTimeInMilliseconds
    {
      get => this.GetAttributeValue<int?>("averageexecutetimeinmilliseconds");
    }

    [AttributeLogicalName("crashcontributionpercent")]
    public int? CrashContributionPercent
    {
      get => this.GetAttributeValue<int?>("crashcontributionpercent");
    }

    [AttributeLogicalName("crashcount")]
    public int? CrashCount => this.GetAttributeValue<int?>("crashcount");

    [AttributeLogicalName("crashpercent")]
    public int? CrashPercent => this.GetAttributeValue<int?>("crashpercent");

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

    [AttributeLogicalName("executecount")]
    public int? ExecuteCount => this.GetAttributeValue<int?>("executecount");

    [AttributeLogicalName("failurecount")]
    public int? FailureCount => this.GetAttributeValue<int?>("failurecount");

    [AttributeLogicalName("failurepercent")]
    public int? FailurePercent => this.GetAttributeValue<int?>("failurepercent");

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

    [AttributeLogicalName("plugintypeid")]
    public EntityReference PluginTypeId => this.GetAttributeValue<EntityReference>("plugintypeid");

    [AttributeLogicalName("plugintypestatisticid")]
    public Guid? PluginTypeStatisticId => this.GetAttributeValue<Guid?>("plugintypestatisticid");

    [AttributeLogicalName("plugintypestatisticid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => base.Id = value;
    }

    [AttributeLogicalName("terminatecpucontributionpercent")]
    public int? TerminateCpuContributionPercent
    {
      get => this.GetAttributeValue<int?>("terminatecpucontributionpercent");
    }

    [AttributeLogicalName("terminatehandlescontributionpercent")]
    public int? TerminateHandlesContributionPercent
    {
      get => this.GetAttributeValue<int?>("terminatehandlescontributionpercent");
    }

    [AttributeLogicalName("terminatememorycontributionpercent")]
    public int? TerminateMemoryContributionPercent
    {
      get => this.GetAttributeValue<int?>("terminatememorycontributionpercent");
    }

    [AttributeLogicalName("terminateothercontributionpercent")]
    public int? TerminateOtherContributionPercent
    {
      get => this.GetAttributeValue<int?>("terminateothercontributionpercent");
    }

    [RelationshipSchemaName("userentityinstancedata_plugintypestatistic")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_plugintypestatistic
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_plugintypestatistic), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_plugintypestatistic));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_plugintypestatistic), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_plugintypestatistic));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("createdby_plugintypestatistic")]
    public SystemUser createdby_plugintypestatistic
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (createdby_plugintypestatistic), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_plugintypestatisticbase_createdonbehalfby")]
    public SystemUser lk_plugintypestatisticbase_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_plugintypestatisticbase_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_plugintypestatisticbase_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_plugintypestatisticbase_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_plugintypestatisticbase_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_plugintypestatisticbase_modifiedonbehalfby")]
    public SystemUser lk_plugintypestatisticbase_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_plugintypestatisticbase_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_plugintypestatisticbase_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_plugintypestatisticbase_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_plugintypestatisticbase_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("modifiedby_plugintypestatistic")]
    public SystemUser modifiedby_plugintypestatistic
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (modifiedby_plugintypestatistic), new EntityRole?());
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_plugintypestatistic")]
    public Organization organization_plugintypestatistic
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_plugintypestatistic), new EntityRole?());
      }
    }

    [AttributeLogicalName("plugintypeid")]
    [RelationshipSchemaName("plugintype_plugintypestatistic")]
    public PluginType plugintype_plugintypestatistic
    {
      get
      {
        return this.GetRelatedEntity<PluginType>(nameof (plugintype_plugintypestatistic), new EntityRole?());
      }
    }

    public PluginTypeStatistic(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["plugintypestatisticid"] = (object) base.Id;
            break;
          case "plugintypestatisticid":
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
