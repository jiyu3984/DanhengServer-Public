// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BJDAAPOAPAI.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from BJDAAPOAPAI.proto</summary>
  public static partial class BJDAAPOAPAIReflection {

    #region Descriptor
    /// <summary>File descriptor for BJDAAPOAPAI.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BJDAAPOAPAIReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFCSkRBQVBPQVBBSS5wcm90bxoRTUtOQUdOR0JGT0kucHJvdG8ijwEKC0JK",
            "REFBUE9BUEFJEg8KB2FyZWFfaWQYCyABKA0SDQoFbGV2ZWwYBiABKA0SIQoL",
            "RUNISURJREVDQ0cYDSADKAsyDC5NS05BR05HQkZPSRITCgtDQUJHT0pGSVBK",
            "SxgHIAEoDRITCgtMQ0FGTk5HSUZOTRgBIAEoDRITCgtBQUZNQUpCQ1BLQhgI",
            "IAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.MKNAGNGBFOIReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.BJDAAPOAPAI), global::EggLink.DanhengServer.Proto.BJDAAPOAPAI.Parser, new[]{ "AreaId", "Level", "ECHIDIDECCG", "CABGOJFIPJK", "LCAFNNGIFNM", "AAFMAJBCPKB" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class BJDAAPOAPAI : pb::IMessage<BJDAAPOAPAI>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BJDAAPOAPAI> _parser = new pb::MessageParser<BJDAAPOAPAI>(() => new BJDAAPOAPAI());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BJDAAPOAPAI> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.BJDAAPOAPAIReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BJDAAPOAPAI() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BJDAAPOAPAI(BJDAAPOAPAI other) : this() {
      areaId_ = other.areaId_;
      level_ = other.level_;
      eCHIDIDECCG_ = other.eCHIDIDECCG_.Clone();
      cABGOJFIPJK_ = other.cABGOJFIPJK_;
      lCAFNNGIFNM_ = other.lCAFNNGIFNM_;
      aAFMAJBCPKB_ = other.aAFMAJBCPKB_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BJDAAPOAPAI Clone() {
      return new BJDAAPOAPAI(this);
    }

    /// <summary>Field number for the "area_id" field.</summary>
    public const int AreaIdFieldNumber = 11;
    private uint areaId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AreaId {
      get { return areaId_; }
      set {
        areaId_ = value;
      }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 6;
    private uint level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "ECHIDIDECCG" field.</summary>
    public const int ECHIDIDECCGFieldNumber = 13;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.MKNAGNGBFOI> _repeated_eCHIDIDECCG_codec
        = pb::FieldCodec.ForMessage(106, global::EggLink.DanhengServer.Proto.MKNAGNGBFOI.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MKNAGNGBFOI> eCHIDIDECCG_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MKNAGNGBFOI>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MKNAGNGBFOI> ECHIDIDECCG {
      get { return eCHIDIDECCG_; }
    }

    /// <summary>Field number for the "CABGOJFIPJK" field.</summary>
    public const int CABGOJFIPJKFieldNumber = 7;
    private uint cABGOJFIPJK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CABGOJFIPJK {
      get { return cABGOJFIPJK_; }
      set {
        cABGOJFIPJK_ = value;
      }
    }

    /// <summary>Field number for the "LCAFNNGIFNM" field.</summary>
    public const int LCAFNNGIFNMFieldNumber = 1;
    private uint lCAFNNGIFNM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LCAFNNGIFNM {
      get { return lCAFNNGIFNM_; }
      set {
        lCAFNNGIFNM_ = value;
      }
    }

    /// <summary>Field number for the "AAFMAJBCPKB" field.</summary>
    public const int AAFMAJBCPKBFieldNumber = 8;
    private uint aAFMAJBCPKB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AAFMAJBCPKB {
      get { return aAFMAJBCPKB_; }
      set {
        aAFMAJBCPKB_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BJDAAPOAPAI);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BJDAAPOAPAI other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AreaId != other.AreaId) return false;
      if (Level != other.Level) return false;
      if(!eCHIDIDECCG_.Equals(other.eCHIDIDECCG_)) return false;
      if (CABGOJFIPJK != other.CABGOJFIPJK) return false;
      if (LCAFNNGIFNM != other.LCAFNNGIFNM) return false;
      if (AAFMAJBCPKB != other.AAFMAJBCPKB) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (AreaId != 0) hash ^= AreaId.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
      hash ^= eCHIDIDECCG_.GetHashCode();
      if (CABGOJFIPJK != 0) hash ^= CABGOJFIPJK.GetHashCode();
      if (LCAFNNGIFNM != 0) hash ^= LCAFNNGIFNM.GetHashCode();
      if (AAFMAJBCPKB != 0) hash ^= AAFMAJBCPKB.GetHashCode();
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
      if (LCAFNNGIFNM != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(LCAFNNGIFNM);
      }
      if (Level != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Level);
      }
      if (CABGOJFIPJK != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(CABGOJFIPJK);
      }
      if (AAFMAJBCPKB != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(AAFMAJBCPKB);
      }
      if (AreaId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(AreaId);
      }
      eCHIDIDECCG_.WriteTo(output, _repeated_eCHIDIDECCG_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (LCAFNNGIFNM != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(LCAFNNGIFNM);
      }
      if (Level != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Level);
      }
      if (CABGOJFIPJK != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(CABGOJFIPJK);
      }
      if (AAFMAJBCPKB != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(AAFMAJBCPKB);
      }
      if (AreaId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(AreaId);
      }
      eCHIDIDECCG_.WriteTo(ref output, _repeated_eCHIDIDECCG_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (AreaId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AreaId);
      }
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Level);
      }
      size += eCHIDIDECCG_.CalculateSize(_repeated_eCHIDIDECCG_codec);
      if (CABGOJFIPJK != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CABGOJFIPJK);
      }
      if (LCAFNNGIFNM != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LCAFNNGIFNM);
      }
      if (AAFMAJBCPKB != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AAFMAJBCPKB);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BJDAAPOAPAI other) {
      if (other == null) {
        return;
      }
      if (other.AreaId != 0) {
        AreaId = other.AreaId;
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
      eCHIDIDECCG_.Add(other.eCHIDIDECCG_);
      if (other.CABGOJFIPJK != 0) {
        CABGOJFIPJK = other.CABGOJFIPJK;
      }
      if (other.LCAFNNGIFNM != 0) {
        LCAFNNGIFNM = other.LCAFNNGIFNM;
      }
      if (other.AAFMAJBCPKB != 0) {
        AAFMAJBCPKB = other.AAFMAJBCPKB;
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
            LCAFNNGIFNM = input.ReadUInt32();
            break;
          }
          case 48: {
            Level = input.ReadUInt32();
            break;
          }
          case 56: {
            CABGOJFIPJK = input.ReadUInt32();
            break;
          }
          case 64: {
            AAFMAJBCPKB = input.ReadUInt32();
            break;
          }
          case 88: {
            AreaId = input.ReadUInt32();
            break;
          }
          case 106: {
            eCHIDIDECCG_.AddEntriesFrom(input, _repeated_eCHIDIDECCG_codec);
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
            LCAFNNGIFNM = input.ReadUInt32();
            break;
          }
          case 48: {
            Level = input.ReadUInt32();
            break;
          }
          case 56: {
            CABGOJFIPJK = input.ReadUInt32();
            break;
          }
          case 64: {
            AAFMAJBCPKB = input.ReadUInt32();
            break;
          }
          case 88: {
            AreaId = input.ReadUInt32();
            break;
          }
          case 106: {
            eCHIDIDECCG_.AddEntriesFrom(ref input, _repeated_eCHIDIDECCG_codec);
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
