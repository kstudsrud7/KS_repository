// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.SdkMessageRequest
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("sdkmessagerequest")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class SdkMessageRequest : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "sdkmessagerequest";
    public const string EntitySchemaName = "SdkMessageRequest";
    public const string PrimaryIdAttribute = "sdkmessagerequestid";

    public SdkMessageRequest()
      : base("sdkmessagerequest")
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

    [AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get => this.GetAttributeValue<EntityReference>("organizationid");
    }

    [AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime => this.GetAttributeValue<DateTime?>("overwritetime");

    [AttributeLogicalName("primaryobjecttypecode")]
    public string PrimaryObjectTypeCode => this.GetAttributeValue<string>("primaryobjecttypecode");

    [AttributeLogicalName("sdkmessagepairid")]
    public EntityReference SdkMessagePairId
    {
      get => this.GetAttributeValue<EntityReference>("sdkmessagepairid");
    }

    [AttributeLogicalName("sdkmessagerequestid")]
    public Guid? SdkMessageRequestId
    {
      get => this.GetAttributeValue<Guid?>("sdkmessagerequestid");
      set
      {
        this.OnPropertyChanging(nameof (SdkMessageRequestId));
        this.SetAttributeValue("sdkmessagerequestid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (SdkMessageRequestId));
      }
    }

    [AttributeLogicalName("sdkmessagerequestid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.SdkMessageRequestId = new Guid?(value);
    }

    [AttributeLogicalName("sdkmessagerequestidunique")]
    public Guid? SdkMessageRequestIdUnique
    {
      get => this.GetAttributeValue<Guid?>("sdkmessagerequestidunique");
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("messagerequest_sdkmessagerequestfield")]
    public IEnumerable<SdkMessageRequestField> messagerequest_sdkmessagerequestfield
    {
      get
      {
        return this.GetRelatedEntities<SdkMessageRequestField>(nameof (messagerequest_sdkmessagerequestfield), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (messagerequest_sdkmessagerequestfield));
        this.SetRelatedEntities<SdkMessageRequestField>(nameof (messagerequest_sdkmessagerequestfield), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (messagerequest_sdkmessagerequestfield));
      }
    }

    [RelationshipSchemaName("messagerequest_sdkmessageresponse")]
    public IEnumerable<SdkMessageResponse> messagerequest_sdkmessageresponse
    {
      get
      {
        return this.GetRelatedEntities<SdkMessageResponse>(nameof (messagerequest_sdkmessageresponse), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (messagerequest_sdkmessageresponse));
        this.SetRelatedEntities<SdkMessageResponse>(nameof (messagerequest_sdkmessageresponse), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (messagerequest_sdkmessageresponse));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_sdkmessagerequest")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_sdkmessagerequest
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_sdkmessagerequest), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_sdkmessagerequest));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_sdkmessagerequest), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_sdkmessagerequest));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("createdby_sdkmessagerequest")]
    public SystemUser createdby_sdkmessagerequest
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (createdby_sdkmessagerequest), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_sdkmessagerequest_createdonbehalfby")]
    public SystemUser lk_sdkmessagerequest_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_sdkmessagerequest_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_sdkmessagerequest_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_sdkmessagerequest_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_sdkmessagerequest_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_sdkmessagerequest_modifiedonbehalfby")]
    public SystemUser lk_sdkmessagerequest_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_sdkmessagerequest_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_sdkmessagerequest_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_sdkmessagerequest_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_sdkmessagerequest_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("sdkmessagepairid")]
    [RelationshipSchemaName("messagepair_sdkmessagerequest")]
    public SdkMessagePair messagepair_sdkmessagerequest
    {
      get
      {
        return this.GetRelatedEntity<SdkMessagePair>(nameof (messagepair_sdkmessagerequest), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("modifiedby_sdkmessagerequest")]
    public SystemUser modifiedby_sdkmessagerequest
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (modifiedby_sdkmessagerequest), new EntityRole?());
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_sdkmessagerequest")]
    public Organization organization_sdkmessagerequest
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_sdkmessagerequest), new EntityRole?());
      }
    }

    public SdkMessageRequest(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["sdkmessagerequestid"] = (object) base.Id;
            break;
          case "sdkmessagerequestid":
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
