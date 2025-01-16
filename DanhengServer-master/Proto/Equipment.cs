// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Equipment.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from Equipment.proto</summary>
  public static partial class EquipmentReflection {

    #region Descriptor
    /// <summary>File descriptor for Equipment.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EquipmentReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg9FcXVpcG1lbnQucHJvdG8ilwEKCUVxdWlwbWVudBINCgVsZXZlbBgJIAEo",
            "DRIXCg9kcmVzc19hdmF0YXJfaWQYCiABKA0SCwoDdGlkGAYgASgNEgsKA2V4",
            "cBgEIAEoDRIRCglwcm9tb3Rpb24YAiABKA0SDAoEcmFuaxgMIAEoDRIRCgl1",
            "bmlxdWVfaWQYASABKA0SFAoMaXNfcHJvdGVjdGVkGAMgASgIQh6qAhtFZ2dM",
            "aW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.Equipment), global::EggLink.DanhengServer.Proto.Equipment.Parser, new[]{ "Level", "DressAvatarId", "Tid", "Exp", "Promotion", "Rank", "UniqueId", "IsProtected" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class Equipment : pb::IMessage<Equipment>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Equipment> _parser = new pb::MessageParser<Equipment>(() => new Equipment());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Equipment> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.EquipmentReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Equipment() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Equipment(Equipment other) : this() {
      level_ = other.level_;
      dressAvatarId_ = other.dressAvatarId_;
      tid_ = other.tid_;
      exp_ = other.exp_;
      promotion_ = other.promotion_;
      rank_ = other.rank_;
      uniqueId_ = other.uniqueId_;
      isProtected_ = other.isProtected_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Equipment Clone() {
      return new Equipment(this);
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 9;
    private uint level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "dress_avatar_id" field.</summary>
    public const int DressAvatarIdFieldNumber = 10;
    private uint dressAvatarId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DressAvatarId {
      get { return dressAvatarId_; }
      set {
        dressAvatarId_ = value;
      }
    }

    /// <summary>Field number for the "tid" field.</summary>
    public const int TidFieldNumber = 6;
    private uint tid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Tid {
      get { return tid_; }
      set {
        tid_ = value;
      }
    }

    /// <summary>Field number for the "exp" field.</summary>
    public const int ExpFieldNumber = 4;
    private uint exp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Exp {
      get { return exp_; }
      set {
        exp_ = value;
      }
    }

    /// <summary>Field number for the "promotion" field.</summary>
    public const int PromotionFieldNumber = 2;
    private uint promotion_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Promotion {
      get { return promotion_; }
      set {
        promotion_ = value;
      }
    }

    /// <summary>Field number for the "rank" field.</summary>
    public const int RankFieldNumber = 12;
    private uint rank_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Rank {
      get { return rank_; }
      set {
        rank_ = value;
      }
    }

    /// <summary>Field number for the "unique_id" field.</summary>
    public const int UniqueIdFieldNumber = 1;
    private uint uniqueId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint UniqueId {
      get { return uniqueId_; }
      set {
        uniqueId_ = value;
      }
    }

    /// <summary>Field number for the "is_protected" field.</summary>
    public const int IsProtectedFieldNumber = 3;
    private bool isProtected_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsProtected {
      get { return isProtected_; }
      set {
        isProtected_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Equipment);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Equipment other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Level != other.Level) return false;
      if (DressAvatarId != other.DressAvatarId) return false;
      if (Tid != other.Tid) return false;
      if (Exp != other.Exp) return false;
      if (Promotion != other.Promotion) return false;
      if (Rank != other.Rank) return false;
      if (UniqueId != other.UniqueId) return false;
      if (IsProtected != other.IsProtected) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Level != 0) hash ^= Level.GetHashCode();
      if (DressAvatarId != 0) hash ^= DressAvatarId.GetHashCode();
      if (Tid != 0) hash ^= Tid.GetHashCode();
      if (Exp != 0) hash ^= Exp.GetHashCode();
      if (Promotion != 0) hash ^= Promotion.GetHashCode();
      if (Rank != 0) hash ^= Rank.GetHashCode();
      if (UniqueId != 0) hash ^= UniqueId.GetHashCode();
      if (IsProtected != false) hash ^= IsProtected.GetHashCode();
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
      if (UniqueId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(UniqueId);
      }
      if (Promotion != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Promotion);
      }
      if (IsProtected != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsProtected);
      }
      if (Exp != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Exp);
      }
      if (Tid != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Tid);
      }
      if (Level != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Level);
      }
      if (DressAvatarId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(DressAvatarId);
      }
      if (Rank != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Rank);
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
      if (UniqueId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(UniqueId);
      }
      if (Promotion != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Promotion);
      }
      if (IsProtected != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsProtected);
      }
      if (Exp != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Exp);
      }
      if (Tid != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Tid);
      }
      if (Level != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Level);
      }
      if (DressAvatarId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(DressAvatarId);
      }
      if (Rank != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Rank);
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
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Level);
      }
      if (DressAvatarId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DressAvatarId);
      }
      if (Tid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Tid);
      }
      if (Exp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Exp);
      }
      if (Promotion != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Promotion);
      }
      if (Rank != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Rank);
      }
      if (UniqueId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(UniqueId);
      }
      if (IsProtected != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Equipment other) {
      if (other == null) {
        return;
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
      if (other.DressAvatarId != 0) {
        DressAvatarId = other.DressAvatarId;
      }
      if (other.Tid != 0) {
        Tid = other.Tid;
      }
      if (other.Exp != 0) {
        Exp = other.Exp;
      }
      if (other.Promotion != 0) {
        Promotion = other.Promotion;
      }
      if (other.Rank != 0) {
        Rank = other.Rank;
      }
      if (other.UniqueId != 0) {
        UniqueId = other.UniqueId;
      }
      if (other.IsProtected != false) {
        IsProtected = other.IsProtected;
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
            UniqueId = input.ReadUInt32();
            break;
          }
          case 16: {
            Promotion = input.ReadUInt32();
            break;
          }
          case 24: {
            IsProtected = input.ReadBool();
            break;
          }
          case 32: {
            Exp = input.ReadUInt32();
            break;
          }
          case 48: {
            Tid = input.ReadUInt32();
            break;
          }
          case 72: {
            Level = input.ReadUInt32();
            break;
          }
          case 80: {
            DressAvatarId = input.ReadUInt32();
            break;
          }
          case 96: {
            Rank = input.ReadUInt32();
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
            UniqueId = input.ReadUInt32();
            break;
          }
          case 16: {
            Promotion = input.ReadUInt32();
            break;
          }
          case 24: {
            IsProtected = input.ReadBool();
            break;
          }
          case 32: {
            Exp = input.ReadUInt32();
            break;
          }
          case 48: {
            Tid = input.ReadUInt32();
            break;
          }
          case 72: {
            Level = input.ReadUInt32();
            break;
          }
          case 80: {
            DressAvatarId = input.ReadUInt32();
            break;
          }
          case 96: {
            Rank = input.ReadUInt32();
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