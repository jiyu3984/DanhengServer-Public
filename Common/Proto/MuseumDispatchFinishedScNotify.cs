// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MuseumDispatchFinishedScNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from MuseumDispatchFinishedScNotify.proto</summary>
  public static partial class MuseumDispatchFinishedScNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for MuseumDispatchFinishedScNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MuseumDispatchFinishedScNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRNdXNldW1EaXNwYXRjaEZpbmlzaGVkU2NOb3RpZnkucHJvdG8idAoeTXVz",
            "ZXVtRGlzcGF0Y2hGaW5pc2hlZFNjTm90aWZ5EhMKC0NJQ0ZJR09NTktOGAYg",
            "ASgNEhMKC0dESkhDQkNPTlBOGAogASgNEhMKC0xFSUxPQ0ZKTkJNGA4gASgN",
            "EhMKC0VFSU5ESEpCRlBGGAUgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2",
            "ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.MuseumDispatchFinishedScNotify), global::EggLink.DanhengServer.Proto.MuseumDispatchFinishedScNotify.Parser, new[]{ "CICFIGOMNKN", "GDJHCBCONPN", "LEILOCFJNBM", "EEINDHJBFPF" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class MuseumDispatchFinishedScNotify : pb::IMessage<MuseumDispatchFinishedScNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MuseumDispatchFinishedScNotify> _parser = new pb::MessageParser<MuseumDispatchFinishedScNotify>(() => new MuseumDispatchFinishedScNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MuseumDispatchFinishedScNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.MuseumDispatchFinishedScNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MuseumDispatchFinishedScNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MuseumDispatchFinishedScNotify(MuseumDispatchFinishedScNotify other) : this() {
      cICFIGOMNKN_ = other.cICFIGOMNKN_;
      gDJHCBCONPN_ = other.gDJHCBCONPN_;
      lEILOCFJNBM_ = other.lEILOCFJNBM_;
      eEINDHJBFPF_ = other.eEINDHJBFPF_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MuseumDispatchFinishedScNotify Clone() {
      return new MuseumDispatchFinishedScNotify(this);
    }

    /// <summary>Field number for the "CICFIGOMNKN" field.</summary>
    public const int CICFIGOMNKNFieldNumber = 6;
    private uint cICFIGOMNKN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CICFIGOMNKN {
      get { return cICFIGOMNKN_; }
      set {
        cICFIGOMNKN_ = value;
      }
    }

    /// <summary>Field number for the "GDJHCBCONPN" field.</summary>
    public const int GDJHCBCONPNFieldNumber = 10;
    private uint gDJHCBCONPN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GDJHCBCONPN {
      get { return gDJHCBCONPN_; }
      set {
        gDJHCBCONPN_ = value;
      }
    }

    /// <summary>Field number for the "LEILOCFJNBM" field.</summary>
    public const int LEILOCFJNBMFieldNumber = 14;
    private uint lEILOCFJNBM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LEILOCFJNBM {
      get { return lEILOCFJNBM_; }
      set {
        lEILOCFJNBM_ = value;
      }
    }

    /// <summary>Field number for the "EEINDHJBFPF" field.</summary>
    public const int EEINDHJBFPFFieldNumber = 5;
    private uint eEINDHJBFPF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EEINDHJBFPF {
      get { return eEINDHJBFPF_; }
      set {
        eEINDHJBFPF_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MuseumDispatchFinishedScNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MuseumDispatchFinishedScNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CICFIGOMNKN != other.CICFIGOMNKN) return false;
      if (GDJHCBCONPN != other.GDJHCBCONPN) return false;
      if (LEILOCFJNBM != other.LEILOCFJNBM) return false;
      if (EEINDHJBFPF != other.EEINDHJBFPF) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CICFIGOMNKN != 0) hash ^= CICFIGOMNKN.GetHashCode();
      if (GDJHCBCONPN != 0) hash ^= GDJHCBCONPN.GetHashCode();
      if (LEILOCFJNBM != 0) hash ^= LEILOCFJNBM.GetHashCode();
      if (EEINDHJBFPF != 0) hash ^= EEINDHJBFPF.GetHashCode();
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
      if (EEINDHJBFPF != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(EEINDHJBFPF);
      }
      if (CICFIGOMNKN != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(CICFIGOMNKN);
      }
      if (GDJHCBCONPN != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(GDJHCBCONPN);
      }
      if (LEILOCFJNBM != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(LEILOCFJNBM);
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
      if (EEINDHJBFPF != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(EEINDHJBFPF);
      }
      if (CICFIGOMNKN != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(CICFIGOMNKN);
      }
      if (GDJHCBCONPN != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(GDJHCBCONPN);
      }
      if (LEILOCFJNBM != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(LEILOCFJNBM);
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
      if (CICFIGOMNKN != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CICFIGOMNKN);
      }
      if (GDJHCBCONPN != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GDJHCBCONPN);
      }
      if (LEILOCFJNBM != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LEILOCFJNBM);
      }
      if (EEINDHJBFPF != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EEINDHJBFPF);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MuseumDispatchFinishedScNotify other) {
      if (other == null) {
        return;
      }
      if (other.CICFIGOMNKN != 0) {
        CICFIGOMNKN = other.CICFIGOMNKN;
      }
      if (other.GDJHCBCONPN != 0) {
        GDJHCBCONPN = other.GDJHCBCONPN;
      }
      if (other.LEILOCFJNBM != 0) {
        LEILOCFJNBM = other.LEILOCFJNBM;
      }
      if (other.EEINDHJBFPF != 0) {
        EEINDHJBFPF = other.EEINDHJBFPF;
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
          case 40: {
            EEINDHJBFPF = input.ReadUInt32();
            break;
          }
          case 48: {
            CICFIGOMNKN = input.ReadUInt32();
            break;
          }
          case 80: {
            GDJHCBCONPN = input.ReadUInt32();
            break;
          }
          case 112: {
            LEILOCFJNBM = input.ReadUInt32();
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
          case 40: {
            EEINDHJBFPF = input.ReadUInt32();
            break;
          }
          case 48: {
            CICFIGOMNKN = input.ReadUInt32();
            break;
          }
          case 80: {
            GDJHCBCONPN = input.ReadUInt32();
            break;
          }
          case 112: {
            LEILOCFJNBM = input.ReadUInt32();
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