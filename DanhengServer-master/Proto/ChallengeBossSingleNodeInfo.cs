// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChallengeBossSingleNodeInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ChallengeBossSingleNodeInfo.proto</summary>
  public static partial class ChallengeBossSingleNodeInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for ChallengeBossSingleNodeInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChallengeBossSingleNodeInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFDaGFsbGVuZ2VCb3NzU2luZ2xlTm9kZUluZm8ucHJvdG8iZgobQ2hhbGxl",
            "bmdlQm9zc1NpbmdsZU5vZGVJbmZvEg8KB2J1ZmZfaWQYAiABKA0SDgoGaXNf",
            "d2luGAEgASgIEhMKC1BFS1BJQ0hPUE1MGAsgASgIEhEKCW1heF9zY29yZRgK",
            "IAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ChallengeBossSingleNodeInfo), global::EggLink.DanhengServer.Proto.ChallengeBossSingleNodeInfo.Parser, new[]{ "BuffId", "IsWin", "PEKPICHOPML", "MaxScore" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ChallengeBossSingleNodeInfo : pb::IMessage<ChallengeBossSingleNodeInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChallengeBossSingleNodeInfo> _parser = new pb::MessageParser<ChallengeBossSingleNodeInfo>(() => new ChallengeBossSingleNodeInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChallengeBossSingleNodeInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ChallengeBossSingleNodeInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChallengeBossSingleNodeInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChallengeBossSingleNodeInfo(ChallengeBossSingleNodeInfo other) : this() {
      buffId_ = other.buffId_;
      isWin_ = other.isWin_;
      pEKPICHOPML_ = other.pEKPICHOPML_;
      maxScore_ = other.maxScore_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChallengeBossSingleNodeInfo Clone() {
      return new ChallengeBossSingleNodeInfo(this);
    }

    /// <summary>Field number for the "buff_id" field.</summary>
    public const int BuffIdFieldNumber = 2;
    private uint buffId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BuffId {
      get { return buffId_; }
      set {
        buffId_ = value;
      }
    }

    /// <summary>Field number for the "is_win" field.</summary>
    public const int IsWinFieldNumber = 1;
    private bool isWin_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsWin {
      get { return isWin_; }
      set {
        isWin_ = value;
      }
    }

    /// <summary>Field number for the "PEKPICHOPML" field.</summary>
    public const int PEKPICHOPMLFieldNumber = 11;
    private bool pEKPICHOPML_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool PEKPICHOPML {
      get { return pEKPICHOPML_; }
      set {
        pEKPICHOPML_ = value;
      }
    }

    /// <summary>Field number for the "max_score" field.</summary>
    public const int MaxScoreFieldNumber = 10;
    private uint maxScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MaxScore {
      get { return maxScore_; }
      set {
        maxScore_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChallengeBossSingleNodeInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChallengeBossSingleNodeInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BuffId != other.BuffId) return false;
      if (IsWin != other.IsWin) return false;
      if (PEKPICHOPML != other.PEKPICHOPML) return false;
      if (MaxScore != other.MaxScore) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (BuffId != 0) hash ^= BuffId.GetHashCode();
      if (IsWin != false) hash ^= IsWin.GetHashCode();
      if (PEKPICHOPML != false) hash ^= PEKPICHOPML.GetHashCode();
      if (MaxScore != 0) hash ^= MaxScore.GetHashCode();
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
      if (IsWin != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsWin);
      }
      if (BuffId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(BuffId);
      }
      if (MaxScore != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(MaxScore);
      }
      if (PEKPICHOPML != false) {
        output.WriteRawTag(88);
        output.WriteBool(PEKPICHOPML);
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
      if (IsWin != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsWin);
      }
      if (BuffId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(BuffId);
      }
      if (MaxScore != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(MaxScore);
      }
      if (PEKPICHOPML != false) {
        output.WriteRawTag(88);
        output.WriteBool(PEKPICHOPML);
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
      if (BuffId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BuffId);
      }
      if (IsWin != false) {
        size += 1 + 1;
      }
      if (PEKPICHOPML != false) {
        size += 1 + 1;
      }
      if (MaxScore != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MaxScore);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChallengeBossSingleNodeInfo other) {
      if (other == null) {
        return;
      }
      if (other.BuffId != 0) {
        BuffId = other.BuffId;
      }
      if (other.IsWin != false) {
        IsWin = other.IsWin;
      }
      if (other.PEKPICHOPML != false) {
        PEKPICHOPML = other.PEKPICHOPML;
      }
      if (other.MaxScore != 0) {
        MaxScore = other.MaxScore;
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
            IsWin = input.ReadBool();
            break;
          }
          case 16: {
            BuffId = input.ReadUInt32();
            break;
          }
          case 80: {
            MaxScore = input.ReadUInt32();
            break;
          }
          case 88: {
            PEKPICHOPML = input.ReadBool();
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
            IsWin = input.ReadBool();
            break;
          }
          case 16: {
            BuffId = input.ReadUInt32();
            break;
          }
          case 80: {
            MaxScore = input.ReadUInt32();
            break;
          }
          case 88: {
            PEKPICHOPML = input.ReadBool();
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