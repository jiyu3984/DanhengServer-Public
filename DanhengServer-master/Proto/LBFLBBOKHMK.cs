// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: LBFLBBOKHMK.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from LBFLBBOKHMK.proto</summary>
  public static partial class LBFLBBOKHMKReflection {

    #region Descriptor
    /// <summary>File descriptor for LBFLBBOKHMK.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LBFLBBOKHMKReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFMQkZMQkJPS0hNSy5wcm90byJvCgtMQkZMQkJPS0hNSxITCgtJQkFETk1E",
            "QUpPRBgBIAEoDRITCgtIRERMTkxGUEJHSxgCIAEoDRITCgtQQkpKT0dDRE1H",
            "ThgDIAEoARIMCgR3YXZlGAQgASgNEhMKC0RMS0NCTEhHQlBGGAUgASgNQh6q",
            "AhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.LBFLBBOKHMK), global::EggLink.DanhengServer.Proto.LBFLBBOKHMK.Parser, new[]{ "IBADNMDAJOD", "HDDLNLFPBGK", "PBJJOGCDMGN", "Wave", "DLKCBLHGBPF" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class LBFLBBOKHMK : pb::IMessage<LBFLBBOKHMK>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LBFLBBOKHMK> _parser = new pb::MessageParser<LBFLBBOKHMK>(() => new LBFLBBOKHMK());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LBFLBBOKHMK> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.LBFLBBOKHMKReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LBFLBBOKHMK() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LBFLBBOKHMK(LBFLBBOKHMK other) : this() {
      iBADNMDAJOD_ = other.iBADNMDAJOD_;
      hDDLNLFPBGK_ = other.hDDLNLFPBGK_;
      pBJJOGCDMGN_ = other.pBJJOGCDMGN_;
      wave_ = other.wave_;
      dLKCBLHGBPF_ = other.dLKCBLHGBPF_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LBFLBBOKHMK Clone() {
      return new LBFLBBOKHMK(this);
    }

    /// <summary>Field number for the "IBADNMDAJOD" field.</summary>
    public const int IBADNMDAJODFieldNumber = 1;
    private uint iBADNMDAJOD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint IBADNMDAJOD {
      get { return iBADNMDAJOD_; }
      set {
        iBADNMDAJOD_ = value;
      }
    }

    /// <summary>Field number for the "HDDLNLFPBGK" field.</summary>
    public const int HDDLNLFPBGKFieldNumber = 2;
    private uint hDDLNLFPBGK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HDDLNLFPBGK {
      get { return hDDLNLFPBGK_; }
      set {
        hDDLNLFPBGK_ = value;
      }
    }

    /// <summary>Field number for the "PBJJOGCDMGN" field.</summary>
    public const int PBJJOGCDMGNFieldNumber = 3;
    private double pBJJOGCDMGN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double PBJJOGCDMGN {
      get { return pBJJOGCDMGN_; }
      set {
        pBJJOGCDMGN_ = value;
      }
    }

    /// <summary>Field number for the "wave" field.</summary>
    public const int WaveFieldNumber = 4;
    private uint wave_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Wave {
      get { return wave_; }
      set {
        wave_ = value;
      }
    }

    /// <summary>Field number for the "DLKCBLHGBPF" field.</summary>
    public const int DLKCBLHGBPFFieldNumber = 5;
    private uint dLKCBLHGBPF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DLKCBLHGBPF {
      get { return dLKCBLHGBPF_; }
      set {
        dLKCBLHGBPF_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LBFLBBOKHMK);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LBFLBBOKHMK other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IBADNMDAJOD != other.IBADNMDAJOD) return false;
      if (HDDLNLFPBGK != other.HDDLNLFPBGK) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(PBJJOGCDMGN, other.PBJJOGCDMGN)) return false;
      if (Wave != other.Wave) return false;
      if (DLKCBLHGBPF != other.DLKCBLHGBPF) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IBADNMDAJOD != 0) hash ^= IBADNMDAJOD.GetHashCode();
      if (HDDLNLFPBGK != 0) hash ^= HDDLNLFPBGK.GetHashCode();
      if (PBJJOGCDMGN != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(PBJJOGCDMGN);
      if (Wave != 0) hash ^= Wave.GetHashCode();
      if (DLKCBLHGBPF != 0) hash ^= DLKCBLHGBPF.GetHashCode();
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
      if (IBADNMDAJOD != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(IBADNMDAJOD);
      }
      if (HDDLNLFPBGK != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(HDDLNLFPBGK);
      }
      if (PBJJOGCDMGN != 0D) {
        output.WriteRawTag(25);
        output.WriteDouble(PBJJOGCDMGN);
      }
      if (Wave != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Wave);
      }
      if (DLKCBLHGBPF != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(DLKCBLHGBPF);
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
      if (IBADNMDAJOD != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(IBADNMDAJOD);
      }
      if (HDDLNLFPBGK != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(HDDLNLFPBGK);
      }
      if (PBJJOGCDMGN != 0D) {
        output.WriteRawTag(25);
        output.WriteDouble(PBJJOGCDMGN);
      }
      if (Wave != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Wave);
      }
      if (DLKCBLHGBPF != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(DLKCBLHGBPF);
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
      if (IBADNMDAJOD != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(IBADNMDAJOD);
      }
      if (HDDLNLFPBGK != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HDDLNLFPBGK);
      }
      if (PBJJOGCDMGN != 0D) {
        size += 1 + 8;
      }
      if (Wave != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Wave);
      }
      if (DLKCBLHGBPF != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DLKCBLHGBPF);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(LBFLBBOKHMK other) {
      if (other == null) {
        return;
      }
      if (other.IBADNMDAJOD != 0) {
        IBADNMDAJOD = other.IBADNMDAJOD;
      }
      if (other.HDDLNLFPBGK != 0) {
        HDDLNLFPBGK = other.HDDLNLFPBGK;
      }
      if (other.PBJJOGCDMGN != 0D) {
        PBJJOGCDMGN = other.PBJJOGCDMGN;
      }
      if (other.Wave != 0) {
        Wave = other.Wave;
      }
      if (other.DLKCBLHGBPF != 0) {
        DLKCBLHGBPF = other.DLKCBLHGBPF;
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
            IBADNMDAJOD = input.ReadUInt32();
            break;
          }
          case 16: {
            HDDLNLFPBGK = input.ReadUInt32();
            break;
          }
          case 25: {
            PBJJOGCDMGN = input.ReadDouble();
            break;
          }
          case 32: {
            Wave = input.ReadUInt32();
            break;
          }
          case 40: {
            DLKCBLHGBPF = input.ReadUInt32();
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
            IBADNMDAJOD = input.ReadUInt32();
            break;
          }
          case 16: {
            HDDLNLFPBGK = input.ReadUInt32();
            break;
          }
          case 25: {
            PBJJOGCDMGN = input.ReadDouble();
            break;
          }
          case 32: {
            Wave = input.ReadUInt32();
            break;
          }
          case 40: {
            DLKCBLHGBPF = input.ReadUInt32();
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
