// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChatMessageData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ChatMessageData.proto</summary>
  public static partial class ChatMessageDataReflection {

    #region Descriptor
    /// <summary>File descriptor for ChatMessageData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChatMessageDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVDaGF0TWVzc2FnZURhdGEucHJvdG8aDU1zZ1R5cGUucHJvdG8aEUNER1BL",
            "SUpCRkRLLnByb3RvIp8BCg9DaGF0TWVzc2FnZURhdGESDwoHY29udGVudBgP",
            "IAEoCRIeCgxtZXNzYWdlX3R5cGUYCiABKA4yCC5Nc2dUeXBlEhAKCGV4dHJh",
            "X2lkGA4gASgNEhEKCXNlbmRlcl9pZBgNIAEoDRIhCgtMRUtQTkxBUENFRBgM",
            "IAEoCzIMLkNER1BLSUpCRkRLEhMKC2NyZWF0ZV90aW1lGAYgASgEQh6qAhtF",
            "Z2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.MsgTypeReflection.Descriptor, global::EggLink.DanhengServer.Proto.CDGPKIJBFDKReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ChatMessageData), global::EggLink.DanhengServer.Proto.ChatMessageData.Parser, new[]{ "Content", "MessageType", "ExtraId", "SenderId", "LEKPNLAPCED", "CreateTime" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ChatMessageData : pb::IMessage<ChatMessageData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChatMessageData> _parser = new pb::MessageParser<ChatMessageData>(() => new ChatMessageData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChatMessageData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ChatMessageDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChatMessageData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChatMessageData(ChatMessageData other) : this() {
      content_ = other.content_;
      messageType_ = other.messageType_;
      extraId_ = other.extraId_;
      senderId_ = other.senderId_;
      lEKPNLAPCED_ = other.lEKPNLAPCED_ != null ? other.lEKPNLAPCED_.Clone() : null;
      createTime_ = other.createTime_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChatMessageData Clone() {
      return new ChatMessageData(this);
    }

    /// <summary>Field number for the "content" field.</summary>
    public const int ContentFieldNumber = 15;
    private string content_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Content {
      get { return content_; }
      set {
        content_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "message_type" field.</summary>
    public const int MessageTypeFieldNumber = 10;
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
    public const int ExtraIdFieldNumber = 14;
    private uint extraId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ExtraId {
      get { return extraId_; }
      set {
        extraId_ = value;
      }
    }

    /// <summary>Field number for the "sender_id" field.</summary>
    public const int SenderIdFieldNumber = 13;
    private uint senderId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SenderId {
      get { return senderId_; }
      set {
        senderId_ = value;
      }
    }

    /// <summary>Field number for the "LEKPNLAPCED" field.</summary>
    public const int LEKPNLAPCEDFieldNumber = 12;
    private global::EggLink.DanhengServer.Proto.CDGPKIJBFDK lEKPNLAPCED_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.CDGPKIJBFDK LEKPNLAPCED {
      get { return lEKPNLAPCED_; }
      set {
        lEKPNLAPCED_ = value;
      }
    }

    /// <summary>Field number for the "create_time" field.</summary>
    public const int CreateTimeFieldNumber = 6;
    private ulong createTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong CreateTime {
      get { return createTime_; }
      set {
        createTime_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChatMessageData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChatMessageData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Content != other.Content) return false;
      if (MessageType != other.MessageType) return false;
      if (ExtraId != other.ExtraId) return false;
      if (SenderId != other.SenderId) return false;
      if (!object.Equals(LEKPNLAPCED, other.LEKPNLAPCED)) return false;
      if (CreateTime != other.CreateTime) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Content.Length != 0) hash ^= Content.GetHashCode();
      if (MessageType != global::EggLink.DanhengServer.Proto.MsgType.None) hash ^= MessageType.GetHashCode();
      if (ExtraId != 0) hash ^= ExtraId.GetHashCode();
      if (SenderId != 0) hash ^= SenderId.GetHashCode();
      if (lEKPNLAPCED_ != null) hash ^= LEKPNLAPCED.GetHashCode();
      if (CreateTime != 0UL) hash ^= CreateTime.GetHashCode();
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
      if (CreateTime != 0UL) {
        output.WriteRawTag(48);
        output.WriteUInt64(CreateTime);
      }
      if (MessageType != global::EggLink.DanhengServer.Proto.MsgType.None) {
        output.WriteRawTag(80);
        output.WriteEnum((int) MessageType);
      }
      if (lEKPNLAPCED_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(LEKPNLAPCED);
      }
      if (SenderId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(SenderId);
      }
      if (ExtraId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(ExtraId);
      }
      if (Content.Length != 0) {
        output.WriteRawTag(122);
        output.WriteString(Content);
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
      if (CreateTime != 0UL) {
        output.WriteRawTag(48);
        output.WriteUInt64(CreateTime);
      }
      if (MessageType != global::EggLink.DanhengServer.Proto.MsgType.None) {
        output.WriteRawTag(80);
        output.WriteEnum((int) MessageType);
      }
      if (lEKPNLAPCED_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(LEKPNLAPCED);
      }
      if (SenderId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(SenderId);
      }
      if (ExtraId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(ExtraId);
      }
      if (Content.Length != 0) {
        output.WriteRawTag(122);
        output.WriteString(Content);
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
      if (Content.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Content);
      }
      if (MessageType != global::EggLink.DanhengServer.Proto.MsgType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) MessageType);
      }
      if (ExtraId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ExtraId);
      }
      if (SenderId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SenderId);
      }
      if (lEKPNLAPCED_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LEKPNLAPCED);
      }
      if (CreateTime != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(CreateTime);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChatMessageData other) {
      if (other == null) {
        return;
      }
      if (other.Content.Length != 0) {
        Content = other.Content;
      }
      if (other.MessageType != global::EggLink.DanhengServer.Proto.MsgType.None) {
        MessageType = other.MessageType;
      }
      if (other.ExtraId != 0) {
        ExtraId = other.ExtraId;
      }
      if (other.SenderId != 0) {
        SenderId = other.SenderId;
      }
      if (other.lEKPNLAPCED_ != null) {
        if (lEKPNLAPCED_ == null) {
          LEKPNLAPCED = new global::EggLink.DanhengServer.Proto.CDGPKIJBFDK();
        }
        LEKPNLAPCED.MergeFrom(other.LEKPNLAPCED);
      }
      if (other.CreateTime != 0UL) {
        CreateTime = other.CreateTime;
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
            CreateTime = input.ReadUInt64();
            break;
          }
          case 80: {
            MessageType = (global::EggLink.DanhengServer.Proto.MsgType) input.ReadEnum();
            break;
          }
          case 98: {
            if (lEKPNLAPCED_ == null) {
              LEKPNLAPCED = new global::EggLink.DanhengServer.Proto.CDGPKIJBFDK();
            }
            input.ReadMessage(LEKPNLAPCED);
            break;
          }
          case 104: {
            SenderId = input.ReadUInt32();
            break;
          }
          case 112: {
            ExtraId = input.ReadUInt32();
            break;
          }
          case 122: {
            Content = input.ReadString();
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
            CreateTime = input.ReadUInt64();
            break;
          }
          case 80: {
            MessageType = (global::EggLink.DanhengServer.Proto.MsgType) input.ReadEnum();
            break;
          }
          case 98: {
            if (lEKPNLAPCED_ == null) {
              LEKPNLAPCED = new global::EggLink.DanhengServer.Proto.CDGPKIJBFDK();
            }
            input.ReadMessage(LEKPNLAPCED);
            break;
          }
          case 104: {
            SenderId = input.ReadUInt32();
            break;
          }
          case 112: {
            ExtraId = input.ReadUInt32();
            break;
          }
          case 122: {
            Content = input.ReadString();
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