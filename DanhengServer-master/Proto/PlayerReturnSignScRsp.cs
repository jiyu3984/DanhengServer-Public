// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerReturnSignScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from PlayerReturnSignScRsp.proto</summary>
  public static partial class PlayerReturnSignScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerReturnSignScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerReturnSignScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtQbGF5ZXJSZXR1cm5TaWduU2NSc3AucHJvdG8aDkl0ZW1MaXN0LnByb3Rv",
            "InIKFVBsYXllclJldHVyblNpZ25TY1JzcBIeCgtJSExFQ0RGSE1GSRgEIAMo",
            "CzIJLkl0ZW1MaXN0EhMKC0lLRU9PSE5HTU9OGA4gASgNEg8KB3JldGNvZGUY",
            "CCABKA0SEwoLRUxETkNEQkJFTUEYDyADKA1CHqoCG0VnZ0xpbmsuRGFuaGVu",
            "Z1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ItemListReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.PlayerReturnSignScRsp), global::EggLink.DanhengServer.Proto.PlayerReturnSignScRsp.Parser, new[]{ "IHLECDFHMFI", "IKEOOHNGMON", "Retcode", "ELDNCDBBEMA" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class PlayerReturnSignScRsp : pb::IMessage<PlayerReturnSignScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerReturnSignScRsp> _parser = new pb::MessageParser<PlayerReturnSignScRsp>(() => new PlayerReturnSignScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerReturnSignScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.PlayerReturnSignScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerReturnSignScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerReturnSignScRsp(PlayerReturnSignScRsp other) : this() {
      iHLECDFHMFI_ = other.iHLECDFHMFI_.Clone();
      iKEOOHNGMON_ = other.iKEOOHNGMON_;
      retcode_ = other.retcode_;
      eLDNCDBBEMA_ = other.eLDNCDBBEMA_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerReturnSignScRsp Clone() {
      return new PlayerReturnSignScRsp(this);
    }

    /// <summary>Field number for the "IHLECDFHMFI" field.</summary>
    public const int IHLECDFHMFIFieldNumber = 4;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.ItemList> _repeated_iHLECDFHMFI_codec
        = pb::FieldCodec.ForMessage(34, global::EggLink.DanhengServer.Proto.ItemList.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ItemList> iHLECDFHMFI_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ItemList>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ItemList> IHLECDFHMFI {
      get { return iHLECDFHMFI_; }
    }

    /// <summary>Field number for the "IKEOOHNGMON" field.</summary>
    public const int IKEOOHNGMONFieldNumber = 14;
    private uint iKEOOHNGMON_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint IKEOOHNGMON {
      get { return iKEOOHNGMON_; }
      set {
        iKEOOHNGMON_ = value;
      }
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

    /// <summary>Field number for the "ELDNCDBBEMA" field.</summary>
    public const int ELDNCDBBEMAFieldNumber = 15;
    private static readonly pb::FieldCodec<uint> _repeated_eLDNCDBBEMA_codec
        = pb::FieldCodec.ForUInt32(122);
    private readonly pbc::RepeatedField<uint> eLDNCDBBEMA_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> ELDNCDBBEMA {
      get { return eLDNCDBBEMA_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerReturnSignScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerReturnSignScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!iHLECDFHMFI_.Equals(other.iHLECDFHMFI_)) return false;
      if (IKEOOHNGMON != other.IKEOOHNGMON) return false;
      if (Retcode != other.Retcode) return false;
      if(!eLDNCDBBEMA_.Equals(other.eLDNCDBBEMA_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= iHLECDFHMFI_.GetHashCode();
      if (IKEOOHNGMON != 0) hash ^= IKEOOHNGMON.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      hash ^= eLDNCDBBEMA_.GetHashCode();
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
      iHLECDFHMFI_.WriteTo(output, _repeated_iHLECDFHMFI_codec);
      if (Retcode != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Retcode);
      }
      if (IKEOOHNGMON != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(IKEOOHNGMON);
      }
      eLDNCDBBEMA_.WriteTo(output, _repeated_eLDNCDBBEMA_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      iHLECDFHMFI_.WriteTo(ref output, _repeated_iHLECDFHMFI_codec);
      if (Retcode != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Retcode);
      }
      if (IKEOOHNGMON != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(IKEOOHNGMON);
      }
      eLDNCDBBEMA_.WriteTo(ref output, _repeated_eLDNCDBBEMA_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += iHLECDFHMFI_.CalculateSize(_repeated_iHLECDFHMFI_codec);
      if (IKEOOHNGMON != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(IKEOOHNGMON);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      size += eLDNCDBBEMA_.CalculateSize(_repeated_eLDNCDBBEMA_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerReturnSignScRsp other) {
      if (other == null) {
        return;
      }
      iHLECDFHMFI_.Add(other.iHLECDFHMFI_);
      if (other.IKEOOHNGMON != 0) {
        IKEOOHNGMON = other.IKEOOHNGMON;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      eLDNCDBBEMA_.Add(other.eLDNCDBBEMA_);
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
          case 34: {
            iHLECDFHMFI_.AddEntriesFrom(input, _repeated_iHLECDFHMFI_codec);
            break;
          }
          case 64: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 112: {
            IKEOOHNGMON = input.ReadUInt32();
            break;
          }
          case 122:
          case 120: {
            eLDNCDBBEMA_.AddEntriesFrom(input, _repeated_eLDNCDBBEMA_codec);
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
          case 34: {
            iHLECDFHMFI_.AddEntriesFrom(ref input, _repeated_iHLECDFHMFI_codec);
            break;
          }
          case 64: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 112: {
            IKEOOHNGMON = input.ReadUInt32();
            break;
          }
          case 122:
          case 120: {
            eLDNCDBBEMA_.AddEntriesFrom(ref input, _repeated_eLDNCDBBEMA_codec);
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