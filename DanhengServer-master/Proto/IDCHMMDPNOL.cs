// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: IDCHMMDPNOL.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from IDCHMMDPNOL.proto</summary>
  public static partial class IDCHMMDPNOLReflection {

    #region Descriptor
    /// <summary>File descriptor for IDCHMMDPNOL.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static IDCHMMDPNOLReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFJRENITU1EUE5PTC5wcm90bxoQTW90aW9uSW5mby5wcm90byKBAQoLSURD",
            "SE1NRFBOT0wSIAoLSk5BTUpORk1OQU0YAiABKAsyCy5Nb3Rpb25JbmZvEhEK",
            "CWNvbmZpZ19pZBgLIAEoDRITCgtKRUFIUEFBT0FPTRgMIAEoDRITCgtNUE9I",
            "Rk1GRExBQhgEIAEoDRITCgtKT0VLT0dDTEZBQRgOIAEoDEIeqgIbRWdnTGlu",
            "ay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.MotionInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.IDCHMMDPNOL), global::EggLink.DanhengServer.Proto.IDCHMMDPNOL.Parser, new[]{ "JNAMJNFMNAM", "ConfigId", "JEAHPAAOAOM", "MPOHFMFDLAB", "JOEKOGCLFAA" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class IDCHMMDPNOL : pb::IMessage<IDCHMMDPNOL>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<IDCHMMDPNOL> _parser = new pb::MessageParser<IDCHMMDPNOL>(() => new IDCHMMDPNOL());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<IDCHMMDPNOL> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.IDCHMMDPNOLReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IDCHMMDPNOL() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IDCHMMDPNOL(IDCHMMDPNOL other) : this() {
      jNAMJNFMNAM_ = other.jNAMJNFMNAM_ != null ? other.jNAMJNFMNAM_.Clone() : null;
      configId_ = other.configId_;
      jEAHPAAOAOM_ = other.jEAHPAAOAOM_;
      mPOHFMFDLAB_ = other.mPOHFMFDLAB_;
      jOEKOGCLFAA_ = other.jOEKOGCLFAA_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IDCHMMDPNOL Clone() {
      return new IDCHMMDPNOL(this);
    }

    /// <summary>Field number for the "JNAMJNFMNAM" field.</summary>
    public const int JNAMJNFMNAMFieldNumber = 2;
    private global::EggLink.DanhengServer.Proto.MotionInfo jNAMJNFMNAM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.MotionInfo JNAMJNFMNAM {
      get { return jNAMJNFMNAM_; }
      set {
        jNAMJNFMNAM_ = value;
      }
    }

    /// <summary>Field number for the "config_id" field.</summary>
    public const int ConfigIdFieldNumber = 11;
    private uint configId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ConfigId {
      get { return configId_; }
      set {
        configId_ = value;
      }
    }

    /// <summary>Field number for the "JEAHPAAOAOM" field.</summary>
    public const int JEAHPAAOAOMFieldNumber = 12;
    private uint jEAHPAAOAOM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint JEAHPAAOAOM {
      get { return jEAHPAAOAOM_; }
      set {
        jEAHPAAOAOM_ = value;
      }
    }

    /// <summary>Field number for the "MPOHFMFDLAB" field.</summary>
    public const int MPOHFMFDLABFieldNumber = 4;
    private uint mPOHFMFDLAB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MPOHFMFDLAB {
      get { return mPOHFMFDLAB_; }
      set {
        mPOHFMFDLAB_ = value;
      }
    }

    /// <summary>Field number for the "JOEKOGCLFAA" field.</summary>
    public const int JOEKOGCLFAAFieldNumber = 14;
    private pb::ByteString jOEKOGCLFAA_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString JOEKOGCLFAA {
      get { return jOEKOGCLFAA_; }
      set {
        jOEKOGCLFAA_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as IDCHMMDPNOL);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(IDCHMMDPNOL other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(JNAMJNFMNAM, other.JNAMJNFMNAM)) return false;
      if (ConfigId != other.ConfigId) return false;
      if (JEAHPAAOAOM != other.JEAHPAAOAOM) return false;
      if (MPOHFMFDLAB != other.MPOHFMFDLAB) return false;
      if (JOEKOGCLFAA != other.JOEKOGCLFAA) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (jNAMJNFMNAM_ != null) hash ^= JNAMJNFMNAM.GetHashCode();
      if (ConfigId != 0) hash ^= ConfigId.GetHashCode();
      if (JEAHPAAOAOM != 0) hash ^= JEAHPAAOAOM.GetHashCode();
      if (MPOHFMFDLAB != 0) hash ^= MPOHFMFDLAB.GetHashCode();
      if (JOEKOGCLFAA.Length != 0) hash ^= JOEKOGCLFAA.GetHashCode();
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
      if (jNAMJNFMNAM_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(JNAMJNFMNAM);
      }
      if (MPOHFMFDLAB != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(MPOHFMFDLAB);
      }
      if (ConfigId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(ConfigId);
      }
      if (JEAHPAAOAOM != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(JEAHPAAOAOM);
      }
      if (JOEKOGCLFAA.Length != 0) {
        output.WriteRawTag(114);
        output.WriteBytes(JOEKOGCLFAA);
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
      if (jNAMJNFMNAM_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(JNAMJNFMNAM);
      }
      if (MPOHFMFDLAB != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(MPOHFMFDLAB);
      }
      if (ConfigId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(ConfigId);
      }
      if (JEAHPAAOAOM != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(JEAHPAAOAOM);
      }
      if (JOEKOGCLFAA.Length != 0) {
        output.WriteRawTag(114);
        output.WriteBytes(JOEKOGCLFAA);
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
      if (jNAMJNFMNAM_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(JNAMJNFMNAM);
      }
      if (ConfigId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ConfigId);
      }
      if (JEAHPAAOAOM != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(JEAHPAAOAOM);
      }
      if (MPOHFMFDLAB != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MPOHFMFDLAB);
      }
      if (JOEKOGCLFAA.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(JOEKOGCLFAA);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(IDCHMMDPNOL other) {
      if (other == null) {
        return;
      }
      if (other.jNAMJNFMNAM_ != null) {
        if (jNAMJNFMNAM_ == null) {
          JNAMJNFMNAM = new global::EggLink.DanhengServer.Proto.MotionInfo();
        }
        JNAMJNFMNAM.MergeFrom(other.JNAMJNFMNAM);
      }
      if (other.ConfigId != 0) {
        ConfigId = other.ConfigId;
      }
      if (other.JEAHPAAOAOM != 0) {
        JEAHPAAOAOM = other.JEAHPAAOAOM;
      }
      if (other.MPOHFMFDLAB != 0) {
        MPOHFMFDLAB = other.MPOHFMFDLAB;
      }
      if (other.JOEKOGCLFAA.Length != 0) {
        JOEKOGCLFAA = other.JOEKOGCLFAA;
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
          case 18: {
            if (jNAMJNFMNAM_ == null) {
              JNAMJNFMNAM = new global::EggLink.DanhengServer.Proto.MotionInfo();
            }
            input.ReadMessage(JNAMJNFMNAM);
            break;
          }
          case 32: {
            MPOHFMFDLAB = input.ReadUInt32();
            break;
          }
          case 88: {
            ConfigId = input.ReadUInt32();
            break;
          }
          case 96: {
            JEAHPAAOAOM = input.ReadUInt32();
            break;
          }
          case 114: {
            JOEKOGCLFAA = input.ReadBytes();
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
          case 18: {
            if (jNAMJNFMNAM_ == null) {
              JNAMJNFMNAM = new global::EggLink.DanhengServer.Proto.MotionInfo();
            }
            input.ReadMessage(JNAMJNFMNAM);
            break;
          }
          case 32: {
            MPOHFMFDLAB = input.ReadUInt32();
            break;
          }
          case 88: {
            ConfigId = input.ReadUInt32();
            break;
          }
          case 96: {
            JEAHPAAOAOM = input.ReadUInt32();
            break;
          }
          case 114: {
            JOEKOGCLFAA = input.ReadBytes();
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