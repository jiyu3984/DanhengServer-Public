// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WorkbenchReforgeFormulaFuncInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from WorkbenchReforgeFormulaFuncInfo.proto</summary>
  public static partial class WorkbenchReforgeFormulaFuncInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for WorkbenchReforgeFormulaFuncInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WorkbenchReforgeFormulaFuncInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVXb3JrYmVuY2hSZWZvcmdlRm9ybXVsYUZ1bmNJbmZvLnByb3RvGhJJdGVt",
            "Q29zdERhdGEucHJvdG8itgEKH1dvcmtiZW5jaFJlZm9yZ2VGb3JtdWxhRnVu",
            "Y0luZm8SHQoVaW50X3JlZm9yZ2VfbnVtX3ZhbHVlGAwgASgFEhgKEGNhbl9m",
            "cmVlX3JlZm9yZ2UYAyABKAgSGAoQZnJlZV9yZWZvcmdlX251bRgEIAEoDRIg",
            "Cgljb3N0X2RhdGEYAiABKAsyDS5JdGVtQ29zdERhdGESHgoWdWludF9yZWZv",
            "cmdlX251bV92YWx1ZRgHIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVy",
            "LlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ItemCostDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.WorkbenchReforgeFormulaFuncInfo), global::EggLink.DanhengServer.Proto.WorkbenchReforgeFormulaFuncInfo.Parser, new[]{ "IntReforgeNumValue", "CanFreeReforge", "FreeReforgeNum", "CostData", "UintReforgeNumValue" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class WorkbenchReforgeFormulaFuncInfo : pb::IMessage<WorkbenchReforgeFormulaFuncInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<WorkbenchReforgeFormulaFuncInfo> _parser = new pb::MessageParser<WorkbenchReforgeFormulaFuncInfo>(() => new WorkbenchReforgeFormulaFuncInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<WorkbenchReforgeFormulaFuncInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.WorkbenchReforgeFormulaFuncInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WorkbenchReforgeFormulaFuncInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WorkbenchReforgeFormulaFuncInfo(WorkbenchReforgeFormulaFuncInfo other) : this() {
      intReforgeNumValue_ = other.intReforgeNumValue_;
      canFreeReforge_ = other.canFreeReforge_;
      freeReforgeNum_ = other.freeReforgeNum_;
      costData_ = other.costData_ != null ? other.costData_.Clone() : null;
      uintReforgeNumValue_ = other.uintReforgeNumValue_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WorkbenchReforgeFormulaFuncInfo Clone() {
      return new WorkbenchReforgeFormulaFuncInfo(this);
    }

    /// <summary>Field number for the "int_reforge_num_value" field.</summary>
    public const int IntReforgeNumValueFieldNumber = 12;
    private int intReforgeNumValue_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int IntReforgeNumValue {
      get { return intReforgeNumValue_; }
      set {
        intReforgeNumValue_ = value;
      }
    }

    /// <summary>Field number for the "can_free_reforge" field.</summary>
    public const int CanFreeReforgeFieldNumber = 3;
    private bool canFreeReforge_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool CanFreeReforge {
      get { return canFreeReforge_; }
      set {
        canFreeReforge_ = value;
      }
    }

    /// <summary>Field number for the "free_reforge_num" field.</summary>
    public const int FreeReforgeNumFieldNumber = 4;
    private uint freeReforgeNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FreeReforgeNum {
      get { return freeReforgeNum_; }
      set {
        freeReforgeNum_ = value;
      }
    }

    /// <summary>Field number for the "cost_data" field.</summary>
    public const int CostDataFieldNumber = 2;
    private global::EggLink.DanhengServer.Proto.ItemCostData costData_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemCostData CostData {
      get { return costData_; }
      set {
        costData_ = value;
      }
    }

    /// <summary>Field number for the "uint_reforge_num_value" field.</summary>
    public const int UintReforgeNumValueFieldNumber = 7;
    private uint uintReforgeNumValue_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint UintReforgeNumValue {
      get { return uintReforgeNumValue_; }
      set {
        uintReforgeNumValue_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as WorkbenchReforgeFormulaFuncInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(WorkbenchReforgeFormulaFuncInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IntReforgeNumValue != other.IntReforgeNumValue) return false;
      if (CanFreeReforge != other.CanFreeReforge) return false;
      if (FreeReforgeNum != other.FreeReforgeNum) return false;
      if (!object.Equals(CostData, other.CostData)) return false;
      if (UintReforgeNumValue != other.UintReforgeNumValue) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IntReforgeNumValue != 0) hash ^= IntReforgeNumValue.GetHashCode();
      if (CanFreeReforge != false) hash ^= CanFreeReforge.GetHashCode();
      if (FreeReforgeNum != 0) hash ^= FreeReforgeNum.GetHashCode();
      if (costData_ != null) hash ^= CostData.GetHashCode();
      if (UintReforgeNumValue != 0) hash ^= UintReforgeNumValue.GetHashCode();
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
      if (costData_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(CostData);
      }
      if (CanFreeReforge != false) {
        output.WriteRawTag(24);
        output.WriteBool(CanFreeReforge);
      }
      if (FreeReforgeNum != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(FreeReforgeNum);
      }
      if (UintReforgeNumValue != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(UintReforgeNumValue);
      }
      if (IntReforgeNumValue != 0) {
        output.WriteRawTag(96);
        output.WriteInt32(IntReforgeNumValue);
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
      if (costData_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(CostData);
      }
      if (CanFreeReforge != false) {
        output.WriteRawTag(24);
        output.WriteBool(CanFreeReforge);
      }
      if (FreeReforgeNum != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(FreeReforgeNum);
      }
      if (UintReforgeNumValue != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(UintReforgeNumValue);
      }
      if (IntReforgeNumValue != 0) {
        output.WriteRawTag(96);
        output.WriteInt32(IntReforgeNumValue);
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
      if (IntReforgeNumValue != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(IntReforgeNumValue);
      }
      if (CanFreeReforge != false) {
        size += 1 + 1;
      }
      if (FreeReforgeNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FreeReforgeNum);
      }
      if (costData_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CostData);
      }
      if (UintReforgeNumValue != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(UintReforgeNumValue);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(WorkbenchReforgeFormulaFuncInfo other) {
      if (other == null) {
        return;
      }
      if (other.IntReforgeNumValue != 0) {
        IntReforgeNumValue = other.IntReforgeNumValue;
      }
      if (other.CanFreeReforge != false) {
        CanFreeReforge = other.CanFreeReforge;
      }
      if (other.FreeReforgeNum != 0) {
        FreeReforgeNum = other.FreeReforgeNum;
      }
      if (other.costData_ != null) {
        if (costData_ == null) {
          CostData = new global::EggLink.DanhengServer.Proto.ItemCostData();
        }
        CostData.MergeFrom(other.CostData);
      }
      if (other.UintReforgeNumValue != 0) {
        UintReforgeNumValue = other.UintReforgeNumValue;
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
            if (costData_ == null) {
              CostData = new global::EggLink.DanhengServer.Proto.ItemCostData();
            }
            input.ReadMessage(CostData);
            break;
          }
          case 24: {
            CanFreeReforge = input.ReadBool();
            break;
          }
          case 32: {
            FreeReforgeNum = input.ReadUInt32();
            break;
          }
          case 56: {
            UintReforgeNumValue = input.ReadUInt32();
            break;
          }
          case 96: {
            IntReforgeNumValue = input.ReadInt32();
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
            if (costData_ == null) {
              CostData = new global::EggLink.DanhengServer.Proto.ItemCostData();
            }
            input.ReadMessage(CostData);
            break;
          }
          case 24: {
            CanFreeReforge = input.ReadBool();
            break;
          }
          case 32: {
            FreeReforgeNum = input.ReadUInt32();
            break;
          }
          case 56: {
            UintReforgeNumValue = input.ReadUInt32();
            break;
          }
          case 96: {
            IntReforgeNumValue = input.ReadInt32();
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