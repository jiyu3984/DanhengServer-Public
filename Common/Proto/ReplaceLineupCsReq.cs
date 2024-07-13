// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ReplaceLineupCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ReplaceLineupCsReq.proto</summary>
  public static partial class ReplaceLineupCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for ReplaceLineupCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ReplaceLineupCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhSZXBsYWNlTGluZXVwQ3NSZXEucHJvdG8aFExpbmV1cFNsb3REYXRhLnBy",
            "b3RvGhVFeHRyYUxpbmV1cFR5cGUucHJvdG8i0gEKElJlcGxhY2VMaW5ldXBD",
            "c1JlcRINCgVpbmRleBgPIAEoDRIrChFleHRyYV9saW5ldXBfdHlwZRgJIAEo",
            "DjIQLkV4dHJhTGluZXVwVHlwZRIQCghwbGFuZV9pZBgHIAEoDRIaChJnYW1l",
            "X3N0b3J5X2xpbmVfaWQYBiABKA0SEwoLbGVhZGVyX3Nsb3QYDCABKA0SEgoK",
            "aXNfdmlydHVhbBgIIAEoCBIpChBsaW5ldXBfc2xvdF9saXN0GAMgAygLMg8u",
            "TGluZXVwU2xvdERhdGFCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90",
            "b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.LineupSlotDataReflection.Descriptor, global::EggLink.DanhengServer.Proto.ExtraLineupTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ReplaceLineupCsReq), global::EggLink.DanhengServer.Proto.ReplaceLineupCsReq.Parser, new[]{ "Index", "ExtraLineupType", "PlaneId", "GameStoryLineId", "LeaderSlot", "IsVirtual", "LineupSlotList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ReplaceLineupCsReq : pb::IMessage<ReplaceLineupCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ReplaceLineupCsReq> _parser = new pb::MessageParser<ReplaceLineupCsReq>(() => new ReplaceLineupCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ReplaceLineupCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ReplaceLineupCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ReplaceLineupCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ReplaceLineupCsReq(ReplaceLineupCsReq other) : this() {
      index_ = other.index_;
      extraLineupType_ = other.extraLineupType_;
      planeId_ = other.planeId_;
      gameStoryLineId_ = other.gameStoryLineId_;
      leaderSlot_ = other.leaderSlot_;
      isVirtual_ = other.isVirtual_;
      lineupSlotList_ = other.lineupSlotList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ReplaceLineupCsReq Clone() {
      return new ReplaceLineupCsReq(this);
    }

    /// <summary>Field number for the "index" field.</summary>
    public const int IndexFieldNumber = 15;
    private uint index_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Index {
      get { return index_; }
      set {
        index_ = value;
      }
    }

    /// <summary>Field number for the "extra_lineup_type" field.</summary>
    public const int ExtraLineupTypeFieldNumber = 9;
    private global::EggLink.DanhengServer.Proto.ExtraLineupType extraLineupType_ = global::EggLink.DanhengServer.Proto.ExtraLineupType.LineupNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ExtraLineupType ExtraLineupType {
      get { return extraLineupType_; }
      set {
        extraLineupType_ = value;
      }
    }

    /// <summary>Field number for the "plane_id" field.</summary>
    public const int PlaneIdFieldNumber = 7;
    private uint planeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PlaneId {
      get { return planeId_; }
      set {
        planeId_ = value;
      }
    }

    /// <summary>Field number for the "game_story_line_id" field.</summary>
    public const int GameStoryLineIdFieldNumber = 6;
    private uint gameStoryLineId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GameStoryLineId {
      get { return gameStoryLineId_; }
      set {
        gameStoryLineId_ = value;
      }
    }

    /// <summary>Field number for the "leader_slot" field.</summary>
    public const int LeaderSlotFieldNumber = 12;
    private uint leaderSlot_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LeaderSlot {
      get { return leaderSlot_; }
      set {
        leaderSlot_ = value;
      }
    }

    /// <summary>Field number for the "is_virtual" field.</summary>
    public const int IsVirtualFieldNumber = 8;
    private bool isVirtual_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsVirtual {
      get { return isVirtual_; }
      set {
        isVirtual_ = value;
      }
    }

    /// <summary>Field number for the "lineup_slot_list" field.</summary>
    public const int LineupSlotListFieldNumber = 3;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.LineupSlotData> _repeated_lineupSlotList_codec
        = pb::FieldCodec.ForMessage(26, global::EggLink.DanhengServer.Proto.LineupSlotData.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.LineupSlotData> lineupSlotList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.LineupSlotData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.LineupSlotData> LineupSlotList {
      get { return lineupSlotList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ReplaceLineupCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ReplaceLineupCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Index != other.Index) return false;
      if (ExtraLineupType != other.ExtraLineupType) return false;
      if (PlaneId != other.PlaneId) return false;
      if (GameStoryLineId != other.GameStoryLineId) return false;
      if (LeaderSlot != other.LeaderSlot) return false;
      if (IsVirtual != other.IsVirtual) return false;
      if(!lineupSlotList_.Equals(other.lineupSlotList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Index != 0) hash ^= Index.GetHashCode();
      if (ExtraLineupType != global::EggLink.DanhengServer.Proto.ExtraLineupType.LineupNone) hash ^= ExtraLineupType.GetHashCode();
      if (PlaneId != 0) hash ^= PlaneId.GetHashCode();
      if (GameStoryLineId != 0) hash ^= GameStoryLineId.GetHashCode();
      if (LeaderSlot != 0) hash ^= LeaderSlot.GetHashCode();
      if (IsVirtual != false) hash ^= IsVirtual.GetHashCode();
      hash ^= lineupSlotList_.GetHashCode();
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
      lineupSlotList_.WriteTo(output, _repeated_lineupSlotList_codec);
      if (GameStoryLineId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(GameStoryLineId);
      }
      if (PlaneId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(PlaneId);
      }
      if (IsVirtual != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsVirtual);
      }
      if (ExtraLineupType != global::EggLink.DanhengServer.Proto.ExtraLineupType.LineupNone) {
        output.WriteRawTag(72);
        output.WriteEnum((int) ExtraLineupType);
      }
      if (LeaderSlot != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(LeaderSlot);
      }
      if (Index != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Index);
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
      lineupSlotList_.WriteTo(ref output, _repeated_lineupSlotList_codec);
      if (GameStoryLineId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(GameStoryLineId);
      }
      if (PlaneId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(PlaneId);
      }
      if (IsVirtual != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsVirtual);
      }
      if (ExtraLineupType != global::EggLink.DanhengServer.Proto.ExtraLineupType.LineupNone) {
        output.WriteRawTag(72);
        output.WriteEnum((int) ExtraLineupType);
      }
      if (LeaderSlot != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(LeaderSlot);
      }
      if (Index != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Index);
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
      if (Index != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Index);
      }
      if (ExtraLineupType != global::EggLink.DanhengServer.Proto.ExtraLineupType.LineupNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ExtraLineupType);
      }
      if (PlaneId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PlaneId);
      }
      if (GameStoryLineId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GameStoryLineId);
      }
      if (LeaderSlot != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LeaderSlot);
      }
      if (IsVirtual != false) {
        size += 1 + 1;
      }
      size += lineupSlotList_.CalculateSize(_repeated_lineupSlotList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ReplaceLineupCsReq other) {
      if (other == null) {
        return;
      }
      if (other.Index != 0) {
        Index = other.Index;
      }
      if (other.ExtraLineupType != global::EggLink.DanhengServer.Proto.ExtraLineupType.LineupNone) {
        ExtraLineupType = other.ExtraLineupType;
      }
      if (other.PlaneId != 0) {
        PlaneId = other.PlaneId;
      }
      if (other.GameStoryLineId != 0) {
        GameStoryLineId = other.GameStoryLineId;
      }
      if (other.LeaderSlot != 0) {
        LeaderSlot = other.LeaderSlot;
      }
      if (other.IsVirtual != false) {
        IsVirtual = other.IsVirtual;
      }
      lineupSlotList_.Add(other.lineupSlotList_);
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
            lineupSlotList_.AddEntriesFrom(input, _repeated_lineupSlotList_codec);
            break;
          }
          case 48: {
            GameStoryLineId = input.ReadUInt32();
            break;
          }
          case 56: {
            PlaneId = input.ReadUInt32();
            break;
          }
          case 64: {
            IsVirtual = input.ReadBool();
            break;
          }
          case 72: {
            ExtraLineupType = (global::EggLink.DanhengServer.Proto.ExtraLineupType) input.ReadEnum();
            break;
          }
          case 96: {
            LeaderSlot = input.ReadUInt32();
            break;
          }
          case 120: {
            Index = input.ReadUInt32();
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
            lineupSlotList_.AddEntriesFrom(ref input, _repeated_lineupSlotList_codec);
            break;
          }
          case 48: {
            GameStoryLineId = input.ReadUInt32();
            break;
          }
          case 56: {
            PlaneId = input.ReadUInt32();
            break;
          }
          case 64: {
            IsVirtual = input.ReadBool();
            break;
          }
          case 72: {
            ExtraLineupType = (global::EggLink.DanhengServer.Proto.ExtraLineupType) input.ReadEnum();
            break;
          }
          case 96: {
            LeaderSlot = input.ReadUInt32();
            break;
          }
          case 120: {
            Index = input.ReadUInt32();
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