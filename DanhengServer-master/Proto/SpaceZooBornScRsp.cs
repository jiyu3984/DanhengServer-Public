// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SpaceZooBornScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SpaceZooBornScRsp.proto</summary>
  public static partial class SpaceZooBornScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for SpaceZooBornScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SpaceZooBornScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdTcGFjZVpvb0Jvcm5TY1JzcC5wcm90bxoRS0pFUExGUEFMQ0IucHJvdG8a",
            "EURHRFBPQ05GTkJNLnByb3RvIn8KEVNwYWNlWm9vQm9yblNjUnNwEiEKC0tP",
            "UE1DRlBBUEVMGAggAygLMgwuS0pFUExGUEFMQ0ISEwoLTkVQTFBPRENIUEUY",
            "CiABKAgSDwoHcmV0Y29kZRgDIAEoDRIhCgtPRkVJS09ORkVJRhgBIAEoCzIM",
            "LkRHRFBPQ05GTkJNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9i",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.KJEPLFPALCBReflection.Descriptor, global::EggLink.DanhengServer.Proto.DGDPOCNFNBMReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SpaceZooBornScRsp), global::EggLink.DanhengServer.Proto.SpaceZooBornScRsp.Parser, new[]{ "KOPMCFPAPEL", "NEPLPODCHPE", "Retcode", "OFEIKONFEIF" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SpaceZooBornScRsp : pb::IMessage<SpaceZooBornScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SpaceZooBornScRsp> _parser = new pb::MessageParser<SpaceZooBornScRsp>(() => new SpaceZooBornScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SpaceZooBornScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.SpaceZooBornScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SpaceZooBornScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SpaceZooBornScRsp(SpaceZooBornScRsp other) : this() {
      kOPMCFPAPEL_ = other.kOPMCFPAPEL_.Clone();
      nEPLPODCHPE_ = other.nEPLPODCHPE_;
      retcode_ = other.retcode_;
      oFEIKONFEIF_ = other.oFEIKONFEIF_ != null ? other.oFEIKONFEIF_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SpaceZooBornScRsp Clone() {
      return new SpaceZooBornScRsp(this);
    }

    /// <summary>Field number for the "KOPMCFPAPEL" field.</summary>
    public const int KOPMCFPAPELFieldNumber = 8;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.KJEPLFPALCB> _repeated_kOPMCFPAPEL_codec
        = pb::FieldCodec.ForMessage(66, global::EggLink.DanhengServer.Proto.KJEPLFPALCB.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.KJEPLFPALCB> kOPMCFPAPEL_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.KJEPLFPALCB>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.KJEPLFPALCB> KOPMCFPAPEL {
      get { return kOPMCFPAPEL_; }
    }

    /// <summary>Field number for the "NEPLPODCHPE" field.</summary>
    public const int NEPLPODCHPEFieldNumber = 10;
    private bool nEPLPODCHPE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool NEPLPODCHPE {
      get { return nEPLPODCHPE_; }
      set {
        nEPLPODCHPE_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 3;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "OFEIKONFEIF" field.</summary>
    public const int OFEIKONFEIFFieldNumber = 1;
    private global::EggLink.DanhengServer.Proto.DGDPOCNFNBM oFEIKONFEIF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.DGDPOCNFNBM OFEIKONFEIF {
      get { return oFEIKONFEIF_; }
      set {
        oFEIKONFEIF_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SpaceZooBornScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SpaceZooBornScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!kOPMCFPAPEL_.Equals(other.kOPMCFPAPEL_)) return false;
      if (NEPLPODCHPE != other.NEPLPODCHPE) return false;
      if (Retcode != other.Retcode) return false;
      if (!object.Equals(OFEIKONFEIF, other.OFEIKONFEIF)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= kOPMCFPAPEL_.GetHashCode();
      if (NEPLPODCHPE != false) hash ^= NEPLPODCHPE.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (oFEIKONFEIF_ != null) hash ^= OFEIKONFEIF.GetHashCode();
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
      if (oFEIKONFEIF_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(OFEIKONFEIF);
      }
      if (Retcode != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Retcode);
      }
      kOPMCFPAPEL_.WriteTo(output, _repeated_kOPMCFPAPEL_codec);
      if (NEPLPODCHPE != false) {
        output.WriteRawTag(80);
        output.WriteBool(NEPLPODCHPE);
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
      if (oFEIKONFEIF_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(OFEIKONFEIF);
      }
      if (Retcode != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Retcode);
      }
      kOPMCFPAPEL_.WriteTo(ref output, _repeated_kOPMCFPAPEL_codec);
      if (NEPLPODCHPE != false) {
        output.WriteRawTag(80);
        output.WriteBool(NEPLPODCHPE);
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
      size += kOPMCFPAPEL_.CalculateSize(_repeated_kOPMCFPAPEL_codec);
      if (NEPLPODCHPE != false) {
        size += 1 + 1;
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (oFEIKONFEIF_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(OFEIKONFEIF);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SpaceZooBornScRsp other) {
      if (other == null) {
        return;
      }
      kOPMCFPAPEL_.Add(other.kOPMCFPAPEL_);
      if (other.NEPLPODCHPE != false) {
        NEPLPODCHPE = other.NEPLPODCHPE;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.oFEIKONFEIF_ != null) {
        if (oFEIKONFEIF_ == null) {
          OFEIKONFEIF = new global::EggLink.DanhengServer.Proto.DGDPOCNFNBM();
        }
        OFEIKONFEIF.MergeFrom(other.OFEIKONFEIF);
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
          case 10: {
            if (oFEIKONFEIF_ == null) {
              OFEIKONFEIF = new global::EggLink.DanhengServer.Proto.DGDPOCNFNBM();
            }
            input.ReadMessage(OFEIKONFEIF);
            break;
          }
          case 24: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 66: {
            kOPMCFPAPEL_.AddEntriesFrom(input, _repeated_kOPMCFPAPEL_codec);
            break;
          }
          case 80: {
            NEPLPODCHPE = input.ReadBool();
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
          case 10: {
            if (oFEIKONFEIF_ == null) {
              OFEIKONFEIF = new global::EggLink.DanhengServer.Proto.DGDPOCNFNBM();
            }
            input.ReadMessage(OFEIKONFEIF);
            break;
          }
          case 24: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 66: {
            kOPMCFPAPEL_.AddEntriesFrom(ref input, _repeated_kOPMCFPAPEL_codec);
            break;
          }
          case 80: {
            NEPLPODCHPE = input.ReadBool();
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
