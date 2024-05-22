// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.OwnerMapping
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ownermapping")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class OwnerMapping : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ownermapping";
    public const string EntitySchemaName = "OwnerMapping";
    public const string PrimaryIdAttribute = "ownermappingid";

    public OwnerMapping()
      : base("ownermapping")
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

    [AttributeLogicalName("importmapid")]
    public EntityReference ImportMapId
    {
      get => this.GetAttributeValue<EntityReference>("importmapid");
      set
      {
        this.OnPropertyChanging(nameof (ImportMapId));
        this.SetAttributeValue("importmapid", (object) value);
        this.OnPropertyChanged(nameof (ImportMapId));
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

    [AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime => this.GetAttributeValue<DateTime?>("overwritetime");

    [AttributeLogicalName("ownermappingid")]
    public Guid? OwnerMappingId
    {
      get => this.GetAttributeValue<Guid?>("ownermappingid");
      set
      {
        this.OnPropertyChanging(nameof (OwnerMappingId));
        this.SetAttributeValue("ownermappingid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (OwnerMappingId));
      }
    }

    [AttributeLogicalName("ownermappingid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.OwnerMappingId = new Guid?(value);
    }

    [AttributeLogicalName("ownermappingidunique")]
    public Guid? OwnerMappingIdUnique => this.GetAttributeValue<Guid?>("ownermappingidunique");

    [AttributeLogicalName("processcode")]
    public OptionSetValue ProcessCode
    {
      get => this.GetAttributeValue<OptionSetValue>("processcode");
      set
      {
        this.OnPropertyChanging(nameof (ProcessCode));
        this.SetAttributeValue("processcode", (object) value);
        this.OnPropertyChanged(nameof (ProcessCode));
      }
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("sourcesystemusername")]
    public string SourceSystemUserName
    {
      get => this.GetAttributeValue<string>("sourcesystemusername");
      set
      {
        this.OnPropertyChanging(nameof (SourceSystemUserName));
        this.SetAttributeValue("sourcesystemusername", (object) value);
        this.OnPropertyChanged(nameof (SourceSystemUserName));
      }
    }

    [AttributeLogicalName("sourceuservalueforsourcecrmuserlink")]
    public string SourceUserValueForSourceCRMUserLink
    {
      get => this.GetAttributeValue<string>("sourceuservalueforsourcecrmuserlink");
      set
      {
        this.OnPropertyChanging(nameof (SourceUserValueForSourceCRMUserLink));
        this.SetAttributeValue("sourceuservalueforsourcecrmuserlink", (object) value);
        this.OnPropertyChanged(nameof (SourceUserValueForSourceCRMUserLink));
      }
    }

    [AttributeLogicalName("statecode")]
    public OwnerMappingState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new OwnerMappingState?((OwnerMappingState) Enum.ToObject(typeof (OwnerMappingState), attributeValue.Value)) : new OwnerMappingState?();
      }
    }

    [AttributeLogicalName("statuscode")]
    public OptionSetValue StatusCode
    {
      get => this.GetAttributeValue<OptionSetValue>("statuscode");
      set
      {
        this.OnPropertyChanging(nameof (StatusCode));
        this.SetAttributeValue("statuscode", (object) value);
        this.OnPropertyChanged(nameof (StatusCode));
      }
    }

    [AttributeLogicalName("targetsystemuserdomainname")]
    public string TargetSystemUserDomainName
    {
      get => this.GetAttributeValue<string>("targetsystemuserdomainname");
      set
      {
        this.OnPropertyChanging(nameof (TargetSystemUserDomainName));
        this.SetAttributeValue("targetsystemuserdomainname", (object) value);
        this.OnPropertyChanged(nameof (TargetSystemUserDomainName));
      }
    }

    [AttributeLogicalName("targetsystemuserid")]
    public EntityReference TargetSystemUserId
    {
      get => this.GetAttributeValue<EntityReference>("targetsystemuserid");
      set
      {
        this.OnPropertyChanging(nameof (TargetSystemUserId));
        this.SetAttributeValue("targetsystemuserid", (object) value);
        this.OnPropertyChanged(nameof (TargetSystemUserId));
      }
    }

    [AttributeLogicalName("targetuservalueforsourcecrmuserlink")]
    public string TargetUserValueForSourceCRMUserLink
    {
      get => this.GetAttributeValue<string>("targetuservalueforsourcecrmuserlink");
      set
      {
        this.OnPropertyChanging(nameof (TargetUserValueForSourceCRMUserLink));
        this.SetAttributeValue("targetuservalueforsourcecrmuserlink", (object) value);
        this.OnPropertyChanged(nameof (TargetUserValueForSourceCRMUserLink));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_ownermapping")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_ownermapping
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_ownermapping), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_ownermapping));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_ownermapping), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_ownermapping));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ownermapping_createdby")]
    public SystemUser lk_ownermapping_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ownermapping_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ownermapping_createdonbehalfby")]
    public SystemUser lk_ownermapping_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ownermapping_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ownermapping_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ownermapping_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ownermapping_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ownermapping_modifiedby")]
    public SystemUser lk_ownermapping_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ownermapping_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ownermapping_modifiedonbehalfby")]
    public SystemUser lk_ownermapping_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ownermapping_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ownermapping_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ownermapping_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ownermapping_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("importmapid")]
    [RelationshipSchemaName("OwnerMapping_ImportMap")]
    public ImportMap OwnerMapping_ImportMap
    {
      get => this.GetRelatedEntity<ImportMap>(nameof (OwnerMapping_ImportMap), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (OwnerMapping_ImportMap));
        this.SetRelatedEntity<ImportMap>(nameof (OwnerMapping_ImportMap), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (OwnerMapping_ImportMap));
      }
    }

    [AttributeLogicalName("targetsystemuserid")]
    [RelationshipSchemaName("OwnerMapping_SystemUser")]
    public SystemUser OwnerMapping_SystemUser
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (OwnerMapping_SystemUser), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (OwnerMapping_SystemUser));
        this.SetRelatedEntity<SystemUser>(nameof (OwnerMapping_SystemUser), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (OwnerMapping_SystemUser));
      }
    }

    public OwnerMapping(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ownermappingid"] = (object) base.Id;
            break;
          case "ownermappingid":
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
