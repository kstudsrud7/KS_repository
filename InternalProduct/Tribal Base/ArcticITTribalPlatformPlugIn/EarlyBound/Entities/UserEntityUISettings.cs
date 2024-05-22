// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.UserEntityUISettings
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("userentityuisettings")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class UserEntityUISettings : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "userentityuisettings";
    public const string EntitySchemaName = "UserEntityUISettings";
    public const string PrimaryIdAttribute = "userentityuisettingsid";

    public UserEntityUISettings()
      : base("userentityuisettings")
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

    [AttributeLogicalName("insertintoemailmruxml")]
    public string InsertIntoEmailMRUXml
    {
      get => this.GetAttributeValue<string>("insertintoemailmruxml");
      set
      {
        this.OnPropertyChanging(nameof (InsertIntoEmailMRUXml));
        this.SetAttributeValue("insertintoemailmruxml", (object) value);
        this.OnPropertyChanged(nameof (InsertIntoEmailMRUXml));
      }
    }

    [AttributeLogicalName("lastviewedformxml")]
    public string LastViewedFormXml
    {
      get => this.GetAttributeValue<string>("lastviewedformxml");
      set
      {
        this.OnPropertyChanging(nameof (LastViewedFormXml));
        this.SetAttributeValue("lastviewedformxml", (object) value);
        this.OnPropertyChanged(nameof (LastViewedFormXml));
      }
    }

    [AttributeLogicalName("lookupmruxml")]
    public string LookupMRUXml
    {
      get => this.GetAttributeValue<string>("lookupmruxml");
      set
      {
        this.OnPropertyChanging(nameof (LookupMRUXml));
        this.SetAttributeValue("lookupmruxml", (object) value);
        this.OnPropertyChanged(nameof (LookupMRUXml));
      }
    }

    [AttributeLogicalName("mruxml")]
    public string MRUXml
    {
      get => this.GetAttributeValue<string>("mruxml");
      set
      {
        this.OnPropertyChanging(nameof (MRUXml));
        this.SetAttributeValue("mruxml", (object) value);
        this.OnPropertyChanged(nameof (MRUXml));
      }
    }

    [AttributeLogicalName("objecttypecode")]
    public int? ObjectTypeCode
    {
      get => this.GetAttributeValue<int?>("objecttypecode");
      set
      {
        this.OnPropertyChanging(nameof (ObjectTypeCode));
        this.SetAttributeValue("objecttypecode", (object) value);
        this.OnPropertyChanged(nameof (ObjectTypeCode));
      }
    }

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

    [AttributeLogicalName("readingpanexml")]
    public string ReadingPaneXml
    {
      get => this.GetAttributeValue<string>("readingpanexml");
      set
      {
        this.OnPropertyChanging(nameof (ReadingPaneXml));
        this.SetAttributeValue("readingpanexml", (object) value);
        this.OnPropertyChanged(nameof (ReadingPaneXml));
      }
    }

    [AttributeLogicalName("recentlyviewedxml")]
    public string RecentlyViewedXml
    {
      get => this.GetAttributeValue<string>("recentlyviewedxml");
      set
      {
        this.OnPropertyChanging(nameof (RecentlyViewedXml));
        this.SetAttributeValue("recentlyviewedxml", (object) value);
        this.OnPropertyChanged(nameof (RecentlyViewedXml));
      }
    }

    [AttributeLogicalName("showinaddressbook")]
    public bool? ShowInAddressBook
    {
      get => this.GetAttributeValue<bool?>("showinaddressbook");
      set
      {
        this.OnPropertyChanging(nameof (ShowInAddressBook));
        this.SetAttributeValue("showinaddressbook", (object) value);
        this.OnPropertyChanged(nameof (ShowInAddressBook));
      }
    }

    [AttributeLogicalName("taborderxml")]
    public string TabOrderXml
    {
      get => this.GetAttributeValue<string>("taborderxml");
      set
      {
        this.OnPropertyChanging(nameof (TabOrderXml));
        this.SetAttributeValue("taborderxml", (object) value);
        this.OnPropertyChanged(nameof (TabOrderXml));
      }
    }

    [AttributeLogicalName("userentityuisettingsid")]
    public Guid? UserEntityUISettingsId
    {
      get => this.GetAttributeValue<Guid?>("userentityuisettingsid");
      set
      {
        this.OnPropertyChanging(nameof (UserEntityUISettingsId));
        this.SetAttributeValue("userentityuisettingsid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (UserEntityUISettingsId));
      }
    }

    [AttributeLogicalName("userentityuisettingsid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.UserEntityUISettingsId = new Guid?(value);
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("userentityinstancedata_userentityuisettings")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_userentityuisettings
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_userentityuisettings), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_userentityuisettings));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_userentityuisettings), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_userentityuisettings));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_userentityuisettings")]
    public Team team_userentityuisettings
    {
      get => this.GetRelatedEntity<Team>(nameof (team_userentityuisettings), new EntityRole?());
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("userentityuisettings_businessunit")]
    public BusinessUnit userentityuisettings_businessunit
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (userentityuisettings_businessunit), new EntityRole?());
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("userentityuisettings_owning_user")]
    public SystemUser userentityuisettings_owning_user
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (userentityuisettings_owning_user), new EntityRole?());
      }
    }

    public UserEntityUISettings(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["userentityuisettingsid"] = (object) base.Id;
            break;
          case "userentityuisettingsid":
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
