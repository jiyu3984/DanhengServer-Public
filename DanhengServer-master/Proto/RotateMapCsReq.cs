// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RotateMapCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RotateMapCsReq.proto</summary>
  public static partial class RotateMapCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for RotateMapCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RotateMapCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRSb3RhdGVNYXBDc1JlcS5wcm90bxoPTmV3TWFwUm90LnByb3RvGhBNb3Rp",
            "b25JbmZvLnByb3RvInMKDlJvdGF0ZU1hcENzUmVxEh0KCXJvZ3VlX21hcBgN",
            "IAEoCzIKLk5ld01hcFJvdBIQCghncm91cF9pZBgIIAEoDRITCgtGRU9GT0xO",
            "TkxERxgEIAEoDRIbCgZtb3Rpb24YDyABKAsyCy5Nb3Rpb25JbmZvQh6qAhtF",
            "Z2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.NewMapRotReflection.Descriptor, global::EggLink.DanhengServer.Proto.MotionInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RotateMapCsReq), global::EggLink.DanhengServer.Proto.RotateMapCsReq.Parser, new[]{ "RogueMap", "GroupId", "FEOFOLNNLDG", "Motion" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RotateMapCsReq : pb::IMessage<RotateMapCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RotateMapCsReq> _parser = new pb::MessageParser<RotateMapCsReq>(() => new RotateMapCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RotateMapCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RotateMapCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RotateMapCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RotateMapCsReq(RotateMapCsReq other) : this() {
      rogueMap_ = other.rogueMap_ != null ? other.rogueMap_.Clone() : null;
      groupId_ = other.groupId_;
      fEOFOLNNLDG_ = other.fEOFOLNNLDG_;
      motion_ = other.motion_ != null ? other.motion_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RotateMapCsReq Clone() {
      return new RotateMapCsReq(this);
    }

    /// <summary>Field number for the "rogue_map" field.</summary>
    public const int RogueMapFieldNumber = 13;
    private global::EggLink.DanhengServer.Proto.NewMapRot rogueMap_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.NewMapRot RogueMap {
      get { return rogueMap_; }
      set {
        rogueMap_ = value;
      }
    }

    /// <summary>Field number for the "group_id" field.</summary>
    public const int GroupIdFieldNumber = 8;
    private uint groupId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GroupId {
      get { return groupId_; }
      set {
        groupId_ = value;
      }
    }

    /// <summary>Field number for the "FEOFOLNNLDG" field.</summary>
    public const int FEOFOLNNLDGFieldNumber = 4;
    private uint fEOFOLNNLDG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FEOFOLNNLDG {
      get { return fEOFOLNNLDG_; }
      set {
        fEOFOLNNLDG_ = value;
      }
    }

    /// <summary>Field number for the "motion" field.</summary>
    public const int MotionFieldNumber = 15;
    private global::EggLink.DanhengServer.Proto.MotionInfo motion_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.MotionInfo Motion {
      get { return motion_; }
      set {
        motion_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RotateMapCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RotateMapCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(RogueMap, other.RogueMap)) return false;
      if (GroupId != other.GroupId) return false;
      if (FEOFOLNNLDG != other.FEOFOLNNLDG) return false;
      if (!object.Equals(Motion, other.Motion)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (rogueMap_ != null) hash ^= RogueMap.GetHashCode();
      if (GroupId != 0) hash ^= GroupId.GetHashCode();
      if (FEOFOLNNLDG != 0) hash ^= FEOFOLNNLDG.GetHashCode();
      if (motion_ != null) hash ^= Motion.GetHashCode();
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
      if (FEOFOLNNLDG != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(FEOFOLNNLDG);
      }
      if (GroupId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(GroupId);
      }
      if (rogueMap_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(RogueMap);
      }
      if (motion_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(Motion);
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
      if (FEOFOLNNLDG != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(FEOFOLNNLDG);
      }
      if (GroupId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(GroupId);
      }
      if (rogueMap_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(RogueMap);
      }
      if (motion_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(Motion);
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
      if (rogueMap_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueMap);
      }
      if (GroupId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GroupId);
      }
      if (FEOFOLNNLDG != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FEOFOLNNLDG);
      }
      if (motion_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Motion);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RotateMapCsReq other) {
      if (other == null) {
        return;
      }
      if (other.rogueMap_ != null) {
        if (rogueMap_ == null) {
          RogueMap = new global::EggLink.DanhengServer.Proto.NewMapRot();
        }
        RogueMap.MergeFrom(other.RogueMap);
      }
      if (other.GroupId != 0) {
        GroupId = other.GroupId;
      }
      if (other.FEOFOLNNLDG != 0) {
        FEOFOLNNLDG = other.FEOFOLNNLDG;
      }
      if (other.motion_ != null) {
        if (motion_ == null) {
          Motion = new global::EggLink.DanhengServer.Proto.MotionInfo();
        }
        Motion.MergeFrom(other.Motion);
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
            FEOFOLNNLDG = input.ReadUInt32();
            break;
          }
          case 64: {
            GroupId = input.ReadUInt32();
            break;
          }
          case 106: {
            if (rogueMap_ == null) {
              RogueMap = new global::EggLink.DanhengServer.Proto.NewMapRot();
            }
            input.ReadMessage(RogueMap);
            break;
          }
          case 122: {
            if (motion_ == null) {
              Motion = new global::EggLink.DanhengServer.Proto.MotionInfo();
            }
            input.ReadMessage(Motion);
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
            FEOFOLNNLDG = input.ReadUInt32();
            break;
          }
          case 64: {
            GroupId = input.ReadUInt32();
            break;
          }
          case 106: {
            if (rogueMap_ == null) {
              RogueMap = new global::EggLink.DanhengServer.Proto.NewMapRot();
            }
            input.ReadMessage(RogueMap);
            break;
          }
          case 122: {
            if (motion_ == null) {
              Motion = new global::EggLink.DanhengServer.Proto.MotionInfo();
            }
            input.ReadMessage(Motion);
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
