// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.TeamSyncAttributeMappingProfiles
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("teamsyncattributemappingprofiles")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class TeamSyncAttributeMappingProfiles : 
    Entity,
    INotifyPropertyChanging,
    INotifyPropertyChanged
  {
    public const string EntityLogicalName = "teamsyncattributemappingprofiles";
    public const string EntitySchemaName = "TeamSyncAttributeMappingProfiles";
    public const string PrimaryIdAttribute = "teamsyncattributemappingprofileid";

    public TeamSyncAttributeMappingProfiles()
      : base("teamsyncattributemappingprofiles")
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

    [AttributeLogicalName("syncattributemappingprofileid")]
    public Guid? SyncAttributeMappingProfileId
    {
      get => this.GetAttributeValue<Guid?>("syncattributemappingprofileid");
    }

    [AttributeLogicalName("teamid")]
    public Guid? TeamId => this.GetAttributeValue<Guid?>("teamid");

    [AttributeLogicalName("teamsyncattributemappingprofileid")]
    public Guid? TeamSyncAttributeMappingProfileId
    {
      get => this.GetAttributeValue<Guid?>("teamsyncattributemappingprofileid");
      set
      {
        this.OnPropertyChanging(nameof (TeamSyncAttributeMappingProfileId));
        this.SetAttributeValue("teamsyncattributemappingprofileid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (TeamSyncAttributeMappingProfileId));
      }
    }

    [AttributeLogicalName("teamsyncattributemappingprofileid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.TeamSyncAttributeMappingProfileId = new Guid?(value);
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("teamsyncattributemappingprofiles_association")]
    public IEnumerable<Team> teamsyncattributemappingprofiles_association
    {
      get
      {
        return this.GetRelatedEntities<Team>(nameof (teamsyncattributemappingprofiles_association), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (teamsyncattributemappingprofiles_association));
        this.SetRelatedEntities<Team>(nameof (teamsyncattributemappingprofiles_association), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (teamsyncattributemappingprofiles_association));
      }
    }

    public TeamSyncAttributeMappingProfiles(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["teamsyncattributemappingprofileid"] = (object) base.Id;
            break;
          case "teamsyncattributemappingprofileid":
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
