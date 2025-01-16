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
            "ChpHZXRTY2VuZU1hcEluZm9Dc1JlcS5wcm90byKKAQoUR2V0U2NlbmVNYXBJ",
            "bmZvQ3NSZXESFQoNZmxvb3JfaWRfbGlzdBgNIAMoDRIbChNlbnRyeV9zdG9y",
            "eV9saW5lX2lkGAwgASgNEhMKC1BOQkZES0VOT0pQGAggASgIEhUKDWVudHJ5",
            "X2lkX2xpc3QYBSADKA0SEgoKY29udGVudF9pZBgJIAEoDUIeqgIbRWdnTGlu",
            "ay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetSceneMapInfoCsReq), global::EggLink.DanhengServer.Proto.GetSceneMapInfoCsReq.Parser, new[]{ "FloorIdList", "EntryStoryLineId", "PNBFDKENOJP", "EntryIdList", "ContentId" }, null, null, null, null)
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
      floorIdList_ = other.floorIdList_.Clone();
      entryStoryLineId_ = other.entryStoryLineId_;
      pNBFDKENOJP_ = other.pNBFDKENOJP_;
      entryIdList_ = other.entryIdList_.Clone();
      contentId_ = other.contentId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetSceneMapInfoCsReq Clone() {
      return new GetSceneMapInfoCsReq(this);
    }

    /// <summary>Field number for the "floor_id_list" field.</summary>
    public const int FloorIdListFieldNumber = 13;
    private static readonly pb::FieldCodec<uint> _repeated_floorIdList_codec
        = pb::FieldCodec.ForUInt32(106);
    private readonly pbc::RepeatedField<uint> floorIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> FloorIdList {
      get { return floorIdList_; }
    }

    /// <summary>Field number for the "entry_story_line_id" field.</summary>
    public const int EntryStoryLineIdFieldNumber = 12;
    private uint entryStoryLineId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntryStoryLineId {
      get { return entryStoryLineId_; }
      set {
        entryStoryLineId_ = value;
      }
    }

    /// <summary>Field number for the "PNBFDKENOJP" field.</summary>
    public const int PNBFDKENOJPFieldNumber = 8;
    private bool pNBFDKENOJP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool PNBFDKENOJP {
      get { return pNBFDKENOJP_; }
      set {
        pNBFDKENOJP_ = value;
      }
    }

    /// <summary>Field number for the "entry_id_list" field.</summary>
    public const int EntryIdListFieldNumber = 5;
    private static readonly pb::FieldCodec<uint> _repeated_entryIdList_codec
        = pb::FieldCodec.ForUInt32(42);
    private readonly pbc::RepeatedField<uint> entryIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> EntryIdList {
      get { return entryIdList_; }
    }

    /// <summary>Field number for the "content_id" field.</summary>
    public const int ContentIdFieldNumber = 9;
    private uint contentId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ContentId {
      get { return contentId_; }
      set {
        contentId_ = value;
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
      if(!floorIdList_.Equals(other.floorIdList_)) return false;
      if (EntryStoryLineId != other.EntryStoryLineId) return false;
      if (PNBFDKENOJP != other.PNBFDKENOJP) return false;
      if(!entryIdList_.Equals(other.entryIdList_)) return false;
      if (ContentId != other.ContentId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= floorIdList_.GetHashCode();
      if (EntryStoryLineId != 0) hash ^= EntryStoryLineId.GetHashCode();
      if (PNBFDKENOJP != false) hash ^= PNBFDKENOJP.GetHashCode();
      hash ^= entryIdList_.GetHashCode();
      if (ContentId != 0) hash ^= ContentId.GetHashCode();
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
      if (PNBFDKENOJP != false) {
        output.WriteRawTag(64);
        output.WriteBool(PNBFDKENOJP);
      }
      if (ContentId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(ContentId);
      }
      if (EntryStoryLineId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(EntryStoryLineId);
      }
      floorIdList_.WriteTo(output, _repeated_floorIdList_codec);
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
      if (PNBFDKENOJP != false) {
        output.WriteRawTag(64);
        output.WriteBool(PNBFDKENOJP);
      }
      if (ContentId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(ContentId);
      }
      if (EntryStoryLineId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(EntryStoryLineId);
      }
      floorIdList_.WriteTo(ref output, _repeated_floorIdList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += floorIdList_.CalculateSize(_repeated_floorIdList_codec);
      if (EntryStoryLineId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntryStoryLineId);
      }
      if (PNBFDKENOJP != false) {
        size += 1 + 1;
      }
      size += entryIdList_.CalculateSize(_repeated_entryIdList_codec);
      if (ContentId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ContentId);
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
      floorIdList_.Add(other.floorIdList_);
      if (other.EntryStoryLineId != 0) {
        EntryStoryLineId = other.EntryStoryLineId;
      }
      if (other.PNBFDKENOJP != false) {
        PNBFDKENOJP = other.PNBFDKENOJP;
      }
      entryIdList_.Add(other.entryIdList_);
      if (other.ContentId != 0) {
        ContentId = other.ContentId;
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
          case 42:
          case 40: {
            entryIdList_.AddEntriesFrom(input, _repeated_entryIdList_codec);
            break;
          }
          case 64: {
            PNBFDKENOJP = input.ReadBool();
            break;
          }
          case 72: {
            ContentId = input.ReadUInt32();
            break;
          }
          case 96: {
            EntryStoryLineId = input.ReadUInt32();
            break;
          }
          case 106:
          case 104: {
            floorIdList_.AddEntriesFrom(input, _repeated_floorIdList_codec);
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
          case 42:
          case 40: {
            entryIdList_.AddEntriesFrom(ref input, _repeated_entryIdList_codec);
            break;
          }
          case 64: {
            PNBFDKENOJP = input.ReadBool();
            break;
          }
          case 72: {
            ContentId = input.ReadUInt32();
            break;
          }
          case 96: {
            EntryStoryLineId = input.ReadUInt32();
            break;
          }
          case 106:
          case 104: {
            floorIdList_.AddEntriesFrom(ref input, _repeated_floorIdList_codec);
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