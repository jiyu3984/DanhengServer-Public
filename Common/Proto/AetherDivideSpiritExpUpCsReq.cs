// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AetherDivideSpiritExpUpCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from AetherDivideSpiritExpUpCsReq.proto</summary>
  public static partial class AetherDivideSpiritExpUpCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for AetherDivideSpiritExpUpCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AetherDivideSpiritExpUpCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJBZXRoZXJEaXZpZGVTcGlyaXRFeHBVcENzUmVxLnByb3RvIl0KHEFldGhl",
            "ckRpdmlkZVNwaXJpdEV4cFVwQ3NSZXESEwoLQUNPSUNFSkVFSkkYCCABKA0S",
            "EwoLSExIREVITklNT08YBSABKA0SEwoLTVBMQ01QREdITUYYBiABKA1CHqoC",
            "G0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.AetherDivideSpiritExpUpCsReq), global::EggLink.DanhengServer.Proto.AetherDivideSpiritExpUpCsReq.Parser, new[]{ "ACOICEJEEJI", "HLHDEHNIMOO", "MPLCMPDGHMF" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class AetherDivideSpiritExpUpCsReq : pb::IMessage<AetherDivideSpiritExpUpCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AetherDivideSpiritExpUpCsReq> _parser = new pb::MessageParser<AetherDivideSpiritExpUpCsReq>(() => new AetherDivideSpiritExpUpCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AetherDivideSpiritExpUpCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.AetherDivideSpiritExpUpCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AetherDivideSpiritExpUpCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AetherDivideSpiritExpUpCsReq(AetherDivideSpiritExpUpCsReq other) : this() {
      aCOICEJEEJI_ = other.aCOICEJEEJI_;
      hLHDEHNIMOO_ = other.hLHDEHNIMOO_;
      mPLCMPDGHMF_ = other.mPLCMPDGHMF_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AetherDivideSpiritExpUpCsReq Clone() {
      return new AetherDivideSpiritExpUpCsReq(this);
    }

    /// <summary>Field number for the "ACOICEJEEJI" field.</summary>
    public const int ACOICEJEEJIFieldNumber = 8;
    private uint aCOICEJEEJI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ACOICEJEEJI {
      get { return aCOICEJEEJI_; }
      set {
        aCOICEJEEJI_ = value;
      }
    }

    /// <summary>Field number for the "HLHDEHNIMOO" field.</summary>
    public const int HLHDEHNIMOOFieldNumber = 5;
    private uint hLHDEHNIMOO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HLHDEHNIMOO {
      get { return hLHDEHNIMOO_; }
      set {
        hLHDEHNIMOO_ = value;
      }
    }

    /// <summary>Field number for the "MPLCMPDGHMF" field.</summary>
    public const int MPLCMPDGHMFFieldNumber = 6;
    private uint mPLCMPDGHMF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MPLCMPDGHMF {
      get { return mPLCMPDGHMF_; }
      set {
        mPLCMPDGHMF_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AetherDivideSpiritExpUpCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AetherDivideSpiritExpUpCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ACOICEJEEJI != other.ACOICEJEEJI) return false;
      if (HLHDEHNIMOO != other.HLHDEHNIMOO) return false;
      if (MPLCMPDGHMF != other.MPLCMPDGHMF) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ACOICEJEEJI != 0) hash ^= ACOICEJEEJI.GetHashCode();
      if (HLHDEHNIMOO != 0) hash ^= HLHDEHNIMOO.GetHashCode();
      if (MPLCMPDGHMF != 0) hash ^= MPLCMPDGHMF.GetHashCode();
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
      if (HLHDEHNIMOO != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(HLHDEHNIMOO);
      }
      if (MPLCMPDGHMF != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(MPLCMPDGHMF);
      }
      if (ACOICEJEEJI != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(ACOICEJEEJI);
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
      if (HLHDEHNIMOO != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(HLHDEHNIMOO);
      }
      if (MPLCMPDGHMF != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(MPLCMPDGHMF);
      }
      if (ACOICEJEEJI != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(ACOICEJEEJI);
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
      if (ACOICEJEEJI != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ACOICEJEEJI);
      }
      if (HLHDEHNIMOO != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HLHDEHNIMOO);
      }
      if (MPLCMPDGHMF != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MPLCMPDGHMF);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AetherDivideSpiritExpUpCsReq other) {
      if (other == null) {
        return;
      }
      if (other.ACOICEJEEJI != 0) {
        ACOICEJEEJI = other.ACOICEJEEJI;
      }
      if (other.HLHDEHNIMOO != 0) {
        HLHDEHNIMOO = other.HLHDEHNIMOO;
      }
      if (other.MPLCMPDGHMF != 0) {
        MPLCMPDGHMF = other.MPLCMPDGHMF;
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
            HLHDEHNIMOO = input.ReadUInt32();
            break;
          }
          case 48: {
            MPLCMPDGHMF = input.ReadUInt32();
            break;
          }
          case 64: {
            ACOICEJEEJI = input.ReadUInt32();
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
            HLHDEHNIMOO = input.ReadUInt32();
            break;
          }
          case 48: {
            MPLCMPDGHMF = input.ReadUInt32();
            break;
          }
          case 64: {
            ACOICEJEEJI = input.ReadUInt32();
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