// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: StartPunkLordRaidScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from StartPunkLordRaidScRsp.proto</summary>
  public static partial class StartPunkLordRaidScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for StartPunkLordRaidScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StartPunkLordRaidScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxTdGFydFB1bmtMb3JkUmFpZFNjUnNwLnByb3RvGhFFSEFQTUdJTEdPTS5w",
            "cm90bxoRQ0hNQk5GSkpJSk4ucHJvdG8iqAEKFlN0YXJ0UHVua0xvcmRSYWlk",
            "U2NSc3ASDwoHcmV0Y29kZRgLIAEoDRITCgtKQ0pKRU1CRktHQhgMIAEoCBIb",
            "CgVzY2VuZRgDIAEoCzIMLkNITUJORkpKSUpOEiEKC1BKTERJTExPRkxPGA0g",
            "ASgLMgwuRUhBUE1HSUxHT00SEwoLQ0lLSkRBSE1JSk4YByABKAMSEwoLR0hP",
            "RkNQSUxITkIYBCADKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90",
            "b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.EHAPMGILGOMReflection.Descriptor, global::EggLink.DanhengServer.Proto.CHMBNFJJIJNReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.StartPunkLordRaidScRsp), global::EggLink.DanhengServer.Proto.StartPunkLordRaidScRsp.Parser, new[]{ "Retcode", "JCJJEMBFKGB", "Scene", "PJLDILLOFLO", "CIKJDAHMIJN", "GHOFCPILHNB" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class StartPunkLordRaidScRsp : pb::IMessage<StartPunkLordRaidScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<StartPunkLordRaidScRsp> _parser = new pb::MessageParser<StartPunkLordRaidScRsp>(() => new StartPunkLordRaidScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<StartPunkLordRaidScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.StartPunkLordRaidScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartPunkLordRaidScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartPunkLordRaidScRsp(StartPunkLordRaidScRsp other) : this() {
      retcode_ = other.retcode_;
      jCJJEMBFKGB_ = other.jCJJEMBFKGB_;
      scene_ = other.scene_ != null ? other.scene_.Clone() : null;
      pJLDILLOFLO_ = other.pJLDILLOFLO_ != null ? other.pJLDILLOFLO_.Clone() : null;
      cIKJDAHMIJN_ = other.cIKJDAHMIJN_;
      gHOFCPILHNB_ = other.gHOFCPILHNB_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartPunkLordRaidScRsp Clone() {
      return new StartPunkLordRaidScRsp(this);
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

    /// <summary>Field number for the "JCJJEMBFKGB" field.</summary>
    public const int JCJJEMBFKGBFieldNumber = 12;
    private bool jCJJEMBFKGB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool JCJJEMBFKGB {
      get { return jCJJEMBFKGB_; }
      set {
        jCJJEMBFKGB_ = value;
      }
    }

    /// <summary>Field number for the "scene" field.</summary>
    public const int SceneFieldNumber = 3;
    private global::EggLink.DanhengServer.Proto.CHMBNFJJIJN scene_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.CHMBNFJJIJN Scene {
      get { return scene_; }
      set {
        scene_ = value;
      }
    }

    /// <summary>Field number for the "PJLDILLOFLO" field.</summary>
    public const int PJLDILLOFLOFieldNumber = 13;
    private global::EggLink.DanhengServer.Proto.EHAPMGILGOM pJLDILLOFLO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.EHAPMGILGOM PJLDILLOFLO {
      get { return pJLDILLOFLO_; }
      set {
        pJLDILLOFLO_ = value;
      }
    }

    /// <summary>Field number for the "CIKJDAHMIJN" field.</summary>
    public const int CIKJDAHMIJNFieldNumber = 7;
    private long cIKJDAHMIJN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long CIKJDAHMIJN {
      get { return cIKJDAHMIJN_; }
      set {
        cIKJDAHMIJN_ = value;
      }
    }

    /// <summary>Field number for the "GHOFCPILHNB" field.</summary>
    public const int GHOFCPILHNBFieldNumber = 4;
    private static readonly pb::FieldCodec<uint> _repeated_gHOFCPILHNB_codec
        = pb::FieldCodec.ForUInt32(34);
    private readonly pbc::RepeatedField<uint> gHOFCPILHNB_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> GHOFCPILHNB {
      get { return gHOFCPILHNB_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as StartPunkLordRaidScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(StartPunkLordRaidScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (JCJJEMBFKGB != other.JCJJEMBFKGB) return false;
      if (!object.Equals(Scene, other.Scene)) return false;
      if (!object.Equals(PJLDILLOFLO, other.PJLDILLOFLO)) return false;
      if (CIKJDAHMIJN != other.CIKJDAHMIJN) return false;
      if(!gHOFCPILHNB_.Equals(other.gHOFCPILHNB_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (JCJJEMBFKGB != false) hash ^= JCJJEMBFKGB.GetHashCode();
      if (scene_ != null) hash ^= Scene.GetHashCode();
      if (pJLDILLOFLO_ != null) hash ^= PJLDILLOFLO.GetHashCode();
      if (CIKJDAHMIJN != 0L) hash ^= CIKJDAHMIJN.GetHashCode();
      hash ^= gHOFCPILHNB_.GetHashCode();
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
      if (scene_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Scene);
      }
      gHOFCPILHNB_.WriteTo(output, _repeated_gHOFCPILHNB_codec);
      if (CIKJDAHMIJN != 0L) {
        output.WriteRawTag(56);
        output.WriteInt64(CIKJDAHMIJN);
      }
      if (Retcode != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Retcode);
      }
      if (JCJJEMBFKGB != false) {
        output.WriteRawTag(96);
        output.WriteBool(JCJJEMBFKGB);
      }
      if (pJLDILLOFLO_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(PJLDILLOFLO);
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
      if (scene_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Scene);
      }
      gHOFCPILHNB_.WriteTo(ref output, _repeated_gHOFCPILHNB_codec);
      if (CIKJDAHMIJN != 0L) {
        output.WriteRawTag(56);
        output.WriteInt64(CIKJDAHMIJN);
      }
      if (Retcode != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Retcode);
      }
      if (JCJJEMBFKGB != false) {
        output.WriteRawTag(96);
        output.WriteBool(JCJJEMBFKGB);
      }
      if (pJLDILLOFLO_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(PJLDILLOFLO);
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
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (JCJJEMBFKGB != false) {
        size += 1 + 1;
      }
      if (scene_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Scene);
      }
      if (pJLDILLOFLO_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PJLDILLOFLO);
      }
      if (CIKJDAHMIJN != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(CIKJDAHMIJN);
      }
      size += gHOFCPILHNB_.CalculateSize(_repeated_gHOFCPILHNB_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(StartPunkLordRaidScRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.JCJJEMBFKGB != false) {
        JCJJEMBFKGB = other.JCJJEMBFKGB;
      }
      if (other.scene_ != null) {
        if (scene_ == null) {
          Scene = new global::EggLink.DanhengServer.Proto.CHMBNFJJIJN();
        }
        Scene.MergeFrom(other.Scene);
      }
      if (other.pJLDILLOFLO_ != null) {
        if (pJLDILLOFLO_ == null) {
          PJLDILLOFLO = new global::EggLink.DanhengServer.Proto.EHAPMGILGOM();
        }
        PJLDILLOFLO.MergeFrom(other.PJLDILLOFLO);
      }
      if (other.CIKJDAHMIJN != 0L) {
        CIKJDAHMIJN = other.CIKJDAHMIJN;
      }
      gHOFCPILHNB_.Add(other.gHOFCPILHNB_);
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
          case 26: {
            if (scene_ == null) {
              Scene = new global::EggLink.DanhengServer.Proto.CHMBNFJJIJN();
            }
            input.ReadMessage(Scene);
            break;
          }
          case 34:
          case 32: {
            gHOFCPILHNB_.AddEntriesFrom(input, _repeated_gHOFCPILHNB_codec);
            break;
          }
          case 56: {
            CIKJDAHMIJN = input.ReadInt64();
            break;
          }
          case 88: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 96: {
            JCJJEMBFKGB = input.ReadBool();
            break;
          }
          case 106: {
            if (pJLDILLOFLO_ == null) {
              PJLDILLOFLO = new global::EggLink.DanhengServer.Proto.EHAPMGILGOM();
            }
            input.ReadMessage(PJLDILLOFLO);
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
          case 26: {
            if (scene_ == null) {
              Scene = new global::EggLink.DanhengServer.Proto.CHMBNFJJIJN();
            }
            input.ReadMessage(Scene);
            break;
          }
          case 34:
          case 32: {
            gHOFCPILHNB_.AddEntriesFrom(ref input, _repeated_gHOFCPILHNB_codec);
            break;
          }
          case 56: {
            CIKJDAHMIJN = input.ReadInt64();
            break;
          }
          case 88: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 96: {
            JCJJEMBFKGB = input.ReadBool();
            break;
          }
          case 106: {
            if (pJLDILLOFLO_ == null) {
              PJLDILLOFLO = new global::EggLink.DanhengServer.Proto.EHAPMGILGOM();
            }
            input.ReadMessage(PJLDILLOFLO);
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