// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FLPFHGIMEND.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from FLPFHGIMEND.proto</summary>
  public static partial class FLPFHGIMENDReflection {

    #region Descriptor
    /// <summary>File descriptor for FLPFHGIMEND.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FLPFHGIMENDReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFGTFBGSEdJTUVORC5wcm90byJhCgtGTFBGSEdJTUVORBITCgtIRE9CSURO",
            "TkdKSxgFIAEoDRITCgtDQUVHQ0RBR01PSxgGIAEoDRITCgtHTkZPT0VPUElN",
            "QhgKIAEoDRITCgtMRE5CRVBQSkpLThgIIAEoCEIeqgIbRWdnTGluay5EYW5o",
            "ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.FLPFHGIMEND), global::EggLink.DanhengServer.Proto.FLPFHGIMEND.Parser, new[]{ "HDOBIDNNGJK", "CAEGCDAGMOK", "GNFOOEOPIMB", "LDNBEPPJJKN" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class FLPFHGIMEND : pb::IMessage<FLPFHGIMEND>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FLPFHGIMEND> _parser = new pb::MessageParser<FLPFHGIMEND>(() => new FLPFHGIMEND());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FLPFHGIMEND> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.FLPFHGIMENDReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FLPFHGIMEND() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FLPFHGIMEND(FLPFHGIMEND other) : this() {
      hDOBIDNNGJK_ = other.hDOBIDNNGJK_;
      cAEGCDAGMOK_ = other.cAEGCDAGMOK_;
      gNFOOEOPIMB_ = other.gNFOOEOPIMB_;
      lDNBEPPJJKN_ = other.lDNBEPPJJKN_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FLPFHGIMEND Clone() {
      return new FLPFHGIMEND(this);
    }

    /// <summary>Field number for the "HDOBIDNNGJK" field.</summary>
    public const int HDOBIDNNGJKFieldNumber = 5;
    private uint hDOBIDNNGJK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HDOBIDNNGJK {
      get { return hDOBIDNNGJK_; }
      set {
        hDOBIDNNGJK_ = value;
      }
    }

    /// <summary>Field number for the "CAEGCDAGMOK" field.</summary>
    public const int CAEGCDAGMOKFieldNumber = 6;
    private uint cAEGCDAGMOK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CAEGCDAGMOK {
      get { return cAEGCDAGMOK_; }
      set {
        cAEGCDAGMOK_ = value;
      }
    }

    /// <summary>Field number for the "GNFOOEOPIMB" field.</summary>
    public const int GNFOOEOPIMBFieldNumber = 10;
    private uint gNFOOEOPIMB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GNFOOEOPIMB {
      get { return gNFOOEOPIMB_; }
      set {
        gNFOOEOPIMB_ = value;
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

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FLPFHGIMEND);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FLPFHGIMEND other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (HDOBIDNNGJK != other.HDOBIDNNGJK) return false;
      if (CAEGCDAGMOK != other.CAEGCDAGMOK) return false;
      if (GNFOOEOPIMB != other.GNFOOEOPIMB) return false;
      if (LDNBEPPJJKN != other.LDNBEPPJJKN) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HDOBIDNNGJK != 0) hash ^= HDOBIDNNGJK.GetHashCode();
      if (CAEGCDAGMOK != 0) hash ^= CAEGCDAGMOK.GetHashCode();
      if (GNFOOEOPIMB != 0) hash ^= GNFOOEOPIMB.GetHashCode();
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
      if (HDOBIDNNGJK != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(HDOBIDNNGJK);
      }
      if (CAEGCDAGMOK != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(CAEGCDAGMOK);
      }
      if (LDNBEPPJJKN != false) {
        output.WriteRawTag(64);
        output.WriteBool(LDNBEPPJJKN);
      }
      if (GNFOOEOPIMB != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(GNFOOEOPIMB);
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
      if (HDOBIDNNGJK != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(HDOBIDNNGJK);
      }
      if (CAEGCDAGMOK != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(CAEGCDAGMOK);
      }
      if (LDNBEPPJJKN != false) {
        output.WriteRawTag(64);
        output.WriteBool(LDNBEPPJJKN);
      }
      if (GNFOOEOPIMB != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(GNFOOEOPIMB);
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
      if (HDOBIDNNGJK != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HDOBIDNNGJK);
      }
      if (CAEGCDAGMOK != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CAEGCDAGMOK);
      }
      if (GNFOOEOPIMB != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GNFOOEOPIMB);
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
    public void MergeFrom(FLPFHGIMEND other) {
      if (other == null) {
        return;
      }
      if (other.HDOBIDNNGJK != 0) {
        HDOBIDNNGJK = other.HDOBIDNNGJK;
      }
      if (other.CAEGCDAGMOK != 0) {
        CAEGCDAGMOK = other.CAEGCDAGMOK;
      }
      if (other.GNFOOEOPIMB != 0) {
        GNFOOEOPIMB = other.GNFOOEOPIMB;
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
            HDOBIDNNGJK = input.ReadUInt32();
            break;
          }
          case 48: {
            CAEGCDAGMOK = input.ReadUInt32();
            break;
          }
          case 64: {
            LDNBEPPJJKN = input.ReadBool();
            break;
          }
          case 80: {
            GNFOOEOPIMB = input.ReadUInt32();
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
            HDOBIDNNGJK = input.ReadUInt32();
            break;
          }
          case 48: {
            CAEGCDAGMOK = input.ReadUInt32();
            break;
          }
          case 64: {
            LDNBEPPJJKN = input.ReadBool();
            break;
          }
          case 80: {
            GNFOOEOPIMB = input.ReadUInt32();
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