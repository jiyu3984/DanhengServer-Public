// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TextJoinSaveCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from TextJoinSaveCsReq.proto</summary>
  public static partial class TextJoinSaveCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for TextJoinSaveCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TextJoinSaveCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdUZXh0Sm9pblNhdmVDc1JlcS5wcm90byJbChFUZXh0Sm9pblNhdmVDc1Jl",
            "cRIUCgx0ZXh0X2l0ZW1faWQYBCABKA0SEwoLR01FSUFCSEhHSkgYCyABKAkS",
            "GwoTdGV4dF9pdGVtX2NvbmZpZ19pZBgOIAEoDUIeqgIbRWdnTGluay5EYW5o",
            "ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.TextJoinSaveCsReq), global::EggLink.DanhengServer.Proto.TextJoinSaveCsReq.Parser, new[]{ "TextItemId", "GMEIABHHGJH", "TextItemConfigId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class TextJoinSaveCsReq : pb::IMessage<TextJoinSaveCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TextJoinSaveCsReq> _parser = new pb::MessageParser<TextJoinSaveCsReq>(() => new TextJoinSaveCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TextJoinSaveCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.TextJoinSaveCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TextJoinSaveCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TextJoinSaveCsReq(TextJoinSaveCsReq other) : this() {
      textItemId_ = other.textItemId_;
      gMEIABHHGJH_ = other.gMEIABHHGJH_;
      textItemConfigId_ = other.textItemConfigId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TextJoinSaveCsReq Clone() {
      return new TextJoinSaveCsReq(this);
    }

    /// <summary>Field number for the "text_item_id" field.</summary>
    public const int TextItemIdFieldNumber = 4;
    private uint textItemId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TextItemId {
      get { return textItemId_; }
      set {
        textItemId_ = value;
      }
    }

    /// <summary>Field number for the "GMEIABHHGJH" field.</summary>
    public const int GMEIABHHGJHFieldNumber = 11;
    private string gMEIABHHGJH_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string GMEIABHHGJH {
      get { return gMEIABHHGJH_; }
      set {
        gMEIABHHGJH_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "text_item_config_id" field.</summary>
    public const int TextItemConfigIdFieldNumber = 14;
    private uint textItemConfigId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TextItemConfigId {
      get { return textItemConfigId_; }
      set {
        textItemConfigId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TextJoinSaveCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TextJoinSaveCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (TextItemId != other.TextItemId) return false;
      if (GMEIABHHGJH != other.GMEIABHHGJH) return false;
      if (TextItemConfigId != other.TextItemConfigId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (TextItemId != 0) hash ^= TextItemId.GetHashCode();
      if (GMEIABHHGJH.Length != 0) hash ^= GMEIABHHGJH.GetHashCode();
      if (TextItemConfigId != 0) hash ^= TextItemConfigId.GetHashCode();
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
      if (TextItemId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(TextItemId);
      }
      if (GMEIABHHGJH.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(GMEIABHHGJH);
      }
      if (TextItemConfigId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(TextItemConfigId);
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
      if (TextItemId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(TextItemId);
      }
      if (GMEIABHHGJH.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(GMEIABHHGJH);
      }
      if (TextItemConfigId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(TextItemConfigId);
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
      if (TextItemId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TextItemId);
      }
      if (GMEIABHHGJH.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(GMEIABHHGJH);
      }
      if (TextItemConfigId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TextItemConfigId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TextJoinSaveCsReq other) {
      if (other == null) {
        return;
      }
      if (other.TextItemId != 0) {
        TextItemId = other.TextItemId;
      }
      if (other.GMEIABHHGJH.Length != 0) {
        GMEIABHHGJH = other.GMEIABHHGJH;
      }
      if (other.TextItemConfigId != 0) {
        TextItemConfigId = other.TextItemConfigId;
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
            TextItemId = input.ReadUInt32();
            break;
          }
          case 90: {
            GMEIABHHGJH = input.ReadString();
            break;
          }
          case 112: {
            TextItemConfigId = input.ReadUInt32();
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
            TextItemId = input.ReadUInt32();
            break;
          }
          case 90: {
            GMEIABHHGJH = input.ReadString();
            break;
          }
          case 112: {
            TextItemConfigId = input.ReadUInt32();
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