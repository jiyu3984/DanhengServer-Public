// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SendMsgCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SendMsgCsReq.proto</summary>
  public static partial class SendMsgCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for SendMsgCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SendMsgCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJTZW5kTXNnQ3NSZXEucHJvdG8aEUNER1BLSUpCRkRLLnByb3RvGg5DaGF0",
            "VHlwZS5wcm90bxoNTXNnVHlwZS5wcm90byKsAQoMU2VuZE1zZ0NzUmVxEhwK",
            "CWNoYXRfdHlwZRgNIAEoDjIJLkNoYXRUeXBlEh4KDG1lc3NhZ2VfdHlwZRgG",
            "IAEoDjIILk1zZ1R5cGUSEAoIZXh0cmFfaWQYCiABKA0SIQoLTEVLUE5MQVBD",
            "RUQYAiABKAsyDC5DREdQS0lKQkZESxITCgt0YXJnZXRfbGlzdBgIIAMoDRIU",
            "CgxtZXNzYWdlX3RleHQYCyABKAlCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZl",
            "ci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.CDGPKIJBFDKReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChatTypeReflection.Descriptor, global::EggLink.DanhengServer.Proto.MsgTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SendMsgCsReq), global::EggLink.DanhengServer.Proto.SendMsgCsReq.Parser, new[]{ "ChatType", "MessageType", "ExtraId", "LEKPNLAPCED", "TargetList", "MessageText" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SendMsgCsReq : pb::IMessage<SendMsgCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SendMsgCsReq> _parser = new pb::MessageParser<SendMsgCsReq>(() => new SendMsgCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SendMsgCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.SendMsgCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SendMsgCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SendMsgCsReq(SendMsgCsReq other) : this() {
      chatType_ = other.chatType_;
      messageType_ = other.messageType_;
      extraId_ = other.extraId_;
      lEKPNLAPCED_ = other.lEKPNLAPCED_ != null ? other.lEKPNLAPCED_.Clone() : null;
      targetList_ = other.targetList_.Clone();
      messageText_ = other.messageText_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SendMsgCsReq Clone() {
      return new SendMsgCsReq(this);
    }

    /// <summary>Field number for the "chat_type" field.</summary>
    public const int ChatTypeFieldNumber = 13;
    private global::EggLink.DanhengServer.Proto.ChatType chatType_ = global::EggLink.DanhengServer.Proto.ChatType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChatType ChatType {
      get { return chatType_; }
      set {
        chatType_ = value;
      }
    }

    /// <summary>Field number for the "message_type" field.</summary>
    public const int MessageTypeFieldNumber = 6;
    private global::EggLink.DanhengServer.Proto.MsgType messageType_ = global::EggLink.DanhengServer.Proto.MsgType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.MsgType MessageType {
      get { return messageType_; }
      set {
        messageType_ = value;
      }
    }

    /// <summary>Field number for the "extra_id" field.</summary>
    public const int ExtraIdFieldNumber = 10;
    private uint extraId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ExtraId {
      get { return extraId_; }
      set {
        extraId_ = value;
      }
    }

    /// <summary>Field number for the "LEKPNLAPCED" field.</summary>
    public const int LEKPNLAPCEDFieldNumber = 2;
    private global::EggLink.DanhengServer.Proto.CDGPKIJBFDK lEKPNLAPCED_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.CDGPKIJBFDK LEKPNLAPCED {
      get { return lEKPNLAPCED_; }
      set {
        lEKPNLAPCED_ = value;
      }
    }

    /// <summary>Field number for the "target_list" field.</summary>
    public const int TargetListFieldNumber = 8;
    private static readonly pb::FieldCodec<uint> _repeated_targetList_codec
        = pb::FieldCodec.ForUInt32(66);
    private readonly pbc::RepeatedField<uint> targetList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> TargetList {
      get { return targetList_; }
    }

    /// <summary>Field number for the "message_text" field.</summary>
    public const int MessageTextFieldNumber = 11;
    private string messageText_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string MessageText {
      get { return messageText_; }
      set {
        messageText_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SendMsgCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SendMsgCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ChatType != other.ChatType) return false;
      if (MessageType != other.MessageType) return false;
      if (ExtraId != other.ExtraId) return false;
      if (!object.Equals(LEKPNLAPCED, other.LEKPNLAPCED)) return false;
      if(!targetList_.Equals(other.targetList_)) return false;
      if (MessageText != other.MessageText) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ChatType != global::EggLink.DanhengServer.Proto.ChatType.None) hash ^= ChatType.GetHashCode();
      if (MessageType != global::EggLink.DanhengServer.Proto.MsgType.None) hash ^= MessageType.GetHashCode();
      if (ExtraId != 0) hash ^= ExtraId.GetHashCode();
      if (lEKPNLAPCED_ != null) hash ^= LEKPNLAPCED.GetHashCode();
      hash ^= targetList_.GetHashCode();
      if (MessageText.Length != 0) hash ^= MessageText.GetHashCode();
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
      if (lEKPNLAPCED_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(LEKPNLAPCED);
      }
      if (MessageType != global::EggLink.DanhengServer.Proto.MsgType.None) {
        output.WriteRawTag(48);
        output.WriteEnum((int) MessageType);
      }
      targetList_.WriteTo(output, _repeated_targetList_codec);
      if (ExtraId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(ExtraId);
      }
      if (MessageText.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(MessageText);
      }
      if (ChatType != global::EggLink.DanhengServer.Proto.ChatType.None) {
        output.WriteRawTag(104);
        output.WriteEnum((int) ChatType);
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
      if (lEKPNLAPCED_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(LEKPNLAPCED);
      }
      if (MessageType != global::EggLink.DanhengServer.Proto.MsgType.None) {
        output.WriteRawTag(48);
        output.WriteEnum((int) MessageType);
      }
      targetList_.WriteTo(ref output, _repeated_targetList_codec);
      if (ExtraId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(ExtraId);
      }
      if (MessageText.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(MessageText);
      }
      if (ChatType != global::EggLink.DanhengServer.Proto.ChatType.None) {
        output.WriteRawTag(104);
        output.WriteEnum((int) ChatType);
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
      if (ChatType != global::EggLink.DanhengServer.Proto.ChatType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ChatType);
      }
      if (MessageType != global::EggLink.DanhengServer.Proto.MsgType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) MessageType);
      }
      if (ExtraId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ExtraId);
      }
      if (lEKPNLAPCED_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LEKPNLAPCED);
      }
      size += targetList_.CalculateSize(_repeated_targetList_codec);
      if (MessageText.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MessageText);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SendMsgCsReq other) {
      if (other == null) {
        return;
      }
      if (other.ChatType != global::EggLink.DanhengServer.Proto.ChatType.None) {
        ChatType = other.ChatType;
      }
      if (other.MessageType != global::EggLink.DanhengServer.Proto.MsgType.None) {
        MessageType = other.MessageType;
      }
      if (other.ExtraId != 0) {
        ExtraId = other.ExtraId;
      }
      if (other.lEKPNLAPCED_ != null) {
        if (lEKPNLAPCED_ == null) {
          LEKPNLAPCED = new global::EggLink.DanhengServer.Proto.CDGPKIJBFDK();
        }
        LEKPNLAPCED.MergeFrom(other.LEKPNLAPCED);
      }
      targetList_.Add(other.targetList_);
      if (other.MessageText.Length != 0) {
        MessageText = other.MessageText;
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
          case 18: {
            if (lEKPNLAPCED_ == null) {
              LEKPNLAPCED = new global::EggLink.DanhengServer.Proto.CDGPKIJBFDK();
            }
            input.ReadMessage(LEKPNLAPCED);
            break;
          }
          case 48: {
            MessageType = (global::EggLink.DanhengServer.Proto.MsgType) input.ReadEnum();
            break;
          }
          case 66:
          case 64: {
            targetList_.AddEntriesFrom(input, _repeated_targetList_codec);
            break;
          }
          case 80: {
            ExtraId = input.ReadUInt32();
            break;
          }
          case 90: {
            MessageText = input.ReadString();
            break;
          }
          case 104: {
            ChatType = (global::EggLink.DanhengServer.Proto.ChatType) input.ReadEnum();
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
          case 18: {
            if (lEKPNLAPCED_ == null) {
              LEKPNLAPCED = new global::EggLink.DanhengServer.Proto.CDGPKIJBFDK();
            }
            input.ReadMessage(LEKPNLAPCED);
            break;
          }
          case 48: {
            MessageType = (global::EggLink.DanhengServer.Proto.MsgType) input.ReadEnum();
            break;
          }
          case 66:
          case 64: {
            targetList_.AddEntriesFrom(ref input, _repeated_targetList_codec);
            break;
          }
          case 80: {
            ExtraId = input.ReadUInt32();
            break;
          }
          case 90: {
            MessageText = input.ReadString();
            break;
          }
          case 104: {
            ChatType = (global::EggLink.DanhengServer.Proto.ChatType) input.ReadEnum();
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
