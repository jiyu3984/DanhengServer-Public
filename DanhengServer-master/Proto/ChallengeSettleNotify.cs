// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChallengeSettleNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ChallengeSettleNotify.proto</summary>
  public static partial class ChallengeSettleNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for ChallengeSettleNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChallengeSettleNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtDaGFsbGVuZ2VTZXR0bGVOb3RpZnkucHJvdG8aEkN1ckNoYWxsZW5nZS5w",
            "cm90bxoRRUFMQkdGTUdDRUcucHJvdG8aDkl0ZW1MaXN0LnByb3RvIoUCChVD",
            "aGFsbGVuZ2VTZXR0bGVOb3RpZnkSEwoLTkZESkdBSkJNRE8YBCABKA0SIQoL",
            "UENOT1BIQlBHSksYDiABKAsyDC5FQUxCR0ZNR0NFRxIkCg1jdXJfY2hhbGxl",
            "bmdlGAwgASgLMg0uQ3VyQ2hhbGxlbmdlEhEKCXNjb3JlX3R3bxgPIAEoDRIM",
            "CgRzdGFyGAEgASgNEhMKC05QSkdETk1JQkxQGAggAygNEhkKBnJld2FyZBgK",
            "IAEoCzIJLkl0ZW1MaXN0EhQKDGNoYWxsZW5nZV9pZBgHIAEoDRIXCg9jaGFs",
            "bGVuZ2Vfc2NvcmUYCSABKA0SDgoGaXNfd2luGAIgASgIQh6qAhtFZ2dMaW5r",
            "LkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.CurChallengeReflection.Descriptor, global::EggLink.DanhengServer.Proto.EALBGFMGCEGReflection.Descriptor, global::EggLink.DanhengServer.Proto.ItemListReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ChallengeSettleNotify), global::EggLink.DanhengServer.Proto.ChallengeSettleNotify.Parser, new[]{ "NFDJGAJBMDO", "PCNOPHBPGJK", "CurChallenge", "ScoreTwo", "Star", "NPJGDNMIBLP", "Reward", "ChallengeId", "ChallengeScore", "IsWin" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ChallengeSettleNotify : pb::IMessage<ChallengeSettleNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChallengeSettleNotify> _parser = new pb::MessageParser<ChallengeSettleNotify>(() => new ChallengeSettleNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChallengeSettleNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ChallengeSettleNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChallengeSettleNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChallengeSettleNotify(ChallengeSettleNotify other) : this() {
      nFDJGAJBMDO_ = other.nFDJGAJBMDO_;
      pCNOPHBPGJK_ = other.pCNOPHBPGJK_ != null ? other.pCNOPHBPGJK_.Clone() : null;
      curChallenge_ = other.curChallenge_ != null ? other.curChallenge_.Clone() : null;
      scoreTwo_ = other.scoreTwo_;
      star_ = other.star_;
      nPJGDNMIBLP_ = other.nPJGDNMIBLP_.Clone();
      reward_ = other.reward_ != null ? other.reward_.Clone() : null;
      challengeId_ = other.challengeId_;
      challengeScore_ = other.challengeScore_;
      isWin_ = other.isWin_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChallengeSettleNotify Clone() {
      return new ChallengeSettleNotify(this);
    }

    /// <summary>Field number for the "NFDJGAJBMDO" field.</summary>
    public const int NFDJGAJBMDOFieldNumber = 4;
    private uint nFDJGAJBMDO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NFDJGAJBMDO {
      get { return nFDJGAJBMDO_; }
      set {
        nFDJGAJBMDO_ = value;
      }
    }

    /// <summary>Field number for the "PCNOPHBPGJK" field.</summary>
    public const int PCNOPHBPGJKFieldNumber = 14;
    private global::EggLink.DanhengServer.Proto.EALBGFMGCEG pCNOPHBPGJK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.EALBGFMGCEG PCNOPHBPGJK {
      get { return pCNOPHBPGJK_; }
      set {
        pCNOPHBPGJK_ = value;
      }
    }

    /// <summary>Field number for the "cur_challenge" field.</summary>
    public const int CurChallengeFieldNumber = 12;
    private global::EggLink.DanhengServer.Proto.CurChallenge curChallenge_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.CurChallenge CurChallenge {
      get { return curChallenge_; }
      set {
        curChallenge_ = value;
      }
    }

    /// <summary>Field number for the "score_two" field.</summary>
    public const int ScoreTwoFieldNumber = 15;
    private uint scoreTwo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ScoreTwo {
      get { return scoreTwo_; }
      set {
        scoreTwo_ = value;
      }
    }

    /// <summary>Field number for the "star" field.</summary>
    public const int StarFieldNumber = 1;
    private uint star_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Star {
      get { return star_; }
      set {
        star_ = value;
      }
    }

    /// <summary>Field number for the "NPJGDNMIBLP" field.</summary>
    public const int NPJGDNMIBLPFieldNumber = 8;
    private static readonly pb::FieldCodec<uint> _repeated_nPJGDNMIBLP_codec
        = pb::FieldCodec.ForUInt32(66);
    private readonly pbc::RepeatedField<uint> nPJGDNMIBLP_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> NPJGDNMIBLP {
      get { return nPJGDNMIBLP_; }
    }

    /// <summary>Field number for the "reward" field.</summary>
    public const int RewardFieldNumber = 10;
    private global::EggLink.DanhengServer.Proto.ItemList reward_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemList Reward {
      get { return reward_; }
      set {
        reward_ = value;
      }
    }

    /// <summary>Field number for the "challenge_id" field.</summary>
    public const int ChallengeIdFieldNumber = 7;
    private uint challengeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChallengeId {
      get { return challengeId_; }
      set {
        challengeId_ = value;
      }
    }

    /// <summary>Field number for the "challenge_score" field.</summary>
    public const int ChallengeScoreFieldNumber = 9;
    private uint challengeScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChallengeScore {
      get { return challengeScore_; }
      set {
        challengeScore_ = value;
      }
    }

    /// <summary>Field number for the "is_win" field.</summary>
    public const int IsWinFieldNumber = 2;
    private bool isWin_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsWin {
      get { return isWin_; }
      set {
        isWin_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChallengeSettleNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChallengeSettleNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (NFDJGAJBMDO != other.NFDJGAJBMDO) return false;
      if (!object.Equals(PCNOPHBPGJK, other.PCNOPHBPGJK)) return false;
      if (!object.Equals(CurChallenge, other.CurChallenge)) return false;
      if (ScoreTwo != other.ScoreTwo) return false;
      if (Star != other.Star) return false;
      if(!nPJGDNMIBLP_.Equals(other.nPJGDNMIBLP_)) return false;
      if (!object.Equals(Reward, other.Reward)) return false;
      if (ChallengeId != other.ChallengeId) return false;
      if (ChallengeScore != other.ChallengeScore) return false;
      if (IsWin != other.IsWin) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (NFDJGAJBMDO != 0) hash ^= NFDJGAJBMDO.GetHashCode();
      if (pCNOPHBPGJK_ != null) hash ^= PCNOPHBPGJK.GetHashCode();
      if (curChallenge_ != null) hash ^= CurChallenge.GetHashCode();
      if (ScoreTwo != 0) hash ^= ScoreTwo.GetHashCode();
      if (Star != 0) hash ^= Star.GetHashCode();
      hash ^= nPJGDNMIBLP_.GetHashCode();
      if (reward_ != null) hash ^= Reward.GetHashCode();
      if (ChallengeId != 0) hash ^= ChallengeId.GetHashCode();
      if (ChallengeScore != 0) hash ^= ChallengeScore.GetHashCode();
      if (IsWin != false) hash ^= IsWin.GetHashCode();
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
      if (Star != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Star);
      }
      if (IsWin != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsWin);
      }
      if (NFDJGAJBMDO != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(NFDJGAJBMDO);
      }
      if (ChallengeId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(ChallengeId);
      }
      nPJGDNMIBLP_.WriteTo(output, _repeated_nPJGDNMIBLP_codec);
      if (ChallengeScore != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(ChallengeScore);
      }
      if (reward_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(Reward);
      }
      if (curChallenge_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(CurChallenge);
      }
      if (pCNOPHBPGJK_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(PCNOPHBPGJK);
      }
      if (ScoreTwo != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(ScoreTwo);
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
      if (Star != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Star);
      }
      if (IsWin != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsWin);
      }
      if (NFDJGAJBMDO != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(NFDJGAJBMDO);
      }
      if (ChallengeId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(ChallengeId);
      }
      nPJGDNMIBLP_.WriteTo(ref output, _repeated_nPJGDNMIBLP_codec);
      if (ChallengeScore != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(ChallengeScore);
      }
      if (reward_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(Reward);
      }
      if (curChallenge_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(CurChallenge);
      }
      if (pCNOPHBPGJK_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(PCNOPHBPGJK);
      }
      if (ScoreTwo != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(ScoreTwo);
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
      if (NFDJGAJBMDO != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NFDJGAJBMDO);
      }
      if (pCNOPHBPGJK_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PCNOPHBPGJK);
      }
      if (curChallenge_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CurChallenge);
      }
      if (ScoreTwo != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ScoreTwo);
      }
      if (Star != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Star);
      }
      size += nPJGDNMIBLP_.CalculateSize(_repeated_nPJGDNMIBLP_codec);
      if (reward_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Reward);
      }
      if (ChallengeId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeId);
      }
      if (ChallengeScore != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeScore);
      }
      if (IsWin != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChallengeSettleNotify other) {
      if (other == null) {
        return;
      }
      if (other.NFDJGAJBMDO != 0) {
        NFDJGAJBMDO = other.NFDJGAJBMDO;
      }
      if (other.pCNOPHBPGJK_ != null) {
        if (pCNOPHBPGJK_ == null) {
          PCNOPHBPGJK = new global::EggLink.DanhengServer.Proto.EALBGFMGCEG();
        }
        PCNOPHBPGJK.MergeFrom(other.PCNOPHBPGJK);
      }
      if (other.curChallenge_ != null) {
        if (curChallenge_ == null) {
          CurChallenge = new global::EggLink.DanhengServer.Proto.CurChallenge();
        }
        CurChallenge.MergeFrom(other.CurChallenge);
      }
      if (other.ScoreTwo != 0) {
        ScoreTwo = other.ScoreTwo;
      }
      if (other.Star != 0) {
        Star = other.Star;
      }
      nPJGDNMIBLP_.Add(other.nPJGDNMIBLP_);
      if (other.reward_ != null) {
        if (reward_ == null) {
          Reward = new global::EggLink.DanhengServer.Proto.ItemList();
        }
        Reward.MergeFrom(other.Reward);
      }
      if (other.ChallengeId != 0) {
        ChallengeId = other.ChallengeId;
      }
      if (other.ChallengeScore != 0) {
        ChallengeScore = other.ChallengeScore;
      }
      if (other.IsWin != false) {
        IsWin = other.IsWin;
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
            Star = input.ReadUInt32();
            break;
          }
          case 16: {
            IsWin = input.ReadBool();
            break;
          }
          case 32: {
            NFDJGAJBMDO = input.ReadUInt32();
            break;
          }
          case 56: {
            ChallengeId = input.ReadUInt32();
            break;
          }
          case 66:
          case 64: {
            nPJGDNMIBLP_.AddEntriesFrom(input, _repeated_nPJGDNMIBLP_codec);
            break;
          }
          case 72: {
            ChallengeScore = input.ReadUInt32();
            break;
          }
          case 82: {
            if (reward_ == null) {
              Reward = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(Reward);
            break;
          }
          case 98: {
            if (curChallenge_ == null) {
              CurChallenge = new global::EggLink.DanhengServer.Proto.CurChallenge();
            }
            input.ReadMessage(CurChallenge);
            break;
          }
          case 114: {
            if (pCNOPHBPGJK_ == null) {
              PCNOPHBPGJK = new global::EggLink.DanhengServer.Proto.EALBGFMGCEG();
            }
            input.ReadMessage(PCNOPHBPGJK);
            break;
          }
          case 120: {
            ScoreTwo = input.ReadUInt32();
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
            Star = input.ReadUInt32();
            break;
          }
          case 16: {
            IsWin = input.ReadBool();
            break;
          }
          case 32: {
            NFDJGAJBMDO = input.ReadUInt32();
            break;
          }
          case 56: {
            ChallengeId = input.ReadUInt32();
            break;
          }
          case 66:
          case 64: {
            nPJGDNMIBLP_.AddEntriesFrom(ref input, _repeated_nPJGDNMIBLP_codec);
            break;
          }
          case 72: {
            ChallengeScore = input.ReadUInt32();
            break;
          }
          case 82: {
            if (reward_ == null) {
              Reward = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(Reward);
            break;
          }
          case 98: {
            if (curChallenge_ == null) {
              CurChallenge = new global::EggLink.DanhengServer.Proto.CurChallenge();
            }
            input.ReadMessage(CurChallenge);
            break;
          }
          case 114: {
            if (pCNOPHBPGJK_ == null) {
              PCNOPHBPGJK = new global::EggLink.DanhengServer.Proto.EALBGFMGCEG();
            }
            input.ReadMessage(PCNOPHBPGJK);
            break;
          }
          case 120: {
            ScoreTwo = input.ReadUInt32();
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
