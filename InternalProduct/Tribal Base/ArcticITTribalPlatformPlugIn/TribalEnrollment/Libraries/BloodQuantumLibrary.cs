// Decompiled with JetBrains decompiler
// Type: ArcticIT.TribalEnrollment.Libraries.BloodQuantumLibrary
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using ArcticIT.CrmFramework.Libraries;
using ArcticIT.EarlyBound.Entities;
using ArcticIT.EarlyBound.OptionSets;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

#nullable disable
namespace ArcticIT.TribalEnrollment.Libraries
{
  public class BloodQuantumLibrary
  {
    private string returnErrorMessage = string.Empty;
    private Fraction minimumParentalBQFraction;
    private ait_memberprofile _member = (ait_memberprofile) null;

    private FrameworkService CrmService { get; set; }

    public BloodQuantumLibrary(FrameworkService crmService, EntityReference memberProfileReference)
    {
      this.CrmService = crmService != null ? crmService : throw new ArgumentNullException(nameof (crmService));
      this.MemberProfileReference = memberProfileReference;
    }

    public EntityReference MemberProfileReference { get; private set; }

    public ait_memberprofile MemberProfile
    {
      get
      {
        if (this._member == null)
          this._member = (ait_memberprofile) EntityLibrary.GetEntity((IOrganizationService) this.CrmService, this.MemberProfileReference);
        return this._member;
      }
    }

    public bool UseParentProfileForCalculation
    {
      get
      {
        bool profileForCalculation = true;
        if (this.MemberProfile.ait_biologicalfatherprofile == null && this.MemberProfile.ait_biologicalmotherprofile == null)
          profileForCalculation = false;
        return profileForCalculation;
      }
    }

    public MemberBloodQuantumInfoStruct GetCalculatedBloodQuantumInfoFromParents()
    {
      MemberBloodQuantumInfoStruct bloodQuantumInfo1 = this.GetMemberBloodQuantumInfo(this.MemberProfile.ait_biologicalmotherprofile);
      MemberBloodQuantumInfoStruct bloodQuantumInfo2 = this.GetMemberBloodQuantumInfo(this.MemberProfile.ait_biologicalfatherprofile);
      this.minimumParentalBQFraction = Fraction.Parse(TribalEnrollmentConfiguration.GetBloodQuantumParentThreshholdFraction(this.CrmService));
      MemberBloodQuantumInfoStruct quantumInfoFromParents = new MemberBloodQuantumInfoStruct();
      Fraction fraction1 = ((bloodQuantumInfo1.TribalBloodQuantum >= this.minimumParentalBQFraction ? bloodQuantumInfo1.TribalBloodQuantum : new Fraction(0L, 1L)) + (bloodQuantumInfo2.TribalBloodQuantum >= this.minimumParentalBQFraction ? bloodQuantumInfo2.TribalBloodQuantum : new Fraction(0L, 1L))) / (Fraction) 2L;
      Fraction fraction2 = (bloodQuantumInfo1.TotalBloodQuantum + bloodQuantumInfo2.TotalBloodQuantum) / (Fraction) 2L;
      quantumInfoFromParents.TribalBloodQuantum = fraction1;
      quantumInfoFromParents.TotalBloodQuantum = fraction2;
      quantumInfoFromParents.TotalBloodQuantumDecimal = (Decimal) quantumInfoFromParents.TotalBloodQuantum;
      quantumInfoFromParents.TribalBloodQuantumDecimal = (Decimal) quantumInfoFromParents.TribalBloodQuantum;
      quantumInfoFromParents.MemberBloodQuantums = this.GetMergedParentBloodQuantums(bloodQuantumInfo1, bloodQuantumInfo2);
      return quantumInfoFromParents;
    }

    public ait_memberprofile UpdateBloodQuantumForIndividual()
    {
      EntityCollection referencedEntities = EntityLibrary.GetAllReferencedEntities((IOrganizationService) this.CrmService, "ait_bloodquantum", "ait_memberprofile", this.MemberProfileReference, true);
      Fraction totalBloodQuantum = new Fraction(0L);
      Fraction tribalBloodQuantum = new Fraction(0L);
      ait_memberprofile aitMemberprofile = new ait_memberprofile();
      aitMemberprofile.ait_memberprofileId = new Guid?(this.MemberProfileReference.Id);
      foreach (ait_bloodquantum entity in (Collection<Entity>) referencedEntities.Entities)
      {
        bool compareTo = BloodQuantumLibrary.IsBloodQuantumIncludedInTribe((IOrganizationService) this.CrmService, entity);
        Fraction.Parse(entity.ait_bloodquantumfraction);
        totalBloodQuantum += Fraction.Parse(entity.ait_bloodquantumfraction);
        if (compareTo)
          tribalBloodQuantum += Fraction.Parse(entity.ait_bloodquantumfraction);
        if (!AttributeLibrary.Compare(entity.ait_bloodquantumincludedintribe, compareTo))
          this.CrmService.Update((Entity) new ait_bloodquantum()
          {
            ait_bloodquantumId = entity.ait_bloodquantumId,
            ait_bloodquantumincludedintribe = new bool?(compareTo)
          });
      }
      if (totalBloodQuantum > (Fraction) 1L)
        throw new InvalidPluginExecutionException("Total blood quantum cannot be greater than 1.");
      aitMemberprofile.ait_tribalbqfraction = !(tribalBloodQuantum > (Fraction) 1L) ? tribalBloodQuantum.ToString() : throw new InvalidPluginExecutionException("Tribal blood quantum cannot be greater than 1.");
      aitMemberprofile.ait_tribalbqdecimal = new Decimal?((Decimal) tribalBloodQuantum);
      aitMemberprofile.ait_totalbqfraction = totalBloodQuantum.ToString();
      aitMemberprofile.ait_totalbqdecimal = new Decimal?((Decimal) totalBloodQuantum);
      bool flag = BloodQuantumLibrary.IsBloodQuantumThreshholdMet(this.CrmService, tribalBloodQuantum, totalBloodQuantum);
      aitMemberprofile.ait_bqthresholdmet = new bool?(flag);
      this.CrmService.Update((Entity) aitMemberprofile);
      return aitMemberprofile;
    }

    private bool IncludeInTribalBlood(
      MemberBloodQuantumInfoStruct memberBloodQuantumInfo,
      ait_bloodquantum bloodQuantum)
    {
      ait_tribe entity = (ait_tribe) EntityLibrary.GetEntity((IOrganizationService) this.CrmService, bloodQuantum.ait_Tribe);
      int num;
      if (entity.ait_includeintribalbq.HasValue)
      {
        bool? includeintribalbq = entity.ait_includeintribalbq;
        bool flag = true;
        num = includeintribalbq.GetValueOrDefault() == flag & includeintribalbq.HasValue ? 1 : 0;
      }
      else
        num = 0;
      return num != 0 && memberBloodQuantumInfo.TribalBloodQuantum >= this.minimumParentalBQFraction;
    }

    private void ProcessBloodQuantums(
      Dictionary<string, ait_bloodquantum> bloodQuantumDictionary,
      MemberBloodQuantumInfoStruct memberBloodQuantumInfo)
    {
      if (memberBloodQuantumInfo.MemberBloodQuantums == null)
        return;
      foreach (ait_bloodquantum entity in (Collection<Entity>) memberBloodQuantumInfo.MemberBloodQuantums.Entities)
      {
        bool includedInTribalCalculation = this.IncludeInTribalBlood(memberBloodQuantumInfo, entity);
        string key = EntityLibrary.GetEntityName((IOrganizationService) this.CrmService, entity.ait_Tribe) + (includedInTribalCalculation ? ",true" : ",false");
        if (!bloodQuantumDictionary.ContainsKey(key))
        {
          ait_bloodquantum newBloodQuantum = this.CreateNewBloodQuantum(this.MemberProfileReference, entity.ait_Tribe, Fraction.Parse(entity.ait_bloodquantumfraction) / (Fraction) 2L, includedInTribalCalculation);
          bloodQuantumDictionary.Add(key, newBloodQuantum);
        }
        else
        {
          ait_bloodquantum bloodQuantum = bloodQuantumDictionary[key];
          Fraction fraction = Fraction.Parse(bloodQuantum.ait_bloodquantumfraction) + Fraction.Parse(entity.ait_bloodquantumfraction) / (Fraction) 2L;
          bloodQuantum.ait_bloodquantumfraction = fraction.ToString();
          bloodQuantum.ait_bloodquantumdecimal = new Decimal?((Decimal) Fraction.Parse(bloodQuantum.ait_bloodquantumfraction));
        }
      }
    }

    private EntityCollection GetMergedParentBloodQuantums(
      MemberBloodQuantumInfoStruct motherBloodQuantumInfo,
      MemberBloodQuantumInfoStruct fatherBloodQuantumInfo)
    {
      Dictionary<string, ait_bloodquantum> bloodQuantumDictionary = new Dictionary<string, ait_bloodquantum>();
      this.ProcessBloodQuantums(bloodQuantumDictionary, fatherBloodQuantumInfo);
      this.ProcessBloodQuantums(bloodQuantumDictionary, motherBloodQuantumInfo);
      EntityCollection parentBloodQuantums = new EntityCollection();
      foreach (ait_bloodquantum aitBloodquantum in bloodQuantumDictionary.Values)
        ((Collection<Entity>) parentBloodQuantums.Entities).Add((Entity) aitBloodquantum);
      return parentBloodQuantums;
    }

    private ait_bloodquantum CreateNewBloodQuantum(
      EntityReference member,
      EntityReference tribe,
      Fraction bloodFraction,
      bool includedInTribalCalculation)
    {
      return new ait_bloodquantum()
      {
        ait_Tribe = tribe,
        ait_memberprofile = member,
        ait_systemgenerated = new bool?(true),
        ait_bloodquantumfraction = bloodFraction.ToString(),
        ait_bloodquantumdecimal = new Decimal?((Decimal) bloodFraction),
        ait_bloodquantumincludedintribe = new bool?(includedInTribalCalculation)
      };
    }

    public void DeleteAllMemberBloodQuantums()
    {
      EntityCollection referencedEntities = EntityLibrary.GetAllReferencedEntities((IOrganizationService) this.CrmService, "ait_bloodquantum", "ait_memberprofile", this.MemberProfileReference, true);
      if (((Collection<Entity>) referencedEntities.Entities).Count <= 0)
        return;
      FrameworkService frameworkService = this.CrmService.ImpersonateAdmin();
      foreach (ait_bloodquantum entity in (Collection<Entity>) referencedEntities.Entities)
        frameworkService.Delete("ait_bloodquantum", ((Entity) entity).Id);
    }

    private MemberBloodQuantumInfoStruct GetMemberBloodQuantumInfo(EntityReference member)
    {
      MemberBloodQuantumInfoStruct bloodQuantumInfo = new MemberBloodQuantumInfoStruct();
      if (member != null && !Guid.Empty.Equals(member.Id))
      {
        EntityCollection allEntities = EntityLibrary.GetAllEntities((IOrganizationService) this.CrmService, "ait_bloodquantum", "ait_memberprofile", (object) member.Id, true);
        bloodQuantumInfo.MemberBloodQuantums = allEntities;
        bloodQuantumInfo.TribalBloodQuantum = new Fraction(0L);
        bloodQuantumInfo.TotalBloodQuantum = new Fraction(0L);
        ait_memberprofile entity = (ait_memberprofile) EntityLibrary.GetEntity((IOrganizationService) this.CrmService, member);
        bloodQuantumInfo.TribalBloodQuantum = entity.ait_tribalbqfraction != null ? Fraction.Parse(entity.ait_tribalbqfraction) : new Fraction(0L);
        bloodQuantumInfo.TotalBloodQuantum = entity.ait_totalbqfraction != null ? Fraction.Parse(entity.ait_totalbqfraction) : new Fraction(0L);
      }
      return bloodQuantumInfo;
    }

    public static bool IsBloodQuantumIncludedInTribe(
      IOrganizationService crmService,
      ait_bloodquantum memberBloodQuantum)
    {
      bool flag = false;
      ait_tribe entity = (ait_tribe) EntityLibrary.GetEntity(crmService, memberBloodQuantum.ait_Tribe);
      bool? includeintribalbq;
      int num;
      if (entity != null)
      {
        includeintribalbq = entity.ait_includeintribalbq;
        if (includeintribalbq.HasValue)
        {
          includeintribalbq = entity.ait_includeintribalbq;
          num = includeintribalbq.HasValue ? 1 : 0;
          goto label_4;
        }
      }
      num = 0;
label_4:
      if (num != 0)
      {
        includeintribalbq = entity.ait_includeintribalbq;
        flag = includeintribalbq.Value;
      }
      return flag;
    }

    public static bool IsBloodQuantumThreshholdMet(
      FrameworkService crmService,
      Fraction tribalBloodQuantum,
      Fraction totalBloodQuantum)
    {
      bool flag = false;
      switch (TribalEnrollmentConfiguration.GetBloodQuantumCalculationMethod(crmService))
      {
        case ait_bloodquantumcalculationmethod.Tribal:
          flag = tribalBloodQuantum >= Fraction.Parse(TribalEnrollmentConfiguration.GetBloodQuantumMembershipThreshholdFraction(crmService));
          break;
        case ait_bloodquantumcalculationmethod.Total:
          flag = totalBloodQuantum >= Fraction.Parse(TribalEnrollmentConfiguration.GetBloodQuantumMembershipThreshholdFraction(crmService));
          break;
      }
      return flag;
    }
  }
}
