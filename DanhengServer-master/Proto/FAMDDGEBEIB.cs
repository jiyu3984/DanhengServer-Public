// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FAMDDGEBEIB.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from FAMDDGEBEIB.proto</summary>
  public static partial class FAMDDGEBEIBReflection {

    #region Descriptor
    /// <summary>File descriptor for FAMDDGEBEIB.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FAMDDGEBEIBReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFGQU1EREdFQkVJQi5wcm90byI3CgtGQU1EREdFQkVJQhITCgtOUEdORUtN",
            "Q05NThgLIAEoDRITCgtPSk1QQkJHR0VGShgPIAEoCEIeqgIbRWdnTGluay5E",
            "YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.FAMDDGEBEIB), global::EggLink.DanhengServer.Proto.FAMDDGEBEIB.Parser, new[]{ "NPGNEKMCNMN", "OJMPBBGGEFJ" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class FAMDDGEBEIB : pb::IMessage<FAMDDGEBEIB>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FAMDDGEBEIB> _parser = new pb::MessageParser<FAMDDGEBEIB>(() => new FAMDDGEBEIB());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FAMDDGEBEIB> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.FAMDDGEBEIBReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FAMDDGEBEIB() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FAMDDGEBEIB(FAMDDGEBEIB other) : this() {
      nPGNEKMCNMN_ = other.nPGNEKMCNMN_;
      oJMPBBGGEFJ_ = other.oJMPBBGGEFJ_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FAMDDGEBEIB Clone() {
      return new FAMDDGEBEIB(this);
    }

    /// <summary>Field number for the "NPGNEKMCNMN" field.</summary>
    public const int NPGNEKMCNMNFieldNumber = 11;
    private uint nPGNEKMCNMN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NPGNEKMCNMN {
      get { return nPGNEKMCNMN_; }
      set {
        nPGNEKMCNMN_ = value;
      }
    }

    /// <summary>Field number for the "OJMPBBGGEFJ" field.</summary>
    public const int OJMPBBGGEFJFieldNumber = 15;
    private bool oJMPBBGGEFJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool OJMPBBGGEFJ {
      get { return oJMPBBGGEFJ_; }
      set {
        oJMPBBGGEFJ_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FAMDDGEBEIB);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FAMDDGEBEIB other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (NPGNEKMCNMN != other.NPGNEKMCNMN) return false;
      if (OJMPBBGGEFJ != other.OJMPBBGGEFJ) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (NPGNEKMCNMN != 0) hash ^= NPGNEKMCNMN.GetHashCode();
      if (OJMPBBGGEFJ != false) hash ^= OJMPBBGGEFJ.GetHashCode();
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
      if (NPGNEKMCNMN != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(NPGNEKMCNMN);
      }
      if (OJMPBBGGEFJ != false) {
        output.WriteRawTag(120);
        output.WriteBool(OJMPBBGGEFJ);
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
      if (NPGNEKMCNMN != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(NPGNEKMCNMN);
      }
      if (OJMPBBGGEFJ != false) {
        output.WriteRawTag(120);
        output.WriteBool(OJMPBBGGEFJ);
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
      if (NPGNEKMCNMN != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NPGNEKMCNMN);
      }
      if (OJMPBBGGEFJ != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FAMDDGEBEIB other) {
      if (other == null) {
        return;
      }
      if (other.NPGNEKMCNMN != 0) {
        NPGNEKMCNMN = other.NPGNEKMCNMN;
      }
      if (other.OJMPBBGGEFJ != false) {
        OJMPBBGGEFJ = other.OJMPBBGGEFJ;
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
          case 88: {
            NPGNEKMCNMN = input.ReadUInt32();
            break;
          }
          case 120: {
            OJMPBBGGEFJ = input.ReadBool();
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
          case 88: {
            NPGNEKMCNMN = input.ReadUInt32();
            break;
          }
          case 120: {
            OJMPBBGGEFJ = input.ReadBool();
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