// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TrainPartyGameCard.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from TrainPartyGameCard.proto</summary>
  public static partial class TrainPartyGameCardReflection {

    #region Descriptor
    /// <summary>File descriptor for TrainPartyGameCard.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TrainPartyGameCardReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhUcmFpblBhcnR5R2FtZUNhcmQucHJvdG8iYgoSVHJhaW5QYXJ0eUdhbWVD",
            "YXJkEhEKCXVuaXF1ZV9pZBgGIAEoDRITCgtMSEZMQ0ZOQU9QQhgPIAEoDRIP",
            "CgdjYXJkX2lkGAMgASgNEhMKC01DQkNCTVBEREJMGAEgAygNQh6qAhtFZ2dM",
            "aW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.TrainPartyGameCard), global::EggLink.DanhengServer.Proto.TrainPartyGameCard.Parser, new[]{ "UniqueId", "LHFLCFNAOPB", "CardId", "MCBCBMPDDBL" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class TrainPartyGameCard : pb::IMessage<TrainPartyGameCard>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TrainPartyGameCard> _parser = new pb::MessageParser<TrainPartyGameCard>(() => new TrainPartyGameCard());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TrainPartyGameCard> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.TrainPartyGameCardReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TrainPartyGameCard() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TrainPartyGameCard(TrainPartyGameCard other) : this() {
      uniqueId_ = other.uniqueId_;
      lHFLCFNAOPB_ = other.lHFLCFNAOPB_;
      cardId_ = other.cardId_;
      mCBCBMPDDBL_ = other.mCBCBMPDDBL_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TrainPartyGameCard Clone() {
      return new TrainPartyGameCard(this);
    }

    /// <summary>Field number for the "unique_id" field.</summary>
    public const int UniqueIdFieldNumber = 6;
    private uint uniqueId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint UniqueId {
      get { return uniqueId_; }
      set {
        uniqueId_ = value;
      }
    }

    /// <summary>Field number for the "LHFLCFNAOPB" field.</summary>
    public const int LHFLCFNAOPBFieldNumber = 15;
    private uint lHFLCFNAOPB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LHFLCFNAOPB {
      get { return lHFLCFNAOPB_; }
      set {
        lHFLCFNAOPB_ = value;
      }
    }

    /// <summary>Field number for the "card_id" field.</summary>
    public const int CardIdFieldNumber = 3;
    private uint cardId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CardId {
      get { return cardId_; }
      set {
        cardId_ = value;
      }
    }

    /// <summary>Field number for the "MCBCBMPDDBL" field.</summary>
    public const int MCBCBMPDDBLFieldNumber = 1;
    private static readonly pb::FieldCodec<uint> _repeated_mCBCBMPDDBL_codec
        = pb::FieldCodec.ForUInt32(10);
    private readonly pbc::RepeatedField<uint> mCBCBMPDDBL_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> MCBCBMPDDBL {
      get { return mCBCBMPDDBL_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TrainPartyGameCard);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TrainPartyGameCard other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UniqueId != other.UniqueId) return false;
      if (LHFLCFNAOPB != other.LHFLCFNAOPB) return false;
      if (CardId != other.CardId) return false;
      if(!mCBCBMPDDBL_.Equals(other.mCBCBMPDDBL_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (UniqueId != 0) hash ^= UniqueId.GetHashCode();
      if (LHFLCFNAOPB != 0) hash ^= LHFLCFNAOPB.GetHashCode();
      if (CardId != 0) hash ^= CardId.GetHashCode();
      hash ^= mCBCBMPDDBL_.GetHashCode();
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
      mCBCBMPDDBL_.WriteTo(output, _repeated_mCBCBMPDDBL_codec);
      if (CardId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(CardId);
      }
      if (UniqueId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(UniqueId);
      }
      if (LHFLCFNAOPB != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(LHFLCFNAOPB);
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
      mCBCBMPDDBL_.WriteTo(ref output, _repeated_mCBCBMPDDBL_codec);
      if (CardId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(CardId);
      }
      if (UniqueId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(UniqueId);
      }
      if (LHFLCFNAOPB != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(LHFLCFNAOPB);
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
      if (LHFLCFNAOPB != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LHFLCFNAOPB);
      }
      if (CardId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CardId);
      }
      size += mCBCBMPDDBL_.CalculateSize(_repeated_mCBCBMPDDBL_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TrainPartyGameCard other) {
      if (other == null) {
        return;
      }
      if (other.UniqueId != 0) {
        UniqueId = other.UniqueId;
      }
      if (other.LHFLCFNAOPB != 0) {
        LHFLCFNAOPB = other.LHFLCFNAOPB;
      }
      if (other.CardId != 0) {
        CardId = other.CardId;
      }
      mCBCBMPDDBL_.Add(other.mCBCBMPDDBL_);
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
          case 10:
          case 8: {
            mCBCBMPDDBL_.AddEntriesFrom(input, _repeated_mCBCBMPDDBL_codec);
            break;
          }
          case 24: {
            CardId = input.ReadUInt32();
            break;
          }
          case 48: {
            UniqueId = input.ReadUInt32();
            break;
          }
          case 120: {
            LHFLCFNAOPB = input.ReadUInt32();
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
          case 10:
          case 8: {
            mCBCBMPDDBL_.AddEntriesFrom(ref input, _repeated_mCBCBMPDDBL_codec);
            break;
          }
          case 24: {
            CardId = input.ReadUInt32();
            break;
          }
          case 48: {
            UniqueId = input.ReadUInt32();
            break;
          }
          case 120: {
            LHFLCFNAOPB = input.ReadUInt32();
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
