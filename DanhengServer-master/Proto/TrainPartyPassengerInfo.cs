// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TrainPartyPassengerInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from TrainPartyPassengerInfo.proto</summary>
  public static partial class TrainPartyPassengerInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for TrainPartyPassengerInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TrainPartyPassengerInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1UcmFpblBhcnR5UGFzc2VuZ2VySW5mby5wcm90bxoZVHJhaW5QYXJ0eVBh",
            "c3Nlbmdlci5wcm90byJhChdUcmFpblBhcnR5UGFzc2VuZ2VySW5mbxIxChNw",
            "YXNzZW5nZXJfaW5mb19saXN0GAwgAygLMhQuVHJhaW5QYXJ0eVBhc3Nlbmdl",
            "chITCgtCSUtDREFESklKShgBIAMoDUIeqgIbRWdnTGluay5EYW5oZW5nU2Vy",
            "dmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.TrainPartyPassengerReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.TrainPartyPassengerInfo), global::EggLink.DanhengServer.Proto.TrainPartyPassengerInfo.Parser, new[]{ "PassengerInfoList", "BIKCDADJIJJ" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class TrainPartyPassengerInfo : pb::IMessage<TrainPartyPassengerInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TrainPartyPassengerInfo> _parser = new pb::MessageParser<TrainPartyPassengerInfo>(() => new TrainPartyPassengerInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TrainPartyPassengerInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.TrainPartyPassengerInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TrainPartyPassengerInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TrainPartyPassengerInfo(TrainPartyPassengerInfo other) : this() {
      passengerInfoList_ = other.passengerInfoList_.Clone();
      bIKCDADJIJJ_ = other.bIKCDADJIJJ_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TrainPartyPassengerInfo Clone() {
      return new TrainPartyPassengerInfo(this);
    }

    /// <summary>Field number for the "passenger_info_list" field.</summary>
    public const int PassengerInfoListFieldNumber = 12;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.TrainPartyPassenger> _repeated_passengerInfoList_codec
        = pb::FieldCodec.ForMessage(98, global::EggLink.DanhengServer.Proto.TrainPartyPassenger.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.TrainPartyPassenger> passengerInfoList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.TrainPartyPassenger>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.TrainPartyPassenger> PassengerInfoList {
      get { return passengerInfoList_; }
    }

    /// <summary>Field number for the "BIKCDADJIJJ" field.</summary>
    public const int BIKCDADJIJJFieldNumber = 1;
    private static readonly pb::FieldCodec<uint> _repeated_bIKCDADJIJJ_codec
        = pb::FieldCodec.ForUInt32(10);
    private readonly pbc::RepeatedField<uint> bIKCDADJIJJ_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> BIKCDADJIJJ {
      get { return bIKCDADJIJJ_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TrainPartyPassengerInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TrainPartyPassengerInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!passengerInfoList_.Equals(other.passengerInfoList_)) return false;
      if(!bIKCDADJIJJ_.Equals(other.bIKCDADJIJJ_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= passengerInfoList_.GetHashCode();
      hash ^= bIKCDADJIJJ_.GetHashCode();
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
      bIKCDADJIJJ_.WriteTo(output, _repeated_bIKCDADJIJJ_codec);
      passengerInfoList_.WriteTo(output, _repeated_passengerInfoList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      bIKCDADJIJJ_.WriteTo(ref output, _repeated_bIKCDADJIJJ_codec);
      passengerInfoList_.WriteTo(ref output, _repeated_passengerInfoList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += passengerInfoList_.CalculateSize(_repeated_passengerInfoList_codec);
      size += bIKCDADJIJJ_.CalculateSize(_repeated_bIKCDADJIJJ_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TrainPartyPassengerInfo other) {
      if (other == null) {
        return;
      }
      passengerInfoList_.Add(other.passengerInfoList_);
      bIKCDADJIJJ_.Add(other.bIKCDADJIJJ_);
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
            bIKCDADJIJJ_.AddEntriesFrom(input, _repeated_bIKCDADJIJJ_codec);
            break;
          }
          case 98: {
            passengerInfoList_.AddEntriesFrom(input, _repeated_passengerInfoList_codec);
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
            bIKCDADJIJJ_.AddEntriesFrom(ref input, _repeated_bIKCDADJIJJ_codec);
            break;
          }
          case 98: {
            passengerInfoList_.AddEntriesFrom(ref input, _repeated_passengerInfoList_codec);
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