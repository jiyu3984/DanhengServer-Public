// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TakeKilledPunkLordMonsterScoreScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from TakeKilledPunkLordMonsterScoreScRsp.proto</summary>
  public static partial class TakeKilledPunkLordMonsterScoreScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for TakeKilledPunkLordMonsterScoreScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TakeKilledPunkLordMonsterScoreScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CilUYWtlS2lsbGVkUHVua0xvcmRNb25zdGVyU2NvcmVTY1JzcC5wcm90bxoY",
            "UHVua0xvcmRNb25zdGVyS2V5LnByb3RvIocBCiNUYWtlS2lsbGVkUHVua0xv",
            "cmRNb25zdGVyU2NvcmVTY1JzcBIPCgdyZXRjb2RlGAggASgNEhAKCHNjb3Jl",
            "X2lkGAYgASgNEigKC0lDSFBNQVBKT0RPGAEgAygLMhMuUHVua0xvcmRNb25z",
            "dGVyS2V5EhMKC0JESUtJSU5PSE1GGA8gASgIQh6qAhtFZ2dMaW5rLkRhbmhl",
            "bmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.PunkLordMonsterKeyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.TakeKilledPunkLordMonsterScoreScRsp), global::EggLink.DanhengServer.Proto.TakeKilledPunkLordMonsterScoreScRsp.Parser, new[]{ "Retcode", "ScoreId", "ICHPMAPJODO", "BDIKIINOHMF" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class TakeKilledPunkLordMonsterScoreScRsp : pb::IMessage<TakeKilledPunkLordMonsterScoreScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TakeKilledPunkLordMonsterScoreScRsp> _parser = new pb::MessageParser<TakeKilledPunkLordMonsterScoreScRsp>(() => new TakeKilledPunkLordMonsterScoreScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TakeKilledPunkLordMonsterScoreScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.TakeKilledPunkLordMonsterScoreScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TakeKilledPunkLordMonsterScoreScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TakeKilledPunkLordMonsterScoreScRsp(TakeKilledPunkLordMonsterScoreScRsp other) : this() {
      retcode_ = other.retcode_;
      scoreId_ = other.scoreId_;
      iCHPMAPJODO_ = other.iCHPMAPJODO_.Clone();
      bDIKIINOHMF_ = other.bDIKIINOHMF_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TakeKilledPunkLordMonsterScoreScRsp Clone() {
      return new TakeKilledPunkLordMonsterScoreScRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 8;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "score_id" field.</summary>
    public const int ScoreIdFieldNumber = 6;
    private uint scoreId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ScoreId {
      get { return scoreId_; }
      set {
        scoreId_ = value;
      }
    }

    /// <summary>Field number for the "ICHPMAPJODO" field.</summary>
    public const int ICHPMAPJODOFieldNumber = 1;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.PunkLordMonsterKey> _repeated_iCHPMAPJODO_codec
        = pb::FieldCodec.ForMessage(10, global::EggLink.DanhengServer.Proto.PunkLordMonsterKey.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.PunkLordMonsterKey> iCHPMAPJODO_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.PunkLordMonsterKey>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.PunkLordMonsterKey> ICHPMAPJODO {
      get { return iCHPMAPJODO_; }
    }

    /// <summary>Field number for the "BDIKIINOHMF" field.</summary>
    public const int BDIKIINOHMFFieldNumber = 15;
    private bool bDIKIINOHMF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool BDIKIINOHMF {
      get { return bDIKIINOHMF_; }
      set {
        bDIKIINOHMF_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TakeKilledPunkLordMonsterScoreScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TakeKilledPunkLordMonsterScoreScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (ScoreId != other.ScoreId) return false;
      if(!iCHPMAPJODO_.Equals(other.iCHPMAPJODO_)) return false;
      if (BDIKIINOHMF != other.BDIKIINOHMF) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (ScoreId != 0) hash ^= ScoreId.GetHashCode();
      hash ^= iCHPMAPJODO_.GetHashCode();
      if (BDIKIINOHMF != false) hash ^= BDIKIINOHMF.GetHashCode();
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
      iCHPMAPJODO_.WriteTo(output, _repeated_iCHPMAPJODO_codec);
      if (ScoreId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(ScoreId);
      }
      if (Retcode != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Retcode);
      }
      if (BDIKIINOHMF != false) {
        output.WriteRawTag(120);
        output.WriteBool(BDIKIINOHMF);
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
      iCHPMAPJODO_.WriteTo(ref output, _repeated_iCHPMAPJODO_codec);
      if (ScoreId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(ScoreId);
      }
      if (Retcode != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Retcode);
      }
      if (BDIKIINOHMF != false) {
        output.WriteRawTag(120);
        output.WriteBool(BDIKIINOHMF);
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
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (ScoreId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ScoreId);
      }
      size += iCHPMAPJODO_.CalculateSize(_repeated_iCHPMAPJODO_codec);
      if (BDIKIINOHMF != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TakeKilledPunkLordMonsterScoreScRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.ScoreId != 0) {
        ScoreId = other.ScoreId;
      }
      iCHPMAPJODO_.Add(other.iCHPMAPJODO_);
      if (other.BDIKIINOHMF != false) {
        BDIKIINOHMF = other.BDIKIINOHMF;
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
            iCHPMAPJODO_.AddEntriesFrom(input, _repeated_iCHPMAPJODO_codec);
            break;
          }
          case 48: {
            ScoreId = input.ReadUInt32();
            break;
          }
          case 64: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 120: {
            BDIKIINOHMF = input.ReadBool();
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
            iCHPMAPJODO_.AddEntriesFrom(ref input, _repeated_iCHPMAPJODO_codec);
            break;
          }
          case 48: {
            ScoreId = input.ReadUInt32();
            break;
          }
          case 64: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 120: {
            BDIKIINOHMF = input.ReadBool();
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