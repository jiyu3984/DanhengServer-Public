// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SelectRogueCommonDialogueOptionScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SelectRogueCommonDialogueOptionScRsp.proto</summary>
  public static partial class SelectRogueCommonDialogueOptionScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for SelectRogueCommonDialogueOptionScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SelectRogueCommonDialogueOptionScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CipTZWxlY3RSb2d1ZUNvbW1vbkRpYWxvZ3VlT3B0aW9uU2NSc3AucHJvdG8a",
            "IVJvZ3VlQ29tbW9uRGlhbG9ndWVEYXRhSW5mby5wcm90byLQAQokU2VsZWN0",
            "Um9ndWVDb21tb25EaWFsb2d1ZU9wdGlvblNjUnNwEhEKCW9wdGlvbl9pZBgP",
            "IAEoDRIPCgdyZXRjb2RlGAQgASgNEhwKFGVmZmVjdF9ldmVudF9pZF9saXN0",
            "GAEgAygNEjMKDWRpYWxvZ3VlX2RhdGEYBiABKAsyHC5Sb2d1ZUNvbW1vbkRp",
            "YWxvZ3VlRGF0YUluZm8SGAoQZXZlbnRfaGFzX2VmZmVjdBgFIAEoCBIXCg9l",
            "dmVudF91bmlxdWVfaWQYAyABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZl",
            "ci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueCommonDialogueDataInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SelectRogueCommonDialogueOptionScRsp), global::EggLink.DanhengServer.Proto.SelectRogueCommonDialogueOptionScRsp.Parser, new[]{ "OptionId", "Retcode", "EffectEventIdList", "DialogueData", "EventHasEffect", "EventUniqueId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SelectRogueCommonDialogueOptionScRsp : pb::IMessage<SelectRogueCommonDialogueOptionScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SelectRogueCommonDialogueOptionScRsp> _parser = new pb::MessageParser<SelectRogueCommonDialogueOptionScRsp>(() => new SelectRogueCommonDialogueOptionScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SelectRogueCommonDialogueOptionScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.SelectRogueCommonDialogueOptionScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SelectRogueCommonDialogueOptionScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SelectRogueCommonDialogueOptionScRsp(SelectRogueCommonDialogueOptionScRsp other) : this() {
      optionId_ = other.optionId_;
      retcode_ = other.retcode_;
      effectEventIdList_ = other.effectEventIdList_.Clone();
      dialogueData_ = other.dialogueData_ != null ? other.dialogueData_.Clone() : null;
      eventHasEffect_ = other.eventHasEffect_;
      eventUniqueId_ = other.eventUniqueId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SelectRogueCommonDialogueOptionScRsp Clone() {
      return new SelectRogueCommonDialogueOptionScRsp(this);
    }

    /// <summary>Field number for the "option_id" field.</summary>
    public const int OptionIdFieldNumber = 15;
    private uint optionId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OptionId {
      get { return optionId_; }
      set {
        optionId_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 4;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "effect_event_id_list" field.</summary>
    public const int EffectEventIdListFieldNumber = 1;
    private static readonly pb::FieldCodec<uint> _repeated_effectEventIdList_codec
        = pb::FieldCodec.ForUInt32(10);
    private readonly pbc::RepeatedField<uint> effectEventIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> EffectEventIdList {
      get { return effectEventIdList_; }
    }

    /// <summary>Field number for the "dialogue_data" field.</summary>
    public const int DialogueDataFieldNumber = 6;
    private global::EggLink.DanhengServer.Proto.RogueCommonDialogueDataInfo dialogueData_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueCommonDialogueDataInfo DialogueData {
      get { return dialogueData_; }
      set {
        dialogueData_ = value;
      }
    }

    /// <summary>Field number for the "event_has_effect" field.</summary>
    public const int EventHasEffectFieldNumber = 5;
    private bool eventHasEffect_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool EventHasEffect {
      get { return eventHasEffect_; }
      set {
        eventHasEffect_ = value;
      }
    }

    /// <summary>Field number for the "event_unique_id" field.</summary>
    public const int EventUniqueIdFieldNumber = 3;
    private uint eventUniqueId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EventUniqueId {
      get { return eventUniqueId_; }
      set {
        eventUniqueId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SelectRogueCommonDialogueOptionScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SelectRogueCommonDialogueOptionScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (OptionId != other.OptionId) return false;
      if (Retcode != other.Retcode) return false;
      if(!effectEventIdList_.Equals(other.effectEventIdList_)) return false;
      if (!object.Equals(DialogueData, other.DialogueData)) return false;
      if (EventHasEffect != other.EventHasEffect) return false;
      if (EventUniqueId != other.EventUniqueId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (OptionId != 0) hash ^= OptionId.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      hash ^= effectEventIdList_.GetHashCode();
      if (dialogueData_ != null) hash ^= DialogueData.GetHashCode();
      if (EventHasEffect != false) hash ^= EventHasEffect.GetHashCode();
      if (EventUniqueId != 0) hash ^= EventUniqueId.GetHashCode();
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
      effectEventIdList_.WriteTo(output, _repeated_effectEventIdList_codec);
      if (EventUniqueId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(EventUniqueId);
      }
      if (Retcode != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Retcode);
      }
      if (EventHasEffect != false) {
        output.WriteRawTag(40);
        output.WriteBool(EventHasEffect);
      }
      if (dialogueData_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(DialogueData);
      }
      if (OptionId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(OptionId);
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
      effectEventIdList_.WriteTo(ref output, _repeated_effectEventIdList_codec);
      if (EventUniqueId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(EventUniqueId);
      }
      if (Retcode != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Retcode);
      }
      if (EventHasEffect != false) {
        output.WriteRawTag(40);
        output.WriteBool(EventHasEffect);
      }
      if (dialogueData_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(DialogueData);
      }
      if (OptionId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(OptionId);
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
      if (OptionId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OptionId);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      size += effectEventIdList_.CalculateSize(_repeated_effectEventIdList_codec);
      if (dialogueData_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DialogueData);
      }
      if (EventHasEffect != false) {
        size += 1 + 1;
      }
      if (EventUniqueId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EventUniqueId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SelectRogueCommonDialogueOptionScRsp other) {
      if (other == null) {
        return;
      }
      if (other.OptionId != 0) {
        OptionId = other.OptionId;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      effectEventIdList_.Add(other.effectEventIdList_);
      if (other.dialogueData_ != null) {
        if (dialogueData_ == null) {
          DialogueData = new global::EggLink.DanhengServer.Proto.RogueCommonDialogueDataInfo();
        }
        DialogueData.MergeFrom(other.DialogueData);
      }
      if (other.EventHasEffect != false) {
        EventHasEffect = other.EventHasEffect;
      }
      if (other.EventUniqueId != 0) {
        EventUniqueId = other.EventUniqueId;
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
          case 10:
          case 8: {
            effectEventIdList_.AddEntriesFrom(input, _repeated_effectEventIdList_codec);
            break;
          }
          case 24: {
            EventUniqueId = input.ReadUInt32();
            break;
          }
          case 32: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 40: {
            EventHasEffect = input.ReadBool();
            break;
          }
          case 50: {
            if (dialogueData_ == null) {
              DialogueData = new global::EggLink.DanhengServer.Proto.RogueCommonDialogueDataInfo();
            }
            input.ReadMessage(DialogueData);
            break;
          }
          case 120: {
            OptionId = input.ReadUInt32();
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
          case 10:
          case 8: {
            effectEventIdList_.AddEntriesFrom(ref input, _repeated_effectEventIdList_codec);
            break;
          }
          case 24: {
            EventUniqueId = input.ReadUInt32();
            break;
          }
          case 32: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 40: {
            EventHasEffect = input.ReadBool();
            break;
          }
          case 50: {
            if (dialogueData_ == null) {
              DialogueData = new global::EggLink.DanhengServer.Proto.RogueCommonDialogueDataInfo();
            }
            input.ReadMessage(DialogueData);
            break;
          }
          case 120: {
            OptionId = input.ReadUInt32();
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
