// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EvolveBuildGearDamageInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from EvolveBuildGearDamageInfo.proto</summary>
  public static partial class EvolveBuildGearDamageInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for EvolveBuildGearDamageInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EvolveBuildGearDamageInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9Fdm9sdmVCdWlsZEdlYXJEYW1hZ2VJbmZvLnByb3RvIk8KGUV2b2x2ZUJ1",
            "aWxkR2VhckRhbWFnZUluZm8SDwoHZ2Vhcl9pZBgBIAEoDRIOCgZkYW1hZ2UY",
            "AiABKAESEQoJaHBfZGFtYWdlGAMgASgBQh6qAhtFZ2dMaW5rLkRhbmhlbmdT",
            "ZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.EvolveBuildGearDamageInfo), global::EggLink.DanhengServer.Proto.EvolveBuildGearDamageInfo.Parser, new[]{ "GearId", "Damage", "HpDamage" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class EvolveBuildGearDamageInfo : pb::IMessage<EvolveBuildGearDamageInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EvolveBuildGearDamageInfo> _parser = new pb::MessageParser<EvolveBuildGearDamageInfo>(() => new EvolveBuildGearDamageInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EvolveBuildGearDamageInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.EvolveBuildGearDamageInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvolveBuildGearDamageInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvolveBuildGearDamageInfo(EvolveBuildGearDamageInfo other) : this() {
      gearId_ = other.gearId_;
      damage_ = other.damage_;
      hpDamage_ = other.hpDamage_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvolveBuildGearDamageInfo Clone() {
      return new EvolveBuildGearDamageInfo(this);
    }

    /// <summary>Field number for the "gear_id" field.</summary>
    public const int GearIdFieldNumber = 1;
    private uint gearId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GearId {
      get { return gearId_; }
      set {
        gearId_ = value;
      }
    }

    /// <summary>Field number for the "damage" field.</summary>
    public const int DamageFieldNumber = 2;
    private double damage_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Damage {
      get { return damage_; }
      set {
        damage_ = value;
      }
    }

    /// <summary>Field number for the "hp_damage" field.</summary>
    public const int HpDamageFieldNumber = 3;
    private double hpDamage_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double HpDamage {
      get { return hpDamage_; }
      set {
        hpDamage_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EvolveBuildGearDamageInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EvolveBuildGearDamageInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GearId != other.GearId) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Damage, other.Damage)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(HpDamage, other.HpDamage)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (GearId != 0) hash ^= GearId.GetHashCode();
      if (Damage != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Damage);
      if (HpDamage != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(HpDamage);
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
      if (GearId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(GearId);
      }
      if (Damage != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(Damage);
      }
      if (HpDamage != 0D) {
        output.WriteRawTag(25);
        output.WriteDouble(HpDamage);
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
      if (GearId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(GearId);
      }
      if (Damage != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(Damage);
      }
      if (HpDamage != 0D) {
        output.WriteRawTag(25);
        output.WriteDouble(HpDamage);
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
      if (GearId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GearId);
      }
      if (Damage != 0D) {
        size += 1 + 8;
      }
      if (HpDamage != 0D) {
        size += 1 + 8;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EvolveBuildGearDamageInfo other) {
      if (other == null) {
        return;
      }
      if (other.GearId != 0) {
        GearId = other.GearId;
      }
      if (other.Damage != 0D) {
        Damage = other.Damage;
      }
      if (other.HpDamage != 0D) {
        HpDamage = other.HpDamage;
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
            GearId = input.ReadUInt32();
            break;
          }
          case 17: {
            Damage = input.ReadDouble();
            break;
          }
          case 25: {
            HpDamage = input.ReadDouble();
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
            GearId = input.ReadUInt32();
            break;
          }
          case 17: {
            Damage = input.ReadDouble();
            break;
          }
          case 25: {
            HpDamage = input.ReadDouble();
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
