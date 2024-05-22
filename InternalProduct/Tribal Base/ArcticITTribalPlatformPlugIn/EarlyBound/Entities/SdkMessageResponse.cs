// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.SdkMessageResponse
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("sdkmessageresponse")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class SdkMessageResponse : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "sdkmessageresponse";
    public const string EntitySchemaName = "SdkMessageResponse";
    public const string PrimaryIdAttribute = "sdkmessageresponseid";

    public SdkMessageResponse()
      : base("sdkmessageresponse")
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

    [AttributeLogicalName("componentstate")]
    public OptionSetValue ComponentState
    {
      get => this.GetAttributeValue<OptionSetValue>("componentstate");
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

    [AttributeLogicalName("customizationlevel")]
    public int? CustomizationLevel => this.GetAttributeValue<int?>("customizationlevel");

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

    [AttributeLogicalName("ismanaged")]
    public bool? IsManaged => this.GetAttributeValue<bool?>("ismanaged");

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

    [AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime => this.GetAttributeValue<DateTime?>("overwritetime");

    [AttributeLogicalName("sdkmessagerequestid")]
    public EntityReference SdkMessageRequestId
    {
      get => this.GetAttributeValue<EntityReference>("sdkmessagerequestid");
    }

    [AttributeLogicalName("sdkmessageresponseid")]
    public Guid? SdkMessageResponseId
    {
      get => this.GetAttributeValue<Guid?>("sdkmessageresponseid");
      set
      {
        this.OnPropertyChanging(nameof (SdkMessageResponseId));
        this.SetAttributeValue("sdkmessageresponseid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (SdkMessageResponseId));
      }
    }

    [AttributeLogicalName("sdkmessageresponseid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.SdkMessageResponseId = new Guid?(value);
    }

    [AttributeLogicalName("sdkmessageresponseidunique")]
    public Guid? SdkMessageResponseIdUnique
    {
      get => this.GetAttributeValue<Guid?>("sdkmessageresponseidunique");
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("messageresponse_sdkmessageresponsefield")]
    public IEnumerable<SdkMessageResponseField> messageresponse_sdkmessageresponsefield
    {
      get
      {
        return this.GetRelatedEntities<SdkMessageResponseField>(nameof (messageresponse_sdkmessageresponsefield), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (messageresponse_sdkmessageresponsefield));
        this.SetRelatedEntities<SdkMessageResponseField>(nameof (messageresponse_sdkmessageresponsefield), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (messageresponse_sdkmessageresponsefield));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_sdkmessageresponse")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_sdkmessageresponse
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_sdkmessageresponse), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_sdkmessageresponse));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_sdkmessageresponse), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_sdkmessageresponse));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("createdby_sdkmessageresponse")]
    public SystemUser createdby_sdkmessageresponse
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (createdby_sdkmessageresponse), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_sdkmessageresponse_createdonbehalfby")]
    public SystemUser lk_sdkmessageresponse_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_sdkmessageresponse_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_sdkmessageresponse_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_sdkmessageresponse_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_sdkmessageresponse_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_sdkmessageresponse_modifiedonbehalfby")]
    public SystemUser lk_sdkmessageresponse_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_sdkmessageresponse_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_sdkmessageresponse_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_sdkmessageresponse_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_sdkmessageresponse_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("sdkmessagerequestid")]
    [RelationshipSchemaName("messagerequest_sdkmessageresponse")]
    public SdkMessageRequest messagerequest_sdkmessageresponse
    {
      get
      {
        return this.GetRelatedEntity<SdkMessageRequest>(nameof (messagerequest_sdkmessageresponse), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("modifiedby_sdkmessageresponse")]
    public SystemUser modifiedby_sdkmessageresponse
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (modifiedby_sdkmessageresponse), new EntityRole?());
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_sdkmessageresponse")]
    public Organization organization_sdkmessageresponse
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_sdkmessageresponse), new EntityRole?());
      }
    }

    public SdkMessageResponse(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["sdkmessageresponseid"] = (object) base.Id;
            break;
          case "sdkmessageresponseid":
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
