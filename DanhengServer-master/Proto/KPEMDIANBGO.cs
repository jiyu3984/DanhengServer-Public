// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: KPEMDIANBGO.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from KPEMDIANBGO.proto</summary>
  public static partial class KPEMDIANBGOReflection {

    #region Descriptor
    /// <summary>File descriptor for KPEMDIANBGO.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static KPEMDIANBGOReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFLUEVNRElBTkJHTy5wcm90bxoRSUNORURPQ1BCUFAucHJvdG8imQEKC0tQ",
            "RU1ESUFOQkdPEhMKC0VLRFBPSUdPTkNEGAIgASgNEhMKC0JKQkZPQUtJR0dI",
            "GAcgAygNEhMKC1BBQklIRkdOUEtHGAQgASgNEhMKC0hBT0RGRU1BUE1MGAkg",
            "ASgNEiEKC0lLSE9CTkxERUNKGAYgAygLMgwuSUNORURPQ1BCUFASEwoLRE9M",
            "TkZHTVBPR0MYCiABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90",
            "b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ICNEDOCPBPPReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.KPEMDIANBGO), global::EggLink.DanhengServer.Proto.KPEMDIANBGO.Parser, new[]{ "EKDPOIGONCD", "BJBFOAKIGGH", "PABIHFGNPKG", "HAODFEMAPML", "IKHOBNLDECJ", "DOLNFGMPOGC" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class KPEMDIANBGO : pb::IMessage<KPEMDIANBGO>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<KPEMDIANBGO> _parser = new pb::MessageParser<KPEMDIANBGO>(() => new KPEMDIANBGO());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<KPEMDIANBGO> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.KPEMDIANBGOReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KPEMDIANBGO() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KPEMDIANBGO(KPEMDIANBGO other) : this() {
      eKDPOIGONCD_ = other.eKDPOIGONCD_;
      bJBFOAKIGGH_ = other.bJBFOAKIGGH_.Clone();
      pABIHFGNPKG_ = other.pABIHFGNPKG_;
      hAODFEMAPML_ = other.hAODFEMAPML_;
      iKHOBNLDECJ_ = other.iKHOBNLDECJ_.Clone();
      dOLNFGMPOGC_ = other.dOLNFGMPOGC_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KPEMDIANBGO Clone() {
      return new KPEMDIANBGO(this);
    }

    /// <summary>Field number for the "EKDPOIGONCD" field.</summary>
    public const int EKDPOIGONCDFieldNumber = 2;
    private uint eKDPOIGONCD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EKDPOIGONCD {
      get { return eKDPOIGONCD_; }
      set {
        eKDPOIGONCD_ = value;
      }
    }

    /// <summary>Field number for the "BJBFOAKIGGH" field.</summary>
    public const int BJBFOAKIGGHFieldNumber = 7;
    private static readonly pb::FieldCodec<uint> _repeated_bJBFOAKIGGH_codec
        = pb::FieldCodec.ForUInt32(58);
    private readonly pbc::RepeatedField<uint> bJBFOAKIGGH_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> BJBFOAKIGGH {
      get { return bJBFOAKIGGH_; }
    }

    /// <summary>Field number for the "PABIHFGNPKG" field.</summary>
    public const int PABIHFGNPKGFieldNumber = 4;
    private uint pABIHFGNPKG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PABIHFGNPKG {
      get { return pABIHFGNPKG_; }
      set {
        pABIHFGNPKG_ = value;
      }
    }

    /// <summary>Field number for the "HAODFEMAPML" field.</summary>
    public const int HAODFEMAPMLFieldNumber = 9;
    private uint hAODFEMAPML_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HAODFEMAPML {
      get { return hAODFEMAPML_; }
      set {
        hAODFEMAPML_ = value;
      }
    }

    /// <summary>Field number for the "IKHOBNLDECJ" field.</summary>
    public const int IKHOBNLDECJFieldNumber = 6;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.ICNEDOCPBPP> _repeated_iKHOBNLDECJ_codec
        = pb::FieldCodec.ForMessage(50, global::EggLink.DanhengServer.Proto.ICNEDOCPBPP.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ICNEDOCPBPP> iKHOBNLDECJ_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ICNEDOCPBPP>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ICNEDOCPBPP> IKHOBNLDECJ {
      get { return iKHOBNLDECJ_; }
    }

    /// <summary>Field number for the "DOLNFGMPOGC" field.</summary>
    public const int DOLNFGMPOGCFieldNumber = 10;
    private uint dOLNFGMPOGC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DOLNFGMPOGC {
      get { return dOLNFGMPOGC_; }
      set {
        dOLNFGMPOGC_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as KPEMDIANBGO);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(KPEMDIANBGO other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EKDPOIGONCD != other.EKDPOIGONCD) return false;
      if(!bJBFOAKIGGH_.Equals(other.bJBFOAKIGGH_)) return false;
      if (PABIHFGNPKG != other.PABIHFGNPKG) return false;
      if (HAODFEMAPML != other.HAODFEMAPML) return false;
      if(!iKHOBNLDECJ_.Equals(other.iKHOBNLDECJ_)) return false;
      if (DOLNFGMPOGC != other.DOLNFGMPOGC) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EKDPOIGONCD != 0) hash ^= EKDPOIGONCD.GetHashCode();
      hash ^= bJBFOAKIGGH_.GetHashCode();
      if (PABIHFGNPKG != 0) hash ^= PABIHFGNPKG.GetHashCode();
      if (HAODFEMAPML != 0) hash ^= HAODFEMAPML.GetHashCode();
      hash ^= iKHOBNLDECJ_.GetHashCode();
      if (DOLNFGMPOGC != 0) hash ^= DOLNFGMPOGC.GetHashCode();
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
      if (EKDPOIGONCD != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(EKDPOIGONCD);
      }
      if (PABIHFGNPKG != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(PABIHFGNPKG);
      }
      iKHOBNLDECJ_.WriteTo(output, _repeated_iKHOBNLDECJ_codec);
      bJBFOAKIGGH_.WriteTo(output, _repeated_bJBFOAKIGGH_codec);
      if (HAODFEMAPML != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(HAODFEMAPML);
      }
      if (DOLNFGMPOGC != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(DOLNFGMPOGC);
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
      if (EKDPOIGONCD != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(EKDPOIGONCD);
      }
      if (PABIHFGNPKG != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(PABIHFGNPKG);
      }
      iKHOBNLDECJ_.WriteTo(ref output, _repeated_iKHOBNLDECJ_codec);
      bJBFOAKIGGH_.WriteTo(ref output, _repeated_bJBFOAKIGGH_codec);
      if (HAODFEMAPML != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(HAODFEMAPML);
      }
      if (DOLNFGMPOGC != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(DOLNFGMPOGC);
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
      if (EKDPOIGONCD != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EKDPOIGONCD);
      }
      size += bJBFOAKIGGH_.CalculateSize(_repeated_bJBFOAKIGGH_codec);
      if (PABIHFGNPKG != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PABIHFGNPKG);
      }
      if (HAODFEMAPML != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HAODFEMAPML);
      }
      size += iKHOBNLDECJ_.CalculateSize(_repeated_iKHOBNLDECJ_codec);
      if (DOLNFGMPOGC != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DOLNFGMPOGC);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(KPEMDIANBGO other) {
      if (other == null) {
        return;
      }
      if (other.EKDPOIGONCD != 0) {
        EKDPOIGONCD = other.EKDPOIGONCD;
      }
      bJBFOAKIGGH_.Add(other.bJBFOAKIGGH_);
      if (other.PABIHFGNPKG != 0) {
        PABIHFGNPKG = other.PABIHFGNPKG;
      }
      if (other.HAODFEMAPML != 0) {
        HAODFEMAPML = other.HAODFEMAPML;
      }
      iKHOBNLDECJ_.Add(other.iKHOBNLDECJ_);
      if (other.DOLNFGMPOGC != 0) {
        DOLNFGMPOGC = other.DOLNFGMPOGC;
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
          case 16: {
            EKDPOIGONCD = input.ReadUInt32();
            break;
          }
          case 32: {
            PABIHFGNPKG = input.ReadUInt32();
            break;
          }
          case 50: {
            iKHOBNLDECJ_.AddEntriesFrom(input, _repeated_iKHOBNLDECJ_codec);
            break;
          }
          case 58:
          case 56: {
            bJBFOAKIGGH_.AddEntriesFrom(input, _repeated_bJBFOAKIGGH_codec);
            break;
          }
          case 72: {
            HAODFEMAPML = input.ReadUInt32();
            break;
          }
          case 80: {
            DOLNFGMPOGC = input.ReadUInt32();
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
          case 16: {
            EKDPOIGONCD = input.ReadUInt32();
            break;
          }
          case 32: {
            PABIHFGNPKG = input.ReadUInt32();
            break;
          }
          case 50: {
            iKHOBNLDECJ_.AddEntriesFrom(ref input, _repeated_iKHOBNLDECJ_codec);
            break;
          }
          case 58:
          case 56: {
            bJBFOAKIGGH_.AddEntriesFrom(ref input, _repeated_bJBFOAKIGGH_codec);
            break;
          }
          case 72: {
            HAODFEMAPML = input.ReadUInt32();
            break;
          }
          case 80: {
            DOLNFGMPOGC = input.ReadUInt32();
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