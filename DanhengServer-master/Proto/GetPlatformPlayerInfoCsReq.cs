// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetPlatformPlayerInfoCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetPlatformPlayerInfoCsReq.proto</summary>
  public static partial class GetPlatformPlayerInfoCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for GetPlatformPlayerInfoCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetPlatformPlayerInfoCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBHZXRQbGF0Zm9ybVBsYXllckluZm9Dc1JlcS5wcm90bxoSUGxhdGZvcm1U",
            "eXBlLnByb3RvIlIKGkdldFBsYXRmb3JtUGxheWVySW5mb0NzUmVxEh8KCHBs",
            "YXRmb3JtGAUgASgOMg0uUGxhdGZvcm1UeXBlEhMKC05EQkNEREtLTkZDGAcg",
            "AygJQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.PlatformTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetPlatformPlayerInfoCsReq), global::EggLink.DanhengServer.Proto.GetPlatformPlayerInfoCsReq.Parser, new[]{ "Platform", "NDBCDDKKNFC" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetPlatformPlayerInfoCsReq : pb::IMessage<GetPlatformPlayerInfoCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetPlatformPlayerInfoCsReq> _parser = new pb::MessageParser<GetPlatformPlayerInfoCsReq>(() => new GetPlatformPlayerInfoCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetPlatformPlayerInfoCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetPlatformPlayerInfoCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetPlatformPlayerInfoCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetPlatformPlayerInfoCsReq(GetPlatformPlayerInfoCsReq other) : this() {
      platform_ = other.platform_;
      nDBCDDKKNFC_ = other.nDBCDDKKNFC_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetPlatformPlayerInfoCsReq Clone() {
      return new GetPlatformPlayerInfoCsReq(this);
    }

    /// <summary>Field number for the "platform" field.</summary>
    public const int PlatformFieldNumber = 5;
    private global::EggLink.DanhengServer.Proto.PlatformType platform_ = global::EggLink.DanhengServer.Proto.PlatformType.Editor;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.PlatformType Platform {
      get { return platform_; }
      set {
        platform_ = value;
      }
    }

    /// <summary>Field number for the "NDBCDDKKNFC" field.</summary>
    public const int NDBCDDKKNFCFieldNumber = 7;
    private static readonly pb::FieldCodec<string> _repeated_nDBCDDKKNFC_codec
        = pb::FieldCodec.ForString(58);
    private readonly pbc::RepeatedField<string> nDBCDDKKNFC_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> NDBCDDKKNFC {
      get { return nDBCDDKKNFC_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetPlatformPlayerInfoCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetPlatformPlayerInfoCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Platform != other.Platform) return false;
      if(!nDBCDDKKNFC_.Equals(other.nDBCDDKKNFC_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Platform != global::EggLink.DanhengServer.Proto.PlatformType.Editor) hash ^= Platform.GetHashCode();
      hash ^= nDBCDDKKNFC_.GetHashCode();
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
      if (Platform != global::EggLink.DanhengServer.Proto.PlatformType.Editor) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Platform);
      }
      nDBCDDKKNFC_.WriteTo(output, _repeated_nDBCDDKKNFC_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Platform != global::EggLink.DanhengServer.Proto.PlatformType.Editor) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Platform);
      }
      nDBCDDKKNFC_.WriteTo(ref output, _repeated_nDBCDDKKNFC_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Platform != global::EggLink.DanhengServer.Proto.PlatformType.Editor) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Platform);
      }
      size += nDBCDDKKNFC_.CalculateSize(_repeated_nDBCDDKKNFC_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetPlatformPlayerInfoCsReq other) {
      if (other == null) {
        return;
      }
      if (other.Platform != global::EggLink.DanhengServer.Proto.PlatformType.Editor) {
        Platform = other.Platform;
      }
      nDBCDDKKNFC_.Add(other.nDBCDDKKNFC_);
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
            Platform = (global::EggLink.DanhengServer.Proto.PlatformType) input.ReadEnum();
            break;
          }
          case 58: {
            nDBCDDKKNFC_.AddEntriesFrom(input, _repeated_nDBCDDKKNFC_codec);
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
            Platform = (global::EggLink.DanhengServer.Proto.PlatformType) input.ReadEnum();
            break;
          }
          case 58: {
            nDBCDDKKNFC_.AddEntriesFrom(ref input, _repeated_nDBCDDKKNFC_codec);
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
