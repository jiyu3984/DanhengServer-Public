// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BuyGoodsCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from BuyGoodsCsReq.proto</summary>
  public static partial class BuyGoodsCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for BuyGoodsCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BuyGoodsCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNCdXlHb29kc0NzUmVxLnByb3RvIn8KDUJ1eUdvb2RzQ3NSZXESDwoHc2hv",
            "cF9pZBgIIAEoDRITCgtIRkdMSEpQREJISRgHIAMoDRIRCglnb29kc19udW0Y",
            "DSABKA0SDwoHaXRlbV9pZBgEIAEoDRIQCghnb29kc19pZBgDIAEoDRISCgpt",
            "b25zdGVyX2lkGAEgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJv",
            "dG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.BuyGoodsCsReq), global::EggLink.DanhengServer.Proto.BuyGoodsCsReq.Parser, new[]{ "ShopId", "HFGLHJPDBHI", "GoodsNum", "ItemId", "GoodsId", "MonsterId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class BuyGoodsCsReq : pb::IMessage<BuyGoodsCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BuyGoodsCsReq> _parser = new pb::MessageParser<BuyGoodsCsReq>(() => new BuyGoodsCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BuyGoodsCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.BuyGoodsCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BuyGoodsCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BuyGoodsCsReq(BuyGoodsCsReq other) : this() {
      shopId_ = other.shopId_;
      hFGLHJPDBHI_ = other.hFGLHJPDBHI_.Clone();
      goodsNum_ = other.goodsNum_;
      itemId_ = other.itemId_;
      goodsId_ = other.goodsId_;
      monsterId_ = other.monsterId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BuyGoodsCsReq Clone() {
      return new BuyGoodsCsReq(this);
    }

    /// <summary>Field number for the "shop_id" field.</summary>
    public const int ShopIdFieldNumber = 8;
    private uint shopId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ShopId {
      get { return shopId_; }
      set {
        shopId_ = value;
      }
    }

    /// <summary>Field number for the "HFGLHJPDBHI" field.</summary>
    public const int HFGLHJPDBHIFieldNumber = 7;
    private static readonly pb::FieldCodec<uint> _repeated_hFGLHJPDBHI_codec
        = pb::FieldCodec.ForUInt32(58);
    private readonly pbc::RepeatedField<uint> hFGLHJPDBHI_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> HFGLHJPDBHI {
      get { return hFGLHJPDBHI_; }
    }

    /// <summary>Field number for the "goods_num" field.</summary>
    public const int GoodsNumFieldNumber = 13;
    private uint goodsNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GoodsNum {
      get { return goodsNum_; }
      set {
        goodsNum_ = value;
      }
    }

    /// <summary>Field number for the "item_id" field.</summary>
    public const int ItemIdFieldNumber = 4;
    private uint itemId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ItemId {
      get { return itemId_; }
      set {
        itemId_ = value;
      }
    }

    /// <summary>Field number for the "goods_id" field.</summary>
    public const int GoodsIdFieldNumber = 3;
    private uint goodsId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GoodsId {
      get { return goodsId_; }
      set {
        goodsId_ = value;
      }
    }

    /// <summary>Field number for the "monster_id" field.</summary>
    public const int MonsterIdFieldNumber = 1;
    private uint monsterId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MonsterId {
      get { return monsterId_; }
      set {
        monsterId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BuyGoodsCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BuyGoodsCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ShopId != other.ShopId) return false;
      if(!hFGLHJPDBHI_.Equals(other.hFGLHJPDBHI_)) return false;
      if (GoodsNum != other.GoodsNum) return false;
      if (ItemId != other.ItemId) return false;
      if (GoodsId != other.GoodsId) return false;
      if (MonsterId != other.MonsterId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ShopId != 0) hash ^= ShopId.GetHashCode();
      hash ^= hFGLHJPDBHI_.GetHashCode();
      if (GoodsNum != 0) hash ^= GoodsNum.GetHashCode();
      if (ItemId != 0) hash ^= ItemId.GetHashCode();
      if (GoodsId != 0) hash ^= GoodsId.GetHashCode();
      if (MonsterId != 0) hash ^= MonsterId.GetHashCode();
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
      if (MonsterId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(MonsterId);
      }
      if (GoodsId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(GoodsId);
      }
      if (ItemId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(ItemId);
      }
      hFGLHJPDBHI_.WriteTo(output, _repeated_hFGLHJPDBHI_codec);
      if (ShopId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(ShopId);
      }
      if (GoodsNum != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(GoodsNum);
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
      if (MonsterId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(MonsterId);
      }
      if (GoodsId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(GoodsId);
      }
      if (ItemId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(ItemId);
      }
      hFGLHJPDBHI_.WriteTo(ref output, _repeated_hFGLHJPDBHI_codec);
      if (ShopId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(ShopId);
      }
      if (GoodsNum != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(GoodsNum);
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
      if (ShopId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ShopId);
      }
      size += hFGLHJPDBHI_.CalculateSize(_repeated_hFGLHJPDBHI_codec);
      if (GoodsNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GoodsNum);
      }
      if (ItemId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ItemId);
      }
      if (GoodsId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GoodsId);
      }
      if (MonsterId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MonsterId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BuyGoodsCsReq other) {
      if (other == null) {
        return;
      }
      if (other.ShopId != 0) {
        ShopId = other.ShopId;
      }
      hFGLHJPDBHI_.Add(other.hFGLHJPDBHI_);
      if (other.GoodsNum != 0) {
        GoodsNum = other.GoodsNum;
      }
      if (other.ItemId != 0) {
        ItemId = other.ItemId;
      }
      if (other.GoodsId != 0) {
        GoodsId = other.GoodsId;
      }
      if (other.MonsterId != 0) {
        MonsterId = other.MonsterId;
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
            MonsterId = input.ReadUInt32();
            break;
          }
          case 24: {
            GoodsId = input.ReadUInt32();
            break;
          }
          case 32: {
            ItemId = input.ReadUInt32();
            break;
          }
          case 58:
          case 56: {
            hFGLHJPDBHI_.AddEntriesFrom(input, _repeated_hFGLHJPDBHI_codec);
            break;
          }
          case 64: {
            ShopId = input.ReadUInt32();
            break;
          }
          case 104: {
            GoodsNum = input.ReadUInt32();
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
            MonsterId = input.ReadUInt32();
            break;
          }
          case 24: {
            GoodsId = input.ReadUInt32();
            break;
          }
          case 32: {
            ItemId = input.ReadUInt32();
            break;
          }
          case 58:
          case 56: {
            hFGLHJPDBHI_.AddEntriesFrom(ref input, _repeated_hFGLHJPDBHI_codec);
            break;
          }
          case 64: {
            ShopId = input.ReadUInt32();
            break;
          }
          case 104: {
            GoodsNum = input.ReadUInt32();
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