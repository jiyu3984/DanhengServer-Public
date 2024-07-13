// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChessRogueLayerAccountInfoNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ChessRogueLayerAccountInfoNotify.proto</summary>
  public static partial class ChessRogueLayerAccountInfoNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for ChessRogueLayerAccountInfoNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChessRogueLayerAccountInfoNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZDaGVzc1JvZ3VlTGF5ZXJBY2NvdW50SW5mb05vdGlmeS5wcm90bxoaQ2hl",
            "c3NSb2d1ZUZpbmlzaEluZm8ucHJvdG8aGUNoZXNzUm9ndWVMZXZlbEluZm8u",
            "cHJvdG8ivgEKIENoZXNzUm9ndWVMYXllckFjY291bnRJbmZvTm90aWZ5EioK",
            "C2ZpbmlzaF9pbmZvGAcgASgLMhUuQ2hlc3NSb2d1ZUZpbmlzaEluZm8SHQoV",
            "YXJlYV9kaWZmaWN1bHR5X2xldmVsGAkgASgNEhMKC0VOUEdQQUxQQ0RMGAsg",
            "AygNEigKCmxldmVsX2luZm8YDCABKAsyFC5DaGVzc1JvZ3VlTGV2ZWxJbmZv",
            "EhAKCGxheWVyX2lkGAEgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIu",
            "UHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ChessRogueFinishInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChessRogueLevelInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ChessRogueLayerAccountInfoNotify), global::EggLink.DanhengServer.Proto.ChessRogueLayerAccountInfoNotify.Parser, new[]{ "FinishInfo", "AreaDifficultyLevel", "ENPGPALPCDL", "LevelInfo", "LayerId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ChessRogueLayerAccountInfoNotify : pb::IMessage<ChessRogueLayerAccountInfoNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChessRogueLayerAccountInfoNotify> _parser = new pb::MessageParser<ChessRogueLayerAccountInfoNotify>(() => new ChessRogueLayerAccountInfoNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChessRogueLayerAccountInfoNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ChessRogueLayerAccountInfoNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueLayerAccountInfoNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueLayerAccountInfoNotify(ChessRogueLayerAccountInfoNotify other) : this() {
      finishInfo_ = other.finishInfo_ != null ? other.finishInfo_.Clone() : null;
      areaDifficultyLevel_ = other.areaDifficultyLevel_;
      eNPGPALPCDL_ = other.eNPGPALPCDL_.Clone();
      levelInfo_ = other.levelInfo_ != null ? other.levelInfo_.Clone() : null;
      layerId_ = other.layerId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueLayerAccountInfoNotify Clone() {
      return new ChessRogueLayerAccountInfoNotify(this);
    }

    /// <summary>Field number for the "finish_info" field.</summary>
    public const int FinishInfoFieldNumber = 7;
    private global::EggLink.DanhengServer.Proto.ChessRogueFinishInfo finishInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueFinishInfo FinishInfo {
      get { return finishInfo_; }
      set {
        finishInfo_ = value;
      }
    }

    /// <summary>Field number for the "area_difficulty_level" field.</summary>
    public const int AreaDifficultyLevelFieldNumber = 9;
    private uint areaDifficultyLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AreaDifficultyLevel {
      get { return areaDifficultyLevel_; }
      set {
        areaDifficultyLevel_ = value;
      }
    }

    /// <summary>Field number for the "ENPGPALPCDL" field.</summary>
    public const int ENPGPALPCDLFieldNumber = 11;
    private static readonly pb::FieldCodec<uint> _repeated_eNPGPALPCDL_codec
        = pb::FieldCodec.ForUInt32(90);
    private readonly pbc::RepeatedField<uint> eNPGPALPCDL_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> ENPGPALPCDL {
      get { return eNPGPALPCDL_; }
    }

    /// <summary>Field number for the "level_info" field.</summary>
    public const int LevelInfoFieldNumber = 12;
    private global::EggLink.DanhengServer.Proto.ChessRogueLevelInfo levelInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueLevelInfo LevelInfo {
      get { return levelInfo_; }
      set {
        levelInfo_ = value;
      }
    }

    /// <summary>Field number for the "layer_id" field.</summary>
    public const int LayerIdFieldNumber = 1;
    private uint layerId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LayerId {
      get { return layerId_; }
      set {
        layerId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChessRogueLayerAccountInfoNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChessRogueLayerAccountInfoNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(FinishInfo, other.FinishInfo)) return false;
      if (AreaDifficultyLevel != other.AreaDifficultyLevel) return false;
      if(!eNPGPALPCDL_.Equals(other.eNPGPALPCDL_)) return false;
      if (!object.Equals(LevelInfo, other.LevelInfo)) return false;
      if (LayerId != other.LayerId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (finishInfo_ != null) hash ^= FinishInfo.GetHashCode();
      if (AreaDifficultyLevel != 0) hash ^= AreaDifficultyLevel.GetHashCode();
      hash ^= eNPGPALPCDL_.GetHashCode();
      if (levelInfo_ != null) hash ^= LevelInfo.GetHashCode();
      if (LayerId != 0) hash ^= LayerId.GetHashCode();
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
        output.WriteRawTag(8);
        output.WriteUInt32(LayerId);
      }
      if (finishInfo_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(FinishInfo);
      }
      if (AreaDifficultyLevel != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(AreaDifficultyLevel);
      }
      eNPGPALPCDL_.WriteTo(output, _repeated_eNPGPALPCDL_codec);
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
      if (LayerId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(LayerId);
      }
      if (finishInfo_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(FinishInfo);
      }
      if (AreaDifficultyLevel != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(AreaDifficultyLevel);
      }
      eNPGPALPCDL_.WriteTo(ref output, _repeated_eNPGPALPCDL_codec);
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
      if (finishInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FinishInfo);
      }
      if (AreaDifficultyLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AreaDifficultyLevel);
      }
      size += eNPGPALPCDL_.CalculateSize(_repeated_eNPGPALPCDL_codec);
      if (levelInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LevelInfo);
      }
      if (LayerId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LayerId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChessRogueLayerAccountInfoNotify other) {
      if (other == null) {
        return;
      }
      if (other.finishInfo_ != null) {
        if (finishInfo_ == null) {
          FinishInfo = new global::EggLink.DanhengServer.Proto.ChessRogueFinishInfo();
        }
        FinishInfo.MergeFrom(other.FinishInfo);
      }
      if (other.AreaDifficultyLevel != 0) {
        AreaDifficultyLevel = other.AreaDifficultyLevel;
      }
      eNPGPALPCDL_.Add(other.eNPGPALPCDL_);
      if (other.levelInfo_ != null) {
        if (levelInfo_ == null) {
          LevelInfo = new global::EggLink.DanhengServer.Proto.ChessRogueLevelInfo();
        }
        LevelInfo.MergeFrom(other.LevelInfo);
      }
      if (other.LayerId != 0) {
        LayerId = other.LayerId;
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
          case 8: {
            LayerId = input.ReadUInt32();
            break;
          }
          case 58: {
            if (finishInfo_ == null) {
              FinishInfo = new global::EggLink.DanhengServer.Proto.ChessRogueFinishInfo();
            }
            input.ReadMessage(FinishInfo);
            break;
          }
          case 72: {
            AreaDifficultyLevel = input.ReadUInt32();
            break;
          }
          case 90:
          case 88: {
            eNPGPALPCDL_.AddEntriesFrom(input, _repeated_eNPGPALPCDL_codec);
            break;
          }
          case 98: {
            if (levelInfo_ == null) {
              LevelInfo = new global::EggLink.DanhengServer.Proto.ChessRogueLevelInfo();
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
          case 8: {
            LayerId = input.ReadUInt32();
            break;
          }
          case 58: {
            if (finishInfo_ == null) {
              FinishInfo = new global::EggLink.DanhengServer.Proto.ChessRogueFinishInfo();
            }
            input.ReadMessage(FinishInfo);
            break;
          }
          case 72: {
            AreaDifficultyLevel = input.ReadUInt32();
            break;
          }
          case 90:
          case 88: {
            eNPGPALPCDL_.AddEntriesFrom(ref input, _repeated_eNPGPALPCDL_codec);
            break;
          }
          case 98: {
            if (levelInfo_ == null) {
              LevelInfo = new global::EggLink.DanhengServer.Proto.ChessRogueLevelInfo();
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