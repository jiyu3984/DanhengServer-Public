// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChessRogueModifierInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ChessRogueModifierInfo.proto</summary>
  public static partial class ChessRogueModifierInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for ChessRogueModifierInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChessRogueModifierInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxDaGVzc1JvZ3VlTW9kaWZpZXJJbmZvLnByb3RvImcKFkNoZXNzUm9ndWVN",
            "b2RpZmllckluZm8SFgoOc2VsZWN0X2NlbGxfaWQYDyABKA0SJAocbW9kaWZp",
            "ZXJfZWZmZWN0X2NlbGxfaWRfbGlzdBgBIAMoDRIPCgdjb25maXJtGAogASgI",
            "Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ChessRogueModifierInfo), global::EggLink.DanhengServer.Proto.ChessRogueModifierInfo.Parser, new[]{ "SelectCellId", "ModifierEffectCellIdList", "Confirm" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ChessRogueModifierInfo : pb::IMessage<ChessRogueModifierInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChessRogueModifierInfo> _parser = new pb::MessageParser<ChessRogueModifierInfo>(() => new ChessRogueModifierInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChessRogueModifierInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ChessRogueModifierInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueModifierInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueModifierInfo(ChessRogueModifierInfo other) : this() {
      selectCellId_ = other.selectCellId_;
      modifierEffectCellIdList_ = other.modifierEffectCellIdList_.Clone();
      confirm_ = other.confirm_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueModifierInfo Clone() {
      return new ChessRogueModifierInfo(this);
    }

    /// <summary>Field number for the "select_cell_id" field.</summary>
    public const int SelectCellIdFieldNumber = 15;
    private uint selectCellId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SelectCellId {
      get { return selectCellId_; }
      set {
        selectCellId_ = value;
      }
    }

    /// <summary>Field number for the "modifier_effect_cell_id_list" field.</summary>
    public const int ModifierEffectCellIdListFieldNumber = 1;
    private static readonly pb::FieldCodec<uint> _repeated_modifierEffectCellIdList_codec
        = pb::FieldCodec.ForUInt32(10);
    private readonly pbc::RepeatedField<uint> modifierEffectCellIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> ModifierEffectCellIdList {
      get { return modifierEffectCellIdList_; }
    }

    /// <summary>Field number for the "confirm" field.</summary>
    public const int ConfirmFieldNumber = 10;
    private bool confirm_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Confirm {
      get { return confirm_; }
      set {
        confirm_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChessRogueModifierInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChessRogueModifierInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SelectCellId != other.SelectCellId) return false;
      if(!modifierEffectCellIdList_.Equals(other.modifierEffectCellIdList_)) return false;
      if (Confirm != other.Confirm) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (SelectCellId != 0) hash ^= SelectCellId.GetHashCode();
      hash ^= modifierEffectCellIdList_.GetHashCode();
      if (Confirm != false) hash ^= Confirm.GetHashCode();
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
      modifierEffectCellIdList_.WriteTo(output, _repeated_modifierEffectCellIdList_codec);
      if (Confirm != false) {
        output.WriteRawTag(80);
        output.WriteBool(Confirm);
      }
      if (SelectCellId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(SelectCellId);
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
      modifierEffectCellIdList_.WriteTo(ref output, _repeated_modifierEffectCellIdList_codec);
      if (Confirm != false) {
        output.WriteRawTag(80);
        output.WriteBool(Confirm);
      }
      if (SelectCellId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(SelectCellId);
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
      if (SelectCellId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SelectCellId);
      }
      size += modifierEffectCellIdList_.CalculateSize(_repeated_modifierEffectCellIdList_codec);
      if (Confirm != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChessRogueModifierInfo other) {
      if (other == null) {
        return;
      }
      if (other.SelectCellId != 0) {
        SelectCellId = other.SelectCellId;
      }
      modifierEffectCellIdList_.Add(other.modifierEffectCellIdList_);
      if (other.Confirm != false) {
        Confirm = other.Confirm;
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
            modifierEffectCellIdList_.AddEntriesFrom(input, _repeated_modifierEffectCellIdList_codec);
            break;
          }
          case 80: {
            Confirm = input.ReadBool();
            break;
          }
          case 120: {
            SelectCellId = input.ReadUInt32();
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
            modifierEffectCellIdList_.AddEntriesFrom(ref input, _repeated_modifierEffectCellIdList_codec);
            break;
          }
          case 80: {
            Confirm = input.ReadBool();
            break;
          }
          case 120: {
            SelectCellId = input.ReadUInt32();
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