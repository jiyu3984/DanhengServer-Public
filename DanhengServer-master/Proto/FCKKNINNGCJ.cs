// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FCKKNINNGCJ.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from FCKKNINNGCJ.proto</summary>
  public static partial class FCKKNINNGCJReflection {

    #region Descriptor
    /// <summary>File descriptor for FCKKNINNGCJ.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FCKKNINNGCJReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFGQ0tLTklOTkdDSi5wcm90byI3CgtGQ0tLTklOTkdDShITCgtPRE1LS1BC",
            "TU1DSRgMIAEoDRITCgtHQ09NRU9HQ0tFThgNIAEoDUIeqgIbRWdnTGluay5E",
            "YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.FCKKNINNGCJ), global::EggLink.DanhengServer.Proto.FCKKNINNGCJ.Parser, new[]{ "ODMKKPBMMCI", "GCOMEOGCKEN" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class FCKKNINNGCJ : pb::IMessage<FCKKNINNGCJ>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FCKKNINNGCJ> _parser = new pb::MessageParser<FCKKNINNGCJ>(() => new FCKKNINNGCJ());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FCKKNINNGCJ> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.FCKKNINNGCJReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FCKKNINNGCJ() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FCKKNINNGCJ(FCKKNINNGCJ other) : this() {
      oDMKKPBMMCI_ = other.oDMKKPBMMCI_;
      gCOMEOGCKEN_ = other.gCOMEOGCKEN_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FCKKNINNGCJ Clone() {
      return new FCKKNINNGCJ(this);
    }

    /// <summary>Field number for the "ODMKKPBMMCI" field.</summary>
    public const int ODMKKPBMMCIFieldNumber = 12;
    private uint oDMKKPBMMCI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ODMKKPBMMCI {
      get { return oDMKKPBMMCI_; }
      set {
        oDMKKPBMMCI_ = value;
      }
    }

    /// <summary>Field number for the "GCOMEOGCKEN" field.</summary>
    public const int GCOMEOGCKENFieldNumber = 13;
    private uint gCOMEOGCKEN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GCOMEOGCKEN {
      get { return gCOMEOGCKEN_; }
      set {
        gCOMEOGCKEN_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FCKKNINNGCJ);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FCKKNINNGCJ other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ODMKKPBMMCI != other.ODMKKPBMMCI) return false;
      if (GCOMEOGCKEN != other.GCOMEOGCKEN) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ODMKKPBMMCI != 0) hash ^= ODMKKPBMMCI.GetHashCode();
      if (GCOMEOGCKEN != 0) hash ^= GCOMEOGCKEN.GetHashCode();
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
      if (ODMKKPBMMCI != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(ODMKKPBMMCI);
      }
      if (GCOMEOGCKEN != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(GCOMEOGCKEN);
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
      if (ODMKKPBMMCI != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(ODMKKPBMMCI);
      }
      if (GCOMEOGCKEN != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(GCOMEOGCKEN);
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
      if (ODMKKPBMMCI != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ODMKKPBMMCI);
      }
      if (GCOMEOGCKEN != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GCOMEOGCKEN);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FCKKNINNGCJ other) {
      if (other == null) {
        return;
      }
      if (other.ODMKKPBMMCI != 0) {
        ODMKKPBMMCI = other.ODMKKPBMMCI;
      }
      if (other.GCOMEOGCKEN != 0) {
        GCOMEOGCKEN = other.GCOMEOGCKEN;
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
          case 96: {
            ODMKKPBMMCI = input.ReadUInt32();
            break;
          }
          case 104: {
            GCOMEOGCKEN = input.ReadUInt32();
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
          case 96: {
            ODMKKPBMMCI = input.ReadUInt32();
            break;
          }
          case 104: {
            GCOMEOGCKEN = input.ReadUInt32();
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