// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MonopolyActionResult.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from MonopolyActionResult.proto</summary>
  public static partial class MonopolyActionResultReflection {

    #region Descriptor
    /// <summary>File descriptor for MonopolyActionResult.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MonopolyActionResultReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpNb25vcG9seUFjdGlvblJlc3VsdC5wcm90bxoRTE1FSEFDQUpGQUMucHJv",
            "dG8aEUJFQUVQQVBHSExQLnByb3RvIsoBChRNb25vcG9seUFjdGlvblJlc3Vs",
            "dBIXCg90cmlnZ2VyX2NlbGxfaWQYASABKA0SFAoMY2xpY2tfbWFwX2lkGAgg",
            "ASgNEhMKC2VmZmVjdF90eXBlGA4gASgNEhwKBmRldGFpbBgDIAEoCzIMLkJF",
            "QUVQQVBHSExQEiEKC3NvdXJjZV90eXBlGAYgASgOMgwuTE1FSEFDQUpGQUMS",
            "FQoNY2xpY2tfY2VsbF9pZBgMIAEoDRIWCg50cmlnZ2VyX21hcF9pZBgPIAEo",
            "DUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.LMEHACAJFACReflection.Descriptor, global::EggLink.DanhengServer.Proto.BEAEPAPGHLPReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.MonopolyActionResult), global::EggLink.DanhengServer.Proto.MonopolyActionResult.Parser, new[]{ "TriggerCellId", "ClickMapId", "EffectType", "Detail", "SourceType", "ClickCellId", "TriggerMapId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class MonopolyActionResult : pb::IMessage<MonopolyActionResult>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MonopolyActionResult> _parser = new pb::MessageParser<MonopolyActionResult>(() => new MonopolyActionResult());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MonopolyActionResult> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.MonopolyActionResultReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MonopolyActionResult() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MonopolyActionResult(MonopolyActionResult other) : this() {
      triggerCellId_ = other.triggerCellId_;
      clickMapId_ = other.clickMapId_;
      effectType_ = other.effectType_;
      detail_ = other.detail_ != null ? other.detail_.Clone() : null;
      sourceType_ = other.sourceType_;
      clickCellId_ = other.clickCellId_;
      triggerMapId_ = other.triggerMapId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MonopolyActionResult Clone() {
      return new MonopolyActionResult(this);
    }

    /// <summary>Field number for the "trigger_cell_id" field.</summary>
    public const int TriggerCellIdFieldNumber = 1;
    private uint triggerCellId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TriggerCellId {
      get { return triggerCellId_; }
      set {
        triggerCellId_ = value;
      }
    }

    /// <summary>Field number for the "click_map_id" field.</summary>
    public const int ClickMapIdFieldNumber = 8;
    private uint clickMapId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ClickMapId {
      get { return clickMapId_; }
      set {
        clickMapId_ = value;
      }
    }

    /// <summary>Field number for the "effect_type" field.</summary>
    public const int EffectTypeFieldNumber = 14;
    private uint effectType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EffectType {
      get { return effectType_; }
      set {
        effectType_ = value;
      }
    }

    /// <summary>Field number for the "detail" field.</summary>
    public const int DetailFieldNumber = 3;
    private global::EggLink.DanhengServer.Proto.BEAEPAPGHLP detail_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.BEAEPAPGHLP Detail {
      get { return detail_; }
      set {
        detail_ = value;
      }
    }

    /// <summary>Field number for the "source_type" field.</summary>
    public const int SourceTypeFieldNumber = 6;
    private global::EggLink.DanhengServer.Proto.LMEHACAJFAC sourceType_ = global::EggLink.DanhengServer.Proto.LMEHACAJFAC.MonopolyActionResultSourceTypeNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.LMEHACAJFAC SourceType {
      get { return sourceType_; }
      set {
        sourceType_ = value;
      }
    }

    /// <summary>Field number for the "click_cell_id" field.</summary>
    public const int ClickCellIdFieldNumber = 12;
    private uint clickCellId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ClickCellId {
      get { return clickCellId_; }
      set {
        clickCellId_ = value;
      }
    }

    /// <summary>Field number for the "trigger_map_id" field.</summary>
    public const int TriggerMapIdFieldNumber = 15;
    private uint triggerMapId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TriggerMapId {
      get { return triggerMapId_; }
      set {
        triggerMapId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MonopolyActionResult);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MonopolyActionResult other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (TriggerCellId != other.TriggerCellId) return false;
      if (ClickMapId != other.ClickMapId) return false;
      if (EffectType != other.EffectType) return false;
      if (!object.Equals(Detail, other.Detail)) return false;
      if (SourceType != other.SourceType) return false;
      if (ClickCellId != other.ClickCellId) return false;
      if (TriggerMapId != other.TriggerMapId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (TriggerCellId != 0) hash ^= TriggerCellId.GetHashCode();
      if (ClickMapId != 0) hash ^= ClickMapId.GetHashCode();
      if (EffectType != 0) hash ^= EffectType.GetHashCode();
      if (detail_ != null) hash ^= Detail.GetHashCode();
      if (SourceType != global::EggLink.DanhengServer.Proto.LMEHACAJFAC.MonopolyActionResultSourceTypeNone) hash ^= SourceType.GetHashCode();
      if (ClickCellId != 0) hash ^= ClickCellId.GetHashCode();
      if (TriggerMapId != 0) hash ^= TriggerMapId.GetHashCode();
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
      if (TriggerCellId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(TriggerCellId);
      }
      if (detail_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Detail);
      }
      if (SourceType != global::EggLink.DanhengServer.Proto.LMEHACAJFAC.MonopolyActionResultSourceTypeNone) {
        output.WriteRawTag(48);
        output.WriteEnum((int) SourceType);
      }
      if (ClickMapId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(ClickMapId);
      }
      if (ClickCellId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(ClickCellId);
      }
      if (EffectType != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(EffectType);
      }
      if (TriggerMapId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(TriggerMapId);
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
      if (TriggerCellId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(TriggerCellId);
      }
      if (detail_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Detail);
      }
      if (SourceType != global::EggLink.DanhengServer.Proto.LMEHACAJFAC.MonopolyActionResultSourceTypeNone) {
        output.WriteRawTag(48);
        output.WriteEnum((int) SourceType);
      }
      if (ClickMapId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(ClickMapId);
      }
      if (ClickCellId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(ClickCellId);
      }
      if (EffectType != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(EffectType);
      }
      if (TriggerMapId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(TriggerMapId);
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
      if (TriggerCellId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TriggerCellId);
      }
      if (ClickMapId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ClickMapId);
      }
      if (EffectType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EffectType);
      }
      if (detail_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Detail);
      }
      if (SourceType != global::EggLink.DanhengServer.Proto.LMEHACAJFAC.MonopolyActionResultSourceTypeNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) SourceType);
      }
      if (ClickCellId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ClickCellId);
      }
      if (TriggerMapId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TriggerMapId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MonopolyActionResult other) {
      if (other == null) {
        return;
      }
      if (other.TriggerCellId != 0) {
        TriggerCellId = other.TriggerCellId;
      }
      if (other.ClickMapId != 0) {
        ClickMapId = other.ClickMapId;
      }
      if (other.EffectType != 0) {
        EffectType = other.EffectType;
      }
      if (other.detail_ != null) {
        if (detail_ == null) {
          Detail = new global::EggLink.DanhengServer.Proto.BEAEPAPGHLP();
        }
        Detail.MergeFrom(other.Detail);
      }
      if (other.SourceType != global::EggLink.DanhengServer.Proto.LMEHACAJFAC.MonopolyActionResultSourceTypeNone) {
        SourceType = other.SourceType;
      }
      if (other.ClickCellId != 0) {
        ClickCellId = other.ClickCellId;
      }
      if (other.TriggerMapId != 0) {
        TriggerMapId = other.TriggerMapId;
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
          case 8: {
            TriggerCellId = input.ReadUInt32();
            break;
          }
          case 26: {
            if (detail_ == null) {
              Detail = new global::EggLink.DanhengServer.Proto.BEAEPAPGHLP();
            }
            input.ReadMessage(Detail);
            break;
          }
          case 48: {
            SourceType = (global::EggLink.DanhengServer.Proto.LMEHACAJFAC) input.ReadEnum();
            break;
          }
          case 64: {
            ClickMapId = input.ReadUInt32();
            break;
          }
          case 96: {
            ClickCellId = input.ReadUInt32();
            break;
          }
          case 112: {
            EffectType = input.ReadUInt32();
            break;
          }
          case 120: {
            TriggerMapId = input.ReadUInt32();
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
          case 8: {
            TriggerCellId = input.ReadUInt32();
            break;
          }
          case 26: {
            if (detail_ == null) {
              Detail = new global::EggLink.DanhengServer.Proto.BEAEPAPGHLP();
            }
            input.ReadMessage(Detail);
            break;
          }
          case 48: {
            SourceType = (global::EggLink.DanhengServer.Proto.LMEHACAJFAC) input.ReadEnum();
            break;
          }
          case 64: {
            ClickMapId = input.ReadUInt32();
            break;
          }
          case 96: {
            ClickCellId = input.ReadUInt32();
            break;
          }
          case 112: {
            EffectType = input.ReadUInt32();
            break;
          }
          case 120: {
            TriggerMapId = input.ReadUInt32();
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
