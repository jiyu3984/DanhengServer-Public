// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SetStuffToAreaCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SetStuffToAreaCsReq.proto</summary>
  public static partial class SetStuffToAreaCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for SetStuffToAreaCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SetStuffToAreaCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlTZXRTdHVmZlRvQXJlYUNzUmVxLnByb3RvGhFCTUVQQ0dNQUZPRy5wcm90",
            "byJaChNTZXRTdHVmZlRvQXJlYUNzUmVxEhMKC0VFSU5ESEpCRlBGGAogASgN",
            "EhkKA3BvcxgNIAEoDjIMLkJNRVBDR01BRk9HEhMKC0lIS0hEUFBHRU1IGAUg",
            "ASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.BMEPCGMAFOGReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SetStuffToAreaCsReq), global::EggLink.DanhengServer.Proto.SetStuffToAreaCsReq.Parser, new[]{ "EEINDHJBFPF", "Pos", "IHKHDPPGEMH" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SetStuffToAreaCsReq : pb::IMessage<SetStuffToAreaCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SetStuffToAreaCsReq> _parser = new pb::MessageParser<SetStuffToAreaCsReq>(() => new SetStuffToAreaCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SetStuffToAreaCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.SetStuffToAreaCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SetStuffToAreaCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SetStuffToAreaCsReq(SetStuffToAreaCsReq other) : this() {
      eEINDHJBFPF_ = other.eEINDHJBFPF_;
      pos_ = other.pos_;
      iHKHDPPGEMH_ = other.iHKHDPPGEMH_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SetStuffToAreaCsReq Clone() {
      return new SetStuffToAreaCsReq(this);
    }

    /// <summary>Field number for the "EEINDHJBFPF" field.</summary>
    public const int EEINDHJBFPFFieldNumber = 10;
    private uint eEINDHJBFPF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EEINDHJBFPF {
      get { return eEINDHJBFPF_; }
      set {
        eEINDHJBFPF_ = value;
      }
    }

    /// <summary>Field number for the "pos" field.</summary>
    public const int PosFieldNumber = 13;
    private global::EggLink.DanhengServer.Proto.BMEPCGMAFOG pos_ = global::EggLink.DanhengServer.Proto.BMEPCGMAFOG.WorkPosNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.BMEPCGMAFOG Pos {
      get { return pos_; }
      set {
        pos_ = value;
      }
    }

    /// <summary>Field number for the "IHKHDPPGEMH" field.</summary>
    public const int IHKHDPPGEMHFieldNumber = 5;
    private uint iHKHDPPGEMH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint IHKHDPPGEMH {
      get { return iHKHDPPGEMH_; }
      set {
        iHKHDPPGEMH_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SetStuffToAreaCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SetStuffToAreaCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EEINDHJBFPF != other.EEINDHJBFPF) return false;
      if (Pos != other.Pos) return false;
      if (IHKHDPPGEMH != other.IHKHDPPGEMH) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EEINDHJBFPF != 0) hash ^= EEINDHJBFPF.GetHashCode();
      if (Pos != global::EggLink.DanhengServer.Proto.BMEPCGMAFOG.WorkPosNone) hash ^= Pos.GetHashCode();
      if (IHKHDPPGEMH != 0) hash ^= IHKHDPPGEMH.GetHashCode();
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
      if (IHKHDPPGEMH != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(IHKHDPPGEMH);
      }
      if (EEINDHJBFPF != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(EEINDHJBFPF);
      }
      if (Pos != global::EggLink.DanhengServer.Proto.BMEPCGMAFOG.WorkPosNone) {
        output.WriteRawTag(104);
        output.WriteEnum((int) Pos);
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
      if (IHKHDPPGEMH != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(IHKHDPPGEMH);
      }
      if (EEINDHJBFPF != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(EEINDHJBFPF);
      }
      if (Pos != global::EggLink.DanhengServer.Proto.BMEPCGMAFOG.WorkPosNone) {
        output.WriteRawTag(104);
        output.WriteEnum((int) Pos);
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
      if (EEINDHJBFPF != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EEINDHJBFPF);
      }
      if (Pos != global::EggLink.DanhengServer.Proto.BMEPCGMAFOG.WorkPosNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Pos);
      }
      if (IHKHDPPGEMH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(IHKHDPPGEMH);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SetStuffToAreaCsReq other) {
      if (other == null) {
        return;
      }
      if (other.EEINDHJBFPF != 0) {
        EEINDHJBFPF = other.EEINDHJBFPF;
      }
      if (other.Pos != global::EggLink.DanhengServer.Proto.BMEPCGMAFOG.WorkPosNone) {
        Pos = other.Pos;
      }
      if (other.IHKHDPPGEMH != 0) {
        IHKHDPPGEMH = other.IHKHDPPGEMH;
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
            IHKHDPPGEMH = input.ReadUInt32();
            break;
          }
          case 80: {
            EEINDHJBFPF = input.ReadUInt32();
            break;
          }
          case 104: {
            Pos = (global::EggLink.DanhengServer.Proto.BMEPCGMAFOG) input.ReadEnum();
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
            IHKHDPPGEMH = input.ReadUInt32();
            break;
          }
          case 80: {
            EEINDHJBFPF = input.ReadUInt32();
            break;
          }
          case 104: {
            Pos = (global::EggLink.DanhengServer.Proto.BMEPCGMAFOG) input.ReadEnum();
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