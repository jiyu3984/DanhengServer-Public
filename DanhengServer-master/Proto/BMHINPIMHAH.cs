// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BMHINPIMHAH.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from BMHINPIMHAH.proto</summary>
  public static partial class BMHINPIMHAHReflection {

    #region Descriptor
    /// <summary>File descriptor for BMHINPIMHAH.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BMHINPIMHAHReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFCTUhJTlBJTUhBSC5wcm90bxocTWlzc2lvbkN1c3RvbVZhbHVlTGlzdC5w",
            "cm90byJfCgtCTUhJTlBJTUhBSBIKCgJpZBgIIAEoDRI1ChFjdXN0b21fdmFs",
            "dWVfbGlzdBjCBCABKAsyFy5NaXNzaW9uQ3VzdG9tVmFsdWVMaXN0SABCDQoL",
            "SU5PR0hES0NMR0dCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.MissionCustomValueListReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.BMHINPIMHAH), global::EggLink.DanhengServer.Proto.BMHINPIMHAH.Parser, new[]{ "Id", "CustomValueList" }, new[]{ "INOGHDKCLGG" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class BMHINPIMHAH : pb::IMessage<BMHINPIMHAH>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BMHINPIMHAH> _parser = new pb::MessageParser<BMHINPIMHAH>(() => new BMHINPIMHAH());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BMHINPIMHAH> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.BMHINPIMHAHReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BMHINPIMHAH() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BMHINPIMHAH(BMHINPIMHAH other) : this() {
      id_ = other.id_;
      switch (other.INOGHDKCLGGCase) {
        case INOGHDKCLGGOneofCase.CustomValueList:
          CustomValueList = other.CustomValueList.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BMHINPIMHAH Clone() {
      return new BMHINPIMHAH(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 8;
    private uint id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "custom_value_list" field.</summary>
    public const int CustomValueListFieldNumber = 578;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.MissionCustomValueList CustomValueList {
      get { return iNOGHDKCLGGCase_ == INOGHDKCLGGOneofCase.CustomValueList ? (global::EggLink.DanhengServer.Proto.MissionCustomValueList) iNOGHDKCLGG_ : null; }
      set {
        iNOGHDKCLGG_ = value;
        iNOGHDKCLGGCase_ = value == null ? INOGHDKCLGGOneofCase.None : INOGHDKCLGGOneofCase.CustomValueList;
      }
    }

    private object iNOGHDKCLGG_;
    /// <summary>Enum of possible cases for the "INOGHDKCLGG" oneof.</summary>
    public enum INOGHDKCLGGOneofCase {
      None = 0,
      CustomValueList = 578,
    }
    private INOGHDKCLGGOneofCase iNOGHDKCLGGCase_ = INOGHDKCLGGOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public INOGHDKCLGGOneofCase INOGHDKCLGGCase {
      get { return iNOGHDKCLGGCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearINOGHDKCLGG() {
      iNOGHDKCLGGCase_ = INOGHDKCLGGOneofCase.None;
      iNOGHDKCLGG_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BMHINPIMHAH);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BMHINPIMHAH other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (!object.Equals(CustomValueList, other.CustomValueList)) return false;
      if (INOGHDKCLGGCase != other.INOGHDKCLGGCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (iNOGHDKCLGGCase_ == INOGHDKCLGGOneofCase.CustomValueList) hash ^= CustomValueList.GetHashCode();
      hash ^= (int) iNOGHDKCLGGCase_;
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
      if (Id != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Id);
      }
      if (iNOGHDKCLGGCase_ == INOGHDKCLGGOneofCase.CustomValueList) {
        output.WriteRawTag(146, 36);
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
      if (Id != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Id);
      }
      if (iNOGHDKCLGGCase_ == INOGHDKCLGGOneofCase.CustomValueList) {
        output.WriteRawTag(146, 36);
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
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Id);
      }
      if (iNOGHDKCLGGCase_ == INOGHDKCLGGOneofCase.CustomValueList) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(CustomValueList);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BMHINPIMHAH other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      switch (other.INOGHDKCLGGCase) {
        case INOGHDKCLGGOneofCase.CustomValueList:
          if (CustomValueList == null) {
            CustomValueList = new global::EggLink.DanhengServer.Proto.MissionCustomValueList();
          }
          CustomValueList.MergeFrom(other.CustomValueList);
          break;
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
          case 64: {
            Id = input.ReadUInt32();
            break;
          }
          case 4626: {
            global::EggLink.DanhengServer.Proto.MissionCustomValueList subBuilder = new global::EggLink.DanhengServer.Proto.MissionCustomValueList();
            if (iNOGHDKCLGGCase_ == INOGHDKCLGGOneofCase.CustomValueList) {
              subBuilder.MergeFrom(CustomValueList);
            }
            input.ReadMessage(subBuilder);
            CustomValueList = subBuilder;
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
          case 64: {
            Id = input.ReadUInt32();
            break;
          }
          case 4626: {
            global::EggLink.DanhengServer.Proto.MissionCustomValueList subBuilder = new global::EggLink.DanhengServer.Proto.MissionCustomValueList();
            if (iNOGHDKCLGGCase_ == INOGHDKCLGGOneofCase.CustomValueList) {
              subBuilder.MergeFrom(CustomValueList);
            }
            input.ReadMessage(subBuilder);
            CustomValueList = subBuilder;
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
