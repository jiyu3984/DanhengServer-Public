// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: APLMIDIJFFA.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from APLMIDIJFFA.proto</summary>
  public static partial class APLMIDIJFFAReflection {

    #region Descriptor
    /// <summary>File descriptor for APLMIDIJFFA.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static APLMIDIJFFAReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFBUExNSURJSkZGQS5wcm90bxoRR0pQTERFTk9QRU4ucHJvdG8aEUtQR1BH",
            "S0pERklJLnByb3RvGhFCR0JETE9QTk1BQS5wcm90byKUAQoLQVBMTUlESUpG",
            "RkESIwoLS09IR0FPS05HSkkYCCABKAsyDC5CR0JETE9QTk1BQUgAEiMKC0RD",
            "Q0NJSEVLSEZPGAkgASgLMgwuR0pQTERFTk9QRU5IABIsChRGVU5DX1VOTE9D",
            "S19JRF9SRUxJQxgNIAEoCzIMLktQR1BHS0pERklJSABCDQoLRU1JTE5JRlBD",
            "RE5CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.GJPLDENOPENReflection.Descriptor, global::EggLink.DanhengServer.Proto.KPGPGKJDFIIReflection.Descriptor, global::EggLink.DanhengServer.Proto.BGBDLOPNMAAReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.APLMIDIJFFA), global::EggLink.DanhengServer.Proto.APLMIDIJFFA.Parser, new[]{ "KOHGAOKNGJI", "DCCCIHEKHFO", "FUNCUNLOCKIDRELIC" }, new[]{ "EMILNIFPCDN" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class APLMIDIJFFA : pb::IMessage<APLMIDIJFFA>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<APLMIDIJFFA> _parser = new pb::MessageParser<APLMIDIJFFA>(() => new APLMIDIJFFA());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<APLMIDIJFFA> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.APLMIDIJFFAReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public APLMIDIJFFA() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public APLMIDIJFFA(APLMIDIJFFA other) : this() {
      switch (other.EMILNIFPCDNCase) {
        case EMILNIFPCDNOneofCase.KOHGAOKNGJI:
          KOHGAOKNGJI = other.KOHGAOKNGJI.Clone();
          break;
        case EMILNIFPCDNOneofCase.DCCCIHEKHFO:
          DCCCIHEKHFO = other.DCCCIHEKHFO.Clone();
          break;
        case EMILNIFPCDNOneofCase.FUNCUNLOCKIDRELIC:
          FUNCUNLOCKIDRELIC = other.FUNCUNLOCKIDRELIC.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public APLMIDIJFFA Clone() {
      return new APLMIDIJFFA(this);
    }

    /// <summary>Field number for the "KOHGAOKNGJI" field.</summary>
    public const int KOHGAOKNGJIFieldNumber = 8;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.BGBDLOPNMAA KOHGAOKNGJI {
      get { return eMILNIFPCDNCase_ == EMILNIFPCDNOneofCase.KOHGAOKNGJI ? (global::EggLink.DanhengServer.Proto.BGBDLOPNMAA) eMILNIFPCDN_ : null; }
      set {
        eMILNIFPCDN_ = value;
        eMILNIFPCDNCase_ = value == null ? EMILNIFPCDNOneofCase.None : EMILNIFPCDNOneofCase.KOHGAOKNGJI;
      }
    }

    /// <summary>Field number for the "DCCCIHEKHFO" field.</summary>
    public const int DCCCIHEKHFOFieldNumber = 9;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.GJPLDENOPEN DCCCIHEKHFO {
      get { return eMILNIFPCDNCase_ == EMILNIFPCDNOneofCase.DCCCIHEKHFO ? (global::EggLink.DanhengServer.Proto.GJPLDENOPEN) eMILNIFPCDN_ : null; }
      set {
        eMILNIFPCDN_ = value;
        eMILNIFPCDNCase_ = value == null ? EMILNIFPCDNOneofCase.None : EMILNIFPCDNOneofCase.DCCCIHEKHFO;
      }
    }

    /// <summary>Field number for the "FUNC_UNLOCK_ID_RELIC" field.</summary>
    public const int FUNCUNLOCKIDRELICFieldNumber = 13;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.KPGPGKJDFII FUNCUNLOCKIDRELIC {
      get { return eMILNIFPCDNCase_ == EMILNIFPCDNOneofCase.FUNCUNLOCKIDRELIC ? (global::EggLink.DanhengServer.Proto.KPGPGKJDFII) eMILNIFPCDN_ : null; }
      set {
        eMILNIFPCDN_ = value;
        eMILNIFPCDNCase_ = value == null ? EMILNIFPCDNOneofCase.None : EMILNIFPCDNOneofCase.FUNCUNLOCKIDRELIC;
      }
    }

    private object eMILNIFPCDN_;
    /// <summary>Enum of possible cases for the "EMILNIFPCDN" oneof.</summary>
    public enum EMILNIFPCDNOneofCase {
      None = 0,
      KOHGAOKNGJI = 8,
      DCCCIHEKHFO = 9,
      FUNCUNLOCKIDRELIC = 13,
    }
    private EMILNIFPCDNOneofCase eMILNIFPCDNCase_ = EMILNIFPCDNOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EMILNIFPCDNOneofCase EMILNIFPCDNCase {
      get { return eMILNIFPCDNCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearEMILNIFPCDN() {
      eMILNIFPCDNCase_ = EMILNIFPCDNOneofCase.None;
      eMILNIFPCDN_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as APLMIDIJFFA);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(APLMIDIJFFA other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(KOHGAOKNGJI, other.KOHGAOKNGJI)) return false;
      if (!object.Equals(DCCCIHEKHFO, other.DCCCIHEKHFO)) return false;
      if (!object.Equals(FUNCUNLOCKIDRELIC, other.FUNCUNLOCKIDRELIC)) return false;
      if (EMILNIFPCDNCase != other.EMILNIFPCDNCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (eMILNIFPCDNCase_ == EMILNIFPCDNOneofCase.KOHGAOKNGJI) hash ^= KOHGAOKNGJI.GetHashCode();
      if (eMILNIFPCDNCase_ == EMILNIFPCDNOneofCase.DCCCIHEKHFO) hash ^= DCCCIHEKHFO.GetHashCode();
      if (eMILNIFPCDNCase_ == EMILNIFPCDNOneofCase.FUNCUNLOCKIDRELIC) hash ^= FUNCUNLOCKIDRELIC.GetHashCode();
      hash ^= (int) eMILNIFPCDNCase_;
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
      if (eMILNIFPCDNCase_ == EMILNIFPCDNOneofCase.KOHGAOKNGJI) {
        output.WriteRawTag(66);
        output.WriteMessage(KOHGAOKNGJI);
      }
      if (eMILNIFPCDNCase_ == EMILNIFPCDNOneofCase.DCCCIHEKHFO) {
        output.WriteRawTag(74);
        output.WriteMessage(DCCCIHEKHFO);
      }
      if (eMILNIFPCDNCase_ == EMILNIFPCDNOneofCase.FUNCUNLOCKIDRELIC) {
        output.WriteRawTag(106);
        output.WriteMessage(FUNCUNLOCKIDRELIC);
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
      if (eMILNIFPCDNCase_ == EMILNIFPCDNOneofCase.KOHGAOKNGJI) {
        output.WriteRawTag(66);
        output.WriteMessage(KOHGAOKNGJI);
      }
      if (eMILNIFPCDNCase_ == EMILNIFPCDNOneofCase.DCCCIHEKHFO) {
        output.WriteRawTag(74);
        output.WriteMessage(DCCCIHEKHFO);
      }
      if (eMILNIFPCDNCase_ == EMILNIFPCDNOneofCase.FUNCUNLOCKIDRELIC) {
        output.WriteRawTag(106);
        output.WriteMessage(FUNCUNLOCKIDRELIC);
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
      if (eMILNIFPCDNCase_ == EMILNIFPCDNOneofCase.KOHGAOKNGJI) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(KOHGAOKNGJI);
      }
      if (eMILNIFPCDNCase_ == EMILNIFPCDNOneofCase.DCCCIHEKHFO) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DCCCIHEKHFO);
      }
      if (eMILNIFPCDNCase_ == EMILNIFPCDNOneofCase.FUNCUNLOCKIDRELIC) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FUNCUNLOCKIDRELIC);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(APLMIDIJFFA other) {
      if (other == null) {
        return;
      }
      switch (other.EMILNIFPCDNCase) {
        case EMILNIFPCDNOneofCase.KOHGAOKNGJI:
          if (KOHGAOKNGJI == null) {
            KOHGAOKNGJI = new global::EggLink.DanhengServer.Proto.BGBDLOPNMAA();
          }
          KOHGAOKNGJI.MergeFrom(other.KOHGAOKNGJI);
          break;
        case EMILNIFPCDNOneofCase.DCCCIHEKHFO:
          if (DCCCIHEKHFO == null) {
            DCCCIHEKHFO = new global::EggLink.DanhengServer.Proto.GJPLDENOPEN();
          }
          DCCCIHEKHFO.MergeFrom(other.DCCCIHEKHFO);
          break;
        case EMILNIFPCDNOneofCase.FUNCUNLOCKIDRELIC:
          if (FUNCUNLOCKIDRELIC == null) {
            FUNCUNLOCKIDRELIC = new global::EggLink.DanhengServer.Proto.KPGPGKJDFII();
          }
          FUNCUNLOCKIDRELIC.MergeFrom(other.FUNCUNLOCKIDRELIC);
          break;
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
          case 66: {
            global::EggLink.DanhengServer.Proto.BGBDLOPNMAA subBuilder = new global::EggLink.DanhengServer.Proto.BGBDLOPNMAA();
            if (eMILNIFPCDNCase_ == EMILNIFPCDNOneofCase.KOHGAOKNGJI) {
              subBuilder.MergeFrom(KOHGAOKNGJI);
            }
            input.ReadMessage(subBuilder);
            KOHGAOKNGJI = subBuilder;
            break;
          }
          case 74: {
            global::EggLink.DanhengServer.Proto.GJPLDENOPEN subBuilder = new global::EggLink.DanhengServer.Proto.GJPLDENOPEN();
            if (eMILNIFPCDNCase_ == EMILNIFPCDNOneofCase.DCCCIHEKHFO) {
              subBuilder.MergeFrom(DCCCIHEKHFO);
            }
            input.ReadMessage(subBuilder);
            DCCCIHEKHFO = subBuilder;
            break;
          }
          case 106: {
            global::EggLink.DanhengServer.Proto.KPGPGKJDFII subBuilder = new global::EggLink.DanhengServer.Proto.KPGPGKJDFII();
            if (eMILNIFPCDNCase_ == EMILNIFPCDNOneofCase.FUNCUNLOCKIDRELIC) {
              subBuilder.MergeFrom(FUNCUNLOCKIDRELIC);
            }
            input.ReadMessage(subBuilder);
            FUNCUNLOCKIDRELIC = subBuilder;
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
          case 66: {
            global::EggLink.DanhengServer.Proto.BGBDLOPNMAA subBuilder = new global::EggLink.DanhengServer.Proto.BGBDLOPNMAA();
            if (eMILNIFPCDNCase_ == EMILNIFPCDNOneofCase.KOHGAOKNGJI) {
              subBuilder.MergeFrom(KOHGAOKNGJI);
            }
            input.ReadMessage(subBuilder);
            KOHGAOKNGJI = subBuilder;
            break;
          }
          case 74: {
            global::EggLink.DanhengServer.Proto.GJPLDENOPEN subBuilder = new global::EggLink.DanhengServer.Proto.GJPLDENOPEN();
            if (eMILNIFPCDNCase_ == EMILNIFPCDNOneofCase.DCCCIHEKHFO) {
              subBuilder.MergeFrom(DCCCIHEKHFO);
            }
            input.ReadMessage(subBuilder);
            DCCCIHEKHFO = subBuilder;
            break;
          }
          case 106: {
            global::EggLink.DanhengServer.Proto.KPGPGKJDFII subBuilder = new global::EggLink.DanhengServer.Proto.KPGPGKJDFII();
            if (eMILNIFPCDNCase_ == EMILNIFPCDNOneofCase.FUNCUNLOCKIDRELIC) {
              subBuilder.MergeFrom(FUNCUNLOCKIDRELIC);
            }
            input.ReadMessage(subBuilder);
            FUNCUNLOCKIDRELIC = subBuilder;
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