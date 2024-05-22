// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EarlyBound.ProcessStage
// Assembly: TPFamilyWellness.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: C0DF2365-4BFC-418D-B654-2FF4D2B8EB1A
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPFamilyWellnessFrameworkPlugIn-A0924F88-EA00-EA11-A82D-000D3A1F0599\TPFamilyWellnessFrameworkPlugIn.dll

using Microsoft.Xrm.Sdk;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

#nullable disable
namespace TPFamilyWellness.EarlyBound
{
  [DataContract]
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("processstage")]
  [GeneratedCode("CrmSvcUtil", "9.0.0.9154")]
  public class ProcessStage : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "processstage";
    public const int EntityTypeCode = 4724;

    public ProcessStage()
      : base("processstage")
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

    [AttributeLogicalName("clientdata")]
    public string ClientData => this.GetAttributeValue<string>("clientdata");

    [AttributeLogicalName("ownerid")]
    public EntityReference OwnerId => this.GetAttributeValue<EntityReference>("ownerid");

    [AttributeLogicalName("owningbusinessunit")]
    public Guid? OwningBusinessUnit => this.GetAttributeValue<Guid?>("owningbusinessunit");

    [AttributeLogicalName("primaryentitytypecode")]
    public string PrimaryEntityTypeCode
    {
      get => this.GetAttributeValue<string>("primaryentitytypecode");
      set
      {
        this.OnPropertyChanging(nameof (PrimaryEntityTypeCode));
        this.SetAttributeValue("primaryentitytypecode", (object) value);
        this.OnPropertyChanged(nameof (PrimaryEntityTypeCode));
      }
    }

    [AttributeLogicalName("processid")]
    public EntityReference ProcessId
    {
      get => this.GetAttributeValue<EntityReference>("processid");
      set
      {
        this.OnPropertyChanging(nameof (ProcessId));
        this.SetAttributeValue("processid", (object) value);
        this.OnPropertyChanged(nameof (ProcessId));
      }
    }

    [AttributeLogicalName("processstageid")]
    public Guid? ProcessStageId
    {
      get => this.GetAttributeValue<Guid?>("processstageid");
      set
      {
        this.OnPropertyChanging(nameof (ProcessStageId));
        this.SetAttributeValue("processstageid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ProcessStageId));
      }
    }

    [AttributeLogicalName("processstageid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ProcessStageId = new Guid?(value);
    }

    [AttributeLogicalName("stagecategory")]
    public OptionSetValue StageCategory
    {
      get => this.GetAttributeValue<OptionSetValue>("stagecategory");
      set
      {
        this.OnPropertyChanging(nameof (StageCategory));
        this.SetAttributeValue("stagecategory", (object) value);
        this.OnPropertyChanged(nameof (StageCategory));
      }
    }

    [AttributeLogicalName("stagename")]
    public string StageName
    {
      get => this.GetAttributeValue<string>("stagename");
      set
      {
        this.OnPropertyChanging(nameof (StageName));
        this.SetAttributeValue("stagename", (object) value);
        this.OnPropertyChanged(nameof (StageName));
      }
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("processstage_account")]
    public IEnumerable<Account> processstage_account
    {
      get => this.GetRelatedEntities<Account>(nameof (processstage_account), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (processstage_account));
        this.SetRelatedEntities<Account>(nameof (processstage_account), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (processstage_account));
      }
    }

    [RelationshipSchemaName("processstage_appointments")]
    public IEnumerable<Appointment> processstage_appointments
    {
      get
      {
        return this.GetRelatedEntities<Appointment>(nameof (processstage_appointments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (processstage_appointments));
        this.SetRelatedEntities<Appointment>(nameof (processstage_appointments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (processstage_appointments));
      }
    }

    [RelationshipSchemaName("processstage_contact")]
    public IEnumerable<Contact> processstage_contact
    {
      get => this.GetRelatedEntities<Contact>(nameof (processstage_contact), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (processstage_contact));
        this.SetRelatedEntities<Contact>(nameof (processstage_contact), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (processstage_contact));
      }
    }

    [RelationshipSchemaName("processstage_emails")]
    public IEnumerable<Email> processstage_emails
    {
      get => this.GetRelatedEntities<Email>(nameof (processstage_emails), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (processstage_emails));
        this.SetRelatedEntities<Email>(nameof (processstage_emails), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (processstage_emails));
      }
    }

    [RelationshipSchemaName("processstage_phonecalls")]
    public IEnumerable<PhoneCall> processstage_phonecalls
    {
      get
      {
        return this.GetRelatedEntities<PhoneCall>(nameof (processstage_phonecalls), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (processstage_phonecalls));
        this.SetRelatedEntities<PhoneCall>(nameof (processstage_phonecalls), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (processstage_phonecalls));
      }
    }

    [RelationshipSchemaName("processstage_systemusers")]
    public IEnumerable<SystemUser> processstage_systemusers
    {
      get
      {
        return this.GetRelatedEntities<SystemUser>(nameof (processstage_systemusers), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (processstage_systemusers));
        this.SetRelatedEntities<SystemUser>(nameof (processstage_systemusers), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (processstage_systemusers));
      }
    }

    [RelationshipSchemaName("processstage_tasks")]
    public IEnumerable<Task> processstage_tasks
    {
      get => this.GetRelatedEntities<Task>(nameof (processstage_tasks), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (processstage_tasks));
        this.SetRelatedEntities<Task>(nameof (processstage_tasks), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (processstage_tasks));
      }
    }

    [AttributeLogicalName("processid")]
    [RelationshipSchemaName("process_processstage")]
    public Workflow process_processstage
    {
      get => this.GetRelatedEntity<Workflow>(nameof (process_processstage), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (process_processstage));
        this.SetRelatedEntity<Workflow>(nameof (process_processstage), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (process_processstage));
      }
    }
  }
}
