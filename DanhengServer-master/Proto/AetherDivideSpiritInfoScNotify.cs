// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AetherDivideSpiritInfoScNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from AetherDivideSpiritInfoScNotify.proto</summary>
  public static partial class AetherDivideSpiritInfoScNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for AetherDivideSpiritInfoScNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AetherDivideSpiritInfoScNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRBZXRoZXJEaXZpZGVTcGlyaXRJbmZvU2NOb3RpZnkucHJvdG8aHEFldGhl",
            "ckRpdmlkZVNwaXJpdEluZm8ucHJvdG8ikQEKHkFldGhlckRpdmlkZVNwaXJp",
            "dEluZm9TY05vdGlmeRITCgtHRklNTEJFQ0pMQxgOIAEoDRIsCgthdmF0YXJf",
            "aW5mbxgFIAEoCzIXLkFldGhlckRpdmlkZVNwaXJpdEluZm8SLAoLUE5OTU9I",
            "RktJQk4YByADKAsyFy5BZXRoZXJEaXZpZGVTcGlyaXRJbmZvQh6qAhtFZ2dM",
            "aW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.AetherDivideSpiritInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.AetherDivideSpiritInfoScNotify), global::EggLink.DanhengServer.Proto.AetherDivideSpiritInfoScNotify.Parser, new[]{ "GFIMLBECJLC", "AvatarInfo", "PNNMOHFKIBN" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class AetherDivideSpiritInfoScNotify : pb::IMessage<AetherDivideSpiritInfoScNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AetherDivideSpiritInfoScNotify> _parser = new pb::MessageParser<AetherDivideSpiritInfoScNotify>(() => new AetherDivideSpiritInfoScNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AetherDivideSpiritInfoScNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.AetherDivideSpiritInfoScNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AetherDivideSpiritInfoScNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AetherDivideSpiritInfoScNotify(AetherDivideSpiritInfoScNotify other) : this() {
      gFIMLBECJLC_ = other.gFIMLBECJLC_;
      avatarInfo_ = other.avatarInfo_ != null ? other.avatarInfo_.Clone() : null;
      pNNMOHFKIBN_ = other.pNNMOHFKIBN_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AetherDivideSpiritInfoScNotify Clone() {
      return new AetherDivideSpiritInfoScNotify(this);
    }

    /// <summary>Field number for the "GFIMLBECJLC" field.</summary>
    public const int GFIMLBECJLCFieldNumber = 14;
    private uint gFIMLBECJLC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GFIMLBECJLC {
      get { return gFIMLBECJLC_; }
      set {
        gFIMLBECJLC_ = value;
      }
    }

    /// <summary>Field number for the "avatar_info" field.</summary>
    public const int AvatarInfoFieldNumber = 5;
    private global::EggLink.DanhengServer.Proto.AetherDivideSpiritInfo avatarInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.AetherDivideSpiritInfo AvatarInfo {
      get { return avatarInfo_; }
      set {
        avatarInfo_ = value;
      }
    }

    /// <summary>Field number for the "PNNMOHFKIBN" field.</summary>
    public const int PNNMOHFKIBNFieldNumber = 7;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.AetherDivideSpiritInfo> _repeated_pNNMOHFKIBN_codec
        = pb::FieldCodec.ForMessage(58, global::EggLink.DanhengServer.Proto.AetherDivideSpiritInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AetherDivideSpiritInfo> pNNMOHFKIBN_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AetherDivideSpiritInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AetherDivideSpiritInfo> PNNMOHFKIBN {
      get { return pNNMOHFKIBN_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AetherDivideSpiritInfoScNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AetherDivideSpiritInfoScNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GFIMLBECJLC != other.GFIMLBECJLC) return false;
      if (!object.Equals(AvatarInfo, other.AvatarInfo)) return false;
      if(!pNNMOHFKIBN_.Equals(other.pNNMOHFKIBN_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (GFIMLBECJLC != 0) hash ^= GFIMLBECJLC.GetHashCode();
      if (avatarInfo_ != null) hash ^= AvatarInfo.GetHashCode();
      hash ^= pNNMOHFKIBN_.GetHashCode();
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
      if (avatarInfo_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(AvatarInfo);
      }
      pNNMOHFKIBN_.WriteTo(output, _repeated_pNNMOHFKIBN_codec);
      if (GFIMLBECJLC != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(GFIMLBECJLC);
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
      if (avatarInfo_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(AvatarInfo);
      }
      pNNMOHFKIBN_.WriteTo(ref output, _repeated_pNNMOHFKIBN_codec);
      if (GFIMLBECJLC != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(GFIMLBECJLC);
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
      if (GFIMLBECJLC != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GFIMLBECJLC);
      }
      if (avatarInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AvatarInfo);
      }
      size += pNNMOHFKIBN_.CalculateSize(_repeated_pNNMOHFKIBN_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AetherDivideSpiritInfoScNotify other) {
      if (other == null) {
        return;
      }
      if (other.GFIMLBECJLC != 0) {
        GFIMLBECJLC = other.GFIMLBECJLC;
      }
      if (other.avatarInfo_ != null) {
        if (avatarInfo_ == null) {
          AvatarInfo = new global::EggLink.DanhengServer.Proto.AetherDivideSpiritInfo();
        }
        AvatarInfo.MergeFrom(other.AvatarInfo);
      }
      pNNMOHFKIBN_.Add(other.pNNMOHFKIBN_);
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
          case 42: {
            if (avatarInfo_ == null) {
              AvatarInfo = new global::EggLink.DanhengServer.Proto.AetherDivideSpiritInfo();
            }
            input.ReadMessage(AvatarInfo);
            break;
          }
          case 58: {
            pNNMOHFKIBN_.AddEntriesFrom(input, _repeated_pNNMOHFKIBN_codec);
            break;
          }
          case 112: {
            GFIMLBECJLC = input.ReadUInt32();
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
          case 42: {
            if (avatarInfo_ == null) {
              AvatarInfo = new global::EggLink.DanhengServer.Proto.AetherDivideSpiritInfo();
            }
            input.ReadMessage(AvatarInfo);
            break;
          }
          case 58: {
            pNNMOHFKIBN_.AddEntriesFrom(ref input, _repeated_pNNMOHFKIBN_codec);
            break;
          }
          case 112: {
            GFIMLBECJLC = input.ReadUInt32();
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
