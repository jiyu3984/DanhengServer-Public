// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueDoGambleScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueDoGambleScRsp.proto</summary>
  public static partial class RogueDoGambleScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueDoGambleScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueDoGambleScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhSb2d1ZURvR2FtYmxlU2NSc3AucHJvdG8aFVJvZ3VlR2FtYmxlSW5mby5w",
            "cm90byJ2ChJSb2d1ZURvR2FtYmxlU2NSc3ASEwoLTlBGTEhOSkFNQU4YBSAB",
            "KA0SEwoLTkRCQUFLQU9KUE0YBiABKA0SJQoLZ2FtYmxlX2luZm8YAiABKAsy",
            "EC5Sb2d1ZUdhbWJsZUluZm8SDwoHcmV0Y29kZRgLIAEoDUIeqgIbRWdnTGlu",
            "ay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueGambleInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueDoGambleScRsp), global::EggLink.DanhengServer.Proto.RogueDoGambleScRsp.Parser, new[]{ "NPFLHNJAMAN", "NDBAAKAOJPM", "GambleInfo", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueDoGambleScRsp : pb::IMessage<RogueDoGambleScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueDoGambleScRsp> _parser = new pb::MessageParser<RogueDoGambleScRsp>(() => new RogueDoGambleScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueDoGambleScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueDoGambleScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueDoGambleScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueDoGambleScRsp(RogueDoGambleScRsp other) : this() {
      nPFLHNJAMAN_ = other.nPFLHNJAMAN_;
      nDBAAKAOJPM_ = other.nDBAAKAOJPM_;
      gambleInfo_ = other.gambleInfo_ != null ? other.gambleInfo_.Clone() : null;
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueDoGambleScRsp Clone() {
      return new RogueDoGambleScRsp(this);
    }

    /// <summary>Field number for the "NPFLHNJAMAN" field.</summary>
    public const int NPFLHNJAMANFieldNumber = 5;
    private uint nPFLHNJAMAN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NPFLHNJAMAN {
      get { return nPFLHNJAMAN_; }
      set {
        nPFLHNJAMAN_ = value;
      }
    }

    /// <summary>Field number for the "NDBAAKAOJPM" field.</summary>
    public const int NDBAAKAOJPMFieldNumber = 6;
    private uint nDBAAKAOJPM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NDBAAKAOJPM {
      get { return nDBAAKAOJPM_; }
      set {
        nDBAAKAOJPM_ = value;
      }
    }

    /// <summary>Field number for the "gamble_info" field.</summary>
    public const int GambleInfoFieldNumber = 2;
    private global::EggLink.DanhengServer.Proto.RogueGambleInfo gambleInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueGambleInfo GambleInfo {
      get { return gambleInfo_; }
      set {
        gambleInfo_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 11;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueDoGambleScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueDoGambleScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (NPFLHNJAMAN != other.NPFLHNJAMAN) return false;
      if (NDBAAKAOJPM != other.NDBAAKAOJPM) return false;
      if (!object.Equals(GambleInfo, other.GambleInfo)) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (NPFLHNJAMAN != 0) hash ^= NPFLHNJAMAN.GetHashCode();
      if (NDBAAKAOJPM != 0) hash ^= NDBAAKAOJPM.GetHashCode();
      if (gambleInfo_ != null) hash ^= GambleInfo.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
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
      if (gambleInfo_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(GambleInfo);
      }
      if (NPFLHNJAMAN != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(NPFLHNJAMAN);
      }
      if (NDBAAKAOJPM != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(NDBAAKAOJPM);
      }
      if (Retcode != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Retcode);
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
      if (gambleInfo_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(GambleInfo);
      }
      if (NPFLHNJAMAN != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(NPFLHNJAMAN);
      }
      if (NDBAAKAOJPM != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(NDBAAKAOJPM);
      }
      if (Retcode != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Retcode);
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
      if (NPFLHNJAMAN != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NPFLHNJAMAN);
      }
      if (NDBAAKAOJPM != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NDBAAKAOJPM);
      }
      if (gambleInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GambleInfo);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueDoGambleScRsp other) {
      if (other == null) {
        return;
      }
      if (other.NPFLHNJAMAN != 0) {
        NPFLHNJAMAN = other.NPFLHNJAMAN;
      }
      if (other.NDBAAKAOJPM != 0) {
        NDBAAKAOJPM = other.NDBAAKAOJPM;
      }
      if (other.gambleInfo_ != null) {
        if (gambleInfo_ == null) {
          GambleInfo = new global::EggLink.DanhengServer.Proto.RogueGambleInfo();
        }
        GambleInfo.MergeFrom(other.GambleInfo);
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
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
            if (gambleInfo_ == null) {
              GambleInfo = new global::EggLink.DanhengServer.Proto.RogueGambleInfo();
            }
            input.ReadMessage(GambleInfo);
            break;
          }
          case 40: {
            NPFLHNJAMAN = input.ReadUInt32();
            break;
          }
          case 48: {
            NDBAAKAOJPM = input.ReadUInt32();
            break;
          }
          case 88: {
            Retcode = input.ReadUInt32();
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
            if (gambleInfo_ == null) {
              GambleInfo = new global::EggLink.DanhengServer.Proto.RogueGambleInfo();
            }
            input.ReadMessage(GambleInfo);
            break;
          }
          case 40: {
            NPFLHNJAMAN = input.ReadUInt32();
            break;
          }
          case 48: {
            NDBAAKAOJPM = input.ReadUInt32();
            break;
          }
          case 88: {
            Retcode = input.ReadUInt32();
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
