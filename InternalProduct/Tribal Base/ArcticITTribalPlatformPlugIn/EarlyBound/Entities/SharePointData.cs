// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.SharePointData
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("sharepointdata")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class SharePointData : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "sharepointdata";
    public const string EntitySchemaName = "SharePointData";
    public const string PrimaryIdAttribute = "sharepointdataid";

    public SharePointData()
      : base("sharepointdata")
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

    [AttributeLogicalName("isvalid")]
    public bool? IsValid => this.GetAttributeValue<bool?>("isvalid");

    [AttributeLogicalName("location")]
    public EntityReference Location => this.GetAttributeValue<EntityReference>("location");

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

    [AttributeLogicalName("nextpagetoken")]
    public string NextPageToken => this.GetAttributeValue<string>("nextpagetoken");

    [AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get => this.GetAttributeValue<EntityReference>("organizationid");
    }

    [AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime => this.GetAttributeValue<DateTime?>("overwritetime");

    [AttributeLogicalName("pagenumber")]
    public int? PageNumber => this.GetAttributeValue<int?>("pagenumber");

    [AttributeLogicalName("previouspagetoken")]
    public string PreviousPageToken => this.GetAttributeValue<string>("previouspagetoken");

    [AttributeLogicalName("regardingobjectid")]
    public string RegardingObjectId => this.GetAttributeValue<string>("regardingobjectid");

    [AttributeLogicalName("sharepointdataid")]
    public Guid? SharePointDataId
    {
      get => this.GetAttributeValue<Guid?>("sharepointdataid");
      set
      {
        this.OnPropertyChanging(nameof (SharePointDataId));
        this.SetAttributeValue("sharepointdataid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (SharePointDataId));
      }
    }

    [AttributeLogicalName("sharepointdataid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.SharePointDataId = new Guid?(value);
    }

    [AttributeLogicalName("userid")]
    public EntityReference UserId => this.GetAttributeValue<EntityReference>("userid");

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_SharePointData_createdby")]
    public SystemUser lk_SharePointData_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_SharePointData_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_SharePointData_createdonbehalfby")]
    public SystemUser lk_SharePointData_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_SharePointData_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_SharePointData_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_SharePointData_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_SharePointData_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_SharePointData_modifiedby")]
    public SystemUser lk_SharePointData_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_SharePointData_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_SharePointData_modifiedonbehalfby")]
    public SystemUser lk_SharePointData_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_SharePointData_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_SharePointData_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_SharePointData_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_SharePointData_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("userid")]
    [RelationshipSchemaName("lk_sharepointdata_user")]
    public SystemUser lk_sharepointdata_user
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_sharepointdata_user), new EntityRole?());
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_sharepointdata")]
    public Organization organization_sharepointdata
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_sharepointdata), new EntityRole?());
      }
    }

    [AttributeLogicalName("location")]
    [RelationshipSchemaName("sharepointdata_sharepointdocumentlocation")]
    public SharePointDocumentLocation sharepointdata_sharepointdocumentlocation
    {
      get
      {
        return this.GetRelatedEntity<SharePointDocumentLocation>(nameof (sharepointdata_sharepointdocumentlocation), new EntityRole?());
      }
    }

    public SharePointData(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["sharepointdataid"] = (object) base.Id;
            break;
          case "sharepointdataid":
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
