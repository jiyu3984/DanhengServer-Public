// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RelicSmartWearUpdatePlanCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RelicSmartWearUpdatePlanCsReq.proto</summary>
  public static partial class RelicSmartWearUpdatePlanCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for RelicSmartWearUpdatePlanCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RelicSmartWearUpdatePlanCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNSZWxpY1NtYXJ0V2VhclVwZGF0ZVBsYW5Dc1JlcS5wcm90bxoRQ1BKSEdD",
            "RUNPSUUucHJvdG8iQgodUmVsaWNTbWFydFdlYXJVcGRhdGVQbGFuQ3NSZXES",
            "IQoLTUJHTkNHR0JFUFAYCiABKAsyDC5DUEpIR0NFQ09JRUIeqgIbRWdnTGlu",
            "ay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.CPJHGCECOIEReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RelicSmartWearUpdatePlanCsReq), global::EggLink.DanhengServer.Proto.RelicSmartWearUpdatePlanCsReq.Parser, new[]{ "MBGNCGGBEPP" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RelicSmartWearUpdatePlanCsReq : pb::IMessage<RelicSmartWearUpdatePlanCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RelicSmartWearUpdatePlanCsReq> _parser = new pb::MessageParser<RelicSmartWearUpdatePlanCsReq>(() => new RelicSmartWearUpdatePlanCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RelicSmartWearUpdatePlanCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RelicSmartWearUpdatePlanCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RelicSmartWearUpdatePlanCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RelicSmartWearUpdatePlanCsReq(RelicSmartWearUpdatePlanCsReq other) : this() {
      mBGNCGGBEPP_ = other.mBGNCGGBEPP_ != null ? other.mBGNCGGBEPP_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RelicSmartWearUpdatePlanCsReq Clone() {
      return new RelicSmartWearUpdatePlanCsReq(this);
    }

    /// <summary>Field number for the "MBGNCGGBEPP" field.</summary>
    public const int MBGNCGGBEPPFieldNumber = 10;
    private global::EggLink.DanhengServer.Proto.CPJHGCECOIE mBGNCGGBEPP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.CPJHGCECOIE MBGNCGGBEPP {
      get { return mBGNCGGBEPP_; }
      set {
        mBGNCGGBEPP_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RelicSmartWearUpdatePlanCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RelicSmartWearUpdatePlanCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(MBGNCGGBEPP, other.MBGNCGGBEPP)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (mBGNCGGBEPP_ != null) hash ^= MBGNCGGBEPP.GetHashCode();
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
      if (mBGNCGGBEPP_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(MBGNCGGBEPP);
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
      if (mBGNCGGBEPP_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(MBGNCGGBEPP);
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
      if (mBGNCGGBEPP_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MBGNCGGBEPP);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RelicSmartWearUpdatePlanCsReq other) {
      if (other == null) {
        return;
      }
      if (other.mBGNCGGBEPP_ != null) {
        if (mBGNCGGBEPP_ == null) {
          MBGNCGGBEPP = new global::EggLink.DanhengServer.Proto.CPJHGCECOIE();
        }
        MBGNCGGBEPP.MergeFrom(other.MBGNCGGBEPP);
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
          case 82: {
            if (mBGNCGGBEPP_ == null) {
              MBGNCGGBEPP = new global::EggLink.DanhengServer.Proto.CPJHGCECOIE();
            }
            input.ReadMessage(MBGNCGGBEPP);
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
          case 82: {
            if (mBGNCGGBEPP_ == null) {
              MBGNCGGBEPP = new global::EggLink.DanhengServer.Proto.CPJHGCECOIE();
            }
            input.ReadMessage(MBGNCGGBEPP);
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
