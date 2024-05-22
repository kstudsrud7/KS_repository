// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.Template
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("template")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class Template : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "template";
    public const string EntitySchemaName = "Template";
    public const string PrimaryIdAttribute = "templateid";
    public const string PrimaryNameAttribute = "title";

    public Template()
      : base("template")
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

    [AttributeLogicalName("body")]
    public string Body
    {
      get => this.GetAttributeValue<string>("body");
      set
      {
        this.OnPropertyChanging(nameof (Body));
        this.SetAttributeValue("body", (object) value);
        this.OnPropertyChanged(nameof (Body));
      }
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

    [AttributeLogicalName("generationtypecode")]
    public int? GenerationTypeCode
    {
      get => this.GetAttributeValue<int?>("generationtypecode");
      set
      {
        this.OnPropertyChanging(nameof (GenerationTypeCode));
        this.SetAttributeValue("generationtypecode", (object) value);
        this.OnPropertyChanged(nameof (GenerationTypeCode));
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

    [AttributeLogicalName("iscustomizable")]
    public BooleanManagedProperty IsCustomizable
    {
      get => this.GetAttributeValue<BooleanManagedProperty>("iscustomizable");
      set
      {
        this.OnPropertyChanging(nameof (IsCustomizable));
        this.SetAttributeValue("iscustomizable", (object) value);
        this.OnPropertyChanged(nameof (IsCustomizable));
      }
    }

    [AttributeLogicalName("ismanaged")]
    public bool? IsManaged => this.GetAttributeValue<bool?>("ismanaged");

    [AttributeLogicalName("ispersonal")]
    public bool? IsPersonal
    {
      get => this.GetAttributeValue<bool?>("ispersonal");
      set
      {
        this.OnPropertyChanging(nameof (IsPersonal));
        this.SetAttributeValue("ispersonal", (object) value);
        this.OnPropertyChanged(nameof (IsPersonal));
      }
    }

    [AttributeLogicalName("isrecommended")]
    public bool? IsRecommended => this.GetAttributeValue<bool?>("isrecommended");

    [AttributeLogicalName("languagecode")]
    public int? LanguageCode
    {
      get => this.GetAttributeValue<int?>("languagecode");
      set
      {
        this.OnPropertyChanging(nameof (LanguageCode));
        this.SetAttributeValue("languagecode", (object) value);
        this.OnPropertyChanged(nameof (LanguageCode));
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

    [AttributeLogicalName("opencount")]
    public int? OpenCount => this.GetAttributeValue<int?>("opencount");

    [AttributeLogicalName("openrate")]
    public int? OpenRate => this.GetAttributeValue<int?>("openrate");

    [AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime => this.GetAttributeValue<DateTime?>("overwritetime");

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

    [AttributeLogicalName("presentationxml")]
    public string PresentationXml
    {
      get => this.GetAttributeValue<string>("presentationxml");
      set
      {
        this.OnPropertyChanging(nameof (PresentationXml));
        this.SetAttributeValue("presentationxml", (object) value);
        this.OnPropertyChanged(nameof (PresentationXml));
      }
    }

    [AttributeLogicalName("replycount")]
    public int? ReplyCount => this.GetAttributeValue<int?>("replycount");

    [AttributeLogicalName("replyrate")]
    public int? ReplyRate => this.GetAttributeValue<int?>("replyrate");

    [AttributeLogicalName("safehtml")]
    public string SafeHtml
    {
      get => this.GetAttributeValue<string>("safehtml");
      set
      {
        this.OnPropertyChanging(nameof (SafeHtml));
        this.SetAttributeValue("safehtml", (object) value);
        this.OnPropertyChanged(nameof (SafeHtml));
      }
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

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

    [AttributeLogicalName("subjectpresentationxml")]
    public string SubjectPresentationXml
    {
      get => this.GetAttributeValue<string>("subjectpresentationxml");
      set
      {
        this.OnPropertyChanging(nameof (SubjectPresentationXml));
        this.SetAttributeValue("subjectpresentationxml", (object) value);
        this.OnPropertyChanged(nameof (SubjectPresentationXml));
      }
    }

    [AttributeLogicalName("subjectsafehtml")]
    public string SubjectSafeHtml
    {
      get => this.GetAttributeValue<string>("subjectsafehtml");
      set
      {
        this.OnPropertyChanging(nameof (SubjectSafeHtml));
        this.SetAttributeValue("subjectsafehtml", (object) value);
        this.OnPropertyChanged(nameof (SubjectSafeHtml));
      }
    }

    [AttributeLogicalName("templateid")]
    public Guid? TemplateId
    {
      get => this.GetAttributeValue<Guid?>("templateid");
      set
      {
        this.OnPropertyChanging(nameof (TemplateId));
        this.SetAttributeValue("templateid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (TemplateId));
      }
    }

    [AttributeLogicalName("templateid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.TemplateId = new Guid?(value);
    }

    [AttributeLogicalName("templateidunique")]
    public Guid? TemplateIdUnique => this.GetAttributeValue<Guid?>("templateidunique");

    [AttributeLogicalName("templatetypecode")]
    public string TemplateTypeCode
    {
      get => this.GetAttributeValue<string>("templatetypecode");
      set
      {
        this.OnPropertyChanging(nameof (TemplateTypeCode));
        this.SetAttributeValue("templatetypecode", (object) value);
        this.OnPropertyChanged(nameof (TemplateTypeCode));
      }
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

    [AttributeLogicalName("usedcount")]
    public int? UsedCount => this.GetAttributeValue<int?>("usedcount");

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("Email_EmailTemplate")]
    public IEnumerable<Email> Email_EmailTemplate
    {
      get => this.GetRelatedEntities<Email>(nameof (Email_EmailTemplate), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Email_EmailTemplate));
        this.SetRelatedEntities<Email>(nameof (Email_EmailTemplate), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Email_EmailTemplate));
      }
    }

    [RelationshipSchemaName("emailtemplate_convertrule")]
    public IEnumerable<ConvertRule> emailtemplate_convertrule
    {
      get
      {
        return this.GetRelatedEntities<ConvertRule>(nameof (emailtemplate_convertrule), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (emailtemplate_convertrule));
        this.SetRelatedEntities<ConvertRule>(nameof (emailtemplate_convertrule), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (emailtemplate_convertrule));
      }
    }

    [RelationshipSchemaName("template_activity_mime_attachments")]
    public IEnumerable<ActivityMimeAttachment> template_activity_mime_attachments
    {
      get
      {
        return this.GetRelatedEntities<ActivityMimeAttachment>(nameof (template_activity_mime_attachments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (template_activity_mime_attachments));
        this.SetRelatedEntities<ActivityMimeAttachment>(nameof (template_activity_mime_attachments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (template_activity_mime_attachments));
      }
    }

    [RelationshipSchemaName("Template_AsyncOperations")]
    public IEnumerable<AsyncOperation> Template_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (Template_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Template_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (Template_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Template_AsyncOperations));
      }
    }

    [RelationshipSchemaName("Template_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> Template_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (Template_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Template_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (Template_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Template_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("Template_Organization")]
    public IEnumerable<Organization> Template_Organization
    {
      get
      {
        return this.GetRelatedEntities<Organization>(nameof (Template_Organization), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Template_Organization));
        this.SetRelatedEntities<Organization>(nameof (Template_Organization), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Template_Organization));
      }
    }

    [RelationshipSchemaName("Template_ProcessSessions")]
    public IEnumerable<ProcessSession> Template_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (Template_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Template_ProcessSessions));
        this.SetRelatedEntities<ProcessSession>(nameof (Template_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Template_ProcessSessions));
      }
    }

    [RelationshipSchemaName("Template_SyncErrors")]
    public IEnumerable<SyncError> Template_SyncErrors
    {
      get => this.GetRelatedEntities<SyncError>(nameof (Template_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Template_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (Template_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Template_SyncErrors));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_template")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_template
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_template), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_template));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_template), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_template));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_templates")]
    public BusinessUnit business_unit_templates
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_templates), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_templatebase_createdby")]
    public SystemUser lk_templatebase_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_templatebase_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_templatebase_createdonbehalfby")]
    public SystemUser lk_templatebase_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_templatebase_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_templatebase_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_templatebase_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_templatebase_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_templatebase_modifiedby")]
    public SystemUser lk_templatebase_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_templatebase_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_templatebase_modifiedonbehalfby")]
    public SystemUser lk_templatebase_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_templatebase_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_templatebase_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_templatebase_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_templatebase_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("system_user_email_templates")]
    public SystemUser system_user_email_templates
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (system_user_email_templates), new EntityRole?());
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_email_templates")]
    public Team team_email_templates
    {
      get => this.GetRelatedEntity<Team>(nameof (team_email_templates), new EntityRole?());
    }

    public Template(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["templateid"] = (object) base.Id;
            break;
          case "templateid":
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
