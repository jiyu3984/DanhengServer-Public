// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MultiplayerMatch3FinishScNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from MultiplayerMatch3FinishScNotify.proto</summary>
  public static partial class MultiplayerMatch3FinishScNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for MultiplayerMatch3FinishScNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MultiplayerMatch3FinishScNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVNdWx0aXBsYXllck1hdGNoM0ZpbmlzaFNjTm90aWZ5LnByb3RvGhFCS0FO",
            "Q0NGSkVQRS5wcm90bxoRQ09LTUVGT0xEREgucHJvdG8ijAEKH011bHRpcGxh",
            "eWVyTWF0Y2gzRmluaXNoU2NOb3RpZnkSEwoLTUdLTUJNS0tLS0MYBCABKA0S",
            "HAoGcmVhc29uGAsgASgOMgwuQktBTkNDRkpFUEUSEwoLSUZPSURNSk5ISUcY",
            "ByABKA0SIQoLQk5QRkdCRUNMREUYDSABKAsyDC5DT0tNRUZPTERESEIeqgIb",
            "RWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.BKANCCFJEPEReflection.Descriptor, global::EggLink.DanhengServer.Proto.COKMEFOLDDHReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.MultiplayerMatch3FinishScNotify), global::EggLink.DanhengServer.Proto.MultiplayerMatch3FinishScNotify.Parser, new[]{ "MGKMBMKKKKC", "Reason", "IFOIDMJNHIG", "BNPFGBECLDE" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class MultiplayerMatch3FinishScNotify : pb::IMessage<MultiplayerMatch3FinishScNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MultiplayerMatch3FinishScNotify> _parser = new pb::MessageParser<MultiplayerMatch3FinishScNotify>(() => new MultiplayerMatch3FinishScNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MultiplayerMatch3FinishScNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.MultiplayerMatch3FinishScNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MultiplayerMatch3FinishScNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MultiplayerMatch3FinishScNotify(MultiplayerMatch3FinishScNotify other) : this() {
      mGKMBMKKKKC_ = other.mGKMBMKKKKC_;
      reason_ = other.reason_;
      iFOIDMJNHIG_ = other.iFOIDMJNHIG_;
      bNPFGBECLDE_ = other.bNPFGBECLDE_ != null ? other.bNPFGBECLDE_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MultiplayerMatch3FinishScNotify Clone() {
      return new MultiplayerMatch3FinishScNotify(this);
    }

    /// <summary>Field number for the "MGKMBMKKKKC" field.</summary>
    public const int MGKMBMKKKKCFieldNumber = 4;
    private uint mGKMBMKKKKC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MGKMBMKKKKC {
      get { return mGKMBMKKKKC_; }
      set {
        mGKMBMKKKKC_ = value;
      }
    }

    /// <summary>Field number for the "reason" field.</summary>
    public const int ReasonFieldNumber = 11;
    private global::EggLink.DanhengServer.Proto.BKANCCFJEPE reason_ = global::EggLink.DanhengServer.Proto.BKANCCFJEPE.Match3FinishReasonDefault;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.BKANCCFJEPE Reason {
      get { return reason_; }
      set {
        reason_ = value;
      }
    }

    /// <summary>Field number for the "IFOIDMJNHIG" field.</summary>
    public const int IFOIDMJNHIGFieldNumber = 7;
    private uint iFOIDMJNHIG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint IFOIDMJNHIG {
      get { return iFOIDMJNHIG_; }
      set {
        iFOIDMJNHIG_ = value;
      }
    }

    /// <summary>Field number for the "BNPFGBECLDE" field.</summary>
    public const int BNPFGBECLDEFieldNumber = 13;
    private global::EggLink.DanhengServer.Proto.COKMEFOLDDH bNPFGBECLDE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.COKMEFOLDDH BNPFGBECLDE {
      get { return bNPFGBECLDE_; }
      set {
        bNPFGBECLDE_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MultiplayerMatch3FinishScNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MultiplayerMatch3FinishScNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MGKMBMKKKKC != other.MGKMBMKKKKC) return false;
      if (Reason != other.Reason) return false;
      if (IFOIDMJNHIG != other.IFOIDMJNHIG) return false;
      if (!object.Equals(BNPFGBECLDE, other.BNPFGBECLDE)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (MGKMBMKKKKC != 0) hash ^= MGKMBMKKKKC.GetHashCode();
      if (Reason != global::EggLink.DanhengServer.Proto.BKANCCFJEPE.Match3FinishReasonDefault) hash ^= Reason.GetHashCode();
      if (IFOIDMJNHIG != 0) hash ^= IFOIDMJNHIG.GetHashCode();
      if (bNPFGBECLDE_ != null) hash ^= BNPFGBECLDE.GetHashCode();
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
      if (MGKMBMKKKKC != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(MGKMBMKKKKC);
      }
      if (IFOIDMJNHIG != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(IFOIDMJNHIG);
      }
      if (Reason != global::EggLink.DanhengServer.Proto.BKANCCFJEPE.Match3FinishReasonDefault) {
        output.WriteRawTag(88);
        output.WriteEnum((int) Reason);
      }
      if (bNPFGBECLDE_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(BNPFGBECLDE);
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
      if (MGKMBMKKKKC != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(MGKMBMKKKKC);
      }
      if (IFOIDMJNHIG != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(IFOIDMJNHIG);
      }
      if (Reason != global::EggLink.DanhengServer.Proto.BKANCCFJEPE.Match3FinishReasonDefault) {
        output.WriteRawTag(88);
        output.WriteEnum((int) Reason);
      }
      if (bNPFGBECLDE_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(BNPFGBECLDE);
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
      if (MGKMBMKKKKC != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MGKMBMKKKKC);
      }
      if (Reason != global::EggLink.DanhengServer.Proto.BKANCCFJEPE.Match3FinishReasonDefault) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Reason);
      }
      if (IFOIDMJNHIG != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(IFOIDMJNHIG);
      }
      if (bNPFGBECLDE_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BNPFGBECLDE);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MultiplayerMatch3FinishScNotify other) {
      if (other == null) {
        return;
      }
      if (other.MGKMBMKKKKC != 0) {
        MGKMBMKKKKC = other.MGKMBMKKKKC;
      }
      if (other.Reason != global::EggLink.DanhengServer.Proto.BKANCCFJEPE.Match3FinishReasonDefault) {
        Reason = other.Reason;
      }
      if (other.IFOIDMJNHIG != 0) {
        IFOIDMJNHIG = other.IFOIDMJNHIG;
      }
      if (other.bNPFGBECLDE_ != null) {
        if (bNPFGBECLDE_ == null) {
          BNPFGBECLDE = new global::EggLink.DanhengServer.Proto.COKMEFOLDDH();
        }
        BNPFGBECLDE.MergeFrom(other.BNPFGBECLDE);
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
            MGKMBMKKKKC = input.ReadUInt32();
            break;
          }
          case 56: {
            IFOIDMJNHIG = input.ReadUInt32();
            break;
          }
          case 88: {
            Reason = (global::EggLink.DanhengServer.Proto.BKANCCFJEPE) input.ReadEnum();
            break;
          }
          case 106: {
            if (bNPFGBECLDE_ == null) {
              BNPFGBECLDE = new global::EggLink.DanhengServer.Proto.COKMEFOLDDH();
            }
            input.ReadMessage(BNPFGBECLDE);
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
            MGKMBMKKKKC = input.ReadUInt32();
            break;
          }
          case 56: {
            IFOIDMJNHIG = input.ReadUInt32();
            break;
          }
          case 88: {
            Reason = (global::EggLink.DanhengServer.Proto.BKANCCFJEPE) input.ReadEnum();
            break;
          }
          case 106: {
            if (bNPFGBECLDE_ == null) {
              BNPFGBECLDE = new global::EggLink.DanhengServer.Proto.COKMEFOLDDH();
            }
            input.ReadMessage(BNPFGBECLDE);
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