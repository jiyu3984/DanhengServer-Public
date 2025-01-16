// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChessRogueQueryInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ChessRogueQueryInfo.proto</summary>
  public static partial class ChessRogueQueryInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for ChessRogueQueryInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChessRogueQueryInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlDaGVzc1JvZ3VlUXVlcnlJbmZvLnByb3RvGiJDaGVzc1JvZ3VlUXVlcnlE",
            "aWZmY3VsdHlJbmZvLnByb3RvGh1DaGVzc1JvZ3VlUXVlcnlBZW9uSW5mby5w",
            "cm90bxoaQ2hlc3NSb2d1ZVRhbGVudEluZm8ucHJvdG8aEUxPSk5BRUtJRU5Q",
            "LnByb3RvGh1DaGVzc1JvZ3VlUXVlcnlEaWNlSW5mby5wcm90byLOAgoTQ2hl",
            "c3NSb2d1ZVF1ZXJ5SW5mbxIUCgxhcmVhX2lkX2xpc3QYDCADKA0SMQoPcXVl",
            "cnlfZGljZV9pbmZvGA4gASgLMhguQ2hlc3NSb2d1ZVF1ZXJ5RGljZUluZm8S",
            "LQoXcm9ndWVfdmlydHVhbF9pdGVtX2luZm8YCSABKAsyDC5MT0pOQUVLSUVO",
            "UBIdChVleHBsb3JlZF9hcmVhX2lkX2xpc3QYDyADKA0SMQoPY2hlc3NfYWVv",
            "bl9pbmZvGAcgASgLMhguQ2hlc3NSb2d1ZVF1ZXJ5QWVvbkluZm8SPAoVcm9n",
            "dWVfZGlmZmljdWx0eV9pbmZvGAggASgLMh0uQ2hlc3NSb2d1ZVF1ZXJ5RGlm",
            "ZmN1bHR5SW5mbxIvChB0YWxlbnRfaW5mb19saXN0GAMgASgLMhUuQ2hlc3NS",
            "b2d1ZVRhbGVudEluZm9CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90",
            "b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ChessRogueQueryDiffcultyInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChessRogueQueryAeonInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChessRogueTalentInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.LOJNAEKIENPReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChessRogueQueryDiceInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ChessRogueQueryInfo), global::EggLink.DanhengServer.Proto.ChessRogueQueryInfo.Parser, new[]{ "AreaIdList", "QueryDiceInfo", "RogueVirtualItemInfo", "ExploredAreaIdList", "ChessAeonInfo", "RogueDifficultyInfo", "TalentInfoList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ChessRogueQueryInfo : pb::IMessage<ChessRogueQueryInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChessRogueQueryInfo> _parser = new pb::MessageParser<ChessRogueQueryInfo>(() => new ChessRogueQueryInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChessRogueQueryInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ChessRogueQueryInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueQueryInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueQueryInfo(ChessRogueQueryInfo other) : this() {
      areaIdList_ = other.areaIdList_.Clone();
      queryDiceInfo_ = other.queryDiceInfo_ != null ? other.queryDiceInfo_.Clone() : null;
      rogueVirtualItemInfo_ = other.rogueVirtualItemInfo_ != null ? other.rogueVirtualItemInfo_.Clone() : null;
      exploredAreaIdList_ = other.exploredAreaIdList_.Clone();
      chessAeonInfo_ = other.chessAeonInfo_ != null ? other.chessAeonInfo_.Clone() : null;
      rogueDifficultyInfo_ = other.rogueDifficultyInfo_ != null ? other.rogueDifficultyInfo_.Clone() : null;
      talentInfoList_ = other.talentInfoList_ != null ? other.talentInfoList_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueQueryInfo Clone() {
      return new ChessRogueQueryInfo(this);
    }

    /// <summary>Field number for the "area_id_list" field.</summary>
    public const int AreaIdListFieldNumber = 12;
    private static readonly pb::FieldCodec<uint> _repeated_areaIdList_codec
        = pb::FieldCodec.ForUInt32(98);
    private readonly pbc::RepeatedField<uint> areaIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> AreaIdList {
      get { return areaIdList_; }
    }

    /// <summary>Field number for the "query_dice_info" field.</summary>
    public const int QueryDiceInfoFieldNumber = 14;
    private global::EggLink.DanhengServer.Proto.ChessRogueQueryDiceInfo queryDiceInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueQueryDiceInfo QueryDiceInfo {
      get { return queryDiceInfo_; }
      set {
        queryDiceInfo_ = value;
      }
    }

    /// <summary>Field number for the "rogue_virtual_item_info" field.</summary>
    public const int RogueVirtualItemInfoFieldNumber = 9;
    private global::EggLink.DanhengServer.Proto.LOJNAEKIENP rogueVirtualItemInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.LOJNAEKIENP RogueVirtualItemInfo {
      get { return rogueVirtualItemInfo_; }
      set {
        rogueVirtualItemInfo_ = value;
      }
    }

    /// <summary>Field number for the "explored_area_id_list" field.</summary>
    public const int ExploredAreaIdListFieldNumber = 15;
    private static readonly pb::FieldCodec<uint> _repeated_exploredAreaIdList_codec
        = pb::FieldCodec.ForUInt32(122);
    private readonly pbc::RepeatedField<uint> exploredAreaIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> ExploredAreaIdList {
      get { return exploredAreaIdList_; }
    }

    /// <summary>Field number for the "chess_aeon_info" field.</summary>
    public const int ChessAeonInfoFieldNumber = 7;
    private global::EggLink.DanhengServer.Proto.ChessRogueQueryAeonInfo chessAeonInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueQueryAeonInfo ChessAeonInfo {
      get { return chessAeonInfo_; }
      set {
        chessAeonInfo_ = value;
      }
    }

    /// <summary>Field number for the "rogue_difficulty_info" field.</summary>
    public const int RogueDifficultyInfoFieldNumber = 8;
    private global::EggLink.DanhengServer.Proto.ChessRogueQueryDiffcultyInfo rogueDifficultyInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueQueryDiffcultyInfo RogueDifficultyInfo {
      get { return rogueDifficultyInfo_; }
      set {
        rogueDifficultyInfo_ = value;
      }
    }

    /// <summary>Field number for the "talent_info_list" field.</summary>
    public const int TalentInfoListFieldNumber = 3;
    private global::EggLink.DanhengServer.Proto.ChessRogueTalentInfo talentInfoList_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueTalentInfo TalentInfoList {
      get { return talentInfoList_; }
      set {
        talentInfoList_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChessRogueQueryInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChessRogueQueryInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!areaIdList_.Equals(other.areaIdList_)) return false;
      if (!object.Equals(QueryDiceInfo, other.QueryDiceInfo)) return false;
      if (!object.Equals(RogueVirtualItemInfo, other.RogueVirtualItemInfo)) return false;
      if(!exploredAreaIdList_.Equals(other.exploredAreaIdList_)) return false;
      if (!object.Equals(ChessAeonInfo, other.ChessAeonInfo)) return false;
      if (!object.Equals(RogueDifficultyInfo, other.RogueDifficultyInfo)) return false;
      if (!object.Equals(TalentInfoList, other.TalentInfoList)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= areaIdList_.GetHashCode();
      if (queryDiceInfo_ != null) hash ^= QueryDiceInfo.GetHashCode();
      if (rogueVirtualItemInfo_ != null) hash ^= RogueVirtualItemInfo.GetHashCode();
      hash ^= exploredAreaIdList_.GetHashCode();
      if (chessAeonInfo_ != null) hash ^= ChessAeonInfo.GetHashCode();
      if (rogueDifficultyInfo_ != null) hash ^= RogueDifficultyInfo.GetHashCode();
      if (talentInfoList_ != null) hash ^= TalentInfoList.GetHashCode();
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
      if (talentInfoList_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(TalentInfoList);
      }
      if (chessAeonInfo_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(ChessAeonInfo);
      }
      if (rogueDifficultyInfo_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(RogueDifficultyInfo);
      }
      if (rogueVirtualItemInfo_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(RogueVirtualItemInfo);
      }
      areaIdList_.WriteTo(output, _repeated_areaIdList_codec);
      if (queryDiceInfo_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(QueryDiceInfo);
      }
      exploredAreaIdList_.WriteTo(output, _repeated_exploredAreaIdList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (talentInfoList_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(TalentInfoList);
      }
      if (chessAeonInfo_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(ChessAeonInfo);
      }
      if (rogueDifficultyInfo_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(RogueDifficultyInfo);
      }
      if (rogueVirtualItemInfo_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(RogueVirtualItemInfo);
      }
      areaIdList_.WriteTo(ref output, _repeated_areaIdList_codec);
      if (queryDiceInfo_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(QueryDiceInfo);
      }
      exploredAreaIdList_.WriteTo(ref output, _repeated_exploredAreaIdList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += areaIdList_.CalculateSize(_repeated_areaIdList_codec);
      if (queryDiceInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(QueryDiceInfo);
      }
      if (rogueVirtualItemInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueVirtualItemInfo);
      }
      size += exploredAreaIdList_.CalculateSize(_repeated_exploredAreaIdList_codec);
      if (chessAeonInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ChessAeonInfo);
      }
      if (rogueDifficultyInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueDifficultyInfo);
      }
      if (talentInfoList_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TalentInfoList);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChessRogueQueryInfo other) {
      if (other == null) {
        return;
      }
      areaIdList_.Add(other.areaIdList_);
      if (other.queryDiceInfo_ != null) {
        if (queryDiceInfo_ == null) {
          QueryDiceInfo = new global::EggLink.DanhengServer.Proto.ChessRogueQueryDiceInfo();
        }
        QueryDiceInfo.MergeFrom(other.QueryDiceInfo);
      }
      if (other.rogueVirtualItemInfo_ != null) {
        if (rogueVirtualItemInfo_ == null) {
          RogueVirtualItemInfo = new global::EggLink.DanhengServer.Proto.LOJNAEKIENP();
        }
        RogueVirtualItemInfo.MergeFrom(other.RogueVirtualItemInfo);
      }
      exploredAreaIdList_.Add(other.exploredAreaIdList_);
      if (other.chessAeonInfo_ != null) {
        if (chessAeonInfo_ == null) {
          ChessAeonInfo = new global::EggLink.DanhengServer.Proto.ChessRogueQueryAeonInfo();
        }
        ChessAeonInfo.MergeFrom(other.ChessAeonInfo);
      }
      if (other.rogueDifficultyInfo_ != null) {
        if (rogueDifficultyInfo_ == null) {
          RogueDifficultyInfo = new global::EggLink.DanhengServer.Proto.ChessRogueQueryDiffcultyInfo();
        }
        RogueDifficultyInfo.MergeFrom(other.RogueDifficultyInfo);
      }
      if (other.talentInfoList_ != null) {
        if (talentInfoList_ == null) {
          TalentInfoList = new global::EggLink.DanhengServer.Proto.ChessRogueTalentInfo();
        }
        TalentInfoList.MergeFrom(other.TalentInfoList);
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
          case 26: {
            if (talentInfoList_ == null) {
              TalentInfoList = new global::EggLink.DanhengServer.Proto.ChessRogueTalentInfo();
            }
            input.ReadMessage(TalentInfoList);
            break;
          }
          case 58: {
            if (chessAeonInfo_ == null) {
              ChessAeonInfo = new global::EggLink.DanhengServer.Proto.ChessRogueQueryAeonInfo();
            }
            input.ReadMessage(ChessAeonInfo);
            break;
          }
          case 66: {
            if (rogueDifficultyInfo_ == null) {
              RogueDifficultyInfo = new global::EggLink.DanhengServer.Proto.ChessRogueQueryDiffcultyInfo();
            }
            input.ReadMessage(RogueDifficultyInfo);
            break;
          }
          case 74: {
            if (rogueVirtualItemInfo_ == null) {
              RogueVirtualItemInfo = new global::EggLink.DanhengServer.Proto.LOJNAEKIENP();
            }
            input.ReadMessage(RogueVirtualItemInfo);
            break;
          }
          case 98:
          case 96: {
            areaIdList_.AddEntriesFrom(input, _repeated_areaIdList_codec);
            break;
          }
          case 114: {
            if (queryDiceInfo_ == null) {
              QueryDiceInfo = new global::EggLink.DanhengServer.Proto.ChessRogueQueryDiceInfo();
            }
            input.ReadMessage(QueryDiceInfo);
            break;
          }
          case 122:
          case 120: {
            exploredAreaIdList_.AddEntriesFrom(input, _repeated_exploredAreaIdList_codec);
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
            if (talentInfoList_ == null) {
              TalentInfoList = new global::EggLink.DanhengServer.Proto.ChessRogueTalentInfo();
            }
            input.ReadMessage(TalentInfoList);
            break;
          }
          case 58: {
            if (chessAeonInfo_ == null) {
              ChessAeonInfo = new global::EggLink.DanhengServer.Proto.ChessRogueQueryAeonInfo();
            }
            input.ReadMessage(ChessAeonInfo);
            break;
          }
          case 66: {
            if (rogueDifficultyInfo_ == null) {
              RogueDifficultyInfo = new global::EggLink.DanhengServer.Proto.ChessRogueQueryDiffcultyInfo();
            }
            input.ReadMessage(RogueDifficultyInfo);
            break;
          }
          case 74: {
            if (rogueVirtualItemInfo_ == null) {
              RogueVirtualItemInfo = new global::EggLink.DanhengServer.Proto.LOJNAEKIENP();
            }
            input.ReadMessage(RogueVirtualItemInfo);
            break;
          }
          case 98:
          case 96: {
            areaIdList_.AddEntriesFrom(ref input, _repeated_areaIdList_codec);
            break;
          }
          case 114: {
            if (queryDiceInfo_ == null) {
              QueryDiceInfo = new global::EggLink.DanhengServer.Proto.ChessRogueQueryDiceInfo();
            }
            input.ReadMessage(QueryDiceInfo);
            break;
          }
          case 122:
          case 120: {
            exploredAreaIdList_.AddEntriesFrom(ref input, _repeated_exploredAreaIdList_codec);
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
