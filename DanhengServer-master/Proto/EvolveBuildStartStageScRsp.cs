// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EvolveBuildStartStageScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from EvolveBuildStartStageScRsp.proto</summary>
  public static partial class EvolveBuildStartStageScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for EvolveBuildStartStageScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EvolveBuildStartStageScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBFdm9sdmVCdWlsZFN0YXJ0U3RhZ2VTY1JzcC5wcm90bxoVU2NlbmVCYXR0",
            "bGVJbmZvLnByb3RvGhpFdm9sdmVCdWlsZExldmVsSW5mby5wcm90byJ/ChpF",
            "dm9sdmVCdWlsZFN0YXJ0U3RhZ2VTY1JzcBIPCgdyZXRjb2RlGAcgASgNEiUK",
            "C0ZES0tKT0RERExGGAsgASgLMhAuU2NlbmVCYXR0bGVJbmZvEikKCmxldmVs",
            "X2luZm8YDCABKAsyFS5Fdm9sdmVCdWlsZExldmVsSW5mb0IeqgIbRWdnTGlu",
            "ay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.SceneBattleInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.EvolveBuildLevelInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.EvolveBuildStartStageScRsp), global::EggLink.DanhengServer.Proto.EvolveBuildStartStageScRsp.Parser, new[]{ "Retcode", "FDKKJODDDLF", "LevelInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class EvolveBuildStartStageScRsp : pb::IMessage<EvolveBuildStartStageScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EvolveBuildStartStageScRsp> _parser = new pb::MessageParser<EvolveBuildStartStageScRsp>(() => new EvolveBuildStartStageScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EvolveBuildStartStageScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.EvolveBuildStartStageScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvolveBuildStartStageScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvolveBuildStartStageScRsp(EvolveBuildStartStageScRsp other) : this() {
      retcode_ = other.retcode_;
      fDKKJODDDLF_ = other.fDKKJODDDLF_ != null ? other.fDKKJODDDLF_.Clone() : null;
      levelInfo_ = other.levelInfo_ != null ? other.levelInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvolveBuildStartStageScRsp Clone() {
      return new EvolveBuildStartStageScRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 7;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "FDKKJODDDLF" field.</summary>
    public const int FDKKJODDDLFFieldNumber = 11;
    private global::EggLink.DanhengServer.Proto.SceneBattleInfo fDKKJODDDLF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.SceneBattleInfo FDKKJODDDLF {
      get { return fDKKJODDDLF_; }
      set {
        fDKKJODDDLF_ = value;
      }
    }

    /// <summary>Field number for the "level_info" field.</summary>
    public const int LevelInfoFieldNumber = 12;
    private global::EggLink.DanhengServer.Proto.EvolveBuildLevelInfo levelInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.EvolveBuildLevelInfo LevelInfo {
      get { return levelInfo_; }
      set {
        levelInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EvolveBuildStartStageScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EvolveBuildStartStageScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (!object.Equals(FDKKJODDDLF, other.FDKKJODDDLF)) return false;
      if (!object.Equals(LevelInfo, other.LevelInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (fDKKJODDDLF_ != null) hash ^= FDKKJODDDLF.GetHashCode();
      if (levelInfo_ != null) hash ^= LevelInfo.GetHashCode();
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
      if (Retcode != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Retcode);
      }
      if (fDKKJODDDLF_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(FDKKJODDDLF);
      }
      if (levelInfo_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(LevelInfo);
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
      if (Retcode != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Retcode);
      }
      if (fDKKJODDDLF_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(FDKKJODDDLF);
      }
      if (levelInfo_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(LevelInfo);
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
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (fDKKJODDDLF_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FDKKJODDDLF);
      }
      if (levelInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LevelInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EvolveBuildStartStageScRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.fDKKJODDDLF_ != null) {
        if (fDKKJODDDLF_ == null) {
          FDKKJODDDLF = new global::EggLink.DanhengServer.Proto.SceneBattleInfo();
        }
        FDKKJODDDLF.MergeFrom(other.FDKKJODDDLF);
      }
      if (other.levelInfo_ != null) {
        if (levelInfo_ == null) {
          LevelInfo = new global::EggLink.DanhengServer.Proto.EvolveBuildLevelInfo();
        }
        LevelInfo.MergeFrom(other.LevelInfo);
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
          case 56: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 90: {
            if (fDKKJODDDLF_ == null) {
              FDKKJODDDLF = new global::EggLink.DanhengServer.Proto.SceneBattleInfo();
            }
            input.ReadMessage(FDKKJODDDLF);
            break;
          }
          case 98: {
            if (levelInfo_ == null) {
              LevelInfo = new global::EggLink.DanhengServer.Proto.EvolveBuildLevelInfo();
            }
            input.ReadMessage(LevelInfo);
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
          case 56: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 90: {
            if (fDKKJODDDLF_ == null) {
              FDKKJODDDLF = new global::EggLink.DanhengServer.Proto.SceneBattleInfo();
            }
            input.ReadMessage(FDKKJODDDLF);
            break;
          }
          case 98: {
            if (levelInfo_ == null) {
              LevelInfo = new global::EggLink.DanhengServer.Proto.EvolveBuildLevelInfo();
            }
            input.ReadMessage(LevelInfo);
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