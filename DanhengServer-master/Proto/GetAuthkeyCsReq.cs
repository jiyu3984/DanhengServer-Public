// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetAuthkeyCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetAuthkeyCsReq.proto</summary>
  public static partial class GetAuthkeyCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for GetAuthkeyCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetAuthkeyCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVHZXRBdXRoa2V5Q3NSZXEucHJvdG8iUAoPR2V0QXV0aGtleUNzUmVxEhMK",
            "C0lNTEhBS09ET1BEGA8gASgJEhMKC0hEQktKUEFJT0tLGAwgASgNEhMKC0RM",
            "UEhLREJPUEVKGAYgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJv",
            "dG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetAuthkeyCsReq), global::EggLink.DanhengServer.Proto.GetAuthkeyCsReq.Parser, new[]{ "IMLHAKODOPD", "HDBKJPAIOKK", "DLPHKDBOPEJ" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetAuthkeyCsReq : pb::IMessage<GetAuthkeyCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetAuthkeyCsReq> _parser = new pb::MessageParser<GetAuthkeyCsReq>(() => new GetAuthkeyCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetAuthkeyCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetAuthkeyCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetAuthkeyCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetAuthkeyCsReq(GetAuthkeyCsReq other) : this() {
      iMLHAKODOPD_ = other.iMLHAKODOPD_;
      hDBKJPAIOKK_ = other.hDBKJPAIOKK_;
      dLPHKDBOPEJ_ = other.dLPHKDBOPEJ_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetAuthkeyCsReq Clone() {
      return new GetAuthkeyCsReq(this);
    }

    /// <summary>Field number for the "IMLHAKODOPD" field.</summary>
    public const int IMLHAKODOPDFieldNumber = 15;
    private string iMLHAKODOPD_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string IMLHAKODOPD {
      get { return iMLHAKODOPD_; }
      set {
        iMLHAKODOPD_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "HDBKJPAIOKK" field.</summary>
    public const int HDBKJPAIOKKFieldNumber = 12;
    private uint hDBKJPAIOKK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HDBKJPAIOKK {
      get { return hDBKJPAIOKK_; }
      set {
        hDBKJPAIOKK_ = value;
      }
    }

    /// <summary>Field number for the "DLPHKDBOPEJ" field.</summary>
    public const int DLPHKDBOPEJFieldNumber = 6;
    private uint dLPHKDBOPEJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DLPHKDBOPEJ {
      get { return dLPHKDBOPEJ_; }
      set {
        dLPHKDBOPEJ_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetAuthkeyCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetAuthkeyCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IMLHAKODOPD != other.IMLHAKODOPD) return false;
      if (HDBKJPAIOKK != other.HDBKJPAIOKK) return false;
      if (DLPHKDBOPEJ != other.DLPHKDBOPEJ) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IMLHAKODOPD.Length != 0) hash ^= IMLHAKODOPD.GetHashCode();
      if (HDBKJPAIOKK != 0) hash ^= HDBKJPAIOKK.GetHashCode();
      if (DLPHKDBOPEJ != 0) hash ^= DLPHKDBOPEJ.GetHashCode();
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
      if (DLPHKDBOPEJ != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(DLPHKDBOPEJ);
      }
      if (HDBKJPAIOKK != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(HDBKJPAIOKK);
      }
      if (IMLHAKODOPD.Length != 0) {
        output.WriteRawTag(122);
        output.WriteString(IMLHAKODOPD);
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
      if (DLPHKDBOPEJ != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(DLPHKDBOPEJ);
      }
      if (HDBKJPAIOKK != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(HDBKJPAIOKK);
      }
      if (IMLHAKODOPD.Length != 0) {
        output.WriteRawTag(122);
        output.WriteString(IMLHAKODOPD);
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
      if (IMLHAKODOPD.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(IMLHAKODOPD);
      }
      if (HDBKJPAIOKK != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HDBKJPAIOKK);
      }
      if (DLPHKDBOPEJ != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DLPHKDBOPEJ);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetAuthkeyCsReq other) {
      if (other == null) {
        return;
      }
      if (other.IMLHAKODOPD.Length != 0) {
        IMLHAKODOPD = other.IMLHAKODOPD;
      }
      if (other.HDBKJPAIOKK != 0) {
        HDBKJPAIOKK = other.HDBKJPAIOKK;
      }
      if (other.DLPHKDBOPEJ != 0) {
        DLPHKDBOPEJ = other.DLPHKDBOPEJ;
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
          case 48: {
            DLPHKDBOPEJ = input.ReadUInt32();
            break;
          }
          case 96: {
            HDBKJPAIOKK = input.ReadUInt32();
            break;
          }
          case 122: {
            IMLHAKODOPD = input.ReadString();
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
          case 48: {
            DLPHKDBOPEJ = input.ReadUInt32();
            break;
          }
          case 96: {
            HDBKJPAIOKK = input.ReadUInt32();
            break;
          }
          case 122: {
            IMLHAKODOPD = input.ReadString();
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