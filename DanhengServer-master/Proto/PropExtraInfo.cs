// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PropExtraInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from PropExtraInfo.proto</summary>
  public static partial class PropExtraInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for PropExtraInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PropExtraInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNQcm9wRXh0cmFJbmZvLnByb3RvGh1Sb2d1ZVRvdXJuV29ya2JlbmNoSW5m",
            "by5wcm90bxoSUHJvcEFlb25JbmZvLnByb3RvGhNQcm9wUm9ndWVJbmZvLnBy",
            "b3RvGhxSb2d1ZUdhbWJsZU1hY2hpbmVJbmZvLnByb3RvGhhQcm9wQ2hlc3NS",
            "b2d1ZUluZm8ucHJvdG8aGFJvZ3VlTWFnaWNEb29ySW5mby5wcm90bxoYUm9n",
            "dWVUb3VybkRvb3JJbmZvLnByb3RvGhlSb2d1ZUN1cnNlQ2hlc3RJbmZvLnBy",
            "b3RvIpwDCg1Qcm9wRXh0cmFJbmZvEiIKCnJvZ3VlX2luZm8YDyABKAsyDi5Q",
            "cm9wUm9ndWVJbmZvEiAKCWFlb25faW5mbxgIIAEoCzINLlByb3BBZW9uSW5m",
            "bxItChBjaGVzc19yb2d1ZV9pbmZvGAYgASgLMhMuUHJvcENoZXNzUm9ndWVJ",
            "bmZvEjIKFXJvZ3VlX3RvdXJuX2Rvb3JfaW5mbxgCIAEoCzITLlJvZ3VlVG91",
            "cm5Eb29ySW5mbxI8Chpyb2d1ZV90b3Vybl93b3JrYmVuY2hfaW5mbxgLIAEo",
            "CzIYLlJvZ3VlVG91cm5Xb3JrYmVuY2hJbmZvEjoKGXJvZ3VlX2dhbWJsZV9t",
            "YWNoaW5lX2luZm8YASABKAsyFy5Sb2d1ZUdhbWJsZU1hY2hpbmVJbmZvEjQK",
            "FnJvZ3VlX2N1cnNlX2NoZXN0X2luZm8YCSABKAsyFC5Sb2d1ZUN1cnNlQ2hl",
            "c3RJbmZvEjIKFXJvZ3VlX21hZ2ljX2Rvb3JfaW5mbxgOIAEoCzITLlJvZ3Vl",
            "TWFnaWNEb29ySW5mb0IeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3Rv",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueTournWorkbenchInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.PropAeonInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.PropRogueInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueGambleMachineInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.PropChessRogueInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueMagicDoorInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueTournDoorInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueCurseChestInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.PropExtraInfo), global::EggLink.DanhengServer.Proto.PropExtraInfo.Parser, new[]{ "RogueInfo", "AeonInfo", "ChessRogueInfo", "RogueTournDoorInfo", "RogueTournWorkbenchInfo", "RogueGambleMachineInfo", "RogueCurseChestInfo", "RogueMagicDoorInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class PropExtraInfo : pb::IMessage<PropExtraInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PropExtraInfo> _parser = new pb::MessageParser<PropExtraInfo>(() => new PropExtraInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PropExtraInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.PropExtraInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PropExtraInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PropExtraInfo(PropExtraInfo other) : this() {
      rogueInfo_ = other.rogueInfo_ != null ? other.rogueInfo_.Clone() : null;
      aeonInfo_ = other.aeonInfo_ != null ? other.aeonInfo_.Clone() : null;
      chessRogueInfo_ = other.chessRogueInfo_ != null ? other.chessRogueInfo_.Clone() : null;
      rogueTournDoorInfo_ = other.rogueTournDoorInfo_ != null ? other.rogueTournDoorInfo_.Clone() : null;
      rogueTournWorkbenchInfo_ = other.rogueTournWorkbenchInfo_ != null ? other.rogueTournWorkbenchInfo_.Clone() : null;
      rogueGambleMachineInfo_ = other.rogueGambleMachineInfo_ != null ? other.rogueGambleMachineInfo_.Clone() : null;
      rogueCurseChestInfo_ = other.rogueCurseChestInfo_ != null ? other.rogueCurseChestInfo_.Clone() : null;
      rogueMagicDoorInfo_ = other.rogueMagicDoorInfo_ != null ? other.rogueMagicDoorInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PropExtraInfo Clone() {
      return new PropExtraInfo(this);
    }

    /// <summary>Field number for the "rogue_info" field.</summary>
    public const int RogueInfoFieldNumber = 15;
    private global::EggLink.DanhengServer.Proto.PropRogueInfo rogueInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.PropRogueInfo RogueInfo {
      get { return rogueInfo_; }
      set {
        rogueInfo_ = value;
      }
    }

    /// <summary>Field number for the "aeon_info" field.</summary>
    public const int AeonInfoFieldNumber = 8;
    private global::EggLink.DanhengServer.Proto.PropAeonInfo aeonInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.PropAeonInfo AeonInfo {
      get { return aeonInfo_; }
      set {
        aeonInfo_ = value;
      }
    }

    /// <summary>Field number for the "chess_rogue_info" field.</summary>
    public const int ChessRogueInfoFieldNumber = 6;
    private global::EggLink.DanhengServer.Proto.PropChessRogueInfo chessRogueInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.PropChessRogueInfo ChessRogueInfo {
      get { return chessRogueInfo_; }
      set {
        chessRogueInfo_ = value;
      }
    }

    /// <summary>Field number for the "rogue_tourn_door_info" field.</summary>
    public const int RogueTournDoorInfoFieldNumber = 2;
    private global::EggLink.DanhengServer.Proto.RogueTournDoorInfo rogueTournDoorInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueTournDoorInfo RogueTournDoorInfo {
      get { return rogueTournDoorInfo_; }
      set {
        rogueTournDoorInfo_ = value;
      }
    }

    /// <summary>Field number for the "rogue_tourn_workbench_info" field.</summary>
    public const int RogueTournWorkbenchInfoFieldNumber = 11;
    private global::EggLink.DanhengServer.Proto.RogueTournWorkbenchInfo rogueTournWorkbenchInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueTournWorkbenchInfo RogueTournWorkbenchInfo {
      get { return rogueTournWorkbenchInfo_; }
      set {
        rogueTournWorkbenchInfo_ = value;
      }
    }

    /// <summary>Field number for the "rogue_gamble_machine_info" field.</summary>
    public const int RogueGambleMachineInfoFieldNumber = 1;
    private global::EggLink.DanhengServer.Proto.RogueGambleMachineInfo rogueGambleMachineInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueGambleMachineInfo RogueGambleMachineInfo {
      get { return rogueGambleMachineInfo_; }
      set {
        rogueGambleMachineInfo_ = value;
      }
    }

    /// <summary>Field number for the "rogue_curse_chest_info" field.</summary>
    public const int RogueCurseChestInfoFieldNumber = 9;
    private global::EggLink.DanhengServer.Proto.RogueCurseChestInfo rogueCurseChestInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueCurseChestInfo RogueCurseChestInfo {
      get { return rogueCurseChestInfo_; }
      set {
        rogueCurseChestInfo_ = value;
      }
    }

    /// <summary>Field number for the "rogue_magic_door_info" field.</summary>
    public const int RogueMagicDoorInfoFieldNumber = 14;
    private global::EggLink.DanhengServer.Proto.RogueMagicDoorInfo rogueMagicDoorInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueMagicDoorInfo RogueMagicDoorInfo {
      get { return rogueMagicDoorInfo_; }
      set {
        rogueMagicDoorInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PropExtraInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PropExtraInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(RogueInfo, other.RogueInfo)) return false;
      if (!object.Equals(AeonInfo, other.AeonInfo)) return false;
      if (!object.Equals(ChessRogueInfo, other.ChessRogueInfo)) return false;
      if (!object.Equals(RogueTournDoorInfo, other.RogueTournDoorInfo)) return false;
      if (!object.Equals(RogueTournWorkbenchInfo, other.RogueTournWorkbenchInfo)) return false;
      if (!object.Equals(RogueGambleMachineInfo, other.RogueGambleMachineInfo)) return false;
      if (!object.Equals(RogueCurseChestInfo, other.RogueCurseChestInfo)) return false;
      if (!object.Equals(RogueMagicDoorInfo, other.RogueMagicDoorInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (rogueInfo_ != null) hash ^= RogueInfo.GetHashCode();
      if (aeonInfo_ != null) hash ^= AeonInfo.GetHashCode();
      if (chessRogueInfo_ != null) hash ^= ChessRogueInfo.GetHashCode();
      if (rogueTournDoorInfo_ != null) hash ^= RogueTournDoorInfo.GetHashCode();
      if (rogueTournWorkbenchInfo_ != null) hash ^= RogueTournWorkbenchInfo.GetHashCode();
      if (rogueGambleMachineInfo_ != null) hash ^= RogueGambleMachineInfo.GetHashCode();
      if (rogueCurseChestInfo_ != null) hash ^= RogueCurseChestInfo.GetHashCode();
      if (rogueMagicDoorInfo_ != null) hash ^= RogueMagicDoorInfo.GetHashCode();
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
      if (rogueGambleMachineInfo_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(RogueGambleMachineInfo);
      }
      if (rogueTournDoorInfo_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(RogueTournDoorInfo);
      }
      if (chessRogueInfo_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(ChessRogueInfo);
      }
      if (aeonInfo_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(AeonInfo);
      }
      if (rogueCurseChestInfo_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(RogueCurseChestInfo);
      }
      if (rogueTournWorkbenchInfo_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(RogueTournWorkbenchInfo);
      }
      if (rogueMagicDoorInfo_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(RogueMagicDoorInfo);
      }
      if (rogueInfo_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(RogueInfo);
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
      if (rogueGambleMachineInfo_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(RogueGambleMachineInfo);
      }
      if (rogueTournDoorInfo_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(RogueTournDoorInfo);
      }
      if (chessRogueInfo_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(ChessRogueInfo);
      }
      if (aeonInfo_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(AeonInfo);
      }
      if (rogueCurseChestInfo_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(RogueCurseChestInfo);
      }
      if (rogueTournWorkbenchInfo_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(RogueTournWorkbenchInfo);
      }
      if (rogueMagicDoorInfo_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(RogueMagicDoorInfo);
      }
      if (rogueInfo_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(RogueInfo);
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
      if (rogueInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueInfo);
      }
      if (aeonInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AeonInfo);
      }
      if (chessRogueInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ChessRogueInfo);
      }
      if (rogueTournDoorInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueTournDoorInfo);
      }
      if (rogueTournWorkbenchInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueTournWorkbenchInfo);
      }
      if (rogueGambleMachineInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueGambleMachineInfo);
      }
      if (rogueCurseChestInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueCurseChestInfo);
      }
      if (rogueMagicDoorInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueMagicDoorInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PropExtraInfo other) {
      if (other == null) {
        return;
      }
      if (other.rogueInfo_ != null) {
        if (rogueInfo_ == null) {
          RogueInfo = new global::EggLink.DanhengServer.Proto.PropRogueInfo();
        }
        RogueInfo.MergeFrom(other.RogueInfo);
      }
      if (other.aeonInfo_ != null) {
        if (aeonInfo_ == null) {
          AeonInfo = new global::EggLink.DanhengServer.Proto.PropAeonInfo();
        }
        AeonInfo.MergeFrom(other.AeonInfo);
      }
      if (other.chessRogueInfo_ != null) {
        if (chessRogueInfo_ == null) {
          ChessRogueInfo = new global::EggLink.DanhengServer.Proto.PropChessRogueInfo();
        }
        ChessRogueInfo.MergeFrom(other.ChessRogueInfo);
      }
      if (other.rogueTournDoorInfo_ != null) {
        if (rogueTournDoorInfo_ == null) {
          RogueTournDoorInfo = new global::EggLink.DanhengServer.Proto.RogueTournDoorInfo();
        }
        RogueTournDoorInfo.MergeFrom(other.RogueTournDoorInfo);
      }
      if (other.rogueTournWorkbenchInfo_ != null) {
        if (rogueTournWorkbenchInfo_ == null) {
          RogueTournWorkbenchInfo = new global::EggLink.DanhengServer.Proto.RogueTournWorkbenchInfo();
        }
        RogueTournWorkbenchInfo.MergeFrom(other.RogueTournWorkbenchInfo);
      }
      if (other.rogueGambleMachineInfo_ != null) {
        if (rogueGambleMachineInfo_ == null) {
          RogueGambleMachineInfo = new global::EggLink.DanhengServer.Proto.RogueGambleMachineInfo();
        }
        RogueGambleMachineInfo.MergeFrom(other.RogueGambleMachineInfo);
      }
      if (other.rogueCurseChestInfo_ != null) {
        if (rogueCurseChestInfo_ == null) {
          RogueCurseChestInfo = new global::EggLink.DanhengServer.Proto.RogueCurseChestInfo();
        }
        RogueCurseChestInfo.MergeFrom(other.RogueCurseChestInfo);
      }
      if (other.rogueMagicDoorInfo_ != null) {
        if (rogueMagicDoorInfo_ == null) {
          RogueMagicDoorInfo = new global::EggLink.DanhengServer.Proto.RogueMagicDoorInfo();
        }
        RogueMagicDoorInfo.MergeFrom(other.RogueMagicDoorInfo);
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
          case 10: {
            if (rogueGambleMachineInfo_ == null) {
              RogueGambleMachineInfo = new global::EggLink.DanhengServer.Proto.RogueGambleMachineInfo();
            }
            input.ReadMessage(RogueGambleMachineInfo);
            break;
          }
          case 18: {
            if (rogueTournDoorInfo_ == null) {
              RogueTournDoorInfo = new global::EggLink.DanhengServer.Proto.RogueTournDoorInfo();
            }
            input.ReadMessage(RogueTournDoorInfo);
            break;
          }
          case 50: {
            if (chessRogueInfo_ == null) {
              ChessRogueInfo = new global::EggLink.DanhengServer.Proto.PropChessRogueInfo();
            }
            input.ReadMessage(ChessRogueInfo);
            break;
          }
          case 66: {
            if (aeonInfo_ == null) {
              AeonInfo = new global::EggLink.DanhengServer.Proto.PropAeonInfo();
            }
            input.ReadMessage(AeonInfo);
            break;
          }
          case 74: {
            if (rogueCurseChestInfo_ == null) {
              RogueCurseChestInfo = new global::EggLink.DanhengServer.Proto.RogueCurseChestInfo();
            }
            input.ReadMessage(RogueCurseChestInfo);
            break;
          }
          case 90: {
            if (rogueTournWorkbenchInfo_ == null) {
              RogueTournWorkbenchInfo = new global::EggLink.DanhengServer.Proto.RogueTournWorkbenchInfo();
            }
            input.ReadMessage(RogueTournWorkbenchInfo);
            break;
          }
          case 114: {
            if (rogueMagicDoorInfo_ == null) {
              RogueMagicDoorInfo = new global::EggLink.DanhengServer.Proto.RogueMagicDoorInfo();
            }
            input.ReadMessage(RogueMagicDoorInfo);
            break;
          }
          case 122: {
            if (rogueInfo_ == null) {
              RogueInfo = new global::EggLink.DanhengServer.Proto.PropRogueInfo();
            }
            input.ReadMessage(RogueInfo);
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
            if (rogueGambleMachineInfo_ == null) {
              RogueGambleMachineInfo = new global::EggLink.DanhengServer.Proto.RogueGambleMachineInfo();
            }
            input.ReadMessage(RogueGambleMachineInfo);
            break;
          }
          case 18: {
            if (rogueTournDoorInfo_ == null) {
              RogueTournDoorInfo = new global::EggLink.DanhengServer.Proto.RogueTournDoorInfo();
            }
            input.ReadMessage(RogueTournDoorInfo);
            break;
          }
          case 50: {
            if (chessRogueInfo_ == null) {
              ChessRogueInfo = new global::EggLink.DanhengServer.Proto.PropChessRogueInfo();
            }
            input.ReadMessage(ChessRogueInfo);
            break;
          }
          case 66: {
            if (aeonInfo_ == null) {
              AeonInfo = new global::EggLink.DanhengServer.Proto.PropAeonInfo();
            }
            input.ReadMessage(AeonInfo);
            break;
          }
          case 74: {
            if (rogueCurseChestInfo_ == null) {
              RogueCurseChestInfo = new global::EggLink.DanhengServer.Proto.RogueCurseChestInfo();
            }
            input.ReadMessage(RogueCurseChestInfo);
            break;
          }
          case 90: {
            if (rogueTournWorkbenchInfo_ == null) {
              RogueTournWorkbenchInfo = new global::EggLink.DanhengServer.Proto.RogueTournWorkbenchInfo();
            }
            input.ReadMessage(RogueTournWorkbenchInfo);
            break;
          }
          case 114: {
            if (rogueMagicDoorInfo_ == null) {
              RogueMagicDoorInfo = new global::EggLink.DanhengServer.Proto.RogueMagicDoorInfo();
            }
            input.ReadMessage(RogueMagicDoorInfo);
            break;
          }
          case 122: {
            if (rogueInfo_ == null) {
              RogueInfo = new global::EggLink.DanhengServer.Proto.PropRogueInfo();
            }
            input.ReadMessage(RogueInfo);
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
