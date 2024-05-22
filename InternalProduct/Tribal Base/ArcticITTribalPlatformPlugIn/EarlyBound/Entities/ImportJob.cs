// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ImportJob
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("importjob")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ImportJob : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "importjob";
    public const string EntitySchemaName = "ImportJob";
    public const string PrimaryIdAttribute = "importjobid";

    public ImportJob()
      : base("importjob")
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

    [AttributeLogicalName("completedon")]
    public DateTime? CompletedOn => this.GetAttributeValue<DateTime?>("completedon");

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

    [AttributeLogicalName("data")]
    public string Data
    {
      get => this.GetAttributeValue<string>("data");
      set
      {
        this.OnPropertyChanging(nameof (Data));
        this.SetAttributeValue("data", (object) value);
        this.OnPropertyChanged(nameof (Data));
      }
    }

    [AttributeLogicalName("importcontext")]
    public string ImportContext
    {
      get => this.GetAttributeValue<string>("importcontext");
      set
      {
        this.OnPropertyChanging(nameof (ImportContext));
        this.SetAttributeValue("importcontext", (object) value);
        this.OnPropertyChanged(nameof (ImportContext));
      }
    }

    [AttributeLogicalName("importjobid")]
    public Guid? ImportJobId
    {
      get => this.GetAttributeValue<Guid?>("importjobid");
      set
      {
        this.OnPropertyChanging(nameof (ImportJobId));
        this.SetAttributeValue("importjobid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ImportJobId));
      }
    }

    [AttributeLogicalName("importjobid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ImportJobId = new Guid?(value);
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

    [AttributeLogicalName("operationcontext")]
    public string OperationContext
    {
      get => this.GetAttributeValue<string>("operationcontext");
      set
      {
        this.OnPropertyChanging(nameof (OperationContext));
        this.SetAttributeValue("operationcontext", (object) value);
        this.OnPropertyChanged(nameof (OperationContext));
      }
    }

    [AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get => this.GetAttributeValue<EntityReference>("organizationid");
    }

    [AttributeLogicalName("progress")]
    public double? Progress
    {
      get => this.GetAttributeValue<double?>("progress");
      set
      {
        this.OnPropertyChanging(nameof (Progress));
        this.SetAttributeValue("progress", (object) value);
        this.OnPropertyChanged(nameof (Progress));
      }
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("solutionname")]
    public string SolutionName
    {
      get => this.GetAttributeValue<string>("solutionname");
      set
      {
        this.OnPropertyChanging(nameof (SolutionName));
        this.SetAttributeValue("solutionname", (object) value);
        this.OnPropertyChanged(nameof (SolutionName));
      }
    }

    [AttributeLogicalName("startedon")]
    public DateTime? StartedOn => this.GetAttributeValue<DateTime?>("startedon");

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

    [RelationshipSchemaName("userentityinstancedata_importjob")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_importjob
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_importjob), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_importjob));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_importjob), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_importjob));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_importjobbase_createdby")]
    public SystemUser lk_importjobbase_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_importjobbase_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_importjobbase_createdonbehalfby")]
    public SystemUser lk_importjobbase_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_importjobbase_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_importjobbase_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_importjobbase_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_importjobbase_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_importjobbase_modifiedby")]
    public SystemUser lk_importjobbase_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_importjobbase_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_importjobbase_modifiedonbehalfby")]
    public SystemUser lk_importjobbase_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_importjobbase_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_importjobbase_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_importjobbase_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_importjobbase_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_importjob")]
    public Organization organization_importjob
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_importjob), new EntityRole?());
      }
    }

    public ImportJob(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["importjobid"] = (object) base.Id;
            break;
          case "importjobid":
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
