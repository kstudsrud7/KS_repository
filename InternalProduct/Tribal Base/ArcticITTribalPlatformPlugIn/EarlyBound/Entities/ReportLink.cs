// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ReportLink
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("reportlink")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ReportLink : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "reportlink";
    public const string EntitySchemaName = "ReportLink";
    public const string PrimaryIdAttribute = "reportlinkid";

    public ReportLink()
      : base("reportlink")
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

    [AttributeLogicalName("linkedreportid")]
    public EntityReference LinkedReportId
    {
      get => this.GetAttributeValue<EntityReference>("linkedreportid");
      set
      {
        this.OnPropertyChanging(nameof (LinkedReportId));
        this.SetAttributeValue("linkedreportid", (object) value);
        this.OnPropertyChanged(nameof (LinkedReportId));
      }
    }

    [AttributeLogicalName("linkedreportname")]
    public string LinkedReportName
    {
      get => this.GetAttributeValue<string>("linkedreportname");
      set
      {
        this.OnPropertyChanging(nameof (LinkedReportName));
        this.SetAttributeValue("linkedreportname", (object) value);
        this.OnPropertyChanged(nameof (LinkedReportName));
      }
    }

    [AttributeLogicalName("linktypecode")]
    public OptionSetValue LinkTypeCode
    {
      get => this.GetAttributeValue<OptionSetValue>("linktypecode");
      set
      {
        this.OnPropertyChanging(nameof (LinkTypeCode));
        this.SetAttributeValue("linktypecode", (object) value);
        this.OnPropertyChanged(nameof (LinkTypeCode));
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

    [AttributeLogicalName("reportlinkid")]
    public Guid? ReportLinkId
    {
      get => this.GetAttributeValue<Guid?>("reportlinkid");
      set
      {
        this.OnPropertyChanging(nameof (ReportLinkId));
        this.SetAttributeValue("reportlinkid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ReportLinkId));
      }
    }

    [AttributeLogicalName("reportlinkid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ReportLinkId = new Guid?(value);
    }

    [AttributeLogicalName("reportlinkidunique")]
    public Guid? ReportLinkIdUnique => this.GetAttributeValue<Guid?>("reportlinkidunique");

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("userentityinstancedata_reportlink")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_reportlink
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_reportlink), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_reportlink));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_reportlink), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_reportlink));
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_reportlink_createdonbehalfby")]
    public SystemUser lk_reportlink_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_reportlink_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_reportlink_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_reportlink_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_reportlink_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_reportlink_modifiedonbehalfby")]
    public SystemUser lk_reportlink_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_reportlink_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_reportlink_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_reportlink_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_reportlink_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_reportlinkbase_createdby")]
    public SystemUser lk_reportlinkbase_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_reportlinkbase_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_reportlinkbase_modifiedby")]
    public SystemUser lk_reportlinkbase_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_reportlinkbase_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("reportid")]
    [RelationshipSchemaName("report_reportlink")]
    public Report report_reportlink
    {
      get => this.GetRelatedEntity<Report>(nameof (report_reportlink), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (report_reportlink));
        this.SetRelatedEntity<Report>(nameof (report_reportlink), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (report_reportlink));
      }
    }

    [AttributeLogicalName("linkedreportid")]
    [RelationshipSchemaName("report_reportlink_sub")]
    public Report report_reportlink_sub
    {
      get => this.GetRelatedEntity<Report>(nameof (report_reportlink_sub), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (report_reportlink_sub));
        this.SetRelatedEntity<Report>(nameof (report_reportlink_sub), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (report_reportlink_sub));
      }
    }

    public ReportLink(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["reportlinkid"] = (object) base.Id;
            break;
          case "reportlinkid":
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
