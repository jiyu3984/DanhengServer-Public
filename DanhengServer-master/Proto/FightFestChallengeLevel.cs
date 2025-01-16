// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FightFestChallengeLevel.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from FightFestChallengeLevel.proto</summary>
  public static partial class FightFestChallengeLevelReflection {

    #region Descriptor
    /// <summary>File descriptor for FightFestChallengeLevel.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FightFestChallengeLevelReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1GaWdodEZlc3RDaGFsbGVuZ2VMZXZlbC5wcm90bxoZRmlnaHRGZXN0QmF0",
            "dGxlUmFuay5wcm90byKJAQoXRmlnaHRGZXN0Q2hhbGxlbmdlTGV2ZWwSLQoP",
            "ZmV2ZXJfdGltZV9yYW5rGAogASgOMhQuRmlnaHRGZXN0QmF0dGxlUmFuaxIQ",
            "CghmZXZlcl9pZBgCIAEoDRIUCgxjaGFsbGVuZ2VfaWQYAyABKA0SFwoPdHVy",
            "bl9sZWZ0X2NvdW50GAsgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIu",
            "UHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.FightFestBattleRankReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.FightFestChallengeLevel), global::EggLink.DanhengServer.Proto.FightFestChallengeLevel.Parser, new[]{ "FeverTimeRank", "FeverId", "ChallengeId", "TurnLeftCount" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class FightFestChallengeLevel : pb::IMessage<FightFestChallengeLevel>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FightFestChallengeLevel> _parser = new pb::MessageParser<FightFestChallengeLevel>(() => new FightFestChallengeLevel());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FightFestChallengeLevel> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.FightFestChallengeLevelReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FightFestChallengeLevel() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FightFestChallengeLevel(FightFestChallengeLevel other) : this() {
      feverTimeRank_ = other.feverTimeRank_;
      feverId_ = other.feverId_;
      challengeId_ = other.challengeId_;
      turnLeftCount_ = other.turnLeftCount_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FightFestChallengeLevel Clone() {
      return new FightFestChallengeLevel(this);
    }

    /// <summary>Field number for the "fever_time_rank" field.</summary>
    public const int FeverTimeRankFieldNumber = 10;
    private global::EggLink.DanhengServer.Proto.FightFestBattleRank feverTimeRank_ = global::EggLink.DanhengServer.Proto.FightFestBattleRank.C;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.FightFestBattleRank FeverTimeRank {
      get { return feverTimeRank_; }
      set {
        feverTimeRank_ = value;
      }
    }

    /// <summary>Field number for the "fever_id" field.</summary>
    public const int FeverIdFieldNumber = 2;
    private uint feverId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FeverId {
      get { return feverId_; }
      set {
        feverId_ = value;
      }
    }

    /// <summary>Field number for the "challenge_id" field.</summary>
    public const int ChallengeIdFieldNumber = 3;
    private uint challengeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChallengeId {
      get { return challengeId_; }
      set {
        challengeId_ = value;
      }
    }

    /// <summary>Field number for the "turn_left_count" field.</summary>
    public const int TurnLeftCountFieldNumber = 11;
    private uint turnLeftCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TurnLeftCount {
      get { return turnLeftCount_; }
      set {
        turnLeftCount_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FightFestChallengeLevel);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FightFestChallengeLevel other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FeverTimeRank != other.FeverTimeRank) return false;
      if (FeverId != other.FeverId) return false;
      if (ChallengeId != other.ChallengeId) return false;
      if (TurnLeftCount != other.TurnLeftCount) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (FeverTimeRank != global::EggLink.DanhengServer.Proto.FightFestBattleRank.C) hash ^= FeverTimeRank.GetHashCode();
      if (FeverId != 0) hash ^= FeverId.GetHashCode();
      if (ChallengeId != 0) hash ^= ChallengeId.GetHashCode();
      if (TurnLeftCount != 0) hash ^= TurnLeftCount.GetHashCode();
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
      if (FeverId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(FeverId);
      }
      if (ChallengeId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ChallengeId);
      }
      if (FeverTimeRank != global::EggLink.DanhengServer.Proto.FightFestBattleRank.C) {
        output.WriteRawTag(80);
        output.WriteEnum((int) FeverTimeRank);
      }
      if (TurnLeftCount != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(TurnLeftCount);
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
      if (FeverId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(FeverId);
      }
      if (ChallengeId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ChallengeId);
      }
      if (FeverTimeRank != global::EggLink.DanhengServer.Proto.FightFestBattleRank.C) {
        output.WriteRawTag(80);
        output.WriteEnum((int) FeverTimeRank);
      }
      if (TurnLeftCount != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(TurnLeftCount);
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
      if (FeverTimeRank != global::EggLink.DanhengServer.Proto.FightFestBattleRank.C) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) FeverTimeRank);
      }
      if (FeverId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FeverId);
      }
      if (ChallengeId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeId);
      }
      if (TurnLeftCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TurnLeftCount);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FightFestChallengeLevel other) {
      if (other == null) {
        return;
      }
      if (other.FeverTimeRank != global::EggLink.DanhengServer.Proto.FightFestBattleRank.C) {
        FeverTimeRank = other.FeverTimeRank;
      }
      if (other.FeverId != 0) {
        FeverId = other.FeverId;
      }
      if (other.ChallengeId != 0) {
        ChallengeId = other.ChallengeId;
      }
      if (other.TurnLeftCount != 0) {
        TurnLeftCount = other.TurnLeftCount;
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
            FeverId = input.ReadUInt32();
            break;
          }
          case 24: {
            ChallengeId = input.ReadUInt32();
            break;
          }
          case 80: {
            FeverTimeRank = (global::EggLink.DanhengServer.Proto.FightFestBattleRank) input.ReadEnum();
            break;
          }
          case 88: {
            TurnLeftCount = input.ReadUInt32();
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
            FeverId = input.ReadUInt32();
            break;
          }
          case 24: {
            ChallengeId = input.ReadUInt32();
            break;
          }
          case 80: {
            FeverTimeRank = (global::EggLink.DanhengServer.Proto.FightFestBattleRank) input.ReadEnum();
            break;
          }
          case 88: {
            TurnLeftCount = input.ReadUInt32();
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