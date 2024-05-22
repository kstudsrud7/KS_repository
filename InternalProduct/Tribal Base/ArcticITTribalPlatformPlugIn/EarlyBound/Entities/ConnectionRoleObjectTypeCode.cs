// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ConnectionRoleObjectTypeCode
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("connectionroleobjecttypecode")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ConnectionRoleObjectTypeCode : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "connectionroleobjecttypecode";
    public const string EntitySchemaName = "ConnectionRoleObjectTypeCode";
    public const string PrimaryIdAttribute = "connectionroleobjecttypecodeid";

    public ConnectionRoleObjectTypeCode()
      : base("connectionroleobjecttypecode")
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

    [AttributeLogicalName("associatedobjecttypecode")]
    public string AssociatedObjectTypeCode
    {
      get => this.GetAttributeValue<string>("associatedobjecttypecode");
      set
      {
        this.OnPropertyChanging(nameof (AssociatedObjectTypeCode));
        this.SetAttributeValue("associatedobjecttypecode", (object) value);
        this.OnPropertyChanged(nameof (AssociatedObjectTypeCode));
      }
    }

    [AttributeLogicalName("connectionroleid")]
    public EntityReference ConnectionRoleId
    {
      get => this.GetAttributeValue<EntityReference>("connectionroleid");
      set
      {
        this.OnPropertyChanging(nameof (ConnectionRoleId));
        this.SetAttributeValue("connectionroleid", (object) value);
        this.OnPropertyChanged(nameof (ConnectionRoleId));
      }
    }

    [AttributeLogicalName("connectionroleobjecttypecodeid")]
    public Guid? ConnectionRoleObjectTypeCodeId
    {
      get => this.GetAttributeValue<Guid?>("connectionroleobjecttypecodeid");
      set
      {
        this.OnPropertyChanging(nameof (ConnectionRoleObjectTypeCodeId));
        this.SetAttributeValue("connectionroleobjecttypecodeid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ConnectionRoleObjectTypeCodeId));
      }
    }

    [AttributeLogicalName("connectionroleobjecttypecodeid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ConnectionRoleObjectTypeCodeId = new Guid?(value);
    }

    [AttributeLogicalName("organizationid")]
    public Guid? OrganizationId => this.GetAttributeValue<Guid?>("organizationid");

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("userentityinstancedata_connectionroleobjecttypecode")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_connectionroleobjecttypecode
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_connectionroleobjecttypecode), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_connectionroleobjecttypecode));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_connectionroleobjecttypecode), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_connectionroleobjecttypecode));
      }
    }

    [AttributeLogicalName("connectionroleid")]
    [RelationshipSchemaName("connection_role_connection_role_object_type_codes")]
    public ConnectionRole connection_role_connection_role_object_type_codes
    {
      get
      {
        return this.GetRelatedEntity<ConnectionRole>(nameof (connection_role_connection_role_object_type_codes), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (connection_role_connection_role_object_type_codes));
        this.SetRelatedEntity<ConnectionRole>(nameof (connection_role_connection_role_object_type_codes), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (connection_role_connection_role_object_type_codes));
      }
    }

    public ConnectionRoleObjectTypeCode(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["connectionroleobjecttypecodeid"] = (object) base.Id;
            break;
          case "connectionroleobjecttypecodeid":
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
