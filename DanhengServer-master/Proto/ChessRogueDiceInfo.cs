// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChessRogueDiceInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ChessRogueDiceInfo.proto</summary>
  public static partial class ChessRogueDiceInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for ChessRogueDiceInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChessRogueDiceInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhDaGVzc1JvZ3VlRGljZUluZm8ucHJvdG8aGkNoZXNzUm9ndWVEaWNlU3Rh",
            "dHVzLnByb3RvGhhDaGVzc1JvZ3VlRGljZVR5cGUucHJvdG8aFENoZXNzUm9n",
            "dWVEaWNlLnByb3RvGhNSb2d1ZU1vZGlmaWVyLnByb3RvGhFFQk9JT0lLRkxG",
            "Si5wcm90byLvAwoSQ2hlc3NSb2d1ZURpY2VJbmZvEhQKC09KQ01HT0lMRkNG",
            "GJYEIAEoBRIWCg5jdXJfc3VyZmFjZV9pZBgDIAEoDRIUCgxpc19hdmFpbGFi",
            "bGUYASABKAgSGwoTY3VyX3N1cmZhY2Vfc2xvdF9pZBgHIAEoDRIbChNnYW1l",
            "X2RpY2VfYnJhbmNoX2lkGA4gASgNEiYKDWRpY2VfbW9kaWZpZXIY4QsgASgL",
            "Mg4uUm9ndWVNb2RpZmllchIUCgxyZXJvbGxfdGltZXMYDCABKA0SJgoJZGlj",
            "ZV90eXBlGAUgASgOMhMuQ2hlc3NSb2d1ZURpY2VUeXBlEhYKDmdhbWVfYnJh",
            "bmNoX2lkGAYgASgNEhMKC0NGSEhOTU1NSUhNGA0gASgNEh4KBGRpY2UYtgsg",
            "ASgLMg8uQ2hlc3NSb2d1ZURpY2USGAoPY2FuX3Jlcm9sbF9kaWNlGPUNIAEo",
            "CBIiCgtPTEdBT0lCR0NISBifDSABKAsyDC5FQk9JT0lLRkxGShIUCgtIRUxO",
            "R0ROS0NMRBimCSADKA0SKgoLZGljZV9zdGF0dXMYCyABKA4yFS5DaGVzc1Jv",
            "Z3VlRGljZVN0YXR1cxITCgtGSU9FQ0pNQ0tBTRgKIAEoDRITCgtjaGVhdF90",
            "aW1lcxgPIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ChessRogueDiceStatusReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChessRogueDiceTypeReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChessRogueDiceReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueModifierReflection.Descriptor, global::EggLink.DanhengServer.Proto.EBOIOIKFLFJReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ChessRogueDiceInfo), global::EggLink.DanhengServer.Proto.ChessRogueDiceInfo.Parser, new[]{ "OJCMGOILFCF", "CurSurfaceId", "IsAvailable", "CurSurfaceSlotId", "GameDiceBranchId", "DiceModifier", "RerollTimes", "DiceType", "GameBranchId", "CFHHNMMMIHM", "Dice", "CanRerollDice", "OLGAOIBGCHH", "HELNGDNKCLD", "DiceStatus", "FIOECJMCKAM", "CheatTimes" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ChessRogueDiceInfo : pb::IMessage<ChessRogueDiceInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChessRogueDiceInfo> _parser = new pb::MessageParser<ChessRogueDiceInfo>(() => new ChessRogueDiceInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChessRogueDiceInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ChessRogueDiceInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueDiceInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueDiceInfo(ChessRogueDiceInfo other) : this() {
      oJCMGOILFCF_ = other.oJCMGOILFCF_;
      curSurfaceId_ = other.curSurfaceId_;
      isAvailable_ = other.isAvailable_;
      curSurfaceSlotId_ = other.curSurfaceSlotId_;
      gameDiceBranchId_ = other.gameDiceBranchId_;
      diceModifier_ = other.diceModifier_ != null ? other.diceModifier_.Clone() : null;
      rerollTimes_ = other.rerollTimes_;
      diceType_ = other.diceType_;
      gameBranchId_ = other.gameBranchId_;
      cFHHNMMMIHM_ = other.cFHHNMMMIHM_;
      dice_ = other.dice_ != null ? other.dice_.Clone() : null;
      canRerollDice_ = other.canRerollDice_;
      oLGAOIBGCHH_ = other.oLGAOIBGCHH_ != null ? other.oLGAOIBGCHH_.Clone() : null;
      hELNGDNKCLD_ = other.hELNGDNKCLD_.Clone();
      diceStatus_ = other.diceStatus_;
      fIOECJMCKAM_ = other.fIOECJMCKAM_;
      cheatTimes_ = other.cheatTimes_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueDiceInfo Clone() {
      return new ChessRogueDiceInfo(this);
    }

    /// <summary>Field number for the "OJCMGOILFCF" field.</summary>
    public const int OJCMGOILFCFFieldNumber = 534;
    private int oJCMGOILFCF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int OJCMGOILFCF {
      get { return oJCMGOILFCF_; }
      set {
        oJCMGOILFCF_ = value;
      }
    }

    /// <summary>Field number for the "cur_surface_id" field.</summary>
    public const int CurSurfaceIdFieldNumber = 3;
    private uint curSurfaceId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurSurfaceId {
      get { return curSurfaceId_; }
      set {
        curSurfaceId_ = value;
      }
    }

    /// <summary>Field number for the "is_available" field.</summary>
    public const int IsAvailableFieldNumber = 1;
    private bool isAvailable_;
    /// <summary>
    /// 1781
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsAvailable {
      get { return isAvailable_; }
      set {
        isAvailable_ = value;
      }
    }

    /// <summary>Field number for the "cur_surface_slot_id" field.</summary>
    public const int CurSurfaceSlotIdFieldNumber = 7;
    private uint curSurfaceSlotId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurSurfaceSlotId {
      get { return curSurfaceSlotId_; }
      set {
        curSurfaceSlotId_ = value;
      }
    }

    /// <summary>Field number for the "game_dice_branch_id" field.</summary>
    public const int GameDiceBranchIdFieldNumber = 14;
    private uint gameDiceBranchId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GameDiceBranchId {
      get { return gameDiceBranchId_; }
      set {
        gameDiceBranchId_ = value;
      }
    }

    /// <summary>Field number for the "dice_modifier" field.</summary>
    public const int DiceModifierFieldNumber = 1505;
    private global::EggLink.DanhengServer.Proto.RogueModifier diceModifier_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueModifier DiceModifier {
      get { return diceModifier_; }
      set {
        diceModifier_ = value;
      }
    }

    /// <summary>Field number for the "reroll_times" field.</summary>
    public const int RerollTimesFieldNumber = 12;
    private uint rerollTimes_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RerollTimes {
      get { return rerollTimes_; }
      set {
        rerollTimes_ = value;
      }
    }

    /// <summary>Field number for the "dice_type" field.</summary>
    public const int DiceTypeFieldNumber = 5;
    private global::EggLink.DanhengServer.Proto.ChessRogueDiceType diceType_ = global::EggLink.DanhengServer.Proto.ChessRogueDiceType.ChessRogueDiceFixed;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueDiceType DiceType {
      get { return diceType_; }
      set {
        diceType_ = value;
      }
    }

    /// <summary>Field number for the "game_branch_id" field.</summary>
    public const int GameBranchIdFieldNumber = 6;
    private uint gameBranchId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GameBranchId {
      get { return gameBranchId_; }
      set {
        gameBranchId_ = value;
      }
    }

    /// <summary>Field number for the "CFHHNMMMIHM" field.</summary>
    public const int CFHHNMMMIHMFieldNumber = 13;
    private uint cFHHNMMMIHM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CFHHNMMMIHM {
      get { return cFHHNMMMIHM_; }
      set {
        cFHHNMMMIHM_ = value;
      }
    }

    /// <summary>Field number for the "dice" field.</summary>
    public const int DiceFieldNumber = 1462;
    private global::EggLink.DanhengServer.Proto.ChessRogueDice dice_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueDice Dice {
      get { return dice_; }
      set {
        dice_ = value;
      }
    }

    /// <summary>Field number for the "can_reroll_dice" field.</summary>
    public const int CanRerollDiceFieldNumber = 1781;
    private bool canRerollDice_;
    /// <summary>
    /// 1
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool CanRerollDice {
      get { return canRerollDice_; }
      set {
        canRerollDice_ = value;
      }
    }

    /// <summary>Field number for the "OLGAOIBGCHH" field.</summary>
    public const int OLGAOIBGCHHFieldNumber = 1695;
    private global::EggLink.DanhengServer.Proto.EBOIOIKFLFJ oLGAOIBGCHH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.EBOIOIKFLFJ OLGAOIBGCHH {
      get { return oLGAOIBGCHH_; }
      set {
        oLGAOIBGCHH_ = value;
      }
    }

    /// <summary>Field number for the "HELNGDNKCLD" field.</summary>
    public const int HELNGDNKCLDFieldNumber = 1190;
    private static readonly pb::FieldCodec<uint> _repeated_hELNGDNKCLD_codec
        = pb::FieldCodec.ForUInt32(9522);
    private readonly pbc::RepeatedField<uint> hELNGDNKCLD_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> HELNGDNKCLD {
      get { return hELNGDNKCLD_; }
    }

    /// <summary>Field number for the "dice_status" field.</summary>
    public const int DiceStatusFieldNumber = 11;
    private global::EggLink.DanhengServer.Proto.ChessRogueDiceStatus diceStatus_ = global::EggLink.DanhengServer.Proto.ChessRogueDiceStatus.ChessRogueDiceIdle;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueDiceStatus DiceStatus {
      get { return diceStatus_; }
      set {
        diceStatus_ = value;
      }
    }

    /// <summary>Field number for the "FIOECJMCKAM" field.</summary>
    public const int FIOECJMCKAMFieldNumber = 10;
    private uint fIOECJMCKAM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FIOECJMCKAM {
      get { return fIOECJMCKAM_; }
      set {
        fIOECJMCKAM_ = value;
      }
    }

    /// <summary>Field number for the "cheat_times" field.</summary>
    public const int CheatTimesFieldNumber = 15;
    private uint cheatTimes_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CheatTimes {
      get { return cheatTimes_; }
      set {
        cheatTimes_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChessRogueDiceInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChessRogueDiceInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (OJCMGOILFCF != other.OJCMGOILFCF) return false;
      if (CurSurfaceId != other.CurSurfaceId) return false;
      if (IsAvailable != other.IsAvailable) return false;
      if (CurSurfaceSlotId != other.CurSurfaceSlotId) return false;
      if (GameDiceBranchId != other.GameDiceBranchId) return false;
      if (!object.Equals(DiceModifier, other.DiceModifier)) return false;
      if (RerollTimes != other.RerollTimes) return false;
      if (DiceType != other.DiceType) return false;
      if (GameBranchId != other.GameBranchId) return false;
      if (CFHHNMMMIHM != other.CFHHNMMMIHM) return false;
      if (!object.Equals(Dice, other.Dice)) return false;
      if (CanRerollDice != other.CanRerollDice) return false;
      if (!object.Equals(OLGAOIBGCHH, other.OLGAOIBGCHH)) return false;
      if(!hELNGDNKCLD_.Equals(other.hELNGDNKCLD_)) return false;
      if (DiceStatus != other.DiceStatus) return false;
      if (FIOECJMCKAM != other.FIOECJMCKAM) return false;
      if (CheatTimes != other.CheatTimes) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (OJCMGOILFCF != 0) hash ^= OJCMGOILFCF.GetHashCode();
      if (CurSurfaceId != 0) hash ^= CurSurfaceId.GetHashCode();
      if (IsAvailable != false) hash ^= IsAvailable.GetHashCode();
      if (CurSurfaceSlotId != 0) hash ^= CurSurfaceSlotId.GetHashCode();
      if (GameDiceBranchId != 0) hash ^= GameDiceBranchId.GetHashCode();
      if (diceModifier_ != null) hash ^= DiceModifier.GetHashCode();
      if (RerollTimes != 0) hash ^= RerollTimes.GetHashCode();
      if (DiceType != global::EggLink.DanhengServer.Proto.ChessRogueDiceType.ChessRogueDiceFixed) hash ^= DiceType.GetHashCode();
      if (GameBranchId != 0) hash ^= GameBranchId.GetHashCode();
      if (CFHHNMMMIHM != 0) hash ^= CFHHNMMMIHM.GetHashCode();
      if (dice_ != null) hash ^= Dice.GetHashCode();
      if (CanRerollDice != false) hash ^= CanRerollDice.GetHashCode();
      if (oLGAOIBGCHH_ != null) hash ^= OLGAOIBGCHH.GetHashCode();
      hash ^= hELNGDNKCLD_.GetHashCode();
      if (DiceStatus != global::EggLink.DanhengServer.Proto.ChessRogueDiceStatus.ChessRogueDiceIdle) hash ^= DiceStatus.GetHashCode();
      if (FIOECJMCKAM != 0) hash ^= FIOECJMCKAM.GetHashCode();
      if (CheatTimes != 0) hash ^= CheatTimes.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (IsAvailable != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsAvailable);
      }
      if (CurSurfaceId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(CurSurfaceId);
      }
      if (DiceType != global::EggLink.DanhengServer.Proto.ChessRogueDiceType.ChessRogueDiceFixed) {
        output.WriteRawTag(40);
        output.WriteEnum((int) DiceType);
      }
      if (GameBranchId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(GameBranchId);
      }
      if (CurSurfaceSlotId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(CurSurfaceSlotId);
      }
      if (FIOECJMCKAM != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(FIOECJMCKAM);
      }
      if (DiceStatus != global::EggLink.DanhengServer.Proto.ChessRogueDiceStatus.ChessRogueDiceIdle) {
        output.WriteRawTag(88);
        output.WriteEnum((int) DiceStatus);
      }
      if (RerollTimes != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(RerollTimes);
      }
      if (CFHHNMMMIHM != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(CFHHNMMMIHM);
      }
      if (GameDiceBranchId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(GameDiceBranchId);
      }
      if (CheatTimes != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(CheatTimes);
      }
      if (OJCMGOILFCF != 0) {
        output.WriteRawTag(176, 33);
        output.WriteInt32(OJCMGOILFCF);
      }
      hELNGDNKCLD_.WriteTo(output, _repeated_hELNGDNKCLD_codec);
      if (dice_ != null) {
        output.WriteRawTag(178, 91);
        output.WriteMessage(Dice);
      }
      if (diceModifier_ != null) {
        output.WriteRawTag(138, 94);
        output.WriteMessage(DiceModifier);
      }
      if (oLGAOIBGCHH_ != null) {
        output.WriteRawTag(250, 105);
        output.WriteMessage(OLGAOIBGCHH);
      }
      if (CanRerollDice != false) {
        output.WriteRawTag(168, 111);
        output.WriteBool(CanRerollDice);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (IsAvailable != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsAvailable);
      }
      if (CurSurfaceId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(CurSurfaceId);
      }
      if (DiceType != global::EggLink.DanhengServer.Proto.ChessRogueDiceType.ChessRogueDiceFixed) {
        output.WriteRawTag(40);
        output.WriteEnum((int) DiceType);
      }
      if (GameBranchId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(GameBranchId);
      }
      if (CurSurfaceSlotId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(CurSurfaceSlotId);
      }
      if (FIOECJMCKAM != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(FIOECJMCKAM);
      }
      if (DiceStatus != global::EggLink.DanhengServer.Proto.ChessRogueDiceStatus.ChessRogueDiceIdle) {
        output.WriteRawTag(88);
        output.WriteEnum((int) DiceStatus);
      }
      if (RerollTimes != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(RerollTimes);
      }
      if (CFHHNMMMIHM != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(CFHHNMMMIHM);
      }
      if (GameDiceBranchId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(GameDiceBranchId);
      }
      if (CheatTimes != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(CheatTimes);
      }
      if (OJCMGOILFCF != 0) {
        output.WriteRawTag(176, 33);
        output.WriteInt32(OJCMGOILFCF);
      }
      hELNGDNKCLD_.WriteTo(ref output, _repeated_hELNGDNKCLD_codec);
      if (dice_ != null) {
        output.WriteRawTag(178, 91);
        output.WriteMessage(Dice);
      }
      if (diceModifier_ != null) {
        output.WriteRawTag(138, 94);
        output.WriteMessage(DiceModifier);
      }
      if (oLGAOIBGCHH_ != null) {
        output.WriteRawTag(250, 105);
        output.WriteMessage(OLGAOIBGCHH);
      }
      if (CanRerollDice != false) {
        output.WriteRawTag(168, 111);
        output.WriteBool(CanRerollDice);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (OJCMGOILFCF != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(OJCMGOILFCF);
      }
      if (CurSurfaceId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurSurfaceId);
      }
      if (IsAvailable != false) {
        size += 1 + 1;
      }
      if (CurSurfaceSlotId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurSurfaceSlotId);
      }
      if (GameDiceBranchId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GameDiceBranchId);
      }
      if (diceModifier_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(DiceModifier);
      }
      if (RerollTimes != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RerollTimes);
      }
      if (DiceType != global::EggLink.DanhengServer.Proto.ChessRogueDiceType.ChessRogueDiceFixed) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) DiceType);
      }
      if (GameBranchId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GameBranchId);
      }
      if (CFHHNMMMIHM != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CFHHNMMMIHM);
      }
      if (dice_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(Dice);
      }
      if (CanRerollDice != false) {
        size += 2 + 1;
      }
      if (oLGAOIBGCHH_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(OLGAOIBGCHH);
      }
      size += hELNGDNKCLD_.CalculateSize(_repeated_hELNGDNKCLD_codec);
      if (DiceStatus != global::EggLink.DanhengServer.Proto.ChessRogueDiceStatus.ChessRogueDiceIdle) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) DiceStatus);
      }
      if (FIOECJMCKAM != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FIOECJMCKAM);
      }
      if (CheatTimes != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CheatTimes);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChessRogueDiceInfo other) {
      if (other == null) {
        return;
      }
      if (other.OJCMGOILFCF != 0) {
        OJCMGOILFCF = other.OJCMGOILFCF;
      }
      if (other.CurSurfaceId != 0) {
        CurSurfaceId = other.CurSurfaceId;
      }
      if (other.IsAvailable != false) {
        IsAvailable = other.IsAvailable;
      }
      if (other.CurSurfaceSlotId != 0) {
        CurSurfaceSlotId = other.CurSurfaceSlotId;
      }
      if (other.GameDiceBranchId != 0) {
        GameDiceBranchId = other.GameDiceBranchId;
      }
      if (other.diceModifier_ != null) {
        if (diceModifier_ == null) {
          DiceModifier = new global::EggLink.DanhengServer.Proto.RogueModifier();
        }
        DiceModifier.MergeFrom(other.DiceModifier);
      }
      if (other.RerollTimes != 0) {
        RerollTimes = other.RerollTimes;
      }
      if (other.DiceType != global::EggLink.DanhengServer.Proto.ChessRogueDiceType.ChessRogueDiceFixed) {
        DiceType = other.DiceType;
      }
      if (other.GameBranchId != 0) {
        GameBranchId = other.GameBranchId;
      }
      if (other.CFHHNMMMIHM != 0) {
        CFHHNMMMIHM = other.CFHHNMMMIHM;
      }
      if (other.dice_ != null) {
        if (dice_ == null) {
          Dice = new global::EggLink.DanhengServer.Proto.ChessRogueDice();
        }
        Dice.MergeFrom(other.Dice);
      }
      if (other.CanRerollDice != false) {
        CanRerollDice = other.CanRerollDice;
      }
      if (other.oLGAOIBGCHH_ != null) {
        if (oLGAOIBGCHH_ == null) {
          OLGAOIBGCHH = new global::EggLink.DanhengServer.Proto.EBOIOIKFLFJ();
        }
        OLGAOIBGCHH.MergeFrom(other.OLGAOIBGCHH);
      }
      hELNGDNKCLD_.Add(other.hELNGDNKCLD_);
      if (other.DiceStatus != global::EggLink.DanhengServer.Proto.ChessRogueDiceStatus.ChessRogueDiceIdle) {
        DiceStatus = other.DiceStatus;
      }
      if (other.FIOECJMCKAM != 0) {
        FIOECJMCKAM = other.FIOECJMCKAM;
      }
      if (other.CheatTimes != 0) {
        CheatTimes = other.CheatTimes;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            IsAvailable = input.ReadBool();
            break;
          }
          case 24: {
            CurSurfaceId = input.ReadUInt32();
            break;
          }
          case 40: {
            DiceType = (global::EggLink.DanhengServer.Proto.ChessRogueDiceType) input.ReadEnum();
            break;
          }
          case 48: {
            GameBranchId = input.ReadUInt32();
            break;
          }
          case 56: {
            CurSurfaceSlotId = input.ReadUInt32();
            break;
          }
          case 80: {
            FIOECJMCKAM = input.ReadUInt32();
            break;
          }
          case 88: {
            DiceStatus = (global::EggLink.DanhengServer.Proto.ChessRogueDiceStatus) input.ReadEnum();
            break;
          }
          case 96: {
            RerollTimes = input.ReadUInt32();
            break;
          }
          case 104: {
            CFHHNMMMIHM = input.ReadUInt32();
            break;
          }
          case 112: {
            GameDiceBranchId = input.ReadUInt32();
            break;
          }
          case 120: {
            CheatTimes = input.ReadUInt32();
            break;
          }
          case 4272: {
            OJCMGOILFCF = input.ReadInt32();
            break;
          }
          case 9522:
          case 9520: {
            hELNGDNKCLD_.AddEntriesFrom(input, _repeated_hELNGDNKCLD_codec);
            break;
          }
          case 11698: {
            if (dice_ == null) {
              Dice = new global::EggLink.DanhengServer.Proto.ChessRogueDice();
            }
            input.ReadMessage(Dice);
            break;
          }
          case 12042: {
            if (diceModifier_ == null) {
              DiceModifier = new global::EggLink.DanhengServer.Proto.RogueModifier();
            }
            input.ReadMessage(DiceModifier);
            break;
          }
          case 13562: {
            if (oLGAOIBGCHH_ == null) {
              OLGAOIBGCHH = new global::EggLink.DanhengServer.Proto.EBOIOIKFLFJ();
            }
            input.ReadMessage(OLGAOIBGCHH);
            break;
          }
          case 14248: {
            CanRerollDice = input.ReadBool();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            IsAvailable = input.ReadBool();
            break;
          }
          case 24: {
            CurSurfaceId = input.ReadUInt32();
            break;
          }
          case 40: {
            DiceType = (global::EggLink.DanhengServer.Proto.ChessRogueDiceType) input.ReadEnum();
            break;
          }
          case 48: {
            GameBranchId = input.ReadUInt32();
            break;
          }
          case 56: {
            CurSurfaceSlotId = input.ReadUInt32();
            break;
          }
          case 80: {
            FIOECJMCKAM = input.ReadUInt32();
            break;
          }
          case 88: {
            DiceStatus = (global::EggLink.DanhengServer.Proto.ChessRogueDiceStatus) input.ReadEnum();
            break;
          }
          case 96: {
            RerollTimes = input.ReadUInt32();
            break;
          }
          case 104: {
            CFHHNMMMIHM = input.ReadUInt32();
            break;
          }
          case 112: {
            GameDiceBranchId = input.ReadUInt32();
            break;
          }
          case 120: {
            CheatTimes = input.ReadUInt32();
            break;
          }
          case 4272: {
            OJCMGOILFCF = input.ReadInt32();
            break;
          }
          case 9522:
          case 9520: {
            hELNGDNKCLD_.AddEntriesFrom(ref input, _repeated_hELNGDNKCLD_codec);
            break;
          }
          case 11698: {
            if (dice_ == null) {
              Dice = new global::EggLink.DanhengServer.Proto.ChessRogueDice();
            }
            input.ReadMessage(Dice);
            break;
          }
          case 12042: {
            if (diceModifier_ == null) {
              DiceModifier = new global::EggLink.DanhengServer.Proto.RogueModifier();
            }
            input.ReadMessage(DiceModifier);
            break;
          }
          case 13562: {
            if (oLGAOIBGCHH_ == null) {
              OLGAOIBGCHH = new global::EggLink.DanhengServer.Proto.EBOIOIKFLFJ();
            }
            input.ReadMessage(OLGAOIBGCHH);
            break;
          }
          case 14248: {
            CanRerollDice = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
