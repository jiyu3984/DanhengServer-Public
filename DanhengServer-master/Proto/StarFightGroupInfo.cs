// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: StarFightGroupInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from StarFightGroupInfo.proto</summary>
  public static partial class StarFightGroupInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for StarFightGroupInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StarFightGroupInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhTdGFyRmlnaHRHcm91cEluZm8ucHJvdG8iegoSU3RhckZpZ2h0R3JvdXBJ",
            "bmZvEhMKC0dNQ09FRkdLRE1GGAkgASgNEhMKC0ZEQU9GTEZLQUtDGAMgASgN",
            "EhMKC0hJRUtLRE9OSEVCGAQgASgNEhMKC0xLRkxCQURLQlBHGA8gASgIEhAK",
            "CGdyb3VwX2lkGAUgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJv",
            "dG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.StarFightGroupInfo), global::EggLink.DanhengServer.Proto.StarFightGroupInfo.Parser, new[]{ "GMCOEFGKDMF", "FDAOFLFKAKC", "HIEKKDONHEB", "LKFLBADKBPG", "GroupId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class StarFightGroupInfo : pb::IMessage<StarFightGroupInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<StarFightGroupInfo> _parser = new pb::MessageParser<StarFightGroupInfo>(() => new StarFightGroupInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<StarFightGroupInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.StarFightGroupInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StarFightGroupInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StarFightGroupInfo(StarFightGroupInfo other) : this() {
      gMCOEFGKDMF_ = other.gMCOEFGKDMF_;
      fDAOFLFKAKC_ = other.fDAOFLFKAKC_;
      hIEKKDONHEB_ = other.hIEKKDONHEB_;
      lKFLBADKBPG_ = other.lKFLBADKBPG_;
      groupId_ = other.groupId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StarFightGroupInfo Clone() {
      return new StarFightGroupInfo(this);
    }

    /// <summary>Field number for the "GMCOEFGKDMF" field.</summary>
    public const int GMCOEFGKDMFFieldNumber = 9;
    private uint gMCOEFGKDMF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GMCOEFGKDMF {
      get { return gMCOEFGKDMF_; }
      set {
        gMCOEFGKDMF_ = value;
      }
    }

    /// <summary>Field number for the "FDAOFLFKAKC" field.</summary>
    public const int FDAOFLFKAKCFieldNumber = 3;
    private uint fDAOFLFKAKC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FDAOFLFKAKC {
      get { return fDAOFLFKAKC_; }
      set {
        fDAOFLFKAKC_ = value;
      }
    }

    /// <summary>Field number for the "HIEKKDONHEB" field.</summary>
    public const int HIEKKDONHEBFieldNumber = 4;
    private uint hIEKKDONHEB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HIEKKDONHEB {
      get { return hIEKKDONHEB_; }
      set {
        hIEKKDONHEB_ = value;
      }
    }

    /// <summary>Field number for the "LKFLBADKBPG" field.</summary>
    public const int LKFLBADKBPGFieldNumber = 15;
    private bool lKFLBADKBPG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool LKFLBADKBPG {
      get { return lKFLBADKBPG_; }
      set {
        lKFLBADKBPG_ = value;
      }
    }

    /// <summary>Field number for the "group_id" field.</summary>
    public const int GroupIdFieldNumber = 5;
    private uint groupId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GroupId {
      get { return groupId_; }
      set {
        groupId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as StarFightGroupInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(StarFightGroupInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GMCOEFGKDMF != other.GMCOEFGKDMF) return false;
      if (FDAOFLFKAKC != other.FDAOFLFKAKC) return false;
      if (HIEKKDONHEB != other.HIEKKDONHEB) return false;
      if (LKFLBADKBPG != other.LKFLBADKBPG) return false;
      if (GroupId != other.GroupId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (GMCOEFGKDMF != 0) hash ^= GMCOEFGKDMF.GetHashCode();
      if (FDAOFLFKAKC != 0) hash ^= FDAOFLFKAKC.GetHashCode();
      if (HIEKKDONHEB != 0) hash ^= HIEKKDONHEB.GetHashCode();
      if (LKFLBADKBPG != false) hash ^= LKFLBADKBPG.GetHashCode();
      if (GroupId != 0) hash ^= GroupId.GetHashCode();
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
      if (FDAOFLFKAKC != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(FDAOFLFKAKC);
      }
      if (HIEKKDONHEB != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(HIEKKDONHEB);
      }
      if (GroupId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(GroupId);
      }
      if (GMCOEFGKDMF != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(GMCOEFGKDMF);
      }
      if (LKFLBADKBPG != false) {
        output.WriteRawTag(120);
        output.WriteBool(LKFLBADKBPG);
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
      if (FDAOFLFKAKC != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(FDAOFLFKAKC);
      }
      if (HIEKKDONHEB != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(HIEKKDONHEB);
      }
      if (GroupId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(GroupId);
      }
      if (GMCOEFGKDMF != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(GMCOEFGKDMF);
      }
      if (LKFLBADKBPG != false) {
        output.WriteRawTag(120);
        output.WriteBool(LKFLBADKBPG);
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
      if (GMCOEFGKDMF != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GMCOEFGKDMF);
      }
      if (FDAOFLFKAKC != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FDAOFLFKAKC);
      }
      if (HIEKKDONHEB != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HIEKKDONHEB);
      }
      if (LKFLBADKBPG != false) {
        size += 1 + 1;
      }
      if (GroupId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GroupId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(StarFightGroupInfo other) {
      if (other == null) {
        return;
      }
      if (other.GMCOEFGKDMF != 0) {
        GMCOEFGKDMF = other.GMCOEFGKDMF;
      }
      if (other.FDAOFLFKAKC != 0) {
        FDAOFLFKAKC = other.FDAOFLFKAKC;
      }
      if (other.HIEKKDONHEB != 0) {
        HIEKKDONHEB = other.HIEKKDONHEB;
      }
      if (other.LKFLBADKBPG != false) {
        LKFLBADKBPG = other.LKFLBADKBPG;
      }
      if (other.GroupId != 0) {
        GroupId = other.GroupId;
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
            FDAOFLFKAKC = input.ReadUInt32();
            break;
          }
          case 32: {
            HIEKKDONHEB = input.ReadUInt32();
            break;
          }
          case 40: {
            GroupId = input.ReadUInt32();
            break;
          }
          case 72: {
            GMCOEFGKDMF = input.ReadUInt32();
            break;
          }
          case 120: {
            LKFLBADKBPG = input.ReadBool();
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
            FDAOFLFKAKC = input.ReadUInt32();
            break;
          }
          case 32: {
            HIEKKDONHEB = input.ReadUInt32();
            break;
          }
          case 40: {
            GroupId = input.ReadUInt32();
            break;
          }
          case 72: {
            GMCOEFGKDMF = input.ReadUInt32();
            break;
          }
          case 120: {
            LKFLBADKBPG = input.ReadBool();
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
