// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: LogisticsScore.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from LogisticsScore.proto</summary>
  public static partial class LogisticsScoreReflection {

    #region Descriptor
    /// <summary>File descriptor for LogisticsScore.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LogisticsScoreReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRMb2dpc3RpY3NTY29yZS5wcm90bxoOSXRlbUxpc3QucHJvdG8iyAEKDkxv",
            "Z2lzdGljc1Njb3JlEhkKBnJld2FyZBgPIAEoCzIJLkl0ZW1MaXN0EhsKE0N1",
            "clNjb3JlRmllbGROdW1iZXIYASABKA0SHwoXTGFzdE1heFNjb3JlRmllbGRO",
            "dW1iZXIYBCABKA0SGAoQTWFwSWRGaWVsZE51bWJlchgGIAEoDRIbChNNYXhT",
            "Y29yZUZpZWxkTnVtYmVyGAcgASgNEhMKC1VubG9ja2xldmVsGAsgASgNEhEK",
            "CUxhc3RsZXZlbBgNIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlBy",
            "b3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ItemListReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.LogisticsScore), global::EggLink.DanhengServer.Proto.LogisticsScore.Parser, new[]{ "Reward", "CurScoreFieldNumber", "LastMaxScoreFieldNumber", "MapIdFieldNumber", "MaxScoreFieldNumber", "Unlocklevel", "Lastlevel" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class LogisticsScore : pb::IMessage<LogisticsScore>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LogisticsScore> _parser = new pb::MessageParser<LogisticsScore>(() => new LogisticsScore());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LogisticsScore> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.LogisticsScoreReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LogisticsScore() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LogisticsScore(LogisticsScore other) : this() {
      reward_ = other.reward_ != null ? other.reward_.Clone() : null;
      curScoreFieldNumber_ = other.curScoreFieldNumber_;
      lastMaxScoreFieldNumber_ = other.lastMaxScoreFieldNumber_;
      mapIdFieldNumber_ = other.mapIdFieldNumber_;
      maxScoreFieldNumber_ = other.maxScoreFieldNumber_;
      unlocklevel_ = other.unlocklevel_;
      lastlevel_ = other.lastlevel_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LogisticsScore Clone() {
      return new LogisticsScore(this);
    }

    /// <summary>Field number for the "reward" field.</summary>
    public const int RewardFieldNumber = 15;
    private global::EggLink.DanhengServer.Proto.ItemList reward_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemList Reward {
      get { return reward_; }
      set {
        reward_ = value;
      }
    }

    /// <summary>Field number for the "CurScoreFieldNumber" field.</summary>
    public const int CurScoreFieldNumberFieldNumber = 1;
    private uint curScoreFieldNumber_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurScoreFieldNumber {
      get { return curScoreFieldNumber_; }
      set {
        curScoreFieldNumber_ = value;
      }
    }

    /// <summary>Field number for the "LastMaxScoreFieldNumber" field.</summary>
    public const int LastMaxScoreFieldNumberFieldNumber = 4;
    private uint lastMaxScoreFieldNumber_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LastMaxScoreFieldNumber {
      get { return lastMaxScoreFieldNumber_; }
      set {
        lastMaxScoreFieldNumber_ = value;
      }
    }

    /// <summary>Field number for the "MapIdFieldNumber" field.</summary>
    public const int MapIdFieldNumberFieldNumber = 6;
    private uint mapIdFieldNumber_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MapIdFieldNumber {
      get { return mapIdFieldNumber_; }
      set {
        mapIdFieldNumber_ = value;
      }
    }

    /// <summary>Field number for the "MaxScoreFieldNumber" field.</summary>
    public const int MaxScoreFieldNumberFieldNumber = 7;
    private uint maxScoreFieldNumber_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MaxScoreFieldNumber {
      get { return maxScoreFieldNumber_; }
      set {
        maxScoreFieldNumber_ = value;
      }
    }

    /// <summary>Field number for the "Unlocklevel" field.</summary>
    public const int UnlocklevelFieldNumber = 11;
    private uint unlocklevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unlocklevel {
      get { return unlocklevel_; }
      set {
        unlocklevel_ = value;
      }
    }

    /// <summary>Field number for the "Lastlevel" field.</summary>
    public const int LastlevelFieldNumber = 13;
    private uint lastlevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Lastlevel {
      get { return lastlevel_; }
      set {
        lastlevel_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LogisticsScore);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LogisticsScore other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Reward, other.Reward)) return false;
      if (CurScoreFieldNumber != other.CurScoreFieldNumber) return false;
      if (LastMaxScoreFieldNumber != other.LastMaxScoreFieldNumber) return false;
      if (MapIdFieldNumber != other.MapIdFieldNumber) return false;
      if (MaxScoreFieldNumber != other.MaxScoreFieldNumber) return false;
      if (Unlocklevel != other.Unlocklevel) return false;
      if (Lastlevel != other.Lastlevel) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (reward_ != null) hash ^= Reward.GetHashCode();
      if (CurScoreFieldNumber != 0) hash ^= CurScoreFieldNumber.GetHashCode();
      if (LastMaxScoreFieldNumber != 0) hash ^= LastMaxScoreFieldNumber.GetHashCode();
      if (MapIdFieldNumber != 0) hash ^= MapIdFieldNumber.GetHashCode();
      if (MaxScoreFieldNumber != 0) hash ^= MaxScoreFieldNumber.GetHashCode();
      if (Unlocklevel != 0) hash ^= Unlocklevel.GetHashCode();
      if (Lastlevel != 0) hash ^= Lastlevel.GetHashCode();
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
      if (CurScoreFieldNumber != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(CurScoreFieldNumber);
      }
      if (LastMaxScoreFieldNumber != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(LastMaxScoreFieldNumber);
      }
      if (MapIdFieldNumber != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(MapIdFieldNumber);
      }
      if (MaxScoreFieldNumber != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(MaxScoreFieldNumber);
      }
      if (Unlocklevel != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Unlocklevel);
      }
      if (Lastlevel != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Lastlevel);
      }
      if (reward_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(Reward);
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
      if (CurScoreFieldNumber != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(CurScoreFieldNumber);
      }
      if (LastMaxScoreFieldNumber != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(LastMaxScoreFieldNumber);
      }
      if (MapIdFieldNumber != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(MapIdFieldNumber);
      }
      if (MaxScoreFieldNumber != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(MaxScoreFieldNumber);
      }
      if (Unlocklevel != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Unlocklevel);
      }
      if (Lastlevel != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Lastlevel);
      }
      if (reward_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(Reward);
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
      if (reward_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Reward);
      }
      if (CurScoreFieldNumber != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurScoreFieldNumber);
      }
      if (LastMaxScoreFieldNumber != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LastMaxScoreFieldNumber);
      }
      if (MapIdFieldNumber != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MapIdFieldNumber);
      }
      if (MaxScoreFieldNumber != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MaxScoreFieldNumber);
      }
      if (Unlocklevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unlocklevel);
      }
      if (Lastlevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Lastlevel);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(LogisticsScore other) {
      if (other == null) {
        return;
      }
      if (other.reward_ != null) {
        if (reward_ == null) {
          Reward = new global::EggLink.DanhengServer.Proto.ItemList();
        }
        Reward.MergeFrom(other.Reward);
      }
      if (other.CurScoreFieldNumber != 0) {
        CurScoreFieldNumber = other.CurScoreFieldNumber;
      }
      if (other.LastMaxScoreFieldNumber != 0) {
        LastMaxScoreFieldNumber = other.LastMaxScoreFieldNumber;
      }
      if (other.MapIdFieldNumber != 0) {
        MapIdFieldNumber = other.MapIdFieldNumber;
      }
      if (other.MaxScoreFieldNumber != 0) {
        MaxScoreFieldNumber = other.MaxScoreFieldNumber;
      }
      if (other.Unlocklevel != 0) {
        Unlocklevel = other.Unlocklevel;
      }
      if (other.Lastlevel != 0) {
        Lastlevel = other.Lastlevel;
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
            CurScoreFieldNumber = input.ReadUInt32();
            break;
          }
          case 32: {
            LastMaxScoreFieldNumber = input.ReadUInt32();
            break;
          }
          case 48: {
            MapIdFieldNumber = input.ReadUInt32();
            break;
          }
          case 56: {
            MaxScoreFieldNumber = input.ReadUInt32();
            break;
          }
          case 88: {
            Unlocklevel = input.ReadUInt32();
            break;
          }
          case 104: {
            Lastlevel = input.ReadUInt32();
            break;
          }
          case 122: {
            if (reward_ == null) {
              Reward = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(Reward);
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
            CurScoreFieldNumber = input.ReadUInt32();
            break;
          }
          case 32: {
            LastMaxScoreFieldNumber = input.ReadUInt32();
            break;
          }
          case 48: {
            MapIdFieldNumber = input.ReadUInt32();
            break;
          }
          case 56: {
            MaxScoreFieldNumber = input.ReadUInt32();
            break;
          }
          case 88: {
            Unlocklevel = input.ReadUInt32();
            break;
          }
          case 104: {
            Lastlevel = input.ReadUInt32();
            break;
          }
          case 122: {
            if (reward_ == null) {
              Reward = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(Reward);
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