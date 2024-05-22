// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ActionCardUserSettings
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("actioncardusersettings")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ActionCardUserSettings : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "actioncardusersettings";
    public const string EntitySchemaName = "ActionCardUserSettings";
    public const string PrimaryIdAttribute = "actioncardusersettingsid";

    public ActionCardUserSettings()
      : base("actioncardusersettings")
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

    [AttributeLogicalName("actioncardusersettingsid")]
    public Guid? ActionCardUserSettingsId
    {
      get => this.GetAttributeValue<Guid?>("actioncardusersettingsid");
      set
      {
        this.OnPropertyChanging(nameof (ActionCardUserSettingsId));
        this.SetAttributeValue("actioncardusersettingsid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ActionCardUserSettingsId));
      }
    }

    [AttributeLogicalName("actioncardusersettingsid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ActionCardUserSettingsId = new Guid?(value);
    }

    [AttributeLogicalName("boolcardoption")]
    public bool? BoolCardOption
    {
      get => this.GetAttributeValue<bool?>("boolcardoption");
      set
      {
        this.OnPropertyChanging(nameof (BoolCardOption));
        this.SetAttributeValue("boolcardoption", (object) value);
        this.OnPropertyChanged(nameof (BoolCardOption));
      }
    }

    [AttributeLogicalName("cardtype")]
    public int? CardType
    {
      get => this.GetAttributeValue<int?>("cardtype");
      set
      {
        this.OnPropertyChanging(nameof (CardType));
        this.SetAttributeValue("cardtype", (object) value);
        this.OnPropertyChanged(nameof (CardType));
      }
    }

    [AttributeLogicalName("cardtypeid")]
    public EntityReference CardTypeId
    {
      get => this.GetAttributeValue<EntityReference>("cardtypeid");
      set
      {
        this.OnPropertyChanging(nameof (CardTypeId));
        this.SetAttributeValue("cardtypeid", (object) value);
        this.OnPropertyChanged(nameof (CardTypeId));
      }
    }

    [AttributeLogicalName("intcardoption")]
    public int? IntCardOption
    {
      get => this.GetAttributeValue<int?>("intcardoption");
      set
      {
        this.OnPropertyChanging(nameof (IntCardOption));
        this.SetAttributeValue("intcardoption", (object) value);
        this.OnPropertyChanged(nameof (IntCardOption));
      }
    }

    [AttributeLogicalName("isenabled")]
    public bool? IsEnabled
    {
      get => this.GetAttributeValue<bool?>("isenabled");
      set
      {
        this.OnPropertyChanging(nameof (IsEnabled));
        this.SetAttributeValue("isenabled", (object) value);
        this.OnPropertyChanged(nameof (IsEnabled));
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

    [AttributeLogicalName("stringcardoption")]
    public string StringCardOption
    {
      get => this.GetAttributeValue<string>("stringcardoption");
      set
      {
        this.OnPropertyChanging(nameof (StringCardOption));
        this.SetAttributeValue("stringcardoption", (object) value);
        this.OnPropertyChanged(nameof (StringCardOption));
      }
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("actioncardusersettings_businessunit")]
    public BusinessUnit actioncardusersettings_businessunit
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (actioncardusersettings_businessunit), new EntityRole?());
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("actioncardusersettings_owning_user")]
    public SystemUser actioncardusersettings_owning_user
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (actioncardusersettings_owning_user), new EntityRole?());
      }
    }

    [AttributeLogicalName("cardtypeid")]
    [RelationshipSchemaName("cardtype_actioncardusersettings")]
    public ArcticIT.EarlyBound.Entities.CardType cardtype_actioncardusersettings
    {
      get
      {
        return this.GetRelatedEntity<ArcticIT.EarlyBound.Entities.CardType>(nameof (cardtype_actioncardusersettings), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (cardtype_actioncardusersettings));
        this.SetRelatedEntity<ArcticIT.EarlyBound.Entities.CardType>(nameof (cardtype_actioncardusersettings), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (cardtype_actioncardusersettings));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_actioncardusersettings")]
    public Team team_actioncardusersettings
    {
      get => this.GetRelatedEntity<Team>(nameof (team_actioncardusersettings), new EntityRole?());
    }

    public ActionCardUserSettings(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["actioncardusersettingsid"] = (object) base.Id;
            break;
          case "actioncardusersettingsid":
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
