// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.FieldSecurityProfile
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("fieldsecurityprofile")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class FieldSecurityProfile : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "fieldsecurityprofile";
    public const string EntitySchemaName = "FieldSecurityProfile";
    public const string PrimaryIdAttribute = "fieldsecurityprofileid";
    public const string PrimaryNameAttribute = "name";

    public FieldSecurityProfile()
      : base("fieldsecurityprofile")
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

    [AttributeLogicalName("fieldsecurityprofileid")]
    public Guid? FieldSecurityProfileId
    {
      get => this.GetAttributeValue<Guid?>("fieldsecurityprofileid");
      set
      {
        this.OnPropertyChanging(nameof (FieldSecurityProfileId));
        this.SetAttributeValue("fieldsecurityprofileid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (FieldSecurityProfileId));
      }
    }

    [AttributeLogicalName("fieldsecurityprofileid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.FieldSecurityProfileId = new Guid?(value);
    }

    [AttributeLogicalName("fieldsecurityprofileidunique")]
    public Guid? FieldSecurityProfileIdUnique
    {
      get => this.GetAttributeValue<Guid?>("fieldsecurityprofileidunique");
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

    [AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get => this.GetAttributeValue<EntityReference>("organizationid");
    }

    [AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime => this.GetAttributeValue<DateTime?>("overwritetime");

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("FieldSecurityProfile_SyncErrors")]
    public IEnumerable<SyncError> FieldSecurityProfile_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (FieldSecurityProfile_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (FieldSecurityProfile_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (FieldSecurityProfile_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (FieldSecurityProfile_SyncErrors));
      }
    }

    [RelationshipSchemaName("lk_fieldpermission_fieldsecurityprofileid")]
    public IEnumerable<FieldPermission> lk_fieldpermission_fieldsecurityprofileid
    {
      get
      {
        return this.GetRelatedEntities<FieldPermission>(nameof (lk_fieldpermission_fieldsecurityprofileid), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_fieldpermission_fieldsecurityprofileid));
        this.SetRelatedEntities<FieldPermission>(nameof (lk_fieldpermission_fieldsecurityprofileid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_fieldpermission_fieldsecurityprofileid));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_fieldsecurityprofile")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_fieldsecurityprofile
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_fieldsecurityprofile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_fieldsecurityprofile));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_fieldsecurityprofile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_fieldsecurityprofile));
      }
    }

    [RelationshipSchemaName("applicationuserprofile")]
    public IEnumerable<ApplicationUser> applicationuserprofile
    {
      get
      {
        return this.GetRelatedEntities<ApplicationUser>(nameof (applicationuserprofile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (applicationuserprofile));
        this.SetRelatedEntities<ApplicationUser>(nameof (applicationuserprofile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (applicationuserprofile));
      }
    }

    [RelationshipSchemaName("systemuserprofiles_association")]
    public IEnumerable<SystemUser> systemuserprofiles_association
    {
      get
      {
        return this.GetRelatedEntities<SystemUser>(nameof (systemuserprofiles_association), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (systemuserprofiles_association));
        this.SetRelatedEntities<SystemUser>(nameof (systemuserprofiles_association), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (systemuserprofiles_association));
      }
    }

    [RelationshipSchemaName("teamprofiles_association")]
    public IEnumerable<Team> teamprofiles_association
    {
      get => this.GetRelatedEntities<Team>(nameof (teamprofiles_association), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (teamprofiles_association));
        this.SetRelatedEntities<Team>(nameof (teamprofiles_association), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (teamprofiles_association));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_fieldsecurityprofile_createdby")]
    public SystemUser lk_fieldsecurityprofile_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_fieldsecurityprofile_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_fieldsecurityprofile_createdonbehalfby")]
    public SystemUser lk_fieldsecurityprofile_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_fieldsecurityprofile_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_fieldsecurityprofile_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_fieldsecurityprofile_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_fieldsecurityprofile_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_fieldsecurityprofile_modifiedby")]
    public SystemUser lk_fieldsecurityprofile_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_fieldsecurityprofile_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_fieldsecurityprofile_modifiedonbehalfby")]
    public SystemUser lk_fieldsecurityprofile_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_fieldsecurityprofile_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_fieldsecurityprofile_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_fieldsecurityprofile_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_fieldsecurityprofile_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("lk_fieldsecurityprofile_organizationid")]
    public Organization lk_fieldsecurityprofile_organizationid
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (lk_fieldsecurityprofile_organizationid), new EntityRole?());
      }
    }

    [AttributeLogicalName("solutionid")]
    [RelationshipSchemaName("solution_fieldsecurityprofile")]
    public Solution solution_fieldsecurityprofile
    {
      get
      {
        return this.GetRelatedEntity<Solution>(nameof (solution_fieldsecurityprofile), new EntityRole?());
      }
    }

    public FieldSecurityProfile(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["fieldsecurityprofileid"] = (object) base.Id;
            break;
          case "fieldsecurityprofileid":
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
