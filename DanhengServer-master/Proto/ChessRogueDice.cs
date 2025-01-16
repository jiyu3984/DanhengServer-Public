// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChessRogueDice.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ChessRogueDice.proto</summary>
  public static partial class ChessRogueDiceReflection {

    #region Descriptor
    /// <summary>File descriptor for ChessRogueDice.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChessRogueDiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRDaGVzc1JvZ3VlRGljZS5wcm90bxofQ2hlc3NSb2d1ZURpY2VTdXJmYWNl",
            "SW5mby5wcm90byJ/Cg5DaGVzc1JvZ3VlRGljZRITCgtMT01FQ0tQRU5DRRgL",
            "IAEoDRITCgtOTUlQRUVESE1NRBgIIAEoDRIwCgxzdXJmYWNlX2xpc3QYDCAD",
            "KAsyGi5DaGVzc1JvZ3VlRGljZVN1cmZhY2VJbmZvEhEKCWJyYW5jaF9pZBgD",
            "IAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ChessRogueDiceSurfaceInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ChessRogueDice), global::EggLink.DanhengServer.Proto.ChessRogueDice.Parser, new[]{ "LOMECKPENCE", "NMIPEEDHMMD", "SurfaceList", "BranchId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ChessRogueDice : pb::IMessage<ChessRogueDice>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChessRogueDice> _parser = new pb::MessageParser<ChessRogueDice>(() => new ChessRogueDice());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChessRogueDice> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ChessRogueDiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueDice() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueDice(ChessRogueDice other) : this() {
      lOMECKPENCE_ = other.lOMECKPENCE_;
      nMIPEEDHMMD_ = other.nMIPEEDHMMD_;
      surfaceList_ = other.surfaceList_.Clone();
      branchId_ = other.branchId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueDice Clone() {
      return new ChessRogueDice(this);
    }

    /// <summary>Field number for the "LOMECKPENCE" field.</summary>
    public const int LOMECKPENCEFieldNumber = 11;
    private uint lOMECKPENCE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LOMECKPENCE {
      get { return lOMECKPENCE_; }
      set {
        lOMECKPENCE_ = value;
      }
    }

    /// <summary>Field number for the "NMIPEEDHMMD" field.</summary>
    public const int NMIPEEDHMMDFieldNumber = 8;
    private uint nMIPEEDHMMD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NMIPEEDHMMD {
      get { return nMIPEEDHMMD_; }
      set {
        nMIPEEDHMMD_ = value;
      }
    }

    /// <summary>Field number for the "surface_list" field.</summary>
    public const int SurfaceListFieldNumber = 12;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.ChessRogueDiceSurfaceInfo> _repeated_surfaceList_codec
        = pb::FieldCodec.ForMessage(98, global::EggLink.DanhengServer.Proto.ChessRogueDiceSurfaceInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ChessRogueDiceSurfaceInfo> surfaceList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ChessRogueDiceSurfaceInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ChessRogueDiceSurfaceInfo> SurfaceList {
      get { return surfaceList_; }
    }

    /// <summary>Field number for the "branch_id" field.</summary>
    public const int BranchIdFieldNumber = 3;
    private uint branchId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BranchId {
      get { return branchId_; }
      set {
        branchId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChessRogueDice);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChessRogueDice other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (LOMECKPENCE != other.LOMECKPENCE) return false;
      if (NMIPEEDHMMD != other.NMIPEEDHMMD) return false;
      if(!surfaceList_.Equals(other.surfaceList_)) return false;
      if (BranchId != other.BranchId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (LOMECKPENCE != 0) hash ^= LOMECKPENCE.GetHashCode();
      if (NMIPEEDHMMD != 0) hash ^= NMIPEEDHMMD.GetHashCode();
      hash ^= surfaceList_.GetHashCode();
      if (BranchId != 0) hash ^= BranchId.GetHashCode();
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
      if (BranchId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(BranchId);
      }
      if (NMIPEEDHMMD != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(NMIPEEDHMMD);
      }
      if (LOMECKPENCE != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(LOMECKPENCE);
      }
      surfaceList_.WriteTo(output, _repeated_surfaceList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (BranchId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(BranchId);
      }
      if (NMIPEEDHMMD != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(NMIPEEDHMMD);
      }
      if (LOMECKPENCE != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(LOMECKPENCE);
      }
      surfaceList_.WriteTo(ref output, _repeated_surfaceList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (LOMECKPENCE != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LOMECKPENCE);
      }
      if (NMIPEEDHMMD != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NMIPEEDHMMD);
      }
      size += surfaceList_.CalculateSize(_repeated_surfaceList_codec);
      if (BranchId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BranchId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChessRogueDice other) {
      if (other == null) {
        return;
      }
      if (other.LOMECKPENCE != 0) {
        LOMECKPENCE = other.LOMECKPENCE;
      }
      if (other.NMIPEEDHMMD != 0) {
        NMIPEEDHMMD = other.NMIPEEDHMMD;
      }
      surfaceList_.Add(other.surfaceList_);
      if (other.BranchId != 0) {
        BranchId = other.BranchId;
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
            BranchId = input.ReadUInt32();
            break;
          }
          case 64: {
            NMIPEEDHMMD = input.ReadUInt32();
            break;
          }
          case 88: {
            LOMECKPENCE = input.ReadUInt32();
            break;
          }
          case 98: {
            surfaceList_.AddEntriesFrom(input, _repeated_surfaceList_codec);
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
            BranchId = input.ReadUInt32();
            break;
          }
          case 64: {
            NMIPEEDHMMD = input.ReadUInt32();
            break;
          }
          case 88: {
            LOMECKPENCE = input.ReadUInt32();
            break;
          }
          case 98: {
            surfaceList_.AddEntriesFrom(ref input, _repeated_surfaceList_codec);
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
