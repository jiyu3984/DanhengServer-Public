// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BFGAMHDHELB.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from BFGAMHDHELB.proto</summary>
  public static partial class BFGAMHDHELBReflection {

    #region Descriptor
    /// <summary>File descriptor for BFGAMHDHELB.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BFGAMHDHELBReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFCRkdBTUhESEVMQi5wcm90byI3CgtCRkdBTUhESEVMQhITCgtKS1BCRE1E",
            "RExNTBgOIAEoDRITCgtQQ01NREpKT0JJThgHIAEoDUIeqgIbRWdnTGluay5E",
            "YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.BFGAMHDHELB), global::EggLink.DanhengServer.Proto.BFGAMHDHELB.Parser, new[]{ "JKPBDMDDLML", "PCMMDJJOBIN" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class BFGAMHDHELB : pb::IMessage<BFGAMHDHELB>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BFGAMHDHELB> _parser = new pb::MessageParser<BFGAMHDHELB>(() => new BFGAMHDHELB());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BFGAMHDHELB> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.BFGAMHDHELBReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BFGAMHDHELB() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BFGAMHDHELB(BFGAMHDHELB other) : this() {
      jKPBDMDDLML_ = other.jKPBDMDDLML_;
      pCMMDJJOBIN_ = other.pCMMDJJOBIN_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BFGAMHDHELB Clone() {
      return new BFGAMHDHELB(this);
    }

    /// <summary>Field number for the "JKPBDMDDLML" field.</summary>
    public const int JKPBDMDDLMLFieldNumber = 14;
    private uint jKPBDMDDLML_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint JKPBDMDDLML {
      get { return jKPBDMDDLML_; }
      set {
        jKPBDMDDLML_ = value;
      }
    }

    /// <summary>Field number for the "PCMMDJJOBIN" field.</summary>
    public const int PCMMDJJOBINFieldNumber = 7;
    private uint pCMMDJJOBIN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PCMMDJJOBIN {
      get { return pCMMDJJOBIN_; }
      set {
        pCMMDJJOBIN_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BFGAMHDHELB);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BFGAMHDHELB other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (JKPBDMDDLML != other.JKPBDMDDLML) return false;
      if (PCMMDJJOBIN != other.PCMMDJJOBIN) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (JKPBDMDDLML != 0) hash ^= JKPBDMDDLML.GetHashCode();
      if (PCMMDJJOBIN != 0) hash ^= PCMMDJJOBIN.GetHashCode();
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
      if (PCMMDJJOBIN != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(PCMMDJJOBIN);
      }
      if (JKPBDMDDLML != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(JKPBDMDDLML);
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
      if (PCMMDJJOBIN != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(PCMMDJJOBIN);
      }
      if (JKPBDMDDLML != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(JKPBDMDDLML);
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
      if (JKPBDMDDLML != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(JKPBDMDDLML);
      }
      if (PCMMDJJOBIN != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PCMMDJJOBIN);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BFGAMHDHELB other) {
      if (other == null) {
        return;
      }
      if (other.JKPBDMDDLML != 0) {
        JKPBDMDDLML = other.JKPBDMDDLML;
      }
      if (other.PCMMDJJOBIN != 0) {
        PCMMDJJOBIN = other.PCMMDJJOBIN;
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
          case 56: {
            PCMMDJJOBIN = input.ReadUInt32();
            break;
          }
          case 112: {
            JKPBDMDDLML = input.ReadUInt32();
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
          case 56: {
            PCMMDJJOBIN = input.ReadUInt32();
            break;
          }
          case 112: {
            JKPBDMDDLML = input.ReadUInt32();
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
