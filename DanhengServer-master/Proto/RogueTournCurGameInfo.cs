// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueTournCurGameInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueTournCurGameInfo.proto</summary>
  public static partial class RogueTournCurGameInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueTournCurGameInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueTournCurGameInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtSb2d1ZVRvdXJuQ3VyR2FtZUluZm8ucHJvdG8aGENoZXNzUm9ndWVCdWZm",
            "SW5mby5wcm90bxobUm9ndWVUb3VybkZvcm11bGFJbmZvLnByb3RvGhpSb2d1",
            "ZVRvdXJuTW9kdWxlSW5mby5wcm90bxocUm9ndWVUb3VybkdhbWVBcmVhSW5m",
            "by5wcm90bxoZUm9ndWVUb3VybkxldmVsSW5mby5wcm90bxoYUm9ndWVHYW1l",
            "SXRlbVZhbHVlLnByb3RvGhpSb2d1ZVRvdXJuTGluZXVwSW5mby5wcm90bxoY",
            "S2V5d29yZFVubG9ja1ZhbHVlLnByb3RvGiJSb2d1ZVRvdXJuR2FtZURpZmZp",
            "Y3VsdHlJbmZvLnByb3RvGhtDaGVzc1JvZ3VlTWlyYWNsZUluZm8ucHJvdG8i",
            "6AMKFVJvZ3VlVG91cm5DdXJHYW1lSW5mbxIjCgVsZXZlbBgBIAEoCzIULlJv",
            "Z3VlVG91cm5MZXZlbEluZm8SOwoacm9ndWVfdG91cm5fZ2FtZV9hcmVhX2lu",
            "Zm8YBCABKAsyFy5Sb2d1ZVRvdXJuR2FtZUFyZWFJbmZvEjAKEXRvdXJuX21v",
            "ZHVsZV9pbmZvGAggASgLMhUuUm9ndWVUb3Vybk1vZHVsZUluZm8SJQoGbGlu",
            "ZXVwGAIgASgLMhUuUm9ndWVUb3VybkxpbmV1cEluZm8SIQoEYnVmZhgPIAEo",
            "CzITLkNoZXNzUm9ndWVCdWZmSW5mbxIpCgx1bmxvY2tfdmFsdWUYCSABKAsy",
            "Ey5LZXl3b3JkVW5sb2NrVmFsdWUSLAoMbWlyYWNsZV9pbmZvGA4gASgLMhYu",
            "Q2hlc3NSb2d1ZU1pcmFjbGVJbmZvEjIKEnRvdXJuX2Zvcm11bGFfaW5mbxgK",
            "IAEoCzIWLlJvZ3VlVG91cm5Gb3JtdWxhSW5mbxI7ChRnYW1lX2RpZmZpY3Vs",
            "dHlfaW5mbxgDIAEoCzIdLlJvZ3VlVG91cm5HYW1lRGlmZmljdWx0eUluZm8S",
            "JwoKaXRlbV92YWx1ZRgHIAEoCzITLlJvZ3VlR2FtZUl0ZW1WYWx1ZUIeqgIb",
            "RWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ChessRogueBuffInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueTournFormulaInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueTournModuleInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueTournGameAreaInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueTournLevelInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueGameItemValueReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueTournLineupInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.KeywordUnlockValueReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueTournGameDifficultyInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChessRogueMiracleInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueTournCurGameInfo), global::EggLink.DanhengServer.Proto.RogueTournCurGameInfo.Parser, new[]{ "Level", "RogueTournGameAreaInfo", "TournModuleInfo", "Lineup", "Buff", "UnlockValue", "MiracleInfo", "TournFormulaInfo", "GameDifficultyInfo", "ItemValue" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueTournCurGameInfo : pb::IMessage<RogueTournCurGameInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueTournCurGameInfo> _parser = new pb::MessageParser<RogueTournCurGameInfo>(() => new RogueTournCurGameInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueTournCurGameInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueTournCurGameInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueTournCurGameInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueTournCurGameInfo(RogueTournCurGameInfo other) : this() {
      level_ = other.level_ != null ? other.level_.Clone() : null;
      rogueTournGameAreaInfo_ = other.rogueTournGameAreaInfo_ != null ? other.rogueTournGameAreaInfo_.Clone() : null;
      tournModuleInfo_ = other.tournModuleInfo_ != null ? other.tournModuleInfo_.Clone() : null;
      lineup_ = other.lineup_ != null ? other.lineup_.Clone() : null;
      buff_ = other.buff_ != null ? other.buff_.Clone() : null;
      unlockValue_ = other.unlockValue_ != null ? other.unlockValue_.Clone() : null;
      miracleInfo_ = other.miracleInfo_ != null ? other.miracleInfo_.Clone() : null;
      tournFormulaInfo_ = other.tournFormulaInfo_ != null ? other.tournFormulaInfo_.Clone() : null;
      gameDifficultyInfo_ = other.gameDifficultyInfo_ != null ? other.gameDifficultyInfo_.Clone() : null;
      itemValue_ = other.itemValue_ != null ? other.itemValue_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueTournCurGameInfo Clone() {
      return new RogueTournCurGameInfo(this);
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 1;
    private global::EggLink.DanhengServer.Proto.RogueTournLevelInfo level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueTournLevelInfo Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "rogue_tourn_game_area_info" field.</summary>
    public const int RogueTournGameAreaInfoFieldNumber = 4;
    private global::EggLink.DanhengServer.Proto.RogueTournGameAreaInfo rogueTournGameAreaInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueTournGameAreaInfo RogueTournGameAreaInfo {
      get { return rogueTournGameAreaInfo_; }
      set {
        rogueTournGameAreaInfo_ = value;
      }
    }

    /// <summary>Field number for the "tourn_module_info" field.</summary>
    public const int TournModuleInfoFieldNumber = 8;
    private global::EggLink.DanhengServer.Proto.RogueTournModuleInfo tournModuleInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueTournModuleInfo TournModuleInfo {
      get { return tournModuleInfo_; }
      set {
        tournModuleInfo_ = value;
      }
    }

    /// <summary>Field number for the "lineup" field.</summary>
    public const int LineupFieldNumber = 2;
    private global::EggLink.DanhengServer.Proto.RogueTournLineupInfo lineup_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueTournLineupInfo Lineup {
      get { return lineup_; }
      set {
        lineup_ = value;
      }
    }

    /// <summary>Field number for the "buff" field.</summary>
    public const int BuffFieldNumber = 15;
    private global::EggLink.DanhengServer.Proto.ChessRogueBuffInfo buff_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueBuffInfo Buff {
      get { return buff_; }
      set {
        buff_ = value;
      }
    }

    /// <summary>Field number for the "unlock_value" field.</summary>
    public const int UnlockValueFieldNumber = 9;
    private global::EggLink.DanhengServer.Proto.KeywordUnlockValue unlockValue_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.KeywordUnlockValue UnlockValue {
      get { return unlockValue_; }
      set {
        unlockValue_ = value;
      }
    }

    /// <summary>Field number for the "miracle_info" field.</summary>
    public const int MiracleInfoFieldNumber = 14;
    private global::EggLink.DanhengServer.Proto.ChessRogueMiracleInfo miracleInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueMiracleInfo MiracleInfo {
      get { return miracleInfo_; }
      set {
        miracleInfo_ = value;
      }
    }

    /// <summary>Field number for the "tourn_formula_info" field.</summary>
    public const int TournFormulaInfoFieldNumber = 10;
    private global::EggLink.DanhengServer.Proto.RogueTournFormulaInfo tournFormulaInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueTournFormulaInfo TournFormulaInfo {
      get { return tournFormulaInfo_; }
      set {
        tournFormulaInfo_ = value;
      }
    }

    /// <summary>Field number for the "game_difficulty_info" field.</summary>
    public const int GameDifficultyInfoFieldNumber = 3;
    private global::EggLink.DanhengServer.Proto.RogueTournGameDifficultyInfo gameDifficultyInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueTournGameDifficultyInfo GameDifficultyInfo {
      get { return gameDifficultyInfo_; }
      set {
        gameDifficultyInfo_ = value;
      }
    }

    /// <summary>Field number for the "item_value" field.</summary>
    public const int ItemValueFieldNumber = 7;
    private global::EggLink.DanhengServer.Proto.RogueGameItemValue itemValue_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueGameItemValue ItemValue {
      get { return itemValue_; }
      set {
        itemValue_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueTournCurGameInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueTournCurGameInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Level, other.Level)) return false;
      if (!object.Equals(RogueTournGameAreaInfo, other.RogueTournGameAreaInfo)) return false;
      if (!object.Equals(TournModuleInfo, other.TournModuleInfo)) return false;
      if (!object.Equals(Lineup, other.Lineup)) return false;
      if (!object.Equals(Buff, other.Buff)) return false;
      if (!object.Equals(UnlockValue, other.UnlockValue)) return false;
      if (!object.Equals(MiracleInfo, other.MiracleInfo)) return false;
      if (!object.Equals(TournFormulaInfo, other.TournFormulaInfo)) return false;
      if (!object.Equals(GameDifficultyInfo, other.GameDifficultyInfo)) return false;
      if (!object.Equals(ItemValue, other.ItemValue)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (level_ != null) hash ^= Level.GetHashCode();
      if (rogueTournGameAreaInfo_ != null) hash ^= RogueTournGameAreaInfo.GetHashCode();
      if (tournModuleInfo_ != null) hash ^= TournModuleInfo.GetHashCode();
      if (lineup_ != null) hash ^= Lineup.GetHashCode();
      if (buff_ != null) hash ^= Buff.GetHashCode();
      if (unlockValue_ != null) hash ^= UnlockValue.GetHashCode();
      if (miracleInfo_ != null) hash ^= MiracleInfo.GetHashCode();
      if (tournFormulaInfo_ != null) hash ^= TournFormulaInfo.GetHashCode();
      if (gameDifficultyInfo_ != null) hash ^= GameDifficultyInfo.GetHashCode();
      if (itemValue_ != null) hash ^= ItemValue.GetHashCode();
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
      if (level_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Level);
      }
      if (lineup_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Lineup);
      }
      if (gameDifficultyInfo_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(GameDifficultyInfo);
      }
      if (rogueTournGameAreaInfo_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(RogueTournGameAreaInfo);
      }
      if (itemValue_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(ItemValue);
      }
      if (tournModuleInfo_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(TournModuleInfo);
      }
      if (unlockValue_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(UnlockValue);
      }
      if (tournFormulaInfo_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(TournFormulaInfo);
      }
      if (miracleInfo_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(MiracleInfo);
      }
      if (buff_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(Buff);
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
      if (level_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Level);
      }
      if (lineup_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Lineup);
      }
      if (gameDifficultyInfo_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(GameDifficultyInfo);
      }
      if (rogueTournGameAreaInfo_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(RogueTournGameAreaInfo);
      }
      if (itemValue_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(ItemValue);
      }
      if (tournModuleInfo_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(TournModuleInfo);
      }
      if (unlockValue_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(UnlockValue);
      }
      if (tournFormulaInfo_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(TournFormulaInfo);
      }
      if (miracleInfo_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(MiracleInfo);
      }
      if (buff_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(Buff);
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
      if (level_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Level);
      }
      if (rogueTournGameAreaInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueTournGameAreaInfo);
      }
      if (tournModuleInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TournModuleInfo);
      }
      if (lineup_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Lineup);
      }
      if (buff_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Buff);
      }
      if (unlockValue_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UnlockValue);
      }
      if (miracleInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MiracleInfo);
      }
      if (tournFormulaInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TournFormulaInfo);
      }
      if (gameDifficultyInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GameDifficultyInfo);
      }
      if (itemValue_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ItemValue);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueTournCurGameInfo other) {
      if (other == null) {
        return;
      }
      if (other.level_ != null) {
        if (level_ == null) {
          Level = new global::EggLink.DanhengServer.Proto.RogueTournLevelInfo();
        }
        Level.MergeFrom(other.Level);
      }
      if (other.rogueTournGameAreaInfo_ != null) {
        if (rogueTournGameAreaInfo_ == null) {
          RogueTournGameAreaInfo = new global::EggLink.DanhengServer.Proto.RogueTournGameAreaInfo();
        }
        RogueTournGameAreaInfo.MergeFrom(other.RogueTournGameAreaInfo);
      }
      if (other.tournModuleInfo_ != null) {
        if (tournModuleInfo_ == null) {
          TournModuleInfo = new global::EggLink.DanhengServer.Proto.RogueTournModuleInfo();
        }
        TournModuleInfo.MergeFrom(other.TournModuleInfo);
      }
      if (other.lineup_ != null) {
        if (lineup_ == null) {
          Lineup = new global::EggLink.DanhengServer.Proto.RogueTournLineupInfo();
        }
        Lineup.MergeFrom(other.Lineup);
      }
      if (other.buff_ != null) {
        if (buff_ == null) {
          Buff = new global::EggLink.DanhengServer.Proto.ChessRogueBuffInfo();
        }
        Buff.MergeFrom(other.Buff);
      }
      if (other.unlockValue_ != null) {
        if (unlockValue_ == null) {
          UnlockValue = new global::EggLink.DanhengServer.Proto.KeywordUnlockValue();
        }
        UnlockValue.MergeFrom(other.UnlockValue);
      }
      if (other.miracleInfo_ != null) {
        if (miracleInfo_ == null) {
          MiracleInfo = new global::EggLink.DanhengServer.Proto.ChessRogueMiracleInfo();
        }
        MiracleInfo.MergeFrom(other.MiracleInfo);
      }
      if (other.tournFormulaInfo_ != null) {
        if (tournFormulaInfo_ == null) {
          TournFormulaInfo = new global::EggLink.DanhengServer.Proto.RogueTournFormulaInfo();
        }
        TournFormulaInfo.MergeFrom(other.TournFormulaInfo);
      }
      if (other.gameDifficultyInfo_ != null) {
        if (gameDifficultyInfo_ == null) {
          GameDifficultyInfo = new global::EggLink.DanhengServer.Proto.RogueTournGameDifficultyInfo();
        }
        GameDifficultyInfo.MergeFrom(other.GameDifficultyInfo);
      }
      if (other.itemValue_ != null) {
        if (itemValue_ == null) {
          ItemValue = new global::EggLink.DanhengServer.Proto.RogueGameItemValue();
        }
        ItemValue.MergeFrom(other.ItemValue);
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
          case 10: {
            if (level_ == null) {
              Level = new global::EggLink.DanhengServer.Proto.RogueTournLevelInfo();
            }
            input.ReadMessage(Level);
            break;
          }
          case 18: {
            if (lineup_ == null) {
              Lineup = new global::EggLink.DanhengServer.Proto.RogueTournLineupInfo();
            }
            input.ReadMessage(Lineup);
            break;
          }
          case 26: {
            if (gameDifficultyInfo_ == null) {
              GameDifficultyInfo = new global::EggLink.DanhengServer.Proto.RogueTournGameDifficultyInfo();
            }
            input.ReadMessage(GameDifficultyInfo);
            break;
          }
          case 34: {
            if (rogueTournGameAreaInfo_ == null) {
              RogueTournGameAreaInfo = new global::EggLink.DanhengServer.Proto.RogueTournGameAreaInfo();
            }
            input.ReadMessage(RogueTournGameAreaInfo);
            break;
          }
          case 58: {
            if (itemValue_ == null) {
              ItemValue = new global::EggLink.DanhengServer.Proto.RogueGameItemValue();
            }
            input.ReadMessage(ItemValue);
            break;
          }
          case 66: {
            if (tournModuleInfo_ == null) {
              TournModuleInfo = new global::EggLink.DanhengServer.Proto.RogueTournModuleInfo();
            }
            input.ReadMessage(TournModuleInfo);
            break;
          }
          case 74: {
            if (unlockValue_ == null) {
              UnlockValue = new global::EggLink.DanhengServer.Proto.KeywordUnlockValue();
            }
            input.ReadMessage(UnlockValue);
            break;
          }
          case 82: {
            if (tournFormulaInfo_ == null) {
              TournFormulaInfo = new global::EggLink.DanhengServer.Proto.RogueTournFormulaInfo();
            }
            input.ReadMessage(TournFormulaInfo);
            break;
          }
          case 114: {
            if (miracleInfo_ == null) {
              MiracleInfo = new global::EggLink.DanhengServer.Proto.ChessRogueMiracleInfo();
            }
            input.ReadMessage(MiracleInfo);
            break;
          }
          case 122: {
            if (buff_ == null) {
              Buff = new global::EggLink.DanhengServer.Proto.ChessRogueBuffInfo();
            }
            input.ReadMessage(Buff);
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
          case 10: {
            if (level_ == null) {
              Level = new global::EggLink.DanhengServer.Proto.RogueTournLevelInfo();
            }
            input.ReadMessage(Level);
            break;
          }
          case 18: {
            if (lineup_ == null) {
              Lineup = new global::EggLink.DanhengServer.Proto.RogueTournLineupInfo();
            }
            input.ReadMessage(Lineup);
            break;
          }
          case 26: {
            if (gameDifficultyInfo_ == null) {
              GameDifficultyInfo = new global::EggLink.DanhengServer.Proto.RogueTournGameDifficultyInfo();
            }
            input.ReadMessage(GameDifficultyInfo);
            break;
          }
          case 34: {
            if (rogueTournGameAreaInfo_ == null) {
              RogueTournGameAreaInfo = new global::EggLink.DanhengServer.Proto.RogueTournGameAreaInfo();
            }
            input.ReadMessage(RogueTournGameAreaInfo);
            break;
          }
          case 58: {
            if (itemValue_ == null) {
              ItemValue = new global::EggLink.DanhengServer.Proto.RogueGameItemValue();
            }
            input.ReadMessage(ItemValue);
            break;
          }
          case 66: {
            if (tournModuleInfo_ == null) {
              TournModuleInfo = new global::EggLink.DanhengServer.Proto.RogueTournModuleInfo();
            }
            input.ReadMessage(TournModuleInfo);
            break;
          }
          case 74: {
            if (unlockValue_ == null) {
              UnlockValue = new global::EggLink.DanhengServer.Proto.KeywordUnlockValue();
            }
            input.ReadMessage(UnlockValue);
            break;
          }
          case 82: {
            if (tournFormulaInfo_ == null) {
              TournFormulaInfo = new global::EggLink.DanhengServer.Proto.RogueTournFormulaInfo();
            }
            input.ReadMessage(TournFormulaInfo);
            break;
          }
          case 114: {
            if (miracleInfo_ == null) {
              MiracleInfo = new global::EggLink.DanhengServer.Proto.ChessRogueMiracleInfo();
            }
            input.ReadMessage(MiracleInfo);
            break;
          }
          case 122: {
            if (buff_ == null) {
              Buff = new global::EggLink.DanhengServer.Proto.ChessRogueBuffInfo();
            }
            input.ReadMessage(Buff);
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
