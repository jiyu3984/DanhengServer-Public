// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ADKIDBBBHNC.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ADKIDBBBHNC.proto</summary>
  public static partial class ADKIDBBBHNCReflection {

    #region Descriptor
    /// <summary>File descriptor for ADKIDBBBHNC.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ADKIDBBBHNCReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFBREtJREJCQkhOQy5wcm90bxoRSE5JQkpDR0hDQU4ucHJvdG8aEUtQQ0VG",
            "SEpCT1BGLnByb3RvInwKC0FES0lEQkJCSE5DEhQKC1BGRUtPRUlIQklKGJsO",
            "IAEoDRIjCgtKTktDSkdNT09GSxgPIAEoCzIMLkhOSUJKQ0dIQ0FOSAASIwoL",
            "RkxMTUpLSUVGRE0YDSABKAsyDC5LUENFRkhKQk9QRkgAQg0KC0lPTUFCUEtK",
            "SkZKQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.HNIBJCGHCANReflection.Descriptor, global::EggLink.DanhengServer.Proto.KPCEFHJBOPFReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ADKIDBBBHNC), global::EggLink.DanhengServer.Proto.ADKIDBBBHNC.Parser, new[]{ "PFEKOEIHBIJ", "JNKCJGMOOFK", "FLLMJKIEFDM" }, new[]{ "IOMABPKJJFJ" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ADKIDBBBHNC : pb::IMessage<ADKIDBBBHNC>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ADKIDBBBHNC> _parser = new pb::MessageParser<ADKIDBBBHNC>(() => new ADKIDBBBHNC());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ADKIDBBBHNC> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ADKIDBBBHNCReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ADKIDBBBHNC() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ADKIDBBBHNC(ADKIDBBBHNC other) : this() {
      pFEKOEIHBIJ_ = other.pFEKOEIHBIJ_;
      switch (other.IOMABPKJJFJCase) {
        case IOMABPKJJFJOneofCase.JNKCJGMOOFK:
          JNKCJGMOOFK = other.JNKCJGMOOFK.Clone();
          break;
        case IOMABPKJJFJOneofCase.FLLMJKIEFDM:
          FLLMJKIEFDM = other.FLLMJKIEFDM.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ADKIDBBBHNC Clone() {
      return new ADKIDBBBHNC(this);
    }

    /// <summary>Field number for the "PFEKOEIHBIJ" field.</summary>
    public const int PFEKOEIHBIJFieldNumber = 1819;
    private uint pFEKOEIHBIJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PFEKOEIHBIJ {
      get { return pFEKOEIHBIJ_; }
      set {
        pFEKOEIHBIJ_ = value;
      }
    }

    /// <summary>Field number for the "JNKCJGMOOFK" field.</summary>
    public const int JNKCJGMOOFKFieldNumber = 15;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.HNIBJCGHCAN JNKCJGMOOFK {
      get { return iOMABPKJJFJCase_ == IOMABPKJJFJOneofCase.JNKCJGMOOFK ? (global::EggLink.DanhengServer.Proto.HNIBJCGHCAN) iOMABPKJJFJ_ : null; }
      set {
        iOMABPKJJFJ_ = value;
        iOMABPKJJFJCase_ = value == null ? IOMABPKJJFJOneofCase.None : IOMABPKJJFJOneofCase.JNKCJGMOOFK;
      }
    }

    /// <summary>Field number for the "FLLMJKIEFDM" field.</summary>
    public const int FLLMJKIEFDMFieldNumber = 13;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.KPCEFHJBOPF FLLMJKIEFDM {
      get { return iOMABPKJJFJCase_ == IOMABPKJJFJOneofCase.FLLMJKIEFDM ? (global::EggLink.DanhengServer.Proto.KPCEFHJBOPF) iOMABPKJJFJ_ : null; }
      set {
        iOMABPKJJFJ_ = value;
        iOMABPKJJFJCase_ = value == null ? IOMABPKJJFJOneofCase.None : IOMABPKJJFJOneofCase.FLLMJKIEFDM;
      }
    }

    private object iOMABPKJJFJ_;
    /// <summary>Enum of possible cases for the "IOMABPKJJFJ" oneof.</summary>
    public enum IOMABPKJJFJOneofCase {
      None = 0,
      JNKCJGMOOFK = 15,
      FLLMJKIEFDM = 13,
    }
    private IOMABPKJJFJOneofCase iOMABPKJJFJCase_ = IOMABPKJJFJOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IOMABPKJJFJOneofCase IOMABPKJJFJCase {
      get { return iOMABPKJJFJCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearIOMABPKJJFJ() {
      iOMABPKJJFJCase_ = IOMABPKJJFJOneofCase.None;
      iOMABPKJJFJ_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ADKIDBBBHNC);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ADKIDBBBHNC other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PFEKOEIHBIJ != other.PFEKOEIHBIJ) return false;
      if (!object.Equals(JNKCJGMOOFK, other.JNKCJGMOOFK)) return false;
      if (!object.Equals(FLLMJKIEFDM, other.FLLMJKIEFDM)) return false;
      if (IOMABPKJJFJCase != other.IOMABPKJJFJCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (PFEKOEIHBIJ != 0) hash ^= PFEKOEIHBIJ.GetHashCode();
      if (iOMABPKJJFJCase_ == IOMABPKJJFJOneofCase.JNKCJGMOOFK) hash ^= JNKCJGMOOFK.GetHashCode();
      if (iOMABPKJJFJCase_ == IOMABPKJJFJOneofCase.FLLMJKIEFDM) hash ^= FLLMJKIEFDM.GetHashCode();
      hash ^= (int) iOMABPKJJFJCase_;
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
      if (iOMABPKJJFJCase_ == IOMABPKJJFJOneofCase.FLLMJKIEFDM) {
        output.WriteRawTag(106);
        output.WriteMessage(FLLMJKIEFDM);
      }
      if (iOMABPKJJFJCase_ == IOMABPKJJFJOneofCase.JNKCJGMOOFK) {
        output.WriteRawTag(122);
        output.WriteMessage(JNKCJGMOOFK);
      }
      if (PFEKOEIHBIJ != 0) {
        output.WriteRawTag(216, 113);
        output.WriteUInt32(PFEKOEIHBIJ);
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
      if (iOMABPKJJFJCase_ == IOMABPKJJFJOneofCase.FLLMJKIEFDM) {
        output.WriteRawTag(106);
        output.WriteMessage(FLLMJKIEFDM);
      }
      if (iOMABPKJJFJCase_ == IOMABPKJJFJOneofCase.JNKCJGMOOFK) {
        output.WriteRawTag(122);
        output.WriteMessage(JNKCJGMOOFK);
      }
      if (PFEKOEIHBIJ != 0) {
        output.WriteRawTag(216, 113);
        output.WriteUInt32(PFEKOEIHBIJ);
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
      if (PFEKOEIHBIJ != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(PFEKOEIHBIJ);
      }
      if (iOMABPKJJFJCase_ == IOMABPKJJFJOneofCase.JNKCJGMOOFK) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(JNKCJGMOOFK);
      }
      if (iOMABPKJJFJCase_ == IOMABPKJJFJOneofCase.FLLMJKIEFDM) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FLLMJKIEFDM);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ADKIDBBBHNC other) {
      if (other == null) {
        return;
      }
      if (other.PFEKOEIHBIJ != 0) {
        PFEKOEIHBIJ = other.PFEKOEIHBIJ;
      }
      switch (other.IOMABPKJJFJCase) {
        case IOMABPKJJFJOneofCase.JNKCJGMOOFK:
          if (JNKCJGMOOFK == null) {
            JNKCJGMOOFK = new global::EggLink.DanhengServer.Proto.HNIBJCGHCAN();
          }
          JNKCJGMOOFK.MergeFrom(other.JNKCJGMOOFK);
          break;
        case IOMABPKJJFJOneofCase.FLLMJKIEFDM:
          if (FLLMJKIEFDM == null) {
            FLLMJKIEFDM = new global::EggLink.DanhengServer.Proto.KPCEFHJBOPF();
          }
          FLLMJKIEFDM.MergeFrom(other.FLLMJKIEFDM);
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
          case 106: {
            global::EggLink.DanhengServer.Proto.KPCEFHJBOPF subBuilder = new global::EggLink.DanhengServer.Proto.KPCEFHJBOPF();
            if (iOMABPKJJFJCase_ == IOMABPKJJFJOneofCase.FLLMJKIEFDM) {
              subBuilder.MergeFrom(FLLMJKIEFDM);
            }
            input.ReadMessage(subBuilder);
            FLLMJKIEFDM = subBuilder;
            break;
          }
          case 122: {
            global::EggLink.DanhengServer.Proto.HNIBJCGHCAN subBuilder = new global::EggLink.DanhengServer.Proto.HNIBJCGHCAN();
            if (iOMABPKJJFJCase_ == IOMABPKJJFJOneofCase.JNKCJGMOOFK) {
              subBuilder.MergeFrom(JNKCJGMOOFK);
            }
            input.ReadMessage(subBuilder);
            JNKCJGMOOFK = subBuilder;
            break;
          }
          case 14552: {
            PFEKOEIHBIJ = input.ReadUInt32();
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
          case 106: {
            global::EggLink.DanhengServer.Proto.KPCEFHJBOPF subBuilder = new global::EggLink.DanhengServer.Proto.KPCEFHJBOPF();
            if (iOMABPKJJFJCase_ == IOMABPKJJFJOneofCase.FLLMJKIEFDM) {
              subBuilder.MergeFrom(FLLMJKIEFDM);
            }
            input.ReadMessage(subBuilder);
            FLLMJKIEFDM = subBuilder;
            break;
          }
          case 122: {
            global::EggLink.DanhengServer.Proto.HNIBJCGHCAN subBuilder = new global::EggLink.DanhengServer.Proto.HNIBJCGHCAN();
            if (iOMABPKJJFJCase_ == IOMABPKJJFJOneofCase.JNKCJGMOOFK) {
              subBuilder.MergeFrom(JNKCJGMOOFK);
            }
            input.ReadMessage(subBuilder);
            JNKCJGMOOFK = subBuilder;
            break;
          }
          case 14552: {
            PFEKOEIHBIJ = input.ReadUInt32();
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