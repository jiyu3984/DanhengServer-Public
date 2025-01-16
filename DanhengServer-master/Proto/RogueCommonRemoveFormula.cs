// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueCommonRemoveFormula.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueCommonRemoveFormula.proto</summary>
  public static partial class RogueCommonRemoveFormulaReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueCommonRemoveFormula.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueCommonRemoveFormulaReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5Sb2d1ZUNvbW1vblJlbW92ZUZvcm11bGEucHJvdG8aEUZvcm11bGFJbmZv",
            "LnByb3RvIj4KGFJvZ3VlQ29tbW9uUmVtb3ZlRm9ybXVsYRIiCgxmb3JtdWxh",
            "X2luZm8YAiABKAsyDC5Gb3JtdWxhSW5mb0IeqgIbRWdnTGluay5EYW5oZW5n",
            "U2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.FormulaInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueCommonRemoveFormula), global::EggLink.DanhengServer.Proto.RogueCommonRemoveFormula.Parser, new[]{ "FormulaInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueCommonRemoveFormula : pb::IMessage<RogueCommonRemoveFormula>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueCommonRemoveFormula> _parser = new pb::MessageParser<RogueCommonRemoveFormula>(() => new RogueCommonRemoveFormula());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueCommonRemoveFormula> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueCommonRemoveFormulaReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueCommonRemoveFormula() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueCommonRemoveFormula(RogueCommonRemoveFormula other) : this() {
      formulaInfo_ = other.formulaInfo_ != null ? other.formulaInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueCommonRemoveFormula Clone() {
      return new RogueCommonRemoveFormula(this);
    }

    /// <summary>Field number for the "formula_info" field.</summary>
    public const int FormulaInfoFieldNumber = 2;
    private global::EggLink.DanhengServer.Proto.FormulaInfo formulaInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.FormulaInfo FormulaInfo {
      get { return formulaInfo_; }
      set {
        formulaInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueCommonRemoveFormula);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueCommonRemoveFormula other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(FormulaInfo, other.FormulaInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (formulaInfo_ != null) hash ^= FormulaInfo.GetHashCode();
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
      if (formulaInfo_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(FormulaInfo);
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
      if (formulaInfo_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(FormulaInfo);
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
      if (formulaInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FormulaInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueCommonRemoveFormula other) {
      if (other == null) {
        return;
      }
      if (other.formulaInfo_ != null) {
        if (formulaInfo_ == null) {
          FormulaInfo = new global::EggLink.DanhengServer.Proto.FormulaInfo();
        }
        FormulaInfo.MergeFrom(other.FormulaInfo);
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
          case 18: {
            if (formulaInfo_ == null) {
              FormulaInfo = new global::EggLink.DanhengServer.Proto.FormulaInfo();
            }
            input.ReadMessage(FormulaInfo);
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
          case 18: {
            if (formulaInfo_ == null) {
              FormulaInfo = new global::EggLink.DanhengServer.Proto.FormulaInfo();
            }
            input.ReadMessage(FormulaInfo);
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