// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SwordTrainingUnlockSyncScNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SwordTrainingUnlockSyncScNotify.proto</summary>
  public static partial class SwordTrainingUnlockSyncScNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for SwordTrainingUnlockSyncScNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SwordTrainingUnlockSyncScNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVTd29yZFRyYWluaW5nVW5sb2NrU3luY1NjTm90aWZ5LnByb3RvGhFKTUhK",
            "RkpCRU9ESy5wcm90byJZCh9Td29yZFRyYWluaW5nVW5sb2NrU3luY1NjTm90",
            "aWZ5EiEKC0JIQklQUExGSE9GGAogAygLMgwuSk1ISkZKQkVPREsSEwoLQUFI",
            "QkdFQU1ESE4YASADKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90",
            "b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.JMHJFJBEODKReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SwordTrainingUnlockSyncScNotify), global::EggLink.DanhengServer.Proto.SwordTrainingUnlockSyncScNotify.Parser, new[]{ "BHBIPPLFHOF", "AAHBGEAMDHN" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SwordTrainingUnlockSyncScNotify : pb::IMessage<SwordTrainingUnlockSyncScNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SwordTrainingUnlockSyncScNotify> _parser = new pb::MessageParser<SwordTrainingUnlockSyncScNotify>(() => new SwordTrainingUnlockSyncScNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SwordTrainingUnlockSyncScNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.SwordTrainingUnlockSyncScNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SwordTrainingUnlockSyncScNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SwordTrainingUnlockSyncScNotify(SwordTrainingUnlockSyncScNotify other) : this() {
      bHBIPPLFHOF_ = other.bHBIPPLFHOF_.Clone();
      aAHBGEAMDHN_ = other.aAHBGEAMDHN_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SwordTrainingUnlockSyncScNotify Clone() {
      return new SwordTrainingUnlockSyncScNotify(this);
    }

    /// <summary>Field number for the "BHBIPPLFHOF" field.</summary>
    public const int BHBIPPLFHOFFieldNumber = 10;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.JMHJFJBEODK> _repeated_bHBIPPLFHOF_codec
        = pb::FieldCodec.ForMessage(82, global::EggLink.DanhengServer.Proto.JMHJFJBEODK.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.JMHJFJBEODK> bHBIPPLFHOF_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.JMHJFJBEODK>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.JMHJFJBEODK> BHBIPPLFHOF {
      get { return bHBIPPLFHOF_; }
    }

    /// <summary>Field number for the "AAHBGEAMDHN" field.</summary>
    public const int AAHBGEAMDHNFieldNumber = 1;
    private static readonly pb::FieldCodec<uint> _repeated_aAHBGEAMDHN_codec
        = pb::FieldCodec.ForUInt32(10);
    private readonly pbc::RepeatedField<uint> aAHBGEAMDHN_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> AAHBGEAMDHN {
      get { return aAHBGEAMDHN_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SwordTrainingUnlockSyncScNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SwordTrainingUnlockSyncScNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!bHBIPPLFHOF_.Equals(other.bHBIPPLFHOF_)) return false;
      if(!aAHBGEAMDHN_.Equals(other.aAHBGEAMDHN_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= bHBIPPLFHOF_.GetHashCode();
      hash ^= aAHBGEAMDHN_.GetHashCode();
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
      aAHBGEAMDHN_.WriteTo(output, _repeated_aAHBGEAMDHN_codec);
      bHBIPPLFHOF_.WriteTo(output, _repeated_bHBIPPLFHOF_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      aAHBGEAMDHN_.WriteTo(ref output, _repeated_aAHBGEAMDHN_codec);
      bHBIPPLFHOF_.WriteTo(ref output, _repeated_bHBIPPLFHOF_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += bHBIPPLFHOF_.CalculateSize(_repeated_bHBIPPLFHOF_codec);
      size += aAHBGEAMDHN_.CalculateSize(_repeated_aAHBGEAMDHN_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SwordTrainingUnlockSyncScNotify other) {
      if (other == null) {
        return;
      }
      bHBIPPLFHOF_.Add(other.bHBIPPLFHOF_);
      aAHBGEAMDHN_.Add(other.aAHBGEAMDHN_);
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
          case 10:
          case 8: {
            aAHBGEAMDHN_.AddEntriesFrom(input, _repeated_aAHBGEAMDHN_codec);
            break;
          }
          case 82: {
            bHBIPPLFHOF_.AddEntriesFrom(input, _repeated_bHBIPPLFHOF_codec);
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
          case 10:
          case 8: {
            aAHBGEAMDHN_.AddEntriesFrom(ref input, _repeated_aAHBGEAMDHN_codec);
            break;
          }
          case 82: {
            bHBIPPLFHOF_.AddEntriesFrom(ref input, _repeated_bHBIPPLFHOF_codec);
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
