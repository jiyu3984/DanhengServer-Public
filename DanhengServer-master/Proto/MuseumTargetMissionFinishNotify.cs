// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MuseumTargetMissionFinishNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from MuseumTargetMissionFinishNotify.proto</summary>
  public static partial class MuseumTargetMissionFinishNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for MuseumTargetMissionFinishNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MuseumTargetMissionFinishNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVNdXNldW1UYXJnZXRNaXNzaW9uRmluaXNoTm90aWZ5LnByb3RvImAKH011",
            "c2V1bVRhcmdldE1pc3Npb25GaW5pc2hOb3RpZnkSEwoLQUVOTkpCTURJTk8Y",
            "DSADKA0SEwoLQUtMSlBFQktNT0gYCCABKA0SEwoLTE1MUEVLSURCS0IYDiAB",
            "KAhCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.MuseumTargetMissionFinishNotify), global::EggLink.DanhengServer.Proto.MuseumTargetMissionFinishNotify.Parser, new[]{ "AENNJBMDINO", "AKLJPEBKMOH", "LMLPEKIDBKB" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class MuseumTargetMissionFinishNotify : pb::IMessage<MuseumTargetMissionFinishNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MuseumTargetMissionFinishNotify> _parser = new pb::MessageParser<MuseumTargetMissionFinishNotify>(() => new MuseumTargetMissionFinishNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MuseumTargetMissionFinishNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.MuseumTargetMissionFinishNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MuseumTargetMissionFinishNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MuseumTargetMissionFinishNotify(MuseumTargetMissionFinishNotify other) : this() {
      aENNJBMDINO_ = other.aENNJBMDINO_.Clone();
      aKLJPEBKMOH_ = other.aKLJPEBKMOH_;
      lMLPEKIDBKB_ = other.lMLPEKIDBKB_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MuseumTargetMissionFinishNotify Clone() {
      return new MuseumTargetMissionFinishNotify(this);
    }

    /// <summary>Field number for the "AENNJBMDINO" field.</summary>
    public const int AENNJBMDINOFieldNumber = 13;
    private static readonly pb::FieldCodec<uint> _repeated_aENNJBMDINO_codec
        = pb::FieldCodec.ForUInt32(106);
    private readonly pbc::RepeatedField<uint> aENNJBMDINO_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> AENNJBMDINO {
      get { return aENNJBMDINO_; }
    }

    /// <summary>Field number for the "AKLJPEBKMOH" field.</summary>
    public const int AKLJPEBKMOHFieldNumber = 8;
    private uint aKLJPEBKMOH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AKLJPEBKMOH {
      get { return aKLJPEBKMOH_; }
      set {
        aKLJPEBKMOH_ = value;
      }
    }

    /// <summary>Field number for the "LMLPEKIDBKB" field.</summary>
    public const int LMLPEKIDBKBFieldNumber = 14;
    private bool lMLPEKIDBKB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool LMLPEKIDBKB {
      get { return lMLPEKIDBKB_; }
      set {
        lMLPEKIDBKB_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MuseumTargetMissionFinishNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MuseumTargetMissionFinishNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!aENNJBMDINO_.Equals(other.aENNJBMDINO_)) return false;
      if (AKLJPEBKMOH != other.AKLJPEBKMOH) return false;
      if (LMLPEKIDBKB != other.LMLPEKIDBKB) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= aENNJBMDINO_.GetHashCode();
      if (AKLJPEBKMOH != 0) hash ^= AKLJPEBKMOH.GetHashCode();
      if (LMLPEKIDBKB != false) hash ^= LMLPEKIDBKB.GetHashCode();
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
      if (AKLJPEBKMOH != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(AKLJPEBKMOH);
      }
      aENNJBMDINO_.WriteTo(output, _repeated_aENNJBMDINO_codec);
      if (LMLPEKIDBKB != false) {
        output.WriteRawTag(112);
        output.WriteBool(LMLPEKIDBKB);
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
      if (AKLJPEBKMOH != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(AKLJPEBKMOH);
      }
      aENNJBMDINO_.WriteTo(ref output, _repeated_aENNJBMDINO_codec);
      if (LMLPEKIDBKB != false) {
        output.WriteRawTag(112);
        output.WriteBool(LMLPEKIDBKB);
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
      size += aENNJBMDINO_.CalculateSize(_repeated_aENNJBMDINO_codec);
      if (AKLJPEBKMOH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AKLJPEBKMOH);
      }
      if (LMLPEKIDBKB != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MuseumTargetMissionFinishNotify other) {
      if (other == null) {
        return;
      }
      aENNJBMDINO_.Add(other.aENNJBMDINO_);
      if (other.AKLJPEBKMOH != 0) {
        AKLJPEBKMOH = other.AKLJPEBKMOH;
      }
      if (other.LMLPEKIDBKB != false) {
        LMLPEKIDBKB = other.LMLPEKIDBKB;
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
          case 64: {
            AKLJPEBKMOH = input.ReadUInt32();
            break;
          }
          case 106:
          case 104: {
            aENNJBMDINO_.AddEntriesFrom(input, _repeated_aENNJBMDINO_codec);
            break;
          }
          case 112: {
            LMLPEKIDBKB = input.ReadBool();
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
          case 64: {
            AKLJPEBKMOH = input.ReadUInt32();
            break;
          }
          case 106:
          case 104: {
            aENNJBMDINO_.AddEntriesFrom(ref input, _repeated_aENNJBMDINO_codec);
            break;
          }
          case 112: {
            LMLPEKIDBKB = input.ReadBool();
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