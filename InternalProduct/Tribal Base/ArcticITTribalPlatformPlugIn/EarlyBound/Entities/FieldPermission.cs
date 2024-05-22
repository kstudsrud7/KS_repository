// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.FieldPermission
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("fieldpermission")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class FieldPermission : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "fieldpermission";
    public const string EntitySchemaName = "FieldPermission";
    public const string PrimaryIdAttribute = "fieldpermissionid";

    public FieldPermission()
      : base("fieldpermission")
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

    [Microsoft.Xrm.Sdk.AttributeLogicalName("attributelogicalname")]
    public string AttributeLogicalName
    {
      get => this.GetAttributeValue<string>("attributelogicalname");
      set
      {
        this.OnPropertyChanging(nameof (AttributeLogicalName));
        this.SetAttributeValue("attributelogicalname", (object) value);
        this.OnPropertyChanged(nameof (AttributeLogicalName));
      }
    }

    [Microsoft.Xrm.Sdk.AttributeLogicalName("cancreate")]
    public OptionSetValue CanCreate
    {
      get => this.GetAttributeValue<OptionSetValue>("cancreate");
      set
      {
        this.OnPropertyChanging(nameof (CanCreate));
        this.SetAttributeValue("cancreate", (object) value);
        this.OnPropertyChanged(nameof (CanCreate));
      }
    }

    [Microsoft.Xrm.Sdk.AttributeLogicalName("canread")]
    public OptionSetValue CanRead
    {
      get => this.GetAttributeValue<OptionSetValue>("canread");
      set
      {
        this.OnPropertyChanging(nameof (CanRead));
        this.SetAttributeValue("canread", (object) value);
        this.OnPropertyChanged(nameof (CanRead));
      }
    }

    [Microsoft.Xrm.Sdk.AttributeLogicalName("canupdate")]
    public OptionSetValue CanUpdate
    {
      get => this.GetAttributeValue<OptionSetValue>("canupdate");
      set
      {
        this.OnPropertyChanging(nameof (CanUpdate));
        this.SetAttributeValue("canupdate", (object) value);
        this.OnPropertyChanged(nameof (CanUpdate));
      }
    }

    [Microsoft.Xrm.Sdk.AttributeLogicalName("componentstate")]
    public OptionSetValue ComponentState
    {
      get => this.GetAttributeValue<OptionSetValue>("componentstate");
    }

    [Microsoft.Xrm.Sdk.AttributeLogicalName("entityname")]
    public string EntityName
    {
      get => this.GetAttributeValue<string>("entityname");
      set
      {
        this.OnPropertyChanging(nameof (EntityName));
        this.SetAttributeValue("entityname", (object) value);
        this.OnPropertyChanged(nameof (EntityName));
      }
    }

    [Microsoft.Xrm.Sdk.AttributeLogicalName("fieldpermissionid")]
    public Guid? FieldPermissionId
    {
      get => this.GetAttributeValue<Guid?>("fieldpermissionid");
      set
      {
        this.OnPropertyChanging(nameof (FieldPermissionId));
        this.SetAttributeValue("fieldpermissionid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (FieldPermissionId));
      }
    }

    [Microsoft.Xrm.Sdk.AttributeLogicalName("fieldpermissionid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.FieldPermissionId = new Guid?(value);
    }

    [Microsoft.Xrm.Sdk.AttributeLogicalName("fieldpermissionidunique")]
    public Guid? FieldPermissionIdUnique
    {
      get => this.GetAttributeValue<Guid?>("fieldpermissionidunique");
    }

    [Microsoft.Xrm.Sdk.AttributeLogicalName("fieldsecurityprofileid")]
    public EntityReference FieldSecurityProfileId
    {
      get => this.GetAttributeValue<EntityReference>("fieldsecurityprofileid");
      set
      {
        this.OnPropertyChanging(nameof (FieldSecurityProfileId));
        this.SetAttributeValue("fieldsecurityprofileid", (object) value);
        this.OnPropertyChanged(nameof (FieldSecurityProfileId));
      }
    }

    [Microsoft.Xrm.Sdk.AttributeLogicalName("ismanaged")]
    public bool? IsManaged => this.GetAttributeValue<bool?>("ismanaged");

    [Microsoft.Xrm.Sdk.AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get => this.GetAttributeValue<EntityReference>("organizationid");
    }

    [Microsoft.Xrm.Sdk.AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime => this.GetAttributeValue<DateTime?>("overwritetime");

    [Microsoft.Xrm.Sdk.AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [Microsoft.Xrm.Sdk.AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("FieldPermission_SyncErrors")]
    public IEnumerable<SyncError> FieldPermission_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (FieldPermission_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (FieldPermission_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (FieldPermission_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (FieldPermission_SyncErrors));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_fieldpermission")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_fieldpermission
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_fieldpermission), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_fieldpermission));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_fieldpermission), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_fieldpermission));
      }
    }

    [Microsoft.Xrm.Sdk.AttributeLogicalName("fieldsecurityprofileid")]
    [RelationshipSchemaName("lk_fieldpermission_fieldsecurityprofileid")]
    public FieldSecurityProfile lk_fieldpermission_fieldsecurityprofileid
    {
      get
      {
        return this.GetRelatedEntity<FieldSecurityProfile>(nameof (lk_fieldpermission_fieldsecurityprofileid), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_fieldpermission_fieldsecurityprofileid));
        this.SetRelatedEntity<FieldSecurityProfile>(nameof (lk_fieldpermission_fieldsecurityprofileid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_fieldpermission_fieldsecurityprofileid));
      }
    }

    [Microsoft.Xrm.Sdk.AttributeLogicalName("solutionid")]
    [RelationshipSchemaName("solution_fieldpermission")]
    public Solution solution_fieldpermission
    {
      get => this.GetRelatedEntity<Solution>(nameof (solution_fieldpermission), new EntityRole?());
    }

    public FieldPermission(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["fieldpermissionid"] = (object) base.Id;
            break;
          case "fieldpermissionid":
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
