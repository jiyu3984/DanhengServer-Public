// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: UnlockAvatarPathScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from UnlockAvatarPathScRsp.proto</summary>
  public static partial class UnlockAvatarPathScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for UnlockAvatarPathScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UnlockAvatarPathScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtVbmxvY2tBdmF0YXJQYXRoU2NSc3AucHJvdG8aGU11bHRpUGF0aEF2YXRh",
            "clR5cGUucHJvdG8aDkl0ZW1MaXN0LnByb3RvIogBChVVbmxvY2tBdmF0YXJQ",
            "YXRoU2NSc3ASJwoJYXZhdGFyX2lkGA8gASgOMhQuTXVsdGlQYXRoQXZhdGFy",
            "VHlwZRIPCgdyZXRjb2RlGA0gASgNEhkKBnJld2FyZBgEIAEoCzIJLkl0ZW1M",
            "aXN0EhoKEmJhc2ljX3R5cGVfaWRfbGlzdBgKIAMoDUIeqgIbRWdnTGluay5E",
            "YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.MultiPathAvatarTypeReflection.Descriptor, global::EggLink.DanhengServer.Proto.ItemListReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.UnlockAvatarPathScRsp), global::EggLink.DanhengServer.Proto.UnlockAvatarPathScRsp.Parser, new[]{ "AvatarId", "Retcode", "Reward", "BasicTypeIdList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class UnlockAvatarPathScRsp : pb::IMessage<UnlockAvatarPathScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UnlockAvatarPathScRsp> _parser = new pb::MessageParser<UnlockAvatarPathScRsp>(() => new UnlockAvatarPathScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<UnlockAvatarPathScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.UnlockAvatarPathScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UnlockAvatarPathScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UnlockAvatarPathScRsp(UnlockAvatarPathScRsp other) : this() {
      avatarId_ = other.avatarId_;
      retcode_ = other.retcode_;
      reward_ = other.reward_ != null ? other.reward_.Clone() : null;
      basicTypeIdList_ = other.basicTypeIdList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UnlockAvatarPathScRsp Clone() {
      return new UnlockAvatarPathScRsp(this);
    }

    /// <summary>Field number for the "avatar_id" field.</summary>
    public const int AvatarIdFieldNumber = 15;
    private global::EggLink.DanhengServer.Proto.MultiPathAvatarType avatarId_ = global::EggLink.DanhengServer.Proto.MultiPathAvatarType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.MultiPathAvatarType AvatarId {
      get { return avatarId_; }
      set {
        avatarId_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 13;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "reward" field.</summary>
    public const int RewardFieldNumber = 4;
    private global::EggLink.DanhengServer.Proto.ItemList reward_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemList Reward {
      get { return reward_; }
      set {
        reward_ = value;
      }
    }

    /// <summary>Field number for the "basic_type_id_list" field.</summary>
    public const int BasicTypeIdListFieldNumber = 10;
    private static readonly pb::FieldCodec<uint> _repeated_basicTypeIdList_codec
        = pb::FieldCodec.ForUInt32(82);
    private readonly pbc::RepeatedField<uint> basicTypeIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> BasicTypeIdList {
      get { return basicTypeIdList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as UnlockAvatarPathScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(UnlockAvatarPathScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AvatarId != other.AvatarId) return false;
      if (Retcode != other.Retcode) return false;
      if (!object.Equals(Reward, other.Reward)) return false;
      if(!basicTypeIdList_.Equals(other.basicTypeIdList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (AvatarId != global::EggLink.DanhengServer.Proto.MultiPathAvatarType.None) hash ^= AvatarId.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (reward_ != null) hash ^= Reward.GetHashCode();
      hash ^= basicTypeIdList_.GetHashCode();
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
      if (reward_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Reward);
      }
      basicTypeIdList_.WriteTo(output, _repeated_basicTypeIdList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Retcode);
      }
      if (AvatarId != global::EggLink.DanhengServer.Proto.MultiPathAvatarType.None) {
        output.WriteRawTag(120);
        output.WriteEnum((int) AvatarId);
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
      if (reward_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Reward);
      }
      basicTypeIdList_.WriteTo(ref output, _repeated_basicTypeIdList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Retcode);
      }
      if (AvatarId != global::EggLink.DanhengServer.Proto.MultiPathAvatarType.None) {
        output.WriteRawTag(120);
        output.WriteEnum((int) AvatarId);
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
      if (AvatarId != global::EggLink.DanhengServer.Proto.MultiPathAvatarType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) AvatarId);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (reward_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Reward);
      }
      size += basicTypeIdList_.CalculateSize(_repeated_basicTypeIdList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(UnlockAvatarPathScRsp other) {
      if (other == null) {
        return;
      }
      if (other.AvatarId != global::EggLink.DanhengServer.Proto.MultiPathAvatarType.None) {
        AvatarId = other.AvatarId;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.reward_ != null) {
        if (reward_ == null) {
          Reward = new global::EggLink.DanhengServer.Proto.ItemList();
        }
        Reward.MergeFrom(other.Reward);
      }
      basicTypeIdList_.Add(other.basicTypeIdList_);
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
          case 34: {
            if (reward_ == null) {
              Reward = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(Reward);
            break;
          }
          case 82:
          case 80: {
            basicTypeIdList_.AddEntriesFrom(input, _repeated_basicTypeIdList_codec);
            break;
          }
          case 104: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 120: {
            AvatarId = (global::EggLink.DanhengServer.Proto.MultiPathAvatarType) input.ReadEnum();
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
          case 34: {
            if (reward_ == null) {
              Reward = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(Reward);
            break;
          }
          case 82:
          case 80: {
            basicTypeIdList_.AddEntriesFrom(ref input, _repeated_basicTypeIdList_codec);
            break;
          }
          case 104: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 120: {
            AvatarId = (global::EggLink.DanhengServer.Proto.MultiPathAvatarType) input.ReadEnum();
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