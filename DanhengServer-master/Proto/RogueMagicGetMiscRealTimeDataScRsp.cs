// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueMagicGetMiscRealTimeDataScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueMagicGetMiscRealTimeDataScRsp.proto</summary>
  public static partial class RogueMagicGetMiscRealTimeDataScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueMagicGetMiscRealTimeDataScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueMagicGetMiscRealTimeDataScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CihSb2d1ZU1hZ2ljR2V0TWlzY1JlYWxUaW1lRGF0YVNjUnNwLnByb3RvGhFH",
            "SUxETkJES09MRC5wcm90bxoRTEFFRVBMQkxEQ0MucHJvdG8iewoiUm9ndWVN",
            "YWdpY0dldE1pc2NSZWFsVGltZURhdGFTY1JzcBIhCgtFRkNETUhIQ0VESBgH",
            "IAEoCzIMLkxBRUVQTEJMRENDEg8KB3JldGNvZGUYDSABKA0SIQoLRU5GQkpC",
            "SFBHR04YBiABKAsyDC5HSUxETkJES09MREIeqgIbRWdnTGluay5EYW5oZW5n",
            "U2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.GILDNBDKOLDReflection.Descriptor, global::EggLink.DanhengServer.Proto.LAEEPLBLDCCReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueMagicGetMiscRealTimeDataScRsp), global::EggLink.DanhengServer.Proto.RogueMagicGetMiscRealTimeDataScRsp.Parser, new[]{ "EFCDMHHCEDH", "Retcode", "ENFBJBHPGGN" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueMagicGetMiscRealTimeDataScRsp : pb::IMessage<RogueMagicGetMiscRealTimeDataScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueMagicGetMiscRealTimeDataScRsp> _parser = new pb::MessageParser<RogueMagicGetMiscRealTimeDataScRsp>(() => new RogueMagicGetMiscRealTimeDataScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueMagicGetMiscRealTimeDataScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueMagicGetMiscRealTimeDataScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueMagicGetMiscRealTimeDataScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueMagicGetMiscRealTimeDataScRsp(RogueMagicGetMiscRealTimeDataScRsp other) : this() {
      eFCDMHHCEDH_ = other.eFCDMHHCEDH_ != null ? other.eFCDMHHCEDH_.Clone() : null;
      retcode_ = other.retcode_;
      eNFBJBHPGGN_ = other.eNFBJBHPGGN_ != null ? other.eNFBJBHPGGN_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueMagicGetMiscRealTimeDataScRsp Clone() {
      return new RogueMagicGetMiscRealTimeDataScRsp(this);
    }

    /// <summary>Field number for the "EFCDMHHCEDH" field.</summary>
    public const int EFCDMHHCEDHFieldNumber = 7;
    private global::EggLink.DanhengServer.Proto.LAEEPLBLDCC eFCDMHHCEDH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.LAEEPLBLDCC EFCDMHHCEDH {
      get { return eFCDMHHCEDH_; }
      set {
        eFCDMHHCEDH_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 13;
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
    public const int ENFBJBHPGGNFieldNumber = 6;
    private global::EggLink.DanhengServer.Proto.GILDNBDKOLD eNFBJBHPGGN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.GILDNBDKOLD ENFBJBHPGGN {
      get { return eNFBJBHPGGN_; }
      set {
        eNFBJBHPGGN_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueMagicGetMiscRealTimeDataScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueMagicGetMiscRealTimeDataScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(EFCDMHHCEDH, other.EFCDMHHCEDH)) return false;
      if (Retcode != other.Retcode) return false;
      if (!object.Equals(ENFBJBHPGGN, other.ENFBJBHPGGN)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (eFCDMHHCEDH_ != null) hash ^= EFCDMHHCEDH.GetHashCode();
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
      if (eNFBJBHPGGN_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(ENFBJBHPGGN);
      }
      if (eFCDMHHCEDH_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(EFCDMHHCEDH);
      }
      if (Retcode != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Retcode);
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
      if (eNFBJBHPGGN_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(ENFBJBHPGGN);
      }
      if (eFCDMHHCEDH_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(EFCDMHHCEDH);
      }
      if (Retcode != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Retcode);
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
      if (eFCDMHHCEDH_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EFCDMHHCEDH);
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
    public void MergeFrom(RogueMagicGetMiscRealTimeDataScRsp other) {
      if (other == null) {
        return;
      }
      if (other.eFCDMHHCEDH_ != null) {
        if (eFCDMHHCEDH_ == null) {
          EFCDMHHCEDH = new global::EggLink.DanhengServer.Proto.LAEEPLBLDCC();
        }
        EFCDMHHCEDH.MergeFrom(other.EFCDMHHCEDH);
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.eNFBJBHPGGN_ != null) {
        if (eNFBJBHPGGN_ == null) {
          ENFBJBHPGGN = new global::EggLink.DanhengServer.Proto.GILDNBDKOLD();
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
          case 50: {
            if (eNFBJBHPGGN_ == null) {
              ENFBJBHPGGN = new global::EggLink.DanhengServer.Proto.GILDNBDKOLD();
            }
            input.ReadMessage(ENFBJBHPGGN);
            break;
          }
          case 58: {
            if (eFCDMHHCEDH_ == null) {
              EFCDMHHCEDH = new global::EggLink.DanhengServer.Proto.LAEEPLBLDCC();
            }
            input.ReadMessage(EFCDMHHCEDH);
            break;
          }
          case 104: {
            Retcode = input.ReadUInt32();
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
          case 50: {
            if (eNFBJBHPGGN_ == null) {
              ENFBJBHPGGN = new global::EggLink.DanhengServer.Proto.GILDNBDKOLD();
            }
            input.ReadMessage(ENFBJBHPGGN);
            break;
          }
          case 58: {
            if (eFCDMHHCEDH_ == null) {
              EFCDMHHCEDH = new global::EggLink.DanhengServer.Proto.LAEEPLBLDCC();
            }
            input.ReadMessage(EFCDMHHCEDH);
            break;
          }
          case 104: {
            Retcode = input.ReadUInt32();
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