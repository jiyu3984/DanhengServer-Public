// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DailyFirstEnterMonopolyActivityScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from DailyFirstEnterMonopolyActivityScRsp.proto</summary>
  public static partial class DailyFirstEnterMonopolyActivityScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for DailyFirstEnterMonopolyActivityScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DailyFirstEnterMonopolyActivityScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CipEYWlseUZpcnN0RW50ZXJNb25vcG9seUFjdGl2aXR5U2NSc3AucHJvdG8a",
            "EUdGSktLQ01GRUlMLnByb3RvIpkBCiREYWlseUZpcnN0RW50ZXJNb25vcG9s",
            "eUFjdGl2aXR5U2NSc3ASIQoLS0lGUEhIREtFRlAYCCABKAsyDC5HRkpLS0NN",
            "RkVJTBITCgtPRUdLTVBFRUxIRxgKIAEoCBIPCgdyZXRjb2RlGAcgASgNEhMK",
            "C0NMR05HRUpFUFBGGAEgASgDEhMKC0RDQ0xCTUFQREJDGA0gASgNQh6qAhtF",
            "Z2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.GFJKKCMFEILReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.DailyFirstEnterMonopolyActivityScRsp), global::EggLink.DanhengServer.Proto.DailyFirstEnterMonopolyActivityScRsp.Parser, new[]{ "KIFPHHDKEFP", "OEGKMPEELHG", "Retcode", "CLGNGEJEPPF", "DCCLBMAPDBC" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class DailyFirstEnterMonopolyActivityScRsp : pb::IMessage<DailyFirstEnterMonopolyActivityScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DailyFirstEnterMonopolyActivityScRsp> _parser = new pb::MessageParser<DailyFirstEnterMonopolyActivityScRsp>(() => new DailyFirstEnterMonopolyActivityScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DailyFirstEnterMonopolyActivityScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.DailyFirstEnterMonopolyActivityScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DailyFirstEnterMonopolyActivityScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DailyFirstEnterMonopolyActivityScRsp(DailyFirstEnterMonopolyActivityScRsp other) : this() {
      kIFPHHDKEFP_ = other.kIFPHHDKEFP_ != null ? other.kIFPHHDKEFP_.Clone() : null;
      oEGKMPEELHG_ = other.oEGKMPEELHG_;
      retcode_ = other.retcode_;
      cLGNGEJEPPF_ = other.cLGNGEJEPPF_;
      dCCLBMAPDBC_ = other.dCCLBMAPDBC_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DailyFirstEnterMonopolyActivityScRsp Clone() {
      return new DailyFirstEnterMonopolyActivityScRsp(this);
    }

    /// <summary>Field number for the "KIFPHHDKEFP" field.</summary>
    public const int KIFPHHDKEFPFieldNumber = 8;
    private global::EggLink.DanhengServer.Proto.GFJKKCMFEIL kIFPHHDKEFP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.GFJKKCMFEIL KIFPHHDKEFP {
      get { return kIFPHHDKEFP_; }
      set {
        kIFPHHDKEFP_ = value;
      }
    }

    /// <summary>Field number for the "OEGKMPEELHG" field.</summary>
    public const int OEGKMPEELHGFieldNumber = 10;
    private bool oEGKMPEELHG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool OEGKMPEELHG {
      get { return oEGKMPEELHG_; }
      set {
        oEGKMPEELHG_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 7;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "CLGNGEJEPPF" field.</summary>
    public const int CLGNGEJEPPFFieldNumber = 1;
    private long cLGNGEJEPPF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long CLGNGEJEPPF {
      get { return cLGNGEJEPPF_; }
      set {
        cLGNGEJEPPF_ = value;
      }
    }

    /// <summary>Field number for the "DCCLBMAPDBC" field.</summary>
    public const int DCCLBMAPDBCFieldNumber = 13;
    private uint dCCLBMAPDBC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DCCLBMAPDBC {
      get { return dCCLBMAPDBC_; }
      set {
        dCCLBMAPDBC_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DailyFirstEnterMonopolyActivityScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DailyFirstEnterMonopolyActivityScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(KIFPHHDKEFP, other.KIFPHHDKEFP)) return false;
      if (OEGKMPEELHG != other.OEGKMPEELHG) return false;
      if (Retcode != other.Retcode) return false;
      if (CLGNGEJEPPF != other.CLGNGEJEPPF) return false;
      if (DCCLBMAPDBC != other.DCCLBMAPDBC) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (kIFPHHDKEFP_ != null) hash ^= KIFPHHDKEFP.GetHashCode();
      if (OEGKMPEELHG != false) hash ^= OEGKMPEELHG.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (CLGNGEJEPPF != 0L) hash ^= CLGNGEJEPPF.GetHashCode();
      if (DCCLBMAPDBC != 0) hash ^= DCCLBMAPDBC.GetHashCode();
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
      if (CLGNGEJEPPF != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(CLGNGEJEPPF);
      }
      if (Retcode != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Retcode);
      }
      if (kIFPHHDKEFP_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(KIFPHHDKEFP);
      }
      if (OEGKMPEELHG != false) {
        output.WriteRawTag(80);
        output.WriteBool(OEGKMPEELHG);
      }
      if (DCCLBMAPDBC != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(DCCLBMAPDBC);
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
      if (CLGNGEJEPPF != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(CLGNGEJEPPF);
      }
      if (Retcode != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Retcode);
      }
      if (kIFPHHDKEFP_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(KIFPHHDKEFP);
      }
      if (OEGKMPEELHG != false) {
        output.WriteRawTag(80);
        output.WriteBool(OEGKMPEELHG);
      }
      if (DCCLBMAPDBC != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(DCCLBMAPDBC);
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
      if (kIFPHHDKEFP_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(KIFPHHDKEFP);
      }
      if (OEGKMPEELHG != false) {
        size += 1 + 1;
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (CLGNGEJEPPF != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(CLGNGEJEPPF);
      }
      if (DCCLBMAPDBC != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DCCLBMAPDBC);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DailyFirstEnterMonopolyActivityScRsp other) {
      if (other == null) {
        return;
      }
      if (other.kIFPHHDKEFP_ != null) {
        if (kIFPHHDKEFP_ == null) {
          KIFPHHDKEFP = new global::EggLink.DanhengServer.Proto.GFJKKCMFEIL();
        }
        KIFPHHDKEFP.MergeFrom(other.KIFPHHDKEFP);
      }
      if (other.OEGKMPEELHG != false) {
        OEGKMPEELHG = other.OEGKMPEELHG;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.CLGNGEJEPPF != 0L) {
        CLGNGEJEPPF = other.CLGNGEJEPPF;
      }
      if (other.DCCLBMAPDBC != 0) {
        DCCLBMAPDBC = other.DCCLBMAPDBC;
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
            CLGNGEJEPPF = input.ReadInt64();
            break;
          }
          case 56: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 66: {
            if (kIFPHHDKEFP_ == null) {
              KIFPHHDKEFP = new global::EggLink.DanhengServer.Proto.GFJKKCMFEIL();
            }
            input.ReadMessage(KIFPHHDKEFP);
            break;
          }
          case 80: {
            OEGKMPEELHG = input.ReadBool();
            break;
          }
          case 104: {
            DCCLBMAPDBC = input.ReadUInt32();
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
            CLGNGEJEPPF = input.ReadInt64();
            break;
          }
          case 56: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 66: {
            if (kIFPHHDKEFP_ == null) {
              KIFPHHDKEFP = new global::EggLink.DanhengServer.Proto.GFJKKCMFEIL();
            }
            input.ReadMessage(KIFPHHDKEFP);
            break;
          }
          case 80: {
            OEGKMPEELHG = input.ReadBool();
            break;
          }
          case 104: {
            DCCLBMAPDBC = input.ReadUInt32();
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