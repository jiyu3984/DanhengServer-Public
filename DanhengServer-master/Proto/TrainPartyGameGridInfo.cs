// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TrainPartyGameGridInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from TrainPartyGameGridInfo.proto</summary>
  public static partial class TrainPartyGameGridInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for TrainPartyGameGridInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TrainPartyGameGridInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxUcmFpblBhcnR5R2FtZUdyaWRJbmZvLnByb3RvGhFCSUdIRURBTUlMTC5w",
            "cm90bxoYVHJhaW5QYXJ0eUdhbWVHcmlkLnByb3RvIo0BChZUcmFpblBhcnR5",
            "R2FtZUdyaWRJbmZvEhMKC0FCS0VKTUZDRERDGAIgASgNEiYKCWdyaWRfbGlz",
            "dBgKIAMoCzITLlRyYWluUGFydHlHYW1lR3JpZBIhCgtNSExCQ0tEQ0JPQxgI",
            "IAEoCzIMLkJJR0hFREFNSUxMEhMKC0hORUtDQU9KRE5BGAwgASgNQh6qAhtF",
            "Z2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.BIGHEDAMILLReflection.Descriptor, global::EggLink.DanhengServer.Proto.TrainPartyGameGridReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.TrainPartyGameGridInfo), global::EggLink.DanhengServer.Proto.TrainPartyGameGridInfo.Parser, new[]{ "ABKEJMFCDDC", "GridList", "MHLBCKDCBOC", "HNEKCAOJDNA" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class TrainPartyGameGridInfo : pb::IMessage<TrainPartyGameGridInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TrainPartyGameGridInfo> _parser = new pb::MessageParser<TrainPartyGameGridInfo>(() => new TrainPartyGameGridInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TrainPartyGameGridInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.TrainPartyGameGridInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TrainPartyGameGridInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TrainPartyGameGridInfo(TrainPartyGameGridInfo other) : this() {
      aBKEJMFCDDC_ = other.aBKEJMFCDDC_;
      gridList_ = other.gridList_.Clone();
      mHLBCKDCBOC_ = other.mHLBCKDCBOC_ != null ? other.mHLBCKDCBOC_.Clone() : null;
      hNEKCAOJDNA_ = other.hNEKCAOJDNA_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TrainPartyGameGridInfo Clone() {
      return new TrainPartyGameGridInfo(this);
    }

    /// <summary>Field number for the "ABKEJMFCDDC" field.</summary>
    public const int ABKEJMFCDDCFieldNumber = 2;
    private uint aBKEJMFCDDC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ABKEJMFCDDC {
      get { return aBKEJMFCDDC_; }
      set {
        aBKEJMFCDDC_ = value;
      }
    }

    /// <summary>Field number for the "grid_list" field.</summary>
    public const int GridListFieldNumber = 10;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.TrainPartyGameGrid> _repeated_gridList_codec
        = pb::FieldCodec.ForMessage(82, global::EggLink.DanhengServer.Proto.TrainPartyGameGrid.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.TrainPartyGameGrid> gridList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.TrainPartyGameGrid>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.TrainPartyGameGrid> GridList {
      get { return gridList_; }
    }

    /// <summary>Field number for the "MHLBCKDCBOC" field.</summary>
    public const int MHLBCKDCBOCFieldNumber = 8;
    private global::EggLink.DanhengServer.Proto.BIGHEDAMILL mHLBCKDCBOC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.BIGHEDAMILL MHLBCKDCBOC {
      get { return mHLBCKDCBOC_; }
      set {
        mHLBCKDCBOC_ = value;
      }
    }

    /// <summary>Field number for the "HNEKCAOJDNA" field.</summary>
    public const int HNEKCAOJDNAFieldNumber = 12;
    private uint hNEKCAOJDNA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HNEKCAOJDNA {
      get { return hNEKCAOJDNA_; }
      set {
        hNEKCAOJDNA_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TrainPartyGameGridInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TrainPartyGameGridInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ABKEJMFCDDC != other.ABKEJMFCDDC) return false;
      if(!gridList_.Equals(other.gridList_)) return false;
      if (!object.Equals(MHLBCKDCBOC, other.MHLBCKDCBOC)) return false;
      if (HNEKCAOJDNA != other.HNEKCAOJDNA) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ABKEJMFCDDC != 0) hash ^= ABKEJMFCDDC.GetHashCode();
      hash ^= gridList_.GetHashCode();
      if (mHLBCKDCBOC_ != null) hash ^= MHLBCKDCBOC.GetHashCode();
      if (HNEKCAOJDNA != 0) hash ^= HNEKCAOJDNA.GetHashCode();
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
      if (ABKEJMFCDDC != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(ABKEJMFCDDC);
      }
      if (mHLBCKDCBOC_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(MHLBCKDCBOC);
      }
      gridList_.WriteTo(output, _repeated_gridList_codec);
      if (HNEKCAOJDNA != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(HNEKCAOJDNA);
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
      if (ABKEJMFCDDC != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(ABKEJMFCDDC);
      }
      if (mHLBCKDCBOC_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(MHLBCKDCBOC);
      }
      gridList_.WriteTo(ref output, _repeated_gridList_codec);
      if (HNEKCAOJDNA != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(HNEKCAOJDNA);
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
      if (ABKEJMFCDDC != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ABKEJMFCDDC);
      }
      size += gridList_.CalculateSize(_repeated_gridList_codec);
      if (mHLBCKDCBOC_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MHLBCKDCBOC);
      }
      if (HNEKCAOJDNA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HNEKCAOJDNA);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TrainPartyGameGridInfo other) {
      if (other == null) {
        return;
      }
      if (other.ABKEJMFCDDC != 0) {
        ABKEJMFCDDC = other.ABKEJMFCDDC;
      }
      gridList_.Add(other.gridList_);
      if (other.mHLBCKDCBOC_ != null) {
        if (mHLBCKDCBOC_ == null) {
          MHLBCKDCBOC = new global::EggLink.DanhengServer.Proto.BIGHEDAMILL();
        }
        MHLBCKDCBOC.MergeFrom(other.MHLBCKDCBOC);
      }
      if (other.HNEKCAOJDNA != 0) {
        HNEKCAOJDNA = other.HNEKCAOJDNA;
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
          case 16: {
            ABKEJMFCDDC = input.ReadUInt32();
            break;
          }
          case 66: {
            if (mHLBCKDCBOC_ == null) {
              MHLBCKDCBOC = new global::EggLink.DanhengServer.Proto.BIGHEDAMILL();
            }
            input.ReadMessage(MHLBCKDCBOC);
            break;
          }
          case 82: {
            gridList_.AddEntriesFrom(input, _repeated_gridList_codec);
            break;
          }
          case 96: {
            HNEKCAOJDNA = input.ReadUInt32();
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
          case 16: {
            ABKEJMFCDDC = input.ReadUInt32();
            break;
          }
          case 66: {
            if (mHLBCKDCBOC_ == null) {
              MHLBCKDCBOC = new global::EggLink.DanhengServer.Proto.BIGHEDAMILL();
            }
            input.ReadMessage(MHLBCKDCBOC);
            break;
          }
          case 82: {
            gridList_.AddEntriesFrom(ref input, _repeated_gridList_codec);
            break;
          }
          case 96: {
            HNEKCAOJDNA = input.ReadUInt32();
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
