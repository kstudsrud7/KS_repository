// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.PostComment
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("postcomment")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class PostComment : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "postcomment";
    public const string EntitySchemaName = "PostComment";
    public const string PrimaryIdAttribute = "postcommentid";
    public const string PrimaryNameAttribute = "text";

    public PostComment()
      : base("postcomment")
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

    [AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get => this.GetAttributeValue<EntityReference>("organizationid");
    }

    [AttributeLogicalName("postcommentid")]
    public Guid? PostCommentId
    {
      get => this.GetAttributeValue<Guid?>("postcommentid");
      set
      {
        this.OnPropertyChanging(nameof (PostCommentId));
        this.SetAttributeValue("postcommentid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (PostCommentId));
      }
    }

    [AttributeLogicalName("postcommentid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.PostCommentId = new Guid?(value);
    }

    [AttributeLogicalName("postid")]
    public EntityReference PostId
    {
      get => this.GetAttributeValue<EntityReference>("postid");
      set
      {
        this.OnPropertyChanging(nameof (PostId));
        this.SetAttributeValue("postid", (object) value);
        this.OnPropertyChanged(nameof (PostId));
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

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_postcomment_createdby")]
    public SystemUser lk_postcomment_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_postcomment_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_postcomment_createdonbehalfby")]
    public SystemUser lk_postcomment_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_postcomment_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_postcomment_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_postcomment_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_postcomment_createdonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_PostComment")]
    public Organization organization_PostComment
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_PostComment), new EntityRole?());
      }
    }

    [AttributeLogicalName("postid")]
    [RelationshipSchemaName("Post_Comments")]
    public Post Post_Comments
    {
      get => this.GetRelatedEntity<Post>(nameof (Post_Comments), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Post_Comments));
        this.SetRelatedEntity<Post>(nameof (Post_Comments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Post_Comments));
      }
    }

    public PostComment(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["postcommentid"] = (object) base.Id;
            break;
          case "postcommentid":
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
