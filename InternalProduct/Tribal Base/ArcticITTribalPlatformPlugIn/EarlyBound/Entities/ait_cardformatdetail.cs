// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_cardformatdetail
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_cardformatdetail")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_cardformatdetail : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_cardformatdetail";
    public const string EntitySchemaName = "ait_cardformatdetail";
    public const string PrimaryIdAttribute = "ait_cardformatdetailid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_cardformatdetail()
      : base(nameof (ait_cardformatdetail))
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

    [AttributeLogicalName("ait_background")]
    public string ait_background
    {
      get => this.GetAttributeValue<string>(nameof (ait_background));
      set
      {
        this.OnPropertyChanging(nameof (ait_background));
        this.SetAttributeValue(nameof (ait_background), (object) value);
        this.OnPropertyChanged(nameof (ait_background));
      }
    }

    [AttributeLogicalName("ait_cardformat")]
    public EntityReference ait_cardformat
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_cardformat));
      set
      {
        this.OnPropertyChanging(nameof (ait_cardformat));
        this.SetAttributeValue(nameof (ait_cardformat), (object) value);
        this.OnPropertyChanged(nameof (ait_cardformat));
      }
    }

    [AttributeLogicalName("ait_cardformatdetailid")]
    public Guid? ait_cardformatdetailId
    {
      get => this.GetAttributeValue<Guid?>("ait_cardformatdetailid");
      set
      {
        this.OnPropertyChanging(nameof (ait_cardformatdetailId));
        this.SetAttributeValue("ait_cardformatdetailid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_cardformatdetailId));
      }
    }

    [AttributeLogicalName("ait_cardformatdetailid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_cardformatdetailId = new Guid?(value);
    }

    [AttributeLogicalName("ait_contactfield")]
    public OptionSetValue ait_contactfield
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_contactfield));
      set
      {
        this.OnPropertyChanging(nameof (ait_contactfield));
        this.SetAttributeValue(nameof (ait_contactfield), (object) value);
        this.OnPropertyChanged(nameof (ait_contactfield));
      }
    }

    [AttributeLogicalName("ait_content")]
    public string ait_content
    {
      get => this.GetAttributeValue<string>(nameof (ait_content));
      set
      {
        this.OnPropertyChanging(nameof (ait_content));
        this.SetAttributeValue(nameof (ait_content), (object) value);
        this.OnPropertyChanged(nameof (ait_content));
      }
    }

    [AttributeLogicalName("ait_foreground")]
    public string ait_foreground
    {
      get => this.GetAttributeValue<string>(nameof (ait_foreground));
      set
      {
        this.OnPropertyChanging(nameof (ait_foreground));
        this.SetAttributeValue(nameof (ait_foreground), (object) value);
        this.OnPropertyChanged(nameof (ait_foreground));
      }
    }

    [AttributeLogicalName("ait_halign")]
    public string ait_halign
    {
      get => this.GetAttributeValue<string>(nameof (ait_halign));
      set
      {
        this.OnPropertyChanging(nameof (ait_halign));
        this.SetAttributeValue(nameof (ait_halign), (object) value);
        this.OnPropertyChanged(nameof (ait_halign));
      }
    }

    [AttributeLogicalName("ait_height")]
    public int? ait_height
    {
      get => this.GetAttributeValue<int?>(nameof (ait_height));
      set
      {
        this.OnPropertyChanging(nameof (ait_height));
        this.SetAttributeValue(nameof (ait_height), (object) value);
        this.OnPropertyChanged(nameof (ait_height));
      }
    }

    [AttributeLogicalName("ait_left")]
    public int? ait_left
    {
      get => this.GetAttributeValue<int?>(nameof (ait_left));
      set
      {
        this.OnPropertyChanging(nameof (ait_left));
        this.SetAttributeValue(nameof (ait_left), (object) value);
        this.OnPropertyChanged(nameof (ait_left));
      }
    }

    [AttributeLogicalName("ait_logo1image")]
    public string ait_logo1image
    {
      get => this.GetAttributeValue<string>(nameof (ait_logo1image));
      set
      {
        this.OnPropertyChanging(nameof (ait_logo1image));
        this.SetAttributeValue(nameof (ait_logo1image), (object) value);
        this.OnPropertyChanged(nameof (ait_logo1image));
      }
    }

    [AttributeLogicalName("ait_name")]
    public string ait_name
    {
      get => this.GetAttributeValue<string>(nameof (ait_name));
      set
      {
        this.OnPropertyChanging(nameof (ait_name));
        this.SetAttributeValue(nameof (ait_name), (object) value);
        this.OnPropertyChanged(nameof (ait_name));
      }
    }

    [AttributeLogicalName("ait_opacity")]
    public double? ait_opacity
    {
      get => this.GetAttributeValue<double?>(nameof (ait_opacity));
      set
      {
        this.OnPropertyChanging(nameof (ait_opacity));
        this.SetAttributeValue(nameof (ait_opacity), (object) value);
        this.OnPropertyChanged(nameof (ait_opacity));
      }
    }

    [AttributeLogicalName("ait_printfont")]
    public OptionSetValue ait_printfont
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_printfont));
      set
      {
        this.OnPropertyChanging(nameof (ait_printfont));
        this.SetAttributeValue(nameof (ait_printfont), (object) value);
        this.OnPropertyChanged(nameof (ait_printfont));
      }
    }

    [AttributeLogicalName("ait_printfontsize")]
    public double? ait_printfontsize
    {
      get => this.GetAttributeValue<double?>(nameof (ait_printfontsize));
      set
      {
        this.OnPropertyChanging(nameof (ait_printfontsize));
        this.SetAttributeValue(nameof (ait_printfontsize), (object) value);
        this.OnPropertyChanged(nameof (ait_printfontsize));
      }
    }

    [AttributeLogicalName("ait_printfontstyle")]
    public OptionSetValue ait_printfontstyle
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_printfontstyle));
      set
      {
        this.OnPropertyChanging(nameof (ait_printfontstyle));
        this.SetAttributeValue(nameof (ait_printfontstyle), (object) value);
        this.OnPropertyChanged(nameof (ait_printfontstyle));
      }
    }

    [AttributeLogicalName("ait_rotationangle")]
    public double? ait_rotationangle
    {
      get => this.GetAttributeValue<double?>(nameof (ait_rotationangle));
      set
      {
        this.OnPropertyChanging(nameof (ait_rotationangle));
        this.SetAttributeValue(nameof (ait_rotationangle), (object) value);
        this.OnPropertyChanged(nameof (ait_rotationangle));
      }
    }

    [AttributeLogicalName("ait_side")]
    public OptionSetValue ait_side
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_side));
      set
      {
        this.OnPropertyChanging(nameof (ait_side));
        this.SetAttributeValue(nameof (ait_side), (object) value);
        this.OnPropertyChanged(nameof (ait_side));
      }
    }

    [AttributeLogicalName("ait_top")]
    public int? ait_top
    {
      get => this.GetAttributeValue<int?>(nameof (ait_top));
      set
      {
        this.OnPropertyChanging(nameof (ait_top));
        this.SetAttributeValue(nameof (ait_top), (object) value);
        this.OnPropertyChanged(nameof (ait_top));
      }
    }

    [AttributeLogicalName("ait_type")]
    public OptionSetValue ait_type
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_type));
      set
      {
        this.OnPropertyChanging(nameof (ait_type));
        this.SetAttributeValue(nameof (ait_type), (object) value);
        this.OnPropertyChanged(nameof (ait_type));
      }
    }

    [AttributeLogicalName("ait_valign")]
    public string ait_valign
    {
      get => this.GetAttributeValue<string>(nameof (ait_valign));
      set
      {
        this.OnPropertyChanging(nameof (ait_valign));
        this.SetAttributeValue(nameof (ait_valign), (object) value);
        this.OnPropertyChanged(nameof (ait_valign));
      }
    }

    [AttributeLogicalName("ait_width")]
    public int? ait_width
    {
      get => this.GetAttributeValue<int?>(nameof (ait_width));
      set
      {
        this.OnPropertyChanging(nameof (ait_width));
        this.SetAttributeValue(nameof (ait_width), (object) value);
        this.OnPropertyChanged(nameof (ait_width));
      }
    }

    [AttributeLogicalName("ait_zindex")]
    public int? ait_zindex
    {
      get => this.GetAttributeValue<int?>(nameof (ait_zindex));
      set
      {
        this.OnPropertyChanging(nameof (ait_zindex));
        this.SetAttributeValue(nameof (ait_zindex), (object) value);
        this.OnPropertyChanged(nameof (ait_zindex));
      }
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

    [AttributeLogicalName("importsequencenumber")]
    public int? ImportSequenceNumber
    {
      get => this.GetAttributeValue<int?>("importsequencenumber");
      set
      {
        this.OnPropertyChanging(nameof (ImportSequenceNumber));
        this.SetAttributeValue("importsequencenumber", (object) value);
        this.OnPropertyChanged(nameof (ImportSequenceNumber));
      }
    }

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

    [AttributeLogicalName("overriddencreatedon")]
    public DateTime? OverriddenCreatedOn
    {
      get => this.GetAttributeValue<DateTime?>("overriddencreatedon");
      set
      {
        this.OnPropertyChanging(nameof (OverriddenCreatedOn));
        this.SetAttributeValue("overriddencreatedon", (object) value);
        this.OnPropertyChanged(nameof (OverriddenCreatedOn));
      }
    }

    [AttributeLogicalName("statecode")]
    public ait_cardformatdetailState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_cardformatdetailState?((ait_cardformatdetailState) Enum.ToObject(typeof (ait_cardformatdetailState), attributeValue.Value)) : new ait_cardformatdetailState?();
      }
      set
      {
        this.OnPropertyChanging(nameof (statecode));
        if (!value.HasValue)
          this.SetAttributeValue(nameof (statecode), (object) null);
        else
          this.SetAttributeValue(nameof (statecode), (object) new OptionSetValue((int) value.Value));
        this.OnPropertyChanged(nameof (statecode));
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

    [AttributeLogicalName("timezoneruleversionnumber")]
    public int? TimeZoneRuleVersionNumber
    {
      get => this.GetAttributeValue<int?>("timezoneruleversionnumber");
      set
      {
        this.OnPropertyChanging(nameof (TimeZoneRuleVersionNumber));
        this.SetAttributeValue("timezoneruleversionnumber", (object) value);
        this.OnPropertyChanged(nameof (TimeZoneRuleVersionNumber));
      }
    }

    [AttributeLogicalName("utcconversiontimezonecode")]
    public int? UTCConversionTimeZoneCode
    {
      get => this.GetAttributeValue<int?>("utcconversiontimezonecode");
      set
      {
        this.OnPropertyChanging(nameof (UTCConversionTimeZoneCode));
        this.SetAttributeValue("utcconversiontimezonecode", (object) value);
        this.OnPropertyChanged(nameof (UTCConversionTimeZoneCode));
      }
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("ait_cardformatdetail_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_cardformatdetail_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_cardformatdetail_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_cardformatdetail_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_cardformatdetail_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_cardformatdetail_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_cardformatdetail_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_cardformatdetail_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_cardformatdetail_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_cardformatdetail_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_cardformatdetail_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_cardformatdetail_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_cardformatdetail_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_cardformatdetail_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_cardformatdetail_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_cardformatdetail_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_cardformatdetail_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_cardformatdetail_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_cardformatdetail_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_cardformatdetail_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_cardformatdetail_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_cardformatdetail_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_cardformatdetail_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_cardformatdetail_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_cardformatdetail_ProcessSession")]
    public IEnumerable<ProcessSession> ait_cardformatdetail_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_cardformatdetail_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_cardformatdetail_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_cardformatdetail_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_cardformatdetail_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_cardformatdetail_SyncErrors")]
    public IEnumerable<SyncError> ait_cardformatdetail_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_cardformatdetail_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_cardformatdetail_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_cardformatdetail_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_cardformatdetail_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_cardformatdetail_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_cardformatdetail_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_cardformatdetail_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_cardformatdetail_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_cardformatdetail_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_cardformatdetail_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_cardformat")]
    [RelationshipSchemaName("ait_ait_cardformat_ait_cardformatdetail_cardformat")]
    public ArcticIT.EarlyBound.Entities.ait_cardformat ait_ait_cardformat_ait_cardformatdetail_cardformat
    {
      get
      {
        return this.GetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_cardformat>(nameof (ait_ait_cardformat_ait_cardformatdetail_cardformat), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_cardformat_ait_cardformatdetail_cardformat));
        this.SetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_cardformat>(nameof (ait_ait_cardformat_ait_cardformatdetail_cardformat), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_cardformat_ait_cardformatdetail_cardformat));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_cardformatdetail_createdby")]
    public SystemUser lk_ait_cardformatdetail_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_cardformatdetail_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_cardformatdetail_createdonbehalfby")]
    public SystemUser lk_ait_cardformatdetail_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_cardformatdetail_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_cardformatdetail_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_cardformatdetail_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_cardformatdetail_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_cardformatdetail_modifiedby")]
    public SystemUser lk_ait_cardformatdetail_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_cardformatdetail_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_cardformatdetail_modifiedonbehalfby")]
    public SystemUser lk_ait_cardformatdetail_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_cardformatdetail_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_cardformatdetail_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_cardformatdetail_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_cardformatdetail_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_ait_cardformatdetail")]
    public Organization organization_ait_cardformatdetail
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_ait_cardformatdetail), new EntityRole?());
      }
    }

    public ait_cardformatdetail(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_cardformatdetailid"] = (object) base.Id;
            break;
          case "ait_cardformatdetailid":
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
