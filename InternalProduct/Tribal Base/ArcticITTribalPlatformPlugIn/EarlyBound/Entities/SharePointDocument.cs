// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.SharePointDocument
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("sharepointdocument")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class SharePointDocument : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "sharepointdocument";
    public const string EntitySchemaName = "SharePointDocument";
    public const string PrimaryIdAttribute = "sharepointdocumentid";
    public const string PrimaryNameAttribute = "fullname";

    public SharePointDocument()
      : base("sharepointdocument")
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

    [AttributeLogicalName("absoluteurl")]
    public string AbsoluteUrl => this.GetAttributeValue<string>("absoluteurl");

    [AttributeLogicalName("appcreatedby")]
    public string AppCreatedBy => this.GetAttributeValue<string>("appcreatedby");

    [AttributeLogicalName("appmodifiedby")]
    public string AppModifiedBy => this.GetAttributeValue<string>("appmodifiedby");

    [AttributeLogicalName("author")]
    public string Author
    {
      get => this.GetAttributeValue<string>("author");
      set
      {
        this.OnPropertyChanging(nameof (Author));
        this.SetAttributeValue("author", (object) value);
        this.OnPropertyChanged(nameof (Author));
      }
    }

    [AttributeLogicalName("businessunitid")]
    public EntityReference BusinessUnitId
    {
      get => this.GetAttributeValue<EntityReference>("businessunitid");
      set
      {
        this.OnPropertyChanging(nameof (BusinessUnitId));
        this.SetAttributeValue("businessunitid", (object) value);
        this.OnPropertyChanged(nameof (BusinessUnitId));
      }
    }

    [AttributeLogicalName("checkedoutto")]
    public string CheckedOutTo => this.GetAttributeValue<string>("checkedoutto");

    [AttributeLogicalName("checkincomment")]
    public string CheckInComment => this.GetAttributeValue<string>("checkincomment");

    [AttributeLogicalName("childfoldercount")]
    public int? ChildFolderCount => this.GetAttributeValue<int?>("childfoldercount");

    [AttributeLogicalName("childitemcount")]
    public int? ChildItemCount => this.GetAttributeValue<int?>("childitemcount");

    [AttributeLogicalName("contenttype")]
    public string ContentType => this.GetAttributeValue<string>("contenttype");

    [AttributeLogicalName("contenttypeid")]
    public int? ContentTypeId => this.GetAttributeValue<int?>("contenttypeid");

    [AttributeLogicalName("copysource")]
    public string CopySource => this.GetAttributeValue<string>("copysource");

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

    [AttributeLogicalName("documentid")]
    public int? DocumentId => this.GetAttributeValue<int?>("documentid");

    [AttributeLogicalName("documentlocationtype")]
    public OptionSetValue DocumentLocationType
    {
      get => this.GetAttributeValue<OptionSetValue>("documentlocationtype");
    }

    [AttributeLogicalName("edit")]
    public string Edit => this.GetAttributeValue<string>("edit");

    [AttributeLogicalName("editurl")]
    public string EditUrl => this.GetAttributeValue<string>("editurl");

    [AttributeLogicalName("exchangerate")]
    public Decimal? ExchangeRate => this.GetAttributeValue<Decimal?>("exchangerate");

    [AttributeLogicalName("filesize")]
    public int? FileSize => this.GetAttributeValue<int?>("filesize");

    [AttributeLogicalName("filetype")]
    public string FileType => this.GetAttributeValue<string>("filetype");

    [AttributeLogicalName("fullname")]
    public string FullName => this.GetAttributeValue<string>("fullname");

    [AttributeLogicalName("iconclassname")]
    public string IconClassName => this.GetAttributeValue<string>("iconclassname");

    [AttributeLogicalName("ischeckedout")]
    public bool? IsCheckedOut => this.GetAttributeValue<bool?>("ischeckedout");

    [AttributeLogicalName("isfolder")]
    public bool? IsFolder => this.GetAttributeValue<bool?>("isfolder");

    [AttributeLogicalName("isrecursivefetch")]
    public bool? IsRecursiveFetch => this.GetAttributeValue<bool?>("isrecursivefetch");

    [AttributeLogicalName("locationid")]
    public string LocationId => this.GetAttributeValue<string>("locationid");

    [AttributeLogicalName("locationname")]
    public string LocationName => this.GetAttributeValue<string>("locationname");

    [AttributeLogicalName("modified")]
    public DateTime? Modified => this.GetAttributeValue<DateTime?>("modified");

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

    [AttributeLogicalName("readurl")]
    public string ReadUrl => this.GetAttributeValue<string>("readurl");

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

    [AttributeLogicalName("relativelocation")]
    public string RelativeLocation => this.GetAttributeValue<string>("relativelocation");

    [AttributeLogicalName("servicetype")]
    public OptionSetValue ServiceType
    {
      get => this.GetAttributeValue<OptionSetValue>("servicetype");
      set
      {
        this.OnPropertyChanging(nameof (ServiceType));
        this.SetAttributeValue("servicetype", (object) value);
        this.OnPropertyChanged(nameof (ServiceType));
      }
    }

    [AttributeLogicalName("sharepointcreatedon")]
    public DateTime? SharePointCreatedOn
    {
      get => this.GetAttributeValue<DateTime?>("sharepointcreatedon");
    }

    [AttributeLogicalName("sharepointdocumentid")]
    public Guid? SharePointDocumentId
    {
      get => this.GetAttributeValue<Guid?>("sharepointdocumentid");
      set
      {
        this.OnPropertyChanging(nameof (SharePointDocumentId));
        this.SetAttributeValue("sharepointdocumentid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (SharePointDocumentId));
      }
    }

    [AttributeLogicalName("sharepointdocumentid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.SharePointDocumentId = new Guid?(value);
    }

    [AttributeLogicalName("sharepointmodifiedby")]
    public string SharePointModifiedBy => this.GetAttributeValue<string>("sharepointmodifiedby");

    [AttributeLogicalName("title")]
    public string Title => this.GetAttributeValue<string>("title");

    [AttributeLogicalName("transactioncurrencyid")]
    public EntityReference TransactionCurrencyId
    {
      get => this.GetAttributeValue<EntityReference>("transactioncurrencyid");
    }

    [AttributeLogicalName("version")]
    public string Version => this.GetAttributeValue<string>("version");

    [RelationshipSchemaName("SharePointDocument_Annotation")]
    public IEnumerable<Annotation> SharePointDocument_Annotation
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (SharePointDocument_Annotation), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SharePointDocument_Annotation));
        this.SetRelatedEntities<Annotation>(nameof (SharePointDocument_Annotation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SharePointDocument_Annotation));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Account_SharepointDocument")]
    public Account Account_SharepointDocument
    {
      get => this.GetRelatedEntity<Account>(nameof (Account_SharepointDocument), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Account_SharepointDocument));
        this.SetRelatedEntity<Account>(nameof (Account_SharepointDocument), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Account_SharepointDocument));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_case_SharePointDocuments")]
    public ait_case ait_case_SharePointDocuments
    {
      get
      {
        return this.GetRelatedEntity<ait_case>(nameof (ait_case_SharePointDocuments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_case_SharePointDocuments));
        this.SetRelatedEntity<ait_case>(nameof (ait_case_SharePointDocuments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_case_SharePointDocuments));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_casenote_SharePointDocuments")]
    public ait_casenote ait_casenote_SharePointDocuments
    {
      get
      {
        return this.GetRelatedEntity<ait_casenote>(nameof (ait_casenote_SharePointDocuments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_casenote_SharePointDocuments));
        this.SetRelatedEntity<ait_casenote>(nameof (ait_casenote_SharePointDocuments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_casenote_SharePointDocuments));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_caseplan_SharePointDocuments")]
    public ait_caseplan ait_caseplan_SharePointDocuments
    {
      get
      {
        return this.GetRelatedEntity<ait_caseplan>(nameof (ait_caseplan_SharePointDocuments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_caseplan_SharePointDocuments));
        this.SetRelatedEntity<ait_caseplan>(nameof (ait_caseplan_SharePointDocuments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_caseplan_SharePointDocuments));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_clientprofile_SharePointDocuments")]
    public ait_clientprofile ait_clientprofile_SharePointDocuments
    {
      get
      {
        return this.GetRelatedEntity<ait_clientprofile>(nameof (ait_clientprofile_SharePointDocuments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_SharePointDocuments));
        this.SetRelatedEntity<ait_clientprofile>(nameof (ait_clientprofile_SharePointDocuments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_SharePointDocuments));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_courtcase_SharePointDocuments")]
    public ait_courtcase ait_courtcase_SharePointDocuments
    {
      get
      {
        return this.GetRelatedEntity<ait_courtcase>(nameof (ait_courtcase_SharePointDocuments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtcase_SharePointDocuments));
        this.SetRelatedEntity<ait_courtcase>(nameof (ait_courtcase_SharePointDocuments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtcase_SharePointDocuments));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_courtprofile_SharePointDocuments")]
    public ait_courtprofile ait_courtprofile_SharePointDocuments
    {
      get
      {
        return this.GetRelatedEntity<ait_courtprofile>(nameof (ait_courtprofile_SharePointDocuments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtprofile_SharePointDocuments));
        this.SetRelatedEntity<ait_courtprofile>(nameof (ait_courtprofile_SharePointDocuments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtprofile_SharePointDocuments));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_icwanotice_SharePointDocuments")]
    public ait_icwanotice ait_icwanotice_SharePointDocuments
    {
      get
      {
        return this.GetRelatedEntity<ait_icwanotice>(nameof (ait_icwanotice_SharePointDocuments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwanotice_SharePointDocuments));
        this.SetRelatedEntity<ait_icwanotice>(nameof (ait_icwanotice_SharePointDocuments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwanotice_SharePointDocuments));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_incident_SharePointDocuments")]
    public ait_incident ait_incident_SharePointDocuments
    {
      get
      {
        return this.GetRelatedEntity<ait_incident>(nameof (ait_incident_SharePointDocuments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incident_SharePointDocuments));
        this.SetRelatedEntity<ait_incident>(nameof (ait_incident_SharePointDocuments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incident_SharePointDocuments));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_medicalproviders_SharePointDocuments")]
    public ait_medicalproviders ait_medicalproviders_SharePointDocuments
    {
      get
      {
        return this.GetRelatedEntity<ait_medicalproviders>(nameof (ait_medicalproviders_SharePointDocuments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_medicalproviders_SharePointDocuments));
        this.SetRelatedEntity<ait_medicalproviders>(nameof (ait_medicalproviders_SharePointDocuments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_medicalproviders_SharePointDocuments));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_memberprofile_SharePointDocuments")]
    public ait_memberprofile ait_memberprofile_SharePointDocuments
    {
      get
      {
        return this.GetRelatedEntity<ait_memberprofile>(nameof (ait_memberprofile_SharePointDocuments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_memberprofile_SharePointDocuments));
        this.SetRelatedEntity<ait_memberprofile>(nameof (ait_memberprofile_SharePointDocuments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_memberprofile_SharePointDocuments));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_placement_SharePointDocuments")]
    public ait_placement ait_placement_SharePointDocuments
    {
      get
      {
        return this.GetRelatedEntity<ait_placement>(nameof (ait_placement_SharePointDocuments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_placement_SharePointDocuments));
        this.SetRelatedEntity<ait_placement>(nameof (ait_placement_SharePointDocuments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_placement_SharePointDocuments));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_placementlocation_SharePointDocuments")]
    public ait_placementlocation ait_placementlocation_SharePointDocuments
    {
      get
      {
        return this.GetRelatedEntity<ait_placementlocation>(nameof (ait_placementlocation_SharePointDocuments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_placementlocation_SharePointDocuments));
        this.SetRelatedEntity<ait_placementlocation>(nameof (ait_placementlocation_SharePointDocuments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_placementlocation_SharePointDocuments));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_program_SharePointDocuments")]
    public ait_program ait_program_SharePointDocuments
    {
      get
      {
        return this.GetRelatedEntity<ait_program>(nameof (ait_program_SharePointDocuments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_program_SharePointDocuments));
        this.SetRelatedEntity<ait_program>(nameof (ait_program_SharePointDocuments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_program_SharePointDocuments));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_referral_SharePointDocuments")]
    public ait_referral ait_referral_SharePointDocuments
    {
      get
      {
        return this.GetRelatedEntity<ait_referral>(nameof (ait_referral_SharePointDocuments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_referral_SharePointDocuments));
        this.SetRelatedEntity<ait_referral>(nameof (ait_referral_SharePointDocuments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_referral_SharePointDocuments));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_safetyplan_SharePointDocuments")]
    public ait_safetyplan ait_safetyplan_SharePointDocuments
    {
      get
      {
        return this.GetRelatedEntity<ait_safetyplan>(nameof (ait_safetyplan_SharePointDocuments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_safetyplan_SharePointDocuments));
        this.SetRelatedEntity<ait_safetyplan>(nameof (ait_safetyplan_SharePointDocuments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_safetyplan_SharePointDocuments));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_servicerequest_SharePointDocuments")]
    public ait_servicerequest ait_servicerequest_SharePointDocuments
    {
      get
      {
        return this.GetRelatedEntity<ait_servicerequest>(nameof (ait_servicerequest_SharePointDocuments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_SharePointDocuments));
        this.SetRelatedEntity<ait_servicerequest>(nameof (ait_servicerequest_SharePointDocuments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_SharePointDocuments));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_sharepointdocument")]
    public BusinessUnit business_unit_sharepointdocument
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_sharepointdocument), new EntityRole?());
      }
    }

    [AttributeLogicalName("businessunitid")]
    [RelationshipSchemaName("business_unit_sharepointdocument2")]
    public BusinessUnit business_unit_sharepointdocument2
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_sharepointdocument2), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_sharepointdocument2));
        this.SetRelatedEntity<BusinessUnit>(nameof (business_unit_sharepointdocument2), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_sharepointdocument2));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("contact_SharePointDocuments")]
    public Contact contact_SharePointDocuments
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (contact_SharePointDocuments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (contact_SharePointDocuments));
        this.SetRelatedEntity<Contact>(nameof (contact_SharePointDocuments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (contact_SharePointDocuments));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("KbArticle_SharepointDocument")]
    public KbArticle KbArticle_SharepointDocument
    {
      get
      {
        return this.GetRelatedEntity<KbArticle>(nameof (KbArticle_SharepointDocument), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KbArticle_SharepointDocument));
        this.SetRelatedEntity<KbArticle>(nameof (KbArticle_SharepointDocument), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KbArticle_SharepointDocument));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("knowledgearticle_SharePointDocuments")]
    public KnowledgeArticle knowledgearticle_SharePointDocuments
    {
      get
      {
        return this.GetRelatedEntity<KnowledgeArticle>(nameof (knowledgearticle_SharePointDocuments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (knowledgearticle_SharePointDocuments));
        this.SetRelatedEntity<KnowledgeArticle>(nameof (knowledgearticle_SharePointDocuments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (knowledgearticle_SharePointDocuments));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_sharepointdocumentbase_createdby")]
    public SystemUser lk_sharepointdocumentbase_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_sharepointdocumentbase_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_sharepointdocumentbase_createdonbehalfby")]
    public SystemUser lk_sharepointdocumentbase_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_sharepointdocumentbase_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_sharepointdocumentbase_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_sharepointdocumentbase_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_sharepointdocumentbase_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_sharepointdocumentbase_modifiedby")]
    public SystemUser lk_sharepointdocumentbase_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_sharepointdocumentbase_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_sharepointdocumentbase_modifiedonbehalfby")]
    public SystemUser lk_sharepointdocumentbase_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_sharepointdocumentbase_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_sharepointdocumentbase_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_sharepointdocumentbase_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_sharepointdocumentbase_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_knowledgearticletemplate_SharePointDocuments")]
    public msdyn_knowledgearticletemplate msdyn_knowledgearticletemplate_SharePointDocuments
    {
      get
      {
        return this.GetRelatedEntity<msdyn_knowledgearticletemplate>(nameof (msdyn_knowledgearticletemplate_SharePointDocuments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgearticletemplate_SharePointDocuments));
        this.SetRelatedEntity<msdyn_knowledgearticletemplate>(nameof (msdyn_knowledgearticletemplate_SharePointDocuments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgearticletemplate_SharePointDocuments));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_sharepointdocument")]
    public Organization organization_sharepointdocument
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_sharepointdocument), new EntityRole?());
      }
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_SharePointDocument")]
    public TransactionCurrency TransactionCurrency_SharePointDocument
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_SharePointDocument), new EntityRole?());
      }
    }

    public SharePointDocument(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["sharepointdocumentid"] = (object) base.Id;
            break;
          case "sharepointdocumentid":
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
