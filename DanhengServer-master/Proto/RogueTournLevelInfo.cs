// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueTournLevelInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueTournLevelInfo.proto</summary>
  public static partial class RogueTournLevelInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueTournLevelInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueTournLevelInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlSb2d1ZVRvdXJuTGV2ZWxJbmZvLnByb3RvGhxSb2d1ZVRvdXJuU2V0dGxl",
            "UmVhc29uLnByb3RvGhVSb2d1ZVRvdXJuTGV2ZWwucHJvdG8aG1JvZ3VlVG91",
            "cm5MZXZlbFN0YXR1cy5wcm90byK/AQoTUm9ndWVUb3VybkxldmVsSW5mbxIX",
            "Cg9jdXJfbGV2ZWxfaW5kZXgYDyABKA0SJwoGcmVhc29uGAUgASgOMhcuUm9n",
            "dWVUb3VyblNldHRsZVJlYXNvbhITCgtNRkRKTk9GSk5EQxgOIAEoCBIpCg9s",
            "ZXZlbF9pbmZvX2xpc3QYCiADKAsyEC5Sb2d1ZVRvdXJuTGV2ZWwSJgoGc3Rh",
            "dHVzGAwgASgOMhYuUm9ndWVUb3VybkxldmVsU3RhdHVzQh6qAhtFZ2dMaW5r",
            "LkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueTournSettleReasonReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueTournLevelReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueTournLevelStatusReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueTournLevelInfo), global::EggLink.DanhengServer.Proto.RogueTournLevelInfo.Parser, new[]{ "CurLevelIndex", "Reason", "MFDJNOFJNDC", "LevelInfoList", "Status" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueTournLevelInfo : pb::IMessage<RogueTournLevelInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueTournLevelInfo> _parser = new pb::MessageParser<RogueTournLevelInfo>(() => new RogueTournLevelInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueTournLevelInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueTournLevelInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueTournLevelInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueTournLevelInfo(RogueTournLevelInfo other) : this() {
      curLevelIndex_ = other.curLevelIndex_;
      reason_ = other.reason_;
      mFDJNOFJNDC_ = other.mFDJNOFJNDC_;
      levelInfoList_ = other.levelInfoList_.Clone();
      status_ = other.status_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueTournLevelInfo Clone() {
      return new RogueTournLevelInfo(this);
    }

    /// <summary>Field number for the "cur_level_index" field.</summary>
    public const int CurLevelIndexFieldNumber = 15;
    private uint curLevelIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurLevelIndex {
      get { return curLevelIndex_; }
      set {
        curLevelIndex_ = value;
      }
    }

    /// <summary>Field number for the "reason" field.</summary>
    public const int ReasonFieldNumber = 5;
    private global::EggLink.DanhengServer.Proto.RogueTournSettleReason reason_ = global::EggLink.DanhengServer.Proto.RogueTournSettleReason.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueTournSettleReason Reason {
      get { return reason_; }
      set {
        reason_ = value;
      }
    }

    /// <summary>Field number for the "MFDJNOFJNDC" field.</summary>
    public const int MFDJNOFJNDCFieldNumber = 14;
    private bool mFDJNOFJNDC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool MFDJNOFJNDC {
      get { return mFDJNOFJNDC_; }
      set {
        mFDJNOFJNDC_ = value;
      }
    }

    /// <summary>Field number for the "level_info_list" field.</summary>
    public const int LevelInfoListFieldNumber = 10;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.RogueTournLevel> _repeated_levelInfoList_codec
        = pb::FieldCodec.ForMessage(82, global::EggLink.DanhengServer.Proto.RogueTournLevel.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueTournLevel> levelInfoList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueTournLevel>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueTournLevel> LevelInfoList {
      get { return levelInfoList_; }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 12;
    private global::EggLink.DanhengServer.Proto.RogueTournLevelStatus status_ = global::EggLink.DanhengServer.Proto.RogueTournLevelStatus.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueTournLevelStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueTournLevelInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueTournLevelInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CurLevelIndex != other.CurLevelIndex) return false;
      if (Reason != other.Reason) return false;
      if (MFDJNOFJNDC != other.MFDJNOFJNDC) return false;
      if(!levelInfoList_.Equals(other.levelInfoList_)) return false;
      if (Status != other.Status) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CurLevelIndex != 0) hash ^= CurLevelIndex.GetHashCode();
      if (Reason != global::EggLink.DanhengServer.Proto.RogueTournSettleReason.None) hash ^= Reason.GetHashCode();
      if (MFDJNOFJNDC != false) hash ^= MFDJNOFJNDC.GetHashCode();
      hash ^= levelInfoList_.GetHashCode();
      if (Status != global::EggLink.DanhengServer.Proto.RogueTournLevelStatus.None) hash ^= Status.GetHashCode();
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
      if (Reason != global::EggLink.DanhengServer.Proto.RogueTournSettleReason.None) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Reason);
      }
      levelInfoList_.WriteTo(output, _repeated_levelInfoList_codec);
      if (Status != global::EggLink.DanhengServer.Proto.RogueTournLevelStatus.None) {
        output.WriteRawTag(96);
        output.WriteEnum((int) Status);
      }
      if (MFDJNOFJNDC != false) {
        output.WriteRawTag(112);
        output.WriteBool(MFDJNOFJNDC);
      }
      if (CurLevelIndex != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(CurLevelIndex);
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
      if (Reason != global::EggLink.DanhengServer.Proto.RogueTournSettleReason.None) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Reason);
      }
      levelInfoList_.WriteTo(ref output, _repeated_levelInfoList_codec);
      if (Status != global::EggLink.DanhengServer.Proto.RogueTournLevelStatus.None) {
        output.WriteRawTag(96);
        output.WriteEnum((int) Status);
      }
      if (MFDJNOFJNDC != false) {
        output.WriteRawTag(112);
        output.WriteBool(MFDJNOFJNDC);
      }
      if (CurLevelIndex != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(CurLevelIndex);
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
      if (CurLevelIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurLevelIndex);
      }
      if (Reason != global::EggLink.DanhengServer.Proto.RogueTournSettleReason.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Reason);
      }
      if (MFDJNOFJNDC != false) {
        size += 1 + 1;
      }
      size += levelInfoList_.CalculateSize(_repeated_levelInfoList_codec);
      if (Status != global::EggLink.DanhengServer.Proto.RogueTournLevelStatus.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueTournLevelInfo other) {
      if (other == null) {
        return;
      }
      if (other.CurLevelIndex != 0) {
        CurLevelIndex = other.CurLevelIndex;
      }
      if (other.Reason != global::EggLink.DanhengServer.Proto.RogueTournSettleReason.None) {
        Reason = other.Reason;
      }
      if (other.MFDJNOFJNDC != false) {
        MFDJNOFJNDC = other.MFDJNOFJNDC;
      }
      levelInfoList_.Add(other.levelInfoList_);
      if (other.Status != global::EggLink.DanhengServer.Proto.RogueTournLevelStatus.None) {
        Status = other.Status;
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
          case 40: {
            Reason = (global::EggLink.DanhengServer.Proto.RogueTournSettleReason) input.ReadEnum();
            break;
          }
          case 82: {
            levelInfoList_.AddEntriesFrom(input, _repeated_levelInfoList_codec);
            break;
          }
          case 96: {
            Status = (global::EggLink.DanhengServer.Proto.RogueTournLevelStatus) input.ReadEnum();
            break;
          }
          case 112: {
            MFDJNOFJNDC = input.ReadBool();
            break;
          }
          case 120: {
            CurLevelIndex = input.ReadUInt32();
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
            Reason = (global::EggLink.DanhengServer.Proto.RogueTournSettleReason) input.ReadEnum();
            break;
          }
          case 82: {
            levelInfoList_.AddEntriesFrom(ref input, _repeated_levelInfoList_codec);
            break;
          }
          case 96: {
            Status = (global::EggLink.DanhengServer.Proto.RogueTournLevelStatus) input.ReadEnum();
            break;
          }
          case 112: {
            MFDJNOFJNDC = input.ReadBool();
            break;
          }
          case 120: {
            CurLevelIndex = input.ReadUInt32();
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