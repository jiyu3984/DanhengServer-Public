// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BDHMAEOPIHI.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from BDHMAEOPIHI.proto</summary>
  public static partial class BDHMAEOPIHIReflection {

    #region Descriptor
    /// <summary>File descriptor for BDHMAEOPIHI.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BDHMAEOPIHIReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFCREhNQUVPUElISS5wcm90byJHCgtCREhNQUVPUElISRISCgp2aXNpdG9y",
            "X2lkGAQgASgNEg8KB2lzX21lZXQYDCABKAgSEwoLRk9DQUxBT0dBR0oYBiAB",
            "KA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.BDHMAEOPIHI), global::EggLink.DanhengServer.Proto.BDHMAEOPIHI.Parser, new[]{ "VisitorId", "IsMeet", "FOCALAOGAGJ" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class BDHMAEOPIHI : pb::IMessage<BDHMAEOPIHI>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BDHMAEOPIHI> _parser = new pb::MessageParser<BDHMAEOPIHI>(() => new BDHMAEOPIHI());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BDHMAEOPIHI> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.BDHMAEOPIHIReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BDHMAEOPIHI() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BDHMAEOPIHI(BDHMAEOPIHI other) : this() {
      visitorId_ = other.visitorId_;
      isMeet_ = other.isMeet_;
      fOCALAOGAGJ_ = other.fOCALAOGAGJ_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BDHMAEOPIHI Clone() {
      return new BDHMAEOPIHI(this);
    }

    /// <summary>Field number for the "visitor_id" field.</summary>
    public const int VisitorIdFieldNumber = 4;
    private uint visitorId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint VisitorId {
      get { return visitorId_; }
      set {
        visitorId_ = value;
      }
    }

    /// <summary>Field number for the "is_meet" field.</summary>
    public const int IsMeetFieldNumber = 12;
    private bool isMeet_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsMeet {
      get { return isMeet_; }
      set {
        isMeet_ = value;
      }
    }

    /// <summary>Field number for the "FOCALAOGAGJ" field.</summary>
    public const int FOCALAOGAGJFieldNumber = 6;
    private uint fOCALAOGAGJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FOCALAOGAGJ {
      get { return fOCALAOGAGJ_; }
      set {
        fOCALAOGAGJ_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BDHMAEOPIHI);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BDHMAEOPIHI other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (VisitorId != other.VisitorId) return false;
      if (IsMeet != other.IsMeet) return false;
      if (FOCALAOGAGJ != other.FOCALAOGAGJ) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (VisitorId != 0) hash ^= VisitorId.GetHashCode();
      if (IsMeet != false) hash ^= IsMeet.GetHashCode();
      if (FOCALAOGAGJ != 0) hash ^= FOCALAOGAGJ.GetHashCode();
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
      if (VisitorId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(VisitorId);
      }
      if (FOCALAOGAGJ != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(FOCALAOGAGJ);
      }
      if (IsMeet != false) {
        output.WriteRawTag(96);
        output.WriteBool(IsMeet);
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
      if (VisitorId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(VisitorId);
      }
      if (FOCALAOGAGJ != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(FOCALAOGAGJ);
      }
      if (IsMeet != false) {
        output.WriteRawTag(96);
        output.WriteBool(IsMeet);
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
      if (VisitorId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(VisitorId);
      }
      if (IsMeet != false) {
        size += 1 + 1;
      }
      if (FOCALAOGAGJ != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FOCALAOGAGJ);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BDHMAEOPIHI other) {
      if (other == null) {
        return;
      }
      if (other.VisitorId != 0) {
        VisitorId = other.VisitorId;
      }
      if (other.IsMeet != false) {
        IsMeet = other.IsMeet;
      }
      if (other.FOCALAOGAGJ != 0) {
        FOCALAOGAGJ = other.FOCALAOGAGJ;
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
            VisitorId = input.ReadUInt32();
            break;
          }
          case 48: {
            FOCALAOGAGJ = input.ReadUInt32();
            break;
          }
          case 96: {
            IsMeet = input.ReadBool();
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
            VisitorId = input.ReadUInt32();
            break;
          }
          case 48: {
            FOCALAOGAGJ = input.ReadUInt32();
            break;
          }
          case 96: {
            IsMeet = input.ReadBool();
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