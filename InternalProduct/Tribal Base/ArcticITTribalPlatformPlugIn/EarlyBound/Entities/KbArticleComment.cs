// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.KbArticleComment
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("kbarticlecomment")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class KbArticleComment : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "kbarticlecomment";
    public const string EntitySchemaName = "KbArticleComment";
    public const string PrimaryIdAttribute = "kbarticlecommentid";
    public const string PrimaryNameAttribute = "title";

    public KbArticleComment()
      : base("kbarticlecomment")
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

    [AttributeLogicalName("commenttext")]
    public string CommentText
    {
      get => this.GetAttributeValue<string>("commenttext");
      set
      {
        this.OnPropertyChanging(nameof (CommentText));
        this.SetAttributeValue("commenttext", (object) value);
        this.OnPropertyChanged(nameof (CommentText));
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

    [AttributeLogicalName("kbarticlecommentid")]
    public Guid? KbArticleCommentId
    {
      get => this.GetAttributeValue<Guid?>("kbarticlecommentid");
      set
      {
        this.OnPropertyChanging(nameof (KbArticleCommentId));
        this.SetAttributeValue("kbarticlecommentid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (KbArticleCommentId));
      }
    }

    [AttributeLogicalName("kbarticlecommentid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.KbArticleCommentId = new Guid?(value);
    }

    [AttributeLogicalName("kbarticleid")]
    public EntityReference KbArticleId
    {
      get => this.GetAttributeValue<EntityReference>("kbarticleid");
      set
      {
        this.OnPropertyChanging(nameof (KbArticleId));
        this.SetAttributeValue("kbarticleid", (object) value);
        this.OnPropertyChanged(nameof (KbArticleId));
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
    public Guid? OrganizationId => this.GetAttributeValue<Guid?>("organizationid");

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

    [RelationshipSchemaName("KbArticleComment_AsyncOperations")]
    public IEnumerable<AsyncOperation> KbArticleComment_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (KbArticleComment_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KbArticleComment_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (KbArticleComment_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KbArticleComment_AsyncOperations));
      }
    }

    [RelationshipSchemaName("KbArticleComment_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> KbArticleComment_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (KbArticleComment_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KbArticleComment_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (KbArticleComment_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KbArticleComment_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("KbArticleComment_ProcessSessions")]
    public IEnumerable<ProcessSession> KbArticleComment_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (KbArticleComment_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KbArticleComment_ProcessSessions));
        this.SetRelatedEntities<ProcessSession>(nameof (KbArticleComment_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KbArticleComment_ProcessSessions));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_kbarticlecomment")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_kbarticlecomment
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_kbarticlecomment), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_kbarticlecomment));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_kbarticlecomment), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_kbarticlecomment));
      }
    }

    [AttributeLogicalName("kbarticleid")]
    [RelationshipSchemaName("kbarticle_comments")]
    public KbArticle kbarticle_comments
    {
      get => this.GetRelatedEntity<KbArticle>(nameof (kbarticle_comments), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (kbarticle_comments));
        this.SetRelatedEntity<KbArticle>(nameof (kbarticle_comments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (kbarticle_comments));
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_kbarticlecomment_createdonbehalfby")]
    public SystemUser lk_kbarticlecomment_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_kbarticlecomment_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_kbarticlecomment_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_kbarticlecomment_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_kbarticlecomment_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_kbarticlecomment_modifiedonbehalfby")]
    public SystemUser lk_kbarticlecomment_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_kbarticlecomment_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_kbarticlecomment_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_kbarticlecomment_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_kbarticlecomment_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_kbarticlecommentbase_createdby")]
    public SystemUser lk_kbarticlecommentbase_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_kbarticlecommentbase_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_kbarticlecommentbase_modifiedby")]
    public SystemUser lk_kbarticlecommentbase_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_kbarticlecommentbase_modifiedby), new EntityRole?());
      }
    }

    public KbArticleComment(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["kbarticlecommentid"] = (object) base.Id;
            break;
          case "kbarticlecommentid":
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
