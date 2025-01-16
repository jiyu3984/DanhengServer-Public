// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueMagicStartCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueMagicStartCsReq.proto</summary>
  public static partial class RogueMagicStartCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueMagicStartCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueMagicStartCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpSb2d1ZU1hZ2ljU3RhcnRDc1JlcS5wcm90byKBAQoUUm9ndWVNYWdpY1N0",
            "YXJ0Q3NSZXESDwoHYXJlYV9pZBgKIAEoDRIgChhzdGFydF9kaWZmaWN1bHR5",
            "X2lkX2xpc3QYAyADKA0SGwoTYmFzZV9hdmF0YXJfaWRfbGlzdBgOIAMoDRIZ",
            "ChFzZWxlY3Rfc3R5bGVfdHlwZRgIIAEoDUIeqgIbRWdnTGluay5EYW5oZW5n",
            "U2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueMagicStartCsReq), global::EggLink.DanhengServer.Proto.RogueMagicStartCsReq.Parser, new[]{ "AreaId", "StartDifficultyIdList", "BaseAvatarIdList", "SelectStyleType" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueMagicStartCsReq : pb::IMessage<RogueMagicStartCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueMagicStartCsReq> _parser = new pb::MessageParser<RogueMagicStartCsReq>(() => new RogueMagicStartCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueMagicStartCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueMagicStartCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueMagicStartCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueMagicStartCsReq(RogueMagicStartCsReq other) : this() {
      areaId_ = other.areaId_;
      startDifficultyIdList_ = other.startDifficultyIdList_.Clone();
      baseAvatarIdList_ = other.baseAvatarIdList_.Clone();
      selectStyleType_ = other.selectStyleType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueMagicStartCsReq Clone() {
      return new RogueMagicStartCsReq(this);
    }

    /// <summary>Field number for the "area_id" field.</summary>
    public const int AreaIdFieldNumber = 10;
    private uint areaId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AreaId {
      get { return areaId_; }
      set {
        areaId_ = value;
      }
    }

    /// <summary>Field number for the "start_difficulty_id_list" field.</summary>
    public const int StartDifficultyIdListFieldNumber = 3;
    private static readonly pb::FieldCodec<uint> _repeated_startDifficultyIdList_codec
        = pb::FieldCodec.ForUInt32(26);
    private readonly pbc::RepeatedField<uint> startDifficultyIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> StartDifficultyIdList {
      get { return startDifficultyIdList_; }
    }

    /// <summary>Field number for the "base_avatar_id_list" field.</summary>
    public const int BaseAvatarIdListFieldNumber = 14;
    private static readonly pb::FieldCodec<uint> _repeated_baseAvatarIdList_codec
        = pb::FieldCodec.ForUInt32(114);
    private readonly pbc::RepeatedField<uint> baseAvatarIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> BaseAvatarIdList {
      get { return baseAvatarIdList_; }
    }

    /// <summary>Field number for the "select_style_type" field.</summary>
    public const int SelectStyleTypeFieldNumber = 8;
    private uint selectStyleType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SelectStyleType {
      get { return selectStyleType_; }
      set {
        selectStyleType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueMagicStartCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueMagicStartCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AreaId != other.AreaId) return false;
      if(!startDifficultyIdList_.Equals(other.startDifficultyIdList_)) return false;
      if(!baseAvatarIdList_.Equals(other.baseAvatarIdList_)) return false;
      if (SelectStyleType != other.SelectStyleType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (AreaId != 0) hash ^= AreaId.GetHashCode();
      hash ^= startDifficultyIdList_.GetHashCode();
      hash ^= baseAvatarIdList_.GetHashCode();
      if (SelectStyleType != 0) hash ^= SelectStyleType.GetHashCode();
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
      startDifficultyIdList_.WriteTo(output, _repeated_startDifficultyIdList_codec);
      if (SelectStyleType != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(SelectStyleType);
      }
      if (AreaId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(AreaId);
      }
      baseAvatarIdList_.WriteTo(output, _repeated_baseAvatarIdList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      startDifficultyIdList_.WriteTo(ref output, _repeated_startDifficultyIdList_codec);
      if (SelectStyleType != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(SelectStyleType);
      }
      if (AreaId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(AreaId);
      }
      baseAvatarIdList_.WriteTo(ref output, _repeated_baseAvatarIdList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (AreaId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AreaId);
      }
      size += startDifficultyIdList_.CalculateSize(_repeated_startDifficultyIdList_codec);
      size += baseAvatarIdList_.CalculateSize(_repeated_baseAvatarIdList_codec);
      if (SelectStyleType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SelectStyleType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueMagicStartCsReq other) {
      if (other == null) {
        return;
      }
      if (other.AreaId != 0) {
        AreaId = other.AreaId;
      }
      startDifficultyIdList_.Add(other.startDifficultyIdList_);
      baseAvatarIdList_.Add(other.baseAvatarIdList_);
      if (other.SelectStyleType != 0) {
        SelectStyleType = other.SelectStyleType;
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
          case 26:
          case 24: {
            startDifficultyIdList_.AddEntriesFrom(input, _repeated_startDifficultyIdList_codec);
            break;
          }
          case 64: {
            SelectStyleType = input.ReadUInt32();
            break;
          }
          case 80: {
            AreaId = input.ReadUInt32();
            break;
          }
          case 114:
          case 112: {
            baseAvatarIdList_.AddEntriesFrom(input, _repeated_baseAvatarIdList_codec);
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
          case 26:
          case 24: {
            startDifficultyIdList_.AddEntriesFrom(ref input, _repeated_startDifficultyIdList_codec);
            break;
          }
          case 64: {
            SelectStyleType = input.ReadUInt32();
            break;
          }
          case 80: {
            AreaId = input.ReadUInt32();
            break;
          }
          case 114:
          case 112: {
            baseAvatarIdList_.AddEntriesFrom(ref input, _repeated_baseAvatarIdList_codec);
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
