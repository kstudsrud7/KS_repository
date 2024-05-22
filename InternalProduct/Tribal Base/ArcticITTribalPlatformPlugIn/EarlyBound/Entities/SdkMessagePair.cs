// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.SdkMessagePair
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("sdkmessagepair")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class SdkMessagePair : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "sdkmessagepair";
    public const string EntitySchemaName = "SdkMessagePair";
    public const string PrimaryIdAttribute = "sdkmessagepairid";

    public SdkMessagePair()
      : base("sdkmessagepair")
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

    [AttributeLogicalName("deprecatedversion")]
    public string DeprecatedVersion
    {
      get => this.GetAttributeValue<string>("deprecatedversion");
      set
      {
        this.OnPropertyChanging(nameof (DeprecatedVersion));
        this.SetAttributeValue("deprecatedversion", (object) value);
        this.OnPropertyChanged(nameof (DeprecatedVersion));
      }
    }

    [AttributeLogicalName("endpoint")]
    public string Endpoint
    {
      get => this.GetAttributeValue<string>("endpoint");
      set
      {
        this.OnPropertyChanging(nameof (Endpoint));
        this.SetAttributeValue("endpoint", (object) value);
        this.OnPropertyChanged(nameof (Endpoint));
      }
    }

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

    [AttributeLogicalName("namespace")]
    public string Namespace
    {
      get => this.GetAttributeValue<string>("namespace");
      set
      {
        this.OnPropertyChanging(nameof (Namespace));
        this.SetAttributeValue("namespace", (object) value);
        this.OnPropertyChanged(nameof (Namespace));
      }
    }

    [AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get => this.GetAttributeValue<EntityReference>("organizationid");
    }

    [AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime => this.GetAttributeValue<DateTime?>("overwritetime");

    [AttributeLogicalName("sdkmessagebindinginformation")]
    public string SdkMessageBindingInformation
    {
      get => this.GetAttributeValue<string>("sdkmessagebindinginformation");
      set
      {
        this.OnPropertyChanging(nameof (SdkMessageBindingInformation));
        this.SetAttributeValue("sdkmessagebindinginformation", (object) value);
        this.OnPropertyChanged(nameof (SdkMessageBindingInformation));
      }
    }

    [AttributeLogicalName("sdkmessageid")]
    public EntityReference SdkMessageId => this.GetAttributeValue<EntityReference>("sdkmessageid");

    [AttributeLogicalName("sdkmessagepairid")]
    public Guid? SdkMessagePairId
    {
      get => this.GetAttributeValue<Guid?>("sdkmessagepairid");
      set
      {
        this.OnPropertyChanging(nameof (SdkMessagePairId));
        this.SetAttributeValue("sdkmessagepairid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (SdkMessagePairId));
      }
    }

    [AttributeLogicalName("sdkmessagepairid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.SdkMessagePairId = new Guid?(value);
    }

    [AttributeLogicalName("sdkmessagepairidunique")]
    public Guid? SdkMessagePairIdUnique => this.GetAttributeValue<Guid?>("sdkmessagepairidunique");

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("messagepair_sdkmessagerequest")]
    public IEnumerable<SdkMessageRequest> messagepair_sdkmessagerequest
    {
      get
      {
        return this.GetRelatedEntities<SdkMessageRequest>(nameof (messagepair_sdkmessagerequest), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (messagepair_sdkmessagerequest));
        this.SetRelatedEntities<SdkMessageRequest>(nameof (messagepair_sdkmessagerequest), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (messagepair_sdkmessagerequest));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_sdkmessagepair")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_sdkmessagepair
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_sdkmessagepair), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_sdkmessagepair));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_sdkmessagepair), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_sdkmessagepair));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("createdby_sdkmessagepair")]
    public SystemUser createdby_sdkmessagepair
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (createdby_sdkmessagepair), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_sdkmessagepair_createdonbehalfby")]
    public SystemUser lk_sdkmessagepair_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_sdkmessagepair_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_sdkmessagepair_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_sdkmessagepair_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_sdkmessagepair_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_sdkmessagepair_modifiedonbehalfby")]
    public SystemUser lk_sdkmessagepair_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_sdkmessagepair_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_sdkmessagepair_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_sdkmessagepair_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_sdkmessagepair_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("sdkmessageid")]
    [RelationshipSchemaName("message_sdkmessagepair")]
    public SdkMessage message_sdkmessagepair
    {
      get => this.GetRelatedEntity<SdkMessage>(nameof (message_sdkmessagepair), new EntityRole?());
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("modifiedby_sdkmessagepair")]
    public SystemUser modifiedby_sdkmessagepair
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (modifiedby_sdkmessagepair), new EntityRole?());
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_sdkmessagepair")]
    public Organization organization_sdkmessagepair
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_sdkmessagepair), new EntityRole?());
      }
    }

    public SdkMessagePair(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["sdkmessagepairid"] = (object) base.Id;
            break;
          case "sdkmessagepairid":
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
