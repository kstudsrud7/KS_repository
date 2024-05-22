// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.TeamProfiles
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("teamprofiles")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class TeamProfiles : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "teamprofiles";
    public const string EntitySchemaName = "TeamProfiles";
    public const string PrimaryIdAttribute = "teamprofileid";

    public TeamProfiles()
      : base("teamprofiles")
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

    [AttributeLogicalName("fieldsecurityprofileid")]
    public Guid? FieldSecurityProfileId => this.GetAttributeValue<Guid?>("fieldsecurityprofileid");

    [AttributeLogicalName("teamid")]
    public Guid? TeamId => this.GetAttributeValue<Guid?>("teamid");

    [AttributeLogicalName("teamprofileid")]
    public Guid? TeamProfileId
    {
      get => this.GetAttributeValue<Guid?>("teamprofileid");
      set
      {
        this.OnPropertyChanging(nameof (TeamProfileId));
        this.SetAttributeValue("teamprofileid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (TeamProfileId));
      }
    }

    [AttributeLogicalName("teamprofileid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.TeamProfileId = new Guid?(value);
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

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

    public TeamProfiles(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["teamprofileid"] = (object) base.Id;
            break;
          case "teamprofileid":
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
