// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MarkRelicFilterPlanScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from MarkRelicFilterPlanScRsp.proto</summary>
  public static partial class MarkRelicFilterPlanScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for MarkRelicFilterPlanScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MarkRelicFilterPlanScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5NYXJrUmVsaWNGaWx0ZXJQbGFuU2NSc3AucHJvdG8iagoYTWFya1JlbGlj",
            "RmlsdGVyUGxhblNjUnNwEhMKC2lzX2JhdGNoX29wGAsgASgIEhcKD3Nsb3Rf",
            "aW5kZXhfbGlzdBgJIAMoDRIPCgdyZXRjb2RlGAEgASgNEg8KB2lzX21hcmsY",
            "AyABKAhCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.MarkRelicFilterPlanScRsp), global::EggLink.DanhengServer.Proto.MarkRelicFilterPlanScRsp.Parser, new[]{ "IsBatchOp", "SlotIndexList", "Retcode", "IsMark" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class MarkRelicFilterPlanScRsp : pb::IMessage<MarkRelicFilterPlanScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MarkRelicFilterPlanScRsp> _parser = new pb::MessageParser<MarkRelicFilterPlanScRsp>(() => new MarkRelicFilterPlanScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MarkRelicFilterPlanScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.MarkRelicFilterPlanScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MarkRelicFilterPlanScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MarkRelicFilterPlanScRsp(MarkRelicFilterPlanScRsp other) : this() {
      isBatchOp_ = other.isBatchOp_;
      slotIndexList_ = other.slotIndexList_.Clone();
      retcode_ = other.retcode_;
      isMark_ = other.isMark_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MarkRelicFilterPlanScRsp Clone() {
      return new MarkRelicFilterPlanScRsp(this);
    }

    /// <summary>Field number for the "is_batch_op" field.</summary>
    public const int IsBatchOpFieldNumber = 11;
    private bool isBatchOp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsBatchOp {
      get { return isBatchOp_; }
      set {
        isBatchOp_ = value;
      }
    }

    /// <summary>Field number for the "slot_index_list" field.</summary>
    public const int SlotIndexListFieldNumber = 9;
    private static readonly pb::FieldCodec<uint> _repeated_slotIndexList_codec
        = pb::FieldCodec.ForUInt32(74);
    private readonly pbc::RepeatedField<uint> slotIndexList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> SlotIndexList {
      get { return slotIndexList_; }
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

    /// <summary>Field number for the "is_mark" field.</summary>
    public const int IsMarkFieldNumber = 3;
    private bool isMark_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsMark {
      get { return isMark_; }
      set {
        isMark_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MarkRelicFilterPlanScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MarkRelicFilterPlanScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsBatchOp != other.IsBatchOp) return false;
      if(!slotIndexList_.Equals(other.slotIndexList_)) return false;
      if (Retcode != other.Retcode) return false;
      if (IsMark != other.IsMark) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsBatchOp != false) hash ^= IsBatchOp.GetHashCode();
      hash ^= slotIndexList_.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (IsMark != false) hash ^= IsMark.GetHashCode();
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
      if (IsMark != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsMark);
      }
      slotIndexList_.WriteTo(output, _repeated_slotIndexList_codec);
      if (IsBatchOp != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsBatchOp);
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
      if (IsMark != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsMark);
      }
      slotIndexList_.WriteTo(ref output, _repeated_slotIndexList_codec);
      if (IsBatchOp != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsBatchOp);
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
      if (IsBatchOp != false) {
        size += 1 + 1;
      }
      size += slotIndexList_.CalculateSize(_repeated_slotIndexList_codec);
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (IsMark != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MarkRelicFilterPlanScRsp other) {
      if (other == null) {
        return;
      }
      if (other.IsBatchOp != false) {
        IsBatchOp = other.IsBatchOp;
      }
      slotIndexList_.Add(other.slotIndexList_);
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.IsMark != false) {
        IsMark = other.IsMark;
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
          case 24: {
            IsMark = input.ReadBool();
            break;
          }
          case 74:
          case 72: {
            slotIndexList_.AddEntriesFrom(input, _repeated_slotIndexList_codec);
            break;
          }
          case 88: {
            IsBatchOp = input.ReadBool();
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
          case 24: {
            IsMark = input.ReadBool();
            break;
          }
          case 74:
          case 72: {
            slotIndexList_.AddEntriesFrom(ref input, _repeated_slotIndexList_codec);
            break;
          }
          case 88: {
            IsBatchOp = input.ReadBool();
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
