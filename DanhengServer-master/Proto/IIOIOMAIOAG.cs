// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: IIOIOMAIOAG.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from IIOIOMAIOAG.proto</summary>
  public static partial class IIOIOMAIOAGReflection {

    #region Descriptor
    /// <summary>File descriptor for IIOIOMAIOAG.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static IIOIOMAIOAGReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFJSU9JT01BSU9BRy5wcm90bxoRRERPTE9BSFBFR08ucHJvdG8aEUNLRkNL",
            "QUNOSEJMLnByb3RvGhFBS0xGTEZPUExGSy5wcm90byLfAQoLSUlPSU9NQUlP",
            "QUcSIQoLSEdNREpITEJJR08YAiADKAsyDC5BS0xGTEZPUExGSxITCgtISUFE",
            "R0lMUE9BTRgMIAEoDRIhCgtFT0JKQ0RGUEVBTxgHIAMoCzIMLkRET0xPQUhQ",
            "RUdPEiEKC0FMQUVCSkpJR1BJGAQgAygLMgwuQ0tGQ0tBQ05IQkwSEwoLRUJO",
            "Rk9FTE1KTUwYBSABKA0SEwoLRU5GTEFJTUdCQU4YCSABKA0SEwoLTUpGS0ZF",
            "SUNBTEEYASABKA0SEwoLQUFJSkFCR05BREEYDyABKA1CHqoCG0VnZ0xpbmsu",
            "RGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.DDOLOAHPEGOReflection.Descriptor, global::EggLink.DanhengServer.Proto.CKFCKACNHBLReflection.Descriptor, global::EggLink.DanhengServer.Proto.AKLFLFOPLFKReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.IIOIOMAIOAG), global::EggLink.DanhengServer.Proto.IIOIOMAIOAG.Parser, new[]{ "HGMDJHLBIGO", "HIADGILPOAM", "EOBJCDFPEAO", "ALAEBJJIGPI", "EBNFOELMJML", "ENFLAIMGBAN", "MJFKFEICALA", "AAIJABGNADA" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class IIOIOMAIOAG : pb::IMessage<IIOIOMAIOAG>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<IIOIOMAIOAG> _parser = new pb::MessageParser<IIOIOMAIOAG>(() => new IIOIOMAIOAG());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<IIOIOMAIOAG> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.IIOIOMAIOAGReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IIOIOMAIOAG() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IIOIOMAIOAG(IIOIOMAIOAG other) : this() {
      hGMDJHLBIGO_ = other.hGMDJHLBIGO_.Clone();
      hIADGILPOAM_ = other.hIADGILPOAM_;
      eOBJCDFPEAO_ = other.eOBJCDFPEAO_.Clone();
      aLAEBJJIGPI_ = other.aLAEBJJIGPI_.Clone();
      eBNFOELMJML_ = other.eBNFOELMJML_;
      eNFLAIMGBAN_ = other.eNFLAIMGBAN_;
      mJFKFEICALA_ = other.mJFKFEICALA_;
      aAIJABGNADA_ = other.aAIJABGNADA_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IIOIOMAIOAG Clone() {
      return new IIOIOMAIOAG(this);
    }

    /// <summary>Field number for the "HGMDJHLBIGO" field.</summary>
    public const int HGMDJHLBIGOFieldNumber = 2;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.AKLFLFOPLFK> _repeated_hGMDJHLBIGO_codec
        = pb::FieldCodec.ForMessage(18, global::EggLink.DanhengServer.Proto.AKLFLFOPLFK.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AKLFLFOPLFK> hGMDJHLBIGO_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AKLFLFOPLFK>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AKLFLFOPLFK> HGMDJHLBIGO {
      get { return hGMDJHLBIGO_; }
    }

    /// <summary>Field number for the "HIADGILPOAM" field.</summary>
    public const int HIADGILPOAMFieldNumber = 12;
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
    public const int EOBJCDFPEAOFieldNumber = 7;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.DDOLOAHPEGO> _repeated_eOBJCDFPEAO_codec
        = pb::FieldCodec.ForMessage(58, global::EggLink.DanhengServer.Proto.DDOLOAHPEGO.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.DDOLOAHPEGO> eOBJCDFPEAO_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.DDOLOAHPEGO>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.DDOLOAHPEGO> EOBJCDFPEAO {
      get { return eOBJCDFPEAO_; }
    }

    /// <summary>Field number for the "ALAEBJJIGPI" field.</summary>
    public const int ALAEBJJIGPIFieldNumber = 4;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.CKFCKACNHBL> _repeated_aLAEBJJIGPI_codec
        = pb::FieldCodec.ForMessage(34, global::EggLink.DanhengServer.Proto.CKFCKACNHBL.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.CKFCKACNHBL> aLAEBJJIGPI_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.CKFCKACNHBL>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.CKFCKACNHBL> ALAEBJJIGPI {
      get { return aLAEBJJIGPI_; }
    }

    /// <summary>Field number for the "EBNFOELMJML" field.</summary>
    public const int EBNFOELMJMLFieldNumber = 5;
    private uint eBNFOELMJML_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EBNFOELMJML {
      get { return eBNFOELMJML_; }
      set {
        eBNFOELMJML_ = value;
      }
    }

    /// <summary>Field number for the "ENFLAIMGBAN" field.</summary>
    public const int ENFLAIMGBANFieldNumber = 9;
    private uint eNFLAIMGBAN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ENFLAIMGBAN {
      get { return eNFLAIMGBAN_; }
      set {
        eNFLAIMGBAN_ = value;
      }
    }

    /// <summary>Field number for the "MJFKFEICALA" field.</summary>
    public const int MJFKFEICALAFieldNumber = 1;
    private uint mJFKFEICALA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MJFKFEICALA {
      get { return mJFKFEICALA_; }
      set {
        mJFKFEICALA_ = value;
      }
    }

    /// <summary>Field number for the "AAIJABGNADA" field.</summary>
    public const int AAIJABGNADAFieldNumber = 15;
    private uint aAIJABGNADA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AAIJABGNADA {
      get { return aAIJABGNADA_; }
      set {
        aAIJABGNADA_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as IIOIOMAIOAG);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(IIOIOMAIOAG other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!hGMDJHLBIGO_.Equals(other.hGMDJHLBIGO_)) return false;
      if (HIADGILPOAM != other.HIADGILPOAM) return false;
      if(!eOBJCDFPEAO_.Equals(other.eOBJCDFPEAO_)) return false;
      if(!aLAEBJJIGPI_.Equals(other.aLAEBJJIGPI_)) return false;
      if (EBNFOELMJML != other.EBNFOELMJML) return false;
      if (ENFLAIMGBAN != other.ENFLAIMGBAN) return false;
      if (MJFKFEICALA != other.MJFKFEICALA) return false;
      if (AAIJABGNADA != other.AAIJABGNADA) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= hGMDJHLBIGO_.GetHashCode();
      if (HIADGILPOAM != 0) hash ^= HIADGILPOAM.GetHashCode();
      hash ^= eOBJCDFPEAO_.GetHashCode();
      hash ^= aLAEBJJIGPI_.GetHashCode();
      if (EBNFOELMJML != 0) hash ^= EBNFOELMJML.GetHashCode();
      if (ENFLAIMGBAN != 0) hash ^= ENFLAIMGBAN.GetHashCode();
      if (MJFKFEICALA != 0) hash ^= MJFKFEICALA.GetHashCode();
      if (AAIJABGNADA != 0) hash ^= AAIJABGNADA.GetHashCode();
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
      if (MJFKFEICALA != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(MJFKFEICALA);
      }
      hGMDJHLBIGO_.WriteTo(output, _repeated_hGMDJHLBIGO_codec);
      aLAEBJJIGPI_.WriteTo(output, _repeated_aLAEBJJIGPI_codec);
      if (EBNFOELMJML != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(EBNFOELMJML);
      }
      eOBJCDFPEAO_.WriteTo(output, _repeated_eOBJCDFPEAO_codec);
      if (ENFLAIMGBAN != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(ENFLAIMGBAN);
      }
      if (HIADGILPOAM != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(HIADGILPOAM);
      }
      if (AAIJABGNADA != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(AAIJABGNADA);
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
      if (MJFKFEICALA != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(MJFKFEICALA);
      }
      hGMDJHLBIGO_.WriteTo(ref output, _repeated_hGMDJHLBIGO_codec);
      aLAEBJJIGPI_.WriteTo(ref output, _repeated_aLAEBJJIGPI_codec);
      if (EBNFOELMJML != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(EBNFOELMJML);
      }
      eOBJCDFPEAO_.WriteTo(ref output, _repeated_eOBJCDFPEAO_codec);
      if (ENFLAIMGBAN != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(ENFLAIMGBAN);
      }
      if (HIADGILPOAM != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(HIADGILPOAM);
      }
      if (AAIJABGNADA != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(AAIJABGNADA);
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
      size += hGMDJHLBIGO_.CalculateSize(_repeated_hGMDJHLBIGO_codec);
      if (HIADGILPOAM != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HIADGILPOAM);
      }
      size += eOBJCDFPEAO_.CalculateSize(_repeated_eOBJCDFPEAO_codec);
      size += aLAEBJJIGPI_.CalculateSize(_repeated_aLAEBJJIGPI_codec);
      if (EBNFOELMJML != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EBNFOELMJML);
      }
      if (ENFLAIMGBAN != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ENFLAIMGBAN);
      }
      if (MJFKFEICALA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MJFKFEICALA);
      }
      if (AAIJABGNADA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AAIJABGNADA);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(IIOIOMAIOAG other) {
      if (other == null) {
        return;
      }
      hGMDJHLBIGO_.Add(other.hGMDJHLBIGO_);
      if (other.HIADGILPOAM != 0) {
        HIADGILPOAM = other.HIADGILPOAM;
      }
      eOBJCDFPEAO_.Add(other.eOBJCDFPEAO_);
      aLAEBJJIGPI_.Add(other.aLAEBJJIGPI_);
      if (other.EBNFOELMJML != 0) {
        EBNFOELMJML = other.EBNFOELMJML;
      }
      if (other.ENFLAIMGBAN != 0) {
        ENFLAIMGBAN = other.ENFLAIMGBAN;
      }
      if (other.MJFKFEICALA != 0) {
        MJFKFEICALA = other.MJFKFEICALA;
      }
      if (other.AAIJABGNADA != 0) {
        AAIJABGNADA = other.AAIJABGNADA;
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
            MJFKFEICALA = input.ReadUInt32();
            break;
          }
          case 18: {
            hGMDJHLBIGO_.AddEntriesFrom(input, _repeated_hGMDJHLBIGO_codec);
            break;
          }
          case 34: {
            aLAEBJJIGPI_.AddEntriesFrom(input, _repeated_aLAEBJJIGPI_codec);
            break;
          }
          case 40: {
            EBNFOELMJML = input.ReadUInt32();
            break;
          }
          case 58: {
            eOBJCDFPEAO_.AddEntriesFrom(input, _repeated_eOBJCDFPEAO_codec);
            break;
          }
          case 72: {
            ENFLAIMGBAN = input.ReadUInt32();
            break;
          }
          case 96: {
            HIADGILPOAM = input.ReadUInt32();
            break;
          }
          case 120: {
            AAIJABGNADA = input.ReadUInt32();
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
            MJFKFEICALA = input.ReadUInt32();
            break;
          }
          case 18: {
            hGMDJHLBIGO_.AddEntriesFrom(ref input, _repeated_hGMDJHLBIGO_codec);
            break;
          }
          case 34: {
            aLAEBJJIGPI_.AddEntriesFrom(ref input, _repeated_aLAEBJJIGPI_codec);
            break;
          }
          case 40: {
            EBNFOELMJML = input.ReadUInt32();
            break;
          }
          case 58: {
            eOBJCDFPEAO_.AddEntriesFrom(ref input, _repeated_eOBJCDFPEAO_codec);
            break;
          }
          case 72: {
            ENFLAIMGBAN = input.ReadUInt32();
            break;
          }
          case 96: {
            HIADGILPOAM = input.ReadUInt32();
            break;
          }
          case 120: {
            AAIJABGNADA = input.ReadUInt32();
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
