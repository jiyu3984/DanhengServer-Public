// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EAGFKGAICCA.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from EAGFKGAICCA.proto</summary>
  public static partial class EAGFKGAICCAReflection {

    #region Descriptor
    /// <summary>File descriptor for EAGFKGAICCA.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EAGFKGAICCAReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFFQUdGS0dBSUNDQS5wcm90byJhCgtFQUdGS0dBSUNDQRITCgtEUFBJTE9M",
            "SUZPTRgHIAEoDRITCgtFTElFTEdERERITxgFIAEoDRITCgtMRE5CRVBQSkpL",
            "ThgIIAEoCBITCgtNSEdMSkZMQ0VFThgOIAEoDUIeqgIbRWdnTGluay5EYW5o",
            "ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.EAGFKGAICCA), global::EggLink.DanhengServer.Proto.EAGFKGAICCA.Parser, new[]{ "DPPILOLIFOM", "ELIELGDDDHO", "LDNBEPPJJKN", "MHGLJFLCEEN" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class EAGFKGAICCA : pb::IMessage<EAGFKGAICCA>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EAGFKGAICCA> _parser = new pb::MessageParser<EAGFKGAICCA>(() => new EAGFKGAICCA());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EAGFKGAICCA> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.EAGFKGAICCAReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EAGFKGAICCA() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EAGFKGAICCA(EAGFKGAICCA other) : this() {
      dPPILOLIFOM_ = other.dPPILOLIFOM_;
      eLIELGDDDHO_ = other.eLIELGDDDHO_;
      lDNBEPPJJKN_ = other.lDNBEPPJJKN_;
      mHGLJFLCEEN_ = other.mHGLJFLCEEN_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EAGFKGAICCA Clone() {
      return new EAGFKGAICCA(this);
    }

    /// <summary>Field number for the "DPPILOLIFOM" field.</summary>
    public const int DPPILOLIFOMFieldNumber = 7;
    private uint dPPILOLIFOM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DPPILOLIFOM {
      get { return dPPILOLIFOM_; }
      set {
        dPPILOLIFOM_ = value;
      }
    }

    /// <summary>Field number for the "ELIELGDDDHO" field.</summary>
    public const int ELIELGDDDHOFieldNumber = 5;
    private uint eLIELGDDDHO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ELIELGDDDHO {
      get { return eLIELGDDDHO_; }
      set {
        eLIELGDDDHO_ = value;
      }
    }

    /// <summary>Field number for the "LDNBEPPJJKN" field.</summary>
    public const int LDNBEPPJJKNFieldNumber = 8;
    private bool lDNBEPPJJKN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool LDNBEPPJJKN {
      get { return lDNBEPPJJKN_; }
      set {
        lDNBEPPJJKN_ = value;
      }
    }

    /// <summary>Field number for the "MHGLJFLCEEN" field.</summary>
    public const int MHGLJFLCEENFieldNumber = 14;
    private uint mHGLJFLCEEN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MHGLJFLCEEN {
      get { return mHGLJFLCEEN_; }
      set {
        mHGLJFLCEEN_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EAGFKGAICCA);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EAGFKGAICCA other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DPPILOLIFOM != other.DPPILOLIFOM) return false;
      if (ELIELGDDDHO != other.ELIELGDDDHO) return false;
      if (LDNBEPPJJKN != other.LDNBEPPJJKN) return false;
      if (MHGLJFLCEEN != other.MHGLJFLCEEN) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (DPPILOLIFOM != 0) hash ^= DPPILOLIFOM.GetHashCode();
      if (ELIELGDDDHO != 0) hash ^= ELIELGDDDHO.GetHashCode();
      if (LDNBEPPJJKN != false) hash ^= LDNBEPPJJKN.GetHashCode();
      if (MHGLJFLCEEN != 0) hash ^= MHGLJFLCEEN.GetHashCode();
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
      if (ELIELGDDDHO != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(ELIELGDDDHO);
      }
      if (DPPILOLIFOM != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(DPPILOLIFOM);
      }
      if (LDNBEPPJJKN != false) {
        output.WriteRawTag(64);
        output.WriteBool(LDNBEPPJJKN);
      }
      if (MHGLJFLCEEN != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(MHGLJFLCEEN);
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
      if (ELIELGDDDHO != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(ELIELGDDDHO);
      }
      if (DPPILOLIFOM != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(DPPILOLIFOM);
      }
      if (LDNBEPPJJKN != false) {
        output.WriteRawTag(64);
        output.WriteBool(LDNBEPPJJKN);
      }
      if (MHGLJFLCEEN != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(MHGLJFLCEEN);
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
      if (DPPILOLIFOM != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DPPILOLIFOM);
      }
      if (ELIELGDDDHO != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ELIELGDDDHO);
      }
      if (LDNBEPPJJKN != false) {
        size += 1 + 1;
      }
      if (MHGLJFLCEEN != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MHGLJFLCEEN);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EAGFKGAICCA other) {
      if (other == null) {
        return;
      }
      if (other.DPPILOLIFOM != 0) {
        DPPILOLIFOM = other.DPPILOLIFOM;
      }
      if (other.ELIELGDDDHO != 0) {
        ELIELGDDDHO = other.ELIELGDDDHO;
      }
      if (other.LDNBEPPJJKN != false) {
        LDNBEPPJJKN = other.LDNBEPPJJKN;
      }
      if (other.MHGLJFLCEEN != 0) {
        MHGLJFLCEEN = other.MHGLJFLCEEN;
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
            ELIELGDDDHO = input.ReadUInt32();
            break;
          }
          case 56: {
            DPPILOLIFOM = input.ReadUInt32();
            break;
          }
          case 64: {
            LDNBEPPJJKN = input.ReadBool();
            break;
          }
          case 112: {
            MHGLJFLCEEN = input.ReadUInt32();
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
            ELIELGDDDHO = input.ReadUInt32();
            break;
          }
          case 56: {
            DPPILOLIFOM = input.ReadUInt32();
            break;
          }
          case 64: {
            LDNBEPPJJKN = input.ReadBool();
            break;
          }
          case 112: {
            MHGLJFLCEEN = input.ReadUInt32();
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
