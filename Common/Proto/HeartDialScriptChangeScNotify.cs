// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HeartDialScriptChangeScNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from HeartDialScriptChangeScNotify.proto</summary>
  public static partial class HeartDialScriptChangeScNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for HeartDialScriptChangeScNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HeartDialScriptChangeScNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNIZWFydERpYWxTY3JpcHRDaGFuZ2VTY05vdGlmeS5wcm90bxoRQlBBRkNF",
            "UE5PQUkucHJvdG8aEU5LRU9MTUlQR0xBLnByb3RvGhFNTERHT0xHQ0hFSS5w",
            "cm90bxoRQ0NPT0VPRURDRk4ucHJvdG8iqwEKHUhlYXJ0RGlhbFNjcmlwdENo",
            "YW5nZVNjTm90aWZ5EiEKC09IUEVOS0hLTElJGAcgAygLMgwuTUxER09MR0NI",
            "RUkSIQoLRk5MUEpOTEJITkEYCCADKAsyDC5DQ09PRU9FRENGThIhCgtNQ05G",
            "T0NNSlBCSxgMIAEoDjIMLkJQQUZDRVBOT0FJEiEKC0tIRk9MRUxFR0hJGAYg",
            "AygLMgwuTktFT0xNSVBHTEFCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Q",
            "cm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.BPAFCEPNOAIReflection.Descriptor, global::EggLink.DanhengServer.Proto.NKEOLMIPGLAReflection.Descriptor, global::EggLink.DanhengServer.Proto.MLDGOLGCHEIReflection.Descriptor, global::EggLink.DanhengServer.Proto.CCOOEOEDCFNReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.HeartDialScriptChangeScNotify), global::EggLink.DanhengServer.Proto.HeartDialScriptChangeScNotify.Parser, new[]{ "OHPENKHKLII", "FNLPJNLBHNA", "MCNFOCMJPBK", "KHFOLELEGHI" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class HeartDialScriptChangeScNotify : pb::IMessage<HeartDialScriptChangeScNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HeartDialScriptChangeScNotify> _parser = new pb::MessageParser<HeartDialScriptChangeScNotify>(() => new HeartDialScriptChangeScNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HeartDialScriptChangeScNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.HeartDialScriptChangeScNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HeartDialScriptChangeScNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HeartDialScriptChangeScNotify(HeartDialScriptChangeScNotify other) : this() {
      oHPENKHKLII_ = other.oHPENKHKLII_.Clone();
      fNLPJNLBHNA_ = other.fNLPJNLBHNA_.Clone();
      mCNFOCMJPBK_ = other.mCNFOCMJPBK_;
      kHFOLELEGHI_ = other.kHFOLELEGHI_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HeartDialScriptChangeScNotify Clone() {
      return new HeartDialScriptChangeScNotify(this);
    }

    /// <summary>Field number for the "OHPENKHKLII" field.</summary>
    public const int OHPENKHKLIIFieldNumber = 7;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.MLDGOLGCHEI> _repeated_oHPENKHKLII_codec
        = pb::FieldCodec.ForMessage(58, global::EggLink.DanhengServer.Proto.MLDGOLGCHEI.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MLDGOLGCHEI> oHPENKHKLII_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MLDGOLGCHEI>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MLDGOLGCHEI> OHPENKHKLII {
      get { return oHPENKHKLII_; }
    }

    /// <summary>Field number for the "FNLPJNLBHNA" field.</summary>
    public const int FNLPJNLBHNAFieldNumber = 8;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.CCOOEOEDCFN> _repeated_fNLPJNLBHNA_codec
        = pb::FieldCodec.ForMessage(66, global::EggLink.DanhengServer.Proto.CCOOEOEDCFN.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.CCOOEOEDCFN> fNLPJNLBHNA_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.CCOOEOEDCFN>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.CCOOEOEDCFN> FNLPJNLBHNA {
      get { return fNLPJNLBHNA_; }
    }

    /// <summary>Field number for the "MCNFOCMJPBK" field.</summary>
    public const int MCNFOCMJPBKFieldNumber = 12;
    private global::EggLink.DanhengServer.Proto.BPAFCEPNOAI mCNFOCMJPBK_ = global::EggLink.DanhengServer.Proto.BPAFCEPNOAI.HeartDialUnlockStatusLock;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.BPAFCEPNOAI MCNFOCMJPBK {
      get { return mCNFOCMJPBK_; }
      set {
        mCNFOCMJPBK_ = value;
      }
    }

    /// <summary>Field number for the "KHFOLELEGHI" field.</summary>
    public const int KHFOLELEGHIFieldNumber = 6;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.NKEOLMIPGLA> _repeated_kHFOLELEGHI_codec
        = pb::FieldCodec.ForMessage(50, global::EggLink.DanhengServer.Proto.NKEOLMIPGLA.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.NKEOLMIPGLA> kHFOLELEGHI_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.NKEOLMIPGLA>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.NKEOLMIPGLA> KHFOLELEGHI {
      get { return kHFOLELEGHI_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HeartDialScriptChangeScNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HeartDialScriptChangeScNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!oHPENKHKLII_.Equals(other.oHPENKHKLII_)) return false;
      if(!fNLPJNLBHNA_.Equals(other.fNLPJNLBHNA_)) return false;
      if (MCNFOCMJPBK != other.MCNFOCMJPBK) return false;
      if(!kHFOLELEGHI_.Equals(other.kHFOLELEGHI_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= oHPENKHKLII_.GetHashCode();
      hash ^= fNLPJNLBHNA_.GetHashCode();
      if (MCNFOCMJPBK != global::EggLink.DanhengServer.Proto.BPAFCEPNOAI.HeartDialUnlockStatusLock) hash ^= MCNFOCMJPBK.GetHashCode();
      hash ^= kHFOLELEGHI_.GetHashCode();
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
      kHFOLELEGHI_.WriteTo(output, _repeated_kHFOLELEGHI_codec);
      oHPENKHKLII_.WriteTo(output, _repeated_oHPENKHKLII_codec);
      fNLPJNLBHNA_.WriteTo(output, _repeated_fNLPJNLBHNA_codec);
      if (MCNFOCMJPBK != global::EggLink.DanhengServer.Proto.BPAFCEPNOAI.HeartDialUnlockStatusLock) {
        output.WriteRawTag(96);
        output.WriteEnum((int) MCNFOCMJPBK);
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
      kHFOLELEGHI_.WriteTo(ref output, _repeated_kHFOLELEGHI_codec);
      oHPENKHKLII_.WriteTo(ref output, _repeated_oHPENKHKLII_codec);
      fNLPJNLBHNA_.WriteTo(ref output, _repeated_fNLPJNLBHNA_codec);
      if (MCNFOCMJPBK != global::EggLink.DanhengServer.Proto.BPAFCEPNOAI.HeartDialUnlockStatusLock) {
        output.WriteRawTag(96);
        output.WriteEnum((int) MCNFOCMJPBK);
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
      size += oHPENKHKLII_.CalculateSize(_repeated_oHPENKHKLII_codec);
      size += fNLPJNLBHNA_.CalculateSize(_repeated_fNLPJNLBHNA_codec);
      if (MCNFOCMJPBK != global::EggLink.DanhengServer.Proto.BPAFCEPNOAI.HeartDialUnlockStatusLock) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) MCNFOCMJPBK);
      }
      size += kHFOLELEGHI_.CalculateSize(_repeated_kHFOLELEGHI_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HeartDialScriptChangeScNotify other) {
      if (other == null) {
        return;
      }
      oHPENKHKLII_.Add(other.oHPENKHKLII_);
      fNLPJNLBHNA_.Add(other.fNLPJNLBHNA_);
      if (other.MCNFOCMJPBK != global::EggLink.DanhengServer.Proto.BPAFCEPNOAI.HeartDialUnlockStatusLock) {
        MCNFOCMJPBK = other.MCNFOCMJPBK;
      }
      kHFOLELEGHI_.Add(other.kHFOLELEGHI_);
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
          case 50: {
            kHFOLELEGHI_.AddEntriesFrom(input, _repeated_kHFOLELEGHI_codec);
            break;
          }
          case 58: {
            oHPENKHKLII_.AddEntriesFrom(input, _repeated_oHPENKHKLII_codec);
            break;
          }
          case 66: {
            fNLPJNLBHNA_.AddEntriesFrom(input, _repeated_fNLPJNLBHNA_codec);
            break;
          }
          case 96: {
            MCNFOCMJPBK = (global::EggLink.DanhengServer.Proto.BPAFCEPNOAI) input.ReadEnum();
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
          case 50: {
            kHFOLELEGHI_.AddEntriesFrom(ref input, _repeated_kHFOLELEGHI_codec);
            break;
          }
          case 58: {
            oHPENKHKLII_.AddEntriesFrom(ref input, _repeated_oHPENKHKLII_codec);
            break;
          }
          case 66: {
            fNLPJNLBHNA_.AddEntriesFrom(ref input, _repeated_fNLPJNLBHNA_codec);
            break;
          }
          case 96: {
            MCNFOCMJPBK = (global::EggLink.DanhengServer.Proto.BPAFCEPNOAI) input.ReadEnum();
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