// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BLBALBLMNHF.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from BLBALBLMNHF.proto</summary>
  public static partial class BLBALBLMNHFReflection {

    #region Descriptor
    /// <summary>File descriptor for BLBALBLMNHF.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BLBALBLMNHFReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFCTEJBTEJMTU5IRi5wcm90bxocUm9ndWVNYWdpY0dhbWVVbml0SW5mby5w",
            "cm90byJaCgtCTEJBTEJMTU5IRhIzChJzZWxlY3RfbWFnaWNfdW5pdHMYASAD",
            "KAsyFy5Sb2d1ZU1hZ2ljR2FtZVVuaXRJbmZvEhYKDnNlbGVjdF9oaW50X2lk",
            "GAIgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueMagicGameUnitInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.BLBALBLMNHF), global::EggLink.DanhengServer.Proto.BLBALBLMNHF.Parser, new[]{ "SelectMagicUnits", "SelectHintId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class BLBALBLMNHF : pb::IMessage<BLBALBLMNHF>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BLBALBLMNHF> _parser = new pb::MessageParser<BLBALBLMNHF>(() => new BLBALBLMNHF());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BLBALBLMNHF> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.BLBALBLMNHFReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BLBALBLMNHF() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BLBALBLMNHF(BLBALBLMNHF other) : this() {
      selectMagicUnits_ = other.selectMagicUnits_.Clone();
      selectHintId_ = other.selectHintId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BLBALBLMNHF Clone() {
      return new BLBALBLMNHF(this);
    }

    /// <summary>Field number for the "select_magic_units" field.</summary>
    public const int SelectMagicUnitsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.RogueMagicGameUnitInfo> _repeated_selectMagicUnits_codec
        = pb::FieldCodec.ForMessage(10, global::EggLink.DanhengServer.Proto.RogueMagicGameUnitInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueMagicGameUnitInfo> selectMagicUnits_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueMagicGameUnitInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueMagicGameUnitInfo> SelectMagicUnits {
      get { return selectMagicUnits_; }
    }

    /// <summary>Field number for the "select_hint_id" field.</summary>
    public const int SelectHintIdFieldNumber = 2;
    private uint selectHintId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SelectHintId {
      get { return selectHintId_; }
      set {
        selectHintId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BLBALBLMNHF);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BLBALBLMNHF other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!selectMagicUnits_.Equals(other.selectMagicUnits_)) return false;
      if (SelectHintId != other.SelectHintId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= selectMagicUnits_.GetHashCode();
      if (SelectHintId != 0) hash ^= SelectHintId.GetHashCode();
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
      selectMagicUnits_.WriteTo(output, _repeated_selectMagicUnits_codec);
      if (SelectHintId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(SelectHintId);
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
      selectMagicUnits_.WriteTo(ref output, _repeated_selectMagicUnits_codec);
      if (SelectHintId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(SelectHintId);
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
      size += selectMagicUnits_.CalculateSize(_repeated_selectMagicUnits_codec);
      if (SelectHintId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SelectHintId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BLBALBLMNHF other) {
      if (other == null) {
        return;
      }
      selectMagicUnits_.Add(other.selectMagicUnits_);
      if (other.SelectHintId != 0) {
        SelectHintId = other.SelectHintId;
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
            selectMagicUnits_.AddEntriesFrom(input, _repeated_selectMagicUnits_codec);
            break;
          }
          case 16: {
            SelectHintId = input.ReadUInt32();
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
            selectMagicUnits_.AddEntriesFrom(ref input, _repeated_selectMagicUnits_codec);
            break;
          }
          case 16: {
            SelectHintId = input.ReadUInt32();
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