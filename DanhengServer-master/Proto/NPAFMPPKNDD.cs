// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: NPAFMPPKNDD.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from NPAFMPPKNDD.proto</summary>
  public static partial class NPAFMPPKNDDReflection {

    #region Descriptor
    /// <summary>File descriptor for NPAFMPPKNDD.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static NPAFMPPKNDDReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFOUEFGTVBQS05ERC5wcm90bxoOSXRlbUxpc3QucHJvdG8ioQEKC05QQUZN",
            "UFBLTkREEhMKC0JHRkVLSEZNRUlIGAwgASgIEhAKCHByb2dyZXNzGAUgASgN",
            "EhMKC0NBRklOSkxBQ1BKGAogASgIEhEKCXNjcmlwdF9pZBgDIAEoDRIZCgZy",
            "ZXdhcmQYCSABKAsyCS5JdGVtTGlzdBITCgtBTUJDQkNMSElIShgCIAEoDRIT",
            "CgtDT0pCRUJJTkNNTBgGIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVy",
            "LlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ItemListReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.NPAFMPPKNDD), global::EggLink.DanhengServer.Proto.NPAFMPPKNDD.Parser, new[]{ "BGFEKHFMEIH", "Progress", "CAFINJLACPJ", "ScriptId", "Reward", "AMBCBCLHIHJ", "COJBEBINCML" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class NPAFMPPKNDD : pb::IMessage<NPAFMPPKNDD>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<NPAFMPPKNDD> _parser = new pb::MessageParser<NPAFMPPKNDD>(() => new NPAFMPPKNDD());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<NPAFMPPKNDD> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.NPAFMPPKNDDReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NPAFMPPKNDD() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NPAFMPPKNDD(NPAFMPPKNDD other) : this() {
      bGFEKHFMEIH_ = other.bGFEKHFMEIH_;
      progress_ = other.progress_;
      cAFINJLACPJ_ = other.cAFINJLACPJ_;
      scriptId_ = other.scriptId_;
      reward_ = other.reward_ != null ? other.reward_.Clone() : null;
      aMBCBCLHIHJ_ = other.aMBCBCLHIHJ_;
      cOJBEBINCML_ = other.cOJBEBINCML_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NPAFMPPKNDD Clone() {
      return new NPAFMPPKNDD(this);
    }

    /// <summary>Field number for the "BGFEKHFMEIH" field.</summary>
    public const int BGFEKHFMEIHFieldNumber = 12;
    private bool bGFEKHFMEIH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool BGFEKHFMEIH {
      get { return bGFEKHFMEIH_; }
      set {
        bGFEKHFMEIH_ = value;
      }
    }

    /// <summary>Field number for the "progress" field.</summary>
    public const int ProgressFieldNumber = 5;
    private uint progress_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Progress {
      get { return progress_; }
      set {
        progress_ = value;
      }
    }

    /// <summary>Field number for the "CAFINJLACPJ" field.</summary>
    public const int CAFINJLACPJFieldNumber = 10;
    private bool cAFINJLACPJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool CAFINJLACPJ {
      get { return cAFINJLACPJ_; }
      set {
        cAFINJLACPJ_ = value;
      }
    }

    /// <summary>Field number for the "script_id" field.</summary>
    public const int ScriptIdFieldNumber = 3;
    private uint scriptId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ScriptId {
      get { return scriptId_; }
      set {
        scriptId_ = value;
      }
    }

    /// <summary>Field number for the "reward" field.</summary>
    public const int RewardFieldNumber = 9;
    private global::EggLink.DanhengServer.Proto.ItemList reward_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemList Reward {
      get { return reward_; }
      set {
        reward_ = value;
      }
    }

    /// <summary>Field number for the "AMBCBCLHIHJ" field.</summary>
    public const int AMBCBCLHIHJFieldNumber = 2;
    private uint aMBCBCLHIHJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AMBCBCLHIHJ {
      get { return aMBCBCLHIHJ_; }
      set {
        aMBCBCLHIHJ_ = value;
      }
    }

    /// <summary>Field number for the "COJBEBINCML" field.</summary>
    public const int COJBEBINCMLFieldNumber = 6;
    private uint cOJBEBINCML_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint COJBEBINCML {
      get { return cOJBEBINCML_; }
      set {
        cOJBEBINCML_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as NPAFMPPKNDD);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(NPAFMPPKNDD other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BGFEKHFMEIH != other.BGFEKHFMEIH) return false;
      if (Progress != other.Progress) return false;
      if (CAFINJLACPJ != other.CAFINJLACPJ) return false;
      if (ScriptId != other.ScriptId) return false;
      if (!object.Equals(Reward, other.Reward)) return false;
      if (AMBCBCLHIHJ != other.AMBCBCLHIHJ) return false;
      if (COJBEBINCML != other.COJBEBINCML) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (BGFEKHFMEIH != false) hash ^= BGFEKHFMEIH.GetHashCode();
      if (Progress != 0) hash ^= Progress.GetHashCode();
      if (CAFINJLACPJ != false) hash ^= CAFINJLACPJ.GetHashCode();
      if (ScriptId != 0) hash ^= ScriptId.GetHashCode();
      if (reward_ != null) hash ^= Reward.GetHashCode();
      if (AMBCBCLHIHJ != 0) hash ^= AMBCBCLHIHJ.GetHashCode();
      if (COJBEBINCML != 0) hash ^= COJBEBINCML.GetHashCode();
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
      if (AMBCBCLHIHJ != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(AMBCBCLHIHJ);
      }
      if (ScriptId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ScriptId);
      }
      if (Progress != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Progress);
      }
      if (COJBEBINCML != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(COJBEBINCML);
      }
      if (reward_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(Reward);
      }
      if (CAFINJLACPJ != false) {
        output.WriteRawTag(80);
        output.WriteBool(CAFINJLACPJ);
      }
      if (BGFEKHFMEIH != false) {
        output.WriteRawTag(96);
        output.WriteBool(BGFEKHFMEIH);
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
      if (AMBCBCLHIHJ != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(AMBCBCLHIHJ);
      }
      if (ScriptId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ScriptId);
      }
      if (Progress != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Progress);
      }
      if (COJBEBINCML != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(COJBEBINCML);
      }
      if (reward_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(Reward);
      }
      if (CAFINJLACPJ != false) {
        output.WriteRawTag(80);
        output.WriteBool(CAFINJLACPJ);
      }
      if (BGFEKHFMEIH != false) {
        output.WriteRawTag(96);
        output.WriteBool(BGFEKHFMEIH);
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
      if (BGFEKHFMEIH != false) {
        size += 1 + 1;
      }
      if (Progress != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Progress);
      }
      if (CAFINJLACPJ != false) {
        size += 1 + 1;
      }
      if (ScriptId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ScriptId);
      }
      if (reward_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Reward);
      }
      if (AMBCBCLHIHJ != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AMBCBCLHIHJ);
      }
      if (COJBEBINCML != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(COJBEBINCML);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(NPAFMPPKNDD other) {
      if (other == null) {
        return;
      }
      if (other.BGFEKHFMEIH != false) {
        BGFEKHFMEIH = other.BGFEKHFMEIH;
      }
      if (other.Progress != 0) {
        Progress = other.Progress;
      }
      if (other.CAFINJLACPJ != false) {
        CAFINJLACPJ = other.CAFINJLACPJ;
      }
      if (other.ScriptId != 0) {
        ScriptId = other.ScriptId;
      }
      if (other.reward_ != null) {
        if (reward_ == null) {
          Reward = new global::EggLink.DanhengServer.Proto.ItemList();
        }
        Reward.MergeFrom(other.Reward);
      }
      if (other.AMBCBCLHIHJ != 0) {
        AMBCBCLHIHJ = other.AMBCBCLHIHJ;
      }
      if (other.COJBEBINCML != 0) {
        COJBEBINCML = other.COJBEBINCML;
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
          case 16: {
            AMBCBCLHIHJ = input.ReadUInt32();
            break;
          }
          case 24: {
            ScriptId = input.ReadUInt32();
            break;
          }
          case 40: {
            Progress = input.ReadUInt32();
            break;
          }
          case 48: {
            COJBEBINCML = input.ReadUInt32();
            break;
          }
          case 74: {
            if (reward_ == null) {
              Reward = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(Reward);
            break;
          }
          case 80: {
            CAFINJLACPJ = input.ReadBool();
            break;
          }
          case 96: {
            BGFEKHFMEIH = input.ReadBool();
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
          case 16: {
            AMBCBCLHIHJ = input.ReadUInt32();
            break;
          }
          case 24: {
            ScriptId = input.ReadUInt32();
            break;
          }
          case 40: {
            Progress = input.ReadUInt32();
            break;
          }
          case 48: {
            COJBEBINCML = input.ReadUInt32();
            break;
          }
          case 74: {
            if (reward_ == null) {
              Reward = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(Reward);
            break;
          }
          case 80: {
            CAFINJLACPJ = input.ReadBool();
            break;
          }
          case 96: {
            BGFEKHFMEIH = input.ReadBool();
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