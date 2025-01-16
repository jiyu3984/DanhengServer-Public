// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MainMissionCustomValue.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from MainMissionCustomValue.proto</summary>
  public static partial class MainMissionCustomValueReflection {

    #region Descriptor
    /// <summary>File descriptor for MainMissionCustomValue.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MainMissionCustomValueReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxNYWluTWlzc2lvbkN1c3RvbVZhbHVlLnByb3RvGhxNaXNzaW9uQ3VzdG9t",
            "VmFsdWVMaXN0LnByb3RvImUKFk1haW5NaXNzaW9uQ3VzdG9tVmFsdWUSFwoP",
            "bWFpbl9taXNzaW9uX2lkGAQgASgNEjIKEWN1c3RvbV92YWx1ZV9saXN0GAcg",
            "ASgLMhcuTWlzc2lvbkN1c3RvbVZhbHVlTGlzdEIeqgIbRWdnTGluay5EYW5o",
            "ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.MissionCustomValueListReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.MainMissionCustomValue), global::EggLink.DanhengServer.Proto.MainMissionCustomValue.Parser, new[]{ "MainMissionId", "CustomValueList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class MainMissionCustomValue : pb::IMessage<MainMissionCustomValue>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MainMissionCustomValue> _parser = new pb::MessageParser<MainMissionCustomValue>(() => new MainMissionCustomValue());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MainMissionCustomValue> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.MainMissionCustomValueReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MainMissionCustomValue() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MainMissionCustomValue(MainMissionCustomValue other) : this() {
      mainMissionId_ = other.mainMissionId_;
      customValueList_ = other.customValueList_ != null ? other.customValueList_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MainMissionCustomValue Clone() {
      return new MainMissionCustomValue(this);
    }

    /// <summary>Field number for the "main_mission_id" field.</summary>
    public const int MainMissionIdFieldNumber = 4;
    private uint mainMissionId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MainMissionId {
      get { return mainMissionId_; }
      set {
        mainMissionId_ = value;
      }
    }

    /// <summary>Field number for the "custom_value_list" field.</summary>
    public const int CustomValueListFieldNumber = 7;
    private global::EggLink.DanhengServer.Proto.MissionCustomValueList customValueList_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.MissionCustomValueList CustomValueList {
      get { return customValueList_; }
      set {
        customValueList_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MainMissionCustomValue);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MainMissionCustomValue other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MainMissionId != other.MainMissionId) return false;
      if (!object.Equals(CustomValueList, other.CustomValueList)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (MainMissionId != 0) hash ^= MainMissionId.GetHashCode();
      if (customValueList_ != null) hash ^= CustomValueList.GetHashCode();
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
      if (MainMissionId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(MainMissionId);
      }
      if (customValueList_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(CustomValueList);
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
      if (MainMissionId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(MainMissionId);
      }
      if (customValueList_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(CustomValueList);
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
      if (MainMissionId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MainMissionId);
      }
      if (customValueList_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CustomValueList);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MainMissionCustomValue other) {
      if (other == null) {
        return;
      }
      if (other.MainMissionId != 0) {
        MainMissionId = other.MainMissionId;
      }
      if (other.customValueList_ != null) {
        if (customValueList_ == null) {
          CustomValueList = new global::EggLink.DanhengServer.Proto.MissionCustomValueList();
        }
        CustomValueList.MergeFrom(other.CustomValueList);
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
          case 32: {
            MainMissionId = input.ReadUInt32();
            break;
          }
          case 58: {
            if (customValueList_ == null) {
              CustomValueList = new global::EggLink.DanhengServer.Proto.MissionCustomValueList();
            }
            input.ReadMessage(CustomValueList);
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
          case 32: {
            MainMissionId = input.ReadUInt32();
            break;
          }
          case 58: {
            if (customValueList_ == null) {
              CustomValueList = new global::EggLink.DanhengServer.Proto.MissionCustomValueList();
            }
            input.ReadMessage(CustomValueList);
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