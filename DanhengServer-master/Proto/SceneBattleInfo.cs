// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneBattleInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SceneBattleInfo.proto</summary>
  public static partial class SceneBattleInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for SceneBattleInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SceneBattleInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVTY2VuZUJhdHRsZUluZm8ucHJvdG8aGkJhdHRsZVJvZ3VlTWFnaWNJbmZv",
            "LnByb3RvGhtFdm9sdmVCdWlsZEJhdHRsZUluZm8ucHJvdG8aEEJhdHRsZUJ1",
            "ZmYucHJvdG8aG0JhdHRsZUV2ZW50QmF0dGxlSW5mby5wcm90bxoWQmF0dGxl",
            "VGFyZ2V0TGlzdC5wcm90bxoRTk1LQUVDRE1IT1AucHJvdG8aFlNjZW5lTW9u",
            "c3RlcldhdmUucHJvdG8aEkJhdHRsZUF2YXRhci5wcm90bxoRT0xHS0pETE1F",
            "SU8ucHJvdG8ijgUKD1NjZW5lQmF0dGxlSW5mbxITCgt3b3JsZF9sZXZlbBgB",
            "IAEoDRItCgxiYXR0bGVfZXZlbnQYoAcgAygLMhYuQmF0dGxlRXZlbnRCYXR0",
            "bGVJbmZvEh4KCWJ1ZmZfbGlzdBgNIAMoCzILLkJhdHRsZUJ1ZmYSLAoLQURB",
            "RkFPSEZMTUEYtwggASgLMhYuRXZvbHZlQnVpbGRCYXR0bGVJbmZvEhMKC05C",
            "R09HSkpPSk1BGAMgASgIEhEKCWJhdHRsZV9pZBgJIAEoDRIQCghzdGFnZV9p",
            "ZBgPIAEoDRIUCgxyb3VuZHNfbGltaXQYDiABKA0SLAoRbW9uc3Rlcl93YXZl",
            "X2xpc3QYBCADKAsyES5TY2VuZU1vbnN0ZXJXYXZlEjcKF2JhdHRsZV9yb2d1",
            "ZV9tYWdpY19pbmZvGMkPIAEoCzIVLkJhdHRsZVJvZ3VlTWFnaWNJbmZvEikK",
            "EmJhdHRsZV9hdmF0YXJfbGlzdBgKIAMoCzINLkJhdHRsZUF2YXRhchIiCgtH",
            "RERBTENHT09CRxicBiABKAsyDC5PTEdLSkRMTUVJTxJDChJiYXR0bGVfdGFy",
            "Z2V0X2luZm8YsA4gAygLMiYuU2NlbmVCYXR0bGVJbmZvLkJhdHRsZVRhcmdl",
            "dEluZm9FbnRyeRIZChFsb2dpY19yYW5kb21fc2VlZBgMIAEoDRITCgtNQUtJ",
            "R0ZFTUtOTRgFIAEoDRIiCgtJR1BJUE5BQUVCShigDiABKAsyDC5OTUtBRUNE",
            "TUhPUBpKChVCYXR0bGVUYXJnZXRJbmZvRW50cnkSCwoDa2V5GAEgASgNEiAK",
            "BXZhbHVlGAIgASgLMhEuQmF0dGxlVGFyZ2V0TGlzdDoCOAFCHqoCG0VnZ0xp",
            "bmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.BattleRogueMagicInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.EvolveBuildBattleInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.BattleBuffReflection.Descriptor, global::EggLink.DanhengServer.Proto.BattleEventBattleInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.BattleTargetListReflection.Descriptor, global::EggLink.DanhengServer.Proto.NMKAECDMHOPReflection.Descriptor, global::EggLink.DanhengServer.Proto.SceneMonsterWaveReflection.Descriptor, global::EggLink.DanhengServer.Proto.BattleAvatarReflection.Descriptor, global::EggLink.DanhengServer.Proto.OLGKJDLMEIOReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SceneBattleInfo), global::EggLink.DanhengServer.Proto.SceneBattleInfo.Parser, new[]{ "WorldLevel", "BattleEvent", "BuffList", "ADAFAOHFLMA", "NBGOGJJOJMA", "BattleId", "StageId", "RoundsLimit", "MonsterWaveList", "BattleRogueMagicInfo", "BattleAvatarList", "GDDALCGOOBG", "BattleTargetInfo", "LogicRandomSeed", "MAKIGFEMKNM", "IGPIPNAAEBJ" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SceneBattleInfo : pb::IMessage<SceneBattleInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SceneBattleInfo> _parser = new pb::MessageParser<SceneBattleInfo>(() => new SceneBattleInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SceneBattleInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.SceneBattleInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneBattleInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneBattleInfo(SceneBattleInfo other) : this() {
      worldLevel_ = other.worldLevel_;
      battleEvent_ = other.battleEvent_.Clone();
      buffList_ = other.buffList_.Clone();
      aDAFAOHFLMA_ = other.aDAFAOHFLMA_ != null ? other.aDAFAOHFLMA_.Clone() : null;
      nBGOGJJOJMA_ = other.nBGOGJJOJMA_;
      battleId_ = other.battleId_;
      stageId_ = other.stageId_;
      roundsLimit_ = other.roundsLimit_;
      monsterWaveList_ = other.monsterWaveList_.Clone();
      battleRogueMagicInfo_ = other.battleRogueMagicInfo_ != null ? other.battleRogueMagicInfo_.Clone() : null;
      battleAvatarList_ = other.battleAvatarList_.Clone();
      gDDALCGOOBG_ = other.gDDALCGOOBG_ != null ? other.gDDALCGOOBG_.Clone() : null;
      battleTargetInfo_ = other.battleTargetInfo_.Clone();
      logicRandomSeed_ = other.logicRandomSeed_;
      mAKIGFEMKNM_ = other.mAKIGFEMKNM_;
      iGPIPNAAEBJ_ = other.iGPIPNAAEBJ_ != null ? other.iGPIPNAAEBJ_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneBattleInfo Clone() {
      return new SceneBattleInfo(this);
    }

    /// <summary>Field number for the "world_level" field.</summary>
    public const int WorldLevelFieldNumber = 1;
    private uint worldLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WorldLevel {
      get { return worldLevel_; }
      set {
        worldLevel_ = value;
      }
    }

    /// <summary>Field number for the "battle_event" field.</summary>
    public const int BattleEventFieldNumber = 928;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.BattleEventBattleInfo> _repeated_battleEvent_codec
        = pb::FieldCodec.ForMessage(7426, global::EggLink.DanhengServer.Proto.BattleEventBattleInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BattleEventBattleInfo> battleEvent_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BattleEventBattleInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BattleEventBattleInfo> BattleEvent {
      get { return battleEvent_; }
    }

    /// <summary>Field number for the "buff_list" field.</summary>
    public const int BuffListFieldNumber = 13;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.BattleBuff> _repeated_buffList_codec
        = pb::FieldCodec.ForMessage(106, global::EggLink.DanhengServer.Proto.BattleBuff.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BattleBuff> buffList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BattleBuff>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BattleBuff> BuffList {
      get { return buffList_; }
    }

    /// <summary>Field number for the "ADAFAOHFLMA" field.</summary>
    public const int ADAFAOHFLMAFieldNumber = 1079;
    private global::EggLink.DanhengServer.Proto.EvolveBuildBattleInfo aDAFAOHFLMA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.EvolveBuildBattleInfo ADAFAOHFLMA {
      get { return aDAFAOHFLMA_; }
      set {
        aDAFAOHFLMA_ = value;
      }
    }

    /// <summary>Field number for the "NBGOGJJOJMA" field.</summary>
    public const int NBGOGJJOJMAFieldNumber = 3;
    private bool nBGOGJJOJMA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool NBGOGJJOJMA {
      get { return nBGOGJJOJMA_; }
      set {
        nBGOGJJOJMA_ = value;
      }
    }

    /// <summary>Field number for the "battle_id" field.</summary>
    public const int BattleIdFieldNumber = 9;
    private uint battleId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BattleId {
      get { return battleId_; }
      set {
        battleId_ = value;
      }
    }

    /// <summary>Field number for the "stage_id" field.</summary>
    public const int StageIdFieldNumber = 15;
    private uint stageId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StageId {
      get { return stageId_; }
      set {
        stageId_ = value;
      }
    }

    /// <summary>Field number for the "rounds_limit" field.</summary>
    public const int RoundsLimitFieldNumber = 14;
    private uint roundsLimit_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RoundsLimit {
      get { return roundsLimit_; }
      set {
        roundsLimit_ = value;
      }
    }

    /// <summary>Field number for the "monster_wave_list" field.</summary>
    public const int MonsterWaveListFieldNumber = 4;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.SceneMonsterWave> _repeated_monsterWaveList_codec
        = pb::FieldCodec.ForMessage(34, global::EggLink.DanhengServer.Proto.SceneMonsterWave.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SceneMonsterWave> monsterWaveList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SceneMonsterWave>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SceneMonsterWave> MonsterWaveList {
      get { return monsterWaveList_; }
    }

    /// <summary>Field number for the "battle_rogue_magic_info" field.</summary>
    public const int BattleRogueMagicInfoFieldNumber = 1993;
    private global::EggLink.DanhengServer.Proto.BattleRogueMagicInfo battleRogueMagicInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.BattleRogueMagicInfo BattleRogueMagicInfo {
      get { return battleRogueMagicInfo_; }
      set {
        battleRogueMagicInfo_ = value;
      }
    }

    /// <summary>Field number for the "battle_avatar_list" field.</summary>
    public const int BattleAvatarListFieldNumber = 10;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.BattleAvatar> _repeated_battleAvatarList_codec
        = pb::FieldCodec.ForMessage(82, global::EggLink.DanhengServer.Proto.BattleAvatar.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BattleAvatar> battleAvatarList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BattleAvatar>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BattleAvatar> BattleAvatarList {
      get { return battleAvatarList_; }
    }

    /// <summary>Field number for the "GDDALCGOOBG" field.</summary>
    public const int GDDALCGOOBGFieldNumber = 796;
    private global::EggLink.DanhengServer.Proto.OLGKJDLMEIO gDDALCGOOBG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.OLGKJDLMEIO GDDALCGOOBG {
      get { return gDDALCGOOBG_; }
      set {
        gDDALCGOOBG_ = value;
      }
    }

    /// <summary>Field number for the "battle_target_info" field.</summary>
    public const int BattleTargetInfoFieldNumber = 1840;
    private static readonly pbc::MapField<uint, global::EggLink.DanhengServer.Proto.BattleTargetList>.Codec _map_battleTargetInfo_codec
        = new pbc::MapField<uint, global::EggLink.DanhengServer.Proto.BattleTargetList>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForMessage(18, global::EggLink.DanhengServer.Proto.BattleTargetList.Parser), 14722);
    private readonly pbc::MapField<uint, global::EggLink.DanhengServer.Proto.BattleTargetList> battleTargetInfo_ = new pbc::MapField<uint, global::EggLink.DanhengServer.Proto.BattleTargetList>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, global::EggLink.DanhengServer.Proto.BattleTargetList> BattleTargetInfo {
      get { return battleTargetInfo_; }
    }

    /// <summary>Field number for the "logic_random_seed" field.</summary>
    public const int LogicRandomSeedFieldNumber = 12;
    private uint logicRandomSeed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LogicRandomSeed {
      get { return logicRandomSeed_; }
      set {
        logicRandomSeed_ = value;
      }
    }

    /// <summary>Field number for the "MAKIGFEMKNM" field.</summary>
    public const int MAKIGFEMKNMFieldNumber = 5;
    private uint mAKIGFEMKNM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MAKIGFEMKNM {
      get { return mAKIGFEMKNM_; }
      set {
        mAKIGFEMKNM_ = value;
      }
    }

    /// <summary>Field number for the "IGPIPNAAEBJ" field.</summary>
    public const int IGPIPNAAEBJFieldNumber = 1824;
    private global::EggLink.DanhengServer.Proto.NMKAECDMHOP iGPIPNAAEBJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.NMKAECDMHOP IGPIPNAAEBJ {
      get { return iGPIPNAAEBJ_; }
      set {
        iGPIPNAAEBJ_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SceneBattleInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SceneBattleInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (WorldLevel != other.WorldLevel) return false;
      if(!battleEvent_.Equals(other.battleEvent_)) return false;
      if(!buffList_.Equals(other.buffList_)) return false;
      if (!object.Equals(ADAFAOHFLMA, other.ADAFAOHFLMA)) return false;
      if (NBGOGJJOJMA != other.NBGOGJJOJMA) return false;
      if (BattleId != other.BattleId) return false;
      if (StageId != other.StageId) return false;
      if (RoundsLimit != other.RoundsLimit) return false;
      if(!monsterWaveList_.Equals(other.monsterWaveList_)) return false;
      if (!object.Equals(BattleRogueMagicInfo, other.BattleRogueMagicInfo)) return false;
      if(!battleAvatarList_.Equals(other.battleAvatarList_)) return false;
      if (!object.Equals(GDDALCGOOBG, other.GDDALCGOOBG)) return false;
      if (!BattleTargetInfo.Equals(other.BattleTargetInfo)) return false;
      if (LogicRandomSeed != other.LogicRandomSeed) return false;
      if (MAKIGFEMKNM != other.MAKIGFEMKNM) return false;
      if (!object.Equals(IGPIPNAAEBJ, other.IGPIPNAAEBJ)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (WorldLevel != 0) hash ^= WorldLevel.GetHashCode();
      hash ^= battleEvent_.GetHashCode();
      hash ^= buffList_.GetHashCode();
      if (aDAFAOHFLMA_ != null) hash ^= ADAFAOHFLMA.GetHashCode();
      if (NBGOGJJOJMA != false) hash ^= NBGOGJJOJMA.GetHashCode();
      if (BattleId != 0) hash ^= BattleId.GetHashCode();
      if (StageId != 0) hash ^= StageId.GetHashCode();
      if (RoundsLimit != 0) hash ^= RoundsLimit.GetHashCode();
      hash ^= monsterWaveList_.GetHashCode();
      if (battleRogueMagicInfo_ != null) hash ^= BattleRogueMagicInfo.GetHashCode();
      hash ^= battleAvatarList_.GetHashCode();
      if (gDDALCGOOBG_ != null) hash ^= GDDALCGOOBG.GetHashCode();
      hash ^= BattleTargetInfo.GetHashCode();
      if (LogicRandomSeed != 0) hash ^= LogicRandomSeed.GetHashCode();
      if (MAKIGFEMKNM != 0) hash ^= MAKIGFEMKNM.GetHashCode();
      if (iGPIPNAAEBJ_ != null) hash ^= IGPIPNAAEBJ.GetHashCode();
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
      if (WorldLevel != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(WorldLevel);
      }
      if (NBGOGJJOJMA != false) {
        output.WriteRawTag(24);
        output.WriteBool(NBGOGJJOJMA);
      }
      monsterWaveList_.WriteTo(output, _repeated_monsterWaveList_codec);
      if (MAKIGFEMKNM != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(MAKIGFEMKNM);
      }
      if (BattleId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(BattleId);
      }
      battleAvatarList_.WriteTo(output, _repeated_battleAvatarList_codec);
      if (LogicRandomSeed != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(LogicRandomSeed);
      }
      buffList_.WriteTo(output, _repeated_buffList_codec);
      if (RoundsLimit != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(RoundsLimit);
      }
      if (StageId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(StageId);
      }
      if (gDDALCGOOBG_ != null) {
        output.WriteRawTag(226, 49);
        output.WriteMessage(GDDALCGOOBG);
      }
      battleEvent_.WriteTo(output, _repeated_battleEvent_codec);
      if (aDAFAOHFLMA_ != null) {
        output.WriteRawTag(186, 67);
        output.WriteMessage(ADAFAOHFLMA);
      }
      if (iGPIPNAAEBJ_ != null) {
        output.WriteRawTag(130, 114);
        output.WriteMessage(IGPIPNAAEBJ);
      }
      battleTargetInfo_.WriteTo(output, _map_battleTargetInfo_codec);
      if (battleRogueMagicInfo_ != null) {
        output.WriteRawTag(202, 124);
        output.WriteMessage(BattleRogueMagicInfo);
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
      if (WorldLevel != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(WorldLevel);
      }
      if (NBGOGJJOJMA != false) {
        output.WriteRawTag(24);
        output.WriteBool(NBGOGJJOJMA);
      }
      monsterWaveList_.WriteTo(ref output, _repeated_monsterWaveList_codec);
      if (MAKIGFEMKNM != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(MAKIGFEMKNM);
      }
      if (BattleId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(BattleId);
      }
      battleAvatarList_.WriteTo(ref output, _repeated_battleAvatarList_codec);
      if (LogicRandomSeed != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(LogicRandomSeed);
      }
      buffList_.WriteTo(ref output, _repeated_buffList_codec);
      if (RoundsLimit != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(RoundsLimit);
      }
      if (StageId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(StageId);
      }
      if (gDDALCGOOBG_ != null) {
        output.WriteRawTag(226, 49);
        output.WriteMessage(GDDALCGOOBG);
      }
      battleEvent_.WriteTo(ref output, _repeated_battleEvent_codec);
      if (aDAFAOHFLMA_ != null) {
        output.WriteRawTag(186, 67);
        output.WriteMessage(ADAFAOHFLMA);
      }
      if (iGPIPNAAEBJ_ != null) {
        output.WriteRawTag(130, 114);
        output.WriteMessage(IGPIPNAAEBJ);
      }
      battleTargetInfo_.WriteTo(ref output, _map_battleTargetInfo_codec);
      if (battleRogueMagicInfo_ != null) {
        output.WriteRawTag(202, 124);
        output.WriteMessage(BattleRogueMagicInfo);
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
      if (WorldLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WorldLevel);
      }
      size += battleEvent_.CalculateSize(_repeated_battleEvent_codec);
      size += buffList_.CalculateSize(_repeated_buffList_codec);
      if (aDAFAOHFLMA_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(ADAFAOHFLMA);
      }
      if (NBGOGJJOJMA != false) {
        size += 1 + 1;
      }
      if (BattleId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BattleId);
      }
      if (StageId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StageId);
      }
      if (RoundsLimit != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RoundsLimit);
      }
      size += monsterWaveList_.CalculateSize(_repeated_monsterWaveList_codec);
      if (battleRogueMagicInfo_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(BattleRogueMagicInfo);
      }
      size += battleAvatarList_.CalculateSize(_repeated_battleAvatarList_codec);
      if (gDDALCGOOBG_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(GDDALCGOOBG);
      }
      size += battleTargetInfo_.CalculateSize(_map_battleTargetInfo_codec);
      if (LogicRandomSeed != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LogicRandomSeed);
      }
      if (MAKIGFEMKNM != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MAKIGFEMKNM);
      }
      if (iGPIPNAAEBJ_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(IGPIPNAAEBJ);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SceneBattleInfo other) {
      if (other == null) {
        return;
      }
      if (other.WorldLevel != 0) {
        WorldLevel = other.WorldLevel;
      }
      battleEvent_.Add(other.battleEvent_);
      buffList_.Add(other.buffList_);
      if (other.aDAFAOHFLMA_ != null) {
        if (aDAFAOHFLMA_ == null) {
          ADAFAOHFLMA = new global::EggLink.DanhengServer.Proto.EvolveBuildBattleInfo();
        }
        ADAFAOHFLMA.MergeFrom(other.ADAFAOHFLMA);
      }
      if (other.NBGOGJJOJMA != false) {
        NBGOGJJOJMA = other.NBGOGJJOJMA;
      }
      if (other.BattleId != 0) {
        BattleId = other.BattleId;
      }
      if (other.StageId != 0) {
        StageId = other.StageId;
      }
      if (other.RoundsLimit != 0) {
        RoundsLimit = other.RoundsLimit;
      }
      monsterWaveList_.Add(other.monsterWaveList_);
      if (other.battleRogueMagicInfo_ != null) {
        if (battleRogueMagicInfo_ == null) {
          BattleRogueMagicInfo = new global::EggLink.DanhengServer.Proto.BattleRogueMagicInfo();
        }
        BattleRogueMagicInfo.MergeFrom(other.BattleRogueMagicInfo);
      }
      battleAvatarList_.Add(other.battleAvatarList_);
      if (other.gDDALCGOOBG_ != null) {
        if (gDDALCGOOBG_ == null) {
          GDDALCGOOBG = new global::EggLink.DanhengServer.Proto.OLGKJDLMEIO();
        }
        GDDALCGOOBG.MergeFrom(other.GDDALCGOOBG);
      }
      battleTargetInfo_.MergeFrom(other.battleTargetInfo_);
      if (other.LogicRandomSeed != 0) {
        LogicRandomSeed = other.LogicRandomSeed;
      }
      if (other.MAKIGFEMKNM != 0) {
        MAKIGFEMKNM = other.MAKIGFEMKNM;
      }
      if (other.iGPIPNAAEBJ_ != null) {
        if (iGPIPNAAEBJ_ == null) {
          IGPIPNAAEBJ = new global::EggLink.DanhengServer.Proto.NMKAECDMHOP();
        }
        IGPIPNAAEBJ.MergeFrom(other.IGPIPNAAEBJ);
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
            WorldLevel = input.ReadUInt32();
            break;
          }
          case 24: {
            NBGOGJJOJMA = input.ReadBool();
            break;
          }
          case 34: {
            monsterWaveList_.AddEntriesFrom(input, _repeated_monsterWaveList_codec);
            break;
          }
          case 40: {
            MAKIGFEMKNM = input.ReadUInt32();
            break;
          }
          case 72: {
            BattleId = input.ReadUInt32();
            break;
          }
          case 82: {
            battleAvatarList_.AddEntriesFrom(input, _repeated_battleAvatarList_codec);
            break;
          }
          case 96: {
            LogicRandomSeed = input.ReadUInt32();
            break;
          }
          case 106: {
            buffList_.AddEntriesFrom(input, _repeated_buffList_codec);
            break;
          }
          case 112: {
            RoundsLimit = input.ReadUInt32();
            break;
          }
          case 120: {
            StageId = input.ReadUInt32();
            break;
          }
          case 6370: {
            if (gDDALCGOOBG_ == null) {
              GDDALCGOOBG = new global::EggLink.DanhengServer.Proto.OLGKJDLMEIO();
            }
            input.ReadMessage(GDDALCGOOBG);
            break;
          }
          case 7426: {
            battleEvent_.AddEntriesFrom(input, _repeated_battleEvent_codec);
            break;
          }
          case 8634: {
            if (aDAFAOHFLMA_ == null) {
              ADAFAOHFLMA = new global::EggLink.DanhengServer.Proto.EvolveBuildBattleInfo();
            }
            input.ReadMessage(ADAFAOHFLMA);
            break;
          }
          case 14594: {
            if (iGPIPNAAEBJ_ == null) {
              IGPIPNAAEBJ = new global::EggLink.DanhengServer.Proto.NMKAECDMHOP();
            }
            input.ReadMessage(IGPIPNAAEBJ);
            break;
          }
          case 14722: {
            battleTargetInfo_.AddEntriesFrom(input, _map_battleTargetInfo_codec);
            break;
          }
          case 15946: {
            if (battleRogueMagicInfo_ == null) {
              BattleRogueMagicInfo = new global::EggLink.DanhengServer.Proto.BattleRogueMagicInfo();
            }
            input.ReadMessage(BattleRogueMagicInfo);
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
            WorldLevel = input.ReadUInt32();
            break;
          }
          case 24: {
            NBGOGJJOJMA = input.ReadBool();
            break;
          }
          case 34: {
            monsterWaveList_.AddEntriesFrom(ref input, _repeated_monsterWaveList_codec);
            break;
          }
          case 40: {
            MAKIGFEMKNM = input.ReadUInt32();
            break;
          }
          case 72: {
            BattleId = input.ReadUInt32();
            break;
          }
          case 82: {
            battleAvatarList_.AddEntriesFrom(ref input, _repeated_battleAvatarList_codec);
            break;
          }
          case 96: {
            LogicRandomSeed = input.ReadUInt32();
            break;
          }
          case 106: {
            buffList_.AddEntriesFrom(ref input, _repeated_buffList_codec);
            break;
          }
          case 112: {
            RoundsLimit = input.ReadUInt32();
            break;
          }
          case 120: {
            StageId = input.ReadUInt32();
            break;
          }
          case 6370: {
            if (gDDALCGOOBG_ == null) {
              GDDALCGOOBG = new global::EggLink.DanhengServer.Proto.OLGKJDLMEIO();
            }
            input.ReadMessage(GDDALCGOOBG);
            break;
          }
          case 7426: {
            battleEvent_.AddEntriesFrom(ref input, _repeated_battleEvent_codec);
            break;
          }
          case 8634: {
            if (aDAFAOHFLMA_ == null) {
              ADAFAOHFLMA = new global::EggLink.DanhengServer.Proto.EvolveBuildBattleInfo();
            }
            input.ReadMessage(ADAFAOHFLMA);
            break;
          }
          case 14594: {
            if (iGPIPNAAEBJ_ == null) {
              IGPIPNAAEBJ = new global::EggLink.DanhengServer.Proto.NMKAECDMHOP();
            }
            input.ReadMessage(IGPIPNAAEBJ);
            break;
          }
          case 14722: {
            battleTargetInfo_.AddEntriesFrom(ref input, _map_battleTargetInfo_codec);
            break;
          }
          case 15946: {
            if (battleRogueMagicInfo_ == null) {
              BattleRogueMagicInfo = new global::EggLink.DanhengServer.Proto.BattleRogueMagicInfo();
            }
            input.ReadMessage(BattleRogueMagicInfo);
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
