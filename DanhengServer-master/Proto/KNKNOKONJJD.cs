// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: KNKNOKONJJD.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from KNKNOKONJJD.proto</summary>
  public static partial class KNKNOKONJJDReflection {

    #region Descriptor
    /// <summary>File descriptor for KNKNOKONJJD.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static KNKNOKONJJDReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFLTktOT0tPTkpKRC5wcm90bxoUTG9naXN0aWNzU2NvcmUucHJvdG8aEVBH",
            "RUxISENJSURQLnByb3RvGhFHRkRDTUVCR0NISS5wcm90byKOAQoLS05LTk9L",
            "T05KSkQSIQoLS0NPSE1NQkxDR0gYCyADKAsyDC5HRkRDTUVCR0NISRIhCgtD",
            "SUlIRklHSkxCShgDIAMoCzIMLlBHRUxISENJSURQEhMKC0RFSUZJRU1DS0xE",
            "GA4gAygNEiQKC0hIRE9PTUpMR0dDGAUgAygLMg8uTG9naXN0aWNzU2NvcmVC",
            "HqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.LogisticsScoreReflection.Descriptor, global::EggLink.DanhengServer.Proto.PGELHHCIIDPReflection.Descriptor, global::EggLink.DanhengServer.Proto.GFDCMEBGCHIReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.KNKNOKONJJD), global::EggLink.DanhengServer.Proto.KNKNOKONJJD.Parser, new[]{ "KCOHMMBLCGH", "CIIHFIGJLBJ", "DEIFIEMCKLD", "HHDOOMJLGGC" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class KNKNOKONJJD : pb::IMessage<KNKNOKONJJD>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<KNKNOKONJJD> _parser = new pb::MessageParser<KNKNOKONJJD>(() => new KNKNOKONJJD());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<KNKNOKONJJD> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.KNKNOKONJJDReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KNKNOKONJJD() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KNKNOKONJJD(KNKNOKONJJD other) : this() {
      kCOHMMBLCGH_ = other.kCOHMMBLCGH_.Clone();
      cIIHFIGJLBJ_ = other.cIIHFIGJLBJ_.Clone();
      dEIFIEMCKLD_ = other.dEIFIEMCKLD_.Clone();
      hHDOOMJLGGC_ = other.hHDOOMJLGGC_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KNKNOKONJJD Clone() {
      return new KNKNOKONJJD(this);
    }

    /// <summary>Field number for the "KCOHMMBLCGH" field.</summary>
    public const int KCOHMMBLCGHFieldNumber = 11;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.GFDCMEBGCHI> _repeated_kCOHMMBLCGH_codec
        = pb::FieldCodec.ForMessage(90, global::EggLink.DanhengServer.Proto.GFDCMEBGCHI.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.GFDCMEBGCHI> kCOHMMBLCGH_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.GFDCMEBGCHI>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.GFDCMEBGCHI> KCOHMMBLCGH {
      get { return kCOHMMBLCGH_; }
    }

    /// <summary>Field number for the "CIIHFIGJLBJ" field.</summary>
    public const int CIIHFIGJLBJFieldNumber = 3;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.PGELHHCIIDP> _repeated_cIIHFIGJLBJ_codec
        = pb::FieldCodec.ForMessage(26, global::EggLink.DanhengServer.Proto.PGELHHCIIDP.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.PGELHHCIIDP> cIIHFIGJLBJ_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.PGELHHCIIDP>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.PGELHHCIIDP> CIIHFIGJLBJ {
      get { return cIIHFIGJLBJ_; }
    }

    /// <summary>Field number for the "DEIFIEMCKLD" field.</summary>
    public const int DEIFIEMCKLDFieldNumber = 14;
    private static readonly pb::FieldCodec<uint> _repeated_dEIFIEMCKLD_codec
        = pb::FieldCodec.ForUInt32(114);
    private readonly pbc::RepeatedField<uint> dEIFIEMCKLD_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> DEIFIEMCKLD {
      get { return dEIFIEMCKLD_; }
    }

    /// <summary>Field number for the "HHDOOMJLGGC" field.</summary>
    public const int HHDOOMJLGGCFieldNumber = 5;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.LogisticsScore> _repeated_hHDOOMJLGGC_codec
        = pb::FieldCodec.ForMessage(42, global::EggLink.DanhengServer.Proto.LogisticsScore.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.LogisticsScore> hHDOOMJLGGC_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.LogisticsScore>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.LogisticsScore> HHDOOMJLGGC {
      get { return hHDOOMJLGGC_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as KNKNOKONJJD);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(KNKNOKONJJD other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!kCOHMMBLCGH_.Equals(other.kCOHMMBLCGH_)) return false;
      if(!cIIHFIGJLBJ_.Equals(other.cIIHFIGJLBJ_)) return false;
      if(!dEIFIEMCKLD_.Equals(other.dEIFIEMCKLD_)) return false;
      if(!hHDOOMJLGGC_.Equals(other.hHDOOMJLGGC_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= kCOHMMBLCGH_.GetHashCode();
      hash ^= cIIHFIGJLBJ_.GetHashCode();
      hash ^= dEIFIEMCKLD_.GetHashCode();
      hash ^= hHDOOMJLGGC_.GetHashCode();
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
      cIIHFIGJLBJ_.WriteTo(output, _repeated_cIIHFIGJLBJ_codec);
      hHDOOMJLGGC_.WriteTo(output, _repeated_hHDOOMJLGGC_codec);
      kCOHMMBLCGH_.WriteTo(output, _repeated_kCOHMMBLCGH_codec);
      dEIFIEMCKLD_.WriteTo(output, _repeated_dEIFIEMCKLD_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      cIIHFIGJLBJ_.WriteTo(ref output, _repeated_cIIHFIGJLBJ_codec);
      hHDOOMJLGGC_.WriteTo(ref output, _repeated_hHDOOMJLGGC_codec);
      kCOHMMBLCGH_.WriteTo(ref output, _repeated_kCOHMMBLCGH_codec);
      dEIFIEMCKLD_.WriteTo(ref output, _repeated_dEIFIEMCKLD_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += kCOHMMBLCGH_.CalculateSize(_repeated_kCOHMMBLCGH_codec);
      size += cIIHFIGJLBJ_.CalculateSize(_repeated_cIIHFIGJLBJ_codec);
      size += dEIFIEMCKLD_.CalculateSize(_repeated_dEIFIEMCKLD_codec);
      size += hHDOOMJLGGC_.CalculateSize(_repeated_hHDOOMJLGGC_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(KNKNOKONJJD other) {
      if (other == null) {
        return;
      }
      kCOHMMBLCGH_.Add(other.kCOHMMBLCGH_);
      cIIHFIGJLBJ_.Add(other.cIIHFIGJLBJ_);
      dEIFIEMCKLD_.Add(other.dEIFIEMCKLD_);
      hHDOOMJLGGC_.Add(other.hHDOOMJLGGC_);
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
          case 26: {
            cIIHFIGJLBJ_.AddEntriesFrom(input, _repeated_cIIHFIGJLBJ_codec);
            break;
          }
          case 42: {
            hHDOOMJLGGC_.AddEntriesFrom(input, _repeated_hHDOOMJLGGC_codec);
            break;
          }
          case 90: {
            kCOHMMBLCGH_.AddEntriesFrom(input, _repeated_kCOHMMBLCGH_codec);
            break;
          }
          case 114:
          case 112: {
            dEIFIEMCKLD_.AddEntriesFrom(input, _repeated_dEIFIEMCKLD_codec);
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
          case 26: {
            cIIHFIGJLBJ_.AddEntriesFrom(ref input, _repeated_cIIHFIGJLBJ_codec);
            break;
          }
          case 42: {
            hHDOOMJLGGC_.AddEntriesFrom(ref input, _repeated_hHDOOMJLGGC_codec);
            break;
          }
          case 90: {
            kCOHMMBLCGH_.AddEntriesFrom(ref input, _repeated_kCOHMMBLCGH_codec);
            break;
          }
          case 114:
          case 112: {
            dEIFIEMCKLD_.AddEntriesFrom(ref input, _repeated_dEIFIEMCKLD_codec);
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
