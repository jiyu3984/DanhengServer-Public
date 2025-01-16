// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RelicFilterPlanSettings.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RelicFilterPlanSettings.proto</summary>
  public static partial class RelicFilterPlanSettingsReflection {

    #region Descriptor
    /// <summary>File descriptor for RelicFilterPlanSettings.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RelicFilterPlanSettingsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1SZWxpY0ZpbHRlclBsYW5TZXR0aW5ncy5wcm90byLtAgoXUmVsaWNGaWx0",
            "ZXJQbGFuU2V0dGluZ3MSFQoNcmFyaXR5X2JpdHNldBgBIAEoDRIWCg5yZWxp",
            "Y19zZXRfbGlzdBgCIAMoDRIfChdib2R5X21haW5fcHJvcGVydHlfbGlzdBgD",
            "IAMoDRIfChdmb290X21haW5fcHJvcGVydHlfbGlzdBgEIAMoDRIhChlzcGhl",
            "cmVfbWFpbl9wcm9wZXJ0eV9saXN0GAUgAygNEh8KF3JvcGVfbWFpbl9wcm9w",
            "ZXJ0eV9saXN0GAYgAygNEiYKHmlzX2luY2x1ZGVfZmlsdGVyX3N1Yl9wcm9w",
            "ZXJ0eRgHIAEoCBIYChBzdWJfcHJvcGVydHlfbnVtGAggASgNEhkKEXN1Yl9w",
            "cm9wZXJ0eV9saXN0GAkgAygNEh8KF2hlYWRfbWFpbl9wcm9wZXJ0eV9saXN0",
            "GAogAygNEh8KF2hhbmRfbWFpbl9wcm9wZXJ0eV9saXN0GAsgAygNQh6qAhtF",
            "Z2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RelicFilterPlanSettings), global::EggLink.DanhengServer.Proto.RelicFilterPlanSettings.Parser, new[]{ "RarityBitset", "RelicSetList", "BodyMainPropertyList", "FootMainPropertyList", "SphereMainPropertyList", "RopeMainPropertyList", "IsIncludeFilterSubProperty", "SubPropertyNum", "SubPropertyList", "HeadMainPropertyList", "HandMainPropertyList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RelicFilterPlanSettings : pb::IMessage<RelicFilterPlanSettings>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RelicFilterPlanSettings> _parser = new pb::MessageParser<RelicFilterPlanSettings>(() => new RelicFilterPlanSettings());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RelicFilterPlanSettings> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RelicFilterPlanSettingsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RelicFilterPlanSettings() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RelicFilterPlanSettings(RelicFilterPlanSettings other) : this() {
      rarityBitset_ = other.rarityBitset_;
      relicSetList_ = other.relicSetList_.Clone();
      bodyMainPropertyList_ = other.bodyMainPropertyList_.Clone();
      footMainPropertyList_ = other.footMainPropertyList_.Clone();
      sphereMainPropertyList_ = other.sphereMainPropertyList_.Clone();
      ropeMainPropertyList_ = other.ropeMainPropertyList_.Clone();
      isIncludeFilterSubProperty_ = other.isIncludeFilterSubProperty_;
      subPropertyNum_ = other.subPropertyNum_;
      subPropertyList_ = other.subPropertyList_.Clone();
      headMainPropertyList_ = other.headMainPropertyList_.Clone();
      handMainPropertyList_ = other.handMainPropertyList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RelicFilterPlanSettings Clone() {
      return new RelicFilterPlanSettings(this);
    }

    /// <summary>Field number for the "rarity_bitset" field.</summary>
    public const int RarityBitsetFieldNumber = 1;
    private uint rarityBitset_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RarityBitset {
      get { return rarityBitset_; }
      set {
        rarityBitset_ = value;
      }
    }

    /// <summary>Field number for the "relic_set_list" field.</summary>
    public const int RelicSetListFieldNumber = 2;
    private static readonly pb::FieldCodec<uint> _repeated_relicSetList_codec
        = pb::FieldCodec.ForUInt32(18);
    private readonly pbc::RepeatedField<uint> relicSetList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> RelicSetList {
      get { return relicSetList_; }
    }

    /// <summary>Field number for the "body_main_property_list" field.</summary>
    public const int BodyMainPropertyListFieldNumber = 3;
    private static readonly pb::FieldCodec<uint> _repeated_bodyMainPropertyList_codec
        = pb::FieldCodec.ForUInt32(26);
    private readonly pbc::RepeatedField<uint> bodyMainPropertyList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> BodyMainPropertyList {
      get { return bodyMainPropertyList_; }
    }

    /// <summary>Field number for the "foot_main_property_list" field.</summary>
    public const int FootMainPropertyListFieldNumber = 4;
    private static readonly pb::FieldCodec<uint> _repeated_footMainPropertyList_codec
        = pb::FieldCodec.ForUInt32(34);
    private readonly pbc::RepeatedField<uint> footMainPropertyList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> FootMainPropertyList {
      get { return footMainPropertyList_; }
    }

    /// <summary>Field number for the "sphere_main_property_list" field.</summary>
    public const int SphereMainPropertyListFieldNumber = 5;
    private static readonly pb::FieldCodec<uint> _repeated_sphereMainPropertyList_codec
        = pb::FieldCodec.ForUInt32(42);
    private readonly pbc::RepeatedField<uint> sphereMainPropertyList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> SphereMainPropertyList {
      get { return sphereMainPropertyList_; }
    }

    /// <summary>Field number for the "rope_main_property_list" field.</summary>
    public const int RopeMainPropertyListFieldNumber = 6;
    private static readonly pb::FieldCodec<uint> _repeated_ropeMainPropertyList_codec
        = pb::FieldCodec.ForUInt32(50);
    private readonly pbc::RepeatedField<uint> ropeMainPropertyList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> RopeMainPropertyList {
      get { return ropeMainPropertyList_; }
    }

    /// <summary>Field number for the "is_include_filter_sub_property" field.</summary>
    public const int IsIncludeFilterSubPropertyFieldNumber = 7;
    private bool isIncludeFilterSubProperty_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsIncludeFilterSubProperty {
      get { return isIncludeFilterSubProperty_; }
      set {
        isIncludeFilterSubProperty_ = value;
      }
    }

    /// <summary>Field number for the "sub_property_num" field.</summary>
    public const int SubPropertyNumFieldNumber = 8;
    private uint subPropertyNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SubPropertyNum {
      get { return subPropertyNum_; }
      set {
        subPropertyNum_ = value;
      }
    }

    /// <summary>Field number for the "sub_property_list" field.</summary>
    public const int SubPropertyListFieldNumber = 9;
    private static readonly pb::FieldCodec<uint> _repeated_subPropertyList_codec
        = pb::FieldCodec.ForUInt32(74);
    private readonly pbc::RepeatedField<uint> subPropertyList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> SubPropertyList {
      get { return subPropertyList_; }
    }

    /// <summary>Field number for the "head_main_property_list" field.</summary>
    public const int HeadMainPropertyListFieldNumber = 10;
    private static readonly pb::FieldCodec<uint> _repeated_headMainPropertyList_codec
        = pb::FieldCodec.ForUInt32(82);
    private readonly pbc::RepeatedField<uint> headMainPropertyList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> HeadMainPropertyList {
      get { return headMainPropertyList_; }
    }

    /// <summary>Field number for the "hand_main_property_list" field.</summary>
    public const int HandMainPropertyListFieldNumber = 11;
    private static readonly pb::FieldCodec<uint> _repeated_handMainPropertyList_codec
        = pb::FieldCodec.ForUInt32(90);
    private readonly pbc::RepeatedField<uint> handMainPropertyList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> HandMainPropertyList {
      get { return handMainPropertyList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RelicFilterPlanSettings);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RelicFilterPlanSettings other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RarityBitset != other.RarityBitset) return false;
      if(!relicSetList_.Equals(other.relicSetList_)) return false;
      if(!bodyMainPropertyList_.Equals(other.bodyMainPropertyList_)) return false;
      if(!footMainPropertyList_.Equals(other.footMainPropertyList_)) return false;
      if(!sphereMainPropertyList_.Equals(other.sphereMainPropertyList_)) return false;
      if(!ropeMainPropertyList_.Equals(other.ropeMainPropertyList_)) return false;
      if (IsIncludeFilterSubProperty != other.IsIncludeFilterSubProperty) return false;
      if (SubPropertyNum != other.SubPropertyNum) return false;
      if(!subPropertyList_.Equals(other.subPropertyList_)) return false;
      if(!headMainPropertyList_.Equals(other.headMainPropertyList_)) return false;
      if(!handMainPropertyList_.Equals(other.handMainPropertyList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (RarityBitset != 0) hash ^= RarityBitset.GetHashCode();
      hash ^= relicSetList_.GetHashCode();
      hash ^= bodyMainPropertyList_.GetHashCode();
      hash ^= footMainPropertyList_.GetHashCode();
      hash ^= sphereMainPropertyList_.GetHashCode();
      hash ^= ropeMainPropertyList_.GetHashCode();
      if (IsIncludeFilterSubProperty != false) hash ^= IsIncludeFilterSubProperty.GetHashCode();
      if (SubPropertyNum != 0) hash ^= SubPropertyNum.GetHashCode();
      hash ^= subPropertyList_.GetHashCode();
      hash ^= headMainPropertyList_.GetHashCode();
      hash ^= handMainPropertyList_.GetHashCode();
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
      if (RarityBitset != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(RarityBitset);
      }
      relicSetList_.WriteTo(output, _repeated_relicSetList_codec);
      bodyMainPropertyList_.WriteTo(output, _repeated_bodyMainPropertyList_codec);
      footMainPropertyList_.WriteTo(output, _repeated_footMainPropertyList_codec);
      sphereMainPropertyList_.WriteTo(output, _repeated_sphereMainPropertyList_codec);
      ropeMainPropertyList_.WriteTo(output, _repeated_ropeMainPropertyList_codec);
      if (IsIncludeFilterSubProperty != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsIncludeFilterSubProperty);
      }
      if (SubPropertyNum != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(SubPropertyNum);
      }
      subPropertyList_.WriteTo(output, _repeated_subPropertyList_codec);
      headMainPropertyList_.WriteTo(output, _repeated_headMainPropertyList_codec);
      handMainPropertyList_.WriteTo(output, _repeated_handMainPropertyList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (RarityBitset != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(RarityBitset);
      }
      relicSetList_.WriteTo(ref output, _repeated_relicSetList_codec);
      bodyMainPropertyList_.WriteTo(ref output, _repeated_bodyMainPropertyList_codec);
      footMainPropertyList_.WriteTo(ref output, _repeated_footMainPropertyList_codec);
      sphereMainPropertyList_.WriteTo(ref output, _repeated_sphereMainPropertyList_codec);
      ropeMainPropertyList_.WriteTo(ref output, _repeated_ropeMainPropertyList_codec);
      if (IsIncludeFilterSubProperty != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsIncludeFilterSubProperty);
      }
      if (SubPropertyNum != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(SubPropertyNum);
      }
      subPropertyList_.WriteTo(ref output, _repeated_subPropertyList_codec);
      headMainPropertyList_.WriteTo(ref output, _repeated_headMainPropertyList_codec);
      handMainPropertyList_.WriteTo(ref output, _repeated_handMainPropertyList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (RarityBitset != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RarityBitset);
      }
      size += relicSetList_.CalculateSize(_repeated_relicSetList_codec);
      size += bodyMainPropertyList_.CalculateSize(_repeated_bodyMainPropertyList_codec);
      size += footMainPropertyList_.CalculateSize(_repeated_footMainPropertyList_codec);
      size += sphereMainPropertyList_.CalculateSize(_repeated_sphereMainPropertyList_codec);
      size += ropeMainPropertyList_.CalculateSize(_repeated_ropeMainPropertyList_codec);
      if (IsIncludeFilterSubProperty != false) {
        size += 1 + 1;
      }
      if (SubPropertyNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SubPropertyNum);
      }
      size += subPropertyList_.CalculateSize(_repeated_subPropertyList_codec);
      size += headMainPropertyList_.CalculateSize(_repeated_headMainPropertyList_codec);
      size += handMainPropertyList_.CalculateSize(_repeated_handMainPropertyList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RelicFilterPlanSettings other) {
      if (other == null) {
        return;
      }
      if (other.RarityBitset != 0) {
        RarityBitset = other.RarityBitset;
      }
      relicSetList_.Add(other.relicSetList_);
      bodyMainPropertyList_.Add(other.bodyMainPropertyList_);
      footMainPropertyList_.Add(other.footMainPropertyList_);
      sphereMainPropertyList_.Add(other.sphereMainPropertyList_);
      ropeMainPropertyList_.Add(other.ropeMainPropertyList_);
      if (other.IsIncludeFilterSubProperty != false) {
        IsIncludeFilterSubProperty = other.IsIncludeFilterSubProperty;
      }
      if (other.SubPropertyNum != 0) {
        SubPropertyNum = other.SubPropertyNum;
      }
      subPropertyList_.Add(other.subPropertyList_);
      headMainPropertyList_.Add(other.headMainPropertyList_);
      handMainPropertyList_.Add(other.handMainPropertyList_);
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
            RarityBitset = input.ReadUInt32();
            break;
          }
          case 18:
          case 16: {
            relicSetList_.AddEntriesFrom(input, _repeated_relicSetList_codec);
            break;
          }
          case 26:
          case 24: {
            bodyMainPropertyList_.AddEntriesFrom(input, _repeated_bodyMainPropertyList_codec);
            break;
          }
          case 34:
          case 32: {
            footMainPropertyList_.AddEntriesFrom(input, _repeated_footMainPropertyList_codec);
            break;
          }
          case 42:
          case 40: {
            sphereMainPropertyList_.AddEntriesFrom(input, _repeated_sphereMainPropertyList_codec);
            break;
          }
          case 50:
          case 48: {
            ropeMainPropertyList_.AddEntriesFrom(input, _repeated_ropeMainPropertyList_codec);
            break;
          }
          case 56: {
            IsIncludeFilterSubProperty = input.ReadBool();
            break;
          }
          case 64: {
            SubPropertyNum = input.ReadUInt32();
            break;
          }
          case 74:
          case 72: {
            subPropertyList_.AddEntriesFrom(input, _repeated_subPropertyList_codec);
            break;
          }
          case 82:
          case 80: {
            headMainPropertyList_.AddEntriesFrom(input, _repeated_headMainPropertyList_codec);
            break;
          }
          case 90:
          case 88: {
            handMainPropertyList_.AddEntriesFrom(input, _repeated_handMainPropertyList_codec);
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
            RarityBitset = input.ReadUInt32();
            break;
          }
          case 18:
          case 16: {
            relicSetList_.AddEntriesFrom(ref input, _repeated_relicSetList_codec);
            break;
          }
          case 26:
          case 24: {
            bodyMainPropertyList_.AddEntriesFrom(ref input, _repeated_bodyMainPropertyList_codec);
            break;
          }
          case 34:
          case 32: {
            footMainPropertyList_.AddEntriesFrom(ref input, _repeated_footMainPropertyList_codec);
            break;
          }
          case 42:
          case 40: {
            sphereMainPropertyList_.AddEntriesFrom(ref input, _repeated_sphereMainPropertyList_codec);
            break;
          }
          case 50:
          case 48: {
            ropeMainPropertyList_.AddEntriesFrom(ref input, _repeated_ropeMainPropertyList_codec);
            break;
          }
          case 56: {
            IsIncludeFilterSubProperty = input.ReadBool();
            break;
          }
          case 64: {
            SubPropertyNum = input.ReadUInt32();
            break;
          }
          case 74:
          case 72: {
            subPropertyList_.AddEntriesFrom(ref input, _repeated_subPropertyList_codec);
            break;
          }
          case 82:
          case 80: {
            headMainPropertyList_.AddEntriesFrom(ref input, _repeated_headMainPropertyList_codec);
            break;
          }
          case 90:
          case 88: {
            handMainPropertyList_.AddEntriesFrom(ref input, _repeated_handMainPropertyList_codec);
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
