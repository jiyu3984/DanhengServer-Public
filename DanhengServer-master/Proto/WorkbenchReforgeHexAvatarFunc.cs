// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WorkbenchReforgeHexAvatarFunc.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from WorkbenchReforgeHexAvatarFunc.proto</summary>
  public static partial class WorkbenchReforgeHexAvatarFuncReflection {

    #region Descriptor
    /// <summary>File descriptor for WorkbenchReforgeHexAvatarFunc.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WorkbenchReforgeHexAvatarFuncReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNXb3JrYmVuY2hSZWZvcmdlSGV4QXZhdGFyRnVuYy5wcm90bxoSSXRlbUNv",
            "c3REYXRhLnByb3RvInoKHVdvcmtiZW5jaFJlZm9yZ2VIZXhBdmF0YXJGdW5j",
            "Eh0KFWludF9yZWZvcmdlX251bV92YWx1ZRgFIAEoBRIYChBmcmVlX3JlZm9y",
            "Z2VfbnVtGAogASgNEiAKCWNvc3RfZGF0YRgGIAEoCzINLkl0ZW1Db3N0RGF0",
            "YUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ItemCostDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.WorkbenchReforgeHexAvatarFunc), global::EggLink.DanhengServer.Proto.WorkbenchReforgeHexAvatarFunc.Parser, new[]{ "IntReforgeNumValue", "FreeReforgeNum", "CostData" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class WorkbenchReforgeHexAvatarFunc : pb::IMessage<WorkbenchReforgeHexAvatarFunc>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<WorkbenchReforgeHexAvatarFunc> _parser = new pb::MessageParser<WorkbenchReforgeHexAvatarFunc>(() => new WorkbenchReforgeHexAvatarFunc());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<WorkbenchReforgeHexAvatarFunc> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.WorkbenchReforgeHexAvatarFuncReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WorkbenchReforgeHexAvatarFunc() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WorkbenchReforgeHexAvatarFunc(WorkbenchReforgeHexAvatarFunc other) : this() {
      intReforgeNumValue_ = other.intReforgeNumValue_;
      freeReforgeNum_ = other.freeReforgeNum_;
      costData_ = other.costData_ != null ? other.costData_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WorkbenchReforgeHexAvatarFunc Clone() {
      return new WorkbenchReforgeHexAvatarFunc(this);
    }

    /// <summary>Field number for the "int_reforge_num_value" field.</summary>
    public const int IntReforgeNumValueFieldNumber = 5;
    private int intReforgeNumValue_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int IntReforgeNumValue {
      get { return intReforgeNumValue_; }
      set {
        intReforgeNumValue_ = value;
      }
    }

    /// <summary>Field number for the "free_reforge_num" field.</summary>
    public const int FreeReforgeNumFieldNumber = 10;
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
    public const int CostDataFieldNumber = 6;
    private global::EggLink.DanhengServer.Proto.ItemCostData costData_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemCostData CostData {
      get { return costData_; }
      set {
        costData_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as WorkbenchReforgeHexAvatarFunc);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(WorkbenchReforgeHexAvatarFunc other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IntReforgeNumValue != other.IntReforgeNumValue) return false;
      if (FreeReforgeNum != other.FreeReforgeNum) return false;
      if (!object.Equals(CostData, other.CostData)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IntReforgeNumValue != 0) hash ^= IntReforgeNumValue.GetHashCode();
      if (FreeReforgeNum != 0) hash ^= FreeReforgeNum.GetHashCode();
      if (costData_ != null) hash ^= CostData.GetHashCode();
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
      if (IntReforgeNumValue != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(IntReforgeNumValue);
      }
      if (costData_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(CostData);
      }
      if (FreeReforgeNum != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(FreeReforgeNum);
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
      if (IntReforgeNumValue != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(IntReforgeNumValue);
      }
      if (costData_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(CostData);
      }
      if (FreeReforgeNum != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(FreeReforgeNum);
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
      if (FreeReforgeNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FreeReforgeNum);
      }
      if (costData_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CostData);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(WorkbenchReforgeHexAvatarFunc other) {
      if (other == null) {
        return;
      }
      if (other.IntReforgeNumValue != 0) {
        IntReforgeNumValue = other.IntReforgeNumValue;
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
          case 40: {
            IntReforgeNumValue = input.ReadInt32();
            break;
          }
          case 50: {
            if (costData_ == null) {
              CostData = new global::EggLink.DanhengServer.Proto.ItemCostData();
            }
            input.ReadMessage(CostData);
            break;
          }
          case 80: {
            FreeReforgeNum = input.ReadUInt32();
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
          case 40: {
            IntReforgeNumValue = input.ReadInt32();
            break;
          }
          case 50: {
            if (costData_ == null) {
              CostData = new global::EggLink.DanhengServer.Proto.ItemCostData();
            }
            input.ReadMessage(CostData);
            break;
          }
          case 80: {
            FreeReforgeNum = input.ReadUInt32();
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
