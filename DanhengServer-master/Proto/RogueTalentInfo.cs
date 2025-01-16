// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueTalentInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueTalentInfo.proto</summary>
  public static partial class RogueTalentInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueTalentInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueTalentInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVSb2d1ZVRhbGVudEluZm8ucHJvdG8aGVJvZ3VlVW5sb2NrUHJvZ3Jlc3Mu",
            "cHJvdG8aF1JvZ3VlVGFsZW50U3RhdHVzLnByb3RvIoIBCg9Sb2d1ZVRhbGVu",
            "dEluZm8SOAoacm9ndWVfdW5sb2NrX3Byb2dyZXNzX2xpc3QYBCADKAsyFC5S",
            "b2d1ZVVubG9ja1Byb2dyZXNzEiIKBnN0YXR1cxgPIAEoDjISLlJvZ3VlVGFs",
            "ZW50U3RhdHVzEhEKCXRhbGVudF9pZBgMIAEoDUIeqgIbRWdnTGluay5EYW5o",
            "ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueUnlockProgressReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueTalentStatusReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueTalentInfo), global::EggLink.DanhengServer.Proto.RogueTalentInfo.Parser, new[]{ "RogueUnlockProgressList", "Status", "TalentId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueTalentInfo : pb::IMessage<RogueTalentInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueTalentInfo> _parser = new pb::MessageParser<RogueTalentInfo>(() => new RogueTalentInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueTalentInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueTalentInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueTalentInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueTalentInfo(RogueTalentInfo other) : this() {
      rogueUnlockProgressList_ = other.rogueUnlockProgressList_.Clone();
      status_ = other.status_;
      talentId_ = other.talentId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueTalentInfo Clone() {
      return new RogueTalentInfo(this);
    }

    /// <summary>Field number for the "rogue_unlock_progress_list" field.</summary>
    public const int RogueUnlockProgressListFieldNumber = 4;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.RogueUnlockProgress> _repeated_rogueUnlockProgressList_codec
        = pb::FieldCodec.ForMessage(34, global::EggLink.DanhengServer.Proto.RogueUnlockProgress.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueUnlockProgress> rogueUnlockProgressList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueUnlockProgress>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueUnlockProgress> RogueUnlockProgressList {
      get { return rogueUnlockProgressList_; }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 15;
    private global::EggLink.DanhengServer.Proto.RogueTalentStatus status_ = global::EggLink.DanhengServer.Proto.RogueTalentStatus.Lock;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueTalentStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "talent_id" field.</summary>
    public const int TalentIdFieldNumber = 12;
    private uint talentId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TalentId {
      get { return talentId_; }
      set {
        talentId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueTalentInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueTalentInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!rogueUnlockProgressList_.Equals(other.rogueUnlockProgressList_)) return false;
      if (Status != other.Status) return false;
      if (TalentId != other.TalentId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= rogueUnlockProgressList_.GetHashCode();
      if (Status != global::EggLink.DanhengServer.Proto.RogueTalentStatus.Lock) hash ^= Status.GetHashCode();
      if (TalentId != 0) hash ^= TalentId.GetHashCode();
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
      rogueUnlockProgressList_.WriteTo(output, _repeated_rogueUnlockProgressList_codec);
      if (TalentId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(TalentId);
      }
      if (Status != global::EggLink.DanhengServer.Proto.RogueTalentStatus.Lock) {
        output.WriteRawTag(120);
        output.WriteEnum((int) Status);
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
      rogueUnlockProgressList_.WriteTo(ref output, _repeated_rogueUnlockProgressList_codec);
      if (TalentId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(TalentId);
      }
      if (Status != global::EggLink.DanhengServer.Proto.RogueTalentStatus.Lock) {
        output.WriteRawTag(120);
        output.WriteEnum((int) Status);
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
      size += rogueUnlockProgressList_.CalculateSize(_repeated_rogueUnlockProgressList_codec);
      if (Status != global::EggLink.DanhengServer.Proto.RogueTalentStatus.Lock) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (TalentId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TalentId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueTalentInfo other) {
      if (other == null) {
        return;
      }
      rogueUnlockProgressList_.Add(other.rogueUnlockProgressList_);
      if (other.Status != global::EggLink.DanhengServer.Proto.RogueTalentStatus.Lock) {
        Status = other.Status;
      }
      if (other.TalentId != 0) {
        TalentId = other.TalentId;
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
          case 34: {
            rogueUnlockProgressList_.AddEntriesFrom(input, _repeated_rogueUnlockProgressList_codec);
            break;
          }
          case 96: {
            TalentId = input.ReadUInt32();
            break;
          }
          case 120: {
            Status = (global::EggLink.DanhengServer.Proto.RogueTalentStatus) input.ReadEnum();
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
          case 34: {
            rogueUnlockProgressList_.AddEntriesFrom(ref input, _repeated_rogueUnlockProgressList_codec);
            break;
          }
          case 96: {
            TalentId = input.ReadUInt32();
            break;
          }
          case 120: {
            Status = (global::EggLink.DanhengServer.Proto.RogueTalentStatus) input.ReadEnum();
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
