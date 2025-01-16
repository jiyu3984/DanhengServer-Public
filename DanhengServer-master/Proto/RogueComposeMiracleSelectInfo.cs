// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueComposeMiracleSelectInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueComposeMiracleSelectInfo.proto</summary>
  public static partial class RogueComposeMiracleSelectInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueComposeMiracleSelectInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueComposeMiracleSelectInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNSb2d1ZUNvbXBvc2VNaXJhY2xlU2VsZWN0SW5mby5wcm90byJMCh1Sb2d1",
            "ZUNvbXBvc2VNaXJhY2xlU2VsZWN0SW5mbxIWCg5zZWxlY3RfaGludF9pZBgP",
            "IAEoDRITCgtQQU1BUEFHQkJKRhgNIAMoDUIeqgIbRWdnTGluay5EYW5oZW5n",
            "U2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueComposeMiracleSelectInfo), global::EggLink.DanhengServer.Proto.RogueComposeMiracleSelectInfo.Parser, new[]{ "SelectHintId", "PAMAPAGBBJF" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueComposeMiracleSelectInfo : pb::IMessage<RogueComposeMiracleSelectInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueComposeMiracleSelectInfo> _parser = new pb::MessageParser<RogueComposeMiracleSelectInfo>(() => new RogueComposeMiracleSelectInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueComposeMiracleSelectInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueComposeMiracleSelectInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueComposeMiracleSelectInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueComposeMiracleSelectInfo(RogueComposeMiracleSelectInfo other) : this() {
      selectHintId_ = other.selectHintId_;
      pAMAPAGBBJF_ = other.pAMAPAGBBJF_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueComposeMiracleSelectInfo Clone() {
      return new RogueComposeMiracleSelectInfo(this);
    }

    /// <summary>Field number for the "select_hint_id" field.</summary>
    public const int SelectHintIdFieldNumber = 15;
    private uint selectHintId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SelectHintId {
      get { return selectHintId_; }
      set {
        selectHintId_ = value;
      }
    }

    /// <summary>Field number for the "PAMAPAGBBJF" field.</summary>
    public const int PAMAPAGBBJFFieldNumber = 13;
    private static readonly pb::FieldCodec<uint> _repeated_pAMAPAGBBJF_codec
        = pb::FieldCodec.ForUInt32(106);
    private readonly pbc::RepeatedField<uint> pAMAPAGBBJF_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> PAMAPAGBBJF {
      get { return pAMAPAGBBJF_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueComposeMiracleSelectInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueComposeMiracleSelectInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SelectHintId != other.SelectHintId) return false;
      if(!pAMAPAGBBJF_.Equals(other.pAMAPAGBBJF_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (SelectHintId != 0) hash ^= SelectHintId.GetHashCode();
      hash ^= pAMAPAGBBJF_.GetHashCode();
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
      pAMAPAGBBJF_.WriteTo(output, _repeated_pAMAPAGBBJF_codec);
      if (SelectHintId != 0) {
        output.WriteRawTag(120);
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
      pAMAPAGBBJF_.WriteTo(ref output, _repeated_pAMAPAGBBJF_codec);
      if (SelectHintId != 0) {
        output.WriteRawTag(120);
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
      if (SelectHintId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SelectHintId);
      }
      size += pAMAPAGBBJF_.CalculateSize(_repeated_pAMAPAGBBJF_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueComposeMiracleSelectInfo other) {
      if (other == null) {
        return;
      }
      if (other.SelectHintId != 0) {
        SelectHintId = other.SelectHintId;
      }
      pAMAPAGBBJF_.Add(other.pAMAPAGBBJF_);
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
          case 106:
          case 104: {
            pAMAPAGBBJF_.AddEntriesFrom(input, _repeated_pAMAPAGBBJF_codec);
            break;
          }
          case 120: {
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
          case 106:
          case 104: {
            pAMAPAGBBJF_.AddEntriesFrom(ref input, _repeated_pAMAPAGBBJF_codec);
            break;
          }
          case 120: {
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
