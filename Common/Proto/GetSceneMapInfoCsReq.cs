// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetSceneMapInfoCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetSceneMapInfoCsReq.proto</summary>
  public static partial class GetSceneMapInfoCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for GetSceneMapInfoCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetSceneMapInfoCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpHZXRTY2VuZU1hcEluZm9Dc1JlcS5wcm90byJpChRHZXRTY2VuZU1hcElu",
            "Zm9Dc1JlcRITCgtDR0lJSUVLSURKRRgEIAEoDRIQCghlbnRyeV9pZBgJIAEo",
            "DRIVCg1lbnRyeV9pZF9saXN0GAIgAygNEhMKC0JES0dQR0JORk5OGAcgASgI",
            "Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetSceneMapInfoCsReq), global::EggLink.DanhengServer.Proto.GetSceneMapInfoCsReq.Parser, new[]{ "CGIIIEKIDJE", "EntryId", "EntryIdList", "BDKGPGBNFNN" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetSceneMapInfoCsReq : pb::IMessage<GetSceneMapInfoCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetSceneMapInfoCsReq> _parser = new pb::MessageParser<GetSceneMapInfoCsReq>(() => new GetSceneMapInfoCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetSceneMapInfoCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetSceneMapInfoCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetSceneMapInfoCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetSceneMapInfoCsReq(GetSceneMapInfoCsReq other) : this() {
      cGIIIEKIDJE_ = other.cGIIIEKIDJE_;
      entryId_ = other.entryId_;
      entryIdList_ = other.entryIdList_.Clone();
      bDKGPGBNFNN_ = other.bDKGPGBNFNN_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetSceneMapInfoCsReq Clone() {
      return new GetSceneMapInfoCsReq(this);
    }

    /// <summary>Field number for the "CGIIIEKIDJE" field.</summary>
    public const int CGIIIEKIDJEFieldNumber = 4;
    private uint cGIIIEKIDJE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CGIIIEKIDJE {
      get { return cGIIIEKIDJE_; }
      set {
        cGIIIEKIDJE_ = value;
      }
    }

    /// <summary>Field number for the "entry_id" field.</summary>
    public const int EntryIdFieldNumber = 9;
    private uint entryId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntryId {
      get { return entryId_; }
      set {
        entryId_ = value;
      }
    }

    /// <summary>Field number for the "entry_id_list" field.</summary>
    public const int EntryIdListFieldNumber = 2;
    private static readonly pb::FieldCodec<uint> _repeated_entryIdList_codec
        = pb::FieldCodec.ForUInt32(18);
    private readonly pbc::RepeatedField<uint> entryIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> EntryIdList {
      get { return entryIdList_; }
    }

    /// <summary>Field number for the "BDKGPGBNFNN" field.</summary>
    public const int BDKGPGBNFNNFieldNumber = 7;
    private bool bDKGPGBNFNN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool BDKGPGBNFNN {
      get { return bDKGPGBNFNN_; }
      set {
        bDKGPGBNFNN_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetSceneMapInfoCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetSceneMapInfoCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CGIIIEKIDJE != other.CGIIIEKIDJE) return false;
      if (EntryId != other.EntryId) return false;
      if(!entryIdList_.Equals(other.entryIdList_)) return false;
      if (BDKGPGBNFNN != other.BDKGPGBNFNN) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CGIIIEKIDJE != 0) hash ^= CGIIIEKIDJE.GetHashCode();
      if (EntryId != 0) hash ^= EntryId.GetHashCode();
      hash ^= entryIdList_.GetHashCode();
      if (BDKGPGBNFNN != false) hash ^= BDKGPGBNFNN.GetHashCode();
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
      entryIdList_.WriteTo(output, _repeated_entryIdList_codec);
      if (CGIIIEKIDJE != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(CGIIIEKIDJE);
      }
      if (BDKGPGBNFNN != false) {
        output.WriteRawTag(56);
        output.WriteBool(BDKGPGBNFNN);
      }
      if (EntryId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(EntryId);
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
      entryIdList_.WriteTo(ref output, _repeated_entryIdList_codec);
      if (CGIIIEKIDJE != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(CGIIIEKIDJE);
      }
      if (BDKGPGBNFNN != false) {
        output.WriteRawTag(56);
        output.WriteBool(BDKGPGBNFNN);
      }
      if (EntryId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(EntryId);
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
      if (CGIIIEKIDJE != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CGIIIEKIDJE);
      }
      if (EntryId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntryId);
      }
      size += entryIdList_.CalculateSize(_repeated_entryIdList_codec);
      if (BDKGPGBNFNN != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetSceneMapInfoCsReq other) {
      if (other == null) {
        return;
      }
      if (other.CGIIIEKIDJE != 0) {
        CGIIIEKIDJE = other.CGIIIEKIDJE;
      }
      if (other.EntryId != 0) {
        EntryId = other.EntryId;
      }
      entryIdList_.Add(other.entryIdList_);
      if (other.BDKGPGBNFNN != false) {
        BDKGPGBNFNN = other.BDKGPGBNFNN;
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
          case 18:
          case 16: {
            entryIdList_.AddEntriesFrom(input, _repeated_entryIdList_codec);
            break;
          }
          case 32: {
            CGIIIEKIDJE = input.ReadUInt32();
            break;
          }
          case 56: {
            BDKGPGBNFNN = input.ReadBool();
            break;
          }
          case 72: {
            EntryId = input.ReadUInt32();
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
          case 18:
          case 16: {
            entryIdList_.AddEntriesFrom(ref input, _repeated_entryIdList_codec);
            break;
          }
          case 32: {
            CGIIIEKIDJE = input.ReadUInt32();
            break;
          }
          case 56: {
            BDKGPGBNFNN = input.ReadBool();
            break;
          }
          case 72: {
            EntryId = input.ReadUInt32();
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