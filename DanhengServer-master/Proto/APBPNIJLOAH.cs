// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: APBPNIJLOAH.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from APBPNIJLOAH.proto</summary>
  public static partial class APBPNIJLOAHReflection {

    #region Descriptor
    /// <summary>File descriptor for APBPNIJLOAH.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static APBPNIJLOAHReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFBUEJQTklKTE9BSC5wcm90byKYAQoLQVBCUE5JSkxPQUgSEwoLTU1GQkFO",
            "R0hNSEwYASABKAkSEwoLTURPTUxJS0RMSUgYAiABKAkSEwoLSkJPQ0NIQUZI",
            "TEgYAyABKAkSEwoLT0VPTUpFQ0hOQkkYBCABKAkSEwoLTUVJRUdLSkREQ0IY",
            "BSABKAkSEwoLQkhORE1NREtGRUUYBiABKAkSCwoDTUFDGAcgASgJQh6qAhtF",
            "Z2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.APBPNIJLOAH), global::EggLink.DanhengServer.Proto.APBPNIJLOAH.Parser, new[]{ "MMFBANGHMHL", "MDOMLIKDLIH", "JBOCCHAFHLH", "OEOMJECHNBI", "MEIEGKJDDCB", "BHNDMMDKFEE", "MAC" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class APBPNIJLOAH : pb::IMessage<APBPNIJLOAH>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<APBPNIJLOAH> _parser = new pb::MessageParser<APBPNIJLOAH>(() => new APBPNIJLOAH());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<APBPNIJLOAH> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.APBPNIJLOAHReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public APBPNIJLOAH() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public APBPNIJLOAH(APBPNIJLOAH other) : this() {
      mMFBANGHMHL_ = other.mMFBANGHMHL_;
      mDOMLIKDLIH_ = other.mDOMLIKDLIH_;
      jBOCCHAFHLH_ = other.jBOCCHAFHLH_;
      oEOMJECHNBI_ = other.oEOMJECHNBI_;
      mEIEGKJDDCB_ = other.mEIEGKJDDCB_;
      bHNDMMDKFEE_ = other.bHNDMMDKFEE_;
      mAC_ = other.mAC_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public APBPNIJLOAH Clone() {
      return new APBPNIJLOAH(this);
    }

    /// <summary>Field number for the "MMFBANGHMHL" field.</summary>
    public const int MMFBANGHMHLFieldNumber = 1;
    private string mMFBANGHMHL_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string MMFBANGHMHL {
      get { return mMFBANGHMHL_; }
      set {
        mMFBANGHMHL_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "MDOMLIKDLIH" field.</summary>
    public const int MDOMLIKDLIHFieldNumber = 2;
    private string mDOMLIKDLIH_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string MDOMLIKDLIH {
      get { return mDOMLIKDLIH_; }
      set {
        mDOMLIKDLIH_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "JBOCCHAFHLH" field.</summary>
    public const int JBOCCHAFHLHFieldNumber = 3;
    private string jBOCCHAFHLH_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string JBOCCHAFHLH {
      get { return jBOCCHAFHLH_; }
      set {
        jBOCCHAFHLH_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "OEOMJECHNBI" field.</summary>
    public const int OEOMJECHNBIFieldNumber = 4;
    private string oEOMJECHNBI_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string OEOMJECHNBI {
      get { return oEOMJECHNBI_; }
      set {
        oEOMJECHNBI_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "MEIEGKJDDCB" field.</summary>
    public const int MEIEGKJDDCBFieldNumber = 5;
    private string mEIEGKJDDCB_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string MEIEGKJDDCB {
      get { return mEIEGKJDDCB_; }
      set {
        mEIEGKJDDCB_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "BHNDMMDKFEE" field.</summary>
    public const int BHNDMMDKFEEFieldNumber = 6;
    private string bHNDMMDKFEE_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string BHNDMMDKFEE {
      get { return bHNDMMDKFEE_; }
      set {
        bHNDMMDKFEE_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "MAC" field.</summary>
    public const int MACFieldNumber = 7;
    private string mAC_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string MAC {
      get { return mAC_; }
      set {
        mAC_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as APBPNIJLOAH);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(APBPNIJLOAH other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MMFBANGHMHL != other.MMFBANGHMHL) return false;
      if (MDOMLIKDLIH != other.MDOMLIKDLIH) return false;
      if (JBOCCHAFHLH != other.JBOCCHAFHLH) return false;
      if (OEOMJECHNBI != other.OEOMJECHNBI) return false;
      if (MEIEGKJDDCB != other.MEIEGKJDDCB) return false;
      if (BHNDMMDKFEE != other.BHNDMMDKFEE) return false;
      if (MAC != other.MAC) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (MMFBANGHMHL.Length != 0) hash ^= MMFBANGHMHL.GetHashCode();
      if (MDOMLIKDLIH.Length != 0) hash ^= MDOMLIKDLIH.GetHashCode();
      if (JBOCCHAFHLH.Length != 0) hash ^= JBOCCHAFHLH.GetHashCode();
      if (OEOMJECHNBI.Length != 0) hash ^= OEOMJECHNBI.GetHashCode();
      if (MEIEGKJDDCB.Length != 0) hash ^= MEIEGKJDDCB.GetHashCode();
      if (BHNDMMDKFEE.Length != 0) hash ^= BHNDMMDKFEE.GetHashCode();
      if (MAC.Length != 0) hash ^= MAC.GetHashCode();
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
      if (MMFBANGHMHL.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(MMFBANGHMHL);
      }
      if (MDOMLIKDLIH.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(MDOMLIKDLIH);
      }
      if (JBOCCHAFHLH.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(JBOCCHAFHLH);
      }
      if (OEOMJECHNBI.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(OEOMJECHNBI);
      }
      if (MEIEGKJDDCB.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(MEIEGKJDDCB);
      }
      if (BHNDMMDKFEE.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(BHNDMMDKFEE);
      }
      if (MAC.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(MAC);
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
      if (MMFBANGHMHL.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(MMFBANGHMHL);
      }
      if (MDOMLIKDLIH.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(MDOMLIKDLIH);
      }
      if (JBOCCHAFHLH.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(JBOCCHAFHLH);
      }
      if (OEOMJECHNBI.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(OEOMJECHNBI);
      }
      if (MEIEGKJDDCB.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(MEIEGKJDDCB);
      }
      if (BHNDMMDKFEE.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(BHNDMMDKFEE);
      }
      if (MAC.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(MAC);
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
      if (MMFBANGHMHL.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MMFBANGHMHL);
      }
      if (MDOMLIKDLIH.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MDOMLIKDLIH);
      }
      if (JBOCCHAFHLH.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(JBOCCHAFHLH);
      }
      if (OEOMJECHNBI.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(OEOMJECHNBI);
      }
      if (MEIEGKJDDCB.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MEIEGKJDDCB);
      }
      if (BHNDMMDKFEE.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BHNDMMDKFEE);
      }
      if (MAC.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MAC);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(APBPNIJLOAH other) {
      if (other == null) {
        return;
      }
      if (other.MMFBANGHMHL.Length != 0) {
        MMFBANGHMHL = other.MMFBANGHMHL;
      }
      if (other.MDOMLIKDLIH.Length != 0) {
        MDOMLIKDLIH = other.MDOMLIKDLIH;
      }
      if (other.JBOCCHAFHLH.Length != 0) {
        JBOCCHAFHLH = other.JBOCCHAFHLH;
      }
      if (other.OEOMJECHNBI.Length != 0) {
        OEOMJECHNBI = other.OEOMJECHNBI;
      }
      if (other.MEIEGKJDDCB.Length != 0) {
        MEIEGKJDDCB = other.MEIEGKJDDCB;
      }
      if (other.BHNDMMDKFEE.Length != 0) {
        BHNDMMDKFEE = other.BHNDMMDKFEE;
      }
      if (other.MAC.Length != 0) {
        MAC = other.MAC;
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
          case 10: {
            MMFBANGHMHL = input.ReadString();
            break;
          }
          case 18: {
            MDOMLIKDLIH = input.ReadString();
            break;
          }
          case 26: {
            JBOCCHAFHLH = input.ReadString();
            break;
          }
          case 34: {
            OEOMJECHNBI = input.ReadString();
            break;
          }
          case 42: {
            MEIEGKJDDCB = input.ReadString();
            break;
          }
          case 50: {
            BHNDMMDKFEE = input.ReadString();
            break;
          }
          case 58: {
            MAC = input.ReadString();
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
          case 10: {
            MMFBANGHMHL = input.ReadString();
            break;
          }
          case 18: {
            MDOMLIKDLIH = input.ReadString();
            break;
          }
          case 26: {
            JBOCCHAFHLH = input.ReadString();
            break;
          }
          case 34: {
            OEOMJECHNBI = input.ReadString();
            break;
          }
          case 42: {
            MEIEGKJDDCB = input.ReadString();
            break;
          }
          case 50: {
            BHNDMMDKFEE = input.ReadString();
            break;
          }
          case 58: {
            MAC = input.ReadString();
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