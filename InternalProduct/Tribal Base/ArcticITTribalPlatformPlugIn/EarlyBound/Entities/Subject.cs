// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.Subject
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("subject")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class Subject : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "subject";
    public const string EntitySchemaName = "Subject";
    public const string PrimaryIdAttribute = "subjectid";
    public const string PrimaryNameAttribute = "title";

    public Subject()
      : base("subject")
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

    [AttributeLogicalName("createdby")]
    public EntityReference CreatedBy => this.GetAttributeValue<EntityReference>("createdby");

    [AttributeLogicalName("createdbyexternalparty")]
    public EntityReference CreatedByExternalParty
    {
      get => this.GetAttributeValue<EntityReference>("createdbyexternalparty");
    }

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

    [AttributeLogicalName("description")]
    public string Description
    {
      get => this.GetAttributeValue<string>("description");
      set
      {
        this.OnPropertyChanging(nameof (Description));
        this.SetAttributeValue("description", (object) value);
        this.OnPropertyChanged(nameof (Description));
      }
    }

    [AttributeLogicalName("featuremask")]
    public int? FeatureMask
    {
      get => this.GetAttributeValue<int?>("featuremask");
      set
      {
        this.OnPropertyChanging(nameof (FeatureMask));
        this.SetAttributeValue("featuremask", (object) value);
        this.OnPropertyChanged(nameof (FeatureMask));
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

    [AttributeLogicalName("modifiedbyexternalparty")]
    public EntityReference ModifiedByExternalParty
    {
      get => this.GetAttributeValue<EntityReference>("modifiedbyexternalparty");
    }

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

    [AttributeLogicalName("parentsubject")]
    public EntityReference ParentSubject
    {
      get => this.GetAttributeValue<EntityReference>("parentsubject");
      set
      {
        this.OnPropertyChanging(nameof (ParentSubject));
        this.SetAttributeValue("parentsubject", (object) value);
        this.OnPropertyChanged(nameof (ParentSubject));
      }
    }

    [AttributeLogicalName("subjectid")]
    public Guid? SubjectId
    {
      get => this.GetAttributeValue<Guid?>("subjectid");
      set
      {
        this.OnPropertyChanging(nameof (SubjectId));
        this.SetAttributeValue("subjectid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (SubjectId));
      }
    }

    [AttributeLogicalName("subjectid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.SubjectId = new Guid?(value);
    }

    [AttributeLogicalName("title")]
    public string Title
    {
      get => this.GetAttributeValue<string>("title");
      set
      {
        this.OnPropertyChanging(nameof (Title));
        this.SetAttributeValue("title", (object) value);
        this.OnPropertyChanged(nameof (Title));
      }
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("is_primary_subject_for")]
    public IEnumerable<DocumentIndex> is_primary_subject_for
    {
      get
      {
        return this.GetRelatedEntities<DocumentIndex>(nameof (is_primary_subject_for), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (is_primary_subject_for));
        this.SetRelatedEntities<DocumentIndex>(nameof (is_primary_subject_for), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (is_primary_subject_for));
      }
    }

    [RelationshipSchemaName("msdyn_subject_knowledgearticletemplate_subjectid")]
    public IEnumerable<msdyn_knowledgearticletemplate> msdyn_subject_knowledgearticletemplate_subjectid
    {
      get
      {
        return this.GetRelatedEntities<msdyn_knowledgearticletemplate>(nameof (msdyn_subject_knowledgearticletemplate_subjectid), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_subject_knowledgearticletemplate_subjectid));
        this.SetRelatedEntities<msdyn_knowledgearticletemplate>(nameof (msdyn_subject_knowledgearticletemplate_subjectid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_subject_knowledgearticletemplate_subjectid));
      }
    }

    [RelationshipSchemaName("Subject_AsyncOperations")]
    public IEnumerable<AsyncOperation> Subject_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (Subject_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Subject_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (Subject_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Subject_AsyncOperations));
      }
    }

    [RelationshipSchemaName("Subject_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> Subject_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (Subject_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Subject_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (Subject_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Subject_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("subject_kb_articles")]
    public IEnumerable<KbArticle> subject_kb_articles
    {
      get => this.GetRelatedEntities<KbArticle>(nameof (subject_kb_articles), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (subject_kb_articles));
        this.SetRelatedEntities<KbArticle>(nameof (subject_kb_articles), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (subject_kb_articles));
      }
    }

    [RelationshipSchemaName("subject_knowledgearticles")]
    public IEnumerable<KnowledgeArticle> subject_knowledgearticles
    {
      get
      {
        return this.GetRelatedEntities<KnowledgeArticle>(nameof (subject_knowledgearticles), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (subject_knowledgearticles));
        this.SetRelatedEntities<KnowledgeArticle>(nameof (subject_knowledgearticles), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (subject_knowledgearticles));
      }
    }

    [RelationshipSchemaName]
    public IEnumerable<Subject> Referencedsubject_parent_subject
    {
      get
      {
        return this.GetRelatedEntities<Subject>("subject_parent_subject", new EntityRole?((EntityRole) 1));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencedsubject_parent_subject));
        this.SetRelatedEntities<Subject>("subject_parent_subject", new EntityRole?((EntityRole) 1), value);
        this.OnPropertyChanged(nameof (Referencedsubject_parent_subject));
      }
    }

    [RelationshipSchemaName("Subject_ProcessSessions")]
    public IEnumerable<ProcessSession> Subject_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (Subject_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Subject_ProcessSessions));
        this.SetRelatedEntities<ProcessSession>(nameof (Subject_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Subject_ProcessSessions));
      }
    }

    [RelationshipSchemaName("Subject_SyncErrors")]
    public IEnumerable<SyncError> Subject_SyncErrors
    {
      get => this.GetRelatedEntities<SyncError>(nameof (Subject_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Subject_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (Subject_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Subject_SyncErrors));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_subject")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_subject
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_subject), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_subject));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_subject), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_subject));
      }
    }

    [AttributeLogicalName("createdbyexternalparty")]
    [RelationshipSchemaName("lk_externalparty_subject_createdby")]
    public ExternalParty lk_externalparty_subject_createdby
    {
      get
      {
        return this.GetRelatedEntity<ExternalParty>(nameof (lk_externalparty_subject_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedbyexternalparty")]
    [RelationshipSchemaName("lk_externalparty_subject_modifiedby")]
    public ExternalParty lk_externalparty_subject_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<ExternalParty>(nameof (lk_externalparty_subject_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_subject_createdonbehalfby")]
    public SystemUser lk_subject_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_subject_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_subject_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_subject_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_subject_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_subject_modifiedonbehalfby")]
    public SystemUser lk_subject_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_subject_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_subject_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_subject_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_subject_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_subjectbase_createdby")]
    public SystemUser lk_subjectbase_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_subjectbase_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_subjectbase_modifiedby")]
    public SystemUser lk_subjectbase_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_subjectbase_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_subjects")]
    public Organization organization_subjects
    {
      get => this.GetRelatedEntity<Organization>(nameof (organization_subjects), new EntityRole?());
    }

    [AttributeLogicalName("parentsubject")]
    [RelationshipSchemaName]
    public Subject Referencingsubject_parent_subject
    {
      get
      {
        return this.GetRelatedEntity<Subject>("subject_parent_subject", new EntityRole?((EntityRole) 0));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencingsubject_parent_subject));
        this.SetRelatedEntity<Subject>("subject_parent_subject", new EntityRole?((EntityRole) 0), value);
        this.OnPropertyChanged(nameof (Referencingsubject_parent_subject));
      }
    }

    public Subject(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["subjectid"] = (object) base.Id;
            break;
          case "subjectid":
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
