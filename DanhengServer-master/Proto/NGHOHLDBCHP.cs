// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: NGHOHLDBCHP.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from NGHOHLDBCHP.proto</summary>
  public static partial class NGHOHLDBCHPReflection {

    #region Descriptor
    /// <summary>File descriptor for NGHOHLDBCHP.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static NGHOHLDBCHPReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFOR0hPSExEQkNIUC5wcm90bxoOSXRlbUxpc3QucHJvdG8iVQoLTkdIT0hM",
            "REJDSFASEwoLSUJLSE1JQ0xFQkoYBSABKA0SEwoLQ0lMSExES09ISFAYCSAB",
            "KA0SHAoJaXRlbV9saXN0GAggASgLMgkuSXRlbUxpc3RCHqoCG0VnZ0xpbmsu",
            "RGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ItemListReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.NGHOHLDBCHP), global::EggLink.DanhengServer.Proto.NGHOHLDBCHP.Parser, new[]{ "IBKHMICLEBJ", "CILHLDKOHHP", "ItemList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class NGHOHLDBCHP : pb::IMessage<NGHOHLDBCHP>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<NGHOHLDBCHP> _parser = new pb::MessageParser<NGHOHLDBCHP>(() => new NGHOHLDBCHP());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<NGHOHLDBCHP> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.NGHOHLDBCHPReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NGHOHLDBCHP() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NGHOHLDBCHP(NGHOHLDBCHP other) : this() {
      iBKHMICLEBJ_ = other.iBKHMICLEBJ_;
      cILHLDKOHHP_ = other.cILHLDKOHHP_;
      itemList_ = other.itemList_ != null ? other.itemList_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NGHOHLDBCHP Clone() {
      return new NGHOHLDBCHP(this);
    }

    /// <summary>Field number for the "IBKHMICLEBJ" field.</summary>
    public const int IBKHMICLEBJFieldNumber = 5;
    private uint iBKHMICLEBJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint IBKHMICLEBJ {
      get { return iBKHMICLEBJ_; }
      set {
        iBKHMICLEBJ_ = value;
      }
    }

    /// <summary>Field number for the "CILHLDKOHHP" field.</summary>
    public const int CILHLDKOHHPFieldNumber = 9;
    private uint cILHLDKOHHP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CILHLDKOHHP {
      get { return cILHLDKOHHP_; }
      set {
        cILHLDKOHHP_ = value;
      }
    }

    /// <summary>Field number for the "item_list" field.</summary>
    public const int ItemListFieldNumber = 8;
    private global::EggLink.DanhengServer.Proto.ItemList itemList_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemList ItemList {
      get { return itemList_; }
      set {
        itemList_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as NGHOHLDBCHP);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(NGHOHLDBCHP other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IBKHMICLEBJ != other.IBKHMICLEBJ) return false;
      if (CILHLDKOHHP != other.CILHLDKOHHP) return false;
      if (!object.Equals(ItemList, other.ItemList)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IBKHMICLEBJ != 0) hash ^= IBKHMICLEBJ.GetHashCode();
      if (CILHLDKOHHP != 0) hash ^= CILHLDKOHHP.GetHashCode();
      if (itemList_ != null) hash ^= ItemList.GetHashCode();
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
      if (IBKHMICLEBJ != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(IBKHMICLEBJ);
      }
      if (itemList_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(ItemList);
      }
      if (CILHLDKOHHP != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(CILHLDKOHHP);
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
      if (IBKHMICLEBJ != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(IBKHMICLEBJ);
      }
      if (itemList_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(ItemList);
      }
      if (CILHLDKOHHP != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(CILHLDKOHHP);
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
      if (IBKHMICLEBJ != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(IBKHMICLEBJ);
      }
      if (CILHLDKOHHP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CILHLDKOHHP);
      }
      if (itemList_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ItemList);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(NGHOHLDBCHP other) {
      if (other == null) {
        return;
      }
      if (other.IBKHMICLEBJ != 0) {
        IBKHMICLEBJ = other.IBKHMICLEBJ;
      }
      if (other.CILHLDKOHHP != 0) {
        CILHLDKOHHP = other.CILHLDKOHHP;
      }
      if (other.itemList_ != null) {
        if (itemList_ == null) {
          ItemList = new global::EggLink.DanhengServer.Proto.ItemList();
        }
        ItemList.MergeFrom(other.ItemList);
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
            IBKHMICLEBJ = input.ReadUInt32();
            break;
          }
          case 66: {
            if (itemList_ == null) {
              ItemList = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(ItemList);
            break;
          }
          case 72: {
            CILHLDKOHHP = input.ReadUInt32();
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
            IBKHMICLEBJ = input.ReadUInt32();
            break;
          }
          case 66: {
            if (itemList_ == null) {
              ItemList = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(ItemList);
            break;
          }
          case 72: {
            CILHLDKOHHP = input.ReadUInt32();
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
