// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PKFIDPGFEJK.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from PKFIDPGFEJK.proto</summary>
  public static partial class PKFIDPGFEJKReflection {

    #region Descriptor
    /// <summary>File descriptor for PKFIDPGFEJK.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PKFIDPGFEJKReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFQS0ZJRFBHRkVKSy5wcm90bxoRQUtQREZMUElLQk0ucHJvdG8iVwoLUEtG",
            "SURQR0ZFSksSIQoLRE9DUEJGRENFSFAYBiADKAsyDC5BS1BERkxQSUtCTRIQ",
            "Cghncm91cF9pZBgEIAEoDRITCgtMTUtPR0ZCQk9GQhgJIAEoCEIeqgIbRWdn",
            "TGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.AKPDFLPIKBMReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.PKFIDPGFEJK), global::EggLink.DanhengServer.Proto.PKFIDPGFEJK.Parser, new[]{ "DOCPBFDCEHP", "GroupId", "LMKOGFBBOFB" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class PKFIDPGFEJK : pb::IMessage<PKFIDPGFEJK>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PKFIDPGFEJK> _parser = new pb::MessageParser<PKFIDPGFEJK>(() => new PKFIDPGFEJK());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PKFIDPGFEJK> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.PKFIDPGFEJKReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PKFIDPGFEJK() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PKFIDPGFEJK(PKFIDPGFEJK other) : this() {
      dOCPBFDCEHP_ = other.dOCPBFDCEHP_.Clone();
      groupId_ = other.groupId_;
      lMKOGFBBOFB_ = other.lMKOGFBBOFB_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PKFIDPGFEJK Clone() {
      return new PKFIDPGFEJK(this);
    }

    /// <summary>Field number for the "DOCPBFDCEHP" field.</summary>
    public const int DOCPBFDCEHPFieldNumber = 6;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.AKPDFLPIKBM> _repeated_dOCPBFDCEHP_codec
        = pb::FieldCodec.ForMessage(50, global::EggLink.DanhengServer.Proto.AKPDFLPIKBM.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AKPDFLPIKBM> dOCPBFDCEHP_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AKPDFLPIKBM>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AKPDFLPIKBM> DOCPBFDCEHP {
      get { return dOCPBFDCEHP_; }
    }

    /// <summary>Field number for the "group_id" field.</summary>
    public const int GroupIdFieldNumber = 4;
    private uint groupId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GroupId {
      get { return groupId_; }
      set {
        groupId_ = value;
      }
    }

    /// <summary>Field number for the "LMKOGFBBOFB" field.</summary>
    public const int LMKOGFBBOFBFieldNumber = 9;
    private bool lMKOGFBBOFB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool LMKOGFBBOFB {
      get { return lMKOGFBBOFB_; }
      set {
        lMKOGFBBOFB_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PKFIDPGFEJK);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PKFIDPGFEJK other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!dOCPBFDCEHP_.Equals(other.dOCPBFDCEHP_)) return false;
      if (GroupId != other.GroupId) return false;
      if (LMKOGFBBOFB != other.LMKOGFBBOFB) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= dOCPBFDCEHP_.GetHashCode();
      if (GroupId != 0) hash ^= GroupId.GetHashCode();
      if (LMKOGFBBOFB != false) hash ^= LMKOGFBBOFB.GetHashCode();
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
      if (GroupId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(GroupId);
      }
      dOCPBFDCEHP_.WriteTo(output, _repeated_dOCPBFDCEHP_codec);
      if (LMKOGFBBOFB != false) {
        output.WriteRawTag(72);
        output.WriteBool(LMKOGFBBOFB);
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
      if (GroupId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(GroupId);
      }
      dOCPBFDCEHP_.WriteTo(ref output, _repeated_dOCPBFDCEHP_codec);
      if (LMKOGFBBOFB != false) {
        output.WriteRawTag(72);
        output.WriteBool(LMKOGFBBOFB);
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
      size += dOCPBFDCEHP_.CalculateSize(_repeated_dOCPBFDCEHP_codec);
      if (GroupId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GroupId);
      }
      if (LMKOGFBBOFB != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PKFIDPGFEJK other) {
      if (other == null) {
        return;
      }
      dOCPBFDCEHP_.Add(other.dOCPBFDCEHP_);
      if (other.GroupId != 0) {
        GroupId = other.GroupId;
      }
      if (other.LMKOGFBBOFB != false) {
        LMKOGFBBOFB = other.LMKOGFBBOFB;
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
            GroupId = input.ReadUInt32();
            break;
          }
          case 50: {
            dOCPBFDCEHP_.AddEntriesFrom(input, _repeated_dOCPBFDCEHP_codec);
            break;
          }
          case 72: {
            LMKOGFBBOFB = input.ReadBool();
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
            GroupId = input.ReadUInt32();
            break;
          }
          case 50: {
            dOCPBFDCEHP_.AddEntriesFrom(ref input, _repeated_dOCPBFDCEHP_codec);
            break;
          }
          case 72: {
            LMKOGFBBOFB = input.ReadBool();
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
