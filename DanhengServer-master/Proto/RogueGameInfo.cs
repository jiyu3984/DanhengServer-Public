// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueGameInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueGameInfo.proto</summary>
  public static partial class RogueGameInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueGameInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueGameInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNSb2d1ZUdhbWVJbmZvLnByb3RvGhhDaGVzc1JvZ3VlQnVmZkluZm8ucHJv",
            "dG8aG1JvZ3VlVG91cm5Gb3JtdWxhSW5mby5wcm90bxoeUm9ndWVEaWZmaWN1",
            "bHR5TGV2ZWxJbmZvLnByb3RvGhxDaGVzc1JvZ3VlR2FtZUFlb25JbmZvLnBy",
            "b3RvGhhSb2d1ZUdhbWVJdGVtVmFsdWUucHJvdG8aGlJvZ3VlVG91cm5MaW5l",
            "dXBJbmZvLnByb3RvGhhLZXl3b3JkVW5sb2NrVmFsdWUucHJvdG8aG0NoZXNz",
            "Um9ndWVNaXJhY2xlSW5mby5wcm90byKwAwoNUm9ndWVHYW1lSW5mbxIuCg9y",
            "b2d1ZV9idWZmX2luZm8YBiABKAsyEy5DaGVzc1JvZ3VlQnVmZkluZm9IABIz",
            "ChFnYW1lX21pcmFjbGVfaW5mbxgPIAEoCzIWLkNoZXNzUm9ndWVNaXJhY2xl",
            "SW5mb0gAEi4KD2dhbWVfaXRlbV92YWx1ZRgKIAEoCzITLlJvZ3VlR2FtZUl0",
            "ZW1WYWx1ZUgAEjIKD3JvZ3VlX2Flb25faW5mbxgCIAEoCzIXLkNoZXNzUm9n",
            "dWVHYW1lQWVvbkluZm9IABI6ChVyb2d1ZV9kaWZmaWN1bHR5X2luZm8YCSAB",
            "KAsyGS5Sb2d1ZURpZmZpY3VsdHlMZXZlbEluZm9IABItCgtMTlBIS0FGTUVG",
            "TRgFIAEoCzIWLlJvZ3VlVG91cm5Gb3JtdWxhSW5mb0gAEioKC05HT01KS0lP",
            "QUtDGAQgASgLMhMuS2V5d29yZFVubG9ja1ZhbHVlSAASMgoRcm9ndWVfbGlu",
            "ZXVwX2luZm8YDiABKAsyFS5Sb2d1ZVRvdXJuTGluZXVwSW5mb0gAQgsKCWdh",
            "bWVfaW5mb0IeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ChessRogueBuffInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueTournFormulaInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueDifficultyLevelInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChessRogueGameAeonInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueGameItemValueReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueTournLineupInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.KeywordUnlockValueReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChessRogueMiracleInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueGameInfo), global::EggLink.DanhengServer.Proto.RogueGameInfo.Parser, new[]{ "RogueBuffInfo", "GameMiracleInfo", "GameItemValue", "RogueAeonInfo", "RogueDifficultyInfo", "LNPHKAFMEFM", "NGOMJKIOAKC", "RogueLineupInfo" }, new[]{ "GameInfo" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueGameInfo : pb::IMessage<RogueGameInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueGameInfo> _parser = new pb::MessageParser<RogueGameInfo>(() => new RogueGameInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueGameInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueGameInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueGameInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueGameInfo(RogueGameInfo other) : this() {
      switch (other.GameInfoCase) {
        case GameInfoOneofCase.RogueBuffInfo:
          RogueBuffInfo = other.RogueBuffInfo.Clone();
          break;
        case GameInfoOneofCase.GameMiracleInfo:
          GameMiracleInfo = other.GameMiracleInfo.Clone();
          break;
        case GameInfoOneofCase.GameItemValue:
          GameItemValue = other.GameItemValue.Clone();
          break;
        case GameInfoOneofCase.RogueAeonInfo:
          RogueAeonInfo = other.RogueAeonInfo.Clone();
          break;
        case GameInfoOneofCase.RogueDifficultyInfo:
          RogueDifficultyInfo = other.RogueDifficultyInfo.Clone();
          break;
        case GameInfoOneofCase.LNPHKAFMEFM:
          LNPHKAFMEFM = other.LNPHKAFMEFM.Clone();
          break;
        case GameInfoOneofCase.NGOMJKIOAKC:
          NGOMJKIOAKC = other.NGOMJKIOAKC.Clone();
          break;
        case GameInfoOneofCase.RogueLineupInfo:
          RogueLineupInfo = other.RogueLineupInfo.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueGameInfo Clone() {
      return new RogueGameInfo(this);
    }

    /// <summary>Field number for the "rogue_buff_info" field.</summary>
    public const int RogueBuffInfoFieldNumber = 6;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueBuffInfo RogueBuffInfo {
      get { return gameInfoCase_ == GameInfoOneofCase.RogueBuffInfo ? (global::EggLink.DanhengServer.Proto.ChessRogueBuffInfo) gameInfo_ : null; }
      set {
        gameInfo_ = value;
        gameInfoCase_ = value == null ? GameInfoOneofCase.None : GameInfoOneofCase.RogueBuffInfo;
      }
    }

    /// <summary>Field number for the "game_miracle_info" field.</summary>
    public const int GameMiracleInfoFieldNumber = 15;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueMiracleInfo GameMiracleInfo {
      get { return gameInfoCase_ == GameInfoOneofCase.GameMiracleInfo ? (global::EggLink.DanhengServer.Proto.ChessRogueMiracleInfo) gameInfo_ : null; }
      set {
        gameInfo_ = value;
        gameInfoCase_ = value == null ? GameInfoOneofCase.None : GameInfoOneofCase.GameMiracleInfo;
      }
    }

    /// <summary>Field number for the "game_item_value" field.</summary>
    public const int GameItemValueFieldNumber = 10;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueGameItemValue GameItemValue {
      get { return gameInfoCase_ == GameInfoOneofCase.GameItemValue ? (global::EggLink.DanhengServer.Proto.RogueGameItemValue) gameInfo_ : null; }
      set {
        gameInfo_ = value;
        gameInfoCase_ = value == null ? GameInfoOneofCase.None : GameInfoOneofCase.GameItemValue;
      }
    }

    /// <summary>Field number for the "rogue_aeon_info" field.</summary>
    public const int RogueAeonInfoFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueGameAeonInfo RogueAeonInfo {
      get { return gameInfoCase_ == GameInfoOneofCase.RogueAeonInfo ? (global::EggLink.DanhengServer.Proto.ChessRogueGameAeonInfo) gameInfo_ : null; }
      set {
        gameInfo_ = value;
        gameInfoCase_ = value == null ? GameInfoOneofCase.None : GameInfoOneofCase.RogueAeonInfo;
      }
    }

    /// <summary>Field number for the "rogue_difficulty_info" field.</summary>
    public const int RogueDifficultyInfoFieldNumber = 9;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueDifficultyLevelInfo RogueDifficultyInfo {
      get { return gameInfoCase_ == GameInfoOneofCase.RogueDifficultyInfo ? (global::EggLink.DanhengServer.Proto.RogueDifficultyLevelInfo) gameInfo_ : null; }
      set {
        gameInfo_ = value;
        gameInfoCase_ = value == null ? GameInfoOneofCase.None : GameInfoOneofCase.RogueDifficultyInfo;
      }
    }

    /// <summary>Field number for the "LNPHKAFMEFM" field.</summary>
    public const int LNPHKAFMEFMFieldNumber = 5;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueTournFormulaInfo LNPHKAFMEFM {
      get { return gameInfoCase_ == GameInfoOneofCase.LNPHKAFMEFM ? (global::EggLink.DanhengServer.Proto.RogueTournFormulaInfo) gameInfo_ : null; }
      set {
        gameInfo_ = value;
        gameInfoCase_ = value == null ? GameInfoOneofCase.None : GameInfoOneofCase.LNPHKAFMEFM;
      }
    }

    /// <summary>Field number for the "NGOMJKIOAKC" field.</summary>
    public const int NGOMJKIOAKCFieldNumber = 4;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.KeywordUnlockValue NGOMJKIOAKC {
      get { return gameInfoCase_ == GameInfoOneofCase.NGOMJKIOAKC ? (global::EggLink.DanhengServer.Proto.KeywordUnlockValue) gameInfo_ : null; }
      set {
        gameInfo_ = value;
        gameInfoCase_ = value == null ? GameInfoOneofCase.None : GameInfoOneofCase.NGOMJKIOAKC;
      }
    }

    /// <summary>Field number for the "rogue_lineup_info" field.</summary>
    public const int RogueLineupInfoFieldNumber = 14;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueTournLineupInfo RogueLineupInfo {
      get { return gameInfoCase_ == GameInfoOneofCase.RogueLineupInfo ? (global::EggLink.DanhengServer.Proto.RogueTournLineupInfo) gameInfo_ : null; }
      set {
        gameInfo_ = value;
        gameInfoCase_ = value == null ? GameInfoOneofCase.None : GameInfoOneofCase.RogueLineupInfo;
      }
    }

    private object gameInfo_;
    /// <summary>Enum of possible cases for the "game_info" oneof.</summary>
    public enum GameInfoOneofCase {
      None = 0,
      RogueBuffInfo = 6,
      GameMiracleInfo = 15,
      GameItemValue = 10,
      RogueAeonInfo = 2,
      RogueDifficultyInfo = 9,
      LNPHKAFMEFM = 5,
      NGOMJKIOAKC = 4,
      RogueLineupInfo = 14,
    }
    private GameInfoOneofCase gameInfoCase_ = GameInfoOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GameInfoOneofCase GameInfoCase {
      get { return gameInfoCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearGameInfo() {
      gameInfoCase_ = GameInfoOneofCase.None;
      gameInfo_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueGameInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueGameInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(RogueBuffInfo, other.RogueBuffInfo)) return false;
      if (!object.Equals(GameMiracleInfo, other.GameMiracleInfo)) return false;
      if (!object.Equals(GameItemValue, other.GameItemValue)) return false;
      if (!object.Equals(RogueAeonInfo, other.RogueAeonInfo)) return false;
      if (!object.Equals(RogueDifficultyInfo, other.RogueDifficultyInfo)) return false;
      if (!object.Equals(LNPHKAFMEFM, other.LNPHKAFMEFM)) return false;
      if (!object.Equals(NGOMJKIOAKC, other.NGOMJKIOAKC)) return false;
      if (!object.Equals(RogueLineupInfo, other.RogueLineupInfo)) return false;
      if (GameInfoCase != other.GameInfoCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (gameInfoCase_ == GameInfoOneofCase.RogueBuffInfo) hash ^= RogueBuffInfo.GetHashCode();
      if (gameInfoCase_ == GameInfoOneofCase.GameMiracleInfo) hash ^= GameMiracleInfo.GetHashCode();
      if (gameInfoCase_ == GameInfoOneofCase.GameItemValue) hash ^= GameItemValue.GetHashCode();
      if (gameInfoCase_ == GameInfoOneofCase.RogueAeonInfo) hash ^= RogueAeonInfo.GetHashCode();
      if (gameInfoCase_ == GameInfoOneofCase.RogueDifficultyInfo) hash ^= RogueDifficultyInfo.GetHashCode();
      if (gameInfoCase_ == GameInfoOneofCase.LNPHKAFMEFM) hash ^= LNPHKAFMEFM.GetHashCode();
      if (gameInfoCase_ == GameInfoOneofCase.NGOMJKIOAKC) hash ^= NGOMJKIOAKC.GetHashCode();
      if (gameInfoCase_ == GameInfoOneofCase.RogueLineupInfo) hash ^= RogueLineupInfo.GetHashCode();
      hash ^= (int) gameInfoCase_;
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
      if (gameInfoCase_ == GameInfoOneofCase.RogueAeonInfo) {
        output.WriteRawTag(18);
        output.WriteMessage(RogueAeonInfo);
      }
      if (gameInfoCase_ == GameInfoOneofCase.NGOMJKIOAKC) {
        output.WriteRawTag(34);
        output.WriteMessage(NGOMJKIOAKC);
      }
      if (gameInfoCase_ == GameInfoOneofCase.LNPHKAFMEFM) {
        output.WriteRawTag(42);
        output.WriteMessage(LNPHKAFMEFM);
      }
      if (gameInfoCase_ == GameInfoOneofCase.RogueBuffInfo) {
        output.WriteRawTag(50);
        output.WriteMessage(RogueBuffInfo);
      }
      if (gameInfoCase_ == GameInfoOneofCase.RogueDifficultyInfo) {
        output.WriteRawTag(74);
        output.WriteMessage(RogueDifficultyInfo);
      }
      if (gameInfoCase_ == GameInfoOneofCase.GameItemValue) {
        output.WriteRawTag(82);
        output.WriteMessage(GameItemValue);
      }
      if (gameInfoCase_ == GameInfoOneofCase.RogueLineupInfo) {
        output.WriteRawTag(114);
        output.WriteMessage(RogueLineupInfo);
      }
      if (gameInfoCase_ == GameInfoOneofCase.GameMiracleInfo) {
        output.WriteRawTag(122);
        output.WriteMessage(GameMiracleInfo);
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
      if (gameInfoCase_ == GameInfoOneofCase.RogueAeonInfo) {
        output.WriteRawTag(18);
        output.WriteMessage(RogueAeonInfo);
      }
      if (gameInfoCase_ == GameInfoOneofCase.NGOMJKIOAKC) {
        output.WriteRawTag(34);
        output.WriteMessage(NGOMJKIOAKC);
      }
      if (gameInfoCase_ == GameInfoOneofCase.LNPHKAFMEFM) {
        output.WriteRawTag(42);
        output.WriteMessage(LNPHKAFMEFM);
      }
      if (gameInfoCase_ == GameInfoOneofCase.RogueBuffInfo) {
        output.WriteRawTag(50);
        output.WriteMessage(RogueBuffInfo);
      }
      if (gameInfoCase_ == GameInfoOneofCase.RogueDifficultyInfo) {
        output.WriteRawTag(74);
        output.WriteMessage(RogueDifficultyInfo);
      }
      if (gameInfoCase_ == GameInfoOneofCase.GameItemValue) {
        output.WriteRawTag(82);
        output.WriteMessage(GameItemValue);
      }
      if (gameInfoCase_ == GameInfoOneofCase.RogueLineupInfo) {
        output.WriteRawTag(114);
        output.WriteMessage(RogueLineupInfo);
      }
      if (gameInfoCase_ == GameInfoOneofCase.GameMiracleInfo) {
        output.WriteRawTag(122);
        output.WriteMessage(GameMiracleInfo);
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
      if (gameInfoCase_ == GameInfoOneofCase.RogueBuffInfo) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueBuffInfo);
      }
      if (gameInfoCase_ == GameInfoOneofCase.GameMiracleInfo) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GameMiracleInfo);
      }
      if (gameInfoCase_ == GameInfoOneofCase.GameItemValue) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GameItemValue);
      }
      if (gameInfoCase_ == GameInfoOneofCase.RogueAeonInfo) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueAeonInfo);
      }
      if (gameInfoCase_ == GameInfoOneofCase.RogueDifficultyInfo) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueDifficultyInfo);
      }
      if (gameInfoCase_ == GameInfoOneofCase.LNPHKAFMEFM) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LNPHKAFMEFM);
      }
      if (gameInfoCase_ == GameInfoOneofCase.NGOMJKIOAKC) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(NGOMJKIOAKC);
      }
      if (gameInfoCase_ == GameInfoOneofCase.RogueLineupInfo) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueLineupInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueGameInfo other) {
      if (other == null) {
        return;
      }
      switch (other.GameInfoCase) {
        case GameInfoOneofCase.RogueBuffInfo:
          if (RogueBuffInfo == null) {
            RogueBuffInfo = new global::EggLink.DanhengServer.Proto.ChessRogueBuffInfo();
          }
          RogueBuffInfo.MergeFrom(other.RogueBuffInfo);
          break;
        case GameInfoOneofCase.GameMiracleInfo:
          if (GameMiracleInfo == null) {
            GameMiracleInfo = new global::EggLink.DanhengServer.Proto.ChessRogueMiracleInfo();
          }
          GameMiracleInfo.MergeFrom(other.GameMiracleInfo);
          break;
        case GameInfoOneofCase.GameItemValue:
          if (GameItemValue == null) {
            GameItemValue = new global::EggLink.DanhengServer.Proto.RogueGameItemValue();
          }
          GameItemValue.MergeFrom(other.GameItemValue);
          break;
        case GameInfoOneofCase.RogueAeonInfo:
          if (RogueAeonInfo == null) {
            RogueAeonInfo = new global::EggLink.DanhengServer.Proto.ChessRogueGameAeonInfo();
          }
          RogueAeonInfo.MergeFrom(other.RogueAeonInfo);
          break;
        case GameInfoOneofCase.RogueDifficultyInfo:
          if (RogueDifficultyInfo == null) {
            RogueDifficultyInfo = new global::EggLink.DanhengServer.Proto.RogueDifficultyLevelInfo();
          }
          RogueDifficultyInfo.MergeFrom(other.RogueDifficultyInfo);
          break;
        case GameInfoOneofCase.LNPHKAFMEFM:
          if (LNPHKAFMEFM == null) {
            LNPHKAFMEFM = new global::EggLink.DanhengServer.Proto.RogueTournFormulaInfo();
          }
          LNPHKAFMEFM.MergeFrom(other.LNPHKAFMEFM);
          break;
        case GameInfoOneofCase.NGOMJKIOAKC:
          if (NGOMJKIOAKC == null) {
            NGOMJKIOAKC = new global::EggLink.DanhengServer.Proto.KeywordUnlockValue();
          }
          NGOMJKIOAKC.MergeFrom(other.NGOMJKIOAKC);
          break;
        case GameInfoOneofCase.RogueLineupInfo:
          if (RogueLineupInfo == null) {
            RogueLineupInfo = new global::EggLink.DanhengServer.Proto.RogueTournLineupInfo();
          }
          RogueLineupInfo.MergeFrom(other.RogueLineupInfo);
          break;
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
          case 18: {
            global::EggLink.DanhengServer.Proto.ChessRogueGameAeonInfo subBuilder = new global::EggLink.DanhengServer.Proto.ChessRogueGameAeonInfo();
            if (gameInfoCase_ == GameInfoOneofCase.RogueAeonInfo) {
              subBuilder.MergeFrom(RogueAeonInfo);
            }
            input.ReadMessage(subBuilder);
            RogueAeonInfo = subBuilder;
            break;
          }
          case 34: {
            global::EggLink.DanhengServer.Proto.KeywordUnlockValue subBuilder = new global::EggLink.DanhengServer.Proto.KeywordUnlockValue();
            if (gameInfoCase_ == GameInfoOneofCase.NGOMJKIOAKC) {
              subBuilder.MergeFrom(NGOMJKIOAKC);
            }
            input.ReadMessage(subBuilder);
            NGOMJKIOAKC = subBuilder;
            break;
          }
          case 42: {
            global::EggLink.DanhengServer.Proto.RogueTournFormulaInfo subBuilder = new global::EggLink.DanhengServer.Proto.RogueTournFormulaInfo();
            if (gameInfoCase_ == GameInfoOneofCase.LNPHKAFMEFM) {
              subBuilder.MergeFrom(LNPHKAFMEFM);
            }
            input.ReadMessage(subBuilder);
            LNPHKAFMEFM = subBuilder;
            break;
          }
          case 50: {
            global::EggLink.DanhengServer.Proto.ChessRogueBuffInfo subBuilder = new global::EggLink.DanhengServer.Proto.ChessRogueBuffInfo();
            if (gameInfoCase_ == GameInfoOneofCase.RogueBuffInfo) {
              subBuilder.MergeFrom(RogueBuffInfo);
            }
            input.ReadMessage(subBuilder);
            RogueBuffInfo = subBuilder;
            break;
          }
          case 74: {
            global::EggLink.DanhengServer.Proto.RogueDifficultyLevelInfo subBuilder = new global::EggLink.DanhengServer.Proto.RogueDifficultyLevelInfo();
            if (gameInfoCase_ == GameInfoOneofCase.RogueDifficultyInfo) {
              subBuilder.MergeFrom(RogueDifficultyInfo);
            }
            input.ReadMessage(subBuilder);
            RogueDifficultyInfo = subBuilder;
            break;
          }
          case 82: {
            global::EggLink.DanhengServer.Proto.RogueGameItemValue subBuilder = new global::EggLink.DanhengServer.Proto.RogueGameItemValue();
            if (gameInfoCase_ == GameInfoOneofCase.GameItemValue) {
              subBuilder.MergeFrom(GameItemValue);
            }
            input.ReadMessage(subBuilder);
            GameItemValue = subBuilder;
            break;
          }
          case 114: {
            global::EggLink.DanhengServer.Proto.RogueTournLineupInfo subBuilder = new global::EggLink.DanhengServer.Proto.RogueTournLineupInfo();
            if (gameInfoCase_ == GameInfoOneofCase.RogueLineupInfo) {
              subBuilder.MergeFrom(RogueLineupInfo);
            }
            input.ReadMessage(subBuilder);
            RogueLineupInfo = subBuilder;
            break;
          }
          case 122: {
            global::EggLink.DanhengServer.Proto.ChessRogueMiracleInfo subBuilder = new global::EggLink.DanhengServer.Proto.ChessRogueMiracleInfo();
            if (gameInfoCase_ == GameInfoOneofCase.GameMiracleInfo) {
              subBuilder.MergeFrom(GameMiracleInfo);
            }
            input.ReadMessage(subBuilder);
            GameMiracleInfo = subBuilder;
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
          case 18: {
            global::EggLink.DanhengServer.Proto.ChessRogueGameAeonInfo subBuilder = new global::EggLink.DanhengServer.Proto.ChessRogueGameAeonInfo();
            if (gameInfoCase_ == GameInfoOneofCase.RogueAeonInfo) {
              subBuilder.MergeFrom(RogueAeonInfo);
            }
            input.ReadMessage(subBuilder);
            RogueAeonInfo = subBuilder;
            break;
          }
          case 34: {
            global::EggLink.DanhengServer.Proto.KeywordUnlockValue subBuilder = new global::EggLink.DanhengServer.Proto.KeywordUnlockValue();
            if (gameInfoCase_ == GameInfoOneofCase.NGOMJKIOAKC) {
              subBuilder.MergeFrom(NGOMJKIOAKC);
            }
            input.ReadMessage(subBuilder);
            NGOMJKIOAKC = subBuilder;
            break;
          }
          case 42: {
            global::EggLink.DanhengServer.Proto.RogueTournFormulaInfo subBuilder = new global::EggLink.DanhengServer.Proto.RogueTournFormulaInfo();
            if (gameInfoCase_ == GameInfoOneofCase.LNPHKAFMEFM) {
              subBuilder.MergeFrom(LNPHKAFMEFM);
            }
            input.ReadMessage(subBuilder);
            LNPHKAFMEFM = subBuilder;
            break;
          }
          case 50: {
            global::EggLink.DanhengServer.Proto.ChessRogueBuffInfo subBuilder = new global::EggLink.DanhengServer.Proto.ChessRogueBuffInfo();
            if (gameInfoCase_ == GameInfoOneofCase.RogueBuffInfo) {
              subBuilder.MergeFrom(RogueBuffInfo);
            }
            input.ReadMessage(subBuilder);
            RogueBuffInfo = subBuilder;
            break;
          }
          case 74: {
            global::EggLink.DanhengServer.Proto.RogueDifficultyLevelInfo subBuilder = new global::EggLink.DanhengServer.Proto.RogueDifficultyLevelInfo();
            if (gameInfoCase_ == GameInfoOneofCase.RogueDifficultyInfo) {
              subBuilder.MergeFrom(RogueDifficultyInfo);
            }
            input.ReadMessage(subBuilder);
            RogueDifficultyInfo = subBuilder;
            break;
          }
          case 82: {
            global::EggLink.DanhengServer.Proto.RogueGameItemValue subBuilder = new global::EggLink.DanhengServer.Proto.RogueGameItemValue();
            if (gameInfoCase_ == GameInfoOneofCase.GameItemValue) {
              subBuilder.MergeFrom(GameItemValue);
            }
            input.ReadMessage(subBuilder);
            GameItemValue = subBuilder;
            break;
          }
          case 114: {
            global::EggLink.DanhengServer.Proto.RogueTournLineupInfo subBuilder = new global::EggLink.DanhengServer.Proto.RogueTournLineupInfo();
            if (gameInfoCase_ == GameInfoOneofCase.RogueLineupInfo) {
              subBuilder.MergeFrom(RogueLineupInfo);
            }
            input.ReadMessage(subBuilder);
            RogueLineupInfo = subBuilder;
            break;
          }
          case 122: {
            global::EggLink.DanhengServer.Proto.ChessRogueMiracleInfo subBuilder = new global::EggLink.DanhengServer.Proto.ChessRogueMiracleInfo();
            if (gameInfoCase_ == GameInfoOneofCase.GameMiracleInfo) {
              subBuilder.MergeFrom(GameMiracleInfo);
            }
            input.ReadMessage(subBuilder);
            GameMiracleInfo = subBuilder;
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
