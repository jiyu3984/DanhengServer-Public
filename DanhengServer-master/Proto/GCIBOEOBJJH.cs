// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCIBOEOBJJH.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GCIBOEOBJJH.proto</summary>
  public static partial class GCIBOEOBJJHReflection {

    #region Descriptor
    /// <summary>File descriptor for GCIBOEOBJJH.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GCIBOEOBJJHReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFHQ0lCT0VPQkpKSC5wcm90bxoTRmlnaHRHYW1lTW9kZS5wcm90byJHCgtH",
            "Q0lCT0VPQkpKSBITCgtQTUZGTE1EQ0tFQhgBIAEoBBIjCgtDQ0tJT0JISkZC",
            "SRgCIAEoDjIOLkZpZ2h0R2FtZU1vZGVCHqoCG0VnZ0xpbmsuRGFuaGVuZ1Nl",
            "cnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.FightGameModeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GCIBOEOBJJH), global::EggLink.DanhengServer.Proto.GCIBOEOBJJH.Parser, new[]{ "PMFFLMDCKEB", "CCKIOBHJFBI" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GCIBOEOBJJH : pb::IMessage<GCIBOEOBJJH>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GCIBOEOBJJH> _parser = new pb::MessageParser<GCIBOEOBJJH>(() => new GCIBOEOBJJH());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GCIBOEOBJJH> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GCIBOEOBJJHReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCIBOEOBJJH() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCIBOEOBJJH(GCIBOEOBJJH other) : this() {
      pMFFLMDCKEB_ = other.pMFFLMDCKEB_;
      cCKIOBHJFBI_ = other.cCKIOBHJFBI_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCIBOEOBJJH Clone() {
      return new GCIBOEOBJJH(this);
    }

    /// <summary>Field number for the "PMFFLMDCKEB" field.</summary>
    public const int PMFFLMDCKEBFieldNumber = 1;
    private ulong pMFFLMDCKEB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong PMFFLMDCKEB {
      get { return pMFFLMDCKEB_; }
      set {
        pMFFLMDCKEB_ = value;
      }
    }

    /// <summary>Field number for the "CCKIOBHJFBI" field.</summary>
    public const int CCKIOBHJFBIFieldNumber = 2;
    private global::EggLink.DanhengServer.Proto.FightGameMode cCKIOBHJFBI_ = global::EggLink.DanhengServer.Proto.FightGameMode.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.FightGameMode CCKIOBHJFBI {
      get { return cCKIOBHJFBI_; }
      set {
        cCKIOBHJFBI_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GCIBOEOBJJH);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GCIBOEOBJJH other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PMFFLMDCKEB != other.PMFFLMDCKEB) return false;
      if (CCKIOBHJFBI != other.CCKIOBHJFBI) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (PMFFLMDCKEB != 0UL) hash ^= PMFFLMDCKEB.GetHashCode();
      if (CCKIOBHJFBI != global::EggLink.DanhengServer.Proto.FightGameMode.None) hash ^= CCKIOBHJFBI.GetHashCode();
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
      if (PMFFLMDCKEB != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(PMFFLMDCKEB);
      }
      if (CCKIOBHJFBI != global::EggLink.DanhengServer.Proto.FightGameMode.None) {
        output.WriteRawTag(16);
        output.WriteEnum((int) CCKIOBHJFBI);
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
      if (PMFFLMDCKEB != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(PMFFLMDCKEB);
      }
      if (CCKIOBHJFBI != global::EggLink.DanhengServer.Proto.FightGameMode.None) {
        output.WriteRawTag(16);
        output.WriteEnum((int) CCKIOBHJFBI);
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
      if (PMFFLMDCKEB != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(PMFFLMDCKEB);
      }
      if (CCKIOBHJFBI != global::EggLink.DanhengServer.Proto.FightGameMode.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) CCKIOBHJFBI);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GCIBOEOBJJH other) {
      if (other == null) {
        return;
      }
      if (other.PMFFLMDCKEB != 0UL) {
        PMFFLMDCKEB = other.PMFFLMDCKEB;
      }
      if (other.CCKIOBHJFBI != global::EggLink.DanhengServer.Proto.FightGameMode.None) {
        CCKIOBHJFBI = other.CCKIOBHJFBI;
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
            PMFFLMDCKEB = input.ReadUInt64();
            break;
          }
          case 16: {
            CCKIOBHJFBI = (global::EggLink.DanhengServer.Proto.FightGameMode) input.ReadEnum();
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
            PMFFLMDCKEB = input.ReadUInt64();
            break;
          }
          case 16: {
            CCKIOBHJFBI = (global::EggLink.DanhengServer.Proto.FightGameMode) input.ReadEnum();
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