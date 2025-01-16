// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FeverTimeActivityData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from FeverTimeActivityData.proto</summary>
  public static partial class FeverTimeActivityDataReflection {

    #region Descriptor
    /// <summary>File descriptor for FeverTimeActivityData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FeverTimeActivityDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtGZXZlclRpbWVBY3Rpdml0eURhdGEucHJvdG8aGUZldmVyVGltZUJhdHRs",
            "ZVJhbmsucHJvdG8icgoVRmV2ZXJUaW1lQWN0aXZpdHlEYXRhEhgKEHJlbWFp",
            "bmluZ19jeWNsZXMYDiABKA0SLQoPZmV2ZXJfdGltZV9yYW5rGA0gASgOMhQu",
            "RmV2ZXJUaW1lQmF0dGxlUmFuaxIQCghmZXZlcl9pZBgBIAEoDUIeqgIbRWdn",
            "TGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.FeverTimeBattleRankReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.FeverTimeActivityData), global::EggLink.DanhengServer.Proto.FeverTimeActivityData.Parser, new[]{ "RemainingCycles", "FeverTimeRank", "FeverId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class FeverTimeActivityData : pb::IMessage<FeverTimeActivityData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FeverTimeActivityData> _parser = new pb::MessageParser<FeverTimeActivityData>(() => new FeverTimeActivityData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FeverTimeActivityData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.FeverTimeActivityDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FeverTimeActivityData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FeverTimeActivityData(FeverTimeActivityData other) : this() {
      remainingCycles_ = other.remainingCycles_;
      feverTimeRank_ = other.feverTimeRank_;
      feverId_ = other.feverId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FeverTimeActivityData Clone() {
      return new FeverTimeActivityData(this);
    }

    /// <summary>Field number for the "remaining_cycles" field.</summary>
    public const int RemainingCyclesFieldNumber = 14;
    private uint remainingCycles_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RemainingCycles {
      get { return remainingCycles_; }
      set {
        remainingCycles_ = value;
      }
    }

    /// <summary>Field number for the "fever_time_rank" field.</summary>
    public const int FeverTimeRankFieldNumber = 13;
    private global::EggLink.DanhengServer.Proto.FeverTimeBattleRank feverTimeRank_ = global::EggLink.DanhengServer.Proto.FeverTimeBattleRank.C;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.FeverTimeBattleRank FeverTimeRank {
      get { return feverTimeRank_; }
      set {
        feverTimeRank_ = value;
      }
    }

    /// <summary>Field number for the "fever_id" field.</summary>
    public const int FeverIdFieldNumber = 1;
    private uint feverId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FeverId {
      get { return feverId_; }
      set {
        feverId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FeverTimeActivityData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FeverTimeActivityData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RemainingCycles != other.RemainingCycles) return false;
      if (FeverTimeRank != other.FeverTimeRank) return false;
      if (FeverId != other.FeverId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (RemainingCycles != 0) hash ^= RemainingCycles.GetHashCode();
      if (FeverTimeRank != global::EggLink.DanhengServer.Proto.FeverTimeBattleRank.C) hash ^= FeverTimeRank.GetHashCode();
      if (FeverId != 0) hash ^= FeverId.GetHashCode();
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
        output.WriteRawTag(8);
        output.WriteUInt32(FeverId);
      }
      if (FeverTimeRank != global::EggLink.DanhengServer.Proto.FeverTimeBattleRank.C) {
        output.WriteRawTag(104);
        output.WriteEnum((int) FeverTimeRank);
      }
      if (RemainingCycles != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(RemainingCycles);
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
        output.WriteRawTag(8);
        output.WriteUInt32(FeverId);
      }
      if (FeverTimeRank != global::EggLink.DanhengServer.Proto.FeverTimeBattleRank.C) {
        output.WriteRawTag(104);
        output.WriteEnum((int) FeverTimeRank);
      }
      if (RemainingCycles != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(RemainingCycles);
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
      if (RemainingCycles != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RemainingCycles);
      }
      if (FeverTimeRank != global::EggLink.DanhengServer.Proto.FeverTimeBattleRank.C) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) FeverTimeRank);
      }
      if (FeverId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FeverId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FeverTimeActivityData other) {
      if (other == null) {
        return;
      }
      if (other.RemainingCycles != 0) {
        RemainingCycles = other.RemainingCycles;
      }
      if (other.FeverTimeRank != global::EggLink.DanhengServer.Proto.FeverTimeBattleRank.C) {
        FeverTimeRank = other.FeverTimeRank;
      }
      if (other.FeverId != 0) {
        FeverId = other.FeverId;
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
            FeverId = input.ReadUInt32();
            break;
          }
          case 104: {
            FeverTimeRank = (global::EggLink.DanhengServer.Proto.FeverTimeBattleRank) input.ReadEnum();
            break;
          }
          case 112: {
            RemainingCycles = input.ReadUInt32();
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
            FeverId = input.ReadUInt32();
            break;
          }
          case 104: {
            FeverTimeRank = (global::EggLink.DanhengServer.Proto.FeverTimeBattleRank) input.ReadEnum();
            break;
          }
          case 112: {
            RemainingCycles = input.ReadUInt32();
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