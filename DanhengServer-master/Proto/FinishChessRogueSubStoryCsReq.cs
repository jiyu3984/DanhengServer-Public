// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FinishChessRogueSubStoryCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from FinishChessRogueSubStoryCsReq.proto</summary>
  public static partial class FinishChessRogueSubStoryCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for FinishChessRogueSubStoryCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FinishChessRogueSubStoryCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNGaW5pc2hDaGVzc1JvZ3VlU3ViU3RvcnlDc1JlcS5wcm90byJrCh1GaW5p",
            "c2hDaGVzc1JvZ3VlU3ViU3RvcnlDc1JlcRITCgtJTkJHRU5BQUlCRxgLIAEo",
            "DRITCgtCSE9ORE1BTEhCTxgIIAEoDRIgChhjaGVzc19yb2d1ZV9zdWJfc3Rv",
            "cnlfaWQYAyABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.FinishChessRogueSubStoryCsReq), global::EggLink.DanhengServer.Proto.FinishChessRogueSubStoryCsReq.Parser, new[]{ "INBGENAAIBG", "BHONDMALHBO", "ChessRogueSubStoryId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class FinishChessRogueSubStoryCsReq : pb::IMessage<FinishChessRogueSubStoryCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FinishChessRogueSubStoryCsReq> _parser = new pb::MessageParser<FinishChessRogueSubStoryCsReq>(() => new FinishChessRogueSubStoryCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FinishChessRogueSubStoryCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.FinishChessRogueSubStoryCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FinishChessRogueSubStoryCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FinishChessRogueSubStoryCsReq(FinishChessRogueSubStoryCsReq other) : this() {
      iNBGENAAIBG_ = other.iNBGENAAIBG_;
      bHONDMALHBO_ = other.bHONDMALHBO_;
      chessRogueSubStoryId_ = other.chessRogueSubStoryId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FinishChessRogueSubStoryCsReq Clone() {
      return new FinishChessRogueSubStoryCsReq(this);
    }

    /// <summary>Field number for the "INBGENAAIBG" field.</summary>
    public const int INBGENAAIBGFieldNumber = 11;
    private uint iNBGENAAIBG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint INBGENAAIBG {
      get { return iNBGENAAIBG_; }
      set {
        iNBGENAAIBG_ = value;
      }
    }

    /// <summary>Field number for the "BHONDMALHBO" field.</summary>
    public const int BHONDMALHBOFieldNumber = 8;
    private uint bHONDMALHBO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BHONDMALHBO {
      get { return bHONDMALHBO_; }
      set {
        bHONDMALHBO_ = value;
      }
    }

    /// <summary>Field number for the "chess_rogue_sub_story_id" field.</summary>
    public const int ChessRogueSubStoryIdFieldNumber = 3;
    private uint chessRogueSubStoryId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChessRogueSubStoryId {
      get { return chessRogueSubStoryId_; }
      set {
        chessRogueSubStoryId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FinishChessRogueSubStoryCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FinishChessRogueSubStoryCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (INBGENAAIBG != other.INBGENAAIBG) return false;
      if (BHONDMALHBO != other.BHONDMALHBO) return false;
      if (ChessRogueSubStoryId != other.ChessRogueSubStoryId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (INBGENAAIBG != 0) hash ^= INBGENAAIBG.GetHashCode();
      if (BHONDMALHBO != 0) hash ^= BHONDMALHBO.GetHashCode();
      if (ChessRogueSubStoryId != 0) hash ^= ChessRogueSubStoryId.GetHashCode();
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
      if (ChessRogueSubStoryId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ChessRogueSubStoryId);
      }
      if (BHONDMALHBO != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(BHONDMALHBO);
      }
      if (INBGENAAIBG != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(INBGENAAIBG);
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
      if (ChessRogueSubStoryId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ChessRogueSubStoryId);
      }
      if (BHONDMALHBO != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(BHONDMALHBO);
      }
      if (INBGENAAIBG != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(INBGENAAIBG);
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
      if (INBGENAAIBG != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(INBGENAAIBG);
      }
      if (BHONDMALHBO != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BHONDMALHBO);
      }
      if (ChessRogueSubStoryId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChessRogueSubStoryId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FinishChessRogueSubStoryCsReq other) {
      if (other == null) {
        return;
      }
      if (other.INBGENAAIBG != 0) {
        INBGENAAIBG = other.INBGENAAIBG;
      }
      if (other.BHONDMALHBO != 0) {
        BHONDMALHBO = other.BHONDMALHBO;
      }
      if (other.ChessRogueSubStoryId != 0) {
        ChessRogueSubStoryId = other.ChessRogueSubStoryId;
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
          case 24: {
            ChessRogueSubStoryId = input.ReadUInt32();
            break;
          }
          case 64: {
            BHONDMALHBO = input.ReadUInt32();
            break;
          }
          case 88: {
            INBGENAAIBG = input.ReadUInt32();
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
          case 24: {
            ChessRogueSubStoryId = input.ReadUInt32();
            break;
          }
          case 64: {
            BHONDMALHBO = input.ReadUInt32();
            break;
          }
          case 88: {
            INBGENAAIBG = input.ReadUInt32();
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