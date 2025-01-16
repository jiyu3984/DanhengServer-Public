// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChessRogueEnterNextLayerScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ChessRogueEnterNextLayerScRsp.proto</summary>
  public static partial class ChessRogueEnterNextLayerScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for ChessRogueEnterNextLayerScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChessRogueEnterNextLayerScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNDaGVzc1JvZ3VlRW50ZXJOZXh0TGF5ZXJTY1JzcC5wcm90bxobQ2hlc3NS",
            "b2d1ZUN1cnJlbnRJbmZvLnByb3RvGhRDaGVzc1JvZ3VlSW5mby5wcm90bxoY",
            "Q2hlc3NSb2d1ZUdhbWVJbmZvLnByb3RvGiVDaGVzc1JvZ3VlTGF5ZXJJbml0",
            "aWFsRXZlbnRJbmZvLnByb3RvIu4BCh1DaGVzc1JvZ3VlRW50ZXJOZXh0TGF5",
            "ZXJTY1JzcBIjCgpzdGFnZV9pbmZvGAcgASgLMg8uQ2hlc3NSb2d1ZUluZm8S",
            "LAoPcm9ndWVfZ2FtZV9pbmZvGAYgASgLMhMuQ2hlc3NSb2d1ZUdhbWVJbmZv",
            "EjIKEnJvZ3VlX2N1cnJlbnRfaW5mbxgCIAEoCzIWLkNoZXNzUm9ndWVDdXJy",
            "ZW50SW5mbxI1CgtNR0JCS0hIQUhFSBgLIAEoCzIgLkNoZXNzUm9ndWVMYXll",
            "ckluaXRpYWxFdmVudEluZm8SDwoHcmV0Y29kZRgEIAEoDUIeqgIbRWdnTGlu",
            "ay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ChessRogueCurrentInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChessRogueInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChessRogueGameInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChessRogueLayerInitialEventInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ChessRogueEnterNextLayerScRsp), global::EggLink.DanhengServer.Proto.ChessRogueEnterNextLayerScRsp.Parser, new[]{ "StageInfo", "RogueGameInfo", "RogueCurrentInfo", "MGBBKHHAHEH", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ChessRogueEnterNextLayerScRsp : pb::IMessage<ChessRogueEnterNextLayerScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChessRogueEnterNextLayerScRsp> _parser = new pb::MessageParser<ChessRogueEnterNextLayerScRsp>(() => new ChessRogueEnterNextLayerScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChessRogueEnterNextLayerScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ChessRogueEnterNextLayerScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueEnterNextLayerScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueEnterNextLayerScRsp(ChessRogueEnterNextLayerScRsp other) : this() {
      stageInfo_ = other.stageInfo_ != null ? other.stageInfo_.Clone() : null;
      rogueGameInfo_ = other.rogueGameInfo_ != null ? other.rogueGameInfo_.Clone() : null;
      rogueCurrentInfo_ = other.rogueCurrentInfo_ != null ? other.rogueCurrentInfo_.Clone() : null;
      mGBBKHHAHEH_ = other.mGBBKHHAHEH_ != null ? other.mGBBKHHAHEH_.Clone() : null;
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueEnterNextLayerScRsp Clone() {
      return new ChessRogueEnterNextLayerScRsp(this);
    }

    /// <summary>Field number for the "stage_info" field.</summary>
    public const int StageInfoFieldNumber = 7;
    private global::EggLink.DanhengServer.Proto.ChessRogueInfo stageInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueInfo StageInfo {
      get { return stageInfo_; }
      set {
        stageInfo_ = value;
      }
    }

    /// <summary>Field number for the "rogue_game_info" field.</summary>
    public const int RogueGameInfoFieldNumber = 6;
    private global::EggLink.DanhengServer.Proto.ChessRogueGameInfo rogueGameInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueGameInfo RogueGameInfo {
      get { return rogueGameInfo_; }
      set {
        rogueGameInfo_ = value;
      }
    }

    /// <summary>Field number for the "rogue_current_info" field.</summary>
    public const int RogueCurrentInfoFieldNumber = 2;
    private global::EggLink.DanhengServer.Proto.ChessRogueCurrentInfo rogueCurrentInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueCurrentInfo RogueCurrentInfo {
      get { return rogueCurrentInfo_; }
      set {
        rogueCurrentInfo_ = value;
      }
    }

    /// <summary>Field number for the "MGBBKHHAHEH" field.</summary>
    public const int MGBBKHHAHEHFieldNumber = 11;
    private global::EggLink.DanhengServer.Proto.ChessRogueLayerInitialEventInfo mGBBKHHAHEH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueLayerInitialEventInfo MGBBKHHAHEH {
      get { return mGBBKHHAHEH_; }
      set {
        mGBBKHHAHEH_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 4;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChessRogueEnterNextLayerScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChessRogueEnterNextLayerScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(StageInfo, other.StageInfo)) return false;
      if (!object.Equals(RogueGameInfo, other.RogueGameInfo)) return false;
      if (!object.Equals(RogueCurrentInfo, other.RogueCurrentInfo)) return false;
      if (!object.Equals(MGBBKHHAHEH, other.MGBBKHHAHEH)) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (stageInfo_ != null) hash ^= StageInfo.GetHashCode();
      if (rogueGameInfo_ != null) hash ^= RogueGameInfo.GetHashCode();
      if (rogueCurrentInfo_ != null) hash ^= RogueCurrentInfo.GetHashCode();
      if (mGBBKHHAHEH_ != null) hash ^= MGBBKHHAHEH.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
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
      if (rogueCurrentInfo_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(RogueCurrentInfo);
      }
      if (Retcode != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Retcode);
      }
      if (rogueGameInfo_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(RogueGameInfo);
      }
      if (stageInfo_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(StageInfo);
      }
      if (mGBBKHHAHEH_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(MGBBKHHAHEH);
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
      if (rogueCurrentInfo_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(RogueCurrentInfo);
      }
      if (Retcode != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Retcode);
      }
      if (rogueGameInfo_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(RogueGameInfo);
      }
      if (stageInfo_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(StageInfo);
      }
      if (mGBBKHHAHEH_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(MGBBKHHAHEH);
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
      if (stageInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(StageInfo);
      }
      if (rogueGameInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueGameInfo);
      }
      if (rogueCurrentInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueCurrentInfo);
      }
      if (mGBBKHHAHEH_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MGBBKHHAHEH);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChessRogueEnterNextLayerScRsp other) {
      if (other == null) {
        return;
      }
      if (other.stageInfo_ != null) {
        if (stageInfo_ == null) {
          StageInfo = new global::EggLink.DanhengServer.Proto.ChessRogueInfo();
        }
        StageInfo.MergeFrom(other.StageInfo);
      }
      if (other.rogueGameInfo_ != null) {
        if (rogueGameInfo_ == null) {
          RogueGameInfo = new global::EggLink.DanhengServer.Proto.ChessRogueGameInfo();
        }
        RogueGameInfo.MergeFrom(other.RogueGameInfo);
      }
      if (other.rogueCurrentInfo_ != null) {
        if (rogueCurrentInfo_ == null) {
          RogueCurrentInfo = new global::EggLink.DanhengServer.Proto.ChessRogueCurrentInfo();
        }
        RogueCurrentInfo.MergeFrom(other.RogueCurrentInfo);
      }
      if (other.mGBBKHHAHEH_ != null) {
        if (mGBBKHHAHEH_ == null) {
          MGBBKHHAHEH = new global::EggLink.DanhengServer.Proto.ChessRogueLayerInitialEventInfo();
        }
        MGBBKHHAHEH.MergeFrom(other.MGBBKHHAHEH);
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
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
          case 18: {
            if (rogueCurrentInfo_ == null) {
              RogueCurrentInfo = new global::EggLink.DanhengServer.Proto.ChessRogueCurrentInfo();
            }
            input.ReadMessage(RogueCurrentInfo);
            break;
          }
          case 32: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 50: {
            if (rogueGameInfo_ == null) {
              RogueGameInfo = new global::EggLink.DanhengServer.Proto.ChessRogueGameInfo();
            }
            input.ReadMessage(RogueGameInfo);
            break;
          }
          case 58: {
            if (stageInfo_ == null) {
              StageInfo = new global::EggLink.DanhengServer.Proto.ChessRogueInfo();
            }
            input.ReadMessage(StageInfo);
            break;
          }
          case 90: {
            if (mGBBKHHAHEH_ == null) {
              MGBBKHHAHEH = new global::EggLink.DanhengServer.Proto.ChessRogueLayerInitialEventInfo();
            }
            input.ReadMessage(MGBBKHHAHEH);
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
          case 18: {
            if (rogueCurrentInfo_ == null) {
              RogueCurrentInfo = new global::EggLink.DanhengServer.Proto.ChessRogueCurrentInfo();
            }
            input.ReadMessage(RogueCurrentInfo);
            break;
          }
          case 32: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 50: {
            if (rogueGameInfo_ == null) {
              RogueGameInfo = new global::EggLink.DanhengServer.Proto.ChessRogueGameInfo();
            }
            input.ReadMessage(RogueGameInfo);
            break;
          }
          case 58: {
            if (stageInfo_ == null) {
              StageInfo = new global::EggLink.DanhengServer.Proto.ChessRogueInfo();
            }
            input.ReadMessage(StageInfo);
            break;
          }
          case 90: {
            if (mGBBKHHAHEH_ == null) {
              MGBBKHHAHEH = new global::EggLink.DanhengServer.Proto.ChessRogueLayerInitialEventInfo();
            }
            input.ReadMessage(MGBBKHHAHEH);
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
