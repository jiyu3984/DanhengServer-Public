// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TravelBrochureApplyPasterCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from TravelBrochureApplyPasterCsReq.proto</summary>
  public static partial class TravelBrochureApplyPasterCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for TravelBrochureApplyPasterCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TravelBrochureApplyPasterCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRUcmF2ZWxCcm9jaHVyZUFwcGx5UGFzdGVyQ3NSZXEucHJvdG8imgEKHlRy",
            "YXZlbEJyb2NodXJlQXBwbHlQYXN0ZXJDc1JlcRITCgtDSkFFQk9MUElGUBgK",
            "IAEoDRITCgtLTUROUENIS0dLThgEIAEoDRITCgtISklLS0dFRUpCSRgIIAEo",
            "BRIPCgdpdGVtX2lkGAEgASgNEhMKC0dDRkVIR01HT0RLGAsgASgNEhMKC0VC",
            "SkpCQkFNS0RQGAwgASgFQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJv",
            "dG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.TravelBrochureApplyPasterCsReq), global::EggLink.DanhengServer.Proto.TravelBrochureApplyPasterCsReq.Parser, new[]{ "CJAEBOLPIFP", "KMDNPCHKGKN", "HJIKKGEEJBI", "ItemId", "GCFEHGMGODK", "EBJJBBAMKDP" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class TravelBrochureApplyPasterCsReq : pb::IMessage<TravelBrochureApplyPasterCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TravelBrochureApplyPasterCsReq> _parser = new pb::MessageParser<TravelBrochureApplyPasterCsReq>(() => new TravelBrochureApplyPasterCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TravelBrochureApplyPasterCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.TravelBrochureApplyPasterCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TravelBrochureApplyPasterCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TravelBrochureApplyPasterCsReq(TravelBrochureApplyPasterCsReq other) : this() {
      cJAEBOLPIFP_ = other.cJAEBOLPIFP_;
      kMDNPCHKGKN_ = other.kMDNPCHKGKN_;
      hJIKKGEEJBI_ = other.hJIKKGEEJBI_;
      itemId_ = other.itemId_;
      gCFEHGMGODK_ = other.gCFEHGMGODK_;
      eBJJBBAMKDP_ = other.eBJJBBAMKDP_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TravelBrochureApplyPasterCsReq Clone() {
      return new TravelBrochureApplyPasterCsReq(this);
    }

    /// <summary>Field number for the "CJAEBOLPIFP" field.</summary>
    public const int CJAEBOLPIFPFieldNumber = 10;
    private uint cJAEBOLPIFP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CJAEBOLPIFP {
      get { return cJAEBOLPIFP_; }
      set {
        cJAEBOLPIFP_ = value;
      }
    }

    /// <summary>Field number for the "KMDNPCHKGKN" field.</summary>
    public const int KMDNPCHKGKNFieldNumber = 4;
    private uint kMDNPCHKGKN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KMDNPCHKGKN {
      get { return kMDNPCHKGKN_; }
      set {
        kMDNPCHKGKN_ = value;
      }
    }

    /// <summary>Field number for the "HJIKKGEEJBI" field.</summary>
    public const int HJIKKGEEJBIFieldNumber = 8;
    private int hJIKKGEEJBI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int HJIKKGEEJBI {
      get { return hJIKKGEEJBI_; }
      set {
        hJIKKGEEJBI_ = value;
      }
    }

    /// <summary>Field number for the "item_id" field.</summary>
    public const int ItemIdFieldNumber = 1;
    private uint itemId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ItemId {
      get { return itemId_; }
      set {
        itemId_ = value;
      }
    }

    /// <summary>Field number for the "GCFEHGMGODK" field.</summary>
    public const int GCFEHGMGODKFieldNumber = 11;
    private uint gCFEHGMGODK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GCFEHGMGODK {
      get { return gCFEHGMGODK_; }
      set {
        gCFEHGMGODK_ = value;
      }
    }

    /// <summary>Field number for the "EBJJBBAMKDP" field.</summary>
    public const int EBJJBBAMKDPFieldNumber = 12;
    private int eBJJBBAMKDP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int EBJJBBAMKDP {
      get { return eBJJBBAMKDP_; }
      set {
        eBJJBBAMKDP_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TravelBrochureApplyPasterCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TravelBrochureApplyPasterCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CJAEBOLPIFP != other.CJAEBOLPIFP) return false;
      if (KMDNPCHKGKN != other.KMDNPCHKGKN) return false;
      if (HJIKKGEEJBI != other.HJIKKGEEJBI) return false;
      if (ItemId != other.ItemId) return false;
      if (GCFEHGMGODK != other.GCFEHGMGODK) return false;
      if (EBJJBBAMKDP != other.EBJJBBAMKDP) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CJAEBOLPIFP != 0) hash ^= CJAEBOLPIFP.GetHashCode();
      if (KMDNPCHKGKN != 0) hash ^= KMDNPCHKGKN.GetHashCode();
      if (HJIKKGEEJBI != 0) hash ^= HJIKKGEEJBI.GetHashCode();
      if (ItemId != 0) hash ^= ItemId.GetHashCode();
      if (GCFEHGMGODK != 0) hash ^= GCFEHGMGODK.GetHashCode();
      if (EBJJBBAMKDP != 0) hash ^= EBJJBBAMKDP.GetHashCode();
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
      if (ItemId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ItemId);
      }
      if (KMDNPCHKGKN != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(KMDNPCHKGKN);
      }
      if (HJIKKGEEJBI != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(HJIKKGEEJBI);
      }
      if (CJAEBOLPIFP != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(CJAEBOLPIFP);
      }
      if (GCFEHGMGODK != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(GCFEHGMGODK);
      }
      if (EBJJBBAMKDP != 0) {
        output.WriteRawTag(96);
        output.WriteInt32(EBJJBBAMKDP);
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
      if (ItemId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ItemId);
      }
      if (KMDNPCHKGKN != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(KMDNPCHKGKN);
      }
      if (HJIKKGEEJBI != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(HJIKKGEEJBI);
      }
      if (CJAEBOLPIFP != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(CJAEBOLPIFP);
      }
      if (GCFEHGMGODK != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(GCFEHGMGODK);
      }
      if (EBJJBBAMKDP != 0) {
        output.WriteRawTag(96);
        output.WriteInt32(EBJJBBAMKDP);
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
      if (CJAEBOLPIFP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CJAEBOLPIFP);
      }
      if (KMDNPCHKGKN != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KMDNPCHKGKN);
      }
      if (HJIKKGEEJBI != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(HJIKKGEEJBI);
      }
      if (ItemId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ItemId);
      }
      if (GCFEHGMGODK != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GCFEHGMGODK);
      }
      if (EBJJBBAMKDP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(EBJJBBAMKDP);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TravelBrochureApplyPasterCsReq other) {
      if (other == null) {
        return;
      }
      if (other.CJAEBOLPIFP != 0) {
        CJAEBOLPIFP = other.CJAEBOLPIFP;
      }
      if (other.KMDNPCHKGKN != 0) {
        KMDNPCHKGKN = other.KMDNPCHKGKN;
      }
      if (other.HJIKKGEEJBI != 0) {
        HJIKKGEEJBI = other.HJIKKGEEJBI;
      }
      if (other.ItemId != 0) {
        ItemId = other.ItemId;
      }
      if (other.GCFEHGMGODK != 0) {
        GCFEHGMGODK = other.GCFEHGMGODK;
      }
      if (other.EBJJBBAMKDP != 0) {
        EBJJBBAMKDP = other.EBJJBBAMKDP;
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
            ItemId = input.ReadUInt32();
            break;
          }
          case 32: {
            KMDNPCHKGKN = input.ReadUInt32();
            break;
          }
          case 64: {
            HJIKKGEEJBI = input.ReadInt32();
            break;
          }
          case 80: {
            CJAEBOLPIFP = input.ReadUInt32();
            break;
          }
          case 88: {
            GCFEHGMGODK = input.ReadUInt32();
            break;
          }
          case 96: {
            EBJJBBAMKDP = input.ReadInt32();
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
            ItemId = input.ReadUInt32();
            break;
          }
          case 32: {
            KMDNPCHKGKN = input.ReadUInt32();
            break;
          }
          case 64: {
            HJIKKGEEJBI = input.ReadInt32();
            break;
          }
          case 80: {
            CJAEBOLPIFP = input.ReadUInt32();
            break;
          }
          case 88: {
            GCFEHGMGODK = input.ReadUInt32();
            break;
          }
          case 96: {
            EBJJBBAMKDP = input.ReadInt32();
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
