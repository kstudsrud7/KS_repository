// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ReportEntity
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("reportentity")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ReportEntity : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "reportentity";
    public const string EntitySchemaName = "ReportEntity";
    public const string PrimaryIdAttribute = "reportentityid";

    public ReportEntity()
      : base("reportentity")
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

    [AttributeLogicalName("iscustomizable")]
    public BooleanManagedProperty IsCustomizable
    {
      get => this.GetAttributeValue<BooleanManagedProperty>("iscustomizable");
      set
      {
        this.OnPropertyChanging(nameof (IsCustomizable));
        this.SetAttributeValue("iscustomizable", (object) value);
        this.OnPropertyChanged(nameof (IsCustomizable));
      }
    }

    [AttributeLogicalName("isfilterable")]
    public bool? IsFilterable
    {
      get => this.GetAttributeValue<bool?>("isfilterable");
      set
      {
        this.OnPropertyChanging(nameof (IsFilterable));
        this.SetAttributeValue("isfilterable", (object) value);
        this.OnPropertyChanged(nameof (IsFilterable));
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

    [AttributeLogicalName("objecttypecode")]
    public string ObjectTypeCode
    {
      get => this.GetAttributeValue<string>("objecttypecode");
      set
      {
        this.OnPropertyChanging(nameof (ObjectTypeCode));
        this.SetAttributeValue("objecttypecode", (object) value);
        this.OnPropertyChanged(nameof (ObjectTypeCode));
      }
    }

    [AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime => this.GetAttributeValue<DateTime?>("overwritetime");

    [AttributeLogicalName("ownerid")]
    public EntityReference OwnerId => this.GetAttributeValue<EntityReference>("ownerid");

    [AttributeLogicalName("owningbusinessunit")]
    public Guid? OwningBusinessUnit => this.GetAttributeValue<Guid?>("owningbusinessunit");

    [AttributeLogicalName("owninguser")]
    public Guid? OwningUser => this.GetAttributeValue<Guid?>("owninguser");

    [AttributeLogicalName("reportentityid")]
    public Guid? ReportEntityId
    {
      get => this.GetAttributeValue<Guid?>("reportentityid");
      set
      {
        this.OnPropertyChanging(nameof (ReportEntityId));
        this.SetAttributeValue("reportentityid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ReportEntityId));
      }
    }

    [AttributeLogicalName("reportentityid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ReportEntityId = new Guid?(value);
    }

    [AttributeLogicalName("reportentityidunique")]
    public Guid? ReportEntityIdUnique => this.GetAttributeValue<Guid?>("reportentityidunique");

    [AttributeLogicalName("reportid")]
    public EntityReference ReportId
    {
      get => this.GetAttributeValue<EntityReference>("reportid");
      set
      {
        this.OnPropertyChanging(nameof (ReportId));
        this.SetAttributeValue("reportid", (object) value);
        this.OnPropertyChanged(nameof (ReportId));
      }
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("userentityinstancedata_reportentity")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_reportentity
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_reportentity), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_reportentity));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_reportentity), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_reportentity));
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_reportentity_createdonbehalfby")]
    public SystemUser lk_reportentity_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_reportentity_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_reportentity_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_reportentity_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_reportentity_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_reportentity_modifiedonbehalfby")]
    public SystemUser lk_reportentity_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_reportentity_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_reportentity_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_reportentity_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_reportentity_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_reportentitybase_createdby")]
    public SystemUser lk_reportentitybase_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_reportentitybase_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_reportentitybase_modifiedby")]
    public SystemUser lk_reportentitybase_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_reportentitybase_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("reportid")]
    [RelationshipSchemaName("report_reportentities")]
    public Report report_reportentities
    {
      get => this.GetRelatedEntity<Report>(nameof (report_reportentities), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (report_reportentities));
        this.SetRelatedEntity<Report>(nameof (report_reportentities), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (report_reportentities));
      }
    }

    public ReportEntity(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["reportentityid"] = (object) base.Id;
            break;
          case "reportentityid":
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
