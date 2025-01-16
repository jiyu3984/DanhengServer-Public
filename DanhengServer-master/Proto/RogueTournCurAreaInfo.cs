// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueTournCurAreaInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueTournCurAreaInfo.proto</summary>
  public static partial class RogueTournCurAreaInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueTournCurAreaInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueTournCurAreaInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtSb2d1ZVRvdXJuQ3VyQXJlYUluZm8ucHJvdG8aHlJvZ3VlQ29tbW9uUGVu",
            "ZGluZ0FjdGlvbi5wcm90byKuAQoVUm9ndWVUb3VybkN1ckFyZWFJbmZvEhMK",
            "C3N1Yl9hcmVhX2lkGAYgASgNEjEKDnBlbmRpbmdfYWN0aW9uGAwgASgLMhku",
            "Um9ndWVDb21tb25QZW5kaW5nQWN0aW9uEhMKC1BJTk9HTkVLQ0FIGAcgASgN",
            "EiAKGHJvZ3VlX21hZ2ljX2JhdHRsZV9jb25zdBgJIAEoDRIWCg5yb2d1ZV9z",
            "dWJfbW9kZRgKIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3Rv",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueCommonPendingActionReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueTournCurAreaInfo), global::EggLink.DanhengServer.Proto.RogueTournCurAreaInfo.Parser, new[]{ "SubAreaId", "PendingAction", "PINOGNEKCAH", "RogueMagicBattleConst", "RogueSubMode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueTournCurAreaInfo : pb::IMessage<RogueTournCurAreaInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueTournCurAreaInfo> _parser = new pb::MessageParser<RogueTournCurAreaInfo>(() => new RogueTournCurAreaInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueTournCurAreaInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueTournCurAreaInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueTournCurAreaInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueTournCurAreaInfo(RogueTournCurAreaInfo other) : this() {
      subAreaId_ = other.subAreaId_;
      pendingAction_ = other.pendingAction_ != null ? other.pendingAction_.Clone() : null;
      pINOGNEKCAH_ = other.pINOGNEKCAH_;
      rogueMagicBattleConst_ = other.rogueMagicBattleConst_;
      rogueSubMode_ = other.rogueSubMode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueTournCurAreaInfo Clone() {
      return new RogueTournCurAreaInfo(this);
    }

    /// <summary>Field number for the "sub_area_id" field.</summary>
    public const int SubAreaIdFieldNumber = 6;
    private uint subAreaId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SubAreaId {
      get { return subAreaId_; }
      set {
        subAreaId_ = value;
      }
    }

    /// <summary>Field number for the "pending_action" field.</summary>
    public const int PendingActionFieldNumber = 12;
    private global::EggLink.DanhengServer.Proto.RogueCommonPendingAction pendingAction_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueCommonPendingAction PendingAction {
      get { return pendingAction_; }
      set {
        pendingAction_ = value;
      }
    }

    /// <summary>Field number for the "PINOGNEKCAH" field.</summary>
    public const int PINOGNEKCAHFieldNumber = 7;
    private uint pINOGNEKCAH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PINOGNEKCAH {
      get { return pINOGNEKCAH_; }
      set {
        pINOGNEKCAH_ = value;
      }
    }

    /// <summary>Field number for the "rogue_magic_battle_const" field.</summary>
    public const int RogueMagicBattleConstFieldNumber = 9;
    private uint rogueMagicBattleConst_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RogueMagicBattleConst {
      get { return rogueMagicBattleConst_; }
      set {
        rogueMagicBattleConst_ = value;
      }
    }

    /// <summary>Field number for the "rogue_sub_mode" field.</summary>
    public const int RogueSubModeFieldNumber = 10;
    private uint rogueSubMode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RogueSubMode {
      get { return rogueSubMode_; }
      set {
        rogueSubMode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueTournCurAreaInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueTournCurAreaInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SubAreaId != other.SubAreaId) return false;
      if (!object.Equals(PendingAction, other.PendingAction)) return false;
      if (PINOGNEKCAH != other.PINOGNEKCAH) return false;
      if (RogueMagicBattleConst != other.RogueMagicBattleConst) return false;
      if (RogueSubMode != other.RogueSubMode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (SubAreaId != 0) hash ^= SubAreaId.GetHashCode();
      if (pendingAction_ != null) hash ^= PendingAction.GetHashCode();
      if (PINOGNEKCAH != 0) hash ^= PINOGNEKCAH.GetHashCode();
      if (RogueMagicBattleConst != 0) hash ^= RogueMagicBattleConst.GetHashCode();
      if (RogueSubMode != 0) hash ^= RogueSubMode.GetHashCode();
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
      if (SubAreaId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(SubAreaId);
      }
      if (PINOGNEKCAH != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(PINOGNEKCAH);
      }
      if (RogueMagicBattleConst != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(RogueMagicBattleConst);
      }
      if (RogueSubMode != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(RogueSubMode);
      }
      if (pendingAction_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(PendingAction);
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
      if (SubAreaId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(SubAreaId);
      }
      if (PINOGNEKCAH != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(PINOGNEKCAH);
      }
      if (RogueMagicBattleConst != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(RogueMagicBattleConst);
      }
      if (RogueSubMode != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(RogueSubMode);
      }
      if (pendingAction_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(PendingAction);
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
      if (SubAreaId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SubAreaId);
      }
      if (pendingAction_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PendingAction);
      }
      if (PINOGNEKCAH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PINOGNEKCAH);
      }
      if (RogueMagicBattleConst != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RogueMagicBattleConst);
      }
      if (RogueSubMode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RogueSubMode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueTournCurAreaInfo other) {
      if (other == null) {
        return;
      }
      if (other.SubAreaId != 0) {
        SubAreaId = other.SubAreaId;
      }
      if (other.pendingAction_ != null) {
        if (pendingAction_ == null) {
          PendingAction = new global::EggLink.DanhengServer.Proto.RogueCommonPendingAction();
        }
        PendingAction.MergeFrom(other.PendingAction);
      }
      if (other.PINOGNEKCAH != 0) {
        PINOGNEKCAH = other.PINOGNEKCAH;
      }
      if (other.RogueMagicBattleConst != 0) {
        RogueMagicBattleConst = other.RogueMagicBattleConst;
      }
      if (other.RogueSubMode != 0) {
        RogueSubMode = other.RogueSubMode;
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
          case 48: {
            SubAreaId = input.ReadUInt32();
            break;
          }
          case 56: {
            PINOGNEKCAH = input.ReadUInt32();
            break;
          }
          case 72: {
            RogueMagicBattleConst = input.ReadUInt32();
            break;
          }
          case 80: {
            RogueSubMode = input.ReadUInt32();
            break;
          }
          case 98: {
            if (pendingAction_ == null) {
              PendingAction = new global::EggLink.DanhengServer.Proto.RogueCommonPendingAction();
            }
            input.ReadMessage(PendingAction);
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
          case 48: {
            SubAreaId = input.ReadUInt32();
            break;
          }
          case 56: {
            PINOGNEKCAH = input.ReadUInt32();
            break;
          }
          case 72: {
            RogueMagicBattleConst = input.ReadUInt32();
            break;
          }
          case 80: {
            RogueSubMode = input.ReadUInt32();
            break;
          }
          case 98: {
            if (pendingAction_ == null) {
              PendingAction = new global::EggLink.DanhengServer.Proto.RogueCommonPendingAction();
            }
            input.ReadMessage(PendingAction);
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