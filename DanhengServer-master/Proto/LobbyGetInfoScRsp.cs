// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: LobbyGetInfoScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from LobbyGetInfoScRsp.proto</summary>
  public static partial class LobbyGetInfoScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for LobbyGetInfoScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LobbyGetInfoScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdMb2JieUdldEluZm9TY1JzcC5wcm90bxoTRmlnaHRHYW1lTW9kZS5wcm90",
            "bxoQTWVtYmVySW5mby5wcm90byKVAQoRTG9iYnlHZXRJbmZvU2NSc3ASDwoH",
            "cmV0Y29kZRgLIAEoDRITCgtGREJPRU9HTlBGQhgHIAEoBBInCg9maWdodF9n",
            "YW1lX21vZGUYCiABKA4yDi5GaWdodEdhbWVNb2RlEg8KB3Jvb21faWQYCSAB",
            "KAQSIAoLbWVtYmVyX2luZm8YCCADKAsyCy5NZW1iZXJJbmZvQh6qAhtFZ2dM",
            "aW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.FightGameModeReflection.Descriptor, global::EggLink.DanhengServer.Proto.MemberInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.LobbyGetInfoScRsp), global::EggLink.DanhengServer.Proto.LobbyGetInfoScRsp.Parser, new[]{ "Retcode", "FDBOEOGNPFB", "FightGameMode", "RoomId", "MemberInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class LobbyGetInfoScRsp : pb::IMessage<LobbyGetInfoScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LobbyGetInfoScRsp> _parser = new pb::MessageParser<LobbyGetInfoScRsp>(() => new LobbyGetInfoScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LobbyGetInfoScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.LobbyGetInfoScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LobbyGetInfoScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LobbyGetInfoScRsp(LobbyGetInfoScRsp other) : this() {
      retcode_ = other.retcode_;
      fDBOEOGNPFB_ = other.fDBOEOGNPFB_;
      fightGameMode_ = other.fightGameMode_;
      roomId_ = other.roomId_;
      memberInfo_ = other.memberInfo_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LobbyGetInfoScRsp Clone() {
      return new LobbyGetInfoScRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 11;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "FDBOEOGNPFB" field.</summary>
    public const int FDBOEOGNPFBFieldNumber = 7;
    private ulong fDBOEOGNPFB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong FDBOEOGNPFB {
      get { return fDBOEOGNPFB_; }
      set {
        fDBOEOGNPFB_ = value;
      }
    }

    /// <summary>Field number for the "fight_game_mode" field.</summary>
    public const int FightGameModeFieldNumber = 10;
    private global::EggLink.DanhengServer.Proto.FightGameMode fightGameMode_ = global::EggLink.DanhengServer.Proto.FightGameMode.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.FightGameMode FightGameMode {
      get { return fightGameMode_; }
      set {
        fightGameMode_ = value;
      }
    }

    /// <summary>Field number for the "room_id" field.</summary>
    public const int RoomIdFieldNumber = 9;
    private ulong roomId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong RoomId {
      get { return roomId_; }
      set {
        roomId_ = value;
      }
    }

    /// <summary>Field number for the "member_info" field.</summary>
    public const int MemberInfoFieldNumber = 8;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.MemberInfo> _repeated_memberInfo_codec
        = pb::FieldCodec.ForMessage(66, global::EggLink.DanhengServer.Proto.MemberInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MemberInfo> memberInfo_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MemberInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MemberInfo> MemberInfo {
      get { return memberInfo_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LobbyGetInfoScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LobbyGetInfoScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (FDBOEOGNPFB != other.FDBOEOGNPFB) return false;
      if (FightGameMode != other.FightGameMode) return false;
      if (RoomId != other.RoomId) return false;
      if(!memberInfo_.Equals(other.memberInfo_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (FDBOEOGNPFB != 0UL) hash ^= FDBOEOGNPFB.GetHashCode();
      if (FightGameMode != global::EggLink.DanhengServer.Proto.FightGameMode.None) hash ^= FightGameMode.GetHashCode();
      if (RoomId != 0UL) hash ^= RoomId.GetHashCode();
      hash ^= memberInfo_.GetHashCode();
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
      if (FDBOEOGNPFB != 0UL) {
        output.WriteRawTag(56);
        output.WriteUInt64(FDBOEOGNPFB);
      }
      memberInfo_.WriteTo(output, _repeated_memberInfo_codec);
      if (RoomId != 0UL) {
        output.WriteRawTag(72);
        output.WriteUInt64(RoomId);
      }
      if (FightGameMode != global::EggLink.DanhengServer.Proto.FightGameMode.None) {
        output.WriteRawTag(80);
        output.WriteEnum((int) FightGameMode);
      }
      if (Retcode != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Retcode);
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
      if (FDBOEOGNPFB != 0UL) {
        output.WriteRawTag(56);
        output.WriteUInt64(FDBOEOGNPFB);
      }
      memberInfo_.WriteTo(ref output, _repeated_memberInfo_codec);
      if (RoomId != 0UL) {
        output.WriteRawTag(72);
        output.WriteUInt64(RoomId);
      }
      if (FightGameMode != global::EggLink.DanhengServer.Proto.FightGameMode.None) {
        output.WriteRawTag(80);
        output.WriteEnum((int) FightGameMode);
      }
      if (Retcode != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Retcode);
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
      if (FDBOEOGNPFB != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(FDBOEOGNPFB);
      }
      if (FightGameMode != global::EggLink.DanhengServer.Proto.FightGameMode.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) FightGameMode);
      }
      if (RoomId != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(RoomId);
      }
      size += memberInfo_.CalculateSize(_repeated_memberInfo_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(LobbyGetInfoScRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.FDBOEOGNPFB != 0UL) {
        FDBOEOGNPFB = other.FDBOEOGNPFB;
      }
      if (other.FightGameMode != global::EggLink.DanhengServer.Proto.FightGameMode.None) {
        FightGameMode = other.FightGameMode;
      }
      if (other.RoomId != 0UL) {
        RoomId = other.RoomId;
      }
      memberInfo_.Add(other.memberInfo_);
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
            FDBOEOGNPFB = input.ReadUInt64();
            break;
          }
          case 66: {
            memberInfo_.AddEntriesFrom(input, _repeated_memberInfo_codec);
            break;
          }
          case 72: {
            RoomId = input.ReadUInt64();
            break;
          }
          case 80: {
            FightGameMode = (global::EggLink.DanhengServer.Proto.FightGameMode) input.ReadEnum();
            break;
          }
          case 88: {
            Retcode = input.ReadUInt32();
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
            FDBOEOGNPFB = input.ReadUInt64();
            break;
          }
          case 66: {
            memberInfo_.AddEntriesFrom(ref input, _repeated_memberInfo_codec);
            break;
          }
          case 72: {
            RoomId = input.ReadUInt64();
            break;
          }
          case 80: {
            FightGameMode = (global::EggLink.DanhengServer.Proto.FightGameMode) input.ReadEnum();
            break;
          }
          case 88: {
            Retcode = input.ReadUInt32();
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
