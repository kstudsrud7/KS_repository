// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.Solution
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("solution")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class Solution : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "solution";
    public const string EntitySchemaName = "Solution";
    public const string PrimaryIdAttribute = "solutionid";
    public const string PrimaryNameAttribute = "friendlyname";

    public Solution()
      : base("solution")
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

    [AttributeLogicalName("configurationpageid")]
    public EntityReference ConfigurationPageId
    {
      get => this.GetAttributeValue<EntityReference>("configurationpageid");
      set
      {
        this.OnPropertyChanging(nameof (ConfigurationPageId));
        this.SetAttributeValue("configurationpageid", (object) value);
        this.OnPropertyChanged(nameof (ConfigurationPageId));
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

    [AttributeLogicalName("friendlyname")]
    public string FriendlyName
    {
      get => this.GetAttributeValue<string>("friendlyname");
      set
      {
        this.OnPropertyChanging(nameof (FriendlyName));
        this.SetAttributeValue("friendlyname", (object) value);
        this.OnPropertyChanged(nameof (FriendlyName));
      }
    }

    [AttributeLogicalName("installedon")]
    public DateTime? InstalledOn => this.GetAttributeValue<DateTime?>("installedon");

    [AttributeLogicalName("isapimanaged")]
    public bool? IsApiManaged => this.GetAttributeValue<bool?>("isapimanaged");

    [AttributeLogicalName("ismanaged")]
    public bool? IsManaged => this.GetAttributeValue<bool?>("ismanaged");

    [AttributeLogicalName("isvisible")]
    public bool? IsVisible => this.GetAttributeValue<bool?>("isvisible");

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

    [AttributeLogicalName("parentsolutionid")]
    public EntityReference ParentSolutionId
    {
      get => this.GetAttributeValue<EntityReference>("parentsolutionid");
    }

    [AttributeLogicalName("pinpointassetid")]
    public string PinpointAssetId => this.GetAttributeValue<string>("pinpointassetid");

    [AttributeLogicalName("pinpointpublisherid")]
    public long? PinpointPublisherId => this.GetAttributeValue<long?>("pinpointpublisherid");

    [AttributeLogicalName("pinpointsolutiondefaultlocale")]
    public string PinpointSolutionDefaultLocale
    {
      get => this.GetAttributeValue<string>("pinpointsolutiondefaultlocale");
    }

    [AttributeLogicalName("pinpointsolutionid")]
    public long? PinpointSolutionId => this.GetAttributeValue<long?>("pinpointsolutionid");

    [AttributeLogicalName("publisherid")]
    public EntityReference PublisherId
    {
      get => this.GetAttributeValue<EntityReference>("publisherid");
      set
      {
        this.OnPropertyChanging(nameof (PublisherId));
        this.SetAttributeValue("publisherid", (object) value);
        this.OnPropertyChanged(nameof (PublisherId));
      }
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId
    {
      get => this.GetAttributeValue<Guid?>("solutionid");
      set
      {
        this.OnPropertyChanging(nameof (SolutionId));
        this.SetAttributeValue("solutionid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (SolutionId));
      }
    }

    [AttributeLogicalName("solutionid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.SolutionId = new Guid?(value);
    }

    [AttributeLogicalName("solutionpackageversion")]
    public string SolutionPackageVersion
    {
      get => this.GetAttributeValue<string>("solutionpackageversion");
      set
      {
        this.OnPropertyChanging(nameof (SolutionPackageVersion));
        this.SetAttributeValue("solutionpackageversion", (object) value);
        this.OnPropertyChanged(nameof (SolutionPackageVersion));
      }
    }

    [AttributeLogicalName("solutiontype")]
    public OptionSetValue SolutionType
    {
      get => this.GetAttributeValue<OptionSetValue>("solutiontype");
      set
      {
        this.OnPropertyChanging(nameof (SolutionType));
        this.SetAttributeValue("solutiontype", (object) value);
        this.OnPropertyChanged(nameof (SolutionType));
      }
    }

    [AttributeLogicalName("templatesuffix")]
    public string TemplateSuffix
    {
      get => this.GetAttributeValue<string>("templatesuffix");
      set
      {
        this.OnPropertyChanging(nameof (TemplateSuffix));
        this.SetAttributeValue("templatesuffix", (object) value);
        this.OnPropertyChanged(nameof (TemplateSuffix));
      }
    }

    [AttributeLogicalName("uniquename")]
    public string UniqueName
    {
      get => this.GetAttributeValue<string>("uniquename");
      set
      {
        this.OnPropertyChanging(nameof (UniqueName));
        this.SetAttributeValue("uniquename", (object) value);
        this.OnPropertyChanged(nameof (UniqueName));
      }
    }

    [AttributeLogicalName("updatedon")]
    public DateTime? UpdatedOn => this.GetAttributeValue<DateTime?>("updatedon");

    [AttributeLogicalName("version")]
    public string Version
    {
      get => this.GetAttributeValue<string>("version");
      set
      {
        this.OnPropertyChanging(nameof (Version));
        this.SetAttributeValue("version", (object) value);
        this.OnPropertyChanged(nameof (Version));
      }
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("FK_CanvasApp_Solution")]
    public IEnumerable<CanvasApp> FK_CanvasApp_Solution
    {
      get => this.GetRelatedEntities<CanvasApp>(nameof (FK_CanvasApp_Solution), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (FK_CanvasApp_Solution));
        this.SetRelatedEntities<CanvasApp>(nameof (FK_CanvasApp_Solution), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (FK_CanvasApp_Solution));
      }
    }

    [RelationshipSchemaName("solution_fieldpermission")]
    public IEnumerable<FieldPermission> solution_fieldpermission
    {
      get
      {
        return this.GetRelatedEntities<FieldPermission>(nameof (solution_fieldpermission), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (solution_fieldpermission));
        this.SetRelatedEntities<FieldPermission>(nameof (solution_fieldpermission), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (solution_fieldpermission));
      }
    }

    [RelationshipSchemaName("solution_fieldsecurityprofile")]
    public IEnumerable<FieldSecurityProfile> solution_fieldsecurityprofile
    {
      get
      {
        return this.GetRelatedEntities<FieldSecurityProfile>(nameof (solution_fieldsecurityprofile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (solution_fieldsecurityprofile));
        this.SetRelatedEntities<FieldSecurityProfile>(nameof (solution_fieldsecurityprofile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (solution_fieldsecurityprofile));
      }
    }

    [RelationshipSchemaName]
    public IEnumerable<Solution> Referencedsolution_parent_solution
    {
      get
      {
        return this.GetRelatedEntities<Solution>("solution_parent_solution", new EntityRole?((EntityRole) 1));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencedsolution_parent_solution));
        this.SetRelatedEntities<Solution>("solution_parent_solution", new EntityRole?((EntityRole) 1), value);
        this.OnPropertyChanged(nameof (Referencedsolution_parent_solution));
      }
    }

    [RelationshipSchemaName("solution_privilege")]
    public IEnumerable<Privilege> solution_privilege
    {
      get => this.GetRelatedEntities<Privilege>(nameof (solution_privilege), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (solution_privilege));
        this.SetRelatedEntities<Privilege>(nameof (solution_privilege), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (solution_privilege));
      }
    }

    [RelationshipSchemaName("solution_role")]
    public IEnumerable<Role> solution_role
    {
      get => this.GetRelatedEntities<Role>(nameof (solution_role), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (solution_role));
        this.SetRelatedEntities<Role>(nameof (solution_role), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (solution_role));
      }
    }

    [RelationshipSchemaName("solution_roleprivileges")]
    public IEnumerable<RolePrivileges> solution_roleprivileges
    {
      get
      {
        return this.GetRelatedEntities<RolePrivileges>(nameof (solution_roleprivileges), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (solution_roleprivileges));
        this.SetRelatedEntities<RolePrivileges>(nameof (solution_roleprivileges), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (solution_roleprivileges));
      }
    }

    [RelationshipSchemaName("solution_solutioncomponent")]
    public IEnumerable<SolutionComponent> solution_solutioncomponent
    {
      get
      {
        return this.GetRelatedEntities<SolutionComponent>(nameof (solution_solutioncomponent), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (solution_solutioncomponent));
        this.SetRelatedEntities<SolutionComponent>(nameof (solution_solutioncomponent), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (solution_solutioncomponent));
      }
    }

    [RelationshipSchemaName("Solution_SyncErrors")]
    public IEnumerable<SyncError> Solution_SyncErrors
    {
      get => this.GetRelatedEntities<SyncError>(nameof (Solution_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Solution_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (Solution_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Solution_SyncErrors));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_solution")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_solution
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_solution), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_solution));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_solution), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_solution));
      }
    }

    [RelationshipSchemaName("package_solution")]
    public IEnumerable<package> package_solution
    {
      get => this.GetRelatedEntities<package>(nameof (package_solution), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (package_solution));
        this.SetRelatedEntities<package>(nameof (package_solution), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (package_solution));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_solution_createdby")]
    public SystemUser lk_solution_createdby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_solution_createdby), new EntityRole?());
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_solution_modifiedby")]
    public SystemUser lk_solution_modifiedby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_solution_modifiedby), new EntityRole?());
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_solutionbase_createdonbehalfby")]
    public SystemUser lk_solutionbase_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_solutionbase_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_solutionbase_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_solutionbase_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_solutionbase_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_solutionbase_modifiedonbehalfby")]
    public SystemUser lk_solutionbase_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_solutionbase_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_solutionbase_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_solutionbase_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_solutionbase_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_solution")]
    public Organization organization_solution
    {
      get => this.GetRelatedEntity<Organization>(nameof (organization_solution), new EntityRole?());
    }

    [AttributeLogicalName("publisherid")]
    [RelationshipSchemaName("publisher_solution")]
    public Publisher publisher_solution
    {
      get => this.GetRelatedEntity<Publisher>(nameof (publisher_solution), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (publisher_solution));
        this.SetRelatedEntity<Publisher>(nameof (publisher_solution), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (publisher_solution));
      }
    }

    [AttributeLogicalName("configurationpageid")]
    [RelationshipSchemaName("solution_configuration_webresource")]
    public WebResource solution_configuration_webresource
    {
      get
      {
        return this.GetRelatedEntity<WebResource>(nameof (solution_configuration_webresource), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (solution_configuration_webresource));
        this.SetRelatedEntity<WebResource>(nameof (solution_configuration_webresource), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (solution_configuration_webresource));
      }
    }

    [AttributeLogicalName("parentsolutionid")]
    [RelationshipSchemaName]
    public Solution Referencingsolution_parent_solution
    {
      get
      {
        return this.GetRelatedEntity<Solution>("solution_parent_solution", new EntityRole?((EntityRole) 0));
      }
    }

    public Solution(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["solutionid"] = (object) base.Id;
            break;
          case "solutionid":
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
