// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SelectChessRogueNousSubStoryCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SelectChessRogueNousSubStoryCsReq.proto</summary>
  public static partial class SelectChessRogueNousSubStoryCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for SelectChessRogueNousSubStoryCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SelectChessRogueNousSubStoryCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CidTZWxlY3RDaGVzc1JvZ3VlTm91c1N1YlN0b3J5Q3NSZXEucHJvdG8iewoh",
            "U2VsZWN0Q2hlc3NSb2d1ZU5vdXNTdWJTdG9yeUNzUmVxEh8KF3JvZ3VlX2Rp",
            "YWxvZ3VlX2V2ZW50X2lkGAIgASgNEiAKGGNoZXNzX3JvZ3VlX3N1Yl9zdG9y",
            "eV9pZBgMIAEoDRITCgtCSE9ORE1BTEhCTxgHIAEoDUIeqgIbRWdnTGluay5E",
            "YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SelectChessRogueNousSubStoryCsReq), global::EggLink.DanhengServer.Proto.SelectChessRogueNousSubStoryCsReq.Parser, new[]{ "RogueDialogueEventId", "ChessRogueSubStoryId", "BHONDMALHBO" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SelectChessRogueNousSubStoryCsReq : pb::IMessage<SelectChessRogueNousSubStoryCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SelectChessRogueNousSubStoryCsReq> _parser = new pb::MessageParser<SelectChessRogueNousSubStoryCsReq>(() => new SelectChessRogueNousSubStoryCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SelectChessRogueNousSubStoryCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.SelectChessRogueNousSubStoryCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SelectChessRogueNousSubStoryCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SelectChessRogueNousSubStoryCsReq(SelectChessRogueNousSubStoryCsReq other) : this() {
      rogueDialogueEventId_ = other.rogueDialogueEventId_;
      chessRogueSubStoryId_ = other.chessRogueSubStoryId_;
      bHONDMALHBO_ = other.bHONDMALHBO_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SelectChessRogueNousSubStoryCsReq Clone() {
      return new SelectChessRogueNousSubStoryCsReq(this);
    }

    /// <summary>Field number for the "rogue_dialogue_event_id" field.</summary>
    public const int RogueDialogueEventIdFieldNumber = 2;
    private uint rogueDialogueEventId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RogueDialogueEventId {
      get { return rogueDialogueEventId_; }
      set {
        rogueDialogueEventId_ = value;
      }
    }

    /// <summary>Field number for the "chess_rogue_sub_story_id" field.</summary>
    public const int ChessRogueSubStoryIdFieldNumber = 12;
    private uint chessRogueSubStoryId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChessRogueSubStoryId {
      get { return chessRogueSubStoryId_; }
      set {
        chessRogueSubStoryId_ = value;
      }
    }

    /// <summary>Field number for the "BHONDMALHBO" field.</summary>
    public const int BHONDMALHBOFieldNumber = 7;
    private uint bHONDMALHBO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BHONDMALHBO {
      get { return bHONDMALHBO_; }
      set {
        bHONDMALHBO_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SelectChessRogueNousSubStoryCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SelectChessRogueNousSubStoryCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RogueDialogueEventId != other.RogueDialogueEventId) return false;
      if (ChessRogueSubStoryId != other.ChessRogueSubStoryId) return false;
      if (BHONDMALHBO != other.BHONDMALHBO) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (RogueDialogueEventId != 0) hash ^= RogueDialogueEventId.GetHashCode();
      if (ChessRogueSubStoryId != 0) hash ^= ChessRogueSubStoryId.GetHashCode();
      if (BHONDMALHBO != 0) hash ^= BHONDMALHBO.GetHashCode();
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
      if (RogueDialogueEventId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(RogueDialogueEventId);
      }
      if (BHONDMALHBO != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(BHONDMALHBO);
      }
      if (ChessRogueSubStoryId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(ChessRogueSubStoryId);
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
      if (RogueDialogueEventId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(RogueDialogueEventId);
      }
      if (BHONDMALHBO != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(BHONDMALHBO);
      }
      if (ChessRogueSubStoryId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(ChessRogueSubStoryId);
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
      if (RogueDialogueEventId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RogueDialogueEventId);
      }
      if (ChessRogueSubStoryId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChessRogueSubStoryId);
      }
      if (BHONDMALHBO != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BHONDMALHBO);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SelectChessRogueNousSubStoryCsReq other) {
      if (other == null) {
        return;
      }
      if (other.RogueDialogueEventId != 0) {
        RogueDialogueEventId = other.RogueDialogueEventId;
      }
      if (other.ChessRogueSubStoryId != 0) {
        ChessRogueSubStoryId = other.ChessRogueSubStoryId;
      }
      if (other.BHONDMALHBO != 0) {
        BHONDMALHBO = other.BHONDMALHBO;
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
          case 16: {
            RogueDialogueEventId = input.ReadUInt32();
            break;
          }
          case 56: {
            BHONDMALHBO = input.ReadUInt32();
            break;
          }
          case 96: {
            ChessRogueSubStoryId = input.ReadUInt32();
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
          case 16: {
            RogueDialogueEventId = input.ReadUInt32();
            break;
          }
          case 56: {
            BHONDMALHBO = input.ReadUInt32();
            break;
          }
          case 96: {
            ChessRogueSubStoryId = input.ReadUInt32();
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