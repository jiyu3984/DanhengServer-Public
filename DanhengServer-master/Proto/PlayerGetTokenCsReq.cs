// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerGetTokenCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from PlayerGetTokenCsReq.proto</summary>
  public static partial class PlayerGetTokenCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerGetTokenCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerGetTokenCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlQbGF5ZXJHZXRUb2tlbkNzUmVxLnByb3RvIqwBChNQbGF5ZXJHZXRUb2tl",
            "bkNzUmVxEhMKC0ZDTENDQ05CRExCGAMgASgNEgsKA3VpZBgBIAEoDRIQCghw",
            "bGF0Zm9ybRgNIAEoDRITCgtBT0RKTkRDUERJRBgPIAEoDRITCgtCSURBRUZM",
            "R0JBThgCIAEoCRITCgtHSEtQQlBERklKSBgJIAEoDRITCgthY2NvdW50X3Vp",
            "ZBgFIAEoCRINCgV0b2tlbhgHIAEoCUIeqgIbRWdnTGluay5EYW5oZW5nU2Vy",
            "dmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.PlayerGetTokenCsReq), global::EggLink.DanhengServer.Proto.PlayerGetTokenCsReq.Parser, new[]{ "FCLCCCNBDLB", "Uid", "Platform", "AODJNDCPDID", "BIDAEFLGBAN", "GHKPBPDFIJH", "AccountUid", "Token" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class PlayerGetTokenCsReq : pb::IMessage<PlayerGetTokenCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerGetTokenCsReq> _parser = new pb::MessageParser<PlayerGetTokenCsReq>(() => new PlayerGetTokenCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerGetTokenCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.PlayerGetTokenCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerGetTokenCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerGetTokenCsReq(PlayerGetTokenCsReq other) : this() {
      fCLCCCNBDLB_ = other.fCLCCCNBDLB_;
      uid_ = other.uid_;
      platform_ = other.platform_;
      aODJNDCPDID_ = other.aODJNDCPDID_;
      bIDAEFLGBAN_ = other.bIDAEFLGBAN_;
      gHKPBPDFIJH_ = other.gHKPBPDFIJH_;
      accountUid_ = other.accountUid_;
      token_ = other.token_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerGetTokenCsReq Clone() {
      return new PlayerGetTokenCsReq(this);
    }

    /// <summary>Field number for the "FCLCCCNBDLB" field.</summary>
    public const int FCLCCCNBDLBFieldNumber = 3;
    private uint fCLCCCNBDLB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FCLCCCNBDLB {
      get { return fCLCCCNBDLB_; }
      set {
        fCLCCCNBDLB_ = value;
      }
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

    /// <summary>Field number for the "platform" field.</summary>
    public const int PlatformFieldNumber = 13;
    private uint platform_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Platform {
      get { return platform_; }
      set {
        platform_ = value;
      }
    }

    /// <summary>Field number for the "AODJNDCPDID" field.</summary>
    public const int AODJNDCPDIDFieldNumber = 15;
    private uint aODJNDCPDID_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AODJNDCPDID {
      get { return aODJNDCPDID_; }
      set {
        aODJNDCPDID_ = value;
      }
    }

    /// <summary>Field number for the "BIDAEFLGBAN" field.</summary>
    public const int BIDAEFLGBANFieldNumber = 2;
    private string bIDAEFLGBAN_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string BIDAEFLGBAN {
      get { return bIDAEFLGBAN_; }
      set {
        bIDAEFLGBAN_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "GHKPBPDFIJH" field.</summary>
    public const int GHKPBPDFIJHFieldNumber = 9;
    private uint gHKPBPDFIJH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GHKPBPDFIJH {
      get { return gHKPBPDFIJH_; }
      set {
        gHKPBPDFIJH_ = value;
      }
    }

    /// <summary>Field number for the "account_uid" field.</summary>
    public const int AccountUidFieldNumber = 5;
    private string accountUid_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string AccountUid {
      get { return accountUid_; }
      set {
        accountUid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "token" field.</summary>
    public const int TokenFieldNumber = 7;
    private string token_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Token {
      get { return token_; }
      set {
        token_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerGetTokenCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerGetTokenCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FCLCCCNBDLB != other.FCLCCCNBDLB) return false;
      if (Uid != other.Uid) return false;
      if (Platform != other.Platform) return false;
      if (AODJNDCPDID != other.AODJNDCPDID) return false;
      if (BIDAEFLGBAN != other.BIDAEFLGBAN) return false;
      if (GHKPBPDFIJH != other.GHKPBPDFIJH) return false;
      if (AccountUid != other.AccountUid) return false;
      if (Token != other.Token) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (FCLCCCNBDLB != 0) hash ^= FCLCCCNBDLB.GetHashCode();
      if (Uid != 0) hash ^= Uid.GetHashCode();
      if (Platform != 0) hash ^= Platform.GetHashCode();
      if (AODJNDCPDID != 0) hash ^= AODJNDCPDID.GetHashCode();
      if (BIDAEFLGBAN.Length != 0) hash ^= BIDAEFLGBAN.GetHashCode();
      if (GHKPBPDFIJH != 0) hash ^= GHKPBPDFIJH.GetHashCode();
      if (AccountUid.Length != 0) hash ^= AccountUid.GetHashCode();
      if (Token.Length != 0) hash ^= Token.GetHashCode();
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
      if (BIDAEFLGBAN.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(BIDAEFLGBAN);
      }
      if (FCLCCCNBDLB != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(FCLCCCNBDLB);
      }
      if (AccountUid.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(AccountUid);
      }
      if (Token.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Token);
      }
      if (GHKPBPDFIJH != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(GHKPBPDFIJH);
      }
      if (Platform != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Platform);
      }
      if (AODJNDCPDID != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(AODJNDCPDID);
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
      if (BIDAEFLGBAN.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(BIDAEFLGBAN);
      }
      if (FCLCCCNBDLB != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(FCLCCCNBDLB);
      }
      if (AccountUid.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(AccountUid);
      }
      if (Token.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Token);
      }
      if (GHKPBPDFIJH != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(GHKPBPDFIJH);
      }
      if (Platform != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Platform);
      }
      if (AODJNDCPDID != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(AODJNDCPDID);
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
      if (FCLCCCNBDLB != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FCLCCCNBDLB);
      }
      if (Uid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Uid);
      }
      if (Platform != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Platform);
      }
      if (AODJNDCPDID != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AODJNDCPDID);
      }
      if (BIDAEFLGBAN.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BIDAEFLGBAN);
      }
      if (GHKPBPDFIJH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GHKPBPDFIJH);
      }
      if (AccountUid.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AccountUid);
      }
      if (Token.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Token);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerGetTokenCsReq other) {
      if (other == null) {
        return;
      }
      if (other.FCLCCCNBDLB != 0) {
        FCLCCCNBDLB = other.FCLCCCNBDLB;
      }
      if (other.Uid != 0) {
        Uid = other.Uid;
      }
      if (other.Platform != 0) {
        Platform = other.Platform;
      }
      if (other.AODJNDCPDID != 0) {
        AODJNDCPDID = other.AODJNDCPDID;
      }
      if (other.BIDAEFLGBAN.Length != 0) {
        BIDAEFLGBAN = other.BIDAEFLGBAN;
      }
      if (other.GHKPBPDFIJH != 0) {
        GHKPBPDFIJH = other.GHKPBPDFIJH;
      }
      if (other.AccountUid.Length != 0) {
        AccountUid = other.AccountUid;
      }
      if (other.Token.Length != 0) {
        Token = other.Token;
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
          case 18: {
            BIDAEFLGBAN = input.ReadString();
            break;
          }
          case 24: {
            FCLCCCNBDLB = input.ReadUInt32();
            break;
          }
          case 42: {
            AccountUid = input.ReadString();
            break;
          }
          case 58: {
            Token = input.ReadString();
            break;
          }
          case 72: {
            GHKPBPDFIJH = input.ReadUInt32();
            break;
          }
          case 104: {
            Platform = input.ReadUInt32();
            break;
          }
          case 120: {
            AODJNDCPDID = input.ReadUInt32();
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
          case 18: {
            BIDAEFLGBAN = input.ReadString();
            break;
          }
          case 24: {
            FCLCCCNBDLB = input.ReadUInt32();
            break;
          }
          case 42: {
            AccountUid = input.ReadString();
            break;
          }
          case 58: {
            Token = input.ReadString();
            break;
          }
          case 72: {
            GHKPBPDFIJH = input.ReadUInt32();
            break;
          }
          case 104: {
            Platform = input.ReadUInt32();
            break;
          }
          case 120: {
            AODJNDCPDID = input.ReadUInt32();
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
