// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: UpdateMarkChestScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from UpdateMarkChestScRsp.proto</summary>
  public static partial class UpdateMarkChestScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for UpdateMarkChestScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UpdateMarkChestScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpVcGRhdGVNYXJrQ2hlc3RTY1JzcC5wcm90bxoXTWFya0NoZXN0RnVuY0lu",
            "Zm8ucHJvdG8ifwoUVXBkYXRlTWFya0NoZXN0U2NSc3ASDwoHcmV0Y29kZRgB",
            "IAEoDRIwChRtYXJrX2NoZXN0X2Z1bmNfaW5mbxgGIAMoCzISLk1hcmtDaGVz",
            "dEZ1bmNJbmZvEhMKC09NQkVDSU1OR0VFGAggASgNEg8KB2Z1bmNfaWQYDiAB",
            "KA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.MarkChestFuncInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.UpdateMarkChestScRsp), global::EggLink.DanhengServer.Proto.UpdateMarkChestScRsp.Parser, new[]{ "Retcode", "MarkChestFuncInfo", "OMBECIMNGEE", "FuncId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class UpdateMarkChestScRsp : pb::IMessage<UpdateMarkChestScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UpdateMarkChestScRsp> _parser = new pb::MessageParser<UpdateMarkChestScRsp>(() => new UpdateMarkChestScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<UpdateMarkChestScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.UpdateMarkChestScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UpdateMarkChestScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UpdateMarkChestScRsp(UpdateMarkChestScRsp other) : this() {
      retcode_ = other.retcode_;
      markChestFuncInfo_ = other.markChestFuncInfo_.Clone();
      oMBECIMNGEE_ = other.oMBECIMNGEE_;
      funcId_ = other.funcId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UpdateMarkChestScRsp Clone() {
      return new UpdateMarkChestScRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 1;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "mark_chest_func_info" field.</summary>
    public const int MarkChestFuncInfoFieldNumber = 6;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.MarkChestFuncInfo> _repeated_markChestFuncInfo_codec
        = pb::FieldCodec.ForMessage(50, global::EggLink.DanhengServer.Proto.MarkChestFuncInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MarkChestFuncInfo> markChestFuncInfo_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MarkChestFuncInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MarkChestFuncInfo> MarkChestFuncInfo {
      get { return markChestFuncInfo_; }
    }

    /// <summary>Field number for the "OMBECIMNGEE" field.</summary>
    public const int OMBECIMNGEEFieldNumber = 8;
    private uint oMBECIMNGEE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OMBECIMNGEE {
      get { return oMBECIMNGEE_; }
      set {
        oMBECIMNGEE_ = value;
      }
    }

    /// <summary>Field number for the "func_id" field.</summary>
    public const int FuncIdFieldNumber = 14;
    private uint funcId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FuncId {
      get { return funcId_; }
      set {
        funcId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as UpdateMarkChestScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(UpdateMarkChestScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if(!markChestFuncInfo_.Equals(other.markChestFuncInfo_)) return false;
      if (OMBECIMNGEE != other.OMBECIMNGEE) return false;
      if (FuncId != other.FuncId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      hash ^= markChestFuncInfo_.GetHashCode();
      if (OMBECIMNGEE != 0) hash ^= OMBECIMNGEE.GetHashCode();
      if (FuncId != 0) hash ^= FuncId.GetHashCode();
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
      if (Retcode != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Retcode);
      }
      markChestFuncInfo_.WriteTo(output, _repeated_markChestFuncInfo_codec);
      if (OMBECIMNGEE != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(OMBECIMNGEE);
      }
      if (FuncId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(FuncId);
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
      if (Retcode != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Retcode);
      }
      markChestFuncInfo_.WriteTo(ref output, _repeated_markChestFuncInfo_codec);
      if (OMBECIMNGEE != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(OMBECIMNGEE);
      }
      if (FuncId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(FuncId);
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
      size += markChestFuncInfo_.CalculateSize(_repeated_markChestFuncInfo_codec);
      if (OMBECIMNGEE != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OMBECIMNGEE);
      }
      if (FuncId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FuncId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(UpdateMarkChestScRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      markChestFuncInfo_.Add(other.markChestFuncInfo_);
      if (other.OMBECIMNGEE != 0) {
        OMBECIMNGEE = other.OMBECIMNGEE;
      }
      if (other.FuncId != 0) {
        FuncId = other.FuncId;
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
            Retcode = input.ReadUInt32();
            break;
          }
          case 50: {
            markChestFuncInfo_.AddEntriesFrom(input, _repeated_markChestFuncInfo_codec);
            break;
          }
          case 64: {
            OMBECIMNGEE = input.ReadUInt32();
            break;
          }
          case 112: {
            FuncId = input.ReadUInt32();
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
            Retcode = input.ReadUInt32();
            break;
          }
          case 50: {
            markChestFuncInfo_.AddEntriesFrom(ref input, _repeated_markChestFuncInfo_codec);
            break;
          }
          case 64: {
            OMBECIMNGEE = input.ReadUInt32();
            break;
          }
          case 112: {
            FuncId = input.ReadUInt32();
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