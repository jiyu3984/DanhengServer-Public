// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SwordTrainingGameSettleScNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SwordTrainingGameSettleScNotify.proto</summary>
  public static partial class SwordTrainingGameSettleScNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for SwordTrainingGameSettleScNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SwordTrainingGameSettleScNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVTd29yZFRyYWluaW5nR2FtZVNldHRsZVNjTm90aWZ5LnByb3RvGhFCT0VI",
            "REtGQURBSC5wcm90bxoOSXRlbUxpc3QucHJvdG8i3wEKH1N3b3JkVHJhaW5p",
            "bmdHYW1lU2V0dGxlU2NOb3RpZnkSGgoSZ2FtZV9zdG9yeV9saW5lX2lkGA4g",
            "ASgNEhwKBnJlYXNvbhgKIAEoDjIMLkJPRUhES0ZBREFIEhMKC0VJRkJLT0pE",
            "RURIGAEgAygNEhMKC01LTUVBRU5MQU1FGAkgASgNEhkKBnJld2FyZBgEIAEo",
            "CzIJLkl0ZW1MaXN0EhMKC0xFS05FUENHT09HGAIgASgNEhMKC0RLSEdDSEFI",
            "T01LGAggASgNEhMKC0ZCQUpHQUlPSUZFGAMgAygNQh6qAhtFZ2dMaW5rLkRh",
            "bmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.BOEHDKFADAHReflection.Descriptor, global::EggLink.DanhengServer.Proto.ItemListReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SwordTrainingGameSettleScNotify), global::EggLink.DanhengServer.Proto.SwordTrainingGameSettleScNotify.Parser, new[]{ "GameStoryLineId", "Reason", "EIFBKOJDEDH", "MKMEAENLAME", "Reward", "LEKNEPCGOOG", "DKHGCHAHOMK", "FBAJGAIOIFE" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SwordTrainingGameSettleScNotify : pb::IMessage<SwordTrainingGameSettleScNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SwordTrainingGameSettleScNotify> _parser = new pb::MessageParser<SwordTrainingGameSettleScNotify>(() => new SwordTrainingGameSettleScNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SwordTrainingGameSettleScNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.SwordTrainingGameSettleScNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SwordTrainingGameSettleScNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SwordTrainingGameSettleScNotify(SwordTrainingGameSettleScNotify other) : this() {
      gameStoryLineId_ = other.gameStoryLineId_;
      reason_ = other.reason_;
      eIFBKOJDEDH_ = other.eIFBKOJDEDH_.Clone();
      mKMEAENLAME_ = other.mKMEAENLAME_;
      reward_ = other.reward_ != null ? other.reward_.Clone() : null;
      lEKNEPCGOOG_ = other.lEKNEPCGOOG_;
      dKHGCHAHOMK_ = other.dKHGCHAHOMK_;
      fBAJGAIOIFE_ = other.fBAJGAIOIFE_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SwordTrainingGameSettleScNotify Clone() {
      return new SwordTrainingGameSettleScNotify(this);
    }

    /// <summary>Field number for the "game_story_line_id" field.</summary>
    public const int GameStoryLineIdFieldNumber = 14;
    private uint gameStoryLineId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GameStoryLineId {
      get { return gameStoryLineId_; }
      set {
        gameStoryLineId_ = value;
      }
    }

    /// <summary>Field number for the "reason" field.</summary>
    public const int ReasonFieldNumber = 10;
    private global::EggLink.DanhengServer.Proto.BOEHDKFADAH reason_ = global::EggLink.DanhengServer.Proto.BOEHDKFADAH.SwordTrainingGameSettleNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.BOEHDKFADAH Reason {
      get { return reason_; }
      set {
        reason_ = value;
      }
    }

    /// <summary>Field number for the "EIFBKOJDEDH" field.</summary>
    public const int EIFBKOJDEDHFieldNumber = 1;
    private static readonly pb::FieldCodec<uint> _repeated_eIFBKOJDEDH_codec
        = pb::FieldCodec.ForUInt32(10);
    private readonly pbc::RepeatedField<uint> eIFBKOJDEDH_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> EIFBKOJDEDH {
      get { return eIFBKOJDEDH_; }
    }

    /// <summary>Field number for the "MKMEAENLAME" field.</summary>
    public const int MKMEAENLAMEFieldNumber = 9;
    private uint mKMEAENLAME_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MKMEAENLAME {
      get { return mKMEAENLAME_; }
      set {
        mKMEAENLAME_ = value;
      }
    }

    /// <summary>Field number for the "reward" field.</summary>
    public const int RewardFieldNumber = 4;
    private global::EggLink.DanhengServer.Proto.ItemList reward_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemList Reward {
      get { return reward_; }
      set {
        reward_ = value;
      }
    }

    /// <summary>Field number for the "LEKNEPCGOOG" field.</summary>
    public const int LEKNEPCGOOGFieldNumber = 2;
    private uint lEKNEPCGOOG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LEKNEPCGOOG {
      get { return lEKNEPCGOOG_; }
      set {
        lEKNEPCGOOG_ = value;
      }
    }

    /// <summary>Field number for the "DKHGCHAHOMK" field.</summary>
    public const int DKHGCHAHOMKFieldNumber = 8;
    private uint dKHGCHAHOMK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DKHGCHAHOMK {
      get { return dKHGCHAHOMK_; }
      set {
        dKHGCHAHOMK_ = value;
      }
    }

    /// <summary>Field number for the "FBAJGAIOIFE" field.</summary>
    public const int FBAJGAIOIFEFieldNumber = 3;
    private static readonly pb::FieldCodec<uint> _repeated_fBAJGAIOIFE_codec
        = pb::FieldCodec.ForUInt32(26);
    private readonly pbc::RepeatedField<uint> fBAJGAIOIFE_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> FBAJGAIOIFE {
      get { return fBAJGAIOIFE_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SwordTrainingGameSettleScNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SwordTrainingGameSettleScNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GameStoryLineId != other.GameStoryLineId) return false;
      if (Reason != other.Reason) return false;
      if(!eIFBKOJDEDH_.Equals(other.eIFBKOJDEDH_)) return false;
      if (MKMEAENLAME != other.MKMEAENLAME) return false;
      if (!object.Equals(Reward, other.Reward)) return false;
      if (LEKNEPCGOOG != other.LEKNEPCGOOG) return false;
      if (DKHGCHAHOMK != other.DKHGCHAHOMK) return false;
      if(!fBAJGAIOIFE_.Equals(other.fBAJGAIOIFE_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (GameStoryLineId != 0) hash ^= GameStoryLineId.GetHashCode();
      if (Reason != global::EggLink.DanhengServer.Proto.BOEHDKFADAH.SwordTrainingGameSettleNone) hash ^= Reason.GetHashCode();
      hash ^= eIFBKOJDEDH_.GetHashCode();
      if (MKMEAENLAME != 0) hash ^= MKMEAENLAME.GetHashCode();
      if (reward_ != null) hash ^= Reward.GetHashCode();
      if (LEKNEPCGOOG != 0) hash ^= LEKNEPCGOOG.GetHashCode();
      if (DKHGCHAHOMK != 0) hash ^= DKHGCHAHOMK.GetHashCode();
      hash ^= fBAJGAIOIFE_.GetHashCode();
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
      eIFBKOJDEDH_.WriteTo(output, _repeated_eIFBKOJDEDH_codec);
      if (LEKNEPCGOOG != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(LEKNEPCGOOG);
      }
      fBAJGAIOIFE_.WriteTo(output, _repeated_fBAJGAIOIFE_codec);
      if (reward_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Reward);
      }
      if (DKHGCHAHOMK != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(DKHGCHAHOMK);
      }
      if (MKMEAENLAME != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(MKMEAENLAME);
      }
      if (Reason != global::EggLink.DanhengServer.Proto.BOEHDKFADAH.SwordTrainingGameSettleNone) {
        output.WriteRawTag(80);
        output.WriteEnum((int) Reason);
      }
      if (GameStoryLineId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(GameStoryLineId);
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
      eIFBKOJDEDH_.WriteTo(ref output, _repeated_eIFBKOJDEDH_codec);
      if (LEKNEPCGOOG != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(LEKNEPCGOOG);
      }
      fBAJGAIOIFE_.WriteTo(ref output, _repeated_fBAJGAIOIFE_codec);
      if (reward_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Reward);
      }
      if (DKHGCHAHOMK != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(DKHGCHAHOMK);
      }
      if (MKMEAENLAME != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(MKMEAENLAME);
      }
      if (Reason != global::EggLink.DanhengServer.Proto.BOEHDKFADAH.SwordTrainingGameSettleNone) {
        output.WriteRawTag(80);
        output.WriteEnum((int) Reason);
      }
      if (GameStoryLineId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(GameStoryLineId);
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
      if (GameStoryLineId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GameStoryLineId);
      }
      if (Reason != global::EggLink.DanhengServer.Proto.BOEHDKFADAH.SwordTrainingGameSettleNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Reason);
      }
      size += eIFBKOJDEDH_.CalculateSize(_repeated_eIFBKOJDEDH_codec);
      if (MKMEAENLAME != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MKMEAENLAME);
      }
      if (reward_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Reward);
      }
      if (LEKNEPCGOOG != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LEKNEPCGOOG);
      }
      if (DKHGCHAHOMK != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DKHGCHAHOMK);
      }
      size += fBAJGAIOIFE_.CalculateSize(_repeated_fBAJGAIOIFE_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SwordTrainingGameSettleScNotify other) {
      if (other == null) {
        return;
      }
      if (other.GameStoryLineId != 0) {
        GameStoryLineId = other.GameStoryLineId;
      }
      if (other.Reason != global::EggLink.DanhengServer.Proto.BOEHDKFADAH.SwordTrainingGameSettleNone) {
        Reason = other.Reason;
      }
      eIFBKOJDEDH_.Add(other.eIFBKOJDEDH_);
      if (other.MKMEAENLAME != 0) {
        MKMEAENLAME = other.MKMEAENLAME;
      }
      if (other.reward_ != null) {
        if (reward_ == null) {
          Reward = new global::EggLink.DanhengServer.Proto.ItemList();
        }
        Reward.MergeFrom(other.Reward);
      }
      if (other.LEKNEPCGOOG != 0) {
        LEKNEPCGOOG = other.LEKNEPCGOOG;
      }
      if (other.DKHGCHAHOMK != 0) {
        DKHGCHAHOMK = other.DKHGCHAHOMK;
      }
      fBAJGAIOIFE_.Add(other.fBAJGAIOIFE_);
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
          case 10:
          case 8: {
            eIFBKOJDEDH_.AddEntriesFrom(input, _repeated_eIFBKOJDEDH_codec);
            break;
          }
          case 16: {
            LEKNEPCGOOG = input.ReadUInt32();
            break;
          }
          case 26:
          case 24: {
            fBAJGAIOIFE_.AddEntriesFrom(input, _repeated_fBAJGAIOIFE_codec);
            break;
          }
          case 34: {
            if (reward_ == null) {
              Reward = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(Reward);
            break;
          }
          case 64: {
            DKHGCHAHOMK = input.ReadUInt32();
            break;
          }
          case 72: {
            MKMEAENLAME = input.ReadUInt32();
            break;
          }
          case 80: {
            Reason = (global::EggLink.DanhengServer.Proto.BOEHDKFADAH) input.ReadEnum();
            break;
          }
          case 112: {
            GameStoryLineId = input.ReadUInt32();
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
          case 10:
          case 8: {
            eIFBKOJDEDH_.AddEntriesFrom(ref input, _repeated_eIFBKOJDEDH_codec);
            break;
          }
          case 16: {
            LEKNEPCGOOG = input.ReadUInt32();
            break;
          }
          case 26:
          case 24: {
            fBAJGAIOIFE_.AddEntriesFrom(ref input, _repeated_fBAJGAIOIFE_codec);
            break;
          }
          case 34: {
            if (reward_ == null) {
              Reward = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(Reward);
            break;
          }
          case 64: {
            DKHGCHAHOMK = input.ReadUInt32();
            break;
          }
          case 72: {
            MKMEAENLAME = input.ReadUInt32();
            break;
          }
          case 80: {
            Reason = (global::EggLink.DanhengServer.Proto.BOEHDKFADAH) input.ReadEnum();
            break;
          }
          case 112: {
            GameStoryLineId = input.ReadUInt32();
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