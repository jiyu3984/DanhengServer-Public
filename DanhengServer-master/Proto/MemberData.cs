// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MemberData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from MemberData.proto</summary>
  public static partial class MemberDataReflection {

    #region Descriptor
    /// <summary>File descriptor for MemberData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MemberDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBNZW1iZXJEYXRhLnByb3RvGhJQbGF0Zm9ybVR5cGUucHJvdG8iqwEKCk1l",
            "bWJlckRhdGESCwoDdWlkGAEgASgNEg0KBWxldmVsGAIgASgNEhAKCG5pY2tu",
            "YW1lGAMgASgJEhMKC0lBTE5HUEFJS0NIGAQgASgNEh8KCHBsYXRmb3JtGAUg",
            "ASgOMg0uUGxhdGZvcm1UeXBlEhMKC1BEQ0lMQURNSklKGAYgASgJEhMKC0lI",
            "RU9NTkJQTUtNGAcgASgJEg8KB3ZlcnNpb24YCCABKARCHqoCG0VnZ0xpbmsu",
            "RGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.PlatformTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.MemberData), global::EggLink.DanhengServer.Proto.MemberData.Parser, new[]{ "Uid", "Level", "Nickname", "IALNGPAIKCH", "Platform", "PDCILADMJIJ", "IHEOMNBPMKM", "Version" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class MemberData : pb::IMessage<MemberData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MemberData> _parser = new pb::MessageParser<MemberData>(() => new MemberData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MemberData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.MemberDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MemberData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MemberData(MemberData other) : this() {
      uid_ = other.uid_;
      level_ = other.level_;
      nickname_ = other.nickname_;
      iALNGPAIKCH_ = other.iALNGPAIKCH_;
      platform_ = other.platform_;
      pDCILADMJIJ_ = other.pDCILADMJIJ_;
      iHEOMNBPMKM_ = other.iHEOMNBPMKM_;
      version_ = other.version_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MemberData Clone() {
      return new MemberData(this);
    }

    /// <summary>Field number for the "uid" field.</summary>
    public const int UidFieldNumber = 1;
    private uint uid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Uid {
      get { return uid_; }
      set {
        uid_ = value;
      }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 2;
    private uint level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "nickname" field.</summary>
    public const int NicknameFieldNumber = 3;
    private string nickname_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Nickname {
      get { return nickname_; }
      set {
        nickname_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "IALNGPAIKCH" field.</summary>
    public const int IALNGPAIKCHFieldNumber = 4;
    private uint iALNGPAIKCH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint IALNGPAIKCH {
      get { return iALNGPAIKCH_; }
      set {
        iALNGPAIKCH_ = value;
      }
    }

    /// <summary>Field number for the "platform" field.</summary>
    public const int PlatformFieldNumber = 5;
    private global::EggLink.DanhengServer.Proto.PlatformType platform_ = global::EggLink.DanhengServer.Proto.PlatformType.Editor;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.PlatformType Platform {
      get { return platform_; }
      set {
        platform_ = value;
      }
    }

    /// <summary>Field number for the "PDCILADMJIJ" field.</summary>
    public const int PDCILADMJIJFieldNumber = 6;
    private string pDCILADMJIJ_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string PDCILADMJIJ {
      get { return pDCILADMJIJ_; }
      set {
        pDCILADMJIJ_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "IHEOMNBPMKM" field.</summary>
    public const int IHEOMNBPMKMFieldNumber = 7;
    private string iHEOMNBPMKM_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string IHEOMNBPMKM {
      get { return iHEOMNBPMKM_; }
      set {
        iHEOMNBPMKM_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "version" field.</summary>
    public const int VersionFieldNumber = 8;
    private ulong version_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong Version {
      get { return version_; }
      set {
        version_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MemberData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MemberData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Uid != other.Uid) return false;
      if (Level != other.Level) return false;
      if (Nickname != other.Nickname) return false;
      if (IALNGPAIKCH != other.IALNGPAIKCH) return false;
      if (Platform != other.Platform) return false;
      if (PDCILADMJIJ != other.PDCILADMJIJ) return false;
      if (IHEOMNBPMKM != other.IHEOMNBPMKM) return false;
      if (Version != other.Version) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Uid != 0) hash ^= Uid.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
      if (Nickname.Length != 0) hash ^= Nickname.GetHashCode();
      if (IALNGPAIKCH != 0) hash ^= IALNGPAIKCH.GetHashCode();
      if (Platform != global::EggLink.DanhengServer.Proto.PlatformType.Editor) hash ^= Platform.GetHashCode();
      if (PDCILADMJIJ.Length != 0) hash ^= PDCILADMJIJ.GetHashCode();
      if (IHEOMNBPMKM.Length != 0) hash ^= IHEOMNBPMKM.GetHashCode();
      if (Version != 0UL) hash ^= Version.GetHashCode();
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
      if (Uid != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Uid);
      }
      if (Level != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Level);
      }
      if (Nickname.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Nickname);
      }
      if (IALNGPAIKCH != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(IALNGPAIKCH);
      }
      if (Platform != global::EggLink.DanhengServer.Proto.PlatformType.Editor) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Platform);
      }
      if (PDCILADMJIJ.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(PDCILADMJIJ);
      }
      if (IHEOMNBPMKM.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(IHEOMNBPMKM);
      }
      if (Version != 0UL) {
        output.WriteRawTag(64);
        output.WriteUInt64(Version);
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
      if (Uid != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Uid);
      }
      if (Level != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Level);
      }
      if (Nickname.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Nickname);
      }
      if (IALNGPAIKCH != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(IALNGPAIKCH);
      }
      if (Platform != global::EggLink.DanhengServer.Proto.PlatformType.Editor) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Platform);
      }
      if (PDCILADMJIJ.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(PDCILADMJIJ);
      }
      if (IHEOMNBPMKM.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(IHEOMNBPMKM);
      }
      if (Version != 0UL) {
        output.WriteRawTag(64);
        output.WriteUInt64(Version);
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
      if (Uid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Uid);
      }
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Level);
      }
      if (Nickname.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Nickname);
      }
      if (IALNGPAIKCH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(IALNGPAIKCH);
      }
      if (Platform != global::EggLink.DanhengServer.Proto.PlatformType.Editor) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Platform);
      }
      if (PDCILADMJIJ.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PDCILADMJIJ);
      }
      if (IHEOMNBPMKM.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(IHEOMNBPMKM);
      }
      if (Version != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Version);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MemberData other) {
      if (other == null) {
        return;
      }
      if (other.Uid != 0) {
        Uid = other.Uid;
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
      if (other.Nickname.Length != 0) {
        Nickname = other.Nickname;
      }
      if (other.IALNGPAIKCH != 0) {
        IALNGPAIKCH = other.IALNGPAIKCH;
      }
      if (other.Platform != global::EggLink.DanhengServer.Proto.PlatformType.Editor) {
        Platform = other.Platform;
      }
      if (other.PDCILADMJIJ.Length != 0) {
        PDCILADMJIJ = other.PDCILADMJIJ;
      }
      if (other.IHEOMNBPMKM.Length != 0) {
        IHEOMNBPMKM = other.IHEOMNBPMKM;
      }
      if (other.Version != 0UL) {
        Version = other.Version;
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
            Uid = input.ReadUInt32();
            break;
          }
          case 16: {
            Level = input.ReadUInt32();
            break;
          }
          case 26: {
            Nickname = input.ReadString();
            break;
          }
          case 32: {
            IALNGPAIKCH = input.ReadUInt32();
            break;
          }
          case 40: {
            Platform = (global::EggLink.DanhengServer.Proto.PlatformType) input.ReadEnum();
            break;
          }
          case 50: {
            PDCILADMJIJ = input.ReadString();
            break;
          }
          case 58: {
            IHEOMNBPMKM = input.ReadString();
            break;
          }
          case 64: {
            Version = input.ReadUInt64();
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
            Uid = input.ReadUInt32();
            break;
          }
          case 16: {
            Level = input.ReadUInt32();
            break;
          }
          case 26: {
            Nickname = input.ReadString();
            break;
          }
          case 32: {
            IALNGPAIKCH = input.ReadUInt32();
            break;
          }
          case 40: {
            Platform = (global::EggLink.DanhengServer.Proto.PlatformType) input.ReadEnum();
            break;
          }
          case 50: {
            PDCILADMJIJ = input.ReadString();
            break;
          }
          case 58: {
            IHEOMNBPMKM = input.ReadString();
            break;
          }
          case 64: {
            Version = input.ReadUInt64();
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
