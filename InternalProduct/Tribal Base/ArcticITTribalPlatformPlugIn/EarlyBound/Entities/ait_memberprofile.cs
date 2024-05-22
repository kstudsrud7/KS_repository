// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_memberprofile
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_memberprofile")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_memberprofile : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_memberprofile";
    public const string EntitySchemaName = "ait_memberprofile";
    public const string PrimaryIdAttribute = "ait_memberprofileid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_memberprofile()
      : base(nameof (ait_memberprofile))
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

    [AttributeLogicalName("ait_bandid")]
    public EntityReference ait_bandid
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_bandid));
      set
      {
        this.OnPropertyChanging(nameof (ait_bandid));
        this.SetAttributeValue(nameof (ait_bandid), (object) value);
        this.OnPropertyChanged(nameof (ait_bandid));
      }
    }

    [AttributeLogicalName("ait_biologicalfatherconfidential")]
    public bool? ait_biologicalfatherconfidential
    {
      get => this.GetAttributeValue<bool?>(nameof (ait_biologicalfatherconfidential));
      set
      {
        this.OnPropertyChanging(nameof (ait_biologicalfatherconfidential));
        this.SetAttributeValue(nameof (ait_biologicalfatherconfidential), (object) value);
        this.OnPropertyChanged(nameof (ait_biologicalfatherconfidential));
      }
    }

    [AttributeLogicalName("ait_biologicalfatherprofile")]
    public EntityReference ait_biologicalfatherprofile
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_biologicalfatherprofile));
      set
      {
        this.OnPropertyChanging(nameof (ait_biologicalfatherprofile));
        this.SetAttributeValue(nameof (ait_biologicalfatherprofile), (object) value);
        this.OnPropertyChanged(nameof (ait_biologicalfatherprofile));
      }
    }

    [AttributeLogicalName("ait_biologicalmotherconfidential")]
    public bool? ait_biologicalmotherconfidential
    {
      get => this.GetAttributeValue<bool?>(nameof (ait_biologicalmotherconfidential));
      set
      {
        this.OnPropertyChanging(nameof (ait_biologicalmotherconfidential));
        this.SetAttributeValue(nameof (ait_biologicalmotherconfidential), (object) value);
        this.OnPropertyChanged(nameof (ait_biologicalmotherconfidential));
      }
    }

    [AttributeLogicalName("ait_biologicalmotherprofile")]
    public EntityReference ait_biologicalmotherprofile
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_biologicalmotherprofile));
      set
      {
        this.OnPropertyChanging(nameof (ait_biologicalmotherprofile));
        this.SetAttributeValue(nameof (ait_biologicalmotherprofile), (object) value);
        this.OnPropertyChanged(nameof (ait_biologicalmotherprofile));
      }
    }

    [AttributeLogicalName("ait_birthdate")]
    public DateTime? ait_Birthdate
    {
      get => this.GetAttributeValue<DateTime?>("ait_birthdate");
      set
      {
        this.OnPropertyChanging(nameof (ait_Birthdate));
        this.SetAttributeValue("ait_birthdate", (object) value);
        this.OnPropertyChanged(nameof (ait_Birthdate));
      }
    }

    [AttributeLogicalName("ait_bqcalculationlocked")]
    public OptionSetValue ait_bqcalculationlocked
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_bqcalculationlocked));
      set
      {
        this.OnPropertyChanging(nameof (ait_bqcalculationlocked));
        this.SetAttributeValue(nameof (ait_bqcalculationlocked), (object) value);
        this.OnPropertyChanged(nameof (ait_bqcalculationlocked));
      }
    }

    [AttributeLogicalName("ait_bqthresholdmet")]
    public bool? ait_bqthresholdmet
    {
      get => this.GetAttributeValue<bool?>(nameof (ait_bqthresholdmet));
      set
      {
        this.OnPropertyChanging(nameof (ait_bqthresholdmet));
        this.SetAttributeValue(nameof (ait_bqthresholdmet), (object) value);
        this.OnPropertyChanged(nameof (ait_bqthresholdmet));
      }
    }

    [AttributeLogicalName("ait_cardlastissuedby")]
    public string ait_cardlastissuedby
    {
      get => this.GetAttributeValue<string>(nameof (ait_cardlastissuedby));
      set
      {
        this.OnPropertyChanging(nameof (ait_cardlastissuedby));
        this.SetAttributeValue(nameof (ait_cardlastissuedby), (object) value);
        this.OnPropertyChanged(nameof (ait_cardlastissuedby));
      }
    }

    [AttributeLogicalName("ait_cardlastissueddate")]
    public DateTime? ait_cardlastissueddate
    {
      get => this.GetAttributeValue<DateTime?>(nameof (ait_cardlastissueddate));
      set
      {
        this.OnPropertyChanging(nameof (ait_cardlastissueddate));
        this.SetAttributeValue(nameof (ait_cardlastissueddate), (object) value);
        this.OnPropertyChanged(nameof (ait_cardlastissueddate));
      }
    }

    [AttributeLogicalName("ait_cardlastissuedexpiration")]
    public DateTime? ait_cardlastissuedexpiration
    {
      get => this.GetAttributeValue<DateTime?>(nameof (ait_cardlastissuedexpiration));
      set
      {
        this.OnPropertyChanging(nameof (ait_cardlastissuedexpiration));
        this.SetAttributeValue(nameof (ait_cardlastissuedexpiration), (object) value);
        this.OnPropertyChanged(nameof (ait_cardlastissuedexpiration));
      }
    }

    [AttributeLogicalName("ait_cardproxynumber")]
    public string ait_cardproxynumber
    {
      get => this.GetAttributeValue<string>(nameof (ait_cardproxynumber));
      set
      {
        this.OnPropertyChanging(nameof (ait_cardproxynumber));
        this.SetAttributeValue(nameof (ait_cardproxynumber), (object) value);
        this.OnPropertyChanged(nameof (ait_cardproxynumber));
      }
    }

    [AttributeLogicalName("ait_cardsissued")]
    public int? ait_cardsissued
    {
      get => this.GetAttributeValue<int?>(nameof (ait_cardsissued));
      set
      {
        this.OnPropertyChanging(nameof (ait_cardsissued));
        this.SetAttributeValue(nameof (ait_cardsissued), (object) value);
        this.OnPropertyChanged(nameof (ait_cardsissued));
      }
    }

    [AttributeLogicalName("ait_clan")]
    public EntityReference ait_clan
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_clan));
      set
      {
        this.OnPropertyChanging(nameof (ait_clan));
        this.SetAttributeValue(nameof (ait_clan), (object) value);
        this.OnPropertyChanged(nameof (ait_clan));
      }
    }

    [AttributeLogicalName("ait_contact")]
    public EntityReference ait_Contact
    {
      get => this.GetAttributeValue<EntityReference>("ait_contact");
      set
      {
        this.OnPropertyChanging(nameof (ait_Contact));
        this.SetAttributeValue("ait_contact", (object) value);
        this.OnPropertyChanged(nameof (ait_Contact));
      }
    }

    [AttributeLogicalName("ait_description")]
    public string ait_description
    {
      get => this.GetAttributeValue<string>(nameof (ait_description));
      set
      {
        this.OnPropertyChanging(nameof (ait_description));
        this.SetAttributeValue(nameof (ait_description), (object) value);
        this.OnPropertyChanged(nameof (ait_description));
      }
    }

    [AttributeLogicalName("ait_enrollmentdate")]
    public DateTime? ait_enrollmentdate
    {
      get => this.GetAttributeValue<DateTime?>(nameof (ait_enrollmentdate));
      set
      {
        this.OnPropertyChanging(nameof (ait_enrollmentdate));
        this.SetAttributeValue(nameof (ait_enrollmentdate), (object) value);
        this.OnPropertyChanged(nameof (ait_enrollmentdate));
      }
    }

    [AttributeLogicalName("ait_federalvoter")]
    public OptionSetValue ait_federalvoter
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_federalvoter));
      set
      {
        this.OnPropertyChanging(nameof (ait_federalvoter));
        this.SetAttributeValue(nameof (ait_federalvoter), (object) value);
        this.OnPropertyChanged(nameof (ait_federalvoter));
      }
    }

    [AttributeLogicalName("ait_memberid")]
    public string ait_memberid
    {
      get => this.GetAttributeValue<string>(nameof (ait_memberid));
      set
      {
        this.OnPropertyChanging(nameof (ait_memberid));
        this.SetAttributeValue(nameof (ait_memberid), (object) value);
        this.OnPropertyChanged(nameof (ait_memberid));
      }
    }

    [AttributeLogicalName("ait_memberprofileid")]
    public Guid? ait_memberprofileId
    {
      get => this.GetAttributeValue<Guid?>("ait_memberprofileid");
      set
      {
        this.OnPropertyChanging(nameof (ait_memberprofileId));
        this.SetAttributeValue("ait_memberprofileid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_memberprofileId));
      }
    }

    [AttributeLogicalName("ait_memberprofileid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_memberprofileId = new Guid?(value);
    }

    [AttributeLogicalName("ait_membershipcardtype")]
    public OptionSetValue ait_membershipcardtype
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_membershipcardtype));
      set
      {
        this.OnPropertyChanging(nameof (ait_membershipcardtype));
        this.SetAttributeValue(nameof (ait_membershipcardtype), (object) value);
        this.OnPropertyChanged(nameof (ait_membershipcardtype));
      }
    }

    [AttributeLogicalName("ait_membershipstatus")]
    public OptionSetValue ait_membershipstatus
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_membershipstatus));
      set
      {
        this.OnPropertyChanging(nameof (ait_membershipstatus));
        this.SetAttributeValue(nameof (ait_membershipstatus), (object) value);
        this.OnPropertyChanged(nameof (ait_membershipstatus));
      }
    }

    [AttributeLogicalName("ait_memberstatuseffectivedate")]
    public DateTime? ait_memberstatuseffectivedate
    {
      get => this.GetAttributeValue<DateTime?>(nameof (ait_memberstatuseffectivedate));
      set
      {
        this.OnPropertyChanging(nameof (ait_memberstatuseffectivedate));
        this.SetAttributeValue(nameof (ait_memberstatuseffectivedate), (object) value);
        this.OnPropertyChanged(nameof (ait_memberstatuseffectivedate));
      }
    }

    [AttributeLogicalName("ait_mostrecentchangerequest")]
    public EntityReference ait_mostrecentchangerequest
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_mostrecentchangerequest));
      set
      {
        this.OnPropertyChanging(nameof (ait_mostrecentchangerequest));
        this.SetAttributeValue(nameof (ait_mostrecentchangerequest), (object) value);
        this.OnPropertyChanged(nameof (ait_mostrecentchangerequest));
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

    [AttributeLogicalName("ait_otherrelinquishedreason")]
    public string ait_otherrelinquishedreason
    {
      get => this.GetAttributeValue<string>(nameof (ait_otherrelinquishedreason));
      set
      {
        this.OnPropertyChanging(nameof (ait_otherrelinquishedreason));
        this.SetAttributeValue(nameof (ait_otherrelinquishedreason), (object) value);
        this.OnPropertyChanged(nameof (ait_otherrelinquishedreason));
      }
    }

    [AttributeLogicalName("ait_otherrevokedreason")]
    public string ait_otherrevokedreason
    {
      get => this.GetAttributeValue<string>(nameof (ait_otherrevokedreason));
      set
      {
        this.OnPropertyChanging(nameof (ait_otherrevokedreason));
        this.SetAttributeValue(nameof (ait_otherrevokedreason), (object) value);
        this.OnPropertyChanged(nameof (ait_otherrevokedreason));
      }
    }

    [AttributeLogicalName("ait_relinquisheddate")]
    public DateTime? ait_relinquisheddate
    {
      get => this.GetAttributeValue<DateTime?>(nameof (ait_relinquisheddate));
      set
      {
        this.OnPropertyChanging(nameof (ait_relinquisheddate));
        this.SetAttributeValue(nameof (ait_relinquisheddate), (object) value);
        this.OnPropertyChanged(nameof (ait_relinquisheddate));
      }
    }

    [AttributeLogicalName("ait_relinquishedreason")]
    public OptionSetValue ait_relinquishedreason
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_relinquishedreason));
      set
      {
        this.OnPropertyChanging(nameof (ait_relinquishedreason));
        this.SetAttributeValue(nameof (ait_relinquishedreason), (object) value);
        this.OnPropertyChanged(nameof (ait_relinquishedreason));
      }
    }

    [AttributeLogicalName("ait_revokeddate")]
    public DateTime? ait_revokeddate
    {
      get => this.GetAttributeValue<DateTime?>(nameof (ait_revokeddate));
      set
      {
        this.OnPropertyChanging(nameof (ait_revokeddate));
        this.SetAttributeValue(nameof (ait_revokeddate), (object) value);
        this.OnPropertyChanged(nameof (ait_revokeddate));
      }
    }

    [AttributeLogicalName("ait_revokedreason")]
    public OptionSetValue ait_revokedreason
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_revokedreason));
      set
      {
        this.OnPropertyChanging(nameof (ait_revokedreason));
        this.SetAttributeValue(nameof (ait_revokedreason), (object) value);
        this.OnPropertyChanged(nameof (ait_revokedreason));
      }
    }

    [AttributeLogicalName("ait_totalbqdecimal")]
    public Decimal? ait_totalbqdecimal
    {
      get => this.GetAttributeValue<Decimal?>(nameof (ait_totalbqdecimal));
      set
      {
        this.OnPropertyChanging(nameof (ait_totalbqdecimal));
        this.SetAttributeValue(nameof (ait_totalbqdecimal), (object) value);
        this.OnPropertyChanged(nameof (ait_totalbqdecimal));
      }
    }

    [AttributeLogicalName("ait_totalbqfraction")]
    public string ait_totalbqfraction
    {
      get => this.GetAttributeValue<string>(nameof (ait_totalbqfraction));
      set
      {
        this.OnPropertyChanging(nameof (ait_totalbqfraction));
        this.SetAttributeValue(nameof (ait_totalbqfraction), (object) value);
        this.OnPropertyChanged(nameof (ait_totalbqfraction));
      }
    }

    [AttributeLogicalName("ait_tribalbqdecimal")]
    public Decimal? ait_tribalbqdecimal
    {
      get => this.GetAttributeValue<Decimal?>(nameof (ait_tribalbqdecimal));
      set
      {
        this.OnPropertyChanging(nameof (ait_tribalbqdecimal));
        this.SetAttributeValue(nameof (ait_tribalbqdecimal), (object) value);
        this.OnPropertyChanged(nameof (ait_tribalbqdecimal));
      }
    }

    [AttributeLogicalName("ait_tribalbqfraction")]
    public string ait_tribalbqfraction
    {
      get => this.GetAttributeValue<string>(nameof (ait_tribalbqfraction));
      set
      {
        this.OnPropertyChanging(nameof (ait_tribalbqfraction));
        this.SetAttributeValue(nameof (ait_tribalbqfraction), (object) value);
        this.OnPropertyChanged(nameof (ait_tribalbqfraction));
      }
    }

    [AttributeLogicalName("ait_tribalid")]
    public string ait_tribalid
    {
      get => this.GetAttributeValue<string>(nameof (ait_tribalid));
      set
      {
        this.OnPropertyChanging(nameof (ait_tribalid));
        this.SetAttributeValue(nameof (ait_tribalid), (object) value);
        this.OnPropertyChanged(nameof (ait_tribalid));
      }
    }

    [AttributeLogicalName("ait_tribe")]
    public EntityReference ait_tribe
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_tribe));
      set
      {
        this.OnPropertyChanging(nameof (ait_tribe));
        this.SetAttributeValue(nameof (ait_tribe), (object) value);
        this.OnPropertyChanged(nameof (ait_tribe));
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

    [AttributeLogicalName("entityimage")]
    public byte[] EntityImage
    {
      get => this.GetAttributeValue<byte[]>("entityimage");
      set
      {
        this.OnPropertyChanging(nameof (EntityImage));
        this.SetAttributeValue("entityimage", (object) value);
        this.OnPropertyChanged(nameof (EntityImage));
      }
    }

    [AttributeLogicalName("entityimage_timestamp")]
    public long? EntityImage_Timestamp => this.GetAttributeValue<long?>("entityimage_timestamp");

    [AttributeLogicalName("entityimage_url")]
    public string EntityImage_URL => this.GetAttributeValue<string>("entityimage_url");

    [AttributeLogicalName("entityimageid")]
    public Guid? EntityImageId => this.GetAttributeValue<Guid?>("entityimageid");

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

    [AttributeLogicalName("ownerid")]
    public EntityReference OwnerId
    {
      get => this.GetAttributeValue<EntityReference>("ownerid");
      set
      {
        this.OnPropertyChanging(nameof (OwnerId));
        this.SetAttributeValue("ownerid", (object) value);
        this.OnPropertyChanged(nameof (OwnerId));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    public EntityReference OwningBusinessUnit
    {
      get => this.GetAttributeValue<EntityReference>("owningbusinessunit");
    }

    [AttributeLogicalName("owningteam")]
    public EntityReference OwningTeam => this.GetAttributeValue<EntityReference>("owningteam");

    [AttributeLogicalName("owninguser")]
    public EntityReference OwningUser => this.GetAttributeValue<EntityReference>("owninguser");

    [AttributeLogicalName("statecode")]
    public ait_memberprofileState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_memberprofileState?((ait_memberprofileState) Enum.ToObject(typeof (ait_memberprofileState), attributeValue.Value)) : new ait_memberprofileState?();
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

    [RelationshipSchemaName("ait_ait_bloodquantum_ait_memberprofile")]
    public IEnumerable<ait_bloodquantum> ait_ait_bloodquantum_ait_memberprofile
    {
      get
      {
        return this.GetRelatedEntities<ait_bloodquantum>(nameof (ait_ait_bloodquantum_ait_memberprofile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_bloodquantum_ait_memberprofile));
        this.SetRelatedEntities<ait_bloodquantum>(nameof (ait_ait_bloodquantum_ait_memberprofile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_bloodquantum_ait_memberprofile));
      }
    }

    [RelationshipSchemaName]
    public IEnumerable<ait_memberprofile> Referencedait_ait_memberprofile_ait_memberprofile_biologicalfatherprofile
    {
      get
      {
        return this.GetRelatedEntities<ait_memberprofile>("ait_ait_memberprofile_ait_memberprofile_biologicalfatherprofile", new EntityRole?((EntityRole) 1));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencedait_ait_memberprofile_ait_memberprofile_biologicalfatherprofile));
        this.SetRelatedEntities<ait_memberprofile>("ait_ait_memberprofile_ait_memberprofile_biologicalfatherprofile", new EntityRole?((EntityRole) 1), value);
        this.OnPropertyChanged(nameof (Referencedait_ait_memberprofile_ait_memberprofile_biologicalfatherprofile));
      }
    }

    [RelationshipSchemaName]
    public IEnumerable<ait_memberprofile> Referencedait_ait_memberprofile_ait_memberprofile_biologicalmotherprofile
    {
      get
      {
        return this.GetRelatedEntities<ait_memberprofile>("ait_ait_memberprofile_ait_memberprofile_biologicalmotherprofile", new EntityRole?((EntityRole) 1));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencedait_ait_memberprofile_ait_memberprofile_biologicalmotherprofile));
        this.SetRelatedEntities<ait_memberprofile>("ait_ait_memberprofile_ait_memberprofile_biologicalmotherprofile", new EntityRole?((EntityRole) 1), value);
        this.OnPropertyChanged(nameof (Referencedait_ait_memberprofile_ait_memberprofile_biologicalmotherprofile));
      }
    }

    [RelationshipSchemaName("ait_ait_memberprofile_ait_memberprofilemembershipcategory_memberprofile")]
    public IEnumerable<ait_memberprofilemembershipcategory> ait_ait_memberprofile_ait_memberprofilemembershipcategory_memberprofile
    {
      get
      {
        return this.GetRelatedEntities<ait_memberprofilemembershipcategory>(nameof (ait_ait_memberprofile_ait_memberprofilemembershipcategory_memberprofile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_memberprofile_ait_memberprofilemembershipcategory_memberprofile));
        this.SetRelatedEntities<ait_memberprofilemembershipcategory>(nameof (ait_ait_memberprofile_ait_memberprofilemembershipcategory_memberprofile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_memberprofile_ait_memberprofilemembershipcategory_memberprofile));
      }
    }

    [RelationshipSchemaName("ait_ait_memberprofile_contact_MemberProfile")]
    public IEnumerable<Contact> ait_ait_memberprofile_contact_MemberProfile
    {
      get
      {
        return this.GetRelatedEntities<Contact>(nameof (ait_ait_memberprofile_contact_MemberProfile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_memberprofile_contact_MemberProfile));
        this.SetRelatedEntities<Contact>(nameof (ait_ait_memberprofile_contact_MemberProfile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_memberprofile_contact_MemberProfile));
      }
    }

    [RelationshipSchemaName("ait_ait_memberroll_ait_memberprofile")]
    public IEnumerable<ait_memberroll> ait_ait_memberroll_ait_memberprofile
    {
      get
      {
        return this.GetRelatedEntities<ait_memberroll>(nameof (ait_ait_memberroll_ait_memberprofile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_memberroll_ait_memberprofile));
        this.SetRelatedEntities<ait_memberroll>(nameof (ait_ait_memberroll_ait_memberprofile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_memberroll_ait_memberprofile));
      }
    }

    [RelationshipSchemaName("ait_ait_membershipstatuschangerequest_ait_memberprofile")]
    public IEnumerable<ait_membershipstatuschangerequest> ait_ait_membershipstatuschangerequest_ait_memberprofile
    {
      get
      {
        return this.GetRelatedEntities<ait_membershipstatuschangerequest>(nameof (ait_ait_membershipstatuschangerequest_ait_memberprofile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_membershipstatuschangerequest_ait_memberprofile));
        this.SetRelatedEntities<ait_membershipstatuschangerequest>(nameof (ait_ait_membershipstatuschangerequest_ait_memberprofile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_membershipstatuschangerequest_ait_memberprofile));
      }
    }

    [RelationshipSchemaName("ait_memberprofile_Annotations")]
    public IEnumerable<Annotation> ait_memberprofile_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (ait_memberprofile_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_memberprofile_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (ait_memberprofile_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_memberprofile_Annotations));
      }
    }

    [RelationshipSchemaName("ait_memberprofile_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_memberprofile_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_memberprofile_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_memberprofile_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_memberprofile_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_memberprofile_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_memberprofile_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_memberprofile_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_memberprofile_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_memberprofile_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_memberprofile_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_memberprofile_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_memberprofile_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_memberprofile_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_memberprofile_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_memberprofile_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_memberprofile_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_memberprofile_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_memberprofile_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_memberprofile_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_memberprofile_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_memberprofile_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_memberprofile_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_memberprofile_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_memberprofile_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_memberprofile_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_memberprofile_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_memberprofile_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_memberprofile_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_memberprofile_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_memberprofile_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_memberprofile_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_memberprofile_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_memberprofile_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_memberprofile_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_memberprofile_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_memberprofile_ProcessSession")]
    public IEnumerable<ProcessSession> ait_memberprofile_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_memberprofile_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_memberprofile_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_memberprofile_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_memberprofile_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_memberprofile_SharePointDocumentLocations")]
    public IEnumerable<SharePointDocumentLocation> ait_memberprofile_SharePointDocumentLocations
    {
      get
      {
        return this.GetRelatedEntities<SharePointDocumentLocation>(nameof (ait_memberprofile_SharePointDocumentLocations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_memberprofile_SharePointDocumentLocations));
        this.SetRelatedEntities<SharePointDocumentLocation>(nameof (ait_memberprofile_SharePointDocumentLocations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_memberprofile_SharePointDocumentLocations));
      }
    }

    [RelationshipSchemaName("ait_memberprofile_SharePointDocuments")]
    public IEnumerable<SharePointDocument> ait_memberprofile_SharePointDocuments
    {
      get
      {
        return this.GetRelatedEntities<SharePointDocument>(nameof (ait_memberprofile_SharePointDocuments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_memberprofile_SharePointDocuments));
        this.SetRelatedEntities<SharePointDocument>(nameof (ait_memberprofile_SharePointDocuments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_memberprofile_SharePointDocuments));
      }
    }

    [RelationshipSchemaName("ait_memberprofile_SyncErrors")]
    public IEnumerable<SyncError> ait_memberprofile_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_memberprofile_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_memberprofile_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_memberprofile_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_memberprofile_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_memberprofile_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_memberprofile_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_memberprofile_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_memberprofile_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_memberprofile_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_memberprofile_UserEntityInstanceDatas));
      }
    }

    [RelationshipSchemaName("ait_ait_memberprofile_ait_membershipcategory")]
    public IEnumerable<ait_membershipcategory> ait_ait_memberprofile_ait_membershipcategory
    {
      get
      {
        return this.GetRelatedEntities<ait_membershipcategory>(nameof (ait_ait_memberprofile_ait_membershipcategory), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_memberprofile_ait_membershipcategory));
        this.SetRelatedEntities<ait_membershipcategory>(nameof (ait_ait_memberprofile_ait_membershipcategory), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_memberprofile_ait_membershipcategory));
      }
    }

    [RelationshipSchemaName("ait_ait_resolution_ait_memberprofile")]
    public IEnumerable<ait_resolution> ait_ait_resolution_ait_memberprofile
    {
      get
      {
        return this.GetRelatedEntities<ait_resolution>(nameof (ait_ait_resolution_ait_memberprofile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_resolution_ait_memberprofile));
        this.SetRelatedEntities<ait_resolution>(nameof (ait_ait_resolution_ait_memberprofile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_resolution_ait_memberprofile));
      }
    }

    [AttributeLogicalName("ait_bandid")]
    [RelationshipSchemaName("ait_ait_band_ait_memberprofile_bandid")]
    public ait_band ait_ait_band_ait_memberprofile_bandid
    {
      get
      {
        return this.GetRelatedEntity<ait_band>(nameof (ait_ait_band_ait_memberprofile_bandid), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_band_ait_memberprofile_bandid));
        this.SetRelatedEntity<ait_band>(nameof (ait_ait_band_ait_memberprofile_bandid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_band_ait_memberprofile_bandid));
      }
    }

    [AttributeLogicalName("ait_clan")]
    [RelationshipSchemaName("ait_ait_memberprofile_ait_clan")]
    public ArcticIT.EarlyBound.Entities.ait_clan ait_ait_memberprofile_ait_clan
    {
      get
      {
        return this.GetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_clan>(nameof (ait_ait_memberprofile_ait_clan), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_memberprofile_ait_clan));
        this.SetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_clan>(nameof (ait_ait_memberprofile_ait_clan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_memberprofile_ait_clan));
      }
    }

    [AttributeLogicalName("ait_biologicalfatherprofile")]
    [RelationshipSchemaName]
    public ait_memberprofile Referencingait_ait_memberprofile_ait_memberprofile_biologicalfatherprofile
    {
      get
      {
        return this.GetRelatedEntity<ait_memberprofile>("ait_ait_memberprofile_ait_memberprofile_biologicalfatherprofile", new EntityRole?((EntityRole) 0));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencingait_ait_memberprofile_ait_memberprofile_biologicalfatherprofile));
        this.SetRelatedEntity<ait_memberprofile>("ait_ait_memberprofile_ait_memberprofile_biologicalfatherprofile", new EntityRole?((EntityRole) 0), value);
        this.OnPropertyChanged(nameof (Referencingait_ait_memberprofile_ait_memberprofile_biologicalfatherprofile));
      }
    }

    [AttributeLogicalName("ait_biologicalmotherprofile")]
    [RelationshipSchemaName]
    public ait_memberprofile Referencingait_ait_memberprofile_ait_memberprofile_biologicalmotherprofile
    {
      get
      {
        return this.GetRelatedEntity<ait_memberprofile>("ait_ait_memberprofile_ait_memberprofile_biologicalmotherprofile", new EntityRole?((EntityRole) 0));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencingait_ait_memberprofile_ait_memberprofile_biologicalmotherprofile));
        this.SetRelatedEntity<ait_memberprofile>("ait_ait_memberprofile_ait_memberprofile_biologicalmotherprofile", new EntityRole?((EntityRole) 0), value);
        this.OnPropertyChanged(nameof (Referencingait_ait_memberprofile_ait_memberprofile_biologicalmotherprofile));
      }
    }

    [AttributeLogicalName("ait_mostrecentchangerequest")]
    [RelationshipSchemaName("ait_ait_memberprofile_ait_membershipstatuschangerequest")]
    public ait_membershipstatuschangerequest ait_ait_memberprofile_ait_membershipstatuschangerequest
    {
      get
      {
        return this.GetRelatedEntity<ait_membershipstatuschangerequest>(nameof (ait_ait_memberprofile_ait_membershipstatuschangerequest), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_memberprofile_ait_membershipstatuschangerequest));
        this.SetRelatedEntity<ait_membershipstatuschangerequest>(nameof (ait_ait_memberprofile_ait_membershipstatuschangerequest), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_memberprofile_ait_membershipstatuschangerequest));
      }
    }

    [AttributeLogicalName("ait_tribe")]
    [RelationshipSchemaName("ait_ait_tribe_ait_memberprofile_tribe")]
    public ArcticIT.EarlyBound.Entities.ait_tribe ait_ait_tribe_ait_memberprofile_tribe
    {
      get
      {
        return this.GetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_tribe>(nameof (ait_ait_tribe_ait_memberprofile_tribe), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_tribe_ait_memberprofile_tribe));
        this.SetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_tribe>(nameof (ait_ait_tribe_ait_memberprofile_tribe), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_tribe_ait_memberprofile_tribe));
      }
    }

    [AttributeLogicalName("ait_contact")]
    [RelationshipSchemaName("ait_contact_ait_memberprofile_Contact")]
    public Contact ait_contact_ait_memberprofile_Contact
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (ait_contact_ait_memberprofile_Contact), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contact_ait_memberprofile_Contact));
        this.SetRelatedEntity<Contact>(nameof (ait_contact_ait_memberprofile_Contact), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contact_ait_memberprofile_Contact));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_memberprofile")]
    public BusinessUnit business_unit_ait_memberprofile
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_memberprofile), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_memberprofile_createdby")]
    public SystemUser lk_ait_memberprofile_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_memberprofile_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_memberprofile_createdonbehalfby")]
    public SystemUser lk_ait_memberprofile_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_memberprofile_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_memberprofile_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_memberprofile_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_memberprofile_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_memberprofile_modifiedby")]
    public SystemUser lk_ait_memberprofile_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_memberprofile_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_memberprofile_modifiedonbehalfby")]
    public SystemUser lk_ait_memberprofile_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_memberprofile_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_memberprofile_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_memberprofile_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_memberprofile_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_memberprofile")]
    public Team team_ait_memberprofile
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_memberprofile), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_memberprofile")]
    public SystemUser user_ait_memberprofile
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_ait_memberprofile), new EntityRole?());
    }

    public ait_memberprofile(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_memberprofileid"] = (object) base.Id;
            break;
          case "ait_memberprofileid":
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
