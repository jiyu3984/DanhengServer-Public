// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MonopolyEventLoadUpdateScNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from MonopolyEventLoadUpdateScNotify.proto</summary>
  public static partial class MonopolyEventLoadUpdateScNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for MonopolyEventLoadUpdateScNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MonopolyEventLoadUpdateScNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVNb25vcG9seUV2ZW50TG9hZFVwZGF0ZVNjTm90aWZ5LnByb3RvGhFGT0tO",
            "TExLSUNFTy5wcm90byJnCh9Nb25vcG9seUV2ZW50TG9hZFVwZGF0ZVNjTm90",
            "aWZ5EiEKC0tLTUJERElCSUlQGAMgAygLMgwuRk9LTkxMS0lDRU8SIQoLSU5Q",
            "RU9JREpHSUwYASADKAsyDC5GT0tOTExLSUNFT0IeqgIbRWdnTGluay5EYW5o",
            "ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.FOKNLLKICEOReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.MonopolyEventLoadUpdateScNotify), global::EggLink.DanhengServer.Proto.MonopolyEventLoadUpdateScNotify.Parser, new[]{ "KKMBDDIBIIP", "INPEOIDJGIL" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class MonopolyEventLoadUpdateScNotify : pb::IMessage<MonopolyEventLoadUpdateScNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MonopolyEventLoadUpdateScNotify> _parser = new pb::MessageParser<MonopolyEventLoadUpdateScNotify>(() => new MonopolyEventLoadUpdateScNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MonopolyEventLoadUpdateScNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.MonopolyEventLoadUpdateScNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MonopolyEventLoadUpdateScNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MonopolyEventLoadUpdateScNotify(MonopolyEventLoadUpdateScNotify other) : this() {
      kKMBDDIBIIP_ = other.kKMBDDIBIIP_.Clone();
      iNPEOIDJGIL_ = other.iNPEOIDJGIL_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MonopolyEventLoadUpdateScNotify Clone() {
      return new MonopolyEventLoadUpdateScNotify(this);
    }

    /// <summary>Field number for the "KKMBDDIBIIP" field.</summary>
    public const int KKMBDDIBIIPFieldNumber = 3;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.FOKNLLKICEO> _repeated_kKMBDDIBIIP_codec
        = pb::FieldCodec.ForMessage(26, global::EggLink.DanhengServer.Proto.FOKNLLKICEO.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.FOKNLLKICEO> kKMBDDIBIIP_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.FOKNLLKICEO>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.FOKNLLKICEO> KKMBDDIBIIP {
      get { return kKMBDDIBIIP_; }
    }

    /// <summary>Field number for the "INPEOIDJGIL" field.</summary>
    public const int INPEOIDJGILFieldNumber = 1;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.FOKNLLKICEO> _repeated_iNPEOIDJGIL_codec
        = pb::FieldCodec.ForMessage(10, global::EggLink.DanhengServer.Proto.FOKNLLKICEO.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.FOKNLLKICEO> iNPEOIDJGIL_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.FOKNLLKICEO>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.FOKNLLKICEO> INPEOIDJGIL {
      get { return iNPEOIDJGIL_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MonopolyEventLoadUpdateScNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MonopolyEventLoadUpdateScNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!kKMBDDIBIIP_.Equals(other.kKMBDDIBIIP_)) return false;
      if(!iNPEOIDJGIL_.Equals(other.iNPEOIDJGIL_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= kKMBDDIBIIP_.GetHashCode();
      hash ^= iNPEOIDJGIL_.GetHashCode();
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
      iNPEOIDJGIL_.WriteTo(output, _repeated_iNPEOIDJGIL_codec);
      kKMBDDIBIIP_.WriteTo(output, _repeated_kKMBDDIBIIP_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      iNPEOIDJGIL_.WriteTo(ref output, _repeated_iNPEOIDJGIL_codec);
      kKMBDDIBIIP_.WriteTo(ref output, _repeated_kKMBDDIBIIP_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += kKMBDDIBIIP_.CalculateSize(_repeated_kKMBDDIBIIP_codec);
      size += iNPEOIDJGIL_.CalculateSize(_repeated_iNPEOIDJGIL_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MonopolyEventLoadUpdateScNotify other) {
      if (other == null) {
        return;
      }
      kKMBDDIBIIP_.Add(other.kKMBDDIBIIP_);
      iNPEOIDJGIL_.Add(other.iNPEOIDJGIL_);
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
          case 10: {
            iNPEOIDJGIL_.AddEntriesFrom(input, _repeated_iNPEOIDJGIL_codec);
            break;
          }
          case 26: {
            kKMBDDIBIIP_.AddEntriesFrom(input, _repeated_kKMBDDIBIIP_codec);
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
          case 10: {
            iNPEOIDJGIL_.AddEntriesFrom(ref input, _repeated_iNPEOIDJGIL_codec);
            break;
          }
          case 26: {
            kKMBDDIBIIP_.AddEntriesFrom(ref input, _repeated_kKMBDDIBIIP_codec);
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
