// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.TeamMembership
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("teammembership")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class TeamMembership : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "teammembership";
    public const string EntitySchemaName = "TeamMembership";
    public const string PrimaryIdAttribute = "teammembershipid";

    public TeamMembership()
      : base("teammembership")
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

    [AttributeLogicalName("systemuserid")]
    public Guid? SystemUserId => this.GetAttributeValue<Guid?>("systemuserid");

    [AttributeLogicalName("teamid")]
    public Guid? TeamId => this.GetAttributeValue<Guid?>("teamid");

    [AttributeLogicalName("teammembershipid")]
    public Guid? TeamMembershipId
    {
      get => this.GetAttributeValue<Guid?>("teammembershipid");
      set
      {
        this.OnPropertyChanging(nameof (TeamMembershipId));
        this.SetAttributeValue("teammembershipid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (TeamMembershipId));
      }
    }

    [AttributeLogicalName("teammembershipid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.TeamMembershipId = new Guid?(value);
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("userentityinstancedata_teammembership")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_teammembership
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_teammembership), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_teammembership));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_teammembership), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_teammembership));
      }
    }

    [RelationshipSchemaName("teammembership_association")]
    public IEnumerable<Team> teammembership_association
    {
      get => this.GetRelatedEntities<Team>(nameof (teammembership_association), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (teammembership_association));
        this.SetRelatedEntities<Team>(nameof (teammembership_association), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (teammembership_association));
      }
    }

    public TeamMembership(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["teammembershipid"] = (object) base.Id;
            break;
          case "teammembershipid":
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
