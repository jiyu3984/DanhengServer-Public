// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FightActivityDataChangeScNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from FightActivityDataChangeScNotify.proto</summary>
  public static partial class FightActivityDataChangeScNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for FightActivityDataChangeScNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FightActivityDataChangeScNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVGaWdodEFjdGl2aXR5RGF0YUNoYW5nZVNjTm90aWZ5LnByb3RvGhhGaWdo",
            "dEFjdGl2aXR5R3JvdXAucHJvdG8ixwEKH0ZpZ2h0QWN0aXZpdHlEYXRhQ2hh",
            "bmdlU2NOb3RpZnkSRgoLS0hHQkdMTEdCRkUYDSADKAsyMS5GaWdodEFjdGl2",
            "aXR5RGF0YUNoYW5nZVNjTm90aWZ5LktIR0JHTExHQkZFRW50cnkSKAoLRUJL",
            "RU1JRUpNS00YBiADKAsyEy5GaWdodEFjdGl2aXR5R3JvdXAaMgoQS0hHQkdM",
            "TEdCRkVFbnRyeRILCgNrZXkYASABKA0SDQoFdmFsdWUYAiABKA06AjgBQh6q",
            "AhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.FightActivityGroupReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.FightActivityDataChangeScNotify), global::EggLink.DanhengServer.Proto.FightActivityDataChangeScNotify.Parser, new[]{ "KHGBGLLGBFE", "EBKEMIEJMKM" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class FightActivityDataChangeScNotify : pb::IMessage<FightActivityDataChangeScNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FightActivityDataChangeScNotify> _parser = new pb::MessageParser<FightActivityDataChangeScNotify>(() => new FightActivityDataChangeScNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FightActivityDataChangeScNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.FightActivityDataChangeScNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FightActivityDataChangeScNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FightActivityDataChangeScNotify(FightActivityDataChangeScNotify other) : this() {
      kHGBGLLGBFE_ = other.kHGBGLLGBFE_.Clone();
      eBKEMIEJMKM_ = other.eBKEMIEJMKM_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FightActivityDataChangeScNotify Clone() {
      return new FightActivityDataChangeScNotify(this);
    }

    /// <summary>Field number for the "KHGBGLLGBFE" field.</summary>
    public const int KHGBGLLGBFEFieldNumber = 13;
    private static readonly pbc::MapField<uint, uint>.Codec _map_kHGBGLLGBFE_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 106);
    private readonly pbc::MapField<uint, uint> kHGBGLLGBFE_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> KHGBGLLGBFE {
      get { return kHGBGLLGBFE_; }
    }

    /// <summary>Field number for the "EBKEMIEJMKM" field.</summary>
    public const int EBKEMIEJMKMFieldNumber = 6;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.FightActivityGroup> _repeated_eBKEMIEJMKM_codec
        = pb::FieldCodec.ForMessage(50, global::EggLink.DanhengServer.Proto.FightActivityGroup.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.FightActivityGroup> eBKEMIEJMKM_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.FightActivityGroup>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.FightActivityGroup> EBKEMIEJMKM {
      get { return eBKEMIEJMKM_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FightActivityDataChangeScNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FightActivityDataChangeScNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!KHGBGLLGBFE.Equals(other.KHGBGLLGBFE)) return false;
      if(!eBKEMIEJMKM_.Equals(other.eBKEMIEJMKM_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= KHGBGLLGBFE.GetHashCode();
      hash ^= eBKEMIEJMKM_.GetHashCode();
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
      eBKEMIEJMKM_.WriteTo(output, _repeated_eBKEMIEJMKM_codec);
      kHGBGLLGBFE_.WriteTo(output, _map_kHGBGLLGBFE_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      eBKEMIEJMKM_.WriteTo(ref output, _repeated_eBKEMIEJMKM_codec);
      kHGBGLLGBFE_.WriteTo(ref output, _map_kHGBGLLGBFE_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += kHGBGLLGBFE_.CalculateSize(_map_kHGBGLLGBFE_codec);
      size += eBKEMIEJMKM_.CalculateSize(_repeated_eBKEMIEJMKM_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FightActivityDataChangeScNotify other) {
      if (other == null) {
        return;
      }
      kHGBGLLGBFE_.MergeFrom(other.kHGBGLLGBFE_);
      eBKEMIEJMKM_.Add(other.eBKEMIEJMKM_);
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
            eBKEMIEJMKM_.AddEntriesFrom(input, _repeated_eBKEMIEJMKM_codec);
            break;
          }
          case 106: {
            kHGBGLLGBFE_.AddEntriesFrom(input, _map_kHGBGLLGBFE_codec);
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
            eBKEMIEJMKM_.AddEntriesFrom(ref input, _repeated_eBKEMIEJMKM_codec);
            break;
          }
          case 106: {
            kHGBGLLGBFE_.AddEntriesFrom(ref input, _map_kHGBGLLGBFE_codec);
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
