// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AetherDivideSpiritExpUpCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from AetherDivideSpiritExpUpCsReq.proto</summary>
  public static partial class AetherDivideSpiritExpUpCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for AetherDivideSpiritExpUpCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AetherDivideSpiritExpUpCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJBZXRoZXJEaXZpZGVTcGlyaXRFeHBVcENzUmVxLnByb3RvIlsKHEFldGhl",
            "ckRpdmlkZVNwaXJpdEV4cFVwQ3NSZXESEQoJYXZhdGFyX2lkGAcgASgNEhMK",
            "C0lQSkxDRkFNTURCGA0gASgNEhMKC0dGSU1MQkVDSkxDGAUgASgNQh6qAhtF",
            "Z2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.AetherDivideSpiritExpUpCsReq), global::EggLink.DanhengServer.Proto.AetherDivideSpiritExpUpCsReq.Parser, new[]{ "AvatarId", "IPJLCFAMMDB", "GFIMLBECJLC" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class AetherDivideSpiritExpUpCsReq : pb::IMessage<AetherDivideSpiritExpUpCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AetherDivideSpiritExpUpCsReq> _parser = new pb::MessageParser<AetherDivideSpiritExpUpCsReq>(() => new AetherDivideSpiritExpUpCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AetherDivideSpiritExpUpCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.AetherDivideSpiritExpUpCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AetherDivideSpiritExpUpCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AetherDivideSpiritExpUpCsReq(AetherDivideSpiritExpUpCsReq other) : this() {
      avatarId_ = other.avatarId_;
      iPJLCFAMMDB_ = other.iPJLCFAMMDB_;
      gFIMLBECJLC_ = other.gFIMLBECJLC_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AetherDivideSpiritExpUpCsReq Clone() {
      return new AetherDivideSpiritExpUpCsReq(this);
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

    /// <summary>Field number for the "IPJLCFAMMDB" field.</summary>
    public const int IPJLCFAMMDBFieldNumber = 13;
    private uint iPJLCFAMMDB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint IPJLCFAMMDB {
      get { return iPJLCFAMMDB_; }
      set {
        iPJLCFAMMDB_ = value;
      }
    }

    /// <summary>Field number for the "GFIMLBECJLC" field.</summary>
    public const int GFIMLBECJLCFieldNumber = 5;
    private uint gFIMLBECJLC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GFIMLBECJLC {
      get { return gFIMLBECJLC_; }
      set {
        gFIMLBECJLC_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AetherDivideSpiritExpUpCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AetherDivideSpiritExpUpCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AvatarId != other.AvatarId) return false;
      if (IPJLCFAMMDB != other.IPJLCFAMMDB) return false;
      if (GFIMLBECJLC != other.GFIMLBECJLC) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (AvatarId != 0) hash ^= AvatarId.GetHashCode();
      if (IPJLCFAMMDB != 0) hash ^= IPJLCFAMMDB.GetHashCode();
      if (GFIMLBECJLC != 0) hash ^= GFIMLBECJLC.GetHashCode();
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
      if (GFIMLBECJLC != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(GFIMLBECJLC);
      }
      if (AvatarId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(AvatarId);
      }
      if (IPJLCFAMMDB != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(IPJLCFAMMDB);
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
      if (GFIMLBECJLC != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(GFIMLBECJLC);
      }
      if (AvatarId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(AvatarId);
      }
      if (IPJLCFAMMDB != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(IPJLCFAMMDB);
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
      if (AvatarId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AvatarId);
      }
      if (IPJLCFAMMDB != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(IPJLCFAMMDB);
      }
      if (GFIMLBECJLC != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GFIMLBECJLC);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AetherDivideSpiritExpUpCsReq other) {
      if (other == null) {
        return;
      }
      if (other.AvatarId != 0) {
        AvatarId = other.AvatarId;
      }
      if (other.IPJLCFAMMDB != 0) {
        IPJLCFAMMDB = other.IPJLCFAMMDB;
      }
      if (other.GFIMLBECJLC != 0) {
        GFIMLBECJLC = other.GFIMLBECJLC;
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
          case 40: {
            GFIMLBECJLC = input.ReadUInt32();
            break;
          }
          case 56: {
            AvatarId = input.ReadUInt32();
            break;
          }
          case 104: {
            IPJLCFAMMDB = input.ReadUInt32();
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
          case 40: {
            GFIMLBECJLC = input.ReadUInt32();
            break;
          }
          case 56: {
            AvatarId = input.ReadUInt32();
            break;
          }
          case 104: {
            IPJLCFAMMDB = input.ReadUInt32();
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