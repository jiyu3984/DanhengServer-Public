// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CityShopInfoScNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from CityShopInfoScNotify.proto</summary>
  public static partial class CityShopInfoScNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for CityShopInfoScNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CityShopInfoScNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpDaXR5U2hvcEluZm9TY05vdGlmeS5wcm90byJdChRDaXR5U2hvcEluZm9T",
            "Y05vdGlmeRILCgNleHAYCCABKA0SDQoFbGV2ZWwYDCABKA0SGAoQVGFrZW5M",
            "ZXZlbHJld2FyZBgFIAEoBBIPCgdzaG9wX2lkGAkgASgNQh6qAhtFZ2dMaW5r",
            "LkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.CityShopInfoScNotify), global::EggLink.DanhengServer.Proto.CityShopInfoScNotify.Parser, new[]{ "Exp", "Level", "TakenLevelreward", "ShopId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class CityShopInfoScNotify : pb::IMessage<CityShopInfoScNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CityShopInfoScNotify> _parser = new pb::MessageParser<CityShopInfoScNotify>(() => new CityShopInfoScNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CityShopInfoScNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.CityShopInfoScNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CityShopInfoScNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CityShopInfoScNotify(CityShopInfoScNotify other) : this() {
      exp_ = other.exp_;
      level_ = other.level_;
      takenLevelreward_ = other.takenLevelreward_;
      shopId_ = other.shopId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CityShopInfoScNotify Clone() {
      return new CityShopInfoScNotify(this);
    }

    /// <summary>Field number for the "exp" field.</summary>
    public const int ExpFieldNumber = 8;
    private uint exp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Exp {
      get { return exp_; }
      set {
        exp_ = value;
      }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 12;
    private uint level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "TakenLevelreward" field.</summary>
    public const int TakenLevelrewardFieldNumber = 5;
    private ulong takenLevelreward_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong TakenLevelreward {
      get { return takenLevelreward_; }
      set {
        takenLevelreward_ = value;
      }
    }

    /// <summary>Field number for the "shop_id" field.</summary>
    public const int ShopIdFieldNumber = 9;
    private uint shopId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ShopId {
      get { return shopId_; }
      set {
        shopId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CityShopInfoScNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CityShopInfoScNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Exp != other.Exp) return false;
      if (Level != other.Level) return false;
      if (TakenLevelreward != other.TakenLevelreward) return false;
      if (ShopId != other.ShopId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Exp != 0) hash ^= Exp.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
      if (TakenLevelreward != 0UL) hash ^= TakenLevelreward.GetHashCode();
      if (ShopId != 0) hash ^= ShopId.GetHashCode();
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
      if (TakenLevelreward != 0UL) {
        output.WriteRawTag(40);
        output.WriteUInt64(TakenLevelreward);
      }
      if (Exp != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Exp);
      }
      if (ShopId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(ShopId);
      }
      if (Level != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Level);
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
      if (TakenLevelreward != 0UL) {
        output.WriteRawTag(40);
        output.WriteUInt64(TakenLevelreward);
      }
      if (Exp != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Exp);
      }
      if (ShopId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(ShopId);
      }
      if (Level != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Level);
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
      if (Exp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Exp);
      }
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Level);
      }
      if (TakenLevelreward != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(TakenLevelreward);
      }
      if (ShopId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ShopId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CityShopInfoScNotify other) {
      if (other == null) {
        return;
      }
      if (other.Exp != 0) {
        Exp = other.Exp;
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
      if (other.TakenLevelreward != 0UL) {
        TakenLevelreward = other.TakenLevelreward;
      }
      if (other.ShopId != 0) {
        ShopId = other.ShopId;
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
            TakenLevelreward = input.ReadUInt64();
            break;
          }
          case 64: {
            Exp = input.ReadUInt32();
            break;
          }
          case 72: {
            ShopId = input.ReadUInt32();
            break;
          }
          case 96: {
            Level = input.ReadUInt32();
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
            TakenLevelreward = input.ReadUInt64();
            break;
          }
          case 64: {
            Exp = input.ReadUInt32();
            break;
          }
          case 72: {
            ShopId = input.ReadUInt32();
            break;
          }
          case 96: {
            Level = input.ReadUInt32();
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