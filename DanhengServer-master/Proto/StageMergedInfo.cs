// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: StageMergedInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from StageMergedInfo.proto</summary>
  public static partial class StageMergedInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for StageMergedInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StageMergedInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVTdGFnZU1lcmdlZEluZm8ucHJvdG8iZAoPU3RhZ2VNZXJnZWRJbmZvEhMK",
            "C0hJTk9CSEhJQkFBGA8gASgIEhAKCGxldmVsX2lkGAMgASgNEhMKC09IRExN",
            "QkVHQ0lCGAggASgIEhUKDXN0YWdlX3BlcmlvZHMYDSADKA1CHqoCG0VnZ0xp",
            "bmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.StageMergedInfo), global::EggLink.DanhengServer.Proto.StageMergedInfo.Parser, new[]{ "HINOBHHIBAA", "LevelId", "OHDLMBEGCIB", "StagePeriods" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class StageMergedInfo : pb::IMessage<StageMergedInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<StageMergedInfo> _parser = new pb::MessageParser<StageMergedInfo>(() => new StageMergedInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<StageMergedInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.StageMergedInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StageMergedInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StageMergedInfo(StageMergedInfo other) : this() {
      hINOBHHIBAA_ = other.hINOBHHIBAA_;
      levelId_ = other.levelId_;
      oHDLMBEGCIB_ = other.oHDLMBEGCIB_;
      stagePeriods_ = other.stagePeriods_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StageMergedInfo Clone() {
      return new StageMergedInfo(this);
    }

    /// <summary>Field number for the "HINOBHHIBAA" field.</summary>
    public const int HINOBHHIBAAFieldNumber = 15;
    private bool hINOBHHIBAA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HINOBHHIBAA {
      get { return hINOBHHIBAA_; }
      set {
        hINOBHHIBAA_ = value;
      }
    }

    /// <summary>Field number for the "level_id" field.</summary>
    public const int LevelIdFieldNumber = 3;
    private uint levelId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LevelId {
      get { return levelId_; }
      set {
        levelId_ = value;
      }
    }

    /// <summary>Field number for the "OHDLMBEGCIB" field.</summary>
    public const int OHDLMBEGCIBFieldNumber = 8;
    private bool oHDLMBEGCIB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool OHDLMBEGCIB {
      get { return oHDLMBEGCIB_; }
      set {
        oHDLMBEGCIB_ = value;
      }
    }

    /// <summary>Field number for the "stage_periods" field.</summary>
    public const int StagePeriodsFieldNumber = 13;
    private static readonly pb::FieldCodec<uint> _repeated_stagePeriods_codec
        = pb::FieldCodec.ForUInt32(106);
    private readonly pbc::RepeatedField<uint> stagePeriods_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> StagePeriods {
      get { return stagePeriods_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as StageMergedInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(StageMergedInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (HINOBHHIBAA != other.HINOBHHIBAA) return false;
      if (LevelId != other.LevelId) return false;
      if (OHDLMBEGCIB != other.OHDLMBEGCIB) return false;
      if(!stagePeriods_.Equals(other.stagePeriods_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HINOBHHIBAA != false) hash ^= HINOBHHIBAA.GetHashCode();
      if (LevelId != 0) hash ^= LevelId.GetHashCode();
      if (OHDLMBEGCIB != false) hash ^= OHDLMBEGCIB.GetHashCode();
      hash ^= stagePeriods_.GetHashCode();
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
      if (LevelId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(LevelId);
      }
      if (OHDLMBEGCIB != false) {
        output.WriteRawTag(64);
        output.WriteBool(OHDLMBEGCIB);
      }
      stagePeriods_.WriteTo(output, _repeated_stagePeriods_codec);
      if (HINOBHHIBAA != false) {
        output.WriteRawTag(120);
        output.WriteBool(HINOBHHIBAA);
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
      if (LevelId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(LevelId);
      }
      if (OHDLMBEGCIB != false) {
        output.WriteRawTag(64);
        output.WriteBool(OHDLMBEGCIB);
      }
      stagePeriods_.WriteTo(ref output, _repeated_stagePeriods_codec);
      if (HINOBHHIBAA != false) {
        output.WriteRawTag(120);
        output.WriteBool(HINOBHHIBAA);
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
      if (HINOBHHIBAA != false) {
        size += 1 + 1;
      }
      if (LevelId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LevelId);
      }
      if (OHDLMBEGCIB != false) {
        size += 1 + 1;
      }
      size += stagePeriods_.CalculateSize(_repeated_stagePeriods_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(StageMergedInfo other) {
      if (other == null) {
        return;
      }
      if (other.HINOBHHIBAA != false) {
        HINOBHHIBAA = other.HINOBHHIBAA;
      }
      if (other.LevelId != 0) {
        LevelId = other.LevelId;
      }
      if (other.OHDLMBEGCIB != false) {
        OHDLMBEGCIB = other.OHDLMBEGCIB;
      }
      stagePeriods_.Add(other.stagePeriods_);
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
          case 24: {
            LevelId = input.ReadUInt32();
            break;
          }
          case 64: {
            OHDLMBEGCIB = input.ReadBool();
            break;
          }
          case 106:
          case 104: {
            stagePeriods_.AddEntriesFrom(input, _repeated_stagePeriods_codec);
            break;
          }
          case 120: {
            HINOBHHIBAA = input.ReadBool();
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
          case 24: {
            LevelId = input.ReadUInt32();
            break;
          }
          case 64: {
            OHDLMBEGCIB = input.ReadBool();
            break;
          }
          case 106:
          case 104: {
            stagePeriods_.AddEntriesFrom(ref input, _repeated_stagePeriods_codec);
            break;
          }
          case 120: {
            HINOBHHIBAA = input.ReadBool();
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