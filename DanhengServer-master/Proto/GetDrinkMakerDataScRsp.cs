// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetDrinkMakerDataScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetDrinkMakerDataScRsp.proto</summary>
  public static partial class GetDrinkMakerDataScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetDrinkMakerDataScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetDrinkMakerDataScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxHZXREcmlua01ha2VyRGF0YVNjUnNwLnByb3RvGhVEcmlua01ha2VyR3Vl",
            "c3QucHJvdG8aEUhISUlOQkVQQ1BJLnByb3RvIvgBChZHZXREcmlua01ha2Vy",
            "RGF0YVNjUnNwEiUKC0hCS0JQQUJKRk1QGAogAygLMhAuRHJpbmtNYWtlckd1",
            "ZXN0EgsKA2V4cBgLIAEoDRITCgtCSUZBT0VJTklNSRgJIAEoDRINCgVsZXZl",
            "bBgMIAEoDRITCgtETEdFS0hNSUhKSxgEIAEoDRIPCgdyZXRjb2RlGAYgASgN",
            "EhMKC0FIQ0FKR0xJT01KGAEgAygNEiEKC0xNUEJERERFQkxDGAIgASgLMgwu",
            "SEhJSU5CRVBDUEkSEwoLR0FJQkpET0FJTUQYDiABKA0SEwoLUEJBSURPTkJK",
            "RUsYAyABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.DrinkMakerGuestReflection.Descriptor, global::EggLink.DanhengServer.Proto.HHIINBEPCPIReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetDrinkMakerDataScRsp), global::EggLink.DanhengServer.Proto.GetDrinkMakerDataScRsp.Parser, new[]{ "HBKBPABJFMP", "Exp", "BIFAOEINIMI", "Level", "DLGEKHMIHJK", "Retcode", "AHCAJGLIOMJ", "LMPBDDDEBLC", "GAIBJDOAIMD", "PBAIDONBJEK" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetDrinkMakerDataScRsp : pb::IMessage<GetDrinkMakerDataScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetDrinkMakerDataScRsp> _parser = new pb::MessageParser<GetDrinkMakerDataScRsp>(() => new GetDrinkMakerDataScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetDrinkMakerDataScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetDrinkMakerDataScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetDrinkMakerDataScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetDrinkMakerDataScRsp(GetDrinkMakerDataScRsp other) : this() {
      hBKBPABJFMP_ = other.hBKBPABJFMP_.Clone();
      exp_ = other.exp_;
      bIFAOEINIMI_ = other.bIFAOEINIMI_;
      level_ = other.level_;
      dLGEKHMIHJK_ = other.dLGEKHMIHJK_;
      retcode_ = other.retcode_;
      aHCAJGLIOMJ_ = other.aHCAJGLIOMJ_.Clone();
      lMPBDDDEBLC_ = other.lMPBDDDEBLC_ != null ? other.lMPBDDDEBLC_.Clone() : null;
      gAIBJDOAIMD_ = other.gAIBJDOAIMD_;
      pBAIDONBJEK_ = other.pBAIDONBJEK_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetDrinkMakerDataScRsp Clone() {
      return new GetDrinkMakerDataScRsp(this);
    }

    /// <summary>Field number for the "HBKBPABJFMP" field.</summary>
    public const int HBKBPABJFMPFieldNumber = 10;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.DrinkMakerGuest> _repeated_hBKBPABJFMP_codec
        = pb::FieldCodec.ForMessage(82, global::EggLink.DanhengServer.Proto.DrinkMakerGuest.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.DrinkMakerGuest> hBKBPABJFMP_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.DrinkMakerGuest>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.DrinkMakerGuest> HBKBPABJFMP {
      get { return hBKBPABJFMP_; }
    }

    /// <summary>Field number for the "exp" field.</summary>
    public const int ExpFieldNumber = 11;
    private uint exp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Exp {
      get { return exp_; }
      set {
        exp_ = value;
      }
    }

    /// <summary>Field number for the "BIFAOEINIMI" field.</summary>
    public const int BIFAOEINIMIFieldNumber = 9;
    private uint bIFAOEINIMI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BIFAOEINIMI {
      get { return bIFAOEINIMI_; }
      set {
        bIFAOEINIMI_ = value;
      }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 12;
    private uint level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "DLGEKHMIHJK" field.</summary>
    public const int DLGEKHMIHJKFieldNumber = 4;
    private uint dLGEKHMIHJK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DLGEKHMIHJK {
      get { return dLGEKHMIHJK_; }
      set {
        dLGEKHMIHJK_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 6;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "AHCAJGLIOMJ" field.</summary>
    public const int AHCAJGLIOMJFieldNumber = 1;
    private static readonly pb::FieldCodec<uint> _repeated_aHCAJGLIOMJ_codec
        = pb::FieldCodec.ForUInt32(10);
    private readonly pbc::RepeatedField<uint> aHCAJGLIOMJ_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> AHCAJGLIOMJ {
      get { return aHCAJGLIOMJ_; }
    }

    /// <summary>Field number for the "LMPBDDDEBLC" field.</summary>
    public const int LMPBDDDEBLCFieldNumber = 2;
    private global::EggLink.DanhengServer.Proto.HHIINBEPCPI lMPBDDDEBLC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.HHIINBEPCPI LMPBDDDEBLC {
      get { return lMPBDDDEBLC_; }
      set {
        lMPBDDDEBLC_ = value;
      }
    }

    /// <summary>Field number for the "GAIBJDOAIMD" field.</summary>
    public const int GAIBJDOAIMDFieldNumber = 14;
    private uint gAIBJDOAIMD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GAIBJDOAIMD {
      get { return gAIBJDOAIMD_; }
      set {
        gAIBJDOAIMD_ = value;
      }
    }

    /// <summary>Field number for the "PBAIDONBJEK" field.</summary>
    public const int PBAIDONBJEKFieldNumber = 3;
    private uint pBAIDONBJEK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PBAIDONBJEK {
      get { return pBAIDONBJEK_; }
      set {
        pBAIDONBJEK_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetDrinkMakerDataScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetDrinkMakerDataScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!hBKBPABJFMP_.Equals(other.hBKBPABJFMP_)) return false;
      if (Exp != other.Exp) return false;
      if (BIFAOEINIMI != other.BIFAOEINIMI) return false;
      if (Level != other.Level) return false;
      if (DLGEKHMIHJK != other.DLGEKHMIHJK) return false;
      if (Retcode != other.Retcode) return false;
      if(!aHCAJGLIOMJ_.Equals(other.aHCAJGLIOMJ_)) return false;
      if (!object.Equals(LMPBDDDEBLC, other.LMPBDDDEBLC)) return false;
      if (GAIBJDOAIMD != other.GAIBJDOAIMD) return false;
      if (PBAIDONBJEK != other.PBAIDONBJEK) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= hBKBPABJFMP_.GetHashCode();
      if (Exp != 0) hash ^= Exp.GetHashCode();
      if (BIFAOEINIMI != 0) hash ^= BIFAOEINIMI.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
      if (DLGEKHMIHJK != 0) hash ^= DLGEKHMIHJK.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      hash ^= aHCAJGLIOMJ_.GetHashCode();
      if (lMPBDDDEBLC_ != null) hash ^= LMPBDDDEBLC.GetHashCode();
      if (GAIBJDOAIMD != 0) hash ^= GAIBJDOAIMD.GetHashCode();
      if (PBAIDONBJEK != 0) hash ^= PBAIDONBJEK.GetHashCode();
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
      aHCAJGLIOMJ_.WriteTo(output, _repeated_aHCAJGLIOMJ_codec);
      if (lMPBDDDEBLC_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(LMPBDDDEBLC);
      }
      if (PBAIDONBJEK != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(PBAIDONBJEK);
      }
      if (DLGEKHMIHJK != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(DLGEKHMIHJK);
      }
      if (Retcode != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Retcode);
      }
      if (BIFAOEINIMI != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(BIFAOEINIMI);
      }
      hBKBPABJFMP_.WriteTo(output, _repeated_hBKBPABJFMP_codec);
      if (Exp != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Exp);
      }
      if (Level != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Level);
      }
      if (GAIBJDOAIMD != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(GAIBJDOAIMD);
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
      aHCAJGLIOMJ_.WriteTo(ref output, _repeated_aHCAJGLIOMJ_codec);
      if (lMPBDDDEBLC_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(LMPBDDDEBLC);
      }
      if (PBAIDONBJEK != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(PBAIDONBJEK);
      }
      if (DLGEKHMIHJK != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(DLGEKHMIHJK);
      }
      if (Retcode != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Retcode);
      }
      if (BIFAOEINIMI != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(BIFAOEINIMI);
      }
      hBKBPABJFMP_.WriteTo(ref output, _repeated_hBKBPABJFMP_codec);
      if (Exp != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Exp);
      }
      if (Level != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Level);
      }
      if (GAIBJDOAIMD != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(GAIBJDOAIMD);
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
      size += hBKBPABJFMP_.CalculateSize(_repeated_hBKBPABJFMP_codec);
      if (Exp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Exp);
      }
      if (BIFAOEINIMI != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BIFAOEINIMI);
      }
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Level);
      }
      if (DLGEKHMIHJK != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DLGEKHMIHJK);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      size += aHCAJGLIOMJ_.CalculateSize(_repeated_aHCAJGLIOMJ_codec);
      if (lMPBDDDEBLC_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LMPBDDDEBLC);
      }
      if (GAIBJDOAIMD != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GAIBJDOAIMD);
      }
      if (PBAIDONBJEK != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PBAIDONBJEK);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetDrinkMakerDataScRsp other) {
      if (other == null) {
        return;
      }
      hBKBPABJFMP_.Add(other.hBKBPABJFMP_);
      if (other.Exp != 0) {
        Exp = other.Exp;
      }
      if (other.BIFAOEINIMI != 0) {
        BIFAOEINIMI = other.BIFAOEINIMI;
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
      if (other.DLGEKHMIHJK != 0) {
        DLGEKHMIHJK = other.DLGEKHMIHJK;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      aHCAJGLIOMJ_.Add(other.aHCAJGLIOMJ_);
      if (other.lMPBDDDEBLC_ != null) {
        if (lMPBDDDEBLC_ == null) {
          LMPBDDDEBLC = new global::EggLink.DanhengServer.Proto.HHIINBEPCPI();
        }
        LMPBDDDEBLC.MergeFrom(other.LMPBDDDEBLC);
      }
      if (other.GAIBJDOAIMD != 0) {
        GAIBJDOAIMD = other.GAIBJDOAIMD;
      }
      if (other.PBAIDONBJEK != 0) {
        PBAIDONBJEK = other.PBAIDONBJEK;
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
          case 10:
          case 8: {
            aHCAJGLIOMJ_.AddEntriesFrom(input, _repeated_aHCAJGLIOMJ_codec);
            break;
          }
          case 18: {
            if (lMPBDDDEBLC_ == null) {
              LMPBDDDEBLC = new global::EggLink.DanhengServer.Proto.HHIINBEPCPI();
            }
            input.ReadMessage(LMPBDDDEBLC);
            break;
          }
          case 24: {
            PBAIDONBJEK = input.ReadUInt32();
            break;
          }
          case 32: {
            DLGEKHMIHJK = input.ReadUInt32();
            break;
          }
          case 48: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 72: {
            BIFAOEINIMI = input.ReadUInt32();
            break;
          }
          case 82: {
            hBKBPABJFMP_.AddEntriesFrom(input, _repeated_hBKBPABJFMP_codec);
            break;
          }
          case 88: {
            Exp = input.ReadUInt32();
            break;
          }
          case 96: {
            Level = input.ReadUInt32();
            break;
          }
          case 112: {
            GAIBJDOAIMD = input.ReadUInt32();
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
          case 10:
          case 8: {
            aHCAJGLIOMJ_.AddEntriesFrom(ref input, _repeated_aHCAJGLIOMJ_codec);
            break;
          }
          case 18: {
            if (lMPBDDDEBLC_ == null) {
              LMPBDDDEBLC = new global::EggLink.DanhengServer.Proto.HHIINBEPCPI();
            }
            input.ReadMessage(LMPBDDDEBLC);
            break;
          }
          case 24: {
            PBAIDONBJEK = input.ReadUInt32();
            break;
          }
          case 32: {
            DLGEKHMIHJK = input.ReadUInt32();
            break;
          }
          case 48: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 72: {
            BIFAOEINIMI = input.ReadUInt32();
            break;
          }
          case 82: {
            hBKBPABJFMP_.AddEntriesFrom(ref input, _repeated_hBKBPABJFMP_codec);
            break;
          }
          case 88: {
            Exp = input.ReadUInt32();
            break;
          }
          case 96: {
            Level = input.ReadUInt32();
            break;
          }
          case 112: {
            GAIBJDOAIMD = input.ReadUInt32();
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