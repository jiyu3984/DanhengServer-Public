// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetReplayTokenCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetReplayTokenCsReq.proto</summary>
  public static partial class GetReplayTokenCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for GetReplayTokenCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetReplayTokenCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlHZXRSZXBsYXlUb2tlbkNzUmVxLnByb3RvGhBSZXBsYXlUeXBlLnByb3Rv",
            "Ip0BChNHZXRSZXBsYXlUb2tlbkNzUmVxEhAKCHN0YWdlX2lkGAIgASgNEhMK",
            "C0xLUEpGR0VCREFEGAQgASgJEhMKC0FDT0NCR0NDRUNFGAwgASgNEiAKC3Jl",
            "cGxheV90eXBlGAggASgOMgsuUmVwbGF5VHlwZRITCgtKUENQRE5QTEJPTRgJ",
            "IAEoCRITCgtJTkVQQ0dLRE9CTBgKIAEoDUIeqgIbRWdnTGluay5EYW5oZW5n",
            "U2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ReplayTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetReplayTokenCsReq), global::EggLink.DanhengServer.Proto.GetReplayTokenCsReq.Parser, new[]{ "StageId", "LKPJFGEBDAD", "ACOCBGCCECE", "ReplayType", "JPCPDNPLBOM", "INEPCGKDOBL" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetReplayTokenCsReq : pb::IMessage<GetReplayTokenCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetReplayTokenCsReq> _parser = new pb::MessageParser<GetReplayTokenCsReq>(() => new GetReplayTokenCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetReplayTokenCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetReplayTokenCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetReplayTokenCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetReplayTokenCsReq(GetReplayTokenCsReq other) : this() {
      stageId_ = other.stageId_;
      lKPJFGEBDAD_ = other.lKPJFGEBDAD_;
      aCOCBGCCECE_ = other.aCOCBGCCECE_;
      replayType_ = other.replayType_;
      jPCPDNPLBOM_ = other.jPCPDNPLBOM_;
      iNEPCGKDOBL_ = other.iNEPCGKDOBL_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetReplayTokenCsReq Clone() {
      return new GetReplayTokenCsReq(this);
    }

    /// <summary>Field number for the "stage_id" field.</summary>
    public const int StageIdFieldNumber = 2;
    private uint stageId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StageId {
      get { return stageId_; }
      set {
        stageId_ = value;
      }
    }

    /// <summary>Field number for the "LKPJFGEBDAD" field.</summary>
    public const int LKPJFGEBDADFieldNumber = 4;
    private string lKPJFGEBDAD_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string LKPJFGEBDAD {
      get { return lKPJFGEBDAD_; }
      set {
        lKPJFGEBDAD_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ACOCBGCCECE" field.</summary>
    public const int ACOCBGCCECEFieldNumber = 12;
    private uint aCOCBGCCECE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ACOCBGCCECE {
      get { return aCOCBGCCECE_; }
      set {
        aCOCBGCCECE_ = value;
      }
    }

    /// <summary>Field number for the "replay_type" field.</summary>
    public const int ReplayTypeFieldNumber = 8;
    private global::EggLink.DanhengServer.Proto.ReplayType replayType_ = global::EggLink.DanhengServer.Proto.ReplayType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ReplayType ReplayType {
      get { return replayType_; }
      set {
        replayType_ = value;
      }
    }

    /// <summary>Field number for the "JPCPDNPLBOM" field.</summary>
    public const int JPCPDNPLBOMFieldNumber = 9;
    private string jPCPDNPLBOM_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string JPCPDNPLBOM {
      get { return jPCPDNPLBOM_; }
      set {
        jPCPDNPLBOM_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "INEPCGKDOBL" field.</summary>
    public const int INEPCGKDOBLFieldNumber = 10;
    private uint iNEPCGKDOBL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint INEPCGKDOBL {
      get { return iNEPCGKDOBL_; }
      set {
        iNEPCGKDOBL_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetReplayTokenCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetReplayTokenCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (StageId != other.StageId) return false;
      if (LKPJFGEBDAD != other.LKPJFGEBDAD) return false;
      if (ACOCBGCCECE != other.ACOCBGCCECE) return false;
      if (ReplayType != other.ReplayType) return false;
      if (JPCPDNPLBOM != other.JPCPDNPLBOM) return false;
      if (INEPCGKDOBL != other.INEPCGKDOBL) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (StageId != 0) hash ^= StageId.GetHashCode();
      if (LKPJFGEBDAD.Length != 0) hash ^= LKPJFGEBDAD.GetHashCode();
      if (ACOCBGCCECE != 0) hash ^= ACOCBGCCECE.GetHashCode();
      if (ReplayType != global::EggLink.DanhengServer.Proto.ReplayType.None) hash ^= ReplayType.GetHashCode();
      if (JPCPDNPLBOM.Length != 0) hash ^= JPCPDNPLBOM.GetHashCode();
      if (INEPCGKDOBL != 0) hash ^= INEPCGKDOBL.GetHashCode();
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
      if (StageId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(StageId);
      }
      if (LKPJFGEBDAD.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(LKPJFGEBDAD);
      }
      if (ReplayType != global::EggLink.DanhengServer.Proto.ReplayType.None) {
        output.WriteRawTag(64);
        output.WriteEnum((int) ReplayType);
      }
      if (JPCPDNPLBOM.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(JPCPDNPLBOM);
      }
      if (INEPCGKDOBL != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(INEPCGKDOBL);
      }
      if (ACOCBGCCECE != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(ACOCBGCCECE);
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
      if (StageId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(StageId);
      }
      if (LKPJFGEBDAD.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(LKPJFGEBDAD);
      }
      if (ReplayType != global::EggLink.DanhengServer.Proto.ReplayType.None) {
        output.WriteRawTag(64);
        output.WriteEnum((int) ReplayType);
      }
      if (JPCPDNPLBOM.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(JPCPDNPLBOM);
      }
      if (INEPCGKDOBL != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(INEPCGKDOBL);
      }
      if (ACOCBGCCECE != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(ACOCBGCCECE);
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
      if (StageId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StageId);
      }
      if (LKPJFGEBDAD.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LKPJFGEBDAD);
      }
      if (ACOCBGCCECE != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ACOCBGCCECE);
      }
      if (ReplayType != global::EggLink.DanhengServer.Proto.ReplayType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ReplayType);
      }
      if (JPCPDNPLBOM.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(JPCPDNPLBOM);
      }
      if (INEPCGKDOBL != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(INEPCGKDOBL);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetReplayTokenCsReq other) {
      if (other == null) {
        return;
      }
      if (other.StageId != 0) {
        StageId = other.StageId;
      }
      if (other.LKPJFGEBDAD.Length != 0) {
        LKPJFGEBDAD = other.LKPJFGEBDAD;
      }
      if (other.ACOCBGCCECE != 0) {
        ACOCBGCCECE = other.ACOCBGCCECE;
      }
      if (other.ReplayType != global::EggLink.DanhengServer.Proto.ReplayType.None) {
        ReplayType = other.ReplayType;
      }
      if (other.JPCPDNPLBOM.Length != 0) {
        JPCPDNPLBOM = other.JPCPDNPLBOM;
      }
      if (other.INEPCGKDOBL != 0) {
        INEPCGKDOBL = other.INEPCGKDOBL;
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
          case 16: {
            StageId = input.ReadUInt32();
            break;
          }
          case 34: {
            LKPJFGEBDAD = input.ReadString();
            break;
          }
          case 64: {
            ReplayType = (global::EggLink.DanhengServer.Proto.ReplayType) input.ReadEnum();
            break;
          }
          case 74: {
            JPCPDNPLBOM = input.ReadString();
            break;
          }
          case 80: {
            INEPCGKDOBL = input.ReadUInt32();
            break;
          }
          case 96: {
            ACOCBGCCECE = input.ReadUInt32();
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
          case 16: {
            StageId = input.ReadUInt32();
            break;
          }
          case 34: {
            LKPJFGEBDAD = input.ReadString();
            break;
          }
          case 64: {
            ReplayType = (global::EggLink.DanhengServer.Proto.ReplayType) input.ReadEnum();
            break;
          }
          case 74: {
            JPCPDNPLBOM = input.ReadString();
            break;
          }
          case 80: {
            INEPCGKDOBL = input.ReadUInt32();
            break;
          }
          case 96: {
            ACOCBGCCECE = input.ReadUInt32();
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