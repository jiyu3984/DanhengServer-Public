// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: NGBCAJHPIGK.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from NGBCAJHPIGK.proto</summary>
  public static partial class NGBCAJHPIGKReflection {

    #region Descriptor
    /// <summary>File descriptor for NGBCAJHPIGK.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static NGBCAJHPIGKReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFOR0JDQUpIUElHSy5wcm90bxoRRERPTE9BSFBFR08ucHJvdG8aEUFLTEZM",
            "Rk9QTEZLLnByb3RvGhRQbGF5U2tpbGxCcmllZi5wcm90byKOAQoLTkdCQ0FK",
            "SFBJR0sSIQoLSEdNREpITEJJR08YCyADKAsyDC5BS0xGTEZPUExGSxITCgtI",
            "SUFER0lMUE9BTRgBIAEoDRIhCgtFT0JKQ0RGUEVBTxgKIAMoCzIMLkRET0xP",
            "QUhQRUdPEiQKC0tMRUlNS01BT01EGAwgAygLMg8uUGxheVNraWxsQnJpZWZC",
            "HqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.DDOLOAHPEGOReflection.Descriptor, global::EggLink.DanhengServer.Proto.AKLFLFOPLFKReflection.Descriptor, global::EggLink.DanhengServer.Proto.PlaySkillBriefReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.NGBCAJHPIGK), global::EggLink.DanhengServer.Proto.NGBCAJHPIGK.Parser, new[]{ "HGMDJHLBIGO", "HIADGILPOAM", "EOBJCDFPEAO", "KLEIMKMAOMD" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class NGBCAJHPIGK : pb::IMessage<NGBCAJHPIGK>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<NGBCAJHPIGK> _parser = new pb::MessageParser<NGBCAJHPIGK>(() => new NGBCAJHPIGK());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<NGBCAJHPIGK> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.NGBCAJHPIGKReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NGBCAJHPIGK() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NGBCAJHPIGK(NGBCAJHPIGK other) : this() {
      hGMDJHLBIGO_ = other.hGMDJHLBIGO_.Clone();
      hIADGILPOAM_ = other.hIADGILPOAM_;
      eOBJCDFPEAO_ = other.eOBJCDFPEAO_.Clone();
      kLEIMKMAOMD_ = other.kLEIMKMAOMD_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NGBCAJHPIGK Clone() {
      return new NGBCAJHPIGK(this);
    }

    /// <summary>Field number for the "HGMDJHLBIGO" field.</summary>
    public const int HGMDJHLBIGOFieldNumber = 11;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.AKLFLFOPLFK> _repeated_hGMDJHLBIGO_codec
        = pb::FieldCodec.ForMessage(90, global::EggLink.DanhengServer.Proto.AKLFLFOPLFK.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AKLFLFOPLFK> hGMDJHLBIGO_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AKLFLFOPLFK>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AKLFLFOPLFK> HGMDJHLBIGO {
      get { return hGMDJHLBIGO_; }
    }

    /// <summary>Field number for the "HIADGILPOAM" field.</summary>
    public const int HIADGILPOAMFieldNumber = 1;
    private uint hIADGILPOAM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HIADGILPOAM {
      get { return hIADGILPOAM_; }
      set {
        hIADGILPOAM_ = value;
      }
    }

    /// <summary>Field number for the "EOBJCDFPEAO" field.</summary>
    public const int EOBJCDFPEAOFieldNumber = 10;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.DDOLOAHPEGO> _repeated_eOBJCDFPEAO_codec
        = pb::FieldCodec.ForMessage(82, global::EggLink.DanhengServer.Proto.DDOLOAHPEGO.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.DDOLOAHPEGO> eOBJCDFPEAO_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.DDOLOAHPEGO>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.DDOLOAHPEGO> EOBJCDFPEAO {
      get { return eOBJCDFPEAO_; }
    }

    /// <summary>Field number for the "KLEIMKMAOMD" field.</summary>
    public const int KLEIMKMAOMDFieldNumber = 12;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.PlaySkillBrief> _repeated_kLEIMKMAOMD_codec
        = pb::FieldCodec.ForMessage(98, global::EggLink.DanhengServer.Proto.PlaySkillBrief.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.PlaySkillBrief> kLEIMKMAOMD_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.PlaySkillBrief>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.PlaySkillBrief> KLEIMKMAOMD {
      get { return kLEIMKMAOMD_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as NGBCAJHPIGK);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(NGBCAJHPIGK other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!hGMDJHLBIGO_.Equals(other.hGMDJHLBIGO_)) return false;
      if (HIADGILPOAM != other.HIADGILPOAM) return false;
      if(!eOBJCDFPEAO_.Equals(other.eOBJCDFPEAO_)) return false;
      if(!kLEIMKMAOMD_.Equals(other.kLEIMKMAOMD_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= hGMDJHLBIGO_.GetHashCode();
      if (HIADGILPOAM != 0) hash ^= HIADGILPOAM.GetHashCode();
      hash ^= eOBJCDFPEAO_.GetHashCode();
      hash ^= kLEIMKMAOMD_.GetHashCode();
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
      if (HIADGILPOAM != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(HIADGILPOAM);
      }
      eOBJCDFPEAO_.WriteTo(output, _repeated_eOBJCDFPEAO_codec);
      hGMDJHLBIGO_.WriteTo(output, _repeated_hGMDJHLBIGO_codec);
      kLEIMKMAOMD_.WriteTo(output, _repeated_kLEIMKMAOMD_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (HIADGILPOAM != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(HIADGILPOAM);
      }
      eOBJCDFPEAO_.WriteTo(ref output, _repeated_eOBJCDFPEAO_codec);
      hGMDJHLBIGO_.WriteTo(ref output, _repeated_hGMDJHLBIGO_codec);
      kLEIMKMAOMD_.WriteTo(ref output, _repeated_kLEIMKMAOMD_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += hGMDJHLBIGO_.CalculateSize(_repeated_hGMDJHLBIGO_codec);
      if (HIADGILPOAM != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HIADGILPOAM);
      }
      size += eOBJCDFPEAO_.CalculateSize(_repeated_eOBJCDFPEAO_codec);
      size += kLEIMKMAOMD_.CalculateSize(_repeated_kLEIMKMAOMD_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(NGBCAJHPIGK other) {
      if (other == null) {
        return;
      }
      hGMDJHLBIGO_.Add(other.hGMDJHLBIGO_);
      if (other.HIADGILPOAM != 0) {
        HIADGILPOAM = other.HIADGILPOAM;
      }
      eOBJCDFPEAO_.Add(other.eOBJCDFPEAO_);
      kLEIMKMAOMD_.Add(other.kLEIMKMAOMD_);
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
            HIADGILPOAM = input.ReadUInt32();
            break;
          }
          case 82: {
            eOBJCDFPEAO_.AddEntriesFrom(input, _repeated_eOBJCDFPEAO_codec);
            break;
          }
          case 90: {
            hGMDJHLBIGO_.AddEntriesFrom(input, _repeated_hGMDJHLBIGO_codec);
            break;
          }
          case 98: {
            kLEIMKMAOMD_.AddEntriesFrom(input, _repeated_kLEIMKMAOMD_codec);
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
            HIADGILPOAM = input.ReadUInt32();
            break;
          }
          case 82: {
            eOBJCDFPEAO_.AddEntriesFrom(ref input, _repeated_eOBJCDFPEAO_codec);
            break;
          }
          case 90: {
            hGMDJHLBIGO_.AddEntriesFrom(ref input, _repeated_hGMDJHLBIGO_codec);
            break;
          }
          case 98: {
            kLEIMKMAOMD_.AddEntriesFrom(ref input, _repeated_kLEIMKMAOMD_codec);
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
