// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PIHEPMKCGCI.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from PIHEPMKCGCI.proto</summary>
  public static partial class PIHEPMKCGCIReflection {

    #region Descriptor
    /// <summary>File descriptor for PIHEPMKCGCI.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PIHEPMKCGCIReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFQSUhFUE1LQ0dDSS5wcm90bxoOSXRlbUxpc3QucHJvdG8iVwoLUElIRVBN",
            "S0NHQ0kSEwoLR0tIRktOSkZLUEcYCyADKA0SHgoLQ0dHTURPSEJFRUEYBSAB",
            "KAsyCS5JdGVtTGlzdBITCgtDT0dQRUhJTkNIQRgPIAEoDUIeqgIbRWdnTGlu",
            "ay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ItemListReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.PIHEPMKCGCI), global::EggLink.DanhengServer.Proto.PIHEPMKCGCI.Parser, new[]{ "GKHFKNJFKPG", "CGGMDOHBEEA", "COGPEHINCHA" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class PIHEPMKCGCI : pb::IMessage<PIHEPMKCGCI>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PIHEPMKCGCI> _parser = new pb::MessageParser<PIHEPMKCGCI>(() => new PIHEPMKCGCI());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PIHEPMKCGCI> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.PIHEPMKCGCIReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PIHEPMKCGCI() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PIHEPMKCGCI(PIHEPMKCGCI other) : this() {
      gKHFKNJFKPG_ = other.gKHFKNJFKPG_.Clone();
      cGGMDOHBEEA_ = other.cGGMDOHBEEA_ != null ? other.cGGMDOHBEEA_.Clone() : null;
      cOGPEHINCHA_ = other.cOGPEHINCHA_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PIHEPMKCGCI Clone() {
      return new PIHEPMKCGCI(this);
    }

    /// <summary>Field number for the "GKHFKNJFKPG" field.</summary>
    public const int GKHFKNJFKPGFieldNumber = 11;
    private static readonly pb::FieldCodec<uint> _repeated_gKHFKNJFKPG_codec
        = pb::FieldCodec.ForUInt32(90);
    private readonly pbc::RepeatedField<uint> gKHFKNJFKPG_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> GKHFKNJFKPG {
      get { return gKHFKNJFKPG_; }
    }

    /// <summary>Field number for the "CGGMDOHBEEA" field.</summary>
    public const int CGGMDOHBEEAFieldNumber = 5;
    private global::EggLink.DanhengServer.Proto.ItemList cGGMDOHBEEA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemList CGGMDOHBEEA {
      get { return cGGMDOHBEEA_; }
      set {
        cGGMDOHBEEA_ = value;
      }
    }

    /// <summary>Field number for the "COGPEHINCHA" field.</summary>
    public const int COGPEHINCHAFieldNumber = 15;
    private uint cOGPEHINCHA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint COGPEHINCHA {
      get { return cOGPEHINCHA_; }
      set {
        cOGPEHINCHA_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PIHEPMKCGCI);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PIHEPMKCGCI other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!gKHFKNJFKPG_.Equals(other.gKHFKNJFKPG_)) return false;
      if (!object.Equals(CGGMDOHBEEA, other.CGGMDOHBEEA)) return false;
      if (COGPEHINCHA != other.COGPEHINCHA) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= gKHFKNJFKPG_.GetHashCode();
      if (cGGMDOHBEEA_ != null) hash ^= CGGMDOHBEEA.GetHashCode();
      if (COGPEHINCHA != 0) hash ^= COGPEHINCHA.GetHashCode();
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
      if (cGGMDOHBEEA_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(CGGMDOHBEEA);
      }
      gKHFKNJFKPG_.WriteTo(output, _repeated_gKHFKNJFKPG_codec);
      if (COGPEHINCHA != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(COGPEHINCHA);
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
      if (cGGMDOHBEEA_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(CGGMDOHBEEA);
      }
      gKHFKNJFKPG_.WriteTo(ref output, _repeated_gKHFKNJFKPG_codec);
      if (COGPEHINCHA != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(COGPEHINCHA);
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
      size += gKHFKNJFKPG_.CalculateSize(_repeated_gKHFKNJFKPG_codec);
      if (cGGMDOHBEEA_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CGGMDOHBEEA);
      }
      if (COGPEHINCHA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(COGPEHINCHA);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PIHEPMKCGCI other) {
      if (other == null) {
        return;
      }
      gKHFKNJFKPG_.Add(other.gKHFKNJFKPG_);
      if (other.cGGMDOHBEEA_ != null) {
        if (cGGMDOHBEEA_ == null) {
          CGGMDOHBEEA = new global::EggLink.DanhengServer.Proto.ItemList();
        }
        CGGMDOHBEEA.MergeFrom(other.CGGMDOHBEEA);
      }
      if (other.COGPEHINCHA != 0) {
        COGPEHINCHA = other.COGPEHINCHA;
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
            if (cGGMDOHBEEA_ == null) {
              CGGMDOHBEEA = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(CGGMDOHBEEA);
            break;
          }
          case 90:
          case 88: {
            gKHFKNJFKPG_.AddEntriesFrom(input, _repeated_gKHFKNJFKPG_codec);
            break;
          }
          case 120: {
            COGPEHINCHA = input.ReadUInt32();
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
            if (cGGMDOHBEEA_ == null) {
              CGGMDOHBEEA = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(CGGMDOHBEEA);
            break;
          }
          case 90:
          case 88: {
            gKHFKNJFKPG_.AddEntriesFrom(ref input, _repeated_gKHFKNJFKPG_codec);
            break;
          }
          case 120: {
            COGPEHINCHA = input.ReadUInt32();
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