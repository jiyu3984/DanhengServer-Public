// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueWorkbenchSelectFuncCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueWorkbenchSelectFuncCsReq.proto</summary>
  public static partial class RogueWorkbenchSelectFuncCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueWorkbenchSelectFuncCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueWorkbenchSelectFuncCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNSb2d1ZVdvcmtiZW5jaFNlbGVjdEZ1bmNDc1JlcS5wcm90byJICh1Sb2d1",
            "ZVdvcmtiZW5jaFNlbGVjdEZ1bmNDc1JlcRIWCg5wcm9wX2VudGl0eV9pZBgL",
            "IAEoDRIPCgdmdW5jX2lkGAcgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2",
            "ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueWorkbenchSelectFuncCsReq), global::EggLink.DanhengServer.Proto.RogueWorkbenchSelectFuncCsReq.Parser, new[]{ "PropEntityId", "FuncId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueWorkbenchSelectFuncCsReq : pb::IMessage<RogueWorkbenchSelectFuncCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueWorkbenchSelectFuncCsReq> _parser = new pb::MessageParser<RogueWorkbenchSelectFuncCsReq>(() => new RogueWorkbenchSelectFuncCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueWorkbenchSelectFuncCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueWorkbenchSelectFuncCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueWorkbenchSelectFuncCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueWorkbenchSelectFuncCsReq(RogueWorkbenchSelectFuncCsReq other) : this() {
      propEntityId_ = other.propEntityId_;
      funcId_ = other.funcId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueWorkbenchSelectFuncCsReq Clone() {
      return new RogueWorkbenchSelectFuncCsReq(this);
    }

    /// <summary>Field number for the "prop_entity_id" field.</summary>
    public const int PropEntityIdFieldNumber = 11;
    private uint propEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PropEntityId {
      get { return propEntityId_; }
      set {
        propEntityId_ = value;
      }
    }

    /// <summary>Field number for the "func_id" field.</summary>
    public const int FuncIdFieldNumber = 7;
    private uint funcId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FuncId {
      get { return funcId_; }
      set {
        funcId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueWorkbenchSelectFuncCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueWorkbenchSelectFuncCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PropEntityId != other.PropEntityId) return false;
      if (FuncId != other.FuncId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (PropEntityId != 0) hash ^= PropEntityId.GetHashCode();
      if (FuncId != 0) hash ^= FuncId.GetHashCode();
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
      if (FuncId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(FuncId);
      }
      if (PropEntityId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(PropEntityId);
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
      if (FuncId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(FuncId);
      }
      if (PropEntityId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(PropEntityId);
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
      if (PropEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PropEntityId);
      }
      if (FuncId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FuncId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueWorkbenchSelectFuncCsReq other) {
      if (other == null) {
        return;
      }
      if (other.PropEntityId != 0) {
        PropEntityId = other.PropEntityId;
      }
      if (other.FuncId != 0) {
        FuncId = other.FuncId;
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
          case 56: {
            FuncId = input.ReadUInt32();
            break;
          }
          case 88: {
            PropEntityId = input.ReadUInt32();
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
          case 56: {
            FuncId = input.ReadUInt32();
            break;
          }
          case 88: {
            PropEntityId = input.ReadUInt32();
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