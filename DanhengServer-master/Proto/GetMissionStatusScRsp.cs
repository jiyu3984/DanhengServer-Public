// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetMissionStatusScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetMissionStatusScRsp.proto</summary>
  public static partial class GetMissionStatusScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetMissionStatusScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetMissionStatusScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtHZXRNaXNzaW9uU3RhdHVzU2NSc3AucHJvdG8aHE1haW5NaXNzaW9uQ3Vz",
            "dG9tVmFsdWUucHJvdG8aDU1pc3Npb24ucHJvdG8i4QIKFUdldE1pc3Npb25T",
            "dGF0dXNTY1JzcBIlCh1kaXNhYmxlZF9tYWluX21pc3Npb25faWRfbGlzdBgH",
            "IAMoDRIPCgdyZXRjb2RlGAYgASgNEjYKFW1haW5fbWlzc2lvbl9tY3ZfbGlz",
            "dBgMIAMoCzIXLk1haW5NaXNzaW9uQ3VzdG9tVmFsdWUSJwofdW5maW5pc2hl",
            "ZF9tYWluX21pc3Npb25faWRfbGlzdBgDIAMoDRIrChltaXNzaW9uX2V2ZW50",
            "X3N0YXR1c19saXN0GAEgAygLMgguTWlzc2lvbhIlCh1maW5pc2hlZF9tYWlu",
            "X21pc3Npb25faWRfbGlzdBgNIAMoDRIpChdzdWJfbWlzc2lvbl9zdGF0dXNf",
            "bGlzdBgJIAMoCzIILk1pc3Npb24SMAooY3VydmVyc2lvbl9maW5pc2hlZF9t",
            "YWluX21pc3Npb25faWRfbGlzdBgPIAMoDUIeqgIbRWdnTGluay5EYW5oZW5n",
            "U2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.MainMissionCustomValueReflection.Descriptor, global::EggLink.DanhengServer.Proto.MissionReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetMissionStatusScRsp), global::EggLink.DanhengServer.Proto.GetMissionStatusScRsp.Parser, new[]{ "DisabledMainMissionIdList", "Retcode", "MainMissionMcvList", "UnfinishedMainMissionIdList", "MissionEventStatusList", "FinishedMainMissionIdList", "SubMissionStatusList", "CurversionFinishedMainMissionIdList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetMissionStatusScRsp : pb::IMessage<GetMissionStatusScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetMissionStatusScRsp> _parser = new pb::MessageParser<GetMissionStatusScRsp>(() => new GetMissionStatusScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetMissionStatusScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetMissionStatusScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetMissionStatusScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetMissionStatusScRsp(GetMissionStatusScRsp other) : this() {
      disabledMainMissionIdList_ = other.disabledMainMissionIdList_.Clone();
      retcode_ = other.retcode_;
      mainMissionMcvList_ = other.mainMissionMcvList_.Clone();
      unfinishedMainMissionIdList_ = other.unfinishedMainMissionIdList_.Clone();
      missionEventStatusList_ = other.missionEventStatusList_.Clone();
      finishedMainMissionIdList_ = other.finishedMainMissionIdList_.Clone();
      subMissionStatusList_ = other.subMissionStatusList_.Clone();
      curversionFinishedMainMissionIdList_ = other.curversionFinishedMainMissionIdList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetMissionStatusScRsp Clone() {
      return new GetMissionStatusScRsp(this);
    }

    /// <summary>Field number for the "disabled_main_mission_id_list" field.</summary>
    public const int DisabledMainMissionIdListFieldNumber = 7;
    private static readonly pb::FieldCodec<uint> _repeated_disabledMainMissionIdList_codec
        = pb::FieldCodec.ForUInt32(58);
    private readonly pbc::RepeatedField<uint> disabledMainMissionIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> DisabledMainMissionIdList {
      get { return disabledMainMissionIdList_; }
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

    /// <summary>Field number for the "main_mission_mcv_list" field.</summary>
    public const int MainMissionMcvListFieldNumber = 12;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.MainMissionCustomValue> _repeated_mainMissionMcvList_codec
        = pb::FieldCodec.ForMessage(98, global::EggLink.DanhengServer.Proto.MainMissionCustomValue.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MainMissionCustomValue> mainMissionMcvList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MainMissionCustomValue>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MainMissionCustomValue> MainMissionMcvList {
      get { return mainMissionMcvList_; }
    }

    /// <summary>Field number for the "unfinished_main_mission_id_list" field.</summary>
    public const int UnfinishedMainMissionIdListFieldNumber = 3;
    private static readonly pb::FieldCodec<uint> _repeated_unfinishedMainMissionIdList_codec
        = pb::FieldCodec.ForUInt32(26);
    private readonly pbc::RepeatedField<uint> unfinishedMainMissionIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> UnfinishedMainMissionIdList {
      get { return unfinishedMainMissionIdList_; }
    }

    /// <summary>Field number for the "mission_event_status_list" field.</summary>
    public const int MissionEventStatusListFieldNumber = 1;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.Mission> _repeated_missionEventStatusList_codec
        = pb::FieldCodec.ForMessage(10, global::EggLink.DanhengServer.Proto.Mission.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Mission> missionEventStatusList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Mission>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Mission> MissionEventStatusList {
      get { return missionEventStatusList_; }
    }

    /// <summary>Field number for the "finished_main_mission_id_list" field.</summary>
    public const int FinishedMainMissionIdListFieldNumber = 13;
    private static readonly pb::FieldCodec<uint> _repeated_finishedMainMissionIdList_codec
        = pb::FieldCodec.ForUInt32(106);
    private readonly pbc::RepeatedField<uint> finishedMainMissionIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> FinishedMainMissionIdList {
      get { return finishedMainMissionIdList_; }
    }

    /// <summary>Field number for the "sub_mission_status_list" field.</summary>
    public const int SubMissionStatusListFieldNumber = 9;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.Mission> _repeated_subMissionStatusList_codec
        = pb::FieldCodec.ForMessage(74, global::EggLink.DanhengServer.Proto.Mission.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Mission> subMissionStatusList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Mission>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Mission> SubMissionStatusList {
      get { return subMissionStatusList_; }
    }

    /// <summary>Field number for the "curversion_finished_main_mission_id_list" field.</summary>
    public const int CurversionFinishedMainMissionIdListFieldNumber = 15;
    private static readonly pb::FieldCodec<uint> _repeated_curversionFinishedMainMissionIdList_codec
        = pb::FieldCodec.ForUInt32(122);
    private readonly pbc::RepeatedField<uint> curversionFinishedMainMissionIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> CurversionFinishedMainMissionIdList {
      get { return curversionFinishedMainMissionIdList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetMissionStatusScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetMissionStatusScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!disabledMainMissionIdList_.Equals(other.disabledMainMissionIdList_)) return false;
      if (Retcode != other.Retcode) return false;
      if(!mainMissionMcvList_.Equals(other.mainMissionMcvList_)) return false;
      if(!unfinishedMainMissionIdList_.Equals(other.unfinishedMainMissionIdList_)) return false;
      if(!missionEventStatusList_.Equals(other.missionEventStatusList_)) return false;
      if(!finishedMainMissionIdList_.Equals(other.finishedMainMissionIdList_)) return false;
      if(!subMissionStatusList_.Equals(other.subMissionStatusList_)) return false;
      if(!curversionFinishedMainMissionIdList_.Equals(other.curversionFinishedMainMissionIdList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= disabledMainMissionIdList_.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      hash ^= mainMissionMcvList_.GetHashCode();
      hash ^= unfinishedMainMissionIdList_.GetHashCode();
      hash ^= missionEventStatusList_.GetHashCode();
      hash ^= finishedMainMissionIdList_.GetHashCode();
      hash ^= subMissionStatusList_.GetHashCode();
      hash ^= curversionFinishedMainMissionIdList_.GetHashCode();
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
      missionEventStatusList_.WriteTo(output, _repeated_missionEventStatusList_codec);
      unfinishedMainMissionIdList_.WriteTo(output, _repeated_unfinishedMainMissionIdList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Retcode);
      }
      disabledMainMissionIdList_.WriteTo(output, _repeated_disabledMainMissionIdList_codec);
      subMissionStatusList_.WriteTo(output, _repeated_subMissionStatusList_codec);
      mainMissionMcvList_.WriteTo(output, _repeated_mainMissionMcvList_codec);
      finishedMainMissionIdList_.WriteTo(output, _repeated_finishedMainMissionIdList_codec);
      curversionFinishedMainMissionIdList_.WriteTo(output, _repeated_curversionFinishedMainMissionIdList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      missionEventStatusList_.WriteTo(ref output, _repeated_missionEventStatusList_codec);
      unfinishedMainMissionIdList_.WriteTo(ref output, _repeated_unfinishedMainMissionIdList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Retcode);
      }
      disabledMainMissionIdList_.WriteTo(ref output, _repeated_disabledMainMissionIdList_codec);
      subMissionStatusList_.WriteTo(ref output, _repeated_subMissionStatusList_codec);
      mainMissionMcvList_.WriteTo(ref output, _repeated_mainMissionMcvList_codec);
      finishedMainMissionIdList_.WriteTo(ref output, _repeated_finishedMainMissionIdList_codec);
      curversionFinishedMainMissionIdList_.WriteTo(ref output, _repeated_curversionFinishedMainMissionIdList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += disabledMainMissionIdList_.CalculateSize(_repeated_disabledMainMissionIdList_codec);
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      size += mainMissionMcvList_.CalculateSize(_repeated_mainMissionMcvList_codec);
      size += unfinishedMainMissionIdList_.CalculateSize(_repeated_unfinishedMainMissionIdList_codec);
      size += missionEventStatusList_.CalculateSize(_repeated_missionEventStatusList_codec);
      size += finishedMainMissionIdList_.CalculateSize(_repeated_finishedMainMissionIdList_codec);
      size += subMissionStatusList_.CalculateSize(_repeated_subMissionStatusList_codec);
      size += curversionFinishedMainMissionIdList_.CalculateSize(_repeated_curversionFinishedMainMissionIdList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetMissionStatusScRsp other) {
      if (other == null) {
        return;
      }
      disabledMainMissionIdList_.Add(other.disabledMainMissionIdList_);
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      mainMissionMcvList_.Add(other.mainMissionMcvList_);
      unfinishedMainMissionIdList_.Add(other.unfinishedMainMissionIdList_);
      missionEventStatusList_.Add(other.missionEventStatusList_);
      finishedMainMissionIdList_.Add(other.finishedMainMissionIdList_);
      subMissionStatusList_.Add(other.subMissionStatusList_);
      curversionFinishedMainMissionIdList_.Add(other.curversionFinishedMainMissionIdList_);
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
          case 10: {
            missionEventStatusList_.AddEntriesFrom(input, _repeated_missionEventStatusList_codec);
            break;
          }
          case 26:
          case 24: {
            unfinishedMainMissionIdList_.AddEntriesFrom(input, _repeated_unfinishedMainMissionIdList_codec);
            break;
          }
          case 48: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 58:
          case 56: {
            disabledMainMissionIdList_.AddEntriesFrom(input, _repeated_disabledMainMissionIdList_codec);
            break;
          }
          case 74: {
            subMissionStatusList_.AddEntriesFrom(input, _repeated_subMissionStatusList_codec);
            break;
          }
          case 98: {
            mainMissionMcvList_.AddEntriesFrom(input, _repeated_mainMissionMcvList_codec);
            break;
          }
          case 106:
          case 104: {
            finishedMainMissionIdList_.AddEntriesFrom(input, _repeated_finishedMainMissionIdList_codec);
            break;
          }
          case 122:
          case 120: {
            curversionFinishedMainMissionIdList_.AddEntriesFrom(input, _repeated_curversionFinishedMainMissionIdList_codec);
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
          case 10: {
            missionEventStatusList_.AddEntriesFrom(ref input, _repeated_missionEventStatusList_codec);
            break;
          }
          case 26:
          case 24: {
            unfinishedMainMissionIdList_.AddEntriesFrom(ref input, _repeated_unfinishedMainMissionIdList_codec);
            break;
          }
          case 48: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 58:
          case 56: {
            disabledMainMissionIdList_.AddEntriesFrom(ref input, _repeated_disabledMainMissionIdList_codec);
            break;
          }
          case 74: {
            subMissionStatusList_.AddEntriesFrom(ref input, _repeated_subMissionStatusList_codec);
            break;
          }
          case 98: {
            mainMissionMcvList_.AddEntriesFrom(ref input, _repeated_mainMissionMcvList_codec);
            break;
          }
          case 106:
          case 104: {
            finishedMainMissionIdList_.AddEntriesFrom(ref input, _repeated_finishedMainMissionIdList_codec);
            break;
          }
          case 122:
          case 120: {
            curversionFinishedMainMissionIdList_.AddEntriesFrom(ref input, _repeated_curversionFinishedMainMissionIdList_codec);
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
