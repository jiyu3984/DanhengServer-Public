// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CMIEPHPMBMI.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from CMIEPHPMBMI.proto</summary>
  public static partial class CMIEPHPMBMIReflection {

    #region Descriptor
    /// <summary>File descriptor for CMIEPHPMBMI.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CMIEPHPMBMIReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFDTUlFUEhQTUJNSS5wcm90bxoWUm9ndWVCb290aFN0YXR1cy5wcm90byJa",
            "CgtDTUlFUEhQTUJNSRITCgtFREhDTkRNRExHRRgIIAEoDRIhCgZzdGF0dXMY",
            "DiABKA4yES5Sb2d1ZUJvb3RoU3RhdHVzEhMKC1BNRFBCR0VOS01JGAkgASgN",
            "Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueBoothStatusReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.CMIEPHPMBMI), global::EggLink.DanhengServer.Proto.CMIEPHPMBMI.Parser, new[]{ "EDHCNDMDLGE", "Status", "PMDPBGENKMI" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class CMIEPHPMBMI : pb::IMessage<CMIEPHPMBMI>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CMIEPHPMBMI> _parser = new pb::MessageParser<CMIEPHPMBMI>(() => new CMIEPHPMBMI());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CMIEPHPMBMI> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.CMIEPHPMBMIReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CMIEPHPMBMI() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CMIEPHPMBMI(CMIEPHPMBMI other) : this() {
      eDHCNDMDLGE_ = other.eDHCNDMDLGE_;
      status_ = other.status_;
      pMDPBGENKMI_ = other.pMDPBGENKMI_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CMIEPHPMBMI Clone() {
      return new CMIEPHPMBMI(this);
    }

    /// <summary>Field number for the "EDHCNDMDLGE" field.</summary>
    public const int EDHCNDMDLGEFieldNumber = 8;
    private uint eDHCNDMDLGE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EDHCNDMDLGE {
      get { return eDHCNDMDLGE_; }
      set {
        eDHCNDMDLGE_ = value;
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 14;
    private global::EggLink.DanhengServer.Proto.RogueBoothStatus status_ = global::EggLink.DanhengServer.Proto.RogueBoothStatus.RogueBoothNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueBoothStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "PMDPBGENKMI" field.</summary>
    public const int PMDPBGENKMIFieldNumber = 9;
    private uint pMDPBGENKMI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PMDPBGENKMI {
      get { return pMDPBGENKMI_; }
      set {
        pMDPBGENKMI_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CMIEPHPMBMI);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CMIEPHPMBMI other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EDHCNDMDLGE != other.EDHCNDMDLGE) return false;
      if (Status != other.Status) return false;
      if (PMDPBGENKMI != other.PMDPBGENKMI) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EDHCNDMDLGE != 0) hash ^= EDHCNDMDLGE.GetHashCode();
      if (Status != global::EggLink.DanhengServer.Proto.RogueBoothStatus.RogueBoothNone) hash ^= Status.GetHashCode();
      if (PMDPBGENKMI != 0) hash ^= PMDPBGENKMI.GetHashCode();
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
      if (EDHCNDMDLGE != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(EDHCNDMDLGE);
      }
      if (PMDPBGENKMI != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(PMDPBGENKMI);
      }
      if (Status != global::EggLink.DanhengServer.Proto.RogueBoothStatus.RogueBoothNone) {
        output.WriteRawTag(112);
        output.WriteEnum((int) Status);
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
      if (EDHCNDMDLGE != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(EDHCNDMDLGE);
      }
      if (PMDPBGENKMI != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(PMDPBGENKMI);
      }
      if (Status != global::EggLink.DanhengServer.Proto.RogueBoothStatus.RogueBoothNone) {
        output.WriteRawTag(112);
        output.WriteEnum((int) Status);
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
      if (EDHCNDMDLGE != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EDHCNDMDLGE);
      }
      if (Status != global::EggLink.DanhengServer.Proto.RogueBoothStatus.RogueBoothNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (PMDPBGENKMI != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PMDPBGENKMI);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CMIEPHPMBMI other) {
      if (other == null) {
        return;
      }
      if (other.EDHCNDMDLGE != 0) {
        EDHCNDMDLGE = other.EDHCNDMDLGE;
      }
      if (other.Status != global::EggLink.DanhengServer.Proto.RogueBoothStatus.RogueBoothNone) {
        Status = other.Status;
      }
      if (other.PMDPBGENKMI != 0) {
        PMDPBGENKMI = other.PMDPBGENKMI;
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
          case 64: {
            EDHCNDMDLGE = input.ReadUInt32();
            break;
          }
          case 72: {
            PMDPBGENKMI = input.ReadUInt32();
            break;
          }
          case 112: {
            Status = (global::EggLink.DanhengServer.Proto.RogueBoothStatus) input.ReadEnum();
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
          case 64: {
            EDHCNDMDLGE = input.ReadUInt32();
            break;
          }
          case 72: {
            PMDPBGENKMI = input.ReadUInt32();
            break;
          }
          case 112: {
            Status = (global::EggLink.DanhengServer.Proto.RogueBoothStatus) input.ReadEnum();
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