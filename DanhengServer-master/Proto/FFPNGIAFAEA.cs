// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FFPNGIAFAEA.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from FFPNGIAFAEA.proto</summary>
  public static partial class FFPNGIAFAEAReflection {

    #region Descriptor
    /// <summary>File descriptor for FFPNGIAFAEA.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FFPNGIAFAEAReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFGRlBOR0lBRkFFQS5wcm90bxocUm9ndWVNYWdpY0dhbWVVbml0SW5mby5w",
            "cm90byJQCgtGRlBOR0lBRkFFQRIsCgtQQUJOQ0VIRklQTBgEIAEoCzIXLlJv",
            "Z3VlTWFnaWNHYW1lVW5pdEluZm8SEwoLTUZOTERKQUhQSkUYCyADKA1CHqoC",
            "G0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueMagicGameUnitInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.FFPNGIAFAEA), global::EggLink.DanhengServer.Proto.FFPNGIAFAEA.Parser, new[]{ "PABNCEHFIPL", "MFNLDJAHPJE" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class FFPNGIAFAEA : pb::IMessage<FFPNGIAFAEA>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FFPNGIAFAEA> _parser = new pb::MessageParser<FFPNGIAFAEA>(() => new FFPNGIAFAEA());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FFPNGIAFAEA> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.FFPNGIAFAEAReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FFPNGIAFAEA() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FFPNGIAFAEA(FFPNGIAFAEA other) : this() {
      pABNCEHFIPL_ = other.pABNCEHFIPL_ != null ? other.pABNCEHFIPL_.Clone() : null;
      mFNLDJAHPJE_ = other.mFNLDJAHPJE_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FFPNGIAFAEA Clone() {
      return new FFPNGIAFAEA(this);
    }

    /// <summary>Field number for the "PABNCEHFIPL" field.</summary>
    public const int PABNCEHFIPLFieldNumber = 4;
    private global::EggLink.DanhengServer.Proto.RogueMagicGameUnitInfo pABNCEHFIPL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueMagicGameUnitInfo PABNCEHFIPL {
      get { return pABNCEHFIPL_; }
      set {
        pABNCEHFIPL_ = value;
      }
    }

    /// <summary>Field number for the "MFNLDJAHPJE" field.</summary>
    public const int MFNLDJAHPJEFieldNumber = 11;
    private static readonly pb::FieldCodec<uint> _repeated_mFNLDJAHPJE_codec
        = pb::FieldCodec.ForUInt32(90);
    private readonly pbc::RepeatedField<uint> mFNLDJAHPJE_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> MFNLDJAHPJE {
      get { return mFNLDJAHPJE_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FFPNGIAFAEA);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FFPNGIAFAEA other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(PABNCEHFIPL, other.PABNCEHFIPL)) return false;
      if(!mFNLDJAHPJE_.Equals(other.mFNLDJAHPJE_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (pABNCEHFIPL_ != null) hash ^= PABNCEHFIPL.GetHashCode();
      hash ^= mFNLDJAHPJE_.GetHashCode();
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
      if (pABNCEHFIPL_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(PABNCEHFIPL);
      }
      mFNLDJAHPJE_.WriteTo(output, _repeated_mFNLDJAHPJE_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (pABNCEHFIPL_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(PABNCEHFIPL);
      }
      mFNLDJAHPJE_.WriteTo(ref output, _repeated_mFNLDJAHPJE_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (pABNCEHFIPL_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PABNCEHFIPL);
      }
      size += mFNLDJAHPJE_.CalculateSize(_repeated_mFNLDJAHPJE_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FFPNGIAFAEA other) {
      if (other == null) {
        return;
      }
      if (other.pABNCEHFIPL_ != null) {
        if (pABNCEHFIPL_ == null) {
          PABNCEHFIPL = new global::EggLink.DanhengServer.Proto.RogueMagicGameUnitInfo();
        }
        PABNCEHFIPL.MergeFrom(other.PABNCEHFIPL);
      }
      mFNLDJAHPJE_.Add(other.mFNLDJAHPJE_);
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
          case 34: {
            if (pABNCEHFIPL_ == null) {
              PABNCEHFIPL = new global::EggLink.DanhengServer.Proto.RogueMagicGameUnitInfo();
            }
            input.ReadMessage(PABNCEHFIPL);
            break;
          }
          case 90:
          case 88: {
            mFNLDJAHPJE_.AddEntriesFrom(input, _repeated_mFNLDJAHPJE_codec);
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
          case 34: {
            if (pABNCEHFIPL_ == null) {
              PABNCEHFIPL = new global::EggLink.DanhengServer.Proto.RogueMagicGameUnitInfo();
            }
            input.ReadMessage(PABNCEHFIPL);
            break;
          }
          case 90:
          case 88: {
            mFNLDJAHPJE_.AddEntriesFrom(ref input, _repeated_mFNLDJAHPJE_codec);
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