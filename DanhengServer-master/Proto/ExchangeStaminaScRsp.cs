// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ExchangeStaminaScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ExchangeStaminaScRsp.proto</summary>
  public static partial class ExchangeStaminaScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for ExchangeStaminaScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ExchangeStaminaScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpFeGNoYW5nZVN0YW1pbmFTY1JzcC5wcm90bxoOSXRlbUNvc3QucHJvdG8i",
            "kgEKFEV4Y2hhbmdlU3RhbWluYVNjUnNwEhMKC3N0YW1pbmFfYWRkGA4gASgN",
            "EhYKDmV4Y2hhbmdlX3RpbWVzGAkgASgNEg8KB3JldGNvZGUYASABKA0SGQoR",
            "bGFzdF9yZWNvdmVyX3RpbWUYBSABKAMSIQoOaXRlbV9jb3N0X2xpc3QYCiAD",
            "KAsyCS5JdGVtQ29zdEIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3Rv",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ItemCostReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ExchangeStaminaScRsp), global::EggLink.DanhengServer.Proto.ExchangeStaminaScRsp.Parser, new[]{ "StaminaAdd", "ExchangeTimes", "Retcode", "LastRecoverTime", "ItemCostList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ExchangeStaminaScRsp : pb::IMessage<ExchangeStaminaScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ExchangeStaminaScRsp> _parser = new pb::MessageParser<ExchangeStaminaScRsp>(() => new ExchangeStaminaScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ExchangeStaminaScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ExchangeStaminaScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExchangeStaminaScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExchangeStaminaScRsp(ExchangeStaminaScRsp other) : this() {
      staminaAdd_ = other.staminaAdd_;
      exchangeTimes_ = other.exchangeTimes_;
      retcode_ = other.retcode_;
      lastRecoverTime_ = other.lastRecoverTime_;
      itemCostList_ = other.itemCostList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExchangeStaminaScRsp Clone() {
      return new ExchangeStaminaScRsp(this);
    }

    /// <summary>Field number for the "stamina_add" field.</summary>
    public const int StaminaAddFieldNumber = 14;
    private uint staminaAdd_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StaminaAdd {
      get { return staminaAdd_; }
      set {
        staminaAdd_ = value;
      }
    }

    /// <summary>Field number for the "exchange_times" field.</summary>
    public const int ExchangeTimesFieldNumber = 9;
    private uint exchangeTimes_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ExchangeTimes {
      get { return exchangeTimes_; }
      set {
        exchangeTimes_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 1;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "last_recover_time" field.</summary>
    public const int LastRecoverTimeFieldNumber = 5;
    private long lastRecoverTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long LastRecoverTime {
      get { return lastRecoverTime_; }
      set {
        lastRecoverTime_ = value;
      }
    }

    /// <summary>Field number for the "item_cost_list" field.</summary>
    public const int ItemCostListFieldNumber = 10;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.ItemCost> _repeated_itemCostList_codec
        = pb::FieldCodec.ForMessage(82, global::EggLink.DanhengServer.Proto.ItemCost.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ItemCost> itemCostList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ItemCost>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ItemCost> ItemCostList {
      get { return itemCostList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ExchangeStaminaScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ExchangeStaminaScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (StaminaAdd != other.StaminaAdd) return false;
      if (ExchangeTimes != other.ExchangeTimes) return false;
      if (Retcode != other.Retcode) return false;
      if (LastRecoverTime != other.LastRecoverTime) return false;
      if(!itemCostList_.Equals(other.itemCostList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (StaminaAdd != 0) hash ^= StaminaAdd.GetHashCode();
      if (ExchangeTimes != 0) hash ^= ExchangeTimes.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (LastRecoverTime != 0L) hash ^= LastRecoverTime.GetHashCode();
      hash ^= itemCostList_.GetHashCode();
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
      if (Retcode != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Retcode);
      }
      if (LastRecoverTime != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(LastRecoverTime);
      }
      if (ExchangeTimes != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(ExchangeTimes);
      }
      itemCostList_.WriteTo(output, _repeated_itemCostList_codec);
      if (StaminaAdd != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(StaminaAdd);
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
      if (Retcode != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Retcode);
      }
      if (LastRecoverTime != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(LastRecoverTime);
      }
      if (ExchangeTimes != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(ExchangeTimes);
      }
      itemCostList_.WriteTo(ref output, _repeated_itemCostList_codec);
      if (StaminaAdd != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(StaminaAdd);
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
      if (StaminaAdd != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StaminaAdd);
      }
      if (ExchangeTimes != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ExchangeTimes);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (LastRecoverTime != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(LastRecoverTime);
      }
      size += itemCostList_.CalculateSize(_repeated_itemCostList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ExchangeStaminaScRsp other) {
      if (other == null) {
        return;
      }
      if (other.StaminaAdd != 0) {
        StaminaAdd = other.StaminaAdd;
      }
      if (other.ExchangeTimes != 0) {
        ExchangeTimes = other.ExchangeTimes;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.LastRecoverTime != 0L) {
        LastRecoverTime = other.LastRecoverTime;
      }
      itemCostList_.Add(other.itemCostList_);
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
            Retcode = input.ReadUInt32();
            break;
          }
          case 40: {
            LastRecoverTime = input.ReadInt64();
            break;
          }
          case 72: {
            ExchangeTimes = input.ReadUInt32();
            break;
          }
          case 82: {
            itemCostList_.AddEntriesFrom(input, _repeated_itemCostList_codec);
            break;
          }
          case 112: {
            StaminaAdd = input.ReadUInt32();
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
            Retcode = input.ReadUInt32();
            break;
          }
          case 40: {
            LastRecoverTime = input.ReadInt64();
            break;
          }
          case 72: {
            ExchangeTimes = input.ReadUInt32();
            break;
          }
          case 82: {
            itemCostList_.AddEntriesFrom(ref input, _repeated_itemCostList_codec);
            break;
          }
          case 112: {
            StaminaAdd = input.ReadUInt32();
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