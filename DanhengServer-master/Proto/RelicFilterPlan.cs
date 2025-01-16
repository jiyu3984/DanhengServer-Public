// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RelicFilterPlan.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RelicFilterPlan.proto</summary>
  public static partial class RelicFilterPlanReflection {

    #region Descriptor
    /// <summary>File descriptor for RelicFilterPlan.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RelicFilterPlanReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVSZWxpY0ZpbHRlclBsYW4ucHJvdG8aGVJlbGljRmlsdGVyUGxhbkljb24u",
            "cHJvdG8aHVJlbGljRmlsdGVyUGxhblNldHRpbmdzLnByb3RvIs0BCg9SZWxp",
            "Y0ZpbHRlclBsYW4SEgoKc2xvdF9pbmRleBgCIAEoDRIMCgRuYW1lGAEgASgJ",
            "EioKCHNldHRpbmdzGA8gASgLMhguUmVsaWNGaWx0ZXJQbGFuU2V0dGluZ3MS",
            "IgoEaWNvbhgIIAEoCzIULlJlbGljRmlsdGVyUGxhbkljb24SGAoQdXBkYXRl",
            "X3RpbWVzdGFtcBgNIAEoAxIRCglpc19tYXJrZWQYBCABKAgSGwoTYXZhdGFy",
            "X2lkX29uX2NyZWF0ZRgJIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVy",
            "LlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RelicFilterPlanIconReflection.Descriptor, global::EggLink.DanhengServer.Proto.RelicFilterPlanSettingsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RelicFilterPlan), global::EggLink.DanhengServer.Proto.RelicFilterPlan.Parser, new[]{ "SlotIndex", "Name", "Settings", "Icon", "UpdateTimestamp", "IsMarked", "AvatarIdOnCreate" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RelicFilterPlan : pb::IMessage<RelicFilterPlan>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RelicFilterPlan> _parser = new pb::MessageParser<RelicFilterPlan>(() => new RelicFilterPlan());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RelicFilterPlan> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RelicFilterPlanReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RelicFilterPlan() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RelicFilterPlan(RelicFilterPlan other) : this() {
      slotIndex_ = other.slotIndex_;
      name_ = other.name_;
      settings_ = other.settings_ != null ? other.settings_.Clone() : null;
      icon_ = other.icon_ != null ? other.icon_.Clone() : null;
      updateTimestamp_ = other.updateTimestamp_;
      isMarked_ = other.isMarked_;
      avatarIdOnCreate_ = other.avatarIdOnCreate_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RelicFilterPlan Clone() {
      return new RelicFilterPlan(this);
    }

    /// <summary>Field number for the "slot_index" field.</summary>
    public const int SlotIndexFieldNumber = 2;
    private uint slotIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SlotIndex {
      get { return slotIndex_; }
      set {
        slotIndex_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "settings" field.</summary>
    public const int SettingsFieldNumber = 15;
    private global::EggLink.DanhengServer.Proto.RelicFilterPlanSettings settings_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RelicFilterPlanSettings Settings {
      get { return settings_; }
      set {
        settings_ = value;
      }
    }

    /// <summary>Field number for the "icon" field.</summary>
    public const int IconFieldNumber = 8;
    private global::EggLink.DanhengServer.Proto.RelicFilterPlanIcon icon_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RelicFilterPlanIcon Icon {
      get { return icon_; }
      set {
        icon_ = value;
      }
    }

    /// <summary>Field number for the "update_timestamp" field.</summary>
    public const int UpdateTimestampFieldNumber = 13;
    private long updateTimestamp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long UpdateTimestamp {
      get { return updateTimestamp_; }
      set {
        updateTimestamp_ = value;
      }
    }

    /// <summary>Field number for the "is_marked" field.</summary>
    public const int IsMarkedFieldNumber = 4;
    private bool isMarked_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsMarked {
      get { return isMarked_; }
      set {
        isMarked_ = value;
      }
    }

    /// <summary>Field number for the "avatar_id_on_create" field.</summary>
    public const int AvatarIdOnCreateFieldNumber = 9;
    private uint avatarIdOnCreate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AvatarIdOnCreate {
      get { return avatarIdOnCreate_; }
      set {
        avatarIdOnCreate_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RelicFilterPlan);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RelicFilterPlan other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SlotIndex != other.SlotIndex) return false;
      if (Name != other.Name) return false;
      if (!object.Equals(Settings, other.Settings)) return false;
      if (!object.Equals(Icon, other.Icon)) return false;
      if (UpdateTimestamp != other.UpdateTimestamp) return false;
      if (IsMarked != other.IsMarked) return false;
      if (AvatarIdOnCreate != other.AvatarIdOnCreate) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (SlotIndex != 0) hash ^= SlotIndex.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (settings_ != null) hash ^= Settings.GetHashCode();
      if (icon_ != null) hash ^= Icon.GetHashCode();
      if (UpdateTimestamp != 0L) hash ^= UpdateTimestamp.GetHashCode();
      if (IsMarked != false) hash ^= IsMarked.GetHashCode();
      if (AvatarIdOnCreate != 0) hash ^= AvatarIdOnCreate.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (SlotIndex != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(SlotIndex);
      }
      if (IsMarked != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsMarked);
      }
      if (icon_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(Icon);
      }
      if (AvatarIdOnCreate != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(AvatarIdOnCreate);
      }
      if (UpdateTimestamp != 0L) {
        output.WriteRawTag(104);
        output.WriteInt64(UpdateTimestamp);
      }
      if (settings_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(Settings);
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (SlotIndex != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(SlotIndex);
      }
      if (IsMarked != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsMarked);
      }
      if (icon_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(Icon);
      }
      if (AvatarIdOnCreate != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(AvatarIdOnCreate);
      }
      if (UpdateTimestamp != 0L) {
        output.WriteRawTag(104);
        output.WriteInt64(UpdateTimestamp);
      }
      if (settings_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(Settings);
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
      if (SlotIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SlotIndex);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (settings_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Settings);
      }
      if (icon_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Icon);
      }
      if (UpdateTimestamp != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(UpdateTimestamp);
      }
      if (IsMarked != false) {
        size += 1 + 1;
      }
      if (AvatarIdOnCreate != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AvatarIdOnCreate);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RelicFilterPlan other) {
      if (other == null) {
        return;
      }
      if (other.SlotIndex != 0) {
        SlotIndex = other.SlotIndex;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.settings_ != null) {
        if (settings_ == null) {
          Settings = new global::EggLink.DanhengServer.Proto.RelicFilterPlanSettings();
        }
        Settings.MergeFrom(other.Settings);
      }
      if (other.icon_ != null) {
        if (icon_ == null) {
          Icon = new global::EggLink.DanhengServer.Proto.RelicFilterPlanIcon();
        }
        Icon.MergeFrom(other.Icon);
      }
      if (other.UpdateTimestamp != 0L) {
        UpdateTimestamp = other.UpdateTimestamp;
      }
      if (other.IsMarked != false) {
        IsMarked = other.IsMarked;
      }
      if (other.AvatarIdOnCreate != 0) {
        AvatarIdOnCreate = other.AvatarIdOnCreate;
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
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 16: {
            SlotIndex = input.ReadUInt32();
            break;
          }
          case 32: {
            IsMarked = input.ReadBool();
            break;
          }
          case 66: {
            if (icon_ == null) {
              Icon = new global::EggLink.DanhengServer.Proto.RelicFilterPlanIcon();
            }
            input.ReadMessage(Icon);
            break;
          }
          case 72: {
            AvatarIdOnCreate = input.ReadUInt32();
            break;
          }
          case 104: {
            UpdateTimestamp = input.ReadInt64();
            break;
          }
          case 122: {
            if (settings_ == null) {
              Settings = new global::EggLink.DanhengServer.Proto.RelicFilterPlanSettings();
            }
            input.ReadMessage(Settings);
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
            Name = input.ReadString();
            break;
          }
          case 16: {
            SlotIndex = input.ReadUInt32();
            break;
          }
          case 32: {
            IsMarked = input.ReadBool();
            break;
          }
          case 66: {
            if (icon_ == null) {
              Icon = new global::EggLink.DanhengServer.Proto.RelicFilterPlanIcon();
            }
            input.ReadMessage(Icon);
            break;
          }
          case 72: {
            AvatarIdOnCreate = input.ReadUInt32();
            break;
          }
          case 104: {
            UpdateTimestamp = input.ReadInt64();
            break;
          }
          case 122: {
            if (settings_ == null) {
              Settings = new global::EggLink.DanhengServer.Proto.RelicFilterPlanSettings();
            }
            input.ReadMessage(Settings);
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