﻿// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ReportVisibility
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("reportvisibility")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ReportVisibility : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "reportvisibility";
    public const string EntitySchemaName = "ReportVisibility";
    public const string PrimaryIdAttribute = "reportvisibilityid";

    public ReportVisibility()
      : base("reportvisibility")
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

    [AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime => this.GetAttributeValue<DateTime?>("overwritetime");

    [AttributeLogicalName("ownerid")]
    public EntityReference OwnerId => this.GetAttributeValue<EntityReference>("ownerid");

    [AttributeLogicalName("owningbusinessunit")]
    public Guid? OwningBusinessUnit => this.GetAttributeValue<Guid?>("owningbusinessunit");

    [AttributeLogicalName("owninguser")]
    public Guid? OwningUser => this.GetAttributeValue<Guid?>("owninguser");

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

    [AttributeLogicalName("reportvisibilityid")]
    public Guid? ReportVisibilityId
    {
      get => this.GetAttributeValue<Guid?>("reportvisibilityid");
      set
      {
        this.OnPropertyChanging(nameof (ReportVisibilityId));
        this.SetAttributeValue("reportvisibilityid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ReportVisibilityId));
      }
    }

    [AttributeLogicalName("reportvisibilityid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ReportVisibilityId = new Guid?(value);
    }

    [AttributeLogicalName("reportvisibilityidunique")]
    public Guid? ReportVisibilityIdUnique
    {
      get => this.GetAttributeValue<Guid?>("reportvisibilityidunique");
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [AttributeLogicalName("visibilitycode")]
    public OptionSetValue VisibilityCode
    {
      get => this.GetAttributeValue<OptionSetValue>("visibilitycode");
      set
      {
        this.OnPropertyChanging(nameof (VisibilityCode));
        this.SetAttributeValue("visibilitycode", (object) value);
        this.OnPropertyChanged(nameof (VisibilityCode));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_reportvisibility")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_reportvisibility
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_reportvisibility), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_reportvisibility));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_reportvisibility), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_reportvisibility));
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_reportvisibility_createdonbehalfby")]
    public SystemUser lk_reportvisibility_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_reportvisibility_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_reportvisibility_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_reportvisibility_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_reportvisibility_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_reportvisibility_modifiedonbehalfby")]
    public SystemUser lk_reportvisibility_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_reportvisibility_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_reportvisibility_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_reportvisibility_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_reportvisibility_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_reportvisibilitybase_createdby")]
    public SystemUser lk_reportvisibilitybase_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_reportvisibilitybase_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_reportvisibilitybase_modifiedby")]
    public SystemUser lk_reportvisibilitybase_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_reportvisibilitybase_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("reportid")]
    [RelationshipSchemaName("report_reportvisibility")]
    public Report report_reportvisibility
    {
      get => this.GetRelatedEntity<Report>(nameof (report_reportvisibility), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (report_reportvisibility));
        this.SetRelatedEntity<Report>(nameof (report_reportvisibility), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (report_reportvisibility));
      }
    }

    public ReportVisibility(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["reportvisibilityid"] = (object) base.Id;
            break;
          case "reportvisibilityid":
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