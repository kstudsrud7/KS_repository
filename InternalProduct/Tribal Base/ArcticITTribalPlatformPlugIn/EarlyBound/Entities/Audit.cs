// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.Audit
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("audit")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class Audit : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "audit";
    public const string EntitySchemaName = "Audit";
    public const string PrimaryIdAttribute = "auditid";

    public Audit()
      : base("audit")
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

    [AttributeLogicalName("action")]
    public OptionSetValue Action => this.GetAttributeValue<OptionSetValue>("action");

    [AttributeLogicalName("attributemask")]
    public string AttributeMask => this.GetAttributeValue<string>("attributemask");

    [AttributeLogicalName("auditid")]
    public Guid? AuditId => this.GetAttributeValue<Guid?>("auditid");

    [AttributeLogicalName("auditid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => base.Id = value;
    }

    [AttributeLogicalName("callinguserid")]
    public EntityReference CallingUserId
    {
      get => this.GetAttributeValue<EntityReference>("callinguserid");
    }

    [AttributeLogicalName("createdon")]
    public DateTime? CreatedOn => this.GetAttributeValue<DateTime?>("createdon");

    [AttributeLogicalName("objectid")]
    public EntityReference ObjectId => this.GetAttributeValue<EntityReference>("objectid");

    [AttributeLogicalName("operation")]
    public OptionSetValue Operation => this.GetAttributeValue<OptionSetValue>("operation");

    [AttributeLogicalName("regardingobjectid")]
    public EntityReference RegardingObjectId
    {
      get => this.GetAttributeValue<EntityReference>("regardingobjectid");
      set
      {
        this.OnPropertyChanging(nameof (RegardingObjectId));
        this.SetAttributeValue("regardingobjectid", (object) value);
        this.OnPropertyChanged(nameof (RegardingObjectId));
      }
    }

    [AttributeLogicalName("transactionid")]
    public Guid? TransactionId => this.GetAttributeValue<Guid?>("transactionid");

    [AttributeLogicalName("useradditionalinfo")]
    public string UserAdditionalInfo
    {
      get => this.GetAttributeValue<string>("useradditionalinfo");
      set
      {
        this.OnPropertyChanging(nameof (UserAdditionalInfo));
        this.SetAttributeValue("useradditionalinfo", (object) value);
        this.OnPropertyChanged(nameof (UserAdditionalInfo));
      }
    }

    [AttributeLogicalName("userid")]
    public EntityReference UserId => this.GetAttributeValue<EntityReference>("userid");

    [RelationshipSchemaName("userentityinstancedata_audit")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_audit
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_audit), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_audit));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_audit), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_audit));
      }
    }

    [AttributeLogicalName("callinguserid")]
    [RelationshipSchemaName("lk_audit_callinguserid")]
    public SystemUser lk_audit_callinguserid
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_audit_callinguserid), new EntityRole?());
    }

    [AttributeLogicalName("userid")]
    [RelationshipSchemaName("lk_audit_userid")]
    public SystemUser lk_audit_userid
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_audit_userid), new EntityRole?());
    }

    public Audit(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["auditid"] = (object) base.Id;
            break;
          case "auditid":
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
