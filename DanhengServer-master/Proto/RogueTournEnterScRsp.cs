// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueTournEnterScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueTournEnterScRsp.proto</summary>
  public static partial class RogueTournEnterScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueTournEnterScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueTournEnterScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpSb2d1ZVRvdXJuRW50ZXJTY1JzcC5wcm90bxocUm9ndWVUb3VybkN1clNj",
            "ZW5lSW5mby5wcm90bxoXUm9ndWVUb3VybkN1ckluZm8ucHJvdG8ilgEKFFJv",
            "Z3VlVG91cm5FbnRlclNjUnNwEjsKGnJvZ3VlX3RvdXJuX2N1cl9zY2VuZV9p",
            "bmZvGAUgASgLMhcuUm9ndWVUb3VybkN1clNjZW5lSW5mbxIPCgdyZXRjb2Rl",
            "GAogASgNEjAKFHJvZ3VlX3RvdXJuX2N1cl9pbmZvGAMgASgLMhIuUm9ndWVU",
            "b3VybkN1ckluZm9CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueTournCurSceneInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueTournCurInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueTournEnterScRsp), global::EggLink.DanhengServer.Proto.RogueTournEnterScRsp.Parser, new[]{ "RogueTournCurSceneInfo", "Retcode", "RogueTournCurInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueTournEnterScRsp : pb::IMessage<RogueTournEnterScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueTournEnterScRsp> _parser = new pb::MessageParser<RogueTournEnterScRsp>(() => new RogueTournEnterScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueTournEnterScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueTournEnterScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueTournEnterScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueTournEnterScRsp(RogueTournEnterScRsp other) : this() {
      rogueTournCurSceneInfo_ = other.rogueTournCurSceneInfo_ != null ? other.rogueTournCurSceneInfo_.Clone() : null;
      retcode_ = other.retcode_;
      rogueTournCurInfo_ = other.rogueTournCurInfo_ != null ? other.rogueTournCurInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueTournEnterScRsp Clone() {
      return new RogueTournEnterScRsp(this);
    }

    /// <summary>Field number for the "rogue_tourn_cur_scene_info" field.</summary>
    public const int RogueTournCurSceneInfoFieldNumber = 5;
    private global::EggLink.DanhengServer.Proto.RogueTournCurSceneInfo rogueTournCurSceneInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueTournCurSceneInfo RogueTournCurSceneInfo {
      get { return rogueTournCurSceneInfo_; }
      set {
        rogueTournCurSceneInfo_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 10;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "rogue_tourn_cur_info" field.</summary>
    public const int RogueTournCurInfoFieldNumber = 3;
    private global::EggLink.DanhengServer.Proto.RogueTournCurInfo rogueTournCurInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueTournCurInfo RogueTournCurInfo {
      get { return rogueTournCurInfo_; }
      set {
        rogueTournCurInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueTournEnterScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueTournEnterScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(RogueTournCurSceneInfo, other.RogueTournCurSceneInfo)) return false;
      if (Retcode != other.Retcode) return false;
      if (!object.Equals(RogueTournCurInfo, other.RogueTournCurInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (rogueTournCurSceneInfo_ != null) hash ^= RogueTournCurSceneInfo.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (rogueTournCurInfo_ != null) hash ^= RogueTournCurInfo.GetHashCode();
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
      if (rogueTournCurSceneInfo_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(RogueTournCurSceneInfo);
      }
      if (Retcode != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Retcode);
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
      if (rogueTournCurSceneInfo_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(RogueTournCurSceneInfo);
      }
      if (Retcode != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Retcode);
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
      if (rogueTournCurSceneInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueTournCurSceneInfo);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (rogueTournCurInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueTournCurInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueTournEnterScRsp other) {
      if (other == null) {
        return;
      }
      if (other.rogueTournCurSceneInfo_ != null) {
        if (rogueTournCurSceneInfo_ == null) {
          RogueTournCurSceneInfo = new global::EggLink.DanhengServer.Proto.RogueTournCurSceneInfo();
        }
        RogueTournCurSceneInfo.MergeFrom(other.RogueTournCurSceneInfo);
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.rogueTournCurInfo_ != null) {
        if (rogueTournCurInfo_ == null) {
          RogueTournCurInfo = new global::EggLink.DanhengServer.Proto.RogueTournCurInfo();
        }
        RogueTournCurInfo.MergeFrom(other.RogueTournCurInfo);
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
              RogueTournCurInfo = new global::EggLink.DanhengServer.Proto.RogueTournCurInfo();
            }
            input.ReadMessage(RogueTournCurInfo);
            break;
          }
          case 42: {
            if (rogueTournCurSceneInfo_ == null) {
              RogueTournCurSceneInfo = new global::EggLink.DanhengServer.Proto.RogueTournCurSceneInfo();
            }
            input.ReadMessage(RogueTournCurSceneInfo);
            break;
          }
          case 80: {
            Retcode = input.ReadUInt32();
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
              RogueTournCurInfo = new global::EggLink.DanhengServer.Proto.RogueTournCurInfo();
            }
            input.ReadMessage(RogueTournCurInfo);
            break;
          }
          case 42: {
            if (rogueTournCurSceneInfo_ == null) {
              RogueTournCurSceneInfo = new global::EggLink.DanhengServer.Proto.RogueTournCurSceneInfo();
            }
            input.ReadMessage(RogueTournCurSceneInfo);
            break;
          }
          case 80: {
            Retcode = input.ReadUInt32();
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
