// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueCommonBuffReforgeSelectInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueCommonBuffReforgeSelectInfo.proto</summary>
  public static partial class RogueCommonBuffReforgeSelectInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueCommonBuffReforgeSelectInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueCommonBuffReforgeSelectInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZSb2d1ZUNvbW1vbkJ1ZmZSZWZvcmdlU2VsZWN0SW5mby5wcm90bxoVUm9n",
            "dWVDb21tb25CdWZmLnByb3RvImIKIFJvZ3VlQ29tbW9uQnVmZlJlZm9yZ2VT",
            "ZWxlY3RJbmZvEiYKDHNlbGVjdF9idWZmcxgNIAMoCzIQLlJvZ3VlQ29tbW9u",
            "QnVmZhIWCg5zZWxlY3RfaGludF9pZBgMIAEoDUIeqgIbRWdnTGluay5EYW5o",
            "ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueCommonBuffReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueCommonBuffReforgeSelectInfo), global::EggLink.DanhengServer.Proto.RogueCommonBuffReforgeSelectInfo.Parser, new[]{ "SelectBuffs", "SelectHintId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueCommonBuffReforgeSelectInfo : pb::IMessage<RogueCommonBuffReforgeSelectInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueCommonBuffReforgeSelectInfo> _parser = new pb::MessageParser<RogueCommonBuffReforgeSelectInfo>(() => new RogueCommonBuffReforgeSelectInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueCommonBuffReforgeSelectInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueCommonBuffReforgeSelectInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueCommonBuffReforgeSelectInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueCommonBuffReforgeSelectInfo(RogueCommonBuffReforgeSelectInfo other) : this() {
      selectBuffs_ = other.selectBuffs_.Clone();
      selectHintId_ = other.selectHintId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueCommonBuffReforgeSelectInfo Clone() {
      return new RogueCommonBuffReforgeSelectInfo(this);
    }

    /// <summary>Field number for the "select_buffs" field.</summary>
    public const int SelectBuffsFieldNumber = 13;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.RogueCommonBuff> _repeated_selectBuffs_codec
        = pb::FieldCodec.ForMessage(106, global::EggLink.DanhengServer.Proto.RogueCommonBuff.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueCommonBuff> selectBuffs_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueCommonBuff>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueCommonBuff> SelectBuffs {
      get { return selectBuffs_; }
    }

    /// <summary>Field number for the "select_hint_id" field.</summary>
    public const int SelectHintIdFieldNumber = 12;
    private uint selectHintId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SelectHintId {
      get { return selectHintId_; }
      set {
        selectHintId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueCommonBuffReforgeSelectInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueCommonBuffReforgeSelectInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!selectBuffs_.Equals(other.selectBuffs_)) return false;
      if (SelectHintId != other.SelectHintId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= selectBuffs_.GetHashCode();
      if (SelectHintId != 0) hash ^= SelectHintId.GetHashCode();
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
      if (SelectHintId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(SelectHintId);
      }
      selectBuffs_.WriteTo(output, _repeated_selectBuffs_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (SelectHintId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(SelectHintId);
      }
      selectBuffs_.WriteTo(ref output, _repeated_selectBuffs_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += selectBuffs_.CalculateSize(_repeated_selectBuffs_codec);
      if (SelectHintId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SelectHintId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueCommonBuffReforgeSelectInfo other) {
      if (other == null) {
        return;
      }
      selectBuffs_.Add(other.selectBuffs_);
      if (other.SelectHintId != 0) {
        SelectHintId = other.SelectHintId;
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
          case 96: {
            SelectHintId = input.ReadUInt32();
            break;
          }
          case 106: {
            selectBuffs_.AddEntriesFrom(input, _repeated_selectBuffs_codec);
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
          case 96: {
            SelectHintId = input.ReadUInt32();
            break;
          }
          case 106: {
            selectBuffs_.AddEntriesFrom(ref input, _repeated_selectBuffs_codec);
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
