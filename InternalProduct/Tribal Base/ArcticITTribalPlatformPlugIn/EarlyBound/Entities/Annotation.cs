// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.Annotation
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("annotation")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class Annotation : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "annotation";
    public const string EntitySchemaName = "Annotation";
    public const string PrimaryIdAttribute = "annotationid";
    public const string PrimaryNameAttribute = "subject";

    public Annotation()
      : base("annotation")
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

    [AttributeLogicalName("annotationid")]
    public Guid? AnnotationId
    {
      get => this.GetAttributeValue<Guid?>("annotationid");
      set
      {
        this.OnPropertyChanging(nameof (AnnotationId));
        this.SetAttributeValue("annotationid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (AnnotationId));
      }
    }

    [AttributeLogicalName("annotationid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.AnnotationId = new Guid?(value);
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

    [AttributeLogicalName("documentbody")]
    public string DocumentBody
    {
      get => this.GetAttributeValue<string>("documentbody");
      set
      {
        this.OnPropertyChanging(nameof (DocumentBody));
        this.SetAttributeValue("documentbody", (object) value);
        this.OnPropertyChanged(nameof (DocumentBody));
      }
    }

    [AttributeLogicalName("dummyfilename")]
    public string DummyFileName => this.GetAttributeValue<string>("dummyfilename");

    [AttributeLogicalName("dummyregarding")]
    public string DummyRegarding => this.GetAttributeValue<string>("dummyregarding");

    [AttributeLogicalName("filename")]
    public string FileName
    {
      get => this.GetAttributeValue<string>("filename");
      set
      {
        this.OnPropertyChanging(nameof (FileName));
        this.SetAttributeValue("filename", (object) value);
        this.OnPropertyChanged(nameof (FileName));
      }
    }

    [AttributeLogicalName("filesize")]
    public int? FileSize => this.GetAttributeValue<int?>("filesize");

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

    [AttributeLogicalName("isdocument")]
    public bool? IsDocument
    {
      get => this.GetAttributeValue<bool?>("isdocument");
      set
      {
        this.OnPropertyChanging(nameof (IsDocument));
        this.SetAttributeValue("isdocument", (object) value);
        this.OnPropertyChanged(nameof (IsDocument));
      }
    }

    [AttributeLogicalName("langid")]
    public string LangId
    {
      get => this.GetAttributeValue<string>("langid");
      set
      {
        this.OnPropertyChanging(nameof (LangId));
        this.SetAttributeValue("langid", (object) value);
        this.OnPropertyChanged(nameof (LangId));
      }
    }

    [AttributeLogicalName("mimetype")]
    public string MimeType
    {
      get => this.GetAttributeValue<string>("mimetype");
      set
      {
        this.OnPropertyChanging(nameof (MimeType));
        this.SetAttributeValue("mimetype", (object) value);
        this.OnPropertyChanged(nameof (MimeType));
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

    [AttributeLogicalName("notetext")]
    public string NoteText
    {
      get => this.GetAttributeValue<string>("notetext");
      set
      {
        this.OnPropertyChanging(nameof (NoteText));
        this.SetAttributeValue("notetext", (object) value);
        this.OnPropertyChanged(nameof (NoteText));
      }
    }

    [AttributeLogicalName("objectid")]
    public EntityReference ObjectId
    {
      get => this.GetAttributeValue<EntityReference>("objectid");
      set
      {
        this.OnPropertyChanging(nameof (ObjectId));
        this.SetAttributeValue("objectid", (object) value);
        this.OnPropertyChanged(nameof (ObjectId));
      }
    }

    [AttributeLogicalName("objecttypecode")]
    public string ObjectTypeCode
    {
      get => this.GetAttributeValue<string>("objecttypecode");
      set
      {
        this.OnPropertyChanging(nameof (ObjectTypeCode));
        this.SetAttributeValue("objecttypecode", (object) value);
        this.OnPropertyChanged(nameof (ObjectTypeCode));
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

    [AttributeLogicalName("prefix")]
    public string Prefix => this.GetAttributeValue<string>("prefix");

    [AttributeLogicalName("stepid")]
    public string StepId
    {
      get => this.GetAttributeValue<string>("stepid");
      set
      {
        this.OnPropertyChanging(nameof (StepId));
        this.SetAttributeValue("stepid", (object) value);
        this.OnPropertyChanged(nameof (StepId));
      }
    }

    [AttributeLogicalName("subject")]
    public string Subject
    {
      get => this.GetAttributeValue<string>("subject");
      set
      {
        this.OnPropertyChanging(nameof (Subject));
        this.SetAttributeValue("subject", (object) value);
        this.OnPropertyChanged(nameof (Subject));
      }
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("Annotation_AsyncOperations")]
    public IEnumerable<AsyncOperation> Annotation_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (Annotation_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Annotation_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (Annotation_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Annotation_AsyncOperations));
      }
    }

    [RelationshipSchemaName("Annotation_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> Annotation_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (Annotation_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Annotation_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (Annotation_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Annotation_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("Annotation_ProcessSessions")]
    public IEnumerable<ProcessSession> Annotation_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (Annotation_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Annotation_ProcessSessions));
        this.SetRelatedEntities<ProcessSession>(nameof (Annotation_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Annotation_ProcessSessions));
      }
    }

    [RelationshipSchemaName("Annotation_SyncErrors")]
    public IEnumerable<SyncError> Annotation_SyncErrors
    {
      get => this.GetRelatedEntities<SyncError>(nameof (Annotation_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Annotation_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (Annotation_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Annotation_SyncErrors));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_annotation")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_annotation
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_annotation), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_annotation));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_annotation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_annotation));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("Account_Annotation")]
    public Account Account_Annotation
    {
      get => this.GetRelatedEntity<Account>(nameof (Account_Annotation), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Account_Annotation));
        this.SetRelatedEntity<Account>(nameof (Account_Annotation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Account_Annotation));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_accountingcode_Annotations")]
    public ait_accountingcode ait_accountingcode_Annotations
    {
      get
      {
        return this.GetRelatedEntity<ait_accountingcode>(nameof (ait_accountingcode_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_accountingcode_Annotations));
        this.SetRelatedEntity<ait_accountingcode>(nameof (ait_accountingcode_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_accountingcode_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_assessment_Annotations")]
    public ait_assessment ait_assessment_Annotations
    {
      get
      {
        return this.GetRelatedEntity<ait_assessment>(nameof (ait_assessment_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_assessment_Annotations));
        this.SetRelatedEntity<ait_assessment>(nameof (ait_assessment_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_assessment_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_bankaccount_Annotations")]
    public ait_bankaccount ait_bankaccount_Annotations
    {
      get
      {
        return this.GetRelatedEntity<ait_bankaccount>(nameof (ait_bankaccount_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_bankaccount_Annotations));
        this.SetRelatedEntity<ait_bankaccount>(nameof (ait_bankaccount_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_bankaccount_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_birthrecord_Annotations")]
    public ait_birthrecord ait_birthrecord_Annotations
    {
      get
      {
        return this.GetRelatedEntity<ait_birthrecord>(nameof (ait_birthrecord_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_birthrecord_Annotations));
        this.SetRelatedEntity<ait_birthrecord>(nameof (ait_birthrecord_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_birthrecord_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_bloodquantum_Annotations")]
    public ait_bloodquantum ait_bloodquantum_Annotations
    {
      get
      {
        return this.GetRelatedEntity<ait_bloodquantum>(nameof (ait_bloodquantum_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_bloodquantum_Annotations));
        this.SetRelatedEntity<ait_bloodquantum>(nameof (ait_bloodquantum_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_bloodquantum_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_case_Annotations")]
    public ait_case ait_case_Annotations
    {
      get => this.GetRelatedEntity<ait_case>(nameof (ait_case_Annotations), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_case_Annotations));
        this.SetRelatedEntity<ait_case>(nameof (ait_case_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_case_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_casenote_Annotations")]
    public ait_casenote ait_casenote_Annotations
    {
      get
      {
        return this.GetRelatedEntity<ait_casenote>(nameof (ait_casenote_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_casenote_Annotations));
        this.SetRelatedEntity<ait_casenote>(nameof (ait_casenote_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_casenote_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_caseplan_Annotations")]
    public ait_caseplan ait_caseplan_Annotations
    {
      get
      {
        return this.GetRelatedEntity<ait_caseplan>(nameof (ait_caseplan_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_caseplan_Annotations));
        this.SetRelatedEntity<ait_caseplan>(nameof (ait_caseplan_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_caseplan_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_changerequest_Annotations")]
    public ait_changerequest ait_changerequest_Annotations
    {
      get
      {
        return this.GetRelatedEntity<ait_changerequest>(nameof (ait_changerequest_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_changerequest_Annotations));
        this.SetRelatedEntity<ait_changerequest>(nameof (ait_changerequest_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_changerequest_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_clientprofile_Annotations")]
    public ait_clientprofile ait_clientprofile_Annotations
    {
      get
      {
        return this.GetRelatedEntity<ait_clientprofile>(nameof (ait_clientprofile_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_Annotations));
        this.SetRelatedEntity<ait_clientprofile>(nameof (ait_clientprofile_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_committee_Annotations")]
    public ait_committee ait_committee_Annotations
    {
      get
      {
        return this.GetRelatedEntity<ait_committee>(nameof (ait_committee_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_committee_Annotations));
        this.SetRelatedEntity<ait_committee>(nameof (ait_committee_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_committee_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_committeemeeting_Annotations")]
    public ait_committeemeeting ait_committeemeeting_Annotations
    {
      get
      {
        return this.GetRelatedEntity<ait_committeemeeting>(nameof (ait_committeemeeting_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_committeemeeting_Annotations));
        this.SetRelatedEntity<ait_committeemeeting>(nameof (ait_committeemeeting_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_committeemeeting_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_committeeposition_Annotations")]
    public ait_committeeposition ait_committeeposition_Annotations
    {
      get
      {
        return this.GetRelatedEntity<ait_committeeposition>(nameof (ait_committeeposition_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_committeeposition_Annotations));
        this.SetRelatedEntity<ait_committeeposition>(nameof (ait_committeeposition_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_committeeposition_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_company_Annotations")]
    public ait_company ait_company_Annotations
    {
      get
      {
        return this.GetRelatedEntity<ait_company>(nameof (ait_company_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_company_Annotations));
        this.SetRelatedEntity<ait_company>(nameof (ait_company_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_company_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_contactcertification_Annotations")]
    public ait_contactcertification ait_contactcertification_Annotations
    {
      get
      {
        return this.GetRelatedEntity<ait_contactcertification>(nameof (ait_contactcertification_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactcertification_Annotations));
        this.SetRelatedEntity<ait_contactcertification>(nameof (ait_contactcertification_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactcertification_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_contacteducation_Annotations")]
    public ait_contacteducation ait_contacteducation_Annotations
    {
      get
      {
        return this.GetRelatedEntity<ait_contacteducation>(nameof (ait_contacteducation_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contacteducation_Annotations));
        this.SetRelatedEntity<ait_contacteducation>(nameof (ait_contacteducation_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contacteducation_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_contactemployment_Annotations")]
    public ait_contactemployment ait_contactemployment_Annotations
    {
      get
      {
        return this.GetRelatedEntity<ait_contactemployment>(nameof (ait_contactemployment_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactemployment_Annotations));
        this.SetRelatedEntity<ait_contactemployment>(nameof (ait_contactemployment_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactemployment_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_contactincarceration_Annotations")]
    public ait_contactincarceration ait_contactincarceration_Annotations
    {
      get
      {
        return this.GetRelatedEntity<ait_contactincarceration>(nameof (ait_contactincarceration_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactincarceration_Annotations));
        this.SetRelatedEntity<ait_contactincarceration>(nameof (ait_contactincarceration_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactincarceration_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_contactincomeandexpense_Annotations")]
    public ait_contactincomeandexpense ait_contactincomeandexpense_Annotations
    {
      get
      {
        return this.GetRelatedEntity<ait_contactincomeandexpense>(nameof (ait_contactincomeandexpense_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactincomeandexpense_Annotations));
        this.SetRelatedEntity<ait_contactincomeandexpense>(nameof (ait_contactincomeandexpense_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactincomeandexpense_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_contactmilitaryservice_Annotations")]
    public ait_contactmilitaryservice ait_contactmilitaryservice_Annotations
    {
      get
      {
        return this.GetRelatedEntity<ait_contactmilitaryservice>(nameof (ait_contactmilitaryservice_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactmilitaryservice_Annotations));
        this.SetRelatedEntity<ait_contactmilitaryservice>(nameof (ait_contactmilitaryservice_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactmilitaryservice_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_contactname_Annotations")]
    public ait_contactname ait_contactname_Annotations
    {
      get
      {
        return this.GetRelatedEntity<ait_contactname>(nameof (ait_contactname_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactname_Annotations));
        this.SetRelatedEntity<ait_contactname>(nameof (ait_contactname_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactname_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_contactskill_Annotations")]
    public ait_contactskill ait_contactskill_Annotations
    {
      get
      {
        return this.GetRelatedEntity<ait_contactskill>(nameof (ait_contactskill_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactskill_Annotations));
        this.SetRelatedEntity<ait_contactskill>(nameof (ait_contactskill_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactskill_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_courtcase_Annotations")]
    public ait_courtcase ait_courtcase_Annotations
    {
      get
      {
        return this.GetRelatedEntity<ait_courtcase>(nameof (ait_courtcase_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtcase_Annotations));
        this.SetRelatedEntity<ait_courtcase>(nameof (ait_courtcase_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtcase_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_courtfinesandfees_Annotations")]
    public ait_courtfinesandfees ait_courtfinesandfees_Annotations
    {
      get
      {
        return this.GetRelatedEntity<ait_courtfinesandfees>(nameof (ait_courtfinesandfees_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtfinesandfees_Annotations));
        this.SetRelatedEntity<ait_courtfinesandfees>(nameof (ait_courtfinesandfees_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtfinesandfees_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_courtprofile_Annotations")]
    public ait_courtprofile ait_courtprofile_Annotations
    {
      get
      {
        return this.GetRelatedEntity<ait_courtprofile>(nameof (ait_courtprofile_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtprofile_Annotations));
        this.SetRelatedEntity<ait_courtprofile>(nameof (ait_courtprofile_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtprofile_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_deathrecord_Annotations")]
    public ait_deathrecord ait_deathrecord_Annotations
    {
      get
      {
        return this.GetRelatedEntity<ait_deathrecord>(nameof (ait_deathrecord_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_deathrecord_Annotations));
        this.SetRelatedEntity<ait_deathrecord>(nameof (ait_deathrecord_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_deathrecord_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_electronicaddress_Annotations")]
    public ait_electronicaddress ait_electronicaddress_Annotations
    {
      get
      {
        return this.GetRelatedEntity<ait_electronicaddress>(nameof (ait_electronicaddress_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_electronicaddress_Annotations));
        this.SetRelatedEntity<ait_electronicaddress>(nameof (ait_electronicaddress_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_electronicaddress_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_emergencycontact_Annotations")]
    public ait_emergencycontact ait_emergencycontact_Annotations
    {
      get
      {
        return this.GetRelatedEntity<ait_emergencycontact>(nameof (ait_emergencycontact_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_emergencycontact_Annotations));
        this.SetRelatedEntity<ait_emergencycontact>(nameof (ait_emergencycontact_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_emergencycontact_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_familygroup_Annotations")]
    public ait_familygroup ait_familygroup_Annotations
    {
      get
      {
        return this.GetRelatedEntity<ait_familygroup>(nameof (ait_familygroup_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familygroup_Annotations));
        this.SetRelatedEntity<ait_familygroup>(nameof (ait_familygroup_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familygroup_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_goal_Annotations")]
    public ait_goal ait_goal_Annotations
    {
      get => this.GetRelatedEntity<ait_goal>(nameof (ait_goal_Annotations), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_goal_Annotations));
        this.SetRelatedEntity<ait_goal>(nameof (ait_goal_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_goal_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_groupactivity_Annotations")]
    public ait_groupactivity ait_groupactivity_Annotations
    {
      get
      {
        return this.GetRelatedEntity<ait_groupactivity>(nameof (ait_groupactivity_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_groupactivity_Annotations));
        this.SetRelatedEntity<ait_groupactivity>(nameof (ait_groupactivity_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_groupactivity_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_household_Annotations")]
    public ait_household ait_household_Annotations
    {
      get
      {
        return this.GetRelatedEntity<ait_household>(nameof (ait_household_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_household_Annotations));
        this.SetRelatedEntity<ait_household>(nameof (ait_household_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_household_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_householdmember_Annotations")]
    public ait_householdmember ait_householdmember_Annotations
    {
      get
      {
        return this.GetRelatedEntity<ait_householdmember>(nameof (ait_householdmember_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_householdmember_Annotations));
        this.SetRelatedEntity<ait_householdmember>(nameof (ait_householdmember_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_householdmember_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_icwaadoption_Annotations")]
    public ait_icwaadoption ait_icwaadoption_Annotations
    {
      get
      {
        return this.GetRelatedEntity<ait_icwaadoption>(nameof (ait_icwaadoption_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaadoption_Annotations));
        this.SetRelatedEntity<ait_icwaadoption>(nameof (ait_icwaadoption_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaadoption_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_icwanotice_Annotations")]
    public ait_icwanotice ait_icwanotice_Annotations
    {
      get
      {
        return this.GetRelatedEntity<ait_icwanotice>(nameof (ait_icwanotice_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwanotice_Annotations));
        this.SetRelatedEntity<ait_icwanotice>(nameof (ait_icwanotice_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwanotice_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_incident_Annotations")]
    public ait_incident ait_incident_Annotations
    {
      get
      {
        return this.GetRelatedEntity<ait_incident>(nameof (ait_incident_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incident_Annotations));
        this.SetRelatedEntity<ait_incident>(nameof (ait_incident_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incident_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_investigation_Annotations")]
    public ait_investigation ait_investigation_Annotations
    {
      get
      {
        return this.GetRelatedEntity<ait_investigation>(nameof (ait_investigation_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_investigation_Annotations));
        this.SetRelatedEntity<ait_investigation>(nameof (ait_investigation_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_investigation_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_memberprofile_Annotations")]
    public ait_memberprofile ait_memberprofile_Annotations
    {
      get
      {
        return this.GetRelatedEntity<ait_memberprofile>(nameof (ait_memberprofile_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_memberprofile_Annotations));
        this.SetRelatedEntity<ait_memberprofile>(nameof (ait_memberprofile_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_memberprofile_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_memberroll_Annotations")]
    public ait_memberroll ait_memberroll_Annotations
    {
      get
      {
        return this.GetRelatedEntity<ait_memberroll>(nameof (ait_memberroll_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_memberroll_Annotations));
        this.SetRelatedEntity<ait_memberroll>(nameof (ait_memberroll_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_memberroll_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_membershipstatuschangerequest_Annotations")]
    public ait_membershipstatuschangerequest ait_membershipstatuschangerequest_Annotations
    {
      get
      {
        return this.GetRelatedEntity<ait_membershipstatuschangerequest>(nameof (ait_membershipstatuschangerequest_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_membershipstatuschangerequest_Annotations));
        this.SetRelatedEntity<ait_membershipstatuschangerequest>(nameof (ait_membershipstatuschangerequest_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_membershipstatuschangerequest_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_outcome_Annotations")]
    public ait_outcome ait_outcome_Annotations
    {
      get
      {
        return this.GetRelatedEntity<ait_outcome>(nameof (ait_outcome_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_outcome_Annotations));
        this.SetRelatedEntity<ait_outcome>(nameof (ait_outcome_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_outcome_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_payment_Annotations")]
    public ait_payment ait_payment_Annotations
    {
      get
      {
        return this.GetRelatedEntity<ait_payment>(nameof (ait_payment_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_payment_Annotations));
        this.SetRelatedEntity<ait_payment>(nameof (ait_payment_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_payment_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_physicaladdress_Annotations")]
    public ait_physicaladdress ait_physicaladdress_Annotations
    {
      get
      {
        return this.GetRelatedEntity<ait_physicaladdress>(nameof (ait_physicaladdress_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_physicaladdress_Annotations));
        this.SetRelatedEntity<ait_physicaladdress>(nameof (ait_physicaladdress_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_physicaladdress_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_planactivity_Annotations")]
    public ait_planactivity ait_planactivity_Annotations
    {
      get
      {
        return this.GetRelatedEntity<ait_planactivity>(nameof (ait_planactivity_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_planactivity_Annotations));
        this.SetRelatedEntity<ait_planactivity>(nameof (ait_planactivity_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_planactivity_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_pmteligibility_Annotations")]
    public ait_pmteligibility ait_pmteligibility_Annotations
    {
      get
      {
        return this.GetRelatedEntity<ait_pmteligibility>(nameof (ait_pmteligibility_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmteligibility_Annotations));
        this.SetRelatedEntity<ait_pmteligibility>(nameof (ait_pmteligibility_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmteligibility_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_pmtevent_Annotations")]
    public ait_pmtevent ait_pmtevent_Annotations
    {
      get
      {
        return this.GetRelatedEntity<ait_pmtevent>(nameof (ait_pmtevent_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtevent_Annotations));
        this.SetRelatedEntity<ait_pmtevent>(nameof (ait_pmtevent_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtevent_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_pmtpaymenttype_Annotations")]
    public ait_pmtpaymenttype ait_pmtpaymenttype_Annotations
    {
      get
      {
        return this.GetRelatedEntity<ait_pmtpaymenttype>(nameof (ait_pmtpaymenttype_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtpaymenttype_Annotations));
        this.SetRelatedEntity<ait_pmtpaymenttype>(nameof (ait_pmtpaymenttype_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtpaymenttype_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_pmttransaction_Annotations")]
    public ait_pmttransaction ait_pmttransaction_Annotations
    {
      get
      {
        return this.GetRelatedEntity<ait_pmttransaction>(nameof (ait_pmttransaction_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmttransaction_Annotations));
        this.SetRelatedEntity<ait_pmttransaction>(nameof (ait_pmttransaction_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmttransaction_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_pmttransactiondeduction_Annotations")]
    public ait_pmttransactiondeduction ait_pmttransactiondeduction_Annotations
    {
      get
      {
        return this.GetRelatedEntity<ait_pmttransactiondeduction>(nameof (ait_pmttransactiondeduction_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmttransactiondeduction_Annotations));
        this.SetRelatedEntity<ait_pmttransactiondeduction>(nameof (ait_pmttransactiondeduction_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmttransactiondeduction_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_pmtwithholding_Annotations")]
    public ait_pmtwithholding ait_pmtwithholding_Annotations
    {
      get
      {
        return this.GetRelatedEntity<ait_pmtwithholding>(nameof (ait_pmtwithholding_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtwithholding_Annotations));
        this.SetRelatedEntity<ait_pmtwithholding>(nameof (ait_pmtwithholding_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtwithholding_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_pmtwithholdingoverride_Annotations")]
    public ait_pmtwithholdingoverride ait_pmtwithholdingoverride_Annotations
    {
      get
      {
        return this.GetRelatedEntity<ait_pmtwithholdingoverride>(nameof (ait_pmtwithholdingoverride_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtwithholdingoverride_Annotations));
        this.SetRelatedEntity<ait_pmtwithholdingoverride>(nameof (ait_pmtwithholdingoverride_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtwithholdingoverride_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_program_Annotations")]
    public ait_program ait_program_Annotations
    {
      get
      {
        return this.GetRelatedEntity<ait_program>(nameof (ait_program_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_program_Annotations));
        this.SetRelatedEntity<ait_program>(nameof (ait_program_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_program_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_referral_Annotations")]
    public ait_referral ait_referral_Annotations
    {
      get
      {
        return this.GetRelatedEntity<ait_referral>(nameof (ait_referral_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_referral_Annotations));
        this.SetRelatedEntity<ait_referral>(nameof (ait_referral_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_referral_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_relationship_Annotations")]
    public ait_relationship ait_relationship_Annotations
    {
      get
      {
        return this.GetRelatedEntity<ait_relationship>(nameof (ait_relationship_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_relationship_Annotations));
        this.SetRelatedEntity<ait_relationship>(nameof (ait_relationship_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_relationship_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_school_Annotations")]
    public ait_school ait_school_Annotations
    {
      get => this.GetRelatedEntity<ait_school>(nameof (ait_school_Annotations), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_school_Annotations));
        this.SetRelatedEntity<ait_school>(nameof (ait_school_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_school_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_servicerequest_Annotations")]
    public ait_servicerequest ait_servicerequest_Annotations
    {
      get
      {
        return this.GetRelatedEntity<ait_servicerequest>(nameof (ait_servicerequest_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_Annotations));
        this.SetRelatedEntity<ait_servicerequest>(nameof (ait_servicerequest_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_Annotations));
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("annotation_owning_user")]
    public SystemUser annotation_owning_user
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (annotation_owning_user), new EntityRole?());
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("Appointment_Annotation")]
    public Appointment Appointment_Annotation
    {
      get => this.GetRelatedEntity<Appointment>(nameof (Appointment_Annotation), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Appointment_Annotation));
        this.SetRelatedEntity<Appointment>(nameof (Appointment_Annotation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Appointment_Annotation));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_annotations")]
    public BusinessUnit business_unit_annotations
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_annotations), new EntityRole?());
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("Calendar_Annotation")]
    public Calendar Calendar_Annotation
    {
      get => this.GetRelatedEntity<Calendar>(nameof (Calendar_Annotation), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Calendar_Annotation));
        this.SetRelatedEntity<Calendar>(nameof (Calendar_Annotation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Calendar_Annotation));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("channelaccessprofile_Annotations")]
    public ChannelAccessProfile channelaccessprofile_Annotations
    {
      get
      {
        return this.GetRelatedEntity<ChannelAccessProfile>(nameof (channelaccessprofile_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (channelaccessprofile_Annotations));
        this.SetRelatedEntity<ChannelAccessProfile>(nameof (channelaccessprofile_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (channelaccessprofile_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("Contact_Annotation")]
    public Contact Contact_Annotation
    {
      get => this.GetRelatedEntity<Contact>(nameof (Contact_Annotation), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Contact_Annotation));
        this.SetRelatedEntity<Contact>(nameof (Contact_Annotation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Contact_Annotation));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ConvertRule_Annotation")]
    public ConvertRule ConvertRule_Annotation
    {
      get => this.GetRelatedEntity<ConvertRule>(nameof (ConvertRule_Annotation), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ConvertRule_Annotation));
        this.SetRelatedEntity<ConvertRule>(nameof (ConvertRule_Annotation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ConvertRule_Annotation));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("DuplicateRule_Annotation")]
    public DuplicateRule DuplicateRule_Annotation
    {
      get
      {
        return this.GetRelatedEntity<DuplicateRule>(nameof (DuplicateRule_Annotation), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (DuplicateRule_Annotation));
        this.SetRelatedEntity<DuplicateRule>(nameof (DuplicateRule_Annotation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (DuplicateRule_Annotation));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("Email_Annotation")]
    public Email Email_Annotation
    {
      get => this.GetRelatedEntity<Email>(nameof (Email_Annotation), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Email_Annotation));
        this.SetRelatedEntity<Email>(nameof (Email_Annotation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Email_Annotation));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("EmailServerProfile_Annotation")]
    public EmailServerProfile EmailServerProfile_Annotation
    {
      get
      {
        return this.GetRelatedEntity<EmailServerProfile>(nameof (EmailServerProfile_Annotation), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (EmailServerProfile_Annotation));
        this.SetRelatedEntity<EmailServerProfile>(nameof (EmailServerProfile_Annotation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (EmailServerProfile_Annotation));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("Fax_Annotation")]
    public Fax Fax_Annotation
    {
      get => this.GetRelatedEntity<Fax>(nameof (Fax_Annotation), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Fax_Annotation));
        this.SetRelatedEntity<Fax>(nameof (Fax_Annotation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Fax_Annotation));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("Goal_Annotation")]
    public Goal Goal_Annotation
    {
      get => this.GetRelatedEntity<Goal>(nameof (Goal_Annotation), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Goal_Annotation));
        this.SetRelatedEntity<Goal>(nameof (Goal_Annotation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Goal_Annotation));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("KbArticle_Annotation")]
    public KbArticle KbArticle_Annotation
    {
      get => this.GetRelatedEntity<KbArticle>(nameof (KbArticle_Annotation), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (KbArticle_Annotation));
        this.SetRelatedEntity<KbArticle>(nameof (KbArticle_Annotation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KbArticle_Annotation));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("knowledgearticle_Annotations")]
    public KnowledgeArticle knowledgearticle_Annotations
    {
      get
      {
        return this.GetRelatedEntity<KnowledgeArticle>(nameof (knowledgearticle_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (knowledgearticle_Annotations));
        this.SetRelatedEntity<KnowledgeArticle>(nameof (knowledgearticle_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (knowledgearticle_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("KnowledgeBaseRecord_Annotations")]
    public KnowledgeBaseRecord KnowledgeBaseRecord_Annotations
    {
      get
      {
        return this.GetRelatedEntity<KnowledgeBaseRecord>(nameof (KnowledgeBaseRecord_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeBaseRecord_Annotations));
        this.SetRelatedEntity<KnowledgeBaseRecord>(nameof (KnowledgeBaseRecord_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeBaseRecord_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("Letter_Annotation")]
    public Letter Letter_Annotation
    {
      get => this.GetRelatedEntity<Letter>(nameof (Letter_Annotation), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Letter_Annotation));
        this.SetRelatedEntity<Letter>(nameof (Letter_Annotation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Letter_Annotation));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_annotationbase_createdby")]
    public SystemUser lk_annotationbase_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_annotationbase_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_annotationbase_createdonbehalfby")]
    public SystemUser lk_annotationbase_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_annotationbase_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_annotationbase_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_annotationbase_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_annotationbase_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_annotationbase_modifiedby")]
    public SystemUser lk_annotationbase_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_annotationbase_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_annotationbase_modifiedonbehalfby")]
    public SystemUser lk_annotationbase_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_annotationbase_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_annotationbase_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_annotationbase_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_annotationbase_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("Mailbox_Annotation")]
    public Mailbox Mailbox_Annotation
    {
      get => this.GetRelatedEntity<Mailbox>(nameof (Mailbox_Annotation), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Mailbox_Annotation));
        this.SetRelatedEntity<Mailbox>(nameof (Mailbox_Annotation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Mailbox_Annotation));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_aifptrainingdocument_Annotations")]
    public msdyn_AIFpTrainingDocument msdyn_aifptrainingdocument_Annotations
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIFpTrainingDocument>(nameof (msdyn_aifptrainingdocument_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aifptrainingdocument_Annotations));
        this.SetRelatedEntity<msdyn_AIFpTrainingDocument>(nameof (msdyn_aifptrainingdocument_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aifptrainingdocument_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_aimodel_Annotations")]
    public msdyn_AIModel msdyn_aimodel_Annotations
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIModel>(nameof (msdyn_aimodel_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aimodel_Annotations));
        this.SetRelatedEntity<msdyn_AIModel>(nameof (msdyn_aimodel_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aimodel_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_aiodimage_Annotations")]
    public msdyn_AIOdImage msdyn_aiodimage_Annotations
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIOdImage>(nameof (msdyn_aiodimage_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodimage_Annotations));
        this.SetRelatedEntity<msdyn_AIOdImage>(nameof (msdyn_aiodimage_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodimage_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_solutioncomponentdatasource_Annotations")]
    public msdyn_solutioncomponentdatasource msdyn_solutioncomponentdatasource_Annotations
    {
      get
      {
        return this.GetRelatedEntity<msdyn_solutioncomponentdatasource>(nameof (msdyn_solutioncomponentdatasource_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutioncomponentdatasource_Annotations));
        this.SetRelatedEntity<msdyn_solutioncomponentdatasource>(nameof (msdyn_solutioncomponentdatasource_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_solutioncomponentdatasource_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_solutionhistorydatasource_Annotations")]
    public msdyn_solutionhistorydatasource msdyn_solutionhistorydatasource_Annotations
    {
      get
      {
        return this.GetRelatedEntity<msdyn_solutionhistorydatasource>(nameof (msdyn_solutionhistorydatasource_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutionhistorydatasource_Annotations));
        this.SetRelatedEntity<msdyn_solutionhistorydatasource>(nameof (msdyn_solutionhistorydatasource_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_solutionhistorydatasource_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("PhoneCall_Annotation")]
    public PhoneCall PhoneCall_Annotation
    {
      get => this.GetRelatedEntity<PhoneCall>(nameof (PhoneCall_Annotation), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (PhoneCall_Annotation));
        this.SetRelatedEntity<PhoneCall>(nameof (PhoneCall_Annotation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (PhoneCall_Annotation));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("profilerule_Annotations")]
    public ChannelAccessProfileRule profilerule_Annotations
    {
      get
      {
        return this.GetRelatedEntity<ChannelAccessProfileRule>(nameof (profilerule_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (profilerule_Annotations));
        this.SetRelatedEntity<ChannelAccessProfileRule>(nameof (profilerule_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (profilerule_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("profileruleitem_Annotations")]
    public ChannelAccessProfileRuleItem profileruleitem_Annotations
    {
      get
      {
        return this.GetRelatedEntity<ChannelAccessProfileRuleItem>(nameof (profileruleitem_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (profileruleitem_Annotations));
        this.SetRelatedEntity<ChannelAccessProfileRuleItem>(nameof (profileruleitem_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (profileruleitem_Annotations));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("RecurringAppointmentMaster_Annotation")]
    public RecurringAppointmentMaster RecurringAppointmentMaster_Annotation
    {
      get
      {
        return this.GetRelatedEntity<RecurringAppointmentMaster>(nameof (RecurringAppointmentMaster_Annotation), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (RecurringAppointmentMaster_Annotation));
        this.SetRelatedEntity<RecurringAppointmentMaster>(nameof (RecurringAppointmentMaster_Annotation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (RecurringAppointmentMaster_Annotation));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("routingrule_Annotation")]
    public RoutingRule routingrule_Annotation
    {
      get => this.GetRelatedEntity<RoutingRule>(nameof (routingrule_Annotation), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (routingrule_Annotation));
        this.SetRelatedEntity<RoutingRule>(nameof (routingrule_Annotation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (routingrule_Annotation));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("routingruleitem_Annotation")]
    public RoutingRuleItem routingruleitem_Annotation
    {
      get
      {
        return this.GetRelatedEntity<RoutingRuleItem>(nameof (routingruleitem_Annotation), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (routingruleitem_Annotation));
        this.SetRelatedEntity<RoutingRuleItem>(nameof (routingruleitem_Annotation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (routingruleitem_Annotation));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("SharePointDocument_Annotation")]
    public SharePointDocument SharePointDocument_Annotation
    {
      get
      {
        return this.GetRelatedEntity<SharePointDocument>(nameof (SharePointDocument_Annotation), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SharePointDocument_Annotation));
        this.SetRelatedEntity<SharePointDocument>(nameof (SharePointDocument_Annotation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SharePointDocument_Annotation));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("sla_Annotation")]
    public SLA sla_Annotation
    {
      get => this.GetRelatedEntity<SLA>(nameof (sla_Annotation), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (sla_Annotation));
        this.SetRelatedEntity<SLA>(nameof (sla_Annotation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (sla_Annotation));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("SocialActivity_Annotation")]
    public SocialActivity SocialActivity_Annotation
    {
      get
      {
        return this.GetRelatedEntity<SocialActivity>(nameof (SocialActivity_Annotation), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SocialActivity_Annotation));
        this.SetRelatedEntity<SocialActivity>(nameof (SocialActivity_Annotation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SocialActivity_Annotation));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("Task_Annotation")]
    public Task Task_Annotation
    {
      get => this.GetRelatedEntity<Task>(nameof (Task_Annotation), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Task_Annotation));
        this.SetRelatedEntity<Task>(nameof (Task_Annotation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Task_Annotation));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_annotations")]
    public Team team_annotations
    {
      get => this.GetRelatedEntity<Team>(nameof (team_annotations), new EntityRole?());
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("Workflow_Annotation")]
    public Workflow Workflow_Annotation
    {
      get => this.GetRelatedEntity<Workflow>(nameof (Workflow_Annotation), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Workflow_Annotation));
        this.SetRelatedEntity<Workflow>(nameof (Workflow_Annotation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Workflow_Annotation));
      }
    }

    public Annotation(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["annotationid"] = (object) base.Id;
            break;
          case "annotationid":
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
