// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetBigDataRecommendScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetBigDataRecommendScRsp.proto</summary>
  public static partial class GetBigDataRecommendScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetBigDataRecommendScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetBigDataRecommendScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5HZXRCaWdEYXRhUmVjb21tZW5kU2NSc3AucHJvdG8aEUJITk5FR0lCQ01P",
            "LnByb3RvGhFMRUVCSEhLRUVIRy5wcm90bxoRSkhJUEdQR0hITUcucHJvdG8i",
            "4AEKGEdldEJpZ0RhdGFSZWNvbW1lbmRTY1JzcBIPCgdyZXRjb2RlGA0gASgN",
            "EhMKC0pMTkhIRE5MQ0dOGAYgASgNEiIKGlJPR1VFX1RBTEVOVF9TVEFUVVNf",
            "RU5BQkxFGA8gASgIEiEKC0pDSUZOT0xEQ0dFGAsgASgOMgwuSkhJUEdQR0hI",
            "TUcSIwoLR0JPUENCT09QS08YCCABKAsyDC5CSE5ORUdJQkNNT0gAEiMKC0tD",
            "SUpLRUVBREpKGAUgASgLMgwuTEVFQkhIS0VFSEdIAEINCgtCTklFREZCRkdI",
            "Q0IeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.BHNNEGIBCMOReflection.Descriptor, global::EggLink.DanhengServer.Proto.LEEBHHKEEHGReflection.Descriptor, global::EggLink.DanhengServer.Proto.JHIPGPGHHMGReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetBigDataRecommendScRsp), global::EggLink.DanhengServer.Proto.GetBigDataRecommendScRsp.Parser, new[]{ "Retcode", "JLNHHDNLCGN", "ROGUETALENTSTATUSENABLE", "JCIFNOLDCGE", "GBOPCBOOPKO", "KCIJKEEADJJ" }, new[]{ "BNIEDFBFGHC" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetBigDataRecommendScRsp : pb::IMessage<GetBigDataRecommendScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetBigDataRecommendScRsp> _parser = new pb::MessageParser<GetBigDataRecommendScRsp>(() => new GetBigDataRecommendScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetBigDataRecommendScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetBigDataRecommendScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetBigDataRecommendScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetBigDataRecommendScRsp(GetBigDataRecommendScRsp other) : this() {
      retcode_ = other.retcode_;
      jLNHHDNLCGN_ = other.jLNHHDNLCGN_;
      rOGUETALENTSTATUSENABLE_ = other.rOGUETALENTSTATUSENABLE_;
      jCIFNOLDCGE_ = other.jCIFNOLDCGE_;
      switch (other.BNIEDFBFGHCCase) {
        case BNIEDFBFGHCOneofCase.GBOPCBOOPKO:
          GBOPCBOOPKO = other.GBOPCBOOPKO.Clone();
          break;
        case BNIEDFBFGHCOneofCase.KCIJKEEADJJ:
          KCIJKEEADJJ = other.KCIJKEEADJJ.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetBigDataRecommendScRsp Clone() {
      return new GetBigDataRecommendScRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 13;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "JLNHHDNLCGN" field.</summary>
    public const int JLNHHDNLCGNFieldNumber = 6;
    private uint jLNHHDNLCGN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint JLNHHDNLCGN {
      get { return jLNHHDNLCGN_; }
      set {
        jLNHHDNLCGN_ = value;
      }
    }

    /// <summary>Field number for the "ROGUE_TALENT_STATUS_ENABLE" field.</summary>
    public const int ROGUETALENTSTATUSENABLEFieldNumber = 15;
    private bool rOGUETALENTSTATUSENABLE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool ROGUETALENTSTATUSENABLE {
      get { return rOGUETALENTSTATUSENABLE_; }
      set {
        rOGUETALENTSTATUSENABLE_ = value;
      }
    }

    /// <summary>Field number for the "JCIFNOLDCGE" field.</summary>
    public const int JCIFNOLDCGEFieldNumber = 11;
    private global::EggLink.DanhengServer.Proto.JHIPGPGHHMG jCIFNOLDCGE_ = global::EggLink.DanhengServer.Proto.JHIPGPGHHMG.BigDataRecommendTypeNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.JHIPGPGHHMG JCIFNOLDCGE {
      get { return jCIFNOLDCGE_; }
      set {
        jCIFNOLDCGE_ = value;
      }
    }

    /// <summary>Field number for the "GBOPCBOOPKO" field.</summary>
    public const int GBOPCBOOPKOFieldNumber = 8;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.BHNNEGIBCMO GBOPCBOOPKO {
      get { return bNIEDFBFGHCCase_ == BNIEDFBFGHCOneofCase.GBOPCBOOPKO ? (global::EggLink.DanhengServer.Proto.BHNNEGIBCMO) bNIEDFBFGHC_ : null; }
      set {
        bNIEDFBFGHC_ = value;
        bNIEDFBFGHCCase_ = value == null ? BNIEDFBFGHCOneofCase.None : BNIEDFBFGHCOneofCase.GBOPCBOOPKO;
      }
    }

    /// <summary>Field number for the "KCIJKEEADJJ" field.</summary>
    public const int KCIJKEEADJJFieldNumber = 5;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.LEEBHHKEEHG KCIJKEEADJJ {
      get { return bNIEDFBFGHCCase_ == BNIEDFBFGHCOneofCase.KCIJKEEADJJ ? (global::EggLink.DanhengServer.Proto.LEEBHHKEEHG) bNIEDFBFGHC_ : null; }
      set {
        bNIEDFBFGHC_ = value;
        bNIEDFBFGHCCase_ = value == null ? BNIEDFBFGHCOneofCase.None : BNIEDFBFGHCOneofCase.KCIJKEEADJJ;
      }
    }

    private object bNIEDFBFGHC_;
    /// <summary>Enum of possible cases for the "BNIEDFBFGHC" oneof.</summary>
    public enum BNIEDFBFGHCOneofCase {
      None = 0,
      GBOPCBOOPKO = 8,
      KCIJKEEADJJ = 5,
    }
    private BNIEDFBFGHCOneofCase bNIEDFBFGHCCase_ = BNIEDFBFGHCOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BNIEDFBFGHCOneofCase BNIEDFBFGHCCase {
      get { return bNIEDFBFGHCCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearBNIEDFBFGHC() {
      bNIEDFBFGHCCase_ = BNIEDFBFGHCOneofCase.None;
      bNIEDFBFGHC_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetBigDataRecommendScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetBigDataRecommendScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (JLNHHDNLCGN != other.JLNHHDNLCGN) return false;
      if (ROGUETALENTSTATUSENABLE != other.ROGUETALENTSTATUSENABLE) return false;
      if (JCIFNOLDCGE != other.JCIFNOLDCGE) return false;
      if (!object.Equals(GBOPCBOOPKO, other.GBOPCBOOPKO)) return false;
      if (!object.Equals(KCIJKEEADJJ, other.KCIJKEEADJJ)) return false;
      if (BNIEDFBFGHCCase != other.BNIEDFBFGHCCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (JLNHHDNLCGN != 0) hash ^= JLNHHDNLCGN.GetHashCode();
      if (ROGUETALENTSTATUSENABLE != false) hash ^= ROGUETALENTSTATUSENABLE.GetHashCode();
      if (JCIFNOLDCGE != global::EggLink.DanhengServer.Proto.JHIPGPGHHMG.BigDataRecommendTypeNone) hash ^= JCIFNOLDCGE.GetHashCode();
      if (bNIEDFBFGHCCase_ == BNIEDFBFGHCOneofCase.GBOPCBOOPKO) hash ^= GBOPCBOOPKO.GetHashCode();
      if (bNIEDFBFGHCCase_ == BNIEDFBFGHCOneofCase.KCIJKEEADJJ) hash ^= KCIJKEEADJJ.GetHashCode();
      hash ^= (int) bNIEDFBFGHCCase_;
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
      if (bNIEDFBFGHCCase_ == BNIEDFBFGHCOneofCase.KCIJKEEADJJ) {
        output.WriteRawTag(42);
        output.WriteMessage(KCIJKEEADJJ);
      }
      if (JLNHHDNLCGN != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(JLNHHDNLCGN);
      }
      if (bNIEDFBFGHCCase_ == BNIEDFBFGHCOneofCase.GBOPCBOOPKO) {
        output.WriteRawTag(66);
        output.WriteMessage(GBOPCBOOPKO);
      }
      if (JCIFNOLDCGE != global::EggLink.DanhengServer.Proto.JHIPGPGHHMG.BigDataRecommendTypeNone) {
        output.WriteRawTag(88);
        output.WriteEnum((int) JCIFNOLDCGE);
      }
      if (Retcode != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Retcode);
      }
      if (ROGUETALENTSTATUSENABLE != false) {
        output.WriteRawTag(120);
        output.WriteBool(ROGUETALENTSTATUSENABLE);
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
      if (bNIEDFBFGHCCase_ == BNIEDFBFGHCOneofCase.KCIJKEEADJJ) {
        output.WriteRawTag(42);
        output.WriteMessage(KCIJKEEADJJ);
      }
      if (JLNHHDNLCGN != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(JLNHHDNLCGN);
      }
      if (bNIEDFBFGHCCase_ == BNIEDFBFGHCOneofCase.GBOPCBOOPKO) {
        output.WriteRawTag(66);
        output.WriteMessage(GBOPCBOOPKO);
      }
      if (JCIFNOLDCGE != global::EggLink.DanhengServer.Proto.JHIPGPGHHMG.BigDataRecommendTypeNone) {
        output.WriteRawTag(88);
        output.WriteEnum((int) JCIFNOLDCGE);
      }
      if (Retcode != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Retcode);
      }
      if (ROGUETALENTSTATUSENABLE != false) {
        output.WriteRawTag(120);
        output.WriteBool(ROGUETALENTSTATUSENABLE);
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
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (JLNHHDNLCGN != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(JLNHHDNLCGN);
      }
      if (ROGUETALENTSTATUSENABLE != false) {
        size += 1 + 1;
      }
      if (JCIFNOLDCGE != global::EggLink.DanhengServer.Proto.JHIPGPGHHMG.BigDataRecommendTypeNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) JCIFNOLDCGE);
      }
      if (bNIEDFBFGHCCase_ == BNIEDFBFGHCOneofCase.GBOPCBOOPKO) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GBOPCBOOPKO);
      }
      if (bNIEDFBFGHCCase_ == BNIEDFBFGHCOneofCase.KCIJKEEADJJ) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(KCIJKEEADJJ);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetBigDataRecommendScRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.JLNHHDNLCGN != 0) {
        JLNHHDNLCGN = other.JLNHHDNLCGN;
      }
      if (other.ROGUETALENTSTATUSENABLE != false) {
        ROGUETALENTSTATUSENABLE = other.ROGUETALENTSTATUSENABLE;
      }
      if (other.JCIFNOLDCGE != global::EggLink.DanhengServer.Proto.JHIPGPGHHMG.BigDataRecommendTypeNone) {
        JCIFNOLDCGE = other.JCIFNOLDCGE;
      }
      switch (other.BNIEDFBFGHCCase) {
        case BNIEDFBFGHCOneofCase.GBOPCBOOPKO:
          if (GBOPCBOOPKO == null) {
            GBOPCBOOPKO = new global::EggLink.DanhengServer.Proto.BHNNEGIBCMO();
          }
          GBOPCBOOPKO.MergeFrom(other.GBOPCBOOPKO);
          break;
        case BNIEDFBFGHCOneofCase.KCIJKEEADJJ:
          if (KCIJKEEADJJ == null) {
            KCIJKEEADJJ = new global::EggLink.DanhengServer.Proto.LEEBHHKEEHG();
          }
          KCIJKEEADJJ.MergeFrom(other.KCIJKEEADJJ);
          break;
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
          case 42: {
            global::EggLink.DanhengServer.Proto.LEEBHHKEEHG subBuilder = new global::EggLink.DanhengServer.Proto.LEEBHHKEEHG();
            if (bNIEDFBFGHCCase_ == BNIEDFBFGHCOneofCase.KCIJKEEADJJ) {
              subBuilder.MergeFrom(KCIJKEEADJJ);
            }
            input.ReadMessage(subBuilder);
            KCIJKEEADJJ = subBuilder;
            break;
          }
          case 48: {
            JLNHHDNLCGN = input.ReadUInt32();
            break;
          }
          case 66: {
            global::EggLink.DanhengServer.Proto.BHNNEGIBCMO subBuilder = new global::EggLink.DanhengServer.Proto.BHNNEGIBCMO();
            if (bNIEDFBFGHCCase_ == BNIEDFBFGHCOneofCase.GBOPCBOOPKO) {
              subBuilder.MergeFrom(GBOPCBOOPKO);
            }
            input.ReadMessage(subBuilder);
            GBOPCBOOPKO = subBuilder;
            break;
          }
          case 88: {
            JCIFNOLDCGE = (global::EggLink.DanhengServer.Proto.JHIPGPGHHMG) input.ReadEnum();
            break;
          }
          case 104: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 120: {
            ROGUETALENTSTATUSENABLE = input.ReadBool();
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
          case 42: {
            global::EggLink.DanhengServer.Proto.LEEBHHKEEHG subBuilder = new global::EggLink.DanhengServer.Proto.LEEBHHKEEHG();
            if (bNIEDFBFGHCCase_ == BNIEDFBFGHCOneofCase.KCIJKEEADJJ) {
              subBuilder.MergeFrom(KCIJKEEADJJ);
            }
            input.ReadMessage(subBuilder);
            KCIJKEEADJJ = subBuilder;
            break;
          }
          case 48: {
            JLNHHDNLCGN = input.ReadUInt32();
            break;
          }
          case 66: {
            global::EggLink.DanhengServer.Proto.BHNNEGIBCMO subBuilder = new global::EggLink.DanhengServer.Proto.BHNNEGIBCMO();
            if (bNIEDFBFGHCCase_ == BNIEDFBFGHCOneofCase.GBOPCBOOPKO) {
              subBuilder.MergeFrom(GBOPCBOOPKO);
            }
            input.ReadMessage(subBuilder);
            GBOPCBOOPKO = subBuilder;
            break;
          }
          case 88: {
            JCIFNOLDCGE = (global::EggLink.DanhengServer.Proto.JHIPGPGHHMG) input.ReadEnum();
            break;
          }
          case 104: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 120: {
            ROGUETALENTSTATUSENABLE = input.ReadBool();
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