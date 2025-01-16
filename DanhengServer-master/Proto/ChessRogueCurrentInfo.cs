// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChessRogueCurrentInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ChessRogueCurrentInfo.proto</summary>
  public static partial class ChessRogueCurrentInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for ChessRogueCurrentInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChessRogueCurrentInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtDaGVzc1JvZ3VlQ3VycmVudEluZm8ucHJvdG8aE1JvZ3VlR2FtZUluZm8u",
            "cHJvdG8iYAoVQ2hlc3NSb2d1ZUN1cnJlbnRJbmZvEhYKDnJvZ3VlX3N1Yl9t",
            "b2RlGAUgASgNEi8KF3JvZ3VlX2N1cnJlbnRfZ2FtZV9pbmZvGA0gAygLMg4u",
            "Um9ndWVHYW1lSW5mb0IeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3Rv",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueGameInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ChessRogueCurrentInfo), global::EggLink.DanhengServer.Proto.ChessRogueCurrentInfo.Parser, new[]{ "RogueSubMode", "RogueCurrentGameInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ChessRogueCurrentInfo : pb::IMessage<ChessRogueCurrentInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChessRogueCurrentInfo> _parser = new pb::MessageParser<ChessRogueCurrentInfo>(() => new ChessRogueCurrentInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChessRogueCurrentInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ChessRogueCurrentInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueCurrentInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueCurrentInfo(ChessRogueCurrentInfo other) : this() {
      rogueSubMode_ = other.rogueSubMode_;
      rogueCurrentGameInfo_ = other.rogueCurrentGameInfo_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueCurrentInfo Clone() {
      return new ChessRogueCurrentInfo(this);
    }

    /// <summary>Field number for the "rogue_sub_mode" field.</summary>
    public const int RogueSubModeFieldNumber = 5;
    private uint rogueSubMode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RogueSubMode {
      get { return rogueSubMode_; }
      set {
        rogueSubMode_ = value;
      }
    }

    /// <summary>Field number for the "rogue_current_game_info" field.</summary>
    public const int RogueCurrentGameInfoFieldNumber = 13;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.RogueGameInfo> _repeated_rogueCurrentGameInfo_codec
        = pb::FieldCodec.ForMessage(106, global::EggLink.DanhengServer.Proto.RogueGameInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueGameInfo> rogueCurrentGameInfo_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueGameInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueGameInfo> RogueCurrentGameInfo {
      get { return rogueCurrentGameInfo_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChessRogueCurrentInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChessRogueCurrentInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RogueSubMode != other.RogueSubMode) return false;
      if(!rogueCurrentGameInfo_.Equals(other.rogueCurrentGameInfo_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (RogueSubMode != 0) hash ^= RogueSubMode.GetHashCode();
      hash ^= rogueCurrentGameInfo_.GetHashCode();
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
      if (RogueSubMode != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(RogueSubMode);
      }
      rogueCurrentGameInfo_.WriteTo(output, _repeated_rogueCurrentGameInfo_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (RogueSubMode != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(RogueSubMode);
      }
      rogueCurrentGameInfo_.WriteTo(ref output, _repeated_rogueCurrentGameInfo_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (RogueSubMode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RogueSubMode);
      }
      size += rogueCurrentGameInfo_.CalculateSize(_repeated_rogueCurrentGameInfo_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChessRogueCurrentInfo other) {
      if (other == null) {
        return;
      }
      if (other.RogueSubMode != 0) {
        RogueSubMode = other.RogueSubMode;
      }
      rogueCurrentGameInfo_.Add(other.rogueCurrentGameInfo_);
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
          case 40: {
            RogueSubMode = input.ReadUInt32();
            break;
          }
          case 106: {
            rogueCurrentGameInfo_.AddEntriesFrom(input, _repeated_rogueCurrentGameInfo_codec);
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
          case 40: {
            RogueSubMode = input.ReadUInt32();
            break;
          }
          case 106: {
            rogueCurrentGameInfo_.AddEntriesFrom(ref input, _repeated_rogueCurrentGameInfo_codec);
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
