// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: StartMatchCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from StartMatchCsReq.proto</summary>
  public static partial class StartMatchCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for StartMatchCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StartMatchCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVTdGFydE1hdGNoQ3NSZXEucHJvdG8aE0ZpZ2h0R2FtZU1vZGUucHJvdG8a",
            "FVBsYXllckV4dHJhSW5mby5wcm90byJmCg9TdGFydE1hdGNoQ3NSZXESKgoQ",
            "bG9iYnlfZXh0cmFfaW5mbxgJIAEoCzIQLlBsYXllckV4dHJhSW5mbxInCg9m",
            "aWdodF9nYW1lX21vZGUYAiABKA4yDi5GaWdodEdhbWVNb2RlQh6qAhtFZ2dM",
            "aW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.FightGameModeReflection.Descriptor, global::EggLink.DanhengServer.Proto.PlayerExtraInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.StartMatchCsReq), global::EggLink.DanhengServer.Proto.StartMatchCsReq.Parser, new[]{ "LobbyExtraInfo", "FightGameMode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class StartMatchCsReq : pb::IMessage<StartMatchCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<StartMatchCsReq> _parser = new pb::MessageParser<StartMatchCsReq>(() => new StartMatchCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<StartMatchCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.StartMatchCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartMatchCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartMatchCsReq(StartMatchCsReq other) : this() {
      lobbyExtraInfo_ = other.lobbyExtraInfo_ != null ? other.lobbyExtraInfo_.Clone() : null;
      fightGameMode_ = other.fightGameMode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartMatchCsReq Clone() {
      return new StartMatchCsReq(this);
    }

    /// <summary>Field number for the "lobby_extra_info" field.</summary>
    public const int LobbyExtraInfoFieldNumber = 9;
    private global::EggLink.DanhengServer.Proto.PlayerExtraInfo lobbyExtraInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.PlayerExtraInfo LobbyExtraInfo {
      get { return lobbyExtraInfo_; }
      set {
        lobbyExtraInfo_ = value;
      }
    }

    /// <summary>Field number for the "fight_game_mode" field.</summary>
    public const int FightGameModeFieldNumber = 2;
    private global::EggLink.DanhengServer.Proto.FightGameMode fightGameMode_ = global::EggLink.DanhengServer.Proto.FightGameMode.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.FightGameMode FightGameMode {
      get { return fightGameMode_; }
      set {
        fightGameMode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as StartMatchCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(StartMatchCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(LobbyExtraInfo, other.LobbyExtraInfo)) return false;
      if (FightGameMode != other.FightGameMode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (lobbyExtraInfo_ != null) hash ^= LobbyExtraInfo.GetHashCode();
      if (FightGameMode != global::EggLink.DanhengServer.Proto.FightGameMode.None) hash ^= FightGameMode.GetHashCode();
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
      if (FightGameMode != global::EggLink.DanhengServer.Proto.FightGameMode.None) {
        output.WriteRawTag(16);
        output.WriteEnum((int) FightGameMode);
      }
      if (lobbyExtraInfo_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(LobbyExtraInfo);
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
      if (FightGameMode != global::EggLink.DanhengServer.Proto.FightGameMode.None) {
        output.WriteRawTag(16);
        output.WriteEnum((int) FightGameMode);
      }
      if (lobbyExtraInfo_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(LobbyExtraInfo);
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
      if (lobbyExtraInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LobbyExtraInfo);
      }
      if (FightGameMode != global::EggLink.DanhengServer.Proto.FightGameMode.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) FightGameMode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(StartMatchCsReq other) {
      if (other == null) {
        return;
      }
      if (other.lobbyExtraInfo_ != null) {
        if (lobbyExtraInfo_ == null) {
          LobbyExtraInfo = new global::EggLink.DanhengServer.Proto.PlayerExtraInfo();
        }
        LobbyExtraInfo.MergeFrom(other.LobbyExtraInfo);
      }
      if (other.FightGameMode != global::EggLink.DanhengServer.Proto.FightGameMode.None) {
        FightGameMode = other.FightGameMode;
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
          case 16: {
            FightGameMode = (global::EggLink.DanhengServer.Proto.FightGameMode) input.ReadEnum();
            break;
          }
          case 74: {
            if (lobbyExtraInfo_ == null) {
              LobbyExtraInfo = new global::EggLink.DanhengServer.Proto.PlayerExtraInfo();
            }
            input.ReadMessage(LobbyExtraInfo);
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
          case 16: {
            FightGameMode = (global::EggLink.DanhengServer.Proto.FightGameMode) input.ReadEnum();
            break;
          }
          case 74: {
            if (lobbyExtraInfo_ == null) {
              LobbyExtraInfo = new global::EggLink.DanhengServer.Proto.PlayerExtraInfo();
            }
            input.ReadMessage(LobbyExtraInfo);
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
