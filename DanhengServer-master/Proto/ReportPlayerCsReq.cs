// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ReportPlayerCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ReportPlayerCsReq.proto</summary>
  public static partial class ReportPlayerCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for ReportPlayerCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ReportPlayerCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdSZXBvcnRQbGF5ZXJDc1JlcS5wcm90byJKChFSZXBvcnRQbGF5ZXJDc1Jl",
            "cRILCgN1aWQYCCABKA0SEwoLTktEQUVGQktIQkkYBCABKA0SEwoLS0xFT05O",
            "RkdCUE0YDyABKAlCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ReportPlayerCsReq), global::EggLink.DanhengServer.Proto.ReportPlayerCsReq.Parser, new[]{ "Uid", "NKDAEFBKHBI", "KLEONNFGBPM" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ReportPlayerCsReq : pb::IMessage<ReportPlayerCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ReportPlayerCsReq> _parser = new pb::MessageParser<ReportPlayerCsReq>(() => new ReportPlayerCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ReportPlayerCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ReportPlayerCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ReportPlayerCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ReportPlayerCsReq(ReportPlayerCsReq other) : this() {
      uid_ = other.uid_;
      nKDAEFBKHBI_ = other.nKDAEFBKHBI_;
      kLEONNFGBPM_ = other.kLEONNFGBPM_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ReportPlayerCsReq Clone() {
      return new ReportPlayerCsReq(this);
    }

    /// <summary>Field number for the "uid" field.</summary>
    public const int UidFieldNumber = 8;
    private uint uid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Uid {
      get { return uid_; }
      set {
        uid_ = value;
      }
    }

    /// <summary>Field number for the "NKDAEFBKHBI" field.</summary>
    public const int NKDAEFBKHBIFieldNumber = 4;
    private uint nKDAEFBKHBI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NKDAEFBKHBI {
      get { return nKDAEFBKHBI_; }
      set {
        nKDAEFBKHBI_ = value;
      }
    }

    /// <summary>Field number for the "KLEONNFGBPM" field.</summary>
    public const int KLEONNFGBPMFieldNumber = 15;
    private string kLEONNFGBPM_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string KLEONNFGBPM {
      get { return kLEONNFGBPM_; }
      set {
        kLEONNFGBPM_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ReportPlayerCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ReportPlayerCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Uid != other.Uid) return false;
      if (NKDAEFBKHBI != other.NKDAEFBKHBI) return false;
      if (KLEONNFGBPM != other.KLEONNFGBPM) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Uid != 0) hash ^= Uid.GetHashCode();
      if (NKDAEFBKHBI != 0) hash ^= NKDAEFBKHBI.GetHashCode();
      if (KLEONNFGBPM.Length != 0) hash ^= KLEONNFGBPM.GetHashCode();
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
      if (NKDAEFBKHBI != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(NKDAEFBKHBI);
      }
      if (Uid != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Uid);
      }
      if (KLEONNFGBPM.Length != 0) {
        output.WriteRawTag(122);
        output.WriteString(KLEONNFGBPM);
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
      if (NKDAEFBKHBI != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(NKDAEFBKHBI);
      }
      if (Uid != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Uid);
      }
      if (KLEONNFGBPM.Length != 0) {
        output.WriteRawTag(122);
        output.WriteString(KLEONNFGBPM);
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
      if (Uid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Uid);
      }
      if (NKDAEFBKHBI != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NKDAEFBKHBI);
      }
      if (KLEONNFGBPM.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(KLEONNFGBPM);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ReportPlayerCsReq other) {
      if (other == null) {
        return;
      }
      if (other.Uid != 0) {
        Uid = other.Uid;
      }
      if (other.NKDAEFBKHBI != 0) {
        NKDAEFBKHBI = other.NKDAEFBKHBI;
      }
      if (other.KLEONNFGBPM.Length != 0) {
        KLEONNFGBPM = other.KLEONNFGBPM;
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
          case 32: {
            NKDAEFBKHBI = input.ReadUInt32();
            break;
          }
          case 64: {
            Uid = input.ReadUInt32();
            break;
          }
          case 122: {
            KLEONNFGBPM = input.ReadString();
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
          case 32: {
            NKDAEFBKHBI = input.ReadUInt32();
            break;
          }
          case 64: {
            Uid = input.ReadUInt32();
            break;
          }
          case 122: {
            KLEONNFGBPM = input.ReadString();
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