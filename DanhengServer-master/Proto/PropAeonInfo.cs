// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PropAeonInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from PropAeonInfo.proto</summary>
  public static partial class PropAeonInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for PropAeonInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PropAeonInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJQcm9wQWVvbkluZm8ucHJvdG8iSwoMUHJvcEFlb25JbmZvEg8KB2FkZF9l",
            "eHAYASABKA0SDwoHYWVvbl9pZBgCIAEoDRIZChFkaWFsb2d1ZV9ncm91cF9p",
            "ZBgLIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.PropAeonInfo), global::EggLink.DanhengServer.Proto.PropAeonInfo.Parser, new[]{ "AddExp", "AeonId", "DialogueGroupId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class PropAeonInfo : pb::IMessage<PropAeonInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PropAeonInfo> _parser = new pb::MessageParser<PropAeonInfo>(() => new PropAeonInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PropAeonInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.PropAeonInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PropAeonInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PropAeonInfo(PropAeonInfo other) : this() {
      addExp_ = other.addExp_;
      aeonId_ = other.aeonId_;
      dialogueGroupId_ = other.dialogueGroupId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PropAeonInfo Clone() {
      return new PropAeonInfo(this);
    }

    /// <summary>Field number for the "add_exp" field.</summary>
    public const int AddExpFieldNumber = 1;
    private uint addExp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AddExp {
      get { return addExp_; }
      set {
        addExp_ = value;
      }
    }

    /// <summary>Field number for the "aeon_id" field.</summary>
    public const int AeonIdFieldNumber = 2;
    private uint aeonId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AeonId {
      get { return aeonId_; }
      set {
        aeonId_ = value;
      }
    }

    /// <summary>Field number for the "dialogue_group_id" field.</summary>
    public const int DialogueGroupIdFieldNumber = 11;
    private uint dialogueGroupId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DialogueGroupId {
      get { return dialogueGroupId_; }
      set {
        dialogueGroupId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PropAeonInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PropAeonInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AddExp != other.AddExp) return false;
      if (AeonId != other.AeonId) return false;
      if (DialogueGroupId != other.DialogueGroupId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (AddExp != 0) hash ^= AddExp.GetHashCode();
      if (AeonId != 0) hash ^= AeonId.GetHashCode();
      if (DialogueGroupId != 0) hash ^= DialogueGroupId.GetHashCode();
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
      if (AddExp != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(AddExp);
      }
      if (AeonId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(AeonId);
      }
      if (DialogueGroupId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(DialogueGroupId);
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
      if (AddExp != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(AddExp);
      }
      if (AeonId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(AeonId);
      }
      if (DialogueGroupId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(DialogueGroupId);
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
      if (AddExp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AddExp);
      }
      if (AeonId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AeonId);
      }
      if (DialogueGroupId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DialogueGroupId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PropAeonInfo other) {
      if (other == null) {
        return;
      }
      if (other.AddExp != 0) {
        AddExp = other.AddExp;
      }
      if (other.AeonId != 0) {
        AeonId = other.AeonId;
      }
      if (other.DialogueGroupId != 0) {
        DialogueGroupId = other.DialogueGroupId;
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
            AddExp = input.ReadUInt32();
            break;
          }
          case 16: {
            AeonId = input.ReadUInt32();
            break;
          }
          case 88: {
            DialogueGroupId = input.ReadUInt32();
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
            AddExp = input.ReadUInt32();
            break;
          }
          case 16: {
            AeonId = input.ReadUInt32();
            break;
          }
          case 88: {
            DialogueGroupId = input.ReadUInt32();
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
