// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SwapLineupCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SwapLineupCsReq.proto</summary>
  public static partial class SwapLineupCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for SwapLineupCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SwapLineupCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVTd2FwTGluZXVwQ3NSZXEucHJvdG8aFUV4dHJhTGluZXVwVHlwZS5wcm90",
            "byKdAQoPU3dhcExpbmV1cENzUmVxEhAKCHBsYW5lX2lkGAggASgNEhMKC0pJ",
            "UERHR0pGS0NIGAogASgNEg0KBWluZGV4GAsgASgNEhMKC0NPSUdHSURFQ05P",
            "GAEgASgNEhIKCmlzX3ZpcnR1YWwYDSABKAgSKwoRZXh0cmFfbGluZXVwX3R5",
            "cGUYDCABKA4yEC5FeHRyYUxpbmV1cFR5cGVCHqoCG0VnZ0xpbmsuRGFuaGVu",
            "Z1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ExtraLineupTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SwapLineupCsReq), global::EggLink.DanhengServer.Proto.SwapLineupCsReq.Parser, new[]{ "PlaneId", "JIPDGGJFKCH", "Index", "COIGGIDECNO", "IsVirtual", "ExtraLineupType" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SwapLineupCsReq : pb::IMessage<SwapLineupCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SwapLineupCsReq> _parser = new pb::MessageParser<SwapLineupCsReq>(() => new SwapLineupCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SwapLineupCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.SwapLineupCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SwapLineupCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SwapLineupCsReq(SwapLineupCsReq other) : this() {
      planeId_ = other.planeId_;
      jIPDGGJFKCH_ = other.jIPDGGJFKCH_;
      index_ = other.index_;
      cOIGGIDECNO_ = other.cOIGGIDECNO_;
      isVirtual_ = other.isVirtual_;
      extraLineupType_ = other.extraLineupType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SwapLineupCsReq Clone() {
      return new SwapLineupCsReq(this);
    }

    /// <summary>Field number for the "plane_id" field.</summary>
    public const int PlaneIdFieldNumber = 8;
    private uint planeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PlaneId {
      get { return planeId_; }
      set {
        planeId_ = value;
      }
    }

    /// <summary>Field number for the "JIPDGGJFKCH" field.</summary>
    public const int JIPDGGJFKCHFieldNumber = 10;
    private uint jIPDGGJFKCH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint JIPDGGJFKCH {
      get { return jIPDGGJFKCH_; }
      set {
        jIPDGGJFKCH_ = value;
      }
    }

    /// <summary>Field number for the "index" field.</summary>
    public const int IndexFieldNumber = 11;
    private uint index_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Index {
      get { return index_; }
      set {
        index_ = value;
      }
    }

    /// <summary>Field number for the "COIGGIDECNO" field.</summary>
    public const int COIGGIDECNOFieldNumber = 1;
    private uint cOIGGIDECNO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint COIGGIDECNO {
      get { return cOIGGIDECNO_; }
      set {
        cOIGGIDECNO_ = value;
      }
    }

    /// <summary>Field number for the "is_virtual" field.</summary>
    public const int IsVirtualFieldNumber = 13;
    private bool isVirtual_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsVirtual {
      get { return isVirtual_; }
      set {
        isVirtual_ = value;
      }
    }

    /// <summary>Field number for the "extra_lineup_type" field.</summary>
    public const int ExtraLineupTypeFieldNumber = 12;
    private global::EggLink.DanhengServer.Proto.ExtraLineupType extraLineupType_ = global::EggLink.DanhengServer.Proto.ExtraLineupType.LineupNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ExtraLineupType ExtraLineupType {
      get { return extraLineupType_; }
      set {
        extraLineupType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SwapLineupCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SwapLineupCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PlaneId != other.PlaneId) return false;
      if (JIPDGGJFKCH != other.JIPDGGJFKCH) return false;
      if (Index != other.Index) return false;
      if (COIGGIDECNO != other.COIGGIDECNO) return false;
      if (IsVirtual != other.IsVirtual) return false;
      if (ExtraLineupType != other.ExtraLineupType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (PlaneId != 0) hash ^= PlaneId.GetHashCode();
      if (JIPDGGJFKCH != 0) hash ^= JIPDGGJFKCH.GetHashCode();
      if (Index != 0) hash ^= Index.GetHashCode();
      if (COIGGIDECNO != 0) hash ^= COIGGIDECNO.GetHashCode();
      if (IsVirtual != false) hash ^= IsVirtual.GetHashCode();
      if (ExtraLineupType != global::EggLink.DanhengServer.Proto.ExtraLineupType.LineupNone) hash ^= ExtraLineupType.GetHashCode();
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
      if (COIGGIDECNO != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(COIGGIDECNO);
      }
      if (PlaneId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(PlaneId);
      }
      if (JIPDGGJFKCH != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(JIPDGGJFKCH);
      }
      if (Index != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Index);
      }
      if (ExtraLineupType != global::EggLink.DanhengServer.Proto.ExtraLineupType.LineupNone) {
        output.WriteRawTag(96);
        output.WriteEnum((int) ExtraLineupType);
      }
      if (IsVirtual != false) {
        output.WriteRawTag(104);
        output.WriteBool(IsVirtual);
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
      if (COIGGIDECNO != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(COIGGIDECNO);
      }
      if (PlaneId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(PlaneId);
      }
      if (JIPDGGJFKCH != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(JIPDGGJFKCH);
      }
      if (Index != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Index);
      }
      if (ExtraLineupType != global::EggLink.DanhengServer.Proto.ExtraLineupType.LineupNone) {
        output.WriteRawTag(96);
        output.WriteEnum((int) ExtraLineupType);
      }
      if (IsVirtual != false) {
        output.WriteRawTag(104);
        output.WriteBool(IsVirtual);
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
      if (PlaneId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PlaneId);
      }
      if (JIPDGGJFKCH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(JIPDGGJFKCH);
      }
      if (Index != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Index);
      }
      if (COIGGIDECNO != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(COIGGIDECNO);
      }
      if (IsVirtual != false) {
        size += 1 + 1;
      }
      if (ExtraLineupType != global::EggLink.DanhengServer.Proto.ExtraLineupType.LineupNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ExtraLineupType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SwapLineupCsReq other) {
      if (other == null) {
        return;
      }
      if (other.PlaneId != 0) {
        PlaneId = other.PlaneId;
      }
      if (other.JIPDGGJFKCH != 0) {
        JIPDGGJFKCH = other.JIPDGGJFKCH;
      }
      if (other.Index != 0) {
        Index = other.Index;
      }
      if (other.COIGGIDECNO != 0) {
        COIGGIDECNO = other.COIGGIDECNO;
      }
      if (other.IsVirtual != false) {
        IsVirtual = other.IsVirtual;
      }
      if (other.ExtraLineupType != global::EggLink.DanhengServer.Proto.ExtraLineupType.LineupNone) {
        ExtraLineupType = other.ExtraLineupType;
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
            COIGGIDECNO = input.ReadUInt32();
            break;
          }
          case 64: {
            PlaneId = input.ReadUInt32();
            break;
          }
          case 80: {
            JIPDGGJFKCH = input.ReadUInt32();
            break;
          }
          case 88: {
            Index = input.ReadUInt32();
            break;
          }
          case 96: {
            ExtraLineupType = (global::EggLink.DanhengServer.Proto.ExtraLineupType) input.ReadEnum();
            break;
          }
          case 104: {
            IsVirtual = input.ReadBool();
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
            COIGGIDECNO = input.ReadUInt32();
            break;
          }
          case 64: {
            PlaneId = input.ReadUInt32();
            break;
          }
          case 80: {
            JIPDGGJFKCH = input.ReadUInt32();
            break;
          }
          case 88: {
            Index = input.ReadUInt32();
            break;
          }
          case 96: {
            ExtraLineupType = (global::EggLink.DanhengServer.Proto.ExtraLineupType) input.ReadEnum();
            break;
          }
          case 104: {
            IsVirtual = input.ReadBool();
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