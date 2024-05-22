// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.TeamTemplate
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("teamtemplate")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class TeamTemplate : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "teamtemplate";
    public const string EntitySchemaName = "TeamTemplate";
    public const string PrimaryIdAttribute = "teamtemplateid";
    public const string PrimaryNameAttribute = "teamtemplatename";

    public TeamTemplate()
      : base("teamtemplate")
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

    [AttributeLogicalName("defaultaccessrightsmask")]
    public int? DefaultAccessRightsMask
    {
      get => this.GetAttributeValue<int?>("defaultaccessrightsmask");
      set
      {
        this.OnPropertyChanging(nameof (DefaultAccessRightsMask));
        this.SetAttributeValue("defaultaccessrightsmask", (object) value);
        this.OnPropertyChanged(nameof (DefaultAccessRightsMask));
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

    [AttributeLogicalName("issystem")]
    public bool? IsSystem => this.GetAttributeValue<bool?>("issystem");

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

    [AttributeLogicalName("teamtemplateid")]
    public Guid? TeamTemplateId
    {
      get => this.GetAttributeValue<Guid?>("teamtemplateid");
      set
      {
        this.OnPropertyChanging(nameof (TeamTemplateId));
        this.SetAttributeValue("teamtemplateid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (TeamTemplateId));
      }
    }

    [AttributeLogicalName("teamtemplateid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.TeamTemplateId = new Guid?(value);
    }

    [AttributeLogicalName("teamtemplatename")]
    public string TeamTemplateName
    {
      get => this.GetAttributeValue<string>("teamtemplatename");
      set
      {
        this.OnPropertyChanging(nameof (TeamTemplateName));
        this.SetAttributeValue("teamtemplatename", (object) value);
        this.OnPropertyChanged(nameof (TeamTemplateName));
      }
    }

    [AttributeLogicalName("versionnumber")]
    public long? versionnumber => this.GetAttributeValue<long?>(nameof (versionnumber));

    [RelationshipSchemaName("TeamTemplate_SyncErrors")]
    public IEnumerable<SyncError> TeamTemplate_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (TeamTemplate_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TeamTemplate_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (TeamTemplate_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TeamTemplate_SyncErrors));
      }
    }

    [RelationshipSchemaName("teamtemplate_Teams")]
    public IEnumerable<Team> teamtemplate_Teams
    {
      get => this.GetRelatedEntities<Team>(nameof (teamtemplate_Teams), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (teamtemplate_Teams));
        this.SetRelatedEntities<Team>(nameof (teamtemplate_Teams), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (teamtemplate_Teams));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_teamtemplate_createdby")]
    public SystemUser lk_teamtemplate_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_teamtemplate_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_teamtemplate_createdonbehalfby")]
    public SystemUser lk_teamtemplate_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_teamtemplate_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_teamtemplate_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_teamtemplate_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_teamtemplate_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_teamtemplate_modifiedby")]
    public SystemUser lk_teamtemplate_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_teamtemplate_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_teamtemplate_modifiedonbehalfby")]
    public SystemUser lk_teamtemplate_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_teamtemplate_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_teamtemplate_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_teamtemplate_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_teamtemplate_modifiedonbehalfby));
      }
    }

    public TeamTemplate(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["teamtemplateid"] = (object) base.Id;
            break;
          case "teamtemplateid":
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
