// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HeliobusActivityDataScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from HeliobusActivityDataScRsp.proto</summary>
  public static partial class HeliobusActivityDataScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for HeliobusActivityDataScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HeliobusActivityDataScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9IZWxpb2J1c0FjdGl2aXR5RGF0YVNjUnNwLnByb3RvGhFGSEhDSUZKT0NC",
            "UC5wcm90bxodSGVsaW9idXNDaGFsbGVuZ2VMaW5ldXAucHJvdG8aEU5KT05G",
            "RExOS0NNLnByb3RvGhNDaGFsbGVuZ2VMaXN0LnByb3RvIqUCChlIZWxpb2J1",
            "c0FjdGl2aXR5RGF0YVNjUnNwEi0KC0JLTEhGTUtFSFBGGA4gAygLMhguSGVs",
            "aW9idXNDaGFsbGVuZ2VMaW5ldXASJgoOY2hhbGxlbmdlX2xpc3QYAiADKAsy",
            "Di5DaGFsbGVuZ2VMaXN0Eg8KB3JldGNvZGUYASABKA0SEwoLTE1CUEtFT0JN",
            "SEsYCSABKA0SDQoFcGhhc2UYBiABKA0SEwoLREhHSVBPSERPUE0YCiABKA0S",
            "DQoFbGV2ZWwYBSABKA0SEwoLS01JT0NFT0ROT00YCCABKA0SIAoKc2tpbGxf",
            "aW5mbxgNIAEoCzIMLk5KT05GRExOS0NNEiEKC01DUEVKTERHR0dIGA8gAygL",
            "MgwuRkhIQ0lGSk9DQlBCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90",
            "b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.FHHCIFJOCBPReflection.Descriptor, global::EggLink.DanhengServer.Proto.HeliobusChallengeLineupReflection.Descriptor, global::EggLink.DanhengServer.Proto.NJONFDLNKCMReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChallengeListReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.HeliobusActivityDataScRsp), global::EggLink.DanhengServer.Proto.HeliobusActivityDataScRsp.Parser, new[]{ "BKLHFMKEHPF", "ChallengeList", "Retcode", "LMBPKEOBMHK", "Phase", "DHGIPOHDOPM", "Level", "KMIOCEODNOM", "SkillInfo", "MCPEJLDGGGH" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class HeliobusActivityDataScRsp : pb::IMessage<HeliobusActivityDataScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HeliobusActivityDataScRsp> _parser = new pb::MessageParser<HeliobusActivityDataScRsp>(() => new HeliobusActivityDataScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HeliobusActivityDataScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.HeliobusActivityDataScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HeliobusActivityDataScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HeliobusActivityDataScRsp(HeliobusActivityDataScRsp other) : this() {
      bKLHFMKEHPF_ = other.bKLHFMKEHPF_.Clone();
      challengeList_ = other.challengeList_.Clone();
      retcode_ = other.retcode_;
      lMBPKEOBMHK_ = other.lMBPKEOBMHK_;
      phase_ = other.phase_;
      dHGIPOHDOPM_ = other.dHGIPOHDOPM_;
      level_ = other.level_;
      kMIOCEODNOM_ = other.kMIOCEODNOM_;
      skillInfo_ = other.skillInfo_ != null ? other.skillInfo_.Clone() : null;
      mCPEJLDGGGH_ = other.mCPEJLDGGGH_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HeliobusActivityDataScRsp Clone() {
      return new HeliobusActivityDataScRsp(this);
    }

    /// <summary>Field number for the "BKLHFMKEHPF" field.</summary>
    public const int BKLHFMKEHPFFieldNumber = 14;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.HeliobusChallengeLineup> _repeated_bKLHFMKEHPF_codec
        = pb::FieldCodec.ForMessage(114, global::EggLink.DanhengServer.Proto.HeliobusChallengeLineup.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.HeliobusChallengeLineup> bKLHFMKEHPF_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.HeliobusChallengeLineup>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.HeliobusChallengeLineup> BKLHFMKEHPF {
      get { return bKLHFMKEHPF_; }
    }

    /// <summary>Field number for the "challenge_list" field.</summary>
    public const int ChallengeListFieldNumber = 2;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.ChallengeList> _repeated_challengeList_codec
        = pb::FieldCodec.ForMessage(18, global::EggLink.DanhengServer.Proto.ChallengeList.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ChallengeList> challengeList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ChallengeList>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ChallengeList> ChallengeList {
      get { return challengeList_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 1;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "LMBPKEOBMHK" field.</summary>
    public const int LMBPKEOBMHKFieldNumber = 9;
    private uint lMBPKEOBMHK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LMBPKEOBMHK {
      get { return lMBPKEOBMHK_; }
      set {
        lMBPKEOBMHK_ = value;
      }
    }

    /// <summary>Field number for the "phase" field.</summary>
    public const int PhaseFieldNumber = 6;
    private uint phase_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Phase {
      get { return phase_; }
      set {
        phase_ = value;
      }
    }

    /// <summary>Field number for the "DHGIPOHDOPM" field.</summary>
    public const int DHGIPOHDOPMFieldNumber = 10;
    private uint dHGIPOHDOPM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DHGIPOHDOPM {
      get { return dHGIPOHDOPM_; }
      set {
        dHGIPOHDOPM_ = value;
      }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 5;
    private uint level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "KMIOCEODNOM" field.</summary>
    public const int KMIOCEODNOMFieldNumber = 8;
    private uint kMIOCEODNOM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KMIOCEODNOM {
      get { return kMIOCEODNOM_; }
      set {
        kMIOCEODNOM_ = value;
      }
    }

    /// <summary>Field number for the "skill_info" field.</summary>
    public const int SkillInfoFieldNumber = 13;
    private global::EggLink.DanhengServer.Proto.NJONFDLNKCM skillInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.NJONFDLNKCM SkillInfo {
      get { return skillInfo_; }
      set {
        skillInfo_ = value;
      }
    }

    /// <summary>Field number for the "MCPEJLDGGGH" field.</summary>
    public const int MCPEJLDGGGHFieldNumber = 15;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.FHHCIFJOCBP> _repeated_mCPEJLDGGGH_codec
        = pb::FieldCodec.ForMessage(122, global::EggLink.DanhengServer.Proto.FHHCIFJOCBP.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.FHHCIFJOCBP> mCPEJLDGGGH_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.FHHCIFJOCBP>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.FHHCIFJOCBP> MCPEJLDGGGH {
      get { return mCPEJLDGGGH_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HeliobusActivityDataScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HeliobusActivityDataScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!bKLHFMKEHPF_.Equals(other.bKLHFMKEHPF_)) return false;
      if(!challengeList_.Equals(other.challengeList_)) return false;
      if (Retcode != other.Retcode) return false;
      if (LMBPKEOBMHK != other.LMBPKEOBMHK) return false;
      if (Phase != other.Phase) return false;
      if (DHGIPOHDOPM != other.DHGIPOHDOPM) return false;
      if (Level != other.Level) return false;
      if (KMIOCEODNOM != other.KMIOCEODNOM) return false;
      if (!object.Equals(SkillInfo, other.SkillInfo)) return false;
      if(!mCPEJLDGGGH_.Equals(other.mCPEJLDGGGH_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= bKLHFMKEHPF_.GetHashCode();
      hash ^= challengeList_.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (LMBPKEOBMHK != 0) hash ^= LMBPKEOBMHK.GetHashCode();
      if (Phase != 0) hash ^= Phase.GetHashCode();
      if (DHGIPOHDOPM != 0) hash ^= DHGIPOHDOPM.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
      if (KMIOCEODNOM != 0) hash ^= KMIOCEODNOM.GetHashCode();
      if (skillInfo_ != null) hash ^= SkillInfo.GetHashCode();
      hash ^= mCPEJLDGGGH_.GetHashCode();
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
        output.WriteRawTag(8);
        output.WriteUInt32(Retcode);
      }
      challengeList_.WriteTo(output, _repeated_challengeList_codec);
      if (Level != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Level);
      }
      if (Phase != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Phase);
      }
      if (KMIOCEODNOM != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(KMIOCEODNOM);
      }
      if (LMBPKEOBMHK != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(LMBPKEOBMHK);
      }
      if (DHGIPOHDOPM != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(DHGIPOHDOPM);
      }
      if (skillInfo_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(SkillInfo);
      }
      bKLHFMKEHPF_.WriteTo(output, _repeated_bKLHFMKEHPF_codec);
      mCPEJLDGGGH_.WriteTo(output, _repeated_mCPEJLDGGGH_codec);
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
        output.WriteRawTag(8);
        output.WriteUInt32(Retcode);
      }
      challengeList_.WriteTo(ref output, _repeated_challengeList_codec);
      if (Level != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Level);
      }
      if (Phase != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Phase);
      }
      if (KMIOCEODNOM != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(KMIOCEODNOM);
      }
      if (LMBPKEOBMHK != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(LMBPKEOBMHK);
      }
      if (DHGIPOHDOPM != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(DHGIPOHDOPM);
      }
      if (skillInfo_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(SkillInfo);
      }
      bKLHFMKEHPF_.WriteTo(ref output, _repeated_bKLHFMKEHPF_codec);
      mCPEJLDGGGH_.WriteTo(ref output, _repeated_mCPEJLDGGGH_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += bKLHFMKEHPF_.CalculateSize(_repeated_bKLHFMKEHPF_codec);
      size += challengeList_.CalculateSize(_repeated_challengeList_codec);
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (LMBPKEOBMHK != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LMBPKEOBMHK);
      }
      if (Phase != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Phase);
      }
      if (DHGIPOHDOPM != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DHGIPOHDOPM);
      }
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Level);
      }
      if (KMIOCEODNOM != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KMIOCEODNOM);
      }
      if (skillInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SkillInfo);
      }
      size += mCPEJLDGGGH_.CalculateSize(_repeated_mCPEJLDGGGH_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HeliobusActivityDataScRsp other) {
      if (other == null) {
        return;
      }
      bKLHFMKEHPF_.Add(other.bKLHFMKEHPF_);
      challengeList_.Add(other.challengeList_);
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.LMBPKEOBMHK != 0) {
        LMBPKEOBMHK = other.LMBPKEOBMHK;
      }
      if (other.Phase != 0) {
        Phase = other.Phase;
      }
      if (other.DHGIPOHDOPM != 0) {
        DHGIPOHDOPM = other.DHGIPOHDOPM;
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
      if (other.KMIOCEODNOM != 0) {
        KMIOCEODNOM = other.KMIOCEODNOM;
      }
      if (other.skillInfo_ != null) {
        if (skillInfo_ == null) {
          SkillInfo = new global::EggLink.DanhengServer.Proto.NJONFDLNKCM();
        }
        SkillInfo.MergeFrom(other.SkillInfo);
      }
      mCPEJLDGGGH_.Add(other.mCPEJLDGGGH_);
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
            Retcode = input.ReadUInt32();
            break;
          }
          case 18: {
            challengeList_.AddEntriesFrom(input, _repeated_challengeList_codec);
            break;
          }
          case 40: {
            Level = input.ReadUInt32();
            break;
          }
          case 48: {
            Phase = input.ReadUInt32();
            break;
          }
          case 64: {
            KMIOCEODNOM = input.ReadUInt32();
            break;
          }
          case 72: {
            LMBPKEOBMHK = input.ReadUInt32();
            break;
          }
          case 80: {
            DHGIPOHDOPM = input.ReadUInt32();
            break;
          }
          case 106: {
            if (skillInfo_ == null) {
              SkillInfo = new global::EggLink.DanhengServer.Proto.NJONFDLNKCM();
            }
            input.ReadMessage(SkillInfo);
            break;
          }
          case 114: {
            bKLHFMKEHPF_.AddEntriesFrom(input, _repeated_bKLHFMKEHPF_codec);
            break;
          }
          case 122: {
            mCPEJLDGGGH_.AddEntriesFrom(input, _repeated_mCPEJLDGGGH_codec);
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
            Retcode = input.ReadUInt32();
            break;
          }
          case 18: {
            challengeList_.AddEntriesFrom(ref input, _repeated_challengeList_codec);
            break;
          }
          case 40: {
            Level = input.ReadUInt32();
            break;
          }
          case 48: {
            Phase = input.ReadUInt32();
            break;
          }
          case 64: {
            KMIOCEODNOM = input.ReadUInt32();
            break;
          }
          case 72: {
            LMBPKEOBMHK = input.ReadUInt32();
            break;
          }
          case 80: {
            DHGIPOHDOPM = input.ReadUInt32();
            break;
          }
          case 106: {
            if (skillInfo_ == null) {
              SkillInfo = new global::EggLink.DanhengServer.Proto.NJONFDLNKCM();
            }
            input.ReadMessage(SkillInfo);
            break;
          }
          case 114: {
            bKLHFMKEHPF_.AddEntriesFrom(ref input, _repeated_bKLHFMKEHPF_codec);
            break;
          }
          case 122: {
            mCPEJLDGGGH_.AddEntriesFrom(ref input, _repeated_mCPEJLDGGGH_codec);
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
