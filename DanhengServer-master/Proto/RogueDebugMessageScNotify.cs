// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueDebugMessageScNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueDebugMessageScNotify.proto</summary>
  public static partial class RogueDebugMessageScNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueDebugMessageScNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueDebugMessageScNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9Sb2d1ZURlYnVnTWVzc2FnZVNjTm90aWZ5LnByb3RvGhtSb2d1ZURlYnVn",
            "TWVzc2FnZVR5cGUucHJvdG8iawoZUm9ndWVEZWJ1Z01lc3NhZ2VTY05vdGlm",
            "eRITCgtLQUxGTlBKQkZJTBgFIAEoCRIkCgR0eXBlGA0gASgOMhYuUm9ndWVE",
            "ZWJ1Z01lc3NhZ2VUeXBlEhMKC01NUExNSUFGS0ZDGAggASgJQh6qAhtFZ2dM",
            "aW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueDebugMessageTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueDebugMessageScNotify), global::EggLink.DanhengServer.Proto.RogueDebugMessageScNotify.Parser, new[]{ "KALFNPJBFIL", "Type", "MMPLMIAFKFC" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueDebugMessageScNotify : pb::IMessage<RogueDebugMessageScNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueDebugMessageScNotify> _parser = new pb::MessageParser<RogueDebugMessageScNotify>(() => new RogueDebugMessageScNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueDebugMessageScNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueDebugMessageScNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueDebugMessageScNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueDebugMessageScNotify(RogueDebugMessageScNotify other) : this() {
      kALFNPJBFIL_ = other.kALFNPJBFIL_;
      type_ = other.type_;
      mMPLMIAFKFC_ = other.mMPLMIAFKFC_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueDebugMessageScNotify Clone() {
      return new RogueDebugMessageScNotify(this);
    }

    /// <summary>Field number for the "KALFNPJBFIL" field.</summary>
    public const int KALFNPJBFILFieldNumber = 5;
    private string kALFNPJBFIL_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string KALFNPJBFIL {
      get { return kALFNPJBFIL_; }
      set {
        kALFNPJBFIL_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 13;
    private global::EggLink.DanhengServer.Proto.RogueDebugMessageType type_ = global::EggLink.DanhengServer.Proto.RogueDebugMessageType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueDebugMessageType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "MMPLMIAFKFC" field.</summary>
    public const int MMPLMIAFKFCFieldNumber = 8;
    private string mMPLMIAFKFC_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string MMPLMIAFKFC {
      get { return mMPLMIAFKFC_; }
      set {
        mMPLMIAFKFC_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueDebugMessageScNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueDebugMessageScNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (KALFNPJBFIL != other.KALFNPJBFIL) return false;
      if (Type != other.Type) return false;
      if (MMPLMIAFKFC != other.MMPLMIAFKFC) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (KALFNPJBFIL.Length != 0) hash ^= KALFNPJBFIL.GetHashCode();
      if (Type != global::EggLink.DanhengServer.Proto.RogueDebugMessageType.None) hash ^= Type.GetHashCode();
      if (MMPLMIAFKFC.Length != 0) hash ^= MMPLMIAFKFC.GetHashCode();
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
      if (KALFNPJBFIL.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(KALFNPJBFIL);
      }
      if (MMPLMIAFKFC.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(MMPLMIAFKFC);
      }
      if (Type != global::EggLink.DanhengServer.Proto.RogueDebugMessageType.None) {
        output.WriteRawTag(104);
        output.WriteEnum((int) Type);
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
      if (KALFNPJBFIL.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(KALFNPJBFIL);
      }
      if (MMPLMIAFKFC.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(MMPLMIAFKFC);
      }
      if (Type != global::EggLink.DanhengServer.Proto.RogueDebugMessageType.None) {
        output.WriteRawTag(104);
        output.WriteEnum((int) Type);
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
      if (KALFNPJBFIL.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(KALFNPJBFIL);
      }
      if (Type != global::EggLink.DanhengServer.Proto.RogueDebugMessageType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (MMPLMIAFKFC.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MMPLMIAFKFC);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueDebugMessageScNotify other) {
      if (other == null) {
        return;
      }
      if (other.KALFNPJBFIL.Length != 0) {
        KALFNPJBFIL = other.KALFNPJBFIL;
      }
      if (other.Type != global::EggLink.DanhengServer.Proto.RogueDebugMessageType.None) {
        Type = other.Type;
      }
      if (other.MMPLMIAFKFC.Length != 0) {
        MMPLMIAFKFC = other.MMPLMIAFKFC;
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
          case 42: {
            KALFNPJBFIL = input.ReadString();
            break;
          }
          case 66: {
            MMPLMIAFKFC = input.ReadString();
            break;
          }
          case 104: {
            Type = (global::EggLink.DanhengServer.Proto.RogueDebugMessageType) input.ReadEnum();
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
          case 42: {
            KALFNPJBFIL = input.ReadString();
            break;
          }
          case 66: {
            MMPLMIAFKFC = input.ReadString();
            break;
          }
          case 104: {
            Type = (global::EggLink.DanhengServer.Proto.RogueDebugMessageType) input.ReadEnum();
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
