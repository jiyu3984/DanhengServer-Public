// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PGELHHCIIDP.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from PGELHHCIIDP.proto</summary>
  public static partial class PGELHHCIIDPReflection {

    #region Descriptor
    /// <summary>File descriptor for PGELHHCIIDP.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PGELHHCIIDPReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFQR0VMSEhDSUlEUC5wcm90byIyCgtQR0VMSEhDSUlEUBITCgtIT0hCTElJ",
            "REFGShgKIAEoDRIOCgZtYXBfaWQYAiABKA1CHqoCG0VnZ0xpbmsuRGFuaGVu",
            "Z1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.PGELHHCIIDP), global::EggLink.DanhengServer.Proto.PGELHHCIIDP.Parser, new[]{ "HOHBLIIDAFJ", "MapId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class PGELHHCIIDP : pb::IMessage<PGELHHCIIDP>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PGELHHCIIDP> _parser = new pb::MessageParser<PGELHHCIIDP>(() => new PGELHHCIIDP());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PGELHHCIIDP> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.PGELHHCIIDPReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PGELHHCIIDP() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PGELHHCIIDP(PGELHHCIIDP other) : this() {
      hOHBLIIDAFJ_ = other.hOHBLIIDAFJ_;
      mapId_ = other.mapId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PGELHHCIIDP Clone() {
      return new PGELHHCIIDP(this);
    }

    /// <summary>Field number for the "HOHBLIIDAFJ" field.</summary>
    public const int HOHBLIIDAFJFieldNumber = 10;
    private uint hOHBLIIDAFJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HOHBLIIDAFJ {
      get { return hOHBLIIDAFJ_; }
      set {
        hOHBLIIDAFJ_ = value;
      }
    }

    /// <summary>Field number for the "map_id" field.</summary>
    public const int MapIdFieldNumber = 2;
    private uint mapId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MapId {
      get { return mapId_; }
      set {
        mapId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PGELHHCIIDP);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PGELHHCIIDP other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (HOHBLIIDAFJ != other.HOHBLIIDAFJ) return false;
      if (MapId != other.MapId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HOHBLIIDAFJ != 0) hash ^= HOHBLIIDAFJ.GetHashCode();
      if (MapId != 0) hash ^= MapId.GetHashCode();
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
      if (MapId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(MapId);
      }
      if (HOHBLIIDAFJ != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(HOHBLIIDAFJ);
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
      if (MapId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(MapId);
      }
      if (HOHBLIIDAFJ != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(HOHBLIIDAFJ);
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
      if (HOHBLIIDAFJ != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HOHBLIIDAFJ);
      }
      if (MapId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MapId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PGELHHCIIDP other) {
      if (other == null) {
        return;
      }
      if (other.HOHBLIIDAFJ != 0) {
        HOHBLIIDAFJ = other.HOHBLIIDAFJ;
      }
      if (other.MapId != 0) {
        MapId = other.MapId;
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
          case 16: {
            MapId = input.ReadUInt32();
            break;
          }
          case 80: {
            HOHBLIIDAFJ = input.ReadUInt32();
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
          case 16: {
            MapId = input.ReadUInt32();
            break;
          }
          case 80: {
            HOHBLIIDAFJ = input.ReadUInt32();
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