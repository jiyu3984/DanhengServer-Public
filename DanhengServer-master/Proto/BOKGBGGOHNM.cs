// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BOKGBGGOHNM.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from BOKGBGGOHNM.proto</summary>
  public static partial class BOKGBGGOHNMReflection {

    #region Descriptor
    /// <summary>File descriptor for BOKGBGGOHNM.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BOKGBGGOHNMReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFCT0tHQkdHT0hOTS5wcm90bxoSUGxhdGZvcm1UeXBlLnByb3RvIq4BCgtC",
            "T0tHQkdHT0hOTRITCgtORlBLTU9OS0tJSBgLIAEoDRITCgtBRU9ISklOR0lG",
            "SxgCIAEoCRIfCghwbGF0Zm9ybRgDIAEoDjINLlBsYXRmb3JtVHlwZRIRCglo",
            "ZWFkX2ljb24YDiABKA0SDQoFbGV2ZWwYCSABKA0SEwoLcmVtYXJrX25hbWUY",
            "BiABKAkSEAoIbmlja25hbWUYDSABKAkSCwoDdWlkGAUgASgNQh6qAhtFZ2dM",
            "aW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.PlatformTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.BOKGBGGOHNM), global::EggLink.DanhengServer.Proto.BOKGBGGOHNM.Parser, new[]{ "NFPKMONKKIH", "AEOHJINGIFK", "Platform", "HeadIcon", "Level", "RemarkName", "Nickname", "Uid" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class BOKGBGGOHNM : pb::IMessage<BOKGBGGOHNM>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BOKGBGGOHNM> _parser = new pb::MessageParser<BOKGBGGOHNM>(() => new BOKGBGGOHNM());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BOKGBGGOHNM> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.BOKGBGGOHNMReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BOKGBGGOHNM() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BOKGBGGOHNM(BOKGBGGOHNM other) : this() {
      nFPKMONKKIH_ = other.nFPKMONKKIH_;
      aEOHJINGIFK_ = other.aEOHJINGIFK_;
      platform_ = other.platform_;
      headIcon_ = other.headIcon_;
      level_ = other.level_;
      remarkName_ = other.remarkName_;
      nickname_ = other.nickname_;
      uid_ = other.uid_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BOKGBGGOHNM Clone() {
      return new BOKGBGGOHNM(this);
    }

    /// <summary>Field number for the "NFPKMONKKIH" field.</summary>
    public const int NFPKMONKKIHFieldNumber = 11;
    private uint nFPKMONKKIH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NFPKMONKKIH {
      get { return nFPKMONKKIH_; }
      set {
        nFPKMONKKIH_ = value;
      }
    }

    /// <summary>Field number for the "AEOHJINGIFK" field.</summary>
    public const int AEOHJINGIFKFieldNumber = 2;
    private string aEOHJINGIFK_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string AEOHJINGIFK {
      get { return aEOHJINGIFK_; }
      set {
        aEOHJINGIFK_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "platform" field.</summary>
    public const int PlatformFieldNumber = 3;
    private global::EggLink.DanhengServer.Proto.PlatformType platform_ = global::EggLink.DanhengServer.Proto.PlatformType.Editor;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.PlatformType Platform {
      get { return platform_; }
      set {
        platform_ = value;
      }
    }

    /// <summary>Field number for the "head_icon" field.</summary>
    public const int HeadIconFieldNumber = 14;
    private uint headIcon_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HeadIcon {
      get { return headIcon_; }
      set {
        headIcon_ = value;
      }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 9;
    private uint level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "remark_name" field.</summary>
    public const int RemarkNameFieldNumber = 6;
    private string remarkName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string RemarkName {
      get { return remarkName_; }
      set {
        remarkName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "nickname" field.</summary>
    public const int NicknameFieldNumber = 13;
    private string nickname_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Nickname {
      get { return nickname_; }
      set {
        nickname_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "uid" field.</summary>
    public const int UidFieldNumber = 5;
    private uint uid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Uid {
      get { return uid_; }
      set {
        uid_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BOKGBGGOHNM);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BOKGBGGOHNM other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (NFPKMONKKIH != other.NFPKMONKKIH) return false;
      if (AEOHJINGIFK != other.AEOHJINGIFK) return false;
      if (Platform != other.Platform) return false;
      if (HeadIcon != other.HeadIcon) return false;
      if (Level != other.Level) return false;
      if (RemarkName != other.RemarkName) return false;
      if (Nickname != other.Nickname) return false;
      if (Uid != other.Uid) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (NFPKMONKKIH != 0) hash ^= NFPKMONKKIH.GetHashCode();
      if (AEOHJINGIFK.Length != 0) hash ^= AEOHJINGIFK.GetHashCode();
      if (Platform != global::EggLink.DanhengServer.Proto.PlatformType.Editor) hash ^= Platform.GetHashCode();
      if (HeadIcon != 0) hash ^= HeadIcon.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
      if (RemarkName.Length != 0) hash ^= RemarkName.GetHashCode();
      if (Nickname.Length != 0) hash ^= Nickname.GetHashCode();
      if (Uid != 0) hash ^= Uid.GetHashCode();
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
      if (AEOHJINGIFK.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(AEOHJINGIFK);
      }
      if (Platform != global::EggLink.DanhengServer.Proto.PlatformType.Editor) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Platform);
      }
      if (Uid != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Uid);
      }
      if (RemarkName.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(RemarkName);
      }
      if (Level != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Level);
      }
      if (NFPKMONKKIH != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(NFPKMONKKIH);
      }
      if (Nickname.Length != 0) {
        output.WriteRawTag(106);
        output.WriteString(Nickname);
      }
      if (HeadIcon != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(HeadIcon);
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
      if (AEOHJINGIFK.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(AEOHJINGIFK);
      }
      if (Platform != global::EggLink.DanhengServer.Proto.PlatformType.Editor) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Platform);
      }
      if (Uid != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Uid);
      }
      if (RemarkName.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(RemarkName);
      }
      if (Level != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Level);
      }
      if (NFPKMONKKIH != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(NFPKMONKKIH);
      }
      if (Nickname.Length != 0) {
        output.WriteRawTag(106);
        output.WriteString(Nickname);
      }
      if (HeadIcon != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(HeadIcon);
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
      if (NFPKMONKKIH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NFPKMONKKIH);
      }
      if (AEOHJINGIFK.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AEOHJINGIFK);
      }
      if (Platform != global::EggLink.DanhengServer.Proto.PlatformType.Editor) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Platform);
      }
      if (HeadIcon != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HeadIcon);
      }
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Level);
      }
      if (RemarkName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RemarkName);
      }
      if (Nickname.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Nickname);
      }
      if (Uid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Uid);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BOKGBGGOHNM other) {
      if (other == null) {
        return;
      }
      if (other.NFPKMONKKIH != 0) {
        NFPKMONKKIH = other.NFPKMONKKIH;
      }
      if (other.AEOHJINGIFK.Length != 0) {
        AEOHJINGIFK = other.AEOHJINGIFK;
      }
      if (other.Platform != global::EggLink.DanhengServer.Proto.PlatformType.Editor) {
        Platform = other.Platform;
      }
      if (other.HeadIcon != 0) {
        HeadIcon = other.HeadIcon;
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
      if (other.RemarkName.Length != 0) {
        RemarkName = other.RemarkName;
      }
      if (other.Nickname.Length != 0) {
        Nickname = other.Nickname;
      }
      if (other.Uid != 0) {
        Uid = other.Uid;
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
            AEOHJINGIFK = input.ReadString();
            break;
          }
          case 24: {
            Platform = (global::EggLink.DanhengServer.Proto.PlatformType) input.ReadEnum();
            break;
          }
          case 40: {
            Uid = input.ReadUInt32();
            break;
          }
          case 50: {
            RemarkName = input.ReadString();
            break;
          }
          case 72: {
            Level = input.ReadUInt32();
            break;
          }
          case 88: {
            NFPKMONKKIH = input.ReadUInt32();
            break;
          }
          case 106: {
            Nickname = input.ReadString();
            break;
          }
          case 112: {
            HeadIcon = input.ReadUInt32();
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
            AEOHJINGIFK = input.ReadString();
            break;
          }
          case 24: {
            Platform = (global::EggLink.DanhengServer.Proto.PlatformType) input.ReadEnum();
            break;
          }
          case 40: {
            Uid = input.ReadUInt32();
            break;
          }
          case 50: {
            RemarkName = input.ReadString();
            break;
          }
          case 72: {
            Level = input.ReadUInt32();
            break;
          }
          case 88: {
            NFPKMONKKIH = input.ReadUInt32();
            break;
          }
          case 106: {
            Nickname = input.ReadString();
            break;
          }
          case 112: {
            HeadIcon = input.ReadUInt32();
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