// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CKBCAHOBKBH.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from CKBCAHOBKBH.proto</summary>
  public static partial class CKBCAHOBKBHReflection {

    #region Descriptor
    /// <summary>File descriptor for CKBCAHOBKBH.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CKBCAHOBKBHReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFDS0JDQUhPQktCSC5wcm90byJuCgtDS0JDQUhPQktCSBITCgtLREFDRkRK",
            "R0ZDTRgOIAEoDRITCgtCQU1GR01MRkxIRRgHIAEoDRITCgtCRkRPTERBQ0JP",
            "TBgNIAEoDRITCgtLTUxFSkFKRktCQRgGIAEoDRILCgN1aWQYAiABKA1CHqoC",
            "G0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.CKBCAHOBKBH), global::EggLink.DanhengServer.Proto.CKBCAHOBKBH.Parser, new[]{ "KDACFDJGFCM", "BAMFGMLFLHE", "BFDOLDACBOL", "KMLEJAJFKBA", "Uid" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class CKBCAHOBKBH : pb::IMessage<CKBCAHOBKBH>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CKBCAHOBKBH> _parser = new pb::MessageParser<CKBCAHOBKBH>(() => new CKBCAHOBKBH());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CKBCAHOBKBH> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.CKBCAHOBKBHReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CKBCAHOBKBH() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CKBCAHOBKBH(CKBCAHOBKBH other) : this() {
      kDACFDJGFCM_ = other.kDACFDJGFCM_;
      bAMFGMLFLHE_ = other.bAMFGMLFLHE_;
      bFDOLDACBOL_ = other.bFDOLDACBOL_;
      kMLEJAJFKBA_ = other.kMLEJAJFKBA_;
      uid_ = other.uid_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CKBCAHOBKBH Clone() {
      return new CKBCAHOBKBH(this);
    }

    /// <summary>Field number for the "KDACFDJGFCM" field.</summary>
    public const int KDACFDJGFCMFieldNumber = 14;
    private uint kDACFDJGFCM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KDACFDJGFCM {
      get { return kDACFDJGFCM_; }
      set {
        kDACFDJGFCM_ = value;
      }
    }

    /// <summary>Field number for the "BAMFGMLFLHE" field.</summary>
    public const int BAMFGMLFLHEFieldNumber = 7;
    private uint bAMFGMLFLHE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BAMFGMLFLHE {
      get { return bAMFGMLFLHE_; }
      set {
        bAMFGMLFLHE_ = value;
      }
    }

    /// <summary>Field number for the "BFDOLDACBOL" field.</summary>
    public const int BFDOLDACBOLFieldNumber = 13;
    private uint bFDOLDACBOL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BFDOLDACBOL {
      get { return bFDOLDACBOL_; }
      set {
        bFDOLDACBOL_ = value;
      }
    }

    /// <summary>Field number for the "KMLEJAJFKBA" field.</summary>
    public const int KMLEJAJFKBAFieldNumber = 6;
    private uint kMLEJAJFKBA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KMLEJAJFKBA {
      get { return kMLEJAJFKBA_; }
      set {
        kMLEJAJFKBA_ = value;
      }
    }

    /// <summary>Field number for the "uid" field.</summary>
    public const int UidFieldNumber = 2;
    private uint uid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Uid {
      get { return uid_; }
      set {
        uid_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CKBCAHOBKBH);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CKBCAHOBKBH other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (KDACFDJGFCM != other.KDACFDJGFCM) return false;
      if (BAMFGMLFLHE != other.BAMFGMLFLHE) return false;
      if (BFDOLDACBOL != other.BFDOLDACBOL) return false;
      if (KMLEJAJFKBA != other.KMLEJAJFKBA) return false;
      if (Uid != other.Uid) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (KDACFDJGFCM != 0) hash ^= KDACFDJGFCM.GetHashCode();
      if (BAMFGMLFLHE != 0) hash ^= BAMFGMLFLHE.GetHashCode();
      if (BFDOLDACBOL != 0) hash ^= BFDOLDACBOL.GetHashCode();
      if (KMLEJAJFKBA != 0) hash ^= KMLEJAJFKBA.GetHashCode();
      if (Uid != 0) hash ^= Uid.GetHashCode();
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
      if (Uid != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Uid);
      }
      if (KMLEJAJFKBA != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(KMLEJAJFKBA);
      }
      if (BAMFGMLFLHE != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(BAMFGMLFLHE);
      }
      if (BFDOLDACBOL != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(BFDOLDACBOL);
      }
      if (KDACFDJGFCM != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(KDACFDJGFCM);
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
      if (Uid != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Uid);
      }
      if (KMLEJAJFKBA != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(KMLEJAJFKBA);
      }
      if (BAMFGMLFLHE != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(BAMFGMLFLHE);
      }
      if (BFDOLDACBOL != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(BFDOLDACBOL);
      }
      if (KDACFDJGFCM != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(KDACFDJGFCM);
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
      if (KDACFDJGFCM != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KDACFDJGFCM);
      }
      if (BAMFGMLFLHE != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BAMFGMLFLHE);
      }
      if (BFDOLDACBOL != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BFDOLDACBOL);
      }
      if (KMLEJAJFKBA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KMLEJAJFKBA);
      }
      if (Uid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Uid);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CKBCAHOBKBH other) {
      if (other == null) {
        return;
      }
      if (other.KDACFDJGFCM != 0) {
        KDACFDJGFCM = other.KDACFDJGFCM;
      }
      if (other.BAMFGMLFLHE != 0) {
        BAMFGMLFLHE = other.BAMFGMLFLHE;
      }
      if (other.BFDOLDACBOL != 0) {
        BFDOLDACBOL = other.BFDOLDACBOL;
      }
      if (other.KMLEJAJFKBA != 0) {
        KMLEJAJFKBA = other.KMLEJAJFKBA;
      }
      if (other.Uid != 0) {
        Uid = other.Uid;
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
            Uid = input.ReadUInt32();
            break;
          }
          case 48: {
            KMLEJAJFKBA = input.ReadUInt32();
            break;
          }
          case 56: {
            BAMFGMLFLHE = input.ReadUInt32();
            break;
          }
          case 104: {
            BFDOLDACBOL = input.ReadUInt32();
            break;
          }
          case 112: {
            KDACFDJGFCM = input.ReadUInt32();
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
            Uid = input.ReadUInt32();
            break;
          }
          case 48: {
            KMLEJAJFKBA = input.ReadUInt32();
            break;
          }
          case 56: {
            BAMFGMLFLHE = input.ReadUInt32();
            break;
          }
          case 104: {
            BFDOLDACBOL = input.ReadUInt32();
            break;
          }
          case 112: {
            KDACFDJGFCM = input.ReadUInt32();
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
