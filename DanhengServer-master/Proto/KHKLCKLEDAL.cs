// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: KHKLCKLEDAL.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from KHKLCKLEDAL.proto</summary>
  public static partial class KHKLCKLEDALReflection {

    #region Descriptor
    /// <summary>File descriptor for KHKLCKLEDAL.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static KHKLCKLEDALReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFLSEtMQ0tMRURBTC5wcm90byJKCgtLSEtMQ0tMRURBTBITCgtCS0JFTkFF",
            "SUFEQhgBIAEoDRITCgtKQkFOQlBCQ0pQSRgCIAEoDRIRCgllbnRpdHlfaWQY",
            "AyABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.KHKLCKLEDAL), global::EggLink.DanhengServer.Proto.KHKLCKLEDAL.Parser, new[]{ "BKBENAEIADB", "JBANBPBCJPI", "EntityId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class KHKLCKLEDAL : pb::IMessage<KHKLCKLEDAL>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<KHKLCKLEDAL> _parser = new pb::MessageParser<KHKLCKLEDAL>(() => new KHKLCKLEDAL());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<KHKLCKLEDAL> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.KHKLCKLEDALReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KHKLCKLEDAL() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KHKLCKLEDAL(KHKLCKLEDAL other) : this() {
      bKBENAEIADB_ = other.bKBENAEIADB_;
      jBANBPBCJPI_ = other.jBANBPBCJPI_;
      entityId_ = other.entityId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KHKLCKLEDAL Clone() {
      return new KHKLCKLEDAL(this);
    }

    /// <summary>Field number for the "BKBENAEIADB" field.</summary>
    public const int BKBENAEIADBFieldNumber = 1;
    private uint bKBENAEIADB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BKBENAEIADB {
      get { return bKBENAEIADB_; }
      set {
        bKBENAEIADB_ = value;
      }
    }

    /// <summary>Field number for the "JBANBPBCJPI" field.</summary>
    public const int JBANBPBCJPIFieldNumber = 2;
    private uint jBANBPBCJPI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint JBANBPBCJPI {
      get { return jBANBPBCJPI_; }
      set {
        jBANBPBCJPI_ = value;
      }
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 3;
    private uint entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as KHKLCKLEDAL);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(KHKLCKLEDAL other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BKBENAEIADB != other.BKBENAEIADB) return false;
      if (JBANBPBCJPI != other.JBANBPBCJPI) return false;
      if (EntityId != other.EntityId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (BKBENAEIADB != 0) hash ^= BKBENAEIADB.GetHashCode();
      if (JBANBPBCJPI != 0) hash ^= JBANBPBCJPI.GetHashCode();
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
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
      if (BKBENAEIADB != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(BKBENAEIADB);
      }
      if (JBANBPBCJPI != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(JBANBPBCJPI);
      }
      if (EntityId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(EntityId);
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
      if (BKBENAEIADB != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(BKBENAEIADB);
      }
      if (JBANBPBCJPI != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(JBANBPBCJPI);
      }
      if (EntityId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(EntityId);
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
      if (BKBENAEIADB != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BKBENAEIADB);
      }
      if (JBANBPBCJPI != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(JBANBPBCJPI);
      }
      if (EntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(KHKLCKLEDAL other) {
      if (other == null) {
        return;
      }
      if (other.BKBENAEIADB != 0) {
        BKBENAEIADB = other.BKBENAEIADB;
      }
      if (other.JBANBPBCJPI != 0) {
        JBANBPBCJPI = other.JBANBPBCJPI;
      }
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
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
            BKBENAEIADB = input.ReadUInt32();
            break;
          }
          case 16: {
            JBANBPBCJPI = input.ReadUInt32();
            break;
          }
          case 24: {
            EntityId = input.ReadUInt32();
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
            BKBENAEIADB = input.ReadUInt32();
            break;
          }
          case 16: {
            JBANBPBCJPI = input.ReadUInt32();
            break;
          }
          case 24: {
            EntityId = input.ReadUInt32();
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