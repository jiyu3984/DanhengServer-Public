// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: LobbyModifyPlayerInfoCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from LobbyModifyPlayerInfoCsReq.proto</summary>
  public static partial class LobbyModifyPlayerInfoCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for LobbyModifyPlayerInfoCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LobbyModifyPlayerInfoCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBMb2JieU1vZGlmeVBsYXllckluZm9Dc1JlcS5wcm90bxoVUGxheWVyRXh0",
            "cmFJbmZvLnByb3RvGhVMb2JieU1vZGlmeVR5cGUucHJvdG8ifQoaTG9iYnlN",
            "b2RpZnlQbGF5ZXJJbmZvQ3NSZXESEwoLR09MQ1BBUExPSUcYCyABKA0SKgoQ",
            "bG9iYnlfZXh0cmFfaW5mbxgPIAEoCzIQLlBsYXllckV4dHJhSW5mbxIeCgR0",
            "eXBlGAYgASgOMhAuTG9iYnlNb2RpZnlUeXBlQh6qAhtFZ2dMaW5rLkRhbmhl",
            "bmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.PlayerExtraInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.LobbyModifyTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.LobbyModifyPlayerInfoCsReq), global::EggLink.DanhengServer.Proto.LobbyModifyPlayerInfoCsReq.Parser, new[]{ "GOLCPAPLOIG", "LobbyExtraInfo", "Type" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class LobbyModifyPlayerInfoCsReq : pb::IMessage<LobbyModifyPlayerInfoCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LobbyModifyPlayerInfoCsReq> _parser = new pb::MessageParser<LobbyModifyPlayerInfoCsReq>(() => new LobbyModifyPlayerInfoCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LobbyModifyPlayerInfoCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.LobbyModifyPlayerInfoCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LobbyModifyPlayerInfoCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LobbyModifyPlayerInfoCsReq(LobbyModifyPlayerInfoCsReq other) : this() {
      gOLCPAPLOIG_ = other.gOLCPAPLOIG_;
      lobbyExtraInfo_ = other.lobbyExtraInfo_ != null ? other.lobbyExtraInfo_.Clone() : null;
      type_ = other.type_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LobbyModifyPlayerInfoCsReq Clone() {
      return new LobbyModifyPlayerInfoCsReq(this);
    }

    /// <summary>Field number for the "GOLCPAPLOIG" field.</summary>
    public const int GOLCPAPLOIGFieldNumber = 11;
    private uint gOLCPAPLOIG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GOLCPAPLOIG {
      get { return gOLCPAPLOIG_; }
      set {
        gOLCPAPLOIG_ = value;
      }
    }

    /// <summary>Field number for the "lobby_extra_info" field.</summary>
    public const int LobbyExtraInfoFieldNumber = 15;
    private global::EggLink.DanhengServer.Proto.PlayerExtraInfo lobbyExtraInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.PlayerExtraInfo LobbyExtraInfo {
      get { return lobbyExtraInfo_; }
      set {
        lobbyExtraInfo_ = value;
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 6;
    private global::EggLink.DanhengServer.Proto.LobbyModifyType type_ = global::EggLink.DanhengServer.Proto.LobbyModifyType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.LobbyModifyType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LobbyModifyPlayerInfoCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LobbyModifyPlayerInfoCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GOLCPAPLOIG != other.GOLCPAPLOIG) return false;
      if (!object.Equals(LobbyExtraInfo, other.LobbyExtraInfo)) return false;
      if (Type != other.Type) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (GOLCPAPLOIG != 0) hash ^= GOLCPAPLOIG.GetHashCode();
      if (lobbyExtraInfo_ != null) hash ^= LobbyExtraInfo.GetHashCode();
      if (Type != global::EggLink.DanhengServer.Proto.LobbyModifyType.None) hash ^= Type.GetHashCode();
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
      if (Type != global::EggLink.DanhengServer.Proto.LobbyModifyType.None) {
        output.WriteRawTag(48);
        output.WriteEnum((int) Type);
      }
      if (GOLCPAPLOIG != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(GOLCPAPLOIG);
      }
      if (lobbyExtraInfo_ != null) {
        output.WriteRawTag(122);
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
      if (Type != global::EggLink.DanhengServer.Proto.LobbyModifyType.None) {
        output.WriteRawTag(48);
        output.WriteEnum((int) Type);
      }
      if (GOLCPAPLOIG != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(GOLCPAPLOIG);
      }
      if (lobbyExtraInfo_ != null) {
        output.WriteRawTag(122);
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
      if (GOLCPAPLOIG != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GOLCPAPLOIG);
      }
      if (lobbyExtraInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LobbyExtraInfo);
      }
      if (Type != global::EggLink.DanhengServer.Proto.LobbyModifyType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(LobbyModifyPlayerInfoCsReq other) {
      if (other == null) {
        return;
      }
      if (other.GOLCPAPLOIG != 0) {
        GOLCPAPLOIG = other.GOLCPAPLOIG;
      }
      if (other.lobbyExtraInfo_ != null) {
        if (lobbyExtraInfo_ == null) {
          LobbyExtraInfo = new global::EggLink.DanhengServer.Proto.PlayerExtraInfo();
        }
        LobbyExtraInfo.MergeFrom(other.LobbyExtraInfo);
      }
      if (other.Type != global::EggLink.DanhengServer.Proto.LobbyModifyType.None) {
        Type = other.Type;
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
          case 48: {
            Type = (global::EggLink.DanhengServer.Proto.LobbyModifyType) input.ReadEnum();
            break;
          }
          case 88: {
            GOLCPAPLOIG = input.ReadUInt32();
            break;
          }
          case 122: {
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
          case 48: {
            Type = (global::EggLink.DanhengServer.Proto.LobbyModifyType) input.ReadEnum();
            break;
          }
          case 88: {
            GOLCPAPLOIG = input.ReadUInt32();
            break;
          }
          case 122: {
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