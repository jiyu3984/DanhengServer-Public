// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GILDNBDKOLD.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GILDNBDKOLD.proto</summary>
  public static partial class GILDNBDKOLDReflection {

    #region Descriptor
    /// <summary>File descriptor for GILDNBDKOLD.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GILDNBDKOLDReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFHSUxETkJES09MRC5wcm90byI3CgtHSUxETkJES09MRBITCgtIRkNNS09P",
            "T0pBSRgLIAEoDRITCgtMRE5CRVBQSkpLThgFIAEoCEIeqgIbRWdnTGluay5E",
            "YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GILDNBDKOLD), global::EggLink.DanhengServer.Proto.GILDNBDKOLD.Parser, new[]{ "HFCMKOOOJAI", "LDNBEPPJJKN" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GILDNBDKOLD : pb::IMessage<GILDNBDKOLD>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GILDNBDKOLD> _parser = new pb::MessageParser<GILDNBDKOLD>(() => new GILDNBDKOLD());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GILDNBDKOLD> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GILDNBDKOLDReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GILDNBDKOLD() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GILDNBDKOLD(GILDNBDKOLD other) : this() {
      hFCMKOOOJAI_ = other.hFCMKOOOJAI_;
      lDNBEPPJJKN_ = other.lDNBEPPJJKN_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GILDNBDKOLD Clone() {
      return new GILDNBDKOLD(this);
    }

    /// <summary>Field number for the "HFCMKOOOJAI" field.</summary>
    public const int HFCMKOOOJAIFieldNumber = 11;
    private uint hFCMKOOOJAI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HFCMKOOOJAI {
      get { return hFCMKOOOJAI_; }
      set {
        hFCMKOOOJAI_ = value;
      }
    }

    /// <summary>Field number for the "LDNBEPPJJKN" field.</summary>
    public const int LDNBEPPJJKNFieldNumber = 5;
    private bool lDNBEPPJJKN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool LDNBEPPJJKN {
      get { return lDNBEPPJJKN_; }
      set {
        lDNBEPPJJKN_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GILDNBDKOLD);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GILDNBDKOLD other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (HFCMKOOOJAI != other.HFCMKOOOJAI) return false;
      if (LDNBEPPJJKN != other.LDNBEPPJJKN) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HFCMKOOOJAI != 0) hash ^= HFCMKOOOJAI.GetHashCode();
      if (LDNBEPPJJKN != false) hash ^= LDNBEPPJJKN.GetHashCode();
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
      if (LDNBEPPJJKN != false) {
        output.WriteRawTag(40);
        output.WriteBool(LDNBEPPJJKN);
      }
      if (HFCMKOOOJAI != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(HFCMKOOOJAI);
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
      if (LDNBEPPJJKN != false) {
        output.WriteRawTag(40);
        output.WriteBool(LDNBEPPJJKN);
      }
      if (HFCMKOOOJAI != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(HFCMKOOOJAI);
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
      if (HFCMKOOOJAI != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HFCMKOOOJAI);
      }
      if (LDNBEPPJJKN != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GILDNBDKOLD other) {
      if (other == null) {
        return;
      }
      if (other.HFCMKOOOJAI != 0) {
        HFCMKOOOJAI = other.HFCMKOOOJAI;
      }
      if (other.LDNBEPPJJKN != false) {
        LDNBEPPJJKN = other.LDNBEPPJJKN;
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
            LDNBEPPJJKN = input.ReadBool();
            break;
          }
          case 88: {
            HFCMKOOOJAI = input.ReadUInt32();
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
            LDNBEPPJJKN = input.ReadBool();
            break;
          }
          case 88: {
            HFCMKOOOJAI = input.ReadUInt32();
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