// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: UseItemScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from UseItemScRsp.proto</summary>
  public static partial class UseItemScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for UseItemScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UseItemScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJVc2VJdGVtU2NSc3AucHJvdG8aDkl0ZW1MaXN0LnByb3RvIpUBCgxVc2VJ",
            "dGVtU2NSc3ASEwoLdXNlX2l0ZW1faWQYDiABKA0SEwoLT01MTEdIUE9MQUgY",
            "BSABKAQSFgoOdXNlX2l0ZW1fY291bnQYAiABKA0SHgoLcmV0dXJuX2RhdGEY",
            "DCABKAsyCS5JdGVtTGlzdBISCgpmb3JtdWxhX2lkGA8gASgNEg8KB3JldGNv",
            "ZGUYCyABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ItemListReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.UseItemScRsp), global::EggLink.DanhengServer.Proto.UseItemScRsp.Parser, new[]{ "UseItemId", "OMLLGHPOLAH", "UseItemCount", "ReturnData", "FormulaId", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class UseItemScRsp : pb::IMessage<UseItemScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UseItemScRsp> _parser = new pb::MessageParser<UseItemScRsp>(() => new UseItemScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<UseItemScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.UseItemScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UseItemScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UseItemScRsp(UseItemScRsp other) : this() {
      useItemId_ = other.useItemId_;
      oMLLGHPOLAH_ = other.oMLLGHPOLAH_;
      useItemCount_ = other.useItemCount_;
      returnData_ = other.returnData_ != null ? other.returnData_.Clone() : null;
      formulaId_ = other.formulaId_;
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UseItemScRsp Clone() {
      return new UseItemScRsp(this);
    }

    /// <summary>Field number for the "use_item_id" field.</summary>
    public const int UseItemIdFieldNumber = 14;
    private uint useItemId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint UseItemId {
      get { return useItemId_; }
      set {
        useItemId_ = value;
      }
    }

    /// <summary>Field number for the "OMLLGHPOLAH" field.</summary>
    public const int OMLLGHPOLAHFieldNumber = 5;
    private ulong oMLLGHPOLAH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong OMLLGHPOLAH {
      get { return oMLLGHPOLAH_; }
      set {
        oMLLGHPOLAH_ = value;
      }
    }

    /// <summary>Field number for the "use_item_count" field.</summary>
    public const int UseItemCountFieldNumber = 2;
    private uint useItemCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint UseItemCount {
      get { return useItemCount_; }
      set {
        useItemCount_ = value;
      }
    }

    /// <summary>Field number for the "return_data" field.</summary>
    public const int ReturnDataFieldNumber = 12;
    private global::EggLink.DanhengServer.Proto.ItemList returnData_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemList ReturnData {
      get { return returnData_; }
      set {
        returnData_ = value;
      }
    }

    /// <summary>Field number for the "formula_id" field.</summary>
    public const int FormulaIdFieldNumber = 15;
    private uint formulaId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FormulaId {
      get { return formulaId_; }
      set {
        formulaId_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 11;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as UseItemScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(UseItemScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UseItemId != other.UseItemId) return false;
      if (OMLLGHPOLAH != other.OMLLGHPOLAH) return false;
      if (UseItemCount != other.UseItemCount) return false;
      if (!object.Equals(ReturnData, other.ReturnData)) return false;
      if (FormulaId != other.FormulaId) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (UseItemId != 0) hash ^= UseItemId.GetHashCode();
      if (OMLLGHPOLAH != 0UL) hash ^= OMLLGHPOLAH.GetHashCode();
      if (UseItemCount != 0) hash ^= UseItemCount.GetHashCode();
      if (returnData_ != null) hash ^= ReturnData.GetHashCode();
      if (FormulaId != 0) hash ^= FormulaId.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
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
      if (UseItemCount != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(UseItemCount);
      }
      if (OMLLGHPOLAH != 0UL) {
        output.WriteRawTag(40);
        output.WriteUInt64(OMLLGHPOLAH);
      }
      if (Retcode != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Retcode);
      }
      if (returnData_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(ReturnData);
      }
      if (UseItemId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(UseItemId);
      }
      if (FormulaId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(FormulaId);
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
      if (UseItemCount != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(UseItemCount);
      }
      if (OMLLGHPOLAH != 0UL) {
        output.WriteRawTag(40);
        output.WriteUInt64(OMLLGHPOLAH);
      }
      if (Retcode != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Retcode);
      }
      if (returnData_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(ReturnData);
      }
      if (UseItemId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(UseItemId);
      }
      if (FormulaId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(FormulaId);
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
      if (UseItemId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(UseItemId);
      }
      if (OMLLGHPOLAH != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(OMLLGHPOLAH);
      }
      if (UseItemCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(UseItemCount);
      }
      if (returnData_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ReturnData);
      }
      if (FormulaId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FormulaId);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(UseItemScRsp other) {
      if (other == null) {
        return;
      }
      if (other.UseItemId != 0) {
        UseItemId = other.UseItemId;
      }
      if (other.OMLLGHPOLAH != 0UL) {
        OMLLGHPOLAH = other.OMLLGHPOLAH;
      }
      if (other.UseItemCount != 0) {
        UseItemCount = other.UseItemCount;
      }
      if (other.returnData_ != null) {
        if (returnData_ == null) {
          ReturnData = new global::EggLink.DanhengServer.Proto.ItemList();
        }
        ReturnData.MergeFrom(other.ReturnData);
      }
      if (other.FormulaId != 0) {
        FormulaId = other.FormulaId;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
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
          case 16: {
            UseItemCount = input.ReadUInt32();
            break;
          }
          case 40: {
            OMLLGHPOLAH = input.ReadUInt64();
            break;
          }
          case 88: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 98: {
            if (returnData_ == null) {
              ReturnData = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(ReturnData);
            break;
          }
          case 112: {
            UseItemId = input.ReadUInt32();
            break;
          }
          case 120: {
            FormulaId = input.ReadUInt32();
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
          case 16: {
            UseItemCount = input.ReadUInt32();
            break;
          }
          case 40: {
            OMLLGHPOLAH = input.ReadUInt64();
            break;
          }
          case 88: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 98: {
            if (returnData_ == null) {
              ReturnData = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(ReturnData);
            break;
          }
          case 112: {
            UseItemId = input.ReadUInt32();
            break;
          }
          case 120: {
            FormulaId = input.ReadUInt32();
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
