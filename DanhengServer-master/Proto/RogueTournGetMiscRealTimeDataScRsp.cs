// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueTournGetMiscRealTimeDataScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueTournGetMiscRealTimeDataScRsp.proto</summary>
  public static partial class RogueTournGetMiscRealTimeDataScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueTournGetMiscRealTimeDataScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueTournGetMiscRealTimeDataScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CihSb2d1ZVRvdXJuR2V0TWlzY1JlYWxUaW1lRGF0YVNjUnNwLnByb3RvGhFF",
            "QUdGS0dBSUNDQS5wcm90bxoRQU5HQkRQTE5JREsucHJvdG8aEUZMUEZIR0lN",
            "RU5ELnByb3RvIp4BCiJSb2d1ZVRvdXJuR2V0TWlzY1JlYWxUaW1lRGF0YVNj",
            "UnNwEiEKC0lPSE1FTkxNRERBGA4gASgLMgwuQU5HQkRQTE5JREsSIQoLQkdM",
            "QkJPR0hISU0YDyABKAsyDC5FQUdGS0dBSUNDQRIPCgdyZXRjb2RlGAMgASgN",
            "EiEKC0VORkJKQkhQR0dOGAggASgLMgwuRkxQRkhHSU1FTkRCHqoCG0VnZ0xp",
            "bmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.EAGFKGAICCAReflection.Descriptor, global::EggLink.DanhengServer.Proto.ANGBDPLNIDKReflection.Descriptor, global::EggLink.DanhengServer.Proto.FLPFHGIMENDReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueTournGetMiscRealTimeDataScRsp), global::EggLink.DanhengServer.Proto.RogueTournGetMiscRealTimeDataScRsp.Parser, new[]{ "IOHMENLMDDA", "BGLBBOGHHIM", "Retcode", "ENFBJBHPGGN" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueTournGetMiscRealTimeDataScRsp : pb::IMessage<RogueTournGetMiscRealTimeDataScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueTournGetMiscRealTimeDataScRsp> _parser = new pb::MessageParser<RogueTournGetMiscRealTimeDataScRsp>(() => new RogueTournGetMiscRealTimeDataScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueTournGetMiscRealTimeDataScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueTournGetMiscRealTimeDataScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueTournGetMiscRealTimeDataScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueTournGetMiscRealTimeDataScRsp(RogueTournGetMiscRealTimeDataScRsp other) : this() {
      iOHMENLMDDA_ = other.iOHMENLMDDA_ != null ? other.iOHMENLMDDA_.Clone() : null;
      bGLBBOGHHIM_ = other.bGLBBOGHHIM_ != null ? other.bGLBBOGHHIM_.Clone() : null;
      retcode_ = other.retcode_;
      eNFBJBHPGGN_ = other.eNFBJBHPGGN_ != null ? other.eNFBJBHPGGN_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueTournGetMiscRealTimeDataScRsp Clone() {
      return new RogueTournGetMiscRealTimeDataScRsp(this);
    }

    /// <summary>Field number for the "IOHMENLMDDA" field.</summary>
    public const int IOHMENLMDDAFieldNumber = 14;
    private global::EggLink.DanhengServer.Proto.ANGBDPLNIDK iOHMENLMDDA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ANGBDPLNIDK IOHMENLMDDA {
      get { return iOHMENLMDDA_; }
      set {
        iOHMENLMDDA_ = value;
      }
    }

    /// <summary>Field number for the "BGLBBOGHHIM" field.</summary>
    public const int BGLBBOGHHIMFieldNumber = 15;
    private global::EggLink.DanhengServer.Proto.EAGFKGAICCA bGLBBOGHHIM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.EAGFKGAICCA BGLBBOGHHIM {
      get { return bGLBBOGHHIM_; }
      set {
        bGLBBOGHHIM_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 3;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "ENFBJBHPGGN" field.</summary>
    public const int ENFBJBHPGGNFieldNumber = 8;
    private global::EggLink.DanhengServer.Proto.FLPFHGIMEND eNFBJBHPGGN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.FLPFHGIMEND ENFBJBHPGGN {
      get { return eNFBJBHPGGN_; }
      set {
        eNFBJBHPGGN_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueTournGetMiscRealTimeDataScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueTournGetMiscRealTimeDataScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(IOHMENLMDDA, other.IOHMENLMDDA)) return false;
      if (!object.Equals(BGLBBOGHHIM, other.BGLBBOGHHIM)) return false;
      if (Retcode != other.Retcode) return false;
      if (!object.Equals(ENFBJBHPGGN, other.ENFBJBHPGGN)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (iOHMENLMDDA_ != null) hash ^= IOHMENLMDDA.GetHashCode();
      if (bGLBBOGHHIM_ != null) hash ^= BGLBBOGHHIM.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (eNFBJBHPGGN_ != null) hash ^= ENFBJBHPGGN.GetHashCode();
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
      if (Retcode != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Retcode);
      }
      if (eNFBJBHPGGN_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(ENFBJBHPGGN);
      }
      if (iOHMENLMDDA_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(IOHMENLMDDA);
      }
      if (bGLBBOGHHIM_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(BGLBBOGHHIM);
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
      if (Retcode != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Retcode);
      }
      if (eNFBJBHPGGN_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(ENFBJBHPGGN);
      }
      if (iOHMENLMDDA_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(IOHMENLMDDA);
      }
      if (bGLBBOGHHIM_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(BGLBBOGHHIM);
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
      if (iOHMENLMDDA_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(IOHMENLMDDA);
      }
      if (bGLBBOGHHIM_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BGLBBOGHHIM);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (eNFBJBHPGGN_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ENFBJBHPGGN);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueTournGetMiscRealTimeDataScRsp other) {
      if (other == null) {
        return;
      }
      if (other.iOHMENLMDDA_ != null) {
        if (iOHMENLMDDA_ == null) {
          IOHMENLMDDA = new global::EggLink.DanhengServer.Proto.ANGBDPLNIDK();
        }
        IOHMENLMDDA.MergeFrom(other.IOHMENLMDDA);
      }
      if (other.bGLBBOGHHIM_ != null) {
        if (bGLBBOGHHIM_ == null) {
          BGLBBOGHHIM = new global::EggLink.DanhengServer.Proto.EAGFKGAICCA();
        }
        BGLBBOGHHIM.MergeFrom(other.BGLBBOGHHIM);
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.eNFBJBHPGGN_ != null) {
        if (eNFBJBHPGGN_ == null) {
          ENFBJBHPGGN = new global::EggLink.DanhengServer.Proto.FLPFHGIMEND();
        }
        ENFBJBHPGGN.MergeFrom(other.ENFBJBHPGGN);
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
          case 24: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 66: {
            if (eNFBJBHPGGN_ == null) {
              ENFBJBHPGGN = new global::EggLink.DanhengServer.Proto.FLPFHGIMEND();
            }
            input.ReadMessage(ENFBJBHPGGN);
            break;
          }
          case 114: {
            if (iOHMENLMDDA_ == null) {
              IOHMENLMDDA = new global::EggLink.DanhengServer.Proto.ANGBDPLNIDK();
            }
            input.ReadMessage(IOHMENLMDDA);
            break;
          }
          case 122: {
            if (bGLBBOGHHIM_ == null) {
              BGLBBOGHHIM = new global::EggLink.DanhengServer.Proto.EAGFKGAICCA();
            }
            input.ReadMessage(BGLBBOGHHIM);
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
          case 24: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 66: {
            if (eNFBJBHPGGN_ == null) {
              ENFBJBHPGGN = new global::EggLink.DanhengServer.Proto.FLPFHGIMEND();
            }
            input.ReadMessage(ENFBJBHPGGN);
            break;
          }
          case 114: {
            if (iOHMENLMDDA_ == null) {
              IOHMENLMDDA = new global::EggLink.DanhengServer.Proto.ANGBDPLNIDK();
            }
            input.ReadMessage(IOHMENLMDDA);
            break;
          }
          case 122: {
            if (bGLBBOGHHIM_ == null) {
              BGLBBOGHHIM = new global::EggLink.DanhengServer.Proto.EAGFKGAICCA();
            }
            input.ReadMessage(BGLBBOGHHIM);
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