// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerLoginScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from PlayerLoginScRsp.proto</summary>
  public static partial class PlayerLoginScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerLoginScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerLoginScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZQbGF5ZXJMb2dpblNjUnNwLnByb3RvGhVQbGF5ZXJCYXNpY0luZm8ucHJv",
            "dG8i9wEKEFBsYXllckxvZ2luU2NSc3ASEwoLQUpQQkRERUNDSkcYDSABKAgS",
            "DwoHc3RhbWluYRgBIAEoDRIUCgxsb2dpbl9yYW5kb20YDyABKAQSEwoLQklH",
            "QUdBR0JKSEsYCCABKAkSFAoMY3VyX3RpbWV6b25lGAwgASgREg8KB3JldGNv",
            "ZGUYAiABKA0SJAoKYmFzaWNfaW5mbxgJIAEoCzIQLlBsYXllckJhc2ljSW5m",
            "bxIbChNzZXJ2ZXJfdGltZXN0YW1wX21zGAcgASgEEhMKC09KTkZNQ0xIS0VE",
            "GAQgASgJEhMKC0pIUEVBQ0RHRVBMGAsgASgIQh6qAhtFZ2dMaW5rLkRhbmhl",
            "bmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.PlayerBasicInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.PlayerLoginScRsp), global::EggLink.DanhengServer.Proto.PlayerLoginScRsp.Parser, new[]{ "AJPBDDECCJG", "Stamina", "LoginRandom", "BIGAGAGBJHK", "CurTimezone", "Retcode", "BasicInfo", "ServerTimestampMs", "OJNFMCLHKED", "JHPEACDGEPL" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class PlayerLoginScRsp : pb::IMessage<PlayerLoginScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerLoginScRsp> _parser = new pb::MessageParser<PlayerLoginScRsp>(() => new PlayerLoginScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerLoginScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.PlayerLoginScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerLoginScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerLoginScRsp(PlayerLoginScRsp other) : this() {
      aJPBDDECCJG_ = other.aJPBDDECCJG_;
      stamina_ = other.stamina_;
      loginRandom_ = other.loginRandom_;
      bIGAGAGBJHK_ = other.bIGAGAGBJHK_;
      curTimezone_ = other.curTimezone_;
      retcode_ = other.retcode_;
      basicInfo_ = other.basicInfo_ != null ? other.basicInfo_.Clone() : null;
      serverTimestampMs_ = other.serverTimestampMs_;
      oJNFMCLHKED_ = other.oJNFMCLHKED_;
      jHPEACDGEPL_ = other.jHPEACDGEPL_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerLoginScRsp Clone() {
      return new PlayerLoginScRsp(this);
    }

    /// <summary>Field number for the "AJPBDDECCJG" field.</summary>
    public const int AJPBDDECCJGFieldNumber = 13;
    private bool aJPBDDECCJG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool AJPBDDECCJG {
      get { return aJPBDDECCJG_; }
      set {
        aJPBDDECCJG_ = value;
      }
    }

    /// <summary>Field number for the "stamina" field.</summary>
    public const int StaminaFieldNumber = 1;
    private uint stamina_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Stamina {
      get { return stamina_; }
      set {
        stamina_ = value;
      }
    }

    /// <summary>Field number for the "login_random" field.</summary>
    public const int LoginRandomFieldNumber = 15;
    private ulong loginRandom_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong LoginRandom {
      get { return loginRandom_; }
      set {
        loginRandom_ = value;
      }
    }

    /// <summary>Field number for the "BIGAGAGBJHK" field.</summary>
    public const int BIGAGAGBJHKFieldNumber = 8;
    private string bIGAGAGBJHK_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string BIGAGAGBJHK {
      get { return bIGAGAGBJHK_; }
      set {
        bIGAGAGBJHK_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "cur_timezone" field.</summary>
    public const int CurTimezoneFieldNumber = 12;
    private int curTimezone_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CurTimezone {
      get { return curTimezone_; }
      set {
        curTimezone_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 2;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "basic_info" field.</summary>
    public const int BasicInfoFieldNumber = 9;
    private global::EggLink.DanhengServer.Proto.PlayerBasicInfo basicInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.PlayerBasicInfo BasicInfo {
      get { return basicInfo_; }
      set {
        basicInfo_ = value;
      }
    }

    /// <summary>Field number for the "server_timestamp_ms" field.</summary>
    public const int ServerTimestampMsFieldNumber = 7;
    private ulong serverTimestampMs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong ServerTimestampMs {
      get { return serverTimestampMs_; }
      set {
        serverTimestampMs_ = value;
      }
    }

    /// <summary>Field number for the "OJNFMCLHKED" field.</summary>
    public const int OJNFMCLHKEDFieldNumber = 4;
    private string oJNFMCLHKED_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string OJNFMCLHKED {
      get { return oJNFMCLHKED_; }
      set {
        oJNFMCLHKED_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "JHPEACDGEPL" field.</summary>
    public const int JHPEACDGEPLFieldNumber = 11;
    private bool jHPEACDGEPL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool JHPEACDGEPL {
      get { return jHPEACDGEPL_; }
      set {
        jHPEACDGEPL_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerLoginScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerLoginScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AJPBDDECCJG != other.AJPBDDECCJG) return false;
      if (Stamina != other.Stamina) return false;
      if (LoginRandom != other.LoginRandom) return false;
      if (BIGAGAGBJHK != other.BIGAGAGBJHK) return false;
      if (CurTimezone != other.CurTimezone) return false;
      if (Retcode != other.Retcode) return false;
      if (!object.Equals(BasicInfo, other.BasicInfo)) return false;
      if (ServerTimestampMs != other.ServerTimestampMs) return false;
      if (OJNFMCLHKED != other.OJNFMCLHKED) return false;
      if (JHPEACDGEPL != other.JHPEACDGEPL) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (AJPBDDECCJG != false) hash ^= AJPBDDECCJG.GetHashCode();
      if (Stamina != 0) hash ^= Stamina.GetHashCode();
      if (LoginRandom != 0UL) hash ^= LoginRandom.GetHashCode();
      if (BIGAGAGBJHK.Length != 0) hash ^= BIGAGAGBJHK.GetHashCode();
      if (CurTimezone != 0) hash ^= CurTimezone.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (basicInfo_ != null) hash ^= BasicInfo.GetHashCode();
      if (ServerTimestampMs != 0UL) hash ^= ServerTimestampMs.GetHashCode();
      if (OJNFMCLHKED.Length != 0) hash ^= OJNFMCLHKED.GetHashCode();
      if (JHPEACDGEPL != false) hash ^= JHPEACDGEPL.GetHashCode();
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
      if (Stamina != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Stamina);
      }
      if (Retcode != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Retcode);
      }
      if (OJNFMCLHKED.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(OJNFMCLHKED);
      }
      if (ServerTimestampMs != 0UL) {
        output.WriteRawTag(56);
        output.WriteUInt64(ServerTimestampMs);
      }
      if (BIGAGAGBJHK.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(BIGAGAGBJHK);
      }
      if (basicInfo_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(BasicInfo);
      }
      if (JHPEACDGEPL != false) {
        output.WriteRawTag(88);
        output.WriteBool(JHPEACDGEPL);
      }
      if (CurTimezone != 0) {
        output.WriteRawTag(96);
        output.WriteSInt32(CurTimezone);
      }
      if (AJPBDDECCJG != false) {
        output.WriteRawTag(104);
        output.WriteBool(AJPBDDECCJG);
      }
      if (LoginRandom != 0UL) {
        output.WriteRawTag(120);
        output.WriteUInt64(LoginRandom);
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
      if (Stamina != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Stamina);
      }
      if (Retcode != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Retcode);
      }
      if (OJNFMCLHKED.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(OJNFMCLHKED);
      }
      if (ServerTimestampMs != 0UL) {
        output.WriteRawTag(56);
        output.WriteUInt64(ServerTimestampMs);
      }
      if (BIGAGAGBJHK.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(BIGAGAGBJHK);
      }
      if (basicInfo_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(BasicInfo);
      }
      if (JHPEACDGEPL != false) {
        output.WriteRawTag(88);
        output.WriteBool(JHPEACDGEPL);
      }
      if (CurTimezone != 0) {
        output.WriteRawTag(96);
        output.WriteSInt32(CurTimezone);
      }
      if (AJPBDDECCJG != false) {
        output.WriteRawTag(104);
        output.WriteBool(AJPBDDECCJG);
      }
      if (LoginRandom != 0UL) {
        output.WriteRawTag(120);
        output.WriteUInt64(LoginRandom);
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
      if (AJPBDDECCJG != false) {
        size += 1 + 1;
      }
      if (Stamina != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Stamina);
      }
      if (LoginRandom != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(LoginRandom);
      }
      if (BIGAGAGBJHK.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BIGAGAGBJHK);
      }
      if (CurTimezone != 0) {
        size += 1 + pb::CodedOutputStream.ComputeSInt32Size(CurTimezone);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (basicInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BasicInfo);
      }
      if (ServerTimestampMs != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(ServerTimestampMs);
      }
      if (OJNFMCLHKED.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(OJNFMCLHKED);
      }
      if (JHPEACDGEPL != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerLoginScRsp other) {
      if (other == null) {
        return;
      }
      if (other.AJPBDDECCJG != false) {
        AJPBDDECCJG = other.AJPBDDECCJG;
      }
      if (other.Stamina != 0) {
        Stamina = other.Stamina;
      }
      if (other.LoginRandom != 0UL) {
        LoginRandom = other.LoginRandom;
      }
      if (other.BIGAGAGBJHK.Length != 0) {
        BIGAGAGBJHK = other.BIGAGAGBJHK;
      }
      if (other.CurTimezone != 0) {
        CurTimezone = other.CurTimezone;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.basicInfo_ != null) {
        if (basicInfo_ == null) {
          BasicInfo = new global::EggLink.DanhengServer.Proto.PlayerBasicInfo();
        }
        BasicInfo.MergeFrom(other.BasicInfo);
      }
      if (other.ServerTimestampMs != 0UL) {
        ServerTimestampMs = other.ServerTimestampMs;
      }
      if (other.OJNFMCLHKED.Length != 0) {
        OJNFMCLHKED = other.OJNFMCLHKED;
      }
      if (other.JHPEACDGEPL != false) {
        JHPEACDGEPL = other.JHPEACDGEPL;
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
            Stamina = input.ReadUInt32();
            break;
          }
          case 16: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 34: {
            OJNFMCLHKED = input.ReadString();
            break;
          }
          case 56: {
            ServerTimestampMs = input.ReadUInt64();
            break;
          }
          case 66: {
            BIGAGAGBJHK = input.ReadString();
            break;
          }
          case 74: {
            if (basicInfo_ == null) {
              BasicInfo = new global::EggLink.DanhengServer.Proto.PlayerBasicInfo();
            }
            input.ReadMessage(BasicInfo);
            break;
          }
          case 88: {
            JHPEACDGEPL = input.ReadBool();
            break;
          }
          case 96: {
            CurTimezone = input.ReadSInt32();
            break;
          }
          case 104: {
            AJPBDDECCJG = input.ReadBool();
            break;
          }
          case 120: {
            LoginRandom = input.ReadUInt64();
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
            Stamina = input.ReadUInt32();
            break;
          }
          case 16: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 34: {
            OJNFMCLHKED = input.ReadString();
            break;
          }
          case 56: {
            ServerTimestampMs = input.ReadUInt64();
            break;
          }
          case 66: {
            BIGAGAGBJHK = input.ReadString();
            break;
          }
          case 74: {
            if (basicInfo_ == null) {
              BasicInfo = new global::EggLink.DanhengServer.Proto.PlayerBasicInfo();
            }
            input.ReadMessage(BasicInfo);
            break;
          }
          case 88: {
            JHPEACDGEPL = input.ReadBool();
            break;
          }
          case 96: {
            CurTimezone = input.ReadSInt32();
            break;
          }
          case 104: {
            AJPBDDECCJG = input.ReadBool();
            break;
          }
          case 120: {
            LoginRandom = input.ReadUInt64();
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