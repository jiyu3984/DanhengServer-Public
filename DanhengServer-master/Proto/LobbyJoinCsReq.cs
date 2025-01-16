// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: LobbyJoinCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from LobbyJoinCsReq.proto</summary>
  public static partial class LobbyJoinCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for LobbyJoinCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LobbyJoinCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRMb2JieUpvaW5Dc1JlcS5wcm90bxoVUGxheWVyRXh0cmFJbmZvLnByb3Rv",
            "Ik0KDkxvYmJ5Sm9pbkNzUmVxEioKEGxvYmJ5X2V4dHJhX2luZm8YByABKAsy",
            "EC5QbGF5ZXJFeHRyYUluZm8SDwoHcm9vbV9pZBgKIAEoBEIeqgIbRWdnTGlu",
            "ay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.PlayerExtraInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.LobbyJoinCsReq), global::EggLink.DanhengServer.Proto.LobbyJoinCsReq.Parser, new[]{ "LobbyExtraInfo", "RoomId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class LobbyJoinCsReq : pb::IMessage<LobbyJoinCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LobbyJoinCsReq> _parser = new pb::MessageParser<LobbyJoinCsReq>(() => new LobbyJoinCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LobbyJoinCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.LobbyJoinCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LobbyJoinCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LobbyJoinCsReq(LobbyJoinCsReq other) : this() {
      lobbyExtraInfo_ = other.lobbyExtraInfo_ != null ? other.lobbyExtraInfo_.Clone() : null;
      roomId_ = other.roomId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LobbyJoinCsReq Clone() {
      return new LobbyJoinCsReq(this);
    }

    /// <summary>Field number for the "lobby_extra_info" field.</summary>
    public const int LobbyExtraInfoFieldNumber = 7;
    private global::EggLink.DanhengServer.Proto.PlayerExtraInfo lobbyExtraInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.PlayerExtraInfo LobbyExtraInfo {
      get { return lobbyExtraInfo_; }
      set {
        lobbyExtraInfo_ = value;
      }
    }

    /// <summary>Field number for the "room_id" field.</summary>
    public const int RoomIdFieldNumber = 10;
    private ulong roomId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong RoomId {
      get { return roomId_; }
      set {
        roomId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LobbyJoinCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LobbyJoinCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(LobbyExtraInfo, other.LobbyExtraInfo)) return false;
      if (RoomId != other.RoomId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (lobbyExtraInfo_ != null) hash ^= LobbyExtraInfo.GetHashCode();
      if (RoomId != 0UL) hash ^= RoomId.GetHashCode();
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
      if (lobbyExtraInfo_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(LobbyExtraInfo);
      }
      if (RoomId != 0UL) {
        output.WriteRawTag(80);
        output.WriteUInt64(RoomId);
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
      if (lobbyExtraInfo_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(LobbyExtraInfo);
      }
      if (RoomId != 0UL) {
        output.WriteRawTag(80);
        output.WriteUInt64(RoomId);
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
      if (RoomId != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(RoomId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(LobbyJoinCsReq other) {
      if (other == null) {
        return;
      }
      if (other.lobbyExtraInfo_ != null) {
        if (lobbyExtraInfo_ == null) {
          LobbyExtraInfo = new global::EggLink.DanhengServer.Proto.PlayerExtraInfo();
        }
        LobbyExtraInfo.MergeFrom(other.LobbyExtraInfo);
      }
      if (other.RoomId != 0UL) {
        RoomId = other.RoomId;
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
          case 58: {
            if (lobbyExtraInfo_ == null) {
              LobbyExtraInfo = new global::EggLink.DanhengServer.Proto.PlayerExtraInfo();
            }
            input.ReadMessage(LobbyExtraInfo);
            break;
          }
          case 80: {
            RoomId = input.ReadUInt64();
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
          case 58: {
            if (lobbyExtraInfo_ == null) {
              LobbyExtraInfo = new global::EggLink.DanhengServer.Proto.PlayerExtraInfo();
            }
            input.ReadMessage(LobbyExtraInfo);
            break;
          }
          case 80: {
            RoomId = input.ReadUInt64();
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