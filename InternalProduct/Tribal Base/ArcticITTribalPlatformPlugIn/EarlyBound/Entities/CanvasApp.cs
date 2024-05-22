// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.CanvasApp
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("canvasapp")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class CanvasApp : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "canvasapp";
    public const string EntitySchemaName = "CanvasApp";
    public const string PrimaryIdAttribute = "canvasappid";
    public const string PrimaryNameAttribute = "name";

    public CanvasApp()
      : base("canvasapp")
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

    [AttributeLogicalName("aadcreatedbyid")]
    public string AADCreatedById
    {
      get => this.GetAttributeValue<string>("aadcreatedbyid");
      set
      {
        this.OnPropertyChanging(nameof (AADCreatedById));
        this.SetAttributeValue("aadcreatedbyid", (object) value);
        this.OnPropertyChanged(nameof (AADCreatedById));
      }
    }

    [AttributeLogicalName("aadlastmodifiedbyid")]
    public string AADLastModifiedById
    {
      get => this.GetAttributeValue<string>("aadlastmodifiedbyid");
      set
      {
        this.OnPropertyChanging(nameof (AADLastModifiedById));
        this.SetAttributeValue("aadlastmodifiedbyid", (object) value);
        this.OnPropertyChanged(nameof (AADLastModifiedById));
      }
    }

    [AttributeLogicalName("aadlastpublishedbyid")]
    public string AADLastPublishedById
    {
      get => this.GetAttributeValue<string>("aadlastpublishedbyid");
      set
      {
        this.OnPropertyChanging(nameof (AADLastPublishedById));
        this.SetAttributeValue("aadlastpublishedbyid", (object) value);
        this.OnPropertyChanged(nameof (AADLastPublishedById));
      }
    }

    [AttributeLogicalName("admincontrolbypassconsent")]
    public bool? AdminControlBypassConsent
    {
      get => this.GetAttributeValue<bool?>("admincontrolbypassconsent");
      set
      {
        this.OnPropertyChanging(nameof (AdminControlBypassConsent));
        this.SetAttributeValue("admincontrolbypassconsent", (object) value);
        this.OnPropertyChanged(nameof (AdminControlBypassConsent));
      }
    }

    [AttributeLogicalName("appcomponentdependencies")]
    public string AppComponentDependencies
    {
      get => this.GetAttributeValue<string>("appcomponentdependencies");
      set
      {
        this.OnPropertyChanging(nameof (AppComponentDependencies));
        this.SetAttributeValue("appcomponentdependencies", (object) value);
        this.OnPropertyChanged(nameof (AppComponentDependencies));
      }
    }

    [AttributeLogicalName("appcomponents")]
    public string AppComponents
    {
      get => this.GetAttributeValue<string>("appcomponents");
      set
      {
        this.OnPropertyChanging(nameof (AppComponents));
        this.SetAttributeValue("appcomponents", (object) value);
        this.OnPropertyChanged(nameof (AppComponents));
      }
    }

    [AttributeLogicalName("appopenuri")]
    public string AppOpenUri
    {
      get => this.GetAttributeValue<string>("appopenuri");
      set
      {
        this.OnPropertyChanging(nameof (AppOpenUri));
        this.SetAttributeValue("appopenuri", (object) value);
        this.OnPropertyChanged(nameof (AppOpenUri));
      }
    }

    [AttributeLogicalName("appversion")]
    public string AppVersion
    {
      get => this.GetAttributeValue<string>("appversion");
      set
      {
        this.OnPropertyChanging(nameof (AppVersion));
        this.SetAttributeValue("appversion", (object) value);
        this.OnPropertyChanged(nameof (AppVersion));
      }
    }

    [AttributeLogicalName("authorizationreferences")]
    public string AuthorizationReferences
    {
      get => this.GetAttributeValue<string>("authorizationreferences");
      set
      {
        this.OnPropertyChanging(nameof (AuthorizationReferences));
        this.SetAttributeValue("authorizationreferences", (object) value);
        this.OnPropertyChanged(nameof (AuthorizationReferences));
      }
    }

    [AttributeLogicalName("backgroundcolor")]
    public string BackgroundColor
    {
      get => this.GetAttributeValue<string>("backgroundcolor");
      set
      {
        this.OnPropertyChanging(nameof (BackgroundColor));
        this.SetAttributeValue("backgroundcolor", (object) value);
        this.OnPropertyChanged(nameof (BackgroundColor));
      }
    }

    [AttributeLogicalName("bypassconsent")]
    public bool? BypassConsent
    {
      get => this.GetAttributeValue<bool?>("bypassconsent");
      set
      {
        this.OnPropertyChanging(nameof (BypassConsent));
        this.SetAttributeValue("bypassconsent", (object) value);
        this.OnPropertyChanged(nameof (BypassConsent));
      }
    }

    [AttributeLogicalName("canconsumeapppass")]
    public bool? CanConsumeAppPass
    {
      get => this.GetAttributeValue<bool?>("canconsumeapppass");
      set
      {
        this.OnPropertyChanging(nameof (CanConsumeAppPass));
        this.SetAttributeValue("canconsumeapppass", (object) value);
        this.OnPropertyChanged(nameof (CanConsumeAppPass));
      }
    }

    [AttributeLogicalName("canvasappid")]
    public Guid? CanvasAppId
    {
      get => this.GetAttributeValue<Guid?>("canvasappid");
      set
      {
        this.OnPropertyChanging(nameof (CanvasAppId));
        this.SetAttributeValue("canvasappid", (object) value);
        this.OnPropertyChanged(nameof (CanvasAppId));
      }
    }

    [AttributeLogicalName("canvasapprowid")]
    public Guid? CanvasAppRowId => this.GetAttributeValue<Guid?>("canvasapprowid");

    [AttributeLogicalName("canvasapptype")]
    public OptionSetValue CanvasAppType
    {
      get => this.GetAttributeValue<OptionSetValue>("canvasapptype");
      set
      {
        this.OnPropertyChanging(nameof (CanvasAppType));
        this.SetAttributeValue("canvasapptype", (object) value);
        this.OnPropertyChanged(nameof (CanvasAppType));
      }
    }

    [AttributeLogicalName("cdsdependencies")]
    public string CdsDependencies
    {
      get => this.GetAttributeValue<string>("cdsdependencies");
      set
      {
        this.OnPropertyChanging(nameof (CdsDependencies));
        this.SetAttributeValue("cdsdependencies", (object) value);
        this.OnPropertyChanged(nameof (CdsDependencies));
      }
    }

    [AttributeLogicalName("commitmessage")]
    public string CommitMessage
    {
      get => this.GetAttributeValue<string>("commitmessage");
      set
      {
        this.OnPropertyChanging(nameof (CommitMessage));
        this.SetAttributeValue("commitmessage", (object) value);
        this.OnPropertyChanged(nameof (CommitMessage));
      }
    }

    [AttributeLogicalName("componentstate")]
    public OptionSetValue ComponentState
    {
      get => this.GetAttributeValue<OptionSetValue>("componentstate");
    }

    [AttributeLogicalName("connectionreferences")]
    public string ConnectionReferences
    {
      get => this.GetAttributeValue<string>("connectionreferences");
      set
      {
        this.OnPropertyChanging(nameof (ConnectionReferences));
        this.SetAttributeValue("connectionreferences", (object) value);
        this.OnPropertyChanged(nameof (ConnectionReferences));
      }
    }

    [AttributeLogicalName("createdbyclientversion")]
    public string CreatedByClientVersion
    {
      get => this.GetAttributeValue<string>("createdbyclientversion");
      set
      {
        this.OnPropertyChanging(nameof (CreatedByClientVersion));
        this.SetAttributeValue("createdbyclientversion", (object) value);
        this.OnPropertyChanged(nameof (CreatedByClientVersion));
      }
    }

    [AttributeLogicalName("createdtime")]
    public DateTime? CreatedTime
    {
      get => this.GetAttributeValue<DateTime?>("createdtime");
      set
      {
        this.OnPropertyChanging(nameof (CreatedTime));
        this.SetAttributeValue("createdtime", (object) value);
        this.OnPropertyChanged(nameof (CreatedTime));
      }
    }

    [AttributeLogicalName("databasereferences")]
    public string DatabaseReferences
    {
      get => this.GetAttributeValue<string>("databasereferences");
      set
      {
        this.OnPropertyChanging(nameof (DatabaseReferences));
        this.SetAttributeValue("databasereferences", (object) value);
        this.OnPropertyChanged(nameof (DatabaseReferences));
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

    [AttributeLogicalName("displayname")]
    public string DisplayName
    {
      get => this.GetAttributeValue<string>("displayname");
      set
      {
        this.OnPropertyChanging(nameof (DisplayName));
        this.SetAttributeValue("displayname", (object) value);
        this.OnPropertyChanged(nameof (DisplayName));
      }
    }

    [AttributeLogicalName("embeddedapp")]
    public string EmbeddedApp
    {
      get => this.GetAttributeValue<string>("embeddedapp");
      set
      {
        this.OnPropertyChanging(nameof (EmbeddedApp));
        this.SetAttributeValue("embeddedapp", (object) value);
        this.OnPropertyChanged(nameof (EmbeddedApp));
      }
    }

    [AttributeLogicalName("galleryitemid")]
    public string GalleryItemId
    {
      get => this.GetAttributeValue<string>("galleryitemid");
      set
      {
        this.OnPropertyChanging(nameof (GalleryItemId));
        this.SetAttributeValue("galleryitemid", (object) value);
        this.OnPropertyChanged(nameof (GalleryItemId));
      }
    }

    [AttributeLogicalName("introducedversion")]
    public string IntroducedVersion
    {
      get => this.GetAttributeValue<string>("introducedversion");
      set
      {
        this.OnPropertyChanging(nameof (IntroducedVersion));
        this.SetAttributeValue("introducedversion", (object) value);
        this.OnPropertyChanged(nameof (IntroducedVersion));
      }
    }

    [AttributeLogicalName("iscdsupgraded")]
    public bool? IsCdsUpgraded
    {
      get => this.GetAttributeValue<bool?>("iscdsupgraded");
      set
      {
        this.OnPropertyChanging(nameof (IsCdsUpgraded));
        this.SetAttributeValue("iscdsupgraded", (object) value);
        this.OnPropertyChanged(nameof (IsCdsUpgraded));
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

    [AttributeLogicalName("isfeaturedapp")]
    public bool? IsFeaturedApp
    {
      get => this.GetAttributeValue<bool?>("isfeaturedapp");
      set
      {
        this.OnPropertyChanging(nameof (IsFeaturedApp));
        this.SetAttributeValue("isfeaturedapp", (object) value);
        this.OnPropertyChanged(nameof (IsFeaturedApp));
      }
    }

    [AttributeLogicalName("isheroapp")]
    public bool? IsHeroApp
    {
      get => this.GetAttributeValue<bool?>("isheroapp");
      set
      {
        this.OnPropertyChanging(nameof (IsHeroApp));
        this.SetAttributeValue("isheroapp", (object) value);
        this.OnPropertyChanged(nameof (IsHeroApp));
      }
    }

    [AttributeLogicalName("ishidden")]
    public bool? IsHidden
    {
      get => this.GetAttributeValue<bool?>("ishidden");
      set
      {
        this.OnPropertyChanging(nameof (IsHidden));
        this.SetAttributeValue("ishidden", (object) value);
        this.OnPropertyChanged(nameof (IsHidden));
      }
    }

    [AttributeLogicalName("ismanaged")]
    public bool? IsManaged => this.GetAttributeValue<bool?>("ismanaged");

    [AttributeLogicalName("lastmodifiedtime")]
    public DateTime? LastModifiedTime
    {
      get => this.GetAttributeValue<DateTime?>("lastmodifiedtime");
      set
      {
        this.OnPropertyChanging(nameof (LastModifiedTime));
        this.SetAttributeValue("lastmodifiedtime", (object) value);
        this.OnPropertyChanged(nameof (LastModifiedTime));
      }
    }

    [AttributeLogicalName("lastpublishtime")]
    public DateTime? LastPublishTime
    {
      get => this.GetAttributeValue<DateTime?>("lastpublishtime");
      set
      {
        this.OnPropertyChanging(nameof (LastPublishTime));
        this.SetAttributeValue("lastpublishtime", (object) value);
        this.OnPropertyChanged(nameof (LastPublishTime));
      }
    }

    [AttributeLogicalName("minclientversion")]
    public string MinClientVersion
    {
      get => this.GetAttributeValue<string>("minclientversion");
      set
      {
        this.OnPropertyChanging(nameof (MinClientVersion));
        this.SetAttributeValue("minclientversion", (object) value);
        this.OnPropertyChanged(nameof (MinClientVersion));
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

    [AttributeLogicalName("owningteam")]
    public EntityReference OwningTeam => this.GetAttributeValue<EntityReference>("owningteam");

    [AttributeLogicalName("owninguser")]
    public EntityReference OwningUser => this.GetAttributeValue<EntityReference>("owninguser");

    [AttributeLogicalName("publisher")]
    public string Publisher
    {
      get => this.GetAttributeValue<string>("publisher");
      set
      {
        this.OnPropertyChanging(nameof (Publisher));
        this.SetAttributeValue("publisher", (object) value);
        this.OnPropertyChanged(nameof (Publisher));
      }
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("status")]
    public string Status
    {
      get => this.GetAttributeValue<string>("status");
      set
      {
        this.OnPropertyChanging(nameof (Status));
        this.SetAttributeValue("status", (object) value);
        this.OnPropertyChanged(nameof (Status));
      }
    }

    [AttributeLogicalName("tags")]
    public string Tags
    {
      get => this.GetAttributeValue<string>("tags");
      set
      {
        this.OnPropertyChanging(nameof (Tags));
        this.SetAttributeValue("tags", (object) value);
        this.OnPropertyChanged(nameof (Tags));
      }
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("canvasapp_appelement_canvasappid")]
    public IEnumerable<AppElement> canvasapp_appelement_canvasappid
    {
      get
      {
        return this.GetRelatedEntities<AppElement>(nameof (canvasapp_appelement_canvasappid), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (canvasapp_appelement_canvasappid));
        this.SetRelatedEntities<AppElement>(nameof (canvasapp_appelement_canvasappid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (canvasapp_appelement_canvasappid));
      }
    }

    [RelationshipSchemaName("canvasappextendedmetadata")]
    public IEnumerable<CanvasAppExtendedMetadata> canvasappextendedmetadata
    {
      get
      {
        return this.GetRelatedEntities<CanvasAppExtendedMetadata>(nameof (canvasappextendedmetadata), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (canvasappextendedmetadata));
        this.SetRelatedEntities<CanvasAppExtendedMetadata>(nameof (canvasappextendedmetadata), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (canvasappextendedmetadata));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("businessunit_canvasapp")]
    public BusinessUnit businessunit_canvasapp
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (businessunit_canvasapp), new EntityRole?());
      }
    }

    [AttributeLogicalName("solutionid")]
    [RelationshipSchemaName("FK_CanvasApp_Solution")]
    public Solution FK_CanvasApp_Solution
    {
      get => this.GetRelatedEntity<Solution>(nameof (FK_CanvasApp_Solution), new EntityRole?());
    }

    public CanvasApp(object anonymousType)
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
            this.Id = (Guid) obj;
            ((DataCollection<string, object>) this.Attributes)["canvasappid"] = (object) this.Id;
            break;
          case "canvasappid":
            Guid? nullable = (Guid?) obj;
            if (nullable.HasValue)
            {
              this.Id = nullable.Value;
              ((DataCollection<string, object>) this.Attributes)[str] = (object) this.Id;
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
