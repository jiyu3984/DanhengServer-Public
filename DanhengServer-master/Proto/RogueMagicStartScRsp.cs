// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueMagicStartScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueMagicStartScRsp.proto</summary>
  public static partial class RogueMagicStartScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueMagicStartScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueMagicStartScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpSb2d1ZU1hZ2ljU3RhcnRTY1JzcC5wcm90bxoXUm9ndWVNYWdpY0N1cklu",
            "Zm8ucHJvdG8aHFJvZ3VlTWFnaWNDdXJTY2VuZUluZm8ucHJvdG8ilgEKFFJv",
            "Z3VlTWFnaWNTdGFydFNjUnNwEjAKFHJvZ3VlX3RvdXJuX2N1cl9pbmZvGAMg",
            "ASgLMhIuUm9ndWVNYWdpY0N1ckluZm8SOwoacm9ndWVfdG91cm5fY3VyX3Nj",
            "ZW5lX2luZm8YDCABKAsyFy5Sb2d1ZU1hZ2ljQ3VyU2NlbmVJbmZvEg8KB3Jl",
            "dGNvZGUYCCABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueMagicCurInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueMagicCurSceneInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueMagicStartScRsp), global::EggLink.DanhengServer.Proto.RogueMagicStartScRsp.Parser, new[]{ "RogueTournCurInfo", "RogueTournCurSceneInfo", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueMagicStartScRsp : pb::IMessage<RogueMagicStartScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueMagicStartScRsp> _parser = new pb::MessageParser<RogueMagicStartScRsp>(() => new RogueMagicStartScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueMagicStartScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueMagicStartScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueMagicStartScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueMagicStartScRsp(RogueMagicStartScRsp other) : this() {
      rogueTournCurInfo_ = other.rogueTournCurInfo_ != null ? other.rogueTournCurInfo_.Clone() : null;
      rogueTournCurSceneInfo_ = other.rogueTournCurSceneInfo_ != null ? other.rogueTournCurSceneInfo_.Clone() : null;
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueMagicStartScRsp Clone() {
      return new RogueMagicStartScRsp(this);
    }

    /// <summary>Field number for the "rogue_tourn_cur_info" field.</summary>
    public const int RogueTournCurInfoFieldNumber = 3;
    private global::EggLink.DanhengServer.Proto.RogueMagicCurInfo rogueTournCurInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueMagicCurInfo RogueTournCurInfo {
      get { return rogueTournCurInfo_; }
      set {
        rogueTournCurInfo_ = value;
      }
    }

    /// <summary>Field number for the "rogue_tourn_cur_scene_info" field.</summary>
    public const int RogueTournCurSceneInfoFieldNumber = 12;
    private global::EggLink.DanhengServer.Proto.RogueMagicCurSceneInfo rogueTournCurSceneInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueMagicCurSceneInfo RogueTournCurSceneInfo {
      get { return rogueTournCurSceneInfo_; }
      set {
        rogueTournCurSceneInfo_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 8;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueMagicStartScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueMagicStartScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(RogueTournCurInfo, other.RogueTournCurInfo)) return false;
      if (!object.Equals(RogueTournCurSceneInfo, other.RogueTournCurSceneInfo)) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (rogueTournCurInfo_ != null) hash ^= RogueTournCurInfo.GetHashCode();
      if (rogueTournCurSceneInfo_ != null) hash ^= RogueTournCurSceneInfo.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
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
      if (rogueTournCurInfo_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(RogueTournCurInfo);
      }
      if (Retcode != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Retcode);
      }
      if (rogueTournCurSceneInfo_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(RogueTournCurSceneInfo);
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
      if (rogueTournCurInfo_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(RogueTournCurInfo);
      }
      if (Retcode != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Retcode);
      }
      if (rogueTournCurSceneInfo_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(RogueTournCurSceneInfo);
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
      if (rogueTournCurInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueTournCurInfo);
      }
      if (rogueTournCurSceneInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueTournCurSceneInfo);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueMagicStartScRsp other) {
      if (other == null) {
        return;
      }
      if (other.rogueTournCurInfo_ != null) {
        if (rogueTournCurInfo_ == null) {
          RogueTournCurInfo = new global::EggLink.DanhengServer.Proto.RogueMagicCurInfo();
        }
        RogueTournCurInfo.MergeFrom(other.RogueTournCurInfo);
      }
      if (other.rogueTournCurSceneInfo_ != null) {
        if (rogueTournCurSceneInfo_ == null) {
          RogueTournCurSceneInfo = new global::EggLink.DanhengServer.Proto.RogueMagicCurSceneInfo();
        }
        RogueTournCurSceneInfo.MergeFrom(other.RogueTournCurSceneInfo);
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
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
          case 26: {
            if (rogueTournCurInfo_ == null) {
              RogueTournCurInfo = new global::EggLink.DanhengServer.Proto.RogueMagicCurInfo();
            }
            input.ReadMessage(RogueTournCurInfo);
            break;
          }
          case 64: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 98: {
            if (rogueTournCurSceneInfo_ == null) {
              RogueTournCurSceneInfo = new global::EggLink.DanhengServer.Proto.RogueMagicCurSceneInfo();
            }
            input.ReadMessage(RogueTournCurSceneInfo);
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
          case 26: {
            if (rogueTournCurInfo_ == null) {
              RogueTournCurInfo = new global::EggLink.DanhengServer.Proto.RogueMagicCurInfo();
            }
            input.ReadMessage(RogueTournCurInfo);
            break;
          }
          case 64: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 98: {
            if (rogueTournCurSceneInfo_ == null) {
              RogueTournCurSceneInfo = new global::EggLink.DanhengServer.Proto.RogueMagicCurSceneInfo();
            }
            input.ReadMessage(RogueTournCurSceneInfo);
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