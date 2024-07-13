// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ClientMail.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ClientMail.proto</summary>
  public static partial class ClientMailReflection {

    #region Descriptor
    /// <summary>File descriptor for ClientMail.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClientMailReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBDbGllbnRNYWlsLnByb3RvGg5NYWlsVHlwZS5wcm90bxoOSXRlbUxpc3Qu",
            "cHJvdG8i5gEKCkNsaWVudE1haWwSDgoGc2VuZGVyGAYgASgJEhMKC2V4cGly",
            "ZV90aW1lGAggASgDEhwKCW1haWxfdHlwZRgPIAEoDjIJLk1haWxUeXBlEg8K",
            "B2lzX3JlYWQYASABKAgSCgoCaWQYByABKA0SEwoLdGVtcGxhdGVfaWQYBSAB",
            "KA0SHQoKYXR0YWNobWVudBgMIAEoCzIJLkl0ZW1MaXN0EhEKCXBhcmFfbGlz",
            "dBgJIAMoCRIUCgxtZXNzYWdlX3RleHQYCyABKAkSDQoFdGl0bGUYAiABKAkS",
            "DAoEdGltZRgOIAEoA0IeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3Rv",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.MailTypeReflection.Descriptor, global::EggLink.DanhengServer.Proto.ItemListReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ClientMail), global::EggLink.DanhengServer.Proto.ClientMail.Parser, new[]{ "Sender", "ExpireTime", "MailType", "IsRead", "Id", "TemplateId", "Attachment", "ParaList", "MessageText", "Title", "Time" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ClientMail : pb::IMessage<ClientMail>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ClientMail> _parser = new pb::MessageParser<ClientMail>(() => new ClientMail());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ClientMail> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ClientMailReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClientMail() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClientMail(ClientMail other) : this() {
      sender_ = other.sender_;
      expireTime_ = other.expireTime_;
      mailType_ = other.mailType_;
      isRead_ = other.isRead_;
      id_ = other.id_;
      templateId_ = other.templateId_;
      attachment_ = other.attachment_ != null ? other.attachment_.Clone() : null;
      paraList_ = other.paraList_.Clone();
      messageText_ = other.messageText_;
      title_ = other.title_;
      time_ = other.time_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClientMail Clone() {
      return new ClientMail(this);
    }

    /// <summary>Field number for the "sender" field.</summary>
    public const int SenderFieldNumber = 6;
    private string sender_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Sender {
      get { return sender_; }
      set {
        sender_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "expire_time" field.</summary>
    public const int ExpireTimeFieldNumber = 8;
    private long expireTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long ExpireTime {
      get { return expireTime_; }
      set {
        expireTime_ = value;
      }
    }

    /// <summary>Field number for the "mail_type" field.</summary>
    public const int MailTypeFieldNumber = 15;
    private global::EggLink.DanhengServer.Proto.MailType mailType_ = global::EggLink.DanhengServer.Proto.MailType.Normal;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.MailType MailType {
      get { return mailType_; }
      set {
        mailType_ = value;
      }
    }

    /// <summary>Field number for the "is_read" field.</summary>
    public const int IsReadFieldNumber = 1;
    private bool isRead_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsRead {
      get { return isRead_; }
      set {
        isRead_ = value;
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 7;
    private uint id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "template_id" field.</summary>
    public const int TemplateIdFieldNumber = 5;
    private uint templateId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TemplateId {
      get { return templateId_; }
      set {
        templateId_ = value;
      }
    }

    /// <summary>Field number for the "attachment" field.</summary>
    public const int AttachmentFieldNumber = 12;
    private global::EggLink.DanhengServer.Proto.ItemList attachment_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemList Attachment {
      get { return attachment_; }
      set {
        attachment_ = value;
      }
    }

    /// <summary>Field number for the "para_list" field.</summary>
    public const int ParaListFieldNumber = 9;
    private static readonly pb::FieldCodec<string> _repeated_paraList_codec
        = pb::FieldCodec.ForString(74);
    private readonly pbc::RepeatedField<string> paraList_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> ParaList {
      get { return paraList_; }
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

    /// <summary>Field number for the "title" field.</summary>
    public const int TitleFieldNumber = 2;
    private string title_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Title {
      get { return title_; }
      set {
        title_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "time" field.</summary>
    public const int TimeFieldNumber = 14;
    private long time_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Time {
      get { return time_; }
      set {
        time_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ClientMail);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ClientMail other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Sender != other.Sender) return false;
      if (ExpireTime != other.ExpireTime) return false;
      if (MailType != other.MailType) return false;
      if (IsRead != other.IsRead) return false;
      if (Id != other.Id) return false;
      if (TemplateId != other.TemplateId) return false;
      if (!object.Equals(Attachment, other.Attachment)) return false;
      if(!paraList_.Equals(other.paraList_)) return false;
      if (MessageText != other.MessageText) return false;
      if (Title != other.Title) return false;
      if (Time != other.Time) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Sender.Length != 0) hash ^= Sender.GetHashCode();
      if (ExpireTime != 0L) hash ^= ExpireTime.GetHashCode();
      if (MailType != global::EggLink.DanhengServer.Proto.MailType.Normal) hash ^= MailType.GetHashCode();
      if (IsRead != false) hash ^= IsRead.GetHashCode();
      if (Id != 0) hash ^= Id.GetHashCode();
      if (TemplateId != 0) hash ^= TemplateId.GetHashCode();
      if (attachment_ != null) hash ^= Attachment.GetHashCode();
      hash ^= paraList_.GetHashCode();
      if (MessageText.Length != 0) hash ^= MessageText.GetHashCode();
      if (Title.Length != 0) hash ^= Title.GetHashCode();
      if (Time != 0L) hash ^= Time.GetHashCode();
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
      if (IsRead != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsRead);
      }
      if (Title.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Title);
      }
      if (TemplateId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(TemplateId);
      }
      if (Sender.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Sender);
      }
      if (Id != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Id);
      }
      if (ExpireTime != 0L) {
        output.WriteRawTag(64);
        output.WriteInt64(ExpireTime);
      }
      paraList_.WriteTo(output, _repeated_paraList_codec);
      if (MessageText.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(MessageText);
      }
      if (attachment_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(Attachment);
      }
      if (Time != 0L) {
        output.WriteRawTag(112);
        output.WriteInt64(Time);
      }
      if (MailType != global::EggLink.DanhengServer.Proto.MailType.Normal) {
        output.WriteRawTag(120);
        output.WriteEnum((int) MailType);
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
      if (IsRead != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsRead);
      }
      if (Title.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Title);
      }
      if (TemplateId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(TemplateId);
      }
      if (Sender.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Sender);
      }
      if (Id != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Id);
      }
      if (ExpireTime != 0L) {
        output.WriteRawTag(64);
        output.WriteInt64(ExpireTime);
      }
      paraList_.WriteTo(ref output, _repeated_paraList_codec);
      if (MessageText.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(MessageText);
      }
      if (attachment_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(Attachment);
      }
      if (Time != 0L) {
        output.WriteRawTag(112);
        output.WriteInt64(Time);
      }
      if (MailType != global::EggLink.DanhengServer.Proto.MailType.Normal) {
        output.WriteRawTag(120);
        output.WriteEnum((int) MailType);
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
      if (Sender.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Sender);
      }
      if (ExpireTime != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ExpireTime);
      }
      if (MailType != global::EggLink.DanhengServer.Proto.MailType.Normal) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) MailType);
      }
      if (IsRead != false) {
        size += 1 + 1;
      }
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Id);
      }
      if (TemplateId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TemplateId);
      }
      if (attachment_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Attachment);
      }
      size += paraList_.CalculateSize(_repeated_paraList_codec);
      if (MessageText.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MessageText);
      }
      if (Title.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Title);
      }
      if (Time != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Time);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ClientMail other) {
      if (other == null) {
        return;
      }
      if (other.Sender.Length != 0) {
        Sender = other.Sender;
      }
      if (other.ExpireTime != 0L) {
        ExpireTime = other.ExpireTime;
      }
      if (other.MailType != global::EggLink.DanhengServer.Proto.MailType.Normal) {
        MailType = other.MailType;
      }
      if (other.IsRead != false) {
        IsRead = other.IsRead;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.TemplateId != 0) {
        TemplateId = other.TemplateId;
      }
      if (other.attachment_ != null) {
        if (attachment_ == null) {
          Attachment = new global::EggLink.DanhengServer.Proto.ItemList();
        }
        Attachment.MergeFrom(other.Attachment);
      }
      paraList_.Add(other.paraList_);
      if (other.MessageText.Length != 0) {
        MessageText = other.MessageText;
      }
      if (other.Title.Length != 0) {
        Title = other.Title;
      }
      if (other.Time != 0L) {
        Time = other.Time;
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
            IsRead = input.ReadBool();
            break;
          }
          case 18: {
            Title = input.ReadString();
            break;
          }
          case 40: {
            TemplateId = input.ReadUInt32();
            break;
          }
          case 50: {
            Sender = input.ReadString();
            break;
          }
          case 56: {
            Id = input.ReadUInt32();
            break;
          }
          case 64: {
            ExpireTime = input.ReadInt64();
            break;
          }
          case 74: {
            paraList_.AddEntriesFrom(input, _repeated_paraList_codec);
            break;
          }
          case 90: {
            MessageText = input.ReadString();
            break;
          }
          case 98: {
            if (attachment_ == null) {
              Attachment = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(Attachment);
            break;
          }
          case 112: {
            Time = input.ReadInt64();
            break;
          }
          case 120: {
            MailType = (global::EggLink.DanhengServer.Proto.MailType) input.ReadEnum();
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
            IsRead = input.ReadBool();
            break;
          }
          case 18: {
            Title = input.ReadString();
            break;
          }
          case 40: {
            TemplateId = input.ReadUInt32();
            break;
          }
          case 50: {
            Sender = input.ReadString();
            break;
          }
          case 56: {
            Id = input.ReadUInt32();
            break;
          }
          case 64: {
            ExpireTime = input.ReadInt64();
            break;
          }
          case 74: {
            paraList_.AddEntriesFrom(ref input, _repeated_paraList_codec);
            break;
          }
          case 90: {
            MessageText = input.ReadString();
            break;
          }
          case 98: {
            if (attachment_ == null) {
              Attachment = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(Attachment);
            break;
          }
          case 112: {
            Time = input.ReadInt64();
            break;
          }
          case 120: {
            MailType = (global::EggLink.DanhengServer.Proto.MailType) input.ReadEnum();
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