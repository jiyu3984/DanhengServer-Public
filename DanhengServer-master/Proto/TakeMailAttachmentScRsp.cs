// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TakeMailAttachmentScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from TakeMailAttachmentScRsp.proto</summary>
  public static partial class TakeMailAttachmentScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for TakeMailAttachmentScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TakeMailAttachmentScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1UYWtlTWFpbEF0dGFjaG1lbnRTY1JzcC5wcm90bxoeQ2xpZW50TWFpbEF0",
            "dGFjaG1lbnRJdGVtLnByb3RvGg5JdGVtTGlzdC5wcm90byKXAQoXVGFrZU1h",
            "aWxBdHRhY2htZW50U2NSc3ASMQoOZmFpbF9tYWlsX2xpc3QYDCADKAsyGS5D",
            "bGllbnRNYWlsQXR0YWNobWVudEl0ZW0SHQoKYXR0YWNobWVudBgOIAEoCzIJ",
            "Lkl0ZW1MaXN0Eg8KB3JldGNvZGUYCSABKA0SGQoRc3VjY19tYWlsX2lkX2xp",
            "c3QYByADKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ClientMailAttachmentItemReflection.Descriptor, global::EggLink.DanhengServer.Proto.ItemListReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.TakeMailAttachmentScRsp), global::EggLink.DanhengServer.Proto.TakeMailAttachmentScRsp.Parser, new[]{ "FailMailList", "Attachment", "Retcode", "SuccMailIdList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class TakeMailAttachmentScRsp : pb::IMessage<TakeMailAttachmentScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TakeMailAttachmentScRsp> _parser = new pb::MessageParser<TakeMailAttachmentScRsp>(() => new TakeMailAttachmentScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TakeMailAttachmentScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.TakeMailAttachmentScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TakeMailAttachmentScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TakeMailAttachmentScRsp(TakeMailAttachmentScRsp other) : this() {
      failMailList_ = other.failMailList_.Clone();
      attachment_ = other.attachment_ != null ? other.attachment_.Clone() : null;
      retcode_ = other.retcode_;
      succMailIdList_ = other.succMailIdList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TakeMailAttachmentScRsp Clone() {
      return new TakeMailAttachmentScRsp(this);
    }

    /// <summary>Field number for the "fail_mail_list" field.</summary>
    public const int FailMailListFieldNumber = 12;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.ClientMailAttachmentItem> _repeated_failMailList_codec
        = pb::FieldCodec.ForMessage(98, global::EggLink.DanhengServer.Proto.ClientMailAttachmentItem.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ClientMailAttachmentItem> failMailList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ClientMailAttachmentItem>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ClientMailAttachmentItem> FailMailList {
      get { return failMailList_; }
    }

    /// <summary>Field number for the "attachment" field.</summary>
    public const int AttachmentFieldNumber = 14;
    private global::EggLink.DanhengServer.Proto.ItemList attachment_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemList Attachment {
      get { return attachment_; }
      set {
        attachment_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 9;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "succ_mail_id_list" field.</summary>
    public const int SuccMailIdListFieldNumber = 7;
    private static readonly pb::FieldCodec<uint> _repeated_succMailIdList_codec
        = pb::FieldCodec.ForUInt32(58);
    private readonly pbc::RepeatedField<uint> succMailIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> SuccMailIdList {
      get { return succMailIdList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TakeMailAttachmentScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TakeMailAttachmentScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!failMailList_.Equals(other.failMailList_)) return false;
      if (!object.Equals(Attachment, other.Attachment)) return false;
      if (Retcode != other.Retcode) return false;
      if(!succMailIdList_.Equals(other.succMailIdList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= failMailList_.GetHashCode();
      if (attachment_ != null) hash ^= Attachment.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      hash ^= succMailIdList_.GetHashCode();
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
      succMailIdList_.WriteTo(output, _repeated_succMailIdList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Retcode);
      }
      failMailList_.WriteTo(output, _repeated_failMailList_codec);
      if (attachment_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(Attachment);
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
      succMailIdList_.WriteTo(ref output, _repeated_succMailIdList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Retcode);
      }
      failMailList_.WriteTo(ref output, _repeated_failMailList_codec);
      if (attachment_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(Attachment);
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
      size += failMailList_.CalculateSize(_repeated_failMailList_codec);
      if (attachment_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Attachment);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      size += succMailIdList_.CalculateSize(_repeated_succMailIdList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TakeMailAttachmentScRsp other) {
      if (other == null) {
        return;
      }
      failMailList_.Add(other.failMailList_);
      if (other.attachment_ != null) {
        if (attachment_ == null) {
          Attachment = new global::EggLink.DanhengServer.Proto.ItemList();
        }
        Attachment.MergeFrom(other.Attachment);
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      succMailIdList_.Add(other.succMailIdList_);
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
          case 58:
          case 56: {
            succMailIdList_.AddEntriesFrom(input, _repeated_succMailIdList_codec);
            break;
          }
          case 72: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 98: {
            failMailList_.AddEntriesFrom(input, _repeated_failMailList_codec);
            break;
          }
          case 114: {
            if (attachment_ == null) {
              Attachment = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(Attachment);
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
          case 58:
          case 56: {
            succMailIdList_.AddEntriesFrom(ref input, _repeated_succMailIdList_codec);
            break;
          }
          case 72: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 98: {
            failMailList_.AddEntriesFrom(ref input, _repeated_failMailList_codec);
            break;
          }
          case 114: {
            if (attachment_ == null) {
              Attachment = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(Attachment);
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
