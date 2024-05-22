// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ActivityMimeAttachment
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("activitymimeattachment")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ActivityMimeAttachment : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "activitymimeattachment";
    public const string EntitySchemaName = "ActivityMimeAttachment";
    public const string PrimaryIdAttribute = "activitymimeattachmentid";
    public const string PrimaryNameAttribute = "filename";

    public ActivityMimeAttachment()
      : base("activitymimeattachment")
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

    [AttributeLogicalName("activityid")]
    [Obsolete]
    public EntityReference ActivityId
    {
      get => this.GetAttributeValue<EntityReference>("activityid");
      set
      {
        this.OnPropertyChanging(nameof (ActivityId));
        this.SetAttributeValue("activityid", (object) value);
        this.OnPropertyChanged(nameof (ActivityId));
      }
    }

    [AttributeLogicalName("activitymimeattachmentid")]
    public Guid? ActivityMimeAttachmentId
    {
      get => this.GetAttributeValue<Guid?>("activitymimeattachmentid");
      set
      {
        this.OnPropertyChanging(nameof (ActivityMimeAttachmentId));
        this.SetAttributeValue("activitymimeattachmentid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ActivityMimeAttachmentId));
      }
    }

    [AttributeLogicalName("activitymimeattachmentid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ActivityMimeAttachmentId = new Guid?(value);
    }

    [AttributeLogicalName("activitymimeattachmentidunique")]
    public Guid? ActivityMimeAttachmentIdUnique
    {
      get => this.GetAttributeValue<Guid?>("activitymimeattachmentidunique");
      set
      {
        this.OnPropertyChanging(nameof (ActivityMimeAttachmentIdUnique));
        this.SetAttributeValue("activitymimeattachmentidunique", (object) value);
        this.OnPropertyChanged(nameof (ActivityMimeAttachmentIdUnique));
      }
    }

    [AttributeLogicalName("activitysubject")]
    public string ActivitySubject => this.GetAttributeValue<string>("activitysubject");

    [AttributeLogicalName("anonymouslink")]
    public string AnonymousLink => this.GetAttributeValue<string>("anonymouslink");

    [AttributeLogicalName("attachmentcontentid")]
    public string AttachmentContentId
    {
      get => this.GetAttributeValue<string>("attachmentcontentid");
      set
      {
        this.OnPropertyChanging(nameof (AttachmentContentId));
        this.SetAttributeValue("attachmentcontentid", (object) value);
        this.OnPropertyChanged(nameof (AttachmentContentId));
      }
    }

    [AttributeLogicalName("attachmentid")]
    public EntityReference AttachmentId
    {
      get => this.GetAttributeValue<EntityReference>("attachmentid");
      set
      {
        this.OnPropertyChanging(nameof (AttachmentId));
        this.SetAttributeValue("attachmentid", (object) value);
        this.OnPropertyChanged(nameof (AttachmentId));
      }
    }

    [AttributeLogicalName("attachmentnumber")]
    public int? AttachmentNumber
    {
      get => this.GetAttributeValue<int?>("attachmentnumber");
      set
      {
        this.OnPropertyChanging(nameof (AttachmentNumber));
        this.SetAttributeValue("attachmentnumber", (object) value);
        this.OnPropertyChanged(nameof (AttachmentNumber));
      }
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

    [AttributeLogicalName("isfollowed")]
    public bool? IsFollowed => this.GetAttributeValue<bool?>("isfollowed");

    [AttributeLogicalName("ismanaged")]
    public bool? IsManaged => this.GetAttributeValue<bool?>("ismanaged");

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

    [AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime => this.GetAttributeValue<DateTime?>("overwritetime");

    [AttributeLogicalName("ownerid")]
    public EntityReference OwnerId => this.GetAttributeValue<EntityReference>("ownerid");

    [AttributeLogicalName("owningbusinessunit")]
    public EntityReference OwningBusinessUnit
    {
      get => this.GetAttributeValue<EntityReference>("owningbusinessunit");
    }

    [AttributeLogicalName("owninguser")]
    public EntityReference OwningUser => this.GetAttributeValue<EntityReference>("owninguser");

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

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("ActivityMimeAttachment_AsyncOperations")]
    public IEnumerable<AsyncOperation> ActivityMimeAttachment_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ActivityMimeAttachment_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ActivityMimeAttachment_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ActivityMimeAttachment_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ActivityMimeAttachment_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ActivityMimeAttachment_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ActivityMimeAttachment_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ActivityMimeAttachment_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ActivityMimeAttachment_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ActivityMimeAttachment_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ActivityMimeAttachment_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ActivityMimeAttachment_SyncErrors")]
    public IEnumerable<SyncError> ActivityMimeAttachment_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ActivityMimeAttachment_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ActivityMimeAttachment_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ActivityMimeAttachment_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ActivityMimeAttachment_SyncErrors));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_activitymimeattachment")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_activitymimeattachment
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_activitymimeattachment), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_activitymimeattachment));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_activitymimeattachment), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_activitymimeattachment));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("activity_pointer_activity_mime_attachment")]
    public ActivityPointer activity_pointer_activity_mime_attachment
    {
      get
      {
        return this.GetRelatedEntity<ActivityPointer>(nameof (activity_pointer_activity_mime_attachment), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (activity_pointer_activity_mime_attachment));
        this.SetRelatedEntity<ActivityPointer>(nameof (activity_pointer_activity_mime_attachment), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (activity_pointer_activity_mime_attachment));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("appointment_activity_mime_attachment")]
    public Appointment appointment_activity_mime_attachment
    {
      get
      {
        return this.GetRelatedEntity<Appointment>(nameof (appointment_activity_mime_attachment), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appointment_activity_mime_attachment));
        this.SetRelatedEntity<Appointment>(nameof (appointment_activity_mime_attachment), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appointment_activity_mime_attachment));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("email_activity_mime_attachment")]
    public Email email_activity_mime_attachment
    {
      get
      {
        return this.GetRelatedEntity<Email>(nameof (email_activity_mime_attachment), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (email_activity_mime_attachment));
        this.SetRelatedEntity<Email>(nameof (email_activity_mime_attachment), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (email_activity_mime_attachment));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("template_activity_mime_attachments")]
    public Template template_activity_mime_attachments
    {
      get
      {
        return this.GetRelatedEntity<Template>(nameof (template_activity_mime_attachments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (template_activity_mime_attachments));
        this.SetRelatedEntity<Template>(nameof (template_activity_mime_attachments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (template_activity_mime_attachments));
      }
    }

    public ActivityMimeAttachment(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["activitymimeattachmentid"] = (object) base.Id;
            break;
          case "activitymimeattachmentid":
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
