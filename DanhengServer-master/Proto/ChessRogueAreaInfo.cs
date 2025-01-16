// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChessRogueAreaInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ChessRogueAreaInfo.proto</summary>
  public static partial class ChessRogueAreaInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for ChessRogueAreaInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChessRogueAreaInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhDaGVzc1JvZ3VlQXJlYUluZm8ucHJvdG8aDkNlbGxJbmZvLnByb3RvGh9D",
            "aGVzc1JvZ3VlSGlzdG9yeUNlbGxJbmZvLnByb3RvGh9DaGVzc1JvZ3VlQm9h",
            "cmRDZWxsU3RhdHVzLnByb3RvGhFQSEJNQUpQQ05MQi5wcm90byL9AQoSQ2hl",
            "c3NSb2d1ZUFyZWFJbmZvEiEKC0dPSUdESUNHTE5NGA8gASgLMgwuUEhCTUFK",
            "UENOTEISIQoZYWxsb3dfc2VsZWN0X2NlbGxfaWRfbGlzdBgDIAMoDRIOCgZj",
            "dXJfaWQYByABKA0SMAoMbGF5ZXJfc3RhdHVzGAogASgOMhouQ2hlc3NSb2d1",
            "ZUJvYXJkQ2VsbFN0YXR1cxIwCgxoaXN0b3J5X2NlbGwYDSADKAsyGi5DaGVz",
            "c1JvZ3VlSGlzdG9yeUNlbGxJbmZvEhQKDGN1cl9ib2FyZF9pZBgFIAEoDRIX",
            "CgRjZWxsGAIgASgLMgkuQ2VsbEluZm9CHqoCG0VnZ0xpbmsuRGFuaGVuZ1Nl",
            "cnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.CellInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChessRogueHistoryCellInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatusReflection.Descriptor, global::EggLink.DanhengServer.Proto.PHBMAJPCNLBReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ChessRogueAreaInfo), global::EggLink.DanhengServer.Proto.ChessRogueAreaInfo.Parser, new[]{ "GOIGDICGLNM", "AllowSelectCellIdList", "CurId", "LayerStatus", "HistoryCell", "CurBoardId", "Cell" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ChessRogueAreaInfo : pb::IMessage<ChessRogueAreaInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChessRogueAreaInfo> _parser = new pb::MessageParser<ChessRogueAreaInfo>(() => new ChessRogueAreaInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChessRogueAreaInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ChessRogueAreaInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueAreaInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueAreaInfo(ChessRogueAreaInfo other) : this() {
      gOIGDICGLNM_ = other.gOIGDICGLNM_ != null ? other.gOIGDICGLNM_.Clone() : null;
      allowSelectCellIdList_ = other.allowSelectCellIdList_.Clone();
      curId_ = other.curId_;
      layerStatus_ = other.layerStatus_;
      historyCell_ = other.historyCell_.Clone();
      curBoardId_ = other.curBoardId_;
      cell_ = other.cell_ != null ? other.cell_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueAreaInfo Clone() {
      return new ChessRogueAreaInfo(this);
    }

    /// <summary>Field number for the "GOIGDICGLNM" field.</summary>
    public const int GOIGDICGLNMFieldNumber = 15;
    private global::EggLink.DanhengServer.Proto.PHBMAJPCNLB gOIGDICGLNM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.PHBMAJPCNLB GOIGDICGLNM {
      get { return gOIGDICGLNM_; }
      set {
        gOIGDICGLNM_ = value;
      }
    }

    /// <summary>Field number for the "allow_select_cell_id_list" field.</summary>
    public const int AllowSelectCellIdListFieldNumber = 3;
    private static readonly pb::FieldCodec<uint> _repeated_allowSelectCellIdList_codec
        = pb::FieldCodec.ForUInt32(26);
    private readonly pbc::RepeatedField<uint> allowSelectCellIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> AllowSelectCellIdList {
      get { return allowSelectCellIdList_; }
    }

    /// <summary>Field number for the "cur_id" field.</summary>
    public const int CurIdFieldNumber = 7;
    private uint curId_;
    /// <summary>
    /// 5
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurId {
      get { return curId_; }
      set {
        curId_ = value;
      }
    }

    /// <summary>Field number for the "layer_status" field.</summary>
    public const int LayerStatusFieldNumber = 10;
    private global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus layerStatus_ = global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus.Idle;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus LayerStatus {
      get { return layerStatus_; }
      set {
        layerStatus_ = value;
      }
    }

    /// <summary>Field number for the "history_cell" field.</summary>
    public const int HistoryCellFieldNumber = 13;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.ChessRogueHistoryCellInfo> _repeated_historyCell_codec
        = pb::FieldCodec.ForMessage(106, global::EggLink.DanhengServer.Proto.ChessRogueHistoryCellInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ChessRogueHistoryCellInfo> historyCell_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ChessRogueHistoryCellInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ChessRogueHistoryCellInfo> HistoryCell {
      get { return historyCell_; }
    }

    /// <summary>Field number for the "cur_board_id" field.</summary>
    public const int CurBoardIdFieldNumber = 5;
    private uint curBoardId_;
    /// <summary>
    /// 7
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurBoardId {
      get { return curBoardId_; }
      set {
        curBoardId_ = value;
      }
    }

    /// <summary>Field number for the "cell" field.</summary>
    public const int CellFieldNumber = 2;
    private global::EggLink.DanhengServer.Proto.CellInfo cell_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.CellInfo Cell {
      get { return cell_; }
      set {
        cell_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChessRogueAreaInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChessRogueAreaInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(GOIGDICGLNM, other.GOIGDICGLNM)) return false;
      if(!allowSelectCellIdList_.Equals(other.allowSelectCellIdList_)) return false;
      if (CurId != other.CurId) return false;
      if (LayerStatus != other.LayerStatus) return false;
      if(!historyCell_.Equals(other.historyCell_)) return false;
      if (CurBoardId != other.CurBoardId) return false;
      if (!object.Equals(Cell, other.Cell)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (gOIGDICGLNM_ != null) hash ^= GOIGDICGLNM.GetHashCode();
      hash ^= allowSelectCellIdList_.GetHashCode();
      if (CurId != 0) hash ^= CurId.GetHashCode();
      if (LayerStatus != global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus.Idle) hash ^= LayerStatus.GetHashCode();
      hash ^= historyCell_.GetHashCode();
      if (CurBoardId != 0) hash ^= CurBoardId.GetHashCode();
      if (cell_ != null) hash ^= Cell.GetHashCode();
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
      if (cell_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Cell);
      }
      allowSelectCellIdList_.WriteTo(output, _repeated_allowSelectCellIdList_codec);
      if (CurBoardId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(CurBoardId);
      }
      if (CurId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(CurId);
      }
      if (LayerStatus != global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus.Idle) {
        output.WriteRawTag(80);
        output.WriteEnum((int) LayerStatus);
      }
      historyCell_.WriteTo(output, _repeated_historyCell_codec);
      if (gOIGDICGLNM_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(GOIGDICGLNM);
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
      if (cell_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Cell);
      }
      allowSelectCellIdList_.WriteTo(ref output, _repeated_allowSelectCellIdList_codec);
      if (CurBoardId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(CurBoardId);
      }
      if (CurId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(CurId);
      }
      if (LayerStatus != global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus.Idle) {
        output.WriteRawTag(80);
        output.WriteEnum((int) LayerStatus);
      }
      historyCell_.WriteTo(ref output, _repeated_historyCell_codec);
      if (gOIGDICGLNM_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(GOIGDICGLNM);
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
      if (gOIGDICGLNM_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GOIGDICGLNM);
      }
      size += allowSelectCellIdList_.CalculateSize(_repeated_allowSelectCellIdList_codec);
      if (CurId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurId);
      }
      if (LayerStatus != global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus.Idle) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) LayerStatus);
      }
      size += historyCell_.CalculateSize(_repeated_historyCell_codec);
      if (CurBoardId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurBoardId);
      }
      if (cell_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Cell);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChessRogueAreaInfo other) {
      if (other == null) {
        return;
      }
      if (other.gOIGDICGLNM_ != null) {
        if (gOIGDICGLNM_ == null) {
          GOIGDICGLNM = new global::EggLink.DanhengServer.Proto.PHBMAJPCNLB();
        }
        GOIGDICGLNM.MergeFrom(other.GOIGDICGLNM);
      }
      allowSelectCellIdList_.Add(other.allowSelectCellIdList_);
      if (other.CurId != 0) {
        CurId = other.CurId;
      }
      if (other.LayerStatus != global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus.Idle) {
        LayerStatus = other.LayerStatus;
      }
      historyCell_.Add(other.historyCell_);
      if (other.CurBoardId != 0) {
        CurBoardId = other.CurBoardId;
      }
      if (other.cell_ != null) {
        if (cell_ == null) {
          Cell = new global::EggLink.DanhengServer.Proto.CellInfo();
        }
        Cell.MergeFrom(other.Cell);
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
            if (cell_ == null) {
              Cell = new global::EggLink.DanhengServer.Proto.CellInfo();
            }
            input.ReadMessage(Cell);
            break;
          }
          case 26:
          case 24: {
            allowSelectCellIdList_.AddEntriesFrom(input, _repeated_allowSelectCellIdList_codec);
            break;
          }
          case 40: {
            CurBoardId = input.ReadUInt32();
            break;
          }
          case 56: {
            CurId = input.ReadUInt32();
            break;
          }
          case 80: {
            LayerStatus = (global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus) input.ReadEnum();
            break;
          }
          case 106: {
            historyCell_.AddEntriesFrom(input, _repeated_historyCell_codec);
            break;
          }
          case 122: {
            if (gOIGDICGLNM_ == null) {
              GOIGDICGLNM = new global::EggLink.DanhengServer.Proto.PHBMAJPCNLB();
            }
            input.ReadMessage(GOIGDICGLNM);
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
            if (cell_ == null) {
              Cell = new global::EggLink.DanhengServer.Proto.CellInfo();
            }
            input.ReadMessage(Cell);
            break;
          }
          case 26:
          case 24: {
            allowSelectCellIdList_.AddEntriesFrom(ref input, _repeated_allowSelectCellIdList_codec);
            break;
          }
          case 40: {
            CurBoardId = input.ReadUInt32();
            break;
          }
          case 56: {
            CurId = input.ReadUInt32();
            break;
          }
          case 80: {
            LayerStatus = (global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus) input.ReadEnum();
            break;
          }
          case 106: {
            historyCell_.AddEntriesFrom(ref input, _repeated_historyCell_codec);
            break;
          }
          case 122: {
            if (gOIGDICGLNM_ == null) {
              GOIGDICGLNM = new global::EggLink.DanhengServer.Proto.PHBMAJPCNLB();
            }
            input.ReadMessage(GOIGDICGLNM);
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
