// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChessRogueAeonInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ChessRogueAeonInfo.proto</summary>
  public static partial class ChessRogueAeonInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for ChessRogueAeonInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChessRogueAeonInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhDaGVzc1JvZ3VlQWVvbkluZm8ucHJvdG8aHUNoZXNzUm9ndWVRdWVyeUFl",
            "b25JbmZvLnByb3RvGhFFQk9JT0lLRkxGSi5wcm90byKrAQoSQ2hlc3NSb2d1",
            "ZUFlb25JbmZvEhQKDGdhbWVfYWVvbl9pZBgJIAEoDRITCgtISERBQk9GT01F",
            "QxgOIAEoBRIhCgtPQUtOR05LQUxQSRgGIAEoCzIMLkVCT0lPSUtGTEZKEjEK",
            "D2NoZXNzX2Flb25faW5mbxgEIAEoCzIYLkNoZXNzUm9ndWVRdWVyeUFlb25J",
            "bmZvEhQKDGFlb25faWRfbGlzdBgHIAMoDUIeqgIbRWdnTGluay5EYW5oZW5n",
            "U2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ChessRogueQueryAeonInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.EBOIOIKFLFJReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ChessRogueAeonInfo), global::EggLink.DanhengServer.Proto.ChessRogueAeonInfo.Parser, new[]{ "GameAeonId", "HHDABOFOMEC", "OAKNGNKALPI", "ChessAeonInfo", "AeonIdList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ChessRogueAeonInfo : pb::IMessage<ChessRogueAeonInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChessRogueAeonInfo> _parser = new pb::MessageParser<ChessRogueAeonInfo>(() => new ChessRogueAeonInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChessRogueAeonInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ChessRogueAeonInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueAeonInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueAeonInfo(ChessRogueAeonInfo other) : this() {
      gameAeonId_ = other.gameAeonId_;
      hHDABOFOMEC_ = other.hHDABOFOMEC_;
      oAKNGNKALPI_ = other.oAKNGNKALPI_ != null ? other.oAKNGNKALPI_.Clone() : null;
      chessAeonInfo_ = other.chessAeonInfo_ != null ? other.chessAeonInfo_.Clone() : null;
      aeonIdList_ = other.aeonIdList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueAeonInfo Clone() {
      return new ChessRogueAeonInfo(this);
    }

    /// <summary>Field number for the "game_aeon_id" field.</summary>
    public const int GameAeonIdFieldNumber = 9;
    private uint gameAeonId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GameAeonId {
      get { return gameAeonId_; }
      set {
        gameAeonId_ = value;
      }
    }

    /// <summary>Field number for the "HHDABOFOMEC" field.</summary>
    public const int HHDABOFOMECFieldNumber = 14;
    private int hHDABOFOMEC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int HHDABOFOMEC {
      get { return hHDABOFOMEC_; }
      set {
        hHDABOFOMEC_ = value;
      }
    }

    /// <summary>Field number for the "OAKNGNKALPI" field.</summary>
    public const int OAKNGNKALPIFieldNumber = 6;
    private global::EggLink.DanhengServer.Proto.EBOIOIKFLFJ oAKNGNKALPI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.EBOIOIKFLFJ OAKNGNKALPI {
      get { return oAKNGNKALPI_; }
      set {
        oAKNGNKALPI_ = value;
      }
    }

    /// <summary>Field number for the "chess_aeon_info" field.</summary>
    public const int ChessAeonInfoFieldNumber = 4;
    private global::EggLink.DanhengServer.Proto.ChessRogueQueryAeonInfo chessAeonInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueQueryAeonInfo ChessAeonInfo {
      get { return chessAeonInfo_; }
      set {
        chessAeonInfo_ = value;
      }
    }

    /// <summary>Field number for the "aeon_id_list" field.</summary>
    public const int AeonIdListFieldNumber = 7;
    private static readonly pb::FieldCodec<uint> _repeated_aeonIdList_codec
        = pb::FieldCodec.ForUInt32(58);
    private readonly pbc::RepeatedField<uint> aeonIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> AeonIdList {
      get { return aeonIdList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChessRogueAeonInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChessRogueAeonInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GameAeonId != other.GameAeonId) return false;
      if (HHDABOFOMEC != other.HHDABOFOMEC) return false;
      if (!object.Equals(OAKNGNKALPI, other.OAKNGNKALPI)) return false;
      if (!object.Equals(ChessAeonInfo, other.ChessAeonInfo)) return false;
      if(!aeonIdList_.Equals(other.aeonIdList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (GameAeonId != 0) hash ^= GameAeonId.GetHashCode();
      if (HHDABOFOMEC != 0) hash ^= HHDABOFOMEC.GetHashCode();
      if (oAKNGNKALPI_ != null) hash ^= OAKNGNKALPI.GetHashCode();
      if (chessAeonInfo_ != null) hash ^= ChessAeonInfo.GetHashCode();
      hash ^= aeonIdList_.GetHashCode();
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
      if (chessAeonInfo_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(ChessAeonInfo);
      }
      if (oAKNGNKALPI_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(OAKNGNKALPI);
      }
      aeonIdList_.WriteTo(output, _repeated_aeonIdList_codec);
      if (GameAeonId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(GameAeonId);
      }
      if (HHDABOFOMEC != 0) {
        output.WriteRawTag(112);
        output.WriteInt32(HHDABOFOMEC);
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
      if (chessAeonInfo_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(ChessAeonInfo);
      }
      if (oAKNGNKALPI_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(OAKNGNKALPI);
      }
      aeonIdList_.WriteTo(ref output, _repeated_aeonIdList_codec);
      if (GameAeonId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(GameAeonId);
      }
      if (HHDABOFOMEC != 0) {
        output.WriteRawTag(112);
        output.WriteInt32(HHDABOFOMEC);
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
      if (GameAeonId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GameAeonId);
      }
      if (HHDABOFOMEC != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(HHDABOFOMEC);
      }
      if (oAKNGNKALPI_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(OAKNGNKALPI);
      }
      if (chessAeonInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ChessAeonInfo);
      }
      size += aeonIdList_.CalculateSize(_repeated_aeonIdList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChessRogueAeonInfo other) {
      if (other == null) {
        return;
      }
      if (other.GameAeonId != 0) {
        GameAeonId = other.GameAeonId;
      }
      if (other.HHDABOFOMEC != 0) {
        HHDABOFOMEC = other.HHDABOFOMEC;
      }
      if (other.oAKNGNKALPI_ != null) {
        if (oAKNGNKALPI_ == null) {
          OAKNGNKALPI = new global::EggLink.DanhengServer.Proto.EBOIOIKFLFJ();
        }
        OAKNGNKALPI.MergeFrom(other.OAKNGNKALPI);
      }
      if (other.chessAeonInfo_ != null) {
        if (chessAeonInfo_ == null) {
          ChessAeonInfo = new global::EggLink.DanhengServer.Proto.ChessRogueQueryAeonInfo();
        }
        ChessAeonInfo.MergeFrom(other.ChessAeonInfo);
      }
      aeonIdList_.Add(other.aeonIdList_);
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
          case 34: {
            if (chessAeonInfo_ == null) {
              ChessAeonInfo = new global::EggLink.DanhengServer.Proto.ChessRogueQueryAeonInfo();
            }
            input.ReadMessage(ChessAeonInfo);
            break;
          }
          case 50: {
            if (oAKNGNKALPI_ == null) {
              OAKNGNKALPI = new global::EggLink.DanhengServer.Proto.EBOIOIKFLFJ();
            }
            input.ReadMessage(OAKNGNKALPI);
            break;
          }
          case 58:
          case 56: {
            aeonIdList_.AddEntriesFrom(input, _repeated_aeonIdList_codec);
            break;
          }
          case 72: {
            GameAeonId = input.ReadUInt32();
            break;
          }
          case 112: {
            HHDABOFOMEC = input.ReadInt32();
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
          case 34: {
            if (chessAeonInfo_ == null) {
              ChessAeonInfo = new global::EggLink.DanhengServer.Proto.ChessRogueQueryAeonInfo();
            }
            input.ReadMessage(ChessAeonInfo);
            break;
          }
          case 50: {
            if (oAKNGNKALPI_ == null) {
              OAKNGNKALPI = new global::EggLink.DanhengServer.Proto.EBOIOIKFLFJ();
            }
            input.ReadMessage(OAKNGNKALPI);
            break;
          }
          case 58:
          case 56: {
            aeonIdList_.AddEntriesFrom(ref input, _repeated_aeonIdList_codec);
            break;
          }
          case 72: {
            GameAeonId = input.ReadUInt32();
            break;
          }
          case 112: {
            HHDABOFOMEC = input.ReadInt32();
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