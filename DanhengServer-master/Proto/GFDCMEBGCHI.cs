// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GFDCMEBGCHI.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GFDCMEBGCHI.proto</summary>
  public static partial class GFDCMEBGCHIReflection {

    #region Descriptor
    /// <summary>File descriptor for GFDCMEBGCHI.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GFDCMEBGCHIReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFHRkRDTUVCR0NISS5wcm90bxoRRk1FSUxBSUdORkIucHJvdG8iUwoLR0ZE",
            "Q01FQkdDSEkSIQoLRkFLRUdBSUlJSUEYAiADKAsyDC5GTUVJTEFJR05GQhIO",
            "CgZtYXBfaWQYBCABKA0SEQoJY29zdF90aW1lGAYgASgNQh6qAhtFZ2dMaW5r",
            "LkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.FMEILAIGNFBReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GFDCMEBGCHI), global::EggLink.DanhengServer.Proto.GFDCMEBGCHI.Parser, new[]{ "FAKEGAIIIIA", "MapId", "CostTime" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GFDCMEBGCHI : pb::IMessage<GFDCMEBGCHI>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GFDCMEBGCHI> _parser = new pb::MessageParser<GFDCMEBGCHI>(() => new GFDCMEBGCHI());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GFDCMEBGCHI> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GFDCMEBGCHIReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GFDCMEBGCHI() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GFDCMEBGCHI(GFDCMEBGCHI other) : this() {
      fAKEGAIIIIA_ = other.fAKEGAIIIIA_.Clone();
      mapId_ = other.mapId_;
      costTime_ = other.costTime_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GFDCMEBGCHI Clone() {
      return new GFDCMEBGCHI(this);
    }

    /// <summary>Field number for the "FAKEGAIIIIA" field.</summary>
    public const int FAKEGAIIIIAFieldNumber = 2;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.FMEILAIGNFB> _repeated_fAKEGAIIIIA_codec
        = pb::FieldCodec.ForMessage(18, global::EggLink.DanhengServer.Proto.FMEILAIGNFB.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.FMEILAIGNFB> fAKEGAIIIIA_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.FMEILAIGNFB>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.FMEILAIGNFB> FAKEGAIIIIA {
      get { return fAKEGAIIIIA_; }
    }

    /// <summary>Field number for the "map_id" field.</summary>
    public const int MapIdFieldNumber = 4;
    private uint mapId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MapId {
      get { return mapId_; }
      set {
        mapId_ = value;
      }
    }

    /// <summary>Field number for the "cost_time" field.</summary>
    public const int CostTimeFieldNumber = 6;
    private uint costTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CostTime {
      get { return costTime_; }
      set {
        costTime_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GFDCMEBGCHI);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GFDCMEBGCHI other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!fAKEGAIIIIA_.Equals(other.fAKEGAIIIIA_)) return false;
      if (MapId != other.MapId) return false;
      if (CostTime != other.CostTime) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= fAKEGAIIIIA_.GetHashCode();
      if (MapId != 0) hash ^= MapId.GetHashCode();
      if (CostTime != 0) hash ^= CostTime.GetHashCode();
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
      fAKEGAIIIIA_.WriteTo(output, _repeated_fAKEGAIIIIA_codec);
      if (MapId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(MapId);
      }
      if (CostTime != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(CostTime);
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
      fAKEGAIIIIA_.WriteTo(ref output, _repeated_fAKEGAIIIIA_codec);
      if (MapId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(MapId);
      }
      if (CostTime != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(CostTime);
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
      size += fAKEGAIIIIA_.CalculateSize(_repeated_fAKEGAIIIIA_codec);
      if (MapId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MapId);
      }
      if (CostTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CostTime);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GFDCMEBGCHI other) {
      if (other == null) {
        return;
      }
      fAKEGAIIIIA_.Add(other.fAKEGAIIIIA_);
      if (other.MapId != 0) {
        MapId = other.MapId;
      }
      if (other.CostTime != 0) {
        CostTime = other.CostTime;
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
            fAKEGAIIIIA_.AddEntriesFrom(input, _repeated_fAKEGAIIIIA_codec);
            break;
          }
          case 32: {
            MapId = input.ReadUInt32();
            break;
          }
          case 48: {
            CostTime = input.ReadUInt32();
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
            fAKEGAIIIIA_.AddEntriesFrom(ref input, _repeated_fAKEGAIIIIA_codec);
            break;
          }
          case 32: {
            MapId = input.ReadUInt32();
            break;
          }
          case 48: {
            CostTime = input.ReadUInt32();
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