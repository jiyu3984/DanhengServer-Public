// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ALAICPOOMMG.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ALAICPOOMMG.proto</summary>
  public static partial class ALAICPOOMMGReflection {

    #region Descriptor
    /// <summary>File descriptor for ALAICPOOMMG.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ALAICPOOMMGReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFBTEFJQ1BPT01NRy5wcm90byJdCgtBTEFJQ1BPT01NRxIQCghwYW5lbF9p",
            "ZBgIIAEoDRITCgtCSUpNRU9PREZHThgCIAEoDRITCgtLSU1IUE1MRE1BSRgF",
            "IAEoDRISCgpkdXJhYmlsaXR5GA8gASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdT",
            "ZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ALAICPOOMMG), global::EggLink.DanhengServer.Proto.ALAICPOOMMG.Parser, new[]{ "PanelId", "BIJMEOODFGN", "KIMHPMLDMAI", "Durability" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ALAICPOOMMG : pb::IMessage<ALAICPOOMMG>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ALAICPOOMMG> _parser = new pb::MessageParser<ALAICPOOMMG>(() => new ALAICPOOMMG());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ALAICPOOMMG> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ALAICPOOMMGReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ALAICPOOMMG() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ALAICPOOMMG(ALAICPOOMMG other) : this() {
      panelId_ = other.panelId_;
      bIJMEOODFGN_ = other.bIJMEOODFGN_;
      kIMHPMLDMAI_ = other.kIMHPMLDMAI_;
      durability_ = other.durability_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ALAICPOOMMG Clone() {
      return new ALAICPOOMMG(this);
    }

    /// <summary>Field number for the "panel_id" field.</summary>
    public const int PanelIdFieldNumber = 8;
    private uint panelId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PanelId {
      get { return panelId_; }
      set {
        panelId_ = value;
      }
    }

    /// <summary>Field number for the "BIJMEOODFGN" field.</summary>
    public const int BIJMEOODFGNFieldNumber = 2;
    private uint bIJMEOODFGN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BIJMEOODFGN {
      get { return bIJMEOODFGN_; }
      set {
        bIJMEOODFGN_ = value;
      }
    }

    /// <summary>Field number for the "KIMHPMLDMAI" field.</summary>
    public const int KIMHPMLDMAIFieldNumber = 5;
    private uint kIMHPMLDMAI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KIMHPMLDMAI {
      get { return kIMHPMLDMAI_; }
      set {
        kIMHPMLDMAI_ = value;
      }
    }

    /// <summary>Field number for the "durability" field.</summary>
    public const int DurabilityFieldNumber = 15;
    private uint durability_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Durability {
      get { return durability_; }
      set {
        durability_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ALAICPOOMMG);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ALAICPOOMMG other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PanelId != other.PanelId) return false;
      if (BIJMEOODFGN != other.BIJMEOODFGN) return false;
      if (KIMHPMLDMAI != other.KIMHPMLDMAI) return false;
      if (Durability != other.Durability) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (PanelId != 0) hash ^= PanelId.GetHashCode();
      if (BIJMEOODFGN != 0) hash ^= BIJMEOODFGN.GetHashCode();
      if (KIMHPMLDMAI != 0) hash ^= KIMHPMLDMAI.GetHashCode();
      if (Durability != 0) hash ^= Durability.GetHashCode();
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
      if (BIJMEOODFGN != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(BIJMEOODFGN);
      }
      if (KIMHPMLDMAI != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(KIMHPMLDMAI);
      }
      if (PanelId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(PanelId);
      }
      if (Durability != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Durability);
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
      if (BIJMEOODFGN != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(BIJMEOODFGN);
      }
      if (KIMHPMLDMAI != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(KIMHPMLDMAI);
      }
      if (PanelId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(PanelId);
      }
      if (Durability != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Durability);
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
      if (PanelId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PanelId);
      }
      if (BIJMEOODFGN != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BIJMEOODFGN);
      }
      if (KIMHPMLDMAI != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KIMHPMLDMAI);
      }
      if (Durability != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Durability);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ALAICPOOMMG other) {
      if (other == null) {
        return;
      }
      if (other.PanelId != 0) {
        PanelId = other.PanelId;
      }
      if (other.BIJMEOODFGN != 0) {
        BIJMEOODFGN = other.BIJMEOODFGN;
      }
      if (other.KIMHPMLDMAI != 0) {
        KIMHPMLDMAI = other.KIMHPMLDMAI;
      }
      if (other.Durability != 0) {
        Durability = other.Durability;
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
            BIJMEOODFGN = input.ReadUInt32();
            break;
          }
          case 40: {
            KIMHPMLDMAI = input.ReadUInt32();
            break;
          }
          case 64: {
            PanelId = input.ReadUInt32();
            break;
          }
          case 120: {
            Durability = input.ReadUInt32();
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
            BIJMEOODFGN = input.ReadUInt32();
            break;
          }
          case 40: {
            KIMHPMLDMAI = input.ReadUInt32();
            break;
          }
          case 64: {
            PanelId = input.ReadUInt32();
            break;
          }
          case 120: {
            Durability = input.ReadUInt32();
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