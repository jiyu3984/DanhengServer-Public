// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerRecordInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from PlayerRecordInfo.proto</summary>
  public static partial class PlayerRecordInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerRecordInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerRecordInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZQbGF5ZXJSZWNvcmRJbmZvLnByb3RvGhpQbGF5ZXJDb2xsZWN0aW9uSW5m",
            "by5wcm90byLqAQoQUGxheWVyUmVjb3JkSW5mbxITCgtKR0tJSkNKUEZBQRgD",
            "IAEoDRIuCg9jb2xsZWN0aW9uX2luZm8YBSABKAsyFS5QbGF5ZXJDb2xsZWN0",
            "aW9uSW5mbxITCgtNTkRKTENNR01IShgNIAEoDRITCgtBQkhHRE1FTUZNQRgK",
            "IAEoDRITCgtFRUtGSk9MREhMSxgIIAEoDRITCgtDUEJCTkpOTU5IRxgPIAEo",
            "DRITCgtCQU5CRExJUEpGUBgHIAEoDRITCgtFQlBER0lGSUNOSBgOIAEoDRIT",
            "CgtBT0RLUE9QSkVBRhgEIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVy",
            "LlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.PlayerCollectionInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.PlayerRecordInfo), global::EggLink.DanhengServer.Proto.PlayerRecordInfo.Parser, new[]{ "JGKIJCJPFAA", "CollectionInfo", "MNDJLCMGMHJ", "ABHGDMEMFMA", "EEKFJOLDHLK", "CPBBNJNMNHG", "BANBDLIPJFP", "EBPDGIFICNH", "AODKPOPJEAF" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class PlayerRecordInfo : pb::IMessage<PlayerRecordInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerRecordInfo> _parser = new pb::MessageParser<PlayerRecordInfo>(() => new PlayerRecordInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerRecordInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.PlayerRecordInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerRecordInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerRecordInfo(PlayerRecordInfo other) : this() {
      jGKIJCJPFAA_ = other.jGKIJCJPFAA_;
      collectionInfo_ = other.collectionInfo_ != null ? other.collectionInfo_.Clone() : null;
      mNDJLCMGMHJ_ = other.mNDJLCMGMHJ_;
      aBHGDMEMFMA_ = other.aBHGDMEMFMA_;
      eEKFJOLDHLK_ = other.eEKFJOLDHLK_;
      cPBBNJNMNHG_ = other.cPBBNJNMNHG_;
      bANBDLIPJFP_ = other.bANBDLIPJFP_;
      eBPDGIFICNH_ = other.eBPDGIFICNH_;
      aODKPOPJEAF_ = other.aODKPOPJEAF_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerRecordInfo Clone() {
      return new PlayerRecordInfo(this);
    }

    /// <summary>Field number for the "JGKIJCJPFAA" field.</summary>
    public const int JGKIJCJPFAAFieldNumber = 3;
    private uint jGKIJCJPFAA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint JGKIJCJPFAA {
      get { return jGKIJCJPFAA_; }
      set {
        jGKIJCJPFAA_ = value;
      }
    }

    /// <summary>Field number for the "collection_info" field.</summary>
    public const int CollectionInfoFieldNumber = 5;
    private global::EggLink.DanhengServer.Proto.PlayerCollectionInfo collectionInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.PlayerCollectionInfo CollectionInfo {
      get { return collectionInfo_; }
      set {
        collectionInfo_ = value;
      }
    }

    /// <summary>Field number for the "MNDJLCMGMHJ" field.</summary>
    public const int MNDJLCMGMHJFieldNumber = 13;
    private uint mNDJLCMGMHJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MNDJLCMGMHJ {
      get { return mNDJLCMGMHJ_; }
      set {
        mNDJLCMGMHJ_ = value;
      }
    }

    /// <summary>Field number for the "ABHGDMEMFMA" field.</summary>
    public const int ABHGDMEMFMAFieldNumber = 10;
    private uint aBHGDMEMFMA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ABHGDMEMFMA {
      get { return aBHGDMEMFMA_; }
      set {
        aBHGDMEMFMA_ = value;
      }
    }

    /// <summary>Field number for the "EEKFJOLDHLK" field.</summary>
    public const int EEKFJOLDHLKFieldNumber = 8;
    private uint eEKFJOLDHLK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EEKFJOLDHLK {
      get { return eEKFJOLDHLK_; }
      set {
        eEKFJOLDHLK_ = value;
      }
    }

    /// <summary>Field number for the "CPBBNJNMNHG" field.</summary>
    public const int CPBBNJNMNHGFieldNumber = 15;
    private uint cPBBNJNMNHG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CPBBNJNMNHG {
      get { return cPBBNJNMNHG_; }
      set {
        cPBBNJNMNHG_ = value;
      }
    }

    /// <summary>Field number for the "BANBDLIPJFP" field.</summary>
    public const int BANBDLIPJFPFieldNumber = 7;
    private uint bANBDLIPJFP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BANBDLIPJFP {
      get { return bANBDLIPJFP_; }
      set {
        bANBDLIPJFP_ = value;
      }
    }

    /// <summary>Field number for the "EBPDGIFICNH" field.</summary>
    public const int EBPDGIFICNHFieldNumber = 14;
    private uint eBPDGIFICNH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EBPDGIFICNH {
      get { return eBPDGIFICNH_; }
      set {
        eBPDGIFICNH_ = value;
      }
    }

    /// <summary>Field number for the "AODKPOPJEAF" field.</summary>
    public const int AODKPOPJEAFFieldNumber = 4;
    private uint aODKPOPJEAF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AODKPOPJEAF {
      get { return aODKPOPJEAF_; }
      set {
        aODKPOPJEAF_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerRecordInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerRecordInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (JGKIJCJPFAA != other.JGKIJCJPFAA) return false;
      if (!object.Equals(CollectionInfo, other.CollectionInfo)) return false;
      if (MNDJLCMGMHJ != other.MNDJLCMGMHJ) return false;
      if (ABHGDMEMFMA != other.ABHGDMEMFMA) return false;
      if (EEKFJOLDHLK != other.EEKFJOLDHLK) return false;
      if (CPBBNJNMNHG != other.CPBBNJNMNHG) return false;
      if (BANBDLIPJFP != other.BANBDLIPJFP) return false;
      if (EBPDGIFICNH != other.EBPDGIFICNH) return false;
      if (AODKPOPJEAF != other.AODKPOPJEAF) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (JGKIJCJPFAA != 0) hash ^= JGKIJCJPFAA.GetHashCode();
      if (collectionInfo_ != null) hash ^= CollectionInfo.GetHashCode();
      if (MNDJLCMGMHJ != 0) hash ^= MNDJLCMGMHJ.GetHashCode();
      if (ABHGDMEMFMA != 0) hash ^= ABHGDMEMFMA.GetHashCode();
      if (EEKFJOLDHLK != 0) hash ^= EEKFJOLDHLK.GetHashCode();
      if (CPBBNJNMNHG != 0) hash ^= CPBBNJNMNHG.GetHashCode();
      if (BANBDLIPJFP != 0) hash ^= BANBDLIPJFP.GetHashCode();
      if (EBPDGIFICNH != 0) hash ^= EBPDGIFICNH.GetHashCode();
      if (AODKPOPJEAF != 0) hash ^= AODKPOPJEAF.GetHashCode();
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
      if (JGKIJCJPFAA != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(JGKIJCJPFAA);
      }
      if (AODKPOPJEAF != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(AODKPOPJEAF);
      }
      if (collectionInfo_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(CollectionInfo);
      }
      if (BANBDLIPJFP != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(BANBDLIPJFP);
      }
      if (EEKFJOLDHLK != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(EEKFJOLDHLK);
      }
      if (ABHGDMEMFMA != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(ABHGDMEMFMA);
      }
      if (MNDJLCMGMHJ != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(MNDJLCMGMHJ);
      }
      if (EBPDGIFICNH != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(EBPDGIFICNH);
      }
      if (CPBBNJNMNHG != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(CPBBNJNMNHG);
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
      if (JGKIJCJPFAA != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(JGKIJCJPFAA);
      }
      if (AODKPOPJEAF != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(AODKPOPJEAF);
      }
      if (collectionInfo_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(CollectionInfo);
      }
      if (BANBDLIPJFP != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(BANBDLIPJFP);
      }
      if (EEKFJOLDHLK != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(EEKFJOLDHLK);
      }
      if (ABHGDMEMFMA != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(ABHGDMEMFMA);
      }
      if (MNDJLCMGMHJ != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(MNDJLCMGMHJ);
      }
      if (EBPDGIFICNH != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(EBPDGIFICNH);
      }
      if (CPBBNJNMNHG != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(CPBBNJNMNHG);
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
      if (JGKIJCJPFAA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(JGKIJCJPFAA);
      }
      if (collectionInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CollectionInfo);
      }
      if (MNDJLCMGMHJ != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MNDJLCMGMHJ);
      }
      if (ABHGDMEMFMA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ABHGDMEMFMA);
      }
      if (EEKFJOLDHLK != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EEKFJOLDHLK);
      }
      if (CPBBNJNMNHG != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CPBBNJNMNHG);
      }
      if (BANBDLIPJFP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BANBDLIPJFP);
      }
      if (EBPDGIFICNH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EBPDGIFICNH);
      }
      if (AODKPOPJEAF != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AODKPOPJEAF);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerRecordInfo other) {
      if (other == null) {
        return;
      }
      if (other.JGKIJCJPFAA != 0) {
        JGKIJCJPFAA = other.JGKIJCJPFAA;
      }
      if (other.collectionInfo_ != null) {
        if (collectionInfo_ == null) {
          CollectionInfo = new global::EggLink.DanhengServer.Proto.PlayerCollectionInfo();
        }
        CollectionInfo.MergeFrom(other.CollectionInfo);
      }
      if (other.MNDJLCMGMHJ != 0) {
        MNDJLCMGMHJ = other.MNDJLCMGMHJ;
      }
      if (other.ABHGDMEMFMA != 0) {
        ABHGDMEMFMA = other.ABHGDMEMFMA;
      }
      if (other.EEKFJOLDHLK != 0) {
        EEKFJOLDHLK = other.EEKFJOLDHLK;
      }
      if (other.CPBBNJNMNHG != 0) {
        CPBBNJNMNHG = other.CPBBNJNMNHG;
      }
      if (other.BANBDLIPJFP != 0) {
        BANBDLIPJFP = other.BANBDLIPJFP;
      }
      if (other.EBPDGIFICNH != 0) {
        EBPDGIFICNH = other.EBPDGIFICNH;
      }
      if (other.AODKPOPJEAF != 0) {
        AODKPOPJEAF = other.AODKPOPJEAF;
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
            JGKIJCJPFAA = input.ReadUInt32();
            break;
          }
          case 32: {
            AODKPOPJEAF = input.ReadUInt32();
            break;
          }
          case 42: {
            if (collectionInfo_ == null) {
              CollectionInfo = new global::EggLink.DanhengServer.Proto.PlayerCollectionInfo();
            }
            input.ReadMessage(CollectionInfo);
            break;
          }
          case 56: {
            BANBDLIPJFP = input.ReadUInt32();
            break;
          }
          case 64: {
            EEKFJOLDHLK = input.ReadUInt32();
            break;
          }
          case 80: {
            ABHGDMEMFMA = input.ReadUInt32();
            break;
          }
          case 104: {
            MNDJLCMGMHJ = input.ReadUInt32();
            break;
          }
          case 112: {
            EBPDGIFICNH = input.ReadUInt32();
            break;
          }
          case 120: {
            CPBBNJNMNHG = input.ReadUInt32();
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
            JGKIJCJPFAA = input.ReadUInt32();
            break;
          }
          case 32: {
            AODKPOPJEAF = input.ReadUInt32();
            break;
          }
          case 42: {
            if (collectionInfo_ == null) {
              CollectionInfo = new global::EggLink.DanhengServer.Proto.PlayerCollectionInfo();
            }
            input.ReadMessage(CollectionInfo);
            break;
          }
          case 56: {
            BANBDLIPJFP = input.ReadUInt32();
            break;
          }
          case 64: {
            EEKFJOLDHLK = input.ReadUInt32();
            break;
          }
          case 80: {
            ABHGDMEMFMA = input.ReadUInt32();
            break;
          }
          case 104: {
            MNDJLCMGMHJ = input.ReadUInt32();
            break;
          }
          case 112: {
            EBPDGIFICNH = input.ReadUInt32();
            break;
          }
          case 120: {
            CPBBNJNMNHG = input.ReadUInt32();
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
