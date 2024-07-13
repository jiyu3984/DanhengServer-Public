// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChessRogueCheatRollScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ChessRogueCheatRollScRsp.proto</summary>
  public static partial class ChessRogueCheatRollScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for ChessRogueCheatRollScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChessRogueCheatRollScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5DaGVzc1JvZ3VlQ2hlYXRSb2xsU2NSc3AucHJvdG8aGENoZXNzUm9ndWVE",
            "aWNlSW5mby5wcm90byKCAQoYQ2hlc3NSb2d1ZUNoZWF0Um9sbFNjUnNwEg8K",
            "B3JldGNvZGUYAyABKA0SEwoLR09IUEJBRlBJUEEYASABKA0SLAoPcm9ndWVf",
            "ZGljZV9pbmZvGAQgASgLMhMuQ2hlc3NSb2d1ZURpY2VJbmZvEhIKCnN1cmZh",
            "Y2VfaWQYDyABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ChessRogueDiceInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ChessRogueCheatRollScRsp), global::EggLink.DanhengServer.Proto.ChessRogueCheatRollScRsp.Parser, new[]{ "Retcode", "GOHPBAFPIPA", "RogueDiceInfo", "SurfaceId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ChessRogueCheatRollScRsp : pb::IMessage<ChessRogueCheatRollScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChessRogueCheatRollScRsp> _parser = new pb::MessageParser<ChessRogueCheatRollScRsp>(() => new ChessRogueCheatRollScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChessRogueCheatRollScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ChessRogueCheatRollScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueCheatRollScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueCheatRollScRsp(ChessRogueCheatRollScRsp other) : this() {
      retcode_ = other.retcode_;
      gOHPBAFPIPA_ = other.gOHPBAFPIPA_;
      rogueDiceInfo_ = other.rogueDiceInfo_ != null ? other.rogueDiceInfo_.Clone() : null;
      surfaceId_ = other.surfaceId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueCheatRollScRsp Clone() {
      return new ChessRogueCheatRollScRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 3;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "GOHPBAFPIPA" field.</summary>
    public const int GOHPBAFPIPAFieldNumber = 1;
    private uint gOHPBAFPIPA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GOHPBAFPIPA {
      get { return gOHPBAFPIPA_; }
      set {
        gOHPBAFPIPA_ = value;
      }
    }

    /// <summary>Field number for the "rogue_dice_info" field.</summary>
    public const int RogueDiceInfoFieldNumber = 4;
    private global::EggLink.DanhengServer.Proto.ChessRogueDiceInfo rogueDiceInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueDiceInfo RogueDiceInfo {
      get { return rogueDiceInfo_; }
      set {
        rogueDiceInfo_ = value;
      }
    }

    /// <summary>Field number for the "surface_id" field.</summary>
    public const int SurfaceIdFieldNumber = 15;
    private uint surfaceId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SurfaceId {
      get { return surfaceId_; }
      set {
        surfaceId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChessRogueCheatRollScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChessRogueCheatRollScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (GOHPBAFPIPA != other.GOHPBAFPIPA) return false;
      if (!object.Equals(RogueDiceInfo, other.RogueDiceInfo)) return false;
      if (SurfaceId != other.SurfaceId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (GOHPBAFPIPA != 0) hash ^= GOHPBAFPIPA.GetHashCode();
      if (rogueDiceInfo_ != null) hash ^= RogueDiceInfo.GetHashCode();
      if (SurfaceId != 0) hash ^= SurfaceId.GetHashCode();
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
      if (GOHPBAFPIPA != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(GOHPBAFPIPA);
      }
      if (Retcode != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Retcode);
      }
      if (rogueDiceInfo_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(RogueDiceInfo);
      }
      if (SurfaceId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(SurfaceId);
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
      if (GOHPBAFPIPA != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(GOHPBAFPIPA);
      }
      if (Retcode != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Retcode);
      }
      if (rogueDiceInfo_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(RogueDiceInfo);
      }
      if (SurfaceId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(SurfaceId);
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
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (GOHPBAFPIPA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GOHPBAFPIPA);
      }
      if (rogueDiceInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueDiceInfo);
      }
      if (SurfaceId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SurfaceId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChessRogueCheatRollScRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.GOHPBAFPIPA != 0) {
        GOHPBAFPIPA = other.GOHPBAFPIPA;
      }
      if (other.rogueDiceInfo_ != null) {
        if (rogueDiceInfo_ == null) {
          RogueDiceInfo = new global::EggLink.DanhengServer.Proto.ChessRogueDiceInfo();
        }
        RogueDiceInfo.MergeFrom(other.RogueDiceInfo);
      }
      if (other.SurfaceId != 0) {
        SurfaceId = other.SurfaceId;
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
            GOHPBAFPIPA = input.ReadUInt32();
            break;
          }
          case 24: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 34: {
            if (rogueDiceInfo_ == null) {
              RogueDiceInfo = new global::EggLink.DanhengServer.Proto.ChessRogueDiceInfo();
            }
            input.ReadMessage(RogueDiceInfo);
            break;
          }
          case 120: {
            SurfaceId = input.ReadUInt32();
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
            GOHPBAFPIPA = input.ReadUInt32();
            break;
          }
          case 24: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 34: {
            if (rogueDiceInfo_ == null) {
              RogueDiceInfo = new global::EggLink.DanhengServer.Proto.ChessRogueDiceInfo();
            }
            input.ReadMessage(RogueDiceInfo);
            break;
          }
          case 120: {
            SurfaceId = input.ReadUInt32();
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