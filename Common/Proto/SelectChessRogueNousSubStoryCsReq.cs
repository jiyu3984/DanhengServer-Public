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
            "CidTZWxlY3RDaGVzc1JvZ3VlTm91c1N1YlN0b3J5Q3NSZXEucHJvdG8idQoh",
            "U2VsZWN0Q2hlc3NSb2d1ZU5vdXNTdWJTdG9yeUNzUmVxEiAKGGNoZXNzX3Jv",
            "Z3VlX3N1Yl9zdG9yeV9pZBgGIAEoDRIZChFkaWFsb2d1ZV9ldmVudF9pZBgL",
            "IAEoDRITCgtHSUdNS01MT0ZIRxgPIAEoDUIeqgIbRWdnTGluay5EYW5oZW5n",
            "U2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SelectChessRogueNousSubStoryCsReq), global::EggLink.DanhengServer.Proto.SelectChessRogueNousSubStoryCsReq.Parser, new[]{ "ChessRogueSubStoryId", "DialogueEventId", "GIGMKMLOFHG" }, null, null, null, null)
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
      chessRogueSubStoryId_ = other.chessRogueSubStoryId_;
      dialogueEventId_ = other.dialogueEventId_;
      gIGMKMLOFHG_ = other.gIGMKMLOFHG_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SelectChessRogueNousSubStoryCsReq Clone() {
      return new SelectChessRogueNousSubStoryCsReq(this);
    }

    /// <summary>Field number for the "chess_rogue_sub_story_id" field.</summary>
    public const int ChessRogueSubStoryIdFieldNumber = 6;
    private uint chessRogueSubStoryId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChessRogueSubStoryId {
      get { return chessRogueSubStoryId_; }
      set {
        chessRogueSubStoryId_ = value;
      }
    }

    /// <summary>Field number for the "dialogue_event_id" field.</summary>
    public const int DialogueEventIdFieldNumber = 11;
    private uint dialogueEventId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DialogueEventId {
      get { return dialogueEventId_; }
      set {
        dialogueEventId_ = value;
      }
    }

    /// <summary>Field number for the "GIGMKMLOFHG" field.</summary>
    public const int GIGMKMLOFHGFieldNumber = 15;
    private uint gIGMKMLOFHG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GIGMKMLOFHG {
      get { return gIGMKMLOFHG_; }
      set {
        gIGMKMLOFHG_ = value;
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
      if (ChessRogueSubStoryId != other.ChessRogueSubStoryId) return false;
      if (DialogueEventId != other.DialogueEventId) return false;
      if (GIGMKMLOFHG != other.GIGMKMLOFHG) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ChessRogueSubStoryId != 0) hash ^= ChessRogueSubStoryId.GetHashCode();
      if (DialogueEventId != 0) hash ^= DialogueEventId.GetHashCode();
      if (GIGMKMLOFHG != 0) hash ^= GIGMKMLOFHG.GetHashCode();
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
        output.WriteRawTag(48);
        output.WriteUInt32(ChessRogueSubStoryId);
      }
      if (DialogueEventId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(DialogueEventId);
      }
      if (GIGMKMLOFHG != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(GIGMKMLOFHG);
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
        output.WriteRawTag(48);
        output.WriteUInt32(ChessRogueSubStoryId);
      }
      if (DialogueEventId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(DialogueEventId);
      }
      if (GIGMKMLOFHG != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(GIGMKMLOFHG);
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
      if (ChessRogueSubStoryId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChessRogueSubStoryId);
      }
      if (DialogueEventId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DialogueEventId);
      }
      if (GIGMKMLOFHG != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GIGMKMLOFHG);
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
      if (other.ChessRogueSubStoryId != 0) {
        ChessRogueSubStoryId = other.ChessRogueSubStoryId;
      }
      if (other.DialogueEventId != 0) {
        DialogueEventId = other.DialogueEventId;
      }
      if (other.GIGMKMLOFHG != 0) {
        GIGMKMLOFHG = other.GIGMKMLOFHG;
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
            ChessRogueSubStoryId = input.ReadUInt32();
            break;
          }
          case 88: {
            DialogueEventId = input.ReadUInt32();
            break;
          }
          case 120: {
            GIGMKMLOFHG = input.ReadUInt32();
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
            ChessRogueSubStoryId = input.ReadUInt32();
            break;
          }
          case 88: {
            DialogueEventId = input.ReadUInt32();
            break;
          }
          case 120: {
            GIGMKMLOFHG = input.ReadUInt32();
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