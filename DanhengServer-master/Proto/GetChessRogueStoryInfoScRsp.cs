// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetChessRogueStoryInfoScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetChessRogueStoryInfoScRsp.proto</summary>
  public static partial class GetChessRogueStoryInfoScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetChessRogueStoryInfoScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetChessRogueStoryInfoScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFHZXRDaGVzc1JvZ3VlU3RvcnlJbmZvU2NSc3AucHJvdG8aEUFBTkVISkJO",
            "RkJNLnByb3RvGhFFSEdMQURJRElDRS5wcm90byKTAQobR2V0Q2hlc3NSb2d1",
            "ZVN0b3J5SW5mb1NjUnNwEjAKGmNoZXNzX3JvZ3VlX3N1Yl9zdG9yeV9pbmZv",
            "GAwgAygLMgwuQUFORUhKQk5GQk0SMQobY2hlc3Nfcm9ndWVfbWFpbl9zdG9y",
            "eV9pbmZvGA4gAygLMgwuRUhHTEFESURJQ0USDwoHcmV0Y29kZRgGIAEoDUIe",
            "qgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.AANEHJBNFBMReflection.Descriptor, global::EggLink.DanhengServer.Proto.EHGLADIDICEReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetChessRogueStoryInfoScRsp), global::EggLink.DanhengServer.Proto.GetChessRogueStoryInfoScRsp.Parser, new[]{ "ChessRogueSubStoryInfo", "ChessRogueMainStoryInfo", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetChessRogueStoryInfoScRsp : pb::IMessage<GetChessRogueStoryInfoScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetChessRogueStoryInfoScRsp> _parser = new pb::MessageParser<GetChessRogueStoryInfoScRsp>(() => new GetChessRogueStoryInfoScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetChessRogueStoryInfoScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetChessRogueStoryInfoScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetChessRogueStoryInfoScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetChessRogueStoryInfoScRsp(GetChessRogueStoryInfoScRsp other) : this() {
      chessRogueSubStoryInfo_ = other.chessRogueSubStoryInfo_.Clone();
      chessRogueMainStoryInfo_ = other.chessRogueMainStoryInfo_.Clone();
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetChessRogueStoryInfoScRsp Clone() {
      return new GetChessRogueStoryInfoScRsp(this);
    }

    /// <summary>Field number for the "chess_rogue_sub_story_info" field.</summary>
    public const int ChessRogueSubStoryInfoFieldNumber = 12;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.AANEHJBNFBM> _repeated_chessRogueSubStoryInfo_codec
        = pb::FieldCodec.ForMessage(98, global::EggLink.DanhengServer.Proto.AANEHJBNFBM.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AANEHJBNFBM> chessRogueSubStoryInfo_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AANEHJBNFBM>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AANEHJBNFBM> ChessRogueSubStoryInfo {
      get { return chessRogueSubStoryInfo_; }
    }

    /// <summary>Field number for the "chess_rogue_main_story_info" field.</summary>
    public const int ChessRogueMainStoryInfoFieldNumber = 14;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.EHGLADIDICE> _repeated_chessRogueMainStoryInfo_codec
        = pb::FieldCodec.ForMessage(114, global::EggLink.DanhengServer.Proto.EHGLADIDICE.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.EHGLADIDICE> chessRogueMainStoryInfo_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.EHGLADIDICE>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.EHGLADIDICE> ChessRogueMainStoryInfo {
      get { return chessRogueMainStoryInfo_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 6;
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
      return Equals(other as GetChessRogueStoryInfoScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetChessRogueStoryInfoScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!chessRogueSubStoryInfo_.Equals(other.chessRogueSubStoryInfo_)) return false;
      if(!chessRogueMainStoryInfo_.Equals(other.chessRogueMainStoryInfo_)) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= chessRogueSubStoryInfo_.GetHashCode();
      hash ^= chessRogueMainStoryInfo_.GetHashCode();
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
      if (Retcode != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Retcode);
      }
      chessRogueSubStoryInfo_.WriteTo(output, _repeated_chessRogueSubStoryInfo_codec);
      chessRogueMainStoryInfo_.WriteTo(output, _repeated_chessRogueMainStoryInfo_codec);
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
        output.WriteRawTag(48);
        output.WriteUInt32(Retcode);
      }
      chessRogueSubStoryInfo_.WriteTo(ref output, _repeated_chessRogueSubStoryInfo_codec);
      chessRogueMainStoryInfo_.WriteTo(ref output, _repeated_chessRogueMainStoryInfo_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += chessRogueSubStoryInfo_.CalculateSize(_repeated_chessRogueSubStoryInfo_codec);
      size += chessRogueMainStoryInfo_.CalculateSize(_repeated_chessRogueMainStoryInfo_codec);
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
    public void MergeFrom(GetChessRogueStoryInfoScRsp other) {
      if (other == null) {
        return;
      }
      chessRogueSubStoryInfo_.Add(other.chessRogueSubStoryInfo_);
      chessRogueMainStoryInfo_.Add(other.chessRogueMainStoryInfo_);
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
          case 48: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 98: {
            chessRogueSubStoryInfo_.AddEntriesFrom(input, _repeated_chessRogueSubStoryInfo_codec);
            break;
          }
          case 114: {
            chessRogueMainStoryInfo_.AddEntriesFrom(input, _repeated_chessRogueMainStoryInfo_codec);
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
            Retcode = input.ReadUInt32();
            break;
          }
          case 98: {
            chessRogueSubStoryInfo_.AddEntriesFrom(ref input, _repeated_chessRogueSubStoryInfo_codec);
            break;
          }
          case 114: {
            chessRogueMainStoryInfo_.AddEntriesFrom(ref input, _repeated_chessRogueMainStoryInfo_codec);
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
