// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PHBMAJPCNLB.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from PHBMAJPCNLB.proto</summary>
  public static partial class PHBMAJPCNLBReflection {

    #region Descriptor
    /// <summary>File descriptor for PHBMAJPCNLB.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PHBMAJPCNLBReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFQSEJNQUpQQ05MQi5wcm90bxoRRUJPSU9JS0ZMRkoucHJvdG8iRQoLUEhC",
            "TUFKUENOTEISIQoLT0FLTkdOS0FMUEkYDyABKAsyDC5FQk9JT0lLRkxGShIT",
            "CgtPT0RQQktESkFGRRgDIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVy",
            "LlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.EBOIOIKFLFJReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.PHBMAJPCNLB), global::EggLink.DanhengServer.Proto.PHBMAJPCNLB.Parser, new[]{ "OAKNGNKALPI", "OODPBKDJAFE" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class PHBMAJPCNLB : pb::IMessage<PHBMAJPCNLB>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PHBMAJPCNLB> _parser = new pb::MessageParser<PHBMAJPCNLB>(() => new PHBMAJPCNLB());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PHBMAJPCNLB> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.PHBMAJPCNLBReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PHBMAJPCNLB() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PHBMAJPCNLB(PHBMAJPCNLB other) : this() {
      oAKNGNKALPI_ = other.oAKNGNKALPI_ != null ? other.oAKNGNKALPI_.Clone() : null;
      oODPBKDJAFE_ = other.oODPBKDJAFE_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PHBMAJPCNLB Clone() {
      return new PHBMAJPCNLB(this);
    }

    /// <summary>Field number for the "OAKNGNKALPI" field.</summary>
    public const int OAKNGNKALPIFieldNumber = 15;
    private global::EggLink.DanhengServer.Proto.EBOIOIKFLFJ oAKNGNKALPI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.EBOIOIKFLFJ OAKNGNKALPI {
      get { return oAKNGNKALPI_; }
      set {
        oAKNGNKALPI_ = value;
      }
    }

    /// <summary>Field number for the "OODPBKDJAFE" field.</summary>
    public const int OODPBKDJAFEFieldNumber = 3;
    private uint oODPBKDJAFE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OODPBKDJAFE {
      get { return oODPBKDJAFE_; }
      set {
        oODPBKDJAFE_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PHBMAJPCNLB);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PHBMAJPCNLB other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(OAKNGNKALPI, other.OAKNGNKALPI)) return false;
      if (OODPBKDJAFE != other.OODPBKDJAFE) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (oAKNGNKALPI_ != null) hash ^= OAKNGNKALPI.GetHashCode();
      if (OODPBKDJAFE != 0) hash ^= OODPBKDJAFE.GetHashCode();
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
      if (OODPBKDJAFE != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(OODPBKDJAFE);
      }
      if (oAKNGNKALPI_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(OAKNGNKALPI);
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
      if (OODPBKDJAFE != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(OODPBKDJAFE);
      }
      if (oAKNGNKALPI_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(OAKNGNKALPI);
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
      if (oAKNGNKALPI_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(OAKNGNKALPI);
      }
      if (OODPBKDJAFE != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OODPBKDJAFE);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PHBMAJPCNLB other) {
      if (other == null) {
        return;
      }
      if (other.oAKNGNKALPI_ != null) {
        if (oAKNGNKALPI_ == null) {
          OAKNGNKALPI = new global::EggLink.DanhengServer.Proto.EBOIOIKFLFJ();
        }
        OAKNGNKALPI.MergeFrom(other.OAKNGNKALPI);
      }
      if (other.OODPBKDJAFE != 0) {
        OODPBKDJAFE = other.OODPBKDJAFE;
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
          case 24: {
            OODPBKDJAFE = input.ReadUInt32();
            break;
          }
          case 122: {
            if (oAKNGNKALPI_ == null) {
              OAKNGNKALPI = new global::EggLink.DanhengServer.Proto.EBOIOIKFLFJ();
            }
            input.ReadMessage(OAKNGNKALPI);
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
          case 24: {
            OODPBKDJAFE = input.ReadUInt32();
            break;
          }
          case 122: {
            if (oAKNGNKALPI_ == null) {
              OAKNGNKALPI = new global::EggLink.DanhengServer.Proto.EBOIOIKFLFJ();
            }
            input.ReadMessage(OAKNGNKALPI);
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
