// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueWorkbenchSelectFuncScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueWorkbenchSelectFuncScRsp.proto</summary>
  public static partial class RogueWorkbenchSelectFuncScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueWorkbenchSelectFuncScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueWorkbenchSelectFuncScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNSb2d1ZVdvcmtiZW5jaFNlbGVjdEZ1bmNTY1JzcC5wcm90bxoXV29ya2Jl",
            "bmNoRnVuY0luZm8ucHJvdG8ibwodUm9ndWVXb3JrYmVuY2hTZWxlY3RGdW5j",
            "U2NSc3ASDwoHcmV0Y29kZRgJIAEoDRIPCgdmdW5jX2lkGAcgASgNEiwKEHRh",
            "cmdldF9mdW5jX2luZm8YASABKAsyEi5Xb3JrYmVuY2hGdW5jSW5mb0IeqgIb",
            "RWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.WorkbenchFuncInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueWorkbenchSelectFuncScRsp), global::EggLink.DanhengServer.Proto.RogueWorkbenchSelectFuncScRsp.Parser, new[]{ "Retcode", "FuncId", "TargetFuncInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueWorkbenchSelectFuncScRsp : pb::IMessage<RogueWorkbenchSelectFuncScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueWorkbenchSelectFuncScRsp> _parser = new pb::MessageParser<RogueWorkbenchSelectFuncScRsp>(() => new RogueWorkbenchSelectFuncScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueWorkbenchSelectFuncScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueWorkbenchSelectFuncScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueWorkbenchSelectFuncScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueWorkbenchSelectFuncScRsp(RogueWorkbenchSelectFuncScRsp other) : this() {
      retcode_ = other.retcode_;
      funcId_ = other.funcId_;
      targetFuncInfo_ = other.targetFuncInfo_ != null ? other.targetFuncInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueWorkbenchSelectFuncScRsp Clone() {
      return new RogueWorkbenchSelectFuncScRsp(this);
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

    /// <summary>Field number for the "target_func_info" field.</summary>
    public const int TargetFuncInfoFieldNumber = 1;
    private global::EggLink.DanhengServer.Proto.WorkbenchFuncInfo targetFuncInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.WorkbenchFuncInfo TargetFuncInfo {
      get { return targetFuncInfo_; }
      set {
        targetFuncInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueWorkbenchSelectFuncScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueWorkbenchSelectFuncScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (FuncId != other.FuncId) return false;
      if (!object.Equals(TargetFuncInfo, other.TargetFuncInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (FuncId != 0) hash ^= FuncId.GetHashCode();
      if (targetFuncInfo_ != null) hash ^= TargetFuncInfo.GetHashCode();
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
      if (targetFuncInfo_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(TargetFuncInfo);
      }
      if (FuncId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(FuncId);
      }
      if (Retcode != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Retcode);
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
      if (targetFuncInfo_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(TargetFuncInfo);
      }
      if (FuncId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(FuncId);
      }
      if (Retcode != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Retcode);
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
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (FuncId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FuncId);
      }
      if (targetFuncInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TargetFuncInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueWorkbenchSelectFuncScRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.FuncId != 0) {
        FuncId = other.FuncId;
      }
      if (other.targetFuncInfo_ != null) {
        if (targetFuncInfo_ == null) {
          TargetFuncInfo = new global::EggLink.DanhengServer.Proto.WorkbenchFuncInfo();
        }
        TargetFuncInfo.MergeFrom(other.TargetFuncInfo);
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
          case 10: {
            if (targetFuncInfo_ == null) {
              TargetFuncInfo = new global::EggLink.DanhengServer.Proto.WorkbenchFuncInfo();
            }
            input.ReadMessage(TargetFuncInfo);
            break;
          }
          case 56: {
            FuncId = input.ReadUInt32();
            break;
          }
          case 72: {
            Retcode = input.ReadUInt32();
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
          case 10: {
            if (targetFuncInfo_ == null) {
              TargetFuncInfo = new global::EggLink.DanhengServer.Proto.WorkbenchFuncInfo();
            }
            input.ReadMessage(TargetFuncInfo);
            break;
          }
          case 56: {
            FuncId = input.ReadUInt32();
            break;
          }
          case 72: {
            Retcode = input.ReadUInt32();
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
