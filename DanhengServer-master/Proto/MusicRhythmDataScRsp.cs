// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MusicRhythmDataScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from MusicRhythmDataScRsp.proto</summary>
  public static partial class MusicRhythmDataScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for MusicRhythmDataScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MusicRhythmDataScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpNdXNpY1JoeXRobURhdGFTY1JzcC5wcm90bxoWTXVzaWNSaHl0aG1MZXZl",
            "bC5wcm90bxoWTXVzaWNSaHl0aG1Hcm91cC5wcm90byKFAgoUTXVzaWNSaHl0",
            "aG1EYXRhU2NSc3ASGQoRdW5sb2NrX3RyYWNrX2xpc3QYByADKA0SGAoQdW5s",
            "b2NrX3NvbmdfbGlzdBgFIAMoDRITCgtjdXJfc29uZ19pZBgLIAEoDRIZChF1",
            "bmxvY2tfcGhhc2VfbGlzdBgMIAMoDRImCgttdXNpY19ncm91cBgDIAMoCzIR",
            "Lk11c2ljUmh5dGhtR3JvdXASFAoMY3VyX2xldmVsX2lkGAEgASgNEg8KB3Jl",
            "dGNvZGUYDiABKA0SJgoLbXVzaWNfbGV2ZWwYCiADKAsyES5NdXNpY1JoeXRo",
            "bUxldmVsEhEKCXNob3dfaGludBgGIAEoCEIeqgIbRWdnTGluay5EYW5oZW5n",
            "U2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.MusicRhythmLevelReflection.Descriptor, global::EggLink.DanhengServer.Proto.MusicRhythmGroupReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.MusicRhythmDataScRsp), global::EggLink.DanhengServer.Proto.MusicRhythmDataScRsp.Parser, new[]{ "UnlockTrackList", "UnlockSongList", "CurSongId", "UnlockPhaseList", "MusicGroup", "CurLevelId", "Retcode", "MusicLevel", "ShowHint" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class MusicRhythmDataScRsp : pb::IMessage<MusicRhythmDataScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MusicRhythmDataScRsp> _parser = new pb::MessageParser<MusicRhythmDataScRsp>(() => new MusicRhythmDataScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MusicRhythmDataScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.MusicRhythmDataScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MusicRhythmDataScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MusicRhythmDataScRsp(MusicRhythmDataScRsp other) : this() {
      unlockTrackList_ = other.unlockTrackList_.Clone();
      unlockSongList_ = other.unlockSongList_.Clone();
      curSongId_ = other.curSongId_;
      unlockPhaseList_ = other.unlockPhaseList_.Clone();
      musicGroup_ = other.musicGroup_.Clone();
      curLevelId_ = other.curLevelId_;
      retcode_ = other.retcode_;
      musicLevel_ = other.musicLevel_.Clone();
      showHint_ = other.showHint_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MusicRhythmDataScRsp Clone() {
      return new MusicRhythmDataScRsp(this);
    }

    /// <summary>Field number for the "unlock_track_list" field.</summary>
    public const int UnlockTrackListFieldNumber = 7;
    private static readonly pb::FieldCodec<uint> _repeated_unlockTrackList_codec
        = pb::FieldCodec.ForUInt32(58);
    private readonly pbc::RepeatedField<uint> unlockTrackList_ = new pbc::RepeatedField<uint>();
    /// <summary>
    /// TODO
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> UnlockTrackList {
      get { return unlockTrackList_; }
    }

    /// <summary>Field number for the "unlock_song_list" field.</summary>
    public const int UnlockSongListFieldNumber = 5;
    private static readonly pb::FieldCodec<uint> _repeated_unlockSongList_codec
        = pb::FieldCodec.ForUInt32(42);
    private readonly pbc::RepeatedField<uint> unlockSongList_ = new pbc::RepeatedField<uint>();
    /// <summary>
    /// TODO
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> UnlockSongList {
      get { return unlockSongList_; }
    }

    /// <summary>Field number for the "cur_song_id" field.</summary>
    public const int CurSongIdFieldNumber = 11;
    private uint curSongId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurSongId {
      get { return curSongId_; }
      set {
        curSongId_ = value;
      }
    }

    /// <summary>Field number for the "unlock_phase_list" field.</summary>
    public const int UnlockPhaseListFieldNumber = 12;
    private static readonly pb::FieldCodec<uint> _repeated_unlockPhaseList_codec
        = pb::FieldCodec.ForUInt32(98);
    private readonly pbc::RepeatedField<uint> unlockPhaseList_ = new pbc::RepeatedField<uint>();
    /// <summary>
    /// TODO
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> UnlockPhaseList {
      get { return unlockPhaseList_; }
    }

    /// <summary>Field number for the "music_group" field.</summary>
    public const int MusicGroupFieldNumber = 3;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.MusicRhythmGroup> _repeated_musicGroup_codec
        = pb::FieldCodec.ForMessage(26, global::EggLink.DanhengServer.Proto.MusicRhythmGroup.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MusicRhythmGroup> musicGroup_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MusicRhythmGroup>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MusicRhythmGroup> MusicGroup {
      get { return musicGroup_; }
    }

    /// <summary>Field number for the "cur_level_id" field.</summary>
    public const int CurLevelIdFieldNumber = 1;
    private uint curLevelId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurLevelId {
      get { return curLevelId_; }
      set {
        curLevelId_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 14;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "music_level" field.</summary>
    public const int MusicLevelFieldNumber = 10;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.MusicRhythmLevel> _repeated_musicLevel_codec
        = pb::FieldCodec.ForMessage(82, global::EggLink.DanhengServer.Proto.MusicRhythmLevel.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MusicRhythmLevel> musicLevel_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MusicRhythmLevel>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MusicRhythmLevel> MusicLevel {
      get { return musicLevel_; }
    }

    /// <summary>Field number for the "show_hint" field.</summary>
    public const int ShowHintFieldNumber = 6;
    private bool showHint_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool ShowHint {
      get { return showHint_; }
      set {
        showHint_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MusicRhythmDataScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MusicRhythmDataScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!unlockTrackList_.Equals(other.unlockTrackList_)) return false;
      if(!unlockSongList_.Equals(other.unlockSongList_)) return false;
      if (CurSongId != other.CurSongId) return false;
      if(!unlockPhaseList_.Equals(other.unlockPhaseList_)) return false;
      if(!musicGroup_.Equals(other.musicGroup_)) return false;
      if (CurLevelId != other.CurLevelId) return false;
      if (Retcode != other.Retcode) return false;
      if(!musicLevel_.Equals(other.musicLevel_)) return false;
      if (ShowHint != other.ShowHint) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= unlockTrackList_.GetHashCode();
      hash ^= unlockSongList_.GetHashCode();
      if (CurSongId != 0) hash ^= CurSongId.GetHashCode();
      hash ^= unlockPhaseList_.GetHashCode();
      hash ^= musicGroup_.GetHashCode();
      if (CurLevelId != 0) hash ^= CurLevelId.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      hash ^= musicLevel_.GetHashCode();
      if (ShowHint != false) hash ^= ShowHint.GetHashCode();
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
      if (CurLevelId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(CurLevelId);
      }
      musicGroup_.WriteTo(output, _repeated_musicGroup_codec);
      unlockSongList_.WriteTo(output, _repeated_unlockSongList_codec);
      if (ShowHint != false) {
        output.WriteRawTag(48);
        output.WriteBool(ShowHint);
      }
      unlockTrackList_.WriteTo(output, _repeated_unlockTrackList_codec);
      musicLevel_.WriteTo(output, _repeated_musicLevel_codec);
      if (CurSongId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(CurSongId);
      }
      unlockPhaseList_.WriteTo(output, _repeated_unlockPhaseList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(112);
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
      if (CurLevelId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(CurLevelId);
      }
      musicGroup_.WriteTo(ref output, _repeated_musicGroup_codec);
      unlockSongList_.WriteTo(ref output, _repeated_unlockSongList_codec);
      if (ShowHint != false) {
        output.WriteRawTag(48);
        output.WriteBool(ShowHint);
      }
      unlockTrackList_.WriteTo(ref output, _repeated_unlockTrackList_codec);
      musicLevel_.WriteTo(ref output, _repeated_musicLevel_codec);
      if (CurSongId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(CurSongId);
      }
      unlockPhaseList_.WriteTo(ref output, _repeated_unlockPhaseList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(112);
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
      size += unlockTrackList_.CalculateSize(_repeated_unlockTrackList_codec);
      size += unlockSongList_.CalculateSize(_repeated_unlockSongList_codec);
      if (CurSongId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurSongId);
      }
      size += unlockPhaseList_.CalculateSize(_repeated_unlockPhaseList_codec);
      size += musicGroup_.CalculateSize(_repeated_musicGroup_codec);
      if (CurLevelId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurLevelId);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      size += musicLevel_.CalculateSize(_repeated_musicLevel_codec);
      if (ShowHint != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MusicRhythmDataScRsp other) {
      if (other == null) {
        return;
      }
      unlockTrackList_.Add(other.unlockTrackList_);
      unlockSongList_.Add(other.unlockSongList_);
      if (other.CurSongId != 0) {
        CurSongId = other.CurSongId;
      }
      unlockPhaseList_.Add(other.unlockPhaseList_);
      musicGroup_.Add(other.musicGroup_);
      if (other.CurLevelId != 0) {
        CurLevelId = other.CurLevelId;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      musicLevel_.Add(other.musicLevel_);
      if (other.ShowHint != false) {
        ShowHint = other.ShowHint;
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
            CurLevelId = input.ReadUInt32();
            break;
          }
          case 26: {
            musicGroup_.AddEntriesFrom(input, _repeated_musicGroup_codec);
            break;
          }
          case 42:
          case 40: {
            unlockSongList_.AddEntriesFrom(input, _repeated_unlockSongList_codec);
            break;
          }
          case 48: {
            ShowHint = input.ReadBool();
            break;
          }
          case 58:
          case 56: {
            unlockTrackList_.AddEntriesFrom(input, _repeated_unlockTrackList_codec);
            break;
          }
          case 82: {
            musicLevel_.AddEntriesFrom(input, _repeated_musicLevel_codec);
            break;
          }
          case 88: {
            CurSongId = input.ReadUInt32();
            break;
          }
          case 98:
          case 96: {
            unlockPhaseList_.AddEntriesFrom(input, _repeated_unlockPhaseList_codec);
            break;
          }
          case 112: {
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
          case 8: {
            CurLevelId = input.ReadUInt32();
            break;
          }
          case 26: {
            musicGroup_.AddEntriesFrom(ref input, _repeated_musicGroup_codec);
            break;
          }
          case 42:
          case 40: {
            unlockSongList_.AddEntriesFrom(ref input, _repeated_unlockSongList_codec);
            break;
          }
          case 48: {
            ShowHint = input.ReadBool();
            break;
          }
          case 58:
          case 56: {
            unlockTrackList_.AddEntriesFrom(ref input, _repeated_unlockTrackList_codec);
            break;
          }
          case 82: {
            musicLevel_.AddEntriesFrom(ref input, _repeated_musicLevel_codec);
            break;
          }
          case 88: {
            CurSongId = input.ReadUInt32();
            break;
          }
          case 98:
          case 96: {
            unlockPhaseList_.AddEntriesFrom(ref input, _repeated_unlockPhaseList_codec);
            break;
          }
          case 112: {
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
