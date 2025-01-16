// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: StartFightFestCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from StartFightFestCsReq.proto</summary>
  public static partial class StartFightFestCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for StartFightFestCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StartFightFestCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlTdGFydEZpZ2h0RmVzdENzUmVxLnByb3RvGhFKQVBPRUJLSEhETC5wcm90",
            "bxoTRmlnaHRGZXN0VHlwZS5wcm90byKTAQoTU3RhcnRGaWdodEZlc3RDc1Jl",
            "cRIcCgR0eXBlGAggASgOMg4uRmlnaHRGZXN0VHlwZRIQCghldmVudF9pZBgB",
            "IAEoDRIdChV1bmxvY2tlZF9jb2FjaF9za2lsbHMYBCADKA0SIQoLYXZhdGFy",
            "X2xpc3QYAyADKAsyDC5KQVBPRUJLSEhETBIKCgJpZBgPIAEoDUIeqgIbRWdn",
            "TGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.JAPOEBKHHDLReflection.Descriptor, global::EggLink.DanhengServer.Proto.FightFestTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.StartFightFestCsReq), global::EggLink.DanhengServer.Proto.StartFightFestCsReq.Parser, new[]{ "Type", "EventId", "UnlockedCoachSkills", "AvatarList", "Id" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class StartFightFestCsReq : pb::IMessage<StartFightFestCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<StartFightFestCsReq> _parser = new pb::MessageParser<StartFightFestCsReq>(() => new StartFightFestCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<StartFightFestCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.StartFightFestCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartFightFestCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartFightFestCsReq(StartFightFestCsReq other) : this() {
      type_ = other.type_;
      eventId_ = other.eventId_;
      unlockedCoachSkills_ = other.unlockedCoachSkills_.Clone();
      avatarList_ = other.avatarList_.Clone();
      id_ = other.id_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartFightFestCsReq Clone() {
      return new StartFightFestCsReq(this);
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 8;
    private global::EggLink.DanhengServer.Proto.FightFestType type_ = global::EggLink.DanhengServer.Proto.FightFestType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.FightFestType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "event_id" field.</summary>
    public const int EventIdFieldNumber = 1;
    private uint eventId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EventId {
      get { return eventId_; }
      set {
        eventId_ = value;
      }
    }

    /// <summary>Field number for the "unlocked_coach_skills" field.</summary>
    public const int UnlockedCoachSkillsFieldNumber = 4;
    private static readonly pb::FieldCodec<uint> _repeated_unlockedCoachSkills_codec
        = pb::FieldCodec.ForUInt32(34);
    private readonly pbc::RepeatedField<uint> unlockedCoachSkills_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> UnlockedCoachSkills {
      get { return unlockedCoachSkills_; }
    }

    /// <summary>Field number for the "avatar_list" field.</summary>
    public const int AvatarListFieldNumber = 3;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.JAPOEBKHHDL> _repeated_avatarList_codec
        = pb::FieldCodec.ForMessage(26, global::EggLink.DanhengServer.Proto.JAPOEBKHHDL.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.JAPOEBKHHDL> avatarList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.JAPOEBKHHDL>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.JAPOEBKHHDL> AvatarList {
      get { return avatarList_; }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 15;
    private uint id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as StartFightFestCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(StartFightFestCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Type != other.Type) return false;
      if (EventId != other.EventId) return false;
      if(!unlockedCoachSkills_.Equals(other.unlockedCoachSkills_)) return false;
      if(!avatarList_.Equals(other.avatarList_)) return false;
      if (Id != other.Id) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Type != global::EggLink.DanhengServer.Proto.FightFestType.None) hash ^= Type.GetHashCode();
      if (EventId != 0) hash ^= EventId.GetHashCode();
      hash ^= unlockedCoachSkills_.GetHashCode();
      hash ^= avatarList_.GetHashCode();
      if (Id != 0) hash ^= Id.GetHashCode();
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
      if (EventId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(EventId);
      }
      avatarList_.WriteTo(output, _repeated_avatarList_codec);
      unlockedCoachSkills_.WriteTo(output, _repeated_unlockedCoachSkills_codec);
      if (Type != global::EggLink.DanhengServer.Proto.FightFestType.None) {
        output.WriteRawTag(64);
        output.WriteEnum((int) Type);
      }
      if (Id != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Id);
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
      if (EventId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(EventId);
      }
      avatarList_.WriteTo(ref output, _repeated_avatarList_codec);
      unlockedCoachSkills_.WriteTo(ref output, _repeated_unlockedCoachSkills_codec);
      if (Type != global::EggLink.DanhengServer.Proto.FightFestType.None) {
        output.WriteRawTag(64);
        output.WriteEnum((int) Type);
      }
      if (Id != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Id);
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
      if (Type != global::EggLink.DanhengServer.Proto.FightFestType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (EventId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EventId);
      }
      size += unlockedCoachSkills_.CalculateSize(_repeated_unlockedCoachSkills_codec);
      size += avatarList_.CalculateSize(_repeated_avatarList_codec);
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Id);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(StartFightFestCsReq other) {
      if (other == null) {
        return;
      }
      if (other.Type != global::EggLink.DanhengServer.Proto.FightFestType.None) {
        Type = other.Type;
      }
      if (other.EventId != 0) {
        EventId = other.EventId;
      }
      unlockedCoachSkills_.Add(other.unlockedCoachSkills_);
      avatarList_.Add(other.avatarList_);
      if (other.Id != 0) {
        Id = other.Id;
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
            EventId = input.ReadUInt32();
            break;
          }
          case 26: {
            avatarList_.AddEntriesFrom(input, _repeated_avatarList_codec);
            break;
          }
          case 34:
          case 32: {
            unlockedCoachSkills_.AddEntriesFrom(input, _repeated_unlockedCoachSkills_codec);
            break;
          }
          case 64: {
            Type = (global::EggLink.DanhengServer.Proto.FightFestType) input.ReadEnum();
            break;
          }
          case 120: {
            Id = input.ReadUInt32();
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
            EventId = input.ReadUInt32();
            break;
          }
          case 26: {
            avatarList_.AddEntriesFrom(ref input, _repeated_avatarList_codec);
            break;
          }
          case 34:
          case 32: {
            unlockedCoachSkills_.AddEntriesFrom(ref input, _repeated_unlockedCoachSkills_codec);
            break;
          }
          case 64: {
            Type = (global::EggLink.DanhengServer.Proto.FightFestType) input.ReadEnum();
            break;
          }
          case 120: {
            Id = input.ReadUInt32();
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
