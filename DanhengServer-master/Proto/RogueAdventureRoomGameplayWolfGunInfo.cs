// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueAdventureRoomGameplayWolfGunInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueAdventureRoomGameplayWolfGunInfo.proto</summary>
  public static partial class RogueAdventureRoomGameplayWolfGunInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueAdventureRoomGameplayWolfGunInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueAdventureRoomGameplayWolfGunInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CitSb2d1ZUFkdmVudHVyZVJvb21HYW1lcGxheVdvbGZHdW5JbmZvLnByb3Rv",
            "Gi9Sb2d1ZUFkdmVudHVyZVJvb21HYW1lcGxheVdvbGZHdW5HYW1lSW5mby5w",
            "cm90byJ+CiVSb2d1ZUFkdmVudHVyZVJvb21HYW1lcGxheVdvbGZHdW5JbmZv",
            "Ej8KCWdhbWVfaW5mbxgOIAEoCzIqLlJvZ3VlQWR2ZW50dXJlUm9vbUdhbWVw",
            "bGF5V29sZkd1bkdhbWVJbmZvSABCFAoSZ2FtZXBsYXlfZ2FtZV9pbmZvQh6q",
            "AhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueAdventureRoomGameplayWolfGunGameInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueAdventureRoomGameplayWolfGunInfo), global::EggLink.DanhengServer.Proto.RogueAdventureRoomGameplayWolfGunInfo.Parser, new[]{ "GameInfo" }, new[]{ "GameplayGameInfo" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueAdventureRoomGameplayWolfGunInfo : pb::IMessage<RogueAdventureRoomGameplayWolfGunInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueAdventureRoomGameplayWolfGunInfo> _parser = new pb::MessageParser<RogueAdventureRoomGameplayWolfGunInfo>(() => new RogueAdventureRoomGameplayWolfGunInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueAdventureRoomGameplayWolfGunInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueAdventureRoomGameplayWolfGunInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueAdventureRoomGameplayWolfGunInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueAdventureRoomGameplayWolfGunInfo(RogueAdventureRoomGameplayWolfGunInfo other) : this() {
      switch (other.GameplayGameInfoCase) {
        case GameplayGameInfoOneofCase.GameInfo:
          GameInfo = other.GameInfo.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueAdventureRoomGameplayWolfGunInfo Clone() {
      return new RogueAdventureRoomGameplayWolfGunInfo(this);
    }

    /// <summary>Field number for the "game_info" field.</summary>
    public const int GameInfoFieldNumber = 14;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueAdventureRoomGameplayWolfGunGameInfo GameInfo {
      get { return gameplayGameInfoCase_ == GameplayGameInfoOneofCase.GameInfo ? (global::EggLink.DanhengServer.Proto.RogueAdventureRoomGameplayWolfGunGameInfo) gameplayGameInfo_ : null; }
      set {
        gameplayGameInfo_ = value;
        gameplayGameInfoCase_ = value == null ? GameplayGameInfoOneofCase.None : GameplayGameInfoOneofCase.GameInfo;
      }
    }

    private object gameplayGameInfo_;
    /// <summary>Enum of possible cases for the "gameplay_game_info" oneof.</summary>
    public enum GameplayGameInfoOneofCase {
      None = 0,
      GameInfo = 14,
    }
    private GameplayGameInfoOneofCase gameplayGameInfoCase_ = GameplayGameInfoOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GameplayGameInfoOneofCase GameplayGameInfoCase {
      get { return gameplayGameInfoCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearGameplayGameInfo() {
      gameplayGameInfoCase_ = GameplayGameInfoOneofCase.None;
      gameplayGameInfo_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueAdventureRoomGameplayWolfGunInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueAdventureRoomGameplayWolfGunInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(GameInfo, other.GameInfo)) return false;
      if (GameplayGameInfoCase != other.GameplayGameInfoCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (gameplayGameInfoCase_ == GameplayGameInfoOneofCase.GameInfo) hash ^= GameInfo.GetHashCode();
      hash ^= (int) gameplayGameInfoCase_;
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
      if (gameplayGameInfoCase_ == GameplayGameInfoOneofCase.GameInfo) {
        output.WriteRawTag(114);
        output.WriteMessage(GameInfo);
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
      if (gameplayGameInfoCase_ == GameplayGameInfoOneofCase.GameInfo) {
        output.WriteRawTag(114);
        output.WriteMessage(GameInfo);
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
      if (gameplayGameInfoCase_ == GameplayGameInfoOneofCase.GameInfo) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GameInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueAdventureRoomGameplayWolfGunInfo other) {
      if (other == null) {
        return;
      }
      switch (other.GameplayGameInfoCase) {
        case GameplayGameInfoOneofCase.GameInfo:
          if (GameInfo == null) {
            GameInfo = new global::EggLink.DanhengServer.Proto.RogueAdventureRoomGameplayWolfGunGameInfo();
          }
          GameInfo.MergeFrom(other.GameInfo);
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
          case 114: {
            global::EggLink.DanhengServer.Proto.RogueAdventureRoomGameplayWolfGunGameInfo subBuilder = new global::EggLink.DanhengServer.Proto.RogueAdventureRoomGameplayWolfGunGameInfo();
            if (gameplayGameInfoCase_ == GameplayGameInfoOneofCase.GameInfo) {
              subBuilder.MergeFrom(GameInfo);
            }
            input.ReadMessage(subBuilder);
            GameInfo = subBuilder;
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
          case 114: {
            global::EggLink.DanhengServer.Proto.RogueAdventureRoomGameplayWolfGunGameInfo subBuilder = new global::EggLink.DanhengServer.Proto.RogueAdventureRoomGameplayWolfGunGameInfo();
            if (gameplayGameInfoCase_ == GameplayGameInfoOneofCase.GameInfo) {
              subBuilder.MergeFrom(GameInfo);
            }
            input.ReadMessage(subBuilder);
            GameInfo = subBuilder;
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