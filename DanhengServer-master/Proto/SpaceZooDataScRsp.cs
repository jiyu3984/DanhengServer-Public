// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SpaceZooDataScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SpaceZooDataScRsp.proto</summary>
  public static partial class SpaceZooDataScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for SpaceZooDataScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SpaceZooDataScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdTcGFjZVpvb0RhdGFTY1JzcC5wcm90bxoRS0pFUExGUEFMQ0IucHJvdG8a",
            "EURHRFBPQ05GTkJNLnByb3RvIugBChFTcGFjZVpvb0RhdGFTY1JzcBITCgtC",
            "UExIREZKTVBPQRgHIAMoDRITCgtQS0hBR0hKT05FRhgJIAMoDRIhCgtNTkNK",
            "UEpMUENIQRgCIAMoCzIMLkRHRFBPQ05GTkJNEhMKC0xLRExEUEJOTkNNGA4g",
            "AygNEhMKC05KRktQT1BBTEVIGAEgASgNEiEKC05OTUxQR01DQ01KGAggAygL",
            "MgwuS0pFUExGUEFMQ0ISDwoHcmV0Y29kZRgEIAEoDRITCgtCQ0FKQkJNQkZL",
            "ThgFIAMoDRITCgtHRURIQUFQRUJORxgMIAMoDUIeqgIbRWdnTGluay5EYW5o",
            "ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.KJEPLFPALCBReflection.Descriptor, global::EggLink.DanhengServer.Proto.DGDPOCNFNBMReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SpaceZooDataScRsp), global::EggLink.DanhengServer.Proto.SpaceZooDataScRsp.Parser, new[]{ "BPLHDFJMPOA", "PKHAGHJONEF", "MNCJPJLPCHA", "LKDLDPBNNCM", "NJFKPOPALEH", "NNMLPGMCCMJ", "Retcode", "BCAJBBMBFKN", "GEDHAAPEBNG" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SpaceZooDataScRsp : pb::IMessage<SpaceZooDataScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SpaceZooDataScRsp> _parser = new pb::MessageParser<SpaceZooDataScRsp>(() => new SpaceZooDataScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SpaceZooDataScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.SpaceZooDataScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SpaceZooDataScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SpaceZooDataScRsp(SpaceZooDataScRsp other) : this() {
      bPLHDFJMPOA_ = other.bPLHDFJMPOA_.Clone();
      pKHAGHJONEF_ = other.pKHAGHJONEF_.Clone();
      mNCJPJLPCHA_ = other.mNCJPJLPCHA_.Clone();
      lKDLDPBNNCM_ = other.lKDLDPBNNCM_.Clone();
      nJFKPOPALEH_ = other.nJFKPOPALEH_;
      nNMLPGMCCMJ_ = other.nNMLPGMCCMJ_.Clone();
      retcode_ = other.retcode_;
      bCAJBBMBFKN_ = other.bCAJBBMBFKN_.Clone();
      gEDHAAPEBNG_ = other.gEDHAAPEBNG_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SpaceZooDataScRsp Clone() {
      return new SpaceZooDataScRsp(this);
    }

    /// <summary>Field number for the "BPLHDFJMPOA" field.</summary>
    public const int BPLHDFJMPOAFieldNumber = 7;
    private static readonly pb::FieldCodec<uint> _repeated_bPLHDFJMPOA_codec
        = pb::FieldCodec.ForUInt32(58);
    private readonly pbc::RepeatedField<uint> bPLHDFJMPOA_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> BPLHDFJMPOA {
      get { return bPLHDFJMPOA_; }
    }

    /// <summary>Field number for the "PKHAGHJONEF" field.</summary>
    public const int PKHAGHJONEFFieldNumber = 9;
    private static readonly pb::FieldCodec<uint> _repeated_pKHAGHJONEF_codec
        = pb::FieldCodec.ForUInt32(74);
    private readonly pbc::RepeatedField<uint> pKHAGHJONEF_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> PKHAGHJONEF {
      get { return pKHAGHJONEF_; }
    }

    /// <summary>Field number for the "MNCJPJLPCHA" field.</summary>
    public const int MNCJPJLPCHAFieldNumber = 2;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.DGDPOCNFNBM> _repeated_mNCJPJLPCHA_codec
        = pb::FieldCodec.ForMessage(18, global::EggLink.DanhengServer.Proto.DGDPOCNFNBM.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.DGDPOCNFNBM> mNCJPJLPCHA_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.DGDPOCNFNBM>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.DGDPOCNFNBM> MNCJPJLPCHA {
      get { return mNCJPJLPCHA_; }
    }

    /// <summary>Field number for the "LKDLDPBNNCM" field.</summary>
    public const int LKDLDPBNNCMFieldNumber = 14;
    private static readonly pb::FieldCodec<uint> _repeated_lKDLDPBNNCM_codec
        = pb::FieldCodec.ForUInt32(114);
    private readonly pbc::RepeatedField<uint> lKDLDPBNNCM_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> LKDLDPBNNCM {
      get { return lKDLDPBNNCM_; }
    }

    /// <summary>Field number for the "NJFKPOPALEH" field.</summary>
    public const int NJFKPOPALEHFieldNumber = 1;
    private uint nJFKPOPALEH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NJFKPOPALEH {
      get { return nJFKPOPALEH_; }
      set {
        nJFKPOPALEH_ = value;
      }
    }

    /// <summary>Field number for the "NNMLPGMCCMJ" field.</summary>
    public const int NNMLPGMCCMJFieldNumber = 8;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.KJEPLFPALCB> _repeated_nNMLPGMCCMJ_codec
        = pb::FieldCodec.ForMessage(66, global::EggLink.DanhengServer.Proto.KJEPLFPALCB.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.KJEPLFPALCB> nNMLPGMCCMJ_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.KJEPLFPALCB>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.KJEPLFPALCB> NNMLPGMCCMJ {
      get { return nNMLPGMCCMJ_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 4;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "BCAJBBMBFKN" field.</summary>
    public const int BCAJBBMBFKNFieldNumber = 5;
    private static readonly pb::FieldCodec<uint> _repeated_bCAJBBMBFKN_codec
        = pb::FieldCodec.ForUInt32(42);
    private readonly pbc::RepeatedField<uint> bCAJBBMBFKN_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> BCAJBBMBFKN {
      get { return bCAJBBMBFKN_; }
    }

    /// <summary>Field number for the "GEDHAAPEBNG" field.</summary>
    public const int GEDHAAPEBNGFieldNumber = 12;
    private static readonly pb::FieldCodec<uint> _repeated_gEDHAAPEBNG_codec
        = pb::FieldCodec.ForUInt32(98);
    private readonly pbc::RepeatedField<uint> gEDHAAPEBNG_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> GEDHAAPEBNG {
      get { return gEDHAAPEBNG_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SpaceZooDataScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SpaceZooDataScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!bPLHDFJMPOA_.Equals(other.bPLHDFJMPOA_)) return false;
      if(!pKHAGHJONEF_.Equals(other.pKHAGHJONEF_)) return false;
      if(!mNCJPJLPCHA_.Equals(other.mNCJPJLPCHA_)) return false;
      if(!lKDLDPBNNCM_.Equals(other.lKDLDPBNNCM_)) return false;
      if (NJFKPOPALEH != other.NJFKPOPALEH) return false;
      if(!nNMLPGMCCMJ_.Equals(other.nNMLPGMCCMJ_)) return false;
      if (Retcode != other.Retcode) return false;
      if(!bCAJBBMBFKN_.Equals(other.bCAJBBMBFKN_)) return false;
      if(!gEDHAAPEBNG_.Equals(other.gEDHAAPEBNG_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= bPLHDFJMPOA_.GetHashCode();
      hash ^= pKHAGHJONEF_.GetHashCode();
      hash ^= mNCJPJLPCHA_.GetHashCode();
      hash ^= lKDLDPBNNCM_.GetHashCode();
      if (NJFKPOPALEH != 0) hash ^= NJFKPOPALEH.GetHashCode();
      hash ^= nNMLPGMCCMJ_.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      hash ^= bCAJBBMBFKN_.GetHashCode();
      hash ^= gEDHAAPEBNG_.GetHashCode();
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
      if (NJFKPOPALEH != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(NJFKPOPALEH);
      }
      mNCJPJLPCHA_.WriteTo(output, _repeated_mNCJPJLPCHA_codec);
      if (Retcode != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Retcode);
      }
      bCAJBBMBFKN_.WriteTo(output, _repeated_bCAJBBMBFKN_codec);
      bPLHDFJMPOA_.WriteTo(output, _repeated_bPLHDFJMPOA_codec);
      nNMLPGMCCMJ_.WriteTo(output, _repeated_nNMLPGMCCMJ_codec);
      pKHAGHJONEF_.WriteTo(output, _repeated_pKHAGHJONEF_codec);
      gEDHAAPEBNG_.WriteTo(output, _repeated_gEDHAAPEBNG_codec);
      lKDLDPBNNCM_.WriteTo(output, _repeated_lKDLDPBNNCM_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (NJFKPOPALEH != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(NJFKPOPALEH);
      }
      mNCJPJLPCHA_.WriteTo(ref output, _repeated_mNCJPJLPCHA_codec);
      if (Retcode != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Retcode);
      }
      bCAJBBMBFKN_.WriteTo(ref output, _repeated_bCAJBBMBFKN_codec);
      bPLHDFJMPOA_.WriteTo(ref output, _repeated_bPLHDFJMPOA_codec);
      nNMLPGMCCMJ_.WriteTo(ref output, _repeated_nNMLPGMCCMJ_codec);
      pKHAGHJONEF_.WriteTo(ref output, _repeated_pKHAGHJONEF_codec);
      gEDHAAPEBNG_.WriteTo(ref output, _repeated_gEDHAAPEBNG_codec);
      lKDLDPBNNCM_.WriteTo(ref output, _repeated_lKDLDPBNNCM_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += bPLHDFJMPOA_.CalculateSize(_repeated_bPLHDFJMPOA_codec);
      size += pKHAGHJONEF_.CalculateSize(_repeated_pKHAGHJONEF_codec);
      size += mNCJPJLPCHA_.CalculateSize(_repeated_mNCJPJLPCHA_codec);
      size += lKDLDPBNNCM_.CalculateSize(_repeated_lKDLDPBNNCM_codec);
      if (NJFKPOPALEH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NJFKPOPALEH);
      }
      size += nNMLPGMCCMJ_.CalculateSize(_repeated_nNMLPGMCCMJ_codec);
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      size += bCAJBBMBFKN_.CalculateSize(_repeated_bCAJBBMBFKN_codec);
      size += gEDHAAPEBNG_.CalculateSize(_repeated_gEDHAAPEBNG_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SpaceZooDataScRsp other) {
      if (other == null) {
        return;
      }
      bPLHDFJMPOA_.Add(other.bPLHDFJMPOA_);
      pKHAGHJONEF_.Add(other.pKHAGHJONEF_);
      mNCJPJLPCHA_.Add(other.mNCJPJLPCHA_);
      lKDLDPBNNCM_.Add(other.lKDLDPBNNCM_);
      if (other.NJFKPOPALEH != 0) {
        NJFKPOPALEH = other.NJFKPOPALEH;
      }
      nNMLPGMCCMJ_.Add(other.nNMLPGMCCMJ_);
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      bCAJBBMBFKN_.Add(other.bCAJBBMBFKN_);
      gEDHAAPEBNG_.Add(other.gEDHAAPEBNG_);
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
            NJFKPOPALEH = input.ReadUInt32();
            break;
          }
          case 18: {
            mNCJPJLPCHA_.AddEntriesFrom(input, _repeated_mNCJPJLPCHA_codec);
            break;
          }
          case 32: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 42:
          case 40: {
            bCAJBBMBFKN_.AddEntriesFrom(input, _repeated_bCAJBBMBFKN_codec);
            break;
          }
          case 58:
          case 56: {
            bPLHDFJMPOA_.AddEntriesFrom(input, _repeated_bPLHDFJMPOA_codec);
            break;
          }
          case 66: {
            nNMLPGMCCMJ_.AddEntriesFrom(input, _repeated_nNMLPGMCCMJ_codec);
            break;
          }
          case 74:
          case 72: {
            pKHAGHJONEF_.AddEntriesFrom(input, _repeated_pKHAGHJONEF_codec);
            break;
          }
          case 98:
          case 96: {
            gEDHAAPEBNG_.AddEntriesFrom(input, _repeated_gEDHAAPEBNG_codec);
            break;
          }
          case 114:
          case 112: {
            lKDLDPBNNCM_.AddEntriesFrom(input, _repeated_lKDLDPBNNCM_codec);
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
            NJFKPOPALEH = input.ReadUInt32();
            break;
          }
          case 18: {
            mNCJPJLPCHA_.AddEntriesFrom(ref input, _repeated_mNCJPJLPCHA_codec);
            break;
          }
          case 32: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 42:
          case 40: {
            bCAJBBMBFKN_.AddEntriesFrom(ref input, _repeated_bCAJBBMBFKN_codec);
            break;
          }
          case 58:
          case 56: {
            bPLHDFJMPOA_.AddEntriesFrom(ref input, _repeated_bPLHDFJMPOA_codec);
            break;
          }
          case 66: {
            nNMLPGMCCMJ_.AddEntriesFrom(ref input, _repeated_nNMLPGMCCMJ_codec);
            break;
          }
          case 74:
          case 72: {
            pKHAGHJONEF_.AddEntriesFrom(ref input, _repeated_pKHAGHJONEF_codec);
            break;
          }
          case 98:
          case 96: {
            gEDHAAPEBNG_.AddEntriesFrom(ref input, _repeated_gEDHAAPEBNG_codec);
            break;
          }
          case 114:
          case 112: {
            lKDLDPBNNCM_.AddEntriesFrom(ref input, _repeated_lKDLDPBNNCM_codec);
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