// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerSettingInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from PlayerSettingInfo.proto</summary>
  public static partial class PlayerSettingInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerSettingInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerSettingInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdQbGF5ZXJTZXR0aW5nSW5mby5wcm90byLlAQoRUGxheWVyU2V0dGluZ0lu",
            "Zm8SEwoLRUJFUEhHTERDTkgYDiABKAgSEwoLS01DQ0tJTUhCQkoYDSABKAgS",
            "EwoLT0lHSVBNRU9FS0IYDyABKAgSEwoLS09GREVPQUdMR0sYBCABKAgSEwoL",
            "S0tISENPUEVOR00YBSABKAgSEwoLS0hLQUFQQUNHSkYYBiABKAgSEwoLRUZD",
            "Q0RETU5NTFAYASABKAgSEwoLS01BQ0RNQUZGRk4YCCABKAgSEwoLTUVGRktD",
            "QVBCRkoYCiABKAgSEwoLREVORkxKS0hORk8YDCABKAhCHqoCG0VnZ0xpbmsu",
            "RGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.PlayerSettingInfo), global::EggLink.DanhengServer.Proto.PlayerSettingInfo.Parser, new[]{ "EBEPHGLDCNH", "KMCCKIMHBBJ", "OIGIPMEOEKB", "KOFDEOAGLGK", "KKHHCOPENGM", "KHKAAPACGJF", "EFCCDDMNMLP", "KMACDMAFFFN", "MEFFKCAPBFJ", "DENFLJKHNFO" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class PlayerSettingInfo : pb::IMessage<PlayerSettingInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerSettingInfo> _parser = new pb::MessageParser<PlayerSettingInfo>(() => new PlayerSettingInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerSettingInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.PlayerSettingInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerSettingInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerSettingInfo(PlayerSettingInfo other) : this() {
      eBEPHGLDCNH_ = other.eBEPHGLDCNH_;
      kMCCKIMHBBJ_ = other.kMCCKIMHBBJ_;
      oIGIPMEOEKB_ = other.oIGIPMEOEKB_;
      kOFDEOAGLGK_ = other.kOFDEOAGLGK_;
      kKHHCOPENGM_ = other.kKHHCOPENGM_;
      kHKAAPACGJF_ = other.kHKAAPACGJF_;
      eFCCDDMNMLP_ = other.eFCCDDMNMLP_;
      kMACDMAFFFN_ = other.kMACDMAFFFN_;
      mEFFKCAPBFJ_ = other.mEFFKCAPBFJ_;
      dENFLJKHNFO_ = other.dENFLJKHNFO_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerSettingInfo Clone() {
      return new PlayerSettingInfo(this);
    }

    /// <summary>Field number for the "EBEPHGLDCNH" field.</summary>
    public const int EBEPHGLDCNHFieldNumber = 14;
    private bool eBEPHGLDCNH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool EBEPHGLDCNH {
      get { return eBEPHGLDCNH_; }
      set {
        eBEPHGLDCNH_ = value;
      }
    }

    /// <summary>Field number for the "KMCCKIMHBBJ" field.</summary>
    public const int KMCCKIMHBBJFieldNumber = 13;
    private bool kMCCKIMHBBJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool KMCCKIMHBBJ {
      get { return kMCCKIMHBBJ_; }
      set {
        kMCCKIMHBBJ_ = value;
      }
    }

    /// <summary>Field number for the "OIGIPMEOEKB" field.</summary>
    public const int OIGIPMEOEKBFieldNumber = 15;
    private bool oIGIPMEOEKB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool OIGIPMEOEKB {
      get { return oIGIPMEOEKB_; }
      set {
        oIGIPMEOEKB_ = value;
      }
    }

    /// <summary>Field number for the "KOFDEOAGLGK" field.</summary>
    public const int KOFDEOAGLGKFieldNumber = 4;
    private bool kOFDEOAGLGK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool KOFDEOAGLGK {
      get { return kOFDEOAGLGK_; }
      set {
        kOFDEOAGLGK_ = value;
      }
    }

    /// <summary>Field number for the "KKHHCOPENGM" field.</summary>
    public const int KKHHCOPENGMFieldNumber = 5;
    private bool kKHHCOPENGM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool KKHHCOPENGM {
      get { return kKHHCOPENGM_; }
      set {
        kKHHCOPENGM_ = value;
      }
    }

    /// <summary>Field number for the "KHKAAPACGJF" field.</summary>
    public const int KHKAAPACGJFFieldNumber = 6;
    private bool kHKAAPACGJF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool KHKAAPACGJF {
      get { return kHKAAPACGJF_; }
      set {
        kHKAAPACGJF_ = value;
      }
    }

    /// <summary>Field number for the "EFCCDDMNMLP" field.</summary>
    public const int EFCCDDMNMLPFieldNumber = 1;
    private bool eFCCDDMNMLP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool EFCCDDMNMLP {
      get { return eFCCDDMNMLP_; }
      set {
        eFCCDDMNMLP_ = value;
      }
    }

    /// <summary>Field number for the "KMACDMAFFFN" field.</summary>
    public const int KMACDMAFFFNFieldNumber = 8;
    private bool kMACDMAFFFN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool KMACDMAFFFN {
      get { return kMACDMAFFFN_; }
      set {
        kMACDMAFFFN_ = value;
      }
    }

    /// <summary>Field number for the "MEFFKCAPBFJ" field.</summary>
    public const int MEFFKCAPBFJFieldNumber = 10;
    private bool mEFFKCAPBFJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool MEFFKCAPBFJ {
      get { return mEFFKCAPBFJ_; }
      set {
        mEFFKCAPBFJ_ = value;
      }
    }

    /// <summary>Field number for the "DENFLJKHNFO" field.</summary>
    public const int DENFLJKHNFOFieldNumber = 12;
    private bool dENFLJKHNFO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool DENFLJKHNFO {
      get { return dENFLJKHNFO_; }
      set {
        dENFLJKHNFO_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerSettingInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerSettingInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EBEPHGLDCNH != other.EBEPHGLDCNH) return false;
      if (KMCCKIMHBBJ != other.KMCCKIMHBBJ) return false;
      if (OIGIPMEOEKB != other.OIGIPMEOEKB) return false;
      if (KOFDEOAGLGK != other.KOFDEOAGLGK) return false;
      if (KKHHCOPENGM != other.KKHHCOPENGM) return false;
      if (KHKAAPACGJF != other.KHKAAPACGJF) return false;
      if (EFCCDDMNMLP != other.EFCCDDMNMLP) return false;
      if (KMACDMAFFFN != other.KMACDMAFFFN) return false;
      if (MEFFKCAPBFJ != other.MEFFKCAPBFJ) return false;
      if (DENFLJKHNFO != other.DENFLJKHNFO) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EBEPHGLDCNH != false) hash ^= EBEPHGLDCNH.GetHashCode();
      if (KMCCKIMHBBJ != false) hash ^= KMCCKIMHBBJ.GetHashCode();
      if (OIGIPMEOEKB != false) hash ^= OIGIPMEOEKB.GetHashCode();
      if (KOFDEOAGLGK != false) hash ^= KOFDEOAGLGK.GetHashCode();
      if (KKHHCOPENGM != false) hash ^= KKHHCOPENGM.GetHashCode();
      if (KHKAAPACGJF != false) hash ^= KHKAAPACGJF.GetHashCode();
      if (EFCCDDMNMLP != false) hash ^= EFCCDDMNMLP.GetHashCode();
      if (KMACDMAFFFN != false) hash ^= KMACDMAFFFN.GetHashCode();
      if (MEFFKCAPBFJ != false) hash ^= MEFFKCAPBFJ.GetHashCode();
      if (DENFLJKHNFO != false) hash ^= DENFLJKHNFO.GetHashCode();
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
      if (EFCCDDMNMLP != false) {
        output.WriteRawTag(8);
        output.WriteBool(EFCCDDMNMLP);
      }
      if (KOFDEOAGLGK != false) {
        output.WriteRawTag(32);
        output.WriteBool(KOFDEOAGLGK);
      }
      if (KKHHCOPENGM != false) {
        output.WriteRawTag(40);
        output.WriteBool(KKHHCOPENGM);
      }
      if (KHKAAPACGJF != false) {
        output.WriteRawTag(48);
        output.WriteBool(KHKAAPACGJF);
      }
      if (KMACDMAFFFN != false) {
        output.WriteRawTag(64);
        output.WriteBool(KMACDMAFFFN);
      }
      if (MEFFKCAPBFJ != false) {
        output.WriteRawTag(80);
        output.WriteBool(MEFFKCAPBFJ);
      }
      if (DENFLJKHNFO != false) {
        output.WriteRawTag(96);
        output.WriteBool(DENFLJKHNFO);
      }
      if (KMCCKIMHBBJ != false) {
        output.WriteRawTag(104);
        output.WriteBool(KMCCKIMHBBJ);
      }
      if (EBEPHGLDCNH != false) {
        output.WriteRawTag(112);
        output.WriteBool(EBEPHGLDCNH);
      }
      if (OIGIPMEOEKB != false) {
        output.WriteRawTag(120);
        output.WriteBool(OIGIPMEOEKB);
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
      if (EFCCDDMNMLP != false) {
        output.WriteRawTag(8);
        output.WriteBool(EFCCDDMNMLP);
      }
      if (KOFDEOAGLGK != false) {
        output.WriteRawTag(32);
        output.WriteBool(KOFDEOAGLGK);
      }
      if (KKHHCOPENGM != false) {
        output.WriteRawTag(40);
        output.WriteBool(KKHHCOPENGM);
      }
      if (KHKAAPACGJF != false) {
        output.WriteRawTag(48);
        output.WriteBool(KHKAAPACGJF);
      }
      if (KMACDMAFFFN != false) {
        output.WriteRawTag(64);
        output.WriteBool(KMACDMAFFFN);
      }
      if (MEFFKCAPBFJ != false) {
        output.WriteRawTag(80);
        output.WriteBool(MEFFKCAPBFJ);
      }
      if (DENFLJKHNFO != false) {
        output.WriteRawTag(96);
        output.WriteBool(DENFLJKHNFO);
      }
      if (KMCCKIMHBBJ != false) {
        output.WriteRawTag(104);
        output.WriteBool(KMCCKIMHBBJ);
      }
      if (EBEPHGLDCNH != false) {
        output.WriteRawTag(112);
        output.WriteBool(EBEPHGLDCNH);
      }
      if (OIGIPMEOEKB != false) {
        output.WriteRawTag(120);
        output.WriteBool(OIGIPMEOEKB);
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
      if (EBEPHGLDCNH != false) {
        size += 1 + 1;
      }
      if (KMCCKIMHBBJ != false) {
        size += 1 + 1;
      }
      if (OIGIPMEOEKB != false) {
        size += 1 + 1;
      }
      if (KOFDEOAGLGK != false) {
        size += 1 + 1;
      }
      if (KKHHCOPENGM != false) {
        size += 1 + 1;
      }
      if (KHKAAPACGJF != false) {
        size += 1 + 1;
      }
      if (EFCCDDMNMLP != false) {
        size += 1 + 1;
      }
      if (KMACDMAFFFN != false) {
        size += 1 + 1;
      }
      if (MEFFKCAPBFJ != false) {
        size += 1 + 1;
      }
      if (DENFLJKHNFO != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerSettingInfo other) {
      if (other == null) {
        return;
      }
      if (other.EBEPHGLDCNH != false) {
        EBEPHGLDCNH = other.EBEPHGLDCNH;
      }
      if (other.KMCCKIMHBBJ != false) {
        KMCCKIMHBBJ = other.KMCCKIMHBBJ;
      }
      if (other.OIGIPMEOEKB != false) {
        OIGIPMEOEKB = other.OIGIPMEOEKB;
      }
      if (other.KOFDEOAGLGK != false) {
        KOFDEOAGLGK = other.KOFDEOAGLGK;
      }
      if (other.KKHHCOPENGM != false) {
        KKHHCOPENGM = other.KKHHCOPENGM;
      }
      if (other.KHKAAPACGJF != false) {
        KHKAAPACGJF = other.KHKAAPACGJF;
      }
      if (other.EFCCDDMNMLP != false) {
        EFCCDDMNMLP = other.EFCCDDMNMLP;
      }
      if (other.KMACDMAFFFN != false) {
        KMACDMAFFFN = other.KMACDMAFFFN;
      }
      if (other.MEFFKCAPBFJ != false) {
        MEFFKCAPBFJ = other.MEFFKCAPBFJ;
      }
      if (other.DENFLJKHNFO != false) {
        DENFLJKHNFO = other.DENFLJKHNFO;
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
            EFCCDDMNMLP = input.ReadBool();
            break;
          }
          case 32: {
            KOFDEOAGLGK = input.ReadBool();
            break;
          }
          case 40: {
            KKHHCOPENGM = input.ReadBool();
            break;
          }
          case 48: {
            KHKAAPACGJF = input.ReadBool();
            break;
          }
          case 64: {
            KMACDMAFFFN = input.ReadBool();
            break;
          }
          case 80: {
            MEFFKCAPBFJ = input.ReadBool();
            break;
          }
          case 96: {
            DENFLJKHNFO = input.ReadBool();
            break;
          }
          case 104: {
            KMCCKIMHBBJ = input.ReadBool();
            break;
          }
          case 112: {
            EBEPHGLDCNH = input.ReadBool();
            break;
          }
          case 120: {
            OIGIPMEOEKB = input.ReadBool();
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
            EFCCDDMNMLP = input.ReadBool();
            break;
          }
          case 32: {
            KOFDEOAGLGK = input.ReadBool();
            break;
          }
          case 40: {
            KKHHCOPENGM = input.ReadBool();
            break;
          }
          case 48: {
            KHKAAPACGJF = input.ReadBool();
            break;
          }
          case 64: {
            KMACDMAFFFN = input.ReadBool();
            break;
          }
          case 80: {
            MEFFKCAPBFJ = input.ReadBool();
            break;
          }
          case 96: {
            DENFLJKHNFO = input.ReadBool();
            break;
          }
          case 104: {
            KMCCKIMHBBJ = input.ReadBool();
            break;
          }
          case 112: {
            EBEPHGLDCNH = input.ReadBool();
            break;
          }
          case 120: {
            OIGIPMEOEKB = input.ReadBool();
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
