// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: UpdatePlayerSetting.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from UpdatePlayerSetting.proto</summary>
  public static partial class UpdatePlayerSettingReflection {

    #region Descriptor
    /// <summary>File descriptor for UpdatePlayerSetting.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UpdatePlayerSettingReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlVcGRhdGVQbGF5ZXJTZXR0aW5nLnByb3RvIooCChNVcGRhdGVQbGF5ZXJT",
            "ZXR0aW5nEhUKC01FRkZLQ0FQQkZKGA0gASgISAASFQoLS09GREVPQUdMR0sY",
            "DCABKAhIABIVCgtERU5GTEpLSE5GTxgIIAEoCEgAEhUKC0tIS0FBUEFDR0pG",
            "GAcgASgISAASFQoLS0tISENPUEVOR00YBiABKAhIABIVCgtLTUNDS0lNSEJC",
            "ShgLIAEoCEgAEhUKC09JR0lQTUVPRUtCGAEgASgISAASFQoLS01BQ0RNQUZG",
            "Rk4YDyABKAhIABIVCgtFRkNDRERNTk1MUBgCIAEoCEgAEhUKC0VCRVBIR0xE",
            "Q05IGAogASgISABCDQoLSUFMREFNQkdKR0ZCHqoCG0VnZ0xpbmsuRGFuaGVu",
            "Z1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.UpdatePlayerSetting), global::EggLink.DanhengServer.Proto.UpdatePlayerSetting.Parser, new[]{ "MEFFKCAPBFJ", "KOFDEOAGLGK", "DENFLJKHNFO", "KHKAAPACGJF", "KKHHCOPENGM", "KMCCKIMHBBJ", "OIGIPMEOEKB", "KMACDMAFFFN", "EFCCDDMNMLP", "EBEPHGLDCNH" }, new[]{ "IALDAMBGJGF" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class UpdatePlayerSetting : pb::IMessage<UpdatePlayerSetting>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UpdatePlayerSetting> _parser = new pb::MessageParser<UpdatePlayerSetting>(() => new UpdatePlayerSetting());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<UpdatePlayerSetting> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.UpdatePlayerSettingReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UpdatePlayerSetting() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UpdatePlayerSetting(UpdatePlayerSetting other) : this() {
      switch (other.IALDAMBGJGFCase) {
        case IALDAMBGJGFOneofCase.MEFFKCAPBFJ:
          MEFFKCAPBFJ = other.MEFFKCAPBFJ;
          break;
        case IALDAMBGJGFOneofCase.KOFDEOAGLGK:
          KOFDEOAGLGK = other.KOFDEOAGLGK;
          break;
        case IALDAMBGJGFOneofCase.DENFLJKHNFO:
          DENFLJKHNFO = other.DENFLJKHNFO;
          break;
        case IALDAMBGJGFOneofCase.KHKAAPACGJF:
          KHKAAPACGJF = other.KHKAAPACGJF;
          break;
        case IALDAMBGJGFOneofCase.KKHHCOPENGM:
          KKHHCOPENGM = other.KKHHCOPENGM;
          break;
        case IALDAMBGJGFOneofCase.KMCCKIMHBBJ:
          KMCCKIMHBBJ = other.KMCCKIMHBBJ;
          break;
        case IALDAMBGJGFOneofCase.OIGIPMEOEKB:
          OIGIPMEOEKB = other.OIGIPMEOEKB;
          break;
        case IALDAMBGJGFOneofCase.KMACDMAFFFN:
          KMACDMAFFFN = other.KMACDMAFFFN;
          break;
        case IALDAMBGJGFOneofCase.EFCCDDMNMLP:
          EFCCDDMNMLP = other.EFCCDDMNMLP;
          break;
        case IALDAMBGJGFOneofCase.EBEPHGLDCNH:
          EBEPHGLDCNH = other.EBEPHGLDCNH;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UpdatePlayerSetting Clone() {
      return new UpdatePlayerSetting(this);
    }

    /// <summary>Field number for the "MEFFKCAPBFJ" field.</summary>
    public const int MEFFKCAPBFJFieldNumber = 13;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool MEFFKCAPBFJ {
      get { return HasMEFFKCAPBFJ ? (bool) iALDAMBGJGF_ : false; }
      set {
        iALDAMBGJGF_ = value;
        iALDAMBGJGFCase_ = IALDAMBGJGFOneofCase.MEFFKCAPBFJ;
      }
    }
    /// <summary>Gets whether the "MEFFKCAPBFJ" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasMEFFKCAPBFJ {
      get { return iALDAMBGJGFCase_ == IALDAMBGJGFOneofCase.MEFFKCAPBFJ; }
    }
    /// <summary> Clears the value of the oneof if it's currently set to "MEFFKCAPBFJ" </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearMEFFKCAPBFJ() {
      if (HasMEFFKCAPBFJ) {
        ClearIALDAMBGJGF();
      }
    }

    /// <summary>Field number for the "KOFDEOAGLGK" field.</summary>
    public const int KOFDEOAGLGKFieldNumber = 12;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool KOFDEOAGLGK {
      get { return HasKOFDEOAGLGK ? (bool) iALDAMBGJGF_ : false; }
      set {
        iALDAMBGJGF_ = value;
        iALDAMBGJGFCase_ = IALDAMBGJGFOneofCase.KOFDEOAGLGK;
      }
    }
    /// <summary>Gets whether the "KOFDEOAGLGK" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasKOFDEOAGLGK {
      get { return iALDAMBGJGFCase_ == IALDAMBGJGFOneofCase.KOFDEOAGLGK; }
    }
    /// <summary> Clears the value of the oneof if it's currently set to "KOFDEOAGLGK" </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearKOFDEOAGLGK() {
      if (HasKOFDEOAGLGK) {
        ClearIALDAMBGJGF();
      }
    }

    /// <summary>Field number for the "DENFLJKHNFO" field.</summary>
    public const int DENFLJKHNFOFieldNumber = 8;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool DENFLJKHNFO {
      get { return HasDENFLJKHNFO ? (bool) iALDAMBGJGF_ : false; }
      set {
        iALDAMBGJGF_ = value;
        iALDAMBGJGFCase_ = IALDAMBGJGFOneofCase.DENFLJKHNFO;
      }
    }
    /// <summary>Gets whether the "DENFLJKHNFO" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasDENFLJKHNFO {
      get { return iALDAMBGJGFCase_ == IALDAMBGJGFOneofCase.DENFLJKHNFO; }
    }
    /// <summary> Clears the value of the oneof if it's currently set to "DENFLJKHNFO" </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearDENFLJKHNFO() {
      if (HasDENFLJKHNFO) {
        ClearIALDAMBGJGF();
      }
    }

    /// <summary>Field number for the "KHKAAPACGJF" field.</summary>
    public const int KHKAAPACGJFFieldNumber = 7;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool KHKAAPACGJF {
      get { return HasKHKAAPACGJF ? (bool) iALDAMBGJGF_ : false; }
      set {
        iALDAMBGJGF_ = value;
        iALDAMBGJGFCase_ = IALDAMBGJGFOneofCase.KHKAAPACGJF;
      }
    }
    /// <summary>Gets whether the "KHKAAPACGJF" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasKHKAAPACGJF {
      get { return iALDAMBGJGFCase_ == IALDAMBGJGFOneofCase.KHKAAPACGJF; }
    }
    /// <summary> Clears the value of the oneof if it's currently set to "KHKAAPACGJF" </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearKHKAAPACGJF() {
      if (HasKHKAAPACGJF) {
        ClearIALDAMBGJGF();
      }
    }

    /// <summary>Field number for the "KKHHCOPENGM" field.</summary>
    public const int KKHHCOPENGMFieldNumber = 6;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool KKHHCOPENGM {
      get { return HasKKHHCOPENGM ? (bool) iALDAMBGJGF_ : false; }
      set {
        iALDAMBGJGF_ = value;
        iALDAMBGJGFCase_ = IALDAMBGJGFOneofCase.KKHHCOPENGM;
      }
    }
    /// <summary>Gets whether the "KKHHCOPENGM" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasKKHHCOPENGM {
      get { return iALDAMBGJGFCase_ == IALDAMBGJGFOneofCase.KKHHCOPENGM; }
    }
    /// <summary> Clears the value of the oneof if it's currently set to "KKHHCOPENGM" </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearKKHHCOPENGM() {
      if (HasKKHHCOPENGM) {
        ClearIALDAMBGJGF();
      }
    }

    /// <summary>Field number for the "KMCCKIMHBBJ" field.</summary>
    public const int KMCCKIMHBBJFieldNumber = 11;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool KMCCKIMHBBJ {
      get { return HasKMCCKIMHBBJ ? (bool) iALDAMBGJGF_ : false; }
      set {
        iALDAMBGJGF_ = value;
        iALDAMBGJGFCase_ = IALDAMBGJGFOneofCase.KMCCKIMHBBJ;
      }
    }
    /// <summary>Gets whether the "KMCCKIMHBBJ" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasKMCCKIMHBBJ {
      get { return iALDAMBGJGFCase_ == IALDAMBGJGFOneofCase.KMCCKIMHBBJ; }
    }
    /// <summary> Clears the value of the oneof if it's currently set to "KMCCKIMHBBJ" </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearKMCCKIMHBBJ() {
      if (HasKMCCKIMHBBJ) {
        ClearIALDAMBGJGF();
      }
    }

    /// <summary>Field number for the "OIGIPMEOEKB" field.</summary>
    public const int OIGIPMEOEKBFieldNumber = 1;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool OIGIPMEOEKB {
      get { return HasOIGIPMEOEKB ? (bool) iALDAMBGJGF_ : false; }
      set {
        iALDAMBGJGF_ = value;
        iALDAMBGJGFCase_ = IALDAMBGJGFOneofCase.OIGIPMEOEKB;
      }
    }
    /// <summary>Gets whether the "OIGIPMEOEKB" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasOIGIPMEOEKB {
      get { return iALDAMBGJGFCase_ == IALDAMBGJGFOneofCase.OIGIPMEOEKB; }
    }
    /// <summary> Clears the value of the oneof if it's currently set to "OIGIPMEOEKB" </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearOIGIPMEOEKB() {
      if (HasOIGIPMEOEKB) {
        ClearIALDAMBGJGF();
      }
    }

    /// <summary>Field number for the "KMACDMAFFFN" field.</summary>
    public const int KMACDMAFFFNFieldNumber = 15;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool KMACDMAFFFN {
      get { return HasKMACDMAFFFN ? (bool) iALDAMBGJGF_ : false; }
      set {
        iALDAMBGJGF_ = value;
        iALDAMBGJGFCase_ = IALDAMBGJGFOneofCase.KMACDMAFFFN;
      }
    }
    /// <summary>Gets whether the "KMACDMAFFFN" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasKMACDMAFFFN {
      get { return iALDAMBGJGFCase_ == IALDAMBGJGFOneofCase.KMACDMAFFFN; }
    }
    /// <summary> Clears the value of the oneof if it's currently set to "KMACDMAFFFN" </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearKMACDMAFFFN() {
      if (HasKMACDMAFFFN) {
        ClearIALDAMBGJGF();
      }
    }

    /// <summary>Field number for the "EFCCDDMNMLP" field.</summary>
    public const int EFCCDDMNMLPFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool EFCCDDMNMLP {
      get { return HasEFCCDDMNMLP ? (bool) iALDAMBGJGF_ : false; }
      set {
        iALDAMBGJGF_ = value;
        iALDAMBGJGFCase_ = IALDAMBGJGFOneofCase.EFCCDDMNMLP;
      }
    }
    /// <summary>Gets whether the "EFCCDDMNMLP" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasEFCCDDMNMLP {
      get { return iALDAMBGJGFCase_ == IALDAMBGJGFOneofCase.EFCCDDMNMLP; }
    }
    /// <summary> Clears the value of the oneof if it's currently set to "EFCCDDMNMLP" </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearEFCCDDMNMLP() {
      if (HasEFCCDDMNMLP) {
        ClearIALDAMBGJGF();
      }
    }

    /// <summary>Field number for the "EBEPHGLDCNH" field.</summary>
    public const int EBEPHGLDCNHFieldNumber = 10;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool EBEPHGLDCNH {
      get { return HasEBEPHGLDCNH ? (bool) iALDAMBGJGF_ : false; }
      set {
        iALDAMBGJGF_ = value;
        iALDAMBGJGFCase_ = IALDAMBGJGFOneofCase.EBEPHGLDCNH;
      }
    }
    /// <summary>Gets whether the "EBEPHGLDCNH" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasEBEPHGLDCNH {
      get { return iALDAMBGJGFCase_ == IALDAMBGJGFOneofCase.EBEPHGLDCNH; }
    }
    /// <summary> Clears the value of the oneof if it's currently set to "EBEPHGLDCNH" </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearEBEPHGLDCNH() {
      if (HasEBEPHGLDCNH) {
        ClearIALDAMBGJGF();
      }
    }

    private object iALDAMBGJGF_;
    /// <summary>Enum of possible cases for the "IALDAMBGJGF" oneof.</summary>
    public enum IALDAMBGJGFOneofCase {
      None = 0,
      MEFFKCAPBFJ = 13,
      KOFDEOAGLGK = 12,
      DENFLJKHNFO = 8,
      KHKAAPACGJF = 7,
      KKHHCOPENGM = 6,
      KMCCKIMHBBJ = 11,
      OIGIPMEOEKB = 1,
      KMACDMAFFFN = 15,
      EFCCDDMNMLP = 2,
      EBEPHGLDCNH = 10,
    }
    private IALDAMBGJGFOneofCase iALDAMBGJGFCase_ = IALDAMBGJGFOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IALDAMBGJGFOneofCase IALDAMBGJGFCase {
      get { return iALDAMBGJGFCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearIALDAMBGJGF() {
      iALDAMBGJGFCase_ = IALDAMBGJGFOneofCase.None;
      iALDAMBGJGF_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as UpdatePlayerSetting);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(UpdatePlayerSetting other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MEFFKCAPBFJ != other.MEFFKCAPBFJ) return false;
      if (KOFDEOAGLGK != other.KOFDEOAGLGK) return false;
      if (DENFLJKHNFO != other.DENFLJKHNFO) return false;
      if (KHKAAPACGJF != other.KHKAAPACGJF) return false;
      if (KKHHCOPENGM != other.KKHHCOPENGM) return false;
      if (KMCCKIMHBBJ != other.KMCCKIMHBBJ) return false;
      if (OIGIPMEOEKB != other.OIGIPMEOEKB) return false;
      if (KMACDMAFFFN != other.KMACDMAFFFN) return false;
      if (EFCCDDMNMLP != other.EFCCDDMNMLP) return false;
      if (EBEPHGLDCNH != other.EBEPHGLDCNH) return false;
      if (IALDAMBGJGFCase != other.IALDAMBGJGFCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HasMEFFKCAPBFJ) hash ^= MEFFKCAPBFJ.GetHashCode();
      if (HasKOFDEOAGLGK) hash ^= KOFDEOAGLGK.GetHashCode();
      if (HasDENFLJKHNFO) hash ^= DENFLJKHNFO.GetHashCode();
      if (HasKHKAAPACGJF) hash ^= KHKAAPACGJF.GetHashCode();
      if (HasKKHHCOPENGM) hash ^= KKHHCOPENGM.GetHashCode();
      if (HasKMCCKIMHBBJ) hash ^= KMCCKIMHBBJ.GetHashCode();
      if (HasOIGIPMEOEKB) hash ^= OIGIPMEOEKB.GetHashCode();
      if (HasKMACDMAFFFN) hash ^= KMACDMAFFFN.GetHashCode();
      if (HasEFCCDDMNMLP) hash ^= EFCCDDMNMLP.GetHashCode();
      if (HasEBEPHGLDCNH) hash ^= EBEPHGLDCNH.GetHashCode();
      hash ^= (int) iALDAMBGJGFCase_;
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
      if (HasOIGIPMEOEKB) {
        output.WriteRawTag(8);
        output.WriteBool(OIGIPMEOEKB);
      }
      if (HasEFCCDDMNMLP) {
        output.WriteRawTag(16);
        output.WriteBool(EFCCDDMNMLP);
      }
      if (HasKKHHCOPENGM) {
        output.WriteRawTag(48);
        output.WriteBool(KKHHCOPENGM);
      }
      if (HasKHKAAPACGJF) {
        output.WriteRawTag(56);
        output.WriteBool(KHKAAPACGJF);
      }
      if (HasDENFLJKHNFO) {
        output.WriteRawTag(64);
        output.WriteBool(DENFLJKHNFO);
      }
      if (HasEBEPHGLDCNH) {
        output.WriteRawTag(80);
        output.WriteBool(EBEPHGLDCNH);
      }
      if (HasKMCCKIMHBBJ) {
        output.WriteRawTag(88);
        output.WriteBool(KMCCKIMHBBJ);
      }
      if (HasKOFDEOAGLGK) {
        output.WriteRawTag(96);
        output.WriteBool(KOFDEOAGLGK);
      }
      if (HasMEFFKCAPBFJ) {
        output.WriteRawTag(104);
        output.WriteBool(MEFFKCAPBFJ);
      }
      if (HasKMACDMAFFFN) {
        output.WriteRawTag(120);
        output.WriteBool(KMACDMAFFFN);
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
      if (HasOIGIPMEOEKB) {
        output.WriteRawTag(8);
        output.WriteBool(OIGIPMEOEKB);
      }
      if (HasEFCCDDMNMLP) {
        output.WriteRawTag(16);
        output.WriteBool(EFCCDDMNMLP);
      }
      if (HasKKHHCOPENGM) {
        output.WriteRawTag(48);
        output.WriteBool(KKHHCOPENGM);
      }
      if (HasKHKAAPACGJF) {
        output.WriteRawTag(56);
        output.WriteBool(KHKAAPACGJF);
      }
      if (HasDENFLJKHNFO) {
        output.WriteRawTag(64);
        output.WriteBool(DENFLJKHNFO);
      }
      if (HasEBEPHGLDCNH) {
        output.WriteRawTag(80);
        output.WriteBool(EBEPHGLDCNH);
      }
      if (HasKMCCKIMHBBJ) {
        output.WriteRawTag(88);
        output.WriteBool(KMCCKIMHBBJ);
      }
      if (HasKOFDEOAGLGK) {
        output.WriteRawTag(96);
        output.WriteBool(KOFDEOAGLGK);
      }
      if (HasMEFFKCAPBFJ) {
        output.WriteRawTag(104);
        output.WriteBool(MEFFKCAPBFJ);
      }
      if (HasKMACDMAFFFN) {
        output.WriteRawTag(120);
        output.WriteBool(KMACDMAFFFN);
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
      if (HasMEFFKCAPBFJ) {
        size += 1 + 1;
      }
      if (HasKOFDEOAGLGK) {
        size += 1 + 1;
      }
      if (HasDENFLJKHNFO) {
        size += 1 + 1;
      }
      if (HasKHKAAPACGJF) {
        size += 1 + 1;
      }
      if (HasKKHHCOPENGM) {
        size += 1 + 1;
      }
      if (HasKMCCKIMHBBJ) {
        size += 1 + 1;
      }
      if (HasOIGIPMEOEKB) {
        size += 1 + 1;
      }
      if (HasKMACDMAFFFN) {
        size += 1 + 1;
      }
      if (HasEFCCDDMNMLP) {
        size += 1 + 1;
      }
      if (HasEBEPHGLDCNH) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(UpdatePlayerSetting other) {
      if (other == null) {
        return;
      }
      switch (other.IALDAMBGJGFCase) {
        case IALDAMBGJGFOneofCase.MEFFKCAPBFJ:
          MEFFKCAPBFJ = other.MEFFKCAPBFJ;
          break;
        case IALDAMBGJGFOneofCase.KOFDEOAGLGK:
          KOFDEOAGLGK = other.KOFDEOAGLGK;
          break;
        case IALDAMBGJGFOneofCase.DENFLJKHNFO:
          DENFLJKHNFO = other.DENFLJKHNFO;
          break;
        case IALDAMBGJGFOneofCase.KHKAAPACGJF:
          KHKAAPACGJF = other.KHKAAPACGJF;
          break;
        case IALDAMBGJGFOneofCase.KKHHCOPENGM:
          KKHHCOPENGM = other.KKHHCOPENGM;
          break;
        case IALDAMBGJGFOneofCase.KMCCKIMHBBJ:
          KMCCKIMHBBJ = other.KMCCKIMHBBJ;
          break;
        case IALDAMBGJGFOneofCase.OIGIPMEOEKB:
          OIGIPMEOEKB = other.OIGIPMEOEKB;
          break;
        case IALDAMBGJGFOneofCase.KMACDMAFFFN:
          KMACDMAFFFN = other.KMACDMAFFFN;
          break;
        case IALDAMBGJGFOneofCase.EFCCDDMNMLP:
          EFCCDDMNMLP = other.EFCCDDMNMLP;
          break;
        case IALDAMBGJGFOneofCase.EBEPHGLDCNH:
          EBEPHGLDCNH = other.EBEPHGLDCNH;
          break;
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
            OIGIPMEOEKB = input.ReadBool();
            break;
          }
          case 16: {
            EFCCDDMNMLP = input.ReadBool();
            break;
          }
          case 48: {
            KKHHCOPENGM = input.ReadBool();
            break;
          }
          case 56: {
            KHKAAPACGJF = input.ReadBool();
            break;
          }
          case 64: {
            DENFLJKHNFO = input.ReadBool();
            break;
          }
          case 80: {
            EBEPHGLDCNH = input.ReadBool();
            break;
          }
          case 88: {
            KMCCKIMHBBJ = input.ReadBool();
            break;
          }
          case 96: {
            KOFDEOAGLGK = input.ReadBool();
            break;
          }
          case 104: {
            MEFFKCAPBFJ = input.ReadBool();
            break;
          }
          case 120: {
            KMACDMAFFFN = input.ReadBool();
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
            OIGIPMEOEKB = input.ReadBool();
            break;
          }
          case 16: {
            EFCCDDMNMLP = input.ReadBool();
            break;
          }
          case 48: {
            KKHHCOPENGM = input.ReadBool();
            break;
          }
          case 56: {
            KHKAAPACGJF = input.ReadBool();
            break;
          }
          case 64: {
            DENFLJKHNFO = input.ReadBool();
            break;
          }
          case 80: {
            EBEPHGLDCNH = input.ReadBool();
            break;
          }
          case 88: {
            KMCCKIMHBBJ = input.ReadBool();
            break;
          }
          case 96: {
            KOFDEOAGLGK = input.ReadBool();
            break;
          }
          case 104: {
            MEFFKCAPBFJ = input.ReadBool();
            break;
          }
          case 120: {
            KMACDMAFFFN = input.ReadBool();
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
