// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: UseTreasureDungeonItemCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from UseTreasureDungeonItemCsReq.proto</summary>
  public static partial class UseTreasureDungeonItemCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for UseTreasureDungeonItemCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UseTreasureDungeonItemCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFVc2VUcmVhc3VyZUR1bmdlb25JdGVtQ3NSZXEucHJvdG8iVgobVXNlVHJl",
            "YXN1cmVEdW5nZW9uSXRlbUNzUmVxEhEKCXVuaXF1ZV9pZBgJIAEoDRIPCgdp",
            "dGVtX2lkGAYgASgNEhMKC0RMRUVKR0ZBQkxDGAQgASgNQh6qAhtFZ2dMaW5r",
            "LkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.UseTreasureDungeonItemCsReq), global::EggLink.DanhengServer.Proto.UseTreasureDungeonItemCsReq.Parser, new[]{ "UniqueId", "ItemId", "DLEEJGFABLC" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class UseTreasureDungeonItemCsReq : pb::IMessage<UseTreasureDungeonItemCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UseTreasureDungeonItemCsReq> _parser = new pb::MessageParser<UseTreasureDungeonItemCsReq>(() => new UseTreasureDungeonItemCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<UseTreasureDungeonItemCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.UseTreasureDungeonItemCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UseTreasureDungeonItemCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UseTreasureDungeonItemCsReq(UseTreasureDungeonItemCsReq other) : this() {
      uniqueId_ = other.uniqueId_;
      itemId_ = other.itemId_;
      dLEEJGFABLC_ = other.dLEEJGFABLC_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UseTreasureDungeonItemCsReq Clone() {
      return new UseTreasureDungeonItemCsReq(this);
    }

    /// <summary>Field number for the "unique_id" field.</summary>
    public const int UniqueIdFieldNumber = 9;
    private uint uniqueId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint UniqueId {
      get { return uniqueId_; }
      set {
        uniqueId_ = value;
      }
    }

    /// <summary>Field number for the "item_id" field.</summary>
    public const int ItemIdFieldNumber = 6;
    private uint itemId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ItemId {
      get { return itemId_; }
      set {
        itemId_ = value;
      }
    }

    /// <summary>Field number for the "DLEEJGFABLC" field.</summary>
    public const int DLEEJGFABLCFieldNumber = 4;
    private uint dLEEJGFABLC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DLEEJGFABLC {
      get { return dLEEJGFABLC_; }
      set {
        dLEEJGFABLC_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as UseTreasureDungeonItemCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(UseTreasureDungeonItemCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UniqueId != other.UniqueId) return false;
      if (ItemId != other.ItemId) return false;
      if (DLEEJGFABLC != other.DLEEJGFABLC) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (UniqueId != 0) hash ^= UniqueId.GetHashCode();
      if (ItemId != 0) hash ^= ItemId.GetHashCode();
      if (DLEEJGFABLC != 0) hash ^= DLEEJGFABLC.GetHashCode();
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
      if (DLEEJGFABLC != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(DLEEJGFABLC);
      }
      if (ItemId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(ItemId);
      }
      if (UniqueId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(UniqueId);
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
      if (DLEEJGFABLC != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(DLEEJGFABLC);
      }
      if (ItemId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(ItemId);
      }
      if (UniqueId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(UniqueId);
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
      if (UniqueId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(UniqueId);
      }
      if (ItemId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ItemId);
      }
      if (DLEEJGFABLC != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DLEEJGFABLC);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(UseTreasureDungeonItemCsReq other) {
      if (other == null) {
        return;
      }
      if (other.UniqueId != 0) {
        UniqueId = other.UniqueId;
      }
      if (other.ItemId != 0) {
        ItemId = other.ItemId;
      }
      if (other.DLEEJGFABLC != 0) {
        DLEEJGFABLC = other.DLEEJGFABLC;
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
            DLEEJGFABLC = input.ReadUInt32();
            break;
          }
          case 48: {
            ItemId = input.ReadUInt32();
            break;
          }
          case 72: {
            UniqueId = input.ReadUInt32();
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
            DLEEJGFABLC = input.ReadUInt32();
            break;
          }
          case 48: {
            ItemId = input.ReadUInt32();
            break;
          }
          case 72: {
            UniqueId = input.ReadUInt32();
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