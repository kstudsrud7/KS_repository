// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.Post
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("post")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class Post : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "post";
    public const string EntitySchemaName = "Post";
    public const string PrimaryIdAttribute = "postid";
    public const string PrimaryNameAttribute = "text";

    public Post()
      : base("post")
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

    [AttributeLogicalName("postid")]
    public Guid? PostId
    {
      get => this.GetAttributeValue<Guid?>("postid");
      set
      {
        this.OnPropertyChanging(nameof (PostId));
        this.SetAttributeValue("postid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (PostId));
      }
    }

    [AttributeLogicalName("postid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.PostId = new Guid?(value);
    }

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

    [AttributeLogicalName("regardingobjectownerid")]
    public EntityReference RegardingObjectOwnerId
    {
      get => this.GetAttributeValue<EntityReference>("regardingobjectownerid");
    }

    [AttributeLogicalName("regardingobjectowningbusinessunit")]
    public EntityReference RegardingObjectOwningBusinessUnit
    {
      get => this.GetAttributeValue<EntityReference>("regardingobjectowningbusinessunit");
    }

    [AttributeLogicalName("source")]
    public OptionSetValue Source
    {
      get => this.GetAttributeValue<OptionSetValue>("source");
      set
      {
        this.OnPropertyChanging(nameof (Source));
        this.SetAttributeValue("source", (object) value);
        this.OnPropertyChanged(nameof (Source));
      }
    }

    [AttributeLogicalName("text")]
    public string Text
    {
      get => this.GetAttributeValue<string>("text");
      set
      {
        this.OnPropertyChanging(nameof (Text));
        this.SetAttributeValue("text", (object) value);
        this.OnPropertyChanged(nameof (Text));
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

    [AttributeLogicalName("type")]
    public OptionSetValue Type
    {
      get => this.GetAttributeValue<OptionSetValue>("type");
      set
      {
        this.OnPropertyChanging(nameof (Type));
        this.SetAttributeValue("type", (object) value);
        this.OnPropertyChanged(nameof (Type));
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

    [RelationshipSchemaName("post_AsyncOperations")]
    public IEnumerable<AsyncOperation> post_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (post_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (post_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (post_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (post_AsyncOperations));
      }
    }

    [RelationshipSchemaName("post_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> post_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (post_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (post_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (post_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (post_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("Post_Comments")]
    public IEnumerable<PostComment> Post_Comments
    {
      get => this.GetRelatedEntities<PostComment>(nameof (Post_Comments), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Post_Comments));
        this.SetRelatedEntities<PostComment>(nameof (Post_Comments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Post_Comments));
      }
    }

    [RelationshipSchemaName("Post_Likes")]
    public IEnumerable<PostLike> Post_Likes
    {
      get => this.GetRelatedEntities<PostLike>(nameof (Post_Likes), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Post_Likes));
        this.SetRelatedEntities<PostLike>(nameof (Post_Likes), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Post_Likes));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_post_createdby")]
    public SystemUser lk_post_createdby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_post_createdby), new EntityRole?());
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_post_createdonbehalfby")]
    public SystemUser lk_post_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_post_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_post_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_post_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_post_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_post_modifiedby")]
    public SystemUser lk_post_modifiedby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_post_modifiedby), new EntityRole?());
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_post_modifiedonbehalfby")]
    public SystemUser lk_post_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_post_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_post_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_post_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_post_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_post")]
    public Organization organization_post
    {
      get => this.GetRelatedEntity<Organization>(nameof (organization_post), new EntityRole?());
    }

    public Post(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["postid"] = (object) base.Id;
            break;
          case "postid":
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
