// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EDBLNCMJOHJ.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from EDBLNCMJOHJ.proto</summary>
  public static partial class EDBLNCMJOHJReflection {

    #region Descriptor
    /// <summary>File descriptor for EDBLNCMJOHJ.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EDBLNCMJOHJReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFFREJMTkNNSk9ISi5wcm90bxoPU3BCYXJJbmZvLnByb3RvInIKC0VEQkxO",
            "Q01KT0hKEhoKBnNwX2JhchgCIAEoCzIKLlNwQmFySW5mbxITCgthdmF0YXJf",
            "dHlwZRgPIAEoDRIKCgJocBgLIAEoDRIRCglhdmF0YXJfaWQYByABKA0SEwoL",
            "SUNORkFNQUZFTkwYCSABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Q",
            "cm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.SpBarInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.EDBLNCMJOHJ), global::EggLink.DanhengServer.Proto.EDBLNCMJOHJ.Parser, new[]{ "SpBar", "AvatarType", "Hp", "AvatarId", "ICNFAMAFENL" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class EDBLNCMJOHJ : pb::IMessage<EDBLNCMJOHJ>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EDBLNCMJOHJ> _parser = new pb::MessageParser<EDBLNCMJOHJ>(() => new EDBLNCMJOHJ());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EDBLNCMJOHJ> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.EDBLNCMJOHJReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EDBLNCMJOHJ() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EDBLNCMJOHJ(EDBLNCMJOHJ other) : this() {
      spBar_ = other.spBar_ != null ? other.spBar_.Clone() : null;
      avatarType_ = other.avatarType_;
      hp_ = other.hp_;
      avatarId_ = other.avatarId_;
      iCNFAMAFENL_ = other.iCNFAMAFENL_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EDBLNCMJOHJ Clone() {
      return new EDBLNCMJOHJ(this);
    }

    /// <summary>Field number for the "sp_bar" field.</summary>
    public const int SpBarFieldNumber = 2;
    private global::EggLink.DanhengServer.Proto.SpBarInfo spBar_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.SpBarInfo SpBar {
      get { return spBar_; }
      set {
        spBar_ = value;
      }
    }

    /// <summary>Field number for the "avatar_type" field.</summary>
    public const int AvatarTypeFieldNumber = 15;
    private uint avatarType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AvatarType {
      get { return avatarType_; }
      set {
        avatarType_ = value;
      }
    }

    /// <summary>Field number for the "hp" field.</summary>
    public const int HpFieldNumber = 11;
    private uint hp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Hp {
      get { return hp_; }
      set {
        hp_ = value;
      }
    }

    /// <summary>Field number for the "avatar_id" field.</summary>
    public const int AvatarIdFieldNumber = 7;
    private uint avatarId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AvatarId {
      get { return avatarId_; }
      set {
        avatarId_ = value;
      }
    }

    /// <summary>Field number for the "ICNFAMAFENL" field.</summary>
    public const int ICNFAMAFENLFieldNumber = 9;
    private uint iCNFAMAFENL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ICNFAMAFENL {
      get { return iCNFAMAFENL_; }
      set {
        iCNFAMAFENL_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EDBLNCMJOHJ);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EDBLNCMJOHJ other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(SpBar, other.SpBar)) return false;
      if (AvatarType != other.AvatarType) return false;
      if (Hp != other.Hp) return false;
      if (AvatarId != other.AvatarId) return false;
      if (ICNFAMAFENL != other.ICNFAMAFENL) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (spBar_ != null) hash ^= SpBar.GetHashCode();
      if (AvatarType != 0) hash ^= AvatarType.GetHashCode();
      if (Hp != 0) hash ^= Hp.GetHashCode();
      if (AvatarId != 0) hash ^= AvatarId.GetHashCode();
      if (ICNFAMAFENL != 0) hash ^= ICNFAMAFENL.GetHashCode();
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
      if (spBar_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(SpBar);
      }
      if (AvatarId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(AvatarId);
      }
      if (ICNFAMAFENL != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(ICNFAMAFENL);
      }
      if (Hp != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Hp);
      }
      if (AvatarType != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(AvatarType);
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
      if (spBar_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(SpBar);
      }
      if (AvatarId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(AvatarId);
      }
      if (ICNFAMAFENL != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(ICNFAMAFENL);
      }
      if (Hp != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Hp);
      }
      if (AvatarType != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(AvatarType);
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
      if (spBar_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SpBar);
      }
      if (AvatarType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AvatarType);
      }
      if (Hp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Hp);
      }
      if (AvatarId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AvatarId);
      }
      if (ICNFAMAFENL != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ICNFAMAFENL);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EDBLNCMJOHJ other) {
      if (other == null) {
        return;
      }
      if (other.spBar_ != null) {
        if (spBar_ == null) {
          SpBar = new global::EggLink.DanhengServer.Proto.SpBarInfo();
        }
        SpBar.MergeFrom(other.SpBar);
      }
      if (other.AvatarType != 0) {
        AvatarType = other.AvatarType;
      }
      if (other.Hp != 0) {
        Hp = other.Hp;
      }
      if (other.AvatarId != 0) {
        AvatarId = other.AvatarId;
      }
      if (other.ICNFAMAFENL != 0) {
        ICNFAMAFENL = other.ICNFAMAFENL;
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
          case 18: {
            if (spBar_ == null) {
              SpBar = new global::EggLink.DanhengServer.Proto.SpBarInfo();
            }
            input.ReadMessage(SpBar);
            break;
          }
          case 56: {
            AvatarId = input.ReadUInt32();
            break;
          }
          case 72: {
            ICNFAMAFENL = input.ReadUInt32();
            break;
          }
          case 88: {
            Hp = input.ReadUInt32();
            break;
          }
          case 120: {
            AvatarType = input.ReadUInt32();
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
          case 18: {
            if (spBar_ == null) {
              SpBar = new global::EggLink.DanhengServer.Proto.SpBarInfo();
            }
            input.ReadMessage(SpBar);
            break;
          }
          case 56: {
            AvatarId = input.ReadUInt32();
            break;
          }
          case 72: {
            ICNFAMAFENL = input.ReadUInt32();
            break;
          }
          case 88: {
            Hp = input.ReadUInt32();
            break;
          }
          case 120: {
            AvatarType = input.ReadUInt32();
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