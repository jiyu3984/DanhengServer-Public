// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueTournLevel.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueTournLevel.proto</summary>
  public static partial class RogueTournLevelReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueTournLevel.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueTournLevelReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVSb2d1ZVRvdXJuTGV2ZWwucHJvdG8aGFJvZ3VlVG91cm5Sb29tTGlzdC5w",
            "cm90bxobUm9ndWVUb3VybkxheWVyU3RhdHVzLnByb3RvIqYBCg9Sb2d1ZVRv",
            "dXJuTGV2ZWwSJgoGc3RhdHVzGAYgASgOMhYuUm9ndWVUb3VybkxheWVyU3Rh",
            "dHVzEhYKDmN1cl9yb29tX2luZGV4GAwgASgNEiwKD3RvdXJuX3Jvb21fbGlz",
            "dBgFIAMoCzITLlJvZ3VlVG91cm5Sb29tTGlzdBIQCghsYXllcl9pZBgEIAEo",
            "DRITCgtsZXZlbF9pbmRleBgKIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2Vy",
            "dmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueTournRoomListReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueTournLayerStatusReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueTournLevel), global::EggLink.DanhengServer.Proto.RogueTournLevel.Parser, new[]{ "Status", "CurRoomIndex", "TournRoomList", "LayerId", "LevelIndex" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueTournLevel : pb::IMessage<RogueTournLevel>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueTournLevel> _parser = new pb::MessageParser<RogueTournLevel>(() => new RogueTournLevel());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueTournLevel> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueTournLevelReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueTournLevel() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueTournLevel(RogueTournLevel other) : this() {
      status_ = other.status_;
      curRoomIndex_ = other.curRoomIndex_;
      tournRoomList_ = other.tournRoomList_.Clone();
      layerId_ = other.layerId_;
      levelIndex_ = other.levelIndex_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueTournLevel Clone() {
      return new RogueTournLevel(this);
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 6;
    private global::EggLink.DanhengServer.Proto.RogueTournLayerStatus status_ = global::EggLink.DanhengServer.Proto.RogueTournLayerStatus.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueTournLayerStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "cur_room_index" field.</summary>
    public const int CurRoomIndexFieldNumber = 12;
    private uint curRoomIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurRoomIndex {
      get { return curRoomIndex_; }
      set {
        curRoomIndex_ = value;
      }
    }

    /// <summary>Field number for the "tourn_room_list" field.</summary>
    public const int TournRoomListFieldNumber = 5;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.RogueTournRoomList> _repeated_tournRoomList_codec
        = pb::FieldCodec.ForMessage(42, global::EggLink.DanhengServer.Proto.RogueTournRoomList.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueTournRoomList> tournRoomList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueTournRoomList>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueTournRoomList> TournRoomList {
      get { return tournRoomList_; }
    }

    /// <summary>Field number for the "layer_id" field.</summary>
    public const int LayerIdFieldNumber = 4;
    private uint layerId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LayerId {
      get { return layerId_; }
      set {
        layerId_ = value;
      }
    }

    /// <summary>Field number for the "level_index" field.</summary>
    public const int LevelIndexFieldNumber = 10;
    private uint levelIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LevelIndex {
      get { return levelIndex_; }
      set {
        levelIndex_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueTournLevel);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueTournLevel other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Status != other.Status) return false;
      if (CurRoomIndex != other.CurRoomIndex) return false;
      if(!tournRoomList_.Equals(other.tournRoomList_)) return false;
      if (LayerId != other.LayerId) return false;
      if (LevelIndex != other.LevelIndex) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Status != global::EggLink.DanhengServer.Proto.RogueTournLayerStatus.None) hash ^= Status.GetHashCode();
      if (CurRoomIndex != 0) hash ^= CurRoomIndex.GetHashCode();
      hash ^= tournRoomList_.GetHashCode();
      if (LayerId != 0) hash ^= LayerId.GetHashCode();
      if (LevelIndex != 0) hash ^= LevelIndex.GetHashCode();
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
      if (LayerId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(LayerId);
      }
      tournRoomList_.WriteTo(output, _repeated_tournRoomList_codec);
      if (Status != global::EggLink.DanhengServer.Proto.RogueTournLayerStatus.None) {
        output.WriteRawTag(48);
        output.WriteEnum((int) Status);
      }
      if (LevelIndex != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(LevelIndex);
      }
      if (CurRoomIndex != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(CurRoomIndex);
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
      if (LayerId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(LayerId);
      }
      tournRoomList_.WriteTo(ref output, _repeated_tournRoomList_codec);
      if (Status != global::EggLink.DanhengServer.Proto.RogueTournLayerStatus.None) {
        output.WriteRawTag(48);
        output.WriteEnum((int) Status);
      }
      if (LevelIndex != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(LevelIndex);
      }
      if (CurRoomIndex != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(CurRoomIndex);
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
      if (Status != global::EggLink.DanhengServer.Proto.RogueTournLayerStatus.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (CurRoomIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurRoomIndex);
      }
      size += tournRoomList_.CalculateSize(_repeated_tournRoomList_codec);
      if (LayerId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LayerId);
      }
      if (LevelIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LevelIndex);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueTournLevel other) {
      if (other == null) {
        return;
      }
      if (other.Status != global::EggLink.DanhengServer.Proto.RogueTournLayerStatus.None) {
        Status = other.Status;
      }
      if (other.CurRoomIndex != 0) {
        CurRoomIndex = other.CurRoomIndex;
      }
      tournRoomList_.Add(other.tournRoomList_);
      if (other.LayerId != 0) {
        LayerId = other.LayerId;
      }
      if (other.LevelIndex != 0) {
        LevelIndex = other.LevelIndex;
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
          case 32: {
            LayerId = input.ReadUInt32();
            break;
          }
          case 42: {
            tournRoomList_.AddEntriesFrom(input, _repeated_tournRoomList_codec);
            break;
          }
          case 48: {
            Status = (global::EggLink.DanhengServer.Proto.RogueTournLayerStatus) input.ReadEnum();
            break;
          }
          case 80: {
            LevelIndex = input.ReadUInt32();
            break;
          }
          case 96: {
            CurRoomIndex = input.ReadUInt32();
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
          case 32: {
            LayerId = input.ReadUInt32();
            break;
          }
          case 42: {
            tournRoomList_.AddEntriesFrom(ref input, _repeated_tournRoomList_codec);
            break;
          }
          case 48: {
            Status = (global::EggLink.DanhengServer.Proto.RogueTournLayerStatus) input.ReadEnum();
            break;
          }
          case 80: {
            LevelIndex = input.ReadUInt32();
            break;
          }
          case 96: {
            CurRoomIndex = input.ReadUInt32();
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
