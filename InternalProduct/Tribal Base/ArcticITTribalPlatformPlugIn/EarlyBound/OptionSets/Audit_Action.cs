// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.OptionSets.Audit_Action
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using System.CodeDom.Compiler;
using System.Runtime.Serialization;

#nullable disable
namespace ArcticIT.EarlyBound.OptionSets
{
  [DataContract]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public enum Audit_Action
  {
    [EnumMember] Unknown = 0,
    [EnumMember] Create = 1,
    [EnumMember] Update = 2,
    [EnumMember] Delete = 3,
    [EnumMember] Activate = 4,
    [EnumMember] Deactivate = 5,
    [EnumMember] Cascade = 11, // 0x0000000B
    [EnumMember] Merge = 12, // 0x0000000C
    [EnumMember] Assign = 13, // 0x0000000D
    [EnumMember] Share = 14, // 0x0000000E
    [EnumMember] Retrieve = 15, // 0x0000000F
    [EnumMember] Close = 16, // 0x00000010
    [EnumMember] Cancel = 17, // 0x00000011
    [EnumMember] Complete = 18, // 0x00000012
    [EnumMember] Resolve = 20, // 0x00000014
    [EnumMember] Reopen = 21, // 0x00000015
    [EnumMember] Fulfill = 22, // 0x00000016
    [EnumMember] Paid = 23, // 0x00000017
    [EnumMember] Qualify = 24, // 0x00000018
    [EnumMember] Disqualify = 25, // 0x00000019
    [EnumMember] Submit = 26, // 0x0000001A
    [EnumMember] Reject = 27, // 0x0000001B
    [EnumMember] Approve = 28, // 0x0000001C
    [EnumMember] Invoice = 29, // 0x0000001D
    [EnumMember] Hold = 30, // 0x0000001E
    [EnumMember] AddMember = 31, // 0x0000001F
    [EnumMember] RemoveMember = 32, // 0x00000020
    [EnumMember] AssociateEntities = 33, // 0x00000021
    [EnumMember] DisassociateEntities = 34, // 0x00000022
    [EnumMember] AddMembers = 35, // 0x00000023
    [EnumMember] RemoveMembers = 36, // 0x00000024
    [EnumMember] AddItem = 37, // 0x00000025
    [EnumMember] RemoveItem = 38, // 0x00000026
    [EnumMember] AddSubstitute = 39, // 0x00000027
    [EnumMember] RemoveSubstitute = 40, // 0x00000028
    [EnumMember] SetState = 41, // 0x00000029
    [EnumMember] Renew = 42, // 0x0000002A
    [EnumMember] Revise = 43, // 0x0000002B
    [EnumMember] Win = 44, // 0x0000002C
    [EnumMember] Lose = 45, // 0x0000002D
    [EnumMember] InternalProcessing = 46, // 0x0000002E
    [EnumMember] Reschedule = 47, // 0x0000002F
    [EnumMember] ModifyShare = 48, // 0x00000030
    [EnumMember] Unshare = 49, // 0x00000031
    [EnumMember] Book = 50, // 0x00000032
    [EnumMember] GenerateQuoteFromOpportunity = 51, // 0x00000033
    [EnumMember] AddToQueue = 52, // 0x00000034
    [EnumMember] AssignRoleToTeam = 53, // 0x00000035
    [EnumMember] RemoveRoleFromTeam = 54, // 0x00000036
    [EnumMember] AssignRoleToUser = 55, // 0x00000037
    [EnumMember] RemoveRoleFromUser = 56, // 0x00000038
    [EnumMember] AddPrivilegestoRole = 57, // 0x00000039
    [EnumMember] RemovePrivilegesFromRole = 58, // 0x0000003A
    [EnumMember] ReplacePrivilegesInRole = 59, // 0x0000003B
    [EnumMember] ImportMappings = 60, // 0x0000003C
    [EnumMember] Clone = 61, // 0x0000003D
    [EnumMember] SendDirectEmail = 62, // 0x0000003E
    [EnumMember] Enabledfororganization = 63, // 0x0000003F
    [EnumMember] UserAccessviaWeb = 64, // 0x00000040
    [EnumMember] UserAccessviaWebServices = 65, // 0x00000041
    [EnumMember] DeleteEntity = 100, // 0x00000064
    [EnumMember] DeleteAttribute = 101, // 0x00000065
    [EnumMember] AuditChangeatEntityLevel = 102, // 0x00000066
    [EnumMember] AuditChangeatAttributeLevel = 103, // 0x00000067
    [EnumMember] AuditChangeatOrgLevel = 104, // 0x00000068
    [EnumMember] EntityAuditStarted = 105, // 0x00000069
    [EnumMember] AttributeAuditStarted = 106, // 0x0000006A
    [EnumMember] AuditEnabled = 107, // 0x0000006B
    [EnumMember] EntityAuditStopped = 108, // 0x0000006C
    [EnumMember] AttributeAuditStopped = 109, // 0x0000006D
    [EnumMember] AuditDisabled = 110, // 0x0000006E
    [EnumMember] AuditLogDeletion = 111, // 0x0000006F
    [EnumMember] UserAccessAuditStarted = 112, // 0x00000070
    [EnumMember] UserAccessAuditStopped = 113, // 0x00000071
  }
}
