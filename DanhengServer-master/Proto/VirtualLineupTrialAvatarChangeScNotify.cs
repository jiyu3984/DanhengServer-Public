// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: VirtualLineupTrialAvatarChangeScNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from VirtualLineupTrialAvatarChangeScNotify.proto</summary>
  public static partial class VirtualLineupTrialAvatarChangeScNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for VirtualLineupTrialAvatarChangeScNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static VirtualLineupTrialAvatarChangeScNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CixWaXJ0dWFsTGluZXVwVHJpYWxBdmF0YXJDaGFuZ2VTY05vdGlmeS5wcm90",
            "byJ5CiZWaXJ0dWFsTGluZXVwVHJpYWxBdmF0YXJDaGFuZ2VTY05vdGlmeRIT",
            "CgtDTEdLTENIRU9FQRgBIAEoCBIQCghwbGFuZV9pZBgGIAEoDRITCgtBQUVB",
            "QUVPTkJPRRgIIAMoDRITCgtDR0tGT1BKQ0dMThgJIAMoDUIeqgIbRWdnTGlu",
            "ay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.VirtualLineupTrialAvatarChangeScNotify), global::EggLink.DanhengServer.Proto.VirtualLineupTrialAvatarChangeScNotify.Parser, new[]{ "CLGKLCHEOEA", "PlaneId", "AAEAAEONBOE", "CGKFOPJCGLN" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class VirtualLineupTrialAvatarChangeScNotify : pb::IMessage<VirtualLineupTrialAvatarChangeScNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<VirtualLineupTrialAvatarChangeScNotify> _parser = new pb::MessageParser<VirtualLineupTrialAvatarChangeScNotify>(() => new VirtualLineupTrialAvatarChangeScNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<VirtualLineupTrialAvatarChangeScNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.VirtualLineupTrialAvatarChangeScNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VirtualLineupTrialAvatarChangeScNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VirtualLineupTrialAvatarChangeScNotify(VirtualLineupTrialAvatarChangeScNotify other) : this() {
      cLGKLCHEOEA_ = other.cLGKLCHEOEA_;
      planeId_ = other.planeId_;
      aAEAAEONBOE_ = other.aAEAAEONBOE_.Clone();
      cGKFOPJCGLN_ = other.cGKFOPJCGLN_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VirtualLineupTrialAvatarChangeScNotify Clone() {
      return new VirtualLineupTrialAvatarChangeScNotify(this);
    }

    /// <summary>Field number for the "CLGKLCHEOEA" field.</summary>
    public const int CLGKLCHEOEAFieldNumber = 1;
    private bool cLGKLCHEOEA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool CLGKLCHEOEA {
      get { return cLGKLCHEOEA_; }
      set {
        cLGKLCHEOEA_ = value;
      }
    }

    /// <summary>Field number for the "plane_id" field.</summary>
    public const int PlaneIdFieldNumber = 6;
    private uint planeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PlaneId {
      get { return planeId_; }
      set {
        planeId_ = value;
      }
    }

    /// <summary>Field number for the "AAEAAEONBOE" field.</summary>
    public const int AAEAAEONBOEFieldNumber = 8;
    private static readonly pb::FieldCodec<uint> _repeated_aAEAAEONBOE_codec
        = pb::FieldCodec.ForUInt32(66);
    private readonly pbc::RepeatedField<uint> aAEAAEONBOE_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> AAEAAEONBOE {
      get { return aAEAAEONBOE_; }
    }

    /// <summary>Field number for the "CGKFOPJCGLN" field.</summary>
    public const int CGKFOPJCGLNFieldNumber = 9;
    private static readonly pb::FieldCodec<uint> _repeated_cGKFOPJCGLN_codec
        = pb::FieldCodec.ForUInt32(74);
    private readonly pbc::RepeatedField<uint> cGKFOPJCGLN_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> CGKFOPJCGLN {
      get { return cGKFOPJCGLN_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as VirtualLineupTrialAvatarChangeScNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(VirtualLineupTrialAvatarChangeScNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CLGKLCHEOEA != other.CLGKLCHEOEA) return false;
      if (PlaneId != other.PlaneId) return false;
      if(!aAEAAEONBOE_.Equals(other.aAEAAEONBOE_)) return false;
      if(!cGKFOPJCGLN_.Equals(other.cGKFOPJCGLN_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CLGKLCHEOEA != false) hash ^= CLGKLCHEOEA.GetHashCode();
      if (PlaneId != 0) hash ^= PlaneId.GetHashCode();
      hash ^= aAEAAEONBOE_.GetHashCode();
      hash ^= cGKFOPJCGLN_.GetHashCode();
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
      if (CLGKLCHEOEA != false) {
        output.WriteRawTag(8);
        output.WriteBool(CLGKLCHEOEA);
      }
      if (PlaneId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(PlaneId);
      }
      aAEAAEONBOE_.WriteTo(output, _repeated_aAEAAEONBOE_codec);
      cGKFOPJCGLN_.WriteTo(output, _repeated_cGKFOPJCGLN_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (CLGKLCHEOEA != false) {
        output.WriteRawTag(8);
        output.WriteBool(CLGKLCHEOEA);
      }
      if (PlaneId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(PlaneId);
      }
      aAEAAEONBOE_.WriteTo(ref output, _repeated_aAEAAEONBOE_codec);
      cGKFOPJCGLN_.WriteTo(ref output, _repeated_cGKFOPJCGLN_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (CLGKLCHEOEA != false) {
        size += 1 + 1;
      }
      if (PlaneId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PlaneId);
      }
      size += aAEAAEONBOE_.CalculateSize(_repeated_aAEAAEONBOE_codec);
      size += cGKFOPJCGLN_.CalculateSize(_repeated_cGKFOPJCGLN_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(VirtualLineupTrialAvatarChangeScNotify other) {
      if (other == null) {
        return;
      }
      if (other.CLGKLCHEOEA != false) {
        CLGKLCHEOEA = other.CLGKLCHEOEA;
      }
      if (other.PlaneId != 0) {
        PlaneId = other.PlaneId;
      }
      aAEAAEONBOE_.Add(other.aAEAAEONBOE_);
      cGKFOPJCGLN_.Add(other.cGKFOPJCGLN_);
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
            CLGKLCHEOEA = input.ReadBool();
            break;
          }
          case 48: {
            PlaneId = input.ReadUInt32();
            break;
          }
          case 66:
          case 64: {
            aAEAAEONBOE_.AddEntriesFrom(input, _repeated_aAEAAEONBOE_codec);
            break;
          }
          case 74:
          case 72: {
            cGKFOPJCGLN_.AddEntriesFrom(input, _repeated_cGKFOPJCGLN_codec);
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
            CLGKLCHEOEA = input.ReadBool();
            break;
          }
          case 48: {
            PlaneId = input.ReadUInt32();
            break;
          }
          case 66:
          case 64: {
            aAEAAEONBOE_.AddEntriesFrom(ref input, _repeated_aAEAAEONBOE_codec);
            break;
          }
          case 74:
          case 72: {
            cGKFOPJCGLN_.AddEntriesFrom(ref input, _repeated_cGKFOPJCGLN_codec);
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