// Decompiled with JetBrains decompiler
// Type: ArcticIT.TribalEnrollment.EntityPlugins.RelationshipPlugin
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using ArcticIT.CrmFramework.Libraries;
using ArcticIT.CrmFramework.Plugins;
using ArcticIT.CrmFramework.Plugins.Enums;
using ArcticIT.EarlyBound.Entities;
using ArcticIT.EarlyBound.OptionSets;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

#nullable disable
namespace ArcticIT.TribalEnrollment.EntityPlugins
{
  [CRMMetadata(EntityName = "ait_relationship", CrmEntityType = "ArcticIT.EarlyBound.Entities.ait_relationship")]
  public class RelationshipPlugin : EntityBase
  {
    private Dictionary<ait_relationshiptype, ait_relationshiptype> _oppositeRelationshipTypes = (Dictionary<ait_relationshiptype, ait_relationshiptype>) null;

    private IPluginExecutionContext PluginContext { get; set; }

    public RelationshipPlugin(
      IServiceProvider serviceProvider,
      string securedConfiguration,
      string unsecuredConfiguration)
      : base(serviceProvider, securedConfiguration, securedConfiguration)
    {
      this.PluginContext = (IPluginExecutionContext) serviceProvider.GetService(typeof (IPluginExecutionContext));
      this.OnPluginPreCreating += new EntityBase.PluginOnPreCreateHandler(this.Execute_OnPluginPreCreating);
      this.OnPluginPreUpdating += new EntityBase.PluginOnPreUpdateHandler(this.Execute_OnPluginPreUpdating);
      this.OnPluginPostUpdating += new EntityBase.PluginOnPostUpdateHandler(this.Execute_OnPluginPostUpdating);
      this.OnPluginPostCreating += new EntityBase.PluginOnPostCreateHandler(this.Execute_OnPluginPostCreating);
      this.OnPluginPostDeleting += new EntityBase.PluginOnPostDeleteHandler(this.Execute_OnPluginPostDeleting);
    }

    private void Execute_OnPluginPreCreating(
      object sender,
      EntityBase.PluginOnPreCreateHandlerEventArgs e)
    {
      if (((IExecutionContext) this.PluginContext).Depth > 3)
        return;
      this.ValidateRelationship();
      this.SynchronizeFromRelatedAttributes();
      this.UpdateName();
    }

    private void Execute_OnPluginPreUpdating(
      object sender,
      EntityBase.PluginOnPreUpdateHandlerEventArgs e)
    {
      if (((IExecutionContext) this.PluginContext).Depth > 3)
        return;
      this.ValidateRelationship();
      this.UpdateName();
    }

    private void Execute_OnPluginPostCreating(
      object sender,
      EntityBase.PluginOnPostCreateHandlerEventArgs e)
    {
      if (((IExecutionContext) this.PluginContext).Depth > 3)
        return;
      this.UpdateOppositeRelationship();
      this.UpdateRelatedRecords();
    }

    private void Execute_OnPluginPostUpdating(
      object sender,
      EntityBase.PluginOnPostUpdateHandlerEventArgs e)
    {
      if (((IExecutionContext) this.PluginContext).Depth > 3)
        return;
      this.UpdateOppositeRelationship();
      this.UpdateRelatedRecords();
    }

    private void Execute_OnPluginPostDeleting(
      object sender,
      EntityBase.PluginOnPostDeleteHandlerEventArgs e)
    {
      if (((IExecutionContext) this.PluginContext).Depth > 3)
        return;
      this.DeleteOppositeRelationship();
    }

    public static void AddRelationship(
      IOrganizationService crmService,
      EntityReference contact,
      EntityReference relatedTo,
      OptionSetValue relationshipType)
    {
      if (contact == null || relatedTo == null || relationshipType == null || AttributeLibrary.Compare(contact, relatedTo))
        return;
      ait_relationship relationship = RelationshipPlugin.GetRelationship(crmService, contact, relatedTo);
      if (relationship == null)
      {
        ait_relationship aitRelationship = new ait_relationship()
        {
          ait_contact = contact,
          ait_RelationshipTo = relatedTo,
          ait_relationshiptype = relationshipType
        };
        crmService.Create((Entity) aitRelationship);
      }
      else if (!AttributeLibrary.Compare(relationship.ait_RelationshipTo, relatedTo) || !AttributeLibrary.Compare(relationship.ait_relationshiptype, relationshipType))
      {
        relationship.ait_RelationshipTo = relatedTo;
        relationship.ait_relationshiptype = relationshipType;
        crmService.Update((Entity) relationship);
      }
    }

    public static ait_relationship GetRelationship(
      IOrganizationService crmService,
      EntityReference contact,
      OptionSetValue relationshipType)
    {
      return contact == null || relationshipType == null ? (ait_relationship) null : RelationshipPlugin.GetRelationship(crmService, contact, (ait_relationshiptype) relationshipType.Value);
    }

    public static ait_relationship GetRelationship(
      IOrganizationService crmService,
      EntityReference contact,
      ait_relationshiptype relationshipType)
    {
      if (contact == null)
        return (ait_relationship) null;
      ait_relationship relationship = (ait_relationship) null;
      EntityCollection allEntities = EntityLibrary.GetAllEntities(crmService, "ait_relationship", new List<ConditionExpression>()
      {
        new ConditionExpression("ait_contact", (ConditionOperator) 0, (object) contact.Id),
        new ConditionExpression("ait_relationshiptype", (ConditionOperator) 0, (object) (int) relationshipType)
      }, true);
      if (allEntities != null && ((Collection<Entity>) allEntities.Entities).Count > 0)
        relationship = (ait_relationship) ((Collection<Entity>) allEntities.Entities)[0];
      return relationship;
    }

    public static ait_relationship GetRelationship(
      IOrganizationService crmService,
      EntityReference contact,
      EntityReference relatedTo)
    {
      return contact == null || relatedTo == null ? (ait_relationship) null : RelationshipPlugin.GetRelationship(crmService, contact.Id, relatedTo.Id);
    }

    public static ait_relationship GetRelationship(
      IOrganizationService crmService,
      Guid contact,
      Guid relatedTo)
    {
      ait_relationship relationship = (ait_relationship) null;
      EntityCollection allEntities = EntityLibrary.GetAllEntities(crmService, "ait_relationship", new List<ConditionExpression>()
      {
        new ConditionExpression("ait_contact", (ConditionOperator) 0, (object) contact),
        new ConditionExpression("ait_relationshipto", (ConditionOperator) 0, (object) relatedTo)
      }, true);
      if (allEntities != null && ((Collection<Entity>) allEntities.Entities).Count > 0)
        relationship = (ait_relationship) ((Collection<Entity>) allEntities.Entities)[0];
      return relationship;
    }

    protected override List<UpdateRelatedAttributeInformation> GetSynchronizeFromAttributeRelationships()
    {
      return new List<UpdateRelatedAttributeInformation>()
      {
        new UpdateRelatedAttributeInformation("contact", "ait_relationshipto", "ait_birthdate", "birthdate", true)
      };
    }

    protected override Entity GetBaseImageForUpdate()
    {
      return (Entity) this.GetInputEntity<ait_relationship>(this.ActionType, Global.Stage.PRE);
    }

    protected override Entity GetPreImageForUpdate()
    {
      return (Entity) this.GetEntityFromPreImage<ait_relationship>();
    }

    protected override string GenerateFormattedName(Entity entityInput, Entity preImage)
    {
      string empty = string.Empty;
      ait_relationship aitRelationship1 = (ait_relationship) entityInput;
      ait_relationship aitRelationship2 = (ait_relationship) preImage;
      return FormatLibrary.FormatName(FormatLibrary.GetEntityValue((IOrganizationService) this.CrmService, aitRelationship1.ait_contact, aitRelationship2.ait_contact), FormatLibrary.GetEntityValue((IOrganizationService) this.CrmService, "ait_relationshiptype", aitRelationship1.ait_relationshiptype, aitRelationship2.ait_relationshiptype), FormatLibrary.GetEntityValue((IOrganizationService) this.CrmService, aitRelationship1.ait_RelationshipTo, aitRelationship2.ait_RelationshipTo));
    }

    private void UpdateContact(
      IOrganizationService crmService,
      ait_relationship relationship,
      Global.ActionType actionType)
    {
      if (relationship == null || relationship.ait_contact == null || relationship.ait_maritalstatus == null || !AttributeLibrary.Compare(relationship.ait_relationshiptype, 750000017))
        return;
      Contact entity = (Contact) EntityLibrary.GetEntity(crmService, relationship.ait_contact, false);
      if (entity == null || AttributeLibrary.Compare(relationship.ait_maritalstatus, entity.ait_maritalstatus))
        return;
      Contact contact = new Contact();
      ((Entity) contact).Id = ((Entity) entity).Id;
      contact.ContactId = entity.ContactId;
      entity.ait_maritalstatus = relationship.ait_maritalstatus;
      contact.ait_maritalstatus = relationship.ait_maritalstatus;
      crmService.Update((Entity) contact);
    }

    private void UpdateEmergencyContact(
      IOrganizationService crmService,
      ait_relationship relationship,
      Global.ActionType actionType)
    {
      if (relationship == null || relationship.ait_contact == null || relationship.ait_RelationshipTo == null || relationship.ait_relationshiptype == null || actionType == Global.ActionType.DELETE)
        return;
      EmergencyContactPlugin.UpdateEmergencyContact(crmService, relationship.ait_contact, relationship.ait_RelationshipTo, relationship.ait_relationshiptype);
    }

    private void UpdateHouseholdMember(
      IOrganizationService crmService,
      ait_relationship relationship,
      Global.ActionType actionType)
    {
      if (relationship == null || relationship.ait_contact == null || relationship.ait_RelationshipTo == null || relationship.ait_relationshiptype == null || actionType == Global.ActionType.DELETE)
        return;
      HouseholdMemberPlugin.UpdateHouseholdMember(crmService, relationship.ait_contact, relationship.ait_RelationshipTo, relationship.ait_relationshiptype);
    }

    private void UpdateRelatedRecords()
    {
      ait_relationship inputEntity = this.GetInputEntity<ait_relationship>(this.ActionType);
      this.UpdateContact((IOrganizationService) this.CrmService, inputEntity, this.ActionType);
      this.UpdateEmergencyContact((IOrganizationService) this.CrmService, inputEntity, this.ActionType);
      this.UpdateHouseholdMember((IOrganizationService) this.CrmService, inputEntity, this.ActionType);
    }

    private void ValidateNoCircularReference(
      ait_relationship relationshipToVerify,
      ait_relationship parentRelationship,
      string relationshipList)
    {
      if (relationshipToVerify == null)
        return;
      string empty = string.Empty;
      string entityName1;
      ait_relationship relationship;
      if (parentRelationship == null)
      {
        entityName1 = EntityLibrary.GetEntityName((IOrganizationService) this.CrmService, relationshipToVerify.ait_contact);
        relationship = RelationshipPlugin.GetRelationship((IOrganizationService) this.CrmService, relationshipToVerify.ait_RelationshipTo, relationshipToVerify.ait_relationshiptype);
      }
      else
      {
        entityName1 = EntityLibrary.GetEntityName((IOrganizationService) this.CrmService, parentRelationship.ait_contact);
        relationship = RelationshipPlugin.GetRelationship((IOrganizationService) this.CrmService, parentRelationship.ait_RelationshipTo, relationshipToVerify.ait_relationshiptype);
      }
      if (relationship == null)
        return;
      if (AttributeLibrary.Compare(relationshipToVerify.ait_contact, relationship.ait_RelationshipTo))
      {
        string entityName2 = EntityLibrary.GetEntityName((IOrganizationService) this.CrmService, relationship.ait_contact);
        string entityName3 = EntityLibrary.GetEntityName((IOrganizationService) this.CrmService, relationship.ait_RelationshipTo);
        relationshipList += string.Format(", {0}, {1}, {2}", (object) entityName1, (object) entityName2, (object) entityName3);
        throw new InvalidPluginExecutionException(string.Format("Relationship: Adding relationship would cause a circular {0} relationship: {1}.", (object) MetadataLibrary.GetOptionSetText((IOrganizationService) this.CrmService, "ait_relationshiptype", relationshipToVerify.ait_relationshiptype.Value), (object) relationshipList));
      }
      if (!string.IsNullOrEmpty(relationshipList))
        relationshipList += ", ";
      relationshipList += entityName1;
      this.ValidateNoCircularReference(relationshipToVerify, relationship, relationshipList);
    }

    private void ValidateRelationship()
    {
      ait_relationship inputEntity = this.GetInputEntity<ait_relationship>();
      EntityReference entityValueToUse1 = (EntityReference) ObjectLibrary.GetEntityValueToUse((EntityBase) this, "ait_relationshipto");
      EntityReference entityValueToUse2 = (EntityReference) ObjectLibrary.GetEntityValueToUse((EntityBase) this, "ait_contact");
      if (entityValueToUse2 == null)
        throw new InvalidPluginExecutionException((OperationStatus) 0, "Contact must be specified.");
      if (inputEntity == null || entityValueToUse1 == null || entityValueToUse2 == null)
        return;
      if (inputEntity.ait_contact != null && entityValueToUse1 != null && entityValueToUse2.Id == entityValueToUse1.Id)
        throw new InvalidPluginExecutionException((OperationStatus) 0, "Cannot set a relationship to itself.");
      if (inputEntity.ait_relationshiptype != null && entityValueToUse2 != null && entityValueToUse1 != null && (inputEntity.ait_relationshiptype.Value == 750000007 || inputEntity.ait_relationshiptype.Value == 750000008))
      {
        if (((Collection<Entity>) EntityLibrary.GetAllEntities((IOrganizationService) this.CrmService, "ait_relationship", new List<ConditionExpression>()
        {
          new ConditionExpression("ait_relationshiptype", (ConditionOperator) 0, (object) inputEntity.ait_relationshiptype.Value),
          new ConditionExpression("ait_contact", (ConditionOperator) 0, (object) entityValueToUse2.Id),
          new ConditionExpression("ait_relationshipid", (ConditionOperator) 1, (object) ((Entity) inputEntity).Id)
        }, true).Entities).Count > 0)
          throw new InvalidPluginExecutionException((OperationStatus) 0, string.Format("Cannot have more than one relationship with the same biological mother or father. {0} - {1}", (object) EntityLibrary.GetEntityName((IOrganizationService) this.CrmService, entityValueToUse2), (object) EntityLibrary.GetEntityName((IOrganizationService) this.CrmService, entityValueToUse1)));
      }
      if (entityValueToUse2 != null && entityValueToUse1 != null)
      {
        if (((Collection<Entity>) EntityLibrary.GetAllEntities((IOrganizationService) this.CrmService, "ait_relationship", new List<ConditionExpression>()
        {
          new ConditionExpression("ait_contact", (ConditionOperator) 0, (object) entityValueToUse2.Id),
          new ConditionExpression("ait_relationshipid", (ConditionOperator) 1, (object) ((Entity) inputEntity).Id),
          new ConditionExpression("ait_relationshipto", (ConditionOperator) 0, (object) entityValueToUse1.Id)
        }, true).Entities).Count > 0)
          throw new InvalidPluginExecutionException((OperationStatus) 0, string.Format("Cannot have more than one relationship with the same from and to contact. {0} -> {1}", (object) EntityLibrary.GetEntityName((IOrganizationService) this.CrmService, entityValueToUse2), (object) EntityLibrary.GetEntityName((IOrganizationService) this.CrmService, entityValueToUse1)));
      }
      if (inputEntity == null || !AttributeLibrary.Compare(inputEntity.ait_relationshiptype, 750000007) && !AttributeLibrary.Compare(inputEntity.ait_relationshiptype, 750000008))
        return;
      this.ValidateNoCircularReference(inputEntity, (ait_relationship) null, string.Empty);
    }

    private void DeleteOppositeRelationship()
    {
      ait_relationship inputEntity = this.GetInputEntity<ait_relationship>(this.ActionType);
      if (inputEntity == null || inputEntity.ait_RelationshipTo == null)
        return;
      ait_relationship relationship = RelationshipPlugin.GetRelationship((IOrganizationService) this.CrmService, inputEntity.ait_RelationshipTo.Id, inputEntity.ait_contact.Id);
      if (relationship == null)
        return;
      this.CrmService.Delete("ait_relationship", ((Entity) relationship).Id);
    }

    private void UpdateOppositeRelationship()
    {
      ait_relationship inputEntity = this.GetInputEntity<ait_relationship>(this.ActionType);
      if (inputEntity == null || inputEntity.ait_RelationshipTo == null || inputEntity.ait_contact == null || inputEntity.ait_relationshiptype == null)
        return;
      ait_relationshiptype relationshipType = this.GetRelationshipType(inputEntity);
      if (ait_relationshiptype.HeadofHousehold == relationshipType)
        return;
      ait_relationship relationship = RelationshipPlugin.GetRelationship((IOrganizationService) this.CrmService, inputEntity.ait_RelationshipTo.Id, inputEntity.ait_contact.Id);
      if (relationship == null)
      {
        ait_relationship oppositeRelationship = new ait_relationship();
        this.UpdateOppositeRelationship(oppositeRelationship, inputEntity, relationshipType);
        this.CrmService.Create((Entity) oppositeRelationship);
      }
      else if ((ait_relationshiptype) relationship.ait_relationshiptype.Value != relationshipType)
      {
        this.UpdateOppositeRelationship(relationship, inputEntity, relationshipType);
        this.CrmService.Update((Entity) relationship);
      }
    }

    private ait_relationshiptype GetRelationshipType(ait_relationship relationShip)
    {
      ait_relationshiptype relationshipType = ait_relationshiptype.HeadofHousehold;
      ait_relationshiptype key = (ait_relationshiptype) relationShip.ait_relationshiptype.Value;
      if (this.OppositeRelationshipTypes.ContainsKey(key))
      {
        relationshipType = this.OppositeRelationshipTypes[key];
        if (ait_relationshiptype.HeadofHousehold == relationshipType)
        {
          Contact entity = (Contact) EntityLibrary.GetEntity((IOrganizationService) this.CrmService, relationShip.ait_contact);
          if (entity != null && entity.ait_gender != null)
          {
            switch (key)
            {
              case ait_relationshiptype.AdoptedChild:
                relationshipType = AttributeLibrary.Compare(entity.ait_gender, 750000000) ? ait_relationshiptype.AdoptiveFather : ait_relationshiptype.AdoptiveMother;
                break;
              case ait_relationshiptype.BiologicalChild:
                relationshipType = AttributeLibrary.Compare(entity.ait_gender, 750000000) ? ait_relationshiptype.BiologicalFather : ait_relationshiptype.BiologicalMother;
                break;
              case ait_relationshiptype.StepChild:
                relationshipType = AttributeLibrary.Compare(entity.ait_gender, 750000000) ? ait_relationshiptype.StepFather : ait_relationshiptype.StepMother;
                break;
            }
          }
        }
      }
      return relationshipType;
    }

    private void UpdateOppositeRelationship(
      ait_relationship oppositeRelationship,
      ait_relationship relationShip,
      ait_relationshiptype relationshipType)
    {
      oppositeRelationship.ait_contact = relationShip.ait_RelationshipTo;
      oppositeRelationship.ait_RelationshipTo = relationShip.ait_contact;
      oppositeRelationship.ait_startdate = relationShip.ait_startdate;
      oppositeRelationship.ait_enddate = relationShip.ait_enddate;
      oppositeRelationship.ait_description = relationShip.ait_description;
      oppositeRelationship.ait_maritalstatus = relationShip.ait_maritalstatus;
      oppositeRelationship.ait_relationshiptype = new OptionSetValue((int) relationshipType);
    }

    private Dictionary<ait_relationshiptype, ait_relationshiptype> OppositeRelationshipTypes
    {
      get
      {
        if (this._oppositeRelationshipTypes != null)
          return this._oppositeRelationshipTypes;
        this._oppositeRelationshipTypes = new Dictionary<ait_relationshiptype, ait_relationshiptype>();
        this._oppositeRelationshipTypes.Add(ait_relationshiptype.Acquaintance, ait_relationshiptype.Acquaintance);
        this._oppositeRelationshipTypes.Add(ait_relationshiptype.AdoptedChild, ait_relationshiptype.HeadofHousehold);
        this._oppositeRelationshipTypes.Add(ait_relationshiptype.AdoptiveFather, ait_relationshiptype.AdoptedChild);
        this._oppositeRelationshipTypes.Add(ait_relationshiptype.AdoptiveMother, ait_relationshiptype.AdoptedChild);
        this._oppositeRelationshipTypes.Add(ait_relationshiptype.AuntorUncle, ait_relationshiptype.NieceorNephew);
        this._oppositeRelationshipTypes.Add(ait_relationshiptype.BiologicalChild, ait_relationshiptype.HeadofHousehold);
        this._oppositeRelationshipTypes.Add(ait_relationshiptype.BiologicalFather, ait_relationshiptype.BiologicalChild);
        this._oppositeRelationshipTypes.Add(ait_relationshiptype.BiologicalMother, ait_relationshiptype.BiologicalChild);
        this._oppositeRelationshipTypes.Add(ait_relationshiptype.Cousin, ait_relationshiptype.Cousin);
        this._oppositeRelationshipTypes.Add(ait_relationshiptype.Grandchild, ait_relationshiptype.Grandparent);
        this._oppositeRelationshipTypes.Add(ait_relationshiptype.Grandparent, ait_relationshiptype.Grandchild);
        this._oppositeRelationshipTypes.Add(ait_relationshiptype.Inlaw, ait_relationshiptype.Inlaw);
        this._oppositeRelationshipTypes.Add(ait_relationshiptype.NieceorNephew, ait_relationshiptype.AuntorUncle);
        this._oppositeRelationshipTypes.Add(ait_relationshiptype.OtherRelative, ait_relationshiptype.OtherRelative);
        this._oppositeRelationshipTypes.Add(ait_relationshiptype.Sibling, ait_relationshiptype.Sibling);
        this._oppositeRelationshipTypes.Add(ait_relationshiptype.Spouse, ait_relationshiptype.Spouse);
        this._oppositeRelationshipTypes.Add(ait_relationshiptype.StepChild, ait_relationshiptype.HeadofHousehold);
        this._oppositeRelationshipTypes.Add(ait_relationshiptype.StepFather, ait_relationshiptype.StepChild);
        this._oppositeRelationshipTypes.Add(ait_relationshiptype.StepMother, ait_relationshiptype.StepChild);
        this._oppositeRelationshipTypes.Add(ait_relationshiptype.StepSibling, ait_relationshiptype.StepSibling);
        return this._oppositeRelationshipTypes;
      }
    }
  }
}
